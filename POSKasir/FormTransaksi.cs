using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POSKasir
{
    public partial class FormTransaksi : Form
    {
        private DataTable _cart;
        private int _userId;

        public FormTransaksi(int userId)
        {
            InitializeComponent();
            _userId = userId;
            InitCart();
        }

        private void InitCart()
        {
            _cart = new DataTable();
            _cart.Columns.Add("ProductID", typeof(int));
            _cart.Columns.Add("Nama Produk", typeof(string));
            _cart.Columns.Add("Harga", typeof(decimal));
            _cart.Columns.Add("Qty", typeof(int));
            _cart.Columns.Add("SubTotal", typeof(decimal));
        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            LoadProducts();
            dgvCart.DataSource = _cart;
            dgvCart.Columns["ProductID"].Visible = false;
            dgvCart.Columns["Harga"].DefaultCellStyle.Format = "N0";
            dgvCart.Columns["Harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvCart.Columns["SubTotal"].DefaultCellStyle.Format = "N0";
            dgvCart.Columns["SubTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            UpdateTotal();
        }

        private void LoadProducts()
        {
            try
            {
                DataTable dt = DBHelper.ExecuteQuery(
                    "SELECT ProductID, ProductName, Price FROM Products WHERE Stock > 0");
                cmbProduk.DataSource = dt;
                cmbProduk.DisplayMember = "ProductName";
                cmbProduk.ValueMember = "ProductID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat produk: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTotal()
        {
            decimal total = 0;
            foreach (DataRow row in _cart.Rows)
                total += Convert.ToDecimal(row["SubTotal"]);
            lblTotal.Text = "Rp " + total.ToString("N0");
        }

        private void btnTambahItem_Click(object sender, EventArgs e)
        {
            if (cmbProduk.SelectedItem == null)
            {
                MessageBox.Show("Pilih produk terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtQty.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("Masukkan jumlah yang valid.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView selected = (DataRowView)cmbProduk.SelectedItem;
            int productId = Convert.ToInt32(selected["ProductID"]);
            string productName = selected["ProductName"].ToString();
            decimal price = Convert.ToDecimal(selected["Price"]);

            foreach (DataRow row in _cart.Rows)
            {
                if (Convert.ToInt32(row["ProductID"]) == productId)
                {
                    row["Qty"] = Convert.ToInt32(row["Qty"]) + qty;
                    row["SubTotal"] = Convert.ToDecimal(row["Harga"]) * Convert.ToInt32(row["Qty"]);
                    dgvCart.Refresh();
                    UpdateTotal();
                    txtQty.Text = "1";
                    return;
                }
            }

            _cart.Rows.Add(productId, productName, price, qty, price * qty);
            UpdateTotal();
            txtQty.Text = "1";
        }

        private void btnHapusItem_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih item yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int index = dgvCart.SelectedRows[0].Index;
            _cart.Rows[index].Delete();
            _cart.AcceptChanges();
            UpdateTotal();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (_cart.Rows.Count == 0)
            {
                MessageBox.Show("Keranjang masih kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                decimal total = 0;
                foreach (DataRow row in _cart.Rows)
                    total += Convert.ToDecimal(row["SubTotal"]);

                DataTable dtTrans = DBHelper.ExecuteQuery(
                    "INSERT INTO Transactions (UserID, TotalAmount) OUTPUT INSERTED.TransactionID VALUES (@uid, @total)",
                    new SqlParameter("@uid", _userId),
                    new SqlParameter("@total", total));

                int transId = Convert.ToInt32(dtTrans.Rows[0][0]);

                foreach (DataRow row in _cart.Rows)
                {
                    DBHelper.ExecuteNonQuery(
                        "INSERT INTO TransactionDetails (TransactionID, ProductID, Qty, SubTotal) VALUES (@tid, @pid, @qty, @sub)",
                        new SqlParameter("@tid", transId),
                        new SqlParameter("@pid", row["ProductID"]),
                        new SqlParameter("@qty", row["Qty"]),
                        new SqlParameter("@sub", row["SubTotal"]));

                    DBHelper.ExecuteNonQuery(
                        "UPDATE Products SET Stock = Stock - @qty WHERE ProductID = @pid",
                        new SqlParameter("@qty", row["Qty"]),
                        new SqlParameter("@pid", row["ProductID"]));
                }

                MessageBox.Show("Transaksi berhasil disimpan!\nTotal: Rp " + total.ToString("N0"),
                    "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _cart.Clear();
                UpdateTotal();
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan transaksi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e) => this.Close();

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void btnCariTransaksi_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = DBHelper.ExecuteQuery(
                    "SELECT t.TransactionID AS [ID], t.TransDate AS [Tanggal], " +
                    "u.Username AS [Kasir], t.TotalAmount AS [Total] " +
                    "FROM Transactions t " +
                    "JOIN Users u ON t.UserID = u.UserID " +
                    "WHERE CAST(t.TransDate AS DATE) BETWEEN @dari AND @sampai " +
                    "ORDER BY t.TransDate DESC",
                    new SqlParameter("@dari", dtpDari.Value.Date),
                    new SqlParameter("@sampai", dtpSampai.Value.Date));

                dgvLaporan.DataSource = dt;

                if (dgvLaporan.Columns["Total"] != null)
                {
                    dgvLaporan.Columns["Total"].DefaultCellStyle.Format = "N0";
                    dgvLaporan.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }

                if (dt.Rows.Count == 0)
                    MessageBox.Show("Tidak ada transaksi pada rentang tanggal tersebut.", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat laporan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POSKasir
{
    public partial class FormInputProduk : Form
    {
        private int _productId = 0;

        public FormInputProduk()
        {
            InitializeComponent();
            this.Text = "Tambah Produk";
            lblTitle.Text = "Tambah Produk";
        }

        public FormInputProduk(int productId)
        {
            InitializeComponent();
            _productId = productId;
            this.Text = "Edit Produk";
            lblTitle.Text = "Edit Produk";
            LoadProduct();
        }

        private void LoadProduct()
        {
            try
            {
                DataTable dt = DBHelper.ExecuteQuery(
                    "SELECT * FROM Products WHERE ProductID=@id",
                    new SqlParameter("@id", _productId));

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    txtNama.Text = row["ProductName"].ToString();
                    txtHarga.Text = Convert.ToDecimal(row["Price"]).ToString("0");
                    txtStok.Text = Convert.ToInt32(row["Stock"]).ToString();
                    cmbKategori.Text = row["Category"].ToString();
                }
                else
                {
                    MessageBox.Show("Data produk tidak ditemukan.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data produk:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("Nama Produk tidak boleh kosong.", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNama.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtHarga.Text))
            {
                MessageBox.Show("Harga tidak boleh kosong.", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHarga.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtStok.Text))
            {
                MessageBox.Show("Stok tidak boleh kosong.", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStok.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cmbKategori.Text))
            {
                MessageBox.Show("Kategori tidak boleh kosong.", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbKategori.Focus();
                return;
            }

            try
            {
                if (_productId == 0)
                {
                    DBHelper.ExecuteNonQuery(
                        "INSERT INTO Products (ProductName, Price, Stock, Category) VALUES (@name, @price, @stock, @cat)",
                        new SqlParameter("@name", txtNama.Text),
                        new SqlParameter("@price", decimal.Parse(txtHarga.Text)),
                        new SqlParameter("@stock", int.Parse(txtStok.Text)),
                        new SqlParameter("@cat", cmbKategori.Text));
                    MessageBox.Show("Produk berhasil ditambahkan.", "Sukses",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DBHelper.ExecuteNonQuery(
                        "UPDATE Products SET ProductName=@name, Price=@price, Stock=@stock, Category=@cat WHERE ProductID=@id",
                        new SqlParameter("@name", txtNama.Text),
                        new SqlParameter("@price", decimal.Parse(txtHarga.Text)),
                        new SqlParameter("@stock", int.Parse(txtStok.Text)),
                        new SqlParameter("@cat", cmbKategori.Text),
                        new SqlParameter("@id", _productId));
                    MessageBox.Show("Produk berhasil diperbarui.", "Sukses",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data produk:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e) => this.Close();

        private void txtHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void txtStok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void txtNama_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("Nama Produk tidak boleh kosong.", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }
    }
}

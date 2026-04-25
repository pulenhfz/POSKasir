using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POSKasir
{
    public partial class FormDataProduk : Form
    {
        private string _username;
        private string _role;
        private int _userId;

        public FormDataProduk(string username, string role, int userId)
        {
            InitializeComponent();
            _username = username;
            _role = role;
            _userId = userId;
        }

        private void FormDataProduk_Load(object sender, EventArgs e)
        {
            this.Text = "Data Produk - POS Kasir | " + _username + " (" + _role + ")";

            if (_role.ToLower() == "kasir")
            {
                btnTambah.Enabled = false;
                btnEdit.Enabled = false;
                btnHapus.Enabled = false;
                btnTambah.BackColor = System.Drawing.Color.LightGray;
                btnEdit.BackColor = System.Drawing.Color.LightGray;
                btnHapus.BackColor = System.Drawing.Color.LightGray;
            }

            LoadData();
        }

        private void LoadData(string keyword = "")
        {
            try
            {
                string query = "SELECT ProductID, ProductName AS [Nama Produk], Category AS [Kategori], " +
                               "Price AS [Harga], Stock AS [Stok] FROM Products";
                DataTable dt;

                if (!string.IsNullOrWhiteSpace(keyword))
                {
                    query += " WHERE ProductName LIKE @search";
                    dt = DBHelper.ExecuteQuery(query, new SqlParameter("@search", "%" + keyword + "%"));
                }
                else
                {
                    dt = DBHelper.ExecuteQuery(query);
                }

                dgvProduk.DataSource = dt;

                if (dgvProduk.Columns["ProductID"] != null)
                    dgvProduk.Columns["ProductID"].Visible = false;

                if (dgvProduk.Columns["Harga"] != null)
                {
                    dgvProduk.Columns["Harga"].DefaultCellStyle.Format = "N0";
                    dgvProduk.Columns["Harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            LoadData(txtCari.Text);
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FormInputProduk form = new FormInputProduk();
            form.ShowDialog();
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProduk.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih produk yang ingin diedit.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int productId = Convert.ToInt32(dgvProduk.SelectedRows[0].Cells["ProductID"].Value);
            FormInputProduk form = new FormInputProduk(productId);
            form.ShowDialog();
            LoadData();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvProduk.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih produk yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Yakin ingin menghapus produk ini?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    int productId = Convert.ToInt32(dgvProduk.SelectedRows[0].Cells["ProductID"].Value);
                    DBHelper.ExecuteNonQuery("DELETE FROM Products WHERE ProductID = @id",
                        new SqlParameter("@id", productId));
                    MessageBox.Show("Produk berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            FormTransaksi form = new FormTransaksi(_userId);
            form.ShowDialog();
            LoadData();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                "Yakin ingin logout?",
                "Konfirmasi Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                this.Hide();
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
            }
        }
    }
}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POSKasir
{
    public partial class FormLogin : Form
    {
        private bool _isClosing = false;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Username tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }
            try
            {
                DataTable dt = DBHelper.ExecuteQuery(
                    "SELECT * FROM Users WHERE Username=@user AND Password=@pass",
                    new SqlParameter("@user", txtUsername.Text),
                    new SqlParameter("@pass", txtPassword.Text));

                if (dt.Rows.Count > 0)
                {
                    string role = dt.Rows[0]["Role"].ToString();
                    string username = txtUsername.Text;
                    int userId = Convert.ToInt32(dt.Rows[0]["UserID"]);
                    MessageBox.Show("Login berhasil! Selamat datang, " + username, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormDataProduk formDataProduk = new FormDataProduk(username, role, userId);
                    formDataProduk.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username atau Password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan koneksi database:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            _isClosing = true;
            Application.Exit();
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            _isClosing = true;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnLogin_Click(sender, e);
            }
        }

        private void txtUsername_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (_isClosing) return;
            if (this.ActiveControl == btnLogin && string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Username tidak boleh kosong!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }
    }
}

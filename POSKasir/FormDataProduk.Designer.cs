namespace POSKasir
{
    partial class FormDataProduk
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCari = new System.Windows.Forms.Label();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.dgvProduk = new System.Windows.Forms.DataGridView();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnTransaksi = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvProduk)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Data Produk";

            // lblCari
            this.lblCari.AutoSize = true;
            this.lblCari.Location = new System.Drawing.Point(12, 55);
            this.lblCari.Name = "lblCari";
            this.lblCari.Text = "Cari Produk:";

            // txtCari
            this.txtCari.Location = new System.Drawing.Point(100, 52);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(250, 23);
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);

            // dgvProduk
            this.dgvProduk.AllowUserToAddRows = false;
            this.dgvProduk.Anchor = ((System.Windows.Forms.AnchorStyles)(
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right |
                System.Windows.Forms.AnchorStyles.Bottom));
            this.dgvProduk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduk.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduk.Location = new System.Drawing.Point(12, 85);
            this.dgvProduk.MultiSelect = false;
            this.dgvProduk.Name = "dgvProduk";
            this.dgvProduk.ReadOnly = true;
            this.dgvProduk.RowHeadersVisible = false;
            this.dgvProduk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduk.Size = new System.Drawing.Size(780, 330);

            // panelBottom
            this.panelBottom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBottom.Controls.Add(this.btnTambah);
            this.panelBottom.Controls.Add(this.btnEdit);
            this.panelBottom.Controls.Add(this.btnHapus);
            this.panelBottom.Controls.Add(this.btnTransaksi);
            this.panelBottom.Controls.Add(this.btnLogout);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 420);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(820, 55);

            // btnTambah
            this.btnTambah.BackColor = System.Drawing.Color.Green;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Location = new System.Drawing.Point(12, 12);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(90, 32);
            this.btnTambah.Text = "+ Tambah";
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);

            // btnEdit
            this.btnEdit.BackColor = System.Drawing.Color.Orange;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(112, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 32);
            this.btnEdit.Text = "\u270E Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            // btnHapus
            this.btnHapus.BackColor = System.Drawing.Color.Red;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Location = new System.Drawing.Point(212, 12);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(90, 32);
            this.btnHapus.Text = "\u2715 Hapus";
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);

            // btnTransaksi
            this.btnTransaksi.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaksi.ForeColor = System.Drawing.Color.White;
            this.btnTransaksi.Location = new System.Drawing.Point(412, 12);
            this.btnTransaksi.Name = "btnTransaksi";
            this.btnTransaksi.Size = new System.Drawing.Size(110, 32);
            this.btnTransaksi.Text = "Transaksi";
            this.btnTransaksi.Click += new System.EventHandler(this.btnTransaksi_Click);

            // btnLogout
            this.btnLogout.BackColor = System.Drawing.Color.Gray;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(532, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(90, 32);
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // FormDataProduk
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 475);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCari);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.dgvProduk);
            this.Controls.Add(this.panelBottom);
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.Name = "FormDataProduk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Produk - POS Kasir";
            this.Load += new System.EventHandler(this.FormDataProduk_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvProduk)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCari;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.DataGridView dgvProduk;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnTransaksi;
        private System.Windows.Forms.Button btnLogout;
    }
}

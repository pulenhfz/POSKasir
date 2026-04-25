namespace POSKasir
{
    partial class FormTransaksi
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
            this.lblProduk = new System.Windows.Forms.Label();
            this.cmbProduk = new System.Windows.Forms.ComboBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.btnTambahItem = new System.Windows.Forms.Button();
            this.btnHapusItem = new System.Windows.Forms.Button();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.lblTotalLabel = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.grpLaporan = new System.Windows.Forms.GroupBox();
            this.lblDari = new System.Windows.Forms.Label();
            this.dtpDari = new System.Windows.Forms.DateTimePicker();
            this.lblSampai = new System.Windows.Forms.Label();
            this.dtpSampai = new System.Windows.Forms.DateTimePicker();
            this.btnCariTransaksi = new System.Windows.Forms.Button();
            this.dgvLaporan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.grpLaporan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporan)).BeginInit();
            this.SuspendLayout();

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Transaksi Baru";

            this.lblProduk.AutoSize = true;
            this.lblProduk.Location = new System.Drawing.Point(12, 55);
            this.lblProduk.Name = "lblProduk";
            this.lblProduk.Text = "Produk:";

            this.cmbProduk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduk.Location = new System.Drawing.Point(70, 52);
            this.cmbProduk.Name = "cmbProduk";
            this.cmbProduk.Size = new System.Drawing.Size(280, 23);
            this.cmbProduk.TabIndex = 0;

            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(365, 55);
            this.lblQty.Name = "lblQty";
            this.lblQty.Text = "Qty:";

            this.txtQty.Location = new System.Drawing.Point(395, 52);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(60, 23);
            this.txtQty.TabIndex = 1;
            this.txtQty.Text = "1";
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);

            this.btnTambahItem.BackColor = System.Drawing.Color.Green;
            this.btnTambahItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambahItem.ForeColor = System.Drawing.Color.White;
            this.btnTambahItem.Location = new System.Drawing.Point(470, 50);
            this.btnTambahItem.Name = "btnTambahItem";
            this.btnTambahItem.Size = new System.Drawing.Size(110, 28);
            this.btnTambahItem.TabIndex = 2;
            this.btnTambahItem.Text = "+ Tambah";
            this.btnTambahItem.UseVisualStyleBackColor = false;
            this.btnTambahItem.Click += new System.EventHandler(this.btnTambahItem_Click);

            this.btnHapusItem.BackColor = System.Drawing.Color.Red;
            this.btnHapusItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapusItem.ForeColor = System.Drawing.Color.White;
            this.btnHapusItem.Location = new System.Drawing.Point(590, 50);
            this.btnHapusItem.Name = "btnHapusItem";
            this.btnHapusItem.Size = new System.Drawing.Size(110, 28);
            this.btnHapusItem.TabIndex = 3;
            this.btnHapusItem.Text = "\u2715 Hapus Item";
            this.btnHapusItem.UseVisualStyleBackColor = false;
            this.btnHapusItem.Click += new System.EventHandler(this.btnHapusItem_Click);

            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.Anchor = ((System.Windows.Forms.AnchorStyles)(
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right));
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCart.BackgroundColor = System.Drawing.Color.White;
            this.dgvCart.Location = new System.Drawing.Point(12, 90);
            this.dgvCart.MultiSelect = false;
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.RowHeadersVisible = false;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(876, 200);
            this.dgvCart.TabIndex = 4;

            this.lblTotalLabel.AutoSize = true;
            this.lblTotalLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalLabel.Location = new System.Drawing.Point(12, 300);
            this.lblTotalLabel.Name = "lblTotalLabel";
            this.lblTotalLabel.Text = "Total:";

            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTotal.Location = new System.Drawing.Point(70, 298);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Text = "Rp 0";

            this.btnSimpan.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(600, 295);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(150, 35);
            this.btnSimpan.TabIndex = 5;
            this.btnSimpan.Text = "Simpan Transaksi";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);

            this.btnBatal.BackColor = System.Drawing.Color.Gray;
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.ForeColor = System.Drawing.Color.White;
            this.btnBatal.Location = new System.Drawing.Point(760, 295);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(90, 35);
            this.btnBatal.TabIndex = 6;
            this.btnBatal.Text = "Tutup";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);

            this.grpLaporan.Anchor = ((System.Windows.Forms.AnchorStyles)(
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right |
                System.Windows.Forms.AnchorStyles.Bottom));
            this.grpLaporan.Controls.Add(this.lblDari);
            this.grpLaporan.Controls.Add(this.dtpDari);
            this.grpLaporan.Controls.Add(this.lblSampai);
            this.grpLaporan.Controls.Add(this.dtpSampai);
            this.grpLaporan.Controls.Add(this.btnCariTransaksi);
            this.grpLaporan.Controls.Add(this.dgvLaporan);
            this.grpLaporan.Location = new System.Drawing.Point(12, 345);
            this.grpLaporan.Name = "grpLaporan";
            this.grpLaporan.Size = new System.Drawing.Size(876, 260);
            this.grpLaporan.TabIndex = 7;
            this.grpLaporan.TabStop = false;
            this.grpLaporan.Text = "Laporan Transaksi";

            this.lblDari.AutoSize = true;
            this.lblDari.Location = new System.Drawing.Point(10, 25);
            this.lblDari.Name = "lblDari";
            this.lblDari.Text = "Dari:";

            this.dtpDari.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDari.Location = new System.Drawing.Point(50, 22);
            this.dtpDari.Name = "dtpDari";
            this.dtpDari.Size = new System.Drawing.Size(150, 23);
            this.dtpDari.TabIndex = 0;

            this.lblSampai.AutoSize = true;
            this.lblSampai.Location = new System.Drawing.Point(215, 25);
            this.lblSampai.Name = "lblSampai";
            this.lblSampai.Text = "Sampai:";

            this.dtpSampai.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSampai.Location = new System.Drawing.Point(265, 22);
            this.dtpSampai.Name = "dtpSampai";
            this.dtpSampai.Size = new System.Drawing.Size(150, 23);
            this.dtpSampai.TabIndex = 1;

            this.btnCariTransaksi.BackColor = System.Drawing.Color.Orange;
            this.btnCariTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCariTransaksi.ForeColor = System.Drawing.Color.White;
            this.btnCariTransaksi.Location = new System.Drawing.Point(430, 20);
            this.btnCariTransaksi.Name = "btnCariTransaksi";
            this.btnCariTransaksi.Size = new System.Drawing.Size(80, 28);
            this.btnCariTransaksi.TabIndex = 2;
            this.btnCariTransaksi.Text = "Cari";
            this.btnCariTransaksi.UseVisualStyleBackColor = false;
            this.btnCariTransaksi.Click += new System.EventHandler(this.btnCariTransaksi_Click);

            this.dgvLaporan.AllowUserToAddRows = false;
            this.dgvLaporan.Anchor = ((System.Windows.Forms.AnchorStyles)(
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right |
                System.Windows.Forms.AnchorStyles.Bottom));
            this.dgvLaporan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLaporan.BackgroundColor = System.Drawing.Color.White;
            this.dgvLaporan.Location = new System.Drawing.Point(10, 60);
            this.dgvLaporan.Name = "dgvLaporan";
            this.dgvLaporan.ReadOnly = true;
            this.dgvLaporan.RowHeadersVisible = false;
            this.dgvLaporan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLaporan.Size = new System.Drawing.Size(856, 185);
            this.dgvLaporan.TabIndex = 3;

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 620);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblProduk);
            this.Controls.Add(this.cmbProduk);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.btnTambahItem);
            this.Controls.Add(this.btnHapusItem);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.lblTotalLabel);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.grpLaporan);
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.Name = "FormTransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaksi - POS Kasir";
            this.Load += new System.EventHandler(this.FormTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.grpLaporan.ResumeLayout(false);
            this.grpLaporan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblProduk;
        private System.Windows.Forms.ComboBox cmbProduk;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Button btnTambahItem;
        private System.Windows.Forms.Button btnHapusItem;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.GroupBox grpLaporan;
        private System.Windows.Forms.Label lblDari;
        private System.Windows.Forms.DateTimePicker dtpDari;
        private System.Windows.Forms.Label lblSampai;
        private System.Windows.Forms.DateTimePicker dtpSampai;
        private System.Windows.Forms.Button btnCariTransaksi;
        private System.Windows.Forms.DataGridView dgvLaporan;
    }
}

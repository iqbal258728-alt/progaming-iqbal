
namespace Proyekakhir_Rizkiiqbaltawakkal_XPPLG1
{
    partial class FormTransaksi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNamaPemesan = new Label();
            cmbmakanan = new ComboBox();
            txtNama = new TextBox();
            lblMakanan = new Label();
            dgv1 = new DataGridView();
            label3 = new Label();
            lblMinuman = new Label();
            btnPesan = new Button();
            btnclear = new Button();
            cmbMinuman = new ComboBox();
            txtPorsi = new TextBox();
            lblnomeja = new Label();
            txtnomeja = new TextBox();
            lblRp = new Label();
            label2 = new Label();
            lblporsi = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            SuspendLayout();
            // 
            // lblNamaPemesan
            // 
            lblNamaPemesan.AutoSize = true;
            lblNamaPemesan.Location = new Point(212, 115);
            lblNamaPemesan.Name = "lblNamaPemesan";
            lblNamaPemesan.Size = new Size(52, 20);
            lblNamaPemesan.TabIndex = 0;
            lblNamaPemesan.Text = "Nama:";
            lblNamaPemesan.Click += this.lblNamaPemesan_Click;
            // 
            // cmbmakanan
            // 
            cmbmakanan.FormattingEnabled = true;
            cmbmakanan.Location = new Point(299, 154);
            cmbmakanan.Name = "cmbmakanan";
            cmbmakanan.Size = new Size(151, 28);
            cmbmakanan.TabIndex = 1;
            cmbmakanan.SelectedIndexChanged += this.cmbmakanan_SelectedIndexChanged;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(299, 112);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(125, 27);
            txtNama.TabIndex = 2;
            txtNama.TextChanged += this.txtNama_TextChanged;
            // 
            // lblMakanan
            // 
            lblMakanan.AutoSize = true;
            lblMakanan.Location = new Point(212, 157);
            lblMakanan.Name = "lblMakanan";
            lblMakanan.Size = new Size(72, 20);
            lblMakanan.TabIndex = 3;
            lblMakanan.Text = "Makanan:";
            lblMakanan.Click += this.lblMakanan_Click;
            // 
            // dgv1
            // 
            dgv1.BackgroundColor = SystemColors.ButtonHighlight;
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Location = new Point(557, 215);
            dgv1.Name = "dgv1";
            dgv1.RowHeadersWidth = 51;
            dgv1.Size = new Size(283, 160);
            dgv1.TabIndex = 4;
            dgv1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(384, 13);
            label3.Name = "label3";
            label3.Size = new Size(346, 38);
            label3.TabIndex = 5;
            label3.Text = "Warung makan pak ole";
            label3.Click += this.label3_Click;
            // 
            // lblMinuman
            // 
            lblMinuman.AutoSize = true;
            lblMinuman.Location = new Point(212, 199);
            lblMinuman.Name = "lblMinuman";
            lblMinuman.Size = new Size(74, 20);
            lblMinuman.TabIndex = 7;
            lblMinuman.Text = "Minuman:";
            lblMinuman.Click += this.lblMinuman_Click;
            // 
            // btnPesan
            // 
            btnPesan.Location = new Point(212, 346);
            btnPesan.Name = "btnPesan";
            btnPesan.Size = new Size(94, 29);
            btnPesan.TabIndex = 8;
            btnPesan.Text = "Pesan";
            btnPesan.UseVisualStyleBackColor = true;
            btnPesan.Click += btnPesan_Click;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(330, 346);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(94, 29);
            btnclear.TabIndex = 9;
            btnclear.Text = "clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // cmbMinuman
            // 
            cmbMinuman.FormattingEnabled = true;
            cmbMinuman.Location = new Point(299, 196);
            cmbMinuman.Name = "cmbMinuman";
            cmbMinuman.Size = new Size(151, 28);
            cmbMinuman.TabIndex = 10;
            cmbMinuman.SelectedIndexChanged += this.cmbMinuman_SelectedIndexChanged;
            // 
            // txtPorsi
            // 
            txtPorsi.Location = new Point(299, 242);
            txtPorsi.Name = "txtPorsi";
            txtPorsi.Size = new Size(125, 27);
            txtPorsi.TabIndex = 12;
            txtPorsi.TextChanged += txtPorsi_TextChanged;
            // 
            // lblnomeja
            // 
            lblnomeja.AutoSize = true;
            lblnomeja.Location = new Point(212, 289);
            lblnomeja.Name = "lblnomeja";
            lblnomeja.Size = new Size(69, 20);
            lblnomeja.TabIndex = 13;
            lblnomeja.Text = "No Meja:";
            lblnomeja.Click += this.lblnomeja_Click;
            // 
            // txtnomeja
            // 
            txtnomeja.Location = new Point(299, 289);
            txtnomeja.Name = "txtnomeja";
            txtnomeja.Size = new Size(125, 27);
            txtnomeja.TabIndex = 14;
            txtnomeja.TextChanged += this.txtnomeja_TextChanged;
            // 
            // lblRp
            // 
            lblRp.AutoSize = true;
            lblRp.Location = new Point(567, 98);
            lblRp.Name = "lblRp";
            lblRp.Size = new Size(30, 20);
            lblRp.TabIndex = 15;
            lblRp.Text = "Rp:";
            lblRp.Click += this.lblRp_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(592, 98);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 16;
            label2.Click += this.label2_Click;
            // 
            // lblporsi
            // 
            lblporsi.AutoSize = true;
            lblporsi.Location = new Point(212, 249);
            lblporsi.Name = "lblporsi";
            lblporsi.Size = new Size(43, 20);
            lblporsi.TabIndex = 17;
            lblporsi.Text = "Porsi:";
            lblporsi.Click += this.lblporsi_Click_1;
            // 
            // FormTransaksi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 414);
            Controls.Add(lblporsi);
            Controls.Add(label2);
            Controls.Add(lblRp);
            Controls.Add(txtnomeja);
            Controls.Add(lblnomeja);
            Controls.Add(txtPorsi);
            Controls.Add(cmbMinuman);
            Controls.Add(btnclear);
            Controls.Add(btnPesan);
            Controls.Add(lblMinuman);
            Controls.Add(label3);
            Controls.Add(dgv1);
            Controls.Add(lblMakanan);
            Controls.Add(txtNama);
            Controls.Add(cmbmakanan);
            Controls.Add(lblNamaPemesan);
            Name = "FormTransaksi";
            Text = "FormTransaksi";
            Load += FormTransaksi1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void cmbMinuman_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblNamaPemesan_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblMinuman_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblnomeja_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblMakanan_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void cmbmakanan_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblporsi_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblRp_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtnomeja_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj) => obj is FormTransaksi transaksi &&
                   EqualityComparer<Label>.Default.Equals(Txtporsi, transaksi.Txtporsi);

        #endregion

        private Label lblNamaPemesan;
        private ComboBox cmbmakanan;
        private TextBox txtNama;
        private Label lblMakanan;
        private DataGridView dgv1;
        private Label label3;
        private Label lblMinuman;
        private Button btnPesan;
        private Button btnclear;
        private ComboBox cmbMinuman;
        private TextBox txtPorsi;
        private Label txtporsi;
        private TextBox txtPorsi1;

        public FormTransaksi(TextBox txtPorsi1, Label txtporsi)
        {
            this.txtPorsi1 = txtPorsi1;
            this.txtporsi = txtporsi;
        }

        public FormTransaksi(Label txtporsi, TextBox txtPorsi1)
        {
            this.Txtporsi = txtporsi;
            this.txtPorsi1 = txtPorsi1;
        }

        private Label lblnomeja;
        private TextBox txtnomeja;
        private Label lblRp;
        private Label label2;
        private Label lblporsi;

        public Label Txtporsi { get => txtporsi; set => txtporsi = value; }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
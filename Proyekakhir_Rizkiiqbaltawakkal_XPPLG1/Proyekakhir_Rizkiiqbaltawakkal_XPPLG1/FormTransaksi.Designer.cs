
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
            lblNamaPemesan.Location = new Point(186, 86);
            lblNamaPemesan.Name = "lblNamaPemesan";
            lblNamaPemesan.Size = new Size(42, 15);
            lblNamaPemesan.TabIndex = 0;
            lblNamaPemesan.Text = "Nama:";
            lblNamaPemesan.Click += lblNamaPemesan_Click;
            // 
            // cmbmakanan
            // 
            cmbmakanan.FormattingEnabled = true;
            cmbmakanan.Location = new Point(262, 116);
            cmbmakanan.Margin = new Padding(3, 2, 3, 2);
            cmbmakanan.Name = "cmbmakanan";
            cmbmakanan.Size = new Size(133, 23);
            cmbmakanan.TabIndex = 1;
            cmbmakanan.SelectedIndexChanged += cmbmakanan_SelectedIndexChanged;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(262, 84);
            txtNama.Margin = new Padding(3, 2, 3, 2);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(110, 23);
            txtNama.TabIndex = 2;
            txtNama.TextChanged += txtNama_TextChanged;
            // 
            // lblMakanan
            // 
            lblMakanan.AutoSize = true;
            lblMakanan.Location = new Point(186, 118);
            lblMakanan.Name = "lblMakanan";
            lblMakanan.Size = new Size(59, 15);
            lblMakanan.TabIndex = 3;
            lblMakanan.Text = "Makanan:";
            lblMakanan.Click += lblMakanan_Click;
            // 
            // dgv1
            // 
            dgv1.BackgroundColor = SystemColors.ButtonHighlight;
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Location = new Point(487, 161);
            dgv1.Margin = new Padding(3, 2, 3, 2);
            dgv1.Name = "dgv1";
            dgv1.RowHeadersWidth = 51;
            dgv1.Size = new Size(248, 120);
            dgv1.TabIndex = 4;
            dgv1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(336, 10);
            label3.Name = "label3";
            label3.Size = new Size(269, 30);
            label3.TabIndex = 5;
            label3.Text = "Warung makan pak ole";
            label3.Click += label3_Click;
            // 
            // lblMinuman
            // 
            lblMinuman.AutoSize = true;
            lblMinuman.Location = new Point(186, 149);
            lblMinuman.Name = "lblMinuman";
            lblMinuman.Size = new Size(62, 15);
            lblMinuman.TabIndex = 7;
            lblMinuman.Text = "Minuman:";
            lblMinuman.Click += lblMinuman_Click;
            // 
            // btnPesan
            // 
            btnPesan.Location = new Point(186, 260);
            btnPesan.Margin = new Padding(3, 2, 3, 2);
            btnPesan.Name = "btnPesan";
            btnPesan.Size = new Size(82, 22);
            btnPesan.TabIndex = 8;
            btnPesan.Text = "Pesan";
            btnPesan.UseVisualStyleBackColor = true;
            btnPesan.Click += btnPesan_Click;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(289, 260);
            btnclear.Margin = new Padding(3, 2, 3, 2);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(82, 22);
            btnclear.TabIndex = 9;
            btnclear.Text = "clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // cmbMinuman
            // 
            cmbMinuman.FormattingEnabled = true;
            cmbMinuman.Location = new Point(262, 147);
            cmbMinuman.Margin = new Padding(3, 2, 3, 2);
            cmbMinuman.Name = "cmbMinuman";
            cmbMinuman.Size = new Size(133, 23);
            cmbMinuman.TabIndex = 10;
            cmbMinuman.SelectedIndexChanged += cmbMinuman_SelectedIndexChanged;
            // 
            // txtPorsi
            // 
            txtPorsi.Location = new Point(262, 182);
            txtPorsi.Margin = new Padding(3, 2, 3, 2);
            txtPorsi.Name = "txtPorsi";
            txtPorsi.Size = new Size(110, 23);
            txtPorsi.TabIndex = 12;
            txtPorsi.TextChanged += txtPorsi_TextChanged;
            // 
            // lblnomeja
            // 
            lblnomeja.AutoSize = true;
            lblnomeja.Location = new Point(186, 217);
            lblnomeja.Name = "lblnomeja";
            lblnomeja.Size = new Size(55, 15);
            lblnomeja.TabIndex = 13;
            lblnomeja.Text = "No Meja:";
            lblnomeja.Click += lblnomeja_Click;
            // 
            // txtnomeja
            // 
            txtnomeja.Location = new Point(262, 217);
            txtnomeja.Margin = new Padding(3, 2, 3, 2);
            txtnomeja.Name = "txtnomeja";
            txtnomeja.Size = new Size(110, 23);
            txtnomeja.TabIndex = 14;
            txtnomeja.TextChanged += txtnomeja_TextChanged;
            // 
            // lblRp
            // 
            lblRp.AutoSize = true;
            lblRp.Location = new Point(496, 74);
            lblRp.Name = "lblRp";
            lblRp.Size = new Size(24, 15);
            lblRp.TabIndex = 15;
            lblRp.Text = "Rp:";
            lblRp.Click += lblRp_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(518, 74);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 16;
            label2.Click += label2_Click;
            // 
            // lblporsi
            // 
            lblporsi.AutoSize = true;
            lblporsi.Location = new Point(186, 187);
            lblporsi.Name = "lblporsi";
            lblporsi.Size = new Size(36, 15);
            lblporsi.TabIndex = 17;
            lblporsi.Text = "Porsi:";
            lblporsi.Click += lblporsi_Click_1;
            // 
            // FormTransaksi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 408);
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
            Margin = new Padding(3, 2, 3, 2);
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
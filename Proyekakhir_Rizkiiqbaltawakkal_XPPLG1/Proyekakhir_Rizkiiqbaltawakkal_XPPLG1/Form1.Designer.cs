
namespace Proyekakhir_Rizkiiqbaltawakkal_XPPLG1
{
    partial class FormTransaksi1
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
            lblporsi = new Label();
            label2 = new Label();
            lblRp = new Label();
            txtnomeja = new TextBox();
            lblnomeja = new Label();
            txtPorsi = new TextBox();
            cmbMinuman = new ComboBox();
            btnclear = new Button();
            btnPesan = new Button();
            lblMinuman = new Label();
            label3 = new Label();
            dgv1 = new DataGridView();
            lblMakanan = new Label();
            txtNama = new TextBox();
            cmbmakanan = new ComboBox();
            lblNamaPemesan = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            SuspendLayout();
            // 
            // lblporsi
            // 
            lblporsi.AutoSize = true;
            lblporsi.Location = new Point(88, 266);
            lblporsi.Name = "lblporsi";
            lblporsi.Size = new Size(43, 20);
            lblporsi.TabIndex = 33;
            lblporsi.Text = "Porsi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(468, 115);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 32;
            // 
            // lblRp
            // 
            lblRp.AutoSize = true;
            lblRp.Location = new Point(443, 115);
            lblRp.Name = "lblRp";
            lblRp.Size = new Size(30, 20);
            lblRp.TabIndex = 31;
            lblRp.Text = "Rp:";
            // 
            // txtnomeja
            // 
            txtnomeja.Location = new Point(175, 306);
            txtnomeja.Name = "txtnomeja";
            txtnomeja.Size = new Size(125, 27);
            txtnomeja.TabIndex = 30;
            // 
            // lblnomeja
            // 
            lblnomeja.AutoSize = true;
            lblnomeja.Location = new Point(88, 306);
            lblnomeja.Name = "lblnomeja";
            lblnomeja.Size = new Size(69, 20);
            lblnomeja.TabIndex = 29;
            lblnomeja.Text = "No Meja:";
            // 
            // txtPorsi
            // 
            txtPorsi.Location = new Point(175, 259);
            txtPorsi.Name = "txtPorsi";
            txtPorsi.Size = new Size(125, 27);
            txtPorsi.TabIndex = 28;
            // 
            // cmbMinuman
            // 
            cmbMinuman.FormattingEnabled = true;
            cmbMinuman.Location = new Point(175, 213);
            cmbMinuman.Name = "cmbMinuman";
            cmbMinuman.Size = new Size(151, 28);
            cmbMinuman.TabIndex = 27;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(206, 363);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(94, 29);
            btnclear.TabIndex = 26;
            btnclear.Text = "clear";
            btnclear.UseVisualStyleBackColor = true;
            // 
            // btnPesan
            // 
            btnPesan.Location = new Point(88, 363);
            btnPesan.Name = "btnPesan";
            btnPesan.Size = new Size(94, 29);
            btnPesan.TabIndex = 25;
            btnPesan.Text = "Pesan";
            btnPesan.UseVisualStyleBackColor = true;
            btnPesan.Click += btnPesan_Click;
            // 
            // lblMinuman
            // 
            lblMinuman.AutoSize = true;
            lblMinuman.Location = new Point(88, 216);
            lblMinuman.Name = "lblMinuman";
            lblMinuman.Size = new Size(74, 20);
            lblMinuman.TabIndex = 24;
            lblMinuman.Text = "Minuman:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(260, 30);
            label3.Name = "label3";
            label3.Size = new Size(346, 38);
            label3.TabIndex = 23;
            label3.Text = "Warung makan pak ole";
            // 
            // dgv1
            // 
            dgv1.BackgroundColor = SystemColors.ButtonHighlight;
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Location = new Point(433, 232);
            dgv1.Name = "dgv1";
            dgv1.RowHeadersWidth = 51;
            dgv1.Size = new Size(283, 160);
            dgv1.TabIndex = 22;
            // 
            // lblMakanan
            // 
            lblMakanan.AutoSize = true;
            lblMakanan.Location = new Point(88, 174);
            lblMakanan.Name = "lblMakanan";
            lblMakanan.Size = new Size(72, 20);
            lblMakanan.TabIndex = 21;
            lblMakanan.Text = "Makanan:";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(175, 129);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(125, 27);
            txtNama.TabIndex = 20;
            // 
            // cmbmakanan
            // 
            cmbmakanan.FormattingEnabled = true;
            cmbmakanan.Location = new Point(175, 171);
            cmbmakanan.Name = "cmbmakanan";
            cmbmakanan.Size = new Size(151, 28);
            cmbmakanan.TabIndex = 19;
            // 
            // lblNamaPemesan
            // 
            lblNamaPemesan.AutoSize = true;
            lblNamaPemesan.Location = new Point(88, 132);
            lblNamaPemesan.Name = "lblNamaPemesan";
            lblNamaPemesan.Size = new Size(52, 20);
            lblNamaPemesan.TabIndex = 18;
            lblNamaPemesan.Text = "Nama:";
            // 
            // FormTransaksi2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "FormTransaksi2";
            Text = "FormTransaksi2";
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnPesan_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lblporsi;
        private Label label2;
        private Label lblRp;
        private TextBox txtnomeja;
        private Label lblnomeja;
        private TextBox txtPorsi;
        private ComboBox cmbMinuman;
        private Button btnclear;
        private Button btnPesan;
        private Label lblMinuman;
        private Label label3;
        private DataGridView dgv1;
        private Label lblMakanan;
        private TextBox txtNama;
        private ComboBox cmbmakanan;
        private Label lblNamaPemesan;
    }
}
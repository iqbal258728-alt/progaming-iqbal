namespace Proyekakhir1_RizkiIqbalTawakkal_XPPLG1
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
            label1 = new Label();
            lblnamapemesan = new Label();
            lblmakanan = new Label();
            lblminunman = new Label();
            lblporsi = new Label();
            lblnomeja = new Label();
            cmbMakanan = new ComboBox();
            cmbMinuman = new ComboBox();
            txtnamapemesan = new TextBox();
            txtporsi = new TextBox();
            txtnomeja = new TextBox();
            btnpesan = new Button();
            btnclear = new Button();
            dgv1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(350, 35);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // lblnamapemesan
            // 
            lblnamapemesan.AutoSize = true;
            lblnamapemesan.Location = new Point(56, 92);
            lblnamapemesan.Name = "lblnamapemesan";
            lblnamapemesan.Size = new Size(114, 20);
            lblnamapemesan.TabIndex = 1;
            lblnamapemesan.Text = "Nama Pemesan:";
            // 
            // lblmakanan
            // 
            lblmakanan.AutoSize = true;
            lblmakanan.Location = new Point(56, 130);
            lblmakanan.Name = "lblmakanan";
            lblmakanan.Size = new Size(72, 20);
            lblmakanan.TabIndex = 2;
            lblmakanan.Text = "Makanan:";
            // 
            // lblminunman
            // 
            lblminunman.AutoSize = true;
            lblminunman.Location = new Point(56, 177);
            lblminunman.Name = "lblminunman";
            lblminunman.Size = new Size(74, 20);
            lblminunman.TabIndex = 3;
            lblminunman.Text = "Minuman:";
            // 
            // lblporsi
            // 
            lblporsi.AutoSize = true;
            lblporsi.Location = new Point(416, 93);
            lblporsi.Name = "lblporsi";
            lblporsi.Size = new Size(43, 20);
            lblporsi.TabIndex = 4;
            lblporsi.Text = "Porsi:";
            // 
            // lblnomeja
            // 
            lblnomeja.AutoSize = true;
            lblnomeja.Location = new Point(416, 131);
            lblnomeja.Name = "lblnomeja";
            lblnomeja.Size = new Size(69, 20);
            lblnomeja.TabIndex = 5;
            lblnomeja.Text = "No Meja:";
            // 
            // cmbMakanan
            // 
            cmbMakanan.FormattingEnabled = true;
            cmbMakanan.Location = new Point(175, 127);
            cmbMakanan.Name = "cmbMakanan";
            cmbMakanan.Size = new Size(151, 28);
            cmbMakanan.TabIndex = 6;
            // 
            // cmbMinuman
            // 
            cmbMinuman.FormattingEnabled = true;
            cmbMinuman.Location = new Point(175, 174);
            cmbMinuman.Name = "cmbMinuman";
            cmbMinuman.Size = new Size(151, 28);
            cmbMinuman.TabIndex = 7;
            // 
            // txtnamapemesan
            // 
            txtnamapemesan.Location = new Point(175, 89);
            txtnamapemesan.Name = "txtnamapemesan";
            txtnamapemesan.Size = new Size(125, 27);
            txtnamapemesan.TabIndex = 8;
            // 
            // txtporsi
            // 
            txtporsi.Location = new Point(491, 93);
            txtporsi.Name = "txtporsi";
            txtporsi.Size = new Size(125, 27);
            txtporsi.TabIndex = 9;
            // 
            // txtnomeja
            // 
            txtnomeja.Location = new Point(491, 131);
            txtnomeja.Name = "txtnomeja";
            txtnomeja.Size = new Size(125, 27);
            txtnomeja.TabIndex = 10;
            // 
            // btnpesan
            // 
            btnpesan.Location = new Point(118, 258);
            btnpesan.Name = "btnpesan";
            btnpesan.Size = new Size(94, 29);
            btnpesan.TabIndex = 11;
            btnpesan.Text = "Pesan";
            btnpesan.UseVisualStyleBackColor = true;
            btnpesan.Click += btnpesan_Click;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(232, 258);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(94, 29);
            btnclear.TabIndex = 12;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // dgv1
            // 
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Location = new Point(660, 91);
            dgv1.Name = "dgv1";
            dgv1.RowHeadersWidth = 51;
            dgv1.Size = new Size(387, 258);
            dgv1.TabIndex = 13;
            // 
            // FormTransaksi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1307, 550);
            Controls.Add(dgv1);
            Controls.Add(btnclear);
            Controls.Add(btnpesan);
            Controls.Add(txtnomeja);
            Controls.Add(txtporsi);
            Controls.Add(txtnamapemesan);
            Controls.Add(cmbMinuman);
            Controls.Add(cmbMakanan);
            Controls.Add(lblnomeja);
            Controls.Add(lblporsi);
            Controls.Add(lblminunman);
            Controls.Add(lblmakanan);
            Controls.Add(lblnamapemesan);
            Controls.Add(label1);
            Name = "FormTransaksi";
            Text = "FormTransaksi";
            Load += FormTransaksi_Load;
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblnamapemesan;
        private Label lblmakanan;
        private Label lblminunman;
        private Label lblporsi;
        private Label lblnomeja;
        private ComboBox cmbMakanan;
        private ComboBox cmbMinuman;
        private TextBox txtnamapemesan;
        private TextBox txtporsi;
        private TextBox txtnomeja;
        private Button btnpesan;
        private Button btnclear;
        private DataGridView dgv1;
    }
}
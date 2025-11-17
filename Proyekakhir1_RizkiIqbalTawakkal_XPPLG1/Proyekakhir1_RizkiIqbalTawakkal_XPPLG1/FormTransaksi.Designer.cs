
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransaksi));
            lblrumahmkn = new Label();
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
            cmbpembayaran = new ComboBox();
            lblpembayaran = new Label();
            lblttl = new Label();
            lblTotal = new Label();
            lblkmbl = new Label();
            lblkembalian = new Label();
            lbltotalbayar = new Label();
            txttotalbayar = new TextBox();
            btnbayar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            SuspendLayout();
            // 
            // lblrumahmkn
            // 
            lblrumahmkn.AutoSize = true;
            lblrumahmkn.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblrumahmkn.Location = new Point(532, 43);
            lblrumahmkn.Name = "lblrumahmkn";
            lblrumahmkn.Size = new Size(387, 35);
            lblrumahmkn.TabIndex = 0;
            lblrumahmkn.Text = "Rumah Makan Kang IQBAL";
            // 
            // lblnamapemesan
            // 
            lblnamapemesan.AutoSize = true;
            lblnamapemesan.Location = new Point(293, 111);
            lblnamapemesan.Name = "lblnamapemesan";
            lblnamapemesan.Size = new Size(114, 20);
            lblnamapemesan.TabIndex = 1;
            lblnamapemesan.Text = "Nama Pemesan:";
            // 
            // lblmakanan
            // 
            lblmakanan.AutoSize = true;
            lblmakanan.Location = new Point(293, 149);
            lblmakanan.Name = "lblmakanan";
            lblmakanan.Size = new Size(72, 20);
            lblmakanan.TabIndex = 2;
            lblmakanan.Text = "Makanan:";
            // 
            // lblminunman
            // 
            lblminunman.AutoSize = true;
            lblminunman.Location = new Point(293, 196);
            lblminunman.Name = "lblminunman";
            lblminunman.Size = new Size(74, 20);
            lblminunman.TabIndex = 3;
            lblminunman.Text = "Minuman:";
            // 
            // lblporsi
            // 
            lblporsi.AutoSize = true;
            lblporsi.BackColor = Color.White;
            lblporsi.Location = new Point(653, 112);
            lblporsi.Name = "lblporsi";
            lblporsi.Size = new Size(43, 20);
            lblporsi.TabIndex = 4;
            lblporsi.Text = "Porsi:";
            // 
            // lblnomeja
            // 
            lblnomeja.AutoSize = true;
            lblnomeja.Location = new Point(653, 150);
            lblnomeja.Name = "lblnomeja";
            lblnomeja.Size = new Size(69, 20);
            lblnomeja.TabIndex = 5;
            lblnomeja.Text = "No Meja:";
            // 
            // cmbMakanan
            // 
            cmbMakanan.FormattingEnabled = true;
            cmbMakanan.Location = new Point(412, 146);
            cmbMakanan.Name = "cmbMakanan";
            cmbMakanan.Size = new Size(151, 28);
            cmbMakanan.TabIndex = 6;
            cmbMakanan.SelectedIndexChanged += cmbMakanan_SelectedIndexChanged;
            // 
            // cmbMinuman
            // 
            cmbMinuman.FormattingEnabled = true;
            cmbMinuman.Location = new Point(412, 193);
            cmbMinuman.Name = "cmbMinuman";
            cmbMinuman.Size = new Size(151, 28);
            cmbMinuman.TabIndex = 7;
            // 
            // txtnamapemesan
            // 
            txtnamapemesan.Location = new Point(412, 108);
            txtnamapemesan.Name = "txtnamapemesan";
            txtnamapemesan.Size = new Size(125, 27);
            txtnamapemesan.TabIndex = 8;
            txtnamapemesan.TextChanged += txtnamapemesan_TextChanged;
            // 
            // txtporsi
            // 
            txtporsi.Location = new Point(728, 112);
            txtporsi.Name = "txtporsi";
            txtporsi.Size = new Size(125, 27);
            txtporsi.TabIndex = 9;
            txtporsi.TextChanged += txtporsi_TextChanged;
            // 
            // txtnomeja
            // 
            txtnomeja.Location = new Point(728, 150);
            txtnomeja.Name = "txtnomeja";
            txtnomeja.Size = new Size(125, 27);
            txtnomeja.TabIndex = 10;
            // 
            // btnpesan
            // 
            btnpesan.Location = new Point(355, 277);
            btnpesan.Name = "btnpesan";
            btnpesan.Size = new Size(94, 29);
            btnpesan.TabIndex = 11;
            btnpesan.Text = "Pesan";
            btnpesan.UseVisualStyleBackColor = true;
            btnpesan.Click += btnpesan_Click;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(469, 277);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(94, 29);
            btnclear.TabIndex = 12;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // dgv1
            // 
            dgv1.BackgroundColor = SystemColors.ButtonHighlight;
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Location = new Point(935, 96);
            dgv1.Name = "dgv1";
            dgv1.RowHeadersWidth = 51;
            dgv1.Size = new Size(469, 166);
            dgv1.TabIndex = 13;
            dgv1.CellContentClick += dgv1_CellContentClick;
            // 
            // cmbpembayaran
            // 
            cmbpembayaran.FormattingEnabled = true;
            cmbpembayaran.Location = new Point(653, 246);
            cmbpembayaran.Name = "cmbpembayaran";
            cmbpembayaran.Size = new Size(151, 28);
            cmbpembayaran.TabIndex = 15;
            cmbpembayaran.SelectedIndexChanged += cmbpembayaran_SelectedIndexChanged;
            // 
            // lblpembayaran
            // 
            lblpembayaran.AutoSize = true;
            lblpembayaran.Location = new Point(653, 219);
            lblpembayaran.Name = "lblpembayaran";
            lblpembayaran.Size = new Size(90, 20);
            lblpembayaran.TabIndex = 16;
            lblpembayaran.Text = "Pembayaran";
            // 
            // lblttl
            // 
            lblttl.AutoSize = true;
            lblttl.Location = new Point(618, 318);
            lblttl.Name = "lblttl";
            lblttl.Size = new Size(42, 20);
            lblttl.TabIndex = 17;
            lblttl.Text = "Total";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(728, 318);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 20);
            lblTotal.TabIndex = 18;
            // 
            // lblkmbl
            // 
            lblkmbl.AutoSize = true;
            lblkmbl.Location = new Point(618, 367);
            lblkmbl.Name = "lblkmbl";
            lblkmbl.Size = new Size(83, 20);
            lblkmbl.TabIndex = 19;
            lblkmbl.Text = "Kembalian:";
            // 
            // lblkembalian
            // 
            lblkembalian.AutoSize = true;
            lblkembalian.Location = new Point(728, 367);
            lblkembalian.Name = "lblkembalian";
            lblkembalian.Size = new Size(0, 20);
            lblkembalian.TabIndex = 20;
            // 
            // lbltotalbayar
            // 
            lbltotalbayar.AutoSize = true;
            lbltotalbayar.Location = new Point(618, 417);
            lbltotalbayar.Name = "lbltotalbayar";
            lbltotalbayar.Size = new Size(86, 20);
            lbltotalbayar.TabIndex = 21;
            lbltotalbayar.Text = "Total Bayar:";
            // 
            // txttotalbayar
            // 
            txttotalbayar.Location = new Point(728, 414);
            txttotalbayar.Name = "txttotalbayar";
            txttotalbayar.Size = new Size(125, 27);
            txttotalbayar.TabIndex = 22;
            // 
            // btnbayar
            // 
            btnbayar.Location = new Point(657, 467);
            btnbayar.Name = "btnbayar";
            btnbayar.Size = new Size(94, 29);
            btnbayar.TabIndex = 23;
            btnbayar.Text = "Bayar";
            btnbayar.UseVisualStyleBackColor = true;
            btnbayar.Click += btnbayar_Click;
            // 
            // FormTransaksi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1448, 550);
            Controls.Add(btnbayar);
            Controls.Add(txttotalbayar);
            Controls.Add(lbltotalbayar);
            Controls.Add(lblkembalian);
            Controls.Add(lblkmbl);
            Controls.Add(lblTotal);
            Controls.Add(lblttl);
            Controls.Add(lblpembayaran);
            Controls.Add(cmbpembayaran);
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
            Controls.Add(lblrumahmkn);
            Name = "FormTransaksi";
            Text = "FormTransaksi";
            Load += FormTransaksi_Load;
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblrumahmkn;
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
        private ComboBox cmbpembayaran;
        private Label lblpembayaran;
        private Label lblttl;
        private Label lblTotal;
        private Label lblkmbl;
        private Label lblkembalian;
        private Label lbltotalbayar;
        private TextBox txttotalbayar;
        private Button btnbayar;
    }
}
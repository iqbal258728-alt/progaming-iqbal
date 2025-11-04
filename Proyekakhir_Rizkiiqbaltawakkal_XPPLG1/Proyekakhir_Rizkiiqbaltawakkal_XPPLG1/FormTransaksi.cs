using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyekakhir_Rizkiiqbaltawakkal_XPPLG1
{
    public partial class FormTransaksi : Form
    {
        public FormTransaksi(Label txtporsi)
        {
            InitializeComponent();
            this.Txtporsi = txtporsi;
        }

        public FormTransaksi()
        {
        }

        private void FormTransaksi1_Load(object sender, EventArgs e)
        {
            //Tambahkan kolom ke DataGridView
            dgv1.ColumnCount = 5;
            dgv1.Columns[0].Name = "Nama Pemesan";
            dgv1.Columns[1].Name = "Makanan";
            dgv1.Columns[2].Name = "Minuman";
            dgv1.Columns[3].Name = "Porsi";
            dgv1.Columns[4].Name = "No Meja";

            //Tambahkan beberapa baris contoh data
            cmbmakanan.Items.Add("Nasi Goreng:13.000");
            cmbmakanan.Items.Add("Mie Ayam:7.000");
            cmbmakanan.Items.Add("Sate Ayam:10.000");
            cmbMinuman.Items.Add("Es Teh:4.000");
            cmbMinuman.Items.Add("Es Jeruk:5.000");
            cmbMinuman.Items.Add("Air Mineral:3.000");
            cmbMinuman.Items.Add("Kopi:7.000");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPesan_Click(object sender, EventArgs e)
        {
            //Mengambil data dari input user
            string namaPemesan = txtNama.Text;
            string makanan = cmbmakanan.SelectedItem?.ToString() ?? "";
            string minuman = cmbMinuman.SelectedItem?.ToString() ?? "";
            string porsi = Txtporsi.ToString();
            string noMeja = txtnomeja.ToString() ?? "";

            if (namaPemesan == "" || makanan == "" || minuman == "" || porsi == "" || noMeja == "")
            {
                MessageBox.Show("Mohon lengkapi semua data pemesanan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgv1.Rows.Add(namaPemesan, makanan, minuman, porsi, noMeja);

            //Bersihkan input setelah menambahkan data
            txtNama.Clear();
            cmbmakanan.SelectedIndex = -1;
            txtNama.Focus();
            txtnomeja.Clear();
            cmbMinuman.SelectedIndex = -1;
            txtnomeja.Focus();
            txtPorsi.Clear();
            txtPorsi.Focus();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {

        }

        private void lblporsi_Click(object sender, EventArgs e)
        {

        }

        private void txtPorsi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

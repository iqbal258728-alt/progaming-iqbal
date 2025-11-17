using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyekakhir1_RizkiIqbalTawakkal_XPPLG1
{
    public partial class FormTransaksi : Form
    {
        //private const string V = "Pembayaran";
        // at class level
        private DataTable ordersTable;

        public FormTransaksi()
        {
            InitializeComponent();
        }

        private void btnpesan_Click(object sender, EventArgs e)
        {
            // tombol pesan
            string namaPemesan = txtnamapemesan.Text;
            string makanan = cmbMakanan.SelectedItem?.ToString() ?? "";
            string minuman = cmbMinuman.SelectedItem?.ToString() ?? "";
            string porsi = txtporsi.Text;
            string noMeja = txtnomeja.Text;
            string pembayaran = cmbpembayaran.SelectedItem?.ToString() ?? "";
            int jumlah = 0;
            if (string.IsNullOrWhiteSpace(namaPemesan) || string.IsNullOrWhiteSpace(makanan) ||
                string.IsNullOrWhiteSpace(minuman) || string.IsNullOrWhiteSpace(porsi) ||
                string.IsNullOrWhiteSpace(noMeja) || string.IsNullOrWhiteSpace(pembayaran))
            {
                MessageBox.Show("Harap lengkapi semua data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Hitung Total Harga
            int Porsi = int.Parse(porsi);
            switch (makanan)
            {
                case "Nasi Goreng:13.000":
                    jumlah += 13000 * Porsi;
                    break;
                case "Nasi Padang:15.000":
                    jumlah += 15000 * Porsi;
                    break;
                case "Sate Ayam:10.000":
                    jumlah += 10000 * Porsi;
                    break;
                case "Nasi kucing:7.000":
                    jumlah += 7000 * Porsi;
                    break;
            }
            switch (minuman) //minuman
            {
                case "Es Teh:4.000":
                    jumlah += 4000 * Porsi;
                    break;
                case "Air Mineral:3.000":
                    jumlah += 3000 * Porsi;
                    break;
                case "Teh Panas:3.000":
                    jumlah += 3000 * Porsi;
                    break;
            }

            //Menambahkan Baris Ke DataGridView
            string[] row = new string[] { namaPemesan, makanan, minuman, porsi, noMeja, pembayaran, jumlah.ToString() };
            //dgv1.Rows.Add(row);

            // tambahkan data ke GridView
            ordersTable = new DataTable();
            ordersTable.Columns.Add("Nama Pemesan", typeof(string));
            ordersTable.Columns.Add("Makanan", typeof(string));
            ordersTable.Columns.Add("Minuman", typeof(string));
            ordersTable.Columns.Add("Porsi", typeof(string));
            ordersTable.Columns.Add("No Meja", typeof(string));
            ordersTable.Columns.Add("Pembayaran", typeof(string));
            ordersTable.Columns.Add("Total Harga", typeof(string));
            ordersTable.Rows.Add(namaPemesan, makanan, minuman, porsi, noMeja, pembayaran, jumlah);
            dgv1.DataSource = ordersTable;

            // Bersihkan input
            txtnamapemesan.Clear();
            cmbMakanan.SelectedIndex = -1;
            cmbMinuman.SelectedIndex = -1;
            txtnomeja.Clear();
            txtporsi.Clear();
            txtnamapemesan.Focus();
            txtnomeja.Focus();
            txtporsi.Focus();
            cmbpembayaran.SelectedIndex = -1;

            lblTotal.Text = jumlah.ToString();
        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {

            // Tambahkan data ComboBox
            cmbMakanan.Items.Add("Nasi Goreng:13.000");
            cmbMakanan.Items.Add("Nasi Padang:15.000");
            cmbMakanan.Items.Add("Sate Ayam:10.000");
            cmbMakanan.Items.Add("Nasi kucing:7.000");
            cmbMinuman.Items.Add("Es Teh:4.000");
            cmbMinuman.Items.Add("Es Jeruk:5.000");
            cmbMinuman.Items.Add("Air Mineral:3.000");
            cmbMinuman.Items.Add("Teh Panas:3.000");

            //Tambahkan data Combobox
            cmbpembayaran.Items.Add("Cash");
            cmbpembayaran.Items.Add("Qris");
            cmbpembayaran.Items.Add("Ovo");
            cmbpembayaran.Items.Add("Dana");
            cmbpembayaran.Items.Add("Gopay");

            // bersihkan selection
            dgv1.ClearSelection();
            cmbpembayaran.SelectedIndex = -1;
            dgv1.DataSource = new object[] {
                };


        }

        private DataGridView GetDgv1()
        {
            return dgv1;
            // return the DataGridView instance

        }

        private void btnclear_Click(object sender, EventArgs e, DataGridView dgv1)
        {

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtporsi_TextChanged(object sender, EventArgs e)
        {

        }


        private void cmbpembayaran_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtnamapemesan_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbMakanan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            if (dgv1.CurrentRow != null)
            {
                dgv1.Rows.RemoveAt(dgv1.CurrentRow.Index);
            }
            else
            {
                MessageBox.Show("Pilih baris yang akan dihapus!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnbayar_Click(object sender, EventArgs e)
        {
            //Hitung Kembalian
            if (!string.IsNullOrEmpty(txttotalbayar.Text))

                if (Convert.ToDouble(txttotalbayar.Text) >= Convert.ToDouble(lblTotal.Text))
                {
                    double kembalian = Convert.ToDouble(txttotalbayar.Text) - Convert.ToDouble(lblTotal.Text);
                    lblkembalian.Text = kembalian.ToString();
                }
                else
                {
                    MessageBox.Show("Uang tidak cukup!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
    }
}

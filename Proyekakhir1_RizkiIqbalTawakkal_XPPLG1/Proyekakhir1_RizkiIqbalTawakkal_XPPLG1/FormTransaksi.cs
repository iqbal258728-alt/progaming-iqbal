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
        public FormTransaksi()
        {
            InitializeComponent();
        }

        private void btnpesan_Click(object sender, EventArgs e)
        {
            //Tombol Pesan
            string namaPemesan = txtnamapemesan.Text;
            string makanan = cmbMakanan.SelectedItem?.ToString() ?? "";
            string minuman = cmbMinuman.SelectedItem?.ToString() ?? "";
            string porsi = txtporsi.Text;
            string noMeja = txtnomeja.Text;

            if (namaPemesan == "" || makanan == "" || minuman == "" ||
             porsi == "" || noMeja == "" || noMeja == null)
            {
                MessageBox.Show("Harap lengkapi semua data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgv1.Rows.Add(namaPemesan, makanan, minuman, porsi, noMeja);

            // Bersihkan input
            txtnamapemesan.Clear();
            cmbMakanan.SelectedIndex = -1;
            cmbMinuman.SelectedIndex = -1;
            txtnomeja.Clear();
            txtporsi.Clear();
            txtnamapemesan.Focus();
            txtnomeja.Focus();
            txtporsi.Focus();
        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            //Tambahkan kolom ke DataGridView
            dgv1.ColumnCount = 5;
            dgv1.Columns[0].Name = "Nama Pemesan";
            dgv1.Columns[1].Name = "Makanan";
            dgv1.Columns[2].Name = "Minuman";
            dgv1.Columns[3].Name = "Porsi";
            dgv1.Columns[4].Name = "No Meja";

            // Tambahkan data ComboBox
            cmbMakanan.Items.Add("Nasi Goreng");
            cmbMakanan.Items.Add("Mie Ayam");
            cmbMakanan.Items.Add("Sate Ayam");
            cmbMakanan.Items.Add("Nasi Goreng");
            cmbMinuman.Items.Add("Es Teh");
            cmbMinuman.Items.Add("Es Jeruk");
            cmbMinuman.Items.Add("Air Mineral");
            cmbMinuman.Items.Add("Teh Panas");
            cmbMinuman.Items.Add("Jus Buah");

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            if(dgv1.CurrentRow != null)
            {
                dgv1.Rows.RemoveAt(dgv1.CurrentRow.Index);
            }
            else
            {
                MessageBox.Show("Pilih baris yang akan dihapus!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

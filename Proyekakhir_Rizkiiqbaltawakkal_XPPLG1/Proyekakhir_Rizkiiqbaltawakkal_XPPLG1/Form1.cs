using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyekakhir_Rizkiiqbaltawakkal_XPPLG1
{
    public partial class FormTransaksi1 : Form
    {
        public FormTransaksi1()
        {
            InitializeComponent();
        }

        public object txtporsi { get; private set; }

        private object GetTxtporsi()
        {
            return txtporsi;
        }

        private void btnPesan_Click(object sender, EventArgs e, object txtporsi)
        {
            //Mengambil data dari input user
            string namaPemesan = txtNama.Text;
            string makanan = cmbmakanan.SelectedItem?.ToString() ?? "";
            string minuman = cmbMinuman.SelectedItem?.ToString() ?? "";
            string porsi = txtPorsi.Text; // Langsung ambil dari TextBox
            string noMeja = txtnomeja.Text;

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
    }
    
}

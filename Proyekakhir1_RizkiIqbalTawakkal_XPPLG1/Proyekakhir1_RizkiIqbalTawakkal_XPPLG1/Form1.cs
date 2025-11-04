namespace Proyekakhir1_RizkiIqbalTawakkal_XPPLG1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            //Username dan password yang benar
            string username = "iqbal";
            string password = "12345";

            //Mengambil input dari user
            string usernameInput = txtusername.Text;
            string passwordInput = txtpassword.Text;

            //Validasi login
            if (usernameInput == username && passwordInput == password)
            {
                //Jika login berhasil
                MessageBox.Show("login berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Membuka form transaksi
                FormTransaksi formTransaksi = new FormTransaksi();
                formTransaksi.Show();

                //Menyembunyikan form login(bukan menutup,AGAR APLIKASI TIDAK BERHENTI)
                this.Hide();
            }
            else
            {
                //Jika login gagal
                MessageBox.Show("username atau password salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Membersihkan field password
                txtpassword.Clear();
                txtpassword.Focus();
            }
        }
    }
}

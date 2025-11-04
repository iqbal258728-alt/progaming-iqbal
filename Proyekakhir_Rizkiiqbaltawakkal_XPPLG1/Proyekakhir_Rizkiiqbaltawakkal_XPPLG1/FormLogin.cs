namespace Proyekakhir_Rizkiiqbaltawakkal_XPPLG1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            //username dan password yang benar
            string usernameTrue = "IQBAL";
            string passwordtrue = "12345";

            //Mengambil Input dari user
            string usernameInput = txtusername.Text;
            string passwordInput = txtpassword.Text;

            //validasi Login
            if (usernameInput == usernameTrue && passwordInput == passwordtrue)
            {
                // jika login Berhasil
                MessageBox.Show("Login Berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Membuka Transaksi
                //FormTransaksi1 formTransaksi = new FormTransaksi1();
                //formTransaksi.Show();

                // ke menu transaksi
                FormTransaksi formTransaksi = new FormTransaksi();
                formTransaksi.Show();



                // Menyembunyikan Form Login (bukan menutup, agar aplikasi tidak berhenti)
                this.Hide();
            }
            else
            {
                // Jika Login gagal
                MessageBox.Show("Username atau Password salah!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Membersihkan field password
                txtusername.Clear();
                txtpassword.Focus();
            }
        }
    }
}

namespace CaesarBotNoSalad
{
    public partial class Perexodnik : Form
    {
        public Perexodnik()
        {
            InitializeComponent();
        }

        private void EncrBt_Click(object sender, EventArgs e)
        {
            Encryption encryption = new Encryption();
            encryption.Show();
            this.Hide();
        }

        private void DecrBt_Click(object sender, EventArgs e)
        {
            Decryption decryption = new Decryption();
            decryption.Show();
            this.Hide();
        }
    }
}
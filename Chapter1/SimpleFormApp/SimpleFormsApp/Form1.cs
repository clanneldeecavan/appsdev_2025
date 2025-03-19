namespace SimpleFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            string fnameValue = this.firstName.Text;
            string mnameValue = this.middleName.Text;
            string lnameValue = this.lastName.Text;
            string snameValue = this.suffixName.Text;
            MessageBox.Show($"Hello There! {fnameValue} {mnameValue} {lnameValue} {snameValue}", "Greetings", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

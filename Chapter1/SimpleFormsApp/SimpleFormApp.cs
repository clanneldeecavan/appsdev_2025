namespace SimpleFormsApp
{
    public partial class SimpleFormApp : Form
    {
        public SimpleFormApp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fnameValue = firstName.Text;
            string mnameValue = middleName.Text;
            string lnameValue = lastName.Text;
            string snameValue = suffixName.Text;

            MessageBox.Show($"Hello World! {fnameValue} {mnameValue} {lnameValue} {snameValue}", "Greetings", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void suffixName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

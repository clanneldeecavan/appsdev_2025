namespace SimpleFormsAppWithMessageBoxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to submit?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

                string fnameValue = firstName.Text;
                string mnameValue = middleName.Text;
                string lnameValue = lastName.Text;
                string snameValue = suffixName.Text;


                MessageBox.Show($"Hello There! {fnameValue} {mnameValue} {lnameValue} {snameValue}", "Greetings!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addBttn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBox.Text) && !lstBox.Items.Contains(txtBox.Text))
            {
                lstBox.Items.Add(txtBox.Text);
            }
        }

        private void dltBttn_Click(object sender, EventArgs e)
        {
            if (lstBox.SelectedIndex != -1)
            {
                lstBox.Items.RemoveAt(lstBox.SelectedIndex);
            }
        }

        private void clrBttn_Click(object sender, EventArgs e)
        {
            lstBox.Items.Clear();
        }

        private void lstBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

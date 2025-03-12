namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] fruits = { "Apple", "RealMe", "Xiaomi", "Samsung", "Nokia", "CherryMobile", "BlackBerry", "Huawei", "Oppo", "Vivo", "Sony" };
            phoneCheckBox.Items.AddRange(fruits);
            phoneCheckBox.CheckOnClick = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checklistbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            foreach (var fruit in phoneCheckBox.Items)
            {
                bool isSelected = phoneCheckBox.GetItemChecked(phoneCheckBox.Items.IndexOf(fruit));
                if (isSelected && !phonetListBox.Items.Contains(fruit))
                {
                    phonetListBox.Items.Add(fruit);
                }
            }
        }

        private void dltButton_Click(object sender, EventArgs e)
        {
            if (phonetListBox.Items.Count >= 1)
            {
                phonetListBox.Items.Remove(phonetListBox.SelectedItem);
            }
        }

        private void clrButton_Click(object sender, EventArgs e)
        {
            phonetListBox.Items.Clear();
        }

        private void slctButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < phoneCheckBox.Items.Count; ++i)
            {
                phoneCheckBox.SetItemChecked(i, true);

            }
        }

        private void cnclButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < phoneCheckBox.Items.Count; ++i)
            {
                phoneCheckBox.SetItemChecked(i, false);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

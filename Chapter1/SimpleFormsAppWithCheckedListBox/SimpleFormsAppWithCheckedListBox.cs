namespace SimpleFormsAppWithCheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] movie = { "The Simpsons", "Rick and Morty", "Squid Game", "Venom", "Big Hero", "The Incredible" };
            checkBox.Items.AddRange(movie);
            checkBox.CheckOnClick = true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            foreach (var item in checkBox.Items)
            {
                bool isSelected = checkBox.GetItemChecked(checkBox.Items.IndexOf(item));
                if (isSelected && !listBox.Items.Contains(item))
                {
                    listBox.Items.Add(item);
                }
            }
        }

        private void rmvButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                listBox.Items.Remove(listBox.SelectedIndex);
            }
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkBox.Items.Count; ++i)
            {
                checkBox.SetItemChecked(i, true);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void clrButton_Click(object sender, EventArgs e)
        {
            for (int i = 0;i < checkBox.Items.Count;++i)
            {
                checkBox.SetItemChecked(i, false);
            }
        }
    }
}

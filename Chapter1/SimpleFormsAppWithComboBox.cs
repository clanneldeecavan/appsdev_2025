namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] foodCuisine = { "Filipino", "Japanese", "Korean", "Chinese" };
            comboBox.Items.AddRange(foodCuisine);

            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.SelectedIndex = 0;
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void slctButton_Click(object sender, EventArgs e)
        {
            string[] filipinoFoodList = { "Adobo", "Lumpia", "Kare-Kare", "Dinuguan", "Sisig", "Pancit", "Tinola", "Sinigang", "Lechon", "Bicol Express" };
            string[] japaneseFoodList = { "Ramen", "Sushi", "Onigiri", "Takoyaki", "Sashimi", "Tempura", "Kabayaki", "Tofu", "Oden", "Yakisoba" };
            string[] koreanFoodList = { "Kimchi", "Tteokboki", "Buldak", "Bibimbap", "Japchae", "Bulgogi", "Samgyeopsal", "Kimbap", "Galdi", "Yakbap" };
            string[] chineseFoodList = { "Chop Suey", "Dim Sum", "Spring Rolls", "Zongzi", "Char Siu", "Hot Pot", "Baozi", "Chili Crab", "Chow Mein", "Dumplings" };

            foodCheckList.Items.Clear();

            if (comboBox.SelectedItem.ToString().Contains("Filipino"))
            {
                foodCheckList.Items.AddRange(filipinoFoodList);
            }
            else if (comboBox.SelectedItem.ToString().Contains("Japanese"))
            {
                foodCheckList.Items.AddRange(japaneseFoodList);
            }
            else if (comboBox.SelectedItem.ToString().Contains("Korean"))
            {
                foodCheckList.Items.AddRange(koreanFoodList);
            }
            else if (comboBox.SelectedItem.ToString().Contains("Chinese"))
            {
                foodCheckList.Items.AddRange(chineseFoodList);
            }
        }

        private void foodCheckList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            foreach (var item in foodCheckList.CheckedItems)
            {
                if (!foodListBox.Items.Contains(item))
                {
                    foodListBox.Items.Add(item);
                }
            }
        }

        private void foodListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rmvButton_Click(object sender, EventArgs e)
        {
            if (foodListBox.Items.Count >= 1)
            {
                foodListBox.Items.Remove(foodListBox.SelectedItem);
            }
        }

        private void clrButton_Click(object sender, EventArgs e)
        {
            foodListBox.Items.Clear();
        }

        private void slctalButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < foodCheckList.Items.Count; i++)
            {
                foodCheckList.SetItemChecked(i, true);
            }
        }
    }
}

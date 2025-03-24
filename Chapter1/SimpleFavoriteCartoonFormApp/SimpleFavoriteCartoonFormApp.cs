using System.Diagnostics;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] cartoons = { "Stitch", "Sonic", "Doraemon", "Megamind", "Bluey"};
            comboBox1.Items.AddRange(cartoons);

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            string selectedCharacter = comboBox1.SelectedItem.ToString();
            switch (selectedCharacter)
            {
                case "Stitch":
                    pictureBox.Image = Image.FromFile(@"C:\Users\OO114\Downloads\lilo & stitch (2002) (1).jpg");
                    break;
                case "Sonic":
                    pictureBox.Image = Image.FromFile(@"C:\Users\OO114\Downloads\Sonic (1).jpg");
                    break;
                case "Doraemon":
                    pictureBox.Image = Image.FromFile(@"C:\Users\OO114\Downloads\download (1).jpg");
                    break;
                case "Megamind":
                    pictureBox.Image = Image.FromFile(@"C:\Users\OO114\Downloads\Megamind (1).jpg");
                    break;
                case "Bluey":
                    pictureBox.Image = Image.FromFile(@"C:\Users\OO114\Downloads\TV shop - Bluey (1).jpg");
                    break;
            }

            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
        }
    }
}

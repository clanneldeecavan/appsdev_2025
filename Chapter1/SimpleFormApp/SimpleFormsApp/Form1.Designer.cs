namespace SimpleFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            firstName = new TextBox();
            middleName = new TextBox();
            lastName = new TextBox();
            suffixName = new TextBox();
            fnameValue = new Label();
            mnameValue = new Label();
            lnameValue = new Label();
            snameValue = new Label();
            button = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(230, 44);
            label1.Name = "label1";
            label1.Size = new Size(361, 33);
            label1.TabIndex = 0;
            label1.Text = "Simple Form Application";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.plain_white_background_or_wallpaper_abstract_image_2E064N7;
            pictureBox1.Location = new Point(195, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(418, 398);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(300, 116);
            label3.Name = "label3";
            label3.Size = new Size(194, 19);
            label3.TabIndex = 3;
            label3.Text = "Simple Form Application";
            // 
            // firstName
            // 
            firstName.Location = new Point(280, 182);
            firstName.Name = "firstName";
            firstName.Size = new Size(235, 23);
            firstName.TabIndex = 4;
            // 
            // middleName
            // 
            middleName.Location = new Point(280, 245);
            middleName.Name = "middleName";
            middleName.Size = new Size(235, 23);
            middleName.TabIndex = 5;
            // 
            // lastName
            // 
            lastName.Location = new Point(280, 311);
            lastName.Name = "lastName";
            lastName.Size = new Size(235, 23);
            lastName.TabIndex = 6;
            // 
            // suffixName
            // 
            suffixName.Location = new Point(280, 376);
            suffixName.Name = "suffixName";
            suffixName.Size = new Size(235, 23);
            suffixName.TabIndex = 7;
            // 
            // fnameValue
            // 
            fnameValue.AutoSize = true;
            fnameValue.BackColor = Color.White;
            fnameValue.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fnameValue.ForeColor = Color.Black;
            fnameValue.Location = new Point(280, 163);
            fnameValue.Name = "fnameValue";
            fnameValue.Size = new Size(75, 16);
            fnameValue.TabIndex = 9;
            fnameValue.Text = "First Name";
            // 
            // mnameValue
            // 
            mnameValue.AutoSize = true;
            mnameValue.BackColor = Color.White;
            mnameValue.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mnameValue.ForeColor = Color.Black;
            mnameValue.Location = new Point(280, 226);
            mnameValue.Name = "mnameValue";
            mnameValue.Size = new Size(91, 16);
            mnameValue.TabIndex = 10;
            mnameValue.Text = "Middle Name";
            // 
            // lnameValue
            // 
            lnameValue.AutoSize = true;
            lnameValue.BackColor = Color.White;
            lnameValue.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnameValue.ForeColor = Color.Black;
            lnameValue.Location = new Point(280, 292);
            lnameValue.Name = "lnameValue";
            lnameValue.Size = new Size(74, 16);
            lnameValue.TabIndex = 11;
            lnameValue.Text = "Last Name";
            // 
            // snameValue
            // 
            snameValue.AutoSize = true;
            snameValue.BackColor = Color.White;
            snameValue.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            snameValue.ForeColor = Color.Black;
            snameValue.Location = new Point(280, 357);
            snameValue.Name = "snameValue";
            snameValue.Size = new Size(44, 16);
            snameValue.TabIndex = 12;
            snameValue.Text = "Suffix";
            // 
            // button
            // 
            button.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button.ForeColor = Color.Black;
            button.Location = new Point(330, 416);
            button.Name = "button";
            button.Size = new Size(125, 36);
            button.TabIndex = 8;
            button.Text = "Submit";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(835, 524);
            Controls.Add(snameValue);
            Controls.Add(lnameValue);
            Controls.Add(mnameValue);
            Controls.Add(fnameValue);
            Controls.Add(button);
            Controls.Add(suffixName);
            Controls.Add(lastName);
            Controls.Add(middleName);
            Controls.Add(firstName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            ForeColor = Color.DarkSeaGreen;
            Name = "Form1";
            Text = "SimpleFormsApp";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private TextBox firstName;
        private TextBox middleName;
        private TextBox lastName;
        private TextBox suffixName;
        private Label fnameValue;
        private Label mnameValue;
        private Label lnameValue;
        private Label snameValue;
        private Button button;
    }
}

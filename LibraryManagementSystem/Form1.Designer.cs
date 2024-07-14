namespace LibraryManagementSystem
{
    partial class Form1
    {
        List<Book> BookList = new List<Book>();
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBoxName = new TextBox();
            textBoxAuthor = new TextBox();
            textBoxManu = new TextBox();
            textBoxPublish = new TextBox();
            textBoxPrice = new TextBox();
            textBoxLang = new TextBox();
            textBoxSemes = new TextBox();
            buttonAdd = new Button();
            groupBox = new GroupBox();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label25 = new Label();
            labelSemes = new Label();
            labelLang = new Label();
            labelPrice = new Label();
            labelPublish = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            labelManu = new Label();
            labelAuthor = new Label();
            labelName = new Label();
            labelID = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            listBoxBook = new ListBox();
            buttonShow = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            label8 = new Label();
            textBoxID = new TextBox();
            menuStrip1.SuspendLayout();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1128, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            fileToolStripMenuItem.Size = new Size(57, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(152, 34);
            newToolStripMenuItem.Text = "New";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(152, 34);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 118);
            label1.Name = "label1";
            label1.Size = new Size(131, 25);
            label1.TabIndex = 1;
            label1.Text = "Name of book";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 172);
            label2.Name = "label2";
            label2.Size = new Size(145, 25);
            label2.TabIndex = 2;
            label2.Text = "Name of author";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 235);
            label3.Name = "label3";
            label3.Size = new Size(174, 25);
            label3.TabIndex = 3;
            label3.Text = "Manufactor's name";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(370, 63);
            label4.Name = "label4";
            label4.Size = new Size(142, 25);
            label4.TabIndex = 4;
            label4.Text = "Publishing year";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(370, 121);
            label5.Name = "label5";
            label5.Size = new Size(150, 25);
            label5.TabIndex = 5;
            label5.Text = "Price of book ($)";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(392, 172);
            label6.Name = "label6";
            label6.Size = new Size(95, 25);
            label6.TabIndex = 6;
            label6.Text = "Language";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(392, 238);
            label7.Name = "label7";
            label7.Size = new Size(89, 25);
            label7.TabIndex = 7;
            label7.Text = "Semester";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(180, 115);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(150, 33);
            textBoxName.TabIndex = 8;
            textBoxName.TextChanged += textBox1_TextChanged;
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Location = new Point(180, 169);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(150, 33);
            textBoxAuthor.TabIndex = 9;
            // 
            // textBoxManu
            // 
            textBoxManu.Location = new Point(180, 235);
            textBoxManu.Name = "textBoxManu";
            textBoxManu.Size = new Size(150, 33);
            textBoxManu.TabIndex = 10;
            // 
            // textBoxPublish
            // 
            textBoxPublish.Location = new Point(518, 57);
            textBoxPublish.Name = "textBoxPublish";
            textBoxPublish.Size = new Size(150, 33);
            textBoxPublish.TabIndex = 11;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(518, 118);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(150, 33);
            textBoxPrice.TabIndex = 12;
            // 
            // textBoxLang
            // 
            textBoxLang.Location = new Point(518, 169);
            textBoxLang.Name = "textBoxLang";
            textBoxLang.Size = new Size(150, 33);
            textBoxLang.TabIndex = 13;
            textBoxLang.TextChanged += textBox6_TextChanged;
            // 
            // textBoxSemes
            // 
            textBoxSemes.Location = new Point(518, 227);
            textBoxSemes.Name = "textBoxSemes";
            textBoxSemes.Size = new Size(150, 33);
            textBoxSemes.TabIndex = 14;
            textBoxSemes.TextChanged += textBoxSemes_TextChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = SystemColors.InactiveCaption;
            buttonAdd.Location = new Point(695, 51);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(112, 34);
            buttonAdd.TabIndex = 15;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // groupBox
            // 
            groupBox.Controls.Add(label24);
            groupBox.Controls.Add(label23);
            groupBox.Controls.Add(label22);
            groupBox.Controls.Add(label21);
            groupBox.Controls.Add(label16);
            groupBox.Controls.Add(label15);
            groupBox.Controls.Add(label14);
            groupBox.Controls.Add(label13);
            groupBox.Controls.Add(label25);
            groupBox.Controls.Add(labelSemes);
            groupBox.Controls.Add(labelLang);
            groupBox.Controls.Add(labelPrice);
            groupBox.Controls.Add(labelPublish);
            groupBox.Controls.Add(label20);
            groupBox.Controls.Add(label19);
            groupBox.Controls.Add(label18);
            groupBox.Controls.Add(label17);
            groupBox.Controls.Add(labelManu);
            groupBox.Controls.Add(labelAuthor);
            groupBox.Controls.Add(labelName);
            groupBox.Controls.Add(labelID);
            groupBox.Controls.Add(label12);
            groupBox.Controls.Add(label11);
            groupBox.Controls.Add(label10);
            groupBox.Controls.Add(label9);
            groupBox.Location = new Point(18, 308);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(777, 250);
            groupBox.TabIndex = 17;
            groupBox.TabStop = false;
            groupBox.Text = "Book's details";
            groupBox.Enter += groupBox_Enter;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(655, 204);
            label24.Name = "label24";
            label24.Size = new Size(0, 25);
            label24.TabIndex = 24;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(655, 150);
            label23.Name = "label23";
            label23.Size = new Size(0, 25);
            label23.TabIndex = 23;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(643, 98);
            label22.Name = "label22";
            label22.Size = new Size(0, 25);
            label22.TabIndex = 22;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(628, 50);
            label21.Name = "label21";
            label21.Size = new Size(0, 25);
            label21.TabIndex = 21;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(169, 204);
            label16.Name = "label16";
            label16.Size = new Size(0, 25);
            label16.TabIndex = 20;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(170, 155);
            label15.Name = "label15";
            label15.Size = new Size(0, 25);
            label15.TabIndex = 19;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(169, 102);
            label14.Name = "label14";
            label14.Size = new Size(0, 25);
            label14.TabIndex = 18;
            label14.Click += label14_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(160, 53);
            label13.Name = "label13";
            label13.Size = new Size(0, 25);
            label13.TabIndex = 17;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(16, 99);
            label25.Name = "label25";
            label25.Size = new Size(118, 25);
            label25.TabIndex = 16;
            label25.Text = "Book's name";
            // 
            // labelSemes
            // 
            labelSemes.AutoSize = true;
            labelSemes.Location = new Point(677, 202);
            labelSemes.Name = "labelSemes";
            labelSemes.Size = new Size(12, 25);
            labelSemes.TabIndex = 15;
            labelSemes.Text = "\r\n";
            // 
            // labelLang
            // 
            labelLang.AutoSize = true;
            labelLang.Location = new Point(677, 151);
            labelLang.Name = "labelLang";
            labelLang.Size = new Size(0, 25);
            labelLang.TabIndex = 14;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(677, 99);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(0, 25);
            labelPrice.TabIndex = 13;
            // 
            // labelPublish
            // 
            labelPublish.AutoSize = true;
            labelPublish.Location = new Point(677, 51);
            labelPublish.Name = "labelPublish";
            labelPublish.Size = new Size(0, 25);
            labelPublish.TabIndex = 12;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(518, 202);
            label20.Name = "label20";
            label20.Size = new Size(89, 25);
            label20.TabIndex = 11;
            label20.Text = "Semester";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(518, 151);
            label19.Name = "label19";
            label19.Size = new Size(95, 25);
            label19.TabIndex = 10;
            label19.Text = "Language";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(518, 99);
            label18.Name = "label18";
            label18.Size = new Size(81, 25);
            label18.TabIndex = 9;
            label18.Text = "Price ($)";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(518, 51);
            label17.Name = "label17";
            label17.Size = new Size(48, 25);
            label17.TabIndex = 8;
            label17.Text = "Year";
            // 
            // labelManu
            // 
            labelManu.AutoSize = true;
            labelManu.Location = new Point(162, 202);
            labelManu.Name = "labelManu";
            labelManu.Size = new Size(0, 25);
            labelManu.TabIndex = 7;
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Location = new Point(162, 151);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(0, 25);
            labelAuthor.TabIndex = 6;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(162, 99);
            labelName.Name = "labelName";
            labelName.Size = new Size(0, 25);
            labelName.TabIndex = 5;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(162, 51);
            labelID.Name = "labelID";
            labelID.Size = new Size(0, 25);
            labelID.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(16, 202);
            label12.Name = "label12";
            label12.Size = new Size(110, 25);
            label12.TabIndex = 3;
            label12.Text = "Manufactor";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(16, 153);
            label11.Name = "label11";
            label11.Size = new Size(70, 25);
            label11.TabIndex = 2;
            label11.Text = "Author";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 99);
            label10.Name = "label10";
            label10.Size = new Size(0, 25);
            label10.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 51);
            label9.Name = "label9";
            label9.Size = new Size(77, 25);
            label9.TabIndex = 0;
            label9.Text = "Book ID";
            // 
            // listBoxBook
            // 
            listBoxBook.FormattingEnabled = true;
            listBoxBook.ItemHeight = 25;
            listBoxBook.Location = new Point(813, 50);
            listBoxBook.Name = "listBoxBook";
            listBoxBook.Size = new Size(303, 504);
            listBoxBook.TabIndex = 18;
            listBoxBook.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // buttonShow
            // 
            buttonShow.BackColor = SystemColors.InactiveCaption;
            buttonShow.Location = new Point(695, 109);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(112, 34);
            buttonShow.TabIndex = 19;
            buttonShow.Text = "Show all";
            buttonShow.UseVisualStyleBackColor = false;
            buttonShow.Click += buttonShow_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = SystemColors.InactiveCaption;
            buttonUpdate.Location = new Point(695, 168);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(112, 34);
            buttonUpdate.TabIndex = 21;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = SystemColors.InactiveCaption;
            buttonDelete.Location = new Point(695, 225);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(112, 34);
            buttonDelete.TabIndex = 22;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(44, 63);
            label8.Name = "label8";
            label8.Size = new Size(77, 25);
            label8.TabIndex = 23;
            label8.Text = "Book ID";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(180, 60);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(150, 33);
            textBoxID.TabIndex = 24;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 581);
            Controls.Add(textBoxID);
            Controls.Add(label8);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonShow);
            Controls.Add(listBoxBook);
            Controls.Add(groupBox);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxSemes);
            Controls.Add(textBoxLang);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxPublish);
            Controls.Add(textBoxManu);
            Controls.Add(textBoxAuthor);
            Controls.Add(textBoxName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Library Management System";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBoxName;
        private TextBox textBoxAuthor;
        private TextBox textBoxManu;
        private TextBox textBoxPublish;
        private TextBox textBoxPrice;
        private TextBox textBoxLang;
        private TextBox textBoxSemes;
        private Button buttonAdd;
        private GroupBox groupBox;
        private ListBox listBoxBook;
        private Button buttonShow;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Label label8;
        private TextBox textBoxID;
        private Label labelSemes;
        private Label labelLang;
        private Label labelPrice;
        private Label labelPublish;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label labelManu;
        private Label labelAuthor;
        private Label labelName;
        private Label labelID;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label25;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label label21;
    }
}

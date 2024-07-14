namespace LibraryManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBoxBook.SelectedIndex;



            if (selectedIndex >= 0 && selectedIndex < BookList.Count)
            {
                // Retrieve the selected book from the BookList using the selected index
                Book selectedBook = BookList[selectedIndex];

                // Update the text boxes with the selected book's details
                textBoxName.Text = selectedBook.Title;
                textBoxAuthor.Text = selectedBook.Author;
                // Update other text boxes as needed

                // Show all book details in the group box
                groupBox.Text = "Book Details";
                label9.Text = $"Name: {selectedBook.Title}";
                label25.Text = $"Author: {selectedBook.Author}";
                // Update other labels as needed
            }
        }

        private Book? GetBookByTitle(string title)
        {
            foreach (Book book in BookList)
            {
                if (book.Title.Equals(title))
                {
                    return book;
                }
            }

            // Return null or throw an exception if the book is not found
            return null;
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxID.Text);
            string name = textBoxName.Text;
            string author = textBoxAuthor.Text;
            string manu = textBoxManu.Text;
            int publish = int.Parse(textBoxPublish.Text);
            int price = int.Parse(textBoxPrice.Text);
            string lang = textBoxLang.Text;
            string semes = textBoxSemes.Text;
            Book book = new Book(id, name, author, manu, publish, price, lang, semes);

            listBoxBook.Items.Add(book.Title);
            MessageBox.Show("Book added successfully!");
        }

        private void textBoxSemes_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxBook.SelectedIndex;

            if (listBoxBook.SelectedIndex >= 0)
            {
                label13.Text = int.Parse(textBoxID.Text).ToString();
                label14.Text = textBoxName.Text.ToString();
                label15.Text = textBoxAuthor.Text.ToString();
                label16.Text = textBoxManu.Text.ToString();
                label21.Text = int.Parse(textBoxPublish.Text).ToString();
                label22.Text = int.Parse(textBoxPrice.Text).ToString();
                label23.Text = textBoxLang.Text;
                label24.Text = textBoxSemes.Text;
            }
        }



        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxBook.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < BookList.Count)
            {
                Book selectedBook = BookList[selectedIndex];
                selectedBook.Title = textBoxName.Text;
                selectedBook.Author = textBoxAuthor.Text;
                MessageBox.Show("Book details updated successfully.");
            }
            else
            {
                MessageBox.Show("Please select a valid book from the list.");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxBook.SelectedIndex;

            if (listBoxBook.SelectedIndex >= 0)
            {
                listBoxBook.Items.RemoveAt(selectedIndex);
                MessageBox.Show("Book deleted successfully.");
            }
            else
            {
                MessageBox.Show("Please select a valid book from the list.");
            }
        }

        private void ClearTextBoxes()
        {
            throw new NotImplementedException();
        }

        private void groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        // Add this event handler to the constructor or InitializeComponent method


        // Event handler for the SelectedIndexChanged event of listBoxBook


    }
}
using System;
using System.Data;
using System.Linq;

using System.Windows.Forms;

namespace ConsidLibrary
{
    public partial class Form1 : Form
    {

        private SqlQueries sqlQueries = new SqlQueries();
        private DataTable libraryDt;
        private DataTable categoryDt;

        private int selected;
        private int selectedCategory;
        private int menuOption;
        private int sortIndex = 2;
        private int categoryIndex;
        private DataView dv;
        private string type;

        public Form1()
        {

            InitializeComponent();
            populateListView();
            populateCategoryView();
        }

        // Funktion för att sortera type/category
        private void sort()
        {
            switch (sortIndex)
            {
                case 1:
                    dv = libraryDt.DefaultView;
                    dv.Sort = "CategoryName";
                    libraryDt = dv.ToTable();
                    break;
                case 2:
                    dv = libraryDt.DefaultView;
                    dv.Sort = "Type";
                    libraryDt = dv.ToTable();
                    break;

            }

        }

        //uppdaterar listan
        private void populateListView()
        {
            listView1.Clear();
            libraryDt = new DataTable();
            libraryDt = sqlQueries.getLibrary();
            sort();
            listView1.View = View.Details;
            listView1.Columns.Add("Title", 160, HorizontalAlignment.Left);
            listView1.Columns.Add("Author", 80, HorizontalAlignment.Left);
            listView1.Columns.Add("Pages", 45, HorizontalAlignment.Left);
            listView1.Columns.Add("Run time", 45, HorizontalAlignment.Left);
            listView1.Columns.Add("Borrowable", 45, HorizontalAlignment.Left);
            listView1.Columns.Add("Borrower", 80, HorizontalAlignment.Left);
            listView1.Columns.Add("Type", 80, HorizontalAlignment.Left);
            listView1.Columns.Add("Category", 80, HorizontalAlignment.Left);
            listView1.Columns.Add("ID", 30, HorizontalAlignment.Left);
            listView1.Columns.Add("Date", 45, HorizontalAlignment.Left);

            for (int i = 0; i <= libraryDt.Rows.Count - 1; i++)
            {

                listView1.Items.Add(libraryDt.Rows[i].ItemArray[0].ToString() + " (" + makeAcronym(libraryDt.Rows[i].ItemArray[0].ToString() + " )"));
                listView1.Items[i].SubItems.Add(libraryDt.Rows[i].ItemArray[1].ToString());
                listView1.Items[i].SubItems.Add(libraryDt.Rows[i].ItemArray[2].ToString());
                listView1.Items[i].SubItems.Add(libraryDt.Rows[i].ItemArray[3].ToString());
                listView1.Items[i].SubItems.Add(libraryDt.Rows[i].ItemArray[4].ToString());
                listView1.Items[i].SubItems.Add(libraryDt.Rows[i].ItemArray[5].ToString());
                listView1.Items[i].SubItems.Add(libraryDt.Rows[i].ItemArray[6].ToString());
                listView1.Items[i].SubItems.Add(libraryDt.Rows[i].ItemArray[7].ToString());
                listView1.Items[i].SubItems.Add(libraryDt.Rows[i].ItemArray[8].ToString());
                listView1.Items[i].SubItems.Add(libraryDt.Rows[i].ItemArray[9].ToString());





            }

        }

        //lägger till värden i databasen
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (radioBtnBook.Checked == true || radioBtnAudioBook.Checked == true || radioBtnDVD.Checked == true || radioBtnReferenceBook.Checked == true)
            {

                parseText();
            }

            else
            {
                MessageBox.Show("You must choose type");
            }


        }

        //radiobuttons kollar vad är för type som har valts
        private void radioBtnBook_CheckedChanged(object sender, EventArgs e)
        {
            resetTxtBoxes();
            sqlQueries.libraryType(1);
            txtBoxRunTime.Hide();

        }
        private void radioBtnAudioBook_CheckedChanged(object sender, EventArgs e)
        {
            resetTxtBoxes();
            sqlQueries.libraryType(2);
            txtBoxPages.Hide();


        }
        private void radioBtnDVD_CheckedChanged(object sender, EventArgs e)
        {
            resetTxtBoxes();
            sqlQueries.libraryType(3);
            txtBoxPages.Hide();
            txtBoxAuthor.Hide();


        }
        private void radioBtnReferenceBook_CheckedChanged(object sender, EventArgs e)
        {
            resetTxtBoxes();
            sqlQueries.libraryType(4);
            txtBoxRunTime.Hide();


        }

        // hämtar texten från boxarna och validerar
        private void parseText()
        {
            if (radioBtnBook.Checked == true)
            {
                if (string.IsNullOrEmpty(txtBoxAuthor.Text) || string.IsNullOrEmpty(txtBoxTitle.Text) || string.IsNullOrEmpty(txtBoxCategory.Text) || string.IsNullOrEmpty(txtBoxPages.Text))
                {

                    MessageBox.Show("Cannot leave empty spaces");
                }
                else
                {
                    string category = txtBoxCategory.Text;
                    string title = txtBoxTitle.Text;
                    string author = txtBoxAuthor.Text;
                    int pages;
                    if (!int.TryParse(txtBoxPages.Text, out pages))
                    {
                        MessageBox.Show("Pages must contain numbers");
                    }
                    else
                    {

                        sqlQueries.addCategory(title, author, category, pages, 0);
                    }
                    populateListView();
                    populateCategoryView();
                }

            }
            else if (radioBtnAudioBook.Checked == true)
            {
                if (string.IsNullOrEmpty(txtBoxAuthor.Text) || string.IsNullOrEmpty(txtBoxTitle.Text) || string.IsNullOrEmpty(txtBoxCategory.Text) || string.IsNullOrEmpty(txtBoxRunTime.Text))
                {

                    MessageBox.Show("Cannot leave empty spaces");
                }
                else
                {
                    string category = txtBoxCategory.Text;
                    string title = txtBoxTitle.Text;
                    string author = txtBoxAuthor.Text;
                    int runTime;
                    if (!int.TryParse(txtBoxRunTime.Text, out runTime))
                    {
                        MessageBox.Show("Runtime must contain numbers");
                    }
                    else
                    {

                        sqlQueries.addCategory(title, author, category, 0, runTime);
                    }
                    populateListView();
                    populateCategoryView();

                }

            }
            else if (radioBtnDVD.Checked == true)
            {
                if (string.IsNullOrEmpty(txtBoxTitle.Text) || string.IsNullOrEmpty(txtBoxCategory.Text) || string.IsNullOrEmpty(txtBoxRunTime.Text))
                {

                    MessageBox.Show("Cannot leave empty spaces");
                }
                else
                {
                    string category = txtBoxCategory.Text;
                    string title = txtBoxTitle.Text;
                    int runTime;
                    if (!int.TryParse(txtBoxRunTime.Text, out runTime))
                    {
                        MessageBox.Show("Runtime must contain numbers");
                    }
                    else
                    {

                        sqlQueries.addCategory(title, "", category, 0, runTime);
                    }
                    populateListView();
                    populateCategoryView();

                }


            }
            else if (radioBtnReferenceBook.Checked == true)
            {
                if (string.IsNullOrEmpty(txtBoxAuthor.Text) || string.IsNullOrEmpty(txtBoxTitle.Text) || string.IsNullOrEmpty(txtBoxCategory.Text) || string.IsNullOrEmpty(txtBoxPages.Text))
                {

                    MessageBox.Show("Cannot leave empty spaces");
                }
                else
                {
                    string category = txtBoxCategory.Text;
                    string title = txtBoxTitle.Text;
                    string author = txtBoxAuthor.Text;
                    int pages;
                    if (!int.TryParse(txtBoxPages.Text, out pages))
                    {
                        MessageBox.Show("Pages must contain numbers");
                    }
                    else
                    {

                        sqlQueries.addCategory(title, author, category, pages, 0);
                    }
                    populateListView();
                    populateCategoryView();

                }

            }
        }

       //uppdaterar textboxes och vyn
        private void resetTxtBoxes()
        {
            txtBoxAuthor.Show();

            txtBoxPages.Show();

            txtBoxRunTime.Show();

            txtBoxTitle.Show();
        }

        // funktinon för att låna
        private void setBorrow(string borrower)
        {
            if (libraryDt.Rows[selected].ItemArray[4].ToString() == "False")
            {

                MessageBox.Show("Cannot borrow that");

            }
            else if (libraryDt.Rows[selected].ItemArray[5].ToString() == "")
            {

                sqlQueries.borrow(borrower, Int32.Parse(libraryDt.Rows[selected].ItemArray[8].ToString()));
                populateListView();
            }
            else
            {
                MessageBox.Show("Already borrowed");
            }


        }

        //funktion för att ta bort
        private void deleteLibraryItem()
        {
            sqlQueries.deleteLibraryItem(Int32.Parse(libraryDt.Rows[selected].ItemArray[8].ToString()));
            populateListView();
        }

        //lämna tillbaks 
        private void returnLibraryItem()
        {

            if (libraryDt.Rows[selected].ItemArray[5].ToString() != "")
            {
                sqlQueries.returnBorrowedItem(Int32.Parse(libraryDt.Rows[selected].ItemArray[8].ToString()));
                populateListView();
            }
            else { MessageBox.Show("Cant return that"); }

        }

        // meny för olika actions som edit/delete
        private void menu()
        {
            if (menuOption == 1)
            {
                if (string.IsNullOrEmpty(txtBoxBorrow.Text))
                {
                    MessageBox.Show("Enter Name of borrower");
                }
                else { setBorrow(txtBoxBorrow.Text); }
            }
            else if (menuOption == 2)
            {

                deleteLibraryItem();
            }
            else if (menuOption == 3)
            {
                returnLibraryItem();

            }
            else if (menuOption == 4)
            {
                editLibraryItem();
            }


        }

        // gör akronym
        private static string makeAcronym(string str)
        {
            return string.Join(string.Empty, str.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(s => s[0]));
        }

        // uppdaterar category listan
        private void populateCategoryView()
        {

            listView2.Clear();
            categoryDt = new DataTable();
            categoryDt = sqlQueries.getCategory();
            listView2.View = View.Details;
            listView2.Columns.Add("Category Name", 160, HorizontalAlignment.Left);
            listView2.Columns.Add("ID", 80, HorizontalAlignment.Left);

            for (int i = 0; i <= categoryDt.Rows.Count - 1; i++)
            {

                listView2.Items.Add(categoryDt.Rows[i].ItemArray[0].ToString());
                listView2.Items[i].SubItems.Add(categoryDt.Rows[i].ItemArray[1].ToString());

            }

        }

        // uppdaterar ett index som används i menyn funktionen
        private void radioBtnEdit_CheckedChanged(object sender, EventArgs e)
        {
            menuOption = 4;

        }
        private void radioBtnReturn_CheckedChanged(object sender, EventArgs e)
        {
            menuOption = 3;

        }
        private void radioBtnBorrow_CheckedChanged(object sender, EventArgs e)
        {
            menuOption = 1;

        }
        private void radioBtnDelete_CheckedChanged(object sender, EventArgs e)
        {
            menuOption = 2;
        }

        // lyssnar på click som händer i category listan
        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            try
            {
                selectedCategory = listView2.SelectedIndices[0];

                if (selectedCategory != null)
                {
                    if (categoryIndex == 1)
                    {
                        checkIfCategoryReferenced();
                    }
                    else if (categoryIndex == 2) {
                        txtBoxEditCategory.Text = sqlQueries.getCategoryWithId(Int32.Parse(categoryDt.Rows[selectedCategory].ItemArray[1].ToString()));
                    }
                }
            }
            catch (Exception ex) { }
        }

        // lyssnar på click i library listan
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selected = listView1.SelectedIndices[0];

                if (selected != null)
                {
                    menu();
                }

            }
            catch (Exception ex) { }
        }

        // kollar om categoryn finns
        private void checkIfCategoryReferenced()
        {
            DataRow[] foundCategory = libraryDt.Select("CategoryName = '" + categoryDt.Rows[selectedCategory].ItemArray[0].ToString() + "'");
            if (foundCategory.Length != 0)
            {
                MessageBox.Show("That category is referenced");
            }
            else
            {
                sqlQueries.deleteCategory(Int32.Parse(categoryDt.Rows[selectedCategory].ItemArray[1].ToString()));
                populateCategoryView();

            }

        }

        // editar library item
        private void editLibraryItem() {
            string Title, Author, category;
            int pages, runtime;
            resetTxtBoxes();
            if (libraryDt.Rows[selected].ItemArray[6].ToString() == "Book") {
                txtBoxRunTime.Hide();
                txtBoxPages.Text = libraryDt.Rows[selected].ItemArray[2].ToString();
                txtBoxAuthor.Text = libraryDt.Rows[selected].ItemArray[1].ToString();
                txtBoxTitle.Text = libraryDt.Rows[selected].ItemArray[0].ToString();
                type = "Book";
            }
            else if (libraryDt.Rows[selected].ItemArray[6].ToString() == "DVD")
            {
                txtBoxAuthor.Hide();
                txtBoxPages.Hide();
                txtBoxTitle.Text = libraryDt.Rows[selected].ItemArray[0].ToString();
                txtBoxRunTime.Text = libraryDt.Rows[selected].ItemArray[3].ToString();

                type = "DVD";
            }
            else if (libraryDt.Rows[selected].ItemArray[6].ToString() == "Reference Book")
            {
                txtBoxRunTime.Hide();
                type = "Reference Book";
                txtBoxPages.Text = libraryDt.Rows[selected].ItemArray[2].ToString();
                txtBoxAuthor.Text = libraryDt.Rows[selected].ItemArray[1].ToString();
                txtBoxTitle.Text = libraryDt.Rows[selected].ItemArray[0].ToString();
                
            }
            else if (libraryDt.Rows[selected].ItemArray[6].ToString() == "Audio Book")
            {
                txtBoxPages.Hide();
                type = "Audio Book";
                txtBoxRunTime.Text = libraryDt.Rows[selected].ItemArray[3].ToString();
                txtBoxAuthor.Text = libraryDt.Rows[selected].ItemArray[1].ToString();
                txtBoxTitle.Text = libraryDt.Rows[selected].ItemArray[0].ToString();
            }
        }

        // kollar vad man har valt för action i categorylistan delete eller edit
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            categoryIndex = 1;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            categoryIndex = 2;
        }

        // när man klickar på submit så editas categoryn
        private void button1_Click(object sender, EventArgs e)
        {
            sqlQueries.editCategory(txtBoxEditCategory.Text, Int32.Parse(categoryDt.Rows[selectedCategory].ItemArray[1].ToString()));
            populateListView();
            populateCategoryView();
        }
        // editar libraryitem
        private void btnLibraryItemEdit_Click(object sender, EventArgs e)
        {
            if (type == "Book")
            {

                sqlQueries.editLibraryItem(txtBoxAuthor.Text, txtBoxTitle.Text, Int32.Parse(txtBoxPages.Text), 0, Int32.Parse(libraryDt.Rows[selected].ItemArray[8].ToString()),type);
            }
            else if (type == "DVD") {
                sqlQueries.editLibraryItem(" ", txtBoxTitle.Text, 0, Int32.Parse(txtBoxRunTime.Text), Int32.Parse(libraryDt.Rows[selected].ItemArray[8].ToString()), type);

            }
            else if (type == "Reference Book") { sqlQueries.editLibraryItem(txtBoxAuthor.Text, txtBoxTitle.Text, Int32.Parse(txtBoxPages.Text), 0, Int32.Parse(libraryDt.Rows[selected].ItemArray[8].ToString()), type); }
            else if (type == "Audio Book") { sqlQueries.editLibraryItem(txtBoxAuthor.Text, txtBoxTitle.Text, 0, Int32.Parse(txtBoxRunTime.Text), Int32.Parse(libraryDt.Rows[selected].ItemArray[8].ToString()), type); }
            populateListView();

        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        // sorterar 
        private void button2_Click(object sender, EventArgs e)
        {
            sortIndex = 2;
            populateListView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sortIndex = 1;
            populateListView();
        }

        private void txtBoxTitle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

       
    




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using ConsidLibrary;
using System.Data;

namespace ConsidLibrary

{
    public class SqlQueries
    {

        private int mItem;
        private string mCategory;
        private string mTitle;
        private string mAuthor;
        private int mPages;
        private int mRunTime;
        private string connectionString = "Server=.\\SQLEXPRESS01;Database=ConsidUppgift;Integrated Security=True";



        public void addCategory(string title, string author, string category, int pages, int runTime)
        {
            mCategory = category;
            mTitle = title;
            mAuthor = author;
            mPages = pages;
            mRunTime = runTime;

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand categoryNameCommand = new SqlCommand("INSERT INTO Category (CategoryName) VALUES (@category)", connection);

            if (!checkCategoryExist(category))
            {
                categoryNameCommand.Parameters.Add("@category", SqlDbType.VarChar).Value = category;
                categoryNameCommand.ExecuteNonQuery();
                addLibraryItem();

            }
            else
            {
                addLibraryItem();
            }

        }

        public bool checkCategoryExist(string categoryCheck)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) FROM Category WHERE CategoryName LIKE @categoryCheck ", connection);

            sqlCommand.Parameters.AddWithValue("@categoryCheck", categoryCheck);
            int userCount = (int)sqlCommand.ExecuteScalar();

            if (userCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public int getCategoryID(string categoryName)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT Id FROM Category WHERE CategoryName LIKE @categoryName", connection);
            cmd.Parameters.AddWithValue("@categoryName", categoryName);
            int id = (int)cmd.ExecuteScalar();
            return id;

        }

        public DataTable getCategory() {
            var dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            string sql = "SELECT CategoryName, Id FROM Category";
            SqlCommand cmd = new SqlCommand(sql, connection);
            using (var da = new SqlDataAdapter(sql, connection))
            {
                da.Fill(dataTable);

            }
            return dataTable;
        }
        
        public DataTable getLibrary()
        {
            var dataTable = new DataTable();
          
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            string sql = "SELECT Title, Author, Pages, RunTimeMinutes, IsBorrowable, Borrower, Type, Category.CategoryName, LibraryItem.ID, BorrowDate FROM LibraryItem" +
                " INNER JOIN Category " +
                " ON  LibraryItem.CategoryId = Category.Id ";
            SqlCommand cmd = new SqlCommand(sql, connection);
            using (var da = new SqlDataAdapter(sql, connection))
            {
                da.Fill(dataTable);

            }
            return dataTable;
            
        }

        public void addLibraryItem()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            //adds book
            if (mItem == 1)
            {
                SqlCommand commandCategory = new SqlCommand("INSERT INTO LibraryItem ([Title], [Author], [Pages], [Borrower], [IsBorrowable], [Type], [CategoryId]) VALUES (@title, @author, @pages, " +
                    "@borrower, @isborrowable, @type, @categoryid)", connection);
                commandCategory.Parameters.Add("@title", SqlDbType.VarChar).Value = mTitle;
                commandCategory.Parameters.Add("@author", SqlDbType.VarChar).Value = mAuthor;
                commandCategory.Parameters.Add("@pages", SqlDbType.Int).Value = mPages;
                commandCategory.Parameters.Add("@borrower", SqlDbType.VarChar).Value = "";
                commandCategory.Parameters.Add("@isborrowable", SqlDbType.Bit).Value = true;
                commandCategory.Parameters.Add("@type", SqlDbType.VarChar).Value = "Book";
                commandCategory.Parameters.Add("@categoryid", SqlDbType.Int).Value = getCategoryID(mCategory);

                commandCategory.ExecuteNonQuery();
            }
            // adds audio book
            else if (mItem == 2)
            {


                SqlCommand commandCategory = new SqlCommand("INSERT INTO LibraryItem ([Title],[Author], [RunTimeMinutes], [Borrower], [IsBorrowable], [Type], [CategoryId]) VALUES (@title,@author, @runTime, " +
                    "@borrower, @isborrowable, @type, @categoryid )", connection);
                commandCategory.Parameters.Add("@title", SqlDbType.VarChar).Value = mTitle;
                commandCategory.Parameters.Add("@author", SqlDbType.VarChar).Value = mAuthor;
                commandCategory.Parameters.Add("@runTime", SqlDbType.VarChar).Value = mRunTime;
                commandCategory.Parameters.Add("@borrower", SqlDbType.VarChar).Value = "";
                commandCategory.Parameters.Add("@isborrowable", SqlDbType.Bit).Value = true;
                commandCategory.Parameters.Add("@type", SqlDbType.VarChar).Value = "Audio Book";
                commandCategory.Parameters.Add("@categoryid", SqlDbType.Int).Value = getCategoryID(mCategory);
                commandCategory.ExecuteNonQuery();
            }
            // adds dvd
            else if (mItem == 3)
            {

                SqlCommand commandCategory = new SqlCommand("INSERT INTO LibraryItem ([Title],[Author], [RunTimeMinutes], [Borrower], [IsBorrowable], [Type], [CategoryId]) VALUES (@title,@author, @runTime, " +
                    "@borrower, @isborrowable, @type, @categoryid )", connection);
                commandCategory.Parameters.Add("@title", SqlDbType.VarChar).Value = mTitle;
                commandCategory.Parameters.Add("@author", SqlDbType.VarChar).Value = "";
                commandCategory.Parameters.Add("@runTime", SqlDbType.VarChar).Value = mRunTime;
                commandCategory.Parameters.Add("@borrower", SqlDbType.VarChar).Value = "";
                commandCategory.Parameters.Add("@isborrowable", SqlDbType.Bit).Value = true;
                commandCategory.Parameters.Add("@type", SqlDbType.VarChar).Value = "DVD";
                commandCategory.Parameters.Add("@categoryid", SqlDbType.Int).Value = getCategoryID(mCategory);
                commandCategory.ExecuteNonQuery();
            }
            // adds reference book
            else if (mItem == 4)
            {

                SqlCommand commandCategory = new SqlCommand("INSERT INTO LibraryItem ([Title],[Author], [Pages] , [Borrower], [IsBorrowable], [Type], [CategoryId]) VALUES (@title,@author, @pages, " +
                    "@borrower, @isborrowable, @type, @categoryid )", connection);
                commandCategory.Parameters.Add("@title", SqlDbType.VarChar).Value = mTitle;
                commandCategory.Parameters.Add("@author", SqlDbType.VarChar).Value = mAuthor;
                commandCategory.Parameters.Add("@pages", SqlDbType.Int).Value = mPages;
                commandCategory.Parameters.Add("@borrower", SqlDbType.VarChar).Value = "";
                commandCategory.Parameters.Add("@isborrowable", SqlDbType.Bit).Value = false;
                commandCategory.Parameters.Add("@type", SqlDbType.VarChar).Value = "Reference Book";
                commandCategory.Parameters.Add("@categoryid", SqlDbType.Int).Value = getCategoryID(mCategory);
                commandCategory.ExecuteNonQuery();
            }

        }

        public void libraryType(int typeIndex)
        {
            if (typeIndex == 1) {
                mItem = typeIndex;
            }
            else if (typeIndex == 2)
            {
                mItem = typeIndex;
            }
            else if (typeIndex == 3)
            {
                mItem = typeIndex;
            }
            else if (typeIndex == 4)
            {
                mItem = typeIndex;
            }
        }

        public string getCategoryWithId(int id) {

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT CategoryName FROM Category WHERE Id = @id", connection);
            cmd.Parameters.AddWithValue("@id", id);
            string category = (string)cmd.ExecuteScalar();
            return category;
        }

        public void editLibrayItem() { }

        public void deleteLibraryItem(int id) {

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand sqlCommand = new SqlCommand("DELETE FROM LibraryItem WHERE ID = @id", connection);
            sqlCommand.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;
            sqlCommand.ExecuteNonQuery();
        }

        public void deleteCategory(int id) {

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM Category WHERE Id = @id", connection);
            sqlCommand.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;
            sqlCommand.ExecuteNonQuery();
        }

        public void borrow(string borrower, int id) {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("UPDATE LibraryItem SET Borrower = @borrower, IsBorrowable = @isborrowable, BorrowDate = @borrowdate WHERE ID = @id", connection);
            sqlCommand.Parameters.AddWithValue("@borrower", SqlDbType.VarChar).Value = borrower;
            sqlCommand.Parameters.AddWithValue("@isborrowable", SqlDbType.Bit).Value = false;
            sqlCommand.Parameters.AddWithValue("@borrowdate", SqlDbType.DateTime).Value = DateTime.Now;
            sqlCommand.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;
            sqlCommand.ExecuteNonQuery();

        }
        
        public void returnBorrowedItem(int id)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("UPDATE LibraryItem SET Borrower = @borrower, IsBorrowable = @isborrowable, BorrowDate = @borrowdate WHERE ID = @id", connection);
            sqlCommand.Parameters.AddWithValue("@borrower", SqlDbType.VarChar).Value = "";
            sqlCommand.Parameters.AddWithValue("@isborrowable", SqlDbType.Bit).Value = true;
            sqlCommand.Parameters.AddWithValue("@borrowdate", SqlDbType.DateTime).Value = DateTime.MinValue.ToString();
            sqlCommand.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;
            sqlCommand.ExecuteNonQuery();

        }

        public void editCategory(string edit, int id) {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            if (checkCategoryExist(edit))
            {

            }
            else {
                SqlCommand sqlCommand = new SqlCommand("UPDATE Category SET CategoryName = @categoryname WHERE ID = @id", connection);
                sqlCommand.Parameters.AddWithValue("@categoryName", SqlDbType.VarChar).Value = edit;
                sqlCommand.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;

                sqlCommand.ExecuteNonQuery();
            }
     
         
        }

        public void editLibraryItem(string author, string title, int pages, int runtime, int id, string type)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            if (type == "Book")
            {
                SqlCommand sqlCommand = new SqlCommand("UPDATE LibraryItem SET Title = @title, Author = @author, Pages = @pages WHERE ID = @id", connection);
                sqlCommand.Parameters.AddWithValue("@title", SqlDbType.VarChar).Value = title;
                sqlCommand.Parameters.AddWithValue("@author", SqlDbType.VarChar).Value = author;
                sqlCommand.Parameters.AddWithValue("@pages", SqlDbType.Int).Value = pages;
                sqlCommand.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;
                sqlCommand.ExecuteNonQuery();

            }
            else if (type == "DVD")
            {
                SqlCommand sqlCommand = new SqlCommand("UPDATE LibraryItem SET Title = @title, RunTimeMinutes = @runtime WHERE ID = @id", connection);
                sqlCommand.Parameters.AddWithValue("@title", SqlDbType.VarChar).Value = title;
                sqlCommand.Parameters.AddWithValue("@runtime", SqlDbType.Int).Value = runtime;
                sqlCommand.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;
                sqlCommand.ExecuteNonQuery();

            }
            else if (type == "Reference Book")
            {
                SqlCommand sqlCommand = new SqlCommand("UPDATE LibraryItem SET Title = @title, Author = @title, Pages = @pages WHERE ID = @id", connection);
                sqlCommand.Parameters.AddWithValue("@title", SqlDbType.VarChar).Value = title;
                sqlCommand.Parameters.AddWithValue("@author", SqlDbType.VarChar).Value = author;
                sqlCommand.Parameters.AddWithValue("@pages", SqlDbType.Int).Value = pages;
                sqlCommand.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;
                sqlCommand.ExecuteNonQuery();

            }
            else if (type == "Audio Book")
            {
                SqlCommand sqlCommand = new SqlCommand("UPDATE LibraryItem SET Title = @title, Author = @title, RunTimeMinutes = @runtime WHERE ID = @id", connection);
                sqlCommand.Parameters.AddWithValue("@title", SqlDbType.VarChar).Value = title;
                sqlCommand.Parameters.AddWithValue("@author", SqlDbType.VarChar).Value = author;
                sqlCommand.Parameters.AddWithValue("@runtime", SqlDbType.Int).Value = runtime;
                sqlCommand.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id;
                sqlCommand.ExecuteNonQuery();
            }



        }



    }

}

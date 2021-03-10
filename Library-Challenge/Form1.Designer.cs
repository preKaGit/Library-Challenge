
namespace ConsidLibrary
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBoxAuthor = new System.Windows.Forms.TextBox();
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.txtBoxRunTime = new System.Windows.Forms.TextBox();
            this.txtBoxPages = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.radioBtnBook = new System.Windows.Forms.RadioButton();
            this.radioBtnAudioBook = new System.Windows.Forms.RadioButton();
            this.radioBtnDVD = new System.Windows.Forms.RadioButton();
            this.radioBtnReferenceBook = new System.Windows.Forms.RadioButton();
            this.txtBoxCategory = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.radioBtnEdit = new System.Windows.Forms.RadioButton();
            this.radioBtnBorrow = new System.Windows.Forms.RadioButton();
            this.radioBtnReturn = new System.Windows.Forms.RadioButton();
            this.radioBtnDelete = new System.Windows.Forms.RadioButton();
            this.txtBoxBorrow = new System.Windows.Forms.TextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.radioBtnDeleteCategory = new System.Windows.Forms.RadioButton();
            this.radioBtnEditCategory = new System.Windows.Forms.RadioButton();
            this.txtBoxEditCategory = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLibraryItemEdit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxAuthor
            // 
            this.txtBoxAuthor.Location = new System.Drawing.Point(91, 203);
            this.txtBoxAuthor.Name = "txtBoxAuthor";
            this.txtBoxAuthor.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAuthor.TabIndex = 0;
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.Location = new System.Drawing.Point(91, 229);
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTitle.TabIndex = 1;
            this.txtBoxTitle.TextChanged += new System.EventHandler(this.txtBoxTitle_TextChanged);
            // 
            // txtBoxRunTime
            // 
            this.txtBoxRunTime.Location = new System.Drawing.Point(91, 255);
            this.txtBoxRunTime.Name = "txtBoxRunTime";
            this.txtBoxRunTime.Size = new System.Drawing.Size(100, 20);
            this.txtBoxRunTime.TabIndex = 2;
            // 
            // txtBoxPages
            // 
            this.txtBoxPages.Location = new System.Drawing.Point(91, 281);
            this.txtBoxPages.Name = "txtBoxPages";
            this.txtBoxPages.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPages.TabIndex = 3;
            this.txtBoxPages.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Author";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Run Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pages";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(119, 164);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 10;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // radioBtnBook
            // 
            this.radioBtnBook.AutoSize = true;
            this.radioBtnBook.Location = new System.Drawing.Point(10, 103);
            this.radioBtnBook.Name = "radioBtnBook";
            this.radioBtnBook.Size = new System.Drawing.Size(50, 17);
            this.radioBtnBook.TabIndex = 0;
            this.radioBtnBook.TabStop = true;
            this.radioBtnBook.Text = "Book";
            this.radioBtnBook.UseVisualStyleBackColor = true;
            this.radioBtnBook.CheckedChanged += new System.EventHandler(this.radioBtnBook_CheckedChanged);
            // 
            // radioBtnAudioBook
            // 
            this.radioBtnAudioBook.AutoSize = true;
            this.radioBtnAudioBook.Location = new System.Drawing.Point(10, 126);
            this.radioBtnAudioBook.Name = "radioBtnAudioBook";
            this.radioBtnAudioBook.Size = new System.Drawing.Size(80, 17);
            this.radioBtnAudioBook.TabIndex = 12;
            this.radioBtnAudioBook.TabStop = true;
            this.radioBtnAudioBook.Text = "Audio Book";
            this.radioBtnAudioBook.UseVisualStyleBackColor = true;
            this.radioBtnAudioBook.CheckedChanged += new System.EventHandler(this.radioBtnAudioBook_CheckedChanged);
            // 
            // radioBtnDVD
            // 
            this.radioBtnDVD.AutoSize = true;
            this.radioBtnDVD.Location = new System.Drawing.Point(10, 149);
            this.radioBtnDVD.Name = "radioBtnDVD";
            this.radioBtnDVD.Size = new System.Drawing.Size(48, 17);
            this.radioBtnDVD.TabIndex = 13;
            this.radioBtnDVD.TabStop = true;
            this.radioBtnDVD.Text = "DVD";
            this.radioBtnDVD.UseVisualStyleBackColor = true;
            this.radioBtnDVD.CheckedChanged += new System.EventHandler(this.radioBtnDVD_CheckedChanged);
            // 
            // radioBtnReferenceBook
            // 
            this.radioBtnReferenceBook.AutoSize = true;
            this.radioBtnReferenceBook.Location = new System.Drawing.Point(10, 170);
            this.radioBtnReferenceBook.Name = "radioBtnReferenceBook";
            this.radioBtnReferenceBook.Size = new System.Drawing.Size(103, 17);
            this.radioBtnReferenceBook.TabIndex = 14;
            this.radioBtnReferenceBook.TabStop = true;
            this.radioBtnReferenceBook.Text = "Reference Book";
            this.radioBtnReferenceBook.UseVisualStyleBackColor = true;
            this.radioBtnReferenceBook.CheckedChanged += new System.EventHandler(this.radioBtnReferenceBook_CheckedChanged);
            // 
            // txtBoxCategory
            // 
            this.txtBoxCategory.Location = new System.Drawing.Point(91, 351);
            this.txtBoxCategory.Name = "txtBoxCategory";
            this.txtBoxCategory.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCategory.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Category";
            // 
            // listView1
            // 
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(200, 272);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(723, 233);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Click title and button for action";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // radioBtnEdit
            // 
            this.radioBtnEdit.AutoSize = true;
            this.radioBtnEdit.Location = new System.Drawing.Point(295, 226);
            this.radioBtnEdit.Name = "radioBtnEdit";
            this.radioBtnEdit.Size = new System.Drawing.Size(43, 17);
            this.radioBtnEdit.TabIndex = 3;
            this.radioBtnEdit.TabStop = true;
            this.radioBtnEdit.Text = "Edit";
            this.radioBtnEdit.UseVisualStyleBackColor = true;
            this.radioBtnEdit.CheckedChanged += new System.EventHandler(this.radioBtnEdit_CheckedChanged);
            // 
            // radioBtnBorrow
            // 
            this.radioBtnBorrow.AutoSize = true;
            this.radioBtnBorrow.Location = new System.Drawing.Point(233, 253);
            this.radioBtnBorrow.Name = "radioBtnBorrow";
            this.radioBtnBorrow.Size = new System.Drawing.Size(58, 17);
            this.radioBtnBorrow.TabIndex = 2;
            this.radioBtnBorrow.TabStop = true;
            this.radioBtnBorrow.Text = "Borrow";
            this.radioBtnBorrow.UseVisualStyleBackColor = true;
            this.radioBtnBorrow.CheckedChanged += new System.EventHandler(this.radioBtnBorrow_CheckedChanged);
            // 
            // radioBtnReturn
            // 
            this.radioBtnReturn.AutoSize = true;
            this.radioBtnReturn.Location = new System.Drawing.Point(295, 253);
            this.radioBtnReturn.Name = "radioBtnReturn";
            this.radioBtnReturn.Size = new System.Drawing.Size(57, 17);
            this.radioBtnReturn.TabIndex = 1;
            this.radioBtnReturn.TabStop = true;
            this.radioBtnReturn.Text = "Return";
            this.radioBtnReturn.UseVisualStyleBackColor = true;
            this.radioBtnReturn.CheckedChanged += new System.EventHandler(this.radioBtnReturn_CheckedChanged);
            // 
            // radioBtnDelete
            // 
            this.radioBtnDelete.AutoSize = true;
            this.radioBtnDelete.Location = new System.Drawing.Point(233, 226);
            this.radioBtnDelete.Name = "radioBtnDelete";
            this.radioBtnDelete.Size = new System.Drawing.Size(56, 17);
            this.radioBtnDelete.TabIndex = 11;
            this.radioBtnDelete.TabStop = true;
            this.radioBtnDelete.Text = "Delete";
            this.radioBtnDelete.UseVisualStyleBackColor = true;
            this.radioBtnDelete.CheckedChanged += new System.EventHandler(this.radioBtnDelete_CheckedChanged);
            // 
            // txtBoxBorrow
            // 
            this.txtBoxBorrow.Location = new System.Drawing.Point(367, 246);
            this.txtBoxBorrow.Name = "txtBoxBorrow";
            this.txtBoxBorrow.Size = new System.Drawing.Size(100, 20);
            this.txtBoxBorrow.TabIndex = 24;
            // 
            // listView2
            // 
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(672, 169);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(251, 97);
            this.listView2.TabIndex = 25;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(669, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Categories";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(364, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Borrower:";
            // 
            // radioBtnDeleteCategory
            // 
            this.radioBtnDeleteCategory.AutoSize = true;
            this.radioBtnDeleteCategory.Location = new System.Drawing.Point(732, 151);
            this.radioBtnDeleteCategory.Name = "radioBtnDeleteCategory";
            this.radioBtnDeleteCategory.Size = new System.Drawing.Size(56, 17);
            this.radioBtnDeleteCategory.TabIndex = 28;
            this.radioBtnDeleteCategory.TabStop = true;
            this.radioBtnDeleteCategory.Text = "Delete";
            this.radioBtnDeleteCategory.UseVisualStyleBackColor = true;
            this.radioBtnDeleteCategory.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioBtnEditCategory
            // 
            this.radioBtnEditCategory.AutoSize = true;
            this.radioBtnEditCategory.Location = new System.Drawing.Point(794, 151);
            this.radioBtnEditCategory.Name = "radioBtnEditCategory";
            this.radioBtnEditCategory.Size = new System.Drawing.Size(43, 17);
            this.radioBtnEditCategory.TabIndex = 29;
            this.radioBtnEditCategory.TabStop = true;
            this.radioBtnEditCategory.Text = "Edit";
            this.radioBtnEditCategory.UseVisualStyleBackColor = true;
            this.radioBtnEditCategory.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // txtBoxEditCategory
            // 
            this.txtBoxEditCategory.Location = new System.Drawing.Point(698, 125);
            this.txtBoxEditCategory.Name = "txtBoxEditCategory";
            this.txtBoxEditCategory.Size = new System.Drawing.Size(100, 20);
            this.txtBoxEditCategory.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(664, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Edit:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(804, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 20);
            this.button1.TabIndex = 32;
            this.button1.Text = "submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLibraryItemEdit
            // 
            this.btnLibraryItemEdit.Location = new System.Drawing.Point(200, 164);
            this.btnLibraryItemEdit.Name = "btnLibraryItemEdit";
            this.btnLibraryItemEdit.Size = new System.Drawing.Size(75, 23);
            this.btnLibraryItemEdit.TabIndex = 33;
            this.btnLibraryItemEdit.Text = "edit";
            this.btnLibraryItemEdit.UseVisualStyleBackColor = true;
            this.btnLibraryItemEdit.Click += new System.EventHandler(this.btnLibraryItemEdit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(486, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "Sort Type";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(486, 214);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 23);
            this.button3.TabIndex = 35;
            this.button3.Text = "Sort Category";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 517);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnLibraryItemEdit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBoxEditCategory);
            this.Controls.Add(this.radioBtnEditCategory);
            this.Controls.Add(this.radioBtnDeleteCategory);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.txtBoxBorrow);
            this.Controls.Add(this.radioBtnEdit);
            this.Controls.Add(this.radioBtnBorrow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioBtnReturn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.radioBtnDelete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxCategory);
            this.Controls.Add(this.radioBtnReferenceBook);
            this.Controls.Add(this.radioBtnDVD);
            this.Controls.Add(this.radioBtnAudioBook);
            this.Controls.Add(this.radioBtnBook);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxPages);
            this.Controls.Add(this.txtBoxRunTime);
            this.Controls.Add(this.txtBoxTitle);
            this.Controls.Add(this.txtBoxAuthor);
            this.Name = "Form1";
            this.Text = "library";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxAuthor;
        private System.Windows.Forms.TextBox txtBoxTitle;
        private System.Windows.Forms.TextBox txtBoxRunTime;
        private System.Windows.Forms.TextBox txtBoxPages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.RadioButton radioBtnBook;
        private System.Windows.Forms.RadioButton radioBtnAudioBook;
        private System.Windows.Forms.RadioButton radioBtnDVD;
        private System.Windows.Forms.RadioButton radioBtnReferenceBook;
        private System.Windows.Forms.TextBox txtBoxCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioBtnEdit;
        private System.Windows.Forms.RadioButton radioBtnBorrow;
        private System.Windows.Forms.RadioButton radioBtnReturn;
        private System.Windows.Forms.RadioButton radioBtnDelete;
        private System.Windows.Forms.TextBox txtBoxBorrow;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioBtnDeleteCategory;
        private System.Windows.Forms.RadioButton radioBtnEditCategory;
        private System.Windows.Forms.TextBox txtBoxEditCategory;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLibraryItemEdit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}


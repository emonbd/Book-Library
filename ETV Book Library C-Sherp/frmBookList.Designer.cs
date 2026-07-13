namespace ETV_Book_Library_C_Sherp
{
    partial class frmBookList
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.cmbField = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvBookList = new System.Windows.Forms.ListView();
            this.colBookID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBookName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBookNameBangla = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAuth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBookNameBangla = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtQry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnReceive = new System.Windows.Forms.Button();
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(217, 205);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(193, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(427, 205);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(129, 26);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // cmbField
            // 
            this.cmbField.FormattingEnabled = true;
            this.cmbField.Location = new System.Drawing.Point(46, 204);
            this.cmbField.Name = "cmbField";
            this.cmbField.Size = new System.Drawing.Size(140, 21);
            this.cmbField.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(646, 262);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 25);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvBookList
            // 
            this.lvBookList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colBookID,
            this.colBookName,
            this.colBookNameBangla,
            this.colAuth,
            this.colCategory,
            this.colStatus});
            this.lvBookList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvBookList.FullRowSelect = true;
            this.lvBookList.GridLines = true;
            this.lvBookList.Location = new System.Drawing.Point(46, 262);
            this.lvBookList.Name = "lvBookList";
            this.lvBookList.Size = new System.Drawing.Size(594, 226);
            this.lvBookList.TabIndex = 4;
            this.lvBookList.UseCompatibleStateImageBehavior = false;
            this.lvBookList.View = System.Windows.Forms.View.Details;
            this.lvBookList.SelectedIndexChanged += new System.EventHandler(this.lvBookList_SelectedIndexChanged);
            this.lvBookList.DoubleClick += new System.EventHandler(this.lvBookList_DoubleClick);
            // 
            // colBookID
            // 
            this.colBookID.Text = "Book ID";
            // 
            // colBookName
            // 
            this.colBookName.Text = "Book Name";
            this.colBookName.Width = 108;
            // 
            // colBookNameBangla
            // 
            this.colBookNameBangla.Text = "Book (Bangla)";
            this.colBookNameBangla.Width = 118;
            // 
            // colAuth
            // 
            this.colAuth.Text = "Author Name";
            this.colAuth.Width = 109;
            // 
            // colCategory
            // 
            this.colCategory.Text = "Category";
            this.colCategory.Width = 109;
            // 
            // txtBookNameBangla
            // 
            this.txtBookNameBangla.Location = new System.Drawing.Point(65, 83);
            this.txtBookNameBangla.Name = "txtBookNameBangla";
            this.txtBookNameBangla.Size = new System.Drawing.Size(193, 20);
            this.txtBookNameBangla.TabIndex = 5;
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(646, 293);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(103, 27);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtQry);
            this.panel1.Location = new System.Drawing.Point(592, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 123);
            this.panel1.TabIndex = 7;
            // 
            // txtQry
            // 
            this.txtQry.Location = new System.Drawing.Point(17, 20);
            this.txtQry.Name = "txtQry";
            this.txtQry.Size = new System.Drawing.Size(125, 20);
            this.txtQry.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Field";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Search by";
            // 
            // btnIssue
            // 
            this.btnIssue.Location = new System.Drawing.Point(650, 356);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(99, 25);
            this.btnIssue.TabIndex = 32;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(650, 397);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(99, 25);
            this.btnReceive.TabIndex = 33;
            this.btnReceive.Text = "Receive";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            // 
            // frmBookList
            // 
            this.AcceptButton = this.btnFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 539);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtBookNameBangla);
            this.Controls.Add(this.lvBookList);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbField);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtSearch);
            this.Name = "frmBookList";
            this.Text = "Book List";
            this.Load += new System.EventHandler(this.frmBookList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lvBookList;
        private System.Windows.Forms.ColumnHeader colBookID;
        private System.Windows.Forms.ColumnHeader colBookName;
        private System.Windows.Forms.TextBox txtBookNameBangla;
        private System.Windows.Forms.ColumnHeader colBookNameBangla;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ColumnHeader colAuth;
        private System.Windows.Forms.ColumnHeader colCategory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbField;
        private System.Windows.Forms.TextBox txtQry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.ColumnHeader colStatus;
    }
}


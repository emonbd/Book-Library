namespace ETV_Book_Library_C_Sherp
{
    partial class frmCategory
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.lvCatList = new System.Windows.Forms.ListView();
            this.colCatID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCatName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCatNameBangla = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCatID = new System.Windows.Forms.TextBox();
            this.txtCatNameBangla = new System.Windows.Forms.TextBox();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtQry = new System.Windows.Forms.TextBox();
            this.btnCan = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRem = new System.Windows.Forms.TextBox();
            this.colRemarks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCount = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(324, 50);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(79, 27);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lvCatList
            // 
            this.lvCatList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCatID,
            this.colCatName,
            this.colCatNameBangla,
            this.colRemarks});
            this.lvCatList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCatList.FullRowSelect = true;
            this.lvCatList.GridLines = true;
            this.lvCatList.Location = new System.Drawing.Point(27, 83);
            this.lvCatList.Name = "lvCatList";
            this.lvCatList.Size = new System.Drawing.Size(376, 396);
            this.lvCatList.TabIndex = 8;
            this.lvCatList.UseCompatibleStateImageBehavior = false;
            this.lvCatList.View = System.Windows.Forms.View.Details;
            this.lvCatList.SelectedIndexChanged += new System.EventHandler(this.lvCatList_SelectedIndexChanged);
            // 
            // colCatID
            // 
            this.colCatID.Text = "Cat ID";
            // 
            // colCatName
            // 
            this.colCatName.Text = "Category";
            this.colCatName.Width = 108;
            // 
            // colCatNameBangla
            // 
            this.colCatNameBangla.Text = "Category (Bangla)";
            this.colCatNameBangla.Width = 118;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(421, 52);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 25);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCatID
            // 
            this.txtCatID.Location = new System.Drawing.Point(546, 135);
            this.txtCatID.Name = "txtCatID";
            this.txtCatID.Size = new System.Drawing.Size(147, 20);
            this.txtCatID.TabIndex = 15;
            // 
            // txtCatNameBangla
            // 
            this.txtCatNameBangla.Font = new System.Drawing.Font("Kalpurush", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCatNameBangla.Location = new System.Drawing.Point(546, 187);
            this.txtCatNameBangla.Name = "txtCatNameBangla";
            this.txtCatNameBangla.Size = new System.Drawing.Size(205, 26);
            this.txtCatNameBangla.TabIndex = 14;
            // 
            // txtCatName
            // 
            this.txtCatName.Location = new System.Drawing.Point(546, 161);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(205, 20);
            this.txtCatName.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Category Name (Bangla)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Category Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Category ID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtType);
            this.panel1.Controls.Add(this.txtQry);
            this.panel1.Location = new System.Drawing.Point(608, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 65);
            this.panel1.TabIndex = 19;
            // 
            // txtQry
            // 
            this.txtQry.Location = new System.Drawing.Point(15, 3);
            this.txtQry.Name = "txtQry";
            this.txtQry.Size = new System.Drawing.Size(125, 20);
            this.txtQry.TabIndex = 0;
            // 
            // btnCan
            // 
            this.btnCan.Location = new System.Drawing.Point(522, 262);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(99, 25);
            this.btnCan.TabIndex = 32;
            this.btnCan.Text = "Cancel";
            this.btnCan.UseVisualStyleBackColor = true;
            this.btnCan.Click += new System.EventHandler(this.btnCan_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(652, 262);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 25);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(15, 29);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(125, 20);
            this.txtType.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Remarks";
            // 
            // txtRem
            // 
            this.txtRem.Location = new System.Drawing.Point(546, 219);
            this.txtRem.Name = "txtRem";
            this.txtRem.Size = new System.Drawing.Size(205, 20);
            this.txtRem.TabIndex = 33;
            // 
            // colRemarks
            // 
            this.colRemarks.Text = "Remarks";
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(412, 459);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(110, 29);
            this.btnCount.TabIndex = 35;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 521);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRem);
            this.Controls.Add(this.btnCan);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCatID);
            this.Controls.Add(this.txtCatNameBangla);
            this.Controls.Add(this.txtCatName);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lvCatList);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmCategory";
            this.Text = "frmCategory";
            this.Load += new System.EventHandler(this.frmCategory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ListView lvCatList;
        private System.Windows.Forms.ColumnHeader colCatID;
        private System.Windows.Forms.ColumnHeader colCatName;
        private System.Windows.Forms.ColumnHeader colCatNameBangla;
        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.TextBox txtCatID;
        private System.Windows.Forms.TextBox txtCatNameBangla;
        private System.Windows.Forms.TextBox txtCatName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtQry;
        private System.Windows.Forms.Button btnCan;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRem;
        private System.Windows.Forms.ColumnHeader colRemarks;
        private System.Windows.Forms.Button btnCount;
    }
}
namespace ETV_Book_Library_C_Sherp
{
    partial class frmIssue
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmpDept = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEmpID = new System.Windows.Forms.ComboBox();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmpDesig = new System.Windows.Forms.TextBox();
            this.btnCan = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.dtpFuncDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtQry = new System.Windows.Forms.TextBox();
            this.lvIssueList = new System.Windows.Forms.ListView();
            this.colBookID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIssuedTo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIssueDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblFuncDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRem = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Department";
            // 
            // txtEmpDept
            // 
            this.txtEmpDept.Location = new System.Drawing.Point(146, 264);
            this.txtEmpDept.Name = "txtEmpDept";
            this.txtEmpDept.Size = new System.Drawing.Size(289, 20);
            this.txtEmpDept.TabIndex = 25;
            this.txtEmpDept.TextChanged += new System.EventHandler(this.txtEmpDept_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Employee ID";
            // 
            // cmbEmpID
            // 
            this.cmbEmpID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpID.FormattingEnabled = true;
            this.cmbEmpID.Location = new System.Drawing.Point(146, 211);
            this.cmbEmpID.Name = "cmbEmpID";
            this.cmbEmpID.Size = new System.Drawing.Size(289, 21);
            this.cmbEmpID.TabIndex = 23;
            this.cmbEmpID.SelectedIndexChanged += new System.EventHandler(this.cmbEmpID_SelectedIndexChanged);
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(146, 83);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(164, 20);
            this.txtBookID.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Book Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Book ID";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(146, 109);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(289, 20);
            this.txtBookName.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Employee Name";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(146, 238);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(289, 20);
            this.txtEmpName.TabIndex = 27;
            this.txtEmpName.TextChanged += new System.EventHandler(this.txtEmpName_TextChanged);
            this.txtEmpName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmpName_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Designation";
            // 
            // txtEmpDesig
            // 
            this.txtEmpDesig.Location = new System.Drawing.Point(146, 290);
            this.txtEmpDesig.Name = "txtEmpDesig";
            this.txtEmpDesig.Size = new System.Drawing.Size(289, 20);
            this.txtEmpDesig.TabIndex = 29;
            // 
            // btnCan
            // 
            this.btnCan.Location = new System.Drawing.Point(146, 346);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(99, 25);
            this.btnCan.TabIndex = 32;
            this.btnCan.Text = "Cancel";
            this.btnCan.UseVisualStyleBackColor = true;
            // 
            // btnIssue
            // 
            this.btnIssue.Location = new System.Drawing.Point(336, 346);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(99, 25);
            this.btnIssue.TabIndex = 31;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // dtpFuncDate
            // 
            this.dtpFuncDate.CustomFormat = "MM/dd/yyyy";
            this.dtpFuncDate.Location = new System.Drawing.Point(146, 174);
            this.dtpFuncDate.Name = "dtpFuncDate";
            this.dtpFuncDate.Size = new System.Drawing.Size(289, 20);
            this.dtpFuncDate.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtType);
            this.panel1.Controls.Add(this.txtQry);
            this.panel1.Location = new System.Drawing.Point(308, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 91);
            this.panel1.TabIndex = 35;
            // 
            // txtQry
            // 
            this.txtQry.Location = new System.Drawing.Point(3, 3);
            this.txtQry.Name = "txtQry";
            this.txtQry.Size = new System.Drawing.Size(125, 20);
            this.txtQry.TabIndex = 0;
            // 
            // lvIssueList
            // 
            this.lvIssueList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colBookID,
            this.colIssuedTo,
            this.colIssueDate});
            this.lvIssueList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvIssueList.FullRowSelect = true;
            this.lvIssueList.GridLines = true;
            this.lvIssueList.Location = new System.Drawing.Point(441, 54);
            this.lvIssueList.Name = "lvIssueList";
            this.lvIssueList.Size = new System.Drawing.Size(369, 226);
            this.lvIssueList.TabIndex = 36;
            this.lvIssueList.UseCompatibleStateImageBehavior = false;
            this.lvIssueList.View = System.Windows.Forms.View.Details;
            // 
            // colBookID
            // 
            this.colBookID.Text = "Book ID";
            this.colBookID.Width = 0;
            // 
            // colIssuedTo
            // 
            this.colIssuedTo.Text = "Issued To";
            this.colIssuedTo.Width = 250;
            // 
            // colIssueDate
            // 
            this.colIssueDate.Text = "Issue Date";
            this.colIssueDate.Width = 109;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(2, 29);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(125, 20);
            this.txtType.TabIndex = 1;
            this.txtType.TextChanged += new System.EventHandler(this.txtType_TextChanged);
            // 
            // lblFuncDate
            // 
            this.lblFuncDate.AutoSize = true;
            this.lblFuncDate.Location = new System.Drawing.Point(33, 181);
            this.lblFuncDate.Name = "lblFuncDate";
            this.lblFuncDate.Size = new System.Drawing.Size(30, 13);
            this.lblFuncDate.TabIndex = 39;
            this.lblFuncDate.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Book Status";
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.SystemColors.Control;
            this.txtStatus.Location = new System.Drawing.Point(146, 135);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(289, 20);
            this.txtStatus.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Remarks";
            // 
            // txtRem
            // 
            this.txtRem.Location = new System.Drawing.Point(146, 320);
            this.txtRem.Name = "txtRem";
            this.txtRem.Size = new System.Drawing.Size(289, 20);
            this.txtRem.TabIndex = 42;
            // 
            // frmIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 419);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtRem);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblFuncDate);
            this.Controls.Add(this.lvIssueList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpFuncDate);
            this.Controls.Add(this.btnCan);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmpDesig);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmpDept);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbEmpID);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBookName);
            this.Name = "frmIssue";
            this.Text = "Issue";
            this.Load += new System.EventHandler(this.frmIssue_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmpDept;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEmpID;
        public System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmpDesig;
        private System.Windows.Forms.Button btnCan;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.DateTimePicker dtpFuncDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtQry;
        private System.Windows.Forms.ListView lvIssueList;
        private System.Windows.Forms.ColumnHeader colBookID;
        private System.Windows.Forms.ColumnHeader colIssuedTo;
        private System.Windows.Forms.ColumnHeader colIssueDate;
        private System.Windows.Forms.Label lblFuncDate;
        public System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRem;
    }
}
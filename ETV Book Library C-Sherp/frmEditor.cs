using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETV_Book_Library_C_Sherp
{
    public partial class frmEditor : Form
    {
        private clsDBConn con;
        public frmEditor()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbCategory.Text.ToString() == "")
            {
                MessageBox.Show("Select a ctegory first.", "Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCategory.Focus();
                return;
            }

            if ((txtBookName.Text.ToString() == "") && (txtBookNameBangla.Text.ToString() == ""))
            {
                MessageBox.Show("Input book name.", "Book Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookName.Focus();
                return;
            }

            if ((txtAuthName.Text.ToString() == "") && (txtAuthNameBangla.Text.ToString() == ""))
            {
                MessageBox.Show("Input author name.", "Author Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthName.Focus();
                return;
            }

            btnSave.Enabled = false;

            string vCatID = "";
            string vCatName = "";

            char[] delimiterChars = { '[', ']' };
            string text = cmbCategory.Text.Trim();
            string[] words = text.Split(delimiterChars);


            foreach (var word in words)
            {
                vCatName = word;
            }



            vCatID = text.Split('[', ']')[1];
            //MessageBox.Show(vCatID);


            
            if (txtType.Text == "new")
            {

                con = new clsDBConn();
                con.SqlQuery("insert into tblBookList (BookID, BookName, BookNameBangla, BookAuthor, BookAuthorBangla, Publisher, PublishDate, BookCategory, BookCategoryID, BookLocation, ReceivedDate, Remarks, InputDate, InputBy) values (@BookID, @BookName, @BookNameBangla, @AuthName, @AuthNameBangla, @Publisher, @PublishDate, @BookCategory, @BookCategoryID, @BookLocation, @ReceivedDate, @Remarks, @InputDate, @InputBy)");
            }else if (txtType.Text == "edit")
            {
                con = new clsDBConn();
                con.SqlQuery("update tblBookList set BookName =@BookName, BookNameBangla=@BookNameBangla, BookAuthor=@AuthName, BookAuthorBangla=@AuthNameBangla, Publisher=@Publisher, PublishDate=@PublishDate, BookCategory=@BookCategory, BookCategoryID=@BookCategoryID, BookLocation=@BookLocation, ReceivedDate=@ReceivedDate, Remarks=@Remarks, InputDate=@InputDate, InputBy=@InputBy where BookID = @BookID");
            }


            con.Cmd.Parameters.AddWithValue("@BookID", txtBookID.Text.Trim());
            con.Cmd.Parameters.AddWithValue("@BookName", txtBookName.Text.Trim());
            con.Cmd.Parameters.AddWithValue("@BookNameBangla", txtBookNameBangla.Text.Trim());
            con.Cmd.Parameters.AddWithValue("@AuthName", txtAuthName.Text.Trim());
            con.Cmd.Parameters.AddWithValue("@AuthNameBangla", txtAuthNameBangla.Text.Trim());

            con.Cmd.Parameters.AddWithValue("@Publisher", txtPublisher.Text.Trim());
            con.Cmd.Parameters.AddWithValue("@PublishDate", dtpPublishDate.Value);
            con.Cmd.Parameters.AddWithValue("@BookCategory", vCatName);
            con.Cmd.Parameters.AddWithValue("@BookCategoryID", vCatID);
            con.Cmd.Parameters.AddWithValue("@BookLocation", txtLocation.Text.Trim());
            con.Cmd.Parameters.AddWithValue("@ReceivedDate", dtpReceivedDate.Value);
            con.Cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text.Trim());
            con.Cmd.Parameters.AddWithValue("@InputDate", DateTime.Now.ToString("MM/dd/yyyy"));
            mdiMain frmMdi = new mdiMain();
            con.Cmd.Parameters.AddWithValue("@InputBy", frmMdi.txtUser.Text.Trim());
            
            con.NonQueryEx();
            
            btnSave.Enabled = true;
            if (txtType.Text == "edit")
            {
                

                //frmBookList fBList = new frmBookList();
                this.Dispose();
                //var principalForm = Application.OpenForms.OfType<frmBookList>().Single();
                //principalForm.LoadBookList();
                //fBList.Show();
                //fBList.LoadBookList();

            }
            txtType.Text = "edit";

        }

        private void btnLoadCat_Click(object sender, EventArgs e)
        {
            
            LoadCategory();
            NewBookID();


        }

        private  void LoadCategory()
        {
            con = new clsDBConn();
            con.SqlQuery("select * from tblCategory order by CategoryName");
            //con.QueryEx().Rows.Count.ToString();
            //MessageBox.Show(con.QueryEx().Rows.Count.ToString(), "Count");
            cmbCategory.Items.Clear();
            foreach (DataRow dr in con.QueryEx().Rows)
            {
                cmbCategory.Items.Add("[" + dr["CID"].ToString() + "]" + dr["CategoryName"].ToString());


            }

            if (cmbCategory.Items.Count > 0)
            {
                cmbCategory.SelectedIndex = 0;
            }

        }

        private void NewBookID()
        {
            con = new clsDBConn();
            con.SqlQuery("select max(BookID) as CBID from tblBookList");
            con.QueryEx();


            var row = con.QueryEx().Rows[0];

            var vOldBookID = row["CBID"].ToString();
            var vNewBookID = (Convert.ToUInt32(vOldBookID) + 1);

            txtBookID.Text = vNewBookID.ToString("000000");
        }

        public void LoadBookInfo()
        {
            con = new clsDBConn();
            con.SqlQuery("select * from tblBookList where BookID = @BookID");
            con.Cmd.Parameters.AddWithValue("@BookID", txtBookID.Text.Trim());
            con.QueryEx();


            var row = con.QueryEx().Rows[0];

            try
            {

                cmbCategory.Text = row["BookCategory"].ToString();
                txtBookName.Text = row["BookName"].ToString();
                txtBookNameBangla.Text = row["BookNameBangla"].ToString();
                txtAuthName.Text = row["BookAuthor"].ToString();
                txtAuthNameBangla.Text = row["BookAuthorBangla"].ToString();
                txtPublisher.Text = row["Publisher"].ToString();
                dtpPublishDate.Value = Convert.ToDateTime(row["PublishDate"].ToString());
                txtLocation.Text = row["BookLocation"].ToString();
                dtpReceivedDate.Value = Convert.ToDateTime(row["ReceivedDate"].ToString());
                txtRemarks.Text = row["Remarks"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data Load Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmEditor_Load(object sender, EventArgs e)
        {
            LoadCategory();


        }

        private void txtBookID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtType_TextChanged(object sender, EventArgs e)
        {
            lblTitle.Text = "Edit Book Info";
            if (txtType.Text == "new")
            {
                NewBookID();
                lblTitle.Text = "Add New Book";
                dtpPublishDate.Value = DateTime.Now;
                dtpReceivedDate.Value = DateTime.Now;
            }
        }

        private void btnCan_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vCatID = "";

            char[] delimiterChars = { ']', '[' };
            string text = cmbCategory.Text.Trim();
            string[] words = text.Split(delimiterChars);
            foreach (var word in words)
            {
                vCatID = word;
            }
            MessageBox.Show(vCatID);

            string output = text.Split('[', ']')[1];
            MessageBox.Show(output);
        }
    }
}

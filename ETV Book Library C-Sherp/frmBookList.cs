using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ETV_Book_Library_C_Sherp
{
    public partial class frmBookList : Form
    {
        private clsDBConn con;



        public frmBookList()
        {
            InitializeComponent();
        }

        private void frmBookList_Load(object sender, EventArgs e)
        {
            
            LoadFieldList();
            //con = new clsDBConn();
            //con.SqlQuery("select * from tblBookList");
        }

        private void LoadFieldList()
        {
            
            cmbField.Items.Clear();
            cmbField.Items.Add("BookName");
            cmbField.Items.Add("BookNameBangla");
            cmbField.Items.Add("BookAuthor");
            cmbField.Items.Add("BookAuthorBangla");
            cmbField.Items.Add("BookCategory");
            cmbField.SelectedIndex = 0;

        }

        public void LoadBookList()
        {

            con = new clsDBConn();
            con.SqlQuery(txtQry.Text);
            //MessageBox.Show(txtQry.Text);
            //con.QueryEx();



            lvBookList.Items.Clear();



            foreach (DataRow dr in con.QueryEx().Rows)
            {


                ListViewItem lvi = new ListViewItem();
                lvi.UseItemStyleForSubItems = false;

                lvi.Text = dr[0].ToString();
                lvi.SubItems.Add(dr["BookName"].ToString() );
                lvi.SubItems.Add(dr["BookNameBangla"].ToString());
                lvi.SubItems.Add(dr["BookAuthor"].ToString());
                lvi.SubItems.Add(dr["BookCategory"].ToString());
                lvi.SubItems.Add(dr["BookStatus"].ToString());

                lvBookList.Items.Add(lvi);
                lvi.SubItems[2].Font = new Font("Kalpurush", 10, System.Drawing.FontStyle.Regular);
            }

            if (con.QueryEx().Rows.Count > 0)
            {
                btnEdit.Enabled = true;
                lvBookList.Items[0].Selected = true;
            }
            else
            {
                btnEdit.Enabled = false;
            }

        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            txtQry.Text = "select * from tblBookList where " + cmbField.Text + " like '%" + txtSearch.Text + "%'";
            LoadBookList();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //con = new clsDBConn();
            //con.SqlQuery("insert into tblBookList (BookID, BookName, BookNameBangla) values ('0003', @BookName, @BookNameBangla)");
            //con.Cmd.Parameters.AddWithValue ("@BookName", txtBooKName.Text.Trim());
            //con.Cmd.Parameters.AddWithValue("@BookNameBangla", txtBookNameBangla.Text.Trim());
            //con.NonQueryEx();
            frmEditor fEdit = new frmEditor();
            fEdit.txtType.Text = "new";
            fEdit.ShowDialog();



        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmEditor fEdit = new frmEditor();

            if (lvBookList.Items.Count > 0 )
                    {
                fEdit.txtBookID.Text = lvBookList.SelectedItems[0].SubItems[0].Text.ToString();
                fEdit.txtType.Text = "edit";
                fEdit.LoadBookInfo();
                fEdit.ShowDialog();
                //MessageBox.Show(lvBookList.SelectedItems[0].ToString());
            }



        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtSearch_GotFocus(object sender, EventArgs e)
        {
            this.ActiveControl = btnFind;
            MessageBox.Show("Emon");
        }

        private void lvBookList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
         private void lvBookList_DoubleClick(object sender, System.EventArgs e)
        {
            btnEdit_Click(sender, e);
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            frmIssue newMDIChild = new frmIssue();
            // Set the Parent Form of the Child window.
            //newMDIChild.MdiParent = this;
            newMDIChild.txtType.Text = "issue";
            newMDIChild.txtBookID.Text = lvBookList.SelectedItems[0].SubItems[0].Text.ToString();
            newMDIChild.LoadBookInfo();
            // Display the new form.
            newMDIChild.Show();
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            frmIssue newMDIChild = new frmIssue();
            // Set the Parent Form of the Child window.
            //newMDIChild.MdiParent = this;
            newMDIChild.txtType.Text = "receive";
            newMDIChild.txtBookID.Text = lvBookList.SelectedItems[0].SubItems[0].Text.ToString();
            newMDIChild.LoadBookInfo();
            // Display the new form.
            newMDIChild.Show();
        }
    }
}

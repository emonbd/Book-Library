using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETV_Book_Library_C_Sherp
{
    public partial class frmCategory : Form
    {
        private clsDBConn con;
        
        public frmCategory()
        {
            InitializeComponent();
        }

        public void LoadCatList()
        {

            con = new clsDBConn();
            con.SqlQuery(txtQry.Text);
            //MessageBox.Show(txtQry.Text);
            //con.QueryEx();



            lvCatList.Items.Clear();



            foreach (DataRow dr in con.QueryEx().Rows)
            {


                ListViewItem lvi = new ListViewItem();
                lvi.UseItemStyleForSubItems = false;

                lvi.Text = dr[0].ToString();
                lvi.SubItems.Add(dr["CategoryName"].ToString());
                lvi.SubItems.Add(dr["CategoryNameBangla"].ToString());
                lvi.SubItems.Add(dr["Remarks"].ToString());


                lvCatList.Items.Add(lvi);
                lvi.SubItems[2].Font = new Font("Kalpurush", 10, System.Drawing.FontStyle.Regular);
            }

            if (con.QueryEx().Rows.Count > 0)
            {
                btnEdit.Enabled = true;
                lvCatList.Items[0].Selected = true;
            }
            else
            {
                btnEdit.Enabled = false;
            }

        }
        public void LockList()
        {
            lvCatList.Enabled = false;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            btnCan.Enabled = true;

        }

        public void UnLockList()
        {
            lvCatList.Enabled = true;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            btnCan.Enabled = false;
        }
        private void frmCategory_Load(object sender, EventArgs e)
        {

            txtQry.Text = "select * from tblCategory order by CategoryName";
            LoadCatList();
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            txtCatID.Text = "";
            txtCatName.Text = "";
            txtCatNameBangla.Text = "";
            UnLockList();


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtType.Text = "edit";
            LockList();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //con = new clsDBConn();
            //con.SqlQuery("select Max(CID) as MaxCat from tblCategory");


            
            string constring = Globals.clsConnString() ;
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("select Max(CID) as MaxCat from tblCategory", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            //MessageBox.Show(dt.Rows[0]["MaxCat"].ToString() );
                            int vMaxID = int.Parse(dt.Rows[0]["MaxCat"].ToString()) + 1;
                            txtCatID.Text = vMaxID.ToString()  ;
                            txtCatName.Text = "";
                            txtCatNameBangla.Text = "";
                        }
                    }
                }
            }




                

             






            txtType.Text = "new";
            LockList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCatName.Text.ToString() == "")
            {
                MessageBox.Show("Type a ctegory name first.", "Category Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCatName.Focus();
                return;
            }



            if (txtType.Text == "new")
            {

                con = new clsDBConn();
                con.SqlQuery("insert into tblCategory (CID, CategoryName, CategoryNameBangla, Remarks) values (@CatID, @CatName, @CatNameBangla, @Remarks)");
            }
            else if (txtType.Text == "edit")
            {
                con = new clsDBConn();
                con.SqlQuery("update tblCategory set CategoryName =@CatName, CategoryNameBangla=@CatNameBangla, Remarks=@Remarks where CID = @CatID");
            }


            con.Cmd.Parameters.AddWithValue("@CatID", txtCatID.Text.Trim());
            con.Cmd.Parameters.AddWithValue("@CatName", txtCatName.Text.Trim());
            con.Cmd.Parameters.AddWithValue("@CatNameBangla", txtCatNameBangla.Text.Trim());
            con.Cmd.Parameters.AddWithValue("@Remarks", txtRem.Text.Trim());
            
            //mdiMain frmMdi = new mdiMain();
            //con.Cmd.Parameters.AddWithValue("@InputBy", frmMdi.txtUser.Text.Trim());

            con.NonQueryEx();

            LoadCatList();
            UnLockList();

        }

        private void lvCatList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCatList.Items.IndexOf(lvCatList.FocusedItem) > -1)
            {

                //MessageBox.Show(lvCatList.Items.IndexOf(lvCatList.FocusedItem).ToString());
                txtCatID.Text = lvCatList.FocusedItem.Text.ToString();
                //txtCatID.Text = lvCatList.SelectedItems[0].SubItems[1].Text.ToString();
                txtCatName.Text = lvCatList.FocusedItem.SubItems[1].Text.ToString();
                txtCatNameBangla.Text = lvCatList.FocusedItem.SubItems[2].Text.ToString();
                txtRem.Text = lvCatList.FocusedItem.SubItems[3].Text.ToString();

                //MessageBox.Show(lvBookList.SelectedItems[0].ToString());
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lvCatList.Items.Count.ToString());
        }
    }
}

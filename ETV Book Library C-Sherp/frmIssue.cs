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
    public partial class frmIssue : Form
    {
        private clsDBConn con;
        public frmIssue()
        {
            InitializeComponent();
        }

        public void LoadEmpList()
        {

           

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

                
                txtBookName.Text = row["BookName"].ToString();
                txtStatus.Text = row["BookStatus"].ToString();

                if (txtStatus.Text == "Issued")
                {
                    txtType.Text = "receive";

                }
                else
                {
                    txtType.Text = "issue";
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data Load Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            LoadIssueInfo();
        }

        public void LoadIssueInfo()
        {
            //con = new clsDBConn();
            //con.SqlQuery("select * from tblIssue where BookID = @BookID");
            //con.Cmd.Parameters.AddWithValue("@BookID", txtBookID.Text.Trim());
            //con.QueryEx();


            //var row = con.QueryEx().Rows[0];
            lvIssueList.Items.Clear();
            con = new clsDBConn();
            con.SqlQuery("select * from tblIssue where BookID = @BookID");
            con.Cmd.Parameters.AddWithValue("@BookID", txtBookID.Text.Trim());



            foreach (DataRow dr in con.QueryEx().Rows)
            {


                ListViewItem lvi = new ListViewItem();
                lvi.UseItemStyleForSubItems = false;

                lvi.Text = dr[0].ToString();
                lvi.SubItems.Add(dr["EmpID"].ToString() + "-" + dr["EmpName"].ToString());
                lvi.SubItems.Add(dr["IssueDate"].ToString());



                lvIssueList.Items.Add(lvi);
                //lvi.SubItems[2].Font = new Font("Kalpurush", 10, System.Drawing.FontStyle.Regular);
            }


            
        }
        private void frmIssue_Load(object sender, EventArgs e)
        {

        }

        private void txtEmpName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmpName_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                //enter key is down

                string constring = Globals.clsConnStringHR();
                using (SqlConnection con = new SqlConnection(constring))
                {
                    using (SqlCommand cmd = new SqlCommand("select * from EmpInfo where EmpName Like '%"+ txtEmpName.Text  +  "%'", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataTable  dt = new DataTable())
                            {
                                sda.Fill(dt);
                                cmbEmpID.Items.Clear();

                                if (dt.Rows.Count > 0)
                                {
                                    for (int i = 0; i < dt.Rows.Count; i++)
                                    {
                                        //MessageBox.Show(dt.Rows[0]["MaxCat"].ToString() );
                                        //int vMaxID = int.Parse(dt.Rows[0]["MaxCat"].ToString()) + 1;
                                        cmbEmpID.Items.Add(dt.Rows[i]["EmpID"].ToString());

                                    }

                                    //cmbCategory.SelectedIndex = 0;
                                    cmbEmpID.Focus() ;
                                }

                            }
                        }
                    }
                }






            }
        }

        private void cmbEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constring = Globals.clsConnStringHR();
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("select * from EmpInfo where EmpID = '" + cmbEmpID.Text + "'", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            txtEmpName.Text = "";
                            txtEmpDept.Text = "";
                            txtEmpDesig.Text = "";

                            //MessageBox.Show(dt.Rows[0]["MaxCat"].ToString() );
                            //int vMaxID = int.Parse(dt.Rows[0]["MaxCat"].ToString()) + 1;
                            txtEmpName.Text = dt.Rows[0]["EmpName"].ToString();
                            txtEmpDept.Text = dt.Rows[0]["DeptName"].ToString();
                            txtEmpDesig.Text = dt.Rows[0]["Designation"].ToString();
                            //cmbEmpID.Items.Add(dt.Rows[i]["EmpID"].ToString());

                        }
                    }
                }
            }

        }

        private void txtEmpDept_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIssue_Click(object sender, EventArgs e)
        {

            con = new clsDBConn();
            con.SqlQuery("select max(IID) as CBID from tblIssue");
            con.QueryEx();
            var vNewIssueID =1 ;
            var row = con.QueryEx().Rows[0];
            if ((row["CBID"]) == "0")
            {
                

                var vOldIssueID = Convert.ToUInt32(row["CBID"])+1;
                //vNewIssueID = 1;
                //vNewIssueID = (Convert.ToUInt32(vOldIssueID) + 1);
            }else
            {
                 vNewIssueID = 1;
            }

            MessageBox.Show(vNewIssueID.ToString());


            con = new clsDBConn();
            con.SqlQuery("insert into tblIssue (IID, BookID, BookName, EmpID, EmpName, DeptName, Designation, Remarks, IssueDate, IssuedBy, InputBy, InputDate) values (@IID, @BookID, @BookName, @EmpID, @EmpName, @DeptName, @Designation, @Remarks, @IssueDate, @IssuedBy, @InputBy, @InputDate)");



            con.Cmd.Parameters.AddWithValue("@IID", vNewIssueID);
            con.Cmd.Parameters.AddWithValue("@BookID", txtBookID.Text.Trim());
            con.Cmd.Parameters.AddWithValue("@BookName", txtBookName.Text.Trim());
            con.Cmd.Parameters.AddWithValue("@EmpID", cmbEmpID.Text.Trim());
            con.Cmd.Parameters.AddWithValue("@EmpName", txtEmpName.Text.Trim());
            con.Cmd.Parameters.AddWithValue("@DeptName", txtEmpDept.Text.Trim());

            con.Cmd.Parameters.AddWithValue("@Designation", txtEmpDesig.Text.Trim());
            con.Cmd.Parameters.AddWithValue("@Remarks", txtRem.Text.Trim());

            con.Cmd.Parameters.AddWithValue("@IssueDate", dtpFuncDate.Value);
            
            con.Cmd.Parameters.AddWithValue("@InputDate", DateTime.Now.ToString("MM/dd/yyyy"));
            mdiMain frmMdi = new mdiMain();
            con.Cmd.Parameters.AddWithValue("@InputBy", frmMdi.txtUser.Text.Trim());
            con.Cmd.Parameters.AddWithValue("@IssuedBy", frmMdi.txtUser.Text.Trim());

            con.NonQueryEx();

            con = new clsDBConn();
            con.SqlQuery("update tblBookList set BookStatus ='Issued' where BookID = " + txtBookID.Text.Trim());
            con.NonQueryEx();


            MessageBox.Show ("Book ID: " + txtBookID.Text.Trim() + " issued successfully to EmpID: " + cmbEmpID.Text.Trim() + ".");

        }

        private void chkReceive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtType_TextChanged(object sender, EventArgs e)
        {
            if (txtType.Text == "issue") {
                lblFuncDate.Text = "Issue Date";
                btnIssue.Text = "Issue";
            }else
            {
                lblFuncDate.Text = "Receive Date";
                btnIssue.Text = "Receive";
            }
        }
    }
}

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
    public partial class mdiMain : Form
    {
        public mdiMain()
        {
            InitializeComponent();
        }

        private void mdiMain_Load(object sender, EventArgs e)
        {
            frmSplash newSplash = new frmSplash();
            // Set the Parent Form of the Child window.

            // Display the new form.
            newSplash.TopMost = true;
            newSplash.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewBookListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBookList newMDIChild = new frmBookList();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditor fEdit = new frmEditor();
            fEdit.txtType.Text = "new";
            fEdit.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();


        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategory newMDIChild = new frmCategory();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }
    }
}

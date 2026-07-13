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
    public partial class frmSplash : Form
    {
        public static frmSplash frmSplashInstance;
        public frmSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            //mdiMain fMdi = new mdiMain();
            //fMdi.Show();
            this.Close();
            timer1.Enabled = false;
            
            

            
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}

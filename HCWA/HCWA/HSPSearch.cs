using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP02
{
    public partial class HSPSearch : Form
    {
        private int enrolleeID;
        public HSPSearch(int id)
        {
            InitializeComponent();
            enrolleeID = id;
        }

        private void HSPSearch_Load(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnrolleeHomePage newform = new EnrolleeHomePage(enrolleeID);
            newform.ShowDialog();
        }

        private void HSPFound_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bool found = false;
            string HSPName = hspNameTxtBox.Text;
            found = DBMng.findHSP(HSPName);
            if (found) { HSPFound.Text = "HSP found: Y"; }
            else { HSPFound.Text = "HSP found: N"; }
        }

        private void HspNameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}

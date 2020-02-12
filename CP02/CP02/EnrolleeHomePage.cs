using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Implement a menu which lets the user perform all use cases pertaining to enrollees here

namespace CP02
{
    public partial class EnrolleeHomePage : Form
    {
        private int enrolleeID;
        public EnrolleeHomePage(int id)
        {
            InitializeComponent();
            enrolleeID = id;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HSPSearch newform = new HSPSearch(enrolleeID);
            newform.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignInOrRegister newform = new SignInOrRegister();
            newform.ShowDialog();

        }

        private void Button3_Click(object sender, EventArgs e)
        {

            
            this.Hide();
            // needs to be changed for final product
            AddRemoveGUI newform = new AddRemoveGUI(Enrollee.primaries.ElementAt(Enrollee.primaries.Count - 1));
            newform.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            // needs to be changed for final product
            EnrolleeInfo newform = new EnrolleeInfo(enrolleeID, 0);
            newform.ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePlan newform = new ChangePlan(enrolleeID);
            newform.ShowDialog();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            SeeBillsGUI newform = new SeeBillsGUI(enrolleeID);
            newform.ShowDialog();

        }
    }
}

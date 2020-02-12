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
    public partial class ChangePlan : Form
    {
        int userId;
        public ChangePlan(int id)
        {
            InitializeComponent();
            userId = id;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ChangePlan_Load(object sender, EventArgs e)
        {

        }

        private void CurrentPlan_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DBMng.changePlan(userId);

            this.Hide();
            EnrolleeHomePage newform = new EnrolleeHomePage(userId);
            newform.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnrolleeHomePage newform = new EnrolleeHomePage(userId);
            newform.ShowDialog();
        }
    }
}

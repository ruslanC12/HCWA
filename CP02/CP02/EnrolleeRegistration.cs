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
    public partial class EnrolleeRegistration : Form
    {
        private string plantype;
        public EnrolleeRegistration()
        {
            InitializeComponent();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                textBox4.Enabled = false;
                textBox4.BackColor = System.Drawing.SystemColors.ControlDark;
                textBox4.Text = textBox3.Text;
            }
            if(checkBox1.Checked == false)
            {
                textBox4.Enabled = true;
                textBox4.BackColor = System.Drawing.SystemColors.Control;
                textBox4.Text = "";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (checkBox3.Checked) { Enrollee.plan = true; }
            else { Enrollee.plan = false; }
            String fullname = textBox1.Text;
            String ssn = textBox2.Text;
            String bAddress = textBox3.Text;
            String mAddress = textBox4.Text;
            String username = textBox5.Text;
            String password = textBox6.Text;
            string pin = PINTextBox.Text;

            DBMng.insertIntoPrimaryEnrollee(plantype, fullname, username, password, mAddress, bAddress, ssn, pin);

            int id;
            id = DBMng.validateEnrollee(username, password);
            if (DBMng.getPlanTypeEnrollee(id) == "basic")
            {
                DBMng.updateDeductible(id, 250);
            }

            this.Hide();
            EnrolleeHomePage newEnrolleeInfo = new EnrolleeHomePage(id);
            newEnrolleeInfo.ShowDialog();

        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked == true)
            {
                plantype = "basic";
                checkBox3.Checked = false;
            }
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                plantype = "extended";
                checkBox2.Checked = false;
            }
        }
    }
}

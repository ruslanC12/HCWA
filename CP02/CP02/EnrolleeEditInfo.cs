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
    public partial class EnrolleeEditInfo : Form
    {
        private int enrolleeID = 0;
        private int accessedBy;
        public EnrolleeEditInfo(int id, int accessed)
        {
            InitializeComponent();
            enrolleeID = id;
            accessedBy = accessed;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string billingA = textBox3.Text;
            string mailingA = textBox4.Text;
            string name = textBox5.Text + " " + textBox6.Text;
            string phoneNum = textBox7.Text;
            string email = textBox8.Text;
            string pin = textBox9.Text;

            DBMng.editPrimaryEnrollee(enrolleeID, name, username, password, mailingA, billingA, email, phoneNum, pin);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (accessedBy == 0)
            {
                this.Hide();
                EnrolleeHomePage newform = new EnrolleeHomePage(enrolleeID);
                newform.ShowDialog();
            }
            else
            {
                this.Hide();
                EnrolleeInfo newform = new EnrolleeInfo(enrolleeID, accessedBy);
                newform.ShowDialog();
            }
        }
    }
}

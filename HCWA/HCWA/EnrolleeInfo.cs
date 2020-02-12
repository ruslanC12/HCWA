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
    public partial class EnrolleeInfo : Form
    {
        private int enrolleeID;
        // who accessed the home page the actually enrollee = 0 or a manager = 1
        private int accessedBy;
        public EnrolleeInfo(int id, int accessed)
        {
            InitializeComponent();
            enrolleeID = id;
            this.richTextBox1.Text = DBMng.getEnrolleeInfo(enrolleeID);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            //AddRemoveGUI addRem = new AddRemoveGUI(enrolleeToDisplay);
            //addRem.ShowDialog();
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            EnrolleeEditInfo newform = new EnrolleeEditInfo(enrolleeID, accessedBy);
            newform.ShowDialog();
        }
    }
}

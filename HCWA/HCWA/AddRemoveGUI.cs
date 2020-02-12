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
    public partial class AddRemoveGUI : Form
    {
        PrimaryEnrollee PrimEnr;
        DependentController Cntrl = new DependentController();
        public AddRemoveGUI(PrimaryEnrollee primary)
        {
            InitializeComponent();
            PrimEnr = primary;
            foreach(DependentEnrollee DepEnr in primary.dependents)
            {
                comboBox1.Items.Add(DepEnr.getFullname());
            }
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox2.Text == null)
            {
                label4.Text = "Please Enter a name and relationship";
            }
            else
            {
                string fullname = textBox1.Text;
                string relationship = textBox2.Text;
                label4.Text = Cntrl.addDependent(fullname, relationship, PrimEnr);
                comboBox1.Items.Add(fullname);
                textBox1.Text = "";
                textBox2.Text = "";
            }

          
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int index;
            index = comboBox1.SelectedIndex;
            label5.Text = Cntrl.removeDependent(index, PrimEnr);
            comboBox1.Items.RemoveAt(index);
            comboBox1.Text = "";
        }
    }
}

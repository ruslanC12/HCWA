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
    public partial class ManagerDisplay : Form
    {
        private string[,] enrollees;
        private int numOfEnrollees = 0;
        public ManagerDisplay()
        {
            InitializeComponent();
            numOfEnrollees = DBMng.getNumOfEnrollees();
            enrollees = DBMng.getEnrollees(numOfEnrollees);
            for (int i = 0; i < numOfEnrollees; i++)
            {
                listBox1.Items.Add(enrollees[i,2]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nameOfSelected = listBox1.SelectedItem.ToString();
            int id = 0;
            
            for(int i = 0; i< numOfEnrollees; i++)
            {
                if(nameOfSelected == enrollees[i,2])
                {
                    id = int.Parse(enrollees[i,0]);
                }
            }

            if(id != 0)
            {
                this.Hide();
                EnrolleeInfo newform = new EnrolleeInfo(id, 1);
                newform.ShowDialog();
            }
        }
    }
}

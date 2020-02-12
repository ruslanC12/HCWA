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

    public partial class GenerateFormGUIHelper : Form
    {
        private int[] numEnrollees;

        private double enrolleePayments;
        public GenerateFormGUIHelper()
        {
            InitializeComponent();

            int month = DBMng.getCurrentMonth();

            label5.Text = "For the month of " + month;

            numEnrollees = DBMng.findNumEnrollees();
            int numBills = DBMng.getNumBills();

            listBox1.Items.Add(numEnrollees[0]);
            listBox2.Items.Add(numEnrollees[1]);

            listBox3.Items.Add(numBills);

        }


    }
}

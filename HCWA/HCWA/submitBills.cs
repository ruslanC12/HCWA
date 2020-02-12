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
    public partial class submitBills : Form
    {
        private string[,] enrollees;
        private int numEnrollees;
        public submitBills(int id)
        {
            InitializeComponent();
            numEnrollees = DBMng.getNumOfEnrollees();
            enrollees = DBMng.getEnrollees(numEnrollees);
            for (int i = 0; i < numEnrollees; i++)
            {
                listBox2.Items.Add(enrollees[i, 2]);
            }
            string[] info = DBMng.getHSPInfo(id);
            string[] services = info[2].Split(',');
            displayServices(services);
            

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int serviceid;
            serviceid = getServiceIndex(listBox1.GetItemText(listBox1.SelectedItem));
            if (serviceid == -1)
            {
                label4.Text = "No Service";
            }
            else if (listBox1.SelectedIndex == -1)
            {
                label4.Text = "Please Select a Service";
            }
            else if (listBox2.SelectedIndex == - 1)
            {
                label4.Text = "Please Select an Enrollee to Bill";
            }
            else
            {
                Bills b = new Bills(double.Parse(textBox1.Text), listBox2.SelectedIndex, serviceid);
                DBMng.insertIntoBills(b);
                label4.Text = "Success";
            }
        }
        private void displayServices(string[] servs)
        {
            int index;
            int i = 0;
            while (i < servs.Length)
            {
                index = int.Parse(servs[i]);
                switch (index)
                {
                    case 0:
                        listBox1.Items.Add("Inpatient");
                        break;
                    case 1:
                        listBox1.Items.Add("Inpatient (Behavioral Health)");
                        break;
                    case 2:
                        listBox1.Items.Add("Emergency Room");
                        break;
                    case 3:
                        listBox1.Items.Add("Outpatient (level 1)");
                        break;
                    case 4:
                        listBox1.Items.Add("Outpatient (level 2)");
                        break;
                    case 5:
                        listBox1.Items.Add("Outpatient (level 3)");
                        break;
                    case 6:
                        listBox1.Items.Add("Diagnostic Lab & X-Ray");
                        break;
                    case 7:
                        listBox1.Items.Add("Physician Office Visits");
                        break;
                    case 8:
                        listBox1.Items.Add("Specialist Office Visits");
                        break;
                    case 9:
                        listBox1.Items.Add("Preventive Services");
                        break;
                    case 10:
                        listBox1.Items.Add("Baby Care");
                        break;
                    case 11:
                        listBox1.Items.Add("Durable Medical Equipment");
                        break;
                    case 12:
                        listBox1.Items.Add("Nursing Facility");
                        break;
                    case 13:
                        listBox1.Items.Add("Physical Therapy");
                        break;
                    default:
                        listBox1.Items.Add("No Services");
                        return;
                }
                i++;
            }
         }
        private int getServiceIndex(string text)
        {
            int id;
            switch (text)
            {
                case "Inpatient":
                    id = 0;
                    break;
                case "Inpatient (Behavioral Health)":
                    id = 1;
                    break;
                case "Emergency Room":
                    id = 2;
                    break;
                case "Outpatient (level 1)":
                    id = 3;
                    break;
                case "Outpatient (level 2)":
                    id = 4;
                    break;
                case "Outpatient (level 3)":
                    id = 5;
                    break;
                case "Diagnostic Lab & X-Ray":
                    id = 6;
                    break;
                case "Physician Office Visits":
                    id = 7;
                    break;
                case "Specialist Office Visits":
                    id = 8;
                    break;
                case "Preventive Services":
                    id = 9;
                    break;
                case "Baby Care":
                    id = 10;
                    break;
                case "Durable Medical Equipment":
                    id = 11;
                    break;
                case "Nursing Facility":
                    id = 12;
                    break;
                case "Physical Therapy":
                    id = 13;
                    break;
                case "No Services":
                    id = -1;
                    break;
                default:
                    id = -1;
                    break;
            }
            return id;
        }

            }
}

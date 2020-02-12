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
    public partial class GenerateFormGUI : Form
    {
        
        public GenerateFormGUI()
        {
            InitializeComponent();

        }
        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            GenerateFormGUIHelper g = new GenerateFormGUIHelper();
            g.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Program
{
    public partial class frmButtonsAndMessageboxes : Form
    {
        public frmButtonsAndMessageboxes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {  
            //This shows a messagebox to the user when the Red button is clicked.
            MessageBox.Show("You clicked on the Red button.", "Red Button");
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {   
            //This shows a messagebox to the user when the Blue button is clicked.
            MessageBox.Show("You clicked on the Blue button.", "Blue Button");
        }
    }
}

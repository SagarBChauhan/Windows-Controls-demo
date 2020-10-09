using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pratical_sit_2
{
    public partial class concate : Form
    {
        public concate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblconcate.Text = txtFname.Text + " " + txtLname.Text;
        }

       
    }
}

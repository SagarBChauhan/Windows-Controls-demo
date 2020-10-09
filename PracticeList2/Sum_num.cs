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
    public partial class Sum_num : Form
    {
        public Sum_num()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int v1 = Convert.ToInt32(txtval1.Text);
            int v2 = Convert.ToInt32(txtval2.Text);
            int ans;
            ans = v1 + v2;
            MessageBox.Show("Addition is : " +  ans);
        }
    }
}

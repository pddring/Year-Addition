using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Year_Addition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int result = YearCalculator.addUpNumbers(txtYear.Text);
                lblOutput.Text = result.ToString();
            } catch
            {
                lblOutput.Text = "Error - please enter a valid date";
            }
        }
    }
}

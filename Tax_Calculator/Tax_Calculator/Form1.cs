using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tax_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblTitle.Text = "Enter Cost (£):";
        }

        public void bttnConfirm_Click(object sender, EventArgs e)
        {
            int cost;
            cost = Int32.Parse(txtBox1.Text);
            Tax taxForm = new Tax(cost);
            taxForm.ShowDialog();
        }
    }
}

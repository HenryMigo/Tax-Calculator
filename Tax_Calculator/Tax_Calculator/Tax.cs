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
    public partial class Tax : Form
    {
        int cost;

        public Tax(int cost)
        {
            InitializeComponent();
            lblTax.Text = "Enter in the Tax percentage(Example 80%):";
            this.cost = cost;
        }

        private void bttnConfirmTax_Click(object sender, EventArgs e)
        {
            float tax;
            tax = Int32.Parse(txtBoxTax.Text);
            float taxFinal = tax / 100;
            // MessageBox.Show(taxFinal.ToString());
            float price = cost * taxFinal;
            MessageBox.Show(price.ToString());
        }
    }
}

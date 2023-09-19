using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            txtpricew.Clear();
            txtpricew.Text += "************************************\n";
            txtpricew.Text += "*********   RAWAL SEEDS    *********\n";
            txtpricew.Text += "************************************\n";
            txtpricew.Text += "Date:" + DateTime.Now + "\n\n";

            txtpricew.Text += "Name: " + txtname.Text + "\n\n";
            txtpricew.Text += "Mobile number: " + txtcont.Text + "\n\n";
            txtpricew.Text += "Product Quantity: " + txtprod.Text + "\n\n";
            txtpricew.Text += "Total Price: " + txtprice.Text + "\n\n";
            
            txtpricew.Text += "\n  Signature";
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtcont.Text = "";
            txtprod.Text = "";
            txtprice.Text = "";

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtpricew.Text, new Font("Microsoft Sans Serif", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        
    }
}

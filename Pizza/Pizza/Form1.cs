using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Form1 : Form
    {
        double pret = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void Pizza_Load(object sender, EventArgs e)
        {
            cboSortiment.SelectedIndex = 0;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cboSortiment_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbPizza.Image = new Bitmap("Resources/" + cboSortiment.Text + ".jpg");
            lbPret.Text = lstPret.Items[cboSortiment.SelectedIndex].ToString();
            pret = double.Parse(lbPret.Text);
            chkCiuperci.Checked = false;
            chkPorumb.Checked = false;
            chkPui.Checked = false;
            chkTon.Checked = false;
            rbMedie.Checked = true;
        }

        private void lstPret_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkTon_CheckedChanged(object sender, EventArgs e)
        {
            if(chkTon.Checked)
            {
                pret = pret + 6.50;
                lbPret.Text = pret.ToString();
            }
            else
            {
                pret = pret - 6.50;
                lbPret.Text = pret.ToString();
            }
                
            
            
        }
    }
}

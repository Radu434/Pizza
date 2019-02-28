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
            gbAlegere.Enabled = false;
            rbMedie.Checked = true;
            
        }
        private void Pizza_Load(object sender, EventArgs e)
        {
            cboSortiment.SelectedIndex = 0;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(chkCiuperci.Checked)
            {
                pret = pret + 3.50;
                lbPret.Text = pret.ToString();
            }
            else
            {
                pret = pret - 3.50;
                lbPret.Text = pret.ToString();
            }
        }

        private void cboSortiment_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbPizza.Image = new Bitmap("Resources/" + cboSortiment.Text + ".jpg");
            lbPret.Text = lstPret.Items[cboSortiment.SelectedIndex].ToString();
            pret = double.Parse(lbPret.Text);
            gbAlegere.Enabled = true;
            chkCiuperci.Checked = false;
            chkPorumb.Checked = false;
            chkPui.Checked = false;
            chkTon.Checked = false;
            rbMedie.Checked = true;
            lbComanda.Text = "Comanda in curs...";
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

        private void btnReset_Click(object sender, EventArgs e)
        {
           
            chkCiuperci.Checked = false;
            chkPorumb.Checked = false;
            chkPui.Checked = false;
            chkTon.Checked = false;
            cboSortiment.SelectedIndex = 0;
            rbMedie.Checked = true;
            lbPret.Text = pret.ToString();
            lbComanda.Text = "";
        }

        private void chkPui_CheckedChanged(object sender, EventArgs e)
        {
            double aux = pret;
            if(chkPui.Checked)
            {
                pret = pret + 5;
                lbPret.Text = pret.ToString();
            }
            else
            {
                pret = pret - 5;
                lbPret.Text = pret.ToString();
            }
            if (rbMica.Checked)
            {
                pret = pret -3;

            }
            if(rbMedie.Checked)
            {
                pret = aux;
            }
            if(rbMare.Checked)
            {
                pret = pret +3;
            }
        }

        private void chkPorumb_CheckedChanged(object sender, EventArgs e)
        {
            if(chkPorumb.Checked)
            {
                pret = pret + 3;
                lbPret.Text = pret.ToString();
            }
            else
            {
                pret = pret - 3;
                lbPret.Text = pret.ToString();
            }
        }

        private void lbComanda_Click(object sender, EventArgs e)
        {

        }

        private void rbMica_CheckedChanged(object sender, EventArgs e)
        {
           

        }

        private void rbMedie_CheckedChanged(object sender, EventArgs e)
        {
            if(rbMedie.Checked)
            {
                rbMica.Checked = false;
                rbMare.Checked = false;
            }
        }

        private void lbPret_Click(object sender, EventArgs e)
        {
            
        }
    }
}

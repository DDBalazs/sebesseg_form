using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sebesseg_formm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btszam_Click(object sender, EventArgs e)
        {
            double ut = Convert.ToDouble(txut.Text);
            double ido = Convert.ToDouble(txido.Text);

            double sebesseg = ut / ido;
            sebesseg = Math.Round(sebesseg, 1);
            txseb.Text= sebesseg.ToString();

            if(sebesseg > 50)
            {
                txseb.BackColor=Color.Red;
                lbhaha.Text = "Gyorshajtás!";
                lbhaha.ForeColor=Color.Red;
            }
            else
            {
                txseb.BackColor = Color.White;
                lbhaha.Text = "Megengedett sebességgel hajt";
                lbhaha.ForeColor=Color.Black;
            }
        }

        private void btkilep_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            lbhaha.Text = "";
        }
    }
}

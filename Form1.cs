using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Problemas.Clases;

namespace Problemas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string entrada = "**Casa 52";
            ChangeString obj = new ChangeString();
            string output = obj.build(entrada);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] arrayEnt = new int[3] { 58, 60, 55 };

            CompleteRange obj = new CompleteRange();
            int[] array = obj.build(arrayEnt);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double entrada = 10.5;
            MoneyParts obj = new MoneyParts();
            double[][] output = obj.build(entrada);
        }
    }
}

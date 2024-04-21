using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace L.R._4_part2_C_
{
    public partial class Form1 : Form
    {
        private Model model;
        public Form1()
        {
            InitializeComponent();
            model = new Model();
            model.DataChanged += new System.EventHandler(this.Form1_updateFromModel);
        }

        private void numUpDwnA_ValueChanged(object sender, EventArgs e)
        {
            model.setA(((int)(numUpDwnA.Value)));
        }
        private void Form1_updateFromModel(object sender, EventArgs e) {
            numUpDwnA.Value = model.getA();
            numUpDwnB.Value = model.getB();
            numUpDwnC.Value = model.getC();
        }

        private void numUpDwnB_ValueChanged(object sender, EventArgs e)
        {
            model.setB(((int)(numUpDwnB.Value)));
        }

        private void numUpDwnC_ValueChanged(object sender, EventArgs e)
        {
            model.setC(((int)(numUpDwnC.Value)));

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(numUpDwnA.Value.ToString());
        }
    }
}

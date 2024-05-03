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
            this.Form1_updateFromModel(this, null);
        }
        private void Form1_updateFromModel(object sender, EventArgs e)
        {
            numUpDwnA.Value = model.getA();
            numUpDwnB.Value = model.getB();
            numUpDwnC.Value = model.getC();
            tBox_A.Text = model.getA().ToString();
            tBox_B.Text = model.getB().ToString();
            tBox_C.Text = model.getC().ToString();
            tBarA.Value = model.getA();
            tBarB.Value = model.getB();
            tBarC.Value = model.getC();
            model.save();
        }
        private void numUpDwnA_ValueChanged(object sender, EventArgs e)
        {
            model.setA(((int)(numUpDwnA.Value)));
            tBoxTstA.Text = numUpDwnA.Value.ToString();
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
        {}

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {}

        private void tBoxC_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(model.getC().ToString());

        }

        private void tBoxB_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(model.getB().ToString());

        }

        private void tBoxA_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(model.getA().ToString()) ;
        }

        private void tBox_A_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tBox_A.Text, out int result))
            {
                model.setA(result);
            }
            else
            {
                tBox_A.Text = (model.getA()).ToString();
            }

        }

        private void tBox_B_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tBox_B.Text, out int result))
            {
                model.setB(result);
            }
            else
            {
                tBox_B.Text = (model.getB()).ToString();
            }
        }

        private void tBox_C_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tBox_C.Text, out int result))
            {
                model.setC(result);
            }
            else
            {
                tBox_C.Text = (model.getC()).ToString();
            }
        }

        private void tBarA_ValueChanged(object sender, EventArgs e)
        {
            model.setA(tBarA.Value);
        }

       
        private void tBarB_ValueChanged(object sender, EventArgs e)
        {
            model.setB(tBarB.Value);
        }

        private void tBarC_ValueChanged(object sender, EventArgs e)
        {
            model.setC(tBarC.Value);
        }

        private void numUpDwnA_Leave(object sender, EventArgs e)
        {
            model.setA((int)(numUpDwnA.Value));
            //int a = model.getA();
            //numUpDwnA.Value = 0;
            //numUpDwnA.Value = a;
          
        }
    }
}

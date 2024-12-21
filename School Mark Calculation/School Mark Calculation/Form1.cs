using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Mark_Calculation
{
    public partial class Form1 : Form
    {
        decimal ass1;
        decimal ass2;
        decimal dp=0;
        decimal fMark;
        decimal eMark;
        decimal aegro;

        private void DPbutton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    ass1 = decimal.Parse(assBox1.Text);
            //    ass2 = decimal.Parse(assBox2.Text);
            //    aegro = decimal.Parse(aegroBox.Text);
            //}
            //catch
            //{
            //    MessageBox.Show("Please enter 0 where unticked");
            //}

            dp = 0;
            if((checkBox1.Checked=true)&&(checkBox2.Checked=true)&&(checkBox3.Checked=true))
            {
                MessageBox.Show("2 Minimun Assesments Can Be Selected ");
            }
            else
            {
                if (checkBox1.Checked)
                    dp += decimal.Parse(assBox1.Text);
                if (checkBox2.Checked)
                    dp += decimal.Parse(assBox2.Text);
                if (checkBox3.Checked)
                    dp += decimal.Parse(aegroBox.Text);
            }

                  dp = (ass1 + ass2) / 2;
                  dpBox.Text = dp.ToString();
                  FinaLbutton.Enabled = true;
                  markBox.Enabled = true;
            //if ((checkBox1.Checked=true)&&(checkBox2.Checked=true))
            //{
            //    dp = (ass1 + ass2) / 2;
            //    dpBox.Text = dp.ToString();
            //    FinaLbutton.Enabled = true;
            //    markBox.Enabled = true;
            //}
            //if((checkBox1.Checked=true)&&(checkBox3.Checked=true))
            //{
            //    dp = (ass1 + aegro) / 2;
            //    dpBox.Text = dp.ToString();
            //    FinaLbutton.Enabled = true;
            //    markBox.Enabled = true;
            //}
            //if ((checkBox2.Checked = true) && (checkBox3.Checked = true))
            //{
            //    dp = (ass2 + aegro) / 2;
            //    dpBox.Text = dp.ToString();
            //    FinaLbutton.Enabled = true;
            //    markBox.Enabled = true;
            //}
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FinaLbutton_Click(object sender, EventArgs e)
        {
            eMark = decimal.Parse(markBox.Text);
            fMark = ((dp * 0.5m) + (eMark * 0.5m));
            textBox1.Text = fMark.ToString("N0");

            if (fMark >= 80)
                MessageBox.Show("A");
            else if ((fMark >= 70) && (fMark < 80))
                MessageBox.Show("B");
            else if ((fMark >= 60) && (fMark < 70))
                MessageBox.Show("C");
            else if ((fMark >= 50) && (fMark < 60))
                MessageBox.Show("D");
            else if ((fMark >= 40) && (fMark < 50))
            {
                MessageBox.Show("Supplementary");
                label8.Show();
                textBox2.Show();
                button1.Visible = true;
                SuppBox.Visible = true;
                label7.Visible = true;

            }
            else
                MessageBox.Show("Failed");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal SuppMark = decimal.Parse(SuppBox.Text);
            decimal FinalMarkAS = Math.Round((SuppMark + dp) / 2, 0);
            textBox2.Text = FinalMarkAS.ToString();
            if (FinalMarkAS >= 80)
                MessageBox.Show("A");
            else if ((FinalMarkAS >= 70) && (FinalMarkAS < 80))
                MessageBox.Show("B");
            else if ((FinalMarkAS >= 60) && (FinalMarkAS < 70))
                MessageBox.Show("C");
            else if ((FinalMarkAS >= 50) && (FinalMarkAS < 60))
                MessageBox.Show("D");
            else
                MessageBox.Show("Failed");
        }
        //private void textBox2_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void label6_Click(object sender, EventArgs e)
        // {

        //}
    }
}

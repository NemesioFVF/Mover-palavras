using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string pss1;
        int cntr, cntr2;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            pss1 = txt1.Text;
            list1.Items.Add(pss1);
            txt1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pss1 = list1.Text;
            list2.Items.Add(pss1);
            list1.Items.RemoveAt(list1.SelectedIndex);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pss1 = "";
            list2.Items.Clear();
            list1.Items.Clear();
            txt1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pss1 = list2.Text;
            list1.Items.Add(pss1);
            list2.Items.RemoveAt(list2.SelectedIndex);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cntr2 = list1.Items.Count;
            for (cntr = 0; cntr < cntr2; cntr++)
            {
                list1.SelectedIndex = cntr;
                pss1 = list1.Text;
                list2.Items.Add(pss1);
            }
            list1.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cntr2 = list2.Items.Count;
            for (cntr = 0; cntr < cntr2; cntr++)
            {
                list2.SelectedIndex = cntr;
                pss1 = list2.Text;
                list1.Items.Add(pss1);
            }
            list2.Items.Clear();
        }

        private void list2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        int money = 0;
        int multiplier = 1;
        public Form1()
        {
            InitializeComponent();
            invest.Visible = false;
            reward.Visible = false;
        }
            
        private void button1_Click(object sender, EventArgs e)
        {
            money = money + multiplier;
            count.Text = money.ToString();
            if (money >= 5)
            {
                invest.Visible = true;
            }
            else
                invest.Visible = false;
            if (money >= 100) 
            {
                reward.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ++multiplier;
            money = money - 5;
            count.Text = money.ToString();
            if (money > 5)
            {
                invest.Visible = true;
            }
            else
                invest.Visible = false;
        }
    }
}

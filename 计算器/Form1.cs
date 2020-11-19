using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 计算器
{
    public partial class Form1 : Form
    {
        //记录第一个数字
        double temp1;
        //存储计算方式
        int pos = 0;
        public void addNum(double num)
        {
            richTextBox1.Text = richTextBox1.Text + num.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += ".";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addNum(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addNum(0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            addNum(2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            addNum(3);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            addNum(4);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            addNum(5);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            addNum(6);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            addNum(7);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            addNum(8);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            addNum(9);
        }

        //除法
        private void button17_Click(object sender, EventArgs e)
        {
            //修改计算方式标志位
            pos = 4;
            //获取前一个数值
            temp1 = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "";
        }

        //乘法
        private void button18_Click(object sender, EventArgs e)
        {
            //修改计算方式标志位
            pos = 3;
            //获取前一个数值
            temp1 = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "";
        }

        //减法
        private void button14_Click(object sender, EventArgs e)
        {
            pos = 2;
            temp1 = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "";
        }

        //加法
        private void button10_Click(object sender, EventArgs e)
        {
            pos = 1;
            temp1 = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "";
        }

        //等于
        private void button3_Click(object sender, EventArgs e)
        {
            //记录第二个数字
            double temp2 = Convert.ToDouble(richTextBox1.Text);
            //根据计算方式进行计算，显示计算结果
            switch (pos)
            {
                case 1:
                    richTextBox1.Text = (temp1 + temp2).ToString();
                    break;
                case 2:
                    richTextBox1.Text = (temp1 - temp2).ToString();
                    break;
                case 3:
                    richTextBox1.Text = (temp1 * temp2).ToString();
                    break;
                case 4:
                    richTextBox1.Text = (temp1 / temp2).ToString();
                    break;
            }
        }

        //归零
        private void button15_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
            temp1 = 0;
            pos = 0;
        }

        //删除一位
        private void button16_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length-1);
        }
    }
}

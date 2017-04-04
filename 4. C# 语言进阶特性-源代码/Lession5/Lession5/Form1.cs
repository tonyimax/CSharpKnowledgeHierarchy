using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lession5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "HelloWorld";
            //为控件添加事件，myClick是自己添加的事件处理方法
            this.Click += new EventHandler(this.myClick);
            //通过 += 后按 TAB按自动生成事件与事件处理方法 
            this.KeyDown += Form1_KeyDown;
        }
        /// <summary>
        ///自动生成 事件处理方法 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        int count = 0;
        private void Form1_Click(object sender, EventArgs e)
        {
            count++;
            this.Text += count.ToString(); 
        }
        /// <summary>
        /// myClick是自己添加的事件处理方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void myClick(object sender, EventArgs e)
        {
            MessageBox.Show(this.Text,"提示",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

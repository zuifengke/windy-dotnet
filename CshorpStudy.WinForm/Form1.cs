﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CshorpStudy.WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Grid代码实现 form = new Grid代码实现();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RibbonUse ribbon = new RibbonUse();
            ribbon.Show();
        }
    }
}

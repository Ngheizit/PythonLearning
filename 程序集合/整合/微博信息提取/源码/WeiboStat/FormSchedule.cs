﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeiboStat
{
    public partial class FormSchedule : Form
    {
        public FormSchedule(int length)
        {
            InitializeComponent();
            progressBar1.Maximum = length;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;
        }
        public void GO(string info = "")
        {
            textBox1.Text = info;
            progressBar1.Value += 1;
        }

        public void OK()
        {
            this.Dispose();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPSLab2
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
            MaximizeBox = false; //Отключение возможности растягивания окна
        }

        private void CloseInfoFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
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
    public partial class MainForm : Form
    {
        InfoForm showInfoForm = null;
        public MainForm()
        {
            InitializeComponent();
            MaximizeBox = false; //Отключение возможности растягивания окна
            if (!BeaufortRadioButton.Checked && !ROT13RadioButton.Checked)
            {
                EncodeButton.Enabled = false;
                DecodeButton.Enabled = false;
            }
        }

        private void InfoToolStripMenuItem_Click(object sender, EventArgs e) //Вывод справочного окна
        {
            //Вызов формы и запрет на открытие множества одинаковых окон
            if (showInfoForm == null || showInfoForm.IsDisposed)
            {
                showInfoForm = new InfoForm();
                showInfoForm.Show();
            }
            else
            {
                showInfoForm.Show();
                showInfoForm.Focus();
            }
        }

        private void BeaufortRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EncodeButton.Enabled = true;
            DecodeButton.Enabled = true;
        }

        private void ROT13RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EncodeButton.Enabled = true;
            DecodeButton.Enabled = true;
        }
    }
}
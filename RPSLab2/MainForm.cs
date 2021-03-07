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
                KeyLabel.Visible = false;
                KeyTextBox.Visible = false;
                FileInputButton.Visible = false;
                DataTextBox.Enabled = false;
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
            KeyLabel.Visible = true;
            KeyTextBox.Visible = true;
            if (FileInputRadioButton.Checked)
                FileInputButton.Enabled = true;
        }

        private void ROT13RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EncodeButton.Enabled = true;
            DecodeButton.Enabled = true;
            KeyLabel.Visible = false;
            KeyTextBox.Visible = false;
            if (FileInputRadioButton.Checked)
                FileInputButton.Enabled = true;
        }

        private void EncodeButton_Click(object sender, EventArgs e)
        {
            if (BeaufortRadioButton.Checked)
            {
                
            }
            else if (ROT13RadioButton.Checked)
            {

            }
        }

        private void DecodeButton_Click(object sender, EventArgs e)
        {
            if (BeaufortRadioButton.Checked)
            {

            }
            else if (ROT13RadioButton.Checked)
            {

            }
        }

        private void ManualInputRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            FileInputButton.Visible = false;
            DataTextBox.Enabled = true;
            BeaufortRadioButton.Enabled = true;
            ROT13RadioButton.Enabled = true;
        }

        private void FileInputRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            FileInputButton.Visible = true;
            if (BeaufortRadioButton.Checked || ROT13RadioButton.Checked)
                FileInputButton.Enabled = true;
            else
                FileInputButton.Enabled = false;
            DataTextBox.Enabled = true;
            BeaufortRadioButton.Enabled = true;
            ROT13RadioButton.Enabled = true;
        }
    }
}
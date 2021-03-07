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
            EncodeButton.Enabled = false;
            DecodeButton.Enabled = false;
            KeyLabel.Visible = false;
            KeyTextBox.Visible = false;
            FileInputButton.Visible = false;
            DataTextBox.Enabled = false;
            BeaufortRadioButton.Enabled = false;
            ROT13RadioButton.Enabled = false;
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

        string text = null;
        string key = null;
        private void EncodeButton_Click(object sender, EventArgs e)
        {
            text = DataTextBox.Text;
            if (BeaufortRadioButton.Checked)
            {
                if (KeyTextBox.Text != "")
                {
                    Beaufort beaufort = new Beaufort();
                    key = KeyTextBox.Text;
                    text = beaufort.Encode(text, key);
                    ResultTextBox.Text = text;
                }
                else
                    MessageBox.Show("Ключ отсутствует", "Ошибка");
            }
            else if (ROT13RadioButton.Checked)
            {
                ROT13 rot13 = new ROT13();
                key = null;
                text = rot13.Encode(text, key);
                ResultTextBox.Text = text;
            }
        }

        private void DecodeButton_Click(object sender, EventArgs e)
        {
            text = DataTextBox.Text;
            if (BeaufortRadioButton.Checked)
            {
                if (KeyTextBox.Text != "")
                {
                    Beaufort beaufort = new Beaufort();
                    key = KeyTextBox.Text;
                    text = beaufort.Decode(text, key);
                    ResultTextBox.Text = text;
                }
                else
                    MessageBox.Show("Ключ отсутствует", "Ошибка");
            }
            else if (ROT13RadioButton.Checked)
            {
                ROT13 rot13 = new ROT13();
                key = null;
                text = rot13.Decode(text, key);
                ResultTextBox.Text = text;
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
            DataTextBox.Enabled = false;
            BeaufortRadioButton.Enabled = true;
            ROT13RadioButton.Enabled = true;
        }

        private void SaveDataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataTextBox.Text != "") //Проверка наличия исходных данных
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return; //Случай с отменой выбора файла
                string saveFilename = saveFileDialog1.FileName;
                System.IO.File.WriteAllText(saveFilename, DataTextBox.Text); //Сохранение в файл
                MessageBox.Show("Файл сохранен", "Файл");
            }
            else
                MessageBox.Show("Исходные данные отсутствуют", "Файл");
        }

        private void SaveResultFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataTextBox.Text != "" && ResultTextBox.Text != "") //Проверка наличия результата 
            {
                if (BeaufortRadioButton.Checked)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                        return; //Случай с отменой выбора файла
                    string saveFilename = saveFileDialog1.FileName;
                    //Сохранение в файл
                    System.IO.File.WriteAllText(saveFilename, " Исходный текст: \n" +
                        DataTextBox.Text + "\n Ключ: \n" + KeyTextBox.Text + "\n Измененный текст: \n" + ResultTextBox.Text);
                    MessageBox.Show("Файл сохранен", "Файл");
                }
                else if (ROT13RadioButton.Checked)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                        return; //Случай с отменой выбора файла
                    string saveFilename = saveFileDialog1.FileName;
                    //Сохранение в файл
                    System.IO.File.WriteAllText(saveFilename, " Исходный текст: \n" +
                        DataTextBox.Text + "\n Измененный текст: \n" + ResultTextBox.Text);
                    MessageBox.Show("Файл сохранен", "Файл");
                }
            }
            else
                MessageBox.Show("Результат программы отсутствует", "Файл");
        }

        private void FileInputButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return; //Случай с отменой выбора файла
            else
            {
                string filename = openFileDialog1.FileName; //Выбор файла
                text = System.IO.File.ReadAllText(filename); //Считывание из файла
                DataTextBox.Text = text;
            }
        }
    }
}
﻿using System;
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
            //Настройки видимости интерфейса
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
            //Настройки видимости интерфейса при выборе шифра Бофора
            EncodeButton.Enabled = true;
            DecodeButton.Enabled = true;
            KeyLabel.Visible = true;
            KeyTextBox.Visible = true;
            if (FileInputRadioButton.Checked)
                FileInputButton.Enabled = true;
        }

        private void ROT13RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Настройки видимости интерфейса при выборе шифра ROT13
            EncodeButton.Enabled = true;
            DecodeButton.Enabled = true;
            KeyLabel.Visible = false;
            KeyTextBox.Visible = false;
            if (FileInputRadioButton.Checked)
                FileInputButton.Enabled = true;
        }

        string text = null;
        string key = null;
        private void EncodeButton_Click(object sender, EventArgs e) //Нажатие кнопки "Шифровать"
        {
            text = DataTextBox.Text;
            if (BeaufortRadioButton.Checked) //Если выбран шифр Бофора
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
            else if (ROT13RadioButton.Checked) //Если выбран шифр ROT13
            {
                ROT13 rot13 = new ROT13();
                key = null;
                text = rot13.Encode(text, key);
                ResultTextBox.Text = text;
            }
        }

        private void DecodeButton_Click(object sender, EventArgs e) //Нажатие кнопки "Дешифровать"
        {
            text = DataTextBox.Text;
            if (BeaufortRadioButton.Checked) //Если выбран шифр Бофора
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
            else if (ROT13RadioButton.Checked) //Если выбран шифр ROT13
            {
                ROT13 rot13 = new ROT13();
                key = null;
                text = rot13.Decode(text, key);
                ResultTextBox.Text = text;
            }
        }

        private void ManualInputRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Настройки видимости интерфейса при выборе ручного ввода
            FileInputButton.Visible = false;
            DataTextBox.Enabled = true;
            BeaufortRadioButton.Enabled = true;
            ROT13RadioButton.Enabled = true;
        }

        private void FileInputRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Настройки видимости интерфейса при выборе ввода из файла
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
            //Сохранение исходных данных
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
            //Сохранение результата программы
            if (DataTextBox.Text != "" && ResultTextBox.Text != "") //Проверка наличия результата 
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return; //Случай с отменой выбора файла
                string saveFilename = saveFileDialog1.FileName;
                //Сохранение в файл
                System.IO.File.WriteAllText(saveFilename, ResultTextBox.Text);
                MessageBox.Show("Файл сохранен", "Файл");
            }
            else
                MessageBox.Show("Результат программы отсутствует", "Файл");
        }

        private void FileInputButton_Click(object sender, EventArgs e)
        {
            //Ввод из файла
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
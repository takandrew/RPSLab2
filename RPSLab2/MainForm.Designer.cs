
namespace RPSLab2
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveDataFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveResultFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BeaufortRadioButton = new System.Windows.Forms.RadioButton();
            this.ROT13RadioButton = new System.Windows.Forms.RadioButton();
            this.EncodeButton = new System.Windows.Forms.Button();
            this.DecodeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FileInputButton = new System.Windows.Forms.Button();
            this.FileInputRadioButton = new System.Windows.Forms.RadioButton();
            this.ManualInputRadioButton = new System.Windows.Forms.RadioButton();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataTextBox
            // 
            this.DataTextBox.Location = new System.Drawing.Point(33, 61);
            this.DataTextBox.Name = "DataTextBox";
            this.DataTextBox.Size = new System.Drawing.Size(676, 22);
            this.DataTextBox.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.InfoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(757, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveDataFileToolStripMenuItem,
            this.SaveResultFileToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // SaveDataFileToolStripMenuItem
            // 
            this.SaveDataFileToolStripMenuItem.Name = "SaveDataFileToolStripMenuItem";
            this.SaveDataFileToolStripMenuItem.Size = new System.Drawing.Size(346, 26);
            this.SaveDataFileToolStripMenuItem.Text = "Сохранить исходные данные в файл";
            this.SaveDataFileToolStripMenuItem.Click += new System.EventHandler(this.SaveDataFileToolStripMenuItem_Click);
            // 
            // SaveResultFileToolStripMenuItem
            // 
            this.SaveResultFileToolStripMenuItem.Name = "SaveResultFileToolStripMenuItem";
            this.SaveResultFileToolStripMenuItem.Size = new System.Drawing.Size(346, 26);
            this.SaveResultFileToolStripMenuItem.Text = "Сохранить результат в файл";
            this.SaveResultFileToolStripMenuItem.Click += new System.EventHandler(this.SaveResultFileToolStripMenuItem_Click);
            // 
            // InfoToolStripMenuItem
            // 
            this.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem";
            this.InfoToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.InfoToolStripMenuItem.Text = "Справка";
            this.InfoToolStripMenuItem.Click += new System.EventHandler(this.InfoToolStripMenuItem_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(33, 340);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(676, 22);
            this.ResultTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Исходный текст";
            // 
            // BeaufortRadioButton
            // 
            this.BeaufortRadioButton.AutoSize = true;
            this.BeaufortRadioButton.Location = new System.Drawing.Point(223, 109);
            this.BeaufortRadioButton.Name = "BeaufortRadioButton";
            this.BeaufortRadioButton.Size = new System.Drawing.Size(123, 21);
            this.BeaufortRadioButton.TabIndex = 4;
            this.BeaufortRadioButton.TabStop = true;
            this.BeaufortRadioButton.Text = "Шифр Бофора";
            this.BeaufortRadioButton.UseVisualStyleBackColor = true;
            this.BeaufortRadioButton.CheckedChanged += new System.EventHandler(this.BeaufortRadioButton_CheckedChanged);
            // 
            // ROT13RadioButton
            // 
            this.ROT13RadioButton.AutoSize = true;
            this.ROT13RadioButton.Location = new System.Drawing.Point(423, 109);
            this.ROT13RadioButton.Name = "ROT13RadioButton";
            this.ROT13RadioButton.Size = new System.Drawing.Size(75, 21);
            this.ROT13RadioButton.TabIndex = 5;
            this.ROT13RadioButton.TabStop = true;
            this.ROT13RadioButton.Text = "ROT13";
            this.ROT13RadioButton.UseVisualStyleBackColor = true;
            this.ROT13RadioButton.CheckedChanged += new System.EventHandler(this.ROT13RadioButton_CheckedChanged);
            // 
            // EncodeButton
            // 
            this.EncodeButton.Location = new System.Drawing.Point(160, 239);
            this.EncodeButton.Name = "EncodeButton";
            this.EncodeButton.Size = new System.Drawing.Size(161, 44);
            this.EncodeButton.TabIndex = 6;
            this.EncodeButton.Text = "Шифровать";
            this.EncodeButton.UseVisualStyleBackColor = true;
            this.EncodeButton.Click += new System.EventHandler(this.EncodeButton_Click);
            // 
            // DecodeButton
            // 
            this.DecodeButton.Location = new System.Drawing.Point(409, 239);
            this.DecodeButton.Name = "DecodeButton";
            this.DecodeButton.Size = new System.Drawing.Size(161, 44);
            this.DecodeButton.TabIndex = 7;
            this.DecodeButton.Text = "Дешифровать";
            this.DecodeButton.UseVisualStyleBackColor = true;
            this.DecodeButton.Click += new System.EventHandler(this.DecodeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Результат";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FileInputButton);
            this.groupBox1.Controls.Add(this.FileInputRadioButton);
            this.groupBox1.Controls.Add(this.ManualInputRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(0, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 70);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // FileInputButton
            // 
            this.FileInputButton.Location = new System.Drawing.Point(584, 9);
            this.FileInputButton.Name = "FileInputButton";
            this.FileInputButton.Size = new System.Drawing.Size(161, 44);
            this.FileInputButton.TabIndex = 13;
            this.FileInputButton.Text = "Выбрать файл";
            this.FileInputButton.UseVisualStyleBackColor = true;
            this.FileInputButton.Click += new System.EventHandler(this.FileInputButton_Click);
            // 
            // FileInputRadioButton
            // 
            this.FileInputRadioButton.AutoSize = true;
            this.FileInputRadioButton.Location = new System.Drawing.Point(439, 21);
            this.FileInputRadioButton.Name = "FileInputRadioButton";
            this.FileInputRadioButton.Size = new System.Drawing.Size(127, 21);
            this.FileInputRadioButton.TabIndex = 12;
            this.FileInputRadioButton.Text = "Ввод из файла";
            this.FileInputRadioButton.UseVisualStyleBackColor = true;
            this.FileInputRadioButton.CheckedChanged += new System.EventHandler(this.FileInputRadioButton_CheckedChanged);
            // 
            // ManualInputRadioButton
            // 
            this.ManualInputRadioButton.AutoSize = true;
            this.ManualInputRadioButton.Location = new System.Drawing.Point(160, 21);
            this.ManualInputRadioButton.Name = "ManualInputRadioButton";
            this.ManualInputRadioButton.Size = new System.Drawing.Size(111, 21);
            this.ManualInputRadioButton.TabIndex = 11;
            this.ManualInputRadioButton.Text = "Ручной ввод";
            this.ManualInputRadioButton.UseVisualStyleBackColor = true;
            this.ManualInputRadioButton.CheckedChanged += new System.EventHandler(this.ManualInputRadioButton_CheckedChanged);
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Location = new System.Drawing.Point(352, 152);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(43, 17);
            this.KeyLabel.TabIndex = 9;
            this.KeyLabel.Text = "Ключ";
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Location = new System.Drawing.Point(33, 183);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(676, 22);
            this.KeyTextBox.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ResultTextBox);
            this.groupBox2.Controls.Add(this.DecodeButton);
            this.groupBox2.Controls.Add(this.KeyLabel);
            this.groupBox2.Controls.Add(this.EncodeButton);
            this.groupBox2.Controls.Add(this.KeyTextBox);
            this.groupBox2.Controls.Add(this.ROT13RadioButton);
            this.groupBox2.Controls.Add(this.BeaufortRadioButton);
            this.groupBox2.Controls.Add(this.DataTextBox);
            this.groupBox2.Location = new System.Drawing.Point(0, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(756, 398);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CreatePrompt = true;
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 486);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Шифрование";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DataTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveDataFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveResultFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InfoToolStripMenuItem;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton BeaufortRadioButton;
        private System.Windows.Forms.RadioButton ROT13RadioButton;
        private System.Windows.Forms.Button EncodeButton;
        private System.Windows.Forms.Button DecodeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.Label KeyLabel;
        private System.Windows.Forms.Button FileInputButton;
        private System.Windows.Forms.RadioButton FileInputRadioButton;
        private System.Windows.Forms.RadioButton ManualInputRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}


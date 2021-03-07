
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
            this.BoforRadioButton = new System.Windows.Forms.RadioButton();
            this.ROT13RadioButton = new System.Windows.Forms.RadioButton();
            this.EncodeButton = new System.Windows.Forms.Button();
            this.DecodeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataTextBox
            // 
            this.DataTextBox.Location = new System.Drawing.Point(56, 67);
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
            this.menuStrip1.Size = new System.Drawing.Size(794, 28);
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
            // 
            // SaveResultFileToolStripMenuItem
            // 
            this.SaveResultFileToolStripMenuItem.Name = "SaveResultFileToolStripMenuItem";
            this.SaveResultFileToolStripMenuItem.Size = new System.Drawing.Size(346, 26);
            this.SaveResultFileToolStripMenuItem.Text = "Сохранить результат в файл";
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
            this.ResultTextBox.Location = new System.Drawing.Point(56, 297);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(676, 22);
            this.ResultTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите исходный текст";
            // 
            // BoforRadioButton
            // 
            this.BoforRadioButton.AutoSize = true;
            this.BoforRadioButton.Location = new System.Drawing.Point(223, 114);
            this.BoforRadioButton.Name = "BoforRadioButton";
            this.BoforRadioButton.Size = new System.Drawing.Size(123, 21);
            this.BoforRadioButton.TabIndex = 4;
            this.BoforRadioButton.TabStop = true;
            this.BoforRadioButton.Text = "Шифр Бофора";
            this.BoforRadioButton.UseVisualStyleBackColor = true;
            // 
            // ROT13RadioButton
            // 
            this.ROT13RadioButton.AutoSize = true;
            this.ROT13RadioButton.Location = new System.Drawing.Point(434, 114);
            this.ROT13RadioButton.Name = "ROT13RadioButton";
            this.ROT13RadioButton.Size = new System.Drawing.Size(75, 21);
            this.ROT13RadioButton.TabIndex = 5;
            this.ROT13RadioButton.TabStop = true;
            this.ROT13RadioButton.Text = "ROT13";
            this.ROT13RadioButton.UseVisualStyleBackColor = true;
            // 
            // EncodeButton
            // 
            this.EncodeButton.Location = new System.Drawing.Point(185, 186);
            this.EncodeButton.Name = "EncodeButton";
            this.EncodeButton.Size = new System.Drawing.Size(161, 44);
            this.EncodeButton.TabIndex = 6;
            this.EncodeButton.Text = "Шифровать";
            this.EncodeButton.UseVisualStyleBackColor = true;
            // 
            // DecodeButton
            // 
            this.DecodeButton.Location = new System.Drawing.Point(407, 186);
            this.DecodeButton.Name = "DecodeButton";
            this.DecodeButton.Size = new System.Drawing.Size(161, 44);
            this.DecodeButton.TabIndex = 7;
            this.DecodeButton.Text = "Дешифровать";
            this.DecodeButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Результат";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ResultTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DecodeButton);
            this.groupBox1.Controls.Add(this.BoforRadioButton);
            this.groupBox1.Controls.Add(this.EncodeButton);
            this.groupBox1.Controls.Add(this.ROT13RadioButton);
            this.groupBox1.Location = new System.Drawing.Point(0, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 361);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 390);
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
        private System.Windows.Forms.RadioButton BoforRadioButton;
        private System.Windows.Forms.RadioButton ROT13RadioButton;
        private System.Windows.Forms.Button EncodeButton;
        private System.Windows.Forms.Button DecodeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}


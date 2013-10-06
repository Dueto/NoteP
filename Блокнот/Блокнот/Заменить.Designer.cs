namespace Блокнот
{
    partial class Заменить
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.НайтиДалееButton = new System.Windows.Forms.Button();
            this.ЗаменитьButton = new System.Windows.Forms.Button();
            this.ЗаменитьВсеButton = new System.Windows.Forms.Button();
            this.ОтменаButton = new System.Windows.Forms.Button();
            this.labelЧто = new System.Windows.Forms.Label();
            this.labelЧем = new System.Windows.Forms.Label();
            this.ЧтоTextBox = new System.Windows.Forms.TextBox();
            this.ЧемTextBox = new System.Windows.Forms.TextBox();
            this.сУчетомРегистраCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // НайтиДалееButton
            // 
            this.НайтиДалееButton.Location = new System.Drawing.Point(175, 12);
            this.НайтиДалееButton.Name = "НайтиДалееButton";
            this.НайтиДалееButton.Size = new System.Drawing.Size(86, 23);
            this.НайтиДалееButton.TabIndex = 0;
            this.НайтиДалееButton.Text = "Найти далее";
            this.НайтиДалееButton.UseVisualStyleBackColor = true;
            this.НайтиДалееButton.Click += new System.EventHandler(this.НайтиДалееButton_Click);
            // 
            // ЗаменитьButton
            // 
            this.ЗаменитьButton.Location = new System.Drawing.Point(175, 41);
            this.ЗаменитьButton.Name = "ЗаменитьButton";
            this.ЗаменитьButton.Size = new System.Drawing.Size(86, 23);
            this.ЗаменитьButton.TabIndex = 1;
            this.ЗаменитьButton.Text = "Заменить";
            this.ЗаменитьButton.UseVisualStyleBackColor = true;
            this.ЗаменитьButton.Click += new System.EventHandler(this.ЗаменитьButton_Click);
            // 
            // ЗаменитьВсеButton
            // 
            this.ЗаменитьВсеButton.Location = new System.Drawing.Point(175, 70);
            this.ЗаменитьВсеButton.Name = "ЗаменитьВсеButton";
            this.ЗаменитьВсеButton.Size = new System.Drawing.Size(86, 23);
            this.ЗаменитьВсеButton.TabIndex = 2;
            this.ЗаменитьВсеButton.Text = "Заменить все";
            this.ЗаменитьВсеButton.UseVisualStyleBackColor = true;
            this.ЗаменитьВсеButton.Click += new System.EventHandler(this.ЗаменитьВсеButton_Click);
            // 
            // ОтменаButton
            // 
            this.ОтменаButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ОтменаButton.Location = new System.Drawing.Point(175, 99);
            this.ОтменаButton.Name = "ОтменаButton";
            this.ОтменаButton.Size = new System.Drawing.Size(86, 23);
            this.ОтменаButton.TabIndex = 3;
            this.ОтменаButton.Text = "Отмена";
            this.ОтменаButton.UseVisualStyleBackColor = true;
            this.ОтменаButton.Click += new System.EventHandler(this.ОтменаButton_Click);
            // 
            // labelЧто
            // 
            this.labelЧто.AutoSize = true;
            this.labelЧто.Location = new System.Drawing.Point(12, 18);
            this.labelЧто.Name = "labelЧто";
            this.labelЧто.Size = new System.Drawing.Size(29, 13);
            this.labelЧто.TabIndex = 4;
            this.labelЧто.Text = "Что:";
            // 
            // labelЧем
            // 
            this.labelЧем.AutoSize = true;
            this.labelЧем.Location = new System.Drawing.Point(12, 43);
            this.labelЧем.Name = "labelЧем";
            this.labelЧем.Size = new System.Drawing.Size(32, 13);
            this.labelЧем.TabIndex = 5;
            this.labelЧем.Text = "Чем:";
            // 
            // ЧтоTextBox
            // 
            this.ЧтоTextBox.Location = new System.Drawing.Point(53, 15);
            this.ЧтоTextBox.Name = "ЧтоTextBox";
            this.ЧтоTextBox.Size = new System.Drawing.Size(112, 20);
            this.ЧтоTextBox.TabIndex = 6;
            this.ЧтоTextBox.TextChanged += new System.EventHandler(this.ЧтоTextBox_TextChanged);
            // 
            // ЧемTextBox
            // 
            this.ЧемTextBox.Location = new System.Drawing.Point(52, 41);
            this.ЧемTextBox.Name = "ЧемTextBox";
            this.ЧемTextBox.Size = new System.Drawing.Size(113, 20);
            this.ЧемTextBox.TabIndex = 7;
            // 
            // сУчетомРегистраCheckBox
            // 
            this.сУчетомРегистраCheckBox.AutoSize = true;
            this.сУчетомРегистраCheckBox.Location = new System.Drawing.Point(15, 76);
            this.сУчетомРегистраCheckBox.Name = "сУчетомРегистраCheckBox";
            this.сУчетомРегистраCheckBox.Size = new System.Drawing.Size(120, 17);
            this.сУчетомРегистраCheckBox.TabIndex = 8;
            this.сУчетомРегистраCheckBox.Text = "С учетом регистра";
            this.сУчетомРегистраCheckBox.UseVisualStyleBackColor = true;
            this.сУчетомРегистраCheckBox.CheckedChanged += new System.EventHandler(this.сУчетомРегистраCheckBox_CheckedChanged);
            // 
            // Заменить
            // 
            this.AcceptButton = this.НайтиДалееButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ОтменаButton;
            this.ClientSize = new System.Drawing.Size(273, 133);
            this.Controls.Add(this.сУчетомРегистраCheckBox);
            this.Controls.Add(this.ЧемTextBox);
            this.Controls.Add(this.ЧтоTextBox);
            this.Controls.Add(this.labelЧем);
            this.Controls.Add(this.labelЧто);
            this.Controls.Add(this.ОтменаButton);
            this.Controls.Add(this.ЗаменитьВсеButton);
            this.Controls.Add(this.ЗаменитьButton);
            this.Controls.Add(this.НайтиДалееButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Заменить";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Заменить";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Заменить_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button НайтиДалееButton;
        private System.Windows.Forms.Button ЗаменитьButton;
        private System.Windows.Forms.Button ЗаменитьВсеButton;
        private System.Windows.Forms.Button ОтменаButton;
        private System.Windows.Forms.Label labelЧто;
        private System.Windows.Forms.Label labelЧем;
        private System.Windows.Forms.TextBox ЧтоTextBox;
        private System.Windows.Forms.TextBox ЧемTextBox;
        private System.Windows.Forms.CheckBox сУчетомРегистраCheckBox;
    }
}
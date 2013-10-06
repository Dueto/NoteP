namespace Блокнот
{
    partial class Найти
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
            this.labelЧто = new System.Windows.Forms.Label();
            this.сУчетомРегистраCheckBox = new System.Windows.Forms.CheckBox();
            this.НайтиДалееButton = new System.Windows.Forms.Button();
            this.ОтменаButton = new System.Windows.Forms.Button();
            this.ЧтоTextBox = new System.Windows.Forms.TextBox();
            this.НаправлениеGroupBox = new System.Windows.Forms.GroupBox();
            this.ВнизRadioButton = new System.Windows.Forms.RadioButton();
            this.ВверхRadioButton = new System.Windows.Forms.RadioButton();
            this.НаправлениеGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelЧто
            // 
            this.labelЧто.AutoSize = true;
            this.labelЧто.Location = new System.Drawing.Point(12, 9);
            this.labelЧто.Name = "labelЧто";
            this.labelЧто.Size = new System.Drawing.Size(29, 13);
            this.labelЧто.TabIndex = 0;
            this.labelЧто.Text = "Что:";
            // 
            // сУчетомРегистраCheckBox
            // 
            this.сУчетомРегистраCheckBox.AutoSize = true;
            this.сУчетомРегистраCheckBox.Location = new System.Drawing.Point(15, 54);
            this.сУчетомРегистраCheckBox.Name = "сУчетомРегистраCheckBox";
            this.сУчетомРегистраCheckBox.Size = new System.Drawing.Size(120, 17);
            this.сУчетомРегистраCheckBox.TabIndex = 1;
            this.сУчетомРегистраCheckBox.Text = "С учетом регистра";
            this.сУчетомРегистраCheckBox.UseVisualStyleBackColor = true;
            this.сУчетомРегистраCheckBox.CheckedChanged += new System.EventHandler(this.сУчетомРегистраCheckBox_CheckedChanged);
            // 
            // НайтиДалееButton
            // 
            this.НайтиДалееButton.Location = new System.Drawing.Point(270, 9);
            this.НайтиДалееButton.Name = "НайтиДалееButton";
            this.НайтиДалееButton.Size = new System.Drawing.Size(85, 23);
            this.НайтиДалееButton.TabIndex = 2;
            this.НайтиДалееButton.Text = "Найти далее";
            this.НайтиДалееButton.UseVisualStyleBackColor = true;
            this.НайтиДалееButton.Click += new System.EventHandler(this.НайтиДалееButton_Click);
            // 
            // ОтменаButton
            // 
            this.ОтменаButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ОтменаButton.Location = new System.Drawing.Point(270, 38);
            this.ОтменаButton.Name = "ОтменаButton";
            this.ОтменаButton.Size = new System.Drawing.Size(85, 23);
            this.ОтменаButton.TabIndex = 3;
            this.ОтменаButton.Text = "Отмена";
            this.ОтменаButton.UseVisualStyleBackColor = true;
            this.ОтменаButton.Click += new System.EventHandler(this.ОтменаButton_Click);
            // 
            // ЧтоTextBox
            // 
            this.ЧтоTextBox.Location = new System.Drawing.Point(47, 9);
            this.ЧтоTextBox.Name = "ЧтоTextBox";
            this.ЧтоTextBox.Size = new System.Drawing.Size(217, 20);
            this.ЧтоTextBox.TabIndex = 4;
            this.ЧтоTextBox.TextChanged += new System.EventHandler(this.ЧтоTextBox_TextChanged);
            // 
            // НаправлениеGroupBox
            // 
            this.НаправлениеGroupBox.Controls.Add(this.ВнизRadioButton);
            this.НаправлениеGroupBox.Controls.Add(this.ВверхRadioButton);
            this.НаправлениеGroupBox.Location = new System.Drawing.Point(141, 35);
            this.НаправлениеGroupBox.Name = "НаправлениеGroupBox";
            this.НаправлениеGroupBox.Size = new System.Drawing.Size(123, 48);
            this.НаправлениеGroupBox.TabIndex = 5;
            this.НаправлениеGroupBox.TabStop = false;
            this.НаправлениеGroupBox.Text = "Направление";
            // 
            // ВнизRadioButton
            // 
            this.ВнизRadioButton.AutoSize = true;
            this.ВнизRadioButton.Checked = true;
            this.ВнизRadioButton.Location = new System.Drawing.Point(67, 19);
            this.ВнизRadioButton.Name = "ВнизRadioButton";
            this.ВнизRadioButton.Size = new System.Drawing.Size(50, 17);
            this.ВнизRadioButton.TabIndex = 1;
            this.ВнизRadioButton.TabStop = true;
            this.ВнизRadioButton.Text = "Вниз";
            this.ВнизRadioButton.UseVisualStyleBackColor = true;
            this.ВнизRadioButton.CheckedChanged += new System.EventHandler(this.ВнизRadioButton_CheckedChanged);
            // 
            // ВверхRadioButton
            // 
            this.ВверхRadioButton.AutoSize = true;
            this.ВверхRadioButton.Location = new System.Drawing.Point(6, 19);
            this.ВверхRadioButton.Name = "ВверхRadioButton";
            this.ВверхRadioButton.Size = new System.Drawing.Size(55, 17);
            this.ВверхRadioButton.TabIndex = 0;
            this.ВверхRadioButton.Text = "Вверх";
            this.ВверхRadioButton.UseVisualStyleBackColor = true;
            // 
            // Найти
            // 
            this.AcceptButton = this.НайтиДалееButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ОтменаButton;
            this.ClientSize = new System.Drawing.Size(364, 89);
            this.Controls.Add(this.НаправлениеGroupBox);
            this.Controls.Add(this.ЧтоTextBox);
            this.Controls.Add(this.ОтменаButton);
            this.Controls.Add(this.НайтиДалееButton);
            this.Controls.Add(this.сУчетомРегистраCheckBox);
            this.Controls.Add(this.labelЧто);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Найти";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Найти";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Найти_Load);
            this.НаправлениеGroupBox.ResumeLayout(false);
            this.НаправлениеGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelЧто;
        private System.Windows.Forms.CheckBox сУчетомРегистраCheckBox;
        private System.Windows.Forms.Button НайтиДалееButton;
        private System.Windows.Forms.Button ОтменаButton;
        private System.Windows.Forms.TextBox ЧтоTextBox;
        private System.Windows.Forms.GroupBox НаправлениеGroupBox;
        private System.Windows.Forms.RadioButton ВнизRadioButton;
        private System.Windows.Forms.RadioButton ВверхRadioButton;
    }
}
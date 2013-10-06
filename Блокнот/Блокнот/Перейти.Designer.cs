namespace Блокнот
{
    partial class Перейти
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
            this.components = new System.ComponentModel.Container();
            this.labelNumber = new System.Windows.Forms.Label();
            this.GoToTextBox = new System.Windows.Forms.TextBox();
            this.отменаButton = new System.Windows.Forms.Button();
            this.переходButton = new System.Windows.Forms.Button();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(13, 13);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(82, 13);
            this.labelNumber.TabIndex = 0;
            this.labelNumber.Text = "Номер строки:";
            // 
            // GoToTextBox
            // 
            this.GoToTextBox.Location = new System.Drawing.Point(13, 30);
            this.GoToTextBox.Name = "GoToTextBox";
            this.GoToTextBox.Size = new System.Drawing.Size(198, 20);
            this.GoToTextBox.TabIndex = 1;
            this.GoToTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GoToTextBox_KeyPress);
            // 
            // отменаButton
            // 
            this.отменаButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.отменаButton.Location = new System.Drawing.Point(136, 56);
            this.отменаButton.Name = "отменаButton";
            this.отменаButton.Size = new System.Drawing.Size(75, 23);
            this.отменаButton.TabIndex = 2;
            this.отменаButton.Text = "Отмена";
            this.отменаButton.UseVisualStyleBackColor = true;
            this.отменаButton.Click += new System.EventHandler(this.отменаButton_Click);
            // 
            // переходButton
            // 
            this.переходButton.Location = new System.Drawing.Point(55, 56);
            this.переходButton.Name = "переходButton";
            this.переходButton.Size = new System.Drawing.Size(75, 23);
            this.переходButton.TabIndex = 3;
            this.переходButton.Text = "Переход";
            this.переходButton.UseVisualStyleBackColor = true;
            this.переходButton.Click += new System.EventHandler(this.переходButton_Click);
            // 
            // ToolTip
            // 
            this.ToolTip.AutoPopDelay = 5000;
            this.ToolTip.InitialDelay = 500;
            this.ToolTip.IsBalloon = true;
            this.ToolTip.ReshowDelay = 500;
            this.ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.ToolTip.ToolTipTitle = "Недопустимый символ";
            this.ToolTip.UseFading = false;
            // 
            // Перейти
            // 
            this.AcceptButton = this.переходButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.отменаButton;
            this.ClientSize = new System.Drawing.Size(223, 93);
            this.Controls.Add(this.переходButton);
            this.Controls.Add(this.отменаButton);
            this.Controls.Add(this.GoToTextBox);
            this.Controls.Add(this.labelNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Перейти";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Перейти";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Перейти_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.TextBox GoToTextBox;
        private System.Windows.Forms.Button отменаButton;
        private System.Windows.Forms.Button переходButton;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}
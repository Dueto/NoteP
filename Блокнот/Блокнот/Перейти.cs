using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Блокнот
{
    public partial class Перейти : Form
    {
        bool Hided;

        public Перейти()
        {
            InitializeComponent();
        }

        private void отменаButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void переходButton_Click(object sender, EventArgs e)
        {
            int number = 0;
            int LinesNumber = ((MainForm)this.Owner).WorkSpace.Lines.Length;
            int symbolsNumber = 0;
            
            try
            {
                number = Convert.ToInt32(GoToTextBox.Text);

                if (number == 1)
                {
                    ((MainForm)this.Owner).WorkSpace.SelectionStart = symbolsNumber;
                    ((MainForm)this.Owner).WorkSpace.SelectionLength = 0;

                    this.Close();
                }
                else
                {
                    if ((number > 1) && (number <= LinesNumber))
                    {
                        number--;

                        for (int i = 0; i < number; i++)
                            symbolsNumber += ((MainForm)this.Owner).WorkSpace.Lines[i].Length + 1;

                        ((MainForm)this.Owner).WorkSpace.SelectionStart = symbolsNumber;
                        ((MainForm)this.Owner).WorkSpace.SelectionLength = 0;

                        this.Close();
                    }
                    else
                        MessageBox.Show("Неверно введен номер строки", "Переход на строку", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Неверно введен номер строки", "Переход на строку", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GoToTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (e.KeyChar == '\b'))
            {
                if (Hided == false)
                {
                    ToolTip.Hide(GoToTextBox);
                    Hided = true;
                }
                
                e.Handled = false;
            }
            else
            {
                if (Hided == true)
                {
                    Point p = GoToTextBox.GetPositionFromCharIndex(GoToTextBox.SelectionStart - 1);
                    
                    p.X -= 5;
                    p.Y -= 70;
                    
                    ToolTip.Show("Здесь можно ввести только цифры", GoToTextBox, p);
                    Hided = false;
                }

                e.Handled = true;
            }
        }

        private void Перейти_Load(object sender, EventArgs e)
        {
            CenterToParent();
            Hided = true;
        }
    }
}
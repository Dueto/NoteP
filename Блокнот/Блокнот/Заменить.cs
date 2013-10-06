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
    public partial class Заменить : Form
    {
        public Заменить()
        {
            InitializeComponent();
        }

        private void ОтменаButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void НайтиДалееButton_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Owner).stringToFind = ЧтоTextBox.Text;
            ((MainForm)this.Owner).stringToReplace = ЧемTextBox.Text;
            
            ((MainForm)this.Owner).FindNextString();
        }

        private void ЗаменитьButton_Click(object sender, EventArgs e)
        {
            string SelText;
            string FindText;
            
            ((MainForm)this.Owner).stringToFind = ЧтоTextBox.Text;
            ((MainForm)this.Owner).stringToReplace = ЧемTextBox.Text;

            if (сУчетомРегистраCheckBox.Checked == true)
            {
                SelText = ((MainForm)this.Owner).WorkSpace.SelectedText;
                FindText = ЧтоTextBox.Text;
            }
            else
            {
                SelText = ((MainForm)this.Owner).WorkSpace.SelectedText.ToLower();
                FindText = ЧтоTextBox.Text.ToLower();
            }

            if (SelText == FindText)
            {
                ((MainForm)this.Owner).WorkSpace.SelectedText = ЧемTextBox.Text;
                ((MainForm)this.Owner).FindNextString();
            }
            else
            {
                ((MainForm)this.Owner).FindNextString();
            }
        }

        private void ЗаменитьВсеButton_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Owner).stringToFind = ЧтоTextBox.Text;
            ((MainForm)this.Owner).stringToReplace = ЧемTextBox.Text;

            if (сУчетомРегистраCheckBox.Checked == true)
                ((MainForm)this.Owner).WorkSpace.Text = ((MainForm)this.Owner).WorkSpace.Text.Replace(ЧтоTextBox.Text, ЧемTextBox.Text);
            else
                ((MainForm)this.Owner).WorkSpace.Text = ((MainForm)this.Owner).WorkSpace.Text.ToLower().Replace(ЧтоTextBox.Text.ToLower(), ЧемTextBox.Text);
        }

        private void ЧтоTextBox_TextChanged(object sender, EventArgs e)
        {
            if ( ЧтоTextBox.Text.Length == 0 )
            {
                НайтиДалееButton.Enabled = false;
                ЗаменитьButton.Enabled = false;
                ЗаменитьВсеButton.Enabled = false;
            }
            else
            {
                НайтиДалееButton.Enabled = true;
                ЗаменитьButton.Enabled = true;
                ЗаменитьВсеButton.Enabled = true;
            }
        }

        private void Заменить_Load(object sender, EventArgs e)
        {
            CenterToParent();
            ЧтоTextBox.Text = ((MainForm)this.Owner).stringToFind;
            ЧемTextBox.Text = ((MainForm)this.Owner).stringToReplace;        
        
            if (ЧтоTextBox.Text.Length == 0)
            {
                НайтиДалееButton.Enabled = false;
                ЗаменитьButton.Enabled = false;
                ЗаменитьВсеButton.Enabled = false;
            }
            else
            {
                НайтиДалееButton.Enabled = true;
                ЗаменитьButton.Enabled = true;
                ЗаменитьВсеButton.Enabled = true;
            }

            сУчетомРегистраCheckBox.Checked = ((MainForm)this.Owner).register;
        }

        private void сУчетомРегистраCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ((MainForm)this.Owner).register = сУчетомРегистраCheckBox.Checked; 
        }
    }
}

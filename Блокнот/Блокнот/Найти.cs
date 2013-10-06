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
    public partial class Найти : Form
    {
        public Найти()
        {
            InitializeComponent();
        }

        private void Найти_Load(object sender, EventArgs e)
        {
            CenterToParent();
            ЧтоTextBox.Text = ((MainForm)this.Owner).stringToFind;
            
            if (((MainForm)this.Owner).FromUpToDown == true)
                ВнизRadioButton.Checked = true;
            else
                ВверхRadioButton.Checked = true;

            if (ЧтоTextBox.Text.Length == 0)
                НайтиДалееButton.Enabled = false;
            else
                НайтиДалееButton.Enabled = true;

            сУчетомРегистраCheckBox.Checked = ((MainForm)this.Owner).register;
        }

        private void ЧтоTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ЧтоTextBox.Text.Length == 0)
                НайтиДалееButton.Enabled = false;
            else
                НайтиДалееButton.Enabled = true;
        }

        private void ОтменаButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void НайтиДалееButton_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Owner).stringToFind = ЧтоTextBox.Text;

            if (ВнизRadioButton.Checked == true)
                ((MainForm)this.Owner).FindNextString();
            else
                ((MainForm)this.Owner).FindPrevString();
        }

        private void сУчетомРегистраCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ((MainForm)this.Owner).register = сУчетомРегистраCheckBox.Checked;
        }

        private void ВнизRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ((MainForm)this.Owner).FromUpToDown = ВнизRadioButton.Checked;
        }
    }
}

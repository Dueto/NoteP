using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace Блокнот
{
    public partial class MainForm : Form
    {
        string FilePath;// имя файла для сохранения
        string FileName;// имя файла
        string InitialText;//исходный текст
        string stringToPrint;// строка для печати
        public string stringToFind;// Поиск строки
        public string stringToReplace;// замена строки
        public bool register;// регистр
        public bool FromUpToDown;// с низу вверх
        const string English = "qwertyuiop[]asdfghjkl;'zxcvbnm,.";// Английская раскладка
        const string Russian = "йцукенгшщзхъфывапролджэячсмитьбю";// Русская раскладка

        public MainForm()
        {
            InitializeComponent();
        }

        //Функция сохранить как
        public bool SaveDialog()
        {
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter SaveFile = new StreamWriter(SaveFileDialog.FileName);
                SaveFile.WriteLine(WorkSpace.Text);
                SaveFile.Close();

                FilePath = SaveFileDialog.FileName;
                FileName = Path.GetFileName(SaveFileDialog.FileName);
                InitialText = WorkSpace.Text;

                this.Text = FileName + " - Блокнот";
                SaveFileDialog.FileName = FileName;

                return true;
            }
            else
                return false;
        }

        //Функция сохранить
        public bool Save()
        {
            if (FileName.CompareTo("Безымянный") != 0)
            {
                StreamWriter SaveFile = new StreamWriter(FilePath);
                SaveFile.WriteLine(WorkSpace.Text);
                SaveFile.Close();

                InitialText = WorkSpace.Text;

                return true;
            }
            else
                return false;
        }

        //Функция поиска следующего слова
        public void FindNextString()
        {
            int index;

            if (WorkSpace.SelectionStart + WorkSpace.SelectionLength < WorkSpace.Text.Length)
            {
                if (register == true)
                    index = WorkSpace.Text.IndexOf(stringToFind, WorkSpace.SelectionStart + WorkSpace.SelectionLength);
                else
                    index = WorkSpace.Text.ToLower().IndexOf(stringToFind.ToLower(), WorkSpace.SelectionStart + WorkSpace.SelectionLength);
            }
            else
                index = -1;

            if (index == -1)
                MessageBox.Show("Не удается найти " + "\"" + stringToFind + "\"", "Блокнот", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                WorkSpace.SelectionStart = index;
                WorkSpace.SelectionLength = stringToFind.Length;
            }
        }

        //Функция поискапредыдущего слова
        public void FindPrevString()
        {
            int index;

            if (WorkSpace.SelectionStart > 0)
            {
                if (register == true)
                    index = WorkSpace.Text.LastIndexOf(stringToFind, WorkSpace.SelectionStart - 1);
                else
                    index = WorkSpace.Text.ToLower().LastIndexOf(stringToFind.ToLower(), WorkSpace.SelectionStart - 1);
            }
            else
                index = -1;

            if (index == -1)
                MessageBox.Show("Не удается найти " + "\"" + stringToFind + "\"", "Блокнот", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                WorkSpace.SelectionStart = index;
                WorkSpace.SelectionLength = stringToFind.Length;
            }
        }

        //Функция вызова формы "Найти"
        public void ShowFindForm()
        {
            Найти SecondForm = new Найти();
            SecondForm.Owner = this;
            SecondForm.Show();
        }

        //Функция вызова формы "Заменить"
        public void ShowReplaceForm()
        {
            Заменить SecondForm = new Заменить();
            SecondForm.Owner = this;
            SecondForm.Show();
        }

        //Функция вызова формы "Перейти"
        public void ShowGoToDialog()
        {
            Перейти SecondForm = new Перейти();
            SecondForm.Owner = this;
            SecondForm.ShowDialog();
        }

        //Перед закрытием Формы
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (InitialText.CompareTo(WorkSpace.Text) != 0)
            {
                DialogResult result;
                result = MessageBox.Show("Сохранить изменения файле " + "\"" + FileName + "\"" + "?", "Блокнот", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    if (Save() == false)
                    {
                        if (SaveDialog() == false)
                            e.Cancel = true;
                    }
                }

                if (result == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }

        // При открытии формы
        private void MainForm_Load(object sender, EventArgs e)
        {
            stringToPrint = WorkSpace.Text;
            stringToFind = "";
            stringToReplace = "";
            register = false;
            FromUpToDown = true;
            InitialText = WorkSpace.Text;
            FilePath = "";
            FileName = "Безымянный";
            WorkSpace.Font = FontDialog.Font;
            WorkSpace.ForeColor = FontDialog.Color;
            CursorStatus.Text = "Строка: 1 | Столбец: 1";
        }
       

    }
}

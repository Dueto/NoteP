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

        //Файл -> Создать
        private void создатьMenuItem_Click(object sender, EventArgs e)
        {
            WorkSpace.Clear();

            FilePath = "";
            FileName = "Безымянный";
            InitialText = WorkSpace.Text;

            this.Text = FileName + " - Блокнот";
            SaveFileDialog.FileName = "*.txt";

            CursorStatus.Text = "Строка: 1 | Столбец: 1";
        }

        //Файл -> Открыть...
        private void открытьMenuItem_Click(object sender, EventArgs e)
        {
            bool cancel = false;

            if (InitialText.CompareTo(WorkSpace.Text) != 0)
            {
                DialogResult result;
                result = MessageBox.Show("Сохранить изменения файле " + "\"" + FileName + "\"" + "?", "Блокнот", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    if (Save() == false)
                    {
                        if (SaveDialog() == false)
                            cancel = true;
                    }
                }

                if (result == DialogResult.Cancel)
                    cancel = true;
            }

            if (cancel == false)
            {
                OpenFileDialog.FileName = "";

                if (OpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamReader OpenFile = new StreamReader(OpenFileDialog.FileName);
                    WorkSpace.Text = OpenFile.ReadToEnd();
                    OpenFile.Close();

                    FilePath = OpenFileDialog.FileName;
                    FileName = OpenFileDialog.SafeFileName;
                    InitialText = WorkSpace.Text;

                    this.Text = FileName + " - Блокнот";
                    SaveFileDialog.FileName = FileName;
                }
            }

            CursorStatus.Text = "Строка: 1 | Столбец: 1";
        }

        //Файл -> Сохранить
        private void сохранитьMenuItem_Click(object sender, EventArgs e)
        {
            if (Save() == false)
                SaveDialog();
        }

        //Файл -> Сохранить как...
        private void сохранитьКакMenuItem_Click(object sender, EventArgs e)
        {
            SaveDialog();
        }

        //Файл -> Параметры страницы
        private void параметрыСтраницыMenuItem_Click(object sender, EventArgs e)
        {
            PageSetupDialog.ShowDialog();
        }

        //Файл -> Предварительный просмотр
        private void предварительныйПросмотрMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument.DocumentName = FileName;
            stringToPrint = WorkSpace.Text;

            PrintPreviewDialog.ShowDialog();
        }

        //Файл -> Печать
        private void печатьMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument.DocumentName = FileName;
            stringToPrint = WorkSpace.Text;

            if (PrintDialog.ShowDialog() == DialogResult.OK)
                PrintDocument.Print();
        }

        //Файл -> Выход
        private void выходMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Правка -> Отменить
        private void отменитьMenuItem_Click(object sender, EventArgs e)
        {
            WorkSpace.Undo();
        }

        //Правка -> Вернуть
        private void вернутьMenuItem_Click(object sender, EventArgs e)
        {
            WorkSpace.Redo();
        }

        //Правка -> Вырезать
        private void вырезатьMenuItem_Click(object sender, EventArgs e)
        {
            WorkSpace.Cut();
        }

        //Правка -> Копировать
        private void копироватьMenuItem_Click(object sender, EventArgs e)
        {
            WorkSpace.Copy();
        }

        //Правка -> Вставить
        private void вставитьMenuItem_Click(object sender, EventArgs e)
        {
            WorkSpace.Paste();
        }

        //Правка -> Удалить
        private void удалитьMenuItem_Click(object sender, EventArgs e)
        {
            WorkSpace.SelectedText = "";
        }

        //Правка -> Найти
        private void найтиMenuItem_Click(object sender, EventArgs e)
        {
            ShowFindForm();
        }

        //Правка -> Найти далее
        private void найтиДалееMenuItem_Click(object sender, EventArgs e)
        {
            if (stringToFind.Length != 0)
            {
                if (FromUpToDown == true)
                    FindNextString();
                else
                    FindPrevString();
            }
            else
            {
                ShowFindForm();
            }
        }

        //Правка -> Заменить
        private void заменитьMenuItem_Click(object sender, EventArgs e)
        {
            ShowReplaceForm();
        }

        //Правка -> Перейти
        private void перейтиMenuItem_Click(object sender, EventArgs e)
        {
            ShowGoToDialog();
        }

        //Правка -> Выделить все
        private void выделитьВсеMenuItem_Click(object sender, EventArgs e)
        {
            WorkSpace.SelectAll();
        }

        //Правка -> Время и дата
        private void времяИДатаMenuItem_Click(object sender, EventArgs e)
        {
            string CurrentDateTime = DateTime.Now.ToLocalTime().ToString();
            int InitialSelectionStart = WorkSpace.SelectionStart;

            WorkSpace.Text = WorkSpace.Text.Insert(WorkSpace.SelectionStart, CurrentDateTime);
            WorkSpace.SelectionStart = InitialSelectionStart + CurrentDateTime.Length;
        }

        //Формат -> Перенос по словам
        private void переносПоСловамMenuItem_Click(object sender, EventArgs e)
        {
            WorkSpace.WordWrap = переносПоСловамMenuItem.Checked;
            переносПоСловамToolMenuButton.Checked = переносПоСловамMenuItem.Checked;
            перейтиMenuItem.Enabled = !переносПоСловамMenuItem.Checked;
        }

        //Перенос по словам
        private void переносПоСловамToolMenuButton_Click(object sender, EventArgs e)
        {
            WorkSpace.WordWrap = переносПоСловамToolMenuButton.Checked;
            переносПоСловамMenuItem.Checked = переносПоСловамToolMenuButton.Checked;
            перейтиMenuItem.Enabled = !переносПоСловамMenuItem.Checked;
        }

        //Формат -> Шрифт
        private void шрифтMenuItem_Click(object sender, EventArgs e)
        {
            if (FontDialog.ShowDialog() == DialogResult.OK)
            {
                WorkSpace.SelectionFont = FontDialog.Font;
                WorkSpace.SelectionColor = FontDialog.Color;
            }
        }

        //Формат -> Включить EN
        private void включитьENMenuItem_Click(object sender, EventArgs e)
        {
            включитьENToolMenuButton.Checked = включитьENMenuItem.Checked;
        }

        //Включить EN
        private void включитьENToolMenuButton_Click(object sender, EventArgs e)
        {
            включитьENMenuItem.Checked = включитьENToolMenuButton.Checked;
        }

        //Вид -> Строка состояния
        private void строкаСостоянияMenuItem_Click(object sender, EventArgs e)
        {
            Status.Visible = строкаСостоянияMenuItem.Checked;
            строкаСостоянияToolMenuButton.Checked = строкаСостоянияMenuItem.Checked;
        }

        //Строка состояния
        private void строкаСостоянияToolMenuButton_Click(object sender, EventArgs e)
        {
            Status.Visible = строкаСостоянияToolMenuButton.Checked;
            строкаСостоянияMenuItem.Checked = строкаСостоянияToolMenuButton.Checked;
        }

        //Спрафка -> О программе
        private void оПрограммеMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа разработана для сдачи ИДЗ по ТХИ :)", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // порядок чтения строки
        private void порядокЧтенияСправоНалевоContextMenuItem_Click(object sender, EventArgs e)
        {
            if (порядокЧтенияСправоНалевоContextMenuItem.Checked == true)
                WorkSpace.RightToLeft = RightToLeft.Yes;
            else
                WorkSpace.RightToLeft = RightToLeft.No;
        }

        //Распечатка
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            int charactersOnPage = 0;
            int linesPerPage = 0;

            e.Graphics.MeasureString(stringToPrint, FontDialog.Font,
                e.MarginBounds.Size, StringFormat.GenericTypographic,
                out charactersOnPage, out linesPerPage);

            e.Graphics.DrawString(stringToPrint, FontDialog.Font, Brushes.Black,
                e.MarginBounds, StringFormat.GenericTypographic);

            stringToPrint = stringToPrint.Substring(charactersOnPage);

            e.HasMorePages = (stringToPrint.Length > 0);

            if (!e.HasMorePages)
                stringToPrint = WorkSpace.Text;
        }


        private void WorkSpace_TextChanged(object sender, EventArgs e)
        {
            if (WorkSpace.Text.Length == 0)
            {
                найтиMenuItem.Enabled = false;
                найтиДалееMenuItem.Enabled = false;
            }
            else
            {
                найтиMenuItem.Enabled = true;
                найтиДалееMenuItem.Enabled = true;
            }
        }

        //работа со строкой
        private void WorkSpace_SelectionChanged(object sender, EventArgs e)
        {
            Point p = new Point();
            p.Y = WorkSpace.GetLineFromCharIndex(WorkSpace.SelectionStart) + 1;
            p.X = WorkSpace.SelectionStart - WorkSpace.GetFirstCharIndexOfCurrentLine() + 1;

            CursorStatus.Text = "Строка: " + p.Y + " | Столбец: " + p.X;

            if (WorkSpace.SelectionLength == 0)
            {
                вырезатьMenuItem.Enabled = false;
                вырезатьContextMenuItem.Enabled = false;
                копироватьMenuItem.Enabled = false;
                копироватьContextMenuItem.Enabled = false;
                удалитьMenuItem.Enabled = false;
                удалитьContextMenuItem.Enabled = false;
            }
            else
            {
                вырезатьMenuItem.Enabled = true;
                вырезатьContextMenuItem.Enabled = true;
                копироватьMenuItem.Enabled = true;
                копироватьContextMenuItem.Enabled = true;
                удалитьMenuItem.Enabled = true;
                удалитьContextMenuItem.Enabled = true;
            }
        }


        private void WorkSpace_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (включитьENMenuItem.Checked == false)
            {
                int index = English.IndexOf(e.KeyChar);

                if (index != -1)
                {
                    e.KeyChar = Russian[index];
                }
            }
        }
       

    }
}

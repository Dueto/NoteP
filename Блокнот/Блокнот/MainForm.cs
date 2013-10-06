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

       
       

    }
}

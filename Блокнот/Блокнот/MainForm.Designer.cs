namespace Блокнот
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.файлMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.параметрыСтраницыMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предварительныйПросмотрMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.выходMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.отменитьMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.вырезатьMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.найтиMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиДалееMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заменитьMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перейтиMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.выделитьВсеMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.времяИДатаMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форматMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.переносПоСловамMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.включитьENMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.строкаСостоянияMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WorkSpace = new System.Windows.Forms.RichTextBox();
            this.ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.отменитьContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.вырезатьContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.выделитьВсеContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.порядокЧтенияСправоНалевоContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.CursorStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolMenu = new System.Windows.Forms.ToolStrip();
            this.создатьToolMenuButton = new System.Windows.Forms.ToolStripButton();
            this.открытьToolMenuButton = new System.Windows.Forms.ToolStripButton();
            this.сохранитьToolMenuButton = new System.Windows.Forms.ToolStripButton();
            this.отменитьToolMenuButton = new System.Windows.Forms.ToolStripButton();
            this.вернутьToolMenuButton = new System.Windows.Forms.ToolStripButton();
            this.переносПоСловамToolMenuButton = new System.Windows.Forms.ToolStripButton();
            this.включитьENToolMenuButton = new System.Windows.Forms.ToolStripButton();
            this.строкаСостоянияToolMenuButton = new System.Windows.Forms.ToolStripButton();
            this.PrintDocument = new System.Drawing.Printing.PrintDocument();
            this.PageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.PrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.PrintDialog = new System.Windows.Forms.PrintDialog();
            this.FontDialog = new System.Windows.Forms.FontDialog();
            this.Menu.SuspendLayout();
            this.ContextMenu.SuspendLayout();
            this.Status.SuspendLayout();
            this.ToolMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.AutoSize = false;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлMenu,
            this.правкаMenu,
            this.форматMenu,
            this.видMenu,
            this.справкаMenu});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(537, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "StripMenu";
            // 
            // файлMenu
            // 
            this.файлMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьMenuItem,
            this.открытьMenuItem,
            this.сохранитьMenuItem,
            this.сохранитьКакMenuItem,
            this.toolStripSeparator1,
            this.параметрыСтраницыMenuItem,
            this.предварительныйПросмотрMenuItem,
            this.печатьMenuItem,
            this.toolStripSeparator2,
            this.выходMenuItem});
            this.файлMenu.Name = "файлMenu";
            this.файлMenu.Size = new System.Drawing.Size(48, 20);
            this.файлMenu.Text = "&Файл";
            // 
            // создатьMenuItem
            // 
            this.создатьMenuItem.Image = global::Блокнот.Properties.Resources.create;
            this.создатьMenuItem.Name = "создатьMenuItem";
            this.создатьMenuItem.ShortcutKeyDisplayString = "";
            this.создатьMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.создатьMenuItem.Size = new System.Drawing.Size(233, 22);
            this.создатьMenuItem.Text = "Созд&ать";
            this.создатьMenuItem.Click += new System.EventHandler(this.создатьMenuItem_Click);
            // 
            // открытьMenuItem
            // 
            this.открытьMenuItem.Image = global::Блокнот.Properties.Resources.open;
            this.открытьMenuItem.Name = "открытьMenuItem";
            this.открытьMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьMenuItem.Size = new System.Drawing.Size(233, 22);
            this.открытьMenuItem.Text = "&Открыть...";
            this.открытьMenuItem.Click += new System.EventHandler(this.открытьMenuItem_Click);
            // 
            // сохранитьMenuItem
            // 
            this.сохранитьMenuItem.Image = global::Блокнот.Properties.Resources.save;
            this.сохранитьMenuItem.Name = "сохранитьMenuItem";
            this.сохранитьMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьMenuItem.Size = new System.Drawing.Size(233, 22);
            this.сохранитьMenuItem.Text = "&Сохранить";
            this.сохранитьMenuItem.Click += new System.EventHandler(this.сохранитьMenuItem_Click);
            // 
            // сохранитьКакMenuItem
            // 
            this.сохранитьКакMenuItem.Image = global::Блокнот.Properties.Resources.save_as;
            this.сохранитьКакMenuItem.Name = "сохранитьКакMenuItem";
            this.сохранитьКакMenuItem.Size = new System.Drawing.Size(233, 22);
            this.сохранитьКакMenuItem.Text = "Сохранить &как...";
            this.сохранитьКакMenuItem.Click += new System.EventHandler(this.сохранитьКакMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(230, 6);
            // 
            // параметрыСтраницыMenuItem
            // 
            this.параметрыСтраницыMenuItem.Image = global::Блокнот.Properties.Resources.parameters;
            this.параметрыСтраницыMenuItem.Name = "параметрыСтраницыMenuItem";
            this.параметрыСтраницыMenuItem.Size = new System.Drawing.Size(233, 22);
            this.параметрыСтраницыMenuItem.Text = "Пара&метры страницы...";
            this.параметрыСтраницыMenuItem.Click += new System.EventHandler(this.параметрыСтраницыMenuItem_Click);
            // 
            // предварительныйПросмотрMenuItem
            // 
            this.предварительныйПросмотрMenuItem.Image = global::Блокнот.Properties.Resources.preview;
            this.предварительныйПросмотрMenuItem.Name = "предварительныйПросмотрMenuItem";
            this.предварительныйПросмотрMenuItem.Size = new System.Drawing.Size(233, 22);
            this.предварительныйПросмотрMenuItem.Text = "П&редварительный просмотр";
            this.предварительныйПросмотрMenuItem.Click += new System.EventHandler(this.предварительныйПросмотрMenuItem_Click);
            // 
            // печатьMenuItem
            // 
            this.печатьMenuItem.Image = global::Блокнот.Properties.Resources.print;
            this.печатьMenuItem.Name = "печатьMenuItem";
            this.печатьMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.печатьMenuItem.Size = new System.Drawing.Size(233, 22);
            this.печатьMenuItem.Text = "&Печать...";
            this.печатьMenuItem.Click += new System.EventHandler(this.печатьMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(230, 6);
            // 
            // выходMenuItem
            // 
            this.выходMenuItem.Image = global::Блокнот.Properties.Resources.quit;
            this.выходMenuItem.Name = "выходMenuItem";
            this.выходMenuItem.Size = new System.Drawing.Size(233, 22);
            this.выходMenuItem.Text = "В&ыход";
            this.выходMenuItem.Click += new System.EventHandler(this.выходMenuItem_Click);
            // 
            // правкаMenu
            // 
            this.правкаMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отменитьMenuItem,
            this.вернутьMenuItem,
            this.toolStripSeparator3,
            this.вырезатьMenuItem,
            this.копироватьMenuItem,
            this.вставитьMenuItem,
            this.удалитьMenuItem,
            this.toolStripSeparator4,
            this.найтиMenuItem,
            this.найтиДалееMenuItem,
            this.заменитьMenuItem,
            this.перейтиMenuItem,
            this.toolStripSeparator5,
            this.выделитьВсеMenuItem,
            this.времяИДатаMenuItem});
            this.правкаMenu.Name = "правкаMenu";
            this.правкаMenu.Size = new System.Drawing.Size(59, 20);
            this.правкаMenu.Text = "&Правка";
            // 
            // отменитьMenuItem
            // 
            this.отменитьMenuItem.Image = global::Блокнот.Properties.Resources.undo;
            this.отменитьMenuItem.Name = "отменитьMenuItem";
            this.отменитьMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.отменитьMenuItem.Size = new System.Drawing.Size(190, 22);
            this.отменитьMenuItem.Text = "&Отменить";
            this.отменитьMenuItem.Click += new System.EventHandler(this.отменитьMenuItem_Click);
            // 
            // вернутьMenuItem
            // 
            this.вернутьMenuItem.Image = global::Блокнот.Properties.Resources.redo;
            this.вернутьMenuItem.Name = "вернутьMenuItem";
            this.вернутьMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.вернутьMenuItem.Size = new System.Drawing.Size(190, 22);
            this.вернутьMenuItem.Text = "В&ернуть";
            this.вернутьMenuItem.Click += new System.EventHandler(this.вернутьMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(187, 6);
            // 
            // вырезатьMenuItem
            // 
            this.вырезатьMenuItem.Enabled = false;
            this.вырезатьMenuItem.Image = global::Блокнот.Properties.Resources.cut;
            this.вырезатьMenuItem.Name = "вырезатьMenuItem";
            this.вырезатьMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.вырезатьMenuItem.Size = new System.Drawing.Size(190, 22);
            this.вырезатьMenuItem.Text = "&Вырезать";
            this.вырезатьMenuItem.Click += new System.EventHandler(this.вырезатьMenuItem_Click);
            // 
            // копироватьMenuItem
            // 
            this.копироватьMenuItem.Enabled = false;
            this.копироватьMenuItem.Image = global::Блокнот.Properties.Resources.copy;
            this.копироватьMenuItem.Name = "копироватьMenuItem";
            this.копироватьMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.копироватьMenuItem.Size = new System.Drawing.Size(190, 22);
            this.копироватьMenuItem.Text = "&Копировать";
            this.копироватьMenuItem.Click += new System.EventHandler(this.копироватьMenuItem_Click);
            // 
            // вставитьMenuItem
            // 
            this.вставитьMenuItem.Image = global::Блокнот.Properties.Resources.paste;
            this.вставитьMenuItem.Name = "вставитьMenuItem";
            this.вставитьMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.вставитьMenuItem.Size = new System.Drawing.Size(190, 22);
            this.вставитьMenuItem.Text = "Вст&авить";
            this.вставитьMenuItem.Click += new System.EventHandler(this.вставитьMenuItem_Click);
            // 
            // удалитьMenuItem
            // 
            this.удалитьMenuItem.Enabled = false;
            this.удалитьMenuItem.Image = global::Блокнот.Properties.Resources.delete;
            this.удалитьMenuItem.Name = "удалитьMenuItem";
            this.удалитьMenuItem.ShortcutKeyDisplayString = "Del";
            this.удалитьMenuItem.Size = new System.Drawing.Size(190, 22);
            this.удалитьMenuItem.Text = "&Удалить";
            this.удалитьMenuItem.Click += new System.EventHandler(this.удалитьMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(187, 6);
            // 
            // найтиMenuItem
            // 
            this.найтиMenuItem.Enabled = false;
            this.найтиMenuItem.Image = global::Блокнот.Properties.Resources.find;
            this.найтиMenuItem.Name = "найтиMenuItem";
            this.найтиMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.найтиMenuItem.Size = new System.Drawing.Size(190, 22);
            this.найтиMenuItem.Text = "&Найти...";
            this.найтиMenuItem.Click += new System.EventHandler(this.найтиMenuItem_Click);
            // 
            // найтиДалееMenuItem
            // 
            this.найтиДалееMenuItem.Enabled = false;
            this.найтиДалееMenuItem.Image = global::Блокнот.Properties.Resources.find_next;
            this.найтиДалееMenuItem.Name = "найтиДалееMenuItem";
            this.найтиДалееMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.найтиДалееMenuItem.Size = new System.Drawing.Size(190, 22);
            this.найтиДалееMenuItem.Text = "Найти &далее";
            this.найтиДалееMenuItem.Click += new System.EventHandler(this.найтиДалееMenuItem_Click);
            // 
            // заменитьMenuItem
            // 
            this.заменитьMenuItem.Image = global::Блокнот.Properties.Resources.replace;
            this.заменитьMenuItem.Name = "заменитьMenuItem";
            this.заменитьMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.заменитьMenuItem.Size = new System.Drawing.Size(190, 22);
            this.заменитьMenuItem.Text = "&Заменить...";
            this.заменитьMenuItem.Click += new System.EventHandler(this.заменитьMenuItem_Click);
            // 
            // перейтиMenuItem
            // 
            this.перейтиMenuItem.Image = global::Блокнот.Properties.Resources.go_to;
            this.перейтиMenuItem.Name = "перейтиMenuItem";
            this.перейтиMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.перейтиMenuItem.Size = new System.Drawing.Size(190, 22);
            this.перейтиMenuItem.Text = "Перей&ти...";
            this.перейтиMenuItem.Click += new System.EventHandler(this.перейтиMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(187, 6);
            // 
            // выделитьВсеMenuItem
            // 
            this.выделитьВсеMenuItem.Image = global::Блокнот.Properties.Resources.select_all;
            this.выделитьВсеMenuItem.Name = "выделитьВсеMenuItem";
            this.выделитьВсеMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.выделитьВсеMenuItem.Size = new System.Drawing.Size(190, 22);
            this.выделитьВсеMenuItem.Text = "Выделить в&се";
            this.выделитьВсеMenuItem.Click += new System.EventHandler(this.выделитьВсеMenuItem_Click);
            // 
            // времяИДатаMenuItem
            // 
            this.времяИДатаMenuItem.Image = global::Блокнот.Properties.Resources.date_time;
            this.времяИДатаMenuItem.Name = "времяИДатаMenuItem";
            this.времяИДатаMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.времяИДатаMenuItem.Size = new System.Drawing.Size(190, 22);
            this.времяИДатаMenuItem.Text = "Врем&я и дата";
            this.времяИДатаMenuItem.Click += new System.EventHandler(this.времяИДатаMenuItem_Click);
            // 
            // форматMenu
            // 
            this.форматMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.переносПоСловамMenuItem,
            this.шрифтMenuItem,
            this.включитьENMenuItem});
            this.форматMenu.Name = "форматMenu";
            this.форматMenu.Size = new System.Drawing.Size(62, 20);
            this.форматMenu.Text = "Фор&мат";
            // 
            // переносПоСловамMenuItem
            // 
            this.переносПоСловамMenuItem.CheckOnClick = true;
            this.переносПоСловамMenuItem.Image = global::Блокнот.Properties.Resources.wordwrap;
            this.переносПоСловамMenuItem.Name = "переносПоСловамMenuItem";
            this.переносПоСловамMenuItem.Size = new System.Drawing.Size(183, 22);
            this.переносПоСловамMenuItem.Text = "&Перенос по словам";
            this.переносПоСловамMenuItem.Click += new System.EventHandler(this.переносПоСловамMenuItem_Click);
            // 
            // шрифтMenuItem
            // 
            this.шрифтMenuItem.Image = global::Блокнот.Properties.Resources.font;
            this.шрифтMenuItem.Name = "шрифтMenuItem";
            this.шрифтMenuItem.Size = new System.Drawing.Size(183, 22);
            this.шрифтMenuItem.Text = "&Шрифт...";
            this.шрифтMenuItem.Click += new System.EventHandler(this.шрифтMenuItem_Click);
            // 
            // включитьENMenuItem
            // 
            this.включитьENMenuItem.CheckOnClick = true;
            this.включитьENMenuItem.Image = global::Блокнот.Properties.Resources.ENG;
            this.включитьENMenuItem.Name = "включитьENMenuItem";
            this.включитьENMenuItem.Size = new System.Drawing.Size(183, 22);
            this.включитьENMenuItem.Text = "&Включить EN";
            this.включитьENMenuItem.Click += new System.EventHandler(this.включитьENMenuItem_Click);
            // 
            // видMenu
            // 
            this.видMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.строкаСостоянияMenuItem});
            this.видMenu.Name = "видMenu";
            this.видMenu.Size = new System.Drawing.Size(39, 20);
            this.видMenu.Text = "&Вид";
            // 
            // строкаСостоянияMenuItem
            // 
            this.строкаСостоянияMenuItem.CheckOnClick = true;
            this.строкаСостоянияMenuItem.Image = global::Блокнот.Properties.Resources.status;
            this.строкаСостоянияMenuItem.Name = "строкаСостоянияMenuItem";
            this.строкаСостоянияMenuItem.Size = new System.Drawing.Size(173, 22);
            this.строкаСостоянияMenuItem.Text = "&Строка состояния";
            this.строкаСостоянияMenuItem.Click += new System.EventHandler(this.строкаСостоянияMenuItem_Click);
            // 
            // справкаMenu
            // 
            this.справкаMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеMenuItem});
            this.справкаMenu.Name = "справкаMenu";
            this.справкаMenu.Size = new System.Drawing.Size(65, 20);
            this.справкаMenu.Text = "&Справка";
            // 
            // оПрограммеMenuItem
            // 
            this.оПрограммеMenuItem.Image = global::Блокнот.Properties.Resources.info;
            this.оПрограммеMenuItem.Name = "оПрограммеMenuItem";
            this.оПрограммеMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеMenuItem.Text = "&О программе";
            this.оПрограммеMenuItem.Click += new System.EventHandler(this.оПрограммеMenuItem_Click);
            // 
            // WorkSpace
            // 
            this.WorkSpace.ContextMenuStrip = this.ContextMenu;
            this.WorkSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkSpace.HideSelection = false;
            this.WorkSpace.Location = new System.Drawing.Point(0, 49);
            this.WorkSpace.Name = "WorkSpace";
            this.WorkSpace.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.WorkSpace.Size = new System.Drawing.Size(537, 271);
            this.WorkSpace.TabIndex = 1;
            this.WorkSpace.TabStop = false;
            this.WorkSpace.Text = "";
            this.WorkSpace.WordWrap = false;
            this.WorkSpace.SelectionChanged += new System.EventHandler(this.WorkSpace_SelectionChanged);
            this.WorkSpace.TextChanged += new System.EventHandler(this.WorkSpace_TextChanged);
            this.WorkSpace.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WorkSpace_KeyPress);
            // 
            // ContextMenu
            // 
            this.ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отменитьContextMenuItem,
            this.вернутьContextMenuItem,
            this.toolStripSeparator6,
            this.вырезатьContextMenuItem,
            this.копироватьContextMenuItem,
            this.вставитьContextMenuItem,
            this.удалитьContextMenuItem,
            this.toolStripSeparator7,
            this.выделитьВсеContextMenuItem,
            this.toolStripSeparator8,
            this.порядокЧтенияСправоНалевоContextMenuItem});
            this.ContextMenu.Name = "StripContextMenu";
            this.ContextMenu.Size = new System.Drawing.Size(250, 198);
            this.ContextMenu.Text = "StripContextMenu";
            // 
            // отменитьContextMenuItem
            // 
            this.отменитьContextMenuItem.Name = "отменитьContextMenuItem";
            this.отменитьContextMenuItem.Size = new System.Drawing.Size(249, 22);
            this.отменитьContextMenuItem.Text = "Отменить";
            this.отменитьContextMenuItem.Click += new System.EventHandler(this.отменитьMenuItem_Click);
            // 
            // вернутьContextMenuItem
            // 
            this.вернутьContextMenuItem.Name = "вернутьContextMenuItem";
            this.вернутьContextMenuItem.Size = new System.Drawing.Size(249, 22);
            this.вернутьContextMenuItem.Text = "Вернуть";
            this.вернутьContextMenuItem.Click += new System.EventHandler(this.вернутьMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(246, 6);
            // 
            // вырезатьContextMenuItem
            // 
            this.вырезатьContextMenuItem.Enabled = false;
            this.вырезатьContextMenuItem.Name = "вырезатьContextMenuItem";
            this.вырезатьContextMenuItem.Size = new System.Drawing.Size(249, 22);
            this.вырезатьContextMenuItem.Text = "Вырезать";
            this.вырезатьContextMenuItem.Click += new System.EventHandler(this.вырезатьMenuItem_Click);
            // 
            // копироватьContextMenuItem
            // 
            this.копироватьContextMenuItem.Enabled = false;
            this.копироватьContextMenuItem.Name = "копироватьContextMenuItem";
            this.копироватьContextMenuItem.Size = new System.Drawing.Size(249, 22);
            this.копироватьContextMenuItem.Text = "Копировать";
            this.копироватьContextMenuItem.Click += new System.EventHandler(this.копироватьMenuItem_Click);
            // 
            // вставитьContextMenuItem
            // 
            this.вставитьContextMenuItem.Name = "вставитьContextMenuItem";
            this.вставитьContextMenuItem.Size = new System.Drawing.Size(249, 22);
            this.вставитьContextMenuItem.Text = "Вставить";
            this.вставитьContextMenuItem.Click += new System.EventHandler(this.вставитьMenuItem_Click);
            // 
            // удалитьContextMenuItem
            // 
            this.удалитьContextMenuItem.Enabled = false;
            this.удалитьContextMenuItem.Name = "удалитьContextMenuItem";
            this.удалитьContextMenuItem.Size = new System.Drawing.Size(249, 22);
            this.удалитьContextMenuItem.Text = "Удалить";
            this.удалитьContextMenuItem.Click += new System.EventHandler(this.удалитьMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(246, 6);
            // 
            // выделитьВсеContextMenuItem
            // 
            this.выделитьВсеContextMenuItem.Name = "выделитьВсеContextMenuItem";
            this.выделитьВсеContextMenuItem.Size = new System.Drawing.Size(249, 22);
            this.выделитьВсеContextMenuItem.Text = "Выделить все";
            this.выделитьВсеContextMenuItem.Click += new System.EventHandler(this.выделитьВсеMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(246, 6);
            // 
            // порядокЧтенияСправоНалевоContextMenuItem
            // 
            this.порядокЧтенияСправоНалевоContextMenuItem.CheckOnClick = true;
            this.порядокЧтенияСправоНалевоContextMenuItem.Name = "порядокЧтенияСправоНалевоContextMenuItem";
            this.порядокЧтенияСправоНалевоContextMenuItem.Size = new System.Drawing.Size(249, 22);
            this.порядокЧтенияСправоНалевоContextMenuItem.Text = "Порядок чтения: справа налево";
            this.порядокЧтенияСправоНалевоContextMenuItem.Click += new System.EventHandler(this.порядокЧтенияСправоНалевоContextMenuItem_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.DefaultExt = "txt";
            this.OpenFileDialog.Filter = "Текстовые документы|*.txt|Все файлы|*.*";
            this.OpenFileDialog.InitialDirectory = "C:\\Users\\Иван\\Desktop\\";
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.DefaultExt = "txt";
            this.SaveFileDialog.FileName = "*.txt";
            this.SaveFileDialog.Filter = "Текстовые документы|*.txt|Все файлы|*.*";
            this.SaveFileDialog.InitialDirectory = "C:\\Users\\Иван\\Desktop\\";
            // 
            // Status
            // 
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CursorStatus});
            this.Status.Location = new System.Drawing.Point(0, 298);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(537, 22);
            this.Status.TabIndex = 2;
            this.Status.Text = "StripStatus";
            this.Status.Visible = false;
            // 
            // CursorStatus
            // 
            this.CursorStatus.Name = "CursorStatus";
            this.CursorStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // ToolMenu
            // 
            this.ToolMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolMenuButton,
            this.открытьToolMenuButton,
            this.сохранитьToolMenuButton,
            this.отменитьToolMenuButton,
            this.вернутьToolMenuButton,
            this.переносПоСловамToolMenuButton,
            this.включитьENToolMenuButton,
            this.строкаСостоянияToolMenuButton});
            this.ToolMenu.Location = new System.Drawing.Point(0, 24);
            this.ToolMenu.Name = "ToolMenu";
            this.ToolMenu.Size = new System.Drawing.Size(537, 25);
            this.ToolMenu.TabIndex = 3;
            this.ToolMenu.Text = "StripTool";
            // 
            // создатьToolMenuButton
            // 
            this.создатьToolMenuButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.создатьToolMenuButton.Image = global::Блокнот.Properties.Resources.create;
            this.создатьToolMenuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.создатьToolMenuButton.Name = "создатьToolMenuButton";
            this.создатьToolMenuButton.Size = new System.Drawing.Size(23, 22);
            this.создатьToolMenuButton.Text = "Создать";
            this.создатьToolMenuButton.Click += new System.EventHandler(this.создатьMenuItem_Click);
            // 
            // открытьToolMenuButton
            // 
            this.открытьToolMenuButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.открытьToolMenuButton.Image = global::Блокнот.Properties.Resources.open;
            this.открытьToolMenuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.открытьToolMenuButton.Name = "открытьToolMenuButton";
            this.открытьToolMenuButton.Size = new System.Drawing.Size(23, 22);
            this.открытьToolMenuButton.Text = "Открыть...";
            this.открытьToolMenuButton.Click += new System.EventHandler(this.открытьMenuItem_Click);
            // 
            // сохранитьToolMenuButton
            // 
            this.сохранитьToolMenuButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.сохранитьToolMenuButton.Image = global::Блокнот.Properties.Resources.save;
            this.сохранитьToolMenuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.сохранитьToolMenuButton.Name = "сохранитьToolMenuButton";
            this.сохранитьToolMenuButton.Size = new System.Drawing.Size(23, 22);
            this.сохранитьToolMenuButton.Text = "Сохранить";
            this.сохранитьToolMenuButton.Click += new System.EventHandler(this.сохранитьMenuItem_Click);
            // 
            // отменитьToolMenuButton
            // 
            this.отменитьToolMenuButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.отменитьToolMenuButton.Image = global::Блокнот.Properties.Resources.undo;
            this.отменитьToolMenuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.отменитьToolMenuButton.Name = "отменитьToolMenuButton";
            this.отменитьToolMenuButton.Size = new System.Drawing.Size(23, 22);
            this.отменитьToolMenuButton.Text = "Отменить";
            this.отменитьToolMenuButton.Click += new System.EventHandler(this.отменитьMenuItem_Click);
            // 
            // вернутьToolMenuButton
            // 
            this.вернутьToolMenuButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.вернутьToolMenuButton.Image = global::Блокнот.Properties.Resources.redo;
            this.вернутьToolMenuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.вернутьToolMenuButton.Name = "вернутьToolMenuButton";
            this.вернутьToolMenuButton.Size = new System.Drawing.Size(23, 22);
            this.вернутьToolMenuButton.Text = "Вернуть";
            this.вернутьToolMenuButton.Click += new System.EventHandler(this.вернутьMenuItem_Click);
            // 
            // переносПоСловамToolMenuButton
            // 
            this.переносПоСловамToolMenuButton.CheckOnClick = true;
            this.переносПоСловамToolMenuButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.переносПоСловамToolMenuButton.Image = global::Блокнот.Properties.Resources.wordwrap;
            this.переносПоСловамToolMenuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.переносПоСловамToolMenuButton.Name = "переносПоСловамToolMenuButton";
            this.переносПоСловамToolMenuButton.Size = new System.Drawing.Size(23, 22);
            this.переносПоСловамToolMenuButton.Text = "Перенос по словам";
            this.переносПоСловамToolMenuButton.Click += new System.EventHandler(this.переносПоСловамToolMenuButton_Click);
            // 
            // включитьENToolMenuButton
            // 
            this.включитьENToolMenuButton.CheckOnClick = true;
            this.включитьENToolMenuButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.включитьENToolMenuButton.Image = global::Блокнот.Properties.Resources.ENG;
            this.включитьENToolMenuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.включитьENToolMenuButton.Name = "включитьENToolMenuButton";
            this.включитьENToolMenuButton.Size = new System.Drawing.Size(23, 22);
            this.включитьENToolMenuButton.Text = "Включить EN";
            this.включитьENToolMenuButton.Click += new System.EventHandler(this.включитьENToolMenuButton_Click);
            // 
            // строкаСостоянияToolMenuButton
            // 
            this.строкаСостоянияToolMenuButton.CheckOnClick = true;
            this.строкаСостоянияToolMenuButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.строкаСостоянияToolMenuButton.Image = global::Блокнот.Properties.Resources.status;
            this.строкаСостоянияToolMenuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.строкаСостоянияToolMenuButton.Name = "строкаСостоянияToolMenuButton";
            this.строкаСостоянияToolMenuButton.Size = new System.Drawing.Size(23, 22);
            this.строкаСостоянияToolMenuButton.Text = "Строка состояния";
            this.строкаСостоянияToolMenuButton.Click += new System.EventHandler(this.строкаСостоянияToolMenuButton_Click);
            // 
            // PrintDocument
            // 
            this.PrintDocument.DocumentName = "Безымянный";
            this.PrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument_PrintPage);
            // 
            // PageSetupDialog
            // 
            this.PageSetupDialog.AllowPrinter = false;
            this.PageSetupDialog.Document = this.PrintDocument;
            this.PageSetupDialog.EnableMetric = true;
            this.PageSetupDialog.ShowNetwork = false;
            // 
            // PrintPreviewDialog
            // 
            this.PrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.PrintPreviewDialog.Document = this.PrintDocument;
            this.PrintPreviewDialog.Enabled = true;
            this.PrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintPreviewDialog.Icon")));
            this.PrintPreviewDialog.Name = "PrintPreviewDialog";
            this.PrintPreviewDialog.Visible = false;
            // 
            // PrintDialog
            // 
            this.PrintDialog.AllowCurrentPage = true;
            this.PrintDialog.AllowSelection = true;
            this.PrintDialog.AllowSomePages = true;
            this.PrintDialog.Document = this.PrintDocument;
            this.PrintDialog.ShowNetwork = false;
            this.PrintDialog.UseEXDialog = true;
            // 
            // FontDialog
            // 
            this.FontDialog.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FontDialog.ShowColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 320);
            this.Controls.Add(this.WorkSpace);
            this.Controls.Add(this.ToolMenu);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Status);
            this.MainMenuStrip = this.Menu;
            this.Name = "MainForm";
            this.Text = "Безымянный - Блокнот";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ContextMenu.ResumeLayout(false);
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.ToolMenu.ResumeLayout(false);
            this.ToolMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem файлMenu;
        private System.Windows.Forms.ToolStripMenuItem создатьMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параметрыСтраницыMenuItem;
        private System.Windows.Forms.ToolStripMenuItem печатьMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаMenu;
        private System.Windows.Forms.ToolStripMenuItem отменитьMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вырезатьMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форматMenu;
        private System.Windows.Forms.ToolStripMenuItem видMenu;
        private System.Windows.Forms.ToolStripMenuItem справкаMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem вставитьMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиДалееMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заменитьMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перейтиMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выделитьВсеMenuItem;
        private System.Windows.Forms.ToolStripMenuItem времяИДатаMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem вернутьMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переносПоСловамMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem шрифтMenuItem;
        private System.Windows.Forms.ToolStripMenuItem строкаСостоянияMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеMenuItem;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.ToolStrip ToolMenu;
        private System.Windows.Forms.ContextMenuStrip ContextMenu;
        private System.Windows.Forms.ToolStripMenuItem включитьENMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменитьContextMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem вырезатьContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьContextMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem выделитьВсеContextMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem порядокЧтенияСправоНалевоContextMenuItem;
        private System.Windows.Forms.ToolStripButton открытьToolMenuButton;
        private System.Windows.Forms.ToolStripButton создатьToolMenuButton;
        private System.Windows.Forms.ToolStripButton сохранитьToolMenuButton;
        private System.Windows.Forms.ToolStripButton отменитьToolMenuButton;
        private System.Windows.Forms.ToolStripButton вернутьToolMenuButton;
        private System.Windows.Forms.ToolStripButton включитьENToolMenuButton;
        private System.Windows.Forms.ToolStripButton переносПоСловамToolMenuButton;
        private System.Windows.Forms.ToolStripButton строкаСостоянияToolMenuButton;
        private System.Windows.Forms.ToolStripMenuItem вернутьContextMenuItem;
        private System.Drawing.Printing.PrintDocument PrintDocument;
        private System.Windows.Forms.PageSetupDialog PageSetupDialog;
        private System.Windows.Forms.ToolStripMenuItem предварительныйПросмотрMenuItem;
        private System.Windows.Forms.PrintPreviewDialog PrintPreviewDialog;
        private System.Windows.Forms.PrintDialog PrintDialog;
        private System.Windows.Forms.FontDialog FontDialog;
        public System.Windows.Forms.RichTextBox WorkSpace;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripStatusLabel CursorStatus;

    }
}


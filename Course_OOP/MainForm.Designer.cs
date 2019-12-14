namespace Course_OOP
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PosterDataGridView = new System.Windows.Forms.DataGridView();
            this.PosterBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSaerchNameTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.SearchFreeTKTtoolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.FreeTKTtoolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.моиЗаказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникПользователейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникЖанровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникАвторовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникКатегорийБилетовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникПьесToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникАфишToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EnterButton = new System.Windows.Forms.Button();
            this.RegistrButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PosterDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PosterBindingNavigator)).BeginInit();
            this.PosterBindingNavigator.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1460, 592);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(695, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 7;
            this.label2.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ExitButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.96272F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.03728F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1460, 592);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 2);
            this.panel2.Controls.Add(this.PosterDataGridView);
            this.panel2.Controls.Add(this.PosterBindingNavigator);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 139);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1454, 410);
            this.panel2.TabIndex = 0;
            // 
            // PosterDataGridView
            // 
            this.PosterDataGridView.AllowUserToAddRows = false;
            this.PosterDataGridView.AllowUserToDeleteRows = false;
            this.PosterDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.PosterDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.PosterDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.PosterDataGridView.ColumnHeadersHeight = 29;
            this.PosterDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PosterDataGridView.Location = new System.Drawing.Point(0, 31);
            this.PosterDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PosterDataGridView.MultiSelect = false;
            this.PosterDataGridView.Name = "PosterDataGridView";
            this.PosterDataGridView.ReadOnly = true;
            this.PosterDataGridView.RowHeadersWidth = 51;
            this.PosterDataGridView.RowTemplate.Height = 24;
            this.PosterDataGridView.Size = new System.Drawing.Size(1454, 379);
            this.PosterDataGridView.TabIndex = 0;
            this.PosterDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PosterDataGridView_CellClick);
            this.PosterDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PosterDataGridView_CellContentClick);
            // 
            // PosterBindingNavigator
            // 
            this.PosterBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.PosterBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.PosterBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.PosterBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.PosterBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripLabel1,
            this.toolStripSaerchNameTextBox,
            this.toolStripLabel2,
            this.SearchFreeTKTtoolStripComboBox,
            this.toolStripLabel3,
            this.toolStripLabel4,
            this.FreeTKTtoolStripTextBox});
            this.PosterBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.PosterBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.PosterBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.PosterBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.PosterBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.PosterBindingNavigator.Name = "PosterBindingNavigator";
            this.PosterBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.PosterBindingNavigator.Size = new System.Drawing.Size(1454, 31);
            this.PosterBindingNavigator.TabIndex = 1;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(49, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(126, 28);
            this.toolStripLabel1.Text = "Поиск по жанру ";
            // 
            // toolStripSaerchNameTextBox
            // 
            this.toolStripSaerchNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripSaerchNameTextBox.Name = "toolStripSaerchNameTextBox";
            this.toolStripSaerchNameTextBox.Size = new System.Drawing.Size(100, 31);
            this.toolStripSaerchNameTextBox.Enter += new System.EventHandler(this.toolStripTextBoxSearch_Enter);
            this.toolStripSaerchNameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.toolStripSaerchNameTextBox_KeyUp);
            this.toolStripSaerchNameTextBox.Click += new System.EventHandler(this.toolStripSaerchNameTextBox_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(194, 28);
            this.toolStripLabel2.Text = "Поиск свободных билетов";
            // 
            // SearchFreeTKTtoolStripComboBox
            // 
            this.SearchFreeTKTtoolStripComboBox.Items.AddRange(new object[] {
            "First",
            "Second",
            "Third"});
            this.SearchFreeTKTtoolStripComboBox.Name = "SearchFreeTKTtoolStripComboBox";
            this.SearchFreeTKTtoolStripComboBox.Size = new System.Drawing.Size(121, 31);
            this.SearchFreeTKTtoolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.SearchFreeTKTtoolStripComboBox_SelectedIndexChanged);
            this.SearchFreeTKTtoolStripComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchFreeTKTtoolStripComboBox_KeyUp);
            this.SearchFreeTKTtoolStripComboBox.Click += new System.EventHandler(this.SearchFreeTKTtoolStripComboBox_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(0, 28);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(266, 28);
            this.toolStripLabel4.Text = "Введите нужное количество билетов";
            // 
            // FreeTKTtoolStripTextBox
            // 
            this.FreeTKTtoolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FreeTKTtoolStripTextBox.Name = "FreeTKTtoolStripTextBox";
            this.FreeTKTtoolStripTextBox.Size = new System.Drawing.Size(100, 31);
            this.FreeTKTtoolStripTextBox.Click += new System.EventHandler(this.FreeTKTtoolStripTextBox_Click);
            // 
            // panel3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel3, 2);
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Controls.Add(this.EnterButton);
            this.panel3.Controls.Add(this.RegistrButton);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1454, 91);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.моиЗаказыToolStripMenuItem,
            this.заказыToolStripMenuItem,
            this.отчётыToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(6, 6);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(515, 34);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // моиЗаказыToolStripMenuItem
            // 
            this.моиЗаказыToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.моиЗаказыToolStripMenuItem.Name = "моиЗаказыToolStripMenuItem";
            this.моиЗаказыToolStripMenuItem.Size = new System.Drawing.Size(116, 30);
            this.моиЗаказыToolStripMenuItem.Text = "Мои заказы";
            this.моиЗаказыToolStripMenuItem.Click += new System.EventHandler(this.моиЗаказыToolStripMenuItem_Click);
            // 
            // заказыToolStripMenuItem
            // 
            this.заказыToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.заказыToolStripMenuItem.Name = "заказыToolStripMenuItem";
            this.заказыToolStripMenuItem.Size = new System.Drawing.Size(81, 30);
            this.заказыToolStripMenuItem.Text = "Заказы";
            this.заказыToolStripMenuItem.Click += new System.EventHandler(this.заказыToolStripMenuItem_Click);
            // 
            // отчётыToolStripMenuItem
            // 
            this.отчётыToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            this.отчётыToolStripMenuItem.Size = new System.Drawing.Size(97, 30);
            this.отчётыToolStripMenuItem.Text = "Отчёты";
            this.отчётыToolStripMenuItem.Click += new System.EventHandler(this.отчётыToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникПользователейToolStripMenuItem,
            this.справочникЖанровToolStripMenuItem,
            this.справочникАвторовToolStripMenuItem,
            this.справочникКатегорийБилетовToolStripMenuItem,
            this.справочникПьесToolStripMenuItem,
            this.справочникАфишToolStripMenuItem});
            this.настройкиToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(214, 30);
            this.настройкиToolStripMenuItem.Text = "Настройки приложения";
            // 
            // справочникПользователейToolStripMenuItem
            // 
            this.справочникПользователейToolStripMenuItem.Name = "справочникПользователейToolStripMenuItem";
            this.справочникПользователейToolStripMenuItem.Size = new System.Drawing.Size(349, 30);
            this.справочникПользователейToolStripMenuItem.Text = "Справочник пользователей";
            this.справочникПользователейToolStripMenuItem.Click += new System.EventHandler(this.справочникПользователейToolStripMenuItem_Click);
            // 
            // справочникЖанровToolStripMenuItem
            // 
            this.справочникЖанровToolStripMenuItem.Name = "справочникЖанровToolStripMenuItem";
            this.справочникЖанровToolStripMenuItem.Size = new System.Drawing.Size(349, 30);
            this.справочникЖанровToolStripMenuItem.Text = "Справочник жанров";
            this.справочникЖанровToolStripMenuItem.Click += new System.EventHandler(this.справочникЖанровToolStripMenuItem_Click);
            // 
            // справочникАвторовToolStripMenuItem
            // 
            this.справочникАвторовToolStripMenuItem.Name = "справочникАвторовToolStripMenuItem";
            this.справочникАвторовToolStripMenuItem.Size = new System.Drawing.Size(349, 30);
            this.справочникАвторовToolStripMenuItem.Text = "Справочник авторов";
            this.справочникАвторовToolStripMenuItem.Click += new System.EventHandler(this.справочникАвторовToolStripMenuItem_Click);
            // 
            // справочникКатегорийБилетовToolStripMenuItem
            // 
            this.справочникКатегорийБилетовToolStripMenuItem.Name = "справочникКатегорийБилетовToolStripMenuItem";
            this.справочникКатегорийБилетовToolStripMenuItem.Size = new System.Drawing.Size(349, 30);
            this.справочникКатегорийБилетовToolStripMenuItem.Text = "Справочник категорий билетов";
            this.справочникКатегорийБилетовToolStripMenuItem.Click += new System.EventHandler(this.справочникКатегорийБилетовToolStripMenuItem_Click);
            // 
            // справочникПьесToolStripMenuItem
            // 
            this.справочникПьесToolStripMenuItem.Name = "справочникПьесToolStripMenuItem";
            this.справочникПьесToolStripMenuItem.Size = new System.Drawing.Size(349, 30);
            this.справочникПьесToolStripMenuItem.Text = "Справочник пьес";
            this.справочникПьесToolStripMenuItem.Click += new System.EventHandler(this.справочникПьесToolStripMenuItem_Click);
            // 
            // справочникАфишToolStripMenuItem
            // 
            this.справочникАфишToolStripMenuItem.Name = "справочникАфишToolStripMenuItem";
            this.справочникАфишToolStripMenuItem.Size = new System.Drawing.Size(349, 30);
            this.справочникАфишToolStripMenuItem.Text = "Справочник афиш";
            this.справочникАфишToolStripMenuItem.Click += new System.EventHandler(this.справочникАфишToolStripMenuItem_Click);
            // 
            // EnterButton
            // 
            this.EnterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EnterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnterButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.EnterButton.FlatAppearance.BorderSize = 0;
            this.EnterButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.EnterButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.EnterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterButton.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterButton.Location = new System.Drawing.Point(1066, 0);
            this.EnterButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(84, 34);
            this.EnterButton.TabIndex = 0;
            this.EnterButton.Text = "Вход";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // RegistrButton
            // 
            this.RegistrButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RegistrButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegistrButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.RegistrButton.FlatAppearance.BorderSize = 0;
            this.RegistrButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.RegistrButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.RegistrButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrButton.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrButton.Location = new System.Drawing.Point(1172, -3);
            this.RegistrButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegistrButton.Name = "RegistrButton";
            this.RegistrButton.Size = new System.Drawing.Size(273, 34);
            this.RegistrButton.TabIndex = 1;
            this.RegistrButton.Text = "Регистрация";
            this.RegistrButton.UseVisualStyleBackColor = true;
            this.RegistrButton.Click += new System.EventHandler(this.RegistrButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(679, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 71);
            this.label1.TabIndex = 2;
            this.label1.Text = "Театр";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold);
            this.ExitButton.Location = new System.Drawing.Point(1356, 553);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(101, 37);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.SearchDateTimePicker);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(733, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(724, 34);
            this.panel4.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(385, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Поиск по дате";
            // 
            // SearchDateTimePicker
            // 
            this.SearchDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchDateTimePicker.Location = new System.Drawing.Point(538, 9);
            this.SearchDateTimePicker.Name = "SearchDateTimePicker";
            this.SearchDateTimePicker.Size = new System.Drawing.Size(177, 22);
            this.SearchDateTimePicker.TabIndex = 2;
            this.SearchDateTimePicker.ValueChanged += new System.EventHandler(this.SearchDateTimePicker_ValueChanged);
            this.SearchDateTimePicker.Enter += new System.EventHandler(this.SearchDateTimePicker_Enter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 592);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PosterDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PosterBindingNavigator)).EndInit();
            this.PosterBindingNavigator.ResumeLayout(false);
            this.PosterBindingNavigator.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RegistrButton;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView PosterDataGridView;
        private System.Windows.Forms.BindingNavigator PosterBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripSaerchNameTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникПользователейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникЖанровToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникАвторовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникКатегорийБилетовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникПьесToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникАфишToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem моиЗаказыToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker SearchDateTimePicker;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox SearchFreeTKTtoolStripComboBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox FreeTKTtoolStripTextBox;
        private System.Windows.Forms.ToolStripMenuItem отчётыToolStripMenuItem;
    }
}


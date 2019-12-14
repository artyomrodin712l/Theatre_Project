namespace Course_OOP
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ReportDataGridView = new System.Windows.Forms.DataGridView();
            this.ReportBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolSearchNameStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolSaerchGenreStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolSearchAuthorStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolSearchUserStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MoneyTextBox = new System.Windows.Forms.TextBox();
            this.ThirdMoneyTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ThirdAmountTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SecondMoneyTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SecondAmountTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.FirstMoneyTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FirstAmountTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FindButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportBindingNavigator)).BeginInit();
            this.ReportBindingNavigator.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.ReportDataGridView);
            this.panel1.Controls.Add(this.ReportBindingNavigator);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1918, 554);
            this.panel1.TabIndex = 0;
            // 
            // ReportDataGridView
            // 
            this.ReportDataGridView.AllowUserToAddRows = false;
            this.ReportDataGridView.AllowUserToDeleteRows = false;
            this.ReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportDataGridView.Location = new System.Drawing.Point(0, 27);
            this.ReportDataGridView.Name = "ReportDataGridView";
            this.ReportDataGridView.ReadOnly = true;
            this.ReportDataGridView.RowHeadersWidth = 51;
            this.ReportDataGridView.RowTemplate.Height = 24;
            this.ReportDataGridView.Size = new System.Drawing.Size(1918, 527);
            this.ReportDataGridView.TabIndex = 0;
            this.ReportDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReportDataGridView_CellContentClick_1);
            // 
            // ReportBindingNavigator
            // 
            this.ReportBindingNavigator.AddNewItem = null;
            this.ReportBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ReportBindingNavigator.DeleteItem = null;
            this.ReportBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ReportBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel1,
            this.toolSearchNameStripTextBox,
            this.toolStripLabel2,
            this.toolSaerchGenreStripTextBox,
            this.toolStripLabel3,
            this.toolSearchAuthorStripTextBox,
            this.toolStripLabel4,
            this.toolSearchUserStripTextBox});
            this.ReportBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ReportBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ReportBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ReportBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ReportBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ReportBindingNavigator.Name = "ReportBindingNavigator";
            this.ReportBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ReportBindingNavigator.Size = new System.Drawing.Size(1918, 27);
            this.ReportBindingNavigator.TabIndex = 1;
            this.ReportBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(150, 24);
            this.toolStripLabel1.Text = "Поиск по спектаклю";
            // 
            // toolSearchNameStripTextBox
            // 
            this.toolSearchNameStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolSearchNameStripTextBox.Name = "toolSearchNameStripTextBox";
            this.toolSearchNameStripTextBox.Size = new System.Drawing.Size(100, 27);
            this.toolSearchNameStripTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.toolSearchNameStripTextBox_KeyUp);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(122, 24);
            this.toolStripLabel2.Text = "Поиск по жанру";
            // 
            // toolSaerchGenreStripTextBox
            // 
            this.toolSaerchGenreStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolSaerchGenreStripTextBox.Name = "toolSaerchGenreStripTextBox";
            this.toolSaerchGenreStripTextBox.Size = new System.Drawing.Size(100, 27);
            this.toolSaerchGenreStripTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.toolSearchGenreStripTextBox_KeyUp);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(125, 24);
            this.toolStripLabel3.Text = "Поиск по автору";
            // 
            // toolSearchAuthorStripTextBox
            // 
            this.toolSearchAuthorStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolSearchAuthorStripTextBox.Name = "toolSearchAuthorStripTextBox";
            this.toolSearchAuthorStripTextBox.Size = new System.Drawing.Size(100, 27);
            this.toolSearchAuthorStripTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.toolSearchAuthorStripTextBox_KeyUp);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(185, 24);
            this.toolStripLabel4.Text = "Поиск по пользователям";
            // 
            // toolSearchUserStripTextBox
            // 
            this.toolSearchUserStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolSearchUserStripTextBox.Name = "toolSearchUserStripTextBox";
            this.toolSearchUserStripTextBox.Size = new System.Drawing.Size(100, 27);
            this.toolSearchUserStripTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.toolSearchUserStripTextBox_KeyUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(817, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "2st category amount:";
            // 
            // panel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 2);
            this.panel2.Controls.Add(this.FromDateTimePicker);
            this.panel2.Controls.Add(this.MoneyTextBox);
            this.panel2.Controls.Add(this.ThirdMoneyTextBox);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.ThirdAmountTextBox);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.SecondMoneyTextBox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.SecondAmountTextBox);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.FirstMoneyTextBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.FirstAmountTextBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.AmountTextBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.FindButton);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ToDateTimePicker);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1918, 44);
            this.panel2.TabIndex = 1;
            // 
            // FromDateTimePicker
            // 
            this.FromDateTimePicker.Location = new System.Drawing.Point(49, 22);
            this.FromDateTimePicker.Name = "FromDateTimePicker";
            this.FromDateTimePicker.Size = new System.Drawing.Size(147, 22);
            this.FromDateTimePicker.TabIndex = 0;
            // 
            // MoneyTextBox
            // 
            this.MoneyTextBox.Location = new System.Drawing.Point(519, 22);
            this.MoneyTextBox.Name = "MoneyTextBox";
            this.MoneyTextBox.ReadOnly = true;
            this.MoneyTextBox.Size = new System.Drawing.Size(51, 22);
            this.MoneyTextBox.TabIndex = 6;
            // 
            // ThirdMoneyTextBox
            // 
            this.ThirdMoneyTextBox.Location = new System.Drawing.Point(1856, 20);
            this.ThirdMoneyTextBox.Name = "ThirdMoneyTextBox";
            this.ThirdMoneyTextBox.ReadOnly = true;
            this.ThirdMoneyTextBox.Size = new System.Drawing.Size(53, 22);
            this.ThirdMoneyTextBox.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1712, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "3rd category money:";
            // 
            // ThirdAmountTextBox
            // 
            this.ThirdAmountTextBox.Location = new System.Drawing.Point(1658, 20);
            this.ThirdAmountTextBox.Name = "ThirdAmountTextBox";
            this.ThirdAmountTextBox.ReadOnly = true;
            this.ThirdAmountTextBox.Size = new System.Drawing.Size(48, 22);
            this.ThirdAmountTextBox.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1509, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 17);
            this.label11.TabIndex = 17;
            this.label11.Text = "3rd category amount:";
            // 
            // SecondMoneyTextBox
            // 
            this.SecondMoneyTextBox.Location = new System.Drawing.Point(1456, 20);
            this.SecondMoneyTextBox.Name = "SecondMoneyTextBox";
            this.SecondMoneyTextBox.ReadOnly = true;
            this.SecondMoneyTextBox.Size = new System.Drawing.Size(47, 22);
            this.SecondMoneyTextBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1309, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "2nd category money:";
            // 
            // SecondAmountTextBox
            // 
            this.SecondAmountTextBox.Location = new System.Drawing.Point(1258, 20);
            this.SecondAmountTextBox.Name = "SecondAmountTextBox";
            this.SecondAmountTextBox.ReadOnly = true;
            this.SecondAmountTextBox.Size = new System.Drawing.Size(45, 22);
            this.SecondAmountTextBox.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1111, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "2st category amount:";
            // 
            // FirstMoneyTextBox
            // 
            this.FirstMoneyTextBox.Location = new System.Drawing.Point(1061, 20);
            this.FirstMoneyTextBox.Name = "FirstMoneyTextBox";
            this.FirstMoneyTextBox.ReadOnly = true;
            this.FirstMoneyTextBox.Size = new System.Drawing.Size(44, 22);
            this.FirstMoneyTextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(914, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "1nd category money:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // FirstAmountTextBox
            // 
            this.FirstAmountTextBox.Location = new System.Drawing.Point(859, 20);
            this.FirstAmountTextBox.Name = "FirstAmountTextBox";
            this.FirstAmountTextBox.ReadOnly = true;
            this.FirstAmountTextBox.Size = new System.Drawing.Size(49, 22);
            this.FirstAmountTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(712, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "1st category amount:";
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(660, 20);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.ReadOnly = true;
            this.AmountTextBox.Size = new System.Drawing.Size(46, 22);
            this.AmountTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(571, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tkt amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Money:";
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(377, 21);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(95, 23);
            this.FindButton.TabIndex = 4;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "From";
            // 
            // ToDateTimePicker
            // 
            this.ToDateTimePicker.Location = new System.Drawing.Point(224, 21);
            this.ToDateTimePicker.Name = "ToDateTimePicker";
            this.ToDateTimePicker.Size = new System.Drawing.Size(147, 22);
            this.ToDateTimePicker.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1924, 660);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 660);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportBindingNavigator)).EndInit();
            this.ReportBindingNavigator.ResumeLayout(false);
            this.ReportBindingNavigator.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView ReportDataGridView;
        private System.Windows.Forms.BindingNavigator ReportBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker ToDateTimePicker;
        private System.Windows.Forms.DateTimePicker FromDateTimePicker;
        private System.Windows.Forms.TextBox MoneyTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FirstAmountTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FirstMoneyTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SecondMoneyTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SecondAmountTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ThirdMoneyTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ThirdAmountTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolSearchNameStripTextBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox toolSaerchGenreStripTextBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox toolSearchAuthorStripTextBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox toolSearchUserStripTextBox;
    }
}
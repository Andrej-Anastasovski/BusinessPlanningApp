namespace Expense_Tracking_App
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewDailyIncome = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewWeeklyIncome = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewMonthlyIncome = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridViewTotalIncome = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridViewDailyExpenses = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dataGridViewWeeklyExpenses = new System.Windows.Forms.DataGridView();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.dataGridViewMonthlyExpenses = new System.Windows.Forms.DataGridView();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.dataGridViewTotalExpenses = new System.Windows.Forms.DataGridView();
            this.buttonOpenAddEditForm = new System.Windows.Forms.Button();
            this.buttonConvertCurrency = new System.Windows.Forms.Button();
            this.comboBoxCurrencySelection = new System.Windows.Forms.ComboBox();
            this.TaxPeriodComboBox = new System.Windows.Forms.ComboBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.txtMonthlyLimit = new System.Windows.Forms.TextBox();
            this.btnSetLimit = new System.Windows.Forms.Button();
            this.btnCheckBudget = new System.Windows.Forms.Button();
            this.txtCheckBudget = new System.Windows.Forms.TextBox();
            this.buttonUndo = new System.Windows.Forms.Button();
            this.buttonRedo = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelIncomeTax = new System.Windows.Forms.Label();
            this.labelExpenseTax = new System.Windows.Forms.Label();
            this.labelRefundTax = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDailyIncome)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeeklyIncome)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonthlyIncome)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTotalIncome)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDailyExpenses)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeeklyExpenses)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonthlyExpenses)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTotalExpenses)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.ItemSize = new System.Drawing.Size(200, 50);
            this.tabControl1.Location = new System.Drawing.Point(178, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(22, 5);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(823, 448);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewDailyIncome);
            this.tabPage1.Location = new System.Drawing.Point(4, 104);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(815, 340);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Daily Income";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDailyIncome
            // 
            this.dataGridViewDailyIncome.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDailyIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDailyIncome.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewDailyIncome.Name = "dataGridViewDailyIncome";
            this.dataGridViewDailyIncome.Size = new System.Drawing.Size(803, 328);
            this.dataGridViewDailyIncome.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewWeeklyIncome);
            this.tabPage2.Location = new System.Drawing.Point(4, 104);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(815, 340);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Weekly Income";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewWeeklyIncome
            // 
            this.dataGridViewWeeklyIncome.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewWeeklyIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWeeklyIncome.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewWeeklyIncome.Name = "dataGridViewWeeklyIncome";
            this.dataGridViewWeeklyIncome.Size = new System.Drawing.Size(803, 328);
            this.dataGridViewWeeklyIncome.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewMonthlyIncome);
            this.tabPage3.Location = new System.Drawing.Point(4, 104);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(815, 340);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Monthly Income";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMonthlyIncome
            // 
            this.dataGridViewMonthlyIncome.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMonthlyIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMonthlyIncome.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewMonthlyIncome.Name = "dataGridViewMonthlyIncome";
            this.dataGridViewMonthlyIncome.Size = new System.Drawing.Size(803, 328);
            this.dataGridViewMonthlyIncome.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage4.Controls.Add(this.dataGridViewTotalIncome);
            this.tabPage4.Location = new System.Drawing.Point(4, 104);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(815, 340);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Total Income";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTotalIncome
            // 
            this.dataGridViewTotalIncome.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTotalIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTotalIncome.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewTotalIncome.Name = "dataGridViewTotalIncome";
            this.dataGridViewTotalIncome.Size = new System.Drawing.Size(803, 328);
            this.dataGridViewTotalIncome.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridViewDailyExpenses);
            this.tabPage5.Location = new System.Drawing.Point(4, 104);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(815, 340);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Daily Expenses";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDailyExpenses
            // 
            this.dataGridViewDailyExpenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDailyExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDailyExpenses.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewDailyExpenses.Name = "dataGridViewDailyExpenses";
            this.dataGridViewDailyExpenses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewDailyExpenses.Size = new System.Drawing.Size(803, 328);
            this.dataGridViewDailyExpenses.TabIndex = 1;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.dataGridViewWeeklyExpenses);
            this.tabPage6.Location = new System.Drawing.Point(4, 104);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(815, 340);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Weekly Expenses";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dataGridViewWeeklyExpenses
            // 
            this.dataGridViewWeeklyExpenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewWeeklyExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWeeklyExpenses.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewWeeklyExpenses.Name = "dataGridViewWeeklyExpenses";
            this.dataGridViewWeeklyExpenses.Size = new System.Drawing.Size(803, 328);
            this.dataGridViewWeeklyExpenses.TabIndex = 2;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.dataGridViewMonthlyExpenses);
            this.tabPage7.Location = new System.Drawing.Point(4, 104);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(815, 340);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Monthly Expenses";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMonthlyExpenses
            // 
            this.dataGridViewMonthlyExpenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMonthlyExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMonthlyExpenses.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewMonthlyExpenses.Name = "dataGridViewMonthlyExpenses";
            this.dataGridViewMonthlyExpenses.Size = new System.Drawing.Size(803, 328);
            this.dataGridViewMonthlyExpenses.TabIndex = 2;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.dataGridViewTotalExpenses);
            this.tabPage8.Location = new System.Drawing.Point(4, 104);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(815, 340);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Total Expenses";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTotalExpenses
            // 
            this.dataGridViewTotalExpenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTotalExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTotalExpenses.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewTotalExpenses.Name = "dataGridViewTotalExpenses";
            this.dataGridViewTotalExpenses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewTotalExpenses.Size = new System.Drawing.Size(803, 328);
            this.dataGridViewTotalExpenses.TabIndex = 2;
            // 
            // buttonOpenAddEditForm
            // 
            this.buttonOpenAddEditForm.Location = new System.Drawing.Point(182, 466);
            this.buttonOpenAddEditForm.Name = "buttonOpenAddEditForm";
            this.buttonOpenAddEditForm.Size = new System.Drawing.Size(202, 52);
            this.buttonOpenAddEditForm.TabIndex = 1;
            this.buttonOpenAddEditForm.Text = "Add Transaction";
            this.buttonOpenAddEditForm.UseVisualStyleBackColor = true;
            this.buttonOpenAddEditForm.Click += new System.EventHandler(this.buttonOpenAddEditForm_Click);
            // 
            // buttonConvertCurrency
            // 
            this.buttonConvertCurrency.Location = new System.Drawing.Point(847, 537);
            this.buttonConvertCurrency.Name = "buttonConvertCurrency";
            this.buttonConvertCurrency.Size = new System.Drawing.Size(144, 52);
            this.buttonConvertCurrency.TabIndex = 2;
            this.buttonConvertCurrency.Text = "Convert Currency";
            this.buttonConvertCurrency.UseVisualStyleBackColor = true;
            this.buttonConvertCurrency.Click += new System.EventHandler(this.buttonConvertCurrency_Click);
            // 
            // comboBoxCurrencySelection
            // 
            this.comboBoxCurrencySelection.FormattingEnabled = true;
            this.comboBoxCurrencySelection.Items.AddRange(new object[] {
            "USD",
            "EUR"});
            this.comboBoxCurrencySelection.Location = new System.Drawing.Point(851, 494);
            this.comboBoxCurrencySelection.Name = "comboBoxCurrencySelection";
            this.comboBoxCurrencySelection.Size = new System.Drawing.Size(140, 21);
            this.comboBoxCurrencySelection.TabIndex = 3;
            // 
            // TaxPeriodComboBox
            // 
            this.TaxPeriodComboBox.FormattingEnabled = true;
            this.TaxPeriodComboBox.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Monthly",
            "Total"});
            this.TaxPeriodComboBox.Location = new System.Drawing.Point(6, 103);
            this.TaxPeriodComboBox.Name = "TaxPeriodComboBox";
            this.TaxPeriodComboBox.Size = new System.Drawing.Size(131, 21);
            this.TaxPeriodComboBox.TabIndex = 6;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(390, 465);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(202, 52);
            this.buttonEdit.TabIndex = 13;
            this.buttonEdit.Text = "Edit Transaction";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(598, 465);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(202, 52);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "Delete Transaction";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // txtMonthlyLimit
            // 
            this.txtMonthlyLimit.Location = new System.Drawing.Point(178, 569);
            this.txtMonthlyLimit.Name = "txtMonthlyLimit";
            this.txtMonthlyLimit.Size = new System.Drawing.Size(157, 20);
            this.txtMonthlyLimit.TabIndex = 16;
            // 
            // btnSetLimit
            // 
            this.btnSetLimit.Location = new System.Drawing.Point(341, 538);
            this.btnSetLimit.Name = "btnSetLimit";
            this.btnSetLimit.Size = new System.Drawing.Size(144, 51);
            this.btnSetLimit.TabIndex = 17;
            this.btnSetLimit.Text = "Set Limit";
            this.btnSetLimit.UseVisualStyleBackColor = true;
            this.btnSetLimit.Click += new System.EventHandler(this.btnSetLimit_Click);
            // 
            // btnCheckBudget
            // 
            this.btnCheckBudget.Location = new System.Drawing.Point(487, 538);
            this.btnCheckBudget.Name = "btnCheckBudget";
            this.btnCheckBudget.Size = new System.Drawing.Size(144, 51);
            this.btnCheckBudget.TabIndex = 18;
            this.btnCheckBudget.Text = "Check Budget";
            this.btnCheckBudget.UseVisualStyleBackColor = true;
            this.btnCheckBudget.Click += new System.EventHandler(this.btnCheckBudget_Click);
            // 
            // txtCheckBudget
            // 
            this.txtCheckBudget.Location = new System.Drawing.Point(637, 569);
            this.txtCheckBudget.Name = "txtCheckBudget";
            this.txtCheckBudget.Size = new System.Drawing.Size(163, 20);
            this.txtCheckBudget.TabIndex = 19;
            // 
            // buttonUndo
            // 
            this.buttonUndo.Location = new System.Drawing.Point(5, 118);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(134, 52);
            this.buttonUndo.TabIndex = 21;
            this.buttonUndo.Text = "Undo";
            this.buttonUndo.UseVisualStyleBackColor = true;
            this.buttonUndo.Click += new System.EventHandler(this.buttonUndo_Click);
            // 
            // buttonRedo
            // 
            this.buttonRedo.Location = new System.Drawing.Point(5, 175);
            this.buttonRedo.Name = "buttonRedo";
            this.buttonRedo.Size = new System.Drawing.Size(134, 52);
            this.buttonRedo.TabIndex = 22;
            this.buttonRedo.Text = "Redo";
            this.buttonRedo.UseVisualStyleBackColor = true;
            this.buttonRedo.Click += new System.EventHandler(this.buttonRedo_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(5, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(134, 52);
            this.buttonSave.TabIndex = 23;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(5, 60);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(134, 52);
            this.buttonLoad.TabIndex = 24;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.BackColor = System.Drawing.Color.PaleGreen;
            this.lblBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblBalance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBalance.Location = new System.Drawing.Point(28, 5);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(94, 44);
            this.lblBalance.TabIndex = 25;
            this.lblBalance.Text = "Balance: \r\n$0.00";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.buttonRedo);
            this.panel1.Controls.Add(this.buttonUndo);
            this.panel1.Controls.Add(this.buttonLoad);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Location = new System.Drawing.Point(15, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 231);
            this.panel1.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 18);
            this.label8.TabIndex = 27;
            this.label8.Text = "Select Time Period";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Paid Income Tax";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Refundable Tax";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "Paid Expense Tax";
            // 
            // labelIncomeTax
            // 
            this.labelIncomeTax.AutoSize = true;
            this.labelIncomeTax.BackColor = System.Drawing.Color.Transparent;
            this.labelIncomeTax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelIncomeTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelIncomeTax.Location = new System.Drawing.Point(4, 151);
            this.labelIncomeTax.Name = "labelIncomeTax";
            this.labelIncomeTax.Size = new System.Drawing.Size(0, 18);
            this.labelIncomeTax.TabIndex = 31;
            // 
            // labelExpenseTax
            // 
            this.labelExpenseTax.AutoSize = true;
            this.labelExpenseTax.BackColor = System.Drawing.Color.Transparent;
            this.labelExpenseTax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelExpenseTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelExpenseTax.Location = new System.Drawing.Point(4, 203);
            this.labelExpenseTax.Name = "labelExpenseTax";
            this.labelExpenseTax.Size = new System.Drawing.Size(0, 18);
            this.labelExpenseTax.TabIndex = 32;
            // 
            // labelRefundTax
            // 
            this.labelRefundTax.AutoSize = true;
            this.labelRefundTax.BackColor = System.Drawing.Color.Transparent;
            this.labelRefundTax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelRefundTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelRefundTax.Location = new System.Drawing.Point(4, 256);
            this.labelRefundTax.Name = "labelRefundTax";
            this.labelRefundTax.Size = new System.Drawing.Size(0, 18);
            this.labelRefundTax.TabIndex = 33;
            this.labelRefundTax.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.labelIncomeTax);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.labelRefundTax);
            this.panel2.Controls.Add(this.TaxPeriodComboBox);
            this.panel2.Controls.Add(this.labelExpenseTax);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(15, 315);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 278);
            this.panel2.TabIndex = 34;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(7, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 64);
            this.panel3.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "CALCULATOR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "TAX";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(878, 466);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 18);
            this.label10.TabIndex = 36;
            this.label10.Text = "Select Currency";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(179, 538);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 18);
            this.label5.TabIndex = 36;
            this.label5.Text = "Monthly Expense Limit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(634, 538);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 18);
            this.label6.TabIndex = 37;
            this.label6.Text = "Total Monthly Expenses";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PaleGreen;
            this.panel4.Controls.Add(this.lblBalance);
            this.panel4.Location = new System.Drawing.Point(15, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(144, 51);
            this.panel4.TabIndex = 38;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 605);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonOpenAddEditForm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCheckBudget);
            this.Controls.Add(this.btnCheckBudget);
            this.Controls.Add(this.btnSetLimit);
            this.Controls.Add(this.txtMonthlyLimit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonConvertCurrency);
            this.Controls.Add(this.comboBoxCurrencySelection);
            this.Name = "Form1";
            this.Text = "Budgeting Application";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDailyIncome)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeeklyIncome)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonthlyIncome)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTotalIncome)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDailyExpenses)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeeklyExpenses)).EndInit();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonthlyExpenses)).EndInit();
            this.tabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTotalExpenses)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.DataGridView dataGridViewDailyIncome;
        private System.Windows.Forms.DataGridView dataGridViewWeeklyIncome;
        private System.Windows.Forms.DataGridView dataGridViewMonthlyIncome;
        private System.Windows.Forms.DataGridView dataGridViewTotalIncome;
        private System.Windows.Forms.DataGridView dataGridViewDailyExpenses;
        private System.Windows.Forms.DataGridView dataGridViewWeeklyExpenses;
        private System.Windows.Forms.DataGridView dataGridViewMonthlyExpenses;
        private System.Windows.Forms.DataGridView dataGridViewTotalExpenses;
        private System.Windows.Forms.Button buttonOpenAddEditForm;
        private System.Windows.Forms.Button buttonConvertCurrency;
        private System.Windows.Forms.ComboBox comboBoxCurrencySelection;
        private System.Windows.Forms.ComboBox TaxPeriodComboBox;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox txtMonthlyLimit;
        private System.Windows.Forms.Button btnSetLimit;
        private System.Windows.Forms.Button btnCheckBudget;
        private System.Windows.Forms.TextBox txtCheckBudget;
        private System.Windows.Forms.Button buttonUndo;
        private System.Windows.Forms.Button buttonRedo;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelIncomeTax;
        private System.Windows.Forms.Label labelExpenseTax;
        private System.Windows.Forms.Label labelRefundTax;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
    }
}


using Expense_Tracking_App.Data;
using Expense_Tracking_App.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Expense_Tracking_App
{
    public partial class Form1 : Form
    {
        private BindingList<Transaction> transactions;
        private TransactionDataSource _dataSource;
        private string _currentSortProperty = "Date";
        private ListSortDirection _currentSortDirection = ListSortDirection.Ascending;
        private decimal _monthlyLimit = 0;
        private DataSerializer _dataSerializer;
        private Expense currentExpense;

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;

            // Initialize DataSerializer
            _dataSerializer = new DataSerializer();

            // Initialize TransactionDataSource
            transactions = new BindingList<Transaction>
            {
                // Sample data
                new Income { Date = new DateTime(2024, 9, 18), Amount = 1500, Source = "Job", Description = "Today's Salary", Currency = "USD" },
                new Income { Date = new DateTime(2024, 9, 12), Amount = 1600, Source = "Freelance", Description = "Project Payment (Last Week)", Currency = "EUR" },
                new Income { Date = new DateTime(2024, 8, 15), Amount = 2100, Source = "Investment", Description = "Stock Dividends (Last Month)", Currency = "USD" },
                new Income { Date = new DateTime(2024, 7, 20), Amount = 1900, Source = "Job", Description = "Previous Monthly Salary", Currency = "USD" },
                new Income { Date = new DateTime(2024, 6, 18), Amount = 1800, Source = "Freelance", Description = "Consulting Fee (Two Months Ago)", Currency = "EUR" },

                new Income { Date = new DateTime(2024, 5, 22), Amount = 2500, Source = "Investment", Description = "Quarterly Dividends", Currency = "USD" },
                new Income { Date = new DateTime(2024, 4, 15), Amount = 1700, Source = "Freelance", Description = "Web Design Payment", Currency = "EUR" },
                new Income { Date = new DateTime(2024, 3, 10), Amount = 1900, Source = "Job", Description = "Salary Adjustment", Currency = "USD" },
                new Income { Date = new DateTime(2024, 2, 8), Amount = 1600, Source = "Freelance", Description = "Content Creation", Currency = "EUR" },
                new Income { Date = new DateTime(2024, 1, 5), Amount = 2000, Source = "Investment", Description = "Annual Returns", Currency = "USD" },
                new Expense { Date = new DateTime(2024, 9, 18), Amount = 90, Category = "Food", Description = "Grocery Shopping Today", Currency = "USD" },
                new Expense { Date = new DateTime(2024, 9, 10), Amount = 55, Category = "Transportation", Description = "Train Ticket (Last Week)", Currency = "EUR" },
                new Expense { Date = new DateTime(2024, 8, 12), Amount = 140, Category = "Utilities", Description = "Gas Bill (Last Month)", Currency = "USD" },
                new Expense { Date = new DateTime(2024, 7, 10), Amount = 85, Category = "Healthcare", Description = "Pharmacy Bill (Two Months Ago)", Currency = "USD" },
                new Expense { Date = new DateTime(2024, 6, 20), Amount = 210, Category = "Rent", Description = "Rent Payment (Three Months Ago)", Currency = "EUR" },

                new Expense { Date = new DateTime(2024, 5, 18), Amount = 80, Category = "Food", Description = "Restaurant Bill", Currency = "USD" },
                new Expense { Date = new DateTime(2024, 4, 22), Amount = 65, Category = "Transportation", Description = "Taxi Fare", Currency = "EUR" },
                new Expense { Date = new DateTime(2024, 3, 15), Amount = 120, Category = "Utilities", Description = "Internet Bill", Currency = "USD" },
                new Expense { Date = new DateTime(2024, 2, 10), Amount = 75, Category = "Healthcare", Description = "Dental Visit", Currency = "EUR" },
                new Expense { Date = new DateTime(2024, 1, 8), Amount = 200, Category = "Rent", Description = "Additional Rent Payment", Currency = "USD" }
            };
            _dataSource = new TransactionDataSource(transactions);
                
            // Bind events
            TaxPeriodComboBox.SelectedIndexChanged += TaxPeriodComboBox_SelectedIndexChanged;

            // Set up DataGridViews
            SetUpDataGridView(dataGridViewDailyIncome, "Income");
            SetUpDataGridView(dataGridViewWeeklyIncome, "Income");
            SetUpDataGridView(dataGridViewMonthlyIncome, "Income");
            SetUpDataGridView(dataGridViewTotalIncome, "Income");
            SetUpDataGridView(dataGridViewDailyExpenses, "Expense");
            SetUpDataGridView(dataGridViewWeeklyExpenses, "Expense");
            SetUpDataGridView(dataGridViewMonthlyExpenses, "Expense");
            SetUpDataGridView(dataGridViewTotalExpenses, "Expense");

            // Bind data
            BindData();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Update the balance when the form loads
            UpdateBalance();
        }
        private void buttonOpenAddEditForm_Click(object sender, EventArgs e)
        {
            using (var addEditForm = new AddEditForm())
            {
                if (addEditForm.ShowDialog() == DialogResult.OK)
                {
                    var newTransaction = addEditForm.Transaction;
                    if (newTransaction != null)
                    {
                        _dataSource.AddTransaction(newTransaction);
                        BindData(); // Rebind data to reflect new transaction
                        UpdateBalance();
                    }
                }
            }
        }
        private void UpdateBalance()
        {
            decimal currentBalance = 0;

            // Loop through all transactions and call their respective Balance method
            foreach (var transaction in transactions)
            {
                currentBalance = transaction.Balance(currentBalance);
            }
            lblBalance.Text = $"Balance: \n{currentBalance:F2}"; // Formats to 2 decimal places
        }



        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditSelectedTransaction();
          
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedTransaction();
            UpdateBalance();

        }
        private void buttonUndo_Click(object sender, EventArgs e)
        {
            _dataSource.Undo();
            UpdateBalance();
            BindData(); // Rebind data to reflect changes
            
        }

        private void buttonRedo_Click(object sender, EventArgs e)
        {
            _dataSource.Redo();
            UpdateBalance();
            BindData(); // Rebind data to reflect changes
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                var allTransactions = new List<Transaction>();
                allTransactions.AddRange(_dataSource.GetTotalIncome());
                allTransactions.AddRange(_dataSource.GetTotalExpenses());

                _dataSerializer.SerializeToFile("transactions.json", allTransactions);
                MessageBox.Show("Data saved successfully.", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                openFileDialog.Title = "Select a JSON File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var loadedTransactions = _dataSerializer.DeserializeFromFile(openFileDialog.FileName);
                        _dataSource.SetTransactions(loadedTransactions);
                        BindData(); // Update the DataGridView after loading the data
                        MessageBox.Show("Data loaded successfully.", "Load Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading data: {ex.Message}", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



        private void btnSetLimit_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtMonthlyLimit.Text, out decimal limit))
            {
                if (currentExpense == null)
                {
                    currentExpense = new Expense(); // Initialize if not already done
                }

                currentExpense.SetMonthlyLimit(limit);
                MessageBox.Show("Monthly limit set successfully.", "Limit Set", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid amount. Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCheckBudget_Click(object sender, EventArgs e)
        {
            if (comboBoxCurrencySelection.SelectedItem == null)
            {
                MessageBox.Show("Please select a currency first", "Currency Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ensure currentExpense is initialized
            if (currentExpense == null)
            {
                currentExpense = new Expense(); // Initialize if not already done
            }

            if (currentExpense.MonthlyLimit == 0)
            {
                MessageBox.Show("Please set a monthly limit first.", "Limit Not Set", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedPeriodExpenses = GetExpensesForCurrentMonth(); // This should return the expenses
            decimal totalMonthlyExpenses = selectedPeriodExpenses.Sum(expense => expense.Amount); // Change 'e' to 'expense'

            // Display total monthly expenses and the monthly limit in the textbox
            txtCheckBudget.Text = $"{totalMonthlyExpenses} / {currentExpense.MonthlyLimit} {comboBoxCurrencySelection.SelectedItem}";

            if (currentExpense.IsOverBudget(selectedPeriodExpenses))
            {
                MessageBox.Show("You are over budget for this month.", "Budget Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("You are within your budget.", "Budget Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private IEnumerable<Expense> GetExpensesForCurrentMonth()
        {
            var currentMonth = DateTime.Now.Month;
            var currentYear = DateTime.Now.Year;
            return _dataSource.GetMonthlyExpenses()
                .Where(expense => expense.Date.Month == currentMonth && expense.Date.Year == currentYear);
        }


        private void EditSelectedTransaction()
        {
            var selectedRow = GetSelectedRow();
            if (selectedRow != null)
            {
                var selectedTransaction = (Transaction)selectedRow.DataBoundItem;
                using (var addEditForm = new AddEditForm(selectedTransaction))
                {
                    if (addEditForm.ShowDialog() == DialogResult.OK)
                    {
                        var updatedTransaction = addEditForm.Transaction;
                        if (updatedTransaction != null)
                        {
                            _dataSource.UpdateTransaction(selectedTransaction, updatedTransaction);
                            BindData(); // Rebind data to reflect changes
                            UpdateBalance();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a transaction to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteSelectedTransaction()
        {
            var selectedRow = GetSelectedRow();
            if (selectedRow != null)
            {
                var selectedTransaction = (Transaction)selectedRow.DataBoundItem;
                if (MessageBox.Show("Are you sure you want to delete this transaction?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _dataSource.RemoveTransaction(selectedTransaction);
                    BindData(); // Rebind data to reflect changes
                    UpdateBalance();
                }
            }
            else
            {
                MessageBox.Show("Please select a transaction to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private DataGridViewRow GetSelectedRow()
        {
            // Check each DataGridView for selected rows
            foreach (var dgv in new[] { dataGridViewDailyIncome, dataGridViewWeeklyIncome, dataGridViewMonthlyIncome, dataGridViewTotalIncome,
                                dataGridViewDailyExpenses, dataGridViewWeeklyExpenses, dataGridViewMonthlyExpenses, dataGridViewTotalExpenses })
            {
                if (dgv.SelectedRows.Count > 0)
                    return dgv.SelectedRows[0];
            }
            return null;
        }

        private void buttonConvertCurrency_Click(object sender, EventArgs e)
        {
            
            string selectedCurrency = comboBoxCurrencySelection.SelectedItem.ToString();
            UpdateBalance();
            ConvertDataGridView(dataGridViewDailyIncome, selectedCurrency);
            ConvertDataGridView(dataGridViewWeeklyIncome, selectedCurrency);
            ConvertDataGridView(dataGridViewMonthlyIncome, selectedCurrency);
            ConvertDataGridView(dataGridViewTotalIncome, selectedCurrency);
            ConvertDataGridView(dataGridViewDailyExpenses, selectedCurrency);
            ConvertDataGridView(dataGridViewWeeklyExpenses, selectedCurrency);
            ConvertDataGridView(dataGridViewMonthlyExpenses, selectedCurrency);
            ConvertDataGridView(dataGridViewTotalExpenses, selectedCurrency);
        }

        private void ConvertDataGridView(DataGridView dgv, string toCurrency)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.DataBoundItem is Transaction transaction)
                {
                    // Convert the amount
                    decimal convertedAmount = transaction.ConvertCurrency(transaction.Amount, transaction.Currency, toCurrency);
                    row.Cells["AmountColumn"].Value = convertedAmount;
                    row.Cells["CurrencyColumn"].Value = toCurrency; // Update the currency string
                    transaction.Currency = toCurrency; // Update the currency in the transaction object
                }
            }
        }

        private void BindData()
        {

            dataGridViewTotalIncome.DataSource = _dataSource.GetTotalIncome().ToList();
            dataGridViewTotalExpenses.DataSource = _dataSource.GetTotalExpenses().ToList();
            // Bind data to DataGridViews using TransactionDataSource methods
            dataGridViewDailyIncome.DataSource = _dataSource.GetDailyIncome().ToList();
            dataGridViewWeeklyIncome.DataSource = _dataSource.GetWeeklyIncome().ToList();
            dataGridViewMonthlyIncome.DataSource = _dataSource.GetMonthlyIncome().ToList();
            dataGridViewTotalIncome.DataSource = _dataSource.GetTotalIncome().ToList();
            dataGridViewDailyExpenses.DataSource = _dataSource.GetDailyExpenses().ToList();
            dataGridViewWeeklyExpenses.DataSource = _dataSource.GetWeeklyExpenses().ToList();
            dataGridViewMonthlyExpenses.DataSource = _dataSource.GetMonthlyExpenses().ToList();
            dataGridViewTotalExpenses.DataSource = _dataSource.GetTotalExpenses().ToList();
        }

        private void SetUpDataGridView(DataGridView dgv, string type)
        {
            dgv.AutoGenerateColumns = false;

            if (dgv.Columns.Count == 0) // Only set up columns if not already set
            {
                if (type == "Income")
                {
                    dgv.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "DateColumn",
                        HeaderText = "Date",
                        DataPropertyName = "Date"
                    });
                    dgv.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "AmountColumn",
                        HeaderText = "Amount",
                        DataPropertyName = "Amount"
                    });
                    dgv.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "SourceColumn",
                        HeaderText = "Source",
                        DataPropertyName = "Source"
                    });
                    dgv.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "DescriptionColumn",
                        HeaderText = "Description",
                        DataPropertyName = "Description"
                    });
                    dgv.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "CurrencyColumn",
                        HeaderText = "Currency",
                        DataPropertyName = "Currency"
                    });
                }
                else if (type == "Expense")
                {
                    dgv.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "DateColumn",
                        HeaderText = "Date",
                        DataPropertyName = "Date"
                    });
                    dgv.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "AmountColumn",
                        HeaderText = "Amount",
                        DataPropertyName = "Amount"
                    });
                    dgv.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "CategoryColumn",
                        HeaderText = "Category",
                        DataPropertyName = "Category"
                    });
                    dgv.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "DescriptionColumn",
                        HeaderText = "Description",
                        DataPropertyName = "Description"
                    });
                    dgv.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "CurrencyColumn",
                        HeaderText = "Currency",
                        DataPropertyName = "Currency"
                    });
                }

                // Attach ColumnHeaderMouseClick event for sorting
                dgv.ColumnHeaderMouseClick += DataGridView_ColumnHeaderMouseClick;
            }
        }

        private void DataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv != null && e.ColumnIndex >= 0)
            {
                var column = dgv.Columns[e.ColumnIndex];
                var newSortProperty = column.DataPropertyName;
                var newSortDirection = _currentSortProperty == newSortProperty && _currentSortDirection == ListSortDirection.Ascending
                    ? ListSortDirection.Descending
                    : ListSortDirection.Ascending;

                // Sort and update DataGridView
                _currentSortProperty = newSortProperty;
                _currentSortDirection = newSortDirection;
                DataSorter.SortData(dgv, _dataSource, newSortProperty, newSortDirection);
                dgv.Refresh(); // Refresh DataGridView to show sorted data
            }
        }

        private void TaxPeriodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculatePaidIncomeTax();
            CalculatePaidExpenseTax();
        }
        private void CalculatePaidIncomeTax()
        {
            if (comboBoxCurrencySelection.SelectedItem == null)
            {
                MessageBox.Show("Please select a currency to display the total tax.", "Currency Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            IEnumerable<Income> selectedPeriodIncome = null;

            // Get the selected period from the combo box
            switch (TaxPeriodComboBox.SelectedItem.ToString())
            {
                case "Daily":
                    selectedPeriodIncome = _dataSource.GetDailyIncome();
                    break;
                case "Weekly":
                    selectedPeriodIncome = _dataSource.GetWeeklyIncome();
                    break;
                case "Monthly":
                    selectedPeriodIncome = _dataSource.GetMonthlyIncome();
                    break;
                case "Total":
                    selectedPeriodIncome = _dataSource.GetTotalIncome();
                    break;
                default:
                    return; // Do nothing if no valid selection is made
            }

            // Calculate the total paid tax for the selected period
            decimal totalPaidTax = 0;

            foreach (var income in selectedPeriodIncome)
            {
                decimal paidTax = income.Amount * (20m / 80m);
                totalPaidTax += paidTax;
            }

            // Display the result in txtPaidIncomeTax
            labelIncomeTax.Text = $"{totalPaidTax.ToString()} {comboBoxCurrencySelection.SelectedItem.ToString()}";
        }



        private void CalculatePaidExpenseTax()
        {
            if (comboBoxCurrencySelection.SelectedItem == null)
            {
                MessageBox.Show("Please select a currency to display the total tax.", "Currency Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            IEnumerable<Expense> selectedPeriodExpenses = null;
            UpdateBalance();
            // Get the selected period from the combo box
            switch (TaxPeriodComboBox.SelectedItem.ToString())
            {
                case "Daily":
                    selectedPeriodExpenses = _dataSource.GetDailyExpenses();
                    break;
                case "Weekly":
                    selectedPeriodExpenses = _dataSource.GetWeeklyExpenses();
                    break;
                case "Monthly":
                    selectedPeriodExpenses = _dataSource.GetMonthlyExpenses();
                    break;
                case "Total":
                    selectedPeriodExpenses = _dataSource.GetTotalExpenses();
                    break;
                default:
                    return; // Do nothing if no valid selection is made
            }

            // Calculate the total paid tax for the selected period
            decimal totalPaidTax = 0;

            foreach (var expense in selectedPeriodExpenses)
            {
                decimal paidTax = expense.CalculateTax(true);
                totalPaidTax += paidTax;
            }

            // Display the result in txtPaidExpenseTax
            labelExpenseTax.Text = $"{totalPaidTax.ToString()} {comboBoxCurrencySelection.SelectedItem.ToString()}";

            // Calculate refundable tax (15% of the total paid tax)
            decimal refundableTax = totalPaidTax * 0.15m;
            labelRefundTax.Text = $"{refundableTax.ToString()} {comboBoxCurrencySelection.SelectedItem.ToString()}";
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
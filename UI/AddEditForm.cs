using Expense_Tracking_App.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Expense_Tracking_App.UI
{
    public partial class AddEditForm : Form
    {
        private Transaction _transaction;
        private List<string> _incomeSources;
        private List<string> _expenseCategories;

        public Transaction Transaction => _transaction;

        public AddEditForm(Transaction transaction = null)
        {
            InitializeComponent();
            InitializeComboBoxes();
            _transaction = transaction;

            if (_transaction != null)
            {
                // Fill the form fields with the transaction details
                textBoxAmount.Text = _transaction.Amount.ToString();
                textBoxDescription.Text = _transaction.Description;
                comboBoxCurrency.SelectedItem = _transaction.Currency;
                dateTimePickerDate.Value = _transaction.Date;

                if (_transaction is Income income)
                {
                    comboBoxTransactionType.SelectedItem = "Income";
                    comboBoxSource.SelectedItem = income.Source;
                }
                else if (_transaction is Expense expense)
                {
                    comboBoxTransactionType.SelectedItem = "Expense";
                    comboBoxCategory.SelectedItem = expense.Category;
                }
            }
        }

        private void InitializeComboBoxes()
        {
            comboBoxTransactionType.Items.AddRange(new string[] { "Income", "Expense" });
            comboBoxCurrency.Items.AddRange(new string[] { "USD", "EUR" }); // Add more currencies as needed

            // Initialize lists
            _incomeSources = new List<string> { "Salary", "Freelance", "Investment", "Rental", "Others" };
            _expenseCategories = new List<string> { "Travel", "Food", "Utilities", "Healthcare", "Rent", "Others" };

            // Bind lists to combo boxes
            comboBoxSource.DataSource = _incomeSources;
            comboBoxCategory.DataSource = _expenseCategories;

            // Set default visibility
            textBoxSource.Visible = false;
            textBoxCategory.Visible = false;
        }

        private void comboBoxTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedType = comboBoxTransactionType.SelectedItem?.ToString();
            if (selectedType == "Income")
            {
                comboBoxSource.Visible = true;
                textBoxSource.Visible = false;
                labelSource.Visible = true;
                comboBoxCategory.Visible = false;
                textBoxCategory.Visible = false;
                labelCategory.Visible = false;
                chkIsTaxed.Visible = true;
            }
            else if (selectedType == "Expense")
            {
                comboBoxSource.Visible = false;
                textBoxSource.Visible = false;
                labelSource.Visible = false;
                comboBoxCategory.Visible = true;
                textBoxCategory.Visible = false;
                labelCategory.Visible = true;
                chkIsTaxed.Visible = false;
            }
        }

        private void comboBoxSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSource.SelectedItem?.ToString() == "Others")
            {
                textBoxSource.Visible = true;
            }
            else
            {
                textBoxSource.Visible = false;
            }
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCategory.SelectedItem?.ToString() == "Others")
            {
                textBoxCategory.Visible = true;
            }
            else
            {
                textBoxCategory.Visible = false;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBoxAmount.Text, out decimal amount) && !string.IsNullOrEmpty(textBoxDescription.Text))
            {
                // Initialize variables
                Income income = null;
                decimal finalAmount = amount;

                if (comboBoxTransactionType.SelectedItem?.ToString() == "Income")
                {
                    // Determine the specific type of income based on selected source
                    switch (comboBoxSource.SelectedItem?.ToString())
                    {
                        case "Salary":
                            income = new SalaryIncome();
                            break;
                        case "Investment":
                            income = new InvestmentIncome();
                            break;
                        case "Rental":
                            income = new RentalIncome();
                            break;
                        case "Freelance":
                            income = new FreelanceIncome();
                            break;
                        case "Others":
                            income = new OtherIncome();
                            break;
                        default:
                            income = new Income(); // Fallback to base class if type is not set
                            break;
                    }

                    if (_transaction == null)
                    {
                        // Set properties for new income
                        income.Amount = amount; // Original amount before tax
                        income.Description = textBoxDescription.Text;
                        income.Currency = comboBoxCurrency.SelectedItem?.ToString();
                        income.Date = dateTimePickerDate.Value;
                        income.Source = comboBoxSource.SelectedItem?.ToString() == "Others" ? textBoxSource.Text : comboBoxSource.SelectedItem?.ToString();
                    }
                    else
                    {
                        // Update existing income
                        income = _transaction as Income;
                        if (income != null)
                        {
                            income.Amount = amount; // Original amount before tax
                            income.Source = comboBoxSource.SelectedItem?.ToString() == "Others" ? textBoxSource.Text : comboBoxSource.SelectedItem?.ToString();
                        }
                    }

                    // Calculate the final amount based on tax
                    finalAmount = income.CalculateTax(chkIsTaxed.Checked);
                    income.Amount = finalAmount; // Update the final amount after tax

                    _transaction = income; // Assign the transaction back
                }
                else if (comboBoxTransactionType.SelectedItem?.ToString() == "Expense")
                {
                    if (_transaction == null)
                    {
                        // Create new expense
                        _transaction = new Expense
                        {
                            Amount = amount,
                            Description = textBoxDescription.Text,
                            Currency = comboBoxCurrency.SelectedItem?.ToString(),
                            Date = dateTimePickerDate.Value,
                            Category = comboBoxCategory.SelectedItem?.ToString() == "Others" ? textBoxCategory.Text : comboBoxCategory.SelectedItem?.ToString()
                        };
                    }
                    else
                    {
                        // Update existing expense
                        var expense = _transaction as Expense;
                        if (expense != null)
                        {
                            expense.Amount = amount;
                            expense.Category = comboBoxCategory.SelectedItem?.ToString() == "Others" ? textBoxCategory.Text : comboBoxCategory.SelectedItem?.ToString();
                        }
                    }
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Please enter valid data.");
            }
        }
    }
}

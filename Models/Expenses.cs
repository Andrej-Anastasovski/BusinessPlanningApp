using System;
using System.Collections.Generic;
using System.Linq;

[Serializable]
public class Expense : Transaction
{
    public string Category { get; set; }
    public decimal MonthlyLimit { get; private set; }  
    public bool Recurring { get; set; }

    // Define tax rates for various categories
    private static readonly Dictionary<string, decimal> TaxRates = new Dictionary<string, decimal>
    {
        { "Travel", 0.10m },        
        { "Food", 0.05m },          
        { "Entertainment", 0.08m }, 
        { "Healthcare", 0.12m },    
        { "Rent", 0.06m },          
        { "Other", 0.07m }          
    };

    public decimal GetAnnualExpense()
    {
        // Calculate annual expense based on recurring status
        return Recurring ? Amount * 12 : Amount;
    }



    public override string GetTransactionSummary()
    {
        return $"Category: {Category}, Amount: {Amount} {Currency}, Date: {Date.ToShortDateString()}, Recurring: {Recurring}, Monthly Limit: {MonthlyLimit}";
    }

    public void SetMonthlyLimit(decimal limit)
    {
        if (limit > 0)
        {
            MonthlyLimit = limit;
        }
    }
    public bool IsOverBudget(IEnumerable<Expense> expenses)
    {
        // Aggregate total expenses for the current month
        decimal totalMonthlyExpenses = expenses
            .Where(e => e.Date.Month == DateTime.Now.Month && e.Date.Year == DateTime.Now.Year)
            .Sum(e => e.Amount);

        // Compare the total monthly expenses against the set monthly limit
        return totalMonthlyExpenses > MonthlyLimit;
    }

    public void ApplyDiscount(decimal percentage)
    {
        // Apply discount to the expense amount
        if (percentage > 0 && percentage <= 100)
        {
            decimal discountAmount = Amount * (percentage / 100);
            Amount -= discountAmount;
        }
    }

    public decimal ConvertExpenseAmount(string toCurrency)
    {
        return ConvertCurrency(Amount, Currency, toCurrency);
    }

    // Calculate tax based on the category
    public override decimal CalculateTax(bool isTaxed)
    {
        if (TaxRates.TryGetValue(Category, out var taxRate))
        {
            return Amount * taxRate;
        }
        return 0m; // Return 0 if the category is not found in tax rates
    }


    // Override the Balance method to deduct the expense amount from the balance
    public override decimal Balance(decimal currentBalance)
    {
        return currentBalance - Amount;
    }
}

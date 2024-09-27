using System;

[Serializable]
public class Income : Transaction
{
    public string Source { get; set; }
    public string Frequency { get; set; }



    // Calculate the amount after applying tax based on whether it is taxed or not
    public override decimal CalculateTax(bool isTaxed)
    {
        if (isTaxed)
        {
            return Amount; // No tax deduction
        }
        else
        {
            return Amount * (1 - TaxRate / 100); // Deduct tax based on the overridden TaxRate
        }
    }


    // Get detailed information about the income
    public override string GetTransactionSummary()
    {
        return $"Income Source: {Source}, Amount: {Amount}, Date: {Date.ToShortDateString()}, Frequency: {Frequency}";
    }

    // Convert the income amount to a different currency
    public decimal ConvertIncomeAmount(string toCurrency)
    {
        return ConvertCurrency(Amount, Currency, toCurrency);
    }

    // Calculate the income growth based on a given growth rate
    public decimal CalculateIncomeGrowth(decimal growthRate)
    {
        return Amount * (1 + growthRate / 100);
    }

    // Override the Balance method to add the income amount to the balance
    public override decimal Balance(decimal currentBalance)
    {
        return currentBalance + Amount;
    }
}

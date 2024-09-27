using System;


    [Serializable]
    public class Transaction : IComparable<Transaction>
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Currency { get; set; }
        protected virtual decimal TaxRate => 20m;
        public virtual decimal Balance(decimal currentBalance)
        {
            return 0;
        }


     // Provides a summary of the transaction
      public virtual string GetTransactionSummary()
      {
            return $"Amount: {Amount} {Currency}, Date: {Date.ToShortDateString()}, Description: {Description}";
      }

    public virtual decimal CalculateTax(bool isTaxed)
    {
        return Amount; 
    }

    public bool IsValidTransaction()
        {
            return Amount > 0 && !string.IsNullOrEmpty(Description);
        }

        public string GetFormattedDate()
        {
            return Date.ToString("dd/MM/yyyy");
        }

        // Converts the given amount from one currency to another based on conversion rates
        public decimal ConvertCurrency(decimal amount, string fromCurrency, string toCurrency)
        {
            // Define conversion rates; can be extended for more currencies
            decimal conversionRate = fromCurrency == "USD" && toCurrency == "EUR" ? 0.85m :
                                     fromCurrency == "EUR" && toCurrency == "USD" ? 1.18m : 1m;

            return Math.Round(amount * conversionRate, 1); // Round to 1 decimal place
        }

        // Converts the transaction amount to a new currency and updates the currency
        public void ConvertTransactionCurrency(string toCurrency)
        {
            if (Currency == toCurrency) return;

            // Convert amount to the new currency
            Amount = ConvertCurrency(Amount, Currency, toCurrency);

            // Update the currency to the new currency
            Currency = toCurrency;
        }

        // Implementation of IComparable<Transaction> to compare transactions by date and amount
        public int CompareTo(Transaction other) 
        {
            int dateComparison = Date.CompareTo(other.Date);
            if (dateComparison == 0)
            {
                return Amount.CompareTo(other.Amount);
            }
            return dateComparison;
        }

        // Applies an adjustment to the transaction amount
        public void ApplyAdjustment(decimal amount)
        {
            Amount += amount;
        }
}
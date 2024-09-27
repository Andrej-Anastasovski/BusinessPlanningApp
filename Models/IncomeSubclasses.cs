using System;

[Serializable]
public class SalaryIncome : Income
    {
        public string EmployerName { get; set; }
        public string Position { get; set; }
        protected override decimal TaxRate => 25m; // Example: 25% for Salary


    public override string GetTransactionSummary()
    {
            return $"Salary from {EmployerName} as {Position}, Amount: {Amount}, Date: {Date}, Frequency: {Frequency}, Tax Rate: {TaxRate}%";
        }

        public decimal ConvertSalaryIncomeAmount(string toCurrency)
        {
            return ConvertIncomeAmount(toCurrency);
        }
    }

    public class InvestmentIncome : Income
    {
        public string InvestmentType { get; set; }
        public decimal ReturnsRate { get; set; }
        protected override decimal TaxRate => 18m; // Example: 18% for Investments

     public override string GetTransactionSummary()
    {
            return $"Investment Type: {InvestmentType}, Return Rate: {ReturnsRate}%, Amount: {Amount}, Date: {Date}, Frequency: {Frequency}, Tax Rate: {TaxRate}%";
        }

        public decimal ConvertInvestmentIncomeAmount(string toCurrency)
        {
            return ConvertIncomeAmount(toCurrency);
        }
    }

    public class RentalIncome : Income
    {
        public string PropertyName { get; set; }
        public string RentalPeriod { get; set; }
        protected override decimal TaxRate => 22m; // Example: 22% for Rental Income

    public override string GetTransactionSummary()
    {
            return $"Rental from {PropertyName}, Rental Period: {RentalPeriod}, Amount: {Amount}, Date: {Date}, Frequency: {Frequency}, Tax Rate: {TaxRate}%";
        }

        public decimal ConvertRentalIncomeAmount(string toCurrency)
        {
            return ConvertIncomeAmount(toCurrency);
        }
    }

    public class FreelanceIncome : Income
    {
        public string ClientName { get; set; }
        public string ProjectDescription { get; set; }
        protected override decimal TaxRate => 24m; // Example: 20% for Freelance Income

    public override string GetTransactionSummary()
    {
            return $"Freelance work for {ClientName}, Project: {ProjectDescription}, Amount: {Amount}, Date: {Date}, Frequency: {Frequency}, Tax Rate:  {TaxRate}%";
        }

        public decimal ConvertFreelanceIncomeAmount(string toCurrency)
        {
            return ConvertIncomeAmount(toCurrency);
        }
    }

    public class OtherIncome : Income
    {
        public string CustomSource { get; set; }
        protected override decimal TaxRate => 20m; // Example: 22% for Rental Income

    public override string GetTransactionSummary()
    {
            return $"Other Income Source: {CustomSource}, Amount: {Amount}, Date: {Date}, Frequency: {Frequency}, Tax Rate: {TaxRate}%";
        }

        public decimal ConvertOtherIncomeAmount(string toCurrency)
        {
            return ConvertIncomeAmount(toCurrency);
        }
    }


using System;

namespace ProjectName.Models
{
    [Serializable]
    public class TravelExpense : Expense
    {
        public string Destination { get; set; }
        public string ModeOfTravel { get; set; }

        public override string GetTransactionSummary()
        {
            return $"Category: Travel, Destination: {Destination}, Mode of Travel: {ModeOfTravel}, Amount: {Amount} {Currency}, Date: {Date.ToShortDateString()}, Recurring: {Recurring}";
        }

        public decimal ConvertTravelExpenseAmount(string toCurrency)
        {
            return ConvertExpenseAmount(toCurrency);
        }
    }

    public class FoodExpense : Expense
    {
        public string RestaurantName { get; set; }
        public string MealType { get; set; }

        public override string GetTransactionSummary()
        {
            return $"Category: Food, Restaurant: {RestaurantName}, Meal Type: {MealType}, Amount: {Amount} {Currency}, Date: {Date.ToShortDateString()}, Recurring: {Recurring}";
        }

        public decimal ConvertFoodExpenseAmount(string toCurrency)
        {
            return ConvertExpenseAmount(toCurrency);
        }
    }

    public class EntertainmentExpense : Expense
    {
        public string EventName { get; set; }
        public string Venue { get; set; }

        public override string GetTransactionSummary()
        {
            return $"Category: Entertainment, Event: {EventName}, Venue: {Venue}, Amount: {Amount} {Currency}, Date: {Date.ToShortDateString()}, Recurring: {Recurring}";
        }

        public decimal ConvertEntertainmentExpenseAmount(string toCurrency)
        {
            return ConvertExpenseAmount(toCurrency);
        }
    }

    public class HealthcareExpense : Expense
    {
        public string ProviderName { get; set; }
        public string TreatmentType { get; set; }

        public override string GetTransactionSummary()
        {
            return $"Category: Healthcare, Provider: {ProviderName}, Treatment: {TreatmentType}, Amount: {Amount} {Currency}, Date: {Date.ToShortDateString()}, Recurring: {Recurring}";
        }

        public decimal ConvertHealthcareExpenseAmount(string toCurrency)
        {
            return ConvertExpenseAmount(toCurrency);
        }
    }

    public class RentExpense : Expense
    {
        public string RentalProperty { get; set; }
        public string LeasePeriod { get; set; }

        public override string GetTransactionSummary()
        {
            return $"Category: Rent, Property: {RentalProperty}, Lease Period: {LeasePeriod}, Amount: {Amount} {Currency}, Date: {Date.ToShortDateString()}, Recurring: {Recurring}";
        }

        public decimal ConvertRentExpenseAmount(string toCurrency)
        {
            return ConvertExpenseAmount(toCurrency);
        }
    }

    public class OtherExpense : Expense
    {
        public string CustomCategory { get; set; }

        public override string GetTransactionSummary()
        {
            return $"Category: Other ({CustomCategory}), Amount: {Amount} {Currency}, Date: {Date.ToShortDateString()}, Recurring: {Recurring}";
        }

        public decimal ConvertOtherExpenseAmount(string toCurrency)
        {
            return ConvertExpenseAmount(toCurrency);
        }
    }
}

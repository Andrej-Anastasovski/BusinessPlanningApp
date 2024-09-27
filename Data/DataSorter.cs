using Expense_Tracking_App.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Expense_Tracking_App
{
    public static class DataSorter
    {
        public static void SortData(DataGridView dgv, TransactionDataSource dataSource, string sortProperty, ListSortDirection sortDirection)
        {
            if (dgv.Name.Contains("Income"))
            {
                var data = dataSource.GetTotalIncome().Cast<Income>();
                var sortedData = SortTransactions(data, sortProperty, sortDirection);
                dgv.DataSource = new BindingList<Income>(sortedData.ToList());
            }
            else
            {
                var data = dataSource.GetTotalExpenses().Cast<Expense>();
                var sortedData = SortTransactions(data, sortProperty, sortDirection);
                dgv.DataSource = new BindingList<Expense>(sortedData.ToList());
            }
        }

        private static IEnumerable<T> SortTransactions<T>(IEnumerable<T> transactions, string sortProperty, ListSortDirection sortDirection) where T : Transaction
        {
            var property = typeof(T).GetProperty(sortProperty);
            if (property != null)
            {
                return sortDirection == ListSortDirection.Ascending
                    ? transactions.OrderBy(t => property.GetValue(t, null))
                    : transactions.OrderByDescending(t => property.GetValue(t, null));
            }
            return transactions;
        }
    }
}
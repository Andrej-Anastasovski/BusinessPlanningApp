using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Expense_Tracking_App.Data
{
    public class TransactionDataSource
    {
        private BindingList<Transaction> _transactions;
        private Stack<List<Transaction>> _undoStack = new Stack<List<Transaction>>();
        private Stack<List<Transaction>> _redoStack = new Stack<List<Transaction>>();
        private List<Transaction> transactions = new List<Transaction>();
        private decimal _monthlyLimit;
        //public BindingList<Transaction> Transactions => _transactions;

        public TransactionDataSource(BindingList<Transaction> transactions)
        {
            _transactions = transactions;
        }


        public void SetTransactions(IEnumerable<Transaction> transactions)
        {
            _transactions.Clear();
            foreach (var transaction in transactions)
            {
                _transactions.Add(transaction);
            }
            Console.WriteLine($"Transactions Set: {_transactions.Count}"); // Debugging line
        }



        // Get expenses and income for different periods
        public IEnumerable<Income> GetDailyIncome()
        {
            return _transactions.OfType<Income>()
                                .Where(t => t.Date.Date == DateTime.Now.Date);
        }

        public IEnumerable<Income> GetWeeklyIncome()
        {
            var startOfWeek = DateTime.Now.Date.AddDays(-(int)DateTime.Now.DayOfWeek);
            return _transactions.OfType<Income>()
                                .Where(t => t.Date >= startOfWeek && t.Date < startOfWeek.AddDays(7));
        }

        public IEnumerable<Income> GetMonthlyIncome()
        {
            var startOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            return _transactions.OfType<Income>()
                                .Where(t => t.Date >= startOfMonth && t.Date < startOfMonth.AddMonths(1));
        }

        public IEnumerable<Income> GetTotalIncome()
        {
            return _transactions.OfType<Income>();
        }

        public IEnumerable<Expense> GetDailyExpenses()
        {
            return _transactions.OfType<Expense>()
                                .Where(t => t.Date.Date == DateTime.Now.Date);
        }

        public IEnumerable<Expense> GetWeeklyExpenses()
        {
            var startOfWeek = DateTime.Now.Date.AddDays(-(int)DateTime.Now.DayOfWeek);
            return _transactions.OfType<Expense>()
                                .Where(t => t.Date >= startOfWeek && t.Date < startOfWeek.AddDays(7));
        }

        public IEnumerable<Expense> GetMonthlyExpenses()
        {
            var startOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            return _transactions.OfType<Expense>()
                                .Where(t => t.Date >= startOfMonth && t.Date < startOfMonth.AddMonths(1));
        }

        public IEnumerable<Expense> GetTotalExpenses()
        {
            return _transactions.OfType<Expense>();
        }

        private void PushStateToUndoStack()
        {
            // Save the current state of transactions to the undo stack
            var snapshot = _transactions.ToList();
            _undoStack.Push(snapshot);
            // Clear the redo stack since new action invalidates redo history
            _redoStack.Clear();
        }

        public void AddTransaction(Transaction transaction)
        {
            PushStateToUndoStack();
            _transactions.Add(transaction);
        }

        public void UpdateTransaction(Transaction oldTransaction, Transaction newTransaction)
        {
            PushStateToUndoStack();
            int index = _transactions.IndexOf(oldTransaction);
            if (index >= 0)
            {
                _transactions[index] = newTransaction;
            }
        }

        public void RemoveTransaction(Transaction transaction)
        {
            PushStateToUndoStack();
            _transactions.Remove(transaction);
        }

        public void Undo()
        {
            if (_undoStack.Count > 0)
            {
                // Save the current state to redo stack before restoring
                var snapshot = _transactions.ToList();
                _redoStack.Push(snapshot);
                // Restore the last state from the undo stack
                var previousState = _undoStack.Pop();
                _transactions = new BindingList<Transaction>(previousState);
            }
        }

        public void Redo()
        {
            if (_redoStack.Count > 0)
            {
                // Save the current state to undo stack before restoring
                var snapshot = _transactions.ToList();
                _undoStack.Push(snapshot);
                // Restore the last state from the redo stack
                var nextState = _redoStack.Pop();
                _transactions = new BindingList<Transaction>(nextState);
            }
        }
    }
}

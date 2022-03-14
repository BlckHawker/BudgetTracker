using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker
{
    /// <summary>
    /// Author: Nya Bentley
    /// Date: 3/14/22
    /// Purpose: Gives a summary of a transaction
    /// </summary>
    class Transaction
    {
        //How much money was deposited/withdrawn
        private Decimal Amount { get; set; }

        //A reminder for why this transaction occured
        private string Comment { get; set; }

        //the date the transaction occured
        private DateTime Date {get; set;}

        /// <summary>
        /// Creates a transaction with no comment and the date
        /// being the current time
        /// </summary>
        /// <param name="amount"></param>
        public Transaction(Decimal amount) 
        : this(amount, "", DateTime.Now)
        {

        }

        /// <summary>
        /// Creates a transaction with a comment with the date
        /// being the current time
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="comment"></param>
        public Transaction(Decimal amount, string comment)
        : this(amount, comment, DateTime.Now)
        { 
        
        }

        /// <summary>
        /// Creates a transaction given an amount, comment, and date and time
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="comment"></param>
        /// <param name="date"></param>
        public Transaction(Decimal amount, string comment, DateTime date)
        {
            Amount = amount;
            Comment = comment;
            Date = date;
        }

        public string PrintTransaction()
        {
            if (Amount > 0)
            {
                return $"{Date}: Deposited {Amount}. {Comment}";
            }

            return $"{Date}: Withdrew {Amount}. {Comment}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker
{
    //Gives information about what was bought,
    //how much it cost, and when it happen
    class Transaction
    {
        public string Comment { get; }

        private Decimal Amount { get; }

        private DateTime Time { get; }

        public Transaction(Decimal amount)
        {
            Comment = "";
            Amount = amount;
            Time = DateTime.Now;
        }

        public Transaction(Decimal amount, DateTime date)
        {
            Comment = "";
            Amount = amount;
            Time = date;
        }

        public Transaction(Decimal amount, string comment)
        {
            Comment = comment;
            Amount = amount;
            Time = DateTime.Now;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="comment">the reason of this transaction</param>
        /// <param name="amount">How much money the item cost minimum amount is 0.01</param>
        /// <param name="time">The date and time the transaction happen</param>
        public Transaction(Decimal amount, string comment, DateTime time)
        {
            Comment = comment;
            Amount = amount;
            Time = time;
        }


        /// <summary>
        /// Gives a summary of this transaction
        /// </summary>
        public string PrintTransactionInfo()
        {
            //depositing money
            if (Amount > 0)
            { 
                return $"{Time}: Deposited {Amount}";
            }

            //withdrawing money
            return $"{Time}: Withdrew {Amount}";
        }
    }
}

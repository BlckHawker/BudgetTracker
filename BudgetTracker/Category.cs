using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker
{
    /// <summary>
    /// Represents a subsection of where the user's money can go
    /// </summary>
    class Category
    {
        //Name of the category
        private string Name { get; }

        //Current amount of money in category
        private Decimal CurrentFunds { get; set; }

        //The percentage of money this category takes when splitting money 
        //[has to between 1 - 100 inclusivly]
        private Decimal Percentage { get; }

        //A list of transaction that has happen in this category
        private List<Transaction> TransactionList { get; }

        /// </summary>
        /// <param name="name">The name of this category</param>
        /// <param name="startingFunds">The percentage of depoisted money this category to its current funds</param>
        /// <param name="percetnage">The percentage of depoisted money this cateogry will take. (Has to be between 1 and 100 inclusivly)</param>
        public Category(string name, Decimal startingFunds, Decimal percetnage)
        {
            Name = name;
            CurrentFunds = startingFunds;
            Percentage = percetnage;
            TransactionList = new List<Transaction>();

            Console.WriteLine($"The category {name} has been created with a starting balance of {startingFunds}");
        }


        /// <summary>
        /// Increases the amount of money to this category by taking a percentage of the given amount
        /// </summary>
        /// <param name="amount">The amount of money that was added to total funds</param
        public string Deposit(Decimal amount, DateTime date, string comment)
        {
            //the amount of money this category will take
            //will always round down, so price may vary a little

            Decimal categoryAmount = decimal.Round(amount * Percentage, 2, MidpointRounding.ToEven);

            CurrentFunds += categoryAmount;

            Transaction transaction = new Transaction(comment, amount, date);

            TransactionList.Add(transaction);

            return $"{transaction.PrintTransactionInfo()} to {Name}, {transaction.Comment}";
        }

        public string Withdraw(Decimal amount, DateTime date, string comment)
        {
            CurrentFunds -= amount;
        }
    }
}

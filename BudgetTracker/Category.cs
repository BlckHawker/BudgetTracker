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
        private string Name { get; }

        private Decimal CurrentFunds { get; set; }

        private Decimal Percentage { get; }

        private List<Transaction> TransactionList { get; }

        /// </summary>
        /// <param name="name">The name of this category</param>
        /// <param name="startingFunds">The percentage of depoisted money this category to its current funds</param>
        /// <param name="percetnage">The percentage of depoisted money this cateogry will take. (Has to be between 0 and 1 inclusivly)</param>
        public Category(string name, Decimal startingFunds, Decimal percetnage)
        {
            Name = name;
            CurrentFunds = startingFunds;
            Percentage = percetnage;
            TransactionList = new List<Transaction>();

            Console.WriteLine($"The category {name} has been created with a starting balance of {startingFunds}");
        }


        /// 
        /// <summary>
        /// Will take a percetange of the total money and deposit it to this category
        /// </summary>
        /// <param name="name">where the money came from or the reasoning why it's being deposited</param>
        /// <param name="totalAmount">The amount of money that was added to total funds</param
        /// <param name="date">the date the money was added</param>
        public void AddFunds(string name, Decimal totalAmount, DateTime date)
        {
            //the amount of money this category will take
            //will always round down, so price may vary a little

            Decimal categoryAmount = decimal.Round(totalAmount * Percentage, 2, MidpointRounding.ToEven);

            CurrentFunds += categoryAmount;

            TransactionList.Add(new Transaction(name, categoryAmount, date));

            Console.WriteLine($"Added {categoryAmount} to {Name} category. {Name} now has {CurrentFunds}.");
        }
    }
}

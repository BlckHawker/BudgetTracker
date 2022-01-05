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
        string Name { get; }

        Decimal CurrentFunds { get; set; }

        Decimal Percentage { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">The name of this category</param>
        /// <param name="startingFunds">The percentage of depoisted money this category to its current funds</param>
        /// <param name="percetnage">The percentage of depoisted money this cateogry will take. (Has to be between 0 and 1 inclusivly)</param>
        public Category(string name, Decimal startingFunds, Decimal percetnage)
        {
            Name = name;
            CurrentFunds = startingFunds;
            Percentage = percetnage;
        }

        /// <summary>
        /// Will take a percetange of the total money and deposit it to this category
        /// </summary>
        /// <param name="totalAmount">The amount of money that was added to total funds</param>
        public void AddFunds(Decimal totalAmount)
        {
            CurrentFunds += totalAmount * (Percentage);
            //will always round down, so price may vary
        }

    }
}

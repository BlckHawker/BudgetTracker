using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker
{
    /// <summary>
    /// Name: Nya Bentley
    /// Date: 3/23/22
    /// Purpose: An object that holds a collection of categories
    /// </summary>
    public class Plan
    {
        //the name of the plan
        private string Name;

        //the amount of money the plan has
        Decimal TotalMoney;

        //all the categories the plan has
        public List<Category> CategoryList { get; }

        /// <summary>
        /// Creates a plan with one category that takes 100 percent of the money
        /// </summary>
        /// <param name="name">name of the plan</param>
        public Plan(string name)
        {
            Name = name;
            TotalMoney = 0;

            CategoryList = new List<Category>();

            CategoryList.Add(new Category("Default", 100));
        }


        /// <summary>
        /// Deposits and splits the money into each category
        /// </summary>
        /// <param name="amount">the amount of money that is being added to the plan</param>
        /// <param name="comment">the comment that will be added to each transaction</param>
        /// <returns>the amount of money that didn't fit in a certain category</returns>
        public Decimal Deposit(Decimal amount, string comment)
        {
            //increase total amount of money
            TotalMoney += amount;

            Decimal moneyDeposited = 0;
            
            foreach (Category category in CategoryList)
            {
                Decimal categoryAmount = CalculateDepositingAmount(amount, category.Percentage);

                category.Deposit(categoryAmount, comment);

                moneyDeposited += categoryAmount;
            }

            //return any money left over
            return amount - moneyDeposited;
        }

        /// <summary>
        /// Deposits money to one specifc category
        /// </summary>
        /// <param name="amount">the maount of money that will be added to a category</param>
        /// <param name="category">which category the money will be added</param>
        /// <param name="comment">the comment that will be added to the transaction</param>
        public void Deposit(Decimal amount, Category category, string comment)
        {
            TotalMoney += amount;

            category.Deposit(amount, comment);
        }

        public void Withdraw(Decimal amount, Category category, string comment)
        {
            TotalMoney -= amount;

            category.Withdraw(amount, comment);
        }

        /// <summary>
        /// Figures out how much money should be added to a certain category
        /// </summary>
        /// <param name="amount">the total amount of money being depostied</param>
        /// <param name="categoryPercentage">the percentage of money this category will take</param>
        /// <returns>the amount of money that should be added to this category</returns>
        public Decimal CalculateDepositingAmount(Decimal amount, Decimal categoryPercentage)
        {
            //calcuatlate how much money is added to each category
            Decimal categoryAmount = amount * categoryPercentage;

            //round down
            categoryAmount = Math.Floor(categoryAmount);

            //get to the decimal places
            categoryAmount /= 100;

            return categoryAmount;
        }
    }
}

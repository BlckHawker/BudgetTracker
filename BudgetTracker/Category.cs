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
    /// Purpose: Creaetes a sub section that will hold a list of tranastcion
    ///          Kinda like its own budget
    /// </summary>
    class Category
    {
        //name of the category
        private string Name;

        //the current amount of money this category has
        private Decimal Money;

        //the amount of money that will be deposited into this category
        //(can only be between 0 and 100 inclusivly)
        public Decimal Percentage { get; }

        //a list of all transaction that happen in this category
        private List<Transaction> TransactionList;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">the name of the category</param>
        /// <param name="percentage">the amount of money that will be deposited into this category
        ///(can only be between 0 and 100 inclusivly)</param>
        public Category(string name, Decimal percentage)
        {
            Name = name;
            Percentage = percentage;
            Money = 0;

            TransactionList = new List<Transaction>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">the name of the category</param>
        /// <param name="percentage">the amount of money that will be deposited into this category
        /// (can only be between 0 and 100 inclusivly)</param>
        /// <param name="amount">the amount of money the category will start with</param>
        public Category(string name, Decimal percentage, Decimal amount) : this(name, percentage)
        {
            Deposit(amount, "Initial Amount");
        }

        /// <summary>
        /// Deposits money into this category
        /// </summary>
        /// <param name="amount">the amount of money to take</param>
        /// <returns></returns>
        public Transaction Deposit(Decimal amount)
        {
            Transaction t = new Transaction(amount);

            TransactionList.Add(t);

            return t;
        }

        public Transaction Deposit(Decimal amount, string comment)
        {
            Transaction t = new Transaction(amount, comment);

            TransactionList.Add(t);

            return t;
        }

        public Transaction Deposit(Decimal amount, DateTime dateTime)
        {
            Transaction t = new Transaction(amount, dateTime);

            TransactionList.Add(t);

            return t;
        }

        public Transaction Deposit(Decimal amount, string comment, DateTime dateTime)
        {
            Transaction t = new Transaction(amount, comment, dateTime);

            TransactionList.Add(t);

            return t;
        }

        public Transaction Withdraw(Decimal amount)
        {
            return Deposit(-amount);
        }

        public Transaction Withdraw(Decimal amount, string comment)
        {
            return Deposit(-amount, comment);
        }

        public Transaction Withdraw(Decimal amount, DateTime dateTime)
        {
            return Deposit(-amount, dateTime);
        }

        public Transaction Withdraw(Decimal amount, string comment, DateTime dateTime)
        {
            return Deposit(-amount, comment, dateTime);
        }
    }
}

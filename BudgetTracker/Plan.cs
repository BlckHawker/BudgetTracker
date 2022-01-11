using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker
{
    class Plan
    {
        private string Name { get; }

        private Decimal TotalMoney { get; }

        private Decimal TotalPercentage { get; }

        private List<Category> CategoryList { get; }

        public Plan(string name)
        {
            Name = name;
            TotalMoney = 0;
            CategoryList = new List<Category>();
            CategoryList.Add(new Category("Default", 0, 100));
            TotalPercentage = 100;
        }

        public string Deposit(Decimal amount, string comment)
        { }

        public string Deposit(Decimal amount, Category category, string comment)
        { }
    }
}

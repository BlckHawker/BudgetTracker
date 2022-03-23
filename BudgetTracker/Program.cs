using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetTracker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LoadCreateForm());

            Transaction testTransaction = new Transaction(-100, "Test comment", new DateTime(2022, 2, 12));

            Console.WriteLine("\n" + testTransaction.PrintTransactionInfo() + "\n"); 
        }
    }
}
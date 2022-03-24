using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetTracker
{
    public partial class ChangeAllPercentagesForm : Form
    {
        Dictionary<Category, decimal> CategoryDecimalDictionary;
        Category currentCategory;
        Decimal RemainingPercentage;

        public ChangeAllPercentagesForm(Category category, Decimal percentage, Decimal remainingPercentage, Dictionary<Category, decimal> categoryDecimalDictionary)
        {
            InitializeComponent();

            CategoryDecimalDictionary = categoryDecimalDictionary;
            currentCategory = category;
            RemainingPercentage = remainingPercentage;

            categoryNameLabel.Text = $"Enter percentage of {category.Name}";
            percentageLabel.Text = $"Currently at {percentage}%";
            percentageRemainingLabel.Text = $"Percentage Remaining: {remainingPercentage}";

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            string errorCaption = "Change Percentage Error";
            //FIX THIS
            Decimal percentage;
            try
            {
                percentage = Decimal.Parse(percentageTextBox.Text);
            }

            catch
            {
                MessageBox.Show("Percentage must be a number", errorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //must be between 0 and the remaining percentage
            if (percentage < 0 || percentage > RemainingPercentage)
            {
                MessageBox.Show("Percentage must be between 0 and the remaining percentage", errorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CategoryDecimalDictionary[currentCategory] = percentage;

            this.Close();
        }
    }
}

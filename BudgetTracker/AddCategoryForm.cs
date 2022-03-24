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
    public partial class AddCategoryForm : Form
    {
        private Plan Plan;

        /// <summary>
        /// Will possibly add a new Category to a plan
        /// </summary>
        /// <param name="plan">The plan that possibly will have a new category added to it</param>
        public AddCategoryForm(Plan plan)
        {
            InitializeComponent();
            Plan = plan;
            categoryNameTextBox.Text = "";
            percentageTextBox.Text = "";
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            string errorCaption = "Adding Category Error";

            //can't have a blank category name
            if (categoryNameTextBox.Text == "")
            { 
                MessageBox.Show("Can't have a blank category name", errorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Decimal percentage;

            //percentage must be a number
            try
            {
                percentage = Decimal.Parse(percentageTextBox.Text);
            }

            catch
            { 
                MessageBox.Show("Percentage must be a number", errorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //check if the sum of all percentages (including this one) is less than 100

            Decimal percentageTotal = 0;

            foreach(Category category in Plan.CategoryList)
            {
                percentageTotal += category.Percentage;
            }

            percentageTotal += percentage;

            if (percentageTotal != 100)
            {
                //edit each category percerntage's so the percentage total is 100

                MessageBox.Show($"Sum of category percentages must be 100. Currently at {percentageTotal}.\nPlease edit all categories' percentages", errorCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

                Dictionary<Category, Decimal> categoryDecimalDictionary = new Dictionary<Category, decimal>();

                foreach (Category category in Plan.CategoryList)
                {
                    categoryDecimalDictionary.Add(category, 0m);
                }

                Decimal totalPercentageRemaining = 100m;

                var first = categoryDecimalDictionary.First();

                Category firstCatgory = first.Key;

                ChangeAllPercentagesForm changeAllPercentagesForm = new ChangeAllPercentagesForm(firstCatgory, categoryDecimalDictionary[firstCatgory], totalPercentageRemaining, categoryDecimalDictionary);

                changeAllPercentagesForm.ShowDialog();

                totalPercentageRemaining -= categoryDecimalDictionary[firstCatgory];

                foreach(Category category in Plan.CategoryList)
                {
                    if (category == firstCatgory)
                    {
                        continue;
                    }

                    changeAllPercentagesForm = new ChangeAllPercentagesForm(firstCatgory, categoryDecimalDictionary[firstCatgory], totalPercentageRemaining, categoryDecimalDictionary);

                    changeAllPercentagesForm.ShowDialog();

                    totalPercentageRemaining -= categoryDecimalDictionary[firstCatgory];
                }

                //have the new category have the remaining percentage

                DialogResult results = MessageBox.Show($"The new category, {categoryNameTextBox.Text}, will take a percentage of {totalPercentageRemaining} of all future transactions. Is this okay?\nSaying no will delete this new category and return you to the Plan Overview form", "Adding Category", MessageBoxButtons.YesNo);

                if (results == DialogResult.Yes)
                {
                    Plan.CategoryList.Add(new Category(categoryNameTextBox.Text, totalPercentageRemaining));
                }

                this.Close();
            }


            else
            {
                if (results == DialogResult.Yes)
                {
                    Plan.CategoryList.Add(new Category(categoryNameTextBox.Text, totalPercentageRemaining));
                }

                this.Close();
            }




            //percentage has to be between 0 and 100 percent inclusivly
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}

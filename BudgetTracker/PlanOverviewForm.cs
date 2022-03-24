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
    public partial class PlanOverviewForm : Form
    {
        Plan Plan;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="plan">The plan that is being worked in</param>
        public PlanOverviewForm(Plan plan)
        {
            InitializeComponent();
            Plan = plan;
        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            AddCategoryForm addCategoryForm = new AddCategoryForm();

            addCategoryForm.ShowDialog();
        }
    }
}

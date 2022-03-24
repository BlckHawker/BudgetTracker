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
    public partial class CreatePlanForm : Form
    {
        public CreatePlanForm()
        {
            InitializeComponent();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            //can't have plan name be blank

            if (planNameTextBox.Text == "")
            {
                MessageBox.Show("Can't have plan name be blank", "Create Plan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Plan newPlan = new Plan(planNameTextBox.Text);

            PlanOverviewForm planOverviewForm = new PlanOverviewForm(newPlan);


            this.Hide();
            planOverviewForm.Show();
        }
    }
}

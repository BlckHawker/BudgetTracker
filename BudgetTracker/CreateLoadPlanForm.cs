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
    public partial class CreateLoadPlanForm : Form
    {
        public CreateLoadPlanForm()
        {
            InitializeComponent();
        }

        private void createPlanButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            CreatePlanForm createPlanForm = new CreatePlanForm();
            createPlanForm.Show();
        }
    }
}


namespace BudgetTracker
{
    partial class CreateLoadPlanForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.createPlanButton = new System.Windows.Forms.Button();
            this.LoadPlanButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createPlanButton
            // 
            this.createPlanButton.Location = new System.Drawing.Point(80, 44);
            this.createPlanButton.Name = "createPlanButton";
            this.createPlanButton.Size = new System.Drawing.Size(103, 42);
            this.createPlanButton.TabIndex = 0;
            this.createPlanButton.Text = "Create Plan";
            this.createPlanButton.UseVisualStyleBackColor = true;
            this.createPlanButton.Click += new System.EventHandler(this.createPlanButton_Click);
            // 
            // LoadPlanButton
            // 
            this.LoadPlanButton.Location = new System.Drawing.Point(80, 116);
            this.LoadPlanButton.Name = "LoadPlanButton";
            this.LoadPlanButton.Size = new System.Drawing.Size(103, 42);
            this.LoadPlanButton.TabIndex = 1;
            this.LoadPlanButton.Text = "Load Plan";
            this.LoadPlanButton.UseVisualStyleBackColor = true;
            // 
            // CreateLoadPlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 183);
            this.Controls.Add(this.LoadPlanButton);
            this.Controls.Add(this.createPlanButton);
            this.Name = "CreateLoadPlanForm";
            this.Text = "CreateLoadPlanForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createPlanButton;
        private System.Windows.Forms.Button LoadPlanButton;
    }
}
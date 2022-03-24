
namespace BudgetTracker
{
    partial class ChangeAllPercentagesForm
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
            this.categoryNameLabel = new System.Windows.Forms.Label();
            this.percentageLabel = new System.Windows.Forms.Label();
            this.percentageRemainingLabel = new System.Windows.Forms.Label();
            this.percentageTextBox = new System.Windows.Forms.TextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // categoryNameLabel
            // 
            this.categoryNameLabel.AutoSize = true;
            this.categoryNameLabel.Location = new System.Drawing.Point(81, 29);
            this.categoryNameLabel.Name = "categoryNameLabel";
            this.categoryNameLabel.Size = new System.Drawing.Size(242, 17);
            this.categoryNameLabel.TabIndex = 0;
            this.categoryNameLabel.Text = "Enter percentage of {CategoryName}";
            // 
            // percentageLabel
            // 
            this.percentageLabel.AutoSize = true;
            this.percentageLabel.Location = new System.Drawing.Point(95, 67);
            this.percentageLabel.Name = "percentageLabel";
            this.percentageLabel.Size = new System.Drawing.Size(179, 17);
            this.percentageLabel.TabIndex = 1;
            this.percentageLabel.Text = "Currently at {percentage}%";
            // 
            // percentageRemainingLabel
            // 
            this.percentageRemainingLabel.AutoSize = true;
            this.percentageRemainingLabel.Location = new System.Drawing.Point(64, 109);
            this.percentageRemainingLabel.Name = "percentageRemainingLabel";
            this.percentageRemainingLabel.Size = new System.Drawing.Size(242, 17);
            this.percentageRemainingLabel.TabIndex = 2;
            this.percentageRemainingLabel.Text = "Percentage Remaining: {percentage}";
            // 
            // percentageTextBox
            // 
            this.percentageTextBox.Location = new System.Drawing.Point(135, 149);
            this.percentageTextBox.Name = "percentageTextBox";
            this.percentageTextBox.Size = new System.Drawing.Size(100, 22);
            this.percentageTextBox.TabIndex = 3;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(135, 194);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(99, 30);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // ChangeAllPercentagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 236);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.percentageTextBox);
            this.Controls.Add(this.percentageRemainingLabel);
            this.Controls.Add(this.percentageLabel);
            this.Controls.Add(this.categoryNameLabel);
            this.Name = "ChangeAllPercentagesForm";
            this.Text = "ChangeAllPercentagesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label categoryNameLabel;
        private System.Windows.Forms.Label percentageLabel;
        private System.Windows.Forms.Label percentageRemainingLabel;
        private System.Windows.Forms.TextBox percentageTextBox;
        private System.Windows.Forms.Button nextButton;
    }
}
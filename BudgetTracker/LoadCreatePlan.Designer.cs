
namespace BudgetTracker
{
    partial class LoadCreateForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the budget tracker. Would you like \r\nto create a new plan or load an o" +
    "ld one?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(94, 64);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(127, 66);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(94, 216);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(127, 66);
            this.loadButton.TabIndex = 2;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // LoadCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 327);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.label1);
            this.Name = "LoadCreateForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button loadButton;
    }
}
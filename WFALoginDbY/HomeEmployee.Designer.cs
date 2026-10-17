namespace WFALoginDbY
{
    partial class HomeEmployee
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
            this.pnlHomeEmployee = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblWelcomeEmployee = new System.Windows.Forms.Label();
            this.pnlHomeEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHomeEmployee
            // 
            this.pnlHomeEmployee.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlHomeEmployee.Controls.Add(this.btnNext);
            this.pnlHomeEmployee.Controls.Add(this.btnExit);
            this.pnlHomeEmployee.Controls.Add(this.lblWelcomeEmployee);
            this.pnlHomeEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHomeEmployee.Location = new System.Drawing.Point(0, 0);
            this.pnlHomeEmployee.Name = "pnlHomeEmployee";
            this.pnlHomeEmployee.Size = new System.Drawing.Size(680, 367);
            this.pnlHomeEmployee.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNext.AutoSize = true;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(350, 226);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(91, 42);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.AutoSize = true;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(215, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 42);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblWelcomeEmployee
            // 
            this.lblWelcomeEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelcomeEmployee.AutoSize = true;
            this.lblWelcomeEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeEmployee.Location = new System.Drawing.Point(225, 69);
            this.lblWelcomeEmployee.Name = "lblWelcomeEmployee";
            this.lblWelcomeEmployee.Size = new System.Drawing.Size(203, 25);
            this.lblWelcomeEmployee.TabIndex = 3;
            this.lblWelcomeEmployee.Text = "Welcome Employee";
            // 
            // HomeEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 367);
            this.Controls.Add(this.pnlHomeEmployee);
            this.Name = "HomeEmployee";
            this.Text = "HomeEmployee";
            this.pnlHomeEmployee.ResumeLayout(false);
            this.pnlHomeEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHomeEmployee;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblWelcomeEmployee;
    }
}
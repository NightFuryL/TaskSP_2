namespace ParentWinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRunWait = new Button();
            btnRunOrKill = new Button();
            btnCalc = new Button();
            btnSearch = new Button();
            txtOutput = new TextBox();
            SuspendLayout();
            // 
            // btnRunWait
            // 
            btnRunWait.Location = new Point(12, 12);
            btnRunWait.Name = "btnRunWait";
            btnRunWait.Size = new Size(776, 29);
            btnRunWait.TabIndex = 0;
            btnRunWait.Text = "RunWait";
            btnRunWait.UseVisualStyleBackColor = true;
            btnRunWait.Click += btnRunWait_Click;
            // 
            // btnRunOrKill
            // 
            btnRunOrKill.Location = new Point(12, 47);
            btnRunOrKill.Name = "btnRunOrKill";
            btnRunOrKill.Size = new Size(776, 29);
            btnRunOrKill.TabIndex = 1;
            btnRunOrKill.Text = "RunOrKill";
            btnRunOrKill.UseVisualStyleBackColor = true;
            btnRunOrKill.Click += btnRunOrKill_Click;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(12, 82);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(776, 29);
            btnCalc.TabIndex = 2;
            btnCalc.Text = "Calc";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(12, 117);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(776, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(12, 152);
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(776, 27);
            txtOutput.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 191);
            Controls.Add(txtOutput);
            Controls.Add(btnSearch);
            Controls.Add(btnCalc);
            Controls.Add(btnRunOrKill);
            Controls.Add(btnRunWait);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRunWait;
        private Button btnRunOrKill;
        private Button btnCalc;
        private Button btnSearch;
        private TextBox txtOutput;
    }
}

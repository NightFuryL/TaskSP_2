namespace WinFormsTask
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
            txtBoxLog = new TextBox();
            btnStart = new Button();
            SuspendLayout();
            // 
            // txtBoxLog
            // 
            txtBoxLog.Dock = DockStyle.Bottom;
            txtBoxLog.Location = new Point(0, 40);
            txtBoxLog.Multiline = true;
            txtBoxLog.Name = "txtBoxLog";
            txtBoxLog.ReadOnly = true;
            txtBoxLog.ScrollBars = ScrollBars.Vertical;
            txtBoxLog.Size = new Size(811, 437);
            txtBoxLog.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(0, 0);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(811, 29);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += buttonStart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 477);
            Controls.Add(btnStart);
            Controls.Add(txtBoxLog);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxLog;
        private Button btnStart;
    }
}

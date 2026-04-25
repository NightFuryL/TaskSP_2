namespace WinFormsTask
{
    partial class FormKeyboard
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
            btnExecute = new Button();
            txtLog = new TextBox();
            SuspendLayout();
            // 
            // btnExecute
            // 
            btnExecute.Location = new Point(12, 213);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(776, 29);
            btnExecute.TabIndex = 0;
            btnExecute.Text = "Execute";
            btnExecute.UseVisualStyleBackColor = true;
            btnExecute.Click += btnExecute_Click;
            // 
            // txtLog
            // 
            txtLog.Location = new Point(12, 12);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.ReadOnly = true;
            txtLog.ScrollBars = ScrollBars.Vertical;
            txtLog.Size = new Size(776, 195);
            txtLog.TabIndex = 1;
            // 
            // FormKeyboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 254);
            Controls.Add(txtLog);
            Controls.Add(btnExecute);
            Name = "FormKeyboard";
            Text = "FormKeyboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExecute;
        private TextBox txtLog;
    }
}
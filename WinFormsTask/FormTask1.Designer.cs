namespace WinFormsTask
{
    partial class FormTask1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtSquare = new TextBox();
            txtRectangle = new TextBox();
            txtTriangle = new TextBox();
            btnExecute = new Button();
            txtResult = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Square";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Rectangle";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 85);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 2;
            label3.Text = "Triangle";
            // 
            // txtSquare
            // 
            txtSquare.Location = new Point(93, 16);
            txtSquare.Name = "txtSquare";
            txtSquare.PlaceholderText = "side";
            txtSquare.Size = new Size(695, 27);
            txtSquare.TabIndex = 3;
            // 
            // txtRectangle
            // 
            txtRectangle.Location = new Point(93, 49);
            txtRectangle.Name = "txtRectangle";
            txtRectangle.PlaceholderText = "side1,side2";
            txtRectangle.Size = new Size(695, 27);
            txtRectangle.TabIndex = 4;
            // 
            // txtTriangle
            // 
            txtTriangle.Location = new Point(93, 82);
            txtTriangle.Name = "txtTriangle";
            txtTriangle.PlaceholderText = "side1,height";
            txtTriangle.Size = new Size(695, 27);
            txtTriangle.TabIndex = 5;
            // 
            // btnExecute
            // 
            btnExecute.Location = new Point(12, 115);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(776, 29);
            btnExecute.TabIndex = 6;
            btnExecute.Text = "Execute";
            btnExecute.UseVisualStyleBackColor = true;
            btnExecute.Click += btnExecute_Click;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(12, 150);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.ScrollBars = ScrollBars.Vertical;
            txtResult.Size = new Size(785, 288);
            txtResult.TabIndex = 7;
            // 
            // FormTask1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResult);
            Controls.Add(btnExecute);
            Controls.Add(txtTriangle);
            Controls.Add(txtRectangle);
            Controls.Add(txtSquare);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormTask1";
            Text = "FormTask1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtSquare;
        private TextBox txtRectangle;
        private TextBox txtTriangle;
        private Button btnExecute;
        private TextBox txtResult;
    }
}
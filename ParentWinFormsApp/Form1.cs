using System.Diagnostics;

namespace ParentWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Exercise 1
        private void btnRunWait_Click(object sender, EventArgs e)
        {
            Process p = new Process();

            p.StartInfo.FileName = "notepad.exe";

            p.Start();

            p.WaitForExit();

            txtOutput.Text = "Exit code: " + p.ExitCode;
        }
        //Exercise 2
        private void btnRunOrKill_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = "notepad.exe";

            p.Start();

            var result = MessageBox.Show(
                "Wait for process? (No = Kill)",
                "Choose",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                p.WaitForExit();
                txtOutput.Text = "Exit code: " + p.ExitCode;
            }
            else
            {
                p.Kill();
                txtOutput.Text = "Process killed";
            }
        }
        //Exercise 3
        private void btnCalc_Click(object sender, EventArgs e)
        {
            string path = @"..\..\..\..\ChildCalcConsoleApp\bin\Debug\net10.0\ChildCalcConsoleApp.exe";

            Process p = new Process();

            p.StartInfo.FileName = path;
            p.StartInfo.Arguments = "7 3 +";

            p.Start();
        }
        //Exercise 4
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string path = @"..\..\..\..\ChildSearchConsoleApp\bin\Debug\net10.0\ChildSearchConsoleApp.exe";

            Process p = new Process();

            p.StartInfo.FileName = path;
            p.StartInfo.Arguments = "..\\..\\..\\..\\test.txt bicycle";

            p.Start();
        }
    }
}



namespace WinFormsTask
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnTask1_Click(object sender, EventArgs e)
        {
            new FormKeyboard().Show();
        }

        private void btnTask2_Click(object sender, EventArgs e)
        {
            new FormMouse().Show();
        }
    }
}

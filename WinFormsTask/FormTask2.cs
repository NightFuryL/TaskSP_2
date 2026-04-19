using LibraryTask;
using static System.Net.Mime.MediaTypeNames;
namespace WinFormsTask
{
    public partial class FormTask2 : Form
    {
        public FormTask2()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            string t = txtText.Text;

            bool pal = MyTextHelper.IsPalindrome(t);
            int count = MyTextHelper.SentenceCount(t);
            string rev = MyTextHelper.Reverse(t);

            txtResult.Text =
                "Is palindrome: " + pal + Environment.NewLine +
                "Sentence count: " + count + Environment.NewLine +
                "Reverse text: " + rev + Environment.NewLine;
        }
    }
}

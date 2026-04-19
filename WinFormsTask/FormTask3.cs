using LibraryTask;
namespace WinFormsTask
{
    public partial class FormTask3 : Form
    {
        public FormTask3()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            bool name = Validator.CheckName(txtName.Text);
            bool age = Validator.CheckAge(txtAge.Text);
            bool phone = Validator.CheckPhone(txtPhone.Text);
            bool email = Validator.CheckEmail(txtEmail.Text);

            txtResult.Text =
                "Name: " + name + Environment.NewLine +
                "Age: " + age + Environment.NewLine +
                "Phone: " + phone + Environment.NewLine +
                "Email: " + email;
        }
    }
}

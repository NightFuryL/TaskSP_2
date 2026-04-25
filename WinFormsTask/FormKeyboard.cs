using LibraryTask;
namespace WinFormsTask;
public partial class FormKeyboard : Form
{
    KeyboardHook hook = new KeyboardHook();
    bool work = false;

    public FormKeyboard()
    {
        InitializeComponent();

        hook.OnKey += Hook_OnKey;
    }

    private void btnExecute_Click(object sender, EventArgs e)
    {
        if (!work)
        {
            hook.Start();
            btnExecute.Text = "Stop";
            work = true;
        }
        else
        {
            hook.Stop();
            btnExecute.Text = "Start";
            work = false;
        }
    }

    private void Hook_OnKey(string key)
    {
        Invoke(() =>
        {
            txtLog.Text += " | " + key + " ";
            File.AppendAllText("log.txt", " | " + key + " ");
        });
    }
}

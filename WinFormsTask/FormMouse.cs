using LibraryTask;

namespace WinFormsTask
{
    public partial class FormMouse : Form
    {
        MouseHook hook = new MouseHook();
        Random rnd = new Random();

        public FormMouse()
        {
            InitializeComponent();

            hook.OnClick += Hook_OnClick;
            hook.Start();

        }
        private void Hook_OnClick(int x, int y)
        {
            Invoke(() =>
            {
                //Такж подивився в інтернеті як отримати координати кнопки на екрані
                var rect = btnRun.RectangleToScreen(btnRun.ClientRectangle);

                if (rect.Contains(x, y))
                {
                    btnRun.Left = rnd.Next(0, Width - btnRun.Width);
                    btnRun.Top = rnd.Next(0, Height - btnRun.Height);
                }
            });
        }

    }
}

using System.Diagnostics;
using LibraryTask.Data;

namespace WinFormsTask;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        txtResult.Clear();

        string keyword = txtSearch.Text.ToLower();

        using var db = new AppDbContext();

        var users = db.Users.ToList();

        Stopwatch sw1 = new Stopwatch();
        sw1.Start();

        var result1 = users
            .Where(u => u.FullName.ToLower().Contains(keyword) || u.Username.ToLower().Contains(keyword))
            .ToList();

        sw1.Stop();

        Stopwatch sw2 = new Stopwatch();
        sw2.Start();

        var result2 = users
            .AsParallel()
            .Where(u => u.FullName.ToLower().Contains(keyword) || u.Username.ToLower().Contains(keyword))
            .ToList();

        sw2.Stop();

        txtResult.AppendText("LINQ:" + Environment.NewLine);
        foreach (var u in result1)
        {
            txtResult.AppendText(u.FullName + " - " + u.Username + Environment.NewLine);
        }

        txtResult.AppendText($"{Environment.NewLine}Час: {sw1.ElapsedMilliseconds} ms" + Environment.NewLine);

        txtResult.AppendText($"{Environment.NewLine}PLINQ:" + Environment.NewLine);
        foreach (var u in result2)
        {
            txtResult.AppendText("\t" + u.FullName + " - " + u.Username + Environment.NewLine);
        }

        txtResult.AppendText($"{Environment.NewLine}Час: {sw2.ElapsedMilliseconds} ms" + Environment.NewLine);
    }
}
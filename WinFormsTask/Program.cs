using LibraryTask.Data;
namespace WinFormsTask
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Генерація
            /*
            var db = new AppDbContext();

            if (!db.Users.Any())
            {
                Random rnd = new Random();

                for (int i = 0; i < 1_000_000; i++)
                {
                    db.Users.Add(new User
                    {
                        FullName = "User " + i,
                        Username = "user" + rnd.Next(100000, 999999)
                    });
                }

                db.SaveChanges();
            }
            */
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
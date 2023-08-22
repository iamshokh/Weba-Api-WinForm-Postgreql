using Backend.DataLayer;
using Backend.Service;

namespace Fontend.WinForm
{
    internal static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var context = new EfCoreContext();
            var userService = new UserService(context);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(userService));
        }
    }
}
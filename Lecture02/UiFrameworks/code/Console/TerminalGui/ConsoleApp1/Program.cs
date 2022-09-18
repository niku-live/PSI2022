using Terminal.Gui;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main()
        {
            Application.Init();
            Application.Top.Add(new MainPage());
            Application.Run();
            Application.Shutdown();
        }
    }
}
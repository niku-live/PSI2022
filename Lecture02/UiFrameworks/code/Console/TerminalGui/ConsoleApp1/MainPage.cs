using Terminal.Gui;

namespace ConsoleApp1
{
    internal class MainPage: Window
    {
        private int count = 0;
        private Button? counterBtn;

        public MainPage()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Title = "MainPage";
            X = 0;
            Y = 1; // Leave one row for the toplevel menu
            Width = Dim.Fill();
            Height = Dim.Fill();

            var hello = new Label("Hello, World! ") { X = Pos.Center(), Y = 2 };
            var welcome = new Label("Welcome to Terminal.Gui")
            {
                X = Pos.Center(),
                Y = Pos.Top(hello) + 1
            };
            counterBtn = new Button() { X = Pos.Center(), Y = 14, Text = "Click me" };
            counterBtn.Clicked += OnCounterClicked;
            Add(hello, welcome, counterBtn);

            // Creates a menubar, the item "New" has a help menu.
            var menu = new MenuBar(new MenuBarItem[] {
            new MenuBarItem ("_File", new MenuItem [] {
                    new MenuItem ("_Quit", "", () => { if (Quit ()) Application.Top.Running = false; })
                })
            });
            Application.Top.Add(menu);
        }

        private bool Quit()
        {
            var n = MessageBox.Query(50, 7, "Quit Demo", "Are you sure you want to quit this demo?", "Yes", "No");
            return n == 0;
        }

        private void OnCounterClicked()
        {
            count++;
            if (counterBtn == null)
                return;

            if (count == 1)
                counterBtn.Text = $"Clicked {count} time";
            else
                counterBtn.Text = $"Clicked {count} times";
        }
    }
}

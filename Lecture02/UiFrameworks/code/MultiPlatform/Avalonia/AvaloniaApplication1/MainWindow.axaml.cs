using Avalonia.Controls;
using Avalonia.Interactivity;
using System;

namespace AvaloniaApplication1
{
    public partial class MainWindow : Window
    {
        int count = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, RoutedEventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Content = $"Clicked {count} time";
            else
                CounterBtn.Content = $"Clicked {count} times";
        }
    }
}

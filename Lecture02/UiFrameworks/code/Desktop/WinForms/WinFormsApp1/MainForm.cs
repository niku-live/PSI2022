namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        private int count = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;
            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";
        }
    }
}
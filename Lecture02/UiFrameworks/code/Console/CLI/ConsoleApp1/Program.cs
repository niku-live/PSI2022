using Cocona;

var app = CoconaApp.Create();
// ./myapp info
app.AddCommand("info", () =>
{
    Console.WriteLine("Hello, World!");
    Console.WriteLine("Welcome to .NET CLI App (Powered by Cocona)");
});

// ./myapp click [command]
app.AddSubCommand("click", x =>
{
    x.AddCommand("once", () => Console.WriteLine(OnCounterClicked(1)));
    x.AddCommand("twise", () => Console.WriteLine(OnCounterClicked(2)));
})
.WithDescription("Click commands");

app.Run();

static string OnCounterClicked(int step)
{
    int count = 0;
    if (File.Exists("state.txt"))
    {
        count = int.Parse(File.ReadAllText("state.txt"));
    }

    count += step;

    string counterBtnText = string.Empty;
    if (count == 1)
        counterBtnText = $"Clicked {count} time";
    else
        counterBtnText = $"Clicked {count} times";

    File.WriteAllText("state.txt", count.ToString());
    return counterBtnText;
}
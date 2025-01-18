namespace hello_book;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        var config = new CongigurationBuilder()
            .AddCommandLine(args)
            .Build();
    }    
}
using NLog;

class Program
{
    private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

    static void Main(string[] args)
    {
        // Log different levels of messages
        Logger.Info("Application has started.");
        Logger.Debug("This is a debug message.");
        Logger.Warn("Warning! Something might be wrong.");
        Logger.Error("An error occurred.");
        Logger.Fatal("Fatal error! Application will shut down.");

        // Simulate application logic
        try
        {
            DivideNumbers(10, 0); // Will cause a divide by zero exception
        }
        catch (Exception ex)
        {
            Logger.Error(ex, "An exception occurred.");
        }

        Logger.Info("Application has finished.");
    }

    static int DivideNumbers(int number1, int number2)
    {
        return number1 / number2; // This will throw an exception if number2 is zero
    }
}

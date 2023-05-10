public interface ICalculator
{
    int Add(int x, int y);
    int Subtract(int x, int y);
}

public class Calculator : ICalculator
{
    public int Add(int x, int y)
    {
        return x + y;
    }

    public int Subtract(int x, int y)
    {
        return x - y;
    }
}

public class Logger
{
    public void Log(string message)
    {
        Console.WriteLine("[LOG] " + message);
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        // Crearea obiectelor Calculator și Logger
        ICalculator calculator = new Calculator();
        Logger logger = new Logger();

        // Adunarea a doua numere
        int result = calculator.Add(5, 10);
        logger.Log("5 + 10 = " + result);

        // Scăderea a doua numere
        result = calculator.Subtract(15, 7);
        logger.Log("15 - 7 = " + result);

        // Așteptarea apăsării unei taste pentru a închide consola
        Console.WriteLine("Apasati o tasta pentru a inchide consola...");
        Console.ReadKey();
    }
}

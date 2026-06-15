using System;

class Logger
{
    private static Logger instance;

    private Logger()
    {

    }

    public static Logger GetInstance()
    {
        if (instance == null)
        {
            instance = new Logger();
        }

        return instance;
    }


    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}


class Program
{
    static void Main(string[] args)
    {
        Logger logger1 = Logger.GetInstance();
        Logger logger2 = Logger.GetInstance();


        logger1.Log("Singleton Pattern Example");


        if (logger1 == logger2)
        {
            Console.WriteLine("Only one instance is created");
        }
        else
        {
            Console.WriteLine("Different instances created");
        }
    }
}
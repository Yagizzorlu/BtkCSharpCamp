namespace RecapDemo
{
    class Program
    {
        public static void main(String[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new FileLogger();
            customerManager.Logger = new SmsLogger();
            customerManager.Logger = new DatabaseLogger();
            customerManager.Add();
        }
    }
    
    class CustomerManager
    {
        public ILogger Logger { get; set; }     //CustomerManager içinde direkt Logger tanımladık ve interface ile tanımladık.
                                               //Bu sayede bu interface'a bağlı tüm Logger türleri bu class'a bağlı oldu.
                                               //Normalde constructor ile yaparız burada Property Injection yaptık.
        public void Add()
        {
            Logger.Log();
            Console.WriteLine("Customer added");
        }
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }

    class SmsLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Sms");
        }
    }

    interface ILogger
    {
        void Log();
    }
}


﻿using System.Security.Cryptography;

namespace Constructors
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();   //parametresiz olan ctor çalışır.
            customerManager.Add();

            Product product = new Product { Id = 1, Name = "Laptop" };
            Product product2 = new Product(2, "Computer");  //İkinci constructorda direkt değişkenleri tanımladığımız için burada direkt değerleri girebiliyoruz.

            EmployeeManager employeeManager = new EmployeeManager(new FileLogger());  //employeeManager'in constructorında içine ILogger parametresi girdik. O Logger'lardan birini tanımlamalıyız.
            //Kısacası class için property olarak public ILogger logger { get; set;} yapmak yerine constructor aracılığıyla interface'i bağlamak daha yararlı.
            employeeManager.Add();

            PersonManager personManager = new PersonManager("PRODUCT");
            personManager.Add();

            //Teacher classlarda teacher = new Teacher();   //staticlerde böyle bir new'leme yok.

            Teacher.Number = 10;    //static nesneler ortaktır ve herkes tarafından kullanılabilir.

            Utilities.Validate();

            Manager.DoSomething();

            Manager manager = new Manager();
            Manager.DoSomething2();
        }
    }

    class CustomerManager
    {
        private int _count = 15;
        public CustomerManager(int count)
        {
            _count = count;
        }

        public CustomerManager()  //Burası çalışır ve default olan 15 çalışır. new'lediğimiz yerde parantez içine sayı girsek parametreli ctor çalışır.
        {

        }
        public void List()
        {
            Console.WriteLine("Listed  {0} items", _count);
        }

        public void Add()
        {
            Console.WriteLine("Added");
        }
    }

    class Product
    {
        public Product()
        {

        }

        private int _id;
        private string _name;
        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
    
    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Database");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to File");
        }
    }

    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            Console.WriteLine("Added");
        }
    }

    class BaseClass
    {
        private string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }
        public void Message()
        {
            Console.WriteLine(" {0} message");
        }
    }

    class PersonManager : BaseClass
    {
        public PersonManager(string entity): base(entity)   //parametreyi sadece base sınıf için kullanıyor.
        {

        }

        public void Add()
        {
            Console.WriteLine("Added");
            Message();
        }
    }

    static class Teacher
    {
        public static int Number { get; set; }
    }

    static class Utilities                //static class'ın içindeki propertyler veya iş kısımları da static olmalı.
    {
        public static void Validate()
        {
            Console.WriteLine("Validation is done");
        }
    }

    class Manager
    {
        public static void DoSomething()
        {
            Console.WriteLine("Done");
        }

        public static void DoSomething2()
        {
            Console.WriteLine("Done 2");
        }
    }
}
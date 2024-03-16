namespace AbstractClasses
{
    class Program
    {
        public static void main(String[] args)
        {
            //Database database = new Database();    //Abstract class lar new'lenemez.
            Database database = new Oracle();
            database.Add();
            database.Delete();

            Database database2 = new SqlServer();    //Bu şekilde new'leyebiliriz.
            database2.Add();
            database2.Delete();
        }
    }

    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by default");
        }                                             //Kısacası Add,herkeste aynı ama Delete herkeste ayrı inherit edilmesi gerekiyor.

        public abstract void Delete();
    }

    class SqlServer : Database
    { 
        public override void Delete()     //implement edince sadece Delete geldi ve override olarak geldi.
        {
            Console.WriteLine("Deleted by Sql");
        }
        //abstract,içi dolu olmayan virtual methoddur.
    }

    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }
}


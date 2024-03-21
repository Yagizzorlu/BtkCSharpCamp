namespace Dictionary
{
    public class Program
    {
        static void Main(string[] args)
        {
           Dictionary<string,string> dictionary = new Dictionary<string,string>();
           dictionary.Add("book", "kitap");
           dictionary.Add("table","masa");
           dictionary.Add("computer", "bilgisayar");

           Console.WriteLine(dictionary["table"]);     //Masa yazdırır.
           Console.WriteLine(dictionary["glass"]);     //Hata verir.

            foreach(var item in dictionary)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            Console.WriteLine(dictionary.ContainsKey("glass"));   //false dönecek.
            Console.WriteLine(dictionary.ContainsKey("table"));   //true dönecek.
        }
    }
}

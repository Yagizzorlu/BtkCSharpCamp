using System.Collections;

namespace Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            //string[] cities = new string[2] { "Ankara", "İstanbul" };
            //cities[2] = "Adana";    Bu olmaz. 2 elemanlık diziye 3. eleman eklemeye çalışmış oluyoruz.

            //cities = new string[3];          Biz new'lediğimizde yeni bir referans oluşturmuş oluruz. Yani başka bir adrese sahiptir bu.
            //Console.WriteLine(cities[0]);      Bir şey yazdırmaz. Bu yeni bir adrese sahip ve içindekiler bomboş durumda.

            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");

            foreach (var city in cities) 
            {
                Console.WriteLine(city);        //Ankara ve Adana'yı yazdırır.
            }

            cities.Add("İstanbul");
            Console.WriteLine(cities[2]);      // Eleman sayısını arttırmak için new'lememize falan gerek olmadı.Yeni şehri rahatça ekleyebildik ve yazdırabildik.

            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            //sehirler.Add(1);    Yazdırmaz. türünün string olduğunu yazmıştık.  ArrayList'de ise string eklediğimiz gibi int de eklemiştik onda bir tür tanımlamamıştık.

            //List<Customer> customers = new List<Customer>
            //{
            //    new Customer { Id = 1, FirstName = "Yağız"},
            //    new Customer { Id = 2, FirstName = "Sinem"}
            //};

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, FirstName = "Yağız" });
            customers.Add(new Customer { Id = 2, FirstName = "Sinem" });

            var count = customers.Count;    //Count listedeki eleman sayısını söyleyen komuttur.
            var customer2 = new Customer
            {
                Id = 3,
                FirstName = "Mert"
            };

            customers.Add(customer2);      //Oluşturduğumuz customer2 yi customers listesine ekledik.
            customers.AddRange(new Customer[2]   //AddRange kullanarak customers listesine 2 tane daha müşteri ekledik.
            {
                new Customer { Id = 4, FirstName = "Ali"},
                new Customer { Id = 5, FirstName = "Ayşe"}
            });

            var index = customers.IndexOf(customer2);   //customers içinden customer2 elemanının kaçıncı sırada olduğunu verir.
            Console.WriteLine("Index: {0}", index);

            var index2 = customers.LastIndexOf(customer2);  //aramaya sondan başlar.
            Console.WriteLine("Index: {0}", index2);     //Bulduğu index numarası değişmez sadece sondan veya baştan aramaya başlar.

            customers.Insert(0,customer2);  //Add gibi direkt sona eklemeyiz,istediğimiz index'e ekleriz ve diğer elemanlar da silinmez.

            customers.Remove(customer2);  //Bulduğu ilk değeri siler. Sonra bırakır.
            customers.RemoveAll(c=>c.FirstName == "Ali");  //İsmi Ali olanların hepsini siler.


            foreach (var customer in customers) 
            {
                Console.WriteLine(customer.FirstName);
            }
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}

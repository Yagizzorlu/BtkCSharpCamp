namespace Exceptions
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();

            try
            {
                Find();  // deniyouz.
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);   //hata geliyorsa buradan hatayı yazdırıyoruz.
            }



            HandleException(() =>
            {
                Find();               
                //try-catch e göre çok daha basit bir yazımı vardır.Try-catch'de catch ler artabilir ama bu değişmez.
            });
           
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();   //parametre olarak gönderdiğimiz kısmı try içinde çalıştırmamız anlamına geliyor burası.Find()'i burada çalıştırıyoruz.
            }
            catch (Exception exception)    //Exception türü ne olursa olsun
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Yağız", "Sinem", "Metehan" };

            if (!students.Contains("Ahmet"))  //Listede Ahmet yoksa (Başta ! var bu değili anlamına geliyor.)
            {
                throw new RecordNotFoundException("Record Not Found");  //Hata fırlat
                //RecordNotFoundException da yazdığımız message kısmı sayesinde bunun içine direkt kullanıcıya gösterebileceğimiz mesajı girebiliyoruz.
            }
            else
            {
                Console.WriteLine("Record Found");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[3] { "Yağız", "Sinem", "Metehan" };
                students[3] = "Ahmet";  //students[3] dizinin 4. elemanı oluyor ve bu tanımladığımız sınırı aşıyor.

            }
            catch (IndexOutOfRangeException exception)
            //Anlamı şudur: Eğer ki aldığın hata bu hataysa bu bloğu çalıştır,eğer hata bu değilse alttaki catch'in hatasının bloğunu çalıştır.

            {
                Console.WriteLine(exception.Message);
            }

            catch (Exception exception)   //Hata olduğunda exception nesnesine aktarılıyor.
            {
                Console.WriteLine(exception.Message);
                Console.WriteLine(exception.InnerException); //Daha detaylı bilgi varsa onu verir.
            }

            //try-catch'in işlevi şudur: Önce try'daki blok ile denemeyi yapıyoruz. Eğer ki bir hata alıyorsak catch bloğunda bu hatayı aktarıyoruz. Hatayı catch'te yakalıyoruz.
            //Özel hata sınıfları vardır bu yüzden birden fazla catch bloğu oluşturabiliriz.
        }
    }
}

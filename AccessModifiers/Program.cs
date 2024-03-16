namespace AccessModifiers
{
    class Program
    {

        //bir class ya internal olur ya da public olur. İç içe class'larda private kullanılabilir.
        public static void main(String[] args)
        {
           
        }
    }

    class Customer
    {                    //private değişkenler sadece tanımlandığı sınıf içinde geçerli olur.
        protected int Id { get; set; }      
        public void Save()
        {
           
        }

        public void Delete()   //save'in içine tanımlayınca dahi delete de bile gözükmez private değişken olduğu için
        {
           
        }
    }

    class Student : Customer      //protected olunca inherit edildiği sınıflarda kullanılabiliyor.
    {
        public void Save2()
        {
            
        }
    }

    public class Course   // class'ın önünde bir şey yok. Default hali "internal" dir. Internal = bağlı olduğu classda referans ihtiyacı olmadan kullanılabilir
    {
        public string Name { get; set; }
    }
}

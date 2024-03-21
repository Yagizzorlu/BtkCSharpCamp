using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class ProductDal
    {
        public DataTable GetAll()
        {
            SqlConnection connection = new SqlConnection(@"server = (localdb)\mssqllocaldb; initial catalog = ETrade;integrated security = true");
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();           //Bağlantımız kapalıysa açmamız için yazdığımız bir kod.
            }

            SqlCommand command = new SqlCommand("Select * from Products", connection);

            SqlDataReader reader = command.ExecuteReader();     //SqlDataReader döndürüyormuş ondan reader nesnesini oluşturuyoruz.

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);    //IDataReader türünde bir şey istiyor Load. O da zaten SqlDataReader'in base idir.
            reader.Close();
            connection.Close();
            return dataTable;
            
        }
    }
}

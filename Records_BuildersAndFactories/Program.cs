using System.Data.SqlClient;

namespace Records_BuildersAndFactories
{
    public class Program
    {
        public static void Main()
        {
            using (var connection = new SqlConnection("Some Connection String"))
            {
                var productFactory = new ProductFactory(connection);
                var productA = productFactory.create(ProductFactory.testProductRecordBuilder() //Build a Default Product override Properties and insert in DB
                                            .Product_ID(100));

                var productB = ProductRecordBuilder.productRecordBuilder() //Build a Product override properties
                                                        .Product_ID(10)
                                                        .build(); 

                var productC = ProductFactory.testProductRecordBuilder().build(); //Build a Product with Defaults

                var productD = productFactory.create();  //Dump a default one in DB
            }
        }
    }
}

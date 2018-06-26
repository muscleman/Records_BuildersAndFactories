using System;
using System.Data.SqlClient;

namespace Records_BuildersAndFactories
{
    public class ProductFactory
    {
        protected SqlConnection connection;

        public ProductFactory(SqlConnection connection)
        {
            this.connection = connection;
        }

        public Product create(ProductRecordBuilder builder)
        {
            var product = builder.build();
            var sql = $@"INSERT INTO PRODUCTS 
                            (
                                Product_ID,
                                Product_Name,
                                Product_Security_Group,
                                Parent_Product_ID,
                                HCO_Required,
                                CPO_Access,
                                Product_Notifying_Email,
                                Requires_Explicit_User_Delete,
                                Product_Description,
                                PHI_Product,
                                Product_Expirty_Date,
                                Dynamic_Product_Users,
                                IT_Team_Group,
                                Product_Business_Owner_Group,
                                Product_Users_Group,
                                AdminConsoleDisplay,
                                Alliance_Aware,
                                Product_Type,
                                Application_Name,
                                Is_Active,
                                Date_Created_On,
                                Created_By,
                                Modified_Date,
                                Modified_By,
                                ApplicationId
                            )
                         VALUES
                            (
                                @Product_ID,
                                @Product_Name,
                                @Product_Security_Group,
                                @Parent_Product_ID,
                                @HCO_Required,
                                @CPO_Access,
                                @Product_Notifying_Email,
                                @Requires_Explicit_User_Delete,
                                @Product_Description,
                                @PHI_Product,
                                @Product_Expiry_Date,
                                @Dynamic_Product_Users,
                                @IT_Team_Group,
                                @Product_Business_Owner_Group,
                                @Product_Users_Group,
                                @AdminConsoleDisplay,
                                @Alliance_Aware,
                                @Product_Type,
                                @Application_Name,
                                @Is_Active,
                                @Date_Created_On,
                                @Created_By,
                                @Modified_Date,
                                @Modified_By,
                                @ApplicationId
                            )";

            try
            {
                using (var command = new SqlCommand(sql, connection))
                {
                    command.CommandType = System.Data.CommandType.Text;
                    command.Parameters.AddWithValue("@Product_ID", product.Product_ID);
                    command.Parameters.AddWithValue("@Product_Name", product.Product_Name);
                    command.Parameters.AddWithValue("@Product_Security_Group", product.Product_Security_Group);
                    command.Parameters.AddWithValue("@Parent_Product_ID", product.Parent_Product_ID);
                    command.Parameters.AddWithValue("@HCO_Required", product.HCO_Required);
                    command.Parameters.AddWithValue("@CPO_Access", product.CPO_Access);
                    command.Parameters.AddWithValue("@Product_Notifying_Email", product.Product_Notifying_Email);
                    command.Parameters.AddWithValue("@Requires_Explicit_User_Delete", product.Requires_Explicit_User_Delete);
                    command.Parameters.AddWithValue("@Product_Description", product.Product_Description);
                    command.Parameters.AddWithValue("@PHI_Product", product.PHI_Product);
                    command.Parameters.AddWithValue("@Product_Expiry_Date", product.Product_Expiry_Date);
                    command.Parameters.AddWithValue("@Dynamic_Product_Users", product.Dynamic_Product_Users);
                    command.Parameters.AddWithValue("@IT_Team_Group", product.IT_Team_Group);
                    command.Parameters.AddWithValue("@Product_Business_Owner_Group", product.Product_Business_Owner_Group);
                    command.Parameters.AddWithValue("@Product_Users_Group", product.Product_Users_Group);
                    command.Parameters.AddWithValue("@AdminConsoleDisplay", product.AdminConsoleDisplay);
                    command.Parameters.AddWithValue("@Alliance_Aware", product.Alliance_Aware);
                    command.Parameters.AddWithValue("@Product_Type", product.Product_Type);
                    command.Parameters.AddWithValue("@Application_Name", product.Application_Name);
                    command.Parameters.AddWithValue("@Is_Active", product.Is_Active);
                    command.Parameters.AddWithValue("@Date_Created_On", product.Date_Created_On);
                    command.Parameters.AddWithValue("@Created_By", product.Created_By);
                    command.Parameters.AddWithValue("@Modified_Date", product.Modified_Date);
                    command.Parameters.AddWithValue("@Modified_By", product.Modified_By);
                    command.Parameters.AddWithValue("@ApplicationId", product.ApplicationId);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            { }
            finally
            {
                connection.Close();
            }

            return builder.build();
        }

        public Product create()
        {
            return create(testProductRecordBuilder());
        }

        
        public static ProductRecordBuilder testProductRecordBuilder()
        {
            return ProductRecordBuilder.productRecordBuilder()
                .Product_ID(1)
                .Product_Name("Aspirin")
                .Product_Security_Group("SomeGroup")
                .Parent_Product_ID(null)
                .HCO_Required(true)
                .CPO_Access(null)
                .Product_Notifying_Email("Marge@yahoo.com")
                .Requires_Explicit_User_Delete(null)
                .Product_Description("My Special Product")
                .PHI_Product(null)
                .Product_Expiry_Date(null)
                .Dynamic_Product_Users(null)
                .IT_Team_Group("Admins")
                .Product_Business_Owner_Group("BusinessGroup")
                .Product_Users_Group("UsersGroup")
                .Admin_Console_Display(null)
                .Alliance_Aware(null)
                .Product_Type("Liquid")
                .Application_Name("App")
                .Is_Active(true)
                .Date_Created_On(new DateTime(2018, 6, 25, 19, 00, 00))
                .Created_By("Marge")
                .Modified_Date(null)
                .Modified_By(null)
                .Application_Id("1");

        }
    }
}

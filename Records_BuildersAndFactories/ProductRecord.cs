using System;

namespace Records_BuildersAndFactories
{
    public class Product
    {
        public int Product_ID { get; set; }
        public string Product_Name { get; set; }
        public string Product_Security_Group { get; set; }
        public Nullable<int> Parent_Product_ID { get; set; }
        public bool HCO_Required { get; set; }
        public Nullable<bool> CPO_Access { get; set; }
        public string Product_Notifying_Email { get; set; }
        public Nullable<bool> Requires_Explicit_User_Delete { get; set; }
        public string Product_Description { get; set; }
        public Nullable<bool> PHI_Product { get; set; }
        public Nullable<System.DateTime> Product_Expiry_Date { get; set; }
        public Nullable<bool> Dynamic_Product_Users { get; set; }
        public string IT_Team_Group { get; set; }
        public string Product_Business_Owner_Group { get; set; }
        public string Product_Users_Group { get; set; }
        public Nullable<bool> AdminConsoleDisplay { get; set; }
        public Nullable<bool> Alliance_Aware { get; set; }
        public string Product_Type { get; set; }
        public string Application_Name { get; set; }
        public bool Is_Active { get; set; }
        public Nullable<System.DateTime> Date_Created_On { get; set; }
        public string Created_By { get; set; }
        public Nullable<System.DateTime> Modified_Date { get; set; }
        public string Modified_By { get; set; }
        public string ApplicationId { get; set; }

        public Product(int productID,
                            string productName,
                            string productSecurityGroup,
                            int? parentProductID,
                            bool hCORequired,
                            bool? cPOAccess,
                            string productNotifyingEmail,
                            bool? requiresExplicitUserDelete,
                            string productDescription,
                            bool? pHIProduct,
                            DateTime? productExpiryDate,
                            bool? dynamicProductUsers,
                            string iTTeamGroup,
                            string productBusinessOwnerGroup,
                            string productUsersGroup,
                            bool? adminConsoleDisplay,
                            bool? allianceAware,
                            string productType,
                            string applicationName,
                            bool isActive,
                            DateTime? dateCreatedOn,
                            string createdBy,
                            DateTime? modifiedDate,
                            string modifiedBy,
                            string applicationId)
        {
            Product_ID = productID;
            Product_Name = productName;
            Product_Security_Group = productSecurityGroup;
            Parent_Product_ID = Parent_Product_ID;
            HCO_Required = HCO_Required;
            CPO_Access = CPO_Access;
            Product_Notifying_Email = productNotifyingEmail;
            Requires_Explicit_User_Delete = requiresExplicitUserDelete;
            Product_Description = productDescription;
            Dynamic_Product_Users = dynamicProductUsers;
            IT_Team_Group = iTTeamGroup;
            Product_Business_Owner_Group = productBusinessOwnerGroup;
            Product_Users_Group = productUsersGroup;
            AdminConsoleDisplay = adminConsoleDisplay;
            Alliance_Aware = allianceAware;
            Product_Type = productType;
            Application_Name = applicationName;
            Is_Active = isActive;
            Date_Created_On = dateCreatedOn;
            Created_By = createdBy;
            Modified_Date = modifiedDate;
            Modified_By = modifiedBy;
            ApplicationId = applicationId;
        }
    }
}

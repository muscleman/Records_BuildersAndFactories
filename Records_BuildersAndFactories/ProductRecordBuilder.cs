using System;

namespace Records_BuildersAndFactories
{
    public class ProductRecordBuilder
    {
        protected int ProductID;
        protected string ProductName;
        protected string ProductSecurityGroup;
        protected int? ParentProductID;
        protected bool HCORequired;
        protected bool? CPOAccess;
        protected string ProductNotifyingEmail;
        protected bool? RequiresExplicitUserDelete;
        protected string ProductDescription;
        protected bool? PHIProduct;
        protected DateTime? ProductExpiryDate;
        protected bool? DynamicProductUsers;
        protected string ITTeamGroup;
        protected string ProductBusinessOwnerGroup;
        protected string ProductUsersGroup;
        protected bool? AdminConsoleDisplay;
        protected bool? AllianceAware;
        protected string ProductType;
        protected string ApplicationName;
        protected bool IsActive;
        protected DateTime? DateCreatedOn;
        protected string CreatedBy;
        protected DateTime? ModifiedDate;
        protected string ModifiedBy;
        protected string ApplicationId;

        private ProductRecordBuilder() { }

        public static ProductRecordBuilder productRecordBuilder()
        {
            return new ProductRecordBuilder();
        }

        public Product build()
        {
            return new Product(ProductID,
                                     ProductName,
                                     ProductSecurityGroup,
                                     ParentProductID,
                                     HCORequired,
                                     CPOAccess,
                                     ProductNotifyingEmail,
                                     RequiresExplicitUserDelete,
                                     ProductDescription,
                                     PHIProduct,
                                     ProductExpiryDate,
                                     DynamicProductUsers,
                                     ITTeamGroup,
                                     ProductBusinessOwnerGroup,
                                     ProductUsersGroup,
                                     AdminConsoleDisplay,
                                     AllianceAware,
                                     ProductType,
                                     ApplicationName,
                                     IsActive,
                                     DateCreatedOn,
                                     CreatedBy,
                                     ModifiedDate,
                                     ModifiedBy,
                                     ApplicationId);
        }

        public ProductRecordBuilder Product_ID(int productId)
        {
            ProductID = productId;
            return this;
        }
        public ProductRecordBuilder Product_Name(string productName)
        {
            ProductName = productName;
            return this;
        }
        public ProductRecordBuilder Product_Security_Group(string productSecurityGroup)
        {
            ProductSecurityGroup = productSecurityGroup;
            return this;
        }
        public ProductRecordBuilder Parent_Product_ID(int? parentProductID)
        {
            ParentProductID = parentProductID;
            return this;
        }
        public ProductRecordBuilder HCO_Required(bool hCoRequired)
        {
            HCORequired = hCoRequired;
            return this;
        }
        public ProductRecordBuilder CPO_Access(bool? cPoAccess)
        {
            CPOAccess = cPoAccess;
            return this;
        }
        public ProductRecordBuilder Product_Notifying_Email(string productNotifyingEmail)
        {
            ProductNotifyingEmail = productNotifyingEmail;
            return this;
        }
        public ProductRecordBuilder Requires_Explicit_User_Delete(bool? requiresExplicitUserDelete)
        {
            RequiresExplicitUserDelete = requiresExplicitUserDelete;
            return this;
        }
        public ProductRecordBuilder Product_Description(string productDescription)
        {
            ProductDescription = productDescription;
            return this;
        }
        public ProductRecordBuilder PHI_Product(bool? phiProduct)
        {
            PHIProduct = phiProduct;
            return this;
        }
        public ProductRecordBuilder Product_Expiry_Date(DateTime? productExpirtyDate)
        {
            ProductExpiryDate = productExpirtyDate;
            return this;
        }
        public ProductRecordBuilder Dynamic_Product_Users(bool? dynamicProductUsers)
        {
            DynamicProductUsers = dynamicProductUsers;
            return this;
        }
        public ProductRecordBuilder IT_Team_Group(string itTeamGroup)
        {
            ITTeamGroup = itTeamGroup;
            return this;
        }
        public ProductRecordBuilder Product_Business_Owner_Group(string productBusinessOwnerGroup)
        {
            ProductBusinessOwnerGroup = productBusinessOwnerGroup;
            return this;
        }
        public ProductRecordBuilder Product_Users_Group(string productUsersGroup)
        {
            ProductUsersGroup = productUsersGroup;
            return this;
        }
        public ProductRecordBuilder Admin_Console_Display(bool? adminConsoleDisplay)
        {
            AdminConsoleDisplay = adminConsoleDisplay;
            return this;
        }
        public ProductRecordBuilder Alliance_Aware(bool? allianceAware)
        {
            AllianceAware = allianceAware;
            return this;
        }
        public ProductRecordBuilder Product_Type(string productType)
        {
            ProductType = productType;
            return this;
        }
        public ProductRecordBuilder Application_Name(string applicationName)
        {
            ApplicationName = applicationName;
            return this;
        }
        public ProductRecordBuilder Is_Active(bool isActive)
        {
            IsActive = isActive;
            return this;
        }
        public ProductRecordBuilder Date_Created_On(DateTime? dateCreatedOn)
        {
            DateCreatedOn = dateCreatedOn;
            return this;
        }
        public ProductRecordBuilder Created_By(string createdBy)
        {
            CreatedBy = createdBy;
            return this;
        }
        public ProductRecordBuilder Modified_Date(DateTime? modifiedDate)
        {
            ModifiedDate = modifiedDate;
            return this;
        }
        public ProductRecordBuilder Modified_By(string modifiedBy)
        {
            ModifiedBy = modifiedBy;
            return this;
        }
        public ProductRecordBuilder Application_Id(string applicationId)
        {
            ApplicationId = applicationId;
            return this;
        }
    }
}

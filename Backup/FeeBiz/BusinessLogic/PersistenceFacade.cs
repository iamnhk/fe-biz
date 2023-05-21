using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;
using System.Collections;

namespace FeBiz
{
    class PersistenceFacade
    {
        SqlConnection myConnection;
        
        //Constructors
        public PersistenceFacade()
        {
            String connectionString = "Data Source=Nazmul-PC;Initial Catalog=FeBiz;Integrated Security=True";
           // String connectionString = "Data Source=ADNAN-PC;Initial Catalog=FeBiz;Integrated Security=True";
           //String connectionString = "Data Source=VANDELAY;Initial Catalog=FeBiz;Integrated Security=True";
            myConnection = new SqlConnection(connectionString);

        }

        //Methods
        public int insertFarmer(Farmer farmer)
        {            
            String myString = @"INSERT INTO Farmer([Phone], [Fax], [Email], [Password], [RegistrationDate], 
                            [RegistrationConfirmation], [AddressLine1], [AddressLine2], [PostCode], [City], [Country], 
                            [VerificationCode], [FarmerName], [BankAccountNumber], [BankAccountTitle], [IBAN], [SwiftBIC],
                            [BankName], [BankBranchName]) 
                            VALUES(@Phone, @Fax, @Email, @Password, @RegistrationDate, @RegistrationConfirmation,
                            @AddressLine1, @AddressLine2, @PostCode, @City, @Country, @VerificationCode, @FarmerName, 
                            @BankAccountNumber, @BankAccountTitle, @IBAN, @SwiftBIC, @BankName, @BankBranchName); "
                            + "SELECT CAST(scope_identity() AS int)";
            SqlCommand myCommand = new SqlCommand(myString, myConnection);            
            myCommand.Parameters.Add(new SqlParameter(@"Phone", OleDbType.VarChar)).Value = farmer.Phone;
            myCommand.Parameters.Add(new SqlParameter(@"Fax", OleDbType.VarChar)).Value = farmer.Fax;
            myCommand.Parameters.Add(new SqlParameter(@"Email", OleDbType.VarChar)).Value = farmer.Email;
            myCommand.Parameters.Add(new SqlParameter(@"Password", OleDbType.Char)).Value = farmer.Password;
            myCommand.Parameters.Add(new SqlParameter(@"RegistrationDate", OleDbType.Date)).Value = farmer.RegistrationDate;
            myCommand.Parameters.Add(new SqlParameter(@"RegistrationConfirmation", OleDbType.Boolean)).Value = farmer.RegistrationConfirmation;
            myCommand.Parameters.Add(new SqlParameter(@"AddressLine1", OleDbType.VarChar)).Value = farmer.AddressLine1;
            myCommand.Parameters.Add(new SqlParameter(@"AddressLine2", OleDbType.VarChar)).Value = farmer.AddressLine2;
            myCommand.Parameters.Add(new SqlParameter(@"PostCode", OleDbType.VarChar)).Value = farmer.PostCode;
            myCommand.Parameters.Add(new SqlParameter(@"City", OleDbType.VarChar)).Value = farmer.City;
            myCommand.Parameters.Add(new SqlParameter(@"Country", OleDbType.VarChar)).Value = farmer.Country;
            myCommand.Parameters.Add(new SqlParameter(@"VerificationCode", OleDbType.Char)).Value = farmer.VerificationCode;
            myCommand.Parameters.Add(new SqlParameter(@"FarmerName", OleDbType.VarChar)).Value = farmer.Name;
            myCommand.Parameters.Add(new SqlParameter(@"BankAccountNumber", OleDbType.VarChar)).Value = farmer.BankAccountNumber;
            myCommand.Parameters.Add(new SqlParameter(@"BankAccountTitle", OleDbType.VarChar)).Value = farmer.BankAccountTitle;
            myCommand.Parameters.Add(new SqlParameter(@"IBAN", OleDbType.VarChar)).Value = farmer.IBAN;
            myCommand.Parameters.Add(new SqlParameter(@"SwiftBIC", OleDbType.VarChar)).Value = farmer.SwiftBIC;
            myCommand.Parameters.Add(new SqlParameter(@"BankName", OleDbType.VarChar)).Value = farmer.BankName;
            myCommand.Parameters.Add(new SqlParameter(@"BankBranchName", OleDbType.VarChar)).Value = farmer.BankBranchName;
            Int32 newFarmerID = -1;
            try
            {
                myConnection.Open();
                newFarmerID = (Int32)myCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }            
            myConnection.Close();
            return (int)newFarmerID;
        }

        public int insertCategory(Category category)
        {            
            String myString = @"INSERT INTO [FeBiz].[dbo].[Category] ([Type], [SubType]) 
                                VALUES(@Type, @SubType); "
                                + "SELECT CAST(scope_identity() AS int)"; 
            SqlCommand myCommand = new SqlCommand(myString, myConnection);            
            myCommand.Parameters.Add(new SqlParameter(@"Type", OleDbType.VarChar)).Value = category.Type;
            myCommand.Parameters.Add(new SqlParameter(@"SubType", OleDbType.VarChar)).Value = category.SubType;            
            Int32 newCategoryID = -1;
            try
            {
                myConnection.Open();
                newCategoryID = (Int32)myCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            myConnection.Close();
            return (int)newCategoryID;            
        }

        public int insertProduct(Product product, int farmerID)
        {   
            String myString = @"INSERT INTO [FeBiz].[dbo].[Product] ([ProductName], [OfferExpiry],
                        [TotalQuantity], [PacketSize], [PacketSizeUnit], [Active], [Price], [Quality], 
                        [RegistrationDate], [CategoryID], [FarmerID]) 
                        VALUES (@ProductName, @OfferExpiry, @TotalQuantity, @PacketSize, 
                        @PacketSizeUnit, @Active, @Price, @Quality, @RegistrationDate, @CategoryID, 
                        @FarmerID); "
                        + "SELECT CAST(scope_identity() AS int)";                
            SqlCommand myCommand = new SqlCommand(myString, myConnection);            
            myCommand.Parameters.Add(new SqlParameter(@"ProductName", OleDbType.VarChar)).Value = product.Name;
            myCommand.Parameters.Add(new SqlParameter(@"OfferExpiry", OleDbType.Date)).Value = product.OfferExpiry;
            myCommand.Parameters.Add(new SqlParameter(@"TotalQuantity", OleDbType.Integer)).Value = product.TotalQuantity;
            myCommand.Parameters.Add(new SqlParameter(@"PacketSize", OleDbType.Integer)).Value = product.PacketSize;
            myCommand.Parameters.Add(new SqlParameter(@"PacketSizeUnit", OleDbType.VarChar)).Value = product.PacketSizeUnit;
            myCommand.Parameters.Add(new SqlParameter(@"Active", OleDbType.Boolean)).Value = product.Active;
            myCommand.Parameters.Add(new SqlParameter(@"Price", OleDbType.Double)).Value = product.Price;
            myCommand.Parameters.Add(new SqlParameter(@"Quality", OleDbType.Integer)).Value = product.Quality;
            myCommand.Parameters.Add(new SqlParameter(@"RegistrationDate", OleDbType.Date)).Value = product.RegistrationDate;
            myCommand.Parameters.Add(new SqlParameter(@"CategoryID", OleDbType.Integer)).Value = product.Category.CategoryID;
            myCommand.Parameters.Add(new SqlParameter(@"FarmerID", OleDbType.Integer)).Value = farmerID;
            Int32 newProductID = -1;
            try
            {
                myConnection.Open();
                newProductID = (Int32)myCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            myConnection.Close();
            return (int)newProductID;                        
        }

        public int insertRenewal(Renewal renewal, int productID)
        {            
            String myString = @"INSERT INTO [FeBiz].[dbo].[Renewal] ([RenewalDate], [ProductID])
                              VALUES(@RenewalDate, @ProductID); "
                              + "SELECT CAST(scope_identity() AS int)";  
            SqlCommand myCommand = new SqlCommand(myString, myConnection);            
            myCommand.Parameters.Add(new SqlParameter(@"RenewalDate", OleDbType.Date)).Value = renewal.RenewalDate;
            myCommand.Parameters.Add(new SqlParameter(@"ProductID", OleDbType.Integer)).Value = productID;
            Int32 newRenewalID = -1;
            try
            {
                myConnection.Open();
                newRenewalID = (Int32)myCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            myConnection.Close();
            return (int)newRenewalID;                        
        }

        public void updateProductOfferExpiry(int productID, DateTime newOfferExpiry)
        {            
            String myString = @"UPDATE [FeBiz].[dbo].[Product] 
                              SET [OfferExpiry] = @OfferExpiry 
                              WHERE ProductID = @ProductID";
            SqlCommand myCommand = new SqlCommand(myString, myConnection);
            myCommand.Parameters.Add(new SqlParameter(@"OfferExpiry", OleDbType.Date)).Value = newOfferExpiry;
            myCommand.Parameters.Add(new SqlParameter(@"ProductID", OleDbType.Integer)).Value = productID;
            try
            {
                myConnection.Open();
                myCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            myConnection.Close();
        }

        public void updateTotalQuantityOfProduct(int productID, int newTotalQuantity)
        {            
            String myString = @"UPDATE [FeBiz].[dbo].[Product] 
                              SET [TotalQuantity] = @TotalQuantity
                              WHERE ProductID = @ProductID";     
            SqlCommand myCommand = new SqlCommand(myString, myConnection);
            myCommand.Parameters.Add(new SqlParameter(@"TotalQuantity", OleDbType.Integer)).Value = newTotalQuantity;
            myCommand.Parameters.Add(new SqlParameter(@"ProductID", OleDbType.Integer)).Value = productID;
            try
            {
                myConnection.Open();
                myCommand.ExecuteScalar();                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            myConnection.Close();
        }

        public bool checkProductStatus(int productID)
        {            
            String myString = @"SELECT [Active] 
                              FROM [FeBiz].[dbo].[Product]
                              WHERE [ProductID] = @ProductID";
            SqlCommand myCommand = new SqlCommand(myString, myConnection);            
            myCommand.Parameters.Add(new SqlParameter(@"ProductID", OleDbType.Integer)).Value = productID;
            bool status = false;
            SqlDataReader mySqlDataReader = null;
            try
            {
                myConnection.Open();
                mySqlDataReader = myCommand.ExecuteReader(CommandBehavior.SingleRow);                
                while (mySqlDataReader.Read())
                {
                    status = (bool)mySqlDataReader["Active"];
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            mySqlDataReader.Close();            
            myConnection.Close();
            return status;
        }

        public void markProductAsActiveORInactive(int productID, bool newStatus)
        {            
            String myString = @"UPDATE [FeBiz].[dbo].[Product] 
                              SET [Active] = @Active
                              WHERE ProductID = @ProductID";
            SqlCommand myCommand = new SqlCommand(myString, myConnection);
            myCommand.Parameters.Add(new SqlParameter(@"Active", OleDbType.Boolean)).Value = newStatus;
            myCommand.Parameters.Add(new SqlParameter(@"ProductID", OleDbType.Integer)).Value = productID;
            try
            {
                myConnection.Open();
                myCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            myConnection.Close();
        }

        public int insertCompany(Company company)
        {            
            String myString = @"INSERT INTO [FeBiz].[dbo].[Company] ([Phone], [Fax], [Email], [Password], 
                              [RegistrationDate], [RegistrationConfirmation], [AddressLine1], [AddressLine2], [PostCode],
                              [City], [Country], [VerificationCode], [CompanyName], [ContactPersonName], [BranchName]) 
                              VALUES(@Phone, @Fax, @Email, @Password, @RegistrationDate, @RegistrationConfirmation,
                              @AddressLine1, @AddressLine2, @PostCode, @City, @Country, @VerificationCode, @CompanyName, 
                              @ContactPersonName, @BranchName); "
                              + "SELECT CAST(scope_identity() AS int)";  
            SqlCommand myCommand = new SqlCommand(myString, myConnection);            
            myCommand.Parameters.Add(new SqlParameter(@"Phone", OleDbType.VarChar)).Value = company.Phone;
            myCommand.Parameters.Add(new SqlParameter(@"Fax", OleDbType.VarChar)).Value = company.Fax;
            myCommand.Parameters.Add(new SqlParameter(@"Email", OleDbType.VarChar)).Value = company.Email;
            myCommand.Parameters.Add(new SqlParameter(@"Password", OleDbType.Char)).Value = company.Password;
            myCommand.Parameters.Add(new SqlParameter(@"RegistrationDate", OleDbType.Date)).Value = company.RegistrationDate;
            myCommand.Parameters.Add(new SqlParameter(@"RegistrationConfirmation", OleDbType.Boolean)).Value = company.RegistrationConfirmation;
            myCommand.Parameters.Add(new SqlParameter(@"AddressLine1", OleDbType.VarChar)).Value = company.AddressLine1;
            myCommand.Parameters.Add(new SqlParameter(@"AddressLine2", OleDbType.VarChar)).Value = company.AddressLine2;
            myCommand.Parameters.Add(new SqlParameter(@"PostCode", OleDbType.VarChar)).Value = company.PostCode;
            myCommand.Parameters.Add(new SqlParameter(@"City", OleDbType.VarChar)).Value = company.City;
            myCommand.Parameters.Add(new SqlParameter(@"Country", OleDbType.VarChar)).Value = company.Country;
            myCommand.Parameters.Add(new SqlParameter(@"VerificationCode", OleDbType.Char)).Value = company.VerificationCode;
            myCommand.Parameters.Add(new SqlParameter(@"CompanyName", OleDbType.VarChar)).Value = company.CompanyName;
            myCommand.Parameters.Add(new SqlParameter(@"ContactPersonName", OleDbType.VarChar)).Value = company.ContactPersonName;
            myCommand.Parameters.Add(new SqlParameter(@"BranchName", OleDbType.VarChar)).Value = company.BranchName;
            Int32 newCompanyID = -1;
            try
            {
                myConnection.Open();
                newCompanyID = (Int32)myCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            myConnection.Close();
            return (int)newCompanyID;                        
        }

        //Checks if VerificationCode required for confirming farmer/company registration is correct or not.
        public string checkVerificationCode(string email, string verificationCode)
        {            
            String myString = @"SELECT [VerificationCode] 
                              FROM [FeBiz].[dbo].[Farmer]
                              WHERE [Email] = @Email";
            SqlCommand myCommand = new SqlCommand(myString, myConnection);
            myCommand.Parameters.Add(new SqlParameter(@"Email", OleDbType.VarChar)).Value = email;
            SqlDataReader mySqlDataReader = null;
            string verificationCodeFromDB = string.Empty;            
            try
            {
                myConnection.Open();
                mySqlDataReader = myCommand.ExecuteReader(CommandBehavior.SingleRow);
                while (mySqlDataReader.Read())
                {
                    verificationCodeFromDB = (string)mySqlDataReader["VerificationCode"];
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            mySqlDataReader.Close();
            myConnection.Close();
            if (verificationCodeFromDB.Equals(verificationCode))
            {
                return "Farmer"; //if  user-entered verificationCode was found in the Farmer table, return "Farmer"
            }

            //now, check for company            
            myString = @"SELECT [VerificationCode] 
                       FROM [FeBiz].[dbo].[Company]
                       WHERE [Email] = @Email";
            myCommand = new SqlCommand(myString, myConnection);
            myCommand.Parameters.Add(new SqlParameter(@"Email", OleDbType.VarChar)).Value = email;
            mySqlDataReader = null;
            verificationCodeFromDB = string.Empty;
            try
            {
                myConnection.Open();
                mySqlDataReader = myCommand.ExecuteReader(CommandBehavior.SingleRow);
                while (mySqlDataReader.Read())
                {
                    verificationCodeFromDB = (string)mySqlDataReader["VerificationCode"];
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            mySqlDataReader.Close();
            myConnection.Close();
            if (verificationCodeFromDB.Equals(verificationCode))
            {
                return "Company";//or if user-entered verificationCode was found in the Company table, return "Company"
            }
            return "Invalid"; //if user-entered verificationCode was not found, then return "Invalid"
        }

        public void confirmFarmerRegistration(string email)
        {            
            String myString = @"UPDATE [FeBiz].[dbo].[Farmer] 
                              SET [RegistrationConfirmation] = @RegistrationConfirmation
                              WHERE [Email] = @Email";
            SqlCommand myCommand = new SqlCommand(myString, myConnection);
            myCommand.Parameters.Add(new SqlParameter(@"RegistrationConfirmation", OleDbType.Boolean)).Value = true;
            myCommand.Parameters.Add(new SqlParameter(@"Email", OleDbType.VarChar)).Value = email;
            try
            {
                myConnection.Open();
                myCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            myConnection.Close();            
        }
        
        public void confirmCompanyRegistration(string email)
        {            
            String myString = @"UPDATE [FeBiz].[dbo].[Company] 
                              SET [RegistrationConfirmation] = @RegistrationConfirmation
                              WHERE [Email] = @Email";
            SqlCommand myCommand = new SqlCommand(myString, myConnection);
            myCommand.Parameters.Add(new SqlParameter(@"RegistrationConfirmation", OleDbType.Boolean)).Value = true;
            myCommand.Parameters.Add(new SqlParameter(@"Email", OleDbType.VarChar)).Value = email;
            try
            {
                myConnection.Open();
                myCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            myConnection.Close();            
        }
                
        public int insertOrder(Order order, int companyID)
        {            
            String myString = @"INSERT INTO [FeBiz].[dbo].[BizOrder] ([OrderName], [OrderDate], 
                              [QuantityOrdered], [Unit], [MinimunQuality], [CategoryID], [CompanyID]) 
                              VALUES(@OrderName, @OrderDate, @QuantityOrdered, @Unit, 
                              @MinimunQuality, @CategoryID, @CompanyID); "
                              + "SELECT CAST(scope_identity() AS int)";  
            SqlCommand myCommand = new SqlCommand(myString, myConnection);            
            myCommand.Parameters.Add(new SqlParameter(@"OrderName", OleDbType.VarChar)).Value = order.OrderName;
            myCommand.Parameters.Add(new SqlParameter(@"OrderDate", OleDbType.Date)).Value = order.OrderDate;
            myCommand.Parameters.Add(new SqlParameter(@"QuantityOrdered", OleDbType.Integer)).Value = order.QuantityOrdered;
            myCommand.Parameters.Add(new SqlParameter(@"Unit", OleDbType.VarChar)).Value = order.Unit;
            myCommand.Parameters.Add(new SqlParameter(@"MinimunQuality", OleDbType.Integer)).Value = order.MinimumQuality;
            myCommand.Parameters.Add(new SqlParameter(@"CategoryID", OleDbType.Integer)).Value = order.Category.CategoryID;
            myCommand.Parameters.Add(new SqlParameter(@"CompanyID", OleDbType.Integer)).Value = companyID;
            Int32 newOrderID = -1;
            try
            {
                myConnection.Open();
                newOrderID = (Int32)myCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            myConnection.Close();
            return (int)newOrderID;                        
        }

        public int insertSale(Sale sale, int orderID)
        {            
            String myString = @"INSERT INTO [FeBiz].[dbo].[Sale] ([NumberOfPacket], [FarmerToCompanyRating], 
                              [CompanyToFarmerRating], [ProductID], [OrderID]) 
                              VALUES(@NumberOfPacket, @FarmerToCompanyRating, @CompanyToFarmerRating, 
                              @ProductID, @OrderID); "
                              +"SELECT CAST(scope_identity() AS int)";   
            SqlCommand myCommand = new SqlCommand(myString, myConnection);            
            myCommand.Parameters.Add(new SqlParameter(@"NumberOfPacket", OleDbType.Integer)).Value = sale.NumberOfPackets;
            myCommand.Parameters.Add(new SqlParameter(@"FarmerToCompanyRating", OleDbType.Integer)).Value = sale.FarmerToCompanyRating;
            myCommand.Parameters.Add(new SqlParameter(@"CompanyToFarmerRating", OleDbType.Integer)).Value = sale.CompanyToFarmerRating;
            myCommand.Parameters.Add(new SqlParameter(@"ProductID", OleDbType.Integer)).Value = sale.Product.ProductID;
            myCommand.Parameters.Add(new SqlParameter(@"OrderID", OleDbType.Integer)).Value = orderID;
            Int32 newSaleID = -1;
            try
            {
                myConnection.Open();
                newSaleID = (Int32)myCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            myConnection.Close();
            return (int)newSaleID;                        
        }

        public void updateCompanyToFarmerRating(int saleID, int companyToFarmerRating)
        {            
            String myString = @"UPDATE [FeBiz].[dbo].[Sale] 
                              SET [CompanyToFarmerRating] = @CompanyToFarmerRating
                              WHERE [SaleID] = @SaleID";
            SqlCommand myCommand = new SqlCommand(myString, myConnection);
            myCommand.Parameters.Add(new SqlParameter(@"CompanyToFarmerRating", OleDbType.Integer)).Value = companyToFarmerRating;
            myCommand.Parameters.Add(new SqlParameter(@"SaleID", OleDbType.Integer)).Value = saleID;
            try
            {
                myConnection.Open();
                myCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            myConnection.Close();                                 
        }

        public void updateFarmerToCompanyRating(int saleID, int farmerToCompanyRating)
        {            
            String myString = @"UPDATE [FeBiz].[dbo].[Sale] 
                              SET [FarmerToCompanyRating] = @FarmerToCompanyRating
                              WHERE [SaleID] = @SaleID";
            SqlCommand myCommand = new SqlCommand(myString, myConnection);
            myCommand.Parameters.Add(new SqlParameter(@"FarmerToCompanyRating", OleDbType.Integer)).Value = farmerToCompanyRating;
            myCommand.Parameters.Add(new SqlParameter(@"SaleID", OleDbType.Integer)).Value = saleID;
            try
            {
                myConnection.Open();
                myCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            myConnection.Close();  
        }


        public string authenticate(string email, string password)
        {            
            String myString = @"SELECT [RegistrationConfirmation] 
                              FROM [FeBiz].[dbo].[Farmer]
                              WHERE [Email] = @Email
                              AND [Password] = @Password";
            SqlCommand myCommand = new SqlCommand(myString, myConnection);
            myCommand.Parameters.Add(new SqlParameter(@"Email", OleDbType.VarChar)).Value = email;
            myCommand.Parameters.Add(new SqlParameter(@"Password", OleDbType.Char)).Value = password;            
            SqlDataReader mySqlDataReader = null;
            bool authenticated = false;            
            try
            {
                myConnection.Open();
                mySqlDataReader = myCommand.ExecuteReader(CommandBehavior.SingleRow);
                while (mySqlDataReader.Read())
                {
                    authenticated = (bool)mySqlDataReader["RegistrationConfirmation"];
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            mySqlDataReader.Close();
            myConnection.Close();
            if (authenticated == true)
            {
                return "Farmer";
            }
            
            //now, check for company            
            myString = @"SELECT [RegistrationConfirmation] 
                       FROM [FeBiz].[dbo].[Company]
                       WHERE [Email] = @Email
                       AND [Password] = @Password";
            myCommand = new SqlCommand(myString, myConnection);
            myCommand.Parameters.Add(new SqlParameter(@"Email", OleDbType.VarChar)).Value = email;
            myCommand.Parameters.Add(new SqlParameter(@"Password", OleDbType.Char)).Value = password;
            mySqlDataReader = null;
            authenticated = false;
            try
            {
                myConnection.Open();
                mySqlDataReader = myCommand.ExecuteReader(CommandBehavior.SingleRow);
                while (mySqlDataReader.Read())
                {
                    authenticated = (bool)mySqlDataReader["RegistrationConfirmation"];
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            mySqlDataReader.Close();
            myConnection.Close();
            if (authenticated == true)
            {
                return "Company";
            }
            return "Invalid";            
        }

        public int getBusinessID(string email)
        {        
            String myString = @"SELECT [FarmerID] 
                              FROM [FeBiz].[dbo].[Farmer]
                              WHERE [Email] = @Email";
            SqlCommand myCommand = new SqlCommand(myString, myConnection);
            myCommand.Parameters.Add(new SqlParameter(@"Email", OleDbType.VarChar)).Value = email;
            SqlDataReader mySqlDataReader = null;
            int businessID = -1;
            try
            {
                myConnection.Open();
                mySqlDataReader = myCommand.ExecuteReader(CommandBehavior.SingleRow);
                while (mySqlDataReader.Read())
                {
                    businessID = (int)mySqlDataReader["FarmerID"];
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            mySqlDataReader.Close();
            myConnection.Close();
            if (businessID != -1)
            {
                return businessID;
            }

            //now, for company
            myString = @"SELECT [CompanyID] 
                       FROM [FeBiz].[dbo].[Company]
                       WHERE [Email] = @Email";
            myCommand = new SqlCommand(myString, myConnection);
            myCommand.Parameters.Add(new SqlParameter(@"Email", OleDbType.VarChar)).Value = email;
            mySqlDataReader = null;
            businessID = -1;
            try
            {
                myConnection.Open();
                mySqlDataReader = myCommand.ExecuteReader(CommandBehavior.SingleRow);
                while (mySqlDataReader.Read())
                {
                    businessID = (int)mySqlDataReader["CompanyID"];
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            mySqlDataReader.Close();
            myConnection.Close();
            if (businessID != -1)
            {
                return businessID;
            }            
            return businessID; //if email is not found in any of Farmer and Compnay tables, then return -1            
        }

        public List<string> getAllUniqueCategoryTypes()
        {
            //selects and returns all unique Types from Category table
            List<string> typesList = new List<string>();            
            String myString = @"SELECT DISTINCT [Type] 
                              FROM [FeBiz].[dbo].[Category]";
            SqlCommand myCommand = new SqlCommand(myString, myConnection);
            SqlDataReader mySqlDataReader = null;
            string aType = string.Empty;
            try
            {
                myConnection.Open();
                mySqlDataReader = myCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    aType = (string)mySqlDataReader["Type"];
                    if (!aType.Equals(string.Empty))
                    {
                        typesList.Add(aType);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            mySqlDataReader.Close();
            myConnection.Close();
            return typesList;
        }

        public List<string> getAllSubTypesOfAType(string type)
        {
            //selects and returns all unique subTypes of a type from Category table
            List<string> subTypesList = new List<string>();            
            String myString = @"SELECT DISTINCT [SubType] 
                              FROM [FeBiz].[dbo].[Category]
                              WHERE [Type] = @Type";
            SqlCommand myCommand = new SqlCommand(myString, myConnection);
            myCommand.Parameters.Add(new SqlParameter(@"Type", OleDbType.VarChar)).Value = type;
            SqlDataReader mySqlDataReader = null;
            string aType = string.Empty;
            try
            {
                myConnection.Open();
                mySqlDataReader = myCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    aType = (string)mySqlDataReader["SubType"];
                    if (!aType.Equals(string.Empty))
                    {
                        subTypesList.Add(aType);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            mySqlDataReader.Close();
            myConnection.Close();
            return subTypesList;
        }

        public List<Package> getAllPackagesForAnOrder(Order order)
        {
            //selects and returns all packages from Product table that can be proposed to fulfil an order
            List<Package> packageList = new List<Package>();
            String myString = @"SELECT [ProductID], [ProductName], [OfferExpiry], [TotalQuantity], [PacketSize],
                              [Price], [Quality]
                              FROM [FeBiz].[dbo].[Product]
                              WHERE [CategoryID] = @CategoryID
                              AND [Active] = @Active
                              AND [PacketSizeUnit] = @PacketSizeUnit
                              AND [Quality] >= @Quality";
            SqlCommand myCommand = new SqlCommand(myString, myConnection);
            myCommand.Parameters.Add(new SqlParameter(@"CategoryID", OleDbType.Integer)).Value = order.Category.CategoryID;
            myCommand.Parameters.Add(new SqlParameter(@"Active", OleDbType.Boolean)).Value = true;
            myCommand.Parameters.Add(new SqlParameter(@"PacketSizeUnit", OleDbType.VarChar)).Value = order.Unit;
            myCommand.Parameters.Add(new SqlParameter(@"Quality", OleDbType.VarChar)).Value = order.MinimumQuality;
            SqlDataReader mySqlDataReader = null;
            Package aPackage = null;
            try
            {
                myConnection.Open();
                mySqlDataReader = myCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    aPackage = new Package();
                    aPackage.ProductID = (int)mySqlDataReader["ProductID"];
                    aPackage.ProductName = (string)mySqlDataReader["ProductName"];
                    aPackage.OfferExpiry = (DateTime)mySqlDataReader["OfferExpiry"];
                    aPackage.AvailableQuantity = (int)mySqlDataReader["TotalQuantity"];
                    aPackage.PacketSize = (int)mySqlDataReader["PacketSize"];
                    aPackage.Price = (double)mySqlDataReader["Price"];
                    aPackage.Quality = (int)mySqlDataReader["Quality"];
                    packageList.Add(aPackage);                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            mySqlDataReader.Close();
            myConnection.Close();
            return packageList;
        }

        public int getAllSoldQuantitiesOfAProduct(int productID)
        {
            //selects all sold quantities of a product from Sale table and then calculates and returns total 
            //sold quantity of the product
            String myString = @"SELECT [NumberOfPacket]
                              FROM [FeBiz].[dbo].[Sale]
                              WHERE [ProductID] = @ProductID";
            SqlCommand myCommand = new SqlCommand(myString, myConnection);
            myCommand.Parameters.Add(new SqlParameter(@"ProductID", OleDbType.Integer)).Value = productID;            
            SqlDataReader mySqlDataReader = null;
            int soldQuantity = 0;
            try
            {
                myConnection.Open();
                mySqlDataReader = myCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    soldQuantity += (int)mySqlDataReader["NumberOfPacket"];                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            mySqlDataReader.Close();
            myConnection.Close();
            return soldQuantity;
        }

        public bool changeFarmerPassword(string email, string oldPassword, string newPassword)
        {
            String myString = @"UPDATE [FeBiz].[dbo].[Farmer] 
                              SET [Password] = @NewPassword
                              WHERE [Email] = @Email 
                              AND [Password] = @OldPassword";
            SqlCommand myCommand = new SqlCommand(myString, myConnection);
            myCommand.Parameters.Add(new SqlParameter(@"OldPassword", OleDbType.Char)).Value = oldPassword;
            myCommand.Parameters.Add(new SqlParameter(@"NewPassword", OleDbType.Char)).Value = newPassword;
            myCommand.Parameters.Add(new SqlParameter(@"Email", OleDbType.VarChar)).Value = email;
            try
            {
                myConnection.Open();
                myCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            myConnection.Close();
              
            myString = @"SELECT [Password]
                       FROM [FeBiz].[dbo].[Farmer]
                       WHERE [Email] = @Email";
            myCommand = new SqlCommand(myString, myConnection);
            myCommand.Parameters.Add(new SqlParameter(@"Email", OleDbType.VarChar)).Value = email;
            SqlDataReader mySqlDataReader = null;
            bool passwordChanged = false;
            try
            {
                myConnection.Open();
                mySqlDataReader = myCommand.ExecuteReader(CommandBehavior.SingleRow);
                while (mySqlDataReader.Read())
                {
                    string newPasswordInDB = (string)mySqlDataReader["Password"];
                    if(newPasswordInDB.Trim().Equals(newPassword))
                    {
                        passwordChanged = true;
                    
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            mySqlDataReader.Close();
            myConnection.Close();
            return passwordChanged;        
        }

        public bool changeCompanyPassword(string email, string oldPassword, string newPassword)
        {
            String myString = @"UPDATE [FeBiz].[dbo].[Company] 
                              SET [Password] = @NewPassword
                              WHERE [Email] = @Email 
                              AND [Password] = @OldPassword";
            SqlCommand myCommand = new SqlCommand(myString, myConnection);
            myCommand.Parameters.Add(new SqlParameter(@"OldPassword", OleDbType.Char)).Value = oldPassword;
            myCommand.Parameters.Add(new SqlParameter(@"NewPassword", OleDbType.Char)).Value = newPassword;
            myCommand.Parameters.Add(new SqlParameter(@"Email", OleDbType.VarChar)).Value = email;
            try
            {
                myConnection.Open();
                myCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            myConnection.Close();

            myString = @"SELECT [Password]
                       FROM [FeBiz].[dbo].[Company]
                       WHERE [Email] = @Email";
            myCommand = new SqlCommand(myString, myConnection);
            myCommand.Parameters.Add(new SqlParameter(@"Email", OleDbType.VarChar)).Value = email;
            SqlDataReader mySqlDataReader = null;
            bool passwordChanged = false;
            try
            {
                myConnection.Open();
                mySqlDataReader = myCommand.ExecuteReader(CommandBehavior.SingleRow);
                while (mySqlDataReader.Read())
                {
                    string newPasswordInDB = (string)mySqlDataReader["Password"];
                    if (newPasswordInDB.Trim().Equals(newPassword))
                    {
                        passwordChanged = true;

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            mySqlDataReader.Close();
            myConnection.Close();
            return passwordChanged;
        }

        public List<Product> getAllProductsOfAFarmer(int farmerID)
        {
            string myString = @"SELECT *
                              FROM [FeBiz].[dbo].[Product]
                              WHERE [FarmerID] = @FarmerID";
            SqlCommand myCommand = new SqlCommand(myString, myConnection);
            myCommand.Parameters.Add(new SqlParameter(@"FarmerID", OleDbType.Integer)).Value = farmerID;
            SqlDataReader mySqlDataReader = null;
            List<Product> productsList = new List<Product>();
            Product aProduct = null;
            try
            {
                myConnection.Open();
                mySqlDataReader = myCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    aProduct = new Product();
                    aProduct.ProductID = (int)mySqlDataReader["ProductID"];
                    aProduct.Name = (string)mySqlDataReader["ProductName"];
                    aProduct.OfferExpiry = (DateTime)mySqlDataReader["OfferExpiry"];
                    aProduct.TotalQuantity = (int)mySqlDataReader["TotalQuantity"];                    
                    aProduct.PacketSize = (int)mySqlDataReader["PacketSize"];
                    aProduct.PacketSizeUnit = (string)mySqlDataReader["PacketSizeUnit"];
                    aProduct.Active = (bool)mySqlDataReader["Active"];
                    aProduct.Price = (double)mySqlDataReader["Price"];
                    aProduct.Quality = (int)mySqlDataReader["Quality"];
                    aProduct.RegistrationDate = (DateTime)mySqlDataReader["RegistrationDate"];
                    aProduct.Category.CategoryID = (int)mySqlDataReader["CategoryID"];                    
                    productsList.Add(aProduct);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            mySqlDataReader.Close();
            myConnection.Close();
            return productsList;        
        }

        public List<Renewal> getAllRenewalsOfAProduct(int productID)
        {
            string myString = @"SELECT *
                              FROM [FeBiz].[dbo].[Renewal]
                              WHERE [ProductID] = @ProductID";
            SqlCommand myCommand = new SqlCommand(myString, myConnection);
            myCommand.Parameters.Add(new SqlParameter(@"ProductID", OleDbType.Integer)).Value = productID;
            SqlDataReader mySqlDataReader = null;
            List<Renewal> renewalsList = new List<Renewal>();
            Renewal aRenewal = null;
            try
            {
                myConnection.Open();
                mySqlDataReader = myCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    aRenewal = new Renewal();
                    aRenewal.RenewalID = (int)mySqlDataReader["RenewalID"];
                    aRenewal.RenewalDate = (DateTime)mySqlDataReader["RenewalDate"];
                    renewalsList.Add(aRenewal);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            mySqlDataReader.Close();
            myConnection.Close();
            return renewalsList;
        }

        public List<Order> getAllOrdersOfACompany(int companyID)
        {
            string myString = @"SELECT *
                              FROM [FeBiz].[dbo].[BizOrder]
                              WHERE [CompanyID] = @CompanyID";
            SqlCommand myCommand = new SqlCommand(myString, myConnection);
            myCommand.Parameters.Add(new SqlParameter(@"CompanyID", OleDbType.Integer)).Value = companyID;
            SqlDataReader mySqlDataReader = null;
            List<Order> ordersList = new List<Order>();
            Order anOrder = null;
            try
            {
                myConnection.Open();
                mySqlDataReader = myCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    anOrder = new Order();
                    anOrder.OrderID = (int)mySqlDataReader["OrderID"];
                    anOrder.OrderName = (string)mySqlDataReader["OrderName"];
                    anOrder.OrderDate = (DateTime)mySqlDataReader["OrderDate"];
                    anOrder.QuantityOrdered = (int)mySqlDataReader["QuantityOrdered"];
                    anOrder.Unit = (string)mySqlDataReader["Unit"];
                    anOrder.MinimumQuality = (int)mySqlDataReader["MinimunQuality"];
                    anOrder.Category.CategoryID = (int)mySqlDataReader["CategoryID"];
                    ordersList.Add(anOrder);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            mySqlDataReader.Close();
            myConnection.Close();
            return ordersList;
        }

        public List<Sale> getAllSalesOfAProduct(int productID)
        {
            string myString = @"SELECT *
                              FROM [FeBiz].[dbo].[Sale]
                              WHERE [ProductID] = @ProductID";
            SqlCommand myCommand = new SqlCommand(myString, myConnection);
            myCommand.Parameters.Add(new SqlParameter(@"ProductID", OleDbType.Integer)).Value = productID;
            SqlDataReader mySqlDataReader = null;
            List<Sale> salesList = new List<Sale>();
            Sale aSale = null;
            try
            {
                myConnection.Open();
                mySqlDataReader = myCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    aSale = new Sale();
                    aSale.SaleID = (int)mySqlDataReader["SaleID"];
                    aSale.NumberOfPackets = (int)mySqlDataReader["NumberOfPacket"];
                    aSale.FarmerToCompanyRating = (int)mySqlDataReader["FarmerToCompanyRating"];
                    aSale.CompanyToFarmerRating = (int)mySqlDataReader["CompanyToFarmerRating"];
                    salesList.Add(aSale);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            mySqlDataReader.Close();
            myConnection.Close();
            return salesList;
        }

        public List<Sale> getAllSalesInAnOrder(int orderID)
        {
            string myString = @"SELECT *
                              FROM [FeBiz].[dbo].[Sale]
                              WHERE [OrderID] = @OrderID";
            SqlCommand myCommand = new SqlCommand(myString, myConnection);
            myCommand.Parameters.Add(new SqlParameter(@"OrderID", OleDbType.Integer)).Value = orderID;
            SqlDataReader mySqlDataReader = null;
            List<Sale> salesList = new List<Sale>();
            Sale aSale = null;
            try
            {
                myConnection.Open();
                mySqlDataReader = myCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    aSale = new Sale();
                    aSale.SaleID = (int)mySqlDataReader["SaleID"];
                    aSale.NumberOfPackets = (int)mySqlDataReader["NumberOfPacket"];
                    aSale.FarmerToCompanyRating = (int)mySqlDataReader["FarmerToCompanyRating"];
                    aSale.CompanyToFarmerRating = (int)mySqlDataReader["CompanyToFarmerRating"];
                    aSale.Product.ProductID = (int)mySqlDataReader["ProductID"];
                    salesList.Add(aSale);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            mySqlDataReader.Close();
            myConnection.Close();
            return salesList;
        }

        public Farmer viewFarmerProfile(int farmerID)
        {
            string myString = @"SELECT *
                              FROM [FeBiz].[dbo].[Farmer]
                              WHERE [FarmerID] = @FarmerID";
            SqlCommand myCommand = new SqlCommand(myString, myConnection);
            myCommand.Parameters.Add(new SqlParameter(@"FarmerID", OleDbType.Integer)).Value = farmerID;
            SqlDataReader mySqlDataReader = null;            
            Farmer farmer = new Farmer();
            try
            {
                myConnection.Open();
                mySqlDataReader = myCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    farmer.BusinessID = (int)mySqlDataReader["FarmerID"];
                    farmer.Phone = (string)mySqlDataReader["Phone"];
                    farmer.Fax = (string)mySqlDataReader["Fax"];
                    farmer.Email = (string)mySqlDataReader["Email"];
                    farmer.RegistrationDate = (DateTime)mySqlDataReader["RegistrationDate"];
                    farmer.AddressLine1 = (string)mySqlDataReader["AddressLine1"];
                    farmer.AddressLine2 = (string)mySqlDataReader["AddressLine2"];
                    farmer.PostCode = (string)mySqlDataReader["PostCode"];
                    farmer.City = (string)mySqlDataReader["City"];
                    farmer.Country = (string)mySqlDataReader["Country"];
                    farmer.Name = (string)mySqlDataReader["FarmerName"];
                    farmer.BankAccountNumber = (string)mySqlDataReader["BankAccountNumber"];
                    farmer.BankAccountTitle = (string)mySqlDataReader["BankAccountTitle"];
                    farmer.IBAN = (string)mySqlDataReader["IBAN"];
                    farmer.SwiftBIC = (string)mySqlDataReader["SwiftBIC"];
                    farmer.BankName = (string)mySqlDataReader["BankName"];
                    farmer.BankBranchName = (string)mySqlDataReader["BankBranchName"];                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            mySqlDataReader.Close();
            myConnection.Close();
            return farmer;
        }

        public Company viewCompanyProfile(int companyID)
        {
            string myString = @"SELECT *
                              FROM [FeBiz].[dbo].[Company]
                              WHERE [CompanyID] = @CompanyID";
            SqlCommand myCommand = new SqlCommand(myString, myConnection);
            myCommand.Parameters.Add(new SqlParameter(@"CompanyID", OleDbType.Integer)).Value = companyID;
            SqlDataReader mySqlDataReader = null;
            Company company = new Company();
            try
            {
                myConnection.Open();
                mySqlDataReader = myCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    company.BusinessID = (int)mySqlDataReader["CompanyID"];
                    company.Phone = (string)mySqlDataReader["Phone"];
                    company.Fax = (string)mySqlDataReader["Fax"];
                    company.Email = (string)mySqlDataReader["Email"];
                    company.RegistrationDate = (DateTime)mySqlDataReader["RegistrationDate"];
                    company.AddressLine1 = (string)mySqlDataReader["AddressLine1"];
                    company.AddressLine2 = (string)mySqlDataReader["AddressLine2"];
                    company.PostCode = (string)mySqlDataReader["PostCode"];
                    company.City = (string)mySqlDataReader["City"];
                    company.Country = (string)mySqlDataReader["Country"];
                    company.CompanyName = (string)mySqlDataReader["CompanyName"];
                    company.ContactPersonName = (string)mySqlDataReader["ContactPersonName"];
                    company.BranchName = (string)mySqlDataReader["BranchName"];                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            mySqlDataReader.Close();
            myConnection.Close();
            return company;
        }

        public void updateFarmerProfile(Farmer farmer)
        {
            string myString = @"UPDATE [FeBiz].[dbo].[Farmer]
                              SET [Phone] = @Phone,
                              [Fax] = @Fax,
                              [AddressLine1] = @AddressLine1,
                              [AddressLine2] = @AddressLine2,  
                              [PostCode] = @PostCode,    
                              [City] = @City,      
                              [Country] = @Country,
                              [FarmerName] = @FarmerName,
                              [BankAccountNumber] = @BankAccountNumber,
                              [BankAccountTitle] = @BankAccountTitle,
                              [IBAN] = @IBAN,
                              [SwiftBIC] = @SwiftBIC,
                              [BankName] = @BankName,
                              [BankBranchName] = @BankBranchName        
                              WHERE [FarmerID] = @FarmerID";
            SqlCommand myCommand = new SqlCommand(myString, myConnection);
            myCommand.Parameters.Add(new SqlParameter(@"FarmerID", OleDbType.Integer)).Value = farmer.BusinessID ;
            myCommand.Parameters.Add(new SqlParameter(@"Phone", OleDbType.VarChar)).Value = farmer.Phone;
            myCommand.Parameters.Add(new SqlParameter(@"Fax", OleDbType.VarChar)).Value = farmer.Fax;
            myCommand.Parameters.Add(new SqlParameter(@"AddressLine1", OleDbType.VarChar)).Value = farmer.AddressLine1;
            myCommand.Parameters.Add(new SqlParameter(@"AddressLine2", OleDbType.VarChar)).Value = farmer.AddressLine2;
            myCommand.Parameters.Add(new SqlParameter(@"PostCode", OleDbType.VarChar)).Value = farmer.PostCode;
            myCommand.Parameters.Add(new SqlParameter(@"City", OleDbType.VarChar)).Value = farmer.City;
            myCommand.Parameters.Add(new SqlParameter(@"Country", OleDbType.VarChar)).Value = farmer.Country;
            myCommand.Parameters.Add(new SqlParameter(@"FarmerName", OleDbType.VarChar)).Value = farmer.Name;
            myCommand.Parameters.Add(new SqlParameter(@"BankAccountNumber", OleDbType.VarChar)).Value = farmer.BankAccountNumber;
            myCommand.Parameters.Add(new SqlParameter(@"BankAccountTitle", OleDbType.VarChar)).Value = farmer.BankAccountTitle;
            myCommand.Parameters.Add(new SqlParameter(@"IBAN", OleDbType.VarChar)).Value = farmer.IBAN;
            myCommand.Parameters.Add(new SqlParameter(@"SwiftBIC", OleDbType.VarChar)).Value = farmer.SwiftBIC;
            myCommand.Parameters.Add(new SqlParameter(@"BankName", OleDbType.VarChar)).Value = farmer.BankName;
            myCommand.Parameters.Add(new SqlParameter(@"BankBranchName", OleDbType.VarChar)).Value = farmer.BankBranchName;
            try
            {
                myConnection.Open();
                myCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            myConnection.Close();
        }

        public void updateCompanyProfile(Company company)
        {
            string myString = @"UPDATE [FeBiz].[dbo].[Company]
                              SET [Phone] = @Phone,
                              [Fax] = @Fax,
                              [AddressLine1] = @AddressLine1,
                              [AddressLine2] = @AddressLine2,  
                              [PostCode] = @PostCode,    
                              [City] = @City,      
                              [Country] = @Country,
                              [CompanyName] = @CompanyName,
                              [ContactPersonName] = @ContactPersonName,
                              [BranchName] = @BranchName
                              WHERE [CompanyID] = @CompanyID";
            SqlCommand myCommand = new SqlCommand(myString, myConnection);
            myCommand.Parameters.Add(new SqlParameter(@"CompanyID", OleDbType.Integer)).Value = company.BusinessID;
            myCommand.Parameters.Add(new SqlParameter(@"Phone", OleDbType.VarChar)).Value = company.Phone;
            myCommand.Parameters.Add(new SqlParameter(@"Fax", OleDbType.VarChar)).Value = company.Fax;
            myCommand.Parameters.Add(new SqlParameter(@"AddressLine1", OleDbType.VarChar)).Value = company.AddressLine1;
            myCommand.Parameters.Add(new SqlParameter(@"AddressLine2", OleDbType.VarChar)).Value = company.AddressLine2;
            myCommand.Parameters.Add(new SqlParameter(@"PostCode", OleDbType.VarChar)).Value = company.PostCode;
            myCommand.Parameters.Add(new SqlParameter(@"City", OleDbType.VarChar)).Value = company.City;
            myCommand.Parameters.Add(new SqlParameter(@"Country", OleDbType.VarChar)).Value = company.Country;
            myCommand.Parameters.Add(new SqlParameter(@"CompanyName", OleDbType.VarChar)).Value = company.CompanyName;
            myCommand.Parameters.Add(new SqlParameter(@"ContactPersonName", OleDbType.VarChar)).Value = company.ContactPersonName;
            myCommand.Parameters.Add(new SqlParameter(@"BranchName", OleDbType.VarChar)).Value = company.BranchName;            
            try
            {
                myConnection.Open();
                myCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            myConnection.Close();
        }

        public int getCategroyID(string type, string subType)
        {
            string myString = @"SELECT [CategoryID]
                              FROM [FeBiz].[dbo].[Category]
                              WHERE [Type] = @Type
                              AND [SubType] = @SubType";
            SqlCommand myCommand = new SqlCommand(myString, myConnection);
            myCommand.Parameters.Add(new SqlParameter(@"Type", OleDbType.VarChar)).Value = type;
            myCommand.Parameters.Add(new SqlParameter(@"SubType", OleDbType.VarChar)).Value = subType;
            SqlDataReader mySqlDataReader = null;            
            int categoryID = -1;
            try
            {
                myConnection.Open();
                mySqlDataReader = myCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    categoryID = (int)mySqlDataReader["CategoryID"];
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            mySqlDataReader.Close();
            myConnection.Close();
            return categoryID;
        }

        public string getFarmerOrCompanyName(string email)
        {
            string myString = @"SELECT [FarmerName]
                              FROM [FeBiz].[dbo].[Farmer]
                              WHERE [Email] = @Email";
            SqlCommand myCommand = new SqlCommand(myString, myConnection);
            myCommand.Parameters.Add(new SqlParameter(@"Email", OleDbType.VarChar)).Value = email;            
            SqlDataReader mySqlDataReader = null;            
            string name = string.Empty;
            try
            {
                myConnection.Open();
                mySqlDataReader = myCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    name = (string)mySqlDataReader["FarmerName"];
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            mySqlDataReader.Close();
            myConnection.Close();

            if (!name.Equals(string.Empty))
            {
                return name; //if it was a farmer, return FarmerName            
            }

            //now, for company
            myString = @"SELECT [CompanyName]
                       FROM [FeBiz].[dbo].[Company]
                       WHERE [Email] = @Email";
            myCommand = new SqlCommand(myString, myConnection);
            myCommand.Parameters.Add(new SqlParameter(@"Email", OleDbType.VarChar)).Value = email;
            mySqlDataReader = null;
            name = string.Empty;
            try
            {
                myConnection.Open();
                mySqlDataReader = myCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    name = (string)mySqlDataReader["CompanyName"];
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            mySqlDataReader.Close();
            myConnection.Close();

            if (!name.Equals(string.Empty))
            {
                return name; //if it was a company, return CompanyName            
            }
            return name; //if not found, then return string.Empty            
        }

    }
}

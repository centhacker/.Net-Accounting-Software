using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using System.Data.Entity;
using System.Data;
using System.Data.SqlClient;



namespace TradingBLL.Muneeb
{
   public sealed class CRUD
    {
       public static ILog log = LogManager.GetLogger("logger");
       
       static TradingEntities obj = new TradingEntities();


       public static List<ComplexProductsOfPackingList> ShowProductsOfPackingList(String PackingList) {
           return obj.ShowProductsOfPackingList(PackingList).ToList();
       }
       public static bool InsertPackingList(String id,String Listname) {
           try
           {
               obj.InsertPackingList(Convert.ToInt32(id),Listname);
               return true;
           }
           catch 
           {

               return false;
           }
       }

       #region CharOfAccounts
       public static bool InsertChartOfAccounts(String Name,String AccountType, DateTime E_date) {
           try
           {
               String Query = "select max(cast(substring(num,2,10) as int)) from chartofaccounts where (type = '"+AccountType+"')";
               String AccountNum = String.Empty;
            
               String ID  = String.Empty;
               try
               {
                    int IncrementID = 0;
                    //TradingBLL.Muneeb.DB.TradingConnection.Open();
                    TradingBLL.Muneeb.DB.MyCommand = new SqlCommand(Query,TradingBLL.Muneeb.DB.TradingConnection);
                    var GetId = TradingBLL.Muneeb.DB.MyCommand.ExecuteScalar();
                    IncrementID = (Convert.ToInt32(GetId));
                    IncrementID++;
                    ID = (IncrementID).ToString();
                   //TradingBLL.Muneeb.DB.TradingConnection.Open();
               }
               catch 
               {
                  //TradingBLL.Muneeb.DB.TradingConnection.Open();
                   ID = "1";
               }
               
               if (ID.Length == 1)
               {
                   AccountNum = "00" + ID;
               }
               else if (ID.Length>1)
               {
                   AccountNum = "0" + ID;
               }
               if (AccountType=="Assets")
               {
                   AccountNum = "1" + AccountNum;
               }
               else if (AccountType == "Equity")
               {
                   AccountNum = "2" + AccountNum;
               }
               else if (AccountType == "Expense")
               {
                   AccountNum = "3" + AccountNum;
               }
               else if (AccountType == "Liability")
               {
                   AccountNum = "4" + AccountNum;
               }
               else if (AccountType == "Revenue")
               {
                   AccountNum = "5" + AccountNum;
               }


               obj.InsertCharOfAccount(AccountNum,Name,AccountType,E_date);
               return true;
           }
           catch (Exception ex)
           {
               log.Error("Chart Of Accounts: " + ex);
               return false;
           }
       }
       public static bool DeleteChartOfAccounts(String ID) {
           try
           {
               obj.DeleteChartOfAccounts(Convert.ToInt32(ID));
               return true;
                   
           }
           catch 
           {

               return false;
           }
       }

       public static List<ComplexChartOfAccounts> ShowChartOfAccounts() {
          return obj.ShowChartOfAccounts().ToList();
       }
       #endregion


       #region Bank

       public static bool DeleteBank(String Id) {
           try
           {
               obj.DeleteBank(Convert.ToInt32(Id));
               return true;
           }
           catch (Exception ex)
           {
               log.Error("Delete Bank: "+ex);
               return false;
           }
       }
       public static List<complexbank> ShowBank() {
        return   obj.ShowBank().ToList();
       }
       public static bool InsertBank(String AccountNo,String AccountName,String AccountType,String AccountBalance,String Branch
           ,String Address,String BranchCode,String Currency, String BankEmail,String BankNo, DateTime eDate, DateTime mDate) {
           try
           {
               obj.InsertBank(AccountNo,AccountName,AccountType,Convert.ToSingle(AccountBalance),Branch,
                   Address,BranchCode,BankNo,Currency,BankEmail,eDate,mDate);
               return true;
           }
           catch (Exception ex)
           {

               log.Error("Insert Bank: "+ex);
               return false;
           }
       }
       #endregion


       #region Payments
       public static List<ComplexPayments> ShowPayments() {
           return obj.ShowPayments().ToList();
       }
       public static bool InsertPayments(String Type, DateTime E_date, DateTime M_date) {
           try
           {
               obj.InsertPayments(Type, E_date, M_date);
               return true;
           }
           
         
           catch (Exception ex)
           {

               log.Error("Insert Delete" + ex);
               return false;
           }
           
       }
       public static bool DeletePayments(String Type) {
           try
           {
               obj.DeletePayments(Type);
               return true;
           }
           catch (Exception ex)
           {

               log.Error("Payments Delete" + ex);
               return false;
           }
       }
       #endregion


       #region Currency & Exchange
       public static bool InsertCurrency(String name, DateTime E_date,DateTime M_date) {
           try
           {
               obj.InsertCurrency(name,E_date,M_date);
               return true;
           }
             
           catch (Exception ex)
           {

               log.Error("Curency Insert" + ex);
               return false;
           }
       }
       public static bool InsertExchangeRate(String Currency1, String Currency2, String ExRate, DateTime E_date,DateTime M_date ) {
           try
           {
               obj.InsertExchangeRate(Currency1,Currency2,Convert.ToSingle(ExRate),E_date,M_date);
               return true;
           }
           catch (Exception ex)
           {

               log.Error("Curency Insert" + ex);
               return false;
           }
       }
       public static List<String> ShowCurrency() {
           List<ComplexCurrency> Get = obj.ShowCurrency().ToList();
          List<String> Set = new List<String>();
           for (int i = 0; i < Get.Count; i++)
           {
               Set.Add( Get[i].Currency.ToString());
           }
           return Set;
       }
       public static List<ComplexExRate> ShowExchangeRate()
       {
           return obj.ShowExchangeRates().ToList();
       }
       public static bool DeleteCurrency(String CurrencyName) {
           try
           {
               obj.DeleteCurrency(CurrencyName);
               return true;
           }
           catch (Exception ex)
           {

               log.Error("Curency Delete" + ex);
               return false;
           }
       }
       #endregion


       #region Orders
       public static List<ComplexOrders> ShowOrders() {
           return obj.ShowOrder().ToList();
       }
       public static bool InsertOrder(String BuyerName, String OrderName,String OrderTotal, DateTime OrderDate, DateTime RequiredDate, DateTime ShippedDate, String Ref, DateTime E_date,DateTime M_date) {
           try
           {
               obj.InsertOrder(BuyerName,OrderName,OrderDate,Convert.ToSingle(OrderTotal),RequiredDate,ShippedDate,Ref,E_date, M_date);
               return true;
           }
           catch (Exception ex)
           {
               log.Error("Order: "+ex);
               return false;
           }
       }

       public static bool UpdateOrder(int OrderID,String BuyerName, String OrderName, String OrderTotal, DateTime OrderDate, DateTime RequiredDate, DateTime ShippedDate, String Ref, DateTime E_date, DateTime M_date)
       {
           try
           {
               obj.UpdateOrder(OrderID, BuyerName, OrderName, OrderDate, Convert.ToSingle(OrderTotal), RequiredDate, ShippedDate, Ref, E_date, M_date);
               return true;
           }
           catch (Exception ex)
           {
               log.Error("Order: " + ex);
               return false;
           }
       }

       public static bool DeleteOrder(String OrderName, String BuyerName,String OrderTotal, DateTime requiredDAte, DateTime OrderDate) {
           try
           {
               obj.DeleteOrder(OrderName,BuyerName,Convert.ToSingle( OrderTotal),OrderDate,requiredDAte);
               return true;
           }
           catch (Exception ex)
           {
               log.Error("Order: " + ex);
               return false;
           }
       }
       #endregion
       

       #region Order Products
       public static List<ComplexOrderDetails> ShowOrderDetails(string OrderID) {
           try
           {
               return obj.ShowOrderDetails(Convert.ToInt32( OrderID)).ToList();
           }
           catch (Exception ex)
           {
               log.Error("Showind Order Product Details: "+ex);
               return null;
               
           }
           
       }

       public static void InsertOrderProducts(int OrderId,String ProductName,String Prd_sp,String prd_quantity,String PrdCurrency,String PaymentType,String Total) {
           try
           {
               obj.InsertOrderProducts(OrderId,ProductName,Convert.ToSingle( Prd_sp),Convert.ToInt32( prd_quantity),PrdCurrency,Convert.ToSingle(Total));
           }
           catch (Exception ex)
           {
               log.Error("Showind Order Product Details: "+ex);
               
           }
       }
       #endregion


       #region Product
       public static List<ComplexProducts> ShowProducts() {
           
           return obj.ShowProducts().ToList();

       }
       public static bool InsertProduct(string name,float CostPrice, float SalePrice,string Description,string category,DateTime e_date,DateTime m_date) {
           try
           {
               obj.InsertProduct(name,Convert.ToString(CostPrice),Convert.ToString(SalePrice),Description,category,e_date,m_date);
               return true;
           }
           catch (Exception ex)
           {
               
               log.Error("Products Insert"+ex);
               return false;
               
           }
       }
       public static bool UpdateProduct(int Id,string name, float CostPrice, float SalePrice, string Description, string category, DateTime e_date, DateTime m_date)
       {
           try
           {
               obj.UpdateProduct(Id,name, Convert.ToString(CostPrice), Convert.ToString(SalePrice), Description, category, m_date);
               return true;
           }
           catch (Exception ex)
           {

               log.Error("Products Update" + ex);
               return false;

           }
       }
       public static bool DeleteProduct(int Id) {
           try
           {
               obj.DeleteProduct(Id);
               return true;
           }
           catch (Exception ex)
           {
               

               log.Error("Products DElete"+ex);
               return false;
           }
       }
        #endregion


       #region Supplier
       public static List<ComplexSupplier> ShowSupplier() {
           return obj.ShowSupplier().ToList();
       }
       public static bool InsertSupplier(string name,string contact,string email,string company,string remarks,DateTime e_date,DateTime m_date) {
           try
           {
               obj.InsertSupplier(name,contact,email,company,remarks,e_date,m_date);
               return true;
           }
           catch (Exception ex)
           {

               log.Error("Supplier Insert"+ex);
               return false;
           }
       }
       public static bool UpdateSupplier(int id,string name,string contact,string email,string company,string remarks,DateTime e_date,DateTime m_date) {

           try
           {
               obj.UpdateSupplier(id,name, contact, email, company, remarks,  m_date);
               return true;
           }
           catch (Exception ex)
           {

               log.Error("Supplier Update" + ex);
               return false;
           }
       }
       public static bool DeleteSupplier(int id) {
           try
           {
               obj.DeleteSupplier(id);
               return true;
           }
           catch (Exception ex)
           {

               log.Error("Supplier Delete" + ex);
               return false;
           }
       }
        #endregion


       #region Freight
       public static List<ComplexFreight> ShowFreight()
       {
           return obj.ShowFreight().ToList();
       }
       public static bool InsertFreight(string name, string company, string refrence, string email, DateTime e_date, DateTime m_date)
       {
           try
           {
               obj.InsertFreight(name,company,refrence,email,e_date,m_date);
               return true;
           }
           catch (Exception ex)
           {

               log.Error("Freight Insert" + ex);
               return false;
           }
       }
       public static bool UpdateFreight(int id, string name, string company, string refrence, string email,DateTime e_date,  DateTime m_date)
       {

           try
           {
               obj.UpdateFreight(id, name, company, refrence, email,e_date,  m_date);
               return true;
           }
           catch (Exception ex)
           {

               log.Error("Freight Update" + ex);
               return false;
           }
       }
       public static bool DeleteFreight(int id)
       {
           try
           {
               obj.DeleteFreight(id);
               return true;
           }
           catch (Exception ex)
           {

               log.Error("Freight Delete" + ex);
               return false;
           }
       }
        #endregion


       #region Buyer
       public static List<ComplexBuyer> ShowBuyer()
       {
           return obj.ShowBuyer().ToList();
       }
       public static bool InsertBuyer(string name,string contact,string email,string account,string company,string remarks,DateTime e_date, DateTime m_date)
       {
           try
           {
               obj.InsertBuyer(name,contact,email,account,company,remarks,e_date,m_date);
               return true;
           }
           catch (Exception ex)
           {

               log.Error("Buyer Insert" + ex);
               return false;
           }
       }
       public static bool UpdateBuyer(int id, string name, string contact, string email, string account, string company, string remarks, DateTime e_date, DateTime m_date)
       {

           try
           {
               obj.UpdateBuyer(id, name, contact, email, account, company, remarks, m_date);
               return true;
           }
           catch (Exception ex)
           {

               log.Error("Buyer Update" + ex);
               return false;
           }
       }
       public static bool DeleteBuyer(int id)
       {
           try
           {
               obj.DeleteBuyer(id);
               return true;
           }
           catch (Exception ex)
           {

               log.Error("Buyer Delete" + ex);
               return false;
           }
       }
        #endregion

    }
}

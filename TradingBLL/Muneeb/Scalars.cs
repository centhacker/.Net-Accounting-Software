using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradingBLL.Muneeb
{
    public sealed class Scalars
    {
      static TradingEntities obj = new TradingEntities();


      public static String[] ShowPackingList() {
          List<ScalarPackingList> Get = obj.ShowPackingList().ToList();
          String[] Set = new String[Get.Count];
          for (int i = 0; i < Get.Count; i++)
          {
              Set[i] = Get[i].pck.ToString();
          }
          return Set;
      }
        //Show Account info in general journal
      public static String[] ShowAccountsInfo() {
          List<ComplexChartOfAccounts> Get = obj.ShowChartOfAccounts().ToList();
          String[] Set = new String[Get.Count];
          for (int i = 0; i < Get.Count; i++)
          {
              Set[i] = Get[i].ID + "|"+Get[i].ACCOUNT_ID+"|"+Get[i].NAME;
          }
          return Set;
      
      }


        // Show Ledgers types

      public static String[] ShowLedgerTypes() {
    List<ScalarAccountType> Get = obj.ShowLedgers().ToList(); 
          String[] Set = new String[Get.Count];
          for (int i = 0; i < Get.Count; i++)
          {
              
              Set[i] = Get[i].type;
          }
          return Set;
      
      }


      //Show BuyerName with shipment name with order name

      public static String[] ShowBuyerNameOrderNameShipmentNameForInvoice()
      {
          List<scalarBuyerNameOrderNameInvoice> Get = obj.ShowBuyerNameWithOrderNameWithShipmentNameForInvoice().ToList();
          String[] Set = new String[Get.Count];
          for (int i = 0; i < Get.Count; i++)
          {
              Set[i] = Get[i].id+"|"+Get[i].BUYER_NAME + "|" + Get[i].order_name + "|" + Get[i].Ship_name;
          }
          return Set;

      }

        //Show shipment orders id

      public static int ShowShipmentOrdersId(String ShipmentName, String Orderid,String OrderName,String ShipmentTotal,String ServiceChaeges
          ,String PaymentType, String Currency) {
          List<ScalarShipmentOrderID> Get = obj.ShowShipmentIDForOrders(ShipmentName,Convert.ToInt32(Orderid)).ToList();
          try
          {
              return Convert.ToInt32(Get[0].ship_supp_id);
          }
          catch (Exception ex)
          {

              TradingBLL.Muneeb.CRUD.log.Error("Shipment Id for orders"+ ex);
              return -1;
          }
      }

        //To order Inventory

      public static List<ScalarBuyerNameWithOrderName> ShowBuyerNamesWithOrderNames() {
          return obj.ShowBuyerNameWithOrderName().ToList();
      }


       //Order Product ID
      public static int ShowOrderID(String BuyerName, String OrderName, String Total, String OrderRef, DateTime OrderDate, DateTime RequiredDate, DateTime ShippedDate) {
          List<ScalarOrderID> Get = obj.ShowOrderID(BuyerName, OrderName, Convert.ToSingle(Total), OrderRef).ToList();
          try
          {
              return Get[0].order_id;
          }
          catch (Exception ex)
          {

              CRUD.log.Error("Getting Order ID: "+ex);
              return Get[0].order_id;
          }
      
      }

       //Supplier name with shipment name for reports

      public static String[] ShowSupplierNameWithShipmentName() {
          List<ScalarSupplierNameWithShipmentName> Get = obj.ShowSupplierNameWithShipmentName().ToList();
          String[] Set = new String[Get.Count];
          for (int i = 0; i < Get.Count; i++)
          {
              Set[i] =Get[i].id+"|"+ Get[i].SUPP_NAME + "|" + Get[i].Ship_name;
          }
          return Set;
      
      }

       //Shipment ID

      public static int GetShipmentIdForInvoice(String ShipName, String SupplierName, String FrieghtName, String ShipmentTotal, String ServiceCharges, String Currency, String SupplierRemarks, String PaymentType)
      
      {
         List<ScalarShipmentId> Get =  obj.GetShipmentIdForInvoice(ShipName, SupplierName, FrieghtName, Convert.ToSingle(ServiceCharges) + Convert.ToSingle(ShipmentTotal), Convert.ToSingle(ServiceCharges), "INVENTORY", Currency, SupplierRemarks, PaymentType).ToList();
         return Convert.ToInt32(Get[0].ship_supp_id);
      }
       //Buyer Names
       public static List<String> ShowBuyerNames() {
           List<ScalarBuyerNames> Show = obj.ShowBuyerNames().ToList();
           List<String> Get = new List<String>();
           for (int i = 0; i < Show.Count; i++)
			{
			 Get.Add(Show[i].buyer_name);
			}
           return Get;
       }

       //Supplier Names

       public static List<String> ShowSupplierNames()
       {
           List<ScalarSupplierNames> Show = obj.ShowSupplierNames().ToList();
           List<String> Get = new List<String>();
           for (int i = 0; i < Show.Count; i++)
           {
               Get.Add(Show[i].supp_name);
           }
           return Get;
       }

       //Frieght Names

       public static List<String> ShowFreightNames()
       {
           List<ScalarFreightName> Show = obj.ShowFreightNames().ToList();
           List<String> Get = new List<String>();
           for (int i = 0; i < Show.Count; i++)
           {
               Get.Add(Show[i].name);
           }
           return Get;
       }

       //Payment Types

       public static List<String> ShowPaymentNames()
       {
           List<ScalarPaymentNames> Show = obj.ShowPaymentNames().ToList();
           List<String> Get = new List<String>();
           for (int i = 0; i < Show.Count; i++)
           {
               Get.Add(Show[i].type);
           }
           return Get;
       }

       //Product Names

       public static List<String> ShowProductNames()
       {
           List<ScalarProductNames> Show = obj.ShowProductNames().ToList();
           List<String> Get = new List<String>();
           for (int i = 0; i < Show.Count; i++)
           {
               Get.Add(Show[i].prd_name);
           }
           return Get;
       }

       //Currency Names
       public static List<String> ShowCurrencyNames()
       {
           List<ScalarCurrencyNames> Show = obj.ShowCurrencyNames().ToList();
           List<String> Get = new List<String>();
           for (int i = 0; i < Show.Count; i++)
           {
               Get.Add(Show[i].name);
           }
           return Get;
       }

       //Currency
       public static String[] ShowCurrency()
       {
           List<ComplexCurrency> Get = obj.ShowCurrency().ToList();
           String[] Set = new String[Get.Count];
           for (int i = 0; i < Get.Count; i++)
           {
               Set[i] = Get[i].Currency.ToString();
           }
           return Set;
       }

       //Product Sale Price 
       public static String ShowProductSalePrice(String ProductName)
       {
           try
           {
               List<ScalarProductCPSP> Show = obj.ShowProduct_SPCP(ProductName).ToList();
               List<String> Get = new List<String>();
               for (int i = 0; i < Show.Count; i++)
               {
                   Get.Add(Show[i].prd_sp);
               }

               return Get[0].ToString();
           }
           catch (Exception ex)
           {
               CRUD.log.Error("Product Cost Price: " + ex);
               return "";

           }
       }

       //Product Cost Price 
       public static String ShowProductCostPrice(String ProductName)
       {
           try
           {
               List<ScalarProductCPSP> Show = obj.ShowProduct_SPCP(ProductName).ToList();
               List<String> Get = new List<String>();
               for (int i = 0; i < Show.Count; i++)
               {
                   Get.Add(Show[i].prd_cp);
               }
               return Get[0].ToString();
           }
           catch (Exception ex)
           {
               CRUD.log.Error("Product Cost Price: " + ex);
               return "";
               
           }
           
       }

    }
}

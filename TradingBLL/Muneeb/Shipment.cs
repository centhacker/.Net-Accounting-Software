using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace TradingBLL.Muneeb
{
    public sealed class Shipment
    {
       static TradingEntities obj = new TradingEntities();

        //Insert Products and UpdateInventory
       public static void InsertOrderInventory(String ShipmentId,String ProductName,String Currency,String Units,String CostPrice,DateTime E_date, DateTime M_date) {
           try
           {
               int InventoryProductId = 1;
               int NewQuantity = 1;

               List<ScalarProductQuantity> GetQuantity = obj.CheckProductInInventory(ProductName).ToList();
               for (int i = 0; i < GetQuantity.Count; i++)
               {
                   if (GetQuantity[i].prd_quantity>=Convert.ToInt32(Units))
                   {
                       InventoryProductId = GetQuantity[i].id;
                       NewQuantity = Convert.ToInt32(GetQuantity[i].prd_quantity) - Convert.ToInt32(Units);
                       break;
                   }
               }
               
                obj.InsertOrderInventory(Convert.ToInt32(ShipmentId),ProductName,Currency,NewQuantity,Convert.ToInt32(Units),Convert.ToSingle(CostPrice),E_date,M_date,InventoryProductId);
           }
           catch (Exception ex)
           {

               TradingBLL.Muneeb.CRUD.log.Error("Insertint Order with Inventory: "+ex.ToString());
           }
       }


        // Inserting Order with invoice

        public static bool InsertShipmentOrderWithInvoice(String ShipmentName,String SupplierRemarks,String BuyerName,String PaymentType,String ShipmentTotal,DateTime E_date,DateTime M_date,String OrderName,String ServiceCharges, String Currency, String OrderID,String InvoiceCurrency ){
            try
            {
                float CurrencyInvoiceTotal = 1;
                float ExchangeRate = 1;
                List<ComplexExRate> GetCurrencies = obj.ShowExchangeRates().ToList();
                for (int i = 0; i < GetCurrencies.Count; i++)
                {
                    if (Currency == GetCurrencies[i].currency_to.ToString() && InvoiceCurrency == GetCurrencies[i].currency_from.ToString())
                    {
                        ExchangeRate = Convert.ToSingle(GetCurrencies[i].Ex_rate);
                        break;
                    }
                }

                CurrencyInvoiceTotal = ExchangeRate * Convert.ToSingle(Convert.ToSingle(ShipmentTotal) + Convert.ToSingle(ServiceCharges));

                obj.InsertShipmentOrderWithInvoice(ShipmentName,SupplierRemarks,BuyerName,PaymentType,Convert.ToSingle(Convert.ToSingle(ShipmentTotal)+Convert.ToSingle(ServiceCharges)),E_date,M_date,OrderName,Convert.ToSingle(ServiceCharges),Currency,BuyerName +" Order with Order Name: "+OrderName+" On: "+E_date,Convert.ToInt32(OrderID),InvoiceCurrency,CurrencyInvoiceTotal,ExchangeRate);
                return true;
            }
            catch (SqlException ex)
            {
                TradingBLL.Muneeb.CRUD.log.Error("Insert order with invoice: "+ex.ToString());
                return false;

            }
        }
         


        //Check Product In Inventory

       public static bool CheckProductInInventory(String ProductName, String Quantity) {
            bool ReturnChecked = false;
           try
           {
              
               List<ScalarProductQuantity> Get = obj.CheckProductInInventory(ProductName).ToList();
               for (int i = 0; i < Get.Count; i++)
               {
                   if ((Get[i].prd_quantity > Convert.ToInt32(Quantity)) || (Get[i].prd_quantity == Convert.ToInt32(Quantity)))
                   {
                       ReturnChecked = true;
                       break;
                   }
                  
               }
               return ReturnChecked;

           }
           catch (Exception ex)
           {
               TradingBLL.Muneeb.CRUD.log.Error("Checking Product Quantity: "+ex);
               return ReturnChecked;
           }
       
       }

        //insert shipment suppliers
       public static bool InsertShipmentSupplierWithInvoice(out String Excep
           ,String ShipName,String SupplierName,String FrieghtName,String ShipmentTotal,DateTime e_date
           ,DateTime m_date,String ServiceCharges,String Currency,String SupplierRemarks,String PaymentType,String InvoiceCurrency) {
           try
           {
               float CurrencyInvoiceTotal=1;
               float ExchangeRate =1;
               List<ComplexExRate> GetCurrencies = obj.ShowExchangeRates().ToList();
               for (int i = 0; i < GetCurrencies.Count; i++)
               {
                   if (Currency == GetCurrencies[i].currency_to.ToString() && InvoiceCurrency == GetCurrencies[i].currency_from.ToString() )
                   {
                       ExchangeRate = Convert.ToSingle(GetCurrencies[i].Ex_rate);
                       break;
                   }
               }

               CurrencyInvoiceTotal = ExchangeRate * Convert.ToSingle(Convert.ToSingle(ShipmentTotal)+Convert.ToSingle( ServiceCharges));

               obj.InsertShipmentSupplierWithInvoice(ShipName,SupplierName,FrieghtName,Convert.ToSingle(ServiceCharges)+ Convert.ToSingle(ShipmentTotal),e_date,m_date,Convert.ToSingle(ServiceCharges),"INVENTORY",Currency,SupplierRemarks,PaymentType,"Shipment From "+SupplierName +" on Date:  "+DateTime.Now.ToShortDateString().ToString(),InvoiceCurrency,CurrencyInvoiceTotal,ExchangeRate);
               Excep = "Invoice Generated Successfully";
               return true;
           }
           catch (SqlException ex)
           {
               Excep = ex.ToString();
               return false;
               
           }
       }

       public static void InsertProductSupplier(int ShipmentID, String ProductName,String Price
           ,String Units,String Currency,DateTime e_date, DateTime m_date) {
           try
           {
               obj.InsertShipmentProduct(ShipmentID,ProductName,Convert.ToSingle(Price),Convert.ToInt32(Units),Currency,"Product Shipped To Inventory on date: "+DateTime.Now.ToShortDateString().ToString(),e_date,m_date);
           }
           catch (SqlException ex)
           {

               CRUD.log.Error("Shipment Product: "+ ex);
           }
         
       }

    }
}

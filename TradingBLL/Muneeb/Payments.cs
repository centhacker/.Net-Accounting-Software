using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradingBLL.Muneeb
{
   public static class Payments
    {
       static TradingEntities obj = new TradingEntities();


        #region Payments
       public static bool PaymentOfShipmentBuyer(out String GetException,String InvoiceId,String Payment,String AccountId,string PaymentType,String PaymentNo) {
           try
           {
               obj.PaymentOfShipmentOrder(Convert.ToInt32(InvoiceId),Convert.ToSingle(Payment),Convert.ToInt32(AccountId),PaymentType,PaymentNo);
               GetException = "Payment Successfull ";
               return true;
           }
           catch (Exception ex)
           {
               GetException = ex.ToString();
               return false;
               
           }
       }

        public static bool PaymentOfShipmentSupplier(out String GetException,String InvoiceId,String Payment,String AccountId,string PaymentType,String PaymentNo) {
           try
           {
             obj.PaymentOfShipmentSupplier(Convert.ToInt32( InvoiceId),Convert.ToInt32(Payment),Convert.ToInt32(AccountId),PaymentType,PaymentNo);
               GetException = "Payment Successfull ";
               return true;
           }
           catch (Exception ex)
           {
               GetException = ex.ToString();
               return false;
               
           }
        }
#endregion

        #region Show Details For Payment Forms
        public static List<ComplexInvoicesSupplier> ShowInvoicesSupplier() {

            return obj.ShowInvoicesSupplier().ToList();
        }
        public static List<ComplexInvoiceSupplierDetails> ShowInvoiceSupplierDEtails(String InvoiceId) {
            return obj.ShowInvoiceSupplierDetails(Convert.ToInt32(InvoiceId)).ToList();
        }
        public static List<ComplexInvoicesBuyer> ShowInvoicesBuyer() {
            return obj.ShowInvoicesBuyer().ToList();
        }
        public static List<ComplexOrderPayments> ShowOrderPayments(String InvoiceId) {
            return obj.ShowOrderPayments(Convert.ToInt32(InvoiceId)).ToList();
        }
        public static List<ComplexOrderDetailPayments> ShowOrderDetailsPayments(String OrderId) {
            return obj.ShowOrderDetailsPayments(Convert.ToInt32(OrderId)).ToList();
        }
        #endregion
    }

    


}

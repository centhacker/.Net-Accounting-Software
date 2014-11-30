using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradingBLL.Muneeb
{
   public class Accounts
    {
       static TradingEntities obj = new TradingEntities();

       #region Default Variables
      public static DateTime TrialBalanceFromDate, TrialBalanceToDate;
       #endregion
       public static bool RefundInvoice(int invoiceId, float InvoiceTotal, int Accountid,float AccountTotal,String CheckTransaction,float Exrate,float Paid) {
           try
           {
               obj.RefundInvoice(invoiceId,InvoiceTotal,Accountid,AccountTotal,CheckTransaction,Exrate,Paid);
               return true;
           }
           catch
           {
               
                return true;
           }
       }
       public static bool AccountTransaction(String AccountId,String TypeOfTransaction,String Refrence,String Total) {
           try
           {
               obj.AccountTransaction(Convert.ToInt32(AccountId), TypeOfTransaction, Refrence, Convert.ToSingle(Total), DateTime.Now, Convert.ToSingle(Total));
               return true;
           }
           catch 
           {

               return false;
           }
       }


       #region Fiscal Year
       public static String[] ShowFiscalYEar() {
           List<ComplexFiscalYear> Get = obj.ShowFiscalYear().ToList();
            String[] Set = new String[Get.Count];
           for (int i = 0; i < Get.Count; i++)
			{
                Set[i] = Convert.ToDateTime(Get[i].f_from.ToString()).ToShortDateString() + "|" + Convert.ToDateTime(Get[i].f_to.ToString()).ToShortDateString();
			}
           return Set;
       }

       public static bool InsertFiscalYear(DateTime ClosingTo) {
           try
           {
               DateTime FromNew = ClosingTo;
               DateTime ToNew = DateTime.Now;
               obj.InsertFiscalYear(ClosingTo,ToNew,ClosingTo);
               return true;
           }
           catch (Exception ex)
           {
               CRUD.log.Error(ex.ToString());
               return false;
               
           }
       }

       public static void UpdateFiscalYearForLogin() {

           obj.UpdateFiscalYear(DateTime.Now.AddDays(1));
       }
       #endregion

       //Inserting General Journal Voucher With T-Accounts Postings
        public static void InsertJournalAndPosting(String AccountId,String AccountNum,String Amount,String Description,String Type,DateTime eDate) {
            obj.InsertJournalAndPostings(Convert.ToInt32(AccountId),AccountNum,
                Convert.ToSingle(Amount),Description,Type,eDate);
        
        }
    }
}

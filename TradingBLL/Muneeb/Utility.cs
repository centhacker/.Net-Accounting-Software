using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradingBLL.Muneeb
{
    public sealed class Utility 
    {
       public static string LoggedIn = String.Empty;
       static TradingEntities obj = new TradingEntities();

       #region Check Account Name Exists


       public static List<ComplexInventoryGrid> InventoryGrid(DateTime From,DateTime To,out String Catch) {
           try
           {
               Catch = "";
               return obj.InventoryFilter(From, To).ToList();
              
           }
           catch (Exception ex)
           {
               Catch = ex.ToString();
               return null;
               
           }
       }

       public static bool CheckNames(String NameOfAccount)
       {
           List<ScalarAccountName> Get = obj.CheckNameOfAccounts(NameOfAccount).ToList();
           if (Get.Count>0)
           {
               return false;
           }
           else
           {
               return true;
           }
          

       }
       #endregion


       #region Check User
       public static bool CheckUser(String UserID, String Password,out String GetException) {
           try
           {
               List<ScalarLogin> GetPassword = obj.CheckLogin(UserID).ToList();
               if (Password==Convert.ToString(GetPassword[0].password))
               {
                   GetException = "";
                   return true;
               }
               else
               {
                   GetException = "User Name Or Password Invalid";
                   return false;
               }
               
           }
           catch (Exception ex)
           {
               GetException = ex.ToString();
               CRUD.log.Error("Check Login Class: "+ex);
               return false;

           }
       }
        #endregion
    }
}

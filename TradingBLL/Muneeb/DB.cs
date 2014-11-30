using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace TradingBLL.Muneeb
{
   public sealed class DB
    {
       private static String ConnectionString = ConfigurationManager.ConnectionStrings["TradingSolutions.Properties.Settings.ConnectionString"].ToString();
       public static SqlConnection TradingConnection = new SqlConnection(ConnectionString);
       public static SqlTransaction TradingTransaction;
       public static SqlCommand MyCommand;

    }
}

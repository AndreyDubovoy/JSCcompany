using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public static class LogExeption
    {
        public static void NextLogExeption (Exception ex, int deepExeption)
        {
            Logger.Log.Error(ex.Message + ' ' + ex.StackTrace);
            if (ex.InnerException != null && deepExeption>0)
            {
                NextLogExeption(ex.InnerException,--deepExeption);
            }
        }

        public static void ExeptionHandler(Exception ex)
        {
            NextLogExeption(ex,5); // 5 -  Max quantity inner Exeptions
        }
    }

   
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETV_Book_Library_C_Sherp
{
    static class Globals
    { 
        //public string sConn;
    public static string clsConnString()
    {
        return @"Data Source=192.168.11.130;Initial Catalog=ETVBookLibraryT;User ID=sa;Password=arunarun";
    }

        public static string clsConnStringHR()
        {
            return @"Data Source=192.168.11.130;Initial Catalog=hrnew;User ID=sa;Password=arunarun";
        }

    }
    
        
        
    
}

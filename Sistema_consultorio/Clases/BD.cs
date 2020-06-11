using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Sistema_consultorio.Clases
{
   public  class BD
    {
        public static  string conexxxion = ConfigurationManager.ConnectionStrings["Sistema_consultorio.Properties.Settings.ConsultasConnectionString"].ConnectionString;




    }
}

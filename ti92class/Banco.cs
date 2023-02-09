using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ti92class
{
    public static class Banco
    {
        public static MySqlCommand Abrir() 
        {
            MySqlCommand cmd = new MySqlCommand();
            try // tentar abrir
            {
                string strCon = @"server=10.91.43.26;database=ti92sysdb;user id=senacitq;password=senac";
                MySqlConnection cn = new MySqlConnection(strCon);
                cn.Open();
                cmd.Connection = cn; 
            }
            catch (Exception)
            {
                throw;
            }

           

            return cmd;
        }
    }
}

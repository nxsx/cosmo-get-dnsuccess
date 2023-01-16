using HTCGetDnReceiveSuccess.Models;
using HTCGetDnReceiveSuccess.Databases;
using MySql.Data.MySqlClient;
using System;

namespace HTCGetDnReceiveSuccess.Controllers
{
    public class MoldLifeShotController
    {
        public static bool postMoldLiftShot(DnReceiveSuccess dns)
        {
            bool result = false;

            String sql = string.Format(@"INSERT INTO mold_master.tb_shot(`code`, `qt`, `vcode`, `vname`, `time_stmp`) VALUES('{0}', '{1}', '{2}', '{3}', '{4}')", dns.materialCode, dns.receiveAmount, dns.supplyCode, dns.supplyName, dns.accountingTime);
            Console.WriteLine(sql);

            using (MySqlConnection conn = new MySqlConnection(MoldDatabase.ConnectionString()))
            {
                try
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    conn.Close();
                    result = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Mold database error: {0}", ex.ToString());
                }
            }

            return result;
        }
    }
}

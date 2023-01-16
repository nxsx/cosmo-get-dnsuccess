using HTCGetDnReceiveSuccess.Models;
using HTCGetDnReceiveSuccess.Databases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace HTCGetDnReceiveSuccess.Controllers
{
    public class DnReceiveSuccessController
    {
        public static List<DnReceiveSuccess> GetDnReceiveSuccessesRF()
        {
            List<DnReceiveSuccess> dnReceiveSuccesses = new List<DnReceiveSuccess>();

            String sql = string.Format(@"SELECT dn.material_code, dn.receipt_amount, po.supply_code, po.supply_name, DATE_FORMAT(dn.accounting_time, '%Y-%m-%d %H:%i:%s') AS accounting_time FROM cosmo_wms_9771.ods_raw_order_in dn LEFT JOIN cosmo_wms_9771.ods_raw_order_po po ON dn.po_no = po.po_no AND dn.po_line = po.po_line AND dn.material_code = po.material_code WHERE dn.accounting_status = 2 AND DATE_FORMAT(dn.accounting_time, '%Y-%m-%d') = DATE_FORMAT(NOW() - INTERVAL 1 DAY, '%Y-%m-%d') ORDER BY dn.accounting_time ASC");
            Console.WriteLine(sql);
            
            using (MySqlConnection conn = new MySqlConnection(DatabaseConfig.CosmoConnectionString()))
            {
                try
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        MySqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            dnReceiveSuccesses.Add(new DnReceiveSuccess()
                                {
                                    materialCode = dr[0].ToString().Trim(),
                                    receiveAmount = dr[1].ToString().Trim(),
                                    supplyCode = dr[2].ToString().Trim(),
                                    supplyName = dr[3].ToString().Trim(),
                                    accountingTime = dr[4].ToString().Trim()
                                }
                            );
                        }
                    }

                    conn.Close();
                }
                catch (Exception ex) 
                {
                    Console.WriteLine("Cosmo database error: {0}", ex.ToString());
                }
            }

            return dnReceiveSuccesses;
        }

        public static List<DnReceiveSuccess> GetDnReceiveSuccessesWAC()
        {
            List<DnReceiveSuccess> dnReceiveSuccesses = new List<DnReceiveSuccess>();

            String sql = string.Format(@"SELECT dn.material_code, dn.receipt_amount, po.supply_code, po.supply_name, DATE_FORMAT(dn.accounting_time, '%Y-%m-%d %H:%i:%s') AS accounting_time FROM cosmo_wms_9773.ods_raw_order_in dn LEFT JOIN cosmo_wms_9773.ods_raw_order_po po ON dn.po_no = po.po_no AND dn.po_line = po.po_line AND dn.material_code = po.material_code WHERE dn.accounting_status = 2 AND DATE_FORMAT(dn.accounting_time, '%Y-%m-%d') = DATE_FORMAT(NOW() - INTERVAL 1 DAY, '%Y-%m-%d') ORDER BY dn.accounting_time ASC");
            Console.WriteLine(sql);

            using (MySqlConnection conn = new MySqlConnection(DatabaseConfig.CosmoConnectionString()))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        MySqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            dnReceiveSuccesses.Add(
                                new DnReceiveSuccess()
                                {
                                    materialCode = dr[0].ToString().Trim(),
                                    receiveAmount = dr[1].ToString().Trim(),
                                    supplyCode = dr[2].ToString().Trim(),
                                    supplyName = dr[3].ToString().Trim(),
                                    accountingTime = dr[4].ToString().Trim()
                                }
                            );
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: {0}", ex.ToString());
                }
            }

            return dnReceiveSuccesses;
        }

        public static List<DnReceiveSuccess> GetDnReceiveSuccessesSAC()
        {
            List<DnReceiveSuccess> dnReceiveSuccesses = new List<DnReceiveSuccess>();

            String sql = string.Format(@"SELECT dn.material_code, dn.receipt_amount, po.supply_code, po.supply_name, DATE_FORMAT(dn.accounting_time, '%Y-%m-%d %H:%i:%s') AS accounting_time FROM cosmo_wms_9774.ods_raw_order_in dn LEFT JOIN cosmo_wms_9774.ods_raw_order_po po ON dn.po_no = po.po_no AND dn.po_line = po.po_line AND dn.material_code = po.material_code WHERE dn.accounting_status = 2 AND DATE_FORMAT(dn.accounting_time, '%Y-%m-%d') = DATE_FORMAT(NOW() - INTERVAL 1 DAY, '%Y-%m-%d') ORDER BY dn.accounting_time ASC");
            Console.WriteLine(sql);

            using (MySqlConnection conn = new MySqlConnection(DatabaseConfig.CosmoConnectionString()))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        MySqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            dnReceiveSuccesses.Add(
                                new DnReceiveSuccess()
                                {
                                    materialCode = dr[0].ToString().Trim(),
                                    receiveAmount = dr[1].ToString().Trim(),
                                    supplyCode = dr[2].ToString().Trim(),
                                    supplyName = dr[3].ToString().Trim(),
                                    accountingTime = dr[4].ToString().Trim()
                                }
                            );
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: {0}", ex.ToString());
                }
            }

            return dnReceiveSuccesses;
        }
    }
}

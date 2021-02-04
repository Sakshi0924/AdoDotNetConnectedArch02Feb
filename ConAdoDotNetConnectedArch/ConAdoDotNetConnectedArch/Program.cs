using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ConAdoDotNetConnectedArch
{
    //POCO Class
    class Customer
    {
        public string CId { get; set; }
        public string CName { get; set; }
        public  DateTime DOB { get; set; }
        public string City  { get; set; }
    }
    class Program
    {
       
        public static void GetDataBySqlDataReader()
        {
            StringBuilder sb = new StringBuilder(1024);
            //create connection
            try
            {
                using ( SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ToString()))
                {
                    using (SqlCommand cmd = new SqlCommand("Select * from TblCustomer", con))
                    {
                        con.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                        {
                            while (dr.Read())
                            {
                                sb.AppendLine($"CustomerId:{dr[0].ToString()}");
                                sb.AppendLine($"CustomerName:{dr[1].ToString()}");
                                sb.AppendLine($"DOB:{dr[2].ToString()}");
                                sb.AppendLine($"City:{dr[3].ToString()}");
                                sb.AppendLine();

                            }
                        }
                    }
                }
                var res1 = sb.ToString();

                Console.WriteLine(res1);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void GetDataByGetMethodsOfDr()
        {
            try
            {
                List<Customer> customerList = new List<Customer>();

                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ToString()))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("Select * from TblCustomer", cn))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                        {
                            while (dr.Read())
                            {
                                customerList.Add(new Customer
                                {
                                    CId = dr.GetString(dr.GetOrdinal("CustomerID")),
                                    CName = dr.GetString(dr.GetOrdinal("Name")),
                                    DOB = dr.GetDateTime(dr.GetOrdinal("DOB")),
                                    City = dr.GetString(dr.GetOrdinal("City"))
                                });

                            }
                        }
                    }

                }
                foreach (var v in customerList)
                {
                    Console.WriteLine($"CustomerId:{v.CId}\nCustomerName:{v.CName}\nDOB:{v.DOB}\nCity:{v.City}");
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void GetDataByGetFieldValue()
        {
            try
            {
                List<Customer> customerList = new List<Customer>();
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ToString()))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("Select * from TblCustomer", cn))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                        {
                            while (dr.Read())
                            {
                                customerList.Add(new Customer
                                {
                                    CId = dr.GetFieldValue<string>(dr.GetOrdinal("CustomerID")),
                                    CName = dr.GetFieldValue<string>(dr.GetOrdinal("Name")),
                                    DOB = dr.GetFieldValue<DateTime>(dr.GetOrdinal("DOB")),
                                    City = dr.GetFieldValue<string>(dr.GetOrdinal("City"))
                                }
                                );
                            }
                        }
                    }
                }
                var result = customerList.GetEnumerator();
                while (result.MoveNext())
                {
                    Console.WriteLine($"CustomerID:{result.Current.CId}\n" +
                      $"CustomerName:{result.Current.CName}\nDOB:{result.Current.DOB}\nCity:{result.Current.City}");
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("--------------Data of Customer Table By using SqlDataReader------------ ");
            GetDataBySqlDataReader();
            Console.WriteLine();
            Console.WriteLine("--------------Data of Customer Table By using GetMethods of DataReader----------");
            GetDataByGetMethodsOfDr();
            Console.WriteLine();
            Console.WriteLine("--------------Data of Customer Table By using GetFieldValue<T>() of DataReader------");
            GetDataByGetFieldValue();
        }
    }
}

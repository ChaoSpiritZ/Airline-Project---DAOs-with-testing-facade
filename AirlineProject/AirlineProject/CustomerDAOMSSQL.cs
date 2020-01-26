using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineProject
{
    public class CustomerDAOMSSQL : ICustomerDAO //supposed to be internal
    {
        public void Add(Customer t)
        {
            using (SqlConnection con = new SqlConnection(AirlineProjectConfig.path))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand($"INSERT INTO Customers VALUES ({t.ID}, '{t.FirstName}', '{t.LastName}', '{t.UserName}', '{t.Password}', '{t.Address}', '{t.PhoneNo}', '{t.CreditCardNumber}')", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                    }
                }
            }
        }

        public Customer Get(int id)
        {
            using (SqlConnection con = new SqlConnection(AirlineProjectConfig.path))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand($"select * from Customers where ID = {id}", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Customer customer = new Customer()
                            {
                                ID = (long)reader["ID"],
                                FirstName = (string)reader["FIRST_NAME"],
                                LastName = (string)reader["LAST_NAME"],
                                UserName = (string)reader["USER_NAME"],
                                Password = (string)reader["PASSWORD"],
                                Address = (string)reader["ADDRESS"],
                                PhoneNo = (string)reader["PHONE_NO"],
                                CreditCardNumber = (string)reader["CREDIT_CARD_NUMBER"]
                            };
                            return customer;
                        }
                        return null;
                    }
                }
            }
        }

        public IList<Customer> GetAll()
        {
            List<Customer> customers = new List<Customer>();
            using (SqlConnection con = new SqlConnection(AirlineProjectConfig.path))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand($"select * from Customers", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Customer customer = new Customer()
                            {
                                ID = (long)reader["ID"],
                                FirstName = (string)reader["FIRST_NAME"],
                                LastName = (string)reader["LAST_NAME"],
                                UserName = (string)reader["USER_NAME"],
                                Password = (string)reader["PASSWORD"],
                                Address = (string)reader["ADDRESS"],
                                PhoneNo = (string)reader["PHONE_NO"],
                                CreditCardNumber = (string)reader["CREDIT_CARD_NUMBER"]
                            };
                            customers.Add(customer);
                        }
                    }
                }
            }
            return customers;
        }

        public Customer GetCustomerByUsername(string name)
        {
            using (SqlConnection con = new SqlConnection(AirlineProjectConfig.path))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand($"select * from Customers where USER_NAME = '{name}'", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Customer customer = new Customer()
                            {
                                ID = (long)reader["ID"],
                                FirstName = (string)reader["FIRST_NAME"],
                                LastName = (string)reader["LAST_NAME"],
                                UserName = (string)reader["USER_NAME"],
                                Password = (string)reader["PASSWORD"],
                                Address = (string)reader["ADDRESS"],
                                PhoneNo = (string)reader["PHONE_NO"],
                                CreditCardNumber = (string)reader["CREDIT_CARD_NUMBER"]
                            };
                            return customer;
                        }
                        return null;
                    }
                }
            }
        }

        public void Remove(Customer t)
        {
            using (SqlConnection con = new SqlConnection(AirlineProjectConfig.path))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand($"DELETE FROM Customers WHERE ID = {t.ID}", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                    }
                }
            }
        }

        public void Update(Customer t)
        {
            using (SqlConnection con = new SqlConnection(AirlineProjectConfig.path))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand($"update Customers set ID = {t.ID}, FIRST_NAME = '{t.FirstName}', LAST_NAME = '{t.LastName}', USER_NAME = '{t.UserName}', PASSWORD = '{t.Password}', ADDRESS = '{t.Address}', PHONE_NO = '{t.PhoneNo}', CREDIT_CARD_NUMBER = '{t.CreditCardNumber}' where ID = {t.ID}", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                    }
                }
            }
        }
    }
}

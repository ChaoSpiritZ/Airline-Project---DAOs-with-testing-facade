using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AirlineProject
{
    public class CountryDAOMSSQL : ICountryDAO //supposed to be internal
    {
        public void Add(Country t)
        {
            using (SqlConnection con = new SqlConnection(AirlineProjectConfig.path))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand($"INSERT INTO Countries VALUES ({t.ID}, '{t.CountryName}')", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                    }
                }
            }
        }

        public Country Get(int id)
        {
            using (SqlConnection con = new SqlConnection(AirlineProjectConfig.path))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand($"select * from Countries where ID = {id}", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Country country = new Country()
                            {
                                ID = (long)reader["ID"],
                                CountryName = (string)reader["COUNTRY_NAME"]
                            };
                            return country;
                        }
                        return null;
                    }
                }
            }
        }

        public IList<Country> GetAll()
        {
            List<Country> countries = new List<Country>();
            using (SqlConnection con = new SqlConnection(AirlineProjectConfig.path))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand($"select * from Countries", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Country country = new Country()
                            {
                                ID = (long)reader["ID"],
                                CountryName = (string)reader["COUNTRY_NAME"]
                            };
                            countries.Add(country);
                        }
                    }
                }
            }
            return countries;
        }

        public void Remove(Country t)
        {
            using (SqlConnection con = new SqlConnection(AirlineProjectConfig.path))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand($"DELETE FROM Countries WHERE ID = {t.ID}", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                    }
                }
            }
        }

        public void Update(Country t)
        {
            using (SqlConnection con = new SqlConnection(AirlineProjectConfig.path))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand($"update Countries set ID = {t.ID}, COUNTRY_NAME = '{t.CountryName}' where ID = {t.ID}", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                    }
                }
            }
        }
    }
}

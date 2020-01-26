using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AirlineProject
{
    public class AirlineDAOMSSQL : IAirlineDAO //supposed to be internal
    {
        public void Add(AirlineCompany t)
        {
            using (SqlConnection con = new SqlConnection(AirlineProjectConfig.path))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand($"INSERT INTO AirlineCompanies VALUES ({t.ID}, '{t.AirlineName}', '{t.UserName}', '{t.Password}', {t.CountryCode})", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                    }
                }
            }
        }

        public AirlineCompany Get(int id)
        {
            using (SqlConnection con = new SqlConnection(AirlineProjectConfig.path))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand($"select * from AirlineCompanies where ID = {id}", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            AirlineCompany airlineCompany = new AirlineCompany()
                            {
                                ID = (long)reader["ID"],
                                AirlineName = (string)reader["AIRLINE_NAME"],
                                UserName = (string)reader["USER_NAME"],
                                Password = (string)reader["PASSWORD"],
                                CountryCode = (long)reader["COUNTRY_CODE"]
                            };
                            return airlineCompany;
                        }
                        return null;
                    }
                }
            }
        }

        public AirlineCompany GetAirlineByUsername(string name)
        {
            using (SqlConnection con = new SqlConnection(AirlineProjectConfig.path))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand($"select * from AirlineCompanies where USER_NAME = '{name}'", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            AirlineCompany airlineCompany = new AirlineCompany()
                            {
                                ID = (long)reader["ID"],
                                AirlineName = (string)reader["AIRLINE_NAME"],
                                UserName = (string)reader["USER_NAME"],
                                Password = (string)reader["PASSWORD"],
                                CountryCode = (long)reader["COUNTRY_CODE"]
                            };
                            return airlineCompany;
                        }
                        return null;
                    }
                }
            }
        }

        public IList<AirlineCompany> GetAll()
        {
            List<AirlineCompany> airlineCompanies = new List<AirlineCompany>();
            using (SqlConnection con = new SqlConnection(AirlineProjectConfig.path))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand($"select * from AirlineCompanies", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            AirlineCompany airlineCompany = new AirlineCompany()
                            {
                                ID = (long)reader["ID"],
                                AirlineName = (string)reader["AIRLINE_NAME"],
                                UserName = (string)reader["USER_NAME"],
                                Password = (string)reader["PASSWORD"],
                                CountryCode = (long)reader["COUNTRY_CODE"]
                            };
                            airlineCompanies.Add(airlineCompany);
                        }
                    }
                }
            }
            return airlineCompanies;
        }

        public IList<AirlineCompany> GetAllAirlinesByCountry(int countryId)
        {
            List<AirlineCompany> airlineCompanies = new List<AirlineCompany>();
            using (SqlConnection con = new SqlConnection(AirlineProjectConfig.path))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand($"select * from AirlineCompanies where COUNTRY_CODE = {countryId}", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            AirlineCompany airlineCompany = new AirlineCompany()
                            {
                                ID = (long)reader["ID"],
                                AirlineName = (string)reader["AIRLINE_NAME"],
                                UserName = (string)reader["USER_NAME"],
                                Password = (string)reader["PASSWORD"],
                                CountryCode = (long)reader["COUNTRY_CODE"]
                            };
                            airlineCompanies.Add(airlineCompany);
                        }
                    }
                }
            }
            return airlineCompanies;
        }

        public void Remove(AirlineCompany t)
        {
            using (SqlConnection con = new SqlConnection(AirlineProjectConfig.path))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand($"DELETE FROM AirlineCompanies WHERE ID = {t.ID}", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                    }
                }
            }
        }

        public void Update(AirlineCompany t)
        {
            using (SqlConnection con = new SqlConnection(AirlineProjectConfig.path))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand($"update AirlineCompanies set ID = {t.ID}, AIRLINE_NAME = '{t.AirlineName}', USER_NAME = '{t.UserName}', PASSWORD = '{t.Password}', COUNTRY_CODE = {t.CountryCode} where ID = {t.ID}", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                    }
                }
            }
        }
    }
}

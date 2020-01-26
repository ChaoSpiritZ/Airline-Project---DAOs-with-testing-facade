using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineProject
{
    public class FlightDAOMSSQL : IFlightDAO //supposed to be internal
    {
        public void Add(Flight t)
        {
            using (SqlConnection con = new SqlConnection(AirlineProjectConfig.path))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand($"INSERT INTO Flights VALUES ({t.ID}, {t.AirlineCompanyId}, {t.OriginCountryCode}, {t.DestinationCountryCode}, '{t.DepartureTime}', '{t.LandingTime}', {t.RemainingTickets})", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                    }
                }
            }
        }

        public Flight Get(int id)
        {
            using (SqlConnection con = new SqlConnection(AirlineProjectConfig.path))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand($"select * from Flights where ID = {id}", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Flight flight = new Flight()
                            {
                                ID = (long)reader["ID"],
                                AirlineCompanyId = (long)reader["AIRLINECOMPANY_ID"],
                                OriginCountryCode = (long)reader["ORIGIN_COUNTRY_CODE"],
                                DestinationCountryCode = (long)reader["DESTINATION_COUNTRY_CODE"],
                                DepartureTime = (DateTime)reader["DEPARTURE_TIME"],
                                LandingTime = (DateTime)reader["LANDING_TIME"],
                                RemainingTickets = (int)reader["REMAINING_TICKETS"],
                            };
                            return flight;
                        }
                        return null;
                    }
                }
            }
        }

        public IList<Flight> GetAll()
        {
            List<Flight> flights = new List<Flight>();
            using (SqlConnection con = new SqlConnection(AirlineProjectConfig.path))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand($"select * from Flights", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Flight flight = new Flight()
                            {
                                ID = (long)reader["ID"],
                                AirlineCompanyId = (long)reader["AIRLINECOMPANY_ID"],
                                OriginCountryCode = (long)reader["ORIGIN_COUNTRY_CODE"],
                                DestinationCountryCode = (long)reader["DESTINATION_COUNTRY_CODE"],
                                DepartureTime = (DateTime)reader["DEPARTURE_TIME"],
                                LandingTime = (DateTime)reader["LANDING_TIME"],
                                RemainingTickets = (int)reader["REMAINING_TICKETS"],
                            };
                            flights.Add(flight);
                        }
                    }
                }
            }
            return flights;
        }

        public Dictionary<Flight, int> GetAllFlightsVacancy()
        {
            Dictionary<Flight, int> flights = new Dictionary<Flight, int>();
            using (SqlConnection con = new SqlConnection(AirlineProjectConfig.path))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand($"select * from Flights", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Flight flight = new Flight()
                            {
                                ID = (long)reader["ID"],
                                AirlineCompanyId = (long)reader["AIRLINECOMPANY_ID"],
                                OriginCountryCode = (long)reader["ORIGIN_COUNTRY_CODE"],
                                DestinationCountryCode = (long)reader["DESTINATION_COUNTRY_CODE"],
                                DepartureTime = (DateTime)reader["DEPARTURE_TIME"],
                                LandingTime = (DateTime)reader["LANDING_TIME"],
                                RemainingTickets = (int)reader["REMAINING_TICKETS"],
                            };
                            flights.Add(flight, flight.RemainingTickets);
                        }
                    }
                }
            }
            return flights;
        }

        //public Flight GetFlightById(int id)
        //{
        //    using (SqlConnection con = new SqlConnection(AirlineProjectConfig.path))
        //    {
        //        con.Open();
        //        using (SqlCommand cmd = new SqlCommand($"select * from Flights where ID = {id}", con))
        //        {
        //            using (SqlDataReader reader = cmd.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    Flight flight = new Flight()
        //                    {
        //                        ID = (long)reader["ID"],
        //                        AirlineCompanyId = (long)reader["AIRLINECOMPANY_ID"],
        //                        OriginCountryCode = (long)reader["ORIGIN_COUNTRY_CODE"],
        //                        DestinationCountryCode = (long)reader["DESTINATION_COUNTRY_CODE"],
        //                        DepartureTime = (DateTime)reader["DEPARTURE_TIME"],
        //                        LandingTime = (DateTime)reader["LANDING_TIME"],
        //                        RemainingTickets = (int)reader["REMAINING_TICKETS"],
        //                    };
        //                    return flight;
        //                }
        //                return null;
        //            }
        //        }
        //    }
        //}

        public IList<Flight> GetFlightsByCustomer(Customer customer)
        {
            List<Flight> flights = new List<Flight>();
            using (SqlConnection con = new SqlConnection(AirlineProjectConfig.path))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand($"Select F.ID, F.AIRLINECOMPANY_ID, F.ORIGIN_COUNTRY_CODE, F.DESTINATION_COUNTRY_CODE, F.DEPARTURE_TIME, F.LANDING_TIME, F.REMAINING_TICKETS from Flights as F inner join Tickets as T on F.ID = T.FLIGHT_ID inner join Customers as C on T.CUSTOMER_ID = C.ID where C.ID = {customer.ID}", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Flight flight = new Flight()
                            {
                                ID = (long)reader["ID"],
                                AirlineCompanyId = (long)reader["AIRLINECOMPANY_ID"],
                                OriginCountryCode = (long)reader["ORIGIN_COUNTRY_CODE"],
                                DestinationCountryCode = (long)reader["DESTINATION_COUNTRY_CODE"],
                                DepartureTime = (DateTime)reader["DEPARTURE_TIME"],
                                LandingTime = (DateTime)reader["LANDING_TIME"],
                                RemainingTickets = (int)reader["REMAINING_TICKETS"],
                            };
                            flights.Add(flight);
                        }
                    }
                }
            }
            return flights;
        }

        public IList<Flight> GetFlightsByDepartureDate(DateTime departureDate)
        {
            List<Flight> flights = new List<Flight>();
            using (SqlConnection con = new SqlConnection(AirlineProjectConfig.path))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand($"select * from Flights where DEPARTURE_TIME = '{departureDate}'", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Flight flight = new Flight()
                            {
                                ID = (long)reader["ID"],
                                AirlineCompanyId = (long)reader["AIRLINECOMPANY_ID"],
                                OriginCountryCode = (long)reader["ORIGIN_COUNTRY_CODE"],
                                DestinationCountryCode = (long)reader["DESTINATION_COUNTRY_CODE"],
                                DepartureTime = (DateTime)reader["DEPARTURE_TIME"],
                                LandingTime = (DateTime)reader["LANDING_TIME"],
                                RemainingTickets = (int)reader["REMAINING_TICKETS"],
                            };
                            flights.Add(flight);
                        }
                    }
                }
            }
            return flights;
        }

        public IList<Flight> GetFlightsByDestinationCountry(int countryCode)
        {
            List<Flight> flights = new List<Flight>();
            using (SqlConnection con = new SqlConnection(AirlineProjectConfig.path))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand($"select * from Flights where DESTINATION_COUNTRY_CODE = {countryCode}", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Flight flight = new Flight()
                            {
                                ID = (long)reader["ID"],
                                AirlineCompanyId = (long)reader["AIRLINECOMPANY_ID"],
                                OriginCountryCode = (long)reader["ORIGIN_COUNTRY_CODE"],
                                DestinationCountryCode = (long)reader["DESTINATION_COUNTRY_CODE"],
                                DepartureTime = (DateTime)reader["DEPARTURE_TIME"],
                                LandingTime = (DateTime)reader["LANDING_TIME"],
                                RemainingTickets = (int)reader["REMAINING_TICKETS"],
                            };
                            flights.Add(flight);
                        }
                    }
                }
            }
            return flights;
        }

        public IList<Flight> GetFlightsByLandingDate(DateTime landingDate)
        {
            List<Flight> flights = new List<Flight>();
            using (SqlConnection con = new SqlConnection(AirlineProjectConfig.path))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand($"select * from Flights where LANDING_TIME = '{landingDate}'", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Flight flight = new Flight()
                            {
                                ID = (long)reader["ID"],
                                AirlineCompanyId = (long)reader["AIRLINECOMPANY_ID"],
                                OriginCountryCode = (long)reader["ORIGIN_COUNTRY_CODE"],
                                DestinationCountryCode = (long)reader["DESTINATION_COUNTRY_CODE"],
                                DepartureTime = (DateTime)reader["DEPARTURE_TIME"],
                                LandingTime = (DateTime)reader["LANDING_TIME"],
                                RemainingTickets = (int)reader["REMAINING_TICKETS"],
                            };
                            flights.Add(flight);
                        }
                    }
                }
            }
            return flights;
        }

        public IList<Flight> GetFlightsByOriginCountry(int countryCode)
        {
            List<Flight> flights = new List<Flight>();
            using (SqlConnection con = new SqlConnection(AirlineProjectConfig.path))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand($"select * from Flights where ORIGIN_COUNTRY_CODE = {countryCode}", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Flight flight = new Flight()
                            {
                                ID = (long)reader["ID"],
                                AirlineCompanyId = (long)reader["AIRLINECOMPANY_ID"],
                                OriginCountryCode = (long)reader["ORIGIN_COUNTRY_CODE"],
                                DestinationCountryCode = (long)reader["DESTINATION_COUNTRY_CODE"],
                                DepartureTime = (DateTime)reader["DEPARTURE_TIME"],
                                LandingTime = (DateTime)reader["LANDING_TIME"],
                                RemainingTickets = (int)reader["REMAINING_TICKETS"],
                            };
                            flights.Add(flight);
                        }
                    }
                }
            }
            return flights;
        }

        public void Remove(Flight t)
        {
            using (SqlConnection con = new SqlConnection(AirlineProjectConfig.path))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand($"DELETE FROM Flights WHERE ID = {t.ID}", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                    }
                }
            }
        }

        public void Update(Flight t)
        {
            using (SqlConnection con = new SqlConnection(AirlineProjectConfig.path))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand($"update Flights set ID = {t.ID}, AIRLINECOMPANY_ID = {t.AirlineCompanyId}, ORIGIN_COUNTRY_CODE = {t.OriginCountryCode}, DESTINATION_COUNTRY_CODE = {t.DestinationCountryCode}, DEPARTURE_TIME = '{t.DepartureTime}', LANDING_TIME = '{t.LandingTime}', REMAINING_TICKETS = {t.RemainingTickets} where ID = {t.ID}", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                    }
                }
            }
        }
    }
}

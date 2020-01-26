using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirlineProject;

namespace AirlineProjectStarter
{
    class Program
    {
        //private static IList<object> foo()
        //{
        //    return new List<object>() { 1, 2, 3 };
        //}

        //private static void Tester()
        //{
        //    IEnumerable<object> result = foo();
        //    result
        //}

        static void Main(string[] args)
        {
            //Tester();
            TestingFunctionsFacade TFF = new TestingFunctionsFacade();

            ///////////////////////////AirlineCompanies//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //AirlineCompany AC = new AirlineCompany(4, "Cruiser", "CrusCrus", "45678", 2);
            //AirlineCompany AC2 = new AirlineCompany(4, "Cruiser", "CrusCrus", "45678123", 2);

            //Console.WriteLine("getting all airline companies: ");
            //IList<AirlineCompany> airlineCompanies = TFF.GetAllAirlineCompanies();
            //airlineCompanies.ToList().ForEach(ac => Console.WriteLine(ac));
            //Console.WriteLine("");

            //Console.WriteLine("adding airline company with: Id: 4, Name: Cruiser, Username: CrusCrus, Password: 45678, Country Code: 2");
            //TFF.AddAirlineCompany(AC);
            //Console.WriteLine("");

            //Console.WriteLine("Getting airline company with id of 4:");
            //Console.WriteLine(TFF.GetAirlineCompany(4));
            //Console.WriteLine("");

            //Console.WriteLine("getting all airline companies:");
            //airlineCompanies = TFF.GetAllAirlineCompanies();
            //airlineCompanies.ToList().ForEach(ac => Console.WriteLine(ac));
            //Console.WriteLine("");

            //Console.WriteLine("updating airline company with id - 4, password - 45678 => 45678123");
            //TFF.UpdateAirlineCompany(AC2);
            //Console.WriteLine("");

            //Console.WriteLine("Getting airline company with id of 4:");
            //Console.WriteLine(TFF.GetAirlineCompany(4));
            //Console.WriteLine("");

            //Console.WriteLine("getting all airline companies:");
            //airlineCompanies = TFF.GetAllAirlineCompanies();
            //airlineCompanies.ToList().ForEach(ac => Console.WriteLine(ac));
            //Console.WriteLine("");

            //Console.WriteLine("removing airline company with id - 4:");
            //TFF.RemoveAirlineCompany(AC2);
            //Console.WriteLine("");

            //Console.WriteLine("getting all airline companies:");
            //airlineCompanies = TFF.GetAllAirlineCompanies();
            //airlineCompanies.ToList().ForEach(ac => Console.WriteLine(ac));
            //Console.WriteLine("");

            //Console.WriteLine("getting airline company with username - CCCRASH");
            //Console.WriteLine(TFF.GetAirlineByUsername("CCCRASH"));
            //Console.WriteLine("");

            //Console.WriteLine("getting airline company with username - CCCRASh");
            //Console.WriteLine(TFF.GetAirlineByUsername("CCCRASh"));
            //Console.WriteLine("");

            //Console.WriteLine("getting all airline companies by country id 3:");
            //airlineCompanies = TFF.GetAllAirlinesByCountry(3);
            //airlineCompanies.ToList().ForEach(ac => Console.WriteLine(ac));
            //Console.WriteLine("");

            ///////////////////////////COUNTRIES//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Country ctr = new Country(11, "Antarctica");
            //Country ctr2 = new Country(11, "Arctica");

            //Console.WriteLine("getting all countries:");
            //IList<Country> countries = TFF.GetAllCountries();
            //countries.ToList().ForEach(c => Console.WriteLine(c));
            //Console.WriteLine("");

            //Console.WriteLine("adding country with id - 11, country name - Antarctica");
            //TFF.AddCountry(ctr);
            //Console.WriteLine("");

            //Console.WriteLine("Getting country with id of 11:");
            //Console.WriteLine(TFF.GetCountry(11));
            //Console.WriteLine("");

            //Console.WriteLine("getting all countries:");
            //countries = TFF.GetAllCountries();
            //countries.ToList().ForEach(c => Console.WriteLine(c));
            //Console.WriteLine("");

            //Console.WriteLine("updating country with id - 11, country name - Antarctica => Arctica");
            //TFF.UpdateCountry(ctr2);
            //Console.WriteLine("");

            //Console.WriteLine("Getting country with id of 11:");
            //Console.WriteLine(TFF.GetCountry(11));
            //Console.WriteLine("");

            //Console.WriteLine("getting all countries:");
            //countries = TFF.GetAllCountries();
            //countries.ToList().ForEach(c => Console.WriteLine(c));
            //Console.WriteLine("");

            //Console.WriteLine("removing country with id - 11:");
            //TFF.RemoveCountry(ctr2);
            //Console.WriteLine("");

            //Console.WriteLine("getting all countries:");
            //countries = TFF.GetAllCountries();
            //countries.ToList().ForEach(c => Console.WriteLine(c));
            //Console.WriteLine("");

            ///////////////////////////CUSTOMERS//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Customer cst = new Customer(4, "Harry", "Potter", "HP127", "Happy127", "Hogwarts", "no phone", "68629472");
            //Customer cst2 = new Customer(4, "Harry", "Potter", "HP127", "Happy127", "Hogwarts", "055-5555555", "68629472");

            //Console.WriteLine("getting all customers:");
            //IList<Customer> customers = TFF.GetAllCustomers();
            //customers.ToList().ForEach(c => Console.WriteLine(c));
            //Console.WriteLine("");

            //Console.WriteLine("adding customer with id - 4, harry potter, HP127, Happy127, Hogwarts, no phone, 68629472");
            //TFF.AddCustomer(cst);
            //Console.WriteLine("");

            //Console.WriteLine("Getting customer with id of 4:");
            //Console.WriteLine(TFF.GetCustomer(4));
            //Console.WriteLine("");

            //Console.WriteLine("getting all customers:");
            //customers = TFF.GetAllCustomers();
            //customers.ToList().ForEach(c => Console.WriteLine(c));
            //Console.WriteLine("");

            //Console.WriteLine("updating customer with id - 4, phone number - no phone => 055-5555555");
            //TFF.UpdateCustomer(cst2);
            //Console.WriteLine("");

            //Console.WriteLine("Getting customer with id of 4:");
            //Console.WriteLine(TFF.GetCustomer(4));
            //Console.WriteLine("");

            //Console.WriteLine("getting all customers:");
            //customers = TFF.GetAllCustomers();
            //customers.ToList().ForEach(c => Console.WriteLine(c));
            //Console.WriteLine("");

            //Console.WriteLine("removing customer with id - 4:");
            //TFF.RemoveCustomer(cst2);
            //Console.WriteLine("");

            //Console.WriteLine("getting all customers:");
            //customers = TFF.GetAllCustomers();
            //customers.ToList().ForEach(c => Console.WriteLine(c));
            //Console.WriteLine("");

            //Console.WriteLine("getting customer by username - glmaN:");
            //Console.WriteLine(TFF.GetCustomerByUsername("glmaN"));
            //Console.WriteLine("");

            ///////////////////////////FLIGHTS//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Flight fl = new Flight(5, 3, 6, 4, new DateTime(2020, 4, 20), new DateTime(2020, 4, 21), 6);
            Flight fl2 = new Flight(5, 3, 6, 4, new DateTime(2020, 4, 20), new DateTime(2020, 5, 20), 6);

            Console.WriteLine("getting all flights:");
            IList<Flight> flights = TFF.GetAllFlights();
            flights.ToList().ForEach(f => Console.WriteLine(f));
            Console.WriteLine("");

            Console.WriteLine("adding flight with id - 5, 3, 6, 4, 20-4-2020, 21-4-2020, 6");
            TFF.AddFlight(fl);
            Console.WriteLine("");

            Console.WriteLine("Getting flight with id of 5:");
            Console.WriteLine(TFF.GetFlight(5));
            Console.WriteLine("");

            Console.WriteLine("getting all flights:");
            flights = TFF.GetAllFlights();
            flights.ToList().ForEach(f => Console.WriteLine(f));
            Console.WriteLine("");

            Console.WriteLine("updating flight with id - 5, landing time - 21-4-2020 => 20-5-2020");
            TFF.UpdateFlight(fl2);
            Console.WriteLine("");

            Console.WriteLine("Getting flight with id of 5:");
            Console.WriteLine(TFF.GetFlight(5));
            Console.WriteLine("");

            Console.WriteLine("getting all flights:");
            flights = TFF.GetAllFlights();
            flights.ToList().ForEach(f => Console.WriteLine(f));
            Console.WriteLine("");

            Console.WriteLine("getting all flights' vacancy:");
            Dictionary<Flight, int> flightsVacancy = TFF.GetAllFlightsVacancy();
            flightsVacancy.ToList().ForEach(fv => Console.WriteLine($"Flight number [{fv.Key.ID}] has [{fv.Value}] remaining tickets"));
            Console.WriteLine("");

            Console.WriteLine("removing flight with id - 5:");
            TFF.RemoveFlight(fl2);
            Console.WriteLine("");

            Console.WriteLine("getting all flights:");
            flights = TFF.GetAllFlights();
            flights.ToList().ForEach(f => Console.WriteLine(f));
            Console.WriteLine("");

            Console.WriteLine("getting all flights' vacancy:");
            flightsVacancy = TFF.GetAllFlightsVacancy();
            flightsVacancy.ToList().ForEach(fv => Console.WriteLine($"Flight number [{fv.Key.ID}] has [{fv.Value}] remaining tickets"));
            Console.WriteLine("");

            Console.WriteLine("getting all flights by customer - Yoav Levi");
            IList<Flight> flightsByCustomer = TFF.GetFlightsByCustomer(TFF.GetCustomer(1));
            flightsByCustomer.ToList().ForEach(fbc => Console.WriteLine(fbc));
            Console.WriteLine("");

            Console.WriteLine("getting all flights by departure time - 23-4-2019");
            IList<Flight> flightsByDepartureTime = TFF.GetFlightsByDepartureDate(new DateTime(2019, 4, 23)); // only gets flights in that date that depart at 00:00:00.000
            flightsByDepartureTime.ToList().ForEach(fbdt => Console.WriteLine(fbdt));
            Console.WriteLine("");

            Console.WriteLine("getting all flights by destination country id - 9");
            IList<Flight> flightsByDestinationCountry = TFF.GetFlightsByDestinationCountry(9);
            flightsByDestinationCountry.ToList().ForEach(fbdc => Console.WriteLine(fbdc));
            Console.WriteLine("");

            Console.WriteLine("getting all flights by landing time - 20-02-2020");
            IList<Flight> flightsByLandingTime = TFF.GetFlightsByLandingDate(new DateTime(2020, 2, 20)); // only gets flights in that date that land at 00:00:00.000
            flightsByLandingTime.ToList().ForEach(fblt => Console.WriteLine(fblt));
            Console.WriteLine("");

            Console.WriteLine("getting all flights by origin country id - 1");
            IList<Flight> flightsByOriginCountry = TFF.GetFlightsByOriginCountry(1);
            flightsByOriginCountry.ToList().ForEach(fboc => Console.WriteLine(fboc));
            Console.WriteLine("");

            ///////////////////////////TICKETS//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Ticket tk = new Ticket(5, 2, 1);
            //Ticket tk2 = new Ticket(5, 1, 1);

            //Console.WriteLine("getting all tickets:");
            //IList<Ticket> tickets = TFF.GetAllTickets();
            //tickets.ToList().ForEach(t => Console.WriteLine(t));
            //Console.WriteLine("");

            //Console.WriteLine("adding ticket with id - 5, flight id - 2, customer id - 1");
            //TFF.AddTicket(tk);
            //Console.WriteLine("");

            //Console.WriteLine("Getting ticket with id of 5:");
            //Console.WriteLine(TFF.GetTicket(5));
            //Console.WriteLine("");

            //Console.WriteLine("getting all tickets:");
            //tickets = TFF.GetAllTickets();
            //tickets.ToList().ForEach(t => Console.WriteLine(t));
            //Console.WriteLine("");

            //Console.WriteLine("updating ticket with id - 5, flight id - 2 => 1");
            //TFF.UpdateTicket(tk2);
            //Console.WriteLine("");

            //Console.WriteLine("Getting ticket with id of 5:");
            //Console.WriteLine(TFF.GetTicket(5));
            //Console.WriteLine("");

            //Console.WriteLine("getting all tickets:");
            //tickets = TFF.GetAllTickets();
            //tickets.ToList().ForEach(t => Console.WriteLine(t));
            //Console.WriteLine("");

            //Console.WriteLine("removing ticket with id - 5:");
            //TFF.RemoveTicket(tk2);
            //Console.WriteLine("");

            //Console.WriteLine("getting all tickets:");
            //tickets = TFF.GetAllTickets();
            //tickets.ToList().ForEach(t => Console.WriteLine(t));
            //Console.WriteLine("");
        }
    }
}

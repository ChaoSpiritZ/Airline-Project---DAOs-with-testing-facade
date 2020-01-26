using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineProject
{
    public abstract class FacadeBase
    {
        protected AirlineDAOMSSQL _airlineDAO;
        protected CountryDAOMSSQL _countryDAO;
        protected CustomerDAOMSSQL _customerDAO;
        protected FlightDAOMSSQL _flightDAO;
        protected TicketDAOMSSQL _ticketDAO;
        
        public FacadeBase()
        {
            _ticketDAO = new TicketDAOMSSQL();
            _customerDAO = new CustomerDAOMSSQL();
            _flightDAO = new FlightDAOMSSQL();
            _countryDAO = new CountryDAOMSSQL();
            _airlineDAO = new AirlineDAOMSSQL();
        }
    }
}

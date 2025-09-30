using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary.Interface
{
    internal interface IStorBealts
    {
        /// <summary>
        /// Adds a ticket to the list of tickets
        /// </summary>
        void AddTicket(Vehicle ticket);
        /// <summary>
        /// Returns all tickets in the list
        /// </summary>
        List<Vehicle> GetAllTickets();
        /// <summary>
        /// Returns all tickets with the specified license plate
        /// </summary>
        List<Vehicle> GetTicketsByLicense(string plate);
    }
}

using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary.Repository
{
    internal class StorBealts
    {
        /// <summary>
        /// A static list to store all tickets
        /// </summary>
        private static readonly List<Vehicle> _tickets = new List<Vehicle>();

        /// <summary>
        /// Adds a ticket to the list of tickets
        /// </summary>
        /// <param name="ticket"></param>
        public void AddTickets(Vehicle ticket)
        {
            _tickets.Add(ticket);
        }

        /// <summary>
        /// Returns all tickets in the list
        /// </summary>
        public List<Vehicle> GetAllTickets()
        {
            return _tickets;
        }

        /// <summary>
        /// Returns all tickets with the specified license plate
        /// </summary>
        public List<Vehicle> GetTicketsByLicense(string plate)
        {
            return _tickets
                .Where(t => t.LicensePlate.Equals(plate, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }





    }
}

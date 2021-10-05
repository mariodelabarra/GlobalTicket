using System.Collections.Generic;

namespace GloboTicket.TicketManagment.Domain
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Event> Events { get; set; }
    }
}

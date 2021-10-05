using System;

namespace GloboTicket.TicketManagment.Domain
{
    public class Event : BaseEntity
    {
        public string Name { get; set; }
        public int Price  { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}

using System;

namespace GloboTicket.TicketManagment.Domain
{
    public class Order : BaseEntity
    {
        public Guid UserId { get; set; }
        public int OrderTotal { get; set; }
        public DateTime OrderPlaced { get; set; }
        public bool OrderPaid { get; set; }
    }
}

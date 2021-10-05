using GloboTicket.TicketManagment.Domain;

namespace GloboTicket.TicketManagment.Application.Contracts.Persistence
{
    public interface IOrderRepository : IAsyncRepository<Order>
    {
    }
}

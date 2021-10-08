using GloboTicket.TicketManagment.Domain;
using System;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagment.Application.Contracts.Persistence
{
    public interface IEventRepository : IBaseRepository<Event>
    {
        Task<bool> IsEventNameAndDateUnique(string name, DateTime eventDate);
    }
}

using GloboTicket.TicketManagment.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagment.Application.Contracts.Persistence
{
    public interface ICategoryRepository : IAsyncRepository<Category>
    {
        Task<List<Category>> GetCategoriesWithEvents(bool includePassedEvents);
    }
}

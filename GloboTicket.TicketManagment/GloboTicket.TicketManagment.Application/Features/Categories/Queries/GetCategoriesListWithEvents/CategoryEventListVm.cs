using System;
using System.Collections.Generic;

namespace GloboTicket.TicketManagment.Application.Features.Categories.Queries
{
    public class CategoryEventListVm
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<CategoryEventDto> Events { get; set; }
    }
}

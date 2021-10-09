using AutoMapper;
using GloboTicket.TicketManagment.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagment.Application.Features.Events.Commands
{
    public class UpdateEventCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Artist { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public Guid CategoryId { get; set; }
    }

    public class UpdateEventCommandHandler : IRequestHandler<UpdateEventCommand>
    {
        private readonly IEventRepository _eventReposiotry;
        private readonly IMapper _mapper;

        public UpdateEventCommandHandler(IEventRepository eventReposiotry, IMapper mapper)
        {
            _eventReposiotry = eventReposiotry;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateEventCommand request, CancellationToken cancellationToken)
        {
            var eventToUpdate = await _eventReposiotry.GetByIdAsync(request.Id);

            _mapper.Map<UpdateEventCommand>(eventToUpdate);

            await _eventReposiotry.UpdateAsync(eventToUpdate);

            return Unit.Value;
        }
    }
}

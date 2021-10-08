using GloboTicket.TicketManagment.Application.Models.Mail;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagment.Application.Contracts.Infrastructure
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}

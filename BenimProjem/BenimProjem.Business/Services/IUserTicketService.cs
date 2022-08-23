using BenimProjem.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenimProjem.Business.Services
{
    public interface IUserTicketService 
    {
        UserTicket Get(string ticket);
        void Add(string ticket, int userId);
    }
}

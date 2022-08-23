using BenimProjem.DataAccess.Abstract;
using BenimProjem.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenimProjem.Business.Services
{
    public class UserTicketService : IUserTicketService
    {
        IUserTicketDal _userTicketDal;

        public UserTicketService(IUserTicketDal userTicketDal)
        {
            _userTicketDal = userTicketDal;
        }

        public UserTicket Get(string ticket)
        {
            
            var userTicket = _userTicketDal.Get(x => x.TicketKey == ticket); 
                                              
            return userTicket;
        }
        public void Add(string ticket,int userId)
        {
            var ticketData = new UserTicket() 
            { 
                CreateDate = DateTime.Now,
                TicketKey = ticket,
                UserId = userId,
                Status = true 
            };
            _userTicketDal.Add(ticketData);
        }
    }
}

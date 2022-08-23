using BenimProjem.Core.DataAccess;
using BenimProjem.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenimProjem.DataAccess.Abstract
{
    public interface IUserTicketDal : IRepository<UserTicket>
    {
    }
}

using BenimProjem.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenimProjem.Entites
{
    public class UserTicket : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string TicketKey { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }

    }
}

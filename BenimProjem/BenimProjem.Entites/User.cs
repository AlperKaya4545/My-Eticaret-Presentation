using BenimProjem.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenimProjem.Entites
{
    public class User : IEntity
    {     
            public int Id { get; set; }

            public string Email { get; set; }

            public string Password { get; set; }

            public bool? Status { get; set; }

            public bool IsAdmin { get; set; }
        
    }
}

using BenimProjem.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenimProjem.Entites
{
    public class CategoryProduct : IEntity
    {
        public int Id { get; set; }

        public int? ProductId { get; set; }

        public int? CategoryId { get; set; }

        public int Sort { get; set; }
    }
}

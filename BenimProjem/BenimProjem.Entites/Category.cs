using BenimProjem.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenimProjem.Entites
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
        public int Sort { get; set; } //sıralamak
        public bool Status { get; set; }
        public string SeoName { get; set; } 
        public string Image { get; set; }

    }
}

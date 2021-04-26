using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigAPI.Model
{
    public class Component
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public string Decsription { get; set; }

        public string Manufactrurer { get; set; }

        public int ManufactrurerPartId { get; set; }

        public ICollection<Item> Items { get; set; }

    }
}

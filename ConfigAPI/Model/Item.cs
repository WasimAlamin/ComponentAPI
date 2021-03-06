using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigAPI.Model
{
    public class Item
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Component> Components { get; set; }
        public ICollection<Configuration> Configuration { get; set; }
    }
}

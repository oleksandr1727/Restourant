using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestourantDataAccess.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Drink> Drinks { get; set; }
        public ICollection<Food> Foods { get; set; }
    }
}

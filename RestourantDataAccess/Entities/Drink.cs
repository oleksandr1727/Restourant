using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestourantDataAccess.Entities
{
    public class Drink
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Liter { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}

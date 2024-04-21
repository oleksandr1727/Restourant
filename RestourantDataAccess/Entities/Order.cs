using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestourantDataAccess.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int WorkerId { get; set; }
        public Worker Worker { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public ICollection<Food> Foods { get; set; }
        public ICollection<Drink> Drinks { get; set; }
    }
}

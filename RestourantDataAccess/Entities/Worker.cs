using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestourantDataAccess.Entities
{
    public class Worker
    {
        public int Id { get; set; }
        public bool AbillityToWork { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public int YearsOfWorking { get; set; }     
        public ICollection<Order> Orders { get; set; }
        public Position Position { get; set; }
        public int PositionId { get; set; }
    }
}

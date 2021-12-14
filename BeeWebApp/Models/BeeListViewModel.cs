using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeeWebApp.Models
{
    public class BeeListViewModel
    {
        public List<Worker> Workers { get; set; }
        public List<Queen> Queens { get; set; }
        public List<Drone> Drones { get; set; }
    }
}

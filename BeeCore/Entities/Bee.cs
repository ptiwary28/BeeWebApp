using System;

namespace BeeWebApp
{
    public class Bee
    {
        public string Id { get; set; }
        private double health = 100;
        public double Health
        {
            get { return health; } 
            set { health = value; }
        }
        public bool Dead { get; set; }
    }
}

using BeeCore;
using BeeWebApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeeCore.Services
{
    public class DroneService : Bee
    {
        /// <summary>
        /// Damage method to determine Drone's health
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public double Damage(int input)
        {
            Dead = DetermineBeeHealth(Health);
            if (input >= 0 && input <= 100 && !Dead)
            {
                Health = (Health - (Health * input) / 100);
            }
            return Health;
        }
        /// <summary>
        /// Determine bee's health
        /// </summary>
        /// <param name="Health"></param>
        /// <returns></returns>
        public bool DetermineBeeHealth(double Health)
        {
            if (Health < 50)
            {
                Dead = true;
            }
            return Dead;
        }
        public List<Drone> GetBeeDetails()
        {
            List<Drone> drones = new List<Drone>();
            for (var i = 0; i < 10; i++)
            {
                drones.Add(new Drone { Id = "Drone" + i + 1 });
            }
            return drones;
        }
    }
}

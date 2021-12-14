using System;
using System.Collections.Generic;
using System.Text;
using BeeWebApp;

namespace BeeCore.Services
{
    public class WorkerService:Bee
    {
        /// <summary>
        /// Damage method to determine Worker's health
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
            if (Health < 70)
            {
                Dead = true;
            }
            return Dead;
        }
        public List<Worker> GetBeeDetails()
        {
            List<Worker> worker = new List<Worker>();
            for (var i = 0; i < 10; i++)
            {
                worker.Add(new Worker { Id = "Worker" + i + 1 });
            }
            return worker;
        }

    }
}

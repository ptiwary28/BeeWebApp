using System;
using System.Collections.Generic;
using System.Text;
using BeeWebApp;

namespace BeeCore.Services
{
    public class QueenService:Bee
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
            if (Health < 20)
            {
                Dead = true;
            }
            return Dead;
        }
        public List<Queen> GetBeeDetails()
        {
            List<Queen> queen = new List<Queen>();
            for (var i = 0; i < 10; i++)
            {
                queen.Add(new Queen { Id = "Queen" + i + 1 });
            }
            return queen;
        }

    }
}

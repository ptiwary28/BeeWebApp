using System;
using System.Collections.Generic;
using System.Text;

namespace BeeCore.Services
{
    public class BeeService
    {
        public List<T> GetBeeDetails<T>() where T :new()
        {
            List<T> lists = new List<T>();
            for(var i=0;i<10;i++)
            {
                lists.Add(new T { });
            }
            return lists;
        }

        public int GenerateRandomNumber()
        {
            Random rnd = new Random();
            int number = rnd.Next(0, 80);
            return number;
        }


   
    }
}

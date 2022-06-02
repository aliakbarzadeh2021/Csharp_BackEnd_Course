using System;
using System.Collections.Generic;
using System.Text;

namespace Example4._5._1
{
    public class Alien
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int HealthPoints { get; set; }

        public void Move()
        {
            //Move
        }

        public void Attack()
        {
            //Attack
        }

        public void Defend()
        {

        }

        public void Run()
        {
            //Run
        }

        public void Decide()
        {
            Random r = new Random();
            int num = r.Next(1, 10);
            if(isEven(num))
            {
                //Even number = engage

                num = r.Next(1, 10);
                if(isEven(num))
                {
                    Attack();
                }
                else
                {
                    Defend();
                }
            }
            else
            {
                //Odd number = run
                Run();
            }

            bool isEven(int value)
            {
                return (value % 2 == 0);
            }
        }
    }
}

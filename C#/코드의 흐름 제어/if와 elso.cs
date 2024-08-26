using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.코드의_흐름_제어
{
    internal class if와_elso
    {
        static void Main(string[] args)
        {

            int hp = 100;
            bool isdead = (hp <= 0);

            if (isdead)
            {              
                Console.WriteLine("You are dead!");             
            }
            else
            {
                Console.WriteLine("You are alive!");
            }



            int choose = 2; // 0:가위 1:바위 2:보 3:치트키


            if (choose == 0)
            {
                Console.WriteLine("가위");
            }
            else if (choose == 1)
            {
                Console.WriteLine("바위");
            }
            else if (choose == 2)
            {
                Console.WriteLine("보");
            }
            else
            {
                Console.WriteLine("치트키");
            }

            
                
        }
    }
}

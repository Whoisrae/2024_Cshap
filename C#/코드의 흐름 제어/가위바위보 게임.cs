using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.코드의_흐름_제어
{
    internal class 가위바위보_게임
    {
        static void Main(string[] args)
        {
            // 0:가위 1:바위 2:보

            Random rand = new Random();
            int aichoice = rand.Next(0,3); // 0~2사이의 랜덤 값

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    Console.WriteLine("당신의 선택은 가위입니다");
                    break;
                case 1:
                    Console.WriteLine("당신의 선택은 바위입니다");
                    break;
                case 2:
                    Console.WriteLine("당신의 선택은 보입니다");
                    break;
            }

            switch (aichoice)
            {
                case 0:
                    Console.WriteLine("컴퓨터의 선택은 가위입니다");
                    break;
                case 1:
                    Console.WriteLine("컴퓨터의 선택은 바위입니다");
                    break;
                case 2:
                    Console.WriteLine("컴퓨터의 선택은 보입니다");
                    break;
            }

            // 승리 무승부 패배
            // 승리
            if (choice == aichoice)
            {
                Console.WriteLine("무승부입니다");
            }
            else if (choice == 0 && aichoice == 2)
            {
                Console.WriteLine("당신의 승리입니다");
            }
            else if (choice == 1 && aichoice == 0)
            {
                Console.WriteLine("당신의 승리입니다");
            }
            else if (choice == 2 && aichoice == 1)
            {
                Console.WriteLine("당신의 승리입니다");
            }
            else
            {
                Console.WriteLine("당신의 패배입니다");
            }
            
            

            

        }
    }
}

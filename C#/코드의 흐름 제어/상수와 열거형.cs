using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.코드의_흐름_제어
{
    internal class 상수와_열거형
    { 
        enum Choice
        {
            // 열거형
            // enum 값으로 지정 하는것 이므로 정수로 사용하고자 할때 (int)를 지정해야함 (캐스팅)
            // ex) (int) Choice.Rock
            Scissosrs = 0
            Rock = 1,
            Paper = 2,
        }
        static void Main(string[] args)
        {
            // 상수 지정 
            // 이름이 겹치지 않게 조심
            // 0:가위 1:바위 2:보


            // 상수 지정 -> 바로 지정
            //const int ROCK = 1;
            //const int PAPER = 0;
            //const int SCISSORS = 2;

            
            Random rand = new Random();
            int aichoice = rand.Next(0, 3); // 0~2사이의 랜덤 값

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case (int)Choice.Scissosrs:
                    Console.WriteLine("당신의 선택은 가위입니다");
                    break;
                case (int)Choice.Rock:
                    Console.WriteLine("당신의 선택은 바위입니다");
                    break;
                case (int)Choice.Paper:
                    Console.WriteLine("당신의 선택은 보입니다");
                    break;
            }

            switch (aichoice)
            {
                case (int)Choice.Scissosrs:
                    Console.WriteLine("컴퓨터의 선택은 가위입니다");
                    break;
                case (int)Choice.Rock:
                    Console.WriteLine("컴퓨터의 선택은 바위입니다");
                    break;
                case (int)Choice.Paper:
                    Console.WriteLine("컴퓨터의 선택은 보입니다");
                    break;
            }

            // 승리 무승부 패배
            // 승리
            if (choice == aichoice)
            {
                Console.WriteLine("무승부입니다");
            }
            else if (choice == (int)Choice.Scissosrs && aichoice == (int)Choice.Paper)
            {
                Console.WriteLine("당신의 승리입니다");
            }
            else if (choice == (int)Choice.Rock && aichoice == (int)Choice.Scissosrs)
            {
                Console.WriteLine("당신의 승리입니다");
            }
            else if (choice == (int)Choice.Paper && aichoice == (int)Choice.Rock)
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

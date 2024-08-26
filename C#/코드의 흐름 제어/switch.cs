using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.코드의_흐름_제어
{
    internal class @switch
    {
        static void Main(string[] args)
        {
            int choose = 0; // 0:가위 1:바위 2:보 3:치트키

            // switch 변수 case 범위 break 계산 완료후 나가기

            // switch 는 값에 따른 분기를 따를때 사용 가능
            switch (choose)
            {
                case 0:
                    Console.WriteLine("가위");
                    break;
                case 1:
                    Console.WriteLine("바위");
                    break;
                case 2:
                    Console.WriteLine("보");
                    break;
                case 3:
                    Console.WriteLine("치트키");
                    break;
                default:
                    Console.WriteLine("실패");
                    break;
            }



            // 삼항연산자
            // (조건 ? 맞을때 : 틀릴때)

            int number = 25;
            bool ispair = ((number % 2) == 0) ? true : false;


            if ((number % 2) == 0) 
                ispair = true;
            else
                ispair = false;
            



        }
    }
}

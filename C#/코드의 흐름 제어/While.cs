using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.코드의_흐름_제어
{
    internal class While
    {
        static void Main(string[] args)
        {
            // While ( 반복문 )
            // while () 안의 값이 참일 경우 중괄호 안의 내용을 반복함
            // while 문 은 잘못하면 게임 크래시가 나므로 주의할 것
            int count = 5;

            while (count > 0)
            {
                Console.WriteLine("Hello, World");
                count--;
            }

            // do while 문 
            // 첫번째는 실행 후 반복할지 선택함

            string answer; // 변수 지정을 밖에 따로 하는 이유는 유효범위가 있기 때문 

            do
            {
                Console.WriteLine("당신은 사람인가요 (Y/S) :");
                answer = Console.ReadLine();
            } while (answer != "Y");

            Console.WriteLine("정답");

        }
    }
}

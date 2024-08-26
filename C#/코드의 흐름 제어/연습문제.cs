using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace C_.코드의_흐름_제어
{
    internal class 연습문제
    {
        // 팩토리얼 메소드 만들기
        static int Factorial(int n)
        {
            int ret = 1;// 유효범위 밖에 작성하여야 작동됨
            
            for (int num = 1; num <= n; num++) // 조건식이 flase 가 되면 반복문에서 빠져나옴
            {
                ret *= num;               
            }
            return ret;
        }

        // 팩토리얼 메소드 만들기 2 // 재귀함수 ( 자기자신을 참조
        static int Factorial2(int n)
        {
            if (n == 1)
                return 1;
            // n 이 1일경우 Stack overflow... (자기자신을 참조함) <- 오류
            return n * Factorial2(n - 1);
        }

    static void Main(string[] args)
        {
            // 구구단 2단부터 9단까지 프로그래밍 하시오
            /* 내가 만든 것
            int c = 0;
            for (int a = 2; a < 10; a++)
            {
                for (int B = 1; B < 10; B++)
                {
                    int C = a * B;
                    Console.WriteLine($"{a}x{B}={C}");
                }
            }
            */

            for (int a = 2; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    Console.WriteLine($"{a} * {b} = {a * b}");
                }
            }



            // 별로 피라미드 만들기

            for (int i = 0; i < 5; i++)
            { 
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            // 팩토리얼

            int ret = Factorial(5);
            Console.WriteLine(ret);

            // 팩토리얼2

            int ret2 = Factorial2(5);
            Console.WriteLine(ret2);
            
        }
    }
}

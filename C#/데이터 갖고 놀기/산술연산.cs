using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace C_
{
    internal class 산술연산
    {
        static void Main(string[] args)
        {
            // [ 100 ] \
            int hp = 100;
            // 1) 할당         int hp;
            // 2) write (쓰기) hp = 100;
            // 3) read  (읽기) hp

            int value = 15;
            int heal = 5;
            hp = hp - value + heal;
            
            Console.WriteLine(hp);

            // 산술 연산
            // + - * / %

            // 몫 과 나머지
            // int n = 0;
            int a = 10 / 3; // 정수형으로 나눴으므로 3, 0으로 나눌 수 없음
            int b = 10 % 3; // % 으로 나눌 경우 나머지를 구함

            Console.WriteLine(a);
            Console.WriteLine(b);

            int h = 101;
            h = h % 2;
            if (h == 0) { Console.WriteLine("짝수"); };
            if (h == 1) { Console.WriteLine("홀수"); };
            

            float f = 100.0f;
            int t = 100;
            Console.WriteLine(f/3);
            Console.WriteLine(t/3);

            int aa = 10;
            aa = aa = 5;
            aa += 5; // aa = aa + 5 와 같이 변수가 2번 들어가는 경우 대신 사용

            aa = aa - 5;
            aa -= 5;

            aa = aa * 5;
            aa *= 5;

            aa++; // 1을 더하는 경우 더 줄여서 사용
            aa--;  // 1을 더하는 경우 ( **, //, %% 는 없음


            int z = 10;

            int y = ++z; // 우선순위가 낮음
            // int y = z;
            // z += 1;

            int y = z++; // 우선순위가 높음
            // z += 1;
            // int y = z;

            Console.WriteLine(y);




        }
    }
}

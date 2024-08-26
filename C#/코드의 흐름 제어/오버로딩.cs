using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.코드의_흐름_제어
{
    internal class 오버로딩
    {   // 오버로딩 = 과적하다, [함수 이름의 재사용] 
        // 같은 이름을 사용하고자 할때 매개변수의 형식과 이름이 완전히 같으면 안됨
        static int Add(int a, int b)
        {
            Console.WriteLine("Add int 호출");
            return a + b;
        }

        // 매개변수의 형식 혹은 숫자를 바꾸거나 늘리면 오버로딩 가능
        static int Add(int a, int b, int c)
        {
            Console.WriteLine("Add int 호출");
            return a + b + c;
        }

        static float Add(float a, float b)
        {
            Console.WriteLine("Add float 호출");
            return a + b;
        }

        /* 반환형식이 다르거나 매개변수의 순서가 다르다 하더라도 같은 이름을 사용할 수 없음
        static void Add(int b, int a)
        {
           Console.WriteLine("Add int 호출");
            return a + b;
        }
        */

        // 선택적 매개변수
        /*
        static int Add(int a, int b, float c = 0, double d = 0)
        {
            Console.WriteLine("Add int 호출");
            return a + b + c + d;
        }
        */



        static void Main(string[] args)
        {
            int ret1 = 오버로딩.Add(2, 3);
            Console.WriteLine(ret1);

            float ret2 = 오버로딩.Add(2.0f, 3.0f);
            Console.WriteLine(ret2);

            int ret3 = 오버로딩.Add(3, 4, 5);
            Console.WriteLine(ret3);

            /*
            int ret4 = 오버로딩.Add(1, 2, 3.0f, 4.0); // 선택적 매개변수를 사용할 경우 순서를 잘 지켜야함
            Console.WriteLine(ret4);
            */
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.코드의_흐름_제어
{
    internal class ref_와_out
    {
        static void AddOne(ref int number) // ref 참조 복사X
        {
            number = number + 1;

        }

        // 일반적으로는 리턴값을 반환 후 필요에따라 원본값에 넣든 다르게 활용하든 함
        static int AddOne2(int number)
        {
            return number + 1;
        }



        static void Swap(ref int c, ref int d) // ref 를 사용하지 않아도 문법상 문제가 없는게 문제 아닌 문제
        { 
            int temp = c;
            c = d;
            d = temp;
        }


        static void Divide(int a, int b, out int result1, out int result2)
        {
            result1 = a / b;
            result2 = a % b;
        }



        static void Main(string[] args)
        {
            // 진퉁
            int a = 0;
            ref_와_out.AddOne(ref a);
            Console.WriteLine(a);

            // 진퉁의 값을 들고와 계산
            a = ref_와_out.AddOne2(a);
            Console.WriteLine(a);



            int num1 = 1;
            int num2 = 2;
            ref_와_out.Swap(ref num1, ref num2);

            Console.WriteLine(num1);
            Console.WriteLine(num2);



            int num3 = 10;
            int num4 = 3;

            int result1;
            int result2;
            Divide(10,3,out result1, out result2);

            Console.WriteLine(result1);
            Console.WriteLine(result2);

        }
    }
}

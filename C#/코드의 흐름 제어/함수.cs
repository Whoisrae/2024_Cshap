using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.코드의_흐름_제어
{
    internal class 함수
    {
        // 메소드 함수 거의 비슷함
        // 클래스 안에 있어야함

        //한정자 반환형식 이름(매개변수목록)
        //{
        //
        //}
        
        static void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }


        // 덧셈 함수
        // 매개변수목록의 int a 같은 경우 변수 a 가 아닌 이 위치에 오는 것을 a 라고 부르겠다
        // 
        static int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }


        static void AddOne (ref int number) // ref 참조 복사X
        {
            number = number + 1;

        }




        static void Main(string[] args)
        {
            // 메소드(함수) 코드를 재사용 할수있게 묶는다

            함수.HelloWorld();


            // 4,5 = 9
            int result = 함수.Add(4, 5);
            Console.WriteLine(result);

            // 입력으로 넘기는 값을 복사 혹은 참조로 입력가능
            // 복사(짭퉁) ref 참조(찐퉁) 
            // ref O 변수 n 자체를 넘기겠다
            // ref X 변수 n 이 가지고 있는 값을 넘길테니 확인해달라

            int n = 0;
            함수.AddOne(ref n);

            Console.WriteLine(n);
        }

    }
}

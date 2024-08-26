using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.코드의_흐름_제어
{
    internal class For
    {
        static void Main(string[] args)
        {
            /*
            for (초기화식; 조건식; 반복식)
            {
            }
            */

            // 반복식 같은 경우 조건과 반복식이 바로 확인 가능하므로 주로 for문을 사용
            for (int i = 0; i < 5; i++) // 반드시 3개의 식을 채울 필요는 없음
            {
                Console.WriteLine("Hello, World");
            }

            // 코드 진행 순서는 초기화식 -> 조건식 -> 중괄호 내용 -> 반복식 으로 진행된다.
        }
    }
}

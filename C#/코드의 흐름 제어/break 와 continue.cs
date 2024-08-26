using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.코드의_흐름_제어
{
    internal class break_와_continue
    {
        static void Main(string[] args)
        {
            // break 특정 조건 달성 시 루프 탈출용으로 사용
            //while (true)
            //{
            //   break;
            //}

            int num = 123; // 1, 97로만 나뉘는 숫자

            bool isPrime = true;

            for (int i = 2; i < num; i++)
            {
                if ((num % i) == 0)
                {
                    isPrime = false;
                    break;
                }
            }
             Console.WriteLine("소수가 아닙니다");


            // countinue 특정 조건 달성 시 다음 루프로 이동 
            // 파티 범위 힐을 할때 주변 유저를 서칭하고 파티원이 아닐경우 continue 한다
            for (int j = 0; j < 100; j++)
            {
                if ((j % 3) != 0)
                    continue;
                    
                Console.WriteLine($"3으로 나뉘는 숫자 발견 : {j}");
                
            }




        }
    }
}

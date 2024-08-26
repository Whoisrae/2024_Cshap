using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    internal class program_1
    {
        static void Main(string[] args)
        {

            // 캐스팅 (형변환) (큰변수를 작은 변수으로 옮기고자 할때 어떠한 일이 생길지 모르므로 한번 더 확인하고자하는 방식)
            int a = 100;
            short b = (short)a;

            // 100 -> 100.0f 이상없음
            // 100.5f -> 50 (더 작은 변수로 변환 할경우 0.5가 없어지므로 한번 더 확인하고자함)
            float c = a;
            int d = (int)c;



            // 스트링포맷
            // string 변수 같은 경우 클래스에 해당하기 때문에 캐스팅으로 변환할 수 없음
            // string -> int
            //string input;
            //input = Console.ReadLine();
            //int number = int.Parse(input);          
            //Console.WriteLine(input);

            // 옛날 코드
            // int -> string
            int hp = 100;
            int maxHp = 100;

            // 당신의 HP는 100입니다.
            
            // string message = string.Format("당신의 HP는 {0}/{1} 입니다", hp, maxHp);
            // Console.WriteLine(message);

          
            string message = $"당신의 HP는 {hp}/{maxHp}입니다";
            Console.WriteLine(message);

                    }
    }
}

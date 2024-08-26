using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    internal class 논리연산
    {
        static void Main(string[] args)
        {

            bool isTall = true; // 키가 크다.
            bool isSmart = false; // 똑똑하다.

            // AND  OR  NOT
            // &&   ||   !

            // 키가 크면서 AND 똑똑하다
            bool boy = (isTall && isSmart);

            // 키가 크거나 OR 똑똑하다
            bool man = (isTall || isSmart);

            // 반전
            bool woman = !isTall;

            Console.WriteLine(boy);
            Console.WriteLine(man);
            Console.WriteLine(woman);



            int level = 5;
            int isStr = 5;
            int isDex = 5;

            bool isHighlevel = (level >= 10);
            bool isStrong = (isStr >= 10);
            bool isDexterity = (isDex >= 10);

            bool isEnterDungeon1 = (isHighlevel && isStrong);
            bool isEnterDungeon2 = (isHighlevel && isDexterity);
            bool isdead = !(level >= 10) && !(isStr >= 10) && !(isDex >= 10);

            Console.WriteLine(isEnterDungeon1);
            Console.WriteLine(isEnterDungeon2);
            Console.WriteLine(isdead);


        }
    }
}

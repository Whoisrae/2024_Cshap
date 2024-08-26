using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace C_
{
    internal class 비교연산
    {
        static void Main(string[] args)
        {
            // < <= > >= == != 
            // 비교연산은 bool 데이터 타입을 사용

            int hp = 100;
            int maxhp = 100;

            bool fullHp = (hp == maxhp);
            Console.WriteLine(fullHp);

            bool isAlive = (hp > 0); // () 는 가독성을 위해 추가함
            Console.WriteLine(isAlive);

            bool isDead = (hp <= 0);
            Console.WriteLine(isDead);

            int level = 10;
            bool canEnterDungeon = (level <= 5);
            Console.WriteLine(canEnterDungeon);
        }
    }
}

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            // (주석)
            /* 
            공간 안 모두 주석처리
            */

            // 데이터의 타입

            // int      정수형 ( -1 0 1 2 3 ) ( HP, 아이템의 개수, 스탯 등등 )
            // float    실수형 ( 3.14 ) ( 소수점이 붙은 숫자, 속도 등등 )
            // string   문자열 ( "조휘래" ) ( 채팅메시지, 퀘스트 이름 등등 )
            // bool     불리언 ( true/false ) ( 자동사냥 on/ off )


            // 변수
            // [데이터 타입] [이름] = ?;

            // int 정수형 (int = -21억 ~ 21억 )
            int hp = 100;
            int maxHp;
            maxHp = hp;

            // hp = 100;        10진법 0 1 2 3 4 5
            // hp = 0b01100110; 2진법 0b00 0b01 0b10 (직관적이나 숫자가 빨리 불어남)
            // hp = 0x64;       16진법 0x124FA (비트연산에 유리, 2진법을 4개씩 분리하여 계산)



            float mp;  // 실수형
            mp = 3.5f; // f가 붙어야 float 타입으로 표현, 메모리 공간은 유한하기 때문에 완전히 정밀하게 표현할수 없음



            string name; // 문자열
            name = "Who_is_rae"; // 큰 따옴표 ""
            Console.WriteLine(name);
            char ch;  // 문자 하나만 표시 가능
            ch = 'a';            // 작은 따옴표 ''


            bool b;  // true ( 참 ) or false ( 거짓 ) 으로만 표시
            b = false;
            b = true;

            // AUTOplay on/off (자동사냥)
            // sound on/off (사운드 on/off)
            // isAdmin on/off (관리자 on/off) 등등

                 }
    }
}
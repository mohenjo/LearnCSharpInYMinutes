using System;
using static System.Math; // C# 6부터 제공되는 기능입니다.

namespace Learning.CSharp
{
    class StaticUsing
    {
        public static void StaticUsingExample()
        {
            Console.WriteLine("The squre root of 4 is {0}", Math.Sqrt(4));
            // using static을 사용하면 클래스명을 생략하고 정적 멤버를 직접 사용할 수 있습니다.
            Console.WriteLine("The squre root of 4 is {0}", Sqrt(4));

        }
    }
}

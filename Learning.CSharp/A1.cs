using System;

namespace Learning.CSharp
{
    // partial 문을 사용하여 클래스를 여러 개의 .cs 파일에 작성할 수 있습니다.
    public partial class A
    {
        public static void A1()
        {
            Console.WriteLine("Method A1 in class A");
        }
    }
}

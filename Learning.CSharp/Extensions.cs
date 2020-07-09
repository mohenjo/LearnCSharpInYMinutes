using System;

namespace Learning.CSharp
{
    // 확장메서드는 클래스 등을 직접 변경하지 않고도 클래스 외부에서 메서드를 정의하는 방법입니다.
    // 정적(static) 클래스 내에서 정적(static) 메서드로 정의됩니다.
    public static class Extensions
    {
        public static void Print(this object obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }
}

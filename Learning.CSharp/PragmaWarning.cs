using System;

namespace Learning.CSharp
{
    public static class PragmaWarning
    {
        // 더 이상 사용하지 않거나 그럴 예정인 코드 다루기

        [Obsolete("NewMethod를 사용하세요", false)] // false인 경우 컴파일러 경고, true인 경우 예외가 발생
        public static void ObsoleteMethod()
        {
            // 구버전 코드
        }

        public static void NewMethod()
        {
            // 새로운 코드
        }
    }
}

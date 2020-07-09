using System;

namespace Learning.CSharp
{
    // 패턴 매칭
    class PatternMatchingTest
    {
        // switch 문을 통해 패턴매칭을 구혀할 수 있으며, 이 때 일치하는 형식의 순서에 유의해야 합니다.
        public static (string, int)? CreateLogMessage(object data)
        {
            switch (data)
            {
                // 레이블을 참으로 만드는 필터 조건을 지정하기 위해 when 키워드를 사용할 수 있습니다.
                case System.Net.Http.HttpRequestException h when h.Message.Contains("404"):
                    return (h.Message, 404);
                case System.Net.Http.HttpRequestException h when h.Message.Contains("400"):
                    return (h.Message, 400);
                case Exception e:
                    return (e.Message, 500);
                case string s:
                    return (s, s.Contains("Error") ? 500 : 200);
                case null:
                    return null;
                default:
                    return (data.ToString(), 500);
            }
        }

        public static void PatternMatchingExample(object o)
        {
            if (o is null)
            {
                Console.WriteLine("null 형식입니다");
            }
            // cf. out 키워드를 사용하기 위해 별도로 변수를 선언하지 않고, 예) int a => out a
            // out <데이터형식> <변수명>으로 인라인 out 선언 가능. 예) out int a
            if (o is int i) // 인라인 아웃변수처럼 scope 내에서 사용 가능합니다.
            {
                Console.WriteLine($"정수값 {i}을(를) 가집니다");
            }
            else
            {
                return;
            }
            Console.WriteLine(new string('*', i)); // 위의 int i가 지역변수로 선언된 것과 같은 상황입니다.
        }
    }
}

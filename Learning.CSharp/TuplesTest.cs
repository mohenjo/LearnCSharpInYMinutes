using System;

namespace Learning.CSharp
{
    // 튜플(Tuple)
    // 튜플형식에 대해서는 이 링크를 참조하세요: https://docs.microsoft.com/ko-kr/dotnet/csharp/tuples
    class TuplesTest
    {
        public (string, string) GetName()
        {
            // 튜플의 각 필드는 기본적으로 Item1, Item2, ... 입니다.
            var names1 = ("Peter", "Parker");
            Console.WriteLine(names1.Item2); // => Parker

            // 튜플의 필드명을 명시적으로 지정할 수 있습니다.
            (string FirstName, string LastName) names2 = ("Peter", "Parker");
            // 또는
            var names3 = (First: "Peter", Last: "Parker");

            Console.WriteLine(names2.FirstName); // => Peter
            Console.WriteLine(names3.Last); // => Parker

            return names3;
        }

        public string GetLastName()
        {
            var fullName = GetName();

            // 튜플은 다음과 같이 분리해서 할당 가능합니다.
            (string firstName, string lastName) = fullName;

            // 사용하지 않는 부분은 다음과 같이 처리할 수 있습니다.
            var (_, last) = fullName;
            return last;
        }

        public int RandomNumber = 4;
        public int ANotherRandomNumber = 10;

        // 튜플 형식에 대해서는 Deconstruct 메소드에 의한 튜플 분리를 기본 제공합니다.
        // 클래스, 구조체 또는 인터페이스에서 하나 이상의 Deconstruct 메서드 구현 => 인스턴스에 대한 튜플 분리
        // 이 메서드는 void를 반환하며 분해할 각 값은 메서드 시그니처에서 out 매개 변수로 표시됩니다. 
        public void Deconstruct(out int randomNumber, out int anotherRandomNumber)
        {
            randomNumber = this.RandomNumber;
            anotherRandomNumber = this.ANotherRandomNumber;
        }

        public static void TuplesTestExample()
        {
            var tt = new TuplesTest();
            Console.WriteLine($"GetName: {tt.GetName()}");
            Console.WriteLine($"GetLastName: {tt.GetLastName()}");

            (int num1, int num2) = tt; // Deconstruct 메소드에 의한 튜플 분리
            Console.WriteLine($"num1: {num1}, num2: {num2}");
        }
    }
}

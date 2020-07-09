using System;

namespace Learning.CSharp
{
    // 지역 함수(local functions)
    class LocalFunctionTest
    {
        private static int _id = 0;
        public int Id;
        public LocalFunctionTest()
        {
            Id = generateId();

            // 이 로컬 함수는 이 코드 블록의 범위 내에서만 사용될 수 있습니다.
            int generateId()
            {
                return _id++;
            }
        }

        public static void LocalFunctionExample()
        {
            var lf1 = new LocalFunctionTest();
            var lf2 = new LocalFunctionTest();
            Console.WriteLine($"{lf1.Id}, {lf2.Id}"); // => 0, 1

            // int id = generateId();
            // CS0103: 'generateId' 이름이 현재 컨텍스트에 없습니다.
        }
    }
}

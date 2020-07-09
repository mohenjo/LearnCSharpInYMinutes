using System;

namespace Learning.CSharp
{
    // REFERENCE LOCALS (참조반환 - 참조로컬)
    // 개체의 값 대신에 개체에 대한 참조값을 반환할 수 있게 합니다.
    class RefLocalsTest
    {
        // ref 키워드는 메모리 공간에 대한 레퍼런스를 의미합니다.
        // int a;
        // ref int b = ref a;
        // b= 2; => a와 b가 동일한 메모리를 가리키고 있으므로 a, b 값 모두 2 입니다.

        // 위와 동일한 방식으로 return ref를 사용합니다.
        // 큰 용량의 데이터에서 특정 요소를 반환하여 액세스할 때 유용하게 사용될 수 있습니다.
        // (반환 시그니처 및 return 문에 ref가 있습니다.)
        public static ref string FindItem(string[] arr, string el)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == el)
                {
                    return ref arr[i];
                }
            }
            throw new Exception("Item not found");
        }

        public static void RefLocalExample()
        {
            string[] arr = { "this", "is", "an", "array" };

            ref string item = ref FindItem(arr, "array");
            item = "apple";
            Console.WriteLine(arr[3]);
        }
    }
}

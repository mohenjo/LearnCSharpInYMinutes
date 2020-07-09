// 한 줄 주석은 '//'로 시작합니다.
// 한 줄 주석은 보통 별도의 라인에 작성하며, 명령문 뒤에 기입하는 것을 권장하지 않습니다.

/*
여러 줄 주석은 다음과 같이 사용합니다.

이 소스는 C#의 기능에 대해 간단히 설명하는 것이므로,
이 문서에 나타낸 (1) 프로젝트 및 소스코드의 구조, (2) 클래스, 메소드 및 변수명 및 이의 사용 (3) 코드의 흐름 등은
실제 코딩 컨벤션에서 사용되거나 권장되는 방식과 다를 수 있습니다.
*/

// 이 소스 코드가 사용하는 네임스페이스입니다.
// 다음의 네임스페이스는 모두 .NET Framework 클래스 라이브러리입니다.
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 네임스페이스는 코드 프로젝트의 범위를 구성합니다.
// 다른 소스파일에서 참조하여 사용하려면: using Learning.CSharp
namespace Learning.CSharp
{
    // 각 .cs 파일은 파일멸과 동일한 이름의 클래스를 포함해야 합니다.
    // 여러 개의 클래스를 포함하거나, 파일명과 동일한 클래스를 포함하지 않아도 상관은 없으나, 
    // 통상적인 프로그래밍에서는 이러한 규칙을 따르는 것이 좋습니다.
    class LearnCSharp
    {
        /// <summary>
        /// XML 문서 주석은 다음과 같이 작성하며, 
        /// 외부 문서 또는 IDE 내의 컨텍스트 도움말 제공에 사용됩니다.
        /// </summary>
        /// <param name="firstParam">firstParam에 대한 설명</param>
        /// <returns>메소드의 반환값에 대한 정보</returns>
        public void MethodOrClassOrOtherWithParsableHelp(string firstParam)
        {
            _ = firstParam; // 사용하지 않는 변수는 무시항목(또는 임시더미변수)('_')에 할당할 수 있습니다. (C# 7.0 이상)
        }

        // BASIC SYNTAX - Java 또는 C++에 익숙하다면, INTERESTING FEATURE 항목으로 넘어가도 무방합니다.
        public static void Syntax()
        {
            // Console.WriteLine을 사용하여 라인을 출력합니다.
            Console.WriteLine("Hello World");
            Console.WriteLine(
                "Integer: " + 10 +
                " Double: " + 3.14 +
                " Boolean: " + true);

            // 개행 없이 출력하기 위해서는 Console.Write를 사용합니다.
            Console.Write("Hello ");
            Console.Write("World\n");

            ///////////////////////////////////////////////////
            // 형식 및 변수
            //
            // 변수의 선언: <데이터형> <변수명>
            ///////////////////////////////////////////////////

            // Sbyte - 부호있는 8비트 정수 
            // (-128 <= sbyte <= 127)
            sbyte fooSByte = 100;
            Console.WriteLine(fooSByte);

            // Byte - 부호없는 8비트 정수
            // (0 <= byte <= 255)
            byte fooByte = 100;
            Console.WriteLine(fooByte);

            // Short - 16비트 정수
            // 부호있는 정수 - (-32,768 <= short <= 32,767)
            // 부호없는 정수 - (0 <= ushort <= 65,535)
            short fooShort = 10000;
            ushort fooUShort = 10_000; // 언더바(_)를 이용해 숫자 단위를 끊어 식별하도록 할 수 있습니다.
            Console.WriteLine(fooShort.ToString() + " " + fooUShort.ToString());

            // Integer - 32비트 정수
            // 부호있는 정수 - (-2,147,483,648 <= int <= 2,147,483,647)
            // 부호없는 정수 - (0 <= uint <= 4,294,967,295)
            int fooInt = 1;
            uint fooUInt = 1;
            // 정수는 기본적으로 크기에 따라 int 또는 uint에 할당됩니다.
            Console.WriteLine(fooInt.ToString() + " " + fooUInt.ToString());

            // Long - 64비트 정수
            // 부호있는 정수 - (-9,223,372,036,854,775,808 <= long <= 9,223,372,036,854,775,807)
            // 부호없는 정수 - (0 <= ulong <= 18,446,744,073,709,551,615)
            long fooLong = 100_000L;
            ulong fooUlong = 100_000L;
            // L은 변수 값이 long 또는 ulong 형식임을 나타냅니다.
            Console.WriteLine(fooLong.ToString() + " " + fooUlong.ToString());

            // Double - 배정도 64비트 IEEE 754 부동소수점 실수
            double fooDouble = 123.4; // 정밀도: 15~16자리
            Console.WriteLine(fooDouble);

            // Float - 단정도 32비트 IEEE 754 부동소수점 실수
            float fooFloat = 234.5f; // 정밀도: 7자리
            // f는 변수 값이 float 형식임을 나타냅니다.
            Console.WriteLine(fooFloat);

            // Decimal - 128비트 실수 형식으로 금융 분야 등 높은 정밀도를 필요로 하는 계산에 사용됩니다.
            decimal fooDecimal = 150.3m;
            // m은 변수 값이 decimal 형식임을 나타냅니다.
            Console.WriteLine(fooDecimal);

            // Boolean - true(참) 또는 false(거짓)
            bool fooBoolean = true; // 또는 false
            Console.WriteLine(fooBoolean);

            // Char - 16비트 유니코드 문자를 나타냅니다.
            char fooChar = 'A';
            Console.WriteLine(fooChar);

            // String - 앞서 나타낸 데이터 형식은 모두 값 형식(value type)인 반면,
            // string은 참조 형식(reference type)입니다. 즉, 널(null) 값을 가질 수 있습니다.
            string fooString = "\"이스케이프 문자\"의 사용이 가능하며, \n(개행) 및 \t(탭) 등을 표현할 수 있습니다.";
            Console.WriteLine(fooString);

            // 인덱서(indexer)를 이용해 문자열 내 문자에 엑세스할 수 있습니다.
            char charFromString = fooString[1]; // => '이'
            Console.WriteLine(charFromString);
            // 문자열은 불변(immutable)이므로 fooString[1] = '삼'; 과 같이 할 수 없습니다.

            // string.Compare는 지정된 규칙을 사용하여 두 문자열을 비교하고
            // 정렬된 순서에서 두 개체의 상대위치를 나타내는 정수를 반환합니다.
            // 정렬 시 fooString이 "x"보다 앞에 올 경우 0보다 작은 값, 그 반대의 경우 0보다 큰 값을,
            // 두 문자열의 정렬 순서가 동일할 경우 0의 값을 반환합니다.
            int fooStringCompare = string.Compare(fooString, "x", StringComparison.CurrentCultureIgnoreCase);
            // 문자열 비교 옵셥으로 현재 문화권의 정렬 규칙을 사용하고 
            // 비교되는 문자열의 대/소문자를 무시하여 문자열을 비교합니다.
            Console.WriteLine(fooStringCompare);

            // 다음과 같이 문자열 포맷을 지정할 수 있습니다.
            string fooFS = string.Format("Check Check, {0} {1}, {0} {1:0.0} {2}", 1, 2, 3);
            Console.WriteLine(fooFS);

            // 날짜와 시간 문자열 포맷
            DateTime fooDate = DateTime.Now;
            Console.WriteLine(fooDate.ToString("hh:mm dd MM yyyy"));

            // Verbatim String
            // @ 문자를 이용하여 이스케이프 문자를 사용하지 않고 문자열을 있는 그대로 사용할 수 있습니다.
            // 단, 따옴표(")를 표시하기 위해서는 ""와 같이 사용해야 합니다. 
            string path = "C:\\Users\\User\\Desktop";
            string verbatimPath = @"C:\Users\User\Desktop";
            Console.WriteLine(path == verbatimPath);
            string bazString = @"Here's some stuff
on a new line! ""Wow!"", the masses cried";
            Console.WriteLine(bazString);

            // const 또는 read-only를 이용하여 불변 변수(상수)를 선언할 수 있습니다.
            // const(상수)는 컴파일 시점에 계산되며, readonly(읽기전용)는 런타임 시점에 계산됩니다.
            const int HoursWorkPerWeek = 9001;
            _ = HoursWorkPerWeek;

            ///////////////////////////////////////////////////
            // 데이터 구조
            ///////////////////////////////////////////////////

            // Array(배열) - 인덱스는 0에서부터 시작합니다.
            // 사용하기 전에 배열의 크기를 선언해야 하며, 다음과 같이 선언, 초기화 합니다.
            // <데이터형식>[] <변수명> = new <데이터형식>[<배열 크기>];
            int[] intArray = new int[10]; // 데이터형(int)의 기본값으로 초기화됩니다.
            // 다음과 같이 선언하고 초기화할 수도 있습니다.
            int[] anotherArrayDeclaration = { 9000, 1000, 1337 };

            // 배열 요소 접근
            Console.WriteLine("intArray @ 0 index: " + intArray[0]);
            // 배열의 요소를 변경할 수 있습니다.
            intArray[1] = 999;
            Console.WriteLine("intArray @ 1 index: " + intArray[1]);

            // List(리스트)
            // 리스트는 배열보다 유연하여 더 널리 사용되며, 다음과 같이 선언됩니다.
            // List<데이터형식> <변수명> = new List<데이터형식>();
            List<int> intList = new List<int>();
            List<string> stringList = new List<string>();
            List<int> anotherListInitialization = new List<int> { 9000, 1000, 1337 };
            // <>는 뒤에서 다룰 제네릭스를 의미합니다.

            // 리스트는 배열과 달리 기본값을 갖지 않습니다. (참조형)
            // 요소에 접근하기 전에 값이 할당되어야 합니다.
            intList.Add(999);
            Console.WriteLine(intList[0]);

            // 이외에도 다음과 같은 데이터 구조가 자주 사용됩니다.
            // Stack
            // Queue
            // Dictionary (hash map)
            // HashSet
            // ReadOnlyCollection
            // Tuple

            ///////////////////////////////////////
            // 연산자
            ///////////////////////////////////////

            int i1 = 1, i2 = 2; // 여러 개의 선언을 한 줄에 할 수도 있습니다.

            // 연산은 직관적인 방법으로 수행 가능합니다.
            Console.WriteLine(i1 + i2 - i1 * 3 / 7); // => 3 (정수 연산)

            // 나머지
            Console.WriteLine("11 % 3 = " + (11 % 3)); // => 2

            // 비교연산
            Console.WriteLine("3 == 2 ? " + (3 == 2)); // => false
            Console.WriteLine("3 != 2 ? " + (3 != 2)); // => true
            Console.WriteLine("3 > 2 ? " + (3 > 2)); // => true
            Console.WriteLine("3 < 2 ? " + (3 < 2)); // => false
            Console.WriteLine("2 <= 2 ? " + (2 <= 2)); // => true
            Console.WriteLine("2 >= 2 ? " + (2 >= 2)); // => true

            // Bitwise 연산
            /*
            ~   단항 비트 보수 연산자 (각 비트를 반대로하여 해당 피연산자의 보수를 생성)
            <<  좌측 시프트 연산자 (연산자 좌측 피연산자를 우측 피연산자의 비트수 만큼 좌측으로 이동)
            <<  우측 시프트 연산자 (연산자 좌측 피연산자를 우측 피연산자의 비트수 만큼 우측으로 이동)
            &   논리 AND
            |   논리 OR
            ^   논리배타적 OR (XOR)
            */

            // 증감연산
            int i = 0;
            Console.WriteLine(i++); // 0 출력, i = 1, 후 증가
            Console.WriteLine(++i); // 2 출력, i = 2, 선 증가
            Console.WriteLine(i--); // 2 출력, i = 1, 후 감소
            Console.WriteLine(--i); // 0 출력, i = 0, 선 감소

            ///////////////////////////////////////
            // 제어 구조
            ///////////////////////////////////////

            int j = 10;
            if (j == 10)
            {
                Console.WriteLine("j = 10");
            }
            else if (j > 10)
            {
                Console.WriteLine("j > 10");
            }
            else
            {
                Console.WriteLine("j < 10");
            }

            // Tenary 연산자
            // 간단한 if/else 문을 다음과 같이 사용할 수도 있습니다.
            // <조건> ? = <참인 경우> : <거짓인 경우>
            int toCompare = 17;
            string isSeventeen = toCompare == 17 ? "Yes, It's 17" : "Nope";
            Console.WriteLine(isSeventeen);

            // While 반복문
            int fooWhile = 0;
            while (fooWhile < 100)
            {
                fooWhile++; // fooWhile은 0 -> 99 (100번 반복)
            }

            // Do while 반복문
            // 조건에 상관 없이 반복문 안의 내용이 최소 한 번은 실행됩니다.
            int fooDoWhile = 0;
            bool fooDoWhileCheck = false;
            do
            {
                if (fooDoWhileCheck) // fooDoWhileCheck은 거짓이므로, 조건문 안의 내용은 실행되지 않습니다.
                {
                    continue; // 현재 수행 내용을 건너뛰고 다음 반복을 수행합니다.
                }
                fooDoWhile++;
                if (fooDoWhile == 50)
                {
                    Console.WriteLine(fooDoWhile);
                    break; // 반복문을 중지하고 빠져나갑니다.
                }
            } while (fooDoWhile < 100);

            // for 반복문
            // for (<초기자>;<조건부>;<반복자>) {}
            for (int fooFor = 0; fooFor < 10; fooFor++)
            {
                // tooFor는 0 -> 9 (10번 반복)
            }

            // foreach 반복문
            // foreach (<열거자 데이터형식> <열거자 이름> in <enumerable>) {}
            // IEnumerable 또는 IEnumerable<T> 인터페이스를 가지는 모든 오브젝트의 요소들을 열거합니다.
            // .NET Framework에서 제공하는 모든 컬렉션 형식(Array, List, DIctionary 등)은 
            // 상기 인터페이스 중 하나 또는 전부를 가집니다.
            foreach (char character in "Hello World".ToCharArray())
            {
                Console.WriteLine(character);
            }
            // 문자열은 IEnumerable 인터페이스를 가지기 때문에 ToCharArray()가 없어도 무방합니다.

            // Switch Case 분기문
            // siwtch 문의 일치식은 char, string, bool, 정수 데이터형, enum(열거형) 중 하나의 값을 
            // 반환하는 형식이어야 합니다.
            // C# 7.0부터 일치식은 null이 아닌 모든 식일 수 있습니다.
            int month = 3;
            string monthString = string.Empty; // 빈 문자열의 할당
            switch (month)
            {
                case 1:
                    monthString = "January";
                    break;
                case 2:
                    monthString = "February";
                    break;
                case 3:
                    monthString = "March";
                    break;
                // 각 케이스의 마지막은 break를 통해 빠져나와야 합니다.
                // (goto case <케이스 값>; 방식으로 명시적으로 다른 케이스로 분기할 수 있습니다.
                // 다음과 같이 여러 개의 케이스를 할당할 수도 있습니다.
                case 6:
                case 7:
                case 8:
                    monthString = "Sumer time!"; // month = 6 or 7 or 8 인 경우
                    break;
                default:
                    monthString = "Some other month";
                    break;
            }
            Console.WriteLine(monthString);

            ///////////////////////////////////////
            // 데이터 형식의 변환 및 타입캐스팅
            ///////////////////////////////////////

            // 데이터 형식의 변환

            // 문자열을 정수형으로 변환 - 변환 실패 시 FormatException 예외를 발생시킵니다.
            Console.WriteLine(int.Parse("123"));

            // TryParse()를 사용하면 변환 실패 시에도 예외를 발생시키지 않고, 목표변환형의 기본값을 얻을 수 있습니다.
            // 이 함수의 반환값은 변환의 성공여부를 나타냅니다.
            if (int.TryParse("X567", out int tryInt))
            // tryInt를 인라인 선언하지 않고, 
            // (1) if 외부에서 'int tryInt;' (2) TryParse 문의 인수로서 'out tryInt'라고 적는 방법도 가능합니다.
            {
                Console.Write("success. ");
            }
            else
            {
                Console.Write("failure. ");
            }
            Console.WriteLine("value is " + tryInt.ToString());

            // 정수를 문자로 변환
            Console.WriteLine(Convert.ToString(123456789));
            Console.WriteLine(123456789.ToString());

            // 타입캐스팅 (캐스팅 = 변환)
            // 실수 => 정수 변환 등의 경우와 같이 암시적 변환 시 정보 손실 위험이 있는 경우
            // 명시적으로 데이터형식을 변환해야 하는데, 이를 타입캐스팅이라고 합니다.
            // 형식이 안전하고 데이터 손실이 없을 경우 암시적 변환이 가능합니다.
            long castedDecimal = (int)15M;
            // decimal 형식을 int로 명시적으로 타입캐스팅한 후, long형으로 암시적 변환을 수행
            Console.WriteLine(castedDecimal);

            // 문자열 앞에 '$'를 붙여 문자열 보간(interpolation)을 할 수 있으며, 
            // 보간할 표현식은 문자열 내의 '{'와 '}'안에 위치시킵니다.
            // '$@'와 같이 verbatim string과 동시에 사용할 수도 있습니다.
            Rectangle rect = new Rectangle { Length = 5, Width = 3 };
            Console.WriteLine($"The length is {rect.Length} and the width is {rect.Width}.");
            string username = "User";
            Console.WriteLine($@"C:\Users\{username}\Desktop");

        }

        ///////////////////////////////////////
        // 클래스의 처리
        ///////////////////////////////////////
        public static void Classes()
        {
            // 각 클래스는 해당 클래스 파일을 참조하면 됩니다.

            // 클래스의 인스턴스를 만들기 위해서는 new 키워드를 사용합니다.
            Bicycle trek = new Bicycle();

            trek.SpeedUp(3);
            trek.Cadence = 100;

            Console.WriteLine("trek info: " + trek.Info());

            PennyFarthing funbike = new PennyFarthing(1, 10);
            Console.WriteLine("funbike Info: " + funbike.Info());

            Console.Write("아무 문자(char)나 입력 후 엔터키를 누르세요: ");
            int codeValue = Console.Read(); // 입력된 문자(char)의 코드값입니다.
            Console.WriteLine("input code is " + codeValue);
        }

        ///////////////////////////////////////
        // INTERESTING FEATURE
        ///////////////////////////////////////

        // 메소드의 기본 시그니처
        public // 액세스(접근) 한정자 - 접근권한 또는 visibility
            static // 특정 개체(인스턴스)가 아니라 형식 자체에 속하는 정적 멤버라는 의미
            int // 반환되는 데이터형식
            MethodSignatures(
            int maxCount, // 첫 번째 인수 - int형
            int count = 0, // 지정되지 않으면 기본값으로 0을 가짐
            int another = 3,
            params string[] otherParams // 앞의 인수 외에 이어서 전달되는 모든 인수를 받음
            )
        {
            _ = maxCount; _ = count; _ = another; _ = otherParams;
            return -1;
        }

        // 메소드는 기존의 메소드와 같은 이름을 가질 수 있습니다. (오버로딩)
        // 이 경우 기존의 메소드와 구분되는 시그니처를 가져야만 합니다. (반환형만 다른 경우는 해당되지 않습니다)
        public static void MethodSignatures(
            ref int maxCount, // 참조형식으로 전달됨
            out int count)
        {
            _ = maxCount;
            count = 15;
            // 이제 메소드 외부에서도 count 값은 15입니다.
        }

        // 제네릭스(Generics)
        // 특정 데이타 타입을 확정하지 않고 이 데이타 타입을 받아들이도록 클래스/메소드를 정의하는 방법입니다.
        // 제네릭을 사용하면 다른 데이타 타입마다 별도로 여러 개의 클래스/메소드를 (일부 중복하여) 구현할 필요가 없습니다.
        // 제네릭은 클래스, 인터페이스, 메서드에 적용 가능합니다.
        // *이 메소드는 파이썬의 SetDefault 명령을 구현한 것입니다.
        public static TValue SetDefault<TKey, TValue>(
            IDictionary<TKey, TValue> dictionary,
            TKey key,
            TValue defaultItem)
        {
            TValue result;
            if (!dictionary.TryGetValue(key, out result))
            {
                return dictionary[key] = defaultItem;
            }
            return result;
        }

        // 제네릭 타입의 범위를 제한할 수도 있습니다.
        public static void IterateAndPrint<T>(T toPrint) where T : IEnumerable<int>
        {
            // T가 IEnumerable이므로 반복문을 적용할 수 있습니다.
            foreach (var item in toPrint) // int item
            {
                Console.WriteLine(item.ToString());
            }
        }

        // YIELD
        // 'yield'문에 의해 아래 메소드는 Iterator(반복자)가 됩니다 - foreach문을 사용할 수 있다는 의미
        public static IEnumerable<int> YieldCounter(int limit = 10)
        {
            for (int i = 0; i < limit; i++)
            {
                yield return i;
            }
        }

        // 위 메소드를 다음과 같이 사용할 수 있습니다.
        public static void PrintYeildCounterConsole()
        {
            foreach (var counter in YieldCounter())
            {
                Console.WriteLine(counter);
            }
        }

        // 여러 개의 'yield return'을 사용할 수도 있습니다.
        public static IEnumerable<int> ManyYieldCounter()
        {
            yield return 0;
            yield return 1;
            yield return 2;
            yield return 3;
        }

        // 반복자의 중지를 위해 'yield break'문을 사용할 수도 있습니다.
        // 아래 메소드는 0 ~ limit/2까지의 값만 반환합니다.
        public static IEnumerable<int> YieldCounterWithBreak(int limit = 10)
        {
            for (int i = 0; i < limit; i++)
            {
                if (i > limit / 2)
                {
                    yield break;
                }
                yield return i;
            }
        }

        public static void OtherInterestingFeatures()
        {
            // 메소드 시그니처 - 인수 기본값
            _ = MethodSignatures(3, 1, 3, "Some", "Extra", "Strings");
            _ = MethodSignatures(3, another: 3); // 다른 인수의 기본값은 그대로 두고, 특정 인수에 대한 값 지정

            // ref, out 인수 전달
            int maxCount = 0, count; // ref로 전달되는 인수는 전달 이전에 값을 가지고 있어야 합니다.
            MethodSignatures(ref maxCount, out count);

            // 확장 메서드
            int i = 3;
            i.Print(); // int 구조체를 변경하지 않고, 인스턴스 메서드를 추가한 효과를 나타냅니다.

            // 델리게이트(delegate)와 이벤트(event)
            DelegateTest.UsingDelegatesAndEvents();

            // NULLABLE 형식 - 값의 반환 또는 데이터베이스와의 상호작용에 유용합니다.
            // 모든 값형식 뒤에 '?'를 붙여 nullable 형식을 만들 수 있습니다.
            // <데이터 형식(값형식)>? <변수명> = <값>
            int? nullable = null; // Nullable<int>와 같은 표현입니다.
            Console.WriteLine("Nullable variable: " + nullable);
            bool hasValue = nullable.HasValue; // null이 아니면(값을 가지면) true
            Console.WriteLine("has value? " + hasValue);

            // ?? 연산자 - null이 아닌 경우 왼쪽 피연산자의 값을, 그렇지 않으면 오른쪽 피연산자의 값을 반환합니다. 
            int notNullable = nullable ?? 0; // 0

            // ? 연산자 - null 조건 연산자
            // ? 앞의 객체가 null인지 체크: null인 경우 null을 반환, 그렇지 않으면 ? 다음의 속성/메서드를 실행
            nullable?.Print(); // nullable != null인 경우 Print() 실행

            // 암시적 형식: var - 컴파일러가 판단하여 형식을 결정합니다.
            // 아래 선언은 string magic = "magic is <하략>"; 과 동일함
            var magic = "magic is a string, at compile time, so you still get type safety";
            _ = magic;
            // magic = 9; 따라서 이와 같은 할당은 불가능

            // 제네릭스
            var phonebook = new Dictionary<string, string>()
            {
                { "Sarah", "212 555 5555"}
            }; // 초기화 할당

            // 제네릭 메서드의 호출
            Console.WriteLine(SetDefault<string, string>(phonebook, "Shaun", "No Phone"));  // No Phone
            // 제너릭 타입을 암시적으로 유추 가능하므로, 다음과 같이 사용할 수도 있습니다.
            Console.WriteLine(SetDefault(phonebook, "Sarah", "No Phone")); // 212 555 5555

            // 람다 표현식 - 무명함수(anonymous function)의 표현에 사용됩니다.
            // 형태 (<입력 인수>) => {<실행 코드 블럭>};
            // Func<입력인수의 형식(들), 반환인수 형식>, Action<입력인수의 형식(들)>은 
            // 흔히 사용되는 람다식에 대응하는 델리게이트입니다.
            Func<int, int> square = (x) => x * x;
            Console.WriteLine(square(3)); // 9

            // 예외처리
            try
            {
                var funBike = PennyFarthing.CreateWithGears(6);

                // 아래 코드에서 예외가 발생하게 되어 있으나, 
                // 위의 CreateWitrhGear(6) 부분에서 예외가 먼저 발생-처리되므로, 이하의 코드 블럭은 수행되지 않습니다.
                string some = "";
                if (true)
                {
                    some = null;
                }
                some.ToLower(); // NullReferenceException를 발생시킵니다.
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Not so much fun now!");
            }
            catch (Exception ex) // 위에 열거한 예외를 제외한 다른 모든 예외를 잡습니다.
            {
                // 예외 처리

                // 예외 처리 후 상위 호출자에게 예외를 발생시킬 수있습니다. 
                // throw new ApplicationException("It hit the fan", ex); 

                // throw; // 또는 이렇게 사용하면 콜스택이 유지됩니다.
            }
            // 모든 예외를 잡기 위해 catch {} 와 같이 사용할 수도 있습니다.
            finally
            {
                // try - catch 문 이후에 실행됩니다.
            }

            // DISPOSABLE RESOURCES MANAGEMENT - 관리되지 않는 리소스를 쉽게 다룰 수 있게 합니다.
            // 파일 핸들링, 장치 관리, 폰트 등에 관련된 클래스는 관리되지 않는 리소스에 액세스하는
            // 대표적인 클래스들입니다. (IDisposable 인터페이스를 가집니다)
            // 해당 클래스들은 사용 후 적절한 시기에 리소스를 해제(Dispose)하여 반환해야 하며,
            // using 문은 이러한 리소스 해제를 올바르게 보장합니다.
            using (StreamWriter writer = new StreamWriter("log.txt"))
            {
                writer.WriteLine("Nothing syspicious here.");
            } // 리소스 범위를 벗어나면 (예외가 발생하더라도) 리소스는 자동으로 해제됩니다.

            // 병렬 프로그래밍 (Parallel Programing)
            // 참조: https://docs.microsoft.com/en-us/archive/blogs/csharpfaq/parallel-programming-in-net-framework-4-getting-started
            var words = new List<string> { "dog", "cat", "horse", "pony" };
            Parallel.ForEach(words,
                new ParallelOptions() { MaxDegreeOfParallelism = 4 },
                word =>
                {
                    Console.WriteLine(word);
                }
                );
            // 각 스레드는 다른 시간에 끝나므로, 실행시마다 다른 결과를 나타냅니다.

            // DYNAMIC 형식 (다른 프로그래밍 언어와의 작업에 유용하게 사용될 수 있습니다)
            // dynamic 타입은 컴파일러에게 변수의 타입을 체크하지 않도록 하고, 
            // 런타임 이전에는 해당 타입을 알 수 없습니다. (내부적으로는 object 타입입니다)
            dynamic student = new ExpandoObject(); // 런타임에 동적으로 추가/제거할 수 있는 멤버가 있는 개체
            student.FirstName = "First Name"; // 클래스를 정의할 필요가 없습니다.
            // 메소드도 추가할 수 있습니다. 아래 예에서는 string을 받고, string을 반환하는 메소드
            student.Introduce = new Func<string, string>(
                (introduceTo) => string.Format("Hey {0}, this is {1}", student.FirstName, introduceTo)
                );
            Console.WriteLine(student.Introduce("Beth"));

            // IQUERYABLE<T> 
            // 대부분의 컬렉션이 이 인터페이스를 가지며, Map,  Filter, Reduce 등과 같은 유용한 메서드를 제공합니다.
            var bikes = new List<Bicycle>();
            bikes.Sort(); // 정렬
            bikes.Sort((b1, b2) => b1.Wheels.CompareTo(b2.Wheels)); // Wheels 값에 기준한 정렬

            var result = bikes
                .Where(b => b.Wheels > 3) // Filter
                .Where(b => b.IsBroken && b.HasTassles)
                .Select(b => b.ToString()); // Map
            var sum = bikes.Sum(b => b.Wheels); // Reduce

            // 익명형식으로 구성된 개체 컬렉션을 구성합니다.
            // 익명형식을 사용하면 명시적으로 형식을 정의할 필요없이 단일 개체로 편리하게 캡슐화할 수 있습니다.
            // 익명형식은 반드시 선언과 함께 new 키워드로 인스턴스를 생성해야 합니다. 
            // 생성된 인스턴스는 읽기전용이기 때문에 값 변경이 불가능합니다.
            var bikeSummaries = bikes.Select(b => new { Name = b.Name, IsAwesome = !b.IsBroken && b.HasTassles });
            foreach (var bikeSummary in bikeSummaries.Where(b => b.IsAwesome))
            {
                Console.WriteLine(bikeSummary.Name);
            }

            // AsParallel - 쿼리를 병렬화할 수 있도록 합니다.
            var threeWheelers = bikes.AsParallel().Where(b => b.Wheels == 3).Select(b => b.Name);
            // 이 쿼리는 병렬로 실행됩니다. 
            // AsParallel은 대용량 데이터셋에 대해 시스템의 모든 프로세서를 충분히 활용하도록 시도합니다.

            // LINQ(Language INtergrated Query)
            // 간략한 수식을 이용하여 데이타셋 또는 컬렉션 등의 데이터를 핸들링하며, 지연실행되는 쿼리입니다.
            // 어떤 데이터를 대상으로 하느냐에 따라 LINQ to XML, LINQ to SQL 등으로 구분됩니다.

            /*
            var db = new BikeRepository(); // 해당 클래스의 참조 링크를 참조하세요

            // 이러한 쿼리는 지연실행(필요한 시점까지 계산을 미룸)되는데, 데이터베이스에 대한 쿼리에 유용합니다.
            var filter = db.Bikes.Where(b => b.HasTassles); // 쿼리가 실행되지는 않습니다.
            if (42 > 6) // (조건에 따라) 필터를 추가할 수 있습니다. 고급검색 등에 유용하게 사용될 수 있습니다.
            {
                filter = filter.Where(b => b.IsBroken);
            }
            var query = filter
                .OrderBy(b => b.Wheels)
                .ThenBy(b => b.Name)
                .Select(b => b.Name); // 아직 쿼리는 실행되지 않았습니다.
            // 쿼리는 다음에서 실행됩니다.
            foreach (string bike in query)
            {
                Console.WriteLine(result);
            }
            */
        }

        ///////////////////////////////////////
        // 콘솔 어플리케이션의 시작부
        // 엔트리포인트 -> Main() 메소드
        ///////////////////////////////////////

        static void Main(string[] args)
        {
            _ = args; // 명령줄 인수

            Syntax();
            Classes();
            OtherInterestingFeatures();

            // partial class "A"
            A.A1();
            A.A2();

            PragmaWarning.ObsoleteMethod(); // 구버전 코드에 대해서는 컴파일러에서 경고를 띄웁니다.
            // CS0618: 'PragmaWarning.ObsoleteMethod()'은(는) 사용되지 않습니다. 'NewMethod를 사용하세요'
#pragma warning disable CS0618
            PragmaWarning.ObsoleteMethod(); // 경고가 뜨지 않습니다.
#pragma warning restore CS0618
            PragmaWarning.ObsoleteMethod(); // 다시 경고가 뜹니다.

            // C# 6
            StaticUsing.StaticUsingExample();

            // C# 7
            TuplesTest.TuplesTestExample();
            object o = 7;
            PatternMatchingTest.PatternMatchingExample(o);
            RefLocalsTest.RefLocalExample();
            LocalFunctionTest.LocalFunctionExample();
        }
    }
}

using System;

namespace Learning.CSharp
{
    // delegate와 event
    public class DelegateTest
    {
        public static int count = 0;
        public static int Increment()
        {
            return ++count;
        }

        // 델리게이트는 메서드에 대한 참조를 나타냅니다
        // 델리게이트가 호출되면 델리게이트가 참조하는 메소드(들)가(이) 호출됩니다.
        // 상기 Increment 메소드를 참조하기 위해서는 동일한 시그니처를 가진 델리게이트를 선언해야 합니다.
        // (이 예에서는 인수가 없고, int형을 반환합니다)
        public delegate int IncrementDelegate();

        // 이벤트는 델리게이트를 트리거 하기 위해 사용될 수 있습니다.
        public static event IncrementDelegate MyEvent;

        public static void UsingDelegatesAndEvents()
        {
            // 델리게이트의 초기화시 메서드를 참조할 수 있으며, 이제 메서드는 변수처럼 사용될 수 있습니다.
            IncrementDelegate inc = new IncrementDelegate(Increment);
            Console.WriteLine("inc: " + inc()); // => 1 // 시그니처대로 호출하여 사용합니다.

            // 델리게이트는 '+' 연산에 의해 중첩될 수 있습니다.
            IncrementDelegate composedInc = inc;
            composedInc += inc;
            composedInc += inc;
            // inc -> Increment() -> count = 1인 상태에서 inc 3번 추가 -> Increment() 3개 추가 -> composedInc
            // composedInc()가 실행되면 inc 3번 -> Increment() 3번 -> ++count 3번 
            Console.WriteLine("composed inc: " + composedInc()); // 4
            Console.WriteLine("composed inc: " + composedInc()); // 7

            // MyEvent에 Increment 메서드를 참조하는 델리게이트를 두 번 추가합니다. (현재 정적 변수값 count는 7입니다)
            MyEvent += new IncrementDelegate(Increment);
            MyEvent += new IncrementDelegate(Increment);

            // 이벤트를 트리거하면, 이 이벤트에 연결된 모든 델리게이트가 실행됩니다.
            Console.WriteLine("Event trigger: " + MyEvent()); // => 9
        }
    }
}

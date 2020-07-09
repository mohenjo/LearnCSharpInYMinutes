using System;

namespace Learning.CSharp
{
    // PennyFarthing 클래스는 Bicycle 클래스의 서브(자식)클래스입니다.
    class PennyFarthing : Bicycle
    {
        // (Penny Farthings은 기어가 없고, 앞바퀴가 큰 자전거입니다)

        // 클래스의 생성자를 만들지 않는 경우 기본 생성자(public <클래스명>() {})가 자동 생성됩니다. 
        // 별도의 생성자를 작성하는 경우 기본 생성자가 자동 생성되지 않습니다.
        // 자식 클래스의 생성자에서는 부모 클래스의 생성자를 자동 호출하며, 그렇게 동작하도록 해야 합니다.
        //
        // 자식 클래스의 기본 생성자는 부모 클래스의 기본 생성자를 호출하나, 
        // 자식 생성자가 매개변수를 가질 경우 대응하는 부모 클래스의 생성자를 직접 호출해주어야 합니다. 
        // ex> public <자식클래스명>(<매개변수>) : base(<부모 클래스 생성자로 전달될 매개변수>)
        //
        // 부모 생성자의 호출
        public PennyFarthing(int startCadence, int startSpeed) :
            base(startCadence, startSpeed, 0, "Penny Farting", true, BikeBrand.Electra)
        {
        }

        protected override int Gear
        {
            get
            {
                return 0;
            }
            set
            {
                if (value != 0)
                {
                    throw new InvalidOperationException("You can't change gears on a PennyFarthing.");
                }
            }
        }

        public static PennyFarthing CreateWithGears(int gears)
        {
            var penny = new PennyFarthing(1, 1);
            penny.Gear = gears; // 이렇게 하면 예외가 발생할겁니다.
            return penny;
        }

        public override string Info()
        {
            string result = "PennyFarting bicycle ";
            result += base.Info(); // 이 메소드에 대한 부모 클래스의 메소드 호출
            return result;
        }
    }
}

using System;

namespace Learning.CSharp
{
    // 클래스 선언 문법:
    // <public/private/protected/internal> class <클래스명> 
    // {
    //      <데이터 필드, 생성자, 메소드 등 ...>
    // }
    // 클래스에 포함된 함수를 일반적으로 메소드라고 합니다.
    public class Bicycle
    {
        private int _cadence;

        // 어셈블리: 버전관리되고 배포되는 프로그램의 단위
        // public은 동일 어셈블리의 다른 코드나 이 어셈블리를 참조하는 다른 어셈블리의 코드 어디서든 접근 가능합니다. 
        public int Cadence
        {
            get // 속성을 읽을 때 사용됩니다. (getter)
            {
                return _cadence;
            }
            set // 속성을 적용할 때 사용됩니다. (setter)
            {
                _cadence = value; // value는 속성에 지정되는 값입니다.
            }
        }

        // protected: 해당 클래스와 서브클래스(자식클래스)에서 접근 가능합니다.
        // virtual: 자식클래스에서 재정의(override 또는 new)가 가능합니다.
        protected virtual int Gear
        {
            // 다음과 같이 자동속성(auto property)를 구현합니다.
            get;
            set;
        }

        // internal: 동일한 어셈블리의 코드에서는 어디서든 접근 가능합니다.
        internal int Wheels
        {
            get;
            private set; // 특정 접근자(set)에 다른 액세스 한정자를 지정할 수 있습니다.
        }

        int _speed = 0; // private 키워드를 생략하면 기본적으로 private 한정자 (동일 클래스 내에서만 접근)를 갖습니다.

        public string Name { get; set; }

        // 속성을 다음과 같이 메소드 본문식으로 나타낼 수도 있습니다.
        public string LongName => Name + " " + _speed + " speed";

        // Enum(열거형)은 이름과 값(기본적으로 int)의 매핑으로 구성된 값 형식입니다.
        // 열거형의 값은 byte, sbyte, short, ushort, int, uint, long, ulong 등이 될 수 있고, 값은 중복될 수 없습니다.
        public enum BikeBrand
        {
            AIST,
            BMC,
            Electra = 42, // 특정 열거형에 특정 값을 지정할 수도 있습니다.
            Gitnae // 43
        }
        // 여기에서는 Bicycle 클래스 내에 열거형을 정의하였으므로, 
        // 클래스 외부에서는 Bicycle.BikeBrand. 을 통해 열거형에 접근합니다.

        public BikeBrand Brand; // 해당 열거형으로 필드를 구성할 수 있습니다.

        // 열거형에 플래그특성(Flags Attribute)를 지정하면 하나의 열거형 변수가 다중값을 가질 수 있습니다. 
        // OR연산(|)을 사용해서 열거형 변수가 다중값을 갖게 할 수 있으며, 
        // AND연산(&)을 사용해서 열거형 변수가 특정값을 포함하고 있는지 확인할 수 있습니다.
        // 
        // * 특성(Attribute)은 타입 혹은 그 멤버를 선언할 때 그 위에 붙이는 특별한 특성값으로 
        // 해당 타입 혹은 멤버가 어떤 특성을 갖고 있는지 나타내게 됩니다.
        [Flags]
        public enum BikeAccessories
        {
            None = 0,
            Bell = 1,
            MudGuards = 2, // 값을 수동으로 지정해주어야 합니다. 비트별로 구분되는 값이어야 합니다.
            Racks = 4,
            Lights = 8,
            FullPackage = Bell | MudGuards | Racks | Lights
        }
        public BikeAccessories Accessories { get; set; }
        // 이 클래스의 인스턴스 개체 aBike에 대해 Bell 열거형 값을 가지고 있는지 확인하기 위해서는 
        // aBike.Accessories.HasFlag(Bicycle.BikeAccessories.Bell) 또는
        // aBike.Accessories & Bicycle.BikeAccessories.Bell =! 0 (.NET 4 이전)과 같이 사용합니다.

        // 정적 멤버는 인스턴스 개체가 아니라 타입(클래스) 자체에 속합니다.
        // Console.WriteLine("Bicycles created: " + Bicycle.bicyclesCreated);
        public static int BicyclesCreated { get; set; } = 0; // 초기값을 지정할 수도 있습니다.

        // 상수와 다르게 읽기전용(readonly)는 실행타임에 설정되며,
        // 선언 시 또는 생성자에서 값이 할당되어야 합니다.
        readonly bool _hasCardsInSpokes = false; // 읽기전용 + private

        // 생성자(constructor)는 클래스 인스턴스를 생성하기 위한 방법입니다.
        // 다음은 기본 생성자입니다.
        public Bicycle()
        {
            this.Gear = 1; // 현재 인스턴스의 멤버에 접근하기 위해 this 키워드를 사용할 수 있습니다.
            Cadence = 50;
            _speed = 5;
            Name = "Bontrager";
            Brand = BikeBrand.AIST;
            BicyclesCreated++;
        }

        // 다음은 인자가 주어지는 생성자입니다.
        public Bicycle(int startCadence, int startSpeed, int startGear,
            string name, bool hasCardsInSpokes, BikeBrand brand)
        {
            Gear = startGear;
            Cadence = startCadence;
            _speed = startSpeed;
            Name = name;
            _hasCardsInSpokes = hasCardsInSpokes;
            Brand = brand;
        }

        // 오버로드된 생성자를 연결할 수도 있습니다.
        public Bicycle(int startCadence, int startSpeed, BikeBrand brand) :
            this(startCadence, startSpeed, 0, "big wheels", true, brand)
        {

        }

        // 메소드(함수) 문법:
        // <public/private/protected> <반환형식> <메소드명>(<인자>)

        // 클래스는 각 멤버 필드에 대해 getter, setter를 지정하거나
        // 속성(property)를 작성할 수 있습니다. 속성 방식이 선호됩니다.

        // 메소드 인자는 기본값을 가질 수 있습니다.
        // 이 경우 메소드는 해당 인자값이 생략된 상태로 호출될 수 있습니다.
        public void SpeedUp(int increment = 1)
        {
            _speed += increment;
        }

        public void SlowDown(int decrement = 1)
        {
            _speed -= decrement;
        }

        // 속성을 통해 값의 액세스 또는 할당이 가능합니다 - get 또는/그리고 set 명령을 사용할 수 있습니다.
        private bool _hasTassles; // private 변수
        public bool HasTassles // public 접근 한정자를 가진 속성 사용
        {
            get { return _hasTassles; }
            set { _hasTassles = value; }
        }

        // 다음과 같이 간단하게 자동속성(automatic property)를 사용할 수도 있습니다.
        // 자동속성을 사용하면 (앞선 속성의 경우와 같이) 내부적으로 private 변수를 자동 생성합니다.
        // get 또는/그리고 set 명령에 접근 한정자를 지정할 수 있습니다.
        public bool IsBroken { get; private set; }

        public int FrameSize
        {
            get;
            // 접근한정자에 private가 지정되면, 이 속성값의 설정(set)이 이 클래스 내에서만 가능하다는 의미입니다.
            private set;
        }

        // 인덱서(indexer)로 클래스나 구조체의 인스턴스를 배열처럼 접근할 수 있습니다.
        // 해당 접근자가 인덱싱을 위한 매개변수를 사용한다는 점을 제외하고는 속성과 유사합니다.
        // 인스턴스 aBicycle에 대해 aBicycle[0] 값은 "chris"를 반환하며,
        // aBicycle[1] = "lisa"와 같은 방법으로 값의 할당이 가능합니다.
        private string[] passengers = { "chris", "phil", "darren", "regina" };

        public string this[int i]
        {
            get
            {
                return passengers[i];
            }
            set
            {
                passengers[i] = value;
            }
        }

        // 이 인스턴스 개체의 특성 값들을 출력하는 메소드입니다.
        public virtual string Info()
        {
            return "Gear:" + Gear +
                " Cadence: " + Cadence +
                " Speed: " + _speed +
                " Name: " + Name +
                " Cards in Spokes: " + (_hasCardsInSpokes ? "yes" : "no") +
                "\n------------------------------\n";
        }

        // 정적(static) 메소드는 해당 클래스의 헬퍼 메소드(helper method)로 사용하면 좋습니다.
        public static bool DidWeCreateEnoughBicycles()
        {
            // 정적 메소드 내에서는 정적 멤버만 접근 가능합니다.
            return BicyclesCreated > 9000;
        }
        // 정적 멤버만 가지는 클래스의 경우라면, 클래스 자체를 정적으로 만드는 경우도 고려할 수 있습니다.
    }
}

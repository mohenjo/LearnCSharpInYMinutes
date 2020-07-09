namespace Learning.CSharp
{
    // 자식 클래스는 하나의 부모 클래스만 가질 수 있으나, 대신 여러 개의 인터페이스를 받을 수 있습니다.
    // 상속할 때는 부모 클래스, 인터페이스(들)의 순서로 적어야 합니다.
    class MountainBike : Bicycle, IJumpable, IBreakable
    {
        int damage = 0;

        public void Jump(int meters)
        {
            damage += meters;
        }

        public bool Broken
        {
            get
            {
                return damage > 100;
            }
        }
    }
}

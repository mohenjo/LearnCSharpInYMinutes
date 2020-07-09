namespace Learning.CSharp
{
    // 인터페이스는 멤버의 구현 없이 시그니처 정보만 가집니다.
    interface IJumpable
    {
        void Jump(int meters); // 인터페이스의 모든 멤버는 암묵적으로 public입니다.
    }
}

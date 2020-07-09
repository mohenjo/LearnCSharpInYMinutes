using System;

namespace Learning.CSharp
{
    // 아래의 내용은 C# 6 버전에서 추가된 내용입니다. 
    class GlassBall : IJumpable, IBreakable
    {
        // 자동속성(autoproperty)에도 초기값을 지정할 수 있습니다.
        public int Damage { get; private set; } = 0;

        // getter-only 속성에 대한 초기값 지정
        public string Name { get; } = "Glass ball";

        // 아래 getter-only 속성은 생성자에서 초기화됩니다.
        public string GenieName { get; }

        public GlassBall(string genieName = null)
        {
            GenieName = genieName;
        }

        public void Jump(int meters)
        {
            if (meters < 0)
            {
                // nameof(): 변수, 형식 또는 멤버의 이름을 문자열 상수로 가져옵니다. (컴파일 시간에 계산됩니다)
                // nameof(x) == "x"
                throw new ArgumentException("Cannot jump negative amount!", nameof(meters));
            }
            Damage += meters;
        }

        // 속성은 블록 본문뿐 아니라, 식 본문 방식으로 쓸 수도 있습니다.
        public bool Broken => Damage > 100;

        // 메소드도 식 본문 방식으로 작성 가능합니다.
        public override string ToString() => $"{Name}. Damage taken: {Damage}"; // 문자열 보간

        public string SummonGenie()
            // 널 조건 연산자
            // x?.y에 대해, x가 null인 경우 y는 평가하지 않고 바로 null을 반환합니다.
            => GenieName?.ToUpper();
    }
}

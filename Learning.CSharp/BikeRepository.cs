// 아래의 네임스페이스는 .NET Framework 클래스 라이브러리가 아닙니다.
// 이 네임스페이스를 사용하기 위해서는 NuGet 패키지 관리자에서 EntityFramework를 설치해야 합니다.
using System.Data.Entity;

namespace Learning.CSharp
{
    /// <summary>
    /// LinqToSql DB로의 연결을 위한 예제입니다.
    /// 다음 링크를 확인하세요. https://docs.microsoft.com/ef/ef6/modeling/code-first/workflows/new-database
    /// </summary>
    public class BikeRepository : DbContext
    {
        public BikeRepository() : base()
        {
        }

        public DbSet<Bicycle> Bikes { get; set; }
    }
}

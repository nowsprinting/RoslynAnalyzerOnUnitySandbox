using System.Diagnostics.CodeAnalysis;

namespace NotReferenced
{
    /// <summary>
    /// asmdefあり、Assembly Definition References指定なし
    /// どのアナライザも入らないはず
    ///
    /// Unity: FooBarBaz のみ有効
    /// Rider: HogeFuga, FooBar, FooBarBaz が有効
    /// VS:
    /// VSCode:
    /// </summary>
    public class NotReferenced
    {
    }

    // ReSharper disable once HogeFugaAnalyzer
    public class NotReferencedDisable // Riderでも`ReSharper disable`コメントは効かない
    {
    }

    [SuppressMessage("ReSharper", "HogeFugaAnalyzer")]
    [SuppressMessage("ReSharper", "FooBarAnalyzer")]
    [SuppressMessage("ReSharper", "FooBarBazAnalyzer")]
    public class NotReferencedSuppress // SuppressMessageアトリビュートは有効
    {
    }
}

using System.Diagnostics.CodeAnalysis;

namespace Referenced
{
    /// <summary>
    /// asmdefあり、Assembly Definition Referencesに `NoAutoReferenced` を指定
    /// FooBarAnalyzerだけ入るはず
    ///
    /// Unity: FooBarBaz のみ有効
    /// Rider: HogeFuga, FooBar, FooBarBaz が有効
    /// VS:
    /// VSCode:
    /// </summary>
    public class Referenced
    {
    }

    // ReSharper disable once FooBarAnalyzer
    public class ReferencedDisable // Riderでも`ReSharper disable`コメントは効かない
    {
    }

    [SuppressMessage("ReSharper", "HogeFugaAnalyzer")]
    [SuppressMessage("ReSharper", "FooBarAnalyzer")]
    [SuppressMessage("ReSharper", "FooBarBazAnalyzer")]
    public class Referenced4Suppress // SuppressMessageアトリビュートは有効
    {
    }
}

using System.Diagnostics.CodeAnalysis;

namespace NotBelongAssembly
{
    /// <summary>
    /// asmdefなし。Assembly-CSharpに属する
    /// `Auto Referenced` がonであるHogeFugaAnalyzer, HogeFugaAnalyzer.CodeFixesが入るはず
    /// `Auto Referenced` がoffであるFooBarAnalyzerは入らないはず
    /// Assembly-CSharpに属するFooBarBazAnalyzerは入るはず
    /// 
    /// Unity: FooBarBaz のみ有効
    /// Rider: HogeFuga, FooBar, FooBarBaz が有効
    /// VS:
    /// VSCode:
    /// </summary>
    public class NotBelongAssembly
    {
    }

    // ReSharper disable once HogeFugaAnalyzer
    public class NotBelongAssemblyDisable // `ReSharper disable`コメントは効かない
    {
    }

    [SuppressMessage("ReSharper", "HogeFugaAnalyzer")]
    [SuppressMessage("ReSharper", "FooBarAnalyzer")]
    [SuppressMessage("ReSharper", "FooBarBazAnalyzer")]
    public class NotBelongAssemblySuppress // SuppressMessageアトリビュートは有効
    {
    }
}

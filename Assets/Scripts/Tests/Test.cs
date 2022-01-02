using NUnit.Framework;

/// <summary>
/// Only specified "NUnit.Analyzers" by "Assembly Definition References" in asmdef.
/// The following analyzers are expected. NUnit.Analyzers and not under asmdef.
/// - NUnit.Analyzers
/// - AnalyzerWithoutAsmdef
/// - AnalyzerInEmbeddedPackage
/// - AnalyzerInLocalPackage
/// - AnalyzerInPackage
/// 
/// Unity 2020.2.0f1 (does not work NUnit.Analyzers)
/// - AnalyzerWithoutAsmdef
/// - AnalyzerInEmbeddedPackage
/// - AnalyzerInLocalPackage
/// - AnalyzerInPackage
///
/// Unity 2021.2.0f1 (correct)
/// - NUnit.Analyzers
/// - AnalyzerWithoutAsmdef
/// - AnalyzerInEmbeddedPackage
/// - AnalyzerInLocalPackage
/// - AnalyzerInPackage
/// </summary>
public class Test
{
    [TestCase(true)]
    public void SampleTest(int numberValue)
    {
        Assert.That(numberValue, Is.EqualTo(1));
    }
}

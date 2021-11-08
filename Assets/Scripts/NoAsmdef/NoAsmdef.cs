/// <summary>
/// No assembly definition file (asmdef). This script is included Assembly-CSharp.
/// The following analyzers are expected. Not under asmdef.
/// - AnalyzerWithoutAsmdef
/// - AnalyzerInEmbeddedPackage
/// - AnalyzerInLocalPackage
/// - AnalyzerInPackage
/// 
/// Unity 2020.2.0f1 (correct)
/// - AnalyzerWithoutAsmdef
/// - AnalyzerInEmbeddedPackage
/// - AnalyzerInLocalPackage
/// - AnalyzerInPackage
/// 
/// Rider Editor package v3.0.7 (only work analyzers under Assets folder and embedded package. asmdef dependencies are not considered)
/// - AnalyzerWithoutAsmdef
/// - AnalyzerWithAsmdef
/// - AnalyzerInEmbeddedPackage
/// - AnalyzerInEmbeddedPackageWithAsmdef
/// </summary>
public class NoAsmdef
{
}

/// <summary>
/// Specified 4 analyzers under the asmdef by "Assembly Definition References" in asmdef.
/// The following analyzers are expected. All analyzers in this project.
/// - AnalyzerWithoutAsmdef
/// - AnalyzerWithAsmdef
/// - AnalyzerInEmbeddedPackage
/// - AnalyzerInEmbeddedPackageWithAsmdef
/// - AnalyzerInLocalPackage
/// - AnalyzerInLocalPackageWithAsmdef
/// - AnalyzerInPackage
/// - AnalyzerInPackageWithAsmdef
/// 
/// Unity 2020.2.0f1 (does not work analyzers under Packages and asmdef)
/// - AnalyzerWithoutAsmdef
/// - AnalyzerWithAsmdef
/// - AnalyzerInEmbeddedPackage
/// - AnalyzerInLocalPackage
/// - AnalyzerInPackage
///
/// Unity 2020.3.4f1 (correct)
/// - AnalyzerWithoutAsmdef
/// - AnalyzerWithAsmdef
/// - AnalyzerInEmbeddedPackage
/// - AnalyzerInEmbeddedPackageWithAsmdef
/// - AnalyzerInLocalPackage
/// - AnalyzerInLocalPackageWithAsmdef
/// - AnalyzerInPackage
/// - AnalyzerInPackageWithAsmdef
/// 
/// Rider Editor package v3.0.7 (only work analyzers under Assets folder and embedded package. asmdef dependencies are not considered)
/// - AnalyzerWithoutAsmdef
/// - AnalyzerWithAsmdef
/// - AnalyzerInEmbeddedPackage
/// - AnalyzerInEmbeddedPackageWithAsmdef
/// </summary>
public class SpecifyReferences
{
}

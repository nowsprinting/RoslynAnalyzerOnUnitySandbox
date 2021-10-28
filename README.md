# RoslynAnalyzerOnUnitySandbox


## Project Structures


### Roslyn Analyzers in project

Both warn when type name contains lowercase letters.


#### AnalyzerWithoutAsmdef

This analyzer in Assets folder.

#### AnalyzerWithAsmdef

This analyzer in Assets folder, and under asmdef.

#### AnalyzerInEmbeddedPackage

This analyzer in embedded package.

#### AnalyzerInEmbeddedPackageWithAsmdef

This analyzer in embedded package, and under asmdef.

#### AnalyzerInLocalPackage

This analyzer in local package.

#### AnalyzerInLocalPackageWithAsmdef

This analyzer in local package, and under asmdef.

#### AnalyzerInPackage

This [analyzer in UPM package](https://github.com/nowsprinting/analyzer-in-package) from Git URL.

#### AnalyzerInPackageWithAsmdef

This [analyzer in UPM package](https://github.com/nowsprinting/analyzer-in-package) from Git URL, and under asmdef.


### Analyzer target scripts

#### NoAsmdef

asmdefのないスクリプト（Assembly-CSharpに含まれる）。
asmdef下にないアナライザ4つ（AnalyzerWithoutAsmdef, AnalyzerInEmbeddedPackage, AnalyzerInLocalPackage, AnalyzerInPackage）の診断対象になるはず。

#### NoReferences

asmdefはあるが、Assembly Definition Referencesに指定のないスクリプト。
asmdef下にないアナライザ4つ（AnalyzerWithoutAsmdef, AnalyzerInEmbeddedPackage, AnalyzerInLocalPackage, AnalyzerInPackage）の診断対象になるはず。

#### SpecifiedReferences

asmdefはあり、Assembly Definition ReferencesにWithAsmdefアナライザ4つを指定したスクリプト。
8アナライザ全ての診断対象になるはず。



## 検証結果

### Unity 2020.2.0f1

* NoAsmdef, NoReferences については想定通りの振る舞い
* SpecifiedReferences では、Assets下のWithAsmdefアナライザは有効だったが、Packages下のWithAsmdefアナライザ3つは無効

つまり
* Packages (Embedded package, Local package, Git URL, and maybe UPM registry) 下かつasmdef下のアナライザは無効

### Rider Editor package v3.0.6

* すべてのパターンで（つまりasmdefに関係なく）、Assets下およびEmbeddedPackageのアナライザが全て有効

つまり
* asmdefの依存関係を見ていない
* Embedded package以外のPackages (Local package, Git URL, and maybe UPM registry) 下に置いたアナライザは無効（asmdefに関係なく）

### Visual Studio Code Editor package v1.2.3 (Unity 2020 verified)

TBD

### Visual Studio Editor package v2.0.7 (Unity 2020 verified)

TBD

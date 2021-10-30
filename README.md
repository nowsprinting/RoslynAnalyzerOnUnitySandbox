# RoslynAnalyzerOnUnitySandbox



## Project Structures

### Roslyn Analyzers in project

Analyzers warn when type name contains lowercase letters.

* **AnalyzerWithoutAsmdef** : Analyzer in Assets folder.
* **AnalyzerWithAsmdef** : Analyzer in Assets folder, and under asmdef.
* **AnalyzerInEmbeddedPackage** : Analyzer in embedded package.
* **AnalyzerInEmbeddedPackageWithAsmdef** : Analyzer in embedded package, and under asmdef.
* **AnalyzerInLocalPackage** : Analyzer in local package.
* **AnalyzerInLocalPackageWithAsmdef** : Analyzer in local package, and under asmdef.
* **AnalyzerInPackage** : [This analyzer](https://github.com/nowsprinting/analyzer-in-package) from Git URL.
* **AnalyzerInPackageWithAsmdef** : [This analyzer](https://github.com/nowsprinting/analyzer-in-package) from Git URL, and under asmdef.


### Analyzer target scripts

#### NoAsmdef

No assembly definition file (asmdef). This script is included Assembly-CSharp.
The following analyzers are expected. Not under asmdef.

* AnalyzerWithoutAsmdef
* AnalyzerInEmbeddedPackage
* AnalyzerInLocalPackage
* AnalyzerInPackage

#### NoReferences

Not specified "Assembly Definition References" in asmdef.
The following analyzers are expected. Not under asmdef.

* AnalyzerWithoutAsmdef
* AnalyzerInEmbeddedPackage
* AnalyzerInLocalPackage
* AnalyzerInPackage

#### SpecifiedReferences

Specified 4 analyzers under the asmdef by "Assembly Definition References" in asmdef.
The following analyzers are expected. All analyzers in this project.

* AnalyzerWithoutAsmdef
* AnalyzerWithAsmdef
* AnalyzerInEmbeddedPackage
* AnalyzerInEmbeddedPackageWithAsmdef
* AnalyzerInLocalPackage
* AnalyzerInLocalPackageWithAsmdef
* AnalyzerInPackage
* AnalyzerInPackageWithAsmdef



## Results of a verification

### Unity

#### Unity 2020.2.0f1

* **NoAsmdef** and **NoReferences** are correct behaviour
* In **SpecifiedReferences**, does not work analyzers under Packages and asmdef

#### Unity 2020.3.4f1

* Fix **SpecifiedReferences** problem (but no mentioned in release notes and issue tracker)


### JetBrains Rider

#### Rider Editor package v3.0.7

For all patterns,

* Analyzers under Assets folder and embedded packages are working (asmdef has no effect)
* Analyzers under local packages and from Git URL (and maybe from UPM registry) are not work


### Visual Studio Code

#### Visual Studio Code Editor package v1.2.3 (Unity 2020 verified)

Same as Rider Editor package v3.0.6


### Visual Studio

#### Visual Studio Editor package v2.0.7 (Unity 2020 verified)

TBD

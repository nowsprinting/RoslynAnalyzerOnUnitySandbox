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
* **NUnit.Analyzers** : [This analyzer](https://github.com/nunit/nunit.analyzers) in Assets folder, and under asmdef.


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

#### Tests

Only specified "NUnit.Analyzers" by "Assembly Definition References" in asmdef.
The following analyzers are expected. NUnit.Analyzers and not under asmdef.

* AnalyzerWithoutAsmdef
* AnalyzerInEmbeddedPackage
* AnalyzerInLocalPackage
* AnalyzerInPackage
* NUnit.Analyzers



## Results of a verification

### Unity

#### [Unity 2020.2.0f1](https://unity3d.com/unity/whats-new/2020.2.0)

* **NoAsmdef** and **NoReferences** are correct behaviour
* In **SpecifiedReferences**, does not work analyzers under Packages and asmdef
* In **Tests**, does not work NUnit.Analyzers (reason is unknown)

#### [Unity 2020.3.4f1](https://unity3d.com/unity/whats-new/2020.3.4)

* Fixed **SpecifiedReferences** problem (but no mentioned in release notes and issue tracker)

#### [Unity 2021.2.0f1](https://unity3d.com/unity/whats-new/2021.2.0)

* Fixed **Tests** problem (reason is unknown)


### [JetBrains Rider Editor](https://docs.unity3d.com/Packages/com.unity.ide.rider@latest)

#### v3.0.7

For all patterns,

* Analyzers under Assets folder and embedded packages are working (asmdef has no effect)
* Analyzers under local packages and from Git URL (and maybe from UPM registry) are not work

#### v3.0.9

Fixed. However, required [Unity 2020.3.6f1](https://unity3d.com/unity/whats-new/2020.3.6) or later or [Unity 2021.1.2f1](https://unity3d.com/unity/whats-new/2021.1.2) or later.


### [Code Editor Package for Visual Studio Code](https://docs.unity3d.com/Packages/com.unity.ide.vscode@latest)

#### v1.2.3

For all patterns,

* Analyzers under Assets folder and embedded packages are working (asmdef has no effect)
* Analyzers under local packages and from Git URL (and maybe from UPM registry) are not work

#### v1.2.4

Fixed. However, required [Unity 2020.3.6f1](https://unity3d.com/unity/whats-new/2020.3.6) or later or [Unity 2021.1.2f1](https://unity3d.com/unity/whats-new/2021.1.2) or later.


### [Code Editor Package for Visual Studio](https://docs.unity3d.com/Packages/com.unity.ide.visualstudio@latest)

#### v2.0.7

Only Microsoft.Unity.Analyzers.dll applies.

#### v2.0.11

Fixed. However, required [Unity 2020.3.6f1](https://unity3d.com/unity/whats-new/2020.3.6) or later or [Unity 2021.1.2f1](https://unity3d.com/unity/whats-new/2021.1.2) or later.
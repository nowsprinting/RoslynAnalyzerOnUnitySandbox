# RoslynAnalyzerOnUnitySandbox


## 構成

### Packages/Roslyn Analyzers

#### AutoReferenced

- asmdefの `Auto Referenced` がon
- HogeFugaAnalyzer
- HogeFugaAnalyzer.CodeFixes

#### NoAutoReferenced

- asmdefの `Auto Referenced` がoff
- FooBarAnalyzer

### Assets/Scripts

#### NotBelongAssembly

- asmdefなし。Assembly-CSharpに属する
- `Auto Referenced` がonであるHogeFugaAnalyzer, HogeFugaAnalyzer.CodeFixesが入るはず
- `Auto Referenced` がoffであるFooBarAnalyzerは入らないはず

#### NotReferenced

- asmdefあり、Assembly Definition References指定なし
- どのアナライザも入らないはず

#### Referenced

- asmdefあり、Assembly Definition Referencesに `NoAutoReferenced` を指定
- FooBarAnalyzerだけ入るはず


## 検証結果

### Rider Editor package v2.0.7 (Unity 2020 verified)

- Assembly-CSharp.csproj : 3つとも`<Analyzer>`として記述
- NotReferenced.csproj : 3つとも`<Analyzer>`として記述
- Referenced.csproj : 3つとも`<Analyzer>`として記述

### Rider Editor package v3.0.5

- Assembly-CSharp.csproj : 3つとも`<Analyzer>`として記述
- NotReferenced.csproj : 3つとも`<Analyzer>`として記述
- Referenced.csproj : 3つとも`<Analyzer>`として記述

### Visual Studio Code Editor package v1.2.3 (Unity 2020 verified)



### Visual Studio Editor package v2.0.7 (Unity 2020 verified)

# RoslynAnalyzerOnUnitySandbox


## 構成

### Packages/Roslyn Analyzers 下のアナライザ

#### AutoReferenced

- asmdefの `Auto Referenced` がon
- HogeFugaAnalyzer.dll
- HogeFugaAnalyzer.CodeFixes.dll

#### NoAutoReferenced

- asmdefの `Auto Referenced` がoff
- FooBarAnalyzer.dll
    - デフォルトの重大度は `Warning` だが、.sln.DotSettingsで `Suggestion` に設定


### Assets 下のアナライザ

- asmdefなし。Assembly-CSharpに属する
- FooBarBazAnalyzer.dll
    - デフォルトの重大度は `Warning` だが、Default.rulesetで `Error` に設定


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

### Unity 2020.3.0f1

- Assets下のFooBarBazAnalyzer.dllのみ、全ソースに対して有効
- Packages下のDLLsはすべて無効
- Rulesetファイル有効

#### Packages下のDLLをAssets下に移動した場合 (branch: reference_in_assets)

- Assembly-CSharp.csproj : FooBarBazAnalyzer（asmdefなし）と HogeFugaAnalyzer（asmdefの `Auto Referenced` がon）が有効
- NotReferenced.csproj : FooBarBazAnalyzer（asmdefなし）のみ有効
- Referenced.csproj : FooBarBazAnalyzer（asmdefなし）と FooBarAnalyzer（asmdefの `Auto Referenced` がoffだが `References` に追加しているため）が有効

→ Unityマニュアル [Roslyn analyzers and ruleset files](https://docs.unity3d.com/2020.2/Documentation/Manual/roslyn-analyzers.html) の "Analyzer scope" に書かれている仕様通り

### Rider Editor package v2.0.7 (Unity 2020 verified)

- Assembly-CSharp.csproj : 4つとも`<Analyzer>`として記述
- NotReferenced.csproj : 4つとも`<Analyzer>`として記述
- Referenced.csproj : 4つとも`<Analyzer>`として記述
- .rulesetファイルはインポートされない。.DotSettingsファイルは有効

### Rider Editor package v3.0.5

- Assembly-CSharp.csproj : 4つとも`<Analyzer>`として記述
- NotReferenced.csproj : 4つとも`<Analyzer>`として記述
- Referenced.csproj : 4つとも`<Analyzer>`として記述
- .rulesetファイルはインポートされない。.DotSettingsファイルは有効

### Visual Studio Code Editor package v1.2.3 (Unity 2020 verified)

- Assembly-CSharp.csproj : 4つとも`<Analyzer>`として記述
- NotReferenced.csproj : 4つとも`<Analyzer>`として記述
- Referenced.csproj : 4つとも`<Analyzer>`として記述

### Visual Studio Editor package v2.0.7 (Unity 2020 verified)

- Assembly-CSharp.csproj :すべて無効。ただしMicrosoft.Unity.Analyzers.dllが`<Analyzer>`として記述
- NotReferenced.csproj : 同上
- Referenced.csproj : 同上

※Packages下のDLLをAssets下に移動するケースは試していない。FooBarBazAnalyzer.dllすら適用されていないため無駄と判断。

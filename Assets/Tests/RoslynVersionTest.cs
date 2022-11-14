// Copyright (c) 2021-2022 Koji Hasegawa

using System;
using System.IO;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

namespace Tests
{
    public class RoslynVersionTest
    {
        private const string AssemblyName = "Microsoft.CodeAnalysis.CSharp";

#if !UNITY_2021_2_OR_LATER
        private const string ExpectedVersion = "3.5.0.0";
#else
        private const string ExpectedVersion = "3.9.0.0";
#endif

        [Test, Order(0), Description("Not contain Microsoft.CodeAnalysis.CSharp before load assembly by path")]
        public void GetAssemblies_notContain()
        {
            var assembly = AppDomain.CurrentDomain
                .GetAssemblies()
                .Select(x => x.GetName())
                .FirstOrDefault(x => x.Name == AssemblyName);

            Assert.That(assembly, Is.Null);
        }

        [Test, Order(1)]
        public void MicrosoftCodeAnalysisCSharpVersion_matches()
        {
            var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var path = Path.Combine(baseDirectory, $"Unity.app/Contents/Tools/Roslyn/{AssemblyName}.dll");
            var assembly = Assembly.LoadFrom(path).GetName();

            Assert.That(assembly, Is.Not.Null);
            Assert.That(assembly.Version.ToString(), Is.EqualTo(ExpectedVersion));
        }
    }
}

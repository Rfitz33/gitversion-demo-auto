using System;

class Program {
    static void Main() {
        // ThisAssembly.GitVersion.FullSemVer is injected by GitVersion.MsBuild
        Console.WriteLine(GitVersionInformation.FullSemVer);
    }
}

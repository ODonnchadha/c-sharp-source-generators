## Developing Source Generators in C# 10 by Thomas Claudius Huber

- OVERVIEW:
  - C# Source Generators can analyze your code and generate new C# code while your project is compiling. 
  - This course will teach you how to build and use C# Source Generators in your .NET applications.

- UNDERSTANDING C# SOURCE GENERATORS:
  - Generates source code. Why?
  - T4 templates. (Text and C3 mixed to generate files.) Third party tools. Custom scripts.
    - Compile for assembly.
    - Run the code that generates additional code for the project.
    - Add the generated code to the project.
    - Compile the project again with the generated code.
  - C# source generators introduced in .NET 5.
    - T4 templates. Get the assembly as input and run after compilation.
    - C# source generators. Get source code as input and run as part of the compilation.
      ```csharp
        [GenerateToString()]
        public partial class Person
        {
          public string? FirstName { get; set; }
          public string? LastName { get; set; }
        }
        public partial class Person
        {
          public override string ToString()
          {
            return $"FirstName: {FirstName}; LastName: {LastName}";
          }
        }
      ```
  - NOTE: reflection is executed a runtime. Performance disadvantage.

- SETTING UP A C# SOURCE GENERATOR:
  - C# source generator:
    - Create a .NET Standard 2.0 class library project.
    - Add the required NuGet packages:
      - Microsoft.CodeAnalysis.Analyzers
      - Microsoft.CodeAnalysis.CSharp
    - .NET 6.0 or later. Do not use ISourceGenerator. Use IIncrementalGenerator.
      ```xml
        <ItemGroup>
            <ProjectReference Include="..\WiredBrainCoffee.Generators\WiredBrainCoffee.Generators.csproj" OutputItemType="Analyzer" ReferenceOutputAssembly="false" />
        </ItemGroup>
      ```

- GENERATING SOURCE FILES:
  - Syntax tree of a C# file. [View -> Other Windows -> Syntax Visualizer.] (Via .NET Compiler Platform SDK.)
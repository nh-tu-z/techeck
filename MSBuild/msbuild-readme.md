### MSBuild

#### Structure of *.csproj file
Main components:
- `<Project>`: Used to identify the project file's XML schema and specify entry points for the build process.
- `<PropertyGroup>`: Used to define build configuration properties.
- `<ItemGroup>`: Used to add inputs, such as source code files, into the build system.
- `<Target>`: Used to specify and execute build operations.

1. **<PropertyGroup>**

Properties represent the necessary information required to build a project. Such properties are defined within a PropertyGroup element. These properties consist of key-value pairs where the property element name defines the property key and the content of the element defines the property value.

Reference: (PropertyGroup)[https://learn.microsoft.com/en-us/previous-versions/visualstudio/visual-studio-2015/msbuild/propertygroup-element-msbuild?view=vs-2015&redirectedfrom=MSDN]

a. **TargetFramework**

Reference: https://learn.microsoft.com/en-us/dotnet/standard/frameworks

b. **Nullable**

Allow using nullable reference type in the source code

Reference https://learn.microsoft.com/en-us/dotnet/csharp/tutorials/nullable-reference-types

c. **Implicit Using**

Reference: https://learn.microsoft.com/en-us/dotnet/core/project-sdk/msbuild-props#implicitusings

2. **Target** 

T.B.D

3. **Item Group**

A project file defines inputs to the build process which are actually different file types. In MSBuild nomenclature, these inputs are represented by Item elements and are defined within an ItemGroup element. 

Common MSbuild project item reference: https://learn.microsoft.com/en-us/visualstudio/msbuild/common-msbuild-project-items?view=vs-2019#none

a. **PackageReference**

b. **ProjectReference**

c. **None**

- None is the item type, indicating that the file is not part of the build process.

- Child property <CopyToOutputDirectory> specifies how the files should be copied to the output directory. In this case, it's set to "PreserveNewest," which means the files will be copied to the output directory if they are newer than the copies already there.

- Using wildcard to choose multi files in MSBuild file

Reference 1: https://learn.microsoft.com/en-us/visualstudio/msbuild/how-to-select-the-files-to-build?view=vs-2022
Reference 2: https://learn.microsoft.com/en-us/visualstudio/msbuild/msbuild-items?view=vs-2022#use-wildcards-to-specify-items

4. Using placeholder with <Link> child property - %()
T.B.D

Macro definition - reference - https://learn.microsoft.com/en-us/cpp/build/reference/common-macros-for-build-commands-and-properties?view=msvc-170

Reference solution for handling case: copy multi files to specific destination - https://github.com/dotnet/msbuild/issues/2795

REFERENCE:

1. MSBuild https://learn.microsoft.com/en-us/visualstudio/msbuild/msbuild?view=vs-2022
1. vstest - https://github.com/microsoft/vstest
this is .NET test framework "Microsoft.NET.Test.Sdk"

2. I found that the docs usually mention MSTest, NUnit, xUnit? what is different between them?
there are 3 common test runner of dotnet. xUnit is the modernest one.

3. dotnet test command line
- can use ```dotnet test --verbosity [level]``` to troubleshoot the issue

4. Dotnet test overview
- https://learn.microsoft.com/en-us/dotnet/core/testing/

5. Sample project and unit test for it
- https://learn.microsoft.com/en-us/dotnet/core/tutorials/testing-with-cli 

6. Run selected unit test
- https://learn.microsoft.com/en-us/dotnet/core/testing/selective-unit-tests?pivots=mstest

7. UT with code coverage
- https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-code-coverage?tabs=windows 

8. We can test published output with dotnet vstest. In other words, we can test the code after build (.dll file)
- https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-code-coverage?tabs=windows 

9. What is packages.lock.json? 
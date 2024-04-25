[![.NET](https://github.com/deanagan/practice-csharp/actions/workflows/dotnet.yml/badge.svg)](https://github.com/deanagan/practice-csharp/actions/workflows/dotnet.yml)
[![Build Status](https://travis-ci.com/deanagan/practice-csharp.svg?branch=master)](https://travis-ci.com/github/deanagan/practice-csharp)
# Practicing C#

# To build and test
I've added some batch files for windows setup.
To run API: `dotnet run -p Api` <br>
To just build: `dotnet build` <br>
To run test: `dotnet test` <br>
To run test verbose + logging: `dotnet test -l:"console;verbosity=detailed"`


To run a specific test, do: dotnet test --filter FullyQualifiedName~MyNamespace.MyTestClass.MyTest
Example:
`dotnet test --filter lib.test.PermutationGeneratorTest`

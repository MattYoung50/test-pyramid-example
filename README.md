# Description
You can run this application just from the console given you've downloaded the [.NET SDK 7.0](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) following the usage section of this README or you can run it with [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) which will download the SDK for you.

# Contents
1. `TestPyramidExample` - an application we'd like to test that sends a UDP packet whenever a console button is input, exits if Enter pressed
2. `UnitTests` - An Unit Test project to test individual classes in TestPyramidExample
3. `IntegrationTests` - An Integration Test project to test different features/behaviors of TestPyramidExample
4. `E2ETests` - An end-to-end test project to test critical paths/features of TestPyramidExample

# Usage 
### Running TestPyramidExample
```console
    $ cd TestPyramidExample
    $ dotnet run
```
### Running all tests
```console
    $ dotnet test
```

# References
- [The Test Pyramid](https://medium.com/creditas-tech/the-test-pyramid-ac7bf8bb418e)

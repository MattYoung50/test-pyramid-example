namespace TestPyramidExample
{
    public interface ITestPyramidExampleAppDependencies
    {
        ILogger Logger { get; }
        IConsoleReader ConsoleReader { get; }
        IUdpSocket UdpSocket { get; }
        IEnvironmentProvider EnvironmentProvider { get; }
        TimestampProvider TimestampProvider { get; }
    }
}
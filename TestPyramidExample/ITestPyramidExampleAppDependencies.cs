namespace TestPyramidExample
{
    public interface ITestPyramidExampleAppDependencies
    {
        ILogger Logger { get; }
        IKeyReader KeyReader { get; }
        IUdpSocket UdpSocket { get; }
        IEnvironmentProvider EnvironmentProvider { get; }
        TimestampProvider TimestampProvider { get; }
    }
}
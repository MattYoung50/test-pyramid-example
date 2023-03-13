namespace TestPyramidExample
{
    public interface ITestPyramidExampleAppDependencies
    {
        ILogger Logger { get; }
        IKeyReader KeyReader { get; }
        IUdpSocket UdpSocket { get; }
        TimestampProvider TimestampProvider { get; }
    }
}
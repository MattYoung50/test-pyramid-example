using TestPyramidExample;

ManualResetEvent _quitEvent = new ManualResetEvent(false);
Console.CancelKeyPress += (sender, eArgs) => {
    _quitEvent.Set();
    eArgs.Cancel = true;
};

var dependencies = new TestPyramidExampleAppDependencies();
var testPyramidExample = new TestPyramidExampleApp(dependencies);

_quitEvent.WaitOne();

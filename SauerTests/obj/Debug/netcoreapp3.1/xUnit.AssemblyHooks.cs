using System.CodeDom.Compiler;

[assembly: global::Xunit.TestFramework("TechTalk.SpecFlow.xUnit.SpecFlowPlugin.XunitTestFrameworkWithAssemblyFixture", "TechTalk.SpecFlow.xUnit.SpecFlowPlugin")]
[assembly: global::TechTalk.SpecFlow.xUnit.SpecFlowPlugin.AssemblyFixture(typeof(global::SauerTests_XUnitAssemblyFixture))]

[GeneratedCode("SpecFlow", "3.1.97")]
public class SauerTests_XUnitAssemblyFixture : global::System.IDisposable
{
    private readonly global::System.Reflection.Assembly _currentAssembly;

    public SauerTests_XUnitAssemblyFixture()
    {
        _currentAssembly = typeof(SauerTests_XUnitAssemblyFixture).Assembly;
        global::TechTalk.SpecFlow.TestRunnerManager.OnTestRunStart(_currentAssembly);
    }

    public void Dispose()
    {
        global::TechTalk.SpecFlow.TestRunnerManager.OnTestRunEnd(_currentAssembly);
    }
}

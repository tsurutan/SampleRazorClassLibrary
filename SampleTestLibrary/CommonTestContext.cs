using Bunit;
using Xunit;

namespace SampleTestLibrary;

public class CommonTestContext: TestContext
{
    public string Message { get; set; } = "Hello, World!";
    public void AssertHelloWorld()
    {
        Assert.Equal("Hello, World!", Message);
    }
}
namespace Project1.Tests;

public class EchoerTests
{
    [Test]
    public void EchoerReturnsString()
    {
        var sut = new Echoer();

        var theValue = "Hello!";
        var result = sut.Echo(theValue);

        Assert.That(result, Is.EqualTo(theValue));
    }

    [Test]
    public void EchoerReturnsFoobar()
    {
        var sut = new Echoer();

        var theValue = "Hello!";
        var result = sut.Echo(theValue);

        Assert.That(result, Is.EqualTo("foobar"));
    }
}

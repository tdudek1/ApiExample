using Xunit;
using ApiExample;

namespace ApiExample.Tests;

public class UnitTest1
{
    [Fact]
    public void When0CThen32F()
    {
        var wf = new WeatherForecast();
        wf.TemperatureC = 0;

        Assert.Equal(32,wf.TemperatureF);
    }

    [Fact]
    public void When40BelowCThen39BelowF()
    {
        var wf = new WeatherForecast();

        wf.TemperatureC = -40;

        Assert.Equal(-39,wf.TemperatureF);
    }

    [Theory]
    [InlineData(3)]
    [InlineData(5)]
    [InlineData(7)]
    public void IsOdd(int value)
    {
        Assert.True(value % 2 == 1);
    }

}
using Xunit;

namespace TestProject1;

public class Tests
{
    [Fact]
    public void Test1()
    {
        double expected = 0.2;
        
        Assert.AreEqual(expected, FlightTime(1));
    }
    
    [Fact]
    public void Test2()
    {
        double expected = 0.4;
        
        Assert.AreEqual(expected, FlightTime(2));
    }

    public double FlightTime(float startSpeed)
    {
        return Math.Round(2 * startSpeed / 9.8, 1);
    }
}
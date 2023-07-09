using Src.Services;

namespace Tests;

public class MyMathTest
{
    [Fact]
    public void Add_TwoNumbers_ReturnsCorrectAddtion()
    {
        // Arrange
        var myMath = new MyMath();
        int x = 1, y = 2;
        int expected = 3;
        
        // Act
        var actual = myMath.Add(x, y);
        
        //Assert
        Assert.Equal(expected, actual);
    }
}
using BusCompany.Core;
using Xunit;

namespace BusCompany.Tests;

public class PriceCalculatorTests
{
    [Fact]
    public void CalculatePrice_ShouldReturnInitialFee_WhenDistanceIsZero()
    {
        //Arrange
        int distance = 0;
        
        //Act
        int result = PriceCalculator.CalculatePrice(distance);
        
        //Assert
        Assert.Equal(2500, result);
    }

    [Fact]
    public void CalculatePrice_ShouldIncludeDistanceFee_WhenDistanceIsBelow100Km()
    {
        //Arrange
        int distance = 50;
        
        //Act
        int result = PriceCalculator.CalculatePrice(distance);
        
        //Assert
        Assert.Equal(2500 + 50 * 10, result);
    }

    [Fact]
    public void CalculatePrice_ShouldIncludeReducedRate_WhenDistanceIsBetween100And500Km()
    {
        //Arrange
        int distance = 200;
        
        //Act
        int result = PriceCalculator.CalculatePrice(distance);
        
        //Assert
        Assert.Equal(2500 + 100 * 10 + 100 * 8, result);
    }

    [Fact]
    public void CalculatePrice_ShouldIncludeLowestRate_WhenDistanceIsAbove500km()
    {
        //Arrange
        int distance = 600;
        //Act
        int result = PriceCalculator.CalculatePrice(distance);
        //Assert
        Assert.Equal(2500 + 100 * 10 + 400 * 8 + 100 * 6, result);
    }
}
using Coins.Objects;
using System;
using Xunit;


namespace Coins
{
    public class ChangeCalculatorTest
    {
      // It can accept a price and an amount tendered
      [Fact]
      public void CreateChangeCalculator_AcceptPriceAndAmountTendered_DisplayPriceAndAmountTendered()
      {
        // Arrange
        int testPrice = 10;
        int testTendered = 20;

        // Act
        ChangeCalculator newChangeCalculator = new ChangeCalculator(testPrice, testTendered);
        int resultPrice = newChangeCalculator.GetPrice();
        int resultTendered = newChangeCalculator.GetTendered();

        // Assert
        Assert.Equal(10, resultPrice);
        Assert.Equal(20, resultTendered);
      }

      //It can calculate change based on price and amount submitted
      [Fact]
      public void CreateChangeCalculator_CalculateChangePriceAmountSubmitted_DisplayChangeOwed()
      {
        // Arrange
        int testPrice = 10;
        int testTendered = 30;
        ChangeCalculator newChangeCalculator = new ChangeCalculator(testPrice, testTendered);
        int resultPrice = newChangeCalculator.GetPrice();
        int resultTendered = newChangeCalculator.GetTendered();

        // Act
        int myResult = newChangeCalculator.ChangePrice(resultPrice, resultTendered);

        // Assert
        Assert.Equal(20, myResult);
      }

      //It can calculate the fewest number of coins required to make up the change returned
      [Fact]
      public void CalculateCoins_FewestCoinsReturned_true()
      {
        // Arrange
        int testPrice = 200;
        int testTendered = 299;
        ChangeCalculator newChangeCalculator = new ChangeCalculator(testPrice, testTendered);
        int testChange = newChangeCalculator.ChangePrice(testPrice, testTendered);
        int testQuarters = 4;
        int testPennies = 0;

        // Act
        string resultPennies = newChangeCalculator.CalculateCoins(testChange);

        // Assert
        Console.WriteLine(resultPennies);
        Assert.Equal(testPennies, resultPennies);



      }
    }
}

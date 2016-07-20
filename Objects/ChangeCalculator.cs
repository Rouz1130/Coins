using System;
using System.Collections.Generic;

namespace Coins.Objects
{
  // A class to calculate change due to a customer
  public class ChangeCalculator
  {
    // properties
    private int _price;
    private int _tendered;
    private int _change;
    private int[] _coinArray = new int[4];
    private int[] _changeArray = new int[4];

    // constructors, getters, setters
    public ChangeCalculator(int price, int tendered)
    {
      _price = price;
      _tendered = tendered;
    }

    public int GetPrice()
    {
      return _price;
    }

    public int GetTendered()
    {
      return _tendered;
    }

    public int ChangePrice(int price, int tendered)
    {
      // caclculate change value
      _change = tendered - price;
      // return change value
      return _change;
    }

    // a method to calculate fewest number of coins for change returned
    public string CalculateCoins(int change)
    {
      int remainderForQuarters = 0;
      int remainderForDimes = 0;
      int remainderForNickels = 0;
      int remainderForPennies = 0;
      string myResult;
      // populate coin array with quarter, dime, nickel, penny values
      _coinArray[0]=25;
      _coinArray[1]=10;
      _coinArray[2]=5;
      _coinArray[3]=1;
      // cycle through the change until change = 0
      for(int i = 0; i < 4; i++)
      {
        _changeArray[0] = change/_coinArray[0];
        remainderForDimes = change % _coinArray[0];
        _changeArray[1] = remainderForDimes/_coinArray[1];
        remainderForNickels = remainderForDimes % _coinArray[1];
        _changeArray[2] = remainderForDimes/_coinArray[2];
        remainderForPennies = remainderForNickels % _coinArray[2];
        _changeArray[3] = remainderForNickels/_coinArray[3];
        myResult = _changeArray[0].ToString();
      }

      return myResult;
    }

  }
}

﻿using System;

namespace TipCalculator
{
  class Program
  {
    static void Main(string[] args)
    {
      // Welcome the User
      Console.WriteLine("Welcome User!!!!");
      // Ask how much the bill
      Console.WriteLine("How much was your meal");
      var total = Console.ReadLine();
      // calculate 18% 
      var tip = Double.Parse(total) * 0.18;
      // var jordan = Convert.ToDouble(total) * 0.18;
      var grandTotal = tip + double.Parse(total);
      // add the tip to the total
      // display the result
      Console.WriteLine("Your total was " + total);
      Console.WriteLine("The 18% tip is " + tip);
      Console.WriteLine("Grandtotal is " + grandTotal);

    }
  }
}

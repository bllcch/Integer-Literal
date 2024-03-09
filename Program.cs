using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[]args)
    {
     
      int decimalNumber = 56;
      Console.WriteLine("Decimal Integer Literal:" +decimalNumber);
      
      int binaryNumber = 0b111000;
      Console.WriteLine("Binary Integer Literal:" +binaryNumber);
      
      int octalNumber = 056;
      Console.WriteLine("Octal Integer Literal:" +octalNumber);
      
      int hexadecimalNumber = 0x38;
      Console.WriteLine("Hexadecimal Integer Literal:" +hexadecimalNumber);
      
      int bigNumber = 56;
      Console.WriteLine("Integer with Underscore:" +bigNumber);
      
      uint unsignedNumber = 56u;
      Console.WriteLine("Unsigned Integer Literal:" +unsignedNumber);
      
      long longValue = 56L;
      Console.WriteLine("Long Literal:" +longValue);
      
      ulong unsignedLong = 56UL;
      Console.WriteLine("Unsigned Long Integer Literal:" +unsignedLong);

      if (decimalNumber == 56 &&
                binaryNumber == 56 &&
                octalNumber == 56 &&
                hexadecimalNumber == 56 &&
                bigNumber == 56 &&
                unsignedNumber == 56 &&
                longValue == 56 &&
                unsignedLong == 56)
                {
                    Console.WriteLine("All representatives are correct");
                }

        else if (decimalNumber < 56 ||
                    binaryNumber < 56 ||
                    octalNumber < 56 ||
                    hexadecimalNumber < 56 ||
                    bigNumber < 56 ||
                    unsignedNumber < 56 ||
                    longValue < 56 ||
                    unsignedLong < 56)
                {
                    Console.WriteLine("All representatives are correct");
                }
                
        else
        {
            Console.WriteLine("All representatives are incorrect");
        }
    
    }
  }
}

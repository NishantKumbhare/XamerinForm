using System;
namespace FormSample
{
    public class BinaryOperation
    {
        public BinaryOperation()
        {
        }

        public static int Add(int value1, int value2)
        {
            // Iterate till there is no carry  
            while (value2 != 0)
            {
                // carry now contains common set bits of x and y
                int carry = value1 & value2;
                // Sum of bits of x and y where at least one of the bits is not set
                value1 = value1 ^ value2;

                // Carry is shifted by one so that adding it to x gives the required sum
                value2 = carry << 1;
            }
            return value1;
        }
    }
}

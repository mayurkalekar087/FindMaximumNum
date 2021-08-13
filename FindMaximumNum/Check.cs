using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumNum
{
    class Check
    {
        public static int MaximumInteger(int firstValue, int secondValue, int thirdValue)
        {

            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            else if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            else if (thirdValue.CompareTo(secondValue) > 0 && thirdValue.CompareTo(firstValue) > 0)
            {
                return thirdValue;
            }
            throw new Exception("firstValue,secondValue,Thirdvalue are same !");

        }
        public static float MaximumFloat(float firstValue, float secondValue, float thirdValue)
        {

            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            else if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            else if (thirdValue.CompareTo(secondValue) > 0 && thirdValue.CompareTo(firstValue) > 0)
            {
                return thirdValue;
            }
            throw new Exception("firstValue,secondValue,ThirdValue are same!");
        }
    }
}

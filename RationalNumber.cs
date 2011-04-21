using System;
using System.Collections.Generic;
using System.Text;

namespace RationalNumber
{
    public class RationalNumber
    {
        private int numerator, denominator;
       public RationalNumber(int x,int y)
        {
            for (int i = 2; i <= y; i++)
            { if((x%i==0)&&(y%i==0))
            {
                x = x / i;
                y = y / i;
            }
            }
            Numerator = x;
            Denominator = y;
        }
      public   RationalNumber() : this(1, 1) { }
      public  RationalNumber(RationalNumber r1) : this(r1.Numerator, r1.Denominator) { }
      public  RationalNumber(int num) : this(num, 1) { }
       public int Numerator
        {get
            {
                return numerator;
        }
            set
            {
            numerator = value;
            }
        }
     public   int Denominator
        {
            get
            {
                return denominator;
            }
            set
            {
                if (value > 0)
                { denominator = value; }
            }
        }
        public static RationalNumber operator +(RationalNumber num1, RationalNumber num2)
        {
            if (num1.Denominator != num2.Denominator)
            {
                int x, y;
                y = num1.Denominator * num2.Denominator;
                x = num1.Numerator * num2.Denominator + num2.Numerator * num1.Denominator;
                return new RationalNumber(x, y);
            }
            else
            {
                return new RationalNumber(num1.Numerator+num2.Numerator,num1.Denominator);
            }
        }
        public static RationalNumber operator -(RationalNumber num1, RationalNumber num2)
        {
            if (num1.Denominator != num2.Denominator)
            {
                int x, y;
                y = num1.Denominator * num2.Denominator;
                if (num1.Numerator > num2.Numerator)
                    {
                    x = num1.Numerator * num2.Denominator - num2.Numerator * num1.Denominator;
                     }
                else
                    { 
                    x = num2.Numerator * num1.Denominator -num1.Numerator * num2.Denominator  ;
                    }
                return new RationalNumber(x, y);
            }
            else
            {
                if (num1.Numerator > num2.Numerator)
                {
                    return new RationalNumber(num1.Numerator - num2.Numerator, num1.Denominator);
                }
                else
                {
                    return new RationalNumber(num2.Numerator - num1.Numerator, num1.Denominator);
                }
            }
        }
        public static RationalNumber operator *(RationalNumber num1, RationalNumber num2)
        { 
            return new RationalNumber(num1.Numerator * num2.Numerator, num1.Denominator * num2.Denominator);
        }
        public static RationalNumber operator /(RationalNumber num1, RationalNumber num2)
        {
            return new RationalNumber(num1.Numerator*num2.Denominator,num2.Numerator*num1.Denominator);
        }
        public override bool Equals(object obj)
        {
            if ((obj == null) || (GetType() != obj.GetType()))
                return false;
            else
            {
                RationalNumber r1 = (RationalNumber)obj;
                return (Numerator == r1.Numerator) && (Denominator == r1.Denominator);
            }
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
        public override string ToString()
        {
            return string.Format(Numerator+"/"+Denominator);
        }
        public static implicit operator RationalNumber(int r1)
        {
            return new RationalNumber(r1, 1);
        }
        public static explicit operator int(RationalNumber r1)
        {
            return r1.Numerator / r1.Denominator;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CalCulator_win
{
    class BigMath
    {
        public _math Sum(_math firstNumber, _math SecoundNumber)
        {
            _math Result = new _math();
            Result.big_One = (firstNumber.big_One + SecoundNumber.big_One);
            Result.big_two = (firstNumber.big_two + SecoundNumber.big_two);
            List<int> lenghts = new List<int>();
            lenghts.Add(firstNumber.big_two.ToString().Length);
            lenghts.Add(SecoundNumber.big_two.ToString().Length);
            if (Result.big_two.ToString().Length > lenghts.Max())
            {
                Result.big_One++;
                Result.big_two = Result.big_two - BigInteger.Parse( Math.Pow(10, lenghts.Max()).ToString());
            }

            return Result;
        }
        public _math minus(_math firstNumber, _math SecoundNumber)
        {
            _math Result = new _math();
            Result.big_One = (firstNumber.big_One + SecoundNumber.big_One);
            Result.big_two = (firstNumber.big_two + SecoundNumber.big_two);





            return Result;
        }
        public _math multiplication (_math firstNumber, _math SecoundNumber)
        {
            _math Result = new _math();
            Result.big_One = (firstNumber.big_One + SecoundNumber.big_One);
            Result.big_two = (firstNumber.big_two + SecoundNumber.big_two);

            return Result;
        }
        public _math Division(_math firstNumber, _math SecoundNumber)
        {
            _math Result = new _math();
            Result.big_One = (firstNumber.big_One + SecoundNumber.big_One);
            Result.big_two = (firstNumber.big_two + SecoundNumber.big_two);

            return Result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CalCulator_win
{
    class _math
    {
        public BigInteger big_One = new BigInteger();
        public BigInteger big_two = new BigInteger();

        public string _jaam
        {
            set
            {
                if (value.Contains('.'))
                {
                    string[] num = value.Split('.');
                    big_One = BigInteger.Parse(num[0]);
                    big_two = BigInteger.Parse(num[1]);
                }
                else
                {
                    big_One = BigInteger.Parse(value);
                    big_two = 0;
                }
            }
            get
            {

                return big_One.ToString()+"."+big_two.ToString();
            }
        }
    }
}
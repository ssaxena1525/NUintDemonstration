﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitDemonstration
    //Shivang Saxena
{
    public static class Triangle
    {
        public static string ValidTriangle(int firstAngle, int secondAngle, int
        thirdAngle)
        {
            string result;
            if ((firstAngle + secondAngle + thirdAngle) == 180)
            {
                result = "The triangle is valid.";
            }
            else
            {
                result = "The triangle is NOT valid.";
            }
            return result;
        }
    }
}

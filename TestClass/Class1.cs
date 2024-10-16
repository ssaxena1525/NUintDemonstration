using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitDemonstration;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace TestClass
{
    [TestFixture]
    //Shivang Saxena
    public class TriangleTest
    {
        [Test]

        public void ValidTriangle_Input60and60and60_OutputVaildTriangle()
        {
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 60;

            string expected = "The triangle is valid.";

            string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            ClassicAssert.AreEqual(expected, actual);

        }
    }
}

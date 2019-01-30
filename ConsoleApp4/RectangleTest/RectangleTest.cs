using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ConsoleApp4;

namespace RectangleTest
{
    [TestFixture]
     class RectangleTest
    {
        [Test]
        public void GetLength_input8_expectLengthEquals8()
        {
            //Arrange
            int l = 8;
            int w = 6;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int length = testRectangle.GetLength();

            //Assert
            Assert.AreEqual(length, l);
        }

        [Test]
        public void SetLength_input7_expectLengthSets7()
        {
            //Arrange
            int l = 8;
            int w = 6;
            int L = 7;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int length = testRectangle.SetLength(L);

            //Assert
            Assert.AreEqual(length, L);
        }

        [Test]
        public void GetWidth_input6_expectWidthEquals6()
        {
            //Arrange
            int l = 8;
            int w = 6;
            
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int width = testRectangle.GetWidth();

            //Assert
            Assert.AreEqual(width, w);
        }

        [Test]
        public void SetWidth_input3_expectLengthSets3()
        {
            //Arrange
            int l = 8;
            int w = 6;
            int W = 3;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int length = testRectangle.SetWidth(W);

            //Assert
            Assert.AreEqual(length, W);
        }
        [Test]
        public void GetPerimeter_inputlength8andwidth6_expectPerimeterEquals28()
        {
            //Arrange
            int l = 8;
            int w = 6;
            int P = (w * 2) + (l * 2);
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int Perimeter = testRectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(Perimeter, P);
        }
        [Test]
        public void GetArea_inputlength8andwidth6_expectAreaEquals48()
        
        {
            //Arrange
            int l = 8;
            int w = 6;
            int A = l * w ;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int Area = testRectangle.GetArea();

            //Assert
            Assert.AreEqual(Area, A);
        }
    }
}

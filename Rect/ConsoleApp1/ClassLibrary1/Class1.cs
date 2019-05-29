using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rectangleabc;
using NUnit.Framework;

namespace rectabc
{
    [TestFixture]
    class testcase
    {
        [Test]
        public void GetLength_input3_expectedLengthEquals3()
        {
            //Arrange
            int l = 4;
            int w = 6;
            Rect testrectangle = new Rect(l, w);

            //Act
            int length = testrectangle.GetLength();

            //Assert
            Assert.AreEqual(l, length);
        }

        [Test]
        public void SetLength_input5_expectedLengthEquals5()
        {
            //Arrange
            int l = 1;
            int w = 5;
            Rect testrectangle = new Rect(l, w);

            //Act
            int length = testrectangle.SetLength(l);

            //Assert
            Assert.AreEqual(l, length);
        }



        [Test]
        public void GetWidth_input4_expectedLengthEquals4()
        {
            //Arrange
            int l = 6;
            int w = 3;
            Rect testrectangle = new Rect(l, w);

            //Act
            int width = testrectangle.GetWidth();

            //Assert
            Assert.AreEqual(w, width);
        }

        [Test]
        public void SetWidth_input2_expectedLengthEquals2()
        {
            //Arrange
            int l = 7;
            int w = 6;
            Rect testrectangle = new Rect(l, w);

            //Act
            int width = testrectangle.SetWidth(w);

            //Assert
            Assert.AreEqual(w, width);
        }

        [Test]
        public void GetPerimeter_inputlength4andwidth4_expectedperimeterEquals16()
        {
            //Arrange
            int l = 4;
            int w = 4;

            int expectedResult = (l * 2) + (w * 2);

            Rect testrectangle = new Rect(l, w);

            //Act
            int actualResult = testrectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetArea_inputlength4andwidth9_expectedAreaEquals36()
        {
            //Arrange
            int l = 4;
            int w = 9;

            int expectedResult = (l * w);

            Rect testrectangle = new Rect(l, w);

            //Act
            int actualResult = testrectangle.GetArea();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}


using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;
using System.Collections.Generic;
using System;

namespace ShapeTracker.Tests
{
    [TestClass]

    public class RectangleTests
    {
        [TestMethod]
        public void RectangleConstructor_CreateARectangleObject_Rectangle()
        {
            Rectangle newRectangle = new Rectangle(4, 3);
        // any necessary logic to prep for test; instantiating new classes, etc.
        // we can also use the arrange, act, assert organization in any test. 
        Assert.AreEqual(typeof(Rectangle), newRectangle.GetType());
        }

        [TestMethod]
        public void GetSideA_ReturnSide1_Int()
        {
            Rectangle newRectangle = new Rectangle(4, 3);
            Assert.AreEqual(4, newRectangle.SidesA);
        }

         [TestMethod]
        public void GetSideB_ReturnSide1_Int()
        {
            Rectangle newRectangle = new Rectangle(4, 3);
            Assert.AreEqual(3, newRectangle.SidesB);
        }


    }


}
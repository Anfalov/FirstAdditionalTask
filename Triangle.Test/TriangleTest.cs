using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Triangle.Test
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Side can't be less than 0.")]
        public void ConstructBySides_Should_ThrowException_When_SideIsNegative()
        {
            Triangle.ConstructBySides(-5, 4, 8);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Sum of two sides can't be less than third side.")]
        public void ConstructBySides_Should_ThrowException_When_TheRuleOfTriangleIsNotPerformed()
        {
            Triangle.ConstructBySides(2, 4, 8);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Angle must be between 0 and 180 degrees.")]
        public void ConstructByAngleAnd2Sides_Should_ThrowException_When_AngleIsGreaterThen180Degrees()
        {
            Triangle.ConstructByAngleAnd2Sides(200, 3, 6);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Angle must be between 0 and 180 degrees.")]
        public void ConstructByAngleAnd2Sides_Should_ThrowException_When_AngleIsNegative()
        {
            Triangle.ConstructByAngleAnd2Sides(-60, 3, 6);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Side can't be less than 0.")]
        public void ConstructByAngleAnd2Sides_Should_ThrowException_When_SideIsNegative()
        {
            Triangle.ConstructByAngleAnd2Sides(60, -3, 6);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Side can't be less than 0.")]
        public void ConstructBySideAnd2Angles_Should_ThrowException_When_SideIsNegative()
        {
            Triangle.ConstructBySideAnd2Angles(-5, 60, 30);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Angle can't be less than 0.")]
        public void ConstructBySideAnd2Angles_Should_ThrowException_When_AngleIsNegative()
        {
            Triangle.ConstructBySideAnd2Angles(5, -60, 30);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Sum of two angles can't be more than 180 degrees.")]
        public void ConstructBySideAnd2Angles_Should_ThrowException_When_SumOfAnglesIsGreaterThen180Degrees()
        {
            Triangle.ConstructBySideAnd2Angles(5, 150, 40);
        }
        [TestMethod]
        public void GetArea_Should_ReturnCorrectAnswer_When_TriangleIsCreated_By_Sides()
        {
            double sideA = 87;
            double sideB = 87;
            double sideC = 126;
            Triangle triangle = Triangle.ConstructBySides(sideA, sideB, sideC);
            double area = triangle.GetArea();
            Assert.AreEqual(3780, area, 1e-10);
        }
        [TestMethod]
        public void GetArea_Should_ReturnCorrectAnswer_When_TriangleIsCreated_By_AngleAnd2Sides()
        {
            double angle = 30;
            double sideA = 40;
            double sideB = 20;
            Triangle triangle = Triangle.ConstructByAngleAnd2Sides(angle, sideA, sideB);
            double area = triangle.GetArea();
            Assert.AreEqual(200, area, 1e-10);
        }
        [TestMethod]
        public void GetArea_Should_ReturnCorrectAnswer_When_TriangleIsCreated_By_SideAnd2Angles()
        {
            double side = 24;
            double angleA = 150;
            double angleB = 15;
            Triangle triangle = Triangle.ConstructBySideAnd2Angles(side, angleA, angleB);
            double area = triangle.GetArea();
            Assert.AreEqual(144, area, 1e-10);
        }
    }
}

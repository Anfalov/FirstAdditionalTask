using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Triangle.Test
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Side can't be less than 0.")]
        public void Sides_Should_ThrowException_When_SideIsNegative()
        {
            Triangle.Sides(-5, 4, 8);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Sum of two sides can't be less than third side.")]
        public void Sides_Should_ThrowException_When_TheRuleOfTriangleIsNotPerformed()
        {
            Triangle.Sides(2, 4, 8);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Angle must be between 0 and 180 degrees.")]
        public void AngleAnd2Sides_Should_ThrowException_When_AngleIsGreaterThen180Degrees()
        {
            Triangle.AngleAnd2Sides(200, 3, 6);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Angle must be between 0 and 180 degrees.")]
        public void AngleAnd2Sides_Should_ThrowException_When_AngleIsNegative()
        {
            Triangle.AngleAnd2Sides(-60, 3, 6);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Side can't be less than 0.")]
        public void AngleAnd2Sides_Should_ThrowException_When_SideIsNegative()
        {
            Triangle.AngleAnd2Sides(60, -3, 6);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Side can't be less than 0.")]
        public void SideAnd2Angles_Should_ThrowException_When_SideIsNegative()
        {
            Triangle.SideAnd2Angles(-5, 60, 30);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Angle can't be less than 0.")]
        public void SideAnd2Angles_Should_ThrowException_When_AngleIsNegative()
        {
            Triangle.SideAnd2Angles(5, -60, 30);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Sum of two angles can't be more than 180 degrees.")]
        public void SideAnd2Angles_Should_ThrowException_When_SumOfAnglesIsGreaterThen180Degrees()
        {
            Triangle.SideAnd2Angles(5, 150, 40);
        }
        [TestMethod]
        public void Area_When_TriangleIsCreated_By_Sides()
        {
            double sideA = 87, sideB = 87, sideC = 126;
            Triangle triangle = Triangle.Sides(sideA, sideB, sideC);
            double area = triangle.Area();
            Assert.AreEqual(3780, area, 1e-10);
        }
        [TestMethod]
        public void Area_When_TriangleIsCreated_By_AngleAnd2Sides()
        {
            double angle = 30, sideA = 40, sideB = 20;
            Triangle triangle = Triangle.AngleAnd2Sides(angle, sideA, sideB);
            double area = triangle.Area();
            Assert.AreEqual(200, area, 1e-10);
        }
        [TestMethod]
        public void Area_When_TriangleIsCreated_By_SideAnd2Angles()
        {
            double side = 24, angleA = 150, angleB = 15;
            Triangle triangle = Triangle.SideAnd2Angles(side, angleA, angleB);
            double area = triangle.Area();
            Assert.AreEqual(144, area, 1e-10);
        }
    }
}

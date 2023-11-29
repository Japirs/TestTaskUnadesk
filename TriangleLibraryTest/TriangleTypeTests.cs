using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleLibrary; 

namespace TriangleLibrary.Tests
{
[TestClass]
public class TriangleTypeTests
{
    [TestMethod]
    public void GetTriangleType_RightTriangle_ReturnsRight()
    {
        // Arrange
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;

        // Act
        var result = TriangleType.GetTriangleType(sideA, sideB, sideC);

        // Assert
        Assert.AreEqual(TriangleType.TriangleTypeEnum.Right, result);
    }

    [TestMethod]
    public void GetTriangleType_ObtuseTriangle_ReturnsObtuse()
    {
        // Arrange
        double sideA = 3;
        double sideB = 4;
        double sideC = 6;

        // Act
        var result = TriangleType.GetTriangleType(sideA, sideB, sideC);

        // Assert
        Assert.AreEqual(TriangleType.TriangleTypeEnum.Obtuse, result);
    }

    [TestMethod]
    public void GetTriangleType_AcuteTriangle_ReturnsAcute()
    {
        
        // Arrange
        double sideA = 5;
        double sideB = 6;
        double sideC = 7;

        // Act
        var result = TriangleType.GetTriangleType(sideA, sideB, sideC);

        // Assert
        Assert.AreEqual(TriangleType.TriangleTypeEnum.Acute, result);
    }

    [TestMethod]
    public void GetTriangleType_EquilateralTriangle_ReturnsAcute()
    {
        // Arrange
        double sideA = 5;
        double sideB = 5;
        double sideC = 5;

        // Act
        var result = TriangleType.GetTriangleType(sideA, sideB, sideC);

        // Assert
        Assert.AreEqual(TriangleType.TriangleTypeEnum.Acute, result);
    }

    [TestMethod]
    public void GetTriangleType_InvalidTriangle_ThrowsException()
    {
        // Arrange
        double sideA = 1;
        double sideB = 2;
        double sideC = 3;

        // Act and Assert
        Assert.ThrowsException<System.ArgumentException>(() => TriangleType.GetTriangleType(sideA, sideB, sideC));
    }

    [TestMethod]
    public void GetTriangleType_ZeroSide_ThrowsException()
    {
        // Arrange
        double sideA = 0;
        double sideB = 0;
        double sideC = 0;

        // Act and Assert
        Assert.ThrowsException<System.ArgumentException>(() => TriangleType.GetTriangleType(sideA, sideB, sideC));
    }
}
}
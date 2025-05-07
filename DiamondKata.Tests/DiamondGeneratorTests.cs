using DiamondKata.Abstractions;
using DiamondKata.Services;

namespace DiamondKata.Tests;

[TestFixture]
public sealed class DiamondGeneratorTests
{
    [Test]
    public void Generate_GivenLetterA_ReturnMatrixHaving1ColumnAnd1RowWithLetterA()
    {
        // Arrange
        IDiamondGenerator generator = new DiamondGenerator();
        char[,] expectedMatrix =
        {
            { 'A' }
        };

        // Act
        var result = generator.GenerateDiamondMatrix('A');

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.EqualTo(expectedMatrix));
            Assert.That(result.GetLength(0), Is.EqualTo(1));
            Assert.That(result.GetLength(1), Is.EqualTo(1));
        });
    }
}
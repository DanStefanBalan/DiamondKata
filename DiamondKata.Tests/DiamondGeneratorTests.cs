using DiamondKata.Abstractions;
using DiamondKata.Services;

namespace DiamondKata.Tests;

[TestFixture]
public sealed class DiamondGeneratorTests
{
    [Test]
    public void GenerateDiamondMatrix_GivenLetterA_ReturnMatrixHaving1ColumnAnd1RowWithLetterA()
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
    
    [TestCase('3')]
    [TestCase('!')]
    [TestCase('&')]
    [TestCase('>')]
    [TestCase('a')]
    [TestCase('t')]
    public void GenerateDiamondMatrix_GivenWrongInput_ThrowException(char input)
    {
        // Arrange
        IDiamondGenerator generator = new DiamondGenerator();
        
        // Act + Assert
        var ex = Assert.Throws<ArgumentException>(() => generator.GenerateDiamondMatrix('1'));
        Assert.That(ex.Message, Is.EqualTo("Input must be a letter from A-Z."));
    }
    
    [Test]
    public void GenerateDiamondMatrix_GivenLetterB_ReturnMatrixHaving3ColumnsAnd3RowWithLetterBInCenter()
    {
        // Arrange
        IDiamondGenerator generator = new DiamondGenerator();
        char[,] expectedMatrix =
        {
            { ' ', 'A', ' ' },
            { 'B', ' ', 'B' },
            { ' ', 'A', ' ' }
        };

        // Act
        var result = generator.GenerateDiamondMatrix('B');

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.EqualTo(expectedMatrix));
            Assert.That(result.GetLength(0), Is.EqualTo(3));
            Assert.That(result.GetLength(1), Is.EqualTo(3));
        });
    }
}
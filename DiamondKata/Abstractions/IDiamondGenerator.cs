namespace DiamondKata.Abstractions;

public interface IDiamondGenerator
{
    char[,] GenerateDiamondMatrix(char targetLetter);
}
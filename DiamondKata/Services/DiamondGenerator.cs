using DiamondKata.Abstractions;

namespace DiamondKata.Services;

public sealed class DiamondGenerator : IDiamondGenerator
{
    public char[,] GenerateDiamondMatrix(char targetLetter)
    {
        if (targetLetter is < 'A' or > 'Z')
        {
            throw new ArgumentException("Input must be a letter from A-Z.");
        }
        
        if (targetLetter == 'A')
        {
            return new char[,]
            {
                { 'A' }
            };
        }

        return new char[0,0];
    }
}
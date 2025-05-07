using DiamondKata.Abstractions;

namespace DiamondKata.Services;

public sealed class DiamondGenerator : IDiamondGenerator
{
    public char[,] GenerateDiamondMatrix(char targetLetter)
    {
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
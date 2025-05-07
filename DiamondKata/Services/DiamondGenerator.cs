using DiamondKata.Abstractions;

namespace DiamondKata.Services;

public sealed class DiamondGenerator : IDiamondGenerator
{
    public char[,] GenerateDiamondMatrix(char targetLetter)
    {
        ValidateInput(targetLetter);
        
        if (targetLetter == 'A')
        {
            return new[,]
            {
                { 'A' }
            };
        }

        return new char[0,0];
    }
    
    private static void ValidateInput(char targetLetter)
    {
        if (targetLetter is < 'A' or > 'Z')
        {
            throw new ArgumentException("Input must be a letter from A-Z.");
        }
    }
}
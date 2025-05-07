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
        
        var currentCharacter = 'A';
        var positionTracker = targetLetter - 'A'; 
        var halfDiamondHeight = positionTracker;
        var matrix = new char[positionTracker * 2 + 1, positionTracker * 2 + 1];

        for (var rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
        {
            for (var colIndex = 0; colIndex < matrix.GetLength(1); colIndex++)
            {
                if (colIndex == positionTracker || colIndex == matrix.GetLength(1) - positionTracker - 1)
                {
                    matrix[rowIndex, colIndex] = currentCharacter;
                }
                else
                {
                    matrix[rowIndex, colIndex] = ' ';
                }
            }

            if (rowIndex < halfDiamondHeight)
            {
                currentCharacter++;
                positionTracker--;
            }
            else
            {
                currentCharacter--;
                positionTracker++;
            }
        }

        return matrix;
    }
    
    private static void ValidateInput(char targetLetter)
    {
        if (targetLetter is < 'A' or > 'Z')
        {
            throw new ArgumentException("Input must be a letter from A-Z.");
        }
    }
}
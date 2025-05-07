using DiamondKata.Abstractions;

namespace DiamondKata.Services;

public sealed class DiamondGenerator : IDiamondGenerator
{
    public char[,] GenerateDiamondMatrix(char targetLetter)
    {
        ValidateInput(targetLetter);
        
        var size = GetMatrixSize(targetLetter);
        var matrix = InitializeMatrix(size);
        FillMatrix(matrix, targetLetter);

        return matrix;
    }
    
    private static void ValidateInput(char targetLetter)
    {
        if (targetLetter is < 'A' or > 'Z')
        {
            throw new ArgumentException("Input must be a letter from A-Z.");
        }
    }
    
    private static int GetMatrixSize(char targetLetter) => (targetLetter - 'A') * 2 + 1;
    
    private static char[,] InitializeMatrix(int size)
    {
        var matrix = new char[size, size];

        for (var rowIndex = 0; rowIndex < size; rowIndex++)
        {
            for (var colIndex = 0; colIndex < size; colIndex++)
            {
                matrix[rowIndex, colIndex] = ' ';
            }
        }

        return matrix;
    }

    private static void FillMatrix(char[,] matrix, char targetLetter)
    {
        var currentCharacter = 'A';
        var positionTracker = targetLetter - 'A'; 
        var halfDiamondHeight = positionTracker;

        for (var rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
        {
            matrix[rowIndex, positionTracker] = currentCharacter;
            matrix[rowIndex, matrix.GetLength(1) - positionTracker - 1] = currentCharacter;

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
    }
}
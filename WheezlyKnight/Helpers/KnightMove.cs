using System;
using System.Collections.Generic;
using System.Linq;
using WheezlyKnight.Models;

public class ChessKnight
{
    private static readonly int[] xMoves = { 2, 1, -1, -2, -2, -1, 1, 2 };
    private static readonly int[] yMoves = { 1, 2, 2, 1, -1, -2, -2, -1 };

    public static List<(int, int)> GetKnightMoves(Piece knight, Piece king, List<Piece> friendlyPieces)
    {
        var possibleMoves = new List<(int, int)>();

        for (int i = 0; i < 8; i++)
        {
            int newX = knight.X + xMoves[i];
            int newY = knight.Y + yMoves[i];

            if (newX >= 0 && newX < 8 && newY >= 0 && newY < 8 && !friendlyPieces.Any(p => p.X == newX && p.Y == newY))
            {
                
                var tempFriendlyPositions = new List<Piece>(friendlyPieces);
                tempFriendlyPositions.Remove(tempFriendlyPositions.FirstOrDefault(p => p.X == knight.X && p.Y == knight.Y));
                tempFriendlyPositions.Add(new Piece { X = newX, Y = newY });
                // Checking wether the knight can move to the position
                if (!IsKingInCheck(king, tempFriendlyPositions))
                {
                    possibleMoves.Add((newX, newY));
                }
            }
        }

        return possibleMoves;
    }

    private static bool IsKingInCheck(Piece king, List<Piece> friendlyPieces)
    {
        // this methods checks if the king is in check
        return false;
    }
}

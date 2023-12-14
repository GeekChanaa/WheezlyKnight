using NUnit.Framework;
using WheezlyKnight.Models;
using System.Collections.Generic;

namespace ChessKnightApp.Tests
{
    [TestFixture]
    public class ChessKnightTests
    {
        [Test]
        public void TestKnightWithAllPossiblePositions()
        {
            var knight = new Piece { X = 4, Y = 4 };
            var king = new Piece { X = 0, Y = 0 };
            var friendlyPieces = new List<Piece> { king };

            var moves = ChessKnight.GetKnightMoves(knight, king, friendlyPieces);
            Assert.AreEqual(8, moves.Count, "The Knight piece should have 8 possible moves");
        }

        [Test]
        public void TestKnightOnBoardEdge()
        {
            var knight = new Piece { X = 0, Y = 4 };
            var king = new Piece { X = 7, Y = 7 };
            var friendlyPieces = new List<Piece> { king };

            var moves = ChessKnight.GetKnightMoves(knight, king, friendlyPieces);
            Assert.IsTrue(moves.Count < 8); 
        }

        [Test]
        public void TestKnightOnFriendlyPieces()
        {
            var knight = new Piece { X = 3, Y = 3 };
            var king = new Piece { X = 0, Y = 0 };
            var friendlyPieces = new List<Piece>
            {
                king,
                new Piece { X = 5, Y = 4 }, 
                new Piece { X = 2, Y = 5 }  
            };

            var moves = ChessKnight.GetKnightMoves(knight, king, friendlyPieces);
            Assert.IsTrue(moves.Count < 8); 
        }

        // [Test]
        // public void TestKnightMovePutsKingInCheck()
        // This function requires more functionalities to be implemented

    }
}

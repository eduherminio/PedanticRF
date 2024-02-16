﻿using Pedantic;
using System.Text;

namespace Pedantic.UnitTests
{
    [TestClass]
    [TestCategory("UnitTests")]
    public class UciCommandTests
    {
        public TestContext? TestContext { get; set; }

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            Board.Initialize();
        }

        [TestMethod]
        public void DebugTest()
        {
            Assert.IsFalse(Engine.Debug);
            Program.ParseUciCommand("debug on");
            Assert.IsTrue(Engine.Debug);
            Program.ParseUciCommand("debug off");
            Assert.IsFalse(Engine.Debug);
        }

        [TestMethod]
        public void IsReadyTest()
        {
            using StringWriter sw = new();
            Console.SetOut(sw);
            Program.ParseUciCommand("isready");
            string expected = $"readyok{Environment.NewLine}";
            Assert.AreEqual(expected, sw.ToString());
        }

        [TestMethod]
        public void PositionTest()
        {
            Assert.AreEqual(Constants.FEN_START_POS, Engine.Board.ToFenString());
            Program.ParseUciCommand("position startpos moves e2e4 e7e5");
            Assert.AreEqual(Engine.Board.PieceBoard(SquareIndex.E4).Color, Color.White);
            Assert.AreEqual(Engine.Board.PieceBoard(SquareIndex.E4).Piece, Piece.Pawn);
            Assert.AreEqual(Engine.Board.PieceBoard(SquareIndex.E5).Color, Color.Black);
            Assert.AreEqual(Engine.Board.PieceBoard(SquareIndex.E5).Piece, Piece.Pawn);
        }

        [TestMethod]
        public void SetOptionTest()
        {
            Assert.AreEqual(2, UciOptions.PromotionDepth);
            Program.ParseUciCommand("setoption name UCI_T_QS_PromotionDepth value 3");
            Assert.AreEqual(3, UciOptions.PromotionDepth);
        }

        [TestMethod]
        public void GoFixedDepthTest()
        {
            Program.ParseUciCommand("uci");
            Program.ParseUciCommand("isready");
            Program.ParseUciCommand("ucinewgame");
            Program.ParseUciCommand("position startpos");
            Program.ParseUciCommand("go depth 8");
            Program.ParseUciCommand("wait");
        }

        [TestMethod]
        public void GoFixedNodesTest()
        {
            Program.ParseUciCommand("uci");
            Program.ParseUciCommand("isready");
            Program.ParseUciCommand("ucinewgame");
            Program.ParseUciCommand("position startpos");
            Program.ParseUciCommand("go nodes 1000000");
            Program.ParseUciCommand("wait");
        }

        [TestMethod]
        public void GoFixedTimeTest()
        {
            Program.ParseUciCommand("uci");
            Program.ParseUciCommand("isready");
            Program.ParseUciCommand("ucinewgame");
            Program.ParseUciCommand("position startpos");
            Program.ParseUciCommand("go movetime 5000");
            Program.ParseUciCommand("wait");
        }

        [TestMethod]
        public void GoTimeNoIncrementTest()
        {
            Program.ParseUciCommand("uci");
            Program.ParseUciCommand("isready");
            Program.ParseUciCommand("ucinewgame");
            Program.ParseUciCommand("position startpos");
            Program.ParseUciCommand("go wtime 15000 btime 15000");
            Program.ParseUciCommand("wait");
        }

        [TestMethod]
        public void GoTimeWithIncrementTest()
        {
            Program.ParseUciCommand("uci");
            Program.ParseUciCommand("isready");
            Program.ParseUciCommand("ucinewgame");
            Program.ParseUciCommand("position startpos");
            Program.ParseUciCommand("go wtime 15000 winc 100 btime 15000 binc 100");
            Program.ParseUciCommand("wait");
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissorsKata;

namespace RockPaperScissorsKataTest
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void Play_Given_PaperAndRock_PlayerWins()
        {
            //Arrange
            var game = CreateGame();
            var expected = "Player Wins";

            //Act
            var actual = game.Play(Move.Paper, Move.Rock);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Play_Given_PlayerPaperOpponentScissors_PlayerLoses()
        {
            //Arrange
            var game = CreateGame();
            var expected = "Player Loses";

            //Act
            var actual = game.Play(Move.Paper, Move.Scissors);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Play_Given_PlayerPaperOpponentPaper_Tie()
        {
            //Arrange
            var game = CreateGame();
            var expected = "Tie";

            //Act
            var actual = game.Play(Move.Paper, Move.Paper);

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Play_Given_PlayerRockOpponentScissors_PlayerWins()
        {
            //Arrange
            var game = CreateGame();
            var expected = "Player Wins";

            //Act
            var actual = game.Play(Move.Rock, Move.Scissors);

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Play_Given_PlayerRockOpponentPaper_PlayerLoses()
        {
            //Arrange
            var game = CreateGame();
            var expected = "Player Loses";

            //Act
            var actual = game.Play(Move.Rock, Move.Paper);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Play_Given_PlayerRockOpponentRock_Tie()
        {
            //Arrange
            var game = CreateGame();
            var expected = "Tie";

            //Act
            var actual = game.Play(Move.Rock, Move.Rock);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        private static Game CreateGame()
        {
            return new Game();
        }
    }
}

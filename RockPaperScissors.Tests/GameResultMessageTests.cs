using System;
using Xunit;
using Moq;

namespace RockPaperScissors.Tests
{
    public class GameResultMessageTests
    {
        [Theory]
        [InlineData(Choice.Invalid, Choice.Rock)]
        [InlineData(Choice.Rock, Choice.Invalid)]
        public void GetGameResultMessage_InvalidChoice_ThrowsArgumentException(Choice playerChoice, Choice compChoice)
        {
            var ex = Assert.Throws<ArgumentException>(() => Game.GetGameResultMessage(playerChoice, compChoice));
            Assert.Equal("Choice cannot be invalid", ex.Message);
        }

        [Theory]
        [InlineData(Choice.Rock, Choice.Rock, "It's a tie!")]
        [InlineData(Choice.Paper, Choice.Paper, "It's a tie!")]
        [InlineData(Choice.Scissors, Choice.Scissors, "It's a tie!")]
        [InlineData(Choice.Rock, Choice.Scissors, "You win!")]
        [InlineData(Choice.Paper, Choice.Rock, "You win!")]
        [InlineData(Choice.Scissors, Choice.Paper, "You win!")]
        [InlineData(Choice.Scissors, Choice.Rock, "Computer wins!")]
        [InlineData(Choice.Paper, Choice.Scissors, "Computer wins!")]
        [InlineData(Choice.Rock, Choice.Paper, "Computer wins!")]
        public void GetGameResultMessage_ValidChoice_ReturnsProperMessage(Choice playerChoice, Choice compChoice, string expected)
        {
            Assert.Equal(expected, Game.GetGameResultMessage(playerChoice, compChoice));
        }

    }
}

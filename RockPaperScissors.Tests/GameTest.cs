using RockPaperScissors;

namespace RockPaperScissors.Tests
{
    public class GameTest
    {
        [Fact]
        public void TestSettingPlayerChoice()
        {
            Assert.Equal(Choice.Rock, Game.GetPlayChoice("r"));
            Assert.Equal(Choice.Rock, Game.GetPlayChoice("rock"));

            Assert.Equal(Choice.Scissors, Game.GetPlayChoice("scissors"));
            Assert.Equal(Choice.Scissors, Game.GetPlayChoice("s"));

            Assert.Equal(Choice.Paper, Game.GetPlayChoice("paper"));
            Assert.Equal(Choice.Paper, Game.GetPlayChoice("p"));

            Assert.Equal(Choice.Invalid, Game.GetPlayChoice("blahh"));
        }
    }
}
using static RockPaperScissors.Game;

namespace RockPaperScissors.Tests
{
    public class GameTest
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(Tool.Rock, SetPlayChoice("r"));
            Assert.Equal(Tool.Rock, SetPlayChoice("rock"));

            Assert.Equal(Tool.Scissors, SetPlayChoice("scissors"));
            Assert.Equal(Tool.Scissors, SetPlayChoice("s"));

            Assert.Equal(Tool.Paper, SetPlayChoice("paper"));
            Assert.Equal(Tool.Paper, SetPlayChoice("p"));

            Assert.Equal(Tool.Invalid, SetPlayChoice("blahh"));
        }
    }
}
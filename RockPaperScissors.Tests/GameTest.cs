using static RockPaperScissors.Game;

namespace RockPaperScissors.Tests;

public class GameTest
{
    [Fact]
    public void TestSettingPlayerChoice()
    {
        Assert.Equal(Choice.Rock, GetPlayChoice("r"));
        Assert.Equal(Choice.Rock, GetPlayChoice("rock"));

        Assert.Equal(Choice.Scissors, GetPlayChoice("scissors"));
        Assert.Equal(Choice.Scissors, GetPlayChoice("s"));

        Assert.Equal(Choice.Paper, GetPlayChoice("paper"));
        Assert.Equal(Choice.Paper, GetPlayChoice("p"));

        Assert.Equal(Choice.Invalid, GetPlayChoice("blahh"));
    }
}
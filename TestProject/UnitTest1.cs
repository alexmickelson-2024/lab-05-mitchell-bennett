using FluentAssertions;

namespace TestProject;

public class UnitTest1
{
    [Fact]
    public void TopRow()
    {
        char[] b = ['x', 'x', 'x','d', 'e', 'f', 'g', 'h', 'i'];
        var ans = MainProgram.Program.HasWinner(b);

        ans.Should().BeTrue();
    }
    [Fact]
    public void MiddleRow()
    {
        char[] b = ['a', 'b', 'c','x', 'x', 'x', 'g', 'h', 'i'];
        var ans = MainProgram.Program.HasWinner(b);

        ans.Should().BeTrue();
    }
    [Fact]
    public void BottomRow()
    {
        char[] b = ['a', 'b', 'c','d', 'e', 'f', 'x', 'x', 'x'];
        var ans = MainProgram.Program.HasWinner(b);

        ans.Should().BeTrue();
    }
    [Fact]
    public void DiagonalOne()
    {
        char[] b = ['x', 'b', 'c','d', 'x', 'f', 'g', 'h', 'x'];
        var ans = MainProgram.Program.HasWinner(b);

        ans.Should().BeTrue();
    }
    [Fact]
    public void DiagonalTwo()
    {
        char[] b = ['a', 'b', 'x','d', 'x', 'f', 'x', 'h', 'i'];
        var ans = MainProgram.Program.HasWinner(b);

        ans.Should().BeTrue();
    }
    [Fact]
    public void LeftColumn()
    {
        char[] b = ['x', 'b', 'c','x', 'e', 'f', 'x', 'h', 'i'];
        var ans = MainProgram.Program.HasWinner(b);

        ans.Should().BeTrue();
    }
    [Fact]
    public void MiddleColumn()
    {
        char[] b = ['a', 'x', 'c','d', 'x', 'f', 'g', 'x', 'i'];
        var ans = MainProgram.Program.HasWinner(b);

        ans.Should().BeTrue();
    }
    [Fact]
    public void RightColumn()
    {
        char[] b = ['a', 'b', 'x','d', 'e', 'x', 'g', 'h', 'x'];
        var ans = MainProgram.Program.HasWinner(b);

        ans.Should().BeTrue();
    }
}
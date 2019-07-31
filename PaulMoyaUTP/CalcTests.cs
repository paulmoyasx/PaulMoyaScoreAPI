using System;
using Xunit;
using PaulMoyaLIB;

namespace PaulMoyaUTP
{
    public class CalcTests
    {
        [Theory]
        [InlineData("",-1)]
        [InlineData(null, -1)]
        [InlineData("0", 0)]
        [InlineData("{{<!>},{<!>},{<!>},{<a>}}", 5)]
        [InlineData("{{<a>},{<a>},{<a>},{<a>}}", 2)]
        [InlineData("{<a>,<a>,<a>,<a>}", 1)]
        [InlineData("{<{},{},{{}}>}", 1)]
        [InlineData("{{{},{},{{}}}}", 6)]
        [InlineData("{{},{}}", 3)]
        [InlineData("{{{}}}", 3)]
        [InlineData("{}", 1)]
        [InlineData("{{<a!>},{<a!>},{<a!>},{<ab>}}", 3)]
        [InlineData("{{< !!>},{<!!>},{<!!>},{<!!>}}", 9)]
        [InlineData("{{<ab>},{<ab>},{<ab>},{<ab>}}", 1)]
        [InlineData("{<a>,<a>,<a>,<a>}", -1)]
        [InlineData("{{{},{},{{}}}}", 16)]
        [InlineData("{{},{}}", 5)]
        [InlineData("{{{}}}", 6)]
        [InlineData("[Sorry]", 0)]
        [InlineData("(Thankyou)", 0)]

        public void CalculationTest(string str, int expected)
        {

            //arrange

            //act
            double actual = Calculator.Calculate(str);
            
            //assert
            Assert.Equal(expected, actual);

        }
    }
}

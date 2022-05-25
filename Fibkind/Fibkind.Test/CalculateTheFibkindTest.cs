using Fibkind.App;
using System;
using Xunit;

namespace Fibkind.Test
{
    public class CalculateTheFibkindTest
    {
        [Theory]
        [InlineData(50, 25, 2)]
        [InlineData(3332, 973, 1391)]
        [InlineData(2941, 862, 1246)]
        [InlineData(3177, 573, 2047)]
        [InlineData(1745, 645, 474)]

        public void BasicTestLengthSupUK(int n, int k, int expected)
        {
            //Arrange
            ICalculateTheFibkind calculateTheFibkind = new CalculateTheFibkind();

            //Act
            var actual = calculateTheFibkind.LengthSupUK(n, k);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(74626, 37128)]
        [InlineData(71749, 35692)]
        [InlineData(56890, 28281)]
        [InlineData(60441, 30054)]
        [InlineData(21361, 10581)]

        public void BasicTestComp(int n, long expected)
        {
            //Arrange
            ICalculateTheFibkind calculateTheFibkind = new CalculateTheFibkind();

            //Act
            var actual = calculateTheFibkind.Comp(n);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}

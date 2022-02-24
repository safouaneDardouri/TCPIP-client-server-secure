using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ServerApp
{
    internal class test
    {
        [Fact]
        public async Task testBidon()
        {
            // Arrange


            // Act
            var number = 1;

            // Assert
            number.Equals(Equals(1));
        }
    }
}

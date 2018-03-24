using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Calculadora;
using System.Collections;

namespace TestintegradoXnuit
{
    public class Test
    {
        ICalculadora _cal;
        
        [Theory]
        [InlineData(2,2,4)]
        [InlineData(4, 6, 10)]
        [InlineData(5, 20, 25)]
        public void SumaTest(int num1 , int num2, int resultado)
        {
            _cal = new Calculo();
            Assert.Equal(_cal.Suma(num1,num2),resultado);
        }

        public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[] { 8, 5, 3 },
            new object[] { 10, 6, 4 },
            new object[] { 15, 7, 8 },
        };
        [Theory]
        [MemberData(nameof(Data))]
        public void RestaTest(int num1, int num2, int resultado)
        {
            _cal = new Calculo();
            Assert.Equal(_cal.Resta(num1, num2), resultado);
        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(3, 5, 15)]
        [InlineData(6, 7, 42)]
        public void MultiplicacionTest(int num1, int num2, int resultado)
        {
            _cal = new Calculo();
            Assert.Equal(_cal.Multiplicacion(num1, num2), resultado);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(15, 3, 5)]
        [InlineData(9, 3, 3)]
        public void DivisionTest(int num1, int num2, int resultado)
        {
            _cal = new Calculo();
            Assert.Equal(_cal.Division(num1, num2), resultado);
        }

       


    }
}

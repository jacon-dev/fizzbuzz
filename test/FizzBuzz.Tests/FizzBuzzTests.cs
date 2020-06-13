using FizzBuzz;
using Xunit;

namespace FizzBuzzTests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void TestMultipleOfReturn()
        {
            var mathsHelper = new MathsHelper();
            var number1 = 3;
            var number2 = 4;
            var number3 = 5;
            var number4 = 15;

            var result1 = mathsHelper.MultipleOf3or5orBoth(number1);
            var result2 = mathsHelper.MultipleOf3or5orBoth(number2);
            var result3 = mathsHelper.MultipleOf3or5orBoth(number3);
            var result4 = mathsHelper.MultipleOf3or5orBoth(number4);

            Assert.Equal(3, result1);
            Assert.Equal(0, result2);
            Assert.Equal(5, result3);
            Assert.Equal(15, result4);
        }

        // [Fact]
        // public void TestMultipleOf3()
        // {
        //     var mathsHelper = new FizzBuzzMaths();
        //     var number1 = 3;
        //     var number2 = 5;

        //     var result1 = mathsHelper.MultipleOf3(number1);
        //     var result2 = mathsHelper.MultipleOf3(number2);

        //     Assert.True(result1);
        //     Assert.False(result2);
        // }

        // [Fact]
        // public void TestMultipleOf5()
        // {
        //     var mathsHelper = new FizzBuzzMaths();
        //     var number1 = 3;
        //     var number2 = 5;

        //     var result1 = mathsHelper.MultipleOf5(number1);
        //     var result2 = mathsHelper.MultipleOf5(number2);

        //     Assert.False(result1);
        //     Assert.True(result2);
        // }

        // [Fact]
        // public void TestMultipleOf3and5()
        // {
        //     var mathsHelper = new FizzBuzzMaths();
        //     var number1 = 3;
        //     var number2 = 5;
        //     var number3 = 15;

        //     var result1 = mathsHelper.MultipleOf3and5(number1);
        //     var result2 = mathsHelper.MultipleOf3and5(number2);
        //     var result3 = mathsHelper.MultipleOf3and5(number3);

        //     Assert.False(result1);
        //     Assert.False(result2);
        //     Assert.True(result3);
        // }
    }
}
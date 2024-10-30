using TestCalculater.TestData;
using Xunit.Abstractions;

namespace TestCalculater.Test
{
    public class CalculaterHelperTest
    {
        private readonly ITestOutputHelper _outputHelper;

        public CalculaterHelperTest(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        //this attr say this method is UnitTest
        //method dont have Argumnet
        [Fact]

        //[Fact(Skip = "For Test")]

        //For Category
        [Trait("UnitTest", "UnitTest")]
        public void sum()
        {
            CalculaterHelper helper = new CalculaterHelper();

            
            int a = 4;
            int b = 5;
            var result = helper.Sum(a, b);
            
            //this method check Method return Respones
            Assert.Equal(9, result);

            _outputHelper.WriteLine(result.ToString());

            //this method check Method Respones Type
            Assert.IsType<int>(result);

        }


        //this attr say this method is UnitTest
        //method have Argumnet
        [Theory]

        //Set method input Argument
        [InlineData(5, 4, 9)]

        public void InlineData_Sum(int x, int y, int expect)
        {
            CalculaterHelper helper = new CalculaterHelper();

            var result = helper.Sum(x, y);

            //this method check Method return Respones
            Assert.Equal(expect, result);

            //this method check Method Respones Type
            Assert.IsType<int>(result);

        }


        [Theory]

        [MemberData(nameof(DataForTest.GetData), MemberType = typeof(DataForTest))]
        public void MemberData_Sum(int x, int y, int expect)
        {
            CalculaterHelper helper = new CalculaterHelper();

            var result = helper.Sum(x, y);

            //this method check Method return Respones
            Assert.Equal(expect, result);

            //this method check Method Respones Type
            Assert.IsType<int>(result);

        }


        [Theory]
        [ClassData(typeof(MemberClassData))]
        public void ClassData_Sum(int x, int y, int expect)
        {
            CalculaterHelper helper = new CalculaterHelper();

            var result = helper.Sum(x, y);

            //this method check Method return Respones
            Assert.Equal(expect, result);

            //this method check Method Respones Type
            Assert.IsType<int>(result);

        }



    }
}
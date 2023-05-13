using MyCalcLib;


namespace MyCalcTests
{
    public class UnitTest1
    {
        [Fact]
      
        public void Sum_10and20_returned30()
        {
            //arrange
            var x = 10;
            var y = 20;
            var expected = 30;


            //act
            var c = new MyCalcLib.MyCalcLib();
            var actual = c.Sum(x, y);


            //assert
            Assert.Equal(expected, actual);
        }
    }
}
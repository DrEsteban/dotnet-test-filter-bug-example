using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(
            "1234567890", 
            "1234567890", 
            "1234567890",
            "1234567890",
            "1234567890",
            "1234567890",
            "1234567890",
            "1234567890",
            "1234567890",
            "1234567890",
            "1234567890",
            "1234567890",
            "1234567890",
            "123456",
            "1234567890",
            "1234567890")]
        public void ThisIsAnExtremelyLongTestName_SoICanDemonstrateAStrangeBehaviorInDotnetTest_Filter(
            string string1,
            string string2,
            string string3,
            string string4,
            string string5,
            string string6,
            string string7,
            string string8,
            string string9,
            string string10,
            string string11,
            string string12,
            string string13,
            string string14,
            string string15,
            string string16)
        {
            //Assert.False(true);
        }
    }
}
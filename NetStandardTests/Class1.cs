namespace NetStandardTests
{
    using Lib;
    using Xunit;

    public class Class1Tests
    {
        [Xunit.Fact]
        public void Meh()
        {
            Assert.Equal(1, Class1.GetOne());
        }
    }
}

namespace NetStandardTests
{
    using Lib;
    using NUnit.Framework;

    public class Class1Tests
    {
        [Test]
        public void Meh()
        {
            Assert.AreEqual(1, Class1.GetOne());
        }
    }
}

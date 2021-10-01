using GDLibrary.Types;
using NUnit.Framework;

namespace GD3_2_Getting_Started_Tests
{
    public class Point2DTests
    {

        [SetUp]
        public void Setup()
        {

        }


        [Test]
        public void TestGetX()
        {
            Point2D p = new Point2D(2, 5);

            Assert.AreEqual(2, p.X);
        }
    }
}
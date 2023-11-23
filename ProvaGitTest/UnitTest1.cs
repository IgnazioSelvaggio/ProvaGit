namespace ProvaGitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        //create a test method for the Sum method
        [Test]
        public void TestSum()
        {
            int a = 10;
            int b = 20;
            int c = ProvaGitLib.Calc.Sum(a, b);
            Assert.That(c, Is.EqualTo(30));
        }
        [Test]
        public void TestDiff()
        {
            int a = 10;
            int b = 20;
            int c = ProvaGitLib.Calc.Diff(a, b);
            Assert.That(c, Is.EqualTo(-10));
        }
        [Test]
        public void TestMult()
        {
            int a = 10;
            int b = 20;
            int c = ProvaGitLib.Calc.Mult(a, b);
            Assert.That(c, Is.EqualTo(200));
        }
        [Test]

        public void TestDiv()
        {
            int a = 10;
            int b = 20;
            int c = ProvaGitLib.Calc.Div(a, b);
            Assert.That(c, Is.EqualTo(0));
        }
    }
}
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRank.Tests
{
    [TestClass]
    public class UnitTests : TestBase
    {
        [TestMethod]
        public void TestMethod1()
        {
            var inputs = GetTestCaseInputs(Cases.TestInput0);

            var result = Solution.GetResult(inputs.First().Roads, inputs.First().Locations);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var inputs = GetTestCaseInputs(Cases.TestInput1);
            var outputs = GetTestCaseOutputs(Cases.TestOutput2);

            for (int i = 0; i < inputs.Length; i++)
            {
                var result = Solution.GetResult(inputs[i].Roads, inputs[i].Locations);

                Assert.AreEqual(outputs[i], result);
            }
        }
    }
}
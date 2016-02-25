using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRank.Tests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            /*
1
4 6
1 2 2
1 3 4
1 4 8
2 3 3
2 4 3
3 4 1
*/
            Tuple<int, int, int>[] input = new Tuple<int, int, int>[6];

            input[0] = new Tuple<int, int, int>(1, 2, 2);
            input[1] = new Tuple<int, int, int>(1, 3, 4);
            input[2] = new Tuple<int, int, int>(1, 4, 8);
            input[3] = new Tuple<int, int, int>(2, 3, 3);
            input[4] = new Tuple<int, int, int>(2, 4, 3);
            input[5] = new Tuple<int, int, int>(3, 4, 1);
          

            var result = Solution.MinDistance(input);

            Assert.AreEqual(4, result);
        }


        [TestMethod]
        public void SquareTest()
        {
            /*
1
6 7

1 2 1
2 3 1
3 4 1
4 1 1

1 5 2
5 6 2
6 1 1

*/
            Tuple<int, int, int>[] input = new Tuple<int, int, int>[7];

            input[0] = new Tuple<int, int, int>(1,2,1);
            input[1] = new Tuple<int, int, int>(2,3,1);
            input[2] = new Tuple<int, int, int>(3,4,1);
            input[3] = new Tuple<int, int, int>(4,1,1);

            input[4] = new Tuple<int, int, int>(1,5,2);
            input[5] = new Tuple<int, int, int>(5,6,2);
            input[6] = new Tuple<int, int, int>(6,1,1);


            var result = Solution.MinDistance(input);

            Assert.AreEqual(2, result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Tests
{
    public class TestBase
    {
        protected static TestInput[] GetTestCaseInputs(string testCase)
        {
            var inputs = new List<TestInput>();
            var lines = testCase.Split(new[] {Environment.NewLine}, StringSplitOptions.None).ToList();
            var noOfCases = Convert.ToInt32(lines.First());
            lines.RemoveAt(0);

            for (int i = 0; i < noOfCases; i++)
            {
                var line2 = lines[0].Split(' ');
                var numberOfLocations = Convert.ToInt32(line2[0]);
                var numberOfRoads = Convert.ToInt32(line2[1]);
                lines.RemoveAt(0);

                inputs.Add(new TestInput(lines.GetRange(0, numberOfRoads).ToArray(), numberOfLocations));

                lines.RemoveRange(0, numberOfRoads);
            }

            return inputs.ToArray();
        }

        protected int[] GetTestCaseOutputs(string testOutput)
        {
            var lines = testOutput.Split(new[] {Environment.NewLine}, StringSplitOptions.None).ToList();
            return lines.Select(int.Parse).ToArray();
        }

        protected class TestInput
        {
            public TestInput(string[] roads, int locations)
            {
                Roads = roads;
                Locations = locations;
            }

            public string[] Roads { get; private set; }
            public int Locations { get; private set; }
        }
    }
}
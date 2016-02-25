using System;
using System.Collections.Generic;

namespace HackerRank
{
    public class Solution
    {
        private static void Main(string[] args)
        {
            var noOfTests = int.Parse(Console.ReadLine());
            for (var j = 0; j < noOfTests; j++)
            {
                var line2 = Console.ReadLine().Split(' ');
                var numberOfLocations = Convert.ToInt32(line2[0]);
                var numberOfRoads = Convert.ToInt32(line2[1]);

                var roads = new string[numberOfRoads];
                for (var i = 0; i < numberOfRoads; i++)
                {
                    roads[i] = Console.ReadLine();
                }

                var minimal_result = GetResult(roads, numberOfLocations);

                Console.WriteLine(minimal_result);
            }
        }

        public static long GetResult(string[] roads, int numberOfLocations)
        {
            var locations = new List<short>[numberOfLocations];

            for (var i = 0; i < numberOfLocations; i++)
            {
                locations[i] = new List<short>();
            }

            foreach (var t in roads)
            {
                var ABD = t.Split(' ');
                var distance = short.Parse(ABD[2]);
                var A = short.Parse(ABD[0]) - 1;
                var B = short.Parse(ABD[1]) - 1;

                locations[A].Add(distance);
                locations[B].Add(distance);
            }

            var minimal_result = long.MaxValue;
            for (var i = 0; i < locations.Length; i++)
            {
                var dist_smallest = short.MaxValue;
                var dist_small = short.MaxValue;
                foreach (var dist in locations[i])
                {
                    if (dist < dist_smallest)
                    {
                        dist_small = dist_smallest;
                        dist_smallest = dist;
                    }
                    else if (dist < dist_small)
                    {
                        dist_small = dist;
                    }
                }

                long dist_total = dist_small + dist_smallest;
                if (dist_total < minimal_result)
                    minimal_result = dist_total;
            }

            return minimal_result;
        }
    }
}
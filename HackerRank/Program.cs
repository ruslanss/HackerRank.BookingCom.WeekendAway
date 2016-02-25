using System;
using System.Collections.Generic;

namespace HackerRank
{
    public  class Solution
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            var line2 = Console.ReadLine().Split(' ');
            var numberOfRoads = Convert.ToInt32(line2[1]);
            var numberOfLocations = Convert.ToInt32(line2[0]);

            var locations = new List<int>[numberOfLocations]; //  locations = dict()

            for (int i = 0; i < numberOfRoads; i++) // for m in range(0, M):
            {
                var ABD = Console.ReadLine().Split(' '); //  ABD = sys.stdin.readline().split()
                var distance = Convert.ToInt32(ABD[2]);  //distance = int(ABD[2])
                var A = Convert.ToInt32(ABD[0]) - 1;     // A = int(ABD[0])
                var B = Convert.ToInt32(ABD[1]) - 1;     //B = int(ABD[1])
                if (locations[A] == null)    //if A not in locations:
                    locations[A] = new List<int>(); //    locations[A] = list()
                if (locations[B] == null)    //if B not in locations:
                    locations[B] = new List<int>();//    locations[B] = list()
                locations[A].Add(distance); //locations[A].append(distance)
                locations[B].Add(distance); //locations[B].append(distance)
            }

            long minimal_result = Int64.MaxValue; //minimal_result = float("inf")
            for (int i = 0; i < locations.Length; i++) //for l in locations.values():
            {                                          //    # no need to sort completely, only O(N)
                var dist_smallest = Int32.MaxValue;    //    dist_smallest = float("inf")
                var dist_small = Int32.MaxValue;       //    dist_small = float("inf")
                foreach (var dist in locations[i])      //    for dist in l:
                {
                    if (dist < dist_smallest)   //        if dist < dist_smallest:
                    {
                        dist_small = dist_smallest; //            dist_small = dist_smallest
                        dist_smallest = dist;        //            dist_smallest = dist
                    }
                    else if (dist < dist_small) //        elif dist < dist_small:
                    {
                        dist_small = dist;  //            dist_small = dist
                    }
                 }

                long dist_total = dist_small + dist_smallest; //  dist_total = dist_small + dist_smallest
                if (dist_total < minimal_result)            //    if dist_total < minimal_result:
                    minimal_result = dist_total;            //        minimal_result = dist_total

            }


            Console.WriteLine(minimal_result);
        }

        public static int MinDistance(Tuple<int, int, int>[] locations)
        {
            var min = 101;

            for (int i = 0; i < locations.Length; i++)
            {
                var pointA = locations[i].Item1;
                var pointB = locations[i].Item2;
                var distance = locations[i].Item3;

                distance = distance + GetNearestPointC(pointA, pointB, locations);

                if (min > distance)
                    min = distance;
            }

            return min;
        }

        private static int GetNearestPointC(int pointA, int pointB, Tuple<int, int, int>[] locations)
        {
            var min = 101;
            for (int i = 0; i < locations.Length; i++)
            {
                if (locations[i].Item1 == pointA && locations[i].Item2 == pointB)
                    continue;
                if (locations[i].Item1 == pointB && locations[i].Item2 == pointA)
                    continue;

                if (locations[i].Item1 != pointA && locations[i].Item2 != pointA && locations[i].Item1 != pointB &&
                    locations[i].Item2 != pointB)
                    continue;

                if (min > locations[i].Item3)   min = locations[i].Item3;
            }

            return min;
        }
    }
}

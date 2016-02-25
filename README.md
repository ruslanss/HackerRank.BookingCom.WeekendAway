# HackerRank.BookingCom.WeekendAway
 Booking.com > Hack a Holiday: City Break Edition > Weekend away

Pete is tired of spending his weekends at home and wants to leave his apartment for a nice weekend getaway. After checking Villas.com for inspiration, he found a lot of countryside accommodations in locations LL = [L1L1 .. LNLN]. Now he plans to go to LstartLstart, rent a car, travel to a few other locations from his list along the way until he reaches his final destination, location LendLend, return the car there and head back home.

It doesn’t matter to Pete which locations he visits, as long as the total distance that he drives in his rental car is minimal. However, his friends suggest that he not waste time and visits at least three locations. Help Pete plan a route in which both his conditions and his friends’ suggestions are satisfied.

Note:

    Pete can start and finish his route at any locations - LstartLstart, LendLend ∈ LL as long as there is a route from LstartLstart to LendLend.
    Pete wants to minimize the total driving distance of his route.
    Following his friends’ suggestions, Pete wants to visit at least 3 locations.

Pete isn’t worried about the distance from his apartment to LstartLstart or the distance from LendLend back to his apartment, so you only need to minimize Pete’s driving distance between LstartLstart to LendLend.

Input Format

The first line contains integer TT, TT test-cases follow. The first line of each test-case contains integer NN that specifies the number of locations, followed by integer MM that specifies the number of roads between locations. Locations have an id [1..N][1..N]. Each of the next MM lines contains three space separated integers AA, BB and DD, which correspond to a bi-directional road between AA and BB that has a length of DD km.
Constraints

1<=T<=101<=T<=10
3<=N<=1053<=N<=105
2<=M<=4×1052<=M<=4×105
1<=D<=1001<=D<=100

Output Format

TT lines, each representing the minimal distance Pete needs to drive in km for test case ii ∈ [1..T][1..T]. Note that there always will be a valid solution.

Sample Input

1
4 6
1 2 2
1 3 4
1 4 8
2 3 3
2 4 3
3 4 1

Sample Output

4

Explanation

In this case, there are two possible routes that are minimized in terms of driving distance: 2 -> 3 -> 4 and 2 -> 4 -> 3, they both sum up to a total driving distance of 4. They both contain 3 different locations.

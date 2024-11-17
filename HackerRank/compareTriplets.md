Alice and Bob each created one problem for HackerRank. A reviewer rates the two challenges, awarding points on a scale from _1_ to _100_ for three categories: _problem clarity_, _originality_, and _difficulty_.

The rating for Alice's challenge is the triplet _a = (a[0], a[1], a[2])_, and the rating for Bob's challenge is the triplet _b = (b[0], b[1], b[2])_.

The task is to find their _comparison points_ by comparing _a[0]_ with _b[0]_, _a[1]_ with _b[1]_, and _a[2]_ with _b[2]_.

- If _a[i] > b[i]_, then Alice is awarded _1_ point.
- If _a[i] < b[i]_, then Bob is awarded _1_ point.
- If _a[i] = b[i]_, then neither person receives a point.

Comparison points is the total points a person earned.

Given _a_ and _b_, determine their respective comparison points.

**Example**

_a = [1, 2, 3]_  
_b = [3, 2, 1]_  

- For elements *0*, Bob is awarded a point because _a[0] ._
_- For the equal elements _a[1]_ and _b[1]_, no points are earned.
- Finally, for elements _2_, _a[2] > b[2]_ so Alice receives a point._

_

The return array is _[1, 1]_ with Alice's score first and Bob's second.

**Function Description**

Complete the function _compareTriplets_ in the editor below.

compareTriplets has the following parameter(s):

- _int a[3]_: Alice's challenge rating
- _int b[3]_: Bob's challenge rating

**Return**

_

- _int[2]_: Alice's score is in the first position, and Bob's score is in the second.

**Input Format**

The first line contains _3_ space-separated integers, _a[0]_, _a[1]_, and _a[2]_, the respective values in triplet _a_.  
The second line contains _3_ space-separated integers, _b[0]_, _b[1]_, and _b[2]_, the respective values in triplet _b_.

**Constraints**

- _1 ≤ a[i] ≤ 100_
- _1 ≤ b[i] ≤ 100_

**Sample Input 0**

5 6 7
3 6 10

**Sample Output 0**

1 1

--- 
## **Solution:**

```
    public static List<int> compareTriplets(List<int> a, List<int> b)

    {

        int Alice_point = 0, Bob_point = 0;

        for(int i =0; i< a.Count; i++){

            if(a[i] > b[i]){

                Alice_point++;

            }else if(a[i] < b[i]){

                Bob_point ++;

            }

        }

        return [Alice_point,Bob_point];
    }
```
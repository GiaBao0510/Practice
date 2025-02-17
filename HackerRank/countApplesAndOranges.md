Sam's house has an apple tree and an orange tree that yield an abundance of fruit. Using the information given below, determine the number of apples and oranges that land on Sam's house.

In the diagram below:

- The red region denotes the house, where s is the start point, and t is the endpoint. The apple tree is to the left of the house, and the orange tree is to its right.
- Assume the trees are located on a single point, where the apple tree is at point a, and the orange tree is at point b.
- When a fruit falls from its tree, it lands d units of distance from its tree of origin along the x-axis. *A negative value of d means the fruit fell  units to the tree's left, and a positive value of d means it falls d units to the tree's right. *

![Apple and orange(2).png](https://s3.amazonaws.com/hr-challenge-images/25220/1474218925-f2a791d52c-Appleandorange2.png)

Given the value of d for m apples and n oranges, determine how many apples and oranges will fall on Sam's house (i.e., in the inclusive range [s,t])?

For example, Sam's house is between s = 7 and t = 10. The apple tree is located at a = 4  and the orange at b = 12 . There are m = 3 apples and n = 3 oranges. Apples are thrown apples = [ 2, 3, -4] units distance from a, and oranges = [3, -2 ,-4] units distance. Adding each apple distance to the position of the tree, they land at [4 + 2, 4 + 3, 4 + -4] = [6 , 7, 0]. Oranges land at [12 + 3, 12 + -2, 12 + -4] = [15, 10, 8]. One apple and two oranges land in the inclusive range 7 - 10 so we print

```
1
2
```

**Function Description**

Complete the _countApplesAndOranges_ function in the editor below. It should print the number of apples and oranges that land on Sam's house, each on a separate line.

countApplesAndOranges has the following parameter(s):

- _s_: integer, starting point of Sam's house location.
- _t_: integer, ending location of Sam's house location.
- _a_: integer, location of the Apple tree.
- _b_: integer, location of the Orange tree.
- _apples_: integer array, distances at which each apple falls from the tree.
- _oranges_: integer array, distances at which each orange falls from the tree.

**Input Format**

The first line contains two space-separated integers denoting the respective values of s and t.  
The second line contains two space-separated integers denoting the respective values of  a and t.  
The third line contains two space-separated integers denoting the respective values of  m and n.  
The fourth line contains m space-separated integers denoting the respective distances that each apple falls from point a.  
The fifth line contains n space-separated integers denoting the respective distances that each orange falls from point b.

**Constraints**
- 1 <= s, t, a, b, m, n <= 10^5
- - 10^5 <= d <= 10^5
- a < s< t < b
**Output Format**

Print two integers on two different lines:

1. The first integer: the number of apples that fall on Sam's house.
2. The second integer: the number of oranges that fall on Sam's house.

**Sample Input 0**

7 11
5 15
3 2
-2 2 1
5 -6

**Sample Output 0**

1
1

---
## **Solution:**

```
public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
{
	int numberOfApples = 0,
		numberOfOranges = 0;

	// calculate the distance of the apples to the tre and count the number of apples in the range[s,t]
	for(int i = 0; i < apples.Count; i++){
		int distance = a + apples[i];
		if(distance >= s && distance <= t){
			numberOfApples++;
		}
	}

	// calculate the distance of the orange to the tre and count the number of oranges in the range[s,t]
	for(int i = 0; i < oranges.Count; i++){
		int distance = b + oranges[i];
		if(distance >= s && distance <= t){
			numberOfOranges++;
		}
	}

	Console.WriteLine(numberOfApples);
	Console.WriteLine(numberOfOranges);
}
```
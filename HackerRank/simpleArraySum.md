Given an array of integers, find the sum of its elements.

For example, if the array _ar = [1,2,3]_, 1+2+3 =  , so return  6.

**Function Description**

Complete the _simpleArraySum_ function in the editor below. It must return the sum of the array elements as an integer.

simpleArraySum has the following parameter(s):

- _ar_: an array of integers

**Input Format**

The first line contains an integer, , denoting the size of the array.  
The second line contains  space-separated integers representing the array's elements.

**Constraints**
0< n,ar[i] <= 1000

**Output Format**

Print the sum of the array's elements as a single integer.

**Sample Input**

```
6
1 2 3 4 10 11
```

**Sample Output**

```
31
```

**Explanation**

We print the sum of the array's elements: 1+2+3+4+10+11 = 31.

---
## **Solution:**

```
    public static int simpleArraySum(List<int> ar)

    {

        return ar.Sum();

    }
```
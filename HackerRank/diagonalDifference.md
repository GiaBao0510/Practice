Given a square matrix, calculate the absolute difference between the sums of its diagonals.

For example, the square matrix  is shown below:

```
1 2 3
4 5 6
9 8 9  
```

The left-to-right diagonal = 1 + 5+ 9 = 15. The right to left diagonal = 3+5+9=17 . Their absolute difference is |15 - 17| = 2.

**Function description**

Complete the  function in the editor below.

diagonalDifference takes the following parameter:

- _int arr[n][m]_: an array of integers

**Return**

- _int_: the absolute diagonal difference

**Input Format**

The first line contains a single integer, n , the number of rows and columns in the square matrix arr .  
Each of the next n  lines describes a row, arr[i], and consists of n space-separated integers a[ i ]  [ j ].

--- 
## **Solution:**

```
    public static int diagonalDifference(List<List<int>> arr)

    {

        int n = arr.Count;

        int primaryDiagonalSum = 0,

            secondaryDiagonalSum = 0;

        for(int i = 0; i< n ;i++){

            primaryDiagonalSum += arr[i][i];

            secondaryDiagonalSum += arr[i][n- 1 - i];

        }

        return Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);

    }
```
Given an array of integers, calculate the ratios of its elements that are _positive_, _negative_, and _zero_. Print the decimal value of each fraction on a new line with 6 places after the decimal.

**Note:** This challenge introduces precision problems. The test cases are scaled to six decimal places, though answers with absolute error of up to  10^-4 are acceptable.

**Example**  
arr = [ 1, 1, 0, -1, -1]
There are n= 5  elements, two positive, two negative and one zero. Their ratios are 2/5 = 0.400000 ,2/5 = 0.400000 and 1/5 = 0.200000  . Results are printed as:

```
0.400000
0.400000
0.200000
```

**Function Description**

Complete the _plusMinus_ function in the editor below.

plusMinus has the following parameter(s):

- _int arr[n]_: an array of integers

**Print**  
Print the ratios of positive, negative and zero values in the array. Each value should be printed on a separate line with  digits after the decimal. The function should not return a value.

**Input Format**

The first line contains an integer n , the size of the array.  
The second line contains n space-separated integers that describe arr[n].

**Constraints**

  0 < n <= 100
  -100 <= arr[ i ] <= 100

**Output Format**

**Print** the following  lines, each to  decimals:

1. proportion of positive values
2. proportion of negative values
3. proportion of zeros

**Sample Input**

```
STDIN           Function
-----           --------
6               arr[] size n = 6
-4 3 -9 0 4 1   arr = [-4, 3, -9, 0, 4, 1]
```

**Sample Output**

```
0.500000
0.333333
0.166667
```

--- 
## **Solution:**

```
    public static void plusMinus(List<int> arr)

    {

        int positive = 0, negative = 0, zero = 0;

        foreach(var i in arr){

            if(i > 0)

                positive ++;

            else if(i < 0)

                negative ++;

            else

                zero ++;

        }

        Console.WriteLine((float)positive/arr.Count);

        Console.WriteLine((float)negative/arr.Count);

        Console.WriteLine((float)zero/arr.Count);

    }
```
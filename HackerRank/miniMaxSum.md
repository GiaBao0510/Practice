Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. Then print the respective minimum and maximum values as a single line of two space-separated long integers.

**Example**  
arr = [1,3,5,7,9]
The minimum sum is 1+3+5+7 = 10  and the maximum sum is 3+5+7+9 = 24 . The function prints

```
16 24
```

**Function Description**

Complete the _miniMaxSum_ function in the editor below.

miniMaxSum has the following parameter(s):

- _arr_: an array of 5 integers

**Print**

Print two space-separated integers on one line: the minimum sum and the maximum sum of  of  elements.

**Input Format**

A single line of five space-separated integers.
1 <= arr[i] <= 10^9
**Constraints**

**Output Format**

Print two space-separated long integers denoting the respective minimum and maximum values that can be calculated by summing exactly _four_ of the five integers. (The output can be greater than a 32 bit integer.)

**Sample Input**

```
1 2 3 4 5
```

**Sample Output**

```
10 14
```

**Explanation**

The numbers are 1,2 3,4  and 5. Calculate the following sums using four of the five integers:

1. Sum everything except 1, the sum is 2+3+4+5 = 14.
2. Sum everything except 2, the sum is 1+3+4+5 = 13.
3. Sum everything except 3, the sum is 1+2+4+5 = 12.
4. Sum everything except 4, the sum is 1+2+3+5 = 11.
5. Sum everything except 5, the sum is 1+2+3+4 = 10.

**Hints:** Beware of integer overflow! Use 64-bit Integer.

---

### **Solution:**
```
public static void miniMaxSum(List<int> arr)
{
	if(arr.Count == 0 || arr == null)
	{
		Console.WriteLine("0 0");
		return;
	}

	long sum = 0;
	int minElement = arr[0], maxElement = arr[0];   //Lấy phần tử đầu tiên của mảng để so sánh

	foreach(int num in arr)
	{
		sum += num;
		minElement = Math.Min(minElement, num); //Tìm phần tử lớn nhất trong mảng
		maxElement = Math.Max(maxElement, num); //Tìm phần tử nhỏ nhất trong mảng
	}

	Console.WriteLine($"{sum-maxElement} {sum-minElement}");
}
```
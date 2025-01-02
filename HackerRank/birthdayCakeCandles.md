You are in charge of the cake for a child's birthday. You have decided the cake will have one candle for each year of their total age. They will only be able to blow out the tallest of the candles. Count how many candles are tallest.

**Example**
_candles_ = [4, 4, 1, 3]

The maximum height candles are 4 units high. There are 2  of them, so return 2.

**Function Description**

Complete the function `birthdayCakeCandles` in the editor below.

birthdayCakeCandles has the following parameter(s):

- _int candles[n]_: the candle heights

**Returns**

- _int_: the number of candles that are tallest

**Input Format**

The first line contains a single integer, n , the size of _candles_[].  
The second line contains  space-separated integers, where each integer i describes the height of _candles_[i].

**Sample Input 0**

4
3 2 1 3

**Sample Output 0**

2

**Explanation 0**

Candle heights are [3, 2 ,1 ,3] . The tallest candles are 3 units, and there are 2 of them.

---
## **Solution:**
```
public static int birthdayCakeCandles(List<int> candles){
	
	int maxval = candles[0],  //Get the first value of the Array to compare with the next elements
		count = 1;             //Count the largest number of values
		
	for(int i = 1; i < candles.Count();i++){
		if(maxval == candles[i]){           //If the maxval is equal to the next element, increment the count
			count++;
		}else if(maxval < candles[i]){    //If the maxval is less than the next element, update the maxval and reset the count
			maxval = candles[i];
			count = 1;
		}
	}
	return count;
}
```

Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

You must write an algorithm with `O(log n)` runtime complexity.

**Example 1:**

**Input:** nums = [1,3,5,6], target = 5
**Output:** 2

**Example 2:**

**Input:** nums = [1,3,5,6], target = 2
**Output:** 1

**Example 3:**

**Input:** nums = [1,3,5,6], target = 7
**Output:** 4

**Constraints:**

- `1 <= nums.length <= 104`
- `-104 <= nums[i] <= 104`
- `nums` contains **distinct** values sorted in **ascending** order.
- `-104 <= target <= 104`

---
## **Solution:

```
public static int SearchInsert(int[] nums, int target) {

	// If array is empty, return 0
	if (nums == null || nums.Length == 0) return 0;

	int L = 0, R = nums.Length - 1;

	//iterative steps to fin the result. O(log n)
	while(L <= R){

		int mid = L + (R-L)/2;              // calculate mid point

		if(nums[mid]  == target) return mid;       // if mid point is target, return mid
		else if(nums[mid] < target) L = mid+ 1;   // if mid point is less than target, move left pointer to mid + 1
		else R = mid -1;                    // if mid point is greater than target, move right pointer to mid - 1
	}

	return L; // return the position where target can be inserted to maintain sorted array

}
```
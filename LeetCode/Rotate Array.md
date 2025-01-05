Given an integer array `nums`, rotate the array to the right by `k` steps, where `k` is non-negative.

**Example 1:**

**Input:** nums = [1,2,3,4,5,6,7], k = 3
**Output:** [5,6,7,1,2,3,4]
**Explanation:**
rotate 1 steps to the right: [7,1,2,3,4,5,6]
rotate 2 steps to the right: [6,7,1,2,3,4,5]
rotate 3 steps to the right: [5,6,7,1,2,3,4]

**Example 2:**

**Input:** nums = [-1,-100,3,99], k = 2
**Output:** [3,99,-1,-100]
**Explanation:** 
rotate 1 steps to the right: [99,-1,-100,3]
rotate 2 steps to the right: [3,99,-1,-100]

**Constraints:**

- `1 <= nums.length <= 105`
- `-231 <= nums[i] <= 231 - 1`
- `0 <= k <= 105`

**Follow up:**

- Try to come up with as many solutions as you can. There are at least **three** different ways to solve this problem.
- Could you do it in-place with `O(1)` extra space?

---
## **Solution:**
```
public static void Rotate(int[] nums, int k){

	if(nums == null ||nums.Length == 0 || k < 0) return;

	//Normalize k if it's larger than array length (k > nums.Length)
	k %= nums.Length;
	if(k == 0) return;

	/*
		Example: nums = [1,2,3,4,5,6,7], k = 3
		Output: [5,6,7,1,2,3,4]
		--------------------------------
		1. Reverse entire array: [7,6,5,4,3,2,1]        (0, nums.Length-1)
		2. Reverse first k elements: [5,6,7,4,3,2,1]    (0, k-1)
		3. Reverse remaining elements: [5,6,7,1,2,3,4]  (k, nums.Length-1)
	*/

	//Step 1: Reverse entire array (0, nums.Length-1)
	Reverse(nums, 0, nums.Length-1);

	//Step 2: Reverse first k elements (0, k-1)
	Reverse(nums, 0, k-1);

	//Step 3: Reverse remaining elements (k, nums.Length-1)
	Reverse(nums, k, nums.Length-1);
}

public static void Reverse(int[] nums, int start, int end){
	while(start < end){
		int temp = nums[start];
		nums[start] = nums[end];
		nums[end] = temp;
		start++;
		end--;
	}
}
```
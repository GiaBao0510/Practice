You are given an integer array `nums`. You are initially positioned at the array's **first index**, and each element in the array represents your maximum jump length at that position.

Return `true` _if you can reach the last index, or_ `false` _otherwise_.

**Example 1:**

**Input:** nums = [2,3,1,1,4]
**Output:** true
**Explanation:** Jump 1 step from index 0 to 1, then 3 steps to the last index.

**Example 2:**

**Input:** nums = [3,2,1,0,4]
**Output:** false
**Explanation:** You will always arrive at index 3 no matter what. Its maximum jump length is 0, which makes it impossible to reach the last index.

**Constraints:**

- `1 <= nums.length <= 104`
- `0 <= nums[i] <= 105`

---
## **Solution:**
```
public static bool CanJump(int[] nums) {
	/*
		Example: A[3,2,1,0,4]
		Intinal: flag = A.Length - 1 = 4
		
		-- repeat from last index to first index --

		Repeat 0:
			- index = 3, A[index] = 0
			- A[index] + index = 3; Flag = 4

		Repeat 1:
		- index = 2, A[index] = 1
		- A[index] + index = 3; Flag = 3

		Repeat 2:
		- index = 1, A[index] = 2
		- A[index] + index = 3; Flag = 2

		Repeat 3:
		- index = 0, A[index] = 3
		- A[index] + index = 3; Flag = 0

		So return False. Because it can't reach the end of the array
	*/

	int finalIndex = nums.Length - 1;       //Flag, if it reaches the beginning of the array then true

	//Iterate from the end of the array
	for(int index = nums.Length - 2; index >= 0; index --){
		if(nums[index] + index >= finalIndex){  //Check if the current index can reach the final index
			finalIndex = index;                 //If it can, then update the final index

		}
	}

	return finalIndex == 0; //Check has reached the first index
}
```
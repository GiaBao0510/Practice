Given an array `nums` of size `n`, return _the majority element_.

The majority element is the element that appears more than `⌊n / 2⌋` times. You may assume that the majority element always exists in the array.

**Example 1:**

**Input:** nums = [3,2,3]
**Output:** 3

**Example 2:**

**Input:** nums = [2,2,1,1,1,2,2]
**Output:** 2

**Constraints:**

- `n == nums.length`
- `1 <= n <= 5 * 104`
- `-109 <= nums[i] <= 109`
---
## **Solution:**
```
public static int MajorityElement(int[] nums) {
        int count = 0;          //Count number of identical elements
        int candidate = 0;      //Get value with high duplicate count

        //Loop through the array
        foreach (int num in nums)
        {
            if (count == 0)                         //If count is 0, assign the current number as candidate
            {
                candidate = num;
            }
            count += (num == candidate) ? 1 : -1;   //If count is 0, assign the current number as candidate
        }
        return candidate;
    }
```
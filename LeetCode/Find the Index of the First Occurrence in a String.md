Given two strings `needle` and `haystack`, return the index of the first occurrence of `needle` in `haystack`, or `-1` if `needle` is not part of `haystack`.

**Example 1:**

**Input:** haystack = "sadbutsad", needle = "sad"
**Output:** 0
**Explanation:** "sad" occurs at index 0 and 6.
The first occurrence is at index 0, so we return 0.

**Example 2:**

**Input:** haystack = "leetcode", needle = "leeto"
**Output:** -1
**Explanation:** "leeto" did not occur in "leetcode", so we return -1.

**Constraints:**

- `1 <= haystack.length, needle.length <= 104`
- `haystack` and `needle` consist of only lowercase English characters.
---

## **Solution:**

```
public int StrStr(string haystack, string needle) {

	//if the length of the haystack is greater than the length of the needle the return -1
	if(haystack.Length < needle.Length) return -1;

	//iterate through each charater from string haystack
	for(int i = 0; i < haystack.Length; i++){
		
		//Check each charater in the needle to see if they all match inside the haystack
		int j;
		for( j = 0; j < needle.Length; j++){
			if(haystack[ Math.Min(i+j, haystack.Length -1)] !=  needle[j])
				break;
		}

		if(j == needle.Length)
			return i;
	}

	return -1;
}
```
Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string `""`.

**Example 1:**

**Input:** strs = ["flower","flow","flight"]
**Output:** "fl"

**Example 2:**

**Input:** strs = ["dog","racecar","car"]
**Output:** ""
**Explanation:** There is no common prefix among the input strings.

**Constraints:**

- `1 <= strs.length <= 200`
- `0 <= strs[i].length <= 200`
- `strs[i]` consists of only lowercase English letters if it is non-empty.

---
## **Solution:**

```
public string LongestCommonPrefix(string[] strs) {

	if(strs.Length == 0 || strs == null) return "";

	//Get the first element value
	string prefix = strs[0];

	//Compare prefix with subsequent elements
	for(int i = 1; i < strs.Length ;i++){

		prefix = CommonPrefix(prefix, strs[i]);
		//If the prefix is empty, stop immediately
		if(prefix.Length == 0) break;
	}

	return prefix;
}

//Function to find the common prefix among two strings a and b
public static string CommonPrefix(string a, string b){

	//Find the minimum length of two strings
	int minLen = Math.Min(a.Length, b.Length);
	int i = 0;

	//Find the common prefix
	while(i < minLen && a[i] == b[i]){
		i++;
	}

	//Return the common prefix
	return a.Substring(0,i);
}
```
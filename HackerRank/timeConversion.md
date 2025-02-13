Given a time in [12-hour AM/PM format](https://en.wikipedia.org/wiki/12-hour_clock), convert it to military (24-hour) time.

Note:
- 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.  
- 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.

**Example**
- S = **'12:01:00PM'.**
	- Return '12:01:00'.
- S = "**12:01:00AM"**
- Return '00:01:00'.
    

**Function Description**
Complete the  function with the following parameter(s):
- ***string s***: a time in  hour format

**Returns**
- ***string:*** the time in  hour format

**Input Format**

A single string **s** that represents a time in 12-hour clock format (i.e.:  **hh:mm:ssAM** or **hh:mm:ssPM**).

**Constraints**
- All input times are valid

**Sample Input 0**
07:05:45PM

**Sample Output 0**
19:05:45


---
## **Solution:**
```
public static string timeConversion(string s)
{
	string remaining = s.Substring(2, s.Length - 4);// 2 is the starting index and s.Length - 4 is the length of the string
	string Last = s.Substring(s.Length - 2, 2);     // s.Length - 2 is the starting index and 2 is the length of the string
	string first = s.Substring(0,2);                // 0 is the starting index and 2 is the length of the string

	// if the last two characters are PM and the first two characters are not 12 then add 12 to the first two characters
	if(Last == "PM"){

		// convert the first two characters to integer
		int hours = int.Parse(first);

		// if the first two characters are not 12 then add 12 to the first two characters
		if(hours != 12){
			hours += 12;
			return hours.ToString() + remaining;
		}
		
		return first + remaining;
	}

	// if the last two characters are AM and the first two characters are 12 then convert the first two characters to 00
	else if(Last == "AM" && first == "12"){
		return "00" + remaining;
	}

	return first + remaining; // if the last two characters are AM and the first two characters are not 12 then return the first two characters

}
```
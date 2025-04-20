Write an algorithm to determine if a number `n` is happy.

A **happy number** is a number defined by the following process:

- Starting with any positive integer, replace the number by the sum of the squares of its digits.
- Repeat the process until the number equals 1 (where it will stay), or it **loops endlessly in a cycle** which does not include 1.
- Those numbers for which this process **ends in 1** are happy.

Return `true` _if_ `n` _is a happy number, and_ `false` _if not_.

**Example 1:**

**Input:** n = 19
**Output:** true
**Explanation:**
12 + 92 = 82
82 + 22 = 68
62 + 82 = 100
12 + 02 + 02 = 1

**Example 2:**

**Input:** n = 2
**Output:** false

**Constraints:**

- `1 <= n <= 231 - 1`
---

#### **Solution:**

```csharp
	/// <summary>
    /// Xác định xem một số nguyên dương n có phải là số hạnh phúc hay không.
    /// Một số hạnh phúc là một số mà khi bạn thay thế nó bằng tổng bình phương các chữ số của nó,
    /// và lặp lại quá trình này, cuối cùng bạn sẽ đạt được 1.
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>

    public static bool IsHappy(int n) {

        //Đặt slow và fast đều là n
        int slow = n, fast = n;

        do{

            //Chạy slow một bước
            slow = TinhTongBinhPhuongChuSo(slow);

            //Chạy Fast hai bước
            fast = TinhTongBinhPhuongChuSo
	            (TinhTongBinhPhuongChuSo(slow));

            //Nếu fast chạy đến 1 thì trả về true
            if(fast == 1)
                return true;

        }while(slow != fast);

        //Nếu slow == fast mà không phải là 1 thì trả về false
        return false;
    }

  

    /// <summary>
    /// Tính tổng bình phương các chữ số của n
    /// Ví dụ: n = 82 => 8^2 + 2^2 = 64 + 4 = 68
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>

    private static int TinhTongBinhPhuongChuSo(int n){

        int sum = 0;
        while( n > 0){
            int digit = n % 10;
            sum += (digit * digit);
            n /= 10;
        }
        return sum;
    }
```
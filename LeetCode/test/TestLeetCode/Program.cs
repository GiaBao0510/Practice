using System.Collections;
using System;
using System.Collections.Generic;
public class Solution {


    // public class ListNode {
    //     public int val;
    //     public ListNode next;
    //     public ListNode(int val=0, ListNode next=null) {
    //         this.val = val;
    //         this.next = next;
    //     }
    // }

    // //Thêm một node vào danh sách liên kết
    // public static ListNode AddNode(ListNode head, int val){
    //     ListNode newNode = new ListNode(val);

    //     if(head == null){
    //         head = newNode;
    //         return head;
    //     }else{
    //         ListNode Q = head;
    //         while(Q.next != null){
    //             Q = Q.next;
    //         }
    //         Q.next = newNode;
    //     }
    //     return head;
    // }

    // //In ra danh sách liên kết
    // public static void PrintListNode(ListNode head){
    //     Console.WriteLine("Danh sách liên kết: ");
    //     if(head == null) Console.WriteLine("Danh sách rỗng");

    //     while(head != null){
    //         Console.Write(head.val + " ");
    //         head = head.next;
    //     }

    //     Console.WriteLine();

    // }

    // public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        
    //     ListNode P = l1;
    //     ListNode Q = l2;

    //     int sumL1 = 0,
    //         sumL2 = 0;
    //     long sum = 0;

    //     while(P != null){
    //         sumL1 = sumL1 * 10 + P.val;
    //         P = P.next;
    //     }

    //     while(Q != null){
    //         sumL2 = sumL2 * 10 + Q.val;
    //         Q = Q.next;
    //     }

    //     string StrSuml1 = new String( sumL1.ToString().Reverse().ToArray());
    //     string StrSuml2 = new String( sumL2.ToString().Reverse().ToArray());
    //     Console.WriteLine("Số thứ nhất: " + StrSuml1);
    //     Console.WriteLine("Số thứ hai: " + StrSuml2);

    //     sum = Int64.Parse(StrSuml1) + Int64.Parse(StrSuml2);
    //     Console.WriteLine("Tổng: " + sum);
    //     ListNode head = null;

    //     if(sum == 0){
    //         head = AddNode(head, 0);
    //         return head;
    //     }else{
    //         while(sum > 0){
    //             int digit = (int)sum%10;
    //             head = AddNode(head, digit);
    //             sum /= 10;
    //         }
    //     }
        
    //     return head;
    // }

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


    static void Main(string[] args) {
        Solution sol = new Solution();
        // ListNode l1 = null;
        // l1 = sol.AddNode(l1, 2);
        // l1 = sol.AddNode(l1, 4);
        // l1 = sol.AddNode(l1, 3);
        // sol.PrintListNode(l1);

        // ListNode l2 = null;
        // l2 = sol.AddNode(l2, 5);
        // l2 = sol.AddNode(l2, 6);
        // l2 = sol.AddNode(l2, 4);
        // sol.PrintListNode(l2);

        // ListNode result = sol.AddTwoNumbers(l1, l2);
        // sol.PrintListNode(result);

        string[] strs = new string[]{"a","a","b"};
        Console.WriteLine("Result: "+sol.LongestCommonPrefix(strs));
    }
}
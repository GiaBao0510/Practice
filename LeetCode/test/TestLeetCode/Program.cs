using System.Collections;
using System;
using System.Collections.Generic;
public class Solution {

    static public string DecodeString(string s) {
        string result = "";

        //Danh sách mảng lưu số
        List<int> LitsNumber = new List<int>();

        //Danh sách mảng lưu chuỗi
        List<string> LitsString = new List<string>();

        string getNum = "";         //Láy chuỗi
        string getString = "";      //Lấy số

        //Duyệt
        foreach(var i in s){
            Console.WriteLine($">>>>Duyệt: {i}");
            

            if(char.IsDigit(i)){        //Nếu là số  thì thêm vào chuỗi
                getNum+= i;
                Console.WriteLine($">>>>số {getNum}");
            }else{
                Console.WriteLine($">>>> Lấy số {getNum}");
                if(!string.IsNullOrEmpty(getNum)){
                    LitsNumber.Add(int.Parse(getNum));  //Thêm chuỗi số
                    getNum = "";                        //Đặt lại
                } 
                
                if(char.IsLetter(i)){
                    getString+= i;
                    Console.WriteLine($">>>>chuỗi {getString}");
                }else if(!string.IsNullOrEmpty(getString)){
                    LitsString.Add(getString);      //Thêm chuỗi ký tự
                    getString = "";                  //Đặt lại
                }
            }
        }

        //Duyệt lần 2 để lấy kết quả
        for(int i = 0; i < LitsNumber.Count; i++) {
            Console.WriteLine($">>>>LitsNumber: {LitsNumber[i]}");
            Console.WriteLine($">>>>LitsString: {LitsString[i]}");
            for(int j = 0; j < LitsNumber[i]; j++) {
                result += LitsString[i];
            }
        }

        Console.WriteLine($">>>>Kết quả: {result}");
        return result;
    }

    static void Main(string[] args) {
        string s = "3[a]2[bc]";
        DecodeString(s);
    }
}
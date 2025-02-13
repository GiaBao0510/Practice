using System.Collections;
using System;
using System.Collections.Generic;
public class Solution {



    public static List<int> gradingStudents(List<int> grades)
    {
        // if array empty
        if(grades.Count == 0 || grades == null) return grades;

        //Array traversal
        for(int i = 0; i < grades.Count; i++){
            
            // Calculate next multiple of 5
            int nextMultipleOf5 = ((grades[i] + 4)/5) * 5;
           
            // Check if grade is greater than 38 and difference between next multiple of 5 and grade is less than 3
            if(grades[i] >= 38 && nextMultipleOf5 - grades[i] < 3){
                grades[i] = nextMultipleOf5;
            }
        }

        return grades;
    }

    static void Main(string[] args) {

        List<int> grades = new List<int>(){73, 67, 38, 33};
        List<int> result = gradingStudents(grades);
        foreach(int grade in result){
            Console.WriteLine(grade);
        }
        
    }
}
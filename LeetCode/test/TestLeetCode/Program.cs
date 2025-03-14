using System.Collections;
using System;
using System.Collections.Generic;
public class Solution {


    public static bool IsRobotBounded(string instructions){
        
        if(instructions.Length == 0 || instructions == null)
            return false;
        
        int count = 0;
        int x = 0, y = 0,
            Measure  = 0;
        
        while(count <= instructions.Length * 4){
            foreach(char i in instructions){
                if(Measure == 0 && i == 'L')  
                    Measure = 270;
                else if(Measure > 0 && i == 'L')
                    Measure -= 90;
                else if( x == 0 && i == 'R')
                    Measure += 90;
                else if(Measure > 0 &&  Measure <= 180 && i == 'R')
                    Measure+= 90;
                else if(Measure > 180 && i == 'R')
                    Measure = 0;
                else{
                    switch(Measure){
                        case 0: y++; break;
                        case 90: x++; break;
                        case 180: y--; break;
                        case 270: x--; break;
                    }
                    
                    if(x == 0 && y == 0) 
                        return true;
                }
                //Console.WriteLine(">> Duyet: "+i+" ,X = "+x);
            }
            count++;
        }
        return false;
    }
    
    public static void Main(string[] args)
    {
        Console.WriteLine(">> KQ: "+IsRobotBounded("GGLLGG"));
    }
}
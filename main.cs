using System;
using System.Collections.Generic;
using System.Linq;

class Program {

  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");

    //Test 1
    string[] array1 = {"a", "b", "c", "x"};
    string[] array2 = {"z", "y", "i"};

    Console.WriteLine("DO THESE  2 ARRAYS CONTAIN COMMON ITEMS: " + FindCommonItems(array1, array2));
    
    //Test 2
    string[] array3 = {"a", "b", "c", "x"};
    string[] array4 = {"z", "y", "x"};

     Console.WriteLine("DO THESE  2 ARRAYS CONTAIN COMMON ITEMS: " + FindCommonItems(array3, array4));

     Console.WriteLine("DO THESE  2 ARRAYS CONTAIN COMMON ITEMS: " + FindCommonItems2(array3, array4));
  }

  //Example for interview quesiton

  //Some things to think about:
  /*
    ->2 parameters - Always will be arrays - no size limit
    ->Return true or false
    ->May want to ask - how large the array will get/ Our goal time complexity or space complexity?
    ->How can you break this
  
  */

  //Given 2 arrays, create a function that let's a user know (true/false) whether these two arrays contain common items

  //For example:
  //string[] array1 = {"a", "b", "c", "x"};
  //string[] array2 = {"z", "y", "i"};
  //should return false.
  //-----------
  //string[] array1 = {"a", "b", "c", "x"};
  //string[] array2 = {"z", "y", "x"};
  //should return true.

  //Big 0 = 0(a+b) (Time complexity)
  //Big 0 = 0(a) (Space Complexity)
  public static bool FindCommonItems(string[] array1, string[] array2){
     
     List<string> arrayList = new List<string>();
    if(array1.Length > array2.Length){
      string[] tempArray = array1;
      array1 = array2;
      array2 = tempArray;
    }

    foreach(string item in array1){
        if(!arrayList.Contains(item)){
          arrayList.Add(item);
        }
    }

    foreach(string item in array2){
      if(arrayList.Contains(item)){
        return true;
      }
    }

    return false;

  }

  //This is the more efficant way of doing things. for the example
  //Big 0 = 0(n) (Time Complexity)
  //Big 0 = 0(1) (Space Complexity)
  public static bool FindCommonItems2(string[] array1, string[] array2){
    return array1.Intersect(array2).Any();
  } 

 
}
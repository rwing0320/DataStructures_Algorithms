using System;
using System.Collections.Generic;
using System.Linq;

class Program {

  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");

    string[] nemo = {"nemo", "Test 1", "Test 2", "Test 3", "Test 4", "Test 5", "Test 6"};

    string[] nemo2 = new string[100000];

    nemo2 = nemo2.Select(i => "nemo").ToArray();

   //As things grow larger and larger, does it scale?
    FindNemo(nemo);

    int[] boxesInt = {1,2,3,4,5};
    LogArrayPairs(boxesInt);


  }

  //Example for 0(1) --> Constant Time (Flat Line)
  public static void compressFirstBox(string[] boxes){
    Console.WriteLine(boxes[0]);
  
  }

   //This function is running 0(2) --> 0(1) (Constant Time)
   int[] boxes = {0,1,2,3,4,5};
  public static void LogFirstTwoBoxes(string[] boxes){
    Console.WriteLine(boxes[0]); //0(1)
    Console.WriteLine(boxes[1]); //0(1) 
  }

  //Example for 0(n)

   //Big O notation - 0(n) --> Linear Time (Most common)
   //n --> Number of inputs
  public static void FindNemo(string[] array){
      
      for(int i = 0; i < array.Length; i++){
        if(array[i] == "nemo"){
          Console.WriteLine("FOUND NEMO");
          break; //-->Make code more efficiant as it stops from running through all lines in an array
        }
      }

  }

  
  //Project Example
  //3 Steps + 4(n)
  //Big 0 = (3 + 4n) = 0(n)
  public static int FunChallenge(string[] input){
    int a = 10; // Assign variable - 0(1) - Usually not counted for declaration
    a = 50 + 3; //Reassign a value - 0(1)

    for(int i = 0;i < input.Length; i++){ //0(n)
        //anotherFunction(); //0(n)
        bool stranger = true;//0(n)
        a++;//0(n)
    }

    return a;//0(1) - Usually not counted for returns
  }

 
  //Project Example 2
  //4 Steps + 4(n) + 3(n)
  //Big 0 = (4 + 7(n)) = 0(n)
  public static void AnotherFunChallenge(string[] input){
    int a = 5; //0(1)
    int b = 10; //0(1)
    int c = 50; //0(1)

    for(int i = 0; i < input.Length; i++){//0(n)
        int x = i + 1;//0(n)
        int y = i + 2;//0(n)
        int z = i + 3;//0(n)
    }

     for(int j = 0; j < input.Length; j++){//0(n)
        int p = j * 2;//0(n)
        int q = j * 2;//0(n)
        
    }

    string whoAmI = "I don't know";//0(1)
  }

  //Log all pairs of array
  //Example of 0(n^2) --> Quadratic Time
  //Nested Loops = Multiplication

  //Big 0 = (0(n) * 0(n)) = 0(n^2);
  public static void LogArrayPairs(int[] boxesInt){

    bool isFirstNum = true;
    for(int i = 0; i < boxesInt.Length; i++){ // 0(n)
        
        for(int j = 0; j < boxesInt.Length; j++){//0(n)
            Console.WriteLine(boxesInt[i] + "," + boxesInt[j]);
        }

    }

  }

  //Factorial Time - Oh No: 0(n!)
  //Nested loop for every input we have
  public static void NFacRuntimeFunc(int n){
    for(int i = 0; i < n; i++){
      NFacRuntimeFunc(n - 1);
    }
  
  }


  //Space Complexity - NEW TOPIC - Example 1
  //Dont care about input (how big it is)
  //B0 0(1)
  public static void Boooooo(string[] n){
    for(int i = 0; i < n.Length; i++){ //0(1) as we are assigning a variable
      Console.WriteLine("booooo");
    }
  }

  //Space Complexity - Example 2
  //Big 0 = 0(n)
  public static string[] ArrayOfHiNTimes(string[] n){
    string[] hiArray = new string[n.Length]; //0(n) - for new data structure

    for(int i = 0; i < n.Length;i++){
        hiArray[i] = "hi"; // 0(n) filling the array data strucutre with a new value depending on how long the array is
    }

    return hiArray;
  }


  //Example - Twitter Problem

  // //Find 1st tweet, find Nth....
  // string[] array = ["hi", "my", "teddy"];
  // array[0] = Newest; //0(1)
  // array[array.Length - 1]; //0(1)

  // //Therefore Big 0 would be 0(1)



//   //Example - Twitter Problem 2

//   //Just like first but compare dates as well
//   //Compare each tweet with other tweets dates
    //Nested Loops
//    var tweets = new {
//      {
//       name = "hi",
//       date = 2012
//      },
//      {
//       name = "my",
//       date = 2014
//      },
//      {
//       name = "teddy",
//       date = 2018
//      }
//     };
    
//     //Therefore Big 0 would be 0(n^2)
// }

//Example 3
//What is the Big 0
//("hellothisisanexamplestring").Length

//Answer: Depends on which langauge
//Need to know how the method works on the string
//JS = 0(1)
//C# = 0(1)
using System;
using System.Collections.Generic;
using System.Linq;

class Program {

  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");

    string[] nemo = {"nemo", "Test 1", "Test 2", "Test 3", "Test 4", "Test 5", "Test 6"};

    string[] nemo2 = new string[10];

    nemo2 = nemo2.Select(i => "nemo").ToArray();

    FindNemo(nemo2);

  }

  public static void FindNemo(string[] array){
      
      DateTime t1 = DateTime.Now;
      
      for(int i = 0; i < array.Length; i++){
        if(array[i] == "nemo"){
          Console.WriteLine("FOUND NEMO");
        }
      }

      DateTime t2 = DateTime.Now;

      Console.WriteLine("Call to find Nemo took " + (t2 - t1).TotalMilliseconds + " milliseconds");
  }
}
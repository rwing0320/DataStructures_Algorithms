using System;

class Program {

  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");

    string[] nemo = {"nemo"};

    FindNemo(nemo);

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
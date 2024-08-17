// While loop
using System;

namespace Myapp{

    class loop{
    
        static void Main(string[] args){
        
        int i = 0;
        while (i<5){
            Console.WriteLine(i);
            i+=1;
        }
        
        }
    
    }
}

// For loop

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      for (int i = 0; i<5; i++) 
      {
        Console.WriteLine(i);
      }
    }
  }
}

// Foreach loop

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] cars = {1,2,3};
      foreach (int i in cars) 
      {
        Console.WriteLine(i);
      }   
    }
  }
}

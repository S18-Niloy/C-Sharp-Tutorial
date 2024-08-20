using System;

namespace MyApp{

    class arr{
    
        static void Main(string[] args){
        
        string[] cars = {"Audi","Toyota","Noah","BMW"};
        
        
        foreach (string i in cars){
        Console.WriteLine(i);
        }
        
        }
    }
}    

////////// Sort

using System;

namespace MyApp{

    class arr{
    
        static void Main(string[] args){
        
        string[] cars = {"Audi","Toyota","Noah","BMW"};
        Array.Sort(cars);
        
        foreach (string i in cars){
        Console.WriteLine(i);
        }
        
        }
    }
}    

////// Multidimensional Array

using System;

namespace MyApp{

    class arr{
    
        static void Main(string[] args){
        
        int[,] numbers = { {1, 4, 2}, {3, 6, 8} };

          foreach (int i in numbers)
          {
            Console.WriteLine(i);
          } 
        
        }
    }
}    


using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
    
      for (int i = 0; i < numbers.GetLength(0); i++) 
      {  
        for (int j = 0; j < numbers.GetLength(1); j++) 
        {  
          Console.WriteLine(numbers[i, j]);  
        }  
      }  
    }
  }
}












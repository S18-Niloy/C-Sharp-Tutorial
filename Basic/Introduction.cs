using System; 

namespace application 

{
    class myprogramme  
    {
        static void Main(string[] args)
        {
        // Print Hello World
        Console.WriteLine("Hello World!!");
        
        // Variables
        string name = "John";
        string name_2 = " Cina";
        Console.WriteLine(name);
        Console.WriteLine("The length of the txt string is: " + name.Length);
        Console.WriteLine(name.ToUpper());   
        Console.WriteLine(name.ToLower()); 
        Console.WriteLine(name + name_2);
        string full = string.Concat(name, name_2);
        Console.WriteLine(full);
        
        int num = 12;
        Console.WriteLine(num);
        
        char n = 'j';
        Console.WriteLine(n);
        
        bool decision = true;
        Console.WriteLine(decision);
        
        double num_2 = 19.999;
        Console.WriteLine(num_2);
        
        float myNum = 5.75F;
        Console.WriteLine(myNum);
        
        double myNum_2 = 19.99D;
        Console.WriteLine(myNum_2);
        
        float f1 = 35e3F;
        double d1 = 12E4D;
        Console.WriteLine(f1);
        Console.WriteLine(d1);
        
        double myDouble = 9.78;
        int myInt = (int) myDouble;   

        Console.WriteLine(myDouble); 
        Console.WriteLine(myInt);  
        
        int myInt_2 = 10;
        double myDouble_2 = 5.25;
        bool myBool = true;

        Console.WriteLine(Convert.ToString(myInt_2));    // convert int to string
        Console.WriteLine(Convert.ToDouble(myInt_2));    // convert int to double
        Console.WriteLine(Convert.ToInt32(myDouble_2));  // convert double to int
        Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
        
        
        // operations
        
       int a = 12;
       double b = 13.34;
       Console.WriteLine(a*b);
       
       int c = 12;
       int d = 134;
       Console.WriteLine(d%c);
       
       int e = 12;
       int f = 2;
       Console.WriteLine(e^f); //XOR
       Console.WriteLine(e&f); //AND
       Console.WriteLine(e|f); //OR
       Console.WriteLine(e>>f); //Right Shift
       Console.WriteLine(e<<f); //Left Shift
       
       //Assignment
       
       int x = 10;
      x += 5;
      Console.WriteLine(x); 
      
      int y = 10;
      y -= 5;
      Console.WriteLine(y); 
        }
    }
}

//using System means that we can use classes from the System namespace.

//namespace is used to organize your code, and it is a container for classes and other namespaces.

//class is a container for data and methods, which brings functionality to your program

//Console is a class of the System namespace, which has a WriteLine() method that is used to

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
        Console.WriteLine(name);
    
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
        
        }
    }
}
    

using System;

namespace MyApplication
{
  class Program
  {
    static void MyMethod()
    {
      Console.WriteLine("I just got executed!");
    }

    static void Main(string[] args)
    {
      MyMethod();
      MyMethod();
      MyMethod();
    }
  }
}

////// Parameters and Arguments

using System;

namespace MyApplication
{
  class Program
  {
    static void MyMethod(string fname, int age)
    {
      Console.WriteLine(fname + " is " + age);
    }

    static void Main(string[] args)
    {
      MyMethod("Liam", 5);
      MyMethod("Jenny", 8);
      MyMethod("Anja", 31);
    }
  }
}

///// Default parameters

using System;

namespace MyApplication
{
  class Program
  {
    static void MyMethod(string country = "Norway")
    {
      Console.WriteLine(country);
    }

    static void Main(string[] args)
    {
      MyMethod("Sweden");
      MyMethod("India");
      MyMethod();
      MyMethod("USA");
    }
  }
}


/////// Return values 

using System;

namespace MyApplication
{
  class Program
  {
    static int MyMethod(int x, int y)
    {
      return x + y;
    }

    static void Main(string[] args)
    {
      int z = MyMethod(5, 3);
      Console.WriteLine(z);
    }
  }
}

///// Named arguments

using System;

namespace MyApplication
{
  class Program
  {
    static void MyMethod(string child1, string child2, string child3)
    {
      Console.WriteLine("The youngest child is: " + child3);
    }

    static void Main(string[] args)
    {
      MyMethod(child3: "John", child1: "Liam", child2: "Liam");
    }
  }
}

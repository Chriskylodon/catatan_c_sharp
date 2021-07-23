generics are introduced in C# 2.0, generics allows us to design classes and methods decoupled from data types

Car BMW = new Car("385 i", 2010);
BMW here is an instance of a car.

bisa selain <T>


using System;
using System.Reflection;

namespace Eki
{
    public class Calculator
    {
        public static bool AreEqual(int Value1, int Value2)
        {
            return Value1 == Value2;
        }
    }

    class Program
    {
        public static void Main()
        {
            bool equal = Eki.Calculator.AreEqual(1,2);

            if (equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }



            Console.Read();
        }
    }
}





using System;
using System.Reflection;

namespace Eki
{
    public class Calculator
    {
        public static bool AreEqual(object Value1, object Value2)
        {
            return Value1 == Value2;
        }
    }

    class Program
    {
        public static void Main()
        {
            bool equal = Eki.Calculator.AreEqual("A","A");

            if (equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }



            Console.Read();
        }
    }
}






using System;
using System.Reflection;

namespace Eki
{
    public class Calculator
    {
        public static bool AreEqual<T>(T Value1, T Value2)
        {
            return Value1.Equals(Value2);
        }
    }

    class Program
    {
        public static void Main()
        {
            bool equal = Eki.Calculator.AreEqual<int>(10,10);

            if (equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }



            Console.Read();
        }
    }
}






using System;
using System.Reflection;

namespace Eki
{
    public class Calculator<T>
    {
        public static bool AreEqual(T Value1, T Value2)
        {
            return Value1.Equals(Value2);
        }
    }

    class Program
    {
        public static void Main()
        {
            bool equal = Eki.Calculator<int>.AreEqual(10,10);

            if (equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }



            Console.Read();
        }
    }
}




the problem using the System.Object type is that
1. AreEqual() Method is not a type safe
2. performance degradation due to boxing and unboxing




-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


using System;
using System.Reflection;

namespace Eki
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //public string ToString()
        //{
        //    return this.FirstName + " " + this.LastName;
        //}
    }

    class Program
    {
        public static void Main()
        {
            int Number = 10;
            Console.WriteLine(Number.ToString());

            Customer C1 = new Customer();
            C1.FirstName = "Sam";
            C1.LastName = "Simoon";
            Console.WriteLine(C1.ToString());

            Console.Read();
        }
    }
}




using System;
using System.Reflection;

namespace Eki
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }

        //public override string ToString()
        //{
        //    return this.FirstName + " " + this.LastName;
        //}
    }

    class Program
    {
        public static void Main()
        {
            int Number = 10;
            Console.WriteLine(Number.ToString());

            Customer C1 = new Customer();
            C1.FirstName = "Sam";
            C1.LastName = "Simoon";
            Console.WriteLine(C1.ToString());
            Console.WriteLine(Convert.ToString(C1));


            Console.Read();
        }
    }
}


-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


using System;
using System.Reflection;

namespace Eki
{
 
    class Program
    {
        public static void Main()
        {
            int i = 10;
            int j = 10;

            Console.WriteLine(i == j);
            Console.WriteLine(i.Equals(j));

            Console.Read();
        }
    }
}



using System;
using System.Reflection;

namespace Eki
{
    public enum Direction
    {
        East = 1,
        West = 2,
        North = 3,
        South = 4
    }


    class Program
    {
        public static void Main()
        {
            Direction direction1 = Direction.East;
            Direction direction2 = Direction.East;

            Console.WriteLine(direction1 == direction2);
            Console.WriteLine(direction1.Equals(direction2));

            Console.Read();
        }
    }
}



using System;
using System.Reflection;

namespace Eki
{
    public enum Direction
    {
        East = 1,
        West = 2,
        North = 3,
        South = 4
    }


    class Program
    {
        public static void Main()
        {
            Direction direction1 = Direction.East;
            Direction direction2 = Direction.West;

            Console.WriteLine(direction1 == direction2);
            Console.WriteLine(direction1.Equals(direction2));
            Console.WriteLine(Direction.East);
            Console.WriteLine(1);

            Console.Read();
        }
    }
}



using System;
namespace Pragim
{
    public class MainClass
    {
        private static void Main()
        {
            Customer C1 = new Customer();
            C1.FirstName = "Simon";
            C1.LastName = "Tan";


            Customer C2 = C1;


            Console.WriteLine(C1 == C2);
            Console.WriteLine(C1.Equals(C2));
        }
    }
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}



using System;
namespace Pragim
{
    public class MainClass
    {
        private static void Main()
        {
            Customer C1 = new Customer();
            C1.FirstName = "Simon";
            C1.LastName = "Tan";


            Customer C2 = new Customer();
            C2.FirstName = "Simon";
            C2.LastName = "Tan";


            Console.WriteLine(C1 == C2);
            Console.WriteLine(C1.Equals(C2));
        }
    }
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}



using System;
namespace Pragim
{
    public class MainClass
    {
        private static void Main()
        {
            Customer C1 = new Customer();
            C1.FirstName = "Simon";
            C1.LastName = "Tan";


            Customer C2 = new Customer();
            C2.FirstName = "Simon";
            C2.LastName = "Tan";


            Console.WriteLine(C1 == C2);
            Console.WriteLine(C1.Equals(C2)); //ragu

            Console.WriteLine(C1.GetHashCode());
            Console.ReadLine();
        }
    }
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public override bool Equals(object obj)
        {
            // If the passed in object is null
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Customer))
            {
                return false;
            }
            return (this.FirstName == ((Customer)obj).FirstName)
                && (this.LastName == ((Customer)obj).LastName);
        }


        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ LastName.GetHashCode();
        }
    }
}


-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------



using System;
public class MainClass
{
    public static void Main()
    {
        Customer C1 = null;


        Console.WriteLine(C1.ToString());           
        Console.WriteLine(Convert.ToString(C1));    


        Console.ReadLine();
    }
}
public class Customer
{
    public string Name { get; set; }
}




using System;
public class MainClass
{
    public static void Main()
    {
        //Customer C1 = null;


        //Console.WriteLine(C1.ToString());           // error
        //Console.WriteLine(Convert.ToString(C1));    // ga error

        Customer C2 = new Customer();
        C2.Name = "asdsfsf";

        Console.WriteLine(C2.ToString());           
        Console.WriteLine(Convert.ToString(C2));

        Console.WriteLine(C2.Name.ToString());
        Console.WriteLine(Convert.ToString(C2.Name));


        Console.ReadLine();
    }
}
public class Customer
{
    public string Name { get; set; }
}


-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------





system.string immutable
immutable -> butuh variabel baru lagi ketika string1 ditambahkan dengan string2 di heap.

            stack                   heap

                                    C#
                                    C# Video
                                    C# Video Tutorial
                                    C# Video Tutorial for 
            userString ---------->  C# Video Tutorial for beginner



string builder mutable (better performance than system.string, when heavy string manipulation is involved)
mutable -> bisa dirubah tanpa harus membuat instance/variabel baru lagi di heap.

            stack                   heap

            userString ----------> C# Video Tutorial for beginner



In this example, userString variable is changed 5 times.
1. C#
2. C# => C# Video
3. C# Video => C# Video Tutorial
4. C# Video Tutorial => C# Video Tutorial for
5. C# Video Tutorial for => C# Video Tutorial for beginners


Since, userString variable is of type System.String, and when we change this string 5 times, we end up with 5 string objects on the heap as shown in the diagram below. 
Immutable means, once a string object is created it cannot be changed, without creating another new string object. 
So in our example, When we initialize userString variable to "C#" we get one immutable string object on the heap. 
When we concatenate " Video" word to userString variable, the first created "C#" string object is orphaned(userString variable no longer points to this object). 
Now another new string object with words "C# Video" will be created to which the userString variable points to. So this process continues until, userString reference variable, points to the last string object (C# Video Tutorial for beginners), leaving the other 4 string onbjects on the heap(orphaned), until they are garbage collected, increasing the pressure on memory.


using System;
public class MainClass
{
    public static void Main()
    {
        string userString = "C#";
        userString += " Video";
        userString += " Tutorial";
        userString += " for";
        userString += " beginners";
        Console.WriteLine(userString);
    }
}


But on the other hand, StringBuilder string objects are mutable, meaning they can be changed inplace, without the need of creating another new StringBuilder object. 
The above example is rewritten using StringBuilder object.
With StringBuilder, no matter how many times you manipulate a string, you will ever have only one instance. 

So in brief, here are the differences between String and StringBuilderobjects.
1. Objects of type StringBuilder are mutable where as objects of type System.String are immutable. 
2. As StringBuilder objects are mutable, they offer better performance than string objects of type System.String.
3. StringBuilder class is present in System.Text namespace where String class is present in System namespace.



using System;
using System.Text;
namespace Pragim
{
    public class MainClass
    {
        public static void Main()
        {
            StringBuilder userStringBuilder = new StringBuilder("C#");
            userStringBuilder.Append(" Video");
            userStringBuilder.Append(" Tutorial");
            userStringBuilder.Append(" for");
            userStringBuilder.Append(" beginners");
            Console.WriteLine(userStringBuilder.ToString());
        }
    }
}




Just imagine, the number of orphaned string objects that get created on the heap when you have a program as shown below.

using System;
namespace Pragim
{
    public class MainClass
    {
        public static void Main()
        {
            string strNumbers = string.Empty;
            for (int i = 0; i < 1000; i++)
            {
                strNumbers += i.ToString() + " ";
            }

            Console.WriteLine(strNumbers);
            Console.Read();
        }
    }
}
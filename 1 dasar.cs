www.csharp-video-tutorials.blogspot.com

if (condition1)
{
  // block of code to be executed if condition1 is True
} 
else if (condition2) 
{
  // block of code to be executed if the condition1 is false and condition2 is True
} 
else
{
  // block of code to be executed if the condition1 is false and condition2 is False
}





for (int i = 0; i <= 10; i = i + 2) 
{
  Console.WriteLine(i);
}


string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
foreach (string i in cars) 
{
  Console.WriteLine(i);
}



https://stackoverflow.com/questions/552796/what-is-string-args-in-main-class-for/45752359#:~:text=The%20args%20parameter%20stores%20all,4%22%2C%20and%20%22parameters%22
static void Main(string[] args)  
{  
    foreach(string arg in args)  
    {  
       Console.WriteLine(arg);  
    }  
   Console.ReadLine();  
}  


input -> this is eki
output ->   this 
            is 
            eki


// single line comments
/* multiple line comments */
/// xml documentation


.dll => dynamic link library    => needs an invoker, it needs a consumer to invoke it.
.exe => executable              => we can run an .exe more than one at one time.




oop

about:
function
class
object
method

PILLARS OF OOP:
 1. INHERITANCE 		=> turunan/warisan (ParentClass-ChildClass dan BaseClass-DerivedClass)
 2. ENCAPSULATION		=> functional programming (struct-properties and get-set)
 3. ABSTRACTION 		=> class yg gaada implementation nya
 4. POLYMORPHISM		=> invoke DerivedClass through BaseClass



types:          classes, structs, enums, interfaces, delegates
type members:   fields, properties, constructor, methods


----------------------------------------------------------------------------------------
                                                                                        |
                                                                                        |
                                        enum,                                           |
                                        interface,                                      |
                                        delegate                                        |
                                                                                        |
                                                                                        |
access-modifier, return type            CLASS           struct(fields, properties)      |
                                                                                        |
                                                                                        |
                                        Base                                            |
                                        Derived                                         |
                                                                                        |
                                                                                        |
----------------------------------------------------------------------------------------


----------------------------------------------------------------------------------------
                                                                                        |
                                                                                        |
                                                                                        |
                                                                                        |
                                                                                        |
                                                                                        |
                                                                                        |
access-modifiers, return-type           METHOD          parameter                       |
                                                                                        |
                                                                                        |
                                                                                        |
                                        method body                                     |
                                                                                        |
                                                                                        |
----------------------------------------------------------------------------------------


---------------------------------------------------------------------------------
                                                                                |
                                                                                |
                                                                                |
                                                                                |
                                                                                |
                                                                                |
                                                                                |
access-modifier, return type            VARIABLE           fields, properties   |
                                                                                |
                                                                                |
                                        value                                   |
                                                                                |
                                                                                |
                                                                                |
---------------------------------------------------------------------------------



class => method => variabel
tiga2nya bisa menggunakan access-modifiers





untuk class:

access-modifiers:
1. private                  => only with the containing class
2. protected                => with in the cotaining types and the types derived from the containing types
3. public                   => anywhere, no restrictions

4. internal                 => anywhere with in the containing assembly
5. protected internal       => anywhere with in the containing assembly and from with in the derived class in any other assembly


misalnya kita INGIN MMEBUAT SUATU CLASS, DAN KITA INGIN AGAR VARIABEL YG ADA DI DALAM CLASS TSB BISA DIGUNAKAN OLEH:

                    class       Package         Subclass (same pkg)         Subclass (diff pkg)         World
public              +           +               +                           +                           +
protected           +           +               +                           +   
no modifier         +           +               +       
private             +               

+ : accessible
blank : not accessible


intinya: private - public



untuk method:

penuisan method:
1 public private 		=> access-modifiers
2 abstract partial		=> 
3 static void			=> returns-type
4 MyMethod				=> method name
5 ()					=> parameter
6 {}					=> method body 


private			=> 
public			=> 
protected       => 

abstract		=>
partial 		=>

static (static method)			=> the method belongs to the Program class and not an object of the Program class. 
void (instance method)			=> doesn't return any value back






untuk variable:








cara penulisan:
- case sensitive
- diakhiri ;
- spasi 	  ngaruh
- new line 	  ga ngaruh
- functional programming, so
- everything being write using some kind of method, but about the variable's
- namespace.class.method.variable
- namespace.parentClass.childClass.method.variable
- namespace, class, method can be change into variable
- 

inti penulisannya:

- Console.WriteLine("hello {0}", username); ====> {0} namanya placeholder
- IsNumber10
- bool IsNumber10 = number == 10 ? true : false;
- int AvaiableTickets = TicketsOnSale ?? 0;
- int.Parse(strNumber);
- bool IsConversionSuccessful = int.TryParse(strNumber, out Result);
- int[] Numbers = new int[3];
- BaseClass C = new DerivedClass(); C.Print();
- public static void Calculate(int FN, int SN, out int Sum, out int Product)
- public static void ParamsMethod(params int[] Numbers)
- public Customer()
        : this("No Firstname Provided", "No Lastname Provided")
- if (string.IsNullOrEmpty(value))
- throw new Exception("student's name cannot be null or empty");
- type casting ====> ((I2)P).InterfaceMethod();
-

inti oop:
- class-this and this-value
- virtual-override-new
- ParentClass-ChildClass and BaseClass-DerivedClass
- struct-properties and get-set
- interface-abstractClass
- public class Program : Customer
- 

kata2 baru:
- parameter (yg disini) tapi harus method
- inheritance artinya turunan/warisan
- implementation artinya { yg disini }
- explicit artinya jelas, gamblang
- intellisense artinya code completer, parameter, dsb. yg otomatis di text editor dan yg kotak kalo diarahin
- 

----------------------------------------------------------------------------------------------------------------------------------------------

using System;

class Program
{
	static void Main() 
	{
		Console.WriteLine("Welcome to C# Training");
	}

}

// CLASS CONSOLE ada didalam NAMESPACE SYSTEM
	using System;
	Console.WriteLine("Welcome to C# Training");
// NAMESPACE bisa berisikan NAMESPACE, contoh:
	using System.Configuration;
// bisa juga penuisannya begini:
	System.Console.WriteLine("Welcome to C# Training");


using System;
class Program
{
	static void Main1() 
	{
		Console.WriteLine("Welcome to C# Training 1");
	}


	static void Main() 
	{
		Console.WriteLine("Welcome to C# Training");
	}

}

// program diatas berjalan tapi hanya main methodnya saja yg di print
// jadi intinya tiap program pasti ada main method
// dan main method itu berjalan dari { hingga }


using System;
class Program
{
	static void Main1() 
	{
		Console.WriteLine("Welcome to C# Training 1");
	}


	static void Main() 
	{
		Console.WriteLine("Welcome to C# Training");
		Main1();
	}

}

// program diatas berjalan dengan menjalankan kedua method

----------------------------------------------------------------------------------------------------------------------------------------------

//using System;

//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("please enter your name");
//            string username = Console.ReadLine();
//            Console.WriteLine("hello " + username);
//            Console.ReadLine();

//    }
//}



// kalo diarahin cursor mousenya ke readline function, setelah program berjalan dan kita menekan enter, maka akan menunjukan bahwa function ini mengembalikan nilai string
// console.readline()
// string console.readline()
// string username = Console.ReadLine()

// concatenate => string + string

//shortcut untuk bikin comment ctrl+k then ctrl+c, buat ngebailikinnya ctrl+k,ctrl+u


using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("please enter your name");
        string username = Console.ReadLine();
        Console.WriteLine("hello {0}", username);
        Console.ReadLine();

    }
}

----------------------------------------------------------------------------------------------------------------------------------------------

using System;

class Program
{
    static void Main()
    {
        // boolean
        bool i = true;
        Console.WriteLine("bool i isinya {0}", i);
        Console.ReadLine();

        // integral
        int j = 123;
        Console.WriteLine("int j isinya {0}", j);
        Console.ReadLine();

        Console.WriteLine("min int = {0}", int.MinValue);
        Console.WriteLine("max int = {0}", int.MaxValue);
        Console.ReadLine();

        // floating
        double k = 12321.4355542778678;
        Console.WriteLine("double k isinya {0}", k);
        Console.ReadLine();

        Console.WriteLine("min double = {0}", double.MinValue);
        Console.WriteLine("max double = {0}", double.MaxValue);
        Console.ReadLine();
            
        // decimal
        decimal l = 1454778.55673346m;
        Console.WriteLine("decimal l isinya {0}", l);
        Console.ReadLine();

        Console.WriteLine("min decimal = {0}", decimal.MinValue);
        Console.WriteLine("max decimal = {0}", decimal.MaxValue);
        Console.ReadLine();

        string name = "\"eki\"";
        Console.WriteLine(name);
    }
}


// escape sequence => \"
//                 => \n
//                 => \\

// contoh: 
// string name = "\"eki\"";

// verbatim literal => @""

// contoh:
// "c:\\Program Files\\app\\bin\\" => @"c:\Program Files\app\bin\"


----------------------------------------------------------------------------------------------------------------------------------------------

// ---------------------------------
// -           ternary ?:          -
// ---------------------------------


using System;

class Program
{
    static void Main()
    {
        int number = 10;
        int number1 = 20;

        if (number == 10 && number1 == 20)
        {
            Console.WriteLine("Hello");
            Console.ReadLine();
        }
    }
}


using System;

class Program
{
    static void Main()
    {
        int number = 10;
        bool IsNumber10;

        if (number == 10)
        {
            IsNumber10 = true;
        }
        else
        {
            IsNumber10 = false;
        }

        Console.WriteLine("number = 10 is {0}", IsNumber10);
        Console.ReadLine();
    }
}



using System;

class Program
{
    static void Main()
    {
        int number = 10;

        bool IsNumber10 = number == 10 ? true : false;

        Console.WriteLine("number = 10 is {0}", IsNumber10);
        Console.ReadLine();
    }
}


// ternary:
// bool IsNumber10 = number == 10 ? true : false;
// bool 			=> Data Type
// IsNumber10 		=> variabel
// =				=> insert to variabel 			(EqualTo)
// number == 10		=> condition 					(IsEqualTo)
// ? true : false 	=> 								(then true else false)
// ;				=> end



// ---------------------------------
// -  null coalescing operator ??  -
// ---------------------------------

using System;

class Program
{
    static void Main()
    {
        bool? AreYouMajor = null;

        if (AreYouMajor == true)
        {
            Console.WriteLine("user is Major");
            Console.ReadLine();
        }
        else if (AreYouMajor == false)
        {
            Console.WriteLine("user is not major");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("user did not answer the question");
            Console.ReadLine();
        }
    }
}



// if (!AreYouMajor.Value)


// ada yg nullable, ada yg non-nullable
// string name = null 			bisa (karena nullable)
// int i = null 				ga bisa (karena non-nullable)
// int? i = null 				bisa 
// 
//



using System;

class Program
{
    static void Main()
    {
        int? TicketsOnSale = null;

        int AvaiableTickets;

        if (TicketsOnSale == null)
        {
            AvaiableTickets = 0;
        }
        else
        {
            AvaiableTickets = (int)TicketsOnSale.Value;
        }

        Console.WriteLine("available tickets = {0}", AvaiableTickets);
        Console.ReadLine();
    }
}



using System;

class Program
{
    static void Main()
    {
        int? TicketsOnSale = null;

        int AvaiableTickets = TicketsOnSale ?? null;

        Console.WriteLine("available tickets = {0}", AvaiableTickets);
        Console.ReadLine();
    }
}

// ga bisa. 
// karena data TicketsOnSale nya bisa null (nullable), 
// sedangkan AvailableTickets nya tidak bisa null (non-nullable)


using System;

class Program
{
    static void Main()
    {
        int? TicketsOnSale = null;

        int AvaiableTickets = TicketsOnSale ?? 0;

        Console.WriteLine("available tickets = {0}", AvaiableTickets);
        Console.ReadLine();
    }
}

----------------------------------------------------------------------------------------------------------------------------------------------

using System;

class Program
{
    static void Main()
    {
        float f = 1286476.2347899F;

        // int i = (int)f;
        int i = Convert.ToInt32(f);

        Console.WriteLine(i);
        Console.ReadLine();

    }
}





using System;

class Program
{
    static void Main()
    {
        string strNumber = "100";
        // only numbers be converted 

        int i = int.Parse(strNumber);

        Console.WriteLine(i);
        Console.ReadLine();

    }
}


using System;

class Program
{
    static void Main()
    {
        string strNumber = "100TG";

        int Result = 0;

        bool IsConversionSuccessful = int.TryParse(strNumber, out Result);

        if (IsConversionSuccessful)
        {
            Console.WriteLine(Result);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Please enter the valid number");
            Console.ReadLine();
        }

        // bool int.TryParse(string s, out int result);
        // returns: true if s was converted successfully, otherwise, false

        //int.TryParse(strNumber, out Result);
        //Console.WriteLine(Result);
        //Console.ReadLine();
    }
}



----------------------------------------------------------------------------------------------------------------------------------------------


using System;

class Program
{
    static void Main()
    {
        int[] EvenNumbers = new int[4];

        EvenNumbers[0] = 0;
        EvenNumbers[1] = 2;
        EvenNumbers[2] = 4;
        EvenNumbers[3] = 10;

        Console.WriteLine(EvenNumbers[3]);
        Console.ReadLine();

        // jumlah array yg sudah ditentukan tidak dapat ditambahkan. contoh: new int[4];
    }
}


----------------------------------------------------------------------------------------------------------------------------------------------

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Pease enter your number");

        int UserNumber = int.Parse(Console.ReadLine());

        if (UserNumber == 1)
        {
            Console.WriteLine("Your number is one");
            Console.ReadLine();
        }

        if (UserNumber == 2)
        {
            Console.WriteLine("Your number is two");
            Console.ReadLine();
        }

        if (UserNumber == 3)
        {
            Console.WriteLine("Your number is three");
            Console.ReadLine();
        }

        if (UserNumber != 1 && UserNumber != 2 && UserNumber != 3)
        {
            Console.WriteLine("Your number is not between 1 and 3");
            Console.ReadLine();
        }
    }
}



using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Pease enter your number");

        int UserNumber = int.Parse(Console.ReadLine());

        if (UserNumber == 10 || UserNumber == 20)
        {
            Console.WriteLine("your number is 10 or 20");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("your number is not 10 or 20");
            Console.ReadLine();
        }
    }
}


// double pipe || doesn't check every condition, once it meets the true condition, it stops and run the program
// single pipe | checks every condition
// double and && doesn't check every condition, it doesn't stops even when thereis already false condition
// single and & checks every condition, evenwhen it aready knows it's true or false


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Pease enter your number");

        int UserNumber = int.Parse(Console.ReadLine());

        switch (UserNumber)
        {
            case 10:
                Console.WriteLine("Your Number is 10");
                Console.ReadLine();
                break;
            case 20:
                Console.WriteLine("Your Number is 20");
                Console.ReadLine();
                break;
            case 30:
                Console.WriteLine("Your Number is 30");
                Console.ReadLine();
                break;
            default:
                Console.WriteLine("Your Number is not 10, 20, and 30");
                Console.ReadLine();
                break;
        }
    }
}


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Pease enter your number");

        int UserNumber = int.Parse(Console.ReadLine());

        switch (UserNumber)
        {
            case 10:
            case 20:
            case 30:
                Console.WriteLine("Your Number is {0}", UserNumber);
                Console.ReadLine();
                break;
            default:
                Console.WriteLine("Your Number is not 10, 20, and 30");
                Console.ReadLine();
                break;
        }
    }
}


using System;

class Program
{
    static void Main()
    {
        int TotalUserCost = 0;
        
        start:

        Console.WriteLine("Please select your coffe size : 1 - small, 2 - medium, 3 - large");

        int UserChoice = int.Parse(Console.ReadLine());

        switch (UserChoice)
        {
            case 1:
                TotalUserCost += 1;
                break;
            case 2:
                TotalUserCost += 2;
                // goto case 1;
                break;
            case 3:
                TotalUserCost += 3;
                break;
            default:
                Console.WriteLine("Your choice invalid..");
                goto start;
        }

        decide:

        Console.WriteLine("Do you want to buy more? answer with 'yes' or 'no'");
        string UserDecision = Console.ReadLine();

        switch (UserDecision.ToUpper())
        {
            case "YES":
                goto start;
            case "NO":
                break;
            default:
                Console.WriteLine("your choice, {0} is invalid. Please try again..", UserDecision);
                goto decide;

        }

        Console.WriteLine("Thank You for shopping with us");
        Console.WriteLine("Your total costs {0}", TotalUserCost);
        Console.ReadLine();
    }
}

// using goto is impolite


using System;

class Program
{
    static void Main()
    {
        int TotalUserCost = 0;

        int UserChoice = 0;

        string UserDecision = "";

        do
        {
            do
            {
                Console.WriteLine("Please select your coffe size : 1 - small, 2 - medium, 3 - large");

                UserChoice = int.Parse(Console.ReadLine());

            } while (UserChoice != 1 && UserChoice != 2 && UserChoice != 3);

            switch (UserChoice)
            {
                case 1:
                    TotalUserCost += 1;
                    break;
                case 2:
                    TotalUserCost += 2;
                    // goto case 1;
                    break;
                case 3:
                    TotalUserCost += 3;
                    break;
                default:
                    break;
            }
            
            do
            {
                Console.WriteLine("Do you want to buy more? answer with 'yes' or 'no'");
                UserDecision = Console.ReadLine().ToUpper();

            } while (UserDecision != "YES" && UserDecision != "NO");
        } while (UserDecision != "NO");

        Console.WriteLine("Thank You for shopping with us");
        Console.WriteLine("Your total costs {0}", TotalUserCost);
        Console.ReadLine();
    }
}


----------------------------------------------------------------------------------------------------------------------------------------------


using System;

class Program
{
    static void Main()
    {
        string UserChoice = "";

        do
        {
            Console.WriteLine("Please enter the target");

            int UserTarget = int.Parse(Console.ReadLine());

            int start = 0;

            while (start <= UserTarget)
            {
                Console.Write(start + " ");
                start = start + 2;
            }

            do
            {
                Console.WriteLine(" ");
                Console.WriteLine("Do you want to continue? (\"yes\" or \"no\")");
                UserChoice = Console.ReadLine().ToLower();

                if (UserChoice != "yes" && UserChoice != "no")
                {
                    Console.WriteLine("invalid choice, please say yes or no");
                }
            } while (UserChoice != "yes" && UserChoice != "no");
        } while (UserChoice == "yes");



    }
}


----------------------------------------------------------------------------------------------------------------------------------------------

using System;

class Program
{
    static void Main()
    {
        int[] Numbers = new int[3];

        Numbers[0] = 101;
        Numbers[1] = 102;
        Numbers[2] = 103;

        int i = 0;

        while (i < Numbers.Length)
        {
            Console.WriteLine(Numbers[i]);
            i++;
        }

        for ( int j = 0 ; j < Numbers.Length ; j++)
        {
            Console.WriteLine(Numbers[j]);
        }

        foreach (int k in Numbers)
        {
            Console.WriteLine(Numbers[k]);
        }

    }
}

----------------------------------------------------------------------------------------------------------------------------------------------











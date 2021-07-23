



partial class is allow us to split a class into two or more phisical files
all these phisical parts/files are then combined into one single class, when the application is compiled
the partial keyword(partial on axxess-modifier) is can also be used to split a struct or an interface over two or more files.


klik kanan di consoleApp1 di kanan(Solution explorer) -> new -> class
namespace harus sama,
access-modifier public partial.

using System;

//file utama(ConsoleApp1)
public class Customer
{
    private string _firstName;
    private string _lastName;

    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }

    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value; }
    }

    public string GetFullName()
    {
        return _firstName + ", " + _lastName;
    }
}

//file2 (PartialClass1)
public partial class PartialCustomer
{
    private string _firstName;
    private string _lastName;

    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }

    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value; }
    }
}

//file3 (PartialClass2)
public partial class PartialCustomer
{
    public string GetFullName()
    {
        return _firstName + ", " + _lastName;
    }
}


//file utama(ConsoleApp1)
public class MainClass
{
    public static void Main()
    {
        Customer c1 = new Customer();
        c1.FirstName = "Pragim";
        c1.LastName = "Technologies";

        string FullName1 = c1.GetFullName();
        Console.WriteLine("Full Name = " + FullName1);


        PartialCustomer c2 = new PartialCustomer();
        c2.FirstName = "Pragim";
        c2.LastName = "Tech";

        string FullName2 = c2.GetFullName();
        Console.WriteLine("Full Name = " + FullName2);

        Console.ReadLine();
    }
}



----------------------------------------------------------------------------------------------------------------------------------------------






1. All the parts spread across different files, must use the partial keyword. Otherwise a compiler error is raised. 
Missing partial modifier. Another partial declaration of this type exists

2. All the parts spread across different files, must have the same access modifiers. Otherwise a compiler error is raised. 
Partial declarations have conflicting accessibility modifiers

3. If any of the parts are declared abstract, then the entire type is considered abstract.

4. If any of the parts are declared sealed, then the entire type is considered sealed. 

5. If any of the parts inherit a class, then the entire type inherits that class.

6. C# does not support multiple class inheritance. Different parts of the partial class, must not specify different base classes. The following code will raise a compiler error stating - Partial declarations must not specify different base classes.
public partial class SamplePartialClass : Employee
{
}
public partial class SamplePartialClass : Customer
{
}
public class Employee
{
}
public class Customer
{
}

7. Different parts of the partial class can specify different base interfaces, and the final type implements all of the interfaces listed by all of the partial declarations. In the example below, SamplePartialClass needs to provide implementation for both IEmployee, and ICustomer interface methods.

public partial class SamplePartialClass : IEmployee
{
    public void EmployeeMethod()
    {
        //Method Implementation
    }
}
public partial class SamplePartialClass : ICustomer
{
    public void CustomerMethod()
    {
        //Method Implementation
    }
}
public interface IEmployee
{
    void EmployeeMethod();
}
public interface ICustomer
{
    void CustomerMethod();
}

8. Any members that are declared in a partial definition are available to all of the other parts of the partial class.



----------------------------------------------------------------------------------------------------------------------------------------------

Partial methods in C# - Part 63

A partial class or a struct can contain partial methods. A partial method is created using the partial keyword. Let us understand partial methods with an example. Create a console application. Add a class file, with name PartialClassFileOne.cs, to the project. copy and paste the following code.

Notice, that, the SampleMethod() definition has the partial keyword, and does not have a body(implementation) only the signature. The implementation for a partial method is optional. If we don't provide the implementation, the compiler removes the signature and all calls to the method.

The implementation can be provided in the same physical file, or in another physical file, that contains the partial class. In this example, the partial SampleMethod() is invoked in the PublicMethod().
partial class SampleClass
{
    // Declaration of the partial method.
    partial void SampleMethod();

    // A public method calling the partial method
    public void PublicMethod()
    {
        Console.WriteLine("Public Method Invoked");
        SampleMethod();
    }
}


 

Copy and paste the following code in the Main() method of the console application. When we run the application now, notice that, we don't get a compiler error, in spite of not having an implementation for the partial SampleMethod(). Since, the implementation for the partial method is missing, the compiler will remove the signature and all calls to the method.
SampleClass SC = new SampleClass();
SC.PublicMethod();

Now, add a class file, with name PartialClassFileTwo.cs. Copy and paste the following code. The implementation for the partial method is provided here.
partial class SampleClass
{
    // Partial method implemented
    partial void SampleMethod()
    {
        Console.WriteLine("Partial SampleMethod Invoked");
    }
}


 

Now, run the console application and notice the output. The partial method and the public method messages are printed on the console. 

A partial method declaration consists of two parts. 
1. The definition (only the method signature ending with a semi-colon, without method body)
2. The implementation. 
These may be in separate parts of a partial class, or in the same part.

Partial methods are private by default, and it is a compile time error to include any access modifiers, including private. The following code will raise an error stating - A partial method cannot have access modifiers or the virtual, abstract, override, new, sealed, or extern modifiers.
partial class SampleClass
{
    private partial void SampleMethod();
}

It is a compile time error, to include declaration and implementation at the same time for a partial method. Code below produces a compile time error - No defining declaration found for implementing declaration of partial method 'PartialMethodsDemo.SampleClass.SampleMethod()'
partial class SampleClass
{
    partial void SampleMethod()
    {
        Console.WriteLine("SampleMethod Implemented");
    }
}

A partial method return type must be void. Including any other return type is a compile time error - Partial methods must have a void return type
partial class SampleClass
{
    partial int SampleMethod();
}

A partial method must be declared within a partial class or partial struct. A non partial class or struct cannot include partial methods.

Signature of the partial method declaration, must match with the signature of the implementation.

A partial method can be implemented only once. Trying to implement a partial method more than once, raises a compile time error - A partial method may not have multiple implementing declarations.


//file utama (ConsoleApp1)

using System;
namespace ConsoleApp1
{


    public class MainClass
    {
        public static void Main()
        {
            SamplePartialClass SPC = new SamplePartialClass();
            SPC.PublicMethod();

            Console.ReadLine();
        }
    }
}



//file2 (PartialClass1)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public partial class PartialClass1
    {

    }

    public partial class SamplePartialClass
    {
        partial void SamplePartialMethod()
        {
            Console.WriteLine("SamplePartialMethod invoked");
        }
    }
}




//file3 (PartialClass2)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public partial class PartialClass2
    {
    }

    public partial class SamplePartialClass
    {

        partial void SamplePartialMethod();

        public void PublicMethod()
        {
            Console.WriteLine("PublicMethod invoked");
            SamplePartialMethod();
        }
    }
}




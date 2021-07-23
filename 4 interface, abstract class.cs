// classes has properties, methods, delegates, events
// interface is the same as classes but only declaration, not implementation



using System;

// interface name have to have an 'I' 
interface ICustomer1
{
    // interface cannot have an implementation
    void Print1();
}

interface ICustomer2 : ICustomer1 // inherit  
{
    void Print2();
}

public class Customer : ICustomer2
{
    public void Print1()
    {
        Console.WriteLine("Print1");
    }

    public void Print2()
    {
        Console.WriteLine("Print2");
    }
}



class Program
{
    static void Main()
    {
        ICustomer1 C1 = new Customer();
        C1.Print1();

        ICustomer2 C2 = new Customer();
        C2.Print2();
        Console.Read();
    }
}


// explicit artinya jelas, gamblang

using System;

interface I1
{
    void InterfaceMethod();
}

interface I2
{
    void InterfaceMethod();
}


public class Program : I1, I2
{
    void I1.InterfaceMethod()
    {
        Console.WriteLine("I1 interface Method");
    }

    void I2.InterfaceMethod()
    {
        Console.WriteLine("I2 interface method");
    }


    static void Main()
    {


        //Program P = new Program();
        //// type casting
        //((I1)P).InterfaceMethod();
        //((I2)P).InterfaceMethod();




        //I1 I1 = new Program();
        //I2 I2 = new Program();

        //I1.InterfaceMethod();
        //I2.InterfaceMethod();

        Console.Read();
    }
}







using System;

interface I1
{
    void InterfaceMethod();
}

interface I2
{
    void InterfaceMethod();
}


public class Program : I1, I2
{
    public void InterfaceMethod()
    {
        Console.WriteLine("I1 interface Method");
    }

    void I2.InterfaceMethod()
    {
        Console.WriteLine("I2 interface method");
    }


    static void Main()
    {


        //Program P = new Program();
        //// type casting
        //((I1)P).InterfaceMethod();
        //((I2)P).InterfaceMethod();




        //I1 I1 = new Program();
        //I2 I2 = new Program();

        //I1.InterfaceMethod();
        //I2.InterfaceMethod();




        Program P = new Program();
        P.InterfaceMethod();
        ((I2)P).InterfaceMethod();



        Console.Read();
    }
}





using System;

interface I2
{
    void InterfaceMethod();
}


public class Program : I2
{
    // default
    public void InterfaceMethod()
    {
        Console.WriteLine("default Method");
    }

    void I2.InterfaceMethod()
    {
        Console.WriteLine("I2 interface method");
    }


    static void Main()
    {
        Program P = new Program();
        P.InterfaceMethod();
        ((I2)P).InterfaceMethod();

        Console.Read();
    }
}






// abstract cannot have an implementation
// abstract classes can only be used as a base class (masih bingung)
// kalo ada class yg inherit ke abstract classes, ada 2 pilihan:
// 1. menyediakan implementation untuk semua abstract class members
// 2. class harus didefinisikan sebagai abstract class (masih bingung tapi kayanya kurang berguna)


using System;

public abstract class Customer
{
    public abstract void Print();
}

public class Program : Customer
{
   public override void Print()
    {
        Console.WriteLine("Print Method");
    }


    static void Main()
    {
        Customer C = new Program();
        C.Print();

        Console.Read();
    }
}






using System;

public abstract class Customer
{
    public void Print()
    {
        Console.WriteLine("Print");
    }
}

public class Program : Customer
{
   //public override void Print()
   // {
   //     Console.WriteLine("Print Method");
   // }


    static void Main()
    {
        //Customer C = new Program();
        //C.Print();

        //Console.Read();
    }
}


// sealed : if we want to prevent your class from the inheritance
// abstract class cannot be sealed
// abstract means can only be used as a base class
// sealed means cannot be used as a base class

using System;

// ga bisa
public abstract sealed class Customer
{
    public abstract void Print();
}

public class Program : Customer
{
   public override void Print()
    {
        Console.WriteLine("Print Method");
    }


    static void Main()
    {
        Customer C = new Program();
        C.Print();

        Console.Read();
    }
}






using System;

public abstract class Customer
{
    public void Print()
    {
        Console.WriteLine("Print");
    }
}

public class Program : Customer
{
   //public override void Print()
   // {
   //     Console.WriteLine("Print Method");
   // }


    static void Main()
    {
        //Customer C = new Program();
        //C.Print();

        //Console.Read();
    }
}


// interface can't have implementation
// abstract class can have an implementation on its members(methods)

// interface can inherit from interface only
// class can inherit from class and interface

// cannot build any fields/struct on interface
// can build a fields/struct on class

// an interface can inherit a lot of interfaces (multiple interface)
// a class cannot inherit more than one class or interface (multiple class, yg tidak ada)

// interface cannot have an access modifier
// abstract class can have a access-modifier


using System;

// bisa
public abstract class Customer
{
    public void Print()
    {
        Console.WriteLine("Print");
    }
}

// ga bisa
public interface ICustomer
{
    public void Print()
    {
        Console.WriteLine("Print");
    }
}

public class Program : Customer
{

    static void Main()
    {

    }
}





using System;

public abstract class Customer
{
    // bisa
    int ID;

    public void Print()
    {
        Console.WriteLine("Print");
    }
}

public interface ICustomer
{
    // ga bisa
    int ID;

    public void Print()
    {
        Console.WriteLine("Print");
    }
}

public class Program : Customer
{

    static void Main()
    {

    }
}





using System;

public abstract class Customer
{
    int ID;

    public void Print() // bisa
    {
        Console.WriteLine("Print");
    }
}

public interface ICustomer
{

    //public void Print(); // gabisa
    void Print(); // bisa
}

public class Program : Customer
{

    static void Main()
    {

    }
}



// why is multiple class forbidden? 


using System;
class A
{
    public virtual void Print()
    {
        Console.WriteLine("A implementation");
    }
}

class B : A
{
    public override void Print()
    {
        Console.WriteLine("B implementation");
    }
}


class C : A
{
    public override void Print()
    {
        Console.WriteLine("C implementation");
    }
}

class D : B
{
    
}

public class Program
{

    static void Main()
    {
        D d = new D();
        d.Print();
        Console.Read();
    }
}



// so how to make it?


using System;

interface IA
{
    void AMethod();
}
class A
{
    public void AMethod()
    {
        Console.WriteLine("A");
    }
}

interface IB
{
    void BMethod();
}
class B 
{
    public void BMethod()
    {
        Console.WriteLine("B");
    }
}


class AB : IA, IB
{
    A a = new A();
    B b = new B();

    public void AMethod()
    {
        a.AMethod();
    }

    public void BMethod()
    {
        b.BMethod();
    }
}

public class Program
{

    static void Main()
    {
        AB ab = new AB();
        ab.AMethod();
        ab.BMethod();


        Console.Read();
    }
}
// instance method (void)


using System;

class Program
{
    static void Main()
    {
        Program p = new Program();
        p.EvenNumbers();
    }

    public void EvenNumbers()
    {
        int start = 0;
        while (start <= 20)
        {
            Console.WriteLine(start);
            start = start + 2;
        }
        Console.ReadLine();
    }

}


// static method (static void)


using System;

class Program
{
    static void Main()
    {
        Program.EvenNumbers();
    }

    public static void EvenNumbers()
    {
        int start = 0;
        while (start <= 20)
        {
            Console.WriteLine(start);
            start = start + 2;
        }
        Console.ReadLine();
    }

}




using System;

class Program
{
    static void Main()
    {
        Program.EvenNumbers(30);

        Program p = new Program();
        int sumResult = p.Sum(10,20);

        Console.WriteLine("Sum = {0}", sumResult);
        Console.ReadLine();
    }

    public int Sum(int FN, int SN)
    {
        return FN + SN;
    }

    public static void EvenNumbers(int Target)
    {
        int start = 0;
        while (start <= Target)
        {
            Console.WriteLine(start);
            start = start + 2;
        }
        Console.ReadLine();
    }

}


----------------------------------------------------------------------------------------------------------------------------------------------



using System;

class Program
{
    static void Main()
    {
        int i = 0;

        SimpleMethod(ref i);

        Console.WriteLine(i);
        Console.ReadLine();

    }

    public static void SimpleMethod(ref int j)
    {
        j = 101;
    }
}

// kalo gapake ref jadinya di consolenya hasilnya 0 (pass by value)
// kalo pake ref jadinya di consolnya hasilnya 101 (pass by reference)

// kalo gapake ref i memiliki penempatan memorynya sendiri, dan j memiliki penempatan memorynya sendiri
// kalo pake ref i memiliki penempatan memory, yg berikutnya j meletakkan penempata memorynya sama dengan i, lalu merubah nilainya

// ibarat kalo yg gapake ref itu kaya si i punya kue, nah si j juga punya kue, tapi ga bisa saling memakan kue milik orang lain
// ibarat kalo yg pake ref itu kaya si i naro kue di meja, nah terus si j makan kuenya


using System;

class Program
{
    static void Main()
    {
        int Total = 0;
        int Product = 0;

        Calculate(10, 20, out Total, out Product);

        Console.WriteLine("Total = {0} && Product = {1}", Total, Product);
        Console.ReadLine();

    }

    public static void Calculate(int FN, int SN, out int Sum, out int Product)
    {
        Sum = FN + SN;
        Product = FN * SN;
    }
}



using System;

class Program
{
    static void Main()
    {
        int[] Numbers = new int[3];

        Numbers[0] = 101;
        Numbers[1] = 102;
        Numbers[2] = 103;

        //ParamsMethod();
        //ParamsMethod(Numbers);
        ParamsMethod(1, 2, 3, 4, 5, 6, 7, 8, 9);
        Console.ReadLine();
    }

    public static void ParamsMethod(params int[] Numbers)
    {
        Console.WriteLine("There are {0} elements", Numbers.Length);

        foreach (int i in Numbers)
        {
            Console.WriteLine(i);
        }
    }
}


// params array has to be the last one
// you can't have 2 or more params

// argument, ParamsMethod(1,2,3,4,5),         
        //ParamsMethod();
        //ParamsMethod(Numbers);
        //ParamsMethod(1, 2, 3, 4, 5, 6, 7, 8, 9);
// parameter, ParamsMethod(params int[] Numbers)



----------------------------------------------------------------------------------------------------------------------------------------------


using System;
using PATA = ProjectA.TeamA;
using PATB = ProjectA.TeamB;

class Program
{
    static void Main()
    {
        PATA.classA.Print();
        PATB.classA.Print();
        Console.ReadLine();
    }

}


namespace ProjectA 
{ 
    namespace TeamA
    {
        class classA
        {
            public static void Print()
            {
                Console.WriteLine("Team A Print Method");
            }
        }
    }
}

namespace ProjectA
{
    namespace TeamB
    {
        class classA
        {
            public static void Print()
            {
                Console.WriteLine("Team B Print Method");
            }
        }
    }
}

// 1. klik kanan di solution 'ProjectName' (kanan)
// 2. add
// 3. new project
// 4. pilih class library, a project for creating a C# library (.dll)
// 5. Project Name : ProjectA.TeamA
// 6. rename class1.cs menjadi classA.cs
// 7. buka aplikasi dissambler ildasm.exe, C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.8 Tools 
// 8. klik kana di consoleApp1 (solution name), add reference
// 9. check ProjectA.TeamA, submit


using System;
using ProjectA.TeamA;
using PATB = ProjectA.TeamB;

class Program
{
    static void Main()
    {
        ProjectA.TeamA.ClassA.Print();
        PATB.ClassA.Print();
        Console.ReadLine();
    }

}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA
{
    namespace TeamB
    {
        public class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team B");
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA
{
    namespace TeamA
    {
        public class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team A");
            }
        }
    }
}

// a namespace can contain :
// 1. namespace
// 2. class
// 3. interface
// 4. struct
// 5. enum
// 6. delegate


----------------------------------------------------------------------------------------------------------------------------------------------

// Class Customer => class has, data and behaviour
// a class basically has fields(or fills),  
//    string _firstname;
//    string _lastname;
// a contstructor has the same name as class name, this._firstname itu sama dengan Customer._firstname   
// a class has a class body

// Class Program
// make a variabel for that class, Customer C1 = new Customer("Eki", "S.Kom");
// (that variabel).(the method you want), C1.PrintFullName();


using System;


class Customer
{
    string _firstname;
    string _lastname;

    public Customer()
        : this("No Firstname Provided", "No Lastname Provided")
    {

    }

    public Customer(string Firstname, string Lastname)
    {
        this._firstname = Firstname;
        this._lastname = Lastname;
    }

    public void PrintFullName()
    {
        Console.WriteLine("Full Name = {0}", this._firstname + " " + this._lastname);
        Console.ReadLine();
    }

    ~Customer()
    {

    }
}

class Program
{
    static void Main()
    {
        Customer C1 = new Customer("Eki", "S.Kom");
        C1.PrintFullName();

        Customer C2 = new Customer("P", "T");
        C2.PrintFullName();
    }

}


// static and void
// return type (static/void) itu yg dibalikin.
// jadi kalo gaada yg dibalikin, void
// kalo ada yg dibalikin, tergantung yg dibalikin (int/float)






// static and instance(arti inheritance ialah warisan atau turunan)
// static means it wouldn't change, for example float _Pi = 3.141;
// the advantage is less in memory, it just record one, no need more

// static members can't be called by (this), instead of (class name).
// for example, from this._Pi to Circle._Pi
// karena this refers to Circle C1 = new Circle(5);

// static method can't be the variable you made, instead of (class name).
// for example, from C1.Print() to Circle.Print()
// karena di C1 ada unsur yg mengakibatkan itu bisa berubah2 (5), Circle C1 = new Circle(5);



using System;


class Circle
{
    float _Pi = 3.141F;
    int _Radius;

    public Circle(int Radius)
    {
        this._Radius = Radius;
    }
    
    public float CalculateArea()
    {
        return this._Pi * this._Radius * this._Radius;
    }

    public void Print()
    {
        //
    }

}

class Program
{
    static void Main()
    {
        Circle C1 = new Circle(5);
        float Area1 = C1.CalculateArea();
        Console.WriteLine("Area1 = {0}", Area1);

        Circle C2 = new Circle(7);
        float Area2 = C2.CalculateArea();
        Console.WriteLine("Area2 = {0}", Area2);
        Console.ReadLine();
    }

}


----------------------------------------------------------------------------------------------------------------------------------------------


// public Circle(int Radius){} => kalo public nya diilangin, 
// jadinya Circle(int Radius){} 
// dengan pengertian private Circle(int Radius){}

// you can only access a private method inside its class
// jadi gabisa dipanggil dari luar class tersebut

// tambahin public kalo mau akses/manggil dari luar class dan
// (class name).(method name)



using System;


class Circle
{
    static float _Pi;
    int _Radius;

    static Circle()
    {
        Console.WriteLine("static constructor's called");
        Circle._Pi = 3.141F;
    }

    public Circle(int Radius)
    {
        Console.WriteLine("instance constructor's called");
        this._Radius = Radius;
    }
    
    public float CalculateArea()
    {
        return Circle._Pi * this._Radius * this._Radius;
    }

    public void Print()
    {
        //
    }

}

class Program
{
    static void Main()
    {
        Circle C1 = new Circle(5);
        float Area1 = C1.CalculateArea();
        Console.WriteLine("Area1 = {0}", Area1);

        Circle C2 = new Circle(7);
        float Area2 = C2.CalculateArea();
        Console.WriteLine("Area2 = {0}", Area2);
        Console.ReadLine();
    }

}







// inheritance dekat dengan specialization
public still confusing

// pillars of oop:
// 1. inheritance
// 2. encapsulation
// 3. abstraction
// 4. polymorphism

// 1. inheritance
// hierarchy
// pola pikir harus dinamis, jangan pake pola pikir yg sama terus di level teratas, bawahnya teratas, bawahnya lagi, dst dalam hierarchy
// namespace, class, method, variabel
// dinamis artinya cara penulisannya bisa dari atas ke bawah, bisa dari bawah ke atas



// jadi, satu turunan class (atau child class) ga bisa held lebih dari satu parent class (base class)
// base refers to Parent class

public class Employee
{

}

public class A
{

}

public class PartTimeEmployee : Employee, A
{
    
}


// bisanya begini

public class Employee
{

}

public class PartTimeEmployee : Employee
{
    
}

public class A : PartTimeEmployee
{

}


class Program
{
    static void Main()
    {
        A A1 = new A();
        A1
    }

}

// A1 is avalable for everything there (PartTimeEmployee and Employee)

using System;


public class Employee
{
    public string FirstName;
    public string LastName;
    public string Email;

}


public class FullTimeEmployee : Employee
{
    public float YearlySalary;
}

public class PartTimeEmployee : Employee
{
    public float HourlyRate;
}


class Program
{
    static void Main()
    {
        FullTimeEmployee FTE = new FullTimeEmployee();
        FTE.FirstName = "Eki";
        FTE.LastName = "S.Kom";
        FTE.YearlySalary = 500000;
        FTE.PrintFullName();
    }

}


// penamaan child class dengan menambahkan :
// public class ChildClass : ParentClass


using System;


public class ParentClass
{
    public ParentClass()
    {
        Console.WriteLine("ParentClass constructed called");
    }
}

public class ChildClass : ParentClass
{
    public ChildClass()
    {
        Console.WriteLine("ChildClass constructed called");
    }
}

class Program
{
    static void Main()
    {
        ChildClass CC = new ChildClass();
        Console.Read();
    }

}



using System;


public class ParentClass
{
    public ParentClass()
    {
        Console.WriteLine("ParentClass constructed called");
    }

    public ParentClass(string Message)
    {
        Console.WriteLine(Message);
    }
}

public class ChildClass : ParentClass
{
    public ChildClass()// : base("DerivedClass controlling ParentClass")
    {
        Console.WriteLine("ChildClass constructed called");
    }
}

class Program
{
    static void Main()
    {
        ChildClass CC = new ChildClass();
        Console.Read();
    }

}



// ChildClass lebih besar dari ParentClass
// karena ChildClass bisa mengontrol method apa saja yg ada di ParentClass, mengontrol dalam artian menggunakan variable dan methods yg ada di ParentClass
// karena ChildClass bisa menyembunyikan method yg ada di ParentClass, dengan cara menamainya dengan sama
//

using System;


public class Employee
{
    public string FirstName;
    public string LastName;

    public void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}


public class FullTimeEmployee : Employee
{

}

public class PartTimeEmployee : Employee
{
    public new void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " - Contractor");
    }
}


class Program
{
    static void Main()
    {
        FullTimeEmployee FTE = new FullTimeEmployee();
        FTE.FirstName = "FullTime";
        FTE.LastName = "Employee";
        FTE.PrintFullName();

        PartTimeEmployee PTE = new PartTimeEmployee();
        PTE.FirstName = "PartTime";
        PTE.LastName = "Employee";
        PTE.PrintFullName();


        Console.Read();
    }

}





using System;


public class Employee
{
    public string FirstName;
    public string LastName;

    public void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}


public class FullTimeEmployee : Employee
{

}

public class PartTimeEmployee : Employee
{
    public new void PrintFullName()
    {
        //base.PrintFullName();
        Console.WriteLine(FirstName + " " + LastName + " - Contractor");
    }
}


class Program
{
    static void Main()
    {
        FullTimeEmployee FTE = new FullTimeEmployee();
        FTE.FirstName = "FullTime";
        FTE.LastName = "Employee";
        FTE.PrintFullName();

        //PartTimeEmployee PTE = new PartTimeEmployee();
        
        Employee PTE = new PartTimeEmployee(); //ini bisa
        //PartTimeEmployee PTE = new Employee(); //ini gabisa
        
        PTE.FirstName = "PartTime";
        PTE.LastName = "Employee";
        PTE.PrintFullName();
        //((Employee)PTE).PrintFullName();

        Console.Read();
    }

}




// 4. polymorphism
// polymorphism basically allows you to invoke derived class methods through a base class reference during runtime
// masih bingung virtual - override - new


using System;


public class Employee
{
    public string FirstName = "FN";
    public string LastName = "SN";

    public virtual void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}


public class FullTimeEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " - Full Time ");
    }
}

public class PartTimeEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " - Part Time ");
    }
}

public class TemporaryEmployee : Employee
{
  
}


class Program
{
    static void Main()
    {
        Employee[] employees = new Employee[4];

        employees[0] = new Employee();
        employees[1] = new FullTimeEmployee();
        employees[2] = new PartTimeEmployee();
        employees[3] = new TemporaryEmployee();

        foreach (Employee e in employees)
        {
            e.PrintFullName();
        }

        Console.Read();

    }

}




----------------------------------------------------------------------------------------------------------------------------------------------

// method hide and method override


using System;

class BaseClass
{
    public virtual void Print()
    {
        Console.WriteLine("This is BaseClass");
    }
}

class DerivedClass : BaseClass
{
    public override void Print()
    {
        Console.WriteLine("This is DerivedClass");
    }
}

class Program
{
    static void Main()
    {
        BaseClass B = new DerivedClass();
        B.Print();




        Console.Read();
    }
}








using System;

class BaseClass
{
    public virtual void Print()
    {
        Console.WriteLine("This is BaseClass");
    }
}

class DerivedClass : BaseClass
{
    public new void Print()
    {
        Console.WriteLine("This is DerivedClass");
    }
}

class Program
{
    static void Main()
    {
        BaseClass B = new DerivedClass();
        B.Print();




        Console.Read();
    }
}







using System;

class BaseClass
{
    public virtual void Print()
    {
        Console.WriteLine("This is BaseClass");
    }
}

class DerivedClass : BaseClass
{
    public override void Print()
    {
        Console.WriteLine("This is DerivedClass");
    }
}

class Program
{
    static void Main()
    {
        BaseClass C = new DerivedClass();
        C.Print();


        BaseClass B = new BaseClass();
        B.Print();


        DerivedClass D = new DerivedClass();
        D.Print();


        //DerivedClass A = new BaseClass();
        //A.Print();


        Console.Read();
    }
}


----------------------------------------------------------------------------------------------------------------------------------------------

// we can overload a method based on the number of parameters

using System;

class Program
{
    static void Main()
    {
        
    }

    public static void Add(int FN, int SN)
    {
        Console.WriteLine("Sum = {0}", FN + SN);
    }

    public static void Add(int FN, int SN, int TN)
    {
        Console.WriteLine("Sum = {0}", FN + SN);
    }

    public static void Add(int FN, int SN, int TN, int FourthNumber)
    {
        Console.WriteLine("Sum = {0}", FN + SN);
    }




}




// we can overload a method based on the



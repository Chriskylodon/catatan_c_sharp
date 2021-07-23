using System;

public class Customer
{
    #region Fields
    private int _id;
    private string _firstname;
    private string _lastname;
    #endregion

    #region Properties
    public int Id
    {
        get { return this._id; }
        set { this._id = value; }
    }

    public string FirstName
    {
        get { return this._firstname; }
        set { this._firstname = value; }
    }

    public string LastName
    {
        get { return this._lastname; }
        set { this._lastname = value; }
    }
    #endregion

    #region Methods
    public string GetFullName()
    {
        return this._firstname + " " + this._lastname;
    }
    #endregion
}

class Program
{
    public static void Main()
    {

        Console.Read();
    }
}










using System;

public class Customer
{
    private int _id = 1;

    public int ID
    {
        get
        { return _id; }
        set
        { this._id = value; }
    }
}

class Program
{
    public static void Main()
    {
        Customer C1 = new Customer();
        Console.WriteLine(C1.ID);

        Console.Read();
    }
}








using System;

public class Customer
{
    private int _id = 1;

    public int ID
    {
        get
        { return _id; }
        set
        { this._id = value; }
    }
}

class Program
{
    public static void Main()
    {
        Customer C1 = new Customer();
        Console.WriteLine(C1._id);

        Console.Read();
    }
}












using System;

public class Customer
{
    protected int ID;

}

public class CorporateCustomer : Customer
{
    public void PrintID()
    {
        CorporateCustomer CC = new  CorporateCustomer();
        CC.ID = 101;

        Console.WriteLine(CC.ID);
    }
}

class Program
{
    public static void Main()
    {
        //Customer C1 = new Customer();
        //Console.WriteLine(C1.ID);

        CorporateCustomer CCc = new CorporateCustomer();
        CCc.PrintID();

        Console.Read();
    }
}



----------------------------------------------------------------------------------------------------------------------------------------------





// on the solution, right click -> open folder location
// on the solution, add -> new project -> class library
// right click, add -> reference

// program.cs
using System;
using AssemblyTwo;

public class Customer
{
    protected int ID;

}

public class CorporateCustomer : Customer
{
    public void PrintID()
    {
        CorporateCustomer CC = new  CorporateCustomer();
        CC.ID = 10100;

        Console.WriteLine(CC.ID);
    }
}

class Program
{
    public static void Main()
    {
        //Customer C1 = new Customer();
        //Console.WriteLine(C1.ID);

        CorporateCustomer CCc = new CorporateCustomer();
        CCc.PrintID();

        AssemblyTwoClass1 A2 = new AssemblyTwoClass1();
        A2.Print();

        Console.Read();
    }
}





// AssemblyOne -> Class1
using System;

namespace AssemblyOne
{
    public class AssemblyOneClass1
    {
        // delete the "protected" to see the difference between internal and protected internal access-modifier
        protected internal int ID = 101;
    }

    public class AssemblyOneClass11
    {
        public void SampleMethod()
        {
            AssemblyOneClass1 A1 = new AssemblyOneClass1();
            Console.WriteLine(A1.ID);
        }
    }
}








// AssemblyTwo -> class1
using System;
using AssemblyOne;

namespace AssemblyTwo
{
    public class AssemblyTwoClass1 : AssemblyOneClass1
    {
        public void Print()
        {
            AssemblyOneClass1 A1 = new AssemblyOneClass1();
            base.ID = 101;
            //A1.ID = 102;

            AssemblyTwoClass1 A2 = new AssemblyTwoClass1();
            A2.ID = 102;

            AssemblyOneClass11 A11 = new AssemblyOneClass11();
            A11.SampleMethod();
        }
    }
}


// for type members, it could have 5 access-modifier (private, protected, public, internal, protected internal)
// for types, it could only have two access-modifier (public or internal) 

// for type members, no access modifier would use the default which is private
// for types, no access modifier would use the default which is internal

// gambarannya, using assembly itu artinya kaya taro codingan assemblynya di atas codingannya


// Assemblyone:
using System;

namespace AssemblyOne
{
    //public class AssemblyOneClass1
    //{
    //    protected internal int ID = 101;
    //}

    //public class AssemblyOneClass11
    //{
    //    public void SampleMethod()
    //    {
    //        AssemblyOneClass1 A1 = new AssemblyOneClass1();
    //        Console.WriteLine(A1.ID);
    //    }
    //}



    public class AssemblyOneClass
    {
        public void Print()
        {
            Console.WriteLine("Hello");
        }
    }
}




//AssemblyTwo
using System;
using AssemblyOne;

namespace AssemblyTwo
{
    //public class AssemblyTwoClass1 : AssemblyOneClass1
    //{
    //    public void Print()
    //    {
    //        AssemblyOneClass1 A1 = new AssemblyOneClass1();
    //        base.ID = 101;
    //        //A1.ID = 102;

    //        AssemblyTwoClass1 A2 = new AssemblyTwoClass1();
    //        A2.ID = 102;

    //        AssemblyOneClass11 A11 = new AssemblyOneClass11();
    //        A11.SampleMethod();
    //    }
    //}

    public class AssemblyTwoClass
    {
        public void Test() 
        {
            AssemblyOneClass instance = new AssemblyOneClass();
            instance.Print();

        }
    }




}





// Program.cs
using System;
using AssemblyTwo;

public class Customer
{
    protected int ID;

}

public class CorporateCustomer : Customer
{
    public void PrintID()
    {
        CorporateCustomer CC = new  CorporateCustomer();
        CC.ID = 10100;

        Console.WriteLine(CC.ID);
    }
}

class Program
{
    public static void Main()
    {
        //Customer C1 = new Customer();
        //Console.WriteLine(C1.ID);

        CorporateCustomer CCc = new CorporateCustomer();
        CCc.PrintID();

        //AssemblyTwoClass1 A2 = new AssemblyTwoClass1();
        //A2.Print();

        AssemblyTwoClass A2 = new AssemblyTwoClass();
        A2.Test();

        Console.Read();
    }
}












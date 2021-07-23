//type casting?
//apakah ada?
//is it even exist?
//is the way to use it like as it explained?
//i doubt the type casting as explained by sir kudvenkat

//so did about the stack
// so, just don't believe.
//perhaps later i would understand. 
// or perhaps i wouldn't understand. 

using System;

// A delegate is a type safe function pointer
public delegate void HelloFunctionDelegate(string Message);

public class Program
{

    static void Main()
    {
        HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
        del("Hello from delegate");



        Console.Read();
    }

    // it's a function pointer, so it needs a function
    public static void Hello(string strMessage)
    {
        Console.WriteLine(strMessage);
    }

}


        // A delegate is a type safe function pointer
        // meaning the signature of the delegates should match the signature function
        // or simply similar to function
        // when creating delegate, thinks as if a method with a delegates keyword

        // why we need to pointing on delegate rather than call the function directly?
        // because of the flexibility that we will get with data approach



// pemahaman gua:
// karena dalam code berikut:
        HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
// ga bisa diberi parameter, makanya parameter yg harusnya di delegate sama nama fungsi yg harusnya di delegate nya kebalik


// itu artinya delegate:
public delegate void HelloFunctionDelegate(string Message);
HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);




----------------------------------------------------------------------------------------------------------------------------------------------





using System;
using System.Collections.Generic;



class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Experience { get; set; }
    public int Salary { get; set; }

    // awal pembuatan listnya
    public static void PromotedEmployee(List<Employee> employeeList)
    {
        foreach (Employee employee in employeeList)
        {
            if (employee.Experience >= 5)
            {
                Console.WriteLine(employee.Name + " Promoted");
            }
        }
    }
}

class Program
{
    public static void Main()
    {
        // pendeklarasian listnya
        List<Employee> empList = new List<Employee>();

        empList.Add(new Employee() { ID = 101, Name = "Mary", Experience = 5, Salary = 5000 });
        empList.Add(new Employee() { ID = 102, Name = "John", Experience = 3, Salary = 3000 });
        empList.Add(new Employee() { ID = 103, Name = "Bob", Experience = 6, Salary = 6000 });
        empList.Add(new Employee() { ID = 104, Name = "Mike", Experience = 4, Salary = 4000 });

        // fokus di Employee yg disini aja, tarolah empList udah jadi list/array
        Employee.PromotedEmployee(empList);


        Console.Read();
    }
}






using System;
using System.Collections.Generic;



class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Experience { get; set; }
    public int Salary { get; set; }

    // awal pembuatan listnya
    public static void PromotedEmployee(List<Employee> employeeList, IsPromotable IsEligibleToPromote)
    {
        foreach (Employee employee in employeeList)
        {
            if (IsEligibleToPromote(employee))
            {
                Console.WriteLine(employee.Name + " Promoted");
            }
        }
    }

    public static bool Promote(Employee emp)
    {
        if (emp.Experience >= 5)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

// IsPromotable pertama kali dibaca oleh komputer
delegate bool IsPromotable(Employee empl);

class Program
{
    public static void Main()
    {
        // pendeklarasian listnya
        List<Employee> empList = new List<Employee>();

        empList.Add(new Employee() { ID = 101, Name = "Mary", Experience = 5, Salary = 5000 });
        empList.Add(new Employee() { ID = 102, Name = "John", Experience = 3, Salary = 3000 });
        empList.Add(new Employee() { ID = 103, Name = "Bob", Experience = 6, Salary = 6000 });
        empList.Add(new Employee() { ID = 104, Name = "Mike", Experience = 4, Salary = 4000 });

        
        IsPromotable isPromotable = new IsPromotable(Employee.Promote);

        // fokus di Employee yg disini aja, tarolah empList udah jadi list/array
        Employee.PromotedEmployee(empList, isPromotable);


        Console.Read();
    }

}


//alur program:
//    1. public int
//    2. listnya diisi
//    3. mencari true/false promoted
//    4. Employee.PromotedEmployee(empList, isPromotable);
//    5. print


//delegate bool IsPromotable(Employee empl);
//Employee.PromotedEmployee(empList, isPromotable);










using System;
using System.Collections.Generic;



class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Experience { get; set; }
    public int Salary { get; set; }

    //1 awal pembuatan listnya
    public static void PromotedEmployee(List<Employee> employeeList, IsPromotable IsEligibleToPromote)
    {
        foreach (Employee employee in employeeList)
        {
            if (IsEligibleToPromote(employee))
            {
                Console.WriteLine(employee.Name + " Promoted");
            }
        }
    }

    public static bool Promote(Employee emp)
    {
        if (emp.Experience >= 5)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

//2 IsPromotable pertama kali dibaca oleh komputer
delegate bool IsPromotable(Employee empl);

class Program
{
    public static void Main()
    {
        //1 pendeklarasian listnya
        List<Employee> empList = new List<Employee>();

        empList.Add(new Employee() { ID = 101, Name = "Mary", Experience = 5, Salary = 5000 });
        empList.Add(new Employee() { ID = 102, Name = "John", Experience = 3, Salary = 3000 });
        empList.Add(new Employee() { ID = 103, Name = "Bob", Experience = 6, Salary = 6000 });
        empList.Add(new Employee() { ID = 104, Name = "Mike", Experience = 4, Salary = 4000 });

        
        IsPromotable isPromotable = new IsPromotable(Employee.Promote);

        //1 fokus di Employee yg disini aja, tarolah empList udah jadi list/array
        Employee.PromotedEmployee(empList, isPromotable);

        //Employee.PromotedEmployee(empList, emp => emp.Experience >= 5);

        Console.Read();
    }

}


//alur program:
//    1. public int
//    2. listnya diisi
//    3. mencari true/false promoted
//    4. Employee.PromotedEmployee(empList, isPromotable);
//    5. print


//delegate bool IsPromotable(Employee empl);
//Employee.PromotedEmployee(empList, isPromotable);
















using System;
using System.Collections.Generic;



class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Experience { get; set; }
    public int Salary { get; set; }

    //1 awal pembuatan listnya
    public static void PromotedEmployee(List<Employee> employeeList, IsPromotable IsEligibleToPromote)
    {
        foreach (Employee employee in employeeList)
        {
            if (IsEligibleToPromote(employee))
            {
                Console.WriteLine(employee.Name + " Promoted");
            }
        }
    }

    //public static bool Promote(Employee emp)
    //{
    //    if (emp.Experience >= 5)
    //    {
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //}
}

//2 IsPromotable pertama kali dibaca oleh komputer
delegate bool IsPromotable(Employee empl);

class Program
{
    public static void Main()
    {
        //1 pendeklarasian listnya
        List<Employee> empList = new List<Employee>();

        empList.Add(new Employee() { ID = 101, Name = "Mary", Experience = 5, Salary = 5000 });
        empList.Add(new Employee() { ID = 102, Name = "John", Experience = 3, Salary = 3000 });
        empList.Add(new Employee() { ID = 103, Name = "Bob", Experience = 6, Salary = 6000 });
        empList.Add(new Employee() { ID = 104, Name = "Mike", Experience = 4, Salary = 4000 });

        
        //IsPromotable isPromotable = new IsPromotable(Employee.Promote);

        //1 fokus di Employee yg disini aja, tarolah empList udah jadi list/array
        //Employee.PromotedEmployee(empList, isPromotable);

        Employee.PromotedEmployee(empList, emp => emp.Experience >= 5);

        Console.Read();
    }

}


//alur program:
//    1. public int
//    2. listnya diisi
//    3. mencari true/false promoted
//    4. Employee.PromotedEmployee(empList, isPromotable);
//    5. print


//delegate bool IsPromotable(Employee empl);
//Employee.PromotedEmployee(empList, isPromotable);







// multicasting

using System;
using System.Collections.Generic;



public delegate void SampleDelegate();

class Program
{
    public static void Main()
    {
        SampleDelegate del1, del2, del3, del4;

        del1 = new SampleDelegate(SampleDelegateOne);
        del2 = new SampleDelegate(SampleDelegateTwo);
        del3 = new SampleDelegate(SampleDelegateThree);

        del4 = del1 + del2 + del3;
        del4();

        Console.Read();
    }

    public static void SampleDelegateOne()
    {
        Console.WriteLine("SampleMethodOne invoked");
    }

    public static void SampleDelegateTwo()
    {
        Console.WriteLine("SampleMethodTwo invoked");
    }

    public static void SampleDelegateThree()
    {
        Console.WriteLine("SampleMethodThree invoked");
    }
}



// question: where is the struct?
// as far as i know, in oop every detail is explained
// ini mah kodingan bocah.

// bocah dalam artian kurang ribet
// ribet dalm artian flexibel
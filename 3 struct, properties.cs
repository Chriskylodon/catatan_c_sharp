//using public, getter, and setter methods


using System;

public class Student
{

    private int _id;
    private string _name;
    private int _passMark = 35;

    public int GetPassMark()
    {
        return this._passMark;
    }

    public void SetName(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new Exception("student's name cannot be null or empty");
        }
        this._name = name;
        Console.WriteLine("student's name = {0}", name);
    }

    public string GetName()
    {
        return string.IsNullOrEmpty(this._name) ? "No Name" : this._name ;

        //if (string.IsNullOrEmpty(this._name))
        //{
        //    return "No Name";
        //}
        //else
        //{
        //    return this._name;
        //}
    }

    public void SetId(int id)
    {
        if (id <= 0)
        {
            throw new Exception("student's id cannot be negative");
        }
        this._id = id;
        Console.WriteLine("student's id = {0}", id);
    }

    public int GetId()
    {
        return this._id;
    }
}



class Program
{
    static void Main()
    {
        Student C1 = new Student();
        C1.SetId(101);
        //C1.SetName("Eki");

        Console.WriteLine("Student's id = {0}", C1.GetId());
        Console.WriteLine("Student's name = {0}", C1.GetName());
        Console.WriteLine("Pass Mark = {0}", C1.GetPassMark());
        Console.Read();

    }


}


// how C# make use a properties in order to achieve encapsulation without using getter and setter method
// using properties

using System;

public class Student
{

    private int _id;
    private string _name;
    private int _passMark = 35;

    public int PassMark
    {
        get
        {
            return this._passMark;
        }
    }


    public string Name
    {
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("student's name cannot be null or empty");
            }
            this._name = value;
            Console.WriteLine("student's name = {0}", value);
        }

        get
        {
            return string.IsNullOrEmpty(this._name) ? "No Name" : this._name;

            //if (string.IsNullOrEmpty(this._name))
            //{
            //    return "No Name";
            //}
            //else
            //{
            //    return this._name;
            //}
        }
    }

    public int Id
    {
        set
        {
            if (value <= 0)
            {
                throw new Exception("student's id cannot be negative");
            }
            this._id = value;
            Console.WriteLine("student's id = {0}", value);
        }

        get
        {
            return this._id;
        }
    }
}



class Program
{
    static void Main()
    {
        Student C1 = new Student();
        C1.Id = 101;
        C1.Name("Eki");

        Console.WriteLine("Student's id = {0}", C1.Id);
        Console.WriteLine("Student's name = {0}", C1.Name);
        Console.WriteLine("Pass Mark = {0}", C1.PassMark);
        Console.Read();

    }


}





// properties
// properties itu contohnya get dan set
// manual properties and automatic properties



using System;

public class Student
{

    private int _id;
    private string _name;
    private int _passMark = 35;

// automatic properties (when there is no special programming in the properties)
    public string Email { get; set; }
    public string City { get; set; }

// manual properties (actually, when there is a special programming in the properties)
    //private string _email;
    //private string _city;

    //public string Email
    //{
    //    get
    //    {
    //        return this._email;
    //    }

    //    set
    //    {
    //        this._email = value;
    //    }
    //}

    //public string City
    //{
    //    get
    //    {
    //        return this._city;
    //    }

    //    set
    //    {
    //        this._city = value;
    //    }
    //}


    public int PassMark
    {
        get
        {
            return this._passMark;
        }
    }


    public string Name
    {
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("student's name cannot be null or empty");
            }
            this._name = value;
            Console.WriteLine("student's name = {0}", value);
        }

        get
        {
            return string.IsNullOrEmpty(this._name) ? "No Name" : this._name;

            //if (string.IsNullOrEmpty(this._name))
            //{
            //    return "No Name";
            //}
            //else
            //{
            //    return this._name;
            //}
        }
    }

    public int Id
    {
        set
        {
            if (value <= 0)
            {
                throw new Exception("student's id cannot be negative");
            }
            this._id = value;
            Console.WriteLine("student's id = {0}", value);
        }

        get
        {
            return this._id;
        }
    }
}



class Program
{
    static void Main()
    {
        Student C1 = new Student();
        C1.Id = 101;
        C1.Name = "Eki";
        C1.Email = "eki@gmail.com";
        C1.City = "Jakarta";

        Console.WriteLine("Student's id = {0}", C1.Id);
        Console.WriteLine("Student's name = {0}", C1.Name);
        Console.WriteLine("Pass Mark = {0}", C1.PassMark);
        Console.WriteLine("Pass Mark = {0}", C1.Email);
        Console.WriteLine("Pass Mark = {0}", C1.City);
        Console.Read();

    }


}








//struct
//1. tulis methodnya secara langsung
//2. block pendefinisian variabelnya -> edit -> Refactor -> encapsulation field -> apply

using System;

public class Student
{
    private int _id;
    private string _name;

    public int ID
    {
        get { return this._id; }
        set { this._id = value; }
    }

    public string Name 
    { 
        get => _name; 
        set => _name = value; 
    }
}



class Program
{
    static void Main()
    {
        
    }


}




using System;

public class Customer
{
    private int _id;
    private string _name;

    public int ID
    {
        get { return this._id; }
        set { this._id = value; }
    }

    public string Name 
    { 
        get => _name; 
        set => _name = value; 
    }

    public Customer(int Id, string Name)
    {
        this._id = Id;
        this._name = Name;
    }

    public void PrintDetail()
    {
        Console.WriteLine("ID = {0} && Name = {1}", this._id, this._name);
    }

}



class Program
{
    static void Main()
    {
        //initialization

        Customer C1 = new Customer(101, "Mark");
        C1.PrintDetail();

        Customer C2 = new Customer();
        C2.ID = 102;
        C2.Name = "John";
        C2.PrintDetail();

        Customer C3 = new Customer
        {
            ID = 103,
            Name = "Rob"
        };
        C3.PrintDetail();

    }


}




// int means System.Int32
// double means System.Double

// the difference between classes and struct is 
// classes is recorded through stack, and 
// struct is recorded through heap










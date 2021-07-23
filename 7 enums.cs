using System;

public class Customer
{
    public string Name { get; set; }
    public int Gender { get; set; }

}


class Program
{
    public static void Main()
    {
        Customer[] customers = new Customer[3];

        customers[0] = new Customer
        {
            Name = "Mark";
            Gender = 1;
        };
           
        customers[1] = new Customer
        {
            Name = "Mary";
            Gender = 2;
        };

        customers[2] = new Customer
        {
            Name = "Sam";
            Gender = 0;
        };
    
        foreach(Customer customer in customers)
        {
            Console.WriteLine("Name = {0} && Gender = {1}", customer.Name, customer.Gender);
        }

        Console.Read();
    }

    public static string GetGender(int gender)
    {
        switch(gender)
        {
            case 0:
                return "Unknown";
            case 1:
                return "Male";
            case 2:
                return "Female";
            default:
                return "data is invalid";
        }
    }

}





using System;

public enum Genders
{
    Unknown,
    Male,
    Female
}

public class Customer
{
    public string Name { get; set; }
    public Genders Gender { get; set; }

}

class Program
{
    public static void Main()
    {
        Customer[] customers = new Customer[3];

        customers[0] = new Customer
        {
            Name = "Mark";
            Gender = Genders.Male;
        };
           
        customers[1] = new Customer
        {
            Name = "Mary";
            Gender = Genders.Female;
        };

        customers[2] = new Customer
        {
            Name = "Sam";
            Gender = Genders.Unknown;
        };
    
        foreach(Customer customer in customers)
        {
            Console.WriteLine("Name = {0} && Gender = {1}", customer.Name, GetGender(customer.Gender));
        }

        Console.Read();
    }

    public static string GetGender(int gender)
    {
        switch(gender)
        {
            case Genders.Unknown:
                return "Unknown";
            case Genders.Male:
                return "Male";
            case Genders.Female:
                return "Female";
            default:
                return "data is invalid";
        }
    }

}




using System;

public enum Gender
{
    Unknown,
    Male,
    Female
}


class Program
{
    public static void Main()
    {
        int[] Values = (int[])Enum.GetValues(typeof(Gender));

        foreach(int value in Values)
        {
            Console.WriteLine(value);
        }




        string[] Names = Enum.GetNames(typeof(Gender));

        foreach(string Name in Names)
        {
            Console.WriteLine(Name);
        }


        Console.Read();
    }
}










using System;

public enum Gender : short
{
    Unknown = 1,
    Male = 5,
    Female = 22
}


class Program
{
    public static void Main()
    {
        short[] Values = (short[])Enum.GetValues(typeof(Gender));

        foreach(short value in Values)
        {
            Console.WriteLine(value);
        }

        string[] Names = Enum.GetNames(typeof(Gender));

        foreach(string Name in Names)
        {
            Console.WriteLine(Name);
        }

        Console.Read();
    }
}





using System;

public enum Gender : short
{
    Unknown = 1,
    Male = 5,
    Female = 22
}

public enum Season
{
    winter = 1,
    spring = 2,
    summer = 3 
}

class Program
{
    public static void Main()
    {
        //Gender gender = (Gender)5;
        //int Num = (int)Gender.Unknown;

        //Console.WriteLine("Gender = {0} && Num = {1}", gender, Num);

        Season season = (Season)3;
        int Numb = (int)Season.winter;

        Console.WriteLine("Season = {0} && Numb = {1}", season, Numb);



        Gender gender = (Gender)Season.winter;
        Console.WriteLine("Gender = {0}", gender);


        short[] Values = (short[])Enum.GetValues(typeof(Gender));

        foreach(short value in Values)
        {
            Console.WriteLine(value);
        }

        string[] Names = Enum.GetNames(typeof(Gender));

        foreach(string Name in Names)
        {
            Console.WriteLine(Name);
        }

        Console.Read();
    }
}



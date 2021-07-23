// exception that contains information can be hacked 
// klik kanan di Exception object -> go to definition
// ctrl = E --> to see every exception
// F10

// try - the code that can possibly cause an exception will be in the try block
// catch - handle the exception
// finally - clean and free resources that the class was holding onto during the program execution. finally block is optional.

// try-catch (coba-tangkap) maksudnya coba tangkap exceptionnya, coba cari exceptionnya, kalo ada

using System;
using System.IO;


class Program
{
    public static void Main()
    {
        try
        {
            StreamReader streamReader = new StreamReader(@"D:\Documentms\programming\wpf\C#\text1.txt");
            Console.WriteLine(streamReader.ReadToEnd());
            streamReader.Close();
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(ex.StackTrace);



        }

        Console.Read();
    }

   
}




// inheritance --> more specific on the top, more general on below

using System;
using System.IO;


class Program
{
    public static void Main()
    {
        try
        {
            StreamReader streamReader = new StreamReader(@"D:\Documents1\programming\wpf\C#\text1.txt");
            Console.WriteLine(streamReader.ReadToEnd());
            streamReader.Close();
        }
        catch(FileNotFoundException ex)
        {
            Console.WriteLine("please check if the file {0} is existed", ex.FileName);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(ex.StackTrace);
        }

        Console.Read();
    }

   
}




// mandatory


using System;
using System.IO;


class Program
{
    public static void Main()
    {
        StreamReader streamReader = null;
        try
        {
            streamReader = new StreamReader(@"D:\Documents1\programming\wpf\C#\text1.txt");
            Console.WriteLine(streamReader.ReadToEnd());
        }
        catch(FileNotFoundException ex)
        {
            Console.WriteLine("please check if the file {0} is existed", ex.FileName);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(ex.StackTrace);
        }
        finally
        {
            streamReader.Close();
            Console.WriteLine("Finally Block");
        }


        Console.Read();
    }   
}



using System;
using System.IO;


class Program
{
    public static void Main()
    {
        StreamReader streamReader = null;
        try
        {
            streamReader = new StreamReader(@"D:\Documents1\programming\wpf\C#\text1.txt");
            Console.WriteLine(streamReader.ReadToEnd());
        }
        catch(FileNotFoundException ex)
        {
            Console.WriteLine("please check if the file {0} is existed", ex.FileName);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(ex.StackTrace);
        }
        finally
        {
            if (streamReader != null)
            {
                streamReader.Close();

            }
            Console.WriteLine("Finally Block");
        }
        Console.Read();
    }

   
}







using System;
using System.IO;


class Program
{
    public static void Main()
    {
        StreamReader streamReader = null;
        try
        {
            streamReader = new StreamReader(@"D:\Documents1\programming\wpf\C#\text1.txt");
            Console.WriteLine(streamReader.ReadToEnd());
        }
        catch(FileNotFoundException ex)
        {
            Console.WriteLine("please check if the file {0} is existed", ex.FileName);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(ex.StackTrace);
        }
        if (streamReader != null)
            {
                streamReader.Close();
            }
        Console.WriteLine("Finally Block");

        Console.Read();
    }

   
}





----------------------------------------------------------------------------------------------------------------------------------------------



using System;
using System.IO;


class Program
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("please enter the first number : ");
            int FN = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter the second number : ");
            int SN = Convert.ToInt32(Console.ReadLine());

            int Result = FN / SN;
            Console.WriteLine("the result is {0}", Result);
        }
        catch(Exception ex)
        {
            string filePath = @"D:\Documents\programming\wpf\C#\log.txt";
            StreamWriter sw = new StreamWriter(filePath);
            sw.Write(ex.GetType().Name);
            sw.WriteLine();
            sw.Write(ex.Message);
            sw.Close();

            Console.WriteLine("there is a problem, please try again later");
        }
        Console.Read();
    }
}





using System;
using System.IO;


class Program
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("please enter the first number : ");
            int FN = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter the second number : ");
            int SN = Convert.ToInt32(Console.ReadLine());

            int Result = FN / SN;
            Console.WriteLine("the result is {0}", Result);
        }
        catch (Exception ex)
        {
            string filePath = @"D:\Documents\programming\wpf\C#\log.txt";
            if (File.Exists(filePath))
            {
                StreamWriter sw = new StreamWriter(filePath);
                sw.Write(ex.GetType().Name);
                sw.WriteLine();
                sw.Write(ex.Message);
                sw.Close();

                Console.WriteLine("there is a problem, please try again later");
            }
            else
            {
                throw new FileNotFoundException(filePath + "is not existed");
            }
        }
    	

        
       
        Console.Read();
    }
}






using System;
using System.IO;


class Program
{
    public static void Main()
    {

        try
        {
            try
            {
                Console.WriteLine("please enter the first number : ");
                int FN = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("please enter the second number : ");
                int SN = Convert.ToInt32(Console.ReadLine());

                int Result = FN / SN;
                Console.WriteLine("the result is {0}", Result);
            }
            catch (Exception ex)
            {
                string filePath = @"D:\Documents\programming\wpf\C#\log.txt";
                if (File.Exists(filePath))
                {
                    StreamWriter sw = new StreamWriter(filePath);
                    sw.Write(ex.GetType().Name);
                    sw.WriteLine();
                    sw.Write(ex.Message);
                    sw.Close();

                    Console.WriteLine("there is a problem, please try again later");
                }
                else
                {
                    throw new FileNotFoundException(filePath + "is not existed", ex);
                    // kalo gapake ex, nanti yg di inner exceptionnya jadi null
                }
            }
        }
        catch(Exception exception)
        {
            Console.WriteLine("Current Exception : {0}", exception.GetType().Name);
            if (exception.InnerException != null)
            {
            	// exception.InnerException.GetType().Name = exception.().() = DividedByZero
                Console.WriteLine("Inner Esception : {0}", exception.InnerException.GetType().Name);
            }
        }

        
       
        Console.Read();
    }
}




using System;
using System.IO;


class Program
{
    public static void Main()
    {

        try
        {
            try
            {
                Console.WriteLine("please enter the first number : ");
                int FN = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("please enter the second number : ");
                int SN = Convert.ToInt32(Console.ReadLine());

                int Result = FN / SN;
                Console.WriteLine("the result is {0}", Result);
            }
            catch (Exception ex)
            {
                string filePath = @"D:\Documents\programming\wpf\C#\log1.txt";
                if (File.Exists(filePath))
                {
                    StreamWriter sw = new StreamWriter(filePath);
                    sw.Write(ex.GetType().Name);
                    sw.WriteLine();
                    sw.Write(ex.Message);
                    sw.Close();

                    //coba
                        //throw new FileNotFoundException(filePath + "is not existed", ex);
                    //hasilnya komputernya langsung "ngelempar" ke "catch"
                    //jadi yg current exceptionnya ga ke print

                    Console.WriteLine("Current Exception : {0}", ex.GetType().Name);

                    //Console.WriteLine("there is a problem, please try again later");                  
                }
                else
                {
                    throw new FileNotFoundException(filePath + "is not existed", ex);
                }
            }
        }
        catch(Exception exception)
        {
            if (exception.InnerException != null)
            {
                Console.WriteLine("Inner Exception : {0}", exception.InnerException.GetType().Name);
            }
        }

        
       
        Console.Read();
    }
}


----------------------------------------------------------------------------------------------------------------------------------------------





using System;
using System.IO;
using System.Runtime.Serialization;


class Program
{
    public static void Main()
    {
        try
        {
            throw new UserAlreadyLoggedInException("User already logged in - no duplicate allowed");
        }
        catch(UserAlreadyLoggedInException ex)
        {
            Console.WriteLine(ex.Message);
        }



        Console.Read();
    }
}


[Serializable]
public class UserAlreadyLoggedInException : Exception
{
    public UserAlreadyLoggedInException() : base()
    {

    }
    
    public UserAlreadyLoggedInException(string message) : base(message)
    {

    }

    public UserAlreadyLoggedInException(string message, Exception innerException) : base(message, innerException)
    {

    }

    protected UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context) : base(info, context)
    {

    }
}





----------------------------------------------------------------------------------------------------------------------------------------------



using System;
using System.IO;
using System.Runtime.Serialization;


class Program
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Enter the numerator : ");
            int Numerator = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the denominator : ");
            int Denominator = Convert.ToInt32(Console.ReadLine());

            int Result = Numerator / Denominator;

            Console.WriteLine("The result is {0}", Result);
        }
        catch(FormatException)
        {
            Console.WriteLine("Please enter the number!!!");
        }
        catch(OverflowException)
        {
            Console.WriteLine("Please enter the valid number between {0} and {1}!!!", int.MinValue, int.MaxValue);
        }
        catch(DivideByZeroException)
        {
            Console.WriteLine("The denominator cannot be zero.");
        }

        Console.Read();
    }
}






using System;
using System.IO;
using System.Runtime.Serialization;


class Program
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Enter the numerator : ");
            int Numerator = Convert.ToInt32(Console.ReadLine());
            bool IsNumeratorConvertSuccesful = Int32.TryParse(Console.ReadLine(), out Numerator);

            if (IsNumeratorConvertSuccesful)
            {

                Console.WriteLine("Enter the denominator : ");
                int Denominator = Convert.ToInt32(Console.ReadLine());
                bool IsDenominatorConvertSuccesful = Int32.TryParse(Console.ReadLine(), out Denominator);

                if (IsDenominatorConvertSuccesful)
                {
                    int Result = Numerator / Denominator;
                    Console.WriteLine("The result is {0}", Result);
                }
            }
        }


        Console.Read();
    }
}




using System;
using System.IO;
using System.Runtime.Serialization;


class Program
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Enter the numerator : ");
            int Numerator = Convert.ToInt32(Console.ReadLine());
            bool IsNumeratorConvertSuccesful = Int32.TryParse(Console.ReadLine(), out Numerator);

            if (IsNumeratorConvertSuccesful)
            {

                Console.WriteLine("Enter the denominator : ");
                int Denominator = Convert.ToInt32(Console.ReadLine());
                bool IsDenominatorConvertSuccesful = Int32.TryParse(Console.ReadLine(), out Denominator);

                if (IsDenominatorConvertSuccesful)
                {
                    int Result = Numerator / Denominator;
                    Console.WriteLine("The result is {0}", Result);
                }
                else
                {
                    if(Denominator == 0)
                    {
                        Console.WriteLine("The denominator cannot be zero.");
                    }
                    else
                    {
                        Console.WriteLine("Please enter the valid number between {0} and {1}!!!", int.MinValue, int.MaxValue);
                    }
                }
            }
            else
            {
                Console.WriteLine("Please enter the valid number between {0} and {1}!!!", int.MinValue, int.MaxValue);
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.Read();
    }
}






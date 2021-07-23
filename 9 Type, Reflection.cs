simple program (class mainClass & class Customer) compiled into intermediate language and then packaged into assembly

assembly contains 2 parts:
1. intermediate language
2. meta data (kayanya deket sama method)

meta data contains:
- types
- type members

!enums penting 

reflection is taking that assembly and then inspecting that assembly to find out
how many classes this assembly got?
how many enums or structure that this assembly got?
for each class, what are different members that each class are enums or structure has got?

so, doing inspecting this assembly content by looking its meta data at runtime is nothing but a reflection
reflection is the ability of inspecting an assemblies meta data  at runtime.
it is used to find all types in an assmebly and/or dynamically invoke methods in an assembly

how is this reflection useful?
this reflection is used in several ways.
one of the practical example is here,

klik kanan di nama classnya, go to definition.
liat propertiesnya (warna, fontsize, font color, margin, brushes)

late binding







Customer C1 = new Customer();
we creating an instance for this customer class but
at compile time itself, i know, i have knowledge about this customer class. (so, at compile time you are able to create an instance) 									-> early binding

there might be a situation where, you might not have the knowledge about of the class for which you have to create an instance, you can only do that in a runtime 
maybe because you don't have the assembly available to you until at runtime or 
for some other reason, you don't have any knowledge at compile time about the class for which you are going to create an instance

so, at that point of time, you have to create an instance of that class at runtime dynamically.																			-> late binding
and when you did that, you are actually doing the late binding.
and one of the best to achieve late binding is to use reflection.

late binding is nothing but create an instance for that class at runtime rather than at compile time																	-> late binding

using System;
using System.Reflection;

namespace Eki
{
    public class Customer
    {
        public int _id { get; set; }
        public string _name { get; set; }

        public Customer(int ID, string Name)
        {
            this._id = ID;
            this._name = Name;
        }
        
        public Customer()
        {
            this._id = -1;
            this._name = string.Empty;
        }

        public void PrintID()
        {
            Console.WriteLine("ID = {0}", this._id);
        }

        public void PrintName()
        {
            Console.WriteLine("Name = {0}", this._name);
        }

    }

    class Program
    {
        public static void Main()
        {
            Customer C1 = new Customer();
            C1.PrintID();
            Console.WriteLine();


            //Type T = Type.GetType("Eki.Customer");
            //Type T = typeof(Customer);
            Customer C2 = new Customer();
            Type T = C2.GetType();

            //Eki.Customer.GetType().Name;
            //Eki.Customer.GetType(Eki.Customer);
            //Eki.Customer.GetType(Name);

            //Customer.GetType().GetProperties();
            //Customer.GetType().GetProperties().PropertyType.Name;



            //cek namespace and types
            Console.WriteLine("Full Name = {0}", T.FullName);
            Console.WriteLine("Just the Namespace = {0}", T.Namespace);
            Console.WriteLine("Just the Name = {0}", T.Name);
            Console.WriteLine();

            //cek properties
            Console.WriteLine("Properties in {0}", T.Name);
            PropertyInfo[] propertyInfos = T.GetProperties();
            foreach (PropertyInfo property in propertyInfos)
            {
                Console.WriteLine(property.PropertyType.Name + " " + property.Name);
            }
            Console.WriteLine();

            //cek methods
            Console.WriteLine("Methods in Customer Class");
            MethodInfo[] methodInfos = T.GetMethods();
            foreach (MethodInfo methods in methodInfos)
            {
                Console.WriteLine(methods.MemberType + " " + methods.ReturnType.Name + " " + methods.Name);
            }
            Console.WriteLine();

            //cek constructor
            Console.WriteLine("Constructor in Customer Class");
            ConstructorInfo[] constructorInfos = T.GetConstructors();
            foreach (ConstructorInfo constructor in constructorInfos)
            {
                Console.WriteLine(  constructor.ToString() + " " + constructor.Name);
            }
            Console.WriteLine();




            Console.Read();
        }
    }
}







using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace ReflectionDemo
{
    public partial class Reflection : Forms
    {
        public Reflection()
        {
            initializeComponent();
        }

        private void btnDiscoveryTypeInformation_Click(object sender, EventArgs e)
        {

            string TypeName = txtTypeName.Text;
            Type T = Type.GetType(TypeName);
            lstMethods.Items.Clear();
            lstProperties.Items.Clear();
            lstConstructors.Items.Clear();
            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo method in methods)
            {
                lstMethods.Items.Add(method.ReturnType.Name + " " + method.Name);
            }
            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                lstProperties.Items.Add(property.PropertyType.Name + " " + property.Name);
            }
            ConstructorInfo[] constructors = T.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                lstConstructors.Items.Add(constructor.ToString());
            }
        }
    }
}




// early binding example
using System;
namespace Pragim
{
    public class MainClass
    {
        private static void Main()
        {
            Customer C1 = new Customer();
            string fullName = C1.GetFullName("Pragim", "Tech");
            Console.WriteLine("Full Name = {0}", fullName);
        }
    }
    public class Customer
    {
        public string GetFullName(string FirstName, string LastName)
        {
            return FirstName + " " + LastName;
        }
    }
}


// late binding example
using System;
using System.Reflection;
namespace Pragim
{
    public class MainClass
    {
        private static void Main()
        {
            // Load the current executing assembly as the Customer class is present in it.
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            // Load the Customer class for which we want to create an instance dynamically
            Type customerType = executingAssembly.GetType("Pragim.Customer");
            // Create the instance of the customer type using Activator class 
            object customerInstance = Activator.CreateInstance(customerType);
            // Get the method information using the customerType and GetMethod()
            MethodInfo getFullName = customerType.GetMethod("GetFullNames");
            // Create the parameter array and populate first and last names
            string[] methodParameters = new string[2];
            methodParameters[0] = "Pragim"; //FirstName
            methodParameters[1] = "Tech";     //LastName
            // Invoke the method passing in customerInstance and parameters array
            string fullName = (string)getFullName.Invoke(customerInstance, methodParameters);
            Console.WriteLine("Full Name = {0}", fullName);
        }
    }
    public class Customer
    {
        public string GetFullName(string FirstName, string LastName)
        {
            return FirstName + " " + LastName;
        }
    }
}
namespace generic_class_with_restriction
{
    //restricted type T to ref type
    //public class GenericClass<T> where T : class
    //{
    //    public T Message;
    //    public void GenericMethod(T param1, T param2)
    //    {
    //        Console.WriteLine($"Message:{Message}");
    //        Console.WriteLine($"param1:{param1}");
    //        Console.WriteLine($"param1:{param2}");
    //    }
    //}

    //restricted type T to non-nullable struct type i.e int, char, float etc.
    //public class GenericClass<T> where T : struct
    //{
    //    public T Message;
    //    public void GenericMethod(T param1, T param2)
    //    {
    //        Console.WriteLine($"Message:{Message}");
    //        Console.WriteLine($"param1:{param1}");
    //        Console.WriteLine($"param1:{param2}");
    //    }
    //}

    //restricted type T to ref type but that class should implement the interface
    //public class GenericClass<T> where T : IEmployee
    //{
    //    public T Message;
    //    public void GenericMethod(T Param1, T Param2)
    //    {
    //        Console.WriteLine($"Message: {Message}");
    //        Console.WriteLine($"Param1: {Param1}");
    //        Console.WriteLine($"Param2: {Param2}");
    //    }
    //}

    //here T should either inherit from U or implement Type U
    public class GenericClass<T, U> where T : U
    {
        public T Message;
        public void GenericMethod(T Param1, U Param2)
        {
            Console.WriteLine($"Message: {Message}");
            Console.WriteLine($"Param1: {Param1}");
            Console.WriteLine($"Param2: {Param2}");
        }
    }

    public interface IEmployee
    {
    }

    public class Employee : Customer, IEmployee
    {
        public string Name { get; set; }
        public string Location { get; set; }
    }

    public class Customer
    {
        public string Name { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //if type T is ref type
            //var employeeClass = new GenericClass<Employee>();
            //var stringClass = new GenericClass<string>();

            //var employee1 = new Employee() { Name = "John", Location = "LA" };
            //var employee2 = new Employee() { Name = "Tom", Location = "CA" };
            //employeeClass.Message = employee1;
            //employeeClass.GenericMethod(employee1, employee2);

            //stringClass.Message = "Welcome to DotNetTutorials";
            //stringClass.GenericMethod("Anurag Mohanty", "Bhubaneswar");

            //if type T is struct type i.e int, char, float etc.
            //var intClass = new GenericClass<int>();
            //intClass.Message = 10;
            //intClass.GenericMethod(1, 2);

            //if type T is any interface
            //var employeeClass = new GenericClass<Employee>();
            //var customerClass = new GenericClass<Customer>();

            // here employee class is implementing IEmployee interface, so it will work fine
            GenericClass<Employee, IEmployee> employeeGenericClass = new GenericClass<Employee, IEmployee>();
            // here employee class is inheres Iemployee interface, so it will work fine
            GenericClass<Employee, Customer> customerGenericClass = new GenericClass<Employee, Customer>();

            //GenericClass<Customer, IEmployee> customerGenericClass = new GenericClass<Customer, IEmployee>();
        }
    }
}
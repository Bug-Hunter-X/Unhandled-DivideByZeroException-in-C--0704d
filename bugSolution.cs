public class MyClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        int x = 5;
        int y = 0;
        try
        {
            if (y == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
                return; // Exit the method if division by zero is attempted.
            }
            int result = x / y;
            Console.WriteLine("Result: " + result);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
    }
}
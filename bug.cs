public class MyClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        int x = 5;
        try
        {
            int y = x / 0; // This will throw a DivideByZeroException
        }
        catch (DivideByZeroException ex)
        {
            // Handle the exception
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        finally
        {
            // This code will always execute
            Console.WriteLine("This is the finally block.");
        }
    }
}
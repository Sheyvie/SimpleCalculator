public class Progrma
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter First Number");

        double a = Convert.ToDouble(Console.ReadLine());




        Console.WriteLine("Enter operation");
        Console.WriteLine("1. Add");
        Console.WriteLine("2.Subtract");
        Console.WriteLine("3. Divide");
        Console.WriteLine("4. Multiply");
        int operation = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Enter Second Number");
        double b = Convert.ToDouble(Console.ReadLine());

        double result = 0;


        switch (operation)
        {
            case 1:
                result = a + b;
                break;
            case 2:
                result = a - b;
                break;
            case 3:
                result = a / b;
                break;
            case 4:
                result = a * b;
                break;
            default:
                Console.WriteLine("Invalid operator");
                break;


        }
        Console.WriteLine("Result: " + result);
    }    
}

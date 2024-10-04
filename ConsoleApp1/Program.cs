using System.Text;
Console.OutputEncoding = Encoding.UTF8;
double factorial_WhileLoop(int number)
{
    double result = 1;
    while (number != 1)
    {
        result = result * number;
        number = number - 1;
    }
    return result;

}


Console.Write("введите число: ");
double x = Convert.ToDouble(Console.ReadLine());


double y = x - (Math.Pow(x,3)/factorial_WhileLoop(3))  + (Math.Pow(x,5)/ factorial_WhileLoop(5)) - (Math.Pow(x, 7) / factorial_WhileLoop(7)) + (Math.Pow(x, 9) / factorial_WhileLoop(9)) - (Math.Pow(x, 11) / factorial_WhileLoop(11)) + (Math.Pow(x, 13) / factorial_WhileLoop(13));
Console.WriteLine(y);
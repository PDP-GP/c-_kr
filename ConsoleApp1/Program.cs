using System.Text;
Console.OutputEncoding = Encoding.UTF8;
double FactorialFunction(int number)
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


double y = x - (Math.Pow(x,3)/FactorialFunction(3))  + (Math.Pow(x,5)/ FactorialFunction(5)) - (Math.Pow(x, 7) / FactorialFunction(7)) + (Math.Pow(x, 9) / FactorialFunction(9)) - (Math.Pow(x, 11) / FactorialFunction(11)) + (Math.Pow(x, 13) / FactorialFunction(13));
Console.WriteLine(y);
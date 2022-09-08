using CSharp_Lambdas;
namespace CSharp_Lambdas
{
    class Program{
        static void Main(string[] args)
        {

            MathService mathService = new MathService();
            mathService.MathPerformed += (result) => Console.WriteLine($"Calculation Result: {result}");
            mathService.CalculateNumbers(3,4,  (x,y) => x*y);
            mathService.
        }
    }
}

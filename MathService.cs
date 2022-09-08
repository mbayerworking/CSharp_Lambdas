using System.Timers;
namespace CSharp_Lambdas
{
    public class MathService
    {
        //public event EventHandler<MathPerformedEventArgs> MathPerformed;
        public Action<double> MathPerformed;

        public void CalculateNumbers(double value1, double value2, Func<double,double,double> calculation)
        {
            System.Timers.Timer timer = new System.Timers.Timer(5000);
            //MathPerformed(this, new MathPerformedEventArgs { Result = value1 * value2 });
            MathPerformed(calculation(value1, value2));


        }
    }
}
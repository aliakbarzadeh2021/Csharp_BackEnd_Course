using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Day04
{
    #region Example: Protected internal modifier

    //internal class StringCalculator
    //{
    //    protected internal string Num1 { get; set; }
    //    protected internal string Num2 { get; set; }
    //}

    //internal class StringCalculatorImplement : StringCalculator
    //{
    //    public int Sum()
    //    {
    //        return Convert.ToInt32(Num1) + Convert.ToInt32(Num2);
    //    }
    //}

    #endregion

    #region Example: private modifier

    //internal class StringCalculator
    //{
    //    private string Num1 { get; set; }
    //    private string Num2 { get; set; }

    //    public int Sum() => Convert.ToInt32(Num1) + Convert.ToInt32(Num2);

    //    public int Add(int num1, int num2)
    //    {
    //        if (num1 > 100 || num2 > 100)
    //            num1 = num2=100;

    //        return num1 + num2;
    //    }
    //}

    //internal class StringCalculatorAnother
    //{
    //    private readonly StringCalculator _calculator;

    //    public StringCalculatorAnother(StringCalculator calculator)
    //    {
    //        _calculator = calculator;
    //    }

    //    //public int Sum()
    //    //{
    //    //    return Convert.ToInt32(_calculator.Num1) + Convert.ToInt32(_calculator.Num2);
    //    //}
    //}

    #endregion

    #region Example: abstract modifier

    //internal abstract class StringCalculator
    //{
    //    public  string Num1 { get; set; }
    //    public  string Num2 { get; set; }
    //    public abstract int Sum();

    //}

    //internal class StringCalculatorImplement : StringCalculator
    //{
    //    public override int Sum() => Convert.ToInt32(Num1) + Convert.ToInt32(Num2);
    //}

    #endregion

    #region Example: async modifier

    //internal class StringCalculator
    //{
    //    public string Num1 { get; set; }
    //    public string Num2 { get; set; }
    //    public async Task<int> Sum()
    //    {
    //        return await Task.Run(()=>Convert.ToInt32(Num1) + Convert.ToInt32(Num2));
    //    }
    //}

    #endregion

    #region Example: const modifier

    //internal class StringCalculator
    //{
    //    private const int Num1 = 70;
    //    public const double Pi = 3.14;
    //    public const string Book = "Learn C# in 7-days";

    //    public int Sum()
    //    {
    //        const int num2 = Num1 + 85;

    //        return  Convert.ToInt32(Num1) + Convert.ToInt32(num2);
    //    }
    //}

    #endregion

    #region Example: new modifier

    //internal class StringCalculator
    //{
    //    private const int Num1 = 70;
    //    private const int Num2 = 89;

    //    public int Sum() => Num1 + Num2;
    //}

    //internal class StingCalculatorImplement : StringCalculator
    //{
    //    public int Num1 { get; set; }
    //    public int Num2 { get; set; }

    //    public new int Sum() => Num1 + Num2;
    //}

    #endregion

    #region Example: virtual modifier

    //internal class StringCalculator
    //{
    //    private const int Num1 = 70;
    //    private const int Num2 = 89;

    //    public virtual int Sum() => Num1 + Num2;
    //}

    //internal class StingCalculatorImplement : StringCalculator
    //{
    //    public int Num1 { get; set; }
    //    public int Num2 { get; set; }

    //    public override int Sum() => Num1 + Num2;
    //}

    #endregion

    #region Example: readOnly modifier

    //internal class StringCalculator
    //{
    //    private readonly int _num2;
    //    public readonly int Num1 = 179;

    //    public StringCalculator(int num2)
    //    {
    //        _num2 = num2;
    //    }

    //    public int Sum()
    //    {
    //        return Num1 + _num2;
    //    }
    //}

    #endregion

    #region Example: sealed modifier

    //internal abstract class StringCalculator
    //{
    //    public int Num1 { get; set; }
    //    public int Num2 { get; set; }

    //    public abstract int Sum();
    //    public virtual int Sub() => Num1 -Num2;
    //}

    //internal class Calc : StringCalculator
    //{
    //    public int Num3 { get; set; }
    //    public int Num4 { get; set; }
    //    public override int Sub() => Num3 - Num4;

    //    //This will not be inherited from within derive classes
    //    //any more
    //    public sealed override int Sum() => Num3 + Num4;
    //}

    //internal sealed class SealedCalc : Calc
    //{
    //    public override int Sub() => Num1 - Num2;

    //}

    #endregion

    #region Example: static modifier

    //internal static class StringCalculator
    //{
    //    public const int Num1 = 10;
    //    public const int Num2 = 20;
    //    public int I { private get; set; }

    //    public static int Sum() => Num1 + Num2;
    //    //public int Sub() => Num1 - Num2;
    //}

    #endregion

    #region Example: Properties

    internal class ProeprtyExample: INotifyPropertyChanged
    {
        private int _number;

        public ProeprtyExample(int num1)
        {
            Num1 = num1;
        }
        //constructor restricted proeprty
        public int Num1 { get; }
        //read-only auto proeprty
        public int Num2 { get; private set; }
        //read-only collection initialized property
        public IEnumerable<string> Numbers { get; } = new List<string>();

        public int Num3 { get; set; }
        public int Num4 { get; set; }

        public int Add => Num3 + Num4;

        public int Sum {
            get
            {
                return Num3 + Num4;
            }
        }

        public int Number
        {
            get => _number;
            set
            {
                if (value < 0)
                {
                    //log for records or take action
                    //Log("Number is negative.");
                    throw new ArgumentException("Number can't be -ve."); 
                }
                _number = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    #endregion

    #region Exception handlings

    class ExceptionhandlingExample
    {
        public int Div(int dividend,int divisor)
        {
            int quotient = 0;
            try
            {
                quotient = dividend / divisor;

            }
            catch (Exception exception)
            {
                Console.WriteLine($"Exception occuered '{exception.Message}'");

            }
            finally
            {
                Console.WriteLine("Exception occured and cleaned.");
            }

            return quotient;
        }
    }

    #endregion
}
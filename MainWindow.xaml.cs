using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_Math_practice10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void SolvetButton_Click(object sender, RoutedEventArgs e)
        {
            int taskNumber = int.Parse(TaskNumberTextBox.Text);
            string result = "";

            switch (taskNumber)
            {
                case 1:
                    result = Task1();
                    break;
                case 2:
                    result = Task2();
                    break;
                case 3:
                    result = Task3();
                    break;
                case 4:
                    result = Task4();
                    break;
                case 5:
                    result = Task5();
                    break;
                case 6:
                    result = Task6();
                    break;
                case 7:
                    result = Task7();
                    break;
                case 8:
                    result = Task8();
                    break;
                case 9:
                    result = Task9();
                    break;
                case 10:
                    result = Task10();
                    break;
                case 11:
                    result = Task11();
                    break;
                case 12:
                    result = Task12();
                    break;
                case 13:
                    result = Task13();
                    break;
                case 14:
                    result = Task14();
                    break;
                case 15:
                    result = Task15();
                    break;
                case 16:
                    result = Task16();
                    break;
                case 17:
                    result = Task17();
                    break;
                case 18:
                    result = Task18();
                    break;
                case 19:
                    result = Task19();
                    break;
                case 20:
                    result = Task20();
                    break;
                case 21:
                    result = Task21();
                    break;
                case 22:
                    result = Task22();
                    break;
                case 23:
                    result = Task23();
                    break;
                case 24:
                    result = Task24();
                    break;
                case 25:
                    result = Task25();
                    break;
                case 26:
                    result = Task26();
                    break;
                case 27:
                    result = Task27();
                    break;
                case 28:
                    result = Task28();
                    break;
                case 29:
                    result = Task29();
                    break;
                case 30:
                    result = Task30();
                    break;
                default:
                    result = "Неверный номер заданияю";
                    break;
            }
            REsultTextBlock.Text = result;
        }
        private string Task1()
        {
            int A = int.Parse(Input1TextBox.Text);
            int N = int.Parse(Input2TextBox.Text);
            return $"Результат: {Math.Pow(A, N)}";
        }

        private string Task2()
        {
            int N = int.Parse(Input1TextBox.Text);
            return $"Результат: {Factorial(N)}";
        }

        private string Task3()
        {
            int N = int.Parse(Input1TextBox.Text);
            return $"Результат: {SumOfSquares(N)}";
        }

        private string Task4()
        {
            int N = int.Parse(Input1TextBox.Text);
            return $"Результат: {SumOfSquaresAndCubes(N)}";
        }
        private string Task5()
        {
            int N = int.Parse(Input1TextBox.Text);
            return $"Результат: {FindSpecialNumbers(N)}";
        }

        private string Task6()
        {
            int N = int.Parse(Input1TextBox.Text);
            return $"Результат: {FindMultiplesOfFive(N)}";
        }

        private string Task7()
        {
            int N = int.Parse(Input1TextBox.Text);
            return $"Результат: {IsPowerOfTwo(N)}";
        }

        private string Task8()
        {
            int N = int.Parse(Input1TextBox.Text);
            return $"Результат: {PrimeFactors(N)}";
        }

        private string Task9()
        {
            int x = int.Parse(Input1TextBox.Text);
            return $"Результат: {FindPerfectNumbers(x)}";
        }

        private string Task10()
        {
            int m = int.Parse(Input1TextBox.Text);
            int n = int.Parse(Input2TextBox.Text);
            return $"Результат: {SumOfSquaresRange(m, n)}";
        }

        private string Task11()
        {
            int m = int.Parse(Input1TextBox.Text);
            int n = int.Parse(Input2TextBox.Text);
            return $"Результат: {SumOfSquaresOfOddNumbers(m, n)}";
        }

        private string Task12()
        {
            return $"Результат: {ProductOfOddMultiplesOfSeven(-80, 80)}";
        }

        private string Task13()
        {
            return $"Результат: {SumOfPositiveMultiplesOfNine(-10, 10)}";
        }

        private string Task14()
        {
            int n = int.Parse(Input1TextBox.Text);
            return $"Результат: {CountThreeDigitNumbersGreaterThanN(n)}";
        }

        private string Task15()
        {
            int n = int.Parse(Input1TextBox.Text);
            return $"Результат: {FindCoprimeNumbers(n)}";
        }

        private string Task16()
        {
            int p = int.Parse(Input1TextBox.Text);
            int q = int.Parse(Input2TextBox.Text);
            return $"Результат: {FindDivisorsCoprimeWithP(p, q)}";
        }

        private string Task17()
        {
            int n = int.Parse(Input1TextBox.Text);
            return $"Результат: {FindPrimeDivisors(n)}";
        }

        private string Task18()
        {
            return $"Результат: {FindFirst100Primes()}";
        }

        private string Task19()
        {
            int m = int.Parse(Input1TextBox.Text);
            int n = int.Parse(Input2TextBox.Text);
            return $"Результат: {ProductOfSquaresOfEvenNumbers(m, n)}";
        }

        private string Task20()
        {
            int n = int.Parse(Input1TextBox.Text);
            return $"Результат: {CalculateSeries(n)}";
        }

        private string Task21()
        {
            int N = int.Parse(Input1TextBox.Text);
            return $"Результат: {DifferenceOfCubes(N)}";
        }

        private string Task22()
        {
            int m = int.Parse(Input1TextBox.Text);
            int n = int.Parse(Input2TextBox.Text);
            return $"Результат: {SquareOfDifference(m, n)}";
        }

        private string Task23()
        {
            return $"Результат: {SumOfNegativeMultiplesOfFive(-20, 20)}";
        }

        private string Task24()
        {
            return $"Результат: {SumOfPositiveMultiplesOfFour(100)}";
        }

        private string Task25()
        {
            int N = int.Parse(Input1TextBox.Text);
            return $"Результат: {DifferenceOfSquares(N)}";
        }

        private string Task26()
        {
            return $"Результат: {PrintOddNumbers(100, 200)}";
        }

        private string Task27()
        {
            int m = int.Parse(Input1TextBox.Text);
            int n = int.Parse(Input2TextBox.Text);
            return $"Результат: {ProductOfCubes(m, n)}";
        }

        private string Task28()
        {
            int n = int.Parse(Input1TextBox.Text);
            int m = int.Parse(Input2TextBox.Text);
            return $"Результат: {FindNumbersWithSquareSumOfDigits(n, m)}";
        }
        private string Task29()
        {
            int m = int.Parse(Input1TextBox.Text);
            int n = int.Parse(Input2TextBox.Text);
            return $"Результат: {ProductOfSquaresOfOddNumbers(m, n)}";
        }

        private string Task30()
        {
            int m = int.Parse(Input1TextBox.Text);
            int n = int.Parse(Input2TextBox.Text);
            return $"Результат: {SumOfSquaresOfEvenNumbers(m, n)}";
        }

        private int Factorial(int n)
        {
            if (n == 0) return 1;
            return n * Factorial(n - 1);
        }

        private int SumOfSquares(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i * i;
            }
            return sum;
        }

        private int SumOfSquaresAndCubes(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                    sum += i * i;
                else
                    sum += i * i * i;
            }
            return sum;
        }

        private string FindSpecialNumbers(int N)
        {
            List<int> numbers = new List<int>();
            for (int i = 1; i <= N; i++)
            {
                if (i % 5 != 0 && i % 3 == 0 && SumOfDigits(i) % 5 != 0 && SumOfDigits(i) % 3 == 0)
                {
                    numbers.Add(i);
                }
            }
            return string.Join(", ", numbers);
        }

        private string FindMultiplesOfFive(int N)
        {
            List<int> numbers = new List<int>();
            for (int i = 1; i <= N; i++)
            {
                if (i % 5 == 0)
                {
                    numbers.Add(i);
                }
            }
            return string.Join(", ", numbers);
        }

        private string IsPowerOfTwo(int N)
        {
            return (N > 0 && (N & (N - 1)) == 0) ? "Да" : "Нет";
        }

        private string PrimeFactors(int N)
        {
            List<int> factors = new List<int>();
            for (int i = 2; i <= N; i++)
            {
                while (N % i == 0)
                {
                    factors.Add(i);
                    N /= i;
                }
            }
            return string.Join(", ", factors);
        }

        private string FindPerfectNumbers(int x)
        {
            List<int> perfectNumbers = new List<int>();
            for (int i = 2; i <= x; i++)
            {
                if (IsPerfect(i))
                {
                    perfectNumbers.Add(i);
                }
            }
            return string.Join(", ", perfectNumbers);
        }

        private bool IsPerfect(int number)
        {
            int sum = 1;
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    if (i * i != number)
                        sum += i + number / i;
                    else
                        sum += i;
                }
            }
            return sum == number && number != 1;
        }

        private int SumOfSquaresRange(int m, int n)
        {
            int sum = 0;
            for (int i = m; i <= n; i++)
            {
                sum += i * i;
            }
            return sum;
        }

        private int SumOfSquaresOfOddNumbers(int m, int n)
        {
            int sum = 0;
            for (int i = m; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i * i;
                }
            }
            return sum;
        }

        private int ProductOfOddMultiplesOfSeven(int start, int end)
        {
            int product = 1;
            for (int i = start; i <= end; i++)
            {
                if (i % 2 != 0 && i % 7 == 0)
                {
                    product *= i;
                }
            }
            return product;
        }
        private int SumOfPositiveMultiplesOfNine(int start, int end)
        {
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                if (i > 0 && i % 9 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        private int CountThreeDigitNumbersGreaterThanN(int n)
        {
            int count = 0;
            for (int i = 100; i <= 999; i++)
            {
                if (i > n)
                {
                    count++;
                }
            }
            return count;
        }

        private string FindCoprimeNumbers(int n)
        {
            List<int> coprimeNumbers = new List<int>();
            for (int i = 1; i < n; i++)
            {
                if (GCD(i, n) == 1)
                {
                    coprimeNumbers.Add(i);
                }
            }
            return string.Join(", ", coprimeNumbers);
        }

        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private string FindDivisorsCoprimeWithP(int p, int q)
        {
            List<int> divisors = new List<int>();
            for (int i = 1; i <= q; i++)
            {
                if (q % i == 0 && GCD(i, p) == 1)
                {
                    divisors.Add(i);
                }
            }
            return string.Join(", ", divisors);
        }

        private string FindPrimeDivisors(int n)
        {
            List<int> primeDivisors = new List<int>();
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0 && IsPrime(i))
                {
                    primeDivisors.Add(i);
                }
            }
            return string.Join(", ", primeDivisors);
        }

        private bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private string FindFirst100Primes()
        {
            List<int> primes = new List<int>();
            int count = 0;
            int number = 2;
            while (count < 100)
            {
                if (IsPrime(number))
                {
                    primes.Add(number);
                    count++;
                }
                number++;
            }
            return string.Join(", ", primes);
        }

        private int ProductOfSquaresOfEvenNumbers(int m, int n)
        {
            int product = 1;
            for (int i = m; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    product *= i * i;
                }
            }
            return product;
        }

        private int CalculateSeries(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int term = 1;
                for (int j = i; j <= 2 * i; j++)
                {
                    term *= j;
                }
                sum += term;
            }
            return sum;
        }

        private int DifferenceOfCubes(int N)
        {
            int sum = 0;
            for (int i = 1; i <= N; i++)
            {
                if (i % 2 != 0)
                    sum += i * i * i;
            }
            return sum;
        }

        private int SquareOfDifference(int m, int n)
        {
            return (m - n) * (m - n);
        }

        private int SumOfNegativeMultiplesOfFive(int start, int end)
        {
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                if (i < 0 && i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
        private int SumOfPositiveMultiplesOfFour(int limit)
        {
            int sum = 0;
            for (int i = 1; i < limit; i++)
            {
                if (i % 4 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        private int DifferenceOfSquares(int N)
        {
            int sum = 0;
            for (int i = 1; i <= N; i++)
            {
                sum += i * i - (i - 1) * (i - 1);
            }
            return sum;
        }

        private string PrintOddNumbers(int start, int end)
        {
            List<int> oddNumbers = new List<int>();
            for (int i = start; i <= end; i++)
            {
                if (i % 2 != 0)
                {
                    oddNumbers.Add(i);
                }
            }
            return string.Join(", ", oddNumbers);
        }

        private int ProductOfCubes(int m, int n)
        {
            int product = 1;
            for (int i = m; i <= n; i++)
            {
                product *= i * i * i;
            }
            return product;
        }

        private string FindNumbersWithSquareSumOfDigits(int n, int m)
        {
            List<int> numbers = new List<int>();
            for (int i = 1; i < n; i++)
            {
                if (SumOfDigits(i) * SumOfDigits(i) == m)
                {
                    numbers.Add(i);
                }
            }
            return string.Join(", ", numbers);
        }

        private int SumOfDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }

        private int ProductOfSquaresOfOddNumbers(int m, int n)
        {
            int product = 1;
            for (int i = m; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    product *= i * i;
                }
            }
            return product;
        }

        private int SumOfSquaresOfEvenNumbers(int m, int n)
        {
            int sum = 0;
            for (int i = m; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i * i;
                }
            }
            return sum;
        }
    }
}

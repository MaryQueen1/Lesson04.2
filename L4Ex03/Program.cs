int Factorial (int n)
{
    // 1! = 1
    // 0! = 1
    if(n ==1) return 1;
    else return n * Factorial(n-1);
}

System.Console.WriteLine(Factorial(5));

// но если это int то из-за переполнения с 17! будет неверный вывод
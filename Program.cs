// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
/*
void ShowNumbers(int n)
{
    if(n > 1) ShowNumbers(n-1);
    Console.Write(n + " ");
}
ShowNumbers(5);*/
//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
/*
int SumOfDigit(int num) 
{
    if(num != 0) return SumOfDigit(num/10) + num% 10;
    return 0;
}
Console.WriteLine(SumOfDigit(1234));
*/
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void ShowNumbers(int m, int n)
{
    if(m<n) 
    {
        Console.Write(m + " ");
        ShowNumbers(m+1, n);        
    }
    if(m==n) Console.Write(m + " ");
    if(n<m) 
    {
        ShowNumbers(n, m);
    }
    //if(m>n) ShowNumbers(m-1,n);
   //Console.Write(m + " ");
    //if(m<n) ShowNumbers(m+1,n);
}
ShowNumbers(0, 7);
//Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B.
/*double Power(int a, int b)
{
    if(b>0) return Power(a, b-1) *a ;
    if(b<0) return Power(a, b+1) * 1/a;
    else return 1;
}
Console.WriteLine(Power(2,2));
*/
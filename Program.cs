// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Runtime.CompilerServices;

Console.WriteLine("enter first number");

int n1= int.Parse(Console.ReadLine());

Console.WriteLine("please inter secondnumber");

int n2= int.Parse(Console.ReadLine());


for (int i = n1;  i <= n2; i++) 
{
    int counter = 0;
    for (int j = 2; j <= i/2 ; j++)
    {
        if (i % j == 0)
        {
            counter++;  
            break;

        }
    }
    if (counter== 0 && i !=1)
        Console.WriteLine("{0} is prime",i);

}
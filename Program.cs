using System;

namespace aula_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu nome?");
            var userName = Console.ReadLine();
            Console.WriteLine($"Olá, {userName}");

            var myChar = 'a'; 
            var myText = "Texto"; 
            var myNumber = 10; 
            var myBoolean = false;
            var myFloat = 0.99;
                     
            Console.WriteLine("Você é maior de idade?");
            var result = Console.ReadLine();
            var myBoolean1 = result == "sim";
            Console.WriteLine(myBoolean1);
        }
    }
}

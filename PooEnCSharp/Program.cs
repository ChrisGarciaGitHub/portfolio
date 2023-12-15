﻿using PooEnCSharp;

internal class Program
{
    private static void Main(string[] args)
    {
        
        Palindromo p = new Palindromo("anita lava la tina");
        ResultadoPalindromo rs = p.esPalindromo();
        if (rs.Sucess == true)
        {
            Console.WriteLine("Es palindromo");
        }
        else
        {
            Console.WriteLine("No es palindromo");
        }


        int[] numbers = { 7, 25, 11, 2 };
        int target = 9;
        
        TwoSum ts = new TwoSum(numbers, target);
        ResultadoSuma result = ts.sumaObjetivo();
        if (result.Sucess == true)
        {
            Console.WriteLine($"Indices: [{result.IndiceOperando1}, {result.IndiceOperando2}]");
        }
        else
        {
            Console.WriteLine("No se ha encontrado solucion");
        }
    }
}
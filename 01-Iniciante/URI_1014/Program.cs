﻿using System;
using System.Globalization;

namespace URI_1014
{
    class Program
    {
        /*
        Calcule o consumo médio de um automóvel sendo fornecidos a distância total percorrida (em Km) e o total de combustível gasto (em litros).
        Entrada: O arquivo de entrada contém dois valores: um valor inteiro X representando a distância total percorrida (em Km), 
        e um valor real Y representando o total de combustível gasto, com um dígito após o ponto decimal.
        Saída: Apresente o valor que representa o consumo médio do automóvel com 3 casas após a vírgula, seguido da mensagem "km/l".
        Exemplo de Entrada 	Exemplo de Saída
        500                 14.286 km/l
        35.0
	
        2254                18.119 km/l
        124.4
         */

        static void Main( string[] args )
        {
            double Y, KML;
            int X;
            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            KML = X / Y;

            Console.WriteLine(KML.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}

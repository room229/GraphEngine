// Graph Engine
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE.md file in the project root for full license information.
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //GraphGen gg = new GraphGen(1 << 20, 16, 100);
            //GraphGen gg = new GraphGen(5, 5, 5);
            //gg.CreatGraph();
            //gg.Print_Nodes();


            Console.WriteLine("Choose engine command: ");
            Console.WriteLine("1. Create graph");
            Console.WriteLine("2. View created graph nodes\n");
            ConsoleKeyInfo keyb_Inp = Console.ReadKey();
            if (keyb_Inp.KeyChar == '1')
            {
                Console.WriteLine("\nNode count: ");
                ConsoleKeyInfo key1 = Console.ReadKey();

                Console.WriteLine("\nAvg degree: ");
                ConsoleKeyInfo key2 = Console.ReadKey();

                Console.WriteLine("\nLabel count: ");
                ConsoleKeyInfo key3 = Console.ReadKey();
                GraphGen gg = new GraphGen(key1.KeyChar - '0', key2.KeyChar - '0', key3.KeyChar - '0');
                gg.CreatGraph();
            }
            else if (keyb_Inp.KeyChar == '2')
                GraphGen.Print_Nodes();



        }
    }
}

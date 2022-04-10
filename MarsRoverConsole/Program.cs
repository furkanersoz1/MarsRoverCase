using MarsRoverCase;
using MarsRoverCase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string plato;
            string location;
            string command;
            Console.WriteLine("Platonun boyutunu giriniz! (Örn: 5 5)");
            plato = Console.ReadLine();
            Console.WriteLine("Gezicinin bilgilerini giriniz! (Örn: 1 2 N)");
            location = Console.ReadLine();
            Console.WriteLine("Gezicinin hareket dizini giriniz! (Örn: LMLMLMLMM)");
            command = Console.ReadLine();

            string[] platos = plato.Split(' ');
            
            Plateau plateau = new Plateau(Convert.ToInt32(platos[0]), Convert.ToInt32(platos[1]));
            Rover rover = new Rover(location, plateau);
            rover.Run(command);

            Console.WriteLine(rover.Output());
            Console.ReadKey();
        }
    }
}

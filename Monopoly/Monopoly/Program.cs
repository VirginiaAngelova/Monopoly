using System;
using System.Collections.Generic;

namespace Monopoly
{
    class Program
    {
        static void Main(string[] args)
        {
            Beginning Beginning = new Beginning("Beginning");
            House HouseAtanasovi = new House("Atanasovi" ,500,50);
            Station StationFilipovo = new Station("Filipovo", 1000, 500);
            House HousePetrovi = new House("Petrovi", 500, 50);
            FreeParking FirstFreeParking = new FreeParking("First parking");

            House HouseDimitrovi = new House("Dimitrovi", 500, 50);
            Station StationTrakia = new Station("Trakia", 1000, 500);
            House HouseIvanovi = new House("", 500, 50);
            FreeParking SecondFreeParking = new FreeParking("Second parking");

            House HouseAngelovi = new House("Angelovi", 500, 50);
            Station StationTsentralna  = new Station("Tsentralna", 1000, 500);
            House HouseMarinovi = new House("Marinovi", 500, 50);
            FreeParking ThirthFreeParking = new FreeParking("Thirt parking");

            House HouseBiserovi = new House("Biserovi", 500, 50);
            Station StationIzgrev = new Station("Izgrev", 1000, 500);
            House HousePavlovi = new House("Pavlovi", 500, 50);


            Player PlayerOne = new Player("Virginia", 1500, 0);
            //List<Player> players = new List<Player>();
            //players.Add(PlayerOne);

            List<Field> board = new List<Field>();
            board.Add(Beginning);

            board.Add(HouseAtanasovi);
            board.Add(StationFilipovo);
            board.Add(HousePetrovi);

            board.Add(FirstFreeParking);

            board.Add(HouseDimitrovi);
            board.Add(StationTrakia);
            board.Add(HouseIvanovi);

            board.Add(SecondFreeParking);

            board.Add(HouseAngelovi);
            board.Add(StationTsentralna);
            board.Add(HouseMarinovi);

            board.Add(ThirthFreeParking);

            board.Add(HouseBiserovi);
            board.Add(StationIzgrev);
            board.Add(HousePavlovi);

            Random dice = new Random();

            PlayerOne.Move(dice.Next(1, 7));
            Field currentPosition = board[PlayerOne.Position];
            Console.WriteLine($"{PlayerOne.NamePlayer} is moving on the position: {board[PlayerOne.Position].FieldName}");



            /*
             object[,] board = new  object[4, 5]{
                {Beginning,HouseAtanasovi, StationFilipovo,  HousePetrovi, FirstFreeParking},
                { FirstFreeParking,HouseDimitrovi, StationTrakia,  HouseIvanovi, SecondFreeParking},
                { SecondFreeParking,HouseAngelovi, StationTsentralna,  HouseMarinovi, ThirthFreeParking},
                { ThirthFreeParking,HouseBiserovi, StationIzgrev,  HousePavlovi, Beginning},
            };
            */


        }
    }
}

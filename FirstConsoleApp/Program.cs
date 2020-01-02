using System;

namespace FirstConsoleApp
{
    class Program {
        static void Main(string[] args) {

            Song giannis = new Song("Giannis", "Freddie Gibbs", 198);
            Console.WriteLine(Song.songCount);
            Song savageNomad = new Song("Savage Nomad", "Danny Brown", 208);
            Console.WriteLine(Song.songCount);

            /* Console.WriteLine(giannis.artist);
            Console.WriteLine(savageNomad.artist); */

            Console.ReadLine();
        }

    }
}
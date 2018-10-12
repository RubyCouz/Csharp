using System;

namespace exo4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			int magnitude = 9;
			switch(magnitude) {
				case 1 :
					Console.WriteLine("Micro-séisme impossible à resssentir.");
					break;
				case 2:
                    Console.WriteLine("Micro-séisme impossible à ressentir mais enregistrable par les sismomètres.");
                    break;
				case 3:
                    Console.WriteLine("Ne cause pas de dégats mais commence à pouvoir être légèrement ressenti.");
                    break;
				case 4:
                    Console.WriteLine("séisme capable de faire bouger des objets mais ne causant généralement pas de dégats.");
                    break;
				case 5:
					Console.WriteLine("Séisme capable d'engendrer des dégats importants sur de vieux bâtiments ou bien des bâtiments présentants des défauts de construction. Peu de dégats sur des bâtiments modernes.");
                    break;
				case 6:
					Console.WriteLine("Fort séisme capable d'engendrer des destructions majeures sur une large distance (180 km) autour de l'épicentre.");
                    break;
				case 7:
					Console.WriteLine("Séisme capable de destructions majeures à modérées sur une très large zone en fonction de la distance.");
                    break;
				case 8:
					Console.WriteLine("Séisme capable de destructions majeures sur une très large zone de plusieurs centaines de kilomètres.");
                    break;
				case 9:
					Console.WriteLine("Séisme capable de tout détruire sur une très vaste zone.");
                    break;
			}

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluacion
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Billetera Din = new Billetera();
                MusicPlayer music = new MusicPlayer();
                Console.WriteLine("Para el ejercicio de la billetera ingrese 1");
                Console.WriteLine("Para el ejercicio del reproductor ingrese 2");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Din.Menu();
                        break;
                    case 2:
                        music.Menu();
                        break;
                }           
            }
            catch
            {

            }
        }
    }
}

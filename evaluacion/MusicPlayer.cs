using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluacion
{
    class MusicPlayer
    {
        public string Nombre { get; set; }
        List<string> reproductor = new List<string>();
        int objeto;
        string reproduciendo;
        public void Menu() {
            Console.WriteLine("Para agregar una nueva cancion ingrese 1");
            Console.WriteLine("Para ver que cancion se esta reproduciendo ingrese 2");
            Console.WriteLine("Para avanzar ingrese 3");
            Console.WriteLine("Para retroceder ingrese 4");
            int opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Agregar();
                break;
                case 2:
                    Reproduciendo();
                    break;
                case 3:
                    
                    break;
                case 4:
                    
                    break;
                case 5:
                    
                    break;
            }
        }
        public void Agregar() {
            Console.WriteLine("Ingrese el nombre de la cancion");
            string cancion = Console.ReadLine();
            reproductor.Add(cancion);
            Menu();
        }
        public void Reproduciendo() {
            foreach (var item in reproductor)
            {
                objeto = Convert.ToInt32(item);
                reproduciendo = item;
                Console.WriteLine($"Reproduciendo actualmente: {reproduciendo}");
            }
            Menu();
        }
        public void adelantar() {
            foreach (var item in reproductor)
            {
                int y = Convert.ToInt32(item);
                int z = y + 1;
                if (z > y){
                    objeto = objeto + 1;
                }
            }
            Menu();
        }
    }
}

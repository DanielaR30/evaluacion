using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluacion
{
    class Billetera
    {
        //Es para definir todas las propiedades
        #region propiedades
        public Double DineroInicial { get; set; }
        public Double Retirar { get; set; }
        public Double Gasto { get; set; }
        public Double Porcentaje { get; set; }
        public Double TotalG { get; set; }
        public Double Ahorro { get; set; }
        public Double Deposito { get; set; }

        int ingreso = 0;
        int gasto = 0;
        int depositar = 0;
        #endregion
        //Al crear un metodo la primera va con mayuscula, en este caso se pasan las propiedades de la clase asi que se deben llamar igual
        //Para eliminar un dato se hace con remove

        public void Menu()
        {
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Para ingresar el dinero incial ingrese 1");
            Console.WriteLine("Para gastar dinero ingrese 2");
            Console.WriteLine("Para depositar dinero en el banco ingrese 3");
            Console.WriteLine("Para conocer el saldo actual de su billetera ingrese 4");
            Console.WriteLine("Para saber cuanto ha ahorrado ingrese 5");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Dinero();
                break;
                case 2:
                    Gastar();
                break;
                case 3:
                    Depositar();
                break;
                case 4:
                    ImprimirDinero();
                break;
                case 5:
                    TotalAhorrado();
                break;
            }

        }

        public void Dinero()
        {
            Console.WriteLine("Ingrese La cantidad de dinero Inicial");
            DineroInicial = Convert.ToInt32(Console.ReadLine());
            ingreso = ingreso + 1;
            Menu();
        }

        public void Gastar()
        {
            Console.WriteLine("Ingrese La cantidad de dinero a Gastar");
            Retirar = Convert.ToDouble(Console.ReadLine());
            if (Retirar<DineroInicial)
            {
                Porcentaje = Retirar * 0.1;
                Ahorro = Ahorro + Porcentaje;
                TotalG = Retirar - Porcentaje;
                DineroInicial = DineroInicial-TotalG;
                Console.WriteLine("Compra realizada");
                Console.WriteLine($"Su saldo es: {DineroInicial}");
                gasto = gasto + 1;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
            Menu();
        }

        public void Depositar()
        {
            Console.WriteLine("¿Desea depositar su dinero en el banco?");
            string respuesta = Console.ReadLine();
            if(respuesta == "si")
            {
                if (DineroInicial > 0)
                {
                    Console.WriteLine("");
                    Deposito = DineroInicial;
                    DineroInicial = 0;
                    DineroInicial = 0;
                    Console.WriteLine($"Has depositado: {Deposito}");
                    depositar = depositar + 1;
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente");
                }
                Menu();
            }
            else
            {
                Menu();
            }
        }
        public void ImprimirDinero() {
            Console.WriteLine($"Saldo actual: {DineroInicial}");
            Menu();
        }
        public void TotalAhorrado() {
            Console.WriteLine($"Total ahorrado: {Ahorro}");
            Menu();
        }
        public void NotificarTransaccion() {
            if (ingreso > 0) {
                Console.WriteLine($"Has realizado {ingreso} en tu cuenta");
            }else if (gasto > 0) {
                Console.WriteLine($"Numero de gastos relizados {gasto}");
            }else if (depositar > 0) {
                Console.WriteLine($"Has depositado {depositar} vez (veces) al banco");
            }
            Menu();
        }
    }
}

using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new Garage();
            Auto auto1 = new Auto("pedro","30689175","jho842",24,"Fijo");
            garage.RecepcionVehiculo(auto1);
            Auto auto2 = new Auto("juan","25627492","hfp923",24,"Fijo");
            garage.RecepcionVehiculo(auto2);
            Camioneta camioneta = new Camioneta("jose","20492794","orc427",9,"Movil");
            garage.RecepcionVehiculo(camioneta);
            Moto moto = new Moto("ramon","15791384","xoq467",12,"Fijo");
            garage.RecepcionVehiculo(moto);
            Bici bici = new Bici("oscar","36794127","qrt908",6,"");
            garage.RecepcionVehiculo(bici);
            Console.WriteLine($"Espacios ocupados: {garage.EspaciosOcupados()}");
            Console.WriteLine($"Monto total a cobrar: {garage.TotalCobrar()}");
            Console.ReadKey();

            

        }
    }
}

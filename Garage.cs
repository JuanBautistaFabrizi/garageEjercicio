using System;
using System.Collections.Generic;


namespace ejercicio3
{
    public class Garage
    {
        public List<Vehiculos> ocupacion { get; set; }
        
         public int CapacidadAuto { get; set; }
         public int CapacidadCamioneta { get; set; }
         public int CapacidadMoto { get; set; }
         public int CapacidadBici { get; set; }
         
         

         public Garage()
         {
         CapacidadAuto = 30;
         CapacidadCamioneta = 20;
         CapacidadMoto = 20;
         CapacidadBici = 30;
         ocupacion = new List<Vehiculos>();
         }

         public int  EspaciosOcupados()
         {
             return ocupacion.Count;
         }

         public void RecepcionVehiculo(Vehiculos vehiculo)
         {  
                 ocupacion.Add(vehiculo);
             
         }
         public double TotalCobrar()
         {  
             double total = 0;
             foreach (Vehiculos vehiculo in ocupacion)
             {
                 total += vehiculo.Costo();
             }
             return total;
         }
        
    }
}


        
     


        

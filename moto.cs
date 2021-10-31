namespace ejercicio3
{
    public class Moto : Vehiculos
    { 
        public Moto(string nombre,string dni,string patente,int horasEstacionado,string tipoEstacionamiento) : base(nombre, dni, patente, horasEstacionado, tipoEstacionamiento)
        {
              PrecioHora = 200;
              PrecioDiario = 0;
        }
            

        
    }
}
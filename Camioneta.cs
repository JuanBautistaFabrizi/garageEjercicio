namespace ejercicio3
{
    public class Camioneta : Vehiculos
    {
        
        

        
        
        public Camioneta(string nombre,string dni,string patente,int horasEstacionado,string tipoEstacionamiento) : base(nombre, dni, patente, horasEstacionado, tipoEstacionamiento)
        {
              PrecioHora = 600;
              PrecioDiario = 600;
        }

        
    }
}
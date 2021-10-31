namespace ejercicio3
{
    public class Auto : Vehiculos
    {

        
        
        public Auto(string nombre,string dni,string patente,int horasEstacionado,string tipoEstacionamiento) : base(nombre, dni, patente, horasEstacionado, tipoEstacionamiento)
        {
              PrecioHora = 400;
              PrecioDiario = 800;
        }

     
        
    }
}
namespace ejercicio3
{
    public class Bici : Vehiculos
    {
        public Bici(string nombre,string dni,string patente,int horasEstacionado,string tipoEstacionamiento) : base(nombre, dni, patente, horasEstacionado, tipoEstacionamiento)
        {
              PrecioHora = 40;
              PrecioDiario = 0;
        }
        

    }
}
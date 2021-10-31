namespace ejercicio3
{
    public  class Vehiculos
    {
        public string Nombre { get; set; }
        public string Dni { get; set; }
        public string Patente { get; set; }
        public int HorasEstacionado { get; set; }

        public string TipoEstacionamiento { get; set; }

        public int PrecioHora { get; set; }
        public int PrecioDiario { get; set; }

         protected   Vehiculos(string nombre,string dni,string patente,int horasEstacionado,string tipoEstacionamiento)
        {
          this.Nombre = nombre;
          this.Dni = dni;
          this.Patente = patente;
          this.HorasEstacionado = horasEstacionado;
          this.TipoEstacionamiento = tipoEstacionamiento;
        }

        public   double  EstacionamientoFija()
        {
            return PrecioHora * HorasEstacionado + PrecioDiario;
        }
        

        public  double EstacionamientoMovil()
        {
            return PrecioHora * HorasEstacionado;
        }

        public virtual double Costo()
        {
            if (TipoEstacionamiento == "Fijo")
            {
                return EstacionamientoFija();
            }
            else
            {
                return EstacionamientoMovil();
            }    
        }
    }
}
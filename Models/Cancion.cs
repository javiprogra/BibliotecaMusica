namespace BibliotecaMusica.Models
{
    public class Cancion
    {
        public string? nombre { get; set; }
        public string? artista { get; set; }
        public string? duracion {  get; set; }

        public override bool Equals(object obj)
        {
            return obj is Cancion c &&
                   nombre == c.nombre &&
                   artista == c.artista &&
                   duracion == c.duracion;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(nombre, artista, duracion);
        }
    }
}

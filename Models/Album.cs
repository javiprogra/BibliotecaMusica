namespace BibliotecaMusica.Models
{
    public class Album
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? tituloAlbum { get; set; }
        public string? artistaAlbum {  get; set; }
        public List<Cancion> canciones { get; set; } = new List<Cancion>();
        public DateTime fechaPublicacion { get; set; }

    }
}

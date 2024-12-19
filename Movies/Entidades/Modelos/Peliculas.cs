namespace Movies.Entidades.Modelos
{
    public class Peliculas
    {
        public long id { get; set; }
        public string name { get; set; }
        public decimal? rating { get; set; }
        public string director {  get; set; }
        public int duracion { get; set; }
        public System.DateTime creacion { get; set; }
        public string synopsis { get; set; }
        public string generos { get; set; }
        public string URL { get; set; }
    }
}

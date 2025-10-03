using Newtonsoft.Json;

public class Juego
{
    private List<Palabra> listaPalabras { get; set; } = new List<Palabra>();
    private static List<Usuario> jugadores { get; set; } = new List<Usuario>();
    private Usuario jugadorActual { get; set; }
    private List<Palabra> palabrasUsadas { get; set; } = new List<Palabra>();
    private static Random random = new Random(); // Random estático para aleatoriedad

    public string PalabraActual { get; set; }

    public void InicializarJuego(string name, int dificultad)
    {
        jugadorActual = new Usuario(name, 0); 
        PalabraActual = CargarPalabra(dificultad);
    }

    public void LlenarListaPalabras()
    {
        listaPalabras.AddRange(new List<Palabra>
        {
            new Palabra("sol", 1), new Palabra("luna", 1), new Palabra("piedra", 1), new Palabra("agua", 1),
            new Palabra("flor", 1), new Palabra("pato", 1), new Palabra("gato", 1), new Palabra("cielo", 1),
            new Palabra("mesa", 1), new Palabra("coche", 1),

            new Palabra("manzana", 2), new Palabra("pelota", 2), new Palabra("tren", 2), new Palabra("zapato", 2),
            new Palabra("peluche", 2), new Palabra("silla", 2), new Palabra("sombrero", 2), new Palabra("hoja", 2),
            new Palabra("rojo", 2), new Palabra("verde", 2),

            new Palabra("correr", 3), new Palabra("caminar", 3), new Palabra("escribir", 3), new Palabra("jugar", 3),
            new Palabra("romper", 3), new Palabra("saltos", 3), new Palabra("florecer", 3), new Palabra("bailar", 3),
            new Palabra("responder", 3), new Palabra("cantar", 3),

            new Palabra("estratégico", 4), new Palabra("conocimiento", 4), new Palabra("adversidad", 4),
            new Palabra("inmortal", 4), new Palabra("desafiante", 4), new Palabra("resiliencia", 4),
            new Palabra("sabiduría", 4), new Palabra("entender", 4), new Palabra("compromiso", 4),
            new Palabra("habilidad", 4)
        });
    }

    private string CargarPalabra(int dificultad)
    {
        // Filtra palabras según dificultad y que no hayan sido usadas
        var palabrasFiltradas = listaPalabras
            .Where(p => p.Dificultad == dificultad && !palabrasUsadas.Contains(p))
            .ToList();

        if (palabrasFiltradas.Count == 0)
            return "No hay más palabras con esa dificultad";

        int indice = random.Next(palabrasFiltradas.Count);
        var palabraElegida = palabrasFiltradas[indice];
        palabrasUsadas.Add(palabraElegida);
        return palabraElegida.Texto;
    }

    public void FinJuego(int cantidadIntentos)
    {
        jugadorActual.CantidadIntentos = cantidadIntentos;
        jugadores.Add(jugadorActual);
        jugadorActual = null;
    }

    public static List<Usuario> DevolverListaUsuarios()
    {
        return jugadores.OrderBy(j => j.CantidadIntentos).ToList();
    }
}

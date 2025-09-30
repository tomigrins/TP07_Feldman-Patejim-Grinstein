using Newtonsoft.Json;

public class Juego{
    private List<Palabra> listaPalabra{get;private set;}
    private List<Usuario> jugadores{get; private set;}
    private Usuario jugadorActual{get; private set;}
    public string PalabraActual {get; private set;}

    public void inicializarJuego(string name, int dificultad){
        jugadorActual = new Usuario(name, 0) 
        palabraActual = CargarPalabra(dificultad)
    }

    private void LlenarListaPalabras(){
        listaPalabras.Add(new Palabra("sol", 1));
        listaPalabras.Add(new Palabra("luna", 1));
        listaPalabras.Add(new Palabra("piedra", 1));
        listaPalabras.Add(new Palabra("agua", 1));
        listaPalabras.Add(new Palabra("flor", 1));
        listaPalabras.Add(new Palabra("pato", 1));
        listaPalabras.Add(new Palabra("gato", 1));
        listaPalabras.Add(new Palabra("cielo", 1));
        listaPalabras.Add(new Palabra("mesa", 1));
        listaPalabras.Add(new Palabra("coche", 1));

        
        listaPalabras.Add(new Palabra("manzana", 2));
        listaPalabras.Add(new Palabra("pelota", 2));
        listaPalabras.Add(new Palabra("tren", 2));
        listaPalabras.Add(new Palabra("zapato", 2));
        listaPalabras.Add(new Palabra("peluche", 2));
        listaPalabras.Add(new Palabra("silla", 2));
        listaPalabras.Add(new Palabra("sombrero", 2));
        listaPalabras.Add(new Palabra("hoja", 2));
        listaPalabras.Add(new Palabra("rojo", 2));
        listaPalabras.Add(new Palabra("verde", 2));

        
        listaPalabras.Add(new Palabra("correr", 3));
        listaPalabras.Add(new Palabra("caminar", 3));
        listaPalabras.Add(new Palabra("escribir", 3));
        listaPalabras.Add(new Palabra("jugar", 3));
        listaPalabras.Add(new Palabra("romper", 3));
        listaPalabras.Add(new Palabra("saltos", 3));
        listaPalabras.Add(new Palabra("florecer", 3));
        listaPalabras.Add(new Palabra("bailar", 3));
        listaPalabras.Add(new Palabra("responder", 3));
        listaPalabras.Add(new Palabra("cantar", 3));

        
        listaPalabras.Add(new Palabra("estratégico", 4));
        listaPalabras.Add(new Palabra("conocimiento", 4));
        listaPalabras.Add(new Palabra("adversidad", 4));
        listaPalabras.Add(new Palabra("inmortal", 4));
        listaPalabras.Add(new Palabra("desafiante", 4));
        listaPalabras.Add(new Palabra("resiliencia", 4));
        listaPalabras.Add(new Palabra("sabiduría", 4));
        listaPalabras.Add(new Palabra("entender", 4));
        listaPalabras.Add(new Palabra("compromiso", 4));
        listaPalabras.Add(new Palabra("habilidad", 4));
    }

    private string CargarPalabra(int dificultad){
        List<Palabra> palabrasFiltradas = new List<Palabra>();

        foreach (Palabra palabra in listaPalabras)
        {
            if (palabra.Dificultad == dificultad)
            {
                palabrasFiltradas.Add(palabra);
            }
        }

        if (palabrasFiltradas.Count == 0)
        {
            return "No hay palabras con esa dificultad";
        }

        Random random = new Random();
        int indice = random.Next(0,palabrasFiltradas.Count);

        return palabrasFiltradas[indice];

    }

    public void FinJuego(int cantidadIntentos){
        jugadorActual.cantidadIntentos=cantidadIntentos;
        jugadores.Add(jugadorActual);
        jugadorActual = null;
    }

    public List<Usuario> DevolverListaUsuarios(){
        return jugadores.Sort();
    }
}
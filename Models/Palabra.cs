using Newtonsoft.Json;

public class Palabra
{
    public string Texto { get; private set; }
    public int Dificultad { get; private set; }

    public Palabra(string texto, int dificultad)
    {
        Texto = texto;
        Dificultad = dificultad;
    }
}
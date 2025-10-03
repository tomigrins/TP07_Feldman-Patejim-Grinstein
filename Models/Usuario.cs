using Newtonsoft.Json;

public class Usuario
{
    [JsonProperty]
    public string Nombre { get; private set; }

    [JsonProperty]
    public int CantidadIntentos { get; set; }

    public Usuario(string nombre, int cantidadIntentos)
    {
        Nombre = nombre;
        CantidadIntentos = cantidadIntentos;
    }
}
using Newtonsoft.Json;
public static class Usuario{
    [JsonProperty]
    public string nombre{get; private set;}
    [JsonProperty]
    public int cantidadIntentos{get; private set;}

    public Usuario(string nombre, int cantidadIntentos){
        this.nombre = nombre;
        this.cantidadIntentos = cantidadIntentos;
    }
}
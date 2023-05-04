namespace Juegopokemon;
public class PokemonDTO
{
    public int Id {get;set;}
    public string Nombre { get; set; }
    public string Tipo { get; set; }
    public List<int> SetHabilidades { get; set; }
    public decimal Defensa { get; set; }
    
}

namespace Juegopokemon;
public class Pokemons: Ipokemons
{  
    private List<PokemonDTO> BD;

    public Pokemons()
    {
         this.BD = new List<PokemonDTO>();

    } 
    public void CrearPokemon(PokemonDTO pokemon)
    {
        this.BD.Add(pokemon);
    }

  
    public void EliminarPokemon(int id)
    {
        this.BD.RemoveAll(Pokemon => Pokemon.Id == id);
    }
    public void EditarPokemon(int id, PokemonDTO Pokemon)
    {
        PokemonDTO EditarPokemon=this.BD.Single((Pokemon => Pokemon.Id == id));
        EditarPokemon.Nombre= Pokemon.Nombre;
        EditarPokemon.Tipo= Pokemon.Tipo;
        EditarPokemon.Defensa= Pokemon.Defensa;
    }
    public PokemonDTO TraePokemonesdeuntipo(int Id)
    {
        return (this.BD.Single(pokemon => pokemon.Id == Id));
    }
    public List<PokemonDTO> Traertodoslospokemones()
    {
        return this.BD;
    }

}
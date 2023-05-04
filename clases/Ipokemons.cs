namespace Juegopokemon;
public interface Ipokemons 
{
    public void CrearPokemon(PokemonDTO pokemon);
    public void EliminarPokemon(int id);
    public void EditarPokemon(int id, PokemonDTO pokemon);
    public PokemonDTO TraePokemonesdeuntipo(int Id);
    List <PokemonDTO> Traertodoslospokemones();

}
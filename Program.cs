using Juegopokemon;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

Pokemons Pokemon= new Pokemons();

app.MapPost("/api/v1/pokemon",(PokemonDTO pokemon) => {
    Pokemon.CrearPokemon(pokemon);
});

app.MapGet("/api/v1/pokemon", () => {
    return Results.Ok(Pokemon.Traertodoslospokemones());
});

app.MapPut("/api/v1/pokemon/{id}", (int  id, PokemonDTO pokemon) => {
   Pokemon.EditarPokemon(id, pokemon);
    
});

app.MapDelete("/api/v1/pokemon/eliminar1/{id}", (int id) =>
{
    Pokemon.EliminarPokemon(id);
    return Results.Ok(Pokemon.Traertodoslospokemones());
});

app.MapGet("/api/v1/pokemon/get1/{id}", (int id) =>
{
    return Results.Ok(Pokemon.TraePokemonesdeuntipo(id));
}); 
app.Run();
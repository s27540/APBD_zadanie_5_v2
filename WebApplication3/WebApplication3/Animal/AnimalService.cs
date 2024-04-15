using Microsoft.Data.SqlClient;

namespace WebApplication3.Animal;

public class AnimalService : IAnimalService
{
    private readonly SqlConnection _connection;

    public AnimalService(SqlConnection connection)
    {
        _connection = connection;
    }

    public IEnumerable<Animal> GetAnimals(string orderBy)
    {
        return null;
    }

    public void AddAnimal(Animal newAnimal)
    {
        
    }

    public void UpdateAnimal(int idAnimal, Animal updatedAnimal)
    {
       
    }

    public void DeleteAnimal(int idAnimal)
    {
        
    }
}

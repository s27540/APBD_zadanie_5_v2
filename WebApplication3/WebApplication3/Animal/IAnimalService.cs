namespace WebApplication3.Animal;

public interface IAnimalService
{
    IEnumerable<Animal> GetAnimals(string orderBy);
    void AddAnimal(Animal newAnimal);
    void UpdateAnimal(int idAnimal, Animal updatedAnimal);
    void DeleteAnimal(int idAnimal);
}
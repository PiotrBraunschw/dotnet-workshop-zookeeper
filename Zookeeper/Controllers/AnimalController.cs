using Microsoft.AspNetCore.Mvc;
using Zookeeper.Models;

namespace Zookeeper.Controllers;

[ApiController]
[Route("[controller]")]
public class AnimalsController : ControllerBase
{

    private IEnumerable<IAnimal> GetAllAnimals()
    {
        return new List<IAnimal>
        {
            new BabyLion { Age = 1, Name = "Simba" },
            new Lion { Age = 10, Name = "Mufasa" },
            new OldLion { Age = 20, Name = "Scar"},
            new Giraffe { Age = 1, Name = "Shorty"},
            new Giraffe { Age = 7, Name = "Lady Long Leg"},
            new Giraffe { Age = 10, Name = "Mister Long Neck"},
            new Tortoise{ Age = 50, Name = "Young Boy Johnny"},
            new Tortoise{ Age = 120, Name = "Grandma Georgia"}
        };
    }

    [HttpGet(nameof(GetBabyAnimals))]
    public IEnumerable<IAnimal> GetBabyAnimals()
    {
        return GetAllAnimals().Where(x => x.Age < 2);
    }

    [HttpGet(nameof(GetOldestAnimal))]
    public IAnimal GetOldestAnimal()
    {
        return GetAllAnimals().OrderBy(x => x.Age).Last();

    }



    [HttpGet(nameof(GetDangerousAnimals))]
    public IEnumerable<IAnimal> GetDangerousAnimals()
    {
        return GetAllAnimals().Where(x => x.IsDangerous());
    }



    [HttpGet(nameof(Search))]
    public IEnumerable<IAnimal> Search(string name)
    {
        return GetAllAnimals().Where(x => x.Name.Contains(name));
    }

    [HttpGet(nameof(GetCuteAnimals))]
    public IEnumerable<IAnimal> GetCuteAnimals()
    {
        return GetAllAnimals().Where(x => x.Age < 10 || x.Size == Size.Small);
    }

    [HttpGet(nameof(GetAnimalsOrderedByName))]
    public IEnumerable<IAnimal> GetAnimalsOrderedByName(int offset, int limit)
    {
        return GetAllAnimals().OrderBy(x => x.Name).Skip(offset).Take(limit);

    }


    [HttpGet(nameof(GetAnimalNamesPerAgeOrderedByAge))]
    public IEnumerable<IAnimal> GetAnimalNamesPerAgeOrderedByAge()
    {
        return (IEnumerable<IAnimal>)GetAllAnimals().OrderBy(x => x.Name).GroupBy(x => x.Age);
    }
}




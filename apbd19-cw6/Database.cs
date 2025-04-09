using apbd19_cw6.Models;

namespace apbd19_cw6;

public static class Database
{
    public static List<Animal> Animals = new List<Animal>()
    {
        new Animal(){AnimalId = 1, Name = "Pies"},
        new Animal(){AnimalId = 2, Name = "Kot"},
        new Animal(){AnimalId = 3, Name = "Mysz"},
    };
    
    
}
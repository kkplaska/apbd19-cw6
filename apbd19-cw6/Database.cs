using apbd19_cw6.Models;

namespace apbd19_cw6;

public static class Database
{
    public static List<Animal> Animals = new List<Animal>()
    {
        new Animal(){Id = 1, Name = "Pieselel", Category = "Dog", Weight = 18.0, FurColor = "Black"},
        new Animal(){Id = 2, Name = "Kotelel", Category = "Cat", Weight = 4.0, FurColor = "Tabby"},
        new Animal(){Id = 3, Name = "Myszelel", Category = "Mice", Weight = 0.15, FurColor = "White"},
    };

    public static List<Visit> Visits = new List<Visit>()
    {
        new Visit(){date = "2025-04-14", animal = Animals[1], description = "Lorem ipsum", price = 120.50},
        new Visit(){date = "2025-04-30", animal = Animals[1], description = "Lorem ipsum", price = 210.45},
        new Visit(){date = "2025-04-15", animal = Animals[2], description = "Lorem ipsum", price = 50.42}
    };

}
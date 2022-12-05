namespace Zookeeper.Models
{
    public interface  IAnimals
    {
        Size Size { get; }
        int Age { get; set; }
        string Name { get; set; }
        bool IsDangerous();
        
    }


    public class Lion : IAnimals
    {
        public Size Size { get; }
        public int Age { get; set; }
        public string Name { get; set; }
        public bool IsDangerous()
        {
            return true;
        }
    }

    public class Giraffe : IAnimals
    {
        public Size Size { get; }
        public int Age { get; set; }
        public string Name { get; set; }
        public bool IsDangerous()
        {
            return false;
        }
    }

    public class Tortise : IAnimals
    {
        public Size Size { get; }
        public int Age { get; set; }
        public string Name { get; set; }
        public bool IsDangerous()
        {
            return false;
        }
    }

}

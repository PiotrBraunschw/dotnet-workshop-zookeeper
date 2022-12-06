namespace Zookeeper.Models
{
    public interface  IAnimal
    {
        Size Size { get; }
        int Age { get; set; }
        string Name { get; set; }
        bool IsDangerous();
        //bool IsHungry { get; set; }

        
    }


    public class Lion : IAnimal
    {
        public Size Size { get; } = Size.Medium;
        public int Age { get; set; }
        public string Name { get; set; }

        private bool isHungry;

        public virtual bool IsDangerous()
        {
            return isHungry;
        }
        public bool canRoar() 
        { 
            return true; 
        }
        public void Feed()
        {

        }
    }

    public class Giraffe : IAnimal
    {
        public Size Size { get; }
        public int Age { get; set; }
        public string Name { get; set; }
        public bool IsDangerous()
        {
            return false;
        }
        bool IsHungry { get; set; }

    }

    public class Tortoise : IAnimal
    {
        public Size Size { get; } = Size.Small;
        public int Age { get; set; }
        public string Name { get; set; }
        public bool IsDangerous()
        {
            return false;
        }
        bool IsHungry { get; set; }
    }

}

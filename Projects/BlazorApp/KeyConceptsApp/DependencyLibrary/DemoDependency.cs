

namespace DependencyLibrary
{
    public class DemoDependency
    {
        public string GiveRandomNumber()
        {
            int randomValue = Random.Shared.Next(0, 100);
            return $"The value is {randomValue.ToString()}";
        }
    }
}

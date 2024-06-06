using InterfaceSegregation.Interfaces;

namespace InterfaceSegregation.Models
{
    internal class Developer : IWorkTeamActivities, IDeveloperActivities
    {
        public void Communicate()
        {
            Console.WriteLine("I'm talking to the product owner");
        }

        public void Plan()
        {
            Console.WriteLine("I'm planning the architecture of a new functionality");
        }

        public void Develop()
        {
            Console.WriteLine("I'm developing the required functionalities");
        }
    }
}

using InterfaceSegregation.Interfaces;

namespace InterfaceSegregation.Models
{
    internal class Architect : IWorkTeamActivities, IDesignerActivities, IDeveloperActivities, ITesterActivities
    {
        public void Communicate()
        {
            Console.WriteLine("I'm talking to the product owner");
        }

        public void Design()
        {
            Console.WriteLine("I'm designing the architecture");
        }

        public void Plan()
        {
            Console.WriteLine("I'm planning the project resources");
        }

        public void Develop()
        {
            Console.WriteLine("I'm working on the architecture implementation");
        }

        public void Test()
        {
            Console.WriteLine("I'm testing the architecture implementation");
        }
    }
}

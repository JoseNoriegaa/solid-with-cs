using InterfaceSegregation.Interfaces;

namespace InterfaceSegregation
{
    public class Tester : IWorkTeamActivities, ITesterActivities
    {
        public Tester()
        {
        } 
        public void Communicate()
        {
            Console.WriteLine("I'm sharing the test results with the development team");
        }

        public void Plan()
        {
            Console.WriteLine("I'm planning the testing strategy");
        }

        public void Test()
        {
            Console.WriteLine("I'm testing the application");
        }
    }
}

using InterfaceSegregation.Interfaces;

namespace InterfaceSegregation.Models
{
    public class ScrumMaster : IWorkTeamActivities, IDesignerActivities
    {
        public ScrumMaster()
        {
        }

        public void Plan() 
        {
            Console.WriteLine("I'm planning user stories");
        }

        public void Communicate() 
        {
            Console.WriteLine("I'm talking to the team user");
        }

        public void Design() 
        {
            Console.WriteLine("I'm designing new futures");
        }
    }
}

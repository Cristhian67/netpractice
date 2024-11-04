using P2.Controllers;

namespace P2.Services
{
    public class PeopleService : IPeopleService
    {
        public bool Validate(People people)
        {
            if (string.IsNullOrEmpty(people.Name))
            {
                return false;
            }
            return true;
        }
    }
}

using Commander.Data;
using Commander.Models;

namespace Commender.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        IEnumerable<Command> ICommanderRepo.GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle & Pan"},
                new Command{Id=1, HowTo="Cut Bread", Line="Get a knife", Platform="Chopping Board"},
                new Command{Id=2, HowTo="Make cup of tea", Line="Place teabeg in cup", Platform="Kettle & Cup"}
            };

            return commands;
        }

        Command ICommanderRepo.GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle & Pan"};
        }
    }
}
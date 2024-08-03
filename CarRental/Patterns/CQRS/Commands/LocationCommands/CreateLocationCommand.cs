namespace CarRental.Patterns.CQRS.Commands.LocationCommands
{
    public class CreateLocationCommand
    {
        public string LocationName { get; set; }
        public bool Status { get; set; }
    }
}

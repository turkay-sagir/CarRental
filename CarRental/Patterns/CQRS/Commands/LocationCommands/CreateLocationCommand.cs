namespace CarRental.Patterns.CQRS.Commands.LocationCommands
{
    public class CreateLocationCommand
    {
        public string PickupLocationName { get; set; }
        public string DropOffLocationName { get; set; }
        public bool Status { get; set; }
    }
}

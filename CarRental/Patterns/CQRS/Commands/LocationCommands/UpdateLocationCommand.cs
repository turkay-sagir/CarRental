namespace CarRental.Patterns.CQRS.Commands.LocationCommands
{
    public class UpdateLocationCommand
    {
        public int LocationId { get; set; }
        public string PickupLocationName { get; set; }
        public string DropOffLocationName { get; set; }
        public bool Status { get; set; }
    }
}

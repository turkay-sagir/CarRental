﻿namespace CarRental.Patterns.CQRS.Commands.BrandCommands
{
    public class UpdateBrandCommand
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
    }
}

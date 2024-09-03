﻿using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.DAL.Entities
{
    public class Car
    {
        public int CarId { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public int Mileage { get; set; }
        public string EngineType { get; set; }
        public int Horsepower { get; set; }
        public string Transmission { get; set; }
        public bool HasAirConditioning { get; set; }
        public bool HasGPS { get; set; }
        public bool HasSunroof { get; set; }
        public bool HasBluetooth { get; set; }
        public bool HasBackupCamera { get; set; }
        public int NumberOfAirbags { get; set; }
        public bool HasABS { get; set; }
        public bool HasLaneAssist { get; set; }
        public bool HasParkingSensors { get; set; }
        public bool Status { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public List<CarRent> CarRents { get; set; }
    }
}

﻿namespace DentalClinicManagement.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Specialty { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }

        public string FullName => $"{FirstName} {LastName}";

    }
}

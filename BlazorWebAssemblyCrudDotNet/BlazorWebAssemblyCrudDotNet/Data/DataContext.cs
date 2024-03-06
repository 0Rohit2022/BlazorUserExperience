using BlazorWebAssemblyCrudDotNet8.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;

namespace BlazorWebAssemblyCrudDotNet.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Registration>().HasData(
                new Registration { Id = 1, Name = "Ranvijay", Email = "ranvijay@gmail.com", Password = "ranvijary", Image = GetDefaultPhoto(), Username = "ranvijay1", OTP = "123456" },
                new Registration { Id = 2, Name = "Ramu", Email = "ramu@gmail.com", Password = "ramu", Image = GetDefaultPhoto(), Username = "ramu2", OTP = "654321" },
                new Registration { Id = 3, Name = "Shamu", Email = "shamu@gmail.com", Password = "shamu", Image = GetDefaultPhoto(), Username = "shamu3", OTP = "987654" }
                );
        }

        public DbSet<Registration> Registration { get; set; }

        // Method to convert base64 string to byte array
        private byte[] ConvertBase64ToByteArray(string base64String)
        {
            // Remove the prefix if it exists
            if (base64String.Contains(","))
            {
                base64String = base64String.Split(',')[1];
            }

            // Convert base64 string to byte array
            byte[] imageBytes = Convert.FromBase64String(base64String);
            return imageBytes;
        }

        // Method to get default photo as byte array
        private byte[] GetDefaultPhoto()
        {
            try
            {
                // Simulate a base64 encoded image string received from Postman
                string base64ImageString = "/* Insert your base64 image string here */";
                byte[] imageBytes = ConvertBase64ToByteArray(base64ImageString);

                // Check if the image size exceeds 10MB
                if (imageBytes.Length > 10 * 1024 * 1024) // 10MB in bytes
                {
                    throw new Exception("Image size exceeds 10MB.");
                }

                return imageBytes;
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur during conversion
                Console.WriteLine($"An error occurred while converting base64 to byte array: {ex.Message}");
                return Array.Empty<byte>(); // Return an empty byte array as fallback
            }
        }
    }
}

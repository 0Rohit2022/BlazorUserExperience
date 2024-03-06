using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorWebAssemblyCrudDotNet8.Shared.Entities
{
    public class Registration
    {
        public int Id { get; set; }

        public string? Username { get; set; } = string.Empty;
        public string? Name { get; set; } = string.Empty;

        public string? Email { get; set; } = string.Empty;

        public string? Password { get; set; } = string.Empty;
        public string? OTP { get; set; }
        public byte[]? Image { get; set; } // Nullable byte array for storing photo

        

        
    }
}

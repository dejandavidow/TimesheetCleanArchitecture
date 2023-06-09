﻿using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string? ClientName { get; set; }
        [Required]
        [MaxLength(100)]
        public string? Adress { get; set; }
        [Required]
        [MaxLength(100)]
        public string? City { get; set; }
        [Required]
        [MaxLength(100)]
        public string? PostalCode { get; set; }
    }
}

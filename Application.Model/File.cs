﻿using System.ComponentModel.DataAnnotations;


namespace Application.Model
{
    public enum FileType
    {
        Photo = 1,
        Document = 2
    }
    public class File: BaseEntity
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "The {0} must be at most {1} characters long.")]
        public string Name { get; set; }

        [Required]
        public string RelativePath { get; set; }

        [Required]
        public FileType FileType { get; set; }

        public string MimeType { get; set; }

        public int Size { get; set; }
        
    }
}

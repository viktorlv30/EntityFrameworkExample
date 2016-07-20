using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace EFExample
{
    public class Position
    {
        public Position()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Index(IsUnique = true)]
        public int Code { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
    }
}
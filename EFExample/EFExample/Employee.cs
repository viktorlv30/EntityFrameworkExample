using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFExample
{
    public class Employee //anlog of table in SQL
    {
        [Key] //Primary key in SQL
        public Guid Id { get; set; } //Accesors - analog of columns

        [MinLength(3, ErrorMessage = "Length must be more than 3 characters")]
        [MaxLength(100, ErrorMessage = "Length must be less than 100 characters")]
        [Required] //analog - Not null
        public string FirstName { get; set; } //string will be translated into - minlength - (nvarchar) and - maxlength - (100)}

        public string LastName { get; set; }
        
        public double Salary { get; set; }

        [Column(TypeName = "datetime2")] //transliruye datetime C# z DateTime to SQL datetime2
        public DateTime BirthDate { get; set; }

        [Required]
        public virtual Position Position { get; set; }

    }
}
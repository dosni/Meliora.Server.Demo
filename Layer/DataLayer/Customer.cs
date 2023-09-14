using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace FUIServerSample.Layer.DataLayer
{
    //[Index(nameof(Tax_Id), IsUnique = true)]
    //[Index(nameof(SSN), IsUnique = true)]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Nama Depan maksimal karakter 50 dan minimal 3"), MinLength(3)]
        [Column(TypeName = "varchar(50)")]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(50, ErrorMessage = "Nama Belakang maksimal karakter 50 dan minimal 3"), MinLength(3)]
        [Column(TypeName = "varchar(50)")]
        public string LastName { get; set; } = string.Empty;

        [NotMapped]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "varchar(15)")]
        public string Phone { get; set; } = string.Empty;

      
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string Address { get; set; } = string.Empty;


        [Column(TypeName = "varchar(50)")]
        public string City { get; set; } = string.Empty;

        [Column(TypeName = "varchar(50)")]
        public string Postal_Code { get; set; } = string.Empty;

        [Column(TypeName = "varchar(50)")]
        public string Country { get; set; } = string.Empty;

        [Column(TypeName = "char(1)")]
        public string Cust_Type { get; set; } = string.Empty;
        


        [Column(TypeName = "varchar(15)")]
        public string Cellular { get; set; } = string.Empty;


        [Column(TypeName = "varchar(50)")]
        [AllowNull]
        public string Email { get; set; } = string.Empty;

        [Column(TypeName = "varchar(20)")]
        public string Tax_Id { get; set; } = string.Empty;


        [Column(TypeName = "varchar(20)")]
        public string SSN { get; set; } = string.Empty; // KTP = Social Security Number

      





  
    }
}

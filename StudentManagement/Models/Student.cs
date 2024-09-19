using System.ComponentModel.DataAnnotations;
namespace StudentManagement.Models
{
    public class Student
    {
        [Key]
        public int ID {get;set;}
        [Required]
        public string FirstName {get;set;}
        [Required]
        public string LastName {get;set;}
        [Required]
        public string RegNum {get;set;}
        [Required]
        public string Section {get;set;}
        [Required]
        public string Program {get;set;}
    }
}
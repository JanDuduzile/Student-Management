using Microsoft.AspNetCore.Mvc.Rendering;

namespace StudentManagement.Models
{
    public class StudentViewModel
    {
        public List<Student> ? Students {get;set;}
        public SelectList? Section {get;set;}
        public string? Program {get;set;}
    }
}
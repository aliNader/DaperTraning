using DataAccessLayer.Interfaces;

namespace DataAccessLayer.Models
{
    public class Student:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public decimal Mark { get; set; }
    }
}

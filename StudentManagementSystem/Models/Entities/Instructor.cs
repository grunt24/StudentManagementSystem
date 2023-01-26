using System.Numerics;

namespace StudentManagementSystem.Models.Entities
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Education { get; set; }
        public string ContactNumber{ get; set; }
        public string EmailAddress { get; set; }
        public string School { get; set; }
    }
}

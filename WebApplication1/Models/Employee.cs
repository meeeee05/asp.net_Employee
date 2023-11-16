using System.ComponentModel.DataAnnotations;
namespace WebApplication1.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Area { get; set; }

        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }
    }
}
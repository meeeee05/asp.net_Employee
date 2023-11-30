using System.ComponentModel.DataAnnotations;
namespace WebApplication1.Models
{
    public class Employee
    {
        [Display(Name = "id")]
        public int Id { get; set; }

        [Display(Name = "名前")]
        public string Name { get; set; }

        [Display(Name = "エリア")]
        public string Area { get; set; }

        [Display(Name = "入社日")]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }

    }
}



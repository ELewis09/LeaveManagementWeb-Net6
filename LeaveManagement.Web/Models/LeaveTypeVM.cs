using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }
        [Display(Name = "Leave Type Name")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Allocated Days")]
        [Required]
        [Range(1, 150, ErrorMessage ="Please Enter a Valid Number")]
        public int DefaultDays { get; set; }

    }
}

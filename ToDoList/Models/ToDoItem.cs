using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class ToDoItem
    {
        [Key]
        public int Id { get; set; }

        [StringLength(200)]
        [Display(Name = "Title")]
        [Required(ErrorMessage = "Title is required and can't be longer than 200 characters")]
        public string Title { get; set; }

        [Display(Name = "Content")]
        public string Content { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date")]
        public DateTime? Date { get; set; }

        [DataType(DataType.Time)]
        [Display(Name = "Time")]
        public DateTime? Time { get; set; }
    }
}

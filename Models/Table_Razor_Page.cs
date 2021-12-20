using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPage.Models
{
    public class Table_Razor_Page
    {
        [Key]
        public int ID { get; set; }                                 //FIELD THAT WE DECLARE ON DB

        [Required(ErrorMessage = "Please insert Name")]             //ERROR MESSAGE THAT WILL BE SHOWN ON asp-validation-for
        public string Name { get; set; }

        [Required(ErrorMessage = "Please insert Date of Birth")]
        [DataType(DataType.Date)]                                       //DECLARE THIS datetime VARIABLE INTO DATE ONLY
        public DateTime dateOfBirth { get; set; }

        public DateTime dateTimeInsert { get; set; }

        public DateTime dateTimeUpdate { get; set; }
    }
}
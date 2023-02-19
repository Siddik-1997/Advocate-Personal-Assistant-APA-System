using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdvocatePersonalAssistantSystem.Models
{
    public class Reminder1
    {
        [Key]

        public int SL_no { get; set; }

        [Required(ErrorMessage = "Case ID is Required.")]
        [Display(Name = "Case ID")]
        public int Case_Id { get; set; }

        [Required(ErrorMessage = "Upcoming Reminder date is Required.")]
        [Display(Name = " Date-Time")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy:MM:dd: HH:mm}")]
        public DateTime Rdate { get; set; }



        [Required(ErrorMessage = "RMg is Required")]
        [Display(Name = "RMg.")]
        public string rms { get; set; }
    }
}

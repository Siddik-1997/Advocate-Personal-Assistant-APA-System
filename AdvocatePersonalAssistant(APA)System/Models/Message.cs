using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdvocatePersonalAssistantSystem.Models
{
    public class Message
    {
        [Key]
        public int M_Id { get; set; }

        [Required(ErrorMessage = "Case ID is Required.")]
        [Display(Name = "Case ID")]
        public int Case_Id { get; set; }

        [Required(ErrorMessage = "Message Delivery date is Required.")]
        [Display(Name = " Date-Time")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy:MM:dd: HH:mm}")]
        public DateTime  Mdate { get; set; }


  

        [Required(ErrorMessage = "Enter valid phone number")]
        [Display(Name = "Phone.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Required filed doesn't empty ")]
        [Display(Name = "Message.")]
        public string Msg { get; set; }
    }
}

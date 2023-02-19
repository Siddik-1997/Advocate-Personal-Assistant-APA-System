using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdvocatePersonalAssistantSystem.Models
{
    public class CaseProfile
    {
        [Key]
        [Required(ErrorMessage = "Case ID is Required.")]
        [Display(Name = "Name")]
        public int Case_Id { get; set; }
        



        [Required(ErrorMessage = "Case Name Required.")]
        [Display(Name = "Case Name")]
        public string CaseName { get; set; }

        [Required(ErrorMessage = "Case History Required.")]
        [Display(Name = "Case History")]
        public string CaseHistory { get; set; }

        [Required(ErrorMessage = "Client Name is required")]
        [Display(Name = "Client Name.")]
        public string ClientName { get; set; }

        [Required(ErrorMessage = "Plainiff Name is required")]
        [Display(Name = "Plaintiff Name.")]
        public string Plaintiff { get; set; }

        [Required(ErrorMessage = "Defendant Name is required")]
        [Display(Name = "Defendant Name.")]
        public string Defendant { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Fee")]
        public string Fee { get; set; }

        [Required]
        [Display(Name = "Issue Date")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode=true, DataFormatString="{0:yyyy:MM:dd: HH:mm}" )]
        public DateTime? Idate { get; set; }

        [Required]
        [Display(Name = "Hearing Schedule")]
         [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy:MM:dd: HH:mm}")]
        public DateTime? Hdate { get; set; }


       
    }
}

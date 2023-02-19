using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdvocatePersonalAssistantSystem.Models
{
    public class CyberLaw
    {
        [Key]
        [Required(ErrorMessage = "Insert the Law no.")]
        [Display(Name = "Law No")]
        public int Law_no { get; set; }

        [Required(ErrorMessage = "Insert the law Name")]
        [Display(Name = "Law Name")]
        public string LawName { get; set; }

        [Required(ErrorMessage = "Insert the required Punishment")]
        [Display(Name = "Punishment.")]
        public string Punishment { get; set; }

        [Required(ErrorMessage = "Keep the law details")]
        [Display(Name = "Law Details.")]
        public string LDeails { get; set; }

        



    }
}

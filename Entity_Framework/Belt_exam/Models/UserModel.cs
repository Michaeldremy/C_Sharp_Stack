using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Belt_exam.Models
{
    public class User
    {
        [Key]
        public int UserId {get;set;}
        [Required]
        [MinLength(2, ErrorMessage = "First Name must be 2 characters or longer!")]
        [Display(Name = "First Name")]
        public string FirstName {get;set;}
        [Required]
        [MinLength(2, ErrorMessage = "Last Name must be 2 characters or longer!")]
        [Display(Name = "Last Name")]
        public string LastName {get;set;}
        [EmailAddress]
        [Required]
        public string Email {get;set;}
        [DataType(DataType.Password)]
        [Required]
        [MinLength(6, ErrorMessage = "Password must be 6 characters or longer!")]
        public string Password {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt{get;set;} = DateTime.Now;
        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string ConfirmPW {get;set;}
        
        // Navigation Properties
        public List<Sport> CreatedSports {get;set;}
        public List<Association> CreatedAssociation {get;set;}
    }
}
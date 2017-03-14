using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyMasale.Shared.DTO
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string EmailId { get; set; }
        public int? Gender { get; set; }
        public string CompanyName { get; set; }
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string StateId { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Password { get; set; }
        public bool? IsTaxExempt { get; set; }
        public bool? IsAdmin { get; set; }
        public string AdminComment { get; set; }
        public int? Status { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public int? OrderUser { get; set; }
        public bool? IsEmailValidated { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}

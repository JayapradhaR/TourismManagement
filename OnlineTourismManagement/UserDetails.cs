using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineTourismManagement
{
    public class UserDetails
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public long MobileNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string MailId { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public int Role { get; set; }
        public UserDetails()
        { }
        public UserDetails(string firstName, string lastName, long mobileNumber, DateTime dateOfBirth,string gender, string mailId, string password,int roleId)
        {
            FirstName = firstName;
            LastName = lastName;
            MobileNumber = mobileNumber;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            MailId = mailId;
            Password = password;
            Role = roleId;
        }
    }
}
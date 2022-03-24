using System;

namespace BusinessLayer
{
    public class Member
    {
        public Member()
        {
        }

        public int MemberID { get; set; }
        public string MemberName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public Member(int memberID, string memberName, string email, string password, string city, string country)
        {
            MemberID = memberID;
            MemberName = memberName;
            Email = email;
            Password = password;
            City = city;
            Country = country;
        }
    }
}

using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class MemberDAO
    {
        private List<Member> members = new List<Member>()
        {
            new Member(1, "Anna", "anna@gmail.com", "anna", "Las Vegas", "US"),
            new Member(2, "John", "John@gmail.com", "john", "New York", "US")
        };

        public List<Member> GetMembers => members;

        public Member Login(string email, string password)
        {
            foreach(Member m in members)
            {
                if(m.Email.Equals(email) && m.Password.Equals(password))
                {
                    return m;
                }
            }
            return null;
        }

        public Member getMember(int id)
        {
            foreach (Member m in members)
            {
                if (m.MemberID.Equals(id))
                {
                    return m;
                }
            }
            return null;
        }

        public void addMember(Member newMember)
        {
            if (getMember(newMember.MemberID) == null && Login(newMember.Email, newMember.Password) == null)
            {
                members.Add(newMember);
            }
            else
            {
                throw new Exception("Member infomation existed");
            }
        }

        public void updateMember(Member member)
        {
            Member mem = getMember(member.MemberID);
            if (mem != null)
            {
                var index = members.IndexOf(mem);
                members[index] = member;
            }
            else
            {
                throw new Exception("Did not exist");
            }
        }

        public void deleteMember(int Id)
        {
            Member mem = getMember(Id);
            if (mem != null)
            {
                members.Remove(mem);
            }
            else
            {
                throw new Exception("Did not exist");
            }
        }
    }
}

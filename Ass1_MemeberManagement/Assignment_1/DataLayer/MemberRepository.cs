using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MemberRepository : IMemberRepository
    {
        MemberDAO m = new MemberDAO();
        void IMemberRepository.Add(Member member) => m.addMember(member);

        void IMemberRepository.Delete(int id) => m.deleteMember(id);

        Member IMemberRepository.GetMemberByID(int id) => m.getMember(id);

        IEnumerable<Member> IMemberRepository.GetMembers() => m.GetMembers;

        Member IMemberRepository.Login(string email, string password) => m.Login(email, password);

        void IMemberRepository.Update(Member member) => m.updateMember(member);
    }
}

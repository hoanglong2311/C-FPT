using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IMemberRepository
    {
        IEnumerable<Member> GetMembers();
        Member Login(string email, string password);
        Member GetMemberByID(int id);
        void Add(Member member);
        void Delete(int id);
        void Update(Member member);
    }
}

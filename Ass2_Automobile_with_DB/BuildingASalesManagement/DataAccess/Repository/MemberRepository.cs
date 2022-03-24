using System.Collections.Generic;
using BusinessObject;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public IEnumerable<MemberObject> GetMembers() 
            => MemberDAO.Instance.GetMemberList();
        public MemberObject GetMemberByID(int memberId) 
            => MemberDAO.Instance.GetMemberByID(memberId);
        public void InsertMember(MemberObject member) 
            => MemberDAO.Instance.AddNew(member);
        public void DeleteMember(int memberId) 
            => MemberDAO.Instance.Remove(memberId);
        public void UpdateMember(MemberObject member) 
            => MemberDAO.Instance.Update(member);
    }
}

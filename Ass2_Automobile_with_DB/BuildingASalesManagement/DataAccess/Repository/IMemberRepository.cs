﻿using System.Collections.Generic;
using BusinessObject;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<MemberObject> GetMembers();
        MemberObject GetMemberByID(int memberId);
        void InsertMember(MemberObject member);
        void DeleteMember(int memberId);
        void UpdateMember(MemberObject member);
    }
}

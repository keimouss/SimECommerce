using SimECommerce.BOL.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SimECommerce.Application.Services.Queries
{
    public class UserExistQuery : BaseQuery<AspNetUsers>
    {
        public UserExistQuery(string userName) => this.UserName = userName;
        public string UserName { get; }
        public override Expression<Func<AspNetUsers, bool>> Criteria =>
            u => u.UserName == this.UserName;
        public override int Take => 1;
    }
}

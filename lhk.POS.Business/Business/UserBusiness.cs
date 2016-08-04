//
//---------------------------------------------- //
//                       @ Project : lhk.POS	   //
//                       @ File Name : UserBusiness.cs                  //
//                       @ Date : 6/6/2014		  //
//                       @ Author : khoatd		  //
//--------------------------------------------- //
//


using System;
using System.Linq;
using System.Collections.Generic;
using lhk.POS.Core.Domain;
using lhk.POS.Data;
namespace lhk.POS.Common.Business
{
    public class UserBusiness : GenericBuiness<User>
    {
        public UserBusiness(IRepository<User> repository)
        {
            _repository = repository;
        }

        public User GetUser(string userName, string role, bool isDeleted = false)
        {
            return this.GetAll().FirstOrDefault(user =>
                                                user.UserName.Equals(userName, StringComparison.InvariantCultureIgnoreCase) &&
                                                user.Role.Equals(role, StringComparison.InvariantCultureIgnoreCase) &&
                                                user.IsDeleted == isDeleted);
        }
    }
}

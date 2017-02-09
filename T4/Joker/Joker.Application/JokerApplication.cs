
//------------------------------------------------------------------------------
// Joooooooooooker
//    此代码由T4模板自动生成
//	   生成时间 2017-02-06 13:53:17 by joker
//    对此文件的更改可能会导致不正确的行为，并且如果重新生成代码，这些更改将会丢失。
// Joooooooooooker
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Joker.Domain.Entity.SystemManage;
using Joker.Domain.IRepository.SystemManage;
using Joker.Repository.SystemManage;
namespace Joker.Application.SystemManage
{	
	/// <summary>
	/// UserApp
	/// </summary>	
	public class UserApp
	{
	    private IUserRepository service=new UserRepository();

		public List<UserEntity> GetList()
        {
            return service.IQueryable().ToList();
        }

	    public UserEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }

        public void Delete(UserEntity entity)
        {
            service.Delete(entity);
        }

		public void SubmitForm(UserEntity entity, string keyValue)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                entity.Modify(keyValue);
                service.Update(entity);
            }
            else
            {
                entity.Create();
                service.Insert(entity);
            }
        }

    }
}




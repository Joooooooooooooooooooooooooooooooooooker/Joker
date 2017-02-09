
//------------------------------------------------------------------------------
// Joooooooooooker
//    此代码由T4模板自动生成
//	   生成时间 2017-02-06 13:53:43 by joker
//    对此文件的更改可能会导致不正确的行为，并且如果重新生成代码，这些更改将会丢失。
// Joooooooooooker
//------------------------------------------------------------------------------
using Joker.Domain.Entity.SystemManage;
using System.Data.Entity.ModelConfiguration;
namespace Joker.Mapping.SystemManage
{	
	/// <summary>
	/// UserMap
	/// </summary>	
	public class UserMap:EntityTypeConfiguration<UserEntity>
	{
	   public UserMap()
	   {
	      this.ToTable("Sys_User");
		  this.HasKey(t=>t.F_Id);
	   }
    }
}




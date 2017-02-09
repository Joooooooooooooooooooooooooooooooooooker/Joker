

//------------------------------------------------------------------------------
// Joooooooooooker
//    此代码由T4模板自动生成
//	   生成时间 2017-02-06 13:53:31 by joker
//    对此文件的更改可能会导致不正确的行为，并且如果重新生成代码，这些更改将会丢失。
// Joooooooooooker
//------------------------------------------------------------------------------

using System;
namespace Joker.Domain.Entity.SystemManage
{	
	/// <summary>
	/// UserEntity
	/// </summary>	
	public class UserEntity:IEntity<UserEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
	{
	  public string F_Id { get; set; }
	  public string F_Account { get; set; }
	  public string F_RealName { get; set; }
	  public string F_NickName { get; set; }
	  public string F_HeadIcon { get; set; }
	  public bool? F_Gender { get; set; }
	  public DateTime? F_Birthday { get; set; }
	  public string F_MobilePhone { get; set; }
	  public string F_Email { get; set; }
	  public string F_WeChat { get; set; }
	  public string F_ManagerId { get; set; }
	  public int? F_SecurityLevel { get; set; }
	  public string F_Signature { get; set; }
	  public string F_OrganizeId { get; set; }
	  public string F_DepartmentId { get; set; }
	  public string F_RoleId { get; set; }
	  public string F_DutyId { get; set; }
	  public bool? F_IsAdministrator { get; set; }
	  public int? F_SortCode { get; set; }
	  public bool? F_DeleteMark { get; set; }
	  public bool? F_EnabledMark { get; set; }
	  public string F_Description { get; set; }
	  public DateTime? F_CreatorTime { get; set; }
	  public string F_CreatorUserId { get; set; }
	  public DateTime? F_LastModifyTime { get; set; }
	  public string F_LastModifyUserId { get; set; }
	  public DateTime? F_DeleteTime { get; set; }
	  public string F_DeleteUserId { get; set; }
 
    }
}




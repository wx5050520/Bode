﻿// <autogenerated>
//   This file was generated by T4 code generator ContractsCodeScript.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>


using System;
using System.Linq;
using OSharp.Core;
using OSharp.Utility.Data;
using System.Linq.Expressions;
using System.Threading.Tasks;
using OSharp.Core.Dependency;
using Bode.Services.Core.Dtos.User;
using Bode.Services.Core.Models.User;

namespace Bode.Services.Core.Contracts
{
	public partial interface IUserContract : IScopeDependency
	{
		                #region FeedBack信息业务

                IQueryable<FeedBack> FeedBacks { get; }

                /// <summary>
                /// 检查FeedBack信息是否存在
                /// </summary>
                /// <param name="predicate">检查谓语表达式</param>
                /// <param name="id">更新的FeedBack编号</param>
                /// <returns>FeedBack信息是否存在</returns>
                Task<bool> CheckFeedBackExists(Expression<Func<FeedBack, bool>> predicate, int id = 0);
                
                /// <summary>
                /// 保存FeedBack信息(新增/更新)
                /// </summary>
                /// <param name="updateForeignKey">更新时是否更新外键信息</param>
                /// <param name="dtos">要保存的FeedBackDto信息</param>
                /// <returns>业务操作集合</returns>
                Task<OperationResult> SaveFeedBacks(bool updateForeignKey=false,params FeedBackDto[] dtos);

                /// <summary>
                /// 删除FeedBack信息
                /// </summary>
                /// <param name="ids">要删除的Id编号</param>
                /// <returns>业务操作结果</returns>
                Task<OperationResult> DeleteFeedBacks(params int[] ids);

                #endregion

                                #region UserInfo信息业务

                IQueryable<UserInfo> UserInfos { get; }

                /// <summary>
                /// 检查UserInfo信息是否存在
                /// </summary>
                /// <param name="predicate">检查谓语表达式</param>
                /// <param name="id">更新的UserInfo编号</param>
                /// <returns>UserInfo信息是否存在</returns>
                Task<bool> CheckUserInfoExists(Expression<Func<UserInfo, bool>> predicate, int id = 0);
                
                /// <summary>
                /// 保存UserInfo信息(新增/更新)
                /// </summary>
                /// <param name="updateForeignKey">更新时是否更新外键信息</param>
                /// <param name="dtos">要保存的UserInfoDto信息</param>
                /// <returns>业务操作集合</returns>
                Task<OperationResult> SaveUserInfos(bool updateForeignKey=false,params UserInfoDto[] dtos);

                /// <summary>
                /// 删除UserInfo信息
                /// </summary>
                /// <param name="ids">要删除的Id编号</param>
                /// <returns>业务操作结果</returns>
                Task<OperationResult> DeleteUserInfos(params int[] ids);

                #endregion

                                #region ValidateCode信息业务

                IQueryable<ValidateCode> ValidateCodes { get; }

                /// <summary>
                /// 检查ValidateCode信息是否存在
                /// </summary>
                /// <param name="predicate">检查谓语表达式</param>
                /// <param name="id">更新的ValidateCode编号</param>
                /// <returns>ValidateCode信息是否存在</returns>
                Task<bool> CheckValidateCodeExists(Expression<Func<ValidateCode, bool>> predicate, int id = 0);
                
                /// <summary>
                /// 保存ValidateCode信息(新增/更新)
                /// </summary>
                /// <param name="updateForeignKey">更新时是否更新外键信息</param>
                /// <param name="dtos">要保存的ValidateCodeDto信息</param>
                /// <returns>业务操作集合</returns>
                Task<OperationResult> SaveValidateCodes(bool updateForeignKey=false,params ValidateCodeDto[] dtos);

                /// <summary>
                /// 删除ValidateCode信息
                /// </summary>
                /// <param name="ids">要删除的Id编号</param>
                /// <returns>业务操作结果</returns>
                Task<OperationResult> DeleteValidateCodes(params int[] ids);

                #endregion

                	}
}

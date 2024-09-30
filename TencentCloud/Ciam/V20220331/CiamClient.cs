/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Ciam.V20220331
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ciam.V20220331.Models;

   public class CiamClient : AbstractClient{

       private const string endpoint = "ciam.tencentcloudapi.com";
       private const string version = "2022-03-31";
       private const string sdkVersion = "SDK_NET_3.0.1100";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CiamClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CiamClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 新建接口导入用户任务
        /// </summary>
        /// <param name="req"><see cref="CreateApiImportUserJobRequest"/></param>
        /// <returns><see cref="CreateApiImportUserJobResponse"/></returns>
        public Task<CreateApiImportUserJobResponse> CreateApiImportUserJob(CreateApiImportUserJobRequest req)
        {
            return InternalRequestAsync<CreateApiImportUserJobResponse>(req, "CreateApiImportUserJob");
        }

        /// <summary>
        /// 新建接口导入用户任务
        /// </summary>
        /// <param name="req"><see cref="CreateApiImportUserJobRequest"/></param>
        /// <returns><see cref="CreateApiImportUserJobResponse"/></returns>
        public CreateApiImportUserJobResponse CreateApiImportUserJobSync(CreateApiImportUserJobRequest req)
        {
            return InternalRequestAsync<CreateApiImportUserJobResponse>(req, "CreateApiImportUserJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新建文件导出用户任务
        /// </summary>
        /// <param name="req"><see cref="CreateFileExportUserJobRequest"/></param>
        /// <returns><see cref="CreateFileExportUserJobResponse"/></returns>
        public Task<CreateFileExportUserJobResponse> CreateFileExportUserJob(CreateFileExportUserJobRequest req)
        {
            return InternalRequestAsync<CreateFileExportUserJobResponse>(req, "CreateFileExportUserJob");
        }

        /// <summary>
        /// 新建文件导出用户任务
        /// </summary>
        /// <param name="req"><see cref="CreateFileExportUserJobRequest"/></param>
        /// <returns><see cref="CreateFileExportUserJobResponse"/></returns>
        public CreateFileExportUserJobResponse CreateFileExportUserJobSync(CreateFileExportUserJobRequest req)
        {
            return InternalRequestAsync<CreateFileExportUserJobResponse>(req, "CreateFileExportUserJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建用户
        /// </summary>
        /// <param name="req"><see cref="CreateUserRequest"/></param>
        /// <returns><see cref="CreateUserResponse"/></returns>
        public Task<CreateUserResponse> CreateUser(CreateUserRequest req)
        {
            return InternalRequestAsync<CreateUserResponse>(req, "CreateUser");
        }

        /// <summary>
        /// 创建用户
        /// </summary>
        /// <param name="req"><see cref="CreateUserRequest"/></param>
        /// <returns><see cref="CreateUserResponse"/></returns>
        public CreateUserResponse CreateUserSync(CreateUserRequest req)
        {
            return InternalRequestAsync<CreateUserResponse>(req, "CreateUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建用户组
        /// </summary>
        /// <param name="req"><see cref="CreateUserGroupRequest"/></param>
        /// <returns><see cref="CreateUserGroupResponse"/></returns>
        public Task<CreateUserGroupResponse> CreateUserGroup(CreateUserGroupRequest req)
        {
            return InternalRequestAsync<CreateUserGroupResponse>(req, "CreateUserGroup");
        }

        /// <summary>
        /// 创建用户组
        /// </summary>
        /// <param name="req"><see cref="CreateUserGroupRequest"/></param>
        /// <returns><see cref="CreateUserGroupResponse"/></returns>
        public CreateUserGroupResponse CreateUserGroupSync(CreateUserGroupRequest req)
        {
            return InternalRequestAsync<CreateUserGroupResponse>(req, "CreateUserGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建用户目录
        /// </summary>
        /// <param name="req"><see cref="CreateUserStoreRequest"/></param>
        /// <returns><see cref="CreateUserStoreResponse"/></returns>
        public Task<CreateUserStoreResponse> CreateUserStore(CreateUserStoreRequest req)
        {
            return InternalRequestAsync<CreateUserStoreResponse>(req, "CreateUserStore");
        }

        /// <summary>
        /// 创建用户目录
        /// </summary>
        /// <param name="req"><see cref="CreateUserStoreRequest"/></param>
        /// <returns><see cref="CreateUserStoreResponse"/></returns>
        public CreateUserStoreResponse CreateUserStoreSync(CreateUserStoreRequest req)
        {
            return InternalRequestAsync<CreateUserStoreResponse>(req, "CreateUserStore")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量删除用户组
        /// </summary>
        /// <param name="req"><see cref="DeleteUserGroupsRequest"/></param>
        /// <returns><see cref="DeleteUserGroupsResponse"/></returns>
        public Task<DeleteUserGroupsResponse> DeleteUserGroups(DeleteUserGroupsRequest req)
        {
            return InternalRequestAsync<DeleteUserGroupsResponse>(req, "DeleteUserGroups");
        }

        /// <summary>
        /// 批量删除用户组
        /// </summary>
        /// <param name="req"><see cref="DeleteUserGroupsRequest"/></param>
        /// <returns><see cref="DeleteUserGroupsResponse"/></returns>
        public DeleteUserGroupsResponse DeleteUserGroupsSync(DeleteUserGroupsRequest req)
        {
            return InternalRequestAsync<DeleteUserGroupsResponse>(req, "DeleteUserGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除用户目录
        /// </summary>
        /// <param name="req"><see cref="DeleteUserStoreRequest"/></param>
        /// <returns><see cref="DeleteUserStoreResponse"/></returns>
        public Task<DeleteUserStoreResponse> DeleteUserStore(DeleteUserStoreRequest req)
        {
            return InternalRequestAsync<DeleteUserStoreResponse>(req, "DeleteUserStore");
        }

        /// <summary>
        /// 删除用户目录
        /// </summary>
        /// <param name="req"><see cref="DeleteUserStoreRequest"/></param>
        /// <returns><see cref="DeleteUserStoreResponse"/></returns>
        public DeleteUserStoreResponse DeleteUserStoreSync(DeleteUserStoreRequest req)
        {
            return InternalRequestAsync<DeleteUserStoreResponse>(req, "DeleteUserStore")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量删除用户
        /// </summary>
        /// <param name="req"><see cref="DeleteUsersRequest"/></param>
        /// <returns><see cref="DeleteUsersResponse"/></returns>
        public Task<DeleteUsersResponse> DeleteUsers(DeleteUsersRequest req)
        {
            return InternalRequestAsync<DeleteUsersResponse>(req, "DeleteUsers");
        }

        /// <summary>
        /// 批量删除用户
        /// </summary>
        /// <param name="req"><see cref="DeleteUsersRequest"/></param>
        /// <returns><see cref="DeleteUsersResponse"/></returns>
        public DeleteUsersResponse DeleteUsersSync(DeleteUsersRequest req)
        {
            return InternalRequestAsync<DeleteUsersResponse>(req, "DeleteUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 多条件查询用户信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRequest"/></param>
        /// <returns><see cref="DescribeUserResponse"/></returns>
        public Task<DescribeUserResponse> DescribeUser(DescribeUserRequest req)
        {
            return InternalRequestAsync<DescribeUserResponse>(req, "DescribeUser");
        }

        /// <summary>
        /// 多条件查询用户信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRequest"/></param>
        /// <returns><see cref="DescribeUserResponse"/></returns>
        public DescribeUserResponse DescribeUserSync(DescribeUserRequest req)
        {
            return InternalRequestAsync<DescribeUserResponse>(req, "DescribeUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据ID查询用户信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserByIdRequest"/></param>
        /// <returns><see cref="DescribeUserByIdResponse"/></returns>
        public Task<DescribeUserByIdResponse> DescribeUserById(DescribeUserByIdRequest req)
        {
            return InternalRequestAsync<DescribeUserByIdResponse>(req, "DescribeUserById");
        }

        /// <summary>
        /// 根据ID查询用户信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserByIdRequest"/></param>
        /// <returns><see cref="DescribeUserByIdResponse"/></returns>
        public DescribeUserByIdResponse DescribeUserByIdSync(DescribeUserByIdRequest req)
        {
            return InternalRequestAsync<DescribeUserByIdResponse>(req, "DescribeUserById")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 账号融合
        /// </summary>
        /// <param name="req"><see cref="LinkAccountRequest"/></param>
        /// <returns><see cref="LinkAccountResponse"/></returns>
        public Task<LinkAccountResponse> LinkAccount(LinkAccountRequest req)
        {
            return InternalRequestAsync<LinkAccountResponse>(req, "LinkAccount");
        }

        /// <summary>
        /// 账号融合
        /// </summary>
        /// <param name="req"><see cref="LinkAccountRequest"/></param>
        /// <returns><see cref="LinkAccountResponse"/></returns>
        public LinkAccountResponse LinkAccountSync(LinkAccountRequest req)
        {
            return InternalRequestAsync<LinkAccountResponse>(req, "LinkAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询任务详情
        /// </summary>
        /// <param name="req"><see cref="ListJobsRequest"/></param>
        /// <returns><see cref="ListJobsResponse"/></returns>
        public Task<ListJobsResponse> ListJobs(ListJobsRequest req)
        {
            return InternalRequestAsync<ListJobsResponse>(req, "ListJobs");
        }

        /// <summary>
        /// 查询任务详情
        /// </summary>
        /// <param name="req"><see cref="ListJobsRequest"/></param>
        /// <returns><see cref="ListJobsResponse"/></returns>
        public ListJobsResponse ListJobsSync(ListJobsRequest req)
        {
            return InternalRequestAsync<ListJobsResponse>(req, "ListJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询日志信息
        /// </summary>
        /// <param name="req"><see cref="ListLogMessageByConditionRequest"/></param>
        /// <returns><see cref="ListLogMessageByConditionResponse"/></returns>
        public Task<ListLogMessageByConditionResponse> ListLogMessageByCondition(ListLogMessageByConditionRequest req)
        {
            return InternalRequestAsync<ListLogMessageByConditionResponse>(req, "ListLogMessageByCondition");
        }

        /// <summary>
        /// 查询日志信息
        /// </summary>
        /// <param name="req"><see cref="ListLogMessageByConditionRequest"/></param>
        /// <returns><see cref="ListLogMessageByConditionResponse"/></returns>
        public ListLogMessageByConditionResponse ListLogMessageByConditionSync(ListLogMessageByConditionRequest req)
        {
            return InternalRequestAsync<ListLogMessageByConditionResponse>(req, "ListLogMessageByCondition")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户列表
        /// </summary>
        /// <param name="req"><see cref="ListUserRequest"/></param>
        /// <returns><see cref="ListUserResponse"/></returns>
        public Task<ListUserResponse> ListUser(ListUserRequest req)
        {
            return InternalRequestAsync<ListUserResponse>(req, "ListUser");
        }

        /// <summary>
        /// 查询用户列表
        /// </summary>
        /// <param name="req"><see cref="ListUserRequest"/></param>
        /// <returns><see cref="ListUserResponse"/></returns>
        public ListUserResponse ListUserSync(ListUserRequest req)
        {
            return InternalRequestAsync<ListUserResponse>(req, "ListUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据属性查询用户列表
        /// </summary>
        /// <param name="req"><see cref="ListUserByPropertyRequest"/></param>
        /// <returns><see cref="ListUserByPropertyResponse"/></returns>
        public Task<ListUserByPropertyResponse> ListUserByProperty(ListUserByPropertyRequest req)
        {
            return InternalRequestAsync<ListUserByPropertyResponse>(req, "ListUserByProperty");
        }

        /// <summary>
        /// 根据属性查询用户列表
        /// </summary>
        /// <param name="req"><see cref="ListUserByPropertyRequest"/></param>
        /// <returns><see cref="ListUserByPropertyResponse"/></returns>
        public ListUserByPropertyResponse ListUserByPropertySync(ListUserByPropertyRequest req)
        {
            return InternalRequestAsync<ListUserByPropertyResponse>(req, "ListUserByProperty")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户组列表
        /// </summary>
        /// <param name="req"><see cref="ListUserGroupsRequest"/></param>
        /// <returns><see cref="ListUserGroupsResponse"/></returns>
        public Task<ListUserGroupsResponse> ListUserGroups(ListUserGroupsRequest req)
        {
            return InternalRequestAsync<ListUserGroupsResponse>(req, "ListUserGroups");
        }

        /// <summary>
        /// 查询用户组列表
        /// </summary>
        /// <param name="req"><see cref="ListUserGroupsRequest"/></param>
        /// <returns><see cref="ListUserGroupsResponse"/></returns>
        public ListUserGroupsResponse ListUserGroupsSync(ListUserGroupsRequest req)
        {
            return InternalRequestAsync<ListUserGroupsResponse>(req, "ListUserGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户目录列表
        /// </summary>
        /// <param name="req"><see cref="ListUserStoreRequest"/></param>
        /// <returns><see cref="ListUserStoreResponse"/></returns>
        public Task<ListUserStoreResponse> ListUserStore(ListUserStoreRequest req)
        {
            return InternalRequestAsync<ListUserStoreResponse>(req, "ListUserStore");
        }

        /// <summary>
        /// 查询用户目录列表
        /// </summary>
        /// <param name="req"><see cref="ListUserStoreRequest"/></param>
        /// <returns><see cref="ListUserStoreResponse"/></returns>
        public ListUserStoreResponse ListUserStoreSync(ListUserStoreRequest req)
        {
            return InternalRequestAsync<ListUserStoreResponse>(req, "ListUserStore")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重置用户密码
        /// </summary>
        /// <param name="req"><see cref="ResetPasswordRequest"/></param>
        /// <returns><see cref="ResetPasswordResponse"/></returns>
        public Task<ResetPasswordResponse> ResetPassword(ResetPasswordRequest req)
        {
            return InternalRequestAsync<ResetPasswordResponse>(req, "ResetPassword");
        }

        /// <summary>
        /// 重置用户密码
        /// </summary>
        /// <param name="req"><see cref="ResetPasswordRequest"/></param>
        /// <returns><see cref="ResetPasswordResponse"/></returns>
        public ResetPasswordResponse ResetPasswordSync(ResetPasswordRequest req)
        {
            return InternalRequestAsync<ResetPasswordResponse>(req, "ResetPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置用户密码
        /// </summary>
        /// <param name="req"><see cref="SetPasswordRequest"/></param>
        /// <returns><see cref="SetPasswordResponse"/></returns>
        public Task<SetPasswordResponse> SetPassword(SetPasswordRequest req)
        {
            return InternalRequestAsync<SetPasswordResponse>(req, "SetPassword");
        }

        /// <summary>
        /// 设置用户密码
        /// </summary>
        /// <param name="req"><see cref="SetPasswordRequest"/></param>
        /// <returns><see cref="SetPasswordResponse"/></returns>
        public SetPasswordResponse SetPasswordSync(SetPasswordRequest req)
        {
            return InternalRequestAsync<SetPasswordResponse>(req, "SetPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新用户
        /// </summary>
        /// <param name="req"><see cref="UpdateUserRequest"/></param>
        /// <returns><see cref="UpdateUserResponse"/></returns>
        public Task<UpdateUserResponse> UpdateUser(UpdateUserRequest req)
        {
            return InternalRequestAsync<UpdateUserResponse>(req, "UpdateUser");
        }

        /// <summary>
        /// 更新用户
        /// </summary>
        /// <param name="req"><see cref="UpdateUserRequest"/></param>
        /// <returns><see cref="UpdateUserResponse"/></returns>
        public UpdateUserResponse UpdateUserSync(UpdateUserRequest req)
        {
            return InternalRequestAsync<UpdateUserResponse>(req, "UpdateUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新用户组
        /// </summary>
        /// <param name="req"><see cref="UpdateUserGroupRequest"/></param>
        /// <returns><see cref="UpdateUserGroupResponse"/></returns>
        public Task<UpdateUserGroupResponse> UpdateUserGroup(UpdateUserGroupRequest req)
        {
            return InternalRequestAsync<UpdateUserGroupResponse>(req, "UpdateUserGroup");
        }

        /// <summary>
        /// 更新用户组
        /// </summary>
        /// <param name="req"><see cref="UpdateUserGroupRequest"/></param>
        /// <returns><see cref="UpdateUserGroupResponse"/></returns>
        public UpdateUserGroupResponse UpdateUserGroupSync(UpdateUserGroupRequest req)
        {
            return InternalRequestAsync<UpdateUserGroupResponse>(req, "UpdateUserGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新用户状态
        /// </summary>
        /// <param name="req"><see cref="UpdateUserStatusRequest"/></param>
        /// <returns><see cref="UpdateUserStatusResponse"/></returns>
        public Task<UpdateUserStatusResponse> UpdateUserStatus(UpdateUserStatusRequest req)
        {
            return InternalRequestAsync<UpdateUserStatusResponse>(req, "UpdateUserStatus");
        }

        /// <summary>
        /// 更新用户状态
        /// </summary>
        /// <param name="req"><see cref="UpdateUserStatusRequest"/></param>
        /// <returns><see cref="UpdateUserStatusResponse"/></returns>
        public UpdateUserStatusResponse UpdateUserStatusSync(UpdateUserStatusRequest req)
        {
            return InternalRequestAsync<UpdateUserStatusResponse>(req, "UpdateUserStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新用户目录
        /// </summary>
        /// <param name="req"><see cref="UpdateUserStoreRequest"/></param>
        /// <returns><see cref="UpdateUserStoreResponse"/></returns>
        public Task<UpdateUserStoreResponse> UpdateUserStore(UpdateUserStoreRequest req)
        {
            return InternalRequestAsync<UpdateUserStoreResponse>(req, "UpdateUserStore");
        }

        /// <summary>
        /// 更新用户目录
        /// </summary>
        /// <param name="req"><see cref="UpdateUserStoreRequest"/></param>
        /// <returns><see cref="UpdateUserStoreResponse"/></returns>
        public UpdateUserStoreResponse UpdateUserStoreSync(UpdateUserStoreRequest req)
        {
            return InternalRequestAsync<UpdateUserStoreResponse>(req, "UpdateUserStore")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}

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

namespace TencentCloud.Dasb.V20191018
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Dasb.V20191018.Models;

   public class DasbClient : AbstractClient{

       private const string endpoint = "dasb.tencentcloudapi.com";
       private const string version = "2019-10-18";
       private const string sdkVersion = "SDK_NET_3.0.978";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DasbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public DasbClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 添加资产组成员
        /// </summary>
        /// <param name="req"><see cref="AddDeviceGroupMembersRequest"/></param>
        /// <returns><see cref="AddDeviceGroupMembersResponse"/></returns>
        public Task<AddDeviceGroupMembersResponse> AddDeviceGroupMembers(AddDeviceGroupMembersRequest req)
        {
            return InternalRequestAsync<AddDeviceGroupMembersResponse>(req, "AddDeviceGroupMembers");
        }

        /// <summary>
        /// 添加资产组成员
        /// </summary>
        /// <param name="req"><see cref="AddDeviceGroupMembersRequest"/></param>
        /// <returns><see cref="AddDeviceGroupMembersResponse"/></returns>
        public AddDeviceGroupMembersResponse AddDeviceGroupMembersSync(AddDeviceGroupMembersRequest req)
        {
            return InternalRequestAsync<AddDeviceGroupMembersResponse>(req, "AddDeviceGroupMembers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加用户组成员
        /// </summary>
        /// <param name="req"><see cref="AddUserGroupMembersRequest"/></param>
        /// <returns><see cref="AddUserGroupMembersResponse"/></returns>
        public Task<AddUserGroupMembersResponse> AddUserGroupMembers(AddUserGroupMembersRequest req)
        {
            return InternalRequestAsync<AddUserGroupMembersResponse>(req, "AddUserGroupMembers");
        }

        /// <summary>
        /// 添加用户组成员
        /// </summary>
        /// <param name="req"><see cref="AddUserGroupMembersRequest"/></param>
        /// <returns><see cref="AddUserGroupMembersResponse"/></returns>
        public AddUserGroupMembersResponse AddUserGroupMembersSync(AddUserGroupMembersRequest req)
        {
            return InternalRequestAsync<AddUserGroupMembersResponse>(req, "AddUserGroupMembers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 绑定主机账号密码
        /// </summary>
        /// <param name="req"><see cref="BindDeviceAccountPasswordRequest"/></param>
        /// <returns><see cref="BindDeviceAccountPasswordResponse"/></returns>
        public Task<BindDeviceAccountPasswordResponse> BindDeviceAccountPassword(BindDeviceAccountPasswordRequest req)
        {
            return InternalRequestAsync<BindDeviceAccountPasswordResponse>(req, "BindDeviceAccountPassword");
        }

        /// <summary>
        /// 绑定主机账号密码
        /// </summary>
        /// <param name="req"><see cref="BindDeviceAccountPasswordRequest"/></param>
        /// <returns><see cref="BindDeviceAccountPasswordResponse"/></returns>
        public BindDeviceAccountPasswordResponse BindDeviceAccountPasswordSync(BindDeviceAccountPasswordRequest req)
        {
            return InternalRequestAsync<BindDeviceAccountPasswordResponse>(req, "BindDeviceAccountPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 绑定主机账号私钥
        /// </summary>
        /// <param name="req"><see cref="BindDeviceAccountPrivateKeyRequest"/></param>
        /// <returns><see cref="BindDeviceAccountPrivateKeyResponse"/></returns>
        public Task<BindDeviceAccountPrivateKeyResponse> BindDeviceAccountPrivateKey(BindDeviceAccountPrivateKeyRequest req)
        {
            return InternalRequestAsync<BindDeviceAccountPrivateKeyResponse>(req, "BindDeviceAccountPrivateKey");
        }

        /// <summary>
        /// 绑定主机账号私钥
        /// </summary>
        /// <param name="req"><see cref="BindDeviceAccountPrivateKeyRequest"/></param>
        /// <returns><see cref="BindDeviceAccountPrivateKeyResponse"/></returns>
        public BindDeviceAccountPrivateKeyResponse BindDeviceAccountPrivateKeySync(BindDeviceAccountPrivateKeyRequest req)
        {
            return InternalRequestAsync<BindDeviceAccountPrivateKeyResponse>(req, "BindDeviceAccountPrivateKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改资产绑定的堡垒机服务
        /// </summary>
        /// <param name="req"><see cref="BindDeviceResourceRequest"/></param>
        /// <returns><see cref="BindDeviceResourceResponse"/></returns>
        public Task<BindDeviceResourceResponse> BindDeviceResource(BindDeviceResourceRequest req)
        {
            return InternalRequestAsync<BindDeviceResourceResponse>(req, "BindDeviceResource");
        }

        /// <summary>
        /// 修改资产绑定的堡垒机服务
        /// </summary>
        /// <param name="req"><see cref="BindDeviceResourceRequest"/></param>
        /// <returns><see cref="BindDeviceResourceResponse"/></returns>
        public BindDeviceResourceResponse BindDeviceResourceSync(BindDeviceResourceRequest req)
        {
            return InternalRequestAsync<BindDeviceResourceResponse>(req, "BindDeviceResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新建访问权限
        /// </summary>
        /// <param name="req"><see cref="CreateAclRequest"/></param>
        /// <returns><see cref="CreateAclResponse"/></returns>
        public Task<CreateAclResponse> CreateAcl(CreateAclRequest req)
        {
            return InternalRequestAsync<CreateAclResponse>(req, "CreateAcl");
        }

        /// <summary>
        /// 新建访问权限
        /// </summary>
        /// <param name="req"><see cref="CreateAclRequest"/></param>
        /// <returns><see cref="CreateAclResponse"/></returns>
        public CreateAclResponse CreateAclSync(CreateAclRequest req)
        {
            return InternalRequestAsync<CreateAclResponse>(req, "CreateAcl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建手工资产同步任务
        /// </summary>
        /// <param name="req"><see cref="CreateAssetSyncJobRequest"/></param>
        /// <returns><see cref="CreateAssetSyncJobResponse"/></returns>
        public Task<CreateAssetSyncJobResponse> CreateAssetSyncJob(CreateAssetSyncJobRequest req)
        {
            return InternalRequestAsync<CreateAssetSyncJobResponse>(req, "CreateAssetSyncJob");
        }

        /// <summary>
        /// 创建手工资产同步任务
        /// </summary>
        /// <param name="req"><see cref="CreateAssetSyncJobRequest"/></param>
        /// <returns><see cref="CreateAssetSyncJobResponse"/></returns>
        public CreateAssetSyncJobResponse CreateAssetSyncJobSync(CreateAssetSyncJobRequest req)
        {
            return InternalRequestAsync<CreateAssetSyncJobResponse>(req, "CreateAssetSyncJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新建高危命令模板
        /// </summary>
        /// <param name="req"><see cref="CreateCmdTemplateRequest"/></param>
        /// <returns><see cref="CreateCmdTemplateResponse"/></returns>
        public Task<CreateCmdTemplateResponse> CreateCmdTemplate(CreateCmdTemplateRequest req)
        {
            return InternalRequestAsync<CreateCmdTemplateResponse>(req, "CreateCmdTemplate");
        }

        /// <summary>
        /// 新建高危命令模板
        /// </summary>
        /// <param name="req"><see cref="CreateCmdTemplateRequest"/></param>
        /// <returns><see cref="CreateCmdTemplateResponse"/></returns>
        public CreateCmdTemplateResponse CreateCmdTemplateSync(CreateCmdTemplateRequest req)
        {
            return InternalRequestAsync<CreateCmdTemplateResponse>(req, "CreateCmdTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新建主机账号
        /// </summary>
        /// <param name="req"><see cref="CreateDeviceAccountRequest"/></param>
        /// <returns><see cref="CreateDeviceAccountResponse"/></returns>
        public Task<CreateDeviceAccountResponse> CreateDeviceAccount(CreateDeviceAccountRequest req)
        {
            return InternalRequestAsync<CreateDeviceAccountResponse>(req, "CreateDeviceAccount");
        }

        /// <summary>
        /// 新建主机账号
        /// </summary>
        /// <param name="req"><see cref="CreateDeviceAccountRequest"/></param>
        /// <returns><see cref="CreateDeviceAccountResponse"/></returns>
        public CreateDeviceAccountResponse CreateDeviceAccountSync(CreateDeviceAccountRequest req)
        {
            return InternalRequestAsync<CreateDeviceAccountResponse>(req, "CreateDeviceAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新建资产组
        /// </summary>
        /// <param name="req"><see cref="CreateDeviceGroupRequest"/></param>
        /// <returns><see cref="CreateDeviceGroupResponse"/></returns>
        public Task<CreateDeviceGroupResponse> CreateDeviceGroup(CreateDeviceGroupRequest req)
        {
            return InternalRequestAsync<CreateDeviceGroupResponse>(req, "CreateDeviceGroup");
        }

        /// <summary>
        /// 新建资产组
        /// </summary>
        /// <param name="req"><see cref="CreateDeviceGroupRequest"/></param>
        /// <returns><see cref="CreateDeviceGroupResponse"/></returns>
        public CreateDeviceGroupResponse CreateDeviceGroupSync(CreateDeviceGroupRequest req)
        {
            return InternalRequestAsync<CreateDeviceGroupResponse>(req, "CreateDeviceGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建堡垒机实例
        /// </summary>
        /// <param name="req"><see cref="CreateResourceRequest"/></param>
        /// <returns><see cref="CreateResourceResponse"/></returns>
        public Task<CreateResourceResponse> CreateResource(CreateResourceRequest req)
        {
            return InternalRequestAsync<CreateResourceResponse>(req, "CreateResource");
        }

        /// <summary>
        /// 创建堡垒机实例
        /// </summary>
        /// <param name="req"><see cref="CreateResourceRequest"/></param>
        /// <returns><see cref="CreateResourceResponse"/></returns>
        public CreateResourceResponse CreateResourceSync(CreateResourceRequest req)
        {
            return InternalRequestAsync<CreateResourceResponse>(req, "CreateResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新建用户
        /// </summary>
        /// <param name="req"><see cref="CreateUserRequest"/></param>
        /// <returns><see cref="CreateUserResponse"/></returns>
        public Task<CreateUserResponse> CreateUser(CreateUserRequest req)
        {
            return InternalRequestAsync<CreateUserResponse>(req, "CreateUser");
        }

        /// <summary>
        /// 新建用户
        /// </summary>
        /// <param name="req"><see cref="CreateUserRequest"/></param>
        /// <returns><see cref="CreateUserResponse"/></returns>
        public CreateUserResponse CreateUserSync(CreateUserRequest req)
        {
            return InternalRequestAsync<CreateUserResponse>(req, "CreateUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新建用户组
        /// </summary>
        /// <param name="req"><see cref="CreateUserGroupRequest"/></param>
        /// <returns><see cref="CreateUserGroupResponse"/></returns>
        public Task<CreateUserGroupResponse> CreateUserGroup(CreateUserGroupRequest req)
        {
            return InternalRequestAsync<CreateUserGroupResponse>(req, "CreateUserGroup");
        }

        /// <summary>
        /// 新建用户组
        /// </summary>
        /// <param name="req"><see cref="CreateUserGroupRequest"/></param>
        /// <returns><see cref="CreateUserGroupResponse"/></returns>
        public CreateUserGroupResponse CreateUserGroupSync(CreateUserGroupRequest req)
        {
            return InternalRequestAsync<CreateUserGroupResponse>(req, "CreateUserGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除访问权限
        /// </summary>
        /// <param name="req"><see cref="DeleteAclsRequest"/></param>
        /// <returns><see cref="DeleteAclsResponse"/></returns>
        public Task<DeleteAclsResponse> DeleteAcls(DeleteAclsRequest req)
        {
            return InternalRequestAsync<DeleteAclsResponse>(req, "DeleteAcls");
        }

        /// <summary>
        /// 删除访问权限
        /// </summary>
        /// <param name="req"><see cref="DeleteAclsRequest"/></param>
        /// <returns><see cref="DeleteAclsResponse"/></returns>
        public DeleteAclsResponse DeleteAclsSync(DeleteAclsRequest req)
        {
            return InternalRequestAsync<DeleteAclsResponse>(req, "DeleteAcls")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除高危命令模板
        /// </summary>
        /// <param name="req"><see cref="DeleteCmdTemplatesRequest"/></param>
        /// <returns><see cref="DeleteCmdTemplatesResponse"/></returns>
        public Task<DeleteCmdTemplatesResponse> DeleteCmdTemplates(DeleteCmdTemplatesRequest req)
        {
            return InternalRequestAsync<DeleteCmdTemplatesResponse>(req, "DeleteCmdTemplates");
        }

        /// <summary>
        /// 删除高危命令模板
        /// </summary>
        /// <param name="req"><see cref="DeleteCmdTemplatesRequest"/></param>
        /// <returns><see cref="DeleteCmdTemplatesResponse"/></returns>
        public DeleteCmdTemplatesResponse DeleteCmdTemplatesSync(DeleteCmdTemplatesRequest req)
        {
            return InternalRequestAsync<DeleteCmdTemplatesResponse>(req, "DeleteCmdTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除主机账号
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceAccountsRequest"/></param>
        /// <returns><see cref="DeleteDeviceAccountsResponse"/></returns>
        public Task<DeleteDeviceAccountsResponse> DeleteDeviceAccounts(DeleteDeviceAccountsRequest req)
        {
            return InternalRequestAsync<DeleteDeviceAccountsResponse>(req, "DeleteDeviceAccounts");
        }

        /// <summary>
        /// 删除主机账号
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceAccountsRequest"/></param>
        /// <returns><see cref="DeleteDeviceAccountsResponse"/></returns>
        public DeleteDeviceAccountsResponse DeleteDeviceAccountsSync(DeleteDeviceAccountsRequest req)
        {
            return InternalRequestAsync<DeleteDeviceAccountsResponse>(req, "DeleteDeviceAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除资产组成员
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceGroupMembersRequest"/></param>
        /// <returns><see cref="DeleteDeviceGroupMembersResponse"/></returns>
        public Task<DeleteDeviceGroupMembersResponse> DeleteDeviceGroupMembers(DeleteDeviceGroupMembersRequest req)
        {
            return InternalRequestAsync<DeleteDeviceGroupMembersResponse>(req, "DeleteDeviceGroupMembers");
        }

        /// <summary>
        /// 删除资产组成员
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceGroupMembersRequest"/></param>
        /// <returns><see cref="DeleteDeviceGroupMembersResponse"/></returns>
        public DeleteDeviceGroupMembersResponse DeleteDeviceGroupMembersSync(DeleteDeviceGroupMembersRequest req)
        {
            return InternalRequestAsync<DeleteDeviceGroupMembersResponse>(req, "DeleteDeviceGroupMembers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除资产组
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceGroupsRequest"/></param>
        /// <returns><see cref="DeleteDeviceGroupsResponse"/></returns>
        public Task<DeleteDeviceGroupsResponse> DeleteDeviceGroups(DeleteDeviceGroupsRequest req)
        {
            return InternalRequestAsync<DeleteDeviceGroupsResponse>(req, "DeleteDeviceGroups");
        }

        /// <summary>
        /// 删除资产组
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceGroupsRequest"/></param>
        /// <returns><see cref="DeleteDeviceGroupsResponse"/></returns>
        public DeleteDeviceGroupsResponse DeleteDeviceGroupsSync(DeleteDeviceGroupsRequest req)
        {
            return InternalRequestAsync<DeleteDeviceGroupsResponse>(req, "DeleteDeviceGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除主机
        /// </summary>
        /// <param name="req"><see cref="DeleteDevicesRequest"/></param>
        /// <returns><see cref="DeleteDevicesResponse"/></returns>
        public Task<DeleteDevicesResponse> DeleteDevices(DeleteDevicesRequest req)
        {
            return InternalRequestAsync<DeleteDevicesResponse>(req, "DeleteDevices");
        }

        /// <summary>
        /// 删除主机
        /// </summary>
        /// <param name="req"><see cref="DeleteDevicesRequest"/></param>
        /// <returns><see cref="DeleteDevicesResponse"/></returns>
        public DeleteDevicesResponse DeleteDevicesSync(DeleteDevicesRequest req)
        {
            return InternalRequestAsync<DeleteDevicesResponse>(req, "DeleteDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除用户组成员
        /// </summary>
        /// <param name="req"><see cref="DeleteUserGroupMembersRequest"/></param>
        /// <returns><see cref="DeleteUserGroupMembersResponse"/></returns>
        public Task<DeleteUserGroupMembersResponse> DeleteUserGroupMembers(DeleteUserGroupMembersRequest req)
        {
            return InternalRequestAsync<DeleteUserGroupMembersResponse>(req, "DeleteUserGroupMembers");
        }

        /// <summary>
        /// 删除用户组成员
        /// </summary>
        /// <param name="req"><see cref="DeleteUserGroupMembersRequest"/></param>
        /// <returns><see cref="DeleteUserGroupMembersResponse"/></returns>
        public DeleteUserGroupMembersResponse DeleteUserGroupMembersSync(DeleteUserGroupMembersRequest req)
        {
            return InternalRequestAsync<DeleteUserGroupMembersResponse>(req, "DeleteUserGroupMembers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除用户组
        /// </summary>
        /// <param name="req"><see cref="DeleteUserGroupsRequest"/></param>
        /// <returns><see cref="DeleteUserGroupsResponse"/></returns>
        public Task<DeleteUserGroupsResponse> DeleteUserGroups(DeleteUserGroupsRequest req)
        {
            return InternalRequestAsync<DeleteUserGroupsResponse>(req, "DeleteUserGroups");
        }

        /// <summary>
        /// 删除用户组
        /// </summary>
        /// <param name="req"><see cref="DeleteUserGroupsRequest"/></param>
        /// <returns><see cref="DeleteUserGroupsResponse"/></returns>
        public DeleteUserGroupsResponse DeleteUserGroupsSync(DeleteUserGroupsRequest req)
        {
            return InternalRequestAsync<DeleteUserGroupsResponse>(req, "DeleteUserGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="req"><see cref="DeleteUsersRequest"/></param>
        /// <returns><see cref="DeleteUsersResponse"/></returns>
        public Task<DeleteUsersResponse> DeleteUsers(DeleteUsersRequest req)
        {
            return InternalRequestAsync<DeleteUsersResponse>(req, "DeleteUsers");
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="req"><see cref="DeleteUsersRequest"/></param>
        /// <returns><see cref="DeleteUsersResponse"/></returns>
        public DeleteUsersResponse DeleteUsersSync(DeleteUsersRequest req)
        {
            return InternalRequestAsync<DeleteUsersResponse>(req, "DeleteUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开通服务，初始化资源，只针对新购资源
        /// </summary>
        /// <param name="req"><see cref="DeployResourceRequest"/></param>
        /// <returns><see cref="DeployResourceResponse"/></returns>
        public Task<DeployResourceResponse> DeployResource(DeployResourceRequest req)
        {
            return InternalRequestAsync<DeployResourceResponse>(req, "DeployResource");
        }

        /// <summary>
        /// 开通服务，初始化资源，只针对新购资源
        /// </summary>
        /// <param name="req"><see cref="DeployResourceRequest"/></param>
        /// <returns><see cref="DeployResourceResponse"/></returns>
        public DeployResourceResponse DeployResourceSync(DeployResourceRequest req)
        {
            return InternalRequestAsync<DeployResourceResponse>(req, "DeployResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询访问权限列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAclsRequest"/></param>
        /// <returns><see cref="DescribeAclsResponse"/></returns>
        public Task<DescribeAclsResponse> DescribeAcls(DescribeAclsRequest req)
        {
            return InternalRequestAsync<DescribeAclsResponse>(req, "DescribeAcls");
        }

        /// <summary>
        /// 查询访问权限列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAclsRequest"/></param>
        /// <returns><see cref="DescribeAclsResponse"/></returns>
        public DescribeAclsResponse DescribeAclsSync(DescribeAclsRequest req)
        {
            return InternalRequestAsync<DescribeAclsResponse>(req, "DescribeAcls")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询资产同步状态
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetSyncStatusRequest"/></param>
        /// <returns><see cref="DescribeAssetSyncStatusResponse"/></returns>
        public Task<DescribeAssetSyncStatusResponse> DescribeAssetSyncStatus(DescribeAssetSyncStatusRequest req)
        {
            return InternalRequestAsync<DescribeAssetSyncStatusResponse>(req, "DescribeAssetSyncStatus");
        }

        /// <summary>
        /// 查询资产同步状态
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetSyncStatusRequest"/></param>
        /// <returns><see cref="DescribeAssetSyncStatusResponse"/></returns>
        public DescribeAssetSyncStatusResponse DescribeAssetSyncStatusSync(DescribeAssetSyncStatusRequest req)
        {
            return InternalRequestAsync<DescribeAssetSyncStatusResponse>(req, "DescribeAssetSyncStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询命令模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCmdTemplatesRequest"/></param>
        /// <returns><see cref="DescribeCmdTemplatesResponse"/></returns>
        public Task<DescribeCmdTemplatesResponse> DescribeCmdTemplates(DescribeCmdTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeCmdTemplatesResponse>(req, "DescribeCmdTemplates");
        }

        /// <summary>
        /// 查询命令模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCmdTemplatesRequest"/></param>
        /// <returns><see cref="DescribeCmdTemplatesResponse"/></returns>
        public DescribeCmdTemplatesResponse DescribeCmdTemplatesSync(DescribeCmdTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeCmdTemplatesResponse>(req, "DescribeCmdTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取镜像列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDasbImageIdsRequest"/></param>
        /// <returns><see cref="DescribeDasbImageIdsResponse"/></returns>
        public Task<DescribeDasbImageIdsResponse> DescribeDasbImageIds(DescribeDasbImageIdsRequest req)
        {
            return InternalRequestAsync<DescribeDasbImageIdsResponse>(req, "DescribeDasbImageIds");
        }

        /// <summary>
        /// 获取镜像列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDasbImageIdsRequest"/></param>
        /// <returns><see cref="DescribeDasbImageIdsResponse"/></returns>
        public DescribeDasbImageIdsResponse DescribeDasbImageIdsSync(DescribeDasbImageIdsRequest req)
        {
            return InternalRequestAsync<DescribeDasbImageIdsResponse>(req, "DescribeDasbImageIds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询主机账号列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceAccountsRequest"/></param>
        /// <returns><see cref="DescribeDeviceAccountsResponse"/></returns>
        public Task<DescribeDeviceAccountsResponse> DescribeDeviceAccounts(DescribeDeviceAccountsRequest req)
        {
            return InternalRequestAsync<DescribeDeviceAccountsResponse>(req, "DescribeDeviceAccounts");
        }

        /// <summary>
        /// 查询主机账号列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceAccountsRequest"/></param>
        /// <returns><see cref="DescribeDeviceAccountsResponse"/></returns>
        public DescribeDeviceAccountsResponse DescribeDeviceAccountsSync(DescribeDeviceAccountsRequest req)
        {
            return InternalRequestAsync<DescribeDeviceAccountsResponse>(req, "DescribeDeviceAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询资产组成员列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceGroupMembersRequest"/></param>
        /// <returns><see cref="DescribeDeviceGroupMembersResponse"/></returns>
        public Task<DescribeDeviceGroupMembersResponse> DescribeDeviceGroupMembers(DescribeDeviceGroupMembersRequest req)
        {
            return InternalRequestAsync<DescribeDeviceGroupMembersResponse>(req, "DescribeDeviceGroupMembers");
        }

        /// <summary>
        /// 查询资产组成员列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceGroupMembersRequest"/></param>
        /// <returns><see cref="DescribeDeviceGroupMembersResponse"/></returns>
        public DescribeDeviceGroupMembersResponse DescribeDeviceGroupMembersSync(DescribeDeviceGroupMembersRequest req)
        {
            return InternalRequestAsync<DescribeDeviceGroupMembersResponse>(req, "DescribeDeviceGroupMembers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询资产组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceGroupsRequest"/></param>
        /// <returns><see cref="DescribeDeviceGroupsResponse"/></returns>
        public Task<DescribeDeviceGroupsResponse> DescribeDeviceGroups(DescribeDeviceGroupsRequest req)
        {
            return InternalRequestAsync<DescribeDeviceGroupsResponse>(req, "DescribeDeviceGroups");
        }

        /// <summary>
        /// 查询资产组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceGroupsRequest"/></param>
        /// <returns><see cref="DescribeDeviceGroupsResponse"/></returns>
        public DescribeDeviceGroupsResponse DescribeDeviceGroupsSync(DescribeDeviceGroupsRequest req)
        {
            return InternalRequestAsync<DescribeDeviceGroupsResponse>(req, "DescribeDeviceGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询资产列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicesRequest"/></param>
        /// <returns><see cref="DescribeDevicesResponse"/></returns>
        public Task<DescribeDevicesResponse> DescribeDevices(DescribeDevicesRequest req)
        {
            return InternalRequestAsync<DescribeDevicesResponse>(req, "DescribeDevices");
        }

        /// <summary>
        /// 查询资产列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicesRequest"/></param>
        /// <returns><see cref="DescribeDevicesResponse"/></returns>
        public DescribeDevicesResponse DescribeDevicesSync(DescribeDevicesRequest req)
        {
            return InternalRequestAsync<DescribeDevicesResponse>(req, "DescribeDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询登录日志
        /// </summary>
        /// <param name="req"><see cref="DescribeLoginEventRequest"/></param>
        /// <returns><see cref="DescribeLoginEventResponse"/></returns>
        public Task<DescribeLoginEventResponse> DescribeLoginEvent(DescribeLoginEventRequest req)
        {
            return InternalRequestAsync<DescribeLoginEventResponse>(req, "DescribeLoginEvent");
        }

        /// <summary>
        /// 查询登录日志
        /// </summary>
        /// <param name="req"><see cref="DescribeLoginEventRequest"/></param>
        /// <returns><see cref="DescribeLoginEventResponse"/></returns>
        public DescribeLoginEventResponse DescribeLoginEventSync(DescribeLoginEventRequest req)
        {
            return InternalRequestAsync<DescribeLoginEventResponse>(req, "DescribeLoginEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询操作日志
        /// </summary>
        /// <param name="req"><see cref="DescribeOperationEventRequest"/></param>
        /// <returns><see cref="DescribeOperationEventResponse"/></returns>
        public Task<DescribeOperationEventResponse> DescribeOperationEvent(DescribeOperationEventRequest req)
        {
            return InternalRequestAsync<DescribeOperationEventResponse>(req, "DescribeOperationEvent");
        }

        /// <summary>
        /// 查询操作日志
        /// </summary>
        /// <param name="req"><see cref="DescribeOperationEventRequest"/></param>
        /// <returns><see cref="DescribeOperationEventResponse"/></returns>
        public DescribeOperationEventResponse DescribeOperationEventSync(DescribeOperationEventRequest req)
        {
            return InternalRequestAsync<DescribeOperationEventResponse>(req, "DescribeOperationEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户购买的堡垒机服务信息，包括资源ID、授权点数、VPC、过期时间等。
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcesRequest"/></param>
        /// <returns><see cref="DescribeResourcesResponse"/></returns>
        public Task<DescribeResourcesResponse> DescribeResources(DescribeResourcesRequest req)
        {
            return InternalRequestAsync<DescribeResourcesResponse>(req, "DescribeResources");
        }

        /// <summary>
        /// 查询用户购买的堡垒机服务信息，包括资源ID、授权点数、VPC、过期时间等。
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcesRequest"/></param>
        /// <returns><see cref="DescribeResourcesResponse"/></returns>
        public DescribeResourcesResponse DescribeResourcesSync(DescribeResourcesRequest req)
        {
            return InternalRequestAsync<DescribeResourcesResponse>(req, "DescribeResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户组成员列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserGroupMembersRequest"/></param>
        /// <returns><see cref="DescribeUserGroupMembersResponse"/></returns>
        public Task<DescribeUserGroupMembersResponse> DescribeUserGroupMembers(DescribeUserGroupMembersRequest req)
        {
            return InternalRequestAsync<DescribeUserGroupMembersResponse>(req, "DescribeUserGroupMembers");
        }

        /// <summary>
        /// 查询用户组成员列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserGroupMembersRequest"/></param>
        /// <returns><see cref="DescribeUserGroupMembersResponse"/></returns>
        public DescribeUserGroupMembersResponse DescribeUserGroupMembersSync(DescribeUserGroupMembersRequest req)
        {
            return InternalRequestAsync<DescribeUserGroupMembersResponse>(req, "DescribeUserGroupMembers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserGroupsRequest"/></param>
        /// <returns><see cref="DescribeUserGroupsResponse"/></returns>
        public Task<DescribeUserGroupsResponse> DescribeUserGroups(DescribeUserGroupsRequest req)
        {
            return InternalRequestAsync<DescribeUserGroupsResponse>(req, "DescribeUserGroups");
        }

        /// <summary>
        /// 查询用户组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserGroupsRequest"/></param>
        /// <returns><see cref="DescribeUserGroupsResponse"/></returns>
        public DescribeUserGroupsResponse DescribeUserGroupsSync(DescribeUserGroupsRequest req)
        {
            return InternalRequestAsync<DescribeUserGroupsResponse>(req, "DescribeUserGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUsersRequest"/></param>
        /// <returns><see cref="DescribeUsersResponse"/></returns>
        public Task<DescribeUsersResponse> DescribeUsers(DescribeUsersRequest req)
        {
            return InternalRequestAsync<DescribeUsersResponse>(req, "DescribeUsers");
        }

        /// <summary>
        /// 查询用户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUsersRequest"/></param>
        /// <returns><see cref="DescribeUsersResponse"/></returns>
        public DescribeUsersResponse DescribeUsersSync(DescribeUsersRequest req)
        {
            return InternalRequestAsync<DescribeUsersResponse>(req, "DescribeUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 导入外部资产信息
        /// </summary>
        /// <param name="req"><see cref="ImportExternalDeviceRequest"/></param>
        /// <returns><see cref="ImportExternalDeviceResponse"/></returns>
        public Task<ImportExternalDeviceResponse> ImportExternalDevice(ImportExternalDeviceRequest req)
        {
            return InternalRequestAsync<ImportExternalDeviceResponse>(req, "ImportExternalDevice");
        }

        /// <summary>
        /// 导入外部资产信息
        /// </summary>
        /// <param name="req"><see cref="ImportExternalDeviceRequest"/></param>
        /// <returns><see cref="ImportExternalDeviceResponse"/></returns>
        public ImportExternalDeviceResponse ImportExternalDeviceSync(ImportExternalDeviceRequest req)
        {
            return InternalRequestAsync<ImportExternalDeviceResponse>(req, "ImportExternalDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改访问权限
        /// </summary>
        /// <param name="req"><see cref="ModifyAclRequest"/></param>
        /// <returns><see cref="ModifyAclResponse"/></returns>
        public Task<ModifyAclResponse> ModifyAcl(ModifyAclRequest req)
        {
            return InternalRequestAsync<ModifyAclResponse>(req, "ModifyAcl");
        }

        /// <summary>
        /// 修改访问权限
        /// </summary>
        /// <param name="req"><see cref="ModifyAclRequest"/></param>
        /// <returns><see cref="ModifyAclResponse"/></returns>
        public ModifyAclResponse ModifyAclSync(ModifyAclRequest req)
        {
            return InternalRequestAsync<ModifyAclResponse>(req, "ModifyAcl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改高危命令模板
        /// </summary>
        /// <param name="req"><see cref="ModifyCmdTemplateRequest"/></param>
        /// <returns><see cref="ModifyCmdTemplateResponse"/></returns>
        public Task<ModifyCmdTemplateResponse> ModifyCmdTemplate(ModifyCmdTemplateRequest req)
        {
            return InternalRequestAsync<ModifyCmdTemplateResponse>(req, "ModifyCmdTemplate");
        }

        /// <summary>
        /// 修改高危命令模板
        /// </summary>
        /// <param name="req"><see cref="ModifyCmdTemplateRequest"/></param>
        /// <returns><see cref="ModifyCmdTemplateResponse"/></returns>
        public ModifyCmdTemplateResponse ModifyCmdTemplateSync(ModifyCmdTemplateRequest req)
        {
            return InternalRequestAsync<ModifyCmdTemplateResponse>(req, "ModifyCmdTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改资产信息
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceRequest"/></param>
        /// <returns><see cref="ModifyDeviceResponse"/></returns>
        public Task<ModifyDeviceResponse> ModifyDevice(ModifyDeviceRequest req)
        {
            return InternalRequestAsync<ModifyDeviceResponse>(req, "ModifyDevice");
        }

        /// <summary>
        /// 修改资产信息
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceRequest"/></param>
        /// <returns><see cref="ModifyDeviceResponse"/></returns>
        public ModifyDeviceResponse ModifyDeviceSync(ModifyDeviceRequest req)
        {
            return InternalRequestAsync<ModifyDeviceResponse>(req, "ModifyDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改资产组
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceGroupRequest"/></param>
        /// <returns><see cref="ModifyDeviceGroupResponse"/></returns>
        public Task<ModifyDeviceGroupResponse> ModifyDeviceGroup(ModifyDeviceGroupRequest req)
        {
            return InternalRequestAsync<ModifyDeviceGroupResponse>(req, "ModifyDeviceGroup");
        }

        /// <summary>
        /// 修改资产组
        /// </summary>
        /// <param name="req"><see cref="ModifyDeviceGroupRequest"/></param>
        /// <returns><see cref="ModifyDeviceGroupResponse"/></returns>
        public ModifyDeviceGroupResponse ModifyDeviceGroupSync(ModifyDeviceGroupRequest req)
        {
            return InternalRequestAsync<ModifyDeviceGroupResponse>(req, "ModifyDeviceGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置OAuth认证参数
        /// </summary>
        /// <param name="req"><see cref="ModifyOAuthSettingRequest"/></param>
        /// <returns><see cref="ModifyOAuthSettingResponse"/></returns>
        public Task<ModifyOAuthSettingResponse> ModifyOAuthSetting(ModifyOAuthSettingRequest req)
        {
            return InternalRequestAsync<ModifyOAuthSettingResponse>(req, "ModifyOAuthSetting");
        }

        /// <summary>
        /// 设置OAuth认证参数
        /// </summary>
        /// <param name="req"><see cref="ModifyOAuthSettingRequest"/></param>
        /// <returns><see cref="ModifyOAuthSettingResponse"/></returns>
        public ModifyOAuthSettingResponse ModifyOAuthSettingSync(ModifyOAuthSettingRequest req)
        {
            return InternalRequestAsync<ModifyOAuthSettingResponse>(req, "ModifyOAuthSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 资源变配
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceRequest"/></param>
        /// <returns><see cref="ModifyResourceResponse"/></returns>
        public Task<ModifyResourceResponse> ModifyResource(ModifyResourceRequest req)
        {
            return InternalRequestAsync<ModifyResourceResponse>(req, "ModifyResource");
        }

        /// <summary>
        /// 资源变配
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceRequest"/></param>
        /// <returns><see cref="ModifyResourceResponse"/></returns>
        public ModifyResourceResponse ModifyResourceSync(ModifyResourceRequest req)
        {
            return InternalRequestAsync<ModifyResourceResponse>(req, "ModifyResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="req"><see cref="ModifyUserRequest"/></param>
        /// <returns><see cref="ModifyUserResponse"/></returns>
        public Task<ModifyUserResponse> ModifyUser(ModifyUserRequest req)
        {
            return InternalRequestAsync<ModifyUserResponse>(req, "ModifyUser");
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="req"><see cref="ModifyUserRequest"/></param>
        /// <returns><see cref="ModifyUserResponse"/></returns>
        public ModifyUserResponse ModifyUserSync(ModifyUserRequest req)
        {
            return InternalRequestAsync<ModifyUserResponse>(req, "ModifyUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改用户组
        /// </summary>
        /// <param name="req"><see cref="ModifyUserGroupRequest"/></param>
        /// <returns><see cref="ModifyUserGroupResponse"/></returns>
        public Task<ModifyUserGroupResponse> ModifyUserGroup(ModifyUserGroupRequest req)
        {
            return InternalRequestAsync<ModifyUserGroupResponse>(req, "ModifyUserGroup");
        }

        /// <summary>
        /// 修改用户组
        /// </summary>
        /// <param name="req"><see cref="ModifyUserGroupRequest"/></param>
        /// <returns><see cref="ModifyUserGroupResponse"/></returns>
        public ModifyUserGroupResponse ModifyUserGroupSync(ModifyUserGroupRequest req)
        {
            return InternalRequestAsync<ModifyUserGroupResponse>(req, "ModifyUserGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 清除设备账号绑定密码
        /// </summary>
        /// <param name="req"><see cref="ResetDeviceAccountPasswordRequest"/></param>
        /// <returns><see cref="ResetDeviceAccountPasswordResponse"/></returns>
        public Task<ResetDeviceAccountPasswordResponse> ResetDeviceAccountPassword(ResetDeviceAccountPasswordRequest req)
        {
            return InternalRequestAsync<ResetDeviceAccountPasswordResponse>(req, "ResetDeviceAccountPassword");
        }

        /// <summary>
        /// 清除设备账号绑定密码
        /// </summary>
        /// <param name="req"><see cref="ResetDeviceAccountPasswordRequest"/></param>
        /// <returns><see cref="ResetDeviceAccountPasswordResponse"/></returns>
        public ResetDeviceAccountPasswordResponse ResetDeviceAccountPasswordSync(ResetDeviceAccountPasswordRequest req)
        {
            return InternalRequestAsync<ResetDeviceAccountPasswordResponse>(req, "ResetDeviceAccountPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 清除设备账号绑定的密钥
        /// </summary>
        /// <param name="req"><see cref="ResetDeviceAccountPrivateKeyRequest"/></param>
        /// <returns><see cref="ResetDeviceAccountPrivateKeyResponse"/></returns>
        public Task<ResetDeviceAccountPrivateKeyResponse> ResetDeviceAccountPrivateKey(ResetDeviceAccountPrivateKeyRequest req)
        {
            return InternalRequestAsync<ResetDeviceAccountPrivateKeyResponse>(req, "ResetDeviceAccountPrivateKey");
        }

        /// <summary>
        /// 清除设备账号绑定的密钥
        /// </summary>
        /// <param name="req"><see cref="ResetDeviceAccountPrivateKeyRequest"/></param>
        /// <returns><see cref="ResetDeviceAccountPrivateKeyResponse"/></returns>
        public ResetDeviceAccountPrivateKeyResponse ResetDeviceAccountPrivateKeySync(ResetDeviceAccountPrivateKeyRequest req)
        {
            return InternalRequestAsync<ResetDeviceAccountPrivateKeyResponse>(req, "ResetDeviceAccountPrivateKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重置用户
        /// </summary>
        /// <param name="req"><see cref="ResetUserRequest"/></param>
        /// <returns><see cref="ResetUserResponse"/></returns>
        public Task<ResetUserResponse> ResetUser(ResetUserRequest req)
        {
            return InternalRequestAsync<ResetUserResponse>(req, "ResetUser");
        }

        /// <summary>
        /// 重置用户
        /// </summary>
        /// <param name="req"><see cref="ResetUserRequest"/></param>
        /// <returns><see cref="ResetUserResponse"/></returns>
        public ResetUserResponse ResetUserSync(ResetUserRequest req)
        {
            return InternalRequestAsync<ResetUserResponse>(req, "ResetUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 搜索审计日志
        /// </summary>
        /// <param name="req"><see cref="SearchAuditLogRequest"/></param>
        /// <returns><see cref="SearchAuditLogResponse"/></returns>
        public Task<SearchAuditLogResponse> SearchAuditLog(SearchAuditLogRequest req)
        {
            return InternalRequestAsync<SearchAuditLogResponse>(req, "SearchAuditLog");
        }

        /// <summary>
        /// 搜索审计日志
        /// </summary>
        /// <param name="req"><see cref="SearchAuditLogRequest"/></param>
        /// <returns><see cref="SearchAuditLogResponse"/></returns>
        public SearchAuditLogResponse SearchAuditLogSync(SearchAuditLogRequest req)
        {
            return InternalRequestAsync<SearchAuditLogResponse>(req, "SearchAuditLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 命令执行检索
        /// </summary>
        /// <param name="req"><see cref="SearchCommandRequest"/></param>
        /// <returns><see cref="SearchCommandResponse"/></returns>
        public Task<SearchCommandResponse> SearchCommand(SearchCommandRequest req)
        {
            return InternalRequestAsync<SearchCommandResponse>(req, "SearchCommand");
        }

        /// <summary>
        /// 命令执行检索
        /// </summary>
        /// <param name="req"><see cref="SearchCommandRequest"/></param>
        /// <returns><see cref="SearchCommandResponse"/></returns>
        public SearchCommandResponse SearchCommandSync(SearchCommandRequest req)
        {
            return InternalRequestAsync<SearchCommandResponse>(req, "SearchCommand")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据会话Id搜索Command
        /// </summary>
        /// <param name="req"><see cref="SearchCommandBySidRequest"/></param>
        /// <returns><see cref="SearchCommandBySidResponse"/></returns>
        public Task<SearchCommandBySidResponse> SearchCommandBySid(SearchCommandBySidRequest req)
        {
            return InternalRequestAsync<SearchCommandBySidResponse>(req, "SearchCommandBySid");
        }

        /// <summary>
        /// 根据会话Id搜索Command
        /// </summary>
        /// <param name="req"><see cref="SearchCommandBySidRequest"/></param>
        /// <returns><see cref="SearchCommandBySidResponse"/></returns>
        public SearchCommandBySidResponse SearchCommandBySidSync(SearchCommandBySidRequest req)
        {
            return InternalRequestAsync<SearchCommandBySidResponse>(req, "SearchCommandBySid")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 文件传输检索
        /// </summary>
        /// <param name="req"><see cref="SearchFileRequest"/></param>
        /// <returns><see cref="SearchFileResponse"/></returns>
        public Task<SearchFileResponse> SearchFile(SearchFileRequest req)
        {
            return InternalRequestAsync<SearchFileResponse>(req, "SearchFile");
        }

        /// <summary>
        /// 文件传输检索
        /// </summary>
        /// <param name="req"><see cref="SearchFileRequest"/></param>
        /// <returns><see cref="SearchFileResponse"/></returns>
        public SearchFileResponse SearchFileSync(SearchFileRequest req)
        {
            return InternalRequestAsync<SearchFileResponse>(req, "SearchFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 搜索文件传输会话下文件操作列表
        /// </summary>
        /// <param name="req"><see cref="SearchFileBySidRequest"/></param>
        /// <returns><see cref="SearchFileBySidResponse"/></returns>
        public Task<SearchFileBySidResponse> SearchFileBySid(SearchFileBySidRequest req)
        {
            return InternalRequestAsync<SearchFileBySidResponse>(req, "SearchFileBySid");
        }

        /// <summary>
        /// 搜索文件传输会话下文件操作列表
        /// </summary>
        /// <param name="req"><see cref="SearchFileBySidRequest"/></param>
        /// <returns><see cref="SearchFileBySidResponse"/></returns>
        public SearchFileBySidResponse SearchFileBySidSync(SearchFileBySidRequest req)
        {
            return InternalRequestAsync<SearchFileBySidResponse>(req, "SearchFileBySid")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 搜索会话
        /// </summary>
        /// <param name="req"><see cref="SearchSessionRequest"/></param>
        /// <returns><see cref="SearchSessionResponse"/></returns>
        public Task<SearchSessionResponse> SearchSession(SearchSessionRequest req)
        {
            return InternalRequestAsync<SearchSessionResponse>(req, "SearchSession");
        }

        /// <summary>
        /// 搜索会话
        /// </summary>
        /// <param name="req"><see cref="SearchSessionRequest"/></param>
        /// <returns><see cref="SearchSessionResponse"/></returns>
        public SearchSessionResponse SearchSessionSync(SearchSessionRequest req)
        {
            return InternalRequestAsync<SearchSessionResponse>(req, "SearchSession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 命令检索
        /// </summary>
        /// <param name="req"><see cref="SearchSessionCommandRequest"/></param>
        /// <returns><see cref="SearchSessionCommandResponse"/></returns>
        public Task<SearchSessionCommandResponse> SearchSessionCommand(SearchSessionCommandRequest req)
        {
            return InternalRequestAsync<SearchSessionCommandResponse>(req, "SearchSessionCommand");
        }

        /// <summary>
        /// 命令检索
        /// </summary>
        /// <param name="req"><see cref="SearchSessionCommandRequest"/></param>
        /// <returns><see cref="SearchSessionCommandResponse"/></returns>
        public SearchSessionCommandResponse SearchSessionCommandSync(SearchSessionCommandRequest req)
        {
            return InternalRequestAsync<SearchSessionCommandResponse>(req, "SearchSessionCommand")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}

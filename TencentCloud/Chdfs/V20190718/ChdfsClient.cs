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

namespace TencentCloud.Chdfs.V20190718
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Chdfs.V20190718.Models;

   public class ChdfsClient : AbstractClient{

       private const string endpoint = "chdfs.tencentcloudapi.com";
       private const string version = "2019-07-18";
       private const string sdkVersion = "SDK_NET_3.0.1236";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public ChdfsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public ChdfsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 创建权限组。
        /// </summary>
        /// <param name="req"><see cref="CreateAccessGroupRequest"/></param>
        /// <returns><see cref="CreateAccessGroupResponse"/></returns>
        public Task<CreateAccessGroupResponse> CreateAccessGroup(CreateAccessGroupRequest req)
        {
            return InternalRequestAsync<CreateAccessGroupResponse>(req, "CreateAccessGroup");
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 创建权限组。
        /// </summary>
        /// <param name="req"><see cref="CreateAccessGroupRequest"/></param>
        /// <returns><see cref="CreateAccessGroupResponse"/></returns>
        public CreateAccessGroupResponse CreateAccessGroupSync(CreateAccessGroupRequest req)
        {
            return InternalRequestAsync<CreateAccessGroupResponse>(req, "CreateAccessGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 批量创建权限规则，权限规则ID和创建时间无需填写。
        /// </summary>
        /// <param name="req"><see cref="CreateAccessRulesRequest"/></param>
        /// <returns><see cref="CreateAccessRulesResponse"/></returns>
        public Task<CreateAccessRulesResponse> CreateAccessRules(CreateAccessRulesRequest req)
        {
            return InternalRequestAsync<CreateAccessRulesResponse>(req, "CreateAccessRules");
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 批量创建权限规则，权限规则ID和创建时间无需填写。
        /// </summary>
        /// <param name="req"><see cref="CreateAccessRulesRequest"/></param>
        /// <returns><see cref="CreateAccessRulesResponse"/></returns>
        public CreateAccessRulesResponse CreateAccessRulesSync(CreateAccessRulesRequest req)
        {
            return InternalRequestAsync<CreateAccessRulesResponse>(req, "CreateAccessRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 创建文件系统（异步）。
        /// </summary>
        /// <param name="req"><see cref="CreateFileSystemRequest"/></param>
        /// <returns><see cref="CreateFileSystemResponse"/></returns>
        public Task<CreateFileSystemResponse> CreateFileSystem(CreateFileSystemRequest req)
        {
            return InternalRequestAsync<CreateFileSystemResponse>(req, "CreateFileSystem");
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 创建文件系统（异步）。
        /// </summary>
        /// <param name="req"><see cref="CreateFileSystemRequest"/></param>
        /// <returns><see cref="CreateFileSystemResponse"/></returns>
        public CreateFileSystemResponse CreateFileSystemSync(CreateFileSystemRequest req)
        {
            return InternalRequestAsync<CreateFileSystemResponse>(req, "CreateFileSystem")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 批量创建生命周期规则，生命周期规则ID和创建时间无需填写。
        /// </summary>
        /// <param name="req"><see cref="CreateLifeCycleRulesRequest"/></param>
        /// <returns><see cref="CreateLifeCycleRulesResponse"/></returns>
        public Task<CreateLifeCycleRulesResponse> CreateLifeCycleRules(CreateLifeCycleRulesRequest req)
        {
            return InternalRequestAsync<CreateLifeCycleRulesResponse>(req, "CreateLifeCycleRules");
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 批量创建生命周期规则，生命周期规则ID和创建时间无需填写。
        /// </summary>
        /// <param name="req"><see cref="CreateLifeCycleRulesRequest"/></param>
        /// <returns><see cref="CreateLifeCycleRulesResponse"/></returns>
        public CreateLifeCycleRulesResponse CreateLifeCycleRulesSync(CreateLifeCycleRulesRequest req)
        {
            return InternalRequestAsync<CreateLifeCycleRulesResponse>(req, "CreateLifeCycleRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 创建文件系统挂载点，仅限于创建成功的文件系统。
        /// </summary>
        /// <param name="req"><see cref="CreateMountPointRequest"/></param>
        /// <returns><see cref="CreateMountPointResponse"/></returns>
        public Task<CreateMountPointResponse> CreateMountPoint(CreateMountPointRequest req)
        {
            return InternalRequestAsync<CreateMountPointResponse>(req, "CreateMountPoint");
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 创建文件系统挂载点，仅限于创建成功的文件系统。
        /// </summary>
        /// <param name="req"><see cref="CreateMountPointRequest"/></param>
        /// <returns><see cref="CreateMountPointResponse"/></returns>
        public CreateMountPointResponse CreateMountPointSync(CreateMountPointRequest req)
        {
            return InternalRequestAsync<CreateMountPointResponse>(req, "CreateMountPoint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 批量创建回热任务，回热任务ID、状态和创建时间无需填写。
        /// </summary>
        /// <param name="req"><see cref="CreateRestoreTasksRequest"/></param>
        /// <returns><see cref="CreateRestoreTasksResponse"/></returns>
        public Task<CreateRestoreTasksResponse> CreateRestoreTasks(CreateRestoreTasksRequest req)
        {
            return InternalRequestAsync<CreateRestoreTasksResponse>(req, "CreateRestoreTasks");
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 批量创建回热任务，回热任务ID、状态和创建时间无需填写。
        /// </summary>
        /// <param name="req"><see cref="CreateRestoreTasksRequest"/></param>
        /// <returns><see cref="CreateRestoreTasksResponse"/></returns>
        public CreateRestoreTasksResponse CreateRestoreTasksSync(CreateRestoreTasksRequest req)
        {
            return InternalRequestAsync<CreateRestoreTasksResponse>(req, "CreateRestoreTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 删除权限组。
        /// </summary>
        /// <param name="req"><see cref="DeleteAccessGroupRequest"/></param>
        /// <returns><see cref="DeleteAccessGroupResponse"/></returns>
        public Task<DeleteAccessGroupResponse> DeleteAccessGroup(DeleteAccessGroupRequest req)
        {
            return InternalRequestAsync<DeleteAccessGroupResponse>(req, "DeleteAccessGroup");
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 删除权限组。
        /// </summary>
        /// <param name="req"><see cref="DeleteAccessGroupRequest"/></param>
        /// <returns><see cref="DeleteAccessGroupResponse"/></returns>
        public DeleteAccessGroupResponse DeleteAccessGroupSync(DeleteAccessGroupRequest req)
        {
            return InternalRequestAsync<DeleteAccessGroupResponse>(req, "DeleteAccessGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 批量删除权限规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteAccessRulesRequest"/></param>
        /// <returns><see cref="DeleteAccessRulesResponse"/></returns>
        public Task<DeleteAccessRulesResponse> DeleteAccessRules(DeleteAccessRulesRequest req)
        {
            return InternalRequestAsync<DeleteAccessRulesResponse>(req, "DeleteAccessRules");
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 批量删除权限规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteAccessRulesRequest"/></param>
        /// <returns><see cref="DeleteAccessRulesResponse"/></returns>
        public DeleteAccessRulesResponse DeleteAccessRulesSync(DeleteAccessRulesRequest req)
        {
            return InternalRequestAsync<DeleteAccessRulesResponse>(req, "DeleteAccessRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 删除文件系统，不允许删除非空文件系统。
        /// </summary>
        /// <param name="req"><see cref="DeleteFileSystemRequest"/></param>
        /// <returns><see cref="DeleteFileSystemResponse"/></returns>
        public Task<DeleteFileSystemResponse> DeleteFileSystem(DeleteFileSystemRequest req)
        {
            return InternalRequestAsync<DeleteFileSystemResponse>(req, "DeleteFileSystem");
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 删除文件系统，不允许删除非空文件系统。
        /// </summary>
        /// <param name="req"><see cref="DeleteFileSystemRequest"/></param>
        /// <returns><see cref="DeleteFileSystemResponse"/></returns>
        public DeleteFileSystemResponse DeleteFileSystemSync(DeleteFileSystemRequest req)
        {
            return InternalRequestAsync<DeleteFileSystemResponse>(req, "DeleteFileSystem")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 批量删除生命周期规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteLifeCycleRulesRequest"/></param>
        /// <returns><see cref="DeleteLifeCycleRulesResponse"/></returns>
        public Task<DeleteLifeCycleRulesResponse> DeleteLifeCycleRules(DeleteLifeCycleRulesRequest req)
        {
            return InternalRequestAsync<DeleteLifeCycleRulesResponse>(req, "DeleteLifeCycleRules");
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 批量删除生命周期规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteLifeCycleRulesRequest"/></param>
        /// <returns><see cref="DeleteLifeCycleRulesResponse"/></returns>
        public DeleteLifeCycleRulesResponse DeleteLifeCycleRulesSync(DeleteLifeCycleRulesRequest req)
        {
            return InternalRequestAsync<DeleteLifeCycleRulesResponse>(req, "DeleteLifeCycleRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 删除挂载点。
        /// </summary>
        /// <param name="req"><see cref="DeleteMountPointRequest"/></param>
        /// <returns><see cref="DeleteMountPointResponse"/></returns>
        public Task<DeleteMountPointResponse> DeleteMountPoint(DeleteMountPointRequest req)
        {
            return InternalRequestAsync<DeleteMountPointResponse>(req, "DeleteMountPoint");
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 删除挂载点。
        /// </summary>
        /// <param name="req"><see cref="DeleteMountPointRequest"/></param>
        /// <returns><see cref="DeleteMountPointResponse"/></returns>
        public DeleteMountPointResponse DeleteMountPointSync(DeleteMountPointRequest req)
        {
            return InternalRequestAsync<DeleteMountPointResponse>(req, "DeleteMountPoint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 查看权限组列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessGroupsRequest"/></param>
        /// <returns><see cref="DescribeAccessGroupsResponse"/></returns>
        public Task<DescribeAccessGroupsResponse> DescribeAccessGroups(DescribeAccessGroupsRequest req)
        {
            return InternalRequestAsync<DescribeAccessGroupsResponse>(req, "DescribeAccessGroups");
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 查看权限组列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessGroupsRequest"/></param>
        /// <returns><see cref="DescribeAccessGroupsResponse"/></returns>
        public DescribeAccessGroupsResponse DescribeAccessGroupsSync(DescribeAccessGroupsRequest req)
        {
            return InternalRequestAsync<DescribeAccessGroupsResponse>(req, "DescribeAccessGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 通过权限组ID查看权限规则列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessRulesRequest"/></param>
        /// <returns><see cref="DescribeAccessRulesResponse"/></returns>
        public Task<DescribeAccessRulesResponse> DescribeAccessRules(DescribeAccessRulesRequest req)
        {
            return InternalRequestAsync<DescribeAccessRulesResponse>(req, "DescribeAccessRules");
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 通过权限组ID查看权限规则列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessRulesRequest"/></param>
        /// <returns><see cref="DescribeAccessRulesResponse"/></returns>
        public DescribeAccessRulesResponse DescribeAccessRulesSync(DescribeAccessRulesRequest req)
        {
            return InternalRequestAsync<DescribeAccessRulesResponse>(req, "DescribeAccessRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 查看文件系统详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeFileSystemRequest"/></param>
        /// <returns><see cref="DescribeFileSystemResponse"/></returns>
        public Task<DescribeFileSystemResponse> DescribeFileSystem(DescribeFileSystemRequest req)
        {
            return InternalRequestAsync<DescribeFileSystemResponse>(req, "DescribeFileSystem");
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 查看文件系统详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeFileSystemRequest"/></param>
        /// <returns><see cref="DescribeFileSystemResponse"/></returns>
        public DescribeFileSystemResponse DescribeFileSystemSync(DescribeFileSystemRequest req)
        {
            return InternalRequestAsync<DescribeFileSystemResponse>(req, "DescribeFileSystem")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 查看文件系统列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeFileSystemsRequest"/></param>
        /// <returns><see cref="DescribeFileSystemsResponse"/></returns>
        public Task<DescribeFileSystemsResponse> DescribeFileSystems(DescribeFileSystemsRequest req)
        {
            return InternalRequestAsync<DescribeFileSystemsResponse>(req, "DescribeFileSystems");
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 查看文件系统列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeFileSystemsRequest"/></param>
        /// <returns><see cref="DescribeFileSystemsResponse"/></returns>
        public DescribeFileSystemsResponse DescribeFileSystemsSync(DescribeFileSystemsRequest req)
        {
            return InternalRequestAsync<DescribeFileSystemsResponse>(req, "DescribeFileSystems")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 通过文件系统ID查看生命周期规则列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeLifeCycleRulesRequest"/></param>
        /// <returns><see cref="DescribeLifeCycleRulesResponse"/></returns>
        public Task<DescribeLifeCycleRulesResponse> DescribeLifeCycleRules(DescribeLifeCycleRulesRequest req)
        {
            return InternalRequestAsync<DescribeLifeCycleRulesResponse>(req, "DescribeLifeCycleRules");
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 通过文件系统ID查看生命周期规则列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeLifeCycleRulesRequest"/></param>
        /// <returns><see cref="DescribeLifeCycleRulesResponse"/></returns>
        public DescribeLifeCycleRulesResponse DescribeLifeCycleRulesSync(DescribeLifeCycleRulesRequest req)
        {
            return InternalRequestAsync<DescribeLifeCycleRulesResponse>(req, "DescribeLifeCycleRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 查看挂载点详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeMountPointRequest"/></param>
        /// <returns><see cref="DescribeMountPointResponse"/></returns>
        public Task<DescribeMountPointResponse> DescribeMountPoint(DescribeMountPointRequest req)
        {
            return InternalRequestAsync<DescribeMountPointResponse>(req, "DescribeMountPoint");
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 查看挂载点详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeMountPointRequest"/></param>
        /// <returns><see cref="DescribeMountPointResponse"/></returns>
        public DescribeMountPointResponse DescribeMountPointSync(DescribeMountPointRequest req)
        {
            return InternalRequestAsync<DescribeMountPointResponse>(req, "DescribeMountPoint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 通过文件系统ID或者权限组ID查看挂载点列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeMountPointsRequest"/></param>
        /// <returns><see cref="DescribeMountPointsResponse"/></returns>
        public Task<DescribeMountPointsResponse> DescribeMountPoints(DescribeMountPointsRequest req)
        {
            return InternalRequestAsync<DescribeMountPointsResponse>(req, "DescribeMountPoints");
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 通过文件系统ID或者权限组ID查看挂载点列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeMountPointsRequest"/></param>
        /// <returns><see cref="DescribeMountPointsResponse"/></returns>
        public DescribeMountPointsResponse DescribeMountPointsSync(DescribeMountPointsRequest req)
        {
            return InternalRequestAsync<DescribeMountPointsResponse>(req, "DescribeMountPoints")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 通过文件系统ID查看资源标签列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceTagsRequest"/></param>
        /// <returns><see cref="DescribeResourceTagsResponse"/></returns>
        public Task<DescribeResourceTagsResponse> DescribeResourceTags(DescribeResourceTagsRequest req)
        {
            return InternalRequestAsync<DescribeResourceTagsResponse>(req, "DescribeResourceTags");
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 通过文件系统ID查看资源标签列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceTagsRequest"/></param>
        /// <returns><see cref="DescribeResourceTagsResponse"/></returns>
        public DescribeResourceTagsResponse DescribeResourceTagsSync(DescribeResourceTagsRequest req)
        {
            return InternalRequestAsync<DescribeResourceTagsResponse>(req, "DescribeResourceTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 通过文件系统ID查看回热任务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeRestoreTasksRequest"/></param>
        /// <returns><see cref="DescribeRestoreTasksResponse"/></returns>
        public Task<DescribeRestoreTasksResponse> DescribeRestoreTasks(DescribeRestoreTasksRequest req)
        {
            return InternalRequestAsync<DescribeRestoreTasksResponse>(req, "DescribeRestoreTasks");
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 通过文件系统ID查看回热任务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeRestoreTasksRequest"/></param>
        /// <returns><see cref="DescribeRestoreTasksResponse"/></returns>
        public DescribeRestoreTasksResponse DescribeRestoreTasksSync(DescribeRestoreTasksRequest req)
        {
            return InternalRequestAsync<DescribeRestoreTasksResponse>(req, "DescribeRestoreTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 修改权限组属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyAccessGroupRequest"/></param>
        /// <returns><see cref="ModifyAccessGroupResponse"/></returns>
        public Task<ModifyAccessGroupResponse> ModifyAccessGroup(ModifyAccessGroupRequest req)
        {
            return InternalRequestAsync<ModifyAccessGroupResponse>(req, "ModifyAccessGroup");
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 修改权限组属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyAccessGroupRequest"/></param>
        /// <returns><see cref="ModifyAccessGroupResponse"/></returns>
        public ModifyAccessGroupResponse ModifyAccessGroupSync(ModifyAccessGroupRequest req)
        {
            return InternalRequestAsync<ModifyAccessGroupResponse>(req, "ModifyAccessGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 批量修改权限规则属性，需要指定权限规则ID，支持修改权限规则地址、访问模式和优先级。
        /// </summary>
        /// <param name="req"><see cref="ModifyAccessRulesRequest"/></param>
        /// <returns><see cref="ModifyAccessRulesResponse"/></returns>
        public Task<ModifyAccessRulesResponse> ModifyAccessRules(ModifyAccessRulesRequest req)
        {
            return InternalRequestAsync<ModifyAccessRulesResponse>(req, "ModifyAccessRules");
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 批量修改权限规则属性，需要指定权限规则ID，支持修改权限规则地址、访问模式和优先级。
        /// </summary>
        /// <param name="req"><see cref="ModifyAccessRulesRequest"/></param>
        /// <returns><see cref="ModifyAccessRulesResponse"/></returns>
        public ModifyAccessRulesResponse ModifyAccessRulesSync(ModifyAccessRulesRequest req)
        {
            return InternalRequestAsync<ModifyAccessRulesResponse>(req, "ModifyAccessRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 修改文件系统属性，仅限于创建成功的文件系统。
        /// </summary>
        /// <param name="req"><see cref="ModifyFileSystemRequest"/></param>
        /// <returns><see cref="ModifyFileSystemResponse"/></returns>
        public Task<ModifyFileSystemResponse> ModifyFileSystem(ModifyFileSystemRequest req)
        {
            return InternalRequestAsync<ModifyFileSystemResponse>(req, "ModifyFileSystem");
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 修改文件系统属性，仅限于创建成功的文件系统。
        /// </summary>
        /// <param name="req"><see cref="ModifyFileSystemRequest"/></param>
        /// <returns><see cref="ModifyFileSystemResponse"/></returns>
        public ModifyFileSystemResponse ModifyFileSystemSync(ModifyFileSystemRequest req)
        {
            return InternalRequestAsync<ModifyFileSystemResponse>(req, "ModifyFileSystem")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 批量修改生命周期规则属性，需要指定生命周期规则ID，支持修改生命周期规则名称、路径、转换列表和状态。
        /// </summary>
        /// <param name="req"><see cref="ModifyLifeCycleRulesRequest"/></param>
        /// <returns><see cref="ModifyLifeCycleRulesResponse"/></returns>
        public Task<ModifyLifeCycleRulesResponse> ModifyLifeCycleRules(ModifyLifeCycleRulesRequest req)
        {
            return InternalRequestAsync<ModifyLifeCycleRulesResponse>(req, "ModifyLifeCycleRules");
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 批量修改生命周期规则属性，需要指定生命周期规则ID，支持修改生命周期规则名称、路径、转换列表和状态。
        /// </summary>
        /// <param name="req"><see cref="ModifyLifeCycleRulesRequest"/></param>
        /// <returns><see cref="ModifyLifeCycleRulesResponse"/></returns>
        public ModifyLifeCycleRulesResponse ModifyLifeCycleRulesSync(ModifyLifeCycleRulesRequest req)
        {
            return InternalRequestAsync<ModifyLifeCycleRulesResponse>(req, "ModifyLifeCycleRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 修改挂载点属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyMountPointRequest"/></param>
        /// <returns><see cref="ModifyMountPointResponse"/></returns>
        public Task<ModifyMountPointResponse> ModifyMountPoint(ModifyMountPointRequest req)
        {
            return InternalRequestAsync<ModifyMountPointResponse>(req, "ModifyMountPoint");
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 修改挂载点属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyMountPointRequest"/></param>
        /// <returns><see cref="ModifyMountPointResponse"/></returns>
        public ModifyMountPointResponse ModifyMountPointSync(ModifyMountPointRequest req)
        {
            return InternalRequestAsync<ModifyMountPointResponse>(req, "ModifyMountPoint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 修改资源标签列表，全量覆盖。
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceTagsRequest"/></param>
        /// <returns><see cref="ModifyResourceTagsResponse"/></returns>
        public Task<ModifyResourceTagsResponse> ModifyResourceTags(ModifyResourceTagsRequest req)
        {
            return InternalRequestAsync<ModifyResourceTagsResponse>(req, "ModifyResourceTags");
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 修改资源标签列表，全量覆盖。
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceTagsRequest"/></param>
        /// <returns><see cref="ModifyResourceTagsResponse"/></returns>
        public ModifyResourceTagsResponse ModifyResourceTagsSync(ModifyResourceTagsRequest req)
        {
            return InternalRequestAsync<ModifyResourceTagsResponse>(req, "ModifyResourceTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}

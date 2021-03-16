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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public ChdfsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 创建权限组。
        /// </summary>
        /// <param name="req"><see cref="CreateAccessGroupRequest"/></param>
        /// <returns><see cref="CreateAccessGroupResponse"/></returns>
        public async Task<CreateAccessGroupResponse> CreateAccessGroup(CreateAccessGroupRequest req)
        {
             JsonResponseModel<CreateAccessGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAccessGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAccessGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<CreateAccessGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAccessGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAccessGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 批量创建权限规则，权限规则ID和创建时间无需填写。
        /// </summary>
        /// <param name="req"><see cref="CreateAccessRulesRequest"/></param>
        /// <returns><see cref="CreateAccessRulesResponse"/></returns>
        public async Task<CreateAccessRulesResponse> CreateAccessRules(CreateAccessRulesRequest req)
        {
             JsonResponseModel<CreateAccessRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAccessRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAccessRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<CreateAccessRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAccessRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAccessRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 创建文件系统（异步）。
        /// </summary>
        /// <param name="req"><see cref="CreateFileSystemRequest"/></param>
        /// <returns><see cref="CreateFileSystemResponse"/></returns>
        public async Task<CreateFileSystemResponse> CreateFileSystem(CreateFileSystemRequest req)
        {
             JsonResponseModel<CreateFileSystemResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateFileSystem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFileSystemResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<CreateFileSystemResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateFileSystem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFileSystemResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 批量创建生命周期规则，生命周期规则ID和创建时间无需填写。
        /// </summary>
        /// <param name="req"><see cref="CreateLifeCycleRulesRequest"/></param>
        /// <returns><see cref="CreateLifeCycleRulesResponse"/></returns>
        public async Task<CreateLifeCycleRulesResponse> CreateLifeCycleRules(CreateLifeCycleRulesRequest req)
        {
             JsonResponseModel<CreateLifeCycleRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLifeCycleRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLifeCycleRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<CreateLifeCycleRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLifeCycleRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLifeCycleRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 创建文件系统挂载点，仅限于创建成功的文件系统。
        /// </summary>
        /// <param name="req"><see cref="CreateMountPointRequest"/></param>
        /// <returns><see cref="CreateMountPointResponse"/></returns>
        public async Task<CreateMountPointResponse> CreateMountPoint(CreateMountPointRequest req)
        {
             JsonResponseModel<CreateMountPointResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateMountPoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMountPointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<CreateMountPointResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateMountPoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMountPointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 批量创建回热任务，回热任务ID、状态和创建时间无需填写。
        /// </summary>
        /// <param name="req"><see cref="CreateRestoreTasksRequest"/></param>
        /// <returns><see cref="CreateRestoreTasksResponse"/></returns>
        public async Task<CreateRestoreTasksResponse> CreateRestoreTasks(CreateRestoreTasksRequest req)
        {
             JsonResponseModel<CreateRestoreTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRestoreTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRestoreTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<CreateRestoreTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRestoreTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRestoreTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 删除权限组。
        /// </summary>
        /// <param name="req"><see cref="DeleteAccessGroupRequest"/></param>
        /// <returns><see cref="DeleteAccessGroupResponse"/></returns>
        public async Task<DeleteAccessGroupResponse> DeleteAccessGroup(DeleteAccessGroupRequest req)
        {
             JsonResponseModel<DeleteAccessGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAccessGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAccessGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DeleteAccessGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAccessGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAccessGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 批量删除权限规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteAccessRulesRequest"/></param>
        /// <returns><see cref="DeleteAccessRulesResponse"/></returns>
        public async Task<DeleteAccessRulesResponse> DeleteAccessRules(DeleteAccessRulesRequest req)
        {
             JsonResponseModel<DeleteAccessRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAccessRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAccessRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DeleteAccessRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAccessRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAccessRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 删除文件系统，不允许删除非空文件系统。
        /// </summary>
        /// <param name="req"><see cref="DeleteFileSystemRequest"/></param>
        /// <returns><see cref="DeleteFileSystemResponse"/></returns>
        public async Task<DeleteFileSystemResponse> DeleteFileSystem(DeleteFileSystemRequest req)
        {
             JsonResponseModel<DeleteFileSystemResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteFileSystem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteFileSystemResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DeleteFileSystemResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteFileSystem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteFileSystemResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 批量删除生命周期规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteLifeCycleRulesRequest"/></param>
        /// <returns><see cref="DeleteLifeCycleRulesResponse"/></returns>
        public async Task<DeleteLifeCycleRulesResponse> DeleteLifeCycleRules(DeleteLifeCycleRulesRequest req)
        {
             JsonResponseModel<DeleteLifeCycleRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLifeCycleRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLifeCycleRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DeleteLifeCycleRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLifeCycleRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLifeCycleRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 删除挂载点。
        /// </summary>
        /// <param name="req"><see cref="DeleteMountPointRequest"/></param>
        /// <returns><see cref="DeleteMountPointResponse"/></returns>
        public async Task<DeleteMountPointResponse> DeleteMountPoint(DeleteMountPointRequest req)
        {
             JsonResponseModel<DeleteMountPointResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMountPoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMountPointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DeleteMountPointResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteMountPoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMountPointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 查看权限组列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessGroupsRequest"/></param>
        /// <returns><see cref="DescribeAccessGroupsResponse"/></returns>
        public async Task<DescribeAccessGroupsResponse> DescribeAccessGroups(DescribeAccessGroupsRequest req)
        {
             JsonResponseModel<DescribeAccessGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccessGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccessGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DescribeAccessGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAccessGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccessGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 通过权限组ID查看权限规则列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessRulesRequest"/></param>
        /// <returns><see cref="DescribeAccessRulesResponse"/></returns>
        public async Task<DescribeAccessRulesResponse> DescribeAccessRules(DescribeAccessRulesRequest req)
        {
             JsonResponseModel<DescribeAccessRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccessRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccessRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DescribeAccessRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAccessRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccessRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 查看文件系统详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeFileSystemRequest"/></param>
        /// <returns><see cref="DescribeFileSystemResponse"/></returns>
        public async Task<DescribeFileSystemResponse> DescribeFileSystem(DescribeFileSystemRequest req)
        {
             JsonResponseModel<DescribeFileSystemResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFileSystem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFileSystemResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DescribeFileSystemResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFileSystem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFileSystemResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 查看文件系统列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeFileSystemsRequest"/></param>
        /// <returns><see cref="DescribeFileSystemsResponse"/></returns>
        public async Task<DescribeFileSystemsResponse> DescribeFileSystems(DescribeFileSystemsRequest req)
        {
             JsonResponseModel<DescribeFileSystemsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFileSystems");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFileSystemsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DescribeFileSystemsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFileSystems");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFileSystemsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 通过文件系统ID查看生命周期规则列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeLifeCycleRulesRequest"/></param>
        /// <returns><see cref="DescribeLifeCycleRulesResponse"/></returns>
        public async Task<DescribeLifeCycleRulesResponse> DescribeLifeCycleRules(DescribeLifeCycleRulesRequest req)
        {
             JsonResponseModel<DescribeLifeCycleRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLifeCycleRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLifeCycleRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DescribeLifeCycleRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLifeCycleRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLifeCycleRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 查看挂载点详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeMountPointRequest"/></param>
        /// <returns><see cref="DescribeMountPointResponse"/></returns>
        public async Task<DescribeMountPointResponse> DescribeMountPoint(DescribeMountPointRequest req)
        {
             JsonResponseModel<DescribeMountPointResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMountPoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMountPointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DescribeMountPointResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMountPoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMountPointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 通过文件系统ID或者权限组ID查看挂载点列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeMountPointsRequest"/></param>
        /// <returns><see cref="DescribeMountPointsResponse"/></returns>
        public async Task<DescribeMountPointsResponse> DescribeMountPoints(DescribeMountPointsRequest req)
        {
             JsonResponseModel<DescribeMountPointsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMountPoints");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMountPointsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DescribeMountPointsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMountPoints");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMountPointsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 通过文件系统ID查看资源标签列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceTagsRequest"/></param>
        /// <returns><see cref="DescribeResourceTagsResponse"/></returns>
        public async Task<DescribeResourceTagsResponse> DescribeResourceTags(DescribeResourceTagsRequest req)
        {
             JsonResponseModel<DescribeResourceTagsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeResourceTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DescribeResourceTagsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeResourceTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 通过文件系统ID查看回热任务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeRestoreTasksRequest"/></param>
        /// <returns><see cref="DescribeRestoreTasksResponse"/></returns>
        public async Task<DescribeRestoreTasksResponse> DescribeRestoreTasks(DescribeRestoreTasksRequest req)
        {
             JsonResponseModel<DescribeRestoreTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRestoreTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRestoreTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DescribeRestoreTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRestoreTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRestoreTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 修改权限组属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyAccessGroupRequest"/></param>
        /// <returns><see cref="ModifyAccessGroupResponse"/></returns>
        public async Task<ModifyAccessGroupResponse> ModifyAccessGroup(ModifyAccessGroupRequest req)
        {
             JsonResponseModel<ModifyAccessGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAccessGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccessGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<ModifyAccessGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAccessGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccessGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 批量修改权限规则属性，需要指定权限规则ID，支持修改权限规则地址、访问模式和优先级。
        /// </summary>
        /// <param name="req"><see cref="ModifyAccessRulesRequest"/></param>
        /// <returns><see cref="ModifyAccessRulesResponse"/></returns>
        public async Task<ModifyAccessRulesResponse> ModifyAccessRules(ModifyAccessRulesRequest req)
        {
             JsonResponseModel<ModifyAccessRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAccessRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccessRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<ModifyAccessRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAccessRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccessRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 修改文件系统属性，仅限于创建成功的文件系统。
        /// </summary>
        /// <param name="req"><see cref="ModifyFileSystemRequest"/></param>
        /// <returns><see cref="ModifyFileSystemResponse"/></returns>
        public async Task<ModifyFileSystemResponse> ModifyFileSystem(ModifyFileSystemRequest req)
        {
             JsonResponseModel<ModifyFileSystemResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyFileSystem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyFileSystemResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<ModifyFileSystemResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyFileSystem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyFileSystemResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 批量修改生命周期规则属性，需要指定生命周期规则ID，支持修改生命周期规则名称、路径、转换列表和状态。
        /// </summary>
        /// <param name="req"><see cref="ModifyLifeCycleRulesRequest"/></param>
        /// <returns><see cref="ModifyLifeCycleRulesResponse"/></returns>
        public async Task<ModifyLifeCycleRulesResponse> ModifyLifeCycleRules(ModifyLifeCycleRulesRequest req)
        {
             JsonResponseModel<ModifyLifeCycleRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLifeCycleRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLifeCycleRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<ModifyLifeCycleRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLifeCycleRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLifeCycleRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 修改挂载点属性。
        /// </summary>
        /// <param name="req"><see cref="ModifyMountPointRequest"/></param>
        /// <returns><see cref="ModifyMountPointResponse"/></returns>
        public async Task<ModifyMountPointResponse> ModifyMountPoint(ModifyMountPointRequest req)
        {
             JsonResponseModel<ModifyMountPointResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMountPoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMountPointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<ModifyMountPointResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMountPoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMountPointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云API旧版本2019-07-18预下线，所有功能由新版本2020-11-12替代，目前云API主要用作控制台使用。
        /// 
        /// 修改资源标签列表，全量覆盖。
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceTagsRequest"/></param>
        /// <returns><see cref="ModifyResourceTagsResponse"/></returns>
        public async Task<ModifyResourceTagsResponse> ModifyResourceTags(ModifyResourceTagsRequest req)
        {
             JsonResponseModel<ModifyResourceTagsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyResourceTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyResourceTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<ModifyResourceTagsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyResourceTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyResourceTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}

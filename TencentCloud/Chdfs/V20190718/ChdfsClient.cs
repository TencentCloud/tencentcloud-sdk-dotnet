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
        /// CreateAccessGroup接口的同步版本，创建权限组。
        /// </summary>
        /// <param name="req">参考<see cref="CreateAccessGroupRequest"/></param>
        /// <returns>参考<see cref="CreateAccessGroupResponse"/>实例</returns>
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
        /// CreateAccessRules接口的同步版本，批量创建权限规则，权限规则ID和创建时间无需填写。
        /// </summary>
        /// <param name="req">参考<see cref="CreateAccessRulesRequest"/></param>
        /// <returns>参考<see cref="CreateAccessRulesResponse"/>实例</returns>
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
        /// CreateFileSystem接口的同步版本，创建文件系统（异步）。
        /// </summary>
        /// <param name="req">参考<see cref="CreateFileSystemRequest"/></param>
        /// <returns>参考<see cref="CreateFileSystemResponse"/>实例</returns>
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
        /// CreateMountPoint接口的同步版本，创建文件系统挂载点，仅限于创建成功的文件系统。
        /// </summary>
        /// <param name="req">参考<see cref="CreateMountPointRequest"/></param>
        /// <returns>参考<see cref="CreateMountPointResponse"/>实例</returns>
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
        /// DeleteAccessGroup接口的同步版本，删除权限组。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteAccessGroupRequest"/></param>
        /// <returns>参考<see cref="DeleteAccessGroupResponse"/>实例</returns>
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
        /// DeleteAccessRules接口的同步版本，批量删除权限规则。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteAccessRulesRequest"/></param>
        /// <returns>参考<see cref="DeleteAccessRulesResponse"/>实例</returns>
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
        /// DeleteFileSystem接口的同步版本，删除文件系统，不允许删除非空文件系统。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteFileSystemRequest"/></param>
        /// <returns>参考<see cref="DeleteFileSystemResponse"/>实例</returns>
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
        /// DeleteMountPoint接口的同步版本，删除挂载点。
        /// </summary>
        /// <param name="req">参考<see cref="DeleteMountPointRequest"/></param>
        /// <returns>参考<see cref="DeleteMountPointResponse"/>实例</returns>
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
        /// DescribeAccessGroups接口的同步版本，查看权限组列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAccessGroupsRequest"/></param>
        /// <returns>参考<see cref="DescribeAccessGroupsResponse"/>实例</returns>
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
        /// DescribeAccessRules接口的同步版本，通过权限组ID查看权限规则列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAccessRulesRequest"/></param>
        /// <returns>参考<see cref="DescribeAccessRulesResponse"/>实例</returns>
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
        /// DescribeFileSystem接口的同步版本，查看文件系统详细信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeFileSystemRequest"/></param>
        /// <returns>参考<see cref="DescribeFileSystemResponse"/>实例</returns>
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
        /// DescribeFileSystems接口的同步版本，查看文件系统列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeFileSystemsRequest"/></param>
        /// <returns>参考<see cref="DescribeFileSystemsResponse"/>实例</returns>
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
        /// DescribeMountPoint接口的同步版本，查看挂载点详细信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeMountPointRequest"/></param>
        /// <returns>参考<see cref="DescribeMountPointResponse"/>实例</returns>
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
        /// DescribeMountPoints接口的同步版本，通过文件系统ID或者权限组ID查看挂载点列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeMountPointsRequest"/></param>
        /// <returns>参考<see cref="DescribeMountPointsResponse"/>实例</returns>
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
        /// ModifyAccessGroup接口的同步版本，修改权限组属性。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyAccessGroupRequest"/></param>
        /// <returns>参考<see cref="ModifyAccessGroupResponse"/>实例</returns>
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
        /// 批量修改权限规则属性，需要指定权限规则ID。
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
        /// ModifyAccessRules接口的同步版本，批量修改权限规则属性，需要指定权限规则ID。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyAccessRulesRequest"/></param>
        /// <returns>参考<see cref="ModifyAccessRulesResponse"/>实例</returns>
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
        /// ModifyFileSystem接口的同步版本，修改文件系统属性，仅限于创建成功的文件系统。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyFileSystemRequest"/></param>
        /// <returns>参考<see cref="ModifyFileSystemResponse"/>实例</returns>
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
        /// ModifyMountPoint接口的同步版本，修改挂载点属性。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyMountPointRequest"/></param>
        /// <returns>参考<see cref="ModifyMountPointResponse"/>实例</returns>
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

    }
}

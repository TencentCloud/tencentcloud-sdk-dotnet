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

namespace TencentCloud.Chdfs.V20201112
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Chdfs.V20201112.Models;

   public class ChdfsClient : AbstractClient{

       private const string endpoint = "chdfs.tencentcloudapi.com";
       private const string version = "2020-11-12";

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
        /// 给挂载点绑定多个权限组。
        /// </summary>
        /// <param name="req"><see cref="AssociateAccessGroupsRequest"/></param>
        /// <returns><see cref="AssociateAccessGroupsResponse"/></returns>
        public async Task<AssociateAccessGroupsResponse> AssociateAccessGroups(AssociateAccessGroupsRequest req)
        {
             JsonResponseModel<AssociateAccessGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssociateAccessGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateAccessGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 给挂载点绑定多个权限组。
        /// </summary>
        /// <param name="req"><see cref="AssociateAccessGroupsRequest"/></param>
        /// <returns><see cref="AssociateAccessGroupsResponse"/></returns>
        public AssociateAccessGroupsResponse AssociateAccessGroupsSync(AssociateAccessGroupsRequest req)
        {
             JsonResponseModel<AssociateAccessGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssociateAccessGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssociateAccessGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        /// 查看权限组详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessGroupRequest"/></param>
        /// <returns><see cref="DescribeAccessGroupResponse"/></returns>
        public async Task<DescribeAccessGroupResponse> DescribeAccessGroup(DescribeAccessGroupRequest req)
        {
             JsonResponseModel<DescribeAccessGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccessGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccessGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看权限组详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessGroupRequest"/></param>
        /// <returns><see cref="DescribeAccessGroupResponse"/></returns>
        public DescribeAccessGroupResponse DescribeAccessGroupSync(DescribeAccessGroupRequest req)
        {
             JsonResponseModel<DescribeAccessGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAccessGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccessGroupResponse>>(strResp);
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
        /// 查看挂载点列表。
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
        /// 查看挂载点列表。
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
        /// 给挂载点解绑多个权限组。
        /// </summary>
        /// <param name="req"><see cref="DisassociateAccessGroupsRequest"/></param>
        /// <returns><see cref="DisassociateAccessGroupsResponse"/></returns>
        public async Task<DisassociateAccessGroupsResponse> DisassociateAccessGroups(DisassociateAccessGroupsRequest req)
        {
             JsonResponseModel<DisassociateAccessGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisassociateAccessGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateAccessGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 给挂载点解绑多个权限组。
        /// </summary>
        /// <param name="req"><see cref="DisassociateAccessGroupsRequest"/></param>
        /// <returns><see cref="DisassociateAccessGroupsResponse"/></returns>
        public DisassociateAccessGroupsResponse DisassociateAccessGroupsSync(DisassociateAccessGroupsRequest req)
        {
             JsonResponseModel<DisassociateAccessGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisassociateAccessGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisassociateAccessGroupsResponse>>(strResp);
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

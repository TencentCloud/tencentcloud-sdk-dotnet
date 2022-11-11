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

namespace TencentCloud.Cfs.V20190719
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cfs.V20190719.Models;

   public class CfsClient : AbstractClient{

       private const string endpoint = "cfs.tencentcloudapi.com";
       private const string version = "2019-07-19";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CfsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CfsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 文件系统绑定快照策略，可以同时绑定多个fs，一个fs 只能跟一个策略绑定
        /// </summary>
        /// <param name="req"><see cref="BindAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="BindAutoSnapshotPolicyResponse"/></returns>
        public async Task<BindAutoSnapshotPolicyResponse> BindAutoSnapshotPolicy(BindAutoSnapshotPolicyRequest req)
        {
             JsonResponseModel<BindAutoSnapshotPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindAutoSnapshotPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindAutoSnapshotPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 文件系统绑定快照策略，可以同时绑定多个fs，一个fs 只能跟一个策略绑定
        /// </summary>
        /// <param name="req"><see cref="BindAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="BindAutoSnapshotPolicyResponse"/></returns>
        public BindAutoSnapshotPolicyResponse BindAutoSnapshotPolicySync(BindAutoSnapshotPolicyRequest req)
        {
             JsonResponseModel<BindAutoSnapshotPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindAutoSnapshotPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindAutoSnapshotPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建定期快照策略
        /// </summary>
        /// <param name="req"><see cref="CreateAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="CreateAutoSnapshotPolicyResponse"/></returns>
        public async Task<CreateAutoSnapshotPolicyResponse> CreateAutoSnapshotPolicy(CreateAutoSnapshotPolicyRequest req)
        {
             JsonResponseModel<CreateAutoSnapshotPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAutoSnapshotPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAutoSnapshotPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建定期快照策略
        /// </summary>
        /// <param name="req"><see cref="CreateAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="CreateAutoSnapshotPolicyResponse"/></returns>
        public CreateAutoSnapshotPolicyResponse CreateAutoSnapshotPolicySync(CreateAutoSnapshotPolicyRequest req)
        {
             JsonResponseModel<CreateAutoSnapshotPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAutoSnapshotPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAutoSnapshotPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于添加新文件系统
        /// </summary>
        /// <param name="req"><see cref="CreateCfsFileSystemRequest"/></param>
        /// <returns><see cref="CreateCfsFileSystemResponse"/></returns>
        public async Task<CreateCfsFileSystemResponse> CreateCfsFileSystem(CreateCfsFileSystemRequest req)
        {
             JsonResponseModel<CreateCfsFileSystemResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCfsFileSystem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCfsFileSystemResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于添加新文件系统
        /// </summary>
        /// <param name="req"><see cref="CreateCfsFileSystemRequest"/></param>
        /// <returns><see cref="CreateCfsFileSystemResponse"/></returns>
        public CreateCfsFileSystemResponse CreateCfsFileSystemSync(CreateCfsFileSystemRequest req)
        {
             JsonResponseModel<CreateCfsFileSystemResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCfsFileSystem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCfsFileSystemResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateCfsPGroup）用于创建权限组
        /// </summary>
        /// <param name="req"><see cref="CreateCfsPGroupRequest"/></param>
        /// <returns><see cref="CreateCfsPGroupResponse"/></returns>
        public async Task<CreateCfsPGroupResponse> CreateCfsPGroup(CreateCfsPGroupRequest req)
        {
             JsonResponseModel<CreateCfsPGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCfsPGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCfsPGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateCfsPGroup）用于创建权限组
        /// </summary>
        /// <param name="req"><see cref="CreateCfsPGroupRequest"/></param>
        /// <returns><see cref="CreateCfsPGroupResponse"/></returns>
        public CreateCfsPGroupResponse CreateCfsPGroupSync(CreateCfsPGroupRequest req)
        {
             JsonResponseModel<CreateCfsPGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCfsPGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCfsPGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateCfsRule）用于创建权限组规则。
        /// </summary>
        /// <param name="req"><see cref="CreateCfsRuleRequest"/></param>
        /// <returns><see cref="CreateCfsRuleResponse"/></returns>
        public async Task<CreateCfsRuleResponse> CreateCfsRule(CreateCfsRuleRequest req)
        {
             JsonResponseModel<CreateCfsRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCfsRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCfsRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateCfsRule）用于创建权限组规则。
        /// </summary>
        /// <param name="req"><see cref="CreateCfsRuleRequest"/></param>
        /// <returns><see cref="CreateCfsRuleResponse"/></returns>
        public CreateCfsRuleResponse CreateCfsRuleSync(CreateCfsRuleRequest req)
        {
             JsonResponseModel<CreateCfsRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCfsRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCfsRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建文件系统快照
        /// </summary>
        /// <param name="req"><see cref="CreateCfsSnapshotRequest"/></param>
        /// <returns><see cref="CreateCfsSnapshotResponse"/></returns>
        public async Task<CreateCfsSnapshotResponse> CreateCfsSnapshot(CreateCfsSnapshotRequest req)
        {
             JsonResponseModel<CreateCfsSnapshotResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCfsSnapshot");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCfsSnapshotResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建文件系统快照
        /// </summary>
        /// <param name="req"><see cref="CreateCfsSnapshotRequest"/></param>
        /// <returns><see cref="CreateCfsSnapshotResponse"/></returns>
        public CreateCfsSnapshotResponse CreateCfsSnapshotSync(CreateCfsSnapshotRequest req)
        {
             JsonResponseModel<CreateCfsSnapshotResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCfsSnapshot");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCfsSnapshotResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除快照定期策略
        /// </summary>
        /// <param name="req"><see cref="DeleteAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="DeleteAutoSnapshotPolicyResponse"/></returns>
        public async Task<DeleteAutoSnapshotPolicyResponse> DeleteAutoSnapshotPolicy(DeleteAutoSnapshotPolicyRequest req)
        {
             JsonResponseModel<DeleteAutoSnapshotPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAutoSnapshotPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAutoSnapshotPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除快照定期策略
        /// </summary>
        /// <param name="req"><see cref="DeleteAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="DeleteAutoSnapshotPolicyResponse"/></returns>
        public DeleteAutoSnapshotPolicyResponse DeleteAutoSnapshotPolicySync(DeleteAutoSnapshotPolicyRequest req)
        {
             JsonResponseModel<DeleteAutoSnapshotPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAutoSnapshotPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAutoSnapshotPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于删除文件系统
        /// </summary>
        /// <param name="req"><see cref="DeleteCfsFileSystemRequest"/></param>
        /// <returns><see cref="DeleteCfsFileSystemResponse"/></returns>
        public async Task<DeleteCfsFileSystemResponse> DeleteCfsFileSystem(DeleteCfsFileSystemRequest req)
        {
             JsonResponseModel<DeleteCfsFileSystemResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCfsFileSystem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCfsFileSystemResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于删除文件系统
        /// </summary>
        /// <param name="req"><see cref="DeleteCfsFileSystemRequest"/></param>
        /// <returns><see cref="DeleteCfsFileSystemResponse"/></returns>
        public DeleteCfsFileSystemResponse DeleteCfsFileSystemSync(DeleteCfsFileSystemRequest req)
        {
             JsonResponseModel<DeleteCfsFileSystemResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCfsFileSystem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCfsFileSystemResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteCfsPGroup）用于删除权限组。
        /// </summary>
        /// <param name="req"><see cref="DeleteCfsPGroupRequest"/></param>
        /// <returns><see cref="DeleteCfsPGroupResponse"/></returns>
        public async Task<DeleteCfsPGroupResponse> DeleteCfsPGroup(DeleteCfsPGroupRequest req)
        {
             JsonResponseModel<DeleteCfsPGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCfsPGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCfsPGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteCfsPGroup）用于删除权限组。
        /// </summary>
        /// <param name="req"><see cref="DeleteCfsPGroupRequest"/></param>
        /// <returns><see cref="DeleteCfsPGroupResponse"/></returns>
        public DeleteCfsPGroupResponse DeleteCfsPGroupSync(DeleteCfsPGroupRequest req)
        {
             JsonResponseModel<DeleteCfsPGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCfsPGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCfsPGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteCfsRule）用于删除权限组规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteCfsRuleRequest"/></param>
        /// <returns><see cref="DeleteCfsRuleResponse"/></returns>
        public async Task<DeleteCfsRuleResponse> DeleteCfsRule(DeleteCfsRuleRequest req)
        {
             JsonResponseModel<DeleteCfsRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCfsRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCfsRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteCfsRule）用于删除权限组规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteCfsRuleRequest"/></param>
        /// <returns><see cref="DeleteCfsRuleResponse"/></returns>
        public DeleteCfsRuleResponse DeleteCfsRuleSync(DeleteCfsRuleRequest req)
        {
             JsonResponseModel<DeleteCfsRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCfsRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCfsRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除文件系统快照
        /// </summary>
        /// <param name="req"><see cref="DeleteCfsSnapshotRequest"/></param>
        /// <returns><see cref="DeleteCfsSnapshotResponse"/></returns>
        public async Task<DeleteCfsSnapshotResponse> DeleteCfsSnapshot(DeleteCfsSnapshotRequest req)
        {
             JsonResponseModel<DeleteCfsSnapshotResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCfsSnapshot");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCfsSnapshotResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除文件系统快照
        /// </summary>
        /// <param name="req"><see cref="DeleteCfsSnapshotRequest"/></param>
        /// <returns><see cref="DeleteCfsSnapshotResponse"/></returns>
        public DeleteCfsSnapshotResponse DeleteCfsSnapshotSync(DeleteCfsSnapshotRequest req)
        {
             JsonResponseModel<DeleteCfsSnapshotResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCfsSnapshot");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCfsSnapshotResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteMountTarget）用于删除挂载点
        /// </summary>
        /// <param name="req"><see cref="DeleteMountTargetRequest"/></param>
        /// <returns><see cref="DeleteMountTargetResponse"/></returns>
        public async Task<DeleteMountTargetResponse> DeleteMountTarget(DeleteMountTargetRequest req)
        {
             JsonResponseModel<DeleteMountTargetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMountTarget");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMountTargetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteMountTarget）用于删除挂载点
        /// </summary>
        /// <param name="req"><see cref="DeleteMountTargetRequest"/></param>
        /// <returns><see cref="DeleteMountTargetResponse"/></returns>
        public DeleteMountTargetResponse DeleteMountTargetSync(DeleteMountTargetRequest req)
        {
             JsonResponseModel<DeleteMountTargetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteMountTarget");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMountTargetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 指定条件删除文件系统配额
        /// </summary>
        /// <param name="req"><see cref="DeleteUserQuotaRequest"/></param>
        /// <returns><see cref="DeleteUserQuotaResponse"/></returns>
        public async Task<DeleteUserQuotaResponse> DeleteUserQuota(DeleteUserQuotaRequest req)
        {
             JsonResponseModel<DeleteUserQuotaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteUserQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUserQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 指定条件删除文件系统配额
        /// </summary>
        /// <param name="req"><see cref="DeleteUserQuotaRequest"/></param>
        /// <returns><see cref="DeleteUserQuotaResponse"/></returns>
        public DeleteUserQuotaResponse DeleteUserQuotaSync(DeleteUserQuotaRequest req)
        {
             JsonResponseModel<DeleteUserQuotaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteUserQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUserQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询文件系统快照定期策略列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="DescribeAutoSnapshotPoliciesResponse"/></returns>
        public async Task<DescribeAutoSnapshotPoliciesResponse> DescribeAutoSnapshotPolicies(DescribeAutoSnapshotPoliciesRequest req)
        {
             JsonResponseModel<DescribeAutoSnapshotPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAutoSnapshotPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAutoSnapshotPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询文件系统快照定期策略列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoSnapshotPoliciesRequest"/></param>
        /// <returns><see cref="DescribeAutoSnapshotPoliciesResponse"/></returns>
        public DescribeAutoSnapshotPoliciesResponse DescribeAutoSnapshotPoliciesSync(DescribeAutoSnapshotPoliciesRequest req)
        {
             JsonResponseModel<DescribeAutoSnapshotPoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAutoSnapshotPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAutoSnapshotPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeAvailableZoneInfo）用于查询区域的可用情况。
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableZoneInfoRequest"/></param>
        /// <returns><see cref="DescribeAvailableZoneInfoResponse"/></returns>
        public async Task<DescribeAvailableZoneInfoResponse> DescribeAvailableZoneInfo(DescribeAvailableZoneInfoRequest req)
        {
             JsonResponseModel<DescribeAvailableZoneInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAvailableZoneInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAvailableZoneInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeAvailableZoneInfo）用于查询区域的可用情况。
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableZoneInfoRequest"/></param>
        /// <returns><see cref="DescribeAvailableZoneInfoResponse"/></returns>
        public DescribeAvailableZoneInfoResponse DescribeAvailableZoneInfoSync(DescribeAvailableZoneInfoRequest req)
        {
             JsonResponseModel<DescribeAvailableZoneInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAvailableZoneInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAvailableZoneInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询挂载该文件系统的客户端。此功能需要客户端安装CFS监控插件。
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsFileSystemClientsRequest"/></param>
        /// <returns><see cref="DescribeCfsFileSystemClientsResponse"/></returns>
        public async Task<DescribeCfsFileSystemClientsResponse> DescribeCfsFileSystemClients(DescribeCfsFileSystemClientsRequest req)
        {
             JsonResponseModel<DescribeCfsFileSystemClientsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCfsFileSystemClients");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCfsFileSystemClientsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询挂载该文件系统的客户端。此功能需要客户端安装CFS监控插件。
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsFileSystemClientsRequest"/></param>
        /// <returns><see cref="DescribeCfsFileSystemClientsResponse"/></returns>
        public DescribeCfsFileSystemClientsResponse DescribeCfsFileSystemClientsSync(DescribeCfsFileSystemClientsRequest req)
        {
             JsonResponseModel<DescribeCfsFileSystemClientsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCfsFileSystemClients");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCfsFileSystemClientsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCfsFileSystems）用于查询文件系统
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsFileSystemsRequest"/></param>
        /// <returns><see cref="DescribeCfsFileSystemsResponse"/></returns>
        public async Task<DescribeCfsFileSystemsResponse> DescribeCfsFileSystems(DescribeCfsFileSystemsRequest req)
        {
             JsonResponseModel<DescribeCfsFileSystemsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCfsFileSystems");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCfsFileSystemsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCfsFileSystems）用于查询文件系统
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsFileSystemsRequest"/></param>
        /// <returns><see cref="DescribeCfsFileSystemsResponse"/></returns>
        public DescribeCfsFileSystemsResponse DescribeCfsFileSystemsSync(DescribeCfsFileSystemsRequest req)
        {
             JsonResponseModel<DescribeCfsFileSystemsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCfsFileSystems");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCfsFileSystemsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCfsPGroups）用于查询权限组列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsPGroupsRequest"/></param>
        /// <returns><see cref="DescribeCfsPGroupsResponse"/></returns>
        public async Task<DescribeCfsPGroupsResponse> DescribeCfsPGroups(DescribeCfsPGroupsRequest req)
        {
             JsonResponseModel<DescribeCfsPGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCfsPGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCfsPGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCfsPGroups）用于查询权限组列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsPGroupsRequest"/></param>
        /// <returns><see cref="DescribeCfsPGroupsResponse"/></returns>
        public DescribeCfsPGroupsResponse DescribeCfsPGroupsSync(DescribeCfsPGroupsRequest req)
        {
             JsonResponseModel<DescribeCfsPGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCfsPGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCfsPGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCfsRules）用于查询权限组规则列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsRulesRequest"/></param>
        /// <returns><see cref="DescribeCfsRulesResponse"/></returns>
        public async Task<DescribeCfsRulesResponse> DescribeCfsRules(DescribeCfsRulesRequest req)
        {
             JsonResponseModel<DescribeCfsRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCfsRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCfsRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCfsRules）用于查询权限组规则列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsRulesRequest"/></param>
        /// <returns><see cref="DescribeCfsRulesResponse"/></returns>
        public DescribeCfsRulesResponse DescribeCfsRulesSync(DescribeCfsRulesRequest req)
        {
             JsonResponseModel<DescribeCfsRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCfsRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCfsRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCfsServiceStatus）用于查询用户使用CFS的服务状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsServiceStatusRequest"/></param>
        /// <returns><see cref="DescribeCfsServiceStatusResponse"/></returns>
        public async Task<DescribeCfsServiceStatusResponse> DescribeCfsServiceStatus(DescribeCfsServiceStatusRequest req)
        {
             JsonResponseModel<DescribeCfsServiceStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCfsServiceStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCfsServiceStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeCfsServiceStatus）用于查询用户使用CFS的服务状态。
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsServiceStatusRequest"/></param>
        /// <returns><see cref="DescribeCfsServiceStatusResponse"/></returns>
        public DescribeCfsServiceStatusResponse DescribeCfsServiceStatusSync(DescribeCfsServiceStatusRequest req)
        {
             JsonResponseModel<DescribeCfsServiceStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCfsServiceStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCfsServiceStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 文件系统快照概览
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsSnapshotOverviewRequest"/></param>
        /// <returns><see cref="DescribeCfsSnapshotOverviewResponse"/></returns>
        public async Task<DescribeCfsSnapshotOverviewResponse> DescribeCfsSnapshotOverview(DescribeCfsSnapshotOverviewRequest req)
        {
             JsonResponseModel<DescribeCfsSnapshotOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCfsSnapshotOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCfsSnapshotOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 文件系统快照概览
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsSnapshotOverviewRequest"/></param>
        /// <returns><see cref="DescribeCfsSnapshotOverviewResponse"/></returns>
        public DescribeCfsSnapshotOverviewResponse DescribeCfsSnapshotOverviewSync(DescribeCfsSnapshotOverviewRequest req)
        {
             JsonResponseModel<DescribeCfsSnapshotOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCfsSnapshotOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCfsSnapshotOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询文件系统快照列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsSnapshotsRequest"/></param>
        /// <returns><see cref="DescribeCfsSnapshotsResponse"/></returns>
        public async Task<DescribeCfsSnapshotsResponse> DescribeCfsSnapshots(DescribeCfsSnapshotsRequest req)
        {
             JsonResponseModel<DescribeCfsSnapshotsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCfsSnapshots");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCfsSnapshotsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询文件系统快照列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCfsSnapshotsRequest"/></param>
        /// <returns><see cref="DescribeCfsSnapshotsResponse"/></returns>
        public DescribeCfsSnapshotsResponse DescribeCfsSnapshotsSync(DescribeCfsSnapshotsRequest req)
        {
             JsonResponseModel<DescribeCfsSnapshotsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCfsSnapshots");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCfsSnapshotsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeMountTargets）用于查询文件系统挂载点信息
        /// </summary>
        /// <param name="req"><see cref="DescribeMountTargetsRequest"/></param>
        /// <returns><see cref="DescribeMountTargetsResponse"/></returns>
        public async Task<DescribeMountTargetsResponse> DescribeMountTargets(DescribeMountTargetsRequest req)
        {
             JsonResponseModel<DescribeMountTargetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMountTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMountTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeMountTargets）用于查询文件系统挂载点信息
        /// </summary>
        /// <param name="req"><see cref="DescribeMountTargetsRequest"/></param>
        /// <returns><see cref="DescribeMountTargetsResponse"/></returns>
        public DescribeMountTargetsResponse DescribeMountTargetsSync(DescribeMountTargetsRequest req)
        {
             JsonResponseModel<DescribeMountTargetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMountTargets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMountTargetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询快照操作日志
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotOperationLogsRequest"/></param>
        /// <returns><see cref="DescribeSnapshotOperationLogsResponse"/></returns>
        public async Task<DescribeSnapshotOperationLogsResponse> DescribeSnapshotOperationLogs(DescribeSnapshotOperationLogsRequest req)
        {
             JsonResponseModel<DescribeSnapshotOperationLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSnapshotOperationLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotOperationLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询快照操作日志
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotOperationLogsRequest"/></param>
        /// <returns><see cref="DescribeSnapshotOperationLogsResponse"/></returns>
        public DescribeSnapshotOperationLogsResponse DescribeSnapshotOperationLogsSync(DescribeSnapshotOperationLogsRequest req)
        {
             JsonResponseModel<DescribeSnapshotOperationLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSnapshotOperationLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotOperationLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询文件系统配额
        /// </summary>
        /// <param name="req"><see cref="DescribeUserQuotaRequest"/></param>
        /// <returns><see cref="DescribeUserQuotaResponse"/></returns>
        public async Task<DescribeUserQuotaResponse> DescribeUserQuota(DescribeUserQuotaRequest req)
        {
             JsonResponseModel<DescribeUserQuotaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询文件系统配额
        /// </summary>
        /// <param name="req"><see cref="DescribeUserQuotaRequest"/></param>
        /// <returns><see cref="DescribeUserQuotaResponse"/></returns>
        public DescribeUserQuotaResponse DescribeUserQuotaSync(DescribeUserQuotaRequest req)
        {
             JsonResponseModel<DescribeUserQuotaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置文件系统配额，提供UID/GID的配额设置的接口
        /// </summary>
        /// <param name="req"><see cref="SetUserQuotaRequest"/></param>
        /// <returns><see cref="SetUserQuotaResponse"/></returns>
        public async Task<SetUserQuotaResponse> SetUserQuota(SetUserQuotaRequest req)
        {
             JsonResponseModel<SetUserQuotaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetUserQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetUserQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置文件系统配额，提供UID/GID的配额设置的接口
        /// </summary>
        /// <param name="req"><see cref="SetUserQuotaRequest"/></param>
        /// <returns><see cref="SetUserQuotaResponse"/></returns>
        public SetUserQuotaResponse SetUserQuotaSync(SetUserQuotaRequest req)
        {
             JsonResponseModel<SetUserQuotaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetUserQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetUserQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（SignUpCfsService）用于开通CFS服务。
        /// </summary>
        /// <param name="req"><see cref="SignUpCfsServiceRequest"/></param>
        /// <returns><see cref="SignUpCfsServiceResponse"/></returns>
        public async Task<SignUpCfsServiceResponse> SignUpCfsService(SignUpCfsServiceRequest req)
        {
             JsonResponseModel<SignUpCfsServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SignUpCfsService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SignUpCfsServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（SignUpCfsService）用于开通CFS服务。
        /// </summary>
        /// <param name="req"><see cref="SignUpCfsServiceRequest"/></param>
        /// <returns><see cref="SignUpCfsServiceResponse"/></returns>
        public SignUpCfsServiceResponse SignUpCfsServiceSync(SignUpCfsServiceRequest req)
        {
             JsonResponseModel<SignUpCfsServiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SignUpCfsService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SignUpCfsServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解除文件系统绑定的快照策略
        /// </summary>
        /// <param name="req"><see cref="UnbindAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="UnbindAutoSnapshotPolicyResponse"/></returns>
        public async Task<UnbindAutoSnapshotPolicyResponse> UnbindAutoSnapshotPolicy(UnbindAutoSnapshotPolicyRequest req)
        {
             JsonResponseModel<UnbindAutoSnapshotPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnbindAutoSnapshotPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindAutoSnapshotPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解除文件系统绑定的快照策略
        /// </summary>
        /// <param name="req"><see cref="UnbindAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="UnbindAutoSnapshotPolicyResponse"/></returns>
        public UnbindAutoSnapshotPolicyResponse UnbindAutoSnapshotPolicySync(UnbindAutoSnapshotPolicyRequest req)
        {
             JsonResponseModel<UnbindAutoSnapshotPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnbindAutoSnapshotPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindAutoSnapshotPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新定期自动快照策略
        /// </summary>
        /// <param name="req"><see cref="UpdateAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="UpdateAutoSnapshotPolicyResponse"/></returns>
        public async Task<UpdateAutoSnapshotPolicyResponse> UpdateAutoSnapshotPolicy(UpdateAutoSnapshotPolicyRequest req)
        {
             JsonResponseModel<UpdateAutoSnapshotPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateAutoSnapshotPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateAutoSnapshotPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新定期自动快照策略
        /// </summary>
        /// <param name="req"><see cref="UpdateAutoSnapshotPolicyRequest"/></param>
        /// <returns><see cref="UpdateAutoSnapshotPolicyResponse"/></returns>
        public UpdateAutoSnapshotPolicyResponse UpdateAutoSnapshotPolicySync(UpdateAutoSnapshotPolicyRequest req)
        {
             JsonResponseModel<UpdateAutoSnapshotPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateAutoSnapshotPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateAutoSnapshotPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateCfsFileSystemName）用于更新文件系统名
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsFileSystemNameRequest"/></param>
        /// <returns><see cref="UpdateCfsFileSystemNameResponse"/></returns>
        public async Task<UpdateCfsFileSystemNameResponse> UpdateCfsFileSystemName(UpdateCfsFileSystemNameRequest req)
        {
             JsonResponseModel<UpdateCfsFileSystemNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateCfsFileSystemName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCfsFileSystemNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateCfsFileSystemName）用于更新文件系统名
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsFileSystemNameRequest"/></param>
        /// <returns><see cref="UpdateCfsFileSystemNameResponse"/></returns>
        public UpdateCfsFileSystemNameResponse UpdateCfsFileSystemNameSync(UpdateCfsFileSystemNameRequest req)
        {
             JsonResponseModel<UpdateCfsFileSystemNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateCfsFileSystemName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCfsFileSystemNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateCfsFileSystemPGroup）用于更新文件系统所使用的权限组
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsFileSystemPGroupRequest"/></param>
        /// <returns><see cref="UpdateCfsFileSystemPGroupResponse"/></returns>
        public async Task<UpdateCfsFileSystemPGroupResponse> UpdateCfsFileSystemPGroup(UpdateCfsFileSystemPGroupRequest req)
        {
             JsonResponseModel<UpdateCfsFileSystemPGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateCfsFileSystemPGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCfsFileSystemPGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateCfsFileSystemPGroup）用于更新文件系统所使用的权限组
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsFileSystemPGroupRequest"/></param>
        /// <returns><see cref="UpdateCfsFileSystemPGroupResponse"/></returns>
        public UpdateCfsFileSystemPGroupResponse UpdateCfsFileSystemPGroupSync(UpdateCfsFileSystemPGroupRequest req)
        {
             JsonResponseModel<UpdateCfsFileSystemPGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateCfsFileSystemPGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCfsFileSystemPGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateCfsFileSystemSizeLimit）用于更新文件系统存储容量限制。
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsFileSystemSizeLimitRequest"/></param>
        /// <returns><see cref="UpdateCfsFileSystemSizeLimitResponse"/></returns>
        public async Task<UpdateCfsFileSystemSizeLimitResponse> UpdateCfsFileSystemSizeLimit(UpdateCfsFileSystemSizeLimitRequest req)
        {
             JsonResponseModel<UpdateCfsFileSystemSizeLimitResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateCfsFileSystemSizeLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCfsFileSystemSizeLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateCfsFileSystemSizeLimit）用于更新文件系统存储容量限制。
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsFileSystemSizeLimitRequest"/></param>
        /// <returns><see cref="UpdateCfsFileSystemSizeLimitResponse"/></returns>
        public UpdateCfsFileSystemSizeLimitResponse UpdateCfsFileSystemSizeLimitSync(UpdateCfsFileSystemSizeLimitRequest req)
        {
             JsonResponseModel<UpdateCfsFileSystemSizeLimitResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateCfsFileSystemSizeLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCfsFileSystemSizeLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateCfsPGroup）更新权限组信息。
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsPGroupRequest"/></param>
        /// <returns><see cref="UpdateCfsPGroupResponse"/></returns>
        public async Task<UpdateCfsPGroupResponse> UpdateCfsPGroup(UpdateCfsPGroupRequest req)
        {
             JsonResponseModel<UpdateCfsPGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateCfsPGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCfsPGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateCfsPGroup）更新权限组信息。
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsPGroupRequest"/></param>
        /// <returns><see cref="UpdateCfsPGroupResponse"/></returns>
        public UpdateCfsPGroupResponse UpdateCfsPGroupSync(UpdateCfsPGroupRequest req)
        {
             JsonResponseModel<UpdateCfsPGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateCfsPGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCfsPGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateCfsRule）用于更新权限规则。
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsRuleRequest"/></param>
        /// <returns><see cref="UpdateCfsRuleResponse"/></returns>
        public async Task<UpdateCfsRuleResponse> UpdateCfsRule(UpdateCfsRuleRequest req)
        {
             JsonResponseModel<UpdateCfsRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateCfsRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCfsRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateCfsRule）用于更新权限规则。
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsRuleRequest"/></param>
        /// <returns><see cref="UpdateCfsRuleResponse"/></returns>
        public UpdateCfsRuleResponse UpdateCfsRuleSync(UpdateCfsRuleRequest req)
        {
             JsonResponseModel<UpdateCfsRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateCfsRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCfsRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新文件系统快照名称及保留时长
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsSnapshotAttributeRequest"/></param>
        /// <returns><see cref="UpdateCfsSnapshotAttributeResponse"/></returns>
        public async Task<UpdateCfsSnapshotAttributeResponse> UpdateCfsSnapshotAttribute(UpdateCfsSnapshotAttributeRequest req)
        {
             JsonResponseModel<UpdateCfsSnapshotAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateCfsSnapshotAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCfsSnapshotAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新文件系统快照名称及保留时长
        /// </summary>
        /// <param name="req"><see cref="UpdateCfsSnapshotAttributeRequest"/></param>
        /// <returns><see cref="UpdateCfsSnapshotAttributeResponse"/></returns>
        public UpdateCfsSnapshotAttributeResponse UpdateCfsSnapshotAttributeSync(UpdateCfsSnapshotAttributeRequest req)
        {
             JsonResponseModel<UpdateCfsSnapshotAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateCfsSnapshotAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCfsSnapshotAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}

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

namespace TencentCloud.Goosefs.V20220519
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Goosefs.V20220519.Models;

   public class GoosefsClient : AbstractClient{

       private const string endpoint = "goosefs.tencentcloudapi.com";
       private const string version = "2022-05-19";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public GoosefsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public GoosefsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 为客户端节点添加跨vpc或子网访问能力
        /// </summary>
        /// <param name="req"><see cref="AddCrossVpcSubnetSupportForClientNodeRequest"/></param>
        /// <returns><see cref="AddCrossVpcSubnetSupportForClientNodeResponse"/></returns>
        public async Task<AddCrossVpcSubnetSupportForClientNodeResponse> AddCrossVpcSubnetSupportForClientNode(AddCrossVpcSubnetSupportForClientNodeRequest req)
        {
             JsonResponseModel<AddCrossVpcSubnetSupportForClientNodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddCrossVpcSubnetSupportForClientNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddCrossVpcSubnetSupportForClientNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 为客户端节点添加跨vpc或子网访问能力
        /// </summary>
        /// <param name="req"><see cref="AddCrossVpcSubnetSupportForClientNodeRequest"/></param>
        /// <returns><see cref="AddCrossVpcSubnetSupportForClientNodeResponse"/></returns>
        public AddCrossVpcSubnetSupportForClientNodeResponse AddCrossVpcSubnetSupportForClientNodeSync(AddCrossVpcSubnetSupportForClientNodeRequest req)
        {
             JsonResponseModel<AddCrossVpcSubnetSupportForClientNodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddCrossVpcSubnetSupportForClientNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddCrossVpcSubnetSupportForClientNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 为文件系统关联Bucket
        /// </summary>
        /// <param name="req"><see cref="AttachFileSystemBucketRequest"/></param>
        /// <returns><see cref="AttachFileSystemBucketResponse"/></returns>
        public async Task<AttachFileSystemBucketResponse> AttachFileSystemBucket(AttachFileSystemBucketRequest req)
        {
             JsonResponseModel<AttachFileSystemBucketResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AttachFileSystemBucket");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachFileSystemBucketResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 为文件系统关联Bucket
        /// </summary>
        /// <param name="req"><see cref="AttachFileSystemBucketRequest"/></param>
        /// <returns><see cref="AttachFileSystemBucketResponse"/></returns>
        public AttachFileSystemBucketResponse AttachFileSystemBucketSync(AttachFileSystemBucketRequest req)
        {
             JsonResponseModel<AttachFileSystemBucketResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AttachFileSystemBucket");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachFileSystemBucketResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量添加客户端节点
        /// </summary>
        /// <param name="req"><see cref="BatchAddClientNodesRequest"/></param>
        /// <returns><see cref="BatchAddClientNodesResponse"/></returns>
        public async Task<BatchAddClientNodesResponse> BatchAddClientNodes(BatchAddClientNodesRequest req)
        {
             JsonResponseModel<BatchAddClientNodesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchAddClientNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchAddClientNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量添加客户端节点
        /// </summary>
        /// <param name="req"><see cref="BatchAddClientNodesRequest"/></param>
        /// <returns><see cref="BatchAddClientNodesResponse"/></returns>
        public BatchAddClientNodesResponse BatchAddClientNodesSync(BatchAddClientNodesRequest req)
        {
             JsonResponseModel<BatchAddClientNodesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchAddClientNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchAddClientNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量删除客户端节点
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteClientNodesRequest"/></param>
        /// <returns><see cref="BatchDeleteClientNodesResponse"/></returns>
        public async Task<BatchDeleteClientNodesResponse> BatchDeleteClientNodes(BatchDeleteClientNodesRequest req)
        {
             JsonResponseModel<BatchDeleteClientNodesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchDeleteClientNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchDeleteClientNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量删除客户端节点
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteClientNodesRequest"/></param>
        /// <returns><see cref="BatchDeleteClientNodesResponse"/></returns>
        public BatchDeleteClientNodesResponse BatchDeleteClientNodesSync(BatchDeleteClientNodesRequest req)
        {
             JsonResponseModel<BatchDeleteClientNodesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchDeleteClientNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchDeleteClientNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建数据流通任务,包括从将文件系统的数据上传到存储桶下, 以及从存储桶下载到文件系统里。
        /// </summary>
        /// <param name="req"><see cref="CreateDataRepositoryTaskRequest"/></param>
        /// <returns><see cref="CreateDataRepositoryTaskResponse"/></returns>
        public async Task<CreateDataRepositoryTaskResponse> CreateDataRepositoryTask(CreateDataRepositoryTaskRequest req)
        {
             JsonResponseModel<CreateDataRepositoryTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDataRepositoryTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDataRepositoryTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建数据流通任务,包括从将文件系统的数据上传到存储桶下, 以及从存储桶下载到文件系统里。
        /// </summary>
        /// <param name="req"><see cref="CreateDataRepositoryTaskRequest"/></param>
        /// <returns><see cref="CreateDataRepositoryTaskResponse"/></returns>
        public CreateDataRepositoryTaskResponse CreateDataRepositoryTaskSync(CreateDataRepositoryTaskRequest req)
        {
             JsonResponseModel<CreateDataRepositoryTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDataRepositoryTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDataRepositoryTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建文件系统
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
        /// 创建文件系统
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
        /// 为客户端节点删除跨vpc子网访问能力
        /// </summary>
        /// <param name="req"><see cref="DeleteCrossVpcSubnetSupportForClientNodeRequest"/></param>
        /// <returns><see cref="DeleteCrossVpcSubnetSupportForClientNodeResponse"/></returns>
        public async Task<DeleteCrossVpcSubnetSupportForClientNodeResponse> DeleteCrossVpcSubnetSupportForClientNode(DeleteCrossVpcSubnetSupportForClientNodeRequest req)
        {
             JsonResponseModel<DeleteCrossVpcSubnetSupportForClientNodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCrossVpcSubnetSupportForClientNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCrossVpcSubnetSupportForClientNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 为客户端节点删除跨vpc子网访问能力
        /// </summary>
        /// <param name="req"><see cref="DeleteCrossVpcSubnetSupportForClientNodeRequest"/></param>
        /// <returns><see cref="DeleteCrossVpcSubnetSupportForClientNodeResponse"/></returns>
        public DeleteCrossVpcSubnetSupportForClientNodeResponse DeleteCrossVpcSubnetSupportForClientNodeSync(DeleteCrossVpcSubnetSupportForClientNodeRequest req)
        {
             JsonResponseModel<DeleteCrossVpcSubnetSupportForClientNodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCrossVpcSubnetSupportForClientNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCrossVpcSubnetSupportForClientNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除文件系统
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
        /// 删除文件系统
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
        /// 列出集群中所有的客户端节点
        /// </summary>
        /// <param name="req"><see cref="DescribeClientNodesRequest"/></param>
        /// <returns><see cref="DescribeClientNodesResponse"/></returns>
        public async Task<DescribeClientNodesResponse> DescribeClientNodes(DescribeClientNodesRequest req)
        {
             JsonResponseModel<DescribeClientNodesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClientNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClientNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 列出集群中所有的客户端节点
        /// </summary>
        /// <param name="req"><see cref="DescribeClientNodesRequest"/></param>
        /// <returns><see cref="DescribeClientNodesResponse"/></returns>
        public DescribeClientNodesResponse DescribeClientNodesSync(DescribeClientNodesRequest req)
        {
             JsonResponseModel<DescribeClientNodesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClientNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClientNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询GooseFS集群客户端凭证
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterClientTokenRequest"/></param>
        /// <returns><see cref="DescribeClusterClientTokenResponse"/></returns>
        public async Task<DescribeClusterClientTokenResponse> DescribeClusterClientToken(DescribeClusterClientTokenRequest req)
        {
             JsonResponseModel<DescribeClusterClientTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterClientToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterClientTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询GooseFS集群客户端凭证
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterClientTokenRequest"/></param>
        /// <returns><see cref="DescribeClusterClientTokenResponse"/></returns>
        public DescribeClusterClientTokenResponse DescribeClusterClientTokenSync(DescribeClusterClientTokenRequest req)
        {
             JsonResponseModel<DescribeClusterClientTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterClientToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterClientTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询GooseFS集群角色凭证
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterRoleTokenRequest"/></param>
        /// <returns><see cref="DescribeClusterRoleTokenResponse"/></returns>
        public async Task<DescribeClusterRoleTokenResponse> DescribeClusterRoleToken(DescribeClusterRoleTokenRequest req)
        {
             JsonResponseModel<DescribeClusterRoleTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterRoleToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterRoleTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询GooseFS集群角色凭证
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterRoleTokenRequest"/></param>
        /// <returns><see cref="DescribeClusterRoleTokenResponse"/></returns>
        public DescribeClusterRoleTokenResponse DescribeClusterRoleTokenSync(DescribeClusterRoleTokenRequest req)
        {
             JsonResponseModel<DescribeClusterRoleTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterRoleToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterRoleTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询GooseFS集群角色
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterRolesRequest"/></param>
        /// <returns><see cref="DescribeClusterRolesResponse"/></returns>
        public async Task<DescribeClusterRolesResponse> DescribeClusterRoles(DescribeClusterRolesRequest req)
        {
             JsonResponseModel<DescribeClusterRolesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterRoles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterRolesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询GooseFS集群角色
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterRolesRequest"/></param>
        /// <returns><see cref="DescribeClusterRolesResponse"/></returns>
        public DescribeClusterRolesResponse DescribeClusterRolesSync(DescribeClusterRolesRequest req)
        {
             JsonResponseModel<DescribeClusterRolesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterRoles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterRolesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取数据流通任务实时状态，用作客户端控制
        /// </summary>
        /// <param name="req"><see cref="DescribeDataRepositoryTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeDataRepositoryTaskStatusResponse"/></returns>
        public async Task<DescribeDataRepositoryTaskStatusResponse> DescribeDataRepositoryTaskStatus(DescribeDataRepositoryTaskStatusRequest req)
        {
             JsonResponseModel<DescribeDataRepositoryTaskStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDataRepositoryTaskStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataRepositoryTaskStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取数据流通任务实时状态，用作客户端控制
        /// </summary>
        /// <param name="req"><see cref="DescribeDataRepositoryTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeDataRepositoryTaskStatusResponse"/></returns>
        public DescribeDataRepositoryTaskStatusResponse DescribeDataRepositoryTaskStatusSync(DescribeDataRepositoryTaskStatusRequest req)
        {
             JsonResponseModel<DescribeDataRepositoryTaskStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDataRepositoryTaskStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataRepositoryTaskStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 罗列文件系统关联的Bucket映射
        /// </summary>
        /// <param name="req"><see cref="DescribeFileSystemBucketsRequest"/></param>
        /// <returns><see cref="DescribeFileSystemBucketsResponse"/></returns>
        public async Task<DescribeFileSystemBucketsResponse> DescribeFileSystemBuckets(DescribeFileSystemBucketsRequest req)
        {
             JsonResponseModel<DescribeFileSystemBucketsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFileSystemBuckets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFileSystemBucketsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 罗列文件系统关联的Bucket映射
        /// </summary>
        /// <param name="req"><see cref="DescribeFileSystemBucketsRequest"/></param>
        /// <returns><see cref="DescribeFileSystemBucketsResponse"/></returns>
        public DescribeFileSystemBucketsResponse DescribeFileSystemBucketsSync(DescribeFileSystemBucketsRequest req)
        {
             JsonResponseModel<DescribeFileSystemBucketsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFileSystemBuckets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFileSystemBucketsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 列出所有的文件系统
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
        /// 列出所有的文件系统
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
        /// 解绑文件系统与Bucket的映射
        /// </summary>
        /// <param name="req"><see cref="DetachFileSystemBucketRequest"/></param>
        /// <returns><see cref="DetachFileSystemBucketResponse"/></returns>
        public async Task<DetachFileSystemBucketResponse> DetachFileSystemBucket(DetachFileSystemBucketRequest req)
        {
             JsonResponseModel<DetachFileSystemBucketResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetachFileSystemBucket");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachFileSystemBucketResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解绑文件系统与Bucket的映射
        /// </summary>
        /// <param name="req"><see cref="DetachFileSystemBucketRequest"/></param>
        /// <returns><see cref="DetachFileSystemBucketResponse"/></returns>
        public DetachFileSystemBucketResponse DetachFileSystemBucketSync(DetachFileSystemBucketRequest req)
        {
             JsonResponseModel<DetachFileSystemBucketResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetachFileSystemBucket");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachFileSystemBucketResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 扩展文件系统容量
        /// </summary>
        /// <param name="req"><see cref="ExpandCapacityRequest"/></param>
        /// <returns><see cref="ExpandCapacityResponse"/></returns>
        public async Task<ExpandCapacityResponse> ExpandCapacity(ExpandCapacityRequest req)
        {
             JsonResponseModel<ExpandCapacityResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExpandCapacity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExpandCapacityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 扩展文件系统容量
        /// </summary>
        /// <param name="req"><see cref="ExpandCapacityRequest"/></param>
        /// <returns><see cref="ExpandCapacityResponse"/></returns>
        public ExpandCapacityResponse ExpandCapacitySync(ExpandCapacityRequest req)
        {
             JsonResponseModel<ExpandCapacityResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExpandCapacity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExpandCapacityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改数据流动带宽
        /// </summary>
        /// <param name="req"><see cref="ModifyDataRepositoryBandwidthRequest"/></param>
        /// <returns><see cref="ModifyDataRepositoryBandwidthResponse"/></returns>
        public async Task<ModifyDataRepositoryBandwidthResponse> ModifyDataRepositoryBandwidth(ModifyDataRepositoryBandwidthRequest req)
        {
             JsonResponseModel<ModifyDataRepositoryBandwidthResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDataRepositoryBandwidth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDataRepositoryBandwidthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改数据流动带宽
        /// </summary>
        /// <param name="req"><see cref="ModifyDataRepositoryBandwidthRequest"/></param>
        /// <returns><see cref="ModifyDataRepositoryBandwidthResponse"/></returns>
        public ModifyDataRepositoryBandwidthResponse ModifyDataRepositoryBandwidthSync(ModifyDataRepositoryBandwidthRequest req)
        {
             JsonResponseModel<ModifyDataRepositoryBandwidthResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDataRepositoryBandwidth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDataRepositoryBandwidthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询客户端节点跨vpc子网访问能力
        /// </summary>
        /// <param name="req"><see cref="QueryCrossVpcSubnetSupportForClientNodeRequest"/></param>
        /// <returns><see cref="QueryCrossVpcSubnetSupportForClientNodeResponse"/></returns>
        public async Task<QueryCrossVpcSubnetSupportForClientNodeResponse> QueryCrossVpcSubnetSupportForClientNode(QueryCrossVpcSubnetSupportForClientNodeRequest req)
        {
             JsonResponseModel<QueryCrossVpcSubnetSupportForClientNodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryCrossVpcSubnetSupportForClientNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryCrossVpcSubnetSupportForClientNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询客户端节点跨vpc子网访问能力
        /// </summary>
        /// <param name="req"><see cref="QueryCrossVpcSubnetSupportForClientNodeRequest"/></param>
        /// <returns><see cref="QueryCrossVpcSubnetSupportForClientNodeResponse"/></returns>
        public QueryCrossVpcSubnetSupportForClientNodeResponse QueryCrossVpcSubnetSupportForClientNodeSync(QueryCrossVpcSubnetSupportForClientNodeRequest req)
        {
             JsonResponseModel<QueryCrossVpcSubnetSupportForClientNodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryCrossVpcSubnetSupportForClientNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryCrossVpcSubnetSupportForClientNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询数据流动带宽
        /// </summary>
        /// <param name="req"><see cref="QueryDataRepositoryBandwidthRequest"/></param>
        /// <returns><see cref="QueryDataRepositoryBandwidthResponse"/></returns>
        public async Task<QueryDataRepositoryBandwidthResponse> QueryDataRepositoryBandwidth(QueryDataRepositoryBandwidthRequest req)
        {
             JsonResponseModel<QueryDataRepositoryBandwidthResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryDataRepositoryBandwidth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryDataRepositoryBandwidthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询数据流动带宽
        /// </summary>
        /// <param name="req"><see cref="QueryDataRepositoryBandwidthRequest"/></param>
        /// <returns><see cref="QueryDataRepositoryBandwidthResponse"/></returns>
        public QueryDataRepositoryBandwidthResponse QueryDataRepositoryBandwidthSync(QueryDataRepositoryBandwidthRequest req)
        {
             JsonResponseModel<QueryDataRepositoryBandwidthResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryDataRepositoryBandwidth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryDataRepositoryBandwidthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}

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
       private const string sdkVersion = "SDK_NET_3.0.1219";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public GoosefsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 为客户端节点添加跨vpc或子网访问能力
        /// </summary>
        /// <param name="req"><see cref="AddCrossVpcSubnetSupportForClientNodeRequest"/></param>
        /// <returns><see cref="AddCrossVpcSubnetSupportForClientNodeResponse"/></returns>
        public Task<AddCrossVpcSubnetSupportForClientNodeResponse> AddCrossVpcSubnetSupportForClientNode(AddCrossVpcSubnetSupportForClientNodeRequest req)
        {
            return InternalRequestAsync<AddCrossVpcSubnetSupportForClientNodeResponse>(req, "AddCrossVpcSubnetSupportForClientNode");
        }

        /// <summary>
        /// 为客户端节点添加跨vpc或子网访问能力
        /// </summary>
        /// <param name="req"><see cref="AddCrossVpcSubnetSupportForClientNodeRequest"/></param>
        /// <returns><see cref="AddCrossVpcSubnetSupportForClientNodeResponse"/></returns>
        public AddCrossVpcSubnetSupportForClientNodeResponse AddCrossVpcSubnetSupportForClientNodeSync(AddCrossVpcSubnetSupportForClientNodeRequest req)
        {
            return InternalRequestAsync<AddCrossVpcSubnetSupportForClientNodeResponse>(req, "AddCrossVpcSubnetSupportForClientNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 为文件系统关联Bucket
        /// </summary>
        /// <param name="req"><see cref="AttachFileSystemBucketRequest"/></param>
        /// <returns><see cref="AttachFileSystemBucketResponse"/></returns>
        public Task<AttachFileSystemBucketResponse> AttachFileSystemBucket(AttachFileSystemBucketRequest req)
        {
            return InternalRequestAsync<AttachFileSystemBucketResponse>(req, "AttachFileSystemBucket");
        }

        /// <summary>
        /// 为文件系统关联Bucket
        /// </summary>
        /// <param name="req"><see cref="AttachFileSystemBucketRequest"/></param>
        /// <returns><see cref="AttachFileSystemBucketResponse"/></returns>
        public AttachFileSystemBucketResponse AttachFileSystemBucketSync(AttachFileSystemBucketRequest req)
        {
            return InternalRequestAsync<AttachFileSystemBucketResponse>(req, "AttachFileSystemBucket")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量添加客户端节点
        /// </summary>
        /// <param name="req"><see cref="BatchAddClientNodesRequest"/></param>
        /// <returns><see cref="BatchAddClientNodesResponse"/></returns>
        public Task<BatchAddClientNodesResponse> BatchAddClientNodes(BatchAddClientNodesRequest req)
        {
            return InternalRequestAsync<BatchAddClientNodesResponse>(req, "BatchAddClientNodes");
        }

        /// <summary>
        /// 批量添加客户端节点
        /// </summary>
        /// <param name="req"><see cref="BatchAddClientNodesRequest"/></param>
        /// <returns><see cref="BatchAddClientNodesResponse"/></returns>
        public BatchAddClientNodesResponse BatchAddClientNodesSync(BatchAddClientNodesRequest req)
        {
            return InternalRequestAsync<BatchAddClientNodesResponse>(req, "BatchAddClientNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量删除客户端节点
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteClientNodesRequest"/></param>
        /// <returns><see cref="BatchDeleteClientNodesResponse"/></returns>
        public Task<BatchDeleteClientNodesResponse> BatchDeleteClientNodes(BatchDeleteClientNodesRequest req)
        {
            return InternalRequestAsync<BatchDeleteClientNodesResponse>(req, "BatchDeleteClientNodes");
        }

        /// <summary>
        /// 批量删除客户端节点
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteClientNodesRequest"/></param>
        /// <returns><see cref="BatchDeleteClientNodesResponse"/></returns>
        public BatchDeleteClientNodesResponse BatchDeleteClientNodesSync(BatchDeleteClientNodesRequest req)
        {
            return InternalRequestAsync<BatchDeleteClientNodesResponse>(req, "BatchDeleteClientNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建数据流通任务,包括从将文件系统的数据上传到存储桶下, 以及从存储桶下载到文件系统里。
        /// </summary>
        /// <param name="req"><see cref="CreateDataRepositoryTaskRequest"/></param>
        /// <returns><see cref="CreateDataRepositoryTaskResponse"/></returns>
        public Task<CreateDataRepositoryTaskResponse> CreateDataRepositoryTask(CreateDataRepositoryTaskRequest req)
        {
            return InternalRequestAsync<CreateDataRepositoryTaskResponse>(req, "CreateDataRepositoryTask");
        }

        /// <summary>
        /// 创建数据流通任务,包括从将文件系统的数据上传到存储桶下, 以及从存储桶下载到文件系统里。
        /// </summary>
        /// <param name="req"><see cref="CreateDataRepositoryTaskRequest"/></param>
        /// <returns><see cref="CreateDataRepositoryTaskResponse"/></returns>
        public CreateDataRepositoryTaskResponse CreateDataRepositoryTaskSync(CreateDataRepositoryTaskRequest req)
        {
            return InternalRequestAsync<CreateDataRepositoryTaskResponse>(req, "CreateDataRepositoryTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建文件系统
        /// </summary>
        /// <param name="req"><see cref="CreateFileSystemRequest"/></param>
        /// <returns><see cref="CreateFileSystemResponse"/></returns>
        public Task<CreateFileSystemResponse> CreateFileSystem(CreateFileSystemRequest req)
        {
            return InternalRequestAsync<CreateFileSystemResponse>(req, "CreateFileSystem");
        }

        /// <summary>
        /// 创建文件系统
        /// </summary>
        /// <param name="req"><see cref="CreateFileSystemRequest"/></param>
        /// <returns><see cref="CreateFileSystemResponse"/></returns>
        public CreateFileSystemResponse CreateFileSystemSync(CreateFileSystemRequest req)
        {
            return InternalRequestAsync<CreateFileSystemResponse>(req, "CreateFileSystem")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 为客户端节点删除跨vpc子网访问能力
        /// </summary>
        /// <param name="req"><see cref="DeleteCrossVpcSubnetSupportForClientNodeRequest"/></param>
        /// <returns><see cref="DeleteCrossVpcSubnetSupportForClientNodeResponse"/></returns>
        public Task<DeleteCrossVpcSubnetSupportForClientNodeResponse> DeleteCrossVpcSubnetSupportForClientNode(DeleteCrossVpcSubnetSupportForClientNodeRequest req)
        {
            return InternalRequestAsync<DeleteCrossVpcSubnetSupportForClientNodeResponse>(req, "DeleteCrossVpcSubnetSupportForClientNode");
        }

        /// <summary>
        /// 为客户端节点删除跨vpc子网访问能力
        /// </summary>
        /// <param name="req"><see cref="DeleteCrossVpcSubnetSupportForClientNodeRequest"/></param>
        /// <returns><see cref="DeleteCrossVpcSubnetSupportForClientNodeResponse"/></returns>
        public DeleteCrossVpcSubnetSupportForClientNodeResponse DeleteCrossVpcSubnetSupportForClientNodeSync(DeleteCrossVpcSubnetSupportForClientNodeRequest req)
        {
            return InternalRequestAsync<DeleteCrossVpcSubnetSupportForClientNodeResponse>(req, "DeleteCrossVpcSubnetSupportForClientNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除文件系统
        /// </summary>
        /// <param name="req"><see cref="DeleteFileSystemRequest"/></param>
        /// <returns><see cref="DeleteFileSystemResponse"/></returns>
        public Task<DeleteFileSystemResponse> DeleteFileSystem(DeleteFileSystemRequest req)
        {
            return InternalRequestAsync<DeleteFileSystemResponse>(req, "DeleteFileSystem");
        }

        /// <summary>
        /// 删除文件系统
        /// </summary>
        /// <param name="req"><see cref="DeleteFileSystemRequest"/></param>
        /// <returns><see cref="DeleteFileSystemResponse"/></returns>
        public DeleteFileSystemResponse DeleteFileSystemSync(DeleteFileSystemRequest req)
        {
            return InternalRequestAsync<DeleteFileSystemResponse>(req, "DeleteFileSystem")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列出集群中所有的客户端节点
        /// </summary>
        /// <param name="req"><see cref="DescribeClientNodesRequest"/></param>
        /// <returns><see cref="DescribeClientNodesResponse"/></returns>
        public Task<DescribeClientNodesResponse> DescribeClientNodes(DescribeClientNodesRequest req)
        {
            return InternalRequestAsync<DescribeClientNodesResponse>(req, "DescribeClientNodes");
        }

        /// <summary>
        /// 列出集群中所有的客户端节点
        /// </summary>
        /// <param name="req"><see cref="DescribeClientNodesRequest"/></param>
        /// <returns><see cref="DescribeClientNodesResponse"/></returns>
        public DescribeClientNodesResponse DescribeClientNodesSync(DescribeClientNodesRequest req)
        {
            return InternalRequestAsync<DescribeClientNodesResponse>(req, "DescribeClientNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询GooseFS集群客户端凭证
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterClientTokenRequest"/></param>
        /// <returns><see cref="DescribeClusterClientTokenResponse"/></returns>
        public Task<DescribeClusterClientTokenResponse> DescribeClusterClientToken(DescribeClusterClientTokenRequest req)
        {
            return InternalRequestAsync<DescribeClusterClientTokenResponse>(req, "DescribeClusterClientToken");
        }

        /// <summary>
        /// 查询GooseFS集群客户端凭证
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterClientTokenRequest"/></param>
        /// <returns><see cref="DescribeClusterClientTokenResponse"/></returns>
        public DescribeClusterClientTokenResponse DescribeClusterClientTokenSync(DescribeClusterClientTokenRequest req)
        {
            return InternalRequestAsync<DescribeClusterClientTokenResponse>(req, "DescribeClusterClientToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询GooseFS集群角色凭证
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterRoleTokenRequest"/></param>
        /// <returns><see cref="DescribeClusterRoleTokenResponse"/></returns>
        public Task<DescribeClusterRoleTokenResponse> DescribeClusterRoleToken(DescribeClusterRoleTokenRequest req)
        {
            return InternalRequestAsync<DescribeClusterRoleTokenResponse>(req, "DescribeClusterRoleToken");
        }

        /// <summary>
        /// 查询GooseFS集群角色凭证
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterRoleTokenRequest"/></param>
        /// <returns><see cref="DescribeClusterRoleTokenResponse"/></returns>
        public DescribeClusterRoleTokenResponse DescribeClusterRoleTokenSync(DescribeClusterRoleTokenRequest req)
        {
            return InternalRequestAsync<DescribeClusterRoleTokenResponse>(req, "DescribeClusterRoleToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询GooseFS集群角色
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterRolesRequest"/></param>
        /// <returns><see cref="DescribeClusterRolesResponse"/></returns>
        public Task<DescribeClusterRolesResponse> DescribeClusterRoles(DescribeClusterRolesRequest req)
        {
            return InternalRequestAsync<DescribeClusterRolesResponse>(req, "DescribeClusterRoles");
        }

        /// <summary>
        /// 查询GooseFS集群角色
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterRolesRequest"/></param>
        /// <returns><see cref="DescribeClusterRolesResponse"/></returns>
        public DescribeClusterRolesResponse DescribeClusterRolesSync(DescribeClusterRolesRequest req)
        {
            return InternalRequestAsync<DescribeClusterRolesResponse>(req, "DescribeClusterRoles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取数据流通任务实时状态，用作客户端控制
        /// </summary>
        /// <param name="req"><see cref="DescribeDataRepositoryTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeDataRepositoryTaskStatusResponse"/></returns>
        public Task<DescribeDataRepositoryTaskStatusResponse> DescribeDataRepositoryTaskStatus(DescribeDataRepositoryTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeDataRepositoryTaskStatusResponse>(req, "DescribeDataRepositoryTaskStatus");
        }

        /// <summary>
        /// 获取数据流通任务实时状态，用作客户端控制
        /// </summary>
        /// <param name="req"><see cref="DescribeDataRepositoryTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeDataRepositoryTaskStatusResponse"/></returns>
        public DescribeDataRepositoryTaskStatusResponse DescribeDataRepositoryTaskStatusSync(DescribeDataRepositoryTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeDataRepositoryTaskStatusResponse>(req, "DescribeDataRepositoryTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 罗列文件系统关联的Bucket映射
        /// </summary>
        /// <param name="req"><see cref="DescribeFileSystemBucketsRequest"/></param>
        /// <returns><see cref="DescribeFileSystemBucketsResponse"/></returns>
        public Task<DescribeFileSystemBucketsResponse> DescribeFileSystemBuckets(DescribeFileSystemBucketsRequest req)
        {
            return InternalRequestAsync<DescribeFileSystemBucketsResponse>(req, "DescribeFileSystemBuckets");
        }

        /// <summary>
        /// 罗列文件系统关联的Bucket映射
        /// </summary>
        /// <param name="req"><see cref="DescribeFileSystemBucketsRequest"/></param>
        /// <returns><see cref="DescribeFileSystemBucketsResponse"/></returns>
        public DescribeFileSystemBucketsResponse DescribeFileSystemBucketsSync(DescribeFileSystemBucketsRequest req)
        {
            return InternalRequestAsync<DescribeFileSystemBucketsResponse>(req, "DescribeFileSystemBuckets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列出所有的文件系统
        /// </summary>
        /// <param name="req"><see cref="DescribeFileSystemsRequest"/></param>
        /// <returns><see cref="DescribeFileSystemsResponse"/></returns>
        public Task<DescribeFileSystemsResponse> DescribeFileSystems(DescribeFileSystemsRequest req)
        {
            return InternalRequestAsync<DescribeFileSystemsResponse>(req, "DescribeFileSystems");
        }

        /// <summary>
        /// 列出所有的文件系统
        /// </summary>
        /// <param name="req"><see cref="DescribeFileSystemsRequest"/></param>
        /// <returns><see cref="DescribeFileSystemsResponse"/></returns>
        public DescribeFileSystemsResponse DescribeFileSystemsSync(DescribeFileSystemsRequest req)
        {
            return InternalRequestAsync<DescribeFileSystemsResponse>(req, "DescribeFileSystems")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解绑文件系统与Bucket的映射
        /// </summary>
        /// <param name="req"><see cref="DetachFileSystemBucketRequest"/></param>
        /// <returns><see cref="DetachFileSystemBucketResponse"/></returns>
        public Task<DetachFileSystemBucketResponse> DetachFileSystemBucket(DetachFileSystemBucketRequest req)
        {
            return InternalRequestAsync<DetachFileSystemBucketResponse>(req, "DetachFileSystemBucket");
        }

        /// <summary>
        /// 解绑文件系统与Bucket的映射
        /// </summary>
        /// <param name="req"><see cref="DetachFileSystemBucketRequest"/></param>
        /// <returns><see cref="DetachFileSystemBucketResponse"/></returns>
        public DetachFileSystemBucketResponse DetachFileSystemBucketSync(DetachFileSystemBucketRequest req)
        {
            return InternalRequestAsync<DetachFileSystemBucketResponse>(req, "DetachFileSystemBucket")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 扩展文件系统容量
        /// </summary>
        /// <param name="req"><see cref="ExpandCapacityRequest"/></param>
        /// <returns><see cref="ExpandCapacityResponse"/></returns>
        public Task<ExpandCapacityResponse> ExpandCapacity(ExpandCapacityRequest req)
        {
            return InternalRequestAsync<ExpandCapacityResponse>(req, "ExpandCapacity");
        }

        /// <summary>
        /// 扩展文件系统容量
        /// </summary>
        /// <param name="req"><see cref="ExpandCapacityRequest"/></param>
        /// <returns><see cref="ExpandCapacityResponse"/></returns>
        public ExpandCapacityResponse ExpandCapacitySync(ExpandCapacityRequest req)
        {
            return InternalRequestAsync<ExpandCapacityResponse>(req, "ExpandCapacity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改数据流动带宽
        /// </summary>
        /// <param name="req"><see cref="ModifyDataRepositoryBandwidthRequest"/></param>
        /// <returns><see cref="ModifyDataRepositoryBandwidthResponse"/></returns>
        public Task<ModifyDataRepositoryBandwidthResponse> ModifyDataRepositoryBandwidth(ModifyDataRepositoryBandwidthRequest req)
        {
            return InternalRequestAsync<ModifyDataRepositoryBandwidthResponse>(req, "ModifyDataRepositoryBandwidth");
        }

        /// <summary>
        /// 修改数据流动带宽
        /// </summary>
        /// <param name="req"><see cref="ModifyDataRepositoryBandwidthRequest"/></param>
        /// <returns><see cref="ModifyDataRepositoryBandwidthResponse"/></returns>
        public ModifyDataRepositoryBandwidthResponse ModifyDataRepositoryBandwidthSync(ModifyDataRepositoryBandwidthRequest req)
        {
            return InternalRequestAsync<ModifyDataRepositoryBandwidthResponse>(req, "ModifyDataRepositoryBandwidth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询客户端节点跨vpc子网访问能力
        /// </summary>
        /// <param name="req"><see cref="QueryCrossVpcSubnetSupportForClientNodeRequest"/></param>
        /// <returns><see cref="QueryCrossVpcSubnetSupportForClientNodeResponse"/></returns>
        public Task<QueryCrossVpcSubnetSupportForClientNodeResponse> QueryCrossVpcSubnetSupportForClientNode(QueryCrossVpcSubnetSupportForClientNodeRequest req)
        {
            return InternalRequestAsync<QueryCrossVpcSubnetSupportForClientNodeResponse>(req, "QueryCrossVpcSubnetSupportForClientNode");
        }

        /// <summary>
        /// 查询客户端节点跨vpc子网访问能力
        /// </summary>
        /// <param name="req"><see cref="QueryCrossVpcSubnetSupportForClientNodeRequest"/></param>
        /// <returns><see cref="QueryCrossVpcSubnetSupportForClientNodeResponse"/></returns>
        public QueryCrossVpcSubnetSupportForClientNodeResponse QueryCrossVpcSubnetSupportForClientNodeSync(QueryCrossVpcSubnetSupportForClientNodeRequest req)
        {
            return InternalRequestAsync<QueryCrossVpcSubnetSupportForClientNodeResponse>(req, "QueryCrossVpcSubnetSupportForClientNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询数据流动带宽
        /// </summary>
        /// <param name="req"><see cref="QueryDataRepositoryBandwidthRequest"/></param>
        /// <returns><see cref="QueryDataRepositoryBandwidthResponse"/></returns>
        public Task<QueryDataRepositoryBandwidthResponse> QueryDataRepositoryBandwidth(QueryDataRepositoryBandwidthRequest req)
        {
            return InternalRequestAsync<QueryDataRepositoryBandwidthResponse>(req, "QueryDataRepositoryBandwidth");
        }

        /// <summary>
        /// 查询数据流动带宽
        /// </summary>
        /// <param name="req"><see cref="QueryDataRepositoryBandwidthRequest"/></param>
        /// <returns><see cref="QueryDataRepositoryBandwidthResponse"/></returns>
        public QueryDataRepositoryBandwidthResponse QueryDataRepositoryBandwidthSync(QueryDataRepositoryBandwidthRequest req)
        {
            return InternalRequestAsync<QueryDataRepositoryBandwidthResponse>(req, "QueryDataRepositoryBandwidth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}

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

namespace TencentCloud.Cdwdoris.V20211228
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cdwdoris.V20211228.Models;

   public class CdwdorisClient : AbstractClient{

       private const string endpoint = "cdwdoris.tencentcloudapi.com";
       private const string version = "2021-12-28";
       private const string sdkVersion = "SDK_NET_3.0.1020";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CdwdorisClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CdwdorisClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 通过API创建集群
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceNewRequest"/></param>
        /// <returns><see cref="CreateInstanceNewResponse"/></returns>
        public Task<CreateInstanceNewResponse> CreateInstanceNew(CreateInstanceNewRequest req)
        {
            return InternalRequestAsync<CreateInstanceNewResponse>(req, "CreateInstanceNew");
        }

        /// <summary>
        /// 通过API创建集群
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceNewRequest"/></param>
        /// <returns><see cref="CreateInstanceNewResponse"/></returns>
        public CreateInstanceNewResponse CreateInstanceNewSync(CreateInstanceNewRequest req)
        {
            return InternalRequestAsync<CreateInstanceNewResponse>(req, "CreateInstanceNew")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取集群的最新的几个配置文件（config.xml、metrika.xml、user.xml）的内容，显示给用户
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterConfigsRequest"/></param>
        /// <returns><see cref="DescribeClusterConfigsResponse"/></returns>
        public Task<DescribeClusterConfigsResponse> DescribeClusterConfigs(DescribeClusterConfigsRequest req)
        {
            return InternalRequestAsync<DescribeClusterConfigsResponse>(req, "DescribeClusterConfigs");
        }

        /// <summary>
        /// 获取集群的最新的几个配置文件（config.xml、metrika.xml、user.xml）的内容，显示给用户
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterConfigsRequest"/></param>
        /// <returns><see cref="DescribeClusterConfigsResponse"/></returns>
        public DescribeClusterConfigsResponse DescribeClusterConfigsSync(DescribeClusterConfigsRequest req)
        {
            return InternalRequestAsync<DescribeClusterConfigsResponse>(req, "DescribeClusterConfigs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 下载数据库审计日志
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseAuditDownloadRequest"/></param>
        /// <returns><see cref="DescribeDatabaseAuditDownloadResponse"/></returns>
        public Task<DescribeDatabaseAuditDownloadResponse> DescribeDatabaseAuditDownload(DescribeDatabaseAuditDownloadRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseAuditDownloadResponse>(req, "DescribeDatabaseAuditDownload");
        }

        /// <summary>
        /// 下载数据库审计日志
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseAuditDownloadRequest"/></param>
        /// <returns><see cref="DescribeDatabaseAuditDownloadResponse"/></returns>
        public DescribeDatabaseAuditDownloadResponse DescribeDatabaseAuditDownloadSync(DescribeDatabaseAuditDownloadRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseAuditDownloadResponse>(req, "DescribeDatabaseAuditDownload")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取数据库审计记录
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseAuditRecordsRequest"/></param>
        /// <returns><see cref="DescribeDatabaseAuditRecordsResponse"/></returns>
        public Task<DescribeDatabaseAuditRecordsResponse> DescribeDatabaseAuditRecords(DescribeDatabaseAuditRecordsRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseAuditRecordsResponse>(req, "DescribeDatabaseAuditRecords");
        }

        /// <summary>
        /// 获取数据库审计记录
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseAuditRecordsRequest"/></param>
        /// <returns><see cref="DescribeDatabaseAuditRecordsResponse"/></returns>
        public DescribeDatabaseAuditRecordsResponse DescribeDatabaseAuditRecordsSync(DescribeDatabaseAuditRecordsRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseAuditRecordsResponse>(req, "DescribeDatabaseAuditRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据集群ID查询某个集群的具体信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceRequest"/></param>
        /// <returns><see cref="DescribeInstanceResponse"/></returns>
        public Task<DescribeInstanceResponse> DescribeInstance(DescribeInstanceRequest req)
        {
            return InternalRequestAsync<DescribeInstanceResponse>(req, "DescribeInstance");
        }

        /// <summary>
        /// 根据集群ID查询某个集群的具体信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceRequest"/></param>
        /// <returns><see cref="DescribeInstanceResponse"/></returns>
        public DescribeInstanceResponse DescribeInstanceSync(DescribeInstanceRequest req)
        {
            return InternalRequestAsync<DescribeInstanceResponse>(req, "DescribeInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取集群节点信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceNodesRequest"/></param>
        /// <returns><see cref="DescribeInstanceNodesResponse"/></returns>
        public Task<DescribeInstanceNodesResponse> DescribeInstanceNodes(DescribeInstanceNodesRequest req)
        {
            return InternalRequestAsync<DescribeInstanceNodesResponse>(req, "DescribeInstanceNodes");
        }

        /// <summary>
        /// 获取集群节点信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceNodesRequest"/></param>
        /// <returns><see cref="DescribeInstanceNodesResponse"/></returns>
        public DescribeInstanceNodesResponse DescribeInstanceNodesSync(DescribeInstanceNodesRequest req)
        {
            return InternalRequestAsync<DescribeInstanceNodesResponse>(req, "DescribeInstanceNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取BE/FE节点角色
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceNodesInfoRequest"/></param>
        /// <returns><see cref="DescribeInstanceNodesInfoResponse"/></returns>
        public Task<DescribeInstanceNodesInfoResponse> DescribeInstanceNodesInfo(DescribeInstanceNodesInfoRequest req)
        {
            return InternalRequestAsync<DescribeInstanceNodesInfoResponse>(req, "DescribeInstanceNodesInfo");
        }

        /// <summary>
        /// 获取BE/FE节点角色
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceNodesInfoRequest"/></param>
        /// <returns><see cref="DescribeInstanceNodesInfoResponse"/></returns>
        public DescribeInstanceNodesInfoResponse DescribeInstanceNodesInfoSync(DescribeInstanceNodesInfoRequest req)
        {
            return InternalRequestAsync<DescribeInstanceNodesInfoResponse>(req, "DescribeInstanceNodesInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 集群详情页中显示集群状态、流程进度等
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceStateRequest"/></param>
        /// <returns><see cref="DescribeInstanceStateResponse"/></returns>
        public Task<DescribeInstanceStateResponse> DescribeInstanceState(DescribeInstanceStateRequest req)
        {
            return InternalRequestAsync<DescribeInstanceStateResponse>(req, "DescribeInstanceState");
        }

        /// <summary>
        /// 集群详情页中显示集群状态、流程进度等
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceStateRequest"/></param>
        /// <returns><see cref="DescribeInstanceStateResponse"/></returns>
        public DescribeInstanceStateResponse DescribeInstanceStateSync(DescribeInstanceStateRequest req)
        {
            return InternalRequestAsync<DescribeInstanceStateResponse>(req, "DescribeInstanceState")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances");
        }

        /// <summary>
        /// 获取集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取慢查询列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowQueryRecordsRequest"/></param>
        /// <returns><see cref="DescribeSlowQueryRecordsResponse"/></returns>
        public Task<DescribeSlowQueryRecordsResponse> DescribeSlowQueryRecords(DescribeSlowQueryRecordsRequest req)
        {
            return InternalRequestAsync<DescribeSlowQueryRecordsResponse>(req, "DescribeSlowQueryRecords");
        }

        /// <summary>
        /// 获取慢查询列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowQueryRecordsRequest"/></param>
        /// <returns><see cref="DescribeSlowQueryRecordsResponse"/></returns>
        public DescribeSlowQueryRecordsResponse DescribeSlowQueryRecordsSync(DescribeSlowQueryRecordsRequest req)
        {
            return InternalRequestAsync<DescribeSlowQueryRecordsResponse>(req, "DescribeSlowQueryRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 下载慢查询文件
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowQueryRecordsDownloadRequest"/></param>
        /// <returns><see cref="DescribeSlowQueryRecordsDownloadResponse"/></returns>
        public Task<DescribeSlowQueryRecordsDownloadResponse> DescribeSlowQueryRecordsDownload(DescribeSlowQueryRecordsDownloadRequest req)
        {
            return InternalRequestAsync<DescribeSlowQueryRecordsDownloadResponse>(req, "DescribeSlowQueryRecordsDownload");
        }

        /// <summary>
        /// 下载慢查询文件
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowQueryRecordsDownloadRequest"/></param>
        /// <returns><see cref="DescribeSlowQueryRecordsDownloadResponse"/></returns>
        public DescribeSlowQueryRecordsDownloadResponse DescribeSlowQueryRecordsDownloadSync(DescribeSlowQueryRecordsDownloadRequest req)
        {
            return InternalRequestAsync<DescribeSlowQueryRecordsDownloadResponse>(req, "DescribeSlowQueryRecordsDownload")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 销毁集群
        /// </summary>
        /// <param name="req"><see cref="DestroyInstanceRequest"/></param>
        /// <returns><see cref="DestroyInstanceResponse"/></returns>
        public Task<DestroyInstanceResponse> DestroyInstance(DestroyInstanceRequest req)
        {
            return InternalRequestAsync<DestroyInstanceResponse>(req, "DestroyInstance");
        }

        /// <summary>
        /// 销毁集群
        /// </summary>
        /// <param name="req"><see cref="DestroyInstanceRequest"/></param>
        /// <returns><see cref="DestroyInstanceResponse"/></returns>
        public DestroyInstanceResponse DestroyInstanceSync(DestroyInstanceRequest req)
        {
            return InternalRequestAsync<DestroyInstanceResponse>(req, "DestroyInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改集群名称
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public Task<ModifyInstanceResponse> ModifyInstance(ModifyInstanceRequest req)
        {
            return InternalRequestAsync<ModifyInstanceResponse>(req, "ModifyInstance");
        }

        /// <summary>
        /// 修改集群名称
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public ModifyInstanceResponse ModifyInstanceSync(ModifyInstanceRequest req)
        {
            return InternalRequestAsync<ModifyInstanceResponse>(req, "ModifyInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 扩容云盘
        /// </summary>
        /// <param name="req"><see cref="ResizeDiskRequest"/></param>
        /// <returns><see cref="ResizeDiskResponse"/></returns>
        public Task<ResizeDiskResponse> ResizeDisk(ResizeDiskRequest req)
        {
            return InternalRequestAsync<ResizeDiskResponse>(req, "ResizeDisk");
        }

        /// <summary>
        /// 扩容云盘
        /// </summary>
        /// <param name="req"><see cref="ResizeDiskRequest"/></param>
        /// <returns><see cref="ResizeDiskResponse"/></returns>
        public ResizeDiskResponse ResizeDiskSync(ResizeDiskRequest req)
        {
            return InternalRequestAsync<ResizeDiskResponse>(req, "ResizeDisk")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 集群滚动重启
        /// </summary>
        /// <param name="req"><see cref="RestartClusterForNodeRequest"/></param>
        /// <returns><see cref="RestartClusterForNodeResponse"/></returns>
        public Task<RestartClusterForNodeResponse> RestartClusterForNode(RestartClusterForNodeRequest req)
        {
            return InternalRequestAsync<RestartClusterForNodeResponse>(req, "RestartClusterForNode");
        }

        /// <summary>
        /// 集群滚动重启
        /// </summary>
        /// <param name="req"><see cref="RestartClusterForNodeRequest"/></param>
        /// <returns><see cref="RestartClusterForNodeResponse"/></returns>
        public RestartClusterForNodeResponse RestartClusterForNodeSync(RestartClusterForNodeRequest req)
        {
            return InternalRequestAsync<RestartClusterForNodeResponse>(req, "RestartClusterForNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 水平扩容节点
        /// </summary>
        /// <param name="req"><see cref="ScaleOutInstanceRequest"/></param>
        /// <returns><see cref="ScaleOutInstanceResponse"/></returns>
        public Task<ScaleOutInstanceResponse> ScaleOutInstance(ScaleOutInstanceRequest req)
        {
            return InternalRequestAsync<ScaleOutInstanceResponse>(req, "ScaleOutInstance");
        }

        /// <summary>
        /// 水平扩容节点
        /// </summary>
        /// <param name="req"><see cref="ScaleOutInstanceRequest"/></param>
        /// <returns><see cref="ScaleOutInstanceResponse"/></returns>
        public ScaleOutInstanceResponse ScaleOutInstanceSync(ScaleOutInstanceRequest req)
        {
            return InternalRequestAsync<ScaleOutInstanceResponse>(req, "ScaleOutInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 计算资源垂直变配
        /// </summary>
        /// <param name="req"><see cref="ScaleUpInstanceRequest"/></param>
        /// <returns><see cref="ScaleUpInstanceResponse"/></returns>
        public Task<ScaleUpInstanceResponse> ScaleUpInstance(ScaleUpInstanceRequest req)
        {
            return InternalRequestAsync<ScaleUpInstanceResponse>(req, "ScaleUpInstance");
        }

        /// <summary>
        /// 计算资源垂直变配
        /// </summary>
        /// <param name="req"><see cref="ScaleUpInstanceRequest"/></param>
        /// <returns><see cref="ScaleUpInstanceResponse"/></returns>
        public ScaleUpInstanceResponse ScaleUpInstanceSync(ScaleUpInstanceRequest req)
        {
            return InternalRequestAsync<ScaleUpInstanceResponse>(req, "ScaleUpInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}

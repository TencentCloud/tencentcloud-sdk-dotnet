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

namespace TencentCloud.Cdwch.V20200915
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cdwch.V20200915.Models;

   public class CdwchClient : AbstractClient{

       private const string endpoint = "cdwch.tencentcloudapi.com";
       private const string version = "2020-09-15";
       private const string sdkVersion = "SDK_NET_3.0.1007";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CdwchClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CdwchClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 新增和修改用户接口
        /// </summary>
        /// <param name="req"><see cref="ActionAlterCkUserRequest"/></param>
        /// <returns><see cref="ActionAlterCkUserResponse"/></returns>
        public Task<ActionAlterCkUserResponse> ActionAlterCkUser(ActionAlterCkUserRequest req)
        {
            return InternalRequestAsync<ActionAlterCkUserResponse>(req, "ActionAlterCkUser");
        }

        /// <summary>
        /// 新增和修改用户接口
        /// </summary>
        /// <param name="req"><see cref="ActionAlterCkUserRequest"/></param>
        /// <returns><see cref="ActionAlterCkUserResponse"/></returns>
        public ActionAlterCkUserResponse ActionAlterCkUserSync(ActionAlterCkUserRequest req)
        {
            return InternalRequestAsync<ActionAlterCkUserResponse>(req, "ActionAlterCkUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建或者修改备份策略
        /// </summary>
        /// <param name="req"><see cref="CreateBackUpScheduleRequest"/></param>
        /// <returns><see cref="CreateBackUpScheduleResponse"/></returns>
        public Task<CreateBackUpScheduleResponse> CreateBackUpSchedule(CreateBackUpScheduleRequest req)
        {
            return InternalRequestAsync<CreateBackUpScheduleResponse>(req, "CreateBackUpSchedule");
        }

        /// <summary>
        /// 创建或者修改备份策略
        /// </summary>
        /// <param name="req"><see cref="CreateBackUpScheduleRequest"/></param>
        /// <returns><see cref="CreateBackUpScheduleResponse"/></returns>
        public CreateBackUpScheduleResponse CreateBackUpScheduleSync(CreateBackUpScheduleRequest req)
        {
            return InternalRequestAsync<CreateBackUpScheduleResponse>(req, "CreateBackUpSchedule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建集群
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceNewRequest"/></param>
        /// <returns><see cref="CreateInstanceNewResponse"/></returns>
        public Task<CreateInstanceNewResponse> CreateInstanceNew(CreateInstanceNewRequest req)
        {
            return InternalRequestAsync<CreateInstanceNewResponse>(req, "CreateInstanceNew");
        }

        /// <summary>
        /// 创建集群
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceNewRequest"/></param>
        /// <returns><see cref="CreateInstanceNewResponse"/></returns>
        public CreateInstanceNewResponse CreateInstanceNewSync(CreateInstanceNewRequest req)
        {
            return InternalRequestAsync<CreateInstanceNewResponse>(req, "CreateInstanceNew")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除备份数据
        /// </summary>
        /// <param name="req"><see cref="DeleteBackUpDataRequest"/></param>
        /// <returns><see cref="DeleteBackUpDataResponse"/></returns>
        public Task<DeleteBackUpDataResponse> DeleteBackUpData(DeleteBackUpDataRequest req)
        {
            return InternalRequestAsync<DeleteBackUpDataResponse>(req, "DeleteBackUpData");
        }

        /// <summary>
        /// 删除备份数据
        /// </summary>
        /// <param name="req"><see cref="DeleteBackUpDataRequest"/></param>
        /// <returns><see cref="DeleteBackUpDataResponse"/></returns>
        public DeleteBackUpDataResponse DeleteBackUpDataSync(DeleteBackUpDataRequest req)
        {
            return InternalRequestAsync<DeleteBackUpDataResponse>(req, "DeleteBackUpData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询备份任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBackUpJobRequest"/></param>
        /// <returns><see cref="DescribeBackUpJobResponse"/></returns>
        public Task<DescribeBackUpJobResponse> DescribeBackUpJob(DescribeBackUpJobRequest req)
        {
            return InternalRequestAsync<DescribeBackUpJobResponse>(req, "DescribeBackUpJob");
        }

        /// <summary>
        /// 查询备份任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBackUpJobRequest"/></param>
        /// <returns><see cref="DescribeBackUpJobResponse"/></returns>
        public DescribeBackUpJobResponse DescribeBackUpJobSync(DescribeBackUpJobRequest req)
        {
            return InternalRequestAsync<DescribeBackUpJobResponse>(req, "DescribeBackUpJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询备份任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeBackUpJobDetailRequest"/></param>
        /// <returns><see cref="DescribeBackUpJobDetailResponse"/></returns>
        public Task<DescribeBackUpJobDetailResponse> DescribeBackUpJobDetail(DescribeBackUpJobDetailRequest req)
        {
            return InternalRequestAsync<DescribeBackUpJobDetailResponse>(req, "DescribeBackUpJobDetail");
        }

        /// <summary>
        /// 查询备份任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeBackUpJobDetailRequest"/></param>
        /// <returns><see cref="DescribeBackUpJobDetailResponse"/></returns>
        public DescribeBackUpJobDetailResponse DescribeBackUpJobDetailSync(DescribeBackUpJobDetailRequest req)
        {
            return InternalRequestAsync<DescribeBackUpJobDetailResponse>(req, "DescribeBackUpJobDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询备份策略信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBackUpScheduleRequest"/></param>
        /// <returns><see cref="DescribeBackUpScheduleResponse"/></returns>
        public Task<DescribeBackUpScheduleResponse> DescribeBackUpSchedule(DescribeBackUpScheduleRequest req)
        {
            return InternalRequestAsync<DescribeBackUpScheduleResponse>(req, "DescribeBackUpSchedule");
        }

        /// <summary>
        /// 查询备份策略信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBackUpScheduleRequest"/></param>
        /// <returns><see cref="DescribeBackUpScheduleResponse"/></returns>
        public DescribeBackUpScheduleResponse DescribeBackUpScheduleSync(DescribeBackUpScheduleRequest req)
        {
            return InternalRequestAsync<DescribeBackUpScheduleResponse>(req, "DescribeBackUpSchedule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取可备份表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBackUpTablesRequest"/></param>
        /// <returns><see cref="DescribeBackUpTablesResponse"/></returns>
        public Task<DescribeBackUpTablesResponse> DescribeBackUpTables(DescribeBackUpTablesRequest req)
        {
            return InternalRequestAsync<DescribeBackUpTablesResponse>(req, "DescribeBackUpTables");
        }

        /// <summary>
        /// 获取可备份表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeBackUpTablesRequest"/></param>
        /// <returns><see cref="DescribeBackUpTablesResponse"/></returns>
        public DescribeBackUpTablesResponse DescribeBackUpTablesSync(DescribeBackUpTablesRequest req)
        {
            return InternalRequestAsync<DescribeBackUpTablesResponse>(req, "DescribeBackUpTables")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集群用户、集群表，数据库等相关信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCkSqlApisRequest"/></param>
        /// <returns><see cref="DescribeCkSqlApisResponse"/></returns>
        public Task<DescribeCkSqlApisResponse> DescribeCkSqlApis(DescribeCkSqlApisRequest req)
        {
            return InternalRequestAsync<DescribeCkSqlApisResponse>(req, "DescribeCkSqlApis");
        }

        /// <summary>
        /// 查询集群用户、集群表，数据库等相关信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCkSqlApisRequest"/></param>
        /// <returns><see cref="DescribeCkSqlApisResponse"/></returns>
        public DescribeCkSqlApisResponse DescribeCkSqlApisSync(DescribeCkSqlApisRequest req)
        {
            return InternalRequestAsync<DescribeCkSqlApisResponse>(req, "DescribeCkSqlApis")
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
        /// 根据实例ID查询某个实例的具体信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceRequest"/></param>
        /// <returns><see cref="DescribeInstanceResponse"/></returns>
        public Task<DescribeInstanceResponse> DescribeInstance(DescribeInstanceRequest req)
        {
            return InternalRequestAsync<DescribeInstanceResponse>(req, "DescribeInstance");
        }

        /// <summary>
        /// 根据实例ID查询某个实例的具体信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceRequest"/></param>
        /// <returns><see cref="DescribeInstanceResponse"/></returns>
        public DescribeInstanceResponse DescribeInstanceSync(DescribeInstanceRequest req)
        {
            return InternalRequestAsync<DescribeInstanceResponse>(req, "DescribeInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 集群vcluster列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceClustersRequest"/></param>
        /// <returns><see cref="DescribeInstanceClustersResponse"/></returns>
        public Task<DescribeInstanceClustersResponse> DescribeInstanceClusters(DescribeInstanceClustersRequest req)
        {
            return InternalRequestAsync<DescribeInstanceClustersResponse>(req, "DescribeInstanceClusters");
        }

        /// <summary>
        /// 集群vcluster列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceClustersRequest"/></param>
        /// <returns><see cref="DescribeInstanceClustersResponse"/></returns>
        public DescribeInstanceClustersResponse DescribeInstanceClustersSync(DescribeInstanceClustersRequest req)
        {
            return InternalRequestAsync<DescribeInstanceClustersResponse>(req, "DescribeInstanceClusters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在集群详情页面获取所有参数列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceKeyValConfigsRequest"/></param>
        /// <returns><see cref="DescribeInstanceKeyValConfigsResponse"/></returns>
        public Task<DescribeInstanceKeyValConfigsResponse> DescribeInstanceKeyValConfigs(DescribeInstanceKeyValConfigsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceKeyValConfigsResponse>(req, "DescribeInstanceKeyValConfigs");
        }

        /// <summary>
        /// 在集群详情页面获取所有参数列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceKeyValConfigsRequest"/></param>
        /// <returns><see cref="DescribeInstanceKeyValConfigsResponse"/></returns>
        public DescribeInstanceKeyValConfigsResponse DescribeInstanceKeyValConfigsSync(DescribeInstanceKeyValConfigsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceKeyValConfigsResponse>(req, "DescribeInstanceKeyValConfigs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取实例节点信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceNodesRequest"/></param>
        /// <returns><see cref="DescribeInstanceNodesResponse"/></returns>
        public Task<DescribeInstanceNodesResponse> DescribeInstanceNodes(DescribeInstanceNodesRequest req)
        {
            return InternalRequestAsync<DescribeInstanceNodesResponse>(req, "DescribeInstanceNodes");
        }

        /// <summary>
        /// 获取实例节点信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceNodesRequest"/></param>
        /// <returns><see cref="DescribeInstanceNodesResponse"/></returns>
        public DescribeInstanceNodesResponse DescribeInstanceNodesSync(DescribeInstanceNodesRequest req)
        {
            return InternalRequestAsync<DescribeInstanceNodesResponse>(req, "DescribeInstanceNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取实例shard信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceShardsRequest"/></param>
        /// <returns><see cref="DescribeInstanceShardsResponse"/></returns>
        public Task<DescribeInstanceShardsResponse> DescribeInstanceShards(DescribeInstanceShardsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceShardsResponse>(req, "DescribeInstanceShards");
        }

        /// <summary>
        /// 获取实例shard信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceShardsRequest"/></param>
        /// <returns><see cref="DescribeInstanceShardsResponse"/></returns>
        public DescribeInstanceShardsResponse DescribeInstanceShardsSync(DescribeInstanceShardsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceShardsResponse>(req, "DescribeInstanceShards")
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
        /// 获取实例列表，供外部sdk使用
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesNewRequest"/></param>
        /// <returns><see cref="DescribeInstancesNewResponse"/></returns>
        public Task<DescribeInstancesNewResponse> DescribeInstancesNew(DescribeInstancesNewRequest req)
        {
            return InternalRequestAsync<DescribeInstancesNewResponse>(req, "DescribeInstancesNew");
        }

        /// <summary>
        /// 获取实例列表，供外部sdk使用
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesNewRequest"/></param>
        /// <returns><see cref="DescribeInstancesNewResponse"/></returns>
        public DescribeInstancesNewResponse DescribeInstancesNewSync(DescribeInstancesNewRequest req)
        {
            return InternalRequestAsync<DescribeInstancesNewResponse>(req, "DescribeInstancesNew")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 购买页拉取集群的数据节点和zookeeper节点的规格列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSpecRequest"/></param>
        /// <returns><see cref="DescribeSpecResponse"/></returns>
        public Task<DescribeSpecResponse> DescribeSpec(DescribeSpecRequest req)
        {
            return InternalRequestAsync<DescribeSpecResponse>(req, "DescribeSpec");
        }

        /// <summary>
        /// 购买页拉取集群的数据节点和zookeeper节点的规格列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSpecRequest"/></param>
        /// <returns><see cref="DescribeSpecResponse"/></returns>
        public DescribeSpecResponse DescribeSpecSync(DescribeSpecRequest req)
        {
            return InternalRequestAsync<DescribeSpecResponse>(req, "DescribeSpec")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 销毁集群 open api
        /// </summary>
        /// <param name="req"><see cref="DestroyInstanceRequest"/></param>
        /// <returns><see cref="DestroyInstanceResponse"/></returns>
        public Task<DestroyInstanceResponse> DestroyInstance(DestroyInstanceRequest req)
        {
            return InternalRequestAsync<DestroyInstanceResponse>(req, "DestroyInstance");
        }

        /// <summary>
        /// 销毁集群 open api
        /// </summary>
        /// <param name="req"><see cref="DestroyInstanceRequest"/></param>
        /// <returns><see cref="DestroyInstanceResponse"/></returns>
        public DestroyInstanceResponse DestroyInstanceSync(DestroyInstanceRequest req)
        {
            return InternalRequestAsync<DestroyInstanceResponse>(req, "DestroyInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在集群配置页面修改集群配置文件接口，xml模式
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterConfigsRequest"/></param>
        /// <returns><see cref="ModifyClusterConfigsResponse"/></returns>
        public Task<ModifyClusterConfigsResponse> ModifyClusterConfigs(ModifyClusterConfigsRequest req)
        {
            return InternalRequestAsync<ModifyClusterConfigsResponse>(req, "ModifyClusterConfigs");
        }

        /// <summary>
        /// 在集群配置页面修改集群配置文件接口，xml模式
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterConfigsRequest"/></param>
        /// <returns><see cref="ModifyClusterConfigsResponse"/></returns>
        public ModifyClusterConfigsResponse ModifyClusterConfigsSync(ModifyClusterConfigsRequest req)
        {
            return InternalRequestAsync<ModifyClusterConfigsResponse>(req, "ModifyClusterConfigs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// KV模式修改配置接口
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceKeyValConfigsRequest"/></param>
        /// <returns><see cref="ModifyInstanceKeyValConfigsResponse"/></returns>
        public Task<ModifyInstanceKeyValConfigsResponse> ModifyInstanceKeyValConfigs(ModifyInstanceKeyValConfigsRequest req)
        {
            return InternalRequestAsync<ModifyInstanceKeyValConfigsResponse>(req, "ModifyInstanceKeyValConfigs");
        }

        /// <summary>
        /// KV模式修改配置接口
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceKeyValConfigsRequest"/></param>
        /// <returns><see cref="ModifyInstanceKeyValConfigsResponse"/></returns>
        public ModifyInstanceKeyValConfigsResponse ModifyInstanceKeyValConfigsSync(ModifyInstanceKeyValConfigsRequest req)
        {
            return InternalRequestAsync<ModifyInstanceKeyValConfigsResponse>(req, "ModifyInstanceKeyValConfigs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 针对集群账号的权限做管控（新版）
        /// </summary>
        /// <param name="req"><see cref="ModifyUserNewPrivilegeRequest"/></param>
        /// <returns><see cref="ModifyUserNewPrivilegeResponse"/></returns>
        public Task<ModifyUserNewPrivilegeResponse> ModifyUserNewPrivilege(ModifyUserNewPrivilegeRequest req)
        {
            return InternalRequestAsync<ModifyUserNewPrivilegeResponse>(req, "ModifyUserNewPrivilege");
        }

        /// <summary>
        /// 针对集群账号的权限做管控（新版）
        /// </summary>
        /// <param name="req"><see cref="ModifyUserNewPrivilegeRequest"/></param>
        /// <returns><see cref="ModifyUserNewPrivilegeResponse"/></returns>
        public ModifyUserNewPrivilegeResponse ModifyUserNewPrivilegeSync(ModifyUserNewPrivilegeRequest req)
        {
            return InternalRequestAsync<ModifyUserNewPrivilegeResponse>(req, "ModifyUserNewPrivilege")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开启或者关闭策略
        /// </summary>
        /// <param name="req"><see cref="OpenBackUpRequest"/></param>
        /// <returns><see cref="OpenBackUpResponse"/></returns>
        public Task<OpenBackUpResponse> OpenBackUp(OpenBackUpRequest req)
        {
            return InternalRequestAsync<OpenBackUpResponse>(req, "OpenBackUp");
        }

        /// <summary>
        /// 开启或者关闭策略
        /// </summary>
        /// <param name="req"><see cref="OpenBackUpRequest"/></param>
        /// <returns><see cref="OpenBackUpResponse"/></returns>
        public OpenBackUpResponse OpenBackUpSync(OpenBackUpRequest req)
        {
            return InternalRequestAsync<OpenBackUpResponse>(req, "OpenBackUp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 备份恢复
        /// </summary>
        /// <param name="req"><see cref="RecoverBackUpJobRequest"/></param>
        /// <returns><see cref="RecoverBackUpJobResponse"/></returns>
        public Task<RecoverBackUpJobResponse> RecoverBackUpJob(RecoverBackUpJobRequest req)
        {
            return InternalRequestAsync<RecoverBackUpJobResponse>(req, "RecoverBackUpJob");
        }

        /// <summary>
        /// 备份恢复
        /// </summary>
        /// <param name="req"><see cref="RecoverBackUpJobRequest"/></param>
        /// <returns><see cref="RecoverBackUpJobResponse"/></returns>
        public RecoverBackUpJobResponse RecoverBackUpJobSync(RecoverBackUpJobRequest req)
        {
            return InternalRequestAsync<RecoverBackUpJobResponse>(req, "RecoverBackUpJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 扩容磁盘，包含扩容数据节点，zk节点
        /// </summary>
        /// <param name="req"><see cref="ResizeDiskRequest"/></param>
        /// <returns><see cref="ResizeDiskResponse"/></returns>
        public Task<ResizeDiskResponse> ResizeDisk(ResizeDiskRequest req)
        {
            return InternalRequestAsync<ResizeDiskResponse>(req, "ResizeDisk");
        }

        /// <summary>
        /// 扩容磁盘，包含扩容数据节点，zk节点
        /// </summary>
        /// <param name="req"><see cref="ResizeDiskRequest"/></param>
        /// <returns><see cref="ResizeDiskResponse"/></returns>
        public ResizeDiskResponse ResizeDiskSync(ResizeDiskRequest req)
        {
            return InternalRequestAsync<ResizeDiskResponse>(req, "ResizeDisk")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 调整clickhouse节点数量
        /// </summary>
        /// <param name="req"><see cref="ScaleOutInstanceRequest"/></param>
        /// <returns><see cref="ScaleOutInstanceResponse"/></returns>
        public Task<ScaleOutInstanceResponse> ScaleOutInstance(ScaleOutInstanceRequest req)
        {
            return InternalRequestAsync<ScaleOutInstanceResponse>(req, "ScaleOutInstance");
        }

        /// <summary>
        /// 调整clickhouse节点数量
        /// </summary>
        /// <param name="req"><see cref="ScaleOutInstanceRequest"/></param>
        /// <returns><see cref="ScaleOutInstanceResponse"/></returns>
        public ScaleOutInstanceResponse ScaleOutInstanceSync(ScaleOutInstanceRequest req)
        {
            return InternalRequestAsync<ScaleOutInstanceResponse>(req, "ScaleOutInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 垂直扩缩容节点规格，修改节点cvm的规格cpu，内存。 规格变化阶段，服务不可用。
        /// </summary>
        /// <param name="req"><see cref="ScaleUpInstanceRequest"/></param>
        /// <returns><see cref="ScaleUpInstanceResponse"/></returns>
        public Task<ScaleUpInstanceResponse> ScaleUpInstance(ScaleUpInstanceRequest req)
        {
            return InternalRequestAsync<ScaleUpInstanceResponse>(req, "ScaleUpInstance");
        }

        /// <summary>
        /// 垂直扩缩容节点规格，修改节点cvm的规格cpu，内存。 规格变化阶段，服务不可用。
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

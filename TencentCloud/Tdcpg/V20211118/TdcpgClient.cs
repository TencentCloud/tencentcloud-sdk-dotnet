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

namespace TencentCloud.Tdcpg.V20211118
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tdcpg.V20211118.Models;

   public class TdcpgClient : AbstractClient{

       private const string endpoint = "tdcpg.tencentcloudapi.com";
       private const string version = "2021-11-18";
       private const string sdkVersion = "SDK_NET_3.0.1073";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TdcpgClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TdcpgClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 使用指定时间点的备份克隆一个新的集群
        /// </summary>
        /// <param name="req"><see cref="CloneClusterToPointInTimeRequest"/></param>
        /// <returns><see cref="CloneClusterToPointInTimeResponse"/></returns>
        public Task<CloneClusterToPointInTimeResponse> CloneClusterToPointInTime(CloneClusterToPointInTimeRequest req)
        {
            return InternalRequestAsync<CloneClusterToPointInTimeResponse>(req, "CloneClusterToPointInTime");
        }

        /// <summary>
        /// 使用指定时间点的备份克隆一个新的集群
        /// </summary>
        /// <param name="req"><see cref="CloneClusterToPointInTimeRequest"/></param>
        /// <returns><see cref="CloneClusterToPointInTimeResponse"/></returns>
        public CloneClusterToPointInTimeResponse CloneClusterToPointInTimeSync(CloneClusterToPointInTimeRequest req)
        {
            return InternalRequestAsync<CloneClusterToPointInTimeResponse>(req, "CloneClusterToPointInTime")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建集群
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRequest"/></param>
        /// <returns><see cref="CreateClusterResponse"/></returns>
        public Task<CreateClusterResponse> CreateCluster(CreateClusterRequest req)
        {
            return InternalRequestAsync<CreateClusterResponse>(req, "CreateCluster");
        }

        /// <summary>
        /// 创建集群
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRequest"/></param>
        /// <returns><see cref="CreateClusterResponse"/></returns>
        public CreateClusterResponse CreateClusterSync(CreateClusterRequest req)
        {
            return InternalRequestAsync<CreateClusterResponse>(req, "CreateCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在集群中新建实例
        /// </summary>
        /// <param name="req"><see cref="CreateClusterInstancesRequest"/></param>
        /// <returns><see cref="CreateClusterInstancesResponse"/></returns>
        public Task<CreateClusterInstancesResponse> CreateClusterInstances(CreateClusterInstancesRequest req)
        {
            return InternalRequestAsync<CreateClusterInstancesResponse>(req, "CreateClusterInstances");
        }

        /// <summary>
        /// 在集群中新建实例
        /// </summary>
        /// <param name="req"><see cref="CreateClusterInstancesRequest"/></param>
        /// <returns><see cref="CreateClusterInstancesResponse"/></returns>
        public CreateClusterInstancesResponse CreateClusterInstancesSync(CreateClusterInstancesRequest req)
        {
            return InternalRequestAsync<CreateClusterInstancesResponse>(req, "CreateClusterInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除集群，集群中的实例和数据都将被删除，且无法恢复。只有当集群状态处于isolated(已隔离)时才生效。
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRequest"/></param>
        /// <returns><see cref="DeleteClusterResponse"/></returns>
        public Task<DeleteClusterResponse> DeleteCluster(DeleteClusterRequest req)
        {
            return InternalRequestAsync<DeleteClusterResponse>(req, "DeleteCluster");
        }

        /// <summary>
        /// 删除集群，集群中的实例和数据都将被删除，且无法恢复。只有当集群状态处于isolated(已隔离)时才生效。
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRequest"/></param>
        /// <returns><see cref="DeleteClusterResponse"/></returns>
        public DeleteClusterResponse DeleteClusterSync(DeleteClusterRequest req)
        {
            return InternalRequestAsync<DeleteClusterResponse>(req, "DeleteCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除实例。只有当实例状态处于isolated(已隔离)时才生效。
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterInstancesRequest"/></param>
        /// <returns><see cref="DeleteClusterInstancesResponse"/></returns>
        public Task<DeleteClusterInstancesResponse> DeleteClusterInstances(DeleteClusterInstancesRequest req)
        {
            return InternalRequestAsync<DeleteClusterInstancesResponse>(req, "DeleteClusterInstances");
        }

        /// <summary>
        /// 删除实例。只有当实例状态处于isolated(已隔离)时才生效。
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterInstancesRequest"/></param>
        /// <returns><see cref="DeleteClusterInstancesResponse"/></returns>
        public DeleteClusterInstancesResponse DeleteClusterInstancesSync(DeleteClusterInstancesRequest req)
        {
            return InternalRequestAsync<DeleteClusterInstancesResponse>(req, "DeleteClusterInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询数据库账号信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountsRequest"/></param>
        /// <returns><see cref="DescribeAccountsResponse"/></returns>
        public Task<DescribeAccountsResponse> DescribeAccounts(DescribeAccountsRequest req)
        {
            return InternalRequestAsync<DescribeAccountsResponse>(req, "DescribeAccounts");
        }

        /// <summary>
        /// 查询数据库账号信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountsRequest"/></param>
        /// <returns><see cref="DescribeAccountsResponse"/></returns>
        public DescribeAccountsResponse DescribeAccountsSync(DescribeAccountsRequest req)
        {
            return InternalRequestAsync<DescribeAccountsResponse>(req, "DescribeAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集群的备份集
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterBackupsRequest"/></param>
        /// <returns><see cref="DescribeClusterBackupsResponse"/></returns>
        public Task<DescribeClusterBackupsResponse> DescribeClusterBackups(DescribeClusterBackupsRequest req)
        {
            return InternalRequestAsync<DescribeClusterBackupsResponse>(req, "DescribeClusterBackups");
        }

        /// <summary>
        /// 查询集群的备份集
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterBackupsRequest"/></param>
        /// <returns><see cref="DescribeClusterBackupsResponse"/></returns>
        public DescribeClusterBackupsResponse DescribeClusterBackupsSync(DescribeClusterBackupsRequest req)
        {
            return InternalRequestAsync<DescribeClusterBackupsResponse>(req, "DescribeClusterBackups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集群接入点信息
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterEndpointsRequest"/></param>
        /// <returns><see cref="DescribeClusterEndpointsResponse"/></returns>
        public Task<DescribeClusterEndpointsResponse> DescribeClusterEndpoints(DescribeClusterEndpointsRequest req)
        {
            return InternalRequestAsync<DescribeClusterEndpointsResponse>(req, "DescribeClusterEndpoints");
        }

        /// <summary>
        /// 查询集群接入点信息
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterEndpointsRequest"/></param>
        /// <returns><see cref="DescribeClusterEndpointsResponse"/></returns>
        public DescribeClusterEndpointsResponse DescribeClusterEndpointsSync(DescribeClusterEndpointsRequest req)
        {
            return InternalRequestAsync<DescribeClusterEndpointsResponse>(req, "DescribeClusterEndpoints")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterInstancesRequest"/></param>
        /// <returns><see cref="DescribeClusterInstancesResponse"/></returns>
        public Task<DescribeClusterInstancesResponse> DescribeClusterInstances(DescribeClusterInstancesRequest req)
        {
            return InternalRequestAsync<DescribeClusterInstancesResponse>(req, "DescribeClusterInstances");
        }

        /// <summary>
        /// 查询实例
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterInstancesRequest"/></param>
        /// <returns><see cref="DescribeClusterInstancesResponse"/></returns>
        public DescribeClusterInstancesResponse DescribeClusterInstancesSync(DescribeClusterInstancesRequest req)
        {
            return InternalRequestAsync<DescribeClusterInstancesResponse>(req, "DescribeClusterInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集群可回档时间范围
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterRecoveryTimeRangeRequest"/></param>
        /// <returns><see cref="DescribeClusterRecoveryTimeRangeResponse"/></returns>
        public Task<DescribeClusterRecoveryTimeRangeResponse> DescribeClusterRecoveryTimeRange(DescribeClusterRecoveryTimeRangeRequest req)
        {
            return InternalRequestAsync<DescribeClusterRecoveryTimeRangeResponse>(req, "DescribeClusterRecoveryTimeRange");
        }

        /// <summary>
        /// 查询集群可回档时间范围
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterRecoveryTimeRangeRequest"/></param>
        /// <returns><see cref="DescribeClusterRecoveryTimeRangeResponse"/></returns>
        public DescribeClusterRecoveryTimeRangeResponse DescribeClusterRecoveryTimeRangeSync(DescribeClusterRecoveryTimeRangeRequest req)
        {
            return InternalRequestAsync<DescribeClusterRecoveryTimeRangeResponse>(req, "DescribeClusterRecoveryTimeRange")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集群
        /// </summary>
        /// <param name="req"><see cref="DescribeClustersRequest"/></param>
        /// <returns><see cref="DescribeClustersResponse"/></returns>
        public Task<DescribeClustersResponse> DescribeClusters(DescribeClustersRequest req)
        {
            return InternalRequestAsync<DescribeClustersResponse>(req, "DescribeClusters");
        }

        /// <summary>
        /// 查询集群
        /// </summary>
        /// <param name="req"><see cref="DescribeClustersRequest"/></param>
        /// <returns><see cref="DescribeClustersResponse"/></returns>
        public DescribeClustersResponse DescribeClustersSync(DescribeClustersRequest req)
        {
            return InternalRequestAsync<DescribeClustersResponse>(req, "DescribeClusters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据订单号获取资源信息
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcesByDealNameRequest"/></param>
        /// <returns><see cref="DescribeResourcesByDealNameResponse"/></returns>
        public Task<DescribeResourcesByDealNameResponse> DescribeResourcesByDealName(DescribeResourcesByDealNameRequest req)
        {
            return InternalRequestAsync<DescribeResourcesByDealNameResponse>(req, "DescribeResourcesByDealName");
        }

        /// <summary>
        /// 根据订单号获取资源信息
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcesByDealNameRequest"/></param>
        /// <returns><see cref="DescribeResourcesByDealNameResponse"/></returns>
        public DescribeResourcesByDealNameResponse DescribeResourcesByDealNameSync(DescribeResourcesByDealNameRequest req)
        {
            return InternalRequestAsync<DescribeResourcesByDealNameResponse>(req, "DescribeResourcesByDealName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 隔离集群，集群的接入点网络将会断掉无法连接使用数据库。只有当集群状态处于running(运行中)时才生效。
        /// </summary>
        /// <param name="req"><see cref="IsolateClusterRequest"/></param>
        /// <returns><see cref="IsolateClusterResponse"/></returns>
        public Task<IsolateClusterResponse> IsolateCluster(IsolateClusterRequest req)
        {
            return InternalRequestAsync<IsolateClusterResponse>(req, "IsolateCluster");
        }

        /// <summary>
        /// 隔离集群，集群的接入点网络将会断掉无法连接使用数据库。只有当集群状态处于running(运行中)时才生效。
        /// </summary>
        /// <param name="req"><see cref="IsolateClusterRequest"/></param>
        /// <returns><see cref="IsolateClusterResponse"/></returns>
        public IsolateClusterResponse IsolateClusterSync(IsolateClusterRequest req)
        {
            return InternalRequestAsync<IsolateClusterResponse>(req, "IsolateCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 隔离实例。此接口只针对状态为running的实例生效，使用场景包括：
        ///  - 批量隔离集群内所有的实例
        ///  - 在读写实例为running(运行中)时，单个/批量隔离只读实例
        ///  - 集群内所有只读实例为isolated(已隔离)时，单独隔离读写实例
        /// </summary>
        /// <param name="req"><see cref="IsolateClusterInstancesRequest"/></param>
        /// <returns><see cref="IsolateClusterInstancesResponse"/></returns>
        public Task<IsolateClusterInstancesResponse> IsolateClusterInstances(IsolateClusterInstancesRequest req)
        {
            return InternalRequestAsync<IsolateClusterInstancesResponse>(req, "IsolateClusterInstances");
        }

        /// <summary>
        /// 隔离实例。此接口只针对状态为running的实例生效，使用场景包括：
        ///  - 批量隔离集群内所有的实例
        ///  - 在读写实例为running(运行中)时，单个/批量隔离只读实例
        ///  - 集群内所有只读实例为isolated(已隔离)时，单独隔离读写实例
        /// </summary>
        /// <param name="req"><see cref="IsolateClusterInstancesRequest"/></param>
        /// <returns><see cref="IsolateClusterInstancesResponse"/></returns>
        public IsolateClusterInstancesResponse IsolateClusterInstancesSync(IsolateClusterInstancesRequest req)
        {
            return InternalRequestAsync<IsolateClusterInstancesResponse>(req, "IsolateClusterInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改数据库账号描述
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountDescriptionRequest"/></param>
        /// <returns><see cref="ModifyAccountDescriptionResponse"/></returns>
        public Task<ModifyAccountDescriptionResponse> ModifyAccountDescription(ModifyAccountDescriptionRequest req)
        {
            return InternalRequestAsync<ModifyAccountDescriptionResponse>(req, "ModifyAccountDescription");
        }

        /// <summary>
        /// 修改数据库账号描述
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountDescriptionRequest"/></param>
        /// <returns><see cref="ModifyAccountDescriptionResponse"/></returns>
        public ModifyAccountDescriptionResponse ModifyAccountDescriptionSync(ModifyAccountDescriptionRequest req)
        {
            return InternalRequestAsync<ModifyAccountDescriptionResponse>(req, "ModifyAccountDescription")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开启或者关闭接入点外网
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterEndpointWanStatusRequest"/></param>
        /// <returns><see cref="ModifyClusterEndpointWanStatusResponse"/></returns>
        public Task<ModifyClusterEndpointWanStatusResponse> ModifyClusterEndpointWanStatus(ModifyClusterEndpointWanStatusRequest req)
        {
            return InternalRequestAsync<ModifyClusterEndpointWanStatusResponse>(req, "ModifyClusterEndpointWanStatus");
        }

        /// <summary>
        /// 开启或者关闭接入点外网
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterEndpointWanStatusRequest"/></param>
        /// <returns><see cref="ModifyClusterEndpointWanStatusResponse"/></returns>
        public ModifyClusterEndpointWanStatusResponse ModifyClusterEndpointWanStatusSync(ModifyClusterEndpointWanStatusRequest req)
        {
            return InternalRequestAsync<ModifyClusterEndpointWanStatusResponse>(req, "ModifyClusterEndpointWanStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改实例规格，此接口只针对状态为running(运行中)的实例生效
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterInstancesSpecRequest"/></param>
        /// <returns><see cref="ModifyClusterInstancesSpecResponse"/></returns>
        public Task<ModifyClusterInstancesSpecResponse> ModifyClusterInstancesSpec(ModifyClusterInstancesSpecRequest req)
        {
            return InternalRequestAsync<ModifyClusterInstancesSpecResponse>(req, "ModifyClusterInstancesSpec");
        }

        /// <summary>
        /// 修改实例规格，此接口只针对状态为running(运行中)的实例生效
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterInstancesSpecRequest"/></param>
        /// <returns><see cref="ModifyClusterInstancesSpecResponse"/></returns>
        public ModifyClusterInstancesSpecResponse ModifyClusterInstancesSpecSync(ModifyClusterInstancesSpecRequest req)
        {
            return InternalRequestAsync<ModifyClusterInstancesSpecResponse>(req, "ModifyClusterInstancesSpec")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改集群名字
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterNameRequest"/></param>
        /// <returns><see cref="ModifyClusterNameResponse"/></returns>
        public Task<ModifyClusterNameResponse> ModifyClusterName(ModifyClusterNameRequest req)
        {
            return InternalRequestAsync<ModifyClusterNameResponse>(req, "ModifyClusterName");
        }

        /// <summary>
        /// 修改集群名字
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterNameRequest"/></param>
        /// <returns><see cref="ModifyClusterNameResponse"/></returns>
        public ModifyClusterNameResponse ModifyClusterNameSync(ModifyClusterNameRequest req)
        {
            return InternalRequestAsync<ModifyClusterNameResponse>(req, "ModifyClusterName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改集群自动续费，只对预付费集群生效。
        /// </summary>
        /// <param name="req"><see cref="ModifyClustersAutoRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyClustersAutoRenewFlagResponse"/></returns>
        public Task<ModifyClustersAutoRenewFlagResponse> ModifyClustersAutoRenewFlag(ModifyClustersAutoRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyClustersAutoRenewFlagResponse>(req, "ModifyClustersAutoRenewFlag");
        }

        /// <summary>
        /// 修改集群自动续费，只对预付费集群生效。
        /// </summary>
        /// <param name="req"><see cref="ModifyClustersAutoRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyClustersAutoRenewFlagResponse"/></returns>
        public ModifyClustersAutoRenewFlagResponse ModifyClustersAutoRenewFlagSync(ModifyClustersAutoRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyClustersAutoRenewFlagResponse>(req, "ModifyClustersAutoRenewFlag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 恢复集群，恢复集群的接入点网络，恢复后继续连接使用数据库。只有当集群状态处于isolated(已隔离)时才生效。
        /// </summary>
        /// <param name="req"><see cref="RecoverClusterRequest"/></param>
        /// <returns><see cref="RecoverClusterResponse"/></returns>
        public Task<RecoverClusterResponse> RecoverCluster(RecoverClusterRequest req)
        {
            return InternalRequestAsync<RecoverClusterResponse>(req, "RecoverCluster");
        }

        /// <summary>
        /// 恢复集群，恢复集群的接入点网络，恢复后继续连接使用数据库。只有当集群状态处于isolated(已隔离)时才生效。
        /// </summary>
        /// <param name="req"><see cref="RecoverClusterRequest"/></param>
        /// <returns><see cref="RecoverClusterResponse"/></returns>
        public RecoverClusterResponse RecoverClusterSync(RecoverClusterRequest req)
        {
            return InternalRequestAsync<RecoverClusterResponse>(req, "RecoverCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 恢复实例。此接口的使用场景包括：
        ///  - 读写实例状态为running(运行中)时，批量恢复状态为isolated(已隔离)的只读实例
        ///  - 读写实例状态为isolated(已隔离)时，恢复读写实例
        ///  - 读写实例状态为isolated(已隔离)时，批量恢复读写实例以及状态为isolated(已隔离)的只读实例
        /// </summary>
        /// <param name="req"><see cref="RecoverClusterInstancesRequest"/></param>
        /// <returns><see cref="RecoverClusterInstancesResponse"/></returns>
        public Task<RecoverClusterInstancesResponse> RecoverClusterInstances(RecoverClusterInstancesRequest req)
        {
            return InternalRequestAsync<RecoverClusterInstancesResponse>(req, "RecoverClusterInstances");
        }

        /// <summary>
        /// 恢复实例。此接口的使用场景包括：
        ///  - 读写实例状态为running(运行中)时，批量恢复状态为isolated(已隔离)的只读实例
        ///  - 读写实例状态为isolated(已隔离)时，恢复读写实例
        ///  - 读写实例状态为isolated(已隔离)时，批量恢复读写实例以及状态为isolated(已隔离)的只读实例
        /// </summary>
        /// <param name="req"><see cref="RecoverClusterInstancesRequest"/></param>
        /// <returns><see cref="RecoverClusterInstancesResponse"/></returns>
        public RecoverClusterInstancesResponse RecoverClusterInstancesSync(RecoverClusterInstancesRequest req)
        {
            return InternalRequestAsync<RecoverClusterInstancesResponse>(req, "RecoverClusterInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 续费集群
        /// </summary>
        /// <param name="req"><see cref="RenewClusterRequest"/></param>
        /// <returns><see cref="RenewClusterResponse"/></returns>
        public Task<RenewClusterResponse> RenewCluster(RenewClusterRequest req)
        {
            return InternalRequestAsync<RenewClusterResponse>(req, "RenewCluster");
        }

        /// <summary>
        /// 续费集群
        /// </summary>
        /// <param name="req"><see cref="RenewClusterRequest"/></param>
        /// <returns><see cref="RenewClusterResponse"/></returns>
        public RenewClusterResponse RenewClusterSync(RenewClusterRequest req)
        {
            return InternalRequestAsync<RenewClusterResponse>(req, "RenewCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重置数据库账号密码
        /// </summary>
        /// <param name="req"><see cref="ResetAccountPasswordRequest"/></param>
        /// <returns><see cref="ResetAccountPasswordResponse"/></returns>
        public Task<ResetAccountPasswordResponse> ResetAccountPassword(ResetAccountPasswordRequest req)
        {
            return InternalRequestAsync<ResetAccountPasswordResponse>(req, "ResetAccountPassword");
        }

        /// <summary>
        /// 重置数据库账号密码
        /// </summary>
        /// <param name="req"><see cref="ResetAccountPasswordRequest"/></param>
        /// <returns><see cref="ResetAccountPasswordResponse"/></returns>
        public ResetAccountPasswordResponse ResetAccountPasswordSync(ResetAccountPasswordRequest req)
        {
            return InternalRequestAsync<ResetAccountPasswordResponse>(req, "ResetAccountPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重启实例，此接口只针对状态为running(运行中)的实例生效。
        /// </summary>
        /// <param name="req"><see cref="RestartClusterInstancesRequest"/></param>
        /// <returns><see cref="RestartClusterInstancesResponse"/></returns>
        public Task<RestartClusterInstancesResponse> RestartClusterInstances(RestartClusterInstancesRequest req)
        {
            return InternalRequestAsync<RestartClusterInstancesResponse>(req, "RestartClusterInstances");
        }

        /// <summary>
        /// 重启实例，此接口只针对状态为running(运行中)的实例生效。
        /// </summary>
        /// <param name="req"><see cref="RestartClusterInstancesRequest"/></param>
        /// <returns><see cref="RestartClusterInstancesResponse"/></returns>
        public RestartClusterInstancesResponse RestartClusterInstancesSync(RestartClusterInstancesRequest req)
        {
            return InternalRequestAsync<RestartClusterInstancesResponse>(req, "RestartClusterInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 转换集群付费模式，目前只支持从 后付费 转换成 与预付费。
        /// </summary>
        /// <param name="req"><see cref="TransformClusterPayModeRequest"/></param>
        /// <returns><see cref="TransformClusterPayModeResponse"/></returns>
        public Task<TransformClusterPayModeResponse> TransformClusterPayMode(TransformClusterPayModeRequest req)
        {
            return InternalRequestAsync<TransformClusterPayModeResponse>(req, "TransformClusterPayMode");
        }

        /// <summary>
        /// 转换集群付费模式，目前只支持从 后付费 转换成 与预付费。
        /// </summary>
        /// <param name="req"><see cref="TransformClusterPayModeRequest"/></param>
        /// <returns><see cref="TransformClusterPayModeResponse"/></returns>
        public TransformClusterPayModeResponse TransformClusterPayModeSync(TransformClusterPayModeRequest req)
        {
            return InternalRequestAsync<TransformClusterPayModeResponse>(req, "TransformClusterPayMode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}

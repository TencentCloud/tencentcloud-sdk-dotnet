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

namespace TencentCloud.Emr.V20190103
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Emr.V20190103.Models;

   public class EmrClient : AbstractClient{

       private const string endpoint = "emr.tencentcloudapi.com";
       private const string version = "2019-01-03";
       private const string sdkVersion = "SDK_NET_3.0.1156";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public EmrClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public EmrClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 添加扩缩容规则，按负载和时间
        /// </summary>
        /// <param name="req"><see cref="AddMetricScaleStrategyRequest"/></param>
        /// <returns><see cref="AddMetricScaleStrategyResponse"/></returns>
        public Task<AddMetricScaleStrategyResponse> AddMetricScaleStrategy(AddMetricScaleStrategyRequest req)
        {
            return InternalRequestAsync<AddMetricScaleStrategyResponse>(req, "AddMetricScaleStrategy");
        }

        /// <summary>
        /// 添加扩缩容规则，按负载和时间
        /// </summary>
        /// <param name="req"><see cref="AddMetricScaleStrategyRequest"/></param>
        /// <returns><see cref="AddMetricScaleStrategyResponse"/></returns>
        public AddMetricScaleStrategyResponse AddMetricScaleStrategySync(AddMetricScaleStrategyRequest req)
        {
            return InternalRequestAsync<AddMetricScaleStrategyResponse>(req, "AddMetricScaleStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 增加当前集群的节点规格配置
        /// </summary>
        /// <param name="req"><see cref="AddNodeResourceConfigRequest"/></param>
        /// <returns><see cref="AddNodeResourceConfigResponse"/></returns>
        public Task<AddNodeResourceConfigResponse> AddNodeResourceConfig(AddNodeResourceConfigRequest req)
        {
            return InternalRequestAsync<AddNodeResourceConfigResponse>(req, "AddNodeResourceConfig");
        }

        /// <summary>
        /// 增加当前集群的节点规格配置
        /// </summary>
        /// <param name="req"><see cref="AddNodeResourceConfigRequest"/></param>
        /// <returns><see cref="AddNodeResourceConfigResponse"/></returns>
        public AddNodeResourceConfigResponse AddNodeResourceConfigSync(AddNodeResourceConfigRequest req)
        {
            return InternalRequestAsync<AddNodeResourceConfigResponse>(req, "AddNodeResourceConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口支持安装了OpenLdap组件的集群。
        /// 新增用户列表（用户管理）。
        /// </summary>
        /// <param name="req"><see cref="AddUsersForUserManagerRequest"/></param>
        /// <returns><see cref="AddUsersForUserManagerResponse"/></returns>
        public Task<AddUsersForUserManagerResponse> AddUsersForUserManager(AddUsersForUserManagerRequest req)
        {
            return InternalRequestAsync<AddUsersForUserManagerResponse>(req, "AddUsersForUserManager");
        }

        /// <summary>
        /// 该接口支持安装了OpenLdap组件的集群。
        /// 新增用户列表（用户管理）。
        /// </summary>
        /// <param name="req"><see cref="AddUsersForUserManagerRequest"/></param>
        /// <returns><see cref="AddUsersForUserManagerResponse"/></returns>
        public AddUsersForUserManagerResponse AddUsersForUserManagerSync(AddUsersForUserManagerRequest req)
        {
            return InternalRequestAsync<AddUsersForUserManagerResponse>(req, "AddUsersForUserManager")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云盘挂载
        /// </summary>
        /// <param name="req"><see cref="AttachDisksRequest"/></param>
        /// <returns><see cref="AttachDisksResponse"/></returns>
        public Task<AttachDisksResponse> AttachDisks(AttachDisksRequest req)
        {
            return InternalRequestAsync<AttachDisksResponse>(req, "AttachDisks");
        }

        /// <summary>
        /// 云盘挂载
        /// </summary>
        /// <param name="req"><see cref="AttachDisksRequest"/></param>
        /// <returns><see cref="AttachDisksResponse"/></returns>
        public AttachDisksResponse AttachDisksSync(AttachDisksRequest req)
        {
            return InternalRequestAsync<AttachDisksResponse>(req, "AttachDisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建EMR容器集群实例
        /// </summary>
        /// <param name="req"><see cref="CreateCloudInstanceRequest"/></param>
        /// <returns><see cref="CreateCloudInstanceResponse"/></returns>
        public Task<CreateCloudInstanceResponse> CreateCloudInstance(CreateCloudInstanceRequest req)
        {
            return InternalRequestAsync<CreateCloudInstanceResponse>(req, "CreateCloudInstance");
        }

        /// <summary>
        /// 创建EMR容器集群实例
        /// </summary>
        /// <param name="req"><see cref="CreateCloudInstanceRequest"/></param>
        /// <returns><see cref="CreateCloudInstanceResponse"/></returns>
        public CreateCloudInstanceResponse CreateCloudInstanceSync(CreateCloudInstanceRequest req)
        {
            return InternalRequestAsync<CreateCloudInstanceResponse>(req, "CreateCloudInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建EMR集群实例
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRequest"/></param>
        /// <returns><see cref="CreateClusterResponse"/></returns>
        public Task<CreateClusterResponse> CreateCluster(CreateClusterRequest req)
        {
            return InternalRequestAsync<CreateClusterResponse>(req, "CreateCluster");
        }

        /// <summary>
        /// 创建EMR集群实例
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRequest"/></param>
        /// <returns><see cref="CreateClusterResponse"/></returns>
        public CreateClusterResponse CreateClusterSync(CreateClusterRequest req)
        {
            return InternalRequestAsync<CreateClusterResponse>(req, "CreateCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建EMR集群实例
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceRequest"/></param>
        /// <returns><see cref="CreateInstanceResponse"/></returns>
        public Task<CreateInstanceResponse> CreateInstance(CreateInstanceRequest req)
        {
            return InternalRequestAsync<CreateInstanceResponse>(req, "CreateInstance");
        }

        /// <summary>
        /// 创建EMR集群实例
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceRequest"/></param>
        /// <returns><see cref="CreateInstanceResponse"/></returns>
        public CreateInstanceResponse CreateInstanceSync(CreateInstanceRequest req)
        {
            return InternalRequestAsync<CreateInstanceResponse>(req, "CreateInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateSLInstance）用于创建Serverless HBase实例
        /// - 接口调用成功，会创建Serverless HBase实例，创建实例请求成功会返回创建实例的InstaceId和请求的 RequestID。
        /// - 接口为异步接口，接口返回时操作并未立即完成，实例操作结果可以通过调用DescribeInstancesList查看当前实例的StatusDesc状态。
        /// </summary>
        /// <param name="req"><see cref="CreateSLInstanceRequest"/></param>
        /// <returns><see cref="CreateSLInstanceResponse"/></returns>
        public Task<CreateSLInstanceResponse> CreateSLInstance(CreateSLInstanceRequest req)
        {
            return InternalRequestAsync<CreateSLInstanceResponse>(req, "CreateSLInstance");
        }

        /// <summary>
        /// 本接口（CreateSLInstance）用于创建Serverless HBase实例
        /// - 接口调用成功，会创建Serverless HBase实例，创建实例请求成功会返回创建实例的InstaceId和请求的 RequestID。
        /// - 接口为异步接口，接口返回时操作并未立即完成，实例操作结果可以通过调用DescribeInstancesList查看当前实例的StatusDesc状态。
        /// </summary>
        /// <param name="req"><see cref="CreateSLInstanceRequest"/></param>
        /// <returns><see cref="CreateSLInstanceResponse"/></returns>
        public CreateSLInstanceResponse CreateSLInstanceSync(CreateSLInstanceRequest req)
        {
            return InternalRequestAsync<CreateSLInstanceResponse>(req, "CreateSLInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除自动扩缩容规则，后台销毁根据该规则扩缩容出来的节点
        /// </summary>
        /// <param name="req"><see cref="DeleteAutoScaleStrategyRequest"/></param>
        /// <returns><see cref="DeleteAutoScaleStrategyResponse"/></returns>
        public Task<DeleteAutoScaleStrategyResponse> DeleteAutoScaleStrategy(DeleteAutoScaleStrategyRequest req)
        {
            return InternalRequestAsync<DeleteAutoScaleStrategyResponse>(req, "DeleteAutoScaleStrategy");
        }

        /// <summary>
        /// 删除自动扩缩容规则，后台销毁根据该规则扩缩容出来的节点
        /// </summary>
        /// <param name="req"><see cref="DeleteAutoScaleStrategyRequest"/></param>
        /// <returns><see cref="DeleteAutoScaleStrategyResponse"/></returns>
        public DeleteAutoScaleStrategyResponse DeleteAutoScaleStrategySync(DeleteAutoScaleStrategyRequest req)
        {
            return InternalRequestAsync<DeleteAutoScaleStrategyResponse>(req, "DeleteAutoScaleStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除当前集群的节点规格配置
        /// </summary>
        /// <param name="req"><see cref="DeleteNodeResourceConfigRequest"/></param>
        /// <returns><see cref="DeleteNodeResourceConfigResponse"/></returns>
        public Task<DeleteNodeResourceConfigResponse> DeleteNodeResourceConfig(DeleteNodeResourceConfigRequest req)
        {
            return InternalRequestAsync<DeleteNodeResourceConfigResponse>(req, "DeleteNodeResourceConfig");
        }

        /// <summary>
        /// 删除当前集群的节点规格配置
        /// </summary>
        /// <param name="req"><see cref="DeleteNodeResourceConfigRequest"/></param>
        /// <returns><see cref="DeleteNodeResourceConfigResponse"/></returns>
        public DeleteNodeResourceConfigResponse DeleteNodeResourceConfigSync(DeleteNodeResourceConfigRequest req)
        {
            return InternalRequestAsync<DeleteNodeResourceConfigResponse>(req, "DeleteNodeResourceConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除用户列表（用户管理）
        /// </summary>
        /// <param name="req"><see cref="DeleteUserManagerUserListRequest"/></param>
        /// <returns><see cref="DeleteUserManagerUserListResponse"/></returns>
        public Task<DeleteUserManagerUserListResponse> DeleteUserManagerUserList(DeleteUserManagerUserListRequest req)
        {
            return InternalRequestAsync<DeleteUserManagerUserListResponse>(req, "DeleteUserManagerUserList");
        }

        /// <summary>
        /// 删除用户列表（用户管理）
        /// </summary>
        /// <param name="req"><see cref="DeleteUserManagerUserListRequest"/></param>
        /// <returns><see cref="DeleteUserManagerUserListResponse"/></returns>
        public DeleteUserManagerUserListResponse DeleteUserManagerUserListSync(DeleteUserManagerUserListRequest req)
        {
            return InternalRequestAsync<DeleteUserManagerUserListResponse>(req, "DeleteUserManagerUserList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// yarn资源调度-部署生效
        /// </summary>
        /// <param name="req"><see cref="DeployYarnConfRequest"/></param>
        /// <returns><see cref="DeployYarnConfResponse"/></returns>
        public Task<DeployYarnConfResponse> DeployYarnConf(DeployYarnConfRequest req)
        {
            return InternalRequestAsync<DeployYarnConfResponse>(req, "DeployYarnConf");
        }

        /// <summary>
        /// yarn资源调度-部署生效
        /// </summary>
        /// <param name="req"><see cref="DeployYarnConfRequest"/></param>
        /// <returns><see cref="DeployYarnConfResponse"/></returns>
        public DeployYarnConfResponse DeployYarnConfSync(DeployYarnConfRequest req)
        {
            return InternalRequestAsync<DeployYarnConfResponse>(req, "DeployYarnConf")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取自动扩缩容全局配置
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScaleGroupGlobalConfRequest"/></param>
        /// <returns><see cref="DescribeAutoScaleGroupGlobalConfResponse"/></returns>
        public Task<DescribeAutoScaleGroupGlobalConfResponse> DescribeAutoScaleGroupGlobalConf(DescribeAutoScaleGroupGlobalConfRequest req)
        {
            return InternalRequestAsync<DescribeAutoScaleGroupGlobalConfResponse>(req, "DescribeAutoScaleGroupGlobalConf");
        }

        /// <summary>
        /// 获取自动扩缩容全局配置
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScaleGroupGlobalConfRequest"/></param>
        /// <returns><see cref="DescribeAutoScaleGroupGlobalConfResponse"/></returns>
        public DescribeAutoScaleGroupGlobalConfResponse DescribeAutoScaleGroupGlobalConfSync(DescribeAutoScaleGroupGlobalConfRequest req)
        {
            return InternalRequestAsync<DescribeAutoScaleGroupGlobalConfResponse>(req, "DescribeAutoScaleGroupGlobalConf")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取集群的自动扩缩容的详细记录
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScaleRecordsRequest"/></param>
        /// <returns><see cref="DescribeAutoScaleRecordsResponse"/></returns>
        public Task<DescribeAutoScaleRecordsResponse> DescribeAutoScaleRecords(DescribeAutoScaleRecordsRequest req)
        {
            return InternalRequestAsync<DescribeAutoScaleRecordsResponse>(req, "DescribeAutoScaleRecords");
        }

        /// <summary>
        /// 获取集群的自动扩缩容的详细记录
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScaleRecordsRequest"/></param>
        /// <returns><see cref="DescribeAutoScaleRecordsResponse"/></returns>
        public DescribeAutoScaleRecordsResponse DescribeAutoScaleRecordsSync(DescribeAutoScaleRecordsRequest req)
        {
            return InternalRequestAsync<DescribeAutoScaleRecordsResponse>(req, "DescribeAutoScaleRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取自动扩缩容规则
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScaleStrategiesRequest"/></param>
        /// <returns><see cref="DescribeAutoScaleStrategiesResponse"/></returns>
        public Task<DescribeAutoScaleStrategiesResponse> DescribeAutoScaleStrategies(DescribeAutoScaleStrategiesRequest req)
        {
            return InternalRequestAsync<DescribeAutoScaleStrategiesResponse>(req, "DescribeAutoScaleStrategies");
        }

        /// <summary>
        /// 获取自动扩缩容规则
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScaleStrategiesRequest"/></param>
        /// <returns><see cref="DescribeAutoScaleStrategiesResponse"/></returns>
        public DescribeAutoScaleStrategiesResponse DescribeAutoScaleStrategiesSync(DescribeAutoScaleStrategiesRequest req)
        {
            return InternalRequestAsync<DescribeAutoScaleStrategiesResponse>(req, "DescribeAutoScaleStrategies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询EMR任务运行详情状态
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterFlowStatusDetailRequest"/></param>
        /// <returns><see cref="DescribeClusterFlowStatusDetailResponse"/></returns>
        public Task<DescribeClusterFlowStatusDetailResponse> DescribeClusterFlowStatusDetail(DescribeClusterFlowStatusDetailRequest req)
        {
            return InternalRequestAsync<DescribeClusterFlowStatusDetailResponse>(req, "DescribeClusterFlowStatusDetail");
        }

        /// <summary>
        /// 查询EMR任务运行详情状态
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterFlowStatusDetailRequest"/></param>
        /// <returns><see cref="DescribeClusterFlowStatusDetailResponse"/></returns>
        public DescribeClusterFlowStatusDetailResponse DescribeClusterFlowStatusDetailSync(DescribeClusterFlowStatusDetailRequest req)
        {
            return InternalRequestAsync<DescribeClusterFlowStatusDetailResponse>(req, "DescribeClusterFlowStatusDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集群节点信息
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterNodesRequest"/></param>
        /// <returns><see cref="DescribeClusterNodesResponse"/></returns>
        public Task<DescribeClusterNodesResponse> DescribeClusterNodes(DescribeClusterNodesRequest req)
        {
            return InternalRequestAsync<DescribeClusterNodesResponse>(req, "DescribeClusterNodes");
        }

        /// <summary>
        /// 查询集群节点信息
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterNodesRequest"/></param>
        /// <returns><see cref="DescribeClusterNodesResponse"/></returns>
        public DescribeClusterNodesResponse DescribeClusterNodesSync(DescribeClusterNodesRequest req)
        {
            return InternalRequestAsync<DescribeClusterNodesResponse>(req, "DescribeClusterNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取账户的CVM配额
        /// </summary>
        /// <param name="req"><see cref="DescribeCvmQuotaRequest"/></param>
        /// <returns><see cref="DescribeCvmQuotaResponse"/></returns>
        public Task<DescribeCvmQuotaResponse> DescribeCvmQuota(DescribeCvmQuotaRequest req)
        {
            return InternalRequestAsync<DescribeCvmQuotaResponse>(req, "DescribeCvmQuota");
        }

        /// <summary>
        /// 获取账户的CVM配额
        /// </summary>
        /// <param name="req"><see cref="DescribeCvmQuotaRequest"/></param>
        /// <returns><see cref="DescribeCvmQuotaResponse"/></returns>
        public DescribeCvmQuotaResponse DescribeCvmQuotaSync(DescribeCvmQuotaRequest req)
        {
            return InternalRequestAsync<DescribeCvmQuotaResponse>(req, "DescribeCvmQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// yarn application 统计接口查询
        /// </summary>
        /// <param name="req"><see cref="DescribeEmrApplicationStaticsRequest"/></param>
        /// <returns><see cref="DescribeEmrApplicationStaticsResponse"/></returns>
        public Task<DescribeEmrApplicationStaticsResponse> DescribeEmrApplicationStatics(DescribeEmrApplicationStaticsRequest req)
        {
            return InternalRequestAsync<DescribeEmrApplicationStaticsResponse>(req, "DescribeEmrApplicationStatics");
        }

        /// <summary>
        /// yarn application 统计接口查询
        /// </summary>
        /// <param name="req"><see cref="DescribeEmrApplicationStaticsRequest"/></param>
        /// <returns><see cref="DescribeEmrApplicationStaticsResponse"/></returns>
        public DescribeEmrApplicationStaticsResponse DescribeEmrApplicationStaticsSync(DescribeEmrApplicationStaticsRequest req)
        {
            return InternalRequestAsync<DescribeEmrApplicationStaticsResponse>(req, "DescribeEmrApplicationStatics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询监控概览页指标数据
        /// </summary>
        /// <param name="req"><see cref="DescribeEmrOverviewMetricsRequest"/></param>
        /// <returns><see cref="DescribeEmrOverviewMetricsResponse"/></returns>
        public Task<DescribeEmrOverviewMetricsResponse> DescribeEmrOverviewMetrics(DescribeEmrOverviewMetricsRequest req)
        {
            return InternalRequestAsync<DescribeEmrOverviewMetricsResponse>(req, "DescribeEmrOverviewMetrics");
        }

        /// <summary>
        /// 查询监控概览页指标数据
        /// </summary>
        /// <param name="req"><see cref="DescribeEmrOverviewMetricsRequest"/></param>
        /// <returns><see cref="DescribeEmrOverviewMetricsResponse"/></returns>
        public DescribeEmrOverviewMetricsResponse DescribeEmrOverviewMetricsSync(DescribeEmrOverviewMetricsRequest req)
        {
            return InternalRequestAsync<DescribeEmrOverviewMetricsResponse>(req, "DescribeEmrOverviewMetrics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询YARN资源调度的全局配置
        /// </summary>
        /// <param name="req"><see cref="DescribeGlobalConfigRequest"/></param>
        /// <returns><see cref="DescribeGlobalConfigResponse"/></returns>
        public Task<DescribeGlobalConfigResponse> DescribeGlobalConfig(DescribeGlobalConfigRequest req)
        {
            return InternalRequestAsync<DescribeGlobalConfigResponse>(req, "DescribeGlobalConfig");
        }

        /// <summary>
        /// 查询YARN资源调度的全局配置
        /// </summary>
        /// <param name="req"><see cref="DescribeGlobalConfigRequest"/></param>
        /// <returns><see cref="DescribeGlobalConfigResponse"/></returns>
        public DescribeGlobalConfigResponse DescribeGlobalConfigSync(DescribeGlobalConfigRequest req)
        {
            return InternalRequestAsync<DescribeGlobalConfigResponse>(req, "DescribeGlobalConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取Hbase表级监控数据概览接口
        /// </summary>
        /// <param name="req"><see cref="DescribeHBaseTableOverviewRequest"/></param>
        /// <returns><see cref="DescribeHBaseTableOverviewResponse"/></returns>
        public Task<DescribeHBaseTableOverviewResponse> DescribeHBaseTableOverview(DescribeHBaseTableOverviewRequest req)
        {
            return InternalRequestAsync<DescribeHBaseTableOverviewResponse>(req, "DescribeHBaseTableOverview");
        }

        /// <summary>
        /// 获取Hbase表级监控数据概览接口
        /// </summary>
        /// <param name="req"><see cref="DescribeHBaseTableOverviewRequest"/></param>
        /// <returns><see cref="DescribeHBaseTableOverviewResponse"/></returns>
        public DescribeHBaseTableOverviewResponse DescribeHBaseTableOverviewSync(DescribeHBaseTableOverviewRequest req)
        {
            return InternalRequestAsync<DescribeHBaseTableOverviewResponse>(req, "DescribeHBaseTableOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询HDFS存储文件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeHDFSStorageInfoRequest"/></param>
        /// <returns><see cref="DescribeHDFSStorageInfoResponse"/></returns>
        public Task<DescribeHDFSStorageInfoResponse> DescribeHDFSStorageInfo(DescribeHDFSStorageInfoRequest req)
        {
            return InternalRequestAsync<DescribeHDFSStorageInfoResponse>(req, "DescribeHDFSStorageInfo");
        }

        /// <summary>
        /// 查询HDFS存储文件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeHDFSStorageInfoRequest"/></param>
        /// <returns><see cref="DescribeHDFSStorageInfoResponse"/></returns>
        public DescribeHDFSStorageInfoResponse DescribeHDFSStorageInfoSync(DescribeHDFSStorageInfoRequest req)
        {
            return InternalRequestAsync<DescribeHDFSStorageInfoResponse>(req, "DescribeHDFSStorageInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取hive查询信息
        /// </summary>
        /// <param name="req"><see cref="DescribeHiveQueriesRequest"/></param>
        /// <returns><see cref="DescribeHiveQueriesResponse"/></returns>
        public Task<DescribeHiveQueriesResponse> DescribeHiveQueries(DescribeHiveQueriesRequest req)
        {
            return InternalRequestAsync<DescribeHiveQueriesResponse>(req, "DescribeHiveQueries");
        }

        /// <summary>
        /// 获取hive查询信息
        /// </summary>
        /// <param name="req"><see cref="DescribeHiveQueriesRequest"/></param>
        /// <returns><see cref="DescribeHiveQueriesResponse"/></returns>
        public DescribeHiveQueriesResponse DescribeHiveQueriesSync(DescribeHiveQueriesRequest req)
        {
            return InternalRequestAsync<DescribeHiveQueriesResponse>(req, "DescribeHiveQueries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeImpalaQueries
        /// </summary>
        /// <param name="req"><see cref="DescribeImpalaQueriesRequest"/></param>
        /// <returns><see cref="DescribeImpalaQueriesResponse"/></returns>
        public Task<DescribeImpalaQueriesResponse> DescribeImpalaQueries(DescribeImpalaQueriesRequest req)
        {
            return InternalRequestAsync<DescribeImpalaQueriesResponse>(req, "DescribeImpalaQueries");
        }

        /// <summary>
        /// DescribeImpalaQueries
        /// </summary>
        /// <param name="req"><see cref="DescribeImpalaQueriesRequest"/></param>
        /// <returns><see cref="DescribeImpalaQueriesResponse"/></returns>
        public DescribeImpalaQueriesResponse DescribeImpalaQueriesSync(DescribeImpalaQueriesRequest req)
        {
            return InternalRequestAsync<DescribeImpalaQueriesResponse>(req, "DescribeImpalaQueries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取洞察结果信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInsightListRequest"/></param>
        /// <returns><see cref="DescribeInsightListResponse"/></returns>
        public Task<DescribeInsightListResponse> DescribeInsightList(DescribeInsightListRequest req)
        {
            return InternalRequestAsync<DescribeInsightListResponse>(req, "DescribeInsightList");
        }

        /// <summary>
        /// 获取洞察结果信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInsightListRequest"/></param>
        /// <returns><see cref="DescribeInsightListResponse"/></returns>
        public DescribeInsightListResponse DescribeInsightListSync(DescribeInsightListRequest req)
        {
            return InternalRequestAsync<DescribeInsightListResponse>(req, "DescribeInsightList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询待续费节点信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceRenewNodesRequest"/></param>
        /// <returns><see cref="DescribeInstanceRenewNodesResponse"/></returns>
        public Task<DescribeInstanceRenewNodesResponse> DescribeInstanceRenewNodes(DescribeInstanceRenewNodesRequest req)
        {
            return InternalRequestAsync<DescribeInstanceRenewNodesResponse>(req, "DescribeInstanceRenewNodes");
        }

        /// <summary>
        /// 查询待续费节点信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceRenewNodesRequest"/></param>
        /// <returns><see cref="DescribeInstanceRenewNodesResponse"/></returns>
        public DescribeInstanceRenewNodesResponse DescribeInstanceRenewNodesSync(DescribeInstanceRenewNodesRequest req)
        {
            return InternalRequestAsync<DescribeInstanceRenewNodesResponse>(req, "DescribeInstanceRenewNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集群实例信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances");
        }

        /// <summary>
        /// 查询集群实例信息
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesListRequest"/></param>
        /// <returns><see cref="DescribeInstancesListResponse"/></returns>
        public Task<DescribeInstancesListResponse> DescribeInstancesList(DescribeInstancesListRequest req)
        {
            return InternalRequestAsync<DescribeInstancesListResponse>(req, "DescribeInstancesList");
        }

        /// <summary>
        /// 查询集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesListRequest"/></param>
        /// <returns><see cref="DescribeInstancesListResponse"/></returns>
        public DescribeInstancesListResponse DescribeInstancesListSync(DescribeInstancesListRequest req)
        {
            return InternalRequestAsync<DescribeInstancesListResponse>(req, "DescribeInstancesList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询流程任务
        /// </summary>
        /// <param name="req"><see cref="DescribeJobFlowRequest"/></param>
        /// <returns><see cref="DescribeJobFlowResponse"/></returns>
        public Task<DescribeJobFlowResponse> DescribeJobFlow(DescribeJobFlowRequest req)
        {
            return InternalRequestAsync<DescribeJobFlowResponse>(req, "DescribeJobFlow");
        }

        /// <summary>
        /// 查询流程任务
        /// </summary>
        /// <param name="req"><see cref="DescribeJobFlowRequest"/></param>
        /// <returns><see cref="DescribeJobFlowResponse"/></returns>
        public DescribeJobFlowResponse DescribeJobFlowSync(DescribeJobFlowRequest req)
        {
            return InternalRequestAsync<DescribeJobFlowResponse>(req, "DescribeJobFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Kyuubi查询信息
        /// </summary>
        /// <param name="req"><see cref="DescribeKyuubiQueryInfoRequest"/></param>
        /// <returns><see cref="DescribeKyuubiQueryInfoResponse"/></returns>
        public Task<DescribeKyuubiQueryInfoResponse> DescribeKyuubiQueryInfo(DescribeKyuubiQueryInfoRequest req)
        {
            return InternalRequestAsync<DescribeKyuubiQueryInfoResponse>(req, "DescribeKyuubiQueryInfo");
        }

        /// <summary>
        /// 查询Kyuubi查询信息
        /// </summary>
        /// <param name="req"><see cref="DescribeKyuubiQueryInfoRequest"/></param>
        /// <returns><see cref="DescribeKyuubiQueryInfoResponse"/></returns>
        public DescribeKyuubiQueryInfoResponse DescribeKyuubiQueryInfoSync(DescribeKyuubiQueryInfoRequest req)
        {
            return InternalRequestAsync<DescribeKyuubiQueryInfoResponse>(req, "DescribeKyuubiQueryInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询节点数据盘信息
        /// </summary>
        /// <param name="req"><see cref="DescribeNodeDataDisksRequest"/></param>
        /// <returns><see cref="DescribeNodeDataDisksResponse"/></returns>
        public Task<DescribeNodeDataDisksResponse> DescribeNodeDataDisks(DescribeNodeDataDisksRequest req)
        {
            return InternalRequestAsync<DescribeNodeDataDisksResponse>(req, "DescribeNodeDataDisks");
        }

        /// <summary>
        /// 查询节点数据盘信息
        /// </summary>
        /// <param name="req"><see cref="DescribeNodeDataDisksRequest"/></param>
        /// <returns><see cref="DescribeNodeDataDisksResponse"/></returns>
        public DescribeNodeDataDisksResponse DescribeNodeDataDisksSync(DescribeNodeDataDisksRequest req)
        {
            return InternalRequestAsync<DescribeNodeDataDisksResponse>(req, "DescribeNodeDataDisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 快速获取当前集群的节点规格配置
        /// </summary>
        /// <param name="req"><see cref="DescribeNodeResourceConfigFastRequest"/></param>
        /// <returns><see cref="DescribeNodeResourceConfigFastResponse"/></returns>
        public Task<DescribeNodeResourceConfigFastResponse> DescribeNodeResourceConfigFast(DescribeNodeResourceConfigFastRequest req)
        {
            return InternalRequestAsync<DescribeNodeResourceConfigFastResponse>(req, "DescribeNodeResourceConfigFast");
        }

        /// <summary>
        /// 快速获取当前集群的节点规格配置
        /// </summary>
        /// <param name="req"><see cref="DescribeNodeResourceConfigFastRequest"/></param>
        /// <returns><see cref="DescribeNodeResourceConfigFastResponse"/></returns>
        public DescribeNodeResourceConfigFastResponse DescribeNodeResourceConfigFastSync(DescribeNodeResourceConfigFastRequest req)
        {
            return InternalRequestAsync<DescribeNodeResourceConfigFastResponse>(req, "DescribeNodeResourceConfigFast")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询YARN资源调度数据信息。已废弃，请使用`DescribeYarnQueue`去查询队列信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceScheduleRequest"/></param>
        /// <returns><see cref="DescribeResourceScheduleResponse"/></returns>
        public Task<DescribeResourceScheduleResponse> DescribeResourceSchedule(DescribeResourceScheduleRequest req)
        {
            return InternalRequestAsync<DescribeResourceScheduleResponse>(req, "DescribeResourceSchedule");
        }

        /// <summary>
        /// 查询YARN资源调度数据信息。已废弃，请使用`DescribeYarnQueue`去查询队列信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceScheduleRequest"/></param>
        /// <returns><see cref="DescribeResourceScheduleResponse"/></returns>
        public DescribeResourceScheduleResponse DescribeResourceScheduleSync(DescribeResourceScheduleRequest req)
        {
            return InternalRequestAsync<DescribeResourceScheduleResponse>(req, "DescribeResourceSchedule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// YARN资源调度-变更详情
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceScheduleDiffDetailRequest"/></param>
        /// <returns><see cref="DescribeResourceScheduleDiffDetailResponse"/></returns>
        public Task<DescribeResourceScheduleDiffDetailResponse> DescribeResourceScheduleDiffDetail(DescribeResourceScheduleDiffDetailRequest req)
        {
            return InternalRequestAsync<DescribeResourceScheduleDiffDetailResponse>(req, "DescribeResourceScheduleDiffDetail");
        }

        /// <summary>
        /// YARN资源调度-变更详情
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceScheduleDiffDetailRequest"/></param>
        /// <returns><see cref="DescribeResourceScheduleDiffDetailResponse"/></returns>
        public DescribeResourceScheduleDiffDetailResponse DescribeResourceScheduleDiffDetailSync(DescribeResourceScheduleDiffDetailRequest req)
        {
            return InternalRequestAsync<DescribeResourceScheduleDiffDetailResponse>(req, "DescribeResourceScheduleDiffDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeSLInstance）用于查询 Serverless HBase实例基本信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSLInstanceRequest"/></param>
        /// <returns><see cref="DescribeSLInstanceResponse"/></returns>
        public Task<DescribeSLInstanceResponse> DescribeSLInstance(DescribeSLInstanceRequest req)
        {
            return InternalRequestAsync<DescribeSLInstanceResponse>(req, "DescribeSLInstance");
        }

        /// <summary>
        /// 本接口（DescribeSLInstance）用于查询 Serverless HBase实例基本信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSLInstanceRequest"/></param>
        /// <returns><see cref="DescribeSLInstanceResponse"/></returns>
        public DescribeSLInstanceResponse DescribeSLInstanceSync(DescribeSLInstanceRequest req)
        {
            return InternalRequestAsync<DescribeSLInstanceResponse>(req, "DescribeSLInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeSLInstanceList）用于查询Serverless HBase实例列表详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSLInstanceListRequest"/></param>
        /// <returns><see cref="DescribeSLInstanceListResponse"/></returns>
        public Task<DescribeSLInstanceListResponse> DescribeSLInstanceList(DescribeSLInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeSLInstanceListResponse>(req, "DescribeSLInstanceList");
        }

        /// <summary>
        /// 本接口（DescribeSLInstanceList）用于查询Serverless HBase实例列表详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSLInstanceListRequest"/></param>
        /// <returns><see cref="DescribeSLInstanceListResponse"/></returns>
        public DescribeSLInstanceListResponse DescribeSLInstanceListSync(DescribeSLInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeSLInstanceListResponse>(req, "DescribeSLInstanceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询服务进程信息
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceNodeInfosRequest"/></param>
        /// <returns><see cref="DescribeServiceNodeInfosResponse"/></returns>
        public Task<DescribeServiceNodeInfosResponse> DescribeServiceNodeInfos(DescribeServiceNodeInfosRequest req)
        {
            return InternalRequestAsync<DescribeServiceNodeInfosResponse>(req, "DescribeServiceNodeInfos");
        }

        /// <summary>
        /// 查询服务进程信息
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceNodeInfosRequest"/></param>
        /// <returns><see cref="DescribeServiceNodeInfosResponse"/></returns>
        public DescribeServiceNodeInfosResponse DescribeServiceNodeInfosSync(DescribeServiceNodeInfosRequest req)
        {
            return InternalRequestAsync<DescribeServiceNodeInfosResponse>(req, "DescribeServiceNodeInfos")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Spark查询信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkQueriesRequest"/></param>
        /// <returns><see cref="DescribeSparkQueriesResponse"/></returns>
        public Task<DescribeSparkQueriesResponse> DescribeSparkQueries(DescribeSparkQueriesRequest req)
        {
            return InternalRequestAsync<DescribeSparkQueriesResponse>(req, "DescribeSparkQueries");
        }

        /// <summary>
        /// 查询Spark查询信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkQueriesRequest"/></param>
        /// <returns><see cref="DescribeSparkQueriesResponse"/></returns>
        public DescribeSparkQueriesResponse DescribeSparkQueriesSync(DescribeSparkQueriesRequest req)
        {
            return InternalRequestAsync<DescribeSparkQueriesResponse>(req, "DescribeSparkQueries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询StarRocks查询信息
        /// </summary>
        /// <param name="req"><see cref="DescribeStarRocksQueryInfoRequest"/></param>
        /// <returns><see cref="DescribeStarRocksQueryInfoResponse"/></returns>
        public Task<DescribeStarRocksQueryInfoResponse> DescribeStarRocksQueryInfo(DescribeStarRocksQueryInfoRequest req)
        {
            return InternalRequestAsync<DescribeStarRocksQueryInfoResponse>(req, "DescribeStarRocksQueryInfo");
        }

        /// <summary>
        /// 查询StarRocks查询信息
        /// </summary>
        /// <param name="req"><see cref="DescribeStarRocksQueryInfoRequest"/></param>
        /// <returns><see cref="DescribeStarRocksQueryInfoResponse"/></returns>
        public DescribeStarRocksQueryInfoResponse DescribeStarRocksQueryInfoSync(DescribeStarRocksQueryInfoRequest req)
        {
            return InternalRequestAsync<DescribeStarRocksQueryInfoResponse>(req, "DescribeStarRocksQueryInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Trino(PrestoSQL)查询信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTrinoQueryInfoRequest"/></param>
        /// <returns><see cref="DescribeTrinoQueryInfoResponse"/></returns>
        public Task<DescribeTrinoQueryInfoResponse> DescribeTrinoQueryInfo(DescribeTrinoQueryInfoRequest req)
        {
            return InternalRequestAsync<DescribeTrinoQueryInfoResponse>(req, "DescribeTrinoQueryInfo");
        }

        /// <summary>
        /// 查询Trino(PrestoSQL)查询信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTrinoQueryInfoRequest"/></param>
        /// <returns><see cref="DescribeTrinoQueryInfoResponse"/></returns>
        public DescribeTrinoQueryInfoResponse DescribeTrinoQueryInfoSync(DescribeTrinoQueryInfoRequest req)
        {
            return InternalRequestAsync<DescribeTrinoQueryInfoResponse>(req, "DescribeTrinoQueryInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口支持安装了OpenLdap组件的集群。
        /// 批量导出用户。对于kerberos集群，如果需要kertab文件下载地址，可以将NeedKeytabInfo设置为true；注意SupportDownLoadKeyTab为true，但是DownLoadKeyTabUrl为空字符串，表示keytab文件在后台没有准备好（正在生成）。
        /// </summary>
        /// <param name="req"><see cref="DescribeUsersForUserManagerRequest"/></param>
        /// <returns><see cref="DescribeUsersForUserManagerResponse"/></returns>
        public Task<DescribeUsersForUserManagerResponse> DescribeUsersForUserManager(DescribeUsersForUserManagerRequest req)
        {
            return InternalRequestAsync<DescribeUsersForUserManagerResponse>(req, "DescribeUsersForUserManager");
        }

        /// <summary>
        /// 该接口支持安装了OpenLdap组件的集群。
        /// 批量导出用户。对于kerberos集群，如果需要kertab文件下载地址，可以将NeedKeytabInfo设置为true；注意SupportDownLoadKeyTab为true，但是DownLoadKeyTabUrl为空字符串，表示keytab文件在后台没有准备好（正在生成）。
        /// </summary>
        /// <param name="req"><see cref="DescribeUsersForUserManagerRequest"/></param>
        /// <returns><see cref="DescribeUsersForUserManagerResponse"/></returns>
        public DescribeUsersForUserManagerResponse DescribeUsersForUserManagerSync(DescribeUsersForUserManagerRequest req)
        {
            return InternalRequestAsync<DescribeUsersForUserManagerResponse>(req, "DescribeUsersForUserManager")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeYarnApplications
        /// </summary>
        /// <param name="req"><see cref="DescribeYarnApplicationsRequest"/></param>
        /// <returns><see cref="DescribeYarnApplicationsResponse"/></returns>
        public Task<DescribeYarnApplicationsResponse> DescribeYarnApplications(DescribeYarnApplicationsRequest req)
        {
            return InternalRequestAsync<DescribeYarnApplicationsResponse>(req, "DescribeYarnApplications");
        }

        /// <summary>
        /// DescribeYarnApplications
        /// </summary>
        /// <param name="req"><see cref="DescribeYarnApplicationsRequest"/></param>
        /// <returns><see cref="DescribeYarnApplicationsResponse"/></returns>
        public DescribeYarnApplicationsResponse DescribeYarnApplicationsSync(DescribeYarnApplicationsRequest req)
        {
            return InternalRequestAsync<DescribeYarnApplicationsResponse>(req, "DescribeYarnApplications")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取资源调度中的队列信息
        /// </summary>
        /// <param name="req"><see cref="DescribeYarnQueueRequest"/></param>
        /// <returns><see cref="DescribeYarnQueueResponse"/></returns>
        public Task<DescribeYarnQueueResponse> DescribeYarnQueue(DescribeYarnQueueRequest req)
        {
            return InternalRequestAsync<DescribeYarnQueueResponse>(req, "DescribeYarnQueue");
        }

        /// <summary>
        /// 获取资源调度中的队列信息
        /// </summary>
        /// <param name="req"><see cref="DescribeYarnQueueRequest"/></param>
        /// <returns><see cref="DescribeYarnQueueResponse"/></returns>
        public DescribeYarnQueueResponse DescribeYarnQueueSync(DescribeYarnQueueRequest req)
        {
            return InternalRequestAsync<DescribeYarnQueueResponse>(req, "DescribeYarnQueue")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看yarn资源调度的调度历史。废弃，请使用流程中心查看历史记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeYarnScheduleHistoryRequest"/></param>
        /// <returns><see cref="DescribeYarnScheduleHistoryResponse"/></returns>
        public Task<DescribeYarnScheduleHistoryResponse> DescribeYarnScheduleHistory(DescribeYarnScheduleHistoryRequest req)
        {
            return InternalRequestAsync<DescribeYarnScheduleHistoryResponse>(req, "DescribeYarnScheduleHistory");
        }

        /// <summary>
        /// 查看yarn资源调度的调度历史。废弃，请使用流程中心查看历史记录。
        /// </summary>
        /// <param name="req"><see cref="DescribeYarnScheduleHistoryRequest"/></param>
        /// <returns><see cref="DescribeYarnScheduleHistoryResponse"/></returns>
        public DescribeYarnScheduleHistoryResponse DescribeYarnScheduleHistorySync(DescribeYarnScheduleHistoryRequest req)
        {
            return InternalRequestAsync<DescribeYarnScheduleHistoryResponse>(req, "DescribeYarnScheduleHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 集群续费询价。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceRenewEmrRequest"/></param>
        /// <returns><see cref="InquirePriceRenewEmrResponse"/></returns>
        public Task<InquirePriceRenewEmrResponse> InquirePriceRenewEmr(InquirePriceRenewEmrRequest req)
        {
            return InternalRequestAsync<InquirePriceRenewEmrResponse>(req, "InquirePriceRenewEmr");
        }

        /// <summary>
        /// 集群续费询价。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceRenewEmrRequest"/></param>
        /// <returns><see cref="InquirePriceRenewEmrResponse"/></returns>
        public InquirePriceRenewEmrResponse InquirePriceRenewEmrSync(InquirePriceRenewEmrRequest req)
        {
            return InternalRequestAsync<InquirePriceRenewEmrResponse>(req, "InquirePriceRenewEmr")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建实例询价
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateInstanceResponse"/></returns>
        public Task<InquiryPriceCreateInstanceResponse> InquiryPriceCreateInstance(InquiryPriceCreateInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceCreateInstanceResponse>(req, "InquiryPriceCreateInstance");
        }

        /// <summary>
        /// 创建实例询价
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateInstanceResponse"/></returns>
        public InquiryPriceCreateInstanceResponse InquiryPriceCreateInstanceSync(InquiryPriceCreateInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceCreateInstanceResponse>(req, "InquiryPriceCreateInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 续费询价。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRenewInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceRenewInstanceResponse"/></returns>
        public Task<InquiryPriceRenewInstanceResponse> InquiryPriceRenewInstance(InquiryPriceRenewInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceRenewInstanceResponse>(req, "InquiryPriceRenewInstance");
        }

        /// <summary>
        /// 续费询价。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRenewInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceRenewInstanceResponse"/></returns>
        public InquiryPriceRenewInstanceResponse InquiryPriceRenewInstanceSync(InquiryPriceRenewInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceRenewInstanceResponse>(req, "InquiryPriceRenewInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 扩容询价. 当扩容时候，请通过该接口查询价格。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceScaleOutInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceScaleOutInstanceResponse"/></returns>
        public Task<InquiryPriceScaleOutInstanceResponse> InquiryPriceScaleOutInstance(InquiryPriceScaleOutInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceScaleOutInstanceResponse>(req, "InquiryPriceScaleOutInstance");
        }

        /// <summary>
        /// 扩容询价. 当扩容时候，请通过该接口查询价格。
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceScaleOutInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceScaleOutInstanceResponse"/></returns>
        public InquiryPriceScaleOutInstanceResponse InquiryPriceScaleOutInstanceSync(InquiryPriceScaleOutInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceScaleOutInstanceResponse>(req, "InquiryPriceScaleOutInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 变配询价
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceUpdateInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceUpdateInstanceResponse"/></returns>
        public Task<InquiryPriceUpdateInstanceResponse> InquiryPriceUpdateInstance(InquiryPriceUpdateInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceUpdateInstanceResponse>(req, "InquiryPriceUpdateInstance");
        }

        /// <summary>
        /// 变配询价
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceUpdateInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceUpdateInstanceResponse"/></returns>
        public InquiryPriceUpdateInstanceResponse InquiryPriceUpdateInstanceSync(InquiryPriceUpdateInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceUpdateInstanceResponse>(req, "InquiryPriceUpdateInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 前提：预付费集群
        /// 资源级别开启或关闭自动续费
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyAutoRenewFlagResponse"/></returns>
        public Task<ModifyAutoRenewFlagResponse> ModifyAutoRenewFlag(ModifyAutoRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyAutoRenewFlagResponse>(req, "ModifyAutoRenewFlag");
        }

        /// <summary>
        /// 前提：预付费集群
        /// 资源级别开启或关闭自动续费
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyAutoRenewFlagResponse"/></returns>
        public ModifyAutoRenewFlagResponse ModifyAutoRenewFlagSync(ModifyAutoRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyAutoRenewFlagResponse>(req, "ModifyAutoRenewFlag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改自动扩缩容规则
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoScaleStrategyRequest"/></param>
        /// <returns><see cref="ModifyAutoScaleStrategyResponse"/></returns>
        public Task<ModifyAutoScaleStrategyResponse> ModifyAutoScaleStrategy(ModifyAutoScaleStrategyRequest req)
        {
            return InternalRequestAsync<ModifyAutoScaleStrategyResponse>(req, "ModifyAutoScaleStrategy");
        }

        /// <summary>
        /// 修改自动扩缩容规则
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoScaleStrategyRequest"/></param>
        /// <returns><see cref="ModifyAutoScaleStrategyResponse"/></returns>
        public ModifyAutoScaleStrategyResponse ModifyAutoScaleStrategySync(ModifyAutoScaleStrategyRequest req)
        {
            return InternalRequestAsync<ModifyAutoScaleStrategyResponse>(req, "ModifyAutoScaleStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改YARN资源调度的全局配置
        /// </summary>
        /// <param name="req"><see cref="ModifyGlobalConfigRequest"/></param>
        /// <returns><see cref="ModifyGlobalConfigResponse"/></returns>
        public Task<ModifyGlobalConfigResponse> ModifyGlobalConfig(ModifyGlobalConfigRequest req)
        {
            return InternalRequestAsync<ModifyGlobalConfigResponse>(req, "ModifyGlobalConfig");
        }

        /// <summary>
        /// 修改YARN资源调度的全局配置
        /// </summary>
        /// <param name="req"><see cref="ModifyGlobalConfigRequest"/></param>
        /// <returns><see cref="ModifyGlobalConfigResponse"/></returns>
        public ModifyGlobalConfigResponse ModifyGlobalConfigSync(ModifyGlobalConfigRequest req)
        {
            return InternalRequestAsync<ModifyGlobalConfigResponse>(req, "ModifyGlobalConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改集群名称
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceBasicRequest"/></param>
        /// <returns><see cref="ModifyInstanceBasicResponse"/></returns>
        public Task<ModifyInstanceBasicResponse> ModifyInstanceBasic(ModifyInstanceBasicRequest req)
        {
            return InternalRequestAsync<ModifyInstanceBasicResponse>(req, "ModifyInstanceBasic");
        }

        /// <summary>
        /// 修改集群名称
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceBasicRequest"/></param>
        /// <returns><see cref="ModifyInstanceBasicResponse"/></returns>
        public ModifyInstanceBasicResponse ModifyInstanceBasicSync(ModifyInstanceBasicRequest req)
        {
            return InternalRequestAsync<ModifyInstanceBasicResponse>(req, "ModifyInstanceBasic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 调整Pod数量
        /// </summary>
        /// <param name="req"><see cref="ModifyPodNumRequest"/></param>
        /// <returns><see cref="ModifyPodNumResponse"/></returns>
        public Task<ModifyPodNumResponse> ModifyPodNum(ModifyPodNumRequest req)
        {
            return InternalRequestAsync<ModifyPodNumResponse>(req, "ModifyPodNum");
        }

        /// <summary>
        /// 调整Pod数量
        /// </summary>
        /// <param name="req"><see cref="ModifyPodNumRequest"/></param>
        /// <returns><see cref="ModifyPodNumResponse"/></returns>
        public ModifyPodNumResponse ModifyPodNumSync(ModifyPodNumRequest req)
        {
            return InternalRequestAsync<ModifyPodNumResponse>(req, "ModifyPodNum")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 变配实例
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceRequest"/></param>
        /// <returns><see cref="ModifyResourceResponse"/></returns>
        public Task<ModifyResourceResponse> ModifyResource(ModifyResourceRequest req)
        {
            return InternalRequestAsync<ModifyResourceResponse>(req, "ModifyResource");
        }

        /// <summary>
        /// 变配实例
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceRequest"/></param>
        /// <returns><see cref="ModifyResourceResponse"/></returns>
        public ModifyResourceResponse ModifyResourceSync(ModifyResourceRequest req)
        {
            return InternalRequestAsync<ModifyResourceResponse>(req, "ModifyResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 刷新YARN的动态资源池。已废弃，请使用`DeployYarnConf`
        /// </summary>
        /// <param name="req"><see cref="ModifyResourcePoolsRequest"/></param>
        /// <returns><see cref="ModifyResourcePoolsResponse"/></returns>
        public Task<ModifyResourcePoolsResponse> ModifyResourcePools(ModifyResourcePoolsRequest req)
        {
            return InternalRequestAsync<ModifyResourcePoolsResponse>(req, "ModifyResourcePools");
        }

        /// <summary>
        /// 刷新YARN的动态资源池。已废弃，请使用`DeployYarnConf`
        /// </summary>
        /// <param name="req"><see cref="ModifyResourcePoolsRequest"/></param>
        /// <returns><see cref="ModifyResourcePoolsResponse"/></returns>
        public ModifyResourcePoolsResponse ModifyResourcePoolsSync(ModifyResourcePoolsRequest req)
        {
            return InternalRequestAsync<ModifyResourcePoolsResponse>(req, "ModifyResourcePools")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改YARN资源调度的资源配置。已废弃，请使用`ModifyYarnQueueV2`来修改队列配置
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceScheduleConfigRequest"/></param>
        /// <returns><see cref="ModifyResourceScheduleConfigResponse"/></returns>
        public Task<ModifyResourceScheduleConfigResponse> ModifyResourceScheduleConfig(ModifyResourceScheduleConfigRequest req)
        {
            return InternalRequestAsync<ModifyResourceScheduleConfigResponse>(req, "ModifyResourceScheduleConfig");
        }

        /// <summary>
        /// 修改YARN资源调度的资源配置。已废弃，请使用`ModifyYarnQueueV2`来修改队列配置
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceScheduleConfigRequest"/></param>
        /// <returns><see cref="ModifyResourceScheduleConfigResponse"/></returns>
        public ModifyResourceScheduleConfigResponse ModifyResourceScheduleConfigSync(ModifyResourceScheduleConfigRequest req)
        {
            return InternalRequestAsync<ModifyResourceScheduleConfigResponse>(req, "ModifyResourceScheduleConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改了yarn的资源调度器，点击部署生效。
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceSchedulerRequest"/></param>
        /// <returns><see cref="ModifyResourceSchedulerResponse"/></returns>
        public Task<ModifyResourceSchedulerResponse> ModifyResourceScheduler(ModifyResourceSchedulerRequest req)
        {
            return InternalRequestAsync<ModifyResourceSchedulerResponse>(req, "ModifyResourceScheduler");
        }

        /// <summary>
        /// 修改了yarn的资源调度器，点击部署生效。
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceSchedulerRequest"/></param>
        /// <returns><see cref="ModifyResourceSchedulerResponse"/></returns>
        public ModifyResourceSchedulerResponse ModifyResourceSchedulerSync(ModifyResourceSchedulerRequest req)
        {
            return InternalRequestAsync<ModifyResourceSchedulerResponse>(req, "ModifyResourceScheduler")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 强制修改标签
        /// </summary>
        /// <param name="req"><see cref="ModifyResourcesTagsRequest"/></param>
        /// <returns><see cref="ModifyResourcesTagsResponse"/></returns>
        public Task<ModifyResourcesTagsResponse> ModifyResourcesTags(ModifyResourcesTagsRequest req)
        {
            return InternalRequestAsync<ModifyResourcesTagsResponse>(req, "ModifyResourcesTags");
        }

        /// <summary>
        /// 强制修改标签
        /// </summary>
        /// <param name="req"><see cref="ModifyResourcesTagsRequest"/></param>
        /// <returns><see cref="ModifyResourcesTagsResponse"/></returns>
        public ModifyResourcesTagsResponse ModifyResourcesTagsSync(ModifyResourcesTagsRequest req)
        {
            return InternalRequestAsync<ModifyResourcesTagsResponse>(req, "ModifyResourcesTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifySLInstance）用于Serverless HBase变配实例。
        /// - 接口调用成功，会创建Serverless HBase实例，创建实例请求成功会返回请求的 RequestID。
        /// - 接口为异步接口，接口返回时操作并未立即完成，实例操作结果可以通过调用DescribeInstancesList查看当前实例的StatusDesc状态。
        /// </summary>
        /// <param name="req"><see cref="ModifySLInstanceRequest"/></param>
        /// <returns><see cref="ModifySLInstanceResponse"/></returns>
        public Task<ModifySLInstanceResponse> ModifySLInstance(ModifySLInstanceRequest req)
        {
            return InternalRequestAsync<ModifySLInstanceResponse>(req, "ModifySLInstance");
        }

        /// <summary>
        /// 本接口（ModifySLInstance）用于Serverless HBase变配实例。
        /// - 接口调用成功，会创建Serverless HBase实例，创建实例请求成功会返回请求的 RequestID。
        /// - 接口为异步接口，接口返回时操作并未立即完成，实例操作结果可以通过调用DescribeInstancesList查看当前实例的StatusDesc状态。
        /// </summary>
        /// <param name="req"><see cref="ModifySLInstanceRequest"/></param>
        /// <returns><see cref="ModifySLInstanceResponse"/></returns>
        public ModifySLInstanceResponse ModifySLInstanceSync(ModifySLInstanceRequest req)
        {
            return InternalRequestAsync<ModifySLInstanceResponse>(req, "ModifySLInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改用户密码（用户管理）
        /// </summary>
        /// <param name="req"><see cref="ModifyUserManagerPwdRequest"/></param>
        /// <returns><see cref="ModifyUserManagerPwdResponse"/></returns>
        public Task<ModifyUserManagerPwdResponse> ModifyUserManagerPwd(ModifyUserManagerPwdRequest req)
        {
            return InternalRequestAsync<ModifyUserManagerPwdResponse>(req, "ModifyUserManagerPwd");
        }

        /// <summary>
        /// 修改用户密码（用户管理）
        /// </summary>
        /// <param name="req"><see cref="ModifyUserManagerPwdRequest"/></param>
        /// <returns><see cref="ModifyUserManagerPwdResponse"/></returns>
        public ModifyUserManagerPwdResponse ModifyUserManagerPwdSync(ModifyUserManagerPwdRequest req)
        {
            return InternalRequestAsync<ModifyUserManagerPwdResponse>(req, "ModifyUserManagerPwd")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 部署生效。已废弃，请使用`DeployYarnConf`接口进行部署生效
        /// </summary>
        /// <param name="req"><see cref="ModifyYarnDeployRequest"/></param>
        /// <returns><see cref="ModifyYarnDeployResponse"/></returns>
        public Task<ModifyYarnDeployResponse> ModifyYarnDeploy(ModifyYarnDeployRequest req)
        {
            return InternalRequestAsync<ModifyYarnDeployResponse>(req, "ModifyYarnDeploy");
        }

        /// <summary>
        /// 部署生效。已废弃，请使用`DeployYarnConf`接口进行部署生效
        /// </summary>
        /// <param name="req"><see cref="ModifyYarnDeployRequest"/></param>
        /// <returns><see cref="ModifyYarnDeployResponse"/></returns>
        public ModifyYarnDeployResponse ModifyYarnDeploySync(ModifyYarnDeployRequest req)
        {
            return InternalRequestAsync<ModifyYarnDeployResponse>(req, "ModifyYarnDeploy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改资源调度中队列信息
        /// </summary>
        /// <param name="req"><see cref="ModifyYarnQueueV2Request"/></param>
        /// <returns><see cref="ModifyYarnQueueV2Response"/></returns>
        public Task<ModifyYarnQueueV2Response> ModifyYarnQueueV2(ModifyYarnQueueV2Request req)
        {
            return InternalRequestAsync<ModifyYarnQueueV2Response>(req, "ModifyYarnQueueV2");
        }

        /// <summary>
        /// 修改资源调度中队列信息
        /// </summary>
        /// <param name="req"><see cref="ModifyYarnQueueV2Request"/></param>
        /// <returns><see cref="ModifyYarnQueueV2Response"/></returns>
        public ModifyYarnQueueV2Response ModifyYarnQueueV2Sync(ModifyYarnQueueV2Request req)
        {
            return InternalRequestAsync<ModifyYarnQueueV2Response>(req, "ModifyYarnQueueV2")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改YARN资源调度的资源配置
        /// </summary>
        /// <param name="req"><see cref="ResetYarnConfigRequest"/></param>
        /// <returns><see cref="ResetYarnConfigResponse"/></returns>
        public Task<ResetYarnConfigResponse> ResetYarnConfig(ResetYarnConfigRequest req)
        {
            return InternalRequestAsync<ResetYarnConfigResponse>(req, "ResetYarnConfig");
        }

        /// <summary>
        /// 修改YARN资源调度的资源配置
        /// </summary>
        /// <param name="req"><see cref="ResetYarnConfigRequest"/></param>
        /// <returns><see cref="ResetYarnConfigResponse"/></returns>
        public ResetYarnConfigResponse ResetYarnConfigSync(ResetYarnConfigRequest req)
        {
            return InternalRequestAsync<ResetYarnConfigResponse>(req, "ResetYarnConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云盘扩容
        /// </summary>
        /// <param name="req"><see cref="ResizeDataDisksRequest"/></param>
        /// <returns><see cref="ResizeDataDisksResponse"/></returns>
        public Task<ResizeDataDisksResponse> ResizeDataDisks(ResizeDataDisksRequest req)
        {
            return InternalRequestAsync<ResizeDataDisksResponse>(req, "ResizeDataDisks");
        }

        /// <summary>
        /// 云盘扩容
        /// </summary>
        /// <param name="req"><see cref="ResizeDataDisksRequest"/></param>
        /// <returns><see cref="ResizeDataDisksResponse"/></returns>
        public ResizeDataDisksResponse ResizeDataDisksSync(ResizeDataDisksRequest req)
        {
            return InternalRequestAsync<ResizeDataDisksResponse>(req, "ResizeDataDisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建流程作业
        /// </summary>
        /// <param name="req"><see cref="RunJobFlowRequest"/></param>
        /// <returns><see cref="RunJobFlowResponse"/></returns>
        public Task<RunJobFlowResponse> RunJobFlow(RunJobFlowRequest req)
        {
            return InternalRequestAsync<RunJobFlowResponse>(req, "RunJobFlow");
        }

        /// <summary>
        /// 创建流程作业
        /// </summary>
        /// <param name="req"><see cref="RunJobFlowRequest"/></param>
        /// <returns><see cref="RunJobFlowResponse"/></returns>
        public RunJobFlowResponse RunJobFlowSync(RunJobFlowRequest req)
        {
            return InternalRequestAsync<RunJobFlowResponse>(req, "RunJobFlow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 扩容集群节点
        /// </summary>
        /// <param name="req"><see cref="ScaleOutClusterRequest"/></param>
        /// <returns><see cref="ScaleOutClusterResponse"/></returns>
        public Task<ScaleOutClusterResponse> ScaleOutCluster(ScaleOutClusterRequest req)
        {
            return InternalRequestAsync<ScaleOutClusterResponse>(req, "ScaleOutCluster");
        }

        /// <summary>
        /// 扩容集群节点
        /// </summary>
        /// <param name="req"><see cref="ScaleOutClusterRequest"/></param>
        /// <returns><see cref="ScaleOutClusterResponse"/></returns>
        public ScaleOutClusterResponse ScaleOutClusterSync(ScaleOutClusterRequest req)
        {
            return InternalRequestAsync<ScaleOutClusterResponse>(req, "ScaleOutCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 扩容节点
        /// </summary>
        /// <param name="req"><see cref="ScaleOutInstanceRequest"/></param>
        /// <returns><see cref="ScaleOutInstanceResponse"/></returns>
        public Task<ScaleOutInstanceResponse> ScaleOutInstance(ScaleOutInstanceRequest req)
        {
            return InternalRequestAsync<ScaleOutInstanceResponse>(req, "ScaleOutInstance");
        }

        /// <summary>
        /// 扩容节点
        /// </summary>
        /// <param name="req"><see cref="ScaleOutInstanceRequest"/></param>
        /// <returns><see cref="ScaleOutInstanceResponse"/></returns>
        public ScaleOutInstanceResponse ScaleOutInstanceSync(ScaleOutInstanceRequest req)
        {
            return InternalRequestAsync<ScaleOutInstanceResponse>(req, "ScaleOutInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置当前集群的某个节点规格配置为默认或取消默认
        /// </summary>
        /// <param name="req"><see cref="SetNodeResourceConfigDefaultRequest"/></param>
        /// <returns><see cref="SetNodeResourceConfigDefaultResponse"/></returns>
        public Task<SetNodeResourceConfigDefaultResponse> SetNodeResourceConfigDefault(SetNodeResourceConfigDefaultRequest req)
        {
            return InternalRequestAsync<SetNodeResourceConfigDefaultResponse>(req, "SetNodeResourceConfigDefault");
        }

        /// <summary>
        /// 设置当前集群的某个节点规格配置为默认或取消默认
        /// </summary>
        /// <param name="req"><see cref="SetNodeResourceConfigDefaultRequest"/></param>
        /// <returns><see cref="SetNodeResourceConfigDefaultResponse"/></returns>
        public SetNodeResourceConfigDefaultResponse SetNodeResourceConfigDefaultSync(SetNodeResourceConfigDefaultRequest req)
        {
            return InternalRequestAsync<SetNodeResourceConfigDefaultResponse>(req, "SetNodeResourceConfigDefault")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于启停服务 重启服务等功能
        /// </summary>
        /// <param name="req"><see cref="StartStopServiceOrMonitorRequest"/></param>
        /// <returns><see cref="StartStopServiceOrMonitorResponse"/></returns>
        public Task<StartStopServiceOrMonitorResponse> StartStopServiceOrMonitor(StartStopServiceOrMonitorRequest req)
        {
            return InternalRequestAsync<StartStopServiceOrMonitorResponse>(req, "StartStopServiceOrMonitor");
        }

        /// <summary>
        /// 用于启停服务 重启服务等功能
        /// </summary>
        /// <param name="req"><see cref="StartStopServiceOrMonitorRequest"/></param>
        /// <returns><see cref="StartStopServiceOrMonitorResponse"/></returns>
        public StartStopServiceOrMonitorResponse StartStopServiceOrMonitorSync(StartStopServiceOrMonitorRequest req)
        {
            return InternalRequestAsync<StartStopServiceOrMonitorResponse>(req, "StartStopServiceOrMonitor")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// EMR同步TKE中POD状态
        /// </summary>
        /// <param name="req"><see cref="SyncPodStateRequest"/></param>
        /// <returns><see cref="SyncPodStateResponse"/></returns>
        public Task<SyncPodStateResponse> SyncPodState(SyncPodStateRequest req)
        {
            return InternalRequestAsync<SyncPodStateResponse>(req, "SyncPodState");
        }

        /// <summary>
        /// EMR同步TKE中POD状态
        /// </summary>
        /// <param name="req"><see cref="SyncPodStateRequest"/></param>
        /// <returns><see cref="SyncPodStateResponse"/></returns>
        public SyncPodStateResponse SyncPodStateSync(SyncPodStateRequest req)
        {
            return InternalRequestAsync<SyncPodStateResponse>(req, "SyncPodState")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 销毁集群节点
        /// </summary>
        /// <param name="req"><see cref="TerminateClusterNodesRequest"/></param>
        /// <returns><see cref="TerminateClusterNodesResponse"/></returns>
        public Task<TerminateClusterNodesResponse> TerminateClusterNodes(TerminateClusterNodesRequest req)
        {
            return InternalRequestAsync<TerminateClusterNodesResponse>(req, "TerminateClusterNodes");
        }

        /// <summary>
        /// 销毁集群节点
        /// </summary>
        /// <param name="req"><see cref="TerminateClusterNodesRequest"/></param>
        /// <returns><see cref="TerminateClusterNodesResponse"/></returns>
        public TerminateClusterNodesResponse TerminateClusterNodesSync(TerminateClusterNodesRequest req)
        {
            return InternalRequestAsync<TerminateClusterNodesResponse>(req, "TerminateClusterNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 销毁EMR实例。此接口仅支持弹性MapReduce正式计费版本。
        /// </summary>
        /// <param name="req"><see cref="TerminateInstanceRequest"/></param>
        /// <returns><see cref="TerminateInstanceResponse"/></returns>
        public Task<TerminateInstanceResponse> TerminateInstance(TerminateInstanceRequest req)
        {
            return InternalRequestAsync<TerminateInstanceResponse>(req, "TerminateInstance");
        }

        /// <summary>
        /// 销毁EMR实例。此接口仅支持弹性MapReduce正式计费版本。
        /// </summary>
        /// <param name="req"><see cref="TerminateInstanceRequest"/></param>
        /// <returns><see cref="TerminateInstanceResponse"/></returns>
        public TerminateInstanceResponse TerminateInstanceSync(TerminateInstanceRequest req)
        {
            return InternalRequestAsync<TerminateInstanceResponse>(req, "TerminateInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（TerminateSLInstance）用于销毁Serverless HBase实例
        /// </summary>
        /// <param name="req"><see cref="TerminateSLInstanceRequest"/></param>
        /// <returns><see cref="TerminateSLInstanceResponse"/></returns>
        public Task<TerminateSLInstanceResponse> TerminateSLInstance(TerminateSLInstanceRequest req)
        {
            return InternalRequestAsync<TerminateSLInstanceResponse>(req, "TerminateSLInstance");
        }

        /// <summary>
        /// 本接口（TerminateSLInstance）用于销毁Serverless HBase实例
        /// </summary>
        /// <param name="req"><see cref="TerminateSLInstanceRequest"/></param>
        /// <returns><see cref="TerminateSLInstanceResponse"/></returns>
        public TerminateSLInstanceResponse TerminateSLInstanceSync(TerminateSLInstanceRequest req)
        {
            return InternalRequestAsync<TerminateSLInstanceResponse>(req, "TerminateSLInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 缩容Task节点
        /// </summary>
        /// <param name="req"><see cref="TerminateTasksRequest"/></param>
        /// <returns><see cref="TerminateTasksResponse"/></returns>
        public Task<TerminateTasksResponse> TerminateTasks(TerminateTasksRequest req)
        {
            return InternalRequestAsync<TerminateTasksResponse>(req, "TerminateTasks");
        }

        /// <summary>
        /// 缩容Task节点
        /// </summary>
        /// <param name="req"><see cref="TerminateTasksRequest"/></param>
        /// <returns><see cref="TerminateTasksResponse"/></returns>
        public TerminateTasksResponse TerminateTasksSync(TerminateTasksRequest req)
        {
            return InternalRequestAsync<TerminateTasksResponse>(req, "TerminateTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}

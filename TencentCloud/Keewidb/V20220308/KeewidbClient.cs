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

namespace TencentCloud.Keewidb.V20220308
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Keewidb.V20220308.Models;

   public class KeewidbClient : AbstractClient{

       private const string endpoint = "keewidb.tencentcloudapi.com";
       private const string version = "2022-03-08";
       private const string sdkVersion = "SDK_NET_3.0.1215";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public KeewidbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public KeewidbClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 本接口 (AssociateSecurityGroups) 用于安全组批量绑定多个指定实例。
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupsResponse"/></returns>
        public Task<AssociateSecurityGroupsResponse> AssociateSecurityGroups(AssociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<AssociateSecurityGroupsResponse>(req, "AssociateSecurityGroups");
        }

        /// <summary>
        /// 本接口 (AssociateSecurityGroups) 用于安全组批量绑定多个指定实例。
        /// </summary>
        /// <param name="req"><see cref="AssociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="AssociateSecurityGroupsResponse"/></returns>
        public AssociateSecurityGroupsResponse AssociateSecurityGroupsSync(AssociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<AssociateSecurityGroupsResponse>(req, "AssociateSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ChangeInstanceMaster）用于将副本节点提升为主节点。
        /// </summary>
        /// <param name="req"><see cref="ChangeInstanceMasterRequest"/></param>
        /// <returns><see cref="ChangeInstanceMasterResponse"/></returns>
        public Task<ChangeInstanceMasterResponse> ChangeInstanceMaster(ChangeInstanceMasterRequest req)
        {
            return InternalRequestAsync<ChangeInstanceMasterResponse>(req, "ChangeInstanceMaster");
        }

        /// <summary>
        /// 本接口（ChangeInstanceMaster）用于将副本节点提升为主节点。
        /// </summary>
        /// <param name="req"><see cref="ChangeInstanceMasterRequest"/></param>
        /// <returns><see cref="ChangeInstanceMasterResponse"/></returns>
        public ChangeInstanceMasterResponse ChangeInstanceMasterSync(ChangeInstanceMasterRequest req)
        {
            return InternalRequestAsync<ChangeInstanceMasterResponse>(req, "ChangeInstanceMaster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CleanUpInstance）用于立即下线回收站已隔离的实例。
        /// </summary>
        /// <param name="req"><see cref="CleanUpInstanceRequest"/></param>
        /// <returns><see cref="CleanUpInstanceResponse"/></returns>
        public Task<CleanUpInstanceResponse> CleanUpInstance(CleanUpInstanceRequest req)
        {
            return InternalRequestAsync<CleanUpInstanceResponse>(req, "CleanUpInstance");
        }

        /// <summary>
        /// 本接口（CleanUpInstance）用于立即下线回收站已隔离的实例。
        /// </summary>
        /// <param name="req"><see cref="CleanUpInstanceRequest"/></param>
        /// <returns><see cref="CleanUpInstanceResponse"/></returns>
        public CleanUpInstanceResponse CleanUpInstanceSync(CleanUpInstanceRequest req)
        {
            return InternalRequestAsync<CleanUpInstanceResponse>(req, "CleanUpInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ClearInstance）用于清空实例数据。
        /// > **说明**：在清空数据流程中，系统将自动进行数据备份，耗时较长，请您耐心等待并提前做好时间规划。
        /// </summary>
        /// <param name="req"><see cref="ClearInstanceRequest"/></param>
        /// <returns><see cref="ClearInstanceResponse"/></returns>
        public Task<ClearInstanceResponse> ClearInstance(ClearInstanceRequest req)
        {
            return InternalRequestAsync<ClearInstanceResponse>(req, "ClearInstance");
        }

        /// <summary>
        /// 本接口（ClearInstance）用于清空实例数据。
        /// > **说明**：在清空数据流程中，系统将自动进行数据备份，耗时较长，请您耐心等待并提前做好时间规划。
        /// </summary>
        /// <param name="req"><see cref="ClearInstanceRequest"/></param>
        /// <returns><see cref="ClearInstanceResponse"/></returns>
        public ClearInstanceResponse ClearInstanceSync(ClearInstanceRequest req)
        {
            return InternalRequestAsync<ClearInstanceResponse>(req, "ClearInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 手动发起备份
        /// </summary>
        /// <param name="req"><see cref="CreateBackupManuallyRequest"/></param>
        /// <returns><see cref="CreateBackupManuallyResponse"/></returns>
        public Task<CreateBackupManuallyResponse> CreateBackupManually(CreateBackupManuallyRequest req)
        {
            return InternalRequestAsync<CreateBackupManuallyResponse>(req, "CreateBackupManually");
        }

        /// <summary>
        /// 手动发起备份
        /// </summary>
        /// <param name="req"><see cref="CreateBackupManuallyRequest"/></param>
        /// <returns><see cref="CreateBackupManuallyResponse"/></returns>
        public CreateBackupManuallyResponse CreateBackupManuallySync(CreateBackupManuallyRequest req)
        {
            return InternalRequestAsync<CreateBackupManuallyResponse>(req, "CreateBackupManually")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建数据库实例
        /// </summary>
        /// <param name="req"><see cref="CreateInstancesRequest"/></param>
        /// <returns><see cref="CreateInstancesResponse"/></returns>
        public Task<CreateInstancesResponse> CreateInstances(CreateInstancesRequest req)
        {
            return InternalRequestAsync<CreateInstancesResponse>(req, "CreateInstances");
        }

        /// <summary>
        /// 创建数据库实例
        /// </summary>
        /// <param name="req"><see cref="CreateInstancesRequest"/></param>
        /// <returns><see cref="CreateInstancesResponse"/></returns>
        public CreateInstancesResponse CreateInstancesSync(CreateInstancesRequest req)
        {
            return InternalRequestAsync<CreateInstancesResponse>(req, "CreateInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeAutoBackupConfig）用于获取自动备份配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoBackupConfigRequest"/></param>
        /// <returns><see cref="DescribeAutoBackupConfigResponse"/></returns>
        public Task<DescribeAutoBackupConfigResponse> DescribeAutoBackupConfig(DescribeAutoBackupConfigRequest req)
        {
            return InternalRequestAsync<DescribeAutoBackupConfigResponse>(req, "DescribeAutoBackupConfig");
        }

        /// <summary>
        /// 本接口（DescribeAutoBackupConfig）用于获取自动备份配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoBackupConfigRequest"/></param>
        /// <returns><see cref="DescribeAutoBackupConfigResponse"/></returns>
        public DescribeAutoBackupConfigResponse DescribeAutoBackupConfigSync(DescribeAutoBackupConfigRequest req)
        {
            return InternalRequestAsync<DescribeAutoBackupConfigResponse>(req, "DescribeAutoBackupConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeConnectionConfig）用于查询实例连接配置，包括出流量和入流量带宽、最大连接数限制。
        /// </summary>
        /// <param name="req"><see cref="DescribeConnectionConfigRequest"/></param>
        /// <returns><see cref="DescribeConnectionConfigResponse"/></returns>
        public Task<DescribeConnectionConfigResponse> DescribeConnectionConfig(DescribeConnectionConfigRequest req)
        {
            return InternalRequestAsync<DescribeConnectionConfigResponse>(req, "DescribeConnectionConfig");
        }

        /// <summary>
        /// 本接口（DescribeConnectionConfig）用于查询实例连接配置，包括出流量和入流量带宽、最大连接数限制。
        /// </summary>
        /// <param name="req"><see cref="DescribeConnectionConfigRequest"/></param>
        /// <returns><see cref="DescribeConnectionConfigResponse"/></returns>
        public DescribeConnectionConfigResponse DescribeConnectionConfigSync(DescribeConnectionConfigRequest req)
        {
            return InternalRequestAsync<DescribeConnectionConfigResponse>(req, "DescribeConnectionConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeDBSecurityGroups)用于查询实例的安全组详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeDBSecurityGroupsResponse"/></returns>
        public Task<DescribeDBSecurityGroupsResponse> DescribeDBSecurityGroups(DescribeDBSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeDBSecurityGroupsResponse>(req, "DescribeDBSecurityGroups");
        }

        /// <summary>
        /// 本接口(DescribeDBSecurityGroups)用于查询实例的安全组详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeDBSecurityGroupsResponse"/></returns>
        public DescribeDBSecurityGroupsResponse DescribeDBSecurityGroupsSync(DescribeDBSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeDBSecurityGroupsResponse>(req, "DescribeDBSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeInstanceBackups）用于查询实例全量备份列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceBackupsRequest"/></param>
        /// <returns><see cref="DescribeInstanceBackupsResponse"/></returns>
        public Task<DescribeInstanceBackupsResponse> DescribeInstanceBackups(DescribeInstanceBackupsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceBackupsResponse>(req, "DescribeInstanceBackups");
        }

        /// <summary>
        /// 本接口（DescribeInstanceBackups）用于查询实例全量备份列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceBackupsRequest"/></param>
        /// <returns><see cref="DescribeInstanceBackupsResponse"/></returns>
        public DescribeInstanceBackupsResponse DescribeInstanceBackupsSync(DescribeInstanceBackupsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceBackupsResponse>(req, "DescribeInstanceBackups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeInstanceBinlogs）用于查询增量备份列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceBinlogsRequest"/></param>
        /// <returns><see cref="DescribeInstanceBinlogsResponse"/></returns>
        public Task<DescribeInstanceBinlogsResponse> DescribeInstanceBinlogs(DescribeInstanceBinlogsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceBinlogsResponse>(req, "DescribeInstanceBinlogs");
        }

        /// <summary>
        /// 本接口（DescribeInstanceBinlogs）用于查询增量备份列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceBinlogsRequest"/></param>
        /// <returns><see cref="DescribeInstanceBinlogsResponse"/></returns>
        public DescribeInstanceBinlogsResponse DescribeInstanceBinlogsSync(DescribeInstanceBinlogsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceBinlogsResponse>(req, "DescribeInstanceBinlogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeInstanceDealDetail）用于查询预付费订单信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceDealDetailRequest"/></param>
        /// <returns><see cref="DescribeInstanceDealDetailResponse"/></returns>
        public Task<DescribeInstanceDealDetailResponse> DescribeInstanceDealDetail(DescribeInstanceDealDetailRequest req)
        {
            return InternalRequestAsync<DescribeInstanceDealDetailResponse>(req, "DescribeInstanceDealDetail");
        }

        /// <summary>
        /// 本接口（DescribeInstanceDealDetail）用于查询预付费订单信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceDealDetailRequest"/></param>
        /// <returns><see cref="DescribeInstanceDealDetailResponse"/></returns>
        public DescribeInstanceDealDetailResponse DescribeInstanceDealDetailSync(DescribeInstanceDealDetailRequest req)
        {
            return InternalRequestAsync<DescribeInstanceDealDetailResponse>(req, "DescribeInstanceDealDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeInstanceNodeInfo）查询实例节点信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceNodeInfoRequest"/></param>
        /// <returns><see cref="DescribeInstanceNodeInfoResponse"/></returns>
        public Task<DescribeInstanceNodeInfoResponse> DescribeInstanceNodeInfo(DescribeInstanceNodeInfoRequest req)
        {
            return InternalRequestAsync<DescribeInstanceNodeInfoResponse>(req, "DescribeInstanceNodeInfo");
        }

        /// <summary>
        /// 本接口（DescribeInstanceNodeInfo）查询实例节点信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceNodeInfoRequest"/></param>
        /// <returns><see cref="DescribeInstanceNodeInfoResponse"/></returns>
        public DescribeInstanceNodeInfoResponse DescribeInstanceNodeInfoSync(DescribeInstanceNodeInfoRequest req)
        {
            return InternalRequestAsync<DescribeInstanceNodeInfoResponse>(req, "DescribeInstanceNodeInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeInstanceParamRecords）查询参数配置修改历史列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamRecordsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamRecordsResponse"/></returns>
        public Task<DescribeInstanceParamRecordsResponse> DescribeInstanceParamRecords(DescribeInstanceParamRecordsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceParamRecordsResponse>(req, "DescribeInstanceParamRecords");
        }

        /// <summary>
        /// 本接口（DescribeInstanceParamRecords）查询参数配置修改历史列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamRecordsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamRecordsResponse"/></returns>
        public DescribeInstanceParamRecordsResponse DescribeInstanceParamRecordsSync(DescribeInstanceParamRecordsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceParamRecordsResponse>(req, "DescribeInstanceParamRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeInstanceParams）用于查询实例的参数列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamsResponse"/></returns>
        public Task<DescribeInstanceParamsResponse> DescribeInstanceParams(DescribeInstanceParamsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceParamsResponse>(req, "DescribeInstanceParams");
        }

        /// <summary>
        /// 本接口（DescribeInstanceParams）用于查询实例的参数列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceParamsRequest"/></param>
        /// <returns><see cref="DescribeInstanceParamsResponse"/></returns>
        public DescribeInstanceParamsResponse DescribeInstanceParamsSync(DescribeInstanceParamsRequest req)
        {
            return InternalRequestAsync<DescribeInstanceParamsResponse>(req, "DescribeInstanceParams")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeInstanceReplicas）用于获取实例副本节点信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceReplicasRequest"/></param>
        /// <returns><see cref="DescribeInstanceReplicasResponse"/></returns>
        public Task<DescribeInstanceReplicasResponse> DescribeInstanceReplicas(DescribeInstanceReplicasRequest req)
        {
            return InternalRequestAsync<DescribeInstanceReplicasResponse>(req, "DescribeInstanceReplicas");
        }

        /// <summary>
        /// 本接口（DescribeInstanceReplicas）用于获取实例副本节点信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceReplicasRequest"/></param>
        /// <returns><see cref="DescribeInstanceReplicasResponse"/></returns>
        public DescribeInstanceReplicasResponse DescribeInstanceReplicasSync(DescribeInstanceReplicasRequest req)
        {
            return InternalRequestAsync<DescribeInstanceReplicasResponse>(req, "DescribeInstanceReplicas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeInstances）可以根据地域、网络、实例id、标签、计费方式等条件，搜索查询实例列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances");
        }

        /// <summary>
        /// 本接口（DescribeInstances）可以根据地域、网络、实例id、标签、计费方式等条件，搜索查询实例列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeMaintenanceWindow）用于查询实例维护时间窗。
        /// </summary>
        /// <param name="req"><see cref="DescribeMaintenanceWindowRequest"/></param>
        /// <returns><see cref="DescribeMaintenanceWindowResponse"/></returns>
        public Task<DescribeMaintenanceWindowResponse> DescribeMaintenanceWindow(DescribeMaintenanceWindowRequest req)
        {
            return InternalRequestAsync<DescribeMaintenanceWindowResponse>(req, "DescribeMaintenanceWindow");
        }

        /// <summary>
        /// 本接口（DescribeMaintenanceWindow）用于查询实例维护时间窗。
        /// </summary>
        /// <param name="req"><see cref="DescribeMaintenanceWindowRequest"/></param>
        /// <returns><see cref="DescribeMaintenanceWindowResponse"/></returns>
        public DescribeMaintenanceWindowResponse DescribeMaintenanceWindowSync(DescribeMaintenanceWindowRequest req)
        {
            return InternalRequestAsync<DescribeMaintenanceWindowResponse>(req, "DescribeMaintenanceWindow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口查询指定可用区和实例类型下keewidb 的售卖规格， 如果用户不在购买白名单中，将不能查询该可用区或该类型的售卖规格详情。申请购买某地域白名单可以提交工单
        /// </summary>
        /// <param name="req"><see cref="DescribeProductInfoRequest"/></param>
        /// <returns><see cref="DescribeProductInfoResponse"/></returns>
        public Task<DescribeProductInfoResponse> DescribeProductInfo(DescribeProductInfoRequest req)
        {
            return InternalRequestAsync<DescribeProductInfoResponse>(req, "DescribeProductInfo");
        }

        /// <summary>
        /// 本接口查询指定可用区和实例类型下keewidb 的售卖规格， 如果用户不在购买白名单中，将不能查询该可用区或该类型的售卖规格详情。申请购买某地域白名单可以提交工单
        /// </summary>
        /// <param name="req"><see cref="DescribeProductInfoRequest"/></param>
        /// <returns><see cref="DescribeProductInfoResponse"/></returns>
        public DescribeProductInfoResponse DescribeProductInfoSync(DescribeProductInfoRequest req)
        {
            return InternalRequestAsync<DescribeProductInfoResponse>(req, "DescribeProductInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DescribeProjectSecurityGroups)用于查询项目的安全组详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeProjectSecurityGroupsResponse"/></returns>
        public Task<DescribeProjectSecurityGroupsResponse> DescribeProjectSecurityGroups(DescribeProjectSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeProjectSecurityGroupsResponse>(req, "DescribeProjectSecurityGroups");
        }

        /// <summary>
        /// 本接口(DescribeProjectSecurityGroups)用于查询项目的安全组详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeProjectSecurityGroupsResponse"/></returns>
        public DescribeProjectSecurityGroupsResponse DescribeProjectSecurityGroupsSync(DescribeProjectSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DescribeProjectSecurityGroupsResponse>(req, "DescribeProjectSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeProxySlowLog）用于查询代理（Proxy）慢日志。
        /// </summary>
        /// <param name="req"><see cref="DescribeProxySlowLogRequest"/></param>
        /// <returns><see cref="DescribeProxySlowLogResponse"/></returns>
        public Task<DescribeProxySlowLogResponse> DescribeProxySlowLog(DescribeProxySlowLogRequest req)
        {
            return InternalRequestAsync<DescribeProxySlowLogResponse>(req, "DescribeProxySlowLog");
        }

        /// <summary>
        /// 本接口（DescribeProxySlowLog）用于查询代理（Proxy）慢日志。
        /// </summary>
        /// <param name="req"><see cref="DescribeProxySlowLogRequest"/></param>
        /// <returns><see cref="DescribeProxySlowLogResponse"/></returns>
        public DescribeProxySlowLogResponse DescribeProxySlowLogSync(DescribeProxySlowLogRequest req)
        {
            return InternalRequestAsync<DescribeProxySlowLogResponse>(req, "DescribeProxySlowLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeTaskInfo）用于查询异步任务结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskInfoRequest"/></param>
        /// <returns><see cref="DescribeTaskInfoResponse"/></returns>
        public Task<DescribeTaskInfoResponse> DescribeTaskInfo(DescribeTaskInfoRequest req)
        {
            return InternalRequestAsync<DescribeTaskInfoResponse>(req, "DescribeTaskInfo");
        }

        /// <summary>
        /// 本接口（DescribeTaskInfo）用于查询异步任务结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskInfoRequest"/></param>
        /// <returns><see cref="DescribeTaskInfoResponse"/></returns>
        public DescribeTaskInfoResponse DescribeTaskInfoSync(DescribeTaskInfoRequest req)
        {
            return InternalRequestAsync<DescribeTaskInfoResponse>(req, "DescribeTaskInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeTaskList）用于查询任务列表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskListRequest"/></param>
        /// <returns><see cref="DescribeTaskListResponse"/></returns>
        public Task<DescribeTaskListResponse> DescribeTaskList(DescribeTaskListRequest req)
        {
            return InternalRequestAsync<DescribeTaskListResponse>(req, "DescribeTaskList");
        }

        /// <summary>
        /// 本接口（DescribeTaskList）用于查询任务列表信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskListRequest"/></param>
        /// <returns><see cref="DescribeTaskListResponse"/></returns>
        public DescribeTaskListResponse DescribeTaskListSync(DescribeTaskListRequest req)
        {
            return InternalRequestAsync<DescribeTaskListResponse>(req, "DescribeTaskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeTendisSlowLog）用于查询实例慢日志。
        /// </summary>
        /// <param name="req"><see cref="DescribeTendisSlowLogRequest"/></param>
        /// <returns><see cref="DescribeTendisSlowLogResponse"/></returns>
        public Task<DescribeTendisSlowLogResponse> DescribeTendisSlowLog(DescribeTendisSlowLogRequest req)
        {
            return InternalRequestAsync<DescribeTendisSlowLogResponse>(req, "DescribeTendisSlowLog");
        }

        /// <summary>
        /// 本接口（DescribeTendisSlowLog）用于查询实例慢日志。
        /// </summary>
        /// <param name="req"><see cref="DescribeTendisSlowLogRequest"/></param>
        /// <returns><see cref="DescribeTendisSlowLogResponse"/></returns>
        public DescribeTendisSlowLogResponse DescribeTendisSlowLogSync(DescribeTendisSlowLogRequest req)
        {
            return InternalRequestAsync<DescribeTendisSlowLogResponse>(req, "DescribeTendisSlowLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DestroyPostpaidInstance）用于退还按量计费实例。
        /// </summary>
        /// <param name="req"><see cref="DestroyPostpaidInstanceRequest"/></param>
        /// <returns><see cref="DestroyPostpaidInstanceResponse"/></returns>
        public Task<DestroyPostpaidInstanceResponse> DestroyPostpaidInstance(DestroyPostpaidInstanceRequest req)
        {
            return InternalRequestAsync<DestroyPostpaidInstanceResponse>(req, "DestroyPostpaidInstance");
        }

        /// <summary>
        /// 本接口（DestroyPostpaidInstance）用于退还按量计费实例。
        /// </summary>
        /// <param name="req"><see cref="DestroyPostpaidInstanceRequest"/></param>
        /// <returns><see cref="DestroyPostpaidInstanceResponse"/></returns>
        public DestroyPostpaidInstanceResponse DestroyPostpaidInstanceSync(DestroyPostpaidInstanceRequest req)
        {
            return InternalRequestAsync<DestroyPostpaidInstanceResponse>(req, "DestroyPostpaidInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DestroyPrepaidInstance）用于退还包年包月计费实例。
        /// </summary>
        /// <param name="req"><see cref="DestroyPrepaidInstanceRequest"/></param>
        /// <returns><see cref="DestroyPrepaidInstanceResponse"/></returns>
        public Task<DestroyPrepaidInstanceResponse> DestroyPrepaidInstance(DestroyPrepaidInstanceRequest req)
        {
            return InternalRequestAsync<DestroyPrepaidInstanceResponse>(req, "DestroyPrepaidInstance");
        }

        /// <summary>
        /// 本接口（DestroyPrepaidInstance）用于退还包年包月计费实例。
        /// </summary>
        /// <param name="req"><see cref="DestroyPrepaidInstanceRequest"/></param>
        /// <returns><see cref="DestroyPrepaidInstanceResponse"/></returns>
        public DestroyPrepaidInstanceResponse DestroyPrepaidInstanceSync(DestroyPrepaidInstanceRequest req)
        {
            return InternalRequestAsync<DestroyPrepaidInstanceResponse>(req, "DestroyPrepaidInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(DisassociateSecurityGroups)用于安全组批量解绑实例。
        /// </summary>
        /// <param name="req"><see cref="DisassociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateSecurityGroupsResponse"/></returns>
        public Task<DisassociateSecurityGroupsResponse> DisassociateSecurityGroups(DisassociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DisassociateSecurityGroupsResponse>(req, "DisassociateSecurityGroups");
        }

        /// <summary>
        /// 本接口(DisassociateSecurityGroups)用于安全组批量解绑实例。
        /// </summary>
        /// <param name="req"><see cref="DisassociateSecurityGroupsRequest"/></param>
        /// <returns><see cref="DisassociateSecurityGroupsResponse"/></returns>
        public DisassociateSecurityGroupsResponse DisassociateSecurityGroupsSync(DisassociateSecurityGroupsRequest req)
        {
            return InternalRequestAsync<DisassociateSecurityGroupsResponse>(req, "DisassociateSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyAutoBackupConfig）用于修改自动备份配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoBackupConfigRequest"/></param>
        /// <returns><see cref="ModifyAutoBackupConfigResponse"/></returns>
        public Task<ModifyAutoBackupConfigResponse> ModifyAutoBackupConfig(ModifyAutoBackupConfigRequest req)
        {
            return InternalRequestAsync<ModifyAutoBackupConfigResponse>(req, "ModifyAutoBackupConfig");
        }

        /// <summary>
        /// 本接口（ModifyAutoBackupConfig）用于修改自动备份配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoBackupConfigRequest"/></param>
        /// <returns><see cref="ModifyAutoBackupConfigResponse"/></returns>
        public ModifyAutoBackupConfigResponse ModifyAutoBackupConfigSync(ModifyAutoBackupConfigRequest req)
        {
            return InternalRequestAsync<ModifyAutoBackupConfigResponse>(req, "ModifyAutoBackupConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyConnectionConfig）用于修改实例的连接配置，包括带宽和最大连接数。
        /// </summary>
        /// <param name="req"><see cref="ModifyConnectionConfigRequest"/></param>
        /// <returns><see cref="ModifyConnectionConfigResponse"/></returns>
        public Task<ModifyConnectionConfigResponse> ModifyConnectionConfig(ModifyConnectionConfigRequest req)
        {
            return InternalRequestAsync<ModifyConnectionConfigResponse>(req, "ModifyConnectionConfig");
        }

        /// <summary>
        /// 本接口（ModifyConnectionConfig）用于修改实例的连接配置，包括带宽和最大连接数。
        /// </summary>
        /// <param name="req"><see cref="ModifyConnectionConfigRequest"/></param>
        /// <returns><see cref="ModifyConnectionConfigResponse"/></returns>
        public ModifyConnectionConfigResponse ModifyConnectionConfigSync(ModifyConnectionConfigRequest req)
        {
            return InternalRequestAsync<ModifyConnectionConfigResponse>(req, "ModifyConnectionConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口(ModifyDBInstanceSecurityGroups)用于修改实例绑定的安全组。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupsResponse"/></returns>
        public Task<ModifyDBInstanceSecurityGroupsResponse> ModifyDBInstanceSecurityGroups(ModifyDBInstanceSecurityGroupsRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSecurityGroupsResponse>(req, "ModifyDBInstanceSecurityGroups");
        }

        /// <summary>
        /// 本接口(ModifyDBInstanceSecurityGroups)用于修改实例绑定的安全组。
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupsResponse"/></returns>
        public ModifyDBInstanceSecurityGroupsResponse ModifyDBInstanceSecurityGroupsSync(ModifyDBInstanceSecurityGroupsRequest req)
        {
            return InternalRequestAsync<ModifyDBInstanceSecurityGroupsResponse>(req, "ModifyDBInstanceSecurityGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyInstance）用于修改实例相关信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public Task<ModifyInstanceResponse> ModifyInstance(ModifyInstanceRequest req)
        {
            return InternalRequestAsync<ModifyInstanceResponse>(req, "ModifyInstance");
        }

        /// <summary>
        /// 本接口（ModifyInstance）用于修改实例相关信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public ModifyInstanceResponse ModifyInstanceSync(ModifyInstanceRequest req)
        {
            return InternalRequestAsync<ModifyInstanceResponse>(req, "ModifyInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyInstanceParams）用于修改实例参数配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceParamsRequest"/></param>
        /// <returns><see cref="ModifyInstanceParamsResponse"/></returns>
        public Task<ModifyInstanceParamsResponse> ModifyInstanceParams(ModifyInstanceParamsRequest req)
        {
            return InternalRequestAsync<ModifyInstanceParamsResponse>(req, "ModifyInstanceParams");
        }

        /// <summary>
        /// 本接口（ModifyInstanceParams）用于修改实例参数配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceParamsRequest"/></param>
        /// <returns><see cref="ModifyInstanceParamsResponse"/></returns>
        public ModifyInstanceParamsResponse ModifyInstanceParamsSync(ModifyInstanceParamsRequest req)
        {
            return InternalRequestAsync<ModifyInstanceParamsResponse>(req, "ModifyInstanceParams")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyMaintenanceWindow）修改实例维护时间窗时间。
        /// </summary>
        /// <param name="req"><see cref="ModifyMaintenanceWindowRequest"/></param>
        /// <returns><see cref="ModifyMaintenanceWindowResponse"/></returns>
        public Task<ModifyMaintenanceWindowResponse> ModifyMaintenanceWindow(ModifyMaintenanceWindowRequest req)
        {
            return InternalRequestAsync<ModifyMaintenanceWindowResponse>(req, "ModifyMaintenanceWindow");
        }

        /// <summary>
        /// 本接口（ModifyMaintenanceWindow）修改实例维护时间窗时间。
        /// </summary>
        /// <param name="req"><see cref="ModifyMaintenanceWindowRequest"/></param>
        /// <returns><see cref="ModifyMaintenanceWindowResponse"/></returns>
        public ModifyMaintenanceWindowResponse ModifyMaintenanceWindowSync(ModifyMaintenanceWindowRequest req)
        {
            return InternalRequestAsync<ModifyMaintenanceWindowResponse>(req, "ModifyMaintenanceWindow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyNetworkConfig）用于修改实例网络配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkConfigRequest"/></param>
        /// <returns><see cref="ModifyNetworkConfigResponse"/></returns>
        public Task<ModifyNetworkConfigResponse> ModifyNetworkConfig(ModifyNetworkConfigRequest req)
        {
            return InternalRequestAsync<ModifyNetworkConfigResponse>(req, "ModifyNetworkConfig");
        }

        /// <summary>
        /// 本接口（ModifyNetworkConfig）用于修改实例网络配置。
        /// </summary>
        /// <param name="req"><see cref="ModifyNetworkConfigRequest"/></param>
        /// <returns><see cref="ModifyNetworkConfigResponse"/></returns>
        public ModifyNetworkConfigResponse ModifyNetworkConfigSync(ModifyNetworkConfigRequest req)
        {
            return InternalRequestAsync<ModifyNetworkConfigResponse>(req, "ModifyNetworkConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（RenewInstance）用于为包年包月计费实例续费。
        /// </summary>
        /// <param name="req"><see cref="RenewInstanceRequest"/></param>
        /// <returns><see cref="RenewInstanceResponse"/></returns>
        public Task<RenewInstanceResponse> RenewInstance(RenewInstanceRequest req)
        {
            return InternalRequestAsync<RenewInstanceResponse>(req, "RenewInstance");
        }

        /// <summary>
        /// 本接口（RenewInstance）用于为包年包月计费实例续费。
        /// </summary>
        /// <param name="req"><see cref="RenewInstanceRequest"/></param>
        /// <returns><see cref="RenewInstanceResponse"/></returns>
        public RenewInstanceResponse RenewInstanceSync(RenewInstanceRequest req)
        {
            return InternalRequestAsync<RenewInstanceResponse>(req, "RenewInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ResetPassword）用于重置数据库访问密码。
        /// </summary>
        /// <param name="req"><see cref="ResetPasswordRequest"/></param>
        /// <returns><see cref="ResetPasswordResponse"/></returns>
        public Task<ResetPasswordResponse> ResetPassword(ResetPasswordRequest req)
        {
            return InternalRequestAsync<ResetPasswordResponse>(req, "ResetPassword");
        }

        /// <summary>
        /// 本接口（ResetPassword）用于重置数据库访问密码。
        /// </summary>
        /// <param name="req"><see cref="ResetPasswordRequest"/></param>
        /// <returns><see cref="ResetPasswordResponse"/></returns>
        public ResetPasswordResponse ResetPasswordSync(ResetPasswordRequest req)
        {
            return InternalRequestAsync<ResetPasswordResponse>(req, "ResetPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（StartUpInstance）用于按量计费实例解隔离
        /// </summary>
        /// <param name="req"><see cref="StartUpInstanceRequest"/></param>
        /// <returns><see cref="StartUpInstanceResponse"/></returns>
        public Task<StartUpInstanceResponse> StartUpInstance(StartUpInstanceRequest req)
        {
            return InternalRequestAsync<StartUpInstanceResponse>(req, "StartUpInstance");
        }

        /// <summary>
        /// 本接口（StartUpInstance）用于按量计费实例解隔离
        /// </summary>
        /// <param name="req"><see cref="StartUpInstanceRequest"/></param>
        /// <returns><see cref="StartUpInstanceResponse"/></returns>
        public StartUpInstanceResponse StartUpInstanceSync(StartUpInstanceRequest req)
        {
            return InternalRequestAsync<StartUpInstanceResponse>(req, "StartUpInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（UpgradeInstance）用于对实例进行配置变更。
        /// </summary>
        /// <param name="req"><see cref="UpgradeInstanceRequest"/></param>
        /// <returns><see cref="UpgradeInstanceResponse"/></returns>
        public Task<UpgradeInstanceResponse> UpgradeInstance(UpgradeInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeInstanceResponse>(req, "UpgradeInstance");
        }

        /// <summary>
        /// 本接口（UpgradeInstance）用于对实例进行配置变更。
        /// </summary>
        /// <param name="req"><see cref="UpgradeInstanceRequest"/></param>
        /// <returns><see cref="UpgradeInstanceResponse"/></returns>
        public UpgradeInstanceResponse UpgradeInstanceSync(UpgradeInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeInstanceResponse>(req, "UpgradeInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}

/*
 * Copyright (c) 2018 Tencent. All Rights Reserved.
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

namespace TencentCloud.Dlc.V20210125
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Dlc.V20210125.Models;

   public class DlcClient : AbstractClient{

       private const string endpoint = "dlc.tencentcloudapi.com";
       private const string version = "2021-01-25";
       private const string sdkVersion = "SDK_NET_3.0.1483";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DlcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public DlcClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// DMS元数据新增分区
        /// </summary>
        /// <param name="req"><see cref="AddDMSPartitionsRequest"/></param>
        /// <returns><see cref="AddDMSPartitionsResponse"/></returns>
        public Task<AddDMSPartitionsResponse> AddDMSPartitions(AddDMSPartitionsRequest req)
        {
            return InternalRequestAsync<AddDMSPartitionsResponse>(req, "AddDMSPartitions");
        }

        /// <summary>
        /// DMS元数据新增分区
        /// </summary>
        /// <param name="req"><see cref="AddDMSPartitionsRequest"/></param>
        /// <returns><see cref="AddDMSPartitionsResponse"/></returns>
        public AddDMSPartitionsResponse AddDMSPartitionsSync(AddDMSPartitionsRequest req)
        {
            return InternalRequestAsync<AddDMSPartitionsResponse>(req, "AddDMSPartitions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加数据优化资源
        /// </summary>
        /// <param name="req"><see cref="AddOptimizerEnginesRequest"/></param>
        /// <returns><see cref="AddOptimizerEnginesResponse"/></returns>
        public Task<AddOptimizerEnginesResponse> AddOptimizerEngines(AddOptimizerEnginesRequest req)
        {
            return InternalRequestAsync<AddOptimizerEnginesResponse>(req, "AddOptimizerEngines");
        }

        /// <summary>
        /// 添加数据优化资源
        /// </summary>
        /// <param name="req"><see cref="AddOptimizerEnginesRequest"/></param>
        /// <returns><see cref="AddOptimizerEnginesResponse"/></returns>
        public AddOptimizerEnginesResponse AddOptimizerEnginesSync(AddOptimizerEnginesRequest req)
        {
            return InternalRequestAsync<AddOptimizerEnginesResponse>(req, "AddOptimizerEngines")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加用户到工作组
        /// </summary>
        /// <param name="req"><see cref="AddUsersToWorkGroupRequest"/></param>
        /// <returns><see cref="AddUsersToWorkGroupResponse"/></returns>
        public Task<AddUsersToWorkGroupResponse> AddUsersToWorkGroup(AddUsersToWorkGroupRequest req)
        {
            return InternalRequestAsync<AddUsersToWorkGroupResponse>(req, "AddUsersToWorkGroup");
        }

        /// <summary>
        /// 添加用户到工作组
        /// </summary>
        /// <param name="req"><see cref="AddUsersToWorkGroupRequest"/></param>
        /// <returns><see cref="AddUsersToWorkGroupResponse"/></returns>
        public AddUsersToWorkGroupResponse AddUsersToWorkGroupSync(AddUsersToWorkGroupRequest req)
        {
            return InternalRequestAsync<AddUsersToWorkGroupResponse>(req, "AddUsersToWorkGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DMS元数据更新库
        /// </summary>
        /// <param name="req"><see cref="AlterDMSDatabaseRequest"/></param>
        /// <returns><see cref="AlterDMSDatabaseResponse"/></returns>
        public Task<AlterDMSDatabaseResponse> AlterDMSDatabase(AlterDMSDatabaseRequest req)
        {
            return InternalRequestAsync<AlterDMSDatabaseResponse>(req, "AlterDMSDatabase");
        }

        /// <summary>
        /// DMS元数据更新库
        /// </summary>
        /// <param name="req"><see cref="AlterDMSDatabaseRequest"/></param>
        /// <returns><see cref="AlterDMSDatabaseResponse"/></returns>
        public AlterDMSDatabaseResponse AlterDMSDatabaseSync(AlterDMSDatabaseRequest req)
        {
            return InternalRequestAsync<AlterDMSDatabaseResponse>(req, "AlterDMSDatabase")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DMS元数据更新分区
        /// </summary>
        /// <param name="req"><see cref="AlterDMSPartitionRequest"/></param>
        /// <returns><see cref="AlterDMSPartitionResponse"/></returns>
        public Task<AlterDMSPartitionResponse> AlterDMSPartition(AlterDMSPartitionRequest req)
        {
            return InternalRequestAsync<AlterDMSPartitionResponse>(req, "AlterDMSPartition");
        }

        /// <summary>
        /// DMS元数据更新分区
        /// </summary>
        /// <param name="req"><see cref="AlterDMSPartitionRequest"/></param>
        /// <returns><see cref="AlterDMSPartitionResponse"/></returns>
        public AlterDMSPartitionResponse AlterDMSPartitionSync(AlterDMSPartitionRequest req)
        {
            return InternalRequestAsync<AlterDMSPartitionResponse>(req, "AlterDMSPartition")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DMS元数据更新表
        /// </summary>
        /// <param name="req"><see cref="AlterDMSTableRequest"/></param>
        /// <returns><see cref="AlterDMSTableResponse"/></returns>
        public Task<AlterDMSTableResponse> AlterDMSTable(AlterDMSTableRequest req)
        {
            return InternalRequestAsync<AlterDMSTableResponse>(req, "AlterDMSTable");
        }

        /// <summary>
        /// DMS元数据更新表
        /// </summary>
        /// <param name="req"><see cref="AlterDMSTableRequest"/></param>
        /// <returns><see cref="AlterDMSTableResponse"/></returns>
        public AlterDMSTableResponse AlterDMSTableSync(AlterDMSTableRequest req)
        {
            return InternalRequestAsync<AlterDMSTableResponse>(req, "AlterDMSTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改表备注
        /// </summary>
        /// <param name="req"><see cref="AlterTableCommentRequest"/></param>
        /// <returns><see cref="AlterTableCommentResponse"/></returns>
        public Task<AlterTableCommentResponse> AlterTableComment(AlterTableCommentRequest req)
        {
            return InternalRequestAsync<AlterTableCommentResponse>(req, "AlterTableComment");
        }

        /// <summary>
        /// 修改表备注
        /// </summary>
        /// <param name="req"><see cref="AlterTableCommentRequest"/></param>
        /// <returns><see cref="AlterTableCommentResponse"/></returns>
        public AlterTableCommentResponse AlterTableCommentSync(AlterTableCommentRequest req)
        {
            return InternalRequestAsync<AlterTableCommentResponse>(req, "AlterTableComment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 分配原生表表属性
        /// </summary>
        /// <param name="req"><see cref="AssignMangedTablePropertiesRequest"/></param>
        /// <returns><see cref="AssignMangedTablePropertiesResponse"/></returns>
        public Task<AssignMangedTablePropertiesResponse> AssignMangedTableProperties(AssignMangedTablePropertiesRequest req)
        {
            return InternalRequestAsync<AssignMangedTablePropertiesResponse>(req, "AssignMangedTableProperties");
        }

        /// <summary>
        /// 分配原生表表属性
        /// </summary>
        /// <param name="req"><see cref="AssignMangedTablePropertiesRequest"/></param>
        /// <returns><see cref="AssignMangedTablePropertiesResponse"/></returns>
        public AssignMangedTablePropertiesResponse AssignMangedTablePropertiesSync(AssignMangedTablePropertiesRequest req)
        {
            return InternalRequestAsync<AssignMangedTablePropertiesResponse>(req, "AssignMangedTableProperties")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 绑定数据源和队列
        /// </summary>
        /// <param name="req"><see cref="AssociateDatasourceHouseRequest"/></param>
        /// <returns><see cref="AssociateDatasourceHouseResponse"/></returns>
        public Task<AssociateDatasourceHouseResponse> AssociateDatasourceHouse(AssociateDatasourceHouseRequest req)
        {
            return InternalRequestAsync<AssociateDatasourceHouseResponse>(req, "AssociateDatasourceHouse");
        }

        /// <summary>
        /// 绑定数据源和队列
        /// </summary>
        /// <param name="req"><see cref="AssociateDatasourceHouseRequest"/></param>
        /// <returns><see cref="AssociateDatasourceHouseResponse"/></returns>
        public AssociateDatasourceHouseResponse AssociateDatasourceHouseSync(AssociateDatasourceHouseRequest req)
        {
            return InternalRequestAsync<AssociateDatasourceHouseResponse>(req, "AssociateDatasourceHouse")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 绑定数据脱敏策略
        /// </summary>
        /// <param name="req"><see cref="AttachDataMaskPolicyRequest"/></param>
        /// <returns><see cref="AttachDataMaskPolicyResponse"/></returns>
        public Task<AttachDataMaskPolicyResponse> AttachDataMaskPolicy(AttachDataMaskPolicyRequest req)
        {
            return InternalRequestAsync<AttachDataMaskPolicyResponse>(req, "AttachDataMaskPolicy");
        }

        /// <summary>
        /// 绑定数据脱敏策略
        /// </summary>
        /// <param name="req"><see cref="AttachDataMaskPolicyRequest"/></param>
        /// <returns><see cref="AttachDataMaskPolicyResponse"/></returns>
        public AttachDataMaskPolicyResponse AttachDataMaskPolicySync(AttachDataMaskPolicyRequest req)
        {
            return InternalRequestAsync<AttachDataMaskPolicyResponse>(req, "AttachDataMaskPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 绑定鉴权策略到用户
        /// </summary>
        /// <param name="req"><see cref="AttachUserPolicyRequest"/></param>
        /// <returns><see cref="AttachUserPolicyResponse"/></returns>
        public Task<AttachUserPolicyResponse> AttachUserPolicy(AttachUserPolicyRequest req)
        {
            return InternalRequestAsync<AttachUserPolicyResponse>(req, "AttachUserPolicy");
        }

        /// <summary>
        /// 绑定鉴权策略到用户
        /// </summary>
        /// <param name="req"><see cref="AttachUserPolicyRequest"/></param>
        /// <returns><see cref="AttachUserPolicyResponse"/></returns>
        public AttachUserPolicyResponse AttachUserPolicySync(AttachUserPolicyRequest req)
        {
            return InternalRequestAsync<AttachUserPolicyResponse>(req, "AttachUserPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 绑定鉴权策略到工作组
        /// </summary>
        /// <param name="req"><see cref="AttachWorkGroupPolicyRequest"/></param>
        /// <returns><see cref="AttachWorkGroupPolicyResponse"/></returns>
        public Task<AttachWorkGroupPolicyResponse> AttachWorkGroupPolicy(AttachWorkGroupPolicyRequest req)
        {
            return InternalRequestAsync<AttachWorkGroupPolicyResponse>(req, "AttachWorkGroupPolicy");
        }

        /// <summary>
        /// 绑定鉴权策略到工作组
        /// </summary>
        /// <param name="req"><see cref="AttachWorkGroupPolicyRequest"/></param>
        /// <returns><see cref="AttachWorkGroupPolicyResponse"/></returns>
        public AttachWorkGroupPolicyResponse AttachWorkGroupPolicySync(AttachWorkGroupPolicyRequest req)
        {
            return InternalRequestAsync<AttachWorkGroupPolicyResponse>(req, "AttachWorkGroupPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 绑定工作组到用户
        /// </summary>
        /// <param name="req"><see cref="BindWorkGroupsToUserRequest"/></param>
        /// <returns><see cref="BindWorkGroupsToUserResponse"/></returns>
        public Task<BindWorkGroupsToUserResponse> BindWorkGroupsToUser(BindWorkGroupsToUserRequest req)
        {
            return InternalRequestAsync<BindWorkGroupsToUserResponse>(req, "BindWorkGroupsToUser");
        }

        /// <summary>
        /// 绑定工作组到用户
        /// </summary>
        /// <param name="req"><see cref="BindWorkGroupsToUserRequest"/></param>
        /// <returns><see cref="BindWorkGroupsToUserResponse"/></returns>
        public BindWorkGroupsToUserResponse BindWorkGroupsToUserSync(BindWorkGroupsToUserRequest req)
        {
            return InternalRequestAsync<BindWorkGroupsToUserResponse>(req, "BindWorkGroupsToUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CancelNotebookSessionStatement）用于取消session中执行的任务
        /// </summary>
        /// <param name="req"><see cref="CancelNotebookSessionStatementRequest"/></param>
        /// <returns><see cref="CancelNotebookSessionStatementResponse"/></returns>
        public Task<CancelNotebookSessionStatementResponse> CancelNotebookSessionStatement(CancelNotebookSessionStatementRequest req)
        {
            return InternalRequestAsync<CancelNotebookSessionStatementResponse>(req, "CancelNotebookSessionStatement");
        }

        /// <summary>
        /// 本接口（CancelNotebookSessionStatement）用于取消session中执行的任务
        /// </summary>
        /// <param name="req"><see cref="CancelNotebookSessionStatementRequest"/></param>
        /// <returns><see cref="CancelNotebookSessionStatementResponse"/></returns>
        public CancelNotebookSessionStatementResponse CancelNotebookSessionStatementSync(CancelNotebookSessionStatementRequest req)
        {
            return InternalRequestAsync<CancelNotebookSessionStatementResponse>(req, "CancelNotebookSessionStatement")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CancelNotebookSessionStatementBatch）用于批量取消Session 中执行的任务
        /// </summary>
        /// <param name="req"><see cref="CancelNotebookSessionStatementBatchRequest"/></param>
        /// <returns><see cref="CancelNotebookSessionStatementBatchResponse"/></returns>
        public Task<CancelNotebookSessionStatementBatchResponse> CancelNotebookSessionStatementBatch(CancelNotebookSessionStatementBatchRequest req)
        {
            return InternalRequestAsync<CancelNotebookSessionStatementBatchResponse>(req, "CancelNotebookSessionStatementBatch");
        }

        /// <summary>
        /// 本接口（CancelNotebookSessionStatementBatch）用于批量取消Session 中执行的任务
        /// </summary>
        /// <param name="req"><see cref="CancelNotebookSessionStatementBatchRequest"/></param>
        /// <returns><see cref="CancelNotebookSessionStatementBatchResponse"/></returns>
        public CancelNotebookSessionStatementBatchResponse CancelNotebookSessionStatementBatchSync(CancelNotebookSessionStatementBatchRequest req)
        {
            return InternalRequestAsync<CancelNotebookSessionStatementBatchResponse>(req, "CancelNotebookSessionStatementBatch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据任务ID取消正在运行的Ray任务
        /// </summary>
        /// <param name="req"><see cref="CancelRayJobRequest"/></param>
        /// <returns><see cref="CancelRayJobResponse"/></returns>
        public Task<CancelRayJobResponse> CancelRayJob(CancelRayJobRequest req)
        {
            return InternalRequestAsync<CancelRayJobResponse>(req, "CancelRayJob");
        }

        /// <summary>
        /// 根据任务ID取消正在运行的Ray任务
        /// </summary>
        /// <param name="req"><see cref="CancelRayJobRequest"/></param>
        /// <returns><see cref="CancelRayJobResponse"/></returns>
        public CancelRayJobResponse CancelRayJobSync(CancelRayJobRequest req)
        {
            return InternalRequestAsync<CancelRayJobResponse>(req, "CancelRayJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CancelSparkSessionBatchSQL）用于取消Spark SQL批任务。
        /// </summary>
        /// <param name="req"><see cref="CancelSparkSessionBatchSQLRequest"/></param>
        /// <returns><see cref="CancelSparkSessionBatchSQLResponse"/></returns>
        public Task<CancelSparkSessionBatchSQLResponse> CancelSparkSessionBatchSQL(CancelSparkSessionBatchSQLRequest req)
        {
            return InternalRequestAsync<CancelSparkSessionBatchSQLResponse>(req, "CancelSparkSessionBatchSQL");
        }

        /// <summary>
        /// 本接口（CancelSparkSessionBatchSQL）用于取消Spark SQL批任务。
        /// </summary>
        /// <param name="req"><see cref="CancelSparkSessionBatchSQLRequest"/></param>
        /// <returns><see cref="CancelSparkSessionBatchSQLResponse"/></returns>
        public CancelSparkSessionBatchSQLResponse CancelSparkSessionBatchSQLSync(CancelSparkSessionBatchSQLRequest req)
        {
            return InternalRequestAsync<CancelSparkSessionBatchSQLResponse>(req, "CancelSparkSessionBatchSQL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CancelTask），用于取消任务
        /// </summary>
        /// <param name="req"><see cref="CancelTaskRequest"/></param>
        /// <returns><see cref="CancelTaskResponse"/></returns>
        public Task<CancelTaskResponse> CancelTask(CancelTaskRequest req)
        {
            return InternalRequestAsync<CancelTaskResponse>(req, "CancelTask");
        }

        /// <summary>
        /// 本接口（CancelTask），用于取消任务
        /// </summary>
        /// <param name="req"><see cref="CancelTaskRequest"/></param>
        /// <returns><see cref="CancelTaskResponse"/></returns>
        public CancelTaskResponse CancelTaskSync(CancelTaskRequest req)
        {
            return InternalRequestAsync<CancelTaskResponse>(req, "CancelTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量取消任务
        /// </summary>
        /// <param name="req"><see cref="CancelTasksRequest"/></param>
        /// <returns><see cref="CancelTasksResponse"/></returns>
        public Task<CancelTasksResponse> CancelTasks(CancelTasksRequest req)
        {
            return InternalRequestAsync<CancelTasksResponse>(req, "CancelTasks");
        }

        /// <summary>
        /// 批量取消任务
        /// </summary>
        /// <param name="req"><see cref="CancelTasksRequest"/></param>
        /// <returns><see cref="CancelTasksResponse"/></returns>
        public CancelTasksResponse CancelTasksSync(CancelTasksRequest req)
        {
            return InternalRequestAsync<CancelTasksResponse>(req, "CancelTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CheckDataEngineConfigPairsValidity）用于检查引擎用户自定义参数的有效性
        /// </summary>
        /// <param name="req"><see cref="CheckDataEngineConfigPairsValidityRequest"/></param>
        /// <returns><see cref="CheckDataEngineConfigPairsValidityResponse"/></returns>
        public Task<CheckDataEngineConfigPairsValidityResponse> CheckDataEngineConfigPairsValidity(CheckDataEngineConfigPairsValidityRequest req)
        {
            return InternalRequestAsync<CheckDataEngineConfigPairsValidityResponse>(req, "CheckDataEngineConfigPairsValidity");
        }

        /// <summary>
        /// 本接口（CheckDataEngineConfigPairsValidity）用于检查引擎用户自定义参数的有效性
        /// </summary>
        /// <param name="req"><see cref="CheckDataEngineConfigPairsValidityRequest"/></param>
        /// <returns><see cref="CheckDataEngineConfigPairsValidityResponse"/></returns>
        public CheckDataEngineConfigPairsValidityResponse CheckDataEngineConfigPairsValiditySync(CheckDataEngineConfigPairsValidityRequest req)
        {
            return InternalRequestAsync<CheckDataEngineConfigPairsValidityResponse>(req, "CheckDataEngineConfigPairsValidity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CheckDataEngineImageCanBeRollback）用于查看集群是否能回滚。
        /// </summary>
        /// <param name="req"><see cref="CheckDataEngineImageCanBeRollbackRequest"/></param>
        /// <returns><see cref="CheckDataEngineImageCanBeRollbackResponse"/></returns>
        public Task<CheckDataEngineImageCanBeRollbackResponse> CheckDataEngineImageCanBeRollback(CheckDataEngineImageCanBeRollbackRequest req)
        {
            return InternalRequestAsync<CheckDataEngineImageCanBeRollbackResponse>(req, "CheckDataEngineImageCanBeRollback");
        }

        /// <summary>
        /// 本接口（CheckDataEngineImageCanBeRollback）用于查看集群是否能回滚。
        /// </summary>
        /// <param name="req"><see cref="CheckDataEngineImageCanBeRollbackRequest"/></param>
        /// <returns><see cref="CheckDataEngineImageCanBeRollbackResponse"/></returns>
        public CheckDataEngineImageCanBeRollbackResponse CheckDataEngineImageCanBeRollbackSync(CheckDataEngineImageCanBeRollbackRequest req)
        {
            return InternalRequestAsync<CheckDataEngineImageCanBeRollbackResponse>(req, "CheckDataEngineImageCanBeRollback")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CheckDataEngineImageCanBeUpgrade）用于查看集群镜像是否能够升级。
        /// </summary>
        /// <param name="req"><see cref="CheckDataEngineImageCanBeUpgradeRequest"/></param>
        /// <returns><see cref="CheckDataEngineImageCanBeUpgradeResponse"/></returns>
        public Task<CheckDataEngineImageCanBeUpgradeResponse> CheckDataEngineImageCanBeUpgrade(CheckDataEngineImageCanBeUpgradeRequest req)
        {
            return InternalRequestAsync<CheckDataEngineImageCanBeUpgradeResponse>(req, "CheckDataEngineImageCanBeUpgrade");
        }

        /// <summary>
        /// 本接口（CheckDataEngineImageCanBeUpgrade）用于查看集群镜像是否能够升级。
        /// </summary>
        /// <param name="req"><see cref="CheckDataEngineImageCanBeUpgradeRequest"/></param>
        /// <returns><see cref="CheckDataEngineImageCanBeUpgradeResponse"/></returns>
        public CheckDataEngineImageCanBeUpgradeResponse CheckDataEngineImageCanBeUpgradeSync(CheckDataEngineImageCanBeUpgradeRequest req)
        {
            return InternalRequestAsync<CheckDataEngineImageCanBeUpgradeResponse>(req, "CheckDataEngineImageCanBeUpgrade")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 元数据锁检查
        /// </summary>
        /// <param name="req"><see cref="CheckLockMetaDataRequest"/></param>
        /// <returns><see cref="CheckLockMetaDataResponse"/></returns>
        public Task<CheckLockMetaDataResponse> CheckLockMetaData(CheckLockMetaDataRequest req)
        {
            return InternalRequestAsync<CheckLockMetaDataResponse>(req, "CheckLockMetaData");
        }

        /// <summary>
        /// 元数据锁检查
        /// </summary>
        /// <param name="req"><see cref="CheckLockMetaDataRequest"/></param>
        /// <returns><see cref="CheckLockMetaDataResponse"/></returns>
        public CheckLockMetaDataResponse CheckLockMetaDataSync(CheckLockMetaDataRequest req)
        {
            return InternalRequestAsync<CheckLockMetaDataResponse>(req, "CheckLockMetaData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 变配校验：判断用户的目标配置是否可以执行变配。校验逻辑：对于缩容场景（目标值 < 当前值），检查 default 队列的 min 值是否足够承受缩容差值。
        /// </summary>
        /// <param name="req"><see cref="CheckModifyPartitionRequest"/></param>
        /// <returns><see cref="CheckModifyPartitionResponse"/></returns>
        public Task<CheckModifyPartitionResponse> CheckModifyPartition(CheckModifyPartitionRequest req)
        {
            return InternalRequestAsync<CheckModifyPartitionResponse>(req, "CheckModifyPartition");
        }

        /// <summary>
        /// 变配校验：判断用户的目标配置是否可以执行变配。校验逻辑：对于缩容场景（目标值 < 当前值），检查 default 队列的 min 值是否足够承受缩容差值。
        /// </summary>
        /// <param name="req"><see cref="CheckModifyPartitionRequest"/></param>
        /// <returns><see cref="CheckModifyPartitionResponse"/></returns>
        public CheckModifyPartitionResponse CheckModifyPartitionSync(CheckModifyPartitionRequest req)
        {
            return InternalRequestAsync<CheckModifyPartitionResponse>(req, "CheckModifyPartition")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 资源队列名称合法性检测：校验队列名称是否合法，包括非空校验、格式校验（以小写字母开头，只允许小写字母、数字和连字符，长度1~11）和同分区下重名校验。
        /// </summary>
        /// <param name="req"><see cref="CheckQueueNameRequest"/></param>
        /// <returns><see cref="CheckQueueNameResponse"/></returns>
        public Task<CheckQueueNameResponse> CheckQueueName(CheckQueueNameRequest req)
        {
            return InternalRequestAsync<CheckQueueNameResponse>(req, "CheckQueueName");
        }

        /// <summary>
        /// 资源队列名称合法性检测：校验队列名称是否合法，包括非空校验、格式校验（以小写字母开头，只允许小写字母、数字和连字符，长度1~11）和同分区下重名校验。
        /// </summary>
        /// <param name="req"><see cref="CheckQueueNameRequest"/></param>
        /// <returns><see cref="CheckQueueNameResponse"/></returns>
        public CheckQueueNameResponse CheckQueueNameSync(CheckQueueNameRequest req)
        {
            return InternalRequestAsync<CheckQueueNameResponse>(req, "CheckQueueName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 校验资源名称合法性
        /// </summary>
        /// <param name="req"><see cref="CheckResourceNameRequest"/></param>
        /// <returns><see cref="CheckResourceNameResponse"/></returns>
        public Task<CheckResourceNameResponse> CheckResourceName(CheckResourceNameRequest req)
        {
            return InternalRequestAsync<CheckResourceNameResponse>(req, "CheckResourceName");
        }

        /// <summary>
        /// 校验资源名称合法性
        /// </summary>
        /// <param name="req"><see cref="CheckResourceNameRequest"/></param>
        /// <returns><see cref="CheckResourceNameResponse"/></returns>
        public CheckResourceNameResponse CheckResourceNameSync(CheckResourceNameRequest req)
        {
            return InternalRequestAsync<CheckResourceNameResponse>(req, "CheckResourceName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 复制一份已有的作业配置
        /// </summary>
        /// <param name="req"><see cref="CopyJobSpecRequest"/></param>
        /// <returns><see cref="CopyJobSpecResponse"/></returns>
        public Task<CopyJobSpecResponse> CopyJobSpec(CopyJobSpecRequest req)
        {
            return InternalRequestAsync<CopyJobSpecResponse>(req, "CopyJobSpec");
        }

        /// <summary>
        /// 复制一份已有的作业配置
        /// </summary>
        /// <param name="req"><see cref="CopyJobSpecRequest"/></param>
        /// <returns><see cref="CopyJobSpecResponse"/></returns>
        public CopyJobSpecResponse CopyJobSpecSync(CopyJobSpecRequest req)
        {
            return InternalRequestAsync<CopyJobSpecResponse>(req, "CopyJobSpec")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（CreateCHDFSBindingProduct）用于创建元数据加速桶和产品绑定关系
        /// </summary>
        /// <param name="req"><see cref="CreateCHDFSBindingProductRequest"/></param>
        /// <returns><see cref="CreateCHDFSBindingProductResponse"/></returns>
        public Task<CreateCHDFSBindingProductResponse> CreateCHDFSBindingProduct(CreateCHDFSBindingProductRequest req)
        {
            return InternalRequestAsync<CreateCHDFSBindingProductResponse>(req, "CreateCHDFSBindingProduct");
        }

        /// <summary>
        /// 此接口（CreateCHDFSBindingProduct）用于创建元数据加速桶和产品绑定关系
        /// </summary>
        /// <param name="req"><see cref="CreateCHDFSBindingProductRequest"/></param>
        /// <returns><see cref="CreateCHDFSBindingProductResponse"/></returns>
        public CreateCHDFSBindingProductResponse CreateCHDFSBindingProductSync(CreateCHDFSBindingProductRequest req)
        {
            return InternalRequestAsync<CreateCHDFSBindingProductResponse>(req, "CreateCHDFSBindingProduct")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建集群组
        /// </summary>
        /// <param name="req"><see cref="CreateClusterGroupRequest"/></param>
        /// <returns><see cref="CreateClusterGroupResponse"/></returns>
        public Task<CreateClusterGroupResponse> CreateClusterGroup(CreateClusterGroupRequest req)
        {
            return InternalRequestAsync<CreateClusterGroupResponse>(req, "CreateClusterGroup");
        }

        /// <summary>
        /// 创建集群组
        /// </summary>
        /// <param name="req"><see cref="CreateClusterGroupRequest"/></param>
        /// <returns><see cref="CreateClusterGroupResponse"/></returns>
        public CreateClusterGroupResponse CreateClusterGroupSync(CreateClusterGroupRequest req)
        {
            return InternalRequestAsync<CreateClusterGroupResponse>(req, "CreateClusterGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DMS元数据创建库
        /// </summary>
        /// <param name="req"><see cref="CreateDMSDatabaseRequest"/></param>
        /// <returns><see cref="CreateDMSDatabaseResponse"/></returns>
        public Task<CreateDMSDatabaseResponse> CreateDMSDatabase(CreateDMSDatabaseRequest req)
        {
            return InternalRequestAsync<CreateDMSDatabaseResponse>(req, "CreateDMSDatabase");
        }

        /// <summary>
        /// DMS元数据创建库
        /// </summary>
        /// <param name="req"><see cref="CreateDMSDatabaseRequest"/></param>
        /// <returns><see cref="CreateDMSDatabaseResponse"/></returns>
        public CreateDMSDatabaseResponse CreateDMSDatabaseSync(CreateDMSDatabaseRequest req)
        {
            return InternalRequestAsync<CreateDMSDatabaseResponse>(req, "CreateDMSDatabase")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DMS元数据创建表
        /// </summary>
        /// <param name="req"><see cref="CreateDMSTableRequest"/></param>
        /// <returns><see cref="CreateDMSTableResponse"/></returns>
        public Task<CreateDMSTableResponse> CreateDMSTable(CreateDMSTableRequest req)
        {
            return InternalRequestAsync<CreateDMSTableResponse>(req, "CreateDMSTable");
        }

        /// <summary>
        /// DMS元数据创建表
        /// </summary>
        /// <param name="req"><see cref="CreateDMSTableRequest"/></param>
        /// <returns><see cref="CreateDMSTableResponse"/></returns>
        public CreateDMSTableResponse CreateDMSTableSync(CreateDMSTableRequest req)
        {
            return InternalRequestAsync<CreateDMSTableResponse>(req, "CreateDMSTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 为用户创建数据引擎
        /// </summary>
        /// <param name="req"><see cref="CreateDataEngineRequest"/></param>
        /// <returns><see cref="CreateDataEngineResponse"/></returns>
        public Task<CreateDataEngineResponse> CreateDataEngine(CreateDataEngineRequest req)
        {
            return InternalRequestAsync<CreateDataEngineResponse>(req, "CreateDataEngine");
        }

        /// <summary>
        /// 为用户创建数据引擎
        /// </summary>
        /// <param name="req"><see cref="CreateDataEngineRequest"/></param>
        /// <returns><see cref="CreateDataEngineResponse"/></returns>
        public CreateDataEngineResponse CreateDataEngineSync(CreateDataEngineRequest req)
        {
            return InternalRequestAsync<CreateDataEngineResponse>(req, "CreateDataEngine")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建数据脱敏策略
        /// </summary>
        /// <param name="req"><see cref="CreateDataMaskStrategyRequest"/></param>
        /// <returns><see cref="CreateDataMaskStrategyResponse"/></returns>
        public Task<CreateDataMaskStrategyResponse> CreateDataMaskStrategy(CreateDataMaskStrategyRequest req)
        {
            return InternalRequestAsync<CreateDataMaskStrategyResponse>(req, "CreateDataMaskStrategy");
        }

        /// <summary>
        /// 创建数据脱敏策略
        /// </summary>
        /// <param name="req"><see cref="CreateDataMaskStrategyRequest"/></param>
        /// <returns><see cref="CreateDataMaskStrategyResponse"/></returns>
        public CreateDataMaskStrategyResponse CreateDataMaskStrategySync(CreateDataMaskStrategyRequest req)
        {
            return InternalRequestAsync<CreateDataMaskStrategyResponse>(req, "CreateDataMaskStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateDatabase）用于生成建库SQL语句。
        /// </summary>
        /// <param name="req"><see cref="CreateDatabaseRequest"/></param>
        /// <returns><see cref="CreateDatabaseResponse"/></returns>
        public Task<CreateDatabaseResponse> CreateDatabase(CreateDatabaseRequest req)
        {
            return InternalRequestAsync<CreateDatabaseResponse>(req, "CreateDatabase");
        }

        /// <summary>
        /// 本接口（CreateDatabase）用于生成建库SQL语句。
        /// </summary>
        /// <param name="req"><see cref="CreateDatabaseRequest"/></param>
        /// <returns><see cref="CreateDatabaseResponse"/></returns>
        public CreateDatabaseResponse CreateDatabaseSync(CreateDatabaseRequest req)
        {
            return InternalRequestAsync<CreateDatabaseResponse>(req, "CreateDatabase")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建数据源
        /// </summary>
        /// <param name="req"><see cref="CreateDatasourceConnectionRequest"/></param>
        /// <returns><see cref="CreateDatasourceConnectionResponse"/></returns>
        public Task<CreateDatasourceConnectionResponse> CreateDatasourceConnection(CreateDatasourceConnectionRequest req)
        {
            return InternalRequestAsync<CreateDatasourceConnectionResponse>(req, "CreateDatasourceConnection");
        }

        /// <summary>
        /// 创建数据源
        /// </summary>
        /// <param name="req"><see cref="CreateDatasourceConnectionRequest"/></param>
        /// <returns><see cref="CreateDatasourceConnectionResponse"/></returns>
        public CreateDatasourceConnectionResponse CreateDatasourceConnectionSync(CreateDatasourceConnectionRequest req)
        {
            return InternalRequestAsync<CreateDatasourceConnectionResponse>(req, "CreateDatasourceConnection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（CreateExportTask）用于创建导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateExportTaskRequest"/></param>
        /// <returns><see cref="CreateExportTaskResponse"/></returns>
        public Task<CreateExportTaskResponse> CreateExportTask(CreateExportTaskRequest req)
        {
            return InternalRequestAsync<CreateExportTaskResponse>(req, "CreateExportTask");
        }

        /// <summary>
        /// 该接口（CreateExportTask）用于创建导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateExportTaskRequest"/></param>
        /// <returns><see cref="CreateExportTaskResponse"/></returns>
        public CreateExportTaskResponse CreateExportTaskSync(CreateExportTaskRequest req)
        {
            return InternalRequestAsync<CreateExportTaskResponse>(req, "CreateExportTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（CreateImportTask）用于创建导入任务
        /// </summary>
        /// <param name="req"><see cref="CreateImportTaskRequest"/></param>
        /// <returns><see cref="CreateImportTaskResponse"/></returns>
        public Task<CreateImportTaskResponse> CreateImportTask(CreateImportTaskRequest req)
        {
            return InternalRequestAsync<CreateImportTaskResponse>(req, "CreateImportTask");
        }

        /// <summary>
        /// 该接口（CreateImportTask）用于创建导入任务
        /// </summary>
        /// <param name="req"><see cref="CreateImportTaskRequest"/></param>
        /// <returns><see cref="CreateImportTaskResponse"/></returns>
        public CreateImportTaskResponse CreateImportTaskSync(CreateImportTaskRequest req)
        {
            return InternalRequestAsync<CreateImportTaskResponse>(req, "CreateImportTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建推理模型（模型上传）
        /// </summary>
        /// <param name="req"><see cref="CreateInferenceModelRequest"/></param>
        /// <returns><see cref="CreateInferenceModelResponse"/></returns>
        public Task<CreateInferenceModelResponse> CreateInferenceModel(CreateInferenceModelRequest req)
        {
            return InternalRequestAsync<CreateInferenceModelResponse>(req, "CreateInferenceModel");
        }

        /// <summary>
        /// 创建推理模型（模型上传）
        /// </summary>
        /// <param name="req"><see cref="CreateInferenceModelRequest"/></param>
        /// <returns><see cref="CreateInferenceModelResponse"/></returns>
        public CreateInferenceModelResponse CreateInferenceModelSync(CreateInferenceModelRequest req)
        {
            return InternalRequestAsync<CreateInferenceModelResponse>(req, "CreateInferenceModel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建推理服务（含默认部署）
        /// </summary>
        /// <param name="req"><see cref="CreateInferenceServiceRequest"/></param>
        /// <returns><see cref="CreateInferenceServiceResponse"/></returns>
        public Task<CreateInferenceServiceResponse> CreateInferenceService(CreateInferenceServiceRequest req)
        {
            return InternalRequestAsync<CreateInferenceServiceResponse>(req, "CreateInferenceService");
        }

        /// <summary>
        /// 创建推理服务（含默认部署）
        /// </summary>
        /// <param name="req"><see cref="CreateInferenceServiceRequest"/></param>
        /// <returns><see cref="CreateInferenceServiceResponse"/></returns>
        public CreateInferenceServiceResponse CreateInferenceServiceSync(CreateInferenceServiceRequest req)
        {
            return InternalRequestAsync<CreateInferenceServiceResponse>(req, "CreateInferenceService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建托管存储内表（该接口已废弃）
        /// </summary>
        /// <param name="req"><see cref="CreateInternalTableRequest"/></param>
        /// <returns><see cref="CreateInternalTableResponse"/></returns>
        public Task<CreateInternalTableResponse> CreateInternalTable(CreateInternalTableRequest req)
        {
            return InternalRequestAsync<CreateInternalTableResponse>(req, "CreateInternalTable");
        }

        /// <summary>
        /// 创建托管存储内表（该接口已废弃）
        /// </summary>
        /// <param name="req"><see cref="CreateInternalTableRequest"/></param>
        /// <returns><see cref="CreateInternalTableResponse"/></returns>
        public CreateInternalTableResponse CreateInternalTableSync(CreateInternalTableRequest req)
        {
            return InternalRequestAsync<CreateInternalTableResponse>(req, "CreateInternalTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建作业配置
        /// </summary>
        /// <param name="req"><see cref="CreateJobSpecRequest"/></param>
        /// <returns><see cref="CreateJobSpecResponse"/></returns>
        public Task<CreateJobSpecResponse> CreateJobSpec(CreateJobSpecRequest req)
        {
            return InternalRequestAsync<CreateJobSpecResponse>(req, "CreateJobSpec");
        }

        /// <summary>
        /// 创建作业配置
        /// </summary>
        /// <param name="req"><see cref="CreateJobSpecRequest"/></param>
        /// <returns><see cref="CreateJobSpecResponse"/></returns>
        public CreateJobSpecResponse CreateJobSpecSync(CreateJobSpecRequest req)
        {
            return InternalRequestAsync<CreateJobSpecResponse>(req, "CreateJobSpec")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建实验室
        /// </summary>
        /// <param name="req"><see cref="CreateLabRequest"/></param>
        /// <returns><see cref="CreateLabResponse"/></returns>
        public Task<CreateLabResponse> CreateLab(CreateLabRequest req)
        {
            return InternalRequestAsync<CreateLabResponse>(req, "CreateLab");
        }

        /// <summary>
        /// 创建实验室
        /// </summary>
        /// <param name="req"><see cref="CreateLabRequest"/></param>
        /// <returns><see cref="CreateLabResponse"/></returns>
        public CreateLabResponse CreateLabSync(CreateLabRequest req)
        {
            return InternalRequestAsync<CreateLabResponse>(req, "CreateLab")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateMetaDatabase）用于创建元数据库
        /// </summary>
        /// <param name="req"><see cref="CreateMetaDatabaseRequest"/></param>
        /// <returns><see cref="CreateMetaDatabaseResponse"/></returns>
        public Task<CreateMetaDatabaseResponse> CreateMetaDatabase(CreateMetaDatabaseRequest req)
        {
            return InternalRequestAsync<CreateMetaDatabaseResponse>(req, "CreateMetaDatabase");
        }

        /// <summary>
        /// 本接口（CreateMetaDatabase）用于创建元数据库
        /// </summary>
        /// <param name="req"><see cref="CreateMetaDatabaseRequest"/></param>
        /// <returns><see cref="CreateMetaDatabaseResponse"/></returns>
        public CreateMetaDatabaseResponse CreateMetaDatabaseSync(CreateMetaDatabaseRequest req)
        {
            return InternalRequestAsync<CreateMetaDatabaseResponse>(req, "CreateMetaDatabase")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建模型新版本
        /// </summary>
        /// <param name="req"><see cref="CreateModelVersionRequest"/></param>
        /// <returns><see cref="CreateModelVersionResponse"/></returns>
        public Task<CreateModelVersionResponse> CreateModelVersion(CreateModelVersionRequest req)
        {
            return InternalRequestAsync<CreateModelVersionResponse>(req, "CreateModelVersion");
        }

        /// <summary>
        /// 创建模型新版本
        /// </summary>
        /// <param name="req"><see cref="CreateModelVersionRequest"/></param>
        /// <returns><see cref="CreateModelVersionResponse"/></returns>
        public CreateModelVersionResponse CreateModelVersionSync(CreateModelVersionRequest req)
        {
            return InternalRequestAsync<CreateModelVersionResponse>(req, "CreateModelVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateNotebookSession）用于创建交互式session（notebook）
        /// </summary>
        /// <param name="req"><see cref="CreateNotebookSessionRequest"/></param>
        /// <returns><see cref="CreateNotebookSessionResponse"/></returns>
        public Task<CreateNotebookSessionResponse> CreateNotebookSession(CreateNotebookSessionRequest req)
        {
            return InternalRequestAsync<CreateNotebookSessionResponse>(req, "CreateNotebookSession");
        }

        /// <summary>
        /// 本接口（CreateNotebookSession）用于创建交互式session（notebook）
        /// </summary>
        /// <param name="req"><see cref="CreateNotebookSessionRequest"/></param>
        /// <returns><see cref="CreateNotebookSessionResponse"/></returns>
        public CreateNotebookSessionResponse CreateNotebookSessionSync(CreateNotebookSessionRequest req)
        {
            return InternalRequestAsync<CreateNotebookSessionResponse>(req, "CreateNotebookSession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateNotebookSessionStatement）用于在session中执行代码片段
        /// </summary>
        /// <param name="req"><see cref="CreateNotebookSessionStatementRequest"/></param>
        /// <returns><see cref="CreateNotebookSessionStatementResponse"/></returns>
        public Task<CreateNotebookSessionStatementResponse> CreateNotebookSessionStatement(CreateNotebookSessionStatementRequest req)
        {
            return InternalRequestAsync<CreateNotebookSessionStatementResponse>(req, "CreateNotebookSessionStatement");
        }

        /// <summary>
        /// 本接口（CreateNotebookSessionStatement）用于在session中执行代码片段
        /// </summary>
        /// <param name="req"><see cref="CreateNotebookSessionStatementRequest"/></param>
        /// <returns><see cref="CreateNotebookSessionStatementResponse"/></returns>
        public CreateNotebookSessionStatementResponse CreateNotebookSessionStatementSync(CreateNotebookSessionStatementRequest req)
        {
            return InternalRequestAsync<CreateNotebookSessionStatementResponse>(req, "CreateNotebookSessionStatement")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateNotebookSessionStatementSupportBatchSQL）用于创建交互式session并执行SQL任务
        /// </summary>
        /// <param name="req"><see cref="CreateNotebookSessionStatementSupportBatchSQLRequest"/></param>
        /// <returns><see cref="CreateNotebookSessionStatementSupportBatchSQLResponse"/></returns>
        public Task<CreateNotebookSessionStatementSupportBatchSQLResponse> CreateNotebookSessionStatementSupportBatchSQL(CreateNotebookSessionStatementSupportBatchSQLRequest req)
        {
            return InternalRequestAsync<CreateNotebookSessionStatementSupportBatchSQLResponse>(req, "CreateNotebookSessionStatementSupportBatchSQL");
        }

        /// <summary>
        /// 本接口（CreateNotebookSessionStatementSupportBatchSQL）用于创建交互式session并执行SQL任务
        /// </summary>
        /// <param name="req"><see cref="CreateNotebookSessionStatementSupportBatchSQLRequest"/></param>
        /// <returns><see cref="CreateNotebookSessionStatementSupportBatchSQLResponse"/></returns>
        public CreateNotebookSessionStatementSupportBatchSQLResponse CreateNotebookSessionStatementSupportBatchSQLSync(CreateNotebookSessionStatementSupportBatchSQLRequest req)
        {
            return InternalRequestAsync<CreateNotebookSessionStatementSupportBatchSQLResponse>(req, "CreateNotebookSessionStatementSupportBatchSQL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新增资源包
        /// </summary>
        /// <param name="req"><see cref="CreatePartitionRequest"/></param>
        /// <returns><see cref="CreatePartitionResponse"/></returns>
        public Task<CreatePartitionResponse> CreatePartition(CreatePartitionRequest req)
        {
            return InternalRequestAsync<CreatePartitionResponse>(req, "CreatePartition");
        }

        /// <summary>
        /// 新增资源包
        /// </summary>
        /// <param name="req"><see cref="CreatePartitionRequest"/></param>
        /// <returns><see cref="CreatePartitionResponse"/></returns>
        public CreatePartitionResponse CreatePartitionSync(CreatePartitionRequest req)
        {
            return InternalRequestAsync<CreatePartitionResponse>(req, "CreatePartition")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新增资源队列：在指定分区下创建一个新的资源队列，支持设置队列名称、描述、资源规格列表和队列类型。
        /// </summary>
        /// <param name="req"><see cref="CreatePartitionQueueRequest"/></param>
        /// <returns><see cref="CreatePartitionQueueResponse"/></returns>
        public Task<CreatePartitionQueueResponse> CreatePartitionQueue(CreatePartitionQueueRequest req)
        {
            return InternalRequestAsync<CreatePartitionQueueResponse>(req, "CreatePartitionQueue");
        }

        /// <summary>
        /// 新增资源队列：在指定分区下创建一个新的资源队列，支持设置队列名称、描述、资源规格列表和队列类型。
        /// </summary>
        /// <param name="req"><see cref="CreatePartitionQueueRequest"/></param>
        /// <returns><see cref="CreatePartitionQueueResponse"/></returns>
        public CreatePartitionQueueResponse CreatePartitionQueueSync(CreatePartitionQueueRequest req)
        {
            return InternalRequestAsync<CreatePartitionQueueResponse>(req, "CreatePartitionQueue")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建集群
        /// </summary>
        /// <param name="req"><see cref="CreateRayClusterRequest"/></param>
        /// <returns><see cref="CreateRayClusterResponse"/></returns>
        public Task<CreateRayClusterResponse> CreateRayCluster(CreateRayClusterRequest req)
        {
            return InternalRequestAsync<CreateRayClusterResponse>(req, "CreateRayCluster");
        }

        /// <summary>
        /// 创建集群
        /// </summary>
        /// <param name="req"><see cref="CreateRayClusterRequest"/></param>
        /// <returns><see cref="CreateRayClusterResponse"/></returns>
        public CreateRayClusterResponse CreateRayClusterSync(CreateRayClusterRequest req)
        {
            return InternalRequestAsync<CreateRayClusterResponse>(req, "CreateRayCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建资源配置模板
        /// </summary>
        /// <param name="req"><see cref="CreateResourceConfigRequest"/></param>
        /// <returns><see cref="CreateResourceConfigResponse"/></returns>
        public Task<CreateResourceConfigResponse> CreateResourceConfig(CreateResourceConfigRequest req)
        {
            return InternalRequestAsync<CreateResourceConfigResponse>(req, "CreateResourceConfig");
        }

        /// <summary>
        /// 创建资源配置模板
        /// </summary>
        /// <param name="req"><see cref="CreateResourceConfigRequest"/></param>
        /// <returns><see cref="CreateResourceConfigResponse"/></returns>
        public CreateResourceConfigResponse CreateResourceConfigSync(CreateResourceConfigRequest req)
        {
            return InternalRequestAsync<CreateResourceConfigResponse>(req, "CreateResourceConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建查询结果下载任务
        /// </summary>
        /// <param name="req"><see cref="CreateResultDownloadRequest"/></param>
        /// <returns><see cref="CreateResultDownloadResponse"/></returns>
        public Task<CreateResultDownloadResponse> CreateResultDownload(CreateResultDownloadRequest req)
        {
            return InternalRequestAsync<CreateResultDownloadResponse>(req, "CreateResultDownload");
        }

        /// <summary>
        /// 创建查询结果下载任务
        /// </summary>
        /// <param name="req"><see cref="CreateResultDownloadRequest"/></param>
        /// <returns><see cref="CreateResultDownloadResponse"/></returns>
        public CreateResultDownloadResponse CreateResultDownloadSync(CreateResultDownloadRequest req)
        {
            return InternalRequestAsync<CreateResultDownloadResponse>(req, "CreateResultDownload")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（CreateScript）用于创建sql脚本。
        /// </summary>
        /// <param name="req"><see cref="CreateScriptRequest"/></param>
        /// <returns><see cref="CreateScriptResponse"/></returns>
        public Task<CreateScriptResponse> CreateScript(CreateScriptRequest req)
        {
            return InternalRequestAsync<CreateScriptResponse>(req, "CreateScript");
        }

        /// <summary>
        /// 该接口（CreateScript）用于创建sql脚本。
        /// </summary>
        /// <param name="req"><see cref="CreateScriptRequest"/></param>
        /// <returns><see cref="CreateScriptResponse"/></returns>
        public CreateScriptResponse CreateScriptSync(CreateScriptRequest req)
        {
            return InternalRequestAsync<CreateScriptResponse>(req, "CreateScript")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建spark作业
        /// </summary>
        /// <param name="req"><see cref="CreateSparkAppRequest"/></param>
        /// <returns><see cref="CreateSparkAppResponse"/></returns>
        public Task<CreateSparkAppResponse> CreateSparkApp(CreateSparkAppRequest req)
        {
            return InternalRequestAsync<CreateSparkAppResponse>(req, "CreateSparkApp");
        }

        /// <summary>
        /// 创建spark作业
        /// </summary>
        /// <param name="req"><see cref="CreateSparkAppRequest"/></param>
        /// <returns><see cref="CreateSparkAppResponse"/></returns>
        public CreateSparkAppResponse CreateSparkAppSync(CreateSparkAppRequest req)
        {
            return InternalRequestAsync<CreateSparkAppResponse>(req, "CreateSparkApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建tdlc spark作业
        /// </summary>
        /// <param name="req"><see cref="CreateSparkAppForTDLCRequest"/></param>
        /// <returns><see cref="CreateSparkAppForTDLCResponse"/></returns>
        public Task<CreateSparkAppForTDLCResponse> CreateSparkAppForTDLC(CreateSparkAppForTDLCRequest req)
        {
            return InternalRequestAsync<CreateSparkAppForTDLCResponse>(req, "CreateSparkAppForTDLC");
        }

        /// <summary>
        /// 创建tdlc spark作业
        /// </summary>
        /// <param name="req"><see cref="CreateSparkAppForTDLCRequest"/></param>
        /// <returns><see cref="CreateSparkAppForTDLCResponse"/></returns>
        public CreateSparkAppForTDLCResponse CreateSparkAppForTDLCSync(CreateSparkAppForTDLCRequest req)
        {
            return InternalRequestAsync<CreateSparkAppForTDLCResponse>(req, "CreateSparkAppForTDLC")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启动Spark作业
        /// </summary>
        /// <param name="req"><see cref="CreateSparkAppTaskRequest"/></param>
        /// <returns><see cref="CreateSparkAppTaskResponse"/></returns>
        public Task<CreateSparkAppTaskResponse> CreateSparkAppTask(CreateSparkAppTaskRequest req)
        {
            return InternalRequestAsync<CreateSparkAppTaskResponse>(req, "CreateSparkAppTask");
        }

        /// <summary>
        /// 启动Spark作业
        /// </summary>
        /// <param name="req"><see cref="CreateSparkAppTaskRequest"/></param>
        /// <returns><see cref="CreateSparkAppTaskResponse"/></returns>
        public CreateSparkAppTaskResponse CreateSparkAppTaskSync(CreateSparkAppTaskRequest req)
        {
            return InternalRequestAsync<CreateSparkAppTaskResponse>(req, "CreateSparkAppTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateSparkSessionBatchSQL）用于向Spark作业引擎提交Spark SQL批任务。
        /// </summary>
        /// <param name="req"><see cref="CreateSparkSessionBatchSQLRequest"/></param>
        /// <returns><see cref="CreateSparkSessionBatchSQLResponse"/></returns>
        public Task<CreateSparkSessionBatchSQLResponse> CreateSparkSessionBatchSQL(CreateSparkSessionBatchSQLRequest req)
        {
            return InternalRequestAsync<CreateSparkSessionBatchSQLResponse>(req, "CreateSparkSessionBatchSQL");
        }

        /// <summary>
        /// 本接口（CreateSparkSessionBatchSQL）用于向Spark作业引擎提交Spark SQL批任务。
        /// </summary>
        /// <param name="req"><see cref="CreateSparkSessionBatchSQLRequest"/></param>
        /// <returns><see cref="CreateSparkSessionBatchSQLResponse"/></returns>
        public CreateSparkSessionBatchSQLResponse CreateSparkSessionBatchSQLSync(CreateSparkSessionBatchSQLRequest req)
        {
            return InternalRequestAsync<CreateSparkSessionBatchSQLResponse>(req, "CreateSparkSessionBatchSQL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateSparkSubmitTask）用于提交SparkSbumit批流任务。
        /// </summary>
        /// <param name="req"><see cref="CreateSparkSubmitTaskRequest"/></param>
        /// <returns><see cref="CreateSparkSubmitTaskResponse"/></returns>
        public Task<CreateSparkSubmitTaskResponse> CreateSparkSubmitTask(CreateSparkSubmitTaskRequest req)
        {
            return InternalRequestAsync<CreateSparkSubmitTaskResponse>(req, "CreateSparkSubmitTask");
        }

        /// <summary>
        /// 本接口（CreateSparkSubmitTask）用于提交SparkSbumit批流任务。
        /// </summary>
        /// <param name="req"><see cref="CreateSparkSubmitTaskRequest"/></param>
        /// <returns><see cref="CreateSparkSubmitTaskResponse"/></returns>
        public CreateSparkSubmitTaskResponse CreateSparkSubmitTaskSync(CreateSparkSubmitTaskRequest req)
        {
            return InternalRequestAsync<CreateSparkSubmitTaskResponse>(req, "CreateSparkSubmitTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建标准引擎资源组
        /// </summary>
        /// <param name="req"><see cref="CreateStandardEngineResourceGroupRequest"/></param>
        /// <returns><see cref="CreateStandardEngineResourceGroupResponse"/></returns>
        public Task<CreateStandardEngineResourceGroupResponse> CreateStandardEngineResourceGroup(CreateStandardEngineResourceGroupRequest req)
        {
            return InternalRequestAsync<CreateStandardEngineResourceGroupResponse>(req, "CreateStandardEngineResourceGroup");
        }

        /// <summary>
        /// 创建标准引擎资源组
        /// </summary>
        /// <param name="req"><see cref="CreateStandardEngineResourceGroupRequest"/></param>
        /// <returns><see cref="CreateStandardEngineResourceGroupResponse"/></returns>
        public CreateStandardEngineResourceGroupResponse CreateStandardEngineResourceGroupSync(CreateStandardEngineResourceGroupRequest req)
        {
            return InternalRequestAsync<CreateStandardEngineResourceGroupResponse>(req, "CreateStandardEngineResourceGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（CreateStoreLocation）新增或覆盖计算结果存储位置。
        /// </summary>
        /// <param name="req"><see cref="CreateStoreLocationRequest"/></param>
        /// <returns><see cref="CreateStoreLocationResponse"/></returns>
        public Task<CreateStoreLocationResponse> CreateStoreLocation(CreateStoreLocationRequest req)
        {
            return InternalRequestAsync<CreateStoreLocationResponse>(req, "CreateStoreLocation");
        }

        /// <summary>
        /// 该接口（CreateStoreLocation）新增或覆盖计算结果存储位置。
        /// </summary>
        /// <param name="req"><see cref="CreateStoreLocationRequest"/></param>
        /// <returns><see cref="CreateStoreLocationResponse"/></returns>
        public CreateStoreLocationResponse CreateStoreLocationSync(CreateStoreLocationRequest req)
        {
            return InternalRequestAsync<CreateStoreLocationResponse>(req, "CreateStoreLocation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateTable）用于生成建表SQL。
        /// </summary>
        /// <param name="req"><see cref="CreateTableRequest"/></param>
        /// <returns><see cref="CreateTableResponse"/></returns>
        public Task<CreateTableResponse> CreateTable(CreateTableRequest req)
        {
            return InternalRequestAsync<CreateTableResponse>(req, "CreateTable");
        }

        /// <summary>
        /// 本接口（CreateTable）用于生成建表SQL。
        /// </summary>
        /// <param name="req"><see cref="CreateTableRequest"/></param>
        /// <returns><see cref="CreateTableResponse"/></returns>
        public CreateTableResponse CreateTableSync(CreateTableRequest req)
        {
            return InternalRequestAsync<CreateTableResponse>(req, "CreateTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateTask）用于创建并执行SQL任务。（推荐使用CreateTasks接口）
        /// </summary>
        /// <param name="req"><see cref="CreateTaskRequest"/></param>
        /// <returns><see cref="CreateTaskResponse"/></returns>
        public Task<CreateTaskResponse> CreateTask(CreateTaskRequest req)
        {
            return InternalRequestAsync<CreateTaskResponse>(req, "CreateTask");
        }

        /// <summary>
        /// 本接口（CreateTask）用于创建并执行SQL任务。（推荐使用CreateTasks接口）
        /// </summary>
        /// <param name="req"><see cref="CreateTaskRequest"/></param>
        /// <returns><see cref="CreateTaskResponse"/></returns>
        public CreateTaskResponse CreateTaskSync(CreateTaskRequest req)
        {
            return InternalRequestAsync<CreateTaskResponse>(req, "CreateTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateTasks），用于批量创建并执行SQL任务
        /// </summary>
        /// <param name="req"><see cref="CreateTasksRequest"/></param>
        /// <returns><see cref="CreateTasksResponse"/></returns>
        public Task<CreateTasksResponse> CreateTasks(CreateTasksRequest req)
        {
            return InternalRequestAsync<CreateTasksResponse>(req, "CreateTasks");
        }

        /// <summary>
        /// 本接口（CreateTasks），用于批量创建并执行SQL任务
        /// </summary>
        /// <param name="req"><see cref="CreateTasksRequest"/></param>
        /// <returns><see cref="CreateTasksResponse"/></returns>
        public CreateTasksResponse CreateTasksSync(CreateTasksRequest req)
        {
            return InternalRequestAsync<CreateTasksResponse>(req, "CreateTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 废弃接口，申请下线
        /// 
        /// 按顺序创建任务（已经废弃，后期不再维护，请使用接口CreateTasks）
        /// </summary>
        /// <param name="req"><see cref="CreateTasksInOrderRequest"/></param>
        /// <returns><see cref="CreateTasksInOrderResponse"/></returns>
        public Task<CreateTasksInOrderResponse> CreateTasksInOrder(CreateTasksInOrderRequest req)
        {
            return InternalRequestAsync<CreateTasksInOrderResponse>(req, "CreateTasksInOrder");
        }

        /// <summary>
        /// 废弃接口，申请下线
        /// 
        /// 按顺序创建任务（已经废弃，后期不再维护，请使用接口CreateTasks）
        /// </summary>
        /// <param name="req"><see cref="CreateTasksInOrderRequest"/></param>
        /// <returns><see cref="CreateTasksInOrderResponse"/></returns>
        public CreateTasksInOrderResponse CreateTasksInOrderSync(CreateTasksInOrderRequest req)
        {
            return InternalRequestAsync<CreateTasksInOrderResponse>(req, "CreateTasksInOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建TIceberg表
        /// </summary>
        /// <param name="req"><see cref="CreateTcIcebergTableRequest"/></param>
        /// <returns><see cref="CreateTcIcebergTableResponse"/></returns>
        public Task<CreateTcIcebergTableResponse> CreateTcIcebergTable(CreateTcIcebergTableRequest req)
        {
            return InternalRequestAsync<CreateTcIcebergTableResponse>(req, "CreateTcIcebergTable");
        }

        /// <summary>
        /// 创建TIceberg表
        /// </summary>
        /// <param name="req"><see cref="CreateTcIcebergTableRequest"/></param>
        /// <returns><see cref="CreateTcIcebergTableResponse"/></returns>
        public CreateTcIcebergTableResponse CreateTcIcebergTableSync(CreateTcIcebergTableRequest req)
        {
            return InternalRequestAsync<CreateTcIcebergTableResponse>(req, "CreateTcIcebergTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建用户
        /// </summary>
        /// <param name="req"><see cref="CreateUserRequest"/></param>
        /// <returns><see cref="CreateUserResponse"/></returns>
        public Task<CreateUserResponse> CreateUser(CreateUserRequest req)
        {
            return InternalRequestAsync<CreateUserResponse>(req, "CreateUser");
        }

        /// <summary>
        /// 创建用户
        /// </summary>
        /// <param name="req"><see cref="CreateUserRequest"/></param>
        /// <returns><see cref="CreateUserResponse"/></returns>
        public CreateUserResponse CreateUserSync(CreateUserRequest req)
        {
            return InternalRequestAsync<CreateUserResponse>(req, "CreateUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建用户角色
        /// </summary>
        /// <param name="req"><see cref="CreateUserRoleRequest"/></param>
        /// <returns><see cref="CreateUserRoleResponse"/></returns>
        public Task<CreateUserRoleResponse> CreateUserRole(CreateUserRoleRequest req)
        {
            return InternalRequestAsync<CreateUserRoleResponse>(req, "CreateUserRole");
        }

        /// <summary>
        /// 创建用户角色
        /// </summary>
        /// <param name="req"><see cref="CreateUserRoleRequest"/></param>
        /// <returns><see cref="CreateUserRoleResponse"/></returns>
        public CreateUserRoleResponse CreateUserRoleSync(CreateUserRoleRequest req)
        {
            return InternalRequestAsync<CreateUserRoleResponse>(req, "CreateUserRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建用户vpc连接到指定引擎网络
        /// </summary>
        /// <param name="req"><see cref="CreateUserVpcConnectionRequest"/></param>
        /// <returns><see cref="CreateUserVpcConnectionResponse"/></returns>
        public Task<CreateUserVpcConnectionResponse> CreateUserVpcConnection(CreateUserVpcConnectionRequest req)
        {
            return InternalRequestAsync<CreateUserVpcConnectionResponse>(req, "CreateUserVpcConnection");
        }

        /// <summary>
        /// 创建用户vpc连接到指定引擎网络
        /// </summary>
        /// <param name="req"><see cref="CreateUserVpcConnectionRequest"/></param>
        /// <returns><see cref="CreateUserVpcConnectionResponse"/></returns>
        public CreateUserVpcConnectionResponse CreateUserVpcConnectionSync(CreateUserVpcConnectionRequest req)
        {
            return InternalRequestAsync<CreateUserVpcConnectionResponse>(req, "CreateUserVpcConnection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建工作组
        /// </summary>
        /// <param name="req"><see cref="CreateWorkGroupRequest"/></param>
        /// <returns><see cref="CreateWorkGroupResponse"/></returns>
        public Task<CreateWorkGroupResponse> CreateWorkGroup(CreateWorkGroupRequest req)
        {
            return InternalRequestAsync<CreateWorkGroupResponse>(req, "CreateWorkGroup");
        }

        /// <summary>
        /// 创建工作组
        /// </summary>
        /// <param name="req"><see cref="CreateWorkGroupRequest"/></param>
        /// <returns><see cref="CreateWorkGroupResponse"/></returns>
        public CreateWorkGroupResponse CreateWorkGroupSync(CreateWorkGroupRequest req)
        {
            return InternalRequestAsync<CreateWorkGroupResponse>(req, "CreateWorkGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（DeleteCHDFSBindingProduct）用于删除元数据加速桶和产品绑定关系
        /// </summary>
        /// <param name="req"><see cref="DeleteCHDFSBindingProductRequest"/></param>
        /// <returns><see cref="DeleteCHDFSBindingProductResponse"/></returns>
        public Task<DeleteCHDFSBindingProductResponse> DeleteCHDFSBindingProduct(DeleteCHDFSBindingProductRequest req)
        {
            return InternalRequestAsync<DeleteCHDFSBindingProductResponse>(req, "DeleteCHDFSBindingProduct");
        }

        /// <summary>
        /// 此接口（DeleteCHDFSBindingProduct）用于删除元数据加速桶和产品绑定关系
        /// </summary>
        /// <param name="req"><see cref="DeleteCHDFSBindingProductRequest"/></param>
        /// <returns><see cref="DeleteCHDFSBindingProductResponse"/></returns>
        public DeleteCHDFSBindingProductResponse DeleteCHDFSBindingProductSync(DeleteCHDFSBindingProductRequest req)
        {
            return InternalRequestAsync<DeleteCHDFSBindingProductResponse>(req, "DeleteCHDFSBindingProduct")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除集群组
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterGroupRequest"/></param>
        /// <returns><see cref="DeleteClusterGroupResponse"/></returns>
        public Task<DeleteClusterGroupResponse> DeleteClusterGroup(DeleteClusterGroupRequest req)
        {
            return InternalRequestAsync<DeleteClusterGroupResponse>(req, "DeleteClusterGroup");
        }

        /// <summary>
        /// 删除集群组
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterGroupRequest"/></param>
        /// <returns><see cref="DeleteClusterGroupResponse"/></returns>
        public DeleteClusterGroupResponse DeleteClusterGroupSync(DeleteClusterGroupRequest req)
        {
            return InternalRequestAsync<DeleteClusterGroupResponse>(req, "DeleteClusterGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除数据引擎
        /// </summary>
        /// <param name="req"><see cref="DeleteDataEngineRequest"/></param>
        /// <returns><see cref="DeleteDataEngineResponse"/></returns>
        public Task<DeleteDataEngineResponse> DeleteDataEngine(DeleteDataEngineRequest req)
        {
            return InternalRequestAsync<DeleteDataEngineResponse>(req, "DeleteDataEngine");
        }

        /// <summary>
        /// 删除数据引擎
        /// </summary>
        /// <param name="req"><see cref="DeleteDataEngineRequest"/></param>
        /// <returns><see cref="DeleteDataEngineResponse"/></returns>
        public DeleteDataEngineResponse DeleteDataEngineSync(DeleteDataEngineRequest req)
        {
            return InternalRequestAsync<DeleteDataEngineResponse>(req, "DeleteDataEngine")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除数据脱敏策略
        /// </summary>
        /// <param name="req"><see cref="DeleteDataMaskStrategyRequest"/></param>
        /// <returns><see cref="DeleteDataMaskStrategyResponse"/></returns>
        public Task<DeleteDataMaskStrategyResponse> DeleteDataMaskStrategy(DeleteDataMaskStrategyRequest req)
        {
            return InternalRequestAsync<DeleteDataMaskStrategyResponse>(req, "DeleteDataMaskStrategy");
        }

        /// <summary>
        /// 删除数据脱敏策略
        /// </summary>
        /// <param name="req"><see cref="DeleteDataMaskStrategyRequest"/></param>
        /// <returns><see cref="DeleteDataMaskStrategyResponse"/></returns>
        public DeleteDataMaskStrategyResponse DeleteDataMaskStrategySync(DeleteDataMaskStrategyRequest req)
        {
            return InternalRequestAsync<DeleteDataMaskStrategyResponse>(req, "DeleteDataMaskStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据配置ID删除作业配置
        /// </summary>
        /// <param name="req"><see cref="DeleteJobSpecRequest"/></param>
        /// <returns><see cref="DeleteJobSpecResponse"/></returns>
        public Task<DeleteJobSpecResponse> DeleteJobSpec(DeleteJobSpecRequest req)
        {
            return InternalRequestAsync<DeleteJobSpecResponse>(req, "DeleteJobSpec");
        }

        /// <summary>
        /// 根据配置ID删除作业配置
        /// </summary>
        /// <param name="req"><see cref="DeleteJobSpecRequest"/></param>
        /// <returns><see cref="DeleteJobSpecResponse"/></returns>
        public DeleteJobSpecResponse DeleteJobSpecSync(DeleteJobSpecRequest req)
        {
            return InternalRequestAsync<DeleteJobSpecResponse>(req, "DeleteJobSpec")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除数据实验室
        /// </summary>
        /// <param name="req"><see cref="DeleteLabRequest"/></param>
        /// <returns><see cref="DeleteLabResponse"/></returns>
        public Task<DeleteLabResponse> DeleteLab(DeleteLabRequest req)
        {
            return InternalRequestAsync<DeleteLabResponse>(req, "DeleteLab");
        }

        /// <summary>
        /// 删除数据实验室
        /// </summary>
        /// <param name="req"><see cref="DeleteLabRequest"/></param>
        /// <returns><see cref="DeleteLabResponse"/></returns>
        public DeleteLabResponse DeleteLabSync(DeleteLabRequest req)
        {
            return InternalRequestAsync<DeleteLabResponse>(req, "DeleteLab")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteMetaDatabase）用于一键删除元数据库
        /// </summary>
        /// <param name="req"><see cref="DeleteMetaDatabaseRequest"/></param>
        /// <returns><see cref="DeleteMetaDatabaseResponse"/></returns>
        public Task<DeleteMetaDatabaseResponse> DeleteMetaDatabase(DeleteMetaDatabaseRequest req)
        {
            return InternalRequestAsync<DeleteMetaDatabaseResponse>(req, "DeleteMetaDatabase");
        }

        /// <summary>
        /// 本接口（DeleteMetaDatabase）用于一键删除元数据库
        /// </summary>
        /// <param name="req"><see cref="DeleteMetaDatabaseRequest"/></param>
        /// <returns><see cref="DeleteMetaDatabaseResponse"/></returns>
        public DeleteMetaDatabaseResponse DeleteMetaDatabaseSync(DeleteMetaDatabaseRequest req)
        {
            return InternalRequestAsync<DeleteMetaDatabaseResponse>(req, "DeleteMetaDatabase")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据spark session名称销毁eg spark session
        /// </summary>
        /// <param name="req"><see cref="DeleteNativeSparkSessionRequest"/></param>
        /// <returns><see cref="DeleteNativeSparkSessionResponse"/></returns>
        public Task<DeleteNativeSparkSessionResponse> DeleteNativeSparkSession(DeleteNativeSparkSessionRequest req)
        {
            return InternalRequestAsync<DeleteNativeSparkSessionResponse>(req, "DeleteNativeSparkSession");
        }

        /// <summary>
        /// 根据spark session名称销毁eg spark session
        /// </summary>
        /// <param name="req"><see cref="DeleteNativeSparkSessionRequest"/></param>
        /// <returns><see cref="DeleteNativeSparkSessionResponse"/></returns>
        public DeleteNativeSparkSessionResponse DeleteNativeSparkSessionSync(DeleteNativeSparkSessionRequest req)
        {
            return InternalRequestAsync<DeleteNativeSparkSessionResponse>(req, "DeleteNativeSparkSession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteNotebookSession）用于删除交互式session（notebook）
        /// </summary>
        /// <param name="req"><see cref="DeleteNotebookSessionRequest"/></param>
        /// <returns><see cref="DeleteNotebookSessionResponse"/></returns>
        public Task<DeleteNotebookSessionResponse> DeleteNotebookSession(DeleteNotebookSessionRequest req)
        {
            return InternalRequestAsync<DeleteNotebookSessionResponse>(req, "DeleteNotebookSession");
        }

        /// <summary>
        /// 本接口（DeleteNotebookSession）用于删除交互式session（notebook）
        /// </summary>
        /// <param name="req"><see cref="DeleteNotebookSessionRequest"/></param>
        /// <returns><see cref="DeleteNotebookSessionResponse"/></returns>
        public DeleteNotebookSessionResponse DeleteNotebookSessionSync(DeleteNotebookSessionRequest req)
        {
            return InternalRequestAsync<DeleteNotebookSessionResponse>(req, "DeleteNotebookSession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除资源队列
        /// </summary>
        /// <param name="req"><see cref="DeletePartitionQueueRequest"/></param>
        /// <returns><see cref="DeletePartitionQueueResponse"/></returns>
        public Task<DeletePartitionQueueResponse> DeletePartitionQueue(DeletePartitionQueueRequest req)
        {
            return InternalRequestAsync<DeletePartitionQueueResponse>(req, "DeletePartitionQueue");
        }

        /// <summary>
        /// 删除资源队列
        /// </summary>
        /// <param name="req"><see cref="DeletePartitionQueueRequest"/></param>
        /// <returns><see cref="DeletePartitionQueueResponse"/></returns>
        public DeletePartitionQueueResponse DeletePartitionQueueSync(DeletePartitionQueueRequest req)
        {
            return InternalRequestAsync<DeletePartitionQueueResponse>(req, "DeletePartitionQueue")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除集群
        /// </summary>
        /// <param name="req"><see cref="DeleteRayClusterRequest"/></param>
        /// <returns><see cref="DeleteRayClusterResponse"/></returns>
        public Task<DeleteRayClusterResponse> DeleteRayCluster(DeleteRayClusterRequest req)
        {
            return InternalRequestAsync<DeleteRayClusterResponse>(req, "DeleteRayCluster");
        }

        /// <summary>
        /// 删除集群
        /// </summary>
        /// <param name="req"><see cref="DeleteRayClusterRequest"/></param>
        /// <returns><see cref="DeleteRayClusterResponse"/></returns>
        public DeleteRayClusterResponse DeleteRayClusterSync(DeleteRayClusterRequest req)
        {
            return InternalRequestAsync<DeleteRayClusterResponse>(req, "DeleteRayCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据任务ID删除Ray任务
        /// </summary>
        /// <param name="req"><see cref="DeleteRayJobRequest"/></param>
        /// <returns><see cref="DeleteRayJobResponse"/></returns>
        public Task<DeleteRayJobResponse> DeleteRayJob(DeleteRayJobRequest req)
        {
            return InternalRequestAsync<DeleteRayJobResponse>(req, "DeleteRayJob");
        }

        /// <summary>
        /// 根据任务ID删除Ray任务
        /// </summary>
        /// <param name="req"><see cref="DeleteRayJobRequest"/></param>
        /// <returns><see cref="DeleteRayJobResponse"/></returns>
        public DeleteRayJobResponse DeleteRayJobSync(DeleteRayJobRequest req)
        {
            return InternalRequestAsync<DeleteRayJobResponse>(req, "DeleteRayJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除资源配置模板
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceConfigRequest"/></param>
        /// <returns><see cref="DeleteResourceConfigResponse"/></returns>
        public Task<DeleteResourceConfigResponse> DeleteResourceConfig(DeleteResourceConfigRequest req)
        {
            return InternalRequestAsync<DeleteResourceConfigResponse>(req, "DeleteResourceConfig");
        }

        /// <summary>
        /// 删除资源配置模板
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceConfigRequest"/></param>
        /// <returns><see cref="DeleteResourceConfigResponse"/></returns>
        public DeleteResourceConfigResponse DeleteResourceConfigSync(DeleteResourceConfigRequest req)
        {
            return InternalRequestAsync<DeleteResourceConfigResponse>(req, "DeleteResourceConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（DeleteScript）用于删除sql脚本。
        /// </summary>
        /// <param name="req"><see cref="DeleteScriptRequest"/></param>
        /// <returns><see cref="DeleteScriptResponse"/></returns>
        public Task<DeleteScriptResponse> DeleteScript(DeleteScriptRequest req)
        {
            return InternalRequestAsync<DeleteScriptResponse>(req, "DeleteScript");
        }

        /// <summary>
        /// 该接口（DeleteScript）用于删除sql脚本。
        /// </summary>
        /// <param name="req"><see cref="DeleteScriptRequest"/></param>
        /// <returns><see cref="DeleteScriptResponse"/></returns>
        public DeleteScriptResponse DeleteScriptSync(DeleteScriptRequest req)
        {
            return InternalRequestAsync<DeleteScriptResponse>(req, "DeleteScript")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除spark作业
        /// </summary>
        /// <param name="req"><see cref="DeleteSparkAppRequest"/></param>
        /// <returns><see cref="DeleteSparkAppResponse"/></returns>
        public Task<DeleteSparkAppResponse> DeleteSparkApp(DeleteSparkAppRequest req)
        {
            return InternalRequestAsync<DeleteSparkAppResponse>(req, "DeleteSparkApp");
        }

        /// <summary>
        /// 删除spark作业
        /// </summary>
        /// <param name="req"><see cref="DeleteSparkAppRequest"/></param>
        /// <returns><see cref="DeleteSparkAppResponse"/></returns>
        public DeleteSparkAppResponse DeleteSparkAppSync(DeleteSparkAppRequest req)
        {
            return InternalRequestAsync<DeleteSparkAppResponse>(req, "DeleteSparkApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除标准引擎资源组
        /// </summary>
        /// <param name="req"><see cref="DeleteStandardEngineResourceGroupRequest"/></param>
        /// <returns><see cref="DeleteStandardEngineResourceGroupResponse"/></returns>
        public Task<DeleteStandardEngineResourceGroupResponse> DeleteStandardEngineResourceGroup(DeleteStandardEngineResourceGroupRequest req)
        {
            return InternalRequestAsync<DeleteStandardEngineResourceGroupResponse>(req, "DeleteStandardEngineResourceGroup");
        }

        /// <summary>
        /// 删除标准引擎资源组
        /// </summary>
        /// <param name="req"><see cref="DeleteStandardEngineResourceGroupRequest"/></param>
        /// <returns><see cref="DeleteStandardEngineResourceGroupResponse"/></returns>
        public DeleteStandardEngineResourceGroupResponse DeleteStandardEngineResourceGroupSync(DeleteStandardEngineResourceGroupRequest req)
        {
            return InternalRequestAsync<DeleteStandardEngineResourceGroupResponse>(req, "DeleteStandardEngineResourceGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除表
        /// </summary>
        /// <param name="req"><see cref="DeleteTableRequest"/></param>
        /// <returns><see cref="DeleteTableResponse"/></returns>
        public Task<DeleteTableResponse> DeleteTable(DeleteTableRequest req)
        {
            return InternalRequestAsync<DeleteTableResponse>(req, "DeleteTable");
        }

        /// <summary>
        /// 删除表
        /// </summary>
        /// <param name="req"><see cref="DeleteTableRequest"/></param>
        /// <returns><see cref="DeleteTableResponse"/></returns>
        public DeleteTableResponse DeleteTableSync(DeleteTableRequest req)
        {
            return InternalRequestAsync<DeleteTableResponse>(req, "DeleteTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（RegisterThirdPartyAccessUser）用于移除第三方平台访问
        /// </summary>
        /// <param name="req"><see cref="DeleteThirdPartyAccessUserRequest"/></param>
        /// <returns><see cref="DeleteThirdPartyAccessUserResponse"/></returns>
        public Task<DeleteThirdPartyAccessUserResponse> DeleteThirdPartyAccessUser(DeleteThirdPartyAccessUserRequest req)
        {
            return InternalRequestAsync<DeleteThirdPartyAccessUserResponse>(req, "DeleteThirdPartyAccessUser");
        }

        /// <summary>
        /// 本接口（RegisterThirdPartyAccessUser）用于移除第三方平台访问
        /// </summary>
        /// <param name="req"><see cref="DeleteThirdPartyAccessUserRequest"/></param>
        /// <returns><see cref="DeleteThirdPartyAccessUserResponse"/></returns>
        public DeleteThirdPartyAccessUserResponse DeleteThirdPartyAccessUserSync(DeleteThirdPartyAccessUserRequest req)
        {
            return InternalRequestAsync<DeleteThirdPartyAccessUserResponse>(req, "DeleteThirdPartyAccessUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRequest"/></param>
        /// <returns><see cref="DeleteUserResponse"/></returns>
        public Task<DeleteUserResponse> DeleteUser(DeleteUserRequest req)
        {
            return InternalRequestAsync<DeleteUserResponse>(req, "DeleteUser");
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRequest"/></param>
        /// <returns><see cref="DeleteUserResponse"/></returns>
        public DeleteUserResponse DeleteUserSync(DeleteUserRequest req)
        {
            return InternalRequestAsync<DeleteUserResponse>(req, "DeleteUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除用户vpc到引擎网络的连接
        /// </summary>
        /// <param name="req"><see cref="DeleteUserVpcConnectionRequest"/></param>
        /// <returns><see cref="DeleteUserVpcConnectionResponse"/></returns>
        public Task<DeleteUserVpcConnectionResponse> DeleteUserVpcConnection(DeleteUserVpcConnectionRequest req)
        {
            return InternalRequestAsync<DeleteUserVpcConnectionResponse>(req, "DeleteUserVpcConnection");
        }

        /// <summary>
        /// 删除用户vpc到引擎网络的连接
        /// </summary>
        /// <param name="req"><see cref="DeleteUserVpcConnectionRequest"/></param>
        /// <returns><see cref="DeleteUserVpcConnectionResponse"/></returns>
        public DeleteUserVpcConnectionResponse DeleteUserVpcConnectionSync(DeleteUserVpcConnectionRequest req)
        {
            return InternalRequestAsync<DeleteUserVpcConnectionResponse>(req, "DeleteUserVpcConnection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 从工作组中删除用户
        /// </summary>
        /// <param name="req"><see cref="DeleteUsersFromWorkGroupRequest"/></param>
        /// <returns><see cref="DeleteUsersFromWorkGroupResponse"/></returns>
        public Task<DeleteUsersFromWorkGroupResponse> DeleteUsersFromWorkGroup(DeleteUsersFromWorkGroupRequest req)
        {
            return InternalRequestAsync<DeleteUsersFromWorkGroupResponse>(req, "DeleteUsersFromWorkGroup");
        }

        /// <summary>
        /// 从工作组中删除用户
        /// </summary>
        /// <param name="req"><see cref="DeleteUsersFromWorkGroupRequest"/></param>
        /// <returns><see cref="DeleteUsersFromWorkGroupResponse"/></returns>
        public DeleteUsersFromWorkGroupResponse DeleteUsersFromWorkGroupSync(DeleteUsersFromWorkGroupRequest req)
        {
            return InternalRequestAsync<DeleteUsersFromWorkGroupResponse>(req, "DeleteUsersFromWorkGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除工作组
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkGroupRequest"/></param>
        /// <returns><see cref="DeleteWorkGroupResponse"/></returns>
        public Task<DeleteWorkGroupResponse> DeleteWorkGroup(DeleteWorkGroupRequest req)
        {
            return InternalRequestAsync<DeleteWorkGroupResponse>(req, "DeleteWorkGroup");
        }

        /// <summary>
        /// 删除工作组
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkGroupRequest"/></param>
        /// <returns><see cref="DeleteWorkGroupResponse"/></returns>
        public DeleteWorkGroupResponse DeleteWorkGroupSync(DeleteWorkGroupRequest req)
        {
            return InternalRequestAsync<DeleteWorkGroupResponse>(req, "DeleteWorkGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询sql查询界面高级设置
        /// </summary>
        /// <param name="req"><see cref="DescribeAdvancedStoreLocationRequest"/></param>
        /// <returns><see cref="DescribeAdvancedStoreLocationResponse"/></returns>
        public Task<DescribeAdvancedStoreLocationResponse> DescribeAdvancedStoreLocation(DescribeAdvancedStoreLocationRequest req)
        {
            return InternalRequestAsync<DescribeAdvancedStoreLocationResponse>(req, "DescribeAdvancedStoreLocation");
        }

        /// <summary>
        /// 查询sql查询界面高级设置
        /// </summary>
        /// <param name="req"><see cref="DescribeAdvancedStoreLocationRequest"/></param>
        /// <returns><see cref="DescribeAdvancedStoreLocationResponse"/></returns>
        public DescribeAdvancedStoreLocationResponse DescribeAdvancedStoreLocationSync(DescribeAdvancedStoreLocationRequest req)
        {
            return InternalRequestAsync<DescribeAdvancedStoreLocationResponse>(req, "DescribeAdvancedStoreLocation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据集群组 ID 获取集群组详情。支持通过 IncludeDeleted 参数控制是否返回已软删除的记录（用于悬挂 cluster 回显场景）。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterGroupRequest"/></param>
        /// <returns><see cref="DescribeClusterGroupResponse"/></returns>
        public Task<DescribeClusterGroupResponse> DescribeClusterGroup(DescribeClusterGroupRequest req)
        {
            return InternalRequestAsync<DescribeClusterGroupResponse>(req, "DescribeClusterGroup");
        }

        /// <summary>
        /// 根据集群组 ID 获取集群组详情。支持通过 IncludeDeleted 参数控制是否返回已软删除的记录（用于悬挂 cluster 回显场景）。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterGroupRequest"/></param>
        /// <returns><see cref="DescribeClusterGroupResponse"/></returns>
        public DescribeClusterGroupResponse DescribeClusterGroupSync(DescribeClusterGroupRequest req)
        {
            return InternalRequestAsync<DescribeClusterGroupResponse>(req, "DescribeClusterGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 计算组关联 cluster 使用情况响应
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterGroupClustersRequest"/></param>
        /// <returns><see cref="DescribeClusterGroupClustersResponse"/></returns>
        public Task<DescribeClusterGroupClustersResponse> DescribeClusterGroupClusters(DescribeClusterGroupClustersRequest req)
        {
            return InternalRequestAsync<DescribeClusterGroupClustersResponse>(req, "DescribeClusterGroupClusters");
        }

        /// <summary>
        /// 计算组关联 cluster 使用情况响应
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterGroupClustersRequest"/></param>
        /// <returns><see cref="DescribeClusterGroupClustersResponse"/></returns>
        public DescribeClusterGroupClustersResponse DescribeClusterGroupClustersSync(DescribeClusterGroupClustersRequest req)
        {
            return InternalRequestAsync<DescribeClusterGroupClustersResponse>(req, "DescribeClusterGroupClusters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询任务监控指标信息
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterMonitorInfosRequest"/></param>
        /// <returns><see cref="DescribeClusterMonitorInfosResponse"/></returns>
        public Task<DescribeClusterMonitorInfosResponse> DescribeClusterMonitorInfos(DescribeClusterMonitorInfosRequest req)
        {
            return InternalRequestAsync<DescribeClusterMonitorInfosResponse>(req, "DescribeClusterMonitorInfos");
        }

        /// <summary>
        /// 查询任务监控指标信息
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterMonitorInfosRequest"/></param>
        /// <returns><see cref="DescribeClusterMonitorInfosResponse"/></returns>
        public DescribeClusterMonitorInfosResponse DescribeClusterMonitorInfosSync(DescribeClusterMonitorInfosRequest req)
        {
            return InternalRequestAsync<DescribeClusterMonitorInfosResponse>(req, "DescribeClusterMonitorInfos")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询DLC Catalog授权列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDLCCatalogAccessRequest"/></param>
        /// <returns><see cref="DescribeDLCCatalogAccessResponse"/></returns>
        public Task<DescribeDLCCatalogAccessResponse> DescribeDLCCatalogAccess(DescribeDLCCatalogAccessRequest req)
        {
            return InternalRequestAsync<DescribeDLCCatalogAccessResponse>(req, "DescribeDLCCatalogAccess");
        }

        /// <summary>
        /// 查询DLC Catalog授权列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDLCCatalogAccessRequest"/></param>
        /// <returns><see cref="DescribeDLCCatalogAccessResponse"/></returns>
        public DescribeDLCCatalogAccessResponse DescribeDLCCatalogAccessSync(DescribeDLCCatalogAccessRequest req)
        {
            return InternalRequestAsync<DescribeDLCCatalogAccessResponse>(req, "DescribeDLCCatalogAccess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DMS元数据获取库
        /// </summary>
        /// <param name="req"><see cref="DescribeDMSDatabaseRequest"/></param>
        /// <returns><see cref="DescribeDMSDatabaseResponse"/></returns>
        public Task<DescribeDMSDatabaseResponse> DescribeDMSDatabase(DescribeDMSDatabaseRequest req)
        {
            return InternalRequestAsync<DescribeDMSDatabaseResponse>(req, "DescribeDMSDatabase");
        }

        /// <summary>
        /// DMS元数据获取库
        /// </summary>
        /// <param name="req"><see cref="DescribeDMSDatabaseRequest"/></param>
        /// <returns><see cref="DescribeDMSDatabaseResponse"/></returns>
        public DescribeDMSDatabaseResponse DescribeDMSDatabaseSync(DescribeDMSDatabaseRequest req)
        {
            return InternalRequestAsync<DescribeDMSDatabaseResponse>(req, "DescribeDMSDatabase")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DMS元数据获取分区
        /// </summary>
        /// <param name="req"><see cref="DescribeDMSPartitionsRequest"/></param>
        /// <returns><see cref="DescribeDMSPartitionsResponse"/></returns>
        public Task<DescribeDMSPartitionsResponse> DescribeDMSPartitions(DescribeDMSPartitionsRequest req)
        {
            return InternalRequestAsync<DescribeDMSPartitionsResponse>(req, "DescribeDMSPartitions");
        }

        /// <summary>
        /// DMS元数据获取分区
        /// </summary>
        /// <param name="req"><see cref="DescribeDMSPartitionsRequest"/></param>
        /// <returns><see cref="DescribeDMSPartitionsResponse"/></returns>
        public DescribeDMSPartitionsResponse DescribeDMSPartitionsSync(DescribeDMSPartitionsRequest req)
        {
            return InternalRequestAsync<DescribeDMSPartitionsResponse>(req, "DescribeDMSPartitions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DMS元数据获取表
        /// </summary>
        /// <param name="req"><see cref="DescribeDMSTableRequest"/></param>
        /// <returns><see cref="DescribeDMSTableResponse"/></returns>
        public Task<DescribeDMSTableResponse> DescribeDMSTable(DescribeDMSTableRequest req)
        {
            return InternalRequestAsync<DescribeDMSTableResponse>(req, "DescribeDMSTable");
        }

        /// <summary>
        /// DMS元数据获取表
        /// </summary>
        /// <param name="req"><see cref="DescribeDMSTableRequest"/></param>
        /// <returns><see cref="DescribeDMSTableResponse"/></returns>
        public DescribeDMSTableResponse DescribeDMSTableSync(DescribeDMSTableRequest req)
        {
            return InternalRequestAsync<DescribeDMSTableResponse>(req, "DescribeDMSTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DMS元数据获取表列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDMSTablesRequest"/></param>
        /// <returns><see cref="DescribeDMSTablesResponse"/></returns>
        public Task<DescribeDMSTablesResponse> DescribeDMSTables(DescribeDMSTablesRequest req)
        {
            return InternalRequestAsync<DescribeDMSTablesResponse>(req, "DescribeDMSTables");
        }

        /// <summary>
        /// DMS元数据获取表列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDMSTablesRequest"/></param>
        /// <returns><see cref="DescribeDMSTablesResponse"/></returns>
        public DescribeDMSTablesResponse DescribeDMSTablesSync(DescribeDMSTablesRequest req)
        {
            return InternalRequestAsync<DescribeDMSTablesResponse>(req, "DescribeDMSTables")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口根据名称用于获取数据引擎详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataEngineRequest"/></param>
        /// <returns><see cref="DescribeDataEngineResponse"/></returns>
        public Task<DescribeDataEngineResponse> DescribeDataEngine(DescribeDataEngineRequest req)
        {
            return InternalRequestAsync<DescribeDataEngineResponse>(req, "DescribeDataEngine");
        }

        /// <summary>
        /// 本接口根据名称用于获取数据引擎详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataEngineRequest"/></param>
        /// <returns><see cref="DescribeDataEngineResponse"/></returns>
        public DescribeDataEngineResponse DescribeDataEngineSync(DescribeDataEngineRequest req)
        {
            return InternalRequestAsync<DescribeDataEngineResponse>(req, "DescribeDataEngine")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询数据引擎事件
        /// </summary>
        /// <param name="req"><see cref="DescribeDataEngineEventsRequest"/></param>
        /// <returns><see cref="DescribeDataEngineEventsResponse"/></returns>
        public Task<DescribeDataEngineEventsResponse> DescribeDataEngineEvents(DescribeDataEngineEventsRequest req)
        {
            return InternalRequestAsync<DescribeDataEngineEventsResponse>(req, "DescribeDataEngineEvents");
        }

        /// <summary>
        /// 查询数据引擎事件
        /// </summary>
        /// <param name="req"><see cref="DescribeDataEngineEventsRequest"/></param>
        /// <returns><see cref="DescribeDataEngineEventsResponse"/></returns>
        public DescribeDataEngineEventsResponse DescribeDataEngineEventsSync(DescribeDataEngineEventsRequest req)
        {
            return InternalRequestAsync<DescribeDataEngineEventsResponse>(req, "DescribeDataEngineEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDataEngineImageVersions）用于获取独享集群大版本镜像列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDataEngineImageVersionsRequest"/></param>
        /// <returns><see cref="DescribeDataEngineImageVersionsResponse"/></returns>
        public Task<DescribeDataEngineImageVersionsResponse> DescribeDataEngineImageVersions(DescribeDataEngineImageVersionsRequest req)
        {
            return InternalRequestAsync<DescribeDataEngineImageVersionsResponse>(req, "DescribeDataEngineImageVersions");
        }

        /// <summary>
        /// 本接口（DescribeDataEngineImageVersions）用于获取独享集群大版本镜像列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDataEngineImageVersionsRequest"/></param>
        /// <returns><see cref="DescribeDataEngineImageVersionsResponse"/></returns>
        public DescribeDataEngineImageVersionsResponse DescribeDataEngineImageVersionsSync(DescribeDataEngineImageVersionsRequest req)
        {
            return InternalRequestAsync<DescribeDataEngineImageVersionsResponse>(req, "DescribeDataEngineImageVersions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDataEnginePythonSparkImages）用于获取PYSPARK镜像列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDataEnginePythonSparkImagesRequest"/></param>
        /// <returns><see cref="DescribeDataEnginePythonSparkImagesResponse"/></returns>
        public Task<DescribeDataEnginePythonSparkImagesResponse> DescribeDataEnginePythonSparkImages(DescribeDataEnginePythonSparkImagesRequest req)
        {
            return InternalRequestAsync<DescribeDataEnginePythonSparkImagesResponse>(req, "DescribeDataEnginePythonSparkImages");
        }

        /// <summary>
        /// 本接口（DescribeDataEnginePythonSparkImages）用于获取PYSPARK镜像列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDataEnginePythonSparkImagesRequest"/></param>
        /// <returns><see cref="DescribeDataEnginePythonSparkImagesResponse"/></returns>
        public DescribeDataEnginePythonSparkImagesResponse DescribeDataEnginePythonSparkImagesSync(DescribeDataEnginePythonSparkImagesRequest req)
        {
            return InternalRequestAsync<DescribeDataEnginePythonSparkImagesResponse>(req, "DescribeDataEnginePythonSparkImages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDataEngineSessionParameters）用于获取指定小版本下的Session配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeDataEngineSessionParametersRequest"/></param>
        /// <returns><see cref="DescribeDataEngineSessionParametersResponse"/></returns>
        public Task<DescribeDataEngineSessionParametersResponse> DescribeDataEngineSessionParameters(DescribeDataEngineSessionParametersRequest req)
        {
            return InternalRequestAsync<DescribeDataEngineSessionParametersResponse>(req, "DescribeDataEngineSessionParameters");
        }

        /// <summary>
        /// 本接口（DescribeDataEngineSessionParameters）用于获取指定小版本下的Session配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeDataEngineSessionParametersRequest"/></param>
        /// <returns><see cref="DescribeDataEngineSessionParametersResponse"/></returns>
        public DescribeDataEngineSessionParametersResponse DescribeDataEngineSessionParametersSync(DescribeDataEngineSessionParametersRequest req)
        {
            return InternalRequestAsync<DescribeDataEngineSessionParametersResponse>(req, "DescribeDataEngineSessionParameters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDataEngines）用于查询DataEngines信息列表.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataEnginesRequest"/></param>
        /// <returns><see cref="DescribeDataEnginesResponse"/></returns>
        public Task<DescribeDataEnginesResponse> DescribeDataEngines(DescribeDataEnginesRequest req)
        {
            return InternalRequestAsync<DescribeDataEnginesResponse>(req, "DescribeDataEngines");
        }

        /// <summary>
        /// 本接口（DescribeDataEngines）用于查询DataEngines信息列表.
        /// </summary>
        /// <param name="req"><see cref="DescribeDataEnginesRequest"/></param>
        /// <returns><see cref="DescribeDataEnginesResponse"/></returns>
        public DescribeDataEnginesResponse DescribeDataEnginesSync(DescribeDataEnginesRequest req)
        {
            return InternalRequestAsync<DescribeDataEnginesResponse>(req, "DescribeDataEngines")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询引擎规格详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDataEnginesScaleDetailRequest"/></param>
        /// <returns><see cref="DescribeDataEnginesScaleDetailResponse"/></returns>
        public Task<DescribeDataEnginesScaleDetailResponse> DescribeDataEnginesScaleDetail(DescribeDataEnginesScaleDetailRequest req)
        {
            return InternalRequestAsync<DescribeDataEnginesScaleDetailResponse>(req, "DescribeDataEnginesScaleDetail");
        }

        /// <summary>
        /// 查询引擎规格详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDataEnginesScaleDetailRequest"/></param>
        /// <returns><see cref="DescribeDataEnginesScaleDetailResponse"/></returns>
        public DescribeDataEnginesScaleDetailResponse DescribeDataEnginesScaleDetailSync(DescribeDataEnginesScaleDetailRequest req)
        {
            return InternalRequestAsync<DescribeDataEnginesScaleDetailResponse>(req, "DescribeDataEnginesScaleDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询数据脱敏列表接口
        /// </summary>
        /// <param name="req"><see cref="DescribeDataMaskStrategiesRequest"/></param>
        /// <returns><see cref="DescribeDataMaskStrategiesResponse"/></returns>
        public Task<DescribeDataMaskStrategiesResponse> DescribeDataMaskStrategies(DescribeDataMaskStrategiesRequest req)
        {
            return InternalRequestAsync<DescribeDataMaskStrategiesResponse>(req, "DescribeDataMaskStrategies");
        }

        /// <summary>
        /// 查询数据脱敏列表接口
        /// </summary>
        /// <param name="req"><see cref="DescribeDataMaskStrategiesRequest"/></param>
        /// <returns><see cref="DescribeDataMaskStrategiesResponse"/></returns>
        public DescribeDataMaskStrategiesResponse DescribeDataMaskStrategiesSync(DescribeDataMaskStrategiesRequest req)
        {
            return InternalRequestAsync<DescribeDataMaskStrategiesResponse>(req, "DescribeDataMaskStrategies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDatabase）,查询数据库详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseRequest"/></param>
        /// <returns><see cref="DescribeDatabaseResponse"/></returns>
        public Task<DescribeDatabaseResponse> DescribeDatabase(DescribeDatabaseRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseResponse>(req, "DescribeDatabase");
        }

        /// <summary>
        /// 本接口（DescribeDatabase）,查询数据库详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabaseRequest"/></param>
        /// <returns><see cref="DescribeDatabaseResponse"/></returns>
        public DescribeDatabaseResponse DescribeDatabaseSync(DescribeDatabaseRequest req)
        {
            return InternalRequestAsync<DescribeDatabaseResponse>(req, "DescribeDatabase")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDatabases）用于查询数据库列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabasesRequest"/></param>
        /// <returns><see cref="DescribeDatabasesResponse"/></returns>
        public Task<DescribeDatabasesResponse> DescribeDatabases(DescribeDatabasesRequest req)
        {
            return InternalRequestAsync<DescribeDatabasesResponse>(req, "DescribeDatabases");
        }

        /// <summary>
        /// 本接口（DescribeDatabases）用于查询数据库列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabasesRequest"/></param>
        /// <returns><see cref="DescribeDatabasesResponse"/></returns>
        public DescribeDatabasesResponse DescribeDatabasesSync(DescribeDatabasesRequest req)
        {
            return InternalRequestAsync<DescribeDatabasesResponse>(req, "DescribeDatabases")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDatasourceConnection）用于查询数据源信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDatasourceConnectionRequest"/></param>
        /// <returns><see cref="DescribeDatasourceConnectionResponse"/></returns>
        public Task<DescribeDatasourceConnectionResponse> DescribeDatasourceConnection(DescribeDatasourceConnectionRequest req)
        {
            return InternalRequestAsync<DescribeDatasourceConnectionResponse>(req, "DescribeDatasourceConnection");
        }

        /// <summary>
        /// 本接口（DescribeDatasourceConnection）用于查询数据源信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDatasourceConnectionRequest"/></param>
        /// <returns><see cref="DescribeDatasourceConnectionResponse"/></returns>
        public DescribeDatasourceConnectionResponse DescribeDatasourceConnectionSync(DescribeDatasourceConnectionRequest req)
        {
            return InternalRequestAsync<DescribeDatasourceConnectionResponse>(req, "DescribeDatasourceConnection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询引擎网络信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEngineNetworksRequest"/></param>
        /// <returns><see cref="DescribeEngineNetworksResponse"/></returns>
        public Task<DescribeEngineNetworksResponse> DescribeEngineNetworks(DescribeEngineNetworksRequest req)
        {
            return InternalRequestAsync<DescribeEngineNetworksResponse>(req, "DescribeEngineNetworks");
        }

        /// <summary>
        /// 查询引擎网络信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEngineNetworksRequest"/></param>
        /// <returns><see cref="DescribeEngineNetworksResponse"/></returns>
        public DescribeEngineNetworksResponse DescribeEngineNetworksSync(DescribeEngineNetworksRequest req)
        {
            return InternalRequestAsync<DescribeEngineNetworksResponse>(req, "DescribeEngineNetworks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询引擎可用的节点规格
        /// </summary>
        /// <param name="req"><see cref="DescribeEngineNodeSpecRequest"/></param>
        /// <returns><see cref="DescribeEngineNodeSpecResponse"/></returns>
        public Task<DescribeEngineNodeSpecResponse> DescribeEngineNodeSpec(DescribeEngineNodeSpecRequest req)
        {
            return InternalRequestAsync<DescribeEngineNodeSpecResponse>(req, "DescribeEngineNodeSpec");
        }

        /// <summary>
        /// 查询引擎可用的节点规格
        /// </summary>
        /// <param name="req"><see cref="DescribeEngineNodeSpecRequest"/></param>
        /// <returns><see cref="DescribeEngineNodeSpecResponse"/></returns>
        public DescribeEngineNodeSpecResponse DescribeEngineNodeSpecSync(DescribeEngineNodeSpecRequest req)
        {
            return InternalRequestAsync<DescribeEngineNodeSpecResponse>(req, "DescribeEngineNodeSpec")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口根据引擎ID查询数据引擎资源使用情况
        /// </summary>
        /// <param name="req"><see cref="DescribeEngineUsageInfoRequest"/></param>
        /// <returns><see cref="DescribeEngineUsageInfoResponse"/></returns>
        public Task<DescribeEngineUsageInfoResponse> DescribeEngineUsageInfo(DescribeEngineUsageInfoRequest req)
        {
            return InternalRequestAsync<DescribeEngineUsageInfoResponse>(req, "DescribeEngineUsageInfo");
        }

        /// <summary>
        /// 本接口根据引擎ID查询数据引擎资源使用情况
        /// </summary>
        /// <param name="req"><see cref="DescribeEngineUsageInfoRequest"/></param>
        /// <returns><see cref="DescribeEngineUsageInfoResponse"/></returns>
        public DescribeEngineUsageInfoResponse DescribeEngineUsageInfoSync(DescribeEngineUsageInfoRequest req)
        {
            return InternalRequestAsync<DescribeEngineUsageInfoResponse>(req, "DescribeEngineUsageInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 分页查询指定分区的流程详情列表，包含每个流程的基本信息和活动列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowDetailListRequest"/></param>
        /// <returns><see cref="DescribeFlowDetailListResponse"/></returns>
        public Task<DescribeFlowDetailListResponse> DescribeFlowDetailList(DescribeFlowDetailListRequest req)
        {
            return InternalRequestAsync<DescribeFlowDetailListResponse>(req, "DescribeFlowDetailList");
        }

        /// <summary>
        /// 分页查询指定分区的流程详情列表，包含每个流程的基本信息和活动列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowDetailListRequest"/></param>
        /// <returns><see cref="DescribeFlowDetailListResponse"/></returns>
        public DescribeFlowDetailListResponse DescribeFlowDetailListSync(DescribeFlowDetailListRequest req)
        {
            return InternalRequestAsync<DescribeFlowDetailListResponse>(req, "DescribeFlowDetailList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定分区的流程列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowListRequest"/></param>
        /// <returns><see cref="DescribeFlowListResponse"/></returns>
        public Task<DescribeFlowListResponse> DescribeFlowList(DescribeFlowListRequest req)
        {
            return InternalRequestAsync<DescribeFlowListResponse>(req, "DescribeFlowList");
        }

        /// <summary>
        /// 查询指定分区的流程列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowListRequest"/></param>
        /// <returns><see cref="DescribeFlowListResponse"/></returns>
        public DescribeFlowListResponse DescribeFlowListSync(DescribeFlowListRequest req)
        {
            return InternalRequestAsync<DescribeFlowListResponse>(req, "DescribeFlowList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeForbiddenTablePro）用于查询被禁用的表属性列表（新）
        /// </summary>
        /// <param name="req"><see cref="DescribeForbiddenTableProRequest"/></param>
        /// <returns><see cref="DescribeForbiddenTableProResponse"/></returns>
        public Task<DescribeForbiddenTableProResponse> DescribeForbiddenTablePro(DescribeForbiddenTableProRequest req)
        {
            return InternalRequestAsync<DescribeForbiddenTableProResponse>(req, "DescribeForbiddenTablePro");
        }

        /// <summary>
        /// 本接口（DescribeForbiddenTablePro）用于查询被禁用的表属性列表（新）
        /// </summary>
        /// <param name="req"><see cref="DescribeForbiddenTableProRequest"/></param>
        /// <returns><see cref="DescribeForbiddenTableProResponse"/></returns>
        public DescribeForbiddenTableProResponse DescribeForbiddenTableProSync(DescribeForbiddenTableProRequest req)
        {
            return InternalRequestAsync<DescribeForbiddenTableProResponse>(req, "DescribeForbiddenTablePro")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询托管存储指定目录的Summary
        /// </summary>
        /// <param name="req"><see cref="DescribeLakeFsDirSummaryRequest"/></param>
        /// <returns><see cref="DescribeLakeFsDirSummaryResponse"/></returns>
        public Task<DescribeLakeFsDirSummaryResponse> DescribeLakeFsDirSummary(DescribeLakeFsDirSummaryRequest req)
        {
            return InternalRequestAsync<DescribeLakeFsDirSummaryResponse>(req, "DescribeLakeFsDirSummary");
        }

        /// <summary>
        /// 查询托管存储指定目录的Summary
        /// </summary>
        /// <param name="req"><see cref="DescribeLakeFsDirSummaryRequest"/></param>
        /// <returns><see cref="DescribeLakeFsDirSummaryResponse"/></returns>
        public DescribeLakeFsDirSummaryResponse DescribeLakeFsDirSummarySync(DescribeLakeFsDirSummaryRequest req)
        {
            return InternalRequestAsync<DescribeLakeFsDirSummaryResponse>(req, "DescribeLakeFsDirSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户的托管存储信息
        /// </summary>
        /// <param name="req"><see cref="DescribeLakeFsInfoRequest"/></param>
        /// <returns><see cref="DescribeLakeFsInfoResponse"/></returns>
        public Task<DescribeLakeFsInfoResponse> DescribeLakeFsInfo(DescribeLakeFsInfoRequest req)
        {
            return InternalRequestAsync<DescribeLakeFsInfoResponse>(req, "DescribeLakeFsInfo");
        }

        /// <summary>
        /// 查询用户的托管存储信息
        /// </summary>
        /// <param name="req"><see cref="DescribeLakeFsInfoRequest"/></param>
        /// <returns><see cref="DescribeLakeFsInfoResponse"/></returns>
        public DescribeLakeFsInfoResponse DescribeLakeFsInfoSync(DescribeLakeFsInfoRequest req)
        {
            return InternalRequestAsync<DescribeLakeFsInfoResponse>(req, "DescribeLakeFsInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取LakeFs上task执行结果访问信息
        /// </summary>
        /// <param name="req"><see cref="DescribeLakeFsTaskResultRequest"/></param>
        /// <returns><see cref="DescribeLakeFsTaskResultResponse"/></returns>
        public Task<DescribeLakeFsTaskResultResponse> DescribeLakeFsTaskResult(DescribeLakeFsTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeLakeFsTaskResultResponse>(req, "DescribeLakeFsTaskResult");
        }

        /// <summary>
        /// 获取LakeFs上task执行结果访问信息
        /// </summary>
        /// <param name="req"><see cref="DescribeLakeFsTaskResultRequest"/></param>
        /// <returns><see cref="DescribeLakeFsTaskResultResponse"/></returns>
        public DescribeLakeFsTaskResultResponse DescribeLakeFsTaskResultSync(DescribeLakeFsTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeLakeFsTaskResultResponse>(req, "DescribeLakeFsTaskResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取账户子账户信息
        /// </summary>
        /// <param name="req"><see cref="DescribeMCPSubUinRequest"/></param>
        /// <returns><see cref="DescribeMCPSubUinResponse"/></returns>
        public Task<DescribeMCPSubUinResponse> DescribeMCPSubUin(DescribeMCPSubUinRequest req)
        {
            return InternalRequestAsync<DescribeMCPSubUinResponse>(req, "DescribeMCPSubUin");
        }

        /// <summary>
        /// 获取账户子账户信息
        /// </summary>
        /// <param name="req"><see cref="DescribeMCPSubUinRequest"/></param>
        /// <returns><see cref="DescribeMCPSubUinResponse"/></returns>
        public DescribeMCPSubUinResponse DescribeMCPSubUinSync(DescribeMCPSubUinRequest req)
        {
            return InternalRequestAsync<DescribeMCPSubUinResponse>(req, "DescribeMCPSubUin")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（DescribeTasks）用于查询任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMCPTaskRequest"/></param>
        /// <returns><see cref="DescribeMCPTaskResponse"/></returns>
        public Task<DescribeMCPTaskResponse> DescribeMCPTask(DescribeMCPTaskRequest req)
        {
            return InternalRequestAsync<DescribeMCPTaskResponse>(req, "DescribeMCPTask");
        }

        /// <summary>
        /// 该接口（DescribeTasks）用于查询任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMCPTaskRequest"/></param>
        /// <returns><see cref="DescribeMCPTaskResponse"/></returns>
        public DescribeMCPTaskResponse DescribeMCPTaskSync(DescribeMCPTaskRequest req)
        {
            return InternalRequestAsync<DescribeMCPTaskResponse>(req, "DescribeMCPTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取任务结果查询
        /// </summary>
        /// <param name="req"><see cref="DescribeMCPTaskResultRequest"/></param>
        /// <returns><see cref="DescribeMCPTaskResultResponse"/></returns>
        public Task<DescribeMCPTaskResultResponse> DescribeMCPTaskResult(DescribeMCPTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeMCPTaskResultResponse>(req, "DescribeMCPTaskResult");
        }

        /// <summary>
        /// 获取任务结果查询
        /// </summary>
        /// <param name="req"><see cref="DescribeMCPTaskResultRequest"/></param>
        /// <returns><see cref="DescribeMCPTaskResultResponse"/></returns>
        public DescribeMCPTaskResultResponse DescribeMCPTaskResultSync(DescribeMCPTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeMCPTaskResultResponse>(req, "DescribeMCPTaskResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据资源组获取spark session列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNativeSparkSessionsRequest"/></param>
        /// <returns><see cref="DescribeNativeSparkSessionsResponse"/></returns>
        public Task<DescribeNativeSparkSessionsResponse> DescribeNativeSparkSessions(DescribeNativeSparkSessionsRequest req)
        {
            return InternalRequestAsync<DescribeNativeSparkSessionsResponse>(req, "DescribeNativeSparkSessions");
        }

        /// <summary>
        /// 根据资源组获取spark session列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNativeSparkSessionsRequest"/></param>
        /// <returns><see cref="DescribeNativeSparkSessionsResponse"/></returns>
        public DescribeNativeSparkSessionsResponse DescribeNativeSparkSessionsSync(DescribeNativeSparkSessionsRequest req)
        {
            return InternalRequestAsync<DescribeNativeSparkSessionsResponse>(req, "DescribeNativeSparkSessions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询网络配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkConnectionsRequest"/></param>
        /// <returns><see cref="DescribeNetworkConnectionsResponse"/></returns>
        public Task<DescribeNetworkConnectionsResponse> DescribeNetworkConnections(DescribeNetworkConnectionsRequest req)
        {
            return InternalRequestAsync<DescribeNetworkConnectionsResponse>(req, "DescribeNetworkConnections");
        }

        /// <summary>
        /// 查询网络配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkConnectionsRequest"/></param>
        /// <returns><see cref="DescribeNetworkConnectionsResponse"/></returns>
        public DescribeNetworkConnectionsResponse DescribeNetworkConnectionsSync(DescribeNetworkConnectionsRequest req)
        {
            return InternalRequestAsync<DescribeNetworkConnectionsResponse>(req, "DescribeNetworkConnections")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeNotebookSession）用于查询交互式 session详情信息
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookSessionRequest"/></param>
        /// <returns><see cref="DescribeNotebookSessionResponse"/></returns>
        public Task<DescribeNotebookSessionResponse> DescribeNotebookSession(DescribeNotebookSessionRequest req)
        {
            return InternalRequestAsync<DescribeNotebookSessionResponse>(req, "DescribeNotebookSession");
        }

        /// <summary>
        /// 本接口（DescribeNotebookSession）用于查询交互式 session详情信息
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookSessionRequest"/></param>
        /// <returns><see cref="DescribeNotebookSessionResponse"/></returns>
        public DescribeNotebookSessionResponse DescribeNotebookSessionSync(DescribeNotebookSessionRequest req)
        {
            return InternalRequestAsync<DescribeNotebookSessionResponse>(req, "DescribeNotebookSession")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeNotebookSessionLog）用于查询交互式 session日志
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookSessionLogRequest"/></param>
        /// <returns><see cref="DescribeNotebookSessionLogResponse"/></returns>
        public Task<DescribeNotebookSessionLogResponse> DescribeNotebookSessionLog(DescribeNotebookSessionLogRequest req)
        {
            return InternalRequestAsync<DescribeNotebookSessionLogResponse>(req, "DescribeNotebookSessionLog");
        }

        /// <summary>
        /// 本接口（DescribeNotebookSessionLog）用于查询交互式 session日志
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookSessionLogRequest"/></param>
        /// <returns><see cref="DescribeNotebookSessionLogResponse"/></returns>
        public DescribeNotebookSessionLogResponse DescribeNotebookSessionLogSync(DescribeNotebookSessionLogRequest req)
        {
            return InternalRequestAsync<DescribeNotebookSessionLogResponse>(req, "DescribeNotebookSessionLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeNotebookSessionStatement）用于查询session 中执行任务的详情
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookSessionStatementRequest"/></param>
        /// <returns><see cref="DescribeNotebookSessionStatementResponse"/></returns>
        public Task<DescribeNotebookSessionStatementResponse> DescribeNotebookSessionStatement(DescribeNotebookSessionStatementRequest req)
        {
            return InternalRequestAsync<DescribeNotebookSessionStatementResponse>(req, "DescribeNotebookSessionStatement");
        }

        /// <summary>
        /// 本接口（DescribeNotebookSessionStatement）用于查询session 中执行任务的详情
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookSessionStatementRequest"/></param>
        /// <returns><see cref="DescribeNotebookSessionStatementResponse"/></returns>
        public DescribeNotebookSessionStatementResponse DescribeNotebookSessionStatementSync(DescribeNotebookSessionStatementRequest req)
        {
            return InternalRequestAsync<DescribeNotebookSessionStatementResponse>(req, "DescribeNotebookSessionStatement")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeNotebookSessionStatementSqlResult）用于获取statement运行结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookSessionStatementSqlResultRequest"/></param>
        /// <returns><see cref="DescribeNotebookSessionStatementSqlResultResponse"/></returns>
        public Task<DescribeNotebookSessionStatementSqlResultResponse> DescribeNotebookSessionStatementSqlResult(DescribeNotebookSessionStatementSqlResultRequest req)
        {
            return InternalRequestAsync<DescribeNotebookSessionStatementSqlResultResponse>(req, "DescribeNotebookSessionStatementSqlResult");
        }

        /// <summary>
        /// 本接口（DescribeNotebookSessionStatementSqlResult）用于获取statement运行结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookSessionStatementSqlResultRequest"/></param>
        /// <returns><see cref="DescribeNotebookSessionStatementSqlResultResponse"/></returns>
        public DescribeNotebookSessionStatementSqlResultResponse DescribeNotebookSessionStatementSqlResultSync(DescribeNotebookSessionStatementSqlResultRequest req)
        {
            return InternalRequestAsync<DescribeNotebookSessionStatementSqlResultResponse>(req, "DescribeNotebookSessionStatementSqlResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeNotebookSessionStatements）用于查询Session中执行的任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookSessionStatementsRequest"/></param>
        /// <returns><see cref="DescribeNotebookSessionStatementsResponse"/></returns>
        public Task<DescribeNotebookSessionStatementsResponse> DescribeNotebookSessionStatements(DescribeNotebookSessionStatementsRequest req)
        {
            return InternalRequestAsync<DescribeNotebookSessionStatementsResponse>(req, "DescribeNotebookSessionStatements");
        }

        /// <summary>
        /// 本接口（DescribeNotebookSessionStatements）用于查询Session中执行的任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookSessionStatementsRequest"/></param>
        /// <returns><see cref="DescribeNotebookSessionStatementsResponse"/></returns>
        public DescribeNotebookSessionStatementsResponse DescribeNotebookSessionStatementsSync(DescribeNotebookSessionStatementsRequest req)
        {
            return InternalRequestAsync<DescribeNotebookSessionStatementsResponse>(req, "DescribeNotebookSessionStatements")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeNotebookSessions）用于查询交互式 session列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookSessionsRequest"/></param>
        /// <returns><see cref="DescribeNotebookSessionsResponse"/></returns>
        public Task<DescribeNotebookSessionsResponse> DescribeNotebookSessions(DescribeNotebookSessionsRequest req)
        {
            return InternalRequestAsync<DescribeNotebookSessionsResponse>(req, "DescribeNotebookSessions");
        }

        /// <summary>
        /// 本接口（DescribeNotebookSessions）用于查询交互式 session列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookSessionsRequest"/></param>
        /// <returns><see cref="DescribeNotebookSessionsResponse"/></returns>
        public DescribeNotebookSessionsResponse DescribeNotebookSessionsSync(DescribeNotebookSessionsRequest req)
        {
            return InternalRequestAsync<DescribeNotebookSessionsResponse>(req, "DescribeNotebookSessions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口（DescribeOtherCHDFSBindingList）用于查询其他产品元数据加速桶绑定列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOtherCHDFSBindingListRequest"/></param>
        /// <returns><see cref="DescribeOtherCHDFSBindingListResponse"/></returns>
        public Task<DescribeOtherCHDFSBindingListResponse> DescribeOtherCHDFSBindingList(DescribeOtherCHDFSBindingListRequest req)
        {
            return InternalRequestAsync<DescribeOtherCHDFSBindingListResponse>(req, "DescribeOtherCHDFSBindingList");
        }

        /// <summary>
        /// 此接口（DescribeOtherCHDFSBindingList）用于查询其他产品元数据加速桶绑定列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOtherCHDFSBindingListRequest"/></param>
        /// <returns><see cref="DescribeOtherCHDFSBindingListResponse"/></returns>
        public DescribeOtherCHDFSBindingListResponse DescribeOtherCHDFSBindingListSync(DescribeOtherCHDFSBindingListRequest req)
        {
            return InternalRequestAsync<DescribeOtherCHDFSBindingListResponse>(req, "DescribeOtherCHDFSBindingList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取指定资源分区详情
        /// </summary>
        /// <param name="req"><see cref="DescribePartitionDetailRequest"/></param>
        /// <returns><see cref="DescribePartitionDetailResponse"/></returns>
        public Task<DescribePartitionDetailResponse> DescribePartitionDetail(DescribePartitionDetailRequest req)
        {
            return InternalRequestAsync<DescribePartitionDetailResponse>(req, "DescribePartitionDetail");
        }

        /// <summary>
        /// 获取指定资源分区详情
        /// </summary>
        /// <param name="req"><see cref="DescribePartitionDetailRequest"/></param>
        /// <returns><see cref="DescribePartitionDetailResponse"/></returns>
        public DescribePartitionDetailResponse DescribePartitionDetailSync(DescribePartitionDetailRequest req)
        {
            return InternalRequestAsync<DescribePartitionDetailResponse>(req, "DescribePartitionDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定分区的所有队列列表
        /// </summary>
        /// <param name="req"><see cref="DescribePartitionQueuesRequest"/></param>
        /// <returns><see cref="DescribePartitionQueuesResponse"/></returns>
        public Task<DescribePartitionQueuesResponse> DescribePartitionQueues(DescribePartitionQueuesRequest req)
        {
            return InternalRequestAsync<DescribePartitionQueuesResponse>(req, "DescribePartitionQueues");
        }

        /// <summary>
        /// 查询指定分区的所有队列列表
        /// </summary>
        /// <param name="req"><see cref="DescribePartitionQueuesRequest"/></param>
        /// <returns><see cref="DescribePartitionQueuesResponse"/></returns>
        public DescribePartitionQueuesResponse DescribePartitionQueuesSync(DescribePartitionQueuesRequest req)
        {
            return InternalRequestAsync<DescribePartitionQueuesResponse>(req, "DescribePartitionQueues")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取分区列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribePartitionsRequest"/></param>
        /// <returns><see cref="DescribePartitionsResponse"/></returns>
        public Task<DescribePartitionsResponse> DescribePartitions(DescribePartitionsRequest req)
        {
            return InternalRequestAsync<DescribePartitionsResponse>(req, "DescribePartitions");
        }

        /// <summary>
        /// 获取分区列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribePartitionsRequest"/></param>
        /// <returns><see cref="DescribePartitionsResponse"/></returns>
        public DescribePartitionsResponse DescribePartitionsSync(DescribePartitionsRequest req)
        {
            return InternalRequestAsync<DescribePartitionsResponse>(req, "DescribePartitions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口根据资源组ID查询资源组CU使用情况
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceGroupUsageInfoRequest"/></param>
        /// <returns><see cref="DescribeResourceGroupUsageInfoResponse"/></returns>
        public Task<DescribeResourceGroupUsageInfoResponse> DescribeResourceGroupUsageInfo(DescribeResourceGroupUsageInfoRequest req)
        {
            return InternalRequestAsync<DescribeResourceGroupUsageInfoResponse>(req, "DescribeResourceGroupUsageInfo");
        }

        /// <summary>
        /// 本接口根据资源组ID查询资源组CU使用情况
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceGroupUsageInfoRequest"/></param>
        /// <returns><see cref="DescribeResourceGroupUsageInfoResponse"/></returns>
        public DescribeResourceGroupUsageInfoResponse DescribeResourceGroupUsageInfoSync(DescribeResourceGroupUsageInfoRequest req)
        {
            return InternalRequestAsync<DescribeResourceGroupUsageInfoResponse>(req, "DescribeResourceGroupUsageInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询结果下载任务
        /// </summary>
        /// <param name="req"><see cref="DescribeResultDownloadRequest"/></param>
        /// <returns><see cref="DescribeResultDownloadResponse"/></returns>
        public Task<DescribeResultDownloadResponse> DescribeResultDownload(DescribeResultDownloadRequest req)
        {
            return InternalRequestAsync<DescribeResultDownloadResponse>(req, "DescribeResultDownload");
        }

        /// <summary>
        /// 查询结果下载任务
        /// </summary>
        /// <param name="req"><see cref="DescribeResultDownloadRequest"/></param>
        /// <returns><see cref="DescribeResultDownloadResponse"/></returns>
        public DescribeResultDownloadResponse DescribeResultDownloadSync(DescribeResultDownloadRequest req)
        {
            return InternalRequestAsync<DescribeResultDownloadResponse>(req, "DescribeResultDownload")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询可售卖的地域列表，仅返回状态为AVAILABLE的地域
        /// </summary>
        /// <param name="req"><see cref="DescribeSaleRegionsRequest"/></param>
        /// <returns><see cref="DescribeSaleRegionsResponse"/></returns>
        public Task<DescribeSaleRegionsResponse> DescribeSaleRegions(DescribeSaleRegionsRequest req)
        {
            return InternalRequestAsync<DescribeSaleRegionsResponse>(req, "DescribeSaleRegions");
        }

        /// <summary>
        /// 查询可售卖的地域列表，仅返回状态为AVAILABLE的地域
        /// </summary>
        /// <param name="req"><see cref="DescribeSaleRegionsRequest"/></param>
        /// <returns><see cref="DescribeSaleRegionsResponse"/></returns>
        public DescribeSaleRegionsResponse DescribeSaleRegionsSync(DescribeSaleRegionsRequest req)
        {
            return InternalRequestAsync<DescribeSaleRegionsResponse>(req, "DescribeSaleRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询当前地域可售卖的资源规格和最大配额
        /// </summary>
        /// <param name="req"><see cref="DescribeSaleResourceInfoRequest"/></param>
        /// <returns><see cref="DescribeSaleResourceInfoResponse"/></returns>
        public Task<DescribeSaleResourceInfoResponse> DescribeSaleResourceInfo(DescribeSaleResourceInfoRequest req)
        {
            return InternalRequestAsync<DescribeSaleResourceInfoResponse>(req, "DescribeSaleResourceInfo");
        }

        /// <summary>
        /// 查询当前地域可售卖的资源规格和最大配额
        /// </summary>
        /// <param name="req"><see cref="DescribeSaleResourceInfoRequest"/></param>
        /// <returns><see cref="DescribeSaleResourceInfoResponse"/></returns>
        public DescribeSaleResourceInfoResponse DescribeSaleResourceInfoSync(DescribeSaleResourceInfoRequest req)
        {
            return InternalRequestAsync<DescribeSaleResourceInfoResponse>(req, "DescribeSaleResourceInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（DescribeScripts）用于查询SQL脚本列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScriptsRequest"/></param>
        /// <returns><see cref="DescribeScriptsResponse"/></returns>
        public Task<DescribeScriptsResponse> DescribeScripts(DescribeScriptsRequest req)
        {
            return InternalRequestAsync<DescribeScriptsResponse>(req, "DescribeScripts");
        }

        /// <summary>
        /// 该接口（DescribeScripts）用于查询SQL脚本列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScriptsRequest"/></param>
        /// <returns><see cref="DescribeScriptsResponse"/></returns>
        public DescribeScriptsResponse DescribeScriptsSync(DescribeScriptsRequest req)
        {
            return InternalRequestAsync<DescribeScriptsResponse>(req, "DescribeScripts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取指定大版本下所有小版本的所有内置镜像
        /// </summary>
        /// <param name="req"><see cref="DescribeSessionImageVersionRequest"/></param>
        /// <returns><see cref="DescribeSessionImageVersionResponse"/></returns>
        public Task<DescribeSessionImageVersionResponse> DescribeSessionImageVersion(DescribeSessionImageVersionRequest req)
        {
            return InternalRequestAsync<DescribeSessionImageVersionResponse>(req, "DescribeSessionImageVersion");
        }

        /// <summary>
        /// 获取指定大版本下所有小版本的所有内置镜像
        /// </summary>
        /// <param name="req"><see cref="DescribeSessionImageVersionRequest"/></param>
        /// <returns><see cref="DescribeSessionImageVersionResponse"/></returns>
        public DescribeSessionImageVersionResponse DescribeSessionImageVersionSync(DescribeSessionImageVersionRequest req)
        {
            return InternalRequestAsync<DescribeSessionImageVersionResponse>(req, "DescribeSessionImageVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询spark作业信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkAppJobRequest"/></param>
        /// <returns><see cref="DescribeSparkAppJobResponse"/></returns>
        public Task<DescribeSparkAppJobResponse> DescribeSparkAppJob(DescribeSparkAppJobRequest req)
        {
            return InternalRequestAsync<DescribeSparkAppJobResponse>(req, "DescribeSparkAppJob");
        }

        /// <summary>
        /// 查询spark作业信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkAppJobRequest"/></param>
        /// <returns><see cref="DescribeSparkAppJobResponse"/></returns>
        public DescribeSparkAppJobResponse DescribeSparkAppJobSync(DescribeSparkAppJobRequest req)
        {
            return InternalRequestAsync<DescribeSparkAppJobResponse>(req, "DescribeSparkAppJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询spark作业列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkAppJobsRequest"/></param>
        /// <returns><see cref="DescribeSparkAppJobsResponse"/></returns>
        public Task<DescribeSparkAppJobsResponse> DescribeSparkAppJobs(DescribeSparkAppJobsRequest req)
        {
            return InternalRequestAsync<DescribeSparkAppJobsResponse>(req, "DescribeSparkAppJobs");
        }

        /// <summary>
        /// 查询spark作业列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkAppJobsRequest"/></param>
        /// <returns><see cref="DescribeSparkAppJobsResponse"/></returns>
        public DescribeSparkAppJobsResponse DescribeSparkAppJobsSync(DescribeSparkAppJobsRequest req)
        {
            return InternalRequestAsync<DescribeSparkAppJobsResponse>(req, "DescribeSparkAppJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Spark作业的运行任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkAppTasksRequest"/></param>
        /// <returns><see cref="DescribeSparkAppTasksResponse"/></returns>
        public Task<DescribeSparkAppTasksResponse> DescribeSparkAppTasks(DescribeSparkAppTasksRequest req)
        {
            return InternalRequestAsync<DescribeSparkAppTasksResponse>(req, "DescribeSparkAppTasks");
        }

        /// <summary>
        /// 查询Spark作业的运行任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkAppTasksRequest"/></param>
        /// <returns><see cref="DescribeSparkAppTasksResponse"/></returns>
        public DescribeSparkAppTasksResponse DescribeSparkAppTasksSync(DescribeSparkAppTasksRequest req)
        {
            return InternalRequestAsync<DescribeSparkAppTasksResponse>(req, "DescribeSparkAppTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeSparkSessionBatchSQL）用于查询Spark SQL批任务运行状态
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkSessionBatchSQLRequest"/></param>
        /// <returns><see cref="DescribeSparkSessionBatchSQLResponse"/></returns>
        public Task<DescribeSparkSessionBatchSQLResponse> DescribeSparkSessionBatchSQL(DescribeSparkSessionBatchSQLRequest req)
        {
            return InternalRequestAsync<DescribeSparkSessionBatchSQLResponse>(req, "DescribeSparkSessionBatchSQL");
        }

        /// <summary>
        /// 本接口（DescribeSparkSessionBatchSQL）用于查询Spark SQL批任务运行状态
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkSessionBatchSQLRequest"/></param>
        /// <returns><see cref="DescribeSparkSessionBatchSQLResponse"/></returns>
        public DescribeSparkSessionBatchSQLResponse DescribeSparkSessionBatchSQLSync(DescribeSparkSessionBatchSQLRequest req)
        {
            return InternalRequestAsync<DescribeSparkSessionBatchSQLResponse>(req, "DescribeSparkSessionBatchSQL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeSparkSessionBatchSQLCost）用于查询Spark SQL批任务消耗
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkSessionBatchSQLCostRequest"/></param>
        /// <returns><see cref="DescribeSparkSessionBatchSQLCostResponse"/></returns>
        public Task<DescribeSparkSessionBatchSQLCostResponse> DescribeSparkSessionBatchSQLCost(DescribeSparkSessionBatchSQLCostRequest req)
        {
            return InternalRequestAsync<DescribeSparkSessionBatchSQLCostResponse>(req, "DescribeSparkSessionBatchSQLCost");
        }

        /// <summary>
        /// 本接口（DescribeSparkSessionBatchSQLCost）用于查询Spark SQL批任务消耗
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkSessionBatchSQLCostRequest"/></param>
        /// <returns><see cref="DescribeSparkSessionBatchSQLCostResponse"/></returns>
        public DescribeSparkSessionBatchSQLCostResponse DescribeSparkSessionBatchSQLCostSync(DescribeSparkSessionBatchSQLCostRequest req)
        {
            return InternalRequestAsync<DescribeSparkSessionBatchSQLCostResponse>(req, "DescribeSparkSessionBatchSQLCost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeSparkSessionBatchSqlLog）用于查询Spark SQL批任务日志
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkSessionBatchSqlLogRequest"/></param>
        /// <returns><see cref="DescribeSparkSessionBatchSqlLogResponse"/></returns>
        public Task<DescribeSparkSessionBatchSqlLogResponse> DescribeSparkSessionBatchSqlLog(DescribeSparkSessionBatchSqlLogRequest req)
        {
            return InternalRequestAsync<DescribeSparkSessionBatchSqlLogResponse>(req, "DescribeSparkSessionBatchSqlLog");
        }

        /// <summary>
        /// 本接口（DescribeSparkSessionBatchSqlLog）用于查询Spark SQL批任务日志
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkSessionBatchSqlLogRequest"/></param>
        /// <returns><see cref="DescribeSparkSessionBatchSqlLogResponse"/></returns>
        public DescribeSparkSessionBatchSqlLogResponse DescribeSparkSessionBatchSqlLogSync(DescribeSparkSessionBatchSqlLogRequest req)
        {
            return InternalRequestAsync<DescribeSparkSessionBatchSqlLogResponse>(req, "DescribeSparkSessionBatchSqlLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询标准引擎资源组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeStandardEngineResourceGroupConfigInfoRequest"/></param>
        /// <returns><see cref="DescribeStandardEngineResourceGroupConfigInfoResponse"/></returns>
        public Task<DescribeStandardEngineResourceGroupConfigInfoResponse> DescribeStandardEngineResourceGroupConfigInfo(DescribeStandardEngineResourceGroupConfigInfoRequest req)
        {
            return InternalRequestAsync<DescribeStandardEngineResourceGroupConfigInfoResponse>(req, "DescribeStandardEngineResourceGroupConfigInfo");
        }

        /// <summary>
        /// 查询标准引擎资源组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeStandardEngineResourceGroupConfigInfoRequest"/></param>
        /// <returns><see cref="DescribeStandardEngineResourceGroupConfigInfoResponse"/></returns>
        public DescribeStandardEngineResourceGroupConfigInfoResponse DescribeStandardEngineResourceGroupConfigInfoSync(DescribeStandardEngineResourceGroupConfigInfoRequest req)
        {
            return InternalRequestAsync<DescribeStandardEngineResourceGroupConfigInfoResponse>(req, "DescribeStandardEngineResourceGroupConfigInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询标准引擎资源组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeStandardEngineResourceGroupsRequest"/></param>
        /// <returns><see cref="DescribeStandardEngineResourceGroupsResponse"/></returns>
        public Task<DescribeStandardEngineResourceGroupsResponse> DescribeStandardEngineResourceGroups(DescribeStandardEngineResourceGroupsRequest req)
        {
            return InternalRequestAsync<DescribeStandardEngineResourceGroupsResponse>(req, "DescribeStandardEngineResourceGroups");
        }

        /// <summary>
        /// 查询标准引擎资源组信息
        /// </summary>
        /// <param name="req"><see cref="DescribeStandardEngineResourceGroupsRequest"/></param>
        /// <returns><see cref="DescribeStandardEngineResourceGroupsResponse"/></returns>
        public DescribeStandardEngineResourceGroupsResponse DescribeStandardEngineResourceGroupsSync(DescribeStandardEngineResourceGroupsRequest req)
        {
            return InternalRequestAsync<DescribeStandardEngineResourceGroupsResponse>(req, "DescribeStandardEngineResourceGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询计算结果存储位置。
        /// </summary>
        /// <param name="req"><see cref="DescribeStoreLocationRequest"/></param>
        /// <returns><see cref="DescribeStoreLocationResponse"/></returns>
        public Task<DescribeStoreLocationResponse> DescribeStoreLocation(DescribeStoreLocationRequest req)
        {
            return InternalRequestAsync<DescribeStoreLocationResponse>(req, "DescribeStoreLocation");
        }

        /// <summary>
        /// 查询计算结果存储位置。
        /// </summary>
        /// <param name="req"><see cref="DescribeStoreLocationRequest"/></param>
        /// <returns><see cref="DescribeStoreLocationResponse"/></returns>
        public DescribeStoreLocationResponse DescribeStoreLocationSync(DescribeStoreLocationRequest req)
        {
            return InternalRequestAsync<DescribeStoreLocationResponse>(req, "DescribeStoreLocation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeSubUserAccessPolicy）用于开通了第三方平台访问的用户，查询其子用户的访问策略
        /// </summary>
        /// <param name="req"><see cref="DescribeSubUserAccessPolicyRequest"/></param>
        /// <returns><see cref="DescribeSubUserAccessPolicyResponse"/></returns>
        public Task<DescribeSubUserAccessPolicyResponse> DescribeSubUserAccessPolicy(DescribeSubUserAccessPolicyRequest req)
        {
            return InternalRequestAsync<DescribeSubUserAccessPolicyResponse>(req, "DescribeSubUserAccessPolicy");
        }

        /// <summary>
        /// 本接口（DescribeSubUserAccessPolicy）用于开通了第三方平台访问的用户，查询其子用户的访问策略
        /// </summary>
        /// <param name="req"><see cref="DescribeSubUserAccessPolicyRequest"/></param>
        /// <returns><see cref="DescribeSubUserAccessPolicyResponse"/></returns>
        public DescribeSubUserAccessPolicyResponse DescribeSubUserAccessPolicySync(DescribeSubUserAccessPolicyRequest req)
        {
            return InternalRequestAsync<DescribeSubUserAccessPolicyResponse>(req, "DescribeSubUserAccessPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 是否成功开通TCLake
        /// </summary>
        /// <param name="req"><see cref="DescribeTCLakeMetaInstanceRequest"/></param>
        /// <returns><see cref="DescribeTCLakeMetaInstanceResponse"/></returns>
        public Task<DescribeTCLakeMetaInstanceResponse> DescribeTCLakeMetaInstance(DescribeTCLakeMetaInstanceRequest req)
        {
            return InternalRequestAsync<DescribeTCLakeMetaInstanceResponse>(req, "DescribeTCLakeMetaInstance");
        }

        /// <summary>
        /// 是否成功开通TCLake
        /// </summary>
        /// <param name="req"><see cref="DescribeTCLakeMetaInstanceRequest"/></param>
        /// <returns><see cref="DescribeTCLakeMetaInstanceResponse"/></returns>
        public DescribeTCLakeMetaInstanceResponse DescribeTCLakeMetaInstanceSync(DescribeTCLakeMetaInstanceRequest req)
        {
            return InternalRequestAsync<DescribeTCLakeMetaInstanceResponse>(req, "DescribeTCLakeMetaInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeTable），用于查询单个表的详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeTableRequest"/></param>
        /// <returns><see cref="DescribeTableResponse"/></returns>
        public Task<DescribeTableResponse> DescribeTable(DescribeTableRequest req)
        {
            return InternalRequestAsync<DescribeTableResponse>(req, "DescribeTable");
        }

        /// <summary>
        /// 本接口（DescribeTable），用于查询单个表的详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeTableRequest"/></param>
        /// <returns><see cref="DescribeTableResponse"/></returns>
        public DescribeTableResponse DescribeTableSync(DescribeTableRequest req)
        {
            return InternalRequestAsync<DescribeTableResponse>(req, "DescribeTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeTablePartitions）用于查询数据表分区信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTablePartitionsRequest"/></param>
        /// <returns><see cref="DescribeTablePartitionsResponse"/></returns>
        public Task<DescribeTablePartitionsResponse> DescribeTablePartitions(DescribeTablePartitionsRequest req)
        {
            return InternalRequestAsync<DescribeTablePartitionsResponse>(req, "DescribeTablePartitions");
        }

        /// <summary>
        /// 本接口（DescribeTablePartitions）用于查询数据表分区信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTablePartitionsRequest"/></param>
        /// <returns><see cref="DescribeTablePartitionsResponse"/></returns>
        public DescribeTablePartitionsResponse DescribeTablePartitionsSync(DescribeTablePartitionsRequest req)
        {
            return InternalRequestAsync<DescribeTablePartitionsResponse>(req, "DescribeTablePartitions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeTables）用于查询数据表列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeTablesRequest"/></param>
        /// <returns><see cref="DescribeTablesResponse"/></returns>
        public Task<DescribeTablesResponse> DescribeTables(DescribeTablesRequest req)
        {
            return InternalRequestAsync<DescribeTablesResponse>(req, "DescribeTables");
        }

        /// <summary>
        /// 本接口（DescribeTables）用于查询数据表列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeTablesRequest"/></param>
        /// <returns><see cref="DescribeTablesResponse"/></returns>
        public DescribeTablesResponse DescribeTablesSync(DescribeTablesRequest req)
        {
            return InternalRequestAsync<DescribeTablesResponse>(req, "DescribeTables")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeTables）用于查询数据表名称列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTablesNameRequest"/></param>
        /// <returns><see cref="DescribeTablesNameResponse"/></returns>
        public Task<DescribeTablesNameResponse> DescribeTablesName(DescribeTablesNameRequest req)
        {
            return InternalRequestAsync<DescribeTablesNameResponse>(req, "DescribeTablesName");
        }

        /// <summary>
        /// 本接口（DescribeTables）用于查询数据表名称列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTablesNameRequest"/></param>
        /// <returns><see cref="DescribeTablesNameResponse"/></returns>
        public DescribeTablesNameResponse DescribeTablesNameSync(DescribeTablesNameRequest req)
        {
            return InternalRequestAsync<DescribeTablesNameResponse>(req, "DescribeTablesName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（DescribeTaskDetail）用于查询历史任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeTaskDetailResponse"/></returns>
        public Task<DescribeTaskDetailResponse> DescribeTaskDetail(DescribeTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeTaskDetailResponse>(req, "DescribeTaskDetail");
        }

        /// <summary>
        /// 该接口（DescribeTaskDetail）用于查询历史任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeTaskDetailResponse"/></returns>
        public DescribeTaskDetailResponse DescribeTaskDetailSync(DescribeTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeTaskDetailResponse>(req, "DescribeTaskDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（DescribleTasks）用于查询任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskListRequest"/></param>
        /// <returns><see cref="DescribeTaskListResponse"/></returns>
        public Task<DescribeTaskListResponse> DescribeTaskList(DescribeTaskListRequest req)
        {
            return InternalRequestAsync<DescribeTaskListResponse>(req, "DescribeTaskList");
        }

        /// <summary>
        /// 该接口（DescribleTasks）用于查询任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskListRequest"/></param>
        /// <returns><see cref="DescribeTaskListResponse"/></returns>
        public DescribeTaskListResponse DescribeTaskListSync(DescribeTaskListRequest req)
        {
            return InternalRequestAsync<DescribeTaskListResponse>(req, "DescribeTaskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeTaskLog）用于获取spark 作业任务日志详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskLogRequest"/></param>
        /// <returns><see cref="DescribeTaskLogResponse"/></returns>
        public Task<DescribeTaskLogResponse> DescribeTaskLog(DescribeTaskLogRequest req)
        {
            return InternalRequestAsync<DescribeTaskLogResponse>(req, "DescribeTaskLog");
        }

        /// <summary>
        /// 本接口（DescribeTaskLog）用于获取spark 作业任务日志详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskLogRequest"/></param>
        /// <returns><see cref="DescribeTaskLogResponse"/></returns>
        public DescribeTaskLogResponse DescribeTaskLogSync(DescribeTaskLogRequest req)
        {
            return InternalRequestAsync<DescribeTaskLogResponse>(req, "DescribeTaskLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询任务监控指标信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskMonitorInfosRequest"/></param>
        /// <returns><see cref="DescribeTaskMonitorInfosResponse"/></returns>
        public Task<DescribeTaskMonitorInfosResponse> DescribeTaskMonitorInfos(DescribeTaskMonitorInfosRequest req)
        {
            return InternalRequestAsync<DescribeTaskMonitorInfosResponse>(req, "DescribeTaskMonitorInfos");
        }

        /// <summary>
        /// 查询任务监控指标信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskMonitorInfosRequest"/></param>
        /// <returns><see cref="DescribeTaskMonitorInfosResponse"/></returns>
        public DescribeTaskMonitorInfosResponse DescribeTaskMonitorInfosSync(DescribeTaskMonitorInfosRequest req)
        {
            return InternalRequestAsync<DescribeTaskMonitorInfosResponse>(req, "DescribeTaskMonitorInfos")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 返回任务洞察资源用量
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskResourceUsageRequest"/></param>
        /// <returns><see cref="DescribeTaskResourceUsageResponse"/></returns>
        public Task<DescribeTaskResourceUsageResponse> DescribeTaskResourceUsage(DescribeTaskResourceUsageRequest req)
        {
            return InternalRequestAsync<DescribeTaskResourceUsageResponse>(req, "DescribeTaskResourceUsage");
        }

        /// <summary>
        /// 返回任务洞察资源用量
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskResourceUsageRequest"/></param>
        /// <returns><see cref="DescribeTaskResourceUsageResponse"/></returns>
        public DescribeTaskResourceUsageResponse DescribeTaskResourceUsageSync(DescribeTaskResourceUsageRequest req)
        {
            return InternalRequestAsync<DescribeTaskResourceUsageResponse>(req, "DescribeTaskResourceUsage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询任务结果，仅支持30天以内的任务查询结果，且返回数据大小超过近50M会进行截断。
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskResultRequest"/></param>
        /// <returns><see cref="DescribeTaskResultResponse"/></returns>
        public Task<DescribeTaskResultResponse> DescribeTaskResult(DescribeTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeTaskResultResponse>(req, "DescribeTaskResult");
        }

        /// <summary>
        /// 查询任务结果，仅支持30天以内的任务查询结果，且返回数据大小超过近50M会进行截断。
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskResultRequest"/></param>
        /// <returns><see cref="DescribeTaskResultResponse"/></returns>
        public DescribeTaskResultResponse DescribeTaskResultSync(DescribeTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeTaskResultResponse>(req, "DescribeTaskResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（DescribeTasks）用于查询任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public Task<DescribeTasksResponse> DescribeTasks(DescribeTasksRequest req)
        {
            return InternalRequestAsync<DescribeTasksResponse>(req, "DescribeTasks");
        }

        /// <summary>
        /// 该接口（DescribeTasks）用于查询任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public DescribeTasksResponse DescribeTasksSync(DescribeTasksRequest req)
        {
            return InternalRequestAsync<DescribeTasksResponse>(req, "DescribeTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于洞察分析列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksAnalysisRequest"/></param>
        /// <returns><see cref="DescribeTasksAnalysisResponse"/></returns>
        public Task<DescribeTasksAnalysisResponse> DescribeTasksAnalysis(DescribeTasksAnalysisRequest req)
        {
            return InternalRequestAsync<DescribeTasksAnalysisResponse>(req, "DescribeTasksAnalysis");
        }

        /// <summary>
        /// 该接口用于洞察分析列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksAnalysisRequest"/></param>
        /// <returns><see cref="DescribeTasksAnalysisResponse"/></returns>
        public DescribeTasksAnalysisResponse DescribeTasksAnalysisSync(DescribeTasksAnalysisRequest req)
        {
            return InternalRequestAsync<DescribeTasksAnalysisResponse>(req, "DescribeTasksAnalysis")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（DescribeTasksCostInfo）用于查询任务消耗
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksCostInfoRequest"/></param>
        /// <returns><see cref="DescribeTasksCostInfoResponse"/></returns>
        public Task<DescribeTasksCostInfoResponse> DescribeTasksCostInfo(DescribeTasksCostInfoRequest req)
        {
            return InternalRequestAsync<DescribeTasksCostInfoResponse>(req, "DescribeTasksCostInfo");
        }

        /// <summary>
        /// 该接口（DescribeTasksCostInfo）用于查询任务消耗
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksCostInfoRequest"/></param>
        /// <returns><see cref="DescribeTasksCostInfoResponse"/></returns>
        public DescribeTasksCostInfoResponse DescribeTasksCostInfoSync(DescribeTasksCostInfoRequest req)
        {
            return InternalRequestAsync<DescribeTasksCostInfoResponse>(req, "DescribeTasksCostInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看任务概览页
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksOverviewRequest"/></param>
        /// <returns><see cref="DescribeTasksOverviewResponse"/></returns>
        public Task<DescribeTasksOverviewResponse> DescribeTasksOverview(DescribeTasksOverviewRequest req)
        {
            return InternalRequestAsync<DescribeTasksOverviewResponse>(req, "DescribeTasksOverview");
        }

        /// <summary>
        /// 查看任务概览页
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksOverviewRequest"/></param>
        /// <returns><see cref="DescribeTasksOverviewResponse"/></returns>
        public DescribeTasksOverviewResponse DescribeTasksOverviewSync(DescribeTasksOverviewRequest req)
        {
            return InternalRequestAsync<DescribeTasksOverviewResponse>(req, "DescribeTasksOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（RegisterThirdPartyAccessUser）查询开通第三方平台访问的用户信息
        /// </summary>
        /// <param name="req"><see cref="DescribeThirdPartyAccessUserRequest"/></param>
        /// <returns><see cref="DescribeThirdPartyAccessUserResponse"/></returns>
        public Task<DescribeThirdPartyAccessUserResponse> DescribeThirdPartyAccessUser(DescribeThirdPartyAccessUserRequest req)
        {
            return InternalRequestAsync<DescribeThirdPartyAccessUserResponse>(req, "DescribeThirdPartyAccessUser");
        }

        /// <summary>
        /// 本接口（RegisterThirdPartyAccessUser）查询开通第三方平台访问的用户信息
        /// </summary>
        /// <param name="req"><see cref="DescribeThirdPartyAccessUserRequest"/></param>
        /// <returns><see cref="DescribeThirdPartyAccessUserResponse"/></returns>
        public DescribeThirdPartyAccessUserResponse DescribeThirdPartyAccessUserSync(DescribeThirdPartyAccessUserRequest req)
        {
            return InternalRequestAsync<DescribeThirdPartyAccessUserResponse>(req, "DescribeThirdPartyAccessUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取UDF权限信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUDFPolicyRequest"/></param>
        /// <returns><see cref="DescribeUDFPolicyResponse"/></returns>
        public Task<DescribeUDFPolicyResponse> DescribeUDFPolicy(DescribeUDFPolicyRequest req)
        {
            return InternalRequestAsync<DescribeUDFPolicyResponse>(req, "DescribeUDFPolicy");
        }

        /// <summary>
        /// 获取UDF权限信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUDFPolicyRequest"/></param>
        /// <returns><see cref="DescribeUDFPolicyResponse"/></returns>
        public DescribeUDFPolicyResponse DescribeUDFPolicySync(DescribeUDFPolicyRequest req)
        {
            return InternalRequestAsync<DescribeUDFPolicyResponse>(req, "DescribeUDFPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询可更新配置的引擎列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUpdatableDataEnginesRequest"/></param>
        /// <returns><see cref="DescribeUpdatableDataEnginesResponse"/></returns>
        public Task<DescribeUpdatableDataEnginesResponse> DescribeUpdatableDataEngines(DescribeUpdatableDataEnginesRequest req)
        {
            return InternalRequestAsync<DescribeUpdatableDataEnginesResponse>(req, "DescribeUpdatableDataEngines");
        }

        /// <summary>
        /// 查询可更新配置的引擎列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUpdatableDataEnginesRequest"/></param>
        /// <returns><see cref="DescribeUpdatableDataEnginesResponse"/></returns>
        public DescribeUpdatableDataEnginesResponse DescribeUpdatableDataEnginesSync(DescribeUpdatableDataEnginesRequest req)
        {
            return InternalRequestAsync<DescribeUpdatableDataEnginesResponse>(req, "DescribeUpdatableDataEngines")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户自定义引擎参数
        /// </summary>
        /// <param name="req"><see cref="DescribeUserDataEngineConfigRequest"/></param>
        /// <returns><see cref="DescribeUserDataEngineConfigResponse"/></returns>
        public Task<DescribeUserDataEngineConfigResponse> DescribeUserDataEngineConfig(DescribeUserDataEngineConfigRequest req)
        {
            return InternalRequestAsync<DescribeUserDataEngineConfigResponse>(req, "DescribeUserDataEngineConfig");
        }

        /// <summary>
        /// 查询用户自定义引擎参数
        /// </summary>
        /// <param name="req"><see cref="DescribeUserDataEngineConfigRequest"/></param>
        /// <returns><see cref="DescribeUserDataEngineConfigResponse"/></returns>
        public DescribeUserDataEngineConfigResponse DescribeUserDataEngineConfigSync(DescribeUserDataEngineConfigRequest req)
        {
            return InternalRequestAsync<DescribeUserDataEngineConfigResponse>(req, "DescribeUserDataEngineConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取用户详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserInfoRequest"/></param>
        /// <returns><see cref="DescribeUserInfoResponse"/></returns>
        public Task<DescribeUserInfoResponse> DescribeUserInfo(DescribeUserInfoRequest req)
        {
            return InternalRequestAsync<DescribeUserInfoResponse>(req, "DescribeUserInfo");
        }

        /// <summary>
        /// 获取用户详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserInfoRequest"/></param>
        /// <returns><see cref="DescribeUserInfoResponse"/></returns>
        public DescribeUserInfoResponse DescribeUserInfoSync(DescribeUserInfoRequest req)
        {
            return InternalRequestAsync<DescribeUserInfoResponse>(req, "DescribeUserInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（DescribeUserRegisterTime）用于查询当前用户注册时间，并判断是否是老用户。
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRegisterTimeRequest"/></param>
        /// <returns><see cref="DescribeUserRegisterTimeResponse"/></returns>
        public Task<DescribeUserRegisterTimeResponse> DescribeUserRegisterTime(DescribeUserRegisterTimeRequest req)
        {
            return InternalRequestAsync<DescribeUserRegisterTimeResponse>(req, "DescribeUserRegisterTime");
        }

        /// <summary>
        /// 该接口（DescribeUserRegisterTime）用于查询当前用户注册时间，并判断是否是老用户。
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRegisterTimeRequest"/></param>
        /// <returns><see cref="DescribeUserRegisterTimeResponse"/></returns>
        public DescribeUserRegisterTimeResponse DescribeUserRegisterTimeSync(DescribeUserRegisterTimeRequest req)
        {
            return InternalRequestAsync<DescribeUserRegisterTimeResponse>(req, "DescribeUserRegisterTime")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列举用户角色信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRolesRequest"/></param>
        /// <returns><see cref="DescribeUserRolesResponse"/></returns>
        public Task<DescribeUserRolesResponse> DescribeUserRoles(DescribeUserRolesRequest req)
        {
            return InternalRequestAsync<DescribeUserRolesResponse>(req, "DescribeUserRoles");
        }

        /// <summary>
        /// 列举用户角色信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRolesRequest"/></param>
        /// <returns><see cref="DescribeUserRolesResponse"/></returns>
        public DescribeUserRolesResponse DescribeUserRolesSync(DescribeUserRolesRequest req)
        {
            return InternalRequestAsync<DescribeUserRolesResponse>(req, "DescribeUserRoles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取用户类型
        /// </summary>
        /// <param name="req"><see cref="DescribeUserTypeRequest"/></param>
        /// <returns><see cref="DescribeUserTypeResponse"/></returns>
        public Task<DescribeUserTypeResponse> DescribeUserType(DescribeUserTypeRequest req)
        {
            return InternalRequestAsync<DescribeUserTypeResponse>(req, "DescribeUserType");
        }

        /// <summary>
        /// 获取用户类型
        /// </summary>
        /// <param name="req"><see cref="DescribeUserTypeRequest"/></param>
        /// <returns><see cref="DescribeUserTypeResponse"/></returns>
        public DescribeUserTypeResponse DescribeUserTypeSync(DescribeUserTypeRequest req)
        {
            return InternalRequestAsync<DescribeUserTypeResponse>(req, "DescribeUserType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户vpc到引擎网络的连接
        /// </summary>
        /// <param name="req"><see cref="DescribeUserVpcConnectionRequest"/></param>
        /// <returns><see cref="DescribeUserVpcConnectionResponse"/></returns>
        public Task<DescribeUserVpcConnectionResponse> DescribeUserVpcConnection(DescribeUserVpcConnectionRequest req)
        {
            return InternalRequestAsync<DescribeUserVpcConnectionResponse>(req, "DescribeUserVpcConnection");
        }

        /// <summary>
        /// 查询用户vpc到引擎网络的连接
        /// </summary>
        /// <param name="req"><see cref="DescribeUserVpcConnectionRequest"/></param>
        /// <returns><see cref="DescribeUserVpcConnectionResponse"/></returns>
        public DescribeUserVpcConnectionResponse DescribeUserVpcConnectionSync(DescribeUserVpcConnectionRequest req)
        {
            return InternalRequestAsync<DescribeUserVpcConnectionResponse>(req, "DescribeUserVpcConnection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取用户列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUsersRequest"/></param>
        /// <returns><see cref="DescribeUsersResponse"/></returns>
        public Task<DescribeUsersResponse> DescribeUsers(DescribeUsersRequest req)
        {
            return InternalRequestAsync<DescribeUsersResponse>(req, "DescribeUsers");
        }

        /// <summary>
        /// 获取用户列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUsersRequest"/></param>
        /// <returns><see cref="DescribeUsersResponse"/></returns>
        public DescribeUsersResponse DescribeUsersSync(DescribeUsersRequest req)
        {
            return InternalRequestAsync<DescribeUsersResponse>(req, "DescribeUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeViews）用于查询数据视图列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeViewsRequest"/></param>
        /// <returns><see cref="DescribeViewsResponse"/></returns>
        public Task<DescribeViewsResponse> DescribeViews(DescribeViewsRequest req)
        {
            return InternalRequestAsync<DescribeViewsResponse>(req, "DescribeViews");
        }

        /// <summary>
        /// 本接口（DescribeViews）用于查询数据视图列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeViewsRequest"/></param>
        /// <returns><see cref="DescribeViewsResponse"/></returns>
        public DescribeViewsResponse DescribeViewsSync(DescribeViewsRequest req)
        {
            return InternalRequestAsync<DescribeViewsResponse>(req, "DescribeViews")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取工作组详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkGroupInfoRequest"/></param>
        /// <returns><see cref="DescribeWorkGroupInfoResponse"/></returns>
        public Task<DescribeWorkGroupInfoResponse> DescribeWorkGroupInfo(DescribeWorkGroupInfoRequest req)
        {
            return InternalRequestAsync<DescribeWorkGroupInfoResponse>(req, "DescribeWorkGroupInfo");
        }

        /// <summary>
        /// 获取工作组详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkGroupInfoRequest"/></param>
        /// <returns><see cref="DescribeWorkGroupInfoResponse"/></returns>
        public DescribeWorkGroupInfoResponse DescribeWorkGroupInfoSync(DescribeWorkGroupInfoRequest req)
        {
            return InternalRequestAsync<DescribeWorkGroupInfoResponse>(req, "DescribeWorkGroupInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取工作组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkGroupsRequest"/></param>
        /// <returns><see cref="DescribeWorkGroupsResponse"/></returns>
        public Task<DescribeWorkGroupsResponse> DescribeWorkGroups(DescribeWorkGroupsRequest req)
        {
            return InternalRequestAsync<DescribeWorkGroupsResponse>(req, "DescribeWorkGroups");
        }

        /// <summary>
        /// 获取工作组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkGroupsRequest"/></param>
        /// <returns><see cref="DescribeWorkGroupsResponse"/></returns>
        public DescribeWorkGroupsResponse DescribeWorkGroupsSync(DescribeWorkGroupsRequest req)
        {
            return InternalRequestAsync<DescribeWorkGroupsResponse>(req, "DescribeWorkGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解绑用户鉴权策略
        /// </summary>
        /// <param name="req"><see cref="DetachUserPolicyRequest"/></param>
        /// <returns><see cref="DetachUserPolicyResponse"/></returns>
        public Task<DetachUserPolicyResponse> DetachUserPolicy(DetachUserPolicyRequest req)
        {
            return InternalRequestAsync<DetachUserPolicyResponse>(req, "DetachUserPolicy");
        }

        /// <summary>
        /// 解绑用户鉴权策略
        /// </summary>
        /// <param name="req"><see cref="DetachUserPolicyRequest"/></param>
        /// <returns><see cref="DetachUserPolicyResponse"/></returns>
        public DetachUserPolicyResponse DetachUserPolicySync(DetachUserPolicyRequest req)
        {
            return InternalRequestAsync<DetachUserPolicyResponse>(req, "DetachUserPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解绑工作组鉴权策略
        /// </summary>
        /// <param name="req"><see cref="DetachWorkGroupPolicyRequest"/></param>
        /// <returns><see cref="DetachWorkGroupPolicyResponse"/></returns>
        public Task<DetachWorkGroupPolicyResponse> DetachWorkGroupPolicy(DetachWorkGroupPolicyRequest req)
        {
            return InternalRequestAsync<DetachWorkGroupPolicyResponse>(req, "DetachWorkGroupPolicy");
        }

        /// <summary>
        /// 解绑工作组鉴权策略
        /// </summary>
        /// <param name="req"><see cref="DetachWorkGroupPolicyRequest"/></param>
        /// <returns><see cref="DetachWorkGroupPolicyResponse"/></returns>
        public DetachWorkGroupPolicyResponse DetachWorkGroupPolicySync(DetachWorkGroupPolicyRequest req)
        {
            return InternalRequestAsync<DetachWorkGroupPolicyResponse>(req, "DetachWorkGroupPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DMS元数据删除库
        /// </summary>
        /// <param name="req"><see cref="DropDMSDatabaseRequest"/></param>
        /// <returns><see cref="DropDMSDatabaseResponse"/></returns>
        public Task<DropDMSDatabaseResponse> DropDMSDatabase(DropDMSDatabaseRequest req)
        {
            return InternalRequestAsync<DropDMSDatabaseResponse>(req, "DropDMSDatabase");
        }

        /// <summary>
        /// DMS元数据删除库
        /// </summary>
        /// <param name="req"><see cref="DropDMSDatabaseRequest"/></param>
        /// <returns><see cref="DropDMSDatabaseResponse"/></returns>
        public DropDMSDatabaseResponse DropDMSDatabaseSync(DropDMSDatabaseRequest req)
        {
            return InternalRequestAsync<DropDMSDatabaseResponse>(req, "DropDMSDatabase")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DMS元数据删除分区
        /// </summary>
        /// <param name="req"><see cref="DropDMSPartitionsRequest"/></param>
        /// <returns><see cref="DropDMSPartitionsResponse"/></returns>
        public Task<DropDMSPartitionsResponse> DropDMSPartitions(DropDMSPartitionsRequest req)
        {
            return InternalRequestAsync<DropDMSPartitionsResponse>(req, "DropDMSPartitions");
        }

        /// <summary>
        /// DMS元数据删除分区
        /// </summary>
        /// <param name="req"><see cref="DropDMSPartitionsRequest"/></param>
        /// <returns><see cref="DropDMSPartitionsResponse"/></returns>
        public DropDMSPartitionsResponse DropDMSPartitionsSync(DropDMSPartitionsRequest req)
        {
            return InternalRequestAsync<DropDMSPartitionsResponse>(req, "DropDMSPartitions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DMS元数据删除表
        /// </summary>
        /// <param name="req"><see cref="DropDMSTableRequest"/></param>
        /// <returns><see cref="DropDMSTableResponse"/></returns>
        public Task<DropDMSTableResponse> DropDMSTable(DropDMSTableRequest req)
        {
            return InternalRequestAsync<DropDMSTableResponse>(req, "DropDMSTable");
        }

        /// <summary>
        /// DMS元数据删除表
        /// </summary>
        /// <param name="req"><see cref="DropDMSTableRequest"/></param>
        /// <returns><see cref="DropDMSTableResponse"/></returns>
        public DropDMSTableResponse DropDMSTableSync(DropDMSTableRequest req)
        {
            return InternalRequestAsync<DropDMSTableResponse>(req, "DropDMSTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 生成创建托管表语句
        /// </summary>
        /// <param name="req"><see cref="GenerateCreateMangedTableSqlRequest"/></param>
        /// <returns><see cref="GenerateCreateMangedTableSqlResponse"/></returns>
        public Task<GenerateCreateMangedTableSqlResponse> GenerateCreateMangedTableSql(GenerateCreateMangedTableSqlRequest req)
        {
            return InternalRequestAsync<GenerateCreateMangedTableSqlResponse>(req, "GenerateCreateMangedTableSql");
        }

        /// <summary>
        /// 生成创建托管表语句
        /// </summary>
        /// <param name="req"><see cref="GenerateCreateMangedTableSqlRequest"/></param>
        /// <returns><see cref="GenerateCreateMangedTableSqlResponse"/></returns>
        public GenerateCreateMangedTableSqlResponse GenerateCreateMangedTableSqlSync(GenerateCreateMangedTableSqlRequest req)
        {
            return InternalRequestAsync<GenerateCreateMangedTableSqlResponse>(req, "GenerateCreateMangedTableSql")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 建表
        /// </summary>
        /// <param name="req"><see cref="GenerateInternalTableRequest"/></param>
        /// <returns><see cref="GenerateInternalTableResponse"/></returns>
        public Task<GenerateInternalTableResponse> GenerateInternalTable(GenerateInternalTableRequest req)
        {
            return InternalRequestAsync<GenerateInternalTableResponse>(req, "GenerateInternalTable");
        }

        /// <summary>
        /// 建表
        /// </summary>
        /// <param name="req"><see cref="GenerateInternalTableRequest"/></param>
        /// <returns><see cref="GenerateInternalTableResponse"/></returns>
        public GenerateInternalTableResponse GenerateInternalTableSync(GenerateInternalTableRequest req)
        {
            return InternalRequestAsync<GenerateInternalTableResponse>(req, "GenerateInternalTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据 exampleId 获取单个案例详情
        /// </summary>
        /// <param name="req"><see cref="GetExampleDetailRequest"/></param>
        /// <returns><see cref="GetExampleDetailResponse"/></returns>
        public Task<GetExampleDetailResponse> GetExampleDetail(GetExampleDetailRequest req)
        {
            return InternalRequestAsync<GetExampleDetailResponse>(req, "GetExampleDetail");
        }

        /// <summary>
        /// 根据 exampleId 获取单个案例详情
        /// </summary>
        /// <param name="req"><see cref="GetExampleDetailRequest"/></param>
        /// <returns><see cref="GetExampleDetailResponse"/></returns>
        public GetExampleDetailResponse GetExampleDetailSync(GetExampleDetailRequest req)
        {
            return InternalRequestAsync<GetExampleDetailResponse>(req, "GetExampleDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取单个模型详情
        /// </summary>
        /// <param name="req"><see cref="GetInferenceModelRequest"/></param>
        /// <returns><see cref="GetInferenceModelResponse"/></returns>
        public Task<GetInferenceModelResponse> GetInferenceModel(GetInferenceModelRequest req)
        {
            return InternalRequestAsync<GetInferenceModelResponse>(req, "GetInferenceModel");
        }

        /// <summary>
        /// 获取单个模型详情
        /// </summary>
        /// <param name="req"><see cref="GetInferenceModelRequest"/></param>
        /// <returns><see cref="GetInferenceModelResponse"/></returns>
        public GetInferenceModelResponse GetInferenceModelSync(GetInferenceModelRequest req)
        {
            return InternalRequestAsync<GetInferenceModelResponse>(req, "GetInferenceModel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取单个推理服务详情
        /// </summary>
        /// <param name="req"><see cref="GetInferenceServiceRequest"/></param>
        /// <returns><see cref="GetInferenceServiceResponse"/></returns>
        public Task<GetInferenceServiceResponse> GetInferenceService(GetInferenceServiceRequest req)
        {
            return InternalRequestAsync<GetInferenceServiceResponse>(req, "GetInferenceService");
        }

        /// <summary>
        /// 获取单个推理服务详情
        /// </summary>
        /// <param name="req"><see cref="GetInferenceServiceRequest"/></param>
        /// <returns><see cref="GetInferenceServiceResponse"/></returns>
        public GetInferenceServiceResponse GetInferenceServiceSync(GetInferenceServiceRequest req)
        {
            return InternalRequestAsync<GetInferenceServiceResponse>(req, "GetInferenceService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据配置ID获取作业配置详情
        /// </summary>
        /// <param name="req"><see cref="GetJobSpecRequest"/></param>
        /// <returns><see cref="GetJobSpecResponse"/></returns>
        public Task<GetJobSpecResponse> GetJobSpec(GetJobSpecRequest req)
        {
            return InternalRequestAsync<GetJobSpecResponse>(req, "GetJobSpec");
        }

        /// <summary>
        /// 根据配置ID获取作业配置详情
        /// </summary>
        /// <param name="req"><see cref="GetJobSpecRequest"/></param>
        /// <returns><see cref="GetJobSpecResponse"/></returns>
        public GetJobSpecResponse GetJobSpecSync(GetJobSpecRequest req)
        {
            return InternalRequestAsync<GetJobSpecResponse>(req, "GetJobSpec")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取实验室详情
        /// </summary>
        /// <param name="req"><see cref="GetLabDetailRequest"/></param>
        /// <returns><see cref="GetLabDetailResponse"/></returns>
        public Task<GetLabDetailResponse> GetLabDetail(GetLabDetailRequest req)
        {
            return InternalRequestAsync<GetLabDetailResponse>(req, "GetLabDetail");
        }

        /// <summary>
        /// 获取实验室详情
        /// </summary>
        /// <param name="req"><see cref="GetLabDetailRequest"/></param>
        /// <returns><see cref="GetLabDetailResponse"/></returns>
        public GetLabDetailResponse GetLabDetailSync(GetLabDetailRequest req)
        {
            return InternalRequestAsync<GetLabDetailResponse>(req, "GetLabDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取实验室的事件流（基于 K8s Event + CLS 日志）
        /// </summary>
        /// <param name="req"><see cref="GetLabEventRequest"/></param>
        /// <returns><see cref="GetLabEventResponse"/></returns>
        public Task<GetLabEventResponse> GetLabEvent(GetLabEventRequest req)
        {
            return InternalRequestAsync<GetLabEventResponse>(req, "GetLabEvent");
        }

        /// <summary>
        /// 获取实验室的事件流（基于 K8s Event + CLS 日志）
        /// </summary>
        /// <param name="req"><see cref="GetLabEventRequest"/></param>
        /// <returns><see cref="GetLabEventResponse"/></returns>
        public GetLabEventResponse GetLabEventSync(GetLabEventRequest req)
        {
            return InternalRequestAsync<GetLabEventResponse>(req, "GetLabEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取实验室的状态变更历史记录
        /// </summary>
        /// <param name="req"><see cref="GetLabHistoryRequest"/></param>
        /// <returns><see cref="GetLabHistoryResponse"/></returns>
        public Task<GetLabHistoryResponse> GetLabHistory(GetLabHistoryRequest req)
        {
            return InternalRequestAsync<GetLabHistoryResponse>(req, "GetLabHistory");
        }

        /// <summary>
        /// 获取实验室的状态变更历史记录
        /// </summary>
        /// <param name="req"><see cref="GetLabHistoryRequest"/></param>
        /// <returns><see cref="GetLabHistoryResponse"/></returns>
        public GetLabHistoryResponse GetLabHistorySync(GetLabHistoryRequest req)
        {
            return InternalRequestAsync<GetLabHistoryResponse>(req, "GetLabHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取数据实验室Pod的YAML内容
        /// </summary>
        /// <param name="req"><see cref="GetLabPodYamlRequest"/></param>
        /// <returns><see cref="GetLabPodYamlResponse"/></returns>
        public Task<GetLabPodYamlResponse> GetLabPodYaml(GetLabPodYamlRequest req)
        {
            return InternalRequestAsync<GetLabPodYamlResponse>(req, "GetLabPodYaml");
        }

        /// <summary>
        /// 获取数据实验室Pod的YAML内容
        /// </summary>
        /// <param name="req"><see cref="GetLabPodYamlRequest"/></param>
        /// <returns><see cref="GetLabPodYamlResponse"/></returns>
        public GetLabPodYamlResponse GetLabPodYamlSync(GetLabPodYamlRequest req)
        {
            return InternalRequestAsync<GetLabPodYamlResponse>(req, "GetLabPodYaml")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取数据实验室的Pod列表
        /// </summary>
        /// <param name="req"><see cref="GetLabPodsRequest"/></param>
        /// <returns><see cref="GetLabPodsResponse"/></returns>
        public Task<GetLabPodsResponse> GetLabPods(GetLabPodsRequest req)
        {
            return InternalRequestAsync<GetLabPodsResponse>(req, "GetLabPods");
        }

        /// <summary>
        /// 获取数据实验室的Pod列表
        /// </summary>
        /// <param name="req"><see cref="GetLabPodsRequest"/></param>
        /// <returns><see cref="GetLabPodsResponse"/></returns>
        public GetLabPodsResponse GetLabPodsSync(GetLabPodsRequest req)
        {
            return InternalRequestAsync<GetLabPodsResponse>(req, "GetLabPods")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取实验室ide访问地址
        /// </summary>
        /// <param name="req"><see cref="GetLabServiceUrlsRequest"/></param>
        /// <returns><see cref="GetLabServiceUrlsResponse"/></returns>
        public Task<GetLabServiceUrlsResponse> GetLabServiceUrls(GetLabServiceUrlsRequest req)
        {
            return InternalRequestAsync<GetLabServiceUrlsResponse>(req, "GetLabServiceUrls");
        }

        /// <summary>
        /// 获取实验室ide访问地址
        /// </summary>
        /// <param name="req"><see cref="GetLabServiceUrlsRequest"/></param>
        /// <returns><see cref="GetLabServiceUrlsResponse"/></returns>
        public GetLabServiceUrlsResponse GetLabServiceUrlsSync(GetLabServiceUrlsRequest req)
        {
            return InternalRequestAsync<GetLabServiceUrlsResponse>(req, "GetLabServiceUrls")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取数据实验室对应的RayCluster YAML内容
        /// </summary>
        /// <param name="req"><see cref="GetLabYamlRequest"/></param>
        /// <returns><see cref="GetLabYamlResponse"/></returns>
        public Task<GetLabYamlResponse> GetLabYaml(GetLabYamlRequest req)
        {
            return InternalRequestAsync<GetLabYamlResponse>(req, "GetLabYaml");
        }

        /// <summary>
        /// 获取数据实验室对应的RayCluster YAML内容
        /// </summary>
        /// <param name="req"><see cref="GetLabYamlRequest"/></param>
        /// <returns><see cref="GetLabYamlResponse"/></returns>
        public GetLabYamlResponse GetLabYamlSync(GetLabYamlRequest req)
        {
            return InternalRequestAsync<GetLabYamlResponse>(req, "GetLabYaml")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取模型 config.json 配置（默认最新版本）
        /// </summary>
        /// <param name="req"><see cref="GetModelConfigRequest"/></param>
        /// <returns><see cref="GetModelConfigResponse"/></returns>
        public Task<GetModelConfigResponse> GetModelConfig(GetModelConfigRequest req)
        {
            return InternalRequestAsync<GetModelConfigResponse>(req, "GetModelConfig");
        }

        /// <summary>
        /// 获取模型 config.json 配置（默认最新版本）
        /// </summary>
        /// <param name="req"><see cref="GetModelConfigRequest"/></param>
        /// <returns><see cref="GetModelConfigResponse"/></returns>
        public GetModelConfigResponse GetModelConfigSync(GetModelConfigRequest req)
        {
            return InternalRequestAsync<GetModelConfigResponse>(req, "GetModelConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取模型文件树（默认最新版本）
        /// </summary>
        /// <param name="req"><see cref="GetModelFilesRequest"/></param>
        /// <returns><see cref="GetModelFilesResponse"/></returns>
        public Task<GetModelFilesResponse> GetModelFiles(GetModelFilesRequest req)
        {
            return InternalRequestAsync<GetModelFilesResponse>(req, "GetModelFiles");
        }

        /// <summary>
        /// 获取模型文件树（默认最新版本）
        /// </summary>
        /// <param name="req"><see cref="GetModelFilesRequest"/></param>
        /// <returns><see cref="GetModelFilesResponse"/></returns>
        public GetModelFilesResponse GetModelFilesSync(GetModelFilesRequest req)
        {
            return InternalRequestAsync<GetModelFilesResponse>(req, "GetModelFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取模型 README 信息（默认最新版本）
        /// </summary>
        /// <param name="req"><see cref="GetModelReadmeRequest"/></param>
        /// <returns><see cref="GetModelReadmeResponse"/></returns>
        public Task<GetModelReadmeResponse> GetModelReadme(GetModelReadmeRequest req)
        {
            return InternalRequestAsync<GetModelReadmeResponse>(req, "GetModelReadme");
        }

        /// <summary>
        /// 获取模型 README 信息（默认最新版本）
        /// </summary>
        /// <param name="req"><see cref="GetModelReadmeRequest"/></param>
        /// <returns><see cref="GetModelReadmeResponse"/></returns>
        public GetModelReadmeResponse GetModelReadmeSync(GetModelReadmeRequest req)
        {
            return InternalRequestAsync<GetModelReadmeResponse>(req, "GetModelReadme")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// GetOptimizerPolicy
        /// </summary>
        /// <param name="req"><see cref="GetOptimizerPolicyRequest"/></param>
        /// <returns><see cref="GetOptimizerPolicyResponse"/></returns>
        public Task<GetOptimizerPolicyResponse> GetOptimizerPolicy(GetOptimizerPolicyRequest req)
        {
            return InternalRequestAsync<GetOptimizerPolicyResponse>(req, "GetOptimizerPolicy");
        }

        /// <summary>
        /// GetOptimizerPolicy
        /// </summary>
        /// <param name="req"><see cref="GetOptimizerPolicyRequest"/></param>
        /// <returns><see cref="GetOptimizerPolicyResponse"/></returns>
        public GetOptimizerPolicyResponse GetOptimizerPolicySync(GetOptimizerPolicyRequest req)
        {
            return InternalRequestAsync<GetOptimizerPolicyResponse>(req, "GetOptimizerPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取Ray集群详情请求
        /// </summary>
        /// <param name="req"><see cref="GetRayClusterRequest"/></param>
        /// <returns><see cref="GetRayClusterResponse"/></returns>
        public Task<GetRayClusterResponse> GetRayCluster(GetRayClusterRequest req)
        {
            return InternalRequestAsync<GetRayClusterResponse>(req, "GetRayCluster");
        }

        /// <summary>
        /// 获取Ray集群详情请求
        /// </summary>
        /// <param name="req"><see cref="GetRayClusterRequest"/></param>
        /// <returns><see cref="GetRayClusterResponse"/></returns>
        public GetRayClusterResponse GetRayClusterSync(GetRayClusterRequest req)
        {
            return InternalRequestAsync<GetRayClusterResponse>(req, "GetRayCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取Ray集群的事件流（基于 K8s Event + CLS 日志）
        /// </summary>
        /// <param name="req"><see cref="GetRayClusterEventRequest"/></param>
        /// <returns><see cref="GetRayClusterEventResponse"/></returns>
        public Task<GetRayClusterEventResponse> GetRayClusterEvent(GetRayClusterEventRequest req)
        {
            return InternalRequestAsync<GetRayClusterEventResponse>(req, "GetRayClusterEvent");
        }

        /// <summary>
        /// 获取Ray集群的事件流（基于 K8s Event + CLS 日志）
        /// </summary>
        /// <param name="req"><see cref="GetRayClusterEventRequest"/></param>
        /// <returns><see cref="GetRayClusterEventResponse"/></returns>
        public GetRayClusterEventResponse GetRayClusterEventSync(GetRayClusterEventRequest req)
        {
            return InternalRequestAsync<GetRayClusterEventResponse>(req, "GetRayClusterEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取集群状态历史
        /// </summary>
        /// <param name="req"><see cref="GetRayClusterHistoryRequest"/></param>
        /// <returns><see cref="GetRayClusterHistoryResponse"/></returns>
        public Task<GetRayClusterHistoryResponse> GetRayClusterHistory(GetRayClusterHistoryRequest req)
        {
            return InternalRequestAsync<GetRayClusterHistoryResponse>(req, "GetRayClusterHistory");
        }

        /// <summary>
        /// 获取集群状态历史
        /// </summary>
        /// <param name="req"><see cref="GetRayClusterHistoryRequest"/></param>
        /// <returns><see cref="GetRayClusterHistoryResponse"/></returns>
        public GetRayClusterHistoryResponse GetRayClusterHistorySync(GetRayClusterHistoryRequest req)
        {
            return InternalRequestAsync<GetRayClusterHistoryResponse>(req, "GetRayClusterHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取集群Pod的YAML内容
        /// </summary>
        /// <param name="req"><see cref="GetRayClusterPodYamlRequest"/></param>
        /// <returns><see cref="GetRayClusterPodYamlResponse"/></returns>
        public Task<GetRayClusterPodYamlResponse> GetRayClusterPodYaml(GetRayClusterPodYamlRequest req)
        {
            return InternalRequestAsync<GetRayClusterPodYamlResponse>(req, "GetRayClusterPodYaml");
        }

        /// <summary>
        /// 获取集群Pod的YAML内容
        /// </summary>
        /// <param name="req"><see cref="GetRayClusterPodYamlRequest"/></param>
        /// <returns><see cref="GetRayClusterPodYamlResponse"/></returns>
        public GetRayClusterPodYamlResponse GetRayClusterPodYamlSync(GetRayClusterPodYamlRequest req)
        {
            return InternalRequestAsync<GetRayClusterPodYamlResponse>(req, "GetRayClusterPodYaml")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取集群的Pod列表
        /// </summary>
        /// <param name="req"><see cref="GetRayClusterPodsRequest"/></param>
        /// <returns><see cref="GetRayClusterPodsResponse"/></returns>
        public Task<GetRayClusterPodsResponse> GetRayClusterPods(GetRayClusterPodsRequest req)
        {
            return InternalRequestAsync<GetRayClusterPodsResponse>(req, "GetRayClusterPods");
        }

        /// <summary>
        /// 获取集群的Pod列表
        /// </summary>
        /// <param name="req"><see cref="GetRayClusterPodsRequest"/></param>
        /// <returns><see cref="GetRayClusterPodsResponse"/></returns>
        public GetRayClusterPodsResponse GetRayClusterPodsSync(GetRayClusterPodsRequest req)
        {
            return InternalRequestAsync<GetRayClusterPodsResponse>(req, "GetRayClusterPods")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取RayCluster的YAML内容
        /// </summary>
        /// <param name="req"><see cref="GetRayClusterYamlRequest"/></param>
        /// <returns><see cref="GetRayClusterYamlResponse"/></returns>
        public Task<GetRayClusterYamlResponse> GetRayClusterYaml(GetRayClusterYamlRequest req)
        {
            return InternalRequestAsync<GetRayClusterYamlResponse>(req, "GetRayClusterYaml");
        }

        /// <summary>
        /// 获取RayCluster的YAML内容
        /// </summary>
        /// <param name="req"><see cref="GetRayClusterYamlRequest"/></param>
        /// <returns><see cref="GetRayClusterYamlResponse"/></returns>
        public GetRayClusterYamlResponse GetRayClusterYamlSync(GetRayClusterYamlRequest req)
        {
            return InternalRequestAsync<GetRayClusterYamlResponse>(req, "GetRayClusterYaml")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据任务ID获取Ray任务详情
        /// </summary>
        /// <param name="req"><see cref="GetRayJobRequest"/></param>
        /// <returns><see cref="GetRayJobResponse"/></returns>
        public Task<GetRayJobResponse> GetRayJob(GetRayJobRequest req)
        {
            return InternalRequestAsync<GetRayJobResponse>(req, "GetRayJob");
        }

        /// <summary>
        /// 根据任务ID获取Ray任务详情
        /// </summary>
        /// <param name="req"><see cref="GetRayJobRequest"/></param>
        /// <returns><see cref="GetRayJobResponse"/></returns>
        public GetRayJobResponse GetRayJobSync(GetRayJobRequest req)
        {
            return InternalRequestAsync<GetRayJobResponse>(req, "GetRayJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过 ResourceManager 调用 CLS SearchLog API 查询作业相关日志。不返回总数，使用 Context 进行翻页，ListOver 标识是否还有更多数据。
        /// </summary>
        /// <param name="req"><see cref="GetRayJobEventRequest"/></param>
        /// <returns><see cref="GetRayJobEventResponse"/></returns>
        public Task<GetRayJobEventResponse> GetRayJobEvent(GetRayJobEventRequest req)
        {
            return InternalRequestAsync<GetRayJobEventResponse>(req, "GetRayJobEvent");
        }

        /// <summary>
        /// 通过 ResourceManager 调用 CLS SearchLog API 查询作业相关日志。不返回总数，使用 Context 进行翻页，ListOver 标识是否还有更多数据。
        /// </summary>
        /// <param name="req"><see cref="GetRayJobEventRequest"/></param>
        /// <returns><see cref="GetRayJobEventResponse"/></returns>
        public GetRayJobEventResponse GetRayJobEventSync(GetRayJobEventRequest req)
        {
            return InternalRequestAsync<GetRayJobEventResponse>(req, "GetRayJobEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取作业事件日志
        /// </summary>
        /// <param name="req"><see cref="GetRayJobEventLogRequest"/></param>
        /// <returns><see cref="GetRayJobEventLogResponse"/></returns>
        public Task<GetRayJobEventLogResponse> GetRayJobEventLog(GetRayJobEventLogRequest req)
        {
            return InternalRequestAsync<GetRayJobEventLogResponse>(req, "GetRayJobEventLog");
        }

        /// <summary>
        /// 获取作业事件日志
        /// </summary>
        /// <param name="req"><see cref="GetRayJobEventLogRequest"/></param>
        /// <returns><see cref="GetRayJobEventLogResponse"/></returns>
        public GetRayJobEventLogResponse GetRayJobEventLogSync(GetRayJobEventLogRequest req)
        {
            return InternalRequestAsync<GetRayJobEventLogResponse>(req, "GetRayJobEventLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据任务ID获取Ray任务的历史执行记录
        /// </summary>
        /// <param name="req"><see cref="GetRayJobHistoryRequest"/></param>
        /// <returns><see cref="GetRayJobHistoryResponse"/></returns>
        public Task<GetRayJobHistoryResponse> GetRayJobHistory(GetRayJobHistoryRequest req)
        {
            return InternalRequestAsync<GetRayJobHistoryResponse>(req, "GetRayJobHistory");
        }

        /// <summary>
        /// 根据任务ID获取Ray任务的历史执行记录
        /// </summary>
        /// <param name="req"><see cref="GetRayJobHistoryRequest"/></param>
        /// <returns><see cref="GetRayJobHistoryResponse"/></returns>
        public GetRayJobHistoryResponse GetRayJobHistorySync(GetRayJobHistoryRequest req)
        {
            return InternalRequestAsync<GetRayJobHistoryResponse>(req, "GetRayJobHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取Pod的YAML内容
        /// </summary>
        /// <param name="req"><see cref="GetRayJobPodYamlRequest"/></param>
        /// <returns><see cref="GetRayJobPodYamlResponse"/></returns>
        public Task<GetRayJobPodYamlResponse> GetRayJobPodYaml(GetRayJobPodYamlRequest req)
        {
            return InternalRequestAsync<GetRayJobPodYamlResponse>(req, "GetRayJobPodYaml");
        }

        /// <summary>
        /// 获取Pod的YAML内容
        /// </summary>
        /// <param name="req"><see cref="GetRayJobPodYamlRequest"/></param>
        /// <returns><see cref="GetRayJobPodYamlResponse"/></returns>
        public GetRayJobPodYamlResponse GetRayJobPodYamlSync(GetRayJobPodYamlRequest req)
        {
            return InternalRequestAsync<GetRayJobPodYamlResponse>(req, "GetRayJobPodYaml")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取作业的Pod列表
        /// </summary>
        /// <param name="req"><see cref="GetRayJobPodsRequest"/></param>
        /// <returns><see cref="GetRayJobPodsResponse"/></returns>
        public Task<GetRayJobPodsResponse> GetRayJobPods(GetRayJobPodsRequest req)
        {
            return InternalRequestAsync<GetRayJobPodsResponse>(req, "GetRayJobPods");
        }

        /// <summary>
        /// 获取作业的Pod列表
        /// </summary>
        /// <param name="req"><see cref="GetRayJobPodsRequest"/></param>
        /// <returns><see cref="GetRayJobPodsResponse"/></returns>
        public GetRayJobPodsResponse GetRayJobPodsSync(GetRayJobPodsRequest req)
        {
            return InternalRequestAsync<GetRayJobPodsResponse>(req, "GetRayJobPods")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取RayJob的YAML内容
        /// </summary>
        /// <param name="req"><see cref="GetRayJobYamlRequest"/></param>
        /// <returns><see cref="GetRayJobYamlResponse"/></returns>
        public Task<GetRayJobYamlResponse> GetRayJobYaml(GetRayJobYamlRequest req)
        {
            return InternalRequestAsync<GetRayJobYamlResponse>(req, "GetRayJobYaml");
        }

        /// <summary>
        /// 获取RayJob的YAML内容
        /// </summary>
        /// <param name="req"><see cref="GetRayJobYamlRequest"/></param>
        /// <returns><see cref="GetRayJobYamlResponse"/></returns>
        public GetRayJobYamlResponse GetRayJobYamlSync(GetRayJobYamlRequest req)
        {
            return InternalRequestAsync<GetRayJobYamlResponse>(req, "GetRayJobYaml")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取资源配置模板详情
        /// </summary>
        /// <param name="req"><see cref="GetResourceConfigRequest"/></param>
        /// <returns><see cref="GetResourceConfigResponse"/></returns>
        public Task<GetResourceConfigResponse> GetResourceConfig(GetResourceConfigRequest req)
        {
            return InternalRequestAsync<GetResourceConfigResponse>(req, "GetResourceConfig");
        }

        /// <summary>
        /// 获取资源配置模板详情
        /// </summary>
        /// <param name="req"><see cref="GetResourceConfigRequest"/></param>
        /// <returns><see cref="GetResourceConfigResponse"/></returns>
        public GetResourceConfigResponse GetResourceConfigSync(GetResourceConfigRequest req)
        {
            return InternalRequestAsync<GetResourceConfigResponse>(req, "GetResourceConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 授权访问DLC Catalog
        /// </summary>
        /// <param name="req"><see cref="GrantDLCCatalogAccessRequest"/></param>
        /// <returns><see cref="GrantDLCCatalogAccessResponse"/></returns>
        public Task<GrantDLCCatalogAccessResponse> GrantDLCCatalogAccess(GrantDLCCatalogAccessRequest req)
        {
            return InternalRequestAsync<GrantDLCCatalogAccessResponse>(req, "GrantDLCCatalogAccess");
        }

        /// <summary>
        /// 授权访问DLC Catalog
        /// </summary>
        /// <param name="req"><see cref="GrantDLCCatalogAccessRequest"/></param>
        /// <returns><see cref="GrantDLCCatalogAccessResponse"/></returns>
        public GrantDLCCatalogAccessResponse GrantDLCCatalogAccessSync(GrantDLCCatalogAccessRequest req)
        {
            return InternalRequestAsync<GrantDLCCatalogAccessResponse>(req, "GrantDLCCatalogAccess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开通TCLake
        /// </summary>
        /// <param name="req"><see cref="InitializeTCLakeRequest"/></param>
        /// <returns><see cref="InitializeTCLakeResponse"/></returns>
        public Task<InitializeTCLakeResponse> InitializeTCLake(InitializeTCLakeRequest req)
        {
            return InternalRequestAsync<InitializeTCLakeResponse>(req, "InitializeTCLake");
        }

        /// <summary>
        /// 开通TCLake
        /// </summary>
        /// <param name="req"><see cref="InitializeTCLakeRequest"/></param>
        /// <returns><see cref="InitializeTCLakeResponse"/></returns>
        public InitializeTCLakeResponse InitializeTCLakeSync(InitializeTCLakeRequest req)
        {
            return InternalRequestAsync<InitializeTCLakeResponse>(req, "InitializeTCLake")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启动标准引擎资源组
        /// </summary>
        /// <param name="req"><see cref="LaunchStandardEngineResourceGroupsRequest"/></param>
        /// <returns><see cref="LaunchStandardEngineResourceGroupsResponse"/></returns>
        public Task<LaunchStandardEngineResourceGroupsResponse> LaunchStandardEngineResourceGroups(LaunchStandardEngineResourceGroupsRequest req)
        {
            return InternalRequestAsync<LaunchStandardEngineResourceGroupsResponse>(req, "LaunchStandardEngineResourceGroups");
        }

        /// <summary>
        /// 启动标准引擎资源组
        /// </summary>
        /// <param name="req"><see cref="LaunchStandardEngineResourceGroupsRequest"/></param>
        /// <returns><see cref="LaunchStandardEngineResourceGroupsResponse"/></returns>
        public LaunchStandardEngineResourceGroupsResponse LaunchStandardEngineResourceGroupsSync(LaunchStandardEngineResourceGroupsRequest req)
        {
            return InternalRequestAsync<LaunchStandardEngineResourceGroupsResponse>(req, "LaunchStandardEngineResourceGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列出所有集群组
        /// </summary>
        /// <param name="req"><see cref="ListClusterGroupsRequest"/></param>
        /// <returns><see cref="ListClusterGroupsResponse"/></returns>
        public Task<ListClusterGroupsResponse> ListClusterGroups(ListClusterGroupsRequest req)
        {
            return InternalRequestAsync<ListClusterGroupsResponse>(req, "ListClusterGroups");
        }

        /// <summary>
        /// 列出所有集群组
        /// </summary>
        /// <param name="req"><see cref="ListClusterGroupsRequest"/></param>
        /// <returns><see cref="ListClusterGroupsResponse"/></returns>
        public ListClusterGroupsResponse ListClusterGroupsSync(ListClusterGroupsRequest req)
        {
            return InternalRequestAsync<ListClusterGroupsResponse>(req, "ListClusterGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取所有案例分类
        /// </summary>
        /// <param name="req"><see cref="ListExampleCategoriesRequest"/></param>
        /// <returns><see cref="ListExampleCategoriesResponse"/></returns>
        public Task<ListExampleCategoriesResponse> ListExampleCategories(ListExampleCategoriesRequest req)
        {
            return InternalRequestAsync<ListExampleCategoriesResponse>(req, "ListExampleCategories");
        }

        /// <summary>
        /// 获取所有案例分类
        /// </summary>
        /// <param name="req"><see cref="ListExampleCategoriesRequest"/></param>
        /// <returns><see cref="ListExampleCategoriesResponse"/></returns>
        public ListExampleCategoriesResponse ListExampleCategoriesSync(ListExampleCategoriesRequest req)
        {
            return InternalRequestAsync<ListExampleCategoriesResponse>(req, "ListExampleCategories")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取所有案例分类
        /// </summary>
        /// <param name="req"><see cref="ListExampleDifficultiesRequest"/></param>
        /// <returns><see cref="ListExampleDifficultiesResponse"/></returns>
        public Task<ListExampleDifficultiesResponse> ListExampleDifficulties(ListExampleDifficultiesRequest req)
        {
            return InternalRequestAsync<ListExampleDifficultiesResponse>(req, "ListExampleDifficulties");
        }

        /// <summary>
        /// 获取所有案例分类
        /// </summary>
        /// <param name="req"><see cref="ListExampleDifficultiesRequest"/></param>
        /// <returns><see cref="ListExampleDifficultiesResponse"/></returns>
        public ListExampleDifficultiesResponse ListExampleDifficultiesSync(ListExampleDifficultiesRequest req)
        {
            return InternalRequestAsync<ListExampleDifficultiesResponse>(req, "ListExampleDifficulties")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 返回标签去重列表，按出现频次从高到低排序。
        /// </summary>
        /// <param name="req"><see cref="ListExampleTagsRequest"/></param>
        /// <returns><see cref="ListExampleTagsResponse"/></returns>
        public Task<ListExampleTagsResponse> ListExampleTags(ListExampleTagsRequest req)
        {
            return InternalRequestAsync<ListExampleTagsResponse>(req, "ListExampleTags");
        }

        /// <summary>
        /// 返回标签去重列表，按出现频次从高到低排序。
        /// </summary>
        /// <param name="req"><see cref="ListExampleTagsRequest"/></param>
        /// <returns><see cref="ListExampleTagsResponse"/></returns>
        public ListExampleTagsResponse ListExampleTagsSync(ListExampleTagsRequest req)
        {
            return InternalRequestAsync<ListExampleTagsResponse>(req, "ListExampleTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 案例列表
        /// </summary>
        /// <param name="req"><see cref="ListExamplesRequest"/></param>
        /// <returns><see cref="ListExamplesResponse"/></returns>
        public Task<ListExamplesResponse> ListExamples(ListExamplesRequest req)
        {
            return InternalRequestAsync<ListExamplesResponse>(req, "ListExamples");
        }

        /// <summary>
        /// 案例列表
        /// </summary>
        /// <param name="req"><see cref="ListExamplesRequest"/></param>
        /// <returns><see cref="ListExamplesResponse"/></returns>
        public ListExamplesResponse ListExamplesSync(ListExamplesRequest req)
        {
            return InternalRequestAsync<ListExamplesResponse>(req, "ListExamples")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列出推理引擎
        /// </summary>
        /// <param name="req"><see cref="ListInferenceEnginesRequest"/></param>
        /// <returns><see cref="ListInferenceEnginesResponse"/></returns>
        public Task<ListInferenceEnginesResponse> ListInferenceEngines(ListInferenceEnginesRequest req)
        {
            return InternalRequestAsync<ListInferenceEnginesResponse>(req, "ListInferenceEngines");
        }

        /// <summary>
        /// 列出推理引擎
        /// </summary>
        /// <param name="req"><see cref="ListInferenceEnginesRequest"/></param>
        /// <returns><see cref="ListInferenceEnginesResponse"/></returns>
        public ListInferenceEnginesResponse ListInferenceEnginesSync(ListInferenceEnginesRequest req)
        {
            return InternalRequestAsync<ListInferenceEnginesResponse>(req, "ListInferenceEngines")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列出推理模型（支持关键词过滤 + 分页）
        /// </summary>
        /// <param name="req"><see cref="ListInferenceModelsRequest"/></param>
        /// <returns><see cref="ListInferenceModelsResponse"/></returns>
        public Task<ListInferenceModelsResponse> ListInferenceModels(ListInferenceModelsRequest req)
        {
            return InternalRequestAsync<ListInferenceModelsResponse>(req, "ListInferenceModels");
        }

        /// <summary>
        /// 列出推理模型（支持关键词过滤 + 分页）
        /// </summary>
        /// <param name="req"><see cref="ListInferenceModelsRequest"/></param>
        /// <returns><see cref="ListInferenceModelsResponse"/></returns>
        public ListInferenceModelsResponse ListInferenceModelsSync(ListInferenceModelsRequest req)
        {
            return InternalRequestAsync<ListInferenceModelsResponse>(req, "ListInferenceModels")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列出推理服务（支持关键词和状态过滤 + 分页）
        /// </summary>
        /// <param name="req"><see cref="ListInferenceServicesRequest"/></param>
        /// <returns><see cref="ListInferenceServicesResponse"/></returns>
        public Task<ListInferenceServicesResponse> ListInferenceServices(ListInferenceServicesRequest req)
        {
            return InternalRequestAsync<ListInferenceServicesResponse>(req, "ListInferenceServices");
        }

        /// <summary>
        /// 列出推理服务（支持关键词和状态过滤 + 分页）
        /// </summary>
        /// <param name="req"><see cref="ListInferenceServicesRequest"/></param>
        /// <returns><see cref="ListInferenceServicesResponse"/></returns>
        public ListInferenceServicesResponse ListInferenceServicesSync(ListInferenceServicesRequest req)
        {
            return InternalRequestAsync<ListInferenceServicesResponse>(req, "ListInferenceServices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 分页查询作业配置列表
        /// </summary>
        /// <param name="req"><see cref="ListJobSpecsRequest"/></param>
        /// <returns><see cref="ListJobSpecsResponse"/></returns>
        public Task<ListJobSpecsResponse> ListJobSpecs(ListJobSpecsRequest req)
        {
            return InternalRequestAsync<ListJobSpecsResponse>(req, "ListJobSpecs");
        }

        /// <summary>
        /// 分页查询作业配置列表
        /// </summary>
        /// <param name="req"><see cref="ListJobSpecsRequest"/></param>
        /// <returns><see cref="ListJobSpecsResponse"/></returns>
        public ListJobSpecsResponse ListJobSpecsSync(ListJobSpecsRequest req)
        {
            return InternalRequestAsync<ListJobSpecsResponse>(req, "ListJobSpecs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 分页查询某作业配置下产生的所有作业实例
        /// </summary>
        /// <param name="req"><see cref="ListJobsBySpecRequest"/></param>
        /// <returns><see cref="ListJobsBySpecResponse"/></returns>
        public Task<ListJobsBySpecResponse> ListJobsBySpec(ListJobsBySpecRequest req)
        {
            return InternalRequestAsync<ListJobsBySpecResponse>(req, "ListJobsBySpec");
        }

        /// <summary>
        /// 分页查询某作业配置下产生的所有作业实例
        /// </summary>
        /// <param name="req"><see cref="ListJobsBySpecRequest"/></param>
        /// <returns><see cref="ListJobsBySpecResponse"/></returns>
        public ListJobsBySpecResponse ListJobsBySpecSync(ListJobsBySpecRequest req)
        {
            return InternalRequestAsync<ListJobsBySpecResponse>(req, "ListJobsBySpec")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列出实验室列表
        /// </summary>
        /// <param name="req"><see cref="ListLabsRequest"/></param>
        /// <returns><see cref="ListLabsResponse"/></returns>
        public Task<ListLabsResponse> ListLabs(ListLabsRequest req)
        {
            return InternalRequestAsync<ListLabsResponse>(req, "ListLabs");
        }

        /// <summary>
        /// 列出实验室列表
        /// </summary>
        /// <param name="req"><see cref="ListLabsRequest"/></param>
        /// <returns><see cref="ListLabsResponse"/></returns>
        public ListLabsResponse ListLabsSync(ListLabsRequest req)
        {
            return InternalRequestAsync<ListLabsResponse>(req, "ListLabs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列出模型所有版本
        /// </summary>
        /// <param name="req"><see cref="ListModelVersionsRequest"/></param>
        /// <returns><see cref="ListModelVersionsResponse"/></returns>
        public Task<ListModelVersionsResponse> ListModelVersions(ListModelVersionsRequest req)
        {
            return InternalRequestAsync<ListModelVersionsResponse>(req, "ListModelVersions");
        }

        /// <summary>
        /// 列出模型所有版本
        /// </summary>
        /// <param name="req"><see cref="ListModelVersionsRequest"/></param>
        /// <returns><see cref="ListModelVersionsResponse"/></returns>
        public ListModelVersionsResponse ListModelVersionsSync(ListModelVersionsRequest req)
        {
            return InternalRequestAsync<ListModelVersionsResponse>(req, "ListModelVersions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定 Ray 集群下提交的所有作业，分页返回。底层委托给 ListRayJobs，强制注入 ClusterId 作为过滤条件。
        /// </summary>
        /// <param name="req"><see cref="ListRayClusterJobsRequest"/></param>
        /// <returns><see cref="ListRayClusterJobsResponse"/></returns>
        public Task<ListRayClusterJobsResponse> ListRayClusterJobs(ListRayClusterJobsRequest req)
        {
            return InternalRequestAsync<ListRayClusterJobsResponse>(req, "ListRayClusterJobs");
        }

        /// <summary>
        /// 查询指定 Ray 集群下提交的所有作业，分页返回。底层委托给 ListRayJobs，强制注入 ClusterId 作为过滤条件。
        /// </summary>
        /// <param name="req"><see cref="ListRayClusterJobsRequest"/></param>
        /// <returns><see cref="ListRayClusterJobsResponse"/></returns>
        public ListRayClusterJobsResponse ListRayClusterJobsSync(ListRayClusterJobsRequest req)
        {
            return InternalRequestAsync<ListRayClusterJobsResponse>(req, "ListRayClusterJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列出所有集群
        /// </summary>
        /// <param name="req"><see cref="ListRayClustersRequest"/></param>
        /// <returns><see cref="ListRayClustersResponse"/></returns>
        public Task<ListRayClustersResponse> ListRayClusters(ListRayClustersRequest req)
        {
            return InternalRequestAsync<ListRayClustersResponse>(req, "ListRayClusters");
        }

        /// <summary>
        /// 列出所有集群
        /// </summary>
        /// <param name="req"><see cref="ListRayClustersRequest"/></param>
        /// <returns><see cref="ListRayClustersResponse"/></returns>
        public ListRayClustersResponse ListRayClustersSync(ListRayClustersRequest req)
        {
            return InternalRequestAsync<ListRayClustersResponse>(req, "ListRayClusters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据集群ID列出所有Ray任务
        /// </summary>
        /// <param name="req"><see cref="ListRayJobsRequest"/></param>
        /// <returns><see cref="ListRayJobsResponse"/></returns>
        public Task<ListRayJobsResponse> ListRayJobs(ListRayJobsRequest req)
        {
            return InternalRequestAsync<ListRayJobsResponse>(req, "ListRayJobs");
        }

        /// <summary>
        /// 根据集群ID列出所有Ray任务
        /// </summary>
        /// <param name="req"><see cref="ListRayJobsRequest"/></param>
        /// <returns><see cref="ListRayJobsResponse"/></returns>
        public ListRayJobsResponse ListRayJobsSync(ListRayJobsRequest req)
        {
            return InternalRequestAsync<ListRayJobsResponse>(req, "ListRayJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列出所有资源配置模板
        /// </summary>
        /// <param name="req"><see cref="ListResourceConfigsRequest"/></param>
        /// <returns><see cref="ListResourceConfigsResponse"/></returns>
        public Task<ListResourceConfigsResponse> ListResourceConfigs(ListResourceConfigsRequest req)
        {
            return InternalRequestAsync<ListResourceConfigsResponse>(req, "ListResourceConfigs");
        }

        /// <summary>
        /// 列出所有资源配置模板
        /// </summary>
        /// <param name="req"><see cref="ListResourceConfigsRequest"/></param>
        /// <returns><see cref="ListResourceConfigsResponse"/></returns>
        public ListResourceConfigsResponse ListResourceConfigsSync(ListResourceConfigsRequest req)
        {
            return InternalRequestAsync<ListResourceConfigsResponse>(req, "ListResourceConfigs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ListTaskJobLogDetail）用于获取spark 作业任务日志详情
        /// </summary>
        /// <param name="req"><see cref="ListTaskJobLogDetailRequest"/></param>
        /// <returns><see cref="ListTaskJobLogDetailResponse"/></returns>
        public Task<ListTaskJobLogDetailResponse> ListTaskJobLogDetail(ListTaskJobLogDetailRequest req)
        {
            return InternalRequestAsync<ListTaskJobLogDetailResponse>(req, "ListTaskJobLogDetail");
        }

        /// <summary>
        /// 本接口（ListTaskJobLogDetail）用于获取spark 作业任务日志详情
        /// </summary>
        /// <param name="req"><see cref="ListTaskJobLogDetailRequest"/></param>
        /// <returns><see cref="ListTaskJobLogDetailResponse"/></returns>
        public ListTaskJobLogDetailResponse ListTaskJobLogDetailSync(ListTaskJobLogDetailRequest req)
        {
            return InternalRequestAsync<ListTaskJobLogDetailResponse>(req, "ListTaskJobLogDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ListTaskJobLogName）用于获取spark-jar日志名称列表
        /// </summary>
        /// <param name="req"><see cref="ListTaskJobLogNameRequest"/></param>
        /// <returns><see cref="ListTaskJobLogNameResponse"/></returns>
        public Task<ListTaskJobLogNameResponse> ListTaskJobLogName(ListTaskJobLogNameRequest req)
        {
            return InternalRequestAsync<ListTaskJobLogNameResponse>(req, "ListTaskJobLogName");
        }

        /// <summary>
        /// 本接口（ListTaskJobLogName）用于获取spark-jar日志名称列表
        /// </summary>
        /// <param name="req"><see cref="ListTaskJobLogNameRequest"/></param>
        /// <returns><see cref="ListTaskJobLogNameResponse"/></returns>
        public ListTaskJobLogNameResponse ListTaskJobLogNameSync(ListTaskJobLogNameRequest req)
        {
            return InternalRequestAsync<ListTaskJobLogNameResponse>(req, "ListTaskJobLogName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 元数据锁
        /// </summary>
        /// <param name="req"><see cref="LockMetaDataRequest"/></param>
        /// <returns><see cref="LockMetaDataResponse"/></returns>
        public Task<LockMetaDataResponse> LockMetaData(LockMetaDataRequest req)
        {
            return InternalRequestAsync<LockMetaDataResponse>(req, "LockMetaData");
        }

        /// <summary>
        /// 元数据锁
        /// </summary>
        /// <param name="req"><see cref="LockMetaDataRequest"/></param>
        /// <returns><see cref="LockMetaDataResponse"/></returns>
        public LockMetaDataResponse LockMetaDataSync(LockMetaDataRequest req)
        {
            return InternalRequestAsync<LockMetaDataResponse>(req, "LockMetaData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改sql查询界面高级设置。
        /// </summary>
        /// <param name="req"><see cref="ModifyAdvancedStoreLocationRequest"/></param>
        /// <returns><see cref="ModifyAdvancedStoreLocationResponse"/></returns>
        public Task<ModifyAdvancedStoreLocationResponse> ModifyAdvancedStoreLocation(ModifyAdvancedStoreLocationRequest req)
        {
            return InternalRequestAsync<ModifyAdvancedStoreLocationResponse>(req, "ModifyAdvancedStoreLocation");
        }

        /// <summary>
        /// 修改sql查询界面高级设置。
        /// </summary>
        /// <param name="req"><see cref="ModifyAdvancedStoreLocationRequest"/></param>
        /// <returns><see cref="ModifyAdvancedStoreLocationResponse"/></returns>
        public ModifyAdvancedStoreLocationResponse ModifyAdvancedStoreLocationSync(ModifyAdvancedStoreLocationRequest req)
        {
            return InternalRequestAsync<ModifyAdvancedStoreLocationResponse>(req, "ModifyAdvancedStoreLocation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改集群的调度优先级（1-9，数字越大优先级越高）
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterPriorityRequest"/></param>
        /// <returns><see cref="ModifyClusterPriorityResponse"/></returns>
        public Task<ModifyClusterPriorityResponse> ModifyClusterPriority(ModifyClusterPriorityRequest req)
        {
            return InternalRequestAsync<ModifyClusterPriorityResponse>(req, "ModifyClusterPriority");
        }

        /// <summary>
        /// 修改集群的调度优先级（1-9，数字越大优先级越高）
        /// </summary>
        /// <param name="req"><see cref="ModifyClusterPriorityRequest"/></param>
        /// <returns><see cref="ModifyClusterPriorityResponse"/></returns>
        public ModifyClusterPriorityResponse ModifyClusterPrioritySync(ModifyClusterPriorityRequest req)
        {
            return InternalRequestAsync<ModifyClusterPriorityResponse>(req, "ModifyClusterPriority")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改引擎描述信息
        /// </summary>
        /// <param name="req"><see cref="ModifyDataEngineDescriptionRequest"/></param>
        /// <returns><see cref="ModifyDataEngineDescriptionResponse"/></returns>
        public Task<ModifyDataEngineDescriptionResponse> ModifyDataEngineDescription(ModifyDataEngineDescriptionRequest req)
        {
            return InternalRequestAsync<ModifyDataEngineDescriptionResponse>(req, "ModifyDataEngineDescription");
        }

        /// <summary>
        /// 修改引擎描述信息
        /// </summary>
        /// <param name="req"><see cref="ModifyDataEngineDescriptionRequest"/></param>
        /// <returns><see cref="ModifyDataEngineDescriptionResponse"/></returns>
        public ModifyDataEngineDescriptionResponse ModifyDataEngineDescriptionSync(ModifyDataEngineDescriptionRequest req)
        {
            return InternalRequestAsync<ModifyDataEngineDescriptionResponse>(req, "ModifyDataEngineDescription")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改数据治理事件阈值
        /// </summary>
        /// <param name="req"><see cref="ModifyGovernEventRuleRequest"/></param>
        /// <returns><see cref="ModifyGovernEventRuleResponse"/></returns>
        public Task<ModifyGovernEventRuleResponse> ModifyGovernEventRule(ModifyGovernEventRuleRequest req)
        {
            return InternalRequestAsync<ModifyGovernEventRuleResponse>(req, "ModifyGovernEventRule");
        }

        /// <summary>
        /// 修改数据治理事件阈值
        /// </summary>
        /// <param name="req"><see cref="ModifyGovernEventRuleRequest"/></param>
        /// <returns><see cref="ModifyGovernEventRuleResponse"/></returns>
        public ModifyGovernEventRuleResponse ModifyGovernEventRuleSync(ModifyGovernEventRuleRequest req)
        {
            return InternalRequestAsync<ModifyGovernEventRuleResponse>(req, "ModifyGovernEventRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改实验室的调度优先级（1-9，数字越大优先级越高）
        /// </summary>
        /// <param name="req"><see cref="ModifyLabPriorityRequest"/></param>
        /// <returns><see cref="ModifyLabPriorityResponse"/></returns>
        public Task<ModifyLabPriorityResponse> ModifyLabPriority(ModifyLabPriorityRequest req)
        {
            return InternalRequestAsync<ModifyLabPriorityResponse>(req, "ModifyLabPriority");
        }

        /// <summary>
        /// 修改实验室的调度优先级（1-9，数字越大优先级越高）
        /// </summary>
        /// <param name="req"><see cref="ModifyLabPriorityRequest"/></param>
        /// <returns><see cref="ModifyLabPriorityResponse"/></returns>
        public ModifyLabPriorityResponse ModifyLabPrioritySync(ModifyLabPriorityRequest req)
        {
            return InternalRequestAsync<ModifyLabPriorityResponse>(req, "ModifyLabPriority")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改分区描述
        /// </summary>
        /// <param name="req"><see cref="ModifyPartitionDescriptionRequest"/></param>
        /// <returns><see cref="ModifyPartitionDescriptionResponse"/></returns>
        public Task<ModifyPartitionDescriptionResponse> ModifyPartitionDescription(ModifyPartitionDescriptionRequest req)
        {
            return InternalRequestAsync<ModifyPartitionDescriptionResponse>(req, "ModifyPartitionDescription");
        }

        /// <summary>
        /// 修改分区描述
        /// </summary>
        /// <param name="req"><see cref="ModifyPartitionDescriptionRequest"/></param>
        /// <returns><see cref="ModifyPartitionDescriptionResponse"/></returns>
        public ModifyPartitionDescriptionResponse ModifyPartitionDescriptionSync(ModifyPartitionDescriptionRequest req)
        {
            return InternalRequestAsync<ModifyPartitionDescriptionResponse>(req, "ModifyPartitionDescription")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑资源队列：根据队列ID修改指定资源队列的名称、描述、资源规格列表和队列类型等信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyPartitionQueueRequest"/></param>
        /// <returns><see cref="ModifyPartitionQueueResponse"/></returns>
        public Task<ModifyPartitionQueueResponse> ModifyPartitionQueue(ModifyPartitionQueueRequest req)
        {
            return InternalRequestAsync<ModifyPartitionQueueResponse>(req, "ModifyPartitionQueue");
        }

        /// <summary>
        /// 编辑资源队列：根据队列ID修改指定资源队列的名称、描述、资源规格列表和队列类型等信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyPartitionQueueRequest"/></param>
        /// <returns><see cref="ModifyPartitionQueueResponse"/></returns>
        public ModifyPartitionQueueResponse ModifyPartitionQueueSync(ModifyPartitionQueueRequest req)
        {
            return InternalRequestAsync<ModifyPartitionQueueResponse>(req, "ModifyPartitionQueue")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新spark作业
        /// </summary>
        /// <param name="req"><see cref="ModifySparkAppRequest"/></param>
        /// <returns><see cref="ModifySparkAppResponse"/></returns>
        public Task<ModifySparkAppResponse> ModifySparkApp(ModifySparkAppRequest req)
        {
            return InternalRequestAsync<ModifySparkAppResponse>(req, "ModifySparkApp");
        }

        /// <summary>
        /// 更新spark作业
        /// </summary>
        /// <param name="req"><see cref="ModifySparkAppRequest"/></param>
        /// <returns><see cref="ModifySparkAppResponse"/></returns>
        public ModifySparkAppResponse ModifySparkAppSync(ModifySparkAppRequest req)
        {
            return InternalRequestAsync<ModifySparkAppResponse>(req, "ModifySparkApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifySparkAppBatch）用于批量修改Spark作业参数配置
        /// </summary>
        /// <param name="req"><see cref="ModifySparkAppBatchRequest"/></param>
        /// <returns><see cref="ModifySparkAppBatchResponse"/></returns>
        public Task<ModifySparkAppBatchResponse> ModifySparkAppBatch(ModifySparkAppBatchRequest req)
        {
            return InternalRequestAsync<ModifySparkAppBatchResponse>(req, "ModifySparkAppBatch");
        }

        /// <summary>
        /// 本接口（ModifySparkAppBatch）用于批量修改Spark作业参数配置
        /// </summary>
        /// <param name="req"><see cref="ModifySparkAppBatchRequest"/></param>
        /// <returns><see cref="ModifySparkAppBatchResponse"/></returns>
        public ModifySparkAppBatchResponse ModifySparkAppBatchSync(ModifySparkAppBatchRequest req)
        {
            return InternalRequestAsync<ModifySparkAppBatchResponse>(req, "ModifySparkAppBatch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新tdlc spark作业
        /// </summary>
        /// <param name="req"><see cref="ModifySparkAppForTDLCRequest"/></param>
        /// <returns><see cref="ModifySparkAppForTDLCResponse"/></returns>
        public Task<ModifySparkAppForTDLCResponse> ModifySparkAppForTDLC(ModifySparkAppForTDLCRequest req)
        {
            return InternalRequestAsync<ModifySparkAppForTDLCResponse>(req, "ModifySparkAppForTDLC");
        }

        /// <summary>
        /// 更新tdlc spark作业
        /// </summary>
        /// <param name="req"><see cref="ModifySparkAppForTDLCRequest"/></param>
        /// <returns><see cref="ModifySparkAppForTDLCResponse"/></returns>
        public ModifySparkAppForTDLCResponse ModifySparkAppForTDLCSync(ModifySparkAppForTDLCRequest req)
        {
            return InternalRequestAsync<ModifySparkAppForTDLCResponse>(req, "ModifySparkAppForTDLC")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="req"><see cref="ModifyUserRequest"/></param>
        /// <returns><see cref="ModifyUserResponse"/></returns>
        public Task<ModifyUserResponse> ModifyUser(ModifyUserRequest req)
        {
            return InternalRequestAsync<ModifyUserResponse>(req, "ModifyUser");
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="req"><see cref="ModifyUserRequest"/></param>
        /// <returns><see cref="ModifyUserResponse"/></returns>
        public ModifyUserResponse ModifyUserSync(ModifyUserRequest req)
        {
            return InternalRequestAsync<ModifyUserResponse>(req, "ModifyUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改用户类型。只有管理员用户能够调用该接口进行操作
        /// </summary>
        /// <param name="req"><see cref="ModifyUserTypeRequest"/></param>
        /// <returns><see cref="ModifyUserTypeResponse"/></returns>
        public Task<ModifyUserTypeResponse> ModifyUserType(ModifyUserTypeRequest req)
        {
            return InternalRequestAsync<ModifyUserTypeResponse>(req, "ModifyUserType");
        }

        /// <summary>
        /// 修改用户类型。只有管理员用户能够调用该接口进行操作
        /// </summary>
        /// <param name="req"><see cref="ModifyUserTypeRequest"/></param>
        /// <returns><see cref="ModifyUserTypeResponse"/></returns>
        public ModifyUserTypeResponse ModifyUserTypeSync(ModifyUserTypeRequest req)
        {
            return InternalRequestAsync<ModifyUserTypeResponse>(req, "ModifyUserType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改工作组信息
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkGroupRequest"/></param>
        /// <returns><see cref="ModifyWorkGroupResponse"/></returns>
        public Task<ModifyWorkGroupResponse> ModifyWorkGroup(ModifyWorkGroupRequest req)
        {
            return InternalRequestAsync<ModifyWorkGroupResponse>(req, "ModifyWorkGroup");
        }

        /// <summary>
        /// 修改工作组信息
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkGroupRequest"/></param>
        /// <returns><see cref="ModifyWorkGroupResponse"/></returns>
        public ModifyWorkGroupResponse ModifyWorkGroupSync(ModifyWorkGroupRequest req)
        {
            return InternalRequestAsync<ModifyWorkGroupResponse>(req, "ModifyWorkGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 暂停标准引擎session
        /// </summary>
        /// <param name="req"><see cref="PauseStandardEngineResourceGroupsRequest"/></param>
        /// <returns><see cref="PauseStandardEngineResourceGroupsResponse"/></returns>
        public Task<PauseStandardEngineResourceGroupsResponse> PauseStandardEngineResourceGroups(PauseStandardEngineResourceGroupsRequest req)
        {
            return InternalRequestAsync<PauseStandardEngineResourceGroupsResponse>(req, "PauseStandardEngineResourceGroups");
        }

        /// <summary>
        /// 暂停标准引擎session
        /// </summary>
        /// <param name="req"><see cref="PauseStandardEngineResourceGroupsRequest"/></param>
        /// <returns><see cref="PauseStandardEngineResourceGroupsResponse"/></returns>
        public PauseStandardEngineResourceGroupsResponse PauseStandardEngineResourceGroupsSync(PauseStandardEngineResourceGroupsRequest req)
        {
            return InternalRequestAsync<PauseStandardEngineResourceGroupsResponse>(req, "PauseStandardEngineResourceGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 返回指定时间范围内所有推理服务的聚合 KPI 值。
        /// </summary>
        /// <param name="req"><see cref="QueryDashboardOverviewRequest"/></param>
        /// <returns><see cref="QueryDashboardOverviewResponse"/></returns>
        public Task<QueryDashboardOverviewResponse> QueryDashboardOverview(QueryDashboardOverviewRequest req)
        {
            return InternalRequestAsync<QueryDashboardOverviewResponse>(req, "QueryDashboardOverview");
        }

        /// <summary>
        /// 返回指定时间范围内所有推理服务的聚合 KPI 值。
        /// </summary>
        /// <param name="req"><see cref="QueryDashboardOverviewRequest"/></param>
        /// <returns><see cref="QueryDashboardOverviewResponse"/></returns>
        public QueryDashboardOverviewResponse QueryDashboardOverviewSync(QueryDashboardOverviewRequest req)
        {
            return InternalRequestAsync<QueryDashboardOverviewResponse>(req, "QueryDashboardOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询监控大盘服务列表
        /// </summary>
        /// <param name="req"><see cref="QueryDashboardServiceListRequest"/></param>
        /// <returns><see cref="QueryDashboardServiceListResponse"/></returns>
        public Task<QueryDashboardServiceListResponse> QueryDashboardServiceList(QueryDashboardServiceListRequest req)
        {
            return InternalRequestAsync<QueryDashboardServiceListResponse>(req, "QueryDashboardServiceList");
        }

        /// <summary>
        /// 查询监控大盘服务列表
        /// </summary>
        /// <param name="req"><see cref="QueryDashboardServiceListRequest"/></param>
        /// <returns><see cref="QueryDashboardServiceListResponse"/></returns>
        public QueryDashboardServiceListResponse QueryDashboardServiceListSync(QueryDashboardServiceListRequest req)
        {
            return InternalRequestAsync<QueryDashboardServiceListResponse>(req, "QueryDashboardServiceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（QueryInternalTableWarehouse）用于获取原生表warehouse路径
        /// </summary>
        /// <param name="req"><see cref="QueryInternalTableWarehouseRequest"/></param>
        /// <returns><see cref="QueryInternalTableWarehouseResponse"/></returns>
        public Task<QueryInternalTableWarehouseResponse> QueryInternalTableWarehouse(QueryInternalTableWarehouseRequest req)
        {
            return InternalRequestAsync<QueryInternalTableWarehouseResponse>(req, "QueryInternalTableWarehouse");
        }

        /// <summary>
        /// 本接口（QueryInternalTableWarehouse）用于获取原生表warehouse路径
        /// </summary>
        /// <param name="req"><see cref="QueryInternalTableWarehouseRequest"/></param>
        /// <returns><see cref="QueryInternalTableWarehouseResponse"/></returns>
        public QueryInternalTableWarehouseResponse QueryInternalTableWarehouseSync(QueryInternalTableWarehouseRequest req)
        {
            return InternalRequestAsync<QueryInternalTableWarehouseResponse>(req, "QueryInternalTableWarehouse")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询监控概览数据（瞬时值）
        /// </summary>
        /// <param name="req"><see cref="QueryMonitorOverviewRequest"/></param>
        /// <returns><see cref="QueryMonitorOverviewResponse"/></returns>
        public Task<QueryMonitorOverviewResponse> QueryMonitorOverview(QueryMonitorOverviewRequest req)
        {
            return InternalRequestAsync<QueryMonitorOverviewResponse>(req, "QueryMonitorOverview");
        }

        /// <summary>
        /// 查询监控概览数据（瞬时值）
        /// </summary>
        /// <param name="req"><see cref="QueryMonitorOverviewRequest"/></param>
        /// <returns><see cref="QueryMonitorOverviewResponse"/></returns>
        public QueryMonitorOverviewResponse QueryMonitorOverviewSync(QueryMonitorOverviewRequest req)
        {
            return InternalRequestAsync<QueryMonitorOverviewResponse>(req, "QueryMonitorOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取任务结果查询
        /// </summary>
        /// <param name="req"><see cref="QueryResultRequest"/></param>
        /// <returns><see cref="QueryResultResponse"/></returns>
        public Task<QueryResultResponse> QueryResult(QueryResultRequest req)
        {
            return InternalRequestAsync<QueryResultResponse>(req, "QueryResult");
        }

        /// <summary>
        /// 获取任务结果查询
        /// </summary>
        /// <param name="req"><see cref="QueryResultRequest"/></param>
        /// <returns><see cref="QueryResultResponse"/></returns>
        public QueryResultResponse QueryResultSync(QueryResultRequest req)
        {
            return InternalRequestAsync<QueryResultResponse>(req, "QueryResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（QueryTaskCostDetail）用于查询任务消耗明细
        /// </summary>
        /// <param name="req"><see cref="QueryTaskCostDetailRequest"/></param>
        /// <returns><see cref="QueryTaskCostDetailResponse"/></returns>
        public Task<QueryTaskCostDetailResponse> QueryTaskCostDetail(QueryTaskCostDetailRequest req)
        {
            return InternalRequestAsync<QueryTaskCostDetailResponse>(req, "QueryTaskCostDetail");
        }

        /// <summary>
        /// 该接口（QueryTaskCostDetail）用于查询任务消耗明细
        /// </summary>
        /// <param name="req"><see cref="QueryTaskCostDetailRequest"/></param>
        /// <returns><see cref="QueryTaskCostDetailResponse"/></returns>
        public QueryTaskCostDetailResponse QueryTaskCostDetailSync(QueryTaskCostDetailRequest req)
        {
            return InternalRequestAsync<QueryTaskCostDetailResponse>(req, "QueryTaskCostDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（RegisterThirdPartyAccessUser）用于开通第三方平台访问
        /// </summary>
        /// <param name="req"><see cref="RegisterThirdPartyAccessUserRequest"/></param>
        /// <returns><see cref="RegisterThirdPartyAccessUserResponse"/></returns>
        public Task<RegisterThirdPartyAccessUserResponse> RegisterThirdPartyAccessUser(RegisterThirdPartyAccessUserRequest req)
        {
            return InternalRequestAsync<RegisterThirdPartyAccessUserResponse>(req, "RegisterThirdPartyAccessUser");
        }

        /// <summary>
        /// 本接口（RegisterThirdPartyAccessUser）用于开通第三方平台访问
        /// </summary>
        /// <param name="req"><see cref="RegisterThirdPartyAccessUserRequest"/></param>
        /// <returns><see cref="RegisterThirdPartyAccessUserResponse"/></returns>
        public RegisterThirdPartyAccessUserResponse RegisterThirdPartyAccessUserSync(RegisterThirdPartyAccessUserRequest req)
        {
            return InternalRequestAsync<RegisterThirdPartyAccessUserResponse>(req, "RegisterThirdPartyAccessUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 续费数据引擎
        /// </summary>
        /// <param name="req"><see cref="RenewDataEngineRequest"/></param>
        /// <returns><see cref="RenewDataEngineResponse"/></returns>
        public Task<RenewDataEngineResponse> RenewDataEngine(RenewDataEngineRequest req)
        {
            return InternalRequestAsync<RenewDataEngineResponse>(req, "RenewDataEngine");
        }

        /// <summary>
        /// 续费数据引擎
        /// </summary>
        /// <param name="req"><see cref="RenewDataEngineRequest"/></param>
        /// <returns><see cref="RenewDataEngineResponse"/></returns>
        public RenewDataEngineResponse RenewDataEngineSync(RenewDataEngineRequest req)
        {
            return InternalRequestAsync<RenewDataEngineResponse>(req, "RenewDataEngine")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 上报元数据心跳
        /// </summary>
        /// <param name="req"><see cref="ReportHeartbeatMetaDataRequest"/></param>
        /// <returns><see cref="ReportHeartbeatMetaDataResponse"/></returns>
        public Task<ReportHeartbeatMetaDataResponse> ReportHeartbeatMetaData(ReportHeartbeatMetaDataRequest req)
        {
            return InternalRequestAsync<ReportHeartbeatMetaDataResponse>(req, "ReportHeartbeatMetaData");
        }

        /// <summary>
        /// 上报元数据心跳
        /// </summary>
        /// <param name="req"><see cref="ReportHeartbeatMetaDataRequest"/></param>
        /// <returns><see cref="ReportHeartbeatMetaDataResponse"/></returns>
        public ReportHeartbeatMetaDataResponse ReportHeartbeatMetaDataSync(ReportHeartbeatMetaDataRequest req)
        {
            return InternalRequestAsync<ReportHeartbeatMetaDataResponse>(req, "ReportHeartbeatMetaData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重启引擎
        /// </summary>
        /// <param name="req"><see cref="RestartDataEngineRequest"/></param>
        /// <returns><see cref="RestartDataEngineResponse"/></returns>
        public Task<RestartDataEngineResponse> RestartDataEngine(RestartDataEngineRequest req)
        {
            return InternalRequestAsync<RestartDataEngineResponse>(req, "RestartDataEngine");
        }

        /// <summary>
        /// 重启引擎
        /// </summary>
        /// <param name="req"><see cref="RestartDataEngineRequest"/></param>
        /// <returns><see cref="RestartDataEngineResponse"/></returns>
        public RestartDataEngineResponse RestartDataEngineSync(RestartDataEngineRequest req)
        {
            return InternalRequestAsync<RestartDataEngineResponse>(req, "RestartDataEngine")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重启推理服务（操作所有部署）。
        /// </summary>
        /// <param name="req"><see cref="RestartInferenceServiceRequest"/></param>
        /// <returns><see cref="RestartInferenceServiceResponse"/></returns>
        public Task<RestartInferenceServiceResponse> RestartInferenceService(RestartInferenceServiceRequest req)
        {
            return InternalRequestAsync<RestartInferenceServiceResponse>(req, "RestartInferenceService");
        }

        /// <summary>
        /// 重启推理服务（操作所有部署）。
        /// </summary>
        /// <param name="req"><see cref="RestartInferenceServiceRequest"/></param>
        /// <returns><see cref="RestartInferenceServiceResponse"/></returns>
        public RestartInferenceServiceResponse RestartInferenceServiceSync(RestartInferenceServiceRequest req)
        {
            return InternalRequestAsync<RestartInferenceServiceResponse>(req, "RestartInferenceService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 撤销DLC Catalog访问权限
        /// </summary>
        /// <param name="req"><see cref="RevokeDLCCatalogAccessRequest"/></param>
        /// <returns><see cref="RevokeDLCCatalogAccessResponse"/></returns>
        public Task<RevokeDLCCatalogAccessResponse> RevokeDLCCatalogAccess(RevokeDLCCatalogAccessRequest req)
        {
            return InternalRequestAsync<RevokeDLCCatalogAccessResponse>(req, "RevokeDLCCatalogAccess");
        }

        /// <summary>
        /// 撤销DLC Catalog访问权限
        /// </summary>
        /// <param name="req"><see cref="RevokeDLCCatalogAccessRequest"/></param>
        /// <returns><see cref="RevokeDLCCatalogAccessResponse"/></returns>
        public RevokeDLCCatalogAccessResponse RevokeDLCCatalogAccessSync(RevokeDLCCatalogAccessRequest req)
        {
            return InternalRequestAsync<RevokeDLCCatalogAccessResponse>(req, "RevokeDLCCatalogAccess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 回滚引擎镜像版本
        /// </summary>
        /// <param name="req"><see cref="RollbackDataEngineImageRequest"/></param>
        /// <returns><see cref="RollbackDataEngineImageResponse"/></returns>
        public Task<RollbackDataEngineImageResponse> RollbackDataEngineImage(RollbackDataEngineImageRequest req)
        {
            return InternalRequestAsync<RollbackDataEngineImageResponse>(req, "RollbackDataEngineImage");
        }

        /// <summary>
        /// 回滚引擎镜像版本
        /// </summary>
        /// <param name="req"><see cref="RollbackDataEngineImageRequest"/></param>
        /// <returns><see cref="RollbackDataEngineImageResponse"/></returns>
        public RollbackDataEngineImageResponse RollbackDataEngineImageSync(RollbackDataEngineImageRequest req)
        {
            return InternalRequestAsync<RollbackDataEngineImageResponse>(req, "RollbackDataEngineImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 基于指定作业配置提交一次作业实例
        /// </summary>
        /// <param name="req"><see cref="RunJobSpecRequest"/></param>
        /// <returns><see cref="RunJobSpecResponse"/></returns>
        public Task<RunJobSpecResponse> RunJobSpec(RunJobSpecRequest req)
        {
            return InternalRequestAsync<RunJobSpecResponse>(req, "RunJobSpec");
        }

        /// <summary>
        /// 基于指定作业配置提交一次作业实例
        /// </summary>
        /// <param name="req"><see cref="RunJobSpecRequest"/></param>
        /// <returns><see cref="RunJobSpecResponse"/></returns>
        public RunJobSpecResponse RunJobSpecSync(RunJobSpecRequest req)
        {
            return InternalRequestAsync<RunJobSpecResponse>(req, "RunJobSpec")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置优化策略的接口
        /// </summary>
        /// <param name="req"><see cref="SetOptimizerPolicyRequest"/></param>
        /// <returns><see cref="SetOptimizerPolicyResponse"/></returns>
        public Task<SetOptimizerPolicyResponse> SetOptimizerPolicy(SetOptimizerPolicyRequest req)
        {
            return InternalRequestAsync<SetOptimizerPolicyResponse>(req, "SetOptimizerPolicy");
        }

        /// <summary>
        /// 设置优化策略的接口
        /// </summary>
        /// <param name="req"><see cref="SetOptimizerPolicyRequest"/></param>
        /// <returns><see cref="SetOptimizerPolicyResponse"/></returns>
        public SetOptimizerPolicyResponse SetOptimizerPolicySync(SetOptimizerPolicyRequest req)
        {
            return InternalRequestAsync<SetOptimizerPolicyResponse>(req, "SetOptimizerPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启动实验室
        /// </summary>
        /// <param name="req"><see cref="StartLabRequest"/></param>
        /// <returns><see cref="StartLabResponse"/></returns>
        public Task<StartLabResponse> StartLab(StartLabRequest req)
        {
            return InternalRequestAsync<StartLabResponse>(req, "StartLab");
        }

        /// <summary>
        /// 启动实验室
        /// </summary>
        /// <param name="req"><see cref="StartLabRequest"/></param>
        /// <returns><see cref="StartLabResponse"/></returns>
        public StartLabResponse StartLabSync(StartLabRequest req)
        {
            return InternalRequestAsync<StartLabResponse>(req, "StartLab")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启动集群
        /// </summary>
        /// <param name="req"><see cref="StartRayClusterRequest"/></param>
        /// <returns><see cref="StartRayClusterResponse"/></returns>
        public Task<StartRayClusterResponse> StartRayCluster(StartRayClusterRequest req)
        {
            return InternalRequestAsync<StartRayClusterResponse>(req, "StartRayCluster");
        }

        /// <summary>
        /// 启动集群
        /// </summary>
        /// <param name="req"><see cref="StartRayClusterRequest"/></param>
        /// <returns><see cref="StartRayClusterResponse"/></returns>
        public StartRayClusterResponse StartRayClusterSync(StartRayClusterRequest req)
        {
            return InternalRequestAsync<StartRayClusterResponse>(req, "StartRayCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止推理服务（操作所有部署）。
        /// </summary>
        /// <param name="req"><see cref="StopInferenceServiceRequest"/></param>
        /// <returns><see cref="StopInferenceServiceResponse"/></returns>
        public Task<StopInferenceServiceResponse> StopInferenceService(StopInferenceServiceRequest req)
        {
            return InternalRequestAsync<StopInferenceServiceResponse>(req, "StopInferenceService");
        }

        /// <summary>
        /// 停止推理服务（操作所有部署）。
        /// </summary>
        /// <param name="req"><see cref="StopInferenceServiceRequest"/></param>
        /// <returns><see cref="StopInferenceServiceResponse"/></returns>
        public StopInferenceServiceResponse StopInferenceServiceSync(StopInferenceServiceRequest req)
        {
            return InternalRequestAsync<StopInferenceServiceResponse>(req, "StopInferenceService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止实验室
        /// </summary>
        /// <param name="req"><see cref="StopLabRequest"/></param>
        /// <returns><see cref="StopLabResponse"/></returns>
        public Task<StopLabResponse> StopLab(StopLabRequest req)
        {
            return InternalRequestAsync<StopLabResponse>(req, "StopLab");
        }

        /// <summary>
        /// 停止实验室
        /// </summary>
        /// <param name="req"><see cref="StopLabRequest"/></param>
        /// <returns><see cref="StopLabResponse"/></returns>
        public StopLabResponse StopLabSync(StopLabRequest req)
        {
            return InternalRequestAsync<StopLabResponse>(req, "StopLab")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止集群
        /// </summary>
        /// <param name="req"><see cref="StopRayClusterRequest"/></param>
        /// <returns><see cref="StopRayClusterResponse"/></returns>
        public Task<StopRayClusterResponse> StopRayCluster(StopRayClusterRequest req)
        {
            return InternalRequestAsync<StopRayClusterResponse>(req, "StopRayCluster");
        }

        /// <summary>
        /// 停止集群
        /// </summary>
        /// <param name="req"><see cref="StopRayClusterRequest"/></param>
        /// <returns><see cref="StopRayClusterResponse"/></returns>
        public StopRayClusterResponse StopRayClusterSync(StopRayClusterRequest req)
        {
            return InternalRequestAsync<StopRayClusterResponse>(req, "StopRayCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于控制挂起或启动数据引擎
        /// </summary>
        /// <param name="req"><see cref="SuspendResumeDataEngineRequest"/></param>
        /// <returns><see cref="SuspendResumeDataEngineResponse"/></returns>
        public Task<SuspendResumeDataEngineResponse> SuspendResumeDataEngine(SuspendResumeDataEngineRequest req)
        {
            return InternalRequestAsync<SuspendResumeDataEngineResponse>(req, "SuspendResumeDataEngine");
        }

        /// <summary>
        /// 本接口用于控制挂起或启动数据引擎
        /// </summary>
        /// <param name="req"><see cref="SuspendResumeDataEngineRequest"/></param>
        /// <returns><see cref="SuspendResumeDataEngineResponse"/></returns>
        public SuspendResumeDataEngineResponse SuspendResumeDataEngineSync(SuspendResumeDataEngineRequest req)
        {
            return InternalRequestAsync<SuspendResumeDataEngineResponse>(req, "SuspendResumeDataEngine")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 切换主备集群
        /// </summary>
        /// <param name="req"><see cref="SwitchDataEngineRequest"/></param>
        /// <returns><see cref="SwitchDataEngineResponse"/></returns>
        public Task<SwitchDataEngineResponse> SwitchDataEngine(SwitchDataEngineRequest req)
        {
            return InternalRequestAsync<SwitchDataEngineResponse>(req, "SwitchDataEngine");
        }

        /// <summary>
        /// 切换主备集群
        /// </summary>
        /// <param name="req"><see cref="SwitchDataEngineRequest"/></param>
        /// <returns><see cref="SwitchDataEngineResponse"/></returns>
        public SwitchDataEngineResponse SwitchDataEngineSync(SwitchDataEngineRequest req)
        {
            return InternalRequestAsync<SwitchDataEngineResponse>(req, "SwitchDataEngine")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 切换引擎镜像版本
        /// </summary>
        /// <param name="req"><see cref="SwitchDataEngineImageRequest"/></param>
        /// <returns><see cref="SwitchDataEngineImageResponse"/></returns>
        public Task<SwitchDataEngineImageResponse> SwitchDataEngineImage(SwitchDataEngineImageRequest req)
        {
            return InternalRequestAsync<SwitchDataEngineImageResponse>(req, "SwitchDataEngineImage");
        }

        /// <summary>
        /// 切换引擎镜像版本
        /// </summary>
        /// <param name="req"><see cref="SwitchDataEngineImageRequest"/></param>
        /// <returns><see cref="SwitchDataEngineImageResponse"/></returns>
        public SwitchDataEngineImageResponse SwitchDataEngineImageSync(SwitchDataEngineImageRequest req)
        {
            return InternalRequestAsync<SwitchDataEngineImageResponse>(req, "SwitchDataEngineImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解绑用户上的用户组
        /// </summary>
        /// <param name="req"><see cref="UnbindWorkGroupsFromUserRequest"/></param>
        /// <returns><see cref="UnbindWorkGroupsFromUserResponse"/></returns>
        public Task<UnbindWorkGroupsFromUserResponse> UnbindWorkGroupsFromUser(UnbindWorkGroupsFromUserRequest req)
        {
            return InternalRequestAsync<UnbindWorkGroupsFromUserResponse>(req, "UnbindWorkGroupsFromUser");
        }

        /// <summary>
        /// 解绑用户上的用户组
        /// </summary>
        /// <param name="req"><see cref="UnbindWorkGroupsFromUserRequest"/></param>
        /// <returns><see cref="UnbindWorkGroupsFromUserResponse"/></returns>
        public UnbindWorkGroupsFromUserResponse UnbindWorkGroupsFromUserSync(UnbindWorkGroupsFromUserRequest req)
        {
            return InternalRequestAsync<UnbindWorkGroupsFromUserResponse>(req, "UnbindWorkGroupsFromUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解绑数据源与队列
        /// </summary>
        /// <param name="req"><see cref="UnboundDatasourceHouseRequest"/></param>
        /// <returns><see cref="UnboundDatasourceHouseResponse"/></returns>
        public Task<UnboundDatasourceHouseResponse> UnboundDatasourceHouse(UnboundDatasourceHouseRequest req)
        {
            return InternalRequestAsync<UnboundDatasourceHouseResponse>(req, "UnboundDatasourceHouse");
        }

        /// <summary>
        /// 解绑数据源与队列
        /// </summary>
        /// <param name="req"><see cref="UnboundDatasourceHouseRequest"/></param>
        /// <returns><see cref="UnboundDatasourceHouseResponse"/></returns>
        public UnboundDatasourceHouseResponse UnboundDatasourceHouseSync(UnboundDatasourceHouseRequest req)
        {
            return InternalRequestAsync<UnboundDatasourceHouseResponse>(req, "UnboundDatasourceHouse")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 元数据解锁
        /// </summary>
        /// <param name="req"><see cref="UnlockMetaDataRequest"/></param>
        /// <returns><see cref="UnlockMetaDataResponse"/></returns>
        public Task<UnlockMetaDataResponse> UnlockMetaData(UnlockMetaDataRequest req)
        {
            return InternalRequestAsync<UnlockMetaDataResponse>(req, "UnlockMetaData");
        }

        /// <summary>
        /// 元数据解锁
        /// </summary>
        /// <param name="req"><see cref="UnlockMetaDataRequest"/></param>
        /// <returns><see cref="UnlockMetaDataResponse"/></returns>
        public UnlockMetaDataResponse UnlockMetaDataSync(UnlockMetaDataRequest req)
        {
            return InternalRequestAsync<UnlockMetaDataResponse>(req, "UnlockMetaData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新集群组
        /// </summary>
        /// <param name="req"><see cref="UpdateClusterGroupRequest"/></param>
        /// <returns><see cref="UpdateClusterGroupResponse"/></returns>
        public Task<UpdateClusterGroupResponse> UpdateClusterGroup(UpdateClusterGroupRequest req)
        {
            return InternalRequestAsync<UpdateClusterGroupResponse>(req, "UpdateClusterGroup");
        }

        /// <summary>
        /// 更新集群组
        /// </summary>
        /// <param name="req"><see cref="UpdateClusterGroupRequest"/></param>
        /// <returns><see cref="UpdateClusterGroupResponse"/></returns>
        public UpdateClusterGroupResponse UpdateClusterGroupSync(UpdateClusterGroupRequest req)
        {
            return InternalRequestAsync<UpdateClusterGroupResponse>(req, "UpdateClusterGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于更新数据引擎配置
        /// </summary>
        /// <param name="req"><see cref="UpdateDataEngineRequest"/></param>
        /// <returns><see cref="UpdateDataEngineResponse"/></returns>
        public Task<UpdateDataEngineResponse> UpdateDataEngine(UpdateDataEngineRequest req)
        {
            return InternalRequestAsync<UpdateDataEngineResponse>(req, "UpdateDataEngine");
        }

        /// <summary>
        /// 本接口用于更新数据引擎配置
        /// </summary>
        /// <param name="req"><see cref="UpdateDataEngineRequest"/></param>
        /// <returns><see cref="UpdateDataEngineResponse"/></returns>
        public UpdateDataEngineResponse UpdateDataEngineSync(UpdateDataEngineRequest req)
        {
            return InternalRequestAsync<UpdateDataEngineResponse>(req, "UpdateDataEngine")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户某种操作，触发引擎配置修改
        /// </summary>
        /// <param name="req"><see cref="UpdateDataEngineConfigRequest"/></param>
        /// <returns><see cref="UpdateDataEngineConfigResponse"/></returns>
        public Task<UpdateDataEngineConfigResponse> UpdateDataEngineConfig(UpdateDataEngineConfigRequest req)
        {
            return InternalRequestAsync<UpdateDataEngineConfigResponse>(req, "UpdateDataEngineConfig");
        }

        /// <summary>
        /// 用户某种操作，触发引擎配置修改
        /// </summary>
        /// <param name="req"><see cref="UpdateDataEngineConfigRequest"/></param>
        /// <returns><see cref="UpdateDataEngineConfigResponse"/></returns>
        public UpdateDataEngineConfigResponse UpdateDataEngineConfigSync(UpdateDataEngineConfigRequest req)
        {
            return InternalRequestAsync<UpdateDataEngineConfigResponse>(req, "UpdateDataEngineConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新数据脱敏策略
        /// </summary>
        /// <param name="req"><see cref="UpdateDataMaskStrategyRequest"/></param>
        /// <returns><see cref="UpdateDataMaskStrategyResponse"/></returns>
        public Task<UpdateDataMaskStrategyResponse> UpdateDataMaskStrategy(UpdateDataMaskStrategyRequest req)
        {
            return InternalRequestAsync<UpdateDataMaskStrategyResponse>(req, "UpdateDataMaskStrategy");
        }

        /// <summary>
        /// 更新数据脱敏策略
        /// </summary>
        /// <param name="req"><see cref="UpdateDataMaskStrategyRequest"/></param>
        /// <returns><see cref="UpdateDataMaskStrategyResponse"/></returns>
        public UpdateDataMaskStrategyResponse UpdateDataMaskStrategySync(UpdateDataMaskStrategyRequest req)
        {
            return InternalRequestAsync<UpdateDataMaskStrategyResponse>(req, "UpdateDataMaskStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新标准引擎资源组网络配置信息
        /// </summary>
        /// <param name="req"><see cref="UpdateEngineResourceGroupNetworkConfigInfoRequest"/></param>
        /// <returns><see cref="UpdateEngineResourceGroupNetworkConfigInfoResponse"/></returns>
        public Task<UpdateEngineResourceGroupNetworkConfigInfoResponse> UpdateEngineResourceGroupNetworkConfigInfo(UpdateEngineResourceGroupNetworkConfigInfoRequest req)
        {
            return InternalRequestAsync<UpdateEngineResourceGroupNetworkConfigInfoResponse>(req, "UpdateEngineResourceGroupNetworkConfigInfo");
        }

        /// <summary>
        /// 更新标准引擎资源组网络配置信息
        /// </summary>
        /// <param name="req"><see cref="UpdateEngineResourceGroupNetworkConfigInfoRequest"/></param>
        /// <returns><see cref="UpdateEngineResourceGroupNetworkConfigInfoResponse"/></returns>
        public UpdateEngineResourceGroupNetworkConfigInfoResponse UpdateEngineResourceGroupNetworkConfigInfoSync(UpdateEngineResourceGroupNetworkConfigInfoRequest req)
        {
            return InternalRequestAsync<UpdateEngineResourceGroupNetworkConfigInfoResponse>(req, "UpdateEngineResourceGroupNetworkConfigInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新推理模型（编辑标签、描述、参数量）
        /// </summary>
        /// <param name="req"><see cref="UpdateInferenceModelRequest"/></param>
        /// <returns><see cref="UpdateInferenceModelResponse"/></returns>
        public Task<UpdateInferenceModelResponse> UpdateInferenceModel(UpdateInferenceModelRequest req)
        {
            return InternalRequestAsync<UpdateInferenceModelResponse>(req, "UpdateInferenceModel");
        }

        /// <summary>
        /// 更新推理模型（编辑标签、描述、参数量）
        /// </summary>
        /// <param name="req"><see cref="UpdateInferenceModelRequest"/></param>
        /// <returns><see cref="UpdateInferenceModelResponse"/></returns>
        public UpdateInferenceModelResponse UpdateInferenceModelSync(UpdateInferenceModelRequest req)
        {
            return InternalRequestAsync<UpdateInferenceModelResponse>(req, "UpdateInferenceModel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新已有作业配置的字段
        /// </summary>
        /// <param name="req"><see cref="UpdateJobSpecRequest"/></param>
        /// <returns><see cref="UpdateJobSpecResponse"/></returns>
        public Task<UpdateJobSpecResponse> UpdateJobSpec(UpdateJobSpecRequest req)
        {
            return InternalRequestAsync<UpdateJobSpecResponse>(req, "UpdateJobSpec");
        }

        /// <summary>
        /// 更新已有作业配置的字段
        /// </summary>
        /// <param name="req"><see cref="UpdateJobSpecRequest"/></param>
        /// <returns><see cref="UpdateJobSpecResponse"/></returns>
        public UpdateJobSpecResponse UpdateJobSpecSync(UpdateJobSpecRequest req)
        {
            return InternalRequestAsync<UpdateJobSpecResponse>(req, "UpdateJobSpec")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改作业配置的调度优先级（1-9，数字越大优先级越高）
        /// </summary>
        /// <param name="req"><see cref="UpdateJobSpecPriorityRequest"/></param>
        /// <returns><see cref="UpdateJobSpecPriorityResponse"/></returns>
        public Task<UpdateJobSpecPriorityResponse> UpdateJobSpecPriority(UpdateJobSpecPriorityRequest req)
        {
            return InternalRequestAsync<UpdateJobSpecPriorityResponse>(req, "UpdateJobSpecPriority");
        }

        /// <summary>
        /// 修改作业配置的调度优先级（1-9，数字越大优先级越高）
        /// </summary>
        /// <param name="req"><see cref="UpdateJobSpecPriorityRequest"/></param>
        /// <returns><see cref="UpdateJobSpecPriorityResponse"/></returns>
        public UpdateJobSpecPriorityResponse UpdateJobSpecPrioritySync(UpdateJobSpecPriorityRequest req)
        {
            return InternalRequestAsync<UpdateJobSpecPriorityResponse>(req, "UpdateJobSpecPriority")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新实验室配置：仅在 CREATED / STOPPED / FAILED 终态可用；变更落 MySQL，下次 Start 按新 spec 创建 K8s 资源
        /// </summary>
        /// <param name="req"><see cref="UpdateLabRequest"/></param>
        /// <returns><see cref="UpdateLabResponse"/></returns>
        public Task<UpdateLabResponse> UpdateLab(UpdateLabRequest req)
        {
            return InternalRequestAsync<UpdateLabResponse>(req, "UpdateLab");
        }

        /// <summary>
        /// 更新实验室配置：仅在 CREATED / STOPPED / FAILED 终态可用；变更落 MySQL，下次 Start 按新 spec 创建 K8s 资源
        /// </summary>
        /// <param name="req"><see cref="UpdateLabRequest"/></param>
        /// <returns><see cref="UpdateLabResponse"/></returns>
        public UpdateLabResponse UpdateLabSync(UpdateLabRequest req)
        {
            return InternalRequestAsync<UpdateLabResponse>(req, "UpdateLab")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新网络配置
        /// </summary>
        /// <param name="req"><see cref="UpdateNetworkConnectionRequest"/></param>
        /// <returns><see cref="UpdateNetworkConnectionResponse"/></returns>
        public Task<UpdateNetworkConnectionResponse> UpdateNetworkConnection(UpdateNetworkConnectionRequest req)
        {
            return InternalRequestAsync<UpdateNetworkConnectionResponse>(req, "UpdateNetworkConnection");
        }

        /// <summary>
        /// 更新网络配置
        /// </summary>
        /// <param name="req"><see cref="UpdateNetworkConnectionRequest"/></param>
        /// <returns><see cref="UpdateNetworkConnectionResponse"/></returns>
        public UpdateNetworkConnectionResponse UpdateNetworkConnectionSync(UpdateNetworkConnectionRequest req)
        {
            return InternalRequestAsync<UpdateNetworkConnectionResponse>(req, "UpdateNetworkConnection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新集群配置：仅在 CREATED / STOPPED / FAILED 终态可用；变更落 MySQL，下次 Start 按新 spec 创建 K8s 资源
        /// </summary>
        /// <param name="req"><see cref="UpdateRayClusterRequest"/></param>
        /// <returns><see cref="UpdateRayClusterResponse"/></returns>
        public Task<UpdateRayClusterResponse> UpdateRayCluster(UpdateRayClusterRequest req)
        {
            return InternalRequestAsync<UpdateRayClusterResponse>(req, "UpdateRayCluster");
        }

        /// <summary>
        /// 更新集群配置：仅在 CREATED / STOPPED / FAILED 终态可用；变更落 MySQL，下次 Start 按新 spec 创建 K8s 资源
        /// </summary>
        /// <param name="req"><see cref="UpdateRayClusterRequest"/></param>
        /// <returns><see cref="UpdateRayClusterResponse"/></returns>
        public UpdateRayClusterResponse UpdateRayClusterSync(UpdateRayClusterRequest req)
        {
            return InternalRequestAsync<UpdateRayClusterResponse>(req, "UpdateRayCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新处于 SUBMITTED/PENDING 状态的作业的优先级。仅 SUBMITTED/PENDING 状态的作业允许调整优先级。内部通过调用 Neutrino 的 UpdateJobConfig 接口更新 ENVIRONMENT 配置中的 priority 字段。
        /// </summary>
        /// <param name="req"><see cref="UpdateRayJobPriorityRequest"/></param>
        /// <returns><see cref="UpdateRayJobPriorityResponse"/></returns>
        public Task<UpdateRayJobPriorityResponse> UpdateRayJobPriority(UpdateRayJobPriorityRequest req)
        {
            return InternalRequestAsync<UpdateRayJobPriorityResponse>(req, "UpdateRayJobPriority");
        }

        /// <summary>
        /// 更新处于 SUBMITTED/PENDING 状态的作业的优先级。仅 SUBMITTED/PENDING 状态的作业允许调整优先级。内部通过调用 Neutrino 的 UpdateJobConfig 接口更新 ENVIRONMENT 配置中的 priority 字段。
        /// </summary>
        /// <param name="req"><see cref="UpdateRayJobPriorityRequest"/></param>
        /// <returns><see cref="UpdateRayJobPriorityResponse"/></returns>
        public UpdateRayJobPriorityResponse UpdateRayJobPrioritySync(UpdateRayJobPriorityRequest req)
        {
            return InternalRequestAsync<UpdateRayJobPriorityResponse>(req, "UpdateRayJobPriority")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新资源配置模板
        /// </summary>
        /// <param name="req"><see cref="UpdateResourceConfigRequest"/></param>
        /// <returns><see cref="UpdateResourceConfigResponse"/></returns>
        public Task<UpdateResourceConfigResponse> UpdateResourceConfig(UpdateResourceConfigRequest req)
        {
            return InternalRequestAsync<UpdateResourceConfigResponse>(req, "UpdateResourceConfig");
        }

        /// <summary>
        /// 更新资源配置模板
        /// </summary>
        /// <param name="req"><see cref="UpdateResourceConfigRequest"/></param>
        /// <returns><see cref="UpdateResourceConfigResponse"/></returns>
        public UpdateResourceConfigResponse UpdateResourceConfigSync(UpdateResourceConfigRequest req)
        {
            return InternalRequestAsync<UpdateResourceConfigResponse>(req, "UpdateResourceConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口用于更新行过滤规则。注意只能更新过滤规则，不能更新规格对象catalog，database和table。
        /// </summary>
        /// <param name="req"><see cref="UpdateRowFilterRequest"/></param>
        /// <returns><see cref="UpdateRowFilterResponse"/></returns>
        public Task<UpdateRowFilterResponse> UpdateRowFilter(UpdateRowFilterRequest req)
        {
            return InternalRequestAsync<UpdateRowFilterResponse>(req, "UpdateRowFilter");
        }

        /// <summary>
        /// 此接口用于更新行过滤规则。注意只能更新过滤规则，不能更新规格对象catalog，database和table。
        /// </summary>
        /// <param name="req"><see cref="UpdateRowFilterRequest"/></param>
        /// <returns><see cref="UpdateRowFilterResponse"/></returns>
        public UpdateRowFilterResponse UpdateRowFilterSync(UpdateRowFilterRequest req)
        {
            return InternalRequestAsync<UpdateRowFilterResponse>(req, "UpdateRowFilter")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新标准引擎资源组基础信息
        /// </summary>
        /// <param name="req"><see cref="UpdateStandardEngineResourceGroupBaseInfoRequest"/></param>
        /// <returns><see cref="UpdateStandardEngineResourceGroupBaseInfoResponse"/></returns>
        public Task<UpdateStandardEngineResourceGroupBaseInfoResponse> UpdateStandardEngineResourceGroupBaseInfo(UpdateStandardEngineResourceGroupBaseInfoRequest req)
        {
            return InternalRequestAsync<UpdateStandardEngineResourceGroupBaseInfoResponse>(req, "UpdateStandardEngineResourceGroupBaseInfo");
        }

        /// <summary>
        /// 更新标准引擎资源组基础信息
        /// </summary>
        /// <param name="req"><see cref="UpdateStandardEngineResourceGroupBaseInfoRequest"/></param>
        /// <returns><see cref="UpdateStandardEngineResourceGroupBaseInfoResponse"/></returns>
        public UpdateStandardEngineResourceGroupBaseInfoResponse UpdateStandardEngineResourceGroupBaseInfoSync(UpdateStandardEngineResourceGroupBaseInfoRequest req)
        {
            return InternalRequestAsync<UpdateStandardEngineResourceGroupBaseInfoResponse>(req, "UpdateStandardEngineResourceGroupBaseInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新标准引擎资源组基础信息
        /// </summary>
        /// <param name="req"><see cref="UpdateStandardEngineResourceGroupConfigInfoRequest"/></param>
        /// <returns><see cref="UpdateStandardEngineResourceGroupConfigInfoResponse"/></returns>
        public Task<UpdateStandardEngineResourceGroupConfigInfoResponse> UpdateStandardEngineResourceGroupConfigInfo(UpdateStandardEngineResourceGroupConfigInfoRequest req)
        {
            return InternalRequestAsync<UpdateStandardEngineResourceGroupConfigInfoResponse>(req, "UpdateStandardEngineResourceGroupConfigInfo");
        }

        /// <summary>
        /// 更新标准引擎资源组基础信息
        /// </summary>
        /// <param name="req"><see cref="UpdateStandardEngineResourceGroupConfigInfoRequest"/></param>
        /// <returns><see cref="UpdateStandardEngineResourceGroupConfigInfoResponse"/></returns>
        public UpdateStandardEngineResourceGroupConfigInfoResponse UpdateStandardEngineResourceGroupConfigInfoSync(UpdateStandardEngineResourceGroupConfigInfoRequest req)
        {
            return InternalRequestAsync<UpdateStandardEngineResourceGroupConfigInfoResponse>(req, "UpdateStandardEngineResourceGroupConfigInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新标准引擎资源组基础信息
        /// </summary>
        /// <param name="req"><see cref="UpdateStandardEngineResourceGroupResourceInfoRequest"/></param>
        /// <returns><see cref="UpdateStandardEngineResourceGroupResourceInfoResponse"/></returns>
        public Task<UpdateStandardEngineResourceGroupResourceInfoResponse> UpdateStandardEngineResourceGroupResourceInfo(UpdateStandardEngineResourceGroupResourceInfoRequest req)
        {
            return InternalRequestAsync<UpdateStandardEngineResourceGroupResourceInfoResponse>(req, "UpdateStandardEngineResourceGroupResourceInfo");
        }

        /// <summary>
        /// 更新标准引擎资源组基础信息
        /// </summary>
        /// <param name="req"><see cref="UpdateStandardEngineResourceGroupResourceInfoRequest"/></param>
        /// <returns><see cref="UpdateStandardEngineResourceGroupResourceInfoResponse"/></returns>
        public UpdateStandardEngineResourceGroupResourceInfoResponse UpdateStandardEngineResourceGroupResourceInfoSync(UpdateStandardEngineResourceGroupResourceInfoRequest req)
        {
            return InternalRequestAsync<UpdateStandardEngineResourceGroupResourceInfoResponse>(req, "UpdateStandardEngineResourceGroupResourceInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// UDP权限修改
        /// </summary>
        /// <param name="req"><see cref="UpdateUDFPolicyRequest"/></param>
        /// <returns><see cref="UpdateUDFPolicyResponse"/></returns>
        public Task<UpdateUDFPolicyResponse> UpdateUDFPolicy(UpdateUDFPolicyRequest req)
        {
            return InternalRequestAsync<UpdateUDFPolicyResponse>(req, "UpdateUDFPolicy");
        }

        /// <summary>
        /// UDP权限修改
        /// </summary>
        /// <param name="req"><see cref="UpdateUDFPolicyRequest"/></param>
        /// <returns><see cref="UpdateUDFPolicyResponse"/></returns>
        public UpdateUDFPolicyResponse UpdateUDFPolicySync(UpdateUDFPolicyRequest req)
        {
            return InternalRequestAsync<UpdateUDFPolicyResponse>(req, "UpdateUDFPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改用户引擎自定义配置
        /// </summary>
        /// <param name="req"><see cref="UpdateUserDataEngineConfigRequest"/></param>
        /// <returns><see cref="UpdateUserDataEngineConfigResponse"/></returns>
        public Task<UpdateUserDataEngineConfigResponse> UpdateUserDataEngineConfig(UpdateUserDataEngineConfigRequest req)
        {
            return InternalRequestAsync<UpdateUserDataEngineConfigResponse>(req, "UpdateUserDataEngineConfig");
        }

        /// <summary>
        /// 修改用户引擎自定义配置
        /// </summary>
        /// <param name="req"><see cref="UpdateUserDataEngineConfigRequest"/></param>
        /// <returns><see cref="UpdateUserDataEngineConfigResponse"/></returns>
        public UpdateUserDataEngineConfigResponse UpdateUserDataEngineConfigSync(UpdateUserDataEngineConfigRequest req)
        {
            return InternalRequestAsync<UpdateUserDataEngineConfigResponse>(req, "UpdateUserDataEngineConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 升级引擎镜像
        /// </summary>
        /// <param name="req"><see cref="UpgradeDataEngineImageRequest"/></param>
        /// <returns><see cref="UpgradeDataEngineImageResponse"/></returns>
        public Task<UpgradeDataEngineImageResponse> UpgradeDataEngineImage(UpgradeDataEngineImageRequest req)
        {
            return InternalRequestAsync<UpgradeDataEngineImageResponse>(req, "UpgradeDataEngineImage");
        }

        /// <summary>
        /// 升级引擎镜像
        /// </summary>
        /// <param name="req"><see cref="UpgradeDataEngineImageRequest"/></param>
        /// <returns><see cref="UpgradeDataEngineImageResponse"/></returns>
        public UpgradeDataEngineImageResponse UpgradeDataEngineImageSync(UpgradeDataEngineImageRequest req)
        {
            return InternalRequestAsync<UpgradeDataEngineImageResponse>(req, "UpgradeDataEngineImage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}

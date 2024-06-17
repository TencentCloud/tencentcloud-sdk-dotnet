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
       private const string sdkVersion = "SDK_NET_3.0.1028";

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
        /// 按顺序创建任务（已经废弃，后期不再维护，请使用接口CreateTasks）
        /// </summary>
        /// <param name="req"><see cref="CreateTasksInOrderRequest"/></param>
        /// <returns><see cref="CreateTasksInOrderResponse"/></returns>
        public Task<CreateTasksInOrderResponse> CreateTasksInOrder(CreateTasksInOrderRequest req)
        {
            return InternalRequestAsync<CreateTasksInOrderResponse>(req, "CreateTasksInOrder");
        }

        /// <summary>
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
        /// 本接口（DescribeDataEngines）用于查询DataEngines信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDataEnginesRequest"/></param>
        /// <returns><see cref="DescribeDataEnginesResponse"/></returns>
        public Task<DescribeDataEnginesResponse> DescribeDataEngines(DescribeDataEnginesRequest req)
        {
            return InternalRequestAsync<DescribeDataEnginesResponse>(req, "DescribeDataEngines");
        }

        /// <summary>
        /// 本接口（DescribeDataEngines）用于查询DataEngines信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDataEnginesRequest"/></param>
        /// <returns><see cref="DescribeDataEnginesResponse"/></returns>
        public DescribeDataEnginesResponse DescribeDataEnginesSync(DescribeDataEnginesRequest req)
        {
            return InternalRequestAsync<DescribeDataEnginesResponse>(req, "DescribeDataEngines")
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
        /// 查询任务结果
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskResultRequest"/></param>
        /// <returns><see cref="DescribeTaskResultResponse"/></returns>
        public Task<DescribeTaskResultResponse> DescribeTaskResult(DescribeTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeTaskResultResponse>(req, "DescribeTaskResult");
        }

        /// <summary>
        /// 查询任务结果
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskResultRequest"/></param>
        /// <returns><see cref="DescribeTaskResultResponse"/></returns>
        public DescribeTaskResultResponse DescribeTaskResultSync(DescribeTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeTaskResultResponse>(req, "DescribeTaskResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口（DescribleTasks）用于查询任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public Task<DescribeTasksResponse> DescribeTasks(DescribeTasksRequest req)
        {
            return InternalRequestAsync<DescribeTasksResponse>(req, "DescribeTasks");
        }

        /// <summary>
        /// 该接口（DescribleTasks）用于查询任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public DescribeTasksResponse DescribeTasksSync(DescribeTasksRequest req)
        {
            return InternalRequestAsync<DescribeTasksResponse>(req, "DescribeTasks")
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

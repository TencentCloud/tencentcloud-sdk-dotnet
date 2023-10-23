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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DlcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// DMS元数据新增分区
        /// </summary>
        /// <param name="req"><see cref="AddDMSPartitionsRequest"/></param>
        /// <returns><see cref="AddDMSPartitionsResponse"/></returns>
        public async Task<AddDMSPartitionsResponse> AddDMSPartitions(AddDMSPartitionsRequest req)
        {
             JsonResponseModel<AddDMSPartitionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddDMSPartitions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddDMSPartitionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DMS元数据新增分区
        /// </summary>
        /// <param name="req"><see cref="AddDMSPartitionsRequest"/></param>
        /// <returns><see cref="AddDMSPartitionsResponse"/></returns>
        public AddDMSPartitionsResponse AddDMSPartitionsSync(AddDMSPartitionsRequest req)
        {
             JsonResponseModel<AddDMSPartitionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddDMSPartitions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddDMSPartitionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加用户到工作组
        /// </summary>
        /// <param name="req"><see cref="AddUsersToWorkGroupRequest"/></param>
        /// <returns><see cref="AddUsersToWorkGroupResponse"/></returns>
        public async Task<AddUsersToWorkGroupResponse> AddUsersToWorkGroup(AddUsersToWorkGroupRequest req)
        {
             JsonResponseModel<AddUsersToWorkGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddUsersToWorkGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddUsersToWorkGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加用户到工作组
        /// </summary>
        /// <param name="req"><see cref="AddUsersToWorkGroupRequest"/></param>
        /// <returns><see cref="AddUsersToWorkGroupResponse"/></returns>
        public AddUsersToWorkGroupResponse AddUsersToWorkGroupSync(AddUsersToWorkGroupRequest req)
        {
             JsonResponseModel<AddUsersToWorkGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddUsersToWorkGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddUsersToWorkGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DMS元数据更新库
        /// </summary>
        /// <param name="req"><see cref="AlterDMSDatabaseRequest"/></param>
        /// <returns><see cref="AlterDMSDatabaseResponse"/></returns>
        public async Task<AlterDMSDatabaseResponse> AlterDMSDatabase(AlterDMSDatabaseRequest req)
        {
             JsonResponseModel<AlterDMSDatabaseResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AlterDMSDatabase");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AlterDMSDatabaseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DMS元数据更新库
        /// </summary>
        /// <param name="req"><see cref="AlterDMSDatabaseRequest"/></param>
        /// <returns><see cref="AlterDMSDatabaseResponse"/></returns>
        public AlterDMSDatabaseResponse AlterDMSDatabaseSync(AlterDMSDatabaseRequest req)
        {
             JsonResponseModel<AlterDMSDatabaseResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AlterDMSDatabase");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AlterDMSDatabaseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DMS元数据更新分区
        /// </summary>
        /// <param name="req"><see cref="AlterDMSPartitionRequest"/></param>
        /// <returns><see cref="AlterDMSPartitionResponse"/></returns>
        public async Task<AlterDMSPartitionResponse> AlterDMSPartition(AlterDMSPartitionRequest req)
        {
             JsonResponseModel<AlterDMSPartitionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AlterDMSPartition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AlterDMSPartitionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DMS元数据更新分区
        /// </summary>
        /// <param name="req"><see cref="AlterDMSPartitionRequest"/></param>
        /// <returns><see cref="AlterDMSPartitionResponse"/></returns>
        public AlterDMSPartitionResponse AlterDMSPartitionSync(AlterDMSPartitionRequest req)
        {
             JsonResponseModel<AlterDMSPartitionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AlterDMSPartition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AlterDMSPartitionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DMS元数据更新表
        /// </summary>
        /// <param name="req"><see cref="AlterDMSTableRequest"/></param>
        /// <returns><see cref="AlterDMSTableResponse"/></returns>
        public async Task<AlterDMSTableResponse> AlterDMSTable(AlterDMSTableRequest req)
        {
             JsonResponseModel<AlterDMSTableResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AlterDMSTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AlterDMSTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DMS元数据更新表
        /// </summary>
        /// <param name="req"><see cref="AlterDMSTableRequest"/></param>
        /// <returns><see cref="AlterDMSTableResponse"/></returns>
        public AlterDMSTableResponse AlterDMSTableSync(AlterDMSTableRequest req)
        {
             JsonResponseModel<AlterDMSTableResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AlterDMSTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AlterDMSTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 绑定鉴权策略到用户
        /// </summary>
        /// <param name="req"><see cref="AttachUserPolicyRequest"/></param>
        /// <returns><see cref="AttachUserPolicyResponse"/></returns>
        public async Task<AttachUserPolicyResponse> AttachUserPolicy(AttachUserPolicyRequest req)
        {
             JsonResponseModel<AttachUserPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AttachUserPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachUserPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 绑定鉴权策略到用户
        /// </summary>
        /// <param name="req"><see cref="AttachUserPolicyRequest"/></param>
        /// <returns><see cref="AttachUserPolicyResponse"/></returns>
        public AttachUserPolicyResponse AttachUserPolicySync(AttachUserPolicyRequest req)
        {
             JsonResponseModel<AttachUserPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AttachUserPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachUserPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 绑定鉴权策略到工作组
        /// </summary>
        /// <param name="req"><see cref="AttachWorkGroupPolicyRequest"/></param>
        /// <returns><see cref="AttachWorkGroupPolicyResponse"/></returns>
        public async Task<AttachWorkGroupPolicyResponse> AttachWorkGroupPolicy(AttachWorkGroupPolicyRequest req)
        {
             JsonResponseModel<AttachWorkGroupPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AttachWorkGroupPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachWorkGroupPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 绑定鉴权策略到工作组
        /// </summary>
        /// <param name="req"><see cref="AttachWorkGroupPolicyRequest"/></param>
        /// <returns><see cref="AttachWorkGroupPolicyResponse"/></returns>
        public AttachWorkGroupPolicyResponse AttachWorkGroupPolicySync(AttachWorkGroupPolicyRequest req)
        {
             JsonResponseModel<AttachWorkGroupPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AttachWorkGroupPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachWorkGroupPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 绑定工作组到用户
        /// </summary>
        /// <param name="req"><see cref="BindWorkGroupsToUserRequest"/></param>
        /// <returns><see cref="BindWorkGroupsToUserResponse"/></returns>
        public async Task<BindWorkGroupsToUserResponse> BindWorkGroupsToUser(BindWorkGroupsToUserRequest req)
        {
             JsonResponseModel<BindWorkGroupsToUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindWorkGroupsToUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindWorkGroupsToUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 绑定工作组到用户
        /// </summary>
        /// <param name="req"><see cref="BindWorkGroupsToUserRequest"/></param>
        /// <returns><see cref="BindWorkGroupsToUserResponse"/></returns>
        public BindWorkGroupsToUserResponse BindWorkGroupsToUserSync(BindWorkGroupsToUserRequest req)
        {
             JsonResponseModel<BindWorkGroupsToUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindWorkGroupsToUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindWorkGroupsToUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CancelNotebookSessionStatement）用于取消session中执行的任务
        /// </summary>
        /// <param name="req"><see cref="CancelNotebookSessionStatementRequest"/></param>
        /// <returns><see cref="CancelNotebookSessionStatementResponse"/></returns>
        public async Task<CancelNotebookSessionStatementResponse> CancelNotebookSessionStatement(CancelNotebookSessionStatementRequest req)
        {
             JsonResponseModel<CancelNotebookSessionStatementResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CancelNotebookSessionStatement");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelNotebookSessionStatementResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CancelNotebookSessionStatement）用于取消session中执行的任务
        /// </summary>
        /// <param name="req"><see cref="CancelNotebookSessionStatementRequest"/></param>
        /// <returns><see cref="CancelNotebookSessionStatementResponse"/></returns>
        public CancelNotebookSessionStatementResponse CancelNotebookSessionStatementSync(CancelNotebookSessionStatementRequest req)
        {
             JsonResponseModel<CancelNotebookSessionStatementResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CancelNotebookSessionStatement");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelNotebookSessionStatementResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CancelNotebookSessionStatementBatch）用于批量取消Session 中执行的任务
        /// </summary>
        /// <param name="req"><see cref="CancelNotebookSessionStatementBatchRequest"/></param>
        /// <returns><see cref="CancelNotebookSessionStatementBatchResponse"/></returns>
        public async Task<CancelNotebookSessionStatementBatchResponse> CancelNotebookSessionStatementBatch(CancelNotebookSessionStatementBatchRequest req)
        {
             JsonResponseModel<CancelNotebookSessionStatementBatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CancelNotebookSessionStatementBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelNotebookSessionStatementBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CancelNotebookSessionStatementBatch）用于批量取消Session 中执行的任务
        /// </summary>
        /// <param name="req"><see cref="CancelNotebookSessionStatementBatchRequest"/></param>
        /// <returns><see cref="CancelNotebookSessionStatementBatchResponse"/></returns>
        public CancelNotebookSessionStatementBatchResponse CancelNotebookSessionStatementBatchSync(CancelNotebookSessionStatementBatchRequest req)
        {
             JsonResponseModel<CancelNotebookSessionStatementBatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CancelNotebookSessionStatementBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelNotebookSessionStatementBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CancelSparkSessionBatchSQL）用于取消Spark SQL批任务。
        /// </summary>
        /// <param name="req"><see cref="CancelSparkSessionBatchSQLRequest"/></param>
        /// <returns><see cref="CancelSparkSessionBatchSQLResponse"/></returns>
        public async Task<CancelSparkSessionBatchSQLResponse> CancelSparkSessionBatchSQL(CancelSparkSessionBatchSQLRequest req)
        {
             JsonResponseModel<CancelSparkSessionBatchSQLResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CancelSparkSessionBatchSQL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelSparkSessionBatchSQLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CancelSparkSessionBatchSQL）用于取消Spark SQL批任务。
        /// </summary>
        /// <param name="req"><see cref="CancelSparkSessionBatchSQLRequest"/></param>
        /// <returns><see cref="CancelSparkSessionBatchSQLResponse"/></returns>
        public CancelSparkSessionBatchSQLResponse CancelSparkSessionBatchSQLSync(CancelSparkSessionBatchSQLRequest req)
        {
             JsonResponseModel<CancelSparkSessionBatchSQLResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CancelSparkSessionBatchSQL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelSparkSessionBatchSQLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CancelTask），用于取消任务
        /// </summary>
        /// <param name="req"><see cref="CancelTaskRequest"/></param>
        /// <returns><see cref="CancelTaskResponse"/></returns>
        public async Task<CancelTaskResponse> CancelTask(CancelTaskRequest req)
        {
             JsonResponseModel<CancelTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CancelTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CancelTask），用于取消任务
        /// </summary>
        /// <param name="req"><see cref="CancelTaskRequest"/></param>
        /// <returns><see cref="CancelTaskResponse"/></returns>
        public CancelTaskResponse CancelTaskSync(CancelTaskRequest req)
        {
             JsonResponseModel<CancelTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CancelTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CheckDataEngineConfigPairsValidity）用于检查引擎用户自定义参数的有效性
        /// </summary>
        /// <param name="req"><see cref="CheckDataEngineConfigPairsValidityRequest"/></param>
        /// <returns><see cref="CheckDataEngineConfigPairsValidityResponse"/></returns>
        public async Task<CheckDataEngineConfigPairsValidityResponse> CheckDataEngineConfigPairsValidity(CheckDataEngineConfigPairsValidityRequest req)
        {
             JsonResponseModel<CheckDataEngineConfigPairsValidityResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckDataEngineConfigPairsValidity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckDataEngineConfigPairsValidityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CheckDataEngineConfigPairsValidity）用于检查引擎用户自定义参数的有效性
        /// </summary>
        /// <param name="req"><see cref="CheckDataEngineConfigPairsValidityRequest"/></param>
        /// <returns><see cref="CheckDataEngineConfigPairsValidityResponse"/></returns>
        public CheckDataEngineConfigPairsValidityResponse CheckDataEngineConfigPairsValiditySync(CheckDataEngineConfigPairsValidityRequest req)
        {
             JsonResponseModel<CheckDataEngineConfigPairsValidityResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckDataEngineConfigPairsValidity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckDataEngineConfigPairsValidityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CheckDataEngineImageCanBeRollback）用于查看集群是否能回滚。
        /// </summary>
        /// <param name="req"><see cref="CheckDataEngineImageCanBeRollbackRequest"/></param>
        /// <returns><see cref="CheckDataEngineImageCanBeRollbackResponse"/></returns>
        public async Task<CheckDataEngineImageCanBeRollbackResponse> CheckDataEngineImageCanBeRollback(CheckDataEngineImageCanBeRollbackRequest req)
        {
             JsonResponseModel<CheckDataEngineImageCanBeRollbackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckDataEngineImageCanBeRollback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckDataEngineImageCanBeRollbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CheckDataEngineImageCanBeRollback）用于查看集群是否能回滚。
        /// </summary>
        /// <param name="req"><see cref="CheckDataEngineImageCanBeRollbackRequest"/></param>
        /// <returns><see cref="CheckDataEngineImageCanBeRollbackResponse"/></returns>
        public CheckDataEngineImageCanBeRollbackResponse CheckDataEngineImageCanBeRollbackSync(CheckDataEngineImageCanBeRollbackRequest req)
        {
             JsonResponseModel<CheckDataEngineImageCanBeRollbackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckDataEngineImageCanBeRollback");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckDataEngineImageCanBeRollbackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CheckDataEngineImageCanBeUpgrade）用于查看集群镜像是否能够升级。
        /// </summary>
        /// <param name="req"><see cref="CheckDataEngineImageCanBeUpgradeRequest"/></param>
        /// <returns><see cref="CheckDataEngineImageCanBeUpgradeResponse"/></returns>
        public async Task<CheckDataEngineImageCanBeUpgradeResponse> CheckDataEngineImageCanBeUpgrade(CheckDataEngineImageCanBeUpgradeRequest req)
        {
             JsonResponseModel<CheckDataEngineImageCanBeUpgradeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckDataEngineImageCanBeUpgrade");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckDataEngineImageCanBeUpgradeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CheckDataEngineImageCanBeUpgrade）用于查看集群镜像是否能够升级。
        /// </summary>
        /// <param name="req"><see cref="CheckDataEngineImageCanBeUpgradeRequest"/></param>
        /// <returns><see cref="CheckDataEngineImageCanBeUpgradeResponse"/></returns>
        public CheckDataEngineImageCanBeUpgradeResponse CheckDataEngineImageCanBeUpgradeSync(CheckDataEngineImageCanBeUpgradeRequest req)
        {
             JsonResponseModel<CheckDataEngineImageCanBeUpgradeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckDataEngineImageCanBeUpgrade");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckDataEngineImageCanBeUpgradeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 元数据锁检查
        /// </summary>
        /// <param name="req"><see cref="CheckLockMetaDataRequest"/></param>
        /// <returns><see cref="CheckLockMetaDataResponse"/></returns>
        public async Task<CheckLockMetaDataResponse> CheckLockMetaData(CheckLockMetaDataRequest req)
        {
             JsonResponseModel<CheckLockMetaDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckLockMetaData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckLockMetaDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 元数据锁检查
        /// </summary>
        /// <param name="req"><see cref="CheckLockMetaDataRequest"/></param>
        /// <returns><see cref="CheckLockMetaDataResponse"/></returns>
        public CheckLockMetaDataResponse CheckLockMetaDataSync(CheckLockMetaDataRequest req)
        {
             JsonResponseModel<CheckLockMetaDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckLockMetaData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckLockMetaDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DMS元数据创建库
        /// </summary>
        /// <param name="req"><see cref="CreateDMSDatabaseRequest"/></param>
        /// <returns><see cref="CreateDMSDatabaseResponse"/></returns>
        public async Task<CreateDMSDatabaseResponse> CreateDMSDatabase(CreateDMSDatabaseRequest req)
        {
             JsonResponseModel<CreateDMSDatabaseResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDMSDatabase");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDMSDatabaseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DMS元数据创建库
        /// </summary>
        /// <param name="req"><see cref="CreateDMSDatabaseRequest"/></param>
        /// <returns><see cref="CreateDMSDatabaseResponse"/></returns>
        public CreateDMSDatabaseResponse CreateDMSDatabaseSync(CreateDMSDatabaseRequest req)
        {
             JsonResponseModel<CreateDMSDatabaseResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDMSDatabase");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDMSDatabaseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DMS元数据创建表
        /// </summary>
        /// <param name="req"><see cref="CreateDMSTableRequest"/></param>
        /// <returns><see cref="CreateDMSTableResponse"/></returns>
        public async Task<CreateDMSTableResponse> CreateDMSTable(CreateDMSTableRequest req)
        {
             JsonResponseModel<CreateDMSTableResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDMSTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDMSTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DMS元数据创建表
        /// </summary>
        /// <param name="req"><see cref="CreateDMSTableRequest"/></param>
        /// <returns><see cref="CreateDMSTableResponse"/></returns>
        public CreateDMSTableResponse CreateDMSTableSync(CreateDMSTableRequest req)
        {
             JsonResponseModel<CreateDMSTableResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDMSTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDMSTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 为用户创建数据引擎
        /// </summary>
        /// <param name="req"><see cref="CreateDataEngineRequest"/></param>
        /// <returns><see cref="CreateDataEngineResponse"/></returns>
        public async Task<CreateDataEngineResponse> CreateDataEngine(CreateDataEngineRequest req)
        {
             JsonResponseModel<CreateDataEngineResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDataEngine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDataEngineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 为用户创建数据引擎
        /// </summary>
        /// <param name="req"><see cref="CreateDataEngineRequest"/></param>
        /// <returns><see cref="CreateDataEngineResponse"/></returns>
        public CreateDataEngineResponse CreateDataEngineSync(CreateDataEngineRequest req)
        {
             JsonResponseModel<CreateDataEngineResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDataEngine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDataEngineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateDatabase）用于生成建库SQL语句。
        /// </summary>
        /// <param name="req"><see cref="CreateDatabaseRequest"/></param>
        /// <returns><see cref="CreateDatabaseResponse"/></returns>
        public async Task<CreateDatabaseResponse> CreateDatabase(CreateDatabaseRequest req)
        {
             JsonResponseModel<CreateDatabaseResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDatabase");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDatabaseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateDatabase）用于生成建库SQL语句。
        /// </summary>
        /// <param name="req"><see cref="CreateDatabaseRequest"/></param>
        /// <returns><see cref="CreateDatabaseResponse"/></returns>
        public CreateDatabaseResponse CreateDatabaseSync(CreateDatabaseRequest req)
        {
             JsonResponseModel<CreateDatabaseResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDatabase");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDatabaseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（CreateExportTask）用于创建导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateExportTaskRequest"/></param>
        /// <returns><see cref="CreateExportTaskResponse"/></returns>
        public async Task<CreateExportTaskResponse> CreateExportTask(CreateExportTaskRequest req)
        {
             JsonResponseModel<CreateExportTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateExportTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateExportTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（CreateExportTask）用于创建导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateExportTaskRequest"/></param>
        /// <returns><see cref="CreateExportTaskResponse"/></returns>
        public CreateExportTaskResponse CreateExportTaskSync(CreateExportTaskRequest req)
        {
             JsonResponseModel<CreateExportTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateExportTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateExportTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（CreateImportTask）用于创建导入任务
        /// </summary>
        /// <param name="req"><see cref="CreateImportTaskRequest"/></param>
        /// <returns><see cref="CreateImportTaskResponse"/></returns>
        public async Task<CreateImportTaskResponse> CreateImportTask(CreateImportTaskRequest req)
        {
             JsonResponseModel<CreateImportTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateImportTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateImportTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（CreateImportTask）用于创建导入任务
        /// </summary>
        /// <param name="req"><see cref="CreateImportTaskRequest"/></param>
        /// <returns><see cref="CreateImportTaskResponse"/></returns>
        public CreateImportTaskResponse CreateImportTaskSync(CreateImportTaskRequest req)
        {
             JsonResponseModel<CreateImportTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateImportTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateImportTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建托管存储内表（该接口已废弃）
        /// </summary>
        /// <param name="req"><see cref="CreateInternalTableRequest"/></param>
        /// <returns><see cref="CreateInternalTableResponse"/></returns>
        public async Task<CreateInternalTableResponse> CreateInternalTable(CreateInternalTableRequest req)
        {
             JsonResponseModel<CreateInternalTableResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateInternalTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInternalTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建托管存储内表（该接口已废弃）
        /// </summary>
        /// <param name="req"><see cref="CreateInternalTableRequest"/></param>
        /// <returns><see cref="CreateInternalTableResponse"/></returns>
        public CreateInternalTableResponse CreateInternalTableSync(CreateInternalTableRequest req)
        {
             JsonResponseModel<CreateInternalTableResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateInternalTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInternalTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateNotebookSession）用于创建交互式session（notebook）
        /// </summary>
        /// <param name="req"><see cref="CreateNotebookSessionRequest"/></param>
        /// <returns><see cref="CreateNotebookSessionResponse"/></returns>
        public async Task<CreateNotebookSessionResponse> CreateNotebookSession(CreateNotebookSessionRequest req)
        {
             JsonResponseModel<CreateNotebookSessionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNotebookSession");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNotebookSessionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateNotebookSession）用于创建交互式session（notebook）
        /// </summary>
        /// <param name="req"><see cref="CreateNotebookSessionRequest"/></param>
        /// <returns><see cref="CreateNotebookSessionResponse"/></returns>
        public CreateNotebookSessionResponse CreateNotebookSessionSync(CreateNotebookSessionRequest req)
        {
             JsonResponseModel<CreateNotebookSessionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateNotebookSession");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNotebookSessionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateNotebookSessionStatement）用于在session中执行代码片段
        /// </summary>
        /// <param name="req"><see cref="CreateNotebookSessionStatementRequest"/></param>
        /// <returns><see cref="CreateNotebookSessionStatementResponse"/></returns>
        public async Task<CreateNotebookSessionStatementResponse> CreateNotebookSessionStatement(CreateNotebookSessionStatementRequest req)
        {
             JsonResponseModel<CreateNotebookSessionStatementResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNotebookSessionStatement");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNotebookSessionStatementResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateNotebookSessionStatement）用于在session中执行代码片段
        /// </summary>
        /// <param name="req"><see cref="CreateNotebookSessionStatementRequest"/></param>
        /// <returns><see cref="CreateNotebookSessionStatementResponse"/></returns>
        public CreateNotebookSessionStatementResponse CreateNotebookSessionStatementSync(CreateNotebookSessionStatementRequest req)
        {
             JsonResponseModel<CreateNotebookSessionStatementResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateNotebookSessionStatement");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNotebookSessionStatementResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateNotebookSessionStatementSupportBatchSQL）用于创建交互式session并执行SQL任务
        /// </summary>
        /// <param name="req"><see cref="CreateNotebookSessionStatementSupportBatchSQLRequest"/></param>
        /// <returns><see cref="CreateNotebookSessionStatementSupportBatchSQLResponse"/></returns>
        public async Task<CreateNotebookSessionStatementSupportBatchSQLResponse> CreateNotebookSessionStatementSupportBatchSQL(CreateNotebookSessionStatementSupportBatchSQLRequest req)
        {
             JsonResponseModel<CreateNotebookSessionStatementSupportBatchSQLResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNotebookSessionStatementSupportBatchSQL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNotebookSessionStatementSupportBatchSQLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateNotebookSessionStatementSupportBatchSQL）用于创建交互式session并执行SQL任务
        /// </summary>
        /// <param name="req"><see cref="CreateNotebookSessionStatementSupportBatchSQLRequest"/></param>
        /// <returns><see cref="CreateNotebookSessionStatementSupportBatchSQLResponse"/></returns>
        public CreateNotebookSessionStatementSupportBatchSQLResponse CreateNotebookSessionStatementSupportBatchSQLSync(CreateNotebookSessionStatementSupportBatchSQLRequest req)
        {
             JsonResponseModel<CreateNotebookSessionStatementSupportBatchSQLResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateNotebookSessionStatementSupportBatchSQL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNotebookSessionStatementSupportBatchSQLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建查询结果下载任务
        /// </summary>
        /// <param name="req"><see cref="CreateResultDownloadRequest"/></param>
        /// <returns><see cref="CreateResultDownloadResponse"/></returns>
        public async Task<CreateResultDownloadResponse> CreateResultDownload(CreateResultDownloadRequest req)
        {
             JsonResponseModel<CreateResultDownloadResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateResultDownload");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateResultDownloadResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建查询结果下载任务
        /// </summary>
        /// <param name="req"><see cref="CreateResultDownloadRequest"/></param>
        /// <returns><see cref="CreateResultDownloadResponse"/></returns>
        public CreateResultDownloadResponse CreateResultDownloadSync(CreateResultDownloadRequest req)
        {
             JsonResponseModel<CreateResultDownloadResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateResultDownload");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateResultDownloadResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（CreateScript）用于创建sql脚本。
        /// </summary>
        /// <param name="req"><see cref="CreateScriptRequest"/></param>
        /// <returns><see cref="CreateScriptResponse"/></returns>
        public async Task<CreateScriptResponse> CreateScript(CreateScriptRequest req)
        {
             JsonResponseModel<CreateScriptResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateScript");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateScriptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（CreateScript）用于创建sql脚本。
        /// </summary>
        /// <param name="req"><see cref="CreateScriptRequest"/></param>
        /// <returns><see cref="CreateScriptResponse"/></returns>
        public CreateScriptResponse CreateScriptSync(CreateScriptRequest req)
        {
             JsonResponseModel<CreateScriptResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateScript");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateScriptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建spark作业
        /// </summary>
        /// <param name="req"><see cref="CreateSparkAppRequest"/></param>
        /// <returns><see cref="CreateSparkAppResponse"/></returns>
        public async Task<CreateSparkAppResponse> CreateSparkApp(CreateSparkAppRequest req)
        {
             JsonResponseModel<CreateSparkAppResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSparkApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSparkAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建spark作业
        /// </summary>
        /// <param name="req"><see cref="CreateSparkAppRequest"/></param>
        /// <returns><see cref="CreateSparkAppResponse"/></returns>
        public CreateSparkAppResponse CreateSparkAppSync(CreateSparkAppRequest req)
        {
             JsonResponseModel<CreateSparkAppResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSparkApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSparkAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启动Spark作业
        /// </summary>
        /// <param name="req"><see cref="CreateSparkAppTaskRequest"/></param>
        /// <returns><see cref="CreateSparkAppTaskResponse"/></returns>
        public async Task<CreateSparkAppTaskResponse> CreateSparkAppTask(CreateSparkAppTaskRequest req)
        {
             JsonResponseModel<CreateSparkAppTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSparkAppTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSparkAppTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启动Spark作业
        /// </summary>
        /// <param name="req"><see cref="CreateSparkAppTaskRequest"/></param>
        /// <returns><see cref="CreateSparkAppTaskResponse"/></returns>
        public CreateSparkAppTaskResponse CreateSparkAppTaskSync(CreateSparkAppTaskRequest req)
        {
             JsonResponseModel<CreateSparkAppTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSparkAppTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSparkAppTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateSparkSessionBatchSQL）用于向Spark作业引擎提交Spark SQL批任务。
        /// </summary>
        /// <param name="req"><see cref="CreateSparkSessionBatchSQLRequest"/></param>
        /// <returns><see cref="CreateSparkSessionBatchSQLResponse"/></returns>
        public async Task<CreateSparkSessionBatchSQLResponse> CreateSparkSessionBatchSQL(CreateSparkSessionBatchSQLRequest req)
        {
             JsonResponseModel<CreateSparkSessionBatchSQLResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSparkSessionBatchSQL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSparkSessionBatchSQLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateSparkSessionBatchSQL）用于向Spark作业引擎提交Spark SQL批任务。
        /// </summary>
        /// <param name="req"><see cref="CreateSparkSessionBatchSQLRequest"/></param>
        /// <returns><see cref="CreateSparkSessionBatchSQLResponse"/></returns>
        public CreateSparkSessionBatchSQLResponse CreateSparkSessionBatchSQLSync(CreateSparkSessionBatchSQLRequest req)
        {
             JsonResponseModel<CreateSparkSessionBatchSQLResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSparkSessionBatchSQL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSparkSessionBatchSQLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（CreateStoreLocation）新增或覆盖计算结果存储位置。
        /// </summary>
        /// <param name="req"><see cref="CreateStoreLocationRequest"/></param>
        /// <returns><see cref="CreateStoreLocationResponse"/></returns>
        public async Task<CreateStoreLocationResponse> CreateStoreLocation(CreateStoreLocationRequest req)
        {
             JsonResponseModel<CreateStoreLocationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateStoreLocation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateStoreLocationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（CreateStoreLocation）新增或覆盖计算结果存储位置。
        /// </summary>
        /// <param name="req"><see cref="CreateStoreLocationRequest"/></param>
        /// <returns><see cref="CreateStoreLocationResponse"/></returns>
        public CreateStoreLocationResponse CreateStoreLocationSync(CreateStoreLocationRequest req)
        {
             JsonResponseModel<CreateStoreLocationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateStoreLocation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateStoreLocationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateTable）用于生成建表SQL。
        /// </summary>
        /// <param name="req"><see cref="CreateTableRequest"/></param>
        /// <returns><see cref="CreateTableResponse"/></returns>
        public async Task<CreateTableResponse> CreateTable(CreateTableRequest req)
        {
             JsonResponseModel<CreateTableResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateTable）用于生成建表SQL。
        /// </summary>
        /// <param name="req"><see cref="CreateTableRequest"/></param>
        /// <returns><see cref="CreateTableResponse"/></returns>
        public CreateTableResponse CreateTableSync(CreateTableRequest req)
        {
             JsonResponseModel<CreateTableResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateTask）用于创建并执行SQL任务。（推荐使用CreateTasks接口）
        /// </summary>
        /// <param name="req"><see cref="CreateTaskRequest"/></param>
        /// <returns><see cref="CreateTaskResponse"/></returns>
        public async Task<CreateTaskResponse> CreateTask(CreateTaskRequest req)
        {
             JsonResponseModel<CreateTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateTask）用于创建并执行SQL任务。（推荐使用CreateTasks接口）
        /// </summary>
        /// <param name="req"><see cref="CreateTaskRequest"/></param>
        /// <returns><see cref="CreateTaskResponse"/></returns>
        public CreateTaskResponse CreateTaskSync(CreateTaskRequest req)
        {
             JsonResponseModel<CreateTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateTasks），用于批量创建并执行SQL任务
        /// </summary>
        /// <param name="req"><see cref="CreateTasksRequest"/></param>
        /// <returns><see cref="CreateTasksResponse"/></returns>
        public async Task<CreateTasksResponse> CreateTasks(CreateTasksRequest req)
        {
             JsonResponseModel<CreateTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateTasks），用于批量创建并执行SQL任务
        /// </summary>
        /// <param name="req"><see cref="CreateTasksRequest"/></param>
        /// <returns><see cref="CreateTasksResponse"/></returns>
        public CreateTasksResponse CreateTasksSync(CreateTasksRequest req)
        {
             JsonResponseModel<CreateTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按顺序创建任务（已经废弃，后期不再维护，请使用接口CreateTasks）
        /// </summary>
        /// <param name="req"><see cref="CreateTasksInOrderRequest"/></param>
        /// <returns><see cref="CreateTasksInOrderResponse"/></returns>
        public async Task<CreateTasksInOrderResponse> CreateTasksInOrder(CreateTasksInOrderRequest req)
        {
             JsonResponseModel<CreateTasksInOrderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTasksInOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTasksInOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按顺序创建任务（已经废弃，后期不再维护，请使用接口CreateTasks）
        /// </summary>
        /// <param name="req"><see cref="CreateTasksInOrderRequest"/></param>
        /// <returns><see cref="CreateTasksInOrderResponse"/></returns>
        public CreateTasksInOrderResponse CreateTasksInOrderSync(CreateTasksInOrderRequest req)
        {
             JsonResponseModel<CreateTasksInOrderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTasksInOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTasksInOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户
        /// </summary>
        /// <param name="req"><see cref="CreateUserRequest"/></param>
        /// <returns><see cref="CreateUserResponse"/></returns>
        public async Task<CreateUserResponse> CreateUser(CreateUserRequest req)
        {
             JsonResponseModel<CreateUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户
        /// </summary>
        /// <param name="req"><see cref="CreateUserRequest"/></param>
        /// <returns><see cref="CreateUserResponse"/></returns>
        public CreateUserResponse CreateUserSync(CreateUserRequest req)
        {
             JsonResponseModel<CreateUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建工作组
        /// </summary>
        /// <param name="req"><see cref="CreateWorkGroupRequest"/></param>
        /// <returns><see cref="CreateWorkGroupResponse"/></returns>
        public async Task<CreateWorkGroupResponse> CreateWorkGroup(CreateWorkGroupRequest req)
        {
             JsonResponseModel<CreateWorkGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateWorkGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWorkGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建工作组
        /// </summary>
        /// <param name="req"><see cref="CreateWorkGroupRequest"/></param>
        /// <returns><see cref="CreateWorkGroupResponse"/></returns>
        public CreateWorkGroupResponse CreateWorkGroupSync(CreateWorkGroupRequest req)
        {
             JsonResponseModel<CreateWorkGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateWorkGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWorkGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除数据引擎
        /// </summary>
        /// <param name="req"><see cref="DeleteDataEngineRequest"/></param>
        /// <returns><see cref="DeleteDataEngineResponse"/></returns>
        public async Task<DeleteDataEngineResponse> DeleteDataEngine(DeleteDataEngineRequest req)
        {
             JsonResponseModel<DeleteDataEngineResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDataEngine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDataEngineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除数据引擎
        /// </summary>
        /// <param name="req"><see cref="DeleteDataEngineRequest"/></param>
        /// <returns><see cref="DeleteDataEngineResponse"/></returns>
        public DeleteDataEngineResponse DeleteDataEngineSync(DeleteDataEngineRequest req)
        {
             JsonResponseModel<DeleteDataEngineResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDataEngine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDataEngineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteNotebookSession）用于删除交互式session（notebook）
        /// </summary>
        /// <param name="req"><see cref="DeleteNotebookSessionRequest"/></param>
        /// <returns><see cref="DeleteNotebookSessionResponse"/></returns>
        public async Task<DeleteNotebookSessionResponse> DeleteNotebookSession(DeleteNotebookSessionRequest req)
        {
             JsonResponseModel<DeleteNotebookSessionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteNotebookSession");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNotebookSessionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteNotebookSession）用于删除交互式session（notebook）
        /// </summary>
        /// <param name="req"><see cref="DeleteNotebookSessionRequest"/></param>
        /// <returns><see cref="DeleteNotebookSessionResponse"/></returns>
        public DeleteNotebookSessionResponse DeleteNotebookSessionSync(DeleteNotebookSessionRequest req)
        {
             JsonResponseModel<DeleteNotebookSessionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteNotebookSession");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNotebookSessionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（DeleteScript）用于删除sql脚本。
        /// </summary>
        /// <param name="req"><see cref="DeleteScriptRequest"/></param>
        /// <returns><see cref="DeleteScriptResponse"/></returns>
        public async Task<DeleteScriptResponse> DeleteScript(DeleteScriptRequest req)
        {
             JsonResponseModel<DeleteScriptResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteScript");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteScriptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（DeleteScript）用于删除sql脚本。
        /// </summary>
        /// <param name="req"><see cref="DeleteScriptRequest"/></param>
        /// <returns><see cref="DeleteScriptResponse"/></returns>
        public DeleteScriptResponse DeleteScriptSync(DeleteScriptRequest req)
        {
             JsonResponseModel<DeleteScriptResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteScript");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteScriptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除spark作业
        /// </summary>
        /// <param name="req"><see cref="DeleteSparkAppRequest"/></param>
        /// <returns><see cref="DeleteSparkAppResponse"/></returns>
        public async Task<DeleteSparkAppResponse> DeleteSparkApp(DeleteSparkAppRequest req)
        {
             JsonResponseModel<DeleteSparkAppResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSparkApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSparkAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除spark作业
        /// </summary>
        /// <param name="req"><see cref="DeleteSparkAppRequest"/></param>
        /// <returns><see cref="DeleteSparkAppResponse"/></returns>
        public DeleteSparkAppResponse DeleteSparkAppSync(DeleteSparkAppRequest req)
        {
             JsonResponseModel<DeleteSparkAppResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSparkApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSparkAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRequest"/></param>
        /// <returns><see cref="DeleteUserResponse"/></returns>
        public async Task<DeleteUserResponse> DeleteUser(DeleteUserRequest req)
        {
             JsonResponseModel<DeleteUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="req"><see cref="DeleteUserRequest"/></param>
        /// <returns><see cref="DeleteUserResponse"/></returns>
        public DeleteUserResponse DeleteUserSync(DeleteUserRequest req)
        {
             JsonResponseModel<DeleteUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 从工作组中删除用户
        /// </summary>
        /// <param name="req"><see cref="DeleteUsersFromWorkGroupRequest"/></param>
        /// <returns><see cref="DeleteUsersFromWorkGroupResponse"/></returns>
        public async Task<DeleteUsersFromWorkGroupResponse> DeleteUsersFromWorkGroup(DeleteUsersFromWorkGroupRequest req)
        {
             JsonResponseModel<DeleteUsersFromWorkGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteUsersFromWorkGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUsersFromWorkGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 从工作组中删除用户
        /// </summary>
        /// <param name="req"><see cref="DeleteUsersFromWorkGroupRequest"/></param>
        /// <returns><see cref="DeleteUsersFromWorkGroupResponse"/></returns>
        public DeleteUsersFromWorkGroupResponse DeleteUsersFromWorkGroupSync(DeleteUsersFromWorkGroupRequest req)
        {
             JsonResponseModel<DeleteUsersFromWorkGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteUsersFromWorkGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUsersFromWorkGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除工作组
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkGroupRequest"/></param>
        /// <returns><see cref="DeleteWorkGroupResponse"/></returns>
        public async Task<DeleteWorkGroupResponse> DeleteWorkGroup(DeleteWorkGroupRequest req)
        {
             JsonResponseModel<DeleteWorkGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteWorkGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWorkGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除工作组
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkGroupRequest"/></param>
        /// <returns><see cref="DeleteWorkGroupResponse"/></returns>
        public DeleteWorkGroupResponse DeleteWorkGroupSync(DeleteWorkGroupRequest req)
        {
             JsonResponseModel<DeleteWorkGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteWorkGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWorkGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询sql查询界面高级设置
        /// </summary>
        /// <param name="req"><see cref="DescribeAdvancedStoreLocationRequest"/></param>
        /// <returns><see cref="DescribeAdvancedStoreLocationResponse"/></returns>
        public async Task<DescribeAdvancedStoreLocationResponse> DescribeAdvancedStoreLocation(DescribeAdvancedStoreLocationRequest req)
        {
             JsonResponseModel<DescribeAdvancedStoreLocationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAdvancedStoreLocation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAdvancedStoreLocationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询sql查询界面高级设置
        /// </summary>
        /// <param name="req"><see cref="DescribeAdvancedStoreLocationRequest"/></param>
        /// <returns><see cref="DescribeAdvancedStoreLocationResponse"/></returns>
        public DescribeAdvancedStoreLocationResponse DescribeAdvancedStoreLocationSync(DescribeAdvancedStoreLocationRequest req)
        {
             JsonResponseModel<DescribeAdvancedStoreLocationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAdvancedStoreLocation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAdvancedStoreLocationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DMS元数据获取库
        /// </summary>
        /// <param name="req"><see cref="DescribeDMSDatabaseRequest"/></param>
        /// <returns><see cref="DescribeDMSDatabaseResponse"/></returns>
        public async Task<DescribeDMSDatabaseResponse> DescribeDMSDatabase(DescribeDMSDatabaseRequest req)
        {
             JsonResponseModel<DescribeDMSDatabaseResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDMSDatabase");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDMSDatabaseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DMS元数据获取库
        /// </summary>
        /// <param name="req"><see cref="DescribeDMSDatabaseRequest"/></param>
        /// <returns><see cref="DescribeDMSDatabaseResponse"/></returns>
        public DescribeDMSDatabaseResponse DescribeDMSDatabaseSync(DescribeDMSDatabaseRequest req)
        {
             JsonResponseModel<DescribeDMSDatabaseResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDMSDatabase");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDMSDatabaseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DMS元数据获取分区
        /// </summary>
        /// <param name="req"><see cref="DescribeDMSPartitionsRequest"/></param>
        /// <returns><see cref="DescribeDMSPartitionsResponse"/></returns>
        public async Task<DescribeDMSPartitionsResponse> DescribeDMSPartitions(DescribeDMSPartitionsRequest req)
        {
             JsonResponseModel<DescribeDMSPartitionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDMSPartitions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDMSPartitionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DMS元数据获取分区
        /// </summary>
        /// <param name="req"><see cref="DescribeDMSPartitionsRequest"/></param>
        /// <returns><see cref="DescribeDMSPartitionsResponse"/></returns>
        public DescribeDMSPartitionsResponse DescribeDMSPartitionsSync(DescribeDMSPartitionsRequest req)
        {
             JsonResponseModel<DescribeDMSPartitionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDMSPartitions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDMSPartitionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DMS元数据获取表
        /// </summary>
        /// <param name="req"><see cref="DescribeDMSTableRequest"/></param>
        /// <returns><see cref="DescribeDMSTableResponse"/></returns>
        public async Task<DescribeDMSTableResponse> DescribeDMSTable(DescribeDMSTableRequest req)
        {
             JsonResponseModel<DescribeDMSTableResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDMSTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDMSTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DMS元数据获取表
        /// </summary>
        /// <param name="req"><see cref="DescribeDMSTableRequest"/></param>
        /// <returns><see cref="DescribeDMSTableResponse"/></returns>
        public DescribeDMSTableResponse DescribeDMSTableSync(DescribeDMSTableRequest req)
        {
             JsonResponseModel<DescribeDMSTableResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDMSTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDMSTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DMS元数据获取表列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDMSTablesRequest"/></param>
        /// <returns><see cref="DescribeDMSTablesResponse"/></returns>
        public async Task<DescribeDMSTablesResponse> DescribeDMSTables(DescribeDMSTablesRequest req)
        {
             JsonResponseModel<DescribeDMSTablesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDMSTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDMSTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DMS元数据获取表列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDMSTablesRequest"/></param>
        /// <returns><see cref="DescribeDMSTablesResponse"/></returns>
        public DescribeDMSTablesResponse DescribeDMSTablesSync(DescribeDMSTablesRequest req)
        {
             JsonResponseModel<DescribeDMSTablesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDMSTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDMSTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口根据名称用于获取数据引擎详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataEngineRequest"/></param>
        /// <returns><see cref="DescribeDataEngineResponse"/></returns>
        public async Task<DescribeDataEngineResponse> DescribeDataEngine(DescribeDataEngineRequest req)
        {
             JsonResponseModel<DescribeDataEngineResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDataEngine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataEngineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口根据名称用于获取数据引擎详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataEngineRequest"/></param>
        /// <returns><see cref="DescribeDataEngineResponse"/></returns>
        public DescribeDataEngineResponse DescribeDataEngineSync(DescribeDataEngineRequest req)
        {
             JsonResponseModel<DescribeDataEngineResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDataEngine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataEngineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDataEngineImageVersions）用于获取独享集群大版本镜像列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDataEngineImageVersionsRequest"/></param>
        /// <returns><see cref="DescribeDataEngineImageVersionsResponse"/></returns>
        public async Task<DescribeDataEngineImageVersionsResponse> DescribeDataEngineImageVersions(DescribeDataEngineImageVersionsRequest req)
        {
             JsonResponseModel<DescribeDataEngineImageVersionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDataEngineImageVersions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataEngineImageVersionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDataEngineImageVersions）用于获取独享集群大版本镜像列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDataEngineImageVersionsRequest"/></param>
        /// <returns><see cref="DescribeDataEngineImageVersionsResponse"/></returns>
        public DescribeDataEngineImageVersionsResponse DescribeDataEngineImageVersionsSync(DescribeDataEngineImageVersionsRequest req)
        {
             JsonResponseModel<DescribeDataEngineImageVersionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDataEngineImageVersions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataEngineImageVersionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDataEnginePythonSparkImages）用于获取PYSPARK镜像列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDataEnginePythonSparkImagesRequest"/></param>
        /// <returns><see cref="DescribeDataEnginePythonSparkImagesResponse"/></returns>
        public async Task<DescribeDataEnginePythonSparkImagesResponse> DescribeDataEnginePythonSparkImages(DescribeDataEnginePythonSparkImagesRequest req)
        {
             JsonResponseModel<DescribeDataEnginePythonSparkImagesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDataEnginePythonSparkImages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataEnginePythonSparkImagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDataEnginePythonSparkImages）用于获取PYSPARK镜像列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDataEnginePythonSparkImagesRequest"/></param>
        /// <returns><see cref="DescribeDataEnginePythonSparkImagesResponse"/></returns>
        public DescribeDataEnginePythonSparkImagesResponse DescribeDataEnginePythonSparkImagesSync(DescribeDataEnginePythonSparkImagesRequest req)
        {
             JsonResponseModel<DescribeDataEnginePythonSparkImagesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDataEnginePythonSparkImages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataEnginePythonSparkImagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDataEngines）用于查询DataEngines信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDataEnginesRequest"/></param>
        /// <returns><see cref="DescribeDataEnginesResponse"/></returns>
        public async Task<DescribeDataEnginesResponse> DescribeDataEngines(DescribeDataEnginesRequest req)
        {
             JsonResponseModel<DescribeDataEnginesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDataEngines");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataEnginesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDataEngines）用于查询DataEngines信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDataEnginesRequest"/></param>
        /// <returns><see cref="DescribeDataEnginesResponse"/></returns>
        public DescribeDataEnginesResponse DescribeDataEnginesSync(DescribeDataEnginesRequest req)
        {
             JsonResponseModel<DescribeDataEnginesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDataEngines");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataEnginesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDatabases）用于查询数据库列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabasesRequest"/></param>
        /// <returns><see cref="DescribeDatabasesResponse"/></returns>
        public async Task<DescribeDatabasesResponse> DescribeDatabases(DescribeDatabasesRequest req)
        {
             JsonResponseModel<DescribeDatabasesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDatabases");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatabasesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDatabases）用于查询数据库列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabasesRequest"/></param>
        /// <returns><see cref="DescribeDatabasesResponse"/></returns>
        public DescribeDatabasesResponse DescribeDatabasesSync(DescribeDatabasesRequest req)
        {
             JsonResponseModel<DescribeDatabasesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDatabases");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatabasesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDatasourceConnection）用于查询数据源信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDatasourceConnectionRequest"/></param>
        /// <returns><see cref="DescribeDatasourceConnectionResponse"/></returns>
        public async Task<DescribeDatasourceConnectionResponse> DescribeDatasourceConnection(DescribeDatasourceConnectionRequest req)
        {
             JsonResponseModel<DescribeDatasourceConnectionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDatasourceConnection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatasourceConnectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDatasourceConnection）用于查询数据源信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDatasourceConnectionRequest"/></param>
        /// <returns><see cref="DescribeDatasourceConnectionResponse"/></returns>
        public DescribeDatasourceConnectionResponse DescribeDatasourceConnectionSync(DescribeDatasourceConnectionRequest req)
        {
             JsonResponseModel<DescribeDatasourceConnectionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDatasourceConnection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatasourceConnectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口根据引擎ID查询数据引擎资源使用情况
        /// </summary>
        /// <param name="req"><see cref="DescribeEngineUsageInfoRequest"/></param>
        /// <returns><see cref="DescribeEngineUsageInfoResponse"/></returns>
        public async Task<DescribeEngineUsageInfoResponse> DescribeEngineUsageInfo(DescribeEngineUsageInfoRequest req)
        {
             JsonResponseModel<DescribeEngineUsageInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEngineUsageInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEngineUsageInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口根据引擎ID查询数据引擎资源使用情况
        /// </summary>
        /// <param name="req"><see cref="DescribeEngineUsageInfoRequest"/></param>
        /// <returns><see cref="DescribeEngineUsageInfoResponse"/></returns>
        public DescribeEngineUsageInfoResponse DescribeEngineUsageInfoSync(DescribeEngineUsageInfoRequest req)
        {
             JsonResponseModel<DescribeEngineUsageInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEngineUsageInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEngineUsageInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeForbiddenTablePro）用于查询被禁用的表属性列表（新）
        /// </summary>
        /// <param name="req"><see cref="DescribeForbiddenTableProRequest"/></param>
        /// <returns><see cref="DescribeForbiddenTableProResponse"/></returns>
        public async Task<DescribeForbiddenTableProResponse> DescribeForbiddenTablePro(DescribeForbiddenTableProRequest req)
        {
             JsonResponseModel<DescribeForbiddenTableProResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeForbiddenTablePro");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeForbiddenTableProResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeForbiddenTablePro）用于查询被禁用的表属性列表（新）
        /// </summary>
        /// <param name="req"><see cref="DescribeForbiddenTableProRequest"/></param>
        /// <returns><see cref="DescribeForbiddenTableProResponse"/></returns>
        public DescribeForbiddenTableProResponse DescribeForbiddenTableProSync(DescribeForbiddenTableProRequest req)
        {
             JsonResponseModel<DescribeForbiddenTableProResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeForbiddenTablePro");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeForbiddenTableProResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询托管存储指定目录的Summary
        /// </summary>
        /// <param name="req"><see cref="DescribeLakeFsDirSummaryRequest"/></param>
        /// <returns><see cref="DescribeLakeFsDirSummaryResponse"/></returns>
        public async Task<DescribeLakeFsDirSummaryResponse> DescribeLakeFsDirSummary(DescribeLakeFsDirSummaryRequest req)
        {
             JsonResponseModel<DescribeLakeFsDirSummaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLakeFsDirSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLakeFsDirSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询托管存储指定目录的Summary
        /// </summary>
        /// <param name="req"><see cref="DescribeLakeFsDirSummaryRequest"/></param>
        /// <returns><see cref="DescribeLakeFsDirSummaryResponse"/></returns>
        public DescribeLakeFsDirSummaryResponse DescribeLakeFsDirSummarySync(DescribeLakeFsDirSummaryRequest req)
        {
             JsonResponseModel<DescribeLakeFsDirSummaryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLakeFsDirSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLakeFsDirSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户的托管存储信息
        /// </summary>
        /// <param name="req"><see cref="DescribeLakeFsInfoRequest"/></param>
        /// <returns><see cref="DescribeLakeFsInfoResponse"/></returns>
        public async Task<DescribeLakeFsInfoResponse> DescribeLakeFsInfo(DescribeLakeFsInfoRequest req)
        {
             JsonResponseModel<DescribeLakeFsInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLakeFsInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLakeFsInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户的托管存储信息
        /// </summary>
        /// <param name="req"><see cref="DescribeLakeFsInfoRequest"/></param>
        /// <returns><see cref="DescribeLakeFsInfoResponse"/></returns>
        public DescribeLakeFsInfoResponse DescribeLakeFsInfoSync(DescribeLakeFsInfoRequest req)
        {
             JsonResponseModel<DescribeLakeFsInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLakeFsInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLakeFsInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取LakeFs上task执行结果访问信息
        /// </summary>
        /// <param name="req"><see cref="DescribeLakeFsTaskResultRequest"/></param>
        /// <returns><see cref="DescribeLakeFsTaskResultResponse"/></returns>
        public async Task<DescribeLakeFsTaskResultResponse> DescribeLakeFsTaskResult(DescribeLakeFsTaskResultRequest req)
        {
             JsonResponseModel<DescribeLakeFsTaskResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLakeFsTaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLakeFsTaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取LakeFs上task执行结果访问信息
        /// </summary>
        /// <param name="req"><see cref="DescribeLakeFsTaskResultRequest"/></param>
        /// <returns><see cref="DescribeLakeFsTaskResultResponse"/></returns>
        public DescribeLakeFsTaskResultResponse DescribeLakeFsTaskResultSync(DescribeLakeFsTaskResultRequest req)
        {
             JsonResponseModel<DescribeLakeFsTaskResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLakeFsTaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLakeFsTaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeNotebookSession）用于查询交互式 session详情信息
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookSessionRequest"/></param>
        /// <returns><see cref="DescribeNotebookSessionResponse"/></returns>
        public async Task<DescribeNotebookSessionResponse> DescribeNotebookSession(DescribeNotebookSessionRequest req)
        {
             JsonResponseModel<DescribeNotebookSessionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNotebookSession");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNotebookSessionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeNotebookSession）用于查询交互式 session详情信息
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookSessionRequest"/></param>
        /// <returns><see cref="DescribeNotebookSessionResponse"/></returns>
        public DescribeNotebookSessionResponse DescribeNotebookSessionSync(DescribeNotebookSessionRequest req)
        {
             JsonResponseModel<DescribeNotebookSessionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNotebookSession");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNotebookSessionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeNotebookSessionLog）用于查询交互式 session日志
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookSessionLogRequest"/></param>
        /// <returns><see cref="DescribeNotebookSessionLogResponse"/></returns>
        public async Task<DescribeNotebookSessionLogResponse> DescribeNotebookSessionLog(DescribeNotebookSessionLogRequest req)
        {
             JsonResponseModel<DescribeNotebookSessionLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNotebookSessionLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNotebookSessionLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeNotebookSessionLog）用于查询交互式 session日志
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookSessionLogRequest"/></param>
        /// <returns><see cref="DescribeNotebookSessionLogResponse"/></returns>
        public DescribeNotebookSessionLogResponse DescribeNotebookSessionLogSync(DescribeNotebookSessionLogRequest req)
        {
             JsonResponseModel<DescribeNotebookSessionLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNotebookSessionLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNotebookSessionLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeNotebookSessionStatement）用于查询session 中执行任务的详情
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookSessionStatementRequest"/></param>
        /// <returns><see cref="DescribeNotebookSessionStatementResponse"/></returns>
        public async Task<DescribeNotebookSessionStatementResponse> DescribeNotebookSessionStatement(DescribeNotebookSessionStatementRequest req)
        {
             JsonResponseModel<DescribeNotebookSessionStatementResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNotebookSessionStatement");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNotebookSessionStatementResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeNotebookSessionStatement）用于查询session 中执行任务的详情
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookSessionStatementRequest"/></param>
        /// <returns><see cref="DescribeNotebookSessionStatementResponse"/></returns>
        public DescribeNotebookSessionStatementResponse DescribeNotebookSessionStatementSync(DescribeNotebookSessionStatementRequest req)
        {
             JsonResponseModel<DescribeNotebookSessionStatementResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNotebookSessionStatement");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNotebookSessionStatementResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeNotebookSessionStatementSqlResult）用于获取statement运行结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookSessionStatementSqlResultRequest"/></param>
        /// <returns><see cref="DescribeNotebookSessionStatementSqlResultResponse"/></returns>
        public async Task<DescribeNotebookSessionStatementSqlResultResponse> DescribeNotebookSessionStatementSqlResult(DescribeNotebookSessionStatementSqlResultRequest req)
        {
             JsonResponseModel<DescribeNotebookSessionStatementSqlResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNotebookSessionStatementSqlResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNotebookSessionStatementSqlResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeNotebookSessionStatementSqlResult）用于获取statement运行结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookSessionStatementSqlResultRequest"/></param>
        /// <returns><see cref="DescribeNotebookSessionStatementSqlResultResponse"/></returns>
        public DescribeNotebookSessionStatementSqlResultResponse DescribeNotebookSessionStatementSqlResultSync(DescribeNotebookSessionStatementSqlResultRequest req)
        {
             JsonResponseModel<DescribeNotebookSessionStatementSqlResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNotebookSessionStatementSqlResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNotebookSessionStatementSqlResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeNotebookSessionStatements）用于查询Session中执行的任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookSessionStatementsRequest"/></param>
        /// <returns><see cref="DescribeNotebookSessionStatementsResponse"/></returns>
        public async Task<DescribeNotebookSessionStatementsResponse> DescribeNotebookSessionStatements(DescribeNotebookSessionStatementsRequest req)
        {
             JsonResponseModel<DescribeNotebookSessionStatementsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNotebookSessionStatements");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNotebookSessionStatementsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeNotebookSessionStatements）用于查询Session中执行的任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookSessionStatementsRequest"/></param>
        /// <returns><see cref="DescribeNotebookSessionStatementsResponse"/></returns>
        public DescribeNotebookSessionStatementsResponse DescribeNotebookSessionStatementsSync(DescribeNotebookSessionStatementsRequest req)
        {
             JsonResponseModel<DescribeNotebookSessionStatementsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNotebookSessionStatements");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNotebookSessionStatementsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeNotebookSessions）用于查询交互式 session列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookSessionsRequest"/></param>
        /// <returns><see cref="DescribeNotebookSessionsResponse"/></returns>
        public async Task<DescribeNotebookSessionsResponse> DescribeNotebookSessions(DescribeNotebookSessionsRequest req)
        {
             JsonResponseModel<DescribeNotebookSessionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNotebookSessions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNotebookSessionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeNotebookSessions）用于查询交互式 session列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNotebookSessionsRequest"/></param>
        /// <returns><see cref="DescribeNotebookSessionsResponse"/></returns>
        public DescribeNotebookSessionsResponse DescribeNotebookSessionsSync(DescribeNotebookSessionsRequest req)
        {
             JsonResponseModel<DescribeNotebookSessionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNotebookSessions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNotebookSessionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询结果下载任务
        /// </summary>
        /// <param name="req"><see cref="DescribeResultDownloadRequest"/></param>
        /// <returns><see cref="DescribeResultDownloadResponse"/></returns>
        public async Task<DescribeResultDownloadResponse> DescribeResultDownload(DescribeResultDownloadRequest req)
        {
             JsonResponseModel<DescribeResultDownloadResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeResultDownload");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResultDownloadResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询结果下载任务
        /// </summary>
        /// <param name="req"><see cref="DescribeResultDownloadRequest"/></param>
        /// <returns><see cref="DescribeResultDownloadResponse"/></returns>
        public DescribeResultDownloadResponse DescribeResultDownloadSync(DescribeResultDownloadRequest req)
        {
             JsonResponseModel<DescribeResultDownloadResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeResultDownload");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResultDownloadResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（DescribeScripts）用于查询SQL脚本列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScriptsRequest"/></param>
        /// <returns><see cref="DescribeScriptsResponse"/></returns>
        public async Task<DescribeScriptsResponse> DescribeScripts(DescribeScriptsRequest req)
        {
             JsonResponseModel<DescribeScriptsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScripts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScriptsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（DescribeScripts）用于查询SQL脚本列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScriptsRequest"/></param>
        /// <returns><see cref="DescribeScriptsResponse"/></returns>
        public DescribeScriptsResponse DescribeScriptsSync(DescribeScriptsRequest req)
        {
             JsonResponseModel<DescribeScriptsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScripts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScriptsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询spark作业信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkAppJobRequest"/></param>
        /// <returns><see cref="DescribeSparkAppJobResponse"/></returns>
        public async Task<DescribeSparkAppJobResponse> DescribeSparkAppJob(DescribeSparkAppJobRequest req)
        {
             JsonResponseModel<DescribeSparkAppJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSparkAppJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSparkAppJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询spark作业信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkAppJobRequest"/></param>
        /// <returns><see cref="DescribeSparkAppJobResponse"/></returns>
        public DescribeSparkAppJobResponse DescribeSparkAppJobSync(DescribeSparkAppJobRequest req)
        {
             JsonResponseModel<DescribeSparkAppJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSparkAppJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSparkAppJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询spark作业列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkAppJobsRequest"/></param>
        /// <returns><see cref="DescribeSparkAppJobsResponse"/></returns>
        public async Task<DescribeSparkAppJobsResponse> DescribeSparkAppJobs(DescribeSparkAppJobsRequest req)
        {
             JsonResponseModel<DescribeSparkAppJobsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSparkAppJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSparkAppJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询spark作业列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkAppJobsRequest"/></param>
        /// <returns><see cref="DescribeSparkAppJobsResponse"/></returns>
        public DescribeSparkAppJobsResponse DescribeSparkAppJobsSync(DescribeSparkAppJobsRequest req)
        {
             JsonResponseModel<DescribeSparkAppJobsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSparkAppJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSparkAppJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询Spark作业的运行任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkAppTasksRequest"/></param>
        /// <returns><see cref="DescribeSparkAppTasksResponse"/></returns>
        public async Task<DescribeSparkAppTasksResponse> DescribeSparkAppTasks(DescribeSparkAppTasksRequest req)
        {
             JsonResponseModel<DescribeSparkAppTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSparkAppTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSparkAppTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询Spark作业的运行任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkAppTasksRequest"/></param>
        /// <returns><see cref="DescribeSparkAppTasksResponse"/></returns>
        public DescribeSparkAppTasksResponse DescribeSparkAppTasksSync(DescribeSparkAppTasksRequest req)
        {
             JsonResponseModel<DescribeSparkAppTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSparkAppTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSparkAppTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeSparkSessionBatchSQL）用于查询Spark SQL批任务运行状态
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkSessionBatchSQLRequest"/></param>
        /// <returns><see cref="DescribeSparkSessionBatchSQLResponse"/></returns>
        public async Task<DescribeSparkSessionBatchSQLResponse> DescribeSparkSessionBatchSQL(DescribeSparkSessionBatchSQLRequest req)
        {
             JsonResponseModel<DescribeSparkSessionBatchSQLResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSparkSessionBatchSQL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSparkSessionBatchSQLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeSparkSessionBatchSQL）用于查询Spark SQL批任务运行状态
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkSessionBatchSQLRequest"/></param>
        /// <returns><see cref="DescribeSparkSessionBatchSQLResponse"/></returns>
        public DescribeSparkSessionBatchSQLResponse DescribeSparkSessionBatchSQLSync(DescribeSparkSessionBatchSQLRequest req)
        {
             JsonResponseModel<DescribeSparkSessionBatchSQLResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSparkSessionBatchSQL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSparkSessionBatchSQLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeSparkSessionBatchSqlLog）用于查询Spark SQL批任务日志
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkSessionBatchSqlLogRequest"/></param>
        /// <returns><see cref="DescribeSparkSessionBatchSqlLogResponse"/></returns>
        public async Task<DescribeSparkSessionBatchSqlLogResponse> DescribeSparkSessionBatchSqlLog(DescribeSparkSessionBatchSqlLogRequest req)
        {
             JsonResponseModel<DescribeSparkSessionBatchSqlLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSparkSessionBatchSqlLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSparkSessionBatchSqlLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeSparkSessionBatchSqlLog）用于查询Spark SQL批任务日志
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkSessionBatchSqlLogRequest"/></param>
        /// <returns><see cref="DescribeSparkSessionBatchSqlLogResponse"/></returns>
        public DescribeSparkSessionBatchSqlLogResponse DescribeSparkSessionBatchSqlLogSync(DescribeSparkSessionBatchSqlLogRequest req)
        {
             JsonResponseModel<DescribeSparkSessionBatchSqlLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSparkSessionBatchSqlLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSparkSessionBatchSqlLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询计算结果存储位置。
        /// </summary>
        /// <param name="req"><see cref="DescribeStoreLocationRequest"/></param>
        /// <returns><see cref="DescribeStoreLocationResponse"/></returns>
        public async Task<DescribeStoreLocationResponse> DescribeStoreLocation(DescribeStoreLocationRequest req)
        {
             JsonResponseModel<DescribeStoreLocationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStoreLocation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStoreLocationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询计算结果存储位置。
        /// </summary>
        /// <param name="req"><see cref="DescribeStoreLocationRequest"/></param>
        /// <returns><see cref="DescribeStoreLocationResponse"/></returns>
        public DescribeStoreLocationResponse DescribeStoreLocationSync(DescribeStoreLocationRequest req)
        {
             JsonResponseModel<DescribeStoreLocationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStoreLocation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStoreLocationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeTable），用于查询单个表的详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeTableRequest"/></param>
        /// <returns><see cref="DescribeTableResponse"/></returns>
        public async Task<DescribeTableResponse> DescribeTable(DescribeTableRequest req)
        {
             JsonResponseModel<DescribeTableResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeTable），用于查询单个表的详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeTableRequest"/></param>
        /// <returns><see cref="DescribeTableResponse"/></returns>
        public DescribeTableResponse DescribeTableSync(DescribeTableRequest req)
        {
             JsonResponseModel<DescribeTableResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeTables）用于查询数据表列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeTablesRequest"/></param>
        /// <returns><see cref="DescribeTablesResponse"/></returns>
        public async Task<DescribeTablesResponse> DescribeTables(DescribeTablesRequest req)
        {
             JsonResponseModel<DescribeTablesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeTables）用于查询数据表列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeTablesRequest"/></param>
        /// <returns><see cref="DescribeTablesResponse"/></returns>
        public DescribeTablesResponse DescribeTablesSync(DescribeTablesRequest req)
        {
             JsonResponseModel<DescribeTablesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询任务结果
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskResultRequest"/></param>
        /// <returns><see cref="DescribeTaskResultResponse"/></returns>
        public async Task<DescribeTaskResultResponse> DescribeTaskResult(DescribeTaskResultRequest req)
        {
             JsonResponseModel<DescribeTaskResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询任务结果
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskResultRequest"/></param>
        /// <returns><see cref="DescribeTaskResultResponse"/></returns>
        public DescribeTaskResultResponse DescribeTaskResultSync(DescribeTaskResultRequest req)
        {
             JsonResponseModel<DescribeTaskResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（DescribleTasks）用于查询任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public async Task<DescribeTasksResponse> DescribeTasks(DescribeTasksRequest req)
        {
             JsonResponseModel<DescribeTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口（DescribleTasks）用于查询任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public DescribeTasksResponse DescribeTasksSync(DescribeTasksRequest req)
        {
             JsonResponseModel<DescribeTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户自定义引擎参数
        /// </summary>
        /// <param name="req"><see cref="DescribeUserDataEngineConfigRequest"/></param>
        /// <returns><see cref="DescribeUserDataEngineConfigResponse"/></returns>
        public async Task<DescribeUserDataEngineConfigResponse> DescribeUserDataEngineConfig(DescribeUserDataEngineConfigRequest req)
        {
             JsonResponseModel<DescribeUserDataEngineConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserDataEngineConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserDataEngineConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户自定义引擎参数
        /// </summary>
        /// <param name="req"><see cref="DescribeUserDataEngineConfigRequest"/></param>
        /// <returns><see cref="DescribeUserDataEngineConfigResponse"/></returns>
        public DescribeUserDataEngineConfigResponse DescribeUserDataEngineConfigSync(DescribeUserDataEngineConfigRequest req)
        {
             JsonResponseModel<DescribeUserDataEngineConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserDataEngineConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserDataEngineConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserInfoRequest"/></param>
        /// <returns><see cref="DescribeUserInfoResponse"/></returns>
        public async Task<DescribeUserInfoResponse> DescribeUserInfo(DescribeUserInfoRequest req)
        {
             JsonResponseModel<DescribeUserInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserInfoRequest"/></param>
        /// <returns><see cref="DescribeUserInfoResponse"/></returns>
        public DescribeUserInfoResponse DescribeUserInfoSync(DescribeUserInfoRequest req)
        {
             JsonResponseModel<DescribeUserInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 列举用户角色信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRolesRequest"/></param>
        /// <returns><see cref="DescribeUserRolesResponse"/></returns>
        public async Task<DescribeUserRolesResponse> DescribeUserRoles(DescribeUserRolesRequest req)
        {
             JsonResponseModel<DescribeUserRolesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserRoles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserRolesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 列举用户角色信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRolesRequest"/></param>
        /// <returns><see cref="DescribeUserRolesResponse"/></returns>
        public DescribeUserRolesResponse DescribeUserRolesSync(DescribeUserRolesRequest req)
        {
             JsonResponseModel<DescribeUserRolesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserRoles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserRolesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户类型
        /// </summary>
        /// <param name="req"><see cref="DescribeUserTypeRequest"/></param>
        /// <returns><see cref="DescribeUserTypeResponse"/></returns>
        public async Task<DescribeUserTypeResponse> DescribeUserType(DescribeUserTypeRequest req)
        {
             JsonResponseModel<DescribeUserTypeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户类型
        /// </summary>
        /// <param name="req"><see cref="DescribeUserTypeRequest"/></param>
        /// <returns><see cref="DescribeUserTypeResponse"/></returns>
        public DescribeUserTypeResponse DescribeUserTypeSync(DescribeUserTypeRequest req)
        {
             JsonResponseModel<DescribeUserTypeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUsersRequest"/></param>
        /// <returns><see cref="DescribeUsersResponse"/></returns>
        public async Task<DescribeUsersResponse> DescribeUsers(DescribeUsersRequest req)
        {
             JsonResponseModel<DescribeUsersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUsers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUsersRequest"/></param>
        /// <returns><see cref="DescribeUsersResponse"/></returns>
        public DescribeUsersResponse DescribeUsersSync(DescribeUsersRequest req)
        {
             JsonResponseModel<DescribeUsersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUsers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeViews）用于查询数据视图列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeViewsRequest"/></param>
        /// <returns><see cref="DescribeViewsResponse"/></returns>
        public async Task<DescribeViewsResponse> DescribeViews(DescribeViewsRequest req)
        {
             JsonResponseModel<DescribeViewsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeViews");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeViewsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeViews）用于查询数据视图列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeViewsRequest"/></param>
        /// <returns><see cref="DescribeViewsResponse"/></returns>
        public DescribeViewsResponse DescribeViewsSync(DescribeViewsRequest req)
        {
             JsonResponseModel<DescribeViewsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeViews");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeViewsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取工作组详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkGroupInfoRequest"/></param>
        /// <returns><see cref="DescribeWorkGroupInfoResponse"/></returns>
        public async Task<DescribeWorkGroupInfoResponse> DescribeWorkGroupInfo(DescribeWorkGroupInfoRequest req)
        {
             JsonResponseModel<DescribeWorkGroupInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWorkGroupInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWorkGroupInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取工作组详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkGroupInfoRequest"/></param>
        /// <returns><see cref="DescribeWorkGroupInfoResponse"/></returns>
        public DescribeWorkGroupInfoResponse DescribeWorkGroupInfoSync(DescribeWorkGroupInfoRequest req)
        {
             JsonResponseModel<DescribeWorkGroupInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWorkGroupInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWorkGroupInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取工作组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkGroupsRequest"/></param>
        /// <returns><see cref="DescribeWorkGroupsResponse"/></returns>
        public async Task<DescribeWorkGroupsResponse> DescribeWorkGroups(DescribeWorkGroupsRequest req)
        {
             JsonResponseModel<DescribeWorkGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWorkGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWorkGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取工作组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkGroupsRequest"/></param>
        /// <returns><see cref="DescribeWorkGroupsResponse"/></returns>
        public DescribeWorkGroupsResponse DescribeWorkGroupsSync(DescribeWorkGroupsRequest req)
        {
             JsonResponseModel<DescribeWorkGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWorkGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWorkGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解绑用户鉴权策略
        /// </summary>
        /// <param name="req"><see cref="DetachUserPolicyRequest"/></param>
        /// <returns><see cref="DetachUserPolicyResponse"/></returns>
        public async Task<DetachUserPolicyResponse> DetachUserPolicy(DetachUserPolicyRequest req)
        {
             JsonResponseModel<DetachUserPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetachUserPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachUserPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解绑用户鉴权策略
        /// </summary>
        /// <param name="req"><see cref="DetachUserPolicyRequest"/></param>
        /// <returns><see cref="DetachUserPolicyResponse"/></returns>
        public DetachUserPolicyResponse DetachUserPolicySync(DetachUserPolicyRequest req)
        {
             JsonResponseModel<DetachUserPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetachUserPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachUserPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解绑工作组鉴权策略
        /// </summary>
        /// <param name="req"><see cref="DetachWorkGroupPolicyRequest"/></param>
        /// <returns><see cref="DetachWorkGroupPolicyResponse"/></returns>
        public async Task<DetachWorkGroupPolicyResponse> DetachWorkGroupPolicy(DetachWorkGroupPolicyRequest req)
        {
             JsonResponseModel<DetachWorkGroupPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetachWorkGroupPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachWorkGroupPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解绑工作组鉴权策略
        /// </summary>
        /// <param name="req"><see cref="DetachWorkGroupPolicyRequest"/></param>
        /// <returns><see cref="DetachWorkGroupPolicyResponse"/></returns>
        public DetachWorkGroupPolicyResponse DetachWorkGroupPolicySync(DetachWorkGroupPolicyRequest req)
        {
             JsonResponseModel<DetachWorkGroupPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetachWorkGroupPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachWorkGroupPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DMS元数据删除库
        /// </summary>
        /// <param name="req"><see cref="DropDMSDatabaseRequest"/></param>
        /// <returns><see cref="DropDMSDatabaseResponse"/></returns>
        public async Task<DropDMSDatabaseResponse> DropDMSDatabase(DropDMSDatabaseRequest req)
        {
             JsonResponseModel<DropDMSDatabaseResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DropDMSDatabase");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DropDMSDatabaseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DMS元数据删除库
        /// </summary>
        /// <param name="req"><see cref="DropDMSDatabaseRequest"/></param>
        /// <returns><see cref="DropDMSDatabaseResponse"/></returns>
        public DropDMSDatabaseResponse DropDMSDatabaseSync(DropDMSDatabaseRequest req)
        {
             JsonResponseModel<DropDMSDatabaseResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DropDMSDatabase");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DropDMSDatabaseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DMS元数据删除分区
        /// </summary>
        /// <param name="req"><see cref="DropDMSPartitionsRequest"/></param>
        /// <returns><see cref="DropDMSPartitionsResponse"/></returns>
        public async Task<DropDMSPartitionsResponse> DropDMSPartitions(DropDMSPartitionsRequest req)
        {
             JsonResponseModel<DropDMSPartitionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DropDMSPartitions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DropDMSPartitionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DMS元数据删除分区
        /// </summary>
        /// <param name="req"><see cref="DropDMSPartitionsRequest"/></param>
        /// <returns><see cref="DropDMSPartitionsResponse"/></returns>
        public DropDMSPartitionsResponse DropDMSPartitionsSync(DropDMSPartitionsRequest req)
        {
             JsonResponseModel<DropDMSPartitionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DropDMSPartitions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DropDMSPartitionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DMS元数据删除表
        /// </summary>
        /// <param name="req"><see cref="DropDMSTableRequest"/></param>
        /// <returns><see cref="DropDMSTableResponse"/></returns>
        public async Task<DropDMSTableResponse> DropDMSTable(DropDMSTableRequest req)
        {
             JsonResponseModel<DropDMSTableResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DropDMSTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DropDMSTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DMS元数据删除表
        /// </summary>
        /// <param name="req"><see cref="DropDMSTableRequest"/></param>
        /// <returns><see cref="DropDMSTableResponse"/></returns>
        public DropDMSTableResponse DropDMSTableSync(DropDMSTableRequest req)
        {
             JsonResponseModel<DropDMSTableResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DropDMSTable");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DropDMSTableResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 生成创建托管表语句
        /// </summary>
        /// <param name="req"><see cref="GenerateCreateMangedTableSqlRequest"/></param>
        /// <returns><see cref="GenerateCreateMangedTableSqlResponse"/></returns>
        public async Task<GenerateCreateMangedTableSqlResponse> GenerateCreateMangedTableSql(GenerateCreateMangedTableSqlRequest req)
        {
             JsonResponseModel<GenerateCreateMangedTableSqlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GenerateCreateMangedTableSql");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GenerateCreateMangedTableSqlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 生成创建托管表语句
        /// </summary>
        /// <param name="req"><see cref="GenerateCreateMangedTableSqlRequest"/></param>
        /// <returns><see cref="GenerateCreateMangedTableSqlResponse"/></returns>
        public GenerateCreateMangedTableSqlResponse GenerateCreateMangedTableSqlSync(GenerateCreateMangedTableSqlRequest req)
        {
             JsonResponseModel<GenerateCreateMangedTableSqlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GenerateCreateMangedTableSql");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GenerateCreateMangedTableSqlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// GetOptimizerPolicy
        /// </summary>
        /// <param name="req"><see cref="GetOptimizerPolicyRequest"/></param>
        /// <returns><see cref="GetOptimizerPolicyResponse"/></returns>
        public async Task<GetOptimizerPolicyResponse> GetOptimizerPolicy(GetOptimizerPolicyRequest req)
        {
             JsonResponseModel<GetOptimizerPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetOptimizerPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetOptimizerPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// GetOptimizerPolicy
        /// </summary>
        /// <param name="req"><see cref="GetOptimizerPolicyRequest"/></param>
        /// <returns><see cref="GetOptimizerPolicyResponse"/></returns>
        public GetOptimizerPolicyResponse GetOptimizerPolicySync(GetOptimizerPolicyRequest req)
        {
             JsonResponseModel<GetOptimizerPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetOptimizerPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetOptimizerPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ListTaskJobLogDetail）用于获取spark 作业任务日志详情
        /// </summary>
        /// <param name="req"><see cref="ListTaskJobLogDetailRequest"/></param>
        /// <returns><see cref="ListTaskJobLogDetailResponse"/></returns>
        public async Task<ListTaskJobLogDetailResponse> ListTaskJobLogDetail(ListTaskJobLogDetailRequest req)
        {
             JsonResponseModel<ListTaskJobLogDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListTaskJobLogDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListTaskJobLogDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ListTaskJobLogDetail）用于获取spark 作业任务日志详情
        /// </summary>
        /// <param name="req"><see cref="ListTaskJobLogDetailRequest"/></param>
        /// <returns><see cref="ListTaskJobLogDetailResponse"/></returns>
        public ListTaskJobLogDetailResponse ListTaskJobLogDetailSync(ListTaskJobLogDetailRequest req)
        {
             JsonResponseModel<ListTaskJobLogDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListTaskJobLogDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListTaskJobLogDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 元数据锁
        /// </summary>
        /// <param name="req"><see cref="LockMetaDataRequest"/></param>
        /// <returns><see cref="LockMetaDataResponse"/></returns>
        public async Task<LockMetaDataResponse> LockMetaData(LockMetaDataRequest req)
        {
             JsonResponseModel<LockMetaDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "LockMetaData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LockMetaDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 元数据锁
        /// </summary>
        /// <param name="req"><see cref="LockMetaDataRequest"/></param>
        /// <returns><see cref="LockMetaDataResponse"/></returns>
        public LockMetaDataResponse LockMetaDataSync(LockMetaDataRequest req)
        {
             JsonResponseModel<LockMetaDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "LockMetaData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LockMetaDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改sql查询界面高级设置。
        /// </summary>
        /// <param name="req"><see cref="ModifyAdvancedStoreLocationRequest"/></param>
        /// <returns><see cref="ModifyAdvancedStoreLocationResponse"/></returns>
        public async Task<ModifyAdvancedStoreLocationResponse> ModifyAdvancedStoreLocation(ModifyAdvancedStoreLocationRequest req)
        {
             JsonResponseModel<ModifyAdvancedStoreLocationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAdvancedStoreLocation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAdvancedStoreLocationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改sql查询界面高级设置。
        /// </summary>
        /// <param name="req"><see cref="ModifyAdvancedStoreLocationRequest"/></param>
        /// <returns><see cref="ModifyAdvancedStoreLocationResponse"/></returns>
        public ModifyAdvancedStoreLocationResponse ModifyAdvancedStoreLocationSync(ModifyAdvancedStoreLocationRequest req)
        {
             JsonResponseModel<ModifyAdvancedStoreLocationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAdvancedStoreLocation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAdvancedStoreLocationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改引擎描述信息
        /// </summary>
        /// <param name="req"><see cref="ModifyDataEngineDescriptionRequest"/></param>
        /// <returns><see cref="ModifyDataEngineDescriptionResponse"/></returns>
        public async Task<ModifyDataEngineDescriptionResponse> ModifyDataEngineDescription(ModifyDataEngineDescriptionRequest req)
        {
             JsonResponseModel<ModifyDataEngineDescriptionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDataEngineDescription");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDataEngineDescriptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改引擎描述信息
        /// </summary>
        /// <param name="req"><see cref="ModifyDataEngineDescriptionRequest"/></param>
        /// <returns><see cref="ModifyDataEngineDescriptionResponse"/></returns>
        public ModifyDataEngineDescriptionResponse ModifyDataEngineDescriptionSync(ModifyDataEngineDescriptionRequest req)
        {
             JsonResponseModel<ModifyDataEngineDescriptionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDataEngineDescription");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDataEngineDescriptionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改数据治理事件阈值
        /// </summary>
        /// <param name="req"><see cref="ModifyGovernEventRuleRequest"/></param>
        /// <returns><see cref="ModifyGovernEventRuleResponse"/></returns>
        public async Task<ModifyGovernEventRuleResponse> ModifyGovernEventRule(ModifyGovernEventRuleRequest req)
        {
             JsonResponseModel<ModifyGovernEventRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyGovernEventRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyGovernEventRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改数据治理事件阈值
        /// </summary>
        /// <param name="req"><see cref="ModifyGovernEventRuleRequest"/></param>
        /// <returns><see cref="ModifyGovernEventRuleResponse"/></returns>
        public ModifyGovernEventRuleResponse ModifyGovernEventRuleSync(ModifyGovernEventRuleRequest req)
        {
             JsonResponseModel<ModifyGovernEventRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyGovernEventRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyGovernEventRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新spark作业
        /// </summary>
        /// <param name="req"><see cref="ModifySparkAppRequest"/></param>
        /// <returns><see cref="ModifySparkAppResponse"/></returns>
        public async Task<ModifySparkAppResponse> ModifySparkApp(ModifySparkAppRequest req)
        {
             JsonResponseModel<ModifySparkAppResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySparkApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySparkAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新spark作业
        /// </summary>
        /// <param name="req"><see cref="ModifySparkAppRequest"/></param>
        /// <returns><see cref="ModifySparkAppResponse"/></returns>
        public ModifySparkAppResponse ModifySparkAppSync(ModifySparkAppRequest req)
        {
             JsonResponseModel<ModifySparkAppResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySparkApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySparkAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifySparkAppBatch）用于批量修改Spark作业参数配置
        /// </summary>
        /// <param name="req"><see cref="ModifySparkAppBatchRequest"/></param>
        /// <returns><see cref="ModifySparkAppBatchResponse"/></returns>
        public async Task<ModifySparkAppBatchResponse> ModifySparkAppBatch(ModifySparkAppBatchRequest req)
        {
             JsonResponseModel<ModifySparkAppBatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySparkAppBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySparkAppBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ModifySparkAppBatch）用于批量修改Spark作业参数配置
        /// </summary>
        /// <param name="req"><see cref="ModifySparkAppBatchRequest"/></param>
        /// <returns><see cref="ModifySparkAppBatchResponse"/></returns>
        public ModifySparkAppBatchResponse ModifySparkAppBatchSync(ModifySparkAppBatchRequest req)
        {
             JsonResponseModel<ModifySparkAppBatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySparkAppBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySparkAppBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="req"><see cref="ModifyUserRequest"/></param>
        /// <returns><see cref="ModifyUserResponse"/></returns>
        public async Task<ModifyUserResponse> ModifyUser(ModifyUserRequest req)
        {
             JsonResponseModel<ModifyUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="req"><see cref="ModifyUserRequest"/></param>
        /// <returns><see cref="ModifyUserResponse"/></returns>
        public ModifyUserResponse ModifyUserSync(ModifyUserRequest req)
        {
             JsonResponseModel<ModifyUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户类型。只有管理员用户能够调用该接口进行操作
        /// </summary>
        /// <param name="req"><see cref="ModifyUserTypeRequest"/></param>
        /// <returns><see cref="ModifyUserTypeResponse"/></returns>
        public async Task<ModifyUserTypeResponse> ModifyUserType(ModifyUserTypeRequest req)
        {
             JsonResponseModel<ModifyUserTypeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyUserType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUserTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户类型。只有管理员用户能够调用该接口进行操作
        /// </summary>
        /// <param name="req"><see cref="ModifyUserTypeRequest"/></param>
        /// <returns><see cref="ModifyUserTypeResponse"/></returns>
        public ModifyUserTypeResponse ModifyUserTypeSync(ModifyUserTypeRequest req)
        {
             JsonResponseModel<ModifyUserTypeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyUserType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUserTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改工作组信息
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkGroupRequest"/></param>
        /// <returns><see cref="ModifyWorkGroupResponse"/></returns>
        public async Task<ModifyWorkGroupResponse> ModifyWorkGroup(ModifyWorkGroupRequest req)
        {
             JsonResponseModel<ModifyWorkGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyWorkGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWorkGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改工作组信息
        /// </summary>
        /// <param name="req"><see cref="ModifyWorkGroupRequest"/></param>
        /// <returns><see cref="ModifyWorkGroupResponse"/></returns>
        public ModifyWorkGroupResponse ModifyWorkGroupSync(ModifyWorkGroupRequest req)
        {
             JsonResponseModel<ModifyWorkGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyWorkGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWorkGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取任务结果查询
        /// </summary>
        /// <param name="req"><see cref="QueryResultRequest"/></param>
        /// <returns><see cref="QueryResultResponse"/></returns>
        public async Task<QueryResultResponse> QueryResult(QueryResultRequest req)
        {
             JsonResponseModel<QueryResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取任务结果查询
        /// </summary>
        /// <param name="req"><see cref="QueryResultRequest"/></param>
        /// <returns><see cref="QueryResultResponse"/></returns>
        public QueryResultResponse QueryResultSync(QueryResultRequest req)
        {
             JsonResponseModel<QueryResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 续费数据引擎
        /// </summary>
        /// <param name="req"><see cref="RenewDataEngineRequest"/></param>
        /// <returns><see cref="RenewDataEngineResponse"/></returns>
        public async Task<RenewDataEngineResponse> RenewDataEngine(RenewDataEngineRequest req)
        {
             JsonResponseModel<RenewDataEngineResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RenewDataEngine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewDataEngineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 续费数据引擎
        /// </summary>
        /// <param name="req"><see cref="RenewDataEngineRequest"/></param>
        /// <returns><see cref="RenewDataEngineResponse"/></returns>
        public RenewDataEngineResponse RenewDataEngineSync(RenewDataEngineRequest req)
        {
             JsonResponseModel<RenewDataEngineResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RenewDataEngine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewDataEngineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上报元数据心跳
        /// </summary>
        /// <param name="req"><see cref="ReportHeartbeatMetaDataRequest"/></param>
        /// <returns><see cref="ReportHeartbeatMetaDataResponse"/></returns>
        public async Task<ReportHeartbeatMetaDataResponse> ReportHeartbeatMetaData(ReportHeartbeatMetaDataRequest req)
        {
             JsonResponseModel<ReportHeartbeatMetaDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReportHeartbeatMetaData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReportHeartbeatMetaDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上报元数据心跳
        /// </summary>
        /// <param name="req"><see cref="ReportHeartbeatMetaDataRequest"/></param>
        /// <returns><see cref="ReportHeartbeatMetaDataResponse"/></returns>
        public ReportHeartbeatMetaDataResponse ReportHeartbeatMetaDataSync(ReportHeartbeatMetaDataRequest req)
        {
             JsonResponseModel<ReportHeartbeatMetaDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReportHeartbeatMetaData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReportHeartbeatMetaDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重启引擎
        /// </summary>
        /// <param name="req"><see cref="RestartDataEngineRequest"/></param>
        /// <returns><see cref="RestartDataEngineResponse"/></returns>
        public async Task<RestartDataEngineResponse> RestartDataEngine(RestartDataEngineRequest req)
        {
             JsonResponseModel<RestartDataEngineResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RestartDataEngine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestartDataEngineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重启引擎
        /// </summary>
        /// <param name="req"><see cref="RestartDataEngineRequest"/></param>
        /// <returns><see cref="RestartDataEngineResponse"/></returns>
        public RestartDataEngineResponse RestartDataEngineSync(RestartDataEngineRequest req)
        {
             JsonResponseModel<RestartDataEngineResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RestartDataEngine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestartDataEngineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 回滚引擎镜像版本
        /// </summary>
        /// <param name="req"><see cref="RollbackDataEngineImageRequest"/></param>
        /// <returns><see cref="RollbackDataEngineImageResponse"/></returns>
        public async Task<RollbackDataEngineImageResponse> RollbackDataEngineImage(RollbackDataEngineImageRequest req)
        {
             JsonResponseModel<RollbackDataEngineImageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RollbackDataEngineImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RollbackDataEngineImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 回滚引擎镜像版本
        /// </summary>
        /// <param name="req"><see cref="RollbackDataEngineImageRequest"/></param>
        /// <returns><see cref="RollbackDataEngineImageResponse"/></returns>
        public RollbackDataEngineImageResponse RollbackDataEngineImageSync(RollbackDataEngineImageRequest req)
        {
             JsonResponseModel<RollbackDataEngineImageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RollbackDataEngineImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RollbackDataEngineImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于控制挂起或启动数据引擎
        /// </summary>
        /// <param name="req"><see cref="SuspendResumeDataEngineRequest"/></param>
        /// <returns><see cref="SuspendResumeDataEngineResponse"/></returns>
        public async Task<SuspendResumeDataEngineResponse> SuspendResumeDataEngine(SuspendResumeDataEngineRequest req)
        {
             JsonResponseModel<SuspendResumeDataEngineResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SuspendResumeDataEngine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SuspendResumeDataEngineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于控制挂起或启动数据引擎
        /// </summary>
        /// <param name="req"><see cref="SuspendResumeDataEngineRequest"/></param>
        /// <returns><see cref="SuspendResumeDataEngineResponse"/></returns>
        public SuspendResumeDataEngineResponse SuspendResumeDataEngineSync(SuspendResumeDataEngineRequest req)
        {
             JsonResponseModel<SuspendResumeDataEngineResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SuspendResumeDataEngine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SuspendResumeDataEngineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 切换主备集群
        /// </summary>
        /// <param name="req"><see cref="SwitchDataEngineRequest"/></param>
        /// <returns><see cref="SwitchDataEngineResponse"/></returns>
        public async Task<SwitchDataEngineResponse> SwitchDataEngine(SwitchDataEngineRequest req)
        {
             JsonResponseModel<SwitchDataEngineResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SwitchDataEngine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchDataEngineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 切换主备集群
        /// </summary>
        /// <param name="req"><see cref="SwitchDataEngineRequest"/></param>
        /// <returns><see cref="SwitchDataEngineResponse"/></returns>
        public SwitchDataEngineResponse SwitchDataEngineSync(SwitchDataEngineRequest req)
        {
             JsonResponseModel<SwitchDataEngineResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SwitchDataEngine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchDataEngineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 切换引擎镜像版本
        /// </summary>
        /// <param name="req"><see cref="SwitchDataEngineImageRequest"/></param>
        /// <returns><see cref="SwitchDataEngineImageResponse"/></returns>
        public async Task<SwitchDataEngineImageResponse> SwitchDataEngineImage(SwitchDataEngineImageRequest req)
        {
             JsonResponseModel<SwitchDataEngineImageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SwitchDataEngineImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchDataEngineImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 切换引擎镜像版本
        /// </summary>
        /// <param name="req"><see cref="SwitchDataEngineImageRequest"/></param>
        /// <returns><see cref="SwitchDataEngineImageResponse"/></returns>
        public SwitchDataEngineImageResponse SwitchDataEngineImageSync(SwitchDataEngineImageRequest req)
        {
             JsonResponseModel<SwitchDataEngineImageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SwitchDataEngineImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchDataEngineImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解绑用户上的用户组
        /// </summary>
        /// <param name="req"><see cref="UnbindWorkGroupsFromUserRequest"/></param>
        /// <returns><see cref="UnbindWorkGroupsFromUserResponse"/></returns>
        public async Task<UnbindWorkGroupsFromUserResponse> UnbindWorkGroupsFromUser(UnbindWorkGroupsFromUserRequest req)
        {
             JsonResponseModel<UnbindWorkGroupsFromUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnbindWorkGroupsFromUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindWorkGroupsFromUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 解绑用户上的用户组
        /// </summary>
        /// <param name="req"><see cref="UnbindWorkGroupsFromUserRequest"/></param>
        /// <returns><see cref="UnbindWorkGroupsFromUserResponse"/></returns>
        public UnbindWorkGroupsFromUserResponse UnbindWorkGroupsFromUserSync(UnbindWorkGroupsFromUserRequest req)
        {
             JsonResponseModel<UnbindWorkGroupsFromUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnbindWorkGroupsFromUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindWorkGroupsFromUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 元数据解锁
        /// </summary>
        /// <param name="req"><see cref="UnlockMetaDataRequest"/></param>
        /// <returns><see cref="UnlockMetaDataResponse"/></returns>
        public async Task<UnlockMetaDataResponse> UnlockMetaData(UnlockMetaDataRequest req)
        {
             JsonResponseModel<UnlockMetaDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnlockMetaData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnlockMetaDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 元数据解锁
        /// </summary>
        /// <param name="req"><see cref="UnlockMetaDataRequest"/></param>
        /// <returns><see cref="UnlockMetaDataResponse"/></returns>
        public UnlockMetaDataResponse UnlockMetaDataSync(UnlockMetaDataRequest req)
        {
             JsonResponseModel<UnlockMetaDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnlockMetaData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnlockMetaDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于更新数据引擎配置
        /// </summary>
        /// <param name="req"><see cref="UpdateDataEngineRequest"/></param>
        /// <returns><see cref="UpdateDataEngineResponse"/></returns>
        public async Task<UpdateDataEngineResponse> UpdateDataEngine(UpdateDataEngineRequest req)
        {
             JsonResponseModel<UpdateDataEngineResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateDataEngine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDataEngineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于更新数据引擎配置
        /// </summary>
        /// <param name="req"><see cref="UpdateDataEngineRequest"/></param>
        /// <returns><see cref="UpdateDataEngineResponse"/></returns>
        public UpdateDataEngineResponse UpdateDataEngineSync(UpdateDataEngineRequest req)
        {
             JsonResponseModel<UpdateDataEngineResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateDataEngine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDataEngineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户某种操作，触发引擎配置修改
        /// </summary>
        /// <param name="req"><see cref="UpdateDataEngineConfigRequest"/></param>
        /// <returns><see cref="UpdateDataEngineConfigResponse"/></returns>
        public async Task<UpdateDataEngineConfigResponse> UpdateDataEngineConfig(UpdateDataEngineConfigRequest req)
        {
             JsonResponseModel<UpdateDataEngineConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateDataEngineConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDataEngineConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户某种操作，触发引擎配置修改
        /// </summary>
        /// <param name="req"><see cref="UpdateDataEngineConfigRequest"/></param>
        /// <returns><see cref="UpdateDataEngineConfigResponse"/></returns>
        public UpdateDataEngineConfigResponse UpdateDataEngineConfigSync(UpdateDataEngineConfigRequest req)
        {
             JsonResponseModel<UpdateDataEngineConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateDataEngineConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDataEngineConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于更新行过滤规则。注意只能更新过滤规则，不能更新规格对象catalog，database和table。
        /// </summary>
        /// <param name="req"><see cref="UpdateRowFilterRequest"/></param>
        /// <returns><see cref="UpdateRowFilterResponse"/></returns>
        public async Task<UpdateRowFilterResponse> UpdateRowFilter(UpdateRowFilterRequest req)
        {
             JsonResponseModel<UpdateRowFilterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateRowFilter");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateRowFilterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于更新行过滤规则。注意只能更新过滤规则，不能更新规格对象catalog，database和table。
        /// </summary>
        /// <param name="req"><see cref="UpdateRowFilterRequest"/></param>
        /// <returns><see cref="UpdateRowFilterResponse"/></returns>
        public UpdateRowFilterResponse UpdateRowFilterSync(UpdateRowFilterRequest req)
        {
             JsonResponseModel<UpdateRowFilterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateRowFilter");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateRowFilterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户引擎自定义配置
        /// </summary>
        /// <param name="req"><see cref="UpdateUserDataEngineConfigRequest"/></param>
        /// <returns><see cref="UpdateUserDataEngineConfigResponse"/></returns>
        public async Task<UpdateUserDataEngineConfigResponse> UpdateUserDataEngineConfig(UpdateUserDataEngineConfigRequest req)
        {
             JsonResponseModel<UpdateUserDataEngineConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateUserDataEngineConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateUserDataEngineConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户引擎自定义配置
        /// </summary>
        /// <param name="req"><see cref="UpdateUserDataEngineConfigRequest"/></param>
        /// <returns><see cref="UpdateUserDataEngineConfigResponse"/></returns>
        public UpdateUserDataEngineConfigResponse UpdateUserDataEngineConfigSync(UpdateUserDataEngineConfigRequest req)
        {
             JsonResponseModel<UpdateUserDataEngineConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateUserDataEngineConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateUserDataEngineConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 升级引擎镜像
        /// </summary>
        /// <param name="req"><see cref="UpgradeDataEngineImageRequest"/></param>
        /// <returns><see cref="UpgradeDataEngineImageResponse"/></returns>
        public async Task<UpgradeDataEngineImageResponse> UpgradeDataEngineImage(UpgradeDataEngineImageRequest req)
        {
             JsonResponseModel<UpgradeDataEngineImageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpgradeDataEngineImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeDataEngineImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 升级引擎镜像
        /// </summary>
        /// <param name="req"><see cref="UpgradeDataEngineImageRequest"/></param>
        /// <returns><see cref="UpgradeDataEngineImageResponse"/></returns>
        public UpgradeDataEngineImageResponse UpgradeDataEngineImageSync(UpgradeDataEngineImageRequest req)
        {
             JsonResponseModel<UpgradeDataEngineImageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpgradeDataEngineImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeDataEngineImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}

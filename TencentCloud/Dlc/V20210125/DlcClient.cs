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
        /// 本接口（CancelTask），用于取消任务执行
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
        /// 本接口（CancelTask），用于取消任务执行
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
        /// 创建spark应用
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
        /// 创建spark应用
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
        /// 创建spark任务
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
        /// 创建spark任务
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
        /// 本接口（CreateTask）用于创建sql查询任务。（推荐使用CreateTasks接口）
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
        /// 本接口（CreateTask）用于创建sql查询任务。（推荐使用CreateTasks接口）
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
        /// 本接口（CreateTasks），用于批量创建任务
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
        /// 本接口（CreateTasks），用于批量创建任务
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
        /// 删除spark应用
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
        /// 删除spark应用
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
        /// 该接口（DescribeScripts）用于获取所有SQL查询。
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
        /// 该接口（DescribeScripts）用于获取所有SQL查询。
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
        /// 查询具体的spark应用
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
        /// 查询具体的spark应用
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
        /// 获取spark应用列表
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
        /// 获取spark应用列表
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
        /// 查询spark应用的运行任务实例列表
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
        /// 查询spark应用的运行任务实例列表
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
        /// 本接口（ListTaskJobLogDetail）用于获取spark-jar日志列表
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
        /// 本接口（ListTaskJobLogDetail）用于获取spark-jar日志列表
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
        /// 更新spark应用
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
        /// 更新spark应用
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

    }
}

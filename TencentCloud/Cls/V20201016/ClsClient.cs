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

namespace TencentCloud.Cls.V20201016
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cls.V20201016.Models;

   public class ClsClient : AbstractClient{

       private const string endpoint = "cls.tencentcloudapi.com";
       private const string version = "2020-10-16";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public ClsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public ClsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 应用采集配置到指定机器组
        /// </summary>
        /// <param name="req"><see cref="ApplyConfigToMachineGroupRequest"/></param>
        /// <returns><see cref="ApplyConfigToMachineGroupResponse"/></returns>
        public async Task<ApplyConfigToMachineGroupResponse> ApplyConfigToMachineGroup(ApplyConfigToMachineGroupRequest req)
        {
             JsonResponseModel<ApplyConfigToMachineGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ApplyConfigToMachineGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyConfigToMachineGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 应用采集配置到指定机器组
        /// </summary>
        /// <param name="req"><see cref="ApplyConfigToMachineGroupRequest"/></param>
        /// <returns><see cref="ApplyConfigToMachineGroupResponse"/></returns>
        public ApplyConfigToMachineGroupResponse ApplyConfigToMachineGroupSync(ApplyConfigToMachineGroupRequest req)
        {
             JsonResponseModel<ApplyConfigToMachineGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ApplyConfigToMachineGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyConfigToMachineGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于创建告警策略。
        /// </summary>
        /// <param name="req"><see cref="CreateAlarmRequest"/></param>
        /// <returns><see cref="CreateAlarmResponse"/></returns>
        public async Task<CreateAlarmResponse> CreateAlarm(CreateAlarmRequest req)
        {
             JsonResponseModel<CreateAlarmResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAlarm");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAlarmResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于创建告警策略。
        /// </summary>
        /// <param name="req"><see cref="CreateAlarmRequest"/></param>
        /// <returns><see cref="CreateAlarmResponse"/></returns>
        public CreateAlarmResponse CreateAlarmSync(CreateAlarmRequest req)
        {
             JsonResponseModel<CreateAlarmResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAlarm");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAlarmResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用户创建告警通知模板。
        /// </summary>
        /// <param name="req"><see cref="CreateAlarmNoticeRequest"/></param>
        /// <returns><see cref="CreateAlarmNoticeResponse"/></returns>
        public async Task<CreateAlarmNoticeResponse> CreateAlarmNotice(CreateAlarmNoticeRequest req)
        {
             JsonResponseModel<CreateAlarmNoticeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAlarmNotice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAlarmNoticeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用户创建告警通知模板。
        /// </summary>
        /// <param name="req"><see cref="CreateAlarmNoticeRequest"/></param>
        /// <returns><see cref="CreateAlarmNoticeResponse"/></returns>
        public CreateAlarmNoticeResponse CreateAlarmNoticeSync(CreateAlarmNoticeRequest req)
        {
             JsonResponseModel<CreateAlarmNoticeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAlarmNotice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAlarmNoticeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建采集规则配置
        /// </summary>
        /// <param name="req"><see cref="CreateConfigRequest"/></param>
        /// <returns><see cref="CreateConfigResponse"/></returns>
        public async Task<CreateConfigResponse> CreateConfig(CreateConfigRequest req)
        {
             JsonResponseModel<CreateConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建采集规则配置
        /// </summary>
        /// <param name="req"><see cref="CreateConfigRequest"/></param>
        /// <returns><see cref="CreateConfigResponse"/></returns>
        public CreateConfigResponse CreateConfigSync(CreateConfigRequest req)
        {
             JsonResponseModel<CreateConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于创建日志导出
        /// </summary>
        /// <param name="req"><see cref="CreateExportRequest"/></param>
        /// <returns><see cref="CreateExportResponse"/></returns>
        public async Task<CreateExportResponse> CreateExport(CreateExportRequest req)
        {
             JsonResponseModel<CreateExportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于创建日志导出
        /// </summary>
        /// <param name="req"><see cref="CreateExportRequest"/></param>
        /// <returns><see cref="CreateExportResponse"/></returns>
        public CreateExportResponse CreateExportSync(CreateExportRequest req)
        {
             JsonResponseModel<CreateExportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于创建索引
        /// </summary>
        /// <param name="req"><see cref="CreateIndexRequest"/></param>
        /// <returns><see cref="CreateIndexResponse"/></returns>
        public async Task<CreateIndexResponse> CreateIndex(CreateIndexRequest req)
        {
             JsonResponseModel<CreateIndexResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateIndex");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIndexResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于创建索引
        /// </summary>
        /// <param name="req"><see cref="CreateIndexRequest"/></param>
        /// <returns><see cref="CreateIndexResponse"/></returns>
        public CreateIndexResponse CreateIndexSync(CreateIndexRequest req)
        {
             JsonResponseModel<CreateIndexResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateIndex");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIndexResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于创建日志集，返回新创建的日志集的 ID。
        /// </summary>
        /// <param name="req"><see cref="CreateLogsetRequest"/></param>
        /// <returns><see cref="CreateLogsetResponse"/></returns>
        public async Task<CreateLogsetResponse> CreateLogset(CreateLogsetRequest req)
        {
             JsonResponseModel<CreateLogsetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLogset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLogsetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于创建日志集，返回新创建的日志集的 ID。
        /// </summary>
        /// <param name="req"><see cref="CreateLogsetRequest"/></param>
        /// <returns><see cref="CreateLogsetResponse"/></returns>
        public CreateLogsetResponse CreateLogsetSync(CreateLogsetRequest req)
        {
             JsonResponseModel<CreateLogsetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLogset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLogsetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建机器组
        /// </summary>
        /// <param name="req"><see cref="CreateMachineGroupRequest"/></param>
        /// <returns><see cref="CreateMachineGroupResponse"/></returns>
        public async Task<CreateMachineGroupResponse> CreateMachineGroup(CreateMachineGroupRequest req)
        {
             JsonResponseModel<CreateMachineGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateMachineGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMachineGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建机器组
        /// </summary>
        /// <param name="req"><see cref="CreateMachineGroupRequest"/></param>
        /// <returns><see cref="CreateMachineGroupResponse"/></returns>
        public CreateMachineGroupResponse CreateMachineGroupSync(CreateMachineGroupRequest req)
        {
             JsonResponseModel<CreateMachineGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateMachineGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMachineGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于创建日志主题。
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRequest"/></param>
        /// <returns><see cref="CreateTopicResponse"/></returns>
        public async Task<CreateTopicResponse> CreateTopic(CreateTopicRequest req)
        {
             JsonResponseModel<CreateTopicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于创建日志主题。
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRequest"/></param>
        /// <returns><see cref="CreateTopicResponse"/></returns>
        public CreateTopicResponse CreateTopicSync(CreateTopicRequest req)
        {
             JsonResponseModel<CreateTopicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于删除告警策略。
        /// </summary>
        /// <param name="req"><see cref="DeleteAlarmRequest"/></param>
        /// <returns><see cref="DeleteAlarmResponse"/></returns>
        public async Task<DeleteAlarmResponse> DeleteAlarm(DeleteAlarmRequest req)
        {
             JsonResponseModel<DeleteAlarmResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAlarm");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAlarmResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于删除告警策略。
        /// </summary>
        /// <param name="req"><see cref="DeleteAlarmRequest"/></param>
        /// <returns><see cref="DeleteAlarmResponse"/></returns>
        public DeleteAlarmResponse DeleteAlarmSync(DeleteAlarmRequest req)
        {
             JsonResponseModel<DeleteAlarmResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAlarm");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAlarmResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于删除告警通知模板
        /// </summary>
        /// <param name="req"><see cref="DeleteAlarmNoticeRequest"/></param>
        /// <returns><see cref="DeleteAlarmNoticeResponse"/></returns>
        public async Task<DeleteAlarmNoticeResponse> DeleteAlarmNotice(DeleteAlarmNoticeRequest req)
        {
             JsonResponseModel<DeleteAlarmNoticeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAlarmNotice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAlarmNoticeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于删除告警通知模板
        /// </summary>
        /// <param name="req"><see cref="DeleteAlarmNoticeRequest"/></param>
        /// <returns><see cref="DeleteAlarmNoticeResponse"/></returns>
        public DeleteAlarmNoticeResponse DeleteAlarmNoticeSync(DeleteAlarmNoticeRequest req)
        {
             JsonResponseModel<DeleteAlarmNoticeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAlarmNotice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAlarmNoticeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除采集规则配置
        /// </summary>
        /// <param name="req"><see cref="DeleteConfigRequest"/></param>
        /// <returns><see cref="DeleteConfigResponse"/></returns>
        public async Task<DeleteConfigResponse> DeleteConfig(DeleteConfigRequest req)
        {
             JsonResponseModel<DeleteConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除采集规则配置
        /// </summary>
        /// <param name="req"><see cref="DeleteConfigRequest"/></param>
        /// <returns><see cref="DeleteConfigResponse"/></returns>
        public DeleteConfigResponse DeleteConfigSync(DeleteConfigRequest req)
        {
             JsonResponseModel<DeleteConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除应用到机器组的采集配置
        /// </summary>
        /// <param name="req"><see cref="DeleteConfigFromMachineGroupRequest"/></param>
        /// <returns><see cref="DeleteConfigFromMachineGroupResponse"/></returns>
        public async Task<DeleteConfigFromMachineGroupResponse> DeleteConfigFromMachineGroup(DeleteConfigFromMachineGroupRequest req)
        {
             JsonResponseModel<DeleteConfigFromMachineGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteConfigFromMachineGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteConfigFromMachineGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除应用到机器组的采集配置
        /// </summary>
        /// <param name="req"><see cref="DeleteConfigFromMachineGroupRequest"/></param>
        /// <returns><see cref="DeleteConfigFromMachineGroupResponse"/></returns>
        public DeleteConfigFromMachineGroupResponse DeleteConfigFromMachineGroupSync(DeleteConfigFromMachineGroupRequest req)
        {
             JsonResponseModel<DeleteConfigFromMachineGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteConfigFromMachineGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteConfigFromMachineGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于删除日志导出
        /// </summary>
        /// <param name="req"><see cref="DeleteExportRequest"/></param>
        /// <returns><see cref="DeleteExportResponse"/></returns>
        public async Task<DeleteExportResponse> DeleteExport(DeleteExportRequest req)
        {
             JsonResponseModel<DeleteExportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于删除日志导出
        /// </summary>
        /// <param name="req"><see cref="DeleteExportRequest"/></param>
        /// <returns><see cref="DeleteExportResponse"/></returns>
        public DeleteExportResponse DeleteExportSync(DeleteExportRequest req)
        {
             JsonResponseModel<DeleteExportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于日志主题的索引配置
        /// </summary>
        /// <param name="req"><see cref="DeleteIndexRequest"/></param>
        /// <returns><see cref="DeleteIndexResponse"/></returns>
        public async Task<DeleteIndexResponse> DeleteIndex(DeleteIndexRequest req)
        {
             JsonResponseModel<DeleteIndexResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteIndex");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteIndexResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于日志主题的索引配置
        /// </summary>
        /// <param name="req"><see cref="DeleteIndexRequest"/></param>
        /// <returns><see cref="DeleteIndexResponse"/></returns>
        public DeleteIndexResponse DeleteIndexSync(DeleteIndexRequest req)
        {
             JsonResponseModel<DeleteIndexResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteIndex");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteIndexResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于删除日志集。
        /// </summary>
        /// <param name="req"><see cref="DeleteLogsetRequest"/></param>
        /// <returns><see cref="DeleteLogsetResponse"/></returns>
        public async Task<DeleteLogsetResponse> DeleteLogset(DeleteLogsetRequest req)
        {
             JsonResponseModel<DeleteLogsetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLogset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLogsetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于删除日志集。
        /// </summary>
        /// <param name="req"><see cref="DeleteLogsetRequest"/></param>
        /// <returns><see cref="DeleteLogsetResponse"/></returns>
        public DeleteLogsetResponse DeleteLogsetSync(DeleteLogsetRequest req)
        {
             JsonResponseModel<DeleteLogsetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLogset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLogsetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除机器组
        /// </summary>
        /// <param name="req"><see cref="DeleteMachineGroupRequest"/></param>
        /// <returns><see cref="DeleteMachineGroupResponse"/></returns>
        public async Task<DeleteMachineGroupResponse> DeleteMachineGroup(DeleteMachineGroupRequest req)
        {
             JsonResponseModel<DeleteMachineGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMachineGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMachineGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除机器组
        /// </summary>
        /// <param name="req"><see cref="DeleteMachineGroupRequest"/></param>
        /// <returns><see cref="DeleteMachineGroupResponse"/></returns>
        public DeleteMachineGroupResponse DeleteMachineGroupSync(DeleteMachineGroupRequest req)
        {
             JsonResponseModel<DeleteMachineGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteMachineGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMachineGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于删除日志主题。
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicRequest"/></param>
        /// <returns><see cref="DeleteTopicResponse"/></returns>
        public async Task<DeleteTopicResponse> DeleteTopic(DeleteTopicRequest req)
        {
             JsonResponseModel<DeleteTopicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于删除日志主题。
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicRequest"/></param>
        /// <returns><see cref="DeleteTopicResponse"/></returns>
        public DeleteTopicResponse DeleteTopicSync(DeleteTopicRequest req)
        {
             JsonResponseModel<DeleteTopicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于获取告警通知模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmNoticesRequest"/></param>
        /// <returns><see cref="DescribeAlarmNoticesResponse"/></returns>
        public async Task<DescribeAlarmNoticesResponse> DescribeAlarmNotices(DescribeAlarmNoticesRequest req)
        {
             JsonResponseModel<DescribeAlarmNoticesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAlarmNotices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmNoticesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于获取告警通知模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmNoticesRequest"/></param>
        /// <returns><see cref="DescribeAlarmNoticesResponse"/></returns>
        public DescribeAlarmNoticesResponse DescribeAlarmNoticesSync(DescribeAlarmNoticesRequest req)
        {
             JsonResponseModel<DescribeAlarmNoticesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAlarmNotices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmNoticesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于获取告警策略。
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmsRequest"/></param>
        /// <returns><see cref="DescribeAlarmsResponse"/></returns>
        public async Task<DescribeAlarmsResponse> DescribeAlarms(DescribeAlarmsRequest req)
        {
             JsonResponseModel<DescribeAlarmsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAlarms");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于获取告警策略。
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmsRequest"/></param>
        /// <returns><see cref="DescribeAlarmsResponse"/></returns>
        public DescribeAlarmsResponse DescribeAlarmsSync(DescribeAlarmsRequest req)
        {
             JsonResponseModel<DescribeAlarmsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAlarms");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取采集规则配置所绑定的机器组
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigMachineGroupsRequest"/></param>
        /// <returns><see cref="DescribeConfigMachineGroupsResponse"/></returns>
        public async Task<DescribeConfigMachineGroupsResponse> DescribeConfigMachineGroups(DescribeConfigMachineGroupsRequest req)
        {
             JsonResponseModel<DescribeConfigMachineGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeConfigMachineGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConfigMachineGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取采集规则配置所绑定的机器组
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigMachineGroupsRequest"/></param>
        /// <returns><see cref="DescribeConfigMachineGroupsResponse"/></returns>
        public DescribeConfigMachineGroupsResponse DescribeConfigMachineGroupsSync(DescribeConfigMachineGroupsRequest req)
        {
             JsonResponseModel<DescribeConfigMachineGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeConfigMachineGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConfigMachineGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取采集规则配置
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigsRequest"/></param>
        /// <returns><see cref="DescribeConfigsResponse"/></returns>
        public async Task<DescribeConfigsResponse> DescribeConfigs(DescribeConfigsRequest req)
        {
             JsonResponseModel<DescribeConfigsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取采集规则配置
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigsRequest"/></param>
        /// <returns><see cref="DescribeConfigsResponse"/></returns>
        public DescribeConfigsResponse DescribeConfigsSync(DescribeConfigsRequest req)
        {
             JsonResponseModel<DescribeConfigsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于获取日志导出列表
        /// </summary>
        /// <param name="req"><see cref="DescribeExportsRequest"/></param>
        /// <returns><see cref="DescribeExportsResponse"/></returns>
        public async Task<DescribeExportsResponse> DescribeExports(DescribeExportsRequest req)
        {
             JsonResponseModel<DescribeExportsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeExports");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExportsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于获取日志导出列表
        /// </summary>
        /// <param name="req"><see cref="DescribeExportsRequest"/></param>
        /// <returns><see cref="DescribeExportsResponse"/></returns>
        public DescribeExportsResponse DescribeExportsSync(DescribeExportsRequest req)
        {
             JsonResponseModel<DescribeExportsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeExports");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExportsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于获取索引配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeIndexRequest"/></param>
        /// <returns><see cref="DescribeIndexResponse"/></returns>
        public async Task<DescribeIndexResponse> DescribeIndex(DescribeIndexRequest req)
        {
             JsonResponseModel<DescribeIndexResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIndex");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIndexResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于获取索引配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeIndexRequest"/></param>
        /// <returns><see cref="DescribeIndexResponse"/></returns>
        public DescribeIndexResponse DescribeIndexSync(DescribeIndexRequest req)
        {
             JsonResponseModel<DescribeIndexResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIndex");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIndexResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于搜索日志上下文附近的内容
        /// </summary>
        /// <param name="req"><see cref="DescribeLogContextRequest"/></param>
        /// <returns><see cref="DescribeLogContextResponse"/></returns>
        public async Task<DescribeLogContextResponse> DescribeLogContext(DescribeLogContextRequest req)
        {
             JsonResponseModel<DescribeLogContextResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLogContext");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogContextResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于搜索日志上下文附近的内容
        /// </summary>
        /// <param name="req"><see cref="DescribeLogContextRequest"/></param>
        /// <returns><see cref="DescribeLogContextResponse"/></returns>
        public DescribeLogContextResponse DescribeLogContextSync(DescribeLogContextRequest req)
        {
             JsonResponseModel<DescribeLogContextResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLogContext");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogContextResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于获取日志集信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeLogsetsRequest"/></param>
        /// <returns><see cref="DescribeLogsetsResponse"/></returns>
        public async Task<DescribeLogsetsResponse> DescribeLogsets(DescribeLogsetsRequest req)
        {
             JsonResponseModel<DescribeLogsetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLogsets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogsetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于获取日志集信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeLogsetsRequest"/></param>
        /// <returns><see cref="DescribeLogsetsResponse"/></returns>
        public DescribeLogsetsResponse DescribeLogsetsSync(DescribeLogsetsRequest req)
        {
             JsonResponseModel<DescribeLogsetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLogsets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogsetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取机器组绑定的采集规则配置
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineGroupConfigsRequest"/></param>
        /// <returns><see cref="DescribeMachineGroupConfigsResponse"/></returns>
        public async Task<DescribeMachineGroupConfigsResponse> DescribeMachineGroupConfigs(DescribeMachineGroupConfigsRequest req)
        {
             JsonResponseModel<DescribeMachineGroupConfigsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMachineGroupConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachineGroupConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取机器组绑定的采集规则配置
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineGroupConfigsRequest"/></param>
        /// <returns><see cref="DescribeMachineGroupConfigsResponse"/></returns>
        public DescribeMachineGroupConfigsResponse DescribeMachineGroupConfigsSync(DescribeMachineGroupConfigsRequest req)
        {
             JsonResponseModel<DescribeMachineGroupConfigsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMachineGroupConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachineGroupConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取机器组信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineGroupsRequest"/></param>
        /// <returns><see cref="DescribeMachineGroupsResponse"/></returns>
        public async Task<DescribeMachineGroupsResponse> DescribeMachineGroups(DescribeMachineGroupsRequest req)
        {
             JsonResponseModel<DescribeMachineGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMachineGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachineGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取机器组信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineGroupsRequest"/></param>
        /// <returns><see cref="DescribeMachineGroupsResponse"/></returns>
        public DescribeMachineGroupsResponse DescribeMachineGroupsSync(DescribeMachineGroupsRequest req)
        {
             JsonResponseModel<DescribeMachineGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMachineGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachineGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取制定机器组下的机器状态
        /// </summary>
        /// <param name="req"><see cref="DescribeMachinesRequest"/></param>
        /// <returns><see cref="DescribeMachinesResponse"/></returns>
        public async Task<DescribeMachinesResponse> DescribeMachines(DescribeMachinesRequest req)
        {
             JsonResponseModel<DescribeMachinesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMachines");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachinesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取制定机器组下的机器状态
        /// </summary>
        /// <param name="req"><see cref="DescribeMachinesRequest"/></param>
        /// <returns><see cref="DescribeMachinesResponse"/></returns>
        public DescribeMachinesResponse DescribeMachinesSync(DescribeMachinesRequest req)
        {
             JsonResponseModel<DescribeMachinesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMachines");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMachinesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于获取主题分区列表。
        /// </summary>
        /// <param name="req"><see cref="DescribePartitionsRequest"/></param>
        /// <returns><see cref="DescribePartitionsResponse"/></returns>
        public async Task<DescribePartitionsResponse> DescribePartitions(DescribePartitionsRequest req)
        {
             JsonResponseModel<DescribePartitionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePartitions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePartitionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于获取主题分区列表。
        /// </summary>
        /// <param name="req"><see cref="DescribePartitionsRequest"/></param>
        /// <returns><see cref="DescribePartitionsResponse"/></returns>
        public DescribePartitionsResponse DescribePartitionsSync(DescribePartitionsRequest req)
        {
             JsonResponseModel<DescribePartitionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePartitions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePartitionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  本接口用于获取日志主题列表，支持分页
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicsRequest"/></param>
        /// <returns><see cref="DescribeTopicsResponse"/></returns>
        public async Task<DescribeTopicsResponse> DescribeTopics(DescribeTopicsRequest req)
        {
             JsonResponseModel<DescribeTopicsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTopics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopicsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        ///  本接口用于获取日志主题列表，支持分页
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicsRequest"/></param>
        /// <returns><see cref="DescribeTopicsResponse"/></returns>
        public DescribeTopicsResponse DescribeTopicsSync(DescribeTopicsRequest req)
        {
             JsonResponseModel<DescribeTopicsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTopics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopicsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于获取告警任务历史
        /// </summary>
        /// <param name="req"><see cref="GetAlarmLogRequest"/></param>
        /// <returns><see cref="GetAlarmLogResponse"/></returns>
        public async Task<GetAlarmLogResponse> GetAlarmLog(GetAlarmLogRequest req)
        {
             JsonResponseModel<GetAlarmLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetAlarmLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetAlarmLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于获取告警任务历史
        /// </summary>
        /// <param name="req"><see cref="GetAlarmLogRequest"/></param>
        /// <returns><see cref="GetAlarmLogResponse"/></returns>
        public GetAlarmLogResponse GetAlarmLogSync(GetAlarmLogRequest req)
        {
             JsonResponseModel<GetAlarmLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetAlarmLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetAlarmLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于合并一个读写态的主题分区，合并时指定一个主题分区 ID，日志服务会自动合并范围右相邻的分区。
        /// </summary>
        /// <param name="req"><see cref="MergePartitionRequest"/></param>
        /// <returns><see cref="MergePartitionResponse"/></returns>
        public async Task<MergePartitionResponse> MergePartition(MergePartitionRequest req)
        {
             JsonResponseModel<MergePartitionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "MergePartition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MergePartitionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于合并一个读写态的主题分区，合并时指定一个主题分区 ID，日志服务会自动合并范围右相邻的分区。
        /// </summary>
        /// <param name="req"><see cref="MergePartitionRequest"/></param>
        /// <returns><see cref="MergePartitionResponse"/></returns>
        public MergePartitionResponse MergePartitionSync(MergePartitionRequest req)
        {
             JsonResponseModel<MergePartitionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "MergePartition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MergePartitionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于修改告警策略。需要至少修改一项有效内容。
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmRequest"/></param>
        /// <returns><see cref="ModifyAlarmResponse"/></returns>
        public async Task<ModifyAlarmResponse> ModifyAlarm(ModifyAlarmRequest req)
        {
             JsonResponseModel<ModifyAlarmResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAlarm");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAlarmResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于修改告警策略。需要至少修改一项有效内容。
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmRequest"/></param>
        /// <returns><see cref="ModifyAlarmResponse"/></returns>
        public ModifyAlarmResponse ModifyAlarmSync(ModifyAlarmRequest req)
        {
             JsonResponseModel<ModifyAlarmResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAlarm");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAlarmResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于修改告警通知模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmNoticeRequest"/></param>
        /// <returns><see cref="ModifyAlarmNoticeResponse"/></returns>
        public async Task<ModifyAlarmNoticeResponse> ModifyAlarmNotice(ModifyAlarmNoticeRequest req)
        {
             JsonResponseModel<ModifyAlarmNoticeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAlarmNotice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAlarmNoticeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于修改告警通知模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmNoticeRequest"/></param>
        /// <returns><see cref="ModifyAlarmNoticeResponse"/></returns>
        public ModifyAlarmNoticeResponse ModifyAlarmNoticeSync(ModifyAlarmNoticeRequest req)
        {
             JsonResponseModel<ModifyAlarmNoticeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAlarmNotice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAlarmNoticeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改采集规则配置
        /// </summary>
        /// <param name="req"><see cref="ModifyConfigRequest"/></param>
        /// <returns><see cref="ModifyConfigResponse"/></returns>
        public async Task<ModifyConfigResponse> ModifyConfig(ModifyConfigRequest req)
        {
             JsonResponseModel<ModifyConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改采集规则配置
        /// </summary>
        /// <param name="req"><see cref="ModifyConfigRequest"/></param>
        /// <returns><see cref="ModifyConfigResponse"/></returns>
        public ModifyConfigResponse ModifyConfigSync(ModifyConfigRequest req)
        {
             JsonResponseModel<ModifyConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于修改索引配置
        /// </summary>
        /// <param name="req"><see cref="ModifyIndexRequest"/></param>
        /// <returns><see cref="ModifyIndexResponse"/></returns>
        public async Task<ModifyIndexResponse> ModifyIndex(ModifyIndexRequest req)
        {
             JsonResponseModel<ModifyIndexResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyIndex");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyIndexResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于修改索引配置
        /// </summary>
        /// <param name="req"><see cref="ModifyIndexRequest"/></param>
        /// <returns><see cref="ModifyIndexResponse"/></returns>
        public ModifyIndexResponse ModifyIndexSync(ModifyIndexRequest req)
        {
             JsonResponseModel<ModifyIndexResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyIndex");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyIndexResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于修改日志集信息
        /// </summary>
        /// <param name="req"><see cref="ModifyLogsetRequest"/></param>
        /// <returns><see cref="ModifyLogsetResponse"/></returns>
        public async Task<ModifyLogsetResponse> ModifyLogset(ModifyLogsetRequest req)
        {
             JsonResponseModel<ModifyLogsetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLogset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLogsetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于修改日志集信息
        /// </summary>
        /// <param name="req"><see cref="ModifyLogsetRequest"/></param>
        /// <returns><see cref="ModifyLogsetResponse"/></returns>
        public ModifyLogsetResponse ModifyLogsetSync(ModifyLogsetRequest req)
        {
             JsonResponseModel<ModifyLogsetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLogset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLogsetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改机器组
        /// </summary>
        /// <param name="req"><see cref="ModifyMachineGroupRequest"/></param>
        /// <returns><see cref="ModifyMachineGroupResponse"/></returns>
        public async Task<ModifyMachineGroupResponse> ModifyMachineGroup(ModifyMachineGroupRequest req)
        {
             JsonResponseModel<ModifyMachineGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMachineGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMachineGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改机器组
        /// </summary>
        /// <param name="req"><see cref="ModifyMachineGroupRequest"/></param>
        /// <returns><see cref="ModifyMachineGroupResponse"/></returns>
        public ModifyMachineGroupResponse ModifyMachineGroupSync(ModifyMachineGroupRequest req)
        {
             JsonResponseModel<ModifyMachineGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMachineGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMachineGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于修改日志主题。
        /// </summary>
        /// <param name="req"><see cref="ModifyTopicRequest"/></param>
        /// <returns><see cref="ModifyTopicResponse"/></returns>
        public async Task<ModifyTopicResponse> ModifyTopic(ModifyTopicRequest req)
        {
             JsonResponseModel<ModifyTopicResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于修改日志主题。
        /// </summary>
        /// <param name="req"><see cref="ModifyTopicRequest"/></param>
        /// <returns><see cref="ModifyTopicResponse"/></returns>
        public ModifyTopicResponse ModifyTopicSync(ModifyTopicRequest req)
        {
             JsonResponseModel<ModifyTopicResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTopic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTopicResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于搜索日志
        /// </summary>
        /// <param name="req"><see cref="SearchLogRequest"/></param>
        /// <returns><see cref="SearchLogResponse"/></returns>
        public async Task<SearchLogResponse> SearchLog(SearchLogRequest req)
        {
             JsonResponseModel<SearchLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SearchLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于搜索日志
        /// </summary>
        /// <param name="req"><see cref="SearchLogRequest"/></param>
        /// <returns><see cref="SearchLogResponse"/></returns>
        public SearchLogResponse SearchLogSync(SearchLogRequest req)
        {
             JsonResponseModel<SearchLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SearchLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于分裂主题分区
        /// </summary>
        /// <param name="req"><see cref="SplitPartitionRequest"/></param>
        /// <returns><see cref="SplitPartitionResponse"/></returns>
        public async Task<SplitPartitionResponse> SplitPartition(SplitPartitionRequest req)
        {
             JsonResponseModel<SplitPartitionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SplitPartition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SplitPartitionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于分裂主题分区
        /// </summary>
        /// <param name="req"><see cref="SplitPartitionRequest"/></param>
        /// <returns><see cref="SplitPartitionResponse"/></returns>
        public SplitPartitionResponse SplitPartitionSync(SplitPartitionRequest req)
        {
             JsonResponseModel<SplitPartitionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SplitPartition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SplitPartitionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}

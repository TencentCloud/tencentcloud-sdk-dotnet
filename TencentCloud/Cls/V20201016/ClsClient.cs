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
        /// 用于添加机器组信息
        /// </summary>
        /// <param name="req"><see cref="AddMachineGroupInfoRequest"/></param>
        /// <returns><see cref="AddMachineGroupInfoResponse"/></returns>
        public async Task<AddMachineGroupInfoResponse> AddMachineGroupInfo(AddMachineGroupInfoRequest req)
        {
             JsonResponseModel<AddMachineGroupInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddMachineGroupInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddMachineGroupInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于添加机器组信息
        /// </summary>
        /// <param name="req"><see cref="AddMachineGroupInfoRequest"/></param>
        /// <returns><see cref="AddMachineGroupInfoResponse"/></returns>
        public AddMachineGroupInfoResponse AddMachineGroupInfoSync(AddMachineGroupInfoRequest req)
        {
             JsonResponseModel<AddMachineGroupInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddMachineGroupInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddMachineGroupInfoResponse>>(strResp);
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
        /// 本接口用于数据加工DSL函数的语法校验。
        /// </summary>
        /// <param name="req"><see cref="CheckFunctionRequest"/></param>
        /// <returns><see cref="CheckFunctionResponse"/></returns>
        public async Task<CheckFunctionResponse> CheckFunction(CheckFunctionRequest req)
        {
             JsonResponseModel<CheckFunctionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckFunction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckFunctionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于数据加工DSL函数的语法校验。
        /// </summary>
        /// <param name="req"><see cref="CheckFunctionRequest"/></param>
        /// <returns><see cref="CheckFunctionResponse"/></returns>
        public CheckFunctionResponse CheckFunctionSync(CheckFunctionRequest req)
        {
             JsonResponseModel<CheckFunctionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckFunction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckFunctionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于校验Kafka服务集群是否可以正常访问
        /// </summary>
        /// <param name="req"><see cref="CheckRechargeKafkaServerRequest"/></param>
        /// <returns><see cref="CheckRechargeKafkaServerResponse"/></returns>
        public async Task<CheckRechargeKafkaServerResponse> CheckRechargeKafkaServer(CheckRechargeKafkaServerRequest req)
        {
             JsonResponseModel<CheckRechargeKafkaServerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckRechargeKafkaServer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckRechargeKafkaServerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于校验Kafka服务集群是否可以正常访问
        /// </summary>
        /// <param name="req"><see cref="CheckRechargeKafkaServerRequest"/></param>
        /// <returns><see cref="CheckRechargeKafkaServerResponse"/></returns>
        public CheckRechargeKafkaServerResponse CheckRechargeKafkaServerSync(CheckRechargeKafkaServerRequest req)
        {
             JsonResponseModel<CheckRechargeKafkaServerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckRechargeKafkaServer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckRechargeKafkaServerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 关闭Kafka协议消费
        /// </summary>
        /// <param name="req"><see cref="CloseKafkaConsumerRequest"/></param>
        /// <returns><see cref="CloseKafkaConsumerResponse"/></returns>
        public async Task<CloseKafkaConsumerResponse> CloseKafkaConsumer(CloseKafkaConsumerRequest req)
        {
             JsonResponseModel<CloseKafkaConsumerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CloseKafkaConsumer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloseKafkaConsumerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 关闭Kafka协议消费
        /// </summary>
        /// <param name="req"><see cref="CloseKafkaConsumerRequest"/></param>
        /// <returns><see cref="CloseKafkaConsumerResponse"/></returns>
        public CloseKafkaConsumerResponse CloseKafkaConsumerSync(CloseKafkaConsumerRequest req)
        {
             JsonResponseModel<CloseKafkaConsumerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CloseKafkaConsumer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloseKafkaConsumerResponse>>(strResp);
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
        /// 该接口用于创建通知渠道组。
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
        /// 该接口用于创建通知渠道组。
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
        /// 本接口用于创建特殊采集配置任务，特殊采集配置应用于自建K8S环境的采集Agent
        /// </summary>
        /// <param name="req"><see cref="CreateConfigExtraRequest"/></param>
        /// <returns><see cref="CreateConfigExtraResponse"/></returns>
        public async Task<CreateConfigExtraResponse> CreateConfigExtra(CreateConfigExtraRequest req)
        {
             JsonResponseModel<CreateConfigExtraResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateConfigExtra");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateConfigExtraResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于创建特殊采集配置任务，特殊采集配置应用于自建K8S环境的采集Agent
        /// </summary>
        /// <param name="req"><see cref="CreateConfigExtraRequest"/></param>
        /// <returns><see cref="CreateConfigExtraResponse"/></returns>
        public CreateConfigExtraResponse CreateConfigExtraSync(CreateConfigExtraRequest req)
        {
             JsonResponseModel<CreateConfigExtraResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateConfigExtra");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateConfigExtraResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于创建投递任务
        /// </summary>
        /// <param name="req"><see cref="CreateConsumerRequest"/></param>
        /// <returns><see cref="CreateConsumerResponse"/></returns>
        public async Task<CreateConsumerResponse> CreateConsumer(CreateConsumerRequest req)
        {
             JsonResponseModel<CreateConsumerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateConsumer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateConsumerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于创建投递任务
        /// </summary>
        /// <param name="req"><see cref="CreateConsumerRequest"/></param>
        /// <returns><see cref="CreateConsumerResponse"/></returns>
        public CreateConsumerResponse CreateConsumerSync(CreateConsumerRequest req)
        {
             JsonResponseModel<CreateConsumerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateConsumer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateConsumerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于创建cos导入任务
        /// </summary>
        /// <param name="req"><see cref="CreateCosRechargeRequest"/></param>
        /// <returns><see cref="CreateCosRechargeResponse"/></returns>
        public async Task<CreateCosRechargeResponse> CreateCosRecharge(CreateCosRechargeRequest req)
        {
             JsonResponseModel<CreateCosRechargeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCosRecharge");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCosRechargeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于创建cos导入任务
        /// </summary>
        /// <param name="req"><see cref="CreateCosRechargeRequest"/></param>
        /// <returns><see cref="CreateCosRechargeResponse"/></returns>
        public CreateCosRechargeResponse CreateCosRechargeSync(CreateCosRechargeRequest req)
        {
             JsonResponseModel<CreateCosRechargeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCosRecharge");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCosRechargeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于创建数据加工任务。
        /// </summary>
        /// <param name="req"><see cref="CreateDataTransformRequest"/></param>
        /// <returns><see cref="CreateDataTransformResponse"/></returns>
        public async Task<CreateDataTransformResponse> CreateDataTransform(CreateDataTransformRequest req)
        {
             JsonResponseModel<CreateDataTransformResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDataTransform");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDataTransformResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于创建数据加工任务。
        /// </summary>
        /// <param name="req"><see cref="CreateDataTransformRequest"/></param>
        /// <returns><see cref="CreateDataTransformResponse"/></returns>
        public CreateDataTransformResponse CreateDataTransformSync(CreateDataTransformRequest req)
        {
             JsonResponseModel<CreateDataTransformResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDataTransform");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDataTransformResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口仅创建下载任务，任务返回的下载地址，请用户调用DescribeExports查看任务列表。其中有下载地址CosPath参数。参考文档https://cloud.tencent.com/document/product/614/56449
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
        /// 本接口仅创建下载任务，任务返回的下载地址，请用户调用DescribeExports查看任务列表。其中有下载地址CosPath参数。参考文档https://cloud.tencent.com/document/product/614/56449
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
        /// 本接口用于创建Kafka数据订阅任务
        /// </summary>
        /// <param name="req"><see cref="CreateKafkaRechargeRequest"/></param>
        /// <returns><see cref="CreateKafkaRechargeResponse"/></returns>
        public async Task<CreateKafkaRechargeResponse> CreateKafkaRecharge(CreateKafkaRechargeRequest req)
        {
             JsonResponseModel<CreateKafkaRechargeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateKafkaRecharge");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateKafkaRechargeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于创建Kafka数据订阅任务
        /// </summary>
        /// <param name="req"><see cref="CreateKafkaRechargeRequest"/></param>
        /// <returns><see cref="CreateKafkaRechargeResponse"/></returns>
        public CreateKafkaRechargeResponse CreateKafkaRechargeSync(CreateKafkaRechargeRequest req)
        {
             JsonResponseModel<CreateKafkaRechargeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateKafkaRecharge");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateKafkaRechargeResponse>>(strResp);
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
        /// 本接口用于创建定时SQL分析任务
        /// </summary>
        /// <param name="req"><see cref="CreateScheduledSqlRequest"/></param>
        /// <returns><see cref="CreateScheduledSqlResponse"/></returns>
        public async Task<CreateScheduledSqlResponse> CreateScheduledSql(CreateScheduledSqlRequest req)
        {
             JsonResponseModel<CreateScheduledSqlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateScheduledSql");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateScheduledSqlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于创建定时SQL分析任务
        /// </summary>
        /// <param name="req"><see cref="CreateScheduledSqlRequest"/></param>
        /// <returns><see cref="CreateScheduledSqlResponse"/></returns>
        public CreateScheduledSqlResponse CreateScheduledSqlSync(CreateScheduledSqlRequest req)
        {
             JsonResponseModel<CreateScheduledSqlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateScheduledSql");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateScheduledSqlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建投递到COS的任务，【！！！注意】使用此接口，需要检查是否配置了投递COS的角色和权限。如果没有配置，请参考文档投递权限查看和配置https://cloud.tencent.com/document/product/614/71623。
        /// </summary>
        /// <param name="req"><see cref="CreateShipperRequest"/></param>
        /// <returns><see cref="CreateShipperResponse"/></returns>
        public async Task<CreateShipperResponse> CreateShipper(CreateShipperRequest req)
        {
             JsonResponseModel<CreateShipperResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateShipper");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateShipperResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建投递到COS的任务，【！！！注意】使用此接口，需要检查是否配置了投递COS的角色和权限。如果没有配置，请参考文档投递权限查看和配置https://cloud.tencent.com/document/product/614/71623。
        /// </summary>
        /// <param name="req"><see cref="CreateShipperRequest"/></param>
        /// <returns><see cref="CreateShipperResponse"/></returns>
        public CreateShipperResponse CreateShipperSync(CreateShipperRequest req)
        {
             JsonResponseModel<CreateShipperResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateShipper");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateShipperResponse>>(strResp);
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
        /// 该接口用于删除通知渠道组
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
        /// 该接口用于删除通知渠道组
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
        /// 本接口用于删除特殊采集规则配置，特殊采集配置应用于自建K8S环境的采集Agent
        /// </summary>
        /// <param name="req"><see cref="DeleteConfigExtraRequest"/></param>
        /// <returns><see cref="DeleteConfigExtraResponse"/></returns>
        public async Task<DeleteConfigExtraResponse> DeleteConfigExtra(DeleteConfigExtraRequest req)
        {
             JsonResponseModel<DeleteConfigExtraResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteConfigExtra");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteConfigExtraResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于删除特殊采集规则配置，特殊采集配置应用于自建K8S环境的采集Agent
        /// </summary>
        /// <param name="req"><see cref="DeleteConfigExtraRequest"/></param>
        /// <returns><see cref="DeleteConfigExtraResponse"/></returns>
        public DeleteConfigExtraResponse DeleteConfigExtraSync(DeleteConfigExtraRequest req)
        {
             JsonResponseModel<DeleteConfigExtraResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteConfigExtra");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteConfigExtraResponse>>(strResp);
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
        /// 本接口用于删除投递配置
        /// </summary>
        /// <param name="req"><see cref="DeleteConsumerRequest"/></param>
        /// <returns><see cref="DeleteConsumerResponse"/></returns>
        public async Task<DeleteConsumerResponse> DeleteConsumer(DeleteConsumerRequest req)
        {
             JsonResponseModel<DeleteConsumerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteConsumer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteConsumerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于删除投递配置
        /// </summary>
        /// <param name="req"><see cref="DeleteConsumerRequest"/></param>
        /// <returns><see cref="DeleteConsumerResponse"/></returns>
        public DeleteConsumerResponse DeleteConsumerSync(DeleteConsumerRequest req)
        {
             JsonResponseModel<DeleteConsumerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteConsumer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteConsumerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于删除数据加工任务
        /// </summary>
        /// <param name="req"><see cref="DeleteDataTransformRequest"/></param>
        /// <returns><see cref="DeleteDataTransformResponse"/></returns>
        public async Task<DeleteDataTransformResponse> DeleteDataTransform(DeleteDataTransformRequest req)
        {
             JsonResponseModel<DeleteDataTransformResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDataTransform");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDataTransformResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于删除数据加工任务
        /// </summary>
        /// <param name="req"><see cref="DeleteDataTransformRequest"/></param>
        /// <returns><see cref="DeleteDataTransformResponse"/></returns>
        public DeleteDataTransformResponse DeleteDataTransformSync(DeleteDataTransformRequest req)
        {
             JsonResponseModel<DeleteDataTransformResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDataTransform");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDataTransformResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于删除日志下载任务
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
        /// 本接口用于删除日志下载任务
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
        /// 本接口用于删除日志主题的索引配置，删除索引配置后将无法检索和查询采集到的日志。
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
        /// 本接口用于删除日志主题的索引配置，删除索引配置后将无法检索和查询采集到的日志。
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
        /// 本接口用于删除Kafka数据订阅任务
        /// </summary>
        /// <param name="req"><see cref="DeleteKafkaRechargeRequest"/></param>
        /// <returns><see cref="DeleteKafkaRechargeResponse"/></returns>
        public async Task<DeleteKafkaRechargeResponse> DeleteKafkaRecharge(DeleteKafkaRechargeRequest req)
        {
             JsonResponseModel<DeleteKafkaRechargeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteKafkaRecharge");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteKafkaRechargeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于删除Kafka数据订阅任务
        /// </summary>
        /// <param name="req"><see cref="DeleteKafkaRechargeRequest"/></param>
        /// <returns><see cref="DeleteKafkaRechargeResponse"/></returns>
        public DeleteKafkaRechargeResponse DeleteKafkaRechargeSync(DeleteKafkaRechargeRequest req)
        {
             JsonResponseModel<DeleteKafkaRechargeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteKafkaRecharge");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteKafkaRechargeResponse>>(strResp);
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
        /// 用于删除机器组信息
        /// </summary>
        /// <param name="req"><see cref="DeleteMachineGroupInfoRequest"/></param>
        /// <returns><see cref="DeleteMachineGroupInfoResponse"/></returns>
        public async Task<DeleteMachineGroupInfoResponse> DeleteMachineGroupInfo(DeleteMachineGroupInfoRequest req)
        {
             JsonResponseModel<DeleteMachineGroupInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMachineGroupInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMachineGroupInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于删除机器组信息
        /// </summary>
        /// <param name="req"><see cref="DeleteMachineGroupInfoRequest"/></param>
        /// <returns><see cref="DeleteMachineGroupInfoResponse"/></returns>
        public DeleteMachineGroupInfoResponse DeleteMachineGroupInfoSync(DeleteMachineGroupInfoRequest req)
        {
             JsonResponseModel<DeleteMachineGroupInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteMachineGroupInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMachineGroupInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于删除定时SQL分析任务
        /// </summary>
        /// <param name="req"><see cref="DeleteScheduledSqlRequest"/></param>
        /// <returns><see cref="DeleteScheduledSqlResponse"/></returns>
        public async Task<DeleteScheduledSqlResponse> DeleteScheduledSql(DeleteScheduledSqlRequest req)
        {
             JsonResponseModel<DeleteScheduledSqlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteScheduledSql");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteScheduledSqlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于删除定时SQL分析任务
        /// </summary>
        /// <param name="req"><see cref="DeleteScheduledSqlRequest"/></param>
        /// <returns><see cref="DeleteScheduledSqlResponse"/></returns>
        public DeleteScheduledSqlResponse DeleteScheduledSqlSync(DeleteScheduledSqlRequest req)
        {
             JsonResponseModel<DeleteScheduledSqlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteScheduledSql");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteScheduledSqlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除投递COS任务
        /// </summary>
        /// <param name="req"><see cref="DeleteShipperRequest"/></param>
        /// <returns><see cref="DeleteShipperResponse"/></returns>
        public async Task<DeleteShipperResponse> DeleteShipper(DeleteShipperRequest req)
        {
             JsonResponseModel<DeleteShipperResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteShipper");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteShipperResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除投递COS任务
        /// </summary>
        /// <param name="req"><see cref="DeleteShipperRequest"/></param>
        /// <returns><see cref="DeleteShipperResponse"/></returns>
        public DeleteShipperResponse DeleteShipperSync(DeleteShipperRequest req)
        {
             JsonResponseModel<DeleteShipperResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteShipper");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteShipperResponse>>(strResp);
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
        /// 该接口用于获取通知渠道组列表
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
        /// 该接口用于获取通知渠道组列表
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
        /// 本接口用于获取告警策略列表。
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
        /// 本接口用于获取告警策略列表。
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
        /// 获取告警历史，例如今天未恢复的告警
        /// </summary>
        /// <param name="req"><see cref="DescribeAlertRecordHistoryRequest"/></param>
        /// <returns><see cref="DescribeAlertRecordHistoryResponse"/></returns>
        public async Task<DescribeAlertRecordHistoryResponse> DescribeAlertRecordHistory(DescribeAlertRecordHistoryRequest req)
        {
             JsonResponseModel<DescribeAlertRecordHistoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAlertRecordHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlertRecordHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取告警历史，例如今天未恢复的告警
        /// </summary>
        /// <param name="req"><see cref="DescribeAlertRecordHistoryRequest"/></param>
        /// <returns><see cref="DescribeAlertRecordHistoryResponse"/></returns>
        public DescribeAlertRecordHistoryResponse DescribeAlertRecordHistorySync(DescribeAlertRecordHistoryRequest req)
        {
             JsonResponseModel<DescribeAlertRecordHistoryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAlertRecordHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlertRecordHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于获取特殊采集配置，特殊采集配置应用于自建K8S环境的采集Agent
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigExtrasRequest"/></param>
        /// <returns><see cref="DescribeConfigExtrasResponse"/></returns>
        public async Task<DescribeConfigExtrasResponse> DescribeConfigExtras(DescribeConfigExtrasRequest req)
        {
             JsonResponseModel<DescribeConfigExtrasResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeConfigExtras");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConfigExtrasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于获取特殊采集配置，特殊采集配置应用于自建K8S环境的采集Agent
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigExtrasRequest"/></param>
        /// <returns><see cref="DescribeConfigExtrasResponse"/></returns>
        public DescribeConfigExtrasResponse DescribeConfigExtrasSync(DescribeConfigExtrasRequest req)
        {
             JsonResponseModel<DescribeConfigExtrasResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeConfigExtras");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConfigExtrasResponse>>(strResp);
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
        /// 本接口用于获取投递配置
        /// </summary>
        /// <param name="req"><see cref="DescribeConsumerRequest"/></param>
        /// <returns><see cref="DescribeConsumerResponse"/></returns>
        public async Task<DescribeConsumerResponse> DescribeConsumer(DescribeConsumerRequest req)
        {
             JsonResponseModel<DescribeConsumerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeConsumer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConsumerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于获取投递配置
        /// </summary>
        /// <param name="req"><see cref="DescribeConsumerRequest"/></param>
        /// <returns><see cref="DescribeConsumerResponse"/></returns>
        public DescribeConsumerResponse DescribeConsumerSync(DescribeConsumerRequest req)
        {
             JsonResponseModel<DescribeConsumerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeConsumer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConsumerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于获取cos导入配置
        /// </summary>
        /// <param name="req"><see cref="DescribeCosRechargesRequest"/></param>
        /// <returns><see cref="DescribeCosRechargesResponse"/></returns>
        public async Task<DescribeCosRechargesResponse> DescribeCosRecharges(DescribeCosRechargesRequest req)
        {
             JsonResponseModel<DescribeCosRechargesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCosRecharges");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCosRechargesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于获取cos导入配置
        /// </summary>
        /// <param name="req"><see cref="DescribeCosRechargesRequest"/></param>
        /// <returns><see cref="DescribeCosRechargesResponse"/></returns>
        public DescribeCosRechargesResponse DescribeCosRechargesSync(DescribeCosRechargesRequest req)
        {
             JsonResponseModel<DescribeCosRechargesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCosRecharges");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCosRechargesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于获取仪表盘
        /// </summary>
        /// <param name="req"><see cref="DescribeDashboardsRequest"/></param>
        /// <returns><see cref="DescribeDashboardsResponse"/></returns>
        public async Task<DescribeDashboardsResponse> DescribeDashboards(DescribeDashboardsRequest req)
        {
             JsonResponseModel<DescribeDashboardsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDashboards");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDashboardsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于获取仪表盘
        /// </summary>
        /// <param name="req"><see cref="DescribeDashboardsRequest"/></param>
        /// <returns><see cref="DescribeDashboardsResponse"/></returns>
        public DescribeDashboardsResponse DescribeDashboardsSync(DescribeDashboardsRequest req)
        {
             JsonResponseModel<DescribeDashboardsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDashboards");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDashboardsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于获取数据加工任务列表基本信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataTransformInfoRequest"/></param>
        /// <returns><see cref="DescribeDataTransformInfoResponse"/></returns>
        public async Task<DescribeDataTransformInfoResponse> DescribeDataTransformInfo(DescribeDataTransformInfoRequest req)
        {
             JsonResponseModel<DescribeDataTransformInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDataTransformInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataTransformInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于获取数据加工任务列表基本信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataTransformInfoRequest"/></param>
        /// <returns><see cref="DescribeDataTransformInfoResponse"/></returns>
        public DescribeDataTransformInfoResponse DescribeDataTransformInfoSync(DescribeDataTransformInfoRequest req)
        {
             JsonResponseModel<DescribeDataTransformInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDataTransformInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataTransformInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于获取日志下载任务列表
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
        /// 本接口用于获取日志下载任务列表
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
        /// 获取Kafka协议消费信息
        /// </summary>
        /// <param name="req"><see cref="DescribeKafkaConsumerRequest"/></param>
        /// <returns><see cref="DescribeKafkaConsumerResponse"/></returns>
        public async Task<DescribeKafkaConsumerResponse> DescribeKafkaConsumer(DescribeKafkaConsumerRequest req)
        {
             JsonResponseModel<DescribeKafkaConsumerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeKafkaConsumer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKafkaConsumerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取Kafka协议消费信息
        /// </summary>
        /// <param name="req"><see cref="DescribeKafkaConsumerRequest"/></param>
        /// <returns><see cref="DescribeKafkaConsumerResponse"/></returns>
        public DescribeKafkaConsumerResponse DescribeKafkaConsumerSync(DescribeKafkaConsumerRequest req)
        {
             JsonResponseModel<DescribeKafkaConsumerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeKafkaConsumer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKafkaConsumerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于获取Kafka数据订阅任务
        /// </summary>
        /// <param name="req"><see cref="DescribeKafkaRechargesRequest"/></param>
        /// <returns><see cref="DescribeKafkaRechargesResponse"/></returns>
        public async Task<DescribeKafkaRechargesResponse> DescribeKafkaRecharges(DescribeKafkaRechargesRequest req)
        {
             JsonResponseModel<DescribeKafkaRechargesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeKafkaRecharges");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKafkaRechargesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于获取Kafka数据订阅任务
        /// </summary>
        /// <param name="req"><see cref="DescribeKafkaRechargesRequest"/></param>
        /// <returns><see cref="DescribeKafkaRechargesResponse"/></returns>
        public DescribeKafkaRechargesResponse DescribeKafkaRechargesSync(DescribeKafkaRechargesRequest req)
        {
             JsonResponseModel<DescribeKafkaRechargesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeKafkaRecharges");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKafkaRechargesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于获取kafka用户信息
        /// </summary>
        /// <param name="req"><see cref="DescribeKafkaUserRequest"/></param>
        /// <returns><see cref="DescribeKafkaUserResponse"/></returns>
        public async Task<DescribeKafkaUserResponse> DescribeKafkaUser(DescribeKafkaUserRequest req)
        {
             JsonResponseModel<DescribeKafkaUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeKafkaUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKafkaUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于获取kafka用户信息
        /// </summary>
        /// <param name="req"><see cref="DescribeKafkaUserRequest"/></param>
        /// <returns><see cref="DescribeKafkaUserResponse"/></returns>
        public DescribeKafkaUserResponse DescribeKafkaUserSync(DescribeKafkaUserRequest req)
        {
             JsonResponseModel<DescribeKafkaUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeKafkaUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeKafkaUserResponse>>(strResp);
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
        /// 本接口用于构建日志数量直方图
        /// </summary>
        /// <param name="req"><see cref="DescribeLogHistogramRequest"/></param>
        /// <returns><see cref="DescribeLogHistogramResponse"/></returns>
        public async Task<DescribeLogHistogramResponse> DescribeLogHistogram(DescribeLogHistogramRequest req)
        {
             JsonResponseModel<DescribeLogHistogramResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLogHistogram");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogHistogramResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于构建日志数量直方图
        /// </summary>
        /// <param name="req"><see cref="DescribeLogHistogramRequest"/></param>
        /// <returns><see cref="DescribeLogHistogramResponse"/></returns>
        public DescribeLogHistogramResponse DescribeLogHistogramSync(DescribeLogHistogramRequest req)
        {
             JsonResponseModel<DescribeLogHistogramResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLogHistogram");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogHistogramResponse>>(strResp);
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
        /// 本接口用于获取定时SQL分析任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScheduledSqlInfoRequest"/></param>
        /// <returns><see cref="DescribeScheduledSqlInfoResponse"/></returns>
        public async Task<DescribeScheduledSqlInfoResponse> DescribeScheduledSqlInfo(DescribeScheduledSqlInfoRequest req)
        {
             JsonResponseModel<DescribeScheduledSqlInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScheduledSqlInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScheduledSqlInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于获取定时SQL分析任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScheduledSqlInfoRequest"/></param>
        /// <returns><see cref="DescribeScheduledSqlInfoResponse"/></returns>
        public DescribeScheduledSqlInfoResponse DescribeScheduledSqlInfoSync(DescribeScheduledSqlInfoRequest req)
        {
             JsonResponseModel<DescribeScheduledSqlInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScheduledSqlInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScheduledSqlInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取投递任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeShipperTasksRequest"/></param>
        /// <returns><see cref="DescribeShipperTasksResponse"/></returns>
        public async Task<DescribeShipperTasksResponse> DescribeShipperTasks(DescribeShipperTasksRequest req)
        {
             JsonResponseModel<DescribeShipperTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeShipperTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeShipperTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取投递任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeShipperTasksRequest"/></param>
        /// <returns><see cref="DescribeShipperTasksResponse"/></returns>
        public DescribeShipperTasksResponse DescribeShipperTasksSync(DescribeShipperTasksRequest req)
        {
             JsonResponseModel<DescribeShipperTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeShipperTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeShipperTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取投递到COS的任务配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeShippersRequest"/></param>
        /// <returns><see cref="DescribeShippersResponse"/></returns>
        public async Task<DescribeShippersResponse> DescribeShippers(DescribeShippersRequest req)
        {
             JsonResponseModel<DescribeShippersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeShippers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeShippersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取投递到COS的任务配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeShippersRequest"/></param>
        /// <returns><see cref="DescribeShippersResponse"/></returns>
        public DescribeShippersResponse DescribeShippersSync(DescribeShippersRequest req)
        {
             JsonResponseModel<DescribeShippersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeShippers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeShippersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于获取日志主题列表，支持分页
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
        /// 本接口用于获取日志主题列表，支持分页
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
        /// 本接口用于获取告警策略执行详情
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
        /// 本接口用于获取告警策略执行详情
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
        /// 该接口用于修改通知渠道组
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
        /// 该接口用于修改通知渠道组
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
        /// 本接口用于修改特殊采集配置任务，特殊采集配置应用于自建K8S环境的采集Agent
        /// </summary>
        /// <param name="req"><see cref="ModifyConfigExtraRequest"/></param>
        /// <returns><see cref="ModifyConfigExtraResponse"/></returns>
        public async Task<ModifyConfigExtraResponse> ModifyConfigExtra(ModifyConfigExtraRequest req)
        {
             JsonResponseModel<ModifyConfigExtraResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyConfigExtra");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyConfigExtraResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于修改特殊采集配置任务，特殊采集配置应用于自建K8S环境的采集Agent
        /// </summary>
        /// <param name="req"><see cref="ModifyConfigExtraRequest"/></param>
        /// <returns><see cref="ModifyConfigExtraResponse"/></returns>
        public ModifyConfigExtraResponse ModifyConfigExtraSync(ModifyConfigExtraRequest req)
        {
             JsonResponseModel<ModifyConfigExtraResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyConfigExtra");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyConfigExtraResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于修改投递任务
        /// </summary>
        /// <param name="req"><see cref="ModifyConsumerRequest"/></param>
        /// <returns><see cref="ModifyConsumerResponse"/></returns>
        public async Task<ModifyConsumerResponse> ModifyConsumer(ModifyConsumerRequest req)
        {
             JsonResponseModel<ModifyConsumerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyConsumer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyConsumerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于修改投递任务
        /// </summary>
        /// <param name="req"><see cref="ModifyConsumerRequest"/></param>
        /// <returns><see cref="ModifyConsumerResponse"/></returns>
        public ModifyConsumerResponse ModifyConsumerSync(ModifyConsumerRequest req)
        {
             JsonResponseModel<ModifyConsumerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyConsumer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyConsumerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于修改cos导入任务
        /// </summary>
        /// <param name="req"><see cref="ModifyCosRechargeRequest"/></param>
        /// <returns><see cref="ModifyCosRechargeResponse"/></returns>
        public async Task<ModifyCosRechargeResponse> ModifyCosRecharge(ModifyCosRechargeRequest req)
        {
             JsonResponseModel<ModifyCosRechargeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCosRecharge");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCosRechargeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于修改cos导入任务
        /// </summary>
        /// <param name="req"><see cref="ModifyCosRechargeRequest"/></param>
        /// <returns><see cref="ModifyCosRechargeResponse"/></returns>
        public ModifyCosRechargeResponse ModifyCosRechargeSync(ModifyCosRechargeRequest req)
        {
             JsonResponseModel<ModifyCosRechargeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCosRecharge");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCosRechargeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于修改数据加工任务
        /// </summary>
        /// <param name="req"><see cref="ModifyDataTransformRequest"/></param>
        /// <returns><see cref="ModifyDataTransformResponse"/></returns>
        public async Task<ModifyDataTransformResponse> ModifyDataTransform(ModifyDataTransformRequest req)
        {
             JsonResponseModel<ModifyDataTransformResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDataTransform");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDataTransformResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于修改数据加工任务
        /// </summary>
        /// <param name="req"><see cref="ModifyDataTransformRequest"/></param>
        /// <returns><see cref="ModifyDataTransformResponse"/></returns>
        public ModifyDataTransformResponse ModifyDataTransformSync(ModifyDataTransformRequest req)
        {
             JsonResponseModel<ModifyDataTransformResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDataTransform");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDataTransformResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于修改索引配置，该接口除受默认接口请求频率限制外，针对单个日志主题，并发数不能超过1，即同一时间同一个日志主题只能有一个正在执行的索引配置修改操作。
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
        /// 本接口用于修改索引配置，该接口除受默认接口请求频率限制外，针对单个日志主题，并发数不能超过1，即同一时间同一个日志主题只能有一个正在执行的索引配置修改操作。
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
        /// 修改Kafka协议消费信息
        /// </summary>
        /// <param name="req"><see cref="ModifyKafkaConsumerRequest"/></param>
        /// <returns><see cref="ModifyKafkaConsumerResponse"/></returns>
        public async Task<ModifyKafkaConsumerResponse> ModifyKafkaConsumer(ModifyKafkaConsumerRequest req)
        {
             JsonResponseModel<ModifyKafkaConsumerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyKafkaConsumer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyKafkaConsumerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改Kafka协议消费信息
        /// </summary>
        /// <param name="req"><see cref="ModifyKafkaConsumerRequest"/></param>
        /// <returns><see cref="ModifyKafkaConsumerResponse"/></returns>
        public ModifyKafkaConsumerResponse ModifyKafkaConsumerSync(ModifyKafkaConsumerRequest req)
        {
             JsonResponseModel<ModifyKafkaConsumerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyKafkaConsumer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyKafkaConsumerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于修改Kafka数据订阅任务
        /// </summary>
        /// <param name="req"><see cref="ModifyKafkaRechargeRequest"/></param>
        /// <returns><see cref="ModifyKafkaRechargeResponse"/></returns>
        public async Task<ModifyKafkaRechargeResponse> ModifyKafkaRecharge(ModifyKafkaRechargeRequest req)
        {
             JsonResponseModel<ModifyKafkaRechargeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyKafkaRecharge");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyKafkaRechargeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于修改Kafka数据订阅任务
        /// </summary>
        /// <param name="req"><see cref="ModifyKafkaRechargeRequest"/></param>
        /// <returns><see cref="ModifyKafkaRechargeResponse"/></returns>
        public ModifyKafkaRechargeResponse ModifyKafkaRechargeSync(ModifyKafkaRechargeRequest req)
        {
             JsonResponseModel<ModifyKafkaRechargeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyKafkaRecharge");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyKafkaRechargeResponse>>(strResp);
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
        /// 本接口用于修改定时SQL分析任务
        /// </summary>
        /// <param name="req"><see cref="ModifyScheduledSqlRequest"/></param>
        /// <returns><see cref="ModifyScheduledSqlResponse"/></returns>
        public async Task<ModifyScheduledSqlResponse> ModifyScheduledSql(ModifyScheduledSqlRequest req)
        {
             JsonResponseModel<ModifyScheduledSqlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyScheduledSql");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyScheduledSqlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于修改定时SQL分析任务
        /// </summary>
        /// <param name="req"><see cref="ModifyScheduledSqlRequest"/></param>
        /// <returns><see cref="ModifyScheduledSqlResponse"/></returns>
        public ModifyScheduledSqlResponse ModifyScheduledSqlSync(ModifyScheduledSqlRequest req)
        {
             JsonResponseModel<ModifyScheduledSqlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyScheduledSql");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyScheduledSqlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改现有的投递规则，客户如果使用此接口，需要自行处理CLS对指定bucket的写权限。
        /// </summary>
        /// <param name="req"><see cref="ModifyShipperRequest"/></param>
        /// <returns><see cref="ModifyShipperResponse"/></returns>
        public async Task<ModifyShipperResponse> ModifyShipper(ModifyShipperRequest req)
        {
             JsonResponseModel<ModifyShipperResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyShipper");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyShipperResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改现有的投递规则，客户如果使用此接口，需要自行处理CLS对指定bucket的写权限。
        /// </summary>
        /// <param name="req"><see cref="ModifyShipperRequest"/></param>
        /// <returns><see cref="ModifyShipperResponse"/></returns>
        public ModifyShipperResponse ModifyShipperSync(ModifyShipperRequest req)
        {
             JsonResponseModel<ModifyShipperResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyShipper");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyShipperResponse>>(strResp);
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
        /// 打开Kafka协议消费功能
        /// </summary>
        /// <param name="req"><see cref="OpenKafkaConsumerRequest"/></param>
        /// <returns><see cref="OpenKafkaConsumerResponse"/></returns>
        public async Task<OpenKafkaConsumerResponse> OpenKafkaConsumer(OpenKafkaConsumerRequest req)
        {
             JsonResponseModel<OpenKafkaConsumerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "OpenKafkaConsumer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenKafkaConsumerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 打开Kafka协议消费功能
        /// </summary>
        /// <param name="req"><see cref="OpenKafkaConsumerRequest"/></param>
        /// <returns><see cref="OpenKafkaConsumerResponse"/></returns>
        public OpenKafkaConsumerResponse OpenKafkaConsumerSync(OpenKafkaConsumerRequest req)
        {
             JsonResponseModel<OpenKafkaConsumerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "OpenKafkaConsumer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenKafkaConsumerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于预览Kafka数据订阅任务客户日志信息
        /// </summary>
        /// <param name="req"><see cref="PreviewKafkaRechargeRequest"/></param>
        /// <returns><see cref="PreviewKafkaRechargeResponse"/></returns>
        public async Task<PreviewKafkaRechargeResponse> PreviewKafkaRecharge(PreviewKafkaRechargeRequest req)
        {
             JsonResponseModel<PreviewKafkaRechargeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PreviewKafkaRecharge");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PreviewKafkaRechargeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于预览Kafka数据订阅任务客户日志信息
        /// </summary>
        /// <param name="req"><see cref="PreviewKafkaRechargeRequest"/></param>
        /// <returns><see cref="PreviewKafkaRechargeResponse"/></returns>
        public PreviewKafkaRechargeResponse PreviewKafkaRechargeSync(PreviewKafkaRechargeRequest req)
        {
             JsonResponseModel<PreviewKafkaRechargeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PreviewKafkaRecharge");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PreviewKafkaRechargeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定时刻指标的最新值
        /// </summary>
        /// <param name="req"><see cref="QueryMetricRequest"/></param>
        /// <returns><see cref="QueryMetricResponse"/></returns>
        public async Task<QueryMetricResponse> QueryMetric(QueryMetricRequest req)
        {
             JsonResponseModel<QueryMetricResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryMetric");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryMetricResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定时刻指标的最新值
        /// </summary>
        /// <param name="req"><see cref="QueryMetricRequest"/></param>
        /// <returns><see cref="QueryMetricResponse"/></returns>
        public QueryMetricResponse QueryMetricSync(QueryMetricRequest req)
        {
             JsonResponseModel<QueryMetricResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryMetric");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryMetricResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定时间范围内指标的变化趋势
        /// </summary>
        /// <param name="req"><see cref="QueryRangeMetricRequest"/></param>
        /// <returns><see cref="QueryRangeMetricResponse"/></returns>
        public async Task<QueryRangeMetricResponse> QueryRangeMetric(QueryRangeMetricRequest req)
        {
             JsonResponseModel<QueryRangeMetricResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryRangeMetric");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryRangeMetricResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定时间范围内指标的变化趋势
        /// </summary>
        /// <param name="req"><see cref="QueryRangeMetricRequest"/></param>
        /// <returns><see cref="QueryRangeMetricResponse"/></returns>
        public QueryRangeMetricResponse QueryRangeMetricSync(QueryRangeMetricRequest req)
        {
             JsonResponseModel<QueryRangeMetricResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryRangeMetric");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryRangeMetricResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重试失败的投递任务
        /// </summary>
        /// <param name="req"><see cref="RetryShipperTaskRequest"/></param>
        /// <returns><see cref="RetryShipperTaskResponse"/></returns>
        public async Task<RetryShipperTaskResponse> RetryShipperTask(RetryShipperTaskRequest req)
        {
             JsonResponseModel<RetryShipperTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RetryShipperTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RetryShipperTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重试失败的投递任务
        /// </summary>
        /// <param name="req"><see cref="RetryShipperTaskRequest"/></param>
        /// <returns><see cref="RetryShipperTaskResponse"/></returns>
        public RetryShipperTaskResponse RetryShipperTaskSync(RetryShipperTaskRequest req)
        {
             JsonResponseModel<RetryShipperTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RetryShipperTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RetryShipperTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于预览cos导入信息
        /// </summary>
        /// <param name="req"><see cref="SearchCosRechargeInfoRequest"/></param>
        /// <returns><see cref="SearchCosRechargeInfoResponse"/></returns>
        public async Task<SearchCosRechargeInfoResponse> SearchCosRechargeInfo(SearchCosRechargeInfoRequest req)
        {
             JsonResponseModel<SearchCosRechargeInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SearchCosRechargeInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchCosRechargeInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于预览cos导入信息
        /// </summary>
        /// <param name="req"><see cref="SearchCosRechargeInfoRequest"/></param>
        /// <returns><see cref="SearchCosRechargeInfoResponse"/></returns>
        public SearchCosRechargeInfoResponse SearchCosRechargeInfoSync(SearchCosRechargeInfoRequest req)
        {
             JsonResponseModel<SearchCosRechargeInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SearchCosRechargeInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchCosRechargeInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于检索分析日志, 该接口除受默认接口请求频率限制外，针对单个日志主题，查询并发数不能超过15。
        /// 
        /// API返回数据包最大49MB，建议启用 gzip 压缩（HTTP Request Header Accept-Encoding:gzip）。
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
        /// 本接口用于检索分析日志, 该接口除受默认接口请求频率限制外，针对单个日志主题，查询并发数不能超过15。
        /// 
        /// API返回数据包最大49MB，建议启用 gzip 压缩（HTTP Request Header Accept-Encoding:gzip）。
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

        /// <summary>
        /// ## 提示
        /// 为了保障您日志数据的可靠性以及更高效地使用日志服务，建议您使用CLS优化后的接口[上传结构化日志](https://cloud.tencent.com/document/product/614/16873)。
        /// 
        /// 同时我们给此接口专门优化定制了多个语言版本的SDK供您选择，SDK提供统一的异步发送、资源控制、自动重试、优雅关闭、感知上报等功能，使上报日志功能更完善，详情请参考[SDK采集](https://cloud.tencent.com/document/product/614/67157)。
        /// 
        /// 同时云API上传日志接口也支持同步上传日志数据，如果您选择继续使用此接口请参考下文。
        /// 
        /// ## 功能描述
        /// 
        /// 本接口用于将日志写入到指定的日志主题。
        /// 
        /// 日志服务提供以下两种模式：
        /// 
        /// #### 负载均衡模式
        /// 
        /// 系统根据当前日志主题下所有可读写的分区，遵循负载均衡原则自动分配写入的目标分区。该模式适合消费不保序的场景。
        /// 
        /// #### 哈希路由模式
        /// 
        /// 系统根据携带的哈希值（X-CLS-HashKey）将数据写入到符合范围要求的目标分区。例如，可以将某个日志源端通过 hashkey 与某个主题分区强绑定，这样可以保证数据在该分区上写入和消费是严格保序的。
        /// 
        ///                  
        /// 
        /// #### 输入参数(pb二进制流，位于body中)
        /// 
        /// | 字段名       | 类型    | 位置 | 必须 | 含义                                                         |
        /// | ------------ | ------- | ---- | ---- | ------------------------------------------------------------ |
        /// | logGroupList | message | pb   | 是   | logGroup 列表，封装好的日志组列表内容，建议 logGroup 数量不要超过5个 |
        /// 
        /// LogGroup 说明：
        /// 
        /// | 字段名      | 是否必选 | 含义                                                         |
        /// | ----------- | -------- | ------------------------------------------------------------ |
        /// | logs        | 是       | 日志数组，表示有多个 Log 组成的集合，一个 Log 表示一条日志，一个 LogGroup 中 Log 个数不能超过10000 |
        /// | contextFlow | 否       | LogGroup 的唯一ID，需要使用上下文功能时传入。格式："{上下文ID}-{LogGroupID}"。<br>上下文ID：唯一标识一个上下文（连续滚动的一系列日志文件，或者是需要保序的一系列日志），16进制64位整型字符串。<br>LogGroupID：连续递增的一串整型，16进制64位整型字符串。样例："102700A66102516A-59F59"。                        |
        /// | filename    | 否       | 日志文件名                                                   |
        /// | source      | 否       | 日志来源，一般使用机器 IP 作为标识                           |
        /// | logTags     | 否       | 日志的标签列表                                               |
        /// 
        /// Log 说明：
        /// 
        /// | 字段名   | 是否必选 | 含义                                                         |
        /// | -------- | -------- | ------------------------------------------------------------ |
        /// | time     | 是       | 日志时间（Unix 格式时间戳），支持秒、毫秒，建议采用毫秒      |
        /// | contents | 否       | key-value 格式的日志内容，表示一条日志里的多个 key-value 组合 |
        /// 
        /// Content 说明：
        /// 
        /// | 字段名 | 是否必选 | 含义                                                         |
        /// | ------ | -------- | ------------------------------------------------------------ |
        /// | key    | 是       | 单条日志里某个字段组的 key 值，不能以`_`开头                 |
        /// | value  | 是       | 单条日志某个字段组的 value 值，单条日志 value 不能超过1MB，LogGroup 中所有 value 总和不能超过5MB |
        /// 
        /// LogTag 说明：
        /// 
        /// | 字段名 | 是否必选 | 含义                             |
        /// | ------ | -------- | -------------------------------- |
        /// | key    | 是       | 自定义的标签 key                 |
        /// | value  | 是       | 自定义的标签 key 对应的 value 值 |
        /// 
        /// ## PB 编译示例
        /// 
        /// 本示例将说明如何使用官方 protoc 编译工具将 PB 描述文件 编译生成为 C++ 语言可调用的上传日志接口。
        /// 
        /// > ?目前 protoc 官方支持 Java、C++、Python 等语言的编译，详情请参见 [protoc](https://github.com/protocolbuffers/protobuf)。
        /// 
        /// #### 1. 安装 Protocol Buffer
        /// 
        /// 下载 [Protocol Buffer](https://main.qcloudimg.com/raw/d7810aaf8b3073fbbc9d4049c21532aa/protobuf-2.6.1.tar.gz) ，解压并安装。示例版本为 protobuf 2.6.1，环境为 Centos 7.3 系统。 解压`protobuf-2.6.1.tar.gz`压缩包至`/usr/local`目录并进入该目录，执行命令如下：
        /// 
        /// ```
        /// tar -zxvf protobuf-2.6.1.tar.gz -C /usr/local/ && cd /usr/local/protobuf-2.6.1
        /// ```
        /// 
        /// 开始编译和安装，配置环境变量，执行命令如下：
        /// 
        /// ```
        /// [root@VM_0_8_centos protobuf-2.6.1]# ./configure 
        /// [root@VM_0_8_centos protobuf-2.6.1]# make && make install
        /// [root@VM_0_8_centos protobuf-2.6.1]# export PATH=$PATH:/usr/local/protobuf-2.6.1/bin
        /// ```
        /// 
        /// 编译成功后，您可以使用以下命令查看版本：
        /// 
        /// ```
        /// [root@VM_0_8_centos protobuf-2.6.1]# protoc --version
        /// liprotoc 2.6.1
        /// ```
        /// 
        /// #### 2. 创建 PB 描述文件
        /// 
        /// PB 描述文件是通信双方约定的数据交换格式，上传日志时须将规定的协议格式编译成对应语言版本的调用接口，然后添加到工程代码里，详情请参见 [protoc](https://github.com/protocolbuffers/protobuf) 。
        /// 
        /// 以日志服务所规定的 PB 数据格式内容为准， 在本地创建 PB 消息描述文件 cls.proto。
        /// 
        /// > !PB 描述文件内容不可更改，且文件名须以`.proto`结尾。
        /// 
        /// cls.proto 内容（PB 描述文件）如下：
        /// 
        /// ```
        /// package cls;
        /// 
        /// message Log
        /// {
        ///     message Content
        ///     {
        ///         required string key   = 1; // 每组字段的 key
        ///         required string value = 2; // 每组字段的 value
        ///     }
        ///     required int64   time     = 1; // 时间戳，UNIX时间格式
        ///     repeated Content contents = 2; // 一条日志里的多个kv组合
        /// }
        /// 
        /// message LogTag
        /// {
        ///     required string key       = 1;
        ///     required string value     = 2;
        /// }
        /// 
        /// message LogGroup
        /// {
        ///     repeated Log    logs        = 1; // 多条日志合成的日志数组
        ///     optional string contextFlow = 2; // 目前暂无效用
        ///     optional string filename    = 3; // 日志文件名
        ///     optional string source      = 4; // 日志来源，一般使用机器IP
        ///     repeated LogTag logTags     = 5;
        /// }
        /// 
        /// message LogGroupList
        /// {
        ///     repeated LogGroup logGroupList = 1; // 日志组列表
        /// }
        /// ```
        /// 
        /// #### 3. 编译生成
        /// 
        /// 此例中，使用 proto 编译器生成 C++ 语言的文件，在 cls.proto 文件的同一目录下，执行如下编译命令：
        /// 
        /// ```
        /// protoc --cpp_out=./ ./cls.proto 
        /// ```
        /// 
        /// > ?`--cpp_out=./`表示编译成 cpp 格式并输出当前目录下，`./cls.proto`表示位于当前目录下的 cls.proto 描述文件。
        /// 
        /// 编译成功后，会输出对应语言的代码文件。此例会生成 cls.pb.h 头文件和 [cls.pb.cc](http://cls.pb.cc) 代码实现文件，如下所示：
        /// 
        /// ```
        /// [root@VM_0_8_centos protobuf-2.6.1]# protoc --cpp_out=./ ./cls.proto
        /// [root@VM_0_8_centos protobuf-2.6.1]# ls
        /// cls.pb.cc cls.pb.h cls.proto
        /// ```
        /// 
        /// #### 4. 调用
        /// 
        /// 将生成的 cls.pb.h 头文件引入代码中，调用接口进行数据格式封装。
        /// </summary>
        /// <param name="req"><see cref="UploadLogRequest"/></param>
        /// <returns><see cref="UploadLogResponse"/></returns>
        public async Task<UploadLogResponse> UploadLog(UploadLogRequest req)
        {
             JsonResponseModel<UploadLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UploadLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ## 提示
        /// 为了保障您日志数据的可靠性以及更高效地使用日志服务，建议您使用CLS优化后的接口[上传结构化日志](https://cloud.tencent.com/document/product/614/16873)。
        /// 
        /// 同时我们给此接口专门优化定制了多个语言版本的SDK供您选择，SDK提供统一的异步发送、资源控制、自动重试、优雅关闭、感知上报等功能，使上报日志功能更完善，详情请参考[SDK采集](https://cloud.tencent.com/document/product/614/67157)。
        /// 
        /// 同时云API上传日志接口也支持同步上传日志数据，如果您选择继续使用此接口请参考下文。
        /// 
        /// ## 功能描述
        /// 
        /// 本接口用于将日志写入到指定的日志主题。
        /// 
        /// 日志服务提供以下两种模式：
        /// 
        /// #### 负载均衡模式
        /// 
        /// 系统根据当前日志主题下所有可读写的分区，遵循负载均衡原则自动分配写入的目标分区。该模式适合消费不保序的场景。
        /// 
        /// #### 哈希路由模式
        /// 
        /// 系统根据携带的哈希值（X-CLS-HashKey）将数据写入到符合范围要求的目标分区。例如，可以将某个日志源端通过 hashkey 与某个主题分区强绑定，这样可以保证数据在该分区上写入和消费是严格保序的。
        /// 
        ///                  
        /// 
        /// #### 输入参数(pb二进制流，位于body中)
        /// 
        /// | 字段名       | 类型    | 位置 | 必须 | 含义                                                         |
        /// | ------------ | ------- | ---- | ---- | ------------------------------------------------------------ |
        /// | logGroupList | message | pb   | 是   | logGroup 列表，封装好的日志组列表内容，建议 logGroup 数量不要超过5个 |
        /// 
        /// LogGroup 说明：
        /// 
        /// | 字段名      | 是否必选 | 含义                                                         |
        /// | ----------- | -------- | ------------------------------------------------------------ |
        /// | logs        | 是       | 日志数组，表示有多个 Log 组成的集合，一个 Log 表示一条日志，一个 LogGroup 中 Log 个数不能超过10000 |
        /// | contextFlow | 否       | LogGroup 的唯一ID，需要使用上下文功能时传入。格式："{上下文ID}-{LogGroupID}"。<br>上下文ID：唯一标识一个上下文（连续滚动的一系列日志文件，或者是需要保序的一系列日志），16进制64位整型字符串。<br>LogGroupID：连续递增的一串整型，16进制64位整型字符串。样例："102700A66102516A-59F59"。                        |
        /// | filename    | 否       | 日志文件名                                                   |
        /// | source      | 否       | 日志来源，一般使用机器 IP 作为标识                           |
        /// | logTags     | 否       | 日志的标签列表                                               |
        /// 
        /// Log 说明：
        /// 
        /// | 字段名   | 是否必选 | 含义                                                         |
        /// | -------- | -------- | ------------------------------------------------------------ |
        /// | time     | 是       | 日志时间（Unix 格式时间戳），支持秒、毫秒，建议采用毫秒      |
        /// | contents | 否       | key-value 格式的日志内容，表示一条日志里的多个 key-value 组合 |
        /// 
        /// Content 说明：
        /// 
        /// | 字段名 | 是否必选 | 含义                                                         |
        /// | ------ | -------- | ------------------------------------------------------------ |
        /// | key    | 是       | 单条日志里某个字段组的 key 值，不能以`_`开头                 |
        /// | value  | 是       | 单条日志某个字段组的 value 值，单条日志 value 不能超过1MB，LogGroup 中所有 value 总和不能超过5MB |
        /// 
        /// LogTag 说明：
        /// 
        /// | 字段名 | 是否必选 | 含义                             |
        /// | ------ | -------- | -------------------------------- |
        /// | key    | 是       | 自定义的标签 key                 |
        /// | value  | 是       | 自定义的标签 key 对应的 value 值 |
        /// 
        /// ## PB 编译示例
        /// 
        /// 本示例将说明如何使用官方 protoc 编译工具将 PB 描述文件 编译生成为 C++ 语言可调用的上传日志接口。
        /// 
        /// > ?目前 protoc 官方支持 Java、C++、Python 等语言的编译，详情请参见 [protoc](https://github.com/protocolbuffers/protobuf)。
        /// 
        /// #### 1. 安装 Protocol Buffer
        /// 
        /// 下载 [Protocol Buffer](https://main.qcloudimg.com/raw/d7810aaf8b3073fbbc9d4049c21532aa/protobuf-2.6.1.tar.gz) ，解压并安装。示例版本为 protobuf 2.6.1，环境为 Centos 7.3 系统。 解压`protobuf-2.6.1.tar.gz`压缩包至`/usr/local`目录并进入该目录，执行命令如下：
        /// 
        /// ```
        /// tar -zxvf protobuf-2.6.1.tar.gz -C /usr/local/ && cd /usr/local/protobuf-2.6.1
        /// ```
        /// 
        /// 开始编译和安装，配置环境变量，执行命令如下：
        /// 
        /// ```
        /// [root@VM_0_8_centos protobuf-2.6.1]# ./configure 
        /// [root@VM_0_8_centos protobuf-2.6.1]# make && make install
        /// [root@VM_0_8_centos protobuf-2.6.1]# export PATH=$PATH:/usr/local/protobuf-2.6.1/bin
        /// ```
        /// 
        /// 编译成功后，您可以使用以下命令查看版本：
        /// 
        /// ```
        /// [root@VM_0_8_centos protobuf-2.6.1]# protoc --version
        /// liprotoc 2.6.1
        /// ```
        /// 
        /// #### 2. 创建 PB 描述文件
        /// 
        /// PB 描述文件是通信双方约定的数据交换格式，上传日志时须将规定的协议格式编译成对应语言版本的调用接口，然后添加到工程代码里，详情请参见 [protoc](https://github.com/protocolbuffers/protobuf) 。
        /// 
        /// 以日志服务所规定的 PB 数据格式内容为准， 在本地创建 PB 消息描述文件 cls.proto。
        /// 
        /// > !PB 描述文件内容不可更改，且文件名须以`.proto`结尾。
        /// 
        /// cls.proto 内容（PB 描述文件）如下：
        /// 
        /// ```
        /// package cls;
        /// 
        /// message Log
        /// {
        ///     message Content
        ///     {
        ///         required string key   = 1; // 每组字段的 key
        ///         required string value = 2; // 每组字段的 value
        ///     }
        ///     required int64   time     = 1; // 时间戳，UNIX时间格式
        ///     repeated Content contents = 2; // 一条日志里的多个kv组合
        /// }
        /// 
        /// message LogTag
        /// {
        ///     required string key       = 1;
        ///     required string value     = 2;
        /// }
        /// 
        /// message LogGroup
        /// {
        ///     repeated Log    logs        = 1; // 多条日志合成的日志数组
        ///     optional string contextFlow = 2; // 目前暂无效用
        ///     optional string filename    = 3; // 日志文件名
        ///     optional string source      = 4; // 日志来源，一般使用机器IP
        ///     repeated LogTag logTags     = 5;
        /// }
        /// 
        /// message LogGroupList
        /// {
        ///     repeated LogGroup logGroupList = 1; // 日志组列表
        /// }
        /// ```
        /// 
        /// #### 3. 编译生成
        /// 
        /// 此例中，使用 proto 编译器生成 C++ 语言的文件，在 cls.proto 文件的同一目录下，执行如下编译命令：
        /// 
        /// ```
        /// protoc --cpp_out=./ ./cls.proto 
        /// ```
        /// 
        /// > ?`--cpp_out=./`表示编译成 cpp 格式并输出当前目录下，`./cls.proto`表示位于当前目录下的 cls.proto 描述文件。
        /// 
        /// 编译成功后，会输出对应语言的代码文件。此例会生成 cls.pb.h 头文件和 [cls.pb.cc](http://cls.pb.cc) 代码实现文件，如下所示：
        /// 
        /// ```
        /// [root@VM_0_8_centos protobuf-2.6.1]# protoc --cpp_out=./ ./cls.proto
        /// [root@VM_0_8_centos protobuf-2.6.1]# ls
        /// cls.pb.cc cls.pb.h cls.proto
        /// ```
        /// 
        /// #### 4. 调用
        /// 
        /// 将生成的 cls.pb.h 头文件引入代码中，调用接口进行数据格式封装。
        /// </summary>
        /// <param name="req"><see cref="UploadLogRequest"/></param>
        /// <returns><see cref="UploadLogResponse"/></returns>
        public UploadLogResponse UploadLogSync(UploadLogRequest req)
        {
             JsonResponseModel<UploadLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UploadLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}

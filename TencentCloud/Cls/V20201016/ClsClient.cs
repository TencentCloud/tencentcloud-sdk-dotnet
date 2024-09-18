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
       private const string sdkVersion = "SDK_NET_3.0.1090";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public ClsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 用于添加机器组信息
        /// </summary>
        /// <param name="req"><see cref="AddMachineGroupInfoRequest"/></param>
        /// <returns><see cref="AddMachineGroupInfoResponse"/></returns>
        public Task<AddMachineGroupInfoResponse> AddMachineGroupInfo(AddMachineGroupInfoRequest req)
        {
            return InternalRequestAsync<AddMachineGroupInfoResponse>(req, "AddMachineGroupInfo");
        }

        /// <summary>
        /// 用于添加机器组信息
        /// </summary>
        /// <param name="req"><see cref="AddMachineGroupInfoRequest"/></param>
        /// <returns><see cref="AddMachineGroupInfoResponse"/></returns>
        public AddMachineGroupInfoResponse AddMachineGroupInfoSync(AddMachineGroupInfoRequest req)
        {
            return InternalRequestAsync<AddMachineGroupInfoResponse>(req, "AddMachineGroupInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 应用采集配置到指定机器组
        /// </summary>
        /// <param name="req"><see cref="ApplyConfigToMachineGroupRequest"/></param>
        /// <returns><see cref="ApplyConfigToMachineGroupResponse"/></returns>
        public Task<ApplyConfigToMachineGroupResponse> ApplyConfigToMachineGroup(ApplyConfigToMachineGroupRequest req)
        {
            return InternalRequestAsync<ApplyConfigToMachineGroupResponse>(req, "ApplyConfigToMachineGroup");
        }

        /// <summary>
        /// 应用采集配置到指定机器组
        /// </summary>
        /// <param name="req"><see cref="ApplyConfigToMachineGroupRequest"/></param>
        /// <returns><see cref="ApplyConfigToMachineGroupResponse"/></returns>
        public ApplyConfigToMachineGroupResponse ApplyConfigToMachineGroupSync(ApplyConfigToMachineGroupRequest req)
        {
            return InternalRequestAsync<ApplyConfigToMachineGroupResponse>(req, "ApplyConfigToMachineGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于数据加工DSL函数的语法校验。
        /// </summary>
        /// <param name="req"><see cref="CheckFunctionRequest"/></param>
        /// <returns><see cref="CheckFunctionResponse"/></returns>
        public Task<CheckFunctionResponse> CheckFunction(CheckFunctionRequest req)
        {
            return InternalRequestAsync<CheckFunctionResponse>(req, "CheckFunction");
        }

        /// <summary>
        /// 本接口用于数据加工DSL函数的语法校验。
        /// </summary>
        /// <param name="req"><see cref="CheckFunctionRequest"/></param>
        /// <returns><see cref="CheckFunctionResponse"/></returns>
        public CheckFunctionResponse CheckFunctionSync(CheckFunctionRequest req)
        {
            return InternalRequestAsync<CheckFunctionResponse>(req, "CheckFunction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于校验Kafka服务集群是否可以正常访问
        /// </summary>
        /// <param name="req"><see cref="CheckRechargeKafkaServerRequest"/></param>
        /// <returns><see cref="CheckRechargeKafkaServerResponse"/></returns>
        public Task<CheckRechargeKafkaServerResponse> CheckRechargeKafkaServer(CheckRechargeKafkaServerRequest req)
        {
            return InternalRequestAsync<CheckRechargeKafkaServerResponse>(req, "CheckRechargeKafkaServer");
        }

        /// <summary>
        /// 本接口用于校验Kafka服务集群是否可以正常访问
        /// </summary>
        /// <param name="req"><see cref="CheckRechargeKafkaServerRequest"/></param>
        /// <returns><see cref="CheckRechargeKafkaServerResponse"/></returns>
        public CheckRechargeKafkaServerResponse CheckRechargeKafkaServerSync(CheckRechargeKafkaServerRequest req)
        {
            return InternalRequestAsync<CheckRechargeKafkaServerResponse>(req, "CheckRechargeKafkaServer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 关闭Kafka协议消费
        /// </summary>
        /// <param name="req"><see cref="CloseKafkaConsumerRequest"/></param>
        /// <returns><see cref="CloseKafkaConsumerResponse"/></returns>
        public Task<CloseKafkaConsumerResponse> CloseKafkaConsumer(CloseKafkaConsumerRequest req)
        {
            return InternalRequestAsync<CloseKafkaConsumerResponse>(req, "CloseKafkaConsumer");
        }

        /// <summary>
        /// 关闭Kafka协议消费
        /// </summary>
        /// <param name="req"><see cref="CloseKafkaConsumerRequest"/></param>
        /// <returns><see cref="CloseKafkaConsumerResponse"/></returns>
        public CloseKafkaConsumerResponse CloseKafkaConsumerSync(CloseKafkaConsumerRequest req)
        {
            return InternalRequestAsync<CloseKafkaConsumerResponse>(req, "CloseKafkaConsumer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于创建告警策略。
        /// </summary>
        /// <param name="req"><see cref="CreateAlarmRequest"/></param>
        /// <returns><see cref="CreateAlarmResponse"/></returns>
        public Task<CreateAlarmResponse> CreateAlarm(CreateAlarmRequest req)
        {
            return InternalRequestAsync<CreateAlarmResponse>(req, "CreateAlarm");
        }

        /// <summary>
        /// 本接口用于创建告警策略。
        /// </summary>
        /// <param name="req"><see cref="CreateAlarmRequest"/></param>
        /// <returns><see cref="CreateAlarmResponse"/></returns>
        public CreateAlarmResponse CreateAlarmSync(CreateAlarmRequest req)
        {
            return InternalRequestAsync<CreateAlarmResponse>(req, "CreateAlarm")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于创建通知渠道组。
        /// </summary>
        /// <param name="req"><see cref="CreateAlarmNoticeRequest"/></param>
        /// <returns><see cref="CreateAlarmNoticeResponse"/></returns>
        public Task<CreateAlarmNoticeResponse> CreateAlarmNotice(CreateAlarmNoticeRequest req)
        {
            return InternalRequestAsync<CreateAlarmNoticeResponse>(req, "CreateAlarmNotice");
        }

        /// <summary>
        /// 该接口用于创建通知渠道组。
        /// </summary>
        /// <param name="req"><see cref="CreateAlarmNoticeRequest"/></param>
        /// <returns><see cref="CreateAlarmNoticeResponse"/></returns>
        public CreateAlarmNoticeResponse CreateAlarmNoticeSync(CreateAlarmNoticeRequest req)
        {
            return InternalRequestAsync<CreateAlarmNoticeResponse>(req, "CreateAlarmNotice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于创建告警屏蔽规则。
        /// </summary>
        /// <param name="req"><see cref="CreateAlarmShieldRequest"/></param>
        /// <returns><see cref="CreateAlarmShieldResponse"/></returns>
        public Task<CreateAlarmShieldResponse> CreateAlarmShield(CreateAlarmShieldRequest req)
        {
            return InternalRequestAsync<CreateAlarmShieldResponse>(req, "CreateAlarmShield");
        }

        /// <summary>
        /// 该接口用于创建告警屏蔽规则。
        /// </summary>
        /// <param name="req"><see cref="CreateAlarmShieldRequest"/></param>
        /// <returns><see cref="CreateAlarmShieldResponse"/></returns>
        public CreateAlarmShieldResponse CreateAlarmShieldSync(CreateAlarmShieldRequest req)
        {
            return InternalRequestAsync<CreateAlarmShieldResponse>(req, "CreateAlarmShield")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建采集规则配置
        /// </summary>
        /// <param name="req"><see cref="CreateConfigRequest"/></param>
        /// <returns><see cref="CreateConfigResponse"/></returns>
        public Task<CreateConfigResponse> CreateConfig(CreateConfigRequest req)
        {
            return InternalRequestAsync<CreateConfigResponse>(req, "CreateConfig");
        }

        /// <summary>
        /// 创建采集规则配置
        /// </summary>
        /// <param name="req"><see cref="CreateConfigRequest"/></param>
        /// <returns><see cref="CreateConfigResponse"/></returns>
        public CreateConfigResponse CreateConfigSync(CreateConfigRequest req)
        {
            return InternalRequestAsync<CreateConfigResponse>(req, "CreateConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于创建特殊采集配置任务，特殊采集配置应用于自建K8S环境的采集Agent
        /// </summary>
        /// <param name="req"><see cref="CreateConfigExtraRequest"/></param>
        /// <returns><see cref="CreateConfigExtraResponse"/></returns>
        public Task<CreateConfigExtraResponse> CreateConfigExtra(CreateConfigExtraRequest req)
        {
            return InternalRequestAsync<CreateConfigExtraResponse>(req, "CreateConfigExtra");
        }

        /// <summary>
        /// 本接口用于创建特殊采集配置任务，特殊采集配置应用于自建K8S环境的采集Agent
        /// </summary>
        /// <param name="req"><see cref="CreateConfigExtraRequest"/></param>
        /// <returns><see cref="CreateConfigExtraResponse"/></returns>
        public CreateConfigExtraResponse CreateConfigExtraSync(CreateConfigExtraRequest req)
        {
            return InternalRequestAsync<CreateConfigExtraResponse>(req, "CreateConfigExtra")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建控制台分享
        /// </summary>
        /// <param name="req"><see cref="CreateConsoleSharingRequest"/></param>
        /// <returns><see cref="CreateConsoleSharingResponse"/></returns>
        public Task<CreateConsoleSharingResponse> CreateConsoleSharing(CreateConsoleSharingRequest req)
        {
            return InternalRequestAsync<CreateConsoleSharingResponse>(req, "CreateConsoleSharing");
        }

        /// <summary>
        /// 创建控制台分享
        /// </summary>
        /// <param name="req"><see cref="CreateConsoleSharingRequest"/></param>
        /// <returns><see cref="CreateConsoleSharingResponse"/></returns>
        public CreateConsoleSharingResponse CreateConsoleSharingSync(CreateConsoleSharingRequest req)
        {
            return InternalRequestAsync<CreateConsoleSharingResponse>(req, "CreateConsoleSharing")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于创建投递CKafka任务
        /// </summary>
        /// <param name="req"><see cref="CreateConsumerRequest"/></param>
        /// <returns><see cref="CreateConsumerResponse"/></returns>
        public Task<CreateConsumerResponse> CreateConsumer(CreateConsumerRequest req)
        {
            return InternalRequestAsync<CreateConsumerResponse>(req, "CreateConsumer");
        }

        /// <summary>
        /// 本接口用于创建投递CKafka任务
        /// </summary>
        /// <param name="req"><see cref="CreateConsumerRequest"/></param>
        /// <returns><see cref="CreateConsumerResponse"/></returns>
        public CreateConsumerResponse CreateConsumerSync(CreateConsumerRequest req)
        {
            return InternalRequestAsync<CreateConsumerResponse>(req, "CreateConsumer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于创建cos导入任务
        /// </summary>
        /// <param name="req"><see cref="CreateCosRechargeRequest"/></param>
        /// <returns><see cref="CreateCosRechargeResponse"/></returns>
        public Task<CreateCosRechargeResponse> CreateCosRecharge(CreateCosRechargeRequest req)
        {
            return InternalRequestAsync<CreateCosRechargeResponse>(req, "CreateCosRecharge");
        }

        /// <summary>
        /// 本接口用于创建cos导入任务
        /// </summary>
        /// <param name="req"><see cref="CreateCosRechargeRequest"/></param>
        /// <returns><see cref="CreateCosRechargeResponse"/></returns>
        public CreateCosRechargeResponse CreateCosRechargeSync(CreateCosRechargeRequest req)
        {
            return InternalRequestAsync<CreateCosRechargeResponse>(req, "CreateCosRecharge")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口用于创建仪表盘订阅
        /// </summary>
        /// <param name="req"><see cref="CreateDashboardSubscribeRequest"/></param>
        /// <returns><see cref="CreateDashboardSubscribeResponse"/></returns>
        public Task<CreateDashboardSubscribeResponse> CreateDashboardSubscribe(CreateDashboardSubscribeRequest req)
        {
            return InternalRequestAsync<CreateDashboardSubscribeResponse>(req, "CreateDashboardSubscribe");
        }

        /// <summary>
        /// 此接口用于创建仪表盘订阅
        /// </summary>
        /// <param name="req"><see cref="CreateDashboardSubscribeRequest"/></param>
        /// <returns><see cref="CreateDashboardSubscribeResponse"/></returns>
        public CreateDashboardSubscribeResponse CreateDashboardSubscribeSync(CreateDashboardSubscribeRequest req)
        {
            return InternalRequestAsync<CreateDashboardSubscribeResponse>(req, "CreateDashboardSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于创建数据加工任务。
        /// </summary>
        /// <param name="req"><see cref="CreateDataTransformRequest"/></param>
        /// <returns><see cref="CreateDataTransformResponse"/></returns>
        public Task<CreateDataTransformResponse> CreateDataTransform(CreateDataTransformRequest req)
        {
            return InternalRequestAsync<CreateDataTransformResponse>(req, "CreateDataTransform");
        }

        /// <summary>
        /// 本接口用于创建数据加工任务。
        /// </summary>
        /// <param name="req"><see cref="CreateDataTransformRequest"/></param>
        /// <returns><see cref="CreateDataTransformResponse"/></returns>
        public CreateDataTransformResponse CreateDataTransformSync(CreateDataTransformRequest req)
        {
            return InternalRequestAsync<CreateDataTransformResponse>(req, "CreateDataTransform")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于创建投递SCF任务
        /// </summary>
        /// <param name="req"><see cref="CreateDeliverCloudFunctionRequest"/></param>
        /// <returns><see cref="CreateDeliverCloudFunctionResponse"/></returns>
        public Task<CreateDeliverCloudFunctionResponse> CreateDeliverCloudFunction(CreateDeliverCloudFunctionRequest req)
        {
            return InternalRequestAsync<CreateDeliverCloudFunctionResponse>(req, "CreateDeliverCloudFunction");
        }

        /// <summary>
        /// 本接口用于创建投递SCF任务
        /// </summary>
        /// <param name="req"><see cref="CreateDeliverCloudFunctionRequest"/></param>
        /// <returns><see cref="CreateDeliverCloudFunctionResponse"/></returns>
        public CreateDeliverCloudFunctionResponse CreateDeliverCloudFunctionSync(CreateDeliverCloudFunctionRequest req)
        {
            return InternalRequestAsync<CreateDeliverCloudFunctionResponse>(req, "CreateDeliverCloudFunction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口仅创建下载任务，任务返回的下载地址，请用户调用DescribeExports查看任务列表。其中有下载地址CosPath参数。参考文档https://cloud.tencent.com/document/product/614/56449
        /// </summary>
        /// <param name="req"><see cref="CreateExportRequest"/></param>
        /// <returns><see cref="CreateExportResponse"/></returns>
        public Task<CreateExportResponse> CreateExport(CreateExportRequest req)
        {
            return InternalRequestAsync<CreateExportResponse>(req, "CreateExport");
        }

        /// <summary>
        /// 本接口仅创建下载任务，任务返回的下载地址，请用户调用DescribeExports查看任务列表。其中有下载地址CosPath参数。参考文档https://cloud.tencent.com/document/product/614/56449
        /// </summary>
        /// <param name="req"><see cref="CreateExportRequest"/></param>
        /// <returns><see cref="CreateExportResponse"/></returns>
        public CreateExportResponse CreateExportSync(CreateExportRequest req)
        {
            return InternalRequestAsync<CreateExportResponse>(req, "CreateExport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于创建索引
        /// </summary>
        /// <param name="req"><see cref="CreateIndexRequest"/></param>
        /// <returns><see cref="CreateIndexResponse"/></returns>
        public Task<CreateIndexResponse> CreateIndex(CreateIndexRequest req)
        {
            return InternalRequestAsync<CreateIndexResponse>(req, "CreateIndex");
        }

        /// <summary>
        /// 本接口用于创建索引
        /// </summary>
        /// <param name="req"><see cref="CreateIndexRequest"/></param>
        /// <returns><see cref="CreateIndexResponse"/></returns>
        public CreateIndexResponse CreateIndexSync(CreateIndexRequest req)
        {
            return InternalRequestAsync<CreateIndexResponse>(req, "CreateIndex")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于创建Kafka数据订阅任务
        /// </summary>
        /// <param name="req"><see cref="CreateKafkaRechargeRequest"/></param>
        /// <returns><see cref="CreateKafkaRechargeResponse"/></returns>
        public Task<CreateKafkaRechargeResponse> CreateKafkaRecharge(CreateKafkaRechargeRequest req)
        {
            return InternalRequestAsync<CreateKafkaRechargeResponse>(req, "CreateKafkaRecharge");
        }

        /// <summary>
        /// 本接口用于创建Kafka数据订阅任务
        /// </summary>
        /// <param name="req"><see cref="CreateKafkaRechargeRequest"/></param>
        /// <returns><see cref="CreateKafkaRechargeResponse"/></returns>
        public CreateKafkaRechargeResponse CreateKafkaRechargeSync(CreateKafkaRechargeRequest req)
        {
            return InternalRequestAsync<CreateKafkaRechargeResponse>(req, "CreateKafkaRecharge")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于创建日志集，返回新创建的日志集的 ID。
        /// </summary>
        /// <param name="req"><see cref="CreateLogsetRequest"/></param>
        /// <returns><see cref="CreateLogsetResponse"/></returns>
        public Task<CreateLogsetResponse> CreateLogset(CreateLogsetRequest req)
        {
            return InternalRequestAsync<CreateLogsetResponse>(req, "CreateLogset");
        }

        /// <summary>
        /// 本接口用于创建日志集，返回新创建的日志集的 ID。
        /// </summary>
        /// <param name="req"><see cref="CreateLogsetRequest"/></param>
        /// <returns><see cref="CreateLogsetResponse"/></returns>
        public CreateLogsetResponse CreateLogsetSync(CreateLogsetRequest req)
        {
            return InternalRequestAsync<CreateLogsetResponse>(req, "CreateLogset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建机器组
        /// </summary>
        /// <param name="req"><see cref="CreateMachineGroupRequest"/></param>
        /// <returns><see cref="CreateMachineGroupResponse"/></returns>
        public Task<CreateMachineGroupResponse> CreateMachineGroup(CreateMachineGroupRequest req)
        {
            return InternalRequestAsync<CreateMachineGroupResponse>(req, "CreateMachineGroup");
        }

        /// <summary>
        /// 创建机器组
        /// </summary>
        /// <param name="req"><see cref="CreateMachineGroupRequest"/></param>
        /// <returns><see cref="CreateMachineGroupResponse"/></returns>
        public CreateMachineGroupResponse CreateMachineGroupSync(CreateMachineGroupRequest req)
        {
            return InternalRequestAsync<CreateMachineGroupResponse>(req, "CreateMachineGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于创建定时SQL分析任务
        /// </summary>
        /// <param name="req"><see cref="CreateScheduledSqlRequest"/></param>
        /// <returns><see cref="CreateScheduledSqlResponse"/></returns>
        public Task<CreateScheduledSqlResponse> CreateScheduledSql(CreateScheduledSqlRequest req)
        {
            return InternalRequestAsync<CreateScheduledSqlResponse>(req, "CreateScheduledSql");
        }

        /// <summary>
        /// 本接口用于创建定时SQL分析任务
        /// </summary>
        /// <param name="req"><see cref="CreateScheduledSqlRequest"/></param>
        /// <returns><see cref="CreateScheduledSqlResponse"/></returns>
        public CreateScheduledSqlResponse CreateScheduledSqlSync(CreateScheduledSqlRequest req)
        {
            return InternalRequestAsync<CreateScheduledSqlResponse>(req, "CreateScheduledSql")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新建投递到COS的任务，【！！！注意】使用此接口，需要检查是否配置了投递COS的角色和权限。如果没有配置，请参考文档投递权限查看和配置https://cloud.tencent.com/document/product/614/71623。
        /// </summary>
        /// <param name="req"><see cref="CreateShipperRequest"/></param>
        /// <returns><see cref="CreateShipperResponse"/></returns>
        public Task<CreateShipperResponse> CreateShipper(CreateShipperRequest req)
        {
            return InternalRequestAsync<CreateShipperResponse>(req, "CreateShipper");
        }

        /// <summary>
        /// 新建投递到COS的任务，【！！！注意】使用此接口，需要检查是否配置了投递COS的角色和权限。如果没有配置，请参考文档投递权限查看和配置https://cloud.tencent.com/document/product/614/71623。
        /// </summary>
        /// <param name="req"><see cref="CreateShipperRequest"/></param>
        /// <returns><see cref="CreateShipperResponse"/></returns>
        public CreateShipperResponse CreateShipperSync(CreateShipperRequest req)
        {
            return InternalRequestAsync<CreateShipperResponse>(req, "CreateShipper")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于创建日志主题。
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRequest"/></param>
        /// <returns><see cref="CreateTopicResponse"/></returns>
        public Task<CreateTopicResponse> CreateTopic(CreateTopicRequest req)
        {
            return InternalRequestAsync<CreateTopicResponse>(req, "CreateTopic");
        }

        /// <summary>
        /// 本接口用于创建日志主题。
        /// </summary>
        /// <param name="req"><see cref="CreateTopicRequest"/></param>
        /// <returns><see cref="CreateTopicResponse"/></returns>
        public CreateTopicResponse CreateTopicSync(CreateTopicRequest req)
        {
            return InternalRequestAsync<CreateTopicResponse>(req, "CreateTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于删除告警策略。
        /// </summary>
        /// <param name="req"><see cref="DeleteAlarmRequest"/></param>
        /// <returns><see cref="DeleteAlarmResponse"/></returns>
        public Task<DeleteAlarmResponse> DeleteAlarm(DeleteAlarmRequest req)
        {
            return InternalRequestAsync<DeleteAlarmResponse>(req, "DeleteAlarm");
        }

        /// <summary>
        /// 本接口用于删除告警策略。
        /// </summary>
        /// <param name="req"><see cref="DeleteAlarmRequest"/></param>
        /// <returns><see cref="DeleteAlarmResponse"/></returns>
        public DeleteAlarmResponse DeleteAlarmSync(DeleteAlarmRequest req)
        {
            return InternalRequestAsync<DeleteAlarmResponse>(req, "DeleteAlarm")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于删除通知渠道组
        /// </summary>
        /// <param name="req"><see cref="DeleteAlarmNoticeRequest"/></param>
        /// <returns><see cref="DeleteAlarmNoticeResponse"/></returns>
        public Task<DeleteAlarmNoticeResponse> DeleteAlarmNotice(DeleteAlarmNoticeRequest req)
        {
            return InternalRequestAsync<DeleteAlarmNoticeResponse>(req, "DeleteAlarmNotice");
        }

        /// <summary>
        /// 该接口用于删除通知渠道组
        /// </summary>
        /// <param name="req"><see cref="DeleteAlarmNoticeRequest"/></param>
        /// <returns><see cref="DeleteAlarmNoticeResponse"/></returns>
        public DeleteAlarmNoticeResponse DeleteAlarmNoticeSync(DeleteAlarmNoticeRequest req)
        {
            return InternalRequestAsync<DeleteAlarmNoticeResponse>(req, "DeleteAlarmNotice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于删除告警屏蔽规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteAlarmShieldRequest"/></param>
        /// <returns><see cref="DeleteAlarmShieldResponse"/></returns>
        public Task<DeleteAlarmShieldResponse> DeleteAlarmShield(DeleteAlarmShieldRequest req)
        {
            return InternalRequestAsync<DeleteAlarmShieldResponse>(req, "DeleteAlarmShield");
        }

        /// <summary>
        /// 该接口用于删除告警屏蔽规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteAlarmShieldRequest"/></param>
        /// <returns><see cref="DeleteAlarmShieldResponse"/></returns>
        public DeleteAlarmShieldResponse DeleteAlarmShieldSync(DeleteAlarmShieldRequest req)
        {
            return InternalRequestAsync<DeleteAlarmShieldResponse>(req, "DeleteAlarmShield")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除采集规则配置
        /// </summary>
        /// <param name="req"><see cref="DeleteConfigRequest"/></param>
        /// <returns><see cref="DeleteConfigResponse"/></returns>
        public Task<DeleteConfigResponse> DeleteConfig(DeleteConfigRequest req)
        {
            return InternalRequestAsync<DeleteConfigResponse>(req, "DeleteConfig");
        }

        /// <summary>
        /// 删除采集规则配置
        /// </summary>
        /// <param name="req"><see cref="DeleteConfigRequest"/></param>
        /// <returns><see cref="DeleteConfigResponse"/></returns>
        public DeleteConfigResponse DeleteConfigSync(DeleteConfigRequest req)
        {
            return InternalRequestAsync<DeleteConfigResponse>(req, "DeleteConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于删除特殊采集规则配置，特殊采集配置应用于自建K8S环境的采集Agent
        /// </summary>
        /// <param name="req"><see cref="DeleteConfigExtraRequest"/></param>
        /// <returns><see cref="DeleteConfigExtraResponse"/></returns>
        public Task<DeleteConfigExtraResponse> DeleteConfigExtra(DeleteConfigExtraRequest req)
        {
            return InternalRequestAsync<DeleteConfigExtraResponse>(req, "DeleteConfigExtra");
        }

        /// <summary>
        /// 本接口用于删除特殊采集规则配置，特殊采集配置应用于自建K8S环境的采集Agent
        /// </summary>
        /// <param name="req"><see cref="DeleteConfigExtraRequest"/></param>
        /// <returns><see cref="DeleteConfigExtraResponse"/></returns>
        public DeleteConfigExtraResponse DeleteConfigExtraSync(DeleteConfigExtraRequest req)
        {
            return InternalRequestAsync<DeleteConfigExtraResponse>(req, "DeleteConfigExtra")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除应用到机器组的采集配置
        /// </summary>
        /// <param name="req"><see cref="DeleteConfigFromMachineGroupRequest"/></param>
        /// <returns><see cref="DeleteConfigFromMachineGroupResponse"/></returns>
        public Task<DeleteConfigFromMachineGroupResponse> DeleteConfigFromMachineGroup(DeleteConfigFromMachineGroupRequest req)
        {
            return InternalRequestAsync<DeleteConfigFromMachineGroupResponse>(req, "DeleteConfigFromMachineGroup");
        }

        /// <summary>
        /// 删除应用到机器组的采集配置
        /// </summary>
        /// <param name="req"><see cref="DeleteConfigFromMachineGroupRequest"/></param>
        /// <returns><see cref="DeleteConfigFromMachineGroupResponse"/></returns>
        public DeleteConfigFromMachineGroupResponse DeleteConfigFromMachineGroupSync(DeleteConfigFromMachineGroupRequest req)
        {
            return InternalRequestAsync<DeleteConfigFromMachineGroupResponse>(req, "DeleteConfigFromMachineGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除控制台分享
        /// </summary>
        /// <param name="req"><see cref="DeleteConsoleSharingRequest"/></param>
        /// <returns><see cref="DeleteConsoleSharingResponse"/></returns>
        public Task<DeleteConsoleSharingResponse> DeleteConsoleSharing(DeleteConsoleSharingRequest req)
        {
            return InternalRequestAsync<DeleteConsoleSharingResponse>(req, "DeleteConsoleSharing");
        }

        /// <summary>
        /// 删除控制台分享
        /// </summary>
        /// <param name="req"><see cref="DeleteConsoleSharingRequest"/></param>
        /// <returns><see cref="DeleteConsoleSharingResponse"/></returns>
        public DeleteConsoleSharingResponse DeleteConsoleSharingSync(DeleteConsoleSharingRequest req)
        {
            return InternalRequestAsync<DeleteConsoleSharingResponse>(req, "DeleteConsoleSharing")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于删除投递配置
        /// </summary>
        /// <param name="req"><see cref="DeleteConsumerRequest"/></param>
        /// <returns><see cref="DeleteConsumerResponse"/></returns>
        public Task<DeleteConsumerResponse> DeleteConsumer(DeleteConsumerRequest req)
        {
            return InternalRequestAsync<DeleteConsumerResponse>(req, "DeleteConsumer");
        }

        /// <summary>
        /// 本接口用于删除投递配置
        /// </summary>
        /// <param name="req"><see cref="DeleteConsumerRequest"/></param>
        /// <returns><see cref="DeleteConsumerResponse"/></returns>
        public DeleteConsumerResponse DeleteConsumerSync(DeleteConsumerRequest req)
        {
            return InternalRequestAsync<DeleteConsumerResponse>(req, "DeleteConsumer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口用于删除仪表盘订阅
        /// </summary>
        /// <param name="req"><see cref="DeleteDashboardSubscribeRequest"/></param>
        /// <returns><see cref="DeleteDashboardSubscribeResponse"/></returns>
        public Task<DeleteDashboardSubscribeResponse> DeleteDashboardSubscribe(DeleteDashboardSubscribeRequest req)
        {
            return InternalRequestAsync<DeleteDashboardSubscribeResponse>(req, "DeleteDashboardSubscribe");
        }

        /// <summary>
        /// 此接口用于删除仪表盘订阅
        /// </summary>
        /// <param name="req"><see cref="DeleteDashboardSubscribeRequest"/></param>
        /// <returns><see cref="DeleteDashboardSubscribeResponse"/></returns>
        public DeleteDashboardSubscribeResponse DeleteDashboardSubscribeSync(DeleteDashboardSubscribeRequest req)
        {
            return InternalRequestAsync<DeleteDashboardSubscribeResponse>(req, "DeleteDashboardSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于删除数据加工任务
        /// </summary>
        /// <param name="req"><see cref="DeleteDataTransformRequest"/></param>
        /// <returns><see cref="DeleteDataTransformResponse"/></returns>
        public Task<DeleteDataTransformResponse> DeleteDataTransform(DeleteDataTransformRequest req)
        {
            return InternalRequestAsync<DeleteDataTransformResponse>(req, "DeleteDataTransform");
        }

        /// <summary>
        /// 本接口用于删除数据加工任务
        /// </summary>
        /// <param name="req"><see cref="DeleteDataTransformRequest"/></param>
        /// <returns><see cref="DeleteDataTransformResponse"/></returns>
        public DeleteDataTransformResponse DeleteDataTransformSync(DeleteDataTransformRequest req)
        {
            return InternalRequestAsync<DeleteDataTransformResponse>(req, "DeleteDataTransform")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于删除日志下载任务
        /// </summary>
        /// <param name="req"><see cref="DeleteExportRequest"/></param>
        /// <returns><see cref="DeleteExportResponse"/></returns>
        public Task<DeleteExportResponse> DeleteExport(DeleteExportRequest req)
        {
            return InternalRequestAsync<DeleteExportResponse>(req, "DeleteExport");
        }

        /// <summary>
        /// 本接口用于删除日志下载任务
        /// </summary>
        /// <param name="req"><see cref="DeleteExportRequest"/></param>
        /// <returns><see cref="DeleteExportResponse"/></returns>
        public DeleteExportResponse DeleteExportSync(DeleteExportRequest req)
        {
            return InternalRequestAsync<DeleteExportResponse>(req, "DeleteExport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于删除日志主题的索引配置，删除索引配置后将无法检索和查询采集到的日志。
        /// </summary>
        /// <param name="req"><see cref="DeleteIndexRequest"/></param>
        /// <returns><see cref="DeleteIndexResponse"/></returns>
        public Task<DeleteIndexResponse> DeleteIndex(DeleteIndexRequest req)
        {
            return InternalRequestAsync<DeleteIndexResponse>(req, "DeleteIndex");
        }

        /// <summary>
        /// 本接口用于删除日志主题的索引配置，删除索引配置后将无法检索和查询采集到的日志。
        /// </summary>
        /// <param name="req"><see cref="DeleteIndexRequest"/></param>
        /// <returns><see cref="DeleteIndexResponse"/></returns>
        public DeleteIndexResponse DeleteIndexSync(DeleteIndexRequest req)
        {
            return InternalRequestAsync<DeleteIndexResponse>(req, "DeleteIndex")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于删除Kafka数据订阅任务
        /// </summary>
        /// <param name="req"><see cref="DeleteKafkaRechargeRequest"/></param>
        /// <returns><see cref="DeleteKafkaRechargeResponse"/></returns>
        public Task<DeleteKafkaRechargeResponse> DeleteKafkaRecharge(DeleteKafkaRechargeRequest req)
        {
            return InternalRequestAsync<DeleteKafkaRechargeResponse>(req, "DeleteKafkaRecharge");
        }

        /// <summary>
        /// 本接口用于删除Kafka数据订阅任务
        /// </summary>
        /// <param name="req"><see cref="DeleteKafkaRechargeRequest"/></param>
        /// <returns><see cref="DeleteKafkaRechargeResponse"/></returns>
        public DeleteKafkaRechargeResponse DeleteKafkaRechargeSync(DeleteKafkaRechargeRequest req)
        {
            return InternalRequestAsync<DeleteKafkaRechargeResponse>(req, "DeleteKafkaRecharge")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于删除日志集。
        /// </summary>
        /// <param name="req"><see cref="DeleteLogsetRequest"/></param>
        /// <returns><see cref="DeleteLogsetResponse"/></returns>
        public Task<DeleteLogsetResponse> DeleteLogset(DeleteLogsetRequest req)
        {
            return InternalRequestAsync<DeleteLogsetResponse>(req, "DeleteLogset");
        }

        /// <summary>
        /// 本接口用于删除日志集。
        /// </summary>
        /// <param name="req"><see cref="DeleteLogsetRequest"/></param>
        /// <returns><see cref="DeleteLogsetResponse"/></returns>
        public DeleteLogsetResponse DeleteLogsetSync(DeleteLogsetRequest req)
        {
            return InternalRequestAsync<DeleteLogsetResponse>(req, "DeleteLogset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除机器组
        /// </summary>
        /// <param name="req"><see cref="DeleteMachineGroupRequest"/></param>
        /// <returns><see cref="DeleteMachineGroupResponse"/></returns>
        public Task<DeleteMachineGroupResponse> DeleteMachineGroup(DeleteMachineGroupRequest req)
        {
            return InternalRequestAsync<DeleteMachineGroupResponse>(req, "DeleteMachineGroup");
        }

        /// <summary>
        /// 删除机器组
        /// </summary>
        /// <param name="req"><see cref="DeleteMachineGroupRequest"/></param>
        /// <returns><see cref="DeleteMachineGroupResponse"/></returns>
        public DeleteMachineGroupResponse DeleteMachineGroupSync(DeleteMachineGroupRequest req)
        {
            return InternalRequestAsync<DeleteMachineGroupResponse>(req, "DeleteMachineGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于删除机器组信息
        /// </summary>
        /// <param name="req"><see cref="DeleteMachineGroupInfoRequest"/></param>
        /// <returns><see cref="DeleteMachineGroupInfoResponse"/></returns>
        public Task<DeleteMachineGroupInfoResponse> DeleteMachineGroupInfo(DeleteMachineGroupInfoRequest req)
        {
            return InternalRequestAsync<DeleteMachineGroupInfoResponse>(req, "DeleteMachineGroupInfo");
        }

        /// <summary>
        /// 用于删除机器组信息
        /// </summary>
        /// <param name="req"><see cref="DeleteMachineGroupInfoRequest"/></param>
        /// <returns><see cref="DeleteMachineGroupInfoResponse"/></returns>
        public DeleteMachineGroupInfoResponse DeleteMachineGroupInfoSync(DeleteMachineGroupInfoRequest req)
        {
            return InternalRequestAsync<DeleteMachineGroupInfoResponse>(req, "DeleteMachineGroupInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于删除定时SQL分析任务
        /// </summary>
        /// <param name="req"><see cref="DeleteScheduledSqlRequest"/></param>
        /// <returns><see cref="DeleteScheduledSqlResponse"/></returns>
        public Task<DeleteScheduledSqlResponse> DeleteScheduledSql(DeleteScheduledSqlRequest req)
        {
            return InternalRequestAsync<DeleteScheduledSqlResponse>(req, "DeleteScheduledSql");
        }

        /// <summary>
        /// 本接口用于删除定时SQL分析任务
        /// </summary>
        /// <param name="req"><see cref="DeleteScheduledSqlRequest"/></param>
        /// <returns><see cref="DeleteScheduledSqlResponse"/></returns>
        public DeleteScheduledSqlResponse DeleteScheduledSqlSync(DeleteScheduledSqlRequest req)
        {
            return InternalRequestAsync<DeleteScheduledSqlResponse>(req, "DeleteScheduledSql")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除投递COS任务
        /// </summary>
        /// <param name="req"><see cref="DeleteShipperRequest"/></param>
        /// <returns><see cref="DeleteShipperResponse"/></returns>
        public Task<DeleteShipperResponse> DeleteShipper(DeleteShipperRequest req)
        {
            return InternalRequestAsync<DeleteShipperResponse>(req, "DeleteShipper");
        }

        /// <summary>
        /// 删除投递COS任务
        /// </summary>
        /// <param name="req"><see cref="DeleteShipperRequest"/></param>
        /// <returns><see cref="DeleteShipperResponse"/></returns>
        public DeleteShipperResponse DeleteShipperSync(DeleteShipperRequest req)
        {
            return InternalRequestAsync<DeleteShipperResponse>(req, "DeleteShipper")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于删除日志主题。
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicRequest"/></param>
        /// <returns><see cref="DeleteTopicResponse"/></returns>
        public Task<DeleteTopicResponse> DeleteTopic(DeleteTopicRequest req)
        {
            return InternalRequestAsync<DeleteTopicResponse>(req, "DeleteTopic");
        }

        /// <summary>
        /// 本接口用于删除日志主题。
        /// </summary>
        /// <param name="req"><see cref="DeleteTopicRequest"/></param>
        /// <returns><see cref="DeleteTopicResponse"/></returns>
        public DeleteTopicResponse DeleteTopicSync(DeleteTopicRequest req)
        {
            return InternalRequestAsync<DeleteTopicResponse>(req, "DeleteTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于获取通知渠道组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmNoticesRequest"/></param>
        /// <returns><see cref="DescribeAlarmNoticesResponse"/></returns>
        public Task<DescribeAlarmNoticesResponse> DescribeAlarmNotices(DescribeAlarmNoticesRequest req)
        {
            return InternalRequestAsync<DescribeAlarmNoticesResponse>(req, "DescribeAlarmNotices");
        }

        /// <summary>
        /// 该接口用于获取通知渠道组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmNoticesRequest"/></param>
        /// <returns><see cref="DescribeAlarmNoticesResponse"/></returns>
        public DescribeAlarmNoticesResponse DescribeAlarmNoticesSync(DescribeAlarmNoticesRequest req)
        {
            return InternalRequestAsync<DescribeAlarmNoticesResponse>(req, "DescribeAlarmNotices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取告警屏蔽配置规则
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmShieldsRequest"/></param>
        /// <returns><see cref="DescribeAlarmShieldsResponse"/></returns>
        public Task<DescribeAlarmShieldsResponse> DescribeAlarmShields(DescribeAlarmShieldsRequest req)
        {
            return InternalRequestAsync<DescribeAlarmShieldsResponse>(req, "DescribeAlarmShields");
        }

        /// <summary>
        /// 获取告警屏蔽配置规则
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmShieldsRequest"/></param>
        /// <returns><see cref="DescribeAlarmShieldsResponse"/></returns>
        public DescribeAlarmShieldsResponse DescribeAlarmShieldsSync(DescribeAlarmShieldsRequest req)
        {
            return InternalRequestAsync<DescribeAlarmShieldsResponse>(req, "DescribeAlarmShields")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于获取告警策略列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmsRequest"/></param>
        /// <returns><see cref="DescribeAlarmsResponse"/></returns>
        public Task<DescribeAlarmsResponse> DescribeAlarms(DescribeAlarmsRequest req)
        {
            return InternalRequestAsync<DescribeAlarmsResponse>(req, "DescribeAlarms");
        }

        /// <summary>
        /// 本接口用于获取告警策略列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmsRequest"/></param>
        /// <returns><see cref="DescribeAlarmsResponse"/></returns>
        public DescribeAlarmsResponse DescribeAlarmsSync(DescribeAlarmsRequest req)
        {
            return InternalRequestAsync<DescribeAlarmsResponse>(req, "DescribeAlarms")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取告警历史，例如今天未恢复的告警
        /// </summary>
        /// <param name="req"><see cref="DescribeAlertRecordHistoryRequest"/></param>
        /// <returns><see cref="DescribeAlertRecordHistoryResponse"/></returns>
        public Task<DescribeAlertRecordHistoryResponse> DescribeAlertRecordHistory(DescribeAlertRecordHistoryRequest req)
        {
            return InternalRequestAsync<DescribeAlertRecordHistoryResponse>(req, "DescribeAlertRecordHistory");
        }

        /// <summary>
        /// 获取告警历史，例如今天未恢复的告警
        /// </summary>
        /// <param name="req"><see cref="DescribeAlertRecordHistoryRequest"/></param>
        /// <returns><see cref="DescribeAlertRecordHistoryResponse"/></returns>
        public DescribeAlertRecordHistoryResponse DescribeAlertRecordHistorySync(DescribeAlertRecordHistoryRequest req)
        {
            return InternalRequestAsync<DescribeAlertRecordHistoryResponse>(req, "DescribeAlertRecordHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于获取特殊采集配置，特殊采集配置应用于自建K8S环境的采集Agent
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigExtrasRequest"/></param>
        /// <returns><see cref="DescribeConfigExtrasResponse"/></returns>
        public Task<DescribeConfigExtrasResponse> DescribeConfigExtras(DescribeConfigExtrasRequest req)
        {
            return InternalRequestAsync<DescribeConfigExtrasResponse>(req, "DescribeConfigExtras");
        }

        /// <summary>
        /// 本接口用于获取特殊采集配置，特殊采集配置应用于自建K8S环境的采集Agent
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigExtrasRequest"/></param>
        /// <returns><see cref="DescribeConfigExtrasResponse"/></returns>
        public DescribeConfigExtrasResponse DescribeConfigExtrasSync(DescribeConfigExtrasRequest req)
        {
            return InternalRequestAsync<DescribeConfigExtrasResponse>(req, "DescribeConfigExtras")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取采集规则配置所绑定的机器组
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigMachineGroupsRequest"/></param>
        /// <returns><see cref="DescribeConfigMachineGroupsResponse"/></returns>
        public Task<DescribeConfigMachineGroupsResponse> DescribeConfigMachineGroups(DescribeConfigMachineGroupsRequest req)
        {
            return InternalRequestAsync<DescribeConfigMachineGroupsResponse>(req, "DescribeConfigMachineGroups");
        }

        /// <summary>
        /// 获取采集规则配置所绑定的机器组
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigMachineGroupsRequest"/></param>
        /// <returns><see cref="DescribeConfigMachineGroupsResponse"/></returns>
        public DescribeConfigMachineGroupsResponse DescribeConfigMachineGroupsSync(DescribeConfigMachineGroupsRequest req)
        {
            return InternalRequestAsync<DescribeConfigMachineGroupsResponse>(req, "DescribeConfigMachineGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取采集规则配置
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigsRequest"/></param>
        /// <returns><see cref="DescribeConfigsResponse"/></returns>
        public Task<DescribeConfigsResponse> DescribeConfigs(DescribeConfigsRequest req)
        {
            return InternalRequestAsync<DescribeConfigsResponse>(req, "DescribeConfigs");
        }

        /// <summary>
        /// 获取采集规则配置
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigsRequest"/></param>
        /// <returns><see cref="DescribeConfigsResponse"/></returns>
        public DescribeConfigsResponse DescribeConfigsSync(DescribeConfigsRequest req)
        {
            return InternalRequestAsync<DescribeConfigsResponse>(req, "DescribeConfigs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量查询控制台分享列表
        /// </summary>
        /// <param name="req"><see cref="DescribeConsoleSharingListRequest"/></param>
        /// <returns><see cref="DescribeConsoleSharingListResponse"/></returns>
        public Task<DescribeConsoleSharingListResponse> DescribeConsoleSharingList(DescribeConsoleSharingListRequest req)
        {
            return InternalRequestAsync<DescribeConsoleSharingListResponse>(req, "DescribeConsoleSharingList");
        }

        /// <summary>
        /// 批量查询控制台分享列表
        /// </summary>
        /// <param name="req"><see cref="DescribeConsoleSharingListRequest"/></param>
        /// <returns><see cref="DescribeConsoleSharingListResponse"/></returns>
        public DescribeConsoleSharingListResponse DescribeConsoleSharingListSync(DescribeConsoleSharingListRequest req)
        {
            return InternalRequestAsync<DescribeConsoleSharingListResponse>(req, "DescribeConsoleSharingList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于获取投递配置
        /// </summary>
        /// <param name="req"><see cref="DescribeConsumerRequest"/></param>
        /// <returns><see cref="DescribeConsumerResponse"/></returns>
        public Task<DescribeConsumerResponse> DescribeConsumer(DescribeConsumerRequest req)
        {
            return InternalRequestAsync<DescribeConsumerResponse>(req, "DescribeConsumer");
        }

        /// <summary>
        /// 本接口用于获取投递配置
        /// </summary>
        /// <param name="req"><see cref="DescribeConsumerRequest"/></param>
        /// <returns><see cref="DescribeConsumerResponse"/></returns>
        public DescribeConsumerResponse DescribeConsumerSync(DescribeConsumerRequest req)
        {
            return InternalRequestAsync<DescribeConsumerResponse>(req, "DescribeConsumer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于获取cos导入配置
        /// </summary>
        /// <param name="req"><see cref="DescribeCosRechargesRequest"/></param>
        /// <returns><see cref="DescribeCosRechargesResponse"/></returns>
        public Task<DescribeCosRechargesResponse> DescribeCosRecharges(DescribeCosRechargesRequest req)
        {
            return InternalRequestAsync<DescribeCosRechargesResponse>(req, "DescribeCosRecharges");
        }

        /// <summary>
        /// 本接口用于获取cos导入配置
        /// </summary>
        /// <param name="req"><see cref="DescribeCosRechargesRequest"/></param>
        /// <returns><see cref="DescribeCosRechargesResponse"/></returns>
        public DescribeCosRechargesResponse DescribeCosRechargesSync(DescribeCosRechargesRequest req)
        {
            return InternalRequestAsync<DescribeCosRechargesResponse>(req, "DescribeCosRecharges")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于获取仪表盘订阅列表，支持分页
        /// </summary>
        /// <param name="req"><see cref="DescribeDashboardSubscribesRequest"/></param>
        /// <returns><see cref="DescribeDashboardSubscribesResponse"/></returns>
        public Task<DescribeDashboardSubscribesResponse> DescribeDashboardSubscribes(DescribeDashboardSubscribesRequest req)
        {
            return InternalRequestAsync<DescribeDashboardSubscribesResponse>(req, "DescribeDashboardSubscribes");
        }

        /// <summary>
        /// 本接口用于获取仪表盘订阅列表，支持分页
        /// </summary>
        /// <param name="req"><see cref="DescribeDashboardSubscribesRequest"/></param>
        /// <returns><see cref="DescribeDashboardSubscribesResponse"/></returns>
        public DescribeDashboardSubscribesResponse DescribeDashboardSubscribesSync(DescribeDashboardSubscribesRequest req)
        {
            return InternalRequestAsync<DescribeDashboardSubscribesResponse>(req, "DescribeDashboardSubscribes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于获取仪表盘
        /// </summary>
        /// <param name="req"><see cref="DescribeDashboardsRequest"/></param>
        /// <returns><see cref="DescribeDashboardsResponse"/></returns>
        public Task<DescribeDashboardsResponse> DescribeDashboards(DescribeDashboardsRequest req)
        {
            return InternalRequestAsync<DescribeDashboardsResponse>(req, "DescribeDashboards");
        }

        /// <summary>
        /// 本接口用于获取仪表盘
        /// </summary>
        /// <param name="req"><see cref="DescribeDashboardsRequest"/></param>
        /// <returns><see cref="DescribeDashboardsResponse"/></returns>
        public DescribeDashboardsResponse DescribeDashboardsSync(DescribeDashboardsRequest req)
        {
            return InternalRequestAsync<DescribeDashboardsResponse>(req, "DescribeDashboards")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于获取数据加工任务列表基本信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataTransformInfoRequest"/></param>
        /// <returns><see cref="DescribeDataTransformInfoResponse"/></returns>
        public Task<DescribeDataTransformInfoResponse> DescribeDataTransformInfo(DescribeDataTransformInfoRequest req)
        {
            return InternalRequestAsync<DescribeDataTransformInfoResponse>(req, "DescribeDataTransformInfo");
        }

        /// <summary>
        /// 本接口用于获取数据加工任务列表基本信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataTransformInfoRequest"/></param>
        /// <returns><see cref="DescribeDataTransformInfoResponse"/></returns>
        public DescribeDataTransformInfoResponse DescribeDataTransformInfoSync(DescribeDataTransformInfoRequest req)
        {
            return InternalRequestAsync<DescribeDataTransformInfoResponse>(req, "DescribeDataTransformInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于获取日志下载任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeExportsRequest"/></param>
        /// <returns><see cref="DescribeExportsResponse"/></returns>
        public Task<DescribeExportsResponse> DescribeExports(DescribeExportsRequest req)
        {
            return InternalRequestAsync<DescribeExportsResponse>(req, "DescribeExports");
        }

        /// <summary>
        /// 本接口用于获取日志下载任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeExportsRequest"/></param>
        /// <returns><see cref="DescribeExportsResponse"/></returns>
        public DescribeExportsResponse DescribeExportsSync(DescribeExportsRequest req)
        {
            return InternalRequestAsync<DescribeExportsResponse>(req, "DescribeExports")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于获取索引配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeIndexRequest"/></param>
        /// <returns><see cref="DescribeIndexResponse"/></returns>
        public Task<DescribeIndexResponse> DescribeIndex(DescribeIndexRequest req)
        {
            return InternalRequestAsync<DescribeIndexResponse>(req, "DescribeIndex");
        }

        /// <summary>
        /// 本接口用于获取索引配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeIndexRequest"/></param>
        /// <returns><see cref="DescribeIndexResponse"/></returns>
        public DescribeIndexResponse DescribeIndexSync(DescribeIndexRequest req)
        {
            return InternalRequestAsync<DescribeIndexResponse>(req, "DescribeIndex")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取Kafka协议消费信息
        /// </summary>
        /// <param name="req"><see cref="DescribeKafkaConsumerRequest"/></param>
        /// <returns><see cref="DescribeKafkaConsumerResponse"/></returns>
        public Task<DescribeKafkaConsumerResponse> DescribeKafkaConsumer(DescribeKafkaConsumerRequest req)
        {
            return InternalRequestAsync<DescribeKafkaConsumerResponse>(req, "DescribeKafkaConsumer");
        }

        /// <summary>
        /// 获取Kafka协议消费信息
        /// </summary>
        /// <param name="req"><see cref="DescribeKafkaConsumerRequest"/></param>
        /// <returns><see cref="DescribeKafkaConsumerResponse"/></returns>
        public DescribeKafkaConsumerResponse DescribeKafkaConsumerSync(DescribeKafkaConsumerRequest req)
        {
            return InternalRequestAsync<DescribeKafkaConsumerResponse>(req, "DescribeKafkaConsumer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于获取Kafka数据订阅任务
        /// </summary>
        /// <param name="req"><see cref="DescribeKafkaRechargesRequest"/></param>
        /// <returns><see cref="DescribeKafkaRechargesResponse"/></returns>
        public Task<DescribeKafkaRechargesResponse> DescribeKafkaRecharges(DescribeKafkaRechargesRequest req)
        {
            return InternalRequestAsync<DescribeKafkaRechargesResponse>(req, "DescribeKafkaRecharges");
        }

        /// <summary>
        /// 本接口用于获取Kafka数据订阅任务
        /// </summary>
        /// <param name="req"><see cref="DescribeKafkaRechargesRequest"/></param>
        /// <returns><see cref="DescribeKafkaRechargesResponse"/></returns>
        public DescribeKafkaRechargesResponse DescribeKafkaRechargesSync(DescribeKafkaRechargesRequest req)
        {
            return InternalRequestAsync<DescribeKafkaRechargesResponse>(req, "DescribeKafkaRecharges")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于搜索日志上下文附近的内容，详情参考[上下文检索](https://cloud.tencent.com/document/product/614/53248)。
        /// API返回数据包最大49MB，建议启用 gzip 压缩（HTTP Request Header Accept-Encoding:gzip）。
        /// </summary>
        /// <param name="req"><see cref="DescribeLogContextRequest"/></param>
        /// <returns><see cref="DescribeLogContextResponse"/></returns>
        public Task<DescribeLogContextResponse> DescribeLogContext(DescribeLogContextRequest req)
        {
            return InternalRequestAsync<DescribeLogContextResponse>(req, "DescribeLogContext");
        }

        /// <summary>
        /// 本接口用于搜索日志上下文附近的内容，详情参考[上下文检索](https://cloud.tencent.com/document/product/614/53248)。
        /// API返回数据包最大49MB，建议启用 gzip 压缩（HTTP Request Header Accept-Encoding:gzip）。
        /// </summary>
        /// <param name="req"><see cref="DescribeLogContextRequest"/></param>
        /// <returns><see cref="DescribeLogContextResponse"/></returns>
        public DescribeLogContextResponse DescribeLogContextSync(DescribeLogContextRequest req)
        {
            return InternalRequestAsync<DescribeLogContextResponse>(req, "DescribeLogContext")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于构建日志数量直方图
        /// </summary>
        /// <param name="req"><see cref="DescribeLogHistogramRequest"/></param>
        /// <returns><see cref="DescribeLogHistogramResponse"/></returns>
        public Task<DescribeLogHistogramResponse> DescribeLogHistogram(DescribeLogHistogramRequest req)
        {
            return InternalRequestAsync<DescribeLogHistogramResponse>(req, "DescribeLogHistogram");
        }

        /// <summary>
        /// 本接口用于构建日志数量直方图
        /// </summary>
        /// <param name="req"><see cref="DescribeLogHistogramRequest"/></param>
        /// <returns><see cref="DescribeLogHistogramResponse"/></returns>
        public DescribeLogHistogramResponse DescribeLogHistogramSync(DescribeLogHistogramRequest req)
        {
            return InternalRequestAsync<DescribeLogHistogramResponse>(req, "DescribeLogHistogram")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于获取日志集信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeLogsetsRequest"/></param>
        /// <returns><see cref="DescribeLogsetsResponse"/></returns>
        public Task<DescribeLogsetsResponse> DescribeLogsets(DescribeLogsetsRequest req)
        {
            return InternalRequestAsync<DescribeLogsetsResponse>(req, "DescribeLogsets");
        }

        /// <summary>
        /// 本接口用于获取日志集信息列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeLogsetsRequest"/></param>
        /// <returns><see cref="DescribeLogsetsResponse"/></returns>
        public DescribeLogsetsResponse DescribeLogsetsSync(DescribeLogsetsRequest req)
        {
            return InternalRequestAsync<DescribeLogsetsResponse>(req, "DescribeLogsets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取机器组绑定的采集规则配置
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineGroupConfigsRequest"/></param>
        /// <returns><see cref="DescribeMachineGroupConfigsResponse"/></returns>
        public Task<DescribeMachineGroupConfigsResponse> DescribeMachineGroupConfigs(DescribeMachineGroupConfigsRequest req)
        {
            return InternalRequestAsync<DescribeMachineGroupConfigsResponse>(req, "DescribeMachineGroupConfigs");
        }

        /// <summary>
        /// 获取机器组绑定的采集规则配置
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineGroupConfigsRequest"/></param>
        /// <returns><see cref="DescribeMachineGroupConfigsResponse"/></returns>
        public DescribeMachineGroupConfigsResponse DescribeMachineGroupConfigsSync(DescribeMachineGroupConfigsRequest req)
        {
            return InternalRequestAsync<DescribeMachineGroupConfigsResponse>(req, "DescribeMachineGroupConfigs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取机器组信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineGroupsRequest"/></param>
        /// <returns><see cref="DescribeMachineGroupsResponse"/></returns>
        public Task<DescribeMachineGroupsResponse> DescribeMachineGroups(DescribeMachineGroupsRequest req)
        {
            return InternalRequestAsync<DescribeMachineGroupsResponse>(req, "DescribeMachineGroups");
        }

        /// <summary>
        /// 获取机器组信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineGroupsRequest"/></param>
        /// <returns><see cref="DescribeMachineGroupsResponse"/></returns>
        public DescribeMachineGroupsResponse DescribeMachineGroupsSync(DescribeMachineGroupsRequest req)
        {
            return InternalRequestAsync<DescribeMachineGroupsResponse>(req, "DescribeMachineGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取指定机器组下的机器状态
        /// </summary>
        /// <param name="req"><see cref="DescribeMachinesRequest"/></param>
        /// <returns><see cref="DescribeMachinesResponse"/></returns>
        public Task<DescribeMachinesResponse> DescribeMachines(DescribeMachinesRequest req)
        {
            return InternalRequestAsync<DescribeMachinesResponse>(req, "DescribeMachines");
        }

        /// <summary>
        /// 获取指定机器组下的机器状态
        /// </summary>
        /// <param name="req"><see cref="DescribeMachinesRequest"/></param>
        /// <returns><see cref="DescribeMachinesResponse"/></returns>
        public DescribeMachinesResponse DescribeMachinesSync(DescribeMachinesRequest req)
        {
            return InternalRequestAsync<DescribeMachinesResponse>(req, "DescribeMachines")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口已废弃，如需获取分区数量，请使用DescribeTopics接口。
        /// </summary>
        /// <param name="req"><see cref="DescribePartitionsRequest"/></param>
        /// <returns><see cref="DescribePartitionsResponse"/></returns>
        public Task<DescribePartitionsResponse> DescribePartitions(DescribePartitionsRequest req)
        {
            return InternalRequestAsync<DescribePartitionsResponse>(req, "DescribePartitions");
        }

        /// <summary>
        /// 该接口已废弃，如需获取分区数量，请使用DescribeTopics接口。
        /// </summary>
        /// <param name="req"><see cref="DescribePartitionsRequest"/></param>
        /// <returns><see cref="DescribePartitionsResponse"/></returns>
        public DescribePartitionsResponse DescribePartitionsSync(DescribePartitionsRequest req)
        {
            return InternalRequestAsync<DescribePartitionsResponse>(req, "DescribePartitions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于获取定时SQL分析任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScheduledSqlInfoRequest"/></param>
        /// <returns><see cref="DescribeScheduledSqlInfoResponse"/></returns>
        public Task<DescribeScheduledSqlInfoResponse> DescribeScheduledSqlInfo(DescribeScheduledSqlInfoRequest req)
        {
            return InternalRequestAsync<DescribeScheduledSqlInfoResponse>(req, "DescribeScheduledSqlInfo");
        }

        /// <summary>
        /// 本接口用于获取定时SQL分析任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScheduledSqlInfoRequest"/></param>
        /// <returns><see cref="DescribeScheduledSqlInfoResponse"/></returns>
        public DescribeScheduledSqlInfoResponse DescribeScheduledSqlInfoSync(DescribeScheduledSqlInfoRequest req)
        {
            return InternalRequestAsync<DescribeScheduledSqlInfoResponse>(req, "DescribeScheduledSqlInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取投递任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeShipperTasksRequest"/></param>
        /// <returns><see cref="DescribeShipperTasksResponse"/></returns>
        public Task<DescribeShipperTasksResponse> DescribeShipperTasks(DescribeShipperTasksRequest req)
        {
            return InternalRequestAsync<DescribeShipperTasksResponse>(req, "DescribeShipperTasks");
        }

        /// <summary>
        /// 获取投递任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeShipperTasksRequest"/></param>
        /// <returns><see cref="DescribeShipperTasksResponse"/></returns>
        public DescribeShipperTasksResponse DescribeShipperTasksSync(DescribeShipperTasksRequest req)
        {
            return InternalRequestAsync<DescribeShipperTasksResponse>(req, "DescribeShipperTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取投递到COS的任务配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeShippersRequest"/></param>
        /// <returns><see cref="DescribeShippersResponse"/></returns>
        public Task<DescribeShippersResponse> DescribeShippers(DescribeShippersRequest req)
        {
            return InternalRequestAsync<DescribeShippersResponse>(req, "DescribeShippers");
        }

        /// <summary>
        /// 获取投递到COS的任务配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeShippersRequest"/></param>
        /// <returns><see cref="DescribeShippersResponse"/></returns>
        public DescribeShippersResponse DescribeShippersSync(DescribeShippersRequest req)
        {
            return InternalRequestAsync<DescribeShippersResponse>(req, "DescribeShippers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于获取日志主题列表，支持分页
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicsRequest"/></param>
        /// <returns><see cref="DescribeTopicsResponse"/></returns>
        public Task<DescribeTopicsResponse> DescribeTopics(DescribeTopicsRequest req)
        {
            return InternalRequestAsync<DescribeTopicsResponse>(req, "DescribeTopics");
        }

        /// <summary>
        /// 本接口用于获取日志主题列表，支持分页
        /// </summary>
        /// <param name="req"><see cref="DescribeTopicsRequest"/></param>
        /// <returns><see cref="DescribeTopicsResponse"/></returns>
        public DescribeTopicsResponse DescribeTopicsSync(DescribeTopicsRequest req)
        {
            return InternalRequestAsync<DescribeTopicsResponse>(req, "DescribeTopics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于获取告警策略执行详情
        /// </summary>
        /// <param name="req"><see cref="GetAlarmLogRequest"/></param>
        /// <returns><see cref="GetAlarmLogResponse"/></returns>
        public Task<GetAlarmLogResponse> GetAlarmLog(GetAlarmLogRequest req)
        {
            return InternalRequestAsync<GetAlarmLogResponse>(req, "GetAlarmLog");
        }

        /// <summary>
        /// 本接口用于获取告警策略执行详情
        /// </summary>
        /// <param name="req"><see cref="GetAlarmLogRequest"/></param>
        /// <returns><see cref="GetAlarmLogResponse"/></returns>
        public GetAlarmLogResponse GetAlarmLogSync(GetAlarmLogRequest req)
        {
            return InternalRequestAsync<GetAlarmLogResponse>(req, "GetAlarmLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口已废弃，如需修改分区数量，请使用ModifyTopic接口。
        /// </summary>
        /// <param name="req"><see cref="MergePartitionRequest"/></param>
        /// <returns><see cref="MergePartitionResponse"/></returns>
        public Task<MergePartitionResponse> MergePartition(MergePartitionRequest req)
        {
            return InternalRequestAsync<MergePartitionResponse>(req, "MergePartition");
        }

        /// <summary>
        /// 该接口已废弃，如需修改分区数量，请使用ModifyTopic接口。
        /// </summary>
        /// <param name="req"><see cref="MergePartitionRequest"/></param>
        /// <returns><see cref="MergePartitionResponse"/></returns>
        public MergePartitionResponse MergePartitionSync(MergePartitionRequest req)
        {
            return InternalRequestAsync<MergePartitionResponse>(req, "MergePartition")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于修改告警策略。需要至少修改一项有效内容。
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmRequest"/></param>
        /// <returns><see cref="ModifyAlarmResponse"/></returns>
        public Task<ModifyAlarmResponse> ModifyAlarm(ModifyAlarmRequest req)
        {
            return InternalRequestAsync<ModifyAlarmResponse>(req, "ModifyAlarm");
        }

        /// <summary>
        /// 本接口用于修改告警策略。需要至少修改一项有效内容。
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmRequest"/></param>
        /// <returns><see cref="ModifyAlarmResponse"/></returns>
        public ModifyAlarmResponse ModifyAlarmSync(ModifyAlarmRequest req)
        {
            return InternalRequestAsync<ModifyAlarmResponse>(req, "ModifyAlarm")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于修改通知渠道组
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmNoticeRequest"/></param>
        /// <returns><see cref="ModifyAlarmNoticeResponse"/></returns>
        public Task<ModifyAlarmNoticeResponse> ModifyAlarmNotice(ModifyAlarmNoticeRequest req)
        {
            return InternalRequestAsync<ModifyAlarmNoticeResponse>(req, "ModifyAlarmNotice");
        }

        /// <summary>
        /// 该接口用于修改通知渠道组
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmNoticeRequest"/></param>
        /// <returns><see cref="ModifyAlarmNoticeResponse"/></returns>
        public ModifyAlarmNoticeResponse ModifyAlarmNoticeSync(ModifyAlarmNoticeRequest req)
        {
            return InternalRequestAsync<ModifyAlarmNoticeResponse>(req, "ModifyAlarmNotice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于修改告警屏蔽规则。
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmShieldRequest"/></param>
        /// <returns><see cref="ModifyAlarmShieldResponse"/></returns>
        public Task<ModifyAlarmShieldResponse> ModifyAlarmShield(ModifyAlarmShieldRequest req)
        {
            return InternalRequestAsync<ModifyAlarmShieldResponse>(req, "ModifyAlarmShield");
        }

        /// <summary>
        /// 该接口用于修改告警屏蔽规则。
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmShieldRequest"/></param>
        /// <returns><see cref="ModifyAlarmShieldResponse"/></returns>
        public ModifyAlarmShieldResponse ModifyAlarmShieldSync(ModifyAlarmShieldRequest req)
        {
            return InternalRequestAsync<ModifyAlarmShieldResponse>(req, "ModifyAlarmShield")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改采集规则配置
        /// </summary>
        /// <param name="req"><see cref="ModifyConfigRequest"/></param>
        /// <returns><see cref="ModifyConfigResponse"/></returns>
        public Task<ModifyConfigResponse> ModifyConfig(ModifyConfigRequest req)
        {
            return InternalRequestAsync<ModifyConfigResponse>(req, "ModifyConfig");
        }

        /// <summary>
        /// 修改采集规则配置
        /// </summary>
        /// <param name="req"><see cref="ModifyConfigRequest"/></param>
        /// <returns><see cref="ModifyConfigResponse"/></returns>
        public ModifyConfigResponse ModifyConfigSync(ModifyConfigRequest req)
        {
            return InternalRequestAsync<ModifyConfigResponse>(req, "ModifyConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于修改特殊采集配置任务，特殊采集配置应用于自建K8S环境的采集Agent
        /// </summary>
        /// <param name="req"><see cref="ModifyConfigExtraRequest"/></param>
        /// <returns><see cref="ModifyConfigExtraResponse"/></returns>
        public Task<ModifyConfigExtraResponse> ModifyConfigExtra(ModifyConfigExtraRequest req)
        {
            return InternalRequestAsync<ModifyConfigExtraResponse>(req, "ModifyConfigExtra");
        }

        /// <summary>
        /// 本接口用于修改特殊采集配置任务，特殊采集配置应用于自建K8S环境的采集Agent
        /// </summary>
        /// <param name="req"><see cref="ModifyConfigExtraRequest"/></param>
        /// <returns><see cref="ModifyConfigExtraResponse"/></returns>
        public ModifyConfigExtraResponse ModifyConfigExtraSync(ModifyConfigExtraRequest req)
        {
            return InternalRequestAsync<ModifyConfigExtraResponse>(req, "ModifyConfigExtra")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改控制台分享，目前仅允许修改有效期
        /// </summary>
        /// <param name="req"><see cref="ModifyConsoleSharingRequest"/></param>
        /// <returns><see cref="ModifyConsoleSharingResponse"/></returns>
        public Task<ModifyConsoleSharingResponse> ModifyConsoleSharing(ModifyConsoleSharingRequest req)
        {
            return InternalRequestAsync<ModifyConsoleSharingResponse>(req, "ModifyConsoleSharing");
        }

        /// <summary>
        /// 修改控制台分享，目前仅允许修改有效期
        /// </summary>
        /// <param name="req"><see cref="ModifyConsoleSharingRequest"/></param>
        /// <returns><see cref="ModifyConsoleSharingResponse"/></returns>
        public ModifyConsoleSharingResponse ModifyConsoleSharingSync(ModifyConsoleSharingRequest req)
        {
            return InternalRequestAsync<ModifyConsoleSharingResponse>(req, "ModifyConsoleSharing")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于修改投递Ckafka任务
        /// </summary>
        /// <param name="req"><see cref="ModifyConsumerRequest"/></param>
        /// <returns><see cref="ModifyConsumerResponse"/></returns>
        public Task<ModifyConsumerResponse> ModifyConsumer(ModifyConsumerRequest req)
        {
            return InternalRequestAsync<ModifyConsumerResponse>(req, "ModifyConsumer");
        }

        /// <summary>
        /// 本接口用于修改投递Ckafka任务
        /// </summary>
        /// <param name="req"><see cref="ModifyConsumerRequest"/></param>
        /// <returns><see cref="ModifyConsumerResponse"/></returns>
        public ModifyConsumerResponse ModifyConsumerSync(ModifyConsumerRequest req)
        {
            return InternalRequestAsync<ModifyConsumerResponse>(req, "ModifyConsumer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于修改cos导入任务
        /// </summary>
        /// <param name="req"><see cref="ModifyCosRechargeRequest"/></param>
        /// <returns><see cref="ModifyCosRechargeResponse"/></returns>
        public Task<ModifyCosRechargeResponse> ModifyCosRecharge(ModifyCosRechargeRequest req)
        {
            return InternalRequestAsync<ModifyCosRechargeResponse>(req, "ModifyCosRecharge");
        }

        /// <summary>
        /// 本接口用于修改cos导入任务
        /// </summary>
        /// <param name="req"><see cref="ModifyCosRechargeRequest"/></param>
        /// <returns><see cref="ModifyCosRechargeResponse"/></returns>
        public ModifyCosRechargeResponse ModifyCosRechargeSync(ModifyCosRechargeRequest req)
        {
            return InternalRequestAsync<ModifyCosRechargeResponse>(req, "ModifyCosRecharge")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口用于修改仪表盘订阅
        /// </summary>
        /// <param name="req"><see cref="ModifyDashboardSubscribeRequest"/></param>
        /// <returns><see cref="ModifyDashboardSubscribeResponse"/></returns>
        public Task<ModifyDashboardSubscribeResponse> ModifyDashboardSubscribe(ModifyDashboardSubscribeRequest req)
        {
            return InternalRequestAsync<ModifyDashboardSubscribeResponse>(req, "ModifyDashboardSubscribe");
        }

        /// <summary>
        /// 此接口用于修改仪表盘订阅
        /// </summary>
        /// <param name="req"><see cref="ModifyDashboardSubscribeRequest"/></param>
        /// <returns><see cref="ModifyDashboardSubscribeResponse"/></returns>
        public ModifyDashboardSubscribeResponse ModifyDashboardSubscribeSync(ModifyDashboardSubscribeRequest req)
        {
            return InternalRequestAsync<ModifyDashboardSubscribeResponse>(req, "ModifyDashboardSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于修改数据加工任务
        /// </summary>
        /// <param name="req"><see cref="ModifyDataTransformRequest"/></param>
        /// <returns><see cref="ModifyDataTransformResponse"/></returns>
        public Task<ModifyDataTransformResponse> ModifyDataTransform(ModifyDataTransformRequest req)
        {
            return InternalRequestAsync<ModifyDataTransformResponse>(req, "ModifyDataTransform");
        }

        /// <summary>
        /// 本接口用于修改数据加工任务
        /// </summary>
        /// <param name="req"><see cref="ModifyDataTransformRequest"/></param>
        /// <returns><see cref="ModifyDataTransformResponse"/></returns>
        public ModifyDataTransformResponse ModifyDataTransformSync(ModifyDataTransformRequest req)
        {
            return InternalRequestAsync<ModifyDataTransformResponse>(req, "ModifyDataTransform")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于修改索引配置，该接口除受默认接口请求频率限制外，针对单个日志主题，并发数不能超过1，即同一时间同一个日志主题只能有一个正在执行的索引配置修改操作。
        /// </summary>
        /// <param name="req"><see cref="ModifyIndexRequest"/></param>
        /// <returns><see cref="ModifyIndexResponse"/></returns>
        public Task<ModifyIndexResponse> ModifyIndex(ModifyIndexRequest req)
        {
            return InternalRequestAsync<ModifyIndexResponse>(req, "ModifyIndex");
        }

        /// <summary>
        /// 本接口用于修改索引配置，该接口除受默认接口请求频率限制外，针对单个日志主题，并发数不能超过1，即同一时间同一个日志主题只能有一个正在执行的索引配置修改操作。
        /// </summary>
        /// <param name="req"><see cref="ModifyIndexRequest"/></param>
        /// <returns><see cref="ModifyIndexResponse"/></returns>
        public ModifyIndexResponse ModifyIndexSync(ModifyIndexRequest req)
        {
            return InternalRequestAsync<ModifyIndexResponse>(req, "ModifyIndex")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改Kafka协议消费信息
        /// </summary>
        /// <param name="req"><see cref="ModifyKafkaConsumerRequest"/></param>
        /// <returns><see cref="ModifyKafkaConsumerResponse"/></returns>
        public Task<ModifyKafkaConsumerResponse> ModifyKafkaConsumer(ModifyKafkaConsumerRequest req)
        {
            return InternalRequestAsync<ModifyKafkaConsumerResponse>(req, "ModifyKafkaConsumer");
        }

        /// <summary>
        /// 修改Kafka协议消费信息
        /// </summary>
        /// <param name="req"><see cref="ModifyKafkaConsumerRequest"/></param>
        /// <returns><see cref="ModifyKafkaConsumerResponse"/></returns>
        public ModifyKafkaConsumerResponse ModifyKafkaConsumerSync(ModifyKafkaConsumerRequest req)
        {
            return InternalRequestAsync<ModifyKafkaConsumerResponse>(req, "ModifyKafkaConsumer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于修改Kafka数据订阅任务
        /// </summary>
        /// <param name="req"><see cref="ModifyKafkaRechargeRequest"/></param>
        /// <returns><see cref="ModifyKafkaRechargeResponse"/></returns>
        public Task<ModifyKafkaRechargeResponse> ModifyKafkaRecharge(ModifyKafkaRechargeRequest req)
        {
            return InternalRequestAsync<ModifyKafkaRechargeResponse>(req, "ModifyKafkaRecharge");
        }

        /// <summary>
        /// 本接口用于修改Kafka数据订阅任务
        /// </summary>
        /// <param name="req"><see cref="ModifyKafkaRechargeRequest"/></param>
        /// <returns><see cref="ModifyKafkaRechargeResponse"/></returns>
        public ModifyKafkaRechargeResponse ModifyKafkaRechargeSync(ModifyKafkaRechargeRequest req)
        {
            return InternalRequestAsync<ModifyKafkaRechargeResponse>(req, "ModifyKafkaRecharge")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于修改日志集信息
        /// </summary>
        /// <param name="req"><see cref="ModifyLogsetRequest"/></param>
        /// <returns><see cref="ModifyLogsetResponse"/></returns>
        public Task<ModifyLogsetResponse> ModifyLogset(ModifyLogsetRequest req)
        {
            return InternalRequestAsync<ModifyLogsetResponse>(req, "ModifyLogset");
        }

        /// <summary>
        /// 本接口用于修改日志集信息
        /// </summary>
        /// <param name="req"><see cref="ModifyLogsetRequest"/></param>
        /// <returns><see cref="ModifyLogsetResponse"/></returns>
        public ModifyLogsetResponse ModifyLogsetSync(ModifyLogsetRequest req)
        {
            return InternalRequestAsync<ModifyLogsetResponse>(req, "ModifyLogset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改机器组
        /// </summary>
        /// <param name="req"><see cref="ModifyMachineGroupRequest"/></param>
        /// <returns><see cref="ModifyMachineGroupResponse"/></returns>
        public Task<ModifyMachineGroupResponse> ModifyMachineGroup(ModifyMachineGroupRequest req)
        {
            return InternalRequestAsync<ModifyMachineGroupResponse>(req, "ModifyMachineGroup");
        }

        /// <summary>
        /// 修改机器组
        /// </summary>
        /// <param name="req"><see cref="ModifyMachineGroupRequest"/></param>
        /// <returns><see cref="ModifyMachineGroupResponse"/></returns>
        public ModifyMachineGroupResponse ModifyMachineGroupSync(ModifyMachineGroupRequest req)
        {
            return InternalRequestAsync<ModifyMachineGroupResponse>(req, "ModifyMachineGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于修改定时SQL分析任务
        /// </summary>
        /// <param name="req"><see cref="ModifyScheduledSqlRequest"/></param>
        /// <returns><see cref="ModifyScheduledSqlResponse"/></returns>
        public Task<ModifyScheduledSqlResponse> ModifyScheduledSql(ModifyScheduledSqlRequest req)
        {
            return InternalRequestAsync<ModifyScheduledSqlResponse>(req, "ModifyScheduledSql");
        }

        /// <summary>
        /// 本接口用于修改定时SQL分析任务
        /// </summary>
        /// <param name="req"><see cref="ModifyScheduledSqlRequest"/></param>
        /// <returns><see cref="ModifyScheduledSqlResponse"/></returns>
        public ModifyScheduledSqlResponse ModifyScheduledSqlSync(ModifyScheduledSqlRequest req)
        {
            return InternalRequestAsync<ModifyScheduledSqlResponse>(req, "ModifyScheduledSql")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改现有的投递规则，客户如果使用此接口，需要自行处理CLS对指定bucket的写权限。
        /// </summary>
        /// <param name="req"><see cref="ModifyShipperRequest"/></param>
        /// <returns><see cref="ModifyShipperResponse"/></returns>
        public Task<ModifyShipperResponse> ModifyShipper(ModifyShipperRequest req)
        {
            return InternalRequestAsync<ModifyShipperResponse>(req, "ModifyShipper");
        }

        /// <summary>
        /// 修改现有的投递规则，客户如果使用此接口，需要自行处理CLS对指定bucket的写权限。
        /// </summary>
        /// <param name="req"><see cref="ModifyShipperRequest"/></param>
        /// <returns><see cref="ModifyShipperResponse"/></returns>
        public ModifyShipperResponse ModifyShipperSync(ModifyShipperRequest req)
        {
            return InternalRequestAsync<ModifyShipperResponse>(req, "ModifyShipper")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于修改日志主题。
        /// </summary>
        /// <param name="req"><see cref="ModifyTopicRequest"/></param>
        /// <returns><see cref="ModifyTopicResponse"/></returns>
        public Task<ModifyTopicResponse> ModifyTopic(ModifyTopicRequest req)
        {
            return InternalRequestAsync<ModifyTopicResponse>(req, "ModifyTopic");
        }

        /// <summary>
        /// 本接口用于修改日志主题。
        /// </summary>
        /// <param name="req"><see cref="ModifyTopicRequest"/></param>
        /// <returns><see cref="ModifyTopicResponse"/></returns>
        public ModifyTopicResponse ModifyTopicSync(ModifyTopicRequest req)
        {
            return InternalRequestAsync<ModifyTopicResponse>(req, "ModifyTopic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 打开Kafka协议消费功能
        /// </summary>
        /// <param name="req"><see cref="OpenKafkaConsumerRequest"/></param>
        /// <returns><see cref="OpenKafkaConsumerResponse"/></returns>
        public Task<OpenKafkaConsumerResponse> OpenKafkaConsumer(OpenKafkaConsumerRequest req)
        {
            return InternalRequestAsync<OpenKafkaConsumerResponse>(req, "OpenKafkaConsumer");
        }

        /// <summary>
        /// 打开Kafka协议消费功能
        /// </summary>
        /// <param name="req"><see cref="OpenKafkaConsumerRequest"/></param>
        /// <returns><see cref="OpenKafkaConsumerResponse"/></returns>
        public OpenKafkaConsumerResponse OpenKafkaConsumerSync(OpenKafkaConsumerRequest req)
        {
            return InternalRequestAsync<OpenKafkaConsumerResponse>(req, "OpenKafkaConsumer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于预览Kafka数据订阅任务客户日志信息
        /// </summary>
        /// <param name="req"><see cref="PreviewKafkaRechargeRequest"/></param>
        /// <returns><see cref="PreviewKafkaRechargeResponse"/></returns>
        public Task<PreviewKafkaRechargeResponse> PreviewKafkaRecharge(PreviewKafkaRechargeRequest req)
        {
            return InternalRequestAsync<PreviewKafkaRechargeResponse>(req, "PreviewKafkaRecharge");
        }

        /// <summary>
        /// 本接口用于预览Kafka数据订阅任务客户日志信息
        /// </summary>
        /// <param name="req"><see cref="PreviewKafkaRechargeRequest"/></param>
        /// <returns><see cref="PreviewKafkaRechargeResponse"/></returns>
        public PreviewKafkaRechargeResponse PreviewKafkaRechargeSync(PreviewKafkaRechargeRequest req)
        {
            return InternalRequestAsync<PreviewKafkaRechargeResponse>(req, "PreviewKafkaRecharge")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定时刻指标的最新值
        /// </summary>
        /// <param name="req"><see cref="QueryMetricRequest"/></param>
        /// <returns><see cref="QueryMetricResponse"/></returns>
        public Task<QueryMetricResponse> QueryMetric(QueryMetricRequest req)
        {
            return InternalRequestAsync<QueryMetricResponse>(req, "QueryMetric");
        }

        /// <summary>
        /// 查询指定时刻指标的最新值
        /// </summary>
        /// <param name="req"><see cref="QueryMetricRequest"/></param>
        /// <returns><see cref="QueryMetricResponse"/></returns>
        public QueryMetricResponse QueryMetricSync(QueryMetricRequest req)
        {
            return InternalRequestAsync<QueryMetricResponse>(req, "QueryMetric")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定时间范围内指标的变化趋势
        /// </summary>
        /// <param name="req"><see cref="QueryRangeMetricRequest"/></param>
        /// <returns><see cref="QueryRangeMetricResponse"/></returns>
        public Task<QueryRangeMetricResponse> QueryRangeMetric(QueryRangeMetricRequest req)
        {
            return InternalRequestAsync<QueryRangeMetricResponse>(req, "QueryRangeMetric");
        }

        /// <summary>
        /// 查询指定时间范围内指标的变化趋势
        /// </summary>
        /// <param name="req"><see cref="QueryRangeMetricRequest"/></param>
        /// <returns><see cref="QueryRangeMetricResponse"/></returns>
        public QueryRangeMetricResponse QueryRangeMetricSync(QueryRangeMetricRequest req)
        {
            return InternalRequestAsync<QueryRangeMetricResponse>(req, "QueryRangeMetric")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重试失败的投递任务
        /// </summary>
        /// <param name="req"><see cref="RetryShipperTaskRequest"/></param>
        /// <returns><see cref="RetryShipperTaskResponse"/></returns>
        public Task<RetryShipperTaskResponse> RetryShipperTask(RetryShipperTaskRequest req)
        {
            return InternalRequestAsync<RetryShipperTaskResponse>(req, "RetryShipperTask");
        }

        /// <summary>
        /// 重试失败的投递任务
        /// </summary>
        /// <param name="req"><see cref="RetryShipperTaskRequest"/></param>
        /// <returns><see cref="RetryShipperTaskResponse"/></returns>
        public RetryShipperTaskResponse RetryShipperTaskSync(RetryShipperTaskRequest req)
        {
            return InternalRequestAsync<RetryShipperTaskResponse>(req, "RetryShipperTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于预览cos导入信息
        /// </summary>
        /// <param name="req"><see cref="SearchCosRechargeInfoRequest"/></param>
        /// <returns><see cref="SearchCosRechargeInfoResponse"/></returns>
        public Task<SearchCosRechargeInfoResponse> SearchCosRechargeInfo(SearchCosRechargeInfoRequest req)
        {
            return InternalRequestAsync<SearchCosRechargeInfoResponse>(req, "SearchCosRechargeInfo");
        }

        /// <summary>
        /// 本接口用于预览cos导入信息
        /// </summary>
        /// <param name="req"><see cref="SearchCosRechargeInfoRequest"/></param>
        /// <returns><see cref="SearchCosRechargeInfoResponse"/></returns>
        public SearchCosRechargeInfoResponse SearchCosRechargeInfoSync(SearchCosRechargeInfoRequest req)
        {
            return InternalRequestAsync<SearchCosRechargeInfoResponse>(req, "SearchCosRechargeInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口用于预览仪表盘订阅
        /// </summary>
        /// <param name="req"><see cref="SearchDashboardSubscribeRequest"/></param>
        /// <returns><see cref="SearchDashboardSubscribeResponse"/></returns>
        public Task<SearchDashboardSubscribeResponse> SearchDashboardSubscribe(SearchDashboardSubscribeRequest req)
        {
            return InternalRequestAsync<SearchDashboardSubscribeResponse>(req, "SearchDashboardSubscribe");
        }

        /// <summary>
        /// 此接口用于预览仪表盘订阅
        /// </summary>
        /// <param name="req"><see cref="SearchDashboardSubscribeRequest"/></param>
        /// <returns><see cref="SearchDashboardSubscribeResponse"/></returns>
        public SearchDashboardSubscribeResponse SearchDashboardSubscribeSync(SearchDashboardSubscribeRequest req)
        {
            return InternalRequestAsync<SearchDashboardSubscribeResponse>(req, "SearchDashboardSubscribe")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于检索分析日志，使用该接口时请注意如下事项：
        /// 1. 该接口除受默认接口请求频率限制外，针对单个日志主题，查询并发数不能超过15。
        /// 2. 检索语法建议使用CQL语法规则，请使用SyntaxRule参数，将值设置为1。
        /// 3. API返回数据包最大49MB，建议启用 gzip 压缩（HTTP Request Header Accept-Encoding:gzip）。
        /// </summary>
        /// <param name="req"><see cref="SearchLogRequest"/></param>
        /// <returns><see cref="SearchLogResponse"/></returns>
        public Task<SearchLogResponse> SearchLog(SearchLogRequest req)
        {
            return InternalRequestAsync<SearchLogResponse>(req, "SearchLog");
        }

        /// <summary>
        /// 本接口用于检索分析日志，使用该接口时请注意如下事项：
        /// 1. 该接口除受默认接口请求频率限制外，针对单个日志主题，查询并发数不能超过15。
        /// 2. 检索语法建议使用CQL语法规则，请使用SyntaxRule参数，将值设置为1。
        /// 3. API返回数据包最大49MB，建议启用 gzip 压缩（HTTP Request Header Accept-Encoding:gzip）。
        /// </summary>
        /// <param name="req"><see cref="SearchLogRequest"/></param>
        /// <returns><see cref="SearchLogResponse"/></returns>
        public SearchLogResponse SearchLogSync(SearchLogRequest req)
        {
            return InternalRequestAsync<SearchLogResponse>(req, "SearchLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口已废弃，如需修改分区数量，请使用ModifyTopic接口。
        /// </summary>
        /// <param name="req"><see cref="SplitPartitionRequest"/></param>
        /// <returns><see cref="SplitPartitionResponse"/></returns>
        public Task<SplitPartitionResponse> SplitPartition(SplitPartitionRequest req)
        {
            return InternalRequestAsync<SplitPartitionResponse>(req, "SplitPartition");
        }

        /// <summary>
        /// 该接口已废弃，如需修改分区数量，请使用ModifyTopic接口。
        /// </summary>
        /// <param name="req"><see cref="SplitPartitionRequest"/></param>
        /// <returns><see cref="SplitPartitionResponse"/></returns>
        public SplitPartitionResponse SplitPartitionSync(SplitPartitionRequest req)
        {
            return InternalRequestAsync<SplitPartitionResponse>(req, "SplitPartition")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        public Task<UploadLogResponse> UploadLog(UploadLogRequest req)
        {
            return InternalRequestAsync<UploadLogResponse>(req, "UploadLog");
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
            return InternalRequestAsync<UploadLogResponse>(req, "UploadLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}

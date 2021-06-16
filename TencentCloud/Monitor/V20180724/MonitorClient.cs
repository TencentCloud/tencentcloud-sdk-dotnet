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

namespace TencentCloud.Monitor.V20180724
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Monitor.V20180724.Models;

   public class MonitorClient : AbstractClient{

       private const string endpoint = "monitor.tencentcloudapi.com";
       private const string version = "2018-07-24";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MonitorClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public MonitorClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 将告警策略绑定到特定对象
        /// </summary>
        /// <param name="req"><see cref="BindingPolicyObjectRequest"/></param>
        /// <returns><see cref="BindingPolicyObjectResponse"/></returns>
        public async Task<BindingPolicyObjectResponse> BindingPolicyObject(BindingPolicyObjectRequest req)
        {
             JsonResponseModel<BindingPolicyObjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindingPolicyObject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindingPolicyObjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将告警策略绑定到特定对象
        /// </summary>
        /// <param name="req"><see cref="BindingPolicyObjectRequest"/></param>
        /// <returns><see cref="BindingPolicyObjectResponse"/></returns>
        public BindingPolicyObjectResponse BindingPolicyObjectSync(BindingPolicyObjectRequest req)
        {
             JsonResponseModel<BindingPolicyObjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindingPolicyObject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindingPolicyObjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建通知模板
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
        /// 创建通知模板
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
        /// 创建告警策略
        /// </summary>
        /// <param name="req"><see cref="CreateAlarmPolicyRequest"/></param>
        /// <returns><see cref="CreateAlarmPolicyResponse"/></returns>
        public async Task<CreateAlarmPolicyResponse> CreateAlarmPolicy(CreateAlarmPolicyRequest req)
        {
             JsonResponseModel<CreateAlarmPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAlarmPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAlarmPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建告警策略
        /// </summary>
        /// <param name="req"><see cref="CreateAlarmPolicyRequest"/></param>
        /// <returns><see cref="CreateAlarmPolicyResponse"/></returns>
        public CreateAlarmPolicyResponse CreateAlarmPolicySync(CreateAlarmPolicyRequest req)
        {
             JsonResponseModel<CreateAlarmPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAlarmPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAlarmPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建 Prometheus 告警规则。
        /// 
        /// 请注意，**告警对象和告警消息是 Prometheus Rule Annotations 的特殊字段，需要通过 annotations 来传递，对应的 Key 分别为summary/description**，，请参考 [Prometheus Rule更多配置请参考](https://prometheus.io/docs/prometheus/latest/configuration/alerting_rules/)。
        /// </summary>
        /// <param name="req"><see cref="CreateAlertRuleRequest"/></param>
        /// <returns><see cref="CreateAlertRuleResponse"/></returns>
        public async Task<CreateAlertRuleResponse> CreateAlertRule(CreateAlertRuleRequest req)
        {
             JsonResponseModel<CreateAlertRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAlertRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAlertRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建 Prometheus 告警规则。
        /// 
        /// 请注意，**告警对象和告警消息是 Prometheus Rule Annotations 的特殊字段，需要通过 annotations 来传递，对应的 Key 分别为summary/description**，，请参考 [Prometheus Rule更多配置请参考](https://prometheus.io/docs/prometheus/latest/configuration/alerting_rules/)。
        /// </summary>
        /// <param name="req"><see cref="CreateAlertRuleRequest"/></param>
        /// <returns><see cref="CreateAlertRuleResponse"/></returns>
        public CreateAlertRuleResponse CreateAlertRuleSync(CreateAlertRuleRequest req)
        {
             JsonResponseModel<CreateAlertRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAlertRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAlertRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 增加策略组
        /// </summary>
        /// <param name="req"><see cref="CreatePolicyGroupRequest"/></param>
        /// <returns><see cref="CreatePolicyGroupResponse"/></returns>
        public async Task<CreatePolicyGroupResponse> CreatePolicyGroup(CreatePolicyGroupRequest req)
        {
             JsonResponseModel<CreatePolicyGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePolicyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePolicyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 增加策略组
        /// </summary>
        /// <param name="req"><see cref="CreatePolicyGroupRequest"/></param>
        /// <returns><see cref="CreatePolicyGroupResponse"/></returns>
        public CreatePolicyGroupResponse CreatePolicyGroupSync(CreatePolicyGroupRequest req)
        {
             JsonResponseModel<CreatePolicyGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePolicyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePolicyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在腾讯云容器服务下创建 Prometheus 服务发现。
        /// <p>注意：前提条件，已经通过 Prometheus 控制台集成了对应的腾讯云容器服务，具体请参考
        /// <a href="https://cloud.tencent.com/document/product/248/48859" target="_blank">Agent 安装</a>。</p>
        /// </summary>
        /// <param name="req"><see cref="CreateServiceDiscoveryRequest"/></param>
        /// <returns><see cref="CreateServiceDiscoveryResponse"/></returns>
        public async Task<CreateServiceDiscoveryResponse> CreateServiceDiscovery(CreateServiceDiscoveryRequest req)
        {
             JsonResponseModel<CreateServiceDiscoveryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateServiceDiscovery");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateServiceDiscoveryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在腾讯云容器服务下创建 Prometheus 服务发现。
        /// <p>注意：前提条件，已经通过 Prometheus 控制台集成了对应的腾讯云容器服务，具体请参考
        /// <a href="https://cloud.tencent.com/document/product/248/48859" target="_blank">Agent 安装</a>。</p>
        /// </summary>
        /// <param name="req"><see cref="CreateServiceDiscoveryRequest"/></param>
        /// <returns><see cref="CreateServiceDiscoveryResponse"/></returns>
        public CreateServiceDiscoveryResponse CreateServiceDiscoverySync(CreateServiceDiscoveryRequest req)
        {
             JsonResponseModel<CreateServiceDiscoveryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateServiceDiscovery");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateServiceDiscoveryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云监控告警删除告警通知模板
        /// </summary>
        /// <param name="req"><see cref="DeleteAlarmNoticesRequest"/></param>
        /// <returns><see cref="DeleteAlarmNoticesResponse"/></returns>
        public async Task<DeleteAlarmNoticesResponse> DeleteAlarmNotices(DeleteAlarmNoticesRequest req)
        {
             JsonResponseModel<DeleteAlarmNoticesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAlarmNotices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAlarmNoticesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云监控告警删除告警通知模板
        /// </summary>
        /// <param name="req"><see cref="DeleteAlarmNoticesRequest"/></param>
        /// <returns><see cref="DeleteAlarmNoticesResponse"/></returns>
        public DeleteAlarmNoticesResponse DeleteAlarmNoticesSync(DeleteAlarmNoticesRequest req)
        {
             JsonResponseModel<DeleteAlarmNoticesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAlarmNotices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAlarmNoticesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除告警策略
        /// </summary>
        /// <param name="req"><see cref="DeleteAlarmPolicyRequest"/></param>
        /// <returns><see cref="DeleteAlarmPolicyResponse"/></returns>
        public async Task<DeleteAlarmPolicyResponse> DeleteAlarmPolicy(DeleteAlarmPolicyRequest req)
        {
             JsonResponseModel<DeleteAlarmPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAlarmPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAlarmPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除告警策略
        /// </summary>
        /// <param name="req"><see cref="DeleteAlarmPolicyRequest"/></param>
        /// <returns><see cref="DeleteAlarmPolicyResponse"/></returns>
        public DeleteAlarmPolicyResponse DeleteAlarmPolicySync(DeleteAlarmPolicyRequest req)
        {
             JsonResponseModel<DeleteAlarmPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAlarmPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAlarmPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量删除 Prometheus 报警规则
        /// </summary>
        /// <param name="req"><see cref="DeleteAlertRulesRequest"/></param>
        /// <returns><see cref="DeleteAlertRulesResponse"/></returns>
        public async Task<DeleteAlertRulesResponse> DeleteAlertRules(DeleteAlertRulesRequest req)
        {
             JsonResponseModel<DeleteAlertRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAlertRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAlertRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量删除 Prometheus 报警规则
        /// </summary>
        /// <param name="req"><see cref="DeleteAlertRulesRequest"/></param>
        /// <returns><see cref="DeleteAlertRulesResponse"/></returns>
        public DeleteAlertRulesResponse DeleteAlertRulesSync(DeleteAlertRulesRequest req)
        {
             JsonResponseModel<DeleteAlertRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAlertRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAlertRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除告警策略组
        /// </summary>
        /// <param name="req"><see cref="DeletePolicyGroupRequest"/></param>
        /// <returns><see cref="DeletePolicyGroupResponse"/></returns>
        public async Task<DeletePolicyGroupResponse> DeletePolicyGroup(DeletePolicyGroupRequest req)
        {
             JsonResponseModel<DeletePolicyGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePolicyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePolicyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除告警策略组
        /// </summary>
        /// <param name="req"><see cref="DeletePolicyGroupRequest"/></param>
        /// <returns><see cref="DeletePolicyGroupResponse"/></returns>
        public DeletePolicyGroupResponse DeletePolicyGroupSync(DeletePolicyGroupRequest req)
        {
             JsonResponseModel<DeletePolicyGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePolicyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePolicyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除在腾讯云容器服务下创建的 Prometheus 服务发现。
        /// <p>注意：前提条件，已经通过 Prometheus 控制台集成了对应的腾讯云容器服务，具体请参考
        /// <a href="https://cloud.tencent.com/document/product/248/48859" target="_blank">Agent 安装</a>。</p>
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceDiscoveryRequest"/></param>
        /// <returns><see cref="DeleteServiceDiscoveryResponse"/></returns>
        public async Task<DeleteServiceDiscoveryResponse> DeleteServiceDiscovery(DeleteServiceDiscoveryRequest req)
        {
             JsonResponseModel<DeleteServiceDiscoveryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteServiceDiscovery");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteServiceDiscoveryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除在腾讯云容器服务下创建的 Prometheus 服务发现。
        /// <p>注意：前提条件，已经通过 Prometheus 控制台集成了对应的腾讯云容器服务，具体请参考
        /// <a href="https://cloud.tencent.com/document/product/248/48859" target="_blank">Agent 安装</a>。</p>
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceDiscoveryRequest"/></param>
        /// <returns><see cref="DeleteServiceDiscoveryResponse"/></returns>
        public DeleteServiceDiscoveryResponse DeleteServiceDiscoverySync(DeleteServiceDiscoveryRequest req)
        {
             JsonResponseModel<DeleteServiceDiscoveryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteServiceDiscovery");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteServiceDiscoveryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取平台事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAccidentEventListRequest"/></param>
        /// <returns><see cref="DescribeAccidentEventListResponse"/></returns>
        public async Task<DescribeAccidentEventListResponse> DescribeAccidentEventList(DescribeAccidentEventListRequest req)
        {
             JsonResponseModel<DescribeAccidentEventListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccidentEventList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccidentEventListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取平台事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAccidentEventListRequest"/></param>
        /// <returns><see cref="DescribeAccidentEventListResponse"/></returns>
        public DescribeAccidentEventListResponse DescribeAccidentEventListSync(DescribeAccidentEventListRequest req)
        {
             JsonResponseModel<DescribeAccidentEventListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAccidentEventList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccidentEventListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询告警事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmEventsRequest"/></param>
        /// <returns><see cref="DescribeAlarmEventsResponse"/></returns>
        public async Task<DescribeAlarmEventsResponse> DescribeAlarmEvents(DescribeAlarmEventsRequest req)
        {
             JsonResponseModel<DescribeAlarmEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAlarmEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询告警事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmEventsRequest"/></param>
        /// <returns><see cref="DescribeAlarmEventsResponse"/></returns>
        public DescribeAlarmEventsResponse DescribeAlarmEventsSync(DescribeAlarmEventsRequest req)
        {
             JsonResponseModel<DescribeAlarmEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAlarmEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询告警历史
        /// 
        /// 请注意，**如果使用子用户进行告警历史的查询，只能查询到被授权项目下的告警历史**，或不区分项目的产品的告警历史。如何对子账户授予项目的权限，请参考 [访问管理-项目与标签](https://cloud.tencent.com/document/product/598/32738)。
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmHistoriesRequest"/></param>
        /// <returns><see cref="DescribeAlarmHistoriesResponse"/></returns>
        public async Task<DescribeAlarmHistoriesResponse> DescribeAlarmHistories(DescribeAlarmHistoriesRequest req)
        {
             JsonResponseModel<DescribeAlarmHistoriesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAlarmHistories");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmHistoriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询告警历史
        /// 
        /// 请注意，**如果使用子用户进行告警历史的查询，只能查询到被授权项目下的告警历史**，或不区分项目的产品的告警历史。如何对子账户授予项目的权限，请参考 [访问管理-项目与标签](https://cloud.tencent.com/document/product/598/32738)。
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmHistoriesRequest"/></param>
        /// <returns><see cref="DescribeAlarmHistoriesResponse"/></returns>
        public DescribeAlarmHistoriesResponse DescribeAlarmHistoriesSync(DescribeAlarmHistoriesRequest req)
        {
             JsonResponseModel<DescribeAlarmHistoriesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAlarmHistories");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmHistoriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询告警指标列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmMetricsRequest"/></param>
        /// <returns><see cref="DescribeAlarmMetricsResponse"/></returns>
        public async Task<DescribeAlarmMetricsResponse> DescribeAlarmMetrics(DescribeAlarmMetricsRequest req)
        {
             JsonResponseModel<DescribeAlarmMetricsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAlarmMetrics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmMetricsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询告警指标列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmMetricsRequest"/></param>
        /// <returns><see cref="DescribeAlarmMetricsResponse"/></returns>
        public DescribeAlarmMetricsResponse DescribeAlarmMetricsSync(DescribeAlarmMetricsRequest req)
        {
             JsonResponseModel<DescribeAlarmMetricsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAlarmMetrics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmMetricsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询单个通知模板的详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmNoticeRequest"/></param>
        /// <returns><see cref="DescribeAlarmNoticeResponse"/></returns>
        public async Task<DescribeAlarmNoticeResponse> DescribeAlarmNotice(DescribeAlarmNoticeRequest req)
        {
             JsonResponseModel<DescribeAlarmNoticeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAlarmNotice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmNoticeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询单个通知模板的详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmNoticeRequest"/></param>
        /// <returns><see cref="DescribeAlarmNoticeResponse"/></returns>
        public DescribeAlarmNoticeResponse DescribeAlarmNoticeSync(DescribeAlarmNoticeRequest req)
        {
             JsonResponseModel<DescribeAlarmNoticeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAlarmNotice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmNoticeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云监控告警获取告警通知模板所有回调URL
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmNoticeCallbacksRequest"/></param>
        /// <returns><see cref="DescribeAlarmNoticeCallbacksResponse"/></returns>
        public async Task<DescribeAlarmNoticeCallbacksResponse> DescribeAlarmNoticeCallbacks(DescribeAlarmNoticeCallbacksRequest req)
        {
             JsonResponseModel<DescribeAlarmNoticeCallbacksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAlarmNoticeCallbacks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmNoticeCallbacksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云监控告警获取告警通知模板所有回调URL
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmNoticeCallbacksRequest"/></param>
        /// <returns><see cref="DescribeAlarmNoticeCallbacksResponse"/></returns>
        public DescribeAlarmNoticeCallbacksResponse DescribeAlarmNoticeCallbacksSync(DescribeAlarmNoticeCallbacksRequest req)
        {
             JsonResponseModel<DescribeAlarmNoticeCallbacksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAlarmNoticeCallbacks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmNoticeCallbacksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询通知模板列表
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
        /// 查询通知模板列表
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
        /// 查询告警策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmPoliciesRequest"/></param>
        /// <returns><see cref="DescribeAlarmPoliciesResponse"/></returns>
        public async Task<DescribeAlarmPoliciesResponse> DescribeAlarmPolicies(DescribeAlarmPoliciesRequest req)
        {
             JsonResponseModel<DescribeAlarmPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAlarmPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询告警策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmPoliciesRequest"/></param>
        /// <returns><see cref="DescribeAlarmPoliciesResponse"/></returns>
        public DescribeAlarmPoliciesResponse DescribeAlarmPoliciesSync(DescribeAlarmPoliciesRequest req)
        {
             JsonResponseModel<DescribeAlarmPoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAlarmPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取单个告警策略详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmPolicyRequest"/></param>
        /// <returns><see cref="DescribeAlarmPolicyResponse"/></returns>
        public async Task<DescribeAlarmPolicyResponse> DescribeAlarmPolicy(DescribeAlarmPolicyRequest req)
        {
             JsonResponseModel<DescribeAlarmPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAlarmPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取单个告警策略详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmPolicyRequest"/></param>
        /// <returns><see cref="DescribeAlarmPolicyResponse"/></returns>
        public DescribeAlarmPolicyResponse DescribeAlarmPolicySync(DescribeAlarmPolicyRequest req)
        {
             JsonResponseModel<DescribeAlarmPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAlarmPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Prometheus 报警规则查询接口
        /// </summary>
        /// <param name="req"><see cref="DescribeAlertRulesRequest"/></param>
        /// <returns><see cref="DescribeAlertRulesResponse"/></returns>
        public async Task<DescribeAlertRulesResponse> DescribeAlertRules(DescribeAlertRulesRequest req)
        {
             JsonResponseModel<DescribeAlertRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAlertRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlertRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Prometheus 报警规则查询接口
        /// </summary>
        /// <param name="req"><see cref="DescribeAlertRulesRequest"/></param>
        /// <returns><see cref="DescribeAlertRulesResponse"/></returns>
        public DescribeAlertRulesResponse DescribeAlertRulesSync(DescribeAlertRulesRequest req)
        {
             JsonResponseModel<DescribeAlertRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAlertRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlertRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询所有名字空间
        /// </summary>
        /// <param name="req"><see cref="DescribeAllNamespacesRequest"/></param>
        /// <returns><see cref="DescribeAllNamespacesResponse"/></returns>
        public async Task<DescribeAllNamespacesResponse> DescribeAllNamespaces(DescribeAllNamespacesRequest req)
        {
             JsonResponseModel<DescribeAllNamespacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAllNamespaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAllNamespacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询所有名字空间
        /// </summary>
        /// <param name="req"><see cref="DescribeAllNamespacesRequest"/></param>
        /// <returns><see cref="DescribeAllNamespacesResponse"/></returns>
        public DescribeAllNamespacesResponse DescribeAllNamespacesSync(DescribeAllNamespacesRequest req)
        {
             JsonResponseModel<DescribeAllNamespacesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAllNamespaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAllNamespacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基础指标属性
        /// </summary>
        /// <param name="req"><see cref="DescribeBaseMetricsRequest"/></param>
        /// <returns><see cref="DescribeBaseMetricsResponse"/></returns>
        public async Task<DescribeBaseMetricsResponse> DescribeBaseMetrics(DescribeBaseMetricsRequest req)
        {
             JsonResponseModel<DescribeBaseMetricsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBaseMetrics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaseMetricsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基础指标属性
        /// </summary>
        /// <param name="req"><see cref="DescribeBaseMetricsRequest"/></param>
        /// <returns><see cref="DescribeBaseMetricsResponse"/></returns>
        public DescribeBaseMetricsResponse DescribeBaseMetricsSync(DescribeBaseMetricsRequest req)
        {
             JsonResponseModel<DescribeBaseMetricsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBaseMetrics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaseMetricsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基础告警列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBasicAlarmListRequest"/></param>
        /// <returns><see cref="DescribeBasicAlarmListResponse"/></returns>
        public async Task<DescribeBasicAlarmListResponse> DescribeBasicAlarmList(DescribeBasicAlarmListRequest req)
        {
             JsonResponseModel<DescribeBasicAlarmListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBasicAlarmList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBasicAlarmListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基础告警列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBasicAlarmListRequest"/></param>
        /// <returns><see cref="DescribeBasicAlarmListResponse"/></returns>
        public DescribeBasicAlarmListResponse DescribeBasicAlarmListSync(DescribeBasicAlarmListRequest req)
        {
             JsonResponseModel<DescribeBasicAlarmListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBasicAlarmList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBasicAlarmListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取已绑定对象列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBindingPolicyObjectListRequest"/></param>
        /// <returns><see cref="DescribeBindingPolicyObjectListResponse"/></returns>
        public async Task<DescribeBindingPolicyObjectListResponse> DescribeBindingPolicyObjectList(DescribeBindingPolicyObjectListRequest req)
        {
             JsonResponseModel<DescribeBindingPolicyObjectListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBindingPolicyObjectList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBindingPolicyObjectListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取已绑定对象列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBindingPolicyObjectListRequest"/></param>
        /// <returns><see cref="DescribeBindingPolicyObjectListResponse"/></returns>
        public DescribeBindingPolicyObjectListResponse DescribeBindingPolicyObjectListSync(DescribeBindingPolicyObjectListRequest req)
        {
             JsonResponseModel<DescribeBindingPolicyObjectListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBindingPolicyObjectList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBindingPolicyObjectListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云监控支持多种类型的监控，此接口列出支持的所有类型
        /// </summary>
        /// <param name="req"><see cref="DescribeMonitorTypesRequest"/></param>
        /// <returns><see cref="DescribeMonitorTypesResponse"/></returns>
        public async Task<DescribeMonitorTypesResponse> DescribeMonitorTypes(DescribeMonitorTypesRequest req)
        {
             JsonResponseModel<DescribeMonitorTypesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMonitorTypes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMonitorTypesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云监控支持多种类型的监控，此接口列出支持的所有类型
        /// </summary>
        /// <param name="req"><see cref="DescribeMonitorTypesRequest"/></param>
        /// <returns><see cref="DescribeMonitorTypesResponse"/></returns>
        public DescribeMonitorTypesResponse DescribeMonitorTypesSync(DescribeMonitorTypesRequest req)
        {
             JsonResponseModel<DescribeMonitorTypesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMonitorTypes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMonitorTypesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基础告警策略条件
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyConditionListRequest"/></param>
        /// <returns><see cref="DescribePolicyConditionListResponse"/></returns>
        public async Task<DescribePolicyConditionListResponse> DescribePolicyConditionList(DescribePolicyConditionListRequest req)
        {
             JsonResponseModel<DescribePolicyConditionListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePolicyConditionList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePolicyConditionListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基础告警策略条件
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyConditionListRequest"/></param>
        /// <returns><see cref="DescribePolicyConditionListResponse"/></returns>
        public DescribePolicyConditionListResponse DescribePolicyConditionListSync(DescribePolicyConditionListRequest req)
        {
             JsonResponseModel<DescribePolicyConditionListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePolicyConditionList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePolicyConditionListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基础策略组详情
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyGroupInfoRequest"/></param>
        /// <returns><see cref="DescribePolicyGroupInfoResponse"/></returns>
        public async Task<DescribePolicyGroupInfoResponse> DescribePolicyGroupInfo(DescribePolicyGroupInfoRequest req)
        {
             JsonResponseModel<DescribePolicyGroupInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePolicyGroupInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePolicyGroupInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基础策略组详情
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyGroupInfoRequest"/></param>
        /// <returns><see cref="DescribePolicyGroupInfoResponse"/></returns>
        public DescribePolicyGroupInfoResponse DescribePolicyGroupInfoSync(DescribePolicyGroupInfoRequest req)
        {
             JsonResponseModel<DescribePolicyGroupInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePolicyGroupInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePolicyGroupInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基础策略告警组列表
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyGroupListRequest"/></param>
        /// <returns><see cref="DescribePolicyGroupListResponse"/></returns>
        public async Task<DescribePolicyGroupListResponse> DescribePolicyGroupList(DescribePolicyGroupListRequest req)
        {
             JsonResponseModel<DescribePolicyGroupListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePolicyGroupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePolicyGroupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基础策略告警组列表
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyGroupListRequest"/></param>
        /// <returns><see cref="DescribePolicyGroupListResponse"/></returns>
        public DescribePolicyGroupListResponse DescribePolicyGroupListSync(DescribePolicyGroupListRequest req)
        {
             JsonResponseModel<DescribePolicyGroupListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePolicyGroupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePolicyGroupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 分页获取产品事件的列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProductEventListRequest"/></param>
        /// <returns><see cref="DescribeProductEventListResponse"/></returns>
        public async Task<DescribeProductEventListResponse> DescribeProductEventList(DescribeProductEventListRequest req)
        {
             JsonResponseModel<DescribeProductEventListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProductEventList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductEventListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 分页获取产品事件的列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProductEventListRequest"/></param>
        /// <returns><see cref="DescribeProductEventListResponse"/></returns>
        public DescribeProductEventListResponse DescribeProductEventListSync(DescribeProductEventListRequest req)
        {
             JsonResponseModel<DescribeProductEventListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProductEventList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductEventListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云监控产品列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProductListRequest"/></param>
        /// <returns><see cref="DescribeProductListResponse"/></returns>
        public async Task<DescribeProductListResponse> DescribeProductList(DescribeProductListRequest req)
        {
             JsonResponseModel<DescribeProductListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProductList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云监控产品列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProductListRequest"/></param>
        /// <returns><see cref="DescribeProductListResponse"/></returns>
        public DescribeProductListResponse DescribeProductListSync(DescribeProductListRequest req)
        {
             JsonResponseModel<DescribeProductListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProductList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 列出在腾讯云容器服务下创建的 Prometheus 服务发现。
        /// <p>注意：前提条件，已经通过 Prometheus 控制台集成了对应的腾讯云容器服务，具体请参考
        /// <a href="https://cloud.tencent.com/document/product/248/48859" target="_blank">Agent 安装</a>。</p>
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceDiscoveryRequest"/></param>
        /// <returns><see cref="DescribeServiceDiscoveryResponse"/></returns>
        public async Task<DescribeServiceDiscoveryResponse> DescribeServiceDiscovery(DescribeServiceDiscoveryRequest req)
        {
             JsonResponseModel<DescribeServiceDiscoveryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeServiceDiscovery");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceDiscoveryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 列出在腾讯云容器服务下创建的 Prometheus 服务发现。
        /// <p>注意：前提条件，已经通过 Prometheus 控制台集成了对应的腾讯云容器服务，具体请参考
        /// <a href="https://cloud.tencent.com/document/product/248/48859" target="_blank">Agent 安装</a>。</p>
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceDiscoveryRequest"/></param>
        /// <returns><see cref="DescribeServiceDiscoveryResponse"/></returns>
        public DescribeServiceDiscoveryResponse DescribeServiceDiscoverySync(DescribeServiceDiscoveryRequest req)
        {
             JsonResponseModel<DescribeServiceDiscoveryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeServiceDiscovery");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceDiscoveryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据维度条件查询监控数据
        /// </summary>
        /// <param name="req"><see cref="DescribeStatisticDataRequest"/></param>
        /// <returns><see cref="DescribeStatisticDataResponse"/></returns>
        public async Task<DescribeStatisticDataResponse> DescribeStatisticData(DescribeStatisticDataRequest req)
        {
             JsonResponseModel<DescribeStatisticDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStatisticData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStatisticDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据维度条件查询监控数据
        /// </summary>
        /// <param name="req"><see cref="DescribeStatisticDataRequest"/></param>
        /// <returns><see cref="DescribeStatisticDataResponse"/></returns>
        public DescribeStatisticDataResponse DescribeStatisticDataSync(DescribeStatisticDataRequest req)
        {
             JsonResponseModel<DescribeStatisticDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStatisticData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStatisticDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取云产品的监控数据。此接口不适用于拉取容器服务监控数据，如需拉取容器服务监控数据，请使用[根据维度条件查询监控数据](https://cloud.tencent.com/document/product/248/51845)接口。
        /// 传入产品的命名空间、对象维度描述和监控指标即可获得相应的监控数据。
        /// 接口调用频率限制为：20次/秒，1200次/分钟。单请求最多可支持批量拉取10个实例的监控数据，单请求的数据点数限制为1440个。
        /// 若您需要调用的指标、对象较多，可能存在因限频出现拉取失败的情况，建议尽量将请求按时间维度均摊。
        /// </summary>
        /// <param name="req"><see cref="GetMonitorDataRequest"/></param>
        /// <returns><see cref="GetMonitorDataResponse"/></returns>
        public async Task<GetMonitorDataResponse> GetMonitorData(GetMonitorDataRequest req)
        {
             JsonResponseModel<GetMonitorDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetMonitorData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetMonitorDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取云产品的监控数据。此接口不适用于拉取容器服务监控数据，如需拉取容器服务监控数据，请使用[根据维度条件查询监控数据](https://cloud.tencent.com/document/product/248/51845)接口。
        /// 传入产品的命名空间、对象维度描述和监控指标即可获得相应的监控数据。
        /// 接口调用频率限制为：20次/秒，1200次/分钟。单请求最多可支持批量拉取10个实例的监控数据，单请求的数据点数限制为1440个。
        /// 若您需要调用的指标、对象较多，可能存在因限频出现拉取失败的情况，建议尽量将请求按时间维度均摊。
        /// </summary>
        /// <param name="req"><see cref="GetMonitorDataRequest"/></param>
        /// <returns><see cref="GetMonitorDataResponse"/></returns>
        public GetMonitorDataResponse GetMonitorDataSync(GetMonitorDataRequest req)
        {
             JsonResponseModel<GetMonitorDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetMonitorData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetMonitorDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云监控告警编辑告警通知模板
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
        /// 云监控告警编辑告警通知模板
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
        /// 修改告警策略触发条件
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmPolicyConditionRequest"/></param>
        /// <returns><see cref="ModifyAlarmPolicyConditionResponse"/></returns>
        public async Task<ModifyAlarmPolicyConditionResponse> ModifyAlarmPolicyCondition(ModifyAlarmPolicyConditionRequest req)
        {
             JsonResponseModel<ModifyAlarmPolicyConditionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAlarmPolicyCondition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAlarmPolicyConditionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改告警策略触发条件
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmPolicyConditionRequest"/></param>
        /// <returns><see cref="ModifyAlarmPolicyConditionResponse"/></returns>
        public ModifyAlarmPolicyConditionResponse ModifyAlarmPolicyConditionSync(ModifyAlarmPolicyConditionRequest req)
        {
             JsonResponseModel<ModifyAlarmPolicyConditionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAlarmPolicyCondition");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAlarmPolicyConditionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 告警2.0编辑告警策略基本信息，包括策略名、备注
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmPolicyInfoRequest"/></param>
        /// <returns><see cref="ModifyAlarmPolicyInfoResponse"/></returns>
        public async Task<ModifyAlarmPolicyInfoResponse> ModifyAlarmPolicyInfo(ModifyAlarmPolicyInfoRequest req)
        {
             JsonResponseModel<ModifyAlarmPolicyInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAlarmPolicyInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAlarmPolicyInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 告警2.0编辑告警策略基本信息，包括策略名、备注
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmPolicyInfoRequest"/></param>
        /// <returns><see cref="ModifyAlarmPolicyInfoResponse"/></returns>
        public ModifyAlarmPolicyInfoResponse ModifyAlarmPolicyInfoSync(ModifyAlarmPolicyInfoRequest req)
        {
             JsonResponseModel<ModifyAlarmPolicyInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAlarmPolicyInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAlarmPolicyInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云监控告警修改告警策略绑定的告警通知模板
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmPolicyNoticeRequest"/></param>
        /// <returns><see cref="ModifyAlarmPolicyNoticeResponse"/></returns>
        public async Task<ModifyAlarmPolicyNoticeResponse> ModifyAlarmPolicyNotice(ModifyAlarmPolicyNoticeRequest req)
        {
             JsonResponseModel<ModifyAlarmPolicyNoticeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAlarmPolicyNotice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAlarmPolicyNoticeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云监控告警修改告警策略绑定的告警通知模板
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmPolicyNoticeRequest"/></param>
        /// <returns><see cref="ModifyAlarmPolicyNoticeResponse"/></returns>
        public ModifyAlarmPolicyNoticeResponse ModifyAlarmPolicyNoticeSync(ModifyAlarmPolicyNoticeRequest req)
        {
             JsonResponseModel<ModifyAlarmPolicyNoticeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAlarmPolicyNotice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAlarmPolicyNoticeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启停告警策略
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmPolicyStatusRequest"/></param>
        /// <returns><see cref="ModifyAlarmPolicyStatusResponse"/></returns>
        public async Task<ModifyAlarmPolicyStatusResponse> ModifyAlarmPolicyStatus(ModifyAlarmPolicyStatusRequest req)
        {
             JsonResponseModel<ModifyAlarmPolicyStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAlarmPolicyStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAlarmPolicyStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启停告警策略
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmPolicyStatusRequest"/></param>
        /// <returns><see cref="ModifyAlarmPolicyStatusResponse"/></returns>
        public ModifyAlarmPolicyStatusResponse ModifyAlarmPolicyStatusSync(ModifyAlarmPolicyStatusRequest req)
        {
             JsonResponseModel<ModifyAlarmPolicyStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAlarmPolicyStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAlarmPolicyStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云监控告警修改告警策略的触发任务，TriggerTasks字段放触发任务列表，TriggerTasks传空数组时，代表解绑该策略的所有触发任务。
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmPolicyTasksRequest"/></param>
        /// <returns><see cref="ModifyAlarmPolicyTasksResponse"/></returns>
        public async Task<ModifyAlarmPolicyTasksResponse> ModifyAlarmPolicyTasks(ModifyAlarmPolicyTasksRequest req)
        {
             JsonResponseModel<ModifyAlarmPolicyTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAlarmPolicyTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAlarmPolicyTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云监控告警修改告警策略的触发任务，TriggerTasks字段放触发任务列表，TriggerTasks传空数组时，代表解绑该策略的所有触发任务。
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmPolicyTasksRequest"/></param>
        /// <returns><see cref="ModifyAlarmPolicyTasksResponse"/></returns>
        public ModifyAlarmPolicyTasksResponse ModifyAlarmPolicyTasksSync(ModifyAlarmPolicyTasksRequest req)
        {
             JsonResponseModel<ModifyAlarmPolicyTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAlarmPolicyTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAlarmPolicyTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改告警接收人
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmReceiversRequest"/></param>
        /// <returns><see cref="ModifyAlarmReceiversResponse"/></returns>
        public async Task<ModifyAlarmReceiversResponse> ModifyAlarmReceivers(ModifyAlarmReceiversRequest req)
        {
             JsonResponseModel<ModifyAlarmReceiversResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAlarmReceivers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAlarmReceiversResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改告警接收人
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmReceiversRequest"/></param>
        /// <returns><see cref="ModifyAlarmReceiversResponse"/></returns>
        public ModifyAlarmReceiversResponse ModifyAlarmReceiversSync(ModifyAlarmReceiversRequest req)
        {
             JsonResponseModel<ModifyAlarmReceiversResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAlarmReceivers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAlarmReceiversResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新策略组
        /// </summary>
        /// <param name="req"><see cref="ModifyPolicyGroupRequest"/></param>
        /// <returns><see cref="ModifyPolicyGroupResponse"/></returns>
        public async Task<ModifyPolicyGroupResponse> ModifyPolicyGroup(ModifyPolicyGroupRequest req)
        {
             JsonResponseModel<ModifyPolicyGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPolicyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPolicyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新策略组
        /// </summary>
        /// <param name="req"><see cref="ModifyPolicyGroupRequest"/></param>
        /// <returns><see cref="ModifyPolicyGroupResponse"/></returns>
        public ModifyPolicyGroupResponse ModifyPolicyGroupSync(ModifyPolicyGroupRequest req)
        {
             JsonResponseModel<ModifyPolicyGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPolicyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPolicyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 默认接口请求频率限制：50次/秒。
        /// 默认单租户指标上限：100个。
        /// 单次上报最多 30 个指标/值对，请求返回错误时，请求中所有的指标/值均不会被保存。
        /// 
        /// 上报的时间戳为期望保存的时间戳，建议构造整数分钟时刻的时间戳。
        /// 时间戳时间范围必须为当前时间到 300 秒前之间。
        /// 同一 IP 指标对的数据需按分钟先后顺序上报。
        /// </summary>
        /// <param name="req"><see cref="PutMonitorDataRequest"/></param>
        /// <returns><see cref="PutMonitorDataResponse"/></returns>
        public async Task<PutMonitorDataResponse> PutMonitorData(PutMonitorDataRequest req)
        {
             JsonResponseModel<PutMonitorDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PutMonitorData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PutMonitorDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 默认接口请求频率限制：50次/秒。
        /// 默认单租户指标上限：100个。
        /// 单次上报最多 30 个指标/值对，请求返回错误时，请求中所有的指标/值均不会被保存。
        /// 
        /// 上报的时间戳为期望保存的时间戳，建议构造整数分钟时刻的时间戳。
        /// 时间戳时间范围必须为当前时间到 300 秒前之间。
        /// 同一 IP 指标对的数据需按分钟先后顺序上报。
        /// </summary>
        /// <param name="req"><see cref="PutMonitorDataRequest"/></param>
        /// <returns><see cref="PutMonitorDataResponse"/></returns>
        public PutMonitorDataResponse PutMonitorDataSync(PutMonitorDataRequest req)
        {
             JsonResponseModel<PutMonitorDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PutMonitorData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PutMonitorDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发送自定义消息告警
        /// </summary>
        /// <param name="req"><see cref="SendCustomAlarmMsgRequest"/></param>
        /// <returns><see cref="SendCustomAlarmMsgResponse"/></returns>
        public async Task<SendCustomAlarmMsgResponse> SendCustomAlarmMsg(SendCustomAlarmMsgRequest req)
        {
             JsonResponseModel<SendCustomAlarmMsgResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendCustomAlarmMsg");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendCustomAlarmMsgResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发送自定义消息告警
        /// </summary>
        /// <param name="req"><see cref="SendCustomAlarmMsgRequest"/></param>
        /// <returns><see cref="SendCustomAlarmMsgResponse"/></returns>
        public SendCustomAlarmMsgResponse SendCustomAlarmMsgSync(SendCustomAlarmMsgRequest req)
        {
             JsonResponseModel<SendCustomAlarmMsgResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SendCustomAlarmMsg");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendCustomAlarmMsgResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置一个策略为该告警策略类型、该项目的默认告警策略。
        /// 同一项目下相同的告警策略类型，就会被设置为非默认。
        /// </summary>
        /// <param name="req"><see cref="SetDefaultAlarmPolicyRequest"/></param>
        /// <returns><see cref="SetDefaultAlarmPolicyResponse"/></returns>
        public async Task<SetDefaultAlarmPolicyResponse> SetDefaultAlarmPolicy(SetDefaultAlarmPolicyRequest req)
        {
             JsonResponseModel<SetDefaultAlarmPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetDefaultAlarmPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetDefaultAlarmPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置一个策略为该告警策略类型、该项目的默认告警策略。
        /// 同一项目下相同的告警策略类型，就会被设置为非默认。
        /// </summary>
        /// <param name="req"><see cref="SetDefaultAlarmPolicyRequest"/></param>
        /// <returns><see cref="SetDefaultAlarmPolicyResponse"/></returns>
        public SetDefaultAlarmPolicyResponse SetDefaultAlarmPolicySync(SetDefaultAlarmPolicyRequest req)
        {
             JsonResponseModel<SetDefaultAlarmPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetDefaultAlarmPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetDefaultAlarmPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除全部的关联对象
        /// </summary>
        /// <param name="req"><see cref="UnBindingAllPolicyObjectRequest"/></param>
        /// <returns><see cref="UnBindingAllPolicyObjectResponse"/></returns>
        public async Task<UnBindingAllPolicyObjectResponse> UnBindingAllPolicyObject(UnBindingAllPolicyObjectRequest req)
        {
             JsonResponseModel<UnBindingAllPolicyObjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnBindingAllPolicyObject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnBindingAllPolicyObjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除全部的关联对象
        /// </summary>
        /// <param name="req"><see cref="UnBindingAllPolicyObjectRequest"/></param>
        /// <returns><see cref="UnBindingAllPolicyObjectResponse"/></returns>
        public UnBindingAllPolicyObjectResponse UnBindingAllPolicyObjectSync(UnBindingAllPolicyObjectRequest req)
        {
             JsonResponseModel<UnBindingAllPolicyObjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnBindingAllPolicyObject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnBindingAllPolicyObjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除策略的关联对象
        /// </summary>
        /// <param name="req"><see cref="UnBindingPolicyObjectRequest"/></param>
        /// <returns><see cref="UnBindingPolicyObjectResponse"/></returns>
        public async Task<UnBindingPolicyObjectResponse> UnBindingPolicyObject(UnBindingPolicyObjectRequest req)
        {
             JsonResponseModel<UnBindingPolicyObjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnBindingPolicyObject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnBindingPolicyObjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除策略的关联对象
        /// </summary>
        /// <param name="req"><see cref="UnBindingPolicyObjectRequest"/></param>
        /// <returns><see cref="UnBindingPolicyObjectResponse"/></returns>
        public UnBindingPolicyObjectResponse UnBindingPolicyObjectSync(UnBindingPolicyObjectRequest req)
        {
             JsonResponseModel<UnBindingPolicyObjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnBindingPolicyObject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnBindingPolicyObjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新 Prometheus 的报警规则。
        /// 
        /// 请注意，**告警对象和告警消息是 Prometheus Rule Annotations 的特殊字段，需要通过 annotations 来传递，对应的 Key 分别为summary/description**，，请参考 [Prometheus Rule更多配置请参考](https://prometheus.io/docs/prometheus/latest/configuration/alerting_rules/)。
        /// </summary>
        /// <param name="req"><see cref="UpdateAlertRuleRequest"/></param>
        /// <returns><see cref="UpdateAlertRuleResponse"/></returns>
        public async Task<UpdateAlertRuleResponse> UpdateAlertRule(UpdateAlertRuleRequest req)
        {
             JsonResponseModel<UpdateAlertRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateAlertRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateAlertRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新 Prometheus 的报警规则。
        /// 
        /// 请注意，**告警对象和告警消息是 Prometheus Rule Annotations 的特殊字段，需要通过 annotations 来传递，对应的 Key 分别为summary/description**，，请参考 [Prometheus Rule更多配置请参考](https://prometheus.io/docs/prometheus/latest/configuration/alerting_rules/)。
        /// </summary>
        /// <param name="req"><see cref="UpdateAlertRuleRequest"/></param>
        /// <returns><see cref="UpdateAlertRuleResponse"/></returns>
        public UpdateAlertRuleResponse UpdateAlertRuleSync(UpdateAlertRuleRequest req)
        {
             JsonResponseModel<UpdateAlertRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateAlertRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateAlertRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新 Prometheus 报警策略状态
        /// </summary>
        /// <param name="req"><see cref="UpdateAlertRuleStateRequest"/></param>
        /// <returns><see cref="UpdateAlertRuleStateResponse"/></returns>
        public async Task<UpdateAlertRuleStateResponse> UpdateAlertRuleState(UpdateAlertRuleStateRequest req)
        {
             JsonResponseModel<UpdateAlertRuleStateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateAlertRuleState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateAlertRuleStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新 Prometheus 报警策略状态
        /// </summary>
        /// <param name="req"><see cref="UpdateAlertRuleStateRequest"/></param>
        /// <returns><see cref="UpdateAlertRuleStateResponse"/></returns>
        public UpdateAlertRuleStateResponse UpdateAlertRuleStateSync(UpdateAlertRuleStateRequest req)
        {
             JsonResponseModel<UpdateAlertRuleStateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateAlertRuleState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateAlertRuleStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在腾讯云容器服务下更新 Prometheus 服务发现。
        /// <p>注意：前提条件，已经通过 Prometheus 控制台集成了对应的腾讯云容器服务，具体请参考
        /// <a href="https://cloud.tencent.com/document/product/248/48859" target="_blank">Agent 安装</a>。</p>
        /// </summary>
        /// <param name="req"><see cref="UpdateServiceDiscoveryRequest"/></param>
        /// <returns><see cref="UpdateServiceDiscoveryResponse"/></returns>
        public async Task<UpdateServiceDiscoveryResponse> UpdateServiceDiscovery(UpdateServiceDiscoveryRequest req)
        {
             JsonResponseModel<UpdateServiceDiscoveryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateServiceDiscovery");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateServiceDiscoveryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在腾讯云容器服务下更新 Prometheus 服务发现。
        /// <p>注意：前提条件，已经通过 Prometheus 控制台集成了对应的腾讯云容器服务，具体请参考
        /// <a href="https://cloud.tencent.com/document/product/248/48859" target="_blank">Agent 安装</a>。</p>
        /// </summary>
        /// <param name="req"><see cref="UpdateServiceDiscoveryRequest"/></param>
        /// <returns><see cref="UpdateServiceDiscoveryResponse"/></returns>
        public UpdateServiceDiscoveryResponse UpdateServiceDiscoverySync(UpdateServiceDiscoveryRequest req)
        {
             JsonResponseModel<UpdateServiceDiscoveryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateServiceDiscovery");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateServiceDiscoveryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}

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
       private const string sdkVersion = "SDK_NET_3.0.1062";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MonitorClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 绑定 Grafana 可视化服务实例
        /// </summary>
        /// <param name="req"><see cref="BindPrometheusManagedGrafanaRequest"/></param>
        /// <returns><see cref="BindPrometheusManagedGrafanaResponse"/></returns>
        public Task<BindPrometheusManagedGrafanaResponse> BindPrometheusManagedGrafana(BindPrometheusManagedGrafanaRequest req)
        {
            return InternalRequestAsync<BindPrometheusManagedGrafanaResponse>(req, "BindPrometheusManagedGrafana");
        }

        /// <summary>
        /// 绑定 Grafana 可视化服务实例
        /// </summary>
        /// <param name="req"><see cref="BindPrometheusManagedGrafanaRequest"/></param>
        /// <returns><see cref="BindPrometheusManagedGrafanaResponse"/></returns>
        public BindPrometheusManagedGrafanaResponse BindPrometheusManagedGrafanaSync(BindPrometheusManagedGrafanaRequest req)
        {
            return InternalRequestAsync<BindPrometheusManagedGrafanaResponse>(req, "BindPrometheusManagedGrafana")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 将告警策略绑定到特定对象
        /// </summary>
        /// <param name="req"><see cref="BindingPolicyObjectRequest"/></param>
        /// <returns><see cref="BindingPolicyObjectResponse"/></returns>
        public Task<BindingPolicyObjectResponse> BindingPolicyObject(BindingPolicyObjectRequest req)
        {
            return InternalRequestAsync<BindingPolicyObjectResponse>(req, "BindingPolicyObject");
        }

        /// <summary>
        /// 将告警策略绑定到特定对象
        /// </summary>
        /// <param name="req"><see cref="BindingPolicyObjectRequest"/></param>
        /// <returns><see cref="BindingPolicyObjectResponse"/></returns>
        public BindingPolicyObjectResponse BindingPolicyObjectSync(BindingPolicyObjectRequest req)
        {
            return InternalRequestAsync<BindingPolicyObjectResponse>(req, "BindingPolicyObject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 策略绑定标签
        /// </summary>
        /// <param name="req"><see cref="BindingPolicyTagRequest"/></param>
        /// <returns><see cref="BindingPolicyTagResponse"/></returns>
        public Task<BindingPolicyTagResponse> BindingPolicyTag(BindingPolicyTagRequest req)
        {
            return InternalRequestAsync<BindingPolicyTagResponse>(req, "BindingPolicyTag");
        }

        /// <summary>
        /// 策略绑定标签
        /// </summary>
        /// <param name="req"><see cref="BindingPolicyTagRequest"/></param>
        /// <returns><see cref="BindingPolicyTagResponse"/></returns>
        public BindingPolicyTagResponse BindingPolicyTagSync(BindingPolicyTagRequest req)
        {
            return InternalRequestAsync<BindingPolicyTagResponse>(req, "BindingPolicyTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 接口功能是检查是否为prometheus新用户，已有其他功能更加全面的接口替代
        /// 
        /// 判断用户是否为云原生监控新用户，即在任何地域下均未创建过监控实例的用户
        /// </summary>
        /// <param name="req"><see cref="CheckIsPrometheusNewUserRequest"/></param>
        /// <returns><see cref="CheckIsPrometheusNewUserResponse"/></returns>
        public Task<CheckIsPrometheusNewUserResponse> CheckIsPrometheusNewUser(CheckIsPrometheusNewUserRequest req)
        {
            return InternalRequestAsync<CheckIsPrometheusNewUserResponse>(req, "CheckIsPrometheusNewUser");
        }

        /// <summary>
        /// 接口功能是检查是否为prometheus新用户，已有其他功能更加全面的接口替代
        /// 
        /// 判断用户是否为云原生监控新用户，即在任何地域下均未创建过监控实例的用户
        /// </summary>
        /// <param name="req"><see cref="CheckIsPrometheusNewUserRequest"/></param>
        /// <returns><see cref="CheckIsPrometheusNewUserResponse"/></returns>
        public CheckIsPrometheusNewUserResponse CheckIsPrometheusNewUserSync(CheckIsPrometheusNewUserRequest req)
        {
            return InternalRequestAsync<CheckIsPrometheusNewUserResponse>(req, "CheckIsPrometheusNewUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 强制销毁 Grafana 实例
        /// </summary>
        /// <param name="req"><see cref="CleanGrafanaInstanceRequest"/></param>
        /// <returns><see cref="CleanGrafanaInstanceResponse"/></returns>
        public Task<CleanGrafanaInstanceResponse> CleanGrafanaInstance(CleanGrafanaInstanceRequest req)
        {
            return InternalRequestAsync<CleanGrafanaInstanceResponse>(req, "CleanGrafanaInstance");
        }

        /// <summary>
        /// 强制销毁 Grafana 实例
        /// </summary>
        /// <param name="req"><see cref="CleanGrafanaInstanceRequest"/></param>
        /// <returns><see cref="CleanGrafanaInstanceResponse"/></returns>
        public CleanGrafanaInstanceResponse CleanGrafanaInstanceSync(CleanGrafanaInstanceRequest req)
        {
            return InternalRequestAsync<CleanGrafanaInstanceResponse>(req, "CleanGrafanaInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建通知模板
        /// </summary>
        /// <param name="req"><see cref="CreateAlarmNoticeRequest"/></param>
        /// <returns><see cref="CreateAlarmNoticeResponse"/></returns>
        public Task<CreateAlarmNoticeResponse> CreateAlarmNotice(CreateAlarmNoticeRequest req)
        {
            return InternalRequestAsync<CreateAlarmNoticeResponse>(req, "CreateAlarmNotice");
        }

        /// <summary>
        /// 创建通知模板
        /// </summary>
        /// <param name="req"><see cref="CreateAlarmNoticeRequest"/></param>
        /// <returns><see cref="CreateAlarmNoticeResponse"/></returns>
        public CreateAlarmNoticeResponse CreateAlarmNoticeSync(CreateAlarmNoticeRequest req)
        {
            return InternalRequestAsync<CreateAlarmNoticeResponse>(req, "CreateAlarmNotice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建告警策略
        /// </summary>
        /// <param name="req"><see cref="CreateAlarmPolicyRequest"/></param>
        /// <returns><see cref="CreateAlarmPolicyResponse"/></returns>
        public Task<CreateAlarmPolicyResponse> CreateAlarmPolicy(CreateAlarmPolicyRequest req)
        {
            return InternalRequestAsync<CreateAlarmPolicyResponse>(req, "CreateAlarmPolicy");
        }

        /// <summary>
        /// 创建告警策略
        /// </summary>
        /// <param name="req"><see cref="CreateAlarmPolicyRequest"/></param>
        /// <returns><see cref="CreateAlarmPolicyResponse"/></returns>
        public CreateAlarmPolicyResponse CreateAlarmPolicySync(CreateAlarmPolicyRequest req)
        {
            return InternalRequestAsync<CreateAlarmPolicyResponse>(req, "CreateAlarmPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建 Prometheus 告警规则。
        /// 
        /// 请注意，**告警对象和告警消息是 Prometheus Rule Annotations 的特殊字段，需要通过 annotations 来传递，对应的 Key 分别为summary/description**，，请参考 [Prometheus Rule更多配置请参考](https://prometheus.io/docs/prometheus/latest/configuration/alerting_rules/)。
        /// </summary>
        /// <param name="req"><see cref="CreateAlertRuleRequest"/></param>
        /// <returns><see cref="CreateAlertRuleResponse"/></returns>
        public Task<CreateAlertRuleResponse> CreateAlertRule(CreateAlertRuleRequest req)
        {
            return InternalRequestAsync<CreateAlertRuleResponse>(req, "CreateAlertRule");
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
            return InternalRequestAsync<CreateAlertRuleResponse>(req, "CreateAlertRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建集成中心 exporter 集成，因集成较多，建议控制台创建集成。(前提：已授权创建托管 EKS 集群，验证方式：1. 控制台界面确认，未提示授权则表示已授权创建；2. 通过 DescribePrometheusInstanceInitStatus 接口查询集群状态，如果托管集群不存在，可通过 RunPrometheusInstance 接口创建)
        /// </summary>
        /// <param name="req"><see cref="CreateExporterIntegrationRequest"/></param>
        /// <returns><see cref="CreateExporterIntegrationResponse"/></returns>
        public Task<CreateExporterIntegrationResponse> CreateExporterIntegration(CreateExporterIntegrationRequest req)
        {
            return InternalRequestAsync<CreateExporterIntegrationResponse>(req, "CreateExporterIntegration");
        }

        /// <summary>
        /// 创建集成中心 exporter 集成，因集成较多，建议控制台创建集成。(前提：已授权创建托管 EKS 集群，验证方式：1. 控制台界面确认，未提示授权则表示已授权创建；2. 通过 DescribePrometheusInstanceInitStatus 接口查询集群状态，如果托管集群不存在，可通过 RunPrometheusInstance 接口创建)
        /// </summary>
        /// <param name="req"><see cref="CreateExporterIntegrationRequest"/></param>
        /// <returns><see cref="CreateExporterIntegrationResponse"/></returns>
        public CreateExporterIntegrationResponse CreateExporterIntegrationSync(CreateExporterIntegrationRequest req)
        {
            return InternalRequestAsync<CreateExporterIntegrationResponse>(req, "CreateExporterIntegration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（CreateGrafanaInstance）用于创建 Grafana 包年包月实例，默认基础版、到期自动续费、不可使用代金券。
        /// </summary>
        /// <param name="req"><see cref="CreateGrafanaInstanceRequest"/></param>
        /// <returns><see cref="CreateGrafanaInstanceResponse"/></returns>
        public Task<CreateGrafanaInstanceResponse> CreateGrafanaInstance(CreateGrafanaInstanceRequest req)
        {
            return InternalRequestAsync<CreateGrafanaInstanceResponse>(req, "CreateGrafanaInstance");
        }

        /// <summary>
        /// 本接口（CreateGrafanaInstance）用于创建 Grafana 包年包月实例，默认基础版、到期自动续费、不可使用代金券。
        /// </summary>
        /// <param name="req"><see cref="CreateGrafanaInstanceRequest"/></param>
        /// <returns><see cref="CreateGrafanaInstanceResponse"/></returns>
        public CreateGrafanaInstanceResponse CreateGrafanaInstanceSync(CreateGrafanaInstanceRequest req)
        {
            return InternalRequestAsync<CreateGrafanaInstanceResponse>(req, "CreateGrafanaInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建 Grafana 集成配置，其中 Prometheus 集成不通过该接口创建，可参考 BindPrometheusManagedGrafana 接口
        /// </summary>
        /// <param name="req"><see cref="CreateGrafanaIntegrationRequest"/></param>
        /// <returns><see cref="CreateGrafanaIntegrationResponse"/></returns>
        public Task<CreateGrafanaIntegrationResponse> CreateGrafanaIntegration(CreateGrafanaIntegrationRequest req)
        {
            return InternalRequestAsync<CreateGrafanaIntegrationResponse>(req, "CreateGrafanaIntegration");
        }

        /// <summary>
        /// 创建 Grafana 集成配置，其中 Prometheus 集成不通过该接口创建，可参考 BindPrometheusManagedGrafana 接口
        /// </summary>
        /// <param name="req"><see cref="CreateGrafanaIntegrationRequest"/></param>
        /// <returns><see cref="CreateGrafanaIntegrationResponse"/></returns>
        public CreateGrafanaIntegrationResponse CreateGrafanaIntegrationSync(CreateGrafanaIntegrationRequest req)
        {
            return InternalRequestAsync<CreateGrafanaIntegrationResponse>(req, "CreateGrafanaIntegration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建 Grafana 告警通道
        /// </summary>
        /// <param name="req"><see cref="CreateGrafanaNotificationChannelRequest"/></param>
        /// <returns><see cref="CreateGrafanaNotificationChannelResponse"/></returns>
        public Task<CreateGrafanaNotificationChannelResponse> CreateGrafanaNotificationChannel(CreateGrafanaNotificationChannelRequest req)
        {
            return InternalRequestAsync<CreateGrafanaNotificationChannelResponse>(req, "CreateGrafanaNotificationChannel");
        }

        /// <summary>
        /// 创建 Grafana 告警通道
        /// </summary>
        /// <param name="req"><see cref="CreateGrafanaNotificationChannelRequest"/></param>
        /// <returns><see cref="CreateGrafanaNotificationChannelResponse"/></returns>
        public CreateGrafanaNotificationChannelResponse CreateGrafanaNotificationChannelSync(CreateGrafanaNotificationChannelRequest req)
        {
            return InternalRequestAsync<CreateGrafanaNotificationChannelResponse>(req, "CreateGrafanaNotificationChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 增加策略组
        /// </summary>
        /// <param name="req"><see cref="CreatePolicyGroupRequest"/></param>
        /// <returns><see cref="CreatePolicyGroupResponse"/></returns>
        public Task<CreatePolicyGroupResponse> CreatePolicyGroup(CreatePolicyGroupRequest req)
        {
            return InternalRequestAsync<CreatePolicyGroupResponse>(req, "CreatePolicyGroup");
        }

        /// <summary>
        /// 增加策略组
        /// </summary>
        /// <param name="req"><see cref="CreatePolicyGroupRequest"/></param>
        /// <returns><see cref="CreatePolicyGroupResponse"/></returns>
        public CreatePolicyGroupResponse CreatePolicyGroupSync(CreatePolicyGroupRequest req)
        {
            return InternalRequestAsync<CreatePolicyGroupResponse>(req, "CreatePolicyGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建 Prometheus CVM Agent
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusAgentRequest"/></param>
        /// <returns><see cref="CreatePrometheusAgentResponse"/></returns>
        public Task<CreatePrometheusAgentResponse> CreatePrometheusAgent(CreatePrometheusAgentRequest req)
        {
            return InternalRequestAsync<CreatePrometheusAgentResponse>(req, "CreatePrometheusAgent");
        }

        /// <summary>
        /// 创建 Prometheus CVM Agent
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusAgentRequest"/></param>
        /// <returns><see cref="CreatePrometheusAgentResponse"/></returns>
        public CreatePrometheusAgentResponse CreatePrometheusAgentSync(CreatePrometheusAgentRequest req)
        {
            return InternalRequestAsync<CreatePrometheusAgentResponse>(req, "CreatePrometheusAgent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建Prometheus告警规则分组
        /// 
        /// 告警分组中可包含多条告警规则，分组内告警消息通过告警分组的通知模板发送。
        /// 支持单个告警分组下分别创建启用/禁用的告警规则。
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusAlertGroupRequest"/></param>
        /// <returns><see cref="CreatePrometheusAlertGroupResponse"/></returns>
        public Task<CreatePrometheusAlertGroupResponse> CreatePrometheusAlertGroup(CreatePrometheusAlertGroupRequest req)
        {
            return InternalRequestAsync<CreatePrometheusAlertGroupResponse>(req, "CreatePrometheusAlertGroup");
        }

        /// <summary>
        /// 创建Prometheus告警规则分组
        /// 
        /// 告警分组中可包含多条告警规则，分组内告警消息通过告警分组的通知模板发送。
        /// 支持单个告警分组下分别创建启用/禁用的告警规则。
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusAlertGroupRequest"/></param>
        /// <returns><see cref="CreatePrometheusAlertGroupResponse"/></returns>
        public CreatePrometheusAlertGroupResponse CreatePrometheusAlertGroupSync(CreatePrometheusAlertGroupRequest req)
        {
            return InternalRequestAsync<CreatePrometheusAlertGroupResponse>(req, "CreatePrometheusAlertGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建 Prometheus 告警策略(将逐步废弃，建议使用 CreatePrometheusAlertGroup 创建告警策略)
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusAlertPolicyRequest"/></param>
        /// <returns><see cref="CreatePrometheusAlertPolicyResponse"/></returns>
        public Task<CreatePrometheusAlertPolicyResponse> CreatePrometheusAlertPolicy(CreatePrometheusAlertPolicyRequest req)
        {
            return InternalRequestAsync<CreatePrometheusAlertPolicyResponse>(req, "CreatePrometheusAlertPolicy");
        }

        /// <summary>
        /// 创建 Prometheus 告警策略(将逐步废弃，建议使用 CreatePrometheusAlertGroup 创建告警策略)
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusAlertPolicyRequest"/></param>
        /// <returns><see cref="CreatePrometheusAlertPolicyResponse"/></returns>
        public CreatePrometheusAlertPolicyResponse CreatePrometheusAlertPolicySync(CreatePrometheusAlertPolicyRequest req)
        {
            return InternalRequestAsync<CreatePrometheusAlertPolicyResponse>(req, "CreatePrometheusAlertPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 与腾讯云可观测融合的2.0实例关联集群
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusClusterAgentRequest"/></param>
        /// <returns><see cref="CreatePrometheusClusterAgentResponse"/></returns>
        public Task<CreatePrometheusClusterAgentResponse> CreatePrometheusClusterAgent(CreatePrometheusClusterAgentRequest req)
        {
            return InternalRequestAsync<CreatePrometheusClusterAgentResponse>(req, "CreatePrometheusClusterAgent");
        }

        /// <summary>
        /// 与腾讯云可观测融合的2.0实例关联集群
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusClusterAgentRequest"/></param>
        /// <returns><see cref="CreatePrometheusClusterAgentResponse"/></returns>
        public CreatePrometheusClusterAgentResponse CreatePrometheusClusterAgentSync(CreatePrometheusClusterAgentRequest req)
        {
            return InternalRequestAsync<CreatePrometheusClusterAgentResponse>(req, "CreatePrometheusClusterAgent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建prometheus配置
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusConfigRequest"/></param>
        /// <returns><see cref="CreatePrometheusConfigResponse"/></returns>
        public Task<CreatePrometheusConfigResponse> CreatePrometheusConfig(CreatePrometheusConfigRequest req)
        {
            return InternalRequestAsync<CreatePrometheusConfigResponse>(req, "CreatePrometheusConfig");
        }

        /// <summary>
        /// 创建prometheus配置
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusConfigRequest"/></param>
        /// <returns><see cref="CreatePrometheusConfigResponse"/></returns>
        public CreatePrometheusConfigResponse CreatePrometheusConfigSync(CreatePrometheusConfigRequest req)
        {
            return InternalRequestAsync<CreatePrometheusConfigResponse>(req, "CreatePrometheusConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建全局告警通知渠道。集群内创建的告警规则如果未配置告警通知渠道，默认走全局告警通知渠道（建议在控制台创建告警，集群内创建告警不易维护）
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusGlobalNotificationRequest"/></param>
        /// <returns><see cref="CreatePrometheusGlobalNotificationResponse"/></returns>
        public Task<CreatePrometheusGlobalNotificationResponse> CreatePrometheusGlobalNotification(CreatePrometheusGlobalNotificationRequest req)
        {
            return InternalRequestAsync<CreatePrometheusGlobalNotificationResponse>(req, "CreatePrometheusGlobalNotification");
        }

        /// <summary>
        /// 创建全局告警通知渠道。集群内创建的告警规则如果未配置告警通知渠道，默认走全局告警通知渠道（建议在控制台创建告警，集群内创建告警不易维护）
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusGlobalNotificationRequest"/></param>
        /// <returns><see cref="CreatePrometheusGlobalNotificationResponse"/></returns>
        public CreatePrometheusGlobalNotificationResponse CreatePrometheusGlobalNotificationSync(CreatePrometheusGlobalNotificationRequest req)
        {
            return InternalRequestAsync<CreatePrometheusGlobalNotificationResponse>(req, "CreatePrometheusGlobalNotification")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建按量 Prometheus 实例，根据用量收费实例
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusMultiTenantInstancePostPayModeRequest"/></param>
        /// <returns><see cref="CreatePrometheusMultiTenantInstancePostPayModeResponse"/></returns>
        public Task<CreatePrometheusMultiTenantInstancePostPayModeResponse> CreatePrometheusMultiTenantInstancePostPayMode(CreatePrometheusMultiTenantInstancePostPayModeRequest req)
        {
            return InternalRequestAsync<CreatePrometheusMultiTenantInstancePostPayModeResponse>(req, "CreatePrometheusMultiTenantInstancePostPayMode");
        }

        /// <summary>
        /// 创建按量 Prometheus 实例，根据用量收费实例
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusMultiTenantInstancePostPayModeRequest"/></param>
        /// <returns><see cref="CreatePrometheusMultiTenantInstancePostPayModeResponse"/></returns>
        public CreatePrometheusMultiTenantInstancePostPayModeResponse CreatePrometheusMultiTenantInstancePostPayModeSync(CreatePrometheusMultiTenantInstancePostPayModeRequest req)
        {
            return InternalRequestAsync<CreatePrometheusMultiTenantInstancePostPayModeResponse>(req, "CreatePrometheusMultiTenantInstancePostPayMode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 以Yaml的方式创建聚合规则
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusRecordRuleYamlRequest"/></param>
        /// <returns><see cref="CreatePrometheusRecordRuleYamlResponse"/></returns>
        public Task<CreatePrometheusRecordRuleYamlResponse> CreatePrometheusRecordRuleYaml(CreatePrometheusRecordRuleYamlRequest req)
        {
            return InternalRequestAsync<CreatePrometheusRecordRuleYamlResponse>(req, "CreatePrometheusRecordRuleYaml");
        }

        /// <summary>
        /// 以Yaml的方式创建聚合规则
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusRecordRuleYamlRequest"/></param>
        /// <returns><see cref="CreatePrometheusRecordRuleYamlResponse"/></returns>
        public CreatePrometheusRecordRuleYamlResponse CreatePrometheusRecordRuleYamlSync(CreatePrometheusRecordRuleYamlRequest req)
        {
            return InternalRequestAsync<CreatePrometheusRecordRuleYamlResponse>(req, "CreatePrometheusRecordRuleYaml")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建 Prometheus Agent 抓取任务
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusScrapeJobRequest"/></param>
        /// <returns><see cref="CreatePrometheusScrapeJobResponse"/></returns>
        public Task<CreatePrometheusScrapeJobResponse> CreatePrometheusScrapeJob(CreatePrometheusScrapeJobRequest req)
        {
            return InternalRequestAsync<CreatePrometheusScrapeJobResponse>(req, "CreatePrometheusScrapeJob");
        }

        /// <summary>
        /// 创建 Prometheus Agent 抓取任务
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusScrapeJobRequest"/></param>
        /// <returns><see cref="CreatePrometheusScrapeJobResponse"/></returns>
        public CreatePrometheusScrapeJobResponse CreatePrometheusScrapeJobSync(CreatePrometheusScrapeJobRequest req)
        {
            return InternalRequestAsync<CreatePrometheusScrapeJobResponse>(req, "CreatePrometheusScrapeJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建一个云原生Prometheus模板
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusTempRequest"/></param>
        /// <returns><see cref="CreatePrometheusTempResponse"/></returns>
        public Task<CreatePrometheusTempResponse> CreatePrometheusTemp(CreatePrometheusTempRequest req)
        {
            return InternalRequestAsync<CreatePrometheusTempResponse>(req, "CreatePrometheusTemp");
        }

        /// <summary>
        /// 创建一个云原生Prometheus模板
        /// </summary>
        /// <param name="req"><see cref="CreatePrometheusTempRequest"/></param>
        /// <returns><see cref="CreatePrometheusTempResponse"/></returns>
        public CreatePrometheusTempResponse CreatePrometheusTempSync(CreatePrometheusTempRequest req)
        {
            return InternalRequestAsync<CreatePrometheusTempResponse>(req, "CreatePrometheusTemp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建 Prometheus 的预聚合规则
        /// </summary>
        /// <param name="req"><see cref="CreateRecordingRuleRequest"/></param>
        /// <returns><see cref="CreateRecordingRuleResponse"/></returns>
        public Task<CreateRecordingRuleResponse> CreateRecordingRule(CreateRecordingRuleRequest req)
        {
            return InternalRequestAsync<CreateRecordingRuleResponse>(req, "CreateRecordingRule");
        }

        /// <summary>
        /// 创建 Prometheus 的预聚合规则
        /// </summary>
        /// <param name="req"><see cref="CreateRecordingRuleRequest"/></param>
        /// <returns><see cref="CreateRecordingRuleResponse"/></returns>
        public CreateRecordingRuleResponse CreateRecordingRuleSync(CreateRecordingRuleRequest req)
        {
            return InternalRequestAsync<CreateRecordingRuleResponse>(req, "CreateRecordingRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Grafana实例授权其他腾讯云用户
        /// </summary>
        /// <param name="req"><see cref="CreateSSOAccountRequest"/></param>
        /// <returns><see cref="CreateSSOAccountResponse"/></returns>
        public Task<CreateSSOAccountResponse> CreateSSOAccount(CreateSSOAccountRequest req)
        {
            return InternalRequestAsync<CreateSSOAccountResponse>(req, "CreateSSOAccount");
        }

        /// <summary>
        /// Grafana实例授权其他腾讯云用户
        /// </summary>
        /// <param name="req"><see cref="CreateSSOAccountRequest"/></param>
        /// <returns><see cref="CreateSSOAccountResponse"/></returns>
        public CreateSSOAccountResponse CreateSSOAccountSync(CreateSSOAccountRequest req)
        {
            return InternalRequestAsync<CreateSSOAccountResponse>(req, "CreateSSOAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在腾讯云容器服务下创建 Prometheus 服务发现。
        /// <p>注意：前提条件，已经通过 Prometheus 控制台集成了对应的腾讯云容器服务，具体请参考
        /// <a href="https://cloud.tencent.com/document/product/248/48859" target="_blank">Agent 安装</a>。</p>
        /// </summary>
        /// <param name="req"><see cref="CreateServiceDiscoveryRequest"/></param>
        /// <returns><see cref="CreateServiceDiscoveryResponse"/></returns>
        public Task<CreateServiceDiscoveryResponse> CreateServiceDiscovery(CreateServiceDiscoveryRequest req)
        {
            return InternalRequestAsync<CreateServiceDiscoveryResponse>(req, "CreateServiceDiscovery");
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
            return InternalRequestAsync<CreateServiceDiscoveryResponse>(req, "CreateServiceDiscovery")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除告警通知模板
        /// </summary>
        /// <param name="req"><see cref="DeleteAlarmNoticesRequest"/></param>
        /// <returns><see cref="DeleteAlarmNoticesResponse"/></returns>
        public Task<DeleteAlarmNoticesResponse> DeleteAlarmNotices(DeleteAlarmNoticesRequest req)
        {
            return InternalRequestAsync<DeleteAlarmNoticesResponse>(req, "DeleteAlarmNotices");
        }

        /// <summary>
        /// 删除告警通知模板
        /// </summary>
        /// <param name="req"><see cref="DeleteAlarmNoticesRequest"/></param>
        /// <returns><see cref="DeleteAlarmNoticesResponse"/></returns>
        public DeleteAlarmNoticesResponse DeleteAlarmNoticesSync(DeleteAlarmNoticesRequest req)
        {
            return InternalRequestAsync<DeleteAlarmNoticesResponse>(req, "DeleteAlarmNotices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除告警策略
        /// </summary>
        /// <param name="req"><see cref="DeleteAlarmPolicyRequest"/></param>
        /// <returns><see cref="DeleteAlarmPolicyResponse"/></returns>
        public Task<DeleteAlarmPolicyResponse> DeleteAlarmPolicy(DeleteAlarmPolicyRequest req)
        {
            return InternalRequestAsync<DeleteAlarmPolicyResponse>(req, "DeleteAlarmPolicy");
        }

        /// <summary>
        /// 删除告警策略
        /// </summary>
        /// <param name="req"><see cref="DeleteAlarmPolicyRequest"/></param>
        /// <returns><see cref="DeleteAlarmPolicyResponse"/></returns>
        public DeleteAlarmPolicyResponse DeleteAlarmPolicySync(DeleteAlarmPolicyRequest req)
        {
            return InternalRequestAsync<DeleteAlarmPolicyResponse>(req, "DeleteAlarmPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量删除 Prometheus 报警规则
        /// </summary>
        /// <param name="req"><see cref="DeleteAlertRulesRequest"/></param>
        /// <returns><see cref="DeleteAlertRulesResponse"/></returns>
        public Task<DeleteAlertRulesResponse> DeleteAlertRules(DeleteAlertRulesRequest req)
        {
            return InternalRequestAsync<DeleteAlertRulesResponse>(req, "DeleteAlertRules");
        }

        /// <summary>
        /// 批量删除 Prometheus 报警规则
        /// </summary>
        /// <param name="req"><see cref="DeleteAlertRulesRequest"/></param>
        /// <returns><see cref="DeleteAlertRulesResponse"/></returns>
        public DeleteAlertRulesResponse DeleteAlertRulesSync(DeleteAlertRulesRequest req)
        {
            return InternalRequestAsync<DeleteAlertRulesResponse>(req, "DeleteAlertRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除集成中心 exporter 集成
        /// </summary>
        /// <param name="req"><see cref="DeleteExporterIntegrationRequest"/></param>
        /// <returns><see cref="DeleteExporterIntegrationResponse"/></returns>
        public Task<DeleteExporterIntegrationResponse> DeleteExporterIntegration(DeleteExporterIntegrationRequest req)
        {
            return InternalRequestAsync<DeleteExporterIntegrationResponse>(req, "DeleteExporterIntegration");
        }

        /// <summary>
        /// 删除集成中心 exporter 集成
        /// </summary>
        /// <param name="req"><see cref="DeleteExporterIntegrationRequest"/></param>
        /// <returns><see cref="DeleteExporterIntegrationResponse"/></returns>
        public DeleteExporterIntegrationResponse DeleteExporterIntegrationSync(DeleteExporterIntegrationRequest req)
        {
            return InternalRequestAsync<DeleteExporterIntegrationResponse>(req, "DeleteExporterIntegration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteGrafanaInstance）用于 Grafana 包年包月实例的退费，调用后实例处于停服状态，不可使用，7天后自动销毁。
        /// </summary>
        /// <param name="req"><see cref="DeleteGrafanaInstanceRequest"/></param>
        /// <returns><see cref="DeleteGrafanaInstanceResponse"/></returns>
        public Task<DeleteGrafanaInstanceResponse> DeleteGrafanaInstance(DeleteGrafanaInstanceRequest req)
        {
            return InternalRequestAsync<DeleteGrafanaInstanceResponse>(req, "DeleteGrafanaInstance");
        }

        /// <summary>
        /// 本接口（DeleteGrafanaInstance）用于 Grafana 包年包月实例的退费，调用后实例处于停服状态，不可使用，7天后自动销毁。
        /// </summary>
        /// <param name="req"><see cref="DeleteGrafanaInstanceRequest"/></param>
        /// <returns><see cref="DeleteGrafanaInstanceResponse"/></returns>
        public DeleteGrafanaInstanceResponse DeleteGrafanaInstanceSync(DeleteGrafanaInstanceRequest req)
        {
            return InternalRequestAsync<DeleteGrafanaInstanceResponse>(req, "DeleteGrafanaInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除 Grafana 集成配置
        /// </summary>
        /// <param name="req"><see cref="DeleteGrafanaIntegrationRequest"/></param>
        /// <returns><see cref="DeleteGrafanaIntegrationResponse"/></returns>
        public Task<DeleteGrafanaIntegrationResponse> DeleteGrafanaIntegration(DeleteGrafanaIntegrationRequest req)
        {
            return InternalRequestAsync<DeleteGrafanaIntegrationResponse>(req, "DeleteGrafanaIntegration");
        }

        /// <summary>
        /// 删除 Grafana 集成配置
        /// </summary>
        /// <param name="req"><see cref="DeleteGrafanaIntegrationRequest"/></param>
        /// <returns><see cref="DeleteGrafanaIntegrationResponse"/></returns>
        public DeleteGrafanaIntegrationResponse DeleteGrafanaIntegrationSync(DeleteGrafanaIntegrationRequest req)
        {
            return InternalRequestAsync<DeleteGrafanaIntegrationResponse>(req, "DeleteGrafanaIntegration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除 Grafana 告警通道
        /// </summary>
        /// <param name="req"><see cref="DeleteGrafanaNotificationChannelRequest"/></param>
        /// <returns><see cref="DeleteGrafanaNotificationChannelResponse"/></returns>
        public Task<DeleteGrafanaNotificationChannelResponse> DeleteGrafanaNotificationChannel(DeleteGrafanaNotificationChannelRequest req)
        {
            return InternalRequestAsync<DeleteGrafanaNotificationChannelResponse>(req, "DeleteGrafanaNotificationChannel");
        }

        /// <summary>
        /// 删除 Grafana 告警通道
        /// </summary>
        /// <param name="req"><see cref="DeleteGrafanaNotificationChannelRequest"/></param>
        /// <returns><see cref="DeleteGrafanaNotificationChannelResponse"/></returns>
        public DeleteGrafanaNotificationChannelResponse DeleteGrafanaNotificationChannelSync(DeleteGrafanaNotificationChannelRequest req)
        {
            return InternalRequestAsync<DeleteGrafanaNotificationChannelResponse>(req, "DeleteGrafanaNotificationChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除告警策略组
        /// </summary>
        /// <param name="req"><see cref="DeletePolicyGroupRequest"/></param>
        /// <returns><see cref="DeletePolicyGroupResponse"/></returns>
        public Task<DeletePolicyGroupResponse> DeletePolicyGroup(DeletePolicyGroupRequest req)
        {
            return InternalRequestAsync<DeletePolicyGroupResponse>(req, "DeletePolicyGroup");
        }

        /// <summary>
        /// 删除告警策略组
        /// </summary>
        /// <param name="req"><see cref="DeletePolicyGroupRequest"/></param>
        /// <returns><see cref="DeletePolicyGroupResponse"/></returns>
        public DeletePolicyGroupResponse DeletePolicyGroupSync(DeletePolicyGroupRequest req)
        {
            return InternalRequestAsync<DeletePolicyGroupResponse>(req, "DeletePolicyGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除Prometheus告警规则分组
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusAlertGroupsRequest"/></param>
        /// <returns><see cref="DeletePrometheusAlertGroupsResponse"/></returns>
        public Task<DeletePrometheusAlertGroupsResponse> DeletePrometheusAlertGroups(DeletePrometheusAlertGroupsRequest req)
        {
            return InternalRequestAsync<DeletePrometheusAlertGroupsResponse>(req, "DeletePrometheusAlertGroups");
        }

        /// <summary>
        /// 删除Prometheus告警规则分组
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusAlertGroupsRequest"/></param>
        /// <returns><see cref="DeletePrometheusAlertGroupsResponse"/></returns>
        public DeletePrometheusAlertGroupsResponse DeletePrometheusAlertGroupsSync(DeletePrometheusAlertGroupsRequest req)
        {
            return InternalRequestAsync<DeletePrometheusAlertGroupsResponse>(req, "DeletePrometheusAlertGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除2.0实例告警策略
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusAlertPolicyRequest"/></param>
        /// <returns><see cref="DeletePrometheusAlertPolicyResponse"/></returns>
        public Task<DeletePrometheusAlertPolicyResponse> DeletePrometheusAlertPolicy(DeletePrometheusAlertPolicyRequest req)
        {
            return InternalRequestAsync<DeletePrometheusAlertPolicyResponse>(req, "DeletePrometheusAlertPolicy");
        }

        /// <summary>
        /// 删除2.0实例告警策略
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusAlertPolicyRequest"/></param>
        /// <returns><see cref="DeletePrometheusAlertPolicyResponse"/></returns>
        public DeletePrometheusAlertPolicyResponse DeletePrometheusAlertPolicySync(DeletePrometheusAlertPolicyRequest req)
        {
            return InternalRequestAsync<DeletePrometheusAlertPolicyResponse>(req, "DeletePrometheusAlertPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解除TMP实例的集群关联
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusClusterAgentRequest"/></param>
        /// <returns><see cref="DeletePrometheusClusterAgentResponse"/></returns>
        public Task<DeletePrometheusClusterAgentResponse> DeletePrometheusClusterAgent(DeletePrometheusClusterAgentRequest req)
        {
            return InternalRequestAsync<DeletePrometheusClusterAgentResponse>(req, "DeletePrometheusClusterAgent");
        }

        /// <summary>
        /// 解除TMP实例的集群关联
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusClusterAgentRequest"/></param>
        /// <returns><see cref="DeletePrometheusClusterAgentResponse"/></returns>
        public DeletePrometheusClusterAgentResponse DeletePrometheusClusterAgentSync(DeletePrometheusClusterAgentRequest req)
        {
            return InternalRequestAsync<DeletePrometheusClusterAgentResponse>(req, "DeletePrometheusClusterAgent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除Prometheus配置，如果目标不存在，将返回成功
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusConfigRequest"/></param>
        /// <returns><see cref="DeletePrometheusConfigResponse"/></returns>
        public Task<DeletePrometheusConfigResponse> DeletePrometheusConfig(DeletePrometheusConfigRequest req)
        {
            return InternalRequestAsync<DeletePrometheusConfigResponse>(req, "DeletePrometheusConfig");
        }

        /// <summary>
        /// 删除Prometheus配置，如果目标不存在，将返回成功
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusConfigRequest"/></param>
        /// <returns><see cref="DeletePrometheusConfigResponse"/></returns>
        public DeletePrometheusConfigResponse DeletePrometheusConfigSync(DeletePrometheusConfigRequest req)
        {
            return InternalRequestAsync<DeletePrometheusConfigResponse>(req, "DeletePrometheusConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除聚合实例
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusRecordRuleYamlRequest"/></param>
        /// <returns><see cref="DeletePrometheusRecordRuleYamlResponse"/></returns>
        public Task<DeletePrometheusRecordRuleYamlResponse> DeletePrometheusRecordRuleYaml(DeletePrometheusRecordRuleYamlRequest req)
        {
            return InternalRequestAsync<DeletePrometheusRecordRuleYamlResponse>(req, "DeletePrometheusRecordRuleYaml");
        }

        /// <summary>
        /// 删除聚合实例
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusRecordRuleYamlRequest"/></param>
        /// <returns><see cref="DeletePrometheusRecordRuleYamlResponse"/></returns>
        public DeletePrometheusRecordRuleYamlResponse DeletePrometheusRecordRuleYamlSync(DeletePrometheusRecordRuleYamlRequest req)
        {
            return InternalRequestAsync<DeletePrometheusRecordRuleYamlResponse>(req, "DeletePrometheusRecordRuleYaml")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除 Prometheus Agent 抓取任务
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusScrapeJobsRequest"/></param>
        /// <returns><see cref="DeletePrometheusScrapeJobsResponse"/></returns>
        public Task<DeletePrometheusScrapeJobsResponse> DeletePrometheusScrapeJobs(DeletePrometheusScrapeJobsRequest req)
        {
            return InternalRequestAsync<DeletePrometheusScrapeJobsResponse>(req, "DeletePrometheusScrapeJobs");
        }

        /// <summary>
        /// 删除 Prometheus Agent 抓取任务
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusScrapeJobsRequest"/></param>
        /// <returns><see cref="DeletePrometheusScrapeJobsResponse"/></returns>
        public DeletePrometheusScrapeJobsResponse DeletePrometheusScrapeJobsSync(DeletePrometheusScrapeJobsRequest req)
        {
            return InternalRequestAsync<DeletePrometheusScrapeJobsResponse>(req, "DeletePrometheusScrapeJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除一个云原生Prometheus配置模板
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusTempRequest"/></param>
        /// <returns><see cref="DeletePrometheusTempResponse"/></returns>
        public Task<DeletePrometheusTempResponse> DeletePrometheusTemp(DeletePrometheusTempRequest req)
        {
            return InternalRequestAsync<DeletePrometheusTempResponse>(req, "DeletePrometheusTemp");
        }

        /// <summary>
        /// 删除一个云原生Prometheus配置模板
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusTempRequest"/></param>
        /// <returns><see cref="DeletePrometheusTempResponse"/></returns>
        public DeletePrometheusTempResponse DeletePrometheusTempSync(DeletePrometheusTempRequest req)
        {
            return InternalRequestAsync<DeletePrometheusTempResponse>(req, "DeletePrometheusTemp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解除模板同步，这将会删除目标中该模板所生产的配置，针对V2版本实例
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusTempSyncRequest"/></param>
        /// <returns><see cref="DeletePrometheusTempSyncResponse"/></returns>
        public Task<DeletePrometheusTempSyncResponse> DeletePrometheusTempSync(DeletePrometheusTempSyncRequest req)
        {
            return InternalRequestAsync<DeletePrometheusTempSyncResponse>(req, "DeletePrometheusTempSync");
        }

        /// <summary>
        /// 解除模板同步，这将会删除目标中该模板所生产的配置，针对V2版本实例
        /// </summary>
        /// <param name="req"><see cref="DeletePrometheusTempSyncRequest"/></param>
        /// <returns><see cref="DeletePrometheusTempSyncResponse"/></returns>
        public DeletePrometheusTempSyncResponse DeletePrometheusTempSyncSync(DeletePrometheusTempSyncRequest req)
        {
            return InternalRequestAsync<DeletePrometheusTempSyncResponse>(req, "DeletePrometheusTempSync")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量删除 Prometheus 预聚合规则
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordingRulesRequest"/></param>
        /// <returns><see cref="DeleteRecordingRulesResponse"/></returns>
        public Task<DeleteRecordingRulesResponse> DeleteRecordingRules(DeleteRecordingRulesRequest req)
        {
            return InternalRequestAsync<DeleteRecordingRulesResponse>(req, "DeleteRecordingRules");
        }

        /// <summary>
        /// 批量删除 Prometheus 预聚合规则
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordingRulesRequest"/></param>
        /// <returns><see cref="DeleteRecordingRulesResponse"/></returns>
        public DeleteRecordingRulesResponse DeleteRecordingRulesSync(DeleteRecordingRulesRequest req)
        {
            return InternalRequestAsync<DeleteRecordingRulesResponse>(req, "DeleteRecordingRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Grafana可视化服务 删除授权用户
        /// </summary>
        /// <param name="req"><see cref="DeleteSSOAccountRequest"/></param>
        /// <returns><see cref="DeleteSSOAccountResponse"/></returns>
        public Task<DeleteSSOAccountResponse> DeleteSSOAccount(DeleteSSOAccountRequest req)
        {
            return InternalRequestAsync<DeleteSSOAccountResponse>(req, "DeleteSSOAccount");
        }

        /// <summary>
        /// Grafana可视化服务 删除授权用户
        /// </summary>
        /// <param name="req"><see cref="DeleteSSOAccountRequest"/></param>
        /// <returns><see cref="DeleteSSOAccountResponse"/></returns>
        public DeleteSSOAccountResponse DeleteSSOAccountSync(DeleteSSOAccountRequest req)
        {
            return InternalRequestAsync<DeleteSSOAccountResponse>(req, "DeleteSSOAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除在腾讯云容器服务下创建的 Prometheus 服务发现。
        /// <p>注意：前提条件，已经通过 Prometheus 控制台集成了对应的腾讯云容器服务，具体请参考
        /// <a href="https://cloud.tencent.com/document/product/248/48859" target="_blank">Agent 安装</a>。</p>
        /// </summary>
        /// <param name="req"><see cref="DeleteServiceDiscoveryRequest"/></param>
        /// <returns><see cref="DeleteServiceDiscoveryResponse"/></returns>
        public Task<DeleteServiceDiscoveryResponse> DeleteServiceDiscovery(DeleteServiceDiscoveryRequest req)
        {
            return InternalRequestAsync<DeleteServiceDiscoveryResponse>(req, "DeleteServiceDiscovery");
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
            return InternalRequestAsync<DeleteServiceDiscoveryResponse>(req, "DeleteServiceDiscovery")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取平台事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAccidentEventListRequest"/></param>
        /// <returns><see cref="DescribeAccidentEventListResponse"/></returns>
        public Task<DescribeAccidentEventListResponse> DescribeAccidentEventList(DescribeAccidentEventListRequest req)
        {
            return InternalRequestAsync<DescribeAccidentEventListResponse>(req, "DescribeAccidentEventList");
        }

        /// <summary>
        /// 获取平台事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAccidentEventListRequest"/></param>
        /// <returns><see cref="DescribeAccidentEventListResponse"/></returns>
        public DescribeAccidentEventListResponse DescribeAccidentEventListSync(DescribeAccidentEventListRequest req)
        {
            return InternalRequestAsync<DescribeAccidentEventListResponse>(req, "DescribeAccidentEventList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询告警事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmEventsRequest"/></param>
        /// <returns><see cref="DescribeAlarmEventsResponse"/></returns>
        public Task<DescribeAlarmEventsResponse> DescribeAlarmEvents(DescribeAlarmEventsRequest req)
        {
            return InternalRequestAsync<DescribeAlarmEventsResponse>(req, "DescribeAlarmEvents");
        }

        /// <summary>
        /// 查询告警事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmEventsRequest"/></param>
        /// <returns><see cref="DescribeAlarmEventsResponse"/></returns>
        public DescribeAlarmEventsResponse DescribeAlarmEventsSync(DescribeAlarmEventsRequest req)
        {
            return InternalRequestAsync<DescribeAlarmEventsResponse>(req, "DescribeAlarmEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询告警历史
        /// 
        /// 请注意，**如果使用子用户进行告警历史的查询，只能查询到被授权项目下的告警历史**，或不区分项目的产品的告警历史。如何对子账户授予项目的权限，请参考 [访问管理-项目与标签](https://cloud.tencent.com/document/product/598/32738)。
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmHistoriesRequest"/></param>
        /// <returns><see cref="DescribeAlarmHistoriesResponse"/></returns>
        public Task<DescribeAlarmHistoriesResponse> DescribeAlarmHistories(DescribeAlarmHistoriesRequest req)
        {
            return InternalRequestAsync<DescribeAlarmHistoriesResponse>(req, "DescribeAlarmHistories");
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
            return InternalRequestAsync<DescribeAlarmHistoriesResponse>(req, "DescribeAlarmHistories")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询告警指标列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmMetricsRequest"/></param>
        /// <returns><see cref="DescribeAlarmMetricsResponse"/></returns>
        public Task<DescribeAlarmMetricsResponse> DescribeAlarmMetrics(DescribeAlarmMetricsRequest req)
        {
            return InternalRequestAsync<DescribeAlarmMetricsResponse>(req, "DescribeAlarmMetrics");
        }

        /// <summary>
        /// 查询告警指标列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmMetricsRequest"/></param>
        /// <returns><see cref="DescribeAlarmMetricsResponse"/></returns>
        public DescribeAlarmMetricsResponse DescribeAlarmMetricsSync(DescribeAlarmMetricsRequest req)
        {
            return InternalRequestAsync<DescribeAlarmMetricsResponse>(req, "DescribeAlarmMetrics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询单个通知模板的详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmNoticeRequest"/></param>
        /// <returns><see cref="DescribeAlarmNoticeResponse"/></returns>
        public Task<DescribeAlarmNoticeResponse> DescribeAlarmNotice(DescribeAlarmNoticeRequest req)
        {
            return InternalRequestAsync<DescribeAlarmNoticeResponse>(req, "DescribeAlarmNotice");
        }

        /// <summary>
        /// 查询单个通知模板的详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmNoticeRequest"/></param>
        /// <returns><see cref="DescribeAlarmNoticeResponse"/></returns>
        public DescribeAlarmNoticeResponse DescribeAlarmNoticeSync(DescribeAlarmNoticeRequest req)
        {
            return InternalRequestAsync<DescribeAlarmNoticeResponse>(req, "DescribeAlarmNotice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取告警通知模板所有回调URL
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmNoticeCallbacksRequest"/></param>
        /// <returns><see cref="DescribeAlarmNoticeCallbacksResponse"/></returns>
        public Task<DescribeAlarmNoticeCallbacksResponse> DescribeAlarmNoticeCallbacks(DescribeAlarmNoticeCallbacksRequest req)
        {
            return InternalRequestAsync<DescribeAlarmNoticeCallbacksResponse>(req, "DescribeAlarmNoticeCallbacks");
        }

        /// <summary>
        /// 获取告警通知模板所有回调URL
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmNoticeCallbacksRequest"/></param>
        /// <returns><see cref="DescribeAlarmNoticeCallbacksResponse"/></returns>
        public DescribeAlarmNoticeCallbacksResponse DescribeAlarmNoticeCallbacksSync(DescribeAlarmNoticeCallbacksRequest req)
        {
            return InternalRequestAsync<DescribeAlarmNoticeCallbacksResponse>(req, "DescribeAlarmNoticeCallbacks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询通知模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmNoticesRequest"/></param>
        /// <returns><see cref="DescribeAlarmNoticesResponse"/></returns>
        public Task<DescribeAlarmNoticesResponse> DescribeAlarmNotices(DescribeAlarmNoticesRequest req)
        {
            return InternalRequestAsync<DescribeAlarmNoticesResponse>(req, "DescribeAlarmNotices");
        }

        /// <summary>
        /// 查询通知模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmNoticesRequest"/></param>
        /// <returns><see cref="DescribeAlarmNoticesResponse"/></returns>
        public DescribeAlarmNoticesResponse DescribeAlarmNoticesSync(DescribeAlarmNoticesRequest req)
        {
            return InternalRequestAsync<DescribeAlarmNoticesResponse>(req, "DescribeAlarmNotices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询告警策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmPoliciesRequest"/></param>
        /// <returns><see cref="DescribeAlarmPoliciesResponse"/></returns>
        public Task<DescribeAlarmPoliciesResponse> DescribeAlarmPolicies(DescribeAlarmPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeAlarmPoliciesResponse>(req, "DescribeAlarmPolicies");
        }

        /// <summary>
        /// 查询告警策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmPoliciesRequest"/></param>
        /// <returns><see cref="DescribeAlarmPoliciesResponse"/></returns>
        public DescribeAlarmPoliciesResponse DescribeAlarmPoliciesSync(DescribeAlarmPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeAlarmPoliciesResponse>(req, "DescribeAlarmPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取单个告警策略详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmPolicyRequest"/></param>
        /// <returns><see cref="DescribeAlarmPolicyResponse"/></returns>
        public Task<DescribeAlarmPolicyResponse> DescribeAlarmPolicy(DescribeAlarmPolicyRequest req)
        {
            return InternalRequestAsync<DescribeAlarmPolicyResponse>(req, "DescribeAlarmPolicy");
        }

        /// <summary>
        /// 获取单个告警策略详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmPolicyRequest"/></param>
        /// <returns><see cref="DescribeAlarmPolicyResponse"/></returns>
        public DescribeAlarmPolicyResponse DescribeAlarmPolicySync(DescribeAlarmPolicyRequest req)
        {
            return InternalRequestAsync<DescribeAlarmPolicyResponse>(req, "DescribeAlarmPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取告警短信配额
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmSmsQuotaRequest"/></param>
        /// <returns><see cref="DescribeAlarmSmsQuotaResponse"/></returns>
        public Task<DescribeAlarmSmsQuotaResponse> DescribeAlarmSmsQuota(DescribeAlarmSmsQuotaRequest req)
        {
            return InternalRequestAsync<DescribeAlarmSmsQuotaResponse>(req, "DescribeAlarmSmsQuota");
        }

        /// <summary>
        /// 获取告警短信配额
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmSmsQuotaRequest"/></param>
        /// <returns><see cref="DescribeAlarmSmsQuotaResponse"/></returns>
        public DescribeAlarmSmsQuotaResponse DescribeAlarmSmsQuotaSync(DescribeAlarmSmsQuotaRequest req)
        {
            return InternalRequestAsync<DescribeAlarmSmsQuotaResponse>(req, "DescribeAlarmSmsQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Prometheus 报警规则查询接口
        /// </summary>
        /// <param name="req"><see cref="DescribeAlertRulesRequest"/></param>
        /// <returns><see cref="DescribeAlertRulesResponse"/></returns>
        public Task<DescribeAlertRulesResponse> DescribeAlertRules(DescribeAlertRulesRequest req)
        {
            return InternalRequestAsync<DescribeAlertRulesResponse>(req, "DescribeAlertRules");
        }

        /// <summary>
        /// Prometheus 报警规则查询接口
        /// </summary>
        /// <param name="req"><see cref="DescribeAlertRulesRequest"/></param>
        /// <returns><see cref="DescribeAlertRulesResponse"/></returns>
        public DescribeAlertRulesResponse DescribeAlertRulesSync(DescribeAlertRulesRequest req)
        {
            return InternalRequestAsync<DescribeAlertRulesResponse>(req, "DescribeAlertRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询所有名字空间
        /// </summary>
        /// <param name="req"><see cref="DescribeAllNamespacesRequest"/></param>
        /// <returns><see cref="DescribeAllNamespacesResponse"/></returns>
        public Task<DescribeAllNamespacesResponse> DescribeAllNamespaces(DescribeAllNamespacesRequest req)
        {
            return InternalRequestAsync<DescribeAllNamespacesResponse>(req, "DescribeAllNamespaces");
        }

        /// <summary>
        /// 查询所有名字空间
        /// </summary>
        /// <param name="req"><see cref="DescribeAllNamespacesRequest"/></param>
        /// <returns><see cref="DescribeAllNamespacesResponse"/></returns>
        public DescribeAllNamespacesResponse DescribeAllNamespacesSync(DescribeAllNamespacesRequest req)
        {
            return InternalRequestAsync<DescribeAllNamespacesResponse>(req, "DescribeAllNamespaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取基础指标属性
        /// </summary>
        /// <param name="req"><see cref="DescribeBaseMetricsRequest"/></param>
        /// <returns><see cref="DescribeBaseMetricsResponse"/></returns>
        public Task<DescribeBaseMetricsResponse> DescribeBaseMetrics(DescribeBaseMetricsRequest req)
        {
            return InternalRequestAsync<DescribeBaseMetricsResponse>(req, "DescribeBaseMetrics");
        }

        /// <summary>
        /// 获取基础指标属性
        /// </summary>
        /// <param name="req"><see cref="DescribeBaseMetricsRequest"/></param>
        /// <returns><see cref="DescribeBaseMetricsResponse"/></returns>
        public DescribeBaseMetricsResponse DescribeBaseMetricsSync(DescribeBaseMetricsRequest req)
        {
            return InternalRequestAsync<DescribeBaseMetricsResponse>(req, "DescribeBaseMetrics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取基础告警列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBasicAlarmListRequest"/></param>
        /// <returns><see cref="DescribeBasicAlarmListResponse"/></returns>
        public Task<DescribeBasicAlarmListResponse> DescribeBasicAlarmList(DescribeBasicAlarmListRequest req)
        {
            return InternalRequestAsync<DescribeBasicAlarmListResponse>(req, "DescribeBasicAlarmList");
        }

        /// <summary>
        /// 获取基础告警列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBasicAlarmListRequest"/></param>
        /// <returns><see cref="DescribeBasicAlarmListResponse"/></returns>
        public DescribeBasicAlarmListResponse DescribeBasicAlarmListSync(DescribeBasicAlarmListRequest req)
        {
            return InternalRequestAsync<DescribeBasicAlarmListResponse>(req, "DescribeBasicAlarmList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取已绑定对象列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBindingPolicyObjectListRequest"/></param>
        /// <returns><see cref="DescribeBindingPolicyObjectListResponse"/></returns>
        public Task<DescribeBindingPolicyObjectListResponse> DescribeBindingPolicyObjectList(DescribeBindingPolicyObjectListRequest req)
        {
            return InternalRequestAsync<DescribeBindingPolicyObjectListResponse>(req, "DescribeBindingPolicyObjectList");
        }

        /// <summary>
        /// 获取已绑定对象列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBindingPolicyObjectListRequest"/></param>
        /// <returns><see cref="DescribeBindingPolicyObjectListResponse"/></returns>
        public DescribeBindingPolicyObjectListResponse DescribeBindingPolicyObjectListSync(DescribeBindingPolicyObjectListRequest req)
        {
            return InternalRequestAsync<DescribeBindingPolicyObjectListResponse>(req, "DescribeBindingPolicyObjectList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取prom实例中集群详细的关联状态
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterAgentCreatingProgressRequest"/></param>
        /// <returns><see cref="DescribeClusterAgentCreatingProgressResponse"/></returns>
        public Task<DescribeClusterAgentCreatingProgressResponse> DescribeClusterAgentCreatingProgress(DescribeClusterAgentCreatingProgressRequest req)
        {
            return InternalRequestAsync<DescribeClusterAgentCreatingProgressResponse>(req, "DescribeClusterAgentCreatingProgress");
        }

        /// <summary>
        /// 获取prom实例中集群详细的关联状态
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterAgentCreatingProgressRequest"/></param>
        /// <returns><see cref="DescribeClusterAgentCreatingProgressResponse"/></returns>
        public DescribeClusterAgentCreatingProgressResponse DescribeClusterAgentCreatingProgressSync(DescribeClusterAgentCreatingProgressRequest req)
        {
            return InternalRequestAsync<DescribeClusterAgentCreatingProgressResponse>(req, "DescribeClusterAgentCreatingProgress")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取条件模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeConditionsTemplateListRequest"/></param>
        /// <returns><see cref="DescribeConditionsTemplateListResponse"/></returns>
        public Task<DescribeConditionsTemplateListResponse> DescribeConditionsTemplateList(DescribeConditionsTemplateListRequest req)
        {
            return InternalRequestAsync<DescribeConditionsTemplateListResponse>(req, "DescribeConditionsTemplateList");
        }

        /// <summary>
        /// 获取条件模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeConditionsTemplateListRequest"/></param>
        /// <returns><see cref="DescribeConditionsTemplateListResponse"/></returns>
        public DescribeConditionsTemplateListResponse DescribeConditionsTemplateListSync(DescribeConditionsTemplateListRequest req)
        {
            return InternalRequestAsync<DescribeConditionsTemplateListResponse>(req, "DescribeConditionsTemplateList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列出 Grafana DNS 配置
        /// </summary>
        /// <param name="req"><see cref="DescribeDNSConfigRequest"/></param>
        /// <returns><see cref="DescribeDNSConfigResponse"/></returns>
        public Task<DescribeDNSConfigResponse> DescribeDNSConfig(DescribeDNSConfigRequest req)
        {
            return InternalRequestAsync<DescribeDNSConfigResponse>(req, "DescribeDNSConfig");
        }

        /// <summary>
        /// 列出 Grafana DNS 配置
        /// </summary>
        /// <param name="req"><see cref="DescribeDNSConfigRequest"/></param>
        /// <returns><see cref="DescribeDNSConfigResponse"/></returns>
        public DescribeDNSConfigResponse DescribeDNSConfigSync(DescribeDNSConfigRequest req)
        {
            return InternalRequestAsync<DescribeDNSConfigResponse>(req, "DescribeDNSConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集成中心 exporter 集成列表
        /// </summary>
        /// <param name="req"><see cref="DescribeExporterIntegrationsRequest"/></param>
        /// <returns><see cref="DescribeExporterIntegrationsResponse"/></returns>
        public Task<DescribeExporterIntegrationsResponse> DescribeExporterIntegrations(DescribeExporterIntegrationsRequest req)
        {
            return InternalRequestAsync<DescribeExporterIntegrationsResponse>(req, "DescribeExporterIntegrations");
        }

        /// <summary>
        /// 查询集成中心 exporter 集成列表
        /// </summary>
        /// <param name="req"><see cref="DescribeExporterIntegrationsRequest"/></param>
        /// <returns><see cref="DescribeExporterIntegrationsResponse"/></returns>
        public DescribeExporterIntegrationsResponse DescribeExporterIntegrationsSync(DescribeExporterIntegrationsRequest req)
        {
            return InternalRequestAsync<DescribeExporterIntegrationsResponse>(req, "DescribeExporterIntegrations")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列出 Grafana 所有告警通道
        /// </summary>
        /// <param name="req"><see cref="DescribeGrafanaChannelsRequest"/></param>
        /// <returns><see cref="DescribeGrafanaChannelsResponse"/></returns>
        public Task<DescribeGrafanaChannelsResponse> DescribeGrafanaChannels(DescribeGrafanaChannelsRequest req)
        {
            return InternalRequestAsync<DescribeGrafanaChannelsResponse>(req, "DescribeGrafanaChannels");
        }

        /// <summary>
        /// 列出 Grafana 所有告警通道
        /// </summary>
        /// <param name="req"><see cref="DescribeGrafanaChannelsRequest"/></param>
        /// <returns><see cref="DescribeGrafanaChannelsResponse"/></returns>
        public DescribeGrafanaChannelsResponse DescribeGrafanaChannelsSync(DescribeGrafanaChannelsRequest req)
        {
            return InternalRequestAsync<DescribeGrafanaChannelsResponse>(req, "DescribeGrafanaChannels")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列出 Grafana 的设置，即 grafana.ini 文件内容
        /// </summary>
        /// <param name="req"><see cref="DescribeGrafanaConfigRequest"/></param>
        /// <returns><see cref="DescribeGrafanaConfigResponse"/></returns>
        public Task<DescribeGrafanaConfigResponse> DescribeGrafanaConfig(DescribeGrafanaConfigRequest req)
        {
            return InternalRequestAsync<DescribeGrafanaConfigResponse>(req, "DescribeGrafanaConfig");
        }

        /// <summary>
        /// 列出 Grafana 的设置，即 grafana.ini 文件内容
        /// </summary>
        /// <param name="req"><see cref="DescribeGrafanaConfigRequest"/></param>
        /// <returns><see cref="DescribeGrafanaConfigResponse"/></returns>
        public DescribeGrafanaConfigResponse DescribeGrafanaConfigSync(DescribeGrafanaConfigRequest req)
        {
            return InternalRequestAsync<DescribeGrafanaConfigResponse>(req, "DescribeGrafanaConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列出 Grafana 环境变量
        /// </summary>
        /// <param name="req"><see cref="DescribeGrafanaEnvironmentsRequest"/></param>
        /// <returns><see cref="DescribeGrafanaEnvironmentsResponse"/></returns>
        public Task<DescribeGrafanaEnvironmentsResponse> DescribeGrafanaEnvironments(DescribeGrafanaEnvironmentsRequest req)
        {
            return InternalRequestAsync<DescribeGrafanaEnvironmentsResponse>(req, "DescribeGrafanaEnvironments");
        }

        /// <summary>
        /// 列出 Grafana 环境变量
        /// </summary>
        /// <param name="req"><see cref="DescribeGrafanaEnvironmentsRequest"/></param>
        /// <returns><see cref="DescribeGrafanaEnvironmentsResponse"/></returns>
        public DescribeGrafanaEnvironmentsResponse DescribeGrafanaEnvironmentsSync(DescribeGrafanaEnvironmentsRequest req)
        {
            return InternalRequestAsync<DescribeGrafanaEnvironmentsResponse>(req, "DescribeGrafanaEnvironments")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列出用户所有的 Grafana 服务
        /// </summary>
        /// <param name="req"><see cref="DescribeGrafanaInstancesRequest"/></param>
        /// <returns><see cref="DescribeGrafanaInstancesResponse"/></returns>
        public Task<DescribeGrafanaInstancesResponse> DescribeGrafanaInstances(DescribeGrafanaInstancesRequest req)
        {
            return InternalRequestAsync<DescribeGrafanaInstancesResponse>(req, "DescribeGrafanaInstances");
        }

        /// <summary>
        /// 列出用户所有的 Grafana 服务
        /// </summary>
        /// <param name="req"><see cref="DescribeGrafanaInstancesRequest"/></param>
        /// <returns><see cref="DescribeGrafanaInstancesResponse"/></returns>
        public DescribeGrafanaInstancesResponse DescribeGrafanaInstancesSync(DescribeGrafanaInstancesRequest req)
        {
            return InternalRequestAsync<DescribeGrafanaInstancesResponse>(req, "DescribeGrafanaInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列出 Grafana 已安装的集成
        /// </summary>
        /// <param name="req"><see cref="DescribeGrafanaIntegrationsRequest"/></param>
        /// <returns><see cref="DescribeGrafanaIntegrationsResponse"/></returns>
        public Task<DescribeGrafanaIntegrationsResponse> DescribeGrafanaIntegrations(DescribeGrafanaIntegrationsRequest req)
        {
            return InternalRequestAsync<DescribeGrafanaIntegrationsResponse>(req, "DescribeGrafanaIntegrations");
        }

        /// <summary>
        /// 列出 Grafana 已安装的集成
        /// </summary>
        /// <param name="req"><see cref="DescribeGrafanaIntegrationsRequest"/></param>
        /// <returns><see cref="DescribeGrafanaIntegrationsResponse"/></returns>
        public DescribeGrafanaIntegrationsResponse DescribeGrafanaIntegrationsSync(DescribeGrafanaIntegrationsRequest req)
        {
            return InternalRequestAsync<DescribeGrafanaIntegrationsResponse>(req, "DescribeGrafanaIntegrations")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列出 Grafana 告警通道
        /// </summary>
        /// <param name="req"><see cref="DescribeGrafanaNotificationChannelsRequest"/></param>
        /// <returns><see cref="DescribeGrafanaNotificationChannelsResponse"/></returns>
        public Task<DescribeGrafanaNotificationChannelsResponse> DescribeGrafanaNotificationChannels(DescribeGrafanaNotificationChannelsRequest req)
        {
            return InternalRequestAsync<DescribeGrafanaNotificationChannelsResponse>(req, "DescribeGrafanaNotificationChannels");
        }

        /// <summary>
        /// 列出 Grafana 告警通道
        /// </summary>
        /// <param name="req"><see cref="DescribeGrafanaNotificationChannelsRequest"/></param>
        /// <returns><see cref="DescribeGrafanaNotificationChannelsResponse"/></returns>
        public DescribeGrafanaNotificationChannelsResponse DescribeGrafanaNotificationChannelsSync(DescribeGrafanaNotificationChannelsRequest req)
        {
            return InternalRequestAsync<DescribeGrafanaNotificationChannelsResponse>(req, "DescribeGrafanaNotificationChannels")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列出 Grafana 白名单
        /// </summary>
        /// <param name="req"><see cref="DescribeGrafanaWhiteListRequest"/></param>
        /// <returns><see cref="DescribeGrafanaWhiteListResponse"/></returns>
        public Task<DescribeGrafanaWhiteListResponse> DescribeGrafanaWhiteList(DescribeGrafanaWhiteListRequest req)
        {
            return InternalRequestAsync<DescribeGrafanaWhiteListResponse>(req, "DescribeGrafanaWhiteList");
        }

        /// <summary>
        /// 列出 Grafana 白名单
        /// </summary>
        /// <param name="req"><see cref="DescribeGrafanaWhiteListRequest"/></param>
        /// <returns><see cref="DescribeGrafanaWhiteListResponse"/></returns>
        public DescribeGrafanaWhiteListResponse DescribeGrafanaWhiteListSync(DescribeGrafanaWhiteListRequest req)
        {
            return InternalRequestAsync<DescribeGrafanaWhiteListResponse>(req, "DescribeGrafanaWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列出实例已安装的插件
        /// </summary>
        /// <param name="req"><see cref="DescribeInstalledPluginsRequest"/></param>
        /// <returns><see cref="DescribeInstalledPluginsResponse"/></returns>
        public Task<DescribeInstalledPluginsResponse> DescribeInstalledPlugins(DescribeInstalledPluginsRequest req)
        {
            return InternalRequestAsync<DescribeInstalledPluginsResponse>(req, "DescribeInstalledPlugins");
        }

        /// <summary>
        /// 列出实例已安装的插件
        /// </summary>
        /// <param name="req"><see cref="DescribeInstalledPluginsRequest"/></param>
        /// <returns><see cref="DescribeInstalledPluginsResponse"/></returns>
        public DescribeInstalledPluginsResponse DescribeInstalledPluginsSync(DescribeInstalledPluginsRequest req)
        {
            return InternalRequestAsync<DescribeInstalledPluginsResponse>(req, "DescribeInstalledPlugins")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取资源消耗页概览
        /// </summary>
        /// <param name="req"><see cref="DescribeMonitorResourceInfoRequest"/></param>
        /// <returns><see cref="DescribeMonitorResourceInfoResponse"/></returns>
        public Task<DescribeMonitorResourceInfoResponse> DescribeMonitorResourceInfo(DescribeMonitorResourceInfoRequest req)
        {
            return InternalRequestAsync<DescribeMonitorResourceInfoResponse>(req, "DescribeMonitorResourceInfo");
        }

        /// <summary>
        /// 获取资源消耗页概览
        /// </summary>
        /// <param name="req"><see cref="DescribeMonitorResourceInfoRequest"/></param>
        /// <returns><see cref="DescribeMonitorResourceInfoResponse"/></returns>
        public DescribeMonitorResourceInfoResponse DescribeMonitorResourceInfoSync(DescribeMonitorResourceInfoRequest req)
        {
            return InternalRequestAsync<DescribeMonitorResourceInfoResponse>(req, "DescribeMonitorResourceInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 腾讯云可观测平台支持多种类型的监控，此接口列出支持的所有类型
        /// </summary>
        /// <param name="req"><see cref="DescribeMonitorTypesRequest"/></param>
        /// <returns><see cref="DescribeMonitorTypesResponse"/></returns>
        public Task<DescribeMonitorTypesResponse> DescribeMonitorTypes(DescribeMonitorTypesRequest req)
        {
            return InternalRequestAsync<DescribeMonitorTypesResponse>(req, "DescribeMonitorTypes");
        }

        /// <summary>
        /// 腾讯云可观测平台支持多种类型的监控，此接口列出支持的所有类型
        /// </summary>
        /// <param name="req"><see cref="DescribeMonitorTypesRequest"/></param>
        /// <returns><see cref="DescribeMonitorTypesResponse"/></returns>
        public DescribeMonitorTypesResponse DescribeMonitorTypesSync(DescribeMonitorTypesRequest req)
        {
            return InternalRequestAsync<DescribeMonitorTypesResponse>(req, "DescribeMonitorTypes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询周期内电话流水总数
        /// </summary>
        /// <param name="req"><see cref="DescribePhoneAlarmFlowTotalCountRequest"/></param>
        /// <returns><see cref="DescribePhoneAlarmFlowTotalCountResponse"/></returns>
        public Task<DescribePhoneAlarmFlowTotalCountResponse> DescribePhoneAlarmFlowTotalCount(DescribePhoneAlarmFlowTotalCountRequest req)
        {
            return InternalRequestAsync<DescribePhoneAlarmFlowTotalCountResponse>(req, "DescribePhoneAlarmFlowTotalCount");
        }

        /// <summary>
        /// 查询周期内电话流水总数
        /// </summary>
        /// <param name="req"><see cref="DescribePhoneAlarmFlowTotalCountRequest"/></param>
        /// <returns><see cref="DescribePhoneAlarmFlowTotalCountResponse"/></returns>
        public DescribePhoneAlarmFlowTotalCountResponse DescribePhoneAlarmFlowTotalCountSync(DescribePhoneAlarmFlowTotalCountRequest req)
        {
            return InternalRequestAsync<DescribePhoneAlarmFlowTotalCountResponse>(req, "DescribePhoneAlarmFlowTotalCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列出可安装的所有 Grafana 插件。
        /// </summary>
        /// <param name="req"><see cref="DescribePluginOverviewsRequest"/></param>
        /// <returns><see cref="DescribePluginOverviewsResponse"/></returns>
        public Task<DescribePluginOverviewsResponse> DescribePluginOverviews(DescribePluginOverviewsRequest req)
        {
            return InternalRequestAsync<DescribePluginOverviewsResponse>(req, "DescribePluginOverviews");
        }

        /// <summary>
        /// 列出可安装的所有 Grafana 插件。
        /// </summary>
        /// <param name="req"><see cref="DescribePluginOverviewsRequest"/></param>
        /// <returns><see cref="DescribePluginOverviewsResponse"/></returns>
        public DescribePluginOverviewsResponse DescribePluginOverviewsSync(DescribePluginOverviewsRequest req)
        {
            return InternalRequestAsync<DescribePluginOverviewsResponse>(req, "DescribePluginOverviews")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取基础告警策略条件
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyConditionListRequest"/></param>
        /// <returns><see cref="DescribePolicyConditionListResponse"/></returns>
        public Task<DescribePolicyConditionListResponse> DescribePolicyConditionList(DescribePolicyConditionListRequest req)
        {
            return InternalRequestAsync<DescribePolicyConditionListResponse>(req, "DescribePolicyConditionList");
        }

        /// <summary>
        /// 获取基础告警策略条件
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyConditionListRequest"/></param>
        /// <returns><see cref="DescribePolicyConditionListResponse"/></returns>
        public DescribePolicyConditionListResponse DescribePolicyConditionListSync(DescribePolicyConditionListRequest req)
        {
            return InternalRequestAsync<DescribePolicyConditionListResponse>(req, "DescribePolicyConditionList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取基础策略组详情
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyGroupInfoRequest"/></param>
        /// <returns><see cref="DescribePolicyGroupInfoResponse"/></returns>
        public Task<DescribePolicyGroupInfoResponse> DescribePolicyGroupInfo(DescribePolicyGroupInfoRequest req)
        {
            return InternalRequestAsync<DescribePolicyGroupInfoResponse>(req, "DescribePolicyGroupInfo");
        }

        /// <summary>
        /// 获取基础策略组详情
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyGroupInfoRequest"/></param>
        /// <returns><see cref="DescribePolicyGroupInfoResponse"/></returns>
        public DescribePolicyGroupInfoResponse DescribePolicyGroupInfoSync(DescribePolicyGroupInfoRequest req)
        {
            return InternalRequestAsync<DescribePolicyGroupInfoResponse>(req, "DescribePolicyGroupInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取基础策略告警组列表
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyGroupListRequest"/></param>
        /// <returns><see cref="DescribePolicyGroupListResponse"/></returns>
        public Task<DescribePolicyGroupListResponse> DescribePolicyGroupList(DescribePolicyGroupListRequest req)
        {
            return InternalRequestAsync<DescribePolicyGroupListResponse>(req, "DescribePolicyGroupList");
        }

        /// <summary>
        /// 获取基础策略告警组列表
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyGroupListRequest"/></param>
        /// <returns><see cref="DescribePolicyGroupListResponse"/></returns>
        public DescribePolicyGroupListResponse DescribePolicyGroupListSync(DescribePolicyGroupListRequest req)
        {
            return InternalRequestAsync<DescribePolicyGroupListResponse>(req, "DescribePolicyGroupList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 分页获取产品事件的列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProductEventListRequest"/></param>
        /// <returns><see cref="DescribeProductEventListResponse"/></returns>
        public Task<DescribeProductEventListResponse> DescribeProductEventList(DescribeProductEventListRequest req)
        {
            return InternalRequestAsync<DescribeProductEventListResponse>(req, "DescribeProductEventList");
        }

        /// <summary>
        /// 分页获取产品事件的列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProductEventListRequest"/></param>
        /// <returns><see cref="DescribeProductEventListResponse"/></returns>
        public DescribeProductEventListResponse DescribeProductEventListSync(DescribeProductEventListRequest req)
        {
            return InternalRequestAsync<DescribeProductEventListResponse>(req, "DescribeProductEventList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询腾讯云可观测平台云产品列表，支持云服务器CVM、云数据库、云消息队列、负载均衡、容器服务、专线等云产品。
        /// </summary>
        /// <param name="req"><see cref="DescribeProductListRequest"/></param>
        /// <returns><see cref="DescribeProductListResponse"/></returns>
        public Task<DescribeProductListResponse> DescribeProductList(DescribeProductListRequest req)
        {
            return InternalRequestAsync<DescribeProductListResponse>(req, "DescribeProductList");
        }

        /// <summary>
        /// 查询腾讯云可观测平台云产品列表，支持云服务器CVM、云数据库、云消息队列、负载均衡、容器服务、专线等云产品。
        /// </summary>
        /// <param name="req"><see cref="DescribeProductListRequest"/></param>
        /// <returns><see cref="DescribeProductListResponse"/></returns>
        public DescribeProductListResponse DescribeProductListSync(DescribeProductListRequest req)
        {
            return InternalRequestAsync<DescribeProductListResponse>(req, "DescribeProductList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取关联目标集群的实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusAgentInstancesRequest"/></param>
        /// <returns><see cref="DescribePrometheusAgentInstancesResponse"/></returns>
        public Task<DescribePrometheusAgentInstancesResponse> DescribePrometheusAgentInstances(DescribePrometheusAgentInstancesRequest req)
        {
            return InternalRequestAsync<DescribePrometheusAgentInstancesResponse>(req, "DescribePrometheusAgentInstances");
        }

        /// <summary>
        /// 获取关联目标集群的实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusAgentInstancesRequest"/></param>
        /// <returns><see cref="DescribePrometheusAgentInstancesResponse"/></returns>
        public DescribePrometheusAgentInstancesResponse DescribePrometheusAgentInstancesSync(DescribePrometheusAgentInstancesRequest req)
        {
            return InternalRequestAsync<DescribePrometheusAgentInstancesResponse>(req, "DescribePrometheusAgentInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列出 Prometheus CVM Agent
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusAgentsRequest"/></param>
        /// <returns><see cref="DescribePrometheusAgentsResponse"/></returns>
        public Task<DescribePrometheusAgentsResponse> DescribePrometheusAgents(DescribePrometheusAgentsRequest req)
        {
            return InternalRequestAsync<DescribePrometheusAgentsResponse>(req, "DescribePrometheusAgents");
        }

        /// <summary>
        /// 列出 Prometheus CVM Agent
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusAgentsRequest"/></param>
        /// <returns><see cref="DescribePrometheusAgentsResponse"/></returns>
        public DescribePrometheusAgentsResponse DescribePrometheusAgentsSync(DescribePrometheusAgentsRequest req)
        {
            return InternalRequestAsync<DescribePrometheusAgentsResponse>(req, "DescribePrometheusAgents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询给定prometheus下的告警分组
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusAlertGroupsRequest"/></param>
        /// <returns><see cref="DescribePrometheusAlertGroupsResponse"/></returns>
        public Task<DescribePrometheusAlertGroupsResponse> DescribePrometheusAlertGroups(DescribePrometheusAlertGroupsRequest req)
        {
            return InternalRequestAsync<DescribePrometheusAlertGroupsResponse>(req, "DescribePrometheusAlertGroups");
        }

        /// <summary>
        /// 查询给定prometheus下的告警分组
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusAlertGroupsRequest"/></param>
        /// <returns><see cref="DescribePrometheusAlertGroupsResponse"/></returns>
        public DescribePrometheusAlertGroupsResponse DescribePrometheusAlertGroupsSync(DescribePrometheusAlertGroupsRequest req)
        {
            return InternalRequestAsync<DescribePrometheusAlertGroupsResponse>(req, "DescribePrometheusAlertGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取2.0实例告警策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusAlertPolicyRequest"/></param>
        /// <returns><see cref="DescribePrometheusAlertPolicyResponse"/></returns>
        public Task<DescribePrometheusAlertPolicyResponse> DescribePrometheusAlertPolicy(DescribePrometheusAlertPolicyRequest req)
        {
            return InternalRequestAsync<DescribePrometheusAlertPolicyResponse>(req, "DescribePrometheusAlertPolicy");
        }

        /// <summary>
        /// 获取2.0实例告警策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusAlertPolicyRequest"/></param>
        /// <returns><see cref="DescribePrometheusAlertPolicyResponse"/></returns>
        public DescribePrometheusAlertPolicyResponse DescribePrometheusAlertPolicySync(DescribePrometheusAlertPolicyRequest req)
        {
            return InternalRequestAsync<DescribePrometheusAlertPolicyResponse>(req, "DescribePrometheusAlertPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取TMP实例关联集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusClusterAgentsRequest"/></param>
        /// <returns><see cref="DescribePrometheusClusterAgentsResponse"/></returns>
        public Task<DescribePrometheusClusterAgentsResponse> DescribePrometheusClusterAgents(DescribePrometheusClusterAgentsRequest req)
        {
            return InternalRequestAsync<DescribePrometheusClusterAgentsResponse>(req, "DescribePrometheusClusterAgents");
        }

        /// <summary>
        /// 获取TMP实例关联集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusClusterAgentsRequest"/></param>
        /// <returns><see cref="DescribePrometheusClusterAgentsResponse"/></returns>
        public DescribePrometheusClusterAgentsResponse DescribePrometheusClusterAgentsSync(DescribePrometheusClusterAgentsRequest req)
        {
            return InternalRequestAsync<DescribePrometheusClusterAgentsResponse>(req, "DescribePrometheusClusterAgents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取Prometheus配置
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusConfigRequest"/></param>
        /// <returns><see cref="DescribePrometheusConfigResponse"/></returns>
        public Task<DescribePrometheusConfigResponse> DescribePrometheusConfig(DescribePrometheusConfigRequest req)
        {
            return InternalRequestAsync<DescribePrometheusConfigResponse>(req, "DescribePrometheusConfig");
        }

        /// <summary>
        /// 拉取Prometheus配置
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusConfigRequest"/></param>
        /// <returns><see cref="DescribePrometheusConfigResponse"/></returns>
        public DescribePrometheusConfigResponse DescribePrometheusConfigSync(DescribePrometheusConfigRequest req)
        {
            return InternalRequestAsync<DescribePrometheusConfigResponse>(req, "DescribePrometheusConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获得实例级别抓取配置
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusGlobalConfigRequest"/></param>
        /// <returns><see cref="DescribePrometheusGlobalConfigResponse"/></returns>
        public Task<DescribePrometheusGlobalConfigResponse> DescribePrometheusGlobalConfig(DescribePrometheusGlobalConfigRequest req)
        {
            return InternalRequestAsync<DescribePrometheusGlobalConfigResponse>(req, "DescribePrometheusGlobalConfig");
        }

        /// <summary>
        /// 获得实例级别抓取配置
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusGlobalConfigRequest"/></param>
        /// <returns><see cref="DescribePrometheusGlobalConfigResponse"/></returns>
        public DescribePrometheusGlobalConfigResponse DescribePrometheusGlobalConfigSync(DescribePrometheusGlobalConfigRequest req)
        {
            return InternalRequestAsync<DescribePrometheusGlobalConfigResponse>(req, "DescribePrometheusGlobalConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询全局告警通知渠道
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusGlobalNotificationRequest"/></param>
        /// <returns><see cref="DescribePrometheusGlobalNotificationResponse"/></returns>
        public Task<DescribePrometheusGlobalNotificationResponse> DescribePrometheusGlobalNotification(DescribePrometheusGlobalNotificationRequest req)
        {
            return InternalRequestAsync<DescribePrometheusGlobalNotificationResponse>(req, "DescribePrometheusGlobalNotification");
        }

        /// <summary>
        /// 查询全局告警通知渠道
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusGlobalNotificationRequest"/></param>
        /// <returns><see cref="DescribePrometheusGlobalNotificationResponse"/></returns>
        public DescribePrometheusGlobalNotificationResponse DescribePrometheusGlobalNotificationSync(DescribePrometheusGlobalNotificationRequest req)
        {
            return InternalRequestAsync<DescribePrometheusGlobalNotificationResponse>(req, "DescribePrometheusGlobalNotification")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取TMP实例详情
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribePrometheusInstanceDetailResponse"/></returns>
        public Task<DescribePrometheusInstanceDetailResponse> DescribePrometheusInstanceDetail(DescribePrometheusInstanceDetailRequest req)
        {
            return InternalRequestAsync<DescribePrometheusInstanceDetailResponse>(req, "DescribePrometheusInstanceDetail");
        }

        /// <summary>
        /// 获取TMP实例详情
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusInstanceDetailRequest"/></param>
        /// <returns><see cref="DescribePrometheusInstanceDetailResponse"/></returns>
        public DescribePrometheusInstanceDetailResponse DescribePrometheusInstanceDetailSync(DescribePrometheusInstanceDetailRequest req)
        {
            return InternalRequestAsync<DescribePrometheusInstanceDetailResponse>(req, "DescribePrometheusInstanceDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取2.0实例初始化任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusInstanceInitStatusRequest"/></param>
        /// <returns><see cref="DescribePrometheusInstanceInitStatusResponse"/></returns>
        public Task<DescribePrometheusInstanceInitStatusResponse> DescribePrometheusInstanceInitStatus(DescribePrometheusInstanceInitStatusRequest req)
        {
            return InternalRequestAsync<DescribePrometheusInstanceInitStatusResponse>(req, "DescribePrometheusInstanceInitStatus");
        }

        /// <summary>
        /// 获取2.0实例初始化任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusInstanceInitStatusRequest"/></param>
        /// <returns><see cref="DescribePrometheusInstanceInitStatusResponse"/></returns>
        public DescribePrometheusInstanceInitStatusResponse DescribePrometheusInstanceInitStatusSync(DescribePrometheusInstanceInitStatusRequest req)
        {
            return InternalRequestAsync<DescribePrometheusInstanceInitStatusResponse>(req, "DescribePrometheusInstanceInitStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Prometheus按量实例用量
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusInstanceUsageRequest"/></param>
        /// <returns><see cref="DescribePrometheusInstanceUsageResponse"/></returns>
        public Task<DescribePrometheusInstanceUsageResponse> DescribePrometheusInstanceUsage(DescribePrometheusInstanceUsageRequest req)
        {
            return InternalRequestAsync<DescribePrometheusInstanceUsageResponse>(req, "DescribePrometheusInstanceUsage");
        }

        /// <summary>
        /// 查询Prometheus按量实例用量
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusInstanceUsageRequest"/></param>
        /// <returns><see cref="DescribePrometheusInstanceUsageResponse"/></returns>
        public DescribePrometheusInstanceUsageResponse DescribePrometheusInstanceUsageSync(DescribePrometheusInstanceUsageRequest req)
        {
            return InternalRequestAsync<DescribePrometheusInstanceUsageResponse>(req, "DescribePrometheusInstanceUsage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribePrometheusInstances) 用于查询一个或多个实例的详细信息。
        /// <ul>
        /// <li>可以根据实例ID、实例名称或者实例状态等信息来查询实例的详细信息</li>
        /// <li>如果参数为空，返回当前用户一定数量（Limit所指定的数量，默认为20）的实例。</li>
        /// </ul>
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusInstancesRequest"/></param>
        /// <returns><see cref="DescribePrometheusInstancesResponse"/></returns>
        public Task<DescribePrometheusInstancesResponse> DescribePrometheusInstances(DescribePrometheusInstancesRequest req)
        {
            return InternalRequestAsync<DescribePrometheusInstancesResponse>(req, "DescribePrometheusInstances");
        }

        /// <summary>
        /// 本接口 (DescribePrometheusInstances) 用于查询一个或多个实例的详细信息。
        /// <ul>
        /// <li>可以根据实例ID、实例名称或者实例状态等信息来查询实例的详细信息</li>
        /// <li>如果参数为空，返回当前用户一定数量（Limit所指定的数量，默认为20）的实例。</li>
        /// </ul>
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusInstancesRequest"/></param>
        /// <returns><see cref="DescribePrometheusInstancesResponse"/></returns>
        public DescribePrometheusInstancesResponse DescribePrometheusInstancesSync(DescribePrometheusInstancesRequest req)
        {
            return InternalRequestAsync<DescribePrometheusInstancesResponse>(req, "DescribePrometheusInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取与 Prometheus 监控融合实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusInstancesOverviewRequest"/></param>
        /// <returns><see cref="DescribePrometheusInstancesOverviewResponse"/></returns>
        public Task<DescribePrometheusInstancesOverviewResponse> DescribePrometheusInstancesOverview(DescribePrometheusInstancesOverviewRequest req)
        {
            return InternalRequestAsync<DescribePrometheusInstancesOverviewResponse>(req, "DescribePrometheusInstancesOverview");
        }

        /// <summary>
        /// 获取与 Prometheus 监控融合实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusInstancesOverviewRequest"/></param>
        /// <returns><see cref="DescribePrometheusInstancesOverviewResponse"/></returns>
        public DescribePrometheusInstancesOverviewResponse DescribePrometheusInstancesOverviewSync(DescribePrometheusInstancesOverviewRequest req)
        {
            return InternalRequestAsync<DescribePrometheusInstancesOverviewResponse>(req, "DescribePrometheusInstancesOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribePrometheusRecordRules 接口可完全代替该接口。近30天仅有3次调用，且都是报错请求
        /// 
        /// 拉取Prometheus聚合规则yaml列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusRecordRuleYamlRequest"/></param>
        /// <returns><see cref="DescribePrometheusRecordRuleYamlResponse"/></returns>
        public Task<DescribePrometheusRecordRuleYamlResponse> DescribePrometheusRecordRuleYaml(DescribePrometheusRecordRuleYamlRequest req)
        {
            return InternalRequestAsync<DescribePrometheusRecordRuleYamlResponse>(req, "DescribePrometheusRecordRuleYaml");
        }

        /// <summary>
        /// DescribePrometheusRecordRules 接口可完全代替该接口。近30天仅有3次调用，且都是报错请求
        /// 
        /// 拉取Prometheus聚合规则yaml列表
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusRecordRuleYamlRequest"/></param>
        /// <returns><see cref="DescribePrometheusRecordRuleYamlResponse"/></returns>
        public DescribePrometheusRecordRuleYamlResponse DescribePrometheusRecordRuleYamlSync(DescribePrometheusRecordRuleYamlRequest req)
        {
            return InternalRequestAsync<DescribePrometheusRecordRuleYamlResponse>(req, "DescribePrometheusRecordRuleYaml")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取聚合规则列表，包含关联集群内crd资源创建的record rule
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusRecordRulesRequest"/></param>
        /// <returns><see cref="DescribePrometheusRecordRulesResponse"/></returns>
        public Task<DescribePrometheusRecordRulesResponse> DescribePrometheusRecordRules(DescribePrometheusRecordRulesRequest req)
        {
            return InternalRequestAsync<DescribePrometheusRecordRulesResponse>(req, "DescribePrometheusRecordRules");
        }

        /// <summary>
        /// 获取聚合规则列表，包含关联集群内crd资源创建的record rule
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusRecordRulesRequest"/></param>
        /// <returns><see cref="DescribePrometheusRecordRulesResponse"/></returns>
        public DescribePrometheusRecordRulesResponse DescribePrometheusRecordRulesSync(DescribePrometheusRecordRulesRequest req)
        {
            return InternalRequestAsync<DescribePrometheusRecordRulesResponse>(req, "DescribePrometheusRecordRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列出 Prometheus 服务所有可用的地域
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusRegionsRequest"/></param>
        /// <returns><see cref="DescribePrometheusRegionsResponse"/></returns>
        public Task<DescribePrometheusRegionsResponse> DescribePrometheusRegions(DescribePrometheusRegionsRequest req)
        {
            return InternalRequestAsync<DescribePrometheusRegionsResponse>(req, "DescribePrometheusRegions");
        }

        /// <summary>
        /// 列出 Prometheus 服务所有可用的地域
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusRegionsRequest"/></param>
        /// <returns><see cref="DescribePrometheusRegionsResponse"/></returns>
        public DescribePrometheusRegionsResponse DescribePrometheusRegionsSync(DescribePrometheusRegionsRequest req)
        {
            return InternalRequestAsync<DescribePrometheusRegionsResponse>(req, "DescribePrometheusRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列出 Prometheus 抓取任务
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusScrapeJobsRequest"/></param>
        /// <returns><see cref="DescribePrometheusScrapeJobsResponse"/></returns>
        public Task<DescribePrometheusScrapeJobsResponse> DescribePrometheusScrapeJobs(DescribePrometheusScrapeJobsRequest req)
        {
            return InternalRequestAsync<DescribePrometheusScrapeJobsResponse>(req, "DescribePrometheusScrapeJobs");
        }

        /// <summary>
        /// 列出 Prometheus 抓取任务
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusScrapeJobsRequest"/></param>
        /// <returns><see cref="DescribePrometheusScrapeJobsResponse"/></returns>
        public DescribePrometheusScrapeJobsResponse DescribePrometheusScrapeJobsSync(DescribePrometheusScrapeJobsRequest req)
        {
            return InternalRequestAsync<DescribePrometheusScrapeJobsResponse>(req, "DescribePrometheusScrapeJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取targets信息，在过滤条件中指定job名称时返回targets详情，否则仅返回数量
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusTargetsTMPRequest"/></param>
        /// <returns><see cref="DescribePrometheusTargetsTMPResponse"/></returns>
        public Task<DescribePrometheusTargetsTMPResponse> DescribePrometheusTargetsTMP(DescribePrometheusTargetsTMPRequest req)
        {
            return InternalRequestAsync<DescribePrometheusTargetsTMPResponse>(req, "DescribePrometheusTargetsTMP");
        }

        /// <summary>
        /// 获取targets信息，在过滤条件中指定job名称时返回targets详情，否则仅返回数量
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusTargetsTMPRequest"/></param>
        /// <returns><see cref="DescribePrometheusTargetsTMPResponse"/></returns>
        public DescribePrometheusTargetsTMPResponse DescribePrometheusTargetsTMPSync(DescribePrometheusTargetsTMPRequest req)
        {
            return InternalRequestAsync<DescribePrometheusTargetsTMPResponse>(req, "DescribePrometheusTargetsTMP")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取模板列表，默认模板将总是在最前面
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusTempRequest"/></param>
        /// <returns><see cref="DescribePrometheusTempResponse"/></returns>
        public Task<DescribePrometheusTempResponse> DescribePrometheusTemp(DescribePrometheusTempRequest req)
        {
            return InternalRequestAsync<DescribePrometheusTempResponse>(req, "DescribePrometheusTemp");
        }

        /// <summary>
        /// 拉取模板列表，默认模板将总是在最前面
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusTempRequest"/></param>
        /// <returns><see cref="DescribePrometheusTempResponse"/></returns>
        public DescribePrometheusTempResponse DescribePrometheusTempSync(DescribePrometheusTempRequest req)
        {
            return InternalRequestAsync<DescribePrometheusTempResponse>(req, "DescribePrometheusTemp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取模板关联实例信息，针对V2版本实例
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusTempSyncRequest"/></param>
        /// <returns><see cref="DescribePrometheusTempSyncResponse"/></returns>
        public Task<DescribePrometheusTempSyncResponse> DescribePrometheusTempSync(DescribePrometheusTempSyncRequest req)
        {
            return InternalRequestAsync<DescribePrometheusTempSyncResponse>(req, "DescribePrometheusTempSync");
        }

        /// <summary>
        /// 获取模板关联实例信息，针对V2版本实例
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusTempSyncRequest"/></param>
        /// <returns><see cref="DescribePrometheusTempSyncResponse"/></returns>
        public DescribePrometheusTempSyncResponse DescribePrometheusTempSyncSync(DescribePrometheusTempSyncRequest req)
        {
            return InternalRequestAsync<DescribePrometheusTempSyncResponse>(req, "DescribePrometheusTempSync")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列出 Prometheus 服务可用区。
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusZonesRequest"/></param>
        /// <returns><see cref="DescribePrometheusZonesResponse"/></returns>
        public Task<DescribePrometheusZonesResponse> DescribePrometheusZones(DescribePrometheusZonesRequest req)
        {
            return InternalRequestAsync<DescribePrometheusZonesResponse>(req, "DescribePrometheusZones");
        }

        /// <summary>
        /// 列出 Prometheus 服务可用区。
        /// </summary>
        /// <param name="req"><see cref="DescribePrometheusZonesRequest"/></param>
        /// <returns><see cref="DescribePrometheusZonesResponse"/></returns>
        public DescribePrometheusZonesResponse DescribePrometheusZonesSync(DescribePrometheusZonesRequest req)
        {
            return InternalRequestAsync<DescribePrometheusZonesResponse>(req, "DescribePrometheusZones")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据条件查询 Prometheus 预聚合规则
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordingRulesRequest"/></param>
        /// <returns><see cref="DescribeRecordingRulesResponse"/></returns>
        public Task<DescribeRecordingRulesResponse> DescribeRecordingRules(DescribeRecordingRulesRequest req)
        {
            return InternalRequestAsync<DescribeRecordingRulesResponse>(req, "DescribeRecordingRules");
        }

        /// <summary>
        /// 根据条件查询 Prometheus 预聚合规则
        /// </summary>
        /// <param name="req"><see cref="DescribeRecordingRulesRequest"/></param>
        /// <returns><see cref="DescribeRecordingRulesResponse"/></returns>
        public DescribeRecordingRulesResponse DescribeRecordingRulesSync(DescribeRecordingRulesRequest req)
        {
            return InternalRequestAsync<DescribeRecordingRulesResponse>(req, "DescribeRecordingRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列出当前grafana实例的所有授权账号
        /// </summary>
        /// <param name="req"><see cref="DescribeSSOAccountRequest"/></param>
        /// <returns><see cref="DescribeSSOAccountResponse"/></returns>
        public Task<DescribeSSOAccountResponse> DescribeSSOAccount(DescribeSSOAccountRequest req)
        {
            return InternalRequestAsync<DescribeSSOAccountResponse>(req, "DescribeSSOAccount");
        }

        /// <summary>
        /// 列出当前grafana实例的所有授权账号
        /// </summary>
        /// <param name="req"><see cref="DescribeSSOAccountRequest"/></param>
        /// <returns><see cref="DescribeSSOAccountResponse"/></returns>
        public DescribeSSOAccountResponse DescribeSSOAccountSync(DescribeSSOAccountRequest req)
        {
            return InternalRequestAsync<DescribeSSOAccountResponse>(req, "DescribeSSOAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列出在腾讯云容器服务下创建的 Prometheus 服务发现。
        /// <p>注意：前提条件，已经通过 Prometheus 控制台集成了对应的腾讯云容器服务，具体请参考
        /// <a href="https://cloud.tencent.com/document/product/248/48859" target="_blank">Agent 安装</a>。</p>
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceDiscoveryRequest"/></param>
        /// <returns><see cref="DescribeServiceDiscoveryResponse"/></returns>
        public Task<DescribeServiceDiscoveryResponse> DescribeServiceDiscovery(DescribeServiceDiscoveryRequest req)
        {
            return InternalRequestAsync<DescribeServiceDiscoveryResponse>(req, "DescribeServiceDiscovery");
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
            return InternalRequestAsync<DescribeServiceDiscoveryResponse>(req, "DescribeServiceDiscovery")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据维度条件查询监控数据
        /// </summary>
        /// <param name="req"><see cref="DescribeStatisticDataRequest"/></param>
        /// <returns><see cref="DescribeStatisticDataResponse"/></returns>
        public Task<DescribeStatisticDataResponse> DescribeStatisticData(DescribeStatisticDataRequest req)
        {
            return InternalRequestAsync<DescribeStatisticDataResponse>(req, "DescribeStatisticData");
        }

        /// <summary>
        /// 根据维度条件查询监控数据
        /// </summary>
        /// <param name="req"><see cref="DescribeStatisticDataRequest"/></param>
        /// <returns><see cref="DescribeStatisticDataResponse"/></returns>
        public DescribeStatisticDataResponse DescribeStatisticDataSync(DescribeStatisticDataRequest req)
        {
            return InternalRequestAsync<DescribeStatisticDataResponse>(req, "DescribeStatisticData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 彻底删除 Prometheus 实例相关数据，给定的实例必须先被 Terminate(该接口是异步接口，实例是否释放需要通过 DescribePrometheusInstances 接口返回的状态来判断)。
        /// </summary>
        /// <param name="req"><see cref="DestroyPrometheusInstanceRequest"/></param>
        /// <returns><see cref="DestroyPrometheusInstanceResponse"/></returns>
        public Task<DestroyPrometheusInstanceResponse> DestroyPrometheusInstance(DestroyPrometheusInstanceRequest req)
        {
            return InternalRequestAsync<DestroyPrometheusInstanceResponse>(req, "DestroyPrometheusInstance");
        }

        /// <summary>
        /// 彻底删除 Prometheus 实例相关数据，给定的实例必须先被 Terminate(该接口是异步接口，实例是否释放需要通过 DescribePrometheusInstances 接口返回的状态来判断)。
        /// </summary>
        /// <param name="req"><see cref="DestroyPrometheusInstanceRequest"/></param>
        /// <returns><see cref="DestroyPrometheusInstanceResponse"/></returns>
        public DestroyPrometheusInstanceResponse DestroyPrometheusInstanceSync(DestroyPrometheusInstanceRequest req)
        {
            return InternalRequestAsync<DestroyPrometheusInstanceResponse>(req, "DestroyPrometheusInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置 Grafana 公网访问
        /// </summary>
        /// <param name="req"><see cref="EnableGrafanaInternetRequest"/></param>
        /// <returns><see cref="EnableGrafanaInternetResponse"/></returns>
        public Task<EnableGrafanaInternetResponse> EnableGrafanaInternet(EnableGrafanaInternetRequest req)
        {
            return InternalRequestAsync<EnableGrafanaInternetResponse>(req, "EnableGrafanaInternet");
        }

        /// <summary>
        /// 设置 Grafana 公网访问
        /// </summary>
        /// <param name="req"><see cref="EnableGrafanaInternetRequest"/></param>
        /// <returns><see cref="EnableGrafanaInternetResponse"/></returns>
        public EnableGrafanaInternetResponse EnableGrafanaInternetSync(EnableGrafanaInternetRequest req)
        {
            return InternalRequestAsync<EnableGrafanaInternetResponse>(req, "EnableGrafanaInternet")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置 Grafana 单点登录，使用腾讯云账号
        /// </summary>
        /// <param name="req"><see cref="EnableGrafanaSSORequest"/></param>
        /// <returns><see cref="EnableGrafanaSSOResponse"/></returns>
        public Task<EnableGrafanaSSOResponse> EnableGrafanaSSO(EnableGrafanaSSORequest req)
        {
            return InternalRequestAsync<EnableGrafanaSSOResponse>(req, "EnableGrafanaSSO");
        }

        /// <summary>
        /// 设置 Grafana 单点登录，使用腾讯云账号
        /// </summary>
        /// <param name="req"><see cref="EnableGrafanaSSORequest"/></param>
        /// <returns><see cref="EnableGrafanaSSOResponse"/></returns>
        public EnableGrafanaSSOResponse EnableGrafanaSSOSync(EnableGrafanaSSORequest req)
        {
            return InternalRequestAsync<EnableGrafanaSSOResponse>(req, "EnableGrafanaSSO")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// SSO单点登录时，设置是否cam鉴权
        /// </summary>
        /// <param name="req"><see cref="EnableSSOCamCheckRequest"/></param>
        /// <returns><see cref="EnableSSOCamCheckResponse"/></returns>
        public Task<EnableSSOCamCheckResponse> EnableSSOCamCheck(EnableSSOCamCheckRequest req)
        {
            return InternalRequestAsync<EnableSSOCamCheckResponse>(req, "EnableSSOCamCheck");
        }

        /// <summary>
        /// SSO单点登录时，设置是否cam鉴权
        /// </summary>
        /// <param name="req"><see cref="EnableSSOCamCheckRequest"/></param>
        /// <returns><see cref="EnableSSOCamCheckResponse"/></returns>
        public EnableSSOCamCheckResponse EnableSSOCamCheckSync(EnableSSOCamCheckRequest req)
        {
            return InternalRequestAsync<EnableSSOCamCheckResponse>(req, "EnableSSOCamCheck")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取云产品的监控数据。此接口不适用于拉取容器服务监控数据，如需拉取容器服务监控数据，请使用[根据维度条件查询监控数据](https://cloud.tencent.com/document/product/248/51845)接口。
        /// 传入产品的命名空间、对象维度描述和监控指标即可获得相应的监控数据。
        /// 接口调用限制：单请求最多可支持批量拉取10个实例的监控数据，单请求的数据点数限制为1440个。
        /// 若您需要调用的指标、对象较多，可能存在因限频出现拉取失败的情况，建议尽量将请求按时间维度均摊。
        /// 参数SpecifyStatistics目前可支持返回三种统计方式（avg，max，min），分别为二进制1，2，4。
        /// 例子：3:avg+max，5:avg+min，6:max+min，7:avg+max+min
        /// 拉取数据的粒度和统计方式的对应关系尽量在接入平台进行配置，如果没有配置，因为更小粒度数据存储时间有限，拉取时间范围也是有限。
        /// 
        /// >?
        /// >- 2022年9月1日起，腾讯云可观测平台开始对GetMonitorData接口计费。每个主账号每月可获得100万次免费请求额度，超过免费额度后如需继续调用接口需要开通 [API请求按量付费](https://buy.cloud.tencent.com/APIRequestBuy)。计费规则可查看[API计费文档](https://cloud.tencent.com/document/product/248/77914)。
        /// </summary>
        /// <param name="req"><see cref="GetMonitorDataRequest"/></param>
        /// <returns><see cref="GetMonitorDataResponse"/></returns>
        public Task<GetMonitorDataResponse> GetMonitorData(GetMonitorDataRequest req)
        {
            return InternalRequestAsync<GetMonitorDataResponse>(req, "GetMonitorData");
        }

        /// <summary>
        /// 获取云产品的监控数据。此接口不适用于拉取容器服务监控数据，如需拉取容器服务监控数据，请使用[根据维度条件查询监控数据](https://cloud.tencent.com/document/product/248/51845)接口。
        /// 传入产品的命名空间、对象维度描述和监控指标即可获得相应的监控数据。
        /// 接口调用限制：单请求最多可支持批量拉取10个实例的监控数据，单请求的数据点数限制为1440个。
        /// 若您需要调用的指标、对象较多，可能存在因限频出现拉取失败的情况，建议尽量将请求按时间维度均摊。
        /// 参数SpecifyStatistics目前可支持返回三种统计方式（avg，max，min），分别为二进制1，2，4。
        /// 例子：3:avg+max，5:avg+min，6:max+min，7:avg+max+min
        /// 拉取数据的粒度和统计方式的对应关系尽量在接入平台进行配置，如果没有配置，因为更小粒度数据存储时间有限，拉取时间范围也是有限。
        /// 
        /// >?
        /// >- 2022年9月1日起，腾讯云可观测平台开始对GetMonitorData接口计费。每个主账号每月可获得100万次免费请求额度，超过免费额度后如需继续调用接口需要开通 [API请求按量付费](https://buy.cloud.tencent.com/APIRequestBuy)。计费规则可查看[API计费文档](https://cloud.tencent.com/document/product/248/77914)。
        /// </summary>
        /// <param name="req"><see cref="GetMonitorDataRequest"/></param>
        /// <returns><see cref="GetMonitorDataResponse"/></returns>
        public GetMonitorDataResponse GetMonitorDataSync(GetMonitorDataRequest req)
        {
            return InternalRequestAsync<GetMonitorDataResponse>(req, "GetMonitorData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取 Prometheus Agent 管理相关的命令行
        /// </summary>
        /// <param name="req"><see cref="GetPrometheusAgentManagementCommandRequest"/></param>
        /// <returns><see cref="GetPrometheusAgentManagementCommandResponse"/></returns>
        public Task<GetPrometheusAgentManagementCommandResponse> GetPrometheusAgentManagementCommand(GetPrometheusAgentManagementCommandRequest req)
        {
            return InternalRequestAsync<GetPrometheusAgentManagementCommandResponse>(req, "GetPrometheusAgentManagementCommand");
        }

        /// <summary>
        /// 获取 Prometheus Agent 管理相关的命令行
        /// </summary>
        /// <param name="req"><see cref="GetPrometheusAgentManagementCommandRequest"/></param>
        /// <returns><see cref="GetPrometheusAgentManagementCommandResponse"/></returns>
        public GetPrometheusAgentManagementCommandResponse GetPrometheusAgentManagementCommandSync(GetPrometheusAgentManagementCommandRequest req)
        {
            return InternalRequestAsync<GetPrometheusAgentManagementCommandResponse>(req, "GetPrometheusAgentManagementCommand")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 安装 Grafana Plugin
        /// </summary>
        /// <param name="req"><see cref="InstallPluginsRequest"/></param>
        /// <returns><see cref="InstallPluginsResponse"/></returns>
        public Task<InstallPluginsResponse> InstallPlugins(InstallPluginsRequest req)
        {
            return InternalRequestAsync<InstallPluginsResponse>(req, "InstallPlugins");
        }

        /// <summary>
        /// 安装 Grafana Plugin
        /// </summary>
        /// <param name="req"><see cref="InstallPluginsRequest"/></param>
        /// <returns><see cref="InstallPluginsResponse"/></returns>
        public InstallPluginsResponse InstallPluginsSync(InstallPluginsRequest req)
        {
            return InternalRequestAsync<InstallPluginsResponse>(req, "InstallPlugins")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑告警通知模板
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmNoticeRequest"/></param>
        /// <returns><see cref="ModifyAlarmNoticeResponse"/></returns>
        public Task<ModifyAlarmNoticeResponse> ModifyAlarmNotice(ModifyAlarmNoticeRequest req)
        {
            return InternalRequestAsync<ModifyAlarmNoticeResponse>(req, "ModifyAlarmNotice");
        }

        /// <summary>
        /// 编辑告警通知模板
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmNoticeRequest"/></param>
        /// <returns><see cref="ModifyAlarmNoticeResponse"/></returns>
        public ModifyAlarmNoticeResponse ModifyAlarmNoticeSync(ModifyAlarmNoticeRequest req)
        {
            return InternalRequestAsync<ModifyAlarmNoticeResponse>(req, "ModifyAlarmNotice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改告警策略触发条件
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmPolicyConditionRequest"/></param>
        /// <returns><see cref="ModifyAlarmPolicyConditionResponse"/></returns>
        public Task<ModifyAlarmPolicyConditionResponse> ModifyAlarmPolicyCondition(ModifyAlarmPolicyConditionRequest req)
        {
            return InternalRequestAsync<ModifyAlarmPolicyConditionResponse>(req, "ModifyAlarmPolicyCondition");
        }

        /// <summary>
        /// 修改告警策略触发条件
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmPolicyConditionRequest"/></param>
        /// <returns><see cref="ModifyAlarmPolicyConditionResponse"/></returns>
        public ModifyAlarmPolicyConditionResponse ModifyAlarmPolicyConditionSync(ModifyAlarmPolicyConditionRequest req)
        {
            return InternalRequestAsync<ModifyAlarmPolicyConditionResponse>(req, "ModifyAlarmPolicyCondition")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 告警2.0编辑告警策略基本信息，包括策略名、备注
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmPolicyInfoRequest"/></param>
        /// <returns><see cref="ModifyAlarmPolicyInfoResponse"/></returns>
        public Task<ModifyAlarmPolicyInfoResponse> ModifyAlarmPolicyInfo(ModifyAlarmPolicyInfoRequest req)
        {
            return InternalRequestAsync<ModifyAlarmPolicyInfoResponse>(req, "ModifyAlarmPolicyInfo");
        }

        /// <summary>
        /// 告警2.0编辑告警策略基本信息，包括策略名、备注
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmPolicyInfoRequest"/></param>
        /// <returns><see cref="ModifyAlarmPolicyInfoResponse"/></returns>
        public ModifyAlarmPolicyInfoResponse ModifyAlarmPolicyInfoSync(ModifyAlarmPolicyInfoRequest req)
        {
            return InternalRequestAsync<ModifyAlarmPolicyInfoResponse>(req, "ModifyAlarmPolicyInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改告警策略绑定的告警通知模板
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmPolicyNoticeRequest"/></param>
        /// <returns><see cref="ModifyAlarmPolicyNoticeResponse"/></returns>
        public Task<ModifyAlarmPolicyNoticeResponse> ModifyAlarmPolicyNotice(ModifyAlarmPolicyNoticeRequest req)
        {
            return InternalRequestAsync<ModifyAlarmPolicyNoticeResponse>(req, "ModifyAlarmPolicyNotice");
        }

        /// <summary>
        /// 修改告警策略绑定的告警通知模板
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmPolicyNoticeRequest"/></param>
        /// <returns><see cref="ModifyAlarmPolicyNoticeResponse"/></returns>
        public ModifyAlarmPolicyNoticeResponse ModifyAlarmPolicyNoticeSync(ModifyAlarmPolicyNoticeRequest req)
        {
            return InternalRequestAsync<ModifyAlarmPolicyNoticeResponse>(req, "ModifyAlarmPolicyNotice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启停告警策略
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmPolicyStatusRequest"/></param>
        /// <returns><see cref="ModifyAlarmPolicyStatusResponse"/></returns>
        public Task<ModifyAlarmPolicyStatusResponse> ModifyAlarmPolicyStatus(ModifyAlarmPolicyStatusRequest req)
        {
            return InternalRequestAsync<ModifyAlarmPolicyStatusResponse>(req, "ModifyAlarmPolicyStatus");
        }

        /// <summary>
        /// 启停告警策略
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmPolicyStatusRequest"/></param>
        /// <returns><see cref="ModifyAlarmPolicyStatusResponse"/></returns>
        public ModifyAlarmPolicyStatusResponse ModifyAlarmPolicyStatusSync(ModifyAlarmPolicyStatusRequest req)
        {
            return InternalRequestAsync<ModifyAlarmPolicyStatusResponse>(req, "ModifyAlarmPolicyStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改告警策略的触发任务，TriggerTasks字段放触发任务列表，TriggerTasks传空数组时，代表解绑该策略的所有触发任务。
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmPolicyTasksRequest"/></param>
        /// <returns><see cref="ModifyAlarmPolicyTasksResponse"/></returns>
        public Task<ModifyAlarmPolicyTasksResponse> ModifyAlarmPolicyTasks(ModifyAlarmPolicyTasksRequest req)
        {
            return InternalRequestAsync<ModifyAlarmPolicyTasksResponse>(req, "ModifyAlarmPolicyTasks");
        }

        /// <summary>
        /// 修改告警策略的触发任务，TriggerTasks字段放触发任务列表，TriggerTasks传空数组时，代表解绑该策略的所有触发任务。
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmPolicyTasksRequest"/></param>
        /// <returns><see cref="ModifyAlarmPolicyTasksResponse"/></returns>
        public ModifyAlarmPolicyTasksResponse ModifyAlarmPolicyTasksSync(ModifyAlarmPolicyTasksRequest req)
        {
            return InternalRequestAsync<ModifyAlarmPolicyTasksResponse>(req, "ModifyAlarmPolicyTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改告警接收人
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmReceiversRequest"/></param>
        /// <returns><see cref="ModifyAlarmReceiversResponse"/></returns>
        public Task<ModifyAlarmReceiversResponse> ModifyAlarmReceivers(ModifyAlarmReceiversRequest req)
        {
            return InternalRequestAsync<ModifyAlarmReceiversResponse>(req, "ModifyAlarmReceivers");
        }

        /// <summary>
        /// 修改告警接收人
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmReceiversRequest"/></param>
        /// <returns><see cref="ModifyAlarmReceiversResponse"/></returns>
        public ModifyAlarmReceiversResponse ModifyAlarmReceiversSync(ModifyAlarmReceiversRequest req)
        {
            return InternalRequestAsync<ModifyAlarmReceiversResponse>(req, "ModifyAlarmReceivers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改 Grafana 实例属性
        /// </summary>
        /// <param name="req"><see cref="ModifyGrafanaInstanceRequest"/></param>
        /// <returns><see cref="ModifyGrafanaInstanceResponse"/></returns>
        public Task<ModifyGrafanaInstanceResponse> ModifyGrafanaInstance(ModifyGrafanaInstanceRequest req)
        {
            return InternalRequestAsync<ModifyGrafanaInstanceResponse>(req, "ModifyGrafanaInstance");
        }

        /// <summary>
        /// 修改 Grafana 实例属性
        /// </summary>
        /// <param name="req"><see cref="ModifyGrafanaInstanceRequest"/></param>
        /// <returns><see cref="ModifyGrafanaInstanceResponse"/></returns>
        public ModifyGrafanaInstanceResponse ModifyGrafanaInstanceSync(ModifyGrafanaInstanceRequest req)
        {
            return InternalRequestAsync<ModifyGrafanaInstanceResponse>(req, "ModifyGrafanaInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新策略组
        /// </summary>
        /// <param name="req"><see cref="ModifyPolicyGroupRequest"/></param>
        /// <returns><see cref="ModifyPolicyGroupResponse"/></returns>
        public Task<ModifyPolicyGroupResponse> ModifyPolicyGroup(ModifyPolicyGroupRequest req)
        {
            return InternalRequestAsync<ModifyPolicyGroupResponse>(req, "ModifyPolicyGroup");
        }

        /// <summary>
        /// 更新策略组
        /// </summary>
        /// <param name="req"><see cref="ModifyPolicyGroupRequest"/></param>
        /// <returns><see cref="ModifyPolicyGroupResponse"/></returns>
        public ModifyPolicyGroupResponse ModifyPolicyGroupSync(ModifyPolicyGroupRequest req)
        {
            return InternalRequestAsync<ModifyPolicyGroupResponse>(req, "ModifyPolicyGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改被关联集群的external labels
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusAgentExternalLabelsRequest"/></param>
        /// <returns><see cref="ModifyPrometheusAgentExternalLabelsResponse"/></returns>
        public Task<ModifyPrometheusAgentExternalLabelsResponse> ModifyPrometheusAgentExternalLabels(ModifyPrometheusAgentExternalLabelsRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusAgentExternalLabelsResponse>(req, "ModifyPrometheusAgentExternalLabels");
        }

        /// <summary>
        /// 修改被关联集群的external labels
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusAgentExternalLabelsRequest"/></param>
        /// <returns><see cref="ModifyPrometheusAgentExternalLabelsResponse"/></returns>
        public ModifyPrometheusAgentExternalLabelsResponse ModifyPrometheusAgentExternalLabelsSync(ModifyPrometheusAgentExternalLabelsRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusAgentExternalLabelsResponse>(req, "ModifyPrometheusAgentExternalLabels")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改2.0实例告警策略
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusAlertPolicyRequest"/></param>
        /// <returns><see cref="ModifyPrometheusAlertPolicyResponse"/></returns>
        public Task<ModifyPrometheusAlertPolicyResponse> ModifyPrometheusAlertPolicy(ModifyPrometheusAlertPolicyRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusAlertPolicyResponse>(req, "ModifyPrometheusAlertPolicy");
        }

        /// <summary>
        /// 修改2.0实例告警策略
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusAlertPolicyRequest"/></param>
        /// <returns><see cref="ModifyPrometheusAlertPolicyResponse"/></returns>
        public ModifyPrometheusAlertPolicyResponse ModifyPrometheusAlertPolicySync(ModifyPrometheusAlertPolicyRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusAlertPolicyResponse>(req, "ModifyPrometheusAlertPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改prometheus采集配置
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusConfigRequest"/></param>
        /// <returns><see cref="ModifyPrometheusConfigResponse"/></returns>
        public Task<ModifyPrometheusConfigResponse> ModifyPrometheusConfig(ModifyPrometheusConfigRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusConfigResponse>(req, "ModifyPrometheusConfig");
        }

        /// <summary>
        /// 修改prometheus采集配置
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusConfigRequest"/></param>
        /// <returns><see cref="ModifyPrometheusConfigResponse"/></returns>
        public ModifyPrometheusConfigResponse ModifyPrometheusConfigSync(ModifyPrometheusConfigRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusConfigResponse>(req, "ModifyPrometheusConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改全局告警通知渠道
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusGlobalNotificationRequest"/></param>
        /// <returns><see cref="ModifyPrometheusGlobalNotificationResponse"/></returns>
        public Task<ModifyPrometheusGlobalNotificationResponse> ModifyPrometheusGlobalNotification(ModifyPrometheusGlobalNotificationRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusGlobalNotificationResponse>(req, "ModifyPrometheusGlobalNotification");
        }

        /// <summary>
        /// 修改全局告警通知渠道
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusGlobalNotificationRequest"/></param>
        /// <returns><see cref="ModifyPrometheusGlobalNotificationResponse"/></returns>
        public ModifyPrometheusGlobalNotificationResponse ModifyPrometheusGlobalNotificationSync(ModifyPrometheusGlobalNotificationRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusGlobalNotificationResponse>(req, "ModifyPrometheusGlobalNotification")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改 Prometheus 实例相关属性
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusInstanceAttributesRequest"/></param>
        /// <returns><see cref="ModifyPrometheusInstanceAttributesResponse"/></returns>
        public Task<ModifyPrometheusInstanceAttributesResponse> ModifyPrometheusInstanceAttributes(ModifyPrometheusInstanceAttributesRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusInstanceAttributesResponse>(req, "ModifyPrometheusInstanceAttributes");
        }

        /// <summary>
        /// 修改 Prometheus 实例相关属性
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusInstanceAttributesRequest"/></param>
        /// <returns><see cref="ModifyPrometheusInstanceAttributesResponse"/></returns>
        public ModifyPrometheusInstanceAttributesResponse ModifyPrometheusInstanceAttributesSync(ModifyPrometheusInstanceAttributesRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusInstanceAttributesResponse>(req, "ModifyPrometheusInstanceAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过yaml的方式修改Prometheus聚合实例
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusRecordRuleYamlRequest"/></param>
        /// <returns><see cref="ModifyPrometheusRecordRuleYamlResponse"/></returns>
        public Task<ModifyPrometheusRecordRuleYamlResponse> ModifyPrometheusRecordRuleYaml(ModifyPrometheusRecordRuleYamlRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusRecordRuleYamlResponse>(req, "ModifyPrometheusRecordRuleYaml");
        }

        /// <summary>
        /// 通过yaml的方式修改Prometheus聚合实例
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusRecordRuleYamlRequest"/></param>
        /// <returns><see cref="ModifyPrometheusRecordRuleYamlResponse"/></returns>
        public ModifyPrometheusRecordRuleYamlResponse ModifyPrometheusRecordRuleYamlSync(ModifyPrometheusRecordRuleYamlRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusRecordRuleYamlResponse>(req, "ModifyPrometheusRecordRuleYaml")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改模板内容
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusTempRequest"/></param>
        /// <returns><see cref="ModifyPrometheusTempResponse"/></returns>
        public Task<ModifyPrometheusTempResponse> ModifyPrometheusTemp(ModifyPrometheusTempRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusTempResponse>(req, "ModifyPrometheusTemp");
        }

        /// <summary>
        /// 修改模板内容
        /// </summary>
        /// <param name="req"><see cref="ModifyPrometheusTempRequest"/></param>
        /// <returns><see cref="ModifyPrometheusTempResponse"/></returns>
        public ModifyPrometheusTempResponse ModifyPrometheusTempSync(ModifyPrometheusTempRequest req)
        {
            return InternalRequestAsync<ModifyPrometheusTempResponse>(req, "ModifyPrometheusTemp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ResumeGrafanaInstance）用于 Grafana 包年包月实例的停服续费，调用后按原版本续费一个月。仍在运行中的实例无法使用该接口进行续费。
        /// </summary>
        /// <param name="req"><see cref="ResumeGrafanaInstanceRequest"/></param>
        /// <returns><see cref="ResumeGrafanaInstanceResponse"/></returns>
        public Task<ResumeGrafanaInstanceResponse> ResumeGrafanaInstance(ResumeGrafanaInstanceRequest req)
        {
            return InternalRequestAsync<ResumeGrafanaInstanceResponse>(req, "ResumeGrafanaInstance");
        }

        /// <summary>
        /// 本接口（ResumeGrafanaInstance）用于 Grafana 包年包月实例的停服续费，调用后按原版本续费一个月。仍在运行中的实例无法使用该接口进行续费。
        /// </summary>
        /// <param name="req"><see cref="ResumeGrafanaInstanceRequest"/></param>
        /// <returns><see cref="ResumeGrafanaInstanceResponse"/></returns>
        public ResumeGrafanaInstanceResponse ResumeGrafanaInstanceSync(ResumeGrafanaInstanceRequest req)
        {
            return InternalRequestAsync<ResumeGrafanaInstanceResponse>(req, "ResumeGrafanaInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 初始化TMP实例，开启集成中心时调用
        /// </summary>
        /// <param name="req"><see cref="RunPrometheusInstanceRequest"/></param>
        /// <returns><see cref="RunPrometheusInstanceResponse"/></returns>
        public Task<RunPrometheusInstanceResponse> RunPrometheusInstance(RunPrometheusInstanceRequest req)
        {
            return InternalRequestAsync<RunPrometheusInstanceResponse>(req, "RunPrometheusInstance");
        }

        /// <summary>
        /// 初始化TMP实例，开启集成中心时调用
        /// </summary>
        /// <param name="req"><see cref="RunPrometheusInstanceRequest"/></param>
        /// <returns><see cref="RunPrometheusInstanceResponse"/></returns>
        public RunPrometheusInstanceResponse RunPrometheusInstanceSync(RunPrometheusInstanceRequest req)
        {
            return InternalRequestAsync<RunPrometheusInstanceResponse>(req, "RunPrometheusInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置一个策略为该告警策略类型、该项目的默认告警策略。
        /// 同一项目下相同的告警策略类型，就会被设置为非默认。
        /// </summary>
        /// <param name="req"><see cref="SetDefaultAlarmPolicyRequest"/></param>
        /// <returns><see cref="SetDefaultAlarmPolicyResponse"/></returns>
        public Task<SetDefaultAlarmPolicyResponse> SetDefaultAlarmPolicy(SetDefaultAlarmPolicyRequest req)
        {
            return InternalRequestAsync<SetDefaultAlarmPolicyResponse>(req, "SetDefaultAlarmPolicy");
        }

        /// <summary>
        /// 设置一个策略为该告警策略类型、该项目的默认告警策略。
        /// 同一项目下相同的告警策略类型，就会被设置为非默认。
        /// </summary>
        /// <param name="req"><see cref="SetDefaultAlarmPolicyRequest"/></param>
        /// <returns><see cref="SetDefaultAlarmPolicyResponse"/></returns>
        public SetDefaultAlarmPolicyResponse SetDefaultAlarmPolicySync(SetDefaultAlarmPolicyRequest req)
        {
            return InternalRequestAsync<SetDefaultAlarmPolicyResponse>(req, "SetDefaultAlarmPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 同步模板到实例或者集群，针对V2版本实例
        /// </summary>
        /// <param name="req"><see cref="SyncPrometheusTempRequest"/></param>
        /// <returns><see cref="SyncPrometheusTempResponse"/></returns>
        public Task<SyncPrometheusTempResponse> SyncPrometheusTemp(SyncPrometheusTempRequest req)
        {
            return InternalRequestAsync<SyncPrometheusTempResponse>(req, "SyncPrometheusTemp");
        }

        /// <summary>
        /// 同步模板到实例或者集群，针对V2版本实例
        /// </summary>
        /// <param name="req"><see cref="SyncPrometheusTempRequest"/></param>
        /// <returns><see cref="SyncPrometheusTempResponse"/></returns>
        public SyncPrometheusTempResponse SyncPrometheusTempSync(SyncPrometheusTempRequest req)
        {
            return InternalRequestAsync<SyncPrometheusTempResponse>(req, "SyncPrometheusTemp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 销毁按量 Prometheus 实例
        /// </summary>
        /// <param name="req"><see cref="TerminatePrometheusInstancesRequest"/></param>
        /// <returns><see cref="TerminatePrometheusInstancesResponse"/></returns>
        public Task<TerminatePrometheusInstancesResponse> TerminatePrometheusInstances(TerminatePrometheusInstancesRequest req)
        {
            return InternalRequestAsync<TerminatePrometheusInstancesResponse>(req, "TerminatePrometheusInstances");
        }

        /// <summary>
        /// 销毁按量 Prometheus 实例
        /// </summary>
        /// <param name="req"><see cref="TerminatePrometheusInstancesRequest"/></param>
        /// <returns><see cref="TerminatePrometheusInstancesResponse"/></returns>
        public TerminatePrometheusInstancesResponse TerminatePrometheusInstancesSync(TerminatePrometheusInstancesRequest req)
        {
            return InternalRequestAsync<TerminatePrometheusInstancesResponse>(req, "TerminatePrometheusInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除全部的关联对象
        /// </summary>
        /// <param name="req"><see cref="UnBindingAllPolicyObjectRequest"/></param>
        /// <returns><see cref="UnBindingAllPolicyObjectResponse"/></returns>
        public Task<UnBindingAllPolicyObjectResponse> UnBindingAllPolicyObject(UnBindingAllPolicyObjectRequest req)
        {
            return InternalRequestAsync<UnBindingAllPolicyObjectResponse>(req, "UnBindingAllPolicyObject");
        }

        /// <summary>
        /// 删除全部的关联对象
        /// </summary>
        /// <param name="req"><see cref="UnBindingAllPolicyObjectRequest"/></param>
        /// <returns><see cref="UnBindingAllPolicyObjectResponse"/></returns>
        public UnBindingAllPolicyObjectResponse UnBindingAllPolicyObjectSync(UnBindingAllPolicyObjectRequest req)
        {
            return InternalRequestAsync<UnBindingAllPolicyObjectResponse>(req, "UnBindingAllPolicyObject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除策略的关联对象
        /// </summary>
        /// <param name="req"><see cref="UnBindingPolicyObjectRequest"/></param>
        /// <returns><see cref="UnBindingPolicyObjectResponse"/></returns>
        public Task<UnBindingPolicyObjectResponse> UnBindingPolicyObject(UnBindingPolicyObjectRequest req)
        {
            return InternalRequestAsync<UnBindingPolicyObjectResponse>(req, "UnBindingPolicyObject");
        }

        /// <summary>
        /// 删除策略的关联对象
        /// </summary>
        /// <param name="req"><see cref="UnBindingPolicyObjectRequest"/></param>
        /// <returns><see cref="UnBindingPolicyObjectResponse"/></returns>
        public UnBindingPolicyObjectResponse UnBindingPolicyObjectSync(UnBindingPolicyObjectRequest req)
        {
            return InternalRequestAsync<UnBindingPolicyObjectResponse>(req, "UnBindingPolicyObject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 解除实例绑定的 Grafana 可视化实例
        /// </summary>
        /// <param name="req"><see cref="UnbindPrometheusManagedGrafanaRequest"/></param>
        /// <returns><see cref="UnbindPrometheusManagedGrafanaResponse"/></returns>
        public Task<UnbindPrometheusManagedGrafanaResponse> UnbindPrometheusManagedGrafana(UnbindPrometheusManagedGrafanaRequest req)
        {
            return InternalRequestAsync<UnbindPrometheusManagedGrafanaResponse>(req, "UnbindPrometheusManagedGrafana");
        }

        /// <summary>
        /// 解除实例绑定的 Grafana 可视化实例
        /// </summary>
        /// <param name="req"><see cref="UnbindPrometheusManagedGrafanaRequest"/></param>
        /// <returns><see cref="UnbindPrometheusManagedGrafanaResponse"/></returns>
        public UnbindPrometheusManagedGrafanaResponse UnbindPrometheusManagedGrafanaSync(UnbindPrometheusManagedGrafanaRequest req)
        {
            return InternalRequestAsync<UnbindPrometheusManagedGrafanaResponse>(req, "UnbindPrometheusManagedGrafana")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除 Grafana Dashboard
        /// </summary>
        /// <param name="req"><see cref="UninstallGrafanaDashboardRequest"/></param>
        /// <returns><see cref="UninstallGrafanaDashboardResponse"/></returns>
        public Task<UninstallGrafanaDashboardResponse> UninstallGrafanaDashboard(UninstallGrafanaDashboardRequest req)
        {
            return InternalRequestAsync<UninstallGrafanaDashboardResponse>(req, "UninstallGrafanaDashboard");
        }

        /// <summary>
        /// 删除 Grafana Dashboard
        /// </summary>
        /// <param name="req"><see cref="UninstallGrafanaDashboardRequest"/></param>
        /// <returns><see cref="UninstallGrafanaDashboardResponse"/></returns>
        public UninstallGrafanaDashboardResponse UninstallGrafanaDashboardSync(UninstallGrafanaDashboardRequest req)
        {
            return InternalRequestAsync<UninstallGrafanaDashboardResponse>(req, "UninstallGrafanaDashboard")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除已安装的插件
        /// </summary>
        /// <param name="req"><see cref="UninstallGrafanaPluginsRequest"/></param>
        /// <returns><see cref="UninstallGrafanaPluginsResponse"/></returns>
        public Task<UninstallGrafanaPluginsResponse> UninstallGrafanaPlugins(UninstallGrafanaPluginsRequest req)
        {
            return InternalRequestAsync<UninstallGrafanaPluginsResponse>(req, "UninstallGrafanaPlugins");
        }

        /// <summary>
        /// 删除已安装的插件
        /// </summary>
        /// <param name="req"><see cref="UninstallGrafanaPluginsRequest"/></param>
        /// <returns><see cref="UninstallGrafanaPluginsResponse"/></returns>
        public UninstallGrafanaPluginsResponse UninstallGrafanaPluginsSync(UninstallGrafanaPluginsRequest req)
        {
            return InternalRequestAsync<UninstallGrafanaPluginsResponse>(req, "UninstallGrafanaPlugins")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新 Prometheus 的告警规则。
        /// 
        /// 请注意，**告警对象和告警消息是 Prometheus Rule Annotations 的特殊字段，需要通过 annotations 来传递，对应的 Key 分别为summary/description**，，请参考 [Prometheus Rule更多配置请参考](https://prometheus.io/docs/prometheus/latest/configuration/alerting_rules/)。
        /// </summary>
        /// <param name="req"><see cref="UpdateAlertRuleRequest"/></param>
        /// <returns><see cref="UpdateAlertRuleResponse"/></returns>
        public Task<UpdateAlertRuleResponse> UpdateAlertRule(UpdateAlertRuleRequest req)
        {
            return InternalRequestAsync<UpdateAlertRuleResponse>(req, "UpdateAlertRule");
        }

        /// <summary>
        /// 更新 Prometheus 的告警规则。
        /// 
        /// 请注意，**告警对象和告警消息是 Prometheus Rule Annotations 的特殊字段，需要通过 annotations 来传递，对应的 Key 分别为summary/description**，，请参考 [Prometheus Rule更多配置请参考](https://prometheus.io/docs/prometheus/latest/configuration/alerting_rules/)。
        /// </summary>
        /// <param name="req"><see cref="UpdateAlertRuleRequest"/></param>
        /// <returns><see cref="UpdateAlertRuleResponse"/></returns>
        public UpdateAlertRuleResponse UpdateAlertRuleSync(UpdateAlertRuleRequest req)
        {
            return InternalRequestAsync<UpdateAlertRuleResponse>(req, "UpdateAlertRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新 Prometheus 报警策略状态
        /// </summary>
        /// <param name="req"><see cref="UpdateAlertRuleStateRequest"/></param>
        /// <returns><see cref="UpdateAlertRuleStateResponse"/></returns>
        public Task<UpdateAlertRuleStateResponse> UpdateAlertRuleState(UpdateAlertRuleStateRequest req)
        {
            return InternalRequestAsync<UpdateAlertRuleStateResponse>(req, "UpdateAlertRuleState");
        }

        /// <summary>
        /// 更新 Prometheus 报警策略状态
        /// </summary>
        /// <param name="req"><see cref="UpdateAlertRuleStateRequest"/></param>
        /// <returns><see cref="UpdateAlertRuleStateResponse"/></returns>
        public UpdateAlertRuleStateResponse UpdateAlertRuleStateSync(UpdateAlertRuleStateRequest req)
        {
            return InternalRequestAsync<UpdateAlertRuleStateResponse>(req, "UpdateAlertRuleState")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新 Grafana 的 DNS 配置
        /// </summary>
        /// <param name="req"><see cref="UpdateDNSConfigRequest"/></param>
        /// <returns><see cref="UpdateDNSConfigResponse"/></returns>
        public Task<UpdateDNSConfigResponse> UpdateDNSConfig(UpdateDNSConfigRequest req)
        {
            return InternalRequestAsync<UpdateDNSConfigResponse>(req, "UpdateDNSConfig");
        }

        /// <summary>
        /// 更新 Grafana 的 DNS 配置
        /// </summary>
        /// <param name="req"><see cref="UpdateDNSConfigRequest"/></param>
        /// <returns><see cref="UpdateDNSConfigResponse"/></returns>
        public UpdateDNSConfigResponse UpdateDNSConfigSync(UpdateDNSConfigRequest req)
        {
            return InternalRequestAsync<UpdateDNSConfigResponse>(req, "UpdateDNSConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新 exporter 集成配置
        /// </summary>
        /// <param name="req"><see cref="UpdateExporterIntegrationRequest"/></param>
        /// <returns><see cref="UpdateExporterIntegrationResponse"/></returns>
        public Task<UpdateExporterIntegrationResponse> UpdateExporterIntegration(UpdateExporterIntegrationRequest req)
        {
            return InternalRequestAsync<UpdateExporterIntegrationResponse>(req, "UpdateExporterIntegration");
        }

        /// <summary>
        /// 更新 exporter 集成配置
        /// </summary>
        /// <param name="req"><see cref="UpdateExporterIntegrationRequest"/></param>
        /// <returns><see cref="UpdateExporterIntegrationResponse"/></returns>
        public UpdateExporterIntegrationResponse UpdateExporterIntegrationSync(UpdateExporterIntegrationRequest req)
        {
            return InternalRequestAsync<UpdateExporterIntegrationResponse>(req, "UpdateExporterIntegration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新 Grafana 配置
        /// </summary>
        /// <param name="req"><see cref="UpdateGrafanaConfigRequest"/></param>
        /// <returns><see cref="UpdateGrafanaConfigResponse"/></returns>
        public Task<UpdateGrafanaConfigResponse> UpdateGrafanaConfig(UpdateGrafanaConfigRequest req)
        {
            return InternalRequestAsync<UpdateGrafanaConfigResponse>(req, "UpdateGrafanaConfig");
        }

        /// <summary>
        /// 更新 Grafana 配置
        /// </summary>
        /// <param name="req"><see cref="UpdateGrafanaConfigRequest"/></param>
        /// <returns><see cref="UpdateGrafanaConfigResponse"/></returns>
        public UpdateGrafanaConfigResponse UpdateGrafanaConfigSync(UpdateGrafanaConfigRequest req)
        {
            return InternalRequestAsync<UpdateGrafanaConfigResponse>(req, "UpdateGrafanaConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新 Grafana 环境变量
        /// </summary>
        /// <param name="req"><see cref="UpdateGrafanaEnvironmentsRequest"/></param>
        /// <returns><see cref="UpdateGrafanaEnvironmentsResponse"/></returns>
        public Task<UpdateGrafanaEnvironmentsResponse> UpdateGrafanaEnvironments(UpdateGrafanaEnvironmentsRequest req)
        {
            return InternalRequestAsync<UpdateGrafanaEnvironmentsResponse>(req, "UpdateGrafanaEnvironments");
        }

        /// <summary>
        /// 更新 Grafana 环境变量
        /// </summary>
        /// <param name="req"><see cref="UpdateGrafanaEnvironmentsRequest"/></param>
        /// <returns><see cref="UpdateGrafanaEnvironmentsResponse"/></returns>
        public UpdateGrafanaEnvironmentsResponse UpdateGrafanaEnvironmentsSync(UpdateGrafanaEnvironmentsRequest req)
        {
            return InternalRequestAsync<UpdateGrafanaEnvironmentsResponse>(req, "UpdateGrafanaEnvironments")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新 Grafana 集成配置
        /// </summary>
        /// <param name="req"><see cref="UpdateGrafanaIntegrationRequest"/></param>
        /// <returns><see cref="UpdateGrafanaIntegrationResponse"/></returns>
        public Task<UpdateGrafanaIntegrationResponse> UpdateGrafanaIntegration(UpdateGrafanaIntegrationRequest req)
        {
            return InternalRequestAsync<UpdateGrafanaIntegrationResponse>(req, "UpdateGrafanaIntegration");
        }

        /// <summary>
        /// 更新 Grafana 集成配置
        /// </summary>
        /// <param name="req"><see cref="UpdateGrafanaIntegrationRequest"/></param>
        /// <returns><see cref="UpdateGrafanaIntegrationResponse"/></returns>
        public UpdateGrafanaIntegrationResponse UpdateGrafanaIntegrationSync(UpdateGrafanaIntegrationRequest req)
        {
            return InternalRequestAsync<UpdateGrafanaIntegrationResponse>(req, "UpdateGrafanaIntegration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新 Grafana 告警通道
        /// </summary>
        /// <param name="req"><see cref="UpdateGrafanaNotificationChannelRequest"/></param>
        /// <returns><see cref="UpdateGrafanaNotificationChannelResponse"/></returns>
        public Task<UpdateGrafanaNotificationChannelResponse> UpdateGrafanaNotificationChannel(UpdateGrafanaNotificationChannelRequest req)
        {
            return InternalRequestAsync<UpdateGrafanaNotificationChannelResponse>(req, "UpdateGrafanaNotificationChannel");
        }

        /// <summary>
        /// 更新 Grafana 告警通道
        /// </summary>
        /// <param name="req"><see cref="UpdateGrafanaNotificationChannelRequest"/></param>
        /// <returns><see cref="UpdateGrafanaNotificationChannelResponse"/></returns>
        public UpdateGrafanaNotificationChannelResponse UpdateGrafanaNotificationChannelSync(UpdateGrafanaNotificationChannelRequest req)
        {
            return InternalRequestAsync<UpdateGrafanaNotificationChannelResponse>(req, "UpdateGrafanaNotificationChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新 Grafana 白名单
        /// </summary>
        /// <param name="req"><see cref="UpdateGrafanaWhiteListRequest"/></param>
        /// <returns><see cref="UpdateGrafanaWhiteListResponse"/></returns>
        public Task<UpdateGrafanaWhiteListResponse> UpdateGrafanaWhiteList(UpdateGrafanaWhiteListRequest req)
        {
            return InternalRequestAsync<UpdateGrafanaWhiteListResponse>(req, "UpdateGrafanaWhiteList");
        }

        /// <summary>
        /// 更新 Grafana 白名单
        /// </summary>
        /// <param name="req"><see cref="UpdateGrafanaWhiteListRequest"/></param>
        /// <returns><see cref="UpdateGrafanaWhiteListResponse"/></returns>
        public UpdateGrafanaWhiteListResponse UpdateGrafanaWhiteListSync(UpdateGrafanaWhiteListRequest req)
        {
            return InternalRequestAsync<UpdateGrafanaWhiteListResponse>(req, "UpdateGrafanaWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新 Prometheus CVM Agent 状态
        /// </summary>
        /// <param name="req"><see cref="UpdatePrometheusAgentStatusRequest"/></param>
        /// <returns><see cref="UpdatePrometheusAgentStatusResponse"/></returns>
        public Task<UpdatePrometheusAgentStatusResponse> UpdatePrometheusAgentStatus(UpdatePrometheusAgentStatusRequest req)
        {
            return InternalRequestAsync<UpdatePrometheusAgentStatusResponse>(req, "UpdatePrometheusAgentStatus");
        }

        /// <summary>
        /// 更新 Prometheus CVM Agent 状态
        /// </summary>
        /// <param name="req"><see cref="UpdatePrometheusAgentStatusRequest"/></param>
        /// <returns><see cref="UpdatePrometheusAgentStatusResponse"/></returns>
        public UpdatePrometheusAgentStatusResponse UpdatePrometheusAgentStatusSync(UpdatePrometheusAgentStatusRequest req)
        {
            return InternalRequestAsync<UpdatePrometheusAgentStatusResponse>(req, "UpdatePrometheusAgentStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新Prometheus告警规则分组
        /// </summary>
        /// <param name="req"><see cref="UpdatePrometheusAlertGroupRequest"/></param>
        /// <returns><see cref="UpdatePrometheusAlertGroupResponse"/></returns>
        public Task<UpdatePrometheusAlertGroupResponse> UpdatePrometheusAlertGroup(UpdatePrometheusAlertGroupRequest req)
        {
            return InternalRequestAsync<UpdatePrometheusAlertGroupResponse>(req, "UpdatePrometheusAlertGroup");
        }

        /// <summary>
        /// 更新Prometheus告警规则分组
        /// </summary>
        /// <param name="req"><see cref="UpdatePrometheusAlertGroupRequest"/></param>
        /// <returns><see cref="UpdatePrometheusAlertGroupResponse"/></returns>
        public UpdatePrometheusAlertGroupResponse UpdatePrometheusAlertGroupSync(UpdatePrometheusAlertGroupRequest req)
        {
            return InternalRequestAsync<UpdatePrometheusAlertGroupResponse>(req, "UpdatePrometheusAlertGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量更新告警分组状态，将分组中全部告警规则更新为目标状态
        /// </summary>
        /// <param name="req"><see cref="UpdatePrometheusAlertGroupStateRequest"/></param>
        /// <returns><see cref="UpdatePrometheusAlertGroupStateResponse"/></returns>
        public Task<UpdatePrometheusAlertGroupStateResponse> UpdatePrometheusAlertGroupState(UpdatePrometheusAlertGroupStateRequest req)
        {
            return InternalRequestAsync<UpdatePrometheusAlertGroupStateResponse>(req, "UpdatePrometheusAlertGroupState");
        }

        /// <summary>
        /// 批量更新告警分组状态，将分组中全部告警规则更新为目标状态
        /// </summary>
        /// <param name="req"><see cref="UpdatePrometheusAlertGroupStateRequest"/></param>
        /// <returns><see cref="UpdatePrometheusAlertGroupStateResponse"/></returns>
        public UpdatePrometheusAlertGroupStateResponse UpdatePrometheusAlertGroupStateSync(UpdatePrometheusAlertGroupStateRequest req)
        {
            return InternalRequestAsync<UpdatePrometheusAlertGroupStateResponse>(req, "UpdatePrometheusAlertGroupState")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新 Prometheus Agent 抓取任务
        /// </summary>
        /// <param name="req"><see cref="UpdatePrometheusScrapeJobRequest"/></param>
        /// <returns><see cref="UpdatePrometheusScrapeJobResponse"/></returns>
        public Task<UpdatePrometheusScrapeJobResponse> UpdatePrometheusScrapeJob(UpdatePrometheusScrapeJobRequest req)
        {
            return InternalRequestAsync<UpdatePrometheusScrapeJobResponse>(req, "UpdatePrometheusScrapeJob");
        }

        /// <summary>
        /// 更新 Prometheus Agent 抓取任务
        /// </summary>
        /// <param name="req"><see cref="UpdatePrometheusScrapeJobRequest"/></param>
        /// <returns><see cref="UpdatePrometheusScrapeJobResponse"/></returns>
        public UpdatePrometheusScrapeJobResponse UpdatePrometheusScrapeJobSync(UpdatePrometheusScrapeJobRequest req)
        {
            return InternalRequestAsync<UpdatePrometheusScrapeJobResponse>(req, "UpdatePrometheusScrapeJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新 Prometheus 的预聚合规则
        /// </summary>
        /// <param name="req"><see cref="UpdateRecordingRuleRequest"/></param>
        /// <returns><see cref="UpdateRecordingRuleResponse"/></returns>
        public Task<UpdateRecordingRuleResponse> UpdateRecordingRule(UpdateRecordingRuleRequest req)
        {
            return InternalRequestAsync<UpdateRecordingRuleResponse>(req, "UpdateRecordingRule");
        }

        /// <summary>
        /// 更新 Prometheus 的预聚合规则
        /// </summary>
        /// <param name="req"><see cref="UpdateRecordingRuleRequest"/></param>
        /// <returns><see cref="UpdateRecordingRuleResponse"/></returns>
        public UpdateRecordingRuleResponse UpdateRecordingRuleSync(UpdateRecordingRuleRequest req)
        {
            return InternalRequestAsync<UpdateRecordingRuleResponse>(req, "UpdateRecordingRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新已授权账号的备注、权限信息，会直接覆盖原有的信息，不传则不会更新。
        /// </summary>
        /// <param name="req"><see cref="UpdateSSOAccountRequest"/></param>
        /// <returns><see cref="UpdateSSOAccountResponse"/></returns>
        public Task<UpdateSSOAccountResponse> UpdateSSOAccount(UpdateSSOAccountRequest req)
        {
            return InternalRequestAsync<UpdateSSOAccountResponse>(req, "UpdateSSOAccount");
        }

        /// <summary>
        /// 更新已授权账号的备注、权限信息，会直接覆盖原有的信息，不传则不会更新。
        /// </summary>
        /// <param name="req"><see cref="UpdateSSOAccountRequest"/></param>
        /// <returns><see cref="UpdateSSOAccountResponse"/></returns>
        public UpdateSSOAccountResponse UpdateSSOAccountSync(UpdateSSOAccountRequest req)
        {
            return InternalRequestAsync<UpdateSSOAccountResponse>(req, "UpdateSSOAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在腾讯云容器服务下更新 Prometheus 服务发现。
        /// <p>注意：前提条件，已经通过 Prometheus 控制台集成了对应的腾讯云容器服务，具体请参考
        /// <a href="https://cloud.tencent.com/document/product/248/48859" target="_blank">Agent 安装</a>。</p>
        /// </summary>
        /// <param name="req"><see cref="UpdateServiceDiscoveryRequest"/></param>
        /// <returns><see cref="UpdateServiceDiscoveryResponse"/></returns>
        public Task<UpdateServiceDiscoveryResponse> UpdateServiceDiscovery(UpdateServiceDiscoveryRequest req)
        {
            return InternalRequestAsync<UpdateServiceDiscoveryResponse>(req, "UpdateServiceDiscovery");
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
            return InternalRequestAsync<UpdateServiceDiscoveryResponse>(req, "UpdateServiceDiscovery")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 升级 Grafana Dashboard
        /// </summary>
        /// <param name="req"><see cref="UpgradeGrafanaDashboardRequest"/></param>
        /// <returns><see cref="UpgradeGrafanaDashboardResponse"/></returns>
        public Task<UpgradeGrafanaDashboardResponse> UpgradeGrafanaDashboard(UpgradeGrafanaDashboardRequest req)
        {
            return InternalRequestAsync<UpgradeGrafanaDashboardResponse>(req, "UpgradeGrafanaDashboard");
        }

        /// <summary>
        /// 升级 Grafana Dashboard
        /// </summary>
        /// <param name="req"><see cref="UpgradeGrafanaDashboardRequest"/></param>
        /// <returns><see cref="UpgradeGrafanaDashboardResponse"/></returns>
        public UpgradeGrafanaDashboardResponse UpgradeGrafanaDashboardSync(UpgradeGrafanaDashboardRequest req)
        {
            return InternalRequestAsync<UpgradeGrafanaDashboardResponse>(req, "UpgradeGrafanaDashboard")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 升级 Grafana 实例
        /// </summary>
        /// <param name="req"><see cref="UpgradeGrafanaInstanceRequest"/></param>
        /// <returns><see cref="UpgradeGrafanaInstanceResponse"/></returns>
        public Task<UpgradeGrafanaInstanceResponse> UpgradeGrafanaInstance(UpgradeGrafanaInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeGrafanaInstanceResponse>(req, "UpgradeGrafanaInstance");
        }

        /// <summary>
        /// 升级 Grafana 实例
        /// </summary>
        /// <param name="req"><see cref="UpgradeGrafanaInstanceRequest"/></param>
        /// <returns><see cref="UpgradeGrafanaInstanceResponse"/></returns>
        public UpgradeGrafanaInstanceResponse UpgradeGrafanaInstanceSync(UpgradeGrafanaInstanceRequest req)
        {
            return InternalRequestAsync<UpgradeGrafanaInstanceResponse>(req, "UpgradeGrafanaInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}

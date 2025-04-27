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

namespace TencentCloud.Dayu.V20180709
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Dayu.V20180709.Models;

   public class DayuClient : AbstractClient{

       private const string endpoint = "dayu.tencentcloudapi.com";
       private const string version = "2018-07-09";
       private const string sdkVersion = "SDK_NET_3.0.1229";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DayuClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public DayuClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 设置基础防护的DDoS告警阈值，只支持基础防护产品
        /// </summary>
        /// <param name="req"><see cref="CreateBasicDDoSAlarmThresholdRequest"/></param>
        /// <returns><see cref="CreateBasicDDoSAlarmThresholdResponse"/></returns>
        public Task<CreateBasicDDoSAlarmThresholdResponse> CreateBasicDDoSAlarmThreshold(CreateBasicDDoSAlarmThresholdRequest req)
        {
            return InternalRequestAsync<CreateBasicDDoSAlarmThresholdResponse>(req, "CreateBasicDDoSAlarmThreshold");
        }

        /// <summary>
        /// 设置基础防护的DDoS告警阈值，只支持基础防护产品
        /// </summary>
        /// <param name="req"><see cref="CreateBasicDDoSAlarmThresholdRequest"/></param>
        /// <returns><see cref="CreateBasicDDoSAlarmThresholdResponse"/></returns>
        public CreateBasicDDoSAlarmThresholdResponse CreateBasicDDoSAlarmThresholdSync(CreateBasicDDoSAlarmThresholdRequest req)
        {
            return InternalRequestAsync<CreateBasicDDoSAlarmThresholdResponse>(req, "CreateBasicDDoSAlarmThreshold")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 绑定IP到高防包实例，支持独享包、共享包；需要注意的是此接口绑定或解绑IP是异步接口，当处于绑定或解绑中时，则不允许再进行绑定或解绑，需要等待当前绑定或解绑完成。
        /// </summary>
        /// <param name="req"><see cref="CreateBoundIPRequest"/></param>
        /// <returns><see cref="CreateBoundIPResponse"/></returns>
        public Task<CreateBoundIPResponse> CreateBoundIP(CreateBoundIPRequest req)
        {
            return InternalRequestAsync<CreateBoundIPResponse>(req, "CreateBoundIP");
        }

        /// <summary>
        /// 绑定IP到高防包实例，支持独享包、共享包；需要注意的是此接口绑定或解绑IP是异步接口，当处于绑定或解绑中时，则不允许再进行绑定或解绑，需要等待当前绑定或解绑完成。
        /// </summary>
        /// <param name="req"><see cref="CreateBoundIPRequest"/></param>
        /// <returns><see cref="CreateBoundIPResponse"/></returns>
        public CreateBoundIPResponse CreateBoundIPSync(CreateBoundIPRequest req)
        {
            return InternalRequestAsync<CreateBoundIPResponse>(req, "CreateBoundIP")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加CC防护的访问频率控制规则
        /// </summary>
        /// <param name="req"><see cref="CreateCCFrequencyRulesRequest"/></param>
        /// <returns><see cref="CreateCCFrequencyRulesResponse"/></returns>
        public Task<CreateCCFrequencyRulesResponse> CreateCCFrequencyRules(CreateCCFrequencyRulesRequest req)
        {
            return InternalRequestAsync<CreateCCFrequencyRulesResponse>(req, "CreateCCFrequencyRules");
        }

        /// <summary>
        /// 添加CC防护的访问频率控制规则
        /// </summary>
        /// <param name="req"><see cref="CreateCCFrequencyRulesRequest"/></param>
        /// <returns><see cref="CreateCCFrequencyRulesResponse"/></returns>
        public CreateCCFrequencyRulesResponse CreateCCFrequencyRulesSync(CreateCCFrequencyRulesRequest req)
        {
            return InternalRequestAsync<CreateCCFrequencyRulesResponse>(req, "CreateCCFrequencyRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建CC自定义策略
        /// </summary>
        /// <param name="req"><see cref="CreateCCSelfDefinePolicyRequest"/></param>
        /// <returns><see cref="CreateCCSelfDefinePolicyResponse"/></returns>
        public Task<CreateCCSelfDefinePolicyResponse> CreateCCSelfDefinePolicy(CreateCCSelfDefinePolicyRequest req)
        {
            return InternalRequestAsync<CreateCCSelfDefinePolicyResponse>(req, "CreateCCSelfDefinePolicy");
        }

        /// <summary>
        /// 创建CC自定义策略
        /// </summary>
        /// <param name="req"><see cref="CreateCCSelfDefinePolicyRequest"/></param>
        /// <returns><see cref="CreateCCSelfDefinePolicyResponse"/></returns>
        public CreateCCSelfDefinePolicyResponse CreateCCSelfDefinePolicySync(CreateCCSelfDefinePolicyRequest req)
        {
            return InternalRequestAsync<CreateCCSelfDefinePolicyResponse>(req, "CreateCCSelfDefinePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加DDoS高级策略
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSPolicyRequest"/></param>
        /// <returns><see cref="CreateDDoSPolicyResponse"/></returns>
        public Task<CreateDDoSPolicyResponse> CreateDDoSPolicy(CreateDDoSPolicyRequest req)
        {
            return InternalRequestAsync<CreateDDoSPolicyResponse>(req, "CreateDDoSPolicy");
        }

        /// <summary>
        /// 添加DDoS高级策略
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSPolicyRequest"/></param>
        /// <returns><see cref="CreateDDoSPolicyResponse"/></returns>
        public CreateDDoSPolicyResponse CreateDDoSPolicySync(CreateDDoSPolicyRequest req)
        {
            return InternalRequestAsync<CreateDDoSPolicyResponse>(req, "CreateDDoSPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加策略场景
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSPolicyCaseRequest"/></param>
        /// <returns><see cref="CreateDDoSPolicyCaseResponse"/></returns>
        public Task<CreateDDoSPolicyCaseResponse> CreateDDoSPolicyCase(CreateDDoSPolicyCaseRequest req)
        {
            return InternalRequestAsync<CreateDDoSPolicyCaseResponse>(req, "CreateDDoSPolicyCase");
        }

        /// <summary>
        /// 添加策略场景
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSPolicyCaseRequest"/></param>
        /// <returns><see cref="CreateDDoSPolicyCaseResponse"/></returns>
        public CreateDDoSPolicyCaseResponse CreateDDoSPolicyCaseSync(CreateDDoSPolicyCaseRequest req)
        {
            return InternalRequestAsync<CreateDDoSPolicyCaseResponse>(req, "CreateDDoSPolicyCase")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 资源实例重命名，支持独享包、共享包、高防IP、高防IP专业版；
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceNameRequest"/></param>
        /// <returns><see cref="CreateInstanceNameResponse"/></returns>
        public Task<CreateInstanceNameResponse> CreateInstanceName(CreateInstanceNameRequest req)
        {
            return InternalRequestAsync<CreateInstanceNameResponse>(req, "CreateInstanceName");
        }

        /// <summary>
        /// 资源实例重命名，支持独享包、共享包、高防IP、高防IP专业版；
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceNameRequest"/></param>
        /// <returns><see cref="CreateInstanceNameResponse"/></returns>
        public CreateInstanceNameResponse CreateInstanceNameSync(CreateInstanceNameRequest req)
        {
            return InternalRequestAsync<CreateInstanceNameResponse>(req, "CreateInstanceName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 上传四层健康检查配置
        /// </summary>
        /// <param name="req"><see cref="CreateL4HealthConfigRequest"/></param>
        /// <returns><see cref="CreateL4HealthConfigResponse"/></returns>
        public Task<CreateL4HealthConfigResponse> CreateL4HealthConfig(CreateL4HealthConfigRequest req)
        {
            return InternalRequestAsync<CreateL4HealthConfigResponse>(req, "CreateL4HealthConfig");
        }

        /// <summary>
        /// 上传四层健康检查配置
        /// </summary>
        /// <param name="req"><see cref="CreateL4HealthConfigRequest"/></param>
        /// <returns><see cref="CreateL4HealthConfigResponse"/></returns>
        public CreateL4HealthConfigResponse CreateL4HealthConfigSync(CreateL4HealthConfigRequest req)
        {
            return InternalRequestAsync<CreateL4HealthConfigResponse>(req, "CreateL4HealthConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加L4转发规则
        /// </summary>
        /// <param name="req"><see cref="CreateL4RulesRequest"/></param>
        /// <returns><see cref="CreateL4RulesResponse"/></returns>
        public Task<CreateL4RulesResponse> CreateL4Rules(CreateL4RulesRequest req)
        {
            return InternalRequestAsync<CreateL4RulesResponse>(req, "CreateL4Rules");
        }

        /// <summary>
        /// 添加L4转发规则
        /// </summary>
        /// <param name="req"><see cref="CreateL4RulesRequest"/></param>
        /// <returns><see cref="CreateL4RulesResponse"/></returns>
        public CreateL4RulesResponse CreateL4RulesSync(CreateL4RulesRequest req)
        {
            return InternalRequestAsync<CreateL4RulesResponse>(req, "CreateL4Rules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 此接口是7层CC的访问频控自定义规则（IP+Host维度，不支持具体的URI），此接口已弃用，请调用新接口CreateCCFrequencyRules，新接口同时支持IP+Host维度以及具体的URI；
        /// </summary>
        /// <param name="req"><see cref="CreateL7CCRuleRequest"/></param>
        /// <returns><see cref="CreateL7CCRuleResponse"/></returns>
        public Task<CreateL7CCRuleResponse> CreateL7CCRule(CreateL7CCRuleRequest req)
        {
            return InternalRequestAsync<CreateL7CCRuleResponse>(req, "CreateL7CCRule");
        }

        /// <summary>
        /// 此接口是7层CC的访问频控自定义规则（IP+Host维度，不支持具体的URI），此接口已弃用，请调用新接口CreateCCFrequencyRules，新接口同时支持IP+Host维度以及具体的URI；
        /// </summary>
        /// <param name="req"><see cref="CreateL7CCRuleRequest"/></param>
        /// <returns><see cref="CreateL7CCRuleResponse"/></returns>
        public CreateL7CCRuleResponse CreateL7CCRuleSync(CreateL7CCRuleRequest req)
        {
            return InternalRequestAsync<CreateL7CCRuleResponse>(req, "CreateL7CCRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 上传七层健康检查配置
        /// </summary>
        /// <param name="req"><see cref="CreateL7HealthConfigRequest"/></param>
        /// <returns><see cref="CreateL7HealthConfigResponse"/></returns>
        public Task<CreateL7HealthConfigResponse> CreateL7HealthConfig(CreateL7HealthConfigRequest req)
        {
            return InternalRequestAsync<CreateL7HealthConfigResponse>(req, "CreateL7HealthConfig");
        }

        /// <summary>
        /// 上传七层健康检查配置
        /// </summary>
        /// <param name="req"><see cref="CreateL7HealthConfigRequest"/></param>
        /// <returns><see cref="CreateL7HealthConfigResponse"/></returns>
        public CreateL7HealthConfigResponse CreateL7HealthConfigSync(CreateL7HealthConfigRequest req)
        {
            return InternalRequestAsync<CreateL7HealthConfigResponse>(req, "CreateL7HealthConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 配置7层转发规则的证书
        /// </summary>
        /// <param name="req"><see cref="CreateL7RuleCertRequest"/></param>
        /// <returns><see cref="CreateL7RuleCertResponse"/></returns>
        public Task<CreateL7RuleCertResponse> CreateL7RuleCert(CreateL7RuleCertRequest req)
        {
            return InternalRequestAsync<CreateL7RuleCertResponse>(req, "CreateL7RuleCert");
        }

        /// <summary>
        /// 配置7层转发规则的证书
        /// </summary>
        /// <param name="req"><see cref="CreateL7RuleCertRequest"/></param>
        /// <returns><see cref="CreateL7RuleCertResponse"/></returns>
        public CreateL7RuleCertResponse CreateL7RuleCertSync(CreateL7RuleCertRequest req)
        {
            return InternalRequestAsync<CreateL7RuleCertResponse>(req, "CreateL7RuleCert")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加7层(网站)转发规则
        /// </summary>
        /// <param name="req"><see cref="CreateL7RulesRequest"/></param>
        /// <returns><see cref="CreateL7RulesResponse"/></returns>
        public Task<CreateL7RulesResponse> CreateL7Rules(CreateL7RulesRequest req)
        {
            return InternalRequestAsync<CreateL7RulesResponse>(req, "CreateL7Rules");
        }

        /// <summary>
        /// 添加7层(网站)转发规则
        /// </summary>
        /// <param name="req"><see cref="CreateL7RulesRequest"/></param>
        /// <returns><see cref="CreateL7RulesResponse"/></returns>
        public CreateL7RulesResponse CreateL7RulesSync(CreateL7RulesRequest req)
        {
            return InternalRequestAsync<CreateL7RulesResponse>(req, "CreateL7Rules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量上传7层转发规则
        /// </summary>
        /// <param name="req"><see cref="CreateL7RulesUploadRequest"/></param>
        /// <returns><see cref="CreateL7RulesUploadResponse"/></returns>
        public Task<CreateL7RulesUploadResponse> CreateL7RulesUpload(CreateL7RulesUploadRequest req)
        {
            return InternalRequestAsync<CreateL7RulesUploadResponse>(req, "CreateL7RulesUpload");
        }

        /// <summary>
        /// 批量上传7层转发规则
        /// </summary>
        /// <param name="req"><see cref="CreateL7RulesUploadRequest"/></param>
        /// <returns><see cref="CreateL7RulesUploadResponse"/></returns>
        public CreateL7RulesUploadResponse CreateL7RulesUploadSync(CreateL7RulesUploadRequest req)
        {
            return InternalRequestAsync<CreateL7RulesUploadResponse>(req, "CreateL7RulesUpload")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 高防IP专业版一键切回源站
        /// </summary>
        /// <param name="req"><see cref="CreateNetReturnRequest"/></param>
        /// <returns><see cref="CreateNetReturnResponse"/></returns>
        public Task<CreateNetReturnResponse> CreateNetReturn(CreateNetReturnRequest req)
        {
            return InternalRequestAsync<CreateNetReturnResponse>(req, "CreateNetReturn");
        }

        /// <summary>
        /// 高防IP专业版一键切回源站
        /// </summary>
        /// <param name="req"><see cref="CreateNetReturnRequest"/></param>
        /// <returns><see cref="CreateNetReturnResponse"/></returns>
        public CreateNetReturnResponse CreateNetReturnSync(CreateNetReturnRequest req)
        {
            return InternalRequestAsync<CreateNetReturnResponse>(req, "CreateNetReturn")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加L4转发规则
        /// </summary>
        /// <param name="req"><see cref="CreateNewL4RulesRequest"/></param>
        /// <returns><see cref="CreateNewL4RulesResponse"/></returns>
        public Task<CreateNewL4RulesResponse> CreateNewL4Rules(CreateNewL4RulesRequest req)
        {
            return InternalRequestAsync<CreateNewL4RulesResponse>(req, "CreateNewL4Rules");
        }

        /// <summary>
        /// 添加L4转发规则
        /// </summary>
        /// <param name="req"><see cref="CreateNewL4RulesRequest"/></param>
        /// <returns><see cref="CreateNewL4RulesResponse"/></returns>
        public CreateNewL4RulesResponse CreateNewL4RulesSync(CreateNewL4RulesRequest req)
        {
            return InternalRequestAsync<CreateNewL4RulesResponse>(req, "CreateNewL4Rules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加7层转发规则
        /// </summary>
        /// <param name="req"><see cref="CreateNewL7RulesRequest"/></param>
        /// <returns><see cref="CreateNewL7RulesResponse"/></returns>
        public Task<CreateNewL7RulesResponse> CreateNewL7Rules(CreateNewL7RulesRequest req)
        {
            return InternalRequestAsync<CreateNewL7RulesResponse>(req, "CreateNewL7Rules");
        }

        /// <summary>
        /// 添加7层转发规则
        /// </summary>
        /// <param name="req"><see cref="CreateNewL7RulesRequest"/></param>
        /// <returns><see cref="CreateNewL7RulesResponse"/></returns>
        public CreateNewL7RulesResponse CreateNewL7RulesSync(CreateNewL7RulesRequest req)
        {
            return InternalRequestAsync<CreateNewL7RulesResponse>(req, "CreateNewL7Rules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量上传7层转发规则
        /// </summary>
        /// <param name="req"><see cref="CreateNewL7RulesUploadRequest"/></param>
        /// <returns><see cref="CreateNewL7RulesUploadResponse"/></returns>
        public Task<CreateNewL7RulesUploadResponse> CreateNewL7RulesUpload(CreateNewL7RulesUploadRequest req)
        {
            return InternalRequestAsync<CreateNewL7RulesUploadResponse>(req, "CreateNewL7RulesUpload");
        }

        /// <summary>
        /// 批量上传7层转发规则
        /// </summary>
        /// <param name="req"><see cref="CreateNewL7RulesUploadRequest"/></param>
        /// <returns><see cref="CreateNewL7RulesUploadResponse"/></returns>
        public CreateNewL7RulesUploadResponse CreateNewL7RulesUploadSync(CreateNewL7RulesUploadRequest req)
        {
            return InternalRequestAsync<CreateNewL7RulesUploadResponse>(req, "CreateNewL7RulesUpload")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// IP解封操作
        /// </summary>
        /// <param name="req"><see cref="CreateUnblockIpRequest"/></param>
        /// <returns><see cref="CreateUnblockIpResponse"/></returns>
        public Task<CreateUnblockIpResponse> CreateUnblockIp(CreateUnblockIpRequest req)
        {
            return InternalRequestAsync<CreateUnblockIpResponse>(req, "CreateUnblockIp");
        }

        /// <summary>
        /// IP解封操作
        /// </summary>
        /// <param name="req"><see cref="CreateUnblockIpRequest"/></param>
        /// <returns><see cref="CreateUnblockIpResponse"/></returns>
        public CreateUnblockIpResponse CreateUnblockIpSync(CreateUnblockIpRequest req)
        {
            return InternalRequestAsync<CreateUnblockIpResponse>(req, "CreateUnblockIp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除CC防护的访问频率控制规则
        /// </summary>
        /// <param name="req"><see cref="DeleteCCFrequencyRulesRequest"/></param>
        /// <returns><see cref="DeleteCCFrequencyRulesResponse"/></returns>
        public Task<DeleteCCFrequencyRulesResponse> DeleteCCFrequencyRules(DeleteCCFrequencyRulesRequest req)
        {
            return InternalRequestAsync<DeleteCCFrequencyRulesResponse>(req, "DeleteCCFrequencyRules");
        }

        /// <summary>
        /// 删除CC防护的访问频率控制规则
        /// </summary>
        /// <param name="req"><see cref="DeleteCCFrequencyRulesRequest"/></param>
        /// <returns><see cref="DeleteCCFrequencyRulesResponse"/></returns>
        public DeleteCCFrequencyRulesResponse DeleteCCFrequencyRulesSync(DeleteCCFrequencyRulesRequest req)
        {
            return InternalRequestAsync<DeleteCCFrequencyRulesResponse>(req, "DeleteCCFrequencyRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除CC自定义策略
        /// </summary>
        /// <param name="req"><see cref="DeleteCCSelfDefinePolicyRequest"/></param>
        /// <returns><see cref="DeleteCCSelfDefinePolicyResponse"/></returns>
        public Task<DeleteCCSelfDefinePolicyResponse> DeleteCCSelfDefinePolicy(DeleteCCSelfDefinePolicyRequest req)
        {
            return InternalRequestAsync<DeleteCCSelfDefinePolicyResponse>(req, "DeleteCCSelfDefinePolicy");
        }

        /// <summary>
        /// 删除CC自定义策略
        /// </summary>
        /// <param name="req"><see cref="DeleteCCSelfDefinePolicyRequest"/></param>
        /// <returns><see cref="DeleteCCSelfDefinePolicyResponse"/></returns>
        public DeleteCCSelfDefinePolicyResponse DeleteCCSelfDefinePolicySync(DeleteCCSelfDefinePolicyRequest req)
        {
            return InternalRequestAsync<DeleteCCSelfDefinePolicyResponse>(req, "DeleteCCSelfDefinePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除DDoS高级策略
        /// </summary>
        /// <param name="req"><see cref="DeleteDDoSPolicyRequest"/></param>
        /// <returns><see cref="DeleteDDoSPolicyResponse"/></returns>
        public Task<DeleteDDoSPolicyResponse> DeleteDDoSPolicy(DeleteDDoSPolicyRequest req)
        {
            return InternalRequestAsync<DeleteDDoSPolicyResponse>(req, "DeleteDDoSPolicy");
        }

        /// <summary>
        /// 删除DDoS高级策略
        /// </summary>
        /// <param name="req"><see cref="DeleteDDoSPolicyRequest"/></param>
        /// <returns><see cref="DeleteDDoSPolicyResponse"/></returns>
        public DeleteDDoSPolicyResponse DeleteDDoSPolicySync(DeleteDDoSPolicyRequest req)
        {
            return InternalRequestAsync<DeleteDDoSPolicyResponse>(req, "DeleteDDoSPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除策略场景
        /// </summary>
        /// <param name="req"><see cref="DeleteDDoSPolicyCaseRequest"/></param>
        /// <returns><see cref="DeleteDDoSPolicyCaseResponse"/></returns>
        public Task<DeleteDDoSPolicyCaseResponse> DeleteDDoSPolicyCase(DeleteDDoSPolicyCaseRequest req)
        {
            return InternalRequestAsync<DeleteDDoSPolicyCaseResponse>(req, "DeleteDDoSPolicyCase");
        }

        /// <summary>
        /// 删除策略场景
        /// </summary>
        /// <param name="req"><see cref="DeleteDDoSPolicyCaseRequest"/></param>
        /// <returns><see cref="DeleteDDoSPolicyCaseResponse"/></returns>
        public DeleteDDoSPolicyCaseResponse DeleteDDoSPolicyCaseSync(DeleteDDoSPolicyCaseRequest req)
        {
            return InternalRequestAsync<DeleteDDoSPolicyCaseResponse>(req, "DeleteDDoSPolicyCase")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除四层转发规则
        /// </summary>
        /// <param name="req"><see cref="DeleteL4RulesRequest"/></param>
        /// <returns><see cref="DeleteL4RulesResponse"/></returns>
        public Task<DeleteL4RulesResponse> DeleteL4Rules(DeleteL4RulesRequest req)
        {
            return InternalRequestAsync<DeleteL4RulesResponse>(req, "DeleteL4Rules");
        }

        /// <summary>
        /// 删除四层转发规则
        /// </summary>
        /// <param name="req"><see cref="DeleteL4RulesRequest"/></param>
        /// <returns><see cref="DeleteL4RulesResponse"/></returns>
        public DeleteL4RulesResponse DeleteL4RulesSync(DeleteL4RulesRequest req)
        {
            return InternalRequestAsync<DeleteL4RulesResponse>(req, "DeleteL4Rules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除七层转发规则
        /// </summary>
        /// <param name="req"><see cref="DeleteL7RulesRequest"/></param>
        /// <returns><see cref="DeleteL7RulesResponse"/></returns>
        public Task<DeleteL7RulesResponse> DeleteL7Rules(DeleteL7RulesRequest req)
        {
            return InternalRequestAsync<DeleteL7RulesResponse>(req, "DeleteL7Rules");
        }

        /// <summary>
        /// 删除七层转发规则
        /// </summary>
        /// <param name="req"><see cref="DeleteL7RulesRequest"/></param>
        /// <returns><see cref="DeleteL7RulesResponse"/></returns>
        public DeleteL7RulesResponse DeleteL7RulesSync(DeleteL7RulesRequest req)
        {
            return InternalRequestAsync<DeleteL7RulesResponse>(req, "DeleteL7Rules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除L4转发规则
        /// </summary>
        /// <param name="req"><see cref="DeleteNewL4RulesRequest"/></param>
        /// <returns><see cref="DeleteNewL4RulesResponse"/></returns>
        public Task<DeleteNewL4RulesResponse> DeleteNewL4Rules(DeleteNewL4RulesRequest req)
        {
            return InternalRequestAsync<DeleteNewL4RulesResponse>(req, "DeleteNewL4Rules");
        }

        /// <summary>
        /// 删除L4转发规则
        /// </summary>
        /// <param name="req"><see cref="DeleteNewL4RulesRequest"/></param>
        /// <returns><see cref="DeleteNewL4RulesResponse"/></returns>
        public DeleteNewL4RulesResponse DeleteNewL4RulesSync(DeleteNewL4RulesRequest req)
        {
            return InternalRequestAsync<DeleteNewL4RulesResponse>(req, "DeleteNewL4Rules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除L7转发规则
        /// </summary>
        /// <param name="req"><see cref="DeleteNewL7RulesRequest"/></param>
        /// <returns><see cref="DeleteNewL7RulesResponse"/></returns>
        public Task<DeleteNewL7RulesResponse> DeleteNewL7Rules(DeleteNewL7RulesRequest req)
        {
            return InternalRequestAsync<DeleteNewL7RulesResponse>(req, "DeleteNewL7Rules");
        }

        /// <summary>
        /// 删除L7转发规则
        /// </summary>
        /// <param name="req"><see cref="DeleteNewL7RulesRequest"/></param>
        /// <returns><see cref="DeleteNewL7RulesResponse"/></returns>
        public DeleteNewL7RulesResponse DeleteNewL7RulesSync(DeleteNewL7RulesRequest req)
        {
            return InternalRequestAsync<DeleteNewL7RulesResponse>(req, "DeleteNewL7Rules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取操作日志
        /// </summary>
        /// <param name="req"><see cref="DescribeActionLogRequest"/></param>
        /// <returns><see cref="DescribeActionLogResponse"/></returns>
        public Task<DescribeActionLogResponse> DescribeActionLog(DescribeActionLogRequest req)
        {
            return InternalRequestAsync<DescribeActionLogResponse>(req, "DescribeActionLog");
        }

        /// <summary>
        /// 获取操作日志
        /// </summary>
        /// <param name="req"><see cref="DescribeActionLogRequest"/></param>
        /// <returns><see cref="DescribeActionLogResponse"/></returns>
        public DescribeActionLogResponse DescribeActionLogSync(DescribeActionLogRequest req)
        {
            return InternalRequestAsync<DescribeActionLogResponse>(req, "DescribeActionLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取高防IP可添加的最多7层规则数量
        /// </summary>
        /// <param name="req"><see cref="DescribeBGPIPL7RuleMaxCntRequest"/></param>
        /// <returns><see cref="DescribeBGPIPL7RuleMaxCntResponse"/></returns>
        public Task<DescribeBGPIPL7RuleMaxCntResponse> DescribeBGPIPL7RuleMaxCnt(DescribeBGPIPL7RuleMaxCntRequest req)
        {
            return InternalRequestAsync<DescribeBGPIPL7RuleMaxCntResponse>(req, "DescribeBGPIPL7RuleMaxCnt");
        }

        /// <summary>
        /// 获取高防IP可添加的最多7层规则数量
        /// </summary>
        /// <param name="req"><see cref="DescribeBGPIPL7RuleMaxCntRequest"/></param>
        /// <returns><see cref="DescribeBGPIPL7RuleMaxCntResponse"/></returns>
        public DescribeBGPIPL7RuleMaxCntResponse DescribeBGPIPL7RuleMaxCntSync(DescribeBGPIPL7RuleMaxCntRequest req)
        {
            return InternalRequestAsync<DescribeBGPIPL7RuleMaxCntResponse>(req, "DescribeBGPIPL7RuleMaxCnt")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 为大禹子产品提供业务转发指标数据的接口
        /// </summary>
        /// <param name="req"><see cref="DescribeBaradDataRequest"/></param>
        /// <returns><see cref="DescribeBaradDataResponse"/></returns>
        public Task<DescribeBaradDataResponse> DescribeBaradData(DescribeBaradDataRequest req)
        {
            return InternalRequestAsync<DescribeBaradDataResponse>(req, "DescribeBaradData");
        }

        /// <summary>
        /// 为大禹子产品提供业务转发指标数据的接口
        /// </summary>
        /// <param name="req"><see cref="DescribeBaradDataRequest"/></param>
        /// <returns><see cref="DescribeBaradDataResponse"/></returns>
        public DescribeBaradDataResponse DescribeBaradDataSync(DescribeBaradDataRequest req)
        {
            return InternalRequestAsync<DescribeBaradDataResponse>(req, "DescribeBaradData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取基础防护CC防护阈值
        /// </summary>
        /// <param name="req"><see cref="DescribeBasicCCThresholdRequest"/></param>
        /// <returns><see cref="DescribeBasicCCThresholdResponse"/></returns>
        public Task<DescribeBasicCCThresholdResponse> DescribeBasicCCThreshold(DescribeBasicCCThresholdRequest req)
        {
            return InternalRequestAsync<DescribeBasicCCThresholdResponse>(req, "DescribeBasicCCThreshold");
        }

        /// <summary>
        /// 获取基础防护CC防护阈值
        /// </summary>
        /// <param name="req"><see cref="DescribeBasicCCThresholdRequest"/></param>
        /// <returns><see cref="DescribeBasicCCThresholdResponse"/></returns>
        public DescribeBasicCCThresholdResponse DescribeBasicCCThresholdSync(DescribeBasicCCThresholdRequest req)
        {
            return InternalRequestAsync<DescribeBasicCCThresholdResponse>(req, "DescribeBasicCCThreshold")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取基础防护黑洞阈值
        /// </summary>
        /// <param name="req"><see cref="DescribeBasicDeviceThresholdRequest"/></param>
        /// <returns><see cref="DescribeBasicDeviceThresholdResponse"/></returns>
        public Task<DescribeBasicDeviceThresholdResponse> DescribeBasicDeviceThreshold(DescribeBasicDeviceThresholdRequest req)
        {
            return InternalRequestAsync<DescribeBasicDeviceThresholdResponse>(req, "DescribeBasicDeviceThreshold");
        }

        /// <summary>
        /// 获取基础防护黑洞阈值
        /// </summary>
        /// <param name="req"><see cref="DescribeBasicDeviceThresholdRequest"/></param>
        /// <returns><see cref="DescribeBasicDeviceThresholdResponse"/></returns>
        public DescribeBasicDeviceThresholdResponse DescribeBasicDeviceThresholdSync(DescribeBasicDeviceThresholdRequest req)
        {
            return InternalRequestAsync<DescribeBasicDeviceThresholdResponse>(req, "DescribeBasicDeviceThreshold")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取业务流量状态码统计
        /// </summary>
        /// <param name="req"><see cref="DescribeBizHttpStatusRequest"/></param>
        /// <returns><see cref="DescribeBizHttpStatusResponse"/></returns>
        public Task<DescribeBizHttpStatusResponse> DescribeBizHttpStatus(DescribeBizHttpStatusRequest req)
        {
            return InternalRequestAsync<DescribeBizHttpStatusResponse>(req, "DescribeBizHttpStatus");
        }

        /// <summary>
        /// 获取业务流量状态码统计
        /// </summary>
        /// <param name="req"><see cref="DescribeBizHttpStatusRequest"/></param>
        /// <returns><see cref="DescribeBizHttpStatusResponse"/></returns>
        public DescribeBizHttpStatusResponse DescribeBizHttpStatusSync(DescribeBizHttpStatusRequest req)
        {
            return InternalRequestAsync<DescribeBizHttpStatusResponse>(req, "DescribeBizHttpStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取业务流量曲线
        /// </summary>
        /// <param name="req"><see cref="DescribeBizTrendRequest"/></param>
        /// <returns><see cref="DescribeBizTrendResponse"/></returns>
        public Task<DescribeBizTrendResponse> DescribeBizTrend(DescribeBizTrendRequest req)
        {
            return InternalRequestAsync<DescribeBizTrendResponse>(req, "DescribeBizTrend");
        }

        /// <summary>
        /// 获取业务流量曲线
        /// </summary>
        /// <param name="req"><see cref="DescribeBizTrendRequest"/></param>
        /// <returns><see cref="DescribeBizTrendResponse"/></returns>
        public DescribeBizTrendResponse DescribeBizTrendSync(DescribeBizTrendRequest req)
        {
            return InternalRequestAsync<DescribeBizTrendResponse>(req, "DescribeBizTrend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取高防包、高防IP、高防IP专业版、棋牌盾产品设置CC攻击的告警通知阈值
        /// </summary>
        /// <param name="req"><see cref="DescribeCCAlarmThresholdRequest"/></param>
        /// <returns><see cref="DescribeCCAlarmThresholdResponse"/></returns>
        public Task<DescribeCCAlarmThresholdResponse> DescribeCCAlarmThreshold(DescribeCCAlarmThresholdRequest req)
        {
            return InternalRequestAsync<DescribeCCAlarmThresholdResponse>(req, "DescribeCCAlarmThreshold");
        }

        /// <summary>
        /// 获取高防包、高防IP、高防IP专业版、棋牌盾产品设置CC攻击的告警通知阈值
        /// </summary>
        /// <param name="req"><see cref="DescribeCCAlarmThresholdRequest"/></param>
        /// <returns><see cref="DescribeCCAlarmThresholdResponse"/></returns>
        public DescribeCCAlarmThresholdResponse DescribeCCAlarmThresholdSync(DescribeCCAlarmThresholdRequest req)
        {
            return InternalRequestAsync<DescribeCCAlarmThresholdResponse>(req, "DescribeCCAlarmThreshold")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取CC攻击事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCCEvListRequest"/></param>
        /// <returns><see cref="DescribeCCEvListResponse"/></returns>
        public Task<DescribeCCEvListResponse> DescribeCCEvList(DescribeCCEvListRequest req)
        {
            return InternalRequestAsync<DescribeCCEvListResponse>(req, "DescribeCCEvList");
        }

        /// <summary>
        /// 获取CC攻击事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCCEvListRequest"/></param>
        /// <returns><see cref="DescribeCCEvListResponse"/></returns>
        public DescribeCCEvListResponse DescribeCCEvListSync(DescribeCCEvListRequest req)
        {
            return InternalRequestAsync<DescribeCCEvListResponse>(req, "DescribeCCEvList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取CC防护的访问频率控制规则
        /// </summary>
        /// <param name="req"><see cref="DescribeCCFrequencyRulesRequest"/></param>
        /// <returns><see cref="DescribeCCFrequencyRulesResponse"/></returns>
        public Task<DescribeCCFrequencyRulesResponse> DescribeCCFrequencyRules(DescribeCCFrequencyRulesRequest req)
        {
            return InternalRequestAsync<DescribeCCFrequencyRulesResponse>(req, "DescribeCCFrequencyRules");
        }

        /// <summary>
        /// 获取CC防护的访问频率控制规则
        /// </summary>
        /// <param name="req"><see cref="DescribeCCFrequencyRulesRequest"/></param>
        /// <returns><see cref="DescribeCCFrequencyRulesResponse"/></returns>
        public DescribeCCFrequencyRulesResponse DescribeCCFrequencyRulesSync(DescribeCCFrequencyRulesRequest req)
        {
            return InternalRequestAsync<DescribeCCFrequencyRulesResponse>(req, "DescribeCCFrequencyRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取CC的IP黑白名单
        /// </summary>
        /// <param name="req"><see cref="DescribeCCIpAllowDenyRequest"/></param>
        /// <returns><see cref="DescribeCCIpAllowDenyResponse"/></returns>
        public Task<DescribeCCIpAllowDenyResponse> DescribeCCIpAllowDeny(DescribeCCIpAllowDenyRequest req)
        {
            return InternalRequestAsync<DescribeCCIpAllowDenyResponse>(req, "DescribeCCIpAllowDeny");
        }

        /// <summary>
        /// 获取CC的IP黑白名单
        /// </summary>
        /// <param name="req"><see cref="DescribeCCIpAllowDenyRequest"/></param>
        /// <returns><see cref="DescribeCCIpAllowDenyResponse"/></returns>
        public DescribeCCIpAllowDenyResponse DescribeCCIpAllowDenySync(DescribeCCIpAllowDenyRequest req)
        {
            return InternalRequestAsync<DescribeCCIpAllowDenyResponse>(req, "DescribeCCIpAllowDeny")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取CC自定义策略
        /// </summary>
        /// <param name="req"><see cref="DescribeCCSelfDefinePolicyRequest"/></param>
        /// <returns><see cref="DescribeCCSelfDefinePolicyResponse"/></returns>
        public Task<DescribeCCSelfDefinePolicyResponse> DescribeCCSelfDefinePolicy(DescribeCCSelfDefinePolicyRequest req)
        {
            return InternalRequestAsync<DescribeCCSelfDefinePolicyResponse>(req, "DescribeCCSelfDefinePolicy");
        }

        /// <summary>
        /// 获取CC自定义策略
        /// </summary>
        /// <param name="req"><see cref="DescribeCCSelfDefinePolicyRequest"/></param>
        /// <returns><see cref="DescribeCCSelfDefinePolicyResponse"/></returns>
        public DescribeCCSelfDefinePolicyResponse DescribeCCSelfDefinePolicySync(DescribeCCSelfDefinePolicyRequest req)
        {
            return InternalRequestAsync<DescribeCCSelfDefinePolicyResponse>(req, "DescribeCCSelfDefinePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取CC攻击指标数据，包括总请求峰值(QPS)和攻击请求(QPS)
        /// </summary>
        /// <param name="req"><see cref="DescribeCCTrendRequest"/></param>
        /// <returns><see cref="DescribeCCTrendResponse"/></returns>
        public Task<DescribeCCTrendResponse> DescribeCCTrend(DescribeCCTrendRequest req)
        {
            return InternalRequestAsync<DescribeCCTrendResponse>(req, "DescribeCCTrend");
        }

        /// <summary>
        /// 获取CC攻击指标数据，包括总请求峰值(QPS)和攻击请求(QPS)
        /// </summary>
        /// <param name="req"><see cref="DescribeCCTrendRequest"/></param>
        /// <returns><see cref="DescribeCCTrendResponse"/></returns>
        public DescribeCCTrendResponse DescribeCCTrendSync(DescribeCCTrendRequest req)
        {
            return InternalRequestAsync<DescribeCCTrendResponse>(req, "DescribeCCTrend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取CC的Url白名单
        /// </summary>
        /// <param name="req"><see cref="DescribeCCUrlAllowRequest"/></param>
        /// <returns><see cref="DescribeCCUrlAllowResponse"/></returns>
        public Task<DescribeCCUrlAllowResponse> DescribeCCUrlAllow(DescribeCCUrlAllowRequest req)
        {
            return InternalRequestAsync<DescribeCCUrlAllowResponse>(req, "DescribeCCUrlAllow");
        }

        /// <summary>
        /// 获取CC的Url白名单
        /// </summary>
        /// <param name="req"><see cref="DescribeCCUrlAllowRequest"/></param>
        /// <returns><see cref="DescribeCCUrlAllowResponse"/></returns>
        public DescribeCCUrlAllowResponse DescribeCCUrlAllowSync(DescribeCCUrlAllowRequest req)
        {
            return InternalRequestAsync<DescribeCCUrlAllowResponse>(req, "DescribeCCUrlAllow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取高防包、高防IP、高防IP专业版、棋牌盾产品设置DDoS攻击的告警通知阈值
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAlarmThresholdRequest"/></param>
        /// <returns><see cref="DescribeDDoSAlarmThresholdResponse"/></returns>
        public Task<DescribeDDoSAlarmThresholdResponse> DescribeDDoSAlarmThreshold(DescribeDDoSAlarmThresholdRequest req)
        {
            return InternalRequestAsync<DescribeDDoSAlarmThresholdResponse>(req, "DescribeDDoSAlarmThreshold");
        }

        /// <summary>
        /// 获取高防包、高防IP、高防IP专业版、棋牌盾产品设置DDoS攻击的告警通知阈值
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAlarmThresholdRequest"/></param>
        /// <returns><see cref="DescribeDDoSAlarmThresholdResponse"/></returns>
        public DescribeDDoSAlarmThresholdResponse DescribeDDoSAlarmThresholdSync(DescribeDDoSAlarmThresholdRequest req)
        {
            return InternalRequestAsync<DescribeDDoSAlarmThresholdResponse>(req, "DescribeDDoSAlarmThreshold")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DDoS攻击源IP地域分布图，支持全球攻击分布和国内省份攻击分布；
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackIPRegionMapRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackIPRegionMapResponse"/></returns>
        public Task<DescribeDDoSAttackIPRegionMapResponse> DescribeDDoSAttackIPRegionMap(DescribeDDoSAttackIPRegionMapRequest req)
        {
            return InternalRequestAsync<DescribeDDoSAttackIPRegionMapResponse>(req, "DescribeDDoSAttackIPRegionMap");
        }

        /// <summary>
        /// 获取DDoS攻击源IP地域分布图，支持全球攻击分布和国内省份攻击分布；
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackIPRegionMapRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackIPRegionMapResponse"/></returns>
        public DescribeDDoSAttackIPRegionMapResponse DescribeDDoSAttackIPRegionMapSync(DescribeDDoSAttackIPRegionMapRequest req)
        {
            return InternalRequestAsync<DescribeDDoSAttackIPRegionMapResponse>(req, "DescribeDDoSAttackIPRegionMap")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DDoS攻击源列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackSourceRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackSourceResponse"/></returns>
        public Task<DescribeDDoSAttackSourceResponse> DescribeDDoSAttackSource(DescribeDDoSAttackSourceRequest req)
        {
            return InternalRequestAsync<DescribeDDoSAttackSourceResponse>(req, "DescribeDDoSAttackSource");
        }

        /// <summary>
        /// 获取DDoS攻击源列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackSourceRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackSourceResponse"/></returns>
        public DescribeDDoSAttackSourceResponse DescribeDDoSAttackSourceSync(DescribeDDoSAttackSourceRequest req)
        {
            return InternalRequestAsync<DescribeDDoSAttackSourceResponse>(req, "DescribeDDoSAttackSource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DDoS攻击占比分析
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSCountRequest"/></param>
        /// <returns><see cref="DescribeDDoSCountResponse"/></returns>
        public Task<DescribeDDoSCountResponse> DescribeDDoSCount(DescribeDDoSCountRequest req)
        {
            return InternalRequestAsync<DescribeDDoSCountResponse>(req, "DescribeDDoSCount");
        }

        /// <summary>
        /// 获取DDoS攻击占比分析
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSCountRequest"/></param>
        /// <returns><see cref="DescribeDDoSCountResponse"/></returns>
        public DescribeDDoSCountResponse DescribeDDoSCountSync(DescribeDDoSCountRequest req)
        {
            return InternalRequestAsync<DescribeDDoSCountResponse>(req, "DescribeDDoSCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DDoS防护状态（临时关闭状态），支持产品：基础防护，独享包，共享包，高防IP，高防IP专业版；调用此接口是获取当前是否有设置临时关闭DDoS防护状态，如果有设置会返回临时关闭的时长等参数。
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSDefendStatusRequest"/></param>
        /// <returns><see cref="DescribeDDoSDefendStatusResponse"/></returns>
        public Task<DescribeDDoSDefendStatusResponse> DescribeDDoSDefendStatus(DescribeDDoSDefendStatusRequest req)
        {
            return InternalRequestAsync<DescribeDDoSDefendStatusResponse>(req, "DescribeDDoSDefendStatus");
        }

        /// <summary>
        /// 获取DDoS防护状态（临时关闭状态），支持产品：基础防护，独享包，共享包，高防IP，高防IP专业版；调用此接口是获取当前是否有设置临时关闭DDoS防护状态，如果有设置会返回临时关闭的时长等参数。
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSDefendStatusRequest"/></param>
        /// <returns><see cref="DescribeDDoSDefendStatusResponse"/></returns>
        public DescribeDDoSDefendStatusResponse DescribeDDoSDefendStatusSync(DescribeDDoSDefendStatusRequest req)
        {
            return InternalRequestAsync<DescribeDDoSDefendStatusResponse>(req, "DescribeDDoSDefendStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DDoS攻击事件详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSEvInfoRequest"/></param>
        /// <returns><see cref="DescribeDDoSEvInfoResponse"/></returns>
        public Task<DescribeDDoSEvInfoResponse> DescribeDDoSEvInfo(DescribeDDoSEvInfoRequest req)
        {
            return InternalRequestAsync<DescribeDDoSEvInfoResponse>(req, "DescribeDDoSEvInfo");
        }

        /// <summary>
        /// 获取DDoS攻击事件详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSEvInfoRequest"/></param>
        /// <returns><see cref="DescribeDDoSEvInfoResponse"/></returns>
        public DescribeDDoSEvInfoResponse DescribeDDoSEvInfoSync(DescribeDDoSEvInfoRequest req)
        {
            return InternalRequestAsync<DescribeDDoSEvInfoResponse>(req, "DescribeDDoSEvInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DDoS攻击事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSEvListRequest"/></param>
        /// <returns><see cref="DescribeDDoSEvListResponse"/></returns>
        public Task<DescribeDDoSEvListResponse> DescribeDDoSEvList(DescribeDDoSEvListRequest req)
        {
            return InternalRequestAsync<DescribeDDoSEvListResponse>(req, "DescribeDDoSEvList");
        }

        /// <summary>
        /// 获取DDoS攻击事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSEvListRequest"/></param>
        /// <returns><see cref="DescribeDDoSEvListResponse"/></returns>
        public DescribeDDoSEvListResponse DescribeDDoSEvListSync(DescribeDDoSEvListRequest req)
        {
            return InternalRequestAsync<DescribeDDoSEvListResponse>(req, "DescribeDDoSEvList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DDoSIP攻击日志
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSIpLogRequest"/></param>
        /// <returns><see cref="DescribeDDoSIpLogResponse"/></returns>
        public Task<DescribeDDoSIpLogResponse> DescribeDDoSIpLog(DescribeDDoSIpLogRequest req)
        {
            return InternalRequestAsync<DescribeDDoSIpLogResponse>(req, "DescribeDDoSIpLog");
        }

        /// <summary>
        /// 获取DDoSIP攻击日志
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSIpLogRequest"/></param>
        /// <returns><see cref="DescribeDDoSIpLogResponse"/></returns>
        public DescribeDDoSIpLogResponse DescribeDDoSIpLogSync(DescribeDDoSIpLogRequest req)
        {
            return InternalRequestAsync<DescribeDDoSIpLogResponse>(req, "DescribeDDoSIpLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取高防IP专业版资源的DDoS攻击占比分析
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSNetCountRequest"/></param>
        /// <returns><see cref="DescribeDDoSNetCountResponse"/></returns>
        public Task<DescribeDDoSNetCountResponse> DescribeDDoSNetCount(DescribeDDoSNetCountRequest req)
        {
            return InternalRequestAsync<DescribeDDoSNetCountResponse>(req, "DescribeDDoSNetCount");
        }

        /// <summary>
        /// 获取高防IP专业版资源的DDoS攻击占比分析
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSNetCountRequest"/></param>
        /// <returns><see cref="DescribeDDoSNetCountResponse"/></returns>
        public DescribeDDoSNetCountResponse DescribeDDoSNetCountSync(DescribeDDoSNetCountRequest req)
        {
            return InternalRequestAsync<DescribeDDoSNetCountResponse>(req, "DescribeDDoSNetCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取高防IP专业版资源的DDoS攻击事件详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSNetEvInfoRequest"/></param>
        /// <returns><see cref="DescribeDDoSNetEvInfoResponse"/></returns>
        public Task<DescribeDDoSNetEvInfoResponse> DescribeDDoSNetEvInfo(DescribeDDoSNetEvInfoRequest req)
        {
            return InternalRequestAsync<DescribeDDoSNetEvInfoResponse>(req, "DescribeDDoSNetEvInfo");
        }

        /// <summary>
        /// 获取高防IP专业版资源的DDoS攻击事件详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSNetEvInfoRequest"/></param>
        /// <returns><see cref="DescribeDDoSNetEvInfoResponse"/></returns>
        public DescribeDDoSNetEvInfoResponse DescribeDDoSNetEvInfoSync(DescribeDDoSNetEvInfoRequest req)
        {
            return InternalRequestAsync<DescribeDDoSNetEvInfoResponse>(req, "DescribeDDoSNetEvInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取高防IP专业版资源的DDoS攻击事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSNetEvListRequest"/></param>
        /// <returns><see cref="DescribeDDoSNetEvListResponse"/></returns>
        public Task<DescribeDDoSNetEvListResponse> DescribeDDoSNetEvList(DescribeDDoSNetEvListRequest req)
        {
            return InternalRequestAsync<DescribeDDoSNetEvListResponse>(req, "DescribeDDoSNetEvList");
        }

        /// <summary>
        /// 获取高防IP专业版资源的DDoS攻击事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSNetEvListRequest"/></param>
        /// <returns><see cref="DescribeDDoSNetEvListResponse"/></returns>
        public DescribeDDoSNetEvListResponse DescribeDDoSNetEvListSync(DescribeDDoSNetEvListRequest req)
        {
            return InternalRequestAsync<DescribeDDoSNetEvListResponse>(req, "DescribeDDoSNetEvList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取高防IP专业版资源的DDoSIP攻击日志
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSNetIpLogRequest"/></param>
        /// <returns><see cref="DescribeDDoSNetIpLogResponse"/></returns>
        public Task<DescribeDDoSNetIpLogResponse> DescribeDDoSNetIpLog(DescribeDDoSNetIpLogRequest req)
        {
            return InternalRequestAsync<DescribeDDoSNetIpLogResponse>(req, "DescribeDDoSNetIpLog");
        }

        /// <summary>
        /// 获取高防IP专业版资源的DDoSIP攻击日志
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSNetIpLogRequest"/></param>
        /// <returns><see cref="DescribeDDoSNetIpLogResponse"/></returns>
        public DescribeDDoSNetIpLogResponse DescribeDDoSNetIpLogSync(DescribeDDoSNetIpLogRequest req)
        {
            return InternalRequestAsync<DescribeDDoSNetIpLogResponse>(req, "DescribeDDoSNetIpLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取高防IP专业版资源的DDoS攻击指标数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSNetTrendRequest"/></param>
        /// <returns><see cref="DescribeDDoSNetTrendResponse"/></returns>
        public Task<DescribeDDoSNetTrendResponse> DescribeDDoSNetTrend(DescribeDDoSNetTrendRequest req)
        {
            return InternalRequestAsync<DescribeDDoSNetTrendResponse>(req, "DescribeDDoSNetTrend");
        }

        /// <summary>
        /// 获取高防IP专业版资源的DDoS攻击指标数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSNetTrendRequest"/></param>
        /// <returns><see cref="DescribeDDoSNetTrendResponse"/></returns>
        public DescribeDDoSNetTrendResponse DescribeDDoSNetTrendSync(DescribeDDoSNetTrendRequest req)
        {
            return InternalRequestAsync<DescribeDDoSNetTrendResponse>(req, "DescribeDDoSNetTrend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DDoS高级策略
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSPolicyRequest"/></param>
        /// <returns><see cref="DescribeDDoSPolicyResponse"/></returns>
        public Task<DescribeDDoSPolicyResponse> DescribeDDoSPolicy(DescribeDDoSPolicyRequest req)
        {
            return InternalRequestAsync<DescribeDDoSPolicyResponse>(req, "DescribeDDoSPolicy");
        }

        /// <summary>
        /// 获取DDoS高级策略
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSPolicyRequest"/></param>
        /// <returns><see cref="DescribeDDoSPolicyResponse"/></returns>
        public DescribeDDoSPolicyResponse DescribeDDoSPolicySync(DescribeDDoSPolicyRequest req)
        {
            return InternalRequestAsync<DescribeDDoSPolicyResponse>(req, "DescribeDDoSPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DDoS攻击流量带宽和攻击包速率数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSTrendRequest"/></param>
        /// <returns><see cref="DescribeDDoSTrendResponse"/></returns>
        public Task<DescribeDDoSTrendResponse> DescribeDDoSTrend(DescribeDDoSTrendRequest req)
        {
            return InternalRequestAsync<DescribeDDoSTrendResponse>(req, "DescribeDDoSTrend");
        }

        /// <summary>
        /// 获取DDoS攻击流量带宽和攻击包速率数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSTrendRequest"/></param>
        /// <returns><see cref="DescribeDDoSTrendResponse"/></returns>
        public DescribeDDoSTrendResponse DescribeDDoSTrendSync(DescribeDDoSTrendRequest req)
        {
            return InternalRequestAsync<DescribeDDoSTrendResponse>(req, "DescribeDDoSTrend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 统计用户的高防资源的使用天数和DDoS攻击防护次数
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSUsedStatisRequest"/></param>
        /// <returns><see cref="DescribeDDoSUsedStatisResponse"/></returns>
        public Task<DescribeDDoSUsedStatisResponse> DescribeDDoSUsedStatis(DescribeDDoSUsedStatisRequest req)
        {
            return InternalRequestAsync<DescribeDDoSUsedStatisResponse>(req, "DescribeDDoSUsedStatis");
        }

        /// <summary>
        /// 统计用户的高防资源的使用天数和DDoS攻击防护次数
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSUsedStatisRequest"/></param>
        /// <returns><see cref="DescribeDDoSUsedStatisResponse"/></returns>
        public DescribeDDoSUsedStatisResponse DescribeDDoSUsedStatisSync(DescribeDDoSUsedStatisRequest req)
        {
            return InternalRequestAsync<DescribeDDoSUsedStatisResponse>(req, "DescribeDDoSUsedStatis")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取独享包或共享包IP对应的云资产信息，只支持独享包和共享包的IP
        /// </summary>
        /// <param name="req"><see cref="DescribeIPProductInfoRequest"/></param>
        /// <returns><see cref="DescribeIPProductInfoResponse"/></returns>
        public Task<DescribeIPProductInfoResponse> DescribeIPProductInfo(DescribeIPProductInfoRequest req)
        {
            return InternalRequestAsync<DescribeIPProductInfoResponse>(req, "DescribeIPProductInfo");
        }

        /// <summary>
        /// 获取独享包或共享包IP对应的云资产信息，只支持独享包和共享包的IP
        /// </summary>
        /// <param name="req"><see cref="DescribeIPProductInfoRequest"/></param>
        /// <returns><see cref="DescribeIPProductInfoResponse"/></returns>
        public DescribeIPProductInfoResponse DescribeIPProductInfoSync(DescribeIPProductInfoRequest req)
        {
            return InternalRequestAsync<DescribeIPProductInfoResponse>(req, "DescribeIPProductInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取保险包套餐列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInsurePacksRequest"/></param>
        /// <returns><see cref="DescribeInsurePacksResponse"/></returns>
        public Task<DescribeInsurePacksResponse> DescribeInsurePacks(DescribeInsurePacksRequest req)
        {
            return InternalRequestAsync<DescribeInsurePacksResponse>(req, "DescribeInsurePacks");
        }

        /// <summary>
        /// 获取保险包套餐列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInsurePacksRequest"/></param>
        /// <returns><see cref="DescribeInsurePacksResponse"/></returns>
        public DescribeInsurePacksResponse DescribeInsurePacksSync(DescribeInsurePacksRequest req)
        {
            return InternalRequestAsync<DescribeInsurePacksResponse>(req, "DescribeInsurePacks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取IP封堵列表
        /// </summary>
        /// <param name="req"><see cref="DescribeIpBlockListRequest"/></param>
        /// <returns><see cref="DescribeIpBlockListResponse"/></returns>
        public Task<DescribeIpBlockListResponse> DescribeIpBlockList(DescribeIpBlockListRequest req)
        {
            return InternalRequestAsync<DescribeIpBlockListResponse>(req, "DescribeIpBlockList");
        }

        /// <summary>
        /// 获取IP封堵列表
        /// </summary>
        /// <param name="req"><see cref="DescribeIpBlockListRequest"/></param>
        /// <returns><see cref="DescribeIpBlockListResponse"/></returns>
        public DescribeIpBlockListResponse DescribeIpBlockListSync(DescribeIpBlockListRequest req)
        {
            return InternalRequestAsync<DescribeIpBlockListResponse>(req, "DescribeIpBlockList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取IP解封记录
        /// </summary>
        /// <param name="req"><see cref="DescribeIpUnBlockListRequest"/></param>
        /// <returns><see cref="DescribeIpUnBlockListResponse"/></returns>
        public Task<DescribeIpUnBlockListResponse> DescribeIpUnBlockList(DescribeIpUnBlockListRequest req)
        {
            return InternalRequestAsync<DescribeIpUnBlockListResponse>(req, "DescribeIpUnBlockList");
        }

        /// <summary>
        /// 获取IP解封记录
        /// </summary>
        /// <param name="req"><see cref="DescribeIpUnBlockListRequest"/></param>
        /// <returns><see cref="DescribeIpUnBlockListResponse"/></returns>
        public DescribeIpUnBlockListResponse DescribeIpUnBlockListSync(DescribeIpUnBlockListRequest req)
        {
            return InternalRequestAsync<DescribeIpUnBlockListResponse>(req, "DescribeIpUnBlockList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 导出四层健康检查配置
        /// </summary>
        /// <param name="req"><see cref="DescribeL4HealthConfigRequest"/></param>
        /// <returns><see cref="DescribeL4HealthConfigResponse"/></returns>
        public Task<DescribeL4HealthConfigResponse> DescribeL4HealthConfig(DescribeL4HealthConfigRequest req)
        {
            return InternalRequestAsync<DescribeL4HealthConfigResponse>(req, "DescribeL4HealthConfig");
        }

        /// <summary>
        /// 导出四层健康检查配置
        /// </summary>
        /// <param name="req"><see cref="DescribeL4HealthConfigRequest"/></param>
        /// <returns><see cref="DescribeL4HealthConfigResponse"/></returns>
        public DescribeL4HealthConfigResponse DescribeL4HealthConfigSync(DescribeL4HealthConfigRequest req)
        {
            return InternalRequestAsync<DescribeL4HealthConfigResponse>(req, "DescribeL4HealthConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取L4转发规则健康检查异常结果
        /// </summary>
        /// <param name="req"><see cref="DescribeL4RulesErrHealthRequest"/></param>
        /// <returns><see cref="DescribeL4RulesErrHealthResponse"/></returns>
        public Task<DescribeL4RulesErrHealthResponse> DescribeL4RulesErrHealth(DescribeL4RulesErrHealthRequest req)
        {
            return InternalRequestAsync<DescribeL4RulesErrHealthResponse>(req, "DescribeL4RulesErrHealth");
        }

        /// <summary>
        /// 获取L4转发规则健康检查异常结果
        /// </summary>
        /// <param name="req"><see cref="DescribeL4RulesErrHealthRequest"/></param>
        /// <returns><see cref="DescribeL4RulesErrHealthResponse"/></returns>
        public DescribeL4RulesErrHealthResponse DescribeL4RulesErrHealthSync(DescribeL4RulesErrHealthRequest req)
        {
            return InternalRequestAsync<DescribeL4RulesErrHealthResponse>(req, "DescribeL4RulesErrHealth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 导出七层健康检查配置
        /// </summary>
        /// <param name="req"><see cref="DescribeL7HealthConfigRequest"/></param>
        /// <returns><see cref="DescribeL7HealthConfigResponse"/></returns>
        public Task<DescribeL7HealthConfigResponse> DescribeL7HealthConfig(DescribeL7HealthConfigRequest req)
        {
            return InternalRequestAsync<DescribeL7HealthConfigResponse>(req, "DescribeL7HealthConfig");
        }

        /// <summary>
        /// 导出七层健康检查配置
        /// </summary>
        /// <param name="req"><see cref="DescribeL7HealthConfigRequest"/></param>
        /// <returns><see cref="DescribeL7HealthConfigResponse"/></returns>
        public DescribeL7HealthConfigResponse DescribeL7HealthConfigSync(DescribeL7HealthConfigRequest req)
        {
            return InternalRequestAsync<DescribeL7HealthConfigResponse>(req, "DescribeL7HealthConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取L4转发规则
        /// </summary>
        /// <param name="req"><see cref="DescribeNewL4RulesRequest"/></param>
        /// <returns><see cref="DescribeNewL4RulesResponse"/></returns>
        public Task<DescribeNewL4RulesResponse> DescribeNewL4Rules(DescribeNewL4RulesRequest req)
        {
            return InternalRequestAsync<DescribeNewL4RulesResponse>(req, "DescribeNewL4Rules");
        }

        /// <summary>
        /// 获取L4转发规则
        /// </summary>
        /// <param name="req"><see cref="DescribeNewL4RulesRequest"/></param>
        /// <returns><see cref="DescribeNewL4RulesResponse"/></returns>
        public DescribeNewL4RulesResponse DescribeNewL4RulesSync(DescribeNewL4RulesRequest req)
        {
            return InternalRequestAsync<DescribeNewL4RulesResponse>(req, "DescribeNewL4Rules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取L4转发规则健康检查异常结果
        /// </summary>
        /// <param name="req"><see cref="DescribeNewL4RulesErrHealthRequest"/></param>
        /// <returns><see cref="DescribeNewL4RulesErrHealthResponse"/></returns>
        public Task<DescribeNewL4RulesErrHealthResponse> DescribeNewL4RulesErrHealth(DescribeNewL4RulesErrHealthRequest req)
        {
            return InternalRequestAsync<DescribeNewL4RulesErrHealthResponse>(req, "DescribeNewL4RulesErrHealth");
        }

        /// <summary>
        /// 获取L4转发规则健康检查异常结果
        /// </summary>
        /// <param name="req"><see cref="DescribeNewL4RulesErrHealthRequest"/></param>
        /// <returns><see cref="DescribeNewL4RulesErrHealthResponse"/></returns>
        public DescribeNewL4RulesErrHealthResponse DescribeNewL4RulesErrHealthSync(DescribeNewL4RulesErrHealthRequest req)
        {
            return InternalRequestAsync<DescribeNewL4RulesErrHealthResponse>(req, "DescribeNewL4RulesErrHealth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取L7转发规则健康检查异常结果
        /// </summary>
        /// <param name="req"><see cref="DescribeNewL7RulesErrHealthRequest"/></param>
        /// <returns><see cref="DescribeNewL7RulesErrHealthResponse"/></returns>
        public Task<DescribeNewL7RulesErrHealthResponse> DescribeNewL7RulesErrHealth(DescribeNewL7RulesErrHealthRequest req)
        {
            return InternalRequestAsync<DescribeNewL7RulesErrHealthResponse>(req, "DescribeNewL7RulesErrHealth");
        }

        /// <summary>
        /// 获取L7转发规则健康检查异常结果
        /// </summary>
        /// <param name="req"><see cref="DescribeNewL7RulesErrHealthRequest"/></param>
        /// <returns><see cref="DescribeNewL7RulesErrHealthResponse"/></returns>
        public DescribeNewL7RulesErrHealthResponse DescribeNewL7RulesErrHealthSync(DescribeNewL7RulesErrHealthRequest req)
        {
            return InternalRequestAsync<DescribeNewL7RulesErrHealthResponse>(req, "DescribeNewL7RulesErrHealth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取产品总览统计，支持高防包、高防IP、高防IP专业版；
        /// </summary>
        /// <param name="req"><see cref="DescribePackIndexRequest"/></param>
        /// <returns><see cref="DescribePackIndexResponse"/></returns>
        public Task<DescribePackIndexResponse> DescribePackIndex(DescribePackIndexRequest req)
        {
            return InternalRequestAsync<DescribePackIndexResponse>(req, "DescribePackIndex");
        }

        /// <summary>
        /// 获取产品总览统计，支持高防包、高防IP、高防IP专业版；
        /// </summary>
        /// <param name="req"><see cref="DescribePackIndexRequest"/></param>
        /// <returns><see cref="DescribePackIndexResponse"/></returns>
        public DescribePackIndexResponse DescribePackIndexSync(DescribePackIndexRequest req)
        {
            return InternalRequestAsync<DescribePackIndexResponse>(req, "DescribePackIndex")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 下载攻击事件的pcap包
        /// </summary>
        /// <param name="req"><see cref="DescribePcapRequest"/></param>
        /// <returns><see cref="DescribePcapResponse"/></returns>
        public Task<DescribePcapResponse> DescribePcap(DescribePcapRequest req)
        {
            return InternalRequestAsync<DescribePcapResponse>(req, "DescribePcap");
        }

        /// <summary>
        /// 下载攻击事件的pcap包
        /// </summary>
        /// <param name="req"><see cref="DescribePcapRequest"/></param>
        /// <returns><see cref="DescribePcapResponse"/></returns>
        public DescribePcapResponse DescribePcapSync(DescribePcapRequest req)
        {
            return InternalRequestAsync<DescribePcapResponse>(req, "DescribePcap")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取策略场景
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyCaseRequest"/></param>
        /// <returns><see cref="DescribePolicyCaseResponse"/></returns>
        public Task<DescribePolicyCaseResponse> DescribePolicyCase(DescribePolicyCaseRequest req)
        {
            return InternalRequestAsync<DescribePolicyCaseResponse>(req, "DescribePolicyCase");
        }

        /// <summary>
        /// 获取策略场景
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyCaseRequest"/></param>
        /// <returns><see cref="DescribePolicyCaseResponse"/></returns>
        public DescribePolicyCaseResponse DescribePolicyCaseSync(DescribePolicyCaseRequest req)
        {
            return InternalRequestAsync<DescribePolicyCaseResponse>(req, "DescribePolicyCase")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取资源的IP列表
        /// </summary>
        /// <param name="req"><see cref="DescribeResIpListRequest"/></param>
        /// <returns><see cref="DescribeResIpListResponse"/></returns>
        public Task<DescribeResIpListResponse> DescribeResIpList(DescribeResIpListRequest req)
        {
            return InternalRequestAsync<DescribeResIpListResponse>(req, "DescribeResIpList");
        }

        /// <summary>
        /// 获取资源的IP列表
        /// </summary>
        /// <param name="req"><see cref="DescribeResIpListRequest"/></param>
        /// <returns><see cref="DescribeResIpListResponse"/></returns>
        public DescribeResIpListResponse DescribeResIpListSync(DescribeResIpListRequest req)
        {
            return InternalRequestAsync<DescribeResIpListResponse>(req, "DescribeResIpList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取资源列表
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceListRequest"/></param>
        /// <returns><see cref="DescribeResourceListResponse"/></returns>
        public Task<DescribeResourceListResponse> DescribeResourceList(DescribeResourceListRequest req)
        {
            return InternalRequestAsync<DescribeResourceListResponse>(req, "DescribeResourceList");
        }

        /// <summary>
        /// 获取资源列表
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceListRequest"/></param>
        /// <returns><see cref="DescribeResourceListResponse"/></returns>
        public DescribeResourceListResponse DescribeResourceListSync(DescribeResourceListRequest req)
        {
            return InternalRequestAsync<DescribeResourceListResponse>(req, "DescribeResourceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取资源的规则数
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleSetsRequest"/></param>
        /// <returns><see cref="DescribeRuleSetsResponse"/></returns>
        public Task<DescribeRuleSetsResponse> DescribeRuleSets(DescribeRuleSetsRequest req)
        {
            return InternalRequestAsync<DescribeRuleSetsResponse>(req, "DescribeRuleSets");
        }

        /// <summary>
        /// 获取资源的规则数
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleSetsRequest"/></param>
        /// <returns><see cref="DescribeRuleSetsResponse"/></returns>
        public DescribeRuleSetsResponse DescribeRuleSetsSync(DescribeRuleSetsRequest req)
        {
            return InternalRequestAsync<DescribeRuleSetsResponse>(req, "DescribeRuleSets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取调度域名列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSchedulingDomainListRequest"/></param>
        /// <returns><see cref="DescribeSchedulingDomainListResponse"/></returns>
        public Task<DescribeSchedulingDomainListResponse> DescribeSchedulingDomainList(DescribeSchedulingDomainListRequest req)
        {
            return InternalRequestAsync<DescribeSchedulingDomainListResponse>(req, "DescribeSchedulingDomainList");
        }

        /// <summary>
        /// 获取调度域名列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSchedulingDomainListRequest"/></param>
        /// <returns><see cref="DescribeSchedulingDomainListResponse"/></returns>
        public DescribeSchedulingDomainListResponse DescribeSchedulingDomainListSync(DescribeSchedulingDomainListRequest req)
        {
            return InternalRequestAsync<DescribeSchedulingDomainListResponse>(req, "DescribeSchedulingDomainList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取本月安全统计
        /// </summary>
        /// <param name="req"><see cref="DescribeSecIndexRequest"/></param>
        /// <returns><see cref="DescribeSecIndexResponse"/></returns>
        public Task<DescribeSecIndexResponse> DescribeSecIndex(DescribeSecIndexRequest req)
        {
            return InternalRequestAsync<DescribeSecIndexResponse>(req, "DescribeSecIndex");
        }

        /// <summary>
        /// 获取本月安全统计
        /// </summary>
        /// <param name="req"><see cref="DescribeSecIndexRequest"/></param>
        /// <returns><see cref="DescribeSecIndexResponse"/></returns>
        public DescribeSecIndexResponse DescribeSecIndexSync(DescribeSecIndexRequest req)
        {
            return InternalRequestAsync<DescribeSecIndexResponse>(req, "DescribeSecIndex")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取回源IP段，支持的产品：高防IP，高防IP专业版；
        /// </summary>
        /// <param name="req"><see cref="DescribeSourceIpSegmentRequest"/></param>
        /// <returns><see cref="DescribeSourceIpSegmentResponse"/></returns>
        public Task<DescribeSourceIpSegmentResponse> DescribeSourceIpSegment(DescribeSourceIpSegmentRequest req)
        {
            return InternalRequestAsync<DescribeSourceIpSegmentResponse>(req, "DescribeSourceIpSegment");
        }

        /// <summary>
        /// 获取回源IP段，支持的产品：高防IP，高防IP专业版；
        /// </summary>
        /// <param name="req"><see cref="DescribeSourceIpSegmentRequest"/></param>
        /// <returns><see cref="DescribeSourceIpSegmentResponse"/></returns>
        public DescribeSourceIpSegmentResponse DescribeSourceIpSegmentSync(DescribeSourceIpSegmentRequest req)
        {
            return InternalRequestAsync<DescribeSourceIpSegmentResponse>(req, "DescribeSourceIpSegment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取业务转发统计数据，支持转发流量和转发包速率
        /// </summary>
        /// <param name="req"><see cref="DescribeTransmitStatisRequest"/></param>
        /// <returns><see cref="DescribeTransmitStatisResponse"/></returns>
        public Task<DescribeTransmitStatisResponse> DescribeTransmitStatis(DescribeTransmitStatisRequest req)
        {
            return InternalRequestAsync<DescribeTransmitStatisResponse>(req, "DescribeTransmitStatis");
        }

        /// <summary>
        /// 获取业务转发统计数据，支持转发流量和转发包速率
        /// </summary>
        /// <param name="req"><see cref="DescribeTransmitStatisRequest"/></param>
        /// <returns><see cref="DescribeTransmitStatisResponse"/></returns>
        public DescribeTransmitStatisResponse DescribeTransmitStatisSync(DescribeTransmitStatisRequest req)
        {
            return InternalRequestAsync<DescribeTransmitStatisResponse>(req, "DescribeTransmitStatis")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取黑洞解封次数
        /// </summary>
        /// <param name="req"><see cref="DescribeUnBlockStatisRequest"/></param>
        /// <returns><see cref="DescribeUnBlockStatisResponse"/></returns>
        public Task<DescribeUnBlockStatisResponse> DescribeUnBlockStatis(DescribeUnBlockStatisRequest req)
        {
            return InternalRequestAsync<DescribeUnBlockStatisResponse>(req, "DescribeUnBlockStatis");
        }

        /// <summary>
        /// 获取黑洞解封次数
        /// </summary>
        /// <param name="req"><see cref="DescribeUnBlockStatisRequest"/></param>
        /// <returns><see cref="DescribeUnBlockStatisResponse"/></returns>
        public DescribeUnBlockStatisResponse DescribeUnBlockStatisSync(DescribeUnBlockStatisRequest req)
        {
            return InternalRequestAsync<DescribeUnBlockStatisResponse>(req, "DescribeUnBlockStatis")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取四层转发规则
        /// </summary>
        /// <param name="req"><see cref="DescribleL4RulesRequest"/></param>
        /// <returns><see cref="DescribleL4RulesResponse"/></returns>
        public Task<DescribleL4RulesResponse> DescribleL4Rules(DescribleL4RulesRequest req)
        {
            return InternalRequestAsync<DescribleL4RulesResponse>(req, "DescribleL4Rules");
        }

        /// <summary>
        /// 获取四层转发规则
        /// </summary>
        /// <param name="req"><see cref="DescribleL4RulesRequest"/></param>
        /// <returns><see cref="DescribleL4RulesResponse"/></returns>
        public DescribleL4RulesResponse DescribleL4RulesSync(DescribleL4RulesRequest req)
        {
            return InternalRequestAsync<DescribleL4RulesResponse>(req, "DescribleL4Rules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取七层转发规则
        /// </summary>
        /// <param name="req"><see cref="DescribleL7RulesRequest"/></param>
        /// <returns><see cref="DescribleL7RulesResponse"/></returns>
        public Task<DescribleL7RulesResponse> DescribleL7Rules(DescribleL7RulesRequest req)
        {
            return InternalRequestAsync<DescribleL7RulesResponse>(req, "DescribleL7Rules");
        }

        /// <summary>
        /// 获取七层转发规则
        /// </summary>
        /// <param name="req"><see cref="DescribleL7RulesRequest"/></param>
        /// <returns><see cref="DescribleL7RulesResponse"/></returns>
        public DescribleL7RulesResponse DescribleL7RulesSync(DescribleL7RulesRequest req)
        {
            return InternalRequestAsync<DescribleL7RulesResponse>(req, "DescribleL7Rules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取7层规则
        /// </summary>
        /// <param name="req"><see cref="DescribleNewL7RulesRequest"/></param>
        /// <returns><see cref="DescribleNewL7RulesResponse"/></returns>
        public Task<DescribleNewL7RulesResponse> DescribleNewL7Rules(DescribleNewL7RulesRequest req)
        {
            return InternalRequestAsync<DescribleNewL7RulesResponse>(req, "DescribleNewL7Rules");
        }

        /// <summary>
        /// 获取7层规则
        /// </summary>
        /// <param name="req"><see cref="DescribleNewL7RulesRequest"/></param>
        /// <returns><see cref="DescribleNewL7RulesResponse"/></returns>
        public DescribleNewL7RulesResponse DescribleNewL7RulesSync(DescribleNewL7RulesRequest req)
        {
            return InternalRequestAsync<DescribleNewL7RulesResponse>(req, "DescribleNewL7Rules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取地域的资源实例数
        /// </summary>
        /// <param name="req"><see cref="DescribleRegionCountRequest"/></param>
        /// <returns><see cref="DescribleRegionCountResponse"/></returns>
        public Task<DescribleRegionCountResponse> DescribleRegionCount(DescribleRegionCountRequest req)
        {
            return InternalRequestAsync<DescribleRegionCountResponse>(req, "DescribleRegionCount");
        }

        /// <summary>
        /// 获取地域的资源实例数
        /// </summary>
        /// <param name="req"><see cref="DescribleRegionCountRequest"/></param>
        /// <returns><see cref="DescribleRegionCountResponse"/></returns>
        public DescribleRegionCountResponse DescribleRegionCountSync(DescribleRegionCountRequest req)
        {
            return InternalRequestAsync<DescribleRegionCountResponse>(req, "DescribleRegionCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 为高防包、高防IP、高防IP专业版、棋牌盾产品设置CC攻击的告警通知阈值
        /// </summary>
        /// <param name="req"><see cref="ModifyCCAlarmThresholdRequest"/></param>
        /// <returns><see cref="ModifyCCAlarmThresholdResponse"/></returns>
        public Task<ModifyCCAlarmThresholdResponse> ModifyCCAlarmThreshold(ModifyCCAlarmThresholdRequest req)
        {
            return InternalRequestAsync<ModifyCCAlarmThresholdResponse>(req, "ModifyCCAlarmThreshold");
        }

        /// <summary>
        /// 为高防包、高防IP、高防IP专业版、棋牌盾产品设置CC攻击的告警通知阈值
        /// </summary>
        /// <param name="req"><see cref="ModifyCCAlarmThresholdRequest"/></param>
        /// <returns><see cref="ModifyCCAlarmThresholdResponse"/></returns>
        public ModifyCCAlarmThresholdResponse ModifyCCAlarmThresholdSync(ModifyCCAlarmThresholdRequest req)
        {
            return InternalRequestAsync<ModifyCCAlarmThresholdResponse>(req, "ModifyCCAlarmThreshold")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改CC防护的访问频率控制规则
        /// </summary>
        /// <param name="req"><see cref="ModifyCCFrequencyRulesRequest"/></param>
        /// <returns><see cref="ModifyCCFrequencyRulesResponse"/></returns>
        public Task<ModifyCCFrequencyRulesResponse> ModifyCCFrequencyRules(ModifyCCFrequencyRulesRequest req)
        {
            return InternalRequestAsync<ModifyCCFrequencyRulesResponse>(req, "ModifyCCFrequencyRules");
        }

        /// <summary>
        /// 修改CC防护的访问频率控制规则
        /// </summary>
        /// <param name="req"><see cref="ModifyCCFrequencyRulesRequest"/></param>
        /// <returns><see cref="ModifyCCFrequencyRulesResponse"/></returns>
        public ModifyCCFrequencyRulesResponse ModifyCCFrequencyRulesSync(ModifyCCFrequencyRulesRequest req)
        {
            return InternalRequestAsync<ModifyCCFrequencyRulesResponse>(req, "ModifyCCFrequencyRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开启或关闭CC防护的访问频率控制规则
        /// </summary>
        /// <param name="req"><see cref="ModifyCCFrequencyRulesStatusRequest"/></param>
        /// <returns><see cref="ModifyCCFrequencyRulesStatusResponse"/></returns>
        public Task<ModifyCCFrequencyRulesStatusResponse> ModifyCCFrequencyRulesStatus(ModifyCCFrequencyRulesStatusRequest req)
        {
            return InternalRequestAsync<ModifyCCFrequencyRulesStatusResponse>(req, "ModifyCCFrequencyRulesStatus");
        }

        /// <summary>
        /// 开启或关闭CC防护的访问频率控制规则
        /// </summary>
        /// <param name="req"><see cref="ModifyCCFrequencyRulesStatusRequest"/></param>
        /// <returns><see cref="ModifyCCFrequencyRulesStatusResponse"/></returns>
        public ModifyCCFrequencyRulesStatusResponse ModifyCCFrequencyRulesStatusSync(ModifyCCFrequencyRulesStatusRequest req)
        {
            return InternalRequestAsync<ModifyCCFrequencyRulesStatusResponse>(req, "ModifyCCFrequencyRulesStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开启或关闭CC域名防护
        /// </summary>
        /// <param name="req"><see cref="ModifyCCHostProtectionRequest"/></param>
        /// <returns><see cref="ModifyCCHostProtectionResponse"/></returns>
        public Task<ModifyCCHostProtectionResponse> ModifyCCHostProtection(ModifyCCHostProtectionRequest req)
        {
            return InternalRequestAsync<ModifyCCHostProtectionResponse>(req, "ModifyCCHostProtection");
        }

        /// <summary>
        /// 开启或关闭CC域名防护
        /// </summary>
        /// <param name="req"><see cref="ModifyCCHostProtectionRequest"/></param>
        /// <returns><see cref="ModifyCCHostProtectionResponse"/></returns>
        public ModifyCCHostProtectionResponse ModifyCCHostProtectionSync(ModifyCCHostProtectionRequest req)
        {
            return InternalRequestAsync<ModifyCCHostProtectionResponse>(req, "ModifyCCHostProtection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加或删除CC的IP黑白名单
        /// </summary>
        /// <param name="req"><see cref="ModifyCCIpAllowDenyRequest"/></param>
        /// <returns><see cref="ModifyCCIpAllowDenyResponse"/></returns>
        public Task<ModifyCCIpAllowDenyResponse> ModifyCCIpAllowDeny(ModifyCCIpAllowDenyRequest req)
        {
            return InternalRequestAsync<ModifyCCIpAllowDenyResponse>(req, "ModifyCCIpAllowDeny");
        }

        /// <summary>
        /// 添加或删除CC的IP黑白名单
        /// </summary>
        /// <param name="req"><see cref="ModifyCCIpAllowDenyRequest"/></param>
        /// <returns><see cref="ModifyCCIpAllowDenyResponse"/></returns>
        public ModifyCCIpAllowDenyResponse ModifyCCIpAllowDenySync(ModifyCCIpAllowDenyRequest req)
        {
            return InternalRequestAsync<ModifyCCIpAllowDenyResponse>(req, "ModifyCCIpAllowDeny")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改CC防护等级
        /// </summary>
        /// <param name="req"><see cref="ModifyCCLevelRequest"/></param>
        /// <returns><see cref="ModifyCCLevelResponse"/></returns>
        public Task<ModifyCCLevelResponse> ModifyCCLevel(ModifyCCLevelRequest req)
        {
            return InternalRequestAsync<ModifyCCLevelResponse>(req, "ModifyCCLevel");
        }

        /// <summary>
        /// 修改CC防护等级
        /// </summary>
        /// <param name="req"><see cref="ModifyCCLevelRequest"/></param>
        /// <returns><see cref="ModifyCCLevelResponse"/></returns>
        public ModifyCCLevelResponse ModifyCCLevelSync(ModifyCCLevelRequest req)
        {
            return InternalRequestAsync<ModifyCCLevelResponse>(req, "ModifyCCLevel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改CC自定义策略开关
        /// </summary>
        /// <param name="req"><see cref="ModifyCCPolicySwitchRequest"/></param>
        /// <returns><see cref="ModifyCCPolicySwitchResponse"/></returns>
        public Task<ModifyCCPolicySwitchResponse> ModifyCCPolicySwitch(ModifyCCPolicySwitchRequest req)
        {
            return InternalRequestAsync<ModifyCCPolicySwitchResponse>(req, "ModifyCCPolicySwitch");
        }

        /// <summary>
        /// 修改CC自定义策略开关
        /// </summary>
        /// <param name="req"><see cref="ModifyCCPolicySwitchRequest"/></param>
        /// <returns><see cref="ModifyCCPolicySwitchResponse"/></returns>
        public ModifyCCPolicySwitchResponse ModifyCCPolicySwitchSync(ModifyCCPolicySwitchRequest req)
        {
            return InternalRequestAsync<ModifyCCPolicySwitchResponse>(req, "ModifyCCPolicySwitch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改CC自定义策略
        /// </summary>
        /// <param name="req"><see cref="ModifyCCSelfDefinePolicyRequest"/></param>
        /// <returns><see cref="ModifyCCSelfDefinePolicyResponse"/></returns>
        public Task<ModifyCCSelfDefinePolicyResponse> ModifyCCSelfDefinePolicy(ModifyCCSelfDefinePolicyRequest req)
        {
            return InternalRequestAsync<ModifyCCSelfDefinePolicyResponse>(req, "ModifyCCSelfDefinePolicy");
        }

        /// <summary>
        /// 修改CC自定义策略
        /// </summary>
        /// <param name="req"><see cref="ModifyCCSelfDefinePolicyRequest"/></param>
        /// <returns><see cref="ModifyCCSelfDefinePolicyResponse"/></returns>
        public ModifyCCSelfDefinePolicyResponse ModifyCCSelfDefinePolicySync(ModifyCCSelfDefinePolicyRequest req)
        {
            return InternalRequestAsync<ModifyCCSelfDefinePolicyResponse>(req, "ModifyCCSelfDefinePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改CC的防护阈值
        /// </summary>
        /// <param name="req"><see cref="ModifyCCThresholdRequest"/></param>
        /// <returns><see cref="ModifyCCThresholdResponse"/></returns>
        public Task<ModifyCCThresholdResponse> ModifyCCThreshold(ModifyCCThresholdRequest req)
        {
            return InternalRequestAsync<ModifyCCThresholdResponse>(req, "ModifyCCThreshold");
        }

        /// <summary>
        /// 修改CC的防护阈值
        /// </summary>
        /// <param name="req"><see cref="ModifyCCThresholdRequest"/></param>
        /// <returns><see cref="ModifyCCThresholdResponse"/></returns>
        public ModifyCCThresholdResponse ModifyCCThresholdSync(ModifyCCThresholdRequest req)
        {
            return InternalRequestAsync<ModifyCCThresholdResponse>(req, "ModifyCCThreshold")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加或删除CC的URL白名单
        /// </summary>
        /// <param name="req"><see cref="ModifyCCUrlAllowRequest"/></param>
        /// <returns><see cref="ModifyCCUrlAllowResponse"/></returns>
        public Task<ModifyCCUrlAllowResponse> ModifyCCUrlAllow(ModifyCCUrlAllowRequest req)
        {
            return InternalRequestAsync<ModifyCCUrlAllowResponse>(req, "ModifyCCUrlAllow");
        }

        /// <summary>
        /// 添加或删除CC的URL白名单
        /// </summary>
        /// <param name="req"><see cref="ModifyCCUrlAllowRequest"/></param>
        /// <returns><see cref="ModifyCCUrlAllowResponse"/></returns>
        public ModifyCCUrlAllowResponse ModifyCCUrlAllowSync(ModifyCCUrlAllowRequest req)
        {
            return InternalRequestAsync<ModifyCCUrlAllowResponse>(req, "ModifyCCUrlAllow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 读取或修改DDoS的AI防护状态
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSAIStatusRequest"/></param>
        /// <returns><see cref="ModifyDDoSAIStatusResponse"/></returns>
        public Task<ModifyDDoSAIStatusResponse> ModifyDDoSAIStatus(ModifyDDoSAIStatusRequest req)
        {
            return InternalRequestAsync<ModifyDDoSAIStatusResponse>(req, "ModifyDDoSAIStatus");
        }

        /// <summary>
        /// 读取或修改DDoS的AI防护状态
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSAIStatusRequest"/></param>
        /// <returns><see cref="ModifyDDoSAIStatusResponse"/></returns>
        public ModifyDDoSAIStatusResponse ModifyDDoSAIStatusSync(ModifyDDoSAIStatusRequest req)
        {
            return InternalRequestAsync<ModifyDDoSAIStatusResponse>(req, "ModifyDDoSAIStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 为高防包、高防IP、高防IP专业版、棋牌盾等产品设置DDoS攻击的告警通知阈值
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSAlarmThresholdRequest"/></param>
        /// <returns><see cref="ModifyDDoSAlarmThresholdResponse"/></returns>
        public Task<ModifyDDoSAlarmThresholdResponse> ModifyDDoSAlarmThreshold(ModifyDDoSAlarmThresholdRequest req)
        {
            return InternalRequestAsync<ModifyDDoSAlarmThresholdResponse>(req, "ModifyDDoSAlarmThreshold");
        }

        /// <summary>
        /// 为高防包、高防IP、高防IP专业版、棋牌盾等产品设置DDoS攻击的告警通知阈值
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSAlarmThresholdRequest"/></param>
        /// <returns><see cref="ModifyDDoSAlarmThresholdResponse"/></returns>
        public ModifyDDoSAlarmThresholdResponse ModifyDDoSAlarmThresholdSync(ModifyDDoSAlarmThresholdRequest req)
        {
            return InternalRequestAsync<ModifyDDoSAlarmThresholdResponse>(req, "ModifyDDoSAlarmThreshold")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开启或关闭DDoS防护状态，调用此接口允许临时关闭DDoS防护一段时间，等时间到了会自动开启DDoS防护；
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSDefendStatusRequest"/></param>
        /// <returns><see cref="ModifyDDoSDefendStatusResponse"/></returns>
        public Task<ModifyDDoSDefendStatusResponse> ModifyDDoSDefendStatus(ModifyDDoSDefendStatusRequest req)
        {
            return InternalRequestAsync<ModifyDDoSDefendStatusResponse>(req, "ModifyDDoSDefendStatus");
        }

        /// <summary>
        /// 开启或关闭DDoS防护状态，调用此接口允许临时关闭DDoS防护一段时间，等时间到了会自动开启DDoS防护；
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSDefendStatusRequest"/></param>
        /// <returns><see cref="ModifyDDoSDefendStatusResponse"/></returns>
        public ModifyDDoSDefendStatusResponse ModifyDDoSDefendStatusSync(ModifyDDoSDefendStatusRequest req)
        {
            return InternalRequestAsync<ModifyDDoSDefendStatusResponse>(req, "ModifyDDoSDefendStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 读取或修改DDoS的防护等级
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSLevelRequest"/></param>
        /// <returns><see cref="ModifyDDoSLevelResponse"/></returns>
        public Task<ModifyDDoSLevelResponse> ModifyDDoSLevel(ModifyDDoSLevelRequest req)
        {
            return InternalRequestAsync<ModifyDDoSLevelResponse>(req, "ModifyDDoSLevel");
        }

        /// <summary>
        /// 读取或修改DDoS的防护等级
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSLevelRequest"/></param>
        /// <returns><see cref="ModifyDDoSLevelResponse"/></returns>
        public ModifyDDoSLevelResponse ModifyDDoSLevelSync(ModifyDDoSLevelRequest req)
        {
            return InternalRequestAsync<ModifyDDoSLevelResponse>(req, "ModifyDDoSLevel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改DDoS高级策略
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSPolicyRequest"/></param>
        /// <returns><see cref="ModifyDDoSPolicyResponse"/></returns>
        public Task<ModifyDDoSPolicyResponse> ModifyDDoSPolicy(ModifyDDoSPolicyRequest req)
        {
            return InternalRequestAsync<ModifyDDoSPolicyResponse>(req, "ModifyDDoSPolicy");
        }

        /// <summary>
        /// 修改DDoS高级策略
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSPolicyRequest"/></param>
        /// <returns><see cref="ModifyDDoSPolicyResponse"/></returns>
        public ModifyDDoSPolicyResponse ModifyDDoSPolicySync(ModifyDDoSPolicyRequest req)
        {
            return InternalRequestAsync<ModifyDDoSPolicyResponse>(req, "ModifyDDoSPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改策略场景
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSPolicyCaseRequest"/></param>
        /// <returns><see cref="ModifyDDoSPolicyCaseResponse"/></returns>
        public Task<ModifyDDoSPolicyCaseResponse> ModifyDDoSPolicyCase(ModifyDDoSPolicyCaseRequest req)
        {
            return InternalRequestAsync<ModifyDDoSPolicyCaseResponse>(req, "ModifyDDoSPolicyCase");
        }

        /// <summary>
        /// 修改策略场景
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSPolicyCaseRequest"/></param>
        /// <returns><see cref="ModifyDDoSPolicyCaseResponse"/></returns>
        public ModifyDDoSPolicyCaseResponse ModifyDDoSPolicyCaseSync(ModifyDDoSPolicyCaseRequest req)
        {
            return InternalRequestAsync<ModifyDDoSPolicyCaseResponse>(req, "ModifyDDoSPolicyCase")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改DDoS高级策略名称
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSPolicyNameRequest"/></param>
        /// <returns><see cref="ModifyDDoSPolicyNameResponse"/></returns>
        public Task<ModifyDDoSPolicyNameResponse> ModifyDDoSPolicyName(ModifyDDoSPolicyNameRequest req)
        {
            return InternalRequestAsync<ModifyDDoSPolicyNameResponse>(req, "ModifyDDoSPolicyName");
        }

        /// <summary>
        /// 修改DDoS高级策略名称
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSPolicyNameRequest"/></param>
        /// <returns><see cref="ModifyDDoSPolicyNameResponse"/></returns>
        public ModifyDDoSPolicyNameResponse ModifyDDoSPolicyNameSync(ModifyDDoSPolicyNameRequest req)
        {
            return InternalRequestAsync<ModifyDDoSPolicyNameResponse>(req, "ModifyDDoSPolicyName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开启或关闭DDoS防护，只支持基础防护产品；
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSSwitchRequest"/></param>
        /// <returns><see cref="ModifyDDoSSwitchResponse"/></returns>
        public Task<ModifyDDoSSwitchResponse> ModifyDDoSSwitch(ModifyDDoSSwitchRequest req)
        {
            return InternalRequestAsync<ModifyDDoSSwitchResponse>(req, "ModifyDDoSSwitch");
        }

        /// <summary>
        /// 开启或关闭DDoS防护，只支持基础防护产品；
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSSwitchRequest"/></param>
        /// <returns><see cref="ModifyDDoSSwitchResponse"/></returns>
        public ModifyDDoSSwitchResponse ModifyDDoSSwitchSync(ModifyDDoSSwitchRequest req)
        {
            return InternalRequestAsync<ModifyDDoSSwitchResponse>(req, "ModifyDDoSSwitch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改DDoS清洗阈值
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSThresholdRequest"/></param>
        /// <returns><see cref="ModifyDDoSThresholdResponse"/></returns>
        public Task<ModifyDDoSThresholdResponse> ModifyDDoSThreshold(ModifyDDoSThresholdRequest req)
        {
            return InternalRequestAsync<ModifyDDoSThresholdResponse>(req, "ModifyDDoSThreshold");
        }

        /// <summary>
        /// 修改DDoS清洗阈值
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSThresholdRequest"/></param>
        /// <returns><see cref="ModifyDDoSThresholdResponse"/></returns>
        public ModifyDDoSThresholdResponse ModifyDDoSThresholdSync(ModifyDDoSThresholdRequest req)
        {
            return InternalRequestAsync<ModifyDDoSThresholdResponse>(req, "ModifyDDoSThreshold")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 支持水印密钥的添加，删除，开启，关闭
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSWaterKeyRequest"/></param>
        /// <returns><see cref="ModifyDDoSWaterKeyResponse"/></returns>
        public Task<ModifyDDoSWaterKeyResponse> ModifyDDoSWaterKey(ModifyDDoSWaterKeyRequest req)
        {
            return InternalRequestAsync<ModifyDDoSWaterKeyResponse>(req, "ModifyDDoSWaterKey");
        }

        /// <summary>
        /// 支持水印密钥的添加，删除，开启，关闭
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSWaterKeyRequest"/></param>
        /// <returns><see cref="ModifyDDoSWaterKeyResponse"/></returns>
        public ModifyDDoSWaterKeyResponse ModifyDDoSWaterKeySync(ModifyDDoSWaterKeyRequest req)
        {
            return InternalRequestAsync<ModifyDDoSWaterKeyResponse>(req, "ModifyDDoSWaterKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改弹性防护阈值
        /// </summary>
        /// <param name="req"><see cref="ModifyElasticLimitRequest"/></param>
        /// <returns><see cref="ModifyElasticLimitResponse"/></returns>
        public Task<ModifyElasticLimitResponse> ModifyElasticLimit(ModifyElasticLimitRequest req)
        {
            return InternalRequestAsync<ModifyElasticLimitResponse>(req, "ModifyElasticLimit");
        }

        /// <summary>
        /// 修改弹性防护阈值
        /// </summary>
        /// <param name="req"><see cref="ModifyElasticLimitRequest"/></param>
        /// <returns><see cref="ModifyElasticLimitResponse"/></returns>
        public ModifyElasticLimitResponse ModifyElasticLimitSync(ModifyElasticLimitRequest req)
        {
            return InternalRequestAsync<ModifyElasticLimitResponse>(req, "ModifyElasticLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改L4转发规则健康检查参数，支持的子产品：高防IP、高防IP专业版
        /// </summary>
        /// <param name="req"><see cref="ModifyL4HealthRequest"/></param>
        /// <returns><see cref="ModifyL4HealthResponse"/></returns>
        public Task<ModifyL4HealthResponse> ModifyL4Health(ModifyL4HealthRequest req)
        {
            return InternalRequestAsync<ModifyL4HealthResponse>(req, "ModifyL4Health");
        }

        /// <summary>
        /// 修改L4转发规则健康检查参数，支持的子产品：高防IP、高防IP专业版
        /// </summary>
        /// <param name="req"><see cref="ModifyL4HealthRequest"/></param>
        /// <returns><see cref="ModifyL4HealthResponse"/></returns>
        public ModifyL4HealthResponse ModifyL4HealthSync(ModifyL4HealthRequest req)
        {
            return InternalRequestAsync<ModifyL4HealthResponse>(req, "ModifyL4Health")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改L4转发规则的会话保持，支持的子产品：高防IP、高防IP专业版
        /// </summary>
        /// <param name="req"><see cref="ModifyL4KeepTimeRequest"/></param>
        /// <returns><see cref="ModifyL4KeepTimeResponse"/></returns>
        public Task<ModifyL4KeepTimeResponse> ModifyL4KeepTime(ModifyL4KeepTimeRequest req)
        {
            return InternalRequestAsync<ModifyL4KeepTimeResponse>(req, "ModifyL4KeepTime");
        }

        /// <summary>
        /// 修改L4转发规则的会话保持，支持的子产品：高防IP、高防IP专业版
        /// </summary>
        /// <param name="req"><see cref="ModifyL4KeepTimeRequest"/></param>
        /// <returns><see cref="ModifyL4KeepTimeResponse"/></returns>
        public ModifyL4KeepTimeResponse ModifyL4KeepTimeSync(ModifyL4KeepTimeRequest req)
        {
            return InternalRequestAsync<ModifyL4KeepTimeResponse>(req, "ModifyL4KeepTime")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改L4转发规则
        /// </summary>
        /// <param name="req"><see cref="ModifyL4RulesRequest"/></param>
        /// <returns><see cref="ModifyL4RulesResponse"/></returns>
        public Task<ModifyL4RulesResponse> ModifyL4Rules(ModifyL4RulesRequest req)
        {
            return InternalRequestAsync<ModifyL4RulesResponse>(req, "ModifyL4Rules");
        }

        /// <summary>
        /// 修改L4转发规则
        /// </summary>
        /// <param name="req"><see cref="ModifyL4RulesRequest"/></param>
        /// <returns><see cref="ModifyL4RulesResponse"/></returns>
        public ModifyL4RulesResponse ModifyL4RulesSync(ModifyL4RulesRequest req)
        {
            return InternalRequestAsync<ModifyL4RulesResponse>(req, "ModifyL4Rules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改L7转发规则
        /// </summary>
        /// <param name="req"><see cref="ModifyL7RulesRequest"/></param>
        /// <returns><see cref="ModifyL7RulesResponse"/></returns>
        public Task<ModifyL7RulesResponse> ModifyL7Rules(ModifyL7RulesRequest req)
        {
            return InternalRequestAsync<ModifyL7RulesResponse>(req, "ModifyL7Rules");
        }

        /// <summary>
        /// 修改L7转发规则
        /// </summary>
        /// <param name="req"><see cref="ModifyL7RulesRequest"/></param>
        /// <returns><see cref="ModifyL7RulesResponse"/></returns>
        public ModifyL7RulesResponse ModifyL7RulesSync(ModifyL7RulesRequest req)
        {
            return InternalRequestAsync<ModifyL7RulesResponse>(req, "ModifyL7Rules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在客户收攻击或者被封堵时，切回到源站，并设置回切的时长
        /// </summary>
        /// <param name="req"><see cref="ModifyNetReturnSwitchRequest"/></param>
        /// <returns><see cref="ModifyNetReturnSwitchResponse"/></returns>
        public Task<ModifyNetReturnSwitchResponse> ModifyNetReturnSwitch(ModifyNetReturnSwitchRequest req)
        {
            return InternalRequestAsync<ModifyNetReturnSwitchResponse>(req, "ModifyNetReturnSwitch");
        }

        /// <summary>
        /// 在客户收攻击或者被封堵时，切回到源站，并设置回切的时长
        /// </summary>
        /// <param name="req"><see cref="ModifyNetReturnSwitchRequest"/></param>
        /// <returns><see cref="ModifyNetReturnSwitchResponse"/></returns>
        public ModifyNetReturnSwitchResponse ModifyNetReturnSwitchSync(ModifyNetReturnSwitchRequest req)
        {
            return InternalRequestAsync<ModifyNetReturnSwitchResponse>(req, "ModifyNetReturnSwitch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改7层转发规则
        /// </summary>
        /// <param name="req"><see cref="ModifyNewDomainRulesRequest"/></param>
        /// <returns><see cref="ModifyNewDomainRulesResponse"/></returns>
        public Task<ModifyNewDomainRulesResponse> ModifyNewDomainRules(ModifyNewDomainRulesRequest req)
        {
            return InternalRequestAsync<ModifyNewDomainRulesResponse>(req, "ModifyNewDomainRules");
        }

        /// <summary>
        /// 修改7层转发规则
        /// </summary>
        /// <param name="req"><see cref="ModifyNewDomainRulesRequest"/></param>
        /// <returns><see cref="ModifyNewDomainRulesResponse"/></returns>
        public ModifyNewDomainRulesResponse ModifyNewDomainRulesSync(ModifyNewDomainRulesRequest req)
        {
            return InternalRequestAsync<ModifyNewDomainRulesResponse>(req, "ModifyNewDomainRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改4层转发规则
        /// </summary>
        /// <param name="req"><see cref="ModifyNewL4RuleRequest"/></param>
        /// <returns><see cref="ModifyNewL4RuleResponse"/></returns>
        public Task<ModifyNewL4RuleResponse> ModifyNewL4Rule(ModifyNewL4RuleRequest req)
        {
            return InternalRequestAsync<ModifyNewL4RuleResponse>(req, "ModifyNewL4Rule");
        }

        /// <summary>
        /// 修改4层转发规则
        /// </summary>
        /// <param name="req"><see cref="ModifyNewL4RuleRequest"/></param>
        /// <returns><see cref="ModifyNewL4RuleResponse"/></returns>
        public ModifyNewL4RuleResponse ModifyNewL4RuleSync(ModifyNewL4RuleRequest req)
        {
            return InternalRequestAsync<ModifyNewL4RuleResponse>(req, "ModifyNewL4Rule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 资源实例绑定DDoS高级策略
        /// </summary>
        /// <param name="req"><see cref="ModifyResBindDDoSPolicyRequest"/></param>
        /// <returns><see cref="ModifyResBindDDoSPolicyResponse"/></returns>
        public Task<ModifyResBindDDoSPolicyResponse> ModifyResBindDDoSPolicy(ModifyResBindDDoSPolicyRequest req)
        {
            return InternalRequestAsync<ModifyResBindDDoSPolicyResponse>(req, "ModifyResBindDDoSPolicy");
        }

        /// <summary>
        /// 资源实例绑定DDoS高级策略
        /// </summary>
        /// <param name="req"><see cref="ModifyResBindDDoSPolicyRequest"/></param>
        /// <returns><see cref="ModifyResBindDDoSPolicyResponse"/></returns>
        public ModifyResBindDDoSPolicyResponse ModifyResBindDDoSPolicySync(ModifyResBindDDoSPolicyRequest req)
        {
            return InternalRequestAsync<ModifyResBindDDoSPolicyResponse>(req, "ModifyResBindDDoSPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改资源自动续费标记
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyResourceRenewFlagResponse"/></returns>
        public Task<ModifyResourceRenewFlagResponse> ModifyResourceRenewFlag(ModifyResourceRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyResourceRenewFlagResponse>(req, "ModifyResourceRenewFlag");
        }

        /// <summary>
        /// 修改资源自动续费标记
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyResourceRenewFlagResponse"/></returns>
        public ModifyResourceRenewFlagResponse ModifyResourceRenewFlagSync(ModifyResourceRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyResourceRenewFlagResponse>(req, "ModifyResourceRenewFlag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}

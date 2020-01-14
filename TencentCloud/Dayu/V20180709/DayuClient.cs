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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DayuClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 设置基础防护的DDoS告警阈值，只支持基础防护产品
        /// </summary>
        /// <param name="req"><see cref="CreateBasicDDoSAlarmThresholdRequest"/></param>
        /// <returns><see cref="CreateBasicDDoSAlarmThresholdResponse"/></returns>
        public async Task<CreateBasicDDoSAlarmThresholdResponse> CreateBasicDDoSAlarmThreshold(CreateBasicDDoSAlarmThresholdRequest req)
        {
             JsonResponseModel<CreateBasicDDoSAlarmThresholdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBasicDDoSAlarmThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBasicDDoSAlarmThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateBasicDDoSAlarmThreshold接口的同步版本，设置基础防护的DDoS告警阈值，只支持基础防护产品
        /// </summary>
        /// <param name="req">参考<see cref="CreateBasicDDoSAlarmThresholdRequest"/></param>
        /// <returns>参考<see cref="CreateBasicDDoSAlarmThresholdResponse"/>实例</returns>
        public CreateBasicDDoSAlarmThresholdResponse CreateBasicDDoSAlarmThresholdSync(CreateBasicDDoSAlarmThresholdRequest req)
        {
             JsonResponseModel<CreateBasicDDoSAlarmThresholdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBasicDDoSAlarmThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBasicDDoSAlarmThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建CC自定义策略
        /// </summary>
        /// <param name="req"><see cref="CreateCCSelfDefinePolicyRequest"/></param>
        /// <returns><see cref="CreateCCSelfDefinePolicyResponse"/></returns>
        public async Task<CreateCCSelfDefinePolicyResponse> CreateCCSelfDefinePolicy(CreateCCSelfDefinePolicyRequest req)
        {
             JsonResponseModel<CreateCCSelfDefinePolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCCSelfDefinePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCCSelfDefinePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateCCSelfDefinePolicy接口的同步版本，创建CC自定义策略
        /// </summary>
        /// <param name="req">参考<see cref="CreateCCSelfDefinePolicyRequest"/></param>
        /// <returns>参考<see cref="CreateCCSelfDefinePolicyResponse"/>实例</returns>
        public CreateCCSelfDefinePolicyResponse CreateCCSelfDefinePolicySync(CreateCCSelfDefinePolicyRequest req)
        {
             JsonResponseModel<CreateCCSelfDefinePolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCCSelfDefinePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCCSelfDefinePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加DDoS高级策略
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSPolicyRequest"/></param>
        /// <returns><see cref="CreateDDoSPolicyResponse"/></returns>
        public async Task<CreateDDoSPolicyResponse> CreateDDoSPolicy(CreateDDoSPolicyRequest req)
        {
             JsonResponseModel<CreateDDoSPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDDoSPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDDoSPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateDDoSPolicy接口的同步版本，添加DDoS高级策略
        /// </summary>
        /// <param name="req">参考<see cref="CreateDDoSPolicyRequest"/></param>
        /// <returns>参考<see cref="CreateDDoSPolicyResponse"/>实例</returns>
        public CreateDDoSPolicyResponse CreateDDoSPolicySync(CreateDDoSPolicyRequest req)
        {
             JsonResponseModel<CreateDDoSPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDDoSPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDDoSPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加策略场景
        /// </summary>
        /// <param name="req"><see cref="CreateDDoSPolicyCaseRequest"/></param>
        /// <returns><see cref="CreateDDoSPolicyCaseResponse"/></returns>
        public async Task<CreateDDoSPolicyCaseResponse> CreateDDoSPolicyCase(CreateDDoSPolicyCaseRequest req)
        {
             JsonResponseModel<CreateDDoSPolicyCaseResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDDoSPolicyCase");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDDoSPolicyCaseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateDDoSPolicyCase接口的同步版本，添加策略场景
        /// </summary>
        /// <param name="req">参考<see cref="CreateDDoSPolicyCaseRequest"/></param>
        /// <returns>参考<see cref="CreateDDoSPolicyCaseResponse"/>实例</returns>
        public CreateDDoSPolicyCaseResponse CreateDDoSPolicyCaseSync(CreateDDoSPolicyCaseRequest req)
        {
             JsonResponseModel<CreateDDoSPolicyCaseResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDDoSPolicyCase");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDDoSPolicyCaseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 资源实例重命名，支持独享包、共享包、高防IP、高防IP专业版、棋牌盾；
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceNameRequest"/></param>
        /// <returns><see cref="CreateInstanceNameResponse"/></returns>
        public async Task<CreateInstanceNameResponse> CreateInstanceName(CreateInstanceNameRequest req)
        {
             JsonResponseModel<CreateInstanceNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateInstanceName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstanceNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateInstanceName接口的同步版本，资源实例重命名，支持独享包、共享包、高防IP、高防IP专业版、棋牌盾；
        /// </summary>
        /// <param name="req">参考<see cref="CreateInstanceNameRequest"/></param>
        /// <returns>参考<see cref="CreateInstanceNameResponse"/>实例</returns>
        public CreateInstanceNameResponse CreateInstanceNameSync(CreateInstanceNameRequest req)
        {
             JsonResponseModel<CreateInstanceNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateInstanceName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstanceNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上传四层健康检查配置
        /// </summary>
        /// <param name="req"><see cref="CreateL4HealthConfigRequest"/></param>
        /// <returns><see cref="CreateL4HealthConfigResponse"/></returns>
        public async Task<CreateL4HealthConfigResponse> CreateL4HealthConfig(CreateL4HealthConfigRequest req)
        {
             JsonResponseModel<CreateL4HealthConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateL4HealthConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateL4HealthConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateL4HealthConfig接口的同步版本，上传四层健康检查配置
        /// </summary>
        /// <param name="req">参考<see cref="CreateL4HealthConfigRequest"/></param>
        /// <returns>参考<see cref="CreateL4HealthConfigResponse"/>实例</returns>
        public CreateL4HealthConfigResponse CreateL4HealthConfigSync(CreateL4HealthConfigRequest req)
        {
             JsonResponseModel<CreateL4HealthConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateL4HealthConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateL4HealthConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加L4转发规则
        /// </summary>
        /// <param name="req"><see cref="CreateL4RulesRequest"/></param>
        /// <returns><see cref="CreateL4RulesResponse"/></returns>
        public async Task<CreateL4RulesResponse> CreateL4Rules(CreateL4RulesRequest req)
        {
             JsonResponseModel<CreateL4RulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateL4Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateL4RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateL4Rules接口的同步版本，添加L4转发规则
        /// </summary>
        /// <param name="req">参考<see cref="CreateL4RulesRequest"/></param>
        /// <returns>参考<see cref="CreateL4RulesResponse"/>实例</returns>
        public CreateL4RulesResponse CreateL4RulesSync(CreateL4RulesRequest req)
        {
             JsonResponseModel<CreateL4RulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateL4Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateL4RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 支持读取，添加，删除7层CC自定义规则
        /// </summary>
        /// <param name="req"><see cref="CreateL7CCRuleRequest"/></param>
        /// <returns><see cref="CreateL7CCRuleResponse"/></returns>
        public async Task<CreateL7CCRuleResponse> CreateL7CCRule(CreateL7CCRuleRequest req)
        {
             JsonResponseModel<CreateL7CCRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateL7CCRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateL7CCRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateL7CCRule接口的同步版本，支持读取，添加，删除7层CC自定义规则
        /// </summary>
        /// <param name="req">参考<see cref="CreateL7CCRuleRequest"/></param>
        /// <returns>参考<see cref="CreateL7CCRuleResponse"/>实例</returns>
        public CreateL7CCRuleResponse CreateL7CCRuleSync(CreateL7CCRuleRequest req)
        {
             JsonResponseModel<CreateL7CCRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateL7CCRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateL7CCRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 上传七层健康检查配置
        /// </summary>
        /// <param name="req"><see cref="CreateL7HealthConfigRequest"/></param>
        /// <returns><see cref="CreateL7HealthConfigResponse"/></returns>
        public async Task<CreateL7HealthConfigResponse> CreateL7HealthConfig(CreateL7HealthConfigRequest req)
        {
             JsonResponseModel<CreateL7HealthConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateL7HealthConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateL7HealthConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateL7HealthConfig接口的同步版本，上传七层健康检查配置
        /// </summary>
        /// <param name="req">参考<see cref="CreateL7HealthConfigRequest"/></param>
        /// <returns>参考<see cref="CreateL7HealthConfigResponse"/>实例</returns>
        public CreateL7HealthConfigResponse CreateL7HealthConfigSync(CreateL7HealthConfigRequest req)
        {
             JsonResponseModel<CreateL7HealthConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateL7HealthConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateL7HealthConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 配置7层转发规则的证书
        /// </summary>
        /// <param name="req"><see cref="CreateL7RuleCertRequest"/></param>
        /// <returns><see cref="CreateL7RuleCertResponse"/></returns>
        public async Task<CreateL7RuleCertResponse> CreateL7RuleCert(CreateL7RuleCertRequest req)
        {
             JsonResponseModel<CreateL7RuleCertResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateL7RuleCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateL7RuleCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateL7RuleCert接口的同步版本，配置7层转发规则的证书
        /// </summary>
        /// <param name="req">参考<see cref="CreateL7RuleCertRequest"/></param>
        /// <returns>参考<see cref="CreateL7RuleCertResponse"/>实例</returns>
        public CreateL7RuleCertResponse CreateL7RuleCertSync(CreateL7RuleCertRequest req)
        {
             JsonResponseModel<CreateL7RuleCertResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateL7RuleCert");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateL7RuleCertResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加7层(网站)转发规则
        /// </summary>
        /// <param name="req"><see cref="CreateL7RulesRequest"/></param>
        /// <returns><see cref="CreateL7RulesResponse"/></returns>
        public async Task<CreateL7RulesResponse> CreateL7Rules(CreateL7RulesRequest req)
        {
             JsonResponseModel<CreateL7RulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateL7Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateL7RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateL7Rules接口的同步版本，添加7层(网站)转发规则
        /// </summary>
        /// <param name="req">参考<see cref="CreateL7RulesRequest"/></param>
        /// <returns>参考<see cref="CreateL7RulesResponse"/>实例</returns>
        public CreateL7RulesResponse CreateL7RulesSync(CreateL7RulesRequest req)
        {
             JsonResponseModel<CreateL7RulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateL7Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateL7RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量上传7层转发规则
        /// </summary>
        /// <param name="req"><see cref="CreateL7RulesUploadRequest"/></param>
        /// <returns><see cref="CreateL7RulesUploadResponse"/></returns>
        public async Task<CreateL7RulesUploadResponse> CreateL7RulesUpload(CreateL7RulesUploadRequest req)
        {
             JsonResponseModel<CreateL7RulesUploadResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateL7RulesUpload");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateL7RulesUploadResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateL7RulesUpload接口的同步版本，批量上传7层转发规则
        /// </summary>
        /// <param name="req">参考<see cref="CreateL7RulesUploadRequest"/></param>
        /// <returns>参考<see cref="CreateL7RulesUploadResponse"/>实例</returns>
        public CreateL7RulesUploadResponse CreateL7RulesUploadSync(CreateL7RulesUploadRequest req)
        {
             JsonResponseModel<CreateL7RulesUploadResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateL7RulesUpload");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateL7RulesUploadResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// IP解封操作
        /// </summary>
        /// <param name="req"><see cref="CreateUnblockIpRequest"/></param>
        /// <returns><see cref="CreateUnblockIpResponse"/></returns>
        public async Task<CreateUnblockIpResponse> CreateUnblockIp(CreateUnblockIpRequest req)
        {
             JsonResponseModel<CreateUnblockIpResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateUnblockIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUnblockIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateUnblockIp接口的同步版本，IP解封操作
        /// </summary>
        /// <param name="req">参考<see cref="CreateUnblockIpRequest"/></param>
        /// <returns>参考<see cref="CreateUnblockIpResponse"/>实例</returns>
        public CreateUnblockIpResponse CreateUnblockIpSync(CreateUnblockIpRequest req)
        {
             JsonResponseModel<CreateUnblockIpResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateUnblockIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUnblockIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除CC自定义策略
        /// </summary>
        /// <param name="req"><see cref="DeleteCCSelfDefinePolicyRequest"/></param>
        /// <returns><see cref="DeleteCCSelfDefinePolicyResponse"/></returns>
        public async Task<DeleteCCSelfDefinePolicyResponse> DeleteCCSelfDefinePolicy(DeleteCCSelfDefinePolicyRequest req)
        {
             JsonResponseModel<DeleteCCSelfDefinePolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCCSelfDefinePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCCSelfDefinePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteCCSelfDefinePolicy接口的同步版本，删除CC自定义策略
        /// </summary>
        /// <param name="req">参考<see cref="DeleteCCSelfDefinePolicyRequest"/></param>
        /// <returns>参考<see cref="DeleteCCSelfDefinePolicyResponse"/>实例</returns>
        public DeleteCCSelfDefinePolicyResponse DeleteCCSelfDefinePolicySync(DeleteCCSelfDefinePolicyRequest req)
        {
             JsonResponseModel<DeleteCCSelfDefinePolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCCSelfDefinePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCCSelfDefinePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除DDoS高级策略
        /// </summary>
        /// <param name="req"><see cref="DeleteDDoSPolicyRequest"/></param>
        /// <returns><see cref="DeleteDDoSPolicyResponse"/></returns>
        public async Task<DeleteDDoSPolicyResponse> DeleteDDoSPolicy(DeleteDDoSPolicyRequest req)
        {
             JsonResponseModel<DeleteDDoSPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDDoSPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDDoSPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteDDoSPolicy接口的同步版本，删除DDoS高级策略
        /// </summary>
        /// <param name="req">参考<see cref="DeleteDDoSPolicyRequest"/></param>
        /// <returns>参考<see cref="DeleteDDoSPolicyResponse"/>实例</returns>
        public DeleteDDoSPolicyResponse DeleteDDoSPolicySync(DeleteDDoSPolicyRequest req)
        {
             JsonResponseModel<DeleteDDoSPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDDoSPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDDoSPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除策略场景
        /// </summary>
        /// <param name="req"><see cref="DeleteDDoSPolicyCaseRequest"/></param>
        /// <returns><see cref="DeleteDDoSPolicyCaseResponse"/></returns>
        public async Task<DeleteDDoSPolicyCaseResponse> DeleteDDoSPolicyCase(DeleteDDoSPolicyCaseRequest req)
        {
             JsonResponseModel<DeleteDDoSPolicyCaseResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDDoSPolicyCase");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDDoSPolicyCaseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteDDoSPolicyCase接口的同步版本，删除策略场景
        /// </summary>
        /// <param name="req">参考<see cref="DeleteDDoSPolicyCaseRequest"/></param>
        /// <returns>参考<see cref="DeleteDDoSPolicyCaseResponse"/>实例</returns>
        public DeleteDDoSPolicyCaseResponse DeleteDDoSPolicyCaseSync(DeleteDDoSPolicyCaseRequest req)
        {
             JsonResponseModel<DeleteDDoSPolicyCaseResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDDoSPolicyCase");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDDoSPolicyCaseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除四层转发规则
        /// </summary>
        /// <param name="req"><see cref="DeleteL4RulesRequest"/></param>
        /// <returns><see cref="DeleteL4RulesResponse"/></returns>
        public async Task<DeleteL4RulesResponse> DeleteL4Rules(DeleteL4RulesRequest req)
        {
             JsonResponseModel<DeleteL4RulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteL4Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteL4RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteL4Rules接口的同步版本，删除四层转发规则
        /// </summary>
        /// <param name="req">参考<see cref="DeleteL4RulesRequest"/></param>
        /// <returns>参考<see cref="DeleteL4RulesResponse"/>实例</returns>
        public DeleteL4RulesResponse DeleteL4RulesSync(DeleteL4RulesRequest req)
        {
             JsonResponseModel<DeleteL4RulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteL4Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteL4RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除七层转发规则
        /// </summary>
        /// <param name="req"><see cref="DeleteL7RulesRequest"/></param>
        /// <returns><see cref="DeleteL7RulesResponse"/></returns>
        public async Task<DeleteL7RulesResponse> DeleteL7Rules(DeleteL7RulesRequest req)
        {
             JsonResponseModel<DeleteL7RulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteL7Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteL7RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DeleteL7Rules接口的同步版本，删除七层转发规则
        /// </summary>
        /// <param name="req">参考<see cref="DeleteL7RulesRequest"/></param>
        /// <returns>参考<see cref="DeleteL7RulesResponse"/>实例</returns>
        public DeleteL7RulesResponse DeleteL7RulesSync(DeleteL7RulesRequest req)
        {
             JsonResponseModel<DeleteL7RulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteL7Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteL7RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取操作日志
        /// </summary>
        /// <param name="req"><see cref="DescribeActionLogRequest"/></param>
        /// <returns><see cref="DescribeActionLogResponse"/></returns>
        public async Task<DescribeActionLogResponse> DescribeActionLog(DescribeActionLogRequest req)
        {
             JsonResponseModel<DescribeActionLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeActionLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeActionLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeActionLog接口的同步版本，获取操作日志
        /// </summary>
        /// <param name="req">参考<see cref="DescribeActionLogRequest"/></param>
        /// <returns>参考<see cref="DescribeActionLogResponse"/>实例</returns>
        public DescribeActionLogResponse DescribeActionLogSync(DescribeActionLogRequest req)
        {
             JsonResponseModel<DescribeActionLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeActionLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeActionLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 为大禹子产品提供从巴拉多获取指标统计数据的接口
        /// </summary>
        /// <param name="req"><see cref="DescribeBaradDataRequest"/></param>
        /// <returns><see cref="DescribeBaradDataResponse"/></returns>
        public async Task<DescribeBaradDataResponse> DescribeBaradData(DescribeBaradDataRequest req)
        {
             JsonResponseModel<DescribeBaradDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBaradData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaradDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeBaradData接口的同步版本，为大禹子产品提供从巴拉多获取指标统计数据的接口
        /// </summary>
        /// <param name="req">参考<see cref="DescribeBaradDataRequest"/></param>
        /// <returns>参考<see cref="DescribeBaradDataResponse"/>实例</returns>
        public DescribeBaradDataResponse DescribeBaradDataSync(DescribeBaradDataRequest req)
        {
             JsonResponseModel<DescribeBaradDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBaradData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaradDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基础防护黑洞阈值
        /// </summary>
        /// <param name="req"><see cref="DescribeBasicDeviceThresholdRequest"/></param>
        /// <returns><see cref="DescribeBasicDeviceThresholdResponse"/></returns>
        public async Task<DescribeBasicDeviceThresholdResponse> DescribeBasicDeviceThreshold(DescribeBasicDeviceThresholdRequest req)
        {
             JsonResponseModel<DescribeBasicDeviceThresholdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBasicDeviceThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBasicDeviceThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeBasicDeviceThreshold接口的同步版本，获取基础防护黑洞阈值
        /// </summary>
        /// <param name="req">参考<see cref="DescribeBasicDeviceThresholdRequest"/></param>
        /// <returns>参考<see cref="DescribeBasicDeviceThresholdResponse"/>实例</returns>
        public DescribeBasicDeviceThresholdResponse DescribeBasicDeviceThresholdSync(DescribeBasicDeviceThresholdRequest req)
        {
             JsonResponseModel<DescribeBasicDeviceThresholdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBasicDeviceThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBasicDeviceThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取高防包、高防IP、高防IP专业版、棋牌盾产品设置CC攻击的告警通知阈值
        /// </summary>
        /// <param name="req"><see cref="DescribeCCAlarmThresholdRequest"/></param>
        /// <returns><see cref="DescribeCCAlarmThresholdResponse"/></returns>
        public async Task<DescribeCCAlarmThresholdResponse> DescribeCCAlarmThreshold(DescribeCCAlarmThresholdRequest req)
        {
             JsonResponseModel<DescribeCCAlarmThresholdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCCAlarmThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCAlarmThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeCCAlarmThreshold接口的同步版本，获取高防包、高防IP、高防IP专业版、棋牌盾产品设置CC攻击的告警通知阈值
        /// </summary>
        /// <param name="req">参考<see cref="DescribeCCAlarmThresholdRequest"/></param>
        /// <returns>参考<see cref="DescribeCCAlarmThresholdResponse"/>实例</returns>
        public DescribeCCAlarmThresholdResponse DescribeCCAlarmThresholdSync(DescribeCCAlarmThresholdRequest req)
        {
             JsonResponseModel<DescribeCCAlarmThresholdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCCAlarmThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCAlarmThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取CC攻击事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCCEvListRequest"/></param>
        /// <returns><see cref="DescribeCCEvListResponse"/></returns>
        public async Task<DescribeCCEvListResponse> DescribeCCEvList(DescribeCCEvListRequest req)
        {
             JsonResponseModel<DescribeCCEvListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCCEvList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCEvListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeCCEvList接口的同步版本，获取CC攻击事件列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeCCEvListRequest"/></param>
        /// <returns>参考<see cref="DescribeCCEvListResponse"/>实例</returns>
        public DescribeCCEvListResponse DescribeCCEvListSync(DescribeCCEvListRequest req)
        {
             JsonResponseModel<DescribeCCEvListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCCEvList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCEvListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取CC的IP黑白名单
        /// </summary>
        /// <param name="req"><see cref="DescribeCCIpAllowDenyRequest"/></param>
        /// <returns><see cref="DescribeCCIpAllowDenyResponse"/></returns>
        public async Task<DescribeCCIpAllowDenyResponse> DescribeCCIpAllowDeny(DescribeCCIpAllowDenyRequest req)
        {
             JsonResponseModel<DescribeCCIpAllowDenyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCCIpAllowDeny");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCIpAllowDenyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeCCIpAllowDeny接口的同步版本，获取CC的IP黑白名单
        /// </summary>
        /// <param name="req">参考<see cref="DescribeCCIpAllowDenyRequest"/></param>
        /// <returns>参考<see cref="DescribeCCIpAllowDenyResponse"/>实例</returns>
        public DescribeCCIpAllowDenyResponse DescribeCCIpAllowDenySync(DescribeCCIpAllowDenyRequest req)
        {
             JsonResponseModel<DescribeCCIpAllowDenyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCCIpAllowDeny");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCIpAllowDenyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取CC自定义策略
        /// </summary>
        /// <param name="req"><see cref="DescribeCCSelfDefinePolicyRequest"/></param>
        /// <returns><see cref="DescribeCCSelfDefinePolicyResponse"/></returns>
        public async Task<DescribeCCSelfDefinePolicyResponse> DescribeCCSelfDefinePolicy(DescribeCCSelfDefinePolicyRequest req)
        {
             JsonResponseModel<DescribeCCSelfDefinePolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCCSelfDefinePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCSelfDefinePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeCCSelfDefinePolicy接口的同步版本，获取CC自定义策略
        /// </summary>
        /// <param name="req">参考<see cref="DescribeCCSelfDefinePolicyRequest"/></param>
        /// <returns>参考<see cref="DescribeCCSelfDefinePolicyResponse"/>实例</returns>
        public DescribeCCSelfDefinePolicyResponse DescribeCCSelfDefinePolicySync(DescribeCCSelfDefinePolicyRequest req)
        {
             JsonResponseModel<DescribeCCSelfDefinePolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCCSelfDefinePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCSelfDefinePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取CC攻击指标数据，包括总请求峰值(QPS)和攻击请求(QPS)
        /// </summary>
        /// <param name="req"><see cref="DescribeCCTrendRequest"/></param>
        /// <returns><see cref="DescribeCCTrendResponse"/></returns>
        public async Task<DescribeCCTrendResponse> DescribeCCTrend(DescribeCCTrendRequest req)
        {
             JsonResponseModel<DescribeCCTrendResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCCTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeCCTrend接口的同步版本，获取CC攻击指标数据，包括总请求峰值(QPS)和攻击请求(QPS)
        /// </summary>
        /// <param name="req">参考<see cref="DescribeCCTrendRequest"/></param>
        /// <returns>参考<see cref="DescribeCCTrendResponse"/>实例</returns>
        public DescribeCCTrendResponse DescribeCCTrendSync(DescribeCCTrendRequest req)
        {
             JsonResponseModel<DescribeCCTrendResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCCTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取CC的Url白名单
        /// </summary>
        /// <param name="req"><see cref="DescribeCCUrlAllowRequest"/></param>
        /// <returns><see cref="DescribeCCUrlAllowResponse"/></returns>
        public async Task<DescribeCCUrlAllowResponse> DescribeCCUrlAllow(DescribeCCUrlAllowRequest req)
        {
             JsonResponseModel<DescribeCCUrlAllowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCCUrlAllow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCUrlAllowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeCCUrlAllow接口的同步版本，获取CC的Url白名单
        /// </summary>
        /// <param name="req">参考<see cref="DescribeCCUrlAllowRequest"/></param>
        /// <returns>参考<see cref="DescribeCCUrlAllowResponse"/>实例</returns>
        public DescribeCCUrlAllowResponse DescribeCCUrlAllowSync(DescribeCCUrlAllowRequest req)
        {
             JsonResponseModel<DescribeCCUrlAllowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCCUrlAllow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCCUrlAllowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取高防包、高防IP、高防IP专业版、棋牌盾产品设置DDoS攻击的告警通知阈值
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAlarmThresholdRequest"/></param>
        /// <returns><see cref="DescribeDDoSAlarmThresholdResponse"/></returns>
        public async Task<DescribeDDoSAlarmThresholdResponse> DescribeDDoSAlarmThreshold(DescribeDDoSAlarmThresholdRequest req)
        {
             JsonResponseModel<DescribeDDoSAlarmThresholdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSAlarmThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSAlarmThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDDoSAlarmThreshold接口的同步版本，获取高防包、高防IP、高防IP专业版、棋牌盾产品设置DDoS攻击的告警通知阈值
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDDoSAlarmThresholdRequest"/></param>
        /// <returns>参考<see cref="DescribeDDoSAlarmThresholdResponse"/>实例</returns>
        public DescribeDDoSAlarmThresholdResponse DescribeDDoSAlarmThresholdSync(DescribeDDoSAlarmThresholdRequest req)
        {
             JsonResponseModel<DescribeDDoSAlarmThresholdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSAlarmThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSAlarmThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DDoS攻击源列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSAttackSourceRequest"/></param>
        /// <returns><see cref="DescribeDDoSAttackSourceResponse"/></returns>
        public async Task<DescribeDDoSAttackSourceResponse> DescribeDDoSAttackSource(DescribeDDoSAttackSourceRequest req)
        {
             JsonResponseModel<DescribeDDoSAttackSourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSAttackSource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSAttackSourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDDoSAttackSource接口的同步版本，获取DDoS攻击源列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDDoSAttackSourceRequest"/></param>
        /// <returns>参考<see cref="DescribeDDoSAttackSourceResponse"/>实例</returns>
        public DescribeDDoSAttackSourceResponse DescribeDDoSAttackSourceSync(DescribeDDoSAttackSourceRequest req)
        {
             JsonResponseModel<DescribeDDoSAttackSourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSAttackSource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSAttackSourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DDoS攻击占比分析
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSCountRequest"/></param>
        /// <returns><see cref="DescribeDDoSCountResponse"/></returns>
        public async Task<DescribeDDoSCountResponse> DescribeDDoSCount(DescribeDDoSCountRequest req)
        {
             JsonResponseModel<DescribeDDoSCountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDDoSCount接口的同步版本，获取DDoS攻击占比分析
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDDoSCountRequest"/></param>
        /// <returns>参考<see cref="DescribeDDoSCountResponse"/>实例</returns>
        public DescribeDDoSCountResponse DescribeDDoSCountSync(DescribeDDoSCountRequest req)
        {
             JsonResponseModel<DescribeDDoSCountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DDoS防护状态（临时关闭状态），支持产品：基础防护，独享包，共享包，高防IP，高防IP专业版；调用此接口是获取当前是否有设置临时关闭DDoS防护状态，如果有设置会返回临时关闭的时长等参数。
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSDefendStatusRequest"/></param>
        /// <returns><see cref="DescribeDDoSDefendStatusResponse"/></returns>
        public async Task<DescribeDDoSDefendStatusResponse> DescribeDDoSDefendStatus(DescribeDDoSDefendStatusRequest req)
        {
             JsonResponseModel<DescribeDDoSDefendStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSDefendStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSDefendStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDDoSDefendStatus接口的同步版本，获取DDoS防护状态（临时关闭状态），支持产品：基础防护，独享包，共享包，高防IP，高防IP专业版；调用此接口是获取当前是否有设置临时关闭DDoS防护状态，如果有设置会返回临时关闭的时长等参数。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDDoSDefendStatusRequest"/></param>
        /// <returns>参考<see cref="DescribeDDoSDefendStatusResponse"/>实例</returns>
        public DescribeDDoSDefendStatusResponse DescribeDDoSDefendStatusSync(DescribeDDoSDefendStatusRequest req)
        {
             JsonResponseModel<DescribeDDoSDefendStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSDefendStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSDefendStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DDoS攻击事件详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSEvInfoRequest"/></param>
        /// <returns><see cref="DescribeDDoSEvInfoResponse"/></returns>
        public async Task<DescribeDDoSEvInfoResponse> DescribeDDoSEvInfo(DescribeDDoSEvInfoRequest req)
        {
             JsonResponseModel<DescribeDDoSEvInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSEvInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSEvInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDDoSEvInfo接口的同步版本，获取DDoS攻击事件详情
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDDoSEvInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeDDoSEvInfoResponse"/>实例</returns>
        public DescribeDDoSEvInfoResponse DescribeDDoSEvInfoSync(DescribeDDoSEvInfoRequest req)
        {
             JsonResponseModel<DescribeDDoSEvInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSEvInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSEvInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DDoS攻击事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSEvListRequest"/></param>
        /// <returns><see cref="DescribeDDoSEvListResponse"/></returns>
        public async Task<DescribeDDoSEvListResponse> DescribeDDoSEvList(DescribeDDoSEvListRequest req)
        {
             JsonResponseModel<DescribeDDoSEvListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSEvList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSEvListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDDoSEvList接口的同步版本，获取DDoS攻击事件列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDDoSEvListRequest"/></param>
        /// <returns>参考<see cref="DescribeDDoSEvListResponse"/>实例</returns>
        public DescribeDDoSEvListResponse DescribeDDoSEvListSync(DescribeDDoSEvListRequest req)
        {
             JsonResponseModel<DescribeDDoSEvListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSEvList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSEvListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DDoSIP攻击日志
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSIpLogRequest"/></param>
        /// <returns><see cref="DescribeDDoSIpLogResponse"/></returns>
        public async Task<DescribeDDoSIpLogResponse> DescribeDDoSIpLog(DescribeDDoSIpLogRequest req)
        {
             JsonResponseModel<DescribeDDoSIpLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSIpLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSIpLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDDoSIpLog接口的同步版本，获取DDoSIP攻击日志
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDDoSIpLogRequest"/></param>
        /// <returns>参考<see cref="DescribeDDoSIpLogResponse"/>实例</returns>
        public DescribeDDoSIpLogResponse DescribeDDoSIpLogSync(DescribeDDoSIpLogRequest req)
        {
             JsonResponseModel<DescribeDDoSIpLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSIpLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSIpLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取高防IP专业版资源的DDoS攻击占比分析
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSNetCountRequest"/></param>
        /// <returns><see cref="DescribeDDoSNetCountResponse"/></returns>
        public async Task<DescribeDDoSNetCountResponse> DescribeDDoSNetCount(DescribeDDoSNetCountRequest req)
        {
             JsonResponseModel<DescribeDDoSNetCountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSNetCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSNetCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDDoSNetCount接口的同步版本，获取高防IP专业版资源的DDoS攻击占比分析
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDDoSNetCountRequest"/></param>
        /// <returns>参考<see cref="DescribeDDoSNetCountResponse"/>实例</returns>
        public DescribeDDoSNetCountResponse DescribeDDoSNetCountSync(DescribeDDoSNetCountRequest req)
        {
             JsonResponseModel<DescribeDDoSNetCountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSNetCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSNetCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取高防IP专业版资源的DDoS攻击事件详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSNetEvInfoRequest"/></param>
        /// <returns><see cref="DescribeDDoSNetEvInfoResponse"/></returns>
        public async Task<DescribeDDoSNetEvInfoResponse> DescribeDDoSNetEvInfo(DescribeDDoSNetEvInfoRequest req)
        {
             JsonResponseModel<DescribeDDoSNetEvInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSNetEvInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSNetEvInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDDoSNetEvInfo接口的同步版本，获取高防IP专业版资源的DDoS攻击事件详情
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDDoSNetEvInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeDDoSNetEvInfoResponse"/>实例</returns>
        public DescribeDDoSNetEvInfoResponse DescribeDDoSNetEvInfoSync(DescribeDDoSNetEvInfoRequest req)
        {
             JsonResponseModel<DescribeDDoSNetEvInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSNetEvInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSNetEvInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取高防IP专业版资源的DDoS攻击事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSNetEvListRequest"/></param>
        /// <returns><see cref="DescribeDDoSNetEvListResponse"/></returns>
        public async Task<DescribeDDoSNetEvListResponse> DescribeDDoSNetEvList(DescribeDDoSNetEvListRequest req)
        {
             JsonResponseModel<DescribeDDoSNetEvListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSNetEvList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSNetEvListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDDoSNetEvList接口的同步版本，获取高防IP专业版资源的DDoS攻击事件列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDDoSNetEvListRequest"/></param>
        /// <returns>参考<see cref="DescribeDDoSNetEvListResponse"/>实例</returns>
        public DescribeDDoSNetEvListResponse DescribeDDoSNetEvListSync(DescribeDDoSNetEvListRequest req)
        {
             JsonResponseModel<DescribeDDoSNetEvListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSNetEvList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSNetEvListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取高防IP专业版资源的DDoSIP攻击日志
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSNetIpLogRequest"/></param>
        /// <returns><see cref="DescribeDDoSNetIpLogResponse"/></returns>
        public async Task<DescribeDDoSNetIpLogResponse> DescribeDDoSNetIpLog(DescribeDDoSNetIpLogRequest req)
        {
             JsonResponseModel<DescribeDDoSNetIpLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSNetIpLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSNetIpLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDDoSNetIpLog接口的同步版本，获取高防IP专业版资源的DDoSIP攻击日志
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDDoSNetIpLogRequest"/></param>
        /// <returns>参考<see cref="DescribeDDoSNetIpLogResponse"/>实例</returns>
        public DescribeDDoSNetIpLogResponse DescribeDDoSNetIpLogSync(DescribeDDoSNetIpLogRequest req)
        {
             JsonResponseModel<DescribeDDoSNetIpLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSNetIpLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSNetIpLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取高防IP专业版资源的DDoS攻击指标数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSNetTrendRequest"/></param>
        /// <returns><see cref="DescribeDDoSNetTrendResponse"/></returns>
        public async Task<DescribeDDoSNetTrendResponse> DescribeDDoSNetTrend(DescribeDDoSNetTrendRequest req)
        {
             JsonResponseModel<DescribeDDoSNetTrendResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSNetTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSNetTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDDoSNetTrend接口的同步版本，获取高防IP专业版资源的DDoS攻击指标数据
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDDoSNetTrendRequest"/></param>
        /// <returns>参考<see cref="DescribeDDoSNetTrendResponse"/>实例</returns>
        public DescribeDDoSNetTrendResponse DescribeDDoSNetTrendSync(DescribeDDoSNetTrendRequest req)
        {
             JsonResponseModel<DescribeDDoSNetTrendResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSNetTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSNetTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DDoS高级策略
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSPolicyRequest"/></param>
        /// <returns><see cref="DescribeDDoSPolicyResponse"/></returns>
        public async Task<DescribeDDoSPolicyResponse> DescribeDDoSPolicy(DescribeDDoSPolicyRequest req)
        {
             JsonResponseModel<DescribeDDoSPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDDoSPolicy接口的同步版本，获取DDoS高级策略
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDDoSPolicyRequest"/></param>
        /// <returns>参考<see cref="DescribeDDoSPolicyResponse"/>实例</returns>
        public DescribeDDoSPolicyResponse DescribeDDoSPolicySync(DescribeDDoSPolicyRequest req)
        {
             JsonResponseModel<DescribeDDoSPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DDoS攻击流量带宽和攻击包速率数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSTrendRequest"/></param>
        /// <returns><see cref="DescribeDDoSTrendResponse"/></returns>
        public async Task<DescribeDDoSTrendResponse> DescribeDDoSTrend(DescribeDDoSTrendRequest req)
        {
             JsonResponseModel<DescribeDDoSTrendResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDDoSTrend接口的同步版本，获取DDoS攻击流量带宽和攻击包速率数据
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDDoSTrendRequest"/></param>
        /// <returns>参考<see cref="DescribeDDoSTrendResponse"/>实例</returns>
        public DescribeDDoSTrendResponse DescribeDDoSTrendSync(DescribeDDoSTrendRequest req)
        {
             JsonResponseModel<DescribeDDoSTrendResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 统计用户的高防资源的使用天数和DDoS攻击防护次数
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSUsedStatisRequest"/></param>
        /// <returns><see cref="DescribeDDoSUsedStatisResponse"/></returns>
        public async Task<DescribeDDoSUsedStatisResponse> DescribeDDoSUsedStatis(DescribeDDoSUsedStatisRequest req)
        {
             JsonResponseModel<DescribeDDoSUsedStatisResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDDoSUsedStatis");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSUsedStatisResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeDDoSUsedStatis接口的同步版本，统计用户的高防资源的使用天数和DDoS攻击防护次数
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDDoSUsedStatisRequest"/></param>
        /// <returns>参考<see cref="DescribeDDoSUsedStatisResponse"/>实例</returns>
        public DescribeDDoSUsedStatisResponse DescribeDDoSUsedStatisSync(DescribeDDoSUsedStatisRequest req)
        {
             JsonResponseModel<DescribeDDoSUsedStatisResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDDoSUsedStatis");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDDoSUsedStatisResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取独享包或共享包IP对应的云资产信息，只支持独享包和共享包的IP
        /// </summary>
        /// <param name="req"><see cref="DescribeIPProductInfoRequest"/></param>
        /// <returns><see cref="DescribeIPProductInfoResponse"/></returns>
        public async Task<DescribeIPProductInfoResponse> DescribeIPProductInfo(DescribeIPProductInfoRequest req)
        {
             JsonResponseModel<DescribeIPProductInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIPProductInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIPProductInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeIPProductInfo接口的同步版本，获取独享包或共享包IP对应的云资产信息，只支持独享包和共享包的IP
        /// </summary>
        /// <param name="req">参考<see cref="DescribeIPProductInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeIPProductInfoResponse"/>实例</returns>
        public DescribeIPProductInfoResponse DescribeIPProductInfoSync(DescribeIPProductInfoRequest req)
        {
             JsonResponseModel<DescribeIPProductInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIPProductInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIPProductInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取保险包套餐列表
        /// </summary>
        /// <param name="req"><see cref="DescribeInsurePacksRequest"/></param>
        /// <returns><see cref="DescribeInsurePacksResponse"/></returns>
        public async Task<DescribeInsurePacksResponse> DescribeInsurePacks(DescribeInsurePacksRequest req)
        {
             JsonResponseModel<DescribeInsurePacksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInsurePacks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInsurePacksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeInsurePacks接口的同步版本，获取保险包套餐列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeInsurePacksRequest"/></param>
        /// <returns>参考<see cref="DescribeInsurePacksResponse"/>实例</returns>
        public DescribeInsurePacksResponse DescribeInsurePacksSync(DescribeInsurePacksRequest req)
        {
             JsonResponseModel<DescribeInsurePacksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInsurePacks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInsurePacksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取IP封堵列表
        /// </summary>
        /// <param name="req"><see cref="DescribeIpBlockListRequest"/></param>
        /// <returns><see cref="DescribeIpBlockListResponse"/></returns>
        public async Task<DescribeIpBlockListResponse> DescribeIpBlockList(DescribeIpBlockListRequest req)
        {
             JsonResponseModel<DescribeIpBlockListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIpBlockList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIpBlockListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeIpBlockList接口的同步版本，获取IP封堵列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeIpBlockListRequest"/></param>
        /// <returns>参考<see cref="DescribeIpBlockListResponse"/>实例</returns>
        public DescribeIpBlockListResponse DescribeIpBlockListSync(DescribeIpBlockListRequest req)
        {
             JsonResponseModel<DescribeIpBlockListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIpBlockList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIpBlockListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取IP解封记录
        /// </summary>
        /// <param name="req"><see cref="DescribeIpUnBlockListRequest"/></param>
        /// <returns><see cref="DescribeIpUnBlockListResponse"/></returns>
        public async Task<DescribeIpUnBlockListResponse> DescribeIpUnBlockList(DescribeIpUnBlockListRequest req)
        {
             JsonResponseModel<DescribeIpUnBlockListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIpUnBlockList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIpUnBlockListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeIpUnBlockList接口的同步版本，获取IP解封记录
        /// </summary>
        /// <param name="req">参考<see cref="DescribeIpUnBlockListRequest"/></param>
        /// <returns>参考<see cref="DescribeIpUnBlockListResponse"/>实例</returns>
        public DescribeIpUnBlockListResponse DescribeIpUnBlockListSync(DescribeIpUnBlockListRequest req)
        {
             JsonResponseModel<DescribeIpUnBlockListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIpUnBlockList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIpUnBlockListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出四层健康检查配置
        /// </summary>
        /// <param name="req"><see cref="DescribeL4HealthConfigRequest"/></param>
        /// <returns><see cref="DescribeL4HealthConfigResponse"/></returns>
        public async Task<DescribeL4HealthConfigResponse> DescribeL4HealthConfig(DescribeL4HealthConfigRequest req)
        {
             JsonResponseModel<DescribeL4HealthConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeL4HealthConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeL4HealthConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeL4HealthConfig接口的同步版本，导出四层健康检查配置
        /// </summary>
        /// <param name="req">参考<see cref="DescribeL4HealthConfigRequest"/></param>
        /// <returns>参考<see cref="DescribeL4HealthConfigResponse"/>实例</returns>
        public DescribeL4HealthConfigResponse DescribeL4HealthConfigSync(DescribeL4HealthConfigRequest req)
        {
             JsonResponseModel<DescribeL4HealthConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeL4HealthConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeL4HealthConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取L4转发规则健康检查异常结果
        /// </summary>
        /// <param name="req"><see cref="DescribeL4RulesErrHealthRequest"/></param>
        /// <returns><see cref="DescribeL4RulesErrHealthResponse"/></returns>
        public async Task<DescribeL4RulesErrHealthResponse> DescribeL4RulesErrHealth(DescribeL4RulesErrHealthRequest req)
        {
             JsonResponseModel<DescribeL4RulesErrHealthResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeL4RulesErrHealth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeL4RulesErrHealthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeL4RulesErrHealth接口的同步版本，获取L4转发规则健康检查异常结果
        /// </summary>
        /// <param name="req">参考<see cref="DescribeL4RulesErrHealthRequest"/></param>
        /// <returns>参考<see cref="DescribeL4RulesErrHealthResponse"/>实例</returns>
        public DescribeL4RulesErrHealthResponse DescribeL4RulesErrHealthSync(DescribeL4RulesErrHealthRequest req)
        {
             JsonResponseModel<DescribeL4RulesErrHealthResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeL4RulesErrHealth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeL4RulesErrHealthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出七层健康检查配置
        /// </summary>
        /// <param name="req"><see cref="DescribeL7HealthConfigRequest"/></param>
        /// <returns><see cref="DescribeL7HealthConfigResponse"/></returns>
        public async Task<DescribeL7HealthConfigResponse> DescribeL7HealthConfig(DescribeL7HealthConfigRequest req)
        {
             JsonResponseModel<DescribeL7HealthConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeL7HealthConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeL7HealthConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeL7HealthConfig接口的同步版本，导出七层健康检查配置
        /// </summary>
        /// <param name="req">参考<see cref="DescribeL7HealthConfigRequest"/></param>
        /// <returns>参考<see cref="DescribeL7HealthConfigResponse"/>实例</returns>
        public DescribeL7HealthConfigResponse DescribeL7HealthConfigSync(DescribeL7HealthConfigRequest req)
        {
             JsonResponseModel<DescribeL7HealthConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeL7HealthConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeL7HealthConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取产品总览统计，支持高防包、高防IP、高防IP专业版、棋牌盾
        /// </summary>
        /// <param name="req"><see cref="DescribePackIndexRequest"/></param>
        /// <returns><see cref="DescribePackIndexResponse"/></returns>
        public async Task<DescribePackIndexResponse> DescribePackIndex(DescribePackIndexRequest req)
        {
             JsonResponseModel<DescribePackIndexResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePackIndex");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePackIndexResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribePackIndex接口的同步版本，获取产品总览统计，支持高防包、高防IP、高防IP专业版、棋牌盾
        /// </summary>
        /// <param name="req">参考<see cref="DescribePackIndexRequest"/></param>
        /// <returns>参考<see cref="DescribePackIndexResponse"/>实例</returns>
        public DescribePackIndexResponse DescribePackIndexSync(DescribePackIndexRequest req)
        {
             JsonResponseModel<DescribePackIndexResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePackIndex");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePackIndexResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 下载攻击事件的pcap包
        /// </summary>
        /// <param name="req"><see cref="DescribePcapRequest"/></param>
        /// <returns><see cref="DescribePcapResponse"/></returns>
        public async Task<DescribePcapResponse> DescribePcap(DescribePcapRequest req)
        {
             JsonResponseModel<DescribePcapResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePcap");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePcapResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribePcap接口的同步版本，下载攻击事件的pcap包
        /// </summary>
        /// <param name="req">参考<see cref="DescribePcapRequest"/></param>
        /// <returns>参考<see cref="DescribePcapResponse"/>实例</returns>
        public DescribePcapResponse DescribePcapSync(DescribePcapRequest req)
        {
             JsonResponseModel<DescribePcapResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePcap");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePcapResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取策略场景
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyCaseRequest"/></param>
        /// <returns><see cref="DescribePolicyCaseResponse"/></returns>
        public async Task<DescribePolicyCaseResponse> DescribePolicyCase(DescribePolicyCaseRequest req)
        {
             JsonResponseModel<DescribePolicyCaseResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePolicyCase");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePolicyCaseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribePolicyCase接口的同步版本，获取策略场景
        /// </summary>
        /// <param name="req">参考<see cref="DescribePolicyCaseRequest"/></param>
        /// <returns>参考<see cref="DescribePolicyCaseResponse"/>实例</returns>
        public DescribePolicyCaseResponse DescribePolicyCaseSync(DescribePolicyCaseRequest req)
        {
             JsonResponseModel<DescribePolicyCaseResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePolicyCase");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePolicyCaseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取资源的IP列表
        /// </summary>
        /// <param name="req"><see cref="DescribeResIpListRequest"/></param>
        /// <returns><see cref="DescribeResIpListResponse"/></returns>
        public async Task<DescribeResIpListResponse> DescribeResIpList(DescribeResIpListRequest req)
        {
             JsonResponseModel<DescribeResIpListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeResIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeResIpList接口的同步版本，获取资源的IP列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeResIpListRequest"/></param>
        /// <returns>参考<see cref="DescribeResIpListResponse"/>实例</returns>
        public DescribeResIpListResponse DescribeResIpListSync(DescribeResIpListRequest req)
        {
             JsonResponseModel<DescribeResIpListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeResIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取资源列表
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceListRequest"/></param>
        /// <returns><see cref="DescribeResourceListResponse"/></returns>
        public async Task<DescribeResourceListResponse> DescribeResourceList(DescribeResourceListRequest req)
        {
             JsonResponseModel<DescribeResourceListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeResourceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeResourceList接口的同步版本，获取资源列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeResourceListRequest"/></param>
        /// <returns>参考<see cref="DescribeResourceListResponse"/>实例</returns>
        public DescribeResourceListResponse DescribeResourceListSync(DescribeResourceListRequest req)
        {
             JsonResponseModel<DescribeResourceListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeResourceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取资源的规则数
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleSetsRequest"/></param>
        /// <returns><see cref="DescribeRuleSetsResponse"/></returns>
        public async Task<DescribeRuleSetsResponse> DescribeRuleSets(DescribeRuleSetsRequest req)
        {
             JsonResponseModel<DescribeRuleSetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRuleSets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleSetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeRuleSets接口的同步版本，获取资源的规则数
        /// </summary>
        /// <param name="req">参考<see cref="DescribeRuleSetsRequest"/></param>
        /// <returns>参考<see cref="DescribeRuleSetsResponse"/>实例</returns>
        public DescribeRuleSetsResponse DescribeRuleSetsSync(DescribeRuleSetsRequest req)
        {
             JsonResponseModel<DescribeRuleSetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRuleSets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleSetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取本月安全统计
        /// </summary>
        /// <param name="req"><see cref="DescribeSecIndexRequest"/></param>
        /// <returns><see cref="DescribeSecIndexResponse"/></returns>
        public async Task<DescribeSecIndexResponse> DescribeSecIndex(DescribeSecIndexRequest req)
        {
             JsonResponseModel<DescribeSecIndexResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecIndex");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecIndexResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeSecIndex接口的同步版本，获取本月安全统计
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSecIndexRequest"/></param>
        /// <returns>参考<see cref="DescribeSecIndexResponse"/>实例</returns>
        public DescribeSecIndexResponse DescribeSecIndexSync(DescribeSecIndexRequest req)
        {
             JsonResponseModel<DescribeSecIndexResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecIndex");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecIndexResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取回源IP段，支持的产品：高防IP，高防IP专业版，棋牌盾；
        /// </summary>
        /// <param name="req"><see cref="DescribeSourceIpSegmentRequest"/></param>
        /// <returns><see cref="DescribeSourceIpSegmentResponse"/></returns>
        public async Task<DescribeSourceIpSegmentResponse> DescribeSourceIpSegment(DescribeSourceIpSegmentRequest req)
        {
             JsonResponseModel<DescribeSourceIpSegmentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSourceIpSegment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSourceIpSegmentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeSourceIpSegment接口的同步版本，获取回源IP段，支持的产品：高防IP，高防IP专业版，棋牌盾；
        /// </summary>
        /// <param name="req">参考<see cref="DescribeSourceIpSegmentRequest"/></param>
        /// <returns>参考<see cref="DescribeSourceIpSegmentResponse"/>实例</returns>
        public DescribeSourceIpSegmentResponse DescribeSourceIpSegmentSync(DescribeSourceIpSegmentRequest req)
        {
             JsonResponseModel<DescribeSourceIpSegmentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSourceIpSegment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSourceIpSegmentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取业务转发统计数据，支持转发流量和转发包速率
        /// </summary>
        /// <param name="req"><see cref="DescribeTransmitStatisRequest"/></param>
        /// <returns><see cref="DescribeTransmitStatisResponse"/></returns>
        public async Task<DescribeTransmitStatisResponse> DescribeTransmitStatis(DescribeTransmitStatisRequest req)
        {
             JsonResponseModel<DescribeTransmitStatisResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTransmitStatis");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTransmitStatisResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeTransmitStatis接口的同步版本，获取业务转发统计数据，支持转发流量和转发包速率
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTransmitStatisRequest"/></param>
        /// <returns>参考<see cref="DescribeTransmitStatisResponse"/>实例</returns>
        public DescribeTransmitStatisResponse DescribeTransmitStatisSync(DescribeTransmitStatisRequest req)
        {
             JsonResponseModel<DescribeTransmitStatisResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTransmitStatis");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTransmitStatisResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取黑洞解封次数
        /// </summary>
        /// <param name="req"><see cref="DescribeUnBlockStatisRequest"/></param>
        /// <returns><see cref="DescribeUnBlockStatisResponse"/></returns>
        public async Task<DescribeUnBlockStatisResponse> DescribeUnBlockStatis(DescribeUnBlockStatisRequest req)
        {
             JsonResponseModel<DescribeUnBlockStatisResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUnBlockStatis");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUnBlockStatisResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeUnBlockStatis接口的同步版本，获取黑洞解封次数
        /// </summary>
        /// <param name="req">参考<see cref="DescribeUnBlockStatisRequest"/></param>
        /// <returns>参考<see cref="DescribeUnBlockStatisResponse"/>实例</returns>
        public DescribeUnBlockStatisResponse DescribeUnBlockStatisSync(DescribeUnBlockStatisRequest req)
        {
             JsonResponseModel<DescribeUnBlockStatisResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUnBlockStatis");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUnBlockStatisResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取四层转发规则
        /// </summary>
        /// <param name="req"><see cref="DescribleL4RulesRequest"/></param>
        /// <returns><see cref="DescribleL4RulesResponse"/></returns>
        public async Task<DescribleL4RulesResponse> DescribleL4Rules(DescribleL4RulesRequest req)
        {
             JsonResponseModel<DescribleL4RulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribleL4Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribleL4RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribleL4Rules接口的同步版本，获取四层转发规则
        /// </summary>
        /// <param name="req">参考<see cref="DescribleL4RulesRequest"/></param>
        /// <returns>参考<see cref="DescribleL4RulesResponse"/>实例</returns>
        public DescribleL4RulesResponse DescribleL4RulesSync(DescribleL4RulesRequest req)
        {
             JsonResponseModel<DescribleL4RulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribleL4Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribleL4RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取七层转发规则
        /// </summary>
        /// <param name="req"><see cref="DescribleL7RulesRequest"/></param>
        /// <returns><see cref="DescribleL7RulesResponse"/></returns>
        public async Task<DescribleL7RulesResponse> DescribleL7Rules(DescribleL7RulesRequest req)
        {
             JsonResponseModel<DescribleL7RulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribleL7Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribleL7RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribleL7Rules接口的同步版本，获取七层转发规则
        /// </summary>
        /// <param name="req">参考<see cref="DescribleL7RulesRequest"/></param>
        /// <returns>参考<see cref="DescribleL7RulesResponse"/>实例</returns>
        public DescribleL7RulesResponse DescribleL7RulesSync(DescribleL7RulesRequest req)
        {
             JsonResponseModel<DescribleL7RulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribleL7Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribleL7RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取地域的资源实例数
        /// </summary>
        /// <param name="req"><see cref="DescribleRegionCountRequest"/></param>
        /// <returns><see cref="DescribleRegionCountResponse"/></returns>
        public async Task<DescribleRegionCountResponse> DescribleRegionCount(DescribleRegionCountRequest req)
        {
             JsonResponseModel<DescribleRegionCountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribleRegionCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribleRegionCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribleRegionCount接口的同步版本，获取地域的资源实例数
        /// </summary>
        /// <param name="req">参考<see cref="DescribleRegionCountRequest"/></param>
        /// <returns>参考<see cref="DescribleRegionCountResponse"/>实例</returns>
        public DescribleRegionCountResponse DescribleRegionCountSync(DescribleRegionCountRequest req)
        {
             JsonResponseModel<DescribleRegionCountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribleRegionCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribleRegionCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 为高防包、高防IP、高防IP专业版、棋牌盾产品设置CC攻击的告警通知阈值
        /// </summary>
        /// <param name="req"><see cref="ModifyCCAlarmThresholdRequest"/></param>
        /// <returns><see cref="ModifyCCAlarmThresholdResponse"/></returns>
        public async Task<ModifyCCAlarmThresholdResponse> ModifyCCAlarmThreshold(ModifyCCAlarmThresholdRequest req)
        {
             JsonResponseModel<ModifyCCAlarmThresholdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCCAlarmThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCAlarmThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyCCAlarmThreshold接口的同步版本，为高防包、高防IP、高防IP专业版、棋牌盾产品设置CC攻击的告警通知阈值
        /// </summary>
        /// <param name="req">参考<see cref="ModifyCCAlarmThresholdRequest"/></param>
        /// <returns>参考<see cref="ModifyCCAlarmThresholdResponse"/>实例</returns>
        public ModifyCCAlarmThresholdResponse ModifyCCAlarmThresholdSync(ModifyCCAlarmThresholdRequest req)
        {
             JsonResponseModel<ModifyCCAlarmThresholdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCCAlarmThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCAlarmThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开启或关闭CC域名防护
        /// </summary>
        /// <param name="req"><see cref="ModifyCCHostProtectionRequest"/></param>
        /// <returns><see cref="ModifyCCHostProtectionResponse"/></returns>
        public async Task<ModifyCCHostProtectionResponse> ModifyCCHostProtection(ModifyCCHostProtectionRequest req)
        {
             JsonResponseModel<ModifyCCHostProtectionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCCHostProtection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCHostProtectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyCCHostProtection接口的同步版本，开启或关闭CC域名防护
        /// </summary>
        /// <param name="req">参考<see cref="ModifyCCHostProtectionRequest"/></param>
        /// <returns>参考<see cref="ModifyCCHostProtectionResponse"/>实例</returns>
        public ModifyCCHostProtectionResponse ModifyCCHostProtectionSync(ModifyCCHostProtectionRequest req)
        {
             JsonResponseModel<ModifyCCHostProtectionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCCHostProtection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCHostProtectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加或删除CC的IP黑白名单
        /// </summary>
        /// <param name="req"><see cref="ModifyCCIpAllowDenyRequest"/></param>
        /// <returns><see cref="ModifyCCIpAllowDenyResponse"/></returns>
        public async Task<ModifyCCIpAllowDenyResponse> ModifyCCIpAllowDeny(ModifyCCIpAllowDenyRequest req)
        {
             JsonResponseModel<ModifyCCIpAllowDenyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCCIpAllowDeny");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCIpAllowDenyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyCCIpAllowDeny接口的同步版本，添加或删除CC的IP黑白名单
        /// </summary>
        /// <param name="req">参考<see cref="ModifyCCIpAllowDenyRequest"/></param>
        /// <returns>参考<see cref="ModifyCCIpAllowDenyResponse"/>实例</returns>
        public ModifyCCIpAllowDenyResponse ModifyCCIpAllowDenySync(ModifyCCIpAllowDenyRequest req)
        {
             JsonResponseModel<ModifyCCIpAllowDenyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCCIpAllowDeny");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCIpAllowDenyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改CC防护等级
        /// </summary>
        /// <param name="req"><see cref="ModifyCCLevelRequest"/></param>
        /// <returns><see cref="ModifyCCLevelResponse"/></returns>
        public async Task<ModifyCCLevelResponse> ModifyCCLevel(ModifyCCLevelRequest req)
        {
             JsonResponseModel<ModifyCCLevelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCCLevel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCLevelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyCCLevel接口的同步版本，修改CC防护等级
        /// </summary>
        /// <param name="req">参考<see cref="ModifyCCLevelRequest"/></param>
        /// <returns>参考<see cref="ModifyCCLevelResponse"/>实例</returns>
        public ModifyCCLevelResponse ModifyCCLevelSync(ModifyCCLevelRequest req)
        {
             JsonResponseModel<ModifyCCLevelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCCLevel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCLevelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改CC自定义策略开关
        /// </summary>
        /// <param name="req"><see cref="ModifyCCPolicySwitchRequest"/></param>
        /// <returns><see cref="ModifyCCPolicySwitchResponse"/></returns>
        public async Task<ModifyCCPolicySwitchResponse> ModifyCCPolicySwitch(ModifyCCPolicySwitchRequest req)
        {
             JsonResponseModel<ModifyCCPolicySwitchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCCPolicySwitch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCPolicySwitchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyCCPolicySwitch接口的同步版本，修改CC自定义策略开关
        /// </summary>
        /// <param name="req">参考<see cref="ModifyCCPolicySwitchRequest"/></param>
        /// <returns>参考<see cref="ModifyCCPolicySwitchResponse"/>实例</returns>
        public ModifyCCPolicySwitchResponse ModifyCCPolicySwitchSync(ModifyCCPolicySwitchRequest req)
        {
             JsonResponseModel<ModifyCCPolicySwitchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCCPolicySwitch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCPolicySwitchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改CC自定义策略
        /// </summary>
        /// <param name="req"><see cref="ModifyCCSelfDefinePolicyRequest"/></param>
        /// <returns><see cref="ModifyCCSelfDefinePolicyResponse"/></returns>
        public async Task<ModifyCCSelfDefinePolicyResponse> ModifyCCSelfDefinePolicy(ModifyCCSelfDefinePolicyRequest req)
        {
             JsonResponseModel<ModifyCCSelfDefinePolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCCSelfDefinePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCSelfDefinePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyCCSelfDefinePolicy接口的同步版本，修改CC自定义策略
        /// </summary>
        /// <param name="req">参考<see cref="ModifyCCSelfDefinePolicyRequest"/></param>
        /// <returns>参考<see cref="ModifyCCSelfDefinePolicyResponse"/>实例</returns>
        public ModifyCCSelfDefinePolicyResponse ModifyCCSelfDefinePolicySync(ModifyCCSelfDefinePolicyRequest req)
        {
             JsonResponseModel<ModifyCCSelfDefinePolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCCSelfDefinePolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCSelfDefinePolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改CC的防护阈值
        /// </summary>
        /// <param name="req"><see cref="ModifyCCThresholdRequest"/></param>
        /// <returns><see cref="ModifyCCThresholdResponse"/></returns>
        public async Task<ModifyCCThresholdResponse> ModifyCCThreshold(ModifyCCThresholdRequest req)
        {
             JsonResponseModel<ModifyCCThresholdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCCThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyCCThreshold接口的同步版本，修改CC的防护阈值
        /// </summary>
        /// <param name="req">参考<see cref="ModifyCCThresholdRequest"/></param>
        /// <returns>参考<see cref="ModifyCCThresholdResponse"/>实例</returns>
        public ModifyCCThresholdResponse ModifyCCThresholdSync(ModifyCCThresholdRequest req)
        {
             JsonResponseModel<ModifyCCThresholdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCCThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加或删除CC的URL白名单
        /// </summary>
        /// <param name="req"><see cref="ModifyCCUrlAllowRequest"/></param>
        /// <returns><see cref="ModifyCCUrlAllowResponse"/></returns>
        public async Task<ModifyCCUrlAllowResponse> ModifyCCUrlAllow(ModifyCCUrlAllowRequest req)
        {
             JsonResponseModel<ModifyCCUrlAllowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCCUrlAllow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCUrlAllowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyCCUrlAllow接口的同步版本，添加或删除CC的URL白名单
        /// </summary>
        /// <param name="req">参考<see cref="ModifyCCUrlAllowRequest"/></param>
        /// <returns>参考<see cref="ModifyCCUrlAllowResponse"/>实例</returns>
        public ModifyCCUrlAllowResponse ModifyCCUrlAllowSync(ModifyCCUrlAllowRequest req)
        {
             JsonResponseModel<ModifyCCUrlAllowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCCUrlAllow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCCUrlAllowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 读取或修改DDoS的AI防护状态
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSAIStatusRequest"/></param>
        /// <returns><see cref="ModifyDDoSAIStatusResponse"/></returns>
        public async Task<ModifyDDoSAIStatusResponse> ModifyDDoSAIStatus(ModifyDDoSAIStatusRequest req)
        {
             JsonResponseModel<ModifyDDoSAIStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDDoSAIStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSAIStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyDDoSAIStatus接口的同步版本，读取或修改DDoS的AI防护状态
        /// </summary>
        /// <param name="req">参考<see cref="ModifyDDoSAIStatusRequest"/></param>
        /// <returns>参考<see cref="ModifyDDoSAIStatusResponse"/>实例</returns>
        public ModifyDDoSAIStatusResponse ModifyDDoSAIStatusSync(ModifyDDoSAIStatusRequest req)
        {
             JsonResponseModel<ModifyDDoSAIStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDDoSAIStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSAIStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 为高防包、高防IP、高防IP专业版、棋牌盾等产品设置DDoS攻击的告警通知阈值
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSAlarmThresholdRequest"/></param>
        /// <returns><see cref="ModifyDDoSAlarmThresholdResponse"/></returns>
        public async Task<ModifyDDoSAlarmThresholdResponse> ModifyDDoSAlarmThreshold(ModifyDDoSAlarmThresholdRequest req)
        {
             JsonResponseModel<ModifyDDoSAlarmThresholdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDDoSAlarmThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSAlarmThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyDDoSAlarmThreshold接口的同步版本，为高防包、高防IP、高防IP专业版、棋牌盾等产品设置DDoS攻击的告警通知阈值
        /// </summary>
        /// <param name="req">参考<see cref="ModifyDDoSAlarmThresholdRequest"/></param>
        /// <returns>参考<see cref="ModifyDDoSAlarmThresholdResponse"/>实例</returns>
        public ModifyDDoSAlarmThresholdResponse ModifyDDoSAlarmThresholdSync(ModifyDDoSAlarmThresholdRequest req)
        {
             JsonResponseModel<ModifyDDoSAlarmThresholdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDDoSAlarmThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSAlarmThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开启或关闭DDoS防护状态，调用此接口允许临时关闭DDoS防护一段时间，等时间到了会自动开启DDoS防护；
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSDefendStatusRequest"/></param>
        /// <returns><see cref="ModifyDDoSDefendStatusResponse"/></returns>
        public async Task<ModifyDDoSDefendStatusResponse> ModifyDDoSDefendStatus(ModifyDDoSDefendStatusRequest req)
        {
             JsonResponseModel<ModifyDDoSDefendStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDDoSDefendStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSDefendStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyDDoSDefendStatus接口的同步版本，开启或关闭DDoS防护状态，调用此接口允许临时关闭DDoS防护一段时间，等时间到了会自动开启DDoS防护；
        /// </summary>
        /// <param name="req">参考<see cref="ModifyDDoSDefendStatusRequest"/></param>
        /// <returns>参考<see cref="ModifyDDoSDefendStatusResponse"/>实例</returns>
        public ModifyDDoSDefendStatusResponse ModifyDDoSDefendStatusSync(ModifyDDoSDefendStatusRequest req)
        {
             JsonResponseModel<ModifyDDoSDefendStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDDoSDefendStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSDefendStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 读取或修改DDoS的防护等级
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSLevelRequest"/></param>
        /// <returns><see cref="ModifyDDoSLevelResponse"/></returns>
        public async Task<ModifyDDoSLevelResponse> ModifyDDoSLevel(ModifyDDoSLevelRequest req)
        {
             JsonResponseModel<ModifyDDoSLevelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDDoSLevel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSLevelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyDDoSLevel接口的同步版本，读取或修改DDoS的防护等级
        /// </summary>
        /// <param name="req">参考<see cref="ModifyDDoSLevelRequest"/></param>
        /// <returns>参考<see cref="ModifyDDoSLevelResponse"/>实例</returns>
        public ModifyDDoSLevelResponse ModifyDDoSLevelSync(ModifyDDoSLevelRequest req)
        {
             JsonResponseModel<ModifyDDoSLevelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDDoSLevel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSLevelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改DDoS高级策略
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSPolicyRequest"/></param>
        /// <returns><see cref="ModifyDDoSPolicyResponse"/></returns>
        public async Task<ModifyDDoSPolicyResponse> ModifyDDoSPolicy(ModifyDDoSPolicyRequest req)
        {
             JsonResponseModel<ModifyDDoSPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDDoSPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyDDoSPolicy接口的同步版本，修改DDoS高级策略
        /// </summary>
        /// <param name="req">参考<see cref="ModifyDDoSPolicyRequest"/></param>
        /// <returns>参考<see cref="ModifyDDoSPolicyResponse"/>实例</returns>
        public ModifyDDoSPolicyResponse ModifyDDoSPolicySync(ModifyDDoSPolicyRequest req)
        {
             JsonResponseModel<ModifyDDoSPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDDoSPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改策略场景
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSPolicyCaseRequest"/></param>
        /// <returns><see cref="ModifyDDoSPolicyCaseResponse"/></returns>
        public async Task<ModifyDDoSPolicyCaseResponse> ModifyDDoSPolicyCase(ModifyDDoSPolicyCaseRequest req)
        {
             JsonResponseModel<ModifyDDoSPolicyCaseResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDDoSPolicyCase");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSPolicyCaseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyDDoSPolicyCase接口的同步版本，修改策略场景
        /// </summary>
        /// <param name="req">参考<see cref="ModifyDDoSPolicyCaseRequest"/></param>
        /// <returns>参考<see cref="ModifyDDoSPolicyCaseResponse"/>实例</returns>
        public ModifyDDoSPolicyCaseResponse ModifyDDoSPolicyCaseSync(ModifyDDoSPolicyCaseRequest req)
        {
             JsonResponseModel<ModifyDDoSPolicyCaseResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDDoSPolicyCase");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSPolicyCaseResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改DDoS高级策略名称
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSPolicyNameRequest"/></param>
        /// <returns><see cref="ModifyDDoSPolicyNameResponse"/></returns>
        public async Task<ModifyDDoSPolicyNameResponse> ModifyDDoSPolicyName(ModifyDDoSPolicyNameRequest req)
        {
             JsonResponseModel<ModifyDDoSPolicyNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDDoSPolicyName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSPolicyNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyDDoSPolicyName接口的同步版本，修改DDoS高级策略名称
        /// </summary>
        /// <param name="req">参考<see cref="ModifyDDoSPolicyNameRequest"/></param>
        /// <returns>参考<see cref="ModifyDDoSPolicyNameResponse"/>实例</returns>
        public ModifyDDoSPolicyNameResponse ModifyDDoSPolicyNameSync(ModifyDDoSPolicyNameRequest req)
        {
             JsonResponseModel<ModifyDDoSPolicyNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDDoSPolicyName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSPolicyNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开启或关闭DDoS防护，只支持基础防护产品；
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSSwitchRequest"/></param>
        /// <returns><see cref="ModifyDDoSSwitchResponse"/></returns>
        public async Task<ModifyDDoSSwitchResponse> ModifyDDoSSwitch(ModifyDDoSSwitchRequest req)
        {
             JsonResponseModel<ModifyDDoSSwitchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDDoSSwitch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSSwitchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyDDoSSwitch接口的同步版本，开启或关闭DDoS防护，只支持基础防护产品；
        /// </summary>
        /// <param name="req">参考<see cref="ModifyDDoSSwitchRequest"/></param>
        /// <returns>参考<see cref="ModifyDDoSSwitchResponse"/>实例</returns>
        public ModifyDDoSSwitchResponse ModifyDDoSSwitchSync(ModifyDDoSSwitchRequest req)
        {
             JsonResponseModel<ModifyDDoSSwitchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDDoSSwitch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSSwitchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改DDoS清洗阈值
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSThresholdRequest"/></param>
        /// <returns><see cref="ModifyDDoSThresholdResponse"/></returns>
        public async Task<ModifyDDoSThresholdResponse> ModifyDDoSThreshold(ModifyDDoSThresholdRequest req)
        {
             JsonResponseModel<ModifyDDoSThresholdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDDoSThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyDDoSThreshold接口的同步版本，修改DDoS清洗阈值
        /// </summary>
        /// <param name="req">参考<see cref="ModifyDDoSThresholdRequest"/></param>
        /// <returns>参考<see cref="ModifyDDoSThresholdResponse"/>实例</returns>
        public ModifyDDoSThresholdResponse ModifyDDoSThresholdSync(ModifyDDoSThresholdRequest req)
        {
             JsonResponseModel<ModifyDDoSThresholdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDDoSThreshold");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSThresholdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 支持水印密钥的添加，删除，开启，关闭
        /// </summary>
        /// <param name="req"><see cref="ModifyDDoSWaterKeyRequest"/></param>
        /// <returns><see cref="ModifyDDoSWaterKeyResponse"/></returns>
        public async Task<ModifyDDoSWaterKeyResponse> ModifyDDoSWaterKey(ModifyDDoSWaterKeyRequest req)
        {
             JsonResponseModel<ModifyDDoSWaterKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDDoSWaterKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSWaterKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyDDoSWaterKey接口的同步版本，支持水印密钥的添加，删除，开启，关闭
        /// </summary>
        /// <param name="req">参考<see cref="ModifyDDoSWaterKeyRequest"/></param>
        /// <returns>参考<see cref="ModifyDDoSWaterKeyResponse"/>实例</returns>
        public ModifyDDoSWaterKeyResponse ModifyDDoSWaterKeySync(ModifyDDoSWaterKeyRequest req)
        {
             JsonResponseModel<ModifyDDoSWaterKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDDoSWaterKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDDoSWaterKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改弹性防护阈值
        /// </summary>
        /// <param name="req"><see cref="ModifyElasticLimitRequest"/></param>
        /// <returns><see cref="ModifyElasticLimitResponse"/></returns>
        public async Task<ModifyElasticLimitResponse> ModifyElasticLimit(ModifyElasticLimitRequest req)
        {
             JsonResponseModel<ModifyElasticLimitResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyElasticLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyElasticLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyElasticLimit接口的同步版本，修改弹性防护阈值
        /// </summary>
        /// <param name="req">参考<see cref="ModifyElasticLimitRequest"/></param>
        /// <returns>参考<see cref="ModifyElasticLimitResponse"/>实例</returns>
        public ModifyElasticLimitResponse ModifyElasticLimitSync(ModifyElasticLimitRequest req)
        {
             JsonResponseModel<ModifyElasticLimitResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyElasticLimit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyElasticLimitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改L4转发规则健康检查参数，支持的子产品：高防IP、高防IP专业版
        /// </summary>
        /// <param name="req"><see cref="ModifyL4HealthRequest"/></param>
        /// <returns><see cref="ModifyL4HealthResponse"/></returns>
        public async Task<ModifyL4HealthResponse> ModifyL4Health(ModifyL4HealthRequest req)
        {
             JsonResponseModel<ModifyL4HealthResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyL4Health");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyL4HealthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyL4Health接口的同步版本，修改L4转发规则健康检查参数，支持的子产品：高防IP、高防IP专业版
        /// </summary>
        /// <param name="req">参考<see cref="ModifyL4HealthRequest"/></param>
        /// <returns>参考<see cref="ModifyL4HealthResponse"/>实例</returns>
        public ModifyL4HealthResponse ModifyL4HealthSync(ModifyL4HealthRequest req)
        {
             JsonResponseModel<ModifyL4HealthResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyL4Health");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyL4HealthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改L4转发规则的会话保持，支持的子产品：高防IP、高防IP专业版
        /// </summary>
        /// <param name="req"><see cref="ModifyL4KeepTimeRequest"/></param>
        /// <returns><see cref="ModifyL4KeepTimeResponse"/></returns>
        public async Task<ModifyL4KeepTimeResponse> ModifyL4KeepTime(ModifyL4KeepTimeRequest req)
        {
             JsonResponseModel<ModifyL4KeepTimeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyL4KeepTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyL4KeepTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyL4KeepTime接口的同步版本，修改L4转发规则的会话保持，支持的子产品：高防IP、高防IP专业版
        /// </summary>
        /// <param name="req">参考<see cref="ModifyL4KeepTimeRequest"/></param>
        /// <returns>参考<see cref="ModifyL4KeepTimeResponse"/>实例</returns>
        public ModifyL4KeepTimeResponse ModifyL4KeepTimeSync(ModifyL4KeepTimeRequest req)
        {
             JsonResponseModel<ModifyL4KeepTimeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyL4KeepTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyL4KeepTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改L4转发规则
        /// </summary>
        /// <param name="req"><see cref="ModifyL4RulesRequest"/></param>
        /// <returns><see cref="ModifyL4RulesResponse"/></returns>
        public async Task<ModifyL4RulesResponse> ModifyL4Rules(ModifyL4RulesRequest req)
        {
             JsonResponseModel<ModifyL4RulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyL4Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyL4RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyL4Rules接口的同步版本，修改L4转发规则
        /// </summary>
        /// <param name="req">参考<see cref="ModifyL4RulesRequest"/></param>
        /// <returns>参考<see cref="ModifyL4RulesResponse"/>实例</returns>
        public ModifyL4RulesResponse ModifyL4RulesSync(ModifyL4RulesRequest req)
        {
             JsonResponseModel<ModifyL4RulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyL4Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyL4RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改L7转发规则
        /// </summary>
        /// <param name="req"><see cref="ModifyL7RulesRequest"/></param>
        /// <returns><see cref="ModifyL7RulesResponse"/></returns>
        public async Task<ModifyL7RulesResponse> ModifyL7Rules(ModifyL7RulesRequest req)
        {
             JsonResponseModel<ModifyL7RulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyL7Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyL7RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyL7Rules接口的同步版本，修改L7转发规则
        /// </summary>
        /// <param name="req">参考<see cref="ModifyL7RulesRequest"/></param>
        /// <returns>参考<see cref="ModifyL7RulesResponse"/>实例</returns>
        public ModifyL7RulesResponse ModifyL7RulesSync(ModifyL7RulesRequest req)
        {
             JsonResponseModel<ModifyL7RulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyL7Rules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyL7RulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 资源实例绑定DDoS高级策略
        /// </summary>
        /// <param name="req"><see cref="ModifyResBindDDoSPolicyRequest"/></param>
        /// <returns><see cref="ModifyResBindDDoSPolicyResponse"/></returns>
        public async Task<ModifyResBindDDoSPolicyResponse> ModifyResBindDDoSPolicy(ModifyResBindDDoSPolicyRequest req)
        {
             JsonResponseModel<ModifyResBindDDoSPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyResBindDDoSPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyResBindDDoSPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyResBindDDoSPolicy接口的同步版本，资源实例绑定DDoS高级策略
        /// </summary>
        /// <param name="req">参考<see cref="ModifyResBindDDoSPolicyRequest"/></param>
        /// <returns>参考<see cref="ModifyResBindDDoSPolicyResponse"/>实例</returns>
        public ModifyResBindDDoSPolicyResponse ModifyResBindDDoSPolicySync(ModifyResBindDDoSPolicyRequest req)
        {
             JsonResponseModel<ModifyResBindDDoSPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyResBindDDoSPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyResBindDDoSPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改资源自动续费标记
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyResourceRenewFlagResponse"/></returns>
        public async Task<ModifyResourceRenewFlagResponse> ModifyResourceRenewFlag(ModifyResourceRenewFlagRequest req)
        {
             JsonResponseModel<ModifyResourceRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyResourceRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyResourceRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyResourceRenewFlag接口的同步版本，修改资源自动续费标记
        /// </summary>
        /// <param name="req">参考<see cref="ModifyResourceRenewFlagRequest"/></param>
        /// <returns>参考<see cref="ModifyResourceRenewFlagResponse"/>实例</returns>
        public ModifyResourceRenewFlagResponse ModifyResourceRenewFlagSync(ModifyResourceRenewFlagRequest req)
        {
             JsonResponseModel<ModifyResourceRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyResourceRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyResourceRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}

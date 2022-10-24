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

namespace TencentCloud.Tcss.V20201101
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tcss.V20201101.Models;

   public class TcssClient : AbstractClient{

       private const string endpoint = "tcss.tencentcloudapi.com";
       private const string version = "2020-11-01";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TcssClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TcssClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 容器网络创建网络策略添加并发布任务
        /// </summary>
        /// <param name="req"><see cref="AddAndPublishNetworkFirewallPolicyDetailRequest"/></param>
        /// <returns><see cref="AddAndPublishNetworkFirewallPolicyDetailResponse"/></returns>
        public async Task<AddAndPublishNetworkFirewallPolicyDetailResponse> AddAndPublishNetworkFirewallPolicyDetail(AddAndPublishNetworkFirewallPolicyDetailRequest req)
        {
             JsonResponseModel<AddAndPublishNetworkFirewallPolicyDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddAndPublishNetworkFirewallPolicyDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddAndPublishNetworkFirewallPolicyDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器网络创建网络策略添加并发布任务
        /// </summary>
        /// <param name="req"><see cref="AddAndPublishNetworkFirewallPolicyDetailRequest"/></param>
        /// <returns><see cref="AddAndPublishNetworkFirewallPolicyDetailResponse"/></returns>
        public AddAndPublishNetworkFirewallPolicyDetailResponse AddAndPublishNetworkFirewallPolicyDetailSync(AddAndPublishNetworkFirewallPolicyDetailRequest req)
        {
             JsonResponseModel<AddAndPublishNetworkFirewallPolicyDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddAndPublishNetworkFirewallPolicyDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddAndPublishNetworkFirewallPolicyDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器网络创建Yaml网络策略并发布任务
        /// </summary>
        /// <param name="req"><see cref="AddAndPublishNetworkFirewallPolicyYamlDetailRequest"/></param>
        /// <returns><see cref="AddAndPublishNetworkFirewallPolicyYamlDetailResponse"/></returns>
        public async Task<AddAndPublishNetworkFirewallPolicyYamlDetailResponse> AddAndPublishNetworkFirewallPolicyYamlDetail(AddAndPublishNetworkFirewallPolicyYamlDetailRequest req)
        {
             JsonResponseModel<AddAndPublishNetworkFirewallPolicyYamlDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddAndPublishNetworkFirewallPolicyYamlDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddAndPublishNetworkFirewallPolicyYamlDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器网络创建Yaml网络策略并发布任务
        /// </summary>
        /// <param name="req"><see cref="AddAndPublishNetworkFirewallPolicyYamlDetailRequest"/></param>
        /// <returns><see cref="AddAndPublishNetworkFirewallPolicyYamlDetailResponse"/></returns>
        public AddAndPublishNetworkFirewallPolicyYamlDetailResponse AddAndPublishNetworkFirewallPolicyYamlDetailSync(AddAndPublishNetworkFirewallPolicyYamlDetailRequest req)
        {
             JsonResponseModel<AddAndPublishNetworkFirewallPolicyYamlDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddAndPublishNetworkFirewallPolicyYamlDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddAndPublishNetworkFirewallPolicyYamlDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增单个镜像仓库详细信息
        /// </summary>
        /// <param name="req"><see cref="AddAssetImageRegistryRegistryDetailRequest"/></param>
        /// <returns><see cref="AddAssetImageRegistryRegistryDetailResponse"/></returns>
        public async Task<AddAssetImageRegistryRegistryDetailResponse> AddAssetImageRegistryRegistryDetail(AddAssetImageRegistryRegistryDetailRequest req)
        {
             JsonResponseModel<AddAssetImageRegistryRegistryDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddAssetImageRegistryRegistryDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddAssetImageRegistryRegistryDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增单个镜像仓库详细信息
        /// </summary>
        /// <param name="req"><see cref="AddAssetImageRegistryRegistryDetailRequest"/></param>
        /// <returns><see cref="AddAssetImageRegistryRegistryDetailResponse"/></returns>
        public AddAssetImageRegistryRegistryDetailResponse AddAssetImageRegistryRegistryDetailSync(AddAssetImageRegistryRegistryDetailRequest req)
        {
             JsonResponseModel<AddAssetImageRegistryRegistryDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddAssetImageRegistryRegistryDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddAssetImageRegistryRegistryDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增安全合规忽略(资产+检测项列表)列表，不显示指定的检查项包含的资产内容
        /// 参考的AddCompliancePolicyItemToWhitelist，除输入字段外，其它应该是一致的，如果有不同可能是定义的不对
        /// </summary>
        /// <param name="req"><see cref="AddComplianceAssetPolicySetToWhitelistRequest"/></param>
        /// <returns><see cref="AddComplianceAssetPolicySetToWhitelistResponse"/></returns>
        public async Task<AddComplianceAssetPolicySetToWhitelistResponse> AddComplianceAssetPolicySetToWhitelist(AddComplianceAssetPolicySetToWhitelistRequest req)
        {
             JsonResponseModel<AddComplianceAssetPolicySetToWhitelistResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddComplianceAssetPolicySetToWhitelist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddComplianceAssetPolicySetToWhitelistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增安全合规忽略(资产+检测项列表)列表，不显示指定的检查项包含的资产内容
        /// 参考的AddCompliancePolicyItemToWhitelist，除输入字段外，其它应该是一致的，如果有不同可能是定义的不对
        /// </summary>
        /// <param name="req"><see cref="AddComplianceAssetPolicySetToWhitelistRequest"/></param>
        /// <returns><see cref="AddComplianceAssetPolicySetToWhitelistResponse"/></returns>
        public AddComplianceAssetPolicySetToWhitelistResponse AddComplianceAssetPolicySetToWhitelistSync(AddComplianceAssetPolicySetToWhitelistRequest req)
        {
             JsonResponseModel<AddComplianceAssetPolicySetToWhitelistResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddComplianceAssetPolicySetToWhitelist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddComplianceAssetPolicySetToWhitelistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增安全合规忽略(检测项+资产)列表，不显示指定的检查项包含的资产内容
        /// 参考的AddCompliancePolicyItemToWhitelist，除输入字段外，其它应该是一致的，如果有不同可能是定义的不对
        /// </summary>
        /// <param name="req"><see cref="AddCompliancePolicyAssetSetToWhitelistRequest"/></param>
        /// <returns><see cref="AddCompliancePolicyAssetSetToWhitelistResponse"/></returns>
        public async Task<AddCompliancePolicyAssetSetToWhitelistResponse> AddCompliancePolicyAssetSetToWhitelist(AddCompliancePolicyAssetSetToWhitelistRequest req)
        {
             JsonResponseModel<AddCompliancePolicyAssetSetToWhitelistResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddCompliancePolicyAssetSetToWhitelist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddCompliancePolicyAssetSetToWhitelistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增安全合规忽略(检测项+资产)列表，不显示指定的检查项包含的资产内容
        /// 参考的AddCompliancePolicyItemToWhitelist，除输入字段外，其它应该是一致的，如果有不同可能是定义的不对
        /// </summary>
        /// <param name="req"><see cref="AddCompliancePolicyAssetSetToWhitelistRequest"/></param>
        /// <returns><see cref="AddCompliancePolicyAssetSetToWhitelistResponse"/></returns>
        public AddCompliancePolicyAssetSetToWhitelistResponse AddCompliancePolicyAssetSetToWhitelistSync(AddCompliancePolicyAssetSetToWhitelistRequest req)
        {
             JsonResponseModel<AddCompliancePolicyAssetSetToWhitelistResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddCompliancePolicyAssetSetToWhitelist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddCompliancePolicyAssetSetToWhitelistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将指定的检测项添加到白名单中，不显示未通过结果。
        /// </summary>
        /// <param name="req"><see cref="AddCompliancePolicyItemToWhitelistRequest"/></param>
        /// <returns><see cref="AddCompliancePolicyItemToWhitelistResponse"/></returns>
        public async Task<AddCompliancePolicyItemToWhitelistResponse> AddCompliancePolicyItemToWhitelist(AddCompliancePolicyItemToWhitelistRequest req)
        {
             JsonResponseModel<AddCompliancePolicyItemToWhitelistResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddCompliancePolicyItemToWhitelist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddCompliancePolicyItemToWhitelistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将指定的检测项添加到白名单中，不显示未通过结果。
        /// </summary>
        /// <param name="req"><see cref="AddCompliancePolicyItemToWhitelistRequest"/></param>
        /// <returns><see cref="AddCompliancePolicyItemToWhitelistResponse"/></returns>
        public AddCompliancePolicyItemToWhitelistResponse AddCompliancePolicyItemToWhitelistSync(AddCompliancePolicyItemToWhitelistRequest req)
        {
             JsonResponseModel<AddCompliancePolicyItemToWhitelistResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddCompliancePolicyItemToWhitelist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddCompliancePolicyItemToWhitelistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加编辑运行时异常进程策略
        /// </summary>
        /// <param name="req"><see cref="AddEditAbnormalProcessRuleRequest"/></param>
        /// <returns><see cref="AddEditAbnormalProcessRuleResponse"/></returns>
        public async Task<AddEditAbnormalProcessRuleResponse> AddEditAbnormalProcessRule(AddEditAbnormalProcessRuleRequest req)
        {
             JsonResponseModel<AddEditAbnormalProcessRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddEditAbnormalProcessRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddEditAbnormalProcessRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加编辑运行时异常进程策略
        /// </summary>
        /// <param name="req"><see cref="AddEditAbnormalProcessRuleRequest"/></param>
        /// <returns><see cref="AddEditAbnormalProcessRuleResponse"/></returns>
        public AddEditAbnormalProcessRuleResponse AddEditAbnormalProcessRuleSync(AddEditAbnormalProcessRuleRequest req)
        {
             JsonResponseModel<AddEditAbnormalProcessRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddEditAbnormalProcessRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddEditAbnormalProcessRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加编辑运行时访问控制策略
        /// </summary>
        /// <param name="req"><see cref="AddEditAccessControlRuleRequest"/></param>
        /// <returns><see cref="AddEditAccessControlRuleResponse"/></returns>
        public async Task<AddEditAccessControlRuleResponse> AddEditAccessControlRule(AddEditAccessControlRuleRequest req)
        {
             JsonResponseModel<AddEditAccessControlRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddEditAccessControlRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddEditAccessControlRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加编辑运行时访问控制策略
        /// </summary>
        /// <param name="req"><see cref="AddEditAccessControlRuleRequest"/></param>
        /// <returns><see cref="AddEditAccessControlRuleResponse"/></returns>
        public AddEditAccessControlRuleResponse AddEditAccessControlRuleSync(AddEditAccessControlRuleRequest req)
        {
             JsonResponseModel<AddEditAccessControlRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddEditAccessControlRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddEditAccessControlRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增或编辑本地镜像自动授权规则
        /// </summary>
        /// <param name="req"><see cref="AddEditImageAutoAuthorizedRuleRequest"/></param>
        /// <returns><see cref="AddEditImageAutoAuthorizedRuleResponse"/></returns>
        public async Task<AddEditImageAutoAuthorizedRuleResponse> AddEditImageAutoAuthorizedRule(AddEditImageAutoAuthorizedRuleRequest req)
        {
             JsonResponseModel<AddEditImageAutoAuthorizedRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddEditImageAutoAuthorizedRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddEditImageAutoAuthorizedRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增或编辑本地镜像自动授权规则
        /// </summary>
        /// <param name="req"><see cref="AddEditImageAutoAuthorizedRuleRequest"/></param>
        /// <returns><see cref="AddEditImageAutoAuthorizedRuleResponse"/></returns>
        public AddEditImageAutoAuthorizedRuleResponse AddEditImageAutoAuthorizedRuleSync(AddEditImageAutoAuthorizedRuleRequest req)
        {
             JsonResponseModel<AddEditImageAutoAuthorizedRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddEditImageAutoAuthorizedRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddEditImageAutoAuthorizedRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加编辑运行时反弹shell白名单
        /// </summary>
        /// <param name="req"><see cref="AddEditReverseShellWhiteListRequest"/></param>
        /// <returns><see cref="AddEditReverseShellWhiteListResponse"/></returns>
        public async Task<AddEditReverseShellWhiteListResponse> AddEditReverseShellWhiteList(AddEditReverseShellWhiteListRequest req)
        {
             JsonResponseModel<AddEditReverseShellWhiteListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddEditReverseShellWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddEditReverseShellWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加编辑运行时反弹shell白名单
        /// </summary>
        /// <param name="req"><see cref="AddEditReverseShellWhiteListRequest"/></param>
        /// <returns><see cref="AddEditReverseShellWhiteListResponse"/></returns>
        public AddEditReverseShellWhiteListResponse AddEditReverseShellWhiteListSync(AddEditReverseShellWhiteListRequest req)
        {
             JsonResponseModel<AddEditReverseShellWhiteListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddEditReverseShellWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddEditReverseShellWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加编辑运行时高危系统调用白名单
        /// </summary>
        /// <param name="req"><see cref="AddEditRiskSyscallWhiteListRequest"/></param>
        /// <returns><see cref="AddEditRiskSyscallWhiteListResponse"/></returns>
        public async Task<AddEditRiskSyscallWhiteListResponse> AddEditRiskSyscallWhiteList(AddEditRiskSyscallWhiteListRequest req)
        {
             JsonResponseModel<AddEditRiskSyscallWhiteListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddEditRiskSyscallWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddEditRiskSyscallWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加编辑运行时高危系统调用白名单
        /// </summary>
        /// <param name="req"><see cref="AddEditRiskSyscallWhiteListRequest"/></param>
        /// <returns><see cref="AddEditRiskSyscallWhiteListResponse"/></returns>
        public AddEditRiskSyscallWhiteListResponse AddEditRiskSyscallWhiteListSync(AddEditRiskSyscallWhiteListRequest req)
        {
             JsonResponseModel<AddEditRiskSyscallWhiteListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddEditRiskSyscallWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddEditRiskSyscallWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加编辑告警策略
        /// </summary>
        /// <param name="req"><see cref="AddEditWarningRulesRequest"/></param>
        /// <returns><see cref="AddEditWarningRulesResponse"/></returns>
        public async Task<AddEditWarningRulesResponse> AddEditWarningRules(AddEditWarningRulesRequest req)
        {
             JsonResponseModel<AddEditWarningRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddEditWarningRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddEditWarningRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加编辑告警策略
        /// </summary>
        /// <param name="req"><see cref="AddEditWarningRulesRequest"/></param>
        /// <returns><see cref="AddEditWarningRulesResponse"/></returns>
        public AddEditWarningRulesResponse AddEditWarningRulesSync(AddEditWarningRulesRequest req)
        {
             JsonResponseModel<AddEditWarningRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddEditWarningRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddEditWarningRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增逃逸白名单
        /// </summary>
        /// <param name="req"><see cref="AddEscapeWhiteListRequest"/></param>
        /// <returns><see cref="AddEscapeWhiteListResponse"/></returns>
        public async Task<AddEscapeWhiteListResponse> AddEscapeWhiteList(AddEscapeWhiteListRequest req)
        {
             JsonResponseModel<AddEscapeWhiteListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddEscapeWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddEscapeWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增逃逸白名单
        /// </summary>
        /// <param name="req"><see cref="AddEscapeWhiteListRequest"/></param>
        /// <returns><see cref="AddEscapeWhiteListResponse"/></returns>
        public AddEscapeWhiteListResponse AddEscapeWhiteListSync(AddEscapeWhiteListRequest req)
        {
             JsonResponseModel<AddEscapeWhiteListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddEscapeWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddEscapeWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增漏洞扫描忽略漏洞
        /// </summary>
        /// <param name="req"><see cref="AddIgnoreVulRequest"/></param>
        /// <returns><see cref="AddIgnoreVulResponse"/></returns>
        public async Task<AddIgnoreVulResponse> AddIgnoreVul(AddIgnoreVulRequest req)
        {
             JsonResponseModel<AddIgnoreVulResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddIgnoreVul");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddIgnoreVulResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增漏洞扫描忽略漏洞
        /// </summary>
        /// <param name="req"><see cref="AddIgnoreVulRequest"/></param>
        /// <returns><see cref="AddIgnoreVulResponse"/></returns>
        public AddIgnoreVulResponse AddIgnoreVulSync(AddIgnoreVulRequest req)
        {
             JsonResponseModel<AddIgnoreVulResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddIgnoreVul");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddIgnoreVulResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器网络创建网络策略添加任务
        /// </summary>
        /// <param name="req"><see cref="AddNetworkFirewallPolicyDetailRequest"/></param>
        /// <returns><see cref="AddNetworkFirewallPolicyDetailResponse"/></returns>
        public async Task<AddNetworkFirewallPolicyDetailResponse> AddNetworkFirewallPolicyDetail(AddNetworkFirewallPolicyDetailRequest req)
        {
             JsonResponseModel<AddNetworkFirewallPolicyDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddNetworkFirewallPolicyDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddNetworkFirewallPolicyDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器网络创建网络策略添加任务
        /// </summary>
        /// <param name="req"><see cref="AddNetworkFirewallPolicyDetailRequest"/></param>
        /// <returns><see cref="AddNetworkFirewallPolicyDetailResponse"/></returns>
        public AddNetworkFirewallPolicyDetailResponse AddNetworkFirewallPolicyDetailSync(AddNetworkFirewallPolicyDetailRequest req)
        {
             JsonResponseModel<AddNetworkFirewallPolicyDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddNetworkFirewallPolicyDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddNetworkFirewallPolicyDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器网络创建Yaml网络策略添加任务
        /// </summary>
        /// <param name="req"><see cref="AddNetworkFirewallPolicyYamlDetailRequest"/></param>
        /// <returns><see cref="AddNetworkFirewallPolicyYamlDetailResponse"/></returns>
        public async Task<AddNetworkFirewallPolicyYamlDetailResponse> AddNetworkFirewallPolicyYamlDetail(AddNetworkFirewallPolicyYamlDetailRequest req)
        {
             JsonResponseModel<AddNetworkFirewallPolicyYamlDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddNetworkFirewallPolicyYamlDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddNetworkFirewallPolicyYamlDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器网络创建Yaml网络策略添加任务
        /// </summary>
        /// <param name="req"><see cref="AddNetworkFirewallPolicyYamlDetailRequest"/></param>
        /// <returns><see cref="AddNetworkFirewallPolicyYamlDetailResponse"/></returns>
        public AddNetworkFirewallPolicyYamlDetailResponse AddNetworkFirewallPolicyYamlDetailSync(AddNetworkFirewallPolicyYamlDetailRequest req)
        {
             JsonResponseModel<AddNetworkFirewallPolicyYamlDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddNetworkFirewallPolicyYamlDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddNetworkFirewallPolicyYamlDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器网络创建检查Yaml网络策略任务
        /// </summary>
        /// <param name="req"><see cref="CheckNetworkFirewallPolicyYamlRequest"/></param>
        /// <returns><see cref="CheckNetworkFirewallPolicyYamlResponse"/></returns>
        public async Task<CheckNetworkFirewallPolicyYamlResponse> CheckNetworkFirewallPolicyYaml(CheckNetworkFirewallPolicyYamlRequest req)
        {
             JsonResponseModel<CheckNetworkFirewallPolicyYamlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckNetworkFirewallPolicyYaml");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckNetworkFirewallPolicyYamlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器网络创建检查Yaml网络策略任务
        /// </summary>
        /// <param name="req"><see cref="CheckNetworkFirewallPolicyYamlRequest"/></param>
        /// <returns><see cref="CheckNetworkFirewallPolicyYamlResponse"/></returns>
        public CheckNetworkFirewallPolicyYamlResponse CheckNetworkFirewallPolicyYamlSync(CheckNetworkFirewallPolicyYamlRequest req)
        {
             JsonResponseModel<CheckNetworkFirewallPolicyYamlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckNetworkFirewallPolicyYaml");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckNetworkFirewallPolicyYamlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 检查单个镜像仓库名是否重复
        /// </summary>
        /// <param name="req"><see cref="CheckRepeatAssetImageRegistryRequest"/></param>
        /// <returns><see cref="CheckRepeatAssetImageRegistryResponse"/></returns>
        public async Task<CheckRepeatAssetImageRegistryResponse> CheckRepeatAssetImageRegistry(CheckRepeatAssetImageRegistryRequest req)
        {
             JsonResponseModel<CheckRepeatAssetImageRegistryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckRepeatAssetImageRegistry");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckRepeatAssetImageRegistryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 检查单个镜像仓库名是否重复
        /// </summary>
        /// <param name="req"><see cref="CheckRepeatAssetImageRegistryRequest"/></param>
        /// <returns><see cref="CheckRepeatAssetImageRegistryResponse"/></returns>
        public CheckRepeatAssetImageRegistryResponse CheckRepeatAssetImageRegistrySync(CheckRepeatAssetImageRegistryRequest req)
        {
             JsonResponseModel<CheckRepeatAssetImageRegistryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckRepeatAssetImageRegistry");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckRepeatAssetImageRegistryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器网络创建网络策略确认任务
        /// </summary>
        /// <param name="req"><see cref="ConfirmNetworkFirewallPolicyRequest"/></param>
        /// <returns><see cref="ConfirmNetworkFirewallPolicyResponse"/></returns>
        public async Task<ConfirmNetworkFirewallPolicyResponse> ConfirmNetworkFirewallPolicy(ConfirmNetworkFirewallPolicyRequest req)
        {
             JsonResponseModel<ConfirmNetworkFirewallPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ConfirmNetworkFirewallPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ConfirmNetworkFirewallPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器网络创建网络策略确认任务
        /// </summary>
        /// <param name="req"><see cref="ConfirmNetworkFirewallPolicyRequest"/></param>
        /// <returns><see cref="ConfirmNetworkFirewallPolicyResponse"/></returns>
        public ConfirmNetworkFirewallPolicyResponse ConfirmNetworkFirewallPolicySync(ConfirmNetworkFirewallPolicyRequest req)
        {
             JsonResponseModel<ConfirmNetworkFirewallPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ConfirmNetworkFirewallPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ConfirmNetworkFirewallPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 镜像仓库创建镜像扫描任务
        /// </summary>
        /// <param name="req"><see cref="CreateAssetImageRegistryScanTaskRequest"/></param>
        /// <returns><see cref="CreateAssetImageRegistryScanTaskResponse"/></returns>
        public async Task<CreateAssetImageRegistryScanTaskResponse> CreateAssetImageRegistryScanTask(CreateAssetImageRegistryScanTaskRequest req)
        {
             JsonResponseModel<CreateAssetImageRegistryScanTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAssetImageRegistryScanTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAssetImageRegistryScanTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 镜像仓库创建镜像扫描任务
        /// </summary>
        /// <param name="req"><see cref="CreateAssetImageRegistryScanTaskRequest"/></param>
        /// <returns><see cref="CreateAssetImageRegistryScanTaskResponse"/></returns>
        public CreateAssetImageRegistryScanTaskResponse CreateAssetImageRegistryScanTaskSync(CreateAssetImageRegistryScanTaskRequest req)
        {
             JsonResponseModel<CreateAssetImageRegistryScanTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAssetImageRegistryScanTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAssetImageRegistryScanTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 镜像仓库创建镜像一键扫描任务
        /// </summary>
        /// <param name="req"><see cref="CreateAssetImageRegistryScanTaskOneKeyRequest"/></param>
        /// <returns><see cref="CreateAssetImageRegistryScanTaskOneKeyResponse"/></returns>
        public async Task<CreateAssetImageRegistryScanTaskOneKeyResponse> CreateAssetImageRegistryScanTaskOneKey(CreateAssetImageRegistryScanTaskOneKeyRequest req)
        {
             JsonResponseModel<CreateAssetImageRegistryScanTaskOneKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAssetImageRegistryScanTaskOneKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAssetImageRegistryScanTaskOneKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 镜像仓库创建镜像一键扫描任务
        /// </summary>
        /// <param name="req"><see cref="CreateAssetImageRegistryScanTaskOneKeyRequest"/></param>
        /// <returns><see cref="CreateAssetImageRegistryScanTaskOneKeyResponse"/></returns>
        public CreateAssetImageRegistryScanTaskOneKeyResponse CreateAssetImageRegistryScanTaskOneKeySync(CreateAssetImageRegistryScanTaskOneKeyRequest req)
        {
             JsonResponseModel<CreateAssetImageRegistryScanTaskOneKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAssetImageRegistryScanTaskOneKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAssetImageRegistryScanTaskOneKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加容器安全镜像扫描设置
        /// </summary>
        /// <param name="req"><see cref="CreateAssetImageScanSettingRequest"/></param>
        /// <returns><see cref="CreateAssetImageScanSettingResponse"/></returns>
        public async Task<CreateAssetImageScanSettingResponse> CreateAssetImageScanSetting(CreateAssetImageScanSettingRequest req)
        {
             JsonResponseModel<CreateAssetImageScanSettingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAssetImageScanSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAssetImageScanSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加容器安全镜像扫描设置
        /// </summary>
        /// <param name="req"><see cref="CreateAssetImageScanSettingRequest"/></param>
        /// <returns><see cref="CreateAssetImageScanSettingResponse"/></returns>
        public CreateAssetImageScanSettingResponse CreateAssetImageScanSettingSync(CreateAssetImageScanSettingRequest req)
        {
             JsonResponseModel<CreateAssetImageScanSettingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAssetImageScanSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAssetImageScanSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器安全创建镜像扫描任务
        /// </summary>
        /// <param name="req"><see cref="CreateAssetImageScanTaskRequest"/></param>
        /// <returns><see cref="CreateAssetImageScanTaskResponse"/></returns>
        public async Task<CreateAssetImageScanTaskResponse> CreateAssetImageScanTask(CreateAssetImageScanTaskRequest req)
        {
             JsonResponseModel<CreateAssetImageScanTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAssetImageScanTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAssetImageScanTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器安全创建镜像扫描任务
        /// </summary>
        /// <param name="req"><see cref="CreateAssetImageScanTaskRequest"/></param>
        /// <returns><see cref="CreateAssetImageScanTaskResponse"/></returns>
        public CreateAssetImageScanTaskResponse CreateAssetImageScanTaskSync(CreateAssetImageScanTaskRequest req)
        {
             JsonResponseModel<CreateAssetImageScanTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAssetImageScanTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAssetImageScanTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建本地镜像木马列表导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateAssetImageVirusExportJobRequest"/></param>
        /// <returns><see cref="CreateAssetImageVirusExportJobResponse"/></returns>
        public async Task<CreateAssetImageVirusExportJobResponse> CreateAssetImageVirusExportJob(CreateAssetImageVirusExportJobRequest req)
        {
             JsonResponseModel<CreateAssetImageVirusExportJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAssetImageVirusExportJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAssetImageVirusExportJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建本地镜像木马列表导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateAssetImageVirusExportJobRequest"/></param>
        /// <returns><see cref="CreateAssetImageVirusExportJobResponse"/></returns>
        public CreateAssetImageVirusExportJobResponse CreateAssetImageVirusExportJobSync(CreateAssetImageVirusExportJobRequest req)
        {
             JsonResponseModel<CreateAssetImageVirusExportJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAssetImageVirusExportJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAssetImageVirusExportJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 安装检查组件，创建防护容器
        /// </summary>
        /// <param name="req"><see cref="CreateCheckComponentRequest"/></param>
        /// <returns><see cref="CreateCheckComponentResponse"/></returns>
        public async Task<CreateCheckComponentResponse> CreateCheckComponent(CreateCheckComponentRequest req)
        {
             JsonResponseModel<CreateCheckComponentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCheckComponent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCheckComponentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 安装检查组件，创建防护容器
        /// </summary>
        /// <param name="req"><see cref="CreateCheckComponentRequest"/></param>
        /// <returns><see cref="CreateCheckComponentResponse"/></returns>
        public CreateCheckComponentResponse CreateCheckComponentSync(CreateCheckComponentRequest req)
        {
             JsonResponseModel<CreateCheckComponentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCheckComponent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCheckComponentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建集群检查任务，用户检查用户的集群相关风险项
        /// </summary>
        /// <param name="req"><see cref="CreateClusterCheckTaskRequest"/></param>
        /// <returns><see cref="CreateClusterCheckTaskResponse"/></returns>
        public async Task<CreateClusterCheckTaskResponse> CreateClusterCheckTask(CreateClusterCheckTaskRequest req)
        {
             JsonResponseModel<CreateClusterCheckTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateClusterCheckTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterCheckTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建集群检查任务，用户检查用户的集群相关风险项
        /// </summary>
        /// <param name="req"><see cref="CreateClusterCheckTaskRequest"/></param>
        /// <returns><see cref="CreateClusterCheckTaskResponse"/></returns>
        public CreateClusterCheckTaskResponse CreateClusterCheckTaskSync(CreateClusterCheckTaskRequest req)
        {
             JsonResponseModel<CreateClusterCheckTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateClusterCheckTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClusterCheckTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建合规检查任务，在资产级别触发重新检测时使用。
        /// </summary>
        /// <param name="req"><see cref="CreateComplianceTaskRequest"/></param>
        /// <returns><see cref="CreateComplianceTaskResponse"/></returns>
        public async Task<CreateComplianceTaskResponse> CreateComplianceTask(CreateComplianceTaskRequest req)
        {
             JsonResponseModel<CreateComplianceTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateComplianceTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateComplianceTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建合规检查任务，在资产级别触发重新检测时使用。
        /// </summary>
        /// <param name="req"><see cref="CreateComplianceTaskRequest"/></param>
        /// <returns><see cref="CreateComplianceTaskResponse"/></returns>
        public CreateComplianceTaskResponse CreateComplianceTaskSync(CreateComplianceTaskRequest req)
        {
             JsonResponseModel<CreateComplianceTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateComplianceTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateComplianceTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询本地镜像组件列表导出
        /// </summary>
        /// <param name="req"><see cref="CreateComponentExportJobRequest"/></param>
        /// <returns><see cref="CreateComponentExportJobResponse"/></returns>
        public async Task<CreateComponentExportJobResponse> CreateComponentExportJob(CreateComponentExportJobRequest req)
        {
             JsonResponseModel<CreateComponentExportJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateComponentExportJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateComponentExportJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询本地镜像组件列表导出
        /// </summary>
        /// <param name="req"><see cref="CreateComponentExportJobRequest"/></param>
        /// <returns><see cref="CreateComponentExportJobResponse"/></returns>
        public CreateComponentExportJobResponse CreateComponentExportJobSync(CreateComponentExportJobRequest req)
        {
             JsonResponseModel<CreateComponentExportJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateComponentExportJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateComponentExportJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建支持防御的漏洞导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateDefenceVulExportJobRequest"/></param>
        /// <returns><see cref="CreateDefenceVulExportJobResponse"/></returns>
        public async Task<CreateDefenceVulExportJobResponse> CreateDefenceVulExportJob(CreateDefenceVulExportJobRequest req)
        {
             JsonResponseModel<CreateDefenceVulExportJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDefenceVulExportJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDefenceVulExportJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建支持防御的漏洞导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateDefenceVulExportJobRequest"/></param>
        /// <returns><see cref="CreateDefenceVulExportJobResponse"/></returns>
        public CreateDefenceVulExportJobResponse CreateDefenceVulExportJobSync(CreateDefenceVulExportJobRequest req)
        {
             JsonResponseModel<CreateDefenceVulExportJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDefenceVulExportJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDefenceVulExportJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建应急漏洞导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateEmergencyVulExportJobRequest"/></param>
        /// <returns><see cref="CreateEmergencyVulExportJobResponse"/></returns>
        public async Task<CreateEmergencyVulExportJobResponse> CreateEmergencyVulExportJob(CreateEmergencyVulExportJobRequest req)
        {
             JsonResponseModel<CreateEmergencyVulExportJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateEmergencyVulExportJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEmergencyVulExportJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建应急漏洞导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateEmergencyVulExportJobRequest"/></param>
        /// <returns><see cref="CreateEmergencyVulExportJobResponse"/></returns>
        public CreateEmergencyVulExportJobResponse CreateEmergencyVulExportJobSync(CreateEmergencyVulExportJobRequest req)
        {
             JsonResponseModel<CreateEmergencyVulExportJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateEmergencyVulExportJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEmergencyVulExportJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建逃逸事件导出异步任务
        /// </summary>
        /// <param name="req"><see cref="CreateEscapeEventsExportJobRequest"/></param>
        /// <returns><see cref="CreateEscapeEventsExportJobResponse"/></returns>
        public async Task<CreateEscapeEventsExportJobResponse> CreateEscapeEventsExportJob(CreateEscapeEventsExportJobRequest req)
        {
             JsonResponseModel<CreateEscapeEventsExportJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateEscapeEventsExportJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEscapeEventsExportJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建逃逸事件导出异步任务
        /// </summary>
        /// <param name="req"><see cref="CreateEscapeEventsExportJobRequest"/></param>
        /// <returns><see cref="CreateEscapeEventsExportJobResponse"/></returns>
        public CreateEscapeEventsExportJobResponse CreateEscapeEventsExportJobSync(CreateEscapeEventsExportJobRequest req)
        {
             JsonResponseModel<CreateEscapeEventsExportJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateEscapeEventsExportJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEscapeEventsExportJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建逃逸白名单导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateEscapeWhiteListExportJobRequest"/></param>
        /// <returns><see cref="CreateEscapeWhiteListExportJobResponse"/></returns>
        public async Task<CreateEscapeWhiteListExportJobResponse> CreateEscapeWhiteListExportJob(CreateEscapeWhiteListExportJobRequest req)
        {
             JsonResponseModel<CreateEscapeWhiteListExportJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateEscapeWhiteListExportJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEscapeWhiteListExportJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建逃逸白名单导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateEscapeWhiteListExportJobRequest"/></param>
        /// <returns><see cref="CreateEscapeWhiteListExportJobResponse"/></returns>
        public CreateEscapeWhiteListExportJobResponse CreateEscapeWhiteListExportJobSync(CreateEscapeWhiteListExportJobRequest req)
        {
             JsonResponseModel<CreateEscapeWhiteListExportJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateEscapeWhiteListExportJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEscapeWhiteListExportJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建一个导出安全合规信息的任务
        /// </summary>
        /// <param name="req"><see cref="CreateExportComplianceStatusListJobRequest"/></param>
        /// <returns><see cref="CreateExportComplianceStatusListJobResponse"/></returns>
        public async Task<CreateExportComplianceStatusListJobResponse> CreateExportComplianceStatusListJob(CreateExportComplianceStatusListJobRequest req)
        {
             JsonResponseModel<CreateExportComplianceStatusListJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateExportComplianceStatusListJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateExportComplianceStatusListJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建一个导出安全合规信息的任务
        /// </summary>
        /// <param name="req"><see cref="CreateExportComplianceStatusListJobRequest"/></param>
        /// <returns><see cref="CreateExportComplianceStatusListJobResponse"/></returns>
        public CreateExportComplianceStatusListJobResponse CreateExportComplianceStatusListJobSync(CreateExportComplianceStatusListJobRequest req)
        {
             JsonResponseModel<CreateExportComplianceStatusListJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateExportComplianceStatusListJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateExportComplianceStatusListJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建主机列表导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateHostExportJobRequest"/></param>
        /// <returns><see cref="CreateHostExportJobResponse"/></returns>
        public async Task<CreateHostExportJobResponse> CreateHostExportJob(CreateHostExportJobRequest req)
        {
             JsonResponseModel<CreateHostExportJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateHostExportJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateHostExportJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建主机列表导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateHostExportJobRequest"/></param>
        /// <returns><see cref="CreateHostExportJobResponse"/></returns>
        public CreateHostExportJobResponse CreateHostExportJobSync(CreateHostExportJobRequest req)
        {
             JsonResponseModel<CreateHostExportJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateHostExportJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateHostExportJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建镜像导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateImageExportJobRequest"/></param>
        /// <returns><see cref="CreateImageExportJobResponse"/></returns>
        public async Task<CreateImageExportJobResponse> CreateImageExportJob(CreateImageExportJobRequest req)
        {
             JsonResponseModel<CreateImageExportJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateImageExportJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateImageExportJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建镜像导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateImageExportJobRequest"/></param>
        /// <returns><see cref="CreateImageExportJobResponse"/></returns>
        public CreateImageExportJobResponse CreateImageExportJobSync(CreateImageExportJobRequest req)
        {
             JsonResponseModel<CreateImageExportJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateImageExportJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateImageExportJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器网络集群下发刷新任务
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkFirewallClusterRefreshRequest"/></param>
        /// <returns><see cref="CreateNetworkFirewallClusterRefreshResponse"/></returns>
        public async Task<CreateNetworkFirewallClusterRefreshResponse> CreateNetworkFirewallClusterRefresh(CreateNetworkFirewallClusterRefreshRequest req)
        {
             JsonResponseModel<CreateNetworkFirewallClusterRefreshResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNetworkFirewallClusterRefresh");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNetworkFirewallClusterRefreshResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器网络集群下发刷新任务
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkFirewallClusterRefreshRequest"/></param>
        /// <returns><see cref="CreateNetworkFirewallClusterRefreshResponse"/></returns>
        public CreateNetworkFirewallClusterRefreshResponse CreateNetworkFirewallClusterRefreshSync(CreateNetworkFirewallClusterRefreshRequest req)
        {
             JsonResponseModel<CreateNetworkFirewallClusterRefreshResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateNetworkFirewallClusterRefresh");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNetworkFirewallClusterRefreshResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器网络集群网络策略创建自动发现任务
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkFirewallPolicyDiscoverRequest"/></param>
        /// <returns><see cref="CreateNetworkFirewallPolicyDiscoverResponse"/></returns>
        public async Task<CreateNetworkFirewallPolicyDiscoverResponse> CreateNetworkFirewallPolicyDiscover(CreateNetworkFirewallPolicyDiscoverRequest req)
        {
             JsonResponseModel<CreateNetworkFirewallPolicyDiscoverResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNetworkFirewallPolicyDiscover");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNetworkFirewallPolicyDiscoverResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器网络集群网络策略创建自动发现任务
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkFirewallPolicyDiscoverRequest"/></param>
        /// <returns><see cref="CreateNetworkFirewallPolicyDiscoverResponse"/></returns>
        public CreateNetworkFirewallPolicyDiscoverResponse CreateNetworkFirewallPolicyDiscoverSync(CreateNetworkFirewallPolicyDiscoverRequest req)
        {
             JsonResponseModel<CreateNetworkFirewallPolicyDiscoverResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateNetworkFirewallPolicyDiscover");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNetworkFirewallPolicyDiscoverResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器网络创建网络策略发布任务
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkFirewallPublishRequest"/></param>
        /// <returns><see cref="CreateNetworkFirewallPublishResponse"/></returns>
        public async Task<CreateNetworkFirewallPublishResponse> CreateNetworkFirewallPublish(CreateNetworkFirewallPublishRequest req)
        {
             JsonResponseModel<CreateNetworkFirewallPublishResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNetworkFirewallPublish");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNetworkFirewallPublishResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器网络创建网络策略发布任务
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkFirewallPublishRequest"/></param>
        /// <returns><see cref="CreateNetworkFirewallPublishResponse"/></returns>
        public CreateNetworkFirewallPublishResponse CreateNetworkFirewallPublishSync(CreateNetworkFirewallPublishRequest req)
        {
             JsonResponseModel<CreateNetworkFirewallPublishResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateNetworkFirewallPublish");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNetworkFirewallPublishResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器网络创建网络策略撤销任务
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkFirewallUndoPublishRequest"/></param>
        /// <returns><see cref="CreateNetworkFirewallUndoPublishResponse"/></returns>
        public async Task<CreateNetworkFirewallUndoPublishResponse> CreateNetworkFirewallUndoPublish(CreateNetworkFirewallUndoPublishRequest req)
        {
             JsonResponseModel<CreateNetworkFirewallUndoPublishResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNetworkFirewallUndoPublish");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNetworkFirewallUndoPublishResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器网络创建网络策略撤销任务
        /// </summary>
        /// <param name="req"><see cref="CreateNetworkFirewallUndoPublishRequest"/></param>
        /// <returns><see cref="CreateNetworkFirewallUndoPublishResponse"/></returns>
        public CreateNetworkFirewallUndoPublishResponse CreateNetworkFirewallUndoPublishSync(CreateNetworkFirewallUndoPublishRequest req)
        {
             JsonResponseModel<CreateNetworkFirewallUndoPublishResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateNetworkFirewallUndoPublish");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNetworkFirewallUndoPublishResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateOrModifyPostPayCores  创建或者编辑弹性计费上限
        /// </summary>
        /// <param name="req"><see cref="CreateOrModifyPostPayCoresRequest"/></param>
        /// <returns><see cref="CreateOrModifyPostPayCoresResponse"/></returns>
        public async Task<CreateOrModifyPostPayCoresResponse> CreateOrModifyPostPayCores(CreateOrModifyPostPayCoresRequest req)
        {
             JsonResponseModel<CreateOrModifyPostPayCoresResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateOrModifyPostPayCores");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOrModifyPostPayCoresResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// CreateOrModifyPostPayCores  创建或者编辑弹性计费上限
        /// </summary>
        /// <param name="req"><see cref="CreateOrModifyPostPayCoresRequest"/></param>
        /// <returns><see cref="CreateOrModifyPostPayCoresResponse"/></returns>
        public CreateOrModifyPostPayCoresResponse CreateOrModifyPostPayCoresSync(CreateOrModifyPostPayCoresRequest req)
        {
             JsonResponseModel<CreateOrModifyPostPayCoresResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateOrModifyPostPayCores");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOrModifyPostPayCoresResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建异常进程事件导出异步任务
        /// </summary>
        /// <param name="req"><see cref="CreateProcessEventsExportJobRequest"/></param>
        /// <returns><see cref="CreateProcessEventsExportJobResponse"/></returns>
        public async Task<CreateProcessEventsExportJobResponse> CreateProcessEventsExportJob(CreateProcessEventsExportJobRequest req)
        {
             JsonResponseModel<CreateProcessEventsExportJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateProcessEventsExportJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProcessEventsExportJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建异常进程事件导出异步任务
        /// </summary>
        /// <param name="req"><see cref="CreateProcessEventsExportJobRequest"/></param>
        /// <returns><see cref="CreateProcessEventsExportJobResponse"/></returns>
        public CreateProcessEventsExportJobResponse CreateProcessEventsExportJobSync(CreateProcessEventsExportJobRequest req)
        {
             JsonResponseModel<CreateProcessEventsExportJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateProcessEventsExportJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProcessEventsExportJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 下发刷新任务，会刷新资产信息
        /// </summary>
        /// <param name="req"><see cref="CreateRefreshTaskRequest"/></param>
        /// <returns><see cref="CreateRefreshTaskResponse"/></returns>
        public async Task<CreateRefreshTaskResponse> CreateRefreshTask(CreateRefreshTaskRequest req)
        {
             JsonResponseModel<CreateRefreshTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRefreshTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRefreshTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 下发刷新任务，会刷新资产信息
        /// </summary>
        /// <param name="req"><see cref="CreateRefreshTaskRequest"/></param>
        /// <returns><see cref="CreateRefreshTaskResponse"/></returns>
        public CreateRefreshTaskResponse CreateRefreshTaskSync(CreateRefreshTaskRequest req)
        {
             JsonResponseModel<CreateRefreshTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRefreshTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRefreshTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加检索模板
        /// </summary>
        /// <param name="req"><see cref="CreateSearchTemplateRequest"/></param>
        /// <returns><see cref="CreateSearchTemplateResponse"/></returns>
        public async Task<CreateSearchTemplateResponse> CreateSearchTemplate(CreateSearchTemplateRequest req)
        {
             JsonResponseModel<CreateSearchTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSearchTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSearchTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加检索模板
        /// </summary>
        /// <param name="req"><see cref="CreateSearchTemplateRequest"/></param>
        /// <returns><see cref="CreateSearchTemplateResponse"/></returns>
        public CreateSearchTemplateResponse CreateSearchTemplateSync(CreateSearchTemplateRequest req)
        {
             JsonResponseModel<CreateSearchTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSearchTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSearchTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建系统漏洞导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateSystemVulExportJobRequest"/></param>
        /// <returns><see cref="CreateSystemVulExportJobResponse"/></returns>
        public async Task<CreateSystemVulExportJobResponse> CreateSystemVulExportJob(CreateSystemVulExportJobRequest req)
        {
             JsonResponseModel<CreateSystemVulExportJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSystemVulExportJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSystemVulExportJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建系统漏洞导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateSystemVulExportJobRequest"/></param>
        /// <returns><see cref="CreateSystemVulExportJobResponse"/></returns>
        public CreateSystemVulExportJobResponse CreateSystemVulExportJobSync(CreateSystemVulExportJobRequest req)
        {
             JsonResponseModel<CreateSystemVulExportJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSystemVulExportJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSystemVulExportJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运行时文件查杀重新检测
        /// </summary>
        /// <param name="req"><see cref="CreateVirusScanAgainRequest"/></param>
        /// <returns><see cref="CreateVirusScanAgainResponse"/></returns>
        public async Task<CreateVirusScanAgainResponse> CreateVirusScanAgain(CreateVirusScanAgainRequest req)
        {
             JsonResponseModel<CreateVirusScanAgainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateVirusScanAgain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVirusScanAgainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运行时文件查杀重新检测
        /// </summary>
        /// <param name="req"><see cref="CreateVirusScanAgainRequest"/></param>
        /// <returns><see cref="CreateVirusScanAgainResponse"/></returns>
        public CreateVirusScanAgainResponse CreateVirusScanAgainSync(CreateVirusScanAgainRequest req)
        {
             JsonResponseModel<CreateVirusScanAgainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateVirusScanAgain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVirusScanAgainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运行时文件查杀一键扫描
        /// </summary>
        /// <param name="req"><see cref="CreateVirusScanTaskRequest"/></param>
        /// <returns><see cref="CreateVirusScanTaskResponse"/></returns>
        public async Task<CreateVirusScanTaskResponse> CreateVirusScanTask(CreateVirusScanTaskRequest req)
        {
             JsonResponseModel<CreateVirusScanTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateVirusScanTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVirusScanTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运行时文件查杀一键扫描
        /// </summary>
        /// <param name="req"><see cref="CreateVirusScanTaskRequest"/></param>
        /// <returns><see cref="CreateVirusScanTaskResponse"/></returns>
        public CreateVirusScanTaskResponse CreateVirusScanTaskSync(CreateVirusScanTaskRequest req)
        {
             JsonResponseModel<CreateVirusScanTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateVirusScanTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVirusScanTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建受漏洞影响的容器导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateVulContainerExportJobRequest"/></param>
        /// <returns><see cref="CreateVulContainerExportJobResponse"/></returns>
        public async Task<CreateVulContainerExportJobResponse> CreateVulContainerExportJob(CreateVulContainerExportJobRequest req)
        {
             JsonResponseModel<CreateVulContainerExportJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateVulContainerExportJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVulContainerExportJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建受漏洞影响的容器导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateVulContainerExportJobRequest"/></param>
        /// <returns><see cref="CreateVulContainerExportJobResponse"/></returns>
        public CreateVulContainerExportJobResponse CreateVulContainerExportJobSync(CreateVulContainerExportJobRequest req)
        {
             JsonResponseModel<CreateVulContainerExportJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateVulContainerExportJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVulContainerExportJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建漏洞防御导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateVulDefenceEventExportJobRequest"/></param>
        /// <returns><see cref="CreateVulDefenceEventExportJobResponse"/></returns>
        public async Task<CreateVulDefenceEventExportJobResponse> CreateVulDefenceEventExportJob(CreateVulDefenceEventExportJobRequest req)
        {
             JsonResponseModel<CreateVulDefenceEventExportJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateVulDefenceEventExportJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVulDefenceEventExportJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建漏洞防御导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateVulDefenceEventExportJobRequest"/></param>
        /// <returns><see cref="CreateVulDefenceEventExportJobResponse"/></returns>
        public CreateVulDefenceEventExportJobResponse CreateVulDefenceEventExportJobSync(CreateVulDefenceEventExportJobRequest req)
        {
             JsonResponseModel<CreateVulDefenceEventExportJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateVulDefenceEventExportJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVulDefenceEventExportJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建漏洞防御主机导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateVulDefenceHostExportJobRequest"/></param>
        /// <returns><see cref="CreateVulDefenceHostExportJobResponse"/></returns>
        public async Task<CreateVulDefenceHostExportJobResponse> CreateVulDefenceHostExportJob(CreateVulDefenceHostExportJobRequest req)
        {
             JsonResponseModel<CreateVulDefenceHostExportJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateVulDefenceHostExportJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVulDefenceHostExportJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建漏洞防御主机导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateVulDefenceHostExportJobRequest"/></param>
        /// <returns><see cref="CreateVulDefenceHostExportJobResponse"/></returns>
        public CreateVulDefenceHostExportJobResponse CreateVulDefenceHostExportJobSync(CreateVulDefenceHostExportJobRequest req)
        {
             JsonResponseModel<CreateVulDefenceHostExportJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateVulDefenceHostExportJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVulDefenceHostExportJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询本地镜像漏洞列表导出
        /// </summary>
        /// <param name="req"><see cref="CreateVulExportJobRequest"/></param>
        /// <returns><see cref="CreateVulExportJobResponse"/></returns>
        public async Task<CreateVulExportJobResponse> CreateVulExportJob(CreateVulExportJobRequest req)
        {
             JsonResponseModel<CreateVulExportJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateVulExportJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVulExportJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询本地镜像漏洞列表导出
        /// </summary>
        /// <param name="req"><see cref="CreateVulExportJobRequest"/></param>
        /// <returns><see cref="CreateVulExportJobResponse"/></returns>
        public CreateVulExportJobResponse CreateVulExportJobSync(CreateVulExportJobRequest req)
        {
             JsonResponseModel<CreateVulExportJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateVulExportJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVulExportJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建受漏洞影响的镜像导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateVulImageExportJobRequest"/></param>
        /// <returns><see cref="CreateVulImageExportJobResponse"/></returns>
        public async Task<CreateVulImageExportJobResponse> CreateVulImageExportJob(CreateVulImageExportJobRequest req)
        {
             JsonResponseModel<CreateVulImageExportJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateVulImageExportJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVulImageExportJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建受漏洞影响的镜像导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateVulImageExportJobRequest"/></param>
        /// <returns><see cref="CreateVulImageExportJobResponse"/></returns>
        public CreateVulImageExportJobResponse CreateVulImageExportJobSync(CreateVulImageExportJobRequest req)
        {
             JsonResponseModel<CreateVulImageExportJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateVulImageExportJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVulImageExportJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建漏洞扫描任务
        /// </summary>
        /// <param name="req"><see cref="CreateVulScanTaskRequest"/></param>
        /// <returns><see cref="CreateVulScanTaskResponse"/></returns>
        public async Task<CreateVulScanTaskResponse> CreateVulScanTask(CreateVulScanTaskRequest req)
        {
             JsonResponseModel<CreateVulScanTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateVulScanTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVulScanTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建漏洞扫描任务
        /// </summary>
        /// <param name="req"><see cref="CreateVulScanTaskRequest"/></param>
        /// <returns><see cref="CreateVulScanTaskResponse"/></returns>
        public CreateVulScanTaskResponse CreateVulScanTaskSync(CreateVulScanTaskRequest req)
        {
             JsonResponseModel<CreateVulScanTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateVulScanTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateVulScanTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建web漏洞导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateWebVulExportJobRequest"/></param>
        /// <returns><see cref="CreateWebVulExportJobResponse"/></returns>
        public async Task<CreateWebVulExportJobResponse> CreateWebVulExportJob(CreateWebVulExportJobRequest req)
        {
             JsonResponseModel<CreateWebVulExportJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateWebVulExportJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWebVulExportJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建web漏洞导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateWebVulExportJobRequest"/></param>
        /// <returns><see cref="CreateWebVulExportJobResponse"/></returns>
        public CreateWebVulExportJobResponse CreateWebVulExportJobSync(CreateWebVulExportJobRequest req)
        {
             JsonResponseModel<CreateWebVulExportJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateWebVulExportJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWebVulExportJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除运行异常进程策略
        /// </summary>
        /// <param name="req"><see cref="DeleteAbnormalProcessRulesRequest"/></param>
        /// <returns><see cref="DeleteAbnormalProcessRulesResponse"/></returns>
        public async Task<DeleteAbnormalProcessRulesResponse> DeleteAbnormalProcessRules(DeleteAbnormalProcessRulesRequest req)
        {
             JsonResponseModel<DeleteAbnormalProcessRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAbnormalProcessRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAbnormalProcessRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除运行异常进程策略
        /// </summary>
        /// <param name="req"><see cref="DeleteAbnormalProcessRulesRequest"/></param>
        /// <returns><see cref="DeleteAbnormalProcessRulesResponse"/></returns>
        public DeleteAbnormalProcessRulesResponse DeleteAbnormalProcessRulesSync(DeleteAbnormalProcessRulesRequest req)
        {
             JsonResponseModel<DeleteAbnormalProcessRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAbnormalProcessRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAbnormalProcessRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除运行访问控制策略
        /// </summary>
        /// <param name="req"><see cref="DeleteAccessControlRulesRequest"/></param>
        /// <returns><see cref="DeleteAccessControlRulesResponse"/></returns>
        public async Task<DeleteAccessControlRulesResponse> DeleteAccessControlRules(DeleteAccessControlRulesRequest req)
        {
             JsonResponseModel<DeleteAccessControlRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAccessControlRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAccessControlRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除运行访问控制策略
        /// </summary>
        /// <param name="req"><see cref="DeleteAccessControlRulesRequest"/></param>
        /// <returns><see cref="DeleteAccessControlRulesResponse"/></returns>
        public DeleteAccessControlRulesResponse DeleteAccessControlRulesSync(DeleteAccessControlRulesRequest req)
        {
             JsonResponseModel<DeleteAccessControlRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAccessControlRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAccessControlRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 移除安全合规忽略(资产+检测项)列表，不显示指定的检查项包含的资产内容
        /// 参考的AddCompliancePolicyAssetSetToWhitelist，除输入字段外，其它应该是一致的，如果有不同可能是定义的不对
        /// </summary>
        /// <param name="req"><see cref="DeleteComplianceAssetPolicySetFromWhitelistRequest"/></param>
        /// <returns><see cref="DeleteComplianceAssetPolicySetFromWhitelistResponse"/></returns>
        public async Task<DeleteComplianceAssetPolicySetFromWhitelistResponse> DeleteComplianceAssetPolicySetFromWhitelist(DeleteComplianceAssetPolicySetFromWhitelistRequest req)
        {
             JsonResponseModel<DeleteComplianceAssetPolicySetFromWhitelistResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteComplianceAssetPolicySetFromWhitelist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteComplianceAssetPolicySetFromWhitelistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 移除安全合规忽略(资产+检测项)列表，不显示指定的检查项包含的资产内容
        /// 参考的AddCompliancePolicyAssetSetToWhitelist，除输入字段外，其它应该是一致的，如果有不同可能是定义的不对
        /// </summary>
        /// <param name="req"><see cref="DeleteComplianceAssetPolicySetFromWhitelistRequest"/></param>
        /// <returns><see cref="DeleteComplianceAssetPolicySetFromWhitelistResponse"/></returns>
        public DeleteComplianceAssetPolicySetFromWhitelistResponse DeleteComplianceAssetPolicySetFromWhitelistSync(DeleteComplianceAssetPolicySetFromWhitelistRequest req)
        {
             JsonResponseModel<DeleteComplianceAssetPolicySetFromWhitelistResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteComplianceAssetPolicySetFromWhitelist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteComplianceAssetPolicySetFromWhitelistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增安全合规忽略(检测项+资产)列表，不显示指定的检查项包含的资产内容
        /// </summary>
        /// <param name="req"><see cref="DeleteCompliancePolicyAssetSetFromWhitelistRequest"/></param>
        /// <returns><see cref="DeleteCompliancePolicyAssetSetFromWhitelistResponse"/></returns>
        public async Task<DeleteCompliancePolicyAssetSetFromWhitelistResponse> DeleteCompliancePolicyAssetSetFromWhitelist(DeleteCompliancePolicyAssetSetFromWhitelistRequest req)
        {
             JsonResponseModel<DeleteCompliancePolicyAssetSetFromWhitelistResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCompliancePolicyAssetSetFromWhitelist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCompliancePolicyAssetSetFromWhitelistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增安全合规忽略(检测项+资产)列表，不显示指定的检查项包含的资产内容
        /// </summary>
        /// <param name="req"><see cref="DeleteCompliancePolicyAssetSetFromWhitelistRequest"/></param>
        /// <returns><see cref="DeleteCompliancePolicyAssetSetFromWhitelistResponse"/></returns>
        public DeleteCompliancePolicyAssetSetFromWhitelistResponse DeleteCompliancePolicyAssetSetFromWhitelistSync(DeleteCompliancePolicyAssetSetFromWhitelistRequest req)
        {
             JsonResponseModel<DeleteCompliancePolicyAssetSetFromWhitelistResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCompliancePolicyAssetSetFromWhitelist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCompliancePolicyAssetSetFromWhitelistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 从白名单中删除将指定的检测项。
        /// </summary>
        /// <param name="req"><see cref="DeleteCompliancePolicyItemFromWhitelistRequest"/></param>
        /// <returns><see cref="DeleteCompliancePolicyItemFromWhitelistResponse"/></returns>
        public async Task<DeleteCompliancePolicyItemFromWhitelistResponse> DeleteCompliancePolicyItemFromWhitelist(DeleteCompliancePolicyItemFromWhitelistRequest req)
        {
             JsonResponseModel<DeleteCompliancePolicyItemFromWhitelistResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCompliancePolicyItemFromWhitelist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCompliancePolicyItemFromWhitelistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 从白名单中删除将指定的检测项。
        /// </summary>
        /// <param name="req"><see cref="DeleteCompliancePolicyItemFromWhitelistRequest"/></param>
        /// <returns><see cref="DeleteCompliancePolicyItemFromWhitelistResponse"/></returns>
        public DeleteCompliancePolicyItemFromWhitelistResponse DeleteCompliancePolicyItemFromWhitelistSync(DeleteCompliancePolicyItemFromWhitelistRequest req)
        {
             JsonResponseModel<DeleteCompliancePolicyItemFromWhitelistResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCompliancePolicyItemFromWhitelist");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCompliancePolicyItemFromWhitelistResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除逃逸白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteEscapeWhiteListRequest"/></param>
        /// <returns><see cref="DeleteEscapeWhiteListResponse"/></returns>
        public async Task<DeleteEscapeWhiteListResponse> DeleteEscapeWhiteList(DeleteEscapeWhiteListRequest req)
        {
             JsonResponseModel<DeleteEscapeWhiteListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteEscapeWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEscapeWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除逃逸白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteEscapeWhiteListRequest"/></param>
        /// <returns><see cref="DeleteEscapeWhiteListResponse"/></returns>
        public DeleteEscapeWhiteListResponse DeleteEscapeWhiteListSync(DeleteEscapeWhiteListRequest req)
        {
             JsonResponseModel<DeleteEscapeWhiteListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteEscapeWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEscapeWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 取消漏洞扫描忽略漏洞
        /// </summary>
        /// <param name="req"><see cref="DeleteIgnoreVulRequest"/></param>
        /// <returns><see cref="DeleteIgnoreVulResponse"/></returns>
        public async Task<DeleteIgnoreVulResponse> DeleteIgnoreVul(DeleteIgnoreVulRequest req)
        {
             JsonResponseModel<DeleteIgnoreVulResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteIgnoreVul");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteIgnoreVulResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 取消漏洞扫描忽略漏洞
        /// </summary>
        /// <param name="req"><see cref="DeleteIgnoreVulRequest"/></param>
        /// <returns><see cref="DeleteIgnoreVulResponse"/></returns>
        public DeleteIgnoreVulResponse DeleteIgnoreVulSync(DeleteIgnoreVulRequest req)
        {
             JsonResponseModel<DeleteIgnoreVulResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteIgnoreVul");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteIgnoreVulResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 卸载Agent客户端
        /// </summary>
        /// <param name="req"><see cref="DeleteMachineRequest"/></param>
        /// <returns><see cref="DeleteMachineResponse"/></returns>
        public async Task<DeleteMachineResponse> DeleteMachine(DeleteMachineRequest req)
        {
             JsonResponseModel<DeleteMachineResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMachine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMachineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 卸载Agent客户端
        /// </summary>
        /// <param name="req"><see cref="DeleteMachineRequest"/></param>
        /// <returns><see cref="DeleteMachineResponse"/></returns>
        public DeleteMachineResponse DeleteMachineSync(DeleteMachineRequest req)
        {
             JsonResponseModel<DeleteMachineResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteMachine");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMachineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器网络创建网络策略删除任务
        /// </summary>
        /// <param name="req"><see cref="DeleteNetworkFirewallPolicyDetailRequest"/></param>
        /// <returns><see cref="DeleteNetworkFirewallPolicyDetailResponse"/></returns>
        public async Task<DeleteNetworkFirewallPolicyDetailResponse> DeleteNetworkFirewallPolicyDetail(DeleteNetworkFirewallPolicyDetailRequest req)
        {
             JsonResponseModel<DeleteNetworkFirewallPolicyDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteNetworkFirewallPolicyDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNetworkFirewallPolicyDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器网络创建网络策略删除任务
        /// </summary>
        /// <param name="req"><see cref="DeleteNetworkFirewallPolicyDetailRequest"/></param>
        /// <returns><see cref="DeleteNetworkFirewallPolicyDetailResponse"/></returns>
        public DeleteNetworkFirewallPolicyDetailResponse DeleteNetworkFirewallPolicyDetailSync(DeleteNetworkFirewallPolicyDetailRequest req)
        {
             JsonResponseModel<DeleteNetworkFirewallPolicyDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteNetworkFirewallPolicyDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNetworkFirewallPolicyDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除运行时反弹shell事件
        /// </summary>
        /// <param name="req"><see cref="DeleteReverseShellEventsRequest"/></param>
        /// <returns><see cref="DeleteReverseShellEventsResponse"/></returns>
        public async Task<DeleteReverseShellEventsResponse> DeleteReverseShellEvents(DeleteReverseShellEventsRequest req)
        {
             JsonResponseModel<DeleteReverseShellEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteReverseShellEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteReverseShellEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除运行时反弹shell事件
        /// </summary>
        /// <param name="req"><see cref="DeleteReverseShellEventsRequest"/></param>
        /// <returns><see cref="DeleteReverseShellEventsResponse"/></returns>
        public DeleteReverseShellEventsResponse DeleteReverseShellEventsSync(DeleteReverseShellEventsRequest req)
        {
             JsonResponseModel<DeleteReverseShellEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteReverseShellEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteReverseShellEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除运行时反弹shell白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteReverseShellWhiteListsRequest"/></param>
        /// <returns><see cref="DeleteReverseShellWhiteListsResponse"/></returns>
        public async Task<DeleteReverseShellWhiteListsResponse> DeleteReverseShellWhiteLists(DeleteReverseShellWhiteListsRequest req)
        {
             JsonResponseModel<DeleteReverseShellWhiteListsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteReverseShellWhiteLists");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteReverseShellWhiteListsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除运行时反弹shell白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteReverseShellWhiteListsRequest"/></param>
        /// <returns><see cref="DeleteReverseShellWhiteListsResponse"/></returns>
        public DeleteReverseShellWhiteListsResponse DeleteReverseShellWhiteListsSync(DeleteReverseShellWhiteListsRequest req)
        {
             JsonResponseModel<DeleteReverseShellWhiteListsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteReverseShellWhiteLists");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteReverseShellWhiteListsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除运行时高危系统调用事件
        /// </summary>
        /// <param name="req"><see cref="DeleteRiskSyscallEventsRequest"/></param>
        /// <returns><see cref="DeleteRiskSyscallEventsResponse"/></returns>
        public async Task<DeleteRiskSyscallEventsResponse> DeleteRiskSyscallEvents(DeleteRiskSyscallEventsRequest req)
        {
             JsonResponseModel<DeleteRiskSyscallEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRiskSyscallEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRiskSyscallEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除运行时高危系统调用事件
        /// </summary>
        /// <param name="req"><see cref="DeleteRiskSyscallEventsRequest"/></param>
        /// <returns><see cref="DeleteRiskSyscallEventsResponse"/></returns>
        public DeleteRiskSyscallEventsResponse DeleteRiskSyscallEventsSync(DeleteRiskSyscallEventsRequest req)
        {
             JsonResponseModel<DeleteRiskSyscallEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRiskSyscallEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRiskSyscallEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除运行时高危系统调用白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteRiskSyscallWhiteListsRequest"/></param>
        /// <returns><see cref="DeleteRiskSyscallWhiteListsResponse"/></returns>
        public async Task<DeleteRiskSyscallWhiteListsResponse> DeleteRiskSyscallWhiteLists(DeleteRiskSyscallWhiteListsRequest req)
        {
             JsonResponseModel<DeleteRiskSyscallWhiteListsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRiskSyscallWhiteLists");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRiskSyscallWhiteListsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除运行时高危系统调用白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteRiskSyscallWhiteListsRequest"/></param>
        /// <returns><see cref="DeleteRiskSyscallWhiteListsResponse"/></returns>
        public DeleteRiskSyscallWhiteListsResponse DeleteRiskSyscallWhiteListsSync(DeleteRiskSyscallWhiteListsRequest req)
        {
             JsonResponseModel<DeleteRiskSyscallWhiteListsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRiskSyscallWhiteLists");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRiskSyscallWhiteListsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除检索模板
        /// </summary>
        /// <param name="req"><see cref="DeleteSearchTemplateRequest"/></param>
        /// <returns><see cref="DeleteSearchTemplateResponse"/></returns>
        public async Task<DeleteSearchTemplateResponse> DeleteSearchTemplate(DeleteSearchTemplateRequest req)
        {
             JsonResponseModel<DeleteSearchTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSearchTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSearchTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除检索模板
        /// </summary>
        /// <param name="req"><see cref="DeleteSearchTemplateRequest"/></param>
        /// <returns><see cref="DeleteSearchTemplateResponse"/></returns>
        public DeleteSearchTemplateResponse DeleteSearchTemplateSync(DeleteSearchTemplateRequest req)
        {
             JsonResponseModel<DeleteSearchTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSearchTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSearchTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户当前灰度配置
        /// </summary>
        /// <param name="req"><see cref="DescribeABTestConfigRequest"/></param>
        /// <returns><see cref="DescribeABTestConfigResponse"/></returns>
        public async Task<DescribeABTestConfigResponse> DescribeABTestConfig(DescribeABTestConfigRequest req)
        {
             JsonResponseModel<DescribeABTestConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeABTestConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeABTestConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户当前灰度配置
        /// </summary>
        /// <param name="req"><see cref="DescribeABTestConfigRequest"/></param>
        /// <returns><see cref="DescribeABTestConfigResponse"/></returns>
        public DescribeABTestConfigResponse DescribeABTestConfigSync(DescribeABTestConfigRequest req)
        {
             JsonResponseModel<DescribeABTestConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeABTestConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeABTestConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询运行时异常进程事件详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAbnormalProcessDetailRequest"/></param>
        /// <returns><see cref="DescribeAbnormalProcessDetailResponse"/></returns>
        public async Task<DescribeAbnormalProcessDetailResponse> DescribeAbnormalProcessDetail(DescribeAbnormalProcessDetailRequest req)
        {
             JsonResponseModel<DescribeAbnormalProcessDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAbnormalProcessDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAbnormalProcessDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询运行时异常进程事件详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAbnormalProcessDetailRequest"/></param>
        /// <returns><see cref="DescribeAbnormalProcessDetailResponse"/></returns>
        public DescribeAbnormalProcessDetailResponse DescribeAbnormalProcessDetailSync(DescribeAbnormalProcessDetailRequest req)
        {
             JsonResponseModel<DescribeAbnormalProcessDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAbnormalProcessDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAbnormalProcessDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询待处理异常进程事件趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeAbnormalProcessEventTendencyRequest"/></param>
        /// <returns><see cref="DescribeAbnormalProcessEventTendencyResponse"/></returns>
        public async Task<DescribeAbnormalProcessEventTendencyResponse> DescribeAbnormalProcessEventTendency(DescribeAbnormalProcessEventTendencyRequest req)
        {
             JsonResponseModel<DescribeAbnormalProcessEventTendencyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAbnormalProcessEventTendency");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAbnormalProcessEventTendencyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询待处理异常进程事件趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeAbnormalProcessEventTendencyRequest"/></param>
        /// <returns><see cref="DescribeAbnormalProcessEventTendencyResponse"/></returns>
        public DescribeAbnormalProcessEventTendencyResponse DescribeAbnormalProcessEventTendencySync(DescribeAbnormalProcessEventTendencyRequest req)
        {
             JsonResponseModel<DescribeAbnormalProcessEventTendencyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAbnormalProcessEventTendency");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAbnormalProcessEventTendencyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询运行时异常进程事件列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAbnormalProcessEventsRequest"/></param>
        /// <returns><see cref="DescribeAbnormalProcessEventsResponse"/></returns>
        public async Task<DescribeAbnormalProcessEventsResponse> DescribeAbnormalProcessEvents(DescribeAbnormalProcessEventsRequest req)
        {
             JsonResponseModel<DescribeAbnormalProcessEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAbnormalProcessEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAbnormalProcessEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询运行时异常进程事件列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAbnormalProcessEventsRequest"/></param>
        /// <returns><see cref="DescribeAbnormalProcessEventsResponse"/></returns>
        public DescribeAbnormalProcessEventsResponse DescribeAbnormalProcessEventsSync(DescribeAbnormalProcessEventsRequest req)
        {
             JsonResponseModel<DescribeAbnormalProcessEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAbnormalProcessEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAbnormalProcessEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询运行时异常进程事件列表信息导出
        /// </summary>
        /// <param name="req"><see cref="DescribeAbnormalProcessEventsExportRequest"/></param>
        /// <returns><see cref="DescribeAbnormalProcessEventsExportResponse"/></returns>
        public async Task<DescribeAbnormalProcessEventsExportResponse> DescribeAbnormalProcessEventsExport(DescribeAbnormalProcessEventsExportRequest req)
        {
             JsonResponseModel<DescribeAbnormalProcessEventsExportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAbnormalProcessEventsExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAbnormalProcessEventsExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询运行时异常进程事件列表信息导出
        /// </summary>
        /// <param name="req"><see cref="DescribeAbnormalProcessEventsExportRequest"/></param>
        /// <returns><see cref="DescribeAbnormalProcessEventsExportResponse"/></returns>
        public DescribeAbnormalProcessEventsExportResponse DescribeAbnormalProcessEventsExportSync(DescribeAbnormalProcessEventsExportRequest req)
        {
             JsonResponseModel<DescribeAbnormalProcessEventsExportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAbnormalProcessEventsExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAbnormalProcessEventsExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 统计异常进程各威胁等级待处理事件数
        /// </summary>
        /// <param name="req"><see cref="DescribeAbnormalProcessLevelSummaryRequest"/></param>
        /// <returns><see cref="DescribeAbnormalProcessLevelSummaryResponse"/></returns>
        public async Task<DescribeAbnormalProcessLevelSummaryResponse> DescribeAbnormalProcessLevelSummary(DescribeAbnormalProcessLevelSummaryRequest req)
        {
             JsonResponseModel<DescribeAbnormalProcessLevelSummaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAbnormalProcessLevelSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAbnormalProcessLevelSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 统计异常进程各威胁等级待处理事件数
        /// </summary>
        /// <param name="req"><see cref="DescribeAbnormalProcessLevelSummaryRequest"/></param>
        /// <returns><see cref="DescribeAbnormalProcessLevelSummaryResponse"/></returns>
        public DescribeAbnormalProcessLevelSummaryResponse DescribeAbnormalProcessLevelSummarySync(DescribeAbnormalProcessLevelSummaryRequest req)
        {
             JsonResponseModel<DescribeAbnormalProcessLevelSummaryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAbnormalProcessLevelSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAbnormalProcessLevelSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询运行时异常策略详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAbnormalProcessRuleDetailRequest"/></param>
        /// <returns><see cref="DescribeAbnormalProcessRuleDetailResponse"/></returns>
        public async Task<DescribeAbnormalProcessRuleDetailResponse> DescribeAbnormalProcessRuleDetail(DescribeAbnormalProcessRuleDetailRequest req)
        {
             JsonResponseModel<DescribeAbnormalProcessRuleDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAbnormalProcessRuleDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAbnormalProcessRuleDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询运行时异常策略详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAbnormalProcessRuleDetailRequest"/></param>
        /// <returns><see cref="DescribeAbnormalProcessRuleDetailResponse"/></returns>
        public DescribeAbnormalProcessRuleDetailResponse DescribeAbnormalProcessRuleDetailSync(DescribeAbnormalProcessRuleDetailRequest req)
        {
             JsonResponseModel<DescribeAbnormalProcessRuleDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAbnormalProcessRuleDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAbnormalProcessRuleDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询运行时异常进程策略列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAbnormalProcessRulesRequest"/></param>
        /// <returns><see cref="DescribeAbnormalProcessRulesResponse"/></returns>
        public async Task<DescribeAbnormalProcessRulesResponse> DescribeAbnormalProcessRules(DescribeAbnormalProcessRulesRequest req)
        {
             JsonResponseModel<DescribeAbnormalProcessRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAbnormalProcessRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAbnormalProcessRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询运行时异常进程策略列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAbnormalProcessRulesRequest"/></param>
        /// <returns><see cref="DescribeAbnormalProcessRulesResponse"/></returns>
        public DescribeAbnormalProcessRulesResponse DescribeAbnormalProcessRulesSync(DescribeAbnormalProcessRulesRequest req)
        {
             JsonResponseModel<DescribeAbnormalProcessRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAbnormalProcessRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAbnormalProcessRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询运行时异常进程策略列表信息导出
        /// </summary>
        /// <param name="req"><see cref="DescribeAbnormalProcessRulesExportRequest"/></param>
        /// <returns><see cref="DescribeAbnormalProcessRulesExportResponse"/></returns>
        public async Task<DescribeAbnormalProcessRulesExportResponse> DescribeAbnormalProcessRulesExport(DescribeAbnormalProcessRulesExportRequest req)
        {
             JsonResponseModel<DescribeAbnormalProcessRulesExportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAbnormalProcessRulesExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAbnormalProcessRulesExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询运行时异常进程策略列表信息导出
        /// </summary>
        /// <param name="req"><see cref="DescribeAbnormalProcessRulesExportRequest"/></param>
        /// <returns><see cref="DescribeAbnormalProcessRulesExportResponse"/></returns>
        public DescribeAbnormalProcessRulesExportResponse DescribeAbnormalProcessRulesExportSync(DescribeAbnormalProcessRulesExportRequest req)
        {
             JsonResponseModel<DescribeAbnormalProcessRulesExportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAbnormalProcessRulesExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAbnormalProcessRulesExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询运行时访问控制事件的详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessControlDetailRequest"/></param>
        /// <returns><see cref="DescribeAccessControlDetailResponse"/></returns>
        public async Task<DescribeAccessControlDetailResponse> DescribeAccessControlDetail(DescribeAccessControlDetailRequest req)
        {
             JsonResponseModel<DescribeAccessControlDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccessControlDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccessControlDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询运行时访问控制事件的详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessControlDetailRequest"/></param>
        /// <returns><see cref="DescribeAccessControlDetailResponse"/></returns>
        public DescribeAccessControlDetailResponse DescribeAccessControlDetailSync(DescribeAccessControlDetailRequest req)
        {
             JsonResponseModel<DescribeAccessControlDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAccessControlDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccessControlDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询运行时访问控制事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessControlEventsRequest"/></param>
        /// <returns><see cref="DescribeAccessControlEventsResponse"/></returns>
        public async Task<DescribeAccessControlEventsResponse> DescribeAccessControlEvents(DescribeAccessControlEventsRequest req)
        {
             JsonResponseModel<DescribeAccessControlEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccessControlEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccessControlEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询运行时访问控制事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessControlEventsRequest"/></param>
        /// <returns><see cref="DescribeAccessControlEventsResponse"/></returns>
        public DescribeAccessControlEventsResponse DescribeAccessControlEventsSync(DescribeAccessControlEventsRequest req)
        {
             JsonResponseModel<DescribeAccessControlEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAccessControlEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccessControlEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询运行时访问控制事件列表导出
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessControlEventsExportRequest"/></param>
        /// <returns><see cref="DescribeAccessControlEventsExportResponse"/></returns>
        public async Task<DescribeAccessControlEventsExportResponse> DescribeAccessControlEventsExport(DescribeAccessControlEventsExportRequest req)
        {
             JsonResponseModel<DescribeAccessControlEventsExportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccessControlEventsExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccessControlEventsExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询运行时访问控制事件列表导出
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessControlEventsExportRequest"/></param>
        /// <returns><see cref="DescribeAccessControlEventsExportResponse"/></returns>
        public DescribeAccessControlEventsExportResponse DescribeAccessControlEventsExportSync(DescribeAccessControlEventsExportRequest req)
        {
             JsonResponseModel<DescribeAccessControlEventsExportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAccessControlEventsExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccessControlEventsExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询运行时访问控制策略详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessControlRuleDetailRequest"/></param>
        /// <returns><see cref="DescribeAccessControlRuleDetailResponse"/></returns>
        public async Task<DescribeAccessControlRuleDetailResponse> DescribeAccessControlRuleDetail(DescribeAccessControlRuleDetailRequest req)
        {
             JsonResponseModel<DescribeAccessControlRuleDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccessControlRuleDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccessControlRuleDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询运行时访问控制策略详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessControlRuleDetailRequest"/></param>
        /// <returns><see cref="DescribeAccessControlRuleDetailResponse"/></returns>
        public DescribeAccessControlRuleDetailResponse DescribeAccessControlRuleDetailSync(DescribeAccessControlRuleDetailRequest req)
        {
             JsonResponseModel<DescribeAccessControlRuleDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAccessControlRuleDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccessControlRuleDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询运行访问控制策略列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessControlRulesRequest"/></param>
        /// <returns><see cref="DescribeAccessControlRulesResponse"/></returns>
        public async Task<DescribeAccessControlRulesResponse> DescribeAccessControlRules(DescribeAccessControlRulesRequest req)
        {
             JsonResponseModel<DescribeAccessControlRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccessControlRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccessControlRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询运行访问控制策略列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessControlRulesRequest"/></param>
        /// <returns><see cref="DescribeAccessControlRulesResponse"/></returns>
        public DescribeAccessControlRulesResponse DescribeAccessControlRulesSync(DescribeAccessControlRulesRequest req)
        {
             JsonResponseModel<DescribeAccessControlRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAccessControlRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccessControlRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询运行时访问控制策略列表导出
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessControlRulesExportRequest"/></param>
        /// <returns><see cref="DescribeAccessControlRulesExportResponse"/></returns>
        public async Task<DescribeAccessControlRulesExportResponse> DescribeAccessControlRulesExport(DescribeAccessControlRulesExportRequest req)
        {
             JsonResponseModel<DescribeAccessControlRulesExportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccessControlRulesExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccessControlRulesExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询运行时访问控制策略列表导出
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessControlRulesExportRequest"/></param>
        /// <returns><see cref="DescribeAccessControlRulesExportResponse"/></returns>
        public DescribeAccessControlRulesExportResponse DescribeAccessControlRulesExportSync(DescribeAccessControlRulesExportRequest req)
        {
             JsonResponseModel<DescribeAccessControlRulesExportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAccessControlRulesExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccessControlRulesExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取受影响的集群数量，返回数量
        /// </summary>
        /// <param name="req"><see cref="DescribeAffectedClusterCountRequest"/></param>
        /// <returns><see cref="DescribeAffectedClusterCountResponse"/></returns>
        public async Task<DescribeAffectedClusterCountResponse> DescribeAffectedClusterCount(DescribeAffectedClusterCountRequest req)
        {
             JsonResponseModel<DescribeAffectedClusterCountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAffectedClusterCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAffectedClusterCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取受影响的集群数量，返回数量
        /// </summary>
        /// <param name="req"><see cref="DescribeAffectedClusterCountRequest"/></param>
        /// <returns><see cref="DescribeAffectedClusterCountResponse"/></returns>
        public DescribeAffectedClusterCountResponse DescribeAffectedClusterCountSync(DescribeAffectedClusterCountRequest req)
        {
             JsonResponseModel<DescribeAffectedClusterCountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAffectedClusterCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAffectedClusterCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询节点类型的影响范围，返回节点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAffectedNodeListRequest"/></param>
        /// <returns><see cref="DescribeAffectedNodeListResponse"/></returns>
        public async Task<DescribeAffectedNodeListResponse> DescribeAffectedNodeList(DescribeAffectedNodeListRequest req)
        {
             JsonResponseModel<DescribeAffectedNodeListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAffectedNodeList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAffectedNodeListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询节点类型的影响范围，返回节点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAffectedNodeListRequest"/></param>
        /// <returns><see cref="DescribeAffectedNodeListResponse"/></returns>
        public DescribeAffectedNodeListResponse DescribeAffectedNodeListSync(DescribeAffectedNodeListRequest req)
        {
             JsonResponseModel<DescribeAffectedNodeListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAffectedNodeList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAffectedNodeListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询workload类型的影响范围，返回workload列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAffectedWorkloadListRequest"/></param>
        /// <returns><see cref="DescribeAffectedWorkloadListResponse"/></returns>
        public async Task<DescribeAffectedWorkloadListResponse> DescribeAffectedWorkloadList(DescribeAffectedWorkloadListRequest req)
        {
             JsonResponseModel<DescribeAffectedWorkloadListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAffectedWorkloadList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAffectedWorkloadListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询workload类型的影响范围，返回workload列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAffectedWorkloadListRequest"/></param>
        /// <returns><see cref="DescribeAffectedWorkloadListResponse"/></returns>
        public DescribeAffectedWorkloadListResponse DescribeAffectedWorkloadListSync(DescribeAffectedWorkloadListRequest req)
        {
             JsonResponseModel<DescribeAffectedWorkloadListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAffectedWorkloadList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAffectedWorkloadListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询平行容器安装命令
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentDaemonSetCmdRequest"/></param>
        /// <returns><see cref="DescribeAgentDaemonSetCmdResponse"/></returns>
        public async Task<DescribeAgentDaemonSetCmdResponse> DescribeAgentDaemonSetCmd(DescribeAgentDaemonSetCmdRequest req)
        {
             JsonResponseModel<DescribeAgentDaemonSetCmdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAgentDaemonSetCmd");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAgentDaemonSetCmdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询平行容器安装命令
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentDaemonSetCmdRequest"/></param>
        /// <returns><see cref="DescribeAgentDaemonSetCmdResponse"/></returns>
        public DescribeAgentDaemonSetCmdResponse DescribeAgentDaemonSetCmdSync(DescribeAgentDaemonSetCmdRequest req)
        {
             JsonResponseModel<DescribeAgentDaemonSetCmdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAgentDaemonSetCmd");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAgentDaemonSetCmdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询agent安装命令
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentInstallCommandRequest"/></param>
        /// <returns><see cref="DescribeAgentInstallCommandResponse"/></returns>
        public async Task<DescribeAgentInstallCommandResponse> DescribeAgentInstallCommand(DescribeAgentInstallCommandRequest req)
        {
             JsonResponseModel<DescribeAgentInstallCommandResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAgentInstallCommand");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAgentInstallCommandResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询agent安装命令
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentInstallCommandRequest"/></param>
        /// <returns><see cref="DescribeAgentInstallCommandResponse"/></returns>
        public DescribeAgentInstallCommandResponse DescribeAgentInstallCommandSync(DescribeAgentInstallCommandRequest req)
        {
             JsonResponseModel<DescribeAgentInstallCommandResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAgentInstallCommand");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAgentInstallCommandResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器安全查询app服务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetAppServiceListRequest"/></param>
        /// <returns><see cref="DescribeAssetAppServiceListResponse"/></returns>
        public async Task<DescribeAssetAppServiceListResponse> DescribeAssetAppServiceList(DescribeAssetAppServiceListRequest req)
        {
             JsonResponseModel<DescribeAssetAppServiceListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetAppServiceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetAppServiceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器安全查询app服务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetAppServiceListRequest"/></param>
        /// <returns><see cref="DescribeAssetAppServiceListResponse"/></returns>
        public DescribeAssetAppServiceListResponse DescribeAssetAppServiceListSync(DescribeAssetAppServiceListRequest req)
        {
             JsonResponseModel<DescribeAssetAppServiceListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetAppServiceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetAppServiceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器安全搜索查询容器组件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetComponentListRequest"/></param>
        /// <returns><see cref="DescribeAssetComponentListResponse"/></returns>
        public async Task<DescribeAssetComponentListResponse> DescribeAssetComponentList(DescribeAssetComponentListRequest req)
        {
             JsonResponseModel<DescribeAssetComponentListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetComponentList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetComponentListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器安全搜索查询容器组件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetComponentListRequest"/></param>
        /// <returns><see cref="DescribeAssetComponentListResponse"/></returns>
        public DescribeAssetComponentListResponse DescribeAssetComponentListSync(DescribeAssetComponentListRequest req)
        {
             JsonResponseModel<DescribeAssetComponentListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetComponentList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetComponentListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询容器详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetContainerDetailRequest"/></param>
        /// <returns><see cref="DescribeAssetContainerDetailResponse"/></returns>
        public async Task<DescribeAssetContainerDetailResponse> DescribeAssetContainerDetail(DescribeAssetContainerDetailRequest req)
        {
             JsonResponseModel<DescribeAssetContainerDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetContainerDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetContainerDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询容器详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetContainerDetailRequest"/></param>
        /// <returns><see cref="DescribeAssetContainerDetailResponse"/></returns>
        public DescribeAssetContainerDetailResponse DescribeAssetContainerDetailSync(DescribeAssetContainerDetailRequest req)
        {
             JsonResponseModel<DescribeAssetContainerDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetContainerDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetContainerDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 搜索查询容器列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetContainerListRequest"/></param>
        /// <returns><see cref="DescribeAssetContainerListResponse"/></returns>
        public async Task<DescribeAssetContainerListResponse> DescribeAssetContainerList(DescribeAssetContainerListRequest req)
        {
             JsonResponseModel<DescribeAssetContainerListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetContainerList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetContainerListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 搜索查询容器列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetContainerListRequest"/></param>
        /// <returns><see cref="DescribeAssetContainerListResponse"/></returns>
        public DescribeAssetContainerListResponse DescribeAssetContainerListSync(DescribeAssetContainerListRequest req)
        {
             JsonResponseModel<DescribeAssetContainerListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetContainerList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetContainerListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器安全查询db服务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetDBServiceListRequest"/></param>
        /// <returns><see cref="DescribeAssetDBServiceListResponse"/></returns>
        public async Task<DescribeAssetDBServiceListResponse> DescribeAssetDBServiceList(DescribeAssetDBServiceListRequest req)
        {
             JsonResponseModel<DescribeAssetDBServiceListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetDBServiceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetDBServiceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器安全查询db服务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetDBServiceListRequest"/></param>
        /// <returns><see cref="DescribeAssetDBServiceListResponse"/></returns>
        public DescribeAssetDBServiceListResponse DescribeAssetDBServiceListSync(DescribeAssetDBServiceListRequest req)
        {
             JsonResponseModel<DescribeAssetDBServiceListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetDBServiceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetDBServiceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询主机详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetHostDetailRequest"/></param>
        /// <returns><see cref="DescribeAssetHostDetailResponse"/></returns>
        public async Task<DescribeAssetHostDetailResponse> DescribeAssetHostDetail(DescribeAssetHostDetailRequest req)
        {
             JsonResponseModel<DescribeAssetHostDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetHostDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetHostDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询主机详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetHostDetailRequest"/></param>
        /// <returns><see cref="DescribeAssetHostDetailResponse"/></returns>
        public DescribeAssetHostDetailResponse DescribeAssetHostDetailSync(DescribeAssetHostDetailRequest req)
        {
             JsonResponseModel<DescribeAssetHostDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetHostDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetHostDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器安全搜索查询主机列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetHostListRequest"/></param>
        /// <returns><see cref="DescribeAssetHostListResponse"/></returns>
        public async Task<DescribeAssetHostListResponse> DescribeAssetHostList(DescribeAssetHostListRequest req)
        {
             JsonResponseModel<DescribeAssetHostListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetHostList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetHostListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器安全搜索查询主机列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetHostListRequest"/></param>
        /// <returns><see cref="DescribeAssetHostListResponse"/></returns>
        public DescribeAssetHostListResponse DescribeAssetHostListSync(DescribeAssetHostListRequest req)
        {
             JsonResponseModel<DescribeAssetHostListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetHostList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetHostListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 镜像绑定规则列表信息，包含运行时访问控制和异常进程公用
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageBindRuleInfoRequest"/></param>
        /// <returns><see cref="DescribeAssetImageBindRuleInfoResponse"/></returns>
        public async Task<DescribeAssetImageBindRuleInfoResponse> DescribeAssetImageBindRuleInfo(DescribeAssetImageBindRuleInfoRequest req)
        {
             JsonResponseModel<DescribeAssetImageBindRuleInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetImageBindRuleInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageBindRuleInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 镜像绑定规则列表信息，包含运行时访问控制和异常进程公用
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageBindRuleInfoRequest"/></param>
        /// <returns><see cref="DescribeAssetImageBindRuleInfoResponse"/></returns>
        public DescribeAssetImageBindRuleInfoResponse DescribeAssetImageBindRuleInfoSync(DescribeAssetImageBindRuleInfoRequest req)
        {
             JsonResponseModel<DescribeAssetImageBindRuleInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetImageBindRuleInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageBindRuleInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询镜像详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageDetailRequest"/></param>
        /// <returns><see cref="DescribeAssetImageDetailResponse"/></returns>
        public async Task<DescribeAssetImageDetailResponse> DescribeAssetImageDetail(DescribeAssetImageDetailRequest req)
        {
             JsonResponseModel<DescribeAssetImageDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetImageDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询镜像详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageDetailRequest"/></param>
        /// <returns><see cref="DescribeAssetImageDetailResponse"/></returns>
        public DescribeAssetImageDetailResponse DescribeAssetImageDetailSync(DescribeAssetImageDetailRequest req)
        {
             JsonResponseModel<DescribeAssetImageDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetImageDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器安全查询镜像关联主机
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageHostListRequest"/></param>
        /// <returns><see cref="DescribeAssetImageHostListResponse"/></returns>
        public async Task<DescribeAssetImageHostListResponse> DescribeAssetImageHostList(DescribeAssetImageHostListRequest req)
        {
             JsonResponseModel<DescribeAssetImageHostListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetImageHostList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageHostListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器安全查询镜像关联主机
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageHostListRequest"/></param>
        /// <returns><see cref="DescribeAssetImageHostListResponse"/></returns>
        public DescribeAssetImageHostListResponse DescribeAssetImageHostListSync(DescribeAssetImageHostListRequest req)
        {
             JsonResponseModel<DescribeAssetImageHostListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetImageHostList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageHostListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器安全搜索查询镜像列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageListRequest"/></param>
        /// <returns><see cref="DescribeAssetImageListResponse"/></returns>
        public async Task<DescribeAssetImageListResponse> DescribeAssetImageList(DescribeAssetImageListRequest req)
        {
             JsonResponseModel<DescribeAssetImageListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetImageList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器安全搜索查询镜像列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageListRequest"/></param>
        /// <returns><see cref="DescribeAssetImageListResponse"/></returns>
        public DescribeAssetImageListResponse DescribeAssetImageListSync(DescribeAssetImageListRequest req)
        {
             JsonResponseModel<DescribeAssetImageListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetImageList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器安全搜索查询镜像列表导出
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageListExportRequest"/></param>
        /// <returns><see cref="DescribeAssetImageListExportResponse"/></returns>
        public async Task<DescribeAssetImageListExportResponse> DescribeAssetImageListExport(DescribeAssetImageListExportRequest req)
        {
             JsonResponseModel<DescribeAssetImageListExportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetImageListExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageListExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器安全搜索查询镜像列表导出
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageListExportRequest"/></param>
        /// <returns><see cref="DescribeAssetImageListExportResponse"/></returns>
        public DescribeAssetImageListExportResponse DescribeAssetImageListExportSync(DescribeAssetImageListExportRequest req)
        {
             JsonResponseModel<DescribeAssetImageListExportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetImageListExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageListExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看镜像仓库资产更新进度状态
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryAssetStatusRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryAssetStatusResponse"/></returns>
        public async Task<DescribeAssetImageRegistryAssetStatusResponse> DescribeAssetImageRegistryAssetStatus(DescribeAssetImageRegistryAssetStatusRequest req)
        {
             JsonResponseModel<DescribeAssetImageRegistryAssetStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetImageRegistryAssetStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageRegistryAssetStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看镜像仓库资产更新进度状态
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryAssetStatusRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryAssetStatusResponse"/></returns>
        public DescribeAssetImageRegistryAssetStatusResponse DescribeAssetImageRegistryAssetStatusSync(DescribeAssetImageRegistryAssetStatusRequest req)
        {
             JsonResponseModel<DescribeAssetImageRegistryAssetStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetImageRegistryAssetStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageRegistryAssetStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 镜像仓库镜像仓库列表详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryDetailRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryDetailResponse"/></returns>
        public async Task<DescribeAssetImageRegistryDetailResponse> DescribeAssetImageRegistryDetail(DescribeAssetImageRegistryDetailRequest req)
        {
             JsonResponseModel<DescribeAssetImageRegistryDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetImageRegistryDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageRegistryDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 镜像仓库镜像仓库列表详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryDetailRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryDetailResponse"/></returns>
        public DescribeAssetImageRegistryDetailResponse DescribeAssetImageRegistryDetailSync(DescribeAssetImageRegistryDetailRequest req)
        {
             JsonResponseModel<DescribeAssetImageRegistryDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetImageRegistryDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageRegistryDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 镜像仓库镜像仓库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryListRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryListResponse"/></returns>
        public async Task<DescribeAssetImageRegistryListResponse> DescribeAssetImageRegistryList(DescribeAssetImageRegistryListRequest req)
        {
             JsonResponseModel<DescribeAssetImageRegistryListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetImageRegistryList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageRegistryListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 镜像仓库镜像仓库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryListRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryListResponse"/></returns>
        public DescribeAssetImageRegistryListResponse DescribeAssetImageRegistryListSync(DescribeAssetImageRegistryListRequest req)
        {
             JsonResponseModel<DescribeAssetImageRegistryListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetImageRegistryList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageRegistryListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 镜像仓库镜像列表导出
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryListExportRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryListExportResponse"/></returns>
        public async Task<DescribeAssetImageRegistryListExportResponse> DescribeAssetImageRegistryListExport(DescribeAssetImageRegistryListExportRequest req)
        {
             JsonResponseModel<DescribeAssetImageRegistryListExportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetImageRegistryListExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageRegistryListExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 镜像仓库镜像列表导出
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryListExportRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryListExportResponse"/></returns>
        public DescribeAssetImageRegistryListExportResponse DescribeAssetImageRegistryListExportSync(DescribeAssetImageRegistryListExportRequest req)
        {
             JsonResponseModel<DescribeAssetImageRegistryListExportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetImageRegistryListExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageRegistryListExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看单个镜像仓库详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryRegistryDetailRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryRegistryDetailResponse"/></returns>
        public async Task<DescribeAssetImageRegistryRegistryDetailResponse> DescribeAssetImageRegistryRegistryDetail(DescribeAssetImageRegistryRegistryDetailRequest req)
        {
             JsonResponseModel<DescribeAssetImageRegistryRegistryDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetImageRegistryRegistryDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageRegistryRegistryDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看单个镜像仓库详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryRegistryDetailRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryRegistryDetailResponse"/></returns>
        public DescribeAssetImageRegistryRegistryDetailResponse DescribeAssetImageRegistryRegistryDetailSync(DescribeAssetImageRegistryRegistryDetailRequest req)
        {
             JsonResponseModel<DescribeAssetImageRegistryRegistryDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetImageRegistryRegistryDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageRegistryRegistryDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 镜像仓库仓库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryRegistryListRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryRegistryListResponse"/></returns>
        public async Task<DescribeAssetImageRegistryRegistryListResponse> DescribeAssetImageRegistryRegistryList(DescribeAssetImageRegistryRegistryListRequest req)
        {
             JsonResponseModel<DescribeAssetImageRegistryRegistryListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetImageRegistryRegistryList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageRegistryRegistryListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 镜像仓库仓库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryRegistryListRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryRegistryListResponse"/></returns>
        public DescribeAssetImageRegistryRegistryListResponse DescribeAssetImageRegistryRegistryListSync(DescribeAssetImageRegistryRegistryListRequest req)
        {
             JsonResponseModel<DescribeAssetImageRegistryRegistryListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetImageRegistryRegistryList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageRegistryRegistryListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 镜像仓库查询镜像高危行为列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryRiskInfoListRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryRiskInfoListResponse"/></returns>
        public async Task<DescribeAssetImageRegistryRiskInfoListResponse> DescribeAssetImageRegistryRiskInfoList(DescribeAssetImageRegistryRiskInfoListRequest req)
        {
             JsonResponseModel<DescribeAssetImageRegistryRiskInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetImageRegistryRiskInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageRegistryRiskInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 镜像仓库查询镜像高危行为列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryRiskInfoListRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryRiskInfoListResponse"/></returns>
        public DescribeAssetImageRegistryRiskInfoListResponse DescribeAssetImageRegistryRiskInfoListSync(DescribeAssetImageRegistryRiskInfoListRequest req)
        {
             JsonResponseModel<DescribeAssetImageRegistryRiskInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetImageRegistryRiskInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageRegistryRiskInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 镜像仓库敏感信息列表导出
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryRiskListExportRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryRiskListExportResponse"/></returns>
        public async Task<DescribeAssetImageRegistryRiskListExportResponse> DescribeAssetImageRegistryRiskListExport(DescribeAssetImageRegistryRiskListExportRequest req)
        {
             JsonResponseModel<DescribeAssetImageRegistryRiskListExportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetImageRegistryRiskListExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageRegistryRiskListExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 镜像仓库敏感信息列表导出
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryRiskListExportRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryRiskListExportResponse"/></returns>
        public DescribeAssetImageRegistryRiskListExportResponse DescribeAssetImageRegistryRiskListExportSync(DescribeAssetImageRegistryRiskListExportRequest req)
        {
             JsonResponseModel<DescribeAssetImageRegistryRiskListExportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetImageRegistryRiskListExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageRegistryRiskListExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 镜像仓库查询一键镜像扫描状态
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryScanStatusOneKeyRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryScanStatusOneKeyResponse"/></returns>
        public async Task<DescribeAssetImageRegistryScanStatusOneKeyResponse> DescribeAssetImageRegistryScanStatusOneKey(DescribeAssetImageRegistryScanStatusOneKeyRequest req)
        {
             JsonResponseModel<DescribeAssetImageRegistryScanStatusOneKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetImageRegistryScanStatusOneKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageRegistryScanStatusOneKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 镜像仓库查询一键镜像扫描状态
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryScanStatusOneKeyRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryScanStatusOneKeyResponse"/></returns>
        public DescribeAssetImageRegistryScanStatusOneKeyResponse DescribeAssetImageRegistryScanStatusOneKeySync(DescribeAssetImageRegistryScanStatusOneKeyRequest req)
        {
             JsonResponseModel<DescribeAssetImageRegistryScanStatusOneKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetImageRegistryScanStatusOneKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageRegistryScanStatusOneKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 镜像仓库查询镜像统计信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistrySummaryRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistrySummaryResponse"/></returns>
        public async Task<DescribeAssetImageRegistrySummaryResponse> DescribeAssetImageRegistrySummary(DescribeAssetImageRegistrySummaryRequest req)
        {
             JsonResponseModel<DescribeAssetImageRegistrySummaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetImageRegistrySummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageRegistrySummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 镜像仓库查询镜像统计信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistrySummaryRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistrySummaryResponse"/></returns>
        public DescribeAssetImageRegistrySummaryResponse DescribeAssetImageRegistrySummarySync(DescribeAssetImageRegistrySummaryRequest req)
        {
             JsonResponseModel<DescribeAssetImageRegistrySummaryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetImageRegistrySummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageRegistrySummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 镜像仓库查询木马病毒列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryVirusListRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryVirusListResponse"/></returns>
        public async Task<DescribeAssetImageRegistryVirusListResponse> DescribeAssetImageRegistryVirusList(DescribeAssetImageRegistryVirusListRequest req)
        {
             JsonResponseModel<DescribeAssetImageRegistryVirusListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetImageRegistryVirusList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageRegistryVirusListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 镜像仓库查询木马病毒列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryVirusListRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryVirusListResponse"/></returns>
        public DescribeAssetImageRegistryVirusListResponse DescribeAssetImageRegistryVirusListSync(DescribeAssetImageRegistryVirusListRequest req)
        {
             JsonResponseModel<DescribeAssetImageRegistryVirusListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetImageRegistryVirusList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageRegistryVirusListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 镜像仓库木马信息列表导出
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryVirusListExportRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryVirusListExportResponse"/></returns>
        public async Task<DescribeAssetImageRegistryVirusListExportResponse> DescribeAssetImageRegistryVirusListExport(DescribeAssetImageRegistryVirusListExportRequest req)
        {
             JsonResponseModel<DescribeAssetImageRegistryVirusListExportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetImageRegistryVirusListExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageRegistryVirusListExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 镜像仓库木马信息列表导出
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryVirusListExportRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryVirusListExportResponse"/></returns>
        public DescribeAssetImageRegistryVirusListExportResponse DescribeAssetImageRegistryVirusListExportSync(DescribeAssetImageRegistryVirusListExportRequest req)
        {
             JsonResponseModel<DescribeAssetImageRegistryVirusListExportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetImageRegistryVirusListExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageRegistryVirusListExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 镜像仓库查询镜像漏洞列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryVulListRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryVulListResponse"/></returns>
        public async Task<DescribeAssetImageRegistryVulListResponse> DescribeAssetImageRegistryVulList(DescribeAssetImageRegistryVulListRequest req)
        {
             JsonResponseModel<DescribeAssetImageRegistryVulListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetImageRegistryVulList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageRegistryVulListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 镜像仓库查询镜像漏洞列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryVulListRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryVulListResponse"/></returns>
        public DescribeAssetImageRegistryVulListResponse DescribeAssetImageRegistryVulListSync(DescribeAssetImageRegistryVulListRequest req)
        {
             JsonResponseModel<DescribeAssetImageRegistryVulListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetImageRegistryVulList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageRegistryVulListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 镜像仓库漏洞列表导出
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryVulListExportRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryVulListExportResponse"/></returns>
        public async Task<DescribeAssetImageRegistryVulListExportResponse> DescribeAssetImageRegistryVulListExport(DescribeAssetImageRegistryVulListExportRequest req)
        {
             JsonResponseModel<DescribeAssetImageRegistryVulListExportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetImageRegistryVulListExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageRegistryVulListExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 镜像仓库漏洞列表导出
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRegistryVulListExportRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRegistryVulListExportResponse"/></returns>
        public DescribeAssetImageRegistryVulListExportResponse DescribeAssetImageRegistryVulListExportSync(DescribeAssetImageRegistryVulListExportRequest req)
        {
             JsonResponseModel<DescribeAssetImageRegistryVulListExportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetImageRegistryVulListExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageRegistryVulListExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器安全查询镜像风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRiskListRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRiskListResponse"/></returns>
        public async Task<DescribeAssetImageRiskListResponse> DescribeAssetImageRiskList(DescribeAssetImageRiskListRequest req)
        {
             JsonResponseModel<DescribeAssetImageRiskListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetImageRiskList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageRiskListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器安全查询镜像风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRiskListRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRiskListResponse"/></returns>
        public DescribeAssetImageRiskListResponse DescribeAssetImageRiskListSync(DescribeAssetImageRiskListRequest req)
        {
             JsonResponseModel<DescribeAssetImageRiskListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetImageRiskList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageRiskListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器安全搜索查询镜像风险列表导出
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRiskListExportRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRiskListExportResponse"/></returns>
        public async Task<DescribeAssetImageRiskListExportResponse> DescribeAssetImageRiskListExport(DescribeAssetImageRiskListExportRequest req)
        {
             JsonResponseModel<DescribeAssetImageRiskListExportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetImageRiskListExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageRiskListExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器安全搜索查询镜像风险列表导出
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageRiskListExportRequest"/></param>
        /// <returns><see cref="DescribeAssetImageRiskListExportResponse"/></returns>
        public DescribeAssetImageRiskListExportResponse DescribeAssetImageRiskListExportSync(DescribeAssetImageRiskListExportRequest req)
        {
             JsonResponseModel<DescribeAssetImageRiskListExportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetImageRiskListExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageRiskListExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取镜像扫描设置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageScanSettingRequest"/></param>
        /// <returns><see cref="DescribeAssetImageScanSettingResponse"/></returns>
        public async Task<DescribeAssetImageScanSettingResponse> DescribeAssetImageScanSetting(DescribeAssetImageScanSettingRequest req)
        {
             JsonResponseModel<DescribeAssetImageScanSettingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetImageScanSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageScanSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取镜像扫描设置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageScanSettingRequest"/></param>
        /// <returns><see cref="DescribeAssetImageScanSettingResponse"/></returns>
        public DescribeAssetImageScanSettingResponse DescribeAssetImageScanSettingSync(DescribeAssetImageScanSettingRequest req)
        {
             JsonResponseModel<DescribeAssetImageScanSettingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetImageScanSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageScanSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器安全查询镜像扫描状态
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageScanStatusRequest"/></param>
        /// <returns><see cref="DescribeAssetImageScanStatusResponse"/></returns>
        public async Task<DescribeAssetImageScanStatusResponse> DescribeAssetImageScanStatus(DescribeAssetImageScanStatusRequest req)
        {
             JsonResponseModel<DescribeAssetImageScanStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetImageScanStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageScanStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器安全查询镜像扫描状态
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageScanStatusRequest"/></param>
        /// <returns><see cref="DescribeAssetImageScanStatusResponse"/></returns>
        public DescribeAssetImageScanStatusResponse DescribeAssetImageScanStatusSync(DescribeAssetImageScanStatusRequest req)
        {
             JsonResponseModel<DescribeAssetImageScanStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetImageScanStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageScanStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询正在一键扫描的镜像扫描taskid
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageScanTaskRequest"/></param>
        /// <returns><see cref="DescribeAssetImageScanTaskResponse"/></returns>
        public async Task<DescribeAssetImageScanTaskResponse> DescribeAssetImageScanTask(DescribeAssetImageScanTaskRequest req)
        {
             JsonResponseModel<DescribeAssetImageScanTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetImageScanTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageScanTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询正在一键扫描的镜像扫描taskid
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageScanTaskRequest"/></param>
        /// <returns><see cref="DescribeAssetImageScanTaskResponse"/></returns>
        public DescribeAssetImageScanTaskResponse DescribeAssetImageScanTaskSync(DescribeAssetImageScanTaskRequest req)
        {
             JsonResponseModel<DescribeAssetImageScanTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetImageScanTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageScanTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器安全搜索查询镜像简略信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageSimpleListRequest"/></param>
        /// <returns><see cref="DescribeAssetImageSimpleListResponse"/></returns>
        public async Task<DescribeAssetImageSimpleListResponse> DescribeAssetImageSimpleList(DescribeAssetImageSimpleListRequest req)
        {
             JsonResponseModel<DescribeAssetImageSimpleListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetImageSimpleList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageSimpleListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器安全搜索查询镜像简略信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageSimpleListRequest"/></param>
        /// <returns><see cref="DescribeAssetImageSimpleListResponse"/></returns>
        public DescribeAssetImageSimpleListResponse DescribeAssetImageSimpleListSync(DescribeAssetImageSimpleListRequest req)
        {
             JsonResponseModel<DescribeAssetImageSimpleListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetImageSimpleList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageSimpleListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器安全查询镜像病毒列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageVirusListRequest"/></param>
        /// <returns><see cref="DescribeAssetImageVirusListResponse"/></returns>
        public async Task<DescribeAssetImageVirusListResponse> DescribeAssetImageVirusList(DescribeAssetImageVirusListRequest req)
        {
             JsonResponseModel<DescribeAssetImageVirusListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetImageVirusList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageVirusListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器安全查询镜像病毒列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageVirusListRequest"/></param>
        /// <returns><see cref="DescribeAssetImageVirusListResponse"/></returns>
        public DescribeAssetImageVirusListResponse DescribeAssetImageVirusListSync(DescribeAssetImageVirusListRequest req)
        {
             JsonResponseModel<DescribeAssetImageVirusListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetImageVirusList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageVirusListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器安全搜索查询镜像木马列表导出
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageVirusListExportRequest"/></param>
        /// <returns><see cref="DescribeAssetImageVirusListExportResponse"/></returns>
        public async Task<DescribeAssetImageVirusListExportResponse> DescribeAssetImageVirusListExport(DescribeAssetImageVirusListExportRequest req)
        {
             JsonResponseModel<DescribeAssetImageVirusListExportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetImageVirusListExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageVirusListExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器安全搜索查询镜像木马列表导出
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageVirusListExportRequest"/></param>
        /// <returns><see cref="DescribeAssetImageVirusListExportResponse"/></returns>
        public DescribeAssetImageVirusListExportResponse DescribeAssetImageVirusListExportSync(DescribeAssetImageVirusListExportRequest req)
        {
             JsonResponseModel<DescribeAssetImageVirusListExportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetImageVirusListExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageVirusListExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器安全查询镜像漏洞列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageVulListRequest"/></param>
        /// <returns><see cref="DescribeAssetImageVulListResponse"/></returns>
        public async Task<DescribeAssetImageVulListResponse> DescribeAssetImageVulList(DescribeAssetImageVulListRequest req)
        {
             JsonResponseModel<DescribeAssetImageVulListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetImageVulList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageVulListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器安全查询镜像漏洞列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageVulListRequest"/></param>
        /// <returns><see cref="DescribeAssetImageVulListResponse"/></returns>
        public DescribeAssetImageVulListResponse DescribeAssetImageVulListSync(DescribeAssetImageVulListRequest req)
        {
             JsonResponseModel<DescribeAssetImageVulListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetImageVulList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageVulListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器安全搜索查询镜像漏洞列表导出
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageVulListExportRequest"/></param>
        /// <returns><see cref="DescribeAssetImageVulListExportResponse"/></returns>
        public async Task<DescribeAssetImageVulListExportResponse> DescribeAssetImageVulListExport(DescribeAssetImageVulListExportRequest req)
        {
             JsonResponseModel<DescribeAssetImageVulListExportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetImageVulListExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageVulListExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器安全搜索查询镜像漏洞列表导出
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetImageVulListExportRequest"/></param>
        /// <returns><see cref="DescribeAssetImageVulListExportResponse"/></returns>
        public DescribeAssetImageVulListExportResponse DescribeAssetImageVulListExportSync(DescribeAssetImageVulListExportRequest req)
        {
             JsonResponseModel<DescribeAssetImageVulListExportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetImageVulListExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetImageVulListExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器安全搜索查询端口占用列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetPortListRequest"/></param>
        /// <returns><see cref="DescribeAssetPortListResponse"/></returns>
        public async Task<DescribeAssetPortListResponse> DescribeAssetPortList(DescribeAssetPortListRequest req)
        {
             JsonResponseModel<DescribeAssetPortListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetPortList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetPortListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器安全搜索查询端口占用列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetPortListRequest"/></param>
        /// <returns><see cref="DescribeAssetPortListResponse"/></returns>
        public DescribeAssetPortListResponse DescribeAssetPortListSync(DescribeAssetPortListRequest req)
        {
             JsonResponseModel<DescribeAssetPortListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetPortList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetPortListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器安全搜索查询进程列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetProcessListRequest"/></param>
        /// <returns><see cref="DescribeAssetProcessListResponse"/></returns>
        public async Task<DescribeAssetProcessListResponse> DescribeAssetProcessList(DescribeAssetProcessListRequest req)
        {
             JsonResponseModel<DescribeAssetProcessListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetProcessList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetProcessListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器安全搜索查询进程列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetProcessListRequest"/></param>
        /// <returns><see cref="DescribeAssetProcessListResponse"/></returns>
        public DescribeAssetProcessListResponse DescribeAssetProcessListSync(DescribeAssetProcessListRequest req)
        {
             JsonResponseModel<DescribeAssetProcessListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetProcessList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetProcessListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询账户容器、镜像等统计信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetSummaryRequest"/></param>
        /// <returns><see cref="DescribeAssetSummaryResponse"/></returns>
        public async Task<DescribeAssetSummaryResponse> DescribeAssetSummary(DescribeAssetSummaryRequest req)
        {
             JsonResponseModel<DescribeAssetSummaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询账户容器、镜像等统计信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetSummaryRequest"/></param>
        /// <returns><see cref="DescribeAssetSummaryResponse"/></returns>
        public DescribeAssetSummaryResponse DescribeAssetSummarySync(DescribeAssetSummaryRequest req)
        {
             JsonResponseModel<DescribeAssetSummaryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询资产同步最近时间
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetSyncLastTimeRequest"/></param>
        /// <returns><see cref="DescribeAssetSyncLastTimeResponse"/></returns>
        public async Task<DescribeAssetSyncLastTimeResponse> DescribeAssetSyncLastTime(DescribeAssetSyncLastTimeRequest req)
        {
             JsonResponseModel<DescribeAssetSyncLastTimeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetSyncLastTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetSyncLastTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询资产同步最近时间
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetSyncLastTimeRequest"/></param>
        /// <returns><see cref="DescribeAssetSyncLastTimeResponse"/></returns>
        public DescribeAssetSyncLastTimeResponse DescribeAssetSyncLastTimeSync(DescribeAssetSyncLastTimeRequest req)
        {
             JsonResponseModel<DescribeAssetSyncLastTimeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetSyncLastTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetSyncLastTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器安全查询web服务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebServiceListRequest"/></param>
        /// <returns><see cref="DescribeAssetWebServiceListResponse"/></returns>
        public async Task<DescribeAssetWebServiceListResponse> DescribeAssetWebServiceList(DescribeAssetWebServiceListRequest req)
        {
             JsonResponseModel<DescribeAssetWebServiceListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetWebServiceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetWebServiceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器安全查询web服务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetWebServiceListRequest"/></param>
        /// <returns><see cref="DescribeAssetWebServiceListResponse"/></returns>
        public DescribeAssetWebServiceListResponse DescribeAssetWebServiceListSync(DescribeAssetWebServiceListRequest req)
        {
             JsonResponseModel<DescribeAssetWebServiceListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetWebServiceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetWebServiceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询自动授权规则授权范围主机信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoAuthorizedRuleHostRequest"/></param>
        /// <returns><see cref="DescribeAutoAuthorizedRuleHostResponse"/></returns>
        public async Task<DescribeAutoAuthorizedRuleHostResponse> DescribeAutoAuthorizedRuleHost(DescribeAutoAuthorizedRuleHostRequest req)
        {
             JsonResponseModel<DescribeAutoAuthorizedRuleHostResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAutoAuthorizedRuleHost");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAutoAuthorizedRuleHostResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询自动授权规则授权范围主机信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoAuthorizedRuleHostRequest"/></param>
        /// <returns><see cref="DescribeAutoAuthorizedRuleHostResponse"/></returns>
        public DescribeAutoAuthorizedRuleHostResponse DescribeAutoAuthorizedRuleHostSync(DescribeAutoAuthorizedRuleHostRequest req)
        {
             JsonResponseModel<DescribeAutoAuthorizedRuleHostResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAutoAuthorizedRuleHost");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAutoAuthorizedRuleHostResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询所有检查项接口，返回总数和检查项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCheckItemListRequest"/></param>
        /// <returns><see cref="DescribeCheckItemListResponse"/></returns>
        public async Task<DescribeCheckItemListResponse> DescribeCheckItemList(DescribeCheckItemListRequest req)
        {
             JsonResponseModel<DescribeCheckItemListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCheckItemList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCheckItemListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询所有检查项接口，返回总数和检查项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCheckItemListRequest"/></param>
        /// <returns><see cref="DescribeCheckItemListResponse"/></returns>
        public DescribeCheckItemListResponse DescribeCheckItemListSync(DescribeCheckItemListRequest req)
        {
             JsonResponseModel<DescribeCheckItemListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCheckItemList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCheckItemListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询单个集群的详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterDetailRequest"/></param>
        /// <returns><see cref="DescribeClusterDetailResponse"/></returns>
        public async Task<DescribeClusterDetailResponse> DescribeClusterDetail(DescribeClusterDetailRequest req)
        {
             JsonResponseModel<DescribeClusterDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询单个集群的详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterDetailRequest"/></param>
        /// <returns><see cref="DescribeClusterDetailResponse"/></returns>
        public DescribeClusterDetailResponse DescribeClusterDetailSync(DescribeClusterDetailRequest req)
        {
             JsonResponseModel<DescribeClusterDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户集群资产总览
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterSummaryRequest"/></param>
        /// <returns><see cref="DescribeClusterSummaryResponse"/></returns>
        public async Task<DescribeClusterSummaryResponse> DescribeClusterSummary(DescribeClusterSummaryRequest req)
        {
             JsonResponseModel<DescribeClusterSummaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClusterSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户集群资产总览
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterSummaryRequest"/></param>
        /// <returns><see cref="DescribeClusterSummaryResponse"/></returns>
        public DescribeClusterSummaryResponse DescribeClusterSummarySync(DescribeClusterSummaryRequest req)
        {
             JsonResponseModel<DescribeClusterSummaryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClusterSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClusterSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询某个资产的详情
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceAssetDetailInfoRequest"/></param>
        /// <returns><see cref="DescribeComplianceAssetDetailInfoResponse"/></returns>
        public async Task<DescribeComplianceAssetDetailInfoResponse> DescribeComplianceAssetDetailInfo(DescribeComplianceAssetDetailInfoRequest req)
        {
             JsonResponseModel<DescribeComplianceAssetDetailInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeComplianceAssetDetailInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeComplianceAssetDetailInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询某个资产的详情
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceAssetDetailInfoRequest"/></param>
        /// <returns><see cref="DescribeComplianceAssetDetailInfoResponse"/></returns>
        public DescribeComplianceAssetDetailInfoResponse DescribeComplianceAssetDetailInfoSync(DescribeComplianceAssetDetailInfoRequest req)
        {
             JsonResponseModel<DescribeComplianceAssetDetailInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeComplianceAssetDetailInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeComplianceAssetDetailInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询某类资产的列表
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceAssetListRequest"/></param>
        /// <returns><see cref="DescribeComplianceAssetListResponse"/></returns>
        public async Task<DescribeComplianceAssetListResponse> DescribeComplianceAssetList(DescribeComplianceAssetListRequest req)
        {
             JsonResponseModel<DescribeComplianceAssetListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeComplianceAssetList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeComplianceAssetListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询某类资产的列表
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceAssetListRequest"/></param>
        /// <returns><see cref="DescribeComplianceAssetListResponse"/></returns>
        public DescribeComplianceAssetListResponse DescribeComplianceAssetListSync(DescribeComplianceAssetListRequest req)
        {
             JsonResponseModel<DescribeComplianceAssetListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeComplianceAssetList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeComplianceAssetListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询某资产下的检测项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceAssetPolicyItemListRequest"/></param>
        /// <returns><see cref="DescribeComplianceAssetPolicyItemListResponse"/></returns>
        public async Task<DescribeComplianceAssetPolicyItemListResponse> DescribeComplianceAssetPolicyItemList(DescribeComplianceAssetPolicyItemListRequest req)
        {
             JsonResponseModel<DescribeComplianceAssetPolicyItemListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeComplianceAssetPolicyItemList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeComplianceAssetPolicyItemListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询某资产下的检测项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceAssetPolicyItemListRequest"/></param>
        /// <returns><see cref="DescribeComplianceAssetPolicyItemListResponse"/></returns>
        public DescribeComplianceAssetPolicyItemListResponse DescribeComplianceAssetPolicyItemListSync(DescribeComplianceAssetPolicyItemListRequest req)
        {
             JsonResponseModel<DescribeComplianceAssetPolicyItemListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeComplianceAssetPolicyItemList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeComplianceAssetPolicyItemListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询合规检测的定时任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCompliancePeriodTaskListRequest"/></param>
        /// <returns><see cref="DescribeCompliancePeriodTaskListResponse"/></returns>
        public async Task<DescribeCompliancePeriodTaskListResponse> DescribeCompliancePeriodTaskList(DescribeCompliancePeriodTaskListRequest req)
        {
             JsonResponseModel<DescribeCompliancePeriodTaskListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCompliancePeriodTaskList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCompliancePeriodTaskListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询合规检测的定时任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCompliancePeriodTaskListRequest"/></param>
        /// <returns><see cref="DescribeCompliancePeriodTaskListResponse"/></returns>
        public DescribeCompliancePeriodTaskListResponse DescribeCompliancePeriodTaskListSync(DescribeCompliancePeriodTaskListRequest req)
        {
             JsonResponseModel<DescribeCompliancePeriodTaskListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCompliancePeriodTaskList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCompliancePeriodTaskListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按照 检测项 → 资产 的两级层次展开的第二层级：资产层级。
        /// </summary>
        /// <param name="req"><see cref="DescribeCompliancePolicyItemAffectedAssetListRequest"/></param>
        /// <returns><see cref="DescribeCompliancePolicyItemAffectedAssetListResponse"/></returns>
        public async Task<DescribeCompliancePolicyItemAffectedAssetListResponse> DescribeCompliancePolicyItemAffectedAssetList(DescribeCompliancePolicyItemAffectedAssetListRequest req)
        {
             JsonResponseModel<DescribeCompliancePolicyItemAffectedAssetListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCompliancePolicyItemAffectedAssetList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCompliancePolicyItemAffectedAssetListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按照 检测项 → 资产 的两级层次展开的第二层级：资产层级。
        /// </summary>
        /// <param name="req"><see cref="DescribeCompliancePolicyItemAffectedAssetListRequest"/></param>
        /// <returns><see cref="DescribeCompliancePolicyItemAffectedAssetListResponse"/></returns>
        public DescribeCompliancePolicyItemAffectedAssetListResponse DescribeCompliancePolicyItemAffectedAssetListSync(DescribeCompliancePolicyItemAffectedAssetListRequest req)
        {
             JsonResponseModel<DescribeCompliancePolicyItemAffectedAssetListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCompliancePolicyItemAffectedAssetList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCompliancePolicyItemAffectedAssetListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按照 检测项 → 资产 的两级层次展开的第一层级：检测项层级。
        /// </summary>
        /// <param name="req"><see cref="DescribeCompliancePolicyItemAffectedSummaryRequest"/></param>
        /// <returns><see cref="DescribeCompliancePolicyItemAffectedSummaryResponse"/></returns>
        public async Task<DescribeCompliancePolicyItemAffectedSummaryResponse> DescribeCompliancePolicyItemAffectedSummary(DescribeCompliancePolicyItemAffectedSummaryRequest req)
        {
             JsonResponseModel<DescribeCompliancePolicyItemAffectedSummaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCompliancePolicyItemAffectedSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCompliancePolicyItemAffectedSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按照 检测项 → 资产 的两级层次展开的第一层级：检测项层级。
        /// </summary>
        /// <param name="req"><see cref="DescribeCompliancePolicyItemAffectedSummaryRequest"/></param>
        /// <returns><see cref="DescribeCompliancePolicyItemAffectedSummaryResponse"/></returns>
        public DescribeCompliancePolicyItemAffectedSummaryResponse DescribeCompliancePolicyItemAffectedSummarySync(DescribeCompliancePolicyItemAffectedSummaryRequest req)
        {
             JsonResponseModel<DescribeCompliancePolicyItemAffectedSummaryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCompliancePolicyItemAffectedSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCompliancePolicyItemAffectedSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按照 资产 → 检测项 二层结构展示的信息。这里查询第一层 资产的通过率汇总信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceScanFailedAssetListRequest"/></param>
        /// <returns><see cref="DescribeComplianceScanFailedAssetListResponse"/></returns>
        public async Task<DescribeComplianceScanFailedAssetListResponse> DescribeComplianceScanFailedAssetList(DescribeComplianceScanFailedAssetListRequest req)
        {
             JsonResponseModel<DescribeComplianceScanFailedAssetListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeComplianceScanFailedAssetList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeComplianceScanFailedAssetListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按照 资产 → 检测项 二层结构展示的信息。这里查询第一层 资产的通过率汇总信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceScanFailedAssetListRequest"/></param>
        /// <returns><see cref="DescribeComplianceScanFailedAssetListResponse"/></returns>
        public DescribeComplianceScanFailedAssetListResponse DescribeComplianceScanFailedAssetListSync(DescribeComplianceScanFailedAssetListRequest req)
        {
             JsonResponseModel<DescribeComplianceScanFailedAssetListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeComplianceScanFailedAssetList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeComplianceScanFailedAssetListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询上次任务的资产通过率汇总信息
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceTaskAssetSummaryRequest"/></param>
        /// <returns><see cref="DescribeComplianceTaskAssetSummaryResponse"/></returns>
        public async Task<DescribeComplianceTaskAssetSummaryResponse> DescribeComplianceTaskAssetSummary(DescribeComplianceTaskAssetSummaryRequest req)
        {
             JsonResponseModel<DescribeComplianceTaskAssetSummaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeComplianceTaskAssetSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeComplianceTaskAssetSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询上次任务的资产通过率汇总信息
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceTaskAssetSummaryRequest"/></param>
        /// <returns><see cref="DescribeComplianceTaskAssetSummaryResponse"/></returns>
        public DescribeComplianceTaskAssetSummaryResponse DescribeComplianceTaskAssetSummarySync(DescribeComplianceTaskAssetSummaryRequest req)
        {
             JsonResponseModel<DescribeComplianceTaskAssetSummaryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeComplianceTaskAssetSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeComplianceTaskAssetSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询最近一次任务发现的检测项的汇总信息列表，按照 检测项 → 资产 的两级层次展开。
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceTaskPolicyItemSummaryListRequest"/></param>
        /// <returns><see cref="DescribeComplianceTaskPolicyItemSummaryListResponse"/></returns>
        public async Task<DescribeComplianceTaskPolicyItemSummaryListResponse> DescribeComplianceTaskPolicyItemSummaryList(DescribeComplianceTaskPolicyItemSummaryListRequest req)
        {
             JsonResponseModel<DescribeComplianceTaskPolicyItemSummaryListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeComplianceTaskPolicyItemSummaryList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeComplianceTaskPolicyItemSummaryListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询最近一次任务发现的检测项的汇总信息列表，按照 检测项 → 资产 的两级层次展开。
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceTaskPolicyItemSummaryListRequest"/></param>
        /// <returns><see cref="DescribeComplianceTaskPolicyItemSummaryListResponse"/></returns>
        public DescribeComplianceTaskPolicyItemSummaryListResponse DescribeComplianceTaskPolicyItemSummaryListSync(DescribeComplianceTaskPolicyItemSummaryListRequest req)
        {
             JsonResponseModel<DescribeComplianceTaskPolicyItemSummaryListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeComplianceTaskPolicyItemSummaryList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeComplianceTaskPolicyItemSummaryListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询白名单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceWhitelistItemListRequest"/></param>
        /// <returns><see cref="DescribeComplianceWhitelistItemListResponse"/></returns>
        public async Task<DescribeComplianceWhitelistItemListResponse> DescribeComplianceWhitelistItemList(DescribeComplianceWhitelistItemListRequest req)
        {
             JsonResponseModel<DescribeComplianceWhitelistItemListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeComplianceWhitelistItemList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeComplianceWhitelistItemListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询白名单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceWhitelistItemListRequest"/></param>
        /// <returns><see cref="DescribeComplianceWhitelistItemListResponse"/></returns>
        public DescribeComplianceWhitelistItemListResponse DescribeComplianceWhitelistItemListSync(DescribeComplianceWhitelistItemListRequest req)
        {
             JsonResponseModel<DescribeComplianceWhitelistItemListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeComplianceWhitelistItemList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeComplianceWhitelistItemListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询容器资产概览信息
        /// </summary>
        /// <param name="req"><see cref="DescribeContainerAssetSummaryRequest"/></param>
        /// <returns><see cref="DescribeContainerAssetSummaryResponse"/></returns>
        public async Task<DescribeContainerAssetSummaryResponse> DescribeContainerAssetSummary(DescribeContainerAssetSummaryRequest req)
        {
             JsonResponseModel<DescribeContainerAssetSummaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeContainerAssetSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeContainerAssetSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询容器资产概览信息
        /// </summary>
        /// <param name="req"><see cref="DescribeContainerAssetSummaryRequest"/></param>
        /// <returns><see cref="DescribeContainerAssetSummaryResponse"/></returns>
        public DescribeContainerAssetSummaryResponse DescribeContainerAssetSummarySync(DescribeContainerAssetSummaryRequest req)
        {
             JsonResponseModel<DescribeContainerAssetSummaryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeContainerAssetSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeContainerAssetSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询容器安全未处理事件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeContainerSecEventSummaryRequest"/></param>
        /// <returns><see cref="DescribeContainerSecEventSummaryResponse"/></returns>
        public async Task<DescribeContainerSecEventSummaryResponse> DescribeContainerSecEventSummary(DescribeContainerSecEventSummaryRequest req)
        {
             JsonResponseModel<DescribeContainerSecEventSummaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeContainerSecEventSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeContainerSecEventSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询容器安全未处理事件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeContainerSecEventSummaryRequest"/></param>
        /// <returns><see cref="DescribeContainerSecEventSummaryResponse"/></returns>
        public DescribeContainerSecEventSummaryResponse DescribeContainerSecEventSummarySync(DescribeContainerSecEventSummaryRequest req)
        {
             JsonResponseModel<DescribeContainerSecEventSummaryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeContainerSecEventSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeContainerSecEventSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取ES字段聚合结果
        /// </summary>
        /// <param name="req"><see cref="DescribeESAggregationsRequest"/></param>
        /// <returns><see cref="DescribeESAggregationsResponse"/></returns>
        public async Task<DescribeESAggregationsResponse> DescribeESAggregations(DescribeESAggregationsRequest req)
        {
             JsonResponseModel<DescribeESAggregationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeESAggregations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeESAggregationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取ES字段聚合结果
        /// </summary>
        /// <param name="req"><see cref="DescribeESAggregationsRequest"/></param>
        /// <returns><see cref="DescribeESAggregationsResponse"/></returns>
        public DescribeESAggregationsResponse DescribeESAggregationsSync(DescribeESAggregationsRequest req)
        {
             JsonResponseModel<DescribeESAggregationsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeESAggregations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeESAggregationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取ES查询文档列表
        /// </summary>
        /// <param name="req"><see cref="DescribeESHitsRequest"/></param>
        /// <returns><see cref="DescribeESHitsResponse"/></returns>
        public async Task<DescribeESHitsResponse> DescribeESHits(DescribeESHitsRequest req)
        {
             JsonResponseModel<DescribeESHitsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeESHits");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeESHitsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取ES查询文档列表
        /// </summary>
        /// <param name="req"><see cref="DescribeESHitsRequest"/></param>
        /// <returns><see cref="DescribeESHitsResponse"/></returns>
        public DescribeESHitsResponse DescribeESHitsSync(DescribeESHitsRequest req)
        {
             JsonResponseModel<DescribeESHitsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeESHits");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeESHitsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询应急漏洞列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEmergencyVulListRequest"/></param>
        /// <returns><see cref="DescribeEmergencyVulListResponse"/></returns>
        public async Task<DescribeEmergencyVulListResponse> DescribeEmergencyVulList(DescribeEmergencyVulListRequest req)
        {
             JsonResponseModel<DescribeEmergencyVulListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEmergencyVulList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEmergencyVulListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询应急漏洞列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEmergencyVulListRequest"/></param>
        /// <returns><see cref="DescribeEmergencyVulListResponse"/></returns>
        public DescribeEmergencyVulListResponse DescribeEmergencyVulListSync(DescribeEmergencyVulListRequest req)
        {
             JsonResponseModel<DescribeEmergencyVulListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEmergencyVulList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEmergencyVulListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeEscapeEventDetail  查询容器逃逸事件详情
        /// </summary>
        /// <param name="req"><see cref="DescribeEscapeEventDetailRequest"/></param>
        /// <returns><see cref="DescribeEscapeEventDetailResponse"/></returns>
        public async Task<DescribeEscapeEventDetailResponse> DescribeEscapeEventDetail(DescribeEscapeEventDetailRequest req)
        {
             JsonResponseModel<DescribeEscapeEventDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEscapeEventDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEscapeEventDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeEscapeEventDetail  查询容器逃逸事件详情
        /// </summary>
        /// <param name="req"><see cref="DescribeEscapeEventDetailRequest"/></param>
        /// <returns><see cref="DescribeEscapeEventDetailResponse"/></returns>
        public DescribeEscapeEventDetailResponse DescribeEscapeEventDetailSync(DescribeEscapeEventDetailRequest req)
        {
             JsonResponseModel<DescribeEscapeEventDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEscapeEventDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEscapeEventDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeEscapeEventInfo 查询容器逃逸事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEscapeEventInfoRequest"/></param>
        /// <returns><see cref="DescribeEscapeEventInfoResponse"/></returns>
        public async Task<DescribeEscapeEventInfoResponse> DescribeEscapeEventInfo(DescribeEscapeEventInfoRequest req)
        {
             JsonResponseModel<DescribeEscapeEventInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEscapeEventInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEscapeEventInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeEscapeEventInfo 查询容器逃逸事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEscapeEventInfoRequest"/></param>
        /// <returns><see cref="DescribeEscapeEventInfoResponse"/></returns>
        public DescribeEscapeEventInfoResponse DescribeEscapeEventInfoSync(DescribeEscapeEventInfoRequest req)
        {
             JsonResponseModel<DescribeEscapeEventInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEscapeEventInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEscapeEventInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询待处理逃逸事件趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeEscapeEventTendencyRequest"/></param>
        /// <returns><see cref="DescribeEscapeEventTendencyResponse"/></returns>
        public async Task<DescribeEscapeEventTendencyResponse> DescribeEscapeEventTendency(DescribeEscapeEventTendencyRequest req)
        {
             JsonResponseModel<DescribeEscapeEventTendencyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEscapeEventTendency");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEscapeEventTendencyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询待处理逃逸事件趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeEscapeEventTendencyRequest"/></param>
        /// <returns><see cref="DescribeEscapeEventTendencyResponse"/></returns>
        public DescribeEscapeEventTendencyResponse DescribeEscapeEventTendencySync(DescribeEscapeEventTendencyRequest req)
        {
             JsonResponseModel<DescribeEscapeEventTendencyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEscapeEventTendency");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEscapeEventTendencyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 统计容器逃逸各事件类型和待处理事件数
        /// </summary>
        /// <param name="req"><see cref="DescribeEscapeEventTypeSummaryRequest"/></param>
        /// <returns><see cref="DescribeEscapeEventTypeSummaryResponse"/></returns>
        public async Task<DescribeEscapeEventTypeSummaryResponse> DescribeEscapeEventTypeSummary(DescribeEscapeEventTypeSummaryRequest req)
        {
             JsonResponseModel<DescribeEscapeEventTypeSummaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEscapeEventTypeSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEscapeEventTypeSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 统计容器逃逸各事件类型和待处理事件数
        /// </summary>
        /// <param name="req"><see cref="DescribeEscapeEventTypeSummaryRequest"/></param>
        /// <returns><see cref="DescribeEscapeEventTypeSummaryResponse"/></returns>
        public DescribeEscapeEventTypeSummaryResponse DescribeEscapeEventTypeSummarySync(DescribeEscapeEventTypeSummaryRequest req)
        {
             JsonResponseModel<DescribeEscapeEventTypeSummaryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEscapeEventTypeSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEscapeEventTypeSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeEscapeEventsExport  查询容器逃逸事件列表导出
        /// </summary>
        /// <param name="req"><see cref="DescribeEscapeEventsExportRequest"/></param>
        /// <returns><see cref="DescribeEscapeEventsExportResponse"/></returns>
        public async Task<DescribeEscapeEventsExportResponse> DescribeEscapeEventsExport(DescribeEscapeEventsExportRequest req)
        {
             JsonResponseModel<DescribeEscapeEventsExportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEscapeEventsExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEscapeEventsExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeEscapeEventsExport  查询容器逃逸事件列表导出
        /// </summary>
        /// <param name="req"><see cref="DescribeEscapeEventsExportRequest"/></param>
        /// <returns><see cref="DescribeEscapeEventsExportResponse"/></returns>
        public DescribeEscapeEventsExportResponse DescribeEscapeEventsExportSync(DescribeEscapeEventsExportRequest req)
        {
             JsonResponseModel<DescribeEscapeEventsExportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEscapeEventsExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEscapeEventsExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeEscapeRuleInfo 查询容器逃逸扫描规则信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEscapeRuleInfoRequest"/></param>
        /// <returns><see cref="DescribeEscapeRuleInfoResponse"/></returns>
        public async Task<DescribeEscapeRuleInfoResponse> DescribeEscapeRuleInfo(DescribeEscapeRuleInfoRequest req)
        {
             JsonResponseModel<DescribeEscapeRuleInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEscapeRuleInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEscapeRuleInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeEscapeRuleInfo 查询容器逃逸扫描规则信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEscapeRuleInfoRequest"/></param>
        /// <returns><see cref="DescribeEscapeRuleInfoResponse"/></returns>
        public DescribeEscapeRuleInfoResponse DescribeEscapeRuleInfoSync(DescribeEscapeRuleInfoRequest req)
        {
             JsonResponseModel<DescribeEscapeRuleInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEscapeRuleInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEscapeRuleInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeEscapeSafeState 查询容器逃逸安全状态
        /// </summary>
        /// <param name="req"><see cref="DescribeEscapeSafeStateRequest"/></param>
        /// <returns><see cref="DescribeEscapeSafeStateResponse"/></returns>
        public async Task<DescribeEscapeSafeStateResponse> DescribeEscapeSafeState(DescribeEscapeSafeStateRequest req)
        {
             JsonResponseModel<DescribeEscapeSafeStateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEscapeSafeState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEscapeSafeStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeEscapeSafeState 查询容器逃逸安全状态
        /// </summary>
        /// <param name="req"><see cref="DescribeEscapeSafeStateRequest"/></param>
        /// <returns><see cref="DescribeEscapeSafeStateResponse"/></returns>
        public DescribeEscapeSafeStateResponse DescribeEscapeSafeStateSync(DescribeEscapeSafeStateRequest req)
        {
             JsonResponseModel<DescribeEscapeSafeStateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEscapeSafeState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEscapeSafeStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询逃逸白名单
        /// </summary>
        /// <param name="req"><see cref="DescribeEscapeWhiteListRequest"/></param>
        /// <returns><see cref="DescribeEscapeWhiteListResponse"/></returns>
        public async Task<DescribeEscapeWhiteListResponse> DescribeEscapeWhiteList(DescribeEscapeWhiteListRequest req)
        {
             JsonResponseModel<DescribeEscapeWhiteListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEscapeWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEscapeWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询逃逸白名单
        /// </summary>
        /// <param name="req"><see cref="DescribeEscapeWhiteListRequest"/></param>
        /// <returns><see cref="DescribeEscapeWhiteListResponse"/></returns>
        public DescribeEscapeWhiteListResponse DescribeEscapeWhiteListSync(DescribeEscapeWhiteListRequest req)
        {
             JsonResponseModel<DescribeEscapeWhiteListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEscapeWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEscapeWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询导出任务的结果
        /// </summary>
        /// <param name="req"><see cref="DescribeExportJobResultRequest"/></param>
        /// <returns><see cref="DescribeExportJobResultResponse"/></returns>
        public async Task<DescribeExportJobResultResponse> DescribeExportJobResult(DescribeExportJobResultRequest req)
        {
             JsonResponseModel<DescribeExportJobResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeExportJobResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExportJobResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询导出任务的结果
        /// </summary>
        /// <param name="req"><see cref="DescribeExportJobResultRequest"/></param>
        /// <returns><see cref="DescribeExportJobResultResponse"/></returns>
        public DescribeExportJobResultResponse DescribeExportJobResultSync(DescribeExportJobResultRequest req)
        {
             JsonResponseModel<DescribeExportJobResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeExportJobResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExportJobResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeImageAuthorizedInfo  查询镜像授权信息
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAuthorizedInfoRequest"/></param>
        /// <returns><see cref="DescribeImageAuthorizedInfoResponse"/></returns>
        public async Task<DescribeImageAuthorizedInfoResponse> DescribeImageAuthorizedInfo(DescribeImageAuthorizedInfoRequest req)
        {
             JsonResponseModel<DescribeImageAuthorizedInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImageAuthorizedInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageAuthorizedInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeImageAuthorizedInfo  查询镜像授权信息
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAuthorizedInfoRequest"/></param>
        /// <returns><see cref="DescribeImageAuthorizedInfoResponse"/></returns>
        public DescribeImageAuthorizedInfoResponse DescribeImageAuthorizedInfoSync(DescribeImageAuthorizedInfoRequest req)
        {
             JsonResponseModel<DescribeImageAuthorizedInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImageAuthorizedInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageAuthorizedInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询镜像自动授权结果列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAutoAuthorizedLogListRequest"/></param>
        /// <returns><see cref="DescribeImageAutoAuthorizedLogListResponse"/></returns>
        public async Task<DescribeImageAutoAuthorizedLogListResponse> DescribeImageAutoAuthorizedLogList(DescribeImageAutoAuthorizedLogListRequest req)
        {
             JsonResponseModel<DescribeImageAutoAuthorizedLogListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImageAutoAuthorizedLogList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageAutoAuthorizedLogListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询镜像自动授权结果列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAutoAuthorizedLogListRequest"/></param>
        /// <returns><see cref="DescribeImageAutoAuthorizedLogListResponse"/></returns>
        public DescribeImageAutoAuthorizedLogListResponse DescribeImageAutoAuthorizedLogListSync(DescribeImageAutoAuthorizedLogListRequest req)
        {
             JsonResponseModel<DescribeImageAutoAuthorizedLogListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImageAutoAuthorizedLogList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageAutoAuthorizedLogListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询本地镜像自动授权规则
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAutoAuthorizedRuleRequest"/></param>
        /// <returns><see cref="DescribeImageAutoAuthorizedRuleResponse"/></returns>
        public async Task<DescribeImageAutoAuthorizedRuleResponse> DescribeImageAutoAuthorizedRule(DescribeImageAutoAuthorizedRuleRequest req)
        {
             JsonResponseModel<DescribeImageAutoAuthorizedRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImageAutoAuthorizedRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageAutoAuthorizedRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询本地镜像自动授权规则
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAutoAuthorizedRuleRequest"/></param>
        /// <returns><see cref="DescribeImageAutoAuthorizedRuleResponse"/></returns>
        public DescribeImageAutoAuthorizedRuleResponse DescribeImageAutoAuthorizedRuleSync(DescribeImageAutoAuthorizedRuleRequest req)
        {
             JsonResponseModel<DescribeImageAutoAuthorizedRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImageAutoAuthorizedRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageAutoAuthorizedRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询镜像自动授权任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAutoAuthorizedTaskListRequest"/></param>
        /// <returns><see cref="DescribeImageAutoAuthorizedTaskListResponse"/></returns>
        public async Task<DescribeImageAutoAuthorizedTaskListResponse> DescribeImageAutoAuthorizedTaskList(DescribeImageAutoAuthorizedTaskListRequest req)
        {
             JsonResponseModel<DescribeImageAutoAuthorizedTaskListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImageAutoAuthorizedTaskList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageAutoAuthorizedTaskListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询镜像自动授权任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAutoAuthorizedTaskListRequest"/></param>
        /// <returns><see cref="DescribeImageAutoAuthorizedTaskListResponse"/></returns>
        public DescribeImageAutoAuthorizedTaskListResponse DescribeImageAutoAuthorizedTaskListSync(DescribeImageAutoAuthorizedTaskListRequest req)
        {
             JsonResponseModel<DescribeImageAutoAuthorizedTaskListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImageAutoAuthorizedTaskList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageAutoAuthorizedTaskListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询本地镜像组件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageComponentListRequest"/></param>
        /// <returns><see cref="DescribeImageComponentListResponse"/></returns>
        public async Task<DescribeImageComponentListResponse> DescribeImageComponentList(DescribeImageComponentListRequest req)
        {
             JsonResponseModel<DescribeImageComponentListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImageComponentList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageComponentListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询本地镜像组件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageComponentListRequest"/></param>
        /// <returns><see cref="DescribeImageComponentListResponse"/></returns>
        public DescribeImageComponentListResponse DescribeImageComponentListSync(DescribeImageComponentListRequest req)
        {
             JsonResponseModel<DescribeImageComponentListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImageComponentList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageComponentListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户镜像仓库下的项目名称列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRegistryNamespaceListRequest"/></param>
        /// <returns><see cref="DescribeImageRegistryNamespaceListResponse"/></returns>
        public async Task<DescribeImageRegistryNamespaceListResponse> DescribeImageRegistryNamespaceList(DescribeImageRegistryNamespaceListRequest req)
        {
             JsonResponseModel<DescribeImageRegistryNamespaceListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImageRegistryNamespaceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageRegistryNamespaceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户镜像仓库下的项目名称列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRegistryNamespaceListRequest"/></param>
        /// <returns><see cref="DescribeImageRegistryNamespaceListResponse"/></returns>
        public DescribeImageRegistryNamespaceListResponse DescribeImageRegistryNamespaceListSync(DescribeImageRegistryNamespaceListRequest req)
        {
             JsonResponseModel<DescribeImageRegistryNamespaceListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImageRegistryNamespaceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageRegistryNamespaceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 镜像仓库查看定时任务
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRegistryTimingScanTaskRequest"/></param>
        /// <returns><see cref="DescribeImageRegistryTimingScanTaskResponse"/></returns>
        public async Task<DescribeImageRegistryTimingScanTaskResponse> DescribeImageRegistryTimingScanTask(DescribeImageRegistryTimingScanTaskRequest req)
        {
             JsonResponseModel<DescribeImageRegistryTimingScanTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImageRegistryTimingScanTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageRegistryTimingScanTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 镜像仓库查看定时任务
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRegistryTimingScanTaskRequest"/></param>
        /// <returns><see cref="DescribeImageRegistryTimingScanTaskResponse"/></returns>
        public DescribeImageRegistryTimingScanTaskResponse DescribeImageRegistryTimingScanTaskSync(DescribeImageRegistryTimingScanTaskRequest req)
        {
             JsonResponseModel<DescribeImageRegistryTimingScanTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImageRegistryTimingScanTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageRegistryTimingScanTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询本地镜像风险概览
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRiskSummaryRequest"/></param>
        /// <returns><see cref="DescribeImageRiskSummaryResponse"/></returns>
        public async Task<DescribeImageRiskSummaryResponse> DescribeImageRiskSummary(DescribeImageRiskSummaryRequest req)
        {
             JsonResponseModel<DescribeImageRiskSummaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImageRiskSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageRiskSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询本地镜像风险概览
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRiskSummaryRequest"/></param>
        /// <returns><see cref="DescribeImageRiskSummaryResponse"/></returns>
        public DescribeImageRiskSummaryResponse DescribeImageRiskSummarySync(DescribeImageRiskSummaryRequest req)
        {
             JsonResponseModel<DescribeImageRiskSummaryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImageRiskSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageRiskSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询容器安全本地镜像风险趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRiskTendencyRequest"/></param>
        /// <returns><see cref="DescribeImageRiskTendencyResponse"/></returns>
        public async Task<DescribeImageRiskTendencyResponse> DescribeImageRiskTendency(DescribeImageRiskTendencyRequest req)
        {
             JsonResponseModel<DescribeImageRiskTendencyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImageRiskTendency");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageRiskTendencyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询容器安全本地镜像风险趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRiskTendencyRequest"/></param>
        /// <returns><see cref="DescribeImageRiskTendencyResponse"/></returns>
        public DescribeImageRiskTendencyResponse DescribeImageRiskTendencySync(DescribeImageRiskTendencyRequest req)
        {
             JsonResponseModel<DescribeImageRiskTendencyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImageRiskTendency");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageRiskTendencyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeImageSimpleList 查询全部镜像列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageSimpleListRequest"/></param>
        /// <returns><see cref="DescribeImageSimpleListResponse"/></returns>
        public async Task<DescribeImageSimpleListResponse> DescribeImageSimpleList(DescribeImageSimpleListRequest req)
        {
             JsonResponseModel<DescribeImageSimpleListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImageSimpleList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageSimpleListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeImageSimpleList 查询全部镜像列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageSimpleListRequest"/></param>
        /// <returns><see cref="DescribeImageSimpleListResponse"/></returns>
        public DescribeImageSimpleListResponse DescribeImageSimpleListSync(DescribeImageSimpleListRequest req)
        {
             JsonResponseModel<DescribeImageSimpleListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImageSimpleList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageSimpleListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取索引列表
        /// </summary>
        /// <param name="req"><see cref="DescribeIndexListRequest"/></param>
        /// <returns><see cref="DescribeIndexListResponse"/></returns>
        public async Task<DescribeIndexListResponse> DescribeIndexList(DescribeIndexListRequest req)
        {
             JsonResponseModel<DescribeIndexListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIndexList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIndexListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取索引列表
        /// </summary>
        /// <param name="req"><see cref="DescribeIndexListRequest"/></param>
        /// <returns><see cref="DescribeIndexListResponse"/></returns>
        public DescribeIndexListResponse DescribeIndexListSync(DescribeIndexListRequest req)
        {
             JsonResponseModel<DescribeIndexListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIndexList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIndexListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询检查报告
        /// </summary>
        /// <param name="req"><see cref="DescribeInspectionReportRequest"/></param>
        /// <returns><see cref="DescribeInspectionReportResponse"/></returns>
        public async Task<DescribeInspectionReportResponse> DescribeInspectionReport(DescribeInspectionReportRequest req)
        {
             JsonResponseModel<DescribeInspectionReportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInspectionReport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInspectionReportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询检查报告
        /// </summary>
        /// <param name="req"><see cref="DescribeInspectionReportRequest"/></param>
        /// <returns><see cref="DescribeInspectionReportResponse"/></returns>
        public DescribeInspectionReportResponse DescribeInspectionReportSync(DescribeInspectionReportRequest req)
        {
             JsonResponseModel<DescribeInspectionReportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInspectionReport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInspectionReportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取日志检索容量使用统计
        /// </summary>
        /// <param name="req"><see cref="DescribeLogStorageStatisticRequest"/></param>
        /// <returns><see cref="DescribeLogStorageStatisticResponse"/></returns>
        public async Task<DescribeLogStorageStatisticResponse> DescribeLogStorageStatistic(DescribeLogStorageStatisticRequest req)
        {
             JsonResponseModel<DescribeLogStorageStatisticResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLogStorageStatistic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogStorageStatisticResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取日志检索容量使用统计
        /// </summary>
        /// <param name="req"><see cref="DescribeLogStorageStatisticRequest"/></param>
        /// <returns><see cref="DescribeLogStorageStatisticResponse"/></returns>
        public DescribeLogStorageStatisticResponse DescribeLogStorageStatisticSync(DescribeLogStorageStatisticRequest req)
        {
             JsonResponseModel<DescribeLogStorageStatisticResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLogStorageStatistic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogStorageStatisticResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群策略审计列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkFirewallAuditRecordRequest"/></param>
        /// <returns><see cref="DescribeNetworkFirewallAuditRecordResponse"/></returns>
        public async Task<DescribeNetworkFirewallAuditRecordResponse> DescribeNetworkFirewallAuditRecord(DescribeNetworkFirewallAuditRecordRequest req)
        {
             JsonResponseModel<DescribeNetworkFirewallAuditRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNetworkFirewallAuditRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetworkFirewallAuditRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群策略审计列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkFirewallAuditRecordRequest"/></param>
        /// <returns><see cref="DescribeNetworkFirewallAuditRecordResponse"/></returns>
        public DescribeNetworkFirewallAuditRecordResponse DescribeNetworkFirewallAuditRecordSync(DescribeNetworkFirewallAuditRecordRequest req)
        {
             JsonResponseModel<DescribeNetworkFirewallAuditRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNetworkFirewallAuditRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetworkFirewallAuditRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkFirewallClusterListRequest"/></param>
        /// <returns><see cref="DescribeNetworkFirewallClusterListResponse"/></returns>
        public async Task<DescribeNetworkFirewallClusterListResponse> DescribeNetworkFirewallClusterList(DescribeNetworkFirewallClusterListRequest req)
        {
             JsonResponseModel<DescribeNetworkFirewallClusterListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNetworkFirewallClusterList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetworkFirewallClusterListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkFirewallClusterListRequest"/></param>
        /// <returns><see cref="DescribeNetworkFirewallClusterListResponse"/></returns>
        public DescribeNetworkFirewallClusterListResponse DescribeNetworkFirewallClusterListSync(DescribeNetworkFirewallClusterListRequest req)
        {
             JsonResponseModel<DescribeNetworkFirewallClusterListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNetworkFirewallClusterList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetworkFirewallClusterListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器网络查询资产任务进度
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkFirewallClusterRefreshStatusRequest"/></param>
        /// <returns><see cref="DescribeNetworkFirewallClusterRefreshStatusResponse"/></returns>
        public async Task<DescribeNetworkFirewallClusterRefreshStatusResponse> DescribeNetworkFirewallClusterRefreshStatus(DescribeNetworkFirewallClusterRefreshStatusRequest req)
        {
             JsonResponseModel<DescribeNetworkFirewallClusterRefreshStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNetworkFirewallClusterRefreshStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetworkFirewallClusterRefreshStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器网络查询资产任务进度
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkFirewallClusterRefreshStatusRequest"/></param>
        /// <returns><see cref="DescribeNetworkFirewallClusterRefreshStatusResponse"/></returns>
        public DescribeNetworkFirewallClusterRefreshStatusResponse DescribeNetworkFirewallClusterRefreshStatusSync(DescribeNetworkFirewallClusterRefreshStatusRequest req)
        {
             JsonResponseModel<DescribeNetworkFirewallClusterRefreshStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNetworkFirewallClusterRefreshStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetworkFirewallClusterRefreshStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群网络空间标签列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkFirewallNamespaceLabelListRequest"/></param>
        /// <returns><see cref="DescribeNetworkFirewallNamespaceLabelListResponse"/></returns>
        public async Task<DescribeNetworkFirewallNamespaceLabelListResponse> DescribeNetworkFirewallNamespaceLabelList(DescribeNetworkFirewallNamespaceLabelListRequest req)
        {
             JsonResponseModel<DescribeNetworkFirewallNamespaceLabelListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNetworkFirewallNamespaceLabelList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetworkFirewallNamespaceLabelListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群网络空间标签列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkFirewallNamespaceLabelListRequest"/></param>
        /// <returns><see cref="DescribeNetworkFirewallNamespaceLabelListResponse"/></returns>
        public DescribeNetworkFirewallNamespaceLabelListResponse DescribeNetworkFirewallNamespaceLabelListSync(DescribeNetworkFirewallNamespaceLabelListRequest req)
        {
             JsonResponseModel<DescribeNetworkFirewallNamespaceLabelListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNetworkFirewallNamespaceLabelList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetworkFirewallNamespaceLabelListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群网络空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkFirewallNamespaceListRequest"/></param>
        /// <returns><see cref="DescribeNetworkFirewallNamespaceListResponse"/></returns>
        public async Task<DescribeNetworkFirewallNamespaceListResponse> DescribeNetworkFirewallNamespaceList(DescribeNetworkFirewallNamespaceListRequest req)
        {
             JsonResponseModel<DescribeNetworkFirewallNamespaceListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNetworkFirewallNamespaceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetworkFirewallNamespaceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群网络空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkFirewallNamespaceListRequest"/></param>
        /// <returns><see cref="DescribeNetworkFirewallNamespaceListResponse"/></returns>
        public DescribeNetworkFirewallNamespaceListResponse DescribeNetworkFirewallNamespaceListSync(DescribeNetworkFirewallNamespaceListRequest req)
        {
             JsonResponseModel<DescribeNetworkFirewallNamespaceListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNetworkFirewallNamespaceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetworkFirewallNamespaceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群网络pod标签
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkFirewallPodLabelsListRequest"/></param>
        /// <returns><see cref="DescribeNetworkFirewallPodLabelsListResponse"/></returns>
        public async Task<DescribeNetworkFirewallPodLabelsListResponse> DescribeNetworkFirewallPodLabelsList(DescribeNetworkFirewallPodLabelsListRequest req)
        {
             JsonResponseModel<DescribeNetworkFirewallPodLabelsListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNetworkFirewallPodLabelsList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetworkFirewallPodLabelsListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群网络pod标签
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkFirewallPodLabelsListRequest"/></param>
        /// <returns><see cref="DescribeNetworkFirewallPodLabelsListResponse"/></returns>
        public DescribeNetworkFirewallPodLabelsListResponse DescribeNetworkFirewallPodLabelsListSync(DescribeNetworkFirewallPodLabelsListRequest req)
        {
             JsonResponseModel<DescribeNetworkFirewallPodLabelsListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNetworkFirewallPodLabelsList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetworkFirewallPodLabelsListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器网络集群查看策略详情
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkFirewallPolicyDetailRequest"/></param>
        /// <returns><see cref="DescribeNetworkFirewallPolicyDetailResponse"/></returns>
        public async Task<DescribeNetworkFirewallPolicyDetailResponse> DescribeNetworkFirewallPolicyDetail(DescribeNetworkFirewallPolicyDetailRequest req)
        {
             JsonResponseModel<DescribeNetworkFirewallPolicyDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNetworkFirewallPolicyDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetworkFirewallPolicyDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器网络集群查看策略详情
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkFirewallPolicyDetailRequest"/></param>
        /// <returns><see cref="DescribeNetworkFirewallPolicyDetailResponse"/></returns>
        public DescribeNetworkFirewallPolicyDetailResponse DescribeNetworkFirewallPolicyDetailSync(DescribeNetworkFirewallPolicyDetailRequest req)
        {
             JsonResponseModel<DescribeNetworkFirewallPolicyDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNetworkFirewallPolicyDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetworkFirewallPolicyDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器网络查询网络策略自动发现任务进度
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkFirewallPolicyDiscoverRequest"/></param>
        /// <returns><see cref="DescribeNetworkFirewallPolicyDiscoverResponse"/></returns>
        public async Task<DescribeNetworkFirewallPolicyDiscoverResponse> DescribeNetworkFirewallPolicyDiscover(DescribeNetworkFirewallPolicyDiscoverRequest req)
        {
             JsonResponseModel<DescribeNetworkFirewallPolicyDiscoverResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNetworkFirewallPolicyDiscover");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetworkFirewallPolicyDiscoverResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器网络查询网络策略自动发现任务进度
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkFirewallPolicyDiscoverRequest"/></param>
        /// <returns><see cref="DescribeNetworkFirewallPolicyDiscoverResponse"/></returns>
        public DescribeNetworkFirewallPolicyDiscoverResponse DescribeNetworkFirewallPolicyDiscoverSync(DescribeNetworkFirewallPolicyDiscoverRequest req)
        {
             JsonResponseModel<DescribeNetworkFirewallPolicyDiscoverResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNetworkFirewallPolicyDiscover");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetworkFirewallPolicyDiscoverResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群网络策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkFirewallPolicyListRequest"/></param>
        /// <returns><see cref="DescribeNetworkFirewallPolicyListResponse"/></returns>
        public async Task<DescribeNetworkFirewallPolicyListResponse> DescribeNetworkFirewallPolicyList(DescribeNetworkFirewallPolicyListRequest req)
        {
             JsonResponseModel<DescribeNetworkFirewallPolicyListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNetworkFirewallPolicyList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetworkFirewallPolicyListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询集群网络策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkFirewallPolicyListRequest"/></param>
        /// <returns><see cref="DescribeNetworkFirewallPolicyListResponse"/></returns>
        public DescribeNetworkFirewallPolicyListResponse DescribeNetworkFirewallPolicyListSync(DescribeNetworkFirewallPolicyListRequest req)
        {
             JsonResponseModel<DescribeNetworkFirewallPolicyListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNetworkFirewallPolicyList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetworkFirewallPolicyListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器网络查询网络策略策略执行状态
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkFirewallPolicyStatusRequest"/></param>
        /// <returns><see cref="DescribeNetworkFirewallPolicyStatusResponse"/></returns>
        public async Task<DescribeNetworkFirewallPolicyStatusResponse> DescribeNetworkFirewallPolicyStatus(DescribeNetworkFirewallPolicyStatusRequest req)
        {
             JsonResponseModel<DescribeNetworkFirewallPolicyStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNetworkFirewallPolicyStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetworkFirewallPolicyStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器网络查询网络策略策略执行状态
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkFirewallPolicyStatusRequest"/></param>
        /// <returns><see cref="DescribeNetworkFirewallPolicyStatusResponse"/></returns>
        public DescribeNetworkFirewallPolicyStatusResponse DescribeNetworkFirewallPolicyStatusSync(DescribeNetworkFirewallPolicyStatusRequest req)
        {
             JsonResponseModel<DescribeNetworkFirewallPolicyStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNetworkFirewallPolicyStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetworkFirewallPolicyStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器网络集群查看Yaml网络策略详情
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkFirewallPolicyYamlDetailRequest"/></param>
        /// <returns><see cref="DescribeNetworkFirewallPolicyYamlDetailResponse"/></returns>
        public async Task<DescribeNetworkFirewallPolicyYamlDetailResponse> DescribeNetworkFirewallPolicyYamlDetail(DescribeNetworkFirewallPolicyYamlDetailRequest req)
        {
             JsonResponseModel<DescribeNetworkFirewallPolicyYamlDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNetworkFirewallPolicyYamlDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetworkFirewallPolicyYamlDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器网络集群查看Yaml网络策略详情
        /// </summary>
        /// <param name="req"><see cref="DescribeNetworkFirewallPolicyYamlDetailRequest"/></param>
        /// <returns><see cref="DescribeNetworkFirewallPolicyYamlDetailResponse"/></returns>
        public DescribeNetworkFirewallPolicyYamlDetailResponse DescribeNetworkFirewallPolicyYamlDetailSync(DescribeNetworkFirewallPolicyYamlDetailRequest req)
        {
             JsonResponseModel<DescribeNetworkFirewallPolicyYamlDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNetworkFirewallPolicyYamlDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNetworkFirewallPolicyYamlDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询最新披露漏洞列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNewestVulRequest"/></param>
        /// <returns><see cref="DescribeNewestVulResponse"/></returns>
        public async Task<DescribeNewestVulResponse> DescribeNewestVul(DescribeNewestVulRequest req)
        {
             JsonResponseModel<DescribeNewestVulResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNewestVul");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNewestVulResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询最新披露漏洞列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNewestVulRequest"/></param>
        /// <returns><see cref="DescribeNewestVulResponse"/></returns>
        public DescribeNewestVulResponse DescribeNewestVulSync(DescribeNewestVulRequest req)
        {
             JsonResponseModel<DescribeNewestVulResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNewestVul");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNewestVulResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribePostPayDetail  查询后付费详情
        /// </summary>
        /// <param name="req"><see cref="DescribePostPayDetailRequest"/></param>
        /// <returns><see cref="DescribePostPayDetailResponse"/></returns>
        public async Task<DescribePostPayDetailResponse> DescribePostPayDetail(DescribePostPayDetailRequest req)
        {
             JsonResponseModel<DescribePostPayDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePostPayDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePostPayDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribePostPayDetail  查询后付费详情
        /// </summary>
        /// <param name="req"><see cref="DescribePostPayDetailRequest"/></param>
        /// <returns><see cref="DescribePostPayDetailResponse"/></returns>
        public DescribePostPayDetailResponse DescribePostPayDetailSync(DescribePostPayDetailRequest req)
        {
             JsonResponseModel<DescribePostPayDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePostPayDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePostPayDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeProVersionInfo  查询专业版需购买信息
        /// </summary>
        /// <param name="req"><see cref="DescribeProVersionInfoRequest"/></param>
        /// <returns><see cref="DescribeProVersionInfoResponse"/></returns>
        public async Task<DescribeProVersionInfoResponse> DescribeProVersionInfo(DescribeProVersionInfoRequest req)
        {
             JsonResponseModel<DescribeProVersionInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProVersionInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProVersionInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeProVersionInfo  查询专业版需购买信息
        /// </summary>
        /// <param name="req"><see cref="DescribeProVersionInfoRequest"/></param>
        /// <returns><see cref="DescribeProVersionInfoResponse"/></returns>
        public DescribeProVersionInfoResponse DescribeProVersionInfoSync(DescribeProVersionInfoRequest req)
        {
             JsonResponseModel<DescribeProVersionInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProVersionInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProVersionInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询促销活动
        /// </summary>
        /// <param name="req"><see cref="DescribePromotionActivityRequest"/></param>
        /// <returns><see cref="DescribePromotionActivityResponse"/></returns>
        public async Task<DescribePromotionActivityResponse> DescribePromotionActivity(DescribePromotionActivityRequest req)
        {
             JsonResponseModel<DescribePromotionActivityResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePromotionActivity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePromotionActivityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询促销活动
        /// </summary>
        /// <param name="req"><see cref="DescribePromotionActivityRequest"/></param>
        /// <returns><see cref="DescribePromotionActivityResponse"/></returns>
        public DescribePromotionActivityResponse DescribePromotionActivitySync(DescribePromotionActivityRequest req)
        {
             JsonResponseModel<DescribePromotionActivityResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePromotionActivity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePromotionActivityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取公钥
        /// </summary>
        /// <param name="req"><see cref="DescribePublicKeyRequest"/></param>
        /// <returns><see cref="DescribePublicKeyResponse"/></returns>
        public async Task<DescribePublicKeyResponse> DescribePublicKey(DescribePublicKeyRequest req)
        {
             JsonResponseModel<DescribePublicKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePublicKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePublicKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取公钥
        /// </summary>
        /// <param name="req"><see cref="DescribePublicKeyRequest"/></param>
        /// <returns><see cref="DescribePublicKeyResponse"/></returns>
        public DescribePublicKeyResponse DescribePublicKeySync(DescribePublicKeyRequest req)
        {
             JsonResponseModel<DescribePublicKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePublicKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePublicKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribePurchaseStateInfo 查询容器安全服务已购买信息
        /// </summary>
        /// <param name="req"><see cref="DescribePurchaseStateInfoRequest"/></param>
        /// <returns><see cref="DescribePurchaseStateInfoResponse"/></returns>
        public async Task<DescribePurchaseStateInfoResponse> DescribePurchaseStateInfo(DescribePurchaseStateInfoRequest req)
        {
             JsonResponseModel<DescribePurchaseStateInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePurchaseStateInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePurchaseStateInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribePurchaseStateInfo 查询容器安全服务已购买信息
        /// </summary>
        /// <param name="req"><see cref="DescribePurchaseStateInfoRequest"/></param>
        /// <returns><see cref="DescribePurchaseStateInfoResponse"/></returns>
        public DescribePurchaseStateInfoResponse DescribePurchaseStateInfoSync(DescribePurchaseStateInfoRequest req)
        {
             JsonResponseModel<DescribePurchaseStateInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePurchaseStateInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePurchaseStateInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询刷新任务
        /// </summary>
        /// <param name="req"><see cref="DescribeRefreshTaskRequest"/></param>
        /// <returns><see cref="DescribeRefreshTaskResponse"/></returns>
        public async Task<DescribeRefreshTaskResponse> DescribeRefreshTask(DescribeRefreshTaskRequest req)
        {
             JsonResponseModel<DescribeRefreshTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRefreshTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRefreshTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询刷新任务
        /// </summary>
        /// <param name="req"><see cref="DescribeRefreshTaskRequest"/></param>
        /// <returns><see cref="DescribeRefreshTaskResponse"/></returns>
        public DescribeRefreshTaskResponse DescribeRefreshTaskSync(DescribeRefreshTaskRequest req)
        {
             JsonResponseModel<DescribeRefreshTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRefreshTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRefreshTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询运行时反弹shell事件详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeReverseShellDetailRequest"/></param>
        /// <returns><see cref="DescribeReverseShellDetailResponse"/></returns>
        public async Task<DescribeReverseShellDetailResponse> DescribeReverseShellDetail(DescribeReverseShellDetailRequest req)
        {
             JsonResponseModel<DescribeReverseShellDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeReverseShellDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReverseShellDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询运行时反弹shell事件详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeReverseShellDetailRequest"/></param>
        /// <returns><see cref="DescribeReverseShellDetailResponse"/></returns>
        public DescribeReverseShellDetailResponse DescribeReverseShellDetailSync(DescribeReverseShellDetailRequest req)
        {
             JsonResponseModel<DescribeReverseShellDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeReverseShellDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReverseShellDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询运行时反弹shell事件列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeReverseShellEventsRequest"/></param>
        /// <returns><see cref="DescribeReverseShellEventsResponse"/></returns>
        public async Task<DescribeReverseShellEventsResponse> DescribeReverseShellEvents(DescribeReverseShellEventsRequest req)
        {
             JsonResponseModel<DescribeReverseShellEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeReverseShellEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReverseShellEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询运行时反弹shell事件列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeReverseShellEventsRequest"/></param>
        /// <returns><see cref="DescribeReverseShellEventsResponse"/></returns>
        public DescribeReverseShellEventsResponse DescribeReverseShellEventsSync(DescribeReverseShellEventsRequest req)
        {
             JsonResponseModel<DescribeReverseShellEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeReverseShellEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReverseShellEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询运行时反弹shell事件列表信息导出
        /// </summary>
        /// <param name="req"><see cref="DescribeReverseShellEventsExportRequest"/></param>
        /// <returns><see cref="DescribeReverseShellEventsExportResponse"/></returns>
        public async Task<DescribeReverseShellEventsExportResponse> DescribeReverseShellEventsExport(DescribeReverseShellEventsExportRequest req)
        {
             JsonResponseModel<DescribeReverseShellEventsExportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeReverseShellEventsExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReverseShellEventsExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询运行时反弹shell事件列表信息导出
        /// </summary>
        /// <param name="req"><see cref="DescribeReverseShellEventsExportRequest"/></param>
        /// <returns><see cref="DescribeReverseShellEventsExportResponse"/></returns>
        public DescribeReverseShellEventsExportResponse DescribeReverseShellEventsExportSync(DescribeReverseShellEventsExportRequest req)
        {
             JsonResponseModel<DescribeReverseShellEventsExportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeReverseShellEventsExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReverseShellEventsExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询运行时反弹shell白名单详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeReverseShellWhiteListDetailRequest"/></param>
        /// <returns><see cref="DescribeReverseShellWhiteListDetailResponse"/></returns>
        public async Task<DescribeReverseShellWhiteListDetailResponse> DescribeReverseShellWhiteListDetail(DescribeReverseShellWhiteListDetailRequest req)
        {
             JsonResponseModel<DescribeReverseShellWhiteListDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeReverseShellWhiteListDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReverseShellWhiteListDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询运行时反弹shell白名单详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeReverseShellWhiteListDetailRequest"/></param>
        /// <returns><see cref="DescribeReverseShellWhiteListDetailResponse"/></returns>
        public DescribeReverseShellWhiteListDetailResponse DescribeReverseShellWhiteListDetailSync(DescribeReverseShellWhiteListDetailRequest req)
        {
             JsonResponseModel<DescribeReverseShellWhiteListDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeReverseShellWhiteListDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReverseShellWhiteListDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询运行时运行时反弹shell白名单列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeReverseShellWhiteListsRequest"/></param>
        /// <returns><see cref="DescribeReverseShellWhiteListsResponse"/></returns>
        public async Task<DescribeReverseShellWhiteListsResponse> DescribeReverseShellWhiteLists(DescribeReverseShellWhiteListsRequest req)
        {
             JsonResponseModel<DescribeReverseShellWhiteListsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeReverseShellWhiteLists");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReverseShellWhiteListsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询运行时运行时反弹shell白名单列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeReverseShellWhiteListsRequest"/></param>
        /// <returns><see cref="DescribeReverseShellWhiteListsResponse"/></returns>
        public DescribeReverseShellWhiteListsResponse DescribeReverseShellWhiteListsSync(DescribeReverseShellWhiteListsRequest req)
        {
             JsonResponseModel<DescribeReverseShellWhiteListsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeReverseShellWhiteLists");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReverseShellWhiteListsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询最近一次任务发现的风险项的信息列表，支持根据特殊字段进行过滤
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskListResponse"/></returns>
        public async Task<DescribeRiskListResponse> DescribeRiskList(DescribeRiskListRequest req)
        {
             JsonResponseModel<DescribeRiskListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRiskList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRiskListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询最近一次任务发现的风险项的信息列表，支持根据特殊字段进行过滤
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskListResponse"/></returns>
        public DescribeRiskListResponse DescribeRiskListSync(DescribeRiskListRequest req)
        {
             JsonResponseModel<DescribeRiskListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRiskList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRiskListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询高危系统调用事件详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskSyscallDetailRequest"/></param>
        /// <returns><see cref="DescribeRiskSyscallDetailResponse"/></returns>
        public async Task<DescribeRiskSyscallDetailResponse> DescribeRiskSyscallDetail(DescribeRiskSyscallDetailRequest req)
        {
             JsonResponseModel<DescribeRiskSyscallDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRiskSyscallDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRiskSyscallDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询高危系统调用事件详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskSyscallDetailRequest"/></param>
        /// <returns><see cref="DescribeRiskSyscallDetailResponse"/></returns>
        public DescribeRiskSyscallDetailResponse DescribeRiskSyscallDetailSync(DescribeRiskSyscallDetailRequest req)
        {
             JsonResponseModel<DescribeRiskSyscallDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRiskSyscallDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRiskSyscallDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询运行时运行时高危系统调用列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskSyscallEventsRequest"/></param>
        /// <returns><see cref="DescribeRiskSyscallEventsResponse"/></returns>
        public async Task<DescribeRiskSyscallEventsResponse> DescribeRiskSyscallEvents(DescribeRiskSyscallEventsRequest req)
        {
             JsonResponseModel<DescribeRiskSyscallEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRiskSyscallEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRiskSyscallEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询运行时运行时高危系统调用列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskSyscallEventsRequest"/></param>
        /// <returns><see cref="DescribeRiskSyscallEventsResponse"/></returns>
        public DescribeRiskSyscallEventsResponse DescribeRiskSyscallEventsSync(DescribeRiskSyscallEventsRequest req)
        {
             JsonResponseModel<DescribeRiskSyscallEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRiskSyscallEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRiskSyscallEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运行时高危系统调用列表导出
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskSyscallEventsExportRequest"/></param>
        /// <returns><see cref="DescribeRiskSyscallEventsExportResponse"/></returns>
        public async Task<DescribeRiskSyscallEventsExportResponse> DescribeRiskSyscallEventsExport(DescribeRiskSyscallEventsExportRequest req)
        {
             JsonResponseModel<DescribeRiskSyscallEventsExportResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRiskSyscallEventsExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRiskSyscallEventsExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运行时高危系统调用列表导出
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskSyscallEventsExportRequest"/></param>
        /// <returns><see cref="DescribeRiskSyscallEventsExportResponse"/></returns>
        public DescribeRiskSyscallEventsExportResponse DescribeRiskSyscallEventsExportSync(DescribeRiskSyscallEventsExportRequest req)
        {
             JsonResponseModel<DescribeRiskSyscallEventsExportResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRiskSyscallEventsExport");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRiskSyscallEventsExportResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询运行时高危系统调用系统名称列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskSyscallNamesRequest"/></param>
        /// <returns><see cref="DescribeRiskSyscallNamesResponse"/></returns>
        public async Task<DescribeRiskSyscallNamesResponse> DescribeRiskSyscallNames(DescribeRiskSyscallNamesRequest req)
        {
             JsonResponseModel<DescribeRiskSyscallNamesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRiskSyscallNames");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRiskSyscallNamesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询运行时高危系统调用系统名称列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskSyscallNamesRequest"/></param>
        /// <returns><see cref="DescribeRiskSyscallNamesResponse"/></returns>
        public DescribeRiskSyscallNamesResponse DescribeRiskSyscallNamesSync(DescribeRiskSyscallNamesRequest req)
        {
             JsonResponseModel<DescribeRiskSyscallNamesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRiskSyscallNames");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRiskSyscallNamesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询运行时高危系统调用白名单详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskSyscallWhiteListDetailRequest"/></param>
        /// <returns><see cref="DescribeRiskSyscallWhiteListDetailResponse"/></returns>
        public async Task<DescribeRiskSyscallWhiteListDetailResponse> DescribeRiskSyscallWhiteListDetail(DescribeRiskSyscallWhiteListDetailRequest req)
        {
             JsonResponseModel<DescribeRiskSyscallWhiteListDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRiskSyscallWhiteListDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRiskSyscallWhiteListDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询运行时高危系统调用白名单详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskSyscallWhiteListDetailRequest"/></param>
        /// <returns><see cref="DescribeRiskSyscallWhiteListDetailResponse"/></returns>
        public DescribeRiskSyscallWhiteListDetailResponse DescribeRiskSyscallWhiteListDetailSync(DescribeRiskSyscallWhiteListDetailRequest req)
        {
             JsonResponseModel<DescribeRiskSyscallWhiteListDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRiskSyscallWhiteListDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRiskSyscallWhiteListDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询运行时高危系统调用白名单列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskSyscallWhiteListsRequest"/></param>
        /// <returns><see cref="DescribeRiskSyscallWhiteListsResponse"/></returns>
        public async Task<DescribeRiskSyscallWhiteListsResponse> DescribeRiskSyscallWhiteLists(DescribeRiskSyscallWhiteListsRequest req)
        {
             JsonResponseModel<DescribeRiskSyscallWhiteListsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRiskSyscallWhiteLists");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRiskSyscallWhiteListsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询运行时高危系统调用白名单列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskSyscallWhiteListsRequest"/></param>
        /// <returns><see cref="DescribeRiskSyscallWhiteListsResponse"/></returns>
        public DescribeRiskSyscallWhiteListsResponse DescribeRiskSyscallWhiteListsSync(DescribeRiskSyscallWhiteListsRequest req)
        {
             JsonResponseModel<DescribeRiskSyscallWhiteListsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRiskSyscallWhiteLists");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRiskSyscallWhiteListsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询扫描忽略的漏洞列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScanIgnoreVulListRequest"/></param>
        /// <returns><see cref="DescribeScanIgnoreVulListResponse"/></returns>
        public async Task<DescribeScanIgnoreVulListResponse> DescribeScanIgnoreVulList(DescribeScanIgnoreVulListRequest req)
        {
             JsonResponseModel<DescribeScanIgnoreVulListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScanIgnoreVulList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScanIgnoreVulListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询扫描忽略的漏洞列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScanIgnoreVulListRequest"/></param>
        /// <returns><see cref="DescribeScanIgnoreVulListResponse"/></returns>
        public DescribeScanIgnoreVulListResponse DescribeScanIgnoreVulListSync(DescribeScanIgnoreVulListRequest req)
        {
             JsonResponseModel<DescribeScanIgnoreVulListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScanIgnoreVulList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScanIgnoreVulListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出ES查询文档列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSearchExportListRequest"/></param>
        /// <returns><see cref="DescribeSearchExportListResponse"/></returns>
        public async Task<DescribeSearchExportListResponse> DescribeSearchExportList(DescribeSearchExportListRequest req)
        {
             JsonResponseModel<DescribeSearchExportListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSearchExportList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSearchExportListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 导出ES查询文档列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSearchExportListRequest"/></param>
        /// <returns><see cref="DescribeSearchExportListResponse"/></returns>
        public DescribeSearchExportListResponse DescribeSearchExportListSync(DescribeSearchExportListRequest req)
        {
             JsonResponseModel<DescribeSearchExportListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSearchExportList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSearchExportListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取历史搜索记录
        /// </summary>
        /// <param name="req"><see cref="DescribeSearchLogsRequest"/></param>
        /// <returns><see cref="DescribeSearchLogsResponse"/></returns>
        public async Task<DescribeSearchLogsResponse> DescribeSearchLogs(DescribeSearchLogsRequest req)
        {
             JsonResponseModel<DescribeSearchLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSearchLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSearchLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取历史搜索记录
        /// </summary>
        /// <param name="req"><see cref="DescribeSearchLogsRequest"/></param>
        /// <returns><see cref="DescribeSearchLogsResponse"/></returns>
        public DescribeSearchLogsResponse DescribeSearchLogsSync(DescribeSearchLogsRequest req)
        {
             JsonResponseModel<DescribeSearchLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSearchLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSearchLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取快速检索列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSearchTemplatesRequest"/></param>
        /// <returns><see cref="DescribeSearchTemplatesResponse"/></returns>
        public async Task<DescribeSearchTemplatesResponse> DescribeSearchTemplates(DescribeSearchTemplatesRequest req)
        {
             JsonResponseModel<DescribeSearchTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSearchTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSearchTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取快速检索列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSearchTemplatesRequest"/></param>
        /// <returns><see cref="DescribeSearchTemplatesResponse"/></returns>
        public DescribeSearchTemplatesResponse DescribeSearchTemplatesSync(DescribeSearchTemplatesRequest req)
        {
             JsonResponseModel<DescribeSearchTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSearchTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSearchTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询容器运行时安全事件趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeSecEventsTendencyRequest"/></param>
        /// <returns><see cref="DescribeSecEventsTendencyResponse"/></returns>
        public async Task<DescribeSecEventsTendencyResponse> DescribeSecEventsTendency(DescribeSecEventsTendencyRequest req)
        {
             JsonResponseModel<DescribeSecEventsTendencyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecEventsTendency");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecEventsTendencyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询容器运行时安全事件趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeSecEventsTendencyRequest"/></param>
        /// <returns><see cref="DescribeSecEventsTendencyResponse"/></returns>
        public DescribeSecEventsTendencyResponse DescribeSecEventsTendencySync(DescribeSecEventsTendencyRequest req)
        {
             JsonResponseModel<DescribeSecEventsTendencyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecEventsTendency");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecEventsTendencyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询安全日志告警信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSecLogAlertMsgRequest"/></param>
        /// <returns><see cref="DescribeSecLogAlertMsgResponse"/></returns>
        public async Task<DescribeSecLogAlertMsgResponse> DescribeSecLogAlertMsg(DescribeSecLogAlertMsgRequest req)
        {
             JsonResponseModel<DescribeSecLogAlertMsgResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecLogAlertMsg");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecLogAlertMsgResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询安全日志告警信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSecLogAlertMsgRequest"/></param>
        /// <returns><see cref="DescribeSecLogAlertMsgResponse"/></returns>
        public DescribeSecLogAlertMsgResponse DescribeSecLogAlertMsgSync(DescribeSecLogAlertMsgRequest req)
        {
             JsonResponseModel<DescribeSecLogAlertMsgResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecLogAlertMsg");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecLogAlertMsgResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询安全日志清理设置详情
        /// </summary>
        /// <param name="req"><see cref="DescribeSecLogCleanSettingInfoRequest"/></param>
        /// <returns><see cref="DescribeSecLogCleanSettingInfoResponse"/></returns>
        public async Task<DescribeSecLogCleanSettingInfoResponse> DescribeSecLogCleanSettingInfo(DescribeSecLogCleanSettingInfoRequest req)
        {
             JsonResponseModel<DescribeSecLogCleanSettingInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecLogCleanSettingInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecLogCleanSettingInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询安全日志清理设置详情
        /// </summary>
        /// <param name="req"><see cref="DescribeSecLogCleanSettingInfoRequest"/></param>
        /// <returns><see cref="DescribeSecLogCleanSettingInfoResponse"/></returns>
        public DescribeSecLogCleanSettingInfoResponse DescribeSecLogCleanSettingInfoSync(DescribeSecLogCleanSettingInfoRequest req)
        {
             JsonResponseModel<DescribeSecLogCleanSettingInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecLogCleanSettingInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecLogCleanSettingInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询安全日志投递cls可选项
        /// </summary>
        /// <param name="req"><see cref="DescribeSecLogDeliveryClsOptionsRequest"/></param>
        /// <returns><see cref="DescribeSecLogDeliveryClsOptionsResponse"/></returns>
        public async Task<DescribeSecLogDeliveryClsOptionsResponse> DescribeSecLogDeliveryClsOptions(DescribeSecLogDeliveryClsOptionsRequest req)
        {
             JsonResponseModel<DescribeSecLogDeliveryClsOptionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecLogDeliveryClsOptions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecLogDeliveryClsOptionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询安全日志投递cls可选项
        /// </summary>
        /// <param name="req"><see cref="DescribeSecLogDeliveryClsOptionsRequest"/></param>
        /// <returns><see cref="DescribeSecLogDeliveryClsOptionsResponse"/></returns>
        public DescribeSecLogDeliveryClsOptionsResponse DescribeSecLogDeliveryClsOptionsSync(DescribeSecLogDeliveryClsOptionsRequest req)
        {
             JsonResponseModel<DescribeSecLogDeliveryClsOptionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecLogDeliveryClsOptions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecLogDeliveryClsOptionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询安全日志投递Cls配置
        /// </summary>
        /// <param name="req"><see cref="DescribeSecLogDeliveryClsSettingRequest"/></param>
        /// <returns><see cref="DescribeSecLogDeliveryClsSettingResponse"/></returns>
        public async Task<DescribeSecLogDeliveryClsSettingResponse> DescribeSecLogDeliveryClsSetting(DescribeSecLogDeliveryClsSettingRequest req)
        {
             JsonResponseModel<DescribeSecLogDeliveryClsSettingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecLogDeliveryClsSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecLogDeliveryClsSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询安全日志投递Cls配置
        /// </summary>
        /// <param name="req"><see cref="DescribeSecLogDeliveryClsSettingRequest"/></param>
        /// <returns><see cref="DescribeSecLogDeliveryClsSettingResponse"/></returns>
        public DescribeSecLogDeliveryClsSettingResponse DescribeSecLogDeliveryClsSettingSync(DescribeSecLogDeliveryClsSettingRequest req)
        {
             JsonResponseModel<DescribeSecLogDeliveryClsSettingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecLogDeliveryClsSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecLogDeliveryClsSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询安全日志投递kafka可选项
        /// </summary>
        /// <param name="req"><see cref="DescribeSecLogDeliveryKafkaOptionsRequest"/></param>
        /// <returns><see cref="DescribeSecLogDeliveryKafkaOptionsResponse"/></returns>
        public async Task<DescribeSecLogDeliveryKafkaOptionsResponse> DescribeSecLogDeliveryKafkaOptions(DescribeSecLogDeliveryKafkaOptionsRequest req)
        {
             JsonResponseModel<DescribeSecLogDeliveryKafkaOptionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecLogDeliveryKafkaOptions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecLogDeliveryKafkaOptionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询安全日志投递kafka可选项
        /// </summary>
        /// <param name="req"><see cref="DescribeSecLogDeliveryKafkaOptionsRequest"/></param>
        /// <returns><see cref="DescribeSecLogDeliveryKafkaOptionsResponse"/></returns>
        public DescribeSecLogDeliveryKafkaOptionsResponse DescribeSecLogDeliveryKafkaOptionsSync(DescribeSecLogDeliveryKafkaOptionsRequest req)
        {
             JsonResponseModel<DescribeSecLogDeliveryKafkaOptionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecLogDeliveryKafkaOptions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecLogDeliveryKafkaOptionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询安全日志投递kafka配置
        /// </summary>
        /// <param name="req"><see cref="DescribeSecLogDeliveryKafkaSettingRequest"/></param>
        /// <returns><see cref="DescribeSecLogDeliveryKafkaSettingResponse"/></returns>
        public async Task<DescribeSecLogDeliveryKafkaSettingResponse> DescribeSecLogDeliveryKafkaSetting(DescribeSecLogDeliveryKafkaSettingRequest req)
        {
             JsonResponseModel<DescribeSecLogDeliveryKafkaSettingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecLogDeliveryKafkaSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecLogDeliveryKafkaSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询安全日志投递kafka配置
        /// </summary>
        /// <param name="req"><see cref="DescribeSecLogDeliveryKafkaSettingRequest"/></param>
        /// <returns><see cref="DescribeSecLogDeliveryKafkaSettingResponse"/></returns>
        public DescribeSecLogDeliveryKafkaSettingResponse DescribeSecLogDeliveryKafkaSettingSync(DescribeSecLogDeliveryKafkaSettingRequest req)
        {
             JsonResponseModel<DescribeSecLogDeliveryKafkaSettingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecLogDeliveryKafkaSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecLogDeliveryKafkaSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询安全日志接入对象列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSecLogJoinObjectListRequest"/></param>
        /// <returns><see cref="DescribeSecLogJoinObjectListResponse"/></returns>
        public async Task<DescribeSecLogJoinObjectListResponse> DescribeSecLogJoinObjectList(DescribeSecLogJoinObjectListRequest req)
        {
             JsonResponseModel<DescribeSecLogJoinObjectListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecLogJoinObjectList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecLogJoinObjectListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询安全日志接入对象列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSecLogJoinObjectListRequest"/></param>
        /// <returns><see cref="DescribeSecLogJoinObjectListResponse"/></returns>
        public DescribeSecLogJoinObjectListResponse DescribeSecLogJoinObjectListSync(DescribeSecLogJoinObjectListRequest req)
        {
             JsonResponseModel<DescribeSecLogJoinObjectListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecLogJoinObjectList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecLogJoinObjectListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询安全日志接入列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSecLogJoinTypeListRequest"/></param>
        /// <returns><see cref="DescribeSecLogJoinTypeListResponse"/></returns>
        public async Task<DescribeSecLogJoinTypeListResponse> DescribeSecLogJoinTypeList(DescribeSecLogJoinTypeListRequest req)
        {
             JsonResponseModel<DescribeSecLogJoinTypeListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecLogJoinTypeList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecLogJoinTypeListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询安全日志接入列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSecLogJoinTypeListRequest"/></param>
        /// <returns><see cref="DescribeSecLogJoinTypeListResponse"/></returns>
        public DescribeSecLogJoinTypeListResponse DescribeSecLogJoinTypeListSync(DescribeSecLogJoinTypeListRequest req)
        {
             JsonResponseModel<DescribeSecLogJoinTypeListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecLogJoinTypeList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecLogJoinTypeListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询安全日志KafkaUIN
        /// </summary>
        /// <param name="req"><see cref="DescribeSecLogKafkaUINRequest"/></param>
        /// <returns><see cref="DescribeSecLogKafkaUINResponse"/></returns>
        public async Task<DescribeSecLogKafkaUINResponse> DescribeSecLogKafkaUIN(DescribeSecLogKafkaUINRequest req)
        {
             JsonResponseModel<DescribeSecLogKafkaUINResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecLogKafkaUIN");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecLogKafkaUINResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询安全日志KafkaUIN
        /// </summary>
        /// <param name="req"><see cref="DescribeSecLogKafkaUINRequest"/></param>
        /// <returns><see cref="DescribeSecLogKafkaUINResponse"/></returns>
        public DescribeSecLogKafkaUINResponse DescribeSecLogKafkaUINSync(DescribeSecLogKafkaUINRequest req)
        {
             JsonResponseModel<DescribeSecLogKafkaUINResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecLogKafkaUIN");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecLogKafkaUINResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询安全日志商品信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSecLogVasInfoRequest"/></param>
        /// <returns><see cref="DescribeSecLogVasInfoResponse"/></returns>
        public async Task<DescribeSecLogVasInfoResponse> DescribeSecLogVasInfo(DescribeSecLogVasInfoRequest req)
        {
             JsonResponseModel<DescribeSecLogVasInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecLogVasInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecLogVasInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询安全日志商品信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSecLogVasInfoRequest"/></param>
        /// <returns><see cref="DescribeSecLogVasInfoResponse"/></returns>
        public DescribeSecLogVasInfoResponse DescribeSecLogVasInfoSync(DescribeSecLogVasInfoRequest req)
        {
             JsonResponseModel<DescribeSecLogVasInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecLogVasInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecLogVasInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询支持防御的漏洞列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSupportDefenceVulRequest"/></param>
        /// <returns><see cref="DescribeSupportDefenceVulResponse"/></returns>
        public async Task<DescribeSupportDefenceVulResponse> DescribeSupportDefenceVul(DescribeSupportDefenceVulRequest req)
        {
             JsonResponseModel<DescribeSupportDefenceVulResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSupportDefenceVul");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSupportDefenceVulResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询支持防御的漏洞列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSupportDefenceVulRequest"/></param>
        /// <returns><see cref="DescribeSupportDefenceVulResponse"/></returns>
        public DescribeSupportDefenceVulResponse DescribeSupportDefenceVulSync(DescribeSupportDefenceVulRequest req)
        {
             JsonResponseModel<DescribeSupportDefenceVulResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSupportDefenceVul");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSupportDefenceVulResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询系统漏洞列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSystemVulListRequest"/></param>
        /// <returns><see cref="DescribeSystemVulListResponse"/></returns>
        public async Task<DescribeSystemVulListResponse> DescribeSystemVulList(DescribeSystemVulListRequest req)
        {
             JsonResponseModel<DescribeSystemVulListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSystemVulList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSystemVulListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询系统漏洞列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSystemVulListRequest"/></param>
        /// <returns><see cref="DescribeSystemVulListResponse"/></returns>
        public DescribeSystemVulListResponse DescribeSystemVulListSync(DescribeSystemVulListRequest req)
        {
             JsonResponseModel<DescribeSystemVulListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSystemVulList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSystemVulListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询检查结果总览，返回受影响的节点数量，返回7天的数据，总共7个
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskResultSummaryRequest"/></param>
        /// <returns><see cref="DescribeTaskResultSummaryResponse"/></returns>
        public async Task<DescribeTaskResultSummaryResponse> DescribeTaskResultSummary(DescribeTaskResultSummaryRequest req)
        {
             JsonResponseModel<DescribeTaskResultSummaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskResultSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskResultSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询检查结果总览，返回受影响的节点数量，返回7天的数据，总共7个
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskResultSummaryRequest"/></param>
        /// <returns><see cref="DescribeTaskResultSummaryResponse"/></returns>
        public DescribeTaskResultSummaryResponse DescribeTaskResultSummarySync(DescribeTaskResultSummaryRequest req)
        {
             JsonResponseModel<DescribeTaskResultSummaryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskResultSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskResultSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询容器安全概览信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTcssSummaryRequest"/></param>
        /// <returns><see cref="DescribeTcssSummaryResponse"/></returns>
        public async Task<DescribeTcssSummaryResponse> DescribeTcssSummary(DescribeTcssSummaryRequest req)
        {
             JsonResponseModel<DescribeTcssSummaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTcssSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTcssSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询容器安全概览信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTcssSummaryRequest"/></param>
        /// <returns><see cref="DescribeTcssSummaryResponse"/></returns>
        public DescribeTcssSummaryResponse DescribeTcssSummarySync(DescribeTcssSummaryRequest req)
        {
             JsonResponseModel<DescribeTcssSummaryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTcssSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTcssSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询当天未授权核数趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeUnauthorizedCoresTendencyRequest"/></param>
        /// <returns><see cref="DescribeUnauthorizedCoresTendencyResponse"/></returns>
        public async Task<DescribeUnauthorizedCoresTendencyResponse> DescribeUnauthorizedCoresTendency(DescribeUnauthorizedCoresTendencyRequest req)
        {
             JsonResponseModel<DescribeUnauthorizedCoresTendencyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUnauthorizedCoresTendency");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUnauthorizedCoresTendencyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询当天未授权核数趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeUnauthorizedCoresTendencyRequest"/></param>
        /// <returns><see cref="DescribeUnauthorizedCoresTendencyResponse"/></returns>
        public DescribeUnauthorizedCoresTendencyResponse DescribeUnauthorizedCoresTendencySync(DescribeUnauthorizedCoresTendencyRequest req)
        {
             JsonResponseModel<DescribeUnauthorizedCoresTendencyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUnauthorizedCoresTendency");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUnauthorizedCoresTendencyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询未完成的刷新资产任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUnfinishRefreshTaskRequest"/></param>
        /// <returns><see cref="DescribeUnfinishRefreshTaskResponse"/></returns>
        public async Task<DescribeUnfinishRefreshTaskResponse> DescribeUnfinishRefreshTask(DescribeUnfinishRefreshTaskRequest req)
        {
             JsonResponseModel<DescribeUnfinishRefreshTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUnfinishRefreshTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUnfinishRefreshTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询未完成的刷新资产任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUnfinishRefreshTaskRequest"/></param>
        /// <returns><see cref="DescribeUnfinishRefreshTaskResponse"/></returns>
        public DescribeUnfinishRefreshTaskResponse DescribeUnfinishRefreshTaskSync(DescribeUnfinishRefreshTaskRequest req)
        {
             JsonResponseModel<DescribeUnfinishRefreshTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUnfinishRefreshTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUnfinishRefreshTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 安全概览和集群安全页进入调用该接口，查询用户集群相关信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeUserClusterRequest"/></param>
        /// <returns><see cref="DescribeUserClusterResponse"/></returns>
        public async Task<DescribeUserClusterResponse> DescribeUserCluster(DescribeUserClusterRequest req)
        {
             JsonResponseModel<DescribeUserClusterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 安全概览和集群安全页进入调用该接口，查询用户集群相关信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeUserClusterRequest"/></param>
        /// <returns><see cref="DescribeUserClusterResponse"/></returns>
        public DescribeUserClusterResponse DescribeUserClusterSync(DescribeUserClusterRequest req)
        {
             JsonResponseModel<DescribeUserClusterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserCluster");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserClusterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeValueAddedSrvInfo查询增值服务需购买信息
        /// </summary>
        /// <param name="req"><see cref="DescribeValueAddedSrvInfoRequest"/></param>
        /// <returns><see cref="DescribeValueAddedSrvInfoResponse"/></returns>
        public async Task<DescribeValueAddedSrvInfoResponse> DescribeValueAddedSrvInfo(DescribeValueAddedSrvInfoRequest req)
        {
             JsonResponseModel<DescribeValueAddedSrvInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeValueAddedSrvInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeValueAddedSrvInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeValueAddedSrvInfo查询增值服务需购买信息
        /// </summary>
        /// <param name="req"><see cref="DescribeValueAddedSrvInfoRequest"/></param>
        /// <returns><see cref="DescribeValueAddedSrvInfoResponse"/></returns>
        public DescribeValueAddedSrvInfoResponse DescribeValueAddedSrvInfoSync(DescribeValueAddedSrvInfoRequest req)
        {
             JsonResponseModel<DescribeValueAddedSrvInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeValueAddedSrvInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeValueAddedSrvInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询木马自动隔离样本详情
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusAutoIsolateSampleDetailRequest"/></param>
        /// <returns><see cref="DescribeVirusAutoIsolateSampleDetailResponse"/></returns>
        public async Task<DescribeVirusAutoIsolateSampleDetailResponse> DescribeVirusAutoIsolateSampleDetail(DescribeVirusAutoIsolateSampleDetailRequest req)
        {
             JsonResponseModel<DescribeVirusAutoIsolateSampleDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVirusAutoIsolateSampleDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVirusAutoIsolateSampleDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询木马自动隔离样本详情
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusAutoIsolateSampleDetailRequest"/></param>
        /// <returns><see cref="DescribeVirusAutoIsolateSampleDetailResponse"/></returns>
        public DescribeVirusAutoIsolateSampleDetailResponse DescribeVirusAutoIsolateSampleDetailSync(DescribeVirusAutoIsolateSampleDetailRequest req)
        {
             JsonResponseModel<DescribeVirusAutoIsolateSampleDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVirusAutoIsolateSampleDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVirusAutoIsolateSampleDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询木马自动隔离样本下载链接
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusAutoIsolateSampleDownloadURLRequest"/></param>
        /// <returns><see cref="DescribeVirusAutoIsolateSampleDownloadURLResponse"/></returns>
        public async Task<DescribeVirusAutoIsolateSampleDownloadURLResponse> DescribeVirusAutoIsolateSampleDownloadURL(DescribeVirusAutoIsolateSampleDownloadURLRequest req)
        {
             JsonResponseModel<DescribeVirusAutoIsolateSampleDownloadURLResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVirusAutoIsolateSampleDownloadURL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVirusAutoIsolateSampleDownloadURLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询木马自动隔离样本下载链接
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusAutoIsolateSampleDownloadURLRequest"/></param>
        /// <returns><see cref="DescribeVirusAutoIsolateSampleDownloadURLResponse"/></returns>
        public DescribeVirusAutoIsolateSampleDownloadURLResponse DescribeVirusAutoIsolateSampleDownloadURLSync(DescribeVirusAutoIsolateSampleDownloadURLRequest req)
        {
             JsonResponseModel<DescribeVirusAutoIsolateSampleDownloadURLResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVirusAutoIsolateSampleDownloadURL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVirusAutoIsolateSampleDownloadURLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询木马自动隔离样本列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusAutoIsolateSampleListRequest"/></param>
        /// <returns><see cref="DescribeVirusAutoIsolateSampleListResponse"/></returns>
        public async Task<DescribeVirusAutoIsolateSampleListResponse> DescribeVirusAutoIsolateSampleList(DescribeVirusAutoIsolateSampleListRequest req)
        {
             JsonResponseModel<DescribeVirusAutoIsolateSampleListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVirusAutoIsolateSampleList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVirusAutoIsolateSampleListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询木马自动隔离样本列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusAutoIsolateSampleListRequest"/></param>
        /// <returns><see cref="DescribeVirusAutoIsolateSampleListResponse"/></returns>
        public DescribeVirusAutoIsolateSampleListResponse DescribeVirusAutoIsolateSampleListSync(DescribeVirusAutoIsolateSampleListRequest req)
        {
             JsonResponseModel<DescribeVirusAutoIsolateSampleListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVirusAutoIsolateSampleList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVirusAutoIsolateSampleListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询木马自动隔离设置
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusAutoIsolateSettingRequest"/></param>
        /// <returns><see cref="DescribeVirusAutoIsolateSettingResponse"/></returns>
        public async Task<DescribeVirusAutoIsolateSettingResponse> DescribeVirusAutoIsolateSetting(DescribeVirusAutoIsolateSettingRequest req)
        {
             JsonResponseModel<DescribeVirusAutoIsolateSettingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVirusAutoIsolateSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVirusAutoIsolateSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询木马自动隔离设置
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusAutoIsolateSettingRequest"/></param>
        /// <returns><see cref="DescribeVirusAutoIsolateSettingResponse"/></returns>
        public DescribeVirusAutoIsolateSettingResponse DescribeVirusAutoIsolateSettingSync(DescribeVirusAutoIsolateSettingRequest req)
        {
             JsonResponseModel<DescribeVirusAutoIsolateSettingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVirusAutoIsolateSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVirusAutoIsolateSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运行时查询木马文件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusDetailRequest"/></param>
        /// <returns><see cref="DescribeVirusDetailResponse"/></returns>
        public async Task<DescribeVirusDetailResponse> DescribeVirusDetail(DescribeVirusDetailRequest req)
        {
             JsonResponseModel<DescribeVirusDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVirusDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVirusDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运行时查询木马文件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusDetailRequest"/></param>
        /// <returns><see cref="DescribeVirusDetailResponse"/></returns>
        public DescribeVirusDetailResponse DescribeVirusDetailSync(DescribeVirusDetailRequest req)
        {
             JsonResponseModel<DescribeVirusDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVirusDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVirusDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询木马事件趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusEventTendencyRequest"/></param>
        /// <returns><see cref="DescribeVirusEventTendencyResponse"/></returns>
        public async Task<DescribeVirusEventTendencyResponse> DescribeVirusEventTendency(DescribeVirusEventTendencyRequest req)
        {
             JsonResponseModel<DescribeVirusEventTendencyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVirusEventTendency");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVirusEventTendencyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询木马事件趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusEventTendencyRequest"/></param>
        /// <returns><see cref="DescribeVirusEventTendencyResponse"/></returns>
        public DescribeVirusEventTendencyResponse DescribeVirusEventTendencySync(DescribeVirusEventTendencyRequest req)
        {
             JsonResponseModel<DescribeVirusEventTendencyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVirusEventTendency");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVirusEventTendencyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询运行时文件查杀事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusListRequest"/></param>
        /// <returns><see cref="DescribeVirusListResponse"/></returns>
        public async Task<DescribeVirusListResponse> DescribeVirusList(DescribeVirusListRequest req)
        {
             JsonResponseModel<DescribeVirusListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVirusList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVirusListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询运行时文件查杀事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusListRequest"/></param>
        /// <returns><see cref="DescribeVirusListResponse"/></returns>
        public DescribeVirusListResponse DescribeVirusListSync(DescribeVirusListRequest req)
        {
             JsonResponseModel<DescribeVirusListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVirusList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVirusListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询木马一键检测预估超时时间
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusManualScanEstimateTimeoutRequest"/></param>
        /// <returns><see cref="DescribeVirusManualScanEstimateTimeoutResponse"/></returns>
        public async Task<DescribeVirusManualScanEstimateTimeoutResponse> DescribeVirusManualScanEstimateTimeout(DescribeVirusManualScanEstimateTimeoutRequest req)
        {
             JsonResponseModel<DescribeVirusManualScanEstimateTimeoutResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVirusManualScanEstimateTimeout");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVirusManualScanEstimateTimeoutResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询木马一键检测预估超时时间
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusManualScanEstimateTimeoutRequest"/></param>
        /// <returns><see cref="DescribeVirusManualScanEstimateTimeoutResponse"/></returns>
        public DescribeVirusManualScanEstimateTimeoutResponse DescribeVirusManualScanEstimateTimeoutSync(DescribeVirusManualScanEstimateTimeoutRequest req)
        {
             JsonResponseModel<DescribeVirusManualScanEstimateTimeoutResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVirusManualScanEstimateTimeout");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVirusManualScanEstimateTimeoutResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运行时查询文件查杀实时监控设置
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusMonitorSettingRequest"/></param>
        /// <returns><see cref="DescribeVirusMonitorSettingResponse"/></returns>
        public async Task<DescribeVirusMonitorSettingResponse> DescribeVirusMonitorSetting(DescribeVirusMonitorSettingRequest req)
        {
             JsonResponseModel<DescribeVirusMonitorSettingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVirusMonitorSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVirusMonitorSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运行时查询文件查杀实时监控设置
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusMonitorSettingRequest"/></param>
        /// <returns><see cref="DescribeVirusMonitorSettingResponse"/></returns>
        public DescribeVirusMonitorSettingResponse DescribeVirusMonitorSettingSync(DescribeVirusMonitorSettingRequest req)
        {
             JsonResponseModel<DescribeVirusMonitorSettingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVirusMonitorSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVirusMonitorSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询木马样本下载url
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusSampleDownloadUrlRequest"/></param>
        /// <returns><see cref="DescribeVirusSampleDownloadUrlResponse"/></returns>
        public async Task<DescribeVirusSampleDownloadUrlResponse> DescribeVirusSampleDownloadUrl(DescribeVirusSampleDownloadUrlRequest req)
        {
             JsonResponseModel<DescribeVirusSampleDownloadUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVirusSampleDownloadUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVirusSampleDownloadUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询木马样本下载url
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusSampleDownloadUrlRequest"/></param>
        /// <returns><see cref="DescribeVirusSampleDownloadUrlResponse"/></returns>
        public DescribeVirusSampleDownloadUrlResponse DescribeVirusSampleDownloadUrlSync(DescribeVirusSampleDownloadUrlRequest req)
        {
             JsonResponseModel<DescribeVirusSampleDownloadUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVirusSampleDownloadUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVirusSampleDownloadUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运行时查询文件查杀设置
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusScanSettingRequest"/></param>
        /// <returns><see cref="DescribeVirusScanSettingResponse"/></returns>
        public async Task<DescribeVirusScanSettingResponse> DescribeVirusScanSetting(DescribeVirusScanSettingRequest req)
        {
             JsonResponseModel<DescribeVirusScanSettingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVirusScanSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVirusScanSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运行时查询文件查杀设置
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusScanSettingRequest"/></param>
        /// <returns><see cref="DescribeVirusScanSettingResponse"/></returns>
        public DescribeVirusScanSettingResponse DescribeVirusScanSettingSync(DescribeVirusScanSettingRequest req)
        {
             JsonResponseModel<DescribeVirusScanSettingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVirusScanSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVirusScanSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运行时查询文件查杀任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusScanTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeVirusScanTaskStatusResponse"/></returns>
        public async Task<DescribeVirusScanTaskStatusResponse> DescribeVirusScanTaskStatus(DescribeVirusScanTaskStatusRequest req)
        {
             JsonResponseModel<DescribeVirusScanTaskStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVirusScanTaskStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVirusScanTaskStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运行时查询文件查杀任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusScanTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeVirusScanTaskStatusResponse"/></returns>
        public DescribeVirusScanTaskStatusResponse DescribeVirusScanTaskStatusSync(DescribeVirusScanTaskStatusRequest req)
        {
             JsonResponseModel<DescribeVirusScanTaskStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVirusScanTaskStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVirusScanTaskStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运行时文件扫描超时设置查询
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusScanTimeoutSettingRequest"/></param>
        /// <returns><see cref="DescribeVirusScanTimeoutSettingResponse"/></returns>
        public async Task<DescribeVirusScanTimeoutSettingResponse> DescribeVirusScanTimeoutSetting(DescribeVirusScanTimeoutSettingRequest req)
        {
             JsonResponseModel<DescribeVirusScanTimeoutSettingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVirusScanTimeoutSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVirusScanTimeoutSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运行时文件扫描超时设置查询
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusScanTimeoutSettingRequest"/></param>
        /// <returns><see cref="DescribeVirusScanTimeoutSettingResponse"/></returns>
        public DescribeVirusScanTimeoutSettingResponse DescribeVirusScanTimeoutSettingSync(DescribeVirusScanTimeoutSettingRequest req)
        {
             JsonResponseModel<DescribeVirusScanTimeoutSettingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVirusScanTimeoutSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVirusScanTimeoutSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运行时查询木马概览信息
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusSummaryRequest"/></param>
        /// <returns><see cref="DescribeVirusSummaryResponse"/></returns>
        public async Task<DescribeVirusSummaryResponse> DescribeVirusSummary(DescribeVirusSummaryRequest req)
        {
             JsonResponseModel<DescribeVirusSummaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVirusSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVirusSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运行时查询木马概览信息
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusSummaryRequest"/></param>
        /// <returns><see cref="DescribeVirusSummaryResponse"/></returns>
        public DescribeVirusSummaryResponse DescribeVirusSummarySync(DescribeVirusSummaryRequest req)
        {
             JsonResponseModel<DescribeVirusSummaryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVirusSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVirusSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运行时查询文件查杀任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusTaskListRequest"/></param>
        /// <returns><see cref="DescribeVirusTaskListResponse"/></returns>
        public async Task<DescribeVirusTaskListResponse> DescribeVirusTaskList(DescribeVirusTaskListRequest req)
        {
             JsonResponseModel<DescribeVirusTaskListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVirusTaskList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVirusTaskListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运行时查询文件查杀任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVirusTaskListRequest"/></param>
        /// <returns><see cref="DescribeVirusTaskListResponse"/></returns>
        public DescribeVirusTaskListResponse DescribeVirusTaskListSync(DescribeVirusTaskListRequest req)
        {
             JsonResponseModel<DescribeVirusTaskListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVirusTaskList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVirusTaskListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询受漏洞的容器列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulContainerListRequest"/></param>
        /// <returns><see cref="DescribeVulContainerListResponse"/></returns>
        public async Task<DescribeVulContainerListResponse> DescribeVulContainerList(DescribeVulContainerListRequest req)
        {
             JsonResponseModel<DescribeVulContainerListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulContainerList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulContainerListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询受漏洞的容器列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulContainerListRequest"/></param>
        /// <returns><see cref="DescribeVulContainerListResponse"/></returns>
        public DescribeVulContainerListResponse DescribeVulContainerListSync(DescribeVulContainerListRequest req)
        {
             JsonResponseModel<DescribeVulContainerListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVulContainerList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulContainerListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询漏洞防御事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefenceEventRequest"/></param>
        /// <returns><see cref="DescribeVulDefenceEventResponse"/></returns>
        public async Task<DescribeVulDefenceEventResponse> DescribeVulDefenceEvent(DescribeVulDefenceEventRequest req)
        {
             JsonResponseModel<DescribeVulDefenceEventResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulDefenceEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulDefenceEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询漏洞防御事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefenceEventRequest"/></param>
        /// <returns><see cref="DescribeVulDefenceEventResponse"/></returns>
        public DescribeVulDefenceEventResponse DescribeVulDefenceEventSync(DescribeVulDefenceEventRequest req)
        {
             JsonResponseModel<DescribeVulDefenceEventResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVulDefenceEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulDefenceEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询漏洞防御事件详情
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefenceEventDetailRequest"/></param>
        /// <returns><see cref="DescribeVulDefenceEventDetailResponse"/></returns>
        public async Task<DescribeVulDefenceEventDetailResponse> DescribeVulDefenceEventDetail(DescribeVulDefenceEventDetailRequest req)
        {
             JsonResponseModel<DescribeVulDefenceEventDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulDefenceEventDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulDefenceEventDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询漏洞防御事件详情
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefenceEventDetailRequest"/></param>
        /// <returns><see cref="DescribeVulDefenceEventDetailResponse"/></returns>
        public DescribeVulDefenceEventDetailResponse DescribeVulDefenceEventDetailSync(DescribeVulDefenceEventDetailRequest req)
        {
             JsonResponseModel<DescribeVulDefenceEventDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVulDefenceEventDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulDefenceEventDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询漏洞防御攻击事件趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefenceEventTendencyRequest"/></param>
        /// <returns><see cref="DescribeVulDefenceEventTendencyResponse"/></returns>
        public async Task<DescribeVulDefenceEventTendencyResponse> DescribeVulDefenceEventTendency(DescribeVulDefenceEventTendencyRequest req)
        {
             JsonResponseModel<DescribeVulDefenceEventTendencyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulDefenceEventTendency");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulDefenceEventTendencyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询漏洞防御攻击事件趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefenceEventTendencyRequest"/></param>
        /// <returns><see cref="DescribeVulDefenceEventTendencyResponse"/></returns>
        public DescribeVulDefenceEventTendencyResponse DescribeVulDefenceEventTendencySync(DescribeVulDefenceEventTendencyRequest req)
        {
             JsonResponseModel<DescribeVulDefenceEventTendencyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVulDefenceEventTendency");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulDefenceEventTendencyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询漏洞防御的主机列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefenceHostRequest"/></param>
        /// <returns><see cref="DescribeVulDefenceHostResponse"/></returns>
        public async Task<DescribeVulDefenceHostResponse> DescribeVulDefenceHost(DescribeVulDefenceHostRequest req)
        {
             JsonResponseModel<DescribeVulDefenceHostResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulDefenceHost");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulDefenceHostResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询漏洞防御的主机列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefenceHostRequest"/></param>
        /// <returns><see cref="DescribeVulDefenceHostResponse"/></returns>
        public DescribeVulDefenceHostResponse DescribeVulDefenceHostSync(DescribeVulDefenceHostRequest req)
        {
             JsonResponseModel<DescribeVulDefenceHostResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVulDefenceHost");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulDefenceHostResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询漏洞防御插件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefencePluginRequest"/></param>
        /// <returns><see cref="DescribeVulDefencePluginResponse"/></returns>
        public async Task<DescribeVulDefencePluginResponse> DescribeVulDefencePlugin(DescribeVulDefencePluginRequest req)
        {
             JsonResponseModel<DescribeVulDefencePluginResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulDefencePlugin");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulDefencePluginResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询漏洞防御插件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefencePluginRequest"/></param>
        /// <returns><see cref="DescribeVulDefencePluginResponse"/></returns>
        public DescribeVulDefencePluginResponse DescribeVulDefencePluginSync(DescribeVulDefencePluginRequest req)
        {
             JsonResponseModel<DescribeVulDefencePluginResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVulDefencePlugin");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulDefencePluginResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询漏洞防御设置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefenceSettingRequest"/></param>
        /// <returns><see cref="DescribeVulDefenceSettingResponse"/></returns>
        public async Task<DescribeVulDefenceSettingResponse> DescribeVulDefenceSetting(DescribeVulDefenceSettingRequest req)
        {
             JsonResponseModel<DescribeVulDefenceSettingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulDefenceSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulDefenceSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询漏洞防御设置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDefenceSettingRequest"/></param>
        /// <returns><see cref="DescribeVulDefenceSettingResponse"/></returns>
        public DescribeVulDefenceSettingResponse DescribeVulDefenceSettingSync(DescribeVulDefenceSettingRequest req)
        {
             JsonResponseModel<DescribeVulDefenceSettingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVulDefenceSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulDefenceSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询漏洞详情
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDetailRequest"/></param>
        /// <returns><see cref="DescribeVulDetailResponse"/></returns>
        public async Task<DescribeVulDetailResponse> DescribeVulDetail(DescribeVulDetailRequest req)
        {
             JsonResponseModel<DescribeVulDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询漏洞详情
        /// </summary>
        /// <param name="req"><see cref="DescribeVulDetailRequest"/></param>
        /// <returns><see cref="DescribeVulDetailResponse"/></returns>
        public DescribeVulDetailResponse DescribeVulDetailSync(DescribeVulDetailRequest req)
        {
             JsonResponseModel<DescribeVulDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVulDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询漏洞扫描忽略的本地镜像列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulIgnoreLocalImageListRequest"/></param>
        /// <returns><see cref="DescribeVulIgnoreLocalImageListResponse"/></returns>
        public async Task<DescribeVulIgnoreLocalImageListResponse> DescribeVulIgnoreLocalImageList(DescribeVulIgnoreLocalImageListRequest req)
        {
             JsonResponseModel<DescribeVulIgnoreLocalImageListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulIgnoreLocalImageList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulIgnoreLocalImageListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询漏洞扫描忽略的本地镜像列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulIgnoreLocalImageListRequest"/></param>
        /// <returns><see cref="DescribeVulIgnoreLocalImageListResponse"/></returns>
        public DescribeVulIgnoreLocalImageListResponse DescribeVulIgnoreLocalImageListSync(DescribeVulIgnoreLocalImageListRequest req)
        {
             JsonResponseModel<DescribeVulIgnoreLocalImageListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVulIgnoreLocalImageList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulIgnoreLocalImageListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询漏洞扫描忽略的仓库镜像列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulIgnoreRegistryImageListRequest"/></param>
        /// <returns><see cref="DescribeVulIgnoreRegistryImageListResponse"/></returns>
        public async Task<DescribeVulIgnoreRegistryImageListResponse> DescribeVulIgnoreRegistryImageList(DescribeVulIgnoreRegistryImageListRequest req)
        {
             JsonResponseModel<DescribeVulIgnoreRegistryImageListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulIgnoreRegistryImageList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulIgnoreRegistryImageListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询漏洞扫描忽略的仓库镜像列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulIgnoreRegistryImageListRequest"/></param>
        /// <returns><see cref="DescribeVulIgnoreRegistryImageListResponse"/></returns>
        public DescribeVulIgnoreRegistryImageListResponse DescribeVulIgnoreRegistryImageListSync(DescribeVulIgnoreRegistryImageListRequest req)
        {
             JsonResponseModel<DescribeVulIgnoreRegistryImageListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVulIgnoreRegistryImageList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulIgnoreRegistryImageListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询漏洞影响的镜像列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulImageListRequest"/></param>
        /// <returns><see cref="DescribeVulImageListResponse"/></returns>
        public async Task<DescribeVulImageListResponse> DescribeVulImageList(DescribeVulImageListRequest req)
        {
             JsonResponseModel<DescribeVulImageListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulImageList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulImageListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询漏洞影响的镜像列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulImageListRequest"/></param>
        /// <returns><see cref="DescribeVulImageListResponse"/></returns>
        public DescribeVulImageListResponse DescribeVulImageListSync(DescribeVulImageListRequest req)
        {
             JsonResponseModel<DescribeVulImageListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVulImageList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulImageListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询漏洞镜像统计
        /// </summary>
        /// <param name="req"><see cref="DescribeVulImageSummaryRequest"/></param>
        /// <returns><see cref="DescribeVulImageSummaryResponse"/></returns>
        public async Task<DescribeVulImageSummaryResponse> DescribeVulImageSummary(DescribeVulImageSummaryRequest req)
        {
             JsonResponseModel<DescribeVulImageSummaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulImageSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulImageSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询漏洞镜像统计
        /// </summary>
        /// <param name="req"><see cref="DescribeVulImageSummaryRequest"/></param>
        /// <returns><see cref="DescribeVulImageSummaryResponse"/></returns>
        public DescribeVulImageSummaryResponse DescribeVulImageSummarySync(DescribeVulImageSummaryRequest req)
        {
             JsonResponseModel<DescribeVulImageSummaryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVulImageSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulImageSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询应急漏洞各威胁等级统计镜像数
        /// </summary>
        /// <param name="req"><see cref="DescribeVulLevelImageSummaryRequest"/></param>
        /// <returns><see cref="DescribeVulLevelImageSummaryResponse"/></returns>
        public async Task<DescribeVulLevelImageSummaryResponse> DescribeVulLevelImageSummary(DescribeVulLevelImageSummaryRequest req)
        {
             JsonResponseModel<DescribeVulLevelImageSummaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulLevelImageSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulLevelImageSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询应急漏洞各威胁等级统计镜像数
        /// </summary>
        /// <param name="req"><see cref="DescribeVulLevelImageSummaryRequest"/></param>
        /// <returns><see cref="DescribeVulLevelImageSummaryResponse"/></returns>
        public DescribeVulLevelImageSummaryResponse DescribeVulLevelImageSummarySync(DescribeVulLevelImageSummaryRequest req)
        {
             JsonResponseModel<DescribeVulLevelImageSummaryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVulLevelImageSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulLevelImageSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询漏洞各威胁等级统计数
        /// </summary>
        /// <param name="req"><see cref="DescribeVulLevelSummaryRequest"/></param>
        /// <returns><see cref="DescribeVulLevelSummaryResponse"/></returns>
        public async Task<DescribeVulLevelSummaryResponse> DescribeVulLevelSummary(DescribeVulLevelSummaryRequest req)
        {
             JsonResponseModel<DescribeVulLevelSummaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulLevelSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulLevelSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询漏洞各威胁等级统计数
        /// </summary>
        /// <param name="req"><see cref="DescribeVulLevelSummaryRequest"/></param>
        /// <returns><see cref="DescribeVulLevelSummaryResponse"/></returns>
        public DescribeVulLevelSummaryResponse DescribeVulLevelSummarySync(DescribeVulLevelSummaryRequest req)
        {
             JsonResponseModel<DescribeVulLevelSummaryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVulLevelSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulLevelSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 统计漏洞扫描页已授权和未扫描镜像数
        /// </summary>
        /// <param name="req"><see cref="DescribeVulScanAuthorizedImageSummaryRequest"/></param>
        /// <returns><see cref="DescribeVulScanAuthorizedImageSummaryResponse"/></returns>
        public async Task<DescribeVulScanAuthorizedImageSummaryResponse> DescribeVulScanAuthorizedImageSummary(DescribeVulScanAuthorizedImageSummaryRequest req)
        {
             JsonResponseModel<DescribeVulScanAuthorizedImageSummaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulScanAuthorizedImageSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulScanAuthorizedImageSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 统计漏洞扫描页已授权和未扫描镜像数
        /// </summary>
        /// <param name="req"><see cref="DescribeVulScanAuthorizedImageSummaryRequest"/></param>
        /// <returns><see cref="DescribeVulScanAuthorizedImageSummaryResponse"/></returns>
        public DescribeVulScanAuthorizedImageSummaryResponse DescribeVulScanAuthorizedImageSummarySync(DescribeVulScanAuthorizedImageSummaryRequest req)
        {
             JsonResponseModel<DescribeVulScanAuthorizedImageSummaryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVulScanAuthorizedImageSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulScanAuthorizedImageSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询漏洞扫描任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeVulScanInfoRequest"/></param>
        /// <returns><see cref="DescribeVulScanInfoResponse"/></returns>
        public async Task<DescribeVulScanInfoResponse> DescribeVulScanInfo(DescribeVulScanInfoRequest req)
        {
             JsonResponseModel<DescribeVulScanInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulScanInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulScanInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询漏洞扫描任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeVulScanInfoRequest"/></param>
        /// <returns><see cref="DescribeVulScanInfoResponse"/></returns>
        public DescribeVulScanInfoResponse DescribeVulScanInfoSync(DescribeVulScanInfoRequest req)
        {
             JsonResponseModel<DescribeVulScanInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVulScanInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulScanInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询漏洞扫描任务的本地镜像列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulScanLocalImageListRequest"/></param>
        /// <returns><see cref="DescribeVulScanLocalImageListResponse"/></returns>
        public async Task<DescribeVulScanLocalImageListResponse> DescribeVulScanLocalImageList(DescribeVulScanLocalImageListRequest req)
        {
             JsonResponseModel<DescribeVulScanLocalImageListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulScanLocalImageList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulScanLocalImageListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询漏洞扫描任务的本地镜像列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulScanLocalImageListRequest"/></param>
        /// <returns><see cref="DescribeVulScanLocalImageListResponse"/></returns>
        public DescribeVulScanLocalImageListResponse DescribeVulScanLocalImageListSync(DescribeVulScanLocalImageListRequest req)
        {
             JsonResponseModel<DescribeVulScanLocalImageListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVulScanLocalImageList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulScanLocalImageListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询漏洞风险统计概览
        /// </summary>
        /// <param name="req"><see cref="DescribeVulSummaryRequest"/></param>
        /// <returns><see cref="DescribeVulSummaryResponse"/></returns>
        public async Task<DescribeVulSummaryResponse> DescribeVulSummary(DescribeVulSummaryRequest req)
        {
             JsonResponseModel<DescribeVulSummaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询漏洞风险统计概览
        /// </summary>
        /// <param name="req"><see cref="DescribeVulSummaryRequest"/></param>
        /// <returns><see cref="DescribeVulSummaryResponse"/></returns>
        public DescribeVulSummaryResponse DescribeVulSummarySync(DescribeVulSummaryRequest req)
        {
             JsonResponseModel<DescribeVulSummaryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVulSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询本地镜像、仓库镜像中严重&高危的漏洞趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeVulTendencyRequest"/></param>
        /// <returns><see cref="DescribeVulTendencyResponse"/></returns>
        public async Task<DescribeVulTendencyResponse> DescribeVulTendency(DescribeVulTendencyRequest req)
        {
             JsonResponseModel<DescribeVulTendencyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulTendency");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulTendencyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询本地镜像、仓库镜像中严重&高危的漏洞趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeVulTendencyRequest"/></param>
        /// <returns><see cref="DescribeVulTendencyResponse"/></returns>
        public DescribeVulTendencyResponse DescribeVulTendencySync(DescribeVulTendencyRequest req)
        {
             JsonResponseModel<DescribeVulTendencyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVulTendency");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulTendencyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询漏洞Top排名列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulTopRankingRequest"/></param>
        /// <returns><see cref="DescribeVulTopRankingResponse"/></returns>
        public async Task<DescribeVulTopRankingResponse> DescribeVulTopRanking(DescribeVulTopRankingRequest req)
        {
             JsonResponseModel<DescribeVulTopRankingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVulTopRanking");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulTopRankingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询漏洞Top排名列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulTopRankingRequest"/></param>
        /// <returns><see cref="DescribeVulTopRankingResponse"/></returns>
        public DescribeVulTopRankingResponse DescribeVulTopRankingSync(DescribeVulTopRankingRequest req)
        {
             JsonResponseModel<DescribeVulTopRankingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVulTopRanking");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVulTopRankingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取告警策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWarningRulesRequest"/></param>
        /// <returns><see cref="DescribeWarningRulesResponse"/></returns>
        public async Task<DescribeWarningRulesResponse> DescribeWarningRules(DescribeWarningRulesRequest req)
        {
             JsonResponseModel<DescribeWarningRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWarningRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWarningRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取告警策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWarningRulesRequest"/></param>
        /// <returns><see cref="DescribeWarningRulesResponse"/></returns>
        public DescribeWarningRulesResponse DescribeWarningRulesSync(DescribeWarningRulesRequest req)
        {
             JsonResponseModel<DescribeWarningRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWarningRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWarningRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询web应用漏洞列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWebVulListRequest"/></param>
        /// <returns><see cref="DescribeWebVulListResponse"/></returns>
        public async Task<DescribeWebVulListResponse> DescribeWebVulList(DescribeWebVulListRequest req)
        {
             JsonResponseModel<DescribeWebVulListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWebVulList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebVulListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询web应用漏洞列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWebVulListRequest"/></param>
        /// <returns><see cref="DescribeWebVulListResponse"/></returns>
        public DescribeWebVulListResponse DescribeWebVulListSync(DescribeWebVulListRequest req)
        {
             JsonResponseModel<DescribeWebVulListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWebVulList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWebVulListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运行时文件查杀事件列表导出
        /// </summary>
        /// <param name="req"><see cref="ExportVirusListRequest"/></param>
        /// <returns><see cref="ExportVirusListResponse"/></returns>
        public async Task<ExportVirusListResponse> ExportVirusList(ExportVirusListRequest req)
        {
             JsonResponseModel<ExportVirusListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportVirusList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportVirusListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运行时文件查杀事件列表导出
        /// </summary>
        /// <param name="req"><see cref="ExportVirusListRequest"/></param>
        /// <returns><see cref="ExportVirusListResponse"/></returns>
        public ExportVirusListResponse ExportVirusListSync(ExportVirusListRequest req)
        {
             JsonResponseModel<ExportVirusListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportVirusList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportVirusListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 为客户初始化合规基线的使用环境，创建必要的数据和选项。
        /// </summary>
        /// <param name="req"><see cref="InitializeUserComplianceEnvironmentRequest"/></param>
        /// <returns><see cref="InitializeUserComplianceEnvironmentResponse"/></returns>
        public async Task<InitializeUserComplianceEnvironmentResponse> InitializeUserComplianceEnvironment(InitializeUserComplianceEnvironmentRequest req)
        {
             JsonResponseModel<InitializeUserComplianceEnvironmentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InitializeUserComplianceEnvironment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InitializeUserComplianceEnvironmentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 为客户初始化合规基线的使用环境，创建必要的数据和选项。
        /// </summary>
        /// <param name="req"><see cref="InitializeUserComplianceEnvironmentRequest"/></param>
        /// <returns><see cref="InitializeUserComplianceEnvironmentResponse"/></returns>
        public InitializeUserComplianceEnvironmentResponse InitializeUserComplianceEnvironmentSync(InitializeUserComplianceEnvironmentRequest req)
        {
             JsonResponseModel<InitializeUserComplianceEnvironmentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InitializeUserComplianceEnvironment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InitializeUserComplianceEnvironmentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改运行时异常进程策略的开启关闭状态
        /// </summary>
        /// <param name="req"><see cref="ModifyAbnormalProcessRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyAbnormalProcessRuleStatusResponse"/></returns>
        public async Task<ModifyAbnormalProcessRuleStatusResponse> ModifyAbnormalProcessRuleStatus(ModifyAbnormalProcessRuleStatusRequest req)
        {
             JsonResponseModel<ModifyAbnormalProcessRuleStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAbnormalProcessRuleStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAbnormalProcessRuleStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改运行时异常进程策略的开启关闭状态
        /// </summary>
        /// <param name="req"><see cref="ModifyAbnormalProcessRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyAbnormalProcessRuleStatusResponse"/></returns>
        public ModifyAbnormalProcessRuleStatusResponse ModifyAbnormalProcessRuleStatusSync(ModifyAbnormalProcessRuleStatusRequest req)
        {
             JsonResponseModel<ModifyAbnormalProcessRuleStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAbnormalProcessRuleStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAbnormalProcessRuleStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改异常进程事件的状态信息
        /// </summary>
        /// <param name="req"><see cref="ModifyAbnormalProcessStatusRequest"/></param>
        /// <returns><see cref="ModifyAbnormalProcessStatusResponse"/></returns>
        public async Task<ModifyAbnormalProcessStatusResponse> ModifyAbnormalProcessStatus(ModifyAbnormalProcessStatusRequest req)
        {
             JsonResponseModel<ModifyAbnormalProcessStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAbnormalProcessStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAbnormalProcessStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改异常进程事件的状态信息
        /// </summary>
        /// <param name="req"><see cref="ModifyAbnormalProcessStatusRequest"/></param>
        /// <returns><see cref="ModifyAbnormalProcessStatusResponse"/></returns>
        public ModifyAbnormalProcessStatusResponse ModifyAbnormalProcessStatusSync(ModifyAbnormalProcessStatusRequest req)
        {
             JsonResponseModel<ModifyAbnormalProcessStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAbnormalProcessStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAbnormalProcessStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改运行时访问控制策略的状态，启用或者禁用
        /// </summary>
        /// <param name="req"><see cref="ModifyAccessControlRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyAccessControlRuleStatusResponse"/></returns>
        public async Task<ModifyAccessControlRuleStatusResponse> ModifyAccessControlRuleStatus(ModifyAccessControlRuleStatusRequest req)
        {
             JsonResponseModel<ModifyAccessControlRuleStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAccessControlRuleStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccessControlRuleStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改运行时访问控制策略的状态，启用或者禁用
        /// </summary>
        /// <param name="req"><see cref="ModifyAccessControlRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyAccessControlRuleStatusResponse"/></returns>
        public ModifyAccessControlRuleStatusResponse ModifyAccessControlRuleStatusSync(ModifyAccessControlRuleStatusRequest req)
        {
             JsonResponseModel<ModifyAccessControlRuleStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAccessControlRuleStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccessControlRuleStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改运行时访问控制事件状态信息
        /// </summary>
        /// <param name="req"><see cref="ModifyAccessControlStatusRequest"/></param>
        /// <returns><see cref="ModifyAccessControlStatusResponse"/></returns>
        public async Task<ModifyAccessControlStatusResponse> ModifyAccessControlStatus(ModifyAccessControlStatusRequest req)
        {
             JsonResponseModel<ModifyAccessControlStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAccessControlStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccessControlStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改运行时访问控制事件状态信息
        /// </summary>
        /// <param name="req"><see cref="ModifyAccessControlStatusRequest"/></param>
        /// <returns><see cref="ModifyAccessControlStatusResponse"/></returns>
        public ModifyAccessControlStatusResponse ModifyAccessControlStatusSync(ModifyAccessControlStatusRequest req)
        {
             JsonResponseModel<ModifyAccessControlStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAccessControlStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccessControlStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器安全主机资产刷新
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetRequest"/></param>
        /// <returns><see cref="ModifyAssetResponse"/></returns>
        public async Task<ModifyAssetResponse> ModifyAsset(ModifyAssetRequest req)
        {
             JsonResponseModel<ModifyAssetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAsset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAssetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器安全主机资产刷新
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetRequest"/></param>
        /// <returns><see cref="ModifyAssetResponse"/></returns>
        public ModifyAssetResponse ModifyAssetSync(ModifyAssetRequest req)
        {
             JsonResponseModel<ModifyAssetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAsset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAssetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 镜像仓库停止镜像扫描任务
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetImageRegistryScanStopRequest"/></param>
        /// <returns><see cref="ModifyAssetImageRegistryScanStopResponse"/></returns>
        public async Task<ModifyAssetImageRegistryScanStopResponse> ModifyAssetImageRegistryScanStop(ModifyAssetImageRegistryScanStopRequest req)
        {
             JsonResponseModel<ModifyAssetImageRegistryScanStopResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAssetImageRegistryScanStop");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAssetImageRegistryScanStopResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 镜像仓库停止镜像扫描任务
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetImageRegistryScanStopRequest"/></param>
        /// <returns><see cref="ModifyAssetImageRegistryScanStopResponse"/></returns>
        public ModifyAssetImageRegistryScanStopResponse ModifyAssetImageRegistryScanStopSync(ModifyAssetImageRegistryScanStopRequest req)
        {
             JsonResponseModel<ModifyAssetImageRegistryScanStopResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAssetImageRegistryScanStop");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAssetImageRegistryScanStopResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 镜像仓库停止镜像一键扫描任务
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetImageRegistryScanStopOneKeyRequest"/></param>
        /// <returns><see cref="ModifyAssetImageRegistryScanStopOneKeyResponse"/></returns>
        public async Task<ModifyAssetImageRegistryScanStopOneKeyResponse> ModifyAssetImageRegistryScanStopOneKey(ModifyAssetImageRegistryScanStopOneKeyRequest req)
        {
             JsonResponseModel<ModifyAssetImageRegistryScanStopOneKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAssetImageRegistryScanStopOneKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAssetImageRegistryScanStopOneKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 镜像仓库停止镜像一键扫描任务
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetImageRegistryScanStopOneKeyRequest"/></param>
        /// <returns><see cref="ModifyAssetImageRegistryScanStopOneKeyResponse"/></returns>
        public ModifyAssetImageRegistryScanStopOneKeyResponse ModifyAssetImageRegistryScanStopOneKeySync(ModifyAssetImageRegistryScanStopOneKeyRequest req)
        {
             JsonResponseModel<ModifyAssetImageRegistryScanStopOneKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAssetImageRegistryScanStopOneKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAssetImageRegistryScanStopOneKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器安全停止镜像扫描
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetImageScanStopRequest"/></param>
        /// <returns><see cref="ModifyAssetImageScanStopResponse"/></returns>
        public async Task<ModifyAssetImageScanStopResponse> ModifyAssetImageScanStop(ModifyAssetImageScanStopRequest req)
        {
             JsonResponseModel<ModifyAssetImageScanStopResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAssetImageScanStop");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAssetImageScanStopResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器安全停止镜像扫描
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetImageScanStopRequest"/></param>
        /// <returns><see cref="ModifyAssetImageScanStopResponse"/></returns>
        public ModifyAssetImageScanStopResponse ModifyAssetImageScanStopSync(ModifyAssetImageScanStopRequest req)
        {
             JsonResponseModel<ModifyAssetImageScanStopResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAssetImageScanStop");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAssetImageScanStopResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改定时任务的设置，包括检测周期、开启/禁用合规基准。
        /// </summary>
        /// <param name="req"><see cref="ModifyCompliancePeriodTaskRequest"/></param>
        /// <returns><see cref="ModifyCompliancePeriodTaskResponse"/></returns>
        public async Task<ModifyCompliancePeriodTaskResponse> ModifyCompliancePeriodTask(ModifyCompliancePeriodTaskRequest req)
        {
             JsonResponseModel<ModifyCompliancePeriodTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCompliancePeriodTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCompliancePeriodTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改定时任务的设置，包括检测周期、开启/禁用合规基准。
        /// </summary>
        /// <param name="req"><see cref="ModifyCompliancePeriodTaskRequest"/></param>
        /// <returns><see cref="ModifyCompliancePeriodTaskResponse"/></returns>
        public ModifyCompliancePeriodTaskResponse ModifyCompliancePeriodTaskSync(ModifyCompliancePeriodTaskRequest req)
        {
             JsonResponseModel<ModifyCompliancePeriodTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCompliancePeriodTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCompliancePeriodTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 隔离容器网络状态
        /// </summary>
        /// <param name="req"><see cref="ModifyContainerNetStatusRequest"/></param>
        /// <returns><see cref="ModifyContainerNetStatusResponse"/></returns>
        public async Task<ModifyContainerNetStatusResponse> ModifyContainerNetStatus(ModifyContainerNetStatusRequest req)
        {
             JsonResponseModel<ModifyContainerNetStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyContainerNetStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyContainerNetStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 隔离容器网络状态
        /// </summary>
        /// <param name="req"><see cref="ModifyContainerNetStatusRequest"/></param>
        /// <returns><see cref="ModifyContainerNetStatusResponse"/></returns>
        public ModifyContainerNetStatusResponse ModifyContainerNetStatusSync(ModifyContainerNetStatusRequest req)
        {
             JsonResponseModel<ModifyContainerNetStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyContainerNetStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyContainerNetStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyEscapeEventStatus  修改容器逃逸扫描事件状态
        /// </summary>
        /// <param name="req"><see cref="ModifyEscapeEventStatusRequest"/></param>
        /// <returns><see cref="ModifyEscapeEventStatusResponse"/></returns>
        public async Task<ModifyEscapeEventStatusResponse> ModifyEscapeEventStatus(ModifyEscapeEventStatusRequest req)
        {
             JsonResponseModel<ModifyEscapeEventStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyEscapeEventStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEscapeEventStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyEscapeEventStatus  修改容器逃逸扫描事件状态
        /// </summary>
        /// <param name="req"><see cref="ModifyEscapeEventStatusRequest"/></param>
        /// <returns><see cref="ModifyEscapeEventStatusResponse"/></returns>
        public ModifyEscapeEventStatusResponse ModifyEscapeEventStatusSync(ModifyEscapeEventStatusRequest req)
        {
             JsonResponseModel<ModifyEscapeEventStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyEscapeEventStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEscapeEventStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyEscapeRule  修改容器逃逸扫描规则信息
        /// </summary>
        /// <param name="req"><see cref="ModifyEscapeRuleRequest"/></param>
        /// <returns><see cref="ModifyEscapeRuleResponse"/></returns>
        public async Task<ModifyEscapeRuleResponse> ModifyEscapeRule(ModifyEscapeRuleRequest req)
        {
             JsonResponseModel<ModifyEscapeRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyEscapeRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEscapeRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyEscapeRule  修改容器逃逸扫描规则信息
        /// </summary>
        /// <param name="req"><see cref="ModifyEscapeRuleRequest"/></param>
        /// <returns><see cref="ModifyEscapeRuleResponse"/></returns>
        public ModifyEscapeRuleResponse ModifyEscapeRuleSync(ModifyEscapeRuleRequest req)
        {
             JsonResponseModel<ModifyEscapeRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyEscapeRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEscapeRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改逃逸白名单
        /// </summary>
        /// <param name="req"><see cref="ModifyEscapeWhiteListRequest"/></param>
        /// <returns><see cref="ModifyEscapeWhiteListResponse"/></returns>
        public async Task<ModifyEscapeWhiteListResponse> ModifyEscapeWhiteList(ModifyEscapeWhiteListRequest req)
        {
             JsonResponseModel<ModifyEscapeWhiteListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyEscapeWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEscapeWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改逃逸白名单
        /// </summary>
        /// <param name="req"><see cref="ModifyEscapeWhiteListRequest"/></param>
        /// <returns><see cref="ModifyEscapeWhiteListResponse"/></returns>
        public ModifyEscapeWhiteListResponse ModifyEscapeWhiteListSync(ModifyEscapeWhiteListRequest req)
        {
             JsonResponseModel<ModifyEscapeWhiteListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyEscapeWhiteList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEscapeWhiteListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量授权镜像扫描V2.0
        /// </summary>
        /// <param name="req"><see cref="ModifyImageAuthorizedRequest"/></param>
        /// <returns><see cref="ModifyImageAuthorizedResponse"/></returns>
        public async Task<ModifyImageAuthorizedResponse> ModifyImageAuthorized(ModifyImageAuthorizedRequest req)
        {
             JsonResponseModel<ModifyImageAuthorizedResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyImageAuthorized");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyImageAuthorizedResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量授权镜像扫描V2.0
        /// </summary>
        /// <param name="req"><see cref="ModifyImageAuthorizedRequest"/></param>
        /// <returns><see cref="ModifyImageAuthorizedResponse"/></returns>
        public ModifyImageAuthorizedResponse ModifyImageAuthorizedSync(ModifyImageAuthorizedRequest req)
        {
             JsonResponseModel<ModifyImageAuthorizedResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyImageAuthorized");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyImageAuthorizedResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改反弹shell事件的状态信息
        /// </summary>
        /// <param name="req"><see cref="ModifyReverseShellStatusRequest"/></param>
        /// <returns><see cref="ModifyReverseShellStatusResponse"/></returns>
        public async Task<ModifyReverseShellStatusResponse> ModifyReverseShellStatus(ModifyReverseShellStatusRequest req)
        {
             JsonResponseModel<ModifyReverseShellStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyReverseShellStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyReverseShellStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改反弹shell事件的状态信息
        /// </summary>
        /// <param name="req"><see cref="ModifyReverseShellStatusRequest"/></param>
        /// <returns><see cref="ModifyReverseShellStatusResponse"/></returns>
        public ModifyReverseShellStatusResponse ModifyReverseShellStatusSync(ModifyReverseShellStatusRequest req)
        {
             JsonResponseModel<ModifyReverseShellStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyReverseShellStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyReverseShellStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改高危系统调用事件的状态信息
        /// </summary>
        /// <param name="req"><see cref="ModifyRiskSyscallStatusRequest"/></param>
        /// <returns><see cref="ModifyRiskSyscallStatusResponse"/></returns>
        public async Task<ModifyRiskSyscallStatusResponse> ModifyRiskSyscallStatus(ModifyRiskSyscallStatusRequest req)
        {
             JsonResponseModel<ModifyRiskSyscallStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRiskSyscallStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRiskSyscallStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改高危系统调用事件的状态信息
        /// </summary>
        /// <param name="req"><see cref="ModifyRiskSyscallStatusRequest"/></param>
        /// <returns><see cref="ModifyRiskSyscallStatusResponse"/></returns>
        public ModifyRiskSyscallStatusResponse ModifyRiskSyscallStatusSync(ModifyRiskSyscallStatusRequest req)
        {
             JsonResponseModel<ModifyRiskSyscallStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRiskSyscallStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRiskSyscallStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改安全日志清理设置信息
        /// </summary>
        /// <param name="req"><see cref="ModifySecLogCleanSettingInfoRequest"/></param>
        /// <returns><see cref="ModifySecLogCleanSettingInfoResponse"/></returns>
        public async Task<ModifySecLogCleanSettingInfoResponse> ModifySecLogCleanSettingInfo(ModifySecLogCleanSettingInfoRequest req)
        {
             JsonResponseModel<ModifySecLogCleanSettingInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySecLogCleanSettingInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecLogCleanSettingInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改安全日志清理设置信息
        /// </summary>
        /// <param name="req"><see cref="ModifySecLogCleanSettingInfoRequest"/></param>
        /// <returns><see cref="ModifySecLogCleanSettingInfoResponse"/></returns>
        public ModifySecLogCleanSettingInfoResponse ModifySecLogCleanSettingInfoSync(ModifySecLogCleanSettingInfoRequest req)
        {
             JsonResponseModel<ModifySecLogCleanSettingInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySecLogCleanSettingInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecLogCleanSettingInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新安全日志-日志投递cls配置
        /// </summary>
        /// <param name="req"><see cref="ModifySecLogDeliveryClsSettingRequest"/></param>
        /// <returns><see cref="ModifySecLogDeliveryClsSettingResponse"/></returns>
        public async Task<ModifySecLogDeliveryClsSettingResponse> ModifySecLogDeliveryClsSetting(ModifySecLogDeliveryClsSettingRequest req)
        {
             JsonResponseModel<ModifySecLogDeliveryClsSettingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySecLogDeliveryClsSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecLogDeliveryClsSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新安全日志-日志投递cls配置
        /// </summary>
        /// <param name="req"><see cref="ModifySecLogDeliveryClsSettingRequest"/></param>
        /// <returns><see cref="ModifySecLogDeliveryClsSettingResponse"/></returns>
        public ModifySecLogDeliveryClsSettingResponse ModifySecLogDeliveryClsSettingSync(ModifySecLogDeliveryClsSettingRequest req)
        {
             JsonResponseModel<ModifySecLogDeliveryClsSettingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySecLogDeliveryClsSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecLogDeliveryClsSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新安全日志投递kafka设置
        /// </summary>
        /// <param name="req"><see cref="ModifySecLogDeliveryKafkaSettingRequest"/></param>
        /// <returns><see cref="ModifySecLogDeliveryKafkaSettingResponse"/></returns>
        public async Task<ModifySecLogDeliveryKafkaSettingResponse> ModifySecLogDeliveryKafkaSetting(ModifySecLogDeliveryKafkaSettingRequest req)
        {
             JsonResponseModel<ModifySecLogDeliveryKafkaSettingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySecLogDeliveryKafkaSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecLogDeliveryKafkaSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新安全日志投递kafka设置
        /// </summary>
        /// <param name="req"><see cref="ModifySecLogDeliveryKafkaSettingRequest"/></param>
        /// <returns><see cref="ModifySecLogDeliveryKafkaSettingResponse"/></returns>
        public ModifySecLogDeliveryKafkaSettingResponse ModifySecLogDeliveryKafkaSettingSync(ModifySecLogDeliveryKafkaSettingRequest req)
        {
             JsonResponseModel<ModifySecLogDeliveryKafkaSettingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySecLogDeliveryKafkaSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecLogDeliveryKafkaSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改安全日志接入对象
        /// </summary>
        /// <param name="req"><see cref="ModifySecLogJoinObjectsRequest"/></param>
        /// <returns><see cref="ModifySecLogJoinObjectsResponse"/></returns>
        public async Task<ModifySecLogJoinObjectsResponse> ModifySecLogJoinObjects(ModifySecLogJoinObjectsRequest req)
        {
             JsonResponseModel<ModifySecLogJoinObjectsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySecLogJoinObjects");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecLogJoinObjectsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改安全日志接入对象
        /// </summary>
        /// <param name="req"><see cref="ModifySecLogJoinObjectsRequest"/></param>
        /// <returns><see cref="ModifySecLogJoinObjectsResponse"/></returns>
        public ModifySecLogJoinObjectsResponse ModifySecLogJoinObjectsSync(ModifySecLogJoinObjectsRequest req)
        {
             JsonResponseModel<ModifySecLogJoinObjectsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySecLogJoinObjects");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecLogJoinObjectsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改安全日志接入状态
        /// </summary>
        /// <param name="req"><see cref="ModifySecLogJoinStateRequest"/></param>
        /// <returns><see cref="ModifySecLogJoinStateResponse"/></returns>
        public async Task<ModifySecLogJoinStateResponse> ModifySecLogJoinState(ModifySecLogJoinStateRequest req)
        {
             JsonResponseModel<ModifySecLogJoinStateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySecLogJoinState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecLogJoinStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改安全日志接入状态
        /// </summary>
        /// <param name="req"><see cref="ModifySecLogJoinStateRequest"/></param>
        /// <returns><see cref="ModifySecLogJoinStateResponse"/></returns>
        public ModifySecLogJoinStateResponse ModifySecLogJoinStateSync(ModifySecLogJoinStateRequest req)
        {
             JsonResponseModel<ModifySecLogJoinStateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySecLogJoinState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecLogJoinStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改安全日志kafkaUIN
        /// </summary>
        /// <param name="req"><see cref="ModifySecLogKafkaUINRequest"/></param>
        /// <returns><see cref="ModifySecLogKafkaUINResponse"/></returns>
        public async Task<ModifySecLogKafkaUINResponse> ModifySecLogKafkaUIN(ModifySecLogKafkaUINRequest req)
        {
             JsonResponseModel<ModifySecLogKafkaUINResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySecLogKafkaUIN");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecLogKafkaUINResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改安全日志kafkaUIN
        /// </summary>
        /// <param name="req"><see cref="ModifySecLogKafkaUINRequest"/></param>
        /// <returns><see cref="ModifySecLogKafkaUINResponse"/></returns>
        public ModifySecLogKafkaUINResponse ModifySecLogKafkaUINSync(ModifySecLogKafkaUINRequest req)
        {
             JsonResponseModel<ModifySecLogKafkaUINResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySecLogKafkaUIN");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecLogKafkaUINResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改木马自动隔离样本开关
        /// </summary>
        /// <param name="req"><see cref="ModifyVirusAutoIsolateExampleSwitchRequest"/></param>
        /// <returns><see cref="ModifyVirusAutoIsolateExampleSwitchResponse"/></returns>
        public async Task<ModifyVirusAutoIsolateExampleSwitchResponse> ModifyVirusAutoIsolateExampleSwitch(ModifyVirusAutoIsolateExampleSwitchRequest req)
        {
             JsonResponseModel<ModifyVirusAutoIsolateExampleSwitchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyVirusAutoIsolateExampleSwitch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVirusAutoIsolateExampleSwitchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改木马自动隔离样本开关
        /// </summary>
        /// <param name="req"><see cref="ModifyVirusAutoIsolateExampleSwitchRequest"/></param>
        /// <returns><see cref="ModifyVirusAutoIsolateExampleSwitchResponse"/></returns>
        public ModifyVirusAutoIsolateExampleSwitchResponse ModifyVirusAutoIsolateExampleSwitchSync(ModifyVirusAutoIsolateExampleSwitchRequest req)
        {
             JsonResponseModel<ModifyVirusAutoIsolateExampleSwitchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyVirusAutoIsolateExampleSwitch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVirusAutoIsolateExampleSwitchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改木马自动隔离设置
        /// </summary>
        /// <param name="req"><see cref="ModifyVirusAutoIsolateSettingRequest"/></param>
        /// <returns><see cref="ModifyVirusAutoIsolateSettingResponse"/></returns>
        public async Task<ModifyVirusAutoIsolateSettingResponse> ModifyVirusAutoIsolateSetting(ModifyVirusAutoIsolateSettingRequest req)
        {
             JsonResponseModel<ModifyVirusAutoIsolateSettingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyVirusAutoIsolateSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVirusAutoIsolateSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改木马自动隔离设置
        /// </summary>
        /// <param name="req"><see cref="ModifyVirusAutoIsolateSettingRequest"/></param>
        /// <returns><see cref="ModifyVirusAutoIsolateSettingResponse"/></returns>
        public ModifyVirusAutoIsolateSettingResponse ModifyVirusAutoIsolateSettingSync(ModifyVirusAutoIsolateSettingRequest req)
        {
             JsonResponseModel<ModifyVirusAutoIsolateSettingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyVirusAutoIsolateSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVirusAutoIsolateSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运行时更新木马文件事件状态
        /// </summary>
        /// <param name="req"><see cref="ModifyVirusFileStatusRequest"/></param>
        /// <returns><see cref="ModifyVirusFileStatusResponse"/></returns>
        public async Task<ModifyVirusFileStatusResponse> ModifyVirusFileStatus(ModifyVirusFileStatusRequest req)
        {
             JsonResponseModel<ModifyVirusFileStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyVirusFileStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVirusFileStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运行时更新木马文件事件状态
        /// </summary>
        /// <param name="req"><see cref="ModifyVirusFileStatusRequest"/></param>
        /// <returns><see cref="ModifyVirusFileStatusResponse"/></returns>
        public ModifyVirusFileStatusResponse ModifyVirusFileStatusSync(ModifyVirusFileStatusRequest req)
        {
             JsonResponseModel<ModifyVirusFileStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyVirusFileStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVirusFileStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运行时更新文件查杀实时监控设置
        /// </summary>
        /// <param name="req"><see cref="ModifyVirusMonitorSettingRequest"/></param>
        /// <returns><see cref="ModifyVirusMonitorSettingResponse"/></returns>
        public async Task<ModifyVirusMonitorSettingResponse> ModifyVirusMonitorSetting(ModifyVirusMonitorSettingRequest req)
        {
             JsonResponseModel<ModifyVirusMonitorSettingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyVirusMonitorSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVirusMonitorSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运行时更新文件查杀实时监控设置
        /// </summary>
        /// <param name="req"><see cref="ModifyVirusMonitorSettingRequest"/></param>
        /// <returns><see cref="ModifyVirusMonitorSettingResponse"/></returns>
        public ModifyVirusMonitorSettingResponse ModifyVirusMonitorSettingSync(ModifyVirusMonitorSettingRequest req)
        {
             JsonResponseModel<ModifyVirusMonitorSettingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyVirusMonitorSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVirusMonitorSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运行时更新文件查杀设置
        /// </summary>
        /// <param name="req"><see cref="ModifyVirusScanSettingRequest"/></param>
        /// <returns><see cref="ModifyVirusScanSettingResponse"/></returns>
        public async Task<ModifyVirusScanSettingResponse> ModifyVirusScanSetting(ModifyVirusScanSettingRequest req)
        {
             JsonResponseModel<ModifyVirusScanSettingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyVirusScanSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVirusScanSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运行时更新文件查杀设置
        /// </summary>
        /// <param name="req"><see cref="ModifyVirusScanSettingRequest"/></param>
        /// <returns><see cref="ModifyVirusScanSettingResponse"/></returns>
        public ModifyVirusScanSettingResponse ModifyVirusScanSettingSync(ModifyVirusScanSettingRequest req)
        {
             JsonResponseModel<ModifyVirusScanSettingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyVirusScanSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVirusScanSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运行时文件扫描超时设置
        /// </summary>
        /// <param name="req"><see cref="ModifyVirusScanTimeoutSettingRequest"/></param>
        /// <returns><see cref="ModifyVirusScanTimeoutSettingResponse"/></returns>
        public async Task<ModifyVirusScanTimeoutSettingResponse> ModifyVirusScanTimeoutSetting(ModifyVirusScanTimeoutSettingRequest req)
        {
             JsonResponseModel<ModifyVirusScanTimeoutSettingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyVirusScanTimeoutSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVirusScanTimeoutSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运行时文件扫描超时设置
        /// </summary>
        /// <param name="req"><see cref="ModifyVirusScanTimeoutSettingRequest"/></param>
        /// <returns><see cref="ModifyVirusScanTimeoutSettingResponse"/></returns>
        public ModifyVirusScanTimeoutSettingResponse ModifyVirusScanTimeoutSettingSync(ModifyVirusScanTimeoutSettingRequest req)
        {
             JsonResponseModel<ModifyVirusScanTimeoutSettingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyVirusScanTimeoutSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVirusScanTimeoutSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改漏洞防御事件状态
        /// </summary>
        /// <param name="req"><see cref="ModifyVulDefenceEventStatusRequest"/></param>
        /// <returns><see cref="ModifyVulDefenceEventStatusResponse"/></returns>
        public async Task<ModifyVulDefenceEventStatusResponse> ModifyVulDefenceEventStatus(ModifyVulDefenceEventStatusRequest req)
        {
             JsonResponseModel<ModifyVulDefenceEventStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyVulDefenceEventStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVulDefenceEventStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改漏洞防御事件状态
        /// </summary>
        /// <param name="req"><see cref="ModifyVulDefenceEventStatusRequest"/></param>
        /// <returns><see cref="ModifyVulDefenceEventStatusResponse"/></returns>
        public ModifyVulDefenceEventStatusResponse ModifyVulDefenceEventStatusSync(ModifyVulDefenceEventStatusRequest req)
        {
             JsonResponseModel<ModifyVulDefenceEventStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyVulDefenceEventStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVulDefenceEventStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑漏洞防御设置
        /// </summary>
        /// <param name="req"><see cref="ModifyVulDefenceSettingRequest"/></param>
        /// <returns><see cref="ModifyVulDefenceSettingResponse"/></returns>
        public async Task<ModifyVulDefenceSettingResponse> ModifyVulDefenceSetting(ModifyVulDefenceSettingRequest req)
        {
             JsonResponseModel<ModifyVulDefenceSettingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyVulDefenceSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVulDefenceSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑漏洞防御设置
        /// </summary>
        /// <param name="req"><see cref="ModifyVulDefenceSettingRequest"/></param>
        /// <returns><see cref="ModifyVulDefenceSettingResponse"/></returns>
        public ModifyVulDefenceSettingResponse ModifyVulDefenceSettingSync(ModifyVulDefenceSettingRequest req)
        {
             JsonResponseModel<ModifyVulDefenceSettingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyVulDefenceSetting");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyVulDefenceSettingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开通容器安全服务试用
        /// </summary>
        /// <param name="req"><see cref="OpenTcssTrialRequest"/></param>
        /// <returns><see cref="OpenTcssTrialResponse"/></returns>
        public async Task<OpenTcssTrialResponse> OpenTcssTrial(OpenTcssTrialRequest req)
        {
             JsonResponseModel<OpenTcssTrialResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "OpenTcssTrial");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenTcssTrialResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开通容器安全服务试用
        /// </summary>
        /// <param name="req"><see cref="OpenTcssTrialRequest"/></param>
        /// <returns><see cref="OpenTcssTrialResponse"/></returns>
        public OpenTcssTrialResponse OpenTcssTrialSync(OpenTcssTrialRequest req)
        {
             JsonResponseModel<OpenTcssTrialResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "OpenTcssTrial");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenTcssTrialResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除单个镜像仓库详细信息
        /// </summary>
        /// <param name="req"><see cref="RemoveAssetImageRegistryRegistryDetailRequest"/></param>
        /// <returns><see cref="RemoveAssetImageRegistryRegistryDetailResponse"/></returns>
        public async Task<RemoveAssetImageRegistryRegistryDetailResponse> RemoveAssetImageRegistryRegistryDetail(RemoveAssetImageRegistryRegistryDetailRequest req)
        {
             JsonResponseModel<RemoveAssetImageRegistryRegistryDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RemoveAssetImageRegistryRegistryDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveAssetImageRegistryRegistryDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除单个镜像仓库详细信息
        /// </summary>
        /// <param name="req"><see cref="RemoveAssetImageRegistryRegistryDetailRequest"/></param>
        /// <returns><see cref="RemoveAssetImageRegistryRegistryDetailResponse"/></returns>
        public RemoveAssetImageRegistryRegistryDetailResponse RemoveAssetImageRegistryRegistryDetailSync(RemoveAssetImageRegistryRegistryDetailRequest req)
        {
             JsonResponseModel<RemoveAssetImageRegistryRegistryDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RemoveAssetImageRegistryRegistryDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveAssetImageRegistryRegistryDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// RenewImageAuthorizeState   授权镜像扫描
        /// </summary>
        /// <param name="req"><see cref="RenewImageAuthorizeStateRequest"/></param>
        /// <returns><see cref="RenewImageAuthorizeStateResponse"/></returns>
        public async Task<RenewImageAuthorizeStateResponse> RenewImageAuthorizeState(RenewImageAuthorizeStateRequest req)
        {
             JsonResponseModel<RenewImageAuthorizeStateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RenewImageAuthorizeState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewImageAuthorizeStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// RenewImageAuthorizeState   授权镜像扫描
        /// </summary>
        /// <param name="req"><see cref="RenewImageAuthorizeStateRequest"/></param>
        /// <returns><see cref="RenewImageAuthorizeStateResponse"/></returns>
        public RenewImageAuthorizeStateResponse RenewImageAuthorizeStateSync(RenewImageAuthorizeStateRequest req)
        {
             JsonResponseModel<RenewImageAuthorizeStateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RenewImageAuthorizeState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewImageAuthorizeStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重置安全日志主题设置
        /// </summary>
        /// <param name="req"><see cref="ResetSecLogTopicConfigRequest"/></param>
        /// <returns><see cref="ResetSecLogTopicConfigResponse"/></returns>
        public async Task<ResetSecLogTopicConfigResponse> ResetSecLogTopicConfig(ResetSecLogTopicConfigRequest req)
        {
             JsonResponseModel<ResetSecLogTopicConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetSecLogTopicConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetSecLogTopicConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重置安全日志主题设置
        /// </summary>
        /// <param name="req"><see cref="ResetSecLogTopicConfigRequest"/></param>
        /// <returns><see cref="ResetSecLogTopicConfigResponse"/></returns>
        public ResetSecLogTopicConfigResponse ResetSecLogTopicConfigSync(ResetSecLogTopicConfigRequest req)
        {
             JsonResponseModel<ResetSecLogTopicConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetSecLogTopicConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetSecLogTopicConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重新检测选定的资产
        /// </summary>
        /// <param name="req"><see cref="ScanComplianceAssetsRequest"/></param>
        /// <returns><see cref="ScanComplianceAssetsResponse"/></returns>
        public async Task<ScanComplianceAssetsResponse> ScanComplianceAssets(ScanComplianceAssetsRequest req)
        {
             JsonResponseModel<ScanComplianceAssetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ScanComplianceAssets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScanComplianceAssetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重新检测选定的资产
        /// </summary>
        /// <param name="req"><see cref="ScanComplianceAssetsRequest"/></param>
        /// <returns><see cref="ScanComplianceAssetsResponse"/></returns>
        public ScanComplianceAssetsResponse ScanComplianceAssetsSync(ScanComplianceAssetsRequest req)
        {
             JsonResponseModel<ScanComplianceAssetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ScanComplianceAssets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScanComplianceAssetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用指定的检测项重新检测选定的资产，返回创建的合规检查任务的ID。
        /// </summary>
        /// <param name="req"><see cref="ScanComplianceAssetsByPolicyItemRequest"/></param>
        /// <returns><see cref="ScanComplianceAssetsByPolicyItemResponse"/></returns>
        public async Task<ScanComplianceAssetsByPolicyItemResponse> ScanComplianceAssetsByPolicyItem(ScanComplianceAssetsByPolicyItemRequest req)
        {
             JsonResponseModel<ScanComplianceAssetsByPolicyItemResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ScanComplianceAssetsByPolicyItem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScanComplianceAssetsByPolicyItemResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用指定的检测项重新检测选定的资产，返回创建的合规检查任务的ID。
        /// </summary>
        /// <param name="req"><see cref="ScanComplianceAssetsByPolicyItemRequest"/></param>
        /// <returns><see cref="ScanComplianceAssetsByPolicyItemResponse"/></returns>
        public ScanComplianceAssetsByPolicyItemResponse ScanComplianceAssetsByPolicyItemSync(ScanComplianceAssetsByPolicyItemRequest req)
        {
             JsonResponseModel<ScanComplianceAssetsByPolicyItemResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ScanComplianceAssetsByPolicyItem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScanComplianceAssetsByPolicyItemResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重新检测选的检测项下的所有资产，返回创建的合规检查任务的ID。
        /// </summary>
        /// <param name="req"><see cref="ScanCompliancePolicyItemsRequest"/></param>
        /// <returns><see cref="ScanCompliancePolicyItemsResponse"/></returns>
        public async Task<ScanCompliancePolicyItemsResponse> ScanCompliancePolicyItems(ScanCompliancePolicyItemsRequest req)
        {
             JsonResponseModel<ScanCompliancePolicyItemsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ScanCompliancePolicyItems");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScanCompliancePolicyItemsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重新检测选的检测项下的所有资产，返回创建的合规检查任务的ID。
        /// </summary>
        /// <param name="req"><see cref="ScanCompliancePolicyItemsRequest"/></param>
        /// <returns><see cref="ScanCompliancePolicyItemsResponse"/></returns>
        public ScanCompliancePolicyItemsResponse ScanCompliancePolicyItemsSync(ScanCompliancePolicyItemsRequest req)
        {
             JsonResponseModel<ScanCompliancePolicyItemsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ScanCompliancePolicyItems");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScanCompliancePolicyItemsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重新检测选定的检测失败的资产下的所有失败的检测项，返回创建的合规检查任务的ID。
        /// </summary>
        /// <param name="req"><see cref="ScanComplianceScanFailedAssetsRequest"/></param>
        /// <returns><see cref="ScanComplianceScanFailedAssetsResponse"/></returns>
        public async Task<ScanComplianceScanFailedAssetsResponse> ScanComplianceScanFailedAssets(ScanComplianceScanFailedAssetsRequest req)
        {
             JsonResponseModel<ScanComplianceScanFailedAssetsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ScanComplianceScanFailedAssets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScanComplianceScanFailedAssetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重新检测选定的检测失败的资产下的所有失败的检测项，返回创建的合规检查任务的ID。
        /// </summary>
        /// <param name="req"><see cref="ScanComplianceScanFailedAssetsRequest"/></param>
        /// <returns><see cref="ScanComplianceScanFailedAssetsResponse"/></returns>
        public ScanComplianceScanFailedAssetsResponse ScanComplianceScanFailedAssetsSync(ScanComplianceScanFailedAssetsRequest req)
        {
             JsonResponseModel<ScanComplianceScanFailedAssetsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ScanComplianceScanFailedAssets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScanComplianceScanFailedAssetsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置检测模式和自动检查
        /// </summary>
        /// <param name="req"><see cref="SetCheckModeRequest"/></param>
        /// <returns><see cref="SetCheckModeResponse"/></returns>
        public async Task<SetCheckModeResponse> SetCheckMode(SetCheckModeRequest req)
        {
             JsonResponseModel<SetCheckModeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetCheckMode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetCheckModeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 设置检测模式和自动检查
        /// </summary>
        /// <param name="req"><see cref="SetCheckModeRequest"/></param>
        /// <returns><see cref="SetCheckModeResponse"/></returns>
        public SetCheckModeResponse SetCheckModeSync(SetCheckModeRequest req)
        {
             JsonResponseModel<SetCheckModeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetCheckMode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetCheckModeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运行时停止木马查杀任务
        /// </summary>
        /// <param name="req"><see cref="StopVirusScanTaskRequest"/></param>
        /// <returns><see cref="StopVirusScanTaskResponse"/></returns>
        public async Task<StopVirusScanTaskResponse> StopVirusScanTask(StopVirusScanTaskRequest req)
        {
             JsonResponseModel<StopVirusScanTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopVirusScanTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopVirusScanTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 运行时停止木马查杀任务
        /// </summary>
        /// <param name="req"><see cref="StopVirusScanTaskRequest"/></param>
        /// <returns><see cref="StopVirusScanTaskResponse"/></returns>
        public StopVirusScanTaskResponse StopVirusScanTaskSync(StopVirusScanTaskRequest req)
        {
             JsonResponseModel<StopVirusScanTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopVirusScanTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopVirusScanTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止漏洞扫描任务
        /// </summary>
        /// <param name="req"><see cref="StopVulScanTaskRequest"/></param>
        /// <returns><see cref="StopVulScanTaskResponse"/></returns>
        public async Task<StopVulScanTaskResponse> StopVulScanTask(StopVulScanTaskRequest req)
        {
             JsonResponseModel<StopVulScanTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopVulScanTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopVulScanTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止漏洞扫描任务
        /// </summary>
        /// <param name="req"><see cref="StopVulScanTaskRequest"/></param>
        /// <returns><see cref="StopVulScanTaskResponse"/></returns>
        public StopVulScanTaskResponse StopVulScanTaskSync(StopVulScanTaskRequest req)
        {
             JsonResponseModel<StopVulScanTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopVulScanTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopVulScanTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑本地镜像自动授权开关
        /// </summary>
        /// <param name="req"><see cref="SwitchImageAutoAuthorizedRuleRequest"/></param>
        /// <returns><see cref="SwitchImageAutoAuthorizedRuleResponse"/></returns>
        public async Task<SwitchImageAutoAuthorizedRuleResponse> SwitchImageAutoAuthorizedRule(SwitchImageAutoAuthorizedRuleRequest req)
        {
             JsonResponseModel<SwitchImageAutoAuthorizedRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SwitchImageAutoAuthorizedRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchImageAutoAuthorizedRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑本地镜像自动授权开关
        /// </summary>
        /// <param name="req"><see cref="SwitchImageAutoAuthorizedRuleRequest"/></param>
        /// <returns><see cref="SwitchImageAutoAuthorizedRuleResponse"/></returns>
        public SwitchImageAutoAuthorizedRuleResponse SwitchImageAutoAuthorizedRuleSync(SwitchImageAutoAuthorizedRuleRequest req)
        {
             JsonResponseModel<SwitchImageAutoAuthorizedRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SwitchImageAutoAuthorizedRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchImageAutoAuthorizedRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 镜像仓库资产刷新
        /// </summary>
        /// <param name="req"><see cref="SyncAssetImageRegistryAssetRequest"/></param>
        /// <returns><see cref="SyncAssetImageRegistryAssetResponse"/></returns>
        public async Task<SyncAssetImageRegistryAssetResponse> SyncAssetImageRegistryAsset(SyncAssetImageRegistryAssetRequest req)
        {
             JsonResponseModel<SyncAssetImageRegistryAssetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SyncAssetImageRegistryAsset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SyncAssetImageRegistryAssetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 镜像仓库资产刷新
        /// </summary>
        /// <param name="req"><see cref="SyncAssetImageRegistryAssetRequest"/></param>
        /// <returns><see cref="SyncAssetImageRegistryAssetResponse"/></returns>
        public SyncAssetImageRegistryAssetResponse SyncAssetImageRegistryAssetSync(SyncAssetImageRegistryAssetRequest req)
        {
             JsonResponseModel<SyncAssetImageRegistryAssetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SyncAssetImageRegistryAsset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SyncAssetImageRegistryAssetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器网络创建网络策略更新并发布任务
        /// </summary>
        /// <param name="req"><see cref="UpdateAndPublishNetworkFirewallPolicyDetailRequest"/></param>
        /// <returns><see cref="UpdateAndPublishNetworkFirewallPolicyDetailResponse"/></returns>
        public async Task<UpdateAndPublishNetworkFirewallPolicyDetailResponse> UpdateAndPublishNetworkFirewallPolicyDetail(UpdateAndPublishNetworkFirewallPolicyDetailRequest req)
        {
             JsonResponseModel<UpdateAndPublishNetworkFirewallPolicyDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateAndPublishNetworkFirewallPolicyDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateAndPublishNetworkFirewallPolicyDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器网络创建网络策略更新并发布任务
        /// </summary>
        /// <param name="req"><see cref="UpdateAndPublishNetworkFirewallPolicyDetailRequest"/></param>
        /// <returns><see cref="UpdateAndPublishNetworkFirewallPolicyDetailResponse"/></returns>
        public UpdateAndPublishNetworkFirewallPolicyDetailResponse UpdateAndPublishNetworkFirewallPolicyDetailSync(UpdateAndPublishNetworkFirewallPolicyDetailRequest req)
        {
             JsonResponseModel<UpdateAndPublishNetworkFirewallPolicyDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateAndPublishNetworkFirewallPolicyDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateAndPublishNetworkFirewallPolicyDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器网络更新Yaml网络策略并发布任务
        /// </summary>
        /// <param name="req"><see cref="UpdateAndPublishNetworkFirewallPolicyYamlDetailRequest"/></param>
        /// <returns><see cref="UpdateAndPublishNetworkFirewallPolicyYamlDetailResponse"/></returns>
        public async Task<UpdateAndPublishNetworkFirewallPolicyYamlDetailResponse> UpdateAndPublishNetworkFirewallPolicyYamlDetail(UpdateAndPublishNetworkFirewallPolicyYamlDetailRequest req)
        {
             JsonResponseModel<UpdateAndPublishNetworkFirewallPolicyYamlDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateAndPublishNetworkFirewallPolicyYamlDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateAndPublishNetworkFirewallPolicyYamlDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器网络更新Yaml网络策略并发布任务
        /// </summary>
        /// <param name="req"><see cref="UpdateAndPublishNetworkFirewallPolicyYamlDetailRequest"/></param>
        /// <returns><see cref="UpdateAndPublishNetworkFirewallPolicyYamlDetailResponse"/></returns>
        public UpdateAndPublishNetworkFirewallPolicyYamlDetailResponse UpdateAndPublishNetworkFirewallPolicyYamlDetailSync(UpdateAndPublishNetworkFirewallPolicyYamlDetailRequest req)
        {
             JsonResponseModel<UpdateAndPublishNetworkFirewallPolicyYamlDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateAndPublishNetworkFirewallPolicyYamlDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateAndPublishNetworkFirewallPolicyYamlDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新单个镜像仓库详细信息
        /// </summary>
        /// <param name="req"><see cref="UpdateAssetImageRegistryRegistryDetailRequest"/></param>
        /// <returns><see cref="UpdateAssetImageRegistryRegistryDetailResponse"/></returns>
        public async Task<UpdateAssetImageRegistryRegistryDetailResponse> UpdateAssetImageRegistryRegistryDetail(UpdateAssetImageRegistryRegistryDetailRequest req)
        {
             JsonResponseModel<UpdateAssetImageRegistryRegistryDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateAssetImageRegistryRegistryDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateAssetImageRegistryRegistryDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新单个镜像仓库详细信息
        /// </summary>
        /// <param name="req"><see cref="UpdateAssetImageRegistryRegistryDetailRequest"/></param>
        /// <returns><see cref="UpdateAssetImageRegistryRegistryDetailResponse"/></returns>
        public UpdateAssetImageRegistryRegistryDetailResponse UpdateAssetImageRegistryRegistryDetailSync(UpdateAssetImageRegistryRegistryDetailRequest req)
        {
             JsonResponseModel<UpdateAssetImageRegistryRegistryDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateAssetImageRegistryRegistryDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateAssetImageRegistryRegistryDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 镜像仓库更新定时任务
        /// </summary>
        /// <param name="req"><see cref="UpdateImageRegistryTimingScanTaskRequest"/></param>
        /// <returns><see cref="UpdateImageRegistryTimingScanTaskResponse"/></returns>
        public async Task<UpdateImageRegistryTimingScanTaskResponse> UpdateImageRegistryTimingScanTask(UpdateImageRegistryTimingScanTaskRequest req)
        {
             JsonResponseModel<UpdateImageRegistryTimingScanTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateImageRegistryTimingScanTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateImageRegistryTimingScanTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 镜像仓库更新定时任务
        /// </summary>
        /// <param name="req"><see cref="UpdateImageRegistryTimingScanTaskRequest"/></param>
        /// <returns><see cref="UpdateImageRegistryTimingScanTaskResponse"/></returns>
        public UpdateImageRegistryTimingScanTaskResponse UpdateImageRegistryTimingScanTaskSync(UpdateImageRegistryTimingScanTaskRequest req)
        {
             JsonResponseModel<UpdateImageRegistryTimingScanTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateImageRegistryTimingScanTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateImageRegistryTimingScanTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器网络创建网络策略更新任务
        /// </summary>
        /// <param name="req"><see cref="UpdateNetworkFirewallPolicyDetailRequest"/></param>
        /// <returns><see cref="UpdateNetworkFirewallPolicyDetailResponse"/></returns>
        public async Task<UpdateNetworkFirewallPolicyDetailResponse> UpdateNetworkFirewallPolicyDetail(UpdateNetworkFirewallPolicyDetailRequest req)
        {
             JsonResponseModel<UpdateNetworkFirewallPolicyDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateNetworkFirewallPolicyDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateNetworkFirewallPolicyDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器网络创建网络策略更新任务
        /// </summary>
        /// <param name="req"><see cref="UpdateNetworkFirewallPolicyDetailRequest"/></param>
        /// <returns><see cref="UpdateNetworkFirewallPolicyDetailResponse"/></returns>
        public UpdateNetworkFirewallPolicyDetailResponse UpdateNetworkFirewallPolicyDetailSync(UpdateNetworkFirewallPolicyDetailRequest req)
        {
             JsonResponseModel<UpdateNetworkFirewallPolicyDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateNetworkFirewallPolicyDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateNetworkFirewallPolicyDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器网络更新Yaml网络策略任务
        /// </summary>
        /// <param name="req"><see cref="UpdateNetworkFirewallPolicyYamlDetailRequest"/></param>
        /// <returns><see cref="UpdateNetworkFirewallPolicyYamlDetailResponse"/></returns>
        public async Task<UpdateNetworkFirewallPolicyYamlDetailResponse> UpdateNetworkFirewallPolicyYamlDetail(UpdateNetworkFirewallPolicyYamlDetailRequest req)
        {
             JsonResponseModel<UpdateNetworkFirewallPolicyYamlDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateNetworkFirewallPolicyYamlDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateNetworkFirewallPolicyYamlDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 容器网络更新Yaml网络策略任务
        /// </summary>
        /// <param name="req"><see cref="UpdateNetworkFirewallPolicyYamlDetailRequest"/></param>
        /// <returns><see cref="UpdateNetworkFirewallPolicyYamlDetailResponse"/></returns>
        public UpdateNetworkFirewallPolicyYamlDetailResponse UpdateNetworkFirewallPolicyYamlDetailSync(UpdateNetworkFirewallPolicyYamlDetailRequest req)
        {
             JsonResponseModel<UpdateNetworkFirewallPolicyYamlDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateNetworkFirewallPolicyYamlDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateNetworkFirewallPolicyYamlDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}

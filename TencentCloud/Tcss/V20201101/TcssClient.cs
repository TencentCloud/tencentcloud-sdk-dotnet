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
        /// 运行时文件查杀事件列表
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
        /// 运行时文件查杀事件列表
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

    }
}

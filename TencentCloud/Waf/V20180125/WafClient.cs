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

namespace TencentCloud.Waf.V20180125
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Waf.V20180125.Models;

   public class WafClient : AbstractClient{

       private const string endpoint = "waf.tencentcloudapi.com";
       private const string version = "2018-01-25";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public WafClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public WafClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 增加自定义策略
        /// </summary>
        /// <param name="req"><see cref="AddCustomRuleRequest"/></param>
        /// <returns><see cref="AddCustomRuleResponse"/></returns>
        public async Task<AddCustomRuleResponse> AddCustomRule(AddCustomRuleRequest req)
        {
             JsonResponseModel<AddCustomRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddCustomRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddCustomRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 增加自定义策略
        /// </summary>
        /// <param name="req"><see cref="AddCustomRuleRequest"/></param>
        /// <returns><see cref="AddCustomRuleResponse"/></returns>
        public AddCustomRuleResponse AddCustomRuleSync(AddCustomRuleRequest req)
        {
             JsonResponseModel<AddCustomRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddCustomRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddCustomRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建攻击日志下载任务
        /// </summary>
        /// <param name="req"><see cref="CreateAttackDownloadTaskRequest"/></param>
        /// <returns><see cref="CreateAttackDownloadTaskResponse"/></returns>
        public async Task<CreateAttackDownloadTaskResponse> CreateAttackDownloadTask(CreateAttackDownloadTaskRequest req)
        {
             JsonResponseModel<CreateAttackDownloadTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAttackDownloadTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAttackDownloadTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建攻击日志下载任务
        /// </summary>
        /// <param name="req"><see cref="CreateAttackDownloadTaskRequest"/></param>
        /// <returns><see cref="CreateAttackDownloadTaskResponse"/></returns>
        public CreateAttackDownloadTaskResponse CreateAttackDownloadTaskSync(CreateAttackDownloadTaskRequest req)
        {
             JsonResponseModel<CreateAttackDownloadTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAttackDownloadTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAttackDownloadTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除攻击日志下载任务记录
        /// </summary>
        /// <param name="req"><see cref="DeleteAttackDownloadRecordRequest"/></param>
        /// <returns><see cref="DeleteAttackDownloadRecordResponse"/></returns>
        public async Task<DeleteAttackDownloadRecordResponse> DeleteAttackDownloadRecord(DeleteAttackDownloadRecordRequest req)
        {
             JsonResponseModel<DeleteAttackDownloadRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAttackDownloadRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAttackDownloadRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除攻击日志下载任务记录
        /// </summary>
        /// <param name="req"><see cref="DeleteAttackDownloadRecordRequest"/></param>
        /// <returns><see cref="DeleteAttackDownloadRecordResponse"/></returns>
        public DeleteAttackDownloadRecordResponse DeleteAttackDownloadRecordSync(DeleteAttackDownloadRecordRequest req)
        {
             JsonResponseModel<DeleteAttackDownloadRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAttackDownloadRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAttackDownloadRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除访问日志下载记录
        /// </summary>
        /// <param name="req"><see cref="DeleteDownloadRecordRequest"/></param>
        /// <returns><see cref="DeleteDownloadRecordResponse"/></returns>
        public async Task<DeleteDownloadRecordResponse> DeleteDownloadRecord(DeleteDownloadRecordRequest req)
        {
             JsonResponseModel<DeleteDownloadRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDownloadRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDownloadRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除访问日志下载记录
        /// </summary>
        /// <param name="req"><see cref="DeleteDownloadRecordRequest"/></param>
        /// <returns><see cref="DeleteDownloadRecordResponse"/></returns>
        public DeleteDownloadRecordResponse DeleteDownloadRecordSync(DeleteDownloadRecordRequest req)
        {
             JsonResponseModel<DeleteDownloadRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDownloadRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDownloadRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除CC攻击的session设置
        /// </summary>
        /// <param name="req"><see cref="DeleteSessionRequest"/></param>
        /// <returns><see cref="DeleteSessionResponse"/></returns>
        public async Task<DeleteSessionResponse> DeleteSession(DeleteSessionRequest req)
        {
             JsonResponseModel<DeleteSessionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSession");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSessionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除CC攻击的session设置
        /// </summary>
        /// <param name="req"><see cref="DeleteSessionRequest"/></param>
        /// <returns><see cref="DeleteSessionResponse"/></returns>
        public DeleteSessionResponse DeleteSessionSync(DeleteSessionRequest req)
        {
             JsonResponseModel<DeleteSessionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSession");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSessionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取防护配置中的自定义策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomRulesRequest"/></param>
        /// <returns><see cref="DescribeCustomRulesResponse"/></returns>
        public async Task<DescribeCustomRulesResponse> DescribeCustomRules(DescribeCustomRulesRequest req)
        {
             JsonResponseModel<DescribeCustomRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCustomRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取防护配置中的自定义策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomRulesRequest"/></param>
        /// <returns><see cref="DescribeCustomRulesResponse"/></returns>
        public DescribeCustomRulesResponse DescribeCustomRulesSync(DescribeCustomRulesRequest req)
        {
             JsonResponseModel<DescribeCustomRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCustomRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCustomRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取waf流量访问趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowTrendRequest"/></param>
        /// <returns><see cref="DescribeFlowTrendResponse"/></returns>
        public async Task<DescribeFlowTrendResponse> DescribeFlowTrend(DescribeFlowTrendRequest req)
        {
             JsonResponseModel<DescribeFlowTrendResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFlowTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取waf流量访问趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowTrendRequest"/></param>
        /// <returns><see cref="DescribeFlowTrendResponse"/></returns>
        public DescribeFlowTrendResponse DescribeFlowTrendSync(DescribeFlowTrendRequest req)
        {
             JsonResponseModel<DescribeFlowTrendResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFlowTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在负载均衡型WAF的添加、编辑域名配置的时候，需要展示负载均衡型WAF（clb-waf)支持的地域列表，通过DescribeUserClbWafRegions既可以获得当前对客户已经开放的地域列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserClbWafRegionsRequest"/></param>
        /// <returns><see cref="DescribeUserClbWafRegionsResponse"/></returns>
        public async Task<DescribeUserClbWafRegionsResponse> DescribeUserClbWafRegions(DescribeUserClbWafRegionsRequest req)
        {
             JsonResponseModel<DescribeUserClbWafRegionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserClbWafRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserClbWafRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在负载均衡型WAF的添加、编辑域名配置的时候，需要展示负载均衡型WAF（clb-waf)支持的地域列表，通过DescribeUserClbWafRegions既可以获得当前对客户已经开放的地域列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserClbWafRegionsRequest"/></param>
        /// <returns><see cref="DescribeUserClbWafRegionsResponse"/></returns>
        public DescribeUserClbWafRegionsResponse DescribeUserClbWafRegionsSync(DescribeUserClbWafRegionsRequest req)
        {
             JsonResponseModel<DescribeUserClbWafRegionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserClbWafRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserClbWafRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于修改访问日志保存期限
        /// </summary>
        /// <param name="req"><see cref="ModifyAccessPeriodRequest"/></param>
        /// <returns><see cref="ModifyAccessPeriodResponse"/></returns>
        public async Task<ModifyAccessPeriodResponse> ModifyAccessPeriod(ModifyAccessPeriodRequest req)
        {
             JsonResponseModel<ModifyAccessPeriodResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAccessPeriod");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccessPeriodResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于修改访问日志保存期限
        /// </summary>
        /// <param name="req"><see cref="ModifyAccessPeriodRequest"/></param>
        /// <returns><see cref="ModifyAccessPeriodResponse"/></returns>
        public ModifyAccessPeriodResponse ModifyAccessPeriodSync(ModifyAccessPeriodRequest req)
        {
             JsonResponseModel<ModifyAccessPeriodResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAccessPeriod");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccessPeriodResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开启或禁用自定义策略
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyCustomRuleStatusResponse"/></returns>
        public async Task<ModifyCustomRuleStatusResponse> ModifyCustomRuleStatus(ModifyCustomRuleStatusRequest req)
        {
             JsonResponseModel<ModifyCustomRuleStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyCustomRuleStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCustomRuleStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开启或禁用自定义策略
        /// </summary>
        /// <param name="req"><see cref="ModifyCustomRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyCustomRuleStatusResponse"/></returns>
        public ModifyCustomRuleStatusResponse ModifyCustomRuleStatusSync(ModifyCustomRuleStatusRequest req)
        {
             JsonResponseModel<ModifyCustomRuleStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyCustomRuleStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyCustomRuleStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}

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

namespace TencentCloud.Cfw.V20190904
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cfw.V20190904.Models;

   public class CfwClient : AbstractClient{

       private const string endpoint = "cfw.tencentcloudapi.com";
       private const string version = "2019-09-04";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CfwClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CfwClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 创建规则
        /// </summary>
        /// <param name="req"><see cref="CreateAcRulesRequest"/></param>
        /// <returns><see cref="CreateAcRulesResponse"/></returns>
        public async Task<CreateAcRulesResponse> CreateAcRules(CreateAcRulesRequest req)
        {
             JsonResponseModel<CreateAcRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAcRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAcRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建规则
        /// </summary>
        /// <param name="req"><see cref="CreateAcRulesRequest"/></param>
        /// <returns><see cref="CreateAcRulesResponse"/></returns>
        public CreateAcRulesResponse CreateAcRulesSync(CreateAcRulesRequest req)
        {
             JsonResponseModel<CreateAcRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAcRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAcRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建安全组API规则
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityGroupApiRulesRequest"/></param>
        /// <returns><see cref="CreateSecurityGroupApiRulesResponse"/></returns>
        public async Task<CreateSecurityGroupApiRulesResponse> CreateSecurityGroupApiRules(CreateSecurityGroupApiRulesRequest req)
        {
             JsonResponseModel<CreateSecurityGroupApiRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSecurityGroupApiRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecurityGroupApiRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建安全组API规则
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityGroupApiRulesRequest"/></param>
        /// <returns><see cref="CreateSecurityGroupApiRulesResponse"/></returns>
        public CreateSecurityGroupApiRulesResponse CreateSecurityGroupApiRulesSync(CreateSecurityGroupApiRulesRequest req)
        {
             JsonResponseModel<CreateSecurityGroupApiRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSecurityGroupApiRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecurityGroupApiRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除规则
        /// </summary>
        /// <param name="req"><see cref="DeleteAcRuleRequest"/></param>
        /// <returns><see cref="DeleteAcRuleResponse"/></returns>
        public async Task<DeleteAcRuleResponse> DeleteAcRule(DeleteAcRuleRequest req)
        {
             JsonResponseModel<DeleteAcRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAcRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAcRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除规则
        /// </summary>
        /// <param name="req"><see cref="DeleteAcRuleRequest"/></param>
        /// <returns><see cref="DeleteAcRuleResponse"/></returns>
        public DeleteAcRuleResponse DeleteAcRuleSync(DeleteAcRuleRequest req)
        {
             JsonResponseModel<DeleteAcRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAcRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAcRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 全部删除规则
        /// </summary>
        /// <param name="req"><see cref="DeleteAllAccessControlRuleRequest"/></param>
        /// <returns><see cref="DeleteAllAccessControlRuleResponse"/></returns>
        public async Task<DeleteAllAccessControlRuleResponse> DeleteAllAccessControlRule(DeleteAllAccessControlRuleRequest req)
        {
             JsonResponseModel<DeleteAllAccessControlRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAllAccessControlRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAllAccessControlRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 全部删除规则
        /// </summary>
        /// <param name="req"><see cref="DeleteAllAccessControlRuleRequest"/></param>
        /// <returns><see cref="DeleteAllAccessControlRuleResponse"/></returns>
        public DeleteAllAccessControlRuleResponse DeleteAllAccessControlRuleSync(DeleteAllAccessControlRuleRequest req)
        {
             JsonResponseModel<DeleteAllAccessControlRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAllAccessControlRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAllAccessControlRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除全部规则
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityGroupAllRuleRequest"/></param>
        /// <returns><see cref="DeleteSecurityGroupAllRuleResponse"/></returns>
        public async Task<DeleteSecurityGroupAllRuleResponse> DeleteSecurityGroupAllRule(DeleteSecurityGroupAllRuleRequest req)
        {
             JsonResponseModel<DeleteSecurityGroupAllRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSecurityGroupAllRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSecurityGroupAllRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除全部规则
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityGroupAllRuleRequest"/></param>
        /// <returns><see cref="DeleteSecurityGroupAllRuleResponse"/></returns>
        public DeleteSecurityGroupAllRuleResponse DeleteSecurityGroupAllRuleSync(DeleteSecurityGroupAllRuleRequest req)
        {
             JsonResponseModel<DeleteSecurityGroupAllRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSecurityGroupAllRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSecurityGroupAllRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除规则
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityGroupRuleRequest"/></param>
        /// <returns><see cref="DeleteSecurityGroupRuleResponse"/></returns>
        public async Task<DeleteSecurityGroupRuleResponse> DeleteSecurityGroupRule(DeleteSecurityGroupRuleRequest req)
        {
             JsonResponseModel<DeleteSecurityGroupRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSecurityGroupRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSecurityGroupRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除规则
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityGroupRuleRequest"/></param>
        /// <returns><see cref="DeleteSecurityGroupRuleResponse"/></returns>
        public DeleteSecurityGroupRuleResponse DeleteSecurityGroupRuleSync(DeleteSecurityGroupRuleRequest req)
        {
             JsonResponseModel<DeleteSecurityGroupRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSecurityGroupRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSecurityGroupRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 访问控制列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAcListsRequest"/></param>
        /// <returns><see cref="DescribeAcListsResponse"/></returns>
        public async Task<DescribeAcListsResponse> DescribeAcLists(DescribeAcListsRequest req)
        {
             JsonResponseModel<DescribeAcListsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAcLists");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAcListsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 访问控制列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAcListsRequest"/></param>
        /// <returns><see cref="DescribeAcListsResponse"/></returns>
        public DescribeAcListsResponse DescribeAcListsSync(DescribeAcListsRequest req)
        {
             JsonResponseModel<DescribeAcListsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAcLists");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAcListsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取安全组关联实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssociatedInstanceListRequest"/></param>
        /// <returns><see cref="DescribeAssociatedInstanceListResponse"/></returns>
        public async Task<DescribeAssociatedInstanceListResponse> DescribeAssociatedInstanceList(DescribeAssociatedInstanceListRequest req)
        {
             JsonResponseModel<DescribeAssociatedInstanceListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssociatedInstanceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssociatedInstanceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取安全组关联实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssociatedInstanceListRequest"/></param>
        /// <returns><see cref="DescribeAssociatedInstanceListResponse"/></returns>
        public DescribeAssociatedInstanceListResponse DescribeAssociatedInstanceListSync(DescribeAssociatedInstanceListRequest req)
        {
             JsonResponseModel<DescribeAssociatedInstanceListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssociatedInstanceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssociatedInstanceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeBlockByIpTimesList 告警中心阻断IP折线图
        /// </summary>
        /// <param name="req"><see cref="DescribeBlockByIpTimesListRequest"/></param>
        /// <returns><see cref="DescribeBlockByIpTimesListResponse"/></returns>
        public async Task<DescribeBlockByIpTimesListResponse> DescribeBlockByIpTimesList(DescribeBlockByIpTimesListRequest req)
        {
             JsonResponseModel<DescribeBlockByIpTimesListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBlockByIpTimesList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBlockByIpTimesListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeBlockByIpTimesList 告警中心阻断IP折线图
        /// </summary>
        /// <param name="req"><see cref="DescribeBlockByIpTimesListRequest"/></param>
        /// <returns><see cref="DescribeBlockByIpTimesListResponse"/></returns>
        public DescribeBlockByIpTimesListResponse DescribeBlockByIpTimesListSync(DescribeBlockByIpTimesListRequest req)
        {
             JsonResponseModel<DescribeBlockByIpTimesListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBlockByIpTimesList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBlockByIpTimesListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeBlockStaticList 告警中心柱形图
        /// </summary>
        /// <param name="req"><see cref="DescribeBlockStaticListRequest"/></param>
        /// <returns><see cref="DescribeBlockStaticListResponse"/></returns>
        public async Task<DescribeBlockStaticListResponse> DescribeBlockStaticList(DescribeBlockStaticListRequest req)
        {
             JsonResponseModel<DescribeBlockStaticListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBlockStaticList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBlockStaticListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeBlockStaticList 告警中心柱形图
        /// </summary>
        /// <param name="req"><see cref="DescribeBlockStaticListRequest"/></param>
        /// <returns><see cref="DescribeBlockStaticListResponse"/></returns>
        public DescribeBlockStaticListResponse DescribeBlockStaticListSync(DescribeBlockStaticListRequest req)
        {
             JsonResponseModel<DescribeBlockStaticListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBlockStaticList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBlockStaticListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询防火墙弹性公网IP
        /// </summary>
        /// <param name="req"><see cref="DescribeCfwEipsRequest"/></param>
        /// <returns><see cref="DescribeCfwEipsResponse"/></returns>
        public async Task<DescribeCfwEipsResponse> DescribeCfwEips(DescribeCfwEipsRequest req)
        {
             JsonResponseModel<DescribeCfwEipsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCfwEips");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCfwEipsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询防火墙弹性公网IP
        /// </summary>
        /// <param name="req"><see cref="DescribeCfwEipsRequest"/></param>
        /// <returns><see cref="DescribeCfwEipsResponse"/></returns>
        public DescribeCfwEipsResponse DescribeCfwEipsSync(DescribeCfwEipsRequest req)
        {
             JsonResponseModel<DescribeCfwEipsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCfwEips");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCfwEipsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeGuideScanInfo新手引导扫描接口信息
        /// </summary>
        /// <param name="req"><see cref="DescribeGuideScanInfoRequest"/></param>
        /// <returns><see cref="DescribeGuideScanInfoResponse"/></returns>
        public async Task<DescribeGuideScanInfoResponse> DescribeGuideScanInfo(DescribeGuideScanInfoRequest req)
        {
             JsonResponseModel<DescribeGuideScanInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGuideScanInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGuideScanInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeGuideScanInfo新手引导扫描接口信息
        /// </summary>
        /// <param name="req"><see cref="DescribeGuideScanInfoRequest"/></param>
        /// <returns><see cref="DescribeGuideScanInfoResponse"/></returns>
        public DescribeGuideScanInfoResponse DescribeGuideScanInfoSync(DescribeGuideScanInfoRequest req)
        {
             JsonResponseModel<DescribeGuideScanInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGuideScanInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGuideScanInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// nat规则列表概况
        /// </summary>
        /// <param name="req"><see cref="DescribeNatRuleOverviewRequest"/></param>
        /// <returns><see cref="DescribeNatRuleOverviewResponse"/></returns>
        public async Task<DescribeNatRuleOverviewResponse> DescribeNatRuleOverview(DescribeNatRuleOverviewRequest req)
        {
             JsonResponseModel<DescribeNatRuleOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNatRuleOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNatRuleOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// nat规则列表概况
        /// </summary>
        /// <param name="req"><see cref="DescribeNatRuleOverviewRequest"/></param>
        /// <returns><see cref="DescribeNatRuleOverviewResponse"/></returns>
        public DescribeNatRuleOverviewResponse DescribeNatRuleOverviewSync(DescribeNatRuleOverviewRequest req)
        {
             JsonResponseModel<DescribeNatRuleOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNatRuleOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNatRuleOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询规则列表概况
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleOverviewRequest"/></param>
        /// <returns><see cref="DescribeRuleOverviewResponse"/></returns>
        public async Task<DescribeRuleOverviewResponse> DescribeRuleOverview(DescribeRuleOverviewRequest req)
        {
             JsonResponseModel<DescribeRuleOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRuleOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询规则列表概况
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleOverviewRequest"/></param>
        /// <returns><see cref="DescribeRuleOverviewResponse"/></returns>
        public DescribeRuleOverviewResponse DescribeRuleOverviewSync(DescribeRuleOverviewRequest req)
        {
             JsonResponseModel<DescribeRuleOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRuleOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询安全组规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupListRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupListResponse"/></returns>
        public async Task<DescribeSecurityGroupListResponse> DescribeSecurityGroupList(DescribeSecurityGroupListRequest req)
        {
             JsonResponseModel<DescribeSecurityGroupListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityGroupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityGroupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询安全组规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupListRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupListResponse"/></returns>
        public DescribeSecurityGroupListResponse DescribeSecurityGroupListSync(DescribeSecurityGroupListRequest req)
        {
             JsonResponseModel<DescribeSecurityGroupListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecurityGroupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityGroupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 防火墙开关列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSwitchListsRequest"/></param>
        /// <returns><see cref="DescribeSwitchListsResponse"/></returns>
        public async Task<DescribeSwitchListsResponse> DescribeSwitchLists(DescribeSwitchListsRequest req)
        {
             JsonResponseModel<DescribeSwitchListsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSwitchLists");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSwitchListsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 防火墙开关列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSwitchListsRequest"/></param>
        /// <returns><see cref="DescribeSwitchListsResponse"/></returns>
        public DescribeSwitchListsResponse DescribeSwitchListsSync(DescribeSwitchListsRequest req)
        {
             JsonResponseModel<DescribeSwitchListsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSwitchLists");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSwitchListsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 同步资产状态查询-互联网&VPC
        /// </summary>
        /// <param name="req"><see cref="DescribeSyncAssetStatusRequest"/></param>
        /// <returns><see cref="DescribeSyncAssetStatusResponse"/></returns>
        public async Task<DescribeSyncAssetStatusResponse> DescribeSyncAssetStatus(DescribeSyncAssetStatusRequest req)
        {
             JsonResponseModel<DescribeSyncAssetStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSyncAssetStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSyncAssetStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 同步资产状态查询-互联网&VPC
        /// </summary>
        /// <param name="req"><see cref="DescribeSyncAssetStatusRequest"/></param>
        /// <returns><see cref="DescribeSyncAssetStatusResponse"/></returns>
        public DescribeSyncAssetStatusResponse DescribeSyncAssetStatusSync(DescribeSyncAssetStatusRequest req)
        {
             JsonResponseModel<DescribeSyncAssetStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSyncAssetStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSyncAssetStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeTLogInfo告警中心概况
        /// </summary>
        /// <param name="req"><see cref="DescribeTLogInfoRequest"/></param>
        /// <returns><see cref="DescribeTLogInfoResponse"/></returns>
        public async Task<DescribeTLogInfoResponse> DescribeTLogInfo(DescribeTLogInfoRequest req)
        {
             JsonResponseModel<DescribeTLogInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTLogInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTLogInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeTLogInfo告警中心概况
        /// </summary>
        /// <param name="req"><see cref="DescribeTLogInfoRequest"/></param>
        /// <returns><see cref="DescribeTLogInfoResponse"/></returns>
        public DescribeTLogInfoResponse DescribeTLogInfoSync(DescribeTLogInfoRequest req)
        {
             JsonResponseModel<DescribeTLogInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTLogInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTLogInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeTLogIpList告警中心IP柱形图
        /// </summary>
        /// <param name="req"><see cref="DescribeTLogIpListRequest"/></param>
        /// <returns><see cref="DescribeTLogIpListResponse"/></returns>
        public async Task<DescribeTLogIpListResponse> DescribeTLogIpList(DescribeTLogIpListRequest req)
        {
             JsonResponseModel<DescribeTLogIpListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTLogIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTLogIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeTLogIpList告警中心IP柱形图
        /// </summary>
        /// <param name="req"><see cref="DescribeTLogIpListRequest"/></param>
        /// <returns><see cref="DescribeTLogIpListResponse"/></returns>
        public DescribeTLogIpListResponse DescribeTLogIpListSync(DescribeTLogIpListRequest req)
        {
             JsonResponseModel<DescribeTLogIpListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTLogIpList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTLogIpListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询规则表状态
        /// </summary>
        /// <param name="req"><see cref="DescribeTableStatusRequest"/></param>
        /// <returns><see cref="DescribeTableStatusResponse"/></returns>
        public async Task<DescribeTableStatusResponse> DescribeTableStatus(DescribeTableStatusRequest req)
        {
             JsonResponseModel<DescribeTableStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTableStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTableStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询规则表状态
        /// </summary>
        /// <param name="req"><see cref="DescribeTableStatusRequest"/></param>
        /// <returns><see cref="DescribeTableStatusResponse"/></returns>
        public DescribeTableStatusResponse DescribeTableStatusSync(DescribeTableStatusRequest req)
        {
             JsonResponseModel<DescribeTableStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTableStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTableStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeUnHandleEventTabList 告警中心伪攻击链事件未处置接口
        /// </summary>
        /// <param name="req"><see cref="DescribeUnHandleEventTabListRequest"/></param>
        /// <returns><see cref="DescribeUnHandleEventTabListResponse"/></returns>
        public async Task<DescribeUnHandleEventTabListResponse> DescribeUnHandleEventTabList(DescribeUnHandleEventTabListRequest req)
        {
             JsonResponseModel<DescribeUnHandleEventTabListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUnHandleEventTabList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUnHandleEventTabListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeUnHandleEventTabList 告警中心伪攻击链事件未处置接口
        /// </summary>
        /// <param name="req"><see cref="DescribeUnHandleEventTabListRequest"/></param>
        /// <returns><see cref="DescribeUnHandleEventTabListResponse"/></returns>
        public DescribeUnHandleEventTabListResponse DescribeUnHandleEventTabListSync(DescribeUnHandleEventTabListRequest req)
        {
             JsonResponseModel<DescribeUnHandleEventTabListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUnHandleEventTabList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUnHandleEventTabListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// vpc规则列表概况
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcRuleOverviewRequest"/></param>
        /// <returns><see cref="DescribeVpcRuleOverviewResponse"/></returns>
        public async Task<DescribeVpcRuleOverviewResponse> DescribeVpcRuleOverview(DescribeVpcRuleOverviewRequest req)
        {
             JsonResponseModel<DescribeVpcRuleOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVpcRuleOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcRuleOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// vpc规则列表概况
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcRuleOverviewRequest"/></param>
        /// <returns><see cref="DescribeVpcRuleOverviewResponse"/></returns>
        public DescribeVpcRuleOverviewResponse DescribeVpcRuleOverviewSync(DescribeVpcRuleOverviewRequest req)
        {
             JsonResponseModel<DescribeVpcRuleOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVpcRuleOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVpcRuleOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 防火墙垂直扩容
        /// </summary>
        /// <param name="req"><see cref="ExpandCfwVerticalRequest"/></param>
        /// <returns><see cref="ExpandCfwVerticalResponse"/></returns>
        public async Task<ExpandCfwVerticalResponse> ExpandCfwVertical(ExpandCfwVerticalRequest req)
        {
             JsonResponseModel<ExpandCfwVerticalResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExpandCfwVertical");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExpandCfwVerticalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 防火墙垂直扩容
        /// </summary>
        /// <param name="req"><see cref="ExpandCfwVerticalRequest"/></param>
        /// <returns><see cref="ExpandCfwVerticalResponse"/></returns>
        public ExpandCfwVerticalResponse ExpandCfwVerticalSync(ExpandCfwVerticalRequest req)
        {
             JsonResponseModel<ExpandCfwVerticalResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExpandCfwVertical");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExpandCfwVerticalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改规则
        /// </summary>
        /// <param name="req"><see cref="ModifyAcRuleRequest"/></param>
        /// <returns><see cref="ModifyAcRuleResponse"/></returns>
        public async Task<ModifyAcRuleResponse> ModifyAcRule(ModifyAcRuleRequest req)
        {
             JsonResponseModel<ModifyAcRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAcRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAcRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改规则
        /// </summary>
        /// <param name="req"><see cref="ModifyAcRuleRequest"/></param>
        /// <returns><see cref="ModifyAcRuleResponse"/></returns>
        public ModifyAcRuleResponse ModifyAcRuleSync(ModifyAcRuleRequest req)
        {
             JsonResponseModel<ModifyAcRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAcRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAcRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启用停用全部规则
        /// </summary>
        /// <param name="req"><see cref="ModifyAllRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyAllRuleStatusResponse"/></returns>
        public async Task<ModifyAllRuleStatusResponse> ModifyAllRuleStatus(ModifyAllRuleStatusRequest req)
        {
             JsonResponseModel<ModifyAllRuleStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAllRuleStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAllRuleStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启用停用全部规则
        /// </summary>
        /// <param name="req"><see cref="ModifyAllRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyAllRuleStatusResponse"/></returns>
        public ModifyAllRuleStatusResponse ModifyAllRuleStatusSync(ModifyAllRuleStatusRequest req)
        {
             JsonResponseModel<ModifyAllRuleStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAllRuleStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAllRuleStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 一键开启和关闭
        /// </summary>
        /// <param name="req"><see cref="ModifyAllSwitchStatusRequest"/></param>
        /// <returns><see cref="ModifyAllSwitchStatusResponse"/></returns>
        public async Task<ModifyAllSwitchStatusResponse> ModifyAllSwitchStatus(ModifyAllSwitchStatusRequest req)
        {
             JsonResponseModel<ModifyAllSwitchStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAllSwitchStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAllSwitchStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 一键开启和关闭
        /// </summary>
        /// <param name="req"><see cref="ModifyAllSwitchStatusRequest"/></param>
        /// <returns><see cref="ModifyAllSwitchStatusResponse"/></returns>
        public ModifyAllSwitchStatusResponse ModifyAllSwitchStatusSync(ModifyAllSwitchStatusRequest req)
        {
             JsonResponseModel<ModifyAllSwitchStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAllSwitchStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAllSwitchStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 支持对拦截列表、忽略列表如下操作：
        /// 批量增加拦截IP、忽略IP/域名
        /// 批量删除拦截IP、忽略IP/域名
        /// 批量修改拦截IP、忽略IP/域名生效事件
        /// </summary>
        /// <param name="req"><see cref="ModifyBlockIgnoreListRequest"/></param>
        /// <returns><see cref="ModifyBlockIgnoreListResponse"/></returns>
        public async Task<ModifyBlockIgnoreListResponse> ModifyBlockIgnoreList(ModifyBlockIgnoreListRequest req)
        {
             JsonResponseModel<ModifyBlockIgnoreListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBlockIgnoreList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBlockIgnoreListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 支持对拦截列表、忽略列表如下操作：
        /// 批量增加拦截IP、忽略IP/域名
        /// 批量删除拦截IP、忽略IP/域名
        /// 批量修改拦截IP、忽略IP/域名生效事件
        /// </summary>
        /// <param name="req"><see cref="ModifyBlockIgnoreListRequest"/></param>
        /// <returns><see cref="ModifyBlockIgnoreListResponse"/></returns>
        public ModifyBlockIgnoreListResponse ModifyBlockIgnoreListSync(ModifyBlockIgnoreListRequest req)
        {
             JsonResponseModel<ModifyBlockIgnoreListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBlockIgnoreList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBlockIgnoreListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyBlockTop取消置顶接口
        /// </summary>
        /// <param name="req"><see cref="ModifyBlockTopRequest"/></param>
        /// <returns><see cref="ModifyBlockTopResponse"/></returns>
        public async Task<ModifyBlockTopResponse> ModifyBlockTop(ModifyBlockTopRequest req)
        {
             JsonResponseModel<ModifyBlockTopResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBlockTop");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBlockTopResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ModifyBlockTop取消置顶接口
        /// </summary>
        /// <param name="req"><see cref="ModifyBlockTopRequest"/></param>
        /// <returns><see cref="ModifyBlockTopResponse"/></returns>
        public ModifyBlockTopResponse ModifyBlockTopSync(ModifyBlockTopRequest req)
        {
             JsonResponseModel<ModifyBlockTopResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBlockTop");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBlockTopResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改单个防火墙开关
        /// </summary>
        /// <param name="req"><see cref="ModifyItemSwitchStatusRequest"/></param>
        /// <returns><see cref="ModifyItemSwitchStatusResponse"/></returns>
        public async Task<ModifyItemSwitchStatusResponse> ModifyItemSwitchStatus(ModifyItemSwitchStatusRequest req)
        {
             JsonResponseModel<ModifyItemSwitchStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyItemSwitchStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyItemSwitchStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改单个防火墙开关
        /// </summary>
        /// <param name="req"><see cref="ModifyItemSwitchStatusRequest"/></param>
        /// <returns><see cref="ModifyItemSwitchStatusResponse"/></returns>
        public ModifyItemSwitchStatusResponse ModifyItemSwitchStatusSync(ModifyItemSwitchStatusRequest req)
        {
             JsonResponseModel<ModifyItemSwitchStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyItemSwitchStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyItemSwitchStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启用停用全部规则
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupAllRuleStatusRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupAllRuleStatusResponse"/></returns>
        public async Task<ModifySecurityGroupAllRuleStatusResponse> ModifySecurityGroupAllRuleStatus(ModifySecurityGroupAllRuleStatusRequest req)
        {
             JsonResponseModel<ModifySecurityGroupAllRuleStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySecurityGroupAllRuleStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecurityGroupAllRuleStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启用停用全部规则
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupAllRuleStatusRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupAllRuleStatusResponse"/></returns>
        public ModifySecurityGroupAllRuleStatusResponse ModifySecurityGroupAllRuleStatusSync(ModifySecurityGroupAllRuleStatusRequest req)
        {
             JsonResponseModel<ModifySecurityGroupAllRuleStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySecurityGroupAllRuleStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecurityGroupAllRuleStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改规则执行顺序
        /// </summary>
        /// <param name="req"><see cref="ModifySequenceRulesRequest"/></param>
        /// <returns><see cref="ModifySequenceRulesResponse"/></returns>
        public async Task<ModifySequenceRulesResponse> ModifySequenceRules(ModifySequenceRulesRequest req)
        {
             JsonResponseModel<ModifySequenceRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySequenceRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySequenceRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改规则执行顺序
        /// </summary>
        /// <param name="req"><see cref="ModifySequenceRulesRequest"/></param>
        /// <returns><see cref="ModifySequenceRulesResponse"/></returns>
        public ModifySequenceRulesResponse ModifySequenceRulesSync(ModifySequenceRulesRequest req)
        {
             JsonResponseModel<ModifySequenceRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySequenceRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySequenceRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改规则表状态
        /// </summary>
        /// <param name="req"><see cref="ModifyTableStatusRequest"/></param>
        /// <returns><see cref="ModifyTableStatusResponse"/></returns>
        public async Task<ModifyTableStatusResponse> ModifyTableStatus(ModifyTableStatusRequest req)
        {
             JsonResponseModel<ModifyTableStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTableStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTableStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改规则表状态
        /// </summary>
        /// <param name="req"><see cref="ModifyTableStatusRequest"/></param>
        /// <returns><see cref="ModifyTableStatusResponse"/></returns>
        public ModifyTableStatusResponse ModifyTableStatusSync(ModifyTableStatusRequest req)
        {
             JsonResponseModel<ModifyTableStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTableStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTableStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 同步资产-互联网&VPC
        /// </summary>
        /// <param name="req"><see cref="RunSyncAssetRequest"/></param>
        /// <returns><see cref="RunSyncAssetResponse"/></returns>
        public async Task<RunSyncAssetResponse> RunSyncAsset(RunSyncAssetRequest req)
        {
             JsonResponseModel<RunSyncAssetResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RunSyncAsset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunSyncAssetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 同步资产-互联网&VPC
        /// </summary>
        /// <param name="req"><see cref="RunSyncAssetRequest"/></param>
        /// <returns><see cref="RunSyncAssetResponse"/></returns>
        public RunSyncAssetResponse RunSyncAssetSync(RunSyncAssetRequest req)
        {
             JsonResponseModel<RunSyncAssetResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RunSyncAsset");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RunSyncAssetResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 配置防火墙Dnat规则
        /// </summary>
        /// <param name="req"><see cref="SetNatFwDnatRuleRequest"/></param>
        /// <returns><see cref="SetNatFwDnatRuleResponse"/></returns>
        public async Task<SetNatFwDnatRuleResponse> SetNatFwDnatRule(SetNatFwDnatRuleRequest req)
        {
             JsonResponseModel<SetNatFwDnatRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetNatFwDnatRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetNatFwDnatRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 配置防火墙Dnat规则
        /// </summary>
        /// <param name="req"><see cref="SetNatFwDnatRuleRequest"/></param>
        /// <returns><see cref="SetNatFwDnatRuleResponse"/></returns>
        public SetNatFwDnatRuleResponse SetNatFwDnatRuleSync(SetNatFwDnatRuleRequest req)
        {
             JsonResponseModel<SetNatFwDnatRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetNatFwDnatRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetNatFwDnatRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}

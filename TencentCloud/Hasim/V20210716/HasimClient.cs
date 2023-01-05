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

namespace TencentCloud.Hasim.V20210716
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Hasim.V20210716.Models;

   public class HasimClient : AbstractClient{

       private const string endpoint = "hasim.tencentcloudapi.com";
       private const string version = "2021-07-16";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public HasimClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public HasimClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 创建自动化规则
        /// </summary>
        /// <param name="req"><see cref="CreateRuleRequest"/></param>
        /// <returns><see cref="CreateRuleResponse"/></returns>
        public async Task<CreateRuleResponse> CreateRule(CreateRuleRequest req)
        {
             JsonResponseModel<CreateRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建自动化规则
        /// </summary>
        /// <param name="req"><see cref="CreateRuleRequest"/></param>
        /// <returns><see cref="CreateRuleResponse"/></returns>
        public CreateRuleResponse CreateRuleSync(CreateRuleRequest req)
        {
             JsonResponseModel<CreateRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建云兔切换策略
        /// </summary>
        /// <param name="req"><see cref="CreateTacticRequest"/></param>
        /// <returns><see cref="CreateTacticResponse"/></returns>
        public async Task<CreateTacticResponse> CreateTactic(CreateTacticRequest req)
        {
             JsonResponseModel<CreateTacticResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTactic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTacticResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建云兔切换策略
        /// </summary>
        /// <param name="req"><see cref="CreateTacticRequest"/></param>
        /// <returns><see cref="CreateTacticResponse"/></returns>
        public CreateTacticResponse CreateTacticSync(CreateTacticRequest req)
        {
             JsonResponseModel<CreateTacticResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTactic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTacticResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建标签
        /// </summary>
        /// <param name="req"><see cref="CreateTagRequest"/></param>
        /// <returns><see cref="CreateTagResponse"/></returns>
        public async Task<CreateTagResponse> CreateTag(CreateTagRequest req)
        {
             JsonResponseModel<CreateTagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建标签
        /// </summary>
        /// <param name="req"><see cref="CreateTagRequest"/></param>
        /// <returns><see cref="CreateTagResponse"/></returns>
        public CreateTagResponse CreateTagSync(CreateTagRequest req)
        {
             JsonResponseModel<CreateTagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除自动化规则
        /// </summary>
        /// <param name="req"><see cref="DeleteRuleRequest"/></param>
        /// <returns><see cref="DeleteRuleResponse"/></returns>
        public async Task<DeleteRuleResponse> DeleteRule(DeleteRuleRequest req)
        {
             JsonResponseModel<DeleteRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除自动化规则
        /// </summary>
        /// <param name="req"><see cref="DeleteRuleRequest"/></param>
        /// <returns><see cref="DeleteRuleResponse"/></returns>
        public DeleteRuleResponse DeleteRuleSync(DeleteRuleRequest req)
        {
             JsonResponseModel<DeleteRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除策略
        /// </summary>
        /// <param name="req"><see cref="DeleteTacticRequest"/></param>
        /// <returns><see cref="DeleteTacticResponse"/></returns>
        public async Task<DeleteTacticResponse> DeleteTactic(DeleteTacticRequest req)
        {
             JsonResponseModel<DeleteTacticResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTactic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTacticResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除策略
        /// </summary>
        /// <param name="req"><see cref="DeleteTacticRequest"/></param>
        /// <returns><see cref="DeleteTacticResponse"/></returns>
        public DeleteTacticResponse DeleteTacticSync(DeleteTacticRequest req)
        {
             JsonResponseModel<DeleteTacticResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTactic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTacticResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除标签
        /// </summary>
        /// <param name="req"><see cref="DeleteTagRequest"/></param>
        /// <returns><see cref="DeleteTagResponse"/></returns>
        public async Task<DeleteTagResponse> DeleteTag(DeleteTagRequest req)
        {
             JsonResponseModel<DeleteTagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除标签
        /// </summary>
        /// <param name="req"><see cref="DeleteTagRequest"/></param>
        /// <returns><see cref="DeleteTagResponse"/></returns>
        public DeleteTagResponse DeleteTagSync(DeleteTagRequest req)
        {
             JsonResponseModel<DeleteTagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云兔连接详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeLinkRequest"/></param>
        /// <returns><see cref="DescribeLinkResponse"/></returns>
        public async Task<DescribeLinkResponse> DescribeLink(DescribeLinkRequest req)
        {
             JsonResponseModel<DescribeLinkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLink");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLinkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云兔连接详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeLinkRequest"/></param>
        /// <returns><see cref="DescribeLinkResponse"/></returns>
        public DescribeLinkResponse DescribeLinkSync(DescribeLinkRequest req)
        {
             JsonResponseModel<DescribeLinkResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLink");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLinkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云兔连接列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLinksRequest"/></param>
        /// <returns><see cref="DescribeLinksResponse"/></returns>
        public async Task<DescribeLinksResponse> DescribeLinks(DescribeLinksRequest req)
        {
             JsonResponseModel<DescribeLinksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLinks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLinksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云兔连接列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLinksRequest"/></param>
        /// <returns><see cref="DescribeLinksResponse"/></returns>
        public DescribeLinksResponse DescribeLinksSync(DescribeLinksRequest req)
        {
             JsonResponseModel<DescribeLinksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLinks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLinksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询订单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOrdersRequest"/></param>
        /// <returns><see cref="DescribeOrdersResponse"/></returns>
        public async Task<DescribeOrdersResponse> DescribeOrders(DescribeOrdersRequest req)
        {
             JsonResponseModel<DescribeOrdersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOrders");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOrdersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询订单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOrdersRequest"/></param>
        /// <returns><see cref="DescribeOrdersResponse"/></returns>
        public DescribeOrdersResponse DescribeOrdersSync(DescribeOrdersRequest req)
        {
             JsonResponseModel<DescribeOrdersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOrders");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOrdersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询自动化规则
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleRequest"/></param>
        /// <returns><see cref="DescribeRuleResponse"/></returns>
        public async Task<DescribeRuleResponse> DescribeRule(DescribeRuleRequest req)
        {
             JsonResponseModel<DescribeRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询自动化规则
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleRequest"/></param>
        /// <returns><see cref="DescribeRuleResponse"/></returns>
        public DescribeRuleResponse DescribeRuleSync(DescribeRuleRequest req)
        {
             JsonResponseModel<DescribeRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询自动化规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesRequest"/></param>
        /// <returns><see cref="DescribeRulesResponse"/></returns>
        public async Task<DescribeRulesResponse> DescribeRules(DescribeRulesRequest req)
        {
             JsonResponseModel<DescribeRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询自动化规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesRequest"/></param>
        /// <returns><see cref="DescribeRulesResponse"/></returns>
        public DescribeRulesResponse DescribeRulesSync(DescribeRulesRequest req)
        {
             JsonResponseModel<DescribeRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云兔切换策略信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTacticRequest"/></param>
        /// <returns><see cref="DescribeTacticResponse"/></returns>
        public async Task<DescribeTacticResponse> DescribeTactic(DescribeTacticRequest req)
        {
             JsonResponseModel<DescribeTacticResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTactic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTacticResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云兔切换策略信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTacticRequest"/></param>
        /// <returns><see cref="DescribeTacticResponse"/></returns>
        public DescribeTacticResponse DescribeTacticSync(DescribeTacticRequest req)
        {
             JsonResponseModel<DescribeTacticResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTactic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTacticResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云兔切换策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTacticsRequest"/></param>
        /// <returns><see cref="DescribeTacticsResponse"/></returns>
        public async Task<DescribeTacticsResponse> DescribeTactics(DescribeTacticsRequest req)
        {
             JsonResponseModel<DescribeTacticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTactics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTacticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云兔切换策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTacticsRequest"/></param>
        /// <returns><see cref="DescribeTacticsResponse"/></returns>
        public DescribeTacticsResponse DescribeTacticsSync(DescribeTacticsRequest req)
        {
             JsonResponseModel<DescribeTacticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTactics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTacticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询标签列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTagsRequest"/></param>
        /// <returns><see cref="DescribeTagsResponse"/></returns>
        public async Task<DescribeTagsResponse> DescribeTags(DescribeTagsRequest req)
        {
             JsonResponseModel<DescribeTagsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询标签列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTagsRequest"/></param>
        /// <returns><see cref="DescribeTagsResponse"/></returns>
        public DescribeTagsResponse DescribeTagsSync(DescribeTagsRequest req)
        {
             JsonResponseModel<DescribeTagsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑云兔高级日志状态
        /// </summary>
        /// <param name="req"><see cref="ModifyLinkAdvancedLogRequest"/></param>
        /// <returns><see cref="ModifyLinkAdvancedLogResponse"/></returns>
        public async Task<ModifyLinkAdvancedLogResponse> ModifyLinkAdvancedLog(ModifyLinkAdvancedLogRequest req)
        {
             JsonResponseModel<ModifyLinkAdvancedLogResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLinkAdvancedLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLinkAdvancedLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑云兔高级日志状态
        /// </summary>
        /// <param name="req"><see cref="ModifyLinkAdvancedLogRequest"/></param>
        /// <returns><see cref="ModifyLinkAdvancedLogResponse"/></returns>
        public ModifyLinkAdvancedLogResponse ModifyLinkAdvancedLogSync(ModifyLinkAdvancedLogRequest req)
        {
             JsonResponseModel<ModifyLinkAdvancedLogResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLinkAdvancedLog");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLinkAdvancedLogResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑云兔策略
        /// </summary>
        /// <param name="req"><see cref="ModifyLinkTacticRequest"/></param>
        /// <returns><see cref="ModifyLinkTacticResponse"/></returns>
        public async Task<ModifyLinkTacticResponse> ModifyLinkTactic(ModifyLinkTacticRequest req)
        {
             JsonResponseModel<ModifyLinkTacticResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLinkTactic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLinkTacticResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑云兔策略
        /// </summary>
        /// <param name="req"><see cref="ModifyLinkTacticRequest"/></param>
        /// <returns><see cref="ModifyLinkTacticResponse"/></returns>
        public ModifyLinkTacticResponse ModifyLinkTacticSync(ModifyLinkTacticRequest req)
        {
             JsonResponseModel<ModifyLinkTacticResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLinkTactic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLinkTacticResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改云兔运营商
        /// </summary>
        /// <param name="req"><see cref="ModifyLinkTeleRequest"/></param>
        /// <returns><see cref="ModifyLinkTeleResponse"/></returns>
        public async Task<ModifyLinkTeleResponse> ModifyLinkTele(ModifyLinkTeleRequest req)
        {
             JsonResponseModel<ModifyLinkTeleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLinkTele");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLinkTeleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改云兔运营商
        /// </summary>
        /// <param name="req"><see cref="ModifyLinkTeleRequest"/></param>
        /// <returns><see cref="ModifyLinkTeleResponse"/></returns>
        public ModifyLinkTeleResponse ModifyLinkTeleSync(ModifyLinkTeleRequest req)
        {
             JsonResponseModel<ModifyLinkTeleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLinkTele");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLinkTeleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑自动化规则
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleRequest"/></param>
        /// <returns><see cref="ModifyRuleResponse"/></returns>
        public async Task<ModifyRuleResponse> ModifyRule(ModifyRuleRequest req)
        {
             JsonResponseModel<ModifyRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑自动化规则
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleRequest"/></param>
        /// <returns><see cref="ModifyRuleResponse"/></returns>
        public ModifyRuleResponse ModifyRuleSync(ModifyRuleRequest req)
        {
             JsonResponseModel<ModifyRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑自动化规则状态
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyRuleStatusResponse"/></returns>
        public async Task<ModifyRuleStatusResponse> ModifyRuleStatus(ModifyRuleStatusRequest req)
        {
             JsonResponseModel<ModifyRuleStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRuleStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRuleStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑自动化规则状态
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyRuleStatusResponse"/></returns>
        public ModifyRuleStatusResponse ModifyRuleStatusSync(ModifyRuleStatusRequest req)
        {
             JsonResponseModel<ModifyRuleStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRuleStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRuleStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改云兔切换策略
        /// </summary>
        /// <param name="req"><see cref="ModifyTacticRequest"/></param>
        /// <returns><see cref="ModifyTacticResponse"/></returns>
        public async Task<ModifyTacticResponse> ModifyTactic(ModifyTacticRequest req)
        {
             JsonResponseModel<ModifyTacticResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTactic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTacticResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改云兔切换策略
        /// </summary>
        /// <param name="req"><see cref="ModifyTacticRequest"/></param>
        /// <returns><see cref="ModifyTacticResponse"/></returns>
        public ModifyTacticResponse ModifyTacticSync(ModifyTacticRequest req)
        {
             JsonResponseModel<ModifyTacticResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTactic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTacticResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑标签
        /// </summary>
        /// <param name="req"><see cref="ModifyTagRequest"/></param>
        /// <returns><see cref="ModifyTagResponse"/></returns>
        public async Task<ModifyTagResponse> ModifyTag(ModifyTagRequest req)
        {
             JsonResponseModel<ModifyTagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑标签
        /// </summary>
        /// <param name="req"><see cref="ModifyTagRequest"/></param>
        /// <returns><see cref="ModifyTagResponse"/></returns>
        public ModifyTagResponse ModifyTagSync(ModifyTagRequest req)
        {
             JsonResponseModel<ModifyTagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 刷新云兔连接信息同步
        /// </summary>
        /// <param name="req"><see cref="RenewLinkInfoRequest"/></param>
        /// <returns><see cref="RenewLinkInfoResponse"/></returns>
        public async Task<RenewLinkInfoResponse> RenewLinkInfo(RenewLinkInfoRequest req)
        {
             JsonResponseModel<RenewLinkInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RenewLinkInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewLinkInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 刷新云兔连接信息同步
        /// </summary>
        /// <param name="req"><see cref="RenewLinkInfoRequest"/></param>
        /// <returns><see cref="RenewLinkInfoResponse"/></returns>
        public RenewLinkInfoResponse RenewLinkInfoSync(RenewLinkInfoRequest req)
        {
             JsonResponseModel<RenewLinkInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RenewLinkInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewLinkInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}

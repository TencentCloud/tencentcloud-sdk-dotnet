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

namespace TencentCloud.Gpm.V20200820
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Gpm.V20200820.Models;

   public class GpmClient : AbstractClient{

       private const string endpoint = "gpm.tencentcloudapi.com";
       private const string version = "2020-08-20";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public GpmClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public GpmClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 取消匹配。
        /// </summary>
        /// <param name="req"><see cref="CancelMatchingRequest"/></param>
        /// <returns><see cref="CancelMatchingResponse"/></returns>
        public async Task<CancelMatchingResponse> CancelMatching(CancelMatchingRequest req)
        {
             JsonResponseModel<CancelMatchingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CancelMatching");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelMatchingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 取消匹配。
        /// </summary>
        /// <param name="req"><see cref="CancelMatchingRequest"/></param>
        /// <returns><see cref="CancelMatchingResponse"/></returns>
        public CancelMatchingResponse CancelMatchingSync(CancelMatchingRequest req)
        {
             JsonResponseModel<CancelMatchingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CancelMatching");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelMatchingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建匹配
        /// </summary>
        /// <param name="req"><see cref="CreateMatchRequest"/></param>
        /// <returns><see cref="CreateMatchResponse"/></returns>
        public async Task<CreateMatchResponse> CreateMatch(CreateMatchRequest req)
        {
             JsonResponseModel<CreateMatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateMatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建匹配
        /// </summary>
        /// <param name="req"><see cref="CreateMatchRequest"/></param>
        /// <returns><see cref="CreateMatchResponse"/></returns>
        public CreateMatchResponse CreateMatchSync(CreateMatchRequest req)
        {
             JsonResponseModel<CreateMatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateMatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMatchResponse>>(strResp);
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
        /// 创建规则
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
        /// 删除匹配
        /// </summary>
        /// <param name="req"><see cref="DeleteMatchRequest"/></param>
        /// <returns><see cref="DeleteMatchResponse"/></returns>
        public async Task<DeleteMatchResponse> DeleteMatch(DeleteMatchRequest req)
        {
             JsonResponseModel<DeleteMatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除匹配
        /// </summary>
        /// <param name="req"><see cref="DeleteMatchRequest"/></param>
        /// <returns><see cref="DeleteMatchResponse"/></returns>
        public DeleteMatchResponse DeleteMatchSync(DeleteMatchRequest req)
        {
             JsonResponseModel<DeleteMatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteMatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMatchResponse>>(strResp);
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
        /// 删除规则
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
        /// 统计数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDataRequest"/></param>
        /// <returns><see cref="DescribeDataResponse"/></returns>
        public async Task<DescribeDataResponse> DescribeData(DescribeDataRequest req)
        {
             JsonResponseModel<DescribeDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 统计数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDataRequest"/></param>
        /// <returns><see cref="DescribeDataResponse"/></returns>
        public DescribeDataResponse DescribeDataSync(DescribeDataRequest req)
        {
             JsonResponseModel<DescribeDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询匹配详情
        /// </summary>
        /// <param name="req"><see cref="DescribeMatchRequest"/></param>
        /// <returns><see cref="DescribeMatchResponse"/></returns>
        public async Task<DescribeMatchResponse> DescribeMatch(DescribeMatchRequest req)
        {
             JsonResponseModel<DescribeMatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询匹配详情
        /// </summary>
        /// <param name="req"><see cref="DescribeMatchRequest"/></param>
        /// <returns><see cref="DescribeMatchResponse"/></returns>
        public DescribeMatchResponse DescribeMatchSync(DescribeMatchRequest req)
        {
             JsonResponseModel<DescribeMatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 分页查询匹配Code
        /// </summary>
        /// <param name="req"><see cref="DescribeMatchCodesRequest"/></param>
        /// <returns><see cref="DescribeMatchCodesResponse"/></returns>
        public async Task<DescribeMatchCodesResponse> DescribeMatchCodes(DescribeMatchCodesRequest req)
        {
             JsonResponseModel<DescribeMatchCodesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMatchCodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMatchCodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 分页查询匹配Code
        /// </summary>
        /// <param name="req"><see cref="DescribeMatchCodesRequest"/></param>
        /// <returns><see cref="DescribeMatchCodesResponse"/></returns>
        public DescribeMatchCodesResponse DescribeMatchCodesSync(DescribeMatchCodesRequest req)
        {
             JsonResponseModel<DescribeMatchCodesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMatchCodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMatchCodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 分页查询匹配列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMatchesRequest"/></param>
        /// <returns><see cref="DescribeMatchesResponse"/></returns>
        public async Task<DescribeMatchesResponse> DescribeMatches(DescribeMatchesRequest req)
        {
             JsonResponseModel<DescribeMatchesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMatches");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMatchesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 分页查询匹配列表
        /// </summary>
        /// <param name="req"><see cref="DescribeMatchesRequest"/></param>
        /// <returns><see cref="DescribeMatchesResponse"/></returns>
        public DescribeMatchesResponse DescribeMatchesSync(DescribeMatchesRequest req)
        {
             JsonResponseModel<DescribeMatchesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMatches");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMatchesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询匹配进度。
        /// </summary>
        /// <param name="req"><see cref="DescribeMatchingProgressRequest"/></param>
        /// <returns><see cref="DescribeMatchingProgressResponse"/></returns>
        public async Task<DescribeMatchingProgressResponse> DescribeMatchingProgress(DescribeMatchingProgressRequest req)
        {
             JsonResponseModel<DescribeMatchingProgressResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMatchingProgress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMatchingProgressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询匹配进度。
        /// </summary>
        /// <param name="req"><see cref="DescribeMatchingProgressRequest"/></param>
        /// <returns><see cref="DescribeMatchingProgressResponse"/></returns>
        public DescribeMatchingProgressResponse DescribeMatchingProgressSync(DescribeMatchingProgressRequest req)
        {
             JsonResponseModel<DescribeMatchingProgressResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMatchingProgress");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMatchingProgressResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询规则详情
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
        /// 查询规则详情
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
        /// 分页查询规则集列表
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
        /// 分页查询规则集列表
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
        /// 查询匹配Token，Token用于push消息验证。
        /// </summary>
        /// <param name="req"><see cref="DescribeTokenRequest"/></param>
        /// <returns><see cref="DescribeTokenResponse"/></returns>
        public async Task<DescribeTokenResponse> DescribeToken(DescribeTokenRequest req)
        {
             JsonResponseModel<DescribeTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询匹配Token，Token用于push消息验证。
        /// </summary>
        /// <param name="req"><see cref="DescribeTokenRequest"/></param>
        /// <returns><see cref="DescribeTokenResponse"/></returns>
        public DescribeTokenResponse DescribeTokenSync(DescribeTokenRequest req)
        {
             JsonResponseModel<DescribeTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改匹配
        /// </summary>
        /// <param name="req"><see cref="ModifyMatchRequest"/></param>
        /// <returns><see cref="ModifyMatchResponse"/></returns>
        public async Task<ModifyMatchResponse> ModifyMatch(ModifyMatchRequest req)
        {
             JsonResponseModel<ModifyMatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改匹配
        /// </summary>
        /// <param name="req"><see cref="ModifyMatchRequest"/></param>
        /// <returns><see cref="ModifyMatchResponse"/></returns>
        public ModifyMatchResponse ModifyMatchSync(ModifyMatchRequest req)
        {
             JsonResponseModel<ModifyMatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改规则（描述、标签）
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
        /// 修改规则（描述、标签）
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
        /// 修改匹配Token。
        /// </summary>
        /// <param name="req"><see cref="ModifyTokenRequest"/></param>
        /// <returns><see cref="ModifyTokenResponse"/></returns>
        public async Task<ModifyTokenResponse> ModifyToken(ModifyTokenRequest req)
        {
             JsonResponseModel<ModifyTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改匹配Token。
        /// </summary>
        /// <param name="req"><see cref="ModifyTokenRequest"/></param>
        /// <returns><see cref="ModifyTokenResponse"/></returns>
        public ModifyTokenResponse ModifyTokenSync(ModifyTokenRequest req)
        {
             JsonResponseModel<ModifyTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 支持传入一个玩家或多个玩家发起匹配，在同一个请求内的玩家将被分到同一个对局。
        /// </summary>
        /// <param name="req"><see cref="StartMatchingRequest"/></param>
        /// <returns><see cref="StartMatchingResponse"/></returns>
        public async Task<StartMatchingResponse> StartMatching(StartMatchingRequest req)
        {
             JsonResponseModel<StartMatchingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartMatching");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartMatchingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 支持传入一个玩家或多个玩家发起匹配，在同一个请求内的玩家将被分到同一个对局。
        /// </summary>
        /// <param name="req"><see cref="StartMatchingRequest"/></param>
        /// <returns><see cref="StartMatchingResponse"/></returns>
        public StartMatchingResponse StartMatchingSync(StartMatchingRequest req)
        {
             JsonResponseModel<StartMatchingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartMatching");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartMatchingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}

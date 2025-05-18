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
       private const string sdkVersion = "SDK_NET_3.0.1241";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public HasimClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 创建自动化规则
        /// </summary>
        /// <param name="req"><see cref="CreateRuleRequest"/></param>
        /// <returns><see cref="CreateRuleResponse"/></returns>
        public Task<CreateRuleResponse> CreateRule(CreateRuleRequest req)
        {
            return InternalRequestAsync<CreateRuleResponse>(req, "CreateRule");
        }

        /// <summary>
        /// 创建自动化规则
        /// </summary>
        /// <param name="req"><see cref="CreateRuleRequest"/></param>
        /// <returns><see cref="CreateRuleResponse"/></returns>
        public CreateRuleResponse CreateRuleSync(CreateRuleRequest req)
        {
            return InternalRequestAsync<CreateRuleResponse>(req, "CreateRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建云兔切换策略
        /// </summary>
        /// <param name="req"><see cref="CreateTacticRequest"/></param>
        /// <returns><see cref="CreateTacticResponse"/></returns>
        public Task<CreateTacticResponse> CreateTactic(CreateTacticRequest req)
        {
            return InternalRequestAsync<CreateTacticResponse>(req, "CreateTactic");
        }

        /// <summary>
        /// 创建云兔切换策略
        /// </summary>
        /// <param name="req"><see cref="CreateTacticRequest"/></param>
        /// <returns><see cref="CreateTacticResponse"/></returns>
        public CreateTacticResponse CreateTacticSync(CreateTacticRequest req)
        {
            return InternalRequestAsync<CreateTacticResponse>(req, "CreateTactic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建标签
        /// </summary>
        /// <param name="req"><see cref="CreateTagRequest"/></param>
        /// <returns><see cref="CreateTagResponse"/></returns>
        public Task<CreateTagResponse> CreateTag(CreateTagRequest req)
        {
            return InternalRequestAsync<CreateTagResponse>(req, "CreateTag");
        }

        /// <summary>
        /// 创建标签
        /// </summary>
        /// <param name="req"><see cref="CreateTagRequest"/></param>
        /// <returns><see cref="CreateTagResponse"/></returns>
        public CreateTagResponse CreateTagSync(CreateTagRequest req)
        {
            return InternalRequestAsync<CreateTagResponse>(req, "CreateTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除自动化规则
        /// </summary>
        /// <param name="req"><see cref="DeleteRuleRequest"/></param>
        /// <returns><see cref="DeleteRuleResponse"/></returns>
        public Task<DeleteRuleResponse> DeleteRule(DeleteRuleRequest req)
        {
            return InternalRequestAsync<DeleteRuleResponse>(req, "DeleteRule");
        }

        /// <summary>
        /// 删除自动化规则
        /// </summary>
        /// <param name="req"><see cref="DeleteRuleRequest"/></param>
        /// <returns><see cref="DeleteRuleResponse"/></returns>
        public DeleteRuleResponse DeleteRuleSync(DeleteRuleRequest req)
        {
            return InternalRequestAsync<DeleteRuleResponse>(req, "DeleteRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除策略
        /// </summary>
        /// <param name="req"><see cref="DeleteTacticRequest"/></param>
        /// <returns><see cref="DeleteTacticResponse"/></returns>
        public Task<DeleteTacticResponse> DeleteTactic(DeleteTacticRequest req)
        {
            return InternalRequestAsync<DeleteTacticResponse>(req, "DeleteTactic");
        }

        /// <summary>
        /// 删除策略
        /// </summary>
        /// <param name="req"><see cref="DeleteTacticRequest"/></param>
        /// <returns><see cref="DeleteTacticResponse"/></returns>
        public DeleteTacticResponse DeleteTacticSync(DeleteTacticRequest req)
        {
            return InternalRequestAsync<DeleteTacticResponse>(req, "DeleteTactic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除标签
        /// </summary>
        /// <param name="req"><see cref="DeleteTagRequest"/></param>
        /// <returns><see cref="DeleteTagResponse"/></returns>
        public Task<DeleteTagResponse> DeleteTag(DeleteTagRequest req)
        {
            return InternalRequestAsync<DeleteTagResponse>(req, "DeleteTag");
        }

        /// <summary>
        /// 删除标签
        /// </summary>
        /// <param name="req"><see cref="DeleteTagRequest"/></param>
        /// <returns><see cref="DeleteTagResponse"/></returns>
        public DeleteTagResponse DeleteTagSync(DeleteTagRequest req)
        {
            return InternalRequestAsync<DeleteTagResponse>(req, "DeleteTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询云兔连接详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeLinkRequest"/></param>
        /// <returns><see cref="DescribeLinkResponse"/></returns>
        public Task<DescribeLinkResponse> DescribeLink(DescribeLinkRequest req)
        {
            return InternalRequestAsync<DescribeLinkResponse>(req, "DescribeLink");
        }

        /// <summary>
        /// 查询云兔连接详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeLinkRequest"/></param>
        /// <returns><see cref="DescribeLinkResponse"/></returns>
        public DescribeLinkResponse DescribeLinkSync(DescribeLinkRequest req)
        {
            return InternalRequestAsync<DescribeLinkResponse>(req, "DescribeLink")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询云兔连接列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLinksRequest"/></param>
        /// <returns><see cref="DescribeLinksResponse"/></returns>
        public Task<DescribeLinksResponse> DescribeLinks(DescribeLinksRequest req)
        {
            return InternalRequestAsync<DescribeLinksResponse>(req, "DescribeLinks");
        }

        /// <summary>
        /// 查询云兔连接列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLinksRequest"/></param>
        /// <returns><see cref="DescribeLinksResponse"/></returns>
        public DescribeLinksResponse DescribeLinksSync(DescribeLinksRequest req)
        {
            return InternalRequestAsync<DescribeLinksResponse>(req, "DescribeLinks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询订单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOrdersRequest"/></param>
        /// <returns><see cref="DescribeOrdersResponse"/></returns>
        public Task<DescribeOrdersResponse> DescribeOrders(DescribeOrdersRequest req)
        {
            return InternalRequestAsync<DescribeOrdersResponse>(req, "DescribeOrders");
        }

        /// <summary>
        /// 查询订单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOrdersRequest"/></param>
        /// <returns><see cref="DescribeOrdersResponse"/></returns>
        public DescribeOrdersResponse DescribeOrdersSync(DescribeOrdersRequest req)
        {
            return InternalRequestAsync<DescribeOrdersResponse>(req, "DescribeOrders")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询自动化规则
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleRequest"/></param>
        /// <returns><see cref="DescribeRuleResponse"/></returns>
        public Task<DescribeRuleResponse> DescribeRule(DescribeRuleRequest req)
        {
            return InternalRequestAsync<DescribeRuleResponse>(req, "DescribeRule");
        }

        /// <summary>
        /// 查询自动化规则
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleRequest"/></param>
        /// <returns><see cref="DescribeRuleResponse"/></returns>
        public DescribeRuleResponse DescribeRuleSync(DescribeRuleRequest req)
        {
            return InternalRequestAsync<DescribeRuleResponse>(req, "DescribeRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询自动化规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesRequest"/></param>
        /// <returns><see cref="DescribeRulesResponse"/></returns>
        public Task<DescribeRulesResponse> DescribeRules(DescribeRulesRequest req)
        {
            return InternalRequestAsync<DescribeRulesResponse>(req, "DescribeRules");
        }

        /// <summary>
        /// 查询自动化规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRulesRequest"/></param>
        /// <returns><see cref="DescribeRulesResponse"/></returns>
        public DescribeRulesResponse DescribeRulesSync(DescribeRulesRequest req)
        {
            return InternalRequestAsync<DescribeRulesResponse>(req, "DescribeRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询云兔切换策略信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTacticRequest"/></param>
        /// <returns><see cref="DescribeTacticResponse"/></returns>
        public Task<DescribeTacticResponse> DescribeTactic(DescribeTacticRequest req)
        {
            return InternalRequestAsync<DescribeTacticResponse>(req, "DescribeTactic");
        }

        /// <summary>
        /// 查询云兔切换策略信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTacticRequest"/></param>
        /// <returns><see cref="DescribeTacticResponse"/></returns>
        public DescribeTacticResponse DescribeTacticSync(DescribeTacticRequest req)
        {
            return InternalRequestAsync<DescribeTacticResponse>(req, "DescribeTactic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询云兔切换策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTacticsRequest"/></param>
        /// <returns><see cref="DescribeTacticsResponse"/></returns>
        public Task<DescribeTacticsResponse> DescribeTactics(DescribeTacticsRequest req)
        {
            return InternalRequestAsync<DescribeTacticsResponse>(req, "DescribeTactics");
        }

        /// <summary>
        /// 查询云兔切换策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTacticsRequest"/></param>
        /// <returns><see cref="DescribeTacticsResponse"/></returns>
        public DescribeTacticsResponse DescribeTacticsSync(DescribeTacticsRequest req)
        {
            return InternalRequestAsync<DescribeTacticsResponse>(req, "DescribeTactics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询标签列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTagsRequest"/></param>
        /// <returns><see cref="DescribeTagsResponse"/></returns>
        public Task<DescribeTagsResponse> DescribeTags(DescribeTagsRequest req)
        {
            return InternalRequestAsync<DescribeTagsResponse>(req, "DescribeTags");
        }

        /// <summary>
        /// 查询标签列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTagsRequest"/></param>
        /// <returns><see cref="DescribeTagsResponse"/></returns>
        public DescribeTagsResponse DescribeTagsSync(DescribeTagsRequest req)
        {
            return InternalRequestAsync<DescribeTagsResponse>(req, "DescribeTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑云兔高级日志状态
        /// </summary>
        /// <param name="req"><see cref="ModifyLinkAdvancedLogRequest"/></param>
        /// <returns><see cref="ModifyLinkAdvancedLogResponse"/></returns>
        public Task<ModifyLinkAdvancedLogResponse> ModifyLinkAdvancedLog(ModifyLinkAdvancedLogRequest req)
        {
            return InternalRequestAsync<ModifyLinkAdvancedLogResponse>(req, "ModifyLinkAdvancedLog");
        }

        /// <summary>
        /// 编辑云兔高级日志状态
        /// </summary>
        /// <param name="req"><see cref="ModifyLinkAdvancedLogRequest"/></param>
        /// <returns><see cref="ModifyLinkAdvancedLogResponse"/></returns>
        public ModifyLinkAdvancedLogResponse ModifyLinkAdvancedLogSync(ModifyLinkAdvancedLogRequest req)
        {
            return InternalRequestAsync<ModifyLinkAdvancedLogResponse>(req, "ModifyLinkAdvancedLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑云兔策略
        /// </summary>
        /// <param name="req"><see cref="ModifyLinkTacticRequest"/></param>
        /// <returns><see cref="ModifyLinkTacticResponse"/></returns>
        public Task<ModifyLinkTacticResponse> ModifyLinkTactic(ModifyLinkTacticRequest req)
        {
            return InternalRequestAsync<ModifyLinkTacticResponse>(req, "ModifyLinkTactic");
        }

        /// <summary>
        /// 编辑云兔策略
        /// </summary>
        /// <param name="req"><see cref="ModifyLinkTacticRequest"/></param>
        /// <returns><see cref="ModifyLinkTacticResponse"/></returns>
        public ModifyLinkTacticResponse ModifyLinkTacticSync(ModifyLinkTacticRequest req)
        {
            return InternalRequestAsync<ModifyLinkTacticResponse>(req, "ModifyLinkTactic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改云兔运营商
        /// </summary>
        /// <param name="req"><see cref="ModifyLinkTeleRequest"/></param>
        /// <returns><see cref="ModifyLinkTeleResponse"/></returns>
        public Task<ModifyLinkTeleResponse> ModifyLinkTele(ModifyLinkTeleRequest req)
        {
            return InternalRequestAsync<ModifyLinkTeleResponse>(req, "ModifyLinkTele");
        }

        /// <summary>
        /// 修改云兔运营商
        /// </summary>
        /// <param name="req"><see cref="ModifyLinkTeleRequest"/></param>
        /// <returns><see cref="ModifyLinkTeleResponse"/></returns>
        public ModifyLinkTeleResponse ModifyLinkTeleSync(ModifyLinkTeleRequest req)
        {
            return InternalRequestAsync<ModifyLinkTeleResponse>(req, "ModifyLinkTele")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑自动化规则
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleRequest"/></param>
        /// <returns><see cref="ModifyRuleResponse"/></returns>
        public Task<ModifyRuleResponse> ModifyRule(ModifyRuleRequest req)
        {
            return InternalRequestAsync<ModifyRuleResponse>(req, "ModifyRule");
        }

        /// <summary>
        /// 编辑自动化规则
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleRequest"/></param>
        /// <returns><see cref="ModifyRuleResponse"/></returns>
        public ModifyRuleResponse ModifyRuleSync(ModifyRuleRequest req)
        {
            return InternalRequestAsync<ModifyRuleResponse>(req, "ModifyRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑自动化规则状态
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyRuleStatusResponse"/></returns>
        public Task<ModifyRuleStatusResponse> ModifyRuleStatus(ModifyRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyRuleStatusResponse>(req, "ModifyRuleStatus");
        }

        /// <summary>
        /// 编辑自动化规则状态
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyRuleStatusResponse"/></returns>
        public ModifyRuleStatusResponse ModifyRuleStatusSync(ModifyRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyRuleStatusResponse>(req, "ModifyRuleStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改云兔切换策略
        /// </summary>
        /// <param name="req"><see cref="ModifyTacticRequest"/></param>
        /// <returns><see cref="ModifyTacticResponse"/></returns>
        public Task<ModifyTacticResponse> ModifyTactic(ModifyTacticRequest req)
        {
            return InternalRequestAsync<ModifyTacticResponse>(req, "ModifyTactic");
        }

        /// <summary>
        /// 修改云兔切换策略
        /// </summary>
        /// <param name="req"><see cref="ModifyTacticRequest"/></param>
        /// <returns><see cref="ModifyTacticResponse"/></returns>
        public ModifyTacticResponse ModifyTacticSync(ModifyTacticRequest req)
        {
            return InternalRequestAsync<ModifyTacticResponse>(req, "ModifyTactic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑标签
        /// </summary>
        /// <param name="req"><see cref="ModifyTagRequest"/></param>
        /// <returns><see cref="ModifyTagResponse"/></returns>
        public Task<ModifyTagResponse> ModifyTag(ModifyTagRequest req)
        {
            return InternalRequestAsync<ModifyTagResponse>(req, "ModifyTag");
        }

        /// <summary>
        /// 编辑标签
        /// </summary>
        /// <param name="req"><see cref="ModifyTagRequest"/></param>
        /// <returns><see cref="ModifyTagResponse"/></returns>
        public ModifyTagResponse ModifyTagSync(ModifyTagRequest req)
        {
            return InternalRequestAsync<ModifyTagResponse>(req, "ModifyTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 刷新云兔连接信息同步
        /// </summary>
        /// <param name="req"><see cref="RenewLinkInfoRequest"/></param>
        /// <returns><see cref="RenewLinkInfoResponse"/></returns>
        public Task<RenewLinkInfoResponse> RenewLinkInfo(RenewLinkInfoRequest req)
        {
            return InternalRequestAsync<RenewLinkInfoResponse>(req, "RenewLinkInfo");
        }

        /// <summary>
        /// 刷新云兔连接信息同步
        /// </summary>
        /// <param name="req"><see cref="RenewLinkInfoRequest"/></param>
        /// <returns><see cref="RenewLinkInfoResponse"/></returns>
        public RenewLinkInfoResponse RenewLinkInfoSync(RenewLinkInfoRequest req)
        {
            return InternalRequestAsync<RenewLinkInfoResponse>(req, "RenewLinkInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}

/*
 * Copyright (c) 2018 Tencent. All Rights Reserved.
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

namespace TencentCloud.Fwm.V20250611
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Fwm.V20250611.Models;

   public class FwmClient : AbstractClient{

       private const string endpoint = "fwm.tencentcloudapi.com";
       private const string version = "2025-06-11";
       private const string sdkVersion = "SDK_NET_3.0.1461";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public FwmClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public FwmClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 取消忽略策略风险
        /// </summary>
        /// <param name="req"><see cref="CancelIgnorePolicyRiskRequest"/></param>
        /// <returns><see cref="CancelIgnorePolicyRiskResponse"/></returns>
        public Task<CancelIgnorePolicyRiskResponse> CancelIgnorePolicyRisk(CancelIgnorePolicyRiskRequest req)
        {
            return InternalRequestAsync<CancelIgnorePolicyRiskResponse>(req, "CancelIgnorePolicyRisk");
        }

        /// <summary>
        /// 取消忽略策略风险
        /// </summary>
        /// <param name="req"><see cref="CancelIgnorePolicyRiskRequest"/></param>
        /// <returns><see cref="CancelIgnorePolicyRiskResponse"/></returns>
        public CancelIgnorePolicyRiskResponse CancelIgnorePolicyRiskSync(CancelIgnorePolicyRiskRequest req)
        {
            return InternalRequestAsync<CancelIgnorePolicyRiskResponse>(req, "CancelIgnorePolicyRisk")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建策略风险分析任务
        /// </summary>
        /// <param name="req"><see cref="CreateAnalyzePolicyTaskRequest"/></param>
        /// <returns><see cref="CreateAnalyzePolicyTaskResponse"/></returns>
        public Task<CreateAnalyzePolicyTaskResponse> CreateAnalyzePolicyTask(CreateAnalyzePolicyTaskRequest req)
        {
            return InternalRequestAsync<CreateAnalyzePolicyTaskResponse>(req, "CreateAnalyzePolicyTask");
        }

        /// <summary>
        /// 创建策略风险分析任务
        /// </summary>
        /// <param name="req"><see cref="CreateAnalyzePolicyTaskRequest"/></param>
        /// <returns><see cref="CreateAnalyzePolicyTaskResponse"/></returns>
        public CreateAnalyzePolicyTaskResponse CreateAnalyzePolicyTaskSync(CreateAnalyzePolicyTaskRequest req)
        {
            return InternalRequestAsync<CreateAnalyzePolicyTaskResponse>(req, "CreateAnalyzePolicyTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 向已有的互联网边界ACL规则组中添加规则。需要先创建规则组，然后通过此接口添加规则。
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeAclRuleRequest"/></param>
        /// <returns><see cref="CreateEdgeAclRuleResponse"/></returns>
        public Task<CreateEdgeAclRuleResponse> CreateEdgeAclRule(CreateEdgeAclRuleRequest req)
        {
            return InternalRequestAsync<CreateEdgeAclRuleResponse>(req, "CreateEdgeAclRule");
        }

        /// <summary>
        /// 向已有的互联网边界ACL规则组中添加规则。需要先创建规则组，然后通过此接口添加规则。
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeAclRuleRequest"/></param>
        /// <returns><see cref="CreateEdgeAclRuleResponse"/></returns>
        public CreateEdgeAclRuleResponse CreateEdgeAclRuleSync(CreateEdgeAclRuleRequest req)
        {
            return InternalRequestAsync<CreateEdgeAclRuleResponse>(req, "CreateEdgeAclRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建互联网边界ACL规则组，支持同时创建多条规则。Product 必须为 cfw_edge_acl。规则支持 IP、域名、参数模板、实例、标签等多种源/目标类型。
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeAclRuleGroupRequest"/></param>
        /// <returns><see cref="CreateEdgeAclRuleGroupResponse"/></returns>
        public Task<CreateEdgeAclRuleGroupResponse> CreateEdgeAclRuleGroup(CreateEdgeAclRuleGroupRequest req)
        {
            return InternalRequestAsync<CreateEdgeAclRuleGroupResponse>(req, "CreateEdgeAclRuleGroup");
        }

        /// <summary>
        /// 创建互联网边界ACL规则组，支持同时创建多条规则。Product 必须为 cfw_edge_acl。规则支持 IP、域名、参数模板、实例、标签等多种源/目标类型。
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeAclRuleGroupRequest"/></param>
        /// <returns><see cref="CreateEdgeAclRuleGroupResponse"/></returns>
        public CreateEdgeAclRuleGroupResponse CreateEdgeAclRuleGroupSync(CreateEdgeAclRuleGroupRequest req)
        {
            return InternalRequestAsync<CreateEdgeAclRuleGroupResponse>(req, "CreateEdgeAclRuleGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在已有规则组中添加NAT ACL规则
        /// </summary>
        /// <param name="req"><see cref="CreateNatAclRuleRequest"/></param>
        /// <returns><see cref="CreateNatAclRuleResponse"/></returns>
        public Task<CreateNatAclRuleResponse> CreateNatAclRule(CreateNatAclRuleRequest req)
        {
            return InternalRequestAsync<CreateNatAclRuleResponse>(req, "CreateNatAclRule");
        }

        /// <summary>
        /// 在已有规则组中添加NAT ACL规则
        /// </summary>
        /// <param name="req"><see cref="CreateNatAclRuleRequest"/></param>
        /// <returns><see cref="CreateNatAclRuleResponse"/></returns>
        public CreateNatAclRuleResponse CreateNatAclRuleSync(CreateNatAclRuleRequest req)
        {
            return InternalRequestAsync<CreateNatAclRuleResponse>(req, "CreateNatAclRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建NAT ACL规则组（NAT边界防火墙规则组管理）
        /// </summary>
        /// <param name="req"><see cref="CreateNatAclRuleGroupRequest"/></param>
        /// <returns><see cref="CreateNatAclRuleGroupResponse"/></returns>
        public Task<CreateNatAclRuleGroupResponse> CreateNatAclRuleGroup(CreateNatAclRuleGroupRequest req)
        {
            return InternalRequestAsync<CreateNatAclRuleGroupResponse>(req, "CreateNatAclRuleGroup");
        }

        /// <summary>
        /// 创建NAT ACL规则组（NAT边界防火墙规则组管理）
        /// </summary>
        /// <param name="req"><see cref="CreateNatAclRuleGroupRequest"/></param>
        /// <returns><see cref="CreateNatAclRuleGroupResponse"/></returns>
        public CreateNatAclRuleGroupResponse CreateNatAclRuleGroupSync(CreateNatAclRuleGroupRequest req)
        {
            return InternalRequestAsync<CreateNatAclRuleGroupResponse>(req, "CreateNatAclRuleGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 规则组编辑时添加规则（规则组管理）
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityGroupRuleRequest"/></param>
        /// <returns><see cref="CreateSecurityGroupRuleResponse"/></returns>
        public Task<CreateSecurityGroupRuleResponse> CreateSecurityGroupRule(CreateSecurityGroupRuleRequest req)
        {
            return InternalRequestAsync<CreateSecurityGroupRuleResponse>(req, "CreateSecurityGroupRule");
        }

        /// <summary>
        /// 规则组编辑时添加规则（规则组管理）
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityGroupRuleRequest"/></param>
        /// <returns><see cref="CreateSecurityGroupRuleResponse"/></returns>
        public CreateSecurityGroupRuleResponse CreateSecurityGroupRuleSync(CreateSecurityGroupRuleRequest req)
        {
            return InternalRequestAsync<CreateSecurityGroupRuleResponse>(req, "CreateSecurityGroupRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建规则组（规则组管理）
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityGroupRuleGroupRequest"/></param>
        /// <returns><see cref="CreateSecurityGroupRuleGroupResponse"/></returns>
        public Task<CreateSecurityGroupRuleGroupResponse> CreateSecurityGroupRuleGroup(CreateSecurityGroupRuleGroupRequest req)
        {
            return InternalRequestAsync<CreateSecurityGroupRuleGroupResponse>(req, "CreateSecurityGroupRuleGroup");
        }

        /// <summary>
        /// 创建规则组（规则组管理）
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityGroupRuleGroupRequest"/></param>
        /// <returns><see cref="CreateSecurityGroupRuleGroupResponse"/></returns>
        public CreateSecurityGroupRuleGroupResponse CreateSecurityGroupRuleGroupSync(CreateSecurityGroupRuleGroupRequest req)
        {
            return InternalRequestAsync<CreateSecurityGroupRuleGroupResponse>(req, "CreateSecurityGroupRuleGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建策略
        /// </summary>
        /// <param name="req"><see cref="CreateStrategyRequest"/></param>
        /// <returns><see cref="CreateStrategyResponse"/></returns>
        public Task<CreateStrategyResponse> CreateStrategy(CreateStrategyRequest req)
        {
            return InternalRequestAsync<CreateStrategyResponse>(req, "CreateStrategy");
        }

        /// <summary>
        /// 创建策略
        /// </summary>
        /// <param name="req"><see cref="CreateStrategyRequest"/></param>
        /// <returns><see cref="CreateStrategyResponse"/></returns>
        public CreateStrategyResponse CreateStrategySync(CreateStrategyRequest req)
        {
            return InternalRequestAsync<CreateStrategyResponse>(req, "CreateStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 在已有规则组中添加VPC ACL规则
        /// </summary>
        /// <param name="req"><see cref="CreateVpcAclRuleRequest"/></param>
        /// <returns><see cref="CreateVpcAclRuleResponse"/></returns>
        public Task<CreateVpcAclRuleResponse> CreateVpcAclRule(CreateVpcAclRuleRequest req)
        {
            return InternalRequestAsync<CreateVpcAclRuleResponse>(req, "CreateVpcAclRule");
        }

        /// <summary>
        /// 在已有规则组中添加VPC ACL规则
        /// </summary>
        /// <param name="req"><see cref="CreateVpcAclRuleRequest"/></param>
        /// <returns><see cref="CreateVpcAclRuleResponse"/></returns>
        public CreateVpcAclRuleResponse CreateVpcAclRuleSync(CreateVpcAclRuleRequest req)
        {
            return InternalRequestAsync<CreateVpcAclRuleResponse>(req, "CreateVpcAclRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建VPC ACL规则组（VPC间防火墙规则组管理）
        /// </summary>
        /// <param name="req"><see cref="CreateVpcAclRuleGroupRequest"/></param>
        /// <returns><see cref="CreateVpcAclRuleGroupResponse"/></returns>
        public Task<CreateVpcAclRuleGroupResponse> CreateVpcAclRuleGroup(CreateVpcAclRuleGroupRequest req)
        {
            return InternalRequestAsync<CreateVpcAclRuleGroupResponse>(req, "CreateVpcAclRuleGroup");
        }

        /// <summary>
        /// 创建VPC ACL规则组（VPC间防火墙规则组管理）
        /// </summary>
        /// <param name="req"><see cref="CreateVpcAclRuleGroupRequest"/></param>
        /// <returns><see cref="CreateVpcAclRuleGroupResponse"/></returns>
        public CreateVpcAclRuleGroupResponse CreateVpcAclRuleGroupSync(CreateVpcAclRuleGroupRequest req)
        {
            return InternalRequestAsync<CreateVpcAclRuleGroupResponse>(req, "CreateVpcAclRuleGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量删除互联网边界ACL规则。支持一次删除多条规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeAclRuleRequest"/></param>
        /// <returns><see cref="DeleteEdgeAclRuleResponse"/></returns>
        public Task<DeleteEdgeAclRuleResponse> DeleteEdgeAclRule(DeleteEdgeAclRuleRequest req)
        {
            return InternalRequestAsync<DeleteEdgeAclRuleResponse>(req, "DeleteEdgeAclRule");
        }

        /// <summary>
        /// 批量删除互联网边界ACL规则。支持一次删除多条规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeAclRuleRequest"/></param>
        /// <returns><see cref="DeleteEdgeAclRuleResponse"/></returns>
        public DeleteEdgeAclRuleResponse DeleteEdgeAclRuleSync(DeleteEdgeAclRuleRequest req)
        {
            return InternalRequestAsync<DeleteEdgeAclRuleResponse>(req, "DeleteEdgeAclRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除NAT ACL规则
        /// </summary>
        /// <param name="req"><see cref="DeleteNatAclRuleRequest"/></param>
        /// <returns><see cref="DeleteNatAclRuleResponse"/></returns>
        public Task<DeleteNatAclRuleResponse> DeleteNatAclRule(DeleteNatAclRuleRequest req)
        {
            return InternalRequestAsync<DeleteNatAclRuleResponse>(req, "DeleteNatAclRule");
        }

        /// <summary>
        /// 删除NAT ACL规则
        /// </summary>
        /// <param name="req"><see cref="DeleteNatAclRuleRequest"/></param>
        /// <returns><see cref="DeleteNatAclRuleResponse"/></returns>
        public DeleteNatAclRuleResponse DeleteNatAclRuleSync(DeleteNatAclRuleRequest req)
        {
            return InternalRequestAsync<DeleteNatAclRuleResponse>(req, "DeleteNatAclRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除规则组
        /// </summary>
        /// <param name="req"><see cref="DeleteRuleGroupRequest"/></param>
        /// <returns><see cref="DeleteRuleGroupResponse"/></returns>
        public Task<DeleteRuleGroupResponse> DeleteRuleGroup(DeleteRuleGroupRequest req)
        {
            return InternalRequestAsync<DeleteRuleGroupResponse>(req, "DeleteRuleGroup");
        }

        /// <summary>
        /// 删除规则组
        /// </summary>
        /// <param name="req"><see cref="DeleteRuleGroupRequest"/></param>
        /// <returns><see cref="DeleteRuleGroupResponse"/></returns>
        public DeleteRuleGroupResponse DeleteRuleGroupSync(DeleteRuleGroupRequest req)
        {
            return InternalRequestAsync<DeleteRuleGroupResponse>(req, "DeleteRuleGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除规则（规则组管理）
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityGroupRuleRequest"/></param>
        /// <returns><see cref="DeleteSecurityGroupRuleResponse"/></returns>
        public Task<DeleteSecurityGroupRuleResponse> DeleteSecurityGroupRule(DeleteSecurityGroupRuleRequest req)
        {
            return InternalRequestAsync<DeleteSecurityGroupRuleResponse>(req, "DeleteSecurityGroupRule");
        }

        /// <summary>
        /// 删除规则（规则组管理）
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityGroupRuleRequest"/></param>
        /// <returns><see cref="DeleteSecurityGroupRuleResponse"/></returns>
        public DeleteSecurityGroupRuleResponse DeleteSecurityGroupRuleSync(DeleteSecurityGroupRuleRequest req)
        {
            return InternalRequestAsync<DeleteSecurityGroupRuleResponse>(req, "DeleteSecurityGroupRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除策略
        /// </summary>
        /// <param name="req"><see cref="DeleteStrategyRequest"/></param>
        /// <returns><see cref="DeleteStrategyResponse"/></returns>
        public Task<DeleteStrategyResponse> DeleteStrategy(DeleteStrategyRequest req)
        {
            return InternalRequestAsync<DeleteStrategyResponse>(req, "DeleteStrategy");
        }

        /// <summary>
        /// 删除策略
        /// </summary>
        /// <param name="req"><see cref="DeleteStrategyRequest"/></param>
        /// <returns><see cref="DeleteStrategyResponse"/></returns>
        public DeleteStrategyResponse DeleteStrategySync(DeleteStrategyRequest req)
        {
            return InternalRequestAsync<DeleteStrategyResponse>(req, "DeleteStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除VPC ACL规则
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcAclRuleRequest"/></param>
        /// <returns><see cref="DeleteVpcAclRuleResponse"/></returns>
        public Task<DeleteVpcAclRuleResponse> DeleteVpcAclRule(DeleteVpcAclRuleRequest req)
        {
            return InternalRequestAsync<DeleteVpcAclRuleResponse>(req, "DeleteVpcAclRule");
        }

        /// <summary>
        /// 删除VPC ACL规则
        /// </summary>
        /// <param name="req"><see cref="DeleteVpcAclRuleRequest"/></param>
        /// <returns><see cref="DeleteVpcAclRuleResponse"/></returns>
        public DeleteVpcAclRuleResponse DeleteVpcAclRuleSync(DeleteVpcAclRuleRequest req)
        {
            return InternalRequestAsync<DeleteVpcAclRuleResponse>(req, "DeleteVpcAclRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定规则组下的互联网边界ACL规则列表。支持分页和多种过滤条件。
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeAclRulesRequest"/></param>
        /// <returns><see cref="DescribeEdgeAclRulesResponse"/></returns>
        public Task<DescribeEdgeAclRulesResponse> DescribeEdgeAclRules(DescribeEdgeAclRulesRequest req)
        {
            return InternalRequestAsync<DescribeEdgeAclRulesResponse>(req, "DescribeEdgeAclRules");
        }

        /// <summary>
        /// 查询指定规则组下的互联网边界ACL规则列表。支持分页和多种过滤条件。
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeAclRulesRequest"/></param>
        /// <returns><see cref="DescribeEdgeAclRulesResponse"/></returns>
        public DescribeEdgeAclRulesResponse DescribeEdgeAclRulesSync(DescribeEdgeAclRulesRequest req)
        {
            return InternalRequestAsync<DescribeEdgeAclRulesResponse>(req, "DescribeEdgeAclRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询NAT ACL规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNatAclRulesRequest"/></param>
        /// <returns><see cref="DescribeNatAclRulesResponse"/></returns>
        public Task<DescribeNatAclRulesResponse> DescribeNatAclRules(DescribeNatAclRulesRequest req)
        {
            return InternalRequestAsync<DescribeNatAclRulesResponse>(req, "DescribeNatAclRules");
        }

        /// <summary>
        /// 查询NAT ACL规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNatAclRulesRequest"/></param>
        /// <returns><see cref="DescribeNatAclRulesResponse"/></returns>
        public DescribeNatAclRulesResponse DescribeNatAclRulesSync(DescribeNatAclRulesRequest req)
        {
            return InternalRequestAsync<DescribeNatAclRulesResponse>(req, "DescribeNatAclRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集团下所有纳管成员账号列表，支持分页、排序和多条件筛选，仅管理员可调用
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganMembersRequest"/></param>
        /// <returns><see cref="DescribeOrganMembersResponse"/></returns>
        public Task<DescribeOrganMembersResponse> DescribeOrganMembers(DescribeOrganMembersRequest req)
        {
            return InternalRequestAsync<DescribeOrganMembersResponse>(req, "DescribeOrganMembers");
        }

        /// <summary>
        /// 查询集团下所有纳管成员账号列表，支持分页、排序和多条件筛选，仅管理员可调用
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganMembersRequest"/></param>
        /// <returns><see cref="DescribeOrganMembersResponse"/></returns>
        public DescribeOrganMembersResponse DescribeOrganMembersSync(DescribeOrganMembersRequest req)
        {
            return InternalRequestAsync<DescribeOrganMembersResponse>(req, "DescribeOrganMembers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取集团概览信息，包括集团名称、管理员信息、成员数量等
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganSummaryRequest"/></param>
        /// <returns><see cref="DescribeOrganSummaryResponse"/></returns>
        public Task<DescribeOrganSummaryResponse> DescribeOrganSummary(DescribeOrganSummaryRequest req)
        {
            return InternalRequestAsync<DescribeOrganSummaryResponse>(req, "DescribeOrganSummary");
        }

        /// <summary>
        /// 获取集团概览信息，包括集团名称、管理员信息、成员数量等
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganSummaryRequest"/></param>
        /// <returns><see cref="DescribeOrganSummaryResponse"/></returns>
        public DescribeOrganSummaryResponse DescribeOrganSummarySync(DescribeOrganSummaryRequest req)
        {
            return InternalRequestAsync<DescribeOrganSummaryResponse>(req, "DescribeOrganSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询账号+产品维度风险统计，按账号分组返回各产品的体检策略数、待整改风险数、整改率、最近体检时间等信息，支持按账号名称/ID搜索以及仅看待整改、仅超时未体检筛选
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyRiskAccountProductStatsRequest"/></param>
        /// <returns><see cref="DescribePolicyRiskAccountProductStatsResponse"/></returns>
        public Task<DescribePolicyRiskAccountProductStatsResponse> DescribePolicyRiskAccountProductStats(DescribePolicyRiskAccountProductStatsRequest req)
        {
            return InternalRequestAsync<DescribePolicyRiskAccountProductStatsResponse>(req, "DescribePolicyRiskAccountProductStats");
        }

        /// <summary>
        /// 查询账号+产品维度风险统计，按账号分组返回各产品的体检策略数、待整改风险数、整改率、最近体检时间等信息，支持按账号名称/ID搜索以及仅看待整改、仅超时未体检筛选
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyRiskAccountProductStatsRequest"/></param>
        /// <returns><see cref="DescribePolicyRiskAccountProductStatsResponse"/></returns>
        public DescribePolicyRiskAccountProductStatsResponse DescribePolicyRiskAccountProductStatsSync(DescribePolicyRiskAccountProductStatsRequest req)
        {
            return InternalRequestAsync<DescribePolicyRiskAccountProductStatsResponse>(req, "DescribePolicyRiskAccountProductStats")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取实时分析风险详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskAnalysisDetailsRequest"/></param>
        /// <returns><see cref="DescribeRiskAnalysisDetailsResponse"/></returns>
        public Task<DescribeRiskAnalysisDetailsResponse> DescribeRiskAnalysisDetails(DescribeRiskAnalysisDetailsRequest req)
        {
            return InternalRequestAsync<DescribeRiskAnalysisDetailsResponse>(req, "DescribeRiskAnalysisDetails");
        }

        /// <summary>
        /// 获取实时分析风险详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskAnalysisDetailsRequest"/></param>
        /// <returns><see cref="DescribeRiskAnalysisDetailsResponse"/></returns>
        public DescribeRiskAnalysisDetailsResponse DescribeRiskAnalysisDetailsSync(DescribeRiskAnalysisDetailsRequest req)
        {
            return InternalRequestAsync<DescribeRiskAnalysisDetailsResponse>(req, "DescribeRiskAnalysisDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询策略体检风险分类统计数据,包含各类风险的规则数量、处置状态、整改率等信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCategoryStatsRequest"/></param>
        /// <returns><see cref="DescribeRiskCategoryStatsResponse"/></returns>
        public Task<DescribeRiskCategoryStatsResponse> DescribeRiskCategoryStats(DescribeRiskCategoryStatsRequest req)
        {
            return InternalRequestAsync<DescribeRiskCategoryStatsResponse>(req, "DescribeRiskCategoryStats");
        }

        /// <summary>
        /// 查询策略体检风险分类统计数据,包含各类风险的规则数量、处置状态、整改率等信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCategoryStatsRequest"/></param>
        /// <returns><see cref="DescribeRiskCategoryStatsResponse"/></returns>
        public DescribeRiskCategoryStatsResponse DescribeRiskCategoryStatsSync(DescribeRiskCategoryStatsRequest req)
        {
            return InternalRequestAsync<DescribeRiskCategoryStatsResponse>(req, "DescribeRiskCategoryStats")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户所有规则的策略问题
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskListResponse"/></returns>
        public Task<DescribeRiskListResponse> DescribeRiskList(DescribeRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskListResponse>(req, "DescribeRiskList");
        }

        /// <summary>
        /// 查询用户所有规则的策略问题
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskListResponse"/></returns>
        public DescribeRiskListResponse DescribeRiskListSync(DescribeRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskListResponse>(req, "DescribeRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询规则详情（规则组管理）
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupRuleRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupRuleResponse"/></returns>
        public Task<DescribeSecurityGroupRuleResponse> DescribeSecurityGroupRule(DescribeSecurityGroupRuleRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupRuleResponse>(req, "DescribeSecurityGroupRule");
        }

        /// <summary>
        /// 查询规则详情（规则组管理）
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupRuleRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupRuleResponse"/></returns>
        public DescribeSecurityGroupRuleResponse DescribeSecurityGroupRuleSync(DescribeSecurityGroupRuleRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupRuleResponse>(req, "DescribeSecurityGroupRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询规则组中规则列表接口
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupRulesRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupRulesResponse"/></returns>
        public Task<DescribeSecurityGroupRulesResponse> DescribeSecurityGroupRules(DescribeSecurityGroupRulesRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupRulesResponse>(req, "DescribeSecurityGroupRules");
        }

        /// <summary>
        /// 查询规则组中规则列表接口
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupRulesRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupRulesResponse"/></returns>
        public DescribeSecurityGroupRulesResponse DescribeSecurityGroupRulesSync(DescribeSecurityGroupRulesRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupRulesResponse>(req, "DescribeSecurityGroupRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeStrategiesRequest"/></param>
        /// <returns><see cref="DescribeStrategiesResponse"/></returns>
        public Task<DescribeStrategiesResponse> DescribeStrategies(DescribeStrategiesRequest req)
        {
            return InternalRequestAsync<DescribeStrategiesResponse>(req, "DescribeStrategies");
        }

        /// <summary>
        /// 查询策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeStrategiesRequest"/></param>
        /// <returns><see cref="DescribeStrategiesResponse"/></returns>
        public DescribeStrategiesResponse DescribeStrategiesSync(DescribeStrategiesRequest req)
        {
            return InternalRequestAsync<DescribeStrategiesResponse>(req, "DescribeStrategies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询策略详情
        /// </summary>
        /// <param name="req"><see cref="DescribeStrategyRequest"/></param>
        /// <returns><see cref="DescribeStrategyResponse"/></returns>
        public Task<DescribeStrategyResponse> DescribeStrategy(DescribeStrategyRequest req)
        {
            return InternalRequestAsync<DescribeStrategyResponse>(req, "DescribeStrategy");
        }

        /// <summary>
        /// 查询策略详情
        /// </summary>
        /// <param name="req"><see cref="DescribeStrategyRequest"/></param>
        /// <returns><see cref="DescribeStrategyResponse"/></returns>
        public DescribeStrategyResponse DescribeStrategySync(DescribeStrategyRequest req)
        {
            return InternalRequestAsync<DescribeStrategyResponse>(req, "DescribeStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看防火墙管理规则下发账号列表
        /// </summary>
        /// <param name="req"><see cref="DescribeStrategyAccountsRequest"/></param>
        /// <returns><see cref="DescribeStrategyAccountsResponse"/></returns>
        public Task<DescribeStrategyAccountsResponse> DescribeStrategyAccounts(DescribeStrategyAccountsRequest req)
        {
            return InternalRequestAsync<DescribeStrategyAccountsResponse>(req, "DescribeStrategyAccounts");
        }

        /// <summary>
        /// 查看防火墙管理规则下发账号列表
        /// </summary>
        /// <param name="req"><see cref="DescribeStrategyAccountsRequest"/></param>
        /// <returns><see cref="DescribeStrategyAccountsResponse"/></returns>
        public DescribeStrategyAccountsResponse DescribeStrategyAccountsSync(DescribeStrategyAccountsRequest req)
        {
            return InternalRequestAsync<DescribeStrategyAccountsResponse>(req, "DescribeStrategyAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询策略下发状态
        /// </summary>
        /// <param name="req"><see cref="DescribeStrategyDispatchStatusRequest"/></param>
        /// <returns><see cref="DescribeStrategyDispatchStatusResponse"/></returns>
        public Task<DescribeStrategyDispatchStatusResponse> DescribeStrategyDispatchStatus(DescribeStrategyDispatchStatusRequest req)
        {
            return InternalRequestAsync<DescribeStrategyDispatchStatusResponse>(req, "DescribeStrategyDispatchStatus");
        }

        /// <summary>
        /// 查询策略下发状态
        /// </summary>
        /// <param name="req"><see cref="DescribeStrategyDispatchStatusRequest"/></param>
        /// <returns><see cref="DescribeStrategyDispatchStatusResponse"/></returns>
        public DescribeStrategyDispatchStatusResponse DescribeStrategyDispatchStatusSync(DescribeStrategyDispatchStatusRequest req)
        {
            return InternalRequestAsync<DescribeStrategyDispatchStatusResponse>(req, "DescribeStrategyDispatchStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询VPC ACL规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcAclRulesRequest"/></param>
        /// <returns><see cref="DescribeVpcAclRulesResponse"/></returns>
        public Task<DescribeVpcAclRulesResponse> DescribeVpcAclRules(DescribeVpcAclRulesRequest req)
        {
            return InternalRequestAsync<DescribeVpcAclRulesResponse>(req, "DescribeVpcAclRules");
        }

        /// <summary>
        /// 查询VPC ACL规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcAclRulesRequest"/></param>
        /// <returns><see cref="DescribeVpcAclRulesResponse"/></returns>
        public DescribeVpcAclRulesResponse DescribeVpcAclRulesSync(DescribeVpcAclRulesRequest req)
        {
            return InternalRequestAsync<DescribeVpcAclRulesResponse>(req, "DescribeVpcAclRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 下发策略
        /// </summary>
        /// <param name="req"><see cref="DispatchStrategyRequest"/></param>
        /// <returns><see cref="DispatchStrategyResponse"/></returns>
        public Task<DispatchStrategyResponse> DispatchStrategy(DispatchStrategyRequest req)
        {
            return InternalRequestAsync<DispatchStrategyResponse>(req, "DispatchStrategy");
        }

        /// <summary>
        /// 下发策略
        /// </summary>
        /// <param name="req"><see cref="DispatchStrategyRequest"/></param>
        /// <returns><see cref="DispatchStrategyResponse"/></returns>
        public DispatchStrategyResponse DispatchStrategySync(DispatchStrategyRequest req)
        {
            return InternalRequestAsync<DispatchStrategyResponse>(req, "DispatchStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 忽略策略问题
        /// </summary>
        /// <param name="req"><see cref="IgnorePolicyRiskRequest"/></param>
        /// <returns><see cref="IgnorePolicyRiskResponse"/></returns>
        public Task<IgnorePolicyRiskResponse> IgnorePolicyRisk(IgnorePolicyRiskRequest req)
        {
            return InternalRequestAsync<IgnorePolicyRiskResponse>(req, "IgnorePolicyRisk");
        }

        /// <summary>
        /// 忽略策略问题
        /// </summary>
        /// <param name="req"><see cref="IgnorePolicyRiskRequest"/></param>
        /// <returns><see cref="IgnorePolicyRiskResponse"/></returns>
        public IgnorePolicyRiskResponse IgnorePolicyRiskSync(IgnorePolicyRiskRequest req)
        {
            return InternalRequestAsync<IgnorePolicyRiskResponse>(req, "IgnorePolicyRisk")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改互联网边界ACL规则。Rule 参数中必须包含 RuleId 用于指定要修改的规则。
        /// </summary>
        /// <param name="req"><see cref="ModifyEdgeAclRuleRequest"/></param>
        /// <returns><see cref="ModifyEdgeAclRuleResponse"/></returns>
        public Task<ModifyEdgeAclRuleResponse> ModifyEdgeAclRule(ModifyEdgeAclRuleRequest req)
        {
            return InternalRequestAsync<ModifyEdgeAclRuleResponse>(req, "ModifyEdgeAclRule");
        }

        /// <summary>
        /// 修改互联网边界ACL规则。Rule 参数中必须包含 RuleId 用于指定要修改的规则。
        /// </summary>
        /// <param name="req"><see cref="ModifyEdgeAclRuleRequest"/></param>
        /// <returns><see cref="ModifyEdgeAclRuleResponse"/></returns>
        public ModifyEdgeAclRuleResponse ModifyEdgeAclRuleSync(ModifyEdgeAclRuleRequest req)
        {
            return InternalRequestAsync<ModifyEdgeAclRuleResponse>(req, "ModifyEdgeAclRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量调整互联网边界ACL规则的执行顺序。Sequences 参数必须包含所有受影响的规则序号映射关系。
        /// </summary>
        /// <param name="req"><see cref="ModifyEdgeAclRuleSequenceRequest"/></param>
        /// <returns><see cref="ModifyEdgeAclRuleSequenceResponse"/></returns>
        public Task<ModifyEdgeAclRuleSequenceResponse> ModifyEdgeAclRuleSequence(ModifyEdgeAclRuleSequenceRequest req)
        {
            return InternalRequestAsync<ModifyEdgeAclRuleSequenceResponse>(req, "ModifyEdgeAclRuleSequence");
        }

        /// <summary>
        /// 批量调整互联网边界ACL规则的执行顺序。Sequences 参数必须包含所有受影响的规则序号映射关系。
        /// </summary>
        /// <param name="req"><see cref="ModifyEdgeAclRuleSequenceRequest"/></param>
        /// <returns><see cref="ModifyEdgeAclRuleSequenceResponse"/></returns>
        public ModifyEdgeAclRuleSequenceResponse ModifyEdgeAclRuleSequenceSync(ModifyEdgeAclRuleSequenceRequest req)
        {
            return InternalRequestAsync<ModifyEdgeAclRuleSequenceResponse>(req, "ModifyEdgeAclRuleSequence")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改NAT ACL规则
        /// </summary>
        /// <param name="req"><see cref="ModifyNatAclRuleRequest"/></param>
        /// <returns><see cref="ModifyNatAclRuleResponse"/></returns>
        public Task<ModifyNatAclRuleResponse> ModifyNatAclRule(ModifyNatAclRuleRequest req)
        {
            return InternalRequestAsync<ModifyNatAclRuleResponse>(req, "ModifyNatAclRule");
        }

        /// <summary>
        /// 修改NAT ACL规则
        /// </summary>
        /// <param name="req"><see cref="ModifyNatAclRuleRequest"/></param>
        /// <returns><see cref="ModifyNatAclRuleResponse"/></returns>
        public ModifyNatAclRuleResponse ModifyNatAclRuleSync(ModifyNatAclRuleRequest req)
        {
            return InternalRequestAsync<ModifyNatAclRuleResponse>(req, "ModifyNatAclRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 调整NAT ACL规则优先级顺序
        /// </summary>
        /// <param name="req"><see cref="ModifyNatAclRuleSequenceRequest"/></param>
        /// <returns><see cref="ModifyNatAclRuleSequenceResponse"/></returns>
        public Task<ModifyNatAclRuleSequenceResponse> ModifyNatAclRuleSequence(ModifyNatAclRuleSequenceRequest req)
        {
            return InternalRequestAsync<ModifyNatAclRuleSequenceResponse>(req, "ModifyNatAclRuleSequence");
        }

        /// <summary>
        /// 调整NAT ACL规则优先级顺序
        /// </summary>
        /// <param name="req"><see cref="ModifyNatAclRuleSequenceRequest"/></param>
        /// <returns><see cref="ModifyNatAclRuleSequenceResponse"/></returns>
        public ModifyNatAclRuleSequenceResponse ModifyNatAclRuleSequenceSync(ModifyNatAclRuleSequenceRequest req)
        {
            return InternalRequestAsync<ModifyNatAclRuleSequenceResponse>(req, "ModifyNatAclRuleSequence")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改规则组信息（规则组管理）
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleGroupRequest"/></param>
        /// <returns><see cref="ModifyRuleGroupResponse"/></returns>
        public Task<ModifyRuleGroupResponse> ModifyRuleGroup(ModifyRuleGroupRequest req)
        {
            return InternalRequestAsync<ModifyRuleGroupResponse>(req, "ModifyRuleGroup");
        }

        /// <summary>
        /// 修改规则组信息（规则组管理）
        /// </summary>
        /// <param name="req"><see cref="ModifyRuleGroupRequest"/></param>
        /// <returns><see cref="ModifyRuleGroupResponse"/></returns>
        public ModifyRuleGroupResponse ModifyRuleGroupSync(ModifyRuleGroupRequest req)
        {
            return InternalRequestAsync<ModifyRuleGroupResponse>(req, "ModifyRuleGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改规则（规则组管理）
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupRuleRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupRuleResponse"/></returns>
        public Task<ModifySecurityGroupRuleResponse> ModifySecurityGroupRule(ModifySecurityGroupRuleRequest req)
        {
            return InternalRequestAsync<ModifySecurityGroupRuleResponse>(req, "ModifySecurityGroupRule");
        }

        /// <summary>
        /// 修改规则（规则组管理）
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityGroupRuleRequest"/></param>
        /// <returns><see cref="ModifySecurityGroupRuleResponse"/></returns>
        public ModifySecurityGroupRuleResponse ModifySecurityGroupRuleSync(ModifySecurityGroupRuleRequest req)
        {
            return InternalRequestAsync<ModifySecurityGroupRuleResponse>(req, "ModifySecurityGroupRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改策略信息
        /// </summary>
        /// <param name="req"><see cref="ModifyStrategyRequest"/></param>
        /// <returns><see cref="ModifyStrategyResponse"/></returns>
        public Task<ModifyStrategyResponse> ModifyStrategy(ModifyStrategyRequest req)
        {
            return InternalRequestAsync<ModifyStrategyResponse>(req, "ModifyStrategy");
        }

        /// <summary>
        /// 修改策略信息
        /// </summary>
        /// <param name="req"><see cref="ModifyStrategyRequest"/></param>
        /// <returns><see cref="ModifyStrategyResponse"/></returns>
        public ModifyStrategyResponse ModifyStrategySync(ModifyStrategyRequest req)
        {
            return InternalRequestAsync<ModifyStrategyResponse>(req, "ModifyStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 快速排序修改策略优先级
        /// </summary>
        /// <param name="req"><see cref="ModifyStrategySequenceRequest"/></param>
        /// <returns><see cref="ModifyStrategySequenceResponse"/></returns>
        public Task<ModifyStrategySequenceResponse> ModifyStrategySequence(ModifyStrategySequenceRequest req)
        {
            return InternalRequestAsync<ModifyStrategySequenceResponse>(req, "ModifyStrategySequence");
        }

        /// <summary>
        /// 快速排序修改策略优先级
        /// </summary>
        /// <param name="req"><see cref="ModifyStrategySequenceRequest"/></param>
        /// <returns><see cref="ModifyStrategySequenceResponse"/></returns>
        public ModifyStrategySequenceResponse ModifyStrategySequenceSync(ModifyStrategySequenceRequest req)
        {
            return InternalRequestAsync<ModifyStrategySequenceResponse>(req, "ModifyStrategySequence")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改VPC ACL规则
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcAclRuleRequest"/></param>
        /// <returns><see cref="ModifyVpcAclRuleResponse"/></returns>
        public Task<ModifyVpcAclRuleResponse> ModifyVpcAclRule(ModifyVpcAclRuleRequest req)
        {
            return InternalRequestAsync<ModifyVpcAclRuleResponse>(req, "ModifyVpcAclRule");
        }

        /// <summary>
        /// 修改VPC ACL规则
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcAclRuleRequest"/></param>
        /// <returns><see cref="ModifyVpcAclRuleResponse"/></returns>
        public ModifyVpcAclRuleResponse ModifyVpcAclRuleSync(ModifyVpcAclRuleRequest req)
        {
            return InternalRequestAsync<ModifyVpcAclRuleResponse>(req, "ModifyVpcAclRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 调整VPC ACL规则优先级顺序
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcAclRuleSequenceRequest"/></param>
        /// <returns><see cref="ModifyVpcAclRuleSequenceResponse"/></returns>
        public Task<ModifyVpcAclRuleSequenceResponse> ModifyVpcAclRuleSequence(ModifyVpcAclRuleSequenceRequest req)
        {
            return InternalRequestAsync<ModifyVpcAclRuleSequenceResponse>(req, "ModifyVpcAclRuleSequence");
        }

        /// <summary>
        /// 调整VPC ACL规则优先级顺序
        /// </summary>
        /// <param name="req"><see cref="ModifyVpcAclRuleSequenceRequest"/></param>
        /// <returns><see cref="ModifyVpcAclRuleSequenceResponse"/></returns>
        public ModifyVpcAclRuleSequenceResponse ModifyVpcAclRuleSequenceSync(ModifyVpcAclRuleSequenceRequest req)
        {
            return InternalRequestAsync<ModifyVpcAclRuleSequenceResponse>(req, "ModifyVpcAclRuleSequence")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}

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

namespace TencentCloud.Dsgc.V20190723
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Dsgc.V20190723.Models;

   public class DsgcClient : AbstractClient{

       private const string endpoint = "dsgc.tencentcloudapi.com";
       private const string version = "2019-07-23";
       private const string sdkVersion = "SDK_NET_3.0.1130";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DsgcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public DsgcClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 授权用户云资源
        /// </summary>
        /// <param name="req"><see cref="AuthorizeDSPAMetaResourcesRequest"/></param>
        /// <returns><see cref="AuthorizeDSPAMetaResourcesResponse"/></returns>
        public Task<AuthorizeDSPAMetaResourcesResponse> AuthorizeDSPAMetaResources(AuthorizeDSPAMetaResourcesRequest req)
        {
            return InternalRequestAsync<AuthorizeDSPAMetaResourcesResponse>(req, "AuthorizeDSPAMetaResources");
        }

        /// <summary>
        /// 授权用户云资源
        /// </summary>
        /// <param name="req"><see cref="AuthorizeDSPAMetaResourcesRequest"/></param>
        /// <returns><see cref="AuthorizeDSPAMetaResourcesResponse"/></returns>
        public AuthorizeDSPAMetaResourcesResponse AuthorizeDSPAMetaResourcesSync(AuthorizeDSPAMetaResourcesRequest req)
        {
            return InternalRequestAsync<AuthorizeDSPAMetaResourcesResponse>(req, "AuthorizeDSPAMetaResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 绑定或解绑COS桶
        /// </summary>
        /// <param name="req"><see cref="BindDSPAResourceCosBucketsRequest"/></param>
        /// <returns><see cref="BindDSPAResourceCosBucketsResponse"/></returns>
        public Task<BindDSPAResourceCosBucketsResponse> BindDSPAResourceCosBuckets(BindDSPAResourceCosBucketsRequest req)
        {
            return InternalRequestAsync<BindDSPAResourceCosBucketsResponse>(req, "BindDSPAResourceCosBuckets");
        }

        /// <summary>
        /// 绑定或解绑COS桶
        /// </summary>
        /// <param name="req"><see cref="BindDSPAResourceCosBucketsRequest"/></param>
        /// <returns><see cref="BindDSPAResourceCosBucketsResponse"/></returns>
        public BindDSPAResourceCosBucketsResponse BindDSPAResourceCosBucketsSync(BindDSPAResourceCosBucketsRequest req)
        {
            return InternalRequestAsync<BindDSPAResourceCosBucketsResponse>(req, "BindDSPAResourceCosBuckets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 绑定或解绑数据库实例DB
        /// </summary>
        /// <param name="req"><see cref="BindDSPAResourceDatabasesRequest"/></param>
        /// <returns><see cref="BindDSPAResourceDatabasesResponse"/></returns>
        public Task<BindDSPAResourceDatabasesResponse> BindDSPAResourceDatabases(BindDSPAResourceDatabasesRequest req)
        {
            return InternalRequestAsync<BindDSPAResourceDatabasesResponse>(req, "BindDSPAResourceDatabases");
        }

        /// <summary>
        /// 绑定或解绑数据库实例DB
        /// </summary>
        /// <param name="req"><see cref="BindDSPAResourceDatabasesRequest"/></param>
        /// <returns><see cref="BindDSPAResourceDatabasesResponse"/></returns>
        public BindDSPAResourceDatabasesResponse BindDSPAResourceDatabasesSync(BindDSPAResourceDatabasesRequest req)
        {
            return InternalRequestAsync<BindDSPAResourceDatabasesResponse>(req, "BindDSPAResourceDatabases")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 复制合规组模板
        /// </summary>
        /// <param name="req"><see cref="CopyDSPATemplateRequest"/></param>
        /// <returns><see cref="CopyDSPATemplateResponse"/></returns>
        public Task<CopyDSPATemplateResponse> CopyDSPATemplate(CopyDSPATemplateRequest req)
        {
            return InternalRequestAsync<CopyDSPATemplateResponse>(req, "CopyDSPATemplate");
        }

        /// <summary>
        /// 复制合规组模板
        /// </summary>
        /// <param name="req"><see cref="CopyDSPATemplateRequest"/></param>
        /// <returns><see cref="CopyDSPATemplateResponse"/></returns>
        public CopyDSPATemplateResponse CopyDSPATemplateSync(CopyDSPATemplateRequest req)
        {
            return InternalRequestAsync<CopyDSPATemplateResponse>(req, "CopyDSPATemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建资产梳理报表导出重试任务
        /// </summary>
        /// <param name="req"><see cref="CreateAssetSortingReportRetryTaskRequest"/></param>
        /// <returns><see cref="CreateAssetSortingReportRetryTaskResponse"/></returns>
        public Task<CreateAssetSortingReportRetryTaskResponse> CreateAssetSortingReportRetryTask(CreateAssetSortingReportRetryTaskRequest req)
        {
            return InternalRequestAsync<CreateAssetSortingReportRetryTaskResponse>(req, "CreateAssetSortingReportRetryTask");
        }

        /// <summary>
        /// 创建资产梳理报表导出重试任务
        /// </summary>
        /// <param name="req"><see cref="CreateAssetSortingReportRetryTaskRequest"/></param>
        /// <returns><see cref="CreateAssetSortingReportRetryTaskResponse"/></returns>
        public CreateAssetSortingReportRetryTaskResponse CreateAssetSortingReportRetryTaskSync(CreateAssetSortingReportRetryTaskRequest req)
        {
            return InternalRequestAsync<CreateAssetSortingReportRetryTaskResponse>(req, "CreateAssetSortingReportRetryTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建资产梳理报告任务
        /// </summary>
        /// <param name="req"><see cref="CreateAssetSortingReportTaskRequest"/></param>
        /// <returns><see cref="CreateAssetSortingReportTaskResponse"/></returns>
        public Task<CreateAssetSortingReportTaskResponse> CreateAssetSortingReportTask(CreateAssetSortingReportTaskRequest req)
        {
            return InternalRequestAsync<CreateAssetSortingReportTaskResponse>(req, "CreateAssetSortingReportTask");
        }

        /// <summary>
        /// 创建资产梳理报告任务
        /// </summary>
        /// <param name="req"><see cref="CreateAssetSortingReportTaskRequest"/></param>
        /// <returns><see cref="CreateAssetSortingReportTaskResponse"/></returns>
        public CreateAssetSortingReportTaskResponse CreateAssetSortingReportTaskSync(CreateAssetSortingReportTaskRequest req)
        {
            return InternalRequestAsync<CreateAssetSortingReportTaskResponse>(req, "CreateAssetSortingReportTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建识别规则
        /// </summary>
        /// <param name="req"><see cref="CreateClassificationRuleRequest"/></param>
        /// <returns><see cref="CreateClassificationRuleResponse"/></returns>
        public Task<CreateClassificationRuleResponse> CreateClassificationRule(CreateClassificationRuleRequest req)
        {
            return InternalRequestAsync<CreateClassificationRuleResponse>(req, "CreateClassificationRule");
        }

        /// <summary>
        /// 创建识别规则
        /// </summary>
        /// <param name="req"><see cref="CreateClassificationRuleRequest"/></param>
        /// <returns><see cref="CreateClassificationRuleResponse"/></returns>
        public CreateClassificationRuleResponse CreateClassificationRuleSync(CreateClassificationRuleRequest req)
        {
            return InternalRequestAsync<CreateClassificationRuleResponse>(req, "CreateClassificationRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 风险项页面---创建风险等级
        /// </summary>
        /// <param name="req"><see cref="CreateDSPAAssessmentRiskLevelRequest"/></param>
        /// <returns><see cref="CreateDSPAAssessmentRiskLevelResponse"/></returns>
        public Task<CreateDSPAAssessmentRiskLevelResponse> CreateDSPAAssessmentRiskLevel(CreateDSPAAssessmentRiskLevelRequest req)
        {
            return InternalRequestAsync<CreateDSPAAssessmentRiskLevelResponse>(req, "CreateDSPAAssessmentRiskLevel");
        }

        /// <summary>
        /// 风险项页面---创建风险等级
        /// </summary>
        /// <param name="req"><see cref="CreateDSPAAssessmentRiskLevelRequest"/></param>
        /// <returns><see cref="CreateDSPAAssessmentRiskLevelResponse"/></returns>
        public CreateDSPAAssessmentRiskLevelResponse CreateDSPAAssessmentRiskLevelSync(CreateDSPAAssessmentRiskLevelRequest req)
        {
            return InternalRequestAsync<CreateDSPAAssessmentRiskLevelResponse>(req, "CreateDSPAAssessmentRiskLevel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 风险评估模板---创建风险评估模板
        /// </summary>
        /// <param name="req"><see cref="CreateDSPAAssessmentRiskTemplateRequest"/></param>
        /// <returns><see cref="CreateDSPAAssessmentRiskTemplateResponse"/></returns>
        public Task<CreateDSPAAssessmentRiskTemplateResponse> CreateDSPAAssessmentRiskTemplate(CreateDSPAAssessmentRiskTemplateRequest req)
        {
            return InternalRequestAsync<CreateDSPAAssessmentRiskTemplateResponse>(req, "CreateDSPAAssessmentRiskTemplate");
        }

        /// <summary>
        /// 风险评估模板---创建风险评估模板
        /// </summary>
        /// <param name="req"><see cref="CreateDSPAAssessmentRiskTemplateRequest"/></param>
        /// <returns><see cref="CreateDSPAAssessmentRiskTemplateResponse"/></returns>
        public CreateDSPAAssessmentRiskTemplateResponse CreateDSPAAssessmentRiskTemplateSync(CreateDSPAAssessmentRiskTemplateRequest req)
        {
            return InternalRequestAsync<CreateDSPAAssessmentRiskTemplateResponse>(req, "CreateDSPAAssessmentRiskTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新建DSPA风险评估任务
        /// </summary>
        /// <param name="req"><see cref="CreateDSPAAssessmentTaskRequest"/></param>
        /// <returns><see cref="CreateDSPAAssessmentTaskResponse"/></returns>
        public Task<CreateDSPAAssessmentTaskResponse> CreateDSPAAssessmentTask(CreateDSPAAssessmentTaskRequest req)
        {
            return InternalRequestAsync<CreateDSPAAssessmentTaskResponse>(req, "CreateDSPAAssessmentTask");
        }

        /// <summary>
        /// 新建DSPA风险评估任务
        /// </summary>
        /// <param name="req"><see cref="CreateDSPAAssessmentTaskRequest"/></param>
        /// <returns><see cref="CreateDSPAAssessmentTaskResponse"/></returns>
        public CreateDSPAAssessmentTaskResponse CreateDSPAAssessmentTaskSync(CreateDSPAAssessmentTaskRequest req)
        {
            return InternalRequestAsync<CreateDSPAAssessmentTaskResponse>(req, "CreateDSPAAssessmentTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新增COS分类分级扫描任务，单个用户最多允许创建100个任务。
        /// </summary>
        /// <param name="req"><see cref="CreateDSPACOSDiscoveryTaskRequest"/></param>
        /// <returns><see cref="CreateDSPACOSDiscoveryTaskResponse"/></returns>
        public Task<CreateDSPACOSDiscoveryTaskResponse> CreateDSPACOSDiscoveryTask(CreateDSPACOSDiscoveryTaskRequest req)
        {
            return InternalRequestAsync<CreateDSPACOSDiscoveryTaskResponse>(req, "CreateDSPACOSDiscoveryTask");
        }

        /// <summary>
        /// 新增COS分类分级扫描任务，单个用户最多允许创建100个任务。
        /// </summary>
        /// <param name="req"><see cref="CreateDSPACOSDiscoveryTaskRequest"/></param>
        /// <returns><see cref="CreateDSPACOSDiscoveryTaskResponse"/></returns>
        public CreateDSPACOSDiscoveryTaskResponse CreateDSPACOSDiscoveryTaskSync(CreateDSPACOSDiscoveryTaskRequest req)
        {
            return InternalRequestAsync<CreateDSPACOSDiscoveryTaskResponse>(req, "CreateDSPACOSDiscoveryTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新增分类，单个用户最多允许创建100个数据分类。
        /// </summary>
        /// <param name="req"><see cref="CreateDSPACategoryRequest"/></param>
        /// <returns><see cref="CreateDSPACategoryResponse"/></returns>
        public Task<CreateDSPACategoryResponse> CreateDSPACategory(CreateDSPACategoryRequest req)
        {
            return InternalRequestAsync<CreateDSPACategoryResponse>(req, "CreateDSPACategory");
        }

        /// <summary>
        /// 新增分类，单个用户最多允许创建100个数据分类。
        /// </summary>
        /// <param name="req"><see cref="CreateDSPACategoryRequest"/></param>
        /// <returns><see cref="CreateDSPACategoryResponse"/></returns>
        public CreateDSPACategoryResponse CreateDSPACategorySync(CreateDSPACategoryRequest req)
        {
            return InternalRequestAsync<CreateDSPACategoryResponse>(req, "CreateDSPACategory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建分类关联关系
        /// </summary>
        /// <param name="req"><see cref="CreateDSPACategoryRelationRequest"/></param>
        /// <returns><see cref="CreateDSPACategoryRelationResponse"/></returns>
        public Task<CreateDSPACategoryRelationResponse> CreateDSPACategoryRelation(CreateDSPACategoryRelationRequest req)
        {
            return InternalRequestAsync<CreateDSPACategoryRelationResponse>(req, "CreateDSPACategoryRelation");
        }

        /// <summary>
        /// 创建分类关联关系
        /// </summary>
        /// <param name="req"><see cref="CreateDSPACategoryRelationRequest"/></param>
        /// <returns><see cref="CreateDSPACategoryRelationResponse"/></returns>
        public CreateDSPACategoryRelationResponse CreateDSPACategoryRelationSync(CreateDSPACategoryRelationRequest req)
        {
            return InternalRequestAsync<CreateDSPACategoryRelationResponse>(req, "CreateDSPACategoryRelation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新增分类分级模板，单个用户最多允许创建100个合规组。
        /// </summary>
        /// <param name="req"><see cref="CreateDSPAComplianceGroupRequest"/></param>
        /// <returns><see cref="CreateDSPAComplianceGroupResponse"/></returns>
        public Task<CreateDSPAComplianceGroupResponse> CreateDSPAComplianceGroup(CreateDSPAComplianceGroupRequest req)
        {
            return InternalRequestAsync<CreateDSPAComplianceGroupResponse>(req, "CreateDSPAComplianceGroup");
        }

        /// <summary>
        /// 新增分类分级模板，单个用户最多允许创建100个合规组。
        /// </summary>
        /// <param name="req"><see cref="CreateDSPAComplianceGroupRequest"/></param>
        /// <returns><see cref="CreateDSPAComplianceGroupResponse"/></returns>
        public CreateDSPAComplianceGroupResponse CreateDSPAComplianceGroupSync(CreateDSPAComplianceGroupRequest req)
        {
            return InternalRequestAsync<CreateDSPAComplianceGroupResponse>(req, "CreateDSPAComplianceGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建合规组分类规则关联关系
        /// </summary>
        /// <param name="req"><see cref="CreateDSPAComplianceRulesRequest"/></param>
        /// <returns><see cref="CreateDSPAComplianceRulesResponse"/></returns>
        public Task<CreateDSPAComplianceRulesResponse> CreateDSPAComplianceRules(CreateDSPAComplianceRulesRequest req)
        {
            return InternalRequestAsync<CreateDSPAComplianceRulesResponse>(req, "CreateDSPAComplianceRules");
        }

        /// <summary>
        /// 创建合规组分类规则关联关系
        /// </summary>
        /// <param name="req"><see cref="CreateDSPAComplianceRulesRequest"/></param>
        /// <returns><see cref="CreateDSPAComplianceRulesResponse"/></returns>
        public CreateDSPAComplianceRulesResponse CreateDSPAComplianceRulesSync(CreateDSPAComplianceRulesRequest req)
        {
            return InternalRequestAsync<CreateDSPAComplianceRulesResponse>(req, "CreateDSPAComplianceRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加COS元数据
        /// </summary>
        /// <param name="req"><see cref="CreateDSPACosMetaResourcesRequest"/></param>
        /// <returns><see cref="CreateDSPACosMetaResourcesResponse"/></returns>
        public Task<CreateDSPACosMetaResourcesResponse> CreateDSPACosMetaResources(CreateDSPACosMetaResourcesRequest req)
        {
            return InternalRequestAsync<CreateDSPACosMetaResourcesResponse>(req, "CreateDSPACosMetaResources");
        }

        /// <summary>
        /// 添加COS元数据
        /// </summary>
        /// <param name="req"><see cref="CreateDSPACosMetaResourcesRequest"/></param>
        /// <returns><see cref="CreateDSPACosMetaResourcesResponse"/></returns>
        public CreateDSPACosMetaResourcesResponse CreateDSPACosMetaResourcesSync(CreateDSPACosMetaResourcesRequest req)
        {
            return InternalRequestAsync<CreateDSPACosMetaResourcesResponse>(req, "CreateDSPACosMetaResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加用户云上数据库类型资源
        /// </summary>
        /// <param name="req"><see cref="CreateDSPADbMetaResourcesRequest"/></param>
        /// <returns><see cref="CreateDSPADbMetaResourcesResponse"/></returns>
        public Task<CreateDSPADbMetaResourcesResponse> CreateDSPADbMetaResources(CreateDSPADbMetaResourcesRequest req)
        {
            return InternalRequestAsync<CreateDSPADbMetaResourcesResponse>(req, "CreateDSPADbMetaResources");
        }

        /// <summary>
        /// 添加用户云上数据库类型资源
        /// </summary>
        /// <param name="req"><see cref="CreateDSPADbMetaResourcesRequest"/></param>
        /// <returns><see cref="CreateDSPADbMetaResourcesResponse"/></returns>
        public CreateDSPADbMetaResourcesResponse CreateDSPADbMetaResourcesSync(CreateDSPADbMetaResourcesRequest req)
        {
            return InternalRequestAsync<CreateDSPADbMetaResourcesResponse>(req, "CreateDSPADbMetaResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新增分类分级规则，单个用户最多允许创建200个规则。
        /// </summary>
        /// <param name="req"><see cref="CreateDSPADiscoveryRuleRequest"/></param>
        /// <returns><see cref="CreateDSPADiscoveryRuleResponse"/></returns>
        public Task<CreateDSPADiscoveryRuleResponse> CreateDSPADiscoveryRule(CreateDSPADiscoveryRuleRequest req)
        {
            return InternalRequestAsync<CreateDSPADiscoveryRuleResponse>(req, "CreateDSPADiscoveryRule");
        }

        /// <summary>
        /// 新增分类分级规则，单个用户最多允许创建200个规则。
        /// </summary>
        /// <param name="req"><see cref="CreateDSPADiscoveryRuleRequest"/></param>
        /// <returns><see cref="CreateDSPADiscoveryRuleResponse"/></returns>
        public CreateDSPADiscoveryRuleResponse CreateDSPADiscoveryRuleSync(CreateDSPADiscoveryRuleRequest req)
        {
            return InternalRequestAsync<CreateDSPADiscoveryRuleResponse>(req, "CreateDSPADiscoveryRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新增分类分级任务，单个用户最多允许创建100个任务。
        /// </summary>
        /// <param name="req"><see cref="CreateDSPADiscoveryTaskRequest"/></param>
        /// <returns><see cref="CreateDSPADiscoveryTaskResponse"/></returns>
        public Task<CreateDSPADiscoveryTaskResponse> CreateDSPADiscoveryTask(CreateDSPADiscoveryTaskRequest req)
        {
            return InternalRequestAsync<CreateDSPADiscoveryTaskResponse>(req, "CreateDSPADiscoveryTask");
        }

        /// <summary>
        /// 新增分类分级任务，单个用户最多允许创建100个任务。
        /// </summary>
        /// <param name="req"><see cref="CreateDSPADiscoveryTaskRequest"/></param>
        /// <returns><see cref="CreateDSPADiscoveryTaskResponse"/></returns>
        public CreateDSPADiscoveryTaskResponse CreateDSPADiscoveryTaskSync(CreateDSPADiscoveryTaskRequest req)
        {
            return InternalRequestAsync<CreateDSPADiscoveryTaskResponse>(req, "CreateDSPADiscoveryTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新增分级，单个Casb实例最多允许创建100个数据分级
        /// </summary>
        /// <param name="req"><see cref="CreateDSPALevelGroupRequest"/></param>
        /// <returns><see cref="CreateDSPALevelGroupResponse"/></returns>
        public Task<CreateDSPALevelGroupResponse> CreateDSPALevelGroup(CreateDSPALevelGroupRequest req)
        {
            return InternalRequestAsync<CreateDSPALevelGroupResponse>(req, "CreateDSPALevelGroup");
        }

        /// <summary>
        /// 新增分级，单个Casb实例最多允许创建100个数据分级
        /// </summary>
        /// <param name="req"><see cref="CreateDSPALevelGroupRequest"/></param>
        /// <returns><see cref="CreateDSPALevelGroupResponse"/></returns>
        public CreateDSPALevelGroupResponse CreateDSPALevelGroupSync(CreateDSPALevelGroupRequest req)
        {
            return InternalRequestAsync<CreateDSPALevelGroupResponse>(req, "CreateDSPALevelGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加用户云上资源列表
        /// </summary>
        /// <param name="req"><see cref="CreateDSPAMetaResourcesRequest"/></param>
        /// <returns><see cref="CreateDSPAMetaResourcesResponse"/></returns>
        public Task<CreateDSPAMetaResourcesResponse> CreateDSPAMetaResources(CreateDSPAMetaResourcesRequest req)
        {
            return InternalRequestAsync<CreateDSPAMetaResourcesResponse>(req, "CreateDSPAMetaResources");
        }

        /// <summary>
        /// 添加用户云上资源列表
        /// </summary>
        /// <param name="req"><see cref="CreateDSPAMetaResourcesRequest"/></param>
        /// <returns><see cref="CreateDSPAMetaResourcesResponse"/></returns>
        public CreateDSPAMetaResourcesResponse CreateDSPAMetaResourcesSync(CreateDSPAMetaResourcesRequest req)
        {
            return InternalRequestAsync<CreateDSPAMetaResourcesResponse>(req, "CreateDSPAMetaResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新建用户自建云资源
        /// </summary>
        /// <param name="req"><see cref="CreateDSPASelfBuildMetaResourceRequest"/></param>
        /// <returns><see cref="CreateDSPASelfBuildMetaResourceResponse"/></returns>
        public Task<CreateDSPASelfBuildMetaResourceResponse> CreateDSPASelfBuildMetaResource(CreateDSPASelfBuildMetaResourceRequest req)
        {
            return InternalRequestAsync<CreateDSPASelfBuildMetaResourceResponse>(req, "CreateDSPASelfBuildMetaResource");
        }

        /// <summary>
        /// 新建用户自建云资源
        /// </summary>
        /// <param name="req"><see cref="CreateDSPASelfBuildMetaResourceRequest"/></param>
        /// <returns><see cref="CreateDSPASelfBuildMetaResourceResponse"/></returns>
        public CreateDSPASelfBuildMetaResourceResponse CreateDSPASelfBuildMetaResourceSync(CreateDSPASelfBuildMetaResourceRequest req)
        {
            return InternalRequestAsync<CreateDSPASelfBuildMetaResourceResponse>(req, "CreateDSPASelfBuildMetaResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建规则别名
        /// </summary>
        /// <param name="req"><see cref="CreateIdentifyRuleAnotherNameRequest"/></param>
        /// <returns><see cref="CreateIdentifyRuleAnotherNameResponse"/></returns>
        public Task<CreateIdentifyRuleAnotherNameResponse> CreateIdentifyRuleAnotherName(CreateIdentifyRuleAnotherNameRequest req)
        {
            return InternalRequestAsync<CreateIdentifyRuleAnotherNameResponse>(req, "CreateIdentifyRuleAnotherName");
        }

        /// <summary>
        /// 创建规则别名
        /// </summary>
        /// <param name="req"><see cref="CreateIdentifyRuleAnotherNameRequest"/></param>
        /// <returns><see cref="CreateIdentifyRuleAnotherNameResponse"/></returns>
        public CreateIdentifyRuleAnotherNameResponse CreateIdentifyRuleAnotherNameSync(CreateIdentifyRuleAnotherNameRequest req)
        {
            return InternalRequestAsync<CreateIdentifyRuleAnotherNameResponse>(req, "CreateIdentifyRuleAnotherName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建新分类
        /// </summary>
        /// <param name="req"><see cref="CreateNewClassificationRequest"/></param>
        /// <returns><see cref="CreateNewClassificationResponse"/></returns>
        public Task<CreateNewClassificationResponse> CreateNewClassification(CreateNewClassificationRequest req)
        {
            return InternalRequestAsync<CreateNewClassificationResponse>(req, "CreateNewClassification");
        }

        /// <summary>
        /// 创建新分类
        /// </summary>
        /// <param name="req"><see cref="CreateNewClassificationRequest"/></param>
        /// <returns><see cref="CreateNewClassificationResponse"/></returns>
        public CreateNewClassificationResponse CreateNewClassificationSync(CreateNewClassificationRequest req)
        {
            return InternalRequestAsync<CreateNewClassificationResponse>(req, "CreateNewClassification")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建或复制分级分类模板
        /// </summary>
        /// <param name="req"><see cref="CreateOrCopyStandardRequest"/></param>
        /// <returns><see cref="CreateOrCopyStandardResponse"/></returns>
        public Task<CreateOrCopyStandardResponse> CreateOrCopyStandard(CreateOrCopyStandardRequest req)
        {
            return InternalRequestAsync<CreateOrCopyStandardResponse>(req, "CreateOrCopyStandard");
        }

        /// <summary>
        /// 创建或复制分级分类模板
        /// </summary>
        /// <param name="req"><see cref="CreateOrCopyStandardRequest"/></param>
        /// <returns><see cref="CreateOrCopyStandardResponse"/></returns>
        public CreateOrCopyStandardResponse CreateOrCopyStandardSync(CreateOrCopyStandardRequest req)
        {
            return InternalRequestAsync<CreateOrCopyStandardResponse>(req, "CreateOrCopyStandard")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 风险等级的定义页面-创建风险等级的时候生成的一个默认的矩阵
        /// </summary>
        /// <param name="req"><see cref="DecribeSuggestRiskLevelMatrixRequest"/></param>
        /// <returns><see cref="DecribeSuggestRiskLevelMatrixResponse"/></returns>
        public Task<DecribeSuggestRiskLevelMatrixResponse> DecribeSuggestRiskLevelMatrix(DecribeSuggestRiskLevelMatrixRequest req)
        {
            return InternalRequestAsync<DecribeSuggestRiskLevelMatrixResponse>(req, "DecribeSuggestRiskLevelMatrix");
        }

        /// <summary>
        /// 风险等级的定义页面-创建风险等级的时候生成的一个默认的矩阵
        /// </summary>
        /// <param name="req"><see cref="DecribeSuggestRiskLevelMatrixRequest"/></param>
        /// <returns><see cref="DecribeSuggestRiskLevelMatrixResponse"/></returns>
        public DecribeSuggestRiskLevelMatrixResponse DecribeSuggestRiskLevelMatrixSync(DecribeSuggestRiskLevelMatrixRequest req)
        {
            return InternalRequestAsync<DecribeSuggestRiskLevelMatrixResponse>(req, "DecribeSuggestRiskLevelMatrix")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteCOSMetaData）用于删除COS元数据信息。
        /// </summary>
        /// <param name="req"><see cref="DeleteCosMetaResourceRequest"/></param>
        /// <returns><see cref="DeleteCosMetaResourceResponse"/></returns>
        public Task<DeleteCosMetaResourceResponse> DeleteCosMetaResource(DeleteCosMetaResourceRequest req)
        {
            return InternalRequestAsync<DeleteCosMetaResourceResponse>(req, "DeleteCosMetaResource");
        }

        /// <summary>
        /// 本接口（DeleteCOSMetaData）用于删除COS元数据信息。
        /// </summary>
        /// <param name="req"><see cref="DeleteCosMetaResourceRequest"/></param>
        /// <returns><see cref="DeleteCosMetaResourceResponse"/></returns>
        public DeleteCosMetaResourceResponse DeleteCosMetaResourceSync(DeleteCosMetaResourceRequest req)
        {
            return InternalRequestAsync<DeleteCosMetaResourceResponse>(req, "DeleteCosMetaResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除DSPA风险评估任务
        /// </summary>
        /// <param name="req"><see cref="DeleteDSPAAssessmentTaskRequest"/></param>
        /// <returns><see cref="DeleteDSPAAssessmentTaskResponse"/></returns>
        public Task<DeleteDSPAAssessmentTaskResponse> DeleteDSPAAssessmentTask(DeleteDSPAAssessmentTaskRequest req)
        {
            return InternalRequestAsync<DeleteDSPAAssessmentTaskResponse>(req, "DeleteDSPAAssessmentTask");
        }

        /// <summary>
        /// 删除DSPA风险评估任务
        /// </summary>
        /// <param name="req"><see cref="DeleteDSPAAssessmentTaskRequest"/></param>
        /// <returns><see cref="DeleteDSPAAssessmentTaskResponse"/></returns>
        public DeleteDSPAAssessmentTaskResponse DeleteDSPAAssessmentTaskSync(DeleteDSPAAssessmentTaskRequest req)
        {
            return InternalRequestAsync<DeleteDSPAAssessmentTaskResponse>(req, "DeleteDSPAAssessmentTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除COS分类分级任务，该接口只有在任务状态为以下几个状态值时才支持正确删除：
        /// 0 待扫描，
        /// 2 扫描终止， 
        /// 3 扫描成功，
        /// 4 扫描失败
        /// </summary>
        /// <param name="req"><see cref="DeleteDSPACOSDiscoveryTaskRequest"/></param>
        /// <returns><see cref="DeleteDSPACOSDiscoveryTaskResponse"/></returns>
        public Task<DeleteDSPACOSDiscoveryTaskResponse> DeleteDSPACOSDiscoveryTask(DeleteDSPACOSDiscoveryTaskRequest req)
        {
            return InternalRequestAsync<DeleteDSPACOSDiscoveryTaskResponse>(req, "DeleteDSPACOSDiscoveryTask");
        }

        /// <summary>
        /// 删除COS分类分级任务，该接口只有在任务状态为以下几个状态值时才支持正确删除：
        /// 0 待扫描，
        /// 2 扫描终止， 
        /// 3 扫描成功，
        /// 4 扫描失败
        /// </summary>
        /// <param name="req"><see cref="DeleteDSPACOSDiscoveryTaskRequest"/></param>
        /// <returns><see cref="DeleteDSPACOSDiscoveryTaskResponse"/></returns>
        public DeleteDSPACOSDiscoveryTaskResponse DeleteDSPACOSDiscoveryTaskSync(DeleteDSPACOSDiscoveryTaskRequest req)
        {
            return InternalRequestAsync<DeleteDSPACOSDiscoveryTaskResponse>(req, "DeleteDSPACOSDiscoveryTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除COS分类分级任务结果
        /// </summary>
        /// <param name="req"><see cref="DeleteDSPACOSDiscoveryTaskResultRequest"/></param>
        /// <returns><see cref="DeleteDSPACOSDiscoveryTaskResultResponse"/></returns>
        public Task<DeleteDSPACOSDiscoveryTaskResultResponse> DeleteDSPACOSDiscoveryTaskResult(DeleteDSPACOSDiscoveryTaskResultRequest req)
        {
            return InternalRequestAsync<DeleteDSPACOSDiscoveryTaskResultResponse>(req, "DeleteDSPACOSDiscoveryTaskResult");
        }

        /// <summary>
        /// 删除COS分类分级任务结果
        /// </summary>
        /// <param name="req"><see cref="DeleteDSPACOSDiscoveryTaskResultRequest"/></param>
        /// <returns><see cref="DeleteDSPACOSDiscoveryTaskResultResponse"/></returns>
        public DeleteDSPACOSDiscoveryTaskResultResponse DeleteDSPACOSDiscoveryTaskResultSync(DeleteDSPACOSDiscoveryTaskResultRequest req)
        {
            return InternalRequestAsync<DeleteDSPACOSDiscoveryTaskResultResponse>(req, "DeleteDSPACOSDiscoveryTaskResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除分类分级识别任务，该接口只有在任务状态为以下几个状态值时才支持正确删除：
        /// 0 待扫描，
        /// 2 扫描终止， 
        /// 3 扫描成功，
        /// 4 扫描失败
        /// </summary>
        /// <param name="req"><see cref="DeleteDSPADiscoveryTaskRequest"/></param>
        /// <returns><see cref="DeleteDSPADiscoveryTaskResponse"/></returns>
        public Task<DeleteDSPADiscoveryTaskResponse> DeleteDSPADiscoveryTask(DeleteDSPADiscoveryTaskRequest req)
        {
            return InternalRequestAsync<DeleteDSPADiscoveryTaskResponse>(req, "DeleteDSPADiscoveryTask");
        }

        /// <summary>
        /// 删除分类分级识别任务，该接口只有在任务状态为以下几个状态值时才支持正确删除：
        /// 0 待扫描，
        /// 2 扫描终止， 
        /// 3 扫描成功，
        /// 4 扫描失败
        /// </summary>
        /// <param name="req"><see cref="DeleteDSPADiscoveryTaskRequest"/></param>
        /// <returns><see cref="DeleteDSPADiscoveryTaskResponse"/></returns>
        public DeleteDSPADiscoveryTaskResponse DeleteDSPADiscoveryTaskSync(DeleteDSPADiscoveryTaskRequest req)
        {
            return InternalRequestAsync<DeleteDSPADiscoveryTaskResponse>(req, "DeleteDSPADiscoveryTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除分类分级识别任务结果
        /// </summary>
        /// <param name="req"><see cref="DeleteDSPADiscoveryTaskResultRequest"/></param>
        /// <returns><see cref="DeleteDSPADiscoveryTaskResultResponse"/></returns>
        public Task<DeleteDSPADiscoveryTaskResultResponse> DeleteDSPADiscoveryTaskResult(DeleteDSPADiscoveryTaskResultRequest req)
        {
            return InternalRequestAsync<DeleteDSPADiscoveryTaskResultResponse>(req, "DeleteDSPADiscoveryTaskResult");
        }

        /// <summary>
        /// 删除分类分级识别任务结果
        /// </summary>
        /// <param name="req"><see cref="DeleteDSPADiscoveryTaskResultRequest"/></param>
        /// <returns><see cref="DeleteDSPADiscoveryTaskResultResponse"/></returns>
        public DeleteDSPADiscoveryTaskResultResponse DeleteDSPADiscoveryTaskResultSync(DeleteDSPADiscoveryTaskResultRequest req)
        {
            return InternalRequestAsync<DeleteDSPADiscoveryTaskResultResponse>(req, "DeleteDSPADiscoveryTaskResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除用户云资源
        /// </summary>
        /// <param name="req"><see cref="DeleteDSPAMetaResourceRequest"/></param>
        /// <returns><see cref="DeleteDSPAMetaResourceResponse"/></returns>
        public Task<DeleteDSPAMetaResourceResponse> DeleteDSPAMetaResource(DeleteDSPAMetaResourceRequest req)
        {
            return InternalRequestAsync<DeleteDSPAMetaResourceResponse>(req, "DeleteDSPAMetaResource");
        }

        /// <summary>
        /// 删除用户云资源
        /// </summary>
        /// <param name="req"><see cref="DeleteDSPAMetaResourceRequest"/></param>
        /// <returns><see cref="DeleteDSPAMetaResourceResponse"/></returns>
        public DeleteDSPAMetaResourceResponse DeleteDSPAMetaResourceSync(DeleteDSPAMetaResourceRequest req)
        {
            return InternalRequestAsync<DeleteDSPAMetaResourceResponse>(req, "DeleteDSPAMetaResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询敏感数据导出结果URL
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetDetailDataExportResultRequest"/></param>
        /// <returns><see cref="DescribeAssetDetailDataExportResultResponse"/></returns>
        public Task<DescribeAssetDetailDataExportResultResponse> DescribeAssetDetailDataExportResult(DescribeAssetDetailDataExportResultRequest req)
        {
            return InternalRequestAsync<DescribeAssetDetailDataExportResultResponse>(req, "DescribeAssetDetailDataExportResult");
        }

        /// <summary>
        /// 查询敏感数据导出结果URL
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetDetailDataExportResultRequest"/></param>
        /// <returns><see cref="DescribeAssetDetailDataExportResultResponse"/></returns>
        public DescribeAssetDetailDataExportResultResponse DescribeAssetDetailDataExportResultSync(DescribeAssetDetailDataExportResultRequest req)
        {
            return InternalRequestAsync<DescribeAssetDetailDataExportResultResponse>(req, "DescribeAssetDetailDataExportResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 数据资产报告页面-查询数据资产概览接口（包括数据库资产详情和存储资产详情）
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetOverviewRequest"/></param>
        /// <returns><see cref="DescribeAssetOverviewResponse"/></returns>
        public Task<DescribeAssetOverviewResponse> DescribeAssetOverview(DescribeAssetOverviewRequest req)
        {
            return InternalRequestAsync<DescribeAssetOverviewResponse>(req, "DescribeAssetOverview");
        }

        /// <summary>
        /// 数据资产报告页面-查询数据资产概览接口（包括数据库资产详情和存储资产详情）
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetOverviewRequest"/></param>
        /// <returns><see cref="DescribeAssetOverviewResponse"/></returns>
        public DescribeAssetOverviewResponse DescribeAssetOverviewSync(DescribeAssetOverviewRequest req)
        {
            return InternalRequestAsync<DescribeAssetOverviewResponse>(req, "DescribeAssetOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询DB绑定的列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBindDBListRequest"/></param>
        /// <returns><see cref="DescribeBindDBListResponse"/></returns>
        public Task<DescribeBindDBListResponse> DescribeBindDBList(DescribeBindDBListRequest req)
        {
            return InternalRequestAsync<DescribeBindDBListResponse>(req, "DescribeBindDBList");
        }

        /// <summary>
        /// 查询DB绑定的列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBindDBListRequest"/></param>
        /// <returns><see cref="DescribeBindDBListResponse"/></returns>
        public DescribeBindDBListResponse DescribeBindDBListSync(DescribeBindDBListRequest req)
        {
            return InternalRequestAsync<DescribeBindDBListResponse>(req, "DescribeBindDBList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 数据资产报告-查询cos的资产分布详情接口
        /// </summary>
        /// <param name="req"><see cref="DescribeCOSAssetSensitiveDistributionRequest"/></param>
        /// <returns><see cref="DescribeCOSAssetSensitiveDistributionResponse"/></returns>
        public Task<DescribeCOSAssetSensitiveDistributionResponse> DescribeCOSAssetSensitiveDistribution(DescribeCOSAssetSensitiveDistributionRequest req)
        {
            return InternalRequestAsync<DescribeCOSAssetSensitiveDistributionResponse>(req, "DescribeCOSAssetSensitiveDistribution");
        }

        /// <summary>
        /// 数据资产报告-查询cos的资产分布详情接口
        /// </summary>
        /// <param name="req"><see cref="DescribeCOSAssetSensitiveDistributionRequest"/></param>
        /// <returns><see cref="DescribeCOSAssetSensitiveDistributionResponse"/></returns>
        public DescribeCOSAssetSensitiveDistributionResponse DescribeCOSAssetSensitiveDistributionSync(DescribeCOSAssetSensitiveDistributionRequest req)
        {
            return InternalRequestAsync<DescribeCOSAssetSensitiveDistributionResponse>(req, "DescribeCOSAssetSensitiveDistribution")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询分类信息
        /// </summary>
        /// <param name="req"><see cref="DescribeClassificationInfoRequest"/></param>
        /// <returns><see cref="DescribeClassificationInfoResponse"/></returns>
        public Task<DescribeClassificationInfoResponse> DescribeClassificationInfo(DescribeClassificationInfoRequest req)
        {
            return InternalRequestAsync<DescribeClassificationInfoResponse>(req, "DescribeClassificationInfo");
        }

        /// <summary>
        /// 查询分类信息
        /// </summary>
        /// <param name="req"><see cref="DescribeClassificationInfoRequest"/></param>
        /// <returns><see cref="DescribeClassificationInfoResponse"/></returns>
        public DescribeClassificationInfoResponse DescribeClassificationInfoSync(DescribeClassificationInfoRequest req)
        {
            return InternalRequestAsync<DescribeClassificationInfoResponse>(req, "DescribeClassificationInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询标准下所有分类的识别规则数量(不算子分类下的识别规则)
        /// </summary>
        /// <param name="req"><see cref="DescribeClassificationRuleCountRequest"/></param>
        /// <returns><see cref="DescribeClassificationRuleCountResponse"/></returns>
        public Task<DescribeClassificationRuleCountResponse> DescribeClassificationRuleCount(DescribeClassificationRuleCountRequest req)
        {
            return InternalRequestAsync<DescribeClassificationRuleCountResponse>(req, "DescribeClassificationRuleCount");
        }

        /// <summary>
        /// 查询标准下所有分类的识别规则数量(不算子分类下的识别规则)
        /// </summary>
        /// <param name="req"><see cref="DescribeClassificationRuleCountRequest"/></param>
        /// <returns><see cref="DescribeClassificationRuleCountResponse"/></returns>
        public DescribeClassificationRuleCountResponse DescribeClassificationRuleCountSync(DescribeClassificationRuleCountRequest req)
        {
            return InternalRequestAsync<DescribeClassificationRuleCountResponse>(req, "DescribeClassificationRuleCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询高风险资产的top10
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentHighRiskTop10OverviewRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentHighRiskTop10OverviewResponse"/></returns>
        public Task<DescribeDSPAAssessmentHighRiskTop10OverviewResponse> DescribeDSPAAssessmentHighRiskTop10Overview(DescribeDSPAAssessmentHighRiskTop10OverviewRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentHighRiskTop10OverviewResponse>(req, "DescribeDSPAAssessmentHighRiskTop10Overview");
        }

        /// <summary>
        /// 查询高风险资产的top10
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentHighRiskTop10OverviewRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentHighRiskTop10OverviewResponse"/></returns>
        public DescribeDSPAAssessmentHighRiskTop10OverviewResponse DescribeDSPAAssessmentHighRiskTop10OverviewSync(DescribeDSPAAssessmentHighRiskTop10OverviewRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentHighRiskTop10OverviewResponse>(req, "DescribeDSPAAssessmentHighRiskTop10Overview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询最新风险项详情数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentLatestRiskDetailInfoRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentLatestRiskDetailInfoResponse"/></returns>
        public Task<DescribeDSPAAssessmentLatestRiskDetailInfoResponse> DescribeDSPAAssessmentLatestRiskDetailInfo(DescribeDSPAAssessmentLatestRiskDetailInfoRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentLatestRiskDetailInfoResponse>(req, "DescribeDSPAAssessmentLatestRiskDetailInfo");
        }

        /// <summary>
        /// 查询最新风险项详情数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentLatestRiskDetailInfoRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentLatestRiskDetailInfoResponse"/></returns>
        public DescribeDSPAAssessmentLatestRiskDetailInfoResponse DescribeDSPAAssessmentLatestRiskDetailInfoSync(DescribeDSPAAssessmentLatestRiskDetailInfoRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentLatestRiskDetailInfoResponse>(req, "DescribeDSPAAssessmentLatestRiskDetailInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询最新的风险详情列表数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentLatestRiskListRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentLatestRiskListResponse"/></returns>
        public Task<DescribeDSPAAssessmentLatestRiskListResponse> DescribeDSPAAssessmentLatestRiskList(DescribeDSPAAssessmentLatestRiskListRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentLatestRiskListResponse>(req, "DescribeDSPAAssessmentLatestRiskList");
        }

        /// <summary>
        /// 查询最新的风险详情列表数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentLatestRiskListRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentLatestRiskListResponse"/></returns>
        public DescribeDSPAAssessmentLatestRiskListResponse DescribeDSPAAssessmentLatestRiskListSync(DescribeDSPAAssessmentLatestRiskListRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentLatestRiskListResponse>(req, "DescribeDSPAAssessmentLatestRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 风险概览-查询新发现风险统计数
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentNewDiscoveredRiskOverviewRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentNewDiscoveredRiskOverviewResponse"/></returns>
        public Task<DescribeDSPAAssessmentNewDiscoveredRiskOverviewResponse> DescribeDSPAAssessmentNewDiscoveredRiskOverview(DescribeDSPAAssessmentNewDiscoveredRiskOverviewRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentNewDiscoveredRiskOverviewResponse>(req, "DescribeDSPAAssessmentNewDiscoveredRiskOverview");
        }

        /// <summary>
        /// 风险概览-查询新发现风险统计数
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentNewDiscoveredRiskOverviewRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentNewDiscoveredRiskOverviewResponse"/></returns>
        public DescribeDSPAAssessmentNewDiscoveredRiskOverviewResponse DescribeDSPAAssessmentNewDiscoveredRiskOverviewSync(DescribeDSPAAssessmentNewDiscoveredRiskOverviewRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentNewDiscoveredRiskOverviewResponse>(req, "DescribeDSPAAssessmentNewDiscoveredRiskOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 风险概览-查询待处理风险统计数
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentPendingRiskOverviewRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentPendingRiskOverviewResponse"/></returns>
        public Task<DescribeDSPAAssessmentPendingRiskOverviewResponse> DescribeDSPAAssessmentPendingRiskOverview(DescribeDSPAAssessmentPendingRiskOverviewRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentPendingRiskOverviewResponse>(req, "DescribeDSPAAssessmentPendingRiskOverview");
        }

        /// <summary>
        /// 风险概览-查询待处理风险统计数
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentPendingRiskOverviewRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentPendingRiskOverviewResponse"/></returns>
        public DescribeDSPAAssessmentPendingRiskOverviewResponse DescribeDSPAAssessmentPendingRiskOverviewSync(DescribeDSPAAssessmentPendingRiskOverviewRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentPendingRiskOverviewResponse>(req, "DescribeDSPAAssessmentPendingRiskOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 风险概览-查询处理中风险统计数
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentProcessingRiskOverviewRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentProcessingRiskOverviewResponse"/></returns>
        public Task<DescribeDSPAAssessmentProcessingRiskOverviewResponse> DescribeDSPAAssessmentProcessingRiskOverview(DescribeDSPAAssessmentProcessingRiskOverviewRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentProcessingRiskOverviewResponse>(req, "DescribeDSPAAssessmentProcessingRiskOverview");
        }

        /// <summary>
        /// 风险概览-查询处理中风险统计数
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentProcessingRiskOverviewRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentProcessingRiskOverviewResponse"/></returns>
        public DescribeDSPAAssessmentProcessingRiskOverviewResponse DescribeDSPAAssessmentProcessingRiskOverviewSync(DescribeDSPAAssessmentProcessingRiskOverviewRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentProcessingRiskOverviewResponse>(req, "DescribeDSPAAssessmentProcessingRiskOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 风险概览页风险数量和受影响资产数概览统计
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskAmountOverviewRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskAmountOverviewResponse"/></returns>
        public Task<DescribeDSPAAssessmentRiskAmountOverviewResponse> DescribeDSPAAssessmentRiskAmountOverview(DescribeDSPAAssessmentRiskAmountOverviewRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentRiskAmountOverviewResponse>(req, "DescribeDSPAAssessmentRiskAmountOverview");
        }

        /// <summary>
        /// 风险概览页风险数量和受影响资产数概览统计
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskAmountOverviewRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskAmountOverviewResponse"/></returns>
        public DescribeDSPAAssessmentRiskAmountOverviewResponse DescribeDSPAAssessmentRiskAmountOverviewSync(DescribeDSPAAssessmentRiskAmountOverviewRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentRiskAmountOverviewResponse>(req, "DescribeDSPAAssessmentRiskAmountOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 受影响资产TOP5统计
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskDatasourceTop5Request"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskDatasourceTop5Response"/></returns>
        public Task<DescribeDSPAAssessmentRiskDatasourceTop5Response> DescribeDSPAAssessmentRiskDatasourceTop5(DescribeDSPAAssessmentRiskDatasourceTop5Request req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentRiskDatasourceTop5Response>(req, "DescribeDSPAAssessmentRiskDatasourceTop5");
        }

        /// <summary>
        /// 受影响资产TOP5统计
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskDatasourceTop5Request"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskDatasourceTop5Response"/></returns>
        public DescribeDSPAAssessmentRiskDatasourceTop5Response DescribeDSPAAssessmentRiskDatasourceTop5Sync(DescribeDSPAAssessmentRiskDatasourceTop5Request req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentRiskDatasourceTop5Response>(req, "DescribeDSPAAssessmentRiskDatasourceTop5")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 遗留待处理&昨日完成风险处置概览统计
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskDealedOverviewRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskDealedOverviewResponse"/></returns>
        public Task<DescribeDSPAAssessmentRiskDealedOverviewResponse> DescribeDSPAAssessmentRiskDealedOverview(DescribeDSPAAssessmentRiskDealedOverviewRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentRiskDealedOverviewResponse>(req, "DescribeDSPAAssessmentRiskDealedOverview");
        }

        /// <summary>
        /// 遗留待处理&昨日完成风险处置概览统计
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskDealedOverviewRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskDealedOverviewResponse"/></returns>
        public DescribeDSPAAssessmentRiskDealedOverviewResponse DescribeDSPAAssessmentRiskDealedOverviewSync(DescribeDSPAAssessmentRiskDealedOverviewRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentRiskDealedOverviewResponse>(req, "DescribeDSPAAssessmentRiskDealedOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 风险项处理趋势统计
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskDealedTrendRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskDealedTrendResponse"/></returns>
        public Task<DescribeDSPAAssessmentRiskDealedTrendResponse> DescribeDSPAAssessmentRiskDealedTrend(DescribeDSPAAssessmentRiskDealedTrendRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentRiskDealedTrendResponse>(req, "DescribeDSPAAssessmentRiskDealedTrend");
        }

        /// <summary>
        /// 风险项处理趋势统计
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskDealedTrendRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskDealedTrendResponse"/></returns>
        public DescribeDSPAAssessmentRiskDealedTrendResponse DescribeDSPAAssessmentRiskDealedTrendSync(DescribeDSPAAssessmentRiskDealedTrendRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentRiskDealedTrendResponse>(req, "DescribeDSPAAssessmentRiskDealedTrend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询风险分布数据，包含风险类型分布，风险详情分布，风险资产的分布
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskDistributionOverviewRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskDistributionOverviewResponse"/></returns>
        public Task<DescribeDSPAAssessmentRiskDistributionOverviewResponse> DescribeDSPAAssessmentRiskDistributionOverview(DescribeDSPAAssessmentRiskDistributionOverviewRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentRiskDistributionOverviewResponse>(req, "DescribeDSPAAssessmentRiskDistributionOverview");
        }

        /// <summary>
        /// 查询风险分布数据，包含风险类型分布，风险详情分布，风险资产的分布
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskDistributionOverviewRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskDistributionOverviewResponse"/></returns>
        public DescribeDSPAAssessmentRiskDistributionOverviewResponse DescribeDSPAAssessmentRiskDistributionOverviewSync(DescribeDSPAAssessmentRiskDistributionOverviewRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentRiskDistributionOverviewResponse>(req, "DescribeDSPAAssessmentRiskDistributionOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 风险分类TOP5统计
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskItemTop5Request"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskItemTop5Response"/></returns>
        public Task<DescribeDSPAAssessmentRiskItemTop5Response> DescribeDSPAAssessmentRiskItemTop5(DescribeDSPAAssessmentRiskItemTop5Request req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentRiskItemTop5Response>(req, "DescribeDSPAAssessmentRiskItemTop5");
        }

        /// <summary>
        /// 风险分类TOP5统计
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskItemTop5Request"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskItemTop5Response"/></returns>
        public DescribeDSPAAssessmentRiskItemTop5Response DescribeDSPAAssessmentRiskItemTop5Sync(DescribeDSPAAssessmentRiskItemTop5Request req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentRiskItemTop5Response>(req, "DescribeDSPAAssessmentRiskItemTop5")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 风险项页面----查询风险等级的详情数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskLevelDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskLevelDetailResponse"/></returns>
        public Task<DescribeDSPAAssessmentRiskLevelDetailResponse> DescribeDSPAAssessmentRiskLevelDetail(DescribeDSPAAssessmentRiskLevelDetailRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentRiskLevelDetailResponse>(req, "DescribeDSPAAssessmentRiskLevelDetail");
        }

        /// <summary>
        /// 风险项页面----查询风险等级的详情数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskLevelDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskLevelDetailResponse"/></returns>
        public DescribeDSPAAssessmentRiskLevelDetailResponse DescribeDSPAAssessmentRiskLevelDetailSync(DescribeDSPAAssessmentRiskLevelDetailRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentRiskLevelDetailResponse>(req, "DescribeDSPAAssessmentRiskLevelDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 风险项页面----查询风险等级的列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskLevelListRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskLevelListResponse"/></returns>
        public Task<DescribeDSPAAssessmentRiskLevelListResponse> DescribeDSPAAssessmentRiskLevelList(DescribeDSPAAssessmentRiskLevelListRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentRiskLevelListResponse>(req, "DescribeDSPAAssessmentRiskLevelList");
        }

        /// <summary>
        /// 风险项页面----查询风险等级的列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskLevelListRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskLevelListResponse"/></returns>
        public DescribeDSPAAssessmentRiskLevelListResponse DescribeDSPAAssessmentRiskLevelListSync(DescribeDSPAAssessmentRiskLevelListRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentRiskLevelListResponse>(req, "DescribeDSPAAssessmentRiskLevelList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 风险级别趋势统计
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskLevelTrendRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskLevelTrendResponse"/></returns>
        public Task<DescribeDSPAAssessmentRiskLevelTrendResponse> DescribeDSPAAssessmentRiskLevelTrend(DescribeDSPAAssessmentRiskLevelTrendRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentRiskLevelTrendResponse>(req, "DescribeDSPAAssessmentRiskLevelTrend");
        }

        /// <summary>
        /// 风险级别趋势统计
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskLevelTrendRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskLevelTrendResponse"/></returns>
        public DescribeDSPAAssessmentRiskLevelTrendResponse DescribeDSPAAssessmentRiskLevelTrendSync(DescribeDSPAAssessmentRiskLevelTrendRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentRiskLevelTrendResponse>(req, "DescribeDSPAAssessmentRiskLevelTrend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 风险数量概览统计
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskOverviewRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskOverviewResponse"/></returns>
        public Task<DescribeDSPAAssessmentRiskOverviewResponse> DescribeDSPAAssessmentRiskOverview(DescribeDSPAAssessmentRiskOverviewRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentRiskOverviewResponse>(req, "DescribeDSPAAssessmentRiskOverview");
        }

        /// <summary>
        /// 风险数量概览统计
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskOverviewRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskOverviewResponse"/></returns>
        public DescribeDSPAAssessmentRiskOverviewResponse DescribeDSPAAssessmentRiskOverviewSync(DescribeDSPAAssessmentRiskOverviewRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentRiskOverviewResponse>(req, "DescribeDSPAAssessmentRiskOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改最新评估风险项状态
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskProcessHistoryRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskProcessHistoryResponse"/></returns>
        public Task<DescribeDSPAAssessmentRiskProcessHistoryResponse> DescribeDSPAAssessmentRiskProcessHistory(DescribeDSPAAssessmentRiskProcessHistoryRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentRiskProcessHistoryResponse>(req, "DescribeDSPAAssessmentRiskProcessHistory");
        }

        /// <summary>
        /// 修改最新评估风险项状态
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskProcessHistoryRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskProcessHistoryResponse"/></returns>
        public DescribeDSPAAssessmentRiskProcessHistoryResponse DescribeDSPAAssessmentRiskProcessHistorySync(DescribeDSPAAssessmentRiskProcessHistoryRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentRiskProcessHistoryResponse>(req, "DescribeDSPAAssessmentRiskProcessHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 风险评估概览页，查询风险面的分布
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskSideDistributedRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskSideDistributedResponse"/></returns>
        public Task<DescribeDSPAAssessmentRiskSideDistributedResponse> DescribeDSPAAssessmentRiskSideDistributed(DescribeDSPAAssessmentRiskSideDistributedRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentRiskSideDistributedResponse>(req, "DescribeDSPAAssessmentRiskSideDistributed");
        }

        /// <summary>
        /// 风险评估概览页，查询风险面的分布
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskSideDistributedRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskSideDistributedResponse"/></returns>
        public DescribeDSPAAssessmentRiskSideDistributedResponse DescribeDSPAAssessmentRiskSideDistributedSync(DescribeDSPAAssessmentRiskSideDistributedRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentRiskSideDistributedResponse>(req, "DescribeDSPAAssessmentRiskSideDistributed")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 风险评估概览页，查询风险面的分布
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskSideListRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskSideListResponse"/></returns>
        public Task<DescribeDSPAAssessmentRiskSideListResponse> DescribeDSPAAssessmentRiskSideList(DescribeDSPAAssessmentRiskSideListRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentRiskSideListResponse>(req, "DescribeDSPAAssessmentRiskSideList");
        }

        /// <summary>
        /// 风险评估概览页，查询风险面的分布
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskSideListRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskSideListResponse"/></returns>
        public DescribeDSPAAssessmentRiskSideListResponse DescribeDSPAAssessmentRiskSideListSync(DescribeDSPAAssessmentRiskSideListRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentRiskSideListResponse>(req, "DescribeDSPAAssessmentRiskSideList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 风险项页面--查看评估模板详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskTemplateDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskTemplateDetailResponse"/></returns>
        public Task<DescribeDSPAAssessmentRiskTemplateDetailResponse> DescribeDSPAAssessmentRiskTemplateDetail(DescribeDSPAAssessmentRiskTemplateDetailRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentRiskTemplateDetailResponse>(req, "DescribeDSPAAssessmentRiskTemplateDetail");
        }

        /// <summary>
        /// 风险项页面--查看评估模板详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskTemplateDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskTemplateDetailResponse"/></returns>
        public DescribeDSPAAssessmentRiskTemplateDetailResponse DescribeDSPAAssessmentRiskTemplateDetailSync(DescribeDSPAAssessmentRiskTemplateDetailRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentRiskTemplateDetailResponse>(req, "DescribeDSPAAssessmentRiskTemplateDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 风险模板页面--查询风险模板中的脆弱项配置
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskTemplateVulnerableListRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskTemplateVulnerableListResponse"/></returns>
        public Task<DescribeDSPAAssessmentRiskTemplateVulnerableListResponse> DescribeDSPAAssessmentRiskTemplateVulnerableList(DescribeDSPAAssessmentRiskTemplateVulnerableListRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentRiskTemplateVulnerableListResponse>(req, "DescribeDSPAAssessmentRiskTemplateVulnerableList");
        }

        /// <summary>
        /// 风险模板页面--查询风险模板中的脆弱项配置
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskTemplateVulnerableListRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskTemplateVulnerableListResponse"/></returns>
        public DescribeDSPAAssessmentRiskTemplateVulnerableListResponse DescribeDSPAAssessmentRiskTemplateVulnerableListSync(DescribeDSPAAssessmentRiskTemplateVulnerableListRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentRiskTemplateVulnerableListResponse>(req, "DescribeDSPAAssessmentRiskTemplateVulnerableList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DSPA评估风险项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRisksRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRisksResponse"/></returns>
        public Task<DescribeDSPAAssessmentRisksResponse> DescribeDSPAAssessmentRisks(DescribeDSPAAssessmentRisksRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentRisksResponse>(req, "DescribeDSPAAssessmentRisks");
        }

        /// <summary>
        /// 获取DSPA评估风险项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRisksRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRisksResponse"/></returns>
        public DescribeDSPAAssessmentRisksResponse DescribeDSPAAssessmentRisksSync(DescribeDSPAAssessmentRisksRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentRisksResponse>(req, "DescribeDSPAAssessmentRisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DSPA评估任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentTasksRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentTasksResponse"/></returns>
        public Task<DescribeDSPAAssessmentTasksResponse> DescribeDSPAAssessmentTasks(DescribeDSPAAssessmentTasksRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentTasksResponse>(req, "DescribeDSPAAssessmentTasks");
        }

        /// <summary>
        /// 获取DSPA评估任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentTasksRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentTasksResponse"/></returns>
        public DescribeDSPAAssessmentTasksResponse DescribeDSPAAssessmentTasksSync(DescribeDSPAAssessmentTasksRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentTasksResponse>(req, "DescribeDSPAAssessmentTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DSPA评估模版关联的评估控制项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentTemplateControlItemsRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentTemplateControlItemsResponse"/></returns>
        public Task<DescribeDSPAAssessmentTemplateControlItemsResponse> DescribeDSPAAssessmentTemplateControlItems(DescribeDSPAAssessmentTemplateControlItemsRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentTemplateControlItemsResponse>(req, "DescribeDSPAAssessmentTemplateControlItems");
        }

        /// <summary>
        /// 获取DSPA评估模版关联的评估控制项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentTemplateControlItemsRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentTemplateControlItemsResponse"/></returns>
        public DescribeDSPAAssessmentTemplateControlItemsResponse DescribeDSPAAssessmentTemplateControlItemsSync(DescribeDSPAAssessmentTemplateControlItemsRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentTemplateControlItemsResponse>(req, "DescribeDSPAAssessmentTemplateControlItems")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DSPA评估模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentTemplatesRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentTemplatesResponse"/></returns>
        public Task<DescribeDSPAAssessmentTemplatesResponse> DescribeDSPAAssessmentTemplates(DescribeDSPAAssessmentTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentTemplatesResponse>(req, "DescribeDSPAAssessmentTemplates");
        }

        /// <summary>
        /// 获取DSPA评估模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentTemplatesRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentTemplatesResponse"/></returns>
        public DescribeDSPAAssessmentTemplatesResponse DescribeDSPAAssessmentTemplatesSync(DescribeDSPAAssessmentTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeDSPAAssessmentTemplatesResponse>(req, "DescribeDSPAAssessmentTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取COS敏感数据资产桶列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACOSDataAssetBucketsRequest"/></param>
        /// <returns><see cref="DescribeDSPACOSDataAssetBucketsResponse"/></returns>
        public Task<DescribeDSPACOSDataAssetBucketsResponse> DescribeDSPACOSDataAssetBuckets(DescribeDSPACOSDataAssetBucketsRequest req)
        {
            return InternalRequestAsync<DescribeDSPACOSDataAssetBucketsResponse>(req, "DescribeDSPACOSDataAssetBuckets");
        }

        /// <summary>
        /// 获取COS敏感数据资产桶列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACOSDataAssetBucketsRequest"/></param>
        /// <returns><see cref="DescribeDSPACOSDataAssetBucketsResponse"/></returns>
        public DescribeDSPACOSDataAssetBucketsResponse DescribeDSPACOSDataAssetBucketsSync(DescribeDSPACOSDataAssetBucketsRequest req)
        {
            return InternalRequestAsync<DescribeDSPACOSDataAssetBucketsResponse>(req, "DescribeDSPACOSDataAssetBuckets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取COS单个模板下的敏感数据资产
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACOSDataAssetByComplianceIdRequest"/></param>
        /// <returns><see cref="DescribeDSPACOSDataAssetByComplianceIdResponse"/></returns>
        public Task<DescribeDSPACOSDataAssetByComplianceIdResponse> DescribeDSPACOSDataAssetByComplianceId(DescribeDSPACOSDataAssetByComplianceIdRequest req)
        {
            return InternalRequestAsync<DescribeDSPACOSDataAssetByComplianceIdResponse>(req, "DescribeDSPACOSDataAssetByComplianceId");
        }

        /// <summary>
        /// 获取COS单个模板下的敏感数据资产
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACOSDataAssetByComplianceIdRequest"/></param>
        /// <returns><see cref="DescribeDSPACOSDataAssetByComplianceIdResponse"/></returns>
        public DescribeDSPACOSDataAssetByComplianceIdResponse DescribeDSPACOSDataAssetByComplianceIdSync(DescribeDSPACOSDataAssetByComplianceIdRequest req)
        {
            return InternalRequestAsync<DescribeDSPACOSDataAssetByComplianceIdResponse>(req, "DescribeDSPACOSDataAssetByComplianceId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取COS分类分级数据资产详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACOSDataAssetDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPACOSDataAssetDetailResponse"/></returns>
        public Task<DescribeDSPACOSDataAssetDetailResponse> DescribeDSPACOSDataAssetDetail(DescribeDSPACOSDataAssetDetailRequest req)
        {
            return InternalRequestAsync<DescribeDSPACOSDataAssetDetailResponse>(req, "DescribeDSPACOSDataAssetDetail");
        }

        /// <summary>
        /// 获取COS分类分级数据资产详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACOSDataAssetDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPACOSDataAssetDetailResponse"/></returns>
        public DescribeDSPACOSDataAssetDetailResponse DescribeDSPACOSDataAssetDetailSync(DescribeDSPACOSDataAssetDetailRequest req)
        {
            return InternalRequestAsync<DescribeDSPACOSDataAssetDetailResponse>(req, "DescribeDSPACOSDataAssetDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取COS分类分级任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACOSDiscoveryTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPACOSDiscoveryTaskDetailResponse"/></returns>
        public Task<DescribeDSPACOSDiscoveryTaskDetailResponse> DescribeDSPACOSDiscoveryTaskDetail(DescribeDSPACOSDiscoveryTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeDSPACOSDiscoveryTaskDetailResponse>(req, "DescribeDSPACOSDiscoveryTaskDetail");
        }

        /// <summary>
        /// 获取COS分类分级任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACOSDiscoveryTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPACOSDiscoveryTaskDetailResponse"/></returns>
        public DescribeDSPACOSDiscoveryTaskDetailResponse DescribeDSPACOSDiscoveryTaskDetailSync(DescribeDSPACOSDiscoveryTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeDSPACOSDiscoveryTaskDetailResponse>(req, "DescribeDSPACOSDiscoveryTaskDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取COS分类分级任务结果详情文件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACOSDiscoveryTaskFilesRequest"/></param>
        /// <returns><see cref="DescribeDSPACOSDiscoveryTaskFilesResponse"/></returns>
        public Task<DescribeDSPACOSDiscoveryTaskFilesResponse> DescribeDSPACOSDiscoveryTaskFiles(DescribeDSPACOSDiscoveryTaskFilesRequest req)
        {
            return InternalRequestAsync<DescribeDSPACOSDiscoveryTaskFilesResponse>(req, "DescribeDSPACOSDiscoveryTaskFiles");
        }

        /// <summary>
        /// 获取COS分类分级任务结果详情文件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACOSDiscoveryTaskFilesRequest"/></param>
        /// <returns><see cref="DescribeDSPACOSDiscoveryTaskFilesResponse"/></returns>
        public DescribeDSPACOSDiscoveryTaskFilesResponse DescribeDSPACOSDiscoveryTaskFilesSync(DescribeDSPACOSDiscoveryTaskFilesRequest req)
        {
            return InternalRequestAsync<DescribeDSPACOSDiscoveryTaskFilesResponse>(req, "DescribeDSPACOSDiscoveryTaskFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取COS分类分级任务结果，该接口只有在任务状态为以下状态时才支持结果正常查询：
        /// 3 扫描成功，
        /// 4 扫描失败
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACOSDiscoveryTaskResultRequest"/></param>
        /// <returns><see cref="DescribeDSPACOSDiscoveryTaskResultResponse"/></returns>
        public Task<DescribeDSPACOSDiscoveryTaskResultResponse> DescribeDSPACOSDiscoveryTaskResult(DescribeDSPACOSDiscoveryTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeDSPACOSDiscoveryTaskResultResponse>(req, "DescribeDSPACOSDiscoveryTaskResult");
        }

        /// <summary>
        /// 获取COS分类分级任务结果，该接口只有在任务状态为以下状态时才支持结果正常查询：
        /// 3 扫描成功，
        /// 4 扫描失败
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACOSDiscoveryTaskResultRequest"/></param>
        /// <returns><see cref="DescribeDSPACOSDiscoveryTaskResultResponse"/></returns>
        public DescribeDSPACOSDiscoveryTaskResultResponse DescribeDSPACOSDiscoveryTaskResultSync(DescribeDSPACOSDiscoveryTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeDSPACOSDiscoveryTaskResultResponse>(req, "DescribeDSPACOSDiscoveryTaskResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取COS分类分级任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACOSDiscoveryTasksRequest"/></param>
        /// <returns><see cref="DescribeDSPACOSDiscoveryTasksResponse"/></returns>
        public Task<DescribeDSPACOSDiscoveryTasksResponse> DescribeDSPACOSDiscoveryTasks(DescribeDSPACOSDiscoveryTasksRequest req)
        {
            return InternalRequestAsync<DescribeDSPACOSDiscoveryTasksResponse>(req, "DescribeDSPACOSDiscoveryTasks");
        }

        /// <summary>
        /// 获取COS分类分级任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACOSDiscoveryTasksRequest"/></param>
        /// <returns><see cref="DescribeDSPACOSDiscoveryTasksResponse"/></returns>
        public DescribeDSPACOSDiscoveryTasksResponse DescribeDSPACOSDiscoveryTasksSync(DescribeDSPACOSDiscoveryTasksRequest req)
        {
            return InternalRequestAsync<DescribeDSPACOSDiscoveryTasksResponse>(req, "DescribeDSPACOSDiscoveryTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取COS分类分级任务结果详情，该接口只有在任务状态为时才支持结果正确查询：
        /// 3 扫描成功
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACOSTaskResultDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPACOSTaskResultDetailResponse"/></returns>
        public Task<DescribeDSPACOSTaskResultDetailResponse> DescribeDSPACOSTaskResultDetail(DescribeDSPACOSTaskResultDetailRequest req)
        {
            return InternalRequestAsync<DescribeDSPACOSTaskResultDetailResponse>(req, "DescribeDSPACOSTaskResultDetail");
        }

        /// <summary>
        /// 获取COS分类分级任务结果详情，该接口只有在任务状态为时才支持结果正确查询：
        /// 3 扫描成功
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACOSTaskResultDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPACOSTaskResultDetailResponse"/></returns>
        public DescribeDSPACOSTaskResultDetailResponse DescribeDSPACOSTaskResultDetailSync(DescribeDSPACOSTaskResultDetailRequest req)
        {
            return InternalRequestAsync<DescribeDSPACOSTaskResultDetailResponse>(req, "DescribeDSPACOSTaskResultDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取敏感数据分类列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACategoriesRequest"/></param>
        /// <returns><see cref="DescribeDSPACategoriesResponse"/></returns>
        public Task<DescribeDSPACategoriesResponse> DescribeDSPACategories(DescribeDSPACategoriesRequest req)
        {
            return InternalRequestAsync<DescribeDSPACategoriesResponse>(req, "DescribeDSPACategories");
        }

        /// <summary>
        /// 获取敏感数据分类列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACategoriesRequest"/></param>
        /// <returns><see cref="DescribeDSPACategoriesResponse"/></returns>
        public DescribeDSPACategoriesResponse DescribeDSPACategoriesSync(DescribeDSPACategoriesRequest req)
        {
            return InternalRequestAsync<DescribeDSPACategoriesResponse>(req, "DescribeDSPACategories")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取分类规则统计信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACategoryRuleStatisticRequest"/></param>
        /// <returns><see cref="DescribeDSPACategoryRuleStatisticResponse"/></returns>
        public Task<DescribeDSPACategoryRuleStatisticResponse> DescribeDSPACategoryRuleStatistic(DescribeDSPACategoryRuleStatisticRequest req)
        {
            return InternalRequestAsync<DescribeDSPACategoryRuleStatisticResponse>(req, "DescribeDSPACategoryRuleStatistic");
        }

        /// <summary>
        /// 获取分类规则统计信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACategoryRuleStatisticRequest"/></param>
        /// <returns><see cref="DescribeDSPACategoryRuleStatisticResponse"/></returns>
        public DescribeDSPACategoryRuleStatisticResponse DescribeDSPACategoryRuleStatisticSync(DescribeDSPACategoryRuleStatisticRequest req)
        {
            return InternalRequestAsync<DescribeDSPACategoryRuleStatisticResponse>(req, "DescribeDSPACategoryRuleStatistic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取合规组分类规则信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACategoryRulesRequest"/></param>
        /// <returns><see cref="DescribeDSPACategoryRulesResponse"/></returns>
        public Task<DescribeDSPACategoryRulesResponse> DescribeDSPACategoryRules(DescribeDSPACategoryRulesRequest req)
        {
            return InternalRequestAsync<DescribeDSPACategoryRulesResponse>(req, "DescribeDSPACategoryRules");
        }

        /// <summary>
        /// 获取合规组分类规则信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACategoryRulesRequest"/></param>
        /// <returns><see cref="DescribeDSPACategoryRulesResponse"/></returns>
        public DescribeDSPACategoryRulesResponse DescribeDSPACategoryRulesSync(DescribeDSPACategoryRulesRequest req)
        {
            return InternalRequestAsync<DescribeDSPACategoryRulesResponse>(req, "DescribeDSPACategoryRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取分类树信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACategoryTreeRequest"/></param>
        /// <returns><see cref="DescribeDSPACategoryTreeResponse"/></returns>
        public Task<DescribeDSPACategoryTreeResponse> DescribeDSPACategoryTree(DescribeDSPACategoryTreeRequest req)
        {
            return InternalRequestAsync<DescribeDSPACategoryTreeResponse>(req, "DescribeDSPACategoryTree");
        }

        /// <summary>
        /// 获取分类树信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACategoryTreeRequest"/></param>
        /// <returns><see cref="DescribeDSPACategoryTreeResponse"/></returns>
        public DescribeDSPACategoryTreeResponse DescribeDSPACategoryTreeSync(DescribeDSPACategoryTreeRequest req)
        {
            return InternalRequestAsync<DescribeDSPACategoryTreeResponse>(req, "DescribeDSPACategoryTree")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取分类规则树信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACategoryTreeWithRulesRequest"/></param>
        /// <returns><see cref="DescribeDSPACategoryTreeWithRulesResponse"/></returns>
        public Task<DescribeDSPACategoryTreeWithRulesResponse> DescribeDSPACategoryTreeWithRules(DescribeDSPACategoryTreeWithRulesRequest req)
        {
            return InternalRequestAsync<DescribeDSPACategoryTreeWithRulesResponse>(req, "DescribeDSPACategoryTreeWithRules");
        }

        /// <summary>
        /// 获取分类规则树信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACategoryTreeWithRulesRequest"/></param>
        /// <returns><see cref="DescribeDSPACategoryTreeWithRulesResponse"/></returns>
        public DescribeDSPACategoryTreeWithRulesResponse DescribeDSPACategoryTreeWithRulesSync(DescribeDSPACategoryTreeWithRulesRequest req)
        {
            return InternalRequestAsync<DescribeDSPACategoryTreeWithRulesResponse>(req, "DescribeDSPACategoryTreeWithRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取模板详情信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAComplianceGroupDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPAComplianceGroupDetailResponse"/></returns>
        public Task<DescribeDSPAComplianceGroupDetailResponse> DescribeDSPAComplianceGroupDetail(DescribeDSPAComplianceGroupDetailRequest req)
        {
            return InternalRequestAsync<DescribeDSPAComplianceGroupDetailResponse>(req, "DescribeDSPAComplianceGroupDetail");
        }

        /// <summary>
        /// 获取模板详情信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAComplianceGroupDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPAComplianceGroupDetailResponse"/></returns>
        public DescribeDSPAComplianceGroupDetailResponse DescribeDSPAComplianceGroupDetailSync(DescribeDSPAComplianceGroupDetailRequest req)
        {
            return InternalRequestAsync<DescribeDSPAComplianceGroupDetailResponse>(req, "DescribeDSPAComplianceGroupDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取分类分级模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAComplianceGroupsRequest"/></param>
        /// <returns><see cref="DescribeDSPAComplianceGroupsResponse"/></returns>
        public Task<DescribeDSPAComplianceGroupsResponse> DescribeDSPAComplianceGroups(DescribeDSPAComplianceGroupsRequest req)
        {
            return InternalRequestAsync<DescribeDSPAComplianceGroupsResponse>(req, "DescribeDSPAComplianceGroups");
        }

        /// <summary>
        /// 获取分类分级模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAComplianceGroupsRequest"/></param>
        /// <returns><see cref="DescribeDSPAComplianceGroupsResponse"/></returns>
        public DescribeDSPAComplianceGroupsResponse DescribeDSPAComplianceGroupsSync(DescribeDSPAComplianceGroupsRequest req)
        {
            return InternalRequestAsync<DescribeDSPAComplianceGroupsResponse>(req, "DescribeDSPAComplianceGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取模板更新提示信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAComplianceUpdateNotificationRequest"/></param>
        /// <returns><see cref="DescribeDSPAComplianceUpdateNotificationResponse"/></returns>
        public Task<DescribeDSPAComplianceUpdateNotificationResponse> DescribeDSPAComplianceUpdateNotification(DescribeDSPAComplianceUpdateNotificationRequest req)
        {
            return InternalRequestAsync<DescribeDSPAComplianceUpdateNotificationResponse>(req, "DescribeDSPAComplianceUpdateNotification");
        }

        /// <summary>
        /// 获取模板更新提示信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAComplianceUpdateNotificationRequest"/></param>
        /// <returns><see cref="DescribeDSPAComplianceUpdateNotificationResponse"/></returns>
        public DescribeDSPAComplianceUpdateNotificationResponse DescribeDSPAComplianceUpdateNotificationSync(DescribeDSPAComplianceUpdateNotificationRequest req)
        {
            return InternalRequestAsync<DescribeDSPAComplianceUpdateNotificationResponse>(req, "DescribeDSPAComplianceUpdateNotification")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取数据源的数据库信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPADataSourceDbInfoRequest"/></param>
        /// <returns><see cref="DescribeDSPADataSourceDbInfoResponse"/></returns>
        public Task<DescribeDSPADataSourceDbInfoResponse> DescribeDSPADataSourceDbInfo(DescribeDSPADataSourceDbInfoRequest req)
        {
            return InternalRequestAsync<DescribeDSPADataSourceDbInfoResponse>(req, "DescribeDSPADataSourceDbInfo");
        }

        /// <summary>
        /// 获取数据源的数据库信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPADataSourceDbInfoRequest"/></param>
        /// <returns><see cref="DescribeDSPADataSourceDbInfoResponse"/></returns>
        public DescribeDSPADataSourceDbInfoResponse DescribeDSPADataSourceDbInfoSync(DescribeDSPADataSourceDbInfoRequest req)
        {
            return InternalRequestAsync<DescribeDSPADataSourceDbInfoResponse>(req, "DescribeDSPADataSourceDbInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取分类分级规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPADiscoveryRulesRequest"/></param>
        /// <returns><see cref="DescribeDSPADiscoveryRulesResponse"/></returns>
        public Task<DescribeDSPADiscoveryRulesResponse> DescribeDSPADiscoveryRules(DescribeDSPADiscoveryRulesRequest req)
        {
            return InternalRequestAsync<DescribeDSPADiscoveryRulesResponse>(req, "DescribeDSPADiscoveryRules");
        }

        /// <summary>
        /// 获取分类分级规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPADiscoveryRulesRequest"/></param>
        /// <returns><see cref="DescribeDSPADiscoveryRulesResponse"/></returns>
        public DescribeDSPADiscoveryRulesResponse DescribeDSPADiscoveryRulesSync(DescribeDSPADiscoveryRulesRequest req)
        {
            return InternalRequestAsync<DescribeDSPADiscoveryRulesResponse>(req, "DescribeDSPADiscoveryRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询该用户是否已开通分类分级服务
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPADiscoveryServiceStatusRequest"/></param>
        /// <returns><see cref="DescribeDSPADiscoveryServiceStatusResponse"/></returns>
        public Task<DescribeDSPADiscoveryServiceStatusResponse> DescribeDSPADiscoveryServiceStatus(DescribeDSPADiscoveryServiceStatusRequest req)
        {
            return InternalRequestAsync<DescribeDSPADiscoveryServiceStatusResponse>(req, "DescribeDSPADiscoveryServiceStatus");
        }

        /// <summary>
        /// 用于查询该用户是否已开通分类分级服务
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPADiscoveryServiceStatusRequest"/></param>
        /// <returns><see cref="DescribeDSPADiscoveryServiceStatusResponse"/></returns>
        public DescribeDSPADiscoveryServiceStatusResponse DescribeDSPADiscoveryServiceStatusSync(DescribeDSPADiscoveryServiceStatusRequest req)
        {
            return InternalRequestAsync<DescribeDSPADiscoveryServiceStatusResponse>(req, "DescribeDSPADiscoveryServiceStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取分类分级任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPADiscoveryTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPADiscoveryTaskDetailResponse"/></returns>
        public Task<DescribeDSPADiscoveryTaskDetailResponse> DescribeDSPADiscoveryTaskDetail(DescribeDSPADiscoveryTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeDSPADiscoveryTaskDetailResponse>(req, "DescribeDSPADiscoveryTaskDetail");
        }

        /// <summary>
        /// 获取分类分级任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPADiscoveryTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPADiscoveryTaskDetailResponse"/></returns>
        public DescribeDSPADiscoveryTaskDetailResponse DescribeDSPADiscoveryTaskDetailSync(DescribeDSPADiscoveryTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeDSPADiscoveryTaskDetailResponse>(req, "DescribeDSPADiscoveryTaskDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取分类分级任务结果，该接口只有在任务状态为以下状态时才支持结果正常查询：
        /// 3 扫描成功，
        /// 4 扫描失败
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPADiscoveryTaskResultRequest"/></param>
        /// <returns><see cref="DescribeDSPADiscoveryTaskResultResponse"/></returns>
        public Task<DescribeDSPADiscoveryTaskResultResponse> DescribeDSPADiscoveryTaskResult(DescribeDSPADiscoveryTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeDSPADiscoveryTaskResultResponse>(req, "DescribeDSPADiscoveryTaskResult");
        }

        /// <summary>
        /// 获取分类分级任务结果，该接口只有在任务状态为以下状态时才支持结果正常查询：
        /// 3 扫描成功，
        /// 4 扫描失败
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPADiscoveryTaskResultRequest"/></param>
        /// <returns><see cref="DescribeDSPADiscoveryTaskResultResponse"/></returns>
        public DescribeDSPADiscoveryTaskResultResponse DescribeDSPADiscoveryTaskResultSync(DescribeDSPADiscoveryTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeDSPADiscoveryTaskResultResponse>(req, "DescribeDSPADiscoveryTaskResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取分类分级任务结果详情，该接口只有在任务状态为时才支持结果正确查询：
        /// 3 扫描成功
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPADiscoveryTaskResultDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPADiscoveryTaskResultDetailResponse"/></returns>
        public Task<DescribeDSPADiscoveryTaskResultDetailResponse> DescribeDSPADiscoveryTaskResultDetail(DescribeDSPADiscoveryTaskResultDetailRequest req)
        {
            return InternalRequestAsync<DescribeDSPADiscoveryTaskResultDetailResponse>(req, "DescribeDSPADiscoveryTaskResultDetail");
        }

        /// <summary>
        /// 获取分类分级任务结果详情，该接口只有在任务状态为时才支持结果正确查询：
        /// 3 扫描成功
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPADiscoveryTaskResultDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPADiscoveryTaskResultDetailResponse"/></returns>
        public DescribeDSPADiscoveryTaskResultDetailResponse DescribeDSPADiscoveryTaskResultDetailSync(DescribeDSPADiscoveryTaskResultDetailRequest req)
        {
            return InternalRequestAsync<DescribeDSPADiscoveryTaskResultDetailResponse>(req, "DescribeDSPADiscoveryTaskResultDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取分级分级扫描的表集合
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPADiscoveryTaskTablesRequest"/></param>
        /// <returns><see cref="DescribeDSPADiscoveryTaskTablesResponse"/></returns>
        public Task<DescribeDSPADiscoveryTaskTablesResponse> DescribeDSPADiscoveryTaskTables(DescribeDSPADiscoveryTaskTablesRequest req)
        {
            return InternalRequestAsync<DescribeDSPADiscoveryTaskTablesResponse>(req, "DescribeDSPADiscoveryTaskTables");
        }

        /// <summary>
        /// 获取分级分级扫描的表集合
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPADiscoveryTaskTablesRequest"/></param>
        /// <returns><see cref="DescribeDSPADiscoveryTaskTablesResponse"/></returns>
        public DescribeDSPADiscoveryTaskTablesResponse DescribeDSPADiscoveryTaskTablesSync(DescribeDSPADiscoveryTaskTablesRequest req)
        {
            return InternalRequestAsync<DescribeDSPADiscoveryTaskTablesResponse>(req, "DescribeDSPADiscoveryTaskTables")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据合规组id，去查询ES的概览页统计数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAESDataAssetByComplianceIdRequest"/></param>
        /// <returns><see cref="DescribeDSPAESDataAssetByComplianceIdResponse"/></returns>
        public Task<DescribeDSPAESDataAssetByComplianceIdResponse> DescribeDSPAESDataAssetByComplianceId(DescribeDSPAESDataAssetByComplianceIdRequest req)
        {
            return InternalRequestAsync<DescribeDSPAESDataAssetByComplianceIdResponse>(req, "DescribeDSPAESDataAssetByComplianceId");
        }

        /// <summary>
        /// 根据合规组id，去查询ES的概览页统计数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAESDataAssetByComplianceIdRequest"/></param>
        /// <returns><see cref="DescribeDSPAESDataAssetByComplianceIdResponse"/></returns>
        public DescribeDSPAESDataAssetByComplianceIdResponse DescribeDSPAESDataAssetByComplianceIdSync(DescribeDSPAESDataAssetByComplianceIdRequest req)
        {
            return InternalRequestAsync<DescribeDSPAESDataAssetByComplianceIdResponse>(req, "DescribeDSPAESDataAssetByComplianceId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据合规组id，去查询ES的概览页下的统计列表数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAESDataAssetDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPAESDataAssetDetailResponse"/></returns>
        public Task<DescribeDSPAESDataAssetDetailResponse> DescribeDSPAESDataAssetDetail(DescribeDSPAESDataAssetDetailRequest req)
        {
            return InternalRequestAsync<DescribeDSPAESDataAssetDetailResponse>(req, "DescribeDSPAESDataAssetDetail");
        }

        /// <summary>
        /// 根据合规组id，去查询ES的概览页下的统计列表数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAESDataAssetDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPAESDataAssetDetailResponse"/></returns>
        public DescribeDSPAESDataAssetDetailResponse DescribeDSPAESDataAssetDetailSync(DescribeDSPAESDataAssetDetailRequest req)
        {
            return InternalRequestAsync<DescribeDSPAESDataAssetDetailResponse>(req, "DescribeDSPAESDataAssetDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取ES扫描结果数据样本
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAESDataSampleRequest"/></param>
        /// <returns><see cref="DescribeDSPAESDataSampleResponse"/></returns>
        public Task<DescribeDSPAESDataSampleResponse> DescribeDSPAESDataSample(DescribeDSPAESDataSampleRequest req)
        {
            return InternalRequestAsync<DescribeDSPAESDataSampleResponse>(req, "DescribeDSPAESDataSample");
        }

        /// <summary>
        /// 获取ES扫描结果数据样本
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAESDataSampleRequest"/></param>
        /// <returns><see cref="DescribeDSPAESDataSampleResponse"/></returns>
        public DescribeDSPAESDataSampleResponse DescribeDSPAESDataSampleSync(DescribeDSPAESDataSampleRequest req)
        {
            return InternalRequestAsync<DescribeDSPAESDataSampleResponse>(req, "DescribeDSPAESDataSample")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取ES的分类分级任务结果详情，该接口只有在任务状态为时才支持结果正确查询：
        /// 3 扫描成功
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAESDiscoveryTaskResultDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPAESDiscoveryTaskResultDetailResponse"/></returns>
        public Task<DescribeDSPAESDiscoveryTaskResultDetailResponse> DescribeDSPAESDiscoveryTaskResultDetail(DescribeDSPAESDiscoveryTaskResultDetailRequest req)
        {
            return InternalRequestAsync<DescribeDSPAESDiscoveryTaskResultDetailResponse>(req, "DescribeDSPAESDiscoveryTaskResultDetail");
        }

        /// <summary>
        /// 获取ES的分类分级任务结果详情，该接口只有在任务状态为时才支持结果正确查询：
        /// 3 扫描成功
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAESDiscoveryTaskResultDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPAESDiscoveryTaskResultDetailResponse"/></returns>
        public DescribeDSPAESDiscoveryTaskResultDetailResponse DescribeDSPAESDiscoveryTaskResultDetailSync(DescribeDSPAESDiscoveryTaskResultDetailRequest req)
        {
            return InternalRequestAsync<DescribeDSPAESDiscoveryTaskResultDetailResponse>(req, "DescribeDSPAESDiscoveryTaskResultDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取分级详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPALevelDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPALevelDetailResponse"/></returns>
        public Task<DescribeDSPALevelDetailResponse> DescribeDSPALevelDetail(DescribeDSPALevelDetailRequest req)
        {
            return InternalRequestAsync<DescribeDSPALevelDetailResponse>(req, "DescribeDSPALevelDetail");
        }

        /// <summary>
        /// 获取分级详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPALevelDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPALevelDetailResponse"/></returns>
        public DescribeDSPALevelDetailResponse DescribeDSPALevelDetailSync(DescribeDSPALevelDetailRequest req)
        {
            return InternalRequestAsync<DescribeDSPALevelDetailResponse>(req, "DescribeDSPALevelDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取分级列表，限制100个 不分页返回
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPALevelGroupsRequest"/></param>
        /// <returns><see cref="DescribeDSPALevelGroupsResponse"/></returns>
        public Task<DescribeDSPALevelGroupsResponse> DescribeDSPALevelGroups(DescribeDSPALevelGroupsRequest req)
        {
            return InternalRequestAsync<DescribeDSPALevelGroupsResponse>(req, "DescribeDSPALevelGroups");
        }

        /// <summary>
        /// 获取分级列表，限制100个 不分页返回
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPALevelGroupsRequest"/></param>
        /// <returns><see cref="DescribeDSPALevelGroupsResponse"/></returns>
        public DescribeDSPALevelGroupsResponse DescribeDSPALevelGroupsSync(DescribeDSPALevelGroupsRequest req)
        {
            return InternalRequestAsync<DescribeDSPALevelGroupsResponse>(req, "DescribeDSPALevelGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取单个合规组下的RDB关系数据库分类分级数据资产
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPARDBDataAssetByComplianceIdRequest"/></param>
        /// <returns><see cref="DescribeDSPARDBDataAssetByComplianceIdResponse"/></returns>
        public Task<DescribeDSPARDBDataAssetByComplianceIdResponse> DescribeDSPARDBDataAssetByComplianceId(DescribeDSPARDBDataAssetByComplianceIdRequest req)
        {
            return InternalRequestAsync<DescribeDSPARDBDataAssetByComplianceIdResponse>(req, "DescribeDSPARDBDataAssetByComplianceId");
        }

        /// <summary>
        /// 获取单个合规组下的RDB关系数据库分类分级数据资产
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPARDBDataAssetByComplianceIdRequest"/></param>
        /// <returns><see cref="DescribeDSPARDBDataAssetByComplianceIdResponse"/></returns>
        public DescribeDSPARDBDataAssetByComplianceIdResponse DescribeDSPARDBDataAssetByComplianceIdSync(DescribeDSPARDBDataAssetByComplianceIdRequest req)
        {
            return InternalRequestAsync<DescribeDSPARDBDataAssetByComplianceIdResponse>(req, "DescribeDSPARDBDataAssetByComplianceId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取RDB关系数据库分类分级资产详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPARDBDataAssetDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPARDBDataAssetDetailResponse"/></returns>
        public Task<DescribeDSPARDBDataAssetDetailResponse> DescribeDSPARDBDataAssetDetail(DescribeDSPARDBDataAssetDetailRequest req)
        {
            return InternalRequestAsync<DescribeDSPARDBDataAssetDetailResponse>(req, "DescribeDSPARDBDataAssetDetail");
        }

        /// <summary>
        /// 获取RDB关系数据库分类分级资产详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPARDBDataAssetDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPARDBDataAssetDetailResponse"/></returns>
        public DescribeDSPARDBDataAssetDetailResponse DescribeDSPARDBDataAssetDetailSync(DescribeDSPARDBDataAssetDetailRequest req)
        {
            return InternalRequestAsync<DescribeDSPARDBDataAssetDetailResponse>(req, "DescribeDSPARDBDataAssetDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取DSPA支持的Meta元数据类型，返回包括：元数据类型，支持的元数据地域信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPASupportedMetasRequest"/></param>
        /// <returns><see cref="DescribeDSPASupportedMetasResponse"/></returns>
        public Task<DescribeDSPASupportedMetasResponse> DescribeDSPASupportedMetas(DescribeDSPASupportedMetasRequest req)
        {
            return InternalRequestAsync<DescribeDSPASupportedMetasResponse>(req, "DescribeDSPASupportedMetas");
        }

        /// <summary>
        /// 拉取DSPA支持的Meta元数据类型，返回包括：元数据类型，支持的元数据地域信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPASupportedMetasRequest"/></param>
        /// <returns><see cref="DescribeDSPASupportedMetasResponse"/></returns>
        public DescribeDSPASupportedMetasResponse DescribeDSPASupportedMetasSync(DescribeDSPASupportedMetasRequest req)
        {
            return InternalRequestAsync<DescribeDSPASupportedMetasResponse>(req, "DescribeDSPASupportedMetas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取扫描结果数据样本
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPATaskResultDataSampleRequest"/></param>
        /// <returns><see cref="DescribeDSPATaskResultDataSampleResponse"/></returns>
        public Task<DescribeDSPATaskResultDataSampleResponse> DescribeDSPATaskResultDataSample(DescribeDSPATaskResultDataSampleRequest req)
        {
            return InternalRequestAsync<DescribeDSPATaskResultDataSampleResponse>(req, "DescribeDSPATaskResultDataSample");
        }

        /// <summary>
        /// 获取扫描结果数据样本
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPATaskResultDataSampleRequest"/></param>
        /// <returns><see cref="DescribeDSPATaskResultDataSampleResponse"/></returns>
        public DescribeDSPATaskResultDataSampleResponse DescribeDSPATaskResultDataSampleSync(DescribeDSPATaskResultDataSampleRequest req)
        {
            return InternalRequestAsync<DescribeDSPATaskResultDataSampleResponse>(req, "DescribeDSPATaskResultDataSample")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 数据资产报告-查询es的敏感资产报告，包含（数据库资产，设敏级别数据库top10，资产详情）
        /// </summary>
        /// <param name="req"><see cref="DescribeESAssetSensitiveDistributionRequest"/></param>
        /// <returns><see cref="DescribeESAssetSensitiveDistributionResponse"/></returns>
        public Task<DescribeESAssetSensitiveDistributionResponse> DescribeESAssetSensitiveDistribution(DescribeESAssetSensitiveDistributionRequest req)
        {
            return InternalRequestAsync<DescribeESAssetSensitiveDistributionResponse>(req, "DescribeESAssetSensitiveDistribution");
        }

        /// <summary>
        /// 数据资产报告-查询es的敏感资产报告，包含（数据库资产，设敏级别数据库top10，资产详情）
        /// </summary>
        /// <param name="req"><see cref="DescribeESAssetSensitiveDistributionRequest"/></param>
        /// <returns><see cref="DescribeESAssetSensitiveDistributionResponse"/></returns>
        public DescribeESAssetSensitiveDistributionResponse DescribeESAssetSensitiveDistributionSync(DescribeESAssetSensitiveDistributionRequest req)
        {
            return InternalRequestAsync<DescribeESAssetSensitiveDistributionResponse>(req, "DescribeESAssetSensitiveDistribution")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取导出任务结果
        /// </summary>
        /// <param name="req"><see cref="DescribeExportTaskResultRequest"/></param>
        /// <returns><see cref="DescribeExportTaskResultResponse"/></returns>
        public Task<DescribeExportTaskResultResponse> DescribeExportTaskResult(DescribeExportTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeExportTaskResultResponse>(req, "DescribeExportTaskResult");
        }

        /// <summary>
        /// 获取导出任务结果
        /// </summary>
        /// <param name="req"><see cref="DescribeExportTaskResultRequest"/></param>
        /// <returns><see cref="DescribeExportTaskResultResponse"/></returns>
        public DescribeExportTaskResultResponse DescribeExportTaskResultSync(DescribeExportTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeExportTaskResultResponse>(req, "DescribeExportTaskResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询标准下所有叶子节点分类
        /// </summary>
        /// <param name="req"><see cref="DescribeLeafClassificationRequest"/></param>
        /// <returns><see cref="DescribeLeafClassificationResponse"/></returns>
        public Task<DescribeLeafClassificationResponse> DescribeLeafClassification(DescribeLeafClassificationRequest req)
        {
            return InternalRequestAsync<DescribeLeafClassificationResponse>(req, "DescribeLeafClassification");
        }

        /// <summary>
        /// 查询标准下所有叶子节点分类
        /// </summary>
        /// <param name="req"><see cref="DescribeLeafClassificationRequest"/></param>
        /// <returns><see cref="DescribeLeafClassificationResponse"/></returns>
        public DescribeLeafClassificationResponse DescribeLeafClassificationSync(DescribeLeafClassificationRequest req)
        {
            return InternalRequestAsync<DescribeLeafClassificationResponse>(req, "DescribeLeafClassification")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 数据资产报告-查询mongo 的敏感资产报告，包含（数据库资产，设敏级别数据库top10，资产详情）
        /// </summary>
        /// <param name="req"><see cref="DescribeMongoAssetSensitiveDistributionRequest"/></param>
        /// <returns><see cref="DescribeMongoAssetSensitiveDistributionResponse"/></returns>
        public Task<DescribeMongoAssetSensitiveDistributionResponse> DescribeMongoAssetSensitiveDistribution(DescribeMongoAssetSensitiveDistributionRequest req)
        {
            return InternalRequestAsync<DescribeMongoAssetSensitiveDistributionResponse>(req, "DescribeMongoAssetSensitiveDistribution");
        }

        /// <summary>
        /// 数据资产报告-查询mongo 的敏感资产报告，包含（数据库资产，设敏级别数据库top10，资产详情）
        /// </summary>
        /// <param name="req"><see cref="DescribeMongoAssetSensitiveDistributionRequest"/></param>
        /// <returns><see cref="DescribeMongoAssetSensitiveDistributionResponse"/></returns>
        public DescribeMongoAssetSensitiveDistributionResponse DescribeMongoAssetSensitiveDistributionSync(DescribeMongoAssetSensitiveDistributionRequest req)
        {
            return InternalRequestAsync<DescribeMongoAssetSensitiveDistributionResponse>(req, "DescribeMongoAssetSensitiveDistribution")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 数据资产报告-查询rbd 的敏感资产报告，包含（数据库资产，设敏级别数据库top10，资产详情）
        /// </summary>
        /// <param name="req"><see cref="DescribeRDBAssetSensitiveDistributionRequest"/></param>
        /// <returns><see cref="DescribeRDBAssetSensitiveDistributionResponse"/></returns>
        public Task<DescribeRDBAssetSensitiveDistributionResponse> DescribeRDBAssetSensitiveDistribution(DescribeRDBAssetSensitiveDistributionRequest req)
        {
            return InternalRequestAsync<DescribeRDBAssetSensitiveDistributionResponse>(req, "DescribeRDBAssetSensitiveDistribution");
        }

        /// <summary>
        /// 数据资产报告-查询rbd 的敏感资产报告，包含（数据库资产，设敏级别数据库top10，资产详情）
        /// </summary>
        /// <param name="req"><see cref="DescribeRDBAssetSensitiveDistributionRequest"/></param>
        /// <returns><see cref="DescribeRDBAssetSensitiveDistributionResponse"/></returns>
        public DescribeRDBAssetSensitiveDistributionResponse DescribeRDBAssetSensitiveDistributionSync(DescribeRDBAssetSensitiveDistributionRequest req)
        {
            return InternalRequestAsync<DescribeRDBAssetSensitiveDistributionResponse>(req, "DescribeRDBAssetSensitiveDistribution")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取报表下载链接
        /// </summary>
        /// <param name="req"><see cref="DescribeReportTaskDownloadUrlRequest"/></param>
        /// <returns><see cref="DescribeReportTaskDownloadUrlResponse"/></returns>
        public Task<DescribeReportTaskDownloadUrlResponse> DescribeReportTaskDownloadUrl(DescribeReportTaskDownloadUrlRequest req)
        {
            return InternalRequestAsync<DescribeReportTaskDownloadUrlResponse>(req, "DescribeReportTaskDownloadUrl");
        }

        /// <summary>
        /// 获取报表下载链接
        /// </summary>
        /// <param name="req"><see cref="DescribeReportTaskDownloadUrlRequest"/></param>
        /// <returns><see cref="DescribeReportTaskDownloadUrlResponse"/></returns>
        public DescribeReportTaskDownloadUrlResponse DescribeReportTaskDownloadUrlSync(DescribeReportTaskDownloadUrlRequest req)
        {
            return InternalRequestAsync<DescribeReportTaskDownloadUrlResponse>(req, "DescribeReportTaskDownloadUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取资产报表任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeReportTasksRequest"/></param>
        /// <returns><see cref="DescribeReportTasksResponse"/></returns>
        public Task<DescribeReportTasksResponse> DescribeReportTasks(DescribeReportTasksRequest req)
        {
            return InternalRequestAsync<DescribeReportTasksResponse>(req, "DescribeReportTasks");
        }

        /// <summary>
        /// 获取资产报表任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeReportTasksRequest"/></param>
        /// <returns><see cref="DescribeReportTasksResponse"/></returns>
        public DescribeReportTasksResponse DescribeReportTasksSync(DescribeReportTasksRequest req)
        {
            return InternalRequestAsync<DescribeReportTasksResponse>(req, "DescribeReportTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询分类规则详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleDetailRequest"/></param>
        /// <returns><see cref="DescribeRuleDetailResponse"/></returns>
        public Task<DescribeRuleDetailResponse> DescribeRuleDetail(DescribeRuleDetailRequest req)
        {
            return InternalRequestAsync<DescribeRuleDetailResponse>(req, "DescribeRuleDetail");
        }

        /// <summary>
        /// 查询分类规则详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleDetailRequest"/></param>
        /// <returns><see cref="DescribeRuleDetailResponse"/></returns>
        public DescribeRuleDetailResponse DescribeRuleDetailSync(DescribeRuleDetailRequest req)
        {
            return InternalRequestAsync<DescribeRuleDetailResponse>(req, "DescribeRuleDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询分类下规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleListRequest"/></param>
        /// <returns><see cref="DescribeRuleListResponse"/></returns>
        public Task<DescribeRuleListResponse> DescribeRuleList(DescribeRuleListRequest req)
        {
            return InternalRequestAsync<DescribeRuleListResponse>(req, "DescribeRuleList");
        }

        /// <summary>
        /// 查询分类下规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleListRequest"/></param>
        /// <returns><see cref="DescribeRuleListResponse"/></returns>
        public DescribeRuleListResponse DescribeRuleListSync(DescribeRuleListRequest req)
        {
            return InternalRequestAsync<DescribeRuleListResponse>(req, "DescribeRuleList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 数据资产报告-查询cos的敏感数据分布（分级分布 分类分布 敏感规则分布详情列表）
        /// </summary>
        /// <param name="req"><see cref="DescribeSensitiveCOSDataDistributionRequest"/></param>
        /// <returns><see cref="DescribeSensitiveCOSDataDistributionResponse"/></returns>
        public Task<DescribeSensitiveCOSDataDistributionResponse> DescribeSensitiveCOSDataDistribution(DescribeSensitiveCOSDataDistributionRequest req)
        {
            return InternalRequestAsync<DescribeSensitiveCOSDataDistributionResponse>(req, "DescribeSensitiveCOSDataDistribution");
        }

        /// <summary>
        /// 数据资产报告-查询cos的敏感数据分布（分级分布 分类分布 敏感规则分布详情列表）
        /// </summary>
        /// <param name="req"><see cref="DescribeSensitiveCOSDataDistributionRequest"/></param>
        /// <returns><see cref="DescribeSensitiveCOSDataDistributionResponse"/></returns>
        public DescribeSensitiveCOSDataDistributionResponse DescribeSensitiveCOSDataDistributionSync(DescribeSensitiveCOSDataDistributionRequest req)
        {
            return InternalRequestAsync<DescribeSensitiveCOSDataDistributionResponse>(req, "DescribeSensitiveCOSDataDistribution")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 数据资产报告-查询rdb的敏感数据分布-敏感规则字段分布-敏感分布详情
        /// </summary>
        /// <param name="req"><see cref="DescribeSensitiveRDBDataDistributionRequest"/></param>
        /// <returns><see cref="DescribeSensitiveRDBDataDistributionResponse"/></returns>
        public Task<DescribeSensitiveRDBDataDistributionResponse> DescribeSensitiveRDBDataDistribution(DescribeSensitiveRDBDataDistributionRequest req)
        {
            return InternalRequestAsync<DescribeSensitiveRDBDataDistributionResponse>(req, "DescribeSensitiveRDBDataDistribution");
        }

        /// <summary>
        /// 数据资产报告-查询rdb的敏感数据分布-敏感规则字段分布-敏感分布详情
        /// </summary>
        /// <param name="req"><see cref="DescribeSensitiveRDBDataDistributionRequest"/></param>
        /// <returns><see cref="DescribeSensitiveRDBDataDistributionResponse"/></returns>
        public DescribeSensitiveRDBDataDistributionResponse DescribeSensitiveRDBDataDistributionSync(DescribeSensitiveRDBDataDistributionRequest req)
        {
            return InternalRequestAsync<DescribeSensitiveRDBDataDistributionResponse>(req, "DescribeSensitiveRDBDataDistribution")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 取消用户云资源授权
        /// </summary>
        /// <param name="req"><see cref="DisableDSPAMetaResourceAuthRequest"/></param>
        /// <returns><see cref="DisableDSPAMetaResourceAuthResponse"/></returns>
        public Task<DisableDSPAMetaResourceAuthResponse> DisableDSPAMetaResourceAuth(DisableDSPAMetaResourceAuthRequest req)
        {
            return InternalRequestAsync<DisableDSPAMetaResourceAuthResponse>(req, "DisableDSPAMetaResourceAuth");
        }

        /// <summary>
        /// 取消用户云资源授权
        /// </summary>
        /// <param name="req"><see cref="DisableDSPAMetaResourceAuthRequest"/></param>
        /// <returns><see cref="DisableDSPAMetaResourceAuthResponse"/></returns>
        public DisableDSPAMetaResourceAuthResponse DisableDSPAMetaResourceAuthSync(DisableDSPAMetaResourceAuthRequest req)
        {
            return InternalRequestAsync<DisableDSPAMetaResourceAuthResponse>(req, "DisableDSPAMetaResourceAuth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 打开或者关闭分类分级规则
        /// 注：此API同时对该规则下的RDB跟COS规则操作。
        /// 
        /// </summary>
        /// <param name="req"><see cref="EnableDSPADiscoveryRuleRequest"/></param>
        /// <returns><see cref="EnableDSPADiscoveryRuleResponse"/></returns>
        public Task<EnableDSPADiscoveryRuleResponse> EnableDSPADiscoveryRule(EnableDSPADiscoveryRuleRequest req)
        {
            return InternalRequestAsync<EnableDSPADiscoveryRuleResponse>(req, "EnableDSPADiscoveryRule");
        }

        /// <summary>
        /// 打开或者关闭分类分级规则
        /// 注：此API同时对该规则下的RDB跟COS规则操作。
        /// 
        /// </summary>
        /// <param name="req"><see cref="EnableDSPADiscoveryRuleRequest"/></param>
        /// <returns><see cref="EnableDSPADiscoveryRuleResponse"/></returns>
        public EnableDSPADiscoveryRuleResponse EnableDSPADiscoveryRuleSync(EnableDSPADiscoveryRuleRequest req)
        {
            return InternalRequestAsync<EnableDSPADiscoveryRuleResponse>(req, "EnableDSPADiscoveryRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 启用版本体验
        /// </summary>
        /// <param name="req"><see cref="EnableTrialVersionRequest"/></param>
        /// <returns><see cref="EnableTrialVersionResponse"/></returns>
        public Task<EnableTrialVersionResponse> EnableTrialVersion(EnableTrialVersionRequest req)
        {
            return InternalRequestAsync<EnableTrialVersionResponse>(req, "EnableTrialVersion");
        }

        /// <summary>
        /// 启用版本体验
        /// </summary>
        /// <param name="req"><see cref="EnableTrialVersionRequest"/></param>
        /// <returns><see cref="EnableTrialVersionResponse"/></returns>
        public EnableTrialVersionResponse EnableTrialVersionSync(EnableTrialVersionRequest req)
        {
            return InternalRequestAsync<EnableTrialVersionResponse>(req, "EnableTrialVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建敏感数据导出任务
        /// </summary>
        /// <param name="req"><see cref="ExportAssetDetailDataRequest"/></param>
        /// <returns><see cref="ExportAssetDetailDataResponse"/></returns>
        public Task<ExportAssetDetailDataResponse> ExportAssetDetailData(ExportAssetDetailDataRequest req)
        {
            return InternalRequestAsync<ExportAssetDetailDataResponse>(req, "ExportAssetDetailData");
        }

        /// <summary>
        /// 创建敏感数据导出任务
        /// </summary>
        /// <param name="req"><see cref="ExportAssetDetailDataRequest"/></param>
        /// <returns><see cref="ExportAssetDetailDataResponse"/></returns>
        public ExportAssetDetailDataResponse ExportAssetDetailDataSync(ExportAssetDetailDataRequest req)
        {
            return InternalRequestAsync<ExportAssetDetailDataResponse>(req, "ExportAssetDetailData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取授权资源的连接状态
        /// </summary>
        /// <param name="req"><see cref="GetResourceConnectionStatusRequest"/></param>
        /// <returns><see cref="GetResourceConnectionStatusResponse"/></returns>
        public Task<GetResourceConnectionStatusResponse> GetResourceConnectionStatus(GetResourceConnectionStatusRequest req)
        {
            return InternalRequestAsync<GetResourceConnectionStatusResponse>(req, "GetResourceConnectionStatus");
        }

        /// <summary>
        /// 获取授权资源的连接状态
        /// </summary>
        /// <param name="req"><see cref="GetResourceConnectionStatusRequest"/></param>
        /// <returns><see cref="GetResourceConnectionStatusResponse"/></returns>
        public GetResourceConnectionStatusResponse GetResourceConnectionStatusSync(GetResourceConnectionStatusRequest req)
        {
            return InternalRequestAsync<GetResourceConnectionStatusResponse>(req, "GetResourceConnectionStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取体验版本信息
        /// </summary>
        /// <param name="req"><see cref="GetTrialVersionRequest"/></param>
        /// <returns><see cref="GetTrialVersionResponse"/></returns>
        public Task<GetTrialVersionResponse> GetTrialVersion(GetTrialVersionRequest req)
        {
            return InternalRequestAsync<GetTrialVersionResponse>(req, "GetTrialVersion");
        }

        /// <summary>
        /// 获取体验版本信息
        /// </summary>
        /// <param name="req"><see cref="GetTrialVersionRequest"/></param>
        /// <returns><see cref="GetTrialVersionResponse"/></returns>
        public GetTrialVersionResponse GetTrialVersionSync(GetTrialVersionRequest req)
        {
            return InternalRequestAsync<GetTrialVersionResponse>(req, "GetTrialVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取用户购买配额信息
        /// </summary>
        /// <param name="req"><see cref="GetUserQuotaInfoRequest"/></param>
        /// <returns><see cref="GetUserQuotaInfoResponse"/></returns>
        public Task<GetUserQuotaInfoResponse> GetUserQuotaInfo(GetUserQuotaInfoRequest req)
        {
            return InternalRequestAsync<GetUserQuotaInfoResponse>(req, "GetUserQuotaInfo");
        }

        /// <summary>
        /// 获取用户购买配额信息
        /// </summary>
        /// <param name="req"><see cref="GetUserQuotaInfoRequest"/></param>
        /// <returns><see cref="GetUserQuotaInfoResponse"/></returns>
        public GetUserQuotaInfoResponse GetUserQuotaInfoSync(GetUserQuotaInfoRequest req)
        {
            return InternalRequestAsync<GetUserQuotaInfoResponse>(req, "GetUserQuotaInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取DSPA集群列表
        /// </summary>
        /// <param name="req"><see cref="ListDSPAClustersRequest"/></param>
        /// <returns><see cref="ListDSPAClustersResponse"/></returns>
        public Task<ListDSPAClustersResponse> ListDSPAClusters(ListDSPAClustersRequest req)
        {
            return InternalRequestAsync<ListDSPAClustersResponse>(req, "ListDSPAClusters");
        }

        /// <summary>
        /// 拉取DSPA集群列表
        /// </summary>
        /// <param name="req"><see cref="ListDSPAClustersRequest"/></param>
        /// <returns><see cref="ListDSPAClustersResponse"/></returns>
        public ListDSPAClustersResponse ListDSPAClustersSync(ListDSPAClustersRequest req)
        {
            return InternalRequestAsync<ListDSPAClustersResponse>(req, "ListDSPAClusters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于获取COS元数据信息，返回COS元数据信息列表。
        /// </summary>
        /// <param name="req"><see cref="ListDSPACosMetaResourcesRequest"/></param>
        /// <returns><see cref="ListDSPACosMetaResourcesResponse"/></returns>
        public Task<ListDSPACosMetaResourcesResponse> ListDSPACosMetaResources(ListDSPACosMetaResourcesRequest req)
        {
            return InternalRequestAsync<ListDSPACosMetaResourcesResponse>(req, "ListDSPACosMetaResources");
        }

        /// <summary>
        /// 本接口用于获取COS元数据信息，返回COS元数据信息列表。
        /// </summary>
        /// <param name="req"><see cref="ListDSPACosMetaResourcesRequest"/></param>
        /// <returns><see cref="ListDSPACosMetaResourcesResponse"/></returns>
        public ListDSPACosMetaResourcesResponse ListDSPACosMetaResourcesSync(ListDSPACosMetaResourcesRequest req)
        {
            return InternalRequestAsync<ListDSPACosMetaResourcesResponse>(req, "ListDSPACosMetaResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 拉取用户云资源
        /// </summary>
        /// <param name="req"><see cref="ListDSPAMetaResourcesRequest"/></param>
        /// <returns><see cref="ListDSPAMetaResourcesResponse"/></returns>
        public Task<ListDSPAMetaResourcesResponse> ListDSPAMetaResources(ListDSPAMetaResourcesRequest req)
        {
            return InternalRequestAsync<ListDSPAMetaResourcesResponse>(req, "ListDSPAMetaResources");
        }

        /// <summary>
        /// 拉取用户云资源
        /// </summary>
        /// <param name="req"><see cref="ListDSPAMetaResourcesRequest"/></param>
        /// <returns><see cref="ListDSPAMetaResourcesResponse"/></returns>
        public ListDSPAMetaResourcesResponse ListDSPAMetaResourcesSync(ListDSPAMetaResourcesRequest req)
        {
            return InternalRequestAsync<ListDSPAMetaResourcesResponse>(req, "ListDSPAMetaResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑识别规则
        /// </summary>
        /// <param name="req"><see cref="ModifyClassificationRuleRequest"/></param>
        /// <returns><see cref="ModifyClassificationRuleResponse"/></returns>
        public Task<ModifyClassificationRuleResponse> ModifyClassificationRule(ModifyClassificationRuleRequest req)
        {
            return InternalRequestAsync<ModifyClassificationRuleResponse>(req, "ModifyClassificationRule");
        }

        /// <summary>
        /// 编辑识别规则
        /// </summary>
        /// <param name="req"><see cref="ModifyClassificationRuleRequest"/></param>
        /// <returns><see cref="ModifyClassificationRuleResponse"/></returns>
        public ModifyClassificationRuleResponse ModifyClassificationRuleSync(ModifyClassificationRuleRequest req)
        {
            return InternalRequestAsync<ModifyClassificationRuleResponse>(req, "ModifyClassificationRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改识别规则状态
        /// </summary>
        /// <param name="req"><see cref="ModifyClassificationRuleStateRequest"/></param>
        /// <returns><see cref="ModifyClassificationRuleStateResponse"/></returns>
        public Task<ModifyClassificationRuleStateResponse> ModifyClassificationRuleState(ModifyClassificationRuleStateRequest req)
        {
            return InternalRequestAsync<ModifyClassificationRuleStateResponse>(req, "ModifyClassificationRuleState");
        }

        /// <summary>
        /// 修改识别规则状态
        /// </summary>
        /// <param name="req"><see cref="ModifyClassificationRuleStateRequest"/></param>
        /// <returns><see cref="ModifyClassificationRuleStateResponse"/></returns>
        public ModifyClassificationRuleStateResponse ModifyClassificationRuleStateSync(ModifyClassificationRuleStateRequest req)
        {
            return InternalRequestAsync<ModifyClassificationRuleStateResponse>(req, "ModifyClassificationRuleState")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改DSPA评估风险项，支持修改Status
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPAAssessmentRiskRequest"/></param>
        /// <returns><see cref="ModifyDSPAAssessmentRiskResponse"/></returns>
        public Task<ModifyDSPAAssessmentRiskResponse> ModifyDSPAAssessmentRisk(ModifyDSPAAssessmentRiskRequest req)
        {
            return InternalRequestAsync<ModifyDSPAAssessmentRiskResponse>(req, "ModifyDSPAAssessmentRisk");
        }

        /// <summary>
        /// 修改DSPA评估风险项，支持修改Status
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPAAssessmentRiskRequest"/></param>
        /// <returns><see cref="ModifyDSPAAssessmentRiskResponse"/></returns>
        public ModifyDSPAAssessmentRiskResponse ModifyDSPAAssessmentRiskSync(ModifyDSPAAssessmentRiskRequest req)
        {
            return InternalRequestAsync<ModifyDSPAAssessmentRiskResponse>(req, "ModifyDSPAAssessmentRisk")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改最新评估风险项状态
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPAAssessmentRiskLatestRequest"/></param>
        /// <returns><see cref="ModifyDSPAAssessmentRiskLatestResponse"/></returns>
        public Task<ModifyDSPAAssessmentRiskLatestResponse> ModifyDSPAAssessmentRiskLatest(ModifyDSPAAssessmentRiskLatestRequest req)
        {
            return InternalRequestAsync<ModifyDSPAAssessmentRiskLatestResponse>(req, "ModifyDSPAAssessmentRiskLatest");
        }

        /// <summary>
        /// 修改最新评估风险项状态
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPAAssessmentRiskLatestRequest"/></param>
        /// <returns><see cref="ModifyDSPAAssessmentRiskLatestResponse"/></returns>
        public ModifyDSPAAssessmentRiskLatestResponse ModifyDSPAAssessmentRiskLatestSync(ModifyDSPAAssessmentRiskLatestRequest req)
        {
            return InternalRequestAsync<ModifyDSPAAssessmentRiskLatestResponse>(req, "ModifyDSPAAssessmentRiskLatest")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 风险项页面----修改风险等级的详情数据
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPAAssessmentRiskLevelRequest"/></param>
        /// <returns><see cref="ModifyDSPAAssessmentRiskLevelResponse"/></returns>
        public Task<ModifyDSPAAssessmentRiskLevelResponse> ModifyDSPAAssessmentRiskLevel(ModifyDSPAAssessmentRiskLevelRequest req)
        {
            return InternalRequestAsync<ModifyDSPAAssessmentRiskLevelResponse>(req, "ModifyDSPAAssessmentRiskLevel");
        }

        /// <summary>
        /// 风险项页面----修改风险等级的详情数据
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPAAssessmentRiskLevelRequest"/></param>
        /// <returns><see cref="ModifyDSPAAssessmentRiskLevelResponse"/></returns>
        public ModifyDSPAAssessmentRiskLevelResponse ModifyDSPAAssessmentRiskLevelSync(ModifyDSPAAssessmentRiskLevelRequest req)
        {
            return InternalRequestAsync<ModifyDSPAAssessmentRiskLevelResponse>(req, "ModifyDSPAAssessmentRiskLevel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 风险模板---修改风险模板
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPAAssessmentRiskTemplateRequest"/></param>
        /// <returns><see cref="ModifyDSPAAssessmentRiskTemplateResponse"/></returns>
        public Task<ModifyDSPAAssessmentRiskTemplateResponse> ModifyDSPAAssessmentRiskTemplate(ModifyDSPAAssessmentRiskTemplateRequest req)
        {
            return InternalRequestAsync<ModifyDSPAAssessmentRiskTemplateResponse>(req, "ModifyDSPAAssessmentRiskTemplate");
        }

        /// <summary>
        /// 风险模板---修改风险模板
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPAAssessmentRiskTemplateRequest"/></param>
        /// <returns><see cref="ModifyDSPAAssessmentRiskTemplateResponse"/></returns>
        public ModifyDSPAAssessmentRiskTemplateResponse ModifyDSPAAssessmentRiskTemplateSync(ModifyDSPAAssessmentRiskTemplateRequest req)
        {
            return InternalRequestAsync<ModifyDSPAAssessmentRiskTemplateResponse>(req, "ModifyDSPAAssessmentRiskTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改COS分类分级任务，该接口只有在任务状态为以下状态时才支持正确修改：
        /// 0 待扫描，
        /// 2 扫描终止， 
        /// 3 扫描成功，
        /// 4 扫描失败
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPACOSDiscoveryTaskRequest"/></param>
        /// <returns><see cref="ModifyDSPACOSDiscoveryTaskResponse"/></returns>
        public Task<ModifyDSPACOSDiscoveryTaskResponse> ModifyDSPACOSDiscoveryTask(ModifyDSPACOSDiscoveryTaskRequest req)
        {
            return InternalRequestAsync<ModifyDSPACOSDiscoveryTaskResponse>(req, "ModifyDSPACOSDiscoveryTask");
        }

        /// <summary>
        /// 修改COS分类分级任务，该接口只有在任务状态为以下状态时才支持正确修改：
        /// 0 待扫描，
        /// 2 扫描终止， 
        /// 3 扫描成功，
        /// 4 扫描失败
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPACOSDiscoveryTaskRequest"/></param>
        /// <returns><see cref="ModifyDSPACOSDiscoveryTaskResponse"/></returns>
        public ModifyDSPACOSDiscoveryTaskResponse ModifyDSPACOSDiscoveryTaskSync(ModifyDSPACOSDiscoveryTaskRequest req)
        {
            return InternalRequestAsync<ModifyDSPACOSDiscoveryTaskResponse>(req, "ModifyDSPACOSDiscoveryTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 调整COS任务扫描结果
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPACOSTaskResultRequest"/></param>
        /// <returns><see cref="ModifyDSPACOSTaskResultResponse"/></returns>
        public Task<ModifyDSPACOSTaskResultResponse> ModifyDSPACOSTaskResult(ModifyDSPACOSTaskResultRequest req)
        {
            return InternalRequestAsync<ModifyDSPACOSTaskResultResponse>(req, "ModifyDSPACOSTaskResult");
        }

        /// <summary>
        /// 调整COS任务扫描结果
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPACOSTaskResultRequest"/></param>
        /// <returns><see cref="ModifyDSPACOSTaskResultResponse"/></returns>
        public ModifyDSPACOSTaskResultResponse ModifyDSPACOSTaskResultSync(ModifyDSPACOSTaskResultRequest req)
        {
            return InternalRequestAsync<ModifyDSPACOSTaskResultResponse>(req, "ModifyDSPACOSTaskResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改分类，内置分类不支持修改。
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPACategoryRequest"/></param>
        /// <returns><see cref="ModifyDSPACategoryResponse"/></returns>
        public Task<ModifyDSPACategoryResponse> ModifyDSPACategory(ModifyDSPACategoryRequest req)
        {
            return InternalRequestAsync<ModifyDSPACategoryResponse>(req, "ModifyDSPACategory");
        }

        /// <summary>
        /// 修改分类，内置分类不支持修改。
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPACategoryRequest"/></param>
        /// <returns><see cref="ModifyDSPACategoryResponse"/></returns>
        public ModifyDSPACategoryResponse ModifyDSPACategorySync(ModifyDSPACategoryRequest req)
        {
            return InternalRequestAsync<ModifyDSPACategoryResponse>(req, "ModifyDSPACategory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改分类分级关系
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPACategoryRelationRequest"/></param>
        /// <returns><see cref="ModifyDSPACategoryRelationResponse"/></returns>
        public Task<ModifyDSPACategoryRelationResponse> ModifyDSPACategoryRelation(ModifyDSPACategoryRelationRequest req)
        {
            return InternalRequestAsync<ModifyDSPACategoryRelationResponse>(req, "ModifyDSPACategoryRelation");
        }

        /// <summary>
        /// 修改分类分级关系
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPACategoryRelationRequest"/></param>
        /// <returns><see cref="ModifyDSPACategoryRelationResponse"/></returns>
        public ModifyDSPACategoryRelationResponse ModifyDSPACategoryRelationSync(ModifyDSPACategoryRelationRequest req)
        {
            return InternalRequestAsync<ModifyDSPACategoryRelationResponse>(req, "ModifyDSPACategoryRelation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改DSPA集群信息
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPAClusterInfoRequest"/></param>
        /// <returns><see cref="ModifyDSPAClusterInfoResponse"/></returns>
        public Task<ModifyDSPAClusterInfoResponse> ModifyDSPAClusterInfo(ModifyDSPAClusterInfoRequest req)
        {
            return InternalRequestAsync<ModifyDSPAClusterInfoResponse>(req, "ModifyDSPAClusterInfo");
        }

        /// <summary>
        /// 修改DSPA集群信息
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPAClusterInfoRequest"/></param>
        /// <returns><see cref="ModifyDSPAClusterInfoResponse"/></returns>
        public ModifyDSPAClusterInfoResponse ModifyDSPAClusterInfoSync(ModifyDSPAClusterInfoRequest req)
        {
            return InternalRequestAsync<ModifyDSPAClusterInfoResponse>(req, "ModifyDSPAClusterInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改分类分级模板，内置模板不支持修改。
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPAComplianceGroupRequest"/></param>
        /// <returns><see cref="ModifyDSPAComplianceGroupResponse"/></returns>
        public Task<ModifyDSPAComplianceGroupResponse> ModifyDSPAComplianceGroup(ModifyDSPAComplianceGroupRequest req)
        {
            return InternalRequestAsync<ModifyDSPAComplianceGroupResponse>(req, "ModifyDSPAComplianceGroup");
        }

        /// <summary>
        /// 修改分类分级模板，内置模板不支持修改。
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPAComplianceGroupRequest"/></param>
        /// <returns><see cref="ModifyDSPAComplianceGroupResponse"/></returns>
        public ModifyDSPAComplianceGroupResponse ModifyDSPAComplianceGroupSync(ModifyDSPAComplianceGroupRequest req)
        {
            return InternalRequestAsync<ModifyDSPAComplianceGroupResponse>(req, "ModifyDSPAComplianceGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改分类分级规则，单个用户最多允许创建200个规则。
        /// 注：此API同时适用RDB跟COS类型数据。
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPADiscoveryRuleRequest"/></param>
        /// <returns><see cref="ModifyDSPADiscoveryRuleResponse"/></returns>
        public Task<ModifyDSPADiscoveryRuleResponse> ModifyDSPADiscoveryRule(ModifyDSPADiscoveryRuleRequest req)
        {
            return InternalRequestAsync<ModifyDSPADiscoveryRuleResponse>(req, "ModifyDSPADiscoveryRule");
        }

        /// <summary>
        /// 修改分类分级规则，单个用户最多允许创建200个规则。
        /// 注：此API同时适用RDB跟COS类型数据。
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPADiscoveryRuleRequest"/></param>
        /// <returns><see cref="ModifyDSPADiscoveryRuleResponse"/></returns>
        public ModifyDSPADiscoveryRuleResponse ModifyDSPADiscoveryRuleSync(ModifyDSPADiscoveryRuleRequest req)
        {
            return InternalRequestAsync<ModifyDSPADiscoveryRuleResponse>(req, "ModifyDSPADiscoveryRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改分类分级任务，该接口只有在任务状态为以下状态时才支持正确修改：
        /// 0 待扫描，
        /// 2 扫描终止， 
        /// 3 扫描成功，
        /// 4 扫描失败
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPADiscoveryTaskRequest"/></param>
        /// <returns><see cref="ModifyDSPADiscoveryTaskResponse"/></returns>
        public Task<ModifyDSPADiscoveryTaskResponse> ModifyDSPADiscoveryTask(ModifyDSPADiscoveryTaskRequest req)
        {
            return InternalRequestAsync<ModifyDSPADiscoveryTaskResponse>(req, "ModifyDSPADiscoveryTask");
        }

        /// <summary>
        /// 修改分类分级任务，该接口只有在任务状态为以下状态时才支持正确修改：
        /// 0 待扫描，
        /// 2 扫描终止， 
        /// 3 扫描成功，
        /// 4 扫描失败
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPADiscoveryTaskRequest"/></param>
        /// <returns><see cref="ModifyDSPADiscoveryTaskResponse"/></returns>
        public ModifyDSPADiscoveryTaskResponse ModifyDSPADiscoveryTaskSync(ModifyDSPADiscoveryTaskRequest req)
        {
            return InternalRequestAsync<ModifyDSPADiscoveryTaskResponse>(req, "ModifyDSPADiscoveryTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 调整ES任务扫描结果
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPAESTaskResultRequest"/></param>
        /// <returns><see cref="ModifyDSPAESTaskResultResponse"/></returns>
        public Task<ModifyDSPAESTaskResultResponse> ModifyDSPAESTaskResult(ModifyDSPAESTaskResultRequest req)
        {
            return InternalRequestAsync<ModifyDSPAESTaskResultResponse>(req, "ModifyDSPAESTaskResult");
        }

        /// <summary>
        /// 调整ES任务扫描结果
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPAESTaskResultRequest"/></param>
        /// <returns><see cref="ModifyDSPAESTaskResultResponse"/></returns>
        public ModifyDSPAESTaskResultResponse ModifyDSPAESTaskResultSync(ModifyDSPAESTaskResultRequest req)
        {
            return InternalRequestAsync<ModifyDSPAESTaskResultResponse>(req, "ModifyDSPAESTaskResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 调整任务扫描结果
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPATaskResultRequest"/></param>
        /// <returns><see cref="ModifyDSPATaskResultResponse"/></returns>
        public Task<ModifyDSPATaskResultResponse> ModifyDSPATaskResult(ModifyDSPATaskResultRequest req)
        {
            return InternalRequestAsync<ModifyDSPATaskResultResponse>(req, "ModifyDSPATaskResult");
        }

        /// <summary>
        /// 调整任务扫描结果
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPATaskResultRequest"/></param>
        /// <returns><see cref="ModifyDSPATaskResultResponse"/></returns>
        public ModifyDSPATaskResultResponse ModifyDSPATaskResultSync(ModifyDSPATaskResultRequest req)
        {
            return InternalRequestAsync<ModifyDSPATaskResultResponse>(req, "ModifyDSPATaskResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改敏感级别信息
        /// </summary>
        /// <param name="req"><see cref="ModifyLevelInfoRequest"/></param>
        /// <returns><see cref="ModifyLevelInfoResponse"/></returns>
        public Task<ModifyLevelInfoResponse> ModifyLevelInfo(ModifyLevelInfoRequest req)
        {
            return InternalRequestAsync<ModifyLevelInfoResponse>(req, "ModifyLevelInfo");
        }

        /// <summary>
        /// 修改敏感级别信息
        /// </summary>
        /// <param name="req"><see cref="ModifyLevelInfoRequest"/></param>
        /// <returns><see cref="ModifyLevelInfoResponse"/></returns>
        public ModifyLevelInfoResponse ModifyLevelInfoSync(ModifyLevelInfoRequest req)
        {
            return InternalRequestAsync<ModifyLevelInfoResponse>(req, "ModifyLevelInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改级别名称
        /// </summary>
        /// <param name="req"><see cref="ModifyLevelNameRequest"/></param>
        /// <returns><see cref="ModifyLevelNameResponse"/></returns>
        public Task<ModifyLevelNameResponse> ModifyLevelName(ModifyLevelNameRequest req)
        {
            return InternalRequestAsync<ModifyLevelNameResponse>(req, "ModifyLevelName");
        }

        /// <summary>
        /// 修改级别名称
        /// </summary>
        /// <param name="req"><see cref="ModifyLevelNameRequest"/></param>
        /// <returns><see cref="ModifyLevelNameResponse"/></returns>
        public ModifyLevelNameResponse ModifyLevelNameSync(ModifyLevelNameRequest req)
        {
            return InternalRequestAsync<ModifyLevelNameResponse>(req, "ModifyLevelName")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开启级别或关闭级别
        /// </summary>
        /// <param name="req"><see cref="ModifyLevelStateRequest"/></param>
        /// <returns><see cref="ModifyLevelStateResponse"/></returns>
        public Task<ModifyLevelStateResponse> ModifyLevelState(ModifyLevelStateRequest req)
        {
            return InternalRequestAsync<ModifyLevelStateResponse>(req, "ModifyLevelState");
        }

        /// <summary>
        /// 开启级别或关闭级别
        /// </summary>
        /// <param name="req"><see cref="ModifyLevelStateRequest"/></param>
        /// <returns><see cref="ModifyLevelStateResponse"/></returns>
        public ModifyLevelStateResponse ModifyLevelStateSync(ModifyLevelStateRequest req)
        {
            return InternalRequestAsync<ModifyLevelStateResponse>(req, "ModifyLevelState")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 一个分类合并到另一个分类中（分类拖拽功能）
        /// </summary>
        /// <param name="req"><see cref="ModifyMergeClassificationRequest"/></param>
        /// <returns><see cref="ModifyMergeClassificationResponse"/></returns>
        public Task<ModifyMergeClassificationResponse> ModifyMergeClassification(ModifyMergeClassificationRequest req)
        {
            return InternalRequestAsync<ModifyMergeClassificationResponse>(req, "ModifyMergeClassification");
        }

        /// <summary>
        /// 一个分类合并到另一个分类中（分类拖拽功能）
        /// </summary>
        /// <param name="req"><see cref="ModifyMergeClassificationRequest"/></param>
        /// <returns><see cref="ModifyMergeClassificationResponse"/></returns>
        public ModifyMergeClassificationResponse ModifyMergeClassificationSync(ModifyMergeClassificationRequest req)
        {
            return InternalRequestAsync<ModifyMergeClassificationResponse>(req, "ModifyMergeClassification")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改分类信息
        /// </summary>
        /// <param name="req"><see cref="ModifyNewClassificationRequest"/></param>
        /// <returns><see cref="ModifyNewClassificationResponse"/></returns>
        public Task<ModifyNewClassificationResponse> ModifyNewClassification(ModifyNewClassificationRequest req)
        {
            return InternalRequestAsync<ModifyNewClassificationResponse>(req, "ModifyNewClassification");
        }

        /// <summary>
        /// 修改分类信息
        /// </summary>
        /// <param name="req"><see cref="ModifyNewClassificationRequest"/></param>
        /// <returns><see cref="ModifyNewClassificationResponse"/></returns>
        public ModifyNewClassificationResponse ModifyNewClassificationSync(ModifyNewClassificationRequest req)
        {
            return InternalRequestAsync<ModifyNewClassificationResponse>(req, "ModifyNewClassification")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改分级分类模板信息
        /// </summary>
        /// <param name="req"><see cref="ModifyStandardInfoRequest"/></param>
        /// <returns><see cref="ModifyStandardInfoResponse"/></returns>
        public Task<ModifyStandardInfoResponse> ModifyStandardInfo(ModifyStandardInfoRequest req)
        {
            return InternalRequestAsync<ModifyStandardInfoResponse>(req, "ModifyStandardInfo");
        }

        /// <summary>
        /// 修改分级分类模板信息
        /// </summary>
        /// <param name="req"><see cref="ModifyStandardInfoRequest"/></param>
        /// <returns><see cref="ModifyStandardInfoResponse"/></returns>
        public ModifyStandardInfoResponse ModifyStandardInfoSync(ModifyStandardInfoRequest req)
        {
            return InternalRequestAsync<ModifyStandardInfoResponse>(req, "ModifyStandardInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询DSPA实例的db列表
        /// </summary>
        /// <param name="req"><see cref="QueryDSPAMetaResourceDbListRequest"/></param>
        /// <returns><see cref="QueryDSPAMetaResourceDbListResponse"/></returns>
        public Task<QueryDSPAMetaResourceDbListResponse> QueryDSPAMetaResourceDbList(QueryDSPAMetaResourceDbListRequest req)
        {
            return InternalRequestAsync<QueryDSPAMetaResourceDbListResponse>(req, "QueryDSPAMetaResourceDbList");
        }

        /// <summary>
        /// 查询DSPA实例的db列表
        /// </summary>
        /// <param name="req"><see cref="QueryDSPAMetaResourceDbListRequest"/></param>
        /// <returns><see cref="QueryDSPAMetaResourceDbListResponse"/></returns>
        public QueryDSPAMetaResourceDbListResponse QueryDSPAMetaResourceDbListSync(QueryDSPAMetaResourceDbListRequest req)
        {
            return InternalRequestAsync<QueryDSPAMetaResourceDbListResponse>(req, "QueryDSPAMetaResourceDbList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取资源绑定DB状态
        /// </summary>
        /// <param name="req"><see cref="QueryResourceDbBindStatusRequest"/></param>
        /// <returns><see cref="QueryResourceDbBindStatusResponse"/></returns>
        public Task<QueryResourceDbBindStatusResponse> QueryResourceDbBindStatus(QueryResourceDbBindStatusRequest req)
        {
            return InternalRequestAsync<QueryResourceDbBindStatusResponse>(req, "QueryResourceDbBindStatus");
        }

        /// <summary>
        /// 获取资源绑定DB状态
        /// </summary>
        /// <param name="req"><see cref="QueryResourceDbBindStatusRequest"/></param>
        /// <returns><see cref="QueryResourceDbBindStatusResponse"/></returns>
        public QueryResourceDbBindStatusResponse QueryResourceDbBindStatusSync(QueryResourceDbBindStatusRequest req)
        {
            return InternalRequestAsync<QueryResourceDbBindStatusResponse>(req, "QueryResourceDbBindStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重新启动DSPA风险评估任务
        /// </summary>
        /// <param name="req"><see cref="RestartDSPAAssessmentTaskRequest"/></param>
        /// <returns><see cref="RestartDSPAAssessmentTaskResponse"/></returns>
        public Task<RestartDSPAAssessmentTaskResponse> RestartDSPAAssessmentTask(RestartDSPAAssessmentTaskRequest req)
        {
            return InternalRequestAsync<RestartDSPAAssessmentTaskResponse>(req, "RestartDSPAAssessmentTask");
        }

        /// <summary>
        /// 重新启动DSPA风险评估任务
        /// </summary>
        /// <param name="req"><see cref="RestartDSPAAssessmentTaskRequest"/></param>
        /// <returns><see cref="RestartDSPAAssessmentTaskResponse"/></returns>
        public RestartDSPAAssessmentTaskResponse RestartDSPAAssessmentTaskSync(RestartDSPAAssessmentTaskRequest req)
        {
            return InternalRequestAsync<RestartDSPAAssessmentTaskResponse>(req, "RestartDSPAAssessmentTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 立即启动分类分级任务，该接口只有在任务状态为以下状态时才支持正确执行立即扫描：
        /// 0 待扫描，
        /// 2 扫描终止，
        /// 3 扫描成功，
        /// 4 扫描失败
        /// </summary>
        /// <param name="req"><see cref="StartDSPADiscoveryTaskRequest"/></param>
        /// <returns><see cref="StartDSPADiscoveryTaskResponse"/></returns>
        public Task<StartDSPADiscoveryTaskResponse> StartDSPADiscoveryTask(StartDSPADiscoveryTaskRequest req)
        {
            return InternalRequestAsync<StartDSPADiscoveryTaskResponse>(req, "StartDSPADiscoveryTask");
        }

        /// <summary>
        /// 立即启动分类分级任务，该接口只有在任务状态为以下状态时才支持正确执行立即扫描：
        /// 0 待扫描，
        /// 2 扫描终止，
        /// 3 扫描成功，
        /// 4 扫描失败
        /// </summary>
        /// <param name="req"><see cref="StartDSPADiscoveryTaskRequest"/></param>
        /// <returns><see cref="StartDSPADiscoveryTaskResponse"/></returns>
        public StartDSPADiscoveryTaskResponse StartDSPADiscoveryTaskSync(StartDSPADiscoveryTaskRequest req)
        {
            return InternalRequestAsync<StartDSPADiscoveryTaskResponse>(req, "StartDSPADiscoveryTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止分类分级任务，该接口只有在任务状态为以下状态时才支持正确执行停止扫描：
        /// 1 扫描中
        /// </summary>
        /// <param name="req"><see cref="StopDSPADiscoveryTaskRequest"/></param>
        /// <returns><see cref="StopDSPADiscoveryTaskResponse"/></returns>
        public Task<StopDSPADiscoveryTaskResponse> StopDSPADiscoveryTask(StopDSPADiscoveryTaskRequest req)
        {
            return InternalRequestAsync<StopDSPADiscoveryTaskResponse>(req, "StopDSPADiscoveryTask");
        }

        /// <summary>
        /// 停止分类分级任务，该接口只有在任务状态为以下状态时才支持正确执行停止扫描：
        /// 1 扫描中
        /// </summary>
        /// <param name="req"><see cref="StopDSPADiscoveryTaskRequest"/></param>
        /// <returns><see cref="StopDSPADiscoveryTaskResponse"/></returns>
        public StopDSPADiscoveryTaskResponse StopDSPADiscoveryTaskSync(StopDSPADiscoveryTaskRequest req)
        {
            return InternalRequestAsync<StopDSPADiscoveryTaskResponse>(req, "StopDSPADiscoveryTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新自建资源基础信息，包括：端口、账户名、密码。
        /// 请注意：
        /// 如果资源自身的VPC、VIP信息发生变化，后台会自动更新。
        /// 如果监听的端口发生变化，请显式输入端口。
        /// 如果账户名密码任意一个发生变化，请务必同时显式输入账户名密码。
        /// </summary>
        /// <param name="req"><see cref="UpdateDSPASelfBuildResourceRequest"/></param>
        /// <returns><see cref="UpdateDSPASelfBuildResourceResponse"/></returns>
        public Task<UpdateDSPASelfBuildResourceResponse> UpdateDSPASelfBuildResource(UpdateDSPASelfBuildResourceRequest req)
        {
            return InternalRequestAsync<UpdateDSPASelfBuildResourceResponse>(req, "UpdateDSPASelfBuildResource");
        }

        /// <summary>
        /// 更新自建资源基础信息，包括：端口、账户名、密码。
        /// 请注意：
        /// 如果资源自身的VPC、VIP信息发生变化，后台会自动更新。
        /// 如果监听的端口发生变化，请显式输入端口。
        /// 如果账户名密码任意一个发生变化，请务必同时显式输入账户名密码。
        /// </summary>
        /// <param name="req"><see cref="UpdateDSPASelfBuildResourceRequest"/></param>
        /// <returns><see cref="UpdateDSPASelfBuildResourceResponse"/></returns>
        public UpdateDSPASelfBuildResourceResponse UpdateDSPASelfBuildResourceSync(UpdateDSPASelfBuildResourceRequest req)
        {
            return InternalRequestAsync<UpdateDSPASelfBuildResourceResponse>(req, "UpdateDSPASelfBuildResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 验证COS分类分级规则
        /// </summary>
        /// <param name="req"><see cref="VerifyDSPACOSRuleRequest"/></param>
        /// <returns><see cref="VerifyDSPACOSRuleResponse"/></returns>
        public Task<VerifyDSPACOSRuleResponse> VerifyDSPACOSRule(VerifyDSPACOSRuleRequest req)
        {
            return InternalRequestAsync<VerifyDSPACOSRuleResponse>(req, "VerifyDSPACOSRule");
        }

        /// <summary>
        /// 验证COS分类分级规则
        /// </summary>
        /// <param name="req"><see cref="VerifyDSPACOSRuleRequest"/></param>
        /// <returns><see cref="VerifyDSPACOSRuleResponse"/></returns>
        public VerifyDSPACOSRuleResponse VerifyDSPACOSRuleSync(VerifyDSPACOSRuleRequest req)
        {
            return InternalRequestAsync<VerifyDSPACOSRuleResponse>(req, "VerifyDSPACOSRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 验证分类分级规则
        /// </summary>
        /// <param name="req"><see cref="VerifyDSPADiscoveryRuleRequest"/></param>
        /// <returns><see cref="VerifyDSPADiscoveryRuleResponse"/></returns>
        public Task<VerifyDSPADiscoveryRuleResponse> VerifyDSPADiscoveryRule(VerifyDSPADiscoveryRuleRequest req)
        {
            return InternalRequestAsync<VerifyDSPADiscoveryRuleResponse>(req, "VerifyDSPADiscoveryRule");
        }

        /// <summary>
        /// 验证分类分级规则
        /// </summary>
        /// <param name="req"><see cref="VerifyDSPADiscoveryRuleRequest"/></param>
        /// <returns><see cref="VerifyDSPADiscoveryRuleResponse"/></returns>
        public VerifyDSPADiscoveryRuleResponse VerifyDSPADiscoveryRuleSync(VerifyDSPADiscoveryRuleRequest req)
        {
            return InternalRequestAsync<VerifyDSPADiscoveryRuleResponse>(req, "VerifyDSPADiscoveryRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}

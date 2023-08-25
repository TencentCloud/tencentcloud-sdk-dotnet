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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DsgcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 授权用户云资源
        /// </summary>
        /// <param name="req"><see cref="AuthorizeDSPAMetaResourcesRequest"/></param>
        /// <returns><see cref="AuthorizeDSPAMetaResourcesResponse"/></returns>
        public async Task<AuthorizeDSPAMetaResourcesResponse> AuthorizeDSPAMetaResources(AuthorizeDSPAMetaResourcesRequest req)
        {
             JsonResponseModel<AuthorizeDSPAMetaResourcesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AuthorizeDSPAMetaResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AuthorizeDSPAMetaResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 授权用户云资源
        /// </summary>
        /// <param name="req"><see cref="AuthorizeDSPAMetaResourcesRequest"/></param>
        /// <returns><see cref="AuthorizeDSPAMetaResourcesResponse"/></returns>
        public AuthorizeDSPAMetaResourcesResponse AuthorizeDSPAMetaResourcesSync(AuthorizeDSPAMetaResourcesRequest req)
        {
             JsonResponseModel<AuthorizeDSPAMetaResourcesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AuthorizeDSPAMetaResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AuthorizeDSPAMetaResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 绑定或解绑COS桶
        /// </summary>
        /// <param name="req"><see cref="BindDSPAResourceCosBucketsRequest"/></param>
        /// <returns><see cref="BindDSPAResourceCosBucketsResponse"/></returns>
        public async Task<BindDSPAResourceCosBucketsResponse> BindDSPAResourceCosBuckets(BindDSPAResourceCosBucketsRequest req)
        {
             JsonResponseModel<BindDSPAResourceCosBucketsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindDSPAResourceCosBuckets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindDSPAResourceCosBucketsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 绑定或解绑COS桶
        /// </summary>
        /// <param name="req"><see cref="BindDSPAResourceCosBucketsRequest"/></param>
        /// <returns><see cref="BindDSPAResourceCosBucketsResponse"/></returns>
        public BindDSPAResourceCosBucketsResponse BindDSPAResourceCosBucketsSync(BindDSPAResourceCosBucketsRequest req)
        {
             JsonResponseModel<BindDSPAResourceCosBucketsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindDSPAResourceCosBuckets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindDSPAResourceCosBucketsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 绑定或解绑数据库实例DB
        /// </summary>
        /// <param name="req"><see cref="BindDSPAResourceDatabasesRequest"/></param>
        /// <returns><see cref="BindDSPAResourceDatabasesResponse"/></returns>
        public async Task<BindDSPAResourceDatabasesResponse> BindDSPAResourceDatabases(BindDSPAResourceDatabasesRequest req)
        {
             JsonResponseModel<BindDSPAResourceDatabasesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindDSPAResourceDatabases");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindDSPAResourceDatabasesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 绑定或解绑数据库实例DB
        /// </summary>
        /// <param name="req"><see cref="BindDSPAResourceDatabasesRequest"/></param>
        /// <returns><see cref="BindDSPAResourceDatabasesResponse"/></returns>
        public BindDSPAResourceDatabasesResponse BindDSPAResourceDatabasesSync(BindDSPAResourceDatabasesRequest req)
        {
             JsonResponseModel<BindDSPAResourceDatabasesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindDSPAResourceDatabases");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindDSPAResourceDatabasesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 复制合规组模版
        /// </summary>
        /// <param name="req"><see cref="CopyDSPATemplateRequest"/></param>
        /// <returns><see cref="CopyDSPATemplateResponse"/></returns>
        public async Task<CopyDSPATemplateResponse> CopyDSPATemplate(CopyDSPATemplateRequest req)
        {
             JsonResponseModel<CopyDSPATemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CopyDSPATemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CopyDSPATemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 复制合规组模版
        /// </summary>
        /// <param name="req"><see cref="CopyDSPATemplateRequest"/></param>
        /// <returns><see cref="CopyDSPATemplateResponse"/></returns>
        public CopyDSPATemplateResponse CopyDSPATemplateSync(CopyDSPATemplateRequest req)
        {
             JsonResponseModel<CopyDSPATemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CopyDSPATemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CopyDSPATemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建资产梳理报表导出重试任务
        /// </summary>
        /// <param name="req"><see cref="CreateAssetSortingReportRetryTaskRequest"/></param>
        /// <returns><see cref="CreateAssetSortingReportRetryTaskResponse"/></returns>
        public async Task<CreateAssetSortingReportRetryTaskResponse> CreateAssetSortingReportRetryTask(CreateAssetSortingReportRetryTaskRequest req)
        {
             JsonResponseModel<CreateAssetSortingReportRetryTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAssetSortingReportRetryTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAssetSortingReportRetryTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建资产梳理报表导出重试任务
        /// </summary>
        /// <param name="req"><see cref="CreateAssetSortingReportRetryTaskRequest"/></param>
        /// <returns><see cref="CreateAssetSortingReportRetryTaskResponse"/></returns>
        public CreateAssetSortingReportRetryTaskResponse CreateAssetSortingReportRetryTaskSync(CreateAssetSortingReportRetryTaskRequest req)
        {
             JsonResponseModel<CreateAssetSortingReportRetryTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAssetSortingReportRetryTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAssetSortingReportRetryTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建资产梳理报告任务
        /// </summary>
        /// <param name="req"><see cref="CreateAssetSortingReportTaskRequest"/></param>
        /// <returns><see cref="CreateAssetSortingReportTaskResponse"/></returns>
        public async Task<CreateAssetSortingReportTaskResponse> CreateAssetSortingReportTask(CreateAssetSortingReportTaskRequest req)
        {
             JsonResponseModel<CreateAssetSortingReportTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAssetSortingReportTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAssetSortingReportTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建资产梳理报告任务
        /// </summary>
        /// <param name="req"><see cref="CreateAssetSortingReportTaskRequest"/></param>
        /// <returns><see cref="CreateAssetSortingReportTaskResponse"/></returns>
        public CreateAssetSortingReportTaskResponse CreateAssetSortingReportTaskSync(CreateAssetSortingReportTaskRequest req)
        {
             JsonResponseModel<CreateAssetSortingReportTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAssetSortingReportTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAssetSortingReportTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建识别规则
        /// </summary>
        /// <param name="req"><see cref="CreateClassificationRuleRequest"/></param>
        /// <returns><see cref="CreateClassificationRuleResponse"/></returns>
        public async Task<CreateClassificationRuleResponse> CreateClassificationRule(CreateClassificationRuleRequest req)
        {
             JsonResponseModel<CreateClassificationRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateClassificationRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClassificationRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建识别规则
        /// </summary>
        /// <param name="req"><see cref="CreateClassificationRuleRequest"/></param>
        /// <returns><see cref="CreateClassificationRuleResponse"/></returns>
        public CreateClassificationRuleResponse CreateClassificationRuleSync(CreateClassificationRuleRequest req)
        {
             JsonResponseModel<CreateClassificationRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateClassificationRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateClassificationRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 风险项页面---创建风险等级
        /// </summary>
        /// <param name="req"><see cref="CreateDSPAAssessmentRiskLevelRequest"/></param>
        /// <returns><see cref="CreateDSPAAssessmentRiskLevelResponse"/></returns>
        public async Task<CreateDSPAAssessmentRiskLevelResponse> CreateDSPAAssessmentRiskLevel(CreateDSPAAssessmentRiskLevelRequest req)
        {
             JsonResponseModel<CreateDSPAAssessmentRiskLevelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDSPAAssessmentRiskLevel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDSPAAssessmentRiskLevelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 风险项页面---创建风险等级
        /// </summary>
        /// <param name="req"><see cref="CreateDSPAAssessmentRiskLevelRequest"/></param>
        /// <returns><see cref="CreateDSPAAssessmentRiskLevelResponse"/></returns>
        public CreateDSPAAssessmentRiskLevelResponse CreateDSPAAssessmentRiskLevelSync(CreateDSPAAssessmentRiskLevelRequest req)
        {
             JsonResponseModel<CreateDSPAAssessmentRiskLevelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDSPAAssessmentRiskLevel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDSPAAssessmentRiskLevelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 风险评估模版---创建风险评估模版
        /// </summary>
        /// <param name="req"><see cref="CreateDSPAAssessmentRiskTemplateRequest"/></param>
        /// <returns><see cref="CreateDSPAAssessmentRiskTemplateResponse"/></returns>
        public async Task<CreateDSPAAssessmentRiskTemplateResponse> CreateDSPAAssessmentRiskTemplate(CreateDSPAAssessmentRiskTemplateRequest req)
        {
             JsonResponseModel<CreateDSPAAssessmentRiskTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDSPAAssessmentRiskTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDSPAAssessmentRiskTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 风险评估模版---创建风险评估模版
        /// </summary>
        /// <param name="req"><see cref="CreateDSPAAssessmentRiskTemplateRequest"/></param>
        /// <returns><see cref="CreateDSPAAssessmentRiskTemplateResponse"/></returns>
        public CreateDSPAAssessmentRiskTemplateResponse CreateDSPAAssessmentRiskTemplateSync(CreateDSPAAssessmentRiskTemplateRequest req)
        {
             JsonResponseModel<CreateDSPAAssessmentRiskTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDSPAAssessmentRiskTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDSPAAssessmentRiskTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建DSPA风险评估任务
        /// </summary>
        /// <param name="req"><see cref="CreateDSPAAssessmentTaskRequest"/></param>
        /// <returns><see cref="CreateDSPAAssessmentTaskResponse"/></returns>
        public async Task<CreateDSPAAssessmentTaskResponse> CreateDSPAAssessmentTask(CreateDSPAAssessmentTaskRequest req)
        {
             JsonResponseModel<CreateDSPAAssessmentTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDSPAAssessmentTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDSPAAssessmentTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建DSPA风险评估任务
        /// </summary>
        /// <param name="req"><see cref="CreateDSPAAssessmentTaskRequest"/></param>
        /// <returns><see cref="CreateDSPAAssessmentTaskResponse"/></returns>
        public CreateDSPAAssessmentTaskResponse CreateDSPAAssessmentTaskSync(CreateDSPAAssessmentTaskRequest req)
        {
             JsonResponseModel<CreateDSPAAssessmentTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDSPAAssessmentTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDSPAAssessmentTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增COS分类分级扫描任务，单个用户最多允许创建100个任务。
        /// </summary>
        /// <param name="req"><see cref="CreateDSPACOSDiscoveryTaskRequest"/></param>
        /// <returns><see cref="CreateDSPACOSDiscoveryTaskResponse"/></returns>
        public async Task<CreateDSPACOSDiscoveryTaskResponse> CreateDSPACOSDiscoveryTask(CreateDSPACOSDiscoveryTaskRequest req)
        {
             JsonResponseModel<CreateDSPACOSDiscoveryTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDSPACOSDiscoveryTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDSPACOSDiscoveryTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增COS分类分级扫描任务，单个用户最多允许创建100个任务。
        /// </summary>
        /// <param name="req"><see cref="CreateDSPACOSDiscoveryTaskRequest"/></param>
        /// <returns><see cref="CreateDSPACOSDiscoveryTaskResponse"/></returns>
        public CreateDSPACOSDiscoveryTaskResponse CreateDSPACOSDiscoveryTaskSync(CreateDSPACOSDiscoveryTaskRequest req)
        {
             JsonResponseModel<CreateDSPACOSDiscoveryTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDSPACOSDiscoveryTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDSPACOSDiscoveryTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增分类，单个用户最多允许创建100个数据分类。
        /// </summary>
        /// <param name="req"><see cref="CreateDSPACategoryRequest"/></param>
        /// <returns><see cref="CreateDSPACategoryResponse"/></returns>
        public async Task<CreateDSPACategoryResponse> CreateDSPACategory(CreateDSPACategoryRequest req)
        {
             JsonResponseModel<CreateDSPACategoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDSPACategory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDSPACategoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增分类，单个用户最多允许创建100个数据分类。
        /// </summary>
        /// <param name="req"><see cref="CreateDSPACategoryRequest"/></param>
        /// <returns><see cref="CreateDSPACategoryResponse"/></returns>
        public CreateDSPACategoryResponse CreateDSPACategorySync(CreateDSPACategoryRequest req)
        {
             JsonResponseModel<CreateDSPACategoryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDSPACategory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDSPACategoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建分类关联关系
        /// </summary>
        /// <param name="req"><see cref="CreateDSPACategoryRelationRequest"/></param>
        /// <returns><see cref="CreateDSPACategoryRelationResponse"/></returns>
        public async Task<CreateDSPACategoryRelationResponse> CreateDSPACategoryRelation(CreateDSPACategoryRelationRequest req)
        {
             JsonResponseModel<CreateDSPACategoryRelationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDSPACategoryRelation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDSPACategoryRelationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建分类关联关系
        /// </summary>
        /// <param name="req"><see cref="CreateDSPACategoryRelationRequest"/></param>
        /// <returns><see cref="CreateDSPACategoryRelationResponse"/></returns>
        public CreateDSPACategoryRelationResponse CreateDSPACategoryRelationSync(CreateDSPACategoryRelationRequest req)
        {
             JsonResponseModel<CreateDSPACategoryRelationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDSPACategoryRelation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDSPACategoryRelationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增分类分级模板，单个用户最多允许创建100个合规组。
        /// </summary>
        /// <param name="req"><see cref="CreateDSPAComplianceGroupRequest"/></param>
        /// <returns><see cref="CreateDSPAComplianceGroupResponse"/></returns>
        public async Task<CreateDSPAComplianceGroupResponse> CreateDSPAComplianceGroup(CreateDSPAComplianceGroupRequest req)
        {
             JsonResponseModel<CreateDSPAComplianceGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDSPAComplianceGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDSPAComplianceGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增分类分级模板，单个用户最多允许创建100个合规组。
        /// </summary>
        /// <param name="req"><see cref="CreateDSPAComplianceGroupRequest"/></param>
        /// <returns><see cref="CreateDSPAComplianceGroupResponse"/></returns>
        public CreateDSPAComplianceGroupResponse CreateDSPAComplianceGroupSync(CreateDSPAComplianceGroupRequest req)
        {
             JsonResponseModel<CreateDSPAComplianceGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDSPAComplianceGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDSPAComplianceGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建合规组分类规则关联关系
        /// </summary>
        /// <param name="req"><see cref="CreateDSPAComplianceRulesRequest"/></param>
        /// <returns><see cref="CreateDSPAComplianceRulesResponse"/></returns>
        public async Task<CreateDSPAComplianceRulesResponse> CreateDSPAComplianceRules(CreateDSPAComplianceRulesRequest req)
        {
             JsonResponseModel<CreateDSPAComplianceRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDSPAComplianceRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDSPAComplianceRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建合规组分类规则关联关系
        /// </summary>
        /// <param name="req"><see cref="CreateDSPAComplianceRulesRequest"/></param>
        /// <returns><see cref="CreateDSPAComplianceRulesResponse"/></returns>
        public CreateDSPAComplianceRulesResponse CreateDSPAComplianceRulesSync(CreateDSPAComplianceRulesRequest req)
        {
             JsonResponseModel<CreateDSPAComplianceRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDSPAComplianceRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDSPAComplianceRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加COS元数据
        /// </summary>
        /// <param name="req"><see cref="CreateDSPACosMetaResourcesRequest"/></param>
        /// <returns><see cref="CreateDSPACosMetaResourcesResponse"/></returns>
        public async Task<CreateDSPACosMetaResourcesResponse> CreateDSPACosMetaResources(CreateDSPACosMetaResourcesRequest req)
        {
             JsonResponseModel<CreateDSPACosMetaResourcesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDSPACosMetaResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDSPACosMetaResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加COS元数据
        /// </summary>
        /// <param name="req"><see cref="CreateDSPACosMetaResourcesRequest"/></param>
        /// <returns><see cref="CreateDSPACosMetaResourcesResponse"/></returns>
        public CreateDSPACosMetaResourcesResponse CreateDSPACosMetaResourcesSync(CreateDSPACosMetaResourcesRequest req)
        {
             JsonResponseModel<CreateDSPACosMetaResourcesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDSPACosMetaResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDSPACosMetaResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加用户云上数据库类型资源
        /// </summary>
        /// <param name="req"><see cref="CreateDSPADbMetaResourcesRequest"/></param>
        /// <returns><see cref="CreateDSPADbMetaResourcesResponse"/></returns>
        public async Task<CreateDSPADbMetaResourcesResponse> CreateDSPADbMetaResources(CreateDSPADbMetaResourcesRequest req)
        {
             JsonResponseModel<CreateDSPADbMetaResourcesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDSPADbMetaResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDSPADbMetaResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加用户云上数据库类型资源
        /// </summary>
        /// <param name="req"><see cref="CreateDSPADbMetaResourcesRequest"/></param>
        /// <returns><see cref="CreateDSPADbMetaResourcesResponse"/></returns>
        public CreateDSPADbMetaResourcesResponse CreateDSPADbMetaResourcesSync(CreateDSPADbMetaResourcesRequest req)
        {
             JsonResponseModel<CreateDSPADbMetaResourcesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDSPADbMetaResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDSPADbMetaResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增分类分级规则，单个用户最多允许创建200个规则。
        /// </summary>
        /// <param name="req"><see cref="CreateDSPADiscoveryRuleRequest"/></param>
        /// <returns><see cref="CreateDSPADiscoveryRuleResponse"/></returns>
        public async Task<CreateDSPADiscoveryRuleResponse> CreateDSPADiscoveryRule(CreateDSPADiscoveryRuleRequest req)
        {
             JsonResponseModel<CreateDSPADiscoveryRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDSPADiscoveryRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDSPADiscoveryRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增分类分级规则，单个用户最多允许创建200个规则。
        /// </summary>
        /// <param name="req"><see cref="CreateDSPADiscoveryRuleRequest"/></param>
        /// <returns><see cref="CreateDSPADiscoveryRuleResponse"/></returns>
        public CreateDSPADiscoveryRuleResponse CreateDSPADiscoveryRuleSync(CreateDSPADiscoveryRuleRequest req)
        {
             JsonResponseModel<CreateDSPADiscoveryRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDSPADiscoveryRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDSPADiscoveryRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增分类分级任务，单个用户最多允许创建100个任务。
        /// </summary>
        /// <param name="req"><see cref="CreateDSPADiscoveryTaskRequest"/></param>
        /// <returns><see cref="CreateDSPADiscoveryTaskResponse"/></returns>
        public async Task<CreateDSPADiscoveryTaskResponse> CreateDSPADiscoveryTask(CreateDSPADiscoveryTaskRequest req)
        {
             JsonResponseModel<CreateDSPADiscoveryTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDSPADiscoveryTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDSPADiscoveryTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增分类分级任务，单个用户最多允许创建100个任务。
        /// </summary>
        /// <param name="req"><see cref="CreateDSPADiscoveryTaskRequest"/></param>
        /// <returns><see cref="CreateDSPADiscoveryTaskResponse"/></returns>
        public CreateDSPADiscoveryTaskResponse CreateDSPADiscoveryTaskSync(CreateDSPADiscoveryTaskRequest req)
        {
             JsonResponseModel<CreateDSPADiscoveryTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDSPADiscoveryTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDSPADiscoveryTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增分级，单个Casb实例最多允许创建100个数据分级
        /// </summary>
        /// <param name="req"><see cref="CreateDSPALevelGroupRequest"/></param>
        /// <returns><see cref="CreateDSPALevelGroupResponse"/></returns>
        public async Task<CreateDSPALevelGroupResponse> CreateDSPALevelGroup(CreateDSPALevelGroupRequest req)
        {
             JsonResponseModel<CreateDSPALevelGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDSPALevelGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDSPALevelGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新增分级，单个Casb实例最多允许创建100个数据分级
        /// </summary>
        /// <param name="req"><see cref="CreateDSPALevelGroupRequest"/></param>
        /// <returns><see cref="CreateDSPALevelGroupResponse"/></returns>
        public CreateDSPALevelGroupResponse CreateDSPALevelGroupSync(CreateDSPALevelGroupRequest req)
        {
             JsonResponseModel<CreateDSPALevelGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDSPALevelGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDSPALevelGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加用户云上资源列表
        /// </summary>
        /// <param name="req"><see cref="CreateDSPAMetaResourcesRequest"/></param>
        /// <returns><see cref="CreateDSPAMetaResourcesResponse"/></returns>
        public async Task<CreateDSPAMetaResourcesResponse> CreateDSPAMetaResources(CreateDSPAMetaResourcesRequest req)
        {
             JsonResponseModel<CreateDSPAMetaResourcesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDSPAMetaResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDSPAMetaResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加用户云上资源列表
        /// </summary>
        /// <param name="req"><see cref="CreateDSPAMetaResourcesRequest"/></param>
        /// <returns><see cref="CreateDSPAMetaResourcesResponse"/></returns>
        public CreateDSPAMetaResourcesResponse CreateDSPAMetaResourcesSync(CreateDSPAMetaResourcesRequest req)
        {
             JsonResponseModel<CreateDSPAMetaResourcesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDSPAMetaResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDSPAMetaResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建用户自建云资源
        /// </summary>
        /// <param name="req"><see cref="CreateDSPASelfBuildMetaResourceRequest"/></param>
        /// <returns><see cref="CreateDSPASelfBuildMetaResourceResponse"/></returns>
        public async Task<CreateDSPASelfBuildMetaResourceResponse> CreateDSPASelfBuildMetaResource(CreateDSPASelfBuildMetaResourceRequest req)
        {
             JsonResponseModel<CreateDSPASelfBuildMetaResourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDSPASelfBuildMetaResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDSPASelfBuildMetaResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建用户自建云资源
        /// </summary>
        /// <param name="req"><see cref="CreateDSPASelfBuildMetaResourceRequest"/></param>
        /// <returns><see cref="CreateDSPASelfBuildMetaResourceResponse"/></returns>
        public CreateDSPASelfBuildMetaResourceResponse CreateDSPASelfBuildMetaResourceSync(CreateDSPASelfBuildMetaResourceRequest req)
        {
             JsonResponseModel<CreateDSPASelfBuildMetaResourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDSPASelfBuildMetaResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDSPASelfBuildMetaResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建规则别名
        /// </summary>
        /// <param name="req"><see cref="CreateIdentifyRuleAnotherNameRequest"/></param>
        /// <returns><see cref="CreateIdentifyRuleAnotherNameResponse"/></returns>
        public async Task<CreateIdentifyRuleAnotherNameResponse> CreateIdentifyRuleAnotherName(CreateIdentifyRuleAnotherNameRequest req)
        {
             JsonResponseModel<CreateIdentifyRuleAnotherNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateIdentifyRuleAnotherName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIdentifyRuleAnotherNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建规则别名
        /// </summary>
        /// <param name="req"><see cref="CreateIdentifyRuleAnotherNameRequest"/></param>
        /// <returns><see cref="CreateIdentifyRuleAnotherNameResponse"/></returns>
        public CreateIdentifyRuleAnotherNameResponse CreateIdentifyRuleAnotherNameSync(CreateIdentifyRuleAnotherNameRequest req)
        {
             JsonResponseModel<CreateIdentifyRuleAnotherNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateIdentifyRuleAnotherName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateIdentifyRuleAnotherNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建新分类
        /// </summary>
        /// <param name="req"><see cref="CreateNewClassificationRequest"/></param>
        /// <returns><see cref="CreateNewClassificationResponse"/></returns>
        public async Task<CreateNewClassificationResponse> CreateNewClassification(CreateNewClassificationRequest req)
        {
             JsonResponseModel<CreateNewClassificationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNewClassification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNewClassificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建新分类
        /// </summary>
        /// <param name="req"><see cref="CreateNewClassificationRequest"/></param>
        /// <returns><see cref="CreateNewClassificationResponse"/></returns>
        public CreateNewClassificationResponse CreateNewClassificationSync(CreateNewClassificationRequest req)
        {
             JsonResponseModel<CreateNewClassificationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateNewClassification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNewClassificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建或复制分级分类模板
        /// </summary>
        /// <param name="req"><see cref="CreateOrCopyStandardRequest"/></param>
        /// <returns><see cref="CreateOrCopyStandardResponse"/></returns>
        public async Task<CreateOrCopyStandardResponse> CreateOrCopyStandard(CreateOrCopyStandardRequest req)
        {
             JsonResponseModel<CreateOrCopyStandardResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateOrCopyStandard");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOrCopyStandardResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建或复制分级分类模板
        /// </summary>
        /// <param name="req"><see cref="CreateOrCopyStandardRequest"/></param>
        /// <returns><see cref="CreateOrCopyStandardResponse"/></returns>
        public CreateOrCopyStandardResponse CreateOrCopyStandardSync(CreateOrCopyStandardRequest req)
        {
             JsonResponseModel<CreateOrCopyStandardResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateOrCopyStandard");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOrCopyStandardResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 风险等级的定义页面-创建风险等级的时候生成的一个默认的矩阵
        /// </summary>
        /// <param name="req"><see cref="DecribeSuggestRiskLevelMatrixRequest"/></param>
        /// <returns><see cref="DecribeSuggestRiskLevelMatrixResponse"/></returns>
        public async Task<DecribeSuggestRiskLevelMatrixResponse> DecribeSuggestRiskLevelMatrix(DecribeSuggestRiskLevelMatrixRequest req)
        {
             JsonResponseModel<DecribeSuggestRiskLevelMatrixResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DecribeSuggestRiskLevelMatrix");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DecribeSuggestRiskLevelMatrixResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 风险等级的定义页面-创建风险等级的时候生成的一个默认的矩阵
        /// </summary>
        /// <param name="req"><see cref="DecribeSuggestRiskLevelMatrixRequest"/></param>
        /// <returns><see cref="DecribeSuggestRiskLevelMatrixResponse"/></returns>
        public DecribeSuggestRiskLevelMatrixResponse DecribeSuggestRiskLevelMatrixSync(DecribeSuggestRiskLevelMatrixRequest req)
        {
             JsonResponseModel<DecribeSuggestRiskLevelMatrixResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DecribeSuggestRiskLevelMatrix");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DecribeSuggestRiskLevelMatrixResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteCOSMetaData）用于删除COS元数据信息。
        /// </summary>
        /// <param name="req"><see cref="DeleteCosMetaResourceRequest"/></param>
        /// <returns><see cref="DeleteCosMetaResourceResponse"/></returns>
        public async Task<DeleteCosMetaResourceResponse> DeleteCosMetaResource(DeleteCosMetaResourceRequest req)
        {
             JsonResponseModel<DeleteCosMetaResourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCosMetaResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCosMetaResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteCOSMetaData）用于删除COS元数据信息。
        /// </summary>
        /// <param name="req"><see cref="DeleteCosMetaResourceRequest"/></param>
        /// <returns><see cref="DeleteCosMetaResourceResponse"/></returns>
        public DeleteCosMetaResourceResponse DeleteCosMetaResourceSync(DeleteCosMetaResourceRequest req)
        {
             JsonResponseModel<DeleteCosMetaResourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCosMetaResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCosMetaResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除DSPA风险评估任务
        /// </summary>
        /// <param name="req"><see cref="DeleteDSPAAssessmentTaskRequest"/></param>
        /// <returns><see cref="DeleteDSPAAssessmentTaskResponse"/></returns>
        public async Task<DeleteDSPAAssessmentTaskResponse> DeleteDSPAAssessmentTask(DeleteDSPAAssessmentTaskRequest req)
        {
             JsonResponseModel<DeleteDSPAAssessmentTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDSPAAssessmentTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDSPAAssessmentTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除DSPA风险评估任务
        /// </summary>
        /// <param name="req"><see cref="DeleteDSPAAssessmentTaskRequest"/></param>
        /// <returns><see cref="DeleteDSPAAssessmentTaskResponse"/></returns>
        public DeleteDSPAAssessmentTaskResponse DeleteDSPAAssessmentTaskSync(DeleteDSPAAssessmentTaskRequest req)
        {
             JsonResponseModel<DeleteDSPAAssessmentTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDSPAAssessmentTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDSPAAssessmentTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        public async Task<DeleteDSPACOSDiscoveryTaskResponse> DeleteDSPACOSDiscoveryTask(DeleteDSPACOSDiscoveryTaskRequest req)
        {
             JsonResponseModel<DeleteDSPACOSDiscoveryTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDSPACOSDiscoveryTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDSPACOSDiscoveryTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DeleteDSPACOSDiscoveryTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDSPACOSDiscoveryTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDSPACOSDiscoveryTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除COS分类分级任务结果
        /// </summary>
        /// <param name="req"><see cref="DeleteDSPACOSDiscoveryTaskResultRequest"/></param>
        /// <returns><see cref="DeleteDSPACOSDiscoveryTaskResultResponse"/></returns>
        public async Task<DeleteDSPACOSDiscoveryTaskResultResponse> DeleteDSPACOSDiscoveryTaskResult(DeleteDSPACOSDiscoveryTaskResultRequest req)
        {
             JsonResponseModel<DeleteDSPACOSDiscoveryTaskResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDSPACOSDiscoveryTaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDSPACOSDiscoveryTaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除COS分类分级任务结果
        /// </summary>
        /// <param name="req"><see cref="DeleteDSPACOSDiscoveryTaskResultRequest"/></param>
        /// <returns><see cref="DeleteDSPACOSDiscoveryTaskResultResponse"/></returns>
        public DeleteDSPACOSDiscoveryTaskResultResponse DeleteDSPACOSDiscoveryTaskResultSync(DeleteDSPACOSDiscoveryTaskResultRequest req)
        {
             JsonResponseModel<DeleteDSPACOSDiscoveryTaskResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDSPACOSDiscoveryTaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDSPACOSDiscoveryTaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        public async Task<DeleteDSPADiscoveryTaskResponse> DeleteDSPADiscoveryTask(DeleteDSPADiscoveryTaskRequest req)
        {
             JsonResponseModel<DeleteDSPADiscoveryTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDSPADiscoveryTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDSPADiscoveryTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DeleteDSPADiscoveryTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDSPADiscoveryTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDSPADiscoveryTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除分类分级识别任务结果
        /// </summary>
        /// <param name="req"><see cref="DeleteDSPADiscoveryTaskResultRequest"/></param>
        /// <returns><see cref="DeleteDSPADiscoveryTaskResultResponse"/></returns>
        public async Task<DeleteDSPADiscoveryTaskResultResponse> DeleteDSPADiscoveryTaskResult(DeleteDSPADiscoveryTaskResultRequest req)
        {
             JsonResponseModel<DeleteDSPADiscoveryTaskResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDSPADiscoveryTaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDSPADiscoveryTaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除分类分级识别任务结果
        /// </summary>
        /// <param name="req"><see cref="DeleteDSPADiscoveryTaskResultRequest"/></param>
        /// <returns><see cref="DeleteDSPADiscoveryTaskResultResponse"/></returns>
        public DeleteDSPADiscoveryTaskResultResponse DeleteDSPADiscoveryTaskResultSync(DeleteDSPADiscoveryTaskResultRequest req)
        {
             JsonResponseModel<DeleteDSPADiscoveryTaskResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDSPADiscoveryTaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDSPADiscoveryTaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户云资源
        /// </summary>
        /// <param name="req"><see cref="DeleteDSPAMetaResourceRequest"/></param>
        /// <returns><see cref="DeleteDSPAMetaResourceResponse"/></returns>
        public async Task<DeleteDSPAMetaResourceResponse> DeleteDSPAMetaResource(DeleteDSPAMetaResourceRequest req)
        {
             JsonResponseModel<DeleteDSPAMetaResourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDSPAMetaResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDSPAMetaResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户云资源
        /// </summary>
        /// <param name="req"><see cref="DeleteDSPAMetaResourceRequest"/></param>
        /// <returns><see cref="DeleteDSPAMetaResourceResponse"/></returns>
        public DeleteDSPAMetaResourceResponse DeleteDSPAMetaResourceSync(DeleteDSPAMetaResourceRequest req)
        {
             JsonResponseModel<DeleteDSPAMetaResourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDSPAMetaResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDSPAMetaResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询敏感数据导出结果URL
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetDetailDataExportResultRequest"/></param>
        /// <returns><see cref="DescribeAssetDetailDataExportResultResponse"/></returns>
        public async Task<DescribeAssetDetailDataExportResultResponse> DescribeAssetDetailDataExportResult(DescribeAssetDetailDataExportResultRequest req)
        {
             JsonResponseModel<DescribeAssetDetailDataExportResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetDetailDataExportResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetDetailDataExportResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询敏感数据导出结果URL
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetDetailDataExportResultRequest"/></param>
        /// <returns><see cref="DescribeAssetDetailDataExportResultResponse"/></returns>
        public DescribeAssetDetailDataExportResultResponse DescribeAssetDetailDataExportResultSync(DescribeAssetDetailDataExportResultRequest req)
        {
             JsonResponseModel<DescribeAssetDetailDataExportResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetDetailDataExportResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetDetailDataExportResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 数据资产报告页面-查询数据资产概览接口（包括数据库资产详情和存储资产详情）
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetOverviewRequest"/></param>
        /// <returns><see cref="DescribeAssetOverviewResponse"/></returns>
        public async Task<DescribeAssetOverviewResponse> DescribeAssetOverview(DescribeAssetOverviewRequest req)
        {
             JsonResponseModel<DescribeAssetOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAssetOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 数据资产报告页面-查询数据资产概览接口（包括数据库资产详情和存储资产详情）
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetOverviewRequest"/></param>
        /// <returns><see cref="DescribeAssetOverviewResponse"/></returns>
        public DescribeAssetOverviewResponse DescribeAssetOverviewSync(DescribeAssetOverviewRequest req)
        {
             JsonResponseModel<DescribeAssetOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAssetOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAssetOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询DB绑定的列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBindDBListRequest"/></param>
        /// <returns><see cref="DescribeBindDBListResponse"/></returns>
        public async Task<DescribeBindDBListResponse> DescribeBindDBList(DescribeBindDBListRequest req)
        {
             JsonResponseModel<DescribeBindDBListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBindDBList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBindDBListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询DB绑定的列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBindDBListRequest"/></param>
        /// <returns><see cref="DescribeBindDBListResponse"/></returns>
        public DescribeBindDBListResponse DescribeBindDBListSync(DescribeBindDBListRequest req)
        {
             JsonResponseModel<DescribeBindDBListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBindDBList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBindDBListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 数据资产报告-查询cos的资产分布详情接口
        /// </summary>
        /// <param name="req"><see cref="DescribeCOSAssetSensitiveDistributionRequest"/></param>
        /// <returns><see cref="DescribeCOSAssetSensitiveDistributionResponse"/></returns>
        public async Task<DescribeCOSAssetSensitiveDistributionResponse> DescribeCOSAssetSensitiveDistribution(DescribeCOSAssetSensitiveDistributionRequest req)
        {
             JsonResponseModel<DescribeCOSAssetSensitiveDistributionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCOSAssetSensitiveDistribution");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCOSAssetSensitiveDistributionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 数据资产报告-查询cos的资产分布详情接口
        /// </summary>
        /// <param name="req"><see cref="DescribeCOSAssetSensitiveDistributionRequest"/></param>
        /// <returns><see cref="DescribeCOSAssetSensitiveDistributionResponse"/></returns>
        public DescribeCOSAssetSensitiveDistributionResponse DescribeCOSAssetSensitiveDistributionSync(DescribeCOSAssetSensitiveDistributionRequest req)
        {
             JsonResponseModel<DescribeCOSAssetSensitiveDistributionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCOSAssetSensitiveDistribution");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCOSAssetSensitiveDistributionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询分类信息
        /// </summary>
        /// <param name="req"><see cref="DescribeClassificationInfoRequest"/></param>
        /// <returns><see cref="DescribeClassificationInfoResponse"/></returns>
        public async Task<DescribeClassificationInfoResponse> DescribeClassificationInfo(DescribeClassificationInfoRequest req)
        {
             JsonResponseModel<DescribeClassificationInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClassificationInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClassificationInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询分类信息
        /// </summary>
        /// <param name="req"><see cref="DescribeClassificationInfoRequest"/></param>
        /// <returns><see cref="DescribeClassificationInfoResponse"/></returns>
        public DescribeClassificationInfoResponse DescribeClassificationInfoSync(DescribeClassificationInfoRequest req)
        {
             JsonResponseModel<DescribeClassificationInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClassificationInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClassificationInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询标准下所有分类的识别规则数量(不算子分类下的识别规则)
        /// </summary>
        /// <param name="req"><see cref="DescribeClassificationRuleCountRequest"/></param>
        /// <returns><see cref="DescribeClassificationRuleCountResponse"/></returns>
        public async Task<DescribeClassificationRuleCountResponse> DescribeClassificationRuleCount(DescribeClassificationRuleCountRequest req)
        {
             JsonResponseModel<DescribeClassificationRuleCountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClassificationRuleCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClassificationRuleCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询标准下所有分类的识别规则数量(不算子分类下的识别规则)
        /// </summary>
        /// <param name="req"><see cref="DescribeClassificationRuleCountRequest"/></param>
        /// <returns><see cref="DescribeClassificationRuleCountResponse"/></returns>
        public DescribeClassificationRuleCountResponse DescribeClassificationRuleCountSync(DescribeClassificationRuleCountRequest req)
        {
             JsonResponseModel<DescribeClassificationRuleCountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClassificationRuleCount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClassificationRuleCountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询高风险资产的top10
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentHighRiskTop10OverviewRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentHighRiskTop10OverviewResponse"/></returns>
        public async Task<DescribeDSPAAssessmentHighRiskTop10OverviewResponse> DescribeDSPAAssessmentHighRiskTop10Overview(DescribeDSPAAssessmentHighRiskTop10OverviewRequest req)
        {
             JsonResponseModel<DescribeDSPAAssessmentHighRiskTop10OverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPAAssessmentHighRiskTop10Overview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentHighRiskTop10OverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询高风险资产的top10
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentHighRiskTop10OverviewRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentHighRiskTop10OverviewResponse"/></returns>
        public DescribeDSPAAssessmentHighRiskTop10OverviewResponse DescribeDSPAAssessmentHighRiskTop10OverviewSync(DescribeDSPAAssessmentHighRiskTop10OverviewRequest req)
        {
             JsonResponseModel<DescribeDSPAAssessmentHighRiskTop10OverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPAAssessmentHighRiskTop10Overview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentHighRiskTop10OverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询最新风险项详情数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentLatestRiskDetailInfoRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentLatestRiskDetailInfoResponse"/></returns>
        public async Task<DescribeDSPAAssessmentLatestRiskDetailInfoResponse> DescribeDSPAAssessmentLatestRiskDetailInfo(DescribeDSPAAssessmentLatestRiskDetailInfoRequest req)
        {
             JsonResponseModel<DescribeDSPAAssessmentLatestRiskDetailInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPAAssessmentLatestRiskDetailInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentLatestRiskDetailInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询最新风险项详情数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentLatestRiskDetailInfoRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentLatestRiskDetailInfoResponse"/></returns>
        public DescribeDSPAAssessmentLatestRiskDetailInfoResponse DescribeDSPAAssessmentLatestRiskDetailInfoSync(DescribeDSPAAssessmentLatestRiskDetailInfoRequest req)
        {
             JsonResponseModel<DescribeDSPAAssessmentLatestRiskDetailInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPAAssessmentLatestRiskDetailInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentLatestRiskDetailInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询最新的风险详情列表数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentLatestRiskListRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentLatestRiskListResponse"/></returns>
        public async Task<DescribeDSPAAssessmentLatestRiskListResponse> DescribeDSPAAssessmentLatestRiskList(DescribeDSPAAssessmentLatestRiskListRequest req)
        {
             JsonResponseModel<DescribeDSPAAssessmentLatestRiskListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPAAssessmentLatestRiskList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentLatestRiskListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询最新的风险详情列表数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentLatestRiskListRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentLatestRiskListResponse"/></returns>
        public DescribeDSPAAssessmentLatestRiskListResponse DescribeDSPAAssessmentLatestRiskListSync(DescribeDSPAAssessmentLatestRiskListRequest req)
        {
             JsonResponseModel<DescribeDSPAAssessmentLatestRiskListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPAAssessmentLatestRiskList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentLatestRiskListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 风险概览-查询新发现风险统计数
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentNewDiscoveredRiskOverviewRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentNewDiscoveredRiskOverviewResponse"/></returns>
        public async Task<DescribeDSPAAssessmentNewDiscoveredRiskOverviewResponse> DescribeDSPAAssessmentNewDiscoveredRiskOverview(DescribeDSPAAssessmentNewDiscoveredRiskOverviewRequest req)
        {
             JsonResponseModel<DescribeDSPAAssessmentNewDiscoveredRiskOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPAAssessmentNewDiscoveredRiskOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentNewDiscoveredRiskOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 风险概览-查询新发现风险统计数
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentNewDiscoveredRiskOverviewRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentNewDiscoveredRiskOverviewResponse"/></returns>
        public DescribeDSPAAssessmentNewDiscoveredRiskOverviewResponse DescribeDSPAAssessmentNewDiscoveredRiskOverviewSync(DescribeDSPAAssessmentNewDiscoveredRiskOverviewRequest req)
        {
             JsonResponseModel<DescribeDSPAAssessmentNewDiscoveredRiskOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPAAssessmentNewDiscoveredRiskOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentNewDiscoveredRiskOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 风险概览-查询待处理风险统计数
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentPendingRiskOverviewRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentPendingRiskOverviewResponse"/></returns>
        public async Task<DescribeDSPAAssessmentPendingRiskOverviewResponse> DescribeDSPAAssessmentPendingRiskOverview(DescribeDSPAAssessmentPendingRiskOverviewRequest req)
        {
             JsonResponseModel<DescribeDSPAAssessmentPendingRiskOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPAAssessmentPendingRiskOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentPendingRiskOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 风险概览-查询待处理风险统计数
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentPendingRiskOverviewRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentPendingRiskOverviewResponse"/></returns>
        public DescribeDSPAAssessmentPendingRiskOverviewResponse DescribeDSPAAssessmentPendingRiskOverviewSync(DescribeDSPAAssessmentPendingRiskOverviewRequest req)
        {
             JsonResponseModel<DescribeDSPAAssessmentPendingRiskOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPAAssessmentPendingRiskOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentPendingRiskOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 风险概览-查询处理中风险统计数
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentProcessingRiskOverviewRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentProcessingRiskOverviewResponse"/></returns>
        public async Task<DescribeDSPAAssessmentProcessingRiskOverviewResponse> DescribeDSPAAssessmentProcessingRiskOverview(DescribeDSPAAssessmentProcessingRiskOverviewRequest req)
        {
             JsonResponseModel<DescribeDSPAAssessmentProcessingRiskOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPAAssessmentProcessingRiskOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentProcessingRiskOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 风险概览-查询处理中风险统计数
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentProcessingRiskOverviewRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentProcessingRiskOverviewResponse"/></returns>
        public DescribeDSPAAssessmentProcessingRiskOverviewResponse DescribeDSPAAssessmentProcessingRiskOverviewSync(DescribeDSPAAssessmentProcessingRiskOverviewRequest req)
        {
             JsonResponseModel<DescribeDSPAAssessmentProcessingRiskOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPAAssessmentProcessingRiskOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentProcessingRiskOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 风险概览页风险数量和受影响资产数概览统计
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskAmountOverviewRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskAmountOverviewResponse"/></returns>
        public async Task<DescribeDSPAAssessmentRiskAmountOverviewResponse> DescribeDSPAAssessmentRiskAmountOverview(DescribeDSPAAssessmentRiskAmountOverviewRequest req)
        {
             JsonResponseModel<DescribeDSPAAssessmentRiskAmountOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPAAssessmentRiskAmountOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentRiskAmountOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 风险概览页风险数量和受影响资产数概览统计
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskAmountOverviewRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskAmountOverviewResponse"/></returns>
        public DescribeDSPAAssessmentRiskAmountOverviewResponse DescribeDSPAAssessmentRiskAmountOverviewSync(DescribeDSPAAssessmentRiskAmountOverviewRequest req)
        {
             JsonResponseModel<DescribeDSPAAssessmentRiskAmountOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPAAssessmentRiskAmountOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentRiskAmountOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 受影响资产TOP5统计
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskDatasourceTop5Request"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskDatasourceTop5Response"/></returns>
        public async Task<DescribeDSPAAssessmentRiskDatasourceTop5Response> DescribeDSPAAssessmentRiskDatasourceTop5(DescribeDSPAAssessmentRiskDatasourceTop5Request req)
        {
             JsonResponseModel<DescribeDSPAAssessmentRiskDatasourceTop5Response> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPAAssessmentRiskDatasourceTop5");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentRiskDatasourceTop5Response>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 受影响资产TOP5统计
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskDatasourceTop5Request"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskDatasourceTop5Response"/></returns>
        public DescribeDSPAAssessmentRiskDatasourceTop5Response DescribeDSPAAssessmentRiskDatasourceTop5Sync(DescribeDSPAAssessmentRiskDatasourceTop5Request req)
        {
             JsonResponseModel<DescribeDSPAAssessmentRiskDatasourceTop5Response> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPAAssessmentRiskDatasourceTop5");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentRiskDatasourceTop5Response>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 遗留待处理&昨日完成风险处置概览统计
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskDealedOverviewRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskDealedOverviewResponse"/></returns>
        public async Task<DescribeDSPAAssessmentRiskDealedOverviewResponse> DescribeDSPAAssessmentRiskDealedOverview(DescribeDSPAAssessmentRiskDealedOverviewRequest req)
        {
             JsonResponseModel<DescribeDSPAAssessmentRiskDealedOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPAAssessmentRiskDealedOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentRiskDealedOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 遗留待处理&昨日完成风险处置概览统计
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskDealedOverviewRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskDealedOverviewResponse"/></returns>
        public DescribeDSPAAssessmentRiskDealedOverviewResponse DescribeDSPAAssessmentRiskDealedOverviewSync(DescribeDSPAAssessmentRiskDealedOverviewRequest req)
        {
             JsonResponseModel<DescribeDSPAAssessmentRiskDealedOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPAAssessmentRiskDealedOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentRiskDealedOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 风险项处理趋势统计
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskDealedTrendRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskDealedTrendResponse"/></returns>
        public async Task<DescribeDSPAAssessmentRiskDealedTrendResponse> DescribeDSPAAssessmentRiskDealedTrend(DescribeDSPAAssessmentRiskDealedTrendRequest req)
        {
             JsonResponseModel<DescribeDSPAAssessmentRiskDealedTrendResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPAAssessmentRiskDealedTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentRiskDealedTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 风险项处理趋势统计
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskDealedTrendRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskDealedTrendResponse"/></returns>
        public DescribeDSPAAssessmentRiskDealedTrendResponse DescribeDSPAAssessmentRiskDealedTrendSync(DescribeDSPAAssessmentRiskDealedTrendRequest req)
        {
             JsonResponseModel<DescribeDSPAAssessmentRiskDealedTrendResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPAAssessmentRiskDealedTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentRiskDealedTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询风险分布数据，包含风险类型分布，风险详情分布，风险资产的分布
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskDistributionOverviewRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskDistributionOverviewResponse"/></returns>
        public async Task<DescribeDSPAAssessmentRiskDistributionOverviewResponse> DescribeDSPAAssessmentRiskDistributionOverview(DescribeDSPAAssessmentRiskDistributionOverviewRequest req)
        {
             JsonResponseModel<DescribeDSPAAssessmentRiskDistributionOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPAAssessmentRiskDistributionOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentRiskDistributionOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询风险分布数据，包含风险类型分布，风险详情分布，风险资产的分布
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskDistributionOverviewRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskDistributionOverviewResponse"/></returns>
        public DescribeDSPAAssessmentRiskDistributionOverviewResponse DescribeDSPAAssessmentRiskDistributionOverviewSync(DescribeDSPAAssessmentRiskDistributionOverviewRequest req)
        {
             JsonResponseModel<DescribeDSPAAssessmentRiskDistributionOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPAAssessmentRiskDistributionOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentRiskDistributionOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 风险分类TOP5统计
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskItemTop5Request"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskItemTop5Response"/></returns>
        public async Task<DescribeDSPAAssessmentRiskItemTop5Response> DescribeDSPAAssessmentRiskItemTop5(DescribeDSPAAssessmentRiskItemTop5Request req)
        {
             JsonResponseModel<DescribeDSPAAssessmentRiskItemTop5Response> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPAAssessmentRiskItemTop5");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentRiskItemTop5Response>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 风险分类TOP5统计
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskItemTop5Request"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskItemTop5Response"/></returns>
        public DescribeDSPAAssessmentRiskItemTop5Response DescribeDSPAAssessmentRiskItemTop5Sync(DescribeDSPAAssessmentRiskItemTop5Request req)
        {
             JsonResponseModel<DescribeDSPAAssessmentRiskItemTop5Response> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPAAssessmentRiskItemTop5");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentRiskItemTop5Response>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 风险项页面----查询风险等级的详情数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskLevelDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskLevelDetailResponse"/></returns>
        public async Task<DescribeDSPAAssessmentRiskLevelDetailResponse> DescribeDSPAAssessmentRiskLevelDetail(DescribeDSPAAssessmentRiskLevelDetailRequest req)
        {
             JsonResponseModel<DescribeDSPAAssessmentRiskLevelDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPAAssessmentRiskLevelDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentRiskLevelDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 风险项页面----查询风险等级的详情数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskLevelDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskLevelDetailResponse"/></returns>
        public DescribeDSPAAssessmentRiskLevelDetailResponse DescribeDSPAAssessmentRiskLevelDetailSync(DescribeDSPAAssessmentRiskLevelDetailRequest req)
        {
             JsonResponseModel<DescribeDSPAAssessmentRiskLevelDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPAAssessmentRiskLevelDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentRiskLevelDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 风险项页面----查询风险等级的列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskLevelListRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskLevelListResponse"/></returns>
        public async Task<DescribeDSPAAssessmentRiskLevelListResponse> DescribeDSPAAssessmentRiskLevelList(DescribeDSPAAssessmentRiskLevelListRequest req)
        {
             JsonResponseModel<DescribeDSPAAssessmentRiskLevelListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPAAssessmentRiskLevelList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentRiskLevelListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 风险项页面----查询风险等级的列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskLevelListRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskLevelListResponse"/></returns>
        public DescribeDSPAAssessmentRiskLevelListResponse DescribeDSPAAssessmentRiskLevelListSync(DescribeDSPAAssessmentRiskLevelListRequest req)
        {
             JsonResponseModel<DescribeDSPAAssessmentRiskLevelListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPAAssessmentRiskLevelList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentRiskLevelListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 风险级别趋势统计
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskLevelTrendRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskLevelTrendResponse"/></returns>
        public async Task<DescribeDSPAAssessmentRiskLevelTrendResponse> DescribeDSPAAssessmentRiskLevelTrend(DescribeDSPAAssessmentRiskLevelTrendRequest req)
        {
             JsonResponseModel<DescribeDSPAAssessmentRiskLevelTrendResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPAAssessmentRiskLevelTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentRiskLevelTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 风险级别趋势统计
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskLevelTrendRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskLevelTrendResponse"/></returns>
        public DescribeDSPAAssessmentRiskLevelTrendResponse DescribeDSPAAssessmentRiskLevelTrendSync(DescribeDSPAAssessmentRiskLevelTrendRequest req)
        {
             JsonResponseModel<DescribeDSPAAssessmentRiskLevelTrendResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPAAssessmentRiskLevelTrend");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentRiskLevelTrendResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 风险数量概览统计
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskOverviewRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskOverviewResponse"/></returns>
        public async Task<DescribeDSPAAssessmentRiskOverviewResponse> DescribeDSPAAssessmentRiskOverview(DescribeDSPAAssessmentRiskOverviewRequest req)
        {
             JsonResponseModel<DescribeDSPAAssessmentRiskOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPAAssessmentRiskOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentRiskOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 风险数量概览统计
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskOverviewRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskOverviewResponse"/></returns>
        public DescribeDSPAAssessmentRiskOverviewResponse DescribeDSPAAssessmentRiskOverviewSync(DescribeDSPAAssessmentRiskOverviewRequest req)
        {
             JsonResponseModel<DescribeDSPAAssessmentRiskOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPAAssessmentRiskOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentRiskOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改最新评估风险项状态
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskProcessHistoryRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskProcessHistoryResponse"/></returns>
        public async Task<DescribeDSPAAssessmentRiskProcessHistoryResponse> DescribeDSPAAssessmentRiskProcessHistory(DescribeDSPAAssessmentRiskProcessHistoryRequest req)
        {
             JsonResponseModel<DescribeDSPAAssessmentRiskProcessHistoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPAAssessmentRiskProcessHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentRiskProcessHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改最新评估风险项状态
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskProcessHistoryRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskProcessHistoryResponse"/></returns>
        public DescribeDSPAAssessmentRiskProcessHistoryResponse DescribeDSPAAssessmentRiskProcessHistorySync(DescribeDSPAAssessmentRiskProcessHistoryRequest req)
        {
             JsonResponseModel<DescribeDSPAAssessmentRiskProcessHistoryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPAAssessmentRiskProcessHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentRiskProcessHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 风险项页面--查看评估模版详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskTemplateDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskTemplateDetailResponse"/></returns>
        public async Task<DescribeDSPAAssessmentRiskTemplateDetailResponse> DescribeDSPAAssessmentRiskTemplateDetail(DescribeDSPAAssessmentRiskTemplateDetailRequest req)
        {
             JsonResponseModel<DescribeDSPAAssessmentRiskTemplateDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPAAssessmentRiskTemplateDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentRiskTemplateDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 风险项页面--查看评估模版详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskTemplateDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskTemplateDetailResponse"/></returns>
        public DescribeDSPAAssessmentRiskTemplateDetailResponse DescribeDSPAAssessmentRiskTemplateDetailSync(DescribeDSPAAssessmentRiskTemplateDetailRequest req)
        {
             JsonResponseModel<DescribeDSPAAssessmentRiskTemplateDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPAAssessmentRiskTemplateDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentRiskTemplateDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 风险模版页面--查询风险模版中的脆弱项配置
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskTemplateVulnerableListRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskTemplateVulnerableListResponse"/></returns>
        public async Task<DescribeDSPAAssessmentRiskTemplateVulnerableListResponse> DescribeDSPAAssessmentRiskTemplateVulnerableList(DescribeDSPAAssessmentRiskTemplateVulnerableListRequest req)
        {
             JsonResponseModel<DescribeDSPAAssessmentRiskTemplateVulnerableListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPAAssessmentRiskTemplateVulnerableList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentRiskTemplateVulnerableListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 风险模版页面--查询风险模版中的脆弱项配置
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRiskTemplateVulnerableListRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRiskTemplateVulnerableListResponse"/></returns>
        public DescribeDSPAAssessmentRiskTemplateVulnerableListResponse DescribeDSPAAssessmentRiskTemplateVulnerableListSync(DescribeDSPAAssessmentRiskTemplateVulnerableListRequest req)
        {
             JsonResponseModel<DescribeDSPAAssessmentRiskTemplateVulnerableListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPAAssessmentRiskTemplateVulnerableList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentRiskTemplateVulnerableListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DSPA评估风险项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRisksRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRisksResponse"/></returns>
        public async Task<DescribeDSPAAssessmentRisksResponse> DescribeDSPAAssessmentRisks(DescribeDSPAAssessmentRisksRequest req)
        {
             JsonResponseModel<DescribeDSPAAssessmentRisksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPAAssessmentRisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentRisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DSPA评估风险项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentRisksRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentRisksResponse"/></returns>
        public DescribeDSPAAssessmentRisksResponse DescribeDSPAAssessmentRisksSync(DescribeDSPAAssessmentRisksRequest req)
        {
             JsonResponseModel<DescribeDSPAAssessmentRisksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPAAssessmentRisks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentRisksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DSPA评估任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentTasksRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentTasksResponse"/></returns>
        public async Task<DescribeDSPAAssessmentTasksResponse> DescribeDSPAAssessmentTasks(DescribeDSPAAssessmentTasksRequest req)
        {
             JsonResponseModel<DescribeDSPAAssessmentTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPAAssessmentTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DSPA评估任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentTasksRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentTasksResponse"/></returns>
        public DescribeDSPAAssessmentTasksResponse DescribeDSPAAssessmentTasksSync(DescribeDSPAAssessmentTasksRequest req)
        {
             JsonResponseModel<DescribeDSPAAssessmentTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPAAssessmentTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DSPA评估模版关联的评估控制项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentTemplateControlItemsRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentTemplateControlItemsResponse"/></returns>
        public async Task<DescribeDSPAAssessmentTemplateControlItemsResponse> DescribeDSPAAssessmentTemplateControlItems(DescribeDSPAAssessmentTemplateControlItemsRequest req)
        {
             JsonResponseModel<DescribeDSPAAssessmentTemplateControlItemsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPAAssessmentTemplateControlItems");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentTemplateControlItemsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DSPA评估模版关联的评估控制项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentTemplateControlItemsRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentTemplateControlItemsResponse"/></returns>
        public DescribeDSPAAssessmentTemplateControlItemsResponse DescribeDSPAAssessmentTemplateControlItemsSync(DescribeDSPAAssessmentTemplateControlItemsRequest req)
        {
             JsonResponseModel<DescribeDSPAAssessmentTemplateControlItemsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPAAssessmentTemplateControlItems");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentTemplateControlItemsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DSPA评估模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentTemplatesRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentTemplatesResponse"/></returns>
        public async Task<DescribeDSPAAssessmentTemplatesResponse> DescribeDSPAAssessmentTemplates(DescribeDSPAAssessmentTemplatesRequest req)
        {
             JsonResponseModel<DescribeDSPAAssessmentTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPAAssessmentTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取DSPA评估模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAAssessmentTemplatesRequest"/></param>
        /// <returns><see cref="DescribeDSPAAssessmentTemplatesResponse"/></returns>
        public DescribeDSPAAssessmentTemplatesResponse DescribeDSPAAssessmentTemplatesSync(DescribeDSPAAssessmentTemplatesRequest req)
        {
             JsonResponseModel<DescribeDSPAAssessmentTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPAAssessmentTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAAssessmentTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取COS敏感数据资产桶列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACOSDataAssetBucketsRequest"/></param>
        /// <returns><see cref="DescribeDSPACOSDataAssetBucketsResponse"/></returns>
        public async Task<DescribeDSPACOSDataAssetBucketsResponse> DescribeDSPACOSDataAssetBuckets(DescribeDSPACOSDataAssetBucketsRequest req)
        {
             JsonResponseModel<DescribeDSPACOSDataAssetBucketsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPACOSDataAssetBuckets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPACOSDataAssetBucketsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取COS敏感数据资产桶列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACOSDataAssetBucketsRequest"/></param>
        /// <returns><see cref="DescribeDSPACOSDataAssetBucketsResponse"/></returns>
        public DescribeDSPACOSDataAssetBucketsResponse DescribeDSPACOSDataAssetBucketsSync(DescribeDSPACOSDataAssetBucketsRequest req)
        {
             JsonResponseModel<DescribeDSPACOSDataAssetBucketsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPACOSDataAssetBuckets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPACOSDataAssetBucketsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取COS单个模板下的敏感数据资产
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACOSDataAssetByComplianceIdRequest"/></param>
        /// <returns><see cref="DescribeDSPACOSDataAssetByComplianceIdResponse"/></returns>
        public async Task<DescribeDSPACOSDataAssetByComplianceIdResponse> DescribeDSPACOSDataAssetByComplianceId(DescribeDSPACOSDataAssetByComplianceIdRequest req)
        {
             JsonResponseModel<DescribeDSPACOSDataAssetByComplianceIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPACOSDataAssetByComplianceId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPACOSDataAssetByComplianceIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取COS单个模板下的敏感数据资产
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACOSDataAssetByComplianceIdRequest"/></param>
        /// <returns><see cref="DescribeDSPACOSDataAssetByComplianceIdResponse"/></returns>
        public DescribeDSPACOSDataAssetByComplianceIdResponse DescribeDSPACOSDataAssetByComplianceIdSync(DescribeDSPACOSDataAssetByComplianceIdRequest req)
        {
             JsonResponseModel<DescribeDSPACOSDataAssetByComplianceIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPACOSDataAssetByComplianceId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPACOSDataAssetByComplianceIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取COS分类分级数据资产详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACOSDataAssetDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPACOSDataAssetDetailResponse"/></returns>
        public async Task<DescribeDSPACOSDataAssetDetailResponse> DescribeDSPACOSDataAssetDetail(DescribeDSPACOSDataAssetDetailRequest req)
        {
             JsonResponseModel<DescribeDSPACOSDataAssetDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPACOSDataAssetDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPACOSDataAssetDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取COS分类分级数据资产详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACOSDataAssetDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPACOSDataAssetDetailResponse"/></returns>
        public DescribeDSPACOSDataAssetDetailResponse DescribeDSPACOSDataAssetDetailSync(DescribeDSPACOSDataAssetDetailRequest req)
        {
             JsonResponseModel<DescribeDSPACOSDataAssetDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPACOSDataAssetDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPACOSDataAssetDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取COS分类分级任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACOSDiscoveryTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPACOSDiscoveryTaskDetailResponse"/></returns>
        public async Task<DescribeDSPACOSDiscoveryTaskDetailResponse> DescribeDSPACOSDiscoveryTaskDetail(DescribeDSPACOSDiscoveryTaskDetailRequest req)
        {
             JsonResponseModel<DescribeDSPACOSDiscoveryTaskDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPACOSDiscoveryTaskDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPACOSDiscoveryTaskDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取COS分类分级任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACOSDiscoveryTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPACOSDiscoveryTaskDetailResponse"/></returns>
        public DescribeDSPACOSDiscoveryTaskDetailResponse DescribeDSPACOSDiscoveryTaskDetailSync(DescribeDSPACOSDiscoveryTaskDetailRequest req)
        {
             JsonResponseModel<DescribeDSPACOSDiscoveryTaskDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPACOSDiscoveryTaskDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPACOSDiscoveryTaskDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取COS分类分级任务结果详情文件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACOSDiscoveryTaskFilesRequest"/></param>
        /// <returns><see cref="DescribeDSPACOSDiscoveryTaskFilesResponse"/></returns>
        public async Task<DescribeDSPACOSDiscoveryTaskFilesResponse> DescribeDSPACOSDiscoveryTaskFiles(DescribeDSPACOSDiscoveryTaskFilesRequest req)
        {
             JsonResponseModel<DescribeDSPACOSDiscoveryTaskFilesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPACOSDiscoveryTaskFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPACOSDiscoveryTaskFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取COS分类分级任务结果详情文件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACOSDiscoveryTaskFilesRequest"/></param>
        /// <returns><see cref="DescribeDSPACOSDiscoveryTaskFilesResponse"/></returns>
        public DescribeDSPACOSDiscoveryTaskFilesResponse DescribeDSPACOSDiscoveryTaskFilesSync(DescribeDSPACOSDiscoveryTaskFilesRequest req)
        {
             JsonResponseModel<DescribeDSPACOSDiscoveryTaskFilesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPACOSDiscoveryTaskFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPACOSDiscoveryTaskFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取COS分类分级任务结果，该接口只有在任务状态为以下状态时才支持结果正常查询：
        /// 3 扫描成功，
        /// 4 扫描失败
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACOSDiscoveryTaskResultRequest"/></param>
        /// <returns><see cref="DescribeDSPACOSDiscoveryTaskResultResponse"/></returns>
        public async Task<DescribeDSPACOSDiscoveryTaskResultResponse> DescribeDSPACOSDiscoveryTaskResult(DescribeDSPACOSDiscoveryTaskResultRequest req)
        {
             JsonResponseModel<DescribeDSPACOSDiscoveryTaskResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPACOSDiscoveryTaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPACOSDiscoveryTaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DescribeDSPACOSDiscoveryTaskResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPACOSDiscoveryTaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPACOSDiscoveryTaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取COS分类分级任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACOSDiscoveryTasksRequest"/></param>
        /// <returns><see cref="DescribeDSPACOSDiscoveryTasksResponse"/></returns>
        public async Task<DescribeDSPACOSDiscoveryTasksResponse> DescribeDSPACOSDiscoveryTasks(DescribeDSPACOSDiscoveryTasksRequest req)
        {
             JsonResponseModel<DescribeDSPACOSDiscoveryTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPACOSDiscoveryTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPACOSDiscoveryTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取COS分类分级任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACOSDiscoveryTasksRequest"/></param>
        /// <returns><see cref="DescribeDSPACOSDiscoveryTasksResponse"/></returns>
        public DescribeDSPACOSDiscoveryTasksResponse DescribeDSPACOSDiscoveryTasksSync(DescribeDSPACOSDiscoveryTasksRequest req)
        {
             JsonResponseModel<DescribeDSPACOSDiscoveryTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPACOSDiscoveryTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPACOSDiscoveryTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取COS分类分级任务结果详情，该接口只有在任务状态为时才支持结果正确查询：
        /// 3 扫描成功
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACOSTaskResultDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPACOSTaskResultDetailResponse"/></returns>
        public async Task<DescribeDSPACOSTaskResultDetailResponse> DescribeDSPACOSTaskResultDetail(DescribeDSPACOSTaskResultDetailRequest req)
        {
             JsonResponseModel<DescribeDSPACOSTaskResultDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPACOSTaskResultDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPACOSTaskResultDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取COS分类分级任务结果详情，该接口只有在任务状态为时才支持结果正确查询：
        /// 3 扫描成功
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACOSTaskResultDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPACOSTaskResultDetailResponse"/></returns>
        public DescribeDSPACOSTaskResultDetailResponse DescribeDSPACOSTaskResultDetailSync(DescribeDSPACOSTaskResultDetailRequest req)
        {
             JsonResponseModel<DescribeDSPACOSTaskResultDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPACOSTaskResultDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPACOSTaskResultDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取敏感数据分类列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACategoriesRequest"/></param>
        /// <returns><see cref="DescribeDSPACategoriesResponse"/></returns>
        public async Task<DescribeDSPACategoriesResponse> DescribeDSPACategories(DescribeDSPACategoriesRequest req)
        {
             JsonResponseModel<DescribeDSPACategoriesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPACategories");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPACategoriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取敏感数据分类列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACategoriesRequest"/></param>
        /// <returns><see cref="DescribeDSPACategoriesResponse"/></returns>
        public DescribeDSPACategoriesResponse DescribeDSPACategoriesSync(DescribeDSPACategoriesRequest req)
        {
             JsonResponseModel<DescribeDSPACategoriesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPACategories");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPACategoriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取分类规则统计信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACategoryRuleStatisticRequest"/></param>
        /// <returns><see cref="DescribeDSPACategoryRuleStatisticResponse"/></returns>
        public async Task<DescribeDSPACategoryRuleStatisticResponse> DescribeDSPACategoryRuleStatistic(DescribeDSPACategoryRuleStatisticRequest req)
        {
             JsonResponseModel<DescribeDSPACategoryRuleStatisticResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPACategoryRuleStatistic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPACategoryRuleStatisticResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取分类规则统计信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACategoryRuleStatisticRequest"/></param>
        /// <returns><see cref="DescribeDSPACategoryRuleStatisticResponse"/></returns>
        public DescribeDSPACategoryRuleStatisticResponse DescribeDSPACategoryRuleStatisticSync(DescribeDSPACategoryRuleStatisticRequest req)
        {
             JsonResponseModel<DescribeDSPACategoryRuleStatisticResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPACategoryRuleStatistic");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPACategoryRuleStatisticResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取合规组分类规则信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACategoryRulesRequest"/></param>
        /// <returns><see cref="DescribeDSPACategoryRulesResponse"/></returns>
        public async Task<DescribeDSPACategoryRulesResponse> DescribeDSPACategoryRules(DescribeDSPACategoryRulesRequest req)
        {
             JsonResponseModel<DescribeDSPACategoryRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPACategoryRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPACategoryRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取合规组分类规则信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACategoryRulesRequest"/></param>
        /// <returns><see cref="DescribeDSPACategoryRulesResponse"/></returns>
        public DescribeDSPACategoryRulesResponse DescribeDSPACategoryRulesSync(DescribeDSPACategoryRulesRequest req)
        {
             JsonResponseModel<DescribeDSPACategoryRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPACategoryRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPACategoryRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取分类树信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACategoryTreeRequest"/></param>
        /// <returns><see cref="DescribeDSPACategoryTreeResponse"/></returns>
        public async Task<DescribeDSPACategoryTreeResponse> DescribeDSPACategoryTree(DescribeDSPACategoryTreeRequest req)
        {
             JsonResponseModel<DescribeDSPACategoryTreeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPACategoryTree");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPACategoryTreeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取分类树信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACategoryTreeRequest"/></param>
        /// <returns><see cref="DescribeDSPACategoryTreeResponse"/></returns>
        public DescribeDSPACategoryTreeResponse DescribeDSPACategoryTreeSync(DescribeDSPACategoryTreeRequest req)
        {
             JsonResponseModel<DescribeDSPACategoryTreeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPACategoryTree");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPACategoryTreeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取分类规则树信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACategoryTreeWithRulesRequest"/></param>
        /// <returns><see cref="DescribeDSPACategoryTreeWithRulesResponse"/></returns>
        public async Task<DescribeDSPACategoryTreeWithRulesResponse> DescribeDSPACategoryTreeWithRules(DescribeDSPACategoryTreeWithRulesRequest req)
        {
             JsonResponseModel<DescribeDSPACategoryTreeWithRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPACategoryTreeWithRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPACategoryTreeWithRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取分类规则树信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPACategoryTreeWithRulesRequest"/></param>
        /// <returns><see cref="DescribeDSPACategoryTreeWithRulesResponse"/></returns>
        public DescribeDSPACategoryTreeWithRulesResponse DescribeDSPACategoryTreeWithRulesSync(DescribeDSPACategoryTreeWithRulesRequest req)
        {
             JsonResponseModel<DescribeDSPACategoryTreeWithRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPACategoryTreeWithRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPACategoryTreeWithRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取模板详情信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAComplianceGroupDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPAComplianceGroupDetailResponse"/></returns>
        public async Task<DescribeDSPAComplianceGroupDetailResponse> DescribeDSPAComplianceGroupDetail(DescribeDSPAComplianceGroupDetailRequest req)
        {
             JsonResponseModel<DescribeDSPAComplianceGroupDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPAComplianceGroupDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAComplianceGroupDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取模板详情信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAComplianceGroupDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPAComplianceGroupDetailResponse"/></returns>
        public DescribeDSPAComplianceGroupDetailResponse DescribeDSPAComplianceGroupDetailSync(DescribeDSPAComplianceGroupDetailRequest req)
        {
             JsonResponseModel<DescribeDSPAComplianceGroupDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPAComplianceGroupDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAComplianceGroupDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取分类分级模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAComplianceGroupsRequest"/></param>
        /// <returns><see cref="DescribeDSPAComplianceGroupsResponse"/></returns>
        public async Task<DescribeDSPAComplianceGroupsResponse> DescribeDSPAComplianceGroups(DescribeDSPAComplianceGroupsRequest req)
        {
             JsonResponseModel<DescribeDSPAComplianceGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPAComplianceGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAComplianceGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取分类分级模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAComplianceGroupsRequest"/></param>
        /// <returns><see cref="DescribeDSPAComplianceGroupsResponse"/></returns>
        public DescribeDSPAComplianceGroupsResponse DescribeDSPAComplianceGroupsSync(DescribeDSPAComplianceGroupsRequest req)
        {
             JsonResponseModel<DescribeDSPAComplianceGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPAComplianceGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAComplianceGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取模板更新提示信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAComplianceUpdateNotificationRequest"/></param>
        /// <returns><see cref="DescribeDSPAComplianceUpdateNotificationResponse"/></returns>
        public async Task<DescribeDSPAComplianceUpdateNotificationResponse> DescribeDSPAComplianceUpdateNotification(DescribeDSPAComplianceUpdateNotificationRequest req)
        {
             JsonResponseModel<DescribeDSPAComplianceUpdateNotificationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPAComplianceUpdateNotification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAComplianceUpdateNotificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取模板更新提示信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAComplianceUpdateNotificationRequest"/></param>
        /// <returns><see cref="DescribeDSPAComplianceUpdateNotificationResponse"/></returns>
        public DescribeDSPAComplianceUpdateNotificationResponse DescribeDSPAComplianceUpdateNotificationSync(DescribeDSPAComplianceUpdateNotificationRequest req)
        {
             JsonResponseModel<DescribeDSPAComplianceUpdateNotificationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPAComplianceUpdateNotification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAComplianceUpdateNotificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取数据源的数据库信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPADataSourceDbInfoRequest"/></param>
        /// <returns><see cref="DescribeDSPADataSourceDbInfoResponse"/></returns>
        public async Task<DescribeDSPADataSourceDbInfoResponse> DescribeDSPADataSourceDbInfo(DescribeDSPADataSourceDbInfoRequest req)
        {
             JsonResponseModel<DescribeDSPADataSourceDbInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPADataSourceDbInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPADataSourceDbInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取数据源的数据库信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPADataSourceDbInfoRequest"/></param>
        /// <returns><see cref="DescribeDSPADataSourceDbInfoResponse"/></returns>
        public DescribeDSPADataSourceDbInfoResponse DescribeDSPADataSourceDbInfoSync(DescribeDSPADataSourceDbInfoRequest req)
        {
             JsonResponseModel<DescribeDSPADataSourceDbInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPADataSourceDbInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPADataSourceDbInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取分类分级规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPADiscoveryRulesRequest"/></param>
        /// <returns><see cref="DescribeDSPADiscoveryRulesResponse"/></returns>
        public async Task<DescribeDSPADiscoveryRulesResponse> DescribeDSPADiscoveryRules(DescribeDSPADiscoveryRulesRequest req)
        {
             JsonResponseModel<DescribeDSPADiscoveryRulesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPADiscoveryRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPADiscoveryRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取分类分级规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPADiscoveryRulesRequest"/></param>
        /// <returns><see cref="DescribeDSPADiscoveryRulesResponse"/></returns>
        public DescribeDSPADiscoveryRulesResponse DescribeDSPADiscoveryRulesSync(DescribeDSPADiscoveryRulesRequest req)
        {
             JsonResponseModel<DescribeDSPADiscoveryRulesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPADiscoveryRules");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPADiscoveryRulesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询该用户是否已开通分类分级服务
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPADiscoveryServiceStatusRequest"/></param>
        /// <returns><see cref="DescribeDSPADiscoveryServiceStatusResponse"/></returns>
        public async Task<DescribeDSPADiscoveryServiceStatusResponse> DescribeDSPADiscoveryServiceStatus(DescribeDSPADiscoveryServiceStatusRequest req)
        {
             JsonResponseModel<DescribeDSPADiscoveryServiceStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPADiscoveryServiceStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPADiscoveryServiceStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询该用户是否已开通分类分级服务
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPADiscoveryServiceStatusRequest"/></param>
        /// <returns><see cref="DescribeDSPADiscoveryServiceStatusResponse"/></returns>
        public DescribeDSPADiscoveryServiceStatusResponse DescribeDSPADiscoveryServiceStatusSync(DescribeDSPADiscoveryServiceStatusRequest req)
        {
             JsonResponseModel<DescribeDSPADiscoveryServiceStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPADiscoveryServiceStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPADiscoveryServiceStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取分类分级任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPADiscoveryTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPADiscoveryTaskDetailResponse"/></returns>
        public async Task<DescribeDSPADiscoveryTaskDetailResponse> DescribeDSPADiscoveryTaskDetail(DescribeDSPADiscoveryTaskDetailRequest req)
        {
             JsonResponseModel<DescribeDSPADiscoveryTaskDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPADiscoveryTaskDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPADiscoveryTaskDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取分类分级任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPADiscoveryTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPADiscoveryTaskDetailResponse"/></returns>
        public DescribeDSPADiscoveryTaskDetailResponse DescribeDSPADiscoveryTaskDetailSync(DescribeDSPADiscoveryTaskDetailRequest req)
        {
             JsonResponseModel<DescribeDSPADiscoveryTaskDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPADiscoveryTaskDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPADiscoveryTaskDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取分类分级任务结果，该接口只有在任务状态为以下状态时才支持结果正常查询：
        /// 3 扫描成功，
        /// 4 扫描失败
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPADiscoveryTaskResultRequest"/></param>
        /// <returns><see cref="DescribeDSPADiscoveryTaskResultResponse"/></returns>
        public async Task<DescribeDSPADiscoveryTaskResultResponse> DescribeDSPADiscoveryTaskResult(DescribeDSPADiscoveryTaskResultRequest req)
        {
             JsonResponseModel<DescribeDSPADiscoveryTaskResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPADiscoveryTaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPADiscoveryTaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DescribeDSPADiscoveryTaskResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPADiscoveryTaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPADiscoveryTaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取分类分级任务结果详情，该接口只有在任务状态为时才支持结果正确查询：
        /// 3 扫描成功
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPADiscoveryTaskResultDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPADiscoveryTaskResultDetailResponse"/></returns>
        public async Task<DescribeDSPADiscoveryTaskResultDetailResponse> DescribeDSPADiscoveryTaskResultDetail(DescribeDSPADiscoveryTaskResultDetailRequest req)
        {
             JsonResponseModel<DescribeDSPADiscoveryTaskResultDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPADiscoveryTaskResultDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPADiscoveryTaskResultDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取分类分级任务结果详情，该接口只有在任务状态为时才支持结果正确查询：
        /// 3 扫描成功
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPADiscoveryTaskResultDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPADiscoveryTaskResultDetailResponse"/></returns>
        public DescribeDSPADiscoveryTaskResultDetailResponse DescribeDSPADiscoveryTaskResultDetailSync(DescribeDSPADiscoveryTaskResultDetailRequest req)
        {
             JsonResponseModel<DescribeDSPADiscoveryTaskResultDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPADiscoveryTaskResultDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPADiscoveryTaskResultDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取分级分级扫描的表集合
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPADiscoveryTaskTablesRequest"/></param>
        /// <returns><see cref="DescribeDSPADiscoveryTaskTablesResponse"/></returns>
        public async Task<DescribeDSPADiscoveryTaskTablesResponse> DescribeDSPADiscoveryTaskTables(DescribeDSPADiscoveryTaskTablesRequest req)
        {
             JsonResponseModel<DescribeDSPADiscoveryTaskTablesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPADiscoveryTaskTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPADiscoveryTaskTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取分级分级扫描的表集合
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPADiscoveryTaskTablesRequest"/></param>
        /// <returns><see cref="DescribeDSPADiscoveryTaskTablesResponse"/></returns>
        public DescribeDSPADiscoveryTaskTablesResponse DescribeDSPADiscoveryTaskTablesSync(DescribeDSPADiscoveryTaskTablesRequest req)
        {
             JsonResponseModel<DescribeDSPADiscoveryTaskTablesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPADiscoveryTaskTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPADiscoveryTaskTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据合规组id，去查询ES的概览页统计数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAESDataAssetByComplianceIdRequest"/></param>
        /// <returns><see cref="DescribeDSPAESDataAssetByComplianceIdResponse"/></returns>
        public async Task<DescribeDSPAESDataAssetByComplianceIdResponse> DescribeDSPAESDataAssetByComplianceId(DescribeDSPAESDataAssetByComplianceIdRequest req)
        {
             JsonResponseModel<DescribeDSPAESDataAssetByComplianceIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPAESDataAssetByComplianceId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAESDataAssetByComplianceIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据合规组id，去查询ES的概览页统计数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAESDataAssetByComplianceIdRequest"/></param>
        /// <returns><see cref="DescribeDSPAESDataAssetByComplianceIdResponse"/></returns>
        public DescribeDSPAESDataAssetByComplianceIdResponse DescribeDSPAESDataAssetByComplianceIdSync(DescribeDSPAESDataAssetByComplianceIdRequest req)
        {
             JsonResponseModel<DescribeDSPAESDataAssetByComplianceIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPAESDataAssetByComplianceId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAESDataAssetByComplianceIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据合规组id，去查询ES的概览页下的统计列表数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAESDataAssetDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPAESDataAssetDetailResponse"/></returns>
        public async Task<DescribeDSPAESDataAssetDetailResponse> DescribeDSPAESDataAssetDetail(DescribeDSPAESDataAssetDetailRequest req)
        {
             JsonResponseModel<DescribeDSPAESDataAssetDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPAESDataAssetDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAESDataAssetDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据合规组id，去查询ES的概览页下的统计列表数据
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAESDataAssetDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPAESDataAssetDetailResponse"/></returns>
        public DescribeDSPAESDataAssetDetailResponse DescribeDSPAESDataAssetDetailSync(DescribeDSPAESDataAssetDetailRequest req)
        {
             JsonResponseModel<DescribeDSPAESDataAssetDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPAESDataAssetDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAESDataAssetDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取ES扫描结果数据样本
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAESDataSampleRequest"/></param>
        /// <returns><see cref="DescribeDSPAESDataSampleResponse"/></returns>
        public async Task<DescribeDSPAESDataSampleResponse> DescribeDSPAESDataSample(DescribeDSPAESDataSampleRequest req)
        {
             JsonResponseModel<DescribeDSPAESDataSampleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPAESDataSample");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAESDataSampleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取ES扫描结果数据样本
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAESDataSampleRequest"/></param>
        /// <returns><see cref="DescribeDSPAESDataSampleResponse"/></returns>
        public DescribeDSPAESDataSampleResponse DescribeDSPAESDataSampleSync(DescribeDSPAESDataSampleRequest req)
        {
             JsonResponseModel<DescribeDSPAESDataSampleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPAESDataSample");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAESDataSampleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取ES的分类分级任务结果详情，该接口只有在任务状态为时才支持结果正确查询：
        /// 3 扫描成功
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAESDiscoveryTaskResultDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPAESDiscoveryTaskResultDetailResponse"/></returns>
        public async Task<DescribeDSPAESDiscoveryTaskResultDetailResponse> DescribeDSPAESDiscoveryTaskResultDetail(DescribeDSPAESDiscoveryTaskResultDetailRequest req)
        {
             JsonResponseModel<DescribeDSPAESDiscoveryTaskResultDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPAESDiscoveryTaskResultDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAESDiscoveryTaskResultDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取ES的分类分级任务结果详情，该接口只有在任务状态为时才支持结果正确查询：
        /// 3 扫描成功
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPAESDiscoveryTaskResultDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPAESDiscoveryTaskResultDetailResponse"/></returns>
        public DescribeDSPAESDiscoveryTaskResultDetailResponse DescribeDSPAESDiscoveryTaskResultDetailSync(DescribeDSPAESDiscoveryTaskResultDetailRequest req)
        {
             JsonResponseModel<DescribeDSPAESDiscoveryTaskResultDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPAESDiscoveryTaskResultDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPAESDiscoveryTaskResultDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取分级详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPALevelDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPALevelDetailResponse"/></returns>
        public async Task<DescribeDSPALevelDetailResponse> DescribeDSPALevelDetail(DescribeDSPALevelDetailRequest req)
        {
             JsonResponseModel<DescribeDSPALevelDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPALevelDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPALevelDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取分级详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPALevelDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPALevelDetailResponse"/></returns>
        public DescribeDSPALevelDetailResponse DescribeDSPALevelDetailSync(DescribeDSPALevelDetailRequest req)
        {
             JsonResponseModel<DescribeDSPALevelDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPALevelDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPALevelDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取分级列表，限制100个 不分页返回
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPALevelGroupsRequest"/></param>
        /// <returns><see cref="DescribeDSPALevelGroupsResponse"/></returns>
        public async Task<DescribeDSPALevelGroupsResponse> DescribeDSPALevelGroups(DescribeDSPALevelGroupsRequest req)
        {
             JsonResponseModel<DescribeDSPALevelGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPALevelGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPALevelGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取分级列表，限制100个 不分页返回
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPALevelGroupsRequest"/></param>
        /// <returns><see cref="DescribeDSPALevelGroupsResponse"/></returns>
        public DescribeDSPALevelGroupsResponse DescribeDSPALevelGroupsSync(DescribeDSPALevelGroupsRequest req)
        {
             JsonResponseModel<DescribeDSPALevelGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPALevelGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPALevelGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取单个合规组下的RDB关系数据库分类分级数据资产
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPARDBDataAssetByComplianceIdRequest"/></param>
        /// <returns><see cref="DescribeDSPARDBDataAssetByComplianceIdResponse"/></returns>
        public async Task<DescribeDSPARDBDataAssetByComplianceIdResponse> DescribeDSPARDBDataAssetByComplianceId(DescribeDSPARDBDataAssetByComplianceIdRequest req)
        {
             JsonResponseModel<DescribeDSPARDBDataAssetByComplianceIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPARDBDataAssetByComplianceId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPARDBDataAssetByComplianceIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取单个合规组下的RDB关系数据库分类分级数据资产
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPARDBDataAssetByComplianceIdRequest"/></param>
        /// <returns><see cref="DescribeDSPARDBDataAssetByComplianceIdResponse"/></returns>
        public DescribeDSPARDBDataAssetByComplianceIdResponse DescribeDSPARDBDataAssetByComplianceIdSync(DescribeDSPARDBDataAssetByComplianceIdRequest req)
        {
             JsonResponseModel<DescribeDSPARDBDataAssetByComplianceIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPARDBDataAssetByComplianceId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPARDBDataAssetByComplianceIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取RDB关系数据库分类分级资产详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPARDBDataAssetDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPARDBDataAssetDetailResponse"/></returns>
        public async Task<DescribeDSPARDBDataAssetDetailResponse> DescribeDSPARDBDataAssetDetail(DescribeDSPARDBDataAssetDetailRequest req)
        {
             JsonResponseModel<DescribeDSPARDBDataAssetDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPARDBDataAssetDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPARDBDataAssetDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取RDB关系数据库分类分级资产详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPARDBDataAssetDetailRequest"/></param>
        /// <returns><see cref="DescribeDSPARDBDataAssetDetailResponse"/></returns>
        public DescribeDSPARDBDataAssetDetailResponse DescribeDSPARDBDataAssetDetailSync(DescribeDSPARDBDataAssetDetailRequest req)
        {
             JsonResponseModel<DescribeDSPARDBDataAssetDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPARDBDataAssetDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPARDBDataAssetDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取DSPA支持的Meta元数据类型，返回包括：元数据类型，支持的元数据地域信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPASupportedMetasRequest"/></param>
        /// <returns><see cref="DescribeDSPASupportedMetasResponse"/></returns>
        public async Task<DescribeDSPASupportedMetasResponse> DescribeDSPASupportedMetas(DescribeDSPASupportedMetasRequest req)
        {
             JsonResponseModel<DescribeDSPASupportedMetasResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPASupportedMetas");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPASupportedMetasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取DSPA支持的Meta元数据类型，返回包括：元数据类型，支持的元数据地域信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPASupportedMetasRequest"/></param>
        /// <returns><see cref="DescribeDSPASupportedMetasResponse"/></returns>
        public DescribeDSPASupportedMetasResponse DescribeDSPASupportedMetasSync(DescribeDSPASupportedMetasRequest req)
        {
             JsonResponseModel<DescribeDSPASupportedMetasResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPASupportedMetas");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPASupportedMetasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取扫描结果数据样本
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPATaskResultDataSampleRequest"/></param>
        /// <returns><see cref="DescribeDSPATaskResultDataSampleResponse"/></returns>
        public async Task<DescribeDSPATaskResultDataSampleResponse> DescribeDSPATaskResultDataSample(DescribeDSPATaskResultDataSampleRequest req)
        {
             JsonResponseModel<DescribeDSPATaskResultDataSampleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDSPATaskResultDataSample");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPATaskResultDataSampleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取扫描结果数据样本
        /// </summary>
        /// <param name="req"><see cref="DescribeDSPATaskResultDataSampleRequest"/></param>
        /// <returns><see cref="DescribeDSPATaskResultDataSampleResponse"/></returns>
        public DescribeDSPATaskResultDataSampleResponse DescribeDSPATaskResultDataSampleSync(DescribeDSPATaskResultDataSampleRequest req)
        {
             JsonResponseModel<DescribeDSPATaskResultDataSampleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDSPATaskResultDataSample");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDSPATaskResultDataSampleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 数据资产报告-查询es的敏感资产报告，包含（数据库资产，设敏级别数据库top10，资产详情）
        /// </summary>
        /// <param name="req"><see cref="DescribeESAssetSensitiveDistributionRequest"/></param>
        /// <returns><see cref="DescribeESAssetSensitiveDistributionResponse"/></returns>
        public async Task<DescribeESAssetSensitiveDistributionResponse> DescribeESAssetSensitiveDistribution(DescribeESAssetSensitiveDistributionRequest req)
        {
             JsonResponseModel<DescribeESAssetSensitiveDistributionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeESAssetSensitiveDistribution");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeESAssetSensitiveDistributionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 数据资产报告-查询es的敏感资产报告，包含（数据库资产，设敏级别数据库top10，资产详情）
        /// </summary>
        /// <param name="req"><see cref="DescribeESAssetSensitiveDistributionRequest"/></param>
        /// <returns><see cref="DescribeESAssetSensitiveDistributionResponse"/></returns>
        public DescribeESAssetSensitiveDistributionResponse DescribeESAssetSensitiveDistributionSync(DescribeESAssetSensitiveDistributionRequest req)
        {
             JsonResponseModel<DescribeESAssetSensitiveDistributionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeESAssetSensitiveDistribution");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeESAssetSensitiveDistributionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取导出任务结果
        /// </summary>
        /// <param name="req"><see cref="DescribeExportTaskResultRequest"/></param>
        /// <returns><see cref="DescribeExportTaskResultResponse"/></returns>
        public async Task<DescribeExportTaskResultResponse> DescribeExportTaskResult(DescribeExportTaskResultRequest req)
        {
             JsonResponseModel<DescribeExportTaskResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeExportTaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExportTaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取导出任务结果
        /// </summary>
        /// <param name="req"><see cref="DescribeExportTaskResultRequest"/></param>
        /// <returns><see cref="DescribeExportTaskResultResponse"/></returns>
        public DescribeExportTaskResultResponse DescribeExportTaskResultSync(DescribeExportTaskResultRequest req)
        {
             JsonResponseModel<DescribeExportTaskResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeExportTaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeExportTaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询标准下所有叶子节点分类
        /// </summary>
        /// <param name="req"><see cref="DescribeLeafClassificationRequest"/></param>
        /// <returns><see cref="DescribeLeafClassificationResponse"/></returns>
        public async Task<DescribeLeafClassificationResponse> DescribeLeafClassification(DescribeLeafClassificationRequest req)
        {
             JsonResponseModel<DescribeLeafClassificationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLeafClassification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLeafClassificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询标准下所有叶子节点分类
        /// </summary>
        /// <param name="req"><see cref="DescribeLeafClassificationRequest"/></param>
        /// <returns><see cref="DescribeLeafClassificationResponse"/></returns>
        public DescribeLeafClassificationResponse DescribeLeafClassificationSync(DescribeLeafClassificationRequest req)
        {
             JsonResponseModel<DescribeLeafClassificationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLeafClassification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLeafClassificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 数据资产报告-查询mongo 的敏感资产报告，包含（数据库资产，设敏级别数据库top10，资产详情）
        /// </summary>
        /// <param name="req"><see cref="DescribeMongoAssetSensitiveDistributionRequest"/></param>
        /// <returns><see cref="DescribeMongoAssetSensitiveDistributionResponse"/></returns>
        public async Task<DescribeMongoAssetSensitiveDistributionResponse> DescribeMongoAssetSensitiveDistribution(DescribeMongoAssetSensitiveDistributionRequest req)
        {
             JsonResponseModel<DescribeMongoAssetSensitiveDistributionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMongoAssetSensitiveDistribution");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMongoAssetSensitiveDistributionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 数据资产报告-查询mongo 的敏感资产报告，包含（数据库资产，设敏级别数据库top10，资产详情）
        /// </summary>
        /// <param name="req"><see cref="DescribeMongoAssetSensitiveDistributionRequest"/></param>
        /// <returns><see cref="DescribeMongoAssetSensitiveDistributionResponse"/></returns>
        public DescribeMongoAssetSensitiveDistributionResponse DescribeMongoAssetSensitiveDistributionSync(DescribeMongoAssetSensitiveDistributionRequest req)
        {
             JsonResponseModel<DescribeMongoAssetSensitiveDistributionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMongoAssetSensitiveDistribution");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMongoAssetSensitiveDistributionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 数据资产报告-查询rbd 的敏感资产报告，包含（数据库资产，设敏级别数据库top10，资产详情）
        /// </summary>
        /// <param name="req"><see cref="DescribeRDBAssetSensitiveDistributionRequest"/></param>
        /// <returns><see cref="DescribeRDBAssetSensitiveDistributionResponse"/></returns>
        public async Task<DescribeRDBAssetSensitiveDistributionResponse> DescribeRDBAssetSensitiveDistribution(DescribeRDBAssetSensitiveDistributionRequest req)
        {
             JsonResponseModel<DescribeRDBAssetSensitiveDistributionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRDBAssetSensitiveDistribution");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRDBAssetSensitiveDistributionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 数据资产报告-查询rbd 的敏感资产报告，包含（数据库资产，设敏级别数据库top10，资产详情）
        /// </summary>
        /// <param name="req"><see cref="DescribeRDBAssetSensitiveDistributionRequest"/></param>
        /// <returns><see cref="DescribeRDBAssetSensitiveDistributionResponse"/></returns>
        public DescribeRDBAssetSensitiveDistributionResponse DescribeRDBAssetSensitiveDistributionSync(DescribeRDBAssetSensitiveDistributionRequest req)
        {
             JsonResponseModel<DescribeRDBAssetSensitiveDistributionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRDBAssetSensitiveDistribution");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRDBAssetSensitiveDistributionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取报表下载链接
        /// </summary>
        /// <param name="req"><see cref="DescribeReportTaskDownloadUrlRequest"/></param>
        /// <returns><see cref="DescribeReportTaskDownloadUrlResponse"/></returns>
        public async Task<DescribeReportTaskDownloadUrlResponse> DescribeReportTaskDownloadUrl(DescribeReportTaskDownloadUrlRequest req)
        {
             JsonResponseModel<DescribeReportTaskDownloadUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeReportTaskDownloadUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReportTaskDownloadUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取报表下载链接
        /// </summary>
        /// <param name="req"><see cref="DescribeReportTaskDownloadUrlRequest"/></param>
        /// <returns><see cref="DescribeReportTaskDownloadUrlResponse"/></returns>
        public DescribeReportTaskDownloadUrlResponse DescribeReportTaskDownloadUrlSync(DescribeReportTaskDownloadUrlRequest req)
        {
             JsonResponseModel<DescribeReportTaskDownloadUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeReportTaskDownloadUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReportTaskDownloadUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取资产报表任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeReportTasksRequest"/></param>
        /// <returns><see cref="DescribeReportTasksResponse"/></returns>
        public async Task<DescribeReportTasksResponse> DescribeReportTasks(DescribeReportTasksRequest req)
        {
             JsonResponseModel<DescribeReportTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeReportTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReportTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取资产报表任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeReportTasksRequest"/></param>
        /// <returns><see cref="DescribeReportTasksResponse"/></returns>
        public DescribeReportTasksResponse DescribeReportTasksSync(DescribeReportTasksRequest req)
        {
             JsonResponseModel<DescribeReportTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeReportTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReportTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询分类规则详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleDetailRequest"/></param>
        /// <returns><see cref="DescribeRuleDetailResponse"/></returns>
        public async Task<DescribeRuleDetailResponse> DescribeRuleDetail(DescribeRuleDetailRequest req)
        {
             JsonResponseModel<DescribeRuleDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRuleDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询分类规则详情
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleDetailRequest"/></param>
        /// <returns><see cref="DescribeRuleDetailResponse"/></returns>
        public DescribeRuleDetailResponse DescribeRuleDetailSync(DescribeRuleDetailRequest req)
        {
             JsonResponseModel<DescribeRuleDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRuleDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询分类下规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleListRequest"/></param>
        /// <returns><see cref="DescribeRuleListResponse"/></returns>
        public async Task<DescribeRuleListResponse> DescribeRuleList(DescribeRuleListRequest req)
        {
             JsonResponseModel<DescribeRuleListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRuleList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询分类下规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRuleListRequest"/></param>
        /// <returns><see cref="DescribeRuleListResponse"/></returns>
        public DescribeRuleListResponse DescribeRuleListSync(DescribeRuleListRequest req)
        {
             JsonResponseModel<DescribeRuleListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRuleList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuleListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 数据资产报告-查询cos的敏感数据分布（分级分布 分类分布 敏感规则分布详情列表）
        /// </summary>
        /// <param name="req"><see cref="DescribeSensitiveCOSDataDistributionRequest"/></param>
        /// <returns><see cref="DescribeSensitiveCOSDataDistributionResponse"/></returns>
        public async Task<DescribeSensitiveCOSDataDistributionResponse> DescribeSensitiveCOSDataDistribution(DescribeSensitiveCOSDataDistributionRequest req)
        {
             JsonResponseModel<DescribeSensitiveCOSDataDistributionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSensitiveCOSDataDistribution");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSensitiveCOSDataDistributionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 数据资产报告-查询cos的敏感数据分布（分级分布 分类分布 敏感规则分布详情列表）
        /// </summary>
        /// <param name="req"><see cref="DescribeSensitiveCOSDataDistributionRequest"/></param>
        /// <returns><see cref="DescribeSensitiveCOSDataDistributionResponse"/></returns>
        public DescribeSensitiveCOSDataDistributionResponse DescribeSensitiveCOSDataDistributionSync(DescribeSensitiveCOSDataDistributionRequest req)
        {
             JsonResponseModel<DescribeSensitiveCOSDataDistributionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSensitiveCOSDataDistribution");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSensitiveCOSDataDistributionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 数据资产报告-查询rdb的敏感数据分布-敏感规则字段分布-敏感分布详情
        /// </summary>
        /// <param name="req"><see cref="DescribeSensitiveRDBDataDistributionRequest"/></param>
        /// <returns><see cref="DescribeSensitiveRDBDataDistributionResponse"/></returns>
        public async Task<DescribeSensitiveRDBDataDistributionResponse> DescribeSensitiveRDBDataDistribution(DescribeSensitiveRDBDataDistributionRequest req)
        {
             JsonResponseModel<DescribeSensitiveRDBDataDistributionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSensitiveRDBDataDistribution");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSensitiveRDBDataDistributionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 数据资产报告-查询rdb的敏感数据分布-敏感规则字段分布-敏感分布详情
        /// </summary>
        /// <param name="req"><see cref="DescribeSensitiveRDBDataDistributionRequest"/></param>
        /// <returns><see cref="DescribeSensitiveRDBDataDistributionResponse"/></returns>
        public DescribeSensitiveRDBDataDistributionResponse DescribeSensitiveRDBDataDistributionSync(DescribeSensitiveRDBDataDistributionRequest req)
        {
             JsonResponseModel<DescribeSensitiveRDBDataDistributionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSensitiveRDBDataDistribution");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSensitiveRDBDataDistributionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 取消用户云资源授权
        /// </summary>
        /// <param name="req"><see cref="DisableDSPAMetaResourceAuthRequest"/></param>
        /// <returns><see cref="DisableDSPAMetaResourceAuthResponse"/></returns>
        public async Task<DisableDSPAMetaResourceAuthResponse> DisableDSPAMetaResourceAuth(DisableDSPAMetaResourceAuthRequest req)
        {
             JsonResponseModel<DisableDSPAMetaResourceAuthResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableDSPAMetaResourceAuth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableDSPAMetaResourceAuthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 取消用户云资源授权
        /// </summary>
        /// <param name="req"><see cref="DisableDSPAMetaResourceAuthRequest"/></param>
        /// <returns><see cref="DisableDSPAMetaResourceAuthResponse"/></returns>
        public DisableDSPAMetaResourceAuthResponse DisableDSPAMetaResourceAuthSync(DisableDSPAMetaResourceAuthRequest req)
        {
             JsonResponseModel<DisableDSPAMetaResourceAuthResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableDSPAMetaResourceAuth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableDSPAMetaResourceAuthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 打开或者关闭分类分级规则
        /// 注：此API同时对该规则下的RDB跟COS规则操作。
        /// 
        /// </summary>
        /// <param name="req"><see cref="EnableDSPADiscoveryRuleRequest"/></param>
        /// <returns><see cref="EnableDSPADiscoveryRuleResponse"/></returns>
        public async Task<EnableDSPADiscoveryRuleResponse> EnableDSPADiscoveryRule(EnableDSPADiscoveryRuleRequest req)
        {
             JsonResponseModel<EnableDSPADiscoveryRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableDSPADiscoveryRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableDSPADiscoveryRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<EnableDSPADiscoveryRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableDSPADiscoveryRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableDSPADiscoveryRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启用版本体验
        /// </summary>
        /// <param name="req"><see cref="EnableTrialVersionRequest"/></param>
        /// <returns><see cref="EnableTrialVersionResponse"/></returns>
        public async Task<EnableTrialVersionResponse> EnableTrialVersion(EnableTrialVersionRequest req)
        {
             JsonResponseModel<EnableTrialVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableTrialVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableTrialVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启用版本体验
        /// </summary>
        /// <param name="req"><see cref="EnableTrialVersionRequest"/></param>
        /// <returns><see cref="EnableTrialVersionResponse"/></returns>
        public EnableTrialVersionResponse EnableTrialVersionSync(EnableTrialVersionRequest req)
        {
             JsonResponseModel<EnableTrialVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableTrialVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableTrialVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建敏感数据导出任务
        /// </summary>
        /// <param name="req"><see cref="ExportAssetDetailDataRequest"/></param>
        /// <returns><see cref="ExportAssetDetailDataResponse"/></returns>
        public async Task<ExportAssetDetailDataResponse> ExportAssetDetailData(ExportAssetDetailDataRequest req)
        {
             JsonResponseModel<ExportAssetDetailDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExportAssetDetailData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportAssetDetailDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建敏感数据导出任务
        /// </summary>
        /// <param name="req"><see cref="ExportAssetDetailDataRequest"/></param>
        /// <returns><see cref="ExportAssetDetailDataResponse"/></returns>
        public ExportAssetDetailDataResponse ExportAssetDetailDataSync(ExportAssetDetailDataRequest req)
        {
             JsonResponseModel<ExportAssetDetailDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExportAssetDetailData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExportAssetDetailDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取授权资源的连接状态
        /// </summary>
        /// <param name="req"><see cref="GetResourceConnectionStatusRequest"/></param>
        /// <returns><see cref="GetResourceConnectionStatusResponse"/></returns>
        public async Task<GetResourceConnectionStatusResponse> GetResourceConnectionStatus(GetResourceConnectionStatusRequest req)
        {
             JsonResponseModel<GetResourceConnectionStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetResourceConnectionStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetResourceConnectionStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取授权资源的连接状态
        /// </summary>
        /// <param name="req"><see cref="GetResourceConnectionStatusRequest"/></param>
        /// <returns><see cref="GetResourceConnectionStatusResponse"/></returns>
        public GetResourceConnectionStatusResponse GetResourceConnectionStatusSync(GetResourceConnectionStatusRequest req)
        {
             JsonResponseModel<GetResourceConnectionStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetResourceConnectionStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetResourceConnectionStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取体验版本信息
        /// </summary>
        /// <param name="req"><see cref="GetTrialVersionRequest"/></param>
        /// <returns><see cref="GetTrialVersionResponse"/></returns>
        public async Task<GetTrialVersionResponse> GetTrialVersion(GetTrialVersionRequest req)
        {
             JsonResponseModel<GetTrialVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetTrialVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetTrialVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取体验版本信息
        /// </summary>
        /// <param name="req"><see cref="GetTrialVersionRequest"/></param>
        /// <returns><see cref="GetTrialVersionResponse"/></returns>
        public GetTrialVersionResponse GetTrialVersionSync(GetTrialVersionRequest req)
        {
             JsonResponseModel<GetTrialVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetTrialVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetTrialVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户购买配额信息
        /// </summary>
        /// <param name="req"><see cref="GetUserQuotaInfoRequest"/></param>
        /// <returns><see cref="GetUserQuotaInfoResponse"/></returns>
        public async Task<GetUserQuotaInfoResponse> GetUserQuotaInfo(GetUserQuotaInfoRequest req)
        {
             JsonResponseModel<GetUserQuotaInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetUserQuotaInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetUserQuotaInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户购买配额信息
        /// </summary>
        /// <param name="req"><see cref="GetUserQuotaInfoRequest"/></param>
        /// <returns><see cref="GetUserQuotaInfoResponse"/></returns>
        public GetUserQuotaInfoResponse GetUserQuotaInfoSync(GetUserQuotaInfoRequest req)
        {
             JsonResponseModel<GetUserQuotaInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetUserQuotaInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetUserQuotaInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取DSPA集群列表
        /// </summary>
        /// <param name="req"><see cref="ListDSPAClustersRequest"/></param>
        /// <returns><see cref="ListDSPAClustersResponse"/></returns>
        public async Task<ListDSPAClustersResponse> ListDSPAClusters(ListDSPAClustersRequest req)
        {
             JsonResponseModel<ListDSPAClustersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListDSPAClusters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListDSPAClustersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取DSPA集群列表
        /// </summary>
        /// <param name="req"><see cref="ListDSPAClustersRequest"/></param>
        /// <returns><see cref="ListDSPAClustersResponse"/></returns>
        public ListDSPAClustersResponse ListDSPAClustersSync(ListDSPAClustersRequest req)
        {
             JsonResponseModel<ListDSPAClustersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListDSPAClusters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListDSPAClustersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于获取COS元数据信息，返回COS元数据信息列表。
        /// </summary>
        /// <param name="req"><see cref="ListDSPACosMetaResourcesRequest"/></param>
        /// <returns><see cref="ListDSPACosMetaResourcesResponse"/></returns>
        public async Task<ListDSPACosMetaResourcesResponse> ListDSPACosMetaResources(ListDSPACosMetaResourcesRequest req)
        {
             JsonResponseModel<ListDSPACosMetaResourcesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListDSPACosMetaResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListDSPACosMetaResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于获取COS元数据信息，返回COS元数据信息列表。
        /// </summary>
        /// <param name="req"><see cref="ListDSPACosMetaResourcesRequest"/></param>
        /// <returns><see cref="ListDSPACosMetaResourcesResponse"/></returns>
        public ListDSPACosMetaResourcesResponse ListDSPACosMetaResourcesSync(ListDSPACosMetaResourcesRequest req)
        {
             JsonResponseModel<ListDSPACosMetaResourcesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListDSPACosMetaResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListDSPACosMetaResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取用户云资源
        /// </summary>
        /// <param name="req"><see cref="ListDSPAMetaResourcesRequest"/></param>
        /// <returns><see cref="ListDSPAMetaResourcesResponse"/></returns>
        public async Task<ListDSPAMetaResourcesResponse> ListDSPAMetaResources(ListDSPAMetaResourcesRequest req)
        {
             JsonResponseModel<ListDSPAMetaResourcesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListDSPAMetaResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListDSPAMetaResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取用户云资源
        /// </summary>
        /// <param name="req"><see cref="ListDSPAMetaResourcesRequest"/></param>
        /// <returns><see cref="ListDSPAMetaResourcesResponse"/></returns>
        public ListDSPAMetaResourcesResponse ListDSPAMetaResourcesSync(ListDSPAMetaResourcesRequest req)
        {
             JsonResponseModel<ListDSPAMetaResourcesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListDSPAMetaResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListDSPAMetaResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑识别规则
        /// </summary>
        /// <param name="req"><see cref="ModifyClassificationRuleRequest"/></param>
        /// <returns><see cref="ModifyClassificationRuleResponse"/></returns>
        public async Task<ModifyClassificationRuleResponse> ModifyClassificationRule(ModifyClassificationRuleRequest req)
        {
             JsonResponseModel<ModifyClassificationRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyClassificationRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClassificationRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑识别规则
        /// </summary>
        /// <param name="req"><see cref="ModifyClassificationRuleRequest"/></param>
        /// <returns><see cref="ModifyClassificationRuleResponse"/></returns>
        public ModifyClassificationRuleResponse ModifyClassificationRuleSync(ModifyClassificationRuleRequest req)
        {
             JsonResponseModel<ModifyClassificationRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyClassificationRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClassificationRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改识别规则状态
        /// </summary>
        /// <param name="req"><see cref="ModifyClassificationRuleStateRequest"/></param>
        /// <returns><see cref="ModifyClassificationRuleStateResponse"/></returns>
        public async Task<ModifyClassificationRuleStateResponse> ModifyClassificationRuleState(ModifyClassificationRuleStateRequest req)
        {
             JsonResponseModel<ModifyClassificationRuleStateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyClassificationRuleState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClassificationRuleStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改识别规则状态
        /// </summary>
        /// <param name="req"><see cref="ModifyClassificationRuleStateRequest"/></param>
        /// <returns><see cref="ModifyClassificationRuleStateResponse"/></returns>
        public ModifyClassificationRuleStateResponse ModifyClassificationRuleStateSync(ModifyClassificationRuleStateRequest req)
        {
             JsonResponseModel<ModifyClassificationRuleStateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyClassificationRuleState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyClassificationRuleStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改DSPA评估风险项，支持修改Status
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPAAssessmentRiskRequest"/></param>
        /// <returns><see cref="ModifyDSPAAssessmentRiskResponse"/></returns>
        public async Task<ModifyDSPAAssessmentRiskResponse> ModifyDSPAAssessmentRisk(ModifyDSPAAssessmentRiskRequest req)
        {
             JsonResponseModel<ModifyDSPAAssessmentRiskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDSPAAssessmentRisk");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDSPAAssessmentRiskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改DSPA评估风险项，支持修改Status
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPAAssessmentRiskRequest"/></param>
        /// <returns><see cref="ModifyDSPAAssessmentRiskResponse"/></returns>
        public ModifyDSPAAssessmentRiskResponse ModifyDSPAAssessmentRiskSync(ModifyDSPAAssessmentRiskRequest req)
        {
             JsonResponseModel<ModifyDSPAAssessmentRiskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDSPAAssessmentRisk");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDSPAAssessmentRiskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改最新评估风险项状态
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPAAssessmentRiskLatestRequest"/></param>
        /// <returns><see cref="ModifyDSPAAssessmentRiskLatestResponse"/></returns>
        public async Task<ModifyDSPAAssessmentRiskLatestResponse> ModifyDSPAAssessmentRiskLatest(ModifyDSPAAssessmentRiskLatestRequest req)
        {
             JsonResponseModel<ModifyDSPAAssessmentRiskLatestResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDSPAAssessmentRiskLatest");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDSPAAssessmentRiskLatestResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改最新评估风险项状态
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPAAssessmentRiskLatestRequest"/></param>
        /// <returns><see cref="ModifyDSPAAssessmentRiskLatestResponse"/></returns>
        public ModifyDSPAAssessmentRiskLatestResponse ModifyDSPAAssessmentRiskLatestSync(ModifyDSPAAssessmentRiskLatestRequest req)
        {
             JsonResponseModel<ModifyDSPAAssessmentRiskLatestResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDSPAAssessmentRiskLatest");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDSPAAssessmentRiskLatestResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 风险项页面----修改风险等级的详情数据
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPAAssessmentRiskLevelRequest"/></param>
        /// <returns><see cref="ModifyDSPAAssessmentRiskLevelResponse"/></returns>
        public async Task<ModifyDSPAAssessmentRiskLevelResponse> ModifyDSPAAssessmentRiskLevel(ModifyDSPAAssessmentRiskLevelRequest req)
        {
             JsonResponseModel<ModifyDSPAAssessmentRiskLevelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDSPAAssessmentRiskLevel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDSPAAssessmentRiskLevelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 风险项页面----修改风险等级的详情数据
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPAAssessmentRiskLevelRequest"/></param>
        /// <returns><see cref="ModifyDSPAAssessmentRiskLevelResponse"/></returns>
        public ModifyDSPAAssessmentRiskLevelResponse ModifyDSPAAssessmentRiskLevelSync(ModifyDSPAAssessmentRiskLevelRequest req)
        {
             JsonResponseModel<ModifyDSPAAssessmentRiskLevelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDSPAAssessmentRiskLevel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDSPAAssessmentRiskLevelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 风险模版---修改风险模版
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPAAssessmentRiskTemplateRequest"/></param>
        /// <returns><see cref="ModifyDSPAAssessmentRiskTemplateResponse"/></returns>
        public async Task<ModifyDSPAAssessmentRiskTemplateResponse> ModifyDSPAAssessmentRiskTemplate(ModifyDSPAAssessmentRiskTemplateRequest req)
        {
             JsonResponseModel<ModifyDSPAAssessmentRiskTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDSPAAssessmentRiskTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDSPAAssessmentRiskTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 风险模版---修改风险模版
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPAAssessmentRiskTemplateRequest"/></param>
        /// <returns><see cref="ModifyDSPAAssessmentRiskTemplateResponse"/></returns>
        public ModifyDSPAAssessmentRiskTemplateResponse ModifyDSPAAssessmentRiskTemplateSync(ModifyDSPAAssessmentRiskTemplateRequest req)
        {
             JsonResponseModel<ModifyDSPAAssessmentRiskTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDSPAAssessmentRiskTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDSPAAssessmentRiskTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        public async Task<ModifyDSPACOSDiscoveryTaskResponse> ModifyDSPACOSDiscoveryTask(ModifyDSPACOSDiscoveryTaskRequest req)
        {
             JsonResponseModel<ModifyDSPACOSDiscoveryTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDSPACOSDiscoveryTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDSPACOSDiscoveryTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<ModifyDSPACOSDiscoveryTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDSPACOSDiscoveryTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDSPACOSDiscoveryTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 调整COS任务扫描结果
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPACOSTaskResultRequest"/></param>
        /// <returns><see cref="ModifyDSPACOSTaskResultResponse"/></returns>
        public async Task<ModifyDSPACOSTaskResultResponse> ModifyDSPACOSTaskResult(ModifyDSPACOSTaskResultRequest req)
        {
             JsonResponseModel<ModifyDSPACOSTaskResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDSPACOSTaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDSPACOSTaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 调整COS任务扫描结果
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPACOSTaskResultRequest"/></param>
        /// <returns><see cref="ModifyDSPACOSTaskResultResponse"/></returns>
        public ModifyDSPACOSTaskResultResponse ModifyDSPACOSTaskResultSync(ModifyDSPACOSTaskResultRequest req)
        {
             JsonResponseModel<ModifyDSPACOSTaskResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDSPACOSTaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDSPACOSTaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改分类，内置分类不支持修改。
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPACategoryRequest"/></param>
        /// <returns><see cref="ModifyDSPACategoryResponse"/></returns>
        public async Task<ModifyDSPACategoryResponse> ModifyDSPACategory(ModifyDSPACategoryRequest req)
        {
             JsonResponseModel<ModifyDSPACategoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDSPACategory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDSPACategoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改分类，内置分类不支持修改。
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPACategoryRequest"/></param>
        /// <returns><see cref="ModifyDSPACategoryResponse"/></returns>
        public ModifyDSPACategoryResponse ModifyDSPACategorySync(ModifyDSPACategoryRequest req)
        {
             JsonResponseModel<ModifyDSPACategoryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDSPACategory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDSPACategoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改分类分级关系
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPACategoryRelationRequest"/></param>
        /// <returns><see cref="ModifyDSPACategoryRelationResponse"/></returns>
        public async Task<ModifyDSPACategoryRelationResponse> ModifyDSPACategoryRelation(ModifyDSPACategoryRelationRequest req)
        {
             JsonResponseModel<ModifyDSPACategoryRelationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDSPACategoryRelation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDSPACategoryRelationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改分类分级关系
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPACategoryRelationRequest"/></param>
        /// <returns><see cref="ModifyDSPACategoryRelationResponse"/></returns>
        public ModifyDSPACategoryRelationResponse ModifyDSPACategoryRelationSync(ModifyDSPACategoryRelationRequest req)
        {
             JsonResponseModel<ModifyDSPACategoryRelationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDSPACategoryRelation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDSPACategoryRelationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改DSPA集群信息
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPAClusterInfoRequest"/></param>
        /// <returns><see cref="ModifyDSPAClusterInfoResponse"/></returns>
        public async Task<ModifyDSPAClusterInfoResponse> ModifyDSPAClusterInfo(ModifyDSPAClusterInfoRequest req)
        {
             JsonResponseModel<ModifyDSPAClusterInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDSPAClusterInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDSPAClusterInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改DSPA集群信息
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPAClusterInfoRequest"/></param>
        /// <returns><see cref="ModifyDSPAClusterInfoResponse"/></returns>
        public ModifyDSPAClusterInfoResponse ModifyDSPAClusterInfoSync(ModifyDSPAClusterInfoRequest req)
        {
             JsonResponseModel<ModifyDSPAClusterInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDSPAClusterInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDSPAClusterInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改分类分级模板，内置模板不支持修改。
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPAComplianceGroupRequest"/></param>
        /// <returns><see cref="ModifyDSPAComplianceGroupResponse"/></returns>
        public async Task<ModifyDSPAComplianceGroupResponse> ModifyDSPAComplianceGroup(ModifyDSPAComplianceGroupRequest req)
        {
             JsonResponseModel<ModifyDSPAComplianceGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDSPAComplianceGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDSPAComplianceGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改分类分级模板，内置模板不支持修改。
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPAComplianceGroupRequest"/></param>
        /// <returns><see cref="ModifyDSPAComplianceGroupResponse"/></returns>
        public ModifyDSPAComplianceGroupResponse ModifyDSPAComplianceGroupSync(ModifyDSPAComplianceGroupRequest req)
        {
             JsonResponseModel<ModifyDSPAComplianceGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDSPAComplianceGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDSPAComplianceGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改分类分级规则，单个用户最多允许创建200个规则。
        /// 注：此API同时适用RDB跟COS类型数据。
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPADiscoveryRuleRequest"/></param>
        /// <returns><see cref="ModifyDSPADiscoveryRuleResponse"/></returns>
        public async Task<ModifyDSPADiscoveryRuleResponse> ModifyDSPADiscoveryRule(ModifyDSPADiscoveryRuleRequest req)
        {
             JsonResponseModel<ModifyDSPADiscoveryRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDSPADiscoveryRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDSPADiscoveryRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改分类分级规则，单个用户最多允许创建200个规则。
        /// 注：此API同时适用RDB跟COS类型数据。
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPADiscoveryRuleRequest"/></param>
        /// <returns><see cref="ModifyDSPADiscoveryRuleResponse"/></returns>
        public ModifyDSPADiscoveryRuleResponse ModifyDSPADiscoveryRuleSync(ModifyDSPADiscoveryRuleRequest req)
        {
             JsonResponseModel<ModifyDSPADiscoveryRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDSPADiscoveryRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDSPADiscoveryRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        public async Task<ModifyDSPADiscoveryTaskResponse> ModifyDSPADiscoveryTask(ModifyDSPADiscoveryTaskRequest req)
        {
             JsonResponseModel<ModifyDSPADiscoveryTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDSPADiscoveryTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDSPADiscoveryTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<ModifyDSPADiscoveryTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDSPADiscoveryTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDSPADiscoveryTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 调整ES任务扫描结果
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPAESTaskResultRequest"/></param>
        /// <returns><see cref="ModifyDSPAESTaskResultResponse"/></returns>
        public async Task<ModifyDSPAESTaskResultResponse> ModifyDSPAESTaskResult(ModifyDSPAESTaskResultRequest req)
        {
             JsonResponseModel<ModifyDSPAESTaskResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDSPAESTaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDSPAESTaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 调整ES任务扫描结果
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPAESTaskResultRequest"/></param>
        /// <returns><see cref="ModifyDSPAESTaskResultResponse"/></returns>
        public ModifyDSPAESTaskResultResponse ModifyDSPAESTaskResultSync(ModifyDSPAESTaskResultRequest req)
        {
             JsonResponseModel<ModifyDSPAESTaskResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDSPAESTaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDSPAESTaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 调整任务扫描结果
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPATaskResultRequest"/></param>
        /// <returns><see cref="ModifyDSPATaskResultResponse"/></returns>
        public async Task<ModifyDSPATaskResultResponse> ModifyDSPATaskResult(ModifyDSPATaskResultRequest req)
        {
             JsonResponseModel<ModifyDSPATaskResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDSPATaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDSPATaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 调整任务扫描结果
        /// </summary>
        /// <param name="req"><see cref="ModifyDSPATaskResultRequest"/></param>
        /// <returns><see cref="ModifyDSPATaskResultResponse"/></returns>
        public ModifyDSPATaskResultResponse ModifyDSPATaskResultSync(ModifyDSPATaskResultRequest req)
        {
             JsonResponseModel<ModifyDSPATaskResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDSPATaskResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDSPATaskResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改敏感级别信息
        /// </summary>
        /// <param name="req"><see cref="ModifyLevelInfoRequest"/></param>
        /// <returns><see cref="ModifyLevelInfoResponse"/></returns>
        public async Task<ModifyLevelInfoResponse> ModifyLevelInfo(ModifyLevelInfoRequest req)
        {
             JsonResponseModel<ModifyLevelInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLevelInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLevelInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改敏感级别信息
        /// </summary>
        /// <param name="req"><see cref="ModifyLevelInfoRequest"/></param>
        /// <returns><see cref="ModifyLevelInfoResponse"/></returns>
        public ModifyLevelInfoResponse ModifyLevelInfoSync(ModifyLevelInfoRequest req)
        {
             JsonResponseModel<ModifyLevelInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLevelInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLevelInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改级别名称
        /// </summary>
        /// <param name="req"><see cref="ModifyLevelNameRequest"/></param>
        /// <returns><see cref="ModifyLevelNameResponse"/></returns>
        public async Task<ModifyLevelNameResponse> ModifyLevelName(ModifyLevelNameRequest req)
        {
             JsonResponseModel<ModifyLevelNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLevelName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLevelNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改级别名称
        /// </summary>
        /// <param name="req"><see cref="ModifyLevelNameRequest"/></param>
        /// <returns><see cref="ModifyLevelNameResponse"/></returns>
        public ModifyLevelNameResponse ModifyLevelNameSync(ModifyLevelNameRequest req)
        {
             JsonResponseModel<ModifyLevelNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLevelName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLevelNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开启级别或关闭级别
        /// </summary>
        /// <param name="req"><see cref="ModifyLevelStateRequest"/></param>
        /// <returns><see cref="ModifyLevelStateResponse"/></returns>
        public async Task<ModifyLevelStateResponse> ModifyLevelState(ModifyLevelStateRequest req)
        {
             JsonResponseModel<ModifyLevelStateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLevelState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLevelStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 开启级别或关闭级别
        /// </summary>
        /// <param name="req"><see cref="ModifyLevelStateRequest"/></param>
        /// <returns><see cref="ModifyLevelStateResponse"/></returns>
        public ModifyLevelStateResponse ModifyLevelStateSync(ModifyLevelStateRequest req)
        {
             JsonResponseModel<ModifyLevelStateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLevelState");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLevelStateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 一个分类合并到另一个分类中（分类拖拽功能）
        /// </summary>
        /// <param name="req"><see cref="ModifyMergeClassificationRequest"/></param>
        /// <returns><see cref="ModifyMergeClassificationResponse"/></returns>
        public async Task<ModifyMergeClassificationResponse> ModifyMergeClassification(ModifyMergeClassificationRequest req)
        {
             JsonResponseModel<ModifyMergeClassificationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMergeClassification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMergeClassificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 一个分类合并到另一个分类中（分类拖拽功能）
        /// </summary>
        /// <param name="req"><see cref="ModifyMergeClassificationRequest"/></param>
        /// <returns><see cref="ModifyMergeClassificationResponse"/></returns>
        public ModifyMergeClassificationResponse ModifyMergeClassificationSync(ModifyMergeClassificationRequest req)
        {
             JsonResponseModel<ModifyMergeClassificationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMergeClassification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMergeClassificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改分类信息
        /// </summary>
        /// <param name="req"><see cref="ModifyNewClassificationRequest"/></param>
        /// <returns><see cref="ModifyNewClassificationResponse"/></returns>
        public async Task<ModifyNewClassificationResponse> ModifyNewClassification(ModifyNewClassificationRequest req)
        {
             JsonResponseModel<ModifyNewClassificationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNewClassification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNewClassificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改分类信息
        /// </summary>
        /// <param name="req"><see cref="ModifyNewClassificationRequest"/></param>
        /// <returns><see cref="ModifyNewClassificationResponse"/></returns>
        public ModifyNewClassificationResponse ModifyNewClassificationSync(ModifyNewClassificationRequest req)
        {
             JsonResponseModel<ModifyNewClassificationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNewClassification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNewClassificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改分级分类模板信息
        /// </summary>
        /// <param name="req"><see cref="ModifyStandardInfoRequest"/></param>
        /// <returns><see cref="ModifyStandardInfoResponse"/></returns>
        public async Task<ModifyStandardInfoResponse> ModifyStandardInfo(ModifyStandardInfoRequest req)
        {
             JsonResponseModel<ModifyStandardInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyStandardInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyStandardInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改分级分类模板信息
        /// </summary>
        /// <param name="req"><see cref="ModifyStandardInfoRequest"/></param>
        /// <returns><see cref="ModifyStandardInfoResponse"/></returns>
        public ModifyStandardInfoResponse ModifyStandardInfoSync(ModifyStandardInfoRequest req)
        {
             JsonResponseModel<ModifyStandardInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyStandardInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyStandardInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询DSPA实例的db列表
        /// </summary>
        /// <param name="req"><see cref="QueryDSPAMetaResourceDbListRequest"/></param>
        /// <returns><see cref="QueryDSPAMetaResourceDbListResponse"/></returns>
        public async Task<QueryDSPAMetaResourceDbListResponse> QueryDSPAMetaResourceDbList(QueryDSPAMetaResourceDbListRequest req)
        {
             JsonResponseModel<QueryDSPAMetaResourceDbListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryDSPAMetaResourceDbList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryDSPAMetaResourceDbListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询DSPA实例的db列表
        /// </summary>
        /// <param name="req"><see cref="QueryDSPAMetaResourceDbListRequest"/></param>
        /// <returns><see cref="QueryDSPAMetaResourceDbListResponse"/></returns>
        public QueryDSPAMetaResourceDbListResponse QueryDSPAMetaResourceDbListSync(QueryDSPAMetaResourceDbListRequest req)
        {
             JsonResponseModel<QueryDSPAMetaResourceDbListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryDSPAMetaResourceDbList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryDSPAMetaResourceDbListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取资源绑定DB状态
        /// </summary>
        /// <param name="req"><see cref="QueryResourceDbBindStatusRequest"/></param>
        /// <returns><see cref="QueryResourceDbBindStatusResponse"/></returns>
        public async Task<QueryResourceDbBindStatusResponse> QueryResourceDbBindStatus(QueryResourceDbBindStatusRequest req)
        {
             JsonResponseModel<QueryResourceDbBindStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryResourceDbBindStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryResourceDbBindStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取资源绑定DB状态
        /// </summary>
        /// <param name="req"><see cref="QueryResourceDbBindStatusRequest"/></param>
        /// <returns><see cref="QueryResourceDbBindStatusResponse"/></returns>
        public QueryResourceDbBindStatusResponse QueryResourceDbBindStatusSync(QueryResourceDbBindStatusRequest req)
        {
             JsonResponseModel<QueryResourceDbBindStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryResourceDbBindStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryResourceDbBindStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重新启动DSPA风险评估任务
        /// </summary>
        /// <param name="req"><see cref="RestartDSPAAssessmentTaskRequest"/></param>
        /// <returns><see cref="RestartDSPAAssessmentTaskResponse"/></returns>
        public async Task<RestartDSPAAssessmentTaskResponse> RestartDSPAAssessmentTask(RestartDSPAAssessmentTaskRequest req)
        {
             JsonResponseModel<RestartDSPAAssessmentTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RestartDSPAAssessmentTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestartDSPAAssessmentTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重新启动DSPA风险评估任务
        /// </summary>
        /// <param name="req"><see cref="RestartDSPAAssessmentTaskRequest"/></param>
        /// <returns><see cref="RestartDSPAAssessmentTaskResponse"/></returns>
        public RestartDSPAAssessmentTaskResponse RestartDSPAAssessmentTaskSync(RestartDSPAAssessmentTaskRequest req)
        {
             JsonResponseModel<RestartDSPAAssessmentTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RestartDSPAAssessmentTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestartDSPAAssessmentTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        public async Task<StartDSPADiscoveryTaskResponse> StartDSPADiscoveryTask(StartDSPADiscoveryTaskRequest req)
        {
             JsonResponseModel<StartDSPADiscoveryTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartDSPADiscoveryTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartDSPADiscoveryTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<StartDSPADiscoveryTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartDSPADiscoveryTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartDSPADiscoveryTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止分类分级任务，该接口只有在任务状态为以下状态时才支持正确执行停止扫描：
        /// 1 扫描中
        /// </summary>
        /// <param name="req"><see cref="StopDSPADiscoveryTaskRequest"/></param>
        /// <returns><see cref="StopDSPADiscoveryTaskResponse"/></returns>
        public async Task<StopDSPADiscoveryTaskResponse> StopDSPADiscoveryTask(StopDSPADiscoveryTaskRequest req)
        {
             JsonResponseModel<StopDSPADiscoveryTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopDSPADiscoveryTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopDSPADiscoveryTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止分类分级任务，该接口只有在任务状态为以下状态时才支持正确执行停止扫描：
        /// 1 扫描中
        /// </summary>
        /// <param name="req"><see cref="StopDSPADiscoveryTaskRequest"/></param>
        /// <returns><see cref="StopDSPADiscoveryTaskResponse"/></returns>
        public StopDSPADiscoveryTaskResponse StopDSPADiscoveryTaskSync(StopDSPADiscoveryTaskRequest req)
        {
             JsonResponseModel<StopDSPADiscoveryTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopDSPADiscoveryTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopDSPADiscoveryTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        public async Task<UpdateDSPASelfBuildResourceResponse> UpdateDSPASelfBuildResource(UpdateDSPASelfBuildResourceRequest req)
        {
             JsonResponseModel<UpdateDSPASelfBuildResourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateDSPASelfBuildResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDSPASelfBuildResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<UpdateDSPASelfBuildResourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateDSPASelfBuildResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDSPASelfBuildResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 验证COS分类分级规则
        /// </summary>
        /// <param name="req"><see cref="VerifyDSPACOSRuleRequest"/></param>
        /// <returns><see cref="VerifyDSPACOSRuleResponse"/></returns>
        public async Task<VerifyDSPACOSRuleResponse> VerifyDSPACOSRule(VerifyDSPACOSRuleRequest req)
        {
             JsonResponseModel<VerifyDSPACOSRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VerifyDSPACOSRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyDSPACOSRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 验证COS分类分级规则
        /// </summary>
        /// <param name="req"><see cref="VerifyDSPACOSRuleRequest"/></param>
        /// <returns><see cref="VerifyDSPACOSRuleResponse"/></returns>
        public VerifyDSPACOSRuleResponse VerifyDSPACOSRuleSync(VerifyDSPACOSRuleRequest req)
        {
             JsonResponseModel<VerifyDSPACOSRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "VerifyDSPACOSRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyDSPACOSRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 验证分类分级规则
        /// </summary>
        /// <param name="req"><see cref="VerifyDSPADiscoveryRuleRequest"/></param>
        /// <returns><see cref="VerifyDSPADiscoveryRuleResponse"/></returns>
        public async Task<VerifyDSPADiscoveryRuleResponse> VerifyDSPADiscoveryRule(VerifyDSPADiscoveryRuleRequest req)
        {
             JsonResponseModel<VerifyDSPADiscoveryRuleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VerifyDSPADiscoveryRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyDSPADiscoveryRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 验证分类分级规则
        /// </summary>
        /// <param name="req"><see cref="VerifyDSPADiscoveryRuleRequest"/></param>
        /// <returns><see cref="VerifyDSPADiscoveryRuleResponse"/></returns>
        public VerifyDSPADiscoveryRuleResponse VerifyDSPADiscoveryRuleSync(VerifyDSPADiscoveryRuleRequest req)
        {
             JsonResponseModel<VerifyDSPADiscoveryRuleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "VerifyDSPADiscoveryRule");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyDSPADiscoveryRuleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}

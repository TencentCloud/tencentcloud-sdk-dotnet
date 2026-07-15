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

namespace TencentCloud.Csip.V20221121
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Csip.V20221121.Models;

   public class CsipClient : AbstractClient{

       private const string endpoint = "csip.tencentcloudapi.com";
       private const string version = "2022-11-21";
       private const string sdkVersion = "SDK_NET_3.0.1463";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CsipClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CsipClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 添加资产管理员
        /// </summary>
        /// <param name="req"><see cref="AddDspmAssetManagerRequest"/></param>
        /// <returns><see cref="AddDspmAssetManagerResponse"/></returns>
        public Task<AddDspmAssetManagerResponse> AddDspmAssetManager(AddDspmAssetManagerRequest req)
        {
            return InternalRequestAsync<AddDspmAssetManagerResponse>(req, "AddDspmAssetManager");
        }

        /// <summary>
        /// 添加资产管理员
        /// </summary>
        /// <param name="req"><see cref="AddDspmAssetManagerRequest"/></param>
        /// <returns><see cref="AddDspmAssetManagerResponse"/></returns>
        public AddDspmAssetManagerResponse AddDspmAssetManagerSync(AddDspmAssetManagerRequest req)
        {
            return InternalRequestAsync<AddDspmAssetManagerResponse>(req, "AddDspmAssetManager")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// csip角色授权绑定接口
        /// </summary>
        /// <param name="req"><see cref="AddNewBindRoleUserRequest"/></param>
        /// <returns><see cref="AddNewBindRoleUserResponse"/></returns>
        public Task<AddNewBindRoleUserResponse> AddNewBindRoleUser(AddNewBindRoleUserRequest req)
        {
            return InternalRequestAsync<AddNewBindRoleUserResponse>(req, "AddNewBindRoleUser");
        }

        /// <summary>
        /// csip角色授权绑定接口
        /// </summary>
        /// <param name="req"><see cref="AddNewBindRoleUserRequest"/></param>
        /// <returns><see cref="AddNewBindRoleUserResponse"/></returns>
        public AddNewBindRoleUserResponse AddNewBindRoleUserSync(AddNewBindRoleUserRequest req)
        {
            return InternalRequestAsync<AddNewBindRoleUserResponse>(req, "AddNewBindRoleUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 检测AK 异步任务
        /// </summary>
        /// <param name="req"><see cref="CreateAccessKeyCheckTaskRequest"/></param>
        /// <returns><see cref="CreateAccessKeyCheckTaskResponse"/></returns>
        public Task<CreateAccessKeyCheckTaskResponse> CreateAccessKeyCheckTask(CreateAccessKeyCheckTaskRequest req)
        {
            return InternalRequestAsync<CreateAccessKeyCheckTaskResponse>(req, "CreateAccessKeyCheckTask");
        }

        /// <summary>
        /// 检测AK 异步任务
        /// </summary>
        /// <param name="req"><see cref="CreateAccessKeyCheckTaskRequest"/></param>
        /// <returns><see cref="CreateAccessKeyCheckTaskResponse"/></returns>
        public CreateAccessKeyCheckTaskResponse CreateAccessKeyCheckTaskSync(CreateAccessKeyCheckTaskRequest req)
        {
            return InternalRequestAsync<CreateAccessKeyCheckTaskResponse>(req, "CreateAccessKeyCheckTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 发起AK资产同步任务
        /// </summary>
        /// <param name="req"><see cref="CreateAccessKeySyncTaskRequest"/></param>
        /// <returns><see cref="CreateAccessKeySyncTaskResponse"/></returns>
        public Task<CreateAccessKeySyncTaskResponse> CreateAccessKeySyncTask(CreateAccessKeySyncTaskRequest req)
        {
            return InternalRequestAsync<CreateAccessKeySyncTaskResponse>(req, "CreateAccessKeySyncTask");
        }

        /// <summary>
        /// 发起AK资产同步任务
        /// </summary>
        /// <param name="req"><see cref="CreateAccessKeySyncTaskRequest"/></param>
        /// <returns><see cref="CreateAccessKeySyncTaskResponse"/></returns>
        public CreateAccessKeySyncTaskResponse CreateAccessKeySyncTaskSync(CreateAccessKeySyncTaskRequest req)
        {
            return InternalRequestAsync<CreateAccessKeySyncTaskResponse>(req, "CreateAccessKeySyncTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建资产同步任务
        /// </summary>
        /// <param name="req"><see cref="CreateCosAssetSyncTaskRequest"/></param>
        /// <returns><see cref="CreateCosAssetSyncTaskResponse"/></returns>
        public Task<CreateCosAssetSyncTaskResponse> CreateCosAssetSyncTask(CreateCosAssetSyncTaskRequest req)
        {
            return InternalRequestAsync<CreateCosAssetSyncTaskResponse>(req, "CreateCosAssetSyncTask");
        }

        /// <summary>
        /// 创建资产同步任务
        /// </summary>
        /// <param name="req"><see cref="CreateCosAssetSyncTaskRequest"/></param>
        /// <returns><see cref="CreateCosAssetSyncTaskResponse"/></returns>
        public CreateCosAssetSyncTaskResponse CreateCosAssetSyncTaskSync(CreateCosAssetSyncTaskRequest req)
        {
            return InternalRequestAsync<CreateCosAssetSyncTaskResponse>(req, "CreateCosAssetSyncTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建cos病毒扫描、敏感数据识别任务
        /// </summary>
        /// <param name="req"><see cref="CreateCosObjectScanTaskRequest"/></param>
        /// <returns><see cref="CreateCosObjectScanTaskResponse"/></returns>
        public Task<CreateCosObjectScanTaskResponse> CreateCosObjectScanTask(CreateCosObjectScanTaskRequest req)
        {
            return InternalRequestAsync<CreateCosObjectScanTaskResponse>(req, "CreateCosObjectScanTask");
        }

        /// <summary>
        /// 创建cos病毒扫描、敏感数据识别任务
        /// </summary>
        /// <param name="req"><see cref="CreateCosObjectScanTaskRequest"/></param>
        /// <returns><see cref="CreateCosObjectScanTaskResponse"/></returns>
        public CreateCosObjectScanTaskResponse CreateCosObjectScanTaskSync(CreateCosObjectScanTaskRequest req)
        {
            return InternalRequestAsync<CreateCosObjectScanTaskResponse>(req, "CreateCosObjectScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 添加cos告警策略
        /// </summary>
        /// <param name="req"><see cref="CreateCosPolicyRequest"/></param>
        /// <returns><see cref="CreateCosPolicyResponse"/></returns>
        public Task<CreateCosPolicyResponse> CreateCosPolicy(CreateCosPolicyRequest req)
        {
            return InternalRequestAsync<CreateCosPolicyResponse>(req, "CreateCosPolicy");
        }

        /// <summary>
        /// 添加cos告警策略
        /// </summary>
        /// <param name="req"><see cref="CreateCosPolicyRequest"/></param>
        /// <returns><see cref="CreateCosPolicyResponse"/></returns>
        public CreateCosPolicyResponse CreateCosPolicySync(CreateCosPolicyRequest req)
        {
            return InternalRequestAsync<CreateCosPolicyResponse>(req, "CreateCosPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建风险监测任务
        /// </summary>
        /// <param name="req"><see cref="CreateCosRiskScanTaskRequest"/></param>
        /// <returns><see cref="CreateCosRiskScanTaskResponse"/></returns>
        public Task<CreateCosRiskScanTaskResponse> CreateCosRiskScanTask(CreateCosRiskScanTaskRequest req)
        {
            return InternalRequestAsync<CreateCosRiskScanTaskResponse>(req, "CreateCosRiskScanTask");
        }

        /// <summary>
        /// 创建风险监测任务
        /// </summary>
        /// <param name="req"><see cref="CreateCosRiskScanTaskRequest"/></param>
        /// <returns><see cref="CreateCosRiskScanTaskResponse"/></returns>
        public CreateCosRiskScanTaskResponse CreateCosRiskScanTaskSync(CreateCosRiskScanTaskRequest req)
        {
            return InternalRequestAsync<CreateCosRiskScanTaskResponse>(req, "CreateCosRiskScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建域名、ip相关信息
        /// </summary>
        /// <param name="req"><see cref="CreateDomainAndIpRequest"/></param>
        /// <returns><see cref="CreateDomainAndIpResponse"/></returns>
        public Task<CreateDomainAndIpResponse> CreateDomainAndIp(CreateDomainAndIpRequest req)
        {
            return InternalRequestAsync<CreateDomainAndIpResponse>(req, "CreateDomainAndIp");
        }

        /// <summary>
        /// 创建域名、ip相关信息
        /// </summary>
        /// <param name="req"><see cref="CreateDomainAndIpRequest"/></param>
        /// <returns><see cref="CreateDomainAndIpResponse"/></returns>
        public CreateDomainAndIpResponse CreateDomainAndIpSync(CreateDomainAndIpRequest req)
        {
            return InternalRequestAsync<CreateDomainAndIpResponse>(req, "CreateDomainAndIp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建Dspm访问记录导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateDspmAccessExportJobRequest"/></param>
        /// <returns><see cref="CreateDspmAccessExportJobResponse"/></returns>
        public Task<CreateDspmAccessExportJobResponse> CreateDspmAccessExportJob(CreateDspmAccessExportJobRequest req)
        {
            return InternalRequestAsync<CreateDspmAccessExportJobResponse>(req, "CreateDspmAccessExportJob");
        }

        /// <summary>
        /// 创建Dspm访问记录导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateDspmAccessExportJobRequest"/></param>
        /// <returns><see cref="CreateDspmAccessExportJobResponse"/></returns>
        public CreateDspmAccessExportJobResponse CreateDspmAccessExportJobSync(CreateDspmAccessExportJobRequest req)
        {
            return InternalRequestAsync<CreateDspmAccessExportJobResponse>(req, "CreateDspmAccessExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建Dspm申请单
        /// </summary>
        /// <param name="req"><see cref="CreateDspmApplyOrderRequest"/></param>
        /// <returns><see cref="CreateDspmApplyOrderResponse"/></returns>
        public Task<CreateDspmApplyOrderResponse> CreateDspmApplyOrder(CreateDspmApplyOrderRequest req)
        {
            return InternalRequestAsync<CreateDspmApplyOrderResponse>(req, "CreateDspmApplyOrder");
        }

        /// <summary>
        /// 创建Dspm申请单
        /// </summary>
        /// <param name="req"><see cref="CreateDspmApplyOrderRequest"/></param>
        /// <returns><see cref="CreateDspmApplyOrderResponse"/></returns>
        public CreateDspmApplyOrderResponse CreateDspmApplyOrderSync(CreateDspmApplyOrderRequest req)
        {
            return InternalRequestAsync<CreateDspmApplyOrderResponse>(req, "CreateDspmApplyOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建Dspm审批历史导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateDspmApproveHistoryExportJobRequest"/></param>
        /// <returns><see cref="CreateDspmApproveHistoryExportJobResponse"/></returns>
        public Task<CreateDspmApproveHistoryExportJobResponse> CreateDspmApproveHistoryExportJob(CreateDspmApproveHistoryExportJobRequest req)
        {
            return InternalRequestAsync<CreateDspmApproveHistoryExportJobResponse>(req, "CreateDspmApproveHistoryExportJob");
        }

        /// <summary>
        /// 创建Dspm审批历史导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateDspmApproveHistoryExportJobRequest"/></param>
        /// <returns><see cref="CreateDspmApproveHistoryExportJobResponse"/></returns>
        public CreateDspmApproveHistoryExportJobResponse CreateDspmApproveHistoryExportJobSync(CreateDspmApproveHistoryExportJobRequest req)
        {
            return InternalRequestAsync<CreateDspmApproveHistoryExportJobResponse>(req, "CreateDspmApproveHistoryExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建Dspm资产访问拓扑导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateDspmAssetAccessTopologyExportJobRequest"/></param>
        /// <returns><see cref="CreateDspmAssetAccessTopologyExportJobResponse"/></returns>
        public Task<CreateDspmAssetAccessTopologyExportJobResponse> CreateDspmAssetAccessTopologyExportJob(CreateDspmAssetAccessTopologyExportJobRequest req)
        {
            return InternalRequestAsync<CreateDspmAssetAccessTopologyExportJobResponse>(req, "CreateDspmAssetAccessTopologyExportJob");
        }

        /// <summary>
        /// 创建Dspm资产访问拓扑导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateDspmAssetAccessTopologyExportJobRequest"/></param>
        /// <returns><see cref="CreateDspmAssetAccessTopologyExportJobResponse"/></returns>
        public CreateDspmAssetAccessTopologyExportJobResponse CreateDspmAssetAccessTopologyExportJobSync(CreateDspmAssetAccessTopologyExportJobRequest req)
        {
            return InternalRequestAsync<CreateDspmAssetAccessTopologyExportJobResponse>(req, "CreateDspmAssetAccessTopologyExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建Dspm资产列表导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateDspmAssetIdentifyInfoExportJobRequest"/></param>
        /// <returns><see cref="CreateDspmAssetIdentifyInfoExportJobResponse"/></returns>
        public Task<CreateDspmAssetIdentifyInfoExportJobResponse> CreateDspmAssetIdentifyInfoExportJob(CreateDspmAssetIdentifyInfoExportJobRequest req)
        {
            return InternalRequestAsync<CreateDspmAssetIdentifyInfoExportJobResponse>(req, "CreateDspmAssetIdentifyInfoExportJob");
        }

        /// <summary>
        /// 创建Dspm资产列表导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateDspmAssetIdentifyInfoExportJobRequest"/></param>
        /// <returns><see cref="CreateDspmAssetIdentifyInfoExportJobResponse"/></returns>
        public CreateDspmAssetIdentifyInfoExportJobResponse CreateDspmAssetIdentifyInfoExportJobSync(CreateDspmAssetIdentifyInfoExportJobRequest req)
        {
            return InternalRequestAsync<CreateDspmAssetIdentifyInfoExportJobResponse>(req, "CreateDspmAssetIdentifyInfoExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建Dspm资产列表导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateDspmAssetsExportJobRequest"/></param>
        /// <returns><see cref="CreateDspmAssetsExportJobResponse"/></returns>
        public Task<CreateDspmAssetsExportJobResponse> CreateDspmAssetsExportJob(CreateDspmAssetsExportJobRequest req)
        {
            return InternalRequestAsync<CreateDspmAssetsExportJobResponse>(req, "CreateDspmAssetsExportJob");
        }

        /// <summary>
        /// 创建Dspm资产列表导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateDspmAssetsExportJobRequest"/></param>
        /// <returns><see cref="CreateDspmAssetsExportJobResponse"/></returns>
        public CreateDspmAssetsExportJobResponse CreateDspmAssetsExportJobSync(CreateDspmAssetsExportJobRequest req)
        {
            return InternalRequestAsync<CreateDspmAssetsExportJobResponse>(req, "CreateDspmAssetsExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建日志导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateDspmExportTaskRequest"/></param>
        /// <returns><see cref="CreateDspmExportTaskResponse"/></returns>
        public Task<CreateDspmExportTaskResponse> CreateDspmExportTask(CreateDspmExportTaskRequest req)
        {
            return InternalRequestAsync<CreateDspmExportTaskResponse>(req, "CreateDspmExportTask");
        }

        /// <summary>
        /// 创建日志导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateDspmExportTaskRequest"/></param>
        /// <returns><see cref="CreateDspmExportTaskResponse"/></returns>
        public CreateDspmExportTaskResponse CreateDspmExportTaskSync(CreateDspmExportTaskRequest req)
        {
            return InternalRequestAsync<CreateDspmExportTaskResponse>(req, "CreateDspmExportTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建dspm数据识别分类
        /// </summary>
        /// <param name="req"><see cref="CreateDspmIdentifyCategoryRequest"/></param>
        /// <returns><see cref="CreateDspmIdentifyCategoryResponse"/></returns>
        public Task<CreateDspmIdentifyCategoryResponse> CreateDspmIdentifyCategory(CreateDspmIdentifyCategoryRequest req)
        {
            return InternalRequestAsync<CreateDspmIdentifyCategoryResponse>(req, "CreateDspmIdentifyCategory");
        }

        /// <summary>
        /// 创建dspm数据识别分类
        /// </summary>
        /// <param name="req"><see cref="CreateDspmIdentifyCategoryRequest"/></param>
        /// <returns><see cref="CreateDspmIdentifyCategoryResponse"/></returns>
        public CreateDspmIdentifyCategoryResponse CreateDspmIdentifyCategorySync(CreateDspmIdentifyCategoryRequest req)
        {
            return InternalRequestAsync<CreateDspmIdentifyCategoryResponse>(req, "CreateDspmIdentifyCategory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建dspm数据识别模板分类关联
        /// </summary>
        /// <param name="req"><see cref="CreateDspmIdentifyComplianceCategoryRelationRequest"/></param>
        /// <returns><see cref="CreateDspmIdentifyComplianceCategoryRelationResponse"/></returns>
        public Task<CreateDspmIdentifyComplianceCategoryRelationResponse> CreateDspmIdentifyComplianceCategoryRelation(CreateDspmIdentifyComplianceCategoryRelationRequest req)
        {
            return InternalRequestAsync<CreateDspmIdentifyComplianceCategoryRelationResponse>(req, "CreateDspmIdentifyComplianceCategoryRelation");
        }

        /// <summary>
        /// 创建dspm数据识别模板分类关联
        /// </summary>
        /// <param name="req"><see cref="CreateDspmIdentifyComplianceCategoryRelationRequest"/></param>
        /// <returns><see cref="CreateDspmIdentifyComplianceCategoryRelationResponse"/></returns>
        public CreateDspmIdentifyComplianceCategoryRelationResponse CreateDspmIdentifyComplianceCategoryRelationSync(CreateDspmIdentifyComplianceCategoryRelationRequest req)
        {
            return InternalRequestAsync<CreateDspmIdentifyComplianceCategoryRelationResponse>(req, "CreateDspmIdentifyComplianceCategoryRelation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建dspm数据识别模板
        /// </summary>
        /// <param name="req"><see cref="CreateDspmIdentifyComplianceGroupRequest"/></param>
        /// <returns><see cref="CreateDspmIdentifyComplianceGroupResponse"/></returns>
        public Task<CreateDspmIdentifyComplianceGroupResponse> CreateDspmIdentifyComplianceGroup(CreateDspmIdentifyComplianceGroupRequest req)
        {
            return InternalRequestAsync<CreateDspmIdentifyComplianceGroupResponse>(req, "CreateDspmIdentifyComplianceGroup");
        }

        /// <summary>
        /// 创建dspm数据识别模板
        /// </summary>
        /// <param name="req"><see cref="CreateDspmIdentifyComplianceGroupRequest"/></param>
        /// <returns><see cref="CreateDspmIdentifyComplianceGroupResponse"/></returns>
        public CreateDspmIdentifyComplianceGroupResponse CreateDspmIdentifyComplianceGroupSync(CreateDspmIdentifyComplianceGroupRequest req)
        {
            return InternalRequestAsync<CreateDspmIdentifyComplianceGroupResponse>(req, "CreateDspmIdentifyComplianceGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 复制dspm数据识别模板
        /// </summary>
        /// <param name="req"><see cref="CreateDspmIdentifyComplianceGroupCopyRequest"/></param>
        /// <returns><see cref="CreateDspmIdentifyComplianceGroupCopyResponse"/></returns>
        public Task<CreateDspmIdentifyComplianceGroupCopyResponse> CreateDspmIdentifyComplianceGroupCopy(CreateDspmIdentifyComplianceGroupCopyRequest req)
        {
            return InternalRequestAsync<CreateDspmIdentifyComplianceGroupCopyResponse>(req, "CreateDspmIdentifyComplianceGroupCopy");
        }

        /// <summary>
        /// 复制dspm数据识别模板
        /// </summary>
        /// <param name="req"><see cref="CreateDspmIdentifyComplianceGroupCopyRequest"/></param>
        /// <returns><see cref="CreateDspmIdentifyComplianceGroupCopyResponse"/></returns>
        public CreateDspmIdentifyComplianceGroupCopyResponse CreateDspmIdentifyComplianceGroupCopySync(CreateDspmIdentifyComplianceGroupCopyRequest req)
        {
            return InternalRequestAsync<CreateDspmIdentifyComplianceGroupCopyResponse>(req, "CreateDspmIdentifyComplianceGroupCopy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建dspm数据识别模板数据项关联
        /// </summary>
        /// <param name="req"><see cref="CreateDspmIdentifyComplianceRuleRelationRequest"/></param>
        /// <returns><see cref="CreateDspmIdentifyComplianceRuleRelationResponse"/></returns>
        public Task<CreateDspmIdentifyComplianceRuleRelationResponse> CreateDspmIdentifyComplianceRuleRelation(CreateDspmIdentifyComplianceRuleRelationRequest req)
        {
            return InternalRequestAsync<CreateDspmIdentifyComplianceRuleRelationResponse>(req, "CreateDspmIdentifyComplianceRuleRelation");
        }

        /// <summary>
        /// 创建dspm数据识别模板数据项关联
        /// </summary>
        /// <param name="req"><see cref="CreateDspmIdentifyComplianceRuleRelationRequest"/></param>
        /// <returns><see cref="CreateDspmIdentifyComplianceRuleRelationResponse"/></returns>
        public CreateDspmIdentifyComplianceRuleRelationResponse CreateDspmIdentifyComplianceRuleRelationSync(CreateDspmIdentifyComplianceRuleRelationRequest req)
        {
            return InternalRequestAsync<CreateDspmIdentifyComplianceRuleRelationResponse>(req, "CreateDspmIdentifyComplianceRuleRelation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建Dspm身份列表导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateDspmIdentifyInfoListExportJobRequest"/></param>
        /// <returns><see cref="CreateDspmIdentifyInfoListExportJobResponse"/></returns>
        public Task<CreateDspmIdentifyInfoListExportJobResponse> CreateDspmIdentifyInfoListExportJob(CreateDspmIdentifyInfoListExportJobRequest req)
        {
            return InternalRequestAsync<CreateDspmIdentifyInfoListExportJobResponse>(req, "CreateDspmIdentifyInfoListExportJob");
        }

        /// <summary>
        /// 创建Dspm身份列表导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateDspmIdentifyInfoListExportJobRequest"/></param>
        /// <returns><see cref="CreateDspmIdentifyInfoListExportJobResponse"/></returns>
        public CreateDspmIdentifyInfoListExportJobResponse CreateDspmIdentifyInfoListExportJobSync(CreateDspmIdentifyInfoListExportJobRequest req)
        {
            return InternalRequestAsync<CreateDspmIdentifyInfoListExportJobResponse>(req, "CreateDspmIdentifyInfoListExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建dspm数据识别分级组
        /// </summary>
        /// <param name="req"><see cref="CreateDspmIdentifyLevelGroupRequest"/></param>
        /// <returns><see cref="CreateDspmIdentifyLevelGroupResponse"/></returns>
        public Task<CreateDspmIdentifyLevelGroupResponse> CreateDspmIdentifyLevelGroup(CreateDspmIdentifyLevelGroupRequest req)
        {
            return InternalRequestAsync<CreateDspmIdentifyLevelGroupResponse>(req, "CreateDspmIdentifyLevelGroup");
        }

        /// <summary>
        /// 创建dspm数据识别分级组
        /// </summary>
        /// <param name="req"><see cref="CreateDspmIdentifyLevelGroupRequest"/></param>
        /// <returns><see cref="CreateDspmIdentifyLevelGroupResponse"/></returns>
        public CreateDspmIdentifyLevelGroupResponse CreateDspmIdentifyLevelGroupSync(CreateDspmIdentifyLevelGroupRequest req)
        {
            return InternalRequestAsync<CreateDspmIdentifyLevelGroupResponse>(req, "CreateDspmIdentifyLevelGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建dspm数据识别数据项
        /// </summary>
        /// <param name="req"><see cref="CreateDspmIdentifyRuleRequest"/></param>
        /// <returns><see cref="CreateDspmIdentifyRuleResponse"/></returns>
        public Task<CreateDspmIdentifyRuleResponse> CreateDspmIdentifyRule(CreateDspmIdentifyRuleRequest req)
        {
            return InternalRequestAsync<CreateDspmIdentifyRuleResponse>(req, "CreateDspmIdentifyRule");
        }

        /// <summary>
        /// 创建dspm数据识别数据项
        /// </summary>
        /// <param name="req"><see cref="CreateDspmIdentifyRuleRequest"/></param>
        /// <returns><see cref="CreateDspmIdentifyRuleResponse"/></returns>
        public CreateDspmIdentifyRuleResponse CreateDspmIdentifyRuleSync(CreateDspmIdentifyRuleRequest req)
        {
            return InternalRequestAsync<CreateDspmIdentifyRuleResponse>(req, "CreateDspmIdentifyRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建Dspm个人身份id
        /// </summary>
        /// <param name="req"><see cref="CreateDspmPersonalIdentifyRequest"/></param>
        /// <returns><see cref="CreateDspmPersonalIdentifyResponse"/></returns>
        public Task<CreateDspmPersonalIdentifyResponse> CreateDspmPersonalIdentify(CreateDspmPersonalIdentifyRequest req)
        {
            return InternalRequestAsync<CreateDspmPersonalIdentifyResponse>(req, "CreateDspmPersonalIdentify");
        }

        /// <summary>
        /// 创建Dspm个人身份id
        /// </summary>
        /// <param name="req"><see cref="CreateDspmPersonalIdentifyRequest"/></param>
        /// <returns><see cref="CreateDspmPersonalIdentifyResponse"/></returns>
        public CreateDspmPersonalIdentifyResponse CreateDspmPersonalIdentifySync(CreateDspmPersonalIdentifyRequest req)
        {
            return InternalRequestAsync<CreateDspmPersonalIdentifyResponse>(req, "CreateDspmPersonalIdentify")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建Dspm风险导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateDspmRiskExportJobRequest"/></param>
        /// <returns><see cref="CreateDspmRiskExportJobResponse"/></returns>
        public Task<CreateDspmRiskExportJobResponse> CreateDspmRiskExportJob(CreateDspmRiskExportJobRequest req)
        {
            return InternalRequestAsync<CreateDspmRiskExportJobResponse>(req, "CreateDspmRiskExportJob");
        }

        /// <summary>
        /// 创建Dspm风险导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateDspmRiskExportJobRequest"/></param>
        /// <returns><see cref="CreateDspmRiskExportJobResponse"/></returns>
        public CreateDspmRiskExportJobResponse CreateDspmRiskExportJobSync(CreateDspmRiskExportJobRequest req)
        {
            return InternalRequestAsync<CreateDspmRiskExportJobResponse>(req, "CreateDspmRiskExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建Dspm白名单策略
        /// </summary>
        /// <param name="req"><see cref="CreateDspmWhitelistStrategyRequest"/></param>
        /// <returns><see cref="CreateDspmWhitelistStrategyResponse"/></returns>
        public Task<CreateDspmWhitelistStrategyResponse> CreateDspmWhitelistStrategy(CreateDspmWhitelistStrategyRequest req)
        {
            return InternalRequestAsync<CreateDspmWhitelistStrategyResponse>(req, "CreateDspmWhitelistStrategy");
        }

        /// <summary>
        /// 创建Dspm白名单策略
        /// </summary>
        /// <param name="req"><see cref="CreateDspmWhitelistStrategyRequest"/></param>
        /// <returns><see cref="CreateDspmWhitelistStrategyResponse"/></returns>
        public CreateDspmWhitelistStrategyResponse CreateDspmWhitelistStrategySync(CreateDspmWhitelistStrategyRequest req)
        {
            return InternalRequestAsync<CreateDspmWhitelistStrategyResponse>(req, "CreateDspmWhitelistStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建IaC检测接入Token
        /// </summary>
        /// <param name="req"><see cref="CreateIaCAccessTokenRequest"/></param>
        /// <returns><see cref="CreateIaCAccessTokenResponse"/></returns>
        public Task<CreateIaCAccessTokenResponse> CreateIaCAccessToken(CreateIaCAccessTokenRequest req)
        {
            return InternalRequestAsync<CreateIaCAccessTokenResponse>(req, "CreateIaCAccessToken");
        }

        /// <summary>
        /// 创建IaC检测接入Token
        /// </summary>
        /// <param name="req"><see cref="CreateIaCAccessTokenRequest"/></param>
        /// <returns><see cref="CreateIaCAccessTokenResponse"/></returns>
        public CreateIaCAccessTokenResponse CreateIaCAccessTokenSync(CreateIaCAccessTokenRequest req)
        {
            return InternalRequestAsync<CreateIaCAccessTokenResponse>(req, "CreateIaCAccessToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建IaC检测文件导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateIaCFileExportJobRequest"/></param>
        /// <returns><see cref="CreateIaCFileExportJobResponse"/></returns>
        public Task<CreateIaCFileExportJobResponse> CreateIaCFileExportJob(CreateIaCFileExportJobRequest req)
        {
            return InternalRequestAsync<CreateIaCFileExportJobResponse>(req, "CreateIaCFileExportJob");
        }

        /// <summary>
        /// 创建IaC检测文件导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateIaCFileExportJobRequest"/></param>
        /// <returns><see cref="CreateIaCFileExportJobResponse"/></returns>
        public CreateIaCFileExportJobResponse CreateIaCFileExportJobSync(CreateIaCFileExportJobRequest req)
        {
            return InternalRequestAsync<CreateIaCFileExportJobResponse>(req, "CreateIaCFileExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建IaC检测文件重新扫描任务
        /// </summary>
        /// <param name="req"><see cref="CreateIaCFileReScanTaskRequest"/></param>
        /// <returns><see cref="CreateIaCFileReScanTaskResponse"/></returns>
        public Task<CreateIaCFileReScanTaskResponse> CreateIaCFileReScanTask(CreateIaCFileReScanTaskRequest req)
        {
            return InternalRequestAsync<CreateIaCFileReScanTaskResponse>(req, "CreateIaCFileReScanTask");
        }

        /// <summary>
        /// 创建IaC检测文件重新扫描任务
        /// </summary>
        /// <param name="req"><see cref="CreateIaCFileReScanTaskRequest"/></param>
        /// <returns><see cref="CreateIaCFileReScanTaskResponse"/></returns>
        public CreateIaCFileReScanTaskResponse CreateIaCFileReScanTaskSync(CreateIaCFileReScanTaskRequest req)
        {
            return InternalRequestAsync<CreateIaCFileReScanTaskResponse>(req, "CreateIaCFileReScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建风险中心扫描任务
        /// </summary>
        /// <param name="req"><see cref="CreateRiskCenterScanTaskRequest"/></param>
        /// <returns><see cref="CreateRiskCenterScanTaskResponse"/></returns>
        public Task<CreateRiskCenterScanTaskResponse> CreateRiskCenterScanTask(CreateRiskCenterScanTaskRequest req)
        {
            return InternalRequestAsync<CreateRiskCenterScanTaskResponse>(req, "CreateRiskCenterScanTask");
        }

        /// <summary>
        /// 创建风险中心扫描任务
        /// </summary>
        /// <param name="req"><see cref="CreateRiskCenterScanTaskRequest"/></param>
        /// <returns><see cref="CreateRiskCenterScanTaskResponse"/></returns>
        public CreateRiskCenterScanTaskResponse CreateRiskCenterScanTaskSync(CreateRiskCenterScanTaskRequest req)
        {
            return InternalRequestAsync<CreateRiskCenterScanTaskResponse>(req, "CreateRiskCenterScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 上传 Skill ZIP 文件，触发异步安全检测。上传成功后应使用返回的 ContentHash + EngineVersion 轮询 DescribeSkillScanResult 接口获取结果。上传接口具备幂等性，同一 Hash 的文件重复上传不会创建重复任务。检测结果保留90天，超期后需重新上传检测。
        /// </summary>
        /// <param name="req"><see cref="CreateSkillScanRequest"/></param>
        /// <returns><see cref="CreateSkillScanResponse"/></returns>
        public Task<CreateSkillScanResponse> CreateSkillScan(CreateSkillScanRequest req)
        {
            return InternalRequestAsync<CreateSkillScanResponse>(req, "CreateSkillScan");
        }

        /// <summary>
        /// 上传 Skill ZIP 文件，触发异步安全检测。上传成功后应使用返回的 ContentHash + EngineVersion 轮询 DescribeSkillScanResult 接口获取结果。上传接口具备幂等性，同一 Hash 的文件重复上传不会创建重复任务。检测结果保留90天，超期后需重新上传检测。
        /// </summary>
        /// <param name="req"><see cref="CreateSkillScanRequest"/></param>
        /// <returns><see cref="CreateSkillScanResponse"/></returns>
        public CreateSkillScanResponse CreateSkillScanSync(CreateSkillScanRequest req)
        {
            return InternalRequestAsync<CreateSkillScanResponse>(req, "CreateSkillScan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除已删除的cos ak资产
        /// </summary>
        /// <param name="req"><see cref="DeleteCosAkAssetRequest"/></param>
        /// <returns><see cref="DeleteCosAkAssetResponse"/></returns>
        public Task<DeleteCosAkAssetResponse> DeleteCosAkAsset(DeleteCosAkAssetRequest req)
        {
            return InternalRequestAsync<DeleteCosAkAssetResponse>(req, "DeleteCosAkAsset");
        }

        /// <summary>
        /// 删除已删除的cos ak资产
        /// </summary>
        /// <param name="req"><see cref="DeleteCosAkAssetRequest"/></param>
        /// <returns><see cref="DeleteCosAkAssetResponse"/></returns>
        public DeleteCosAkAssetResponse DeleteCosAkAssetSync(DeleteCosAkAssetRequest req)
        {
            return InternalRequestAsync<DeleteCosAkAssetResponse>(req, "DeleteCosAkAsset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除策略
        /// </summary>
        /// <param name="req"><see cref="DeleteCosPolicyRequest"/></param>
        /// <returns><see cref="DeleteCosPolicyResponse"/></returns>
        public Task<DeleteCosPolicyResponse> DeleteCosPolicy(DeleteCosPolicyRequest req)
        {
            return InternalRequestAsync<DeleteCosPolicyResponse>(req, "DeleteCosPolicy");
        }

        /// <summary>
        /// 删除策略
        /// </summary>
        /// <param name="req"><see cref="DeleteCosPolicyRequest"/></param>
        /// <returns><see cref="DeleteCosPolicyResponse"/></returns>
        public DeleteCosPolicyResponse DeleteCosPolicySync(DeleteCosPolicyRequest req)
        {
            return InternalRequestAsync<DeleteCosPolicyResponse>(req, "DeleteCosPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除域名和ip请求
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainAndIpRequest"/></param>
        /// <returns><see cref="DeleteDomainAndIpResponse"/></returns>
        public Task<DeleteDomainAndIpResponse> DeleteDomainAndIp(DeleteDomainAndIpRequest req)
        {
            return InternalRequestAsync<DeleteDomainAndIpResponse>(req, "DeleteDomainAndIp");
        }

        /// <summary>
        /// 删除域名和ip请求
        /// </summary>
        /// <param name="req"><see cref="DeleteDomainAndIpRequest"/></param>
        /// <returns><see cref="DeleteDomainAndIpResponse"/></returns>
        public DeleteDomainAndIpResponse DeleteDomainAndIpSync(DeleteDomainAndIpRequest req)
        {
            return InternalRequestAsync<DeleteDomainAndIpResponse>(req, "DeleteDomainAndIp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除Dspm申请单
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmApplyOrderRequest"/></param>
        /// <returns><see cref="DeleteDspmApplyOrderResponse"/></returns>
        public Task<DeleteDspmApplyOrderResponse> DeleteDspmApplyOrder(DeleteDspmApplyOrderRequest req)
        {
            return InternalRequestAsync<DeleteDspmApplyOrderResponse>(req, "DeleteDspmApplyOrder");
        }

        /// <summary>
        /// 删除Dspm申请单
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmApplyOrderRequest"/></param>
        /// <returns><see cref="DeleteDspmApplyOrderResponse"/></returns>
        public DeleteDspmApplyOrderResponse DeleteDspmApplyOrderSync(DeleteDspmApplyOrderRequest req)
        {
            return InternalRequestAsync<DeleteDspmApplyOrderResponse>(req, "DeleteDspmApplyOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除Dspm资产账号
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmAssetAccountRequest"/></param>
        /// <returns><see cref="DeleteDspmAssetAccountResponse"/></returns>
        public Task<DeleteDspmAssetAccountResponse> DeleteDspmAssetAccount(DeleteDspmAssetAccountRequest req)
        {
            return InternalRequestAsync<DeleteDspmAssetAccountResponse>(req, "DeleteDspmAssetAccount");
        }

        /// <summary>
        /// 删除Dspm资产账号
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmAssetAccountRequest"/></param>
        /// <returns><see cref="DeleteDspmAssetAccountResponse"/></returns>
        public DeleteDspmAssetAccountResponse DeleteDspmAssetAccountSync(DeleteDspmAssetAccountRequest req)
        {
            return InternalRequestAsync<DeleteDspmAssetAccountResponse>(req, "DeleteDspmAssetAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除备份日志
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmBackupLogListRequest"/></param>
        /// <returns><see cref="DeleteDspmBackupLogListResponse"/></returns>
        public Task<DeleteDspmBackupLogListResponse> DeleteDspmBackupLogList(DeleteDspmBackupLogListRequest req)
        {
            return InternalRequestAsync<DeleteDspmBackupLogListResponse>(req, "DeleteDspmBackupLogList");
        }

        /// <summary>
        /// 删除备份日志
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmBackupLogListRequest"/></param>
        /// <returns><see cref="DeleteDspmBackupLogListResponse"/></returns>
        public DeleteDspmBackupLogListResponse DeleteDspmBackupLogListSync(DeleteDspmBackupLogListRequest req)
        {
            return InternalRequestAsync<DeleteDspmBackupLogListResponse>(req, "DeleteDspmBackupLogList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除导出任务
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmExportTaskRequest"/></param>
        /// <returns><see cref="DeleteDspmExportTaskResponse"/></returns>
        public Task<DeleteDspmExportTaskResponse> DeleteDspmExportTask(DeleteDspmExportTaskRequest req)
        {
            return InternalRequestAsync<DeleteDspmExportTaskResponse>(req, "DeleteDspmExportTask");
        }

        /// <summary>
        /// 删除导出任务
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmExportTaskRequest"/></param>
        /// <returns><see cref="DeleteDspmExportTaskResponse"/></returns>
        public DeleteDspmExportTaskResponse DeleteDspmExportTaskSync(DeleteDspmExportTaskRequest req)
        {
            return InternalRequestAsync<DeleteDspmExportTaskResponse>(req, "DeleteDspmExportTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除dspm数据识别分类
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmIdentifyCategoryRequest"/></param>
        /// <returns><see cref="DeleteDspmIdentifyCategoryResponse"/></returns>
        public Task<DeleteDspmIdentifyCategoryResponse> DeleteDspmIdentifyCategory(DeleteDspmIdentifyCategoryRequest req)
        {
            return InternalRequestAsync<DeleteDspmIdentifyCategoryResponse>(req, "DeleteDspmIdentifyCategory");
        }

        /// <summary>
        /// 删除dspm数据识别分类
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmIdentifyCategoryRequest"/></param>
        /// <returns><see cref="DeleteDspmIdentifyCategoryResponse"/></returns>
        public DeleteDspmIdentifyCategoryResponse DeleteDspmIdentifyCategorySync(DeleteDspmIdentifyCategoryRequest req)
        {
            return InternalRequestAsync<DeleteDspmIdentifyCategoryResponse>(req, "DeleteDspmIdentifyCategory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除dspm数据识别模板分类关联
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmIdentifyComplianceCategoryRelationRequest"/></param>
        /// <returns><see cref="DeleteDspmIdentifyComplianceCategoryRelationResponse"/></returns>
        public Task<DeleteDspmIdentifyComplianceCategoryRelationResponse> DeleteDspmIdentifyComplianceCategoryRelation(DeleteDspmIdentifyComplianceCategoryRelationRequest req)
        {
            return InternalRequestAsync<DeleteDspmIdentifyComplianceCategoryRelationResponse>(req, "DeleteDspmIdentifyComplianceCategoryRelation");
        }

        /// <summary>
        /// 删除dspm数据识别模板分类关联
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmIdentifyComplianceCategoryRelationRequest"/></param>
        /// <returns><see cref="DeleteDspmIdentifyComplianceCategoryRelationResponse"/></returns>
        public DeleteDspmIdentifyComplianceCategoryRelationResponse DeleteDspmIdentifyComplianceCategoryRelationSync(DeleteDspmIdentifyComplianceCategoryRelationRequest req)
        {
            return InternalRequestAsync<DeleteDspmIdentifyComplianceCategoryRelationResponse>(req, "DeleteDspmIdentifyComplianceCategoryRelation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除dspm数据识别模板
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmIdentifyComplianceGroupRequest"/></param>
        /// <returns><see cref="DeleteDspmIdentifyComplianceGroupResponse"/></returns>
        public Task<DeleteDspmIdentifyComplianceGroupResponse> DeleteDspmIdentifyComplianceGroup(DeleteDspmIdentifyComplianceGroupRequest req)
        {
            return InternalRequestAsync<DeleteDspmIdentifyComplianceGroupResponse>(req, "DeleteDspmIdentifyComplianceGroup");
        }

        /// <summary>
        /// 删除dspm数据识别模板
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmIdentifyComplianceGroupRequest"/></param>
        /// <returns><see cref="DeleteDspmIdentifyComplianceGroupResponse"/></returns>
        public DeleteDspmIdentifyComplianceGroupResponse DeleteDspmIdentifyComplianceGroupSync(DeleteDspmIdentifyComplianceGroupRequest req)
        {
            return InternalRequestAsync<DeleteDspmIdentifyComplianceGroupResponse>(req, "DeleteDspmIdentifyComplianceGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除dspm数据识别模板数据项关联
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmIdentifyComplianceRuleRelationRequest"/></param>
        /// <returns><see cref="DeleteDspmIdentifyComplianceRuleRelationResponse"/></returns>
        public Task<DeleteDspmIdentifyComplianceRuleRelationResponse> DeleteDspmIdentifyComplianceRuleRelation(DeleteDspmIdentifyComplianceRuleRelationRequest req)
        {
            return InternalRequestAsync<DeleteDspmIdentifyComplianceRuleRelationResponse>(req, "DeleteDspmIdentifyComplianceRuleRelation");
        }

        /// <summary>
        /// 删除dspm数据识别模板数据项关联
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmIdentifyComplianceRuleRelationRequest"/></param>
        /// <returns><see cref="DeleteDspmIdentifyComplianceRuleRelationResponse"/></returns>
        public DeleteDspmIdentifyComplianceRuleRelationResponse DeleteDspmIdentifyComplianceRuleRelationSync(DeleteDspmIdentifyComplianceRuleRelationRequest req)
        {
            return InternalRequestAsync<DeleteDspmIdentifyComplianceRuleRelationResponse>(req, "DeleteDspmIdentifyComplianceRuleRelation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除dspm数据识别分级组
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmIdentifyLevelGroupRequest"/></param>
        /// <returns><see cref="DeleteDspmIdentifyLevelGroupResponse"/></returns>
        public Task<DeleteDspmIdentifyLevelGroupResponse> DeleteDspmIdentifyLevelGroup(DeleteDspmIdentifyLevelGroupRequest req)
        {
            return InternalRequestAsync<DeleteDspmIdentifyLevelGroupResponse>(req, "DeleteDspmIdentifyLevelGroup");
        }

        /// <summary>
        /// 删除dspm数据识别分级组
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmIdentifyLevelGroupRequest"/></param>
        /// <returns><see cref="DeleteDspmIdentifyLevelGroupResponse"/></returns>
        public DeleteDspmIdentifyLevelGroupResponse DeleteDspmIdentifyLevelGroupSync(DeleteDspmIdentifyLevelGroupRequest req)
        {
            return InternalRequestAsync<DeleteDspmIdentifyLevelGroupResponse>(req, "DeleteDspmIdentifyLevelGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除dspm数据识别数据项
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmIdentifyRuleRequest"/></param>
        /// <returns><see cref="DeleteDspmIdentifyRuleResponse"/></returns>
        public Task<DeleteDspmIdentifyRuleResponse> DeleteDspmIdentifyRule(DeleteDspmIdentifyRuleRequest req)
        {
            return InternalRequestAsync<DeleteDspmIdentifyRuleResponse>(req, "DeleteDspmIdentifyRule");
        }

        /// <summary>
        /// 删除dspm数据识别数据项
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmIdentifyRuleRequest"/></param>
        /// <returns><see cref="DeleteDspmIdentifyRuleResponse"/></returns>
        public DeleteDspmIdentifyRuleResponse DeleteDspmIdentifyRuleSync(DeleteDspmIdentifyRuleRequest req)
        {
            return InternalRequestAsync<DeleteDspmIdentifyRuleResponse>(req, "DeleteDspmIdentifyRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除Dspm个人身份id
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmPersonalIdentifyRequest"/></param>
        /// <returns><see cref="DeleteDspmPersonalIdentifyResponse"/></returns>
        public Task<DeleteDspmPersonalIdentifyResponse> DeleteDspmPersonalIdentify(DeleteDspmPersonalIdentifyRequest req)
        {
            return InternalRequestAsync<DeleteDspmPersonalIdentifyResponse>(req, "DeleteDspmPersonalIdentify");
        }

        /// <summary>
        /// 删除Dspm个人身份id
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmPersonalIdentifyRequest"/></param>
        /// <returns><see cref="DeleteDspmPersonalIdentifyResponse"/></returns>
        public DeleteDspmPersonalIdentifyResponse DeleteDspmPersonalIdentifySync(DeleteDspmPersonalIdentifyRequest req)
        {
            return InternalRequestAsync<DeleteDspmPersonalIdentifyResponse>(req, "DeleteDspmPersonalIdentify")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除恢复日志
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmRestoreLogListRequest"/></param>
        /// <returns><see cref="DeleteDspmRestoreLogListResponse"/></returns>
        public Task<DeleteDspmRestoreLogListResponse> DeleteDspmRestoreLogList(DeleteDspmRestoreLogListRequest req)
        {
            return InternalRequestAsync<DeleteDspmRestoreLogListResponse>(req, "DeleteDspmRestoreLogList");
        }

        /// <summary>
        /// 删除恢复日志
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmRestoreLogListRequest"/></param>
        /// <returns><see cref="DeleteDspmRestoreLogListResponse"/></returns>
        public DeleteDspmRestoreLogListResponse DeleteDspmRestoreLogListSync(DeleteDspmRestoreLogListRequest req)
        {
            return InternalRequestAsync<DeleteDspmRestoreLogListResponse>(req, "DeleteDspmRestoreLogList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除Dspm白名单策略
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmWhitelistStrategyRequest"/></param>
        /// <returns><see cref="DeleteDspmWhitelistStrategyResponse"/></returns>
        public Task<DeleteDspmWhitelistStrategyResponse> DeleteDspmWhitelistStrategy(DeleteDspmWhitelistStrategyRequest req)
        {
            return InternalRequestAsync<DeleteDspmWhitelistStrategyResponse>(req, "DeleteDspmWhitelistStrategy");
        }

        /// <summary>
        /// 删除Dspm白名单策略
        /// </summary>
        /// <param name="req"><see cref="DeleteDspmWhitelistStrategyRequest"/></param>
        /// <returns><see cref="DeleteDspmWhitelistStrategyResponse"/></returns>
        public DeleteDspmWhitelistStrategyResponse DeleteDspmWhitelistStrategySync(DeleteDspmWhitelistStrategyRequest req)
        {
            return InternalRequestAsync<DeleteDspmWhitelistStrategyResponse>(req, "DeleteDspmWhitelistStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除IaC检测接入Token
        /// </summary>
        /// <param name="req"><see cref="DeleteIaCAccessTokenRequest"/></param>
        /// <returns><see cref="DeleteIaCAccessTokenResponse"/></returns>
        public Task<DeleteIaCAccessTokenResponse> DeleteIaCAccessToken(DeleteIaCAccessTokenRequest req)
        {
            return InternalRequestAsync<DeleteIaCAccessTokenResponse>(req, "DeleteIaCAccessToken");
        }

        /// <summary>
        /// 删除IaC检测接入Token
        /// </summary>
        /// <param name="req"><see cref="DeleteIaCAccessTokenRequest"/></param>
        /// <returns><see cref="DeleteIaCAccessTokenResponse"/></returns>
        public DeleteIaCAccessTokenResponse DeleteIaCAccessTokenSync(DeleteIaCAccessTokenRequest req)
        {
            return InternalRequestAsync<DeleteIaCAccessTokenResponse>(req, "DeleteIaCAccessToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除IaC检测文件
        /// </summary>
        /// <param name="req"><see cref="DeleteIaCFileRequest"/></param>
        /// <returns><see cref="DeleteIaCFileResponse"/></returns>
        public Task<DeleteIaCFileResponse> DeleteIaCFile(DeleteIaCFileRequest req)
        {
            return InternalRequestAsync<DeleteIaCFileResponse>(req, "DeleteIaCFile");
        }

        /// <summary>
        /// 删除IaC检测文件
        /// </summary>
        /// <param name="req"><see cref="DeleteIaCFileRequest"/></param>
        /// <returns><see cref="DeleteIaCFileResponse"/></returns>
        public DeleteIaCFileResponse DeleteIaCFileSync(DeleteIaCFileRequest req)
        {
            return InternalRequestAsync<DeleteIaCFileResponse>(req, "DeleteIaCFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除风险中心扫描任务
        /// </summary>
        /// <param name="req"><see cref="DeleteRiskScanTaskRequest"/></param>
        /// <returns><see cref="DeleteRiskScanTaskResponse"/></returns>
        public Task<DeleteRiskScanTaskResponse> DeleteRiskScanTask(DeleteRiskScanTaskRequest req)
        {
            return InternalRequestAsync<DeleteRiskScanTaskResponse>(req, "DeleteRiskScanTask");
        }

        /// <summary>
        /// 删除风险中心扫描任务
        /// </summary>
        /// <param name="req"><see cref="DeleteRiskScanTaskRequest"/></param>
        /// <returns><see cref="DeleteRiskScanTaskResponse"/></returns>
        public DeleteRiskScanTaskResponse DeleteRiskScanTaskSync(DeleteRiskScanTaskRequest req)
        {
            return InternalRequestAsync<DeleteRiskScanTaskResponse>(req, "DeleteRiskScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取 AI agent 资产列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAgentAssetListRequest"/></param>
        /// <returns><see cref="DescribeAIAgentAssetListResponse"/></returns>
        public Task<DescribeAIAgentAssetListResponse> DescribeAIAgentAssetList(DescribeAIAgentAssetListRequest req)
        {
            return InternalRequestAsync<DescribeAIAgentAssetListResponse>(req, "DescribeAIAgentAssetList");
        }

        /// <summary>
        /// 获取 AI agent 资产列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAgentAssetListRequest"/></param>
        /// <returns><see cref="DescribeAIAgentAssetListResponse"/></returns>
        public DescribeAIAgentAssetListResponse DescribeAIAgentAssetListSync(DescribeAIAgentAssetListRequest req)
        {
            return InternalRequestAsync<DescribeAIAgentAssetListResponse>(req, "DescribeAIAgentAssetList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询AI-Link智链引擎配置
        /// </summary>
        /// <param name="req"><see cref="DescribeAILinkSettingRequest"/></param>
        /// <returns><see cref="DescribeAILinkSettingResponse"/></returns>
        public Task<DescribeAILinkSettingResponse> DescribeAILinkSetting(DescribeAILinkSettingRequest req)
        {
            return InternalRequestAsync<DescribeAILinkSettingResponse>(req, "DescribeAILinkSetting");
        }

        /// <summary>
        /// 查询AI-Link智链引擎配置
        /// </summary>
        /// <param name="req"><see cref="DescribeAILinkSettingRequest"/></param>
        /// <returns><see cref="DescribeAILinkSettingResponse"/></returns>
        public DescribeAILinkSettingResponse DescribeAILinkSettingSync(DescribeAILinkSettingRequest req)
        {
            return InternalRequestAsync<DescribeAILinkSettingResponse>(req, "DescribeAILinkSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 访问密钥告警记录AI分析结果详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAKAnalysisDetailRequest"/></param>
        /// <returns><see cref="DescribeAKAnalysisDetailResponse"/></returns>
        public Task<DescribeAKAnalysisDetailResponse> DescribeAKAnalysisDetail(DescribeAKAnalysisDetailRequest req)
        {
            return InternalRequestAsync<DescribeAKAnalysisDetailResponse>(req, "DescribeAKAnalysisDetail");
        }

        /// <summary>
        /// 访问密钥告警记录AI分析结果详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAKAnalysisDetailRequest"/></param>
        /// <returns><see cref="DescribeAKAnalysisDetailResponse"/></returns>
        public DescribeAKAnalysisDetailResponse DescribeAKAnalysisDetailSync(DescribeAKAnalysisDetailRequest req)
        {
            return InternalRequestAsync<DescribeAKAnalysisDetailResponse>(req, "DescribeAKAnalysisDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取调用记录列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAbnormalCallRecordRequest"/></param>
        /// <returns><see cref="DescribeAbnormalCallRecordResponse"/></returns>
        public Task<DescribeAbnormalCallRecordResponse> DescribeAbnormalCallRecord(DescribeAbnormalCallRecordRequest req)
        {
            return InternalRequestAsync<DescribeAbnormalCallRecordResponse>(req, "DescribeAbnormalCallRecord");
        }

        /// <summary>
        /// 获取调用记录列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAbnormalCallRecordRequest"/></param>
        /// <returns><see cref="DescribeAbnormalCallRecordResponse"/></returns>
        public DescribeAbnormalCallRecordResponse DescribeAbnormalCallRecordSync(DescribeAbnormalCallRecordRequest req)
        {
            return InternalRequestAsync<DescribeAbnormalCallRecordResponse>(req, "DescribeAbnormalCallRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 访问密钥告警记录列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessKeyAlarmRequest"/></param>
        /// <returns><see cref="DescribeAccessKeyAlarmResponse"/></returns>
        public Task<DescribeAccessKeyAlarmResponse> DescribeAccessKeyAlarm(DescribeAccessKeyAlarmRequest req)
        {
            return InternalRequestAsync<DescribeAccessKeyAlarmResponse>(req, "DescribeAccessKeyAlarm");
        }

        /// <summary>
        /// 访问密钥告警记录列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessKeyAlarmRequest"/></param>
        /// <returns><see cref="DescribeAccessKeyAlarmResponse"/></returns>
        public DescribeAccessKeyAlarmResponse DescribeAccessKeyAlarmSync(DescribeAccessKeyAlarmRequest req)
        {
            return InternalRequestAsync<DescribeAccessKeyAlarmResponse>(req, "DescribeAccessKeyAlarm")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 访问密钥告警记录详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessKeyAlarmDetailRequest"/></param>
        /// <returns><see cref="DescribeAccessKeyAlarmDetailResponse"/></returns>
        public Task<DescribeAccessKeyAlarmDetailResponse> DescribeAccessKeyAlarmDetail(DescribeAccessKeyAlarmDetailRequest req)
        {
            return InternalRequestAsync<DescribeAccessKeyAlarmDetailResponse>(req, "DescribeAccessKeyAlarmDetail");
        }

        /// <summary>
        /// 访问密钥告警记录详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessKeyAlarmDetailRequest"/></param>
        /// <returns><see cref="DescribeAccessKeyAlarmDetailResponse"/></returns>
        public DescribeAccessKeyAlarmDetailResponse DescribeAccessKeyAlarmDetailSync(DescribeAccessKeyAlarmDetailRequest req)
        {
            return InternalRequestAsync<DescribeAccessKeyAlarmDetailResponse>(req, "DescribeAccessKeyAlarmDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取用户访问密钥资产列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessKeyAssetRequest"/></param>
        /// <returns><see cref="DescribeAccessKeyAssetResponse"/></returns>
        public Task<DescribeAccessKeyAssetResponse> DescribeAccessKeyAsset(DescribeAccessKeyAssetRequest req)
        {
            return InternalRequestAsync<DescribeAccessKeyAssetResponse>(req, "DescribeAccessKeyAsset");
        }

        /// <summary>
        /// 获取用户访问密钥资产列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessKeyAssetRequest"/></param>
        /// <returns><see cref="DescribeAccessKeyAssetResponse"/></returns>
        public DescribeAccessKeyAssetResponse DescribeAccessKeyAssetSync(DescribeAccessKeyAssetRequest req)
        {
            return InternalRequestAsync<DescribeAccessKeyAssetResponse>(req, "DescribeAccessKeyAsset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 访问密钥风险记录列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessKeyRiskRequest"/></param>
        /// <returns><see cref="DescribeAccessKeyRiskResponse"/></returns>
        public Task<DescribeAccessKeyRiskResponse> DescribeAccessKeyRisk(DescribeAccessKeyRiskRequest req)
        {
            return InternalRequestAsync<DescribeAccessKeyRiskResponse>(req, "DescribeAccessKeyRisk");
        }

        /// <summary>
        /// 访问密钥风险记录列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessKeyRiskRequest"/></param>
        /// <returns><see cref="DescribeAccessKeyRiskResponse"/></returns>
        public DescribeAccessKeyRiskResponse DescribeAccessKeyRiskSync(DescribeAccessKeyRiskRequest req)
        {
            return InternalRequestAsync<DescribeAccessKeyRiskResponse>(req, "DescribeAccessKeyRisk")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 访问密钥风险记录详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessKeyRiskDetailRequest"/></param>
        /// <returns><see cref="DescribeAccessKeyRiskDetailResponse"/></returns>
        public Task<DescribeAccessKeyRiskDetailResponse> DescribeAccessKeyRiskDetail(DescribeAccessKeyRiskDetailRequest req)
        {
            return InternalRequestAsync<DescribeAccessKeyRiskDetailResponse>(req, "DescribeAccessKeyRiskDetail");
        }

        /// <summary>
        /// 访问密钥风险记录详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessKeyRiskDetailRequest"/></param>
        /// <returns><see cref="DescribeAccessKeyRiskDetailResponse"/></returns>
        public DescribeAccessKeyRiskDetailResponse DescribeAccessKeyRiskDetailSync(DescribeAccessKeyRiskDetailRequest req)
        {
            return InternalRequestAsync<DescribeAccessKeyRiskDetailResponse>(req, "DescribeAccessKeyRiskDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户的账号详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessKeyUserDetailRequest"/></param>
        /// <returns><see cref="DescribeAccessKeyUserDetailResponse"/></returns>
        public Task<DescribeAccessKeyUserDetailResponse> DescribeAccessKeyUserDetail(DescribeAccessKeyUserDetailRequest req)
        {
            return InternalRequestAsync<DescribeAccessKeyUserDetailResponse>(req, "DescribeAccessKeyUserDetail");
        }

        /// <summary>
        /// 查询用户的账号详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessKeyUserDetailRequest"/></param>
        /// <returns><see cref="DescribeAccessKeyUserDetailResponse"/></returns>
        public DescribeAccessKeyUserDetailResponse DescribeAccessKeyUserDetailSync(DescribeAccessKeyUserDetailRequest req)
        {
            return InternalRequestAsync<DescribeAccessKeyUserDetailResponse>(req, "DescribeAccessKeyUserDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户的账号列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessKeyUserListRequest"/></param>
        /// <returns><see cref="DescribeAccessKeyUserListResponse"/></returns>
        public Task<DescribeAccessKeyUserListResponse> DescribeAccessKeyUserList(DescribeAccessKeyUserListRequest req)
        {
            return InternalRequestAsync<DescribeAccessKeyUserListResponse>(req, "DescribeAccessKeyUserList");
        }

        /// <summary>
        /// 查询用户的账号列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAccessKeyUserListRequest"/></param>
        /// <returns><see cref="DescribeAccessKeyUserListResponse"/></returns>
        public DescribeAccessKeyUserListResponse DescribeAccessKeyUserListSync(DescribeAccessKeyUserListRequest req)
        {
            return InternalRequestAsync<DescribeAccessKeyUserListResponse>(req, "DescribeAccessKeyUserList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 告警中心全量告警列表接口
        /// </summary>
        /// <param name="req"><see cref="DescribeAlertListRequest"/></param>
        /// <returns><see cref="DescribeAlertListResponse"/></returns>
        public Task<DescribeAlertListResponse> DescribeAlertList(DescribeAlertListRequest req)
        {
            return InternalRequestAsync<DescribeAlertListResponse>(req, "DescribeAlertList");
        }

        /// <summary>
        /// 告警中心全量告警列表接口
        /// </summary>
        /// <param name="req"><see cref="DescribeAlertListRequest"/></param>
        /// <returns><see cref="DescribeAlertListResponse"/></returns>
        public DescribeAlertListResponse DescribeAlertListSync(DescribeAlertListRequest req)
        {
            return InternalRequestAsync<DescribeAlertListResponse>(req, "DescribeAlertList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询云边界分析-暴露路径下主机节点的进程列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetProcessListRequest"/></param>
        /// <returns><see cref="DescribeAssetProcessListResponse"/></returns>
        public Task<DescribeAssetProcessListResponse> DescribeAssetProcessList(DescribeAssetProcessListRequest req)
        {
            return InternalRequestAsync<DescribeAssetProcessListResponse>(req, "DescribeAssetProcessList");
        }

        /// <summary>
        /// 查询云边界分析-暴露路径下主机节点的进程列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetProcessListRequest"/></param>
        /// <returns><see cref="DescribeAssetProcessListResponse"/></returns>
        public DescribeAssetProcessListResponse DescribeAssetProcessListSync(DescribeAssetProcessListRequest req)
        {
            return InternalRequestAsync<DescribeAssetProcessListResponse>(req, "DescribeAssetProcessList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 资产视角下云资源配置风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetRiskListRequest"/></param>
        /// <returns><see cref="DescribeAssetRiskListResponse"/></returns>
        public Task<DescribeAssetRiskListResponse> DescribeAssetRiskList(DescribeAssetRiskListRequest req)
        {
            return InternalRequestAsync<DescribeAssetRiskListResponse>(req, "DescribeAssetRiskList");
        }

        /// <summary>
        /// 资产视角下云资源配置风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetRiskListRequest"/></param>
        /// <returns><see cref="DescribeAssetRiskListResponse"/></returns>
        public DescribeAssetRiskListResponse DescribeAssetRiskListSync(DescribeAssetRiskListRequest req)
        {
            return InternalRequestAsync<DescribeAssetRiskListResponse>(req, "DescribeAssetRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取资产视角的漏洞风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetViewVulRiskListRequest"/></param>
        /// <returns><see cref="DescribeAssetViewVulRiskListResponse"/></returns>
        public Task<DescribeAssetViewVulRiskListResponse> DescribeAssetViewVulRiskList(DescribeAssetViewVulRiskListRequest req)
        {
            return InternalRequestAsync<DescribeAssetViewVulRiskListResponse>(req, "DescribeAssetViewVulRiskList");
        }

        /// <summary>
        /// 获取资产视角的漏洞风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetViewVulRiskListRequest"/></param>
        /// <returns><see cref="DescribeAssetViewVulRiskListResponse"/></returns>
        public DescribeAssetViewVulRiskListResponse DescribeAssetViewVulRiskListSync(DescribeAssetViewVulRiskListRequest req)
        {
            return InternalRequestAsync<DescribeAssetViewVulRiskListResponse>(req, "DescribeAssetViewVulRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询是否绑定角色
        /// </summary>
        /// <param name="req"><see cref="DescribeAssumeRoleRequest"/></param>
        /// <returns><see cref="DescribeAssumeRoleResponse"/></returns>
        public Task<DescribeAssumeRoleResponse> DescribeAssumeRole(DescribeAssumeRoleRequest req)
        {
            return InternalRequestAsync<DescribeAssumeRoleResponse>(req, "DescribeAssumeRole");
        }

        /// <summary>
        /// 查询是否绑定角色
        /// </summary>
        /// <param name="req"><see cref="DescribeAssumeRoleRequest"/></param>
        /// <returns><see cref="DescribeAssumeRoleResponse"/></returns>
        public DescribeAssumeRoleResponse DescribeAssumeRoleSync(DescribeAssumeRoleRequest req)
        {
            return InternalRequestAsync<DescribeAssumeRoleResponse>(req, "DescribeAssumeRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看存储桶调用源ip列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBucketInvokeIpListRequest"/></param>
        /// <returns><see cref="DescribeBucketInvokeIpListResponse"/></returns>
        public Task<DescribeBucketInvokeIpListResponse> DescribeBucketInvokeIpList(DescribeBucketInvokeIpListRequest req)
        {
            return InternalRequestAsync<DescribeBucketInvokeIpListResponse>(req, "DescribeBucketInvokeIpList");
        }

        /// <summary>
        /// 查看存储桶调用源ip列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBucketInvokeIpListRequest"/></param>
        /// <returns><see cref="DescribeBucketInvokeIpListResponse"/></returns>
        public DescribeBucketInvokeIpListResponse DescribeBucketInvokeIpListSync(DescribeBucketInvokeIpListRequest req)
        {
            return InternalRequestAsync<DescribeBucketInvokeIpListResponse>(req, "DescribeBucketInvokeIpList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云防资产中心统计数据
        /// </summary>
        /// <param name="req"><see cref="DescribeCFWAssetStatisticsRequest"/></param>
        /// <returns><see cref="DescribeCFWAssetStatisticsResponse"/></returns>
        public Task<DescribeCFWAssetStatisticsResponse> DescribeCFWAssetStatistics(DescribeCFWAssetStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeCFWAssetStatisticsResponse>(req, "DescribeCFWAssetStatistics");
        }

        /// <summary>
        /// 云防资产中心统计数据
        /// </summary>
        /// <param name="req"><see cref="DescribeCFWAssetStatisticsRequest"/></param>
        /// <returns><see cref="DescribeCFWAssetStatisticsResponse"/></returns>
        public DescribeCFWAssetStatisticsResponse DescribeCFWAssetStatisticsSync(DescribeCFWAssetStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeCFWAssetStatisticsResponse>(req, "DescribeCFWAssetStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取日志索引信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCLSLogIndexV3Request"/></param>
        /// <returns><see cref="DescribeCLSLogIndexV3Response"/></returns>
        public Task<DescribeCLSLogIndexV3Response> DescribeCLSLogIndexV3(DescribeCLSLogIndexV3Request req)
        {
            return InternalRequestAsync<DescribeCLSLogIndexV3Response>(req, "DescribeCLSLogIndexV3");
        }

        /// <summary>
        /// 获取日志索引信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCLSLogIndexV3Request"/></param>
        /// <returns><see cref="DescribeCLSLogIndexV3Response"/></returns>
        public DescribeCLSLogIndexV3Response DescribeCLSLogIndexV3Sync(DescribeCLSLogIndexV3Request req)
        {
            return InternalRequestAsync<DescribeCLSLogIndexV3Response>(req, "DescribeCLSLogIndexV3")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 日志分析检索接口v3
        /// </summary>
        /// <param name="req"><see cref="DescribeCLSLogListV3Request"/></param>
        /// <returns><see cref="DescribeCLSLogListV3Response"/></returns>
        public Task<DescribeCLSLogListV3Response> DescribeCLSLogListV3(DescribeCLSLogListV3Request req)
        {
            return InternalRequestAsync<DescribeCLSLogListV3Response>(req, "DescribeCLSLogListV3");
        }

        /// <summary>
        /// 日志分析检索接口v3
        /// </summary>
        /// <param name="req"><see cref="DescribeCLSLogListV3Request"/></param>
        /// <returns><see cref="DescribeCLSLogListV3Response"/></returns>
        public DescribeCLSLogListV3Response DescribeCLSLogListV3Sync(DescribeCLSLogListV3Request req)
        {
            return InternalRequestAsync<DescribeCLSLogListV3Response>(req, "DescribeCLSLogListV3")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取风险中心风险概况示例
        /// </summary>
        /// <param name="req"><see cref="DescribeCSIPRiskStatisticsRequest"/></param>
        /// <returns><see cref="DescribeCSIPRiskStatisticsResponse"/></returns>
        public Task<DescribeCSIPRiskStatisticsResponse> DescribeCSIPRiskStatistics(DescribeCSIPRiskStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeCSIPRiskStatisticsResponse>(req, "DescribeCSIPRiskStatistics");
        }

        /// <summary>
        /// 获取风险中心风险概况示例
        /// </summary>
        /// <param name="req"><see cref="DescribeCSIPRiskStatisticsRequest"/></param>
        /// <returns><see cref="DescribeCSIPRiskStatisticsResponse"/></returns>
        public DescribeCSIPRiskStatisticsResponse DescribeCSIPRiskStatisticsSync(DescribeCSIPRiskStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeCSIPRiskStatisticsResponse>(req, "DescribeCSIPRiskStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// cvm详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCVMAssetInfoRequest"/></param>
        /// <returns><see cref="DescribeCVMAssetInfoResponse"/></returns>
        public Task<DescribeCVMAssetInfoResponse> DescribeCVMAssetInfo(DescribeCVMAssetInfoRequest req)
        {
            return InternalRequestAsync<DescribeCVMAssetInfoResponse>(req, "DescribeCVMAssetInfo");
        }

        /// <summary>
        /// cvm详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCVMAssetInfoRequest"/></param>
        /// <returns><see cref="DescribeCVMAssetInfoResponse"/></returns>
        public DescribeCVMAssetInfoResponse DescribeCVMAssetInfoSync(DescribeCVMAssetInfoRequest req)
        {
            return InternalRequestAsync<DescribeCVMAssetInfoResponse>(req, "DescribeCVMAssetInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取cvm列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCVMAssetsRequest"/></param>
        /// <returns><see cref="DescribeCVMAssetsResponse"/></returns>
        public Task<DescribeCVMAssetsResponse> DescribeCVMAssets(DescribeCVMAssetsRequest req)
        {
            return InternalRequestAsync<DescribeCVMAssetsResponse>(req, "DescribeCVMAssets");
        }

        /// <summary>
        /// 获取cvm列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCVMAssetsRequest"/></param>
        /// <returns><see cref="DescribeCVMAssetsResponse"/></returns>
        public DescribeCVMAssetsResponse DescribeCVMAssetsSync(DescribeCVMAssetsRequest req)
        {
            return InternalRequestAsync<DescribeCVMAssetsResponse>(req, "DescribeCVMAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 主机详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCWPMachineDetailRequest"/></param>
        /// <returns><see cref="DescribeCWPMachineDetailResponse"/></returns>
        public Task<DescribeCWPMachineDetailResponse> DescribeCWPMachineDetail(DescribeCWPMachineDetailRequest req)
        {
            return InternalRequestAsync<DescribeCWPMachineDetailResponse>(req, "DescribeCWPMachineDetail");
        }

        /// <summary>
        /// 主机详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCWPMachineDetailRequest"/></param>
        /// <returns><see cref="DescribeCWPMachineDetailResponse"/></returns>
        public DescribeCWPMachineDetailResponse DescribeCWPMachineDetailSync(DescribeCWPMachineDetailRequest req)
        {
            return InternalRequestAsync<DescribeCWPMachineDetailResponse>(req, "DescribeCWPMachineDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 主机列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCWPMachinesRequest"/></param>
        /// <returns><see cref="DescribeCWPMachinesResponse"/></returns>
        public Task<DescribeCWPMachinesResponse> DescribeCWPMachines(DescribeCWPMachinesRequest req)
        {
            return InternalRequestAsync<DescribeCWPMachinesResponse>(req, "DescribeCWPMachines");
        }

        /// <summary>
        /// 主机列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCWPMachinesRequest"/></param>
        /// <returns><see cref="DescribeCWPMachinesResponse"/></returns>
        public DescribeCWPMachinesResponse DescribeCWPMachinesSync(DescribeCWPMachinesRequest req)
        {
            return InternalRequestAsync<DescribeCWPMachinesResponse>(req, "DescribeCWPMachines")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取调用记录列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCallRecordRequest"/></param>
        /// <returns><see cref="DescribeCallRecordResponse"/></returns>
        public Task<DescribeCallRecordResponse> DescribeCallRecord(DescribeCallRecordRequest req)
        {
            return InternalRequestAsync<DescribeCallRecordResponse>(req, "DescribeCallRecord");
        }

        /// <summary>
        /// 获取调用记录列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCallRecordRequest"/></param>
        /// <returns><see cref="DescribeCallRecordResponse"/></returns>
        public DescribeCallRecordResponse DescribeCallRecordSync(DescribeCallRecordRequest req)
        {
            return InternalRequestAsync<DescribeCallRecordResponse>(req, "DescribeCallRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 检查视角下云资源配置风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCheckViewRisksRequest"/></param>
        /// <returns><see cref="DescribeCheckViewRisksResponse"/></returns>
        public Task<DescribeCheckViewRisksResponse> DescribeCheckViewRisks(DescribeCheckViewRisksRequest req)
        {
            return InternalRequestAsync<DescribeCheckViewRisksResponse>(req, "DescribeCheckViewRisks");
        }

        /// <summary>
        /// 检查视角下云资源配置风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCheckViewRisksRequest"/></param>
        /// <returns><see cref="DescribeCheckViewRisksResponse"/></returns>
        public DescribeCheckViewRisksResponse DescribeCheckViewRisksSync(DescribeCheckViewRisksRequest req)
        {
            return InternalRequestAsync<DescribeCheckViewRisksResponse>(req, "DescribeCheckViewRisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterAssetsRequest"/></param>
        /// <returns><see cref="DescribeClusterAssetsResponse"/></returns>
        public Task<DescribeClusterAssetsResponse> DescribeClusterAssets(DescribeClusterAssetsRequest req)
        {
            return InternalRequestAsync<DescribeClusterAssetsResponse>(req, "DescribeClusterAssets");
        }

        /// <summary>
        /// 集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterAssetsRequest"/></param>
        /// <returns><see cref="DescribeClusterAssetsResponse"/></returns>
        public DescribeClusterAssetsResponse DescribeClusterAssetsSync(DescribeClusterAssetsRequest req)
        {
            return InternalRequestAsync<DescribeClusterAssetsResponse>(req, "DescribeClusterAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 集群pod列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterPodAssetsRequest"/></param>
        /// <returns><see cref="DescribeClusterPodAssetsResponse"/></returns>
        public Task<DescribeClusterPodAssetsResponse> DescribeClusterPodAssets(DescribeClusterPodAssetsRequest req)
        {
            return InternalRequestAsync<DescribeClusterPodAssetsResponse>(req, "DescribeClusterPodAssets");
        }

        /// <summary>
        /// 集群pod列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterPodAssetsRequest"/></param>
        /// <returns><see cref="DescribeClusterPodAssetsResponse"/></returns>
        public DescribeClusterPodAssetsResponse DescribeClusterPodAssetsSync(DescribeClusterPodAssetsRequest req)
        {
            return InternalRequestAsync<DescribeClusterPodAssetsResponse>(req, "DescribeClusterPodAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云资源配置风险规则列表示例
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigCheckRulesRequest"/></param>
        /// <returns><see cref="DescribeConfigCheckRulesResponse"/></returns>
        public Task<DescribeConfigCheckRulesResponse> DescribeConfigCheckRules(DescribeConfigCheckRulesRequest req)
        {
            return InternalRequestAsync<DescribeConfigCheckRulesResponse>(req, "DescribeConfigCheckRules");
        }

        /// <summary>
        /// 云资源配置风险规则列表示例
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigCheckRulesRequest"/></param>
        /// <returns><see cref="DescribeConfigCheckRulesResponse"/></returns>
        public DescribeConfigCheckRulesResponse DescribeConfigCheckRulesSync(DescribeConfigCheckRulesRequest req)
        {
            return InternalRequestAsync<DescribeConfigCheckRulesResponse>(req, "DescribeConfigCheckRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看cos桶访问权限信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCosAccessPermissionRequest"/></param>
        /// <returns><see cref="DescribeCosAccessPermissionResponse"/></returns>
        public Task<DescribeCosAccessPermissionResponse> DescribeCosAccessPermission(DescribeCosAccessPermissionRequest req)
        {
            return InternalRequestAsync<DescribeCosAccessPermissionResponse>(req, "DescribeCosAccessPermission");
        }

        /// <summary>
        /// 查看cos桶访问权限信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCosAccessPermissionRequest"/></param>
        /// <returns><see cref="DescribeCosAccessPermissionResponse"/></returns>
        public DescribeCosAccessPermissionResponse DescribeCosAccessPermissionSync(DescribeCosAccessPermissionRequest req)
        {
            return InternalRequestAsync<DescribeCosAccessPermissionResponse>(req, "DescribeCosAccessPermission")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看对象存储访问权限列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCosAccessPermissionsRequest"/></param>
        /// <returns><see cref="DescribeCosAccessPermissionsResponse"/></returns>
        public Task<DescribeCosAccessPermissionsResponse> DescribeCosAccessPermissions(DescribeCosAccessPermissionsRequest req)
        {
            return InternalRequestAsync<DescribeCosAccessPermissionsResponse>(req, "DescribeCosAccessPermissions");
        }

        /// <summary>
        /// 查看对象存储访问权限列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCosAccessPermissionsRequest"/></param>
        /// <returns><see cref="DescribeCosAccessPermissionsResponse"/></returns>
        public DescribeCosAccessPermissionsResponse DescribeCosAccessPermissionsSync(DescribeCosAccessPermissionsRequest req)
        {
            return InternalRequestAsync<DescribeCosAccessPermissionsResponse>(req, "DescribeCosAccessPermissions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看COS接口列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCosActionListRequest"/></param>
        /// <returns><see cref="DescribeCosActionListResponse"/></returns>
        public Task<DescribeCosActionListResponse> DescribeCosActionList(DescribeCosActionListRequest req)
        {
            return InternalRequestAsync<DescribeCosActionListResponse>(req, "DescribeCosActionList");
        }

        /// <summary>
        /// 查看COS接口列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCosActionListRequest"/></param>
        /// <returns><see cref="DescribeCosActionListResponse"/></returns>
        public DescribeCosActionListResponse DescribeCosActionListSync(DescribeCosActionListRequest req)
        {
            return InternalRequestAsync<DescribeCosActionListResponse>(req, "DescribeCosActionList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看ak资产列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCosAkAssetRequest"/></param>
        /// <returns><see cref="DescribeCosAkAssetResponse"/></returns>
        public Task<DescribeCosAkAssetResponse> DescribeCosAkAsset(DescribeCosAkAssetRequest req)
        {
            return InternalRequestAsync<DescribeCosAkAssetResponse>(req, "DescribeCosAkAsset");
        }

        /// <summary>
        /// 查看ak资产列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCosAkAssetRequest"/></param>
        /// <returns><see cref="DescribeCosAkAssetResponse"/></returns>
        public DescribeCosAkAssetResponse DescribeCosAkAssetSync(DescribeCosAkAssetRequest req)
        {
            return InternalRequestAsync<DescribeCosAkAssetResponse>(req, "DescribeCosAkAsset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看存储桶调用源ip列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCosAkInvokeIpListRequest"/></param>
        /// <returns><see cref="DescribeCosAkInvokeIpListResponse"/></returns>
        public Task<DescribeCosAkInvokeIpListResponse> DescribeCosAkInvokeIpList(DescribeCosAkInvokeIpListRequest req)
        {
            return InternalRequestAsync<DescribeCosAkInvokeIpListResponse>(req, "DescribeCosAkInvokeIpList");
        }

        /// <summary>
        /// 查看存储桶调用源ip列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCosAkInvokeIpListRequest"/></param>
        /// <returns><see cref="DescribeCosAkInvokeIpListResponse"/></returns>
        public DescribeCosAkInvokeIpListResponse DescribeCosAkInvokeIpListSync(DescribeCosAkInvokeIpListRequest req)
        {
            return InternalRequestAsync<DescribeCosAkInvokeIpListResponse>(req, "DescribeCosAkInvokeIpList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看告警列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCosAlarmListRequest"/></param>
        /// <returns><see cref="DescribeCosAlarmListResponse"/></returns>
        public Task<DescribeCosAlarmListResponse> DescribeCosAlarmList(DescribeCosAlarmListRequest req)
        {
            return InternalRequestAsync<DescribeCosAlarmListResponse>(req, "DescribeCosAlarmList");
        }

        /// <summary>
        /// 查看告警列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCosAlarmListRequest"/></param>
        /// <returns><see cref="DescribeCosAlarmListResponse"/></returns>
        public DescribeCosAlarmListResponse DescribeCosAlarmListSync(DescribeCosAlarmListRequest req)
        {
            return InternalRequestAsync<DescribeCosAlarmListResponse>(req, "DescribeCosAlarmList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 每日告警新增数据
        /// </summary>
        /// <param name="req"><see cref="DescribeCosAlarmTrendDataRequest"/></param>
        /// <returns><see cref="DescribeCosAlarmTrendDataResponse"/></returns>
        public Task<DescribeCosAlarmTrendDataResponse> DescribeCosAlarmTrendData(DescribeCosAlarmTrendDataRequest req)
        {
            return InternalRequestAsync<DescribeCosAlarmTrendDataResponse>(req, "DescribeCosAlarmTrendData");
        }

        /// <summary>
        /// 每日告警新增数据
        /// </summary>
        /// <param name="req"><see cref="DescribeCosAlarmTrendDataRequest"/></param>
        /// <returns><see cref="DescribeCosAlarmTrendDataResponse"/></returns>
        public DescribeCosAlarmTrendDataResponse DescribeCosAlarmTrendDataSync(DescribeCosAlarmTrendDataRequest req)
        {
            return InternalRequestAsync<DescribeCosAlarmTrendDataResponse>(req, "DescribeCosAlarmTrendData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看cos资产列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCosAssetRequest"/></param>
        /// <returns><see cref="DescribeCosAssetResponse"/></returns>
        public Task<DescribeCosAssetResponse> DescribeCosAsset(DescribeCosAssetRequest req)
        {
            return InternalRequestAsync<DescribeCosAssetResponse>(req, "DescribeCosAsset");
        }

        /// <summary>
        /// 查看cos资产列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCosAssetRequest"/></param>
        /// <returns><see cref="DescribeCosAssetResponse"/></returns>
        public DescribeCosAssetResponse DescribeCosAssetSync(DescribeCosAssetRequest req)
        {
            return InternalRequestAsync<DescribeCosAssetResponse>(req, "DescribeCosAsset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取对应appid对应的当前正在扫描的taskid
        /// </summary>
        /// <param name="req"><see cref="DescribeCosAssetSyncTaskRequest"/></param>
        /// <returns><see cref="DescribeCosAssetSyncTaskResponse"/></returns>
        public Task<DescribeCosAssetSyncTaskResponse> DescribeCosAssetSyncTask(DescribeCosAssetSyncTaskRequest req)
        {
            return InternalRequestAsync<DescribeCosAssetSyncTaskResponse>(req, "DescribeCosAssetSyncTask");
        }

        /// <summary>
        /// 获取对应appid对应的当前正在扫描的taskid
        /// </summary>
        /// <param name="req"><see cref="DescribeCosAssetSyncTaskRequest"/></param>
        /// <returns><see cref="DescribeCosAssetSyncTaskResponse"/></returns>
        public DescribeCosAssetSyncTaskResponse DescribeCosAssetSyncTaskSync(DescribeCosAssetSyncTaskRequest req)
        {
            return InternalRequestAsync<DescribeCosAssetSyncTaskResponse>(req, "DescribeCosAssetSyncTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看该appid下已购买的appid集合
        /// </summary>
        /// <param name="req"><see cref="DescribeCosAuditAppIdListRequest"/></param>
        /// <returns><see cref="DescribeCosAuditAppIdListResponse"/></returns>
        public Task<DescribeCosAuditAppIdListResponse> DescribeCosAuditAppIdList(DescribeCosAuditAppIdListRequest req)
        {
            return InternalRequestAsync<DescribeCosAuditAppIdListResponse>(req, "DescribeCosAuditAppIdList");
        }

        /// <summary>
        /// 查看该appid下已购买的appid集合
        /// </summary>
        /// <param name="req"><see cref="DescribeCosAuditAppIdListRequest"/></param>
        /// <returns><see cref="DescribeCosAuditAppIdListResponse"/></returns>
        public DescribeCosAuditAppIdListResponse DescribeCosAuditAppIdListSync(DescribeCosAuditAppIdListRequest req)
        {
            return InternalRequestAsync<DescribeCosAuditAppIdListResponse>(req, "DescribeCosAuditAppIdList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询cos审计字典信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCosAuditDictionaryListRequest"/></param>
        /// <returns><see cref="DescribeCosAuditDictionaryListResponse"/></returns>
        public Task<DescribeCosAuditDictionaryListResponse> DescribeCosAuditDictionaryList(DescribeCosAuditDictionaryListRequest req)
        {
            return InternalRequestAsync<DescribeCosAuditDictionaryListResponse>(req, "DescribeCosAuditDictionaryList");
        }

        /// <summary>
        /// 查询cos审计字典信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCosAuditDictionaryListRequest"/></param>
        /// <returns><see cref="DescribeCosAuditDictionaryListResponse"/></returns>
        public DescribeCosAuditDictionaryListResponse DescribeCosAuditDictionaryListSync(DescribeCosAuditDictionaryListRequest req)
        {
            return InternalRequestAsync<DescribeCosAuditDictionaryListResponse>(req, "DescribeCosAuditDictionaryList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取审计支付信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCosAuditPayInfoRequest"/></param>
        /// <returns><see cref="DescribeCosAuditPayInfoResponse"/></returns>
        public Task<DescribeCosAuditPayInfoResponse> DescribeCosAuditPayInfo(DescribeCosAuditPayInfoRequest req)
        {
            return InternalRequestAsync<DescribeCosAuditPayInfoResponse>(req, "DescribeCosAuditPayInfo");
        }

        /// <summary>
        /// 获取审计支付信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCosAuditPayInfoRequest"/></param>
        /// <returns><see cref="DescribeCosAuditPayInfoResponse"/></returns>
        public DescribeCosAuditPayInfoResponse DescribeCosAuditPayInfoSync(DescribeCosAuditPayInfoRequest req)
        {
            return InternalRequestAsync<DescribeCosAuditPayInfoResponse>(req, "DescribeCosAuditPayInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取存储桶计费信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCosBucketBillingInfoRequest"/></param>
        /// <returns><see cref="DescribeCosBucketBillingInfoResponse"/></returns>
        public Task<DescribeCosBucketBillingInfoResponse> DescribeCosBucketBillingInfo(DescribeCosBucketBillingInfoRequest req)
        {
            return InternalRequestAsync<DescribeCosBucketBillingInfoResponse>(req, "DescribeCosBucketBillingInfo");
        }

        /// <summary>
        /// 获取存储桶计费信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCosBucketBillingInfoRequest"/></param>
        /// <returns><see cref="DescribeCosBucketBillingInfoResponse"/></returns>
        public DescribeCosBucketBillingInfoResponse DescribeCosBucketBillingInfoSync(DescribeCosBucketBillingInfoRequest req)
        {
            return InternalRequestAsync<DescribeCosBucketBillingInfoResponse>(req, "DescribeCosBucketBillingInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取存储桶信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCosBucketListRequest"/></param>
        /// <returns><see cref="DescribeCosBucketListResponse"/></returns>
        public Task<DescribeCosBucketListResponse> DescribeCosBucketList(DescribeCosBucketListRequest req)
        {
            return InternalRequestAsync<DescribeCosBucketListResponse>(req, "DescribeCosBucketList");
        }

        /// <summary>
        /// 获取存储桶信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCosBucketListRequest"/></param>
        /// <returns><see cref="DescribeCosBucketListResponse"/></returns>
        public DescribeCosBucketListResponse DescribeCosBucketListSync(DescribeCosBucketListRequest req)
        {
            return InternalRequestAsync<DescribeCosBucketListResponse>(req, "DescribeCosBucketList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看风险资产视角
        /// </summary>
        /// <param name="req"><see cref="DescribeCosBucketRiskRequest"/></param>
        /// <returns><see cref="DescribeCosBucketRiskResponse"/></returns>
        public Task<DescribeCosBucketRiskResponse> DescribeCosBucketRisk(DescribeCosBucketRiskRequest req)
        {
            return InternalRequestAsync<DescribeCosBucketRiskResponse>(req, "DescribeCosBucketRisk");
        }

        /// <summary>
        /// 查看风险资产视角
        /// </summary>
        /// <param name="req"><see cref="DescribeCosBucketRiskRequest"/></param>
        /// <returns><see cref="DescribeCosBucketRiskResponse"/></returns>
        public DescribeCosBucketRiskResponse DescribeCosBucketRiskSync(DescribeCosBucketRiskRequest req)
        {
            return InternalRequestAsync<DescribeCosBucketRiskResponse>(req, "DescribeCosBucketRisk")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询cos文件数据识别结果列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCosIdentifyFileListRequest"/></param>
        /// <returns><see cref="DescribeCosIdentifyFileListResponse"/></returns>
        public Task<DescribeCosIdentifyFileListResponse> DescribeCosIdentifyFileList(DescribeCosIdentifyFileListRequest req)
        {
            return InternalRequestAsync<DescribeCosIdentifyFileListResponse>(req, "DescribeCosIdentifyFileList");
        }

        /// <summary>
        /// 查询cos文件数据识别结果列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCosIdentifyFileListRequest"/></param>
        /// <returns><see cref="DescribeCosIdentifyFileListResponse"/></returns>
        public DescribeCosIdentifyFileListResponse DescribeCosIdentifyFileListSync(DescribeCosIdentifyFileListRequest req)
        {
            return InternalRequestAsync<DescribeCosIdentifyFileListResponse>(req, "DescribeCosIdentifyFileList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看调用记录关联的文件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCosInvokeUaRequest"/></param>
        /// <returns><see cref="DescribeCosInvokeUaResponse"/></returns>
        public Task<DescribeCosInvokeUaResponse> DescribeCosInvokeUa(DescribeCosInvokeUaRequest req)
        {
            return InternalRequestAsync<DescribeCosInvokeUaResponse>(req, "DescribeCosInvokeUa");
        }

        /// <summary>
        /// 查看调用记录关联的文件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCosInvokeUaRequest"/></param>
        /// <returns><see cref="DescribeCosInvokeUaResponse"/></returns>
        public DescribeCosInvokeUaResponse DescribeCosInvokeUaSync(DescribeCosInvokeUaRequest req)
        {
            return InternalRequestAsync<DescribeCosInvokeUaResponse>(req, "DescribeCosInvokeUa")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看cos调用日志
        /// </summary>
        /// <param name="req"><see cref="DescribeCosIpInvokeLogRequest"/></param>
        /// <returns><see cref="DescribeCosIpInvokeLogResponse"/></returns>
        public Task<DescribeCosIpInvokeLogResponse> DescribeCosIpInvokeLog(DescribeCosIpInvokeLogRequest req)
        {
            return InternalRequestAsync<DescribeCosIpInvokeLogResponse>(req, "DescribeCosIpInvokeLog");
        }

        /// <summary>
        /// 查看cos调用日志
        /// </summary>
        /// <param name="req"><see cref="DescribeCosIpInvokeLogRequest"/></param>
        /// <returns><see cref="DescribeCosIpInvokeLogResponse"/></returns>
        public DescribeCosIpInvokeLogResponse DescribeCosIpInvokeLogSync(DescribeCosIpInvokeLogRequest req)
        {
            return InternalRequestAsync<DescribeCosIpInvokeLogResponse>(req, "DescribeCosIpInvokeLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看调用记录关联的文件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCosIpInvokeRecordFileRequest"/></param>
        /// <returns><see cref="DescribeCosIpInvokeRecordFileResponse"/></returns>
        public Task<DescribeCosIpInvokeRecordFileResponse> DescribeCosIpInvokeRecordFile(DescribeCosIpInvokeRecordFileRequest req)
        {
            return InternalRequestAsync<DescribeCosIpInvokeRecordFileResponse>(req, "DescribeCosIpInvokeRecordFile");
        }

        /// <summary>
        /// 查看调用记录关联的文件信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCosIpInvokeRecordFileRequest"/></param>
        /// <returns><see cref="DescribeCosIpInvokeRecordFileResponse"/></returns>
        public DescribeCosIpInvokeRecordFileResponse DescribeCosIpInvokeRecordFileSync(DescribeCosIpInvokeRecordFileRequest req)
        {
            return InternalRequestAsync<DescribeCosIpInvokeRecordFileResponse>(req, "DescribeCosIpInvokeRecordFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询cos风险文件扫描任务
        /// </summary>
        /// <param name="req"><see cref="DescribeCosObjectScanTaskRequest"/></param>
        /// <returns><see cref="DescribeCosObjectScanTaskResponse"/></returns>
        public Task<DescribeCosObjectScanTaskResponse> DescribeCosObjectScanTask(DescribeCosObjectScanTaskRequest req)
        {
            return InternalRequestAsync<DescribeCosObjectScanTaskResponse>(req, "DescribeCosObjectScanTask");
        }

        /// <summary>
        /// 查询cos风险文件扫描任务
        /// </summary>
        /// <param name="req"><see cref="DescribeCosObjectScanTaskRequest"/></param>
        /// <returns><see cref="DescribeCosObjectScanTaskResponse"/></returns>
        public DescribeCosObjectScanTaskResponse DescribeCosObjectScanTaskSync(DescribeCosObjectScanTaskRequest req)
        {
            return InternalRequestAsync<DescribeCosObjectScanTaskResponse>(req, "DescribeCosObjectScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// cos概览信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCosOverviewRequest"/></param>
        /// <returns><see cref="DescribeCosOverviewResponse"/></returns>
        public Task<DescribeCosOverviewResponse> DescribeCosOverview(DescribeCosOverviewRequest req)
        {
            return InternalRequestAsync<DescribeCosOverviewResponse>(req, "DescribeCosOverview");
        }

        /// <summary>
        /// cos概览信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCosOverviewRequest"/></param>
        /// <returns><see cref="DescribeCosOverviewResponse"/></returns>
        public DescribeCosOverviewResponse DescribeCosOverviewSync(DescribeCosOverviewRequest req)
        {
            return InternalRequestAsync<DescribeCosOverviewResponse>(req, "DescribeCosOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取策略列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCosPolicyRequest"/></param>
        /// <returns><see cref="DescribeCosPolicyResponse"/></returns>
        public Task<DescribeCosPolicyResponse> DescribeCosPolicy(DescribeCosPolicyRequest req)
        {
            return InternalRequestAsync<DescribeCosPolicyResponse>(req, "DescribeCosPolicy");
        }

        /// <summary>
        /// 获取策略列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCosPolicyRequest"/></param>
        /// <returns><see cref="DescribeCosPolicyResponse"/></returns>
        public DescribeCosPolicyResponse DescribeCosPolicySync(DescribeCosPolicyRequest req)
        {
            return InternalRequestAsync<DescribeCosPolicyResponse>(req, "DescribeCosPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 风险接口列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCosRiskActionListRequest"/></param>
        /// <returns><see cref="DescribeCosRiskActionListResponse"/></returns>
        public Task<DescribeCosRiskActionListResponse> DescribeCosRiskActionList(DescribeCosRiskActionListRequest req)
        {
            return InternalRequestAsync<DescribeCosRiskActionListResponse>(req, "DescribeCosRiskActionList");
        }

        /// <summary>
        /// 风险接口列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCosRiskActionListRequest"/></param>
        /// <returns><see cref="DescribeCosRiskActionListResponse"/></returns>
        public DescribeCosRiskActionListResponse DescribeCosRiskActionListSync(DescribeCosRiskActionListRequest req)
        {
            return InternalRequestAsync<DescribeCosRiskActionListResponse>(req, "DescribeCosRiskActionList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看风险证据以及描述
        /// </summary>
        /// <param name="req"><see cref="DescribeCosRiskEvidenceRequest"/></param>
        /// <returns><see cref="DescribeCosRiskEvidenceResponse"/></returns>
        public Task<DescribeCosRiskEvidenceResponse> DescribeCosRiskEvidence(DescribeCosRiskEvidenceRequest req)
        {
            return InternalRequestAsync<DescribeCosRiskEvidenceResponse>(req, "DescribeCosRiskEvidence");
        }

        /// <summary>
        /// 查看风险证据以及描述
        /// </summary>
        /// <param name="req"><see cref="DescribeCosRiskEvidenceRequest"/></param>
        /// <returns><see cref="DescribeCosRiskEvidenceResponse"/></returns>
        public DescribeCosRiskEvidenceResponse DescribeCosRiskEvidenceSync(DescribeCosRiskEvidenceRequest req)
        {
            return InternalRequestAsync<DescribeCosRiskEvidenceResponse>(req, "DescribeCosRiskEvidence")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看存储桶扫描任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCosRiskScanTaskRequest"/></param>
        /// <returns><see cref="DescribeCosRiskScanTaskResponse"/></returns>
        public Task<DescribeCosRiskScanTaskResponse> DescribeCosRiskScanTask(DescribeCosRiskScanTaskRequest req)
        {
            return InternalRequestAsync<DescribeCosRiskScanTaskResponse>(req, "DescribeCosRiskScanTask");
        }

        /// <summary>
        /// 查看存储桶扫描任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCosRiskScanTaskRequest"/></param>
        /// <returns><see cref="DescribeCosRiskScanTaskResponse"/></returns>
        public DescribeCosRiskScanTaskResponse DescribeCosRiskScanTaskSync(DescribeCosRiskScanTaskRequest req)
        {
            return InternalRequestAsync<DescribeCosRiskScanTaskResponse>(req, "DescribeCosRiskScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看cos桶访问权限信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCosRoleAccessPermissionRequest"/></param>
        /// <returns><see cref="DescribeCosRoleAccessPermissionResponse"/></returns>
        public Task<DescribeCosRoleAccessPermissionResponse> DescribeCosRoleAccessPermission(DescribeCosRoleAccessPermissionRequest req)
        {
            return InternalRequestAsync<DescribeCosRoleAccessPermissionResponse>(req, "DescribeCosRoleAccessPermission");
        }

        /// <summary>
        /// 查看cos桶访问权限信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCosRoleAccessPermissionRequest"/></param>
        /// <returns><see cref="DescribeCosRoleAccessPermissionResponse"/></returns>
        public DescribeCosRoleAccessPermissionResponse DescribeCosRoleAccessPermissionSync(DescribeCosRoleAccessPermissionRequest req)
        {
            return InternalRequestAsync<DescribeCosRoleAccessPermissionResponse>(req, "DescribeCosRoleAccessPermission")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取存储桶角色权限列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCosRoleAccessPermissionsRequest"/></param>
        /// <returns><see cref="DescribeCosRoleAccessPermissionsResponse"/></returns>
        public Task<DescribeCosRoleAccessPermissionsResponse> DescribeCosRoleAccessPermissions(DescribeCosRoleAccessPermissionsRequest req)
        {
            return InternalRequestAsync<DescribeCosRoleAccessPermissionsResponse>(req, "DescribeCosRoleAccessPermissions");
        }

        /// <summary>
        /// 获取存储桶角色权限列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCosRoleAccessPermissionsRequest"/></param>
        /// <returns><see cref="DescribeCosRoleAccessPermissionsResponse"/></returns>
        public DescribeCosRoleAccessPermissionsResponse DescribeCosRoleAccessPermissionsSync(DescribeCosRoleAccessPermissionsRequest req)
        {
            return InternalRequestAsync<DescribeCosRoleAccessPermissionsResponse>(req, "DescribeCosRoleAccessPermissions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 调用源ip列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCosSourceIpRequest"/></param>
        /// <returns><see cref="DescribeCosSourceIpResponse"/></returns>
        public Task<DescribeCosSourceIpResponse> DescribeCosSourceIp(DescribeCosSourceIpRequest req)
        {
            return InternalRequestAsync<DescribeCosSourceIpResponse>(req, "DescribeCosSourceIp");
        }

        /// <summary>
        /// 调用源ip列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCosSourceIpRequest"/></param>
        /// <returns><see cref="DescribeCosSourceIpResponse"/></returns>
        public DescribeCosSourceIpResponse DescribeCosSourceIpSync(DescribeCosSourceIpRequest req)
        {
            return InternalRequestAsync<DescribeCosSourceIpResponse>(req, "DescribeCosSourceIp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// db资产详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDbAssetInfoRequest"/></param>
        /// <returns><see cref="DescribeDbAssetInfoResponse"/></returns>
        public Task<DescribeDbAssetInfoResponse> DescribeDbAssetInfo(DescribeDbAssetInfoRequest req)
        {
            return InternalRequestAsync<DescribeDbAssetInfoResponse>(req, "DescribeDbAssetInfo");
        }

        /// <summary>
        /// db资产详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDbAssetInfoRequest"/></param>
        /// <returns><see cref="DescribeDbAssetInfoResponse"/></returns>
        public DescribeDbAssetInfoResponse DescribeDbAssetInfoSync(DescribeDbAssetInfoRequest req)
        {
            return InternalRequestAsync<DescribeDbAssetInfoResponse>(req, "DescribeDbAssetInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 数据库资产列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDbAssetsRequest"/></param>
        /// <returns><see cref="DescribeDbAssetsResponse"/></returns>
        public Task<DescribeDbAssetsResponse> DescribeDbAssets(DescribeDbAssetsRequest req)
        {
            return InternalRequestAsync<DescribeDbAssetsResponse>(req, "DescribeDbAssets");
        }

        /// <summary>
        /// 数据库资产列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDbAssetsRequest"/></param>
        /// <returns><see cref="DescribeDbAssetsResponse"/></returns>
        public DescribeDbAssetsResponse DescribeDbAssetsSync(DescribeDbAssetsRequest req)
        {
            return InternalRequestAsync<DescribeDbAssetsResponse>(req, "DescribeDbAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 域名列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainAssetsRequest"/></param>
        /// <returns><see cref="DescribeDomainAssetsResponse"/></returns>
        public Task<DescribeDomainAssetsResponse> DescribeDomainAssets(DescribeDomainAssetsRequest req)
        {
            return InternalRequestAsync<DescribeDomainAssetsResponse>(req, "DescribeDomainAssets");
        }

        /// <summary>
        /// 域名列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainAssetsRequest"/></param>
        /// <returns><see cref="DescribeDomainAssetsResponse"/></returns>
        public DescribeDomainAssetsResponse DescribeDomainAssetsSync(DescribeDomainAssetsRequest req)
        {
            return InternalRequestAsync<DescribeDomainAssetsResponse>(req, "DescribeDomainAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Dspm访问记录
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAccessRecordRequest"/></param>
        /// <returns><see cref="DescribeDspmAccessRecordResponse"/></returns>
        public Task<DescribeDspmAccessRecordResponse> DescribeDspmAccessRecord(DescribeDspmAccessRecordRequest req)
        {
            return InternalRequestAsync<DescribeDspmAccessRecordResponse>(req, "DescribeDspmAccessRecord");
        }

        /// <summary>
        /// 查询Dspm访问记录
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAccessRecordRequest"/></param>
        /// <returns><see cref="DescribeDspmAccessRecordResponse"/></returns>
        public DescribeDspmAccessRecordResponse DescribeDspmAccessRecordSync(DescribeDspmAccessRecordRequest req)
        {
            return InternalRequestAsync<DescribeDspmAccessRecordResponse>(req, "DescribeDspmAccessRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Dspm访问拓扑账号列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAccessTopologyAccountsRequest"/></param>
        /// <returns><see cref="DescribeDspmAccessTopologyAccountsResponse"/></returns>
        public Task<DescribeDspmAccessTopologyAccountsResponse> DescribeDspmAccessTopologyAccounts(DescribeDspmAccessTopologyAccountsRequest req)
        {
            return InternalRequestAsync<DescribeDspmAccessTopologyAccountsResponse>(req, "DescribeDspmAccessTopologyAccounts");
        }

        /// <summary>
        /// 查询Dspm访问拓扑账号列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAccessTopologyAccountsRequest"/></param>
        /// <returns><see cref="DescribeDspmAccessTopologyAccountsResponse"/></returns>
        public DescribeDspmAccessTopologyAccountsResponse DescribeDspmAccessTopologyAccountsSync(DescribeDspmAccessTopologyAccountsRequest req)
        {
            return InternalRequestAsync<DescribeDspmAccessTopologyAccountsResponse>(req, "DescribeDspmAccessTopologyAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Dspm访问拓扑资产列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAccessTopologyAssetsRequest"/></param>
        /// <returns><see cref="DescribeDspmAccessTopologyAssetsResponse"/></returns>
        public Task<DescribeDspmAccessTopologyAssetsResponse> DescribeDspmAccessTopologyAssets(DescribeDspmAccessTopologyAssetsRequest req)
        {
            return InternalRequestAsync<DescribeDspmAccessTopologyAssetsResponse>(req, "DescribeDspmAccessTopologyAssets");
        }

        /// <summary>
        /// 查询Dspm访问拓扑资产列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAccessTopologyAssetsRequest"/></param>
        /// <returns><see cref="DescribeDspmAccessTopologyAssetsResponse"/></returns>
        public DescribeDspmAccessTopologyAssetsResponse DescribeDspmAccessTopologyAssetsSync(DescribeDspmAccessTopologyAssetsRequest req)
        {
            return InternalRequestAsync<DescribeDspmAccessTopologyAssetsResponse>(req, "DescribeDspmAccessTopologyAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Dspm访问拓扑ip列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAccessTopologyIpsRequest"/></param>
        /// <returns><see cref="DescribeDspmAccessTopologyIpsResponse"/></returns>
        public Task<DescribeDspmAccessTopologyIpsResponse> DescribeDspmAccessTopologyIps(DescribeDspmAccessTopologyIpsRequest req)
        {
            return InternalRequestAsync<DescribeDspmAccessTopologyIpsResponse>(req, "DescribeDspmAccessTopologyIps");
        }

        /// <summary>
        /// 查询Dspm访问拓扑ip列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAccessTopologyIpsRequest"/></param>
        /// <returns><see cref="DescribeDspmAccessTopologyIpsResponse"/></returns>
        public DescribeDspmAccessTopologyIpsResponse DescribeDspmAccessTopologyIpsSync(DescribeDspmAccessTopologyIpsRequest req)
        {
            return InternalRequestAsync<DescribeDspmAccessTopologyIpsResponse>(req, "DescribeDspmAccessTopologyIps")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Dspm申请历史
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmApplyHistoryRequest"/></param>
        /// <returns><see cref="DescribeDspmApplyHistoryResponse"/></returns>
        public Task<DescribeDspmApplyHistoryResponse> DescribeDspmApplyHistory(DescribeDspmApplyHistoryRequest req)
        {
            return InternalRequestAsync<DescribeDspmApplyHistoryResponse>(req, "DescribeDspmApplyHistory");
        }

        /// <summary>
        /// 查询Dspm申请历史
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmApplyHistoryRequest"/></param>
        /// <returns><see cref="DescribeDspmApplyHistoryResponse"/></returns>
        public DescribeDspmApplyHistoryResponse DescribeDspmApplyHistorySync(DescribeDspmApplyHistoryRequest req)
        {
            return InternalRequestAsync<DescribeDspmApplyHistoryResponse>(req, "DescribeDspmApplyHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Dspm申请单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmApplyOrderListRequest"/></param>
        /// <returns><see cref="DescribeDspmApplyOrderListResponse"/></returns>
        public Task<DescribeDspmApplyOrderListResponse> DescribeDspmApplyOrderList(DescribeDspmApplyOrderListRequest req)
        {
            return InternalRequestAsync<DescribeDspmApplyOrderListResponse>(req, "DescribeDspmApplyOrderList");
        }

        /// <summary>
        /// 查询Dspm申请单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmApplyOrderListRequest"/></param>
        /// <returns><see cref="DescribeDspmApplyOrderListResponse"/></returns>
        public DescribeDspmApplyOrderListResponse DescribeDspmApplyOrderListSync(DescribeDspmApplyOrderListRequest req)
        {
            return InternalRequestAsync<DescribeDspmApplyOrderListResponse>(req, "DescribeDspmApplyOrderList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Dspm审批历史
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmApproveHistoryRequest"/></param>
        /// <returns><see cref="DescribeDspmApproveHistoryResponse"/></returns>
        public Task<DescribeDspmApproveHistoryResponse> DescribeDspmApproveHistory(DescribeDspmApproveHistoryRequest req)
        {
            return InternalRequestAsync<DescribeDspmApproveHistoryResponse>(req, "DescribeDspmApproveHistory");
        }

        /// <summary>
        /// 查询Dspm审批历史
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmApproveHistoryRequest"/></param>
        /// <returns><see cref="DescribeDspmApproveHistoryResponse"/></returns>
        public DescribeDspmApproveHistoryResponse DescribeDspmApproveHistorySync(DescribeDspmApproveHistoryRequest req)
        {
            return InternalRequestAsync<DescribeDspmApproveHistoryResponse>(req, "DescribeDspmApproveHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Dspm审批单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmApproveOrderListRequest"/></param>
        /// <returns><see cref="DescribeDspmApproveOrderListResponse"/></returns>
        public Task<DescribeDspmApproveOrderListResponse> DescribeDspmApproveOrderList(DescribeDspmApproveOrderListRequest req)
        {
            return InternalRequestAsync<DescribeDspmApproveOrderListResponse>(req, "DescribeDspmApproveOrderList");
        }

        /// <summary>
        /// 查询Dspm审批单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmApproveOrderListRequest"/></param>
        /// <returns><see cref="DescribeDspmApproveOrderListResponse"/></returns>
        public DescribeDspmApproveOrderListResponse DescribeDspmApproveOrderListSync(DescribeDspmApproveOrderListRequest req)
        {
            return InternalRequestAsync<DescribeDspmApproveOrderListResponse>(req, "DescribeDspmApproveOrderList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Dspm资产访问拓扑
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetAccessTopologyRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetAccessTopologyResponse"/></returns>
        public Task<DescribeDspmAssetAccessTopologyResponse> DescribeDspmAssetAccessTopology(DescribeDspmAssetAccessTopologyRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetAccessTopologyResponse>(req, "DescribeDspmAssetAccessTopology");
        }

        /// <summary>
        /// 查询Dspm资产访问拓扑
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetAccessTopologyRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetAccessTopologyResponse"/></returns>
        public DescribeDspmAssetAccessTopologyResponse DescribeDspmAssetAccessTopologySync(DescribeDspmAssetAccessTopologyRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetAccessTopologyResponse>(req, "DescribeDspmAssetAccessTopology")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Dspm资产账号身份信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetAccountIdentifyRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetAccountIdentifyResponse"/></returns>
        public Task<DescribeDspmAssetAccountIdentifyResponse> DescribeDspmAssetAccountIdentify(DescribeDspmAssetAccountIdentifyRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetAccountIdentifyResponse>(req, "DescribeDspmAssetAccountIdentify");
        }

        /// <summary>
        /// 查询Dspm资产账号身份信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetAccountIdentifyRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetAccountIdentifyResponse"/></returns>
        public DescribeDspmAssetAccountIdentifyResponse DescribeDspmAssetAccountIdentifySync(DescribeDspmAssetAccountIdentifyRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetAccountIdentifyResponse>(req, "DescribeDspmAssetAccountIdentify")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Dspm资产账号预设特权信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetAccountPresetPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetAccountPresetPrivilegesResponse"/></returns>
        public Task<DescribeDspmAssetAccountPresetPrivilegesResponse> DescribeDspmAssetAccountPresetPrivileges(DescribeDspmAssetAccountPresetPrivilegesRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetAccountPresetPrivilegesResponse>(req, "DescribeDspmAssetAccountPresetPrivileges");
        }

        /// <summary>
        /// 查询Dspm资产账号预设特权信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetAccountPresetPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetAccountPresetPrivilegesResponse"/></returns>
        public DescribeDspmAssetAccountPresetPrivilegesResponse DescribeDspmAssetAccountPresetPrivilegesSync(DescribeDspmAssetAccountPresetPrivilegesRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetAccountPresetPrivilegesResponse>(req, "DescribeDspmAssetAccountPresetPrivileges")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Dspm资产账号回收后特权信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetAccountRecycledPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetAccountRecycledPrivilegesResponse"/></returns>
        public Task<DescribeDspmAssetAccountRecycledPrivilegesResponse> DescribeDspmAssetAccountRecycledPrivileges(DescribeDspmAssetAccountRecycledPrivilegesRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetAccountRecycledPrivilegesResponse>(req, "DescribeDspmAssetAccountRecycledPrivileges");
        }

        /// <summary>
        /// 查询Dspm资产账号回收后特权信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetAccountRecycledPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetAccountRecycledPrivilegesResponse"/></returns>
        public DescribeDspmAssetAccountRecycledPrivilegesResponse DescribeDspmAssetAccountRecycledPrivilegesSync(DescribeDspmAssetAccountRecycledPrivilegesRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetAccountRecycledPrivilegesResponse>(req, "DescribeDspmAssetAccountRecycledPrivileges")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Dspm资产账号列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetAccountsRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetAccountsResponse"/></returns>
        public Task<DescribeDspmAssetAccountsResponse> DescribeDspmAssetAccounts(DescribeDspmAssetAccountsRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetAccountsResponse>(req, "DescribeDspmAssetAccounts");
        }

        /// <summary>
        /// 查询Dspm资产账号列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetAccountsRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetAccountsResponse"/></returns>
        public DescribeDspmAssetAccountsResponse DescribeDspmAssetAccountsSync(DescribeDspmAssetAccountsRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetAccountsResponse>(req, "DescribeDspmAssetAccounts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询资产数据库信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetDatabaseListRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetDatabaseListResponse"/></returns>
        public Task<DescribeDspmAssetDatabaseListResponse> DescribeDspmAssetDatabaseList(DescribeDspmAssetDatabaseListRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetDatabaseListResponse>(req, "DescribeDspmAssetDatabaseList");
        }

        /// <summary>
        /// 查询资产数据库信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetDatabaseListRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetDatabaseListResponse"/></returns>
        public DescribeDspmAssetDatabaseListResponse DescribeDspmAssetDatabaseListSync(DescribeDspmAssetDatabaseListRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetDatabaseListResponse>(req, "DescribeDspmAssetDatabaseList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Dspm资产数据库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetDatabasesRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetDatabasesResponse"/></returns>
        public Task<DescribeDspmAssetDatabasesResponse> DescribeDspmAssetDatabases(DescribeDspmAssetDatabasesRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetDatabasesResponse>(req, "DescribeDspmAssetDatabases");
        }

        /// <summary>
        /// 查询Dspm资产数据库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetDatabasesRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetDatabasesResponse"/></returns>
        public DescribeDspmAssetDatabasesResponse DescribeDspmAssetDatabasesSync(DescribeDspmAssetDatabasesRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetDatabasesResponse>(req, "DescribeDspmAssetDatabases")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询dspm资产字段信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetFieldListRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetFieldListResponse"/></returns>
        public Task<DescribeDspmAssetFieldListResponse> DescribeDspmAssetFieldList(DescribeDspmAssetFieldListRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetFieldListResponse>(req, "DescribeDspmAssetFieldList");
        }

        /// <summary>
        /// 查询dspm资产字段信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetFieldListRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetFieldListResponse"/></returns>
        public DescribeDspmAssetFieldListResponse DescribeDspmAssetFieldListSync(DescribeDspmAssetFieldListRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetFieldListResponse>(req, "DescribeDspmAssetFieldList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询dspm资产字段样本值
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetFieldSamplesRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetFieldSamplesResponse"/></returns>
        public Task<DescribeDspmAssetFieldSamplesResponse> DescribeDspmAssetFieldSamples(DescribeDspmAssetFieldSamplesRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetFieldSamplesResponse>(req, "DescribeDspmAssetFieldSamples");
        }

        /// <summary>
        /// 查询dspm资产字段样本值
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetFieldSamplesRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetFieldSamplesResponse"/></returns>
        public DescribeDspmAssetFieldSamplesResponse DescribeDspmAssetFieldSamplesSync(DescribeDspmAssetFieldSamplesRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetFieldSamplesResponse>(req, "DescribeDspmAssetFieldSamples")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询dspm资产数据识别信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetIdentifyInfoListRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetIdentifyInfoListResponse"/></returns>
        public Task<DescribeDspmAssetIdentifyInfoListResponse> DescribeDspmAssetIdentifyInfoList(DescribeDspmAssetIdentifyInfoListRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetIdentifyInfoListResponse>(req, "DescribeDspmAssetIdentifyInfoList");
        }

        /// <summary>
        /// 查询dspm资产数据识别信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetIdentifyInfoListRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetIdentifyInfoListResponse"/></returns>
        public DescribeDspmAssetIdentifyInfoListResponse DescribeDspmAssetIdentifyInfoListSync(DescribeDspmAssetIdentifyInfoListRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetIdentifyInfoListResponse>(req, "DescribeDspmAssetIdentifyInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Dspm资产id列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetIdsRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetIdsResponse"/></returns>
        public Task<DescribeDspmAssetIdsResponse> DescribeDspmAssetIds(DescribeDspmAssetIdsRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetIdsResponse>(req, "DescribeDspmAssetIds");
        }

        /// <summary>
        /// 查询Dspm资产id列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetIdsRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetIdsResponse"/></returns>
        public DescribeDspmAssetIdsResponse DescribeDspmAssetIdsSync(DescribeDspmAssetIdsRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetIdsResponse>(req, "DescribeDspmAssetIds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Dspm资产登录凭据
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetLoginCredentialRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetLoginCredentialResponse"/></returns>
        public Task<DescribeDspmAssetLoginCredentialResponse> DescribeDspmAssetLoginCredential(DescribeDspmAssetLoginCredentialRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetLoginCredentialResponse>(req, "DescribeDspmAssetLoginCredential");
        }

        /// <summary>
        /// 查询Dspm资产登录凭据
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetLoginCredentialRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetLoginCredentialResponse"/></returns>
        public DescribeDspmAssetLoginCredentialResponse DescribeDspmAssetLoginCredentialSync(DescribeDspmAssetLoginCredentialRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetLoginCredentialResponse>(req, "DescribeDspmAssetLoginCredential")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Dspm资产安全分析状态
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetSecurityAnalyseStatusRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetSecurityAnalyseStatusResponse"/></returns>
        public Task<DescribeDspmAssetSecurityAnalyseStatusResponse> DescribeDspmAssetSecurityAnalyseStatus(DescribeDspmAssetSecurityAnalyseStatusRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetSecurityAnalyseStatusResponse>(req, "DescribeDspmAssetSecurityAnalyseStatus");
        }

        /// <summary>
        /// 查询Dspm资产安全分析状态
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetSecurityAnalyseStatusRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetSecurityAnalyseStatusResponse"/></returns>
        public DescribeDspmAssetSecurityAnalyseStatusResponse DescribeDspmAssetSecurityAnalyseStatusSync(DescribeDspmAssetSecurityAnalyseStatusRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetSecurityAnalyseStatusResponse>(req, "DescribeDspmAssetSecurityAnalyseStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Dspm资产支持的权限
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetSupportedPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetSupportedPrivilegesResponse"/></returns>
        public Task<DescribeDspmAssetSupportedPrivilegesResponse> DescribeDspmAssetSupportedPrivileges(DescribeDspmAssetSupportedPrivilegesRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetSupportedPrivilegesResponse>(req, "DescribeDspmAssetSupportedPrivileges");
        }

        /// <summary>
        /// 查询Dspm资产支持的权限
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetSupportedPrivilegesRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetSupportedPrivilegesResponse"/></returns>
        public DescribeDspmAssetSupportedPrivilegesResponse DescribeDspmAssetSupportedPrivilegesSync(DescribeDspmAssetSupportedPrivilegesRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetSupportedPrivilegesResponse>(req, "DescribeDspmAssetSupportedPrivileges")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询资产表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetTableListRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetTableListResponse"/></returns>
        public Task<DescribeDspmAssetTableListResponse> DescribeDspmAssetTableList(DescribeDspmAssetTableListRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetTableListResponse>(req, "DescribeDspmAssetTableList");
        }

        /// <summary>
        /// 查询资产表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetTableListRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetTableListResponse"/></returns>
        public DescribeDspmAssetTableListResponse DescribeDspmAssetTableListSync(DescribeDspmAssetTableListRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetTableListResponse>(req, "DescribeDspmAssetTableList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Dspm资产列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetsRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetsResponse"/></returns>
        public Task<DescribeDspmAssetsResponse> DescribeDspmAssets(DescribeDspmAssetsRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetsResponse>(req, "DescribeDspmAssets");
        }

        /// <summary>
        /// 查询Dspm资产列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmAssetsRequest"/></param>
        /// <returns><see cref="DescribeDspmAssetsResponse"/></returns>
        public DescribeDspmAssetsResponse DescribeDspmAssetsSync(DescribeDspmAssetsRequest req)
        {
            return InternalRequestAsync<DescribeDspmAssetsResponse>(req, "DescribeDspmAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询备份日志列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmBackupLogListRequest"/></param>
        /// <returns><see cref="DescribeDspmBackupLogListResponse"/></returns>
        public Task<DescribeDspmBackupLogListResponse> DescribeDspmBackupLogList(DescribeDspmBackupLogListRequest req)
        {
            return InternalRequestAsync<DescribeDspmBackupLogListResponse>(req, "DescribeDspmBackupLogList");
        }

        /// <summary>
        /// 查询备份日志列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmBackupLogListRequest"/></param>
        /// <returns><see cref="DescribeDspmBackupLogListResponse"/></returns>
        public DescribeDspmBackupLogListResponse DescribeDspmBackupLogListSync(DescribeDspmBackupLogListRequest req)
        {
            return InternalRequestAsync<DescribeDspmBackupLogListResponse>(req, "DescribeDspmBackupLogList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询日志备份配置
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmBackupSettingRequest"/></param>
        /// <returns><see cref="DescribeDspmBackupSettingResponse"/></returns>
        public Task<DescribeDspmBackupSettingResponse> DescribeDspmBackupSetting(DescribeDspmBackupSettingRequest req)
        {
            return InternalRequestAsync<DescribeDspmBackupSettingResponse>(req, "DescribeDspmBackupSetting");
        }

        /// <summary>
        /// 查询日志备份配置
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmBackupSettingRequest"/></param>
        /// <returns><see cref="DescribeDspmBackupSettingResponse"/></returns>
        public DescribeDspmBackupSettingResponse DescribeDspmBackupSettingSync(DescribeDspmBackupSettingRequest req)
        {
            return InternalRequestAsync<DescribeDspmBackupSettingResponse>(req, "DescribeDspmBackupSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询dspm字典信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmDictionaryListRequest"/></param>
        /// <returns><see cref="DescribeDspmDictionaryListResponse"/></returns>
        public Task<DescribeDspmDictionaryListResponse> DescribeDspmDictionaryList(DescribeDspmDictionaryListRequest req)
        {
            return InternalRequestAsync<DescribeDspmDictionaryListResponse>(req, "DescribeDspmDictionaryList");
        }

        /// <summary>
        /// 查询dspm字典信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmDictionaryListRequest"/></param>
        /// <returns><see cref="DescribeDspmDictionaryListResponse"/></returns>
        public DescribeDspmDictionaryListResponse DescribeDspmDictionaryListSync(DescribeDspmDictionaryListRequest req)
        {
            return InternalRequestAsync<DescribeDspmDictionaryListResponse>(req, "DescribeDspmDictionaryList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询导出任务
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmExportTaskRequest"/></param>
        /// <returns><see cref="DescribeDspmExportTaskResponse"/></returns>
        public Task<DescribeDspmExportTaskResponse> DescribeDspmExportTask(DescribeDspmExportTaskRequest req)
        {
            return InternalRequestAsync<DescribeDspmExportTaskResponse>(req, "DescribeDspmExportTask");
        }

        /// <summary>
        /// 查询导出任务
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmExportTaskRequest"/></param>
        /// <returns><see cref="DescribeDspmExportTaskResponse"/></returns>
        public DescribeDspmExportTaskResponse DescribeDspmExportTaskSync(DescribeDspmExportTaskRequest req)
        {
            return InternalRequestAsync<DescribeDspmExportTaskResponse>(req, "DescribeDspmExportTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询dspm数据识别分类列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyCategoryListRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyCategoryListResponse"/></returns>
        public Task<DescribeDspmIdentifyCategoryListResponse> DescribeDspmIdentifyCategoryList(DescribeDspmIdentifyCategoryListRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyCategoryListResponse>(req, "DescribeDspmIdentifyCategoryList");
        }

        /// <summary>
        /// 查询dspm数据识别分类列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyCategoryListRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyCategoryListResponse"/></returns>
        public DescribeDspmIdentifyCategoryListResponse DescribeDspmIdentifyCategoryListSync(DescribeDspmIdentifyCategoryListRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyCategoryListResponse>(req, "DescribeDspmIdentifyCategoryList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询dspm数据识别模板分类关联数据项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyComplianceCategoryRuleListRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyComplianceCategoryRuleListResponse"/></returns>
        public Task<DescribeDspmIdentifyComplianceCategoryRuleListResponse> DescribeDspmIdentifyComplianceCategoryRuleList(DescribeDspmIdentifyComplianceCategoryRuleListRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyComplianceCategoryRuleListResponse>(req, "DescribeDspmIdentifyComplianceCategoryRuleList");
        }

        /// <summary>
        /// 查询dspm数据识别模板分类关联数据项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyComplianceCategoryRuleListRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyComplianceCategoryRuleListResponse"/></returns>
        public DescribeDspmIdentifyComplianceCategoryRuleListResponse DescribeDspmIdentifyComplianceCategoryRuleListSync(DescribeDspmIdentifyComplianceCategoryRuleListRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyComplianceCategoryRuleListResponse>(req, "DescribeDspmIdentifyComplianceCategoryRuleList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询dspm识别模板详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyComplianceGroupDetailRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyComplianceGroupDetailResponse"/></returns>
        public Task<DescribeDspmIdentifyComplianceGroupDetailResponse> DescribeDspmIdentifyComplianceGroupDetail(DescribeDspmIdentifyComplianceGroupDetailRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyComplianceGroupDetailResponse>(req, "DescribeDspmIdentifyComplianceGroupDetail");
        }

        /// <summary>
        /// 查询dspm识别模板详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyComplianceGroupDetailRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyComplianceGroupDetailResponse"/></returns>
        public DescribeDspmIdentifyComplianceGroupDetailResponse DescribeDspmIdentifyComplianceGroupDetailSync(DescribeDspmIdentifyComplianceGroupDetailRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyComplianceGroupDetailResponse>(req, "DescribeDspmIdentifyComplianceGroupDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询dspm数据识别模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyComplianceGroupListRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyComplianceGroupListResponse"/></returns>
        public Task<DescribeDspmIdentifyComplianceGroupListResponse> DescribeDspmIdentifyComplianceGroupList(DescribeDspmIdentifyComplianceGroupListRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyComplianceGroupListResponse>(req, "DescribeDspmIdentifyComplianceGroupList");
        }

        /// <summary>
        /// 查询dspm数据识别模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyComplianceGroupListRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyComplianceGroupListResponse"/></returns>
        public DescribeDspmIdentifyComplianceGroupListResponse DescribeDspmIdentifyComplianceGroupListSync(DescribeDspmIdentifyComplianceGroupListRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyComplianceGroupListResponse>(req, "DescribeDspmIdentifyComplianceGroupList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询dspm数据识别分布统计
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyDistributionStatisticsRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyDistributionStatisticsResponse"/></returns>
        public Task<DescribeDspmIdentifyDistributionStatisticsResponse> DescribeDspmIdentifyDistributionStatistics(DescribeDspmIdentifyDistributionStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyDistributionStatisticsResponse>(req, "DescribeDspmIdentifyDistributionStatistics");
        }

        /// <summary>
        /// 查询dspm数据识别分布统计
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyDistributionStatisticsRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyDistributionStatisticsResponse"/></returns>
        public DescribeDspmIdentifyDistributionStatisticsResponse DescribeDspmIdentifyDistributionStatisticsSync(DescribeDspmIdentifyDistributionStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyDistributionStatisticsResponse>(req, "DescribeDspmIdentifyDistributionStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Dspm身份id列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyIdListRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyIdListResponse"/></returns>
        public Task<DescribeDspmIdentifyIdListResponse> DescribeDspmIdentifyIdList(DescribeDspmIdentifyIdListRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyIdListResponse>(req, "DescribeDspmIdentifyIdList");
        }

        /// <summary>
        /// 查询Dspm身份id列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyIdListRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyIdListResponse"/></returns>
        public DescribeDspmIdentifyIdListResponse DescribeDspmIdentifyIdListSync(DescribeDspmIdentifyIdListRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyIdListResponse>(req, "DescribeDspmIdentifyIdList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Dspm身份信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyInfoRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyInfoResponse"/></returns>
        public Task<DescribeDspmIdentifyInfoResponse> DescribeDspmIdentifyInfo(DescribeDspmIdentifyInfoRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyInfoResponse>(req, "DescribeDspmIdentifyInfo");
        }

        /// <summary>
        /// 查询Dspm身份信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyInfoRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyInfoResponse"/></returns>
        public DescribeDspmIdentifyInfoResponse DescribeDspmIdentifyInfoSync(DescribeDspmIdentifyInfoRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyInfoResponse>(req, "DescribeDspmIdentifyInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Dspm身份信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyInfoListRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyInfoListResponse"/></returns>
        public Task<DescribeDspmIdentifyInfoListResponse> DescribeDspmIdentifyInfoList(DescribeDspmIdentifyInfoListRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyInfoListResponse>(req, "DescribeDspmIdentifyInfoList");
        }

        /// <summary>
        /// 查询Dspm身份信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyInfoListRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyInfoListResponse"/></returns>
        public DescribeDspmIdentifyInfoListResponse DescribeDspmIdentifyInfoListSync(DescribeDspmIdentifyInfoListRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyInfoListResponse>(req, "DescribeDspmIdentifyInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询dspm数据识别分级组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyLevelGroupListRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyLevelGroupListResponse"/></returns>
        public Task<DescribeDspmIdentifyLevelGroupListResponse> DescribeDspmIdentifyLevelGroupList(DescribeDspmIdentifyLevelGroupListRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyLevelGroupListResponse>(req, "DescribeDspmIdentifyLevelGroupList");
        }

        /// <summary>
        /// 查询dspm数据识别分级组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyLevelGroupListRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyLevelGroupListResponse"/></returns>
        public DescribeDspmIdentifyLevelGroupListResponse DescribeDspmIdentifyLevelGroupListSync(DescribeDspmIdentifyLevelGroupListRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyLevelGroupListResponse>(req, "DescribeDspmIdentifyLevelGroupList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询dspm数据识别数据项详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyRuleDetailRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyRuleDetailResponse"/></returns>
        public Task<DescribeDspmIdentifyRuleDetailResponse> DescribeDspmIdentifyRuleDetail(DescribeDspmIdentifyRuleDetailRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyRuleDetailResponse>(req, "DescribeDspmIdentifyRuleDetail");
        }

        /// <summary>
        /// 查询dspm数据识别数据项详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyRuleDetailRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyRuleDetailResponse"/></returns>
        public DescribeDspmIdentifyRuleDetailResponse DescribeDspmIdentifyRuleDetailSync(DescribeDspmIdentifyRuleDetailRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyRuleDetailResponse>(req, "DescribeDspmIdentifyRuleDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询dspm数据识别数据项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyRuleListRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyRuleListResponse"/></returns>
        public Task<DescribeDspmIdentifyRuleListResponse> DescribeDspmIdentifyRuleList(DescribeDspmIdentifyRuleListRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyRuleListResponse>(req, "DescribeDspmIdentifyRuleList");
        }

        /// <summary>
        /// 查询dspm数据识别数据项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyRuleListRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyRuleListResponse"/></returns>
        public DescribeDspmIdentifyRuleListResponse DescribeDspmIdentifyRuleListSync(DescribeDspmIdentifyRuleListRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyRuleListResponse>(req, "DescribeDspmIdentifyRuleList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询dspm数据识别数据项验证结果
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyRuleTestResultRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyRuleTestResultResponse"/></returns>
        public Task<DescribeDspmIdentifyRuleTestResultResponse> DescribeDspmIdentifyRuleTestResult(DescribeDspmIdentifyRuleTestResultRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyRuleTestResultResponse>(req, "DescribeDspmIdentifyRuleTestResult");
        }

        /// <summary>
        /// 查询dspm数据识别数据项验证结果
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmIdentifyRuleTestResultRequest"/></param>
        /// <returns><see cref="DescribeDspmIdentifyRuleTestResultResponse"/></returns>
        public DescribeDspmIdentifyRuleTestResultResponse DescribeDspmIdentifyRuleTestResultSync(DescribeDspmIdentifyRuleTestResultRequest req)
        {
            return InternalRequestAsync<DescribeDspmIdentifyRuleTestResultResponse>(req, "DescribeDspmIdentifyRuleTestResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询日志列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmLogListRequest"/></param>
        /// <returns><see cref="DescribeDspmLogListResponse"/></returns>
        public Task<DescribeDspmLogListResponse> DescribeDspmLogList(DescribeDspmLogListRequest req)
        {
            return InternalRequestAsync<DescribeDspmLogListResponse>(req, "DescribeDspmLogList");
        }

        /// <summary>
        /// 查询日志列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmLogListRequest"/></param>
        /// <returns><see cref="DescribeDspmLogListResponse"/></returns>
        public DescribeDspmLogListResponse DescribeDspmLogListSync(DescribeDspmLogListRequest req)
        {
            return InternalRequestAsync<DescribeDspmLogListResponse>(req, "DescribeDspmLogList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取已购Dspm订单信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmPayInfoRequest"/></param>
        /// <returns><see cref="DescribeDspmPayInfoResponse"/></returns>
        public Task<DescribeDspmPayInfoResponse> DescribeDspmPayInfo(DescribeDspmPayInfoRequest req)
        {
            return InternalRequestAsync<DescribeDspmPayInfoResponse>(req, "DescribeDspmPayInfo");
        }

        /// <summary>
        /// 获取已购Dspm订单信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmPayInfoRequest"/></param>
        /// <returns><see cref="DescribeDspmPayInfoResponse"/></returns>
        public DescribeDspmPayInfoResponse DescribeDspmPayInfoSync(DescribeDspmPayInfoRequest req)
        {
            return InternalRequestAsync<DescribeDspmPayInfoResponse>(req, "DescribeDspmPayInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Dspm访客申请记录
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmPersonApplyHistoryRequest"/></param>
        /// <returns><see cref="DescribeDspmPersonApplyHistoryResponse"/></returns>
        public Task<DescribeDspmPersonApplyHistoryResponse> DescribeDspmPersonApplyHistory(DescribeDspmPersonApplyHistoryRequest req)
        {
            return InternalRequestAsync<DescribeDspmPersonApplyHistoryResponse>(req, "DescribeDspmPersonApplyHistory");
        }

        /// <summary>
        /// 查询Dspm访客申请记录
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmPersonApplyHistoryRequest"/></param>
        /// <returns><see cref="DescribeDspmPersonApplyHistoryResponse"/></returns>
        public DescribeDspmPersonApplyHistoryResponse DescribeDspmPersonApplyHistorySync(DescribeDspmPersonApplyHistoryRequest req)
        {
            return InternalRequestAsync<DescribeDspmPersonApplyHistoryResponse>(req, "DescribeDspmPersonApplyHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Dspm个人身份信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmPersonalIdentifyListRequest"/></param>
        /// <returns><see cref="DescribeDspmPersonalIdentifyListResponse"/></returns>
        public Task<DescribeDspmPersonalIdentifyListResponse> DescribeDspmPersonalIdentifyList(DescribeDspmPersonalIdentifyListRequest req)
        {
            return InternalRequestAsync<DescribeDspmPersonalIdentifyListResponse>(req, "DescribeDspmPersonalIdentifyList");
        }

        /// <summary>
        /// 查询Dspm个人身份信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmPersonalIdentifyListRequest"/></param>
        /// <returns><see cref="DescribeDspmPersonalIdentifyListResponse"/></returns>
        public DescribeDspmPersonalIdentifyListResponse DescribeDspmPersonalIdentifyListSync(DescribeDspmPersonalIdentifyListRequest req)
        {
            return InternalRequestAsync<DescribeDspmPersonalIdentifyListResponse>(req, "DescribeDspmPersonalIdentifyList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Dspm风险记录
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmRiskRequest"/></param>
        /// <returns><see cref="DescribeDspmRiskResponse"/></returns>
        public Task<DescribeDspmRiskResponse> DescribeDspmRisk(DescribeDspmRiskRequest req)
        {
            return InternalRequestAsync<DescribeDspmRiskResponse>(req, "DescribeDspmRisk");
        }

        /// <summary>
        /// 查询Dspm风险记录
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmRiskRequest"/></param>
        /// <returns><see cref="DescribeDspmRiskResponse"/></returns>
        public DescribeDspmRiskResponse DescribeDspmRiskSync(DescribeDspmRiskRequest req)
        {
            return InternalRequestAsync<DescribeDspmRiskResponse>(req, "DescribeDspmRisk")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Dspm风险详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmRiskDetailRequest"/></param>
        /// <returns><see cref="DescribeDspmRiskDetailResponse"/></returns>
        public Task<DescribeDspmRiskDetailResponse> DescribeDspmRiskDetail(DescribeDspmRiskDetailRequest req)
        {
            return InternalRequestAsync<DescribeDspmRiskDetailResponse>(req, "DescribeDspmRiskDetail");
        }

        /// <summary>
        /// 查询Dspm风险详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmRiskDetailRequest"/></param>
        /// <returns><see cref="DescribeDspmRiskDetailResponse"/></returns>
        public DescribeDspmRiskDetailResponse DescribeDspmRiskDetailSync(DescribeDspmRiskDetailRequest req)
        {
            return InternalRequestAsync<DescribeDspmRiskDetailResponse>(req, "DescribeDspmRiskDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Dspm风险策略
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmRiskStrategyRequest"/></param>
        /// <returns><see cref="DescribeDspmRiskStrategyResponse"/></returns>
        public Task<DescribeDspmRiskStrategyResponse> DescribeDspmRiskStrategy(DescribeDspmRiskStrategyRequest req)
        {
            return InternalRequestAsync<DescribeDspmRiskStrategyResponse>(req, "DescribeDspmRiskStrategy");
        }

        /// <summary>
        /// 查询Dspm风险策略
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmRiskStrategyRequest"/></param>
        /// <returns><see cref="DescribeDspmRiskStrategyResponse"/></returns>
        public DescribeDspmRiskStrategyResponse DescribeDspmRiskStrategySync(DescribeDspmRiskStrategyRequest req)
        {
            return InternalRequestAsync<DescribeDspmRiskStrategyResponse>(req, "DescribeDspmRiskStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Dspm风险分组策略
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmRiskStrategyGroupRequest"/></param>
        /// <returns><see cref="DescribeDspmRiskStrategyGroupResponse"/></returns>
        public Task<DescribeDspmRiskStrategyGroupResponse> DescribeDspmRiskStrategyGroup(DescribeDspmRiskStrategyGroupRequest req)
        {
            return InternalRequestAsync<DescribeDspmRiskStrategyGroupResponse>(req, "DescribeDspmRiskStrategyGroup");
        }

        /// <summary>
        /// 查询Dspm风险分组策略
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmRiskStrategyGroupRequest"/></param>
        /// <returns><see cref="DescribeDspmRiskStrategyGroupResponse"/></returns>
        public DescribeDspmRiskStrategyGroupResponse DescribeDspmRiskStrategyGroupSync(DescribeDspmRiskStrategyGroupRequest req)
        {
            return InternalRequestAsync<DescribeDspmRiskStrategyGroupResponse>(req, "DescribeDspmRiskStrategyGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Dspm风险趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmRiskTendencyRequest"/></param>
        /// <returns><see cref="DescribeDspmRiskTendencyResponse"/></returns>
        public Task<DescribeDspmRiskTendencyResponse> DescribeDspmRiskTendency(DescribeDspmRiskTendencyRequest req)
        {
            return InternalRequestAsync<DescribeDspmRiskTendencyResponse>(req, "DescribeDspmRiskTendency");
        }

        /// <summary>
        /// 查询Dspm风险趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmRiskTendencyRequest"/></param>
        /// <returns><see cref="DescribeDspmRiskTendencyResponse"/></returns>
        public DescribeDspmRiskTendencyResponse DescribeDspmRiskTendencySync(DescribeDspmRiskTendencyRequest req)
        {
            return InternalRequestAsync<DescribeDspmRiskTendencyResponse>(req, "DescribeDspmRiskTendency")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Dspm统计信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmStatisticsRequest"/></param>
        /// <returns><see cref="DescribeDspmStatisticsResponse"/></returns>
        public Task<DescribeDspmStatisticsResponse> DescribeDspmStatistics(DescribeDspmStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeDspmStatisticsResponse>(req, "DescribeDspmStatistics");
        }

        /// <summary>
        /// 查询Dspm统计信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmStatisticsRequest"/></param>
        /// <returns><see cref="DescribeDspmStatisticsResponse"/></returns>
        public DescribeDspmStatisticsResponse DescribeDspmStatisticsSync(DescribeDspmStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeDspmStatisticsResponse>(req, "DescribeDspmStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Dspm支持的资产类型信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmSupportedAssetTypeRequest"/></param>
        /// <returns><see cref="DescribeDspmSupportedAssetTypeResponse"/></returns>
        public Task<DescribeDspmSupportedAssetTypeResponse> DescribeDspmSupportedAssetType(DescribeDspmSupportedAssetTypeRequest req)
        {
            return InternalRequestAsync<DescribeDspmSupportedAssetTypeResponse>(req, "DescribeDspmSupportedAssetType");
        }

        /// <summary>
        /// 查询Dspm支持的资产类型信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmSupportedAssetTypeRequest"/></param>
        /// <returns><see cref="DescribeDspmSupportedAssetTypeResponse"/></returns>
        public DescribeDspmSupportedAssetTypeResponse DescribeDspmSupportedAssetTypeSync(DescribeDspmSupportedAssetTypeRequest req)
        {
            return InternalRequestAsync<DescribeDspmSupportedAssetTypeResponse>(req, "DescribeDspmSupportedAssetType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Dspm同步资产状态
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmSyncAssetsStatusRequest"/></param>
        /// <returns><see cref="DescribeDspmSyncAssetsStatusResponse"/></returns>
        public Task<DescribeDspmSyncAssetsStatusResponse> DescribeDspmSyncAssetsStatus(DescribeDspmSyncAssetsStatusRequest req)
        {
            return InternalRequestAsync<DescribeDspmSyncAssetsStatusResponse>(req, "DescribeDspmSyncAssetsStatus");
        }

        /// <summary>
        /// 查询Dspm同步资产状态
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmSyncAssetsStatusRequest"/></param>
        /// <returns><see cref="DescribeDspmSyncAssetsStatusResponse"/></returns>
        public DescribeDspmSyncAssetsStatusResponse DescribeDspmSyncAssetsStatusSync(DescribeDspmSyncAssetsStatusRequest req)
        {
            return InternalRequestAsync<DescribeDspmSyncAssetsStatusResponse>(req, "DescribeDspmSyncAssetsStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Dspm同步用户状态
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmSyncUsersStatusRequest"/></param>
        /// <returns><see cref="DescribeDspmSyncUsersStatusResponse"/></returns>
        public Task<DescribeDspmSyncUsersStatusResponse> DescribeDspmSyncUsersStatus(DescribeDspmSyncUsersStatusRequest req)
        {
            return InternalRequestAsync<DescribeDspmSyncUsersStatusResponse>(req, "DescribeDspmSyncUsersStatus");
        }

        /// <summary>
        /// 查询Dspm同步用户状态
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmSyncUsersStatusRequest"/></param>
        /// <returns><see cref="DescribeDspmSyncUsersStatusResponse"/></returns>
        public DescribeDspmSyncUsersStatusResponse DescribeDspmSyncUsersStatusSync(DescribeDspmSyncUsersStatusRequest req)
        {
            return InternalRequestAsync<DescribeDspmSyncUsersStatusResponse>(req, "DescribeDspmSyncUsersStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询Dspm白名单策略
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmWhitelistStrategyRequest"/></param>
        /// <returns><see cref="DescribeDspmWhitelistStrategyResponse"/></returns>
        public Task<DescribeDspmWhitelistStrategyResponse> DescribeDspmWhitelistStrategy(DescribeDspmWhitelistStrategyRequest req)
        {
            return InternalRequestAsync<DescribeDspmWhitelistStrategyResponse>(req, "DescribeDspmWhitelistStrategy");
        }

        /// <summary>
        /// 查询Dspm白名单策略
        /// </summary>
        /// <param name="req"><see cref="DescribeDspmWhitelistStrategyRequest"/></param>
        /// <returns><see cref="DescribeDspmWhitelistStrategyResponse"/></returns>
        public DescribeDspmWhitelistStrategyResponse DescribeDspmWhitelistStrategySync(DescribeDspmWhitelistStrategyRequest req)
        {
            return InternalRequestAsync<DescribeDspmWhitelistStrategyResponse>(req, "DescribeDspmWhitelistStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取EDR策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEDRRuleListRequest"/></param>
        /// <returns><see cref="DescribeEDRRuleListResponse"/></returns>
        public Task<DescribeEDRRuleListResponse> DescribeEDRRuleList(DescribeEDRRuleListRequest req)
        {
            return InternalRequestAsync<DescribeEDRRuleListResponse>(req, "DescribeEDRRuleList");
        }

        /// <summary>
        /// 获取EDR策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEDRRuleListRequest"/></param>
        /// <returns><see cref="DescribeEDRRuleListResponse"/></returns>
        public DescribeEDRRuleListResponse DescribeEDRRuleListSync(DescribeEDRRuleListRequest req)
        {
            return InternalRequestAsync<DescribeEDRRuleListResponse>(req, "DescribeEDRRuleList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取EDR告警详情，包含告警内容JSON、资产富化、情报富化等完整信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEdrAlertInfoRequest"/></param>
        /// <returns><see cref="DescribeEdrAlertInfoResponse"/></returns>
        public Task<DescribeEdrAlertInfoResponse> DescribeEdrAlertInfo(DescribeEdrAlertInfoRequest req)
        {
            return InternalRequestAsync<DescribeEdrAlertInfoResponse>(req, "DescribeEdrAlertInfo");
        }

        /// <summary>
        /// 获取EDR告警详情，包含告警内容JSON、资产富化、情报富化等完整信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEdrAlertInfoRequest"/></param>
        /// <returns><see cref="DescribeEdrAlertInfoResponse"/></returns>
        public DescribeEdrAlertInfoResponse DescribeEdrAlertInfoSync(DescribeEdrAlertInfoRequest req)
        {
            return InternalRequestAsync<DescribeEdrAlertInfoResponse>(req, "DescribeEdrAlertInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取EDR告警列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdrAlertListRequest"/></param>
        /// <returns><see cref="DescribeEdrAlertListResponse"/></returns>
        public Task<DescribeEdrAlertListResponse> DescribeEdrAlertList(DescribeEdrAlertListRequest req)
        {
            return InternalRequestAsync<DescribeEdrAlertListResponse>(req, "DescribeEdrAlertList");
        }

        /// <summary>
        /// 获取EDR告警列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdrAlertListRequest"/></param>
        /// <returns><see cref="DescribeEdrAlertListResponse"/></returns>
        public DescribeEdrAlertListResponse DescribeEdrAlertListSync(DescribeEdrAlertListRequest req)
        {
            return InternalRequestAsync<DescribeEdrAlertListResponse>(req, "DescribeEdrAlertList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云边界分析资产分类
        /// </summary>
        /// <param name="req"><see cref="DescribeExposeAssetCategoryRequest"/></param>
        /// <returns><see cref="DescribeExposeAssetCategoryResponse"/></returns>
        public Task<DescribeExposeAssetCategoryResponse> DescribeExposeAssetCategory(DescribeExposeAssetCategoryRequest req)
        {
            return InternalRequestAsync<DescribeExposeAssetCategoryResponse>(req, "DescribeExposeAssetCategory");
        }

        /// <summary>
        /// 云边界分析资产分类
        /// </summary>
        /// <param name="req"><see cref="DescribeExposeAssetCategoryRequest"/></param>
        /// <returns><see cref="DescribeExposeAssetCategoryResponse"/></returns>
        public DescribeExposeAssetCategoryResponse DescribeExposeAssetCategorySync(DescribeExposeAssetCategoryRequest req)
        {
            return InternalRequestAsync<DescribeExposeAssetCategoryResponse>(req, "DescribeExposeAssetCategory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询云边界分析路径节点
        /// </summary>
        /// <param name="req"><see cref="DescribeExposePathRequest"/></param>
        /// <returns><see cref="DescribeExposePathResponse"/></returns>
        public Task<DescribeExposePathResponse> DescribeExposePath(DescribeExposePathRequest req)
        {
            return InternalRequestAsync<DescribeExposePathResponse>(req, "DescribeExposePath");
        }

        /// <summary>
        /// 查询云边界分析路径节点
        /// </summary>
        /// <param name="req"><see cref="DescribeExposePathRequest"/></param>
        /// <returns><see cref="DescribeExposePathResponse"/></returns>
        public DescribeExposePathResponse DescribeExposePathSync(DescribeExposePathRequest req)
        {
            return InternalRequestAsync<DescribeExposePathResponse>(req, "DescribeExposePath")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云边界分析资产列表
        /// </summary>
        /// <param name="req"><see cref="DescribeExposuresRequest"/></param>
        /// <returns><see cref="DescribeExposuresResponse"/></returns>
        public Task<DescribeExposuresResponse> DescribeExposures(DescribeExposuresRequest req)
        {
            return InternalRequestAsync<DescribeExposuresResponse>(req, "DescribeExposures");
        }

        /// <summary>
        /// 云边界分析资产列表
        /// </summary>
        /// <param name="req"><see cref="DescribeExposuresRequest"/></param>
        /// <returns><see cref="DescribeExposuresResponse"/></returns>
        public DescribeExposuresResponse DescribeExposuresSync(DescribeExposuresRequest req)
        {
            return InternalRequestAsync<DescribeExposuresResponse>(req, "DescribeExposures")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取网关列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayAssetsRequest"/></param>
        /// <returns><see cref="DescribeGatewayAssetsResponse"/></returns>
        public Task<DescribeGatewayAssetsResponse> DescribeGatewayAssets(DescribeGatewayAssetsRequest req)
        {
            return InternalRequestAsync<DescribeGatewayAssetsResponse>(req, "DescribeGatewayAssets");
        }

        /// <summary>
        /// 获取网关列表
        /// </summary>
        /// <param name="req"><see cref="DescribeGatewayAssetsRequest"/></param>
        /// <returns><see cref="DescribeGatewayAssetsResponse"/></returns>
        public DescribeGatewayAssetsResponse DescribeGatewayAssetsSync(DescribeGatewayAssetsRequest req)
        {
            return InternalRequestAsync<DescribeGatewayAssetsResponse>(req, "DescribeGatewayAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询云边界分析-暴露路径下主机节点的高危基线风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHighBaseLineRiskListRequest"/></param>
        /// <returns><see cref="DescribeHighBaseLineRiskListResponse"/></returns>
        public Task<DescribeHighBaseLineRiskListResponse> DescribeHighBaseLineRiskList(DescribeHighBaseLineRiskListRequest req)
        {
            return InternalRequestAsync<DescribeHighBaseLineRiskListResponse>(req, "DescribeHighBaseLineRiskList");
        }

        /// <summary>
        /// 查询云边界分析-暴露路径下主机节点的高危基线风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHighBaseLineRiskListRequest"/></param>
        /// <returns><see cref="DescribeHighBaseLineRiskListResponse"/></returns>
        public DescribeHighBaseLineRiskListResponse DescribeHighBaseLineRiskListSync(DescribeHighBaseLineRiskListRequest req)
        {
            return InternalRequestAsync<DescribeHighBaseLineRiskListResponse>(req, "DescribeHighBaseLineRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取IaC检测文件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeIaCFileListRequest"/></param>
        /// <returns><see cref="DescribeIaCFileListResponse"/></returns>
        public Task<DescribeIaCFileListResponse> DescribeIaCFileList(DescribeIaCFileListRequest req)
        {
            return InternalRequestAsync<DescribeIaCFileListResponse>(req, "DescribeIaCFileList");
        }

        /// <summary>
        /// 获取IaC检测文件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeIaCFileListRequest"/></param>
        /// <returns><see cref="DescribeIaCFileListResponse"/></returns>
        public DescribeIaCFileListResponse DescribeIaCFileListSync(DescribeIaCFileListRequest req)
        {
            return InternalRequestAsync<DescribeIaCFileListResponse>(req, "DescribeIaCFileList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取IaC检测文件概览
        /// </summary>
        /// <param name="req"><see cref="DescribeIaCFileOverviewRequest"/></param>
        /// <returns><see cref="DescribeIaCFileOverviewResponse"/></returns>
        public Task<DescribeIaCFileOverviewResponse> DescribeIaCFileOverview(DescribeIaCFileOverviewRequest req)
        {
            return InternalRequestAsync<DescribeIaCFileOverviewResponse>(req, "DescribeIaCFileOverview");
        }

        /// <summary>
        /// 获取IaC检测文件概览
        /// </summary>
        /// <param name="req"><see cref="DescribeIaCFileOverviewRequest"/></param>
        /// <returns><see cref="DescribeIaCFileOverviewResponse"/></returns>
        public DescribeIaCFileOverviewResponse DescribeIaCFileOverviewSync(DescribeIaCFileOverviewRequest req)
        {
            return InternalRequestAsync<DescribeIaCFileOverviewResponse>(req, "DescribeIaCFileOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取IaC检测文件报告
        /// </summary>
        /// <param name="req"><see cref="DescribeIaCFileReportRequest"/></param>
        /// <returns><see cref="DescribeIaCFileReportResponse"/></returns>
        public Task<DescribeIaCFileReportResponse> DescribeIaCFileReport(DescribeIaCFileReportRequest req)
        {
            return InternalRequestAsync<DescribeIaCFileReportResponse>(req, "DescribeIaCFileReport");
        }

        /// <summary>
        /// 获取IaC检测文件报告
        /// </summary>
        /// <param name="req"><see cref="DescribeIaCFileReportRequest"/></param>
        /// <returns><see cref="DescribeIaCFileReportResponse"/></returns>
        public DescribeIaCFileReportResponse DescribeIaCFileReportSync(DescribeIaCFileReportRequest req)
        {
            return InternalRequestAsync<DescribeIaCFileReportResponse>(req, "DescribeIaCFileReport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取IaC检测接入Token列表
        /// </summary>
        /// <param name="req"><see cref="DescribeIaCTokenListRequest"/></param>
        /// <returns><see cref="DescribeIaCTokenListResponse"/></returns>
        public Task<DescribeIaCTokenListResponse> DescribeIaCTokenList(DescribeIaCTokenListRequest req)
        {
            return InternalRequestAsync<DescribeIaCTokenListResponse>(req, "DescribeIaCTokenList");
        }

        /// <summary>
        /// 获取IaC检测接入Token列表
        /// </summary>
        /// <param name="req"><see cref="DescribeIaCTokenListRequest"/></param>
        /// <returns><see cref="DescribeIaCTokenListResponse"/></returns>
        public DescribeIaCTokenListResponse DescribeIaCTokenListSync(DescribeIaCTokenListRequest req)
        {
            return InternalRequestAsync<DescribeIaCTokenListResponse>(req, "DescribeIaCTokenList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 对象存储异常检测调用记录信息
        /// </summary>
        /// <param name="req"><see cref="DescribeIpInvokeRecordRequest"/></param>
        /// <returns><see cref="DescribeIpInvokeRecordResponse"/></returns>
        public Task<DescribeIpInvokeRecordResponse> DescribeIpInvokeRecord(DescribeIpInvokeRecordRequest req)
        {
            return InternalRequestAsync<DescribeIpInvokeRecordResponse>(req, "DescribeIpInvokeRecord");
        }

        /// <summary>
        /// 对象存储异常检测调用记录信息
        /// </summary>
        /// <param name="req"><see cref="DescribeIpInvokeRecordRequest"/></param>
        /// <returns><see cref="DescribeIpInvokeRecordResponse"/></returns>
        public DescribeIpInvokeRecordResponse DescribeIpInvokeRecordSync(DescribeIpInvokeRecordRequest req)
        {
            return InternalRequestAsync<DescribeIpInvokeRecordResponse>(req, "DescribeIpInvokeRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ip访问列表详情信息
        /// </summary>
        /// <param name="req"><see cref="DescribeIpInvokeRecordDetailRequest"/></param>
        /// <returns><see cref="DescribeIpInvokeRecordDetailResponse"/></returns>
        public Task<DescribeIpInvokeRecordDetailResponse> DescribeIpInvokeRecordDetail(DescribeIpInvokeRecordDetailRequest req)
        {
            return InternalRequestAsync<DescribeIpInvokeRecordDetailResponse>(req, "DescribeIpInvokeRecordDetail");
        }

        /// <summary>
        /// ip访问列表详情信息
        /// </summary>
        /// <param name="req"><see cref="DescribeIpInvokeRecordDetailRequest"/></param>
        /// <returns><see cref="DescribeIpInvokeRecordDetailResponse"/></returns>
        public DescribeIpInvokeRecordDetailResponse DescribeIpInvokeRecordDetailSync(DescribeIpInvokeRecordDetailRequest req)
        {
            return InternalRequestAsync<DescribeIpInvokeRecordDetailResponse>(req, "DescribeIpInvokeRecordDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询凭证详情，返回凭证元数据和打码后的凭据数据。access类型返回Access数组（Key原文、Value打码），sts类型返回STS对象（System原文、SecretID和SecretKey打码）
        /// </summary>
        /// <param name="req"><see cref="DescribeKeySandboxCredentialRequest"/></param>
        /// <returns><see cref="DescribeKeySandboxCredentialResponse"/></returns>
        public Task<DescribeKeySandboxCredentialResponse> DescribeKeySandboxCredential(DescribeKeySandboxCredentialRequest req)
        {
            return InternalRequestAsync<DescribeKeySandboxCredentialResponse>(req, "DescribeKeySandboxCredential");
        }

        /// <summary>
        /// 查询凭证详情，返回凭证元数据和打码后的凭据数据。access类型返回Access数组（Key原文、Value打码），sts类型返回STS对象（System原文、SecretID和SecretKey打码）
        /// </summary>
        /// <param name="req"><see cref="DescribeKeySandboxCredentialRequest"/></param>
        /// <returns><see cref="DescribeKeySandboxCredentialResponse"/></returns>
        public DescribeKeySandboxCredentialResponse DescribeKeySandboxCredentialSync(DescribeKeySandboxCredentialRequest req)
        {
            return InternalRequestAsync<DescribeKeySandboxCredentialResponse>(req, "DescribeKeySandboxCredential")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询凭证列表
        /// </summary>
        /// <param name="req"><see cref="DescribeKeySandboxCredentialListRequest"/></param>
        /// <returns><see cref="DescribeKeySandboxCredentialListResponse"/></returns>
        public Task<DescribeKeySandboxCredentialListResponse> DescribeKeySandboxCredentialList(DescribeKeySandboxCredentialListRequest req)
        {
            return InternalRequestAsync<DescribeKeySandboxCredentialListResponse>(req, "DescribeKeySandboxCredentialList");
        }

        /// <summary>
        /// 查询凭证列表
        /// </summary>
        /// <param name="req"><see cref="DescribeKeySandboxCredentialListRequest"/></param>
        /// <returns><see cref="DescribeKeySandboxCredentialListResponse"/></returns>
        public DescribeKeySandboxCredentialListResponse DescribeKeySandboxCredentialListSync(DescribeKeySandboxCredentialListRequest req)
        {
            return InternalRequestAsync<DescribeKeySandboxCredentialListResponse>(req, "DescribeKeySandboxCredentialList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询clb监听器列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListenerListRequest"/></param>
        /// <returns><see cref="DescribeListenerListResponse"/></returns>
        public Task<DescribeListenerListResponse> DescribeListenerList(DescribeListenerListRequest req)
        {
            return InternalRequestAsync<DescribeListenerListResponse>(req, "DescribeListenerList");
        }

        /// <summary>
        /// 查询clb监听器列表
        /// </summary>
        /// <param name="req"><see cref="DescribeListenerListRequest"/></param>
        /// <returns><see cref="DescribeListenerListResponse"/></returns>
        public DescribeListenerListResponse DescribeListenerListSync(DescribeListenerListRequest req)
        {
            return InternalRequestAsync<DescribeListenerListResponse>(req, "DescribeListenerList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取网卡列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNICAssetsRequest"/></param>
        /// <returns><see cref="DescribeNICAssetsResponse"/></returns>
        public Task<DescribeNICAssetsResponse> DescribeNICAssets(DescribeNICAssetsRequest req)
        {
            return InternalRequestAsync<DescribeNICAssetsResponse>(req, "DescribeNICAssets");
        }

        /// <summary>
        /// 获取网卡列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNICAssetsRequest"/></param>
        /// <returns><see cref="DescribeNICAssetsResponse"/></returns>
        public DescribeNICAssetsResponse DescribeNICAssetsSync(DescribeNICAssetsRequest req)
        {
            return InternalRequestAsync<DescribeNICAssetsResponse>(req, "DescribeNICAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取通知资产范围配置
        /// </summary>
        /// <param name="req"><see cref="DescribeNotifyAssetConfigRequest"/></param>
        /// <returns><see cref="DescribeNotifyAssetConfigResponse"/></returns>
        public Task<DescribeNotifyAssetConfigResponse> DescribeNotifyAssetConfig(DescribeNotifyAssetConfigRequest req)
        {
            return InternalRequestAsync<DescribeNotifyAssetConfigResponse>(req, "DescribeNotifyAssetConfig");
        }

        /// <summary>
        /// 获取通知资产范围配置
        /// </summary>
        /// <param name="req"><see cref="DescribeNotifyAssetConfigRequest"/></param>
        /// <returns><see cref="DescribeNotifyAssetConfigResponse"/></returns>
        public DescribeNotifyAssetConfigResponse DescribeNotifyAssetConfigSync(DescribeNotifyAssetConfigRequest req)
        {
            return InternalRequestAsync<DescribeNotifyAssetConfigResponse>(req, "DescribeNotifyAssetConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取通知设置
        /// </summary>
        /// <param name="req"><see cref="DescribeNotifySettingRequest"/></param>
        /// <returns><see cref="DescribeNotifySettingResponse"/></returns>
        public Task<DescribeNotifySettingResponse> DescribeNotifySetting(DescribeNotifySettingRequest req)
        {
            return InternalRequestAsync<DescribeNotifySettingResponse>(req, "DescribeNotifySetting");
        }

        /// <summary>
        /// 获取通知设置
        /// </summary>
        /// <param name="req"><see cref="DescribeNotifySettingRequest"/></param>
        /// <returns><see cref="DescribeNotifySettingResponse"/></returns>
        public DescribeNotifySettingResponse DescribeNotifySettingSync(DescribeNotifySettingRequest req)
        {
            return InternalRequestAsync<DescribeNotifySettingResponse>(req, "DescribeNotifySetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取告警中心通知高级配置
        /// </summary>
        /// <param name="req"><see cref="DescribeNotifySettingAlertRequest"/></param>
        /// <returns><see cref="DescribeNotifySettingAlertResponse"/></returns>
        public Task<DescribeNotifySettingAlertResponse> DescribeNotifySettingAlert(DescribeNotifySettingAlertRequest req)
        {
            return InternalRequestAsync<DescribeNotifySettingAlertResponse>(req, "DescribeNotifySettingAlert");
        }

        /// <summary>
        /// 获取告警中心通知高级配置
        /// </summary>
        /// <param name="req"><see cref="DescribeNotifySettingAlertRequest"/></param>
        /// <returns><see cref="DescribeNotifySettingAlertResponse"/></returns>
        public DescribeNotifySettingAlertResponse DescribeNotifySettingAlertSync(DescribeNotifySettingAlertRequest req)
        {
            return InternalRequestAsync<DescribeNotifySettingAlertResponse>(req, "DescribeNotifySettingAlert")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集团账号详情
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationInfoRequest"/></param>
        /// <returns><see cref="DescribeOrganizationInfoResponse"/></returns>
        public Task<DescribeOrganizationInfoResponse> DescribeOrganizationInfo(DescribeOrganizationInfoRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationInfoResponse>(req, "DescribeOrganizationInfo");
        }

        /// <summary>
        /// 查询集团账号详情
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationInfoRequest"/></param>
        /// <returns><see cref="DescribeOrganizationInfoResponse"/></returns>
        public DescribeOrganizationInfoResponse DescribeOrganizationInfoSync(DescribeOrganizationInfoRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationInfoResponse>(req, "DescribeOrganizationInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集团账号用户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationUserInfoRequest"/></param>
        /// <returns><see cref="DescribeOrganizationUserInfoResponse"/></returns>
        public Task<DescribeOrganizationUserInfoResponse> DescribeOrganizationUserInfo(DescribeOrganizationUserInfoRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationUserInfoResponse>(req, "DescribeOrganizationUserInfo");
        }

        /// <summary>
        /// 查询集团账号用户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOrganizationUserInfoRequest"/></param>
        /// <returns><see cref="DescribeOrganizationUserInfoResponse"/></returns>
        public DescribeOrganizationUserInfoResponse DescribeOrganizationUserInfoSync(DescribeOrganizationUserInfoRequest req)
        {
            return InternalRequestAsync<DescribeOrganizationUserInfoResponse>(req, "DescribeOrganizationUserInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 资产列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOtherCloudAssetsRequest"/></param>
        /// <returns><see cref="DescribeOtherCloudAssetsResponse"/></returns>
        public Task<DescribeOtherCloudAssetsResponse> DescribeOtherCloudAssets(DescribeOtherCloudAssetsRequest req)
        {
            return InternalRequestAsync<DescribeOtherCloudAssetsResponse>(req, "DescribeOtherCloudAssets");
        }

        /// <summary>
        /// 资产列表
        /// </summary>
        /// <param name="req"><see cref="DescribeOtherCloudAssetsRequest"/></param>
        /// <returns><see cref="DescribeOtherCloudAssetsResponse"/></returns>
        public DescribeOtherCloudAssetsResponse DescribeOtherCloudAssetsSync(DescribeOtherCloudAssetsRequest req)
        {
            return InternalRequestAsync<DescribeOtherCloudAssetsResponse>(req, "DescribeOtherCloudAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 按日期查看策略命中详情
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyHitDataRequest"/></param>
        /// <returns><see cref="DescribePolicyHitDataResponse"/></returns>
        public Task<DescribePolicyHitDataResponse> DescribePolicyHitData(DescribePolicyHitDataRequest req)
        {
            return InternalRequestAsync<DescribePolicyHitDataResponse>(req, "DescribePolicyHitData");
        }

        /// <summary>
        /// 按日期查看策略命中详情
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyHitDataRequest"/></param>
        /// <returns><see cref="DescribePolicyHitDataResponse"/></returns>
        public DescribePolicyHitDataResponse DescribePolicyHitDataSync(DescribePolicyHitDataRequest req)
        {
            return InternalRequestAsync<DescribePolicyHitDataResponse>(req, "DescribePolicyHitData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ip公网列表
        /// </summary>
        /// <param name="req"><see cref="DescribePublicIpAssetsRequest"/></param>
        /// <returns><see cref="DescribePublicIpAssetsResponse"/></returns>
        public Task<DescribePublicIpAssetsResponse> DescribePublicIpAssets(DescribePublicIpAssetsRequest req)
        {
            return InternalRequestAsync<DescribePublicIpAssetsResponse>(req, "DescribePublicIpAssets");
        }

        /// <summary>
        /// ip公网列表
        /// </summary>
        /// <param name="req"><see cref="DescribePublicIpAssetsRequest"/></param>
        /// <returns><see cref="DescribePublicIpAssetsResponse"/></returns>
        public DescribePublicIpAssetsResponse DescribePublicIpAssetsSync(DescribePublicIpAssetsRequest req)
        {
            return InternalRequestAsync<DescribePublicIpAssetsResponse>(req, "DescribePublicIpAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 仓库镜像列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRepositoryImageAssetsRequest"/></param>
        /// <returns><see cref="DescribeRepositoryImageAssetsResponse"/></returns>
        public Task<DescribeRepositoryImageAssetsResponse> DescribeRepositoryImageAssets(DescribeRepositoryImageAssetsRequest req)
        {
            return InternalRequestAsync<DescribeRepositoryImageAssetsResponse>(req, "DescribeRepositoryImageAssets");
        }

        /// <summary>
        /// 仓库镜像列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRepositoryImageAssetsRequest"/></param>
        /// <returns><see cref="DescribeRepositoryImageAssetsResponse"/></returns>
        public DescribeRepositoryImageAssetsResponse DescribeRepositoryImageAssetsSync(DescribeRepositoryImageAssetsRequest req)
        {
            return InternalRequestAsync<DescribeRepositoryImageAssetsResponse>(req, "DescribeRepositoryImageAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看风险关联的存储桶信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskBucketListRequest"/></param>
        /// <returns><see cref="DescribeRiskBucketListResponse"/></returns>
        public Task<DescribeRiskBucketListResponse> DescribeRiskBucketList(DescribeRiskBucketListRequest req)
        {
            return InternalRequestAsync<DescribeRiskBucketListResponse>(req, "DescribeRiskBucketList");
        }

        /// <summary>
        /// 查看风险关联的存储桶信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskBucketListRequest"/></param>
        /// <returns><see cref="DescribeRiskBucketListResponse"/></returns>
        public DescribeRiskBucketListResponse DescribeRiskBucketListSync(DescribeRiskBucketListRequest req)
        {
            return InternalRequestAsync<DescribeRiskBucketListResponse>(req, "DescribeRiskBucketList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取风险调用记录列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCallRecordRequest"/></param>
        /// <returns><see cref="DescribeRiskCallRecordResponse"/></returns>
        public Task<DescribeRiskCallRecordResponse> DescribeRiskCallRecord(DescribeRiskCallRecordRequest req)
        {
            return InternalRequestAsync<DescribeRiskCallRecordResponse>(req, "DescribeRiskCallRecord");
        }

        /// <summary>
        /// 获取风险调用记录列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCallRecordRequest"/></param>
        /// <returns><see cref="DescribeRiskCallRecordResponse"/></returns>
        public DescribeRiskCallRecordResponse DescribeRiskCallRecordSync(DescribeRiskCallRecordRequest req)
        {
            return InternalRequestAsync<DescribeRiskCallRecordResponse>(req, "DescribeRiskCallRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取资产视角的配置风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterAssetViewCFGRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterAssetViewCFGRiskListResponse"/></returns>
        public Task<DescribeRiskCenterAssetViewCFGRiskListResponse> DescribeRiskCenterAssetViewCFGRiskList(DescribeRiskCenterAssetViewCFGRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterAssetViewCFGRiskListResponse>(req, "DescribeRiskCenterAssetViewCFGRiskList");
        }

        /// <summary>
        /// 获取资产视角的配置风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterAssetViewCFGRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterAssetViewCFGRiskListResponse"/></returns>
        public DescribeRiskCenterAssetViewCFGRiskListResponse DescribeRiskCenterAssetViewCFGRiskListSync(DescribeRiskCenterAssetViewCFGRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterAssetViewCFGRiskListResponse>(req, "DescribeRiskCenterAssetViewCFGRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取资产视角的端口风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterAssetViewPortRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterAssetViewPortRiskListResponse"/></returns>
        public Task<DescribeRiskCenterAssetViewPortRiskListResponse> DescribeRiskCenterAssetViewPortRiskList(DescribeRiskCenterAssetViewPortRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterAssetViewPortRiskListResponse>(req, "DescribeRiskCenterAssetViewPortRiskList");
        }

        /// <summary>
        /// 获取资产视角的端口风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterAssetViewPortRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterAssetViewPortRiskListResponse"/></returns>
        public DescribeRiskCenterAssetViewPortRiskListResponse DescribeRiskCenterAssetViewPortRiskListSync(DescribeRiskCenterAssetViewPortRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterAssetViewPortRiskListResponse>(req, "DescribeRiskCenterAssetViewPortRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取资产视角的漏洞风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterAssetViewVULRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterAssetViewVULRiskListResponse"/></returns>
        public Task<DescribeRiskCenterAssetViewVULRiskListResponse> DescribeRiskCenterAssetViewVULRiskList(DescribeRiskCenterAssetViewVULRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterAssetViewVULRiskListResponse>(req, "DescribeRiskCenterAssetViewVULRiskList");
        }

        /// <summary>
        /// 获取资产视角的漏洞风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterAssetViewVULRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterAssetViewVULRiskListResponse"/></returns>
        public DescribeRiskCenterAssetViewVULRiskListResponse DescribeRiskCenterAssetViewVULRiskListSync(DescribeRiskCenterAssetViewVULRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterAssetViewVULRiskListResponse>(req, "DescribeRiskCenterAssetViewVULRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取资产视角的弱口令风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterAssetViewWeakPasswordRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterAssetViewWeakPasswordRiskListResponse"/></returns>
        public Task<DescribeRiskCenterAssetViewWeakPasswordRiskListResponse> DescribeRiskCenterAssetViewWeakPasswordRiskList(DescribeRiskCenterAssetViewWeakPasswordRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterAssetViewWeakPasswordRiskListResponse>(req, "DescribeRiskCenterAssetViewWeakPasswordRiskList");
        }

        /// <summary>
        /// 获取资产视角的弱口令风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterAssetViewWeakPasswordRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterAssetViewWeakPasswordRiskListResponse"/></returns>
        public DescribeRiskCenterAssetViewWeakPasswordRiskListResponse DescribeRiskCenterAssetViewWeakPasswordRiskListSync(DescribeRiskCenterAssetViewWeakPasswordRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterAssetViewWeakPasswordRiskListResponse>(req, "DescribeRiskCenterAssetViewWeakPasswordRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取配置视角的配置风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterCFGViewCFGRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterCFGViewCFGRiskListResponse"/></returns>
        public Task<DescribeRiskCenterCFGViewCFGRiskListResponse> DescribeRiskCenterCFGViewCFGRiskList(DescribeRiskCenterCFGViewCFGRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterCFGViewCFGRiskListResponse>(req, "DescribeRiskCenterCFGViewCFGRiskList");
        }

        /// <summary>
        /// 获取配置视角的配置风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterCFGViewCFGRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterCFGViewCFGRiskListResponse"/></returns>
        public DescribeRiskCenterCFGViewCFGRiskListResponse DescribeRiskCenterCFGViewCFGRiskListSync(DescribeRiskCenterCFGViewCFGRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterCFGViewCFGRiskListResponse>(req, "DescribeRiskCenterCFGViewCFGRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取端口视角的端口风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterPortViewPortRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterPortViewPortRiskListResponse"/></returns>
        public Task<DescribeRiskCenterPortViewPortRiskListResponse> DescribeRiskCenterPortViewPortRiskList(DescribeRiskCenterPortViewPortRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterPortViewPortRiskListResponse>(req, "DescribeRiskCenterPortViewPortRiskList");
        }

        /// <summary>
        /// 获取端口视角的端口风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterPortViewPortRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterPortViewPortRiskListResponse"/></returns>
        public DescribeRiskCenterPortViewPortRiskListResponse DescribeRiskCenterPortViewPortRiskListSync(DescribeRiskCenterPortViewPortRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterPortViewPortRiskListResponse>(req, "DescribeRiskCenterPortViewPortRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取风险服务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterServerRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterServerRiskListResponse"/></returns>
        public Task<DescribeRiskCenterServerRiskListResponse> DescribeRiskCenterServerRiskList(DescribeRiskCenterServerRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterServerRiskListResponse>(req, "DescribeRiskCenterServerRiskList");
        }

        /// <summary>
        /// 获取风险服务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterServerRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterServerRiskListResponse"/></returns>
        public DescribeRiskCenterServerRiskListResponse DescribeRiskCenterServerRiskListSync(DescribeRiskCenterServerRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterServerRiskListResponse>(req, "DescribeRiskCenterServerRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取漏洞视角的漏洞风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterVULViewVULRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterVULViewVULRiskListResponse"/></returns>
        public Task<DescribeRiskCenterVULViewVULRiskListResponse> DescribeRiskCenterVULViewVULRiskList(DescribeRiskCenterVULViewVULRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterVULViewVULRiskListResponse>(req, "DescribeRiskCenterVULViewVULRiskList");
        }

        /// <summary>
        /// 获取漏洞视角的漏洞风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterVULViewVULRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterVULViewVULRiskListResponse"/></returns>
        public DescribeRiskCenterVULViewVULRiskListResponse DescribeRiskCenterVULViewVULRiskListSync(DescribeRiskCenterVULViewVULRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterVULViewVULRiskListResponse>(req, "DescribeRiskCenterVULViewVULRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取内容风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterWebsiteRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterWebsiteRiskListResponse"/></returns>
        public Task<DescribeRiskCenterWebsiteRiskListResponse> DescribeRiskCenterWebsiteRiskList(DescribeRiskCenterWebsiteRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterWebsiteRiskListResponse>(req, "DescribeRiskCenterWebsiteRiskList");
        }

        /// <summary>
        /// 获取内容风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterWebsiteRiskListRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterWebsiteRiskListResponse"/></returns>
        public DescribeRiskCenterWebsiteRiskListResponse DescribeRiskCenterWebsiteRiskListSync(DescribeRiskCenterWebsiteRiskListRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterWebsiteRiskListResponse>(req, "DescribeRiskCenterWebsiteRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 风险详情列表示例
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskDetailListRequest"/></param>
        /// <returns><see cref="DescribeRiskDetailListResponse"/></returns>
        public Task<DescribeRiskDetailListResponse> DescribeRiskDetailList(DescribeRiskDetailListRequest req)
        {
            return InternalRequestAsync<DescribeRiskDetailListResponse>(req, "DescribeRiskDetailList");
        }

        /// <summary>
        /// 风险详情列表示例
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskDetailListRequest"/></param>
        /// <returns><see cref="DescribeRiskDetailListResponse"/></returns>
        public DescribeRiskDetailListResponse DescribeRiskDetailListSync(DescribeRiskDetailListRequest req)
        {
            return InternalRequestAsync<DescribeRiskDetailListResponse>(req, "DescribeRiskDetailList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取风险项视角列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskItemListRequest"/></param>
        /// <returns><see cref="DescribeRiskItemListResponse"/></returns>
        public Task<DescribeRiskItemListResponse> DescribeRiskItemList(DescribeRiskItemListRequest req)
        {
            return InternalRequestAsync<DescribeRiskItemListResponse>(req, "DescribeRiskItemList");
        }

        /// <summary>
        /// 获取风险项视角列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskItemListRequest"/></param>
        /// <returns><see cref="DescribeRiskItemListResponse"/></returns>
        public DescribeRiskItemListResponse DescribeRiskItemListSync(DescribeRiskItemListRequest req)
        {
            return InternalRequestAsync<DescribeRiskItemListResponse>(req, "DescribeRiskItemList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询风险规则详情示例
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskRuleDetailRequest"/></param>
        /// <returns><see cref="DescribeRiskRuleDetailResponse"/></returns>
        public Task<DescribeRiskRuleDetailResponse> DescribeRiskRuleDetail(DescribeRiskRuleDetailRequest req)
        {
            return InternalRequestAsync<DescribeRiskRuleDetailResponse>(req, "DescribeRiskRuleDetail");
        }

        /// <summary>
        /// 查询风险规则详情示例
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskRuleDetailRequest"/></param>
        /// <returns><see cref="DescribeRiskRuleDetailResponse"/></returns>
        public DescribeRiskRuleDetailResponse DescribeRiskRuleDetailSync(DescribeRiskRuleDetailRequest req)
        {
            return InternalRequestAsync<DescribeRiskRuleDetailResponse>(req, "DescribeRiskRuleDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 高级配置风险规则列表示例
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskRulesRequest"/></param>
        /// <returns><see cref="DescribeRiskRulesResponse"/></returns>
        public Task<DescribeRiskRulesResponse> DescribeRiskRules(DescribeRiskRulesRequest req)
        {
            return InternalRequestAsync<DescribeRiskRulesResponse>(req, "DescribeRiskRules");
        }

        /// <summary>
        /// 高级配置风险规则列表示例
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskRulesRequest"/></param>
        /// <returns><see cref="DescribeRiskRulesResponse"/></returns>
        public DescribeRiskRulesResponse DescribeRiskRulesSync(DescribeRiskRulesRequest req)
        {
            return InternalRequestAsync<DescribeRiskRulesResponse>(req, "DescribeRiskRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看风险趋势图
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskTrendDataRequest"/></param>
        /// <returns><see cref="DescribeRiskTrendDataResponse"/></returns>
        public Task<DescribeRiskTrendDataResponse> DescribeRiskTrendData(DescribeRiskTrendDataRequest req)
        {
            return InternalRequestAsync<DescribeRiskTrendDataResponse>(req, "DescribeRiskTrendData");
        }

        /// <summary>
        /// 查看风险趋势图
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskTrendDataRequest"/></param>
        /// <returns><see cref="DescribeRiskTrendDataResponse"/></returns>
        public DescribeRiskTrendDataResponse DescribeRiskTrendDataSync(DescribeRiskTrendDataRequest req)
        {
            return InternalRequestAsync<DescribeRiskTrendDataResponse>(req, "DescribeRiskTrendData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取扫描报告列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScanReportListRequest"/></param>
        /// <returns><see cref="DescribeScanReportListResponse"/></returns>
        public Task<DescribeScanReportListResponse> DescribeScanReportList(DescribeScanReportListRequest req)
        {
            return InternalRequestAsync<DescribeScanReportListResponse>(req, "DescribeScanReportList");
        }

        /// <summary>
        /// 获取扫描报告列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScanReportListRequest"/></param>
        /// <returns><see cref="DescribeScanReportListResponse"/></returns>
        public DescribeScanReportListResponse DescribeScanReportListSync(DescribeScanReportListRequest req)
        {
            return InternalRequestAsync<DescribeScanReportListResponse>(req, "DescribeScanReportList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询云边界分析扫描结果统计信息
        /// </summary>
        /// <param name="req"><see cref="DescribeScanStatisticRequest"/></param>
        /// <returns><see cref="DescribeScanStatisticResponse"/></returns>
        public Task<DescribeScanStatisticResponse> DescribeScanStatistic(DescribeScanStatisticRequest req)
        {
            return InternalRequestAsync<DescribeScanStatisticResponse>(req, "DescribeScanStatistic");
        }

        /// <summary>
        /// 查询云边界分析扫描结果统计信息
        /// </summary>
        /// <param name="req"><see cref="DescribeScanStatisticRequest"/></param>
        /// <returns><see cref="DescribeScanStatisticResponse"/></returns>
        public DescribeScanStatisticResponse DescribeScanStatisticSync(DescribeScanStatisticRequest req)
        {
            return InternalRequestAsync<DescribeScanStatisticResponse>(req, "DescribeScanStatistic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取扫描任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScanTaskListRequest"/></param>
        /// <returns><see cref="DescribeScanTaskListResponse"/></returns>
        public Task<DescribeScanTaskListResponse> DescribeScanTaskList(DescribeScanTaskListRequest req)
        {
            return InternalRequestAsync<DescribeScanTaskListResponse>(req, "DescribeScanTaskList");
        }

        /// <summary>
        /// 获取扫描任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScanTaskListRequest"/></param>
        /// <returns><see cref="DescribeScanTaskListResponse"/></returns>
        public DescribeScanTaskListResponse DescribeScanTaskListSync(DescribeScanTaskListRequest req)
        {
            return InternalRequestAsync<DescribeScanTaskListResponse>(req, "DescribeScanTaskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 立体防护中心查询漏洞信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSearchBugInfoRequest"/></param>
        /// <returns><see cref="DescribeSearchBugInfoResponse"/></returns>
        public Task<DescribeSearchBugInfoResponse> DescribeSearchBugInfo(DescribeSearchBugInfoRequest req)
        {
            return InternalRequestAsync<DescribeSearchBugInfoResponse>(req, "DescribeSearchBugInfo");
        }

        /// <summary>
        /// 立体防护中心查询漏洞信息
        /// </summary>
        /// <param name="req"><see cref="DescribeSearchBugInfoRequest"/></param>
        /// <returns><see cref="DescribeSearchBugInfoResponse"/></returns>
        public DescribeSearchBugInfoResponse DescribeSearchBugInfoSync(DescribeSearchBugInfoRequest req)
        {
            return InternalRequestAsync<DescribeSearchBugInfoResponse>(req, "DescribeSearchBugInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 Skill 安全检测计费信息，包括订单状态、总配额、已消耗配额、到期时间、支付模式等。无订单时返回零值（仅含 TimeNow 和 BetaEndTime）。试用订单通过 ModifyTrialStatus(Module=9) 领取，正式订单通过计费系统创建。
        /// </summary>
        /// <param name="req"><see cref="DescribeSkillScanPayInfoRequest"/></param>
        /// <returns><see cref="DescribeSkillScanPayInfoResponse"/></returns>
        public Task<DescribeSkillScanPayInfoResponse> DescribeSkillScanPayInfo(DescribeSkillScanPayInfoRequest req)
        {
            return InternalRequestAsync<DescribeSkillScanPayInfoResponse>(req, "DescribeSkillScanPayInfo");
        }

        /// <summary>
        /// 查询 Skill 安全检测计费信息，包括订单状态、总配额、已消耗配额、到期时间、支付模式等。无订单时返回零值（仅含 TimeNow 和 BetaEndTime）。试用订单通过 ModifyTrialStatus(Module=9) 领取，正式订单通过计费系统创建。
        /// </summary>
        /// <param name="req"><see cref="DescribeSkillScanPayInfoRequest"/></param>
        /// <returns><see cref="DescribeSkillScanPayInfoResponse"/></returns>
        public DescribeSkillScanPayInfoResponse DescribeSkillScanPayInfoSync(DescribeSkillScanPayInfoRequest req)
        {
            return InternalRequestAsync<DescribeSkillScanPayInfoResponse>(req, "DescribeSkillScanPayInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 Skill 安全检测结果。调用 CreateSkillScan 成功后使用返回的 ContentHash + EngineVersion 轮询本接口获取结果。上传成功后建议5分钟后首次轮询，如未检测完成之后每隔1分钟轮询一次。响应通过 Status 字段区分四种状态：检测完成（SUCCESS）、检测中（SCANNING）、无记录（NOT_FOUND）、检测失败（FAILED）。注意：检测结果保留90天，超期后将返回 NOT_FOUND。
        /// </summary>
        /// <param name="req"><see cref="DescribeSkillScanResultRequest"/></param>
        /// <returns><see cref="DescribeSkillScanResultResponse"/></returns>
        public Task<DescribeSkillScanResultResponse> DescribeSkillScanResult(DescribeSkillScanResultRequest req)
        {
            return InternalRequestAsync<DescribeSkillScanResultResponse>(req, "DescribeSkillScanResult");
        }

        /// <summary>
        /// 查询 Skill 安全检测结果。调用 CreateSkillScan 成功后使用返回的 ContentHash + EngineVersion 轮询本接口获取结果。上传成功后建议5分钟后首次轮询，如未检测完成之后每隔1分钟轮询一次。响应通过 Status 字段区分四种状态：检测完成（SUCCESS）、检测中（SCANNING）、无记录（NOT_FOUND）、检测失败（FAILED）。注意：检测结果保留90天，超期后将返回 NOT_FOUND。
        /// </summary>
        /// <param name="req"><see cref="DescribeSkillScanResultRequest"/></param>
        /// <returns><see cref="DescribeSkillScanResultResponse"/></returns>
        public DescribeSkillScanResultResponse DescribeSkillScanResultSync(DescribeSkillScanResultRequest req)
        {
            return InternalRequestAsync<DescribeSkillScanResultResponse>(req, "DescribeSkillScanResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取用户访问密钥资产列表（源IP视角）
        /// </summary>
        /// <param name="req"><see cref="DescribeSourceIPAssetRequest"/></param>
        /// <returns><see cref="DescribeSourceIPAssetResponse"/></returns>
        public Task<DescribeSourceIPAssetResponse> DescribeSourceIPAsset(DescribeSourceIPAssetRequest req)
        {
            return InternalRequestAsync<DescribeSourceIPAssetResponse>(req, "DescribeSourceIPAsset");
        }

        /// <summary>
        /// 获取用户访问密钥资产列表（源IP视角）
        /// </summary>
        /// <param name="req"><see cref="DescribeSourceIPAssetRequest"/></param>
        /// <returns><see cref="DescribeSourceIPAssetResponse"/></returns>
        public DescribeSourceIPAssetResponse DescribeSourceIPAssetSync(DescribeSourceIPAssetRequest req)
        {
            return InternalRequestAsync<DescribeSourceIPAssetResponse>(req, "DescribeSourceIPAsset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集团的子账号列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSubUserInfoRequest"/></param>
        /// <returns><see cref="DescribeSubUserInfoResponse"/></returns>
        public Task<DescribeSubUserInfoResponse> DescribeSubUserInfo(DescribeSubUserInfoRequest req)
        {
            return InternalRequestAsync<DescribeSubUserInfoResponse>(req, "DescribeSubUserInfo");
        }

        /// <summary>
        /// 查询集团的子账号列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSubUserInfoRequest"/></param>
        /// <returns><see cref="DescribeSubUserInfoResponse"/></returns>
        public DescribeSubUserInfoResponse DescribeSubUserInfoSync(DescribeSubUserInfoRequest req)
        {
            return InternalRequestAsync<DescribeSubUserInfoResponse>(req, "DescribeSubUserInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取子网列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSubnetAssetsRequest"/></param>
        /// <returns><see cref="DescribeSubnetAssetsResponse"/></returns>
        public Task<DescribeSubnetAssetsResponse> DescribeSubnetAssets(DescribeSubnetAssetsRequest req)
        {
            return InternalRequestAsync<DescribeSubnetAssetsResponse>(req, "DescribeSubnetAssets");
        }

        /// <summary>
        /// 获取子网列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSubnetAssetsRequest"/></param>
        /// <returns><see cref="DescribeSubnetAssetsResponse"/></returns>
        public DescribeSubnetAssetsResponse DescribeSubnetAssetsSync(DescribeSubnetAssetsRequest req)
        {
            return InternalRequestAsync<DescribeSubnetAssetsResponse>(req, "DescribeSubnetAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取任务扫描报告列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskLogListRequest"/></param>
        /// <returns><see cref="DescribeTaskLogListResponse"/></returns>
        public Task<DescribeTaskLogListResponse> DescribeTaskLogList(DescribeTaskLogListRequest req)
        {
            return InternalRequestAsync<DescribeTaskLogListResponse>(req, "DescribeTaskLogList");
        }

        /// <summary>
        /// 获取任务扫描报告列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskLogListRequest"/></param>
        /// <returns><see cref="DescribeTaskLogListResponse"/></returns>
        public DescribeTaskLogListResponse DescribeTaskLogListSync(DescribeTaskLogListRequest req)
        {
            return InternalRequestAsync<DescribeTaskLogListResponse>(req, "DescribeTaskLogList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取报告下载的临时链接
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskLogURLRequest"/></param>
        /// <returns><see cref="DescribeTaskLogURLResponse"/></returns>
        public Task<DescribeTaskLogURLResponse> DescribeTaskLogURL(DescribeTaskLogURLRequest req)
        {
            return InternalRequestAsync<DescribeTaskLogURLResponse>(req, "DescribeTaskLogURL");
        }

        /// <summary>
        /// 获取报告下载的临时链接
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskLogURLRequest"/></param>
        /// <returns><see cref="DescribeTaskLogURLResponse"/></returns>
        public DescribeTaskLogURLResponse DescribeTaskLogURLSync(DescribeTaskLogURLRequest req)
        {
            return InternalRequestAsync<DescribeTaskLogURLResponse>(req, "DescribeTaskLogURL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询TOP攻击信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTopAttackInfoRequest"/></param>
        /// <returns><see cref="DescribeTopAttackInfoResponse"/></returns>
        public Task<DescribeTopAttackInfoResponse> DescribeTopAttackInfo(DescribeTopAttackInfoRequest req)
        {
            return InternalRequestAsync<DescribeTopAttackInfoResponse>(req, "DescribeTopAttackInfo");
        }

        /// <summary>
        /// 查询TOP攻击信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTopAttackInfoRequest"/></param>
        /// <returns><see cref="DescribeTopAttackInfoResponse"/></returns>
        public DescribeTopAttackInfoResponse DescribeTopAttackInfoSync(DescribeTopAttackInfoRequest req)
        {
            return InternalRequestAsync<DescribeTopAttackInfoResponse>(req, "DescribeTopAttackInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询用户行为分析策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUebaRuleRequest"/></param>
        /// <returns><see cref="DescribeUebaRuleResponse"/></returns>
        public Task<DescribeUebaRuleResponse> DescribeUebaRule(DescribeUebaRuleRequest req)
        {
            return InternalRequestAsync<DescribeUebaRuleResponse>(req, "DescribeUebaRule");
        }

        /// <summary>
        /// 查询用户行为分析策略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUebaRuleRequest"/></param>
        /// <returns><see cref="DescribeUebaRuleResponse"/></returns>
        public DescribeUebaRuleResponse DescribeUebaRuleSync(DescribeUebaRuleRequest req)
        {
            return InternalRequestAsync<DescribeUebaRuleResponse>(req, "DescribeUebaRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取账号调用记录列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserCallRecordRequest"/></param>
        /// <returns><see cref="DescribeUserCallRecordResponse"/></returns>
        public Task<DescribeUserCallRecordResponse> DescribeUserCallRecord(DescribeUserCallRecordRequest req)
        {
            return InternalRequestAsync<DescribeUserCallRecordResponse>(req, "DescribeUserCallRecord");
        }

        /// <summary>
        /// 获取账号调用记录列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserCallRecordRequest"/></param>
        /// <returns><see cref="DescribeUserCallRecordResponse"/></returns>
        public DescribeUserCallRecordResponse DescribeUserCallRecordSync(DescribeUserCallRecordRequest req)
        {
            return InternalRequestAsync<DescribeUserCallRecordResponse>(req, "DescribeUserCallRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取账号dspm信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserDspmInfoListRequest"/></param>
        /// <returns><see cref="DescribeUserDspmInfoListResponse"/></returns>
        public Task<DescribeUserDspmInfoListResponse> DescribeUserDspmInfoList(DescribeUserDspmInfoListRequest req)
        {
            return InternalRequestAsync<DescribeUserDspmInfoListResponse>(req, "DescribeUserDspmInfoList");
        }

        /// <summary>
        /// 获取账号dspm信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserDspmInfoListRequest"/></param>
        /// <returns><see cref="DescribeUserDspmInfoListResponse"/></returns>
        public DescribeUserDspmInfoListResponse DescribeUserDspmInfoListSync(DescribeUserDspmInfoListRequest req)
        {
            return InternalRequestAsync<DescribeUserDspmInfoListResponse>(req, "DescribeUserDspmInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新安全中心风险中心-漏洞列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVULListRequest"/></param>
        /// <returns><see cref="DescribeVULListResponse"/></returns>
        public Task<DescribeVULListResponse> DescribeVULList(DescribeVULListRequest req)
        {
            return InternalRequestAsync<DescribeVULListResponse>(req, "DescribeVULList");
        }

        /// <summary>
        /// 新安全中心风险中心-漏洞列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVULListRequest"/></param>
        /// <returns><see cref="DescribeVULListResponse"/></returns>
        public DescribeVULListResponse DescribeVULListSync(DescribeVULListRequest req)
        {
            return InternalRequestAsync<DescribeVULListResponse>(req, "DescribeVULList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询漏洞风险高级配置
        /// </summary>
        /// <param name="req"><see cref="DescribeVULRiskAdvanceCFGListRequest"/></param>
        /// <returns><see cref="DescribeVULRiskAdvanceCFGListResponse"/></returns>
        public Task<DescribeVULRiskAdvanceCFGListResponse> DescribeVULRiskAdvanceCFGList(DescribeVULRiskAdvanceCFGListRequest req)
        {
            return InternalRequestAsync<DescribeVULRiskAdvanceCFGListResponse>(req, "DescribeVULRiskAdvanceCFGList");
        }

        /// <summary>
        /// 查询漏洞风险高级配置
        /// </summary>
        /// <param name="req"><see cref="DescribeVULRiskAdvanceCFGListRequest"/></param>
        /// <returns><see cref="DescribeVULRiskAdvanceCFGListResponse"/></returns>
        public DescribeVULRiskAdvanceCFGListResponse DescribeVULRiskAdvanceCFGListSync(DescribeVULRiskAdvanceCFGListRequest req)
        {
            return InternalRequestAsync<DescribeVULRiskAdvanceCFGListResponse>(req, "DescribeVULRiskAdvanceCFGList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取漏洞展开详情
        /// </summary>
        /// <param name="req"><see cref="DescribeVULRiskDetailRequest"/></param>
        /// <returns><see cref="DescribeVULRiskDetailResponse"/></returns>
        public Task<DescribeVULRiskDetailResponse> DescribeVULRiskDetail(DescribeVULRiskDetailRequest req)
        {
            return InternalRequestAsync<DescribeVULRiskDetailResponse>(req, "DescribeVULRiskDetail");
        }

        /// <summary>
        /// 获取漏洞展开详情
        /// </summary>
        /// <param name="req"><see cref="DescribeVULRiskDetailRequest"/></param>
        /// <returns><see cref="DescribeVULRiskDetailResponse"/></returns>
        public DescribeVULRiskDetailResponse DescribeVULRiskDetailSync(DescribeVULRiskDetailRequest req)
        {
            return InternalRequestAsync<DescribeVULRiskDetailResponse>(req, "DescribeVULRiskDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取vpc列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcAssetsRequest"/></param>
        /// <returns><see cref="DescribeVpcAssetsResponse"/></returns>
        public Task<DescribeVpcAssetsResponse> DescribeVpcAssets(DescribeVpcAssetsRequest req)
        {
            return InternalRequestAsync<DescribeVpcAssetsResponse>(req, "DescribeVpcAssets");
        }

        /// <summary>
        /// 获取vpc列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVpcAssetsRequest"/></param>
        /// <returns><see cref="DescribeVpcAssetsResponse"/></returns>
        public DescribeVpcAssetsResponse DescribeVpcAssetsSync(DescribeVpcAssetsRequest req)
        {
            return InternalRequestAsync<DescribeVpcAssetsResponse>(req, "DescribeVpcAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询云边界分析-暴露路径下主机节点的漏洞列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulRiskListRequest"/></param>
        /// <returns><see cref="DescribeVulRiskListResponse"/></returns>
        public Task<DescribeVulRiskListResponse> DescribeVulRiskList(DescribeVulRiskListRequest req)
        {
            return InternalRequestAsync<DescribeVulRiskListResponse>(req, "DescribeVulRiskList");
        }

        /// <summary>
        /// 查询云边界分析-暴露路径下主机节点的漏洞列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulRiskListRequest"/></param>
        /// <returns><see cref="DescribeVulRiskListResponse"/></returns>
        public DescribeVulRiskListResponse DescribeVulRiskListSync(DescribeVulRiskListRequest req)
        {
            return InternalRequestAsync<DescribeVulRiskListResponse>(req, "DescribeVulRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取漏洞视角的漏洞风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulViewVulRiskListRequest"/></param>
        /// <returns><see cref="DescribeVulViewVulRiskListResponse"/></returns>
        public Task<DescribeVulViewVulRiskListResponse> DescribeVulViewVulRiskList(DescribeVulViewVulRiskListRequest req)
        {
            return InternalRequestAsync<DescribeVulViewVulRiskListResponse>(req, "DescribeVulViewVulRiskList");
        }

        /// <summary>
        /// 获取漏洞视角的漏洞风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulViewVulRiskListRequest"/></param>
        /// <returns><see cref="DescribeVulViewVulRiskListResponse"/></returns>
        public DescribeVulViewVulRiskListResponse DescribeVulViewVulRiskListSync(DescribeVulViewVulRiskListRequest req)
        {
            return InternalRequestAsync<DescribeVulViewVulRiskListResponse>(req, "DescribeVulViewVulRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 下载导出日志
        /// </summary>
        /// <param name="req"><see cref="DownloadDspmExportLogRequest"/></param>
        /// <returns><see cref="DownloadDspmExportLogResponse"/></returns>
        public Task<DownloadDspmExportLogResponse> DownloadDspmExportLog(DownloadDspmExportLogRequest req)
        {
            return InternalRequestAsync<DownloadDspmExportLogResponse>(req, "DownloadDspmExportLog");
        }

        /// <summary>
        /// 下载导出日志
        /// </summary>
        /// <param name="req"><see cref="DownloadDspmExportLogRequest"/></param>
        /// <returns><see cref="DownloadDspmExportLogResponse"/></returns>
        public DownloadDspmExportLogResponse DownloadDspmExportLogSync(DownloadDspmExportLogRequest req)
        {
            return InternalRequestAsync<DownloadDspmExportLogResponse>(req, "DownloadDspmExportLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改AI-Link智链引擎配置
        /// </summary>
        /// <param name="req"><see cref="ModifyAILinkSettingRequest"/></param>
        /// <returns><see cref="ModifyAILinkSettingResponse"/></returns>
        public Task<ModifyAILinkSettingResponse> ModifyAILinkSetting(ModifyAILinkSettingRequest req)
        {
            return InternalRequestAsync<ModifyAILinkSettingResponse>(req, "ModifyAILinkSetting");
        }

        /// <summary>
        /// 修改AI-Link智链引擎配置
        /// </summary>
        /// <param name="req"><see cref="ModifyAILinkSettingRequest"/></param>
        /// <returns><see cref="ModifyAILinkSettingResponse"/></returns>
        public ModifyAILinkSettingResponse ModifyAILinkSettingSync(ModifyAILinkSettingRequest req)
        {
            return InternalRequestAsync<ModifyAILinkSettingResponse>(req, "ModifyAILinkSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改或者更改处置状态
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmRiskStatusRequest"/></param>
        /// <returns><see cref="ModifyAlarmRiskStatusResponse"/></returns>
        public Task<ModifyAlarmRiskStatusResponse> ModifyAlarmRiskStatus(ModifyAlarmRiskStatusRequest req)
        {
            return InternalRequestAsync<ModifyAlarmRiskStatusResponse>(req, "ModifyAlarmRiskStatus");
        }

        /// <summary>
        /// 修改或者更改处置状态
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmRiskStatusRequest"/></param>
        /// <returns><see cref="ModifyAlarmRiskStatusResponse"/></returns>
        public ModifyAlarmRiskStatusResponse ModifyAlarmRiskStatusSync(ModifyAlarmRiskStatusRequest req)
        {
            return InternalRequestAsync<ModifyAlarmRiskStatusResponse>(req, "ModifyAlarmRiskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改存储桶监测状态
        /// </summary>
        /// <param name="req"><see cref="ModifyCosAuditBucketMonitorStatusRequest"/></param>
        /// <returns><see cref="ModifyCosAuditBucketMonitorStatusResponse"/></returns>
        public Task<ModifyCosAuditBucketMonitorStatusResponse> ModifyCosAuditBucketMonitorStatus(ModifyCosAuditBucketMonitorStatusRequest req)
        {
            return InternalRequestAsync<ModifyCosAuditBucketMonitorStatusResponse>(req, "ModifyCosAuditBucketMonitorStatus");
        }

        /// <summary>
        /// 修改存储桶监测状态
        /// </summary>
        /// <param name="req"><see cref="ModifyCosAuditBucketMonitorStatusRequest"/></param>
        /// <returns><see cref="ModifyCosAuditBucketMonitorStatusResponse"/></returns>
        public ModifyCosAuditBucketMonitorStatusResponse ModifyCosAuditBucketMonitorStatusSync(ModifyCosAuditBucketMonitorStatusRequest req)
        {
            return InternalRequestAsync<ModifyCosAuditBucketMonitorStatusResponse>(req, "ModifyCosAuditBucketMonitorStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改cos审计监测账号
        /// </summary>
        /// <param name="req"><see cref="ModifyCosAuditMonitorAccountRequest"/></param>
        /// <returns><see cref="ModifyCosAuditMonitorAccountResponse"/></returns>
        public Task<ModifyCosAuditMonitorAccountResponse> ModifyCosAuditMonitorAccount(ModifyCosAuditMonitorAccountRequest req)
        {
            return InternalRequestAsync<ModifyCosAuditMonitorAccountResponse>(req, "ModifyCosAuditMonitorAccount");
        }

        /// <summary>
        /// 修改cos审计监测账号
        /// </summary>
        /// <param name="req"><see cref="ModifyCosAuditMonitorAccountRequest"/></param>
        /// <returns><see cref="ModifyCosAuditMonitorAccountResponse"/></returns>
        public ModifyCosAuditMonitorAccountResponse ModifyCosAuditMonitorAccountSync(ModifyCosAuditMonitorAccountRequest req)
        {
            return InternalRequestAsync<ModifyCosAuditMonitorAccountResponse>(req, "ModifyCosAuditMonitorAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改对象存储识别开关
        /// </summary>
        /// <param name="req"><see cref="ModifyCosAuditObjectIdentifyStatusRequest"/></param>
        /// <returns><see cref="ModifyCosAuditObjectIdentifyStatusResponse"/></returns>
        public Task<ModifyCosAuditObjectIdentifyStatusResponse> ModifyCosAuditObjectIdentifyStatus(ModifyCosAuditObjectIdentifyStatusRequest req)
        {
            return InternalRequestAsync<ModifyCosAuditObjectIdentifyStatusResponse>(req, "ModifyCosAuditObjectIdentifyStatus");
        }

        /// <summary>
        /// 修改对象存储识别开关
        /// </summary>
        /// <param name="req"><see cref="ModifyCosAuditObjectIdentifyStatusRequest"/></param>
        /// <returns><see cref="ModifyCosAuditObjectIdentifyStatusResponse"/></returns>
        public ModifyCosAuditObjectIdentifyStatusResponse ModifyCosAuditObjectIdentifyStatusSync(ModifyCosAuditObjectIdentifyStatusRequest req)
        {
            return InternalRequestAsync<ModifyCosAuditObjectIdentifyStatusResponse>(req, "ModifyCosAuditObjectIdentifyStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置对象存储扫描采样率
        /// </summary>
        /// <param name="req"><see cref="ModifyCosAuditObjectSampleRateRequest"/></param>
        /// <returns><see cref="ModifyCosAuditObjectSampleRateResponse"/></returns>
        public Task<ModifyCosAuditObjectSampleRateResponse> ModifyCosAuditObjectSampleRate(ModifyCosAuditObjectSampleRateRequest req)
        {
            return InternalRequestAsync<ModifyCosAuditObjectSampleRateResponse>(req, "ModifyCosAuditObjectSampleRate");
        }

        /// <summary>
        /// 设置对象存储扫描采样率
        /// </summary>
        /// <param name="req"><see cref="ModifyCosAuditObjectSampleRateRequest"/></param>
        /// <returns><see cref="ModifyCosAuditObjectSampleRateResponse"/></returns>
        public ModifyCosAuditObjectSampleRateResponse ModifyCosAuditObjectSampleRateSync(ModifyCosAuditObjectSampleRateRequest req)
        {
            return InternalRequestAsync<ModifyCosAuditObjectSampleRateResponse>(req, "ModifyCosAuditObjectSampleRate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改对象存储备注
        /// </summary>
        /// <param name="req"><see cref="ModifyCosMarkInfoRequest"/></param>
        /// <returns><see cref="ModifyCosMarkInfoResponse"/></returns>
        public Task<ModifyCosMarkInfoResponse> ModifyCosMarkInfo(ModifyCosMarkInfoRequest req)
        {
            return InternalRequestAsync<ModifyCosMarkInfoResponse>(req, "ModifyCosMarkInfo");
        }

        /// <summary>
        /// 修改对象存储备注
        /// </summary>
        /// <param name="req"><see cref="ModifyCosMarkInfoRequest"/></param>
        /// <returns><see cref="ModifyCosMarkInfoResponse"/></returns>
        public ModifyCosMarkInfoResponse ModifyCosMarkInfoSync(ModifyCosMarkInfoRequest req)
        {
            return InternalRequestAsync<ModifyCosMarkInfoResponse>(req, "ModifyCosMarkInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改Dspm访问管理信息
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmAccessRecordRequest"/></param>
        /// <returns><see cref="ModifyDspmAccessRecordResponse"/></returns>
        public Task<ModifyDspmAccessRecordResponse> ModifyDspmAccessRecord(ModifyDspmAccessRecordRequest req)
        {
            return InternalRequestAsync<ModifyDspmAccessRecordResponse>(req, "ModifyDspmAccessRecord");
        }

        /// <summary>
        /// 修改Dspm访问管理信息
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmAccessRecordRequest"/></param>
        /// <returns><see cref="ModifyDspmAccessRecordResponse"/></returns>
        public ModifyDspmAccessRecordResponse ModifyDspmAccessRecordSync(ModifyDspmAccessRecordRequest req)
        {
            return InternalRequestAsync<ModifyDspmAccessRecordResponse>(req, "ModifyDspmAccessRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改dspm当前应用的数据识别模板
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmApplyingIdentifyComplianceGroupRequest"/></param>
        /// <returns><see cref="ModifyDspmApplyingIdentifyComplianceGroupResponse"/></returns>
        public Task<ModifyDspmApplyingIdentifyComplianceGroupResponse> ModifyDspmApplyingIdentifyComplianceGroup(ModifyDspmApplyingIdentifyComplianceGroupRequest req)
        {
            return InternalRequestAsync<ModifyDspmApplyingIdentifyComplianceGroupResponse>(req, "ModifyDspmApplyingIdentifyComplianceGroup");
        }

        /// <summary>
        /// 修改dspm当前应用的数据识别模板
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmApplyingIdentifyComplianceGroupRequest"/></param>
        /// <returns><see cref="ModifyDspmApplyingIdentifyComplianceGroupResponse"/></returns>
        public ModifyDspmApplyingIdentifyComplianceGroupResponse ModifyDspmApplyingIdentifyComplianceGroupSync(ModifyDspmApplyingIdentifyComplianceGroupRequest req)
        {
            return InternalRequestAsync<ModifyDspmApplyingIdentifyComplianceGroupResponse>(req, "ModifyDspmApplyingIdentifyComplianceGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改Dspm审批单状态
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmApproveStatusRequest"/></param>
        /// <returns><see cref="ModifyDspmApproveStatusResponse"/></returns>
        public Task<ModifyDspmApproveStatusResponse> ModifyDspmApproveStatus(ModifyDspmApproveStatusRequest req)
        {
            return InternalRequestAsync<ModifyDspmApproveStatusResponse>(req, "ModifyDspmApproveStatus");
        }

        /// <summary>
        /// 修改Dspm审批单状态
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmApproveStatusRequest"/></param>
        /// <returns><see cref="ModifyDspmApproveStatusResponse"/></returns>
        public ModifyDspmApproveStatusResponse ModifyDspmApproveStatusSync(ModifyDspmApproveStatusRequest req)
        {
            return InternalRequestAsync<ModifyDspmApproveStatusResponse>(req, "ModifyDspmApproveStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改Dspm资产账号信息
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmAssetAccountRequest"/></param>
        /// <returns><see cref="ModifyDspmAssetAccountResponse"/></returns>
        public Task<ModifyDspmAssetAccountResponse> ModifyDspmAssetAccount(ModifyDspmAssetAccountRequest req)
        {
            return InternalRequestAsync<ModifyDspmAssetAccountResponse>(req, "ModifyDspmAssetAccount");
        }

        /// <summary>
        /// 修改Dspm资产账号信息
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmAssetAccountRequest"/></param>
        /// <returns><see cref="ModifyDspmAssetAccountResponse"/></returns>
        public ModifyDspmAssetAccountResponse ModifyDspmAssetAccountSync(ModifyDspmAssetAccountRequest req)
        {
            return InternalRequestAsync<ModifyDspmAssetAccountResponse>(req, "ModifyDspmAssetAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改Dspm资产账号权限
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmAssetAccountPrivilegesRequest"/></param>
        /// <returns><see cref="ModifyDspmAssetAccountPrivilegesResponse"/></returns>
        public Task<ModifyDspmAssetAccountPrivilegesResponse> ModifyDspmAssetAccountPrivileges(ModifyDspmAssetAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<ModifyDspmAssetAccountPrivilegesResponse>(req, "ModifyDspmAssetAccountPrivileges");
        }

        /// <summary>
        /// 修改Dspm资产账号权限
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmAssetAccountPrivilegesRequest"/></param>
        /// <returns><see cref="ModifyDspmAssetAccountPrivilegesResponse"/></returns>
        public ModifyDspmAssetAccountPrivilegesResponse ModifyDspmAssetAccountPrivilegesSync(ModifyDspmAssetAccountPrivilegesRequest req)
        {
            return InternalRequestAsync<ModifyDspmAssetAccountPrivilegesResponse>(req, "ModifyDspmAssetAccountPrivileges")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改Dspm资产数据扫描任务
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmAssetDataScanTaskRequest"/></param>
        /// <returns><see cref="ModifyDspmAssetDataScanTaskResponse"/></returns>
        public Task<ModifyDspmAssetDataScanTaskResponse> ModifyDspmAssetDataScanTask(ModifyDspmAssetDataScanTaskRequest req)
        {
            return InternalRequestAsync<ModifyDspmAssetDataScanTaskResponse>(req, "ModifyDspmAssetDataScanTask");
        }

        /// <summary>
        /// 修改Dspm资产数据扫描任务
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmAssetDataScanTaskRequest"/></param>
        /// <returns><see cref="ModifyDspmAssetDataScanTaskResponse"/></returns>
        public ModifyDspmAssetDataScanTaskResponse ModifyDspmAssetDataScanTaskSync(ModifyDspmAssetDataScanTaskRequest req)
        {
            return InternalRequestAsync<ModifyDspmAssetDataScanTaskResponse>(req, "ModifyDspmAssetDataScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改Dspm资产数据扫描任务状态
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmAssetDataScanTaskStatusRequest"/></param>
        /// <returns><see cref="ModifyDspmAssetDataScanTaskStatusResponse"/></returns>
        public Task<ModifyDspmAssetDataScanTaskStatusResponse> ModifyDspmAssetDataScanTaskStatus(ModifyDspmAssetDataScanTaskStatusRequest req)
        {
            return InternalRequestAsync<ModifyDspmAssetDataScanTaskStatusResponse>(req, "ModifyDspmAssetDataScanTaskStatus");
        }

        /// <summary>
        /// 修改Dspm资产数据扫描任务状态
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmAssetDataScanTaskStatusRequest"/></param>
        /// <returns><see cref="ModifyDspmAssetDataScanTaskStatusResponse"/></returns>
        public ModifyDspmAssetDataScanTaskStatusResponse ModifyDspmAssetDataScanTaskStatusSync(ModifyDspmAssetDataScanTaskStatusRequest req)
        {
            return InternalRequestAsync<ModifyDspmAssetDataScanTaskStatusResponse>(req, "ModifyDspmAssetDataScanTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改Dspm资产日志投递开关
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmAssetLogDeliverySwitchRequest"/></param>
        /// <returns><see cref="ModifyDspmAssetLogDeliverySwitchResponse"/></returns>
        public Task<ModifyDspmAssetLogDeliverySwitchResponse> ModifyDspmAssetLogDeliverySwitch(ModifyDspmAssetLogDeliverySwitchRequest req)
        {
            return InternalRequestAsync<ModifyDspmAssetLogDeliverySwitchResponse>(req, "ModifyDspmAssetLogDeliverySwitch");
        }

        /// <summary>
        /// 修改Dspm资产日志投递开关
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmAssetLogDeliverySwitchRequest"/></param>
        /// <returns><see cref="ModifyDspmAssetLogDeliverySwitchResponse"/></returns>
        public ModifyDspmAssetLogDeliverySwitchResponse ModifyDspmAssetLogDeliverySwitchSync(ModifyDspmAssetLogDeliverySwitchRequest req)
        {
            return InternalRequestAsync<ModifyDspmAssetLogDeliverySwitchResponse>(req, "ModifyDspmAssetLogDeliverySwitch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改Dspm资产日志投递开关
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmAssetSecurityAnalysisSwitchRequest"/></param>
        /// <returns><see cref="ModifyDspmAssetSecurityAnalysisSwitchResponse"/></returns>
        public Task<ModifyDspmAssetSecurityAnalysisSwitchResponse> ModifyDspmAssetSecurityAnalysisSwitch(ModifyDspmAssetSecurityAnalysisSwitchRequest req)
        {
            return InternalRequestAsync<ModifyDspmAssetSecurityAnalysisSwitchResponse>(req, "ModifyDspmAssetSecurityAnalysisSwitch");
        }

        /// <summary>
        /// 修改Dspm资产日志投递开关
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmAssetSecurityAnalysisSwitchRequest"/></param>
        /// <returns><see cref="ModifyDspmAssetSecurityAnalysisSwitchResponse"/></returns>
        public ModifyDspmAssetSecurityAnalysisSwitchResponse ModifyDspmAssetSecurityAnalysisSwitchSync(ModifyDspmAssetSecurityAnalysisSwitchRequest req)
        {
            return InternalRequestAsync<ModifyDspmAssetSecurityAnalysisSwitchResponse>(req, "ModifyDspmAssetSecurityAnalysisSwitch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改日志备份设置
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmBackupSettingRequest"/></param>
        /// <returns><see cref="ModifyDspmBackupSettingResponse"/></returns>
        public Task<ModifyDspmBackupSettingResponse> ModifyDspmBackupSetting(ModifyDspmBackupSettingRequest req)
        {
            return InternalRequestAsync<ModifyDspmBackupSettingResponse>(req, "ModifyDspmBackupSetting");
        }

        /// <summary>
        /// 修改日志备份设置
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmBackupSettingRequest"/></param>
        /// <returns><see cref="ModifyDspmBackupSettingResponse"/></returns>
        public ModifyDspmBackupSettingResponse ModifyDspmBackupSettingSync(ModifyDspmBackupSettingRequest req)
        {
            return InternalRequestAsync<ModifyDspmBackupSettingResponse>(req, "ModifyDspmBackupSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改dspm数据识别分类
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmIdentifyCategoryRequest"/></param>
        /// <returns><see cref="ModifyDspmIdentifyCategoryResponse"/></returns>
        public Task<ModifyDspmIdentifyCategoryResponse> ModifyDspmIdentifyCategory(ModifyDspmIdentifyCategoryRequest req)
        {
            return InternalRequestAsync<ModifyDspmIdentifyCategoryResponse>(req, "ModifyDspmIdentifyCategory");
        }

        /// <summary>
        /// 修改dspm数据识别分类
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmIdentifyCategoryRequest"/></param>
        /// <returns><see cref="ModifyDspmIdentifyCategoryResponse"/></returns>
        public ModifyDspmIdentifyCategoryResponse ModifyDspmIdentifyCategorySync(ModifyDspmIdentifyCategoryRequest req)
        {
            return InternalRequestAsync<ModifyDspmIdentifyCategoryResponse>(req, "ModifyDspmIdentifyCategory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改dspm数据识别模板
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmIdentifyComplianceGroupRequest"/></param>
        /// <returns><see cref="ModifyDspmIdentifyComplianceGroupResponse"/></returns>
        public Task<ModifyDspmIdentifyComplianceGroupResponse> ModifyDspmIdentifyComplianceGroup(ModifyDspmIdentifyComplianceGroupRequest req)
        {
            return InternalRequestAsync<ModifyDspmIdentifyComplianceGroupResponse>(req, "ModifyDspmIdentifyComplianceGroup");
        }

        /// <summary>
        /// 修改dspm数据识别模板
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmIdentifyComplianceGroupRequest"/></param>
        /// <returns><see cref="ModifyDspmIdentifyComplianceGroupResponse"/></returns>
        public ModifyDspmIdentifyComplianceGroupResponse ModifyDspmIdentifyComplianceGroupSync(ModifyDspmIdentifyComplianceGroupRequest req)
        {
            return InternalRequestAsync<ModifyDspmIdentifyComplianceGroupResponse>(req, "ModifyDspmIdentifyComplianceGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改dspm数据识别模板状态
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmIdentifyComplianceGroupStatusRequest"/></param>
        /// <returns><see cref="ModifyDspmIdentifyComplianceGroupStatusResponse"/></returns>
        public Task<ModifyDspmIdentifyComplianceGroupStatusResponse> ModifyDspmIdentifyComplianceGroupStatus(ModifyDspmIdentifyComplianceGroupStatusRequest req)
        {
            return InternalRequestAsync<ModifyDspmIdentifyComplianceGroupStatusResponse>(req, "ModifyDspmIdentifyComplianceGroupStatus");
        }

        /// <summary>
        /// 修改dspm数据识别模板状态
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmIdentifyComplianceGroupStatusRequest"/></param>
        /// <returns><see cref="ModifyDspmIdentifyComplianceGroupStatusResponse"/></returns>
        public ModifyDspmIdentifyComplianceGroupStatusResponse ModifyDspmIdentifyComplianceGroupStatusSync(ModifyDspmIdentifyComplianceGroupStatusRequest req)
        {
            return InternalRequestAsync<ModifyDspmIdentifyComplianceGroupStatusResponse>(req, "ModifyDspmIdentifyComplianceGroupStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改dspm数据识别模板数据项关联级别信息
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmIdentifyComplianceRuleLevelInfoRequest"/></param>
        /// <returns><see cref="ModifyDspmIdentifyComplianceRuleLevelInfoResponse"/></returns>
        public Task<ModifyDspmIdentifyComplianceRuleLevelInfoResponse> ModifyDspmIdentifyComplianceRuleLevelInfo(ModifyDspmIdentifyComplianceRuleLevelInfoRequest req)
        {
            return InternalRequestAsync<ModifyDspmIdentifyComplianceRuleLevelInfoResponse>(req, "ModifyDspmIdentifyComplianceRuleLevelInfo");
        }

        /// <summary>
        /// 修改dspm数据识别模板数据项关联级别信息
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmIdentifyComplianceRuleLevelInfoRequest"/></param>
        /// <returns><see cref="ModifyDspmIdentifyComplianceRuleLevelInfoResponse"/></returns>
        public ModifyDspmIdentifyComplianceRuleLevelInfoResponse ModifyDspmIdentifyComplianceRuleLevelInfoSync(ModifyDspmIdentifyComplianceRuleLevelInfoRequest req)
        {
            return InternalRequestAsync<ModifyDspmIdentifyComplianceRuleLevelInfoResponse>(req, "ModifyDspmIdentifyComplianceRuleLevelInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改Dspm身份信息
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmIdentifyInfoRequest"/></param>
        /// <returns><see cref="ModifyDspmIdentifyInfoResponse"/></returns>
        public Task<ModifyDspmIdentifyInfoResponse> ModifyDspmIdentifyInfo(ModifyDspmIdentifyInfoRequest req)
        {
            return InternalRequestAsync<ModifyDspmIdentifyInfoResponse>(req, "ModifyDspmIdentifyInfo");
        }

        /// <summary>
        /// 修改Dspm身份信息
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmIdentifyInfoRequest"/></param>
        /// <returns><see cref="ModifyDspmIdentifyInfoResponse"/></returns>
        public ModifyDspmIdentifyInfoResponse ModifyDspmIdentifyInfoSync(ModifyDspmIdentifyInfoRequest req)
        {
            return InternalRequestAsync<ModifyDspmIdentifyInfoResponse>(req, "ModifyDspmIdentifyInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改dspm数据识别分级组
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmIdentifyLevelGroupRequest"/></param>
        /// <returns><see cref="ModifyDspmIdentifyLevelGroupResponse"/></returns>
        public Task<ModifyDspmIdentifyLevelGroupResponse> ModifyDspmIdentifyLevelGroup(ModifyDspmIdentifyLevelGroupRequest req)
        {
            return InternalRequestAsync<ModifyDspmIdentifyLevelGroupResponse>(req, "ModifyDspmIdentifyLevelGroup");
        }

        /// <summary>
        /// 修改dspm数据识别分级组
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmIdentifyLevelGroupRequest"/></param>
        /// <returns><see cref="ModifyDspmIdentifyLevelGroupResponse"/></returns>
        public ModifyDspmIdentifyLevelGroupResponse ModifyDspmIdentifyLevelGroupSync(ModifyDspmIdentifyLevelGroupRequest req)
        {
            return InternalRequestAsync<ModifyDspmIdentifyLevelGroupResponse>(req, "ModifyDspmIdentifyLevelGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改dspm数据识别分级信息
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmIdentifyLevelItemRequest"/></param>
        /// <returns><see cref="ModifyDspmIdentifyLevelItemResponse"/></returns>
        public Task<ModifyDspmIdentifyLevelItemResponse> ModifyDspmIdentifyLevelItem(ModifyDspmIdentifyLevelItemRequest req)
        {
            return InternalRequestAsync<ModifyDspmIdentifyLevelItemResponse>(req, "ModifyDspmIdentifyLevelItem");
        }

        /// <summary>
        /// 修改dspm数据识别分级信息
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmIdentifyLevelItemRequest"/></param>
        /// <returns><see cref="ModifyDspmIdentifyLevelItemResponse"/></returns>
        public ModifyDspmIdentifyLevelItemResponse ModifyDspmIdentifyLevelItemSync(ModifyDspmIdentifyLevelItemRequest req)
        {
            return InternalRequestAsync<ModifyDspmIdentifyLevelItemResponse>(req, "ModifyDspmIdentifyLevelItem")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改dspm数据识别数据项
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmIdentifyRuleRequest"/></param>
        /// <returns><see cref="ModifyDspmIdentifyRuleResponse"/></returns>
        public Task<ModifyDspmIdentifyRuleResponse> ModifyDspmIdentifyRule(ModifyDspmIdentifyRuleRequest req)
        {
            return InternalRequestAsync<ModifyDspmIdentifyRuleResponse>(req, "ModifyDspmIdentifyRule");
        }

        /// <summary>
        /// 修改dspm数据识别数据项
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmIdentifyRuleRequest"/></param>
        /// <returns><see cref="ModifyDspmIdentifyRuleResponse"/></returns>
        public ModifyDspmIdentifyRuleResponse ModifyDspmIdentifyRuleSync(ModifyDspmIdentifyRuleRequest req)
        {
            return InternalRequestAsync<ModifyDspmIdentifyRuleResponse>(req, "ModifyDspmIdentifyRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改dspm数据识别数据项状态
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmIdentifyRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyDspmIdentifyRuleStatusResponse"/></returns>
        public Task<ModifyDspmIdentifyRuleStatusResponse> ModifyDspmIdentifyRuleStatus(ModifyDspmIdentifyRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyDspmIdentifyRuleStatusResponse>(req, "ModifyDspmIdentifyRuleStatus");
        }

        /// <summary>
        /// 修改dspm数据识别数据项状态
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmIdentifyRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyDspmIdentifyRuleStatusResponse"/></returns>
        public ModifyDspmIdentifyRuleStatusResponse ModifyDspmIdentifyRuleStatusSync(ModifyDspmIdentifyRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyDspmIdentifyRuleStatusResponse>(req, "ModifyDspmIdentifyRuleStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改DspmIp信息
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmIpInfoRequest"/></param>
        /// <returns><see cref="ModifyDspmIpInfoResponse"/></returns>
        public Task<ModifyDspmIpInfoResponse> ModifyDspmIpInfo(ModifyDspmIpInfoRequest req)
        {
            return InternalRequestAsync<ModifyDspmIpInfoResponse>(req, "ModifyDspmIpInfo");
        }

        /// <summary>
        /// 修改DspmIp信息
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmIpInfoRequest"/></param>
        /// <returns><see cref="ModifyDspmIpInfoResponse"/></returns>
        public ModifyDspmIpInfoResponse ModifyDspmIpInfoSync(ModifyDspmIpInfoRequest req)
        {
            return InternalRequestAsync<ModifyDspmIpInfoResponse>(req, "ModifyDspmIpInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改Dspm个人身份id
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmPersonalIdentifyRequest"/></param>
        /// <returns><see cref="ModifyDspmPersonalIdentifyResponse"/></returns>
        public Task<ModifyDspmPersonalIdentifyResponse> ModifyDspmPersonalIdentify(ModifyDspmPersonalIdentifyRequest req)
        {
            return InternalRequestAsync<ModifyDspmPersonalIdentifyResponse>(req, "ModifyDspmPersonalIdentify");
        }

        /// <summary>
        /// 修改Dspm个人身份id
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmPersonalIdentifyRequest"/></param>
        /// <returns><see cref="ModifyDspmPersonalIdentifyResponse"/></returns>
        public ModifyDspmPersonalIdentifyResponse ModifyDspmPersonalIdentifySync(ModifyDspmPersonalIdentifyRequest req)
        {
            return InternalRequestAsync<ModifyDspmPersonalIdentifyResponse>(req, "ModifyDspmPersonalIdentify")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 恢复备份日志
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmRestoreLogTaskRequest"/></param>
        /// <returns><see cref="ModifyDspmRestoreLogTaskResponse"/></returns>
        public Task<ModifyDspmRestoreLogTaskResponse> ModifyDspmRestoreLogTask(ModifyDspmRestoreLogTaskRequest req)
        {
            return InternalRequestAsync<ModifyDspmRestoreLogTaskResponse>(req, "ModifyDspmRestoreLogTask");
        }

        /// <summary>
        /// 恢复备份日志
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmRestoreLogTaskRequest"/></param>
        /// <returns><see cref="ModifyDspmRestoreLogTaskResponse"/></returns>
        public ModifyDspmRestoreLogTaskResponse ModifyDspmRestoreLogTaskSync(ModifyDspmRestoreLogTaskRequest req)
        {
            return InternalRequestAsync<ModifyDspmRestoreLogTaskResponse>(req, "ModifyDspmRestoreLogTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改Dspm风险信息
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmRiskInfoRequest"/></param>
        /// <returns><see cref="ModifyDspmRiskInfoResponse"/></returns>
        public Task<ModifyDspmRiskInfoResponse> ModifyDspmRiskInfo(ModifyDspmRiskInfoRequest req)
        {
            return InternalRequestAsync<ModifyDspmRiskInfoResponse>(req, "ModifyDspmRiskInfo");
        }

        /// <summary>
        /// 修改Dspm风险信息
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmRiskInfoRequest"/></param>
        /// <returns><see cref="ModifyDspmRiskInfoResponse"/></returns>
        public ModifyDspmRiskInfoResponse ModifyDspmRiskInfoSync(ModifyDspmRiskInfoRequest req)
        {
            return InternalRequestAsync<ModifyDspmRiskInfoResponse>(req, "ModifyDspmRiskInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改Dspm风险策略
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmRiskStrategyRequest"/></param>
        /// <returns><see cref="ModifyDspmRiskStrategyResponse"/></returns>
        public Task<ModifyDspmRiskStrategyResponse> ModifyDspmRiskStrategy(ModifyDspmRiskStrategyRequest req)
        {
            return InternalRequestAsync<ModifyDspmRiskStrategyResponse>(req, "ModifyDspmRiskStrategy");
        }

        /// <summary>
        /// 修改Dspm风险策略
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmRiskStrategyRequest"/></param>
        /// <returns><see cref="ModifyDspmRiskStrategyResponse"/></returns>
        public ModifyDspmRiskStrategyResponse ModifyDspmRiskStrategySync(ModifyDspmRiskStrategyRequest req)
        {
            return InternalRequestAsync<ModifyDspmRiskStrategyResponse>(req, "ModifyDspmRiskStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改Dspm白名单策略
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmWhitelistStrategyRequest"/></param>
        /// <returns><see cref="ModifyDspmWhitelistStrategyResponse"/></returns>
        public Task<ModifyDspmWhitelistStrategyResponse> ModifyDspmWhitelistStrategy(ModifyDspmWhitelistStrategyRequest req)
        {
            return InternalRequestAsync<ModifyDspmWhitelistStrategyResponse>(req, "ModifyDspmWhitelistStrategy");
        }

        /// <summary>
        /// 修改Dspm白名单策略
        /// </summary>
        /// <param name="req"><see cref="ModifyDspmWhitelistStrategyRequest"/></param>
        /// <returns><see cref="ModifyDspmWhitelistStrategyResponse"/></returns>
        public ModifyDspmWhitelistStrategyResponse ModifyDspmWhitelistStrategySync(ModifyDspmWhitelistStrategyRequest req)
        {
            return InternalRequestAsync<ModifyDspmWhitelistStrategyResponse>(req, "ModifyDspmWhitelistStrategy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑或者创建EDR策略
        /// </summary>
        /// <param name="req"><see cref="ModifyEDRRuleRequest"/></param>
        /// <returns><see cref="ModifyEDRRuleResponse"/></returns>
        public Task<ModifyEDRRuleResponse> ModifyEDRRule(ModifyEDRRuleRequest req)
        {
            return InternalRequestAsync<ModifyEDRRuleResponse>(req, "ModifyEDRRule");
        }

        /// <summary>
        /// 编辑或者创建EDR策略
        /// </summary>
        /// <param name="req"><see cref="ModifyEDRRuleRequest"/></param>
        /// <returns><see cref="ModifyEDRRuleResponse"/></returns>
        public ModifyEDRRuleResponse ModifyEDRRuleSync(ModifyEDRRuleRequest req)
        {
            return InternalRequestAsync<ModifyEDRRuleResponse>(req, "ModifyEDRRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 永久忽略EDR多行为告警，将告警对应的主机+规则加入AI-Link永久忽略白名单，后续同类告警将自动丢弃
        /// </summary>
        /// <param name="req"><see cref="ModifyEdrAlertPermanentIgnoreRequest"/></param>
        /// <returns><see cref="ModifyEdrAlertPermanentIgnoreResponse"/></returns>
        public Task<ModifyEdrAlertPermanentIgnoreResponse> ModifyEdrAlertPermanentIgnore(ModifyEdrAlertPermanentIgnoreRequest req)
        {
            return InternalRequestAsync<ModifyEdrAlertPermanentIgnoreResponse>(req, "ModifyEdrAlertPermanentIgnore");
        }

        /// <summary>
        /// 永久忽略EDR多行为告警，将告警对应的主机+规则加入AI-Link永久忽略白名单，后续同类告警将自动丢弃
        /// </summary>
        /// <param name="req"><see cref="ModifyEdrAlertPermanentIgnoreRequest"/></param>
        /// <returns><see cref="ModifyEdrAlertPermanentIgnoreResponse"/></returns>
        public ModifyEdrAlertPermanentIgnoreResponse ModifyEdrAlertPermanentIgnoreSync(ModifyEdrAlertPermanentIgnoreRequest req)
        {
            return InternalRequestAsync<ModifyEdrAlertPermanentIgnoreResponse>(req, "ModifyEdrAlertPermanentIgnore")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改IaC检测接入Token存储周期
        /// </summary>
        /// <param name="req"><see cref="ModifyIaCTokenPeriodRequest"/></param>
        /// <returns><see cref="ModifyIaCTokenPeriodResponse"/></returns>
        public Task<ModifyIaCTokenPeriodResponse> ModifyIaCTokenPeriod(ModifyIaCTokenPeriodRequest req)
        {
            return InternalRequestAsync<ModifyIaCTokenPeriodResponse>(req, "ModifyIaCTokenPeriod");
        }

        /// <summary>
        /// 修改IaC检测接入Token存储周期
        /// </summary>
        /// <param name="req"><see cref="ModifyIaCTokenPeriodRequest"/></param>
        /// <returns><see cref="ModifyIaCTokenPeriodResponse"/></returns>
        public ModifyIaCTokenPeriodResponse ModifyIaCTokenPeriodSync(ModifyIaCTokenPeriodRequest req)
        {
            return InternalRequestAsync<ModifyIaCTokenPeriodResponse>(req, "ModifyIaCTokenPeriod")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改主机资产备注信息
        /// </summary>
        /// <param name="req"><see cref="ModifyMachineRemarkRequest"/></param>
        /// <returns><see cref="ModifyMachineRemarkResponse"/></returns>
        public Task<ModifyMachineRemarkResponse> ModifyMachineRemark(ModifyMachineRemarkRequest req)
        {
            return InternalRequestAsync<ModifyMachineRemarkResponse>(req, "ModifyMachineRemark");
        }

        /// <summary>
        /// 修改主机资产备注信息
        /// </summary>
        /// <param name="req"><see cref="ModifyMachineRemarkRequest"/></param>
        /// <returns><see cref="ModifyMachineRemarkResponse"/></returns>
        public ModifyMachineRemarkResponse ModifyMachineRemarkSync(ModifyMachineRemarkRequest req)
        {
            return InternalRequestAsync<ModifyMachineRemarkResponse>(req, "ModifyMachineRemark")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改通知资产范围配置
        /// </summary>
        /// <param name="req"><see cref="ModifyNotifyAssetConfigRequest"/></param>
        /// <returns><see cref="ModifyNotifyAssetConfigResponse"/></returns>
        public Task<ModifyNotifyAssetConfigResponse> ModifyNotifyAssetConfig(ModifyNotifyAssetConfigRequest req)
        {
            return InternalRequestAsync<ModifyNotifyAssetConfigResponse>(req, "ModifyNotifyAssetConfig");
        }

        /// <summary>
        /// 修改通知资产范围配置
        /// </summary>
        /// <param name="req"><see cref="ModifyNotifyAssetConfigRequest"/></param>
        /// <returns><see cref="ModifyNotifyAssetConfigResponse"/></returns>
        public ModifyNotifyAssetConfigResponse ModifyNotifyAssetConfigSync(ModifyNotifyAssetConfigRequest req)
        {
            return InternalRequestAsync<ModifyNotifyAssetConfigResponse>(req, "ModifyNotifyAssetConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改通知设置
        /// </summary>
        /// <param name="req"><see cref="ModifyNotifySettingRequest"/></param>
        /// <returns><see cref="ModifyNotifySettingResponse"/></returns>
        public Task<ModifyNotifySettingResponse> ModifyNotifySetting(ModifyNotifySettingRequest req)
        {
            return InternalRequestAsync<ModifyNotifySettingResponse>(req, "ModifyNotifySetting");
        }

        /// <summary>
        /// 修改通知设置
        /// </summary>
        /// <param name="req"><see cref="ModifyNotifySettingRequest"/></param>
        /// <returns><see cref="ModifyNotifySettingResponse"/></returns>
        public ModifyNotifySettingResponse ModifyNotifySettingSync(ModifyNotifySettingRequest req)
        {
            return InternalRequestAsync<ModifyNotifySettingResponse>(req, "ModifyNotifySetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改告警中心通知高级配置
        /// </summary>
        /// <param name="req"><see cref="ModifyNotifySettingAlertRequest"/></param>
        /// <returns><see cref="ModifyNotifySettingAlertResponse"/></returns>
        public Task<ModifyNotifySettingAlertResponse> ModifyNotifySettingAlert(ModifyNotifySettingAlertRequest req)
        {
            return InternalRequestAsync<ModifyNotifySettingAlertResponse>(req, "ModifyNotifySettingAlert");
        }

        /// <summary>
        /// 修改告警中心通知高级配置
        /// </summary>
        /// <param name="req"><see cref="ModifyNotifySettingAlertRequest"/></param>
        /// <returns><see cref="ModifyNotifySettingAlertResponse"/></returns>
        public ModifyNotifySettingAlertResponse ModifyNotifySettingAlertSync(ModifyNotifySettingAlertRequest req)
        {
            return InternalRequestAsync<ModifyNotifySettingAlertResponse>(req, "ModifyNotifySettingAlert")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改集团账号状态
        /// </summary>
        /// <param name="req"><see cref="ModifyOrganizationAccountStatusRequest"/></param>
        /// <returns><see cref="ModifyOrganizationAccountStatusResponse"/></returns>
        public Task<ModifyOrganizationAccountStatusResponse> ModifyOrganizationAccountStatus(ModifyOrganizationAccountStatusRequest req)
        {
            return InternalRequestAsync<ModifyOrganizationAccountStatusResponse>(req, "ModifyOrganizationAccountStatus");
        }

        /// <summary>
        /// 修改集团账号状态
        /// </summary>
        /// <param name="req"><see cref="ModifyOrganizationAccountStatusRequest"/></param>
        /// <returns><see cref="ModifyOrganizationAccountStatusResponse"/></returns>
        public ModifyOrganizationAccountStatusResponse ModifyOrganizationAccountStatusSync(ModifyOrganizationAccountStatusRequest req)
        {
            return InternalRequestAsync<ModifyOrganizationAccountStatusResponse>(req, "ModifyOrganizationAccountStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改策略状态
        /// </summary>
        /// <param name="req"><see cref="ModifyPolicyStatusRequest"/></param>
        /// <returns><see cref="ModifyPolicyStatusResponse"/></returns>
        public Task<ModifyPolicyStatusResponse> ModifyPolicyStatus(ModifyPolicyStatusRequest req)
        {
            return InternalRequestAsync<ModifyPolicyStatusResponse>(req, "ModifyPolicyStatus");
        }

        /// <summary>
        /// 修改策略状态
        /// </summary>
        /// <param name="req"><see cref="ModifyPolicyStatusRequest"/></param>
        /// <returns><see cref="ModifyPolicyStatusResponse"/></returns>
        public ModifyPolicyStatusResponse ModifyPolicyStatusSync(ModifyPolicyStatusRequest req)
        {
            return InternalRequestAsync<ModifyPolicyStatusResponse>(req, "ModifyPolicyStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改风险中心风险状态
        /// </summary>
        /// <param name="req"><see cref="ModifyRiskCenterRiskStatusRequest"/></param>
        /// <returns><see cref="ModifyRiskCenterRiskStatusResponse"/></returns>
        public Task<ModifyRiskCenterRiskStatusResponse> ModifyRiskCenterRiskStatus(ModifyRiskCenterRiskStatusRequest req)
        {
            return InternalRequestAsync<ModifyRiskCenterRiskStatusResponse>(req, "ModifyRiskCenterRiskStatus");
        }

        /// <summary>
        /// 修改风险中心风险状态
        /// </summary>
        /// <param name="req"><see cref="ModifyRiskCenterRiskStatusRequest"/></param>
        /// <returns><see cref="ModifyRiskCenterRiskStatusResponse"/></returns>
        public ModifyRiskCenterRiskStatusResponse ModifyRiskCenterRiskStatusSync(ModifyRiskCenterRiskStatusRequest req)
        {
            return InternalRequestAsync<ModifyRiskCenterRiskStatusResponse>(req, "ModifyRiskCenterRiskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改风险中心扫描任务
        /// </summary>
        /// <param name="req"><see cref="ModifyRiskCenterScanTaskRequest"/></param>
        /// <returns><see cref="ModifyRiskCenterScanTaskResponse"/></returns>
        public Task<ModifyRiskCenterScanTaskResponse> ModifyRiskCenterScanTask(ModifyRiskCenterScanTaskRequest req)
        {
            return InternalRequestAsync<ModifyRiskCenterScanTaskResponse>(req, "ModifyRiskCenterScanTask");
        }

        /// <summary>
        /// 修改风险中心扫描任务
        /// </summary>
        /// <param name="req"><see cref="ModifyRiskCenterScanTaskRequest"/></param>
        /// <returns><see cref="ModifyRiskCenterScanTaskResponse"/></returns>
        public ModifyRiskCenterScanTaskResponse ModifyRiskCenterScanTaskSync(ModifyRiskCenterScanTaskRequest req)
        {
            return InternalRequestAsync<ModifyRiskCenterScanTaskResponse>(req, "ModifyRiskCenterScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新自定义策略的开关
        /// </summary>
        /// <param name="req"><see cref="ModifyUebaRuleSwitchRequest"/></param>
        /// <returns><see cref="ModifyUebaRuleSwitchResponse"/></returns>
        public Task<ModifyUebaRuleSwitchResponse> ModifyUebaRuleSwitch(ModifyUebaRuleSwitchRequest req)
        {
            return InternalRequestAsync<ModifyUebaRuleSwitchResponse>(req, "ModifyUebaRuleSwitch");
        }

        /// <summary>
        /// 更新自定义策略的开关
        /// </summary>
        /// <param name="req"><see cref="ModifyUebaRuleSwitchRequest"/></param>
        /// <returns><see cref="ModifyUebaRuleSwitchResponse"/></returns>
        public ModifyUebaRuleSwitchResponse ModifyUebaRuleSwitchSync(ModifyUebaRuleSwitchRequest req)
        {
            return InternalRequestAsync<ModifyUebaRuleSwitchResponse>(req, "ModifyUebaRuleSwitch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重置Dspm资产账号密码
        /// </summary>
        /// <param name="req"><see cref="ResetDspmAssetAccountPasswordRequest"/></param>
        /// <returns><see cref="ResetDspmAssetAccountPasswordResponse"/></returns>
        public Task<ResetDspmAssetAccountPasswordResponse> ResetDspmAssetAccountPassword(ResetDspmAssetAccountPasswordRequest req)
        {
            return InternalRequestAsync<ResetDspmAssetAccountPasswordResponse>(req, "ResetDspmAssetAccountPassword");
        }

        /// <summary>
        /// 重置Dspm资产账号密码
        /// </summary>
        /// <param name="req"><see cref="ResetDspmAssetAccountPasswordRequest"/></param>
        /// <returns><see cref="ResetDspmAssetAccountPasswordResponse"/></returns>
        public ResetDspmAssetAccountPasswordResponse ResetDspmAssetAccountPasswordSync(ResetDspmAssetAccountPasswordRequest req)
        {
            return InternalRequestAsync<ResetDspmAssetAccountPasswordResponse>(req, "ResetDspmAssetAccountPassword")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// RetryExportLog
        /// </summary>
        /// <param name="req"><see cref="RetryDspmExportLogRequest"/></param>
        /// <returns><see cref="RetryDspmExportLogResponse"/></returns>
        public Task<RetryDspmExportLogResponse> RetryDspmExportLog(RetryDspmExportLogRequest req)
        {
            return InternalRequestAsync<RetryDspmExportLogResponse>(req, "RetryDspmExportLog");
        }

        /// <summary>
        /// RetryExportLog
        /// </summary>
        /// <param name="req"><see cref="RetryDspmExportLogRequest"/></param>
        /// <returns><see cref="RetryDspmExportLogResponse"/></returns>
        public RetryDspmExportLogResponse RetryDspmExportLogSync(RetryDspmExportLogRequest req)
        {
            return InternalRequestAsync<RetryDspmExportLogResponse>(req, "RetryDspmExportLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 恢复Dspm资产账号
        /// </summary>
        /// <param name="req"><see cref="RevertDspmAssetAccountRequest"/></param>
        /// <returns><see cref="RevertDspmAssetAccountResponse"/></returns>
        public Task<RevertDspmAssetAccountResponse> RevertDspmAssetAccount(RevertDspmAssetAccountRequest req)
        {
            return InternalRequestAsync<RevertDspmAssetAccountResponse>(req, "RevertDspmAssetAccount");
        }

        /// <summary>
        /// 恢复Dspm资产账号
        /// </summary>
        /// <param name="req"><see cref="RevertDspmAssetAccountRequest"/></param>
        /// <returns><see cref="RevertDspmAssetAccountResponse"/></returns>
        public RevertDspmAssetAccountResponse RevertDspmAssetAccountSync(RevertDspmAssetAccountRequest req)
        {
            return InternalRequestAsync<RevertDspmAssetAccountResponse>(req, "RevertDspmAssetAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 发送Dspm资产访问验证码
        /// </summary>
        /// <param name="req"><see cref="SendDspmAssetLoginSmsCodeRequest"/></param>
        /// <returns><see cref="SendDspmAssetLoginSmsCodeResponse"/></returns>
        public Task<SendDspmAssetLoginSmsCodeResponse> SendDspmAssetLoginSmsCode(SendDspmAssetLoginSmsCodeRequest req)
        {
            return InternalRequestAsync<SendDspmAssetLoginSmsCodeResponse>(req, "SendDspmAssetLoginSmsCode");
        }

        /// <summary>
        /// 发送Dspm资产访问验证码
        /// </summary>
        /// <param name="req"><see cref="SendDspmAssetLoginSmsCodeRequest"/></param>
        /// <returns><see cref="SendDspmAssetLoginSmsCodeResponse"/></returns>
        public SendDspmAssetLoginSmsCodeResponse SendDspmAssetLoginSmsCodeSync(SendDspmAssetLoginSmsCodeRequest req)
        {
            return InternalRequestAsync<SendDspmAssetLoginSmsCodeResponse>(req, "SendDspmAssetLoginSmsCode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止扫风险中心扫描任务
        /// </summary>
        /// <param name="req"><see cref="StopRiskCenterTaskRequest"/></param>
        /// <returns><see cref="StopRiskCenterTaskResponse"/></returns>
        public Task<StopRiskCenterTaskResponse> StopRiskCenterTask(StopRiskCenterTaskRequest req)
        {
            return InternalRequestAsync<StopRiskCenterTaskResponse>(req, "StopRiskCenterTask");
        }

        /// <summary>
        /// 停止扫风险中心扫描任务
        /// </summary>
        /// <param name="req"><see cref="StopRiskCenterTaskRequest"/></param>
        /// <returns><see cref="StopRiskCenterTaskResponse"/></returns>
        public StopRiskCenterTaskResponse StopRiskCenterTaskSync(StopRiskCenterTaskRequest req)
        {
            return InternalRequestAsync<StopRiskCenterTaskResponse>(req, "StopRiskCenterTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 同步dspm支持的资产
        /// </summary>
        /// <param name="req"><see cref="SyncDspmAssetsRequest"/></param>
        /// <returns><see cref="SyncDspmAssetsResponse"/></returns>
        public Task<SyncDspmAssetsResponse> SyncDspmAssets(SyncDspmAssetsRequest req)
        {
            return InternalRequestAsync<SyncDspmAssetsResponse>(req, "SyncDspmAssets");
        }

        /// <summary>
        /// 同步dspm支持的资产
        /// </summary>
        /// <param name="req"><see cref="SyncDspmAssetsRequest"/></param>
        /// <returns><see cref="SyncDspmAssetsResponse"/></returns>
        public SyncDspmAssetsResponse SyncDspmAssetsSync(SyncDspmAssetsRequest req)
        {
            return InternalRequestAsync<SyncDspmAssetsResponse>(req, "SyncDspmAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 同步dspm用户列表
        /// </summary>
        /// <param name="req"><see cref="SyncDspmUsersRequest"/></param>
        /// <returns><see cref="SyncDspmUsersResponse"/></returns>
        public Task<SyncDspmUsersResponse> SyncDspmUsers(SyncDspmUsersRequest req)
        {
            return InternalRequestAsync<SyncDspmUsersResponse>(req, "SyncDspmUsers");
        }

        /// <summary>
        /// 同步dspm用户列表
        /// </summary>
        /// <param name="req"><see cref="SyncDspmUsersRequest"/></param>
        /// <returns><see cref="SyncDspmUsersResponse"/></returns>
        public SyncDspmUsersResponse SyncDspmUsersSync(SyncDspmUsersRequest req)
        {
            return InternalRequestAsync<SyncDspmUsersResponse>(req, "SyncDspmUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 标记风险或者告警为 已处置/已忽略
        /// </summary>
        /// <param name="req"><see cref="UpdateAccessKeyAlarmStatusRequest"/></param>
        /// <returns><see cref="UpdateAccessKeyAlarmStatusResponse"/></returns>
        public Task<UpdateAccessKeyAlarmStatusResponse> UpdateAccessKeyAlarmStatus(UpdateAccessKeyAlarmStatusRequest req)
        {
            return InternalRequestAsync<UpdateAccessKeyAlarmStatusResponse>(req, "UpdateAccessKeyAlarmStatus");
        }

        /// <summary>
        /// 标记风险或者告警为 已处置/已忽略
        /// </summary>
        /// <param name="req"><see cref="UpdateAccessKeyAlarmStatusRequest"/></param>
        /// <returns><see cref="UpdateAccessKeyAlarmStatusResponse"/></returns>
        public UpdateAccessKeyAlarmStatusResponse UpdateAccessKeyAlarmStatusSync(UpdateAccessKeyAlarmStatusRequest req)
        {
            return InternalRequestAsync<UpdateAccessKeyAlarmStatusResponse>(req, "UpdateAccessKeyAlarmStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑访问密钥/源IP备注
        /// </summary>
        /// <param name="req"><see cref="UpdateAccessKeyRemarkRequest"/></param>
        /// <returns><see cref="UpdateAccessKeyRemarkResponse"/></returns>
        public Task<UpdateAccessKeyRemarkResponse> UpdateAccessKeyRemark(UpdateAccessKeyRemarkRequest req)
        {
            return InternalRequestAsync<UpdateAccessKeyRemarkResponse>(req, "UpdateAccessKeyRemark");
        }

        /// <summary>
        /// 编辑访问密钥/源IP备注
        /// </summary>
        /// <param name="req"><see cref="UpdateAccessKeyRemarkRequest"/></param>
        /// <returns><see cref="UpdateAccessKeyRemarkResponse"/></returns>
        public UpdateAccessKeyRemarkResponse UpdateAccessKeyRemarkSync(UpdateAccessKeyRemarkRequest req)
        {
            return InternalRequestAsync<UpdateAccessKeyRemarkResponse>(req, "UpdateAccessKeyRemark")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量告警状态处理接口
        /// </summary>
        /// <param name="req"><see cref="UpdateAlertStatusListRequest"/></param>
        /// <returns><see cref="UpdateAlertStatusListResponse"/></returns>
        public Task<UpdateAlertStatusListResponse> UpdateAlertStatusList(UpdateAlertStatusListRequest req)
        {
            return InternalRequestAsync<UpdateAlertStatusListResponse>(req, "UpdateAlertStatusList");
        }

        /// <summary>
        /// 批量告警状态处理接口
        /// </summary>
        /// <param name="req"><see cref="UpdateAlertStatusListRequest"/></param>
        /// <returns><see cref="UpdateAlertStatusListResponse"/></returns>
        public UpdateAlertStatusListResponse UpdateAlertStatusListSync(UpdateAlertStatusListRequest req)
        {
            return InternalRequestAsync<UpdateAlertStatusListResponse>(req, "UpdateAlertStatusList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 验证Dspm资产登录验证码
        /// </summary>
        /// <param name="req"><see cref="VerifyDspmAssetLoginCodeRequest"/></param>
        /// <returns><see cref="VerifyDspmAssetLoginCodeResponse"/></returns>
        public Task<VerifyDspmAssetLoginCodeResponse> VerifyDspmAssetLoginCode(VerifyDspmAssetLoginCodeRequest req)
        {
            return InternalRequestAsync<VerifyDspmAssetLoginCodeResponse>(req, "VerifyDspmAssetLoginCode");
        }

        /// <summary>
        /// 验证Dspm资产登录验证码
        /// </summary>
        /// <param name="req"><see cref="VerifyDspmAssetLoginCodeRequest"/></param>
        /// <returns><see cref="VerifyDspmAssetLoginCodeResponse"/></returns>
        public VerifyDspmAssetLoginCodeResponse VerifyDspmAssetLoginCodeSync(VerifyDspmAssetLoginCodeRequest req)
        {
            return InternalRequestAsync<VerifyDspmAssetLoginCodeResponse>(req, "VerifyDspmAssetLoginCode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}

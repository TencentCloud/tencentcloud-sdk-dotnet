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
       private const string sdkVersion = "SDK_NET_3.0.1494";

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
        /// 创建/修改SMTP邮箱接入请求
        /// </summary>
        /// <param name="req"><see cref="AccessAIAnalysisSMTPRequest"/></param>
        /// <returns><see cref="AccessAIAnalysisSMTPResponse"/></returns>
        public Task<AccessAIAnalysisSMTPResponse> AccessAIAnalysisSMTP(AccessAIAnalysisSMTPRequest req)
        {
            return InternalRequestAsync<AccessAIAnalysisSMTPResponse>(req, "AccessAIAnalysisSMTP");
        }

        /// <summary>
        /// 创建/修改SMTP邮箱接入请求
        /// </summary>
        /// <param name="req"><see cref="AccessAIAnalysisSMTPRequest"/></param>
        /// <returns><see cref="AccessAIAnalysisSMTPResponse"/></returns>
        public AccessAIAnalysisSMTPResponse AccessAIAnalysisSMTPSync(AccessAIAnalysisSMTPRequest req)
        {
            return InternalRequestAsync<AccessAIAnalysisSMTPResponse>(req, "AccessAIAnalysisSMTP")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        /// 添加镜像仓库信息
        /// </summary>
        /// <param name="req"><see cref="AddImageRegistryRequest"/></param>
        /// <returns><see cref="AddImageRegistryResponse"/></returns>
        public Task<AddImageRegistryResponse> AddImageRegistry(AddImageRegistryRequest req)
        {
            return InternalRequestAsync<AddImageRegistryResponse>(req, "AddImageRegistry");
        }

        /// <summary>
        /// 添加镜像仓库信息
        /// </summary>
        /// <param name="req"><see cref="AddImageRegistryRequest"/></param>
        /// <returns><see cref="AddImageRegistryResponse"/></returns>
        public AddImageRegistryResponse AddImageRegistrySync(AddImageRegistryRequest req)
        {
            return InternalRequestAsync<AddImageRegistryResponse>(req, "AddImageRegistry")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量添加异地登录白名单
        /// </summary>
        /// <param name="req"><see cref="AddLoginWhiteListsRequest"/></param>
        /// <returns><see cref="AddLoginWhiteListsResponse"/></returns>
        public Task<AddLoginWhiteListsResponse> AddLoginWhiteLists(AddLoginWhiteListsRequest req)
        {
            return InternalRequestAsync<AddLoginWhiteListsResponse>(req, "AddLoginWhiteLists");
        }

        /// <summary>
        /// 批量添加异地登录白名单
        /// </summary>
        /// <param name="req"><see cref="AddLoginWhiteListsRequest"/></param>
        /// <returns><see cref="AddLoginWhiteListsResponse"/></returns>
        public AddLoginWhiteListsResponse AddLoginWhiteListsSync(AddLoginWhiteListsRequest req)
        {
            return InternalRequestAsync<AddLoginWhiteListsResponse>(req, "AddLoginWhiteLists")
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
        /// 添加漏洞白名单
        /// </summary>
        /// <param name="req"><see cref="AddVulWhitelistRequest"/></param>
        /// <returns><see cref="AddVulWhitelistResponse"/></returns>
        public Task<AddVulWhitelistResponse> AddVulWhitelist(AddVulWhitelistRequest req)
        {
            return InternalRequestAsync<AddVulWhitelistResponse>(req, "AddVulWhitelist");
        }

        /// <summary>
        /// 添加漏洞白名单
        /// </summary>
        /// <param name="req"><see cref="AddVulWhitelistRequest"/></param>
        /// <returns><see cref="AddVulWhitelistResponse"/></returns>
        public AddVulWhitelistResponse AddVulWhitelistSync(AddVulWhitelistRequest req)
        {
            return InternalRequestAsync<AddVulWhitelistResponse>(req, "AddVulWhitelist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量修改基线策略的“周期扫描配置 / 自动同步新增检测项 / 检测项命中配置 / 自定义检测项”等设置。仅修改请求中传入的字段。
        /// </summary>
        /// <param name="req"><see cref="BatchModifyBaselinePolicyRequest"/></param>
        /// <returns><see cref="BatchModifyBaselinePolicyResponse"/></returns>
        public Task<BatchModifyBaselinePolicyResponse> BatchModifyBaselinePolicy(BatchModifyBaselinePolicyRequest req)
        {
            return InternalRequestAsync<BatchModifyBaselinePolicyResponse>(req, "BatchModifyBaselinePolicy");
        }

        /// <summary>
        /// 批量修改基线策略的“周期扫描配置 / 自动同步新增检测项 / 检测项命中配置 / 自定义检测项”等设置。仅修改请求中传入的字段。
        /// </summary>
        /// <param name="req"><see cref="BatchModifyBaselinePolicyRequest"/></param>
        /// <returns><see cref="BatchModifyBaselinePolicyResponse"/></returns>
        public BatchModifyBaselinePolicyResponse BatchModifyBaselinePolicySync(BatchModifyBaselinePolicyRequest req)
        {
            return InternalRequestAsync<BatchModifyBaselinePolicyResponse>(req, "BatchModifyBaselinePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量修改镜像仓库定时扫描任务配置
        /// </summary>
        /// <param name="req"><see cref="BatchModifyImageRegistryTimedScanTaskConfigRequest"/></param>
        /// <returns><see cref="BatchModifyImageRegistryTimedScanTaskConfigResponse"/></returns>
        public Task<BatchModifyImageRegistryTimedScanTaskConfigResponse> BatchModifyImageRegistryTimedScanTaskConfig(BatchModifyImageRegistryTimedScanTaskConfigRequest req)
        {
            return InternalRequestAsync<BatchModifyImageRegistryTimedScanTaskConfigResponse>(req, "BatchModifyImageRegistryTimedScanTaskConfig");
        }

        /// <summary>
        /// 批量修改镜像仓库定时扫描任务配置
        /// </summary>
        /// <param name="req"><see cref="BatchModifyImageRegistryTimedScanTaskConfigRequest"/></param>
        /// <returns><see cref="BatchModifyImageRegistryTimedScanTaskConfigResponse"/></returns>
        public BatchModifyImageRegistryTimedScanTaskConfigResponse BatchModifyImageRegistryTimedScanTaskConfigSync(BatchModifyImageRegistryTimedScanTaskConfigRequest req)
        {
            return InternalRequestAsync<BatchModifyImageRegistryTimedScanTaskConfigResponse>(req, "BatchModifyImageRegistryTimedScanTaskConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量修改容器镜像敏感信息白名单
        /// </summary>
        /// <param name="req"><see cref="BatchModifyImageSensitiveWhitelistRequest"/></param>
        /// <returns><see cref="BatchModifyImageSensitiveWhitelistResponse"/></returns>
        public Task<BatchModifyImageSensitiveWhitelistResponse> BatchModifyImageSensitiveWhitelist(BatchModifyImageSensitiveWhitelistRequest req)
        {
            return InternalRequestAsync<BatchModifyImageSensitiveWhitelistResponse>(req, "BatchModifyImageSensitiveWhitelist");
        }

        /// <summary>
        /// 批量修改容器镜像敏感信息白名单
        /// </summary>
        /// <param name="req"><see cref="BatchModifyImageSensitiveWhitelistRequest"/></param>
        /// <returns><see cref="BatchModifyImageSensitiveWhitelistResponse"/></returns>
        public BatchModifyImageSensitiveWhitelistResponse BatchModifyImageSensitiveWhitelistSync(BatchModifyImageSensitiveWhitelistRequest req)
        {
            return InternalRequestAsync<BatchModifyImageSensitiveWhitelistResponse>(req, "BatchModifyImageSensitiveWhitelist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量修改镜像木马白名单
        /// </summary>
        /// <param name="req"><see cref="BatchModifyImageVirusWhitelistRequest"/></param>
        /// <returns><see cref="BatchModifyImageVirusWhitelistResponse"/></returns>
        public Task<BatchModifyImageVirusWhitelistResponse> BatchModifyImageVirusWhitelist(BatchModifyImageVirusWhitelistRequest req)
        {
            return InternalRequestAsync<BatchModifyImageVirusWhitelistResponse>(req, "BatchModifyImageVirusWhitelist");
        }

        /// <summary>
        /// 批量修改镜像木马白名单
        /// </summary>
        /// <param name="req"><see cref="BatchModifyImageVirusWhitelistRequest"/></param>
        /// <returns><see cref="BatchModifyImageVirusWhitelistResponse"/></returns>
        public BatchModifyImageVirusWhitelistResponse BatchModifyImageVirusWhitelistSync(BatchModifyImageVirusWhitelistRequest req)
        {
            return InternalRequestAsync<BatchModifyImageVirusWhitelistResponse>(req, "BatchModifyImageVirusWhitelist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量修改容器镜像漏洞白名单
        /// </summary>
        /// <param name="req"><see cref="BatchModifyImageVulWhitelistRequest"/></param>
        /// <returns><see cref="BatchModifyImageVulWhitelistResponse"/></returns>
        public Task<BatchModifyImageVulWhitelistResponse> BatchModifyImageVulWhitelist(BatchModifyImageVulWhitelistRequest req)
        {
            return InternalRequestAsync<BatchModifyImageVulWhitelistResponse>(req, "BatchModifyImageVulWhitelist");
        }

        /// <summary>
        /// 批量修改容器镜像漏洞白名单
        /// </summary>
        /// <param name="req"><see cref="BatchModifyImageVulWhitelistRequest"/></param>
        /// <returns><see cref="BatchModifyImageVulWhitelistResponse"/></returns>
        public BatchModifyImageVulWhitelistResponse BatchModifyImageVulWhitelistSync(BatchModifyImageVulWhitelistRequest req)
        {
            return InternalRequestAsync<BatchModifyImageVulWhitelistResponse>(req, "BatchModifyImageVulWhitelist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 绑定集群负责人
        /// </summary>
        /// <param name="req"><see cref="BindClusterOwnerRequest"/></param>
        /// <returns><see cref="BindClusterOwnerResponse"/></returns>
        public Task<BindClusterOwnerResponse> BindClusterOwner(BindClusterOwnerRequest req)
        {
            return InternalRequestAsync<BindClusterOwnerResponse>(req, "BindClusterOwner");
        }

        /// <summary>
        /// 绑定集群负责人
        /// </summary>
        /// <param name="req"><see cref="BindClusterOwnerRequest"/></param>
        /// <returns><see cref="BindClusterOwnerResponse"/></returns>
        public BindClusterOwnerResponse BindClusterOwnerSync(BindClusterOwnerRequest req)
        {
            return InternalRequestAsync<BindClusterOwnerResponse>(req, "BindClusterOwner")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 取消已永久忽略的EDR多行为告警，从AI-Link永久忽略白名单移除对应主机+规则记录，并将告警状态恢复为待处理（PENDING）
        /// </summary>
        /// <param name="req"><see cref="CancelEdrAlertIgnoreRequest"/></param>
        /// <returns><see cref="CancelEdrAlertIgnoreResponse"/></returns>
        public Task<CancelEdrAlertIgnoreResponse> CancelEdrAlertIgnore(CancelEdrAlertIgnoreRequest req)
        {
            return InternalRequestAsync<CancelEdrAlertIgnoreResponse>(req, "CancelEdrAlertIgnore");
        }

        /// <summary>
        /// 取消已永久忽略的EDR多行为告警，从AI-Link永久忽略白名单移除对应主机+规则记录，并将告警状态恢复为待处理（PENDING）
        /// </summary>
        /// <param name="req"><see cref="CancelEdrAlertIgnoreRequest"/></param>
        /// <returns><see cref="CancelEdrAlertIgnoreResponse"/></returns>
        public CancelEdrAlertIgnoreResponse CancelEdrAlertIgnoreSync(CancelEdrAlertIgnoreRequest req)
        {
            return InternalRequestAsync<CancelEdrAlertIgnoreResponse>(req, "CancelEdrAlertIgnore")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 判断当前用户是否旗舰版(适用于主机)
        /// </summary>
        /// <param name="req"><see cref="CheckCWPExposePathPermissionRequest"/></param>
        /// <returns><see cref="CheckCWPExposePathPermissionResponse"/></returns>
        public Task<CheckCWPExposePathPermissionResponse> CheckCWPExposePathPermission(CheckCWPExposePathPermissionRequest req)
        {
            return InternalRequestAsync<CheckCWPExposePathPermissionResponse>(req, "CheckCWPExposePathPermission");
        }

        /// <summary>
        /// 判断当前用户是否旗舰版(适用于主机)
        /// </summary>
        /// <param name="req"><see cref="CheckCWPExposePathPermissionRequest"/></param>
        /// <returns><see cref="CheckCWPExposePathPermissionResponse"/></returns>
        public CheckCWPExposePathPermissionResponse CheckCWPExposePathPermissionSync(CheckCWPExposePathPermissionRequest req)
        {
            return InternalRequestAsync<CheckCWPExposePathPermissionResponse>(req, "CheckCWPExposePathPermission")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 检查镜像仓库实例名是否重复
        /// </summary>
        /// <param name="req"><see cref="CheckImageRegistryInstanceNameDuplicateRequest"/></param>
        /// <returns><see cref="CheckImageRegistryInstanceNameDuplicateResponse"/></returns>
        public Task<CheckImageRegistryInstanceNameDuplicateResponse> CheckImageRegistryInstanceNameDuplicate(CheckImageRegistryInstanceNameDuplicateRequest req)
        {
            return InternalRequestAsync<CheckImageRegistryInstanceNameDuplicateResponse>(req, "CheckImageRegistryInstanceNameDuplicate");
        }

        /// <summary>
        /// 检查镜像仓库实例名是否重复
        /// </summary>
        /// <param name="req"><see cref="CheckImageRegistryInstanceNameDuplicateRequest"/></param>
        /// <returns><see cref="CheckImageRegistryInstanceNameDuplicateResponse"/></returns>
        public CheckImageRegistryInstanceNameDuplicateResponse CheckImageRegistryInstanceNameDuplicateSync(CheckImageRegistryInstanceNameDuplicateRequest req)
        {
            return InternalRequestAsync<CheckImageRegistryInstanceNameDuplicateResponse>(req, "CheckImageRegistryInstanceNameDuplicate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 判断当前用户是否旗舰版
        /// </summary>
        /// <param name="req"><see cref="CheckIsUltimateVersionRequest"/></param>
        /// <returns><see cref="CheckIsUltimateVersionResponse"/></returns>
        public Task<CheckIsUltimateVersionResponse> CheckIsUltimateVersion(CheckIsUltimateVersionRequest req)
        {
            return InternalRequestAsync<CheckIsUltimateVersionResponse>(req, "CheckIsUltimateVersion");
        }

        /// <summary>
        /// 判断当前用户是否旗舰版
        /// </summary>
        /// <param name="req"><see cref="CheckIsUltimateVersionRequest"/></param>
        /// <returns><see cref="CheckIsUltimateVersionResponse"/></returns>
        public CheckIsUltimateVersionResponse CheckIsUltimateVersionSync(CheckIsUltimateVersionRequest req)
        {
            return InternalRequestAsync<CheckIsUltimateVersionResponse>(req, "CheckIsUltimateVersion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 风险验证示例
        /// </summary>
        /// <param name="req"><see cref="CheckRiskRequest"/></param>
        /// <returns><see cref="CheckRiskResponse"/></returns>
        public Task<CheckRiskResponse> CheckRisk(CheckRiskRequest req)
        {
            return InternalRequestAsync<CheckRiskResponse>(req, "CheckRisk");
        }

        /// <summary>
        /// 风险验证示例
        /// </summary>
        /// <param name="req"><see cref="CheckRiskRequest"/></param>
        /// <returns><see cref="CheckRiskResponse"/></returns>
        public CheckRiskResponse CheckRiskSync(CheckRiskRequest req)
        {
            return InternalRequestAsync<CheckRiskResponse>(req, "CheckRisk")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 复制自定义基线策略
        /// </summary>
        /// <param name="req"><see cref="CopyBaselinePolicyRequest"/></param>
        /// <returns><see cref="CopyBaselinePolicyResponse"/></returns>
        public Task<CopyBaselinePolicyResponse> CopyBaselinePolicy(CopyBaselinePolicyRequest req)
        {
            return InternalRequestAsync<CopyBaselinePolicyResponse>(req, "CopyBaselinePolicy");
        }

        /// <summary>
        /// 复制自定义基线策略
        /// </summary>
        /// <param name="req"><see cref="CopyBaselinePolicyRequest"/></param>
        /// <returns><see cref="CopyBaselinePolicyResponse"/></returns>
        public CopyBaselinePolicyResponse CopyBaselinePolicySync(CopyBaselinePolicyRequest req)
        {
            return InternalRequestAsync<CopyBaselinePolicyResponse>(req, "CopyBaselinePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建AI 定时任务。
        /// 
        /// 创建一个新的AI 定时任务，需传入任务名称、执行提示词和触发器配置。创建成功后返回AI 定时任务 ID。
        /// </summary>
        /// <param name="req"><see cref="CreateAIScheduleRequest"/></param>
        /// <returns><see cref="CreateAIScheduleResponse"/></returns>
        public Task<CreateAIScheduleResponse> CreateAISchedule(CreateAIScheduleRequest req)
        {
            return InternalRequestAsync<CreateAIScheduleResponse>(req, "CreateAISchedule");
        }

        /// <summary>
        /// 创建AI 定时任务。
        /// 
        /// 创建一个新的AI 定时任务，需传入任务名称、执行提示词和触发器配置。创建成功后返回AI 定时任务 ID。
        /// </summary>
        /// <param name="req"><see cref="CreateAIScheduleRequest"/></param>
        /// <returns><see cref="CreateAIScheduleResponse"/></returns>
        public CreateAIScheduleResponse CreateAIScheduleSync(CreateAIScheduleRequest req)
        {
            return InternalRequestAsync<CreateAIScheduleResponse>(req, "CreateAISchedule")
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
        /// 创建全部资产导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateAllAssetsExportJobRequest"/></param>
        /// <returns><see cref="CreateAllAssetsExportJobResponse"/></returns>
        public Task<CreateAllAssetsExportJobResponse> CreateAllAssetsExportJob(CreateAllAssetsExportJobRequest req)
        {
            return InternalRequestAsync<CreateAllAssetsExportJobResponse>(req, "CreateAllAssetsExportJob");
        }

        /// <summary>
        /// 创建全部资产导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateAllAssetsExportJobRequest"/></param>
        /// <returns><see cref="CreateAllAssetsExportJobResponse"/></returns>
        public CreateAllAssetsExportJobResponse CreateAllAssetsExportJobSync(CreateAllAssetsExportJobRequest req)
        {
            return InternalRequestAsync<CreateAllAssetsExportJobResponse>(req, "CreateAllAssetsExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建镜像资产中组件列表导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateAssetComponentListExportJobRequest"/></param>
        /// <returns><see cref="CreateAssetComponentListExportJobResponse"/></returns>
        public Task<CreateAssetComponentListExportJobResponse> CreateAssetComponentListExportJob(CreateAssetComponentListExportJobRequest req)
        {
            return InternalRequestAsync<CreateAssetComponentListExportJobResponse>(req, "CreateAssetComponentListExportJob");
        }

        /// <summary>
        /// 创建镜像资产中组件列表导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateAssetComponentListExportJobRequest"/></param>
        /// <returns><see cref="CreateAssetComponentListExportJobResponse"/></returns>
        public CreateAssetComponentListExportJobResponse CreateAssetComponentListExportJobSync(CreateAssetComponentListExportJobRequest req)
        {
            return InternalRequestAsync<CreateAssetComponentListExportJobResponse>(req, "CreateAssetComponentListExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建镜像仓库组件关联镜像列表导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateAssetComponentRelatedImageListExportJobRequest"/></param>
        /// <returns><see cref="CreateAssetComponentRelatedImageListExportJobResponse"/></returns>
        public Task<CreateAssetComponentRelatedImageListExportJobResponse> CreateAssetComponentRelatedImageListExportJob(CreateAssetComponentRelatedImageListExportJobRequest req)
        {
            return InternalRequestAsync<CreateAssetComponentRelatedImageListExportJobResponse>(req, "CreateAssetComponentRelatedImageListExportJob");
        }

        /// <summary>
        /// 创建镜像仓库组件关联镜像列表导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateAssetComponentRelatedImageListExportJobRequest"/></param>
        /// <returns><see cref="CreateAssetComponentRelatedImageListExportJobResponse"/></returns>
        public CreateAssetComponentRelatedImageListExportJobResponse CreateAssetComponentRelatedImageListExportJobSync(CreateAssetComponentRelatedImageListExportJobRequest req)
        {
            return InternalRequestAsync<CreateAssetComponentRelatedImageListExportJobResponse>(req, "CreateAssetComponentRelatedImageListExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建资产搜索视图
        /// </summary>
        /// <param name="req"><see cref="CreateAssetFilterViewRequest"/></param>
        /// <returns><see cref="CreateAssetFilterViewResponse"/></returns>
        public Task<CreateAssetFilterViewResponse> CreateAssetFilterView(CreateAssetFilterViewRequest req)
        {
            return InternalRequestAsync<CreateAssetFilterViewResponse>(req, "CreateAssetFilterView");
        }

        /// <summary>
        /// 创建资产搜索视图
        /// </summary>
        /// <param name="req"><see cref="CreateAssetFilterViewRequest"/></param>
        /// <returns><see cref="CreateAssetFilterViewResponse"/></returns>
        public CreateAssetFilterViewResponse CreateAssetFilterViewSync(CreateAssetFilterViewRequest req)
        {
            return InternalRequestAsync<CreateAssetFilterViewResponse>(req, "CreateAssetFilterView")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建主机进程列表导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateAssetProcessExportJobRequest"/></param>
        /// <returns><see cref="CreateAssetProcessExportJobResponse"/></returns>
        public Task<CreateAssetProcessExportJobResponse> CreateAssetProcessExportJob(CreateAssetProcessExportJobRequest req)
        {
            return InternalRequestAsync<CreateAssetProcessExportJobResponse>(req, "CreateAssetProcessExportJob");
        }

        /// <summary>
        /// 创建主机进程列表导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateAssetProcessExportJobRequest"/></param>
        /// <returns><see cref="CreateAssetProcessExportJobResponse"/></returns>
        public CreateAssetProcessExportJobResponse CreateAssetProcessExportJobSync(CreateAssetProcessExportJobRequest req)
        {
            return InternalRequestAsync<CreateAssetProcessExportJobResponse>(req, "CreateAssetProcessExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建资产同步任务
        /// </summary>
        /// <param name="req"><see cref="CreateAssetSyncTaskRequest"/></param>
        /// <returns><see cref="CreateAssetSyncTaskResponse"/></returns>
        public Task<CreateAssetSyncTaskResponse> CreateAssetSyncTask(CreateAssetSyncTaskRequest req)
        {
            return InternalRequestAsync<CreateAssetSyncTaskResponse>(req, "CreateAssetSyncTask");
        }

        /// <summary>
        /// 创建资产同步任务
        /// </summary>
        /// <param name="req"><see cref="CreateAssetSyncTaskRequest"/></param>
        /// <returns><see cref="CreateAssetSyncTaskResponse"/></returns>
        public CreateAssetSyncTaskResponse CreateAssetSyncTaskSync(CreateAssetSyncTaskRequest req)
        {
            return InternalRequestAsync<CreateAssetSyncTaskResponse>(req, "CreateAssetSyncTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建资产标签
        /// </summary>
        /// <param name="req"><see cref="CreateAssetTagRequest"/></param>
        /// <returns><see cref="CreateAssetTagResponse"/></returns>
        public Task<CreateAssetTagResponse> CreateAssetTag(CreateAssetTagRequest req)
        {
            return InternalRequestAsync<CreateAssetTagResponse>(req, "CreateAssetTag");
        }

        /// <summary>
        /// 创建资产标签
        /// </summary>
        /// <param name="req"><see cref="CreateAssetTagRequest"/></param>
        /// <returns><see cref="CreateAssetTagResponse"/></returns>
        public CreateAssetTagResponse CreateAssetTagSync(CreateAssetTagRequest req)
        {
            return InternalRequestAsync<CreateAssetTagResponse>(req, "CreateAssetTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建资产视角下风险列表导出任务示例
        /// </summary>
        /// <param name="req"><see cref="CreateAssetViewRisksExportJobRequest"/></param>
        /// <returns><see cref="CreateAssetViewRisksExportJobResponse"/></returns>
        public Task<CreateAssetViewRisksExportJobResponse> CreateAssetViewRisksExportJob(CreateAssetViewRisksExportJobRequest req)
        {
            return InternalRequestAsync<CreateAssetViewRisksExportJobResponse>(req, "CreateAssetViewRisksExportJob");
        }

        /// <summary>
        /// 创建资产视角下风险列表导出任务示例
        /// </summary>
        /// <param name="req"><see cref="CreateAssetViewRisksExportJobRequest"/></param>
        /// <returns><see cref="CreateAssetViewRisksExportJobResponse"/></returns>
        public CreateAssetViewRisksExportJobResponse CreateAssetViewRisksExportJobSync(CreateAssetViewRisksExportJobRequest req)
        {
            return InternalRequestAsync<CreateAssetViewRisksExportJobResponse>(req, "CreateAssetViewRisksExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建基线聚合检测项导出任务。通过 ExportType 选择导出统计结果或风险明细，可按策略、分类等条件限定范围；任务在后台异步执行，完成后可在导出任务列表中下载结果文件。
        /// </summary>
        /// <param name="req"><see cref="CreateBaselineAggregatedItemExportJobRequest"/></param>
        /// <returns><see cref="CreateBaselineAggregatedItemExportJobResponse"/></returns>
        public Task<CreateBaselineAggregatedItemExportJobResponse> CreateBaselineAggregatedItemExportJob(CreateBaselineAggregatedItemExportJobRequest req)
        {
            return InternalRequestAsync<CreateBaselineAggregatedItemExportJobResponse>(req, "CreateBaselineAggregatedItemExportJob");
        }

        /// <summary>
        /// 创建基线聚合检测项导出任务。通过 ExportType 选择导出统计结果或风险明细，可按策略、分类等条件限定范围；任务在后台异步执行，完成后可在导出任务列表中下载结果文件。
        /// </summary>
        /// <param name="req"><see cref="CreateBaselineAggregatedItemExportJobRequest"/></param>
        /// <returns><see cref="CreateBaselineAggregatedItemExportJobResponse"/></returns>
        public CreateBaselineAggregatedItemExportJobResponse CreateBaselineAggregatedItemExportJobSync(CreateBaselineAggregatedItemExportJobRequest req)
        {
            return InternalRequestAsync<CreateBaselineAggregatedItemExportJobResponse>(req, "CreateBaselineAggregatedItemExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建基线修复记录导出任务，导出已修复检测项的记录数据（含检测项信息、资产信息、修复时间等）。任务在后台异步执行，完成后可在导出任务列表中下载结果文件。
        /// </summary>
        /// <param name="req"><see cref="CreateBaselineFixRecordExportJobRequest"/></param>
        /// <returns><see cref="CreateBaselineFixRecordExportJobResponse"/></returns>
        public Task<CreateBaselineFixRecordExportJobResponse> CreateBaselineFixRecordExportJob(CreateBaselineFixRecordExportJobRequest req)
        {
            return InternalRequestAsync<CreateBaselineFixRecordExportJobResponse>(req, "CreateBaselineFixRecordExportJob");
        }

        /// <summary>
        /// 创建基线修复记录导出任务，导出已修复检测项的记录数据（含检测项信息、资产信息、修复时间等）。任务在后台异步执行，完成后可在导出任务列表中下载结果文件。
        /// </summary>
        /// <param name="req"><see cref="CreateBaselineFixRecordExportJobRequest"/></param>
        /// <returns><see cref="CreateBaselineFixRecordExportJobResponse"/></returns>
        public CreateBaselineFixRecordExportJobResponse CreateBaselineFixRecordExportJobSync(CreateBaselineFixRecordExportJobRequest req)
        {
            return InternalRequestAsync<CreateBaselineFixRecordExportJobResponse>(req, "CreateBaselineFixRecordExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建基线主任务导出任务，导出指定主任务下的检测项与子任务数据。任务在后台异步执行，完成后可在导出任务列表中下载结果文件。
        /// </summary>
        /// <param name="req"><see cref="CreateBaselineMainTaskExportJobRequest"/></param>
        /// <returns><see cref="CreateBaselineMainTaskExportJobResponse"/></returns>
        public Task<CreateBaselineMainTaskExportJobResponse> CreateBaselineMainTaskExportJob(CreateBaselineMainTaskExportJobRequest req)
        {
            return InternalRequestAsync<CreateBaselineMainTaskExportJobResponse>(req, "CreateBaselineMainTaskExportJob");
        }

        /// <summary>
        /// 创建基线主任务导出任务，导出指定主任务下的检测项与子任务数据。任务在后台异步执行，完成后可在导出任务列表中下载结果文件。
        /// </summary>
        /// <param name="req"><see cref="CreateBaselineMainTaskExportJobRequest"/></param>
        /// <returns><see cref="CreateBaselineMainTaskExportJobResponse"/></returns>
        public CreateBaselineMainTaskExportJobResponse CreateBaselineMainTaskExportJobSync(CreateBaselineMainTaskExportJobRequest req)
        {
            return InternalRequestAsync<CreateBaselineMainTaskExportJobResponse>(req, "CreateBaselineMainTaskExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建云资源配置检测PDF报告导出任务示例
        /// </summary>
        /// <param name="req"><see cref="CreateCFGRiskPDFReportExportJobRequest"/></param>
        /// <returns><see cref="CreateCFGRiskPDFReportExportJobResponse"/></returns>
        public Task<CreateCFGRiskPDFReportExportJobResponse> CreateCFGRiskPDFReportExportJob(CreateCFGRiskPDFReportExportJobRequest req)
        {
            return InternalRequestAsync<CreateCFGRiskPDFReportExportJobResponse>(req, "CreateCFGRiskPDFReportExportJob");
        }

        /// <summary>
        /// 创建云资源配置检测PDF报告导出任务示例
        /// </summary>
        /// <param name="req"><see cref="CreateCFGRiskPDFReportExportJobRequest"/></param>
        /// <returns><see cref="CreateCFGRiskPDFReportExportJobResponse"/></returns>
        public CreateCFGRiskPDFReportExportJobResponse CreateCFGRiskPDFReportExportJobSync(CreateCFGRiskPDFReportExportJobRequest req)
        {
            return InternalRequestAsync<CreateCFGRiskPDFReportExportJobResponse>(req, "CreateCFGRiskPDFReportExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建资产视角下风险列表导出任务示例
        /// </summary>
        /// <param name="req"><see cref="CreateCFGRisksExportJobRequest"/></param>
        /// <returns><see cref="CreateCFGRisksExportJobResponse"/></returns>
        public Task<CreateCFGRisksExportJobResponse> CreateCFGRisksExportJob(CreateCFGRisksExportJobRequest req)
        {
            return InternalRequestAsync<CreateCFGRisksExportJobResponse>(req, "CreateCFGRisksExportJob");
        }

        /// <summary>
        /// 创建资产视角下风险列表导出任务示例
        /// </summary>
        /// <param name="req"><see cref="CreateCFGRisksExportJobRequest"/></param>
        /// <returns><see cref="CreateCFGRisksExportJobResponse"/></returns>
        public CreateCFGRisksExportJobResponse CreateCFGRisksExportJobSync(CreateCFGRisksExportJobRequest req)
        {
            return InternalRequestAsync<CreateCFGRisksExportJobResponse>(req, "CreateCFGRisksExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// CSIP 手动扫描创建接口
        /// </summary>
        /// <param name="req"><see cref="CreateCSIPManualMalwareScanRequest"/></param>
        /// <returns><see cref="CreateCSIPManualMalwareScanResponse"/></returns>
        public Task<CreateCSIPManualMalwareScanResponse> CreateCSIPManualMalwareScan(CreateCSIPManualMalwareScanRequest req)
        {
            return InternalRequestAsync<CreateCSIPManualMalwareScanResponse>(req, "CreateCSIPManualMalwareScan");
        }

        /// <summary>
        /// CSIP 手动扫描创建接口
        /// </summary>
        /// <param name="req"><see cref="CreateCSIPManualMalwareScanRequest"/></param>
        /// <returns><see cref="CreateCSIPManualMalwareScanResponse"/></returns>
        public CreateCSIPManualMalwareScanResponse CreateCSIPManualMalwareScanSync(CreateCSIPManualMalwareScanRequest req)
        {
            return InternalRequestAsync<CreateCSIPManualMalwareScanResponse>(req, "CreateCSIPManualMalwareScan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建资产视角下风险列表导出任务示例
        /// </summary>
        /// <param name="req"><see cref="CreateCheckViewRisksExportJobRequest"/></param>
        /// <returns><see cref="CreateCheckViewRisksExportJobResponse"/></returns>
        public Task<CreateCheckViewRisksExportJobResponse> CreateCheckViewRisksExportJob(CreateCheckViewRisksExportJobRequest req)
        {
            return InternalRequestAsync<CreateCheckViewRisksExportJobResponse>(req, "CreateCheckViewRisksExportJob");
        }

        /// <summary>
        /// 创建资产视角下风险列表导出任务示例
        /// </summary>
        /// <param name="req"><see cref="CreateCheckViewRisksExportJobRequest"/></param>
        /// <returns><see cref="CreateCheckViewRisksExportJobResponse"/></returns>
        public CreateCheckViewRisksExportJobResponse CreateCheckViewRisksExportJobSync(CreateCheckViewRisksExportJobRequest req)
        {
            return InternalRequestAsync<CreateCheckViewRisksExportJobResponse>(req, "CreateCheckViewRisksExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建云函数导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateCloudFunctionExportJobRequest"/></param>
        /// <returns><see cref="CreateCloudFunctionExportJobResponse"/></returns>
        public Task<CreateCloudFunctionExportJobResponse> CreateCloudFunctionExportJob(CreateCloudFunctionExportJobRequest req)
        {
            return InternalRequestAsync<CreateCloudFunctionExportJobResponse>(req, "CreateCloudFunctionExportJob");
        }

        /// <summary>
        /// 创建云函数导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateCloudFunctionExportJobRequest"/></param>
        /// <returns><see cref="CreateCloudFunctionExportJobResponse"/></returns>
        public CreateCloudFunctionExportJobResponse CreateCloudFunctionExportJobSync(CreateCloudFunctionExportJobRequest req)
        {
            return InternalRequestAsync<CreateCloudFunctionExportJobResponse>(req, "CreateCloudFunctionExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建集群资产同步任务
        /// </summary>
        /// <param name="req"><see cref="CreateClusterAssetSyncTaskRequest"/></param>
        /// <returns><see cref="CreateClusterAssetSyncTaskResponse"/></returns>
        public Task<CreateClusterAssetSyncTaskResponse> CreateClusterAssetSyncTask(CreateClusterAssetSyncTaskRequest req)
        {
            return InternalRequestAsync<CreateClusterAssetSyncTaskResponse>(req, "CreateClusterAssetSyncTask");
        }

        /// <summary>
        /// 创建集群资产同步任务
        /// </summary>
        /// <param name="req"><see cref="CreateClusterAssetSyncTaskRequest"/></param>
        /// <returns><see cref="CreateClusterAssetSyncTaskResponse"/></returns>
        public CreateClusterAssetSyncTaskResponse CreateClusterAssetSyncTaskSync(CreateClusterAssetSyncTaskRequest req)
        {
            return InternalRequestAsync<CreateClusterAssetSyncTaskResponse>(req, "CreateClusterAssetSyncTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建集群容器列表导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateClusterContainerListExportJobRequest"/></param>
        /// <returns><see cref="CreateClusterContainerListExportJobResponse"/></returns>
        public Task<CreateClusterContainerListExportJobResponse> CreateClusterContainerListExportJob(CreateClusterContainerListExportJobRequest req)
        {
            return InternalRequestAsync<CreateClusterContainerListExportJobResponse>(req, "CreateClusterContainerListExportJob");
        }

        /// <summary>
        /// 创建集群容器列表导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateClusterContainerListExportJobRequest"/></param>
        /// <returns><see cref="CreateClusterContainerListExportJobResponse"/></returns>
        public CreateClusterContainerListExportJobResponse CreateClusterContainerListExportJobSync(CreateClusterContainerListExportJobRequest req)
        {
            return InternalRequestAsync<CreateClusterContainerListExportJobResponse>(req, "CreateClusterContainerListExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建集群列表导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateClusterListExportJobRequest"/></param>
        /// <returns><see cref="CreateClusterListExportJobResponse"/></returns>
        public Task<CreateClusterListExportJobResponse> CreateClusterListExportJob(CreateClusterListExportJobRequest req)
        {
            return InternalRequestAsync<CreateClusterListExportJobResponse>(req, "CreateClusterListExportJob");
        }

        /// <summary>
        /// 创建集群列表导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateClusterListExportJobRequest"/></param>
        /// <returns><see cref="CreateClusterListExportJobResponse"/></returns>
        public CreateClusterListExportJobResponse CreateClusterListExportJobSync(CreateClusterListExportJobRequest req)
        {
            return InternalRequestAsync<CreateClusterListExportJobResponse>(req, "CreateClusterListExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建集群命名空间列表导出任务。导出字段包含命名空间名称、Labels、创建时间。支持Filter过滤。导出通过异步任务实现，返回JobId后前端轮询查询导出任务状态。
        /// </summary>
        /// <param name="req"><see cref="CreateClusterNamespaceListExportJobRequest"/></param>
        /// <returns><see cref="CreateClusterNamespaceListExportJobResponse"/></returns>
        public Task<CreateClusterNamespaceListExportJobResponse> CreateClusterNamespaceListExportJob(CreateClusterNamespaceListExportJobRequest req)
        {
            return InternalRequestAsync<CreateClusterNamespaceListExportJobResponse>(req, "CreateClusterNamespaceListExportJob");
        }

        /// <summary>
        /// 创建集群命名空间列表导出任务。导出字段包含命名空间名称、Labels、创建时间。支持Filter过滤。导出通过异步任务实现，返回JobId后前端轮询查询导出任务状态。
        /// </summary>
        /// <param name="req"><see cref="CreateClusterNamespaceListExportJobRequest"/></param>
        /// <returns><see cref="CreateClusterNamespaceListExportJobResponse"/></returns>
        public CreateClusterNamespaceListExportJobResponse CreateClusterNamespaceListExportJobSync(CreateClusterNamespaceListExportJobRequest req)
        {
            return InternalRequestAsync<CreateClusterNamespaceListExportJobResponse>(req, "CreateClusterNamespaceListExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建集群节点列表导出任务。导出字段包含节点ID、节点名称、公网IP、内网IP、节点类型、核数、客户端状态、运行状态。NodeType和ClientStatus、RunStatus均经过国际化翻译。支持Filter过滤（含ClientStatus内存过滤）。导出通过异步任务实现，返回JobId后前端轮询查询导出任务状态。
        /// </summary>
        /// <param name="req"><see cref="CreateClusterNodeListExportJobRequest"/></param>
        /// <returns><see cref="CreateClusterNodeListExportJobResponse"/></returns>
        public Task<CreateClusterNodeListExportJobResponse> CreateClusterNodeListExportJob(CreateClusterNodeListExportJobRequest req)
        {
            return InternalRequestAsync<CreateClusterNodeListExportJobResponse>(req, "CreateClusterNodeListExportJob");
        }

        /// <summary>
        /// 创建集群节点列表导出任务。导出字段包含节点ID、节点名称、公网IP、内网IP、节点类型、核数、客户端状态、运行状态。NodeType和ClientStatus、RunStatus均经过国际化翻译。支持Filter过滤（含ClientStatus内存过滤）。导出通过异步任务实现，返回JobId后前端轮询查询导出任务状态。
        /// </summary>
        /// <param name="req"><see cref="CreateClusterNodeListExportJobRequest"/></param>
        /// <returns><see cref="CreateClusterNodeListExportJobResponse"/></returns>
        public CreateClusterNodeListExportJobResponse CreateClusterNodeListExportJobSync(CreateClusterNodeListExportJobRequest req)
        {
            return InternalRequestAsync<CreateClusterNodeListExportJobResponse>(req, "CreateClusterNodeListExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建合规标准聚合视角下风险列表导出任务示例
        /// </summary>
        /// <param name="req"><see cref="CreateComplianceRiskExportJobRequest"/></param>
        /// <returns><see cref="CreateComplianceRiskExportJobResponse"/></returns>
        public Task<CreateComplianceRiskExportJobResponse> CreateComplianceRiskExportJob(CreateComplianceRiskExportJobRequest req)
        {
            return InternalRequestAsync<CreateComplianceRiskExportJobResponse>(req, "CreateComplianceRiskExportJob");
        }

        /// <summary>
        /// 创建合规标准聚合视角下风险列表导出任务示例
        /// </summary>
        /// <param name="req"><see cref="CreateComplianceRiskExportJobRequest"/></param>
        /// <returns><see cref="CreateComplianceRiskExportJobResponse"/></returns>
        public CreateComplianceRiskExportJobResponse CreateComplianceRiskExportJobSync(CreateComplianceRiskExportJobRequest req)
        {
            return InternalRequestAsync<CreateComplianceRiskExportJobResponse>(req, "CreateComplianceRiskExportJob")
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
        /// 创建公网资产导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateDynamicAssetsExportJobRequest"/></param>
        /// <returns><see cref="CreateDynamicAssetsExportJobResponse"/></returns>
        public Task<CreateDynamicAssetsExportJobResponse> CreateDynamicAssetsExportJob(CreateDynamicAssetsExportJobRequest req)
        {
            return InternalRequestAsync<CreateDynamicAssetsExportJobResponse>(req, "CreateDynamicAssetsExportJob");
        }

        /// <summary>
        /// 创建公网资产导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateDynamicAssetsExportJobRequest"/></param>
        /// <returns><see cref="CreateDynamicAssetsExportJobResponse"/></returns>
        public CreateDynamicAssetsExportJobResponse CreateDynamicAssetsExportJobSync(CreateDynamicAssetsExportJobRequest req)
        {
            return InternalRequestAsync<CreateDynamicAssetsExportJobResponse>(req, "CreateDynamicAssetsExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 点击开始扫描后触发，支持多账号、多资产类型。同时选主机和容器集群时拆分为两个独立任务（主机+容器）。
        /// </summary>
        /// <param name="req"><see cref="CreateEDRManualScanRequest"/></param>
        /// <returns><see cref="CreateEDRManualScanResponse"/></returns>
        public Task<CreateEDRManualScanResponse> CreateEDRManualScan(CreateEDRManualScanRequest req)
        {
            return InternalRequestAsync<CreateEDRManualScanResponse>(req, "CreateEDRManualScan");
        }

        /// <summary>
        /// 点击开始扫描后触发，支持多账号、多资产类型。同时选主机和容器集群时拆分为两个独立任务（主机+容器）。
        /// </summary>
        /// <param name="req"><see cref="CreateEDRManualScanRequest"/></param>
        /// <returns><see cref="CreateEDRManualScanResponse"/></returns>
        public CreateEDRManualScanResponse CreateEDRManualScanSync(CreateEDRManualScanRequest req)
        {
            return InternalRequestAsync<CreateEDRManualScanResponse>(req, "CreateEDRManualScan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建EDR告警导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateEdrAlertExportJobRequest"/></param>
        /// <returns><see cref="CreateEdrAlertExportJobResponse"/></returns>
        public Task<CreateEdrAlertExportJobResponse> CreateEdrAlertExportJob(CreateEdrAlertExportJobRequest req)
        {
            return InternalRequestAsync<CreateEdrAlertExportJobResponse>(req, "CreateEdrAlertExportJob");
        }

        /// <summary>
        /// 创建EDR告警导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateEdrAlertExportJobRequest"/></param>
        /// <returns><see cref="CreateEdrAlertExportJobResponse"/></returns>
        public CreateEdrAlertExportJobResponse CreateEdrAlertExportJobSync(CreateEdrAlertExportJobRequest req)
        {
            return InternalRequestAsync<CreateEdrAlertExportJobResponse>(req, "CreateEdrAlertExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建EDR告警普通导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateEdrLessAlertExportJobRequest"/></param>
        /// <returns><see cref="CreateEdrLessAlertExportJobResponse"/></returns>
        public Task<CreateEdrLessAlertExportJobResponse> CreateEdrLessAlertExportJob(CreateEdrLessAlertExportJobRequest req)
        {
            return InternalRequestAsync<CreateEdrLessAlertExportJobResponse>(req, "CreateEdrLessAlertExportJob");
        }

        /// <summary>
        /// 创建EDR告警普通导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateEdrLessAlertExportJobRequest"/></param>
        /// <returns><see cref="CreateEdrLessAlertExportJobResponse"/></returns>
        public CreateEdrLessAlertExportJobResponse CreateEdrLessAlertExportJobSync(CreateEdrLessAlertExportJobRequest req)
        {
            return InternalRequestAsync<CreateEdrLessAlertExportJobResponse>(req, "CreateEdrLessAlertExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云边界自动打标-创建规则
        /// </summary>
        /// <param name="req"><see cref="CreateExposureAutoTagRuleRequest"/></param>
        /// <returns><see cref="CreateExposureAutoTagRuleResponse"/></returns>
        public Task<CreateExposureAutoTagRuleResponse> CreateExposureAutoTagRule(CreateExposureAutoTagRuleRequest req)
        {
            return InternalRequestAsync<CreateExposureAutoTagRuleResponse>(req, "CreateExposureAutoTagRule");
        }

        /// <summary>
        /// 云边界自动打标-创建规则
        /// </summary>
        /// <param name="req"><see cref="CreateExposureAutoTagRuleRequest"/></param>
        /// <returns><see cref="CreateExposureAutoTagRuleResponse"/></returns>
        public CreateExposureAutoTagRuleResponse CreateExposureAutoTagRuleSync(CreateExposureAutoTagRuleRequest req)
        {
            return InternalRequestAsync<CreateExposureAutoTagRuleResponse>(req, "CreateExposureAutoTagRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 暴露资产导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateExposuresExportJobRequest"/></param>
        /// <returns><see cref="CreateExposuresExportJobResponse"/></returns>
        public Task<CreateExposuresExportJobResponse> CreateExposuresExportJob(CreateExposuresExportJobRequest req)
        {
            return InternalRequestAsync<CreateExposuresExportJobResponse>(req, "CreateExposuresExportJob");
        }

        /// <summary>
        /// 暴露资产导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateExposuresExportJobRequest"/></param>
        /// <returns><see cref="CreateExposuresExportJobResponse"/></returns>
        public CreateExposuresExportJobResponse CreateExposuresExportJobSync(CreateExposuresExportJobRequest req)
        {
            return InternalRequestAsync<CreateExposuresExportJobResponse>(req, "CreateExposuresExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建高危基线风险导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateHighBaseLineRisksExportJobRequest"/></param>
        /// <returns><see cref="CreateHighBaseLineRisksExportJobResponse"/></returns>
        public Task<CreateHighBaseLineRisksExportJobResponse> CreateHighBaseLineRisksExportJob(CreateHighBaseLineRisksExportJobRequest req)
        {
            return InternalRequestAsync<CreateHighBaseLineRisksExportJobResponse>(req, "CreateHighBaseLineRisksExportJob");
        }

        /// <summary>
        /// 创建高危基线风险导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateHighBaseLineRisksExportJobRequest"/></param>
        /// <returns><see cref="CreateHighBaseLineRisksExportJobResponse"/></returns>
        public CreateHighBaseLineRisksExportJobResponse CreateHighBaseLineRisksExportJobSync(CreateHighBaseLineRisksExportJobRequest req)
        {
            return InternalRequestAsync<CreateHighBaseLineRisksExportJobResponse>(req, "CreateHighBaseLineRisksExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建主机列漏洞表导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateHostVulExportJobRequest"/></param>
        /// <returns><see cref="CreateHostVulExportJobResponse"/></returns>
        public Task<CreateHostVulExportJobResponse> CreateHostVulExportJob(CreateHostVulExportJobRequest req)
        {
            return InternalRequestAsync<CreateHostVulExportJobResponse>(req, "CreateHostVulExportJob");
        }

        /// <summary>
        /// 创建主机列漏洞表导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateHostVulExportJobRequest"/></param>
        /// <returns><see cref="CreateHostVulExportJobResponse"/></returns>
        public CreateHostVulExportJobResponse CreateHostVulExportJobSync(CreateHostVulExportJobRequest req)
        {
            return InternalRequestAsync<CreateHostVulExportJobResponse>(req, "CreateHostVulExportJob")
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
        /// 创建镜像资产列表导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateImageAssetListExportJobRequest"/></param>
        /// <returns><see cref="CreateImageAssetListExportJobResponse"/></returns>
        public Task<CreateImageAssetListExportJobResponse> CreateImageAssetListExportJob(CreateImageAssetListExportJobRequest req)
        {
            return InternalRequestAsync<CreateImageAssetListExportJobResponse>(req, "CreateImageAssetListExportJob");
        }

        /// <summary>
        /// 创建镜像资产列表导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateImageAssetListExportJobRequest"/></param>
        /// <returns><see cref="CreateImageAssetListExportJobResponse"/></returns>
        public CreateImageAssetListExportJobResponse CreateImageAssetListExportJobSync(CreateImageAssetListExportJobRequest req)
        {
            return InternalRequestAsync<CreateImageAssetListExportJobResponse>(req, "CreateImageAssetListExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建镜像关联容器资产导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateImageAssociatedContainerListExportJobRequest"/></param>
        /// <returns><see cref="CreateImageAssociatedContainerListExportJobResponse"/></returns>
        public Task<CreateImageAssociatedContainerListExportJobResponse> CreateImageAssociatedContainerListExportJob(CreateImageAssociatedContainerListExportJobRequest req)
        {
            return InternalRequestAsync<CreateImageAssociatedContainerListExportJobResponse>(req, "CreateImageAssociatedContainerListExportJob");
        }

        /// <summary>
        /// 创建镜像关联容器资产导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateImageAssociatedContainerListExportJobRequest"/></param>
        /// <returns><see cref="CreateImageAssociatedContainerListExportJobResponse"/></returns>
        public CreateImageAssociatedContainerListExportJobResponse CreateImageAssociatedContainerListExportJobSync(CreateImageAssociatedContainerListExportJobRequest req)
        {
            return InternalRequestAsync<CreateImageAssociatedContainerListExportJobResponse>(req, "CreateImageAssociatedContainerListExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建镜像关联主机资产列表导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateImageAssociatedHostListExportJobRequest"/></param>
        /// <returns><see cref="CreateImageAssociatedHostListExportJobResponse"/></returns>
        public Task<CreateImageAssociatedHostListExportJobResponse> CreateImageAssociatedHostListExportJob(CreateImageAssociatedHostListExportJobRequest req)
        {
            return InternalRequestAsync<CreateImageAssociatedHostListExportJobResponse>(req, "CreateImageAssociatedHostListExportJob");
        }

        /// <summary>
        /// 创建镜像关联主机资产列表导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateImageAssociatedHostListExportJobRequest"/></param>
        /// <returns><see cref="CreateImageAssociatedHostListExportJobResponse"/></returns>
        public CreateImageAssociatedHostListExportJobResponse CreateImageAssociatedHostListExportJobSync(CreateImageAssociatedHostListExportJobRequest req)
        {
            return InternalRequestAsync<CreateImageAssociatedHostListExportJobResponse>(req, "CreateImageAssociatedHostListExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建镜像组件列表导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateImageComponentListExportJobRequest"/></param>
        /// <returns><see cref="CreateImageComponentListExportJobResponse"/></returns>
        public Task<CreateImageComponentListExportJobResponse> CreateImageComponentListExportJob(CreateImageComponentListExportJobRequest req)
        {
            return InternalRequestAsync<CreateImageComponentListExportJobResponse>(req, "CreateImageComponentListExportJob");
        }

        /// <summary>
        /// 创建镜像组件列表导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateImageComponentListExportJobRequest"/></param>
        /// <returns><see cref="CreateImageComponentListExportJobResponse"/></returns>
        public CreateImageComponentListExportJobResponse CreateImageComponentListExportJobSync(CreateImageComponentListExportJobRequest req)
        {
            return InternalRequestAsync<CreateImageComponentListExportJobResponse>(req, "CreateImageComponentListExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建镜像层漏洞列表导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateImageLayerVulListExportJobRequest"/></param>
        /// <returns><see cref="CreateImageLayerVulListExportJobResponse"/></returns>
        public Task<CreateImageLayerVulListExportJobResponse> CreateImageLayerVulListExportJob(CreateImageLayerVulListExportJobRequest req)
        {
            return InternalRequestAsync<CreateImageLayerVulListExportJobResponse>(req, "CreateImageLayerVulListExportJob");
        }

        /// <summary>
        /// 创建镜像层漏洞列表导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateImageLayerVulListExportJobRequest"/></param>
        /// <returns><see cref="CreateImageLayerVulListExportJobResponse"/></returns>
        public CreateImageLayerVulListExportJobResponse CreateImageLayerVulListExportJobSync(CreateImageLayerVulListExportJobRequest req)
        {
            return InternalRequestAsync<CreateImageLayerVulListExportJobResponse>(req, "CreateImageLayerVulListExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建镜像仓库联通性检查任务
        /// </summary>
        /// <param name="req"><see cref="CreateImageRegistryConnectivityTaskRequest"/></param>
        /// <returns><see cref="CreateImageRegistryConnectivityTaskResponse"/></returns>
        public Task<CreateImageRegistryConnectivityTaskResponse> CreateImageRegistryConnectivityTask(CreateImageRegistryConnectivityTaskRequest req)
        {
            return InternalRequestAsync<CreateImageRegistryConnectivityTaskResponse>(req, "CreateImageRegistryConnectivityTask");
        }

        /// <summary>
        /// 创建镜像仓库联通性检查任务
        /// </summary>
        /// <param name="req"><see cref="CreateImageRegistryConnectivityTaskRequest"/></param>
        /// <returns><see cref="CreateImageRegistryConnectivityTaskResponse"/></returns>
        public CreateImageRegistryConnectivityTaskResponse CreateImageRegistryConnectivityTaskSync(CreateImageRegistryConnectivityTaskRequest req)
        {
            return InternalRequestAsync<CreateImageRegistryConnectivityTaskResponse>(req, "CreateImageRegistryConnectivityTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建镜像仓库列表导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateImageRegistryListExportJobRequest"/></param>
        /// <returns><see cref="CreateImageRegistryListExportJobResponse"/></returns>
        public Task<CreateImageRegistryListExportJobResponse> CreateImageRegistryListExportJob(CreateImageRegistryListExportJobRequest req)
        {
            return InternalRequestAsync<CreateImageRegistryListExportJobResponse>(req, "CreateImageRegistryListExportJob");
        }

        /// <summary>
        /// 创建镜像仓库列表导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateImageRegistryListExportJobRequest"/></param>
        /// <returns><see cref="CreateImageRegistryListExportJobResponse"/></returns>
        public CreateImageRegistryListExportJobResponse CreateImageRegistryListExportJobSync(CreateImageRegistryListExportJobRequest req)
        {
            return InternalRequestAsync<CreateImageRegistryListExportJobResponse>(req, "CreateImageRegistryListExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建镜像扫描任务
        /// </summary>
        /// <param name="req"><see cref="CreateImageRegistryScanTaskRequest"/></param>
        /// <returns><see cref="CreateImageRegistryScanTaskResponse"/></returns>
        public Task<CreateImageRegistryScanTaskResponse> CreateImageRegistryScanTask(CreateImageRegistryScanTaskRequest req)
        {
            return InternalRequestAsync<CreateImageRegistryScanTaskResponse>(req, "CreateImageRegistryScanTask");
        }

        /// <summary>
        /// 创建镜像扫描任务
        /// </summary>
        /// <param name="req"><see cref="CreateImageRegistryScanTaskRequest"/></param>
        /// <returns><see cref="CreateImageRegistryScanTaskResponse"/></returns>
        public CreateImageRegistryScanTaskResponse CreateImageRegistryScanTaskSync(CreateImageRegistryScanTaskRequest req)
        {
            return InternalRequestAsync<CreateImageRegistryScanTaskResponse>(req, "CreateImageRegistryScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建镜像仓库镜像扫描任务配置
        /// </summary>
        /// <param name="req"><see cref="CreateImageRegistryTimedScanTaskConfigRequest"/></param>
        /// <returns><see cref="CreateImageRegistryTimedScanTaskConfigResponse"/></returns>
        public Task<CreateImageRegistryTimedScanTaskConfigResponse> CreateImageRegistryTimedScanTaskConfig(CreateImageRegistryTimedScanTaskConfigRequest req)
        {
            return InternalRequestAsync<CreateImageRegistryTimedScanTaskConfigResponse>(req, "CreateImageRegistryTimedScanTaskConfig");
        }

        /// <summary>
        /// 创建镜像仓库镜像扫描任务配置
        /// </summary>
        /// <param name="req"><see cref="CreateImageRegistryTimedScanTaskConfigRequest"/></param>
        /// <returns><see cref="CreateImageRegistryTimedScanTaskConfigResponse"/></returns>
        public CreateImageRegistryTimedScanTaskConfigResponse CreateImageRegistryTimedScanTaskConfigSync(CreateImageRegistryTimedScanTaskConfigRequest req)
        {
            return InternalRequestAsync<CreateImageRegistryTimedScanTaskConfigResponse>(req, "CreateImageRegistryTimedScanTaskConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建镜像敏感信息列表导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateImageSensitiveInfoListExportJobRequest"/></param>
        /// <returns><see cref="CreateImageSensitiveInfoListExportJobResponse"/></returns>
        public Task<CreateImageSensitiveInfoListExportJobResponse> CreateImageSensitiveInfoListExportJob(CreateImageSensitiveInfoListExportJobRequest req)
        {
            return InternalRequestAsync<CreateImageSensitiveInfoListExportJobResponse>(req, "CreateImageSensitiveInfoListExportJob");
        }

        /// <summary>
        /// 创建镜像敏感信息列表导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateImageSensitiveInfoListExportJobRequest"/></param>
        /// <returns><see cref="CreateImageSensitiveInfoListExportJobResponse"/></returns>
        public CreateImageSensitiveInfoListExportJobResponse CreateImageSensitiveInfoListExportJobSync(CreateImageSensitiveInfoListExportJobRequest req)
        {
            return InternalRequestAsync<CreateImageSensitiveInfoListExportJobResponse>(req, "CreateImageSensitiveInfoListExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建容器镜像敏感信息白名单
        /// </summary>
        /// <param name="req"><see cref="CreateImageSensitiveWhitelistRequest"/></param>
        /// <returns><see cref="CreateImageSensitiveWhitelistResponse"/></returns>
        public Task<CreateImageSensitiveWhitelistResponse> CreateImageSensitiveWhitelist(CreateImageSensitiveWhitelistRequest req)
        {
            return InternalRequestAsync<CreateImageSensitiveWhitelistResponse>(req, "CreateImageSensitiveWhitelist");
        }

        /// <summary>
        /// 创建容器镜像敏感信息白名单
        /// </summary>
        /// <param name="req"><see cref="CreateImageSensitiveWhitelistRequest"/></param>
        /// <returns><see cref="CreateImageSensitiveWhitelistResponse"/></returns>
        public CreateImageSensitiveWhitelistResponse CreateImageSensitiveWhitelistSync(CreateImageSensitiveWhitelistRequest req)
        {
            return InternalRequestAsync<CreateImageSensitiveWhitelistResponse>(req, "CreateImageSensitiveWhitelist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建镜像木马病毒列表导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateImageVirusListExportJobRequest"/></param>
        /// <returns><see cref="CreateImageVirusListExportJobResponse"/></returns>
        public Task<CreateImageVirusListExportJobResponse> CreateImageVirusListExportJob(CreateImageVirusListExportJobRequest req)
        {
            return InternalRequestAsync<CreateImageVirusListExportJobResponse>(req, "CreateImageVirusListExportJob");
        }

        /// <summary>
        /// 创建镜像木马病毒列表导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateImageVirusListExportJobRequest"/></param>
        /// <returns><see cref="CreateImageVirusListExportJobResponse"/></returns>
        public CreateImageVirusListExportJobResponse CreateImageVirusListExportJobSync(CreateImageVirusListExportJobRequest req)
        {
            return InternalRequestAsync<CreateImageVirusListExportJobResponse>(req, "CreateImageVirusListExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建镜像木马白名单
        /// </summary>
        /// <param name="req"><see cref="CreateImageVirusWhitelistRequest"/></param>
        /// <returns><see cref="CreateImageVirusWhitelistResponse"/></returns>
        public Task<CreateImageVirusWhitelistResponse> CreateImageVirusWhitelist(CreateImageVirusWhitelistRequest req)
        {
            return InternalRequestAsync<CreateImageVirusWhitelistResponse>(req, "CreateImageVirusWhitelist");
        }

        /// <summary>
        /// 创建镜像木马白名单
        /// </summary>
        /// <param name="req"><see cref="CreateImageVirusWhitelistRequest"/></param>
        /// <returns><see cref="CreateImageVirusWhitelistResponse"/></returns>
        public CreateImageVirusWhitelistResponse CreateImageVirusWhitelistSync(CreateImageVirusWhitelistRequest req)
        {
            return InternalRequestAsync<CreateImageVirusWhitelistResponse>(req, "CreateImageVirusWhitelist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建镜像漏洞列表导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateImageVulListExportJobRequest"/></param>
        /// <returns><see cref="CreateImageVulListExportJobResponse"/></returns>
        public Task<CreateImageVulListExportJobResponse> CreateImageVulListExportJob(CreateImageVulListExportJobRequest req)
        {
            return InternalRequestAsync<CreateImageVulListExportJobResponse>(req, "CreateImageVulListExportJob");
        }

        /// <summary>
        /// 创建镜像漏洞列表导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateImageVulListExportJobRequest"/></param>
        /// <returns><see cref="CreateImageVulListExportJobResponse"/></returns>
        public CreateImageVulListExportJobResponse CreateImageVulListExportJobSync(CreateImageVulListExportJobRequest req)
        {
            return InternalRequestAsync<CreateImageVulListExportJobResponse>(req, "CreateImageVulListExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建镜像漏洞概览列表导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateImageVulSummaryListExportJobRequest"/></param>
        /// <returns><see cref="CreateImageVulSummaryListExportJobResponse"/></returns>
        public Task<CreateImageVulSummaryListExportJobResponse> CreateImageVulSummaryListExportJob(CreateImageVulSummaryListExportJobRequest req)
        {
            return InternalRequestAsync<CreateImageVulSummaryListExportJobResponse>(req, "CreateImageVulSummaryListExportJob");
        }

        /// <summary>
        /// 创建镜像漏洞概览列表导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateImageVulSummaryListExportJobRequest"/></param>
        /// <returns><see cref="CreateImageVulSummaryListExportJobResponse"/></returns>
        public CreateImageVulSummaryListExportJobResponse CreateImageVulSummaryListExportJobSync(CreateImageVulSummaryListExportJobRequest req)
        {
            return InternalRequestAsync<CreateImageVulSummaryListExportJobResponse>(req, "CreateImageVulSummaryListExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建容器镜像漏洞白名单
        /// </summary>
        /// <param name="req"><see cref="CreateImageVulWhitelistRequest"/></param>
        /// <returns><see cref="CreateImageVulWhitelistResponse"/></returns>
        public Task<CreateImageVulWhitelistResponse> CreateImageVulWhitelist(CreateImageVulWhitelistRequest req)
        {
            return InternalRequestAsync<CreateImageVulWhitelistResponse>(req, "CreateImageVulWhitelist");
        }

        /// <summary>
        /// 创建容器镜像漏洞白名单
        /// </summary>
        /// <param name="req"><see cref="CreateImageVulWhitelistRequest"/></param>
        /// <returns><see cref="CreateImageVulWhitelistResponse"/></returns>
        public CreateImageVulWhitelistResponse CreateImageVulWhitelistSync(CreateImageVulWhitelistRequest req)
        {
            return InternalRequestAsync<CreateImageVulWhitelistResponse>(req, "CreateImageVulWhitelist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建Pod关联容器列表导出任务。导出字段包含容器ID、容器名称、运行状态、节点ID、节点类型、镜像ID、镜像名称、隔离状态。支持Filter过滤。导出通过异步任务实现，返回JobId后前端轮询查询导出任务状态。
        /// </summary>
        /// <param name="req"><see cref="CreatePodContainerListExportJobRequest"/></param>
        /// <returns><see cref="CreatePodContainerListExportJobResponse"/></returns>
        public Task<CreatePodContainerListExportJobResponse> CreatePodContainerListExportJob(CreatePodContainerListExportJobRequest req)
        {
            return InternalRequestAsync<CreatePodContainerListExportJobResponse>(req, "CreatePodContainerListExportJob");
        }

        /// <summary>
        /// 创建Pod关联容器列表导出任务。导出字段包含容器ID、容器名称、运行状态、节点ID、节点类型、镜像ID、镜像名称、隔离状态。支持Filter过滤。导出通过异步任务实现，返回JobId后前端轮询查询导出任务状态。
        /// </summary>
        /// <param name="req"><see cref="CreatePodContainerListExportJobRequest"/></param>
        /// <returns><see cref="CreatePodContainerListExportJobResponse"/></returns>
        public CreatePodContainerListExportJobResponse CreatePodContainerListExportJobSync(CreatePodContainerListExportJobRequest req)
        {
            return InternalRequestAsync<CreatePodContainerListExportJobResponse>(req, "CreatePodContainerListExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建Pod关联服务列表导出任务。导出字段包含服务名称、类型、Selector、命名空间、创建时间。支持Filter过滤。当传入PodUniqueID时，复用DescribeClusterServiceList的Pod关联匹配逻辑。导出通过异步任务实现，返回JobId后前端轮询查询导出任务状态。
        /// </summary>
        /// <param name="req"><see cref="CreatePodServiceListExportJobRequest"/></param>
        /// <returns><see cref="CreatePodServiceListExportJobResponse"/></returns>
        public Task<CreatePodServiceListExportJobResponse> CreatePodServiceListExportJob(CreatePodServiceListExportJobRequest req)
        {
            return InternalRequestAsync<CreatePodServiceListExportJobResponse>(req, "CreatePodServiceListExportJob");
        }

        /// <summary>
        /// 创建Pod关联服务列表导出任务。导出字段包含服务名称、类型、Selector、命名空间、创建时间。支持Filter过滤。当传入PodUniqueID时，复用DescribeClusterServiceList的Pod关联匹配逻辑。导出通过异步任务实现，返回JobId后前端轮询查询导出任务状态。
        /// </summary>
        /// <param name="req"><see cref="CreatePodServiceListExportJobRequest"/></param>
        /// <returns><see cref="CreatePodServiceListExportJobResponse"/></returns>
        public CreatePodServiceListExportJobResponse CreatePodServiceListExportJobSync(CreatePodServiceListExportJobRequest req)
        {
            return InternalRequestAsync<CreatePodServiceListExportJobResponse>(req, "CreatePodServiceListExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建公网资产导出任务
        /// </summary>
        /// <param name="req"><see cref="CreatePublicAssetsExportJobRequest"/></param>
        /// <returns><see cref="CreatePublicAssetsExportJobResponse"/></returns>
        public Task<CreatePublicAssetsExportJobResponse> CreatePublicAssetsExportJob(CreatePublicAssetsExportJobRequest req)
        {
            return InternalRequestAsync<CreatePublicAssetsExportJobResponse>(req, "CreatePublicAssetsExportJob");
        }

        /// <summary>
        /// 创建公网资产导出任务
        /// </summary>
        /// <param name="req"><see cref="CreatePublicAssetsExportJobRequest"/></param>
        /// <returns><see cref="CreatePublicAssetsExportJobResponse"/></returns>
        public CreatePublicAssetsExportJobResponse CreatePublicAssetsExportJobSync(CreatePublicAssetsExportJobRequest req)
        {
            return InternalRequestAsync<CreatePublicAssetsExportJobResponse>(req, "CreatePublicAssetsExportJob")
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
        /// 创建云资源配置检查风险详情导出任务示例
        /// </summary>
        /// <param name="req"><see cref="CreateRiskDetailExportJobRequest"/></param>
        /// <returns><see cref="CreateRiskDetailExportJobResponse"/></returns>
        public Task<CreateRiskDetailExportJobResponse> CreateRiskDetailExportJob(CreateRiskDetailExportJobRequest req)
        {
            return InternalRequestAsync<CreateRiskDetailExportJobResponse>(req, "CreateRiskDetailExportJob");
        }

        /// <summary>
        /// 创建云资源配置检查风险详情导出任务示例
        /// </summary>
        /// <param name="req"><see cref="CreateRiskDetailExportJobRequest"/></param>
        /// <returns><see cref="CreateRiskDetailExportJobResponse"/></returns>
        public CreateRiskDetailExportJobResponse CreateRiskDetailExportJobSync(CreateRiskDetailExportJobRequest req)
        {
            return InternalRequestAsync<CreateRiskDetailExportJobResponse>(req, "CreateRiskDetailExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 暴露面扫描结果导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateScanStatisticExportJobRequest"/></param>
        /// <returns><see cref="CreateScanStatisticExportJobResponse"/></returns>
        public Task<CreateScanStatisticExportJobResponse> CreateScanStatisticExportJob(CreateScanStatisticExportJobRequest req)
        {
            return InternalRequestAsync<CreateScanStatisticExportJobResponse>(req, "CreateScanStatisticExportJob");
        }

        /// <summary>
        /// 暴露面扫描结果导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateScanStatisticExportJobRequest"/></param>
        /// <returns><see cref="CreateScanStatisticExportJobResponse"/></returns>
        public CreateScanStatisticExportJobResponse CreateScanStatisticExportJobSync(CreateScanStatisticExportJobRequest req)
        {
            return InternalRequestAsync<CreateScanStatisticExportJobResponse>(req, "CreateScanStatisticExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建立即检测任务
        /// </summary>
        /// <param name="req"><see cref="CreateScanTaskRequest"/></param>
        /// <returns><see cref="CreateScanTaskResponse"/></returns>
        public Task<CreateScanTaskResponse> CreateScanTask(CreateScanTaskRequest req)
        {
            return InternalRequestAsync<CreateScanTaskResponse>(req, "CreateScanTask");
        }

        /// <summary>
        /// 创建立即检测任务
        /// </summary>
        /// <param name="req"><see cref="CreateScanTaskRequest"/></param>
        /// <returns><see cref="CreateScanTaskResponse"/></returns>
        public CreateScanTaskResponse CreateScanTaskSync(CreateScanTaskRequest req)
        {
            return InternalRequestAsync<CreateScanTaskResponse>(req, "CreateScanTask")
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
        /// 对修复失败的漏洞修复任务进行重试，仅针对原任务中修复失败的主机重新下发修复指令。仅当任务状态为部分修复失败或全部修复失败时允许重试。
        /// </summary>
        /// <param name="req"><see cref="CreateVulFixRetryTaskRequest"/></param>
        /// <returns><see cref="CreateVulFixRetryTaskResponse"/></returns>
        public Task<CreateVulFixRetryTaskResponse> CreateVulFixRetryTask(CreateVulFixRetryTaskRequest req)
        {
            return InternalRequestAsync<CreateVulFixRetryTaskResponse>(req, "CreateVulFixRetryTask");
        }

        /// <summary>
        /// 对修复失败的漏洞修复任务进行重试，仅针对原任务中修复失败的主机重新下发修复指令。仅当任务状态为部分修复失败或全部修复失败时允许重试。
        /// </summary>
        /// <param name="req"><see cref="CreateVulFixRetryTaskRequest"/></param>
        /// <returns><see cref="CreateVulFixRetryTaskResponse"/></returns>
        public CreateVulFixRetryTaskResponse CreateVulFixRetryTaskSync(CreateVulFixRetryTaskRequest req)
        {
            return InternalRequestAsync<CreateVulFixRetryTaskResponse>(req, "CreateVulFixRetryTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户手动提交漏洞修复任务，指定需要修复的漏洞和目标主机，系统创建修复任务并下发执行。支持指定修复超时时间、是否创建快照等选项。通过FixItems数组精确控制每个漏洞/KB补丁修复哪些主机。
        /// </summary>
        /// <param name="req"><see cref="CreateVulFixTaskRequest"/></param>
        /// <returns><see cref="CreateVulFixTaskResponse"/></returns>
        public Task<CreateVulFixTaskResponse> CreateVulFixTask(CreateVulFixTaskRequest req)
        {
            return InternalRequestAsync<CreateVulFixTaskResponse>(req, "CreateVulFixTask");
        }

        /// <summary>
        /// 用户手动提交漏洞修复任务，指定需要修复的漏洞和目标主机，系统创建修复任务并下发执行。支持指定修复超时时间、是否创建快照等选项。通过FixItems数组精确控制每个漏洞/KB补丁修复哪些主机。
        /// </summary>
        /// <param name="req"><see cref="CreateVulFixTaskRequest"/></param>
        /// <returns><see cref="CreateVulFixTaskResponse"/></returns>
        public CreateVulFixTaskResponse CreateVulFixTaskSync(CreateVulFixTaskRequest req)
        {
            return InternalRequestAsync<CreateVulFixTaskResponse>(req, "CreateVulFixTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建已修复漏洞列表的导出任务。支持与 DescribeVulFixedList 相同的过滤条件，导出通过异步任务实现，返回 JobID 后前端轮询查询导出任务状态。导出字段包含漏洞ID、漏洞名称、漏洞等级、VPR评级、漏洞类型、CVE编号、主机名称、实例ID、关联组件&路径、修复时间。
        /// </summary>
        /// <param name="req"><see cref="CreateVulFixedExportJobRequest"/></param>
        /// <returns><see cref="CreateVulFixedExportJobResponse"/></returns>
        public Task<CreateVulFixedExportJobResponse> CreateVulFixedExportJob(CreateVulFixedExportJobRequest req)
        {
            return InternalRequestAsync<CreateVulFixedExportJobResponse>(req, "CreateVulFixedExportJob");
        }

        /// <summary>
        /// 创建已修复漏洞列表的导出任务。支持与 DescribeVulFixedList 相同的过滤条件，导出通过异步任务实现，返回 JobID 后前端轮询查询导出任务状态。导出字段包含漏洞ID、漏洞名称、漏洞等级、VPR评级、漏洞类型、CVE编号、主机名称、实例ID、关联组件&路径、修复时间。
        /// </summary>
        /// <param name="req"><see cref="CreateVulFixedExportJobRequest"/></param>
        /// <returns><see cref="CreateVulFixedExportJobResponse"/></returns>
        public CreateVulFixedExportJobResponse CreateVulFixedExportJobSync(CreateVulFixedExportJobRequest req)
        {
            return InternalRequestAsync<CreateVulFixedExportJobResponse>(req, "CreateVulFixedExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建漏洞重新扫描
        /// </summary>
        /// <param name="req"><see cref="CreateVulReScanRequest"/></param>
        /// <returns><see cref="CreateVulReScanResponse"/></returns>
        public Task<CreateVulReScanResponse> CreateVulReScan(CreateVulReScanRequest req)
        {
            return InternalRequestAsync<CreateVulReScanResponse>(req, "CreateVulReScan");
        }

        /// <summary>
        /// 创建漏洞重新扫描
        /// </summary>
        /// <param name="req"><see cref="CreateVulReScanRequest"/></param>
        /// <returns><see cref="CreateVulReScanResponse"/></returns>
        public CreateVulReScanResponse CreateVulReScanSync(CreateVulReScanRequest req)
        {
            return InternalRequestAsync<CreateVulReScanResponse>(req, "CreateVulReScan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建漏洞风险导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateVulRisksExportJobRequest"/></param>
        /// <returns><see cref="CreateVulRisksExportJobResponse"/></returns>
        public Task<CreateVulRisksExportJobResponse> CreateVulRisksExportJob(CreateVulRisksExportJobRequest req)
        {
            return InternalRequestAsync<CreateVulRisksExportJobResponse>(req, "CreateVulRisksExportJob");
        }

        /// <summary>
        /// 创建漏洞风险导出任务
        /// </summary>
        /// <param name="req"><see cref="CreateVulRisksExportJobRequest"/></param>
        /// <returns><see cref="CreateVulRisksExportJobResponse"/></returns>
        public CreateVulRisksExportJobResponse CreateVulRisksExportJobSync(CreateVulRisksExportJobRequest req)
        {
            return InternalRequestAsync<CreateVulRisksExportJobResponse>(req, "CreateVulRisksExportJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建漏洞扫描（一键扫描）
        /// </summary>
        /// <param name="req"><see cref="CreateVulScanManualRequest"/></param>
        /// <returns><see cref="CreateVulScanManualResponse"/></returns>
        public Task<CreateVulScanManualResponse> CreateVulScanManual(CreateVulScanManualRequest req)
        {
            return InternalRequestAsync<CreateVulScanManualResponse>(req, "CreateVulScanManual");
        }

        /// <summary>
        /// 创建漏洞扫描（一键扫描）
        /// </summary>
        /// <param name="req"><see cref="CreateVulScanManualRequest"/></param>
        /// <returns><see cref="CreateVulScanManualResponse"/></returns>
        public CreateVulScanManualResponse CreateVulScanManualSync(CreateVulScanManualRequest req)
        {
            return InternalRequestAsync<CreateVulScanManualResponse>(req, "CreateVulScanManual")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除AI助手的SMTP邮箱接入信息
        /// </summary>
        /// <param name="req"><see cref="DeleteAIAnalysisSMTPAccessRequest"/></param>
        /// <returns><see cref="DeleteAIAnalysisSMTPAccessResponse"/></returns>
        public Task<DeleteAIAnalysisSMTPAccessResponse> DeleteAIAnalysisSMTPAccess(DeleteAIAnalysisSMTPAccessRequest req)
        {
            return InternalRequestAsync<DeleteAIAnalysisSMTPAccessResponse>(req, "DeleteAIAnalysisSMTPAccess");
        }

        /// <summary>
        /// 删除AI助手的SMTP邮箱接入信息
        /// </summary>
        /// <param name="req"><see cref="DeleteAIAnalysisSMTPAccessRequest"/></param>
        /// <returns><see cref="DeleteAIAnalysisSMTPAccessResponse"/></returns>
        public DeleteAIAnalysisSMTPAccessResponse DeleteAIAnalysisSMTPAccessSync(DeleteAIAnalysisSMTPAccessRequest req)
        {
            return InternalRequestAsync<DeleteAIAnalysisSMTPAccessResponse>(req, "DeleteAIAnalysisSMTPAccess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除AI 定时任务。
        /// 
        /// 根据指定的AI 定时任务 ID 删除对应的定时任务。删除后不可恢复。
        /// </summary>
        /// <param name="req"><see cref="DeleteAIScheduleRequest"/></param>
        /// <returns><see cref="DeleteAIScheduleResponse"/></returns>
        public Task<DeleteAIScheduleResponse> DeleteAISchedule(DeleteAIScheduleRequest req)
        {
            return InternalRequestAsync<DeleteAIScheduleResponse>(req, "DeleteAISchedule");
        }

        /// <summary>
        /// 删除AI 定时任务。
        /// 
        /// 根据指定的AI 定时任务 ID 删除对应的定时任务。删除后不可恢复。
        /// </summary>
        /// <param name="req"><see cref="DeleteAIScheduleRequest"/></param>
        /// <returns><see cref="DeleteAIScheduleResponse"/></returns>
        public DeleteAIScheduleResponse DeleteAIScheduleSync(DeleteAIScheduleRequest req)
        {
            return InternalRequestAsync<DeleteAIScheduleResponse>(req, "DeleteAISchedule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除用户创建的指定资产搜索视图
        /// </summary>
        /// <param name="req"><see cref="DeleteAssetFilterViewRequest"/></param>
        /// <returns><see cref="DeleteAssetFilterViewResponse"/></returns>
        public Task<DeleteAssetFilterViewResponse> DeleteAssetFilterView(DeleteAssetFilterViewRequest req)
        {
            return InternalRequestAsync<DeleteAssetFilterViewResponse>(req, "DeleteAssetFilterView");
        }

        /// <summary>
        /// 删除用户创建的指定资产搜索视图
        /// </summary>
        /// <param name="req"><see cref="DeleteAssetFilterViewRequest"/></param>
        /// <returns><see cref="DeleteAssetFilterViewResponse"/></returns>
        public DeleteAssetFilterViewResponse DeleteAssetFilterViewSync(DeleteAssetFilterViewRequest req)
        {
            return InternalRequestAsync<DeleteAssetFilterViewResponse>(req, "DeleteAssetFilterView")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除资产标签
        /// </summary>
        /// <param name="req"><see cref="DeleteAssetTagRequest"/></param>
        /// <returns><see cref="DeleteAssetTagResponse"/></returns>
        public Task<DeleteAssetTagResponse> DeleteAssetTag(DeleteAssetTagRequest req)
        {
            return InternalRequestAsync<DeleteAssetTagResponse>(req, "DeleteAssetTag");
        }

        /// <summary>
        /// 删除资产标签
        /// </summary>
        /// <param name="req"><see cref="DeleteAssetTagRequest"/></param>
        /// <returns><see cref="DeleteAssetTagResponse"/></returns>
        public DeleteAssetTagResponse DeleteAssetTagSync(DeleteAssetTagRequest req)
        {
            return InternalRequestAsync<DeleteAssetTagResponse>(req, "DeleteAssetTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量删除自定义基线策略。仅支持删除 PolicyType=SELF 的策略；删除后历史风险记录保留，但不再产生新结果。
        /// </summary>
        /// <param name="req"><see cref="DeleteBaselineSelfDefinedPolicyListRequest"/></param>
        /// <returns><see cref="DeleteBaselineSelfDefinedPolicyListResponse"/></returns>
        public Task<DeleteBaselineSelfDefinedPolicyListResponse> DeleteBaselineSelfDefinedPolicyList(DeleteBaselineSelfDefinedPolicyListRequest req)
        {
            return InternalRequestAsync<DeleteBaselineSelfDefinedPolicyListResponse>(req, "DeleteBaselineSelfDefinedPolicyList");
        }

        /// <summary>
        /// 批量删除自定义基线策略。仅支持删除 PolicyType=SELF 的策略；删除后历史风险记录保留，但不再产生新结果。
        /// </summary>
        /// <param name="req"><see cref="DeleteBaselineSelfDefinedPolicyListRequest"/></param>
        /// <returns><see cref="DeleteBaselineSelfDefinedPolicyListResponse"/></returns>
        public DeleteBaselineSelfDefinedPolicyListResponse DeleteBaselineSelfDefinedPolicyListSync(DeleteBaselineSelfDefinedPolicyListRequest req)
        {
            return InternalRequestAsync<DeleteBaselineSelfDefinedPolicyListResponse>(req, "DeleteBaselineSelfDefinedPolicyList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// CSIP 手动扫描任务删除接口
        /// </summary>
        /// <param name="req"><see cref="DeleteCSIPMalwareScanTaskRequest"/></param>
        /// <returns><see cref="DeleteCSIPMalwareScanTaskResponse"/></returns>
        public Task<DeleteCSIPMalwareScanTaskResponse> DeleteCSIPMalwareScanTask(DeleteCSIPMalwareScanTaskRequest req)
        {
            return InternalRequestAsync<DeleteCSIPMalwareScanTaskResponse>(req, "DeleteCSIPMalwareScanTask");
        }

        /// <summary>
        /// CSIP 手动扫描任务删除接口
        /// </summary>
        /// <param name="req"><see cref="DeleteCSIPMalwareScanTaskRequest"/></param>
        /// <returns><see cref="DeleteCSIPMalwareScanTaskResponse"/></returns>
        public DeleteCSIPMalwareScanTaskResponse DeleteCSIPMalwareScanTaskSync(DeleteCSIPMalwareScanTaskRequest req)
        {
            return InternalRequestAsync<DeleteCSIPMalwareScanTaskResponse>(req, "DeleteCSIPMalwareScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除集群
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRequest"/></param>
        /// <returns><see cref="DeleteClusterResponse"/></returns>
        public Task<DeleteClusterResponse> DeleteCluster(DeleteClusterRequest req)
        {
            return InternalRequestAsync<DeleteClusterResponse>(req, "DeleteCluster");
        }

        /// <summary>
        /// 删除集群
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRequest"/></param>
        /// <returns><see cref="DeleteClusterResponse"/></returns>
        public DeleteClusterResponse DeleteClusterSync(DeleteClusterRequest req)
        {
            return InternalRequestAsync<DeleteClusterResponse>(req, "DeleteCluster")
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
        /// 删除EDR策略
        /// </summary>
        /// <param name="req"><see cref="DeleteEDRRulesRequest"/></param>
        /// <returns><see cref="DeleteEDRRulesResponse"/></returns>
        public Task<DeleteEDRRulesResponse> DeleteEDRRules(DeleteEDRRulesRequest req)
        {
            return InternalRequestAsync<DeleteEDRRulesResponse>(req, "DeleteEDRRules");
        }

        /// <summary>
        /// 删除EDR策略
        /// </summary>
        /// <param name="req"><see cref="DeleteEDRRulesRequest"/></param>
        /// <returns><see cref="DeleteEDRRulesResponse"/></returns>
        public DeleteEDRRulesResponse DeleteEDRRulesSync(DeleteEDRRulesRequest req)
        {
            return InternalRequestAsync<DeleteEDRRulesResponse>(req, "DeleteEDRRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除已终止的扫描任务（物理删除主表及明细表）。只允许删除终态任务，只有创建者可操作。
        /// </summary>
        /// <param name="req"><see cref="DeleteEDRScanTaskRequest"/></param>
        /// <returns><see cref="DeleteEDRScanTaskResponse"/></returns>
        public Task<DeleteEDRScanTaskResponse> DeleteEDRScanTask(DeleteEDRScanTaskRequest req)
        {
            return InternalRequestAsync<DeleteEDRScanTaskResponse>(req, "DeleteEDRScanTask");
        }

        /// <summary>
        /// 删除已终止的扫描任务（物理删除主表及明细表）。只允许删除终态任务，只有创建者可操作。
        /// </summary>
        /// <param name="req"><see cref="DeleteEDRScanTaskRequest"/></param>
        /// <returns><see cref="DeleteEDRScanTaskResponse"/></returns>
        public DeleteEDRScanTaskResponse DeleteEDRScanTaskSync(DeleteEDRScanTaskRequest req)
        {
            return InternalRequestAsync<DeleteEDRScanTaskResponse>(req, "DeleteEDRScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量删除EDR日志采集路径配置
        /// </summary>
        /// <param name="req"><see cref="DeleteEdrLogCollectPathsRequest"/></param>
        /// <returns><see cref="DeleteEdrLogCollectPathsResponse"/></returns>
        public Task<DeleteEdrLogCollectPathsResponse> DeleteEdrLogCollectPaths(DeleteEdrLogCollectPathsRequest req)
        {
            return InternalRequestAsync<DeleteEdrLogCollectPathsResponse>(req, "DeleteEdrLogCollectPaths");
        }

        /// <summary>
        /// 批量删除EDR日志采集路径配置
        /// </summary>
        /// <param name="req"><see cref="DeleteEdrLogCollectPathsRequest"/></param>
        /// <returns><see cref="DeleteEdrLogCollectPathsResponse"/></returns>
        public DeleteEdrLogCollectPathsResponse DeleteEdrLogCollectPathsSync(DeleteEdrLogCollectPathsRequest req)
        {
            return InternalRequestAsync<DeleteEdrLogCollectPathsResponse>(req, "DeleteEdrLogCollectPaths")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云边界自动打标-删除规则
        /// </summary>
        /// <param name="req"><see cref="DeleteExposureAutoTagRuleRequest"/></param>
        /// <returns><see cref="DeleteExposureAutoTagRuleResponse"/></returns>
        public Task<DeleteExposureAutoTagRuleResponse> DeleteExposureAutoTagRule(DeleteExposureAutoTagRuleRequest req)
        {
            return InternalRequestAsync<DeleteExposureAutoTagRuleResponse>(req, "DeleteExposureAutoTagRule");
        }

        /// <summary>
        /// 云边界自动打标-删除规则
        /// </summary>
        /// <param name="req"><see cref="DeleteExposureAutoTagRuleRequest"/></param>
        /// <returns><see cref="DeleteExposureAutoTagRuleResponse"/></returns>
        public DeleteExposureAutoTagRuleResponse DeleteExposureAutoTagRuleSync(DeleteExposureAutoTagRuleRequest req)
        {
            return InternalRequestAsync<DeleteExposureAutoTagRuleResponse>(req, "DeleteExposureAutoTagRule")
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
        /// 删除镜像仓库信息
        /// </summary>
        /// <param name="req"><see cref="DeleteImageRegistryRequest"/></param>
        /// <returns><see cref="DeleteImageRegistryResponse"/></returns>
        public Task<DeleteImageRegistryResponse> DeleteImageRegistry(DeleteImageRegistryRequest req)
        {
            return InternalRequestAsync<DeleteImageRegistryResponse>(req, "DeleteImageRegistry");
        }

        /// <summary>
        /// 删除镜像仓库信息
        /// </summary>
        /// <param name="req"><see cref="DeleteImageRegistryRequest"/></param>
        /// <returns><see cref="DeleteImageRegistryResponse"/></returns>
        public DeleteImageRegistryResponse DeleteImageRegistrySync(DeleteImageRegistryRequest req)
        {
            return InternalRequestAsync<DeleteImageRegistryResponse>(req, "DeleteImageRegistry")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除镜像仓库扫描任务
        /// </summary>
        /// <param name="req"><see cref="DeleteImageRegistryScanTaskRequest"/></param>
        /// <returns><see cref="DeleteImageRegistryScanTaskResponse"/></returns>
        public Task<DeleteImageRegistryScanTaskResponse> DeleteImageRegistryScanTask(DeleteImageRegistryScanTaskRequest req)
        {
            return InternalRequestAsync<DeleteImageRegistryScanTaskResponse>(req, "DeleteImageRegistryScanTask");
        }

        /// <summary>
        /// 删除镜像仓库扫描任务
        /// </summary>
        /// <param name="req"><see cref="DeleteImageRegistryScanTaskRequest"/></param>
        /// <returns><see cref="DeleteImageRegistryScanTaskResponse"/></returns>
        public DeleteImageRegistryScanTaskResponse DeleteImageRegistryScanTaskSync(DeleteImageRegistryScanTaskRequest req)
        {
            return InternalRequestAsync<DeleteImageRegistryScanTaskResponse>(req, "DeleteImageRegistryScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除镜像仓库定时扫描任务配置
        /// </summary>
        /// <param name="req"><see cref="DeleteImageRegistryTimedScanTaskConfigRequest"/></param>
        /// <returns><see cref="DeleteImageRegistryTimedScanTaskConfigResponse"/></returns>
        public Task<DeleteImageRegistryTimedScanTaskConfigResponse> DeleteImageRegistryTimedScanTaskConfig(DeleteImageRegistryTimedScanTaskConfigRequest req)
        {
            return InternalRequestAsync<DeleteImageRegistryTimedScanTaskConfigResponse>(req, "DeleteImageRegistryTimedScanTaskConfig");
        }

        /// <summary>
        /// 删除镜像仓库定时扫描任务配置
        /// </summary>
        /// <param name="req"><see cref="DeleteImageRegistryTimedScanTaskConfigRequest"/></param>
        /// <returns><see cref="DeleteImageRegistryTimedScanTaskConfigResponse"/></returns>
        public DeleteImageRegistryTimedScanTaskConfigResponse DeleteImageRegistryTimedScanTaskConfigSync(DeleteImageRegistryTimedScanTaskConfigRequest req)
        {
            return InternalRequestAsync<DeleteImageRegistryTimedScanTaskConfigResponse>(req, "DeleteImageRegistryTimedScanTaskConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除容器镜像敏感信息白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteImageSensitiveWhitelistRequest"/></param>
        /// <returns><see cref="DeleteImageSensitiveWhitelistResponse"/></returns>
        public Task<DeleteImageSensitiveWhitelistResponse> DeleteImageSensitiveWhitelist(DeleteImageSensitiveWhitelistRequest req)
        {
            return InternalRequestAsync<DeleteImageSensitiveWhitelistResponse>(req, "DeleteImageSensitiveWhitelist");
        }

        /// <summary>
        /// 删除容器镜像敏感信息白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteImageSensitiveWhitelistRequest"/></param>
        /// <returns><see cref="DeleteImageSensitiveWhitelistResponse"/></returns>
        public DeleteImageSensitiveWhitelistResponse DeleteImageSensitiveWhitelistSync(DeleteImageSensitiveWhitelistRequest req)
        {
            return InternalRequestAsync<DeleteImageSensitiveWhitelistResponse>(req, "DeleteImageSensitiveWhitelist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除镜像木马白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteImageVirusWhitelistRequest"/></param>
        /// <returns><see cref="DeleteImageVirusWhitelistResponse"/></returns>
        public Task<DeleteImageVirusWhitelistResponse> DeleteImageVirusWhitelist(DeleteImageVirusWhitelistRequest req)
        {
            return InternalRequestAsync<DeleteImageVirusWhitelistResponse>(req, "DeleteImageVirusWhitelist");
        }

        /// <summary>
        /// 删除镜像木马白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteImageVirusWhitelistRequest"/></param>
        /// <returns><see cref="DeleteImageVirusWhitelistResponse"/></returns>
        public DeleteImageVirusWhitelistResponse DeleteImageVirusWhitelistSync(DeleteImageVirusWhitelistRequest req)
        {
            return InternalRequestAsync<DeleteImageVirusWhitelistResponse>(req, "DeleteImageVirusWhitelist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除容器镜像漏洞白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteImageVulWhitelistRequest"/></param>
        /// <returns><see cref="DeleteImageVulWhitelistResponse"/></returns>
        public Task<DeleteImageVulWhitelistResponse> DeleteImageVulWhitelist(DeleteImageVulWhitelistRequest req)
        {
            return InternalRequestAsync<DeleteImageVulWhitelistResponse>(req, "DeleteImageVulWhitelist");
        }

        /// <summary>
        /// 删除容器镜像漏洞白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteImageVulWhitelistRequest"/></param>
        /// <returns><see cref="DeleteImageVulWhitelistResponse"/></returns>
        public DeleteImageVulWhitelistResponse DeleteImageVulWhitelistSync(DeleteImageVulWhitelistRequest req)
        {
            return InternalRequestAsync<DeleteImageVulWhitelistResponse>(req, "DeleteImageVulWhitelist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口用于删除异地登录白名单规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteLoginWhiteListRequest"/></param>
        /// <returns><see cref="DeleteLoginWhiteListResponse"/></returns>
        public Task<DeleteLoginWhiteListResponse> DeleteLoginWhiteList(DeleteLoginWhiteListRequest req)
        {
            return InternalRequestAsync<DeleteLoginWhiteListResponse>(req, "DeleteLoginWhiteList");
        }

        /// <summary>
        /// 本接口用于删除异地登录白名单规则。
        /// </summary>
        /// <param name="req"><see cref="DeleteLoginWhiteListRequest"/></param>
        /// <returns><see cref="DeleteLoginWhiteListResponse"/></returns>
        public DeleteLoginWhiteListResponse DeleteLoginWhiteListSync(DeleteLoginWhiteListRequest req)
        {
            return InternalRequestAsync<DeleteLoginWhiteListResponse>(req, "DeleteLoginWhiteList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除机器清理记录
        /// </summary>
        /// <param name="req"><see cref="DeleteMachineClearHistoryRequest"/></param>
        /// <returns><see cref="DeleteMachineClearHistoryResponse"/></returns>
        public Task<DeleteMachineClearHistoryResponse> DeleteMachineClearHistory(DeleteMachineClearHistoryRequest req)
        {
            return InternalRequestAsync<DeleteMachineClearHistoryResponse>(req, "DeleteMachineClearHistory");
        }

        /// <summary>
        /// 删除机器清理记录
        /// </summary>
        /// <param name="req"><see cref="DeleteMachineClearHistoryRequest"/></param>
        /// <returns><see cref="DeleteMachineClearHistoryResponse"/></returns>
        public DeleteMachineClearHistoryResponse DeleteMachineClearHistorySync(DeleteMachineClearHistoryRequest req)
        {
            return InternalRequestAsync<DeleteMachineClearHistoryResponse>(req, "DeleteMachineClearHistory")
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
        /// 批量删除 LLM 审计用户规则。任一 ID 不存在或属于其他租户时整体返回错误
        /// </summary>
        /// <param name="req"><see cref="DeleteSandboxLLMAuditRuleRequest"/></param>
        /// <returns><see cref="DeleteSandboxLLMAuditRuleResponse"/></returns>
        public Task<DeleteSandboxLLMAuditRuleResponse> DeleteSandboxLLMAuditRule(DeleteSandboxLLMAuditRuleRequest req)
        {
            return InternalRequestAsync<DeleteSandboxLLMAuditRuleResponse>(req, "DeleteSandboxLLMAuditRule");
        }

        /// <summary>
        /// 批量删除 LLM 审计用户规则。任一 ID 不存在或属于其他租户时整体返回错误
        /// </summary>
        /// <param name="req"><see cref="DeleteSandboxLLMAuditRuleRequest"/></param>
        /// <returns><see cref="DeleteSandboxLLMAuditRuleResponse"/></returns>
        public DeleteSandboxLLMAuditRuleResponse DeleteSandboxLLMAuditRuleSync(DeleteSandboxLLMAuditRuleRequest req)
        {
            return InternalRequestAsync<DeleteSandboxLLMAuditRuleResponse>(req, "DeleteSandboxLLMAuditRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除漏洞白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteVulWhitelistRequest"/></param>
        /// <returns><see cref="DeleteVulWhitelistResponse"/></returns>
        public Task<DeleteVulWhitelistResponse> DeleteVulWhitelist(DeleteVulWhitelistRequest req)
        {
            return InternalRequestAsync<DeleteVulWhitelistResponse>(req, "DeleteVulWhitelist");
        }

        /// <summary>
        /// 删除漏洞白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteVulWhitelistRequest"/></param>
        /// <returns><see cref="DeleteVulWhitelistResponse"/></returns>
        public DeleteVulWhitelistResponse DeleteVulWhitelistSync(DeleteVulWhitelistRequest req)
        {
            return InternalRequestAsync<DeleteVulWhitelistResponse>(req, "DeleteVulWhitelist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量删除通知策略。
        /// </summary>
        /// <param name="req"><see cref="DeleteWebhookPoliciesRequest"/></param>
        /// <returns><see cref="DeleteWebhookPoliciesResponse"/></returns>
        public Task<DeleteWebhookPoliciesResponse> DeleteWebhookPolicies(DeleteWebhookPoliciesRequest req)
        {
            return InternalRequestAsync<DeleteWebhookPoliciesResponse>(req, "DeleteWebhookPolicies");
        }

        /// <summary>
        /// 批量删除通知策略。
        /// </summary>
        /// <param name="req"><see cref="DeleteWebhookPoliciesRequest"/></param>
        /// <returns><see cref="DeleteWebhookPoliciesResponse"/></returns>
        public DeleteWebhookPoliciesResponse DeleteWebhookPoliciesSync(DeleteWebhookPoliciesRequest req)
        {
            return InternalRequestAsync<DeleteWebhookPoliciesResponse>(req, "DeleteWebhookPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量删除接收机器人。删除前会自动从所有引用了这些机器人的策略中移除引用关系。
        /// </summary>
        /// <param name="req"><see cref="DeleteWebhookReceiversRequest"/></param>
        /// <returns><see cref="DeleteWebhookReceiversResponse"/></returns>
        public Task<DeleteWebhookReceiversResponse> DeleteWebhookReceivers(DeleteWebhookReceiversRequest req)
        {
            return InternalRequestAsync<DeleteWebhookReceiversResponse>(req, "DeleteWebhookReceivers");
        }

        /// <summary>
        /// 批量删除接收机器人。删除前会自动从所有引用了这些机器人的策略中移除引用关系。
        /// </summary>
        /// <param name="req"><see cref="DeleteWebhookReceiversRequest"/></param>
        /// <returns><see cref="DeleteWebhookReceiversResponse"/></returns>
        public DeleteWebhookReceiversResponse DeleteWebhookReceiversSync(DeleteWebhookReceiversRequest req)
        {
            return InternalRequestAsync<DeleteWebhookReceiversResponse>(req, "DeleteWebhookReceivers")
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
        /// 获取 AIAgent 资产凭据扫描列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAgentCredentialListRequest"/></param>
        /// <returns><see cref="DescribeAIAgentCredentialListResponse"/></returns>
        public Task<DescribeAIAgentCredentialListResponse> DescribeAIAgentCredentialList(DescribeAIAgentCredentialListRequest req)
        {
            return InternalRequestAsync<DescribeAIAgentCredentialListResponse>(req, "DescribeAIAgentCredentialList");
        }

        /// <summary>
        /// 获取 AIAgent 资产凭据扫描列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAgentCredentialListRequest"/></param>
        /// <returns><see cref="DescribeAIAgentCredentialListResponse"/></returns>
        public DescribeAIAgentCredentialListResponse DescribeAIAgentCredentialListSync(DescribeAIAgentCredentialListRequest req)
        {
            return InternalRequestAsync<DescribeAIAgentCredentialListResponse>(req, "DescribeAIAgentCredentialList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 按凭据组行 ID 分页查询单个凭据的泄露位置列表。用于配合 DescribeAIAgentCredentialList 接口拆分后的展开场景，避免单接口在数据倾斜场景下一次拉取几十万行 location 导致性能问题。
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAgentCredentialLocationListRequest"/></param>
        /// <returns><see cref="DescribeAIAgentCredentialLocationListResponse"/></returns>
        public Task<DescribeAIAgentCredentialLocationListResponse> DescribeAIAgentCredentialLocationList(DescribeAIAgentCredentialLocationListRequest req)
        {
            return InternalRequestAsync<DescribeAIAgentCredentialLocationListResponse>(req, "DescribeAIAgentCredentialLocationList");
        }

        /// <summary>
        /// 按凭据组行 ID 分页查询单个凭据的泄露位置列表。用于配合 DescribeAIAgentCredentialList 接口拆分后的展开场景，避免单接口在数据倾斜场景下一次拉取几十万行 location 导致性能问题。
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAgentCredentialLocationListRequest"/></param>
        /// <returns><see cref="DescribeAIAgentCredentialLocationListResponse"/></returns>
        public DescribeAIAgentCredentialLocationListResponse DescribeAIAgentCredentialLocationListSync(DescribeAIAgentCredentialLocationListRequest req)
        {
            return InternalRequestAsync<DescribeAIAgentCredentialLocationListResponse>(req, "DescribeAIAgentCredentialLocationList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取 AI Agent skill 列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAgentSkillListRequest"/></param>
        /// <returns><see cref="DescribeAIAgentSkillListResponse"/></returns>
        public Task<DescribeAIAgentSkillListResponse> DescribeAIAgentSkillList(DescribeAIAgentSkillListRequest req)
        {
            return InternalRequestAsync<DescribeAIAgentSkillListResponse>(req, "DescribeAIAgentSkillList");
        }

        /// <summary>
        /// 获取 AI Agent skill 列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAgentSkillListRequest"/></param>
        /// <returns><see cref="DescribeAIAgentSkillListResponse"/></returns>
        public DescribeAIAgentSkillListResponse DescribeAIAgentSkillListSync(DescribeAIAgentSkillListRequest req)
        {
            return InternalRequestAsync<DescribeAIAgentSkillListResponse>(req, "DescribeAIAgentSkillList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取 AI 分析文件的临时下载链接。
        /// 
        /// 传入文件的原始地址，返回带签名的临时下载链接，链接有效期为 2 小时。
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAnalysisFileDownloadURLRequest"/></param>
        /// <returns><see cref="DescribeAIAnalysisFileDownloadURLResponse"/></returns>
        public Task<DescribeAIAnalysisFileDownloadURLResponse> DescribeAIAnalysisFileDownloadURL(DescribeAIAnalysisFileDownloadURLRequest req)
        {
            return InternalRequestAsync<DescribeAIAnalysisFileDownloadURLResponse>(req, "DescribeAIAnalysisFileDownloadURL");
        }

        /// <summary>
        /// 获取 AI 分析文件的临时下载链接。
        /// 
        /// 传入文件的原始地址，返回带签名的临时下载链接，链接有效期为 2 小时。
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAnalysisFileDownloadURLRequest"/></param>
        /// <returns><see cref="DescribeAIAnalysisFileDownloadURLResponse"/></returns>
        public DescribeAIAnalysisFileDownloadURLResponse DescribeAIAnalysisFileDownloadURLSync(DescribeAIAnalysisFileDownloadURLRequest req)
        {
            return InternalRequestAsync<DescribeAIAnalysisFileDownloadURLResponse>(req, "DescribeAIAnalysisFileDownloadURL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取云安全AI助手历史分析记录
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAnalysisHistoryRequest"/></param>
        /// <returns><see cref="DescribeAIAnalysisHistoryResponse"/></returns>
        public Task<DescribeAIAnalysisHistoryResponse> DescribeAIAnalysisHistory(DescribeAIAnalysisHistoryRequest req)
        {
            return InternalRequestAsync<DescribeAIAnalysisHistoryResponse>(req, "DescribeAIAnalysisHistory");
        }

        /// <summary>
        /// 获取云安全AI助手历史分析记录
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAnalysisHistoryRequest"/></param>
        /// <returns><see cref="DescribeAIAnalysisHistoryResponse"/></returns>
        public DescribeAIAnalysisHistoryResponse DescribeAIAnalysisHistorySync(DescribeAIAnalysisHistoryRequest req)
        {
            return InternalRequestAsync<DescribeAIAnalysisHistoryResponse>(req, "DescribeAIAnalysisHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取AI问答推荐问题
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAnalysisRecommendQuestionsRequest"/></param>
        /// <returns><see cref="DescribeAIAnalysisRecommendQuestionsResponse"/></returns>
        public Task<DescribeAIAnalysisRecommendQuestionsResponse> DescribeAIAnalysisRecommendQuestions(DescribeAIAnalysisRecommendQuestionsRequest req)
        {
            return InternalRequestAsync<DescribeAIAnalysisRecommendQuestionsResponse>(req, "DescribeAIAnalysisRecommendQuestions");
        }

        /// <summary>
        /// 获取AI问答推荐问题
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAnalysisRecommendQuestionsRequest"/></param>
        /// <returns><see cref="DescribeAIAnalysisRecommendQuestionsResponse"/></returns>
        public DescribeAIAnalysisRecommendQuestionsResponse DescribeAIAnalysisRecommendQuestionsSync(DescribeAIAnalysisRecommendQuestionsRequest req)
        {
            return InternalRequestAsync<DescribeAIAnalysisRecommendQuestionsResponse>(req, "DescribeAIAnalysisRecommendQuestions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取云安全AI助手基础信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAnalysisRobotInfoRequest"/></param>
        /// <returns><see cref="DescribeAIAnalysisRobotInfoResponse"/></returns>
        public Task<DescribeAIAnalysisRobotInfoResponse> DescribeAIAnalysisRobotInfo(DescribeAIAnalysisRobotInfoRequest req)
        {
            return InternalRequestAsync<DescribeAIAnalysisRobotInfoResponse>(req, "DescribeAIAnalysisRobotInfo");
        }

        /// <summary>
        /// 获取云安全AI助手基础信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAnalysisRobotInfoRequest"/></param>
        /// <returns><see cref="DescribeAIAnalysisRobotInfoResponse"/></returns>
        public DescribeAIAnalysisRobotInfoResponse DescribeAIAnalysisRobotInfoSync(DescribeAIAnalysisRobotInfoRequest req)
        {
            return InternalRequestAsync<DescribeAIAnalysisRobotInfoResponse>(req, "DescribeAIAnalysisRobotInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询AI助手的SMTP邮箱接入信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAnalysisSMTPRequest"/></param>
        /// <returns><see cref="DescribeAIAnalysisSMTPResponse"/></returns>
        public Task<DescribeAIAnalysisSMTPResponse> DescribeAIAnalysisSMTP(DescribeAIAnalysisSMTPRequest req)
        {
            return InternalRequestAsync<DescribeAIAnalysisSMTPResponse>(req, "DescribeAIAnalysisSMTP");
        }

        /// <summary>
        /// 查询AI助手的SMTP邮箱接入信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAnalysisSMTPRequest"/></param>
        /// <returns><see cref="DescribeAIAnalysisSMTPResponse"/></returns>
        public DescribeAIAnalysisSMTPResponse DescribeAIAnalysisSMTPSync(DescribeAIAnalysisSMTPRequest req)
        {
            return InternalRequestAsync<DescribeAIAnalysisSMTPResponse>(req, "DescribeAIAnalysisSMTP")
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
        /// 查询AI 定时任务列表。
        /// 
        /// 支持分页查询和状态过滤，返回定时任务列表及总条数。
        /// </summary>
        /// <param name="req"><see cref="DescribeAIScheduleListRequest"/></param>
        /// <returns><see cref="DescribeAIScheduleListResponse"/></returns>
        public Task<DescribeAIScheduleListResponse> DescribeAIScheduleList(DescribeAIScheduleListRequest req)
        {
            return InternalRequestAsync<DescribeAIScheduleListResponse>(req, "DescribeAIScheduleList");
        }

        /// <summary>
        /// 查询AI 定时任务列表。
        /// 
        /// 支持分页查询和状态过滤，返回定时任务列表及总条数。
        /// </summary>
        /// <param name="req"><see cref="DescribeAIScheduleListRequest"/></param>
        /// <returns><see cref="DescribeAIScheduleListResponse"/></returns>
        public DescribeAIScheduleListResponse DescribeAIScheduleListSync(DescribeAIScheduleListRequest req)
        {
            return InternalRequestAsync<DescribeAIScheduleListResponse>(req, "DescribeAIScheduleList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询AI 定时任务触发计划。
        /// 
        /// 查询指定AI 定时任务在给定时间窗口内的未来触发计划列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAISchedulePlanListRequest"/></param>
        /// <returns><see cref="DescribeAISchedulePlanListResponse"/></returns>
        public Task<DescribeAISchedulePlanListResponse> DescribeAISchedulePlanList(DescribeAISchedulePlanListRequest req)
        {
            return InternalRequestAsync<DescribeAISchedulePlanListResponse>(req, "DescribeAISchedulePlanList");
        }

        /// <summary>
        /// 查询AI 定时任务触发计划。
        /// 
        /// 查询指定AI 定时任务在给定时间窗口内的未来触发计划列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeAISchedulePlanListRequest"/></param>
        /// <returns><see cref="DescribeAISchedulePlanListResponse"/></returns>
        public DescribeAISchedulePlanListResponse DescribeAISchedulePlanListSync(DescribeAISchedulePlanListRequest req)
        {
            return InternalRequestAsync<DescribeAISchedulePlanListResponse>(req, "DescribeAISchedulePlanList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询AI 定时任务统计信息。
        /// 
        /// 返回当前用户的定时任务总数和当前运行中的任务数量。
        /// </summary>
        /// <param name="req"><see cref="DescribeAIScheduleStatsRequest"/></param>
        /// <returns><see cref="DescribeAIScheduleStatsResponse"/></returns>
        public Task<DescribeAIScheduleStatsResponse> DescribeAIScheduleStats(DescribeAIScheduleStatsRequest req)
        {
            return InternalRequestAsync<DescribeAIScheduleStatsResponse>(req, "DescribeAIScheduleStats");
        }

        /// <summary>
        /// 查询AI 定时任务统计信息。
        /// 
        /// 返回当前用户的定时任务总数和当前运行中的任务数量。
        /// </summary>
        /// <param name="req"><see cref="DescribeAIScheduleStatsRequest"/></param>
        /// <returns><see cref="DescribeAIScheduleStatsResponse"/></returns>
        public DescribeAIScheduleStatsResponse DescribeAIScheduleStatsSync(DescribeAIScheduleStatsRequest req)
        {
            return InternalRequestAsync<DescribeAIScheduleStatsResponse>(req, "DescribeAIScheduleStats")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询AI 定时任务执行详情。
        /// 
        /// 根据任务 ID 查询指定执行任务的详细信息，包括执行状态、结果等。
        /// </summary>
        /// <param name="req"><see cref="DescribeAIScheduleTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeAIScheduleTaskDetailResponse"/></returns>
        public Task<DescribeAIScheduleTaskDetailResponse> DescribeAIScheduleTaskDetail(DescribeAIScheduleTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeAIScheduleTaskDetailResponse>(req, "DescribeAIScheduleTaskDetail");
        }

        /// <summary>
        /// 查询AI 定时任务执行详情。
        /// 
        /// 根据任务 ID 查询指定执行任务的详细信息，包括执行状态、结果等。
        /// </summary>
        /// <param name="req"><see cref="DescribeAIScheduleTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeAIScheduleTaskDetailResponse"/></returns>
        public DescribeAIScheduleTaskDetailResponse DescribeAIScheduleTaskDetailSync(DescribeAIScheduleTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeAIScheduleTaskDetailResponse>(req, "DescribeAIScheduleTaskDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询AI 定时任务执行列表。
        /// 
        /// 查询AI 定时任务的历史执行记录，支持分页和按定时任务 ID 过滤。
        /// </summary>
        /// <param name="req"><see cref="DescribeAIScheduleTaskListRequest"/></param>
        /// <returns><see cref="DescribeAIScheduleTaskListResponse"/></returns>
        public Task<DescribeAIScheduleTaskListResponse> DescribeAIScheduleTaskList(DescribeAIScheduleTaskListRequest req)
        {
            return InternalRequestAsync<DescribeAIScheduleTaskListResponse>(req, "DescribeAIScheduleTaskList");
        }

        /// <summary>
        /// 查询AI 定时任务执行列表。
        /// 
        /// 查询AI 定时任务的历史执行记录，支持分页和按定时任务 ID 过滤。
        /// </summary>
        /// <param name="req"><see cref="DescribeAIScheduleTaskListRequest"/></param>
        /// <returns><see cref="DescribeAIScheduleTaskListResponse"/></returns>
        public DescribeAIScheduleTaskListResponse DescribeAIScheduleTaskListSync(DescribeAIScheduleTaskListRequest req)
        {
            return InternalRequestAsync<DescribeAIScheduleTaskListResponse>(req, "DescribeAIScheduleTaskList")
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
        /// 判断用户是否灰度用户
        /// </summary>
        /// <param name="req"><see cref="DescribeAbTestUserRequest"/></param>
        /// <returns><see cref="DescribeAbTestUserResponse"/></returns>
        public Task<DescribeAbTestUserResponse> DescribeAbTestUser(DescribeAbTestUserRequest req)
        {
            return InternalRequestAsync<DescribeAbTestUserResponse>(req, "DescribeAbTestUser");
        }

        /// <summary>
        /// 判断用户是否灰度用户
        /// </summary>
        /// <param name="req"><see cref="DescribeAbTestUserRequest"/></param>
        /// <returns><see cref="DescribeAbTestUserResponse"/></returns>
        public DescribeAbTestUserResponse DescribeAbTestUserSync(DescribeAbTestUserRequest req)
        {
            return InternalRequestAsync<DescribeAbTestUserResponse>(req, "DescribeAbTestUser")
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
        /// 查询客户端配置设置（配置组），从DescribeAgentRunMode拆分出的独立接口
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentConfigSettingRequest"/></param>
        /// <returns><see cref="DescribeAgentConfigSettingResponse"/></returns>
        public Task<DescribeAgentConfigSettingResponse> DescribeAgentConfigSetting(DescribeAgentConfigSettingRequest req)
        {
            return InternalRequestAsync<DescribeAgentConfigSettingResponse>(req, "DescribeAgentConfigSetting");
        }

        /// <summary>
        /// 查询客户端配置设置（配置组），从DescribeAgentRunMode拆分出的独立接口
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentConfigSettingRequest"/></param>
        /// <returns><see cref="DescribeAgentConfigSettingResponse"/></returns>
        public DescribeAgentConfigSettingResponse DescribeAgentConfigSettingSync(DescribeAgentConfigSettingRequest req)
        {
            return InternalRequestAsync<DescribeAgentConfigSettingResponse>(req, "DescribeAgentConfigSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取客户端运行模式和运行配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentRunModeRequest"/></param>
        /// <returns><see cref="DescribeAgentRunModeResponse"/></returns>
        public Task<DescribeAgentRunModeResponse> DescribeAgentRunMode(DescribeAgentRunModeRequest req)
        {
            return InternalRequestAsync<DescribeAgentRunModeResponse>(req, "DescribeAgentRunMode");
        }

        /// <summary>
        /// 获取客户端运行模式和运行配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentRunModeRequest"/></param>
        /// <returns><see cref="DescribeAgentRunModeResponse"/></returns>
        public DescribeAgentRunModeResponse DescribeAgentRunModeSync(DescribeAgentRunModeRequest req)
        {
            return InternalRequestAsync<DescribeAgentRunModeResponse>(req, "DescribeAgentRunMode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询客户端运行策略（策略组），从DescribeAgentRunMode拆分出的独立接口
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentRunPolicyRequest"/></param>
        /// <returns><see cref="DescribeAgentRunPolicyResponse"/></returns>
        public Task<DescribeAgentRunPolicyResponse> DescribeAgentRunPolicy(DescribeAgentRunPolicyRequest req)
        {
            return InternalRequestAsync<DescribeAgentRunPolicyResponse>(req, "DescribeAgentRunPolicy");
        }

        /// <summary>
        /// 查询客户端运行策略（策略组），从DescribeAgentRunMode拆分出的独立接口
        /// </summary>
        /// <param name="req"><see cref="DescribeAgentRunPolicyRequest"/></param>
        /// <returns><see cref="DescribeAgentRunPolicyResponse"/></returns>
        public DescribeAgentRunPolicyResponse DescribeAgentRunPolicySync(DescribeAgentRunPolicyRequest req)
        {
            return InternalRequestAsync<DescribeAgentRunPolicyResponse>(req, "DescribeAgentRunPolicy")
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
        /// 查询资产中组件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetComponentListRequest"/></param>
        /// <returns><see cref="DescribeAssetComponentListResponse"/></returns>
        public Task<DescribeAssetComponentListResponse> DescribeAssetComponentList(DescribeAssetComponentListRequest req)
        {
            return InternalRequestAsync<DescribeAssetComponentListResponse>(req, "DescribeAssetComponentList");
        }

        /// <summary>
        /// 查询资产中组件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetComponentListRequest"/></param>
        /// <returns><see cref="DescribeAssetComponentListResponse"/></returns>
        public DescribeAssetComponentListResponse DescribeAssetComponentListSync(DescribeAssetComponentListRequest req)
        {
            return InternalRequestAsync<DescribeAssetComponentListResponse>(req, "DescribeAssetComponentList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询镜像仓库组件关联的镜像列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetComponentRelatedImageListRequest"/></param>
        /// <returns><see cref="DescribeAssetComponentRelatedImageListResponse"/></returns>
        public Task<DescribeAssetComponentRelatedImageListResponse> DescribeAssetComponentRelatedImageList(DescribeAssetComponentRelatedImageListRequest req)
        {
            return InternalRequestAsync<DescribeAssetComponentRelatedImageListResponse>(req, "DescribeAssetComponentRelatedImageList");
        }

        /// <summary>
        /// 查询镜像仓库组件关联的镜像列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetComponentRelatedImageListRequest"/></param>
        /// <returns><see cref="DescribeAssetComponentRelatedImageListResponse"/></returns>
        public DescribeAssetComponentRelatedImageListResponse DescribeAssetComponentRelatedImageListSync(DescribeAssetComponentRelatedImageListRequest req)
        {
            return InternalRequestAsync<DescribeAssetComponentRelatedImageListResponse>(req, "DescribeAssetComponentRelatedImageList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 资产详情信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetDetailRequest"/></param>
        /// <returns><see cref="DescribeAssetDetailResponse"/></returns>
        public Task<DescribeAssetDetailResponse> DescribeAssetDetail(DescribeAssetDetailRequest req)
        {
            return InternalRequestAsync<DescribeAssetDetailResponse>(req, "DescribeAssetDetail");
        }

        /// <summary>
        /// 资产详情信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetDetailRequest"/></param>
        /// <returns><see cref="DescribeAssetDetailResponse"/></returns>
        public DescribeAssetDetailResponse DescribeAssetDetailSync(DescribeAssetDetailRequest req)
        {
            return InternalRequestAsync<DescribeAssetDetailResponse>(req, "DescribeAssetDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 资产搜索视图
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetFilterViewsRequest"/></param>
        /// <returns><see cref="DescribeAssetFilterViewsResponse"/></returns>
        public Task<DescribeAssetFilterViewsResponse> DescribeAssetFilterViews(DescribeAssetFilterViewsRequest req)
        {
            return InternalRequestAsync<DescribeAssetFilterViewsResponse>(req, "DescribeAssetFilterViews");
        }

        /// <summary>
        /// 资产搜索视图
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetFilterViewsRequest"/></param>
        /// <returns><see cref="DescribeAssetFilterViewsResponse"/></returns>
        public DescribeAssetFilterViewsResponse DescribeAssetFilterViewsSync(DescribeAssetFilterViewsRequest req)
        {
            return InternalRequestAsync<DescribeAssetFilterViewsResponse>(req, "DescribeAssetFilterViews")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 资产信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetInfoRequest"/></param>
        /// <returns><see cref="DescribeAssetInfoResponse"/></returns>
        public Task<DescribeAssetInfoResponse> DescribeAssetInfo(DescribeAssetInfoRequest req)
        {
            return InternalRequestAsync<DescribeAssetInfoResponse>(req, "DescribeAssetInfo");
        }

        /// <summary>
        /// 资产信息
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetInfoRequest"/></param>
        /// <returns><see cref="DescribeAssetInfoResponse"/></returns>
        public DescribeAssetInfoResponse DescribeAssetInfoSync(DescribeAssetInfoRequest req)
        {
            return InternalRequestAsync<DescribeAssetInfoResponse>(req, "DescribeAssetInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 资产最近同步时间
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetLastSyncTimeRequest"/></param>
        /// <returns><see cref="DescribeAssetLastSyncTimeResponse"/></returns>
        public Task<DescribeAssetLastSyncTimeResponse> DescribeAssetLastSyncTime(DescribeAssetLastSyncTimeRequest req)
        {
            return InternalRequestAsync<DescribeAssetLastSyncTimeResponse>(req, "DescribeAssetLastSyncTime");
        }

        /// <summary>
        /// 资产最近同步时间
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetLastSyncTimeRequest"/></param>
        /// <returns><see cref="DescribeAssetLastSyncTimeResponse"/></returns>
        public DescribeAssetLastSyncTimeResponse DescribeAssetLastSyncTimeSync(DescribeAssetLastSyncTimeRequest req)
        {
            return InternalRequestAsync<DescribeAssetLastSyncTimeResponse>(req, "DescribeAssetLastSyncTime")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 资产概览统计
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetOverviewRequest"/></param>
        /// <returns><see cref="DescribeAssetOverviewResponse"/></returns>
        public Task<DescribeAssetOverviewResponse> DescribeAssetOverview(DescribeAssetOverviewRequest req)
        {
            return InternalRequestAsync<DescribeAssetOverviewResponse>(req, "DescribeAssetOverview");
        }

        /// <summary>
        /// 资产概览统计
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetOverviewRequest"/></param>
        /// <returns><see cref="DescribeAssetOverviewResponse"/></returns>
        public DescribeAssetOverviewResponse DescribeAssetOverviewSync(DescribeAssetOverviewRequest req)
        {
            return InternalRequestAsync<DescribeAssetOverviewResponse>(req, "DescribeAssetOverview")
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
        /// 资产风险详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetRiskDetailRequest"/></param>
        /// <returns><see cref="DescribeAssetRiskDetailResponse"/></returns>
        public Task<DescribeAssetRiskDetailResponse> DescribeAssetRiskDetail(DescribeAssetRiskDetailRequest req)
        {
            return InternalRequestAsync<DescribeAssetRiskDetailResponse>(req, "DescribeAssetRiskDetail");
        }

        /// <summary>
        /// 资产风险详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetRiskDetailRequest"/></param>
        /// <returns><see cref="DescribeAssetRiskDetailResponse"/></returns>
        public DescribeAssetRiskDetailResponse DescribeAssetRiskDetailSync(DescribeAssetRiskDetailRequest req)
        {
            return InternalRequestAsync<DescribeAssetRiskDetailResponse>(req, "DescribeAssetRiskDetail")
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
        /// 资产同步任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetSyncTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeAssetSyncTaskStatusResponse"/></returns>
        public Task<DescribeAssetSyncTaskStatusResponse> DescribeAssetSyncTaskStatus(DescribeAssetSyncTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeAssetSyncTaskStatusResponse>(req, "DescribeAssetSyncTaskStatus");
        }

        /// <summary>
        /// 资产同步任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetSyncTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeAssetSyncTaskStatusResponse"/></returns>
        public DescribeAssetSyncTaskStatusResponse DescribeAssetSyncTaskStatusSync(DescribeAssetSyncTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeAssetSyncTaskStatusResponse>(req, "DescribeAssetSyncTaskStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取资产标签属性
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetTagAttributesRequest"/></param>
        /// <returns><see cref="DescribeAssetTagAttributesResponse"/></returns>
        public Task<DescribeAssetTagAttributesResponse> DescribeAssetTagAttributes(DescribeAssetTagAttributesRequest req)
        {
            return InternalRequestAsync<DescribeAssetTagAttributesResponse>(req, "DescribeAssetTagAttributes");
        }

        /// <summary>
        /// 获取资产标签属性
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetTagAttributesRequest"/></param>
        /// <returns><see cref="DescribeAssetTagAttributesResponse"/></returns>
        public DescribeAssetTagAttributesResponse DescribeAssetTagAttributesSync(DescribeAssetTagAttributesRequest req)
        {
            return InternalRequestAsync<DescribeAssetTagAttributesResponse>(req, "DescribeAssetTagAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 资产标签树结构数据
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetTagTreeRequest"/></param>
        /// <returns><see cref="DescribeAssetTagTreeResponse"/></returns>
        public Task<DescribeAssetTagTreeResponse> DescribeAssetTagTree(DescribeAssetTagTreeRequest req)
        {
            return InternalRequestAsync<DescribeAssetTagTreeResponse>(req, "DescribeAssetTagTree");
        }

        /// <summary>
        /// 资产标签树结构数据
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetTagTreeRequest"/></param>
        /// <returns><see cref="DescribeAssetTagTreeResponse"/></returns>
        public DescribeAssetTagTreeResponse DescribeAssetTagTreeSync(DescribeAssetTagTreeRequest req)
        {
            return InternalRequestAsync<DescribeAssetTagTreeResponse>(req, "DescribeAssetTagTree")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 全部资产
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetTagsRequest"/></param>
        /// <returns><see cref="DescribeAssetTagsResponse"/></returns>
        public Task<DescribeAssetTagsResponse> DescribeAssetTags(DescribeAssetTagsRequest req)
        {
            return InternalRequestAsync<DescribeAssetTagsResponse>(req, "DescribeAssetTags");
        }

        /// <summary>
        /// 全部资产
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetTagsRequest"/></param>
        /// <returns><see cref="DescribeAssetTagsResponse"/></returns>
        public DescribeAssetTagsResponse DescribeAssetTagsSync(DescribeAssetTagsRequest req)
        {
            return InternalRequestAsync<DescribeAssetTagsResponse>(req, "DescribeAssetTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 资产树结构
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetTreeRequest"/></param>
        /// <returns><see cref="DescribeAssetTreeResponse"/></returns>
        public Task<DescribeAssetTreeResponse> DescribeAssetTree(DescribeAssetTreeRequest req)
        {
            return InternalRequestAsync<DescribeAssetTreeResponse>(req, "DescribeAssetTree");
        }

        /// <summary>
        /// 资产树结构
        /// </summary>
        /// <param name="req"><see cref="DescribeAssetTreeRequest"/></param>
        /// <returns><see cref="DescribeAssetTreeResponse"/></returns>
        public DescribeAssetTreeResponse DescribeAssetTreeSync(DescribeAssetTreeRequest req)
        {
            return InternalRequestAsync<DescribeAssetTreeResponse>(req, "DescribeAssetTree")
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
        /// 查询后台扫描引擎地域列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBackendScanEngineRegionListRequest"/></param>
        /// <returns><see cref="DescribeBackendScanEngineRegionListResponse"/></returns>
        public Task<DescribeBackendScanEngineRegionListResponse> DescribeBackendScanEngineRegionList(DescribeBackendScanEngineRegionListRequest req)
        {
            return InternalRequestAsync<DescribeBackendScanEngineRegionListResponse>(req, "DescribeBackendScanEngineRegionList");
        }

        /// <summary>
        /// 查询后台扫描引擎地域列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBackendScanEngineRegionListRequest"/></param>
        /// <returns><see cref="DescribeBackendScanEngineRegionListResponse"/></returns>
        public DescribeBackendScanEngineRegionListResponse DescribeBackendScanEngineRegionListSync(DescribeBackendScanEngineRegionListRequest req)
        {
            return InternalRequestAsync<DescribeBackendScanEngineRegionListResponse>(req, "DescribeBackendScanEngineRegionList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取爆破阻断模式
        /// </summary>
        /// <param name="req"><see cref="DescribeBanModeRequest"/></param>
        /// <returns><see cref="DescribeBanModeResponse"/></returns>
        public Task<DescribeBanModeResponse> DescribeBanMode(DescribeBanModeRequest req)
        {
            return InternalRequestAsync<DescribeBanModeResponse>(req, "DescribeBanMode");
        }

        /// <summary>
        /// 获取爆破阻断模式
        /// </summary>
        /// <param name="req"><see cref="DescribeBanModeRequest"/></param>
        /// <returns><see cref="DescribeBanModeResponse"/></returns>
        public DescribeBanModeResponse DescribeBanModeSync(DescribeBanModeRequest req)
        {
            return InternalRequestAsync<DescribeBanModeResponse>(req, "DescribeBanMode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取阻断按钮状态
        /// </summary>
        /// <param name="req"><see cref="DescribeBanStatusRequest"/></param>
        /// <returns><see cref="DescribeBanStatusResponse"/></returns>
        public Task<DescribeBanStatusResponse> DescribeBanStatus(DescribeBanStatusRequest req)
        {
            return InternalRequestAsync<DescribeBanStatusResponse>(req, "DescribeBanStatus");
        }

        /// <summary>
        /// 获取阻断按钮状态
        /// </summary>
        /// <param name="req"><see cref="DescribeBanStatusRequest"/></param>
        /// <returns><see cref="DescribeBanStatusResponse"/></returns>
        public DescribeBanStatusResponse DescribeBanStatusSync(DescribeBanStatusRequest req)
        {
            return InternalRequestAsync<DescribeBanStatusResponse>(req, "DescribeBanStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取检测项维度的聚合扫描结果列表，用于策略详情页“检测项”Tab 按检测项展示通过/未通过资产数。
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineAggregatedItemListRequest"/></param>
        /// <returns><see cref="DescribeBaselineAggregatedItemListResponse"/></returns>
        public Task<DescribeBaselineAggregatedItemListResponse> DescribeBaselineAggregatedItemList(DescribeBaselineAggregatedItemListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineAggregatedItemListResponse>(req, "DescribeBaselineAggregatedItemList");
        }

        /// <summary>
        /// 获取检测项维度的聚合扫描结果列表，用于策略详情页“检测项”Tab 按检测项展示通过/未通过资产数。
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineAggregatedItemListRequest"/></param>
        /// <returns><see cref="DescribeBaselineAggregatedItemListResponse"/></returns>
        public DescribeBaselineAggregatedItemListResponse DescribeBaselineAggregatedItemListSync(DescribeBaselineAggregatedItemListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineAggregatedItemListResponse>(req, "DescribeBaselineAggregatedItemList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取基线策略维度的聚合扫描结果列表，用于概览页“基线扫描策略”模块按策略展示通过/未通过情况。
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineAggregatedPolicyListRequest"/></param>
        /// <returns><see cref="DescribeBaselineAggregatedPolicyListResponse"/></returns>
        public Task<DescribeBaselineAggregatedPolicyListResponse> DescribeBaselineAggregatedPolicyList(DescribeBaselineAggregatedPolicyListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineAggregatedPolicyListResponse>(req, "DescribeBaselineAggregatedPolicyList");
        }

        /// <summary>
        /// 获取基线策略维度的聚合扫描结果列表，用于概览页“基线扫描策略”模块按策略展示通过/未通过情况。
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineAggregatedPolicyListRequest"/></param>
        /// <returns><see cref="DescribeBaselineAggregatedPolicyListResponse"/></returns>
        public DescribeBaselineAggregatedPolicyListResponse DescribeBaselineAggregatedPolicyListSync(DescribeBaselineAggregatedPolicyListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineAggregatedPolicyListResponse>(req, "DescribeBaselineAggregatedPolicyList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询当前处于“统计计算中”状态的策略 ID 列表，用于前端轮询判断扫描结果统计是否就绪。
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineCalculatingStatisticsPolicyIDListRequest"/></param>
        /// <returns><see cref="DescribeBaselineCalculatingStatisticsPolicyIDListResponse"/></returns>
        public Task<DescribeBaselineCalculatingStatisticsPolicyIDListResponse> DescribeBaselineCalculatingStatisticsPolicyIDList(DescribeBaselineCalculatingStatisticsPolicyIDListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineCalculatingStatisticsPolicyIDListResponse>(req, "DescribeBaselineCalculatingStatisticsPolicyIDList");
        }

        /// <summary>
        /// 查询当前处于“统计计算中”状态的策略 ID 列表，用于前端轮询判断扫描结果统计是否就绪。
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineCalculatingStatisticsPolicyIDListRequest"/></param>
        /// <returns><see cref="DescribeBaselineCalculatingStatisticsPolicyIDListResponse"/></returns>
        public DescribeBaselineCalculatingStatisticsPolicyIDListResponse DescribeBaselineCalculatingStatisticsPolicyIDListSync(DescribeBaselineCalculatingStatisticsPolicyIDListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineCalculatingStatisticsPolicyIDListResponse>(req, "DescribeBaselineCalculatingStatisticsPolicyIDList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取分类检测项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineCategoryItemListRequest"/></param>
        /// <returns><see cref="DescribeBaselineCategoryItemListResponse"/></returns>
        public Task<DescribeBaselineCategoryItemListResponse> DescribeBaselineCategoryItemList(DescribeBaselineCategoryItemListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineCategoryItemListResponse>(req, "DescribeBaselineCategoryItemList");
        }

        /// <summary>
        /// 获取分类检测项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineCategoryItemListRequest"/></param>
        /// <returns><see cref="DescribeBaselineCategoryItemListResponse"/></returns>
        public DescribeBaselineCategoryItemListResponse DescribeBaselineCategoryItemListSync(DescribeBaselineCategoryItemListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineCategoryItemListResponse>(req, "DescribeBaselineCategoryItemList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取基线风险修复历史记录列表，用于“修复记录”页展示已修复的检测项与对应资产。
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineFixRecordListRequest"/></param>
        /// <returns><see cref="DescribeBaselineFixRecordListResponse"/></returns>
        public Task<DescribeBaselineFixRecordListResponse> DescribeBaselineFixRecordList(DescribeBaselineFixRecordListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineFixRecordListResponse>(req, "DescribeBaselineFixRecordList");
        }

        /// <summary>
        /// 获取基线风险修复历史记录列表，用于“修复记录”页展示已修复的检测项与对应资产。
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineFixRecordListRequest"/></param>
        /// <returns><see cref="DescribeBaselineFixRecordListResponse"/></returns>
        public DescribeBaselineFixRecordListResponse DescribeBaselineFixRecordListSync(DescribeBaselineFixRecordListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineFixRecordListResponse>(req, "DescribeBaselineFixRecordList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取检测项维度的风险记录列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineItemRiskListRequest"/></param>
        /// <returns><see cref="DescribeBaselineItemRiskListResponse"/></returns>
        public Task<DescribeBaselineItemRiskListResponse> DescribeBaselineItemRiskList(DescribeBaselineItemRiskListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineItemRiskListResponse>(req, "DescribeBaselineItemRiskList");
        }

        /// <summary>
        /// 获取检测项维度的风险记录列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineItemRiskListRequest"/></param>
        /// <returns><see cref="DescribeBaselineItemRiskListResponse"/></returns>
        public DescribeBaselineItemRiskListResponse DescribeBaselineItemRiskListSync(DescribeBaselineItemRiskListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineItemRiskListResponse>(req, "DescribeBaselineItemRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取系统内置基线分类的检测项列表（父分类 → 子分类 → 内置检测项 ID 列表），用于策略编辑页选择基线检测项。
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineMainTaskItemListRequest"/></param>
        /// <returns><see cref="DescribeBaselineMainTaskItemListResponse"/></returns>
        public Task<DescribeBaselineMainTaskItemListResponse> DescribeBaselineMainTaskItemList(DescribeBaselineMainTaskItemListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineMainTaskItemListResponse>(req, "DescribeBaselineMainTaskItemList");
        }

        /// <summary>
        /// 获取系统内置基线分类的检测项列表（父分类 → 子分类 → 内置检测项 ID 列表），用于策略编辑页选择基线检测项。
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineMainTaskItemListRequest"/></param>
        /// <returns><see cref="DescribeBaselineMainTaskItemListResponse"/></returns>
        public DescribeBaselineMainTaskItemListResponse DescribeBaselineMainTaskItemListSync(DescribeBaselineMainTaskItemListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineMainTaskItemListResponse>(req, "DescribeBaselineMainTaskItemList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取扫描主任务列表，用于“任务记录”页展示一键扫描 / 周期扫描 / 分散扫描的历史记录及结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineMainTaskListRequest"/></param>
        /// <returns><see cref="DescribeBaselineMainTaskListResponse"/></returns>
        public Task<DescribeBaselineMainTaskListResponse> DescribeBaselineMainTaskList(DescribeBaselineMainTaskListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineMainTaskListResponse>(req, "DescribeBaselineMainTaskList");
        }

        /// <summary>
        /// 获取扫描主任务列表，用于“任务记录”页展示一键扫描 / 周期扫描 / 分散扫描的历史记录及结果。
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineMainTaskListRequest"/></param>
        /// <returns><see cref="DescribeBaselineMainTaskListResponse"/></returns>
        public DescribeBaselineMainTaskListResponse DescribeBaselineMainTaskListSync(DescribeBaselineMainTaskListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineMainTaskListResponse>(req, "DescribeBaselineMainTaskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取基线概览页的头部数据，含未通过检测项总数、近一年修复数、最近一次扫描时间、当前是否启用周期扫描等。
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineOverviewRequest"/></param>
        /// <returns><see cref="DescribeBaselineOverviewResponse"/></returns>
        public Task<DescribeBaselineOverviewResponse> DescribeBaselineOverview(DescribeBaselineOverviewRequest req)
        {
            return InternalRequestAsync<DescribeBaselineOverviewResponse>(req, "DescribeBaselineOverview");
        }

        /// <summary>
        /// 获取基线概览页的头部数据，含未通过检测项总数、近一年修复数、最近一次扫描时间、当前是否启用周期扫描等。
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineOverviewRequest"/></param>
        /// <returns><see cref="DescribeBaselineOverviewResponse"/></returns>
        public DescribeBaselineOverviewResponse DescribeBaselineOverviewSync(DescribeBaselineOverviewRequest req)
        {
            return InternalRequestAsync<DescribeBaselineOverviewResponse>(req, "DescribeBaselineOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取系统内置基线分类树（父分类 → 子分类 → 内置检测项 ID 列表），用于策略详情展示。
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselinePolicyCategoryListRequest"/></param>
        /// <returns><see cref="DescribeBaselinePolicyCategoryListResponse"/></returns>
        public Task<DescribeBaselinePolicyCategoryListResponse> DescribeBaselinePolicyCategoryList(DescribeBaselinePolicyCategoryListRequest req)
        {
            return InternalRequestAsync<DescribeBaselinePolicyCategoryListResponse>(req, "DescribeBaselinePolicyCategoryList");
        }

        /// <summary>
        /// 获取系统内置基线分类树（父分类 → 子分类 → 内置检测项 ID 列表），用于策略详情展示。
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselinePolicyCategoryListRequest"/></param>
        /// <returns><see cref="DescribeBaselinePolicyCategoryListResponse"/></returns>
        public DescribeBaselinePolicyCategoryListResponse DescribeBaselinePolicyCategoryListSync(DescribeBaselinePolicyCategoryListRequest req)
        {
            return InternalRequestAsync<DescribeBaselinePolicyCategoryListResponse>(req, "DescribeBaselinePolicyCategoryList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取策略配置的检测项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselinePolicyItemListRequest"/></param>
        /// <returns><see cref="DescribeBaselinePolicyItemListResponse"/></returns>
        public Task<DescribeBaselinePolicyItemListResponse> DescribeBaselinePolicyItemList(DescribeBaselinePolicyItemListRequest req)
        {
            return InternalRequestAsync<DescribeBaselinePolicyItemListResponse>(req, "DescribeBaselinePolicyItemList");
        }

        /// <summary>
        /// 获取策略配置的检测项列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselinePolicyItemListRequest"/></param>
        /// <returns><see cref="DescribeBaselinePolicyItemListResponse"/></returns>
        public DescribeBaselinePolicyItemListResponse DescribeBaselinePolicyItemListSync(DescribeBaselinePolicyItemListRequest req)
        {
            return InternalRequestAsync<DescribeBaselinePolicyItemListResponse>(req, "DescribeBaselinePolicyItemList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取基线策略列表，用于“周期计划管理”等列表页展示系统/自定义策略及其配置情况。
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselinePolicyListRequest"/></param>
        /// <returns><see cref="DescribeBaselinePolicyListResponse"/></returns>
        public Task<DescribeBaselinePolicyListResponse> DescribeBaselinePolicyList(DescribeBaselinePolicyListRequest req)
        {
            return InternalRequestAsync<DescribeBaselinePolicyListResponse>(req, "DescribeBaselinePolicyList");
        }

        /// <summary>
        /// 获取基线策略列表，用于“周期计划管理”等列表页展示系统/自定义策略及其配置情况。
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselinePolicyListRequest"/></param>
        /// <returns><see cref="DescribeBaselinePolicyListResponse"/></returns>
        public DescribeBaselinePolicyListResponse DescribeBaselinePolicyListSync(DescribeBaselinePolicyListRequest req)
        {
            return InternalRequestAsync<DescribeBaselinePolicyListResponse>(req, "DescribeBaselinePolicyList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取基线策略名字存在的用户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselinePolicyNameExistAppidListRequest"/></param>
        /// <returns><see cref="DescribeBaselinePolicyNameExistAppidListResponse"/></returns>
        public Task<DescribeBaselinePolicyNameExistAppidListResponse> DescribeBaselinePolicyNameExistAppidList(DescribeBaselinePolicyNameExistAppidListRequest req)
        {
            return InternalRequestAsync<DescribeBaselinePolicyNameExistAppidListResponse>(req, "DescribeBaselinePolicyNameExistAppidList");
        }

        /// <summary>
        /// 获取基线策略名字存在的用户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselinePolicyNameExistAppidListRequest"/></param>
        /// <returns><see cref="DescribeBaselinePolicyNameExistAppidListResponse"/></returns>
        public DescribeBaselinePolicyNameExistAppidListResponse DescribeBaselinePolicyNameExistAppidListSync(DescribeBaselinePolicyNameExistAppidListRequest req)
        {
            return InternalRequestAsync<DescribeBaselinePolicyNameExistAppidListResponse>(req, "DescribeBaselinePolicyNameExistAppidList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取扫描子任务列表，用于任务详情页“资产维度”展示每台主机/每个集群的扫描状态与失败原因。
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineSubTaskListRequest"/></param>
        /// <returns><see cref="DescribeBaselineSubTaskListResponse"/></returns>
        public Task<DescribeBaselineSubTaskListResponse> DescribeBaselineSubTaskList(DescribeBaselineSubTaskListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineSubTaskListResponse>(req, "DescribeBaselineSubTaskList");
        }

        /// <summary>
        /// 获取扫描子任务列表，用于任务详情页“资产维度”展示每台主机/每个集群的扫描状态与失败原因。
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineSubTaskListRequest"/></param>
        /// <returns><see cref="DescribeBaselineSubTaskListResponse"/></returns>
        public DescribeBaselineSubTaskListResponse DescribeBaselineSubTaskListSync(DescribeBaselineSubTaskListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineSubTaskListResponse>(req, "DescribeBaselineSubTaskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取当前账号（管理员）的基线同步配置。仅集团管理员可调用，普通成员账号请使用 DescribeBaselineUserOtherConf。
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineSyncConfRequest"/></param>
        /// <returns><see cref="DescribeBaselineSyncConfResponse"/></returns>
        public Task<DescribeBaselineSyncConfResponse> DescribeBaselineSyncConf(DescribeBaselineSyncConfRequest req)
        {
            return InternalRequestAsync<DescribeBaselineSyncConfResponse>(req, "DescribeBaselineSyncConf");
        }

        /// <summary>
        /// 获取当前账号（管理员）的基线同步配置。仅集团管理员可调用，普通成员账号请使用 DescribeBaselineUserOtherConf。
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineSyncConfRequest"/></param>
        /// <returns><see cref="DescribeBaselineSyncConfResponse"/></returns>
        public DescribeBaselineSyncConfResponse DescribeBaselineSyncConfSync(DescribeBaselineSyncConfRequest req)
        {
            return InternalRequestAsync<DescribeBaselineSyncConfResponse>(req, "DescribeBaselineSyncConf")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取系统内置基线分类树（父分类 → 子分类 → 内置检测项 ID 列表），用于策略编辑页选择基线检测项。
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineSystemCategoryListRequest"/></param>
        /// <returns><see cref="DescribeBaselineSystemCategoryListResponse"/></returns>
        public Task<DescribeBaselineSystemCategoryListResponse> DescribeBaselineSystemCategoryList(DescribeBaselineSystemCategoryListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineSystemCategoryListResponse>(req, "DescribeBaselineSystemCategoryList");
        }

        /// <summary>
        /// 获取系统内置基线分类树（父分类 → 子分类 → 内置检测项 ID 列表），用于策略编辑页选择基线检测项。
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineSystemCategoryListRequest"/></param>
        /// <returns><see cref="DescribeBaselineSystemCategoryListResponse"/></returns>
        public DescribeBaselineSystemCategoryListResponse DescribeBaselineSystemCategoryListSync(DescribeBaselineSystemCategoryListRequest req)
        {
            return InternalRequestAsync<DescribeBaselineSystemCategoryListResponse>(req, "DescribeBaselineSystemCategoryList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取当前账号的用户级基线配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineUserOtherConfRequest"/></param>
        /// <returns><see cref="DescribeBaselineUserOtherConfResponse"/></returns>
        public Task<DescribeBaselineUserOtherConfResponse> DescribeBaselineUserOtherConf(DescribeBaselineUserOtherConfRequest req)
        {
            return InternalRequestAsync<DescribeBaselineUserOtherConfResponse>(req, "DescribeBaselineUserOtherConf");
        }

        /// <summary>
        /// 获取当前账号的用户级基线配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineUserOtherConfRequest"/></param>
        /// <returns><see cref="DescribeBaselineUserOtherConfResponse"/></returns>
        public DescribeBaselineUserOtherConfResponse DescribeBaselineUserOtherConfSync(DescribeBaselineUserOtherConfRequest req)
        {
            return InternalRequestAsync<DescribeBaselineUserOtherConfResponse>(req, "DescribeBaselineUserOtherConf")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取当前账号的“用户弱口令”自定义字典（服务端解密后返回明文）。
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineUserWeakPasswordConfRequest"/></param>
        /// <returns><see cref="DescribeBaselineUserWeakPasswordConfResponse"/></returns>
        public Task<DescribeBaselineUserWeakPasswordConfResponse> DescribeBaselineUserWeakPasswordConf(DescribeBaselineUserWeakPasswordConfRequest req)
        {
            return InternalRequestAsync<DescribeBaselineUserWeakPasswordConfResponse>(req, "DescribeBaselineUserWeakPasswordConf");
        }

        /// <summary>
        /// 获取当前账号的“用户弱口令”自定义字典（服务端解密后返回明文）。
        /// </summary>
        /// <param name="req"><see cref="DescribeBaselineUserWeakPasswordConfRequest"/></param>
        /// <returns><see cref="DescribeBaselineUserWeakPasswordConfResponse"/></returns>
        public DescribeBaselineUserWeakPasswordConfResponse DescribeBaselineUserWeakPasswordConfSync(DescribeBaselineUserWeakPasswordConfRequest req)
        {
            return InternalRequestAsync<DescribeBaselineUserWeakPasswordConfResponse>(req, "DescribeBaselineUserWeakPasswordConf")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取爆破破解规则
        /// </summary>
        /// <param name="req"><see cref="DescribeBruteAttackRulesRequest"/></param>
        /// <returns><see cref="DescribeBruteAttackRulesResponse"/></returns>
        public Task<DescribeBruteAttackRulesResponse> DescribeBruteAttackRules(DescribeBruteAttackRulesRequest req)
        {
            return InternalRequestAsync<DescribeBruteAttackRulesResponse>(req, "DescribeBruteAttackRules");
        }

        /// <summary>
        /// 获取爆破破解规则
        /// </summary>
        /// <param name="req"><see cref="DescribeBruteAttackRulesRequest"/></param>
        /// <returns><see cref="DescribeBruteAttackRulesResponse"/></returns>
        public DescribeBruteAttackRulesResponse DescribeBruteAttackRulesSync(DescribeBruteAttackRulesRequest req)
        {
            return InternalRequestAsync<DescribeBruteAttackRulesResponse>(req, "DescribeBruteAttackRules")
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
        /// 云资源配置检查报告风险统计
        /// </summary>
        /// <param name="req"><see cref="DescribeCFGRiskReportStatisticsRequest"/></param>
        /// <returns><see cref="DescribeCFGRiskReportStatisticsResponse"/></returns>
        public Task<DescribeCFGRiskReportStatisticsResponse> DescribeCFGRiskReportStatistics(DescribeCFGRiskReportStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeCFGRiskReportStatisticsResponse>(req, "DescribeCFGRiskReportStatistics");
        }

        /// <summary>
        /// 云资源配置检查报告风险统计
        /// </summary>
        /// <param name="req"><see cref="DescribeCFGRiskReportStatisticsRequest"/></param>
        /// <returns><see cref="DescribeCFGRiskReportStatisticsResponse"/></returns>
        public DescribeCFGRiskReportStatisticsResponse DescribeCFGRiskReportStatisticsSync(DescribeCFGRiskReportStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeCFGRiskReportStatisticsResponse>(req, "DescribeCFGRiskReportStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取扫描结果统计信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCFGRiskStatisticsRequest"/></param>
        /// <returns><see cref="DescribeCFGRiskStatisticsResponse"/></returns>
        public Task<DescribeCFGRiskStatisticsResponse> DescribeCFGRiskStatistics(DescribeCFGRiskStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeCFGRiskStatisticsResponse>(req, "DescribeCFGRiskStatistics");
        }

        /// <summary>
        /// 获取扫描结果统计信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCFGRiskStatisticsRequest"/></param>
        /// <returns><see cref="DescribeCFGRiskStatisticsResponse"/></returns>
        public DescribeCFGRiskStatisticsResponse DescribeCFGRiskStatisticsSync(DescribeCFGRiskStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeCFGRiskStatisticsResponse>(req, "DescribeCFGRiskStatistics")
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
        /// 查询ModifyCSIPLicenseBinds返回的异步绑定任务进度。
        /// </summary>
        /// <param name="req"><see cref="DescribeCSIPLicenseBindScheduleRequest"/></param>
        /// <returns><see cref="DescribeCSIPLicenseBindScheduleResponse"/></returns>
        public Task<DescribeCSIPLicenseBindScheduleResponse> DescribeCSIPLicenseBindSchedule(DescribeCSIPLicenseBindScheduleRequest req)
        {
            return InternalRequestAsync<DescribeCSIPLicenseBindScheduleResponse>(req, "DescribeCSIPLicenseBindSchedule");
        }

        /// <summary>
        /// 查询ModifyCSIPLicenseBinds返回的异步绑定任务进度。
        /// </summary>
        /// <param name="req"><see cref="DescribeCSIPLicenseBindScheduleRequest"/></param>
        /// <returns><see cref="DescribeCSIPLicenseBindScheduleResponse"/></returns>
        public DescribeCSIPLicenseBindScheduleResponse DescribeCSIPLicenseBindScheduleSync(DescribeCSIPLicenseBindScheduleRequest req)
        {
            return InternalRequestAsync<DescribeCSIPLicenseBindScheduleResponse>(req, "DescribeCSIPLicenseBindSchedule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// CSIP 扫描任务主机详情接口
        /// </summary>
        /// <param name="req"><see cref="DescribeCSIPMalwareScanTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeCSIPMalwareScanTaskDetailResponse"/></returns>
        public Task<DescribeCSIPMalwareScanTaskDetailResponse> DescribeCSIPMalwareScanTaskDetail(DescribeCSIPMalwareScanTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeCSIPMalwareScanTaskDetailResponse>(req, "DescribeCSIPMalwareScanTaskDetail");
        }

        /// <summary>
        /// CSIP 扫描任务主机详情接口
        /// </summary>
        /// <param name="req"><see cref="DescribeCSIPMalwareScanTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeCSIPMalwareScanTaskDetailResponse"/></returns>
        public DescribeCSIPMalwareScanTaskDetailResponse DescribeCSIPMalwareScanTaskDetailSync(DescribeCSIPMalwareScanTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeCSIPMalwareScanTaskDetailResponse>(req, "DescribeCSIPMalwareScanTaskDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// CSIP 手动扫描进度查询接口
        /// </summary>
        /// <param name="req"><see cref="DescribeCSIPMalwareScanTaskProgressRequest"/></param>
        /// <returns><see cref="DescribeCSIPMalwareScanTaskProgressResponse"/></returns>
        public Task<DescribeCSIPMalwareScanTaskProgressResponse> DescribeCSIPMalwareScanTaskProgress(DescribeCSIPMalwareScanTaskProgressRequest req)
        {
            return InternalRequestAsync<DescribeCSIPMalwareScanTaskProgressResponse>(req, "DescribeCSIPMalwareScanTaskProgress");
        }

        /// <summary>
        /// CSIP 手动扫描进度查询接口
        /// </summary>
        /// <param name="req"><see cref="DescribeCSIPMalwareScanTaskProgressRequest"/></param>
        /// <returns><see cref="DescribeCSIPMalwareScanTaskProgressResponse"/></returns>
        public DescribeCSIPMalwareScanTaskProgressResponse DescribeCSIPMalwareScanTaskProgressSync(DescribeCSIPMalwareScanTaskProgressRequest req)
        {
            return InternalRequestAsync<DescribeCSIPMalwareScanTaskProgressResponse>(req, "DescribeCSIPMalwareScanTaskProgress")
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
        /// 查询云边界分析路径节点(主机专用)
        /// </summary>
        /// <param name="req"><see cref="DescribeCWPExposePathRequest"/></param>
        /// <returns><see cref="DescribeCWPExposePathResponse"/></returns>
        public Task<DescribeCWPExposePathResponse> DescribeCWPExposePath(DescribeCWPExposePathRequest req)
        {
            return InternalRequestAsync<DescribeCWPExposePathResponse>(req, "DescribeCWPExposePath");
        }

        /// <summary>
        /// 查询云边界分析路径节点(主机专用)
        /// </summary>
        /// <param name="req"><see cref="DescribeCWPExposePathRequest"/></param>
        /// <returns><see cref="DescribeCWPExposePathResponse"/></returns>
        public DescribeCWPExposePathResponse DescribeCWPExposePathSync(DescribeCWPExposePathRequest req)
        {
            return InternalRequestAsync<DescribeCWPExposePathResponse>(req, "DescribeCWPExposePath")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云边界分析资产列表(适用于主机资产)
        /// </summary>
        /// <param name="req"><see cref="DescribeCWPExposuresRequest"/></param>
        /// <returns><see cref="DescribeCWPExposuresResponse"/></returns>
        public Task<DescribeCWPExposuresResponse> DescribeCWPExposures(DescribeCWPExposuresRequest req)
        {
            return InternalRequestAsync<DescribeCWPExposuresResponse>(req, "DescribeCWPExposures");
        }

        /// <summary>
        /// 云边界分析资产列表(适用于主机资产)
        /// </summary>
        /// <param name="req"><see cref="DescribeCWPExposuresRequest"/></param>
        /// <returns><see cref="DescribeCWPExposuresResponse"/></returns>
        public DescribeCWPExposuresResponse DescribeCWPExposuresSync(DescribeCWPExposuresRequest req)
        {
            return InternalRequestAsync<DescribeCWPExposuresResponse>(req, "DescribeCWPExposures")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询授权绑定任务的进度
        /// </summary>
        /// <param name="req"><see cref="DescribeCWPLicenseBindScheduleRequest"/></param>
        /// <returns><see cref="DescribeCWPLicenseBindScheduleResponse"/></returns>
        public Task<DescribeCWPLicenseBindScheduleResponse> DescribeCWPLicenseBindSchedule(DescribeCWPLicenseBindScheduleRequest req)
        {
            return InternalRequestAsync<DescribeCWPLicenseBindScheduleResponse>(req, "DescribeCWPLicenseBindSchedule");
        }

        /// <summary>
        /// 查询授权绑定任务的进度
        /// </summary>
        /// <param name="req"><see cref="DescribeCWPLicenseBindScheduleRequest"/></param>
        /// <returns><see cref="DescribeCWPLicenseBindScheduleResponse"/></returns>
        public DescribeCWPLicenseBindScheduleResponse DescribeCWPLicenseBindScheduleSync(DescribeCWPLicenseBindScheduleRequest req)
        {
            return InternalRequestAsync<DescribeCWPLicenseBindScheduleResponse>(req, "DescribeCWPLicenseBindSchedule")
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
        /// 查询可筛选操作系统列表.
        /// </summary>
        /// <param name="req"><see cref="DescribeCWPMachineOsListRequest"/></param>
        /// <returns><see cref="DescribeCWPMachineOsListResponse"/></returns>
        public Task<DescribeCWPMachineOsListResponse> DescribeCWPMachineOsList(DescribeCWPMachineOsListRequest req)
        {
            return InternalRequestAsync<DescribeCWPMachineOsListResponse>(req, "DescribeCWPMachineOsList");
        }

        /// <summary>
        /// 查询可筛选操作系统列表.
        /// </summary>
        /// <param name="req"><see cref="DescribeCWPMachineOsListRequest"/></param>
        /// <returns><see cref="DescribeCWPMachineOsListResponse"/></returns>
        public DescribeCWPMachineOsListResponse DescribeCWPMachineOsListSync(DescribeCWPMachineOsListRequest req)
        {
            return InternalRequestAsync<DescribeCWPMachineOsListResponse>(req, "DescribeCWPMachineOsList")
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
        /// 查询资源订单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCWPOrderListRequest"/></param>
        /// <returns><see cref="DescribeCWPOrderListResponse"/></returns>
        public Task<DescribeCWPOrderListResponse> DescribeCWPOrderList(DescribeCWPOrderListRequest req)
        {
            return InternalRequestAsync<DescribeCWPOrderListResponse>(req, "DescribeCWPOrderList");
        }

        /// <summary>
        /// 查询资源订单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCWPOrderListRequest"/></param>
        /// <returns><see cref="DescribeCWPOrderListResponse"/></returns>
        public DescribeCWPOrderListResponse DescribeCWPOrderListSync(DescribeCWPOrderListRequest req)
        {
            return InternalRequestAsync<DescribeCWPOrderListResponse>(req, "DescribeCWPOrderList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询腾讯云扫描IP信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCWPScanIpInfoRequest"/></param>
        /// <returns><see cref="DescribeCWPScanIpInfoResponse"/></returns>
        public Task<DescribeCWPScanIpInfoResponse> DescribeCWPScanIpInfo(DescribeCWPScanIpInfoRequest req)
        {
            return InternalRequestAsync<DescribeCWPScanIpInfoResponse>(req, "DescribeCWPScanIpInfo");
        }

        /// <summary>
        /// 查询腾讯云扫描IP信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCWPScanIpInfoRequest"/></param>
        /// <returns><see cref="DescribeCWPScanIpInfoResponse"/></returns>
        public DescribeCWPScanIpInfoResponse DescribeCWPScanIpInfoSync(DescribeCWPScanIpInfoRequest req)
        {
            return InternalRequestAsync<DescribeCWPScanIpInfoResponse>(req, "DescribeCWPScanIpInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取任务下发时长
        /// </summary>
        /// <param name="req"><see cref="DescribeCWPTaskDurationRequest"/></param>
        /// <returns><see cref="DescribeCWPTaskDurationResponse"/></returns>
        public Task<DescribeCWPTaskDurationResponse> DescribeCWPTaskDuration(DescribeCWPTaskDurationRequest req)
        {
            return InternalRequestAsync<DescribeCWPTaskDurationResponse>(req, "DescribeCWPTaskDuration");
        }

        /// <summary>
        /// 获取任务下发时长
        /// </summary>
        /// <param name="req"><see cref="DescribeCWPTaskDurationRequest"/></param>
        /// <returns><see cref="DescribeCWPTaskDurationResponse"/></returns>
        public DescribeCWPTaskDurationResponse DescribeCWPTaskDurationSync(DescribeCWPTaskDurationRequest req)
        {
            return InternalRequestAsync<DescribeCWPTaskDurationResponse>(req, "DescribeCWPTaskDuration")
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
        /// 查询联通性检测主机列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCheckConnectivityHostListRequest"/></param>
        /// <returns><see cref="DescribeCheckConnectivityHostListResponse"/></returns>
        public Task<DescribeCheckConnectivityHostListResponse> DescribeCheckConnectivityHostList(DescribeCheckConnectivityHostListRequest req)
        {
            return InternalRequestAsync<DescribeCheckConnectivityHostListResponse>(req, "DescribeCheckConnectivityHostList");
        }

        /// <summary>
        /// 查询联通性检测主机列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCheckConnectivityHostListRequest"/></param>
        /// <returns><see cref="DescribeCheckConnectivityHostListResponse"/></returns>
        public DescribeCheckConnectivityHostListResponse DescribeCheckConnectivityHostListSync(DescribeCheckConnectivityHostListRequest req)
        {
            return InternalRequestAsync<DescribeCheckConnectivityHostListResponse>(req, "DescribeCheckConnectivityHostList")
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
        /// 查询腾讯云指定CLB实例对应的监听器列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClbListenerListRequest"/></param>
        /// <returns><see cref="DescribeClbListenerListResponse"/></returns>
        public Task<DescribeClbListenerListResponse> DescribeClbListenerList(DescribeClbListenerListRequest req)
        {
            return InternalRequestAsync<DescribeClbListenerListResponse>(req, "DescribeClbListenerList");
        }

        /// <summary>
        /// 查询腾讯云指定CLB实例对应的监听器列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClbListenerListRequest"/></param>
        /// <returns><see cref="DescribeClbListenerListResponse"/></returns>
        public DescribeClbListenerListResponse DescribeClbListenerListSync(DescribeClbListenerListRequest req)
        {
            return InternalRequestAsync<DescribeClbListenerListResponse>(req, "DescribeClbListenerList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询腾讯云指定CLB实例对应的七层转发规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClbListenerRulesRequest"/></param>
        /// <returns><see cref="DescribeClbListenerRulesResponse"/></returns>
        public Task<DescribeClbListenerRulesResponse> DescribeClbListenerRules(DescribeClbListenerRulesRequest req)
        {
            return InternalRequestAsync<DescribeClbListenerRulesResponse>(req, "DescribeClbListenerRules");
        }

        /// <summary>
        /// 查询腾讯云指定CLB实例对应的七层转发规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClbListenerRulesRequest"/></param>
        /// <returns><see cref="DescribeClbListenerRulesResponse"/></returns>
        public DescribeClbListenerRulesResponse DescribeClbListenerRulesSync(DescribeClbListenerRulesRequest req)
        {
            return InternalRequestAsync<DescribeClbListenerRulesResponse>(req, "DescribeClbListenerRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询CLB后端服务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClbTargetsRequest"/></param>
        /// <returns><see cref="DescribeClbTargetsResponse"/></returns>
        public Task<DescribeClbTargetsResponse> DescribeClbTargets(DescribeClbTargetsRequest req)
        {
            return InternalRequestAsync<DescribeClbTargetsResponse>(req, "DescribeClbTargets");
        }

        /// <summary>
        /// 查询CLB后端服务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClbTargetsRequest"/></param>
        /// <returns><see cref="DescribeClbTargetsResponse"/></returns>
        public DescribeClbTargetsResponse DescribeClbTargetsSync(DescribeClbTargetsRequest req)
        {
            return InternalRequestAsync<DescribeClbTargetsResponse>(req, "DescribeClbTargets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 全部资产
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudAssetsRequest"/></param>
        /// <returns><see cref="DescribeCloudAssetsResponse"/></returns>
        public Task<DescribeCloudAssetsResponse> DescribeCloudAssets(DescribeCloudAssetsRequest req)
        {
            return InternalRequestAsync<DescribeCloudAssetsResponse>(req, "DescribeCloudAssets");
        }

        /// <summary>
        /// 全部资产
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudAssetsRequest"/></param>
        /// <returns><see cref="DescribeCloudAssetsResponse"/></returns>
        public DescribeCloudAssetsResponse DescribeCloudAssetsSync(DescribeCloudAssetsRequest req)
        {
            return InternalRequestAsync<DescribeCloudAssetsResponse>(req, "DescribeCloudAssets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云函数列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudFunctionListRequest"/></param>
        /// <returns><see cref="DescribeCloudFunctionListResponse"/></returns>
        public Task<DescribeCloudFunctionListResponse> DescribeCloudFunctionList(DescribeCloudFunctionListRequest req)
        {
            return InternalRequestAsync<DescribeCloudFunctionListResponse>(req, "DescribeCloudFunctionList");
        }

        /// <summary>
        /// 云函数列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCloudFunctionListRequest"/></param>
        /// <returns><see cref="DescribeCloudFunctionListResponse"/></returns>
        public DescribeCloudFunctionListResponse DescribeCloudFunctionListSync(DescribeCloudFunctionListRequest req)
        {
            return InternalRequestAsync<DescribeCloudFunctionListResponse>(req, "DescribeCloudFunctionList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询容器集群资产列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterAssetListRequest"/></param>
        /// <returns><see cref="DescribeClusterAssetListResponse"/></returns>
        public Task<DescribeClusterAssetListResponse> DescribeClusterAssetList(DescribeClusterAssetListRequest req)
        {
            return InternalRequestAsync<DescribeClusterAssetListResponse>(req, "DescribeClusterAssetList");
        }

        /// <summary>
        /// 查询容器集群资产列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterAssetListRequest"/></param>
        /// <returns><see cref="DescribeClusterAssetListResponse"/></returns>
        public DescribeClusterAssetListResponse DescribeClusterAssetListSync(DescribeClusterAssetListRequest req)
        {
            return InternalRequestAsync<DescribeClusterAssetListResponse>(req, "DescribeClusterAssetList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集群资产同步任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterAssetSyncTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeClusterAssetSyncTaskStatusResponse"/></returns>
        public Task<DescribeClusterAssetSyncTaskStatusResponse> DescribeClusterAssetSyncTaskStatus(DescribeClusterAssetSyncTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeClusterAssetSyncTaskStatusResponse>(req, "DescribeClusterAssetSyncTaskStatus");
        }

        /// <summary>
        /// 查询集群资产同步任务状态
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterAssetSyncTaskStatusRequest"/></param>
        /// <returns><see cref="DescribeClusterAssetSyncTaskStatusResponse"/></returns>
        public DescribeClusterAssetSyncTaskStatusResponse DescribeClusterAssetSyncTaskStatusSync(DescribeClusterAssetSyncTaskStatusRequest req)
        {
            return InternalRequestAsync<DescribeClusterAssetSyncTaskStatusResponse>(req, "DescribeClusterAssetSyncTaskStatus")
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
        /// 查询容器关联应用列表。通过容器ID获取关联的应用服务信息，支持分页。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterContainerAppListRequest"/></param>
        /// <returns><see cref="DescribeClusterContainerAppListResponse"/></returns>
        public Task<DescribeClusterContainerAppListResponse> DescribeClusterContainerAppList(DescribeClusterContainerAppListRequest req)
        {
            return InternalRequestAsync<DescribeClusterContainerAppListResponse>(req, "DescribeClusterContainerAppList");
        }

        /// <summary>
        /// 查询容器关联应用列表。通过容器ID获取关联的应用服务信息，支持分页。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterContainerAppListRequest"/></param>
        /// <returns><see cref="DescribeClusterContainerAppListResponse"/></returns>
        public DescribeClusterContainerAppListResponse DescribeClusterContainerAppListSync(DescribeClusterContainerAppListRequest req)
        {
            return InternalRequestAsync<DescribeClusterContainerAppListResponse>(req, "DescribeClusterContainerAppList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询容器关联组件列表。通过容器ID获取关联的组件信息，支持分页。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterContainerComponentListRequest"/></param>
        /// <returns><see cref="DescribeClusterContainerComponentListResponse"/></returns>
        public Task<DescribeClusterContainerComponentListResponse> DescribeClusterContainerComponentList(DescribeClusterContainerComponentListRequest req)
        {
            return InternalRequestAsync<DescribeClusterContainerComponentListResponse>(req, "DescribeClusterContainerComponentList");
        }

        /// <summary>
        /// 查询容器关联组件列表。通过容器ID获取关联的组件信息，支持分页。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterContainerComponentListRequest"/></param>
        /// <returns><see cref="DescribeClusterContainerComponentListResponse"/></returns>
        public DescribeClusterContainerComponentListResponse DescribeClusterContainerComponentListSync(DescribeClusterContainerComponentListRequest req)
        {
            return InternalRequestAsync<DescribeClusterContainerComponentListResponse>(req, "DescribeClusterContainerComponentList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集群容器详情。通过容器ID获取容器基本信息、镜像信息、挂载信息、网络信息以及关联节点信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterContainerDetailRequest"/></param>
        /// <returns><see cref="DescribeClusterContainerDetailResponse"/></returns>
        public Task<DescribeClusterContainerDetailResponse> DescribeClusterContainerDetail(DescribeClusterContainerDetailRequest req)
        {
            return InternalRequestAsync<DescribeClusterContainerDetailResponse>(req, "DescribeClusterContainerDetail");
        }

        /// <summary>
        /// 查询集群容器详情。通过容器ID获取容器基本信息、镜像信息、挂载信息、网络信息以及关联节点信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterContainerDetailRequest"/></param>
        /// <returns><see cref="DescribeClusterContainerDetailResponse"/></returns>
        public DescribeClusterContainerDetailResponse DescribeClusterContainerDetailSync(DescribeClusterContainerDetailRequest req)
        {
            return InternalRequestAsync<DescribeClusterContainerDetailResponse>(req, "DescribeClusterContainerDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集群容器列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterContainerListRequest"/></param>
        /// <returns><see cref="DescribeClusterContainerListResponse"/></returns>
        public Task<DescribeClusterContainerListResponse> DescribeClusterContainerList(DescribeClusterContainerListRequest req)
        {
            return InternalRequestAsync<DescribeClusterContainerListResponse>(req, "DescribeClusterContainerList");
        }

        /// <summary>
        /// 查询集群容器列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterContainerListRequest"/></param>
        /// <returns><see cref="DescribeClusterContainerListResponse"/></returns>
        public DescribeClusterContainerListResponse DescribeClusterContainerListSync(DescribeClusterContainerListRequest req)
        {
            return InternalRequestAsync<DescribeClusterContainerListResponse>(req, "DescribeClusterContainerList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询容器关联端口列表。通过容器ID获取关联的端口信息，支持分页。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterContainerPortListRequest"/></param>
        /// <returns><see cref="DescribeClusterContainerPortListResponse"/></returns>
        public Task<DescribeClusterContainerPortListResponse> DescribeClusterContainerPortList(DescribeClusterContainerPortListRequest req)
        {
            return InternalRequestAsync<DescribeClusterContainerPortListResponse>(req, "DescribeClusterContainerPortList");
        }

        /// <summary>
        /// 查询容器关联端口列表。通过容器ID获取关联的端口信息，支持分页。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterContainerPortListRequest"/></param>
        /// <returns><see cref="DescribeClusterContainerPortListResponse"/></returns>
        public DescribeClusterContainerPortListResponse DescribeClusterContainerPortListSync(DescribeClusterContainerPortListRequest req)
        {
            return InternalRequestAsync<DescribeClusterContainerPortListResponse>(req, "DescribeClusterContainerPortList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询容器关联进程列表。通过容器ID获取关联的进程信息，支持按启动时间排序和分页。Filter.By支持StartTime；Filter.Order支持ASC/DESC。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterContainerProcessListRequest"/></param>
        /// <returns><see cref="DescribeClusterContainerProcessListResponse"/></returns>
        public Task<DescribeClusterContainerProcessListResponse> DescribeClusterContainerProcessList(DescribeClusterContainerProcessListRequest req)
        {
            return InternalRequestAsync<DescribeClusterContainerProcessListResponse>(req, "DescribeClusterContainerProcessList");
        }

        /// <summary>
        /// 查询容器关联进程列表。通过容器ID获取关联的进程信息，支持按启动时间排序和分页。Filter.By支持StartTime；Filter.Order支持ASC/DESC。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterContainerProcessListRequest"/></param>
        /// <returns><see cref="DescribeClusterContainerProcessListResponse"/></returns>
        public DescribeClusterContainerProcessListResponse DescribeClusterContainerProcessListSync(DescribeClusterContainerProcessListRequest req)
        {
            return InternalRequestAsync<DescribeClusterContainerProcessListResponse>(req, "DescribeClusterContainerProcessList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询容器关联Web服务列表。通过容器ID获取关联的Web服务信息，支持分页。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterContainerWebServiceListRequest"/></param>
        /// <returns><see cref="DescribeClusterContainerWebServiceListResponse"/></returns>
        public Task<DescribeClusterContainerWebServiceListResponse> DescribeClusterContainerWebServiceList(DescribeClusterContainerWebServiceListRequest req)
        {
            return InternalRequestAsync<DescribeClusterContainerWebServiceListResponse>(req, "DescribeClusterContainerWebServiceList");
        }

        /// <summary>
        /// 查询容器关联Web服务列表。通过容器ID获取关联的Web服务信息，支持分页。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterContainerWebServiceListRequest"/></param>
        /// <returns><see cref="DescribeClusterContainerWebServiceListResponse"/></returns>
        public DescribeClusterContainerWebServiceListResponse DescribeClusterContainerWebServiceListSync(DescribeClusterContainerWebServiceListRequest req)
        {
            return InternalRequestAsync<DescribeClusterContainerWebServiceListResponse>(req, "DescribeClusterContainerWebServiceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集群详情
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterDetailRequest"/></param>
        /// <returns><see cref="DescribeClusterDetailResponse"/></returns>
        public Task<DescribeClusterDetailResponse> DescribeClusterDetail(DescribeClusterDetailRequest req)
        {
            return InternalRequestAsync<DescribeClusterDetailResponse>(req, "DescribeClusterDetail");
        }

        /// <summary>
        /// 查询集群详情
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterDetailRequest"/></param>
        /// <returns><see cref="DescribeClusterDetailResponse"/></returns>
        public DescribeClusterDetailResponse DescribeClusterDetailSync(DescribeClusterDetailRequest req)
        {
            return InternalRequestAsync<DescribeClusterDetailResponse>(req, "DescribeClusterDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集群安装命令
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterInstallCommandRequest"/></param>
        /// <returns><see cref="DescribeClusterInstallCommandResponse"/></returns>
        public Task<DescribeClusterInstallCommandResponse> DescribeClusterInstallCommand(DescribeClusterInstallCommandRequest req)
        {
            return InternalRequestAsync<DescribeClusterInstallCommandResponse>(req, "DescribeClusterInstallCommand");
        }

        /// <summary>
        /// 查询集群安装命令
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterInstallCommandRequest"/></param>
        /// <returns><see cref="DescribeClusterInstallCommandResponse"/></returns>
        public DescribeClusterInstallCommandResponse DescribeClusterInstallCommandSync(DescribeClusterInstallCommandRequest req)
        {
            return InternalRequestAsync<DescribeClusterInstallCommandResponse>(req, "DescribeClusterInstallCommand")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterListV2Request"/></param>
        /// <returns><see cref="DescribeClusterListV2Response"/></returns>
        public Task<DescribeClusterListV2Response> DescribeClusterListV2(DescribeClusterListV2Request req)
        {
            return InternalRequestAsync<DescribeClusterListV2Response>(req, "DescribeClusterListV2");
        }

        /// <summary>
        /// 查询集群列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterListV2Request"/></param>
        /// <returns><see cref="DescribeClusterListV2Response"/></returns>
        public DescribeClusterListV2Response DescribeClusterListV2Sync(DescribeClusterListV2Request req)
        {
            return InternalRequestAsync<DescribeClusterListV2Response>(req, "DescribeClusterListV2")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集群命名空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterNamespaceListRequest"/></param>
        /// <returns><see cref="DescribeClusterNamespaceListResponse"/></returns>
        public Task<DescribeClusterNamespaceListResponse> DescribeClusterNamespaceList(DescribeClusterNamespaceListRequest req)
        {
            return InternalRequestAsync<DescribeClusterNamespaceListResponse>(req, "DescribeClusterNamespaceList");
        }

        /// <summary>
        /// 查询集群命名空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterNamespaceListRequest"/></param>
        /// <returns><see cref="DescribeClusterNamespaceListResponse"/></returns>
        public DescribeClusterNamespaceListResponse DescribeClusterNamespaceListSync(DescribeClusterNamespaceListRequest req)
        {
            return InternalRequestAsync<DescribeClusterNamespaceListResponse>(req, "DescribeClusterNamespaceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集群节点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterNodeListRequest"/></param>
        /// <returns><see cref="DescribeClusterNodeListResponse"/></returns>
        public Task<DescribeClusterNodeListResponse> DescribeClusterNodeList(DescribeClusterNodeListRequest req)
        {
            return InternalRequestAsync<DescribeClusterNodeListResponse>(req, "DescribeClusterNodeList");
        }

        /// <summary>
        /// 查询集群节点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterNodeListRequest"/></param>
        /// <returns><see cref="DescribeClusterNodeListResponse"/></returns>
        public DescribeClusterNodeListResponse DescribeClusterNodeListSync(DescribeClusterNodeListRequest req)
        {
            return InternalRequestAsync<DescribeClusterNodeListResponse>(req, "DescribeClusterNodeList")
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
        /// 查询集群 Pod 详情。容器资产改版 A 类新接口，为 Pod 资产详情页主入口。入参仅 UniqueID；出参覆盖资产信息、所属集群、命名空间、节点、Workload、以及按四个风险等级分组的风险事件数和告警事件数。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterPodDetailRequest"/></param>
        /// <returns><see cref="DescribeClusterPodDetailResponse"/></returns>
        public Task<DescribeClusterPodDetailResponse> DescribeClusterPodDetail(DescribeClusterPodDetailRequest req)
        {
            return InternalRequestAsync<DescribeClusterPodDetailResponse>(req, "DescribeClusterPodDetail");
        }

        /// <summary>
        /// 查询集群 Pod 详情。容器资产改版 A 类新接口，为 Pod 资产详情页主入口。入参仅 UniqueID；出参覆盖资产信息、所属集群、命名空间、节点、Workload、以及按四个风险等级分组的风险事件数和告警事件数。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterPodDetailRequest"/></param>
        /// <returns><see cref="DescribeClusterPodDetailResponse"/></returns>
        public DescribeClusterPodDetailResponse DescribeClusterPodDetailSync(DescribeClusterPodDetailRequest req)
        {
            return InternalRequestAsync<DescribeClusterPodDetailResponse>(req, "DescribeClusterPodDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集群pod列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterPodListRequest"/></param>
        /// <returns><see cref="DescribeClusterPodListResponse"/></returns>
        public Task<DescribeClusterPodListResponse> DescribeClusterPodList(DescribeClusterPodListRequest req)
        {
            return InternalRequestAsync<DescribeClusterPodListResponse>(req, "DescribeClusterPodList");
        }

        /// <summary>
        /// 查询集群pod列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterPodListRequest"/></param>
        /// <returns><see cref="DescribeClusterPodListResponse"/></returns>
        public DescribeClusterPodListResponse DescribeClusterPodListSync(DescribeClusterPodListRequest req)
        {
            return InternalRequestAsync<DescribeClusterPodListResponse>(req, "DescribeClusterPodList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集群service列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterServiceListRequest"/></param>
        /// <returns><see cref="DescribeClusterServiceListResponse"/></returns>
        public Task<DescribeClusterServiceListResponse> DescribeClusterServiceList(DescribeClusterServiceListRequest req)
        {
            return InternalRequestAsync<DescribeClusterServiceListResponse>(req, "DescribeClusterServiceList");
        }

        /// <summary>
        /// 查询集群service列表
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterServiceListRequest"/></param>
        /// <returns><see cref="DescribeClusterServiceListResponse"/></returns>
        public DescribeClusterServiceListResponse DescribeClusterServiceListSync(DescribeClusterServiceListRequest req)
        {
            return InternalRequestAsync<DescribeClusterServiceListResponse>(req, "DescribeClusterServiceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集群概览数据
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterSummaryRequest"/></param>
        /// <returns><see cref="DescribeClusterSummaryResponse"/></returns>
        public Task<DescribeClusterSummaryResponse> DescribeClusterSummary(DescribeClusterSummaryRequest req)
        {
            return InternalRequestAsync<DescribeClusterSummaryResponse>(req, "DescribeClusterSummary");
        }

        /// <summary>
        /// 查询集群概览数据
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterSummaryRequest"/></param>
        /// <returns><see cref="DescribeClusterSummaryResponse"/></returns>
        public DescribeClusterSummaryResponse DescribeClusterSummarySync(DescribeClusterSummaryRequest req)
        {
            return InternalRequestAsync<DescribeClusterSummaryResponse>(req, "DescribeClusterSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集群超级节点详情，返回基本信息（所属地域/可用区/资产最后更新时间/节点来源/子网/核数）与所属集群信息（集群名称/集群ID/集群状态/Kubernetes版本/Kubelet版本）。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterSuperNodeInfoRequest"/></param>
        /// <returns><see cref="DescribeClusterSuperNodeInfoResponse"/></returns>
        public Task<DescribeClusterSuperNodeInfoResponse> DescribeClusterSuperNodeInfo(DescribeClusterSuperNodeInfoRequest req)
        {
            return InternalRequestAsync<DescribeClusterSuperNodeInfoResponse>(req, "DescribeClusterSuperNodeInfo");
        }

        /// <summary>
        /// 查询集群超级节点详情，返回基本信息（所属地域/可用区/资产最后更新时间/节点来源/子网/核数）与所属集群信息（集群名称/集群ID/集群状态/Kubernetes版本/Kubelet版本）。
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterSuperNodeInfoRequest"/></param>
        /// <returns><see cref="DescribeClusterSuperNodeInfoResponse"/></returns>
        public DescribeClusterSuperNodeInfoResponse DescribeClusterSuperNodeInfoSync(DescribeClusterSuperNodeInfoRequest req)
        {
            return InternalRequestAsync<DescribeClusterSuperNodeInfoResponse>(req, "DescribeClusterSuperNodeInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云资源配置检测合规概览
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceOverviewRequest"/></param>
        /// <returns><see cref="DescribeComplianceOverviewResponse"/></returns>
        public Task<DescribeComplianceOverviewResponse> DescribeComplianceOverview(DescribeComplianceOverviewRequest req)
        {
            return InternalRequestAsync<DescribeComplianceOverviewResponse>(req, "DescribeComplianceOverview");
        }

        /// <summary>
        /// 云资源配置检测合规概览
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceOverviewRequest"/></param>
        /// <returns><see cref="DescribeComplianceOverviewResponse"/></returns>
        public DescribeComplianceOverviewResponse DescribeComplianceOverviewSync(DescribeComplianceOverviewRequest req)
        {
            return InternalRequestAsync<DescribeComplianceOverviewResponse>(req, "DescribeComplianceOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 合规标准聚合视角下云资源配置风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceRiskListRequest"/></param>
        /// <returns><see cref="DescribeComplianceRiskListResponse"/></returns>
        public Task<DescribeComplianceRiskListResponse> DescribeComplianceRiskList(DescribeComplianceRiskListRequest req)
        {
            return InternalRequestAsync<DescribeComplianceRiskListResponse>(req, "DescribeComplianceRiskList");
        }

        /// <summary>
        /// 合规标准聚合视角下云资源配置风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceRiskListRequest"/></param>
        /// <returns><see cref="DescribeComplianceRiskListResponse"/></returns>
        public DescribeComplianceRiskListResponse DescribeComplianceRiskListSync(DescribeComplianceRiskListRequest req)
        {
            return InternalRequestAsync<DescribeComplianceRiskListResponse>(req, "DescribeComplianceRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云资源配置检测标准章节条款树
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceStandardTermTreeRequest"/></param>
        /// <returns><see cref="DescribeComplianceStandardTermTreeResponse"/></returns>
        public Task<DescribeComplianceStandardTermTreeResponse> DescribeComplianceStandardTermTree(DescribeComplianceStandardTermTreeRequest req)
        {
            return InternalRequestAsync<DescribeComplianceStandardTermTreeResponse>(req, "DescribeComplianceStandardTermTree");
        }

        /// <summary>
        /// 云资源配置检测标准章节条款树
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceStandardTermTreeRequest"/></param>
        /// <returns><see cref="DescribeComplianceStandardTermTreeResponse"/></returns>
        public DescribeComplianceStandardTermTreeResponse DescribeComplianceStandardTermTreeSync(DescribeComplianceStandardTermTreeRequest req)
        {
            return InternalRequestAsync<DescribeComplianceStandardTermTreeResponse>(req, "DescribeComplianceStandardTermTree")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云资源配置检测规范分类统计
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceStatisticsRequest"/></param>
        /// <returns><see cref="DescribeComplianceStatisticsResponse"/></returns>
        public Task<DescribeComplianceStatisticsResponse> DescribeComplianceStatistics(DescribeComplianceStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeComplianceStatisticsResponse>(req, "DescribeComplianceStatistics");
        }

        /// <summary>
        /// 云资源配置检测规范分类统计
        /// </summary>
        /// <param name="req"><see cref="DescribeComplianceStatisticsRequest"/></param>
        /// <returns><see cref="DescribeComplianceStatisticsResponse"/></returns>
        public DescribeComplianceStatisticsResponse DescribeComplianceStatisticsSync(DescribeComplianceStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeComplianceStatisticsResponse>(req, "DescribeComplianceStatistics")
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
        /// 获取CSPM自动配额共享配置
        /// </summary>
        /// <param name="req"><see cref="DescribeCspmShardConfigRequest"/></param>
        /// <returns><see cref="DescribeCspmShardConfigResponse"/></returns>
        public Task<DescribeCspmShardConfigResponse> DescribeCspmShardConfig(DescribeCspmShardConfigRequest req)
        {
            return InternalRequestAsync<DescribeCspmShardConfigResponse>(req, "DescribeCspmShardConfig");
        }

        /// <summary>
        /// 获取CSPM自动配额共享配置
        /// </summary>
        /// <param name="req"><see cref="DescribeCspmShardConfigRequest"/></param>
        /// <returns><see cref="DescribeCspmShardConfigResponse"/></returns>
        public DescribeCspmShardConfigResponse DescribeCspmShardConfigSync(DescribeCspmShardConfigRequest req)
        {
            return InternalRequestAsync<DescribeCspmShardConfigResponse>(req, "DescribeCspmShardConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用户自定义 标签数量
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomAssetTagCountRequest"/></param>
        /// <returns><see cref="DescribeCustomAssetTagCountResponse"/></returns>
        public Task<DescribeCustomAssetTagCountResponse> DescribeCustomAssetTagCount(DescribeCustomAssetTagCountRequest req)
        {
            return InternalRequestAsync<DescribeCustomAssetTagCountResponse>(req, "DescribeCustomAssetTagCount");
        }

        /// <summary>
        /// 用户自定义 标签数量
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomAssetTagCountRequest"/></param>
        /// <returns><see cref="DescribeCustomAssetTagCountResponse"/></returns>
        public DescribeCustomAssetTagCountResponse DescribeCustomAssetTagCountSync(DescribeCustomAssetTagCountRequest req)
        {
            return InternalRequestAsync<DescribeCustomAssetTagCountResponse>(req, "DescribeCustomAssetTagCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 自定义风险规则配置详情列表示例
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomRiskRuleDetailRequest"/></param>
        /// <returns><see cref="DescribeCustomRiskRuleDetailResponse"/></returns>
        public Task<DescribeCustomRiskRuleDetailResponse> DescribeCustomRiskRuleDetail(DescribeCustomRiskRuleDetailRequest req)
        {
            return InternalRequestAsync<DescribeCustomRiskRuleDetailResponse>(req, "DescribeCustomRiskRuleDetail");
        }

        /// <summary>
        /// 自定义风险规则配置详情列表示例
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomRiskRuleDetailRequest"/></param>
        /// <returns><see cref="DescribeCustomRiskRuleDetailResponse"/></returns>
        public DescribeCustomRiskRuleDetailResponse DescribeCustomRiskRuleDetailSync(DescribeCustomRiskRuleDetailRequest req)
        {
            return InternalRequestAsync<DescribeCustomRiskRuleDetailResponse>(req, "DescribeCustomRiskRuleDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 自定义风险规则配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomRiskRulesRequest"/></param>
        /// <returns><see cref="DescribeCustomRiskRulesResponse"/></returns>
        public Task<DescribeCustomRiskRulesResponse> DescribeCustomRiskRules(DescribeCustomRiskRulesRequest req)
        {
            return InternalRequestAsync<DescribeCustomRiskRulesResponse>(req, "DescribeCustomRiskRules");
        }

        /// <summary>
        /// 自定义风险规则配置列表
        /// </summary>
        /// <param name="req"><see cref="DescribeCustomRiskRulesRequest"/></param>
        /// <returns><see cref="DescribeCustomRiskRulesResponse"/></returns>
        public DescribeCustomRiskRulesResponse DescribeCustomRiskRulesSync(DescribeCustomRiskRulesRequest req)
        {
            return InternalRequestAsync<DescribeCustomRiskRulesResponse>(req, "DescribeCustomRiskRules")
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
        /// 获取内置默认安全评分规则，用于重置自定义规则
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultSecurityScoreRuleRequest"/></param>
        /// <returns><see cref="DescribeDefaultSecurityScoreRuleResponse"/></returns>
        public Task<DescribeDefaultSecurityScoreRuleResponse> DescribeDefaultSecurityScoreRule(DescribeDefaultSecurityScoreRuleRequest req)
        {
            return InternalRequestAsync<DescribeDefaultSecurityScoreRuleResponse>(req, "DescribeDefaultSecurityScoreRule");
        }

        /// <summary>
        /// 获取内置默认安全评分规则，用于重置自定义规则
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultSecurityScoreRuleRequest"/></param>
        /// <returns><see cref="DescribeDefaultSecurityScoreRuleResponse"/></returns>
        public DescribeDefaultSecurityScoreRuleResponse DescribeDefaultSecurityScoreRuleSync(DescribeDefaultSecurityScoreRuleRequest req)
        {
            return InternalRequestAsync<DescribeDefaultSecurityScoreRuleResponse>(req, "DescribeDefaultSecurityScoreRule")
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
        /// 指定资产类型列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDynamicAssetsRequest"/></param>
        /// <returns><see cref="DescribeDynamicAssetsResponse"/></returns>
        public Task<DescribeDynamicAssetsResponse> DescribeDynamicAssets(DescribeDynamicAssetsRequest req)
        {
            return InternalRequestAsync<DescribeDynamicAssetsResponse>(req, "DescribeDynamicAssets");
        }

        /// <summary>
        /// 指定资产类型列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDynamicAssetsRequest"/></param>
        /// <returns><see cref="DescribeDynamicAssetsResponse"/></returns>
        public DescribeDynamicAssetsResponse DescribeDynamicAssetsSync(DescribeDynamicAssetsRequest req)
        {
            return InternalRequestAsync<DescribeDynamicAssetsResponse>(req, "DescribeDynamicAssets")
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
        /// 查询扫描任务列表。Filter.Filters支持Name：Keyword(模糊OperatorType=9)、ScanType(MANUAL/CYCLE)、TaskType(HOST/CONTAINER)、Status(WAIT/SCANNING/FINISHED/FAILED/CANCELED)、AppId(账号)。
        /// </summary>
        /// <param name="req"><see cref="DescribeEDRScanRecordListRequest"/></param>
        /// <returns><see cref="DescribeEDRScanRecordListResponse"/></returns>
        public Task<DescribeEDRScanRecordListResponse> DescribeEDRScanRecordList(DescribeEDRScanRecordListRequest req)
        {
            return InternalRequestAsync<DescribeEDRScanRecordListResponse>(req, "DescribeEDRScanRecordList");
        }

        /// <summary>
        /// 查询扫描任务列表。Filter.Filters支持Name：Keyword(模糊OperatorType=9)、ScanType(MANUAL/CYCLE)、TaskType(HOST/CONTAINER)、Status(WAIT/SCANNING/FINISHED/FAILED/CANCELED)、AppId(账号)。
        /// </summary>
        /// <param name="req"><see cref="DescribeEDRScanRecordListRequest"/></param>
        /// <returns><see cref="DescribeEDRScanRecordListResponse"/></returns>
        public DescribeEDRScanRecordListResponse DescribeEDRScanRecordListSync(DescribeEDRScanRecordListRequest req)
        {
            return InternalRequestAsync<DescribeEDRScanRecordListResponse>(req, "DescribeEDRScanRecordList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询扫描任务详情。Filter.Filters支持Name：Status（资产扫描状态，OperatorType=7 IN匹配，取值WAIT/SCANNING/FINISHED/FAILED）。
        /// </summary>
        /// <param name="req"><see cref="DescribeEDRScanTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeEDRScanTaskDetailResponse"/></returns>
        public Task<DescribeEDRScanTaskDetailResponse> DescribeEDRScanTaskDetail(DescribeEDRScanTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeEDRScanTaskDetailResponse>(req, "DescribeEDRScanTaskDetail");
        }

        /// <summary>
        /// 查询扫描任务详情。Filter.Filters支持Name：Status（资产扫描状态，OperatorType=7 IN匹配，取值WAIT/SCANNING/FINISHED/FAILED）。
        /// </summary>
        /// <param name="req"><see cref="DescribeEDRScanTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeEDRScanTaskDetailResponse"/></returns>
        public DescribeEDRScanTaskDetailResponse DescribeEDRScanTaskDetailSync(DescribeEDRScanTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeEDRScanTaskDetailResponse>(req, "DescribeEDRScanTaskDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取EDR告警数量统计，供资产模块调用。根据传入的MemberId和InstanceIDs，查询EDR告警表并返回告警记录条数信息。当InstanceIDs为空时返回汇总统计，非空时按InstanceIDs粒度分别返回统计。
        /// </summary>
        /// <param name="req"><see cref="DescribeEdrAlertCountForAssetRequest"/></param>
        /// <returns><see cref="DescribeEdrAlertCountForAssetResponse"/></returns>
        public Task<DescribeEdrAlertCountForAssetResponse> DescribeEdrAlertCountForAsset(DescribeEdrAlertCountForAssetRequest req)
        {
            return InternalRequestAsync<DescribeEdrAlertCountForAssetResponse>(req, "DescribeEdrAlertCountForAsset");
        }

        /// <summary>
        /// 获取EDR告警数量统计，供资产模块调用。根据传入的MemberId和InstanceIDs，查询EDR告警表并返回告警记录条数信息。当InstanceIDs为空时返回汇总统计，非空时按InstanceIDs粒度分别返回统计。
        /// </summary>
        /// <param name="req"><see cref="DescribeEdrAlertCountForAssetRequest"/></param>
        /// <returns><see cref="DescribeEdrAlertCountForAssetResponse"/></returns>
        public DescribeEdrAlertCountForAssetResponse DescribeEdrAlertCountForAssetSync(DescribeEdrAlertCountForAssetRequest req)
        {
            return InternalRequestAsync<DescribeEdrAlertCountForAssetResponse>(req, "DescribeEdrAlertCountForAsset")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 容器场景告警数量统计
        /// </summary>
        /// <param name="req"><see cref="DescribeEdrAlertCountForContainerRequest"/></param>
        /// <returns><see cref="DescribeEdrAlertCountForContainerResponse"/></returns>
        public Task<DescribeEdrAlertCountForContainerResponse> DescribeEdrAlertCountForContainer(DescribeEdrAlertCountForContainerRequest req)
        {
            return InternalRequestAsync<DescribeEdrAlertCountForContainerResponse>(req, "DescribeEdrAlertCountForContainer");
        }

        /// <summary>
        /// 容器场景告警数量统计
        /// </summary>
        /// <param name="req"><see cref="DescribeEdrAlertCountForContainerRequest"/></param>
        /// <returns><see cref="DescribeEdrAlertCountForContainerResponse"/></returns>
        public DescribeEdrAlertCountForContainerResponse DescribeEdrAlertCountForContainerSync(DescribeEdrAlertCountForContainerRequest req)
        {
            return InternalRequestAsync<DescribeEdrAlertCountForContainerResponse>(req, "DescribeEdrAlertCountForContainer")
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
        /// EDR告警多攻击阶段查询
        /// </summary>
        /// <param name="req"><see cref="DescribeEdrAlertMultiAttackStagesRequest"/></param>
        /// <returns><see cref="DescribeEdrAlertMultiAttackStagesResponse"/></returns>
        public Task<DescribeEdrAlertMultiAttackStagesResponse> DescribeEdrAlertMultiAttackStages(DescribeEdrAlertMultiAttackStagesRequest req)
        {
            return InternalRequestAsync<DescribeEdrAlertMultiAttackStagesResponse>(req, "DescribeEdrAlertMultiAttackStages");
        }

        /// <summary>
        /// EDR告警多攻击阶段查询
        /// </summary>
        /// <param name="req"><see cref="DescribeEdrAlertMultiAttackStagesRequest"/></param>
        /// <returns><see cref="DescribeEdrAlertMultiAttackStagesResponse"/></returns>
        public DescribeEdrAlertMultiAttackStagesResponse DescribeEdrAlertMultiAttackStagesSync(DescribeEdrAlertMultiAttackStagesRequest req)
        {
            return InternalRequestAsync<DescribeEdrAlertMultiAttackStagesResponse>(req, "DescribeEdrAlertMultiAttackStages")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取EDR告警统计
        /// </summary>
        /// <param name="req"><see cref="DescribeEdrAlertSummaryRequest"/></param>
        /// <returns><see cref="DescribeEdrAlertSummaryResponse"/></returns>
        public Task<DescribeEdrAlertSummaryResponse> DescribeEdrAlertSummary(DescribeEdrAlertSummaryRequest req)
        {
            return InternalRequestAsync<DescribeEdrAlertSummaryResponse>(req, "DescribeEdrAlertSummary");
        }

        /// <summary>
        /// 获取EDR告警统计
        /// </summary>
        /// <param name="req"><see cref="DescribeEdrAlertSummaryRequest"/></param>
        /// <returns><see cref="DescribeEdrAlertSummaryResponse"/></returns>
        public DescribeEdrAlertSummaryResponse DescribeEdrAlertSummarySync(DescribeEdrAlertSummaryRequest req)
        {
            return InternalRequestAsync<DescribeEdrAlertSummaryResponse>(req, "DescribeEdrAlertSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// EDR告警标签批量查询
        /// </summary>
        /// <param name="req"><see cref="DescribeEdrAlertThreatTagsRequest"/></param>
        /// <returns><see cref="DescribeEdrAlertThreatTagsResponse"/></returns>
        public Task<DescribeEdrAlertThreatTagsResponse> DescribeEdrAlertThreatTags(DescribeEdrAlertThreatTagsRequest req)
        {
            return InternalRequestAsync<DescribeEdrAlertThreatTagsResponse>(req, "DescribeEdrAlertThreatTags");
        }

        /// <summary>
        /// EDR告警标签批量查询
        /// </summary>
        /// <param name="req"><see cref="DescribeEdrAlertThreatTagsRequest"/></param>
        /// <returns><see cref="DescribeEdrAlertThreatTagsResponse"/></returns>
        public DescribeEdrAlertThreatTagsResponse DescribeEdrAlertThreatTagsSync(DescribeEdrAlertThreatTagsRequest req)
        {
            return InternalRequestAsync<DescribeEdrAlertThreatTagsResponse>(req, "DescribeEdrAlertThreatTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询EDR日志采集例外网段配置，添加至例外名单的网段，其TCP日志将不被采集。如果用户未配置过，则返回系统推荐的默认网段
        /// </summary>
        /// <param name="req"><see cref="DescribeEdrExcludeNetworkSegmentsRequest"/></param>
        /// <returns><see cref="DescribeEdrExcludeNetworkSegmentsResponse"/></returns>
        public Task<DescribeEdrExcludeNetworkSegmentsResponse> DescribeEdrExcludeNetworkSegments(DescribeEdrExcludeNetworkSegmentsRequest req)
        {
            return InternalRequestAsync<DescribeEdrExcludeNetworkSegmentsResponse>(req, "DescribeEdrExcludeNetworkSegments");
        }

        /// <summary>
        /// 查询EDR日志采集例外网段配置，添加至例外名单的网段，其TCP日志将不被采集。如果用户未配置过，则返回系统推荐的默认网段
        /// </summary>
        /// <param name="req"><see cref="DescribeEdrExcludeNetworkSegmentsRequest"/></param>
        /// <returns><see cref="DescribeEdrExcludeNetworkSegmentsResponse"/></returns>
        public DescribeEdrExcludeNetworkSegmentsResponse DescribeEdrExcludeNetworkSegmentsSync(DescribeEdrExcludeNetworkSegmentsRequest req)
        {
            return InternalRequestAsync<DescribeEdrExcludeNetworkSegmentsResponse>(req, "DescribeEdrExcludeNetworkSegments")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取EDR导出下载链接
        /// </summary>
        /// <param name="req"><see cref="DescribeEdrExportJobDownloadURLRequest"/></param>
        /// <returns><see cref="DescribeEdrExportJobDownloadURLResponse"/></returns>
        public Task<DescribeEdrExportJobDownloadURLResponse> DescribeEdrExportJobDownloadURL(DescribeEdrExportJobDownloadURLRequest req)
        {
            return InternalRequestAsync<DescribeEdrExportJobDownloadURLResponse>(req, "DescribeEdrExportJobDownloadURL");
        }

        /// <summary>
        /// 获取EDR导出下载链接
        /// </summary>
        /// <param name="req"><see cref="DescribeEdrExportJobDownloadURLRequest"/></param>
        /// <returns><see cref="DescribeEdrExportJobDownloadURLResponse"/></returns>
        public DescribeEdrExportJobDownloadURLResponse DescribeEdrExportJobDownloadURLSync(DescribeEdrExportJobDownloadURLRequest req)
        {
            return InternalRequestAsync<DescribeEdrExportJobDownloadURLResponse>(req, "DescribeEdrExportJobDownloadURL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 导出EDR任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdrExportJobListRequest"/></param>
        /// <returns><see cref="DescribeEdrExportJobListResponse"/></returns>
        public Task<DescribeEdrExportJobListResponse> DescribeEdrExportJobList(DescribeEdrExportJobListRequest req)
        {
            return InternalRequestAsync<DescribeEdrExportJobListResponse>(req, "DescribeEdrExportJobList");
        }

        /// <summary>
        /// 导出EDR任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdrExportJobListRequest"/></param>
        /// <returns><see cref="DescribeEdrExportJobListResponse"/></returns>
        public DescribeEdrExportJobListResponse DescribeEdrExportJobListSync(DescribeEdrExportJobListRequest req)
        {
            return InternalRequestAsync<DescribeEdrExportJobListResponse>(req, "DescribeEdrExportJobList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询采集路径配置
        /// </summary>
        /// <param name="req"><see cref="DescribeEdrLogCollectPathsRequest"/></param>
        /// <returns><see cref="DescribeEdrLogCollectPathsResponse"/></returns>
        public Task<DescribeEdrLogCollectPathsResponse> DescribeEdrLogCollectPaths(DescribeEdrLogCollectPathsRequest req)
        {
            return InternalRequestAsync<DescribeEdrLogCollectPathsResponse>(req, "DescribeEdrLogCollectPaths");
        }

        /// <summary>
        /// 查询采集路径配置
        /// </summary>
        /// <param name="req"><see cref="DescribeEdrLogCollectPathsRequest"/></param>
        /// <returns><see cref="DescribeEdrLogCollectPathsResponse"/></returns>
        public DescribeEdrLogCollectPathsResponse DescribeEdrLogCollectPathsSync(DescribeEdrLogCollectPathsRequest req)
        {
            return InternalRequestAsync<DescribeEdrLogCollectPathsResponse>(req, "DescribeEdrLogCollectPaths")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 导出任务结果下载URL
        /// </summary>
        /// <param name="req"><see cref="DescribeExportJobDownloadURLRequest"/></param>
        /// <returns><see cref="DescribeExportJobDownloadURLResponse"/></returns>
        public Task<DescribeExportJobDownloadURLResponse> DescribeExportJobDownloadURL(DescribeExportJobDownloadURLRequest req)
        {
            return InternalRequestAsync<DescribeExportJobDownloadURLResponse>(req, "DescribeExportJobDownloadURL");
        }

        /// <summary>
        /// 导出任务结果下载URL
        /// </summary>
        /// <param name="req"><see cref="DescribeExportJobDownloadURLRequest"/></param>
        /// <returns><see cref="DescribeExportJobDownloadURLResponse"/></returns>
        public DescribeExportJobDownloadURLResponse DescribeExportJobDownloadURLSync(DescribeExportJobDownloadURLRequest req)
        {
            return InternalRequestAsync<DescribeExportJobDownloadURLResponse>(req, "DescribeExportJobDownloadURL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 导出任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeExportJobManageListRequest"/></param>
        /// <returns><see cref="DescribeExportJobManageListResponse"/></returns>
        public Task<DescribeExportJobManageListResponse> DescribeExportJobManageList(DescribeExportJobManageListRequest req)
        {
            return InternalRequestAsync<DescribeExportJobManageListResponse>(req, "DescribeExportJobManageList");
        }

        /// <summary>
        /// 导出任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeExportJobManageListRequest"/></param>
        /// <returns><see cref="DescribeExportJobManageListResponse"/></returns>
        public DescribeExportJobManageListResponse DescribeExportJobManageListSync(DescribeExportJobManageListRequest req)
        {
            return InternalRequestAsync<DescribeExportJobManageListResponse>(req, "DescribeExportJobManageList")
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
        /// 云边界风险待治理风险
        /// </summary>
        /// <param name="req"><see cref="DescribeExposeRiskStatisticsRequest"/></param>
        /// <returns><see cref="DescribeExposeRiskStatisticsResponse"/></returns>
        public Task<DescribeExposeRiskStatisticsResponse> DescribeExposeRiskStatistics(DescribeExposeRiskStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeExposeRiskStatisticsResponse>(req, "DescribeExposeRiskStatistics");
        }

        /// <summary>
        /// 云边界风险待治理风险
        /// </summary>
        /// <param name="req"><see cref="DescribeExposeRiskStatisticsRequest"/></param>
        /// <returns><see cref="DescribeExposeRiskStatisticsResponse"/></returns>
        public DescribeExposeRiskStatisticsResponse DescribeExposeRiskStatisticsSync(DescribeExposeRiskStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeExposeRiskStatisticsResponse>(req, "DescribeExposeRiskStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云边界待处理风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeExposeRisksRequest"/></param>
        /// <returns><see cref="DescribeExposeRisksResponse"/></returns>
        public Task<DescribeExposeRisksResponse> DescribeExposeRisks(DescribeExposeRisksRequest req)
        {
            return InternalRequestAsync<DescribeExposeRisksResponse>(req, "DescribeExposeRisks");
        }

        /// <summary>
        /// 云边界待处理风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeExposeRisksRequest"/></param>
        /// <returns><see cref="DescribeExposeRisksResponse"/></returns>
        public DescribeExposeRisksResponse DescribeExposeRisksSync(DescribeExposeRisksRequest req)
        {
            return InternalRequestAsync<DescribeExposeRisksResponse>(req, "DescribeExposeRisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 边界规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeExposeRulesRequest"/></param>
        /// <returns><see cref="DescribeExposeRulesResponse"/></returns>
        public Task<DescribeExposeRulesResponse> DescribeExposeRules(DescribeExposeRulesRequest req)
        {
            return InternalRequestAsync<DescribeExposeRulesResponse>(req, "DescribeExposeRules");
        }

        /// <summary>
        /// 边界规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeExposeRulesRequest"/></param>
        /// <returns><see cref="DescribeExposeRulesResponse"/></returns>
        public DescribeExposeRulesResponse DescribeExposeRulesSync(DescribeExposeRulesRequest req)
        {
            return InternalRequestAsync<DescribeExposeRulesResponse>(req, "DescribeExposeRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云边界自动打标-规则属性
        /// </summary>
        /// <param name="req"><see cref="DescribeExposureAutoTagAttributeRequest"/></param>
        /// <returns><see cref="DescribeExposureAutoTagAttributeResponse"/></returns>
        public Task<DescribeExposureAutoTagAttributeResponse> DescribeExposureAutoTagAttribute(DescribeExposureAutoTagAttributeRequest req)
        {
            return InternalRequestAsync<DescribeExposureAutoTagAttributeResponse>(req, "DescribeExposureAutoTagAttribute");
        }

        /// <summary>
        /// 云边界自动打标-规则属性
        /// </summary>
        /// <param name="req"><see cref="DescribeExposureAutoTagAttributeRequest"/></param>
        /// <returns><see cref="DescribeExposureAutoTagAttributeResponse"/></returns>
        public DescribeExposureAutoTagAttributeResponse DescribeExposureAutoTagAttributeSync(DescribeExposureAutoTagAttributeRequest req)
        {
            return InternalRequestAsync<DescribeExposureAutoTagAttributeResponse>(req, "DescribeExposureAutoTagAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云边界自动打标-规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeExposureAutoTagRulesRequest"/></param>
        /// <returns><see cref="DescribeExposureAutoTagRulesResponse"/></returns>
        public Task<DescribeExposureAutoTagRulesResponse> DescribeExposureAutoTagRules(DescribeExposureAutoTagRulesRequest req)
        {
            return InternalRequestAsync<DescribeExposureAutoTagRulesResponse>(req, "DescribeExposureAutoTagRules");
        }

        /// <summary>
        /// 云边界自动打标-规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeExposureAutoTagRulesRequest"/></param>
        /// <returns><see cref="DescribeExposureAutoTagRulesResponse"/></returns>
        public DescribeExposureAutoTagRulesResponse DescribeExposureAutoTagRulesSync(DescribeExposureAutoTagRulesRequest req)
        {
            return InternalRequestAsync<DescribeExposureAutoTagRulesResponse>(req, "DescribeExposureAutoTagRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询互联网暴露周期数量趋势统计信息
        /// </summary>
        /// <param name="req"><see cref="DescribeExposureTrendRequest"/></param>
        /// <returns><see cref="DescribeExposureTrendResponse"/></returns>
        public Task<DescribeExposureTrendResponse> DescribeExposureTrend(DescribeExposureTrendRequest req)
        {
            return InternalRequestAsync<DescribeExposureTrendResponse>(req, "DescribeExposureTrend");
        }

        /// <summary>
        /// 查询互联网暴露周期数量趋势统计信息
        /// </summary>
        /// <param name="req"><see cref="DescribeExposureTrendRequest"/></param>
        /// <returns><see cref="DescribeExposureTrendResponse"/></returns>
        public DescribeExposureTrendResponse DescribeExposureTrendSync(DescribeExposureTrendRequest req)
        {
            return InternalRequestAsync<DescribeExposureTrendResponse>(req, "DescribeExposureTrend")
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
        /// 获取主机kb风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHostKBRiskListRequest"/></param>
        /// <returns><see cref="DescribeHostKBRiskListResponse"/></returns>
        public Task<DescribeHostKBRiskListResponse> DescribeHostKBRiskList(DescribeHostKBRiskListRequest req)
        {
            return InternalRequestAsync<DescribeHostKBRiskListResponse>(req, "DescribeHostKBRiskList");
        }

        /// <summary>
        /// 获取主机kb风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHostKBRiskListRequest"/></param>
        /// <returns><see cref="DescribeHostKBRiskListResponse"/></returns>
        public DescribeHostKBRiskListResponse DescribeHostKBRiskListSync(DescribeHostKBRiskListRequest req)
        {
            return InternalRequestAsync<DescribeHostKBRiskListResponse>(req, "DescribeHostKBRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取主机漏洞VPR信息
        /// </summary>
        /// <param name="req"><see cref="DescribeHostVulItemVPRInfoRequest"/></param>
        /// <returns><see cref="DescribeHostVulItemVPRInfoResponse"/></returns>
        public Task<DescribeHostVulItemVPRInfoResponse> DescribeHostVulItemVPRInfo(DescribeHostVulItemVPRInfoRequest req)
        {
            return InternalRequestAsync<DescribeHostVulItemVPRInfoResponse>(req, "DescribeHostVulItemVPRInfo");
        }

        /// <summary>
        /// 获取主机漏洞VPR信息
        /// </summary>
        /// <param name="req"><see cref="DescribeHostVulItemVPRInfoRequest"/></param>
        /// <returns><see cref="DescribeHostVulItemVPRInfoResponse"/></returns>
        public DescribeHostVulItemVPRInfoResponse DescribeHostVulItemVPRInfoSync(DescribeHostVulItemVPRInfoRequest req)
        {
            return InternalRequestAsync<DescribeHostVulItemVPRInfoResponse>(req, "DescribeHostVulItemVPRInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取主机漏洞概览
        /// </summary>
        /// <param name="req"><see cref="DescribeHostVulOverviewRequest"/></param>
        /// <returns><see cref="DescribeHostVulOverviewResponse"/></returns>
        public Task<DescribeHostVulOverviewResponse> DescribeHostVulOverview(DescribeHostVulOverviewRequest req)
        {
            return InternalRequestAsync<DescribeHostVulOverviewResponse>(req, "DescribeHostVulOverview");
        }

        /// <summary>
        /// 获取主机漏洞概览
        /// </summary>
        /// <param name="req"><see cref="DescribeHostVulOverviewRequest"/></param>
        /// <returns><see cref="DescribeHostVulOverviewResponse"/></returns>
        public DescribeHostVulOverviewResponse DescribeHostVulOverviewSync(DescribeHostVulOverviewRequest req)
        {
            return InternalRequestAsync<DescribeHostVulOverviewResponse>(req, "DescribeHostVulOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取主机漏洞风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHostVulRiskListRequest"/></param>
        /// <returns><see cref="DescribeHostVulRiskListResponse"/></returns>
        public Task<DescribeHostVulRiskListResponse> DescribeHostVulRiskList(DescribeHostVulRiskListRequest req)
        {
            return InternalRequestAsync<DescribeHostVulRiskListResponse>(req, "DescribeHostVulRiskList");
        }

        /// <summary>
        /// 获取主机漏洞风险列表
        /// </summary>
        /// <param name="req"><see cref="DescribeHostVulRiskListRequest"/></param>
        /// <returns><see cref="DescribeHostVulRiskListResponse"/></returns>
        public DescribeHostVulRiskListResponse DescribeHostVulRiskListSync(DescribeHostVulRiskListRequest req)
        {
            return InternalRequestAsync<DescribeHostVulRiskListResponse>(req, "DescribeHostVulRiskList")
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
        /// 查询镜像资产详情
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAssetDetailRequest"/></param>
        /// <returns><see cref="DescribeImageAssetDetailResponse"/></returns>
        public Task<DescribeImageAssetDetailResponse> DescribeImageAssetDetail(DescribeImageAssetDetailRequest req)
        {
            return InternalRequestAsync<DescribeImageAssetDetailResponse>(req, "DescribeImageAssetDetail");
        }

        /// <summary>
        /// 查询镜像资产详情
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAssetDetailRequest"/></param>
        /// <returns><see cref="DescribeImageAssetDetailResponse"/></returns>
        public DescribeImageAssetDetailResponse DescribeImageAssetDetailSync(DescribeImageAssetDetailRequest req)
        {
            return InternalRequestAsync<DescribeImageAssetDetailResponse>(req, "DescribeImageAssetDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询镜像资产列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAssetListRequest"/></param>
        /// <returns><see cref="DescribeImageAssetListResponse"/></returns>
        public Task<DescribeImageAssetListResponse> DescribeImageAssetList(DescribeImageAssetListRequest req)
        {
            return InternalRequestAsync<DescribeImageAssetListResponse>(req, "DescribeImageAssetList");
        }

        /// <summary>
        /// 查询镜像资产列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAssetListRequest"/></param>
        /// <returns><see cref="DescribeImageAssetListResponse"/></returns>
        public DescribeImageAssetListResponse DescribeImageAssetListSync(DescribeImageAssetListRequest req)
        {
            return InternalRequestAsync<DescribeImageAssetListResponse>(req, "DescribeImageAssetList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询镜像关联资产数
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAssociatedAssetCountRequest"/></param>
        /// <returns><see cref="DescribeImageAssociatedAssetCountResponse"/></returns>
        public Task<DescribeImageAssociatedAssetCountResponse> DescribeImageAssociatedAssetCount(DescribeImageAssociatedAssetCountRequest req)
        {
            return InternalRequestAsync<DescribeImageAssociatedAssetCountResponse>(req, "DescribeImageAssociatedAssetCount");
        }

        /// <summary>
        /// 查询镜像关联资产数
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAssociatedAssetCountRequest"/></param>
        /// <returns><see cref="DescribeImageAssociatedAssetCountResponse"/></returns>
        public DescribeImageAssociatedAssetCountResponse DescribeImageAssociatedAssetCountSync(DescribeImageAssociatedAssetCountRequest req)
        {
            return InternalRequestAsync<DescribeImageAssociatedAssetCountResponse>(req, "DescribeImageAssociatedAssetCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询镜像关联容器资产
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAssociatedContainerListRequest"/></param>
        /// <returns><see cref="DescribeImageAssociatedContainerListResponse"/></returns>
        public Task<DescribeImageAssociatedContainerListResponse> DescribeImageAssociatedContainerList(DescribeImageAssociatedContainerListRequest req)
        {
            return InternalRequestAsync<DescribeImageAssociatedContainerListResponse>(req, "DescribeImageAssociatedContainerList");
        }

        /// <summary>
        /// 查询镜像关联容器资产
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAssociatedContainerListRequest"/></param>
        /// <returns><see cref="DescribeImageAssociatedContainerListResponse"/></returns>
        public DescribeImageAssociatedContainerListResponse DescribeImageAssociatedContainerListSync(DescribeImageAssociatedContainerListRequest req)
        {
            return InternalRequestAsync<DescribeImageAssociatedContainerListResponse>(req, "DescribeImageAssociatedContainerList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询镜像关联主机资产列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAssociatedHostListRequest"/></param>
        /// <returns><see cref="DescribeImageAssociatedHostListResponse"/></returns>
        public Task<DescribeImageAssociatedHostListResponse> DescribeImageAssociatedHostList(DescribeImageAssociatedHostListRequest req)
        {
            return InternalRequestAsync<DescribeImageAssociatedHostListResponse>(req, "DescribeImageAssociatedHostList");
        }

        /// <summary>
        /// 查询镜像关联主机资产列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageAssociatedHostListRequest"/></param>
        /// <returns><see cref="DescribeImageAssociatedHostListResponse"/></returns>
        public DescribeImageAssociatedHostListResponse DescribeImageAssociatedHostListSync(DescribeImageAssociatedHostListRequest req)
        {
            return InternalRequestAsync<DescribeImageAssociatedHostListResponse>(req, "DescribeImageAssociatedHostList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询镜像组件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageComponentListRequest"/></param>
        /// <returns><see cref="DescribeImageComponentListResponse"/></returns>
        public Task<DescribeImageComponentListResponse> DescribeImageComponentList(DescribeImageComponentListRequest req)
        {
            return InternalRequestAsync<DescribeImageComponentListResponse>(req, "DescribeImageComponentList");
        }

        /// <summary>
        /// 查询镜像组件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageComponentListRequest"/></param>
        /// <returns><see cref="DescribeImageComponentListResponse"/></returns>
        public DescribeImageComponentListResponse DescribeImageComponentListSync(DescribeImageComponentListRequest req)
        {
            return InternalRequestAsync<DescribeImageComponentListResponse>(req, "DescribeImageComponentList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询镜像仓库导出任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageExportJobListRequest"/></param>
        /// <returns><see cref="DescribeImageExportJobListResponse"/></returns>
        public Task<DescribeImageExportJobListResponse> DescribeImageExportJobList(DescribeImageExportJobListRequest req)
        {
            return InternalRequestAsync<DescribeImageExportJobListResponse>(req, "DescribeImageExportJobList");
        }

        /// <summary>
        /// 查询镜像仓库导出任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageExportJobListRequest"/></param>
        /// <returns><see cref="DescribeImageExportJobListResponse"/></returns>
        public DescribeImageExportJobListResponse DescribeImageExportJobListSync(DescribeImageExportJobListRequest req)
        {
            return InternalRequestAsync<DescribeImageExportJobListResponse>(req, "DescribeImageExportJobList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询镜像层信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageLayerListRequest"/></param>
        /// <returns><see cref="DescribeImageLayerListResponse"/></returns>
        public Task<DescribeImageLayerListResponse> DescribeImageLayerList(DescribeImageLayerListRequest req)
        {
            return InternalRequestAsync<DescribeImageLayerListResponse>(req, "DescribeImageLayerList");
        }

        /// <summary>
        /// 查询镜像层信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageLayerListRequest"/></param>
        /// <returns><see cref="DescribeImageLayerListResponse"/></returns>
        public DescribeImageLayerListResponse DescribeImageLayerListSync(DescribeImageLayerListRequest req)
        {
            return InternalRequestAsync<DescribeImageLayerListResponse>(req, "DescribeImageLayerList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询镜像层漏洞列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageLayerVulListRequest"/></param>
        /// <returns><see cref="DescribeImageLayerVulListResponse"/></returns>
        public Task<DescribeImageLayerVulListResponse> DescribeImageLayerVulList(DescribeImageLayerVulListRequest req)
        {
            return InternalRequestAsync<DescribeImageLayerVulListResponse>(req, "DescribeImageLayerVulList");
        }

        /// <summary>
        /// 查询镜像层漏洞列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageLayerVulListRequest"/></param>
        /// <returns><see cref="DescribeImageLayerVulListResponse"/></returns>
        public DescribeImageLayerVulListResponse DescribeImageLayerVulListSync(DescribeImageLayerVulListRequest req)
        {
            return InternalRequestAsync<DescribeImageLayerVulListResponse>(req, "DescribeImageLayerVulList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询镜像仓库资产总览
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRegistryAssetOverviewRequest"/></param>
        /// <returns><see cref="DescribeImageRegistryAssetOverviewResponse"/></returns>
        public Task<DescribeImageRegistryAssetOverviewResponse> DescribeImageRegistryAssetOverview(DescribeImageRegistryAssetOverviewRequest req)
        {
            return InternalRequestAsync<DescribeImageRegistryAssetOverviewResponse>(req, "DescribeImageRegistryAssetOverview");
        }

        /// <summary>
        /// 查询镜像仓库资产总览
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRegistryAssetOverviewRequest"/></param>
        /// <returns><see cref="DescribeImageRegistryAssetOverviewResponse"/></returns>
        public DescribeImageRegistryAssetOverviewResponse DescribeImageRegistryAssetOverviewSync(DescribeImageRegistryAssetOverviewRequest req)
        {
            return InternalRequestAsync<DescribeImageRegistryAssetOverviewResponse>(req, "DescribeImageRegistryAssetOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询镜像仓库联通性检查任务结果
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRegistryConnectivityTaskResultRequest"/></param>
        /// <returns><see cref="DescribeImageRegistryConnectivityTaskResultResponse"/></returns>
        public Task<DescribeImageRegistryConnectivityTaskResultResponse> DescribeImageRegistryConnectivityTaskResult(DescribeImageRegistryConnectivityTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeImageRegistryConnectivityTaskResultResponse>(req, "DescribeImageRegistryConnectivityTaskResult");
        }

        /// <summary>
        /// 查询镜像仓库联通性检查任务结果
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRegistryConnectivityTaskResultRequest"/></param>
        /// <returns><see cref="DescribeImageRegistryConnectivityTaskResultResponse"/></returns>
        public DescribeImageRegistryConnectivityTaskResultResponse DescribeImageRegistryConnectivityTaskResultSync(DescribeImageRegistryConnectivityTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeImageRegistryConnectivityTaskResultResponse>(req, "DescribeImageRegistryConnectivityTaskResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询镜像仓库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRegistryListRequest"/></param>
        /// <returns><see cref="DescribeImageRegistryListResponse"/></returns>
        public Task<DescribeImageRegistryListResponse> DescribeImageRegistryList(DescribeImageRegistryListRequest req)
        {
            return InternalRequestAsync<DescribeImageRegistryListResponse>(req, "DescribeImageRegistryList");
        }

        /// <summary>
        /// 查询镜像仓库列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRegistryListRequest"/></param>
        /// <returns><see cref="DescribeImageRegistryListResponse"/></returns>
        public DescribeImageRegistryListResponse DescribeImageRegistryListSync(DescribeImageRegistryListRequest req)
        {
            return InternalRequestAsync<DescribeImageRegistryListResponse>(req, "DescribeImageRegistryList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询镜像仓库命名空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRegistryNamespaceListRequest"/></param>
        /// <returns><see cref="DescribeImageRegistryNamespaceListResponse"/></returns>
        public Task<DescribeImageRegistryNamespaceListResponse> DescribeImageRegistryNamespaceList(DescribeImageRegistryNamespaceListRequest req)
        {
            return InternalRequestAsync<DescribeImageRegistryNamespaceListResponse>(req, "DescribeImageRegistryNamespaceList");
        }

        /// <summary>
        /// 查询镜像仓库命名空间列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRegistryNamespaceListRequest"/></param>
        /// <returns><see cref="DescribeImageRegistryNamespaceListResponse"/></returns>
        public DescribeImageRegistryNamespaceListResponse DescribeImageRegistryNamespaceListSync(DescribeImageRegistryNamespaceListRequest req)
        {
            return InternalRequestAsync<DescribeImageRegistryNamespaceListResponse>(req, "DescribeImageRegistryNamespaceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询镜像仓库扫描子任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRegistryScanSubTaskListRequest"/></param>
        /// <returns><see cref="DescribeImageRegistryScanSubTaskListResponse"/></returns>
        public Task<DescribeImageRegistryScanSubTaskListResponse> DescribeImageRegistryScanSubTaskList(DescribeImageRegistryScanSubTaskListRequest req)
        {
            return InternalRequestAsync<DescribeImageRegistryScanSubTaskListResponse>(req, "DescribeImageRegistryScanSubTaskList");
        }

        /// <summary>
        /// 查询镜像仓库扫描子任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRegistryScanSubTaskListRequest"/></param>
        /// <returns><see cref="DescribeImageRegistryScanSubTaskListResponse"/></returns>
        public DescribeImageRegistryScanSubTaskListResponse DescribeImageRegistryScanSubTaskListSync(DescribeImageRegistryScanSubTaskListRequest req)
        {
            return InternalRequestAsync<DescribeImageRegistryScanSubTaskListResponse>(req, "DescribeImageRegistryScanSubTaskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询镜像仓库镜像扫描任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRegistryScanTaskListRequest"/></param>
        /// <returns><see cref="DescribeImageRegistryScanTaskListResponse"/></returns>
        public Task<DescribeImageRegistryScanTaskListResponse> DescribeImageRegistryScanTaskList(DescribeImageRegistryScanTaskListRequest req)
        {
            return InternalRequestAsync<DescribeImageRegistryScanTaskListResponse>(req, "DescribeImageRegistryScanTaskList");
        }

        /// <summary>
        /// 查询镜像仓库镜像扫描任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRegistryScanTaskListRequest"/></param>
        /// <returns><see cref="DescribeImageRegistryScanTaskListResponse"/></returns>
        public DescribeImageRegistryScanTaskListResponse DescribeImageRegistryScanTaskListSync(DescribeImageRegistryScanTaskListRequest req)
        {
            return InternalRequestAsync<DescribeImageRegistryScanTaskListResponse>(req, "DescribeImageRegistryScanTaskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看镜像仓库定时扫描任务配置
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRegistryTimedScanTaskConfigRequest"/></param>
        /// <returns><see cref="DescribeImageRegistryTimedScanTaskConfigResponse"/></returns>
        public Task<DescribeImageRegistryTimedScanTaskConfigResponse> DescribeImageRegistryTimedScanTaskConfig(DescribeImageRegistryTimedScanTaskConfigRequest req)
        {
            return InternalRequestAsync<DescribeImageRegistryTimedScanTaskConfigResponse>(req, "DescribeImageRegistryTimedScanTaskConfig");
        }

        /// <summary>
        /// 查看镜像仓库定时扫描任务配置
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRegistryTimedScanTaskConfigRequest"/></param>
        /// <returns><see cref="DescribeImageRegistryTimedScanTaskConfigResponse"/></returns>
        public DescribeImageRegistryTimedScanTaskConfigResponse DescribeImageRegistryTimedScanTaskConfigSync(DescribeImageRegistryTimedScanTaskConfigRequest req)
        {
            return InternalRequestAsync<DescribeImageRegistryTimedScanTaskConfigResponse>(req, "DescribeImageRegistryTimedScanTaskConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询镜像仓库定时扫描任务预览
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRegistryTimedScanTaskPreviewRequest"/></param>
        /// <returns><see cref="DescribeImageRegistryTimedScanTaskPreviewResponse"/></returns>
        public Task<DescribeImageRegistryTimedScanTaskPreviewResponse> DescribeImageRegistryTimedScanTaskPreview(DescribeImageRegistryTimedScanTaskPreviewRequest req)
        {
            return InternalRequestAsync<DescribeImageRegistryTimedScanTaskPreviewResponse>(req, "DescribeImageRegistryTimedScanTaskPreview");
        }

        /// <summary>
        /// 查询镜像仓库定时扫描任务预览
        /// </summary>
        /// <param name="req"><see cref="DescribeImageRegistryTimedScanTaskPreviewRequest"/></param>
        /// <returns><see cref="DescribeImageRegistryTimedScanTaskPreviewResponse"/></returns>
        public DescribeImageRegistryTimedScanTaskPreviewResponse DescribeImageRegistryTimedScanTaskPreviewSync(DescribeImageRegistryTimedScanTaskPreviewRequest req)
        {
            return InternalRequestAsync<DescribeImageRegistryTimedScanTaskPreviewResponse>(req, "DescribeImageRegistryTimedScanTaskPreview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询镜像敏感信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageSensitiveInfoListRequest"/></param>
        /// <returns><see cref="DescribeImageSensitiveInfoListResponse"/></returns>
        public Task<DescribeImageSensitiveInfoListResponse> DescribeImageSensitiveInfoList(DescribeImageSensitiveInfoListRequest req)
        {
            return InternalRequestAsync<DescribeImageSensitiveInfoListResponse>(req, "DescribeImageSensitiveInfoList");
        }

        /// <summary>
        /// 查询镜像敏感信息列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageSensitiveInfoListRequest"/></param>
        /// <returns><see cref="DescribeImageSensitiveInfoListResponse"/></returns>
        public DescribeImageSensitiveInfoListResponse DescribeImageSensitiveInfoListSync(DescribeImageSensitiveInfoListRequest req)
        {
            return InternalRequestAsync<DescribeImageSensitiveInfoListResponse>(req, "DescribeImageSensitiveInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询容器镜像敏感信息白名单
        /// </summary>
        /// <param name="req"><see cref="DescribeImageSensitiveWhitelistRequest"/></param>
        /// <returns><see cref="DescribeImageSensitiveWhitelistResponse"/></returns>
        public Task<DescribeImageSensitiveWhitelistResponse> DescribeImageSensitiveWhitelist(DescribeImageSensitiveWhitelistRequest req)
        {
            return InternalRequestAsync<DescribeImageSensitiveWhitelistResponse>(req, "DescribeImageSensitiveWhitelist");
        }

        /// <summary>
        /// 查询容器镜像敏感信息白名单
        /// </summary>
        /// <param name="req"><see cref="DescribeImageSensitiveWhitelistRequest"/></param>
        /// <returns><see cref="DescribeImageSensitiveWhitelistResponse"/></returns>
        public DescribeImageSensitiveWhitelistResponse DescribeImageSensitiveWhitelistSync(DescribeImageSensitiveWhitelistRequest req)
        {
            return InternalRequestAsync<DescribeImageSensitiveWhitelistResponse>(req, "DescribeImageSensitiveWhitelist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询镜像木马病毒列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageVirusListRequest"/></param>
        /// <returns><see cref="DescribeImageVirusListResponse"/></returns>
        public Task<DescribeImageVirusListResponse> DescribeImageVirusList(DescribeImageVirusListRequest req)
        {
            return InternalRequestAsync<DescribeImageVirusListResponse>(req, "DescribeImageVirusList");
        }

        /// <summary>
        /// 查询镜像木马病毒列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageVirusListRequest"/></param>
        /// <returns><see cref="DescribeImageVirusListResponse"/></returns>
        public DescribeImageVirusListResponse DescribeImageVirusListSync(DescribeImageVirusListRequest req)
        {
            return InternalRequestAsync<DescribeImageVirusListResponse>(req, "DescribeImageVirusList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询镜像木马白名单
        /// </summary>
        /// <param name="req"><see cref="DescribeImageVirusWhitelistRequest"/></param>
        /// <returns><see cref="DescribeImageVirusWhitelistResponse"/></returns>
        public Task<DescribeImageVirusWhitelistResponse> DescribeImageVirusWhitelist(DescribeImageVirusWhitelistRequest req)
        {
            return InternalRequestAsync<DescribeImageVirusWhitelistResponse>(req, "DescribeImageVirusWhitelist");
        }

        /// <summary>
        /// 查询镜像木马白名单
        /// </summary>
        /// <param name="req"><see cref="DescribeImageVirusWhitelistRequest"/></param>
        /// <returns><see cref="DescribeImageVirusWhitelistResponse"/></returns>
        public DescribeImageVirusWhitelistResponse DescribeImageVirusWhitelistSync(DescribeImageVirusWhitelistRequest req)
        {
            return InternalRequestAsync<DescribeImageVirusWhitelistResponse>(req, "DescribeImageVirusWhitelist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询镜像木马白名单详情
        /// </summary>
        /// <param name="req"><see cref="DescribeImageVirusWhitelistDetailRequest"/></param>
        /// <returns><see cref="DescribeImageVirusWhitelistDetailResponse"/></returns>
        public Task<DescribeImageVirusWhitelistDetailResponse> DescribeImageVirusWhitelistDetail(DescribeImageVirusWhitelistDetailRequest req)
        {
            return InternalRequestAsync<DescribeImageVirusWhitelistDetailResponse>(req, "DescribeImageVirusWhitelistDetail");
        }

        /// <summary>
        /// 查询镜像木马白名单详情
        /// </summary>
        /// <param name="req"><see cref="DescribeImageVirusWhitelistDetailRequest"/></param>
        /// <returns><see cref="DescribeImageVirusWhitelistDetailResponse"/></returns>
        public DescribeImageVirusWhitelistDetailResponse DescribeImageVirusWhitelistDetailSync(DescribeImageVirusWhitelistDetailRequest req)
        {
            return InternalRequestAsync<DescribeImageVirusWhitelistDetailResponse>(req, "DescribeImageVirusWhitelistDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询镜像漏洞列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageVulListRequest"/></param>
        /// <returns><see cref="DescribeImageVulListResponse"/></returns>
        public Task<DescribeImageVulListResponse> DescribeImageVulList(DescribeImageVulListRequest req)
        {
            return InternalRequestAsync<DescribeImageVulListResponse>(req, "DescribeImageVulList");
        }

        /// <summary>
        /// 查询镜像漏洞列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageVulListRequest"/></param>
        /// <returns><see cref="DescribeImageVulListResponse"/></returns>
        public DescribeImageVulListResponse DescribeImageVulListSync(DescribeImageVulListRequest req)
        {
            return InternalRequestAsync<DescribeImageVulListResponse>(req, "DescribeImageVulList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询镜像漏洞概览列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageVulSummaryListRequest"/></param>
        /// <returns><see cref="DescribeImageVulSummaryListResponse"/></returns>
        public Task<DescribeImageVulSummaryListResponse> DescribeImageVulSummaryList(DescribeImageVulSummaryListRequest req)
        {
            return InternalRequestAsync<DescribeImageVulSummaryListResponse>(req, "DescribeImageVulSummaryList");
        }

        /// <summary>
        /// 查询镜像漏洞概览列表
        /// </summary>
        /// <param name="req"><see cref="DescribeImageVulSummaryListRequest"/></param>
        /// <returns><see cref="DescribeImageVulSummaryListResponse"/></returns>
        public DescribeImageVulSummaryListResponse DescribeImageVulSummaryListSync(DescribeImageVulSummaryListRequest req)
        {
            return InternalRequestAsync<DescribeImageVulSummaryListResponse>(req, "DescribeImageVulSummaryList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询容器镜像漏洞白名单
        /// </summary>
        /// <param name="req"><see cref="DescribeImageVulWhitelistRequest"/></param>
        /// <returns><see cref="DescribeImageVulWhitelistResponse"/></returns>
        public Task<DescribeImageVulWhitelistResponse> DescribeImageVulWhitelist(DescribeImageVulWhitelistRequest req)
        {
            return InternalRequestAsync<DescribeImageVulWhitelistResponse>(req, "DescribeImageVulWhitelist");
        }

        /// <summary>
        /// 查询容器镜像漏洞白名单
        /// </summary>
        /// <param name="req"><see cref="DescribeImageVulWhitelistRequest"/></param>
        /// <returns><see cref="DescribeImageVulWhitelistResponse"/></returns>
        public DescribeImageVulWhitelistResponse DescribeImageVulWhitelistSync(DescribeImageVulWhitelistRequest req)
        {
            return InternalRequestAsync<DescribeImageVulWhitelistResponse>(req, "DescribeImageVulWhitelist")
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
        /// 根据用户输入的 KB 内部 ID 查询单个 Windows KB 补丁的详情信息，返回 KB 基本信息、发布时间、是否需要重启，以及该 KB 关联的漏洞列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeKBDetailRequest"/></param>
        /// <returns><see cref="DescribeKBDetailResponse"/></returns>
        public Task<DescribeKBDetailResponse> DescribeKBDetail(DescribeKBDetailRequest req)
        {
            return InternalRequestAsync<DescribeKBDetailResponse>(req, "DescribeKBDetail");
        }

        /// <summary>
        /// 根据用户输入的 KB 内部 ID 查询单个 Windows KB 补丁的详情信息，返回 KB 基本信息、发布时间、是否需要重启，以及该 KB 关联的漏洞列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeKBDetailRequest"/></param>
        /// <returns><see cref="DescribeKBDetailResponse"/></returns>
        public DescribeKBDetailResponse DescribeKBDetailSync(DescribeKBDetailRequest req)
        {
            return InternalRequestAsync<DescribeKBDetailResponse>(req, "DescribeKBDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定KB补丁可以更新的主机列表。用于Windows系统补丁修复场景，在用户提交KB补丁更新任务前，查询哪些主机缺少该补丁且支持自动更新。
        /// </summary>
        /// <param name="req"><see cref="DescribeKBUpdatableMachineListRequest"/></param>
        /// <returns><see cref="DescribeKBUpdatableMachineListResponse"/></returns>
        public Task<DescribeKBUpdatableMachineListResponse> DescribeKBUpdatableMachineList(DescribeKBUpdatableMachineListRequest req)
        {
            return InternalRequestAsync<DescribeKBUpdatableMachineListResponse>(req, "DescribeKBUpdatableMachineList");
        }

        /// <summary>
        /// 查询指定KB补丁可以更新的主机列表。用于Windows系统补丁修复场景，在用户提交KB补丁更新任务前，查询哪些主机缺少该补丁且支持自动更新。
        /// </summary>
        /// <param name="req"><see cref="DescribeKBUpdatableMachineListRequest"/></param>
        /// <returns><see cref="DescribeKBUpdatableMachineListResponse"/></returns>
        public DescribeKBUpdatableMachineListResponse DescribeKBUpdatableMachineListSync(DescribeKBUpdatableMachineListRequest req)
        {
            return InternalRequestAsync<DescribeKBUpdatableMachineListResponse>(req, "DescribeKBUpdatableMachineList")
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
        /// 获取最近一次立即检测任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeLastScanTaskInfoRequest"/></param>
        /// <returns><see cref="DescribeLastScanTaskInfoResponse"/></returns>
        public Task<DescribeLastScanTaskInfoResponse> DescribeLastScanTaskInfo(DescribeLastScanTaskInfoRequest req)
        {
            return InternalRequestAsync<DescribeLastScanTaskInfoResponse>(req, "DescribeLastScanTaskInfo");
        }

        /// <summary>
        /// 获取最近一次立即检测任务信息
        /// </summary>
        /// <param name="req"><see cref="DescribeLastScanTaskInfoRequest"/></param>
        /// <returns><see cref="DescribeLastScanTaskInfoResponse"/></returns>
        public DescribeLastScanTaskInfoResponse DescribeLastScanTaskInfoSync(DescribeLastScanTaskInfoRequest req)
        {
            return InternalRequestAsync<DescribeLastScanTaskInfoResponse>(req, "DescribeLastScanTaskInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询当前账号下所有有效授权的汇总状态，按计费项分组返回总数、已用、剩余及到期时间，同时返回自动加购开关状态和合并剩余解绑次数。输出顺序固定为：旗舰版 → 专业版 → RASP → 其他。
        /// </summary>
        /// <param name="req"><see cref="DescribeLicenseStatusRequest"/></param>
        /// <returns><see cref="DescribeLicenseStatusResponse"/></returns>
        public Task<DescribeLicenseStatusResponse> DescribeLicenseStatus(DescribeLicenseStatusRequest req)
        {
            return InternalRequestAsync<DescribeLicenseStatusResponse>(req, "DescribeLicenseStatus");
        }

        /// <summary>
        /// 查询当前账号下所有有效授权的汇总状态，按计费项分组返回总数、已用、剩余及到期时间，同时返回自动加购开关状态和合并剩余解绑次数。输出顺序固定为：旗舰版 → 专业版 → RASP → 其他。
        /// </summary>
        /// <param name="req"><see cref="DescribeLicenseStatusRequest"/></param>
        /// <returns><see cref="DescribeLicenseStatusResponse"/></returns>
        public DescribeLicenseStatusResponse DescribeLicenseStatusSync(DescribeLicenseStatusRequest req)
        {
            return InternalRequestAsync<DescribeLicenseStatusResponse>(req, "DescribeLicenseStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询轻量应用服务器防火墙规则
        /// </summary>
        /// <param name="req"><see cref="DescribeLighthouseFirewallRulesRequest"/></param>
        /// <returns><see cref="DescribeLighthouseFirewallRulesResponse"/></returns>
        public Task<DescribeLighthouseFirewallRulesResponse> DescribeLighthouseFirewallRules(DescribeLighthouseFirewallRulesRequest req)
        {
            return InternalRequestAsync<DescribeLighthouseFirewallRulesResponse>(req, "DescribeLighthouseFirewallRules");
        }

        /// <summary>
        /// 查询轻量应用服务器防火墙规则
        /// </summary>
        /// <param name="req"><see cref="DescribeLighthouseFirewallRulesRequest"/></param>
        /// <returns><see cref="DescribeLighthouseFirewallRulesResponse"/></returns>
        public DescribeLighthouseFirewallRulesResponse DescribeLighthouseFirewallRulesSync(DescribeLighthouseFirewallRulesRequest req)
        {
            return InternalRequestAsync<DescribeLighthouseFirewallRulesResponse>(req, "DescribeLighthouseFirewallRules")
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
        /// 获取防卸载全局配置
        /// </summary>
        /// <param name="req"><see cref="DescribeLoginTypeGlobalConfRequest"/></param>
        /// <returns><see cref="DescribeLoginTypeGlobalConfResponse"/></returns>
        public Task<DescribeLoginTypeGlobalConfResponse> DescribeLoginTypeGlobalConf(DescribeLoginTypeGlobalConfRequest req)
        {
            return InternalRequestAsync<DescribeLoginTypeGlobalConfResponse>(req, "DescribeLoginTypeGlobalConf");
        }

        /// <summary>
        /// 获取防卸载全局配置
        /// </summary>
        /// <param name="req"><see cref="DescribeLoginTypeGlobalConfRequest"/></param>
        /// <returns><see cref="DescribeLoginTypeGlobalConfResponse"/></returns>
        public DescribeLoginTypeGlobalConfResponse DescribeLoginTypeGlobalConfSync(DescribeLoginTypeGlobalConfRequest req)
        {
            return InternalRequestAsync<DescribeLoginTypeGlobalConfResponse>(req, "DescribeLoginTypeGlobalConf")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取扫码登录主机列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLoginTypeHostRequest"/></param>
        /// <returns><see cref="DescribeLoginTypeHostResponse"/></returns>
        public Task<DescribeLoginTypeHostResponse> DescribeLoginTypeHost(DescribeLoginTypeHostRequest req)
        {
            return InternalRequestAsync<DescribeLoginTypeHostResponse>(req, "DescribeLoginTypeHost");
        }

        /// <summary>
        /// 获取扫码登录主机列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLoginTypeHostRequest"/></param>
        /// <returns><see cref="DescribeLoginTypeHostResponse"/></returns>
        public DescribeLoginTypeHostResponse DescribeLoginTypeHostSync(DescribeLoginTypeHostRequest req)
        {
            return InternalRequestAsync<DescribeLoginTypeHostResponse>(req, "DescribeLoginTypeHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取异地登录白名单合并后列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLoginWhiteCombinedListRequest"/></param>
        /// <returns><see cref="DescribeLoginWhiteCombinedListResponse"/></returns>
        public Task<DescribeLoginWhiteCombinedListResponse> DescribeLoginWhiteCombinedList(DescribeLoginWhiteCombinedListRequest req)
        {
            return InternalRequestAsync<DescribeLoginWhiteCombinedListResponse>(req, "DescribeLoginWhiteCombinedList");
        }

        /// <summary>
        /// 获取异地登录白名单合并后列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLoginWhiteCombinedListRequest"/></param>
        /// <returns><see cref="DescribeLoginWhiteCombinedListResponse"/></returns>
        public DescribeLoginWhiteCombinedListResponse DescribeLoginWhiteCombinedListSync(DescribeLoginWhiteCombinedListRequest req)
        {
            return InternalRequestAsync<DescribeLoginWhiteCombinedListResponse>(req, "DescribeLoginWhiteCombinedList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询合并后白名单机器列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLoginWhiteHostListRequest"/></param>
        /// <returns><see cref="DescribeLoginWhiteHostListResponse"/></returns>
        public Task<DescribeLoginWhiteHostListResponse> DescribeLoginWhiteHostList(DescribeLoginWhiteHostListRequest req)
        {
            return InternalRequestAsync<DescribeLoginWhiteHostListResponse>(req, "DescribeLoginWhiteHostList");
        }

        /// <summary>
        /// 查询合并后白名单机器列表
        /// </summary>
        /// <param name="req"><see cref="DescribeLoginWhiteHostListRequest"/></param>
        /// <returns><see cref="DescribeLoginWhiteHostListResponse"/></returns>
        public DescribeLoginWhiteHostListResponse DescribeLoginWhiteHostListSync(DescribeLoginWhiteHostListRequest req)
        {
            return InternalRequestAsync<DescribeLoginWhiteHostListResponse>(req, "DescribeLoginWhiteHostList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询机器清理历史记录
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineClearHistoryRequest"/></param>
        /// <returns><see cref="DescribeMachineClearHistoryResponse"/></returns>
        public Task<DescribeMachineClearHistoryResponse> DescribeMachineClearHistory(DescribeMachineClearHistoryRequest req)
        {
            return InternalRequestAsync<DescribeMachineClearHistoryResponse>(req, "DescribeMachineClearHistory");
        }

        /// <summary>
        /// 查询机器清理历史记录
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineClearHistoryRequest"/></param>
        /// <returns><see cref="DescribeMachineClearHistoryResponse"/></returns>
        public DescribeMachineClearHistoryResponse DescribeMachineClearHistorySync(DescribeMachineClearHistoryRequest req)
        {
            return InternalRequestAsync<DescribeMachineClearHistoryResponse>(req, "DescribeMachineClearHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询主机概览信息
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineGeneralRequest"/></param>
        /// <returns><see cref="DescribeMachineGeneralResponse"/></returns>
        public Task<DescribeMachineGeneralResponse> DescribeMachineGeneral(DescribeMachineGeneralRequest req)
        {
            return InternalRequestAsync<DescribeMachineGeneralResponse>(req, "DescribeMachineGeneral");
        }

        /// <summary>
        /// 查询主机概览信息
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineGeneralRequest"/></param>
        /// <returns><see cref="DescribeMachineGeneralResponse"/></returns>
        public DescribeMachineGeneralResponse DescribeMachineGeneralSync(DescribeMachineGeneralRequest req)
        {
            return InternalRequestAsync<DescribeMachineGeneralResponse>(req, "DescribeMachineGeneral")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取主机登录方式
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineLoginTypeRequest"/></param>
        /// <returns><see cref="DescribeMachineLoginTypeResponse"/></returns>
        public Task<DescribeMachineLoginTypeResponse> DescribeMachineLoginType(DescribeMachineLoginTypeRequest req)
        {
            return InternalRequestAsync<DescribeMachineLoginTypeResponse>(req, "DescribeMachineLoginType");
        }

        /// <summary>
        /// 获取主机登录方式
        /// </summary>
        /// <param name="req"><see cref="DescribeMachineLoginTypeRequest"/></param>
        /// <returns><see cref="DescribeMachineLoginTypeResponse"/></returns>
        public DescribeMachineLoginTypeResponse DescribeMachineLoginTypeSync(DescribeMachineLoginTypeRequest req)
        {
            return InternalRequestAsync<DescribeMachineLoginTypeResponse>(req, "DescribeMachineLoginType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询文件查杀定时扫描配置
        /// </summary>
        /// <param name="req"><see cref="DescribeMalwareTimingScanSettingRequest"/></param>
        /// <returns><see cref="DescribeMalwareTimingScanSettingResponse"/></returns>
        public Task<DescribeMalwareTimingScanSettingResponse> DescribeMalwareTimingScanSetting(DescribeMalwareTimingScanSettingRequest req)
        {
            return InternalRequestAsync<DescribeMalwareTimingScanSettingResponse>(req, "DescribeMalwareTimingScanSetting");
        }

        /// <summary>
        /// 查询文件查杀定时扫描配置
        /// </summary>
        /// <param name="req"><see cref="DescribeMalwareTimingScanSettingRequest"/></param>
        /// <returns><see cref="DescribeMalwareTimingScanSettingResponse"/></returns>
        public DescribeMalwareTimingScanSettingResponse DescribeMalwareTimingScanSettingSync(DescribeMalwareTimingScanSettingRequest req)
        {
            return InternalRequestAsync<DescribeMalwareTimingScanSettingResponse>(req, "DescribeMalwareTimingScanSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 展示企业必修漏洞情报
        /// </summary>
        /// <param name="req"><see cref="DescribeMandatoryVulSetRequest"/></param>
        /// <returns><see cref="DescribeMandatoryVulSetResponse"/></returns>
        public Task<DescribeMandatoryVulSetResponse> DescribeMandatoryVulSet(DescribeMandatoryVulSetRequest req)
        {
            return InternalRequestAsync<DescribeMandatoryVulSetResponse>(req, "DescribeMandatoryVulSet");
        }

        /// <summary>
        /// 展示企业必修漏洞情报
        /// </summary>
        /// <param name="req"><see cref="DescribeMandatoryVulSetRequest"/></param>
        /// <returns><see cref="DescribeMandatoryVulSetResponse"/></returns>
        public DescribeMandatoryVulSetResponse DescribeMandatoryVulSetSync(DescribeMandatoryVulSetRequest req)
        {
            return InternalRequestAsync<DescribeMandatoryVulSetResponse>(req, "DescribeMandatoryVulSet")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取批量修改主机登录方式任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeModifyMachinesLoginTypeTasksRequest"/></param>
        /// <returns><see cref="DescribeModifyMachinesLoginTypeTasksResponse"/></returns>
        public Task<DescribeModifyMachinesLoginTypeTasksResponse> DescribeModifyMachinesLoginTypeTasks(DescribeModifyMachinesLoginTypeTasksRequest req)
        {
            return InternalRequestAsync<DescribeModifyMachinesLoginTypeTasksResponse>(req, "DescribeModifyMachinesLoginTypeTasks");
        }

        /// <summary>
        /// 获取批量修改主机登录方式任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeModifyMachinesLoginTypeTasksRequest"/></param>
        /// <returns><see cref="DescribeModifyMachinesLoginTypeTasksResponse"/></returns>
        public DescribeModifyMachinesLoginTypeTasksResponse DescribeModifyMachinesLoginTypeTasksSync(DescribeModifyMachinesLoginTypeTasksRequest req)
        {
            return InternalRequestAsync<DescribeModifyMachinesLoginTypeTasksResponse>(req, "DescribeModifyMachinesLoginTypeTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取多云（腾讯云、阿里云、AWS、华为云、Azure 等）接入的资产总数及各云厂商资产数量明细
        /// </summary>
        /// <param name="req"><see cref="DescribeMultiCloudAssetCountRequest"/></param>
        /// <returns><see cref="DescribeMultiCloudAssetCountResponse"/></returns>
        public Task<DescribeMultiCloudAssetCountResponse> DescribeMultiCloudAssetCount(DescribeMultiCloudAssetCountRequest req)
        {
            return InternalRequestAsync<DescribeMultiCloudAssetCountResponse>(req, "DescribeMultiCloudAssetCount");
        }

        /// <summary>
        /// 获取多云（腾讯云、阿里云、AWS、华为云、Azure 等）接入的资产总数及各云厂商资产数量明细
        /// </summary>
        /// <param name="req"><see cref="DescribeMultiCloudAssetCountRequest"/></param>
        /// <returns><see cref="DescribeMultiCloudAssetCountResponse"/></returns>
        public DescribeMultiCloudAssetCountResponse DescribeMultiCloudAssetCountSync(DescribeMultiCloudAssetCountRequest req)
        {
            return InternalRequestAsync<DescribeMultiCloudAssetCountResponse>(req, "DescribeMultiCloudAssetCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取NFS扫描全局配置
        /// </summary>
        /// <param name="req"><see cref="DescribeNFSScanConfRequest"/></param>
        /// <returns><see cref="DescribeNFSScanConfResponse"/></returns>
        public Task<DescribeNFSScanConfResponse> DescribeNFSScanConf(DescribeNFSScanConfRequest req)
        {
            return InternalRequestAsync<DescribeNFSScanConfResponse>(req, "DescribeNFSScanConf");
        }

        /// <summary>
        /// 获取NFS扫描全局配置
        /// </summary>
        /// <param name="req"><see cref="DescribeNFSScanConfRequest"/></param>
        /// <returns><see cref="DescribeNFSScanConfResponse"/></returns>
        public DescribeNFSScanConfResponse DescribeNFSScanConfSync(DescribeNFSScanConfRequest req)
        {
            return InternalRequestAsync<DescribeNFSScanConfResponse>(req, "DescribeNFSScanConf")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取扫码登录主机列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNFSScanHostRequest"/></param>
        /// <returns><see cref="DescribeNFSScanHostResponse"/></returns>
        public Task<DescribeNFSScanHostResponse> DescribeNFSScanHost(DescribeNFSScanHostRequest req)
        {
            return InternalRequestAsync<DescribeNFSScanHostResponse>(req, "DescribeNFSScanHost");
        }

        /// <summary>
        /// 获取扫码登录主机列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNFSScanHostRequest"/></param>
        /// <returns><see cref="DescribeNFSScanHostResponse"/></returns>
        public DescribeNFSScanHostResponse DescribeNFSScanHostSync(DescribeNFSScanHostRequest req)
        {
            return InternalRequestAsync<DescribeNFSScanHostResponse>(req, "DescribeNFSScanHost")
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
        /// 查询腾讯云nat网关实例对应的NAT策略
        /// </summary>
        /// <param name="req"><see cref="DescribeNatRulesRequest"/></param>
        /// <returns><see cref="DescribeNatRulesResponse"/></returns>
        public Task<DescribeNatRulesResponse> DescribeNatRules(DescribeNatRulesRequest req)
        {
            return InternalRequestAsync<DescribeNatRulesResponse>(req, "DescribeNatRules");
        }

        /// <summary>
        /// 查询腾讯云nat网关实例对应的NAT策略
        /// </summary>
        /// <param name="req"><see cref="DescribeNatRulesRequest"/></param>
        /// <returns><see cref="DescribeNatRulesResponse"/></returns>
        public DescribeNatRulesResponse DescribeNatRulesSync(DescribeNatRulesRequest req)
        {
            return InternalRequestAsync<DescribeNatRulesResponse>(req, "DescribeNatRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询网络攻击检测开关及资产范围配置
        /// </summary>
        /// <param name="req"><see cref="DescribeNetAttackSettingRequest"/></param>
        /// <returns><see cref="DescribeNetAttackSettingResponse"/></returns>
        public Task<DescribeNetAttackSettingResponse> DescribeNetAttackSetting(DescribeNetAttackSettingRequest req)
        {
            return InternalRequestAsync<DescribeNetAttackSettingResponse>(req, "DescribeNetAttackSetting");
        }

        /// <summary>
        /// 查询网络攻击检测开关及资产范围配置
        /// </summary>
        /// <param name="req"><see cref="DescribeNetAttackSettingRequest"/></param>
        /// <returns><see cref="DescribeNetAttackSettingResponse"/></returns>
        public DescribeNetAttackSettingResponse DescribeNetAttackSettingSync(DescribeNetAttackSettingRequest req)
        {
            return InternalRequestAsync<DescribeNetAttackSettingResponse>(req, "DescribeNetAttackSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询客户端离线时长
        /// </summary>
        /// <param name="req"><see cref="DescribeNotifyAgentOfflineDurationRequest"/></param>
        /// <returns><see cref="DescribeNotifyAgentOfflineDurationResponse"/></returns>
        public Task<DescribeNotifyAgentOfflineDurationResponse> DescribeNotifyAgentOfflineDuration(DescribeNotifyAgentOfflineDurationRequest req)
        {
            return InternalRequestAsync<DescribeNotifyAgentOfflineDurationResponse>(req, "DescribeNotifyAgentOfflineDuration");
        }

        /// <summary>
        /// 查询客户端离线时长
        /// </summary>
        /// <param name="req"><see cref="DescribeNotifyAgentOfflineDurationRequest"/></param>
        /// <returns><see cref="DescribeNotifyAgentOfflineDurationResponse"/></returns>
        public DescribeNotifyAgentOfflineDurationResponse DescribeNotifyAgentOfflineDurationSync(DescribeNotifyAgentOfflineDurationRequest req)
        {
            return InternalRequestAsync<DescribeNotifyAgentOfflineDurationResponse>(req, "DescribeNotifyAgentOfflineDuration")
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
        /// 获取通知设置（云API风险治理）
        /// </summary>
        /// <param name="req"><see cref="DescribeNotifySettingAkRequest"/></param>
        /// <returns><see cref="DescribeNotifySettingAkResponse"/></returns>
        public Task<DescribeNotifySettingAkResponse> DescribeNotifySettingAk(DescribeNotifySettingAkRequest req)
        {
            return InternalRequestAsync<DescribeNotifySettingAkResponse>(req, "DescribeNotifySettingAk");
        }

        /// <summary>
        /// 获取通知设置（云API风险治理）
        /// </summary>
        /// <param name="req"><see cref="DescribeNotifySettingAkRequest"/></param>
        /// <returns><see cref="DescribeNotifySettingAkResponse"/></returns>
        public DescribeNotifySettingAkResponse DescribeNotifySettingAkSync(DescribeNotifySettingAkRequest req)
        {
            return InternalRequestAsync<DescribeNotifySettingAkResponse>(req, "DescribeNotifySettingAk")
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
        /// 查询 Pod 关联容器列表
        /// </summary>
        /// <param name="req"><see cref="DescribePodContainerListRequest"/></param>
        /// <returns><see cref="DescribePodContainerListResponse"/></returns>
        public Task<DescribePodContainerListResponse> DescribePodContainerList(DescribePodContainerListRequest req)
        {
            return InternalRequestAsync<DescribePodContainerListResponse>(req, "DescribePodContainerList");
        }

        /// <summary>
        /// 查询 Pod 关联容器列表
        /// </summary>
        /// <param name="req"><see cref="DescribePodContainerListRequest"/></param>
        /// <returns><see cref="DescribePodContainerListResponse"/></returns>
        public DescribePodContainerListResponse DescribePodContainerListSync(DescribePodContainerListRequest req)
        {
            return InternalRequestAsync<DescribePodContainerListResponse>(req, "DescribePodContainerList")
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
        /// 端口探测列表
        /// </summary>
        /// <param name="req"><see cref="DescribePortDetectListRequest"/></param>
        /// <returns><see cref="DescribePortDetectListResponse"/></returns>
        public Task<DescribePortDetectListResponse> DescribePortDetectList(DescribePortDetectListRequest req)
        {
            return InternalRequestAsync<DescribePortDetectListResponse>(req, "DescribePortDetectList");
        }

        /// <summary>
        /// 端口探测列表
        /// </summary>
        /// <param name="req"><see cref="DescribePortDetectListRequest"/></param>
        /// <returns><see cref="DescribePortDetectListResponse"/></returns>
        public DescribePortDetectListResponse DescribePortDetectListSync(DescribePortDetectListRequest req)
        {
            return InternalRequestAsync<DescribePortDetectListResponse>(req, "DescribePortDetectList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询当前账号下端口扫描任务次数
        /// </summary>
        /// <param name="req"><see cref="DescribePortScanTaskCountRequest"/></param>
        /// <returns><see cref="DescribePortScanTaskCountResponse"/></returns>
        public Task<DescribePortScanTaskCountResponse> DescribePortScanTaskCount(DescribePortScanTaskCountRequest req)
        {
            return InternalRequestAsync<DescribePortScanTaskCountResponse>(req, "DescribePortScanTaskCount");
        }

        /// <summary>
        /// 查询当前账号下端口扫描任务次数
        /// </summary>
        /// <param name="req"><see cref="DescribePortScanTaskCountRequest"/></param>
        /// <returns><see cref="DescribePortScanTaskCountResponse"/></returns>
        public DescribePortScanTaskCountResponse DescribePortScanTaskCountSync(DescribePortScanTaskCountRequest req)
        {
            return InternalRequestAsync<DescribePortScanTaskCountResponse>(req, "DescribePortScanTaskCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取防卸载全局配置
        /// </summary>
        /// <param name="req"><see cref="DescribePreventUninstallGlobalConfRequest"/></param>
        /// <returns><see cref="DescribePreventUninstallGlobalConfResponse"/></returns>
        public Task<DescribePreventUninstallGlobalConfResponse> DescribePreventUninstallGlobalConf(DescribePreventUninstallGlobalConfRequest req)
        {
            return InternalRequestAsync<DescribePreventUninstallGlobalConfResponse>(req, "DescribePreventUninstallGlobalConf");
        }

        /// <summary>
        /// 获取防卸载全局配置
        /// </summary>
        /// <param name="req"><see cref="DescribePreventUninstallGlobalConfRequest"/></param>
        /// <returns><see cref="DescribePreventUninstallGlobalConfResponse"/></returns>
        public DescribePreventUninstallGlobalConfResponse DescribePreventUninstallGlobalConfSync(DescribePreventUninstallGlobalConfRequest req)
        {
            return InternalRequestAsync<DescribePreventUninstallGlobalConfResponse>(req, "DescribePreventUninstallGlobalConf")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取防卸载主机列表
        /// </summary>
        /// <param name="req"><see cref="DescribePreventUninstallHostRequest"/></param>
        /// <returns><see cref="DescribePreventUninstallHostResponse"/></returns>
        public Task<DescribePreventUninstallHostResponse> DescribePreventUninstallHost(DescribePreventUninstallHostRequest req)
        {
            return InternalRequestAsync<DescribePreventUninstallHostResponse>(req, "DescribePreventUninstallHost");
        }

        /// <summary>
        /// 获取防卸载主机列表
        /// </summary>
        /// <param name="req"><see cref="DescribePreventUninstallHostRequest"/></param>
        /// <returns><see cref="DescribePreventUninstallHostResponse"/></returns>
        public DescribePreventUninstallHostResponse DescribePreventUninstallHostSync(DescribePreventUninstallHostRequest req)
        {
            return InternalRequestAsync<DescribePreventUninstallHostResponse>(req, "DescribePreventUninstallHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取进程防护全局配置
        /// </summary>
        /// <param name="req"><see cref="DescribeProcessDaemonGlobalConfRequest"/></param>
        /// <returns><see cref="DescribeProcessDaemonGlobalConfResponse"/></returns>
        public Task<DescribeProcessDaemonGlobalConfResponse> DescribeProcessDaemonGlobalConf(DescribeProcessDaemonGlobalConfRequest req)
        {
            return InternalRequestAsync<DescribeProcessDaemonGlobalConfResponse>(req, "DescribeProcessDaemonGlobalConf");
        }

        /// <summary>
        /// 获取进程防护全局配置
        /// </summary>
        /// <param name="req"><see cref="DescribeProcessDaemonGlobalConfRequest"/></param>
        /// <returns><see cref="DescribeProcessDaemonGlobalConfResponse"/></returns>
        public DescribeProcessDaemonGlobalConfResponse DescribeProcessDaemonGlobalConfSync(DescribeProcessDaemonGlobalConfRequest req)
        {
            return InternalRequestAsync<DescribeProcessDaemonGlobalConfResponse>(req, "DescribeProcessDaemonGlobalConf")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取进程守护主机列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProcessDaemonHostRequest"/></param>
        /// <returns><see cref="DescribeProcessDaemonHostResponse"/></returns>
        public Task<DescribeProcessDaemonHostResponse> DescribeProcessDaemonHost(DescribeProcessDaemonHostRequest req)
        {
            return InternalRequestAsync<DescribeProcessDaemonHostResponse>(req, "DescribeProcessDaemonHost");
        }

        /// <summary>
        /// 获取进程守护主机列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProcessDaemonHostRequest"/></param>
        /// <returns><see cref="DescribeProcessDaemonHostResponse"/></returns>
        public DescribeProcessDaemonHostResponse DescribeProcessDaemonHostSync(DescribeProcessDaemonHostRequest req)
        {
            return InternalRequestAsync<DescribeProcessDaemonHostResponse>(req, "DescribeProcessDaemonHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 公网资产
        /// </summary>
        /// <param name="req"><see cref="DescribePublicCloudAssetsRequest"/></param>
        /// <returns><see cref="DescribePublicCloudAssetsResponse"/></returns>
        public Task<DescribePublicCloudAssetsResponse> DescribePublicCloudAssets(DescribePublicCloudAssetsRequest req)
        {
            return InternalRequestAsync<DescribePublicCloudAssetsResponse>(req, "DescribePublicCloudAssets");
        }

        /// <summary>
        /// 公网资产
        /// </summary>
        /// <param name="req"><see cref="DescribePublicCloudAssetsRequest"/></param>
        /// <returns><see cref="DescribePublicCloudAssetsResponse"/></returns>
        public DescribePublicCloudAssetsResponse DescribePublicCloudAssetsSync(DescribePublicCloudAssetsRequest req)
        {
            return InternalRequestAsync<DescribePublicCloudAssetsResponse>(req, "DescribePublicCloudAssets")
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
        /// 查询应用防护授权列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRaspLicenseListRequest"/></param>
        /// <returns><see cref="DescribeRaspLicenseListResponse"/></returns>
        public Task<DescribeRaspLicenseListResponse> DescribeRaspLicenseList(DescribeRaspLicenseListRequest req)
        {
            return InternalRequestAsync<DescribeRaspLicenseListResponse>(req, "DescribeRaspLicenseList");
        }

        /// <summary>
        /// 查询应用防护授权列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRaspLicenseListRequest"/></param>
        /// <returns><see cref="DescribeRaspLicenseListResponse"/></returns>
        public DescribeRaspLicenseListResponse DescribeRaspLicenseListSync(DescribeRaspLicenseListRequest req)
        {
            return InternalRequestAsync<DescribeRaspLicenseListResponse>(req, "DescribeRaspLicenseList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询仓库总览
        /// </summary>
        /// <param name="req"><see cref="DescribeRegistryOverviewRequest"/></param>
        /// <returns><see cref="DescribeRegistryOverviewResponse"/></returns>
        public Task<DescribeRegistryOverviewResponse> DescribeRegistryOverview(DescribeRegistryOverviewRequest req)
        {
            return InternalRequestAsync<DescribeRegistryOverviewResponse>(req, "DescribeRegistryOverview");
        }

        /// <summary>
        /// 查询仓库总览
        /// </summary>
        /// <param name="req"><see cref="DescribeRegistryOverviewRequest"/></param>
        /// <returns><see cref="DescribeRegistryOverviewResponse"/></returns>
        public DescribeRegistryOverviewResponse DescribeRegistryOverviewSync(DescribeRegistryOverviewRequest req)
        {
            return InternalRequestAsync<DescribeRegistryOverviewResponse>(req, "DescribeRegistryOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询镜像仓库地域列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRegistryRegionListRequest"/></param>
        /// <returns><see cref="DescribeRegistryRegionListResponse"/></returns>
        public Task<DescribeRegistryRegionListResponse> DescribeRegistryRegionList(DescribeRegistryRegionListRequest req)
        {
            return InternalRequestAsync<DescribeRegistryRegionListResponse>(req, "DescribeRegistryRegionList");
        }

        /// <summary>
        /// 查询镜像仓库地域列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRegistryRegionListRequest"/></param>
        /// <returns><see cref="DescribeRegistryRegionListResponse"/></returns>
        public DescribeRegistryRegionListResponse DescribeRegistryRegionListSync(DescribeRegistryRegionListRequest req)
        {
            return InternalRequestAsync<DescribeRegistryRegionListResponse>(req, "DescribeRegistryRegionList")
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
        /// 查询反弹Shell内网告警与资产范围配置
        /// </summary>
        /// <param name="req"><see cref="DescribeReverseShellSystemPolicyConfigRequest"/></param>
        /// <returns><see cref="DescribeReverseShellSystemPolicyConfigResponse"/></returns>
        public Task<DescribeReverseShellSystemPolicyConfigResponse> DescribeReverseShellSystemPolicyConfig(DescribeReverseShellSystemPolicyConfigRequest req)
        {
            return InternalRequestAsync<DescribeReverseShellSystemPolicyConfigResponse>(req, "DescribeReverseShellSystemPolicyConfig");
        }

        /// <summary>
        /// 查询反弹Shell内网告警与资产范围配置
        /// </summary>
        /// <param name="req"><see cref="DescribeReverseShellSystemPolicyConfigRequest"/></param>
        /// <returns><see cref="DescribeReverseShellSystemPolicyConfigResponse"/></returns>
        public DescribeReverseShellSystemPolicyConfigResponse DescribeReverseShellSystemPolicyConfigSync(DescribeReverseShellSystemPolicyConfigRequest req)
        {
            return InternalRequestAsync<DescribeReverseShellSystemPolicyConfigResponse>(req, "DescribeReverseShellSystemPolicyConfig")
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
        /// 获取风险趋势分析示例
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterRiskTrendAnalysisRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterRiskTrendAnalysisResponse"/></returns>
        public Task<DescribeRiskCenterRiskTrendAnalysisResponse> DescribeRiskCenterRiskTrendAnalysis(DescribeRiskCenterRiskTrendAnalysisRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterRiskTrendAnalysisResponse>(req, "DescribeRiskCenterRiskTrendAnalysis");
        }

        /// <summary>
        /// 获取风险趋势分析示例
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskCenterRiskTrendAnalysisRequest"/></param>
        /// <returns><see cref="DescribeRiskCenterRiskTrendAnalysisResponse"/></returns>
        public DescribeRiskCenterRiskTrendAnalysisResponse DescribeRiskCenterRiskTrendAnalysisSync(DescribeRiskCenterRiskTrendAnalysisRequest req)
        {
            return InternalRequestAsync<DescribeRiskCenterRiskTrendAnalysisResponse>(req, "DescribeRiskCenterRiskTrendAnalysis")
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
        /// 获取风险扫描周期计划
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskScanCronConfigRequest"/></param>
        /// <returns><see cref="DescribeRiskScanCronConfigResponse"/></returns>
        public Task<DescribeRiskScanCronConfigResponse> DescribeRiskScanCronConfig(DescribeRiskScanCronConfigRequest req)
        {
            return InternalRequestAsync<DescribeRiskScanCronConfigResponse>(req, "DescribeRiskScanCronConfig");
        }

        /// <summary>
        /// 获取风险扫描周期计划
        /// </summary>
        /// <param name="req"><see cref="DescribeRiskScanCronConfigRequest"/></param>
        /// <returns><see cref="DescribeRiskScanCronConfigResponse"/></returns>
        public DescribeRiskScanCronConfigResponse DescribeRiskScanCronConfigSync(DescribeRiskScanCronConfigRequest req)
        {
            return InternalRequestAsync<DescribeRiskScanCronConfigResponse>(req, "DescribeRiskScanCronConfig")
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
        /// 查询指定 SCF 函数下的别名列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeSCFAliasListRequest"/></param>
        /// <returns><see cref="DescribeSCFAliasListResponse"/></returns>
        public Task<DescribeSCFAliasListResponse> DescribeSCFAliasList(DescribeSCFAliasListRequest req)
        {
            return InternalRequestAsync<DescribeSCFAliasListResponse>(req, "DescribeSCFAliasList");
        }

        /// <summary>
        /// 查询指定 SCF 函数下的别名列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeSCFAliasListRequest"/></param>
        /// <returns><see cref="DescribeSCFAliasListResponse"/></returns>
        public DescribeSCFAliasListResponse DescribeSCFAliasListSync(DescribeSCFAliasListRequest req)
        {
            return InternalRequestAsync<DescribeSCFAliasListResponse>(req, "DescribeSCFAliasList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定命名空间下的 SCF 函数列表，仅返回 Event 触发器类型的函数。
        /// </summary>
        /// <param name="req"><see cref="DescribeSCFFunctionListRequest"/></param>
        /// <returns><see cref="DescribeSCFFunctionListResponse"/></returns>
        public Task<DescribeSCFFunctionListResponse> DescribeSCFFunctionList(DescribeSCFFunctionListRequest req)
        {
            return InternalRequestAsync<DescribeSCFFunctionListResponse>(req, "DescribeSCFFunctionList");
        }

        /// <summary>
        /// 查询指定命名空间下的 SCF 函数列表，仅返回 Event 触发器类型的函数。
        /// </summary>
        /// <param name="req"><see cref="DescribeSCFFunctionListRequest"/></param>
        /// <returns><see cref="DescribeSCFFunctionListResponse"/></returns>
        public DescribeSCFFunctionListResponse DescribeSCFFunctionListSync(DescribeSCFFunctionListRequest req)
        {
            return InternalRequestAsync<DescribeSCFFunctionListResponse>(req, "DescribeSCFFunctionList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定 SCF 函数下的版本列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeSCFFunctionVersionListRequest"/></param>
        /// <returns><see cref="DescribeSCFFunctionVersionListResponse"/></returns>
        public Task<DescribeSCFFunctionVersionListResponse> DescribeSCFFunctionVersionList(DescribeSCFFunctionVersionListRequest req)
        {
            return InternalRequestAsync<DescribeSCFFunctionVersionListResponse>(req, "DescribeSCFFunctionVersionList");
        }

        /// <summary>
        /// 查询指定 SCF 函数下的版本列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeSCFFunctionVersionListRequest"/></param>
        /// <returns><see cref="DescribeSCFFunctionVersionListResponse"/></returns>
        public DescribeSCFFunctionVersionListResponse DescribeSCFFunctionVersionListSync(DescribeSCFFunctionVersionListRequest req)
        {
            return InternalRequestAsync<DescribeSCFFunctionVersionListResponse>(req, "DescribeSCFFunctionVersionList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询当前用户在指定地域下的 SCF（云函数）命名空间列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeSCFNamespaceListRequest"/></param>
        /// <returns><see cref="DescribeSCFNamespaceListResponse"/></returns>
        public Task<DescribeSCFNamespaceListResponse> DescribeSCFNamespaceList(DescribeSCFNamespaceListRequest req)
        {
            return InternalRequestAsync<DescribeSCFNamespaceListResponse>(req, "DescribeSCFNamespaceList");
        }

        /// <summary>
        /// 查询当前用户在指定地域下的 SCF（云函数）命名空间列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeSCFNamespaceListRequest"/></param>
        /// <returns><see cref="DescribeSCFNamespaceListResponse"/></returns>
        public DescribeSCFNamespaceListResponse DescribeSCFNamespaceListSync(DescribeSCFNamespaceListRequest req)
        {
            return InternalRequestAsync<DescribeSCFNamespaceListResponse>(req, "DescribeSCFNamespaceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 分页查询 ACL 访问控制告警日志列表。支持按 Filter.Name=ID 精确过滤单条告警用于详情页场景
        /// </summary>
        /// <param name="req"><see cref="DescribeSandboxACLAlertListRequest"/></param>
        /// <returns><see cref="DescribeSandboxACLAlertListResponse"/></returns>
        public Task<DescribeSandboxACLAlertListResponse> DescribeSandboxACLAlertList(DescribeSandboxACLAlertListRequest req)
        {
            return InternalRequestAsync<DescribeSandboxACLAlertListResponse>(req, "DescribeSandboxACLAlertList");
        }

        /// <summary>
        /// 分页查询 ACL 访问控制告警日志列表。支持按 Filter.Name=ID 精确过滤单条告警用于详情页场景
        /// </summary>
        /// <param name="req"><see cref="DescribeSandboxACLAlertListRequest"/></param>
        /// <returns><see cref="DescribeSandboxACLAlertListResponse"/></returns>
        public DescribeSandboxACLAlertListResponse DescribeSandboxACLAlertListSync(DescribeSandboxACLAlertListRequest req)
        {
            return InternalRequestAsync<DescribeSandboxACLAlertListResponse>(req, "DescribeSandboxACLAlertList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询当前租户的 ACL 用户访问控制规则列表。传入 Filter.Name=RuleID 可精确查询单条规则（用于详情页面场景）
        /// </summary>
        /// <param name="req"><see cref="DescribeSandboxACLRuleListRequest"/></param>
        /// <returns><see cref="DescribeSandboxACLRuleListResponse"/></returns>
        public Task<DescribeSandboxACLRuleListResponse> DescribeSandboxACLRuleList(DescribeSandboxACLRuleListRequest req)
        {
            return InternalRequestAsync<DescribeSandboxACLRuleListResponse>(req, "DescribeSandboxACLRuleList");
        }

        /// <summary>
        /// 查询当前租户的 ACL 用户访问控制规则列表。传入 Filter.Name=RuleID 可精确查询单条规则（用于详情页面场景）
        /// </summary>
        /// <param name="req"><see cref="DescribeSandboxACLRuleListRequest"/></param>
        /// <returns><see cref="DescribeSandboxACLRuleListResponse"/></returns>
        public DescribeSandboxACLRuleListResponse DescribeSandboxACLRuleListSync(DescribeSandboxACLRuleListRequest req)
        {
            return InternalRequestAsync<DescribeSandboxACLRuleListResponse>(req, "DescribeSandboxACLRuleList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询流量沙箱访问控制（ACL）系统规则列表，系统规则由 CSIP 平台内置，可被用户规则引用
        /// </summary>
        /// <param name="req"><see cref="DescribeSandboxACLSystemRuleListRequest"/></param>
        /// <returns><see cref="DescribeSandboxACLSystemRuleListResponse"/></returns>
        public Task<DescribeSandboxACLSystemRuleListResponse> DescribeSandboxACLSystemRuleList(DescribeSandboxACLSystemRuleListRequest req)
        {
            return InternalRequestAsync<DescribeSandboxACLSystemRuleListResponse>(req, "DescribeSandboxACLSystemRuleList");
        }

        /// <summary>
        /// 查询流量沙箱访问控制（ACL）系统规则列表，系统规则由 CSIP 平台内置，可被用户规则引用
        /// </summary>
        /// <param name="req"><see cref="DescribeSandboxACLSystemRuleListRequest"/></param>
        /// <returns><see cref="DescribeSandboxACLSystemRuleListResponse"/></returns>
        public DescribeSandboxACLSystemRuleListResponse DescribeSandboxACLSystemRuleListSync(DescribeSandboxACLSystemRuleListRequest req)
        {
            return InternalRequestAsync<DescribeSandboxACLSystemRuleListResponse>(req, "DescribeSandboxACLSystemRuleList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询流量沙箱数据泄露防护（DLP）系统规则列表，系统规则由 CSIP 平台内置，可被用户规则引用
        /// </summary>
        /// <param name="req"><see cref="DescribeSandboxDLPSystemRuleListRequest"/></param>
        /// <returns><see cref="DescribeSandboxDLPSystemRuleListResponse"/></returns>
        public Task<DescribeSandboxDLPSystemRuleListResponse> DescribeSandboxDLPSystemRuleList(DescribeSandboxDLPSystemRuleListRequest req)
        {
            return InternalRequestAsync<DescribeSandboxDLPSystemRuleListResponse>(req, "DescribeSandboxDLPSystemRuleList");
        }

        /// <summary>
        /// 查询流量沙箱数据泄露防护（DLP）系统规则列表，系统规则由 CSIP 平台内置，可被用户规则引用
        /// </summary>
        /// <param name="req"><see cref="DescribeSandboxDLPSystemRuleListRequest"/></param>
        /// <returns><see cref="DescribeSandboxDLPSystemRuleListResponse"/></returns>
        public DescribeSandboxDLPSystemRuleListResponse DescribeSandboxDLPSystemRuleListSync(DescribeSandboxDLPSystemRuleListRequest req)
        {
            return InternalRequestAsync<DescribeSandboxDLPSystemRuleListResponse>(req, "DescribeSandboxDLPSystemRuleList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取命令沙箱文件规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSandboxFileRuleListRequest"/></param>
        /// <returns><see cref="DescribeSandboxFileRuleListResponse"/></returns>
        public Task<DescribeSandboxFileRuleListResponse> DescribeSandboxFileRuleList(DescribeSandboxFileRuleListRequest req)
        {
            return InternalRequestAsync<DescribeSandboxFileRuleListResponse>(req, "DescribeSandboxFileRuleList");
        }

        /// <summary>
        /// 获取命令沙箱文件规则列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSandboxFileRuleListRequest"/></param>
        /// <returns><see cref="DescribeSandboxFileRuleListResponse"/></returns>
        public DescribeSandboxFileRuleListResponse DescribeSandboxFileRuleListSync(DescribeSandboxFileRuleListRequest req)
        {
            return InternalRequestAsync<DescribeSandboxFileRuleListResponse>(req, "DescribeSandboxFileRuleList")
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
        /// 查询扫描任务记录列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScanTaskRecordListRequest"/></param>
        /// <returns><see cref="DescribeScanTaskRecordListResponse"/></returns>
        public Task<DescribeScanTaskRecordListResponse> DescribeScanTaskRecordList(DescribeScanTaskRecordListRequest req)
        {
            return InternalRequestAsync<DescribeScanTaskRecordListResponse>(req, "DescribeScanTaskRecordList");
        }

        /// <summary>
        /// 查询扫描任务记录列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScanTaskRecordListRequest"/></param>
        /// <returns><see cref="DescribeScanTaskRecordListResponse"/></returns>
        public DescribeScanTaskRecordListResponse DescribeScanTaskRecordListSync(DescribeScanTaskRecordListRequest req)
        {
            return InternalRequestAsync<DescribeScanTaskRecordListResponse>(req, "DescribeScanTaskRecordList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询腾讯云SCF自定义域名端点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScfCustomDomainEndpointsRequest"/></param>
        /// <returns><see cref="DescribeScfCustomDomainEndpointsResponse"/></returns>
        public Task<DescribeScfCustomDomainEndpointsResponse> DescribeScfCustomDomainEndpoints(DescribeScfCustomDomainEndpointsRequest req)
        {
            return InternalRequestAsync<DescribeScfCustomDomainEndpointsResponse>(req, "DescribeScfCustomDomainEndpoints");
        }

        /// <summary>
        /// 查询腾讯云SCF自定义域名端点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScfCustomDomainEndpointsRequest"/></param>
        /// <returns><see cref="DescribeScfCustomDomainEndpointsResponse"/></returns>
        public DescribeScfCustomDomainEndpointsResponse DescribeScfCustomDomainEndpointsSync(DescribeScfCustomDomainEndpointsRequest req)
        {
            return InternalRequestAsync<DescribeScfCustomDomainEndpointsResponse>(req, "DescribeScfCustomDomainEndpoints")
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
        /// 查询指定安全组ID对应安全组规则
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupPolicyRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupPolicyResponse"/></returns>
        public Task<DescribeSecurityGroupPolicyResponse> DescribeSecurityGroupPolicy(DescribeSecurityGroupPolicyRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupPolicyResponse>(req, "DescribeSecurityGroupPolicy");
        }

        /// <summary>
        /// 查询指定安全组ID对应安全组规则
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityGroupPolicyRequest"/></param>
        /// <returns><see cref="DescribeSecurityGroupPolicyResponse"/></returns>
        public DescribeSecurityGroupPolicyResponse DescribeSecurityGroupPolicySync(DescribeSecurityGroupPolicyRequest req)
        {
            return InternalRequestAsync<DescribeSecurityGroupPolicyResponse>(req, "DescribeSecurityGroupPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取安全风险趋势，返回按维度分组的每日风险数量
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityRiskTrendRequest"/></param>
        /// <returns><see cref="DescribeSecurityRiskTrendResponse"/></returns>
        public Task<DescribeSecurityRiskTrendResponse> DescribeSecurityRiskTrend(DescribeSecurityRiskTrendRequest req)
        {
            return InternalRequestAsync<DescribeSecurityRiskTrendResponse>(req, "DescribeSecurityRiskTrend");
        }

        /// <summary>
        /// 获取安全风险趋势，返回按维度分组的每日风险数量
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityRiskTrendRequest"/></param>
        /// <returns><see cref="DescribeSecurityRiskTrendResponse"/></returns>
        public DescribeSecurityRiskTrendResponse DescribeSecurityRiskTrendSync(DescribeSecurityRiskTrendRequest req)
        {
            return InternalRequestAsync<DescribeSecurityRiskTrendResponse>(req, "DescribeSecurityRiskTrend")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取安全评分概览，实时计算各维度和子项扣分情况
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityScoreOverviewRequest"/></param>
        /// <returns><see cref="DescribeSecurityScoreOverviewResponse"/></returns>
        public Task<DescribeSecurityScoreOverviewResponse> DescribeSecurityScoreOverview(DescribeSecurityScoreOverviewRequest req)
        {
            return InternalRequestAsync<DescribeSecurityScoreOverviewResponse>(req, "DescribeSecurityScoreOverview");
        }

        /// <summary>
        /// 获取安全评分概览，实时计算各维度和子项扣分情况
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityScoreOverviewRequest"/></param>
        /// <returns><see cref="DescribeSecurityScoreOverviewResponse"/></returns>
        public DescribeSecurityScoreOverviewResponse DescribeSecurityScoreOverviewSync(DescribeSecurityScoreOverviewRequest req)
        {
            return InternalRequestAsync<DescribeSecurityScoreOverviewResponse>(req, "DescribeSecurityScoreOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取当前账号的安全评分规则，无自定义则返回内置默认规则
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityScoreRuleRequest"/></param>
        /// <returns><see cref="DescribeSecurityScoreRuleResponse"/></returns>
        public Task<DescribeSecurityScoreRuleResponse> DescribeSecurityScoreRule(DescribeSecurityScoreRuleRequest req)
        {
            return InternalRequestAsync<DescribeSecurityScoreRuleResponse>(req, "DescribeSecurityScoreRule");
        }

        /// <summary>
        /// 获取当前账号的安全评分规则，无自定义则返回内置默认规则
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityScoreRuleRequest"/></param>
        /// <returns><see cref="DescribeSecurityScoreRuleResponse"/></returns>
        public DescribeSecurityScoreRuleResponse DescribeSecurityScoreRuleSync(DescribeSecurityScoreRuleRequest req)
        {
            return InternalRequestAsync<DescribeSecurityScoreRuleResponse>(req, "DescribeSecurityScoreRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 Skill 安全检测告警详情，包含本地告警信息和引擎实时检测数据
        /// </summary>
        /// <param name="req"><see cref="DescribeSkillScanAlertDetailRequest"/></param>
        /// <returns><see cref="DescribeSkillScanAlertDetailResponse"/></returns>
        public Task<DescribeSkillScanAlertDetailResponse> DescribeSkillScanAlertDetail(DescribeSkillScanAlertDetailRequest req)
        {
            return InternalRequestAsync<DescribeSkillScanAlertDetailResponse>(req, "DescribeSkillScanAlertDetail");
        }

        /// <summary>
        /// 查询 Skill 安全检测告警详情，包含本地告警信息和引擎实时检测数据
        /// </summary>
        /// <param name="req"><see cref="DescribeSkillScanAlertDetailRequest"/></param>
        /// <returns><see cref="DescribeSkillScanAlertDetailResponse"/></returns>
        public DescribeSkillScanAlertDetailResponse DescribeSkillScanAlertDetailSync(DescribeSkillScanAlertDetailRequest req)
        {
            return InternalRequestAsync<DescribeSkillScanAlertDetailResponse>(req, "DescribeSkillScanAlertDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 Skill 安全检测告警列表，支持分页、过滤和排序
        /// </summary>
        /// <param name="req"><see cref="DescribeSkillScanAlertListRequest"/></param>
        /// <returns><see cref="DescribeSkillScanAlertListResponse"/></returns>
        public Task<DescribeSkillScanAlertListResponse> DescribeSkillScanAlertList(DescribeSkillScanAlertListRequest req)
        {
            return InternalRequestAsync<DescribeSkillScanAlertListResponse>(req, "DescribeSkillScanAlertList");
        }

        /// <summary>
        /// 查询 Skill 安全检测告警列表，支持分页、过滤和排序
        /// </summary>
        /// <param name="req"><see cref="DescribeSkillScanAlertListRequest"/></param>
        /// <returns><see cref="DescribeSkillScanAlertListResponse"/></returns>
        public DescribeSkillScanAlertListResponse DescribeSkillScanAlertListSync(DescribeSkillScanAlertListRequest req)
        {
            return InternalRequestAsync<DescribeSkillScanAlertListResponse>(req, "DescribeSkillScanAlertList")
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
        /// 获取TCR实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTCRInstanceListRequest"/></param>
        /// <returns><see cref="DescribeTCRInstanceListResponse"/></returns>
        public Task<DescribeTCRInstanceListResponse> DescribeTCRInstanceList(DescribeTCRInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeTCRInstanceListResponse>(req, "DescribeTCRInstanceList");
        }

        /// <summary>
        /// 获取TCR实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTCRInstanceListRequest"/></param>
        /// <returns><see cref="DescribeTCRInstanceListResponse"/></returns>
        public DescribeTCRInstanceListResponse DescribeTCRInstanceListSync(DescribeTCRInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeTCRInstanceListResponse>(req, "DescribeTCRInstanceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 打标策略生效资产列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTagRuleAssetsRequest"/></param>
        /// <returns><see cref="DescribeTagRuleAssetsResponse"/></returns>
        public Task<DescribeTagRuleAssetsResponse> DescribeTagRuleAssets(DescribeTagRuleAssetsRequest req)
        {
            return InternalRequestAsync<DescribeTagRuleAssetsResponse>(req, "DescribeTagRuleAssets");
        }

        /// <summary>
        /// 打标策略生效资产列表
        /// </summary>
        /// <param name="req"><see cref="DescribeTagRuleAssetsRequest"/></param>
        /// <returns><see cref="DescribeTagRuleAssetsResponse"/></returns>
        public DescribeTagRuleAssetsResponse DescribeTagRuleAssetsSync(DescribeTagRuleAssetsRequest req)
        {
            return InternalRequestAsync<DescribeTagRuleAssetsResponse>(req, "DescribeTagRuleAssets")
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
        /// 获取扫描预消耗配额
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskPredictCostQuotaRequest"/></param>
        /// <returns><see cref="DescribeTaskPredictCostQuotaResponse"/></returns>
        public Task<DescribeTaskPredictCostQuotaResponse> DescribeTaskPredictCostQuota(DescribeTaskPredictCostQuotaRequest req)
        {
            return InternalRequestAsync<DescribeTaskPredictCostQuotaResponse>(req, "DescribeTaskPredictCostQuota");
        }

        /// <summary>
        /// 获取扫描预消耗配额
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskPredictCostQuotaRequest"/></param>
        /// <returns><see cref="DescribeTaskPredictCostQuotaResponse"/></returns>
        public DescribeTaskPredictCostQuotaResponse DescribeTaskPredictCostQuotaSync(DescribeTaskPredictCostQuotaRequest req)
        {
            return InternalRequestAsync<DescribeTaskPredictCostQuotaResponse>(req, "DescribeTaskPredictCostQuota")
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
        /// 查询用户行为分析的行为概览
        /// </summary>
        /// <param name="req"><see cref="DescribeUebaBehaviorSummaryRequest"/></param>
        /// <returns><see cref="DescribeUebaBehaviorSummaryResponse"/></returns>
        public Task<DescribeUebaBehaviorSummaryResponse> DescribeUebaBehaviorSummary(DescribeUebaBehaviorSummaryRequest req)
        {
            return InternalRequestAsync<DescribeUebaBehaviorSummaryResponse>(req, "DescribeUebaBehaviorSummary");
        }

        /// <summary>
        /// 查询用户行为分析的行为概览
        /// </summary>
        /// <param name="req"><see cref="DescribeUebaBehaviorSummaryRequest"/></param>
        /// <returns><see cref="DescribeUebaBehaviorSummaryResponse"/></returns>
        public DescribeUebaBehaviorSummaryResponse DescribeUebaBehaviorSummarySync(DescribeUebaBehaviorSummaryRequest req)
        {
            return InternalRequestAsync<DescribeUebaBehaviorSummaryResponse>(req, "DescribeUebaBehaviorSummary")
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
        /// 获取用户行为分析模块的用户概览
        /// </summary>
        /// <param name="req"><see cref="DescribeUebaUserSummaryRequest"/></param>
        /// <returns><see cref="DescribeUebaUserSummaryResponse"/></returns>
        public Task<DescribeUebaUserSummaryResponse> DescribeUebaUserSummary(DescribeUebaUserSummaryRequest req)
        {
            return InternalRequestAsync<DescribeUebaUserSummaryResponse>(req, "DescribeUebaUserSummary");
        }

        /// <summary>
        /// 获取用户行为分析模块的用户概览
        /// </summary>
        /// <param name="req"><see cref="DescribeUebaUserSummaryRequest"/></param>
        /// <returns><see cref="DescribeUebaUserSummaryResponse"/></returns>
        public DescribeUebaUserSummaryResponse DescribeUebaUserSummarySync(DescribeUebaUserSummaryRequest req)
        {
            return InternalRequestAsync<DescribeUebaUserSummaryResponse>(req, "DescribeUebaUserSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取账号CSPM信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserCSPMInfoListRequest"/></param>
        /// <returns><see cref="DescribeUserCSPMInfoListResponse"/></returns>
        public Task<DescribeUserCSPMInfoListResponse> DescribeUserCSPMInfoList(DescribeUserCSPMInfoListRequest req)
        {
            return InternalRequestAsync<DescribeUserCSPMInfoListResponse>(req, "DescribeUserCSPMInfoList");
        }

        /// <summary>
        /// 获取账号CSPM信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserCSPMInfoListRequest"/></param>
        /// <returns><see cref="DescribeUserCSPMInfoListResponse"/></returns>
        public DescribeUserCSPMInfoListResponse DescribeUserCSPMInfoListSync(DescribeUserCSPMInfoListRequest req)
        {
            return InternalRequestAsync<DescribeUserCSPMInfoListResponse>(req, "DescribeUserCSPMInfoList")
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
        /// 用户CSPM配额信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserInfoRequest"/></param>
        /// <returns><see cref="DescribeUserInfoResponse"/></returns>
        public Task<DescribeUserInfoResponse> DescribeUserInfo(DescribeUserInfoRequest req)
        {
            return InternalRequestAsync<DescribeUserInfoResponse>(req, "DescribeUserInfo");
        }

        /// <summary>
        /// 用户CSPM配额信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserInfoRequest"/></param>
        /// <returns><see cref="DescribeUserInfoResponse"/></returns>
        public DescribeUserInfoResponse DescribeUserInfoSync(DescribeUserInfoRequest req)
        {
            return InternalRequestAsync<DescribeUserInfoResponse>(req, "DescribeUserInfo")
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
        /// 获取病毒库及POC的更新信息
        /// </summary>
        /// <param name="req"><see cref="DescribeVdbAndPocInfoRequest"/></param>
        /// <returns><see cref="DescribeVdbAndPocInfoResponse"/></returns>
        public Task<DescribeVdbAndPocInfoResponse> DescribeVdbAndPocInfo(DescribeVdbAndPocInfoRequest req)
        {
            return InternalRequestAsync<DescribeVdbAndPocInfoResponse>(req, "DescribeVdbAndPocInfo");
        }

        /// <summary>
        /// 获取病毒库及POC的更新信息
        /// </summary>
        /// <param name="req"><see cref="DescribeVdbAndPocInfoRequest"/></param>
        /// <returns><see cref="DescribeVdbAndPocInfoResponse"/></returns>
        public DescribeVdbAndPocInfoResponse DescribeVdbAndPocInfoSync(DescribeVdbAndPocInfoRequest req)
        {
            return InternalRequestAsync<DescribeVdbAndPocInfoResponse>(req, "DescribeVdbAndPocInfo")
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
        /// 获取漏洞组件关联主机
        /// </summary>
        /// <param name="req"><see cref="DescribeVulComponentRelateHostRequest"/></param>
        /// <returns><see cref="DescribeVulComponentRelateHostResponse"/></returns>
        public Task<DescribeVulComponentRelateHostResponse> DescribeVulComponentRelateHost(DescribeVulComponentRelateHostRequest req)
        {
            return InternalRequestAsync<DescribeVulComponentRelateHostResponse>(req, "DescribeVulComponentRelateHost");
        }

        /// <summary>
        /// 获取漏洞组件关联主机
        /// </summary>
        /// <param name="req"><see cref="DescribeVulComponentRelateHostRequest"/></param>
        /// <returns><see cref="DescribeVulComponentRelateHostResponse"/></returns>
        public DescribeVulComponentRelateHostResponse DescribeVulComponentRelateHostSync(DescribeVulComponentRelateHostRequest req)
        {
            return InternalRequestAsync<DescribeVulComponentRelateHostResponse>(req, "DescribeVulComponentRelateHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定漏洞修复任务的详情信息，包含每台主机的修复状态、快照状态等明细数据，支持分页和筛选。
        /// </summary>
        /// <param name="req"><see cref="DescribeVulFixTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeVulFixTaskDetailResponse"/></returns>
        public Task<DescribeVulFixTaskDetailResponse> DescribeVulFixTaskDetail(DescribeVulFixTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeVulFixTaskDetailResponse>(req, "DescribeVulFixTaskDetail");
        }

        /// <summary>
        /// 查询指定漏洞修复任务的详情信息，包含每台主机的修复状态、快照状态等明细数据，支持分页和筛选。
        /// </summary>
        /// <param name="req"><see cref="DescribeVulFixTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeVulFixTaskDetailResponse"/></returns>
        public DescribeVulFixTaskDetailResponse DescribeVulFixTaskDetailSync(DescribeVulFixTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeVulFixTaskDetailResponse>(req, "DescribeVulFixTaskDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 分页查询漏洞修复任务记录列表，支持按修复状态、时间范围等条件筛选，展示每个修复任务的概要信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeVulFixTaskListRequest"/></param>
        /// <returns><see cref="DescribeVulFixTaskListResponse"/></returns>
        public Task<DescribeVulFixTaskListResponse> DescribeVulFixTaskList(DescribeVulFixTaskListRequest req)
        {
            return InternalRequestAsync<DescribeVulFixTaskListResponse>(req, "DescribeVulFixTaskList");
        }

        /// <summary>
        /// 分页查询漏洞修复任务记录列表，支持按修复状态、时间范围等条件筛选，展示每个修复任务的概要信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeVulFixTaskListRequest"/></param>
        /// <returns><see cref="DescribeVulFixTaskListResponse"/></returns>
        public DescribeVulFixTaskListResponse DescribeVulFixTaskListSync(DescribeVulFixTaskListRequest req)
        {
            return InternalRequestAsync<DescribeVulFixTaskListResponse>(req, "DescribeVulFixTaskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指定漏洞可以被修复的主机列表。在用户提交修复任务前，需要先查询哪些主机支持自动修复，为用户选择修复目标提供数据支持。
        /// </summary>
        /// <param name="req"><see cref="DescribeVulFixableMachineListRequest"/></param>
        /// <returns><see cref="DescribeVulFixableMachineListResponse"/></returns>
        public Task<DescribeVulFixableMachineListResponse> DescribeVulFixableMachineList(DescribeVulFixableMachineListRequest req)
        {
            return InternalRequestAsync<DescribeVulFixableMachineListResponse>(req, "DescribeVulFixableMachineList");
        }

        /// <summary>
        /// 查询指定漏洞可以被修复的主机列表。在用户提交修复任务前，需要先查询哪些主机支持自动修复，为用户选择修复目标提供数据支持。
        /// </summary>
        /// <param name="req"><see cref="DescribeVulFixableMachineListRequest"/></param>
        /// <returns><see cref="DescribeVulFixableMachineListResponse"/></returns>
        public DescribeVulFixableMachineListResponse DescribeVulFixableMachineListSync(DescribeVulFixableMachineListRequest req)
        {
            return InternalRequestAsync<DescribeVulFixableMachineListResponse>(req, "DescribeVulFixableMachineList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询某个已修复漏洞在指定主机上的修复详情，包含漏洞基本信息、修复主机信息以及关联组件&路径的详细列表（组件名称、命中版本、关联路径、修复命令）。
        /// </summary>
        /// <param name="req"><see cref="DescribeVulFixedHostDetailRequest"/></param>
        /// <returns><see cref="DescribeVulFixedHostDetailResponse"/></returns>
        public Task<DescribeVulFixedHostDetailResponse> DescribeVulFixedHostDetail(DescribeVulFixedHostDetailRequest req)
        {
            return InternalRequestAsync<DescribeVulFixedHostDetailResponse>(req, "DescribeVulFixedHostDetail");
        }

        /// <summary>
        /// 查询某个已修复漏洞在指定主机上的修复详情，包含漏洞基本信息、修复主机信息以及关联组件&路径的详细列表（组件名称、命中版本、关联路径、修复命令）。
        /// </summary>
        /// <param name="req"><see cref="DescribeVulFixedHostDetailRequest"/></param>
        /// <returns><see cref="DescribeVulFixedHostDetailResponse"/></returns>
        public DescribeVulFixedHostDetailResponse DescribeVulFixedHostDetailSync(DescribeVulFixedHostDetailRequest req)
        {
            return InternalRequestAsync<DescribeVulFixedHostDetailResponse>(req, "DescribeVulFixedHostDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询已被修复的漏洞列表，展示修复成功的漏洞信息及修复情况统计，帮助用户了解修复成效。
        /// </summary>
        /// <param name="req"><see cref="DescribeVulFixedListRequest"/></param>
        /// <returns><see cref="DescribeVulFixedListResponse"/></returns>
        public Task<DescribeVulFixedListResponse> DescribeVulFixedList(DescribeVulFixedListRequest req)
        {
            return InternalRequestAsync<DescribeVulFixedListResponse>(req, "DescribeVulFixedList");
        }

        /// <summary>
        /// 查询已被修复的漏洞列表，展示修复成功的漏洞信息及修复情况统计，帮助用户了解修复成效。
        /// </summary>
        /// <param name="req"><see cref="DescribeVulFixedListRequest"/></param>
        /// <returns><see cref="DescribeVulFixedListResponse"/></returns>
        public DescribeVulFixedListResponse DescribeVulFixedListSync(DescribeVulFixedListRequest req)
        {
            return InternalRequestAsync<DescribeVulFixedListResponse>(req, "DescribeVulFixedList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取漏洞主机关联组件
        /// </summary>
        /// <param name="req"><see cref="DescribeVulHostRelateComponentRequest"/></param>
        /// <returns><see cref="DescribeVulHostRelateComponentResponse"/></returns>
        public Task<DescribeVulHostRelateComponentResponse> DescribeVulHostRelateComponent(DescribeVulHostRelateComponentRequest req)
        {
            return InternalRequestAsync<DescribeVulHostRelateComponentResponse>(req, "DescribeVulHostRelateComponent");
        }

        /// <summary>
        /// 获取漏洞主机关联组件
        /// </summary>
        /// <param name="req"><see cref="DescribeVulHostRelateComponentRequest"/></param>
        /// <returns><see cref="DescribeVulHostRelateComponentResponse"/></returns>
        public DescribeVulHostRelateComponentResponse DescribeVulHostRelateComponentSync(DescribeVulHostRelateComponentRequest req)
        {
            return InternalRequestAsync<DescribeVulHostRelateComponentResponse>(req, "DescribeVulHostRelateComponent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取漏洞忽略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulIgnoreRuleListRequest"/></param>
        /// <returns><see cref="DescribeVulIgnoreRuleListResponse"/></returns>
        public Task<DescribeVulIgnoreRuleListResponse> DescribeVulIgnoreRuleList(DescribeVulIgnoreRuleListRequest req)
        {
            return InternalRequestAsync<DescribeVulIgnoreRuleListResponse>(req, "DescribeVulIgnoreRuleList");
        }

        /// <summary>
        /// 获取漏洞忽略列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulIgnoreRuleListRequest"/></param>
        /// <returns><see cref="DescribeVulIgnoreRuleListResponse"/></returns>
        public DescribeVulIgnoreRuleListResponse DescribeVulIgnoreRuleListSync(DescribeVulIgnoreRuleListRequest req)
        {
            return InternalRequestAsync<DescribeVulIgnoreRuleListResponse>(req, "DescribeVulIgnoreRuleList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取漏洞列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulItemListRequest"/></param>
        /// <returns><see cref="DescribeVulItemListResponse"/></returns>
        public Task<DescribeVulItemListResponse> DescribeVulItemList(DescribeVulItemListRequest req)
        {
            return InternalRequestAsync<DescribeVulItemListResponse>(req, "DescribeVulItemList");
        }

        /// <summary>
        /// 获取漏洞列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulItemListRequest"/></param>
        /// <returns><see cref="DescribeVulItemListResponse"/></returns>
        public DescribeVulItemListResponse DescribeVulItemListSync(DescribeVulItemListRequest req)
        {
            return InternalRequestAsync<DescribeVulItemListResponse>(req, "DescribeVulItemList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取漏洞标签列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulLabelListRequest"/></param>
        /// <returns><see cref="DescribeVulLabelListResponse"/></returns>
        public Task<DescribeVulLabelListResponse> DescribeVulLabelList(DescribeVulLabelListRequest req)
        {
            return InternalRequestAsync<DescribeVulLabelListResponse>(req, "DescribeVulLabelList");
        }

        /// <summary>
        /// 获取漏洞标签列表
        /// </summary>
        /// <param name="req"><see cref="DescribeVulLabelListRequest"/></param>
        /// <returns><see cref="DescribeVulLabelListResponse"/></returns>
        public DescribeVulLabelListResponse DescribeVulLabelListSync(DescribeVulLabelListRequest req)
        {
            return InternalRequestAsync<DescribeVulLabelListResponse>(req, "DescribeVulLabelList")
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
        /// 获取漏洞关联组件
        /// </summary>
        /// <param name="req"><see cref="DescribeVulRiskRelateComponentRequest"/></param>
        /// <returns><see cref="DescribeVulRiskRelateComponentResponse"/></returns>
        public Task<DescribeVulRiskRelateComponentResponse> DescribeVulRiskRelateComponent(DescribeVulRiskRelateComponentRequest req)
        {
            return InternalRequestAsync<DescribeVulRiskRelateComponentResponse>(req, "DescribeVulRiskRelateComponent");
        }

        /// <summary>
        /// 获取漏洞关联组件
        /// </summary>
        /// <param name="req"><see cref="DescribeVulRiskRelateComponentRequest"/></param>
        /// <returns><see cref="DescribeVulRiskRelateComponentResponse"/></returns>
        public DescribeVulRiskRelateComponentResponse DescribeVulRiskRelateComponentSync(DescribeVulRiskRelateComponentRequest req)
        {
            return InternalRequestAsync<DescribeVulRiskRelateComponentResponse>(req, "DescribeVulRiskRelateComponent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取漏洞或KB关联的主机
        /// </summary>
        /// <param name="req"><see cref="DescribeVulRiskRelateHostRequest"/></param>
        /// <returns><see cref="DescribeVulRiskRelateHostResponse"/></returns>
        public Task<DescribeVulRiskRelateHostResponse> DescribeVulRiskRelateHost(DescribeVulRiskRelateHostRequest req)
        {
            return InternalRequestAsync<DescribeVulRiskRelateHostResponse>(req, "DescribeVulRiskRelateHost");
        }

        /// <summary>
        /// 获取漏洞或KB关联的主机
        /// </summary>
        /// <param name="req"><see cref="DescribeVulRiskRelateHostRequest"/></param>
        /// <returns><see cref="DescribeVulRiskRelateHostResponse"/></returns>
        public DescribeVulRiskRelateHostResponse DescribeVulRiskRelateHostSync(DescribeVulRiskRelateHostRequest req)
        {
            return InternalRequestAsync<DescribeVulRiskRelateHostResponse>(req, "DescribeVulRiskRelateHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取漏洞扫描（周期扫描）
        /// </summary>
        /// <param name="req"><see cref="DescribeVulScanPeriodicRequest"/></param>
        /// <returns><see cref="DescribeVulScanPeriodicResponse"/></returns>
        public Task<DescribeVulScanPeriodicResponse> DescribeVulScanPeriodic(DescribeVulScanPeriodicRequest req)
        {
            return InternalRequestAsync<DescribeVulScanPeriodicResponse>(req, "DescribeVulScanPeriodic");
        }

        /// <summary>
        /// 获取漏洞扫描（周期扫描）
        /// </summary>
        /// <param name="req"><see cref="DescribeVulScanPeriodicRequest"/></param>
        /// <returns><see cref="DescribeVulScanPeriodicResponse"/></returns>
        public DescribeVulScanPeriodicResponse DescribeVulScanPeriodicSync(DescribeVulScanPeriodicRequest req)
        {
            return InternalRequestAsync<DescribeVulScanPeriodicResponse>(req, "DescribeVulScanPeriodic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取扫描漏洞任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeVulScanTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeVulScanTaskDetailResponse"/></returns>
        public Task<DescribeVulScanTaskDetailResponse> DescribeVulScanTaskDetail(DescribeVulScanTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeVulScanTaskDetailResponse>(req, "DescribeVulScanTaskDetail");
        }

        /// <summary>
        /// 获取扫描漏洞任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeVulScanTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeVulScanTaskDetailResponse"/></returns>
        public DescribeVulScanTaskDetailResponse DescribeVulScanTaskDetailSync(DescribeVulScanTaskDetailRequest req)
        {
            return InternalRequestAsync<DescribeVulScanTaskDetailResponse>(req, "DescribeVulScanTaskDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取漏洞扫描任务记录
        /// </summary>
        /// <param name="req"><see cref="DescribeVulScanTaskListRequest"/></param>
        /// <returns><see cref="DescribeVulScanTaskListResponse"/></returns>
        public Task<DescribeVulScanTaskListResponse> DescribeVulScanTaskList(DescribeVulScanTaskListRequest req)
        {
            return InternalRequestAsync<DescribeVulScanTaskListResponse>(req, "DescribeVulScanTaskList");
        }

        /// <summary>
        /// 获取漏洞扫描任务记录
        /// </summary>
        /// <param name="req"><see cref="DescribeVulScanTaskListRequest"/></param>
        /// <returns><see cref="DescribeVulScanTaskListResponse"/></returns>
        public DescribeVulScanTaskListResponse DescribeVulScanTaskListSync(DescribeVulScanTaskListRequest req)
        {
            return InternalRequestAsync<DescribeVulScanTaskListResponse>(req, "DescribeVulScanTaskList")
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
        /// 分页查询当前租户下的通知策略列表，对应「通知中心 - 机器人通知 - 通知策略配置」Tab 的表格。返回的字段为「行展示」所需的精简信息。完整配置在编辑场景下使用 DescribeWebhookPolicy。每租户最多 100 个通知策略
        /// </summary>
        /// <param name="req"><see cref="DescribeWebhookPolicyListRequest"/></param>
        /// <returns><see cref="DescribeWebhookPolicyListResponse"/></returns>
        public Task<DescribeWebhookPolicyListResponse> DescribeWebhookPolicyList(DescribeWebhookPolicyListRequest req)
        {
            return InternalRequestAsync<DescribeWebhookPolicyListResponse>(req, "DescribeWebhookPolicyList");
        }

        /// <summary>
        /// 分页查询当前租户下的通知策略列表，对应「通知中心 - 机器人通知 - 通知策略配置」Tab 的表格。返回的字段为「行展示」所需的精简信息。完整配置在编辑场景下使用 DescribeWebhookPolicy。每租户最多 100 个通知策略
        /// </summary>
        /// <param name="req"><see cref="DescribeWebhookPolicyListRequest"/></param>
        /// <returns><see cref="DescribeWebhookPolicyListResponse"/></returns>
        public DescribeWebhookPolicyListResponse DescribeWebhookPolicyListSync(DescribeWebhookPolicyListRequest req)
        {
            return InternalRequestAsync<DescribeWebhookPolicyListResponse>(req, "DescribeWebhookPolicyList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 分页查询当前租户下的接收机器人列表，对应「通知中心 - 机器人通知 - 接收机器人管理」Tab 的表格。每租户最多 50 个机器人
        /// </summary>
        /// <param name="req"><see cref="DescribeWebhookReceiverListRequest"/></param>
        /// <returns><see cref="DescribeWebhookReceiverListResponse"/></returns>
        public Task<DescribeWebhookReceiverListResponse> DescribeWebhookReceiverList(DescribeWebhookReceiverListRequest req)
        {
            return InternalRequestAsync<DescribeWebhookReceiverListResponse>(req, "DescribeWebhookReceiverList");
        }

        /// <summary>
        /// 分页查询当前租户下的接收机器人列表，对应「通知中心 - 机器人通知 - 接收机器人管理」Tab 的表格。每租户最多 50 个机器人
        /// </summary>
        /// <param name="req"><see cref="DescribeWebhookReceiverListRequest"/></param>
        /// <returns><see cref="DescribeWebhookReceiverListResponse"/></returns>
        public DescribeWebhookReceiverListResponse DescribeWebhookReceiverListSync(DescribeWebhookReceiverListRequest req)
        {
            return InternalRequestAsync<DescribeWebhookReceiverListResponse>(req, "DescribeWebhookReceiverList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停用AI 定时任务。
        /// 
        /// 将指定的AI 定时任务状态设置为已停用，停用后任务将暂停自动执行。
        /// </summary>
        /// <param name="req"><see cref="DisableAIScheduleRequest"/></param>
        /// <returns><see cref="DisableAIScheduleResponse"/></returns>
        public Task<DisableAIScheduleResponse> DisableAISchedule(DisableAIScheduleRequest req)
        {
            return InternalRequestAsync<DisableAIScheduleResponse>(req, "DisableAISchedule");
        }

        /// <summary>
        /// 停用AI 定时任务。
        /// 
        /// 将指定的AI 定时任务状态设置为已停用，停用后任务将暂停自动执行。
        /// </summary>
        /// <param name="req"><see cref="DisableAIScheduleRequest"/></param>
        /// <returns><see cref="DisableAIScheduleResponse"/></returns>
        public DisableAIScheduleResponse DisableAIScheduleSync(DisableAIScheduleRequest req)
        {
            return InternalRequestAsync<DisableAIScheduleResponse>(req, "DisableAISchedule")
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
        /// 启用AI 定时任务。
        /// 
        /// 将指定的AI 定时任务状态设置为已启用，启用后任务将按触发器配置自动执行。
        /// </summary>
        /// <param name="req"><see cref="EnableAIScheduleRequest"/></param>
        /// <returns><see cref="EnableAIScheduleResponse"/></returns>
        public Task<EnableAIScheduleResponse> EnableAISchedule(EnableAIScheduleRequest req)
        {
            return InternalRequestAsync<EnableAIScheduleResponse>(req, "EnableAISchedule");
        }

        /// <summary>
        /// 启用AI 定时任务。
        /// 
        /// 将指定的AI 定时任务状态设置为已启用，启用后任务将按触发器配置自动执行。
        /// </summary>
        /// <param name="req"><see cref="EnableAIScheduleRequest"/></param>
        /// <returns><see cref="EnableAIScheduleResponse"/></returns>
        public EnableAIScheduleResponse EnableAIScheduleSync(EnableAIScheduleRequest req)
        {
            return InternalRequestAsync<EnableAIScheduleResponse>(req, "EnableAISchedule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 导出CSIP扫描任务主机详情为Excel文件，异步生成后通过DescribeExportMachines查询下载地址
        /// </summary>
        /// <param name="req"><see cref="ExportCSIPMalwareScanTaskDetailRequest"/></param>
        /// <returns><see cref="ExportCSIPMalwareScanTaskDetailResponse"/></returns>
        public Task<ExportCSIPMalwareScanTaskDetailResponse> ExportCSIPMalwareScanTaskDetail(ExportCSIPMalwareScanTaskDetailRequest req)
        {
            return InternalRequestAsync<ExportCSIPMalwareScanTaskDetailResponse>(req, "ExportCSIPMalwareScanTaskDetail");
        }

        /// <summary>
        /// 导出CSIP扫描任务主机详情为Excel文件，异步生成后通过DescribeExportMachines查询下载地址
        /// </summary>
        /// <param name="req"><see cref="ExportCSIPMalwareScanTaskDetailRequest"/></param>
        /// <returns><see cref="ExportCSIPMalwareScanTaskDetailResponse"/></returns>
        public ExportCSIPMalwareScanTaskDetailResponse ExportCSIPMalwareScanTaskDetailSync(ExportCSIPMalwareScanTaskDetailRequest req)
        {
            return InternalRequestAsync<ExportCSIPMalwareScanTaskDetailResponse>(req, "ExportCSIPMalwareScanTaskDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 客户端设置主机列表导出
        /// </summary>
        /// <param name="req"><see cref="ExportClientSettingHostListRequest"/></param>
        /// <returns><see cref="ExportClientSettingHostListResponse"/></returns>
        public Task<ExportClientSettingHostListResponse> ExportClientSettingHostList(ExportClientSettingHostListRequest req)
        {
            return InternalRequestAsync<ExportClientSettingHostListResponse>(req, "ExportClientSettingHostList");
        }

        /// <summary>
        /// 客户端设置主机列表导出
        /// </summary>
        /// <param name="req"><see cref="ExportClientSettingHostListRequest"/></param>
        /// <returns><see cref="ExportClientSettingHostListResponse"/></returns>
        public ExportClientSettingHostListResponse ExportClientSettingHostListSync(ExportClientSettingHostListRequest req)
        {
            return InternalRequestAsync<ExportClientSettingHostListResponse>(req, "ExportClientSettingHostList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 导出EDR策略列表
        /// </summary>
        /// <param name="req"><see cref="ExportEDRRulesRequest"/></param>
        /// <returns><see cref="ExportEDRRulesResponse"/></returns>
        public Task<ExportEDRRulesResponse> ExportEDRRules(ExportEDRRulesRequest req)
        {
            return InternalRequestAsync<ExportEDRRulesResponse>(req, "ExportEDRRules");
        }

        /// <summary>
        /// 导出EDR策略列表
        /// </summary>
        /// <param name="req"><see cref="ExportEDRRulesRequest"/></param>
        /// <returns><see cref="ExportEDRRulesResponse"/></returns>
        public ExportEDRRulesResponse ExportEDRRulesSync(ExportEDRRulesRequest req)
        {
            return InternalRequestAsync<ExportEDRRulesResponse>(req, "ExportEDRRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于异步导出数据量大的日志文件
        /// </summary>
        /// <param name="req"><see cref="ExportTasksRequest"/></param>
        /// <returns><see cref="ExportTasksResponse"/></returns>
        public Task<ExportTasksResponse> ExportTasks(ExportTasksRequest req)
        {
            return InternalRequestAsync<ExportTasksResponse>(req, "ExportTasks");
        }

        /// <summary>
        /// 用于异步导出数据量大的日志文件
        /// </summary>
        /// <param name="req"><see cref="ExportTasksRequest"/></param>
        /// <returns><see cref="ExportTasksResponse"/></returns>
        public ExportTasksResponse ExportTasksSync(ExportTasksRequest req)
        {
            return InternalRequestAsync<ExportTasksResponse>(req, "ExportTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 安装集群容器安全Agent（平行容器方式安装 Agent）。
        /// 
        /// capi 层处理流程：
        /// 1. 按 ClusterCaMD5List 查询 DB 集群列表（仅用于解析每个集群归属的 appid，不做存在性/类型校验）
        /// 2. 按 appid 分组透传到接入侧 ClusterInstall RPC
        /// 
        /// 说明（容器资产改版 2026 H1）：本接口为透传接口，capi 层不对 ClusterCaMD5 做存在性/类型/格式校验；DB 中未命中的 ClusterCaMD5 静默跳过、不报错。
        /// </summary>
        /// <param name="req"><see cref="InstallClusterAgentRequest"/></param>
        /// <returns><see cref="InstallClusterAgentResponse"/></returns>
        public Task<InstallClusterAgentResponse> InstallClusterAgent(InstallClusterAgentRequest req)
        {
            return InternalRequestAsync<InstallClusterAgentResponse>(req, "InstallClusterAgent");
        }

        /// <summary>
        /// 安装集群容器安全Agent（平行容器方式安装 Agent）。
        /// 
        /// capi 层处理流程：
        /// 1. 按 ClusterCaMD5List 查询 DB 集群列表（仅用于解析每个集群归属的 appid，不做存在性/类型校验）
        /// 2. 按 appid 分组透传到接入侧 ClusterInstall RPC
        /// 
        /// 说明（容器资产改版 2026 H1）：本接口为透传接口，capi 层不对 ClusterCaMD5 做存在性/类型/格式校验；DB 中未命中的 ClusterCaMD5 静默跳过、不报错。
        /// </summary>
        /// <param name="req"><see cref="InstallClusterAgentRequest"/></param>
        /// <returns><see cref="InstallClusterAgentResponse"/></returns>
        public InstallClusterAgentResponse InstallClusterAgentSync(InstallClusterAgentRequest req)
        {
            return InternalRequestAsync<InstallClusterAgentResponse>(req, "InstallClusterAgent")
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
        /// 修改AI 定时任务。
        /// 
        /// 支持部分更新，仅更新传入的可选字段。触发器列表通过 UpdateTriggers 标志控制是否全量替换。
        /// </summary>
        /// <param name="req"><see cref="ModifyAIScheduleRequest"/></param>
        /// <returns><see cref="ModifyAIScheduleResponse"/></returns>
        public Task<ModifyAIScheduleResponse> ModifyAISchedule(ModifyAIScheduleRequest req)
        {
            return InternalRequestAsync<ModifyAIScheduleResponse>(req, "ModifyAISchedule");
        }

        /// <summary>
        /// 修改AI 定时任务。
        /// 
        /// 支持部分更新，仅更新传入的可选字段。触发器列表通过 UpdateTriggers 标志控制是否全量替换。
        /// </summary>
        /// <param name="req"><see cref="ModifyAIScheduleRequest"/></param>
        /// <returns><see cref="ModifyAIScheduleResponse"/></returns>
        public ModifyAIScheduleResponse ModifyAIScheduleSync(ModifyAIScheduleRequest req)
        {
            return InternalRequestAsync<ModifyAIScheduleResponse>(req, "ModifyAISchedule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改客户端日志采集配置（CSIP专属），支持设置日志采集类型和生效资产范围
        /// </summary>
        /// <param name="req"><see cref="ModifyAgentConfigSettingRequest"/></param>
        /// <returns><see cref="ModifyAgentConfigSettingResponse"/></returns>
        public Task<ModifyAgentConfigSettingResponse> ModifyAgentConfigSetting(ModifyAgentConfigSettingRequest req)
        {
            return InternalRequestAsync<ModifyAgentConfigSettingResponse>(req, "ModifyAgentConfigSetting");
        }

        /// <summary>
        /// 修改客户端日志采集配置（CSIP专属），支持设置日志采集类型和生效资产范围
        /// </summary>
        /// <param name="req"><see cref="ModifyAgentConfigSettingRequest"/></param>
        /// <returns><see cref="ModifyAgentConfigSettingResponse"/></returns>
        public ModifyAgentConfigSettingResponse ModifyAgentConfigSettingSync(ModifyAgentConfigSettingRequest req)
        {
            return InternalRequestAsync<ModifyAgentConfigSettingResponse>(req, "ModifyAgentConfigSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置客户端运行模式以及配置
        /// </summary>
        /// <param name="req"><see cref="ModifyAgentRunModeRequest"/></param>
        /// <returns><see cref="ModifyAgentRunModeResponse"/></returns>
        public Task<ModifyAgentRunModeResponse> ModifyAgentRunMode(ModifyAgentRunModeRequest req)
        {
            return InternalRequestAsync<ModifyAgentRunModeResponse>(req, "ModifyAgentRunMode");
        }

        /// <summary>
        /// 设置客户端运行模式以及配置
        /// </summary>
        /// <param name="req"><see cref="ModifyAgentRunModeRequest"/></param>
        /// <returns><see cref="ModifyAgentRunModeResponse"/></returns>
        public ModifyAgentRunModeResponse ModifyAgentRunModeSync(ModifyAgentRunModeRequest req)
        {
            return InternalRequestAsync<ModifyAgentRunModeResponse>(req, "ModifyAgentRunMode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改客户端运行策略（策略组），支持设置自定义策略及关联机器列表
        /// </summary>
        /// <param name="req"><see cref="ModifyAgentRunPolicyRequest"/></param>
        /// <returns><see cref="ModifyAgentRunPolicyResponse"/></returns>
        public Task<ModifyAgentRunPolicyResponse> ModifyAgentRunPolicy(ModifyAgentRunPolicyRequest req)
        {
            return InternalRequestAsync<ModifyAgentRunPolicyResponse>(req, "ModifyAgentRunPolicy");
        }

        /// <summary>
        /// 修改客户端运行策略（策略组），支持设置自定义策略及关联机器列表
        /// </summary>
        /// <param name="req"><see cref="ModifyAgentRunPolicyRequest"/></param>
        /// <returns><see cref="ModifyAgentRunPolicyResponse"/></returns>
        public ModifyAgentRunPolicyResponse ModifyAgentRunPolicySync(ModifyAgentRunPolicyRequest req)
        {
            return InternalRequestAsync<ModifyAgentRunPolicyResponse>(req, "ModifyAgentRunPolicy")
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
        /// 标记资产是否核心
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetCoreAttributeRequest"/></param>
        /// <returns><see cref="ModifyAssetCoreAttributeResponse"/></returns>
        public Task<ModifyAssetCoreAttributeResponse> ModifyAssetCoreAttribute(ModifyAssetCoreAttributeRequest req)
        {
            return InternalRequestAsync<ModifyAssetCoreAttributeResponse>(req, "ModifyAssetCoreAttribute");
        }

        /// <summary>
        /// 标记资产是否核心
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetCoreAttributeRequest"/></param>
        /// <returns><see cref="ModifyAssetCoreAttributeResponse"/></returns>
        public ModifyAssetCoreAttributeResponse ModifyAssetCoreAttributeSync(ModifyAssetCoreAttributeRequest req)
        {
            return InternalRequestAsync<ModifyAssetCoreAttributeResponse>(req, "ModifyAssetCoreAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新资产搜索视图
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetFilterViewRequest"/></param>
        /// <returns><see cref="ModifyAssetFilterViewResponse"/></returns>
        public Task<ModifyAssetFilterViewResponse> ModifyAssetFilterView(ModifyAssetFilterViewRequest req)
        {
            return InternalRequestAsync<ModifyAssetFilterViewResponse>(req, "ModifyAssetFilterView");
        }

        /// <summary>
        /// 更新资产搜索视图
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetFilterViewRequest"/></param>
        /// <returns><see cref="ModifyAssetFilterViewResponse"/></returns>
        public ModifyAssetFilterViewResponse ModifyAssetFilterViewSync(ModifyAssetFilterViewRequest req)
        {
            return InternalRequestAsync<ModifyAssetFilterViewResponse>(req, "ModifyAssetFilterView")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑资产标签
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetTagRequest"/></param>
        /// <returns><see cref="ModifyAssetTagResponse"/></returns>
        public Task<ModifyAssetTagResponse> ModifyAssetTag(ModifyAssetTagRequest req)
        {
            return InternalRequestAsync<ModifyAssetTagResponse>(req, "ModifyAssetTag");
        }

        /// <summary>
        /// 编辑资产标签
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetTagRequest"/></param>
        /// <returns><see cref="ModifyAssetTagResponse"/></returns>
        public ModifyAssetTagResponse ModifyAssetTagSync(ModifyAssetTagRequest req)
        {
            return InternalRequestAsync<ModifyAssetTagResponse>(req, "ModifyAssetTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 操作资产编辑标签
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetTagsRequest"/></param>
        /// <returns><see cref="ModifyAssetTagsResponse"/></returns>
        public Task<ModifyAssetTagsResponse> ModifyAssetTags(ModifyAssetTagsRequest req)
        {
            return InternalRequestAsync<ModifyAssetTagsResponse>(req, "ModifyAssetTags");
        }

        /// <summary>
        /// 操作资产编辑标签
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetTagsRequest"/></param>
        /// <returns><see cref="ModifyAssetTagsResponse"/></returns>
        public ModifyAssetTagsResponse ModifyAssetTagsSync(ModifyAssetTagsRequest req)
        {
            return InternalRequestAsync<ModifyAssetTagsResponse>(req, "ModifyAssetTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 操作资产编辑标签
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetTagsByAssetInfoRequest"/></param>
        /// <returns><see cref="ModifyAssetTagsByAssetInfoResponse"/></returns>
        public Task<ModifyAssetTagsByAssetInfoResponse> ModifyAssetTagsByAssetInfo(ModifyAssetTagsByAssetInfoRequest req)
        {
            return InternalRequestAsync<ModifyAssetTagsByAssetInfoResponse>(req, "ModifyAssetTagsByAssetInfo");
        }

        /// <summary>
        /// 操作资产编辑标签
        /// </summary>
        /// <param name="req"><see cref="ModifyAssetTagsByAssetInfoRequest"/></param>
        /// <returns><see cref="ModifyAssetTagsByAssetInfoResponse"/></returns>
        public ModifyAssetTagsByAssetInfoResponse ModifyAssetTagsByAssetInfoSync(ModifyAssetTagsByAssetInfoRequest req)
        {
            return InternalRequestAsync<ModifyAssetTagsByAssetInfoResponse>(req, "ModifyAssetTagsByAssetInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改爆破阻断模式
        /// </summary>
        /// <param name="req"><see cref="ModifyBanModeRequest"/></param>
        /// <returns><see cref="ModifyBanModeResponse"/></returns>
        public Task<ModifyBanModeResponse> ModifyBanMode(ModifyBanModeRequest req)
        {
            return InternalRequestAsync<ModifyBanModeResponse>(req, "ModifyBanMode");
        }

        /// <summary>
        /// 修改爆破阻断模式
        /// </summary>
        /// <param name="req"><see cref="ModifyBanModeRequest"/></param>
        /// <returns><see cref="ModifyBanModeResponse"/></returns>
        public ModifyBanModeResponse ModifyBanModeSync(ModifyBanModeRequest req)
        {
            return InternalRequestAsync<ModifyBanModeResponse>(req, "ModifyBanMode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新建或编辑一条基线策略。Policy.ID 为 0 视为新建，非 0 视为编辑；新建/编辑时 Name 必填，CheckAssetType 与 Type 需符合 CheckAssetType / PolicyType 枚举。
        /// </summary>
        /// <param name="req"><see cref="ModifyBaselinePolicyRequest"/></param>
        /// <returns><see cref="ModifyBaselinePolicyResponse"/></returns>
        public Task<ModifyBaselinePolicyResponse> ModifyBaselinePolicy(ModifyBaselinePolicyRequest req)
        {
            return InternalRequestAsync<ModifyBaselinePolicyResponse>(req, "ModifyBaselinePolicy");
        }

        /// <summary>
        /// 新建或编辑一条基线策略。Policy.ID 为 0 视为新建，非 0 视为编辑；新建/编辑时 Name 必填，CheckAssetType 与 Type 需符合 CheckAssetType / PolicyType 枚举。
        /// </summary>
        /// <param name="req"><see cref="ModifyBaselinePolicyRequest"/></param>
        /// <returns><see cref="ModifyBaselinePolicyResponse"/></returns>
        public ModifyBaselinePolicyResponse ModifyBaselinePolicySync(ModifyBaselinePolicyRequest req)
        {
            return InternalRequestAsync<ModifyBaselinePolicyResponse>(req, "ModifyBaselinePolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量启用或停用基线策略。停用后的策略将不再参与扫描与统计。
        /// </summary>
        /// <param name="req"><see cref="ModifyBaselinePolicyEnableRequest"/></param>
        /// <returns><see cref="ModifyBaselinePolicyEnableResponse"/></returns>
        public Task<ModifyBaselinePolicyEnableResponse> ModifyBaselinePolicyEnable(ModifyBaselinePolicyEnableRequest req)
        {
            return InternalRequestAsync<ModifyBaselinePolicyEnableResponse>(req, "ModifyBaselinePolicyEnable");
        }

        /// <summary>
        /// 批量启用或停用基线策略。停用后的策略将不再参与扫描与统计。
        /// </summary>
        /// <param name="req"><see cref="ModifyBaselinePolicyEnableRequest"/></param>
        /// <returns><see cref="ModifyBaselinePolicyEnableResponse"/></returns>
        public ModifyBaselinePolicyEnableResponse ModifyBaselinePolicyEnableSync(ModifyBaselinePolicyEnableRequest req)
        {
            return InternalRequestAsync<ModifyBaselinePolicyEnableResponse>(req, "ModifyBaselinePolicyEnable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新当前账号（管理员）的基线同步配置。AutoSync=true 时 TargetAppidList 不可为空，且元素不可为 0。
        /// </summary>
        /// <param name="req"><see cref="ModifyBaselineSyncConfRequest"/></param>
        /// <returns><see cref="ModifyBaselineSyncConfResponse"/></returns>
        public Task<ModifyBaselineSyncConfResponse> ModifyBaselineSyncConf(ModifyBaselineSyncConfRequest req)
        {
            return InternalRequestAsync<ModifyBaselineSyncConfResponse>(req, "ModifyBaselineSyncConf");
        }

        /// <summary>
        /// 更新当前账号（管理员）的基线同步配置。AutoSync=true 时 TargetAppidList 不可为空，且元素不可为 0。
        /// </summary>
        /// <param name="req"><see cref="ModifyBaselineSyncConfRequest"/></param>
        /// <returns><see cref="ModifyBaselineSyncConfResponse"/></returns>
        public ModifyBaselineSyncConfResponse ModifyBaselineSyncConfSync(ModifyBaselineSyncConfRequest req)
        {
            return InternalRequestAsync<ModifyBaselineSyncConfResponse>(req, "ModifyBaselineSyncConf")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新当前账号的用户级基线配置（允许同步、离线清风险、Agent 扫描超时等）。
        /// </summary>
        /// <param name="req"><see cref="ModifyBaselineUserOtherConfRequest"/></param>
        /// <returns><see cref="ModifyBaselineUserOtherConfResponse"/></returns>
        public Task<ModifyBaselineUserOtherConfResponse> ModifyBaselineUserOtherConf(ModifyBaselineUserOtherConfRequest req)
        {
            return InternalRequestAsync<ModifyBaselineUserOtherConfResponse>(req, "ModifyBaselineUserOtherConf");
        }

        /// <summary>
        /// 更新当前账号的用户级基线配置（允许同步、离线清风险、Agent 扫描超时等）。
        /// </summary>
        /// <param name="req"><see cref="ModifyBaselineUserOtherConfRequest"/></param>
        /// <returns><see cref="ModifyBaselineUserOtherConfResponse"/></returns>
        public ModifyBaselineUserOtherConfResponse ModifyBaselineUserOtherConfSync(ModifyBaselineUserOtherConfRequest req)
        {
            return InternalRequestAsync<ModifyBaselineUserOtherConfResponse>(req, "ModifyBaselineUserOtherConf")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新当前账号的“用户弱口令”自定义字典。字典原文经服务端加密后存储；传空字符串视为清空。
        /// </summary>
        /// <param name="req"><see cref="ModifyBaselineUserWeakPasswordConfRequest"/></param>
        /// <returns><see cref="ModifyBaselineUserWeakPasswordConfResponse"/></returns>
        public Task<ModifyBaselineUserWeakPasswordConfResponse> ModifyBaselineUserWeakPasswordConf(ModifyBaselineUserWeakPasswordConfRequest req)
        {
            return InternalRequestAsync<ModifyBaselineUserWeakPasswordConfResponse>(req, "ModifyBaselineUserWeakPasswordConf");
        }

        /// <summary>
        /// 更新当前账号的“用户弱口令”自定义字典。字典原文经服务端加密后存储；传空字符串视为清空。
        /// </summary>
        /// <param name="req"><see cref="ModifyBaselineUserWeakPasswordConfRequest"/></param>
        /// <returns><see cref="ModifyBaselineUserWeakPasswordConfResponse"/></returns>
        public ModifyBaselineUserWeakPasswordConfResponse ModifyBaselineUserWeakPasswordConfSync(ModifyBaselineUserWeakPasswordConfRequest req)
        {
            return InternalRequestAsync<ModifyBaselineUserWeakPasswordConfResponse>(req, "ModifyBaselineUserWeakPasswordConf")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 设置暴力破解阻断开关状态
        /// </summary>
        /// <param name="req"><see cref="ModifyBruteAttackBanStatusRequest"/></param>
        /// <returns><see cref="ModifyBruteAttackBanStatusResponse"/></returns>
        public Task<ModifyBruteAttackBanStatusResponse> ModifyBruteAttackBanStatus(ModifyBruteAttackBanStatusRequest req)
        {
            return InternalRequestAsync<ModifyBruteAttackBanStatusResponse>(req, "ModifyBruteAttackBanStatus");
        }

        /// <summary>
        /// 设置暴力破解阻断开关状态
        /// </summary>
        /// <param name="req"><see cref="ModifyBruteAttackBanStatusRequest"/></param>
        /// <returns><see cref="ModifyBruteAttackBanStatusResponse"/></returns>
        public ModifyBruteAttackBanStatusResponse ModifyBruteAttackBanStatusSync(ModifyBruteAttackBanStatusRequest req)
        {
            return InternalRequestAsync<ModifyBruteAttackBanStatusResponse>(req, "ModifyBruteAttackBanStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改暴力破解规则
        /// </summary>
        /// <param name="req"><see cref="ModifyBruteAttackRulesRequest"/></param>
        /// <returns><see cref="ModifyBruteAttackRulesResponse"/></returns>
        public Task<ModifyBruteAttackRulesResponse> ModifyBruteAttackRules(ModifyBruteAttackRulesRequest req)
        {
            return InternalRequestAsync<ModifyBruteAttackRulesResponse>(req, "ModifyBruteAttackRules");
        }

        /// <summary>
        /// 修改暴力破解规则
        /// </summary>
        /// <param name="req"><see cref="ModifyBruteAttackRulesRequest"/></param>
        /// <returns><see cref="ModifyBruteAttackRulesResponse"/></returns>
        public ModifyBruteAttackRulesResponse ModifyBruteAttackRulesSync(ModifyBruteAttackRulesRequest req)
        {
            return InternalRequestAsync<ModifyBruteAttackRulesResponse>(req, "ModifyBruteAttackRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 绑定主机授权或RASP授权到指定订单。异步执行，返回TaskId供查询进度。通过LicenseType指定授权版本（旗舰版/专业版/RASP）。
        /// </summary>
        /// <param name="req"><see cref="ModifyCSIPLicenseBindsRequest"/></param>
        /// <returns><see cref="ModifyCSIPLicenseBindsResponse"/></returns>
        public Task<ModifyCSIPLicenseBindsResponse> ModifyCSIPLicenseBinds(ModifyCSIPLicenseBindsRequest req)
        {
            return InternalRequestAsync<ModifyCSIPLicenseBindsResponse>(req, "ModifyCSIPLicenseBinds");
        }

        /// <summary>
        /// 绑定主机授权或RASP授权到指定订单。异步执行，返回TaskId供查询进度。通过LicenseType指定授权版本（旗舰版/专业版/RASP）。
        /// </summary>
        /// <param name="req"><see cref="ModifyCSIPLicenseBindsRequest"/></param>
        /// <returns><see cref="ModifyCSIPLicenseBindsResponse"/></returns>
        public ModifyCSIPLicenseBindsResponse ModifyCSIPLicenseBindsSync(ModifyCSIPLicenseBindsRequest req)
        {
            return InternalRequestAsync<ModifyCSIPLicenseBindsResponse>(req, "ModifyCSIPLicenseBinds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 手动解绑主机授权。同步执行，直接返回结果。仅解绑主机授权（category=0，含专业版/旗舰版）。单订单模式下appid即可定位订单，无需传ResourceId。RASP解绑请用ModifyCSIPRaspLicenseUnBinds。
        /// </summary>
        /// <param name="req"><see cref="ModifyCSIPLicenseUnBindsRequest"/></param>
        /// <returns><see cref="ModifyCSIPLicenseUnBindsResponse"/></returns>
        public Task<ModifyCSIPLicenseUnBindsResponse> ModifyCSIPLicenseUnBinds(ModifyCSIPLicenseUnBindsRequest req)
        {
            return InternalRequestAsync<ModifyCSIPLicenseUnBindsResponse>(req, "ModifyCSIPLicenseUnBinds");
        }

        /// <summary>
        /// 手动解绑主机授权。同步执行，直接返回结果。仅解绑主机授权（category=0，含专业版/旗舰版）。单订单模式下appid即可定位订单，无需传ResourceId。RASP解绑请用ModifyCSIPRaspLicenseUnBinds。
        /// </summary>
        /// <param name="req"><see cref="ModifyCSIPLicenseUnBindsRequest"/></param>
        /// <returns><see cref="ModifyCSIPLicenseUnBindsResponse"/></returns>
        public ModifyCSIPLicenseUnBindsResponse ModifyCSIPLicenseUnBindsSync(ModifyCSIPLicenseUnBindsRequest req)
        {
            return InternalRequestAsync<ModifyCSIPLicenseUnBindsResponse>(req, "ModifyCSIPLicenseUnBinds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 绑定 RASP / 旗舰版授权到指定订单。异步执行，返回TaskId供查询进度。LicenseType=rasp 绑 RASP，LicenseType=enterprise_hp 绑旗舰版主机授权；AssetType 区分主机/容器节点/EKS。
        /// </summary>
        /// <param name="req"><see cref="ModifyCSIPRaspLicenseBindsRequest"/></param>
        /// <returns><see cref="ModifyCSIPRaspLicenseBindsResponse"/></returns>
        public Task<ModifyCSIPRaspLicenseBindsResponse> ModifyCSIPRaspLicenseBinds(ModifyCSIPRaspLicenseBindsRequest req)
        {
            return InternalRequestAsync<ModifyCSIPRaspLicenseBindsResponse>(req, "ModifyCSIPRaspLicenseBinds");
        }

        /// <summary>
        /// 绑定 RASP / 旗舰版授权到指定订单。异步执行，返回TaskId供查询进度。LicenseType=rasp 绑 RASP，LicenseType=enterprise_hp 绑旗舰版主机授权；AssetType 区分主机/容器节点/EKS。
        /// </summary>
        /// <param name="req"><see cref="ModifyCSIPRaspLicenseBindsRequest"/></param>
        /// <returns><see cref="ModifyCSIPRaspLicenseBindsResponse"/></returns>
        public ModifyCSIPRaspLicenseBindsResponse ModifyCSIPRaspLicenseBindsSync(ModifyCSIPRaspLicenseBindsRequest req)
        {
            return InternalRequestAsync<ModifyCSIPRaspLicenseBindsResponse>(req, "ModifyCSIPRaspLicenseBinds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 手动解绑RASP授权。同步执行，直接返回结果。仅解绑RASP授权（category=1），无解绑次数限制。单订单模式下appid即可定位订单，无需传ResourceId。
        /// </summary>
        /// <param name="req"><see cref="ModifyCSIPRaspLicenseUnBindsRequest"/></param>
        /// <returns><see cref="ModifyCSIPRaspLicenseUnBindsResponse"/></returns>
        public Task<ModifyCSIPRaspLicenseUnBindsResponse> ModifyCSIPRaspLicenseUnBinds(ModifyCSIPRaspLicenseUnBindsRequest req)
        {
            return InternalRequestAsync<ModifyCSIPRaspLicenseUnBindsResponse>(req, "ModifyCSIPRaspLicenseUnBinds");
        }

        /// <summary>
        /// 手动解绑RASP授权。同步执行，直接返回结果。仅解绑RASP授权（category=1），无解绑次数限制。单订单模式下appid即可定位订单，无需传ResourceId。
        /// </summary>
        /// <param name="req"><see cref="ModifyCSIPRaspLicenseUnBindsRequest"/></param>
        /// <returns><see cref="ModifyCSIPRaspLicenseUnBindsResponse"/></returns>
        public ModifyCSIPRaspLicenseUnBindsResponse ModifyCSIPRaspLicenseUnBindsSync(ModifyCSIPRaspLicenseUnBindsRequest req)
        {
            return InternalRequestAsync<ModifyCSIPRaspLicenseUnBindsResponse>(req, "ModifyCSIPRaspLicenseUnBinds")
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
        /// 更新CSPM自动配额管理者共享开关
        /// </summary>
        /// <param name="req"><see cref="ModifyCspmShardConfigRequest"/></param>
        /// <returns><see cref="ModifyCspmShardConfigResponse"/></returns>
        public Task<ModifyCspmShardConfigResponse> ModifyCspmShardConfig(ModifyCspmShardConfigRequest req)
        {
            return InternalRequestAsync<ModifyCspmShardConfigResponse>(req, "ModifyCspmShardConfig");
        }

        /// <summary>
        /// 更新CSPM自动配额管理者共享开关
        /// </summary>
        /// <param name="req"><see cref="ModifyCspmShardConfigRequest"/></param>
        /// <returns><see cref="ModifyCspmShardConfigResponse"/></returns>
        public ModifyCspmShardConfigResponse ModifyCspmShardConfigSync(ModifyCspmShardConfigRequest req)
        {
            return InternalRequestAsync<ModifyCspmShardConfigResponse>(req, "ModifyCspmShardConfig")
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
        /// 修改EDR策略开关状态
        /// </summary>
        /// <param name="req"><see cref="ModifyEDRRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyEDRRuleStatusResponse"/></returns>
        public Task<ModifyEDRRuleStatusResponse> ModifyEDRRuleStatus(ModifyEDRRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyEDRRuleStatusResponse>(req, "ModifyEDRRuleStatus");
        }

        /// <summary>
        /// 修改EDR策略开关状态
        /// </summary>
        /// <param name="req"><see cref="ModifyEDRRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyEDRRuleStatusResponse"/></returns>
        public ModifyEDRRuleStatusResponse ModifyEDRRuleStatusSync(ModifyEDRRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyEDRRuleStatusResponse>(req, "ModifyEDRRuleStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量修改EDR策略动作
        /// </summary>
        /// <param name="req"><see cref="ModifyEDRRulesActionRequest"/></param>
        /// <returns><see cref="ModifyEDRRulesActionResponse"/></returns>
        public Task<ModifyEDRRulesActionResponse> ModifyEDRRulesAction(ModifyEDRRulesActionRequest req)
        {
            return InternalRequestAsync<ModifyEDRRulesActionResponse>(req, "ModifyEDRRulesAction");
        }

        /// <summary>
        /// 批量修改EDR策略动作
        /// </summary>
        /// <param name="req"><see cref="ModifyEDRRulesActionRequest"/></param>
        /// <returns><see cref="ModifyEDRRulesActionResponse"/></returns>
        public ModifyEDRRulesActionResponse ModifyEDRRulesActionSync(ModifyEDRRulesActionRequest req)
        {
            return InternalRequestAsync<ModifyEDRRulesActionResponse>(req, "ModifyEDRRulesAction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// EDR告警隔离和恢复
        /// </summary>
        /// <param name="req"><see cref="ModifyEdrAlertIsolationRequest"/></param>
        /// <returns><see cref="ModifyEdrAlertIsolationResponse"/></returns>
        public Task<ModifyEdrAlertIsolationResponse> ModifyEdrAlertIsolation(ModifyEdrAlertIsolationRequest req)
        {
            return InternalRequestAsync<ModifyEdrAlertIsolationResponse>(req, "ModifyEdrAlertIsolation");
        }

        /// <summary>
        /// EDR告警隔离和恢复
        /// </summary>
        /// <param name="req"><see cref="ModifyEdrAlertIsolationRequest"/></param>
        /// <returns><see cref="ModifyEdrAlertIsolationResponse"/></returns>
        public ModifyEdrAlertIsolationResponse ModifyEdrAlertIsolationSync(ModifyEdrAlertIsolationRequest req)
        {
            return InternalRequestAsync<ModifyEdrAlertIsolationResponse>(req, "ModifyEdrAlertIsolation")
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
        /// EDR告警状态处置
        /// </summary>
        /// <param name="req"><see cref="ModifyEdrAlertStatusRequest"/></param>
        /// <returns><see cref="ModifyEdrAlertStatusResponse"/></returns>
        public Task<ModifyEdrAlertStatusResponse> ModifyEdrAlertStatus(ModifyEdrAlertStatusRequest req)
        {
            return InternalRequestAsync<ModifyEdrAlertStatusResponse>(req, "ModifyEdrAlertStatus");
        }

        /// <summary>
        /// EDR告警状态处置
        /// </summary>
        /// <param name="req"><see cref="ModifyEdrAlertStatusRequest"/></param>
        /// <returns><see cref="ModifyEdrAlertStatusResponse"/></returns>
        public ModifyEdrAlertStatusResponse ModifyEdrAlertStatusSync(ModifyEdrAlertStatusRequest req)
        {
            return InternalRequestAsync<ModifyEdrAlertStatusResponse>(req, "ModifyEdrAlertStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改日志采集例外网段配置，支持IP/IP段/CIDR格式，最多可添加100条
        /// </summary>
        /// <param name="req"><see cref="ModifyEdrExcludeNetworkSegmentsRequest"/></param>
        /// <returns><see cref="ModifyEdrExcludeNetworkSegmentsResponse"/></returns>
        public Task<ModifyEdrExcludeNetworkSegmentsResponse> ModifyEdrExcludeNetworkSegments(ModifyEdrExcludeNetworkSegmentsRequest req)
        {
            return InternalRequestAsync<ModifyEdrExcludeNetworkSegmentsResponse>(req, "ModifyEdrExcludeNetworkSegments");
        }

        /// <summary>
        /// 修改日志采集例外网段配置，支持IP/IP段/CIDR格式，最多可添加100条
        /// </summary>
        /// <param name="req"><see cref="ModifyEdrExcludeNetworkSegmentsRequest"/></param>
        /// <returns><see cref="ModifyEdrExcludeNetworkSegmentsResponse"/></returns>
        public ModifyEdrExcludeNetworkSegmentsResponse ModifyEdrExcludeNetworkSegmentsSync(ModifyEdrExcludeNetworkSegmentsRequest req)
        {
            return InternalRequestAsync<ModifyEdrExcludeNetworkSegmentsResponse>(req, "ModifyEdrExcludeNetworkSegments")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改应用日志采集路径配置
        /// </summary>
        /// <param name="req"><see cref="ModifyEdrLogCollectPathRequest"/></param>
        /// <returns><see cref="ModifyEdrLogCollectPathResponse"/></returns>
        public Task<ModifyEdrLogCollectPathResponse> ModifyEdrLogCollectPath(ModifyEdrLogCollectPathRequest req)
        {
            return InternalRequestAsync<ModifyEdrLogCollectPathResponse>(req, "ModifyEdrLogCollectPath");
        }

        /// <summary>
        /// 修改应用日志采集路径配置
        /// </summary>
        /// <param name="req"><see cref="ModifyEdrLogCollectPathRequest"/></param>
        /// <returns><see cref="ModifyEdrLogCollectPathResponse"/></returns>
        public ModifyEdrLogCollectPathResponse ModifyEdrLogCollectPathSync(ModifyEdrLogCollectPathRequest req)
        {
            return InternalRequestAsync<ModifyEdrLogCollectPathResponse>(req, "ModifyEdrLogCollectPath")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云边界自动打标-更新规则
        /// </summary>
        /// <param name="req"><see cref="ModifyExposureAutoTagRuleRequest"/></param>
        /// <returns><see cref="ModifyExposureAutoTagRuleResponse"/></returns>
        public Task<ModifyExposureAutoTagRuleResponse> ModifyExposureAutoTagRule(ModifyExposureAutoTagRuleRequest req)
        {
            return InternalRequestAsync<ModifyExposureAutoTagRuleResponse>(req, "ModifyExposureAutoTagRule");
        }

        /// <summary>
        /// 云边界自动打标-更新规则
        /// </summary>
        /// <param name="req"><see cref="ModifyExposureAutoTagRuleRequest"/></param>
        /// <returns><see cref="ModifyExposureAutoTagRuleResponse"/></returns>
        public ModifyExposureAutoTagRuleResponse ModifyExposureAutoTagRuleSync(ModifyExposureAutoTagRuleRequest req)
        {
            return InternalRequestAsync<ModifyExposureAutoTagRuleResponse>(req, "ModifyExposureAutoTagRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云边界自动打标-启停规则
        /// </summary>
        /// <param name="req"><see cref="ModifyExposureAutoTagRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyExposureAutoTagRuleStatusResponse"/></returns>
        public Task<ModifyExposureAutoTagRuleStatusResponse> ModifyExposureAutoTagRuleStatus(ModifyExposureAutoTagRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyExposureAutoTagRuleStatusResponse>(req, "ModifyExposureAutoTagRuleStatus");
        }

        /// <summary>
        /// 云边界自动打标-启停规则
        /// </summary>
        /// <param name="req"><see cref="ModifyExposureAutoTagRuleStatusRequest"/></param>
        /// <returns><see cref="ModifyExposureAutoTagRuleStatusResponse"/></returns>
        public ModifyExposureAutoTagRuleStatusResponse ModifyExposureAutoTagRuleStatusSync(ModifyExposureAutoTagRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifyExposureAutoTagRuleStatusResponse>(req, "ModifyExposureAutoTagRuleStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新云边界自定义标签
        /// </summary>
        /// <param name="req"><see cref="ModifyExposureTagRequest"/></param>
        /// <returns><see cref="ModifyExposureTagResponse"/></returns>
        public Task<ModifyExposureTagResponse> ModifyExposureTag(ModifyExposureTagRequest req)
        {
            return InternalRequestAsync<ModifyExposureTagResponse>(req, "ModifyExposureTag");
        }

        /// <summary>
        /// 更新云边界自定义标签
        /// </summary>
        /// <param name="req"><see cref="ModifyExposureTagRequest"/></param>
        /// <returns><see cref="ModifyExposureTagResponse"/></returns>
        public ModifyExposureTagResponse ModifyExposureTagSync(ModifyExposureTagRequest req)
        {
            return InternalRequestAsync<ModifyExposureTagResponse>(req, "ModifyExposureTag")
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
        /// 修改镜像仓库信息
        /// </summary>
        /// <param name="req"><see cref="ModifyImageRegistryRequest"/></param>
        /// <returns><see cref="ModifyImageRegistryResponse"/></returns>
        public Task<ModifyImageRegistryResponse> ModifyImageRegistry(ModifyImageRegistryRequest req)
        {
            return InternalRequestAsync<ModifyImageRegistryResponse>(req, "ModifyImageRegistry");
        }

        /// <summary>
        /// 修改镜像仓库信息
        /// </summary>
        /// <param name="req"><see cref="ModifyImageRegistryRequest"/></param>
        /// <returns><see cref="ModifyImageRegistryResponse"/></returns>
        public ModifyImageRegistryResponse ModifyImageRegistrySync(ModifyImageRegistryRequest req)
        {
            return InternalRequestAsync<ModifyImageRegistryResponse>(req, "ModifyImageRegistry")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改镜像仓库定时扫描任务配置
        /// </summary>
        /// <param name="req"><see cref="ModifyImageRegistryTimedScanTaskConfigRequest"/></param>
        /// <returns><see cref="ModifyImageRegistryTimedScanTaskConfigResponse"/></returns>
        public Task<ModifyImageRegistryTimedScanTaskConfigResponse> ModifyImageRegistryTimedScanTaskConfig(ModifyImageRegistryTimedScanTaskConfigRequest req)
        {
            return InternalRequestAsync<ModifyImageRegistryTimedScanTaskConfigResponse>(req, "ModifyImageRegistryTimedScanTaskConfig");
        }

        /// <summary>
        /// 修改镜像仓库定时扫描任务配置
        /// </summary>
        /// <param name="req"><see cref="ModifyImageRegistryTimedScanTaskConfigRequest"/></param>
        /// <returns><see cref="ModifyImageRegistryTimedScanTaskConfigResponse"/></returns>
        public ModifyImageRegistryTimedScanTaskConfigResponse ModifyImageRegistryTimedScanTaskConfigSync(ModifyImageRegistryTimedScanTaskConfigRequest req)
        {
            return InternalRequestAsync<ModifyImageRegistryTimedScanTaskConfigResponse>(req, "ModifyImageRegistryTimedScanTaskConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改容器镜像敏感信息白名单
        /// </summary>
        /// <param name="req"><see cref="ModifyImageSensitiveWhitelistRequest"/></param>
        /// <returns><see cref="ModifyImageSensitiveWhitelistResponse"/></returns>
        public Task<ModifyImageSensitiveWhitelistResponse> ModifyImageSensitiveWhitelist(ModifyImageSensitiveWhitelistRequest req)
        {
            return InternalRequestAsync<ModifyImageSensitiveWhitelistResponse>(req, "ModifyImageSensitiveWhitelist");
        }

        /// <summary>
        /// 修改容器镜像敏感信息白名单
        /// </summary>
        /// <param name="req"><see cref="ModifyImageSensitiveWhitelistRequest"/></param>
        /// <returns><see cref="ModifyImageSensitiveWhitelistResponse"/></returns>
        public ModifyImageSensitiveWhitelistResponse ModifyImageSensitiveWhitelistSync(ModifyImageSensitiveWhitelistRequest req)
        {
            return InternalRequestAsync<ModifyImageSensitiveWhitelistResponse>(req, "ModifyImageSensitiveWhitelist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询资产数据库信息
        /// </summary>
        /// <param name="req"><see cref="ModifyImageVirusWhitelistRequest"/></param>
        /// <returns><see cref="ModifyImageVirusWhitelistResponse"/></returns>
        public Task<ModifyImageVirusWhitelistResponse> ModifyImageVirusWhitelist(ModifyImageVirusWhitelistRequest req)
        {
            return InternalRequestAsync<ModifyImageVirusWhitelistResponse>(req, "ModifyImageVirusWhitelist");
        }

        /// <summary>
        /// 查询资产数据库信息
        /// </summary>
        /// <param name="req"><see cref="ModifyImageVirusWhitelistRequest"/></param>
        /// <returns><see cref="ModifyImageVirusWhitelistResponse"/></returns>
        public ModifyImageVirusWhitelistResponse ModifyImageVirusWhitelistSync(ModifyImageVirusWhitelistRequest req)
        {
            return InternalRequestAsync<ModifyImageVirusWhitelistResponse>(req, "ModifyImageVirusWhitelist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改容器镜像漏洞白名单
        /// </summary>
        /// <param name="req"><see cref="ModifyImageVulWhitelistRequest"/></param>
        /// <returns><see cref="ModifyImageVulWhitelistResponse"/></returns>
        public Task<ModifyImageVulWhitelistResponse> ModifyImageVulWhitelist(ModifyImageVulWhitelistRequest req)
        {
            return InternalRequestAsync<ModifyImageVulWhitelistResponse>(req, "ModifyImageVulWhitelist");
        }

        /// <summary>
        /// 修改容器镜像漏洞白名单
        /// </summary>
        /// <param name="req"><see cref="ModifyImageVulWhitelistRequest"/></param>
        /// <returns><see cref="ModifyImageVulWhitelistResponse"/></returns>
        public ModifyImageVulWhitelistResponse ModifyImageVulWhitelistSync(ModifyImageVulWhitelistRequest req)
        {
            return InternalRequestAsync<ModifyImageVulWhitelistResponse>(req, "ModifyImageVulWhitelist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新合并后登录审计白名单信息（服务器列表数目应小于1000）
        /// </summary>
        /// <param name="req"><see cref="ModifyLoginWhiteRecordRequest"/></param>
        /// <returns><see cref="ModifyLoginWhiteRecordResponse"/></returns>
        public Task<ModifyLoginWhiteRecordResponse> ModifyLoginWhiteRecord(ModifyLoginWhiteRecordRequest req)
        {
            return InternalRequestAsync<ModifyLoginWhiteRecordResponse>(req, "ModifyLoginWhiteRecord");
        }

        /// <summary>
        /// 更新合并后登录审计白名单信息（服务器列表数目应小于1000）
        /// </summary>
        /// <param name="req"><see cref="ModifyLoginWhiteRecordRequest"/></param>
        /// <returns><see cref="ModifyLoginWhiteRecordResponse"/></returns>
        public ModifyLoginWhiteRecordResponse ModifyLoginWhiteRecordSync(ModifyLoginWhiteRecordRequest req)
        {
            return InternalRequestAsync<ModifyLoginWhiteRecordResponse>(req, "ModifyLoginWhiteRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改机器清理配置
        /// </summary>
        /// <param name="req"><see cref="ModifyMachineAutoClearConfigRequest"/></param>
        /// <returns><see cref="ModifyMachineAutoClearConfigResponse"/></returns>
        public Task<ModifyMachineAutoClearConfigResponse> ModifyMachineAutoClearConfig(ModifyMachineAutoClearConfigRequest req)
        {
            return InternalRequestAsync<ModifyMachineAutoClearConfigResponse>(req, "ModifyMachineAutoClearConfig");
        }

        /// <summary>
        /// 修改机器清理配置
        /// </summary>
        /// <param name="req"><see cref="ModifyMachineAutoClearConfigRequest"/></param>
        /// <returns><see cref="ModifyMachineAutoClearConfigResponse"/></returns>
        public ModifyMachineAutoClearConfigResponse ModifyMachineAutoClearConfigSync(ModifyMachineAutoClearConfigRequest req)
        {
            return InternalRequestAsync<ModifyMachineAutoClearConfigResponse>(req, "ModifyMachineAutoClearConfig")
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
        /// 批量修改主机登录方式
        /// </summary>
        /// <param name="req"><see cref="ModifyMachinesLoginTypeRequest"/></param>
        /// <returns><see cref="ModifyMachinesLoginTypeResponse"/></returns>
        public Task<ModifyMachinesLoginTypeResponse> ModifyMachinesLoginType(ModifyMachinesLoginTypeRequest req)
        {
            return InternalRequestAsync<ModifyMachinesLoginTypeResponse>(req, "ModifyMachinesLoginType");
        }

        /// <summary>
        /// 批量修改主机登录方式
        /// </summary>
        /// <param name="req"><see cref="ModifyMachinesLoginTypeRequest"/></param>
        /// <returns><see cref="ModifyMachinesLoginTypeResponse"/></returns>
        public ModifyMachinesLoginTypeResponse ModifyMachinesLoginTypeSync(ModifyMachinesLoginTypeRequest req)
        {
            return InternalRequestAsync<ModifyMachinesLoginTypeResponse>(req, "ModifyMachinesLoginType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改文件查杀定时扫描配置，包含扫描周期、检测模式、资产范围、引擎选择、隔离配置等
        /// </summary>
        /// <param name="req"><see cref="ModifyMalwareTimingScanSettingsRequest"/></param>
        /// <returns><see cref="ModifyMalwareTimingScanSettingsResponse"/></returns>
        public Task<ModifyMalwareTimingScanSettingsResponse> ModifyMalwareTimingScanSettings(ModifyMalwareTimingScanSettingsRequest req)
        {
            return InternalRequestAsync<ModifyMalwareTimingScanSettingsResponse>(req, "ModifyMalwareTimingScanSettings");
        }

        /// <summary>
        /// 修改文件查杀定时扫描配置，包含扫描周期、检测模式、资产范围、引擎选择、隔离配置等
        /// </summary>
        /// <param name="req"><see cref="ModifyMalwareTimingScanSettingsRequest"/></param>
        /// <returns><see cref="ModifyMalwareTimingScanSettingsResponse"/></returns>
        public ModifyMalwareTimingScanSettingsResponse ModifyMalwareTimingScanSettingsSync(ModifyMalwareTimingScanSettingsRequest req)
        {
            return InternalRequestAsync<ModifyMalwareTimingScanSettingsResponse>(req, "ModifyMalwareTimingScanSettings")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新增或更新NFS扫描全局配置
        /// </summary>
        /// <param name="req"><see cref="ModifyNFSScanConfRequest"/></param>
        /// <returns><see cref="ModifyNFSScanConfResponse"/></returns>
        public Task<ModifyNFSScanConfResponse> ModifyNFSScanConf(ModifyNFSScanConfRequest req)
        {
            return InternalRequestAsync<ModifyNFSScanConfResponse>(req, "ModifyNFSScanConf");
        }

        /// <summary>
        /// 新增或更新NFS扫描全局配置
        /// </summary>
        /// <param name="req"><see cref="ModifyNFSScanConfRequest"/></param>
        /// <returns><see cref="ModifyNFSScanConfResponse"/></returns>
        public ModifyNFSScanConfResponse ModifyNFSScanConfSync(ModifyNFSScanConfRequest req)
        {
            return InternalRequestAsync<ModifyNFSScanConfResponse>(req, "ModifyNFSScanConf")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 关闭进程守护功能
        /// </summary>
        /// <param name="req"><see cref="ModifyNFSScanHostRequest"/></param>
        /// <returns><see cref="ModifyNFSScanHostResponse"/></returns>
        public Task<ModifyNFSScanHostResponse> ModifyNFSScanHost(ModifyNFSScanHostRequest req)
        {
            return InternalRequestAsync<ModifyNFSScanHostResponse>(req, "ModifyNFSScanHost");
        }

        /// <summary>
        /// 关闭进程守护功能
        /// </summary>
        /// <param name="req"><see cref="ModifyNFSScanHostRequest"/></param>
        /// <returns><see cref="ModifyNFSScanHostResponse"/></returns>
        public ModifyNFSScanHostResponse ModifyNFSScanHostSync(ModifyNFSScanHostRequest req)
        {
            return InternalRequestAsync<ModifyNFSScanHostResponse>(req, "ModifyNFSScanHost")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改网络攻击检测开关及资产范围配置
        /// </summary>
        /// <param name="req"><see cref="ModifyNetAttackSettingRequest"/></param>
        /// <returns><see cref="ModifyNetAttackSettingResponse"/></returns>
        public Task<ModifyNetAttackSettingResponse> ModifyNetAttackSetting(ModifyNetAttackSettingRequest req)
        {
            return InternalRequestAsync<ModifyNetAttackSettingResponse>(req, "ModifyNetAttackSetting");
        }

        /// <summary>
        /// 修改网络攻击检测开关及资产范围配置
        /// </summary>
        /// <param name="req"><see cref="ModifyNetAttackSettingRequest"/></param>
        /// <returns><see cref="ModifyNetAttackSettingResponse"/></returns>
        public ModifyNetAttackSettingResponse ModifyNetAttackSettingSync(ModifyNetAttackSettingRequest req)
        {
            return InternalRequestAsync<ModifyNetAttackSettingResponse>(req, "ModifyNetAttackSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改客户端离线时长
        /// </summary>
        /// <param name="req"><see cref="ModifyNotifyAgentOfflineDurationRequest"/></param>
        /// <returns><see cref="ModifyNotifyAgentOfflineDurationResponse"/></returns>
        public Task<ModifyNotifyAgentOfflineDurationResponse> ModifyNotifyAgentOfflineDuration(ModifyNotifyAgentOfflineDurationRequest req)
        {
            return InternalRequestAsync<ModifyNotifyAgentOfflineDurationResponse>(req, "ModifyNotifyAgentOfflineDuration");
        }

        /// <summary>
        /// 修改客户端离线时长
        /// </summary>
        /// <param name="req"><see cref="ModifyNotifyAgentOfflineDurationRequest"/></param>
        /// <returns><see cref="ModifyNotifyAgentOfflineDurationResponse"/></returns>
        public ModifyNotifyAgentOfflineDurationResponse ModifyNotifyAgentOfflineDurationSync(ModifyNotifyAgentOfflineDurationRequest req)
        {
            return InternalRequestAsync<ModifyNotifyAgentOfflineDurationResponse>(req, "ModifyNotifyAgentOfflineDuration")
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
        /// 修改通知成员账号
        /// </summary>
        /// <param name="req"><see cref="ModifyNotifyMemberRequest"/></param>
        /// <returns><see cref="ModifyNotifyMemberResponse"/></returns>
        public Task<ModifyNotifyMemberResponse> ModifyNotifyMember(ModifyNotifyMemberRequest req)
        {
            return InternalRequestAsync<ModifyNotifyMemberResponse>(req, "ModifyNotifyMember");
        }

        /// <summary>
        /// 修改通知成员账号
        /// </summary>
        /// <param name="req"><see cref="ModifyNotifyMemberRequest"/></param>
        /// <returns><see cref="ModifyNotifyMemberResponse"/></returns>
        public ModifyNotifyMemberResponse ModifyNotifyMemberSync(ModifyNotifyMemberRequest req)
        {
            return InternalRequestAsync<ModifyNotifyMemberResponse>(req, "ModifyNotifyMember")
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
        /// 修改通知设置（云API风险治理）
        /// </summary>
        /// <param name="req"><see cref="ModifyNotifySettingAkRequest"/></param>
        /// <returns><see cref="ModifyNotifySettingAkResponse"/></returns>
        public Task<ModifyNotifySettingAkResponse> ModifyNotifySettingAk(ModifyNotifySettingAkRequest req)
        {
            return InternalRequestAsync<ModifyNotifySettingAkResponse>(req, "ModifyNotifySettingAk");
        }

        /// <summary>
        /// 修改通知设置（云API风险治理）
        /// </summary>
        /// <param name="req"><see cref="ModifyNotifySettingAkRequest"/></param>
        /// <returns><see cref="ModifyNotifySettingAkResponse"/></returns>
        public ModifyNotifySettingAkResponse ModifyNotifySettingAkSync(ModifyNotifySettingAkRequest req)
        {
            return InternalRequestAsync<ModifyNotifySettingAkResponse>(req, "ModifyNotifySettingAk")
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
        /// 修改自动扩容配置（多模块可扩展，本期仅主机安全模块）。
        /// 
        /// 「自动扩容」为面向用户的对外概念，等价于底层自动加购(auto_repurchase)：当账号有新增资产时，自动加购所需授权。
        /// 
        /// 补充说明：
        /// 1. 本期仅实现主机安全模块 HostConfig；后续可扩展容器安全、AI-Agent 安全等命名模块字段，各模块配置字段可异构；
        /// 2. 部分更新语义：模块对象为空表示该模块不修改，模块内字段为空表示该字段不修改；
        /// 3. HostConfig.Switch 联动映射 auto_repurchase_switch；auto_bind_switch（自动绑定）恒开，不由本接口改动；
        /// 4. 自动续费(renew_flag) 不由本接口改动；额度/用量请调用 DescribeLicenseStatus；
        /// 5. 顶部「自动扩容」总开关状态由前端按各模块开关聚合，后端不存储、不返回全局开关。
        /// </summary>
        /// <param name="req"><see cref="ModifyPayConfigRequest"/></param>
        /// <returns><see cref="ModifyPayConfigResponse"/></returns>
        public Task<ModifyPayConfigResponse> ModifyPayConfig(ModifyPayConfigRequest req)
        {
            return InternalRequestAsync<ModifyPayConfigResponse>(req, "ModifyPayConfig");
        }

        /// <summary>
        /// 修改自动扩容配置（多模块可扩展，本期仅主机安全模块）。
        /// 
        /// 「自动扩容」为面向用户的对外概念，等价于底层自动加购(auto_repurchase)：当账号有新增资产时，自动加购所需授权。
        /// 
        /// 补充说明：
        /// 1. 本期仅实现主机安全模块 HostConfig；后续可扩展容器安全、AI-Agent 安全等命名模块字段，各模块配置字段可异构；
        /// 2. 部分更新语义：模块对象为空表示该模块不修改，模块内字段为空表示该字段不修改；
        /// 3. HostConfig.Switch 联动映射 auto_repurchase_switch；auto_bind_switch（自动绑定）恒开，不由本接口改动；
        /// 4. 自动续费(renew_flag) 不由本接口改动；额度/用量请调用 DescribeLicenseStatus；
        /// 5. 顶部「自动扩容」总开关状态由前端按各模块开关聚合，后端不存储、不返回全局开关。
        /// </summary>
        /// <param name="req"><see cref="ModifyPayConfigRequest"/></param>
        /// <returns><see cref="ModifyPayConfigResponse"/></returns>
        public ModifyPayConfigResponse ModifyPayConfigSync(ModifyPayConfigRequest req)
        {
            return InternalRequestAsync<ModifyPayConfigResponse>(req, "ModifyPayConfig")
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
        /// 重保防护包防护设置
        /// </summary>
        /// <param name="req"><see cref="ModifyProtectionSettingRequest"/></param>
        /// <returns><see cref="ModifyProtectionSettingResponse"/></returns>
        public Task<ModifyProtectionSettingResponse> ModifyProtectionSetting(ModifyProtectionSettingRequest req)
        {
            return InternalRequestAsync<ModifyProtectionSettingResponse>(req, "ModifyProtectionSetting");
        }

        /// <summary>
        /// 重保防护包防护设置
        /// </summary>
        /// <param name="req"><see cref="ModifyProtectionSettingRequest"/></param>
        /// <returns><see cref="ModifyProtectionSettingResponse"/></returns>
        public ModifyProtectionSettingResponse ModifyProtectionSettingSync(ModifyProtectionSettingRequest req)
        {
            return InternalRequestAsync<ModifyProtectionSettingResponse>(req, "ModifyProtectionSetting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重保防护授权包绑定
        /// </summary>
        /// <param name="req"><see cref="ModifyRaspLicenseBindsRequest"/></param>
        /// <returns><see cref="ModifyRaspLicenseBindsResponse"/></returns>
        public Task<ModifyRaspLicenseBindsResponse> ModifyRaspLicenseBinds(ModifyRaspLicenseBindsRequest req)
        {
            return InternalRequestAsync<ModifyRaspLicenseBindsResponse>(req, "ModifyRaspLicenseBinds");
        }

        /// <summary>
        /// 重保防护授权包绑定
        /// </summary>
        /// <param name="req"><see cref="ModifyRaspLicenseBindsRequest"/></param>
        /// <returns><see cref="ModifyRaspLicenseBindsResponse"/></returns>
        public ModifyRaspLicenseBindsResponse ModifyRaspLicenseBindsSync(ModifyRaspLicenseBindsRequest req)
        {
            return InternalRequestAsync<ModifyRaspLicenseBindsResponse>(req, "ModifyRaspLicenseBinds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改反弹Shell内网告警与资产范围配置
        /// </summary>
        /// <param name="req"><see cref="ModifyReverseShellSystemPolicyConfigRequest"/></param>
        /// <returns><see cref="ModifyReverseShellSystemPolicyConfigResponse"/></returns>
        public Task<ModifyReverseShellSystemPolicyConfigResponse> ModifyReverseShellSystemPolicyConfig(ModifyReverseShellSystemPolicyConfigRequest req)
        {
            return InternalRequestAsync<ModifyReverseShellSystemPolicyConfigResponse>(req, "ModifyReverseShellSystemPolicyConfig");
        }

        /// <summary>
        /// 修改反弹Shell内网告警与资产范围配置
        /// </summary>
        /// <param name="req"><see cref="ModifyReverseShellSystemPolicyConfigRequest"/></param>
        /// <returns><see cref="ModifyReverseShellSystemPolicyConfigResponse"/></returns>
        public ModifyReverseShellSystemPolicyConfigResponse ModifyReverseShellSystemPolicyConfigSync(ModifyReverseShellSystemPolicyConfigRequest req)
        {
            return InternalRequestAsync<ModifyReverseShellSystemPolicyConfigResponse>(req, "ModifyReverseShellSystemPolicyConfig")
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
        /// 更新周期扫描计划
        /// </summary>
        /// <param name="req"><see cref="ModifyRiskScanCronConfigRequest"/></param>
        /// <returns><see cref="ModifyRiskScanCronConfigResponse"/></returns>
        public Task<ModifyRiskScanCronConfigResponse> ModifyRiskScanCronConfig(ModifyRiskScanCronConfigRequest req)
        {
            return InternalRequestAsync<ModifyRiskScanCronConfigResponse>(req, "ModifyRiskScanCronConfig");
        }

        /// <summary>
        /// 更新周期扫描计划
        /// </summary>
        /// <param name="req"><see cref="ModifyRiskScanCronConfigRequest"/></param>
        /// <returns><see cref="ModifyRiskScanCronConfigResponse"/></returns>
        public ModifyRiskScanCronConfigResponse ModifyRiskScanCronConfigSync(ModifyRiskScanCronConfigRequest req)
        {
            return InternalRequestAsync<ModifyRiskScanCronConfigResponse>(req, "ModifyRiskScanCronConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量切换 LLM 审计用户规则的启禁用状态。任一规则不存在、属于其他租户或已删除时整体返回错误
        /// </summary>
        /// <param name="req"><see cref="ModifySandboxLLMAuditRuleStatusRequest"/></param>
        /// <returns><see cref="ModifySandboxLLMAuditRuleStatusResponse"/></returns>
        public Task<ModifySandboxLLMAuditRuleStatusResponse> ModifySandboxLLMAuditRuleStatus(ModifySandboxLLMAuditRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifySandboxLLMAuditRuleStatusResponse>(req, "ModifySandboxLLMAuditRuleStatus");
        }

        /// <summary>
        /// 批量切换 LLM 审计用户规则的启禁用状态。任一规则不存在、属于其他租户或已删除时整体返回错误
        /// </summary>
        /// <param name="req"><see cref="ModifySandboxLLMAuditRuleStatusRequest"/></param>
        /// <returns><see cref="ModifySandboxLLMAuditRuleStatusResponse"/></returns>
        public ModifySandboxLLMAuditRuleStatusResponse ModifySandboxLLMAuditRuleStatusSync(ModifySandboxLLMAuditRuleStatusRequest req)
        {
            return InternalRequestAsync<ModifySandboxLLMAuditRuleStatusResponse>(req, "ModifySandboxLLMAuditRuleStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改安全评分规则，必须传入完整规则集
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityScoreRuleRequest"/></param>
        /// <returns><see cref="ModifySecurityScoreRuleResponse"/></returns>
        public Task<ModifySecurityScoreRuleResponse> ModifySecurityScoreRule(ModifySecurityScoreRuleRequest req)
        {
            return InternalRequestAsync<ModifySecurityScoreRuleResponse>(req, "ModifySecurityScoreRule");
        }

        /// <summary>
        /// 修改安全评分规则，必须传入完整规则集
        /// </summary>
        /// <param name="req"><see cref="ModifySecurityScoreRuleRequest"/></param>
        /// <returns><see cref="ModifySecurityScoreRuleResponse"/></returns>
        public ModifySecurityScoreRuleResponse ModifySecurityScoreRuleSync(ModifySecurityScoreRuleRequest req)
        {
            return InternalRequestAsync<ModifySecurityScoreRuleResponse>(req, "ModifySecurityScoreRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑CSPM共享账号
        /// </summary>
        /// <param name="req"><see cref="ModifyShareUserCSPMRequest"/></param>
        /// <returns><see cref="ModifyShareUserCSPMResponse"/></returns>
        public Task<ModifyShareUserCSPMResponse> ModifyShareUserCSPM(ModifyShareUserCSPMRequest req)
        {
            return InternalRequestAsync<ModifyShareUserCSPMResponse>(req, "ModifyShareUserCSPM");
        }

        /// <summary>
        /// 编辑CSPM共享账号
        /// </summary>
        /// <param name="req"><see cref="ModifyShareUserCSPMRequest"/></param>
        /// <returns><see cref="ModifyShareUserCSPMResponse"/></returns>
        public ModifyShareUserCSPMResponse ModifyShareUserCSPMSync(ModifyShareUserCSPMRequest req)
        {
            return InternalRequestAsync<ModifyShareUserCSPMResponse>(req, "ModifyShareUserCSPM")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量修改 Skill 安全检测告警的处理状态
        /// </summary>
        /// <param name="req"><see cref="ModifySkillScanAlertStatusRequest"/></param>
        /// <returns><see cref="ModifySkillScanAlertStatusResponse"/></returns>
        public Task<ModifySkillScanAlertStatusResponse> ModifySkillScanAlertStatus(ModifySkillScanAlertStatusRequest req)
        {
            return InternalRequestAsync<ModifySkillScanAlertStatusResponse>(req, "ModifySkillScanAlertStatus");
        }

        /// <summary>
        /// 批量修改 Skill 安全检测告警的处理状态
        /// </summary>
        /// <param name="req"><see cref="ModifySkillScanAlertStatusRequest"/></param>
        /// <returns><see cref="ModifySkillScanAlertStatusResponse"/></returns>
        public ModifySkillScanAlertStatusResponse ModifySkillScanAlertStatusSync(ModifySkillScanAlertStatusRequest req)
        {
            return InternalRequestAsync<ModifySkillScanAlertStatusResponse>(req, "ModifySkillScanAlertStatus")
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
        /// 修改漏洞扫描（周期扫描）
        /// </summary>
        /// <param name="req"><see cref="ModifyVulScanPeriodicRequest"/></param>
        /// <returns><see cref="ModifyVulScanPeriodicResponse"/></returns>
        public Task<ModifyVulScanPeriodicResponse> ModifyVulScanPeriodic(ModifyVulScanPeriodicRequest req)
        {
            return InternalRequestAsync<ModifyVulScanPeriodicResponse>(req, "ModifyVulScanPeriodic");
        }

        /// <summary>
        /// 修改漏洞扫描（周期扫描）
        /// </summary>
        /// <param name="req"><see cref="ModifyVulScanPeriodicRequest"/></param>
        /// <returns><see cref="ModifyVulScanPeriodicResponse"/></returns>
        public ModifyVulScanPeriodicResponse ModifyVulScanPeriodicSync(ModifyVulScanPeriodicRequest req)
        {
            return InternalRequestAsync<ModifyVulScanPeriodicResponse>(req, "ModifyVulScanPeriodic")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改漏洞白名单配置
        /// </summary>
        /// <param name="req"><see cref="ModifyVulWhitelistConfigRequest"/></param>
        /// <returns><see cref="ModifyVulWhitelistConfigResponse"/></returns>
        public Task<ModifyVulWhitelistConfigResponse> ModifyVulWhitelistConfig(ModifyVulWhitelistConfigRequest req)
        {
            return InternalRequestAsync<ModifyVulWhitelistConfigResponse>(req, "ModifyVulWhitelistConfig");
        }

        /// <summary>
        /// 修改漏洞白名单配置
        /// </summary>
        /// <param name="req"><see cref="ModifyVulWhitelistConfigRequest"/></param>
        /// <returns><see cref="ModifyVulWhitelistConfigResponse"/></returns>
        public ModifyVulWhitelistConfigResponse ModifyVulWhitelistConfigSync(ModifyVulWhitelistConfigRequest req)
        {
            return InternalRequestAsync<ModifyVulWhitelistConfigResponse>(req, "ModifyVulWhitelistConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改漏洞白名单开关
        /// </summary>
        /// <param name="req"><see cref="ModifyVulWhitelistSwitchRequest"/></param>
        /// <returns><see cref="ModifyVulWhitelistSwitchResponse"/></returns>
        public Task<ModifyVulWhitelistSwitchResponse> ModifyVulWhitelistSwitch(ModifyVulWhitelistSwitchRequest req)
        {
            return InternalRequestAsync<ModifyVulWhitelistSwitchResponse>(req, "ModifyVulWhitelistSwitch");
        }

        /// <summary>
        /// 修改漏洞白名单开关
        /// </summary>
        /// <param name="req"><see cref="ModifyVulWhitelistSwitchRequest"/></param>
        /// <returns><see cref="ModifyVulWhitelistSwitchResponse"/></returns>
        public ModifyVulWhitelistSwitchResponse ModifyVulWhitelistSwitchSync(ModifyVulWhitelistSwitchRequest req)
        {
            return InternalRequestAsync<ModifyVulWhitelistSwitchResponse>(req, "ModifyVulWhitelistSwitch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新增或修改一条通知策略。ID > 0 表示修改；ID = 0 或不传表示新增。MemberAppIds 配置为空时，策略仅作用于当前主账号事件；非空时同时作用于自身账号 + 所列成员账号。
        /// </summary>
        /// <param name="req"><see cref="ModifyWebhookPolicyRequest"/></param>
        /// <returns><see cref="ModifyWebhookPolicyResponse"/></returns>
        public Task<ModifyWebhookPolicyResponse> ModifyWebhookPolicy(ModifyWebhookPolicyRequest req)
        {
            return InternalRequestAsync<ModifyWebhookPolicyResponse>(req, "ModifyWebhookPolicy");
        }

        /// <summary>
        /// 新增或修改一条通知策略。ID > 0 表示修改；ID = 0 或不传表示新增。MemberAppIds 配置为空时，策略仅作用于当前主账号事件；非空时同时作用于自身账号 + 所列成员账号。
        /// </summary>
        /// <param name="req"><see cref="ModifyWebhookPolicyRequest"/></param>
        /// <returns><see cref="ModifyWebhookPolicyResponse"/></returns>
        public ModifyWebhookPolicyResponse ModifyWebhookPolicySync(ModifyWebhookPolicyRequest req)
        {
            return InternalRequestAsync<ModifyWebhookPolicyResponse>(req, "ModifyWebhookPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 切换通知策略的启用状态。
        /// </summary>
        /// <param name="req"><see cref="ModifyWebhookPolicyStatusRequest"/></param>
        /// <returns><see cref="ModifyWebhookPolicyStatusResponse"/></returns>
        public Task<ModifyWebhookPolicyStatusResponse> ModifyWebhookPolicyStatus(ModifyWebhookPolicyStatusRequest req)
        {
            return InternalRequestAsync<ModifyWebhookPolicyStatusResponse>(req, "ModifyWebhookPolicyStatus");
        }

        /// <summary>
        /// 切换通知策略的启用状态。
        /// </summary>
        /// <param name="req"><see cref="ModifyWebhookPolicyStatusRequest"/></param>
        /// <returns><see cref="ModifyWebhookPolicyStatusResponse"/></returns>
        public ModifyWebhookPolicyStatusResponse ModifyWebhookPolicyStatusSync(ModifyWebhookPolicyStatusRequest req)
        {
            return InternalRequestAsync<ModifyWebhookPolicyStatusResponse>(req, "ModifyWebhookPolicyStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新增或修改一个接收机器人。ID > 0 表示修改已有记录；ID = 0 或不传表示新增。机器人类型由 Type 字段决定，Type=WEBHOOK 时 WebhookAddr 必填，Type=SCF 时 SCFRegion/Namespace/FunctionName/FunctionVersion/Alias/MaxWaitSeconds 全部必填。修改时不允许变更 Type
        /// </summary>
        /// <param name="req"><see cref="ModifyWebhookReceiverRequest"/></param>
        /// <returns><see cref="ModifyWebhookReceiverResponse"/></returns>
        public Task<ModifyWebhookReceiverResponse> ModifyWebhookReceiver(ModifyWebhookReceiverRequest req)
        {
            return InternalRequestAsync<ModifyWebhookReceiverResponse>(req, "ModifyWebhookReceiver");
        }

        /// <summary>
        /// 新增或修改一个接收机器人。ID > 0 表示修改已有记录；ID = 0 或不传表示新增。机器人类型由 Type 字段决定，Type=WEBHOOK 时 WebhookAddr 必填，Type=SCF 时 SCFRegion/Namespace/FunctionName/FunctionVersion/Alias/MaxWaitSeconds 全部必填。修改时不允许变更 Type
        /// </summary>
        /// <param name="req"><see cref="ModifyWebhookReceiverRequest"/></param>
        /// <returns><see cref="ModifyWebhookReceiverResponse"/></returns>
        public ModifyWebhookReceiverResponse ModifyWebhookReceiverSync(ModifyWebhookReceiverRequest req)
        {
            return InternalRequestAsync<ModifyWebhookReceiverResponse>(req, "ModifyWebhookReceiver")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 风险操作示例
        /// </summary>
        /// <param name="req"><see cref="OperateRiskRequest"/></param>
        /// <returns><see cref="OperateRiskResponse"/></returns>
        public Task<OperateRiskResponse> OperateRisk(OperateRiskRequest req)
        {
            return InternalRequestAsync<OperateRiskResponse>(req, "OperateRisk");
        }

        /// <summary>
        /// 风险操作示例
        /// </summary>
        /// <param name="req"><see cref="OperateRiskRequest"/></param>
        /// <returns><see cref="OperateRiskResponse"/></returns>
        public OperateRiskResponse OperateRiskSync(OperateRiskRequest req)
        {
            return InternalRequestAsync<OperateRiskResponse>(req, "OperateRisk")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 自定义风险规则
        /// </summary>
        /// <param name="req"><see cref="OperateRiskRulePolicyRequest"/></param>
        /// <returns><see cref="OperateRiskRulePolicyResponse"/></returns>
        public Task<OperateRiskRulePolicyResponse> OperateRiskRulePolicy(OperateRiskRulePolicyRequest req)
        {
            return InternalRequestAsync<OperateRiskRulePolicyResponse>(req, "OperateRiskRulePolicy");
        }

        /// <summary>
        /// 自定义风险规则
        /// </summary>
        /// <param name="req"><see cref="OperateRiskRulePolicyRequest"/></param>
        /// <returns><see cref="OperateRiskRulePolicyResponse"/></returns>
        public OperateRiskRulePolicyResponse OperateRiskRulePolicySync(OperateRiskRulePolicyRequest req)
        {
            return InternalRequestAsync<OperateRiskRulePolicyResponse>(req, "OperateRiskRulePolicy")
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
        /// 对单个资产的部分检测项发起重新扫描（资产详情页“重新扫描”入口）。
        /// </summary>
        /// <param name="req"><see cref="ScanBaselineAssetItemListRequest"/></param>
        /// <returns><see cref="ScanBaselineAssetItemListResponse"/></returns>
        public Task<ScanBaselineAssetItemListResponse> ScanBaselineAssetItemList(ScanBaselineAssetItemListRequest req)
        {
            return InternalRequestAsync<ScanBaselineAssetItemListResponse>(req, "ScanBaselineAssetItemList");
        }

        /// <summary>
        /// 对单个资产的部分检测项发起重新扫描（资产详情页“重新扫描”入口）。
        /// </summary>
        /// <param name="req"><see cref="ScanBaselineAssetItemListRequest"/></param>
        /// <returns><see cref="ScanBaselineAssetItemListResponse"/></returns>
        public ScanBaselineAssetItemListResponse ScanBaselineAssetItemListSync(ScanBaselineAssetItemListRequest req)
        {
            return InternalRequestAsync<ScanBaselineAssetItemListResponse>(req, "ScanBaselineAssetItemList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 对指定策略下的一批检测项发起重新扫描（策略详情页“检测项”维度的复扫入口）。
        /// </summary>
        /// <param name="req"><see cref="ScanBaselineItemListRequest"/></param>
        /// <returns><see cref="ScanBaselineItemListResponse"/></returns>
        public Task<ScanBaselineItemListResponse> ScanBaselineItemList(ScanBaselineItemListRequest req)
        {
            return InternalRequestAsync<ScanBaselineItemListResponse>(req, "ScanBaselineItemList");
        }

        /// <summary>
        /// 对指定策略下的一批检测项发起重新扫描（策略详情页“检测项”维度的复扫入口）。
        /// </summary>
        /// <param name="req"><see cref="ScanBaselineItemListRequest"/></param>
        /// <returns><see cref="ScanBaselineItemListResponse"/></returns>
        public ScanBaselineItemListResponse ScanBaselineItemListSync(ScanBaselineItemListRequest req)
        {
            return InternalRequestAsync<ScanBaselineItemListResponse>(req, "ScanBaselineItemList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 对一批基线策略发起整体重新扫描（策略列表页“一键扫描”入口），按策略命中的资产范围全量重扫。
        /// </summary>
        /// <param name="req"><see cref="ScanBaselinePolicyListRequest"/></param>
        /// <returns><see cref="ScanBaselinePolicyListResponse"/></returns>
        public Task<ScanBaselinePolicyListResponse> ScanBaselinePolicyList(ScanBaselinePolicyListRequest req)
        {
            return InternalRequestAsync<ScanBaselinePolicyListResponse>(req, "ScanBaselinePolicyList");
        }

        /// <summary>
        /// 对一批基线策略发起整体重新扫描（策略列表页“一键扫描”入口），按策略命中的资产范围全量重扫。
        /// </summary>
        /// <param name="req"><see cref="ScanBaselinePolicyListRequest"/></param>
        /// <returns><see cref="ScanBaselinePolicyListResponse"/></returns>
        public ScanBaselinePolicyListResponse ScanBaselinePolicyListSync(ScanBaselinePolicyListRequest req)
        {
            return InternalRequestAsync<ScanBaselinePolicyListResponse>(req, "ScanBaselinePolicyList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 对一批风险记录发起重新扫描，常用于“风险列表”页批量勾选风险后的复扫场景。
        /// </summary>
        /// <param name="req"><see cref="ScanBaselineRiskListRequest"/></param>
        /// <returns><see cref="ScanBaselineRiskListResponse"/></returns>
        public Task<ScanBaselineRiskListResponse> ScanBaselineRiskList(ScanBaselineRiskListRequest req)
        {
            return InternalRequestAsync<ScanBaselineRiskListResponse>(req, "ScanBaselineRiskList");
        }

        /// <summary>
        /// 对一批风险记录发起重新扫描，常用于“风险列表”页批量勾选风险后的复扫场景。
        /// </summary>
        /// <param name="req"><see cref="ScanBaselineRiskListRequest"/></param>
        /// <returns><see cref="ScanBaselineRiskListResponse"/></returns>
        public ScanBaselineRiskListResponse ScanBaselineRiskListSync(ScanBaselineRiskListRequest req)
        {
            return InternalRequestAsync<ScanBaselineRiskListResponse>(req, "ScanBaselineRiskList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// CSIP 手动扫描任务删除接口
        /// </summary>
        /// <param name="req"><see cref="ScanCSIPTaskAgainRequest"/></param>
        /// <returns><see cref="ScanCSIPTaskAgainResponse"/></returns>
        public Task<ScanCSIPTaskAgainResponse> ScanCSIPTaskAgain(ScanCSIPTaskAgainRequest req)
        {
            return InternalRequestAsync<ScanCSIPTaskAgainResponse>(req, "ScanCSIPTaskAgain");
        }

        /// <summary>
        /// CSIP 手动扫描任务删除接口
        /// </summary>
        /// <param name="req"><see cref="ScanCSIPTaskAgainRequest"/></param>
        /// <returns><see cref="ScanCSIPTaskAgainResponse"/></returns>
        public ScanCSIPTaskAgainResponse ScanCSIPTaskAgainSync(ScanCSIPTaskAgainRequest req)
        {
            return InternalRequestAsync<ScanCSIPTaskAgainResponse>(req, "ScanCSIPTaskAgain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 基于原任务配置新建扫描任务。AssetId为空时从TaskId获取全部资产信息；AssetId非空时仅含该单资产。
        /// </summary>
        /// <param name="req"><see cref="ScanEDRTaskAgainRequest"/></param>
        /// <returns><see cref="ScanEDRTaskAgainResponse"/></returns>
        public Task<ScanEDRTaskAgainResponse> ScanEDRTaskAgain(ScanEDRTaskAgainRequest req)
        {
            return InternalRequestAsync<ScanEDRTaskAgainResponse>(req, "ScanEDRTaskAgain");
        }

        /// <summary>
        /// 基于原任务配置新建扫描任务。AssetId为空时从TaskId获取全部资产信息；AssetId非空时仅含该单资产。
        /// </summary>
        /// <param name="req"><see cref="ScanEDRTaskAgainRequest"/></param>
        /// <returns><see cref="ScanEDRTaskAgainResponse"/></returns>
        public ScanEDRTaskAgainResponse ScanEDRTaskAgainSync(ScanEDRTaskAgainRequest req)
        {
            return InternalRequestAsync<ScanEDRTaskAgainResponse>(req, "ScanEDRTaskAgain")
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
        /// 开启或者修改防卸载功能配置
        /// </summary>
        /// <param name="req"><see cref="StartOrModifyPreventUninstallRequest"/></param>
        /// <returns><see cref="StartOrModifyPreventUninstallResponse"/></returns>
        public Task<StartOrModifyPreventUninstallResponse> StartOrModifyPreventUninstall(StartOrModifyPreventUninstallRequest req)
        {
            return InternalRequestAsync<StartOrModifyPreventUninstallResponse>(req, "StartOrModifyPreventUninstall");
        }

        /// <summary>
        /// 开启或者修改防卸载功能配置
        /// </summary>
        /// <param name="req"><see cref="StartOrModifyPreventUninstallRequest"/></param>
        /// <returns><see cref="StartOrModifyPreventUninstallResponse"/></returns>
        public StartOrModifyPreventUninstallResponse StartOrModifyPreventUninstallSync(StartOrModifyPreventUninstallRequest req)
        {
            return InternalRequestAsync<StartOrModifyPreventUninstallResponse>(req, "StartOrModifyPreventUninstall")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开启或者修改进程守护功能配置
        /// </summary>
        /// <param name="req"><see cref="StartOrModifyProcessDaemonRequest"/></param>
        /// <returns><see cref="StartOrModifyProcessDaemonResponse"/></returns>
        public Task<StartOrModifyProcessDaemonResponse> StartOrModifyProcessDaemon(StartOrModifyProcessDaemonRequest req)
        {
            return InternalRequestAsync<StartOrModifyProcessDaemonResponse>(req, "StartOrModifyProcessDaemon");
        }

        /// <summary>
        /// 开启或者修改进程守护功能配置
        /// </summary>
        /// <param name="req"><see cref="StartOrModifyProcessDaemonRequest"/></param>
        /// <returns><see cref="StartOrModifyProcessDaemonResponse"/></returns>
        public StartOrModifyProcessDaemonResponse StartOrModifyProcessDaemonSync(StartOrModifyProcessDaemonRequest req)
        {
            return InternalRequestAsync<StartOrModifyProcessDaemonResponse>(req, "StartOrModifyProcessDaemon")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止指定的基线扫描主任务，仅对处于 INIT / SUBTASK_CREATING / SCANNING 状态的任务生效。
        /// </summary>
        /// <param name="req"><see cref="StopBaselineScanTaskRequest"/></param>
        /// <returns><see cref="StopBaselineScanTaskResponse"/></returns>
        public Task<StopBaselineScanTaskResponse> StopBaselineScanTask(StopBaselineScanTaskRequest req)
        {
            return InternalRequestAsync<StopBaselineScanTaskResponse>(req, "StopBaselineScanTask");
        }

        /// <summary>
        /// 停止指定的基线扫描主任务，仅对处于 INIT / SUBTASK_CREATING / SCANNING 状态的任务生效。
        /// </summary>
        /// <param name="req"><see cref="StopBaselineScanTaskRequest"/></param>
        /// <returns><see cref="StopBaselineScanTaskResponse"/></returns>
        public StopBaselineScanTaskResponse StopBaselineScanTaskSync(StopBaselineScanTaskRequest req)
        {
            return InternalRequestAsync<StopBaselineScanTaskResponse>(req, "StopBaselineScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// CSIP 手动扫描停止接口
        /// </summary>
        /// <param name="req"><see cref="StopCSIPManualMalwareScanRequest"/></param>
        /// <returns><see cref="StopCSIPManualMalwareScanResponse"/></returns>
        public Task<StopCSIPManualMalwareScanResponse> StopCSIPManualMalwareScan(StopCSIPManualMalwareScanRequest req)
        {
            return InternalRequestAsync<StopCSIPManualMalwareScanResponse>(req, "StopCSIPManualMalwareScan");
        }

        /// <summary>
        /// CSIP 手动扫描停止接口
        /// </summary>
        /// <param name="req"><see cref="StopCSIPManualMalwareScanRequest"/></param>
        /// <returns><see cref="StopCSIPManualMalwareScanResponse"/></returns>
        public StopCSIPManualMalwareScanResponse StopCSIPManualMalwareScanSync(StopCSIPManualMalwareScanRequest req)
        {
            return InternalRequestAsync<StopCSIPManualMalwareScanResponse>(req, "StopCSIPManualMalwareScan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止或取消扫描任务。SCANNING状态调RPC停止，WAIT状态直接改库取消。只有任务创建者可操作。
        /// </summary>
        /// <param name="req"><see cref="StopEDRScanTaskRequest"/></param>
        /// <returns><see cref="StopEDRScanTaskResponse"/></returns>
        public Task<StopEDRScanTaskResponse> StopEDRScanTask(StopEDRScanTaskRequest req)
        {
            return InternalRequestAsync<StopEDRScanTaskResponse>(req, "StopEDRScanTask");
        }

        /// <summary>
        /// 停止或取消扫描任务。SCANNING状态调RPC停止，WAIT状态直接改库取消。只有任务创建者可操作。
        /// </summary>
        /// <param name="req"><see cref="StopEDRScanTaskRequest"/></param>
        /// <returns><see cref="StopEDRScanTaskResponse"/></returns>
        public StopEDRScanTaskResponse StopEDRScanTaskSync(StopEDRScanTaskRequest req)
        {
            return InternalRequestAsync<StopEDRScanTaskResponse>(req, "StopEDRScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止镜像仓库镜像扫描任务
        /// </summary>
        /// <param name="req"><see cref="StopImageRegistryScanTaskRequest"/></param>
        /// <returns><see cref="StopImageRegistryScanTaskResponse"/></returns>
        public Task<StopImageRegistryScanTaskResponse> StopImageRegistryScanTask(StopImageRegistryScanTaskRequest req)
        {
            return InternalRequestAsync<StopImageRegistryScanTaskResponse>(req, "StopImageRegistryScanTask");
        }

        /// <summary>
        /// 停止镜像仓库镜像扫描任务
        /// </summary>
        /// <param name="req"><see cref="StopImageRegistryScanTaskRequest"/></param>
        /// <returns><see cref="StopImageRegistryScanTaskResponse"/></returns>
        public StopImageRegistryScanTaskResponse StopImageRegistryScanTaskSync(StopImageRegistryScanTaskRequest req)
        {
            return InternalRequestAsync<StopImageRegistryScanTaskResponse>(req, "StopImageRegistryScanTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 关闭防卸载功能
        /// </summary>
        /// <param name="req"><see cref="StopPreventUninstallRequest"/></param>
        /// <returns><see cref="StopPreventUninstallResponse"/></returns>
        public Task<StopPreventUninstallResponse> StopPreventUninstall(StopPreventUninstallRequest req)
        {
            return InternalRequestAsync<StopPreventUninstallResponse>(req, "StopPreventUninstall");
        }

        /// <summary>
        /// 关闭防卸载功能
        /// </summary>
        /// <param name="req"><see cref="StopPreventUninstallRequest"/></param>
        /// <returns><see cref="StopPreventUninstallResponse"/></returns>
        public StopPreventUninstallResponse StopPreventUninstallSync(StopPreventUninstallRequest req)
        {
            return InternalRequestAsync<StopPreventUninstallResponse>(req, "StopPreventUninstall")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 关闭进程守护功能
        /// </summary>
        /// <param name="req"><see cref="StopProcessDaemonRequest"/></param>
        /// <returns><see cref="StopProcessDaemonResponse"/></returns>
        public Task<StopProcessDaemonResponse> StopProcessDaemon(StopProcessDaemonRequest req)
        {
            return InternalRequestAsync<StopProcessDaemonResponse>(req, "StopProcessDaemon");
        }

        /// <summary>
        /// 关闭进程守护功能
        /// </summary>
        /// <param name="req"><see cref="StopProcessDaemonRequest"/></param>
        /// <returns><see cref="StopProcessDaemonResponse"/></returns>
        public StopProcessDaemonResponse StopProcessDaemonSync(StopProcessDaemonRequest req)
        {
            return InternalRequestAsync<StopProcessDaemonResponse>(req, "StopProcessDaemon")
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
        /// 停止漏洞扫描（任务扫描）
        /// </summary>
        /// <param name="req"><see cref="StopVulScanTaskRequest"/></param>
        /// <returns><see cref="StopVulScanTaskResponse"/></returns>
        public Task<StopVulScanTaskResponse> StopVulScanTask(StopVulScanTaskRequest req)
        {
            return InternalRequestAsync<StopVulScanTaskResponse>(req, "StopVulScanTask");
        }

        /// <summary>
        /// 停止漏洞扫描（任务扫描）
        /// </summary>
        /// <param name="req"><see cref="StopVulScanTaskRequest"/></param>
        /// <returns><see cref="StopVulScanTaskResponse"/></returns>
        public StopVulScanTaskResponse StopVulScanTaskSync(StopVulScanTaskRequest req)
        {
            return InternalRequestAsync<StopVulScanTaskResponse>(req, "StopVulScanTask")
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
        /// 镜像仓库同步
        /// </summary>
        /// <param name="req"><see cref="SyncImageRegistryRequest"/></param>
        /// <returns><see cref="SyncImageRegistryResponse"/></returns>
        public Task<SyncImageRegistryResponse> SyncImageRegistry(SyncImageRegistryRequest req)
        {
            return InternalRequestAsync<SyncImageRegistryResponse>(req, "SyncImageRegistry");
        }

        /// <summary>
        /// 镜像仓库同步
        /// </summary>
        /// <param name="req"><see cref="SyncImageRegistryRequest"/></param>
        /// <returns><see cref="SyncImageRegistryResponse"/></returns>
        public SyncImageRegistryResponse SyncImageRegistrySync(SyncImageRegistryRequest req)
        {
            return InternalRequestAsync<SyncImageRegistryResponse>(req, "SyncImageRegistry")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 向指定的接收机器人发送一条测试消息，验证可达性与配置正确性。对应表格行内的「测试」按钮。
        /// </summary>
        /// <param name="req"><see cref="TestWebhookReceiverRequest"/></param>
        /// <returns><see cref="TestWebhookReceiverResponse"/></returns>
        public Task<TestWebhookReceiverResponse> TestWebhookReceiver(TestWebhookReceiverRequest req)
        {
            return InternalRequestAsync<TestWebhookReceiverResponse>(req, "TestWebhookReceiver");
        }

        /// <summary>
        /// 向指定的接收机器人发送一条测试消息，验证可达性与配置正确性。对应表格行内的「测试」按钮。
        /// </summary>
        /// <param name="req"><see cref="TestWebhookReceiverRequest"/></param>
        /// <returns><see cref="TestWebhookReceiverResponse"/></returns>
        public TestWebhookReceiverResponse TestWebhookReceiverSync(TestWebhookReceiverRequest req)
        {
            return InternalRequestAsync<TestWebhookReceiverResponse>(req, "TestWebhookReceiver")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 卸载集群容器安全Agent。
        /// </summary>
        /// <param name="req"><see cref="UninstallClusterAgentRequest"/></param>
        /// <returns><see cref="UninstallClusterAgentResponse"/></returns>
        public Task<UninstallClusterAgentResponse> UninstallClusterAgent(UninstallClusterAgentRequest req)
        {
            return InternalRequestAsync<UninstallClusterAgentResponse>(req, "UninstallClusterAgent");
        }

        /// <summary>
        /// 卸载集群容器安全Agent。
        /// </summary>
        /// <param name="req"><see cref="UninstallClusterAgentRequest"/></param>
        /// <returns><see cref="UninstallClusterAgentResponse"/></returns>
        public UninstallClusterAgentResponse UninstallClusterAgentSync(UninstallClusterAgentRequest req)
        {
            return InternalRequestAsync<UninstallClusterAgentResponse>(req, "UninstallClusterAgent")
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
        /// 绑定、更新集群负责人
        /// </summary>
        /// <param name="req"><see cref="UpdateClusterOwnerRequest"/></param>
        /// <returns><see cref="UpdateClusterOwnerResponse"/></returns>
        public Task<UpdateClusterOwnerResponse> UpdateClusterOwner(UpdateClusterOwnerRequest req)
        {
            return InternalRequestAsync<UpdateClusterOwnerResponse>(req, "UpdateClusterOwner");
        }

        /// <summary>
        /// 绑定、更新集群负责人
        /// </summary>
        /// <param name="req"><see cref="UpdateClusterOwnerRequest"/></param>
        /// <returns><see cref="UpdateClusterOwnerResponse"/></returns>
        public UpdateClusterOwnerResponse UpdateClusterOwnerSync(UpdateClusterOwnerRequest req)
        {
            return InternalRequestAsync<UpdateClusterOwnerResponse>(req, "UpdateClusterOwner")
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

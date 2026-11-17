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

namespace TencentCloud.Dbs.V20211108
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Dbs.V20211108.Models;

   public class DbsClient : AbstractClient{

       private const string endpoint = "dbs.tencentcloudapi.com";
       private const string version = "2021-11-08";
       private const string sdkVersion = "SDK_NET_3.0.1536";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DbsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public DbsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 本接口（ConfigureBackupPlan）用于配置备份计划。包括配置备份源实例信息、备份对象以及备份策略等。
        /// </summary>
        /// <param name="req"><see cref="ConfigureBackupPlanRequest"/></param>
        /// <returns><see cref="ConfigureBackupPlanResponse"/></returns>
        public Task<ConfigureBackupPlanResponse> ConfigureBackupPlan(ConfigureBackupPlanRequest req)
        {
            return InternalRequestAsync<ConfigureBackupPlanResponse>(req, "ConfigureBackupPlan");
        }

        /// <summary>
        /// 本接口（ConfigureBackupPlan）用于配置备份计划。包括配置备份源实例信息、备份对象以及备份策略等。
        /// </summary>
        /// <param name="req"><see cref="ConfigureBackupPlanRequest"/></param>
        /// <returns><see cref="ConfigureBackupPlanResponse"/></returns>
        public ConfigureBackupPlanResponse ConfigureBackupPlanSync(ConfigureBackupPlanRequest req)
        {
            return InternalRequestAsync<ConfigureBackupPlanResponse>(req, "ConfigureBackupPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于创建备份计划。
        /// </summary>
        /// <param name="req"><see cref="CreateBackupPlanRequest"/></param>
        /// <returns><see cref="CreateBackupPlanResponse"/></returns>
        public Task<CreateBackupPlanResponse> CreateBackupPlan(CreateBackupPlanRequest req)
        {
            return InternalRequestAsync<CreateBackupPlanResponse>(req, "CreateBackupPlan");
        }

        /// <summary>
        /// 该接口用于创建备份计划。
        /// </summary>
        /// <param name="req"><see cref="CreateBackupPlanRequest"/></param>
        /// <returns><see cref="CreateBackupPlanResponse"/></returns>
        public CreateBackupPlanResponse CreateBackupPlanSync(CreateBackupPlanRequest req)
        {
            return InternalRequestAsync<CreateBackupPlanResponse>(req, "CreateBackupPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于创建连通性检测任务，请在创建备份计划前，通过该接口来检测你的源端实例是否连通性正常。
        /// </summary>
        /// <param name="req"><see cref="CreateConnectTestJobRequest"/></param>
        /// <returns><see cref="CreateConnectTestJobResponse"/></returns>
        public Task<CreateConnectTestJobResponse> CreateConnectTestJob(CreateConnectTestJobRequest req)
        {
            return InternalRequestAsync<CreateConnectTestJobResponse>(req, "CreateConnectTestJob");
        }

        /// <summary>
        /// 该接口用于创建连通性检测任务，请在创建备份计划前，通过该接口来检测你的源端实例是否连通性正常。
        /// </summary>
        /// <param name="req"><see cref="CreateConnectTestJobRequest"/></param>
        /// <returns><see cref="CreateConnectTestJobResponse"/></returns>
        public CreateConnectTestJobResponse CreateConnectTestJobSync(CreateConnectTestJobRequest req)
        {
            return InternalRequestAsync<CreateConnectTestJobResponse>(req, "CreateConnectTestJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除备份计划。
        /// 
        /// 仅已下线的备份计划支持删除，删除后不可恢复。已隔离（isolated）的备份计划请先调用 DestroyBackupPlanByUser 完成下线，再进行删除。调用接口后，若通过 DescribeBackupPlans 接口查询不到对应的备份计划，则表示删除成功。
        /// </summary>
        /// <param name="req"><see cref="DeleteBackupPlanRequest"/></param>
        /// <returns><see cref="DeleteBackupPlanResponse"/></returns>
        public Task<DeleteBackupPlanResponse> DeleteBackupPlan(DeleteBackupPlanRequest req)
        {
            return InternalRequestAsync<DeleteBackupPlanResponse>(req, "DeleteBackupPlan");
        }

        /// <summary>
        /// 删除备份计划。
        /// 
        /// 仅已下线的备份计划支持删除，删除后不可恢复。已隔离（isolated）的备份计划请先调用 DestroyBackupPlanByUser 完成下线，再进行删除。调用接口后，若通过 DescribeBackupPlans 接口查询不到对应的备份计划，则表示删除成功。
        /// </summary>
        /// <param name="req"><see cref="DeleteBackupPlanRequest"/></param>
        /// <returns><see cref="DeleteBackupPlanResponse"/></returns>
        public DeleteBackupPlanResponse DeleteBackupPlanSync(DeleteBackupPlanRequest req)
        {
            return InternalRequestAsync<DeleteBackupPlanResponse>(req, "DeleteBackupPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeBackupCheckJob）用于查询备份计划预校验任务的结果。仅对于预校验通过的任务，才能启动备份计划。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupCheckJobRequest"/></param>
        /// <returns><see cref="DescribeBackupCheckJobResponse"/></returns>
        public Task<DescribeBackupCheckJobResponse> DescribeBackupCheckJob(DescribeBackupCheckJobRequest req)
        {
            return InternalRequestAsync<DescribeBackupCheckJobResponse>(req, "DescribeBackupCheckJob");
        }

        /// <summary>
        /// 本接口（DescribeBackupCheckJob）用于查询备份计划预校验任务的结果。仅对于预校验通过的任务，才能启动备份计划。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupCheckJobRequest"/></param>
        /// <returns><see cref="DescribeBackupCheckJobResponse"/></returns>
        public DescribeBackupCheckJobResponse DescribeBackupCheckJobSync(DescribeBackupCheckJobRequest req)
        {
            return InternalRequestAsync<DescribeBackupCheckJobResponse>(req, "DescribeBackupCheckJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询备份计划详情。
        /// 返回备份计划的基本信息、源库信息、备份对象、备份策略、备份进度和付费信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupPlanDetailRequest"/></param>
        /// <returns><see cref="DescribeBackupPlanDetailResponse"/></returns>
        public Task<DescribeBackupPlanDetailResponse> DescribeBackupPlanDetail(DescribeBackupPlanDetailRequest req)
        {
            return InternalRequestAsync<DescribeBackupPlanDetailResponse>(req, "DescribeBackupPlanDetail");
        }

        /// <summary>
        /// 查询备份计划详情。
        /// 返回备份计划的基本信息、源库信息、备份对象、备份策略、备份进度和付费信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupPlanDetailRequest"/></param>
        /// <returns><see cref="DescribeBackupPlanDetailResponse"/></returns>
        public DescribeBackupPlanDetailResponse DescribeBackupPlanDetailSync(DescribeBackupPlanDetailRequest req)
        {
            return InternalRequestAsync<DescribeBackupPlanDetailResponse>(req, "DescribeBackupPlanDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeBackupPlans）用于查询备份计划列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupPlansRequest"/></param>
        /// <returns><see cref="DescribeBackupPlansResponse"/></returns>
        public Task<DescribeBackupPlansResponse> DescribeBackupPlans(DescribeBackupPlansRequest req)
        {
            return InternalRequestAsync<DescribeBackupPlansResponse>(req, "DescribeBackupPlans");
        }

        /// <summary>
        /// 本接口（DescribeBackupPlans）用于查询备份计划列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupPlansRequest"/></param>
        /// <returns><see cref="DescribeBackupPlansResponse"/></returns>
        public DescribeBackupPlansResponse DescribeBackupPlansSync(DescribeBackupPlansRequest req)
        {
            return InternalRequestAsync<DescribeBackupPlansResponse>(req, "DescribeBackupPlans")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于查询连通性检测任务的结果
        /// </summary>
        /// <param name="req"><see cref="DescribeConnectTestResultRequest"/></param>
        /// <returns><see cref="DescribeConnectTestResultResponse"/></returns>
        public Task<DescribeConnectTestResultResponse> DescribeConnectTestResult(DescribeConnectTestResultRequest req)
        {
            return InternalRequestAsync<DescribeConnectTestResultResponse>(req, "DescribeConnectTestResult");
        }

        /// <summary>
        /// 该接口用于查询连通性检测任务的结果
        /// </summary>
        /// <param name="req"><see cref="DescribeConnectTestResultRequest"/></param>
        /// <returns><see cref="DescribeConnectTestResultResponse"/></returns>
        public DescribeConnectTestResultResponse DescribeConnectTestResultSync(DescribeConnectTestResultRequest req)
        {
            return InternalRequestAsync<DescribeConnectTestResultResponse>(req, "DescribeConnectTestResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询全量备份集详情。
        /// 
        /// 返回全量备份集的基本信息、源库信息、备份对象、备份进度和加密信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeFullBackupSetDetailRequest"/></param>
        /// <returns><see cref="DescribeFullBackupSetDetailResponse"/></returns>
        public Task<DescribeFullBackupSetDetailResponse> DescribeFullBackupSetDetail(DescribeFullBackupSetDetailRequest req)
        {
            return InternalRequestAsync<DescribeFullBackupSetDetailResponse>(req, "DescribeFullBackupSetDetail");
        }

        /// <summary>
        /// 查询全量备份集详情。
        /// 
        /// 返回全量备份集的基本信息、源库信息、备份对象、备份进度和加密信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeFullBackupSetDetailRequest"/></param>
        /// <returns><see cref="DescribeFullBackupSetDetailResponse"/></returns>
        public DescribeFullBackupSetDetailResponse DescribeFullBackupSetDetailSync(DescribeFullBackupSetDetailRequest req)
        {
            return InternalRequestAsync<DescribeFullBackupSetDetailResponse>(req, "DescribeFullBackupSetDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询增量备份集文件列表。
        /// 
        /// 文件按最后修改时间倒序返回，支持分页。
        /// </summary>
        /// <param name="req"><see cref="DescribeIncrementBackupSetFilesRequest"/></param>
        /// <returns><see cref="DescribeIncrementBackupSetFilesResponse"/></returns>
        public Task<DescribeIncrementBackupSetFilesResponse> DescribeIncrementBackupSetFiles(DescribeIncrementBackupSetFilesRequest req)
        {
            return InternalRequestAsync<DescribeIncrementBackupSetFilesResponse>(req, "DescribeIncrementBackupSetFiles");
        }

        /// <summary>
        /// 查询增量备份集文件列表。
        /// 
        /// 文件按最后修改时间倒序返回，支持分页。
        /// </summary>
        /// <param name="req"><see cref="DescribeIncrementBackupSetFilesRequest"/></param>
        /// <returns><see cref="DescribeIncrementBackupSetFilesResponse"/></returns>
        public DescribeIncrementBackupSetFilesResponse DescribeIncrementBackupSetFilesSync(DescribeIncrementBackupSetFilesRequest req)
        {
            return InternalRequestAsync<DescribeIncrementBackupSetFilesResponse>(req, "DescribeIncrementBackupSetFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeIncrementBackupSets）用于查询增量备份集列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeIncrementBackupSetsRequest"/></param>
        /// <returns><see cref="DescribeIncrementBackupSetsResponse"/></returns>
        public Task<DescribeIncrementBackupSetsResponse> DescribeIncrementBackupSets(DescribeIncrementBackupSetsRequest req)
        {
            return InternalRequestAsync<DescribeIncrementBackupSetsResponse>(req, "DescribeIncrementBackupSets");
        }

        /// <summary>
        /// 本接口（DescribeIncrementBackupSets）用于查询增量备份集列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeIncrementBackupSetsRequest"/></param>
        /// <returns><see cref="DescribeIncrementBackupSetsResponse"/></returns>
        public DescribeIncrementBackupSetsResponse DescribeIncrementBackupSetsSync(DescribeIncrementBackupSetsRequest req)
        {
            return InternalRequestAsync<DescribeIncrementBackupSetsResponse>(req, "DescribeIncrementBackupSets")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 立即下线已隔离的备份计划。
        /// 
        /// 下线后备份计划不可恢复。调用接口后，若通过 DescribeBackupPlanDetail 接口查询到备份计划状态为 offlined，则表示下线成功。
        /// </summary>
        /// <param name="req"><see cref="DestroyBackupPlanByUserRequest"/></param>
        /// <returns><see cref="DestroyBackupPlanByUserResponse"/></returns>
        public Task<DestroyBackupPlanByUserResponse> DestroyBackupPlanByUser(DestroyBackupPlanByUserRequest req)
        {
            return InternalRequestAsync<DestroyBackupPlanByUserResponse>(req, "DestroyBackupPlanByUser");
        }

        /// <summary>
        /// 立即下线已隔离的备份计划。
        /// 
        /// 下线后备份计划不可恢复。调用接口后，若通过 DescribeBackupPlanDetail 接口查询到备份计划状态为 offlined，则表示下线成功。
        /// </summary>
        /// <param name="req"><see cref="DestroyBackupPlanByUserRequest"/></param>
        /// <returns><see cref="DestroyBackupPlanByUserResponse"/></returns>
        public DestroyBackupPlanByUserResponse DestroyBackupPlanByUserSync(DestroyBackupPlanByUserRequest req)
        {
            return InternalRequestAsync<DestroyBackupPlanByUserResponse>(req, "DestroyBackupPlanByUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（ModifyBackupPlanSourceInfo）用于修改备份计划的源实例信息、备份对象信息等。注意，调用该接口后，原有备份计划任务将立即停止，您可以在修改完源信息后重新启动备份任务。
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupPlanSourceInfoRequest"/></param>
        /// <returns><see cref="ModifyBackupPlanSourceInfoResponse"/></returns>
        public Task<ModifyBackupPlanSourceInfoResponse> ModifyBackupPlanSourceInfo(ModifyBackupPlanSourceInfoRequest req)
        {
            return InternalRequestAsync<ModifyBackupPlanSourceInfoResponse>(req, "ModifyBackupPlanSourceInfo");
        }

        /// <summary>
        /// 本接口（ModifyBackupPlanSourceInfo）用于修改备份计划的源实例信息、备份对象信息等。注意，调用该接口后，原有备份计划任务将立即停止，您可以在修改完源信息后重新启动备份任务。
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupPlanSourceInfoRequest"/></param>
        /// <returns><see cref="ModifyBackupPlanSourceInfoResponse"/></returns>
        public ModifyBackupPlanSourceInfoResponse ModifyBackupPlanSourceInfoSync(ModifyBackupPlanSourceInfoRequest req)
        {
            return InternalRequestAsync<ModifyBackupPlanSourceInfoResponse>(req, "ModifyBackupPlanSourceInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 恢复已暂停的备份计划。
        /// 
        /// 仅已暂停的备份计划支持恢复。调用接口后，若通过 DescribeBackupPlanDetail 接口查询到备份计划状态为 running，则表示恢复成功。
        /// </summary>
        /// <param name="req"><see cref="ResumeBackupPlanRequest"/></param>
        /// <returns><see cref="ResumeBackupPlanResponse"/></returns>
        public Task<ResumeBackupPlanResponse> ResumeBackupPlan(ResumeBackupPlanRequest req)
        {
            return InternalRequestAsync<ResumeBackupPlanResponse>(req, "ResumeBackupPlan");
        }

        /// <summary>
        /// 恢复已暂停的备份计划。
        /// 
        /// 仅已暂停的备份计划支持恢复。调用接口后，若通过 DescribeBackupPlanDetail 接口查询到备份计划状态为 running，则表示恢复成功。
        /// </summary>
        /// <param name="req"><see cref="ResumeBackupPlanRequest"/></param>
        /// <returns><see cref="ResumeBackupPlanResponse"/></returns>
        public ResumeBackupPlanResponse ResumeBackupPlanSync(ResumeBackupPlanRequest req)
        {
            return InternalRequestAsync<ResumeBackupPlanResponse>(req, "ResumeBackupPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（StartBackupCheckJob）用于创建备份计划预校验任务。
        /// </summary>
        /// <param name="req"><see cref="StartBackupCheckJobRequest"/></param>
        /// <returns><see cref="StartBackupCheckJobResponse"/></returns>
        public Task<StartBackupCheckJobResponse> StartBackupCheckJob(StartBackupCheckJobRequest req)
        {
            return InternalRequestAsync<StartBackupCheckJobResponse>(req, "StartBackupCheckJob");
        }

        /// <summary>
        /// 本接口（StartBackupCheckJob）用于创建备份计划预校验任务。
        /// </summary>
        /// <param name="req"><see cref="StartBackupCheckJobRequest"/></param>
        /// <returns><see cref="StartBackupCheckJobResponse"/></returns>
        public StartBackupCheckJobResponse StartBackupCheckJobSync(StartBackupCheckJobRequest req)
        {
            return InternalRequestAsync<StartBackupCheckJobResponse>(req, "StartBackupCheckJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（StartBackupPlan）用于启动备份计划。调用此接口前，请务必先使用 StartBackupCheckJob 创建备份计划预校验任务，并通过 DescribeBackupCheckJob 接口查询到任务状态为校验通过时，才能启动备份计划。
        /// </summary>
        /// <param name="req"><see cref="StartBackupPlanRequest"/></param>
        /// <returns><see cref="StartBackupPlanResponse"/></returns>
        public Task<StartBackupPlanResponse> StartBackupPlan(StartBackupPlanRequest req)
        {
            return InternalRequestAsync<StartBackupPlanResponse>(req, "StartBackupPlan");
        }

        /// <summary>
        /// 本接口（StartBackupPlan）用于启动备份计划。调用此接口前，请务必先使用 StartBackupCheckJob 创建备份计划预校验任务，并通过 DescribeBackupCheckJob 接口查询到任务状态为校验通过时，才能启动备份计划。
        /// </summary>
        /// <param name="req"><see cref="StartBackupPlanRequest"/></param>
        /// <returns><see cref="StartBackupPlanResponse"/></returns>
        public StartBackupPlanResponse StartBackupPlanSync(StartBackupPlanRequest req)
        {
            return InternalRequestAsync<StartBackupPlanResponse>(req, "StartBackupPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 暂停备份计划。
        /// 
        /// 仅运行中的备份计划支持暂停。调用接口后，若通过 DescribeBackupPlanDetail 接口查询到备份计划状态为 paused，则表示暂停成功。
        /// </summary>
        /// <param name="req"><see cref="StopBackupPlanRequest"/></param>
        /// <returns><see cref="StopBackupPlanResponse"/></returns>
        public Task<StopBackupPlanResponse> StopBackupPlan(StopBackupPlanRequest req)
        {
            return InternalRequestAsync<StopBackupPlanResponse>(req, "StopBackupPlan");
        }

        /// <summary>
        /// 暂停备份计划。
        /// 
        /// 仅运行中的备份计划支持暂停。调用接口后，若通过 DescribeBackupPlanDetail 接口查询到备份计划状态为 paused，则表示暂停成功。
        /// </summary>
        /// <param name="req"><see cref="StopBackupPlanRequest"/></param>
        /// <returns><see cref="StopBackupPlanResponse"/></returns>
        public StopBackupPlanResponse StopBackupPlanSync(StopBackupPlanRequest req)
        {
            return InternalRequestAsync<StopBackupPlanResponse>(req, "StopBackupPlan")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}

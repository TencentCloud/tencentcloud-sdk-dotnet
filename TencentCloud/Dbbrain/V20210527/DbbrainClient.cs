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

namespace TencentCloud.Dbbrain.V20210527
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Dbbrain.V20210527.Models;

   public class DbbrainClient : AbstractClient{

       private const string endpoint = "dbbrain.tencentcloudapi.com";
       private const string version = "2021-05-27";
       private const string sdkVersion = "SDK_NET_3.0.1240";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DbbrainClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public DbbrainClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 添加邮件接收联系人的姓名， 邮件地址，返回值为添加成功的联系人id。
        /// </summary>
        /// <param name="req"><see cref="AddUserContactRequest"/></param>
        /// <returns><see cref="AddUserContactResponse"/></returns>
        public Task<AddUserContactResponse> AddUserContact(AddUserContactRequest req)
        {
            return InternalRequestAsync<AddUserContactResponse>(req, "AddUserContact");
        }

        /// <summary>
        /// 添加邮件接收联系人的姓名， 邮件地址，返回值为添加成功的联系人id。
        /// </summary>
        /// <param name="req"><see cref="AddUserContactRequest"/></param>
        /// <returns><see cref="AddUserContactResponse"/></returns>
        public AddUserContactResponse AddUserContactSync(AddUserContactRequest req)
        {
            return InternalRequestAsync<AddUserContactResponse>(req, "AddUserContact")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 自治中心-终止自治任务（单次）
        /// </summary>
        /// <param name="req"><see cref="CancelDBAutonomyActionRequest"/></param>
        /// <returns><see cref="CancelDBAutonomyActionResponse"/></returns>
        public Task<CancelDBAutonomyActionResponse> CancelDBAutonomyAction(CancelDBAutonomyActionRequest req)
        {
            return InternalRequestAsync<CancelDBAutonomyActionResponse>(req, "CancelDBAutonomyAction");
        }

        /// <summary>
        /// 自治中心-终止自治任务（单次）
        /// </summary>
        /// <param name="req"><see cref="CancelDBAutonomyActionRequest"/></param>
        /// <returns><see cref="CancelDBAutonomyActionResponse"/></returns>
        public CancelDBAutonomyActionResponse CancelDBAutonomyActionSync(CancelDBAutonomyActionRequest req)
        {
            return InternalRequestAsync<CancelDBAutonomyActionResponse>(req, "CancelDBAutonomyAction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 自治中心-终止自治事件
        /// </summary>
        /// <param name="req"><see cref="CancelDBAutonomyEventRequest"/></param>
        /// <returns><see cref="CancelDBAutonomyEventResponse"/></returns>
        public Task<CancelDBAutonomyEventResponse> CancelDBAutonomyEvent(CancelDBAutonomyEventRequest req)
        {
            return InternalRequestAsync<CancelDBAutonomyEventResponse>(req, "CancelDBAutonomyEvent");
        }

        /// <summary>
        /// 自治中心-终止自治事件
        /// </summary>
        /// <param name="req"><see cref="CancelDBAutonomyEventRequest"/></param>
        /// <returns><see cref="CancelDBAutonomyEventResponse"/></returns>
        public CancelDBAutonomyEventResponse CancelDBAutonomyEventSync(CancelDBAutonomyEventRequest req)
        {
            return InternalRequestAsync<CancelDBAutonomyEventResponse>(req, "CancelDBAutonomyEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 终止中断会话任务。
        /// </summary>
        /// <param name="req"><see cref="CancelKillTaskRequest"/></param>
        /// <returns><see cref="CancelKillTaskResponse"/></returns>
        public Task<CancelKillTaskResponse> CancelKillTask(CancelKillTaskRequest req)
        {
            return InternalRequestAsync<CancelKillTaskResponse>(req, "CancelKillTask");
        }

        /// <summary>
        /// 终止中断会话任务。
        /// </summary>
        /// <param name="req"><see cref="CancelKillTaskRequest"/></param>
        /// <returns><see cref="CancelKillTaskResponse"/></returns>
        public CancelKillTaskResponse CancelKillTaskSync(CancelKillTaskRequest req)
        {
            return InternalRequestAsync<CancelKillTaskResponse>(req, "CancelKillTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 自治中心-终止自治任务（单次）
        /// </summary>
        /// <param name="req"><see cref="CancelRedisBigKeyAnalysisTasksRequest"/></param>
        /// <returns><see cref="CancelRedisBigKeyAnalysisTasksResponse"/></returns>
        public Task<CancelRedisBigKeyAnalysisTasksResponse> CancelRedisBigKeyAnalysisTasks(CancelRedisBigKeyAnalysisTasksRequest req)
        {
            return InternalRequestAsync<CancelRedisBigKeyAnalysisTasksResponse>(req, "CancelRedisBigKeyAnalysisTasks");
        }

        /// <summary>
        /// 自治中心-终止自治任务（单次）
        /// </summary>
        /// <param name="req"><see cref="CancelRedisBigKeyAnalysisTasksRequest"/></param>
        /// <returns><see cref="CancelRedisBigKeyAnalysisTasksResponse"/></returns>
        public CancelRedisBigKeyAnalysisTasksResponse CancelRedisBigKeyAnalysisTasksSync(CancelRedisBigKeyAnalysisTasksRequest req)
        {
            return InternalRequestAsync<CancelRedisBigKeyAnalysisTasksResponse>(req, "CancelRedisBigKeyAnalysisTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 不用审计日志时，关闭数据库审计
        /// </summary>
        /// <param name="req"><see cref="CloseAuditServiceRequest"/></param>
        /// <returns><see cref="CloseAuditServiceResponse"/></returns>
        public Task<CloseAuditServiceResponse> CloseAuditService(CloseAuditServiceRequest req)
        {
            return InternalRequestAsync<CloseAuditServiceResponse>(req, "CloseAuditService");
        }

        /// <summary>
        /// 不用审计日志时，关闭数据库审计
        /// </summary>
        /// <param name="req"><see cref="CloseAuditServiceRequest"/></param>
        /// <returns><see cref="CloseAuditServiceResponse"/></returns>
        public CloseAuditServiceResponse CloseAuditServiceSync(CloseAuditServiceRequest req)
        {
            return InternalRequestAsync<CloseAuditServiceResponse>(req, "CloseAuditService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于创建云数据库实例的审计日志文件，最多下载600w审计日志。
        /// </summary>
        /// <param name="req"><see cref="CreateAuditLogFileRequest"/></param>
        /// <returns><see cref="CreateAuditLogFileResponse"/></returns>
        public Task<CreateAuditLogFileResponse> CreateAuditLogFile(CreateAuditLogFileRequest req)
        {
            return InternalRequestAsync<CreateAuditLogFileResponse>(req, "CreateAuditLogFile");
        }

        /// <summary>
        /// 用于创建云数据库实例的审计日志文件，最多下载600w审计日志。
        /// </summary>
        /// <param name="req"><see cref="CreateAuditLogFileRequest"/></param>
        /// <returns><see cref="CreateAuditLogFileResponse"/></returns>
        public CreateAuditLogFileResponse CreateAuditLogFileSync(CreateAuditLogFileRequest req)
        {
            return InternalRequestAsync<CreateAuditLogFileResponse>(req, "CreateAuditLogFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建健康报告，并可以选择是否发送邮件。
        /// </summary>
        /// <param name="req"><see cref="CreateDBDiagReportTaskRequest"/></param>
        /// <returns><see cref="CreateDBDiagReportTaskResponse"/></returns>
        public Task<CreateDBDiagReportTaskResponse> CreateDBDiagReportTask(CreateDBDiagReportTaskRequest req)
        {
            return InternalRequestAsync<CreateDBDiagReportTaskResponse>(req, "CreateDBDiagReportTask");
        }

        /// <summary>
        /// 创建健康报告，并可以选择是否发送邮件。
        /// </summary>
        /// <param name="req"><see cref="CreateDBDiagReportTaskRequest"/></param>
        /// <returns><see cref="CreateDBDiagReportTaskResponse"/></returns>
        public CreateDBDiagReportTaskResponse CreateDBDiagReportTaskSync(CreateDBDiagReportTaskRequest req)
        {
            return InternalRequestAsync<CreateDBDiagReportTaskResponse>(req, "CreateDBDiagReportTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建健康报告的浏览地址。
        /// </summary>
        /// <param name="req"><see cref="CreateDBDiagReportUrlRequest"/></param>
        /// <returns><see cref="CreateDBDiagReportUrlResponse"/></returns>
        public Task<CreateDBDiagReportUrlResponse> CreateDBDiagReportUrl(CreateDBDiagReportUrlRequest req)
        {
            return InternalRequestAsync<CreateDBDiagReportUrlResponse>(req, "CreateDBDiagReportUrl");
        }

        /// <summary>
        /// 创建健康报告的浏览地址。
        /// </summary>
        /// <param name="req"><see cref="CreateDBDiagReportUrlRequest"/></param>
        /// <returns><see cref="CreateDBDiagReportUrlResponse"/></returns>
        public CreateDBDiagReportUrlResponse CreateDBDiagReportUrlSync(CreateDBDiagReportUrlRequest req)
        {
            return InternalRequestAsync<CreateDBDiagReportUrlResponse>(req, "CreateDBDiagReportUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建中断会话的任务。
        /// </summary>
        /// <param name="req"><see cref="CreateKillTaskRequest"/></param>
        /// <returns><see cref="CreateKillTaskResponse"/></returns>
        public Task<CreateKillTaskResponse> CreateKillTask(CreateKillTaskRequest req)
        {
            return InternalRequestAsync<CreateKillTaskResponse>(req, "CreateKillTask");
        }

        /// <summary>
        /// 创建中断会话的任务。
        /// </summary>
        /// <param name="req"><see cref="CreateKillTaskRequest"/></param>
        /// <returns><see cref="CreateKillTaskResponse"/></returns>
        public CreateKillTaskResponse CreateKillTaskSync(CreateKillTaskRequest req)
        {
            return InternalRequestAsync<CreateKillTaskResponse>(req, "CreateKillTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建邮件配置。其中入参ProfileType表示所创建配置的类型，ProfileType 取值包括：dbScan_mail_configuration（数据库巡检邮件配置）、scheduler_mail_configuration（定期生成健康报告的邮件发送配置）。Region统一选择广州，和实例所属地域无关。
        /// </summary>
        /// <param name="req"><see cref="CreateMailProfileRequest"/></param>
        /// <returns><see cref="CreateMailProfileResponse"/></returns>
        public Task<CreateMailProfileResponse> CreateMailProfile(CreateMailProfileRequest req)
        {
            return InternalRequestAsync<CreateMailProfileResponse>(req, "CreateMailProfile");
        }

        /// <summary>
        /// 创建邮件配置。其中入参ProfileType表示所创建配置的类型，ProfileType 取值包括：dbScan_mail_configuration（数据库巡检邮件配置）、scheduler_mail_configuration（定期生成健康报告的邮件发送配置）。Region统一选择广州，和实例所属地域无关。
        /// </summary>
        /// <param name="req"><see cref="CreateMailProfileRequest"/></param>
        /// <returns><see cref="CreateMailProfileResponse"/></returns>
        public CreateMailProfileResponse CreateMailProfileSync(CreateMailProfileRequest req)
        {
            return InternalRequestAsync<CreateMailProfileResponse>(req, "CreateMailProfile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建中止所有代理节点连接会话的异步任务。当前仅支持 Redis。得到的返回值为异步任务 id，可以作为参数传入接口 DescribeProxySessionKillTasks 查询kill会话任务执行状态。
        /// </summary>
        /// <param name="req"><see cref="CreateProxySessionKillTaskRequest"/></param>
        /// <returns><see cref="CreateProxySessionKillTaskResponse"/></returns>
        public Task<CreateProxySessionKillTaskResponse> CreateProxySessionKillTask(CreateProxySessionKillTaskRequest req)
        {
            return InternalRequestAsync<CreateProxySessionKillTaskResponse>(req, "CreateProxySessionKillTask");
        }

        /// <summary>
        /// 创建中止所有代理节点连接会话的异步任务。当前仅支持 Redis。得到的返回值为异步任务 id，可以作为参数传入接口 DescribeProxySessionKillTasks 查询kill会话任务执行状态。
        /// </summary>
        /// <param name="req"><see cref="CreateProxySessionKillTaskRequest"/></param>
        /// <returns><see cref="CreateProxySessionKillTaskResponse"/></returns>
        public CreateProxySessionKillTaskResponse CreateProxySessionKillTaskSync(CreateProxySessionKillTaskRequest req)
        {
            return InternalRequestAsync<CreateProxySessionKillTaskResponse>(req, "CreateProxySessionKillTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 即时创建redis实例大key分析任务，限制正在运行的即时分析任务数量默认为5。
        /// </summary>
        /// <param name="req"><see cref="CreateRedisBigKeyAnalysisTaskRequest"/></param>
        /// <returns><see cref="CreateRedisBigKeyAnalysisTaskResponse"/></returns>
        public Task<CreateRedisBigKeyAnalysisTaskResponse> CreateRedisBigKeyAnalysisTask(CreateRedisBigKeyAnalysisTaskRequest req)
        {
            return InternalRequestAsync<CreateRedisBigKeyAnalysisTaskResponse>(req, "CreateRedisBigKeyAnalysisTask");
        }

        /// <summary>
        /// 即时创建redis实例大key分析任务，限制正在运行的即时分析任务数量默认为5。
        /// </summary>
        /// <param name="req"><see cref="CreateRedisBigKeyAnalysisTaskRequest"/></param>
        /// <returns><see cref="CreateRedisBigKeyAnalysisTaskResponse"/></returns>
        public CreateRedisBigKeyAnalysisTaskResponse CreateRedisBigKeyAnalysisTaskSync(CreateRedisBigKeyAnalysisTaskRequest req)
        {
            return InternalRequestAsync<CreateRedisBigKeyAnalysisTaskResponse>(req, "CreateRedisBigKeyAnalysisTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口用于创建定期生成健康报告并邮件发送的配置，将健康报告的定期生成时间作为参数传入（周一至周日），用于设置健康报告的定期生成时间，同时保存相应的定期邮件发送的配置。
        /// </summary>
        /// <param name="req"><see cref="CreateSchedulerMailProfileRequest"/></param>
        /// <returns><see cref="CreateSchedulerMailProfileResponse"/></returns>
        public Task<CreateSchedulerMailProfileResponse> CreateSchedulerMailProfile(CreateSchedulerMailProfileRequest req)
        {
            return InternalRequestAsync<CreateSchedulerMailProfileResponse>(req, "CreateSchedulerMailProfile");
        }

        /// <summary>
        /// 该接口用于创建定期生成健康报告并邮件发送的配置，将健康报告的定期生成时间作为参数传入（周一至周日），用于设置健康报告的定期生成时间，同时保存相应的定期邮件发送的配置。
        /// </summary>
        /// <param name="req"><see cref="CreateSchedulerMailProfileRequest"/></param>
        /// <returns><see cref="CreateSchedulerMailProfileResponse"/></returns>
        public CreateSchedulerMailProfileResponse CreateSchedulerMailProfileSync(CreateSchedulerMailProfileRequest req)
        {
            return InternalRequestAsync<CreateSchedulerMailProfileResponse>(req, "CreateSchedulerMailProfile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建安全审计日志导出任务。
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityAuditLogExportTaskRequest"/></param>
        /// <returns><see cref="CreateSecurityAuditLogExportTaskResponse"/></returns>
        public Task<CreateSecurityAuditLogExportTaskResponse> CreateSecurityAuditLogExportTask(CreateSecurityAuditLogExportTaskRequest req)
        {
            return InternalRequestAsync<CreateSecurityAuditLogExportTaskResponse>(req, "CreateSecurityAuditLogExportTask");
        }

        /// <summary>
        /// 创建安全审计日志导出任务。
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityAuditLogExportTaskRequest"/></param>
        /// <returns><see cref="CreateSecurityAuditLogExportTaskResponse"/></returns>
        public CreateSecurityAuditLogExportTaskResponse CreateSecurityAuditLogExportTaskSync(CreateSecurityAuditLogExportTaskRequest req)
        {
            return InternalRequestAsync<CreateSecurityAuditLogExportTaskResponse>(req, "CreateSecurityAuditLogExportTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建实例SQL限流任务。
        /// </summary>
        /// <param name="req"><see cref="CreateSqlFilterRequest"/></param>
        /// <returns><see cref="CreateSqlFilterResponse"/></returns>
        public Task<CreateSqlFilterResponse> CreateSqlFilter(CreateSqlFilterRequest req)
        {
            return InternalRequestAsync<CreateSqlFilterResponse>(req, "CreateSqlFilter");
        }

        /// <summary>
        /// 创建实例SQL限流任务。
        /// </summary>
        /// <param name="req"><see cref="CreateSqlFilterRequest"/></param>
        /// <returns><see cref="CreateSqlFilterResponse"/></returns>
        public CreateSqlFilterResponse CreateSqlFilterSync(CreateSqlFilterRequest req)
        {
            return InternalRequestAsync<CreateSqlFilterResponse>(req, "CreateSqlFilter")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 自治中心-终止自治任务（单次）；注意：接口需要加白名单。
        /// </summary>
        /// <param name="req"><see cref="CreateUserAutonomyProfileRequest"/></param>
        /// <returns><see cref="CreateUserAutonomyProfileResponse"/></returns>
        public Task<CreateUserAutonomyProfileResponse> CreateUserAutonomyProfile(CreateUserAutonomyProfileRequest req)
        {
            return InternalRequestAsync<CreateUserAutonomyProfileResponse>(req, "CreateUserAutonomyProfile");
        }

        /// <summary>
        /// 自治中心-终止自治任务（单次）；注意：接口需要加白名单。
        /// </summary>
        /// <param name="req"><see cref="CreateUserAutonomyProfileRequest"/></param>
        /// <returns><see cref="CreateUserAutonomyProfileResponse"/></returns>
        public CreateUserAutonomyProfileResponse CreateUserAutonomyProfileSync(CreateUserAutonomyProfileRequest req)
        {
            return InternalRequestAsync<CreateUserAutonomyProfileResponse>(req, "CreateUserAutonomyProfile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于删除云数据库实例的审计日志文件。
        /// </summary>
        /// <param name="req"><see cref="DeleteAuditLogFileRequest"/></param>
        /// <returns><see cref="DeleteAuditLogFileResponse"/></returns>
        public Task<DeleteAuditLogFileResponse> DeleteAuditLogFile(DeleteAuditLogFileRequest req)
        {
            return InternalRequestAsync<DeleteAuditLogFileResponse>(req, "DeleteAuditLogFile");
        }

        /// <summary>
        /// 用于删除云数据库实例的审计日志文件。
        /// </summary>
        /// <param name="req"><see cref="DeleteAuditLogFileRequest"/></param>
        /// <returns><see cref="DeleteAuditLogFileResponse"/></returns>
        public DeleteAuditLogFileResponse DeleteAuditLogFileSync(DeleteAuditLogFileRequest req)
        {
            return InternalRequestAsync<DeleteAuditLogFileResponse>(req, "DeleteAuditLogFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据任务id删除健康报告生成任务
        /// </summary>
        /// <param name="req"><see cref="DeleteDBDiagReportTasksRequest"/></param>
        /// <returns><see cref="DeleteDBDiagReportTasksResponse"/></returns>
        public Task<DeleteDBDiagReportTasksResponse> DeleteDBDiagReportTasks(DeleteDBDiagReportTasksRequest req)
        {
            return InternalRequestAsync<DeleteDBDiagReportTasksResponse>(req, "DeleteDBDiagReportTasks");
        }

        /// <summary>
        /// 根据任务id删除健康报告生成任务
        /// </summary>
        /// <param name="req"><see cref="DeleteDBDiagReportTasksRequest"/></param>
        /// <returns><see cref="DeleteDBDiagReportTasksResponse"/></returns>
        public DeleteDBDiagReportTasksResponse DeleteDBDiagReportTasksSync(DeleteDBDiagReportTasksRequest req)
        {
            return InternalRequestAsync<DeleteDBDiagReportTasksResponse>(req, "DeleteDBDiagReportTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除Redis实例的大key分析任务。
        /// </summary>
        /// <param name="req"><see cref="DeleteRedisBigKeyAnalysisTasksRequest"/></param>
        /// <returns><see cref="DeleteRedisBigKeyAnalysisTasksResponse"/></returns>
        public Task<DeleteRedisBigKeyAnalysisTasksResponse> DeleteRedisBigKeyAnalysisTasks(DeleteRedisBigKeyAnalysisTasksRequest req)
        {
            return InternalRequestAsync<DeleteRedisBigKeyAnalysisTasksResponse>(req, "DeleteRedisBigKeyAnalysisTasks");
        }

        /// <summary>
        /// 删除Redis实例的大key分析任务。
        /// </summary>
        /// <param name="req"><see cref="DeleteRedisBigKeyAnalysisTasksRequest"/></param>
        /// <returns><see cref="DeleteRedisBigKeyAnalysisTasksResponse"/></returns>
        public DeleteRedisBigKeyAnalysisTasksResponse DeleteRedisBigKeyAnalysisTasksSync(DeleteRedisBigKeyAnalysisTasksRequest req)
        {
            return InternalRequestAsync<DeleteRedisBigKeyAnalysisTasksResponse>(req, "DeleteRedisBigKeyAnalysisTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除安全审计日志导出任务。
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityAuditLogExportTasksRequest"/></param>
        /// <returns><see cref="DeleteSecurityAuditLogExportTasksResponse"/></returns>
        public Task<DeleteSecurityAuditLogExportTasksResponse> DeleteSecurityAuditLogExportTasks(DeleteSecurityAuditLogExportTasksRequest req)
        {
            return InternalRequestAsync<DeleteSecurityAuditLogExportTasksResponse>(req, "DeleteSecurityAuditLogExportTasks");
        }

        /// <summary>
        /// 删除安全审计日志导出任务。
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityAuditLogExportTasksRequest"/></param>
        /// <returns><see cref="DeleteSecurityAuditLogExportTasksResponse"/></returns>
        public DeleteSecurityAuditLogExportTasksResponse DeleteSecurityAuditLogExportTasksSync(DeleteSecurityAuditLogExportTasksRequest req)
        {
            return InternalRequestAsync<DeleteSecurityAuditLogExportTasksResponse>(req, "DeleteSecurityAuditLogExportTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除实例SQL限流任务。
        /// </summary>
        /// <param name="req"><see cref="DeleteSqlFiltersRequest"/></param>
        /// <returns><see cref="DeleteSqlFiltersResponse"/></returns>
        public Task<DeleteSqlFiltersResponse> DeleteSqlFilters(DeleteSqlFiltersRequest req)
        {
            return InternalRequestAsync<DeleteSqlFiltersResponse>(req, "DeleteSqlFilters");
        }

        /// <summary>
        /// 删除实例SQL限流任务。
        /// </summary>
        /// <param name="req"><see cref="DeleteSqlFiltersRequest"/></param>
        /// <returns><see cref="DeleteSqlFiltersResponse"/></returns>
        public DeleteSqlFiltersResponse DeleteSqlFiltersSync(DeleteSqlFiltersRequest req)
        {
            return InternalRequestAsync<DeleteSqlFiltersResponse>(req, "DeleteSqlFilters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通知模板查询
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmTemplateRequest"/></param>
        /// <returns><see cref="DescribeAlarmTemplateResponse"/></returns>
        public Task<DescribeAlarmTemplateResponse> DescribeAlarmTemplate(DescribeAlarmTemplateRequest req)
        {
            return InternalRequestAsync<DescribeAlarmTemplateResponse>(req, "DescribeAlarmTemplate");
        }

        /// <summary>
        /// 通知模板查询
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmTemplateRequest"/></param>
        /// <returns><see cref="DescribeAlarmTemplateResponse"/></returns>
        public DescribeAlarmTemplateResponse DescribeAlarmTemplateSync(DescribeAlarmTemplateRequest req)
        {
            return InternalRequestAsync<DescribeAlarmTemplateResponse>(req, "DescribeAlarmTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取邮件发送中联系人的相关信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeAllUserContactRequest"/></param>
        /// <returns><see cref="DescribeAllUserContactResponse"/></returns>
        public Task<DescribeAllUserContactResponse> DescribeAllUserContact(DescribeAllUserContactRequest req)
        {
            return InternalRequestAsync<DescribeAllUserContactResponse>(req, "DescribeAllUserContact");
        }

        /// <summary>
        /// 获取邮件发送中联系人的相关信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeAllUserContactRequest"/></param>
        /// <returns><see cref="DescribeAllUserContactResponse"/></returns>
        public DescribeAllUserContactResponse DescribeAllUserContactSync(DescribeAllUserContactRequest req)
        {
            return InternalRequestAsync<DescribeAllUserContactResponse>(req, "DescribeAllUserContact")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取邮件发送联系组的相关信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeAllUserGroupRequest"/></param>
        /// <returns><see cref="DescribeAllUserGroupResponse"/></returns>
        public Task<DescribeAllUserGroupResponse> DescribeAllUserGroup(DescribeAllUserGroupRequest req)
        {
            return InternalRequestAsync<DescribeAllUserGroupResponse>(req, "DescribeAllUserGroup");
        }

        /// <summary>
        /// 获取邮件发送联系组的相关信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeAllUserGroupRequest"/></param>
        /// <returns><see cref="DescribeAllUserGroupResponse"/></returns>
        public DescribeAllUserGroupResponse DescribeAllUserGroupSync(DescribeAllUserGroupRequest req)
        {
            return InternalRequestAsync<DescribeAllUserGroupResponse>(req, "DescribeAllUserGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditInstanceListRequest"/></param>
        /// <returns><see cref="DescribeAuditInstanceListResponse"/></returns>
        public Task<DescribeAuditInstanceListResponse> DescribeAuditInstanceList(DescribeAuditInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeAuditInstanceListResponse>(req, "DescribeAuditInstanceList");
        }

        /// <summary>
        /// 查询实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditInstanceListRequest"/></param>
        /// <returns><see cref="DescribeAuditInstanceListResponse"/></returns>
        public DescribeAuditInstanceListResponse DescribeAuditInstanceListSync(DescribeAuditInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeAuditInstanceListResponse>(req, "DescribeAuditInstanceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于创建云数据库实例的审计日志文件
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditLogFilesRequest"/></param>
        /// <returns><see cref="DescribeAuditLogFilesResponse"/></returns>
        public Task<DescribeAuditLogFilesResponse> DescribeAuditLogFiles(DescribeAuditLogFilesRequest req)
        {
            return InternalRequestAsync<DescribeAuditLogFilesResponse>(req, "DescribeAuditLogFiles");
        }

        /// <summary>
        /// 用于创建云数据库实例的审计日志文件
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditLogFilesRequest"/></param>
        /// <returns><see cref="DescribeAuditLogFilesResponse"/></returns>
        public DescribeAuditLogFilesResponse DescribeAuditLogFilesSync(DescribeAuditLogFilesRequest req)
        {
            return InternalRequestAsync<DescribeAuditLogFilesResponse>(req, "DescribeAuditLogFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 自治中心-查询自治事件任务详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBAutonomyActionRequest"/></param>
        /// <returns><see cref="DescribeDBAutonomyActionResponse"/></returns>
        public Task<DescribeDBAutonomyActionResponse> DescribeDBAutonomyAction(DescribeDBAutonomyActionRequest req)
        {
            return InternalRequestAsync<DescribeDBAutonomyActionResponse>(req, "DescribeDBAutonomyAction");
        }

        /// <summary>
        /// 自治中心-查询自治事件任务详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBAutonomyActionRequest"/></param>
        /// <returns><see cref="DescribeDBAutonomyActionResponse"/></returns>
        public DescribeDBAutonomyActionResponse DescribeDBAutonomyActionSync(DescribeDBAutonomyActionRequest req)
        {
            return InternalRequestAsync<DescribeDBAutonomyActionResponse>(req, "DescribeDBAutonomyAction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 自治中心-终止自治任务（单次）
        /// </summary>
        /// <param name="req"><see cref="DescribeDBAutonomyActionsRequest"/></param>
        /// <returns><see cref="DescribeDBAutonomyActionsResponse"/></returns>
        public Task<DescribeDBAutonomyActionsResponse> DescribeDBAutonomyActions(DescribeDBAutonomyActionsRequest req)
        {
            return InternalRequestAsync<DescribeDBAutonomyActionsResponse>(req, "DescribeDBAutonomyActions");
        }

        /// <summary>
        /// 自治中心-终止自治任务（单次）
        /// </summary>
        /// <param name="req"><see cref="DescribeDBAutonomyActionsRequest"/></param>
        /// <returns><see cref="DescribeDBAutonomyActionsResponse"/></returns>
        public DescribeDBAutonomyActionsResponse DescribeDBAutonomyActionsSync(DescribeDBAutonomyActionsRequest req)
        {
            return InternalRequestAsync<DescribeDBAutonomyActionsResponse>(req, "DescribeDBAutonomyActions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 自治中心-终止自治任务（单次）
        /// </summary>
        /// <param name="req"><see cref="DescribeDBAutonomyEventsRequest"/></param>
        /// <returns><see cref="DescribeDBAutonomyEventsResponse"/></returns>
        public Task<DescribeDBAutonomyEventsResponse> DescribeDBAutonomyEvents(DescribeDBAutonomyEventsRequest req)
        {
            return InternalRequestAsync<DescribeDBAutonomyEventsResponse>(req, "DescribeDBAutonomyEvents");
        }

        /// <summary>
        /// 自治中心-终止自治任务（单次）
        /// </summary>
        /// <param name="req"><see cref="DescribeDBAutonomyEventsRequest"/></param>
        /// <returns><see cref="DescribeDBAutonomyEventsResponse"/></returns>
        public DescribeDBAutonomyEventsResponse DescribeDBAutonomyEventsSync(DescribeDBAutonomyEventsRequest req)
        {
            return InternalRequestAsync<DescribeDBAutonomyEventsResponse>(req, "DescribeDBAutonomyEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取实例异常诊断事件的详情信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBDiagEventRequest"/></param>
        /// <returns><see cref="DescribeDBDiagEventResponse"/></returns>
        public Task<DescribeDBDiagEventResponse> DescribeDBDiagEvent(DescribeDBDiagEventRequest req)
        {
            return InternalRequestAsync<DescribeDBDiagEventResponse>(req, "DescribeDBDiagEvent");
        }

        /// <summary>
        /// 获取实例异常诊断事件的详情信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBDiagEventRequest"/></param>
        /// <returns><see cref="DescribeDBDiagEventResponse"/></returns>
        public DescribeDBDiagEventResponse DescribeDBDiagEventSync(DescribeDBDiagEventRequest req)
        {
            return InternalRequestAsync<DescribeDBDiagEventResponse>(req, "DescribeDBDiagEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取指定时间段内的诊断事件列表，支持依据风险等级、实例ID等条件过滤。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBDiagEventsRequest"/></param>
        /// <returns><see cref="DescribeDBDiagEventsResponse"/></returns>
        public Task<DescribeDBDiagEventsResponse> DescribeDBDiagEvents(DescribeDBDiagEventsRequest req)
        {
            return InternalRequestAsync<DescribeDBDiagEventsResponse>(req, "DescribeDBDiagEvents");
        }

        /// <summary>
        /// 获取指定时间段内的诊断事件列表，支持依据风险等级、实例ID等条件过滤。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBDiagEventsRequest"/></param>
        /// <returns><see cref="DescribeDBDiagEventsResponse"/></returns>
        public DescribeDBDiagEventsResponse DescribeDBDiagEventsSync(DescribeDBDiagEventsRequest req)
        {
            return InternalRequestAsync<DescribeDBDiagEventsResponse>(req, "DescribeDBDiagEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取实例诊断事件的列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBDiagHistoryRequest"/></param>
        /// <returns><see cref="DescribeDBDiagHistoryResponse"/></returns>
        public Task<DescribeDBDiagHistoryResponse> DescribeDBDiagHistory(DescribeDBDiagHistoryRequest req)
        {
            return InternalRequestAsync<DescribeDBDiagHistoryResponse>(req, "DescribeDBDiagHistory");
        }

        /// <summary>
        /// 获取实例诊断事件的列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBDiagHistoryRequest"/></param>
        /// <returns><see cref="DescribeDBDiagHistoryResponse"/></returns>
        public DescribeDBDiagHistoryResponse DescribeDBDiagHistorySync(DescribeDBDiagHistoryRequest req)
        {
            return InternalRequestAsync<DescribeDBDiagHistoryResponse>(req, "DescribeDBDiagHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 健康报告内容。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBDiagReportContentRequest"/></param>
        /// <returns><see cref="DescribeDBDiagReportContentResponse"/></returns>
        public Task<DescribeDBDiagReportContentResponse> DescribeDBDiagReportContent(DescribeDBDiagReportContentRequest req)
        {
            return InternalRequestAsync<DescribeDBDiagReportContentResponse>(req, "DescribeDBDiagReportContent");
        }

        /// <summary>
        /// 健康报告内容。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBDiagReportContentRequest"/></param>
        /// <returns><see cref="DescribeDBDiagReportContentResponse"/></returns>
        public DescribeDBDiagReportContentResponse DescribeDBDiagReportContentSync(DescribeDBDiagReportContentRequest req)
        {
            return InternalRequestAsync<DescribeDBDiagReportContentResponse>(req, "DescribeDBDiagReportContent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询健康报告生成任务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBDiagReportTasksRequest"/></param>
        /// <returns><see cref="DescribeDBDiagReportTasksResponse"/></returns>
        public Task<DescribeDBDiagReportTasksResponse> DescribeDBDiagReportTasks(DescribeDBDiagReportTasksRequest req)
        {
            return InternalRequestAsync<DescribeDBDiagReportTasksResponse>(req, "DescribeDBDiagReportTasks");
        }

        /// <summary>
        /// 查询健康报告生成任务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBDiagReportTasksRequest"/></param>
        /// <returns><see cref="DescribeDBDiagReportTasksResponse"/></returns>
        public DescribeDBDiagReportTasksResponse DescribeDBDiagReportTasksSync(DescribeDBDiagReportTasksRequest req)
        {
            return InternalRequestAsync<DescribeDBDiagReportTasksResponse>(req, "DescribeDBDiagReportTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据实例ID获取指定时间段的性能趋势。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBPerfTimeSeriesRequest"/></param>
        /// <returns><see cref="DescribeDBPerfTimeSeriesResponse"/></returns>
        public Task<DescribeDBPerfTimeSeriesResponse> DescribeDBPerfTimeSeries(DescribeDBPerfTimeSeriesRequest req)
        {
            return InternalRequestAsync<DescribeDBPerfTimeSeriesResponse>(req, "DescribeDBPerfTimeSeries");
        }

        /// <summary>
        /// 根据实例ID获取指定时间段的性能趋势。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBPerfTimeSeriesRequest"/></param>
        /// <returns><see cref="DescribeDBPerfTimeSeriesResponse"/></returns>
        public DescribeDBPerfTimeSeriesResponse DescribeDBPerfTimeSeriesSync(DescribeDBPerfTimeSeriesRequest req)
        {
            return InternalRequestAsync<DescribeDBPerfTimeSeriesResponse>(req, "DescribeDBPerfTimeSeries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取指定时间段内的实例空间使用概览，包括磁盘增长量(MB)、磁盘剩余(MB)、磁盘总量(MB)及预计可用天数。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSpaceStatusRequest"/></param>
        /// <returns><see cref="DescribeDBSpaceStatusResponse"/></returns>
        public Task<DescribeDBSpaceStatusResponse> DescribeDBSpaceStatus(DescribeDBSpaceStatusRequest req)
        {
            return InternalRequestAsync<DescribeDBSpaceStatusResponse>(req, "DescribeDBSpaceStatus");
        }

        /// <summary>
        /// 获取指定时间段内的实例空间使用概览，包括磁盘增长量(MB)、磁盘剩余(MB)、磁盘总量(MB)及预计可用天数。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSpaceStatusRequest"/></param>
        /// <returns><see cref="DescribeDBSpaceStatusResponse"/></returns>
        public DescribeDBSpaceStatusResponse DescribeDBSpaceStatusSync(DescribeDBSpaceStatusRequest req)
        {
            return InternalRequestAsync<DescribeDBSpaceStatusResponse>(req, "DescribeDBSpaceStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取实例信息列表。Region统一选择广州。
        /// </summary>
        /// <param name="req"><see cref="DescribeDiagDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDiagDBInstancesResponse"/></returns>
        public Task<DescribeDiagDBInstancesResponse> DescribeDiagDBInstances(DescribeDiagDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDiagDBInstancesResponse>(req, "DescribeDiagDBInstances");
        }

        /// <summary>
        /// 获取实例信息列表。Region统一选择广州。
        /// </summary>
        /// <param name="req"><see cref="DescribeDiagDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDiagDBInstancesResponse"/></returns>
        public DescribeDiagDBInstancesResponse DescribeDiagDBInstancesSync(DescribeDiagDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDiagDBInstancesResponse>(req, "DescribeDiagDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据实例ID获取指定时间段（30分钟）的健康得分，以及异常扣分项。
        /// </summary>
        /// <param name="req"><see cref="DescribeHealthScoreRequest"/></param>
        /// <returns><see cref="DescribeHealthScoreResponse"/></returns>
        public Task<DescribeHealthScoreResponse> DescribeHealthScore(DescribeHealthScoreRequest req)
        {
            return InternalRequestAsync<DescribeHealthScoreResponse>(req, "DescribeHealthScore");
        }

        /// <summary>
        /// 根据实例ID获取指定时间段（30分钟）的健康得分，以及异常扣分项。
        /// </summary>
        /// <param name="req"><see cref="DescribeHealthScoreRequest"/></param>
        /// <returns><see cref="DescribeHealthScoreResponse"/></returns>
        public DescribeHealthScoreResponse DescribeHealthScoreSync(DescribeHealthScoreRequest req)
        {
            return InternalRequestAsync<DescribeHealthScoreResponse>(req, "DescribeHealthScore")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询某张表的慢查模板概览
        /// </summary>
        /// <param name="req"><see cref="DescribeIndexRecommendAggregationSlowLogsRequest"/></param>
        /// <returns><see cref="DescribeIndexRecommendAggregationSlowLogsResponse"/></returns>
        public Task<DescribeIndexRecommendAggregationSlowLogsResponse> DescribeIndexRecommendAggregationSlowLogs(DescribeIndexRecommendAggregationSlowLogsRequest req)
        {
            return InternalRequestAsync<DescribeIndexRecommendAggregationSlowLogsResponse>(req, "DescribeIndexRecommendAggregationSlowLogs");
        }

        /// <summary>
        /// 查询某张表的慢查模板概览
        /// </summary>
        /// <param name="req"><see cref="DescribeIndexRecommendAggregationSlowLogsRequest"/></param>
        /// <returns><see cref="DescribeIndexRecommendAggregationSlowLogsResponse"/></returns>
        public DescribeIndexRecommendAggregationSlowLogsResponse DescribeIndexRecommendAggregationSlowLogsSync(DescribeIndexRecommendAggregationSlowLogsRequest req)
        {
            return InternalRequestAsync<DescribeIndexRecommendAggregationSlowLogsResponse>(req, "DescribeIndexRecommendAggregationSlowLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例的索引推荐信息，包括索引统计相关信息，推荐索引列表，无效索引列表等。
        /// </summary>
        /// <param name="req"><see cref="DescribeIndexRecommendInfoRequest"/></param>
        /// <returns><see cref="DescribeIndexRecommendInfoResponse"/></returns>
        public Task<DescribeIndexRecommendInfoResponse> DescribeIndexRecommendInfo(DescribeIndexRecommendInfoRequest req)
        {
            return InternalRequestAsync<DescribeIndexRecommendInfoResponse>(req, "DescribeIndexRecommendInfo");
        }

        /// <summary>
        /// 查询实例的索引推荐信息，包括索引统计相关信息，推荐索引列表，无效索引列表等。
        /// </summary>
        /// <param name="req"><see cref="DescribeIndexRecommendInfoRequest"/></param>
        /// <returns><see cref="DescribeIndexRecommendInfoResponse"/></returns>
        public DescribeIndexRecommendInfoResponse DescribeIndexRecommendInfoSync(DescribeIndexRecommendInfoRequest req)
        {
            return InternalRequestAsync<DescribeIndexRecommendInfoResponse>(req, "DescribeIndexRecommendInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取发送邮件的配置， 包括数据库巡检的邮件配置以及定期生成健康报告的邮件发送配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeMailProfileRequest"/></param>
        /// <returns><see cref="DescribeMailProfileResponse"/></returns>
        public Task<DescribeMailProfileResponse> DescribeMailProfile(DescribeMailProfileRequest req)
        {
            return InternalRequestAsync<DescribeMailProfileResponse>(req, "DescribeMailProfile");
        }

        /// <summary>
        /// 获取发送邮件的配置， 包括数据库巡检的邮件配置以及定期生成健康报告的邮件发送配置。
        /// </summary>
        /// <param name="req"><see cref="DescribeMailProfileRequest"/></param>
        /// <returns><see cref="DescribeMailProfileResponse"/></returns>
        public DescribeMailProfileResponse DescribeMailProfileSync(DescribeMailProfileRequest req)
        {
            return InternalRequestAsync<DescribeMailProfileResponse>(req, "DescribeMailProfile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询关系型数据库的实时线程列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeMySqlProcessListRequest"/></param>
        /// <returns><see cref="DescribeMySqlProcessListResponse"/></returns>
        public Task<DescribeMySqlProcessListResponse> DescribeMySqlProcessList(DescribeMySqlProcessListRequest req)
        {
            return InternalRequestAsync<DescribeMySqlProcessListResponse>(req, "DescribeMySqlProcessList");
        }

        /// <summary>
        /// 查询关系型数据库的实时线程列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeMySqlProcessListRequest"/></param>
        /// <returns><see cref="DescribeMySqlProcessListResponse"/></returns>
        public DescribeMySqlProcessListResponse DescribeMySqlProcessListSync(DescribeMySqlProcessListRequest req)
        {
            return InternalRequestAsync<DescribeMySqlProcessListResponse>(req, "DescribeMySqlProcessList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例无主键表。
        /// </summary>
        /// <param name="req"><see cref="DescribeNoPrimaryKeyTablesRequest"/></param>
        /// <returns><see cref="DescribeNoPrimaryKeyTablesResponse"/></returns>
        public Task<DescribeNoPrimaryKeyTablesResponse> DescribeNoPrimaryKeyTables(DescribeNoPrimaryKeyTablesRequest req)
        {
            return InternalRequestAsync<DescribeNoPrimaryKeyTablesResponse>(req, "DescribeNoPrimaryKeyTables");
        }

        /// <summary>
        /// 查询实例无主键表。
        /// </summary>
        /// <param name="req"><see cref="DescribeNoPrimaryKeyTablesRequest"/></param>
        /// <returns><see cref="DescribeNoPrimaryKeyTablesResponse"/></returns>
        public DescribeNoPrimaryKeyTablesResponse DescribeNoPrimaryKeyTablesSync(DescribeNoPrimaryKeyTablesRequest req)
        {
            return InternalRequestAsync<DescribeNoPrimaryKeyTablesResponse>(req, "DescribeNoPrimaryKeyTables")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取当前实例下的单个proxy的会话统计详情信息， 返回数据为单个 proxy 的会话统计信息。【注意】该接口仅限部分环境调用。
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyProcessStatisticsRequest"/></param>
        /// <returns><see cref="DescribeProxyProcessStatisticsResponse"/></returns>
        public Task<DescribeProxyProcessStatisticsResponse> DescribeProxyProcessStatistics(DescribeProxyProcessStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeProxyProcessStatisticsResponse>(req, "DescribeProxyProcessStatistics");
        }

        /// <summary>
        /// 获取当前实例下的单个proxy的会话统计详情信息， 返回数据为单个 proxy 的会话统计信息。【注意】该接口仅限部分环境调用。
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyProcessStatisticsRequest"/></param>
        /// <returns><see cref="DescribeProxyProcessStatisticsResponse"/></returns>
        public DescribeProxyProcessStatisticsResponse DescribeProxyProcessStatisticsSync(DescribeProxyProcessStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeProxyProcessStatisticsResponse>(req, "DescribeProxyProcessStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询 redis 执行 kill 会话任务后代理节点的执行结果，入参异步任务 ID 从接口 CreateProxySessionKillTask 调用成功后取得。当前 product 只支持：redis。
        /// </summary>
        /// <param name="req"><see cref="DescribeProxySessionKillTasksRequest"/></param>
        /// <returns><see cref="DescribeProxySessionKillTasksResponse"/></returns>
        public Task<DescribeProxySessionKillTasksResponse> DescribeProxySessionKillTasks(DescribeProxySessionKillTasksRequest req)
        {
            return InternalRequestAsync<DescribeProxySessionKillTasksResponse>(req, "DescribeProxySessionKillTasks");
        }

        /// <summary>
        /// 用于查询 redis 执行 kill 会话任务后代理节点的执行结果，入参异步任务 ID 从接口 CreateProxySessionKillTask 调用成功后取得。当前 product 只支持：redis。
        /// </summary>
        /// <param name="req"><see cref="DescribeProxySessionKillTasksRequest"/></param>
        /// <returns><see cref="DescribeProxySessionKillTasksResponse"/></returns>
        public DescribeProxySessionKillTasksResponse DescribeProxySessionKillTasksSync(DescribeProxySessionKillTasksRequest req)
        {
            return InternalRequestAsync<DescribeProxySessionKillTasksResponse>(req, "DescribeProxySessionKillTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询redis大key分析任务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeRedisBigKeyAnalysisTasksRequest"/></param>
        /// <returns><see cref="DescribeRedisBigKeyAnalysisTasksResponse"/></returns>
        public Task<DescribeRedisBigKeyAnalysisTasksResponse> DescribeRedisBigKeyAnalysisTasks(DescribeRedisBigKeyAnalysisTasksRequest req)
        {
            return InternalRequestAsync<DescribeRedisBigKeyAnalysisTasksResponse>(req, "DescribeRedisBigKeyAnalysisTasks");
        }

        /// <summary>
        /// 查询redis大key分析任务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeRedisBigKeyAnalysisTasksRequest"/></param>
        /// <returns><see cref="DescribeRedisBigKeyAnalysisTasksResponse"/></returns>
        public DescribeRedisBigKeyAnalysisTasksResponse DescribeRedisBigKeyAnalysisTasksSync(DescribeRedisBigKeyAnalysisTasksRequest req)
        {
            return InternalRequestAsync<DescribeRedisBigKeyAnalysisTasksResponse>(req, "DescribeRedisBigKeyAnalysisTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 延迟分析-命令字分析-查询命令延迟趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeRedisCmdPerfTimeSeriesRequest"/></param>
        /// <returns><see cref="DescribeRedisCmdPerfTimeSeriesResponse"/></returns>
        public Task<DescribeRedisCmdPerfTimeSeriesResponse> DescribeRedisCmdPerfTimeSeries(DescribeRedisCmdPerfTimeSeriesRequest req)
        {
            return InternalRequestAsync<DescribeRedisCmdPerfTimeSeriesResponse>(req, "DescribeRedisCmdPerfTimeSeries");
        }

        /// <summary>
        /// 延迟分析-命令字分析-查询命令延迟趋势
        /// </summary>
        /// <param name="req"><see cref="DescribeRedisCmdPerfTimeSeriesRequest"/></param>
        /// <returns><see cref="DescribeRedisCmdPerfTimeSeriesResponse"/></returns>
        public DescribeRedisCmdPerfTimeSeriesResponse DescribeRedisCmdPerfTimeSeriesSync(DescribeRedisCmdPerfTimeSeriesRequest req)
        {
            return InternalRequestAsync<DescribeRedisCmdPerfTimeSeriesResponse>(req, "DescribeRedisCmdPerfTimeSeries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 延迟分析-查询命令延迟分布
        /// </summary>
        /// <param name="req"><see cref="DescribeRedisCommandCostStatisticsRequest"/></param>
        /// <returns><see cref="DescribeRedisCommandCostStatisticsResponse"/></returns>
        public Task<DescribeRedisCommandCostStatisticsResponse> DescribeRedisCommandCostStatistics(DescribeRedisCommandCostStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeRedisCommandCostStatisticsResponse>(req, "DescribeRedisCommandCostStatistics");
        }

        /// <summary>
        /// 延迟分析-查询命令延迟分布
        /// </summary>
        /// <param name="req"><see cref="DescribeRedisCommandCostStatisticsRequest"/></param>
        /// <returns><see cref="DescribeRedisCommandCostStatisticsResponse"/></returns>
        public DescribeRedisCommandCostStatisticsResponse DescribeRedisCommandCostStatisticsSync(DescribeRedisCommandCostStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeRedisCommandCostStatisticsResponse>(req, "DescribeRedisCommandCostStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 延迟分析-查询实例访问命令统计
        /// </summary>
        /// <param name="req"><see cref="DescribeRedisCommandOverviewRequest"/></param>
        /// <returns><see cref="DescribeRedisCommandOverviewResponse"/></returns>
        public Task<DescribeRedisCommandOverviewResponse> DescribeRedisCommandOverview(DescribeRedisCommandOverviewRequest req)
        {
            return InternalRequestAsync<DescribeRedisCommandOverviewResponse>(req, "DescribeRedisCommandOverview");
        }

        /// <summary>
        /// 延迟分析-查询实例访问命令统计
        /// </summary>
        /// <param name="req"><see cref="DescribeRedisCommandOverviewRequest"/></param>
        /// <returns><see cref="DescribeRedisCommandOverviewResponse"/></returns>
        public DescribeRedisCommandOverviewResponse DescribeRedisCommandOverviewSync(DescribeRedisCommandOverviewRequest req)
        {
            return InternalRequestAsync<DescribeRedisCommandOverviewResponse>(req, "DescribeRedisCommandOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取 Redis 实例所有 proxy 节点的实时会话详情列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeRedisProcessListRequest"/></param>
        /// <returns><see cref="DescribeRedisProcessListResponse"/></returns>
        public Task<DescribeRedisProcessListResponse> DescribeRedisProcessList(DescribeRedisProcessListRequest req)
        {
            return InternalRequestAsync<DescribeRedisProcessListResponse>(req, "DescribeRedisProcessList");
        }

        /// <summary>
        /// 获取 Redis 实例所有 proxy 节点的实时会话详情列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeRedisProcessListRequest"/></param>
        /// <returns><see cref="DescribeRedisProcessListResponse"/></returns>
        public DescribeRedisProcessListResponse DescribeRedisProcessListSync(DescribeRedisProcessListRequest req)
        {
            return InternalRequestAsync<DescribeRedisProcessListResponse>(req, "DescribeRedisProcessList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 统计排序指定时间段内的top慢sql。
        /// </summary>
        /// <param name="req"><see cref="DescribeRedisSlowLogTopSqlsRequest"/></param>
        /// <returns><see cref="DescribeRedisSlowLogTopSqlsResponse"/></returns>
        public Task<DescribeRedisSlowLogTopSqlsResponse> DescribeRedisSlowLogTopSqls(DescribeRedisSlowLogTopSqlsRequest req)
        {
            return InternalRequestAsync<DescribeRedisSlowLogTopSqlsResponse>(req, "DescribeRedisSlowLogTopSqls");
        }

        /// <summary>
        /// 统计排序指定时间段内的top慢sql。
        /// </summary>
        /// <param name="req"><see cref="DescribeRedisSlowLogTopSqlsRequest"/></param>
        /// <returns><see cref="DescribeRedisSlowLogTopSqlsResponse"/></returns>
        public DescribeRedisSlowLogTopSqlsResponse DescribeRedisSlowLogTopSqlsSync(DescribeRedisSlowLogTopSqlsRequest req)
        {
            return InternalRequestAsync<DescribeRedisSlowLogTopSqlsResponse>(req, "DescribeRedisSlowLogTopSqls")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询redis实例大key列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeRedisTopBigKeysRequest"/></param>
        /// <returns><see cref="DescribeRedisTopBigKeysResponse"/></returns>
        public Task<DescribeRedisTopBigKeysResponse> DescribeRedisTopBigKeys(DescribeRedisTopBigKeysRequest req)
        {
            return InternalRequestAsync<DescribeRedisTopBigKeysResponse>(req, "DescribeRedisTopBigKeys");
        }

        /// <summary>
        /// 查询redis实例大key列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeRedisTopBigKeysRequest"/></param>
        /// <returns><see cref="DescribeRedisTopBigKeysResponse"/></returns>
        public DescribeRedisTopBigKeysResponse DescribeRedisTopBigKeysSync(DescribeRedisTopBigKeysRequest req)
        {
            return InternalRequestAsync<DescribeRedisTopBigKeysResponse>(req, "DescribeRedisTopBigKeys")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 热Key分析
        /// </summary>
        /// <param name="req"><see cref="DescribeRedisTopHotKeysRequest"/></param>
        /// <returns><see cref="DescribeRedisTopHotKeysResponse"/></returns>
        public Task<DescribeRedisTopHotKeysResponse> DescribeRedisTopHotKeys(DescribeRedisTopHotKeysRequest req)
        {
            return InternalRequestAsync<DescribeRedisTopHotKeysResponse>(req, "DescribeRedisTopHotKeys");
        }

        /// <summary>
        /// 热Key分析
        /// </summary>
        /// <param name="req"><see cref="DescribeRedisTopHotKeysRequest"/></param>
        /// <returns><see cref="DescribeRedisTopHotKeysResponse"/></returns>
        public DescribeRedisTopHotKeysResponse DescribeRedisTopHotKeysSync(DescribeRedisTopHotKeysRequest req)
        {
            return InternalRequestAsync<DescribeRedisTopHotKeysResponse>(req, "DescribeRedisTopHotKeys")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询redis实例top key前缀列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeRedisTopKeyPrefixListRequest"/></param>
        /// <returns><see cref="DescribeRedisTopKeyPrefixListResponse"/></returns>
        public Task<DescribeRedisTopKeyPrefixListResponse> DescribeRedisTopKeyPrefixList(DescribeRedisTopKeyPrefixListRequest req)
        {
            return InternalRequestAsync<DescribeRedisTopKeyPrefixListResponse>(req, "DescribeRedisTopKeyPrefixList");
        }

        /// <summary>
        /// 查询redis实例top key前缀列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeRedisTopKeyPrefixListRequest"/></param>
        /// <returns><see cref="DescribeRedisTopKeyPrefixListResponse"/></returns>
        public DescribeRedisTopKeyPrefixListResponse DescribeRedisTopKeyPrefixListSync(DescribeRedisTopKeyPrefixListRequest req)
        {
            return InternalRequestAsync<DescribeRedisTopKeyPrefixListResponse>(req, "DescribeRedisTopKeyPrefixList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询安全审计日志导出文件下载链接。目前日志文件下载仅提供腾讯云内网地址，请通过广州地域的腾讯云服务器进行下载。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityAuditLogDownloadUrlsRequest"/></param>
        /// <returns><see cref="DescribeSecurityAuditLogDownloadUrlsResponse"/></returns>
        public Task<DescribeSecurityAuditLogDownloadUrlsResponse> DescribeSecurityAuditLogDownloadUrls(DescribeSecurityAuditLogDownloadUrlsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityAuditLogDownloadUrlsResponse>(req, "DescribeSecurityAuditLogDownloadUrls");
        }

        /// <summary>
        /// 查询安全审计日志导出文件下载链接。目前日志文件下载仅提供腾讯云内网地址，请通过广州地域的腾讯云服务器进行下载。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityAuditLogDownloadUrlsRequest"/></param>
        /// <returns><see cref="DescribeSecurityAuditLogDownloadUrlsResponse"/></returns>
        public DescribeSecurityAuditLogDownloadUrlsResponse DescribeSecurityAuditLogDownloadUrlsSync(DescribeSecurityAuditLogDownloadUrlsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityAuditLogDownloadUrlsResponse>(req, "DescribeSecurityAuditLogDownloadUrls")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询安全审计日志导出任务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityAuditLogExportTasksRequest"/></param>
        /// <returns><see cref="DescribeSecurityAuditLogExportTasksResponse"/></returns>
        public Task<DescribeSecurityAuditLogExportTasksResponse> DescribeSecurityAuditLogExportTasks(DescribeSecurityAuditLogExportTasksRequest req)
        {
            return InternalRequestAsync<DescribeSecurityAuditLogExportTasksResponse>(req, "DescribeSecurityAuditLogExportTasks");
        }

        /// <summary>
        /// 查询安全审计日志导出任务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityAuditLogExportTasksRequest"/></param>
        /// <returns><see cref="DescribeSecurityAuditLogExportTasksResponse"/></returns>
        public DescribeSecurityAuditLogExportTasksResponse DescribeSecurityAuditLogExportTasksSync(DescribeSecurityAuditLogExportTasksRequest req)
        {
            return InternalRequestAsync<DescribeSecurityAuditLogExportTasksResponse>(req, "DescribeSecurityAuditLogExportTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 统计排序指定时间段内的top慢sql。
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogQueryTimeStatsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogQueryTimeStatsResponse"/></returns>
        public Task<DescribeSlowLogQueryTimeStatsResponse> DescribeSlowLogQueryTimeStats(DescribeSlowLogQueryTimeStatsRequest req)
        {
            return InternalRequestAsync<DescribeSlowLogQueryTimeStatsResponse>(req, "DescribeSlowLogQueryTimeStats");
        }

        /// <summary>
        /// 统计排序指定时间段内的top慢sql。
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogQueryTimeStatsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogQueryTimeStatsResponse"/></returns>
        public DescribeSlowLogQueryTimeStatsResponse DescribeSlowLogQueryTimeStatsSync(DescribeSlowLogQueryTimeStatsRequest req)
        {
            return InternalRequestAsync<DescribeSlowLogQueryTimeStatsResponse>(req, "DescribeSlowLogQueryTimeStats")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取慢日志统计柱状图。
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogTimeSeriesStatsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogTimeSeriesStatsResponse"/></returns>
        public Task<DescribeSlowLogTimeSeriesStatsResponse> DescribeSlowLogTimeSeriesStats(DescribeSlowLogTimeSeriesStatsRequest req)
        {
            return InternalRequestAsync<DescribeSlowLogTimeSeriesStatsResponse>(req, "DescribeSlowLogTimeSeriesStats");
        }

        /// <summary>
        /// 获取慢日志统计柱状图。
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogTimeSeriesStatsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogTimeSeriesStatsResponse"/></returns>
        public DescribeSlowLogTimeSeriesStatsResponse DescribeSlowLogTimeSeriesStatsSync(DescribeSlowLogTimeSeriesStatsRequest req)
        {
            return InternalRequestAsync<DescribeSlowLogTimeSeriesStatsResponse>(req, "DescribeSlowLogTimeSeriesStats")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 按照Sql模板+schema的聚合方式，统计排序指定时间段内的top慢sql。
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogTopSqlsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogTopSqlsResponse"/></returns>
        public Task<DescribeSlowLogTopSqlsResponse> DescribeSlowLogTopSqls(DescribeSlowLogTopSqlsRequest req)
        {
            return InternalRequestAsync<DescribeSlowLogTopSqlsResponse>(req, "DescribeSlowLogTopSqls");
        }

        /// <summary>
        /// 按照Sql模板+schema的聚合方式，统计排序指定时间段内的top慢sql。
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogTopSqlsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogTopSqlsResponse"/></returns>
        public DescribeSlowLogTopSqlsResponse DescribeSlowLogTopSqlsSync(DescribeSlowLogTopSqlsRequest req)
        {
            return InternalRequestAsync<DescribeSlowLogTopSqlsResponse>(req, "DescribeSlowLogTopSqls")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取慢日志来源地址统计分布图。
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogUserHostStatsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogUserHostStatsResponse"/></returns>
        public Task<DescribeSlowLogUserHostStatsResponse> DescribeSlowLogUserHostStats(DescribeSlowLogUserHostStatsRequest req)
        {
            return InternalRequestAsync<DescribeSlowLogUserHostStatsResponse>(req, "DescribeSlowLogUserHostStats");
        }

        /// <summary>
        /// 获取慢日志来源地址统计分布图。
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogUserHostStatsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogUserHostStatsResponse"/></returns>
        public DescribeSlowLogUserHostStatsResponse DescribeSlowLogUserHostStatsSync(DescribeSlowLogUserHostStatsRequest req)
        {
            return InternalRequestAsync<DescribeSlowLogUserHostStatsResponse>(req, "DescribeSlowLogUserHostStats")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取指定时间内某个sql模板的慢日志明细
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogsResponse"/></returns>
        public Task<DescribeSlowLogsResponse> DescribeSlowLogs(DescribeSlowLogsRequest req)
        {
            return InternalRequestAsync<DescribeSlowLogsResponse>(req, "DescribeSlowLogs");
        }

        /// <summary>
        /// 获取指定时间内某个sql模板的慢日志明细
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogsResponse"/></returns>
        public DescribeSlowLogsResponse DescribeSlowLogsSync(DescribeSlowLogsRequest req)
        {
            return InternalRequestAsync<DescribeSlowLogsResponse>(req, "DescribeSlowLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例SQL限流任务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeSqlFiltersRequest"/></param>
        /// <returns><see cref="DescribeSqlFiltersResponse"/></returns>
        public Task<DescribeSqlFiltersResponse> DescribeSqlFilters(DescribeSqlFiltersRequest req)
        {
            return InternalRequestAsync<DescribeSqlFiltersResponse>(req, "DescribeSqlFilters");
        }

        /// <summary>
        /// 查询实例SQL限流任务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeSqlFiltersRequest"/></param>
        /// <returns><see cref="DescribeSqlFiltersResponse"/></returns>
        public DescribeSqlFiltersResponse DescribeSqlFiltersSync(DescribeSqlFiltersRequest req)
        {
            return InternalRequestAsync<DescribeSqlFiltersResponse>(req, "DescribeSqlFilters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询SQL模板。
        /// </summary>
        /// <param name="req"><see cref="DescribeSqlTemplateRequest"/></param>
        /// <returns><see cref="DescribeSqlTemplateResponse"/></returns>
        public Task<DescribeSqlTemplateResponse> DescribeSqlTemplate(DescribeSqlTemplateRequest req)
        {
            return InternalRequestAsync<DescribeSqlTemplateResponse>(req, "DescribeSqlTemplate");
        }

        /// <summary>
        /// 查询SQL模板。
        /// </summary>
        /// <param name="req"><see cref="DescribeSqlTemplateRequest"/></param>
        /// <returns><see cref="DescribeSqlTemplateResponse"/></returns>
        public DescribeSqlTemplateResponse DescribeSqlTemplateSync(DescribeSqlTemplateRequest req)
        {
            return InternalRequestAsync<DescribeSqlTemplateResponse>(req, "DescribeSqlTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取实例占用空间最大的前几个库在指定时间段内的每日由DBbrain定时采集的空间数据，默认返回按大小排序。
        /// </summary>
        /// <param name="req"><see cref="DescribeTopSpaceSchemaTimeSeriesRequest"/></param>
        /// <returns><see cref="DescribeTopSpaceSchemaTimeSeriesResponse"/></returns>
        public Task<DescribeTopSpaceSchemaTimeSeriesResponse> DescribeTopSpaceSchemaTimeSeries(DescribeTopSpaceSchemaTimeSeriesRequest req)
        {
            return InternalRequestAsync<DescribeTopSpaceSchemaTimeSeriesResponse>(req, "DescribeTopSpaceSchemaTimeSeries");
        }

        /// <summary>
        /// 获取实例占用空间最大的前几个库在指定时间段内的每日由DBbrain定时采集的空间数据，默认返回按大小排序。
        /// </summary>
        /// <param name="req"><see cref="DescribeTopSpaceSchemaTimeSeriesRequest"/></param>
        /// <returns><see cref="DescribeTopSpaceSchemaTimeSeriesResponse"/></returns>
        public DescribeTopSpaceSchemaTimeSeriesResponse DescribeTopSpaceSchemaTimeSeriesSync(DescribeTopSpaceSchemaTimeSeriesRequest req)
        {
            return InternalRequestAsync<DescribeTopSpaceSchemaTimeSeriesResponse>(req, "DescribeTopSpaceSchemaTimeSeries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取实例Top库的实时空间统计信息，默认返回按大小排序。
        /// </summary>
        /// <param name="req"><see cref="DescribeTopSpaceSchemasRequest"/></param>
        /// <returns><see cref="DescribeTopSpaceSchemasResponse"/></returns>
        public Task<DescribeTopSpaceSchemasResponse> DescribeTopSpaceSchemas(DescribeTopSpaceSchemasRequest req)
        {
            return InternalRequestAsync<DescribeTopSpaceSchemasResponse>(req, "DescribeTopSpaceSchemas");
        }

        /// <summary>
        /// 获取实例Top库的实时空间统计信息，默认返回按大小排序。
        /// </summary>
        /// <param name="req"><see cref="DescribeTopSpaceSchemasRequest"/></param>
        /// <returns><see cref="DescribeTopSpaceSchemasResponse"/></returns>
        public DescribeTopSpaceSchemasResponse DescribeTopSpaceSchemasSync(DescribeTopSpaceSchemasRequest req)
        {
            return InternalRequestAsync<DescribeTopSpaceSchemasResponse>(req, "DescribeTopSpaceSchemas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取实例占用空间最大的前几张表在指定时间段内的每日由DBbrain定时采集的空间数据，默认返回按大小排序。
        /// </summary>
        /// <param name="req"><see cref="DescribeTopSpaceTableTimeSeriesRequest"/></param>
        /// <returns><see cref="DescribeTopSpaceTableTimeSeriesResponse"/></returns>
        public Task<DescribeTopSpaceTableTimeSeriesResponse> DescribeTopSpaceTableTimeSeries(DescribeTopSpaceTableTimeSeriesRequest req)
        {
            return InternalRequestAsync<DescribeTopSpaceTableTimeSeriesResponse>(req, "DescribeTopSpaceTableTimeSeries");
        }

        /// <summary>
        /// 获取实例占用空间最大的前几张表在指定时间段内的每日由DBbrain定时采集的空间数据，默认返回按大小排序。
        /// </summary>
        /// <param name="req"><see cref="DescribeTopSpaceTableTimeSeriesRequest"/></param>
        /// <returns><see cref="DescribeTopSpaceTableTimeSeriesResponse"/></returns>
        public DescribeTopSpaceTableTimeSeriesResponse DescribeTopSpaceTableTimeSeriesSync(DescribeTopSpaceTableTimeSeriesRequest req)
        {
            return InternalRequestAsync<DescribeTopSpaceTableTimeSeriesResponse>(req, "DescribeTopSpaceTableTimeSeries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取实例Top表的实时空间统计信息，默认返回按大小排序。
        /// </summary>
        /// <param name="req"><see cref="DescribeTopSpaceTablesRequest"/></param>
        /// <returns><see cref="DescribeTopSpaceTablesResponse"/></returns>
        public Task<DescribeTopSpaceTablesResponse> DescribeTopSpaceTables(DescribeTopSpaceTablesRequest req)
        {
            return InternalRequestAsync<DescribeTopSpaceTablesResponse>(req, "DescribeTopSpaceTables");
        }

        /// <summary>
        /// 获取实例Top表的实时空间统计信息，默认返回按大小排序。
        /// </summary>
        /// <param name="req"><see cref="DescribeTopSpaceTablesRequest"/></param>
        /// <returns><see cref="DescribeTopSpaceTablesResponse"/></returns>
        public DescribeTopSpaceTablesResponse DescribeTopSpaceTablesSync(DescribeTopSpaceTablesRequest req)
        {
            return InternalRequestAsync<DescribeTopSpaceTablesResponse>(req, "DescribeTopSpaceTables")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 自治中心-终止自治任务（单次）；注意： 接口调用需要加白名单。
        /// </summary>
        /// <param name="req"><see cref="DescribeUserAutonomyProfileRequest"/></param>
        /// <returns><see cref="DescribeUserAutonomyProfileResponse"/></returns>
        public Task<DescribeUserAutonomyProfileResponse> DescribeUserAutonomyProfile(DescribeUserAutonomyProfileRequest req)
        {
            return InternalRequestAsync<DescribeUserAutonomyProfileResponse>(req, "DescribeUserAutonomyProfile");
        }

        /// <summary>
        /// 自治中心-终止自治任务（单次）；注意： 接口调用需要加白名单。
        /// </summary>
        /// <param name="req"><see cref="DescribeUserAutonomyProfileRequest"/></param>
        /// <returns><see cref="DescribeUserAutonomyProfileResponse"/></returns>
        public DescribeUserAutonomyProfileResponse DescribeUserAutonomyProfileSync(DescribeUserAutonomyProfileRequest req)
        {
            return InternalRequestAsync<DescribeUserAutonomyProfileResponse>(req, "DescribeUserAutonomyProfile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取SQL优化建议。【产品用户回馈，此接口限免开放，后续将并入dbbrain专业版】
        /// </summary>
        /// <param name="req"><see cref="DescribeUserSqlAdviceRequest"/></param>
        /// <returns><see cref="DescribeUserSqlAdviceResponse"/></returns>
        public Task<DescribeUserSqlAdviceResponse> DescribeUserSqlAdvice(DescribeUserSqlAdviceRequest req)
        {
            return InternalRequestAsync<DescribeUserSqlAdviceResponse>(req, "DescribeUserSqlAdvice");
        }

        /// <summary>
        /// 获取SQL优化建议。【产品用户回馈，此接口限免开放，后续将并入dbbrain专业版】
        /// </summary>
        /// <param name="req"><see cref="DescribeUserSqlAdviceRequest"/></param>
        /// <returns><see cref="DescribeUserSqlAdviceResponse"/></returns>
        public DescribeUserSqlAdviceResponse DescribeUserSqlAdviceSync(DescribeUserSqlAdviceRequest req)
        {
            return InternalRequestAsync<DescribeUserSqlAdviceResponse>(req, "DescribeUserSqlAdvice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据会话ID中断当前会话，该接口分为两次提交：第一次为预提交阶段，Stage为"Prepare"，得到的返回值包含SqlExecId；第二次为确认提交， Stage为"Commit"， 将SqlExecId的值作为参数传入，最终终止会话进程。
        /// </summary>
        /// <param name="req"><see cref="KillMySqlThreadsRequest"/></param>
        /// <returns><see cref="KillMySqlThreadsResponse"/></returns>
        public Task<KillMySqlThreadsResponse> KillMySqlThreads(KillMySqlThreadsRequest req)
        {
            return InternalRequestAsync<KillMySqlThreadsResponse>(req, "KillMySqlThreads");
        }

        /// <summary>
        /// 根据会话ID中断当前会话，该接口分为两次提交：第一次为预提交阶段，Stage为"Prepare"，得到的返回值包含SqlExecId；第二次为确认提交， Stage为"Commit"， 将SqlExecId的值作为参数传入，最终终止会话进程。
        /// </summary>
        /// <param name="req"><see cref="KillMySqlThreadsRequest"/></param>
        /// <returns><see cref="KillMySqlThreadsResponse"/></returns>
        public KillMySqlThreadsResponse KillMySqlThreadsSync(KillMySqlThreadsRequest req)
        {
            return InternalRequestAsync<KillMySqlThreadsResponse>(req, "KillMySqlThreads")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改告警策略
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmPolicyRequest"/></param>
        /// <returns><see cref="ModifyAlarmPolicyResponse"/></returns>
        public Task<ModifyAlarmPolicyResponse> ModifyAlarmPolicy(ModifyAlarmPolicyRequest req)
        {
            return InternalRequestAsync<ModifyAlarmPolicyResponse>(req, "ModifyAlarmPolicy");
        }

        /// <summary>
        /// 修改告警策略
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmPolicyRequest"/></param>
        /// <returns><see cref="ModifyAlarmPolicyResponse"/></returns>
        public ModifyAlarmPolicyResponse ModifyAlarmPolicySync(ModifyAlarmPolicyRequest req)
        {
            return InternalRequestAsync<ModifyAlarmPolicyResponse>(req, "ModifyAlarmPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改审计配置相关信息，如高频存储时长等
        /// </summary>
        /// <param name="req"><see cref="ModifyAuditServiceRequest"/></param>
        /// <returns><see cref="ModifyAuditServiceResponse"/></returns>
        public Task<ModifyAuditServiceResponse> ModifyAuditService(ModifyAuditServiceRequest req)
        {
            return InternalRequestAsync<ModifyAuditServiceResponse>(req, "ModifyAuditService");
        }

        /// <summary>
        /// 修改审计配置相关信息，如高频存储时长等
        /// </summary>
        /// <param name="req"><see cref="ModifyAuditServiceRequest"/></param>
        /// <returns><see cref="ModifyAuditServiceResponse"/></returns>
        public ModifyAuditServiceResponse ModifyAuditServiceSync(ModifyAuditServiceRequest req)
        {
            return InternalRequestAsync<ModifyAuditServiceResponse>(req, "ModifyAuditService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改实例的配置信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyDiagDBInstanceConfRequest"/></param>
        /// <returns><see cref="ModifyDiagDBInstanceConfResponse"/></returns>
        public Task<ModifyDiagDBInstanceConfResponse> ModifyDiagDBInstanceConf(ModifyDiagDBInstanceConfRequest req)
        {
            return InternalRequestAsync<ModifyDiagDBInstanceConfResponse>(req, "ModifyDiagDBInstanceConf");
        }

        /// <summary>
        /// 修改实例的配置信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyDiagDBInstanceConfRequest"/></param>
        /// <returns><see cref="ModifyDiagDBInstanceConfResponse"/></returns>
        public ModifyDiagDBInstanceConfResponse ModifyDiagDBInstanceConfSync(ModifyDiagDBInstanceConfRequest req)
        {
            return InternalRequestAsync<ModifyDiagDBInstanceConfResponse>(req, "ModifyDiagDBInstanceConf")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更改实例限流任务状态，目前仅用于终止限流。
        /// </summary>
        /// <param name="req"><see cref="ModifySqlFiltersRequest"/></param>
        /// <returns><see cref="ModifySqlFiltersResponse"/></returns>
        public Task<ModifySqlFiltersResponse> ModifySqlFilters(ModifySqlFiltersRequest req)
        {
            return InternalRequestAsync<ModifySqlFiltersResponse>(req, "ModifySqlFilters");
        }

        /// <summary>
        /// 更改实例限流任务状态，目前仅用于终止限流。
        /// </summary>
        /// <param name="req"><see cref="ModifySqlFiltersRequest"/></param>
        /// <returns><see cref="ModifySqlFiltersResponse"/></returns>
        public ModifySqlFiltersResponse ModifySqlFiltersSync(ModifySqlFiltersRequest req)
        {
            return InternalRequestAsync<ModifySqlFiltersResponse>(req, "ModifySqlFilters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 自治中心-终止自治任务（单次）；注意：接口需要加白名单。
        /// </summary>
        /// <param name="req"><see cref="ModifyUserAutonomyProfileRequest"/></param>
        /// <returns><see cref="ModifyUserAutonomyProfileResponse"/></returns>
        public Task<ModifyUserAutonomyProfileResponse> ModifyUserAutonomyProfile(ModifyUserAutonomyProfileRequest req)
        {
            return InternalRequestAsync<ModifyUserAutonomyProfileResponse>(req, "ModifyUserAutonomyProfile");
        }

        /// <summary>
        /// 自治中心-终止自治任务（单次）；注意：接口需要加白名单。
        /// </summary>
        /// <param name="req"><see cref="ModifyUserAutonomyProfileRequest"/></param>
        /// <returns><see cref="ModifyUserAutonomyProfileResponse"/></returns>
        public ModifyUserAutonomyProfileResponse ModifyUserAutonomyProfileSync(ModifyUserAutonomyProfileRequest req)
        {
            return InternalRequestAsync<ModifyUserAutonomyProfileResponse>(req, "ModifyUserAutonomyProfile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 开启数据库审计服务
        /// </summary>
        /// <param name="req"><see cref="OpenAuditServiceRequest"/></param>
        /// <returns><see cref="OpenAuditServiceResponse"/></returns>
        public Task<OpenAuditServiceResponse> OpenAuditService(OpenAuditServiceRequest req)
        {
            return InternalRequestAsync<OpenAuditServiceResponse>(req, "OpenAuditService");
        }

        /// <summary>
        /// 开启数据库审计服务
        /// </summary>
        /// <param name="req"><see cref="OpenAuditServiceRequest"/></param>
        /// <returns><see cref="OpenAuditServiceResponse"/></returns>
        public OpenAuditServiceResponse OpenAuditServiceSync(OpenAuditServiceRequest req)
        {
            return InternalRequestAsync<OpenAuditServiceResponse>(req, "OpenAuditService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新agent状态（停止或重连Agent）
        /// </summary>
        /// <param name="req"><see cref="UpdateAgentSwitchRequest"/></param>
        /// <returns><see cref="UpdateAgentSwitchResponse"/></returns>
        public Task<UpdateAgentSwitchResponse> UpdateAgentSwitch(UpdateAgentSwitchRequest req)
        {
            return InternalRequestAsync<UpdateAgentSwitchResponse>(req, "UpdateAgentSwitch");
        }

        /// <summary>
        /// 更新agent状态（停止或重连Agent）
        /// </summary>
        /// <param name="req"><see cref="UpdateAgentSwitchRequest"/></param>
        /// <returns><see cref="UpdateAgentSwitchResponse"/></returns>
        public UpdateAgentSwitchResponse UpdateAgentSwitchSync(UpdateAgentSwitchRequest req)
        {
            return InternalRequestAsync<UpdateAgentSwitchResponse>(req, "UpdateAgentSwitch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新Agent实例状态（停止或重连实例）
        /// </summary>
        /// <param name="req"><see cref="UpdateMonitorSwitchRequest"/></param>
        /// <returns><see cref="UpdateMonitorSwitchResponse"/></returns>
        public Task<UpdateMonitorSwitchResponse> UpdateMonitorSwitch(UpdateMonitorSwitchRequest req)
        {
            return InternalRequestAsync<UpdateMonitorSwitchResponse>(req, "UpdateMonitorSwitch");
        }

        /// <summary>
        /// 更新Agent实例状态（停止或重连实例）
        /// </summary>
        /// <param name="req"><see cref="UpdateMonitorSwitchRequest"/></param>
        /// <returns><see cref="UpdateMonitorSwitchResponse"/></returns>
        public UpdateMonitorSwitchResponse UpdateMonitorSwitchSync(UpdateMonitorSwitchRequest req)
        {
            return InternalRequestAsync<UpdateMonitorSwitchResponse>(req, "UpdateMonitorSwitch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 验证用户数据库账号权限，获取会话token。
        /// </summary>
        /// <param name="req"><see cref="VerifyUserAccountRequest"/></param>
        /// <returns><see cref="VerifyUserAccountResponse"/></returns>
        public Task<VerifyUserAccountResponse> VerifyUserAccount(VerifyUserAccountRequest req)
        {
            return InternalRequestAsync<VerifyUserAccountResponse>(req, "VerifyUserAccount");
        }

        /// <summary>
        /// 验证用户数据库账号权限，获取会话token。
        /// </summary>
        /// <param name="req"><see cref="VerifyUserAccountRequest"/></param>
        /// <returns><see cref="VerifyUserAccountResponse"/></returns>
        public VerifyUserAccountResponse VerifyUserAccountSync(VerifyUserAccountRequest req)
        {
            return InternalRequestAsync<VerifyUserAccountResponse>(req, "VerifyUserAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}

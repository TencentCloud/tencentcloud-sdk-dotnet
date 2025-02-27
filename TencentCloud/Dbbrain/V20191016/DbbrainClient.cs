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

namespace TencentCloud.Dbbrain.V20191016
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Dbbrain.V20191016.Models;

   public class DbbrainClient : AbstractClient{

       private const string endpoint = "dbbrain.tencentcloudapi.com";
       private const string version = "2019-10-16";
       private const string sdkVersion = "SDK_NET_3.0.1188";

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
        /// 添加邮件接收联系人的姓名， 邮件地址，返回值为添加成功的联系人id。Region统一选择广州。
        /// </summary>
        /// <param name="req"><see cref="AddUserContactRequest"/></param>
        /// <returns><see cref="AddUserContactResponse"/></returns>
        public Task<AddUserContactResponse> AddUserContact(AddUserContactRequest req)
        {
            return InternalRequestAsync<AddUserContactResponse>(req, "AddUserContact");
        }

        /// <summary>
        /// 添加邮件接收联系人的姓名， 邮件地址，返回值为添加成功的联系人id。Region统一选择广州。
        /// </summary>
        /// <param name="req"><see cref="AddUserContactRequest"/></param>
        /// <returns><see cref="AddUserContactResponse"/></returns>
        public AddUserContactResponse AddUserContactSync(AddUserContactRequest req)
        {
            return InternalRequestAsync<AddUserContactResponse>(req, "AddUserContact")
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
        /// 获取发送邮件的配置， 包括数据库巡检的邮件配置以及定期生成健康报告的邮件发送配置。Region统一选择广州。
        /// </summary>
        /// <param name="req"><see cref="DescribeMailProfileRequest"/></param>
        /// <returns><see cref="DescribeMailProfileResponse"/></returns>
        public Task<DescribeMailProfileResponse> DescribeMailProfile(DescribeMailProfileRequest req)
        {
            return InternalRequestAsync<DescribeMailProfileResponse>(req, "DescribeMailProfile");
        }

        /// <summary>
        /// 获取发送邮件的配置， 包括数据库巡检的邮件配置以及定期生成健康报告的邮件发送配置。Region统一选择广州。
        /// </summary>
        /// <param name="req"><see cref="DescribeMailProfileRequest"/></param>
        /// <returns><see cref="DescribeMailProfileResponse"/></returns>
        public DescribeMailProfileResponse DescribeMailProfileSync(DescribeMailProfileRequest req)
        {
            return InternalRequestAsync<DescribeMailProfileResponse>(req, "DescribeMailProfile")
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
        /// 获取SQL优化建议。
        /// </summary>
        /// <param name="req"><see cref="DescribeUserSqlAdviceRequest"/></param>
        /// <returns><see cref="DescribeUserSqlAdviceResponse"/></returns>
        public Task<DescribeUserSqlAdviceResponse> DescribeUserSqlAdvice(DescribeUserSqlAdviceRequest req)
        {
            return InternalRequestAsync<DescribeUserSqlAdviceResponse>(req, "DescribeUserSqlAdvice");
        }

        /// <summary>
        /// 获取SQL优化建议。
        /// </summary>
        /// <param name="req"><see cref="DescribeUserSqlAdviceRequest"/></param>
        /// <returns><see cref="DescribeUserSqlAdviceResponse"/></returns>
        public DescribeUserSqlAdviceResponse DescribeUserSqlAdviceSync(DescribeUserSqlAdviceRequest req)
        {
            return InternalRequestAsync<DescribeUserSqlAdviceResponse>(req, "DescribeUserSqlAdvice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改实例巡检开关。
        /// </summary>
        /// <param name="req"><see cref="ModifyDiagDBInstanceConfRequest"/></param>
        /// <returns><see cref="ModifyDiagDBInstanceConfResponse"/></returns>
        public Task<ModifyDiagDBInstanceConfResponse> ModifyDiagDBInstanceConf(ModifyDiagDBInstanceConfRequest req)
        {
            return InternalRequestAsync<ModifyDiagDBInstanceConfResponse>(req, "ModifyDiagDBInstanceConf");
        }

        /// <summary>
        /// 修改实例巡检开关。
        /// </summary>
        /// <param name="req"><see cref="ModifyDiagDBInstanceConfRequest"/></param>
        /// <returns><see cref="ModifyDiagDBInstanceConfResponse"/></returns>
        public ModifyDiagDBInstanceConfResponse ModifyDiagDBInstanceConfSync(ModifyDiagDBInstanceConfRequest req)
        {
            return InternalRequestAsync<ModifyDiagDBInstanceConfResponse>(req, "ModifyDiagDBInstanceConf")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}

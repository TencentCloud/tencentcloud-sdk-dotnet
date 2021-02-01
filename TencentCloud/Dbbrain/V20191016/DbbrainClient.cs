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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DbbrainClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 创建健康报告，并可以选择是否发送邮件。
        /// </summary>
        /// <param name="req"><see cref="CreateDBDiagReportTaskRequest"/></param>
        /// <returns><see cref="CreateDBDiagReportTaskResponse"/></returns>
        public async Task<CreateDBDiagReportTaskResponse> CreateDBDiagReportTask(CreateDBDiagReportTaskRequest req)
        {
             JsonResponseModel<CreateDBDiagReportTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDBDiagReportTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDBDiagReportTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建健康报告，并可以选择是否发送邮件。
        /// </summary>
        /// <param name="req"><see cref="CreateDBDiagReportTaskRequest"/></param>
        /// <returns><see cref="CreateDBDiagReportTaskResponse"/></returns>
        public CreateDBDiagReportTaskResponse CreateDBDiagReportTaskSync(CreateDBDiagReportTaskRequest req)
        {
             JsonResponseModel<CreateDBDiagReportTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDBDiagReportTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDBDiagReportTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建邮件配置。其中入参ProfileType表示所创建配置的类型，ProfileType 取值包括：dbScan_mail_configuration（数据库巡检邮件配置）、scheduler_mail_configuration（定期生成邮件配置）。
        /// </summary>
        /// <param name="req"><see cref="CreateMailProfileRequest"/></param>
        /// <returns><see cref="CreateMailProfileResponse"/></returns>
        public async Task<CreateMailProfileResponse> CreateMailProfile(CreateMailProfileRequest req)
        {
             JsonResponseModel<CreateMailProfileResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateMailProfile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMailProfileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建邮件配置。其中入参ProfileType表示所创建配置的类型，ProfileType 取值包括：dbScan_mail_configuration（数据库巡检邮件配置）、scheduler_mail_configuration（定期生成邮件配置）。
        /// </summary>
        /// <param name="req"><see cref="CreateMailProfileRequest"/></param>
        /// <returns><see cref="CreateMailProfileResponse"/></returns>
        public CreateMailProfileResponse CreateMailProfileSync(CreateMailProfileRequest req)
        {
             JsonResponseModel<CreateMailProfileResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateMailProfile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMailProfileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建安全审计日志导出任务。
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityAuditLogExportTaskRequest"/></param>
        /// <returns><see cref="CreateSecurityAuditLogExportTaskResponse"/></returns>
        public async Task<CreateSecurityAuditLogExportTaskResponse> CreateSecurityAuditLogExportTask(CreateSecurityAuditLogExportTaskRequest req)
        {
             JsonResponseModel<CreateSecurityAuditLogExportTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSecurityAuditLogExportTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecurityAuditLogExportTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建安全审计日志导出任务。
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityAuditLogExportTaskRequest"/></param>
        /// <returns><see cref="CreateSecurityAuditLogExportTaskResponse"/></returns>
        public CreateSecurityAuditLogExportTaskResponse CreateSecurityAuditLogExportTaskSync(CreateSecurityAuditLogExportTaskRequest req)
        {
             JsonResponseModel<CreateSecurityAuditLogExportTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSecurityAuditLogExportTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecurityAuditLogExportTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除安全审计日志导出任务。
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityAuditLogExportTasksRequest"/></param>
        /// <returns><see cref="DeleteSecurityAuditLogExportTasksResponse"/></returns>
        public async Task<DeleteSecurityAuditLogExportTasksResponse> DeleteSecurityAuditLogExportTasks(DeleteSecurityAuditLogExportTasksRequest req)
        {
             JsonResponseModel<DeleteSecurityAuditLogExportTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSecurityAuditLogExportTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSecurityAuditLogExportTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除安全审计日志导出任务。
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityAuditLogExportTasksRequest"/></param>
        /// <returns><see cref="DeleteSecurityAuditLogExportTasksResponse"/></returns>
        public DeleteSecurityAuditLogExportTasksResponse DeleteSecurityAuditLogExportTasksSync(DeleteSecurityAuditLogExportTasksRequest req)
        {
             JsonResponseModel<DeleteSecurityAuditLogExportTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSecurityAuditLogExportTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSecurityAuditLogExportTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取邮件发送中联系人的相关信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeAllUserContactRequest"/></param>
        /// <returns><see cref="DescribeAllUserContactResponse"/></returns>
        public async Task<DescribeAllUserContactResponse> DescribeAllUserContact(DescribeAllUserContactRequest req)
        {
             JsonResponseModel<DescribeAllUserContactResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAllUserContact");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAllUserContactResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取邮件发送中联系人的相关信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeAllUserContactRequest"/></param>
        /// <returns><see cref="DescribeAllUserContactResponse"/></returns>
        public DescribeAllUserContactResponse DescribeAllUserContactSync(DescribeAllUserContactRequest req)
        {
             JsonResponseModel<DescribeAllUserContactResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAllUserContact");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAllUserContactResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取邮件发送联系组的相关信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeAllUserGroupRequest"/></param>
        /// <returns><see cref="DescribeAllUserGroupResponse"/></returns>
        public async Task<DescribeAllUserGroupResponse> DescribeAllUserGroup(DescribeAllUserGroupRequest req)
        {
             JsonResponseModel<DescribeAllUserGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAllUserGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAllUserGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取邮件发送联系组的相关信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeAllUserGroupRequest"/></param>
        /// <returns><see cref="DescribeAllUserGroupResponse"/></returns>
        public DescribeAllUserGroupResponse DescribeAllUserGroupSync(DescribeAllUserGroupRequest req)
        {
             JsonResponseModel<DescribeAllUserGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAllUserGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAllUserGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取实例异常诊断事件的详情信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBDiagEventRequest"/></param>
        /// <returns><see cref="DescribeDBDiagEventResponse"/></returns>
        public async Task<DescribeDBDiagEventResponse> DescribeDBDiagEvent(DescribeDBDiagEventRequest req)
        {
             JsonResponseModel<DescribeDBDiagEventResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBDiagEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBDiagEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取实例异常诊断事件的详情信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBDiagEventRequest"/></param>
        /// <returns><see cref="DescribeDBDiagEventResponse"/></returns>
        public DescribeDBDiagEventResponse DescribeDBDiagEventSync(DescribeDBDiagEventRequest req)
        {
             JsonResponseModel<DescribeDBDiagEventResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBDiagEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBDiagEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取实例诊断事件的列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBDiagHistoryRequest"/></param>
        /// <returns><see cref="DescribeDBDiagHistoryResponse"/></returns>
        public async Task<DescribeDBDiagHistoryResponse> DescribeDBDiagHistory(DescribeDBDiagHistoryRequest req)
        {
             JsonResponseModel<DescribeDBDiagHistoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBDiagHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBDiagHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取实例诊断事件的列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBDiagHistoryRequest"/></param>
        /// <returns><see cref="DescribeDBDiagHistoryResponse"/></returns>
        public DescribeDBDiagHistoryResponse DescribeDBDiagHistorySync(DescribeDBDiagHistoryRequest req)
        {
             JsonResponseModel<DescribeDBDiagHistoryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBDiagHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBDiagHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定时间段内的实例空间使用概览，包括磁盘增长量(MB)、磁盘剩余(MB)、磁盘总量(MB)及预计可用天数。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSpaceStatusRequest"/></param>
        /// <returns><see cref="DescribeDBSpaceStatusResponse"/></returns>
        public async Task<DescribeDBSpaceStatusResponse> DescribeDBSpaceStatus(DescribeDBSpaceStatusRequest req)
        {
             JsonResponseModel<DescribeDBSpaceStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBSpaceStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBSpaceStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定时间段内的实例空间使用概览，包括磁盘增长量(MB)、磁盘剩余(MB)、磁盘总量(MB)及预计可用天数。
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSpaceStatusRequest"/></param>
        /// <returns><see cref="DescribeDBSpaceStatusResponse"/></returns>
        public DescribeDBSpaceStatusResponse DescribeDBSpaceStatusSync(DescribeDBSpaceStatusRequest req)
        {
             JsonResponseModel<DescribeDBSpaceStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBSpaceStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBSpaceStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询安全审计日志导出文件下载链接。目前日志文件下载仅提供腾讯云内网地址，请通过广州地域的腾讯云服务器进行下载。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityAuditLogDownloadUrlsRequest"/></param>
        /// <returns><see cref="DescribeSecurityAuditLogDownloadUrlsResponse"/></returns>
        public async Task<DescribeSecurityAuditLogDownloadUrlsResponse> DescribeSecurityAuditLogDownloadUrls(DescribeSecurityAuditLogDownloadUrlsRequest req)
        {
             JsonResponseModel<DescribeSecurityAuditLogDownloadUrlsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityAuditLogDownloadUrls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityAuditLogDownloadUrlsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询安全审计日志导出文件下载链接。目前日志文件下载仅提供腾讯云内网地址，请通过广州地域的腾讯云服务器进行下载。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityAuditLogDownloadUrlsRequest"/></param>
        /// <returns><see cref="DescribeSecurityAuditLogDownloadUrlsResponse"/></returns>
        public DescribeSecurityAuditLogDownloadUrlsResponse DescribeSecurityAuditLogDownloadUrlsSync(DescribeSecurityAuditLogDownloadUrlsRequest req)
        {
             JsonResponseModel<DescribeSecurityAuditLogDownloadUrlsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecurityAuditLogDownloadUrls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityAuditLogDownloadUrlsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询安全审计日志导出任务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityAuditLogExportTasksRequest"/></param>
        /// <returns><see cref="DescribeSecurityAuditLogExportTasksResponse"/></returns>
        public async Task<DescribeSecurityAuditLogExportTasksResponse> DescribeSecurityAuditLogExportTasks(DescribeSecurityAuditLogExportTasksRequest req)
        {
             JsonResponseModel<DescribeSecurityAuditLogExportTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityAuditLogExportTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityAuditLogExportTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询安全审计日志导出任务列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityAuditLogExportTasksRequest"/></param>
        /// <returns><see cref="DescribeSecurityAuditLogExportTasksResponse"/></returns>
        public DescribeSecurityAuditLogExportTasksResponse DescribeSecurityAuditLogExportTasksSync(DescribeSecurityAuditLogExportTasksRequest req)
        {
             JsonResponseModel<DescribeSecurityAuditLogExportTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecurityAuditLogExportTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityAuditLogExportTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取慢日志统计柱状图。
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogTimeSeriesStatsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogTimeSeriesStatsResponse"/></returns>
        public async Task<DescribeSlowLogTimeSeriesStatsResponse> DescribeSlowLogTimeSeriesStats(DescribeSlowLogTimeSeriesStatsRequest req)
        {
             JsonResponseModel<DescribeSlowLogTimeSeriesStatsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSlowLogTimeSeriesStats");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowLogTimeSeriesStatsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取慢日志统计柱状图。
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogTimeSeriesStatsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogTimeSeriesStatsResponse"/></returns>
        public DescribeSlowLogTimeSeriesStatsResponse DescribeSlowLogTimeSeriesStatsSync(DescribeSlowLogTimeSeriesStatsRequest req)
        {
             JsonResponseModel<DescribeSlowLogTimeSeriesStatsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSlowLogTimeSeriesStats");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowLogTimeSeriesStatsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按照Sql模板+schema的聚合方式，统计排序指定时间段内的top慢sql。
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogTopSqlsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogTopSqlsResponse"/></returns>
        public async Task<DescribeSlowLogTopSqlsResponse> DescribeSlowLogTopSqls(DescribeSlowLogTopSqlsRequest req)
        {
             JsonResponseModel<DescribeSlowLogTopSqlsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSlowLogTopSqls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowLogTopSqlsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按照Sql模板+schema的聚合方式，统计排序指定时间段内的top慢sql。
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogTopSqlsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogTopSqlsResponse"/></returns>
        public DescribeSlowLogTopSqlsResponse DescribeSlowLogTopSqlsSync(DescribeSlowLogTopSqlsRequest req)
        {
             JsonResponseModel<DescribeSlowLogTopSqlsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSlowLogTopSqls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowLogTopSqlsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取实例占用空间最大的前几张表在指定时间段内的每日由DBbrain定时采集的空间数据，默认返回按大小排序。
        /// </summary>
        /// <param name="req"><see cref="DescribeTopSpaceTableTimeSeriesRequest"/></param>
        /// <returns><see cref="DescribeTopSpaceTableTimeSeriesResponse"/></returns>
        public async Task<DescribeTopSpaceTableTimeSeriesResponse> DescribeTopSpaceTableTimeSeries(DescribeTopSpaceTableTimeSeriesRequest req)
        {
             JsonResponseModel<DescribeTopSpaceTableTimeSeriesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTopSpaceTableTimeSeries");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopSpaceTableTimeSeriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取实例占用空间最大的前几张表在指定时间段内的每日由DBbrain定时采集的空间数据，默认返回按大小排序。
        /// </summary>
        /// <param name="req"><see cref="DescribeTopSpaceTableTimeSeriesRequest"/></param>
        /// <returns><see cref="DescribeTopSpaceTableTimeSeriesResponse"/></returns>
        public DescribeTopSpaceTableTimeSeriesResponse DescribeTopSpaceTableTimeSeriesSync(DescribeTopSpaceTableTimeSeriesRequest req)
        {
             JsonResponseModel<DescribeTopSpaceTableTimeSeriesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTopSpaceTableTimeSeries");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopSpaceTableTimeSeriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取实例Top表的实时空间统计信息，默认返回按大小排序。
        /// </summary>
        /// <param name="req"><see cref="DescribeTopSpaceTablesRequest"/></param>
        /// <returns><see cref="DescribeTopSpaceTablesResponse"/></returns>
        public async Task<DescribeTopSpaceTablesResponse> DescribeTopSpaceTables(DescribeTopSpaceTablesRequest req)
        {
             JsonResponseModel<DescribeTopSpaceTablesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTopSpaceTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopSpaceTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取实例Top表的实时空间统计信息，默认返回按大小排序。
        /// </summary>
        /// <param name="req"><see cref="DescribeTopSpaceTablesRequest"/></param>
        /// <returns><see cref="DescribeTopSpaceTablesResponse"/></returns>
        public DescribeTopSpaceTablesResponse DescribeTopSpaceTablesSync(DescribeTopSpaceTablesRequest req)
        {
             JsonResponseModel<DescribeTopSpaceTablesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTopSpaceTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopSpaceTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改实例巡检开关。
        /// </summary>
        /// <param name="req"><see cref="ModifyDiagDBInstanceConfRequest"/></param>
        /// <returns><see cref="ModifyDiagDBInstanceConfResponse"/></returns>
        public async Task<ModifyDiagDBInstanceConfResponse> ModifyDiagDBInstanceConf(ModifyDiagDBInstanceConfRequest req)
        {
             JsonResponseModel<ModifyDiagDBInstanceConfResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDiagDBInstanceConf");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDiagDBInstanceConfResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改实例巡检开关。
        /// </summary>
        /// <param name="req"><see cref="ModifyDiagDBInstanceConfRequest"/></param>
        /// <returns><see cref="ModifyDiagDBInstanceConfResponse"/></returns>
        public ModifyDiagDBInstanceConfResponse ModifyDiagDBInstanceConfSync(ModifyDiagDBInstanceConfRequest req)
        {
             JsonResponseModel<ModifyDiagDBInstanceConfResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDiagDBInstanceConf");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDiagDBInstanceConfResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}

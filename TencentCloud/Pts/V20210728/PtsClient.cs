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

namespace TencentCloud.Pts.V20210728
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Pts.V20210728.Models;

   public class PtsClient : AbstractClient{

       private const string endpoint = "pts.tencentcloudapi.com";
       private const string version = "2021-07-28";
       private const string sdkVersion = "SDK_NET_3.0.1121";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public PtsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public PtsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 停止定时任务
        /// </summary>
        /// <param name="req"><see cref="AbortCronJobsRequest"/></param>
        /// <returns><see cref="AbortCronJobsResponse"/></returns>
        public Task<AbortCronJobsResponse> AbortCronJobs(AbortCronJobsRequest req)
        {
            return InternalRequestAsync<AbortCronJobsResponse>(req, "AbortCronJobs");
        }

        /// <summary>
        /// 停止定时任务
        /// </summary>
        /// <param name="req"><see cref="AbortCronJobsRequest"/></param>
        /// <returns><see cref="AbortCronJobsResponse"/></returns>
        public AbortCronJobsResponse AbortCronJobsSync(AbortCronJobsRequest req)
        {
            return InternalRequestAsync<AbortCronJobsResponse>(req, "AbortCronJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止任务
        /// </summary>
        /// <param name="req"><see cref="AbortJobRequest"/></param>
        /// <returns><see cref="AbortJobResponse"/></returns>
        public Task<AbortJobResponse> AbortJob(AbortJobRequest req)
        {
            return InternalRequestAsync<AbortJobResponse>(req, "AbortJob");
        }

        /// <summary>
        /// 停止任务
        /// </summary>
        /// <param name="req"><see cref="AbortJobRequest"/></param>
        /// <returns><see cref="AbortJobResponse"/></returns>
        public AbortJobResponse AbortJobSync(AbortJobRequest req)
        {
            return InternalRequestAsync<AbortJobResponse>(req, "AbortJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 调整任务的目标RPS
        /// </summary>
        /// <param name="req"><see cref="AdjustJobSpeedRequest"/></param>
        /// <returns><see cref="AdjustJobSpeedResponse"/></returns>
        public Task<AdjustJobSpeedResponse> AdjustJobSpeed(AdjustJobSpeedRequest req)
        {
            return InternalRequestAsync<AdjustJobSpeedResponse>(req, "AdjustJobSpeed");
        }

        /// <summary>
        /// 调整任务的目标RPS
        /// </summary>
        /// <param name="req"><see cref="AdjustJobSpeedRequest"/></param>
        /// <returns><see cref="AdjustJobSpeedResponse"/></returns>
        public AdjustJobSpeedResponse AdjustJobSpeedSync(AdjustJobSpeedRequest req)
        {
            return InternalRequestAsync<AdjustJobSpeedResponse>(req, "AdjustJobSpeed")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 复制场景
        /// </summary>
        /// <param name="req"><see cref="CopyScenarioRequest"/></param>
        /// <returns><see cref="CopyScenarioResponse"/></returns>
        public Task<CopyScenarioResponse> CopyScenario(CopyScenarioRequest req)
        {
            return InternalRequestAsync<CopyScenarioResponse>(req, "CopyScenario");
        }

        /// <summary>
        /// 复制场景
        /// </summary>
        /// <param name="req"><see cref="CopyScenarioRequest"/></param>
        /// <returns><see cref="CopyScenarioResponse"/></returns>
        public CopyScenarioResponse CopyScenarioSync(CopyScenarioRequest req)
        {
            return InternalRequestAsync<CopyScenarioResponse>(req, "CopyScenario")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建告警通知接收组
        /// </summary>
        /// <param name="req"><see cref="CreateAlertChannelRequest"/></param>
        /// <returns><see cref="CreateAlertChannelResponse"/></returns>
        public Task<CreateAlertChannelResponse> CreateAlertChannel(CreateAlertChannelRequest req)
        {
            return InternalRequestAsync<CreateAlertChannelResponse>(req, "CreateAlertChannel");
        }

        /// <summary>
        /// 创建告警通知接收组
        /// </summary>
        /// <param name="req"><see cref="CreateAlertChannelRequest"/></param>
        /// <returns><see cref="CreateAlertChannelResponse"/></returns>
        public CreateAlertChannelResponse CreateAlertChannelSync(CreateAlertChannelRequest req)
        {
            return InternalRequestAsync<CreateAlertChannelResponse>(req, "CreateAlertChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建定时任务
        /// </summary>
        /// <param name="req"><see cref="CreateCronJobRequest"/></param>
        /// <returns><see cref="CreateCronJobResponse"/></returns>
        public Task<CreateCronJobResponse> CreateCronJob(CreateCronJobRequest req)
        {
            return InternalRequestAsync<CreateCronJobResponse>(req, "CreateCronJob");
        }

        /// <summary>
        /// 创建定时任务
        /// </summary>
        /// <param name="req"><see cref="CreateCronJobRequest"/></param>
        /// <returns><see cref="CreateCronJobResponse"/></returns>
        public CreateCronJobResponse CreateCronJobSync(CreateCronJobRequest req)
        {
            return InternalRequestAsync<CreateCronJobResponse>(req, "CreateCronJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建环境
        /// </summary>
        /// <param name="req"><see cref="CreateEnvironmentRequest"/></param>
        /// <returns><see cref="CreateEnvironmentResponse"/></returns>
        public Task<CreateEnvironmentResponse> CreateEnvironment(CreateEnvironmentRequest req)
        {
            return InternalRequestAsync<CreateEnvironmentResponse>(req, "CreateEnvironment");
        }

        /// <summary>
        /// 创建环境
        /// </summary>
        /// <param name="req"><see cref="CreateEnvironmentRequest"/></param>
        /// <returns><see cref="CreateEnvironmentResponse"/></returns>
        public CreateEnvironmentResponse CreateEnvironmentSync(CreateEnvironmentRequest req)
        {
            return InternalRequestAsync<CreateEnvironmentResponse>(req, "CreateEnvironment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建文件
        /// </summary>
        /// <param name="req"><see cref="CreateFileRequest"/></param>
        /// <returns><see cref="CreateFileResponse"/></returns>
        public Task<CreateFileResponse> CreateFile(CreateFileRequest req)
        {
            return InternalRequestAsync<CreateFileResponse>(req, "CreateFile");
        }

        /// <summary>
        /// 创建文件
        /// </summary>
        /// <param name="req"><see cref="CreateFileRequest"/></param>
        /// <returns><see cref="CreateFileResponse"/></returns>
        public CreateFileResponse CreateFileSync(CreateFileRequest req)
        {
            return InternalRequestAsync<CreateFileResponse>(req, "CreateFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建项目
        /// </summary>
        /// <param name="req"><see cref="CreateProjectRequest"/></param>
        /// <returns><see cref="CreateProjectResponse"/></returns>
        public Task<CreateProjectResponse> CreateProject(CreateProjectRequest req)
        {
            return InternalRequestAsync<CreateProjectResponse>(req, "CreateProject");
        }

        /// <summary>
        /// 创建项目
        /// </summary>
        /// <param name="req"><see cref="CreateProjectRequest"/></param>
        /// <returns><see cref="CreateProjectResponse"/></returns>
        public CreateProjectResponse CreateProjectSync(CreateProjectRequest req)
        {
            return InternalRequestAsync<CreateProjectResponse>(req, "CreateProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建场景
        /// </summary>
        /// <param name="req"><see cref="CreateScenarioRequest"/></param>
        /// <returns><see cref="CreateScenarioResponse"/></returns>
        public Task<CreateScenarioResponse> CreateScenario(CreateScenarioRequest req)
        {
            return InternalRequestAsync<CreateScenarioResponse>(req, "CreateScenario");
        }

        /// <summary>
        /// 创建场景
        /// </summary>
        /// <param name="req"><see cref="CreateScenarioRequest"/></param>
        /// <returns><see cref="CreateScenarioResponse"/></returns>
        public CreateScenarioResponse CreateScenarioSync(CreateScenarioRequest req)
        {
            return InternalRequestAsync<CreateScenarioResponse>(req, "CreateScenario")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除告警通知接收组
        /// </summary>
        /// <param name="req"><see cref="DeleteAlertChannelRequest"/></param>
        /// <returns><see cref="DeleteAlertChannelResponse"/></returns>
        public Task<DeleteAlertChannelResponse> DeleteAlertChannel(DeleteAlertChannelRequest req)
        {
            return InternalRequestAsync<DeleteAlertChannelResponse>(req, "DeleteAlertChannel");
        }

        /// <summary>
        /// 删除告警通知接收组
        /// </summary>
        /// <param name="req"><see cref="DeleteAlertChannelRequest"/></param>
        /// <returns><see cref="DeleteAlertChannelResponse"/></returns>
        public DeleteAlertChannelResponse DeleteAlertChannelSync(DeleteAlertChannelRequest req)
        {
            return InternalRequestAsync<DeleteAlertChannelResponse>(req, "DeleteAlertChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除定时任务
        /// </summary>
        /// <param name="req"><see cref="DeleteCronJobsRequest"/></param>
        /// <returns><see cref="DeleteCronJobsResponse"/></returns>
        public Task<DeleteCronJobsResponse> DeleteCronJobs(DeleteCronJobsRequest req)
        {
            return InternalRequestAsync<DeleteCronJobsResponse>(req, "DeleteCronJobs");
        }

        /// <summary>
        /// 删除定时任务
        /// </summary>
        /// <param name="req"><see cref="DeleteCronJobsRequest"/></param>
        /// <returns><see cref="DeleteCronJobsResponse"/></returns>
        public DeleteCronJobsResponse DeleteCronJobsSync(DeleteCronJobsRequest req)
        {
            return InternalRequestAsync<DeleteCronJobsResponse>(req, "DeleteCronJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除环境
        /// </summary>
        /// <param name="req"><see cref="DeleteEnvironmentsRequest"/></param>
        /// <returns><see cref="DeleteEnvironmentsResponse"/></returns>
        public Task<DeleteEnvironmentsResponse> DeleteEnvironments(DeleteEnvironmentsRequest req)
        {
            return InternalRequestAsync<DeleteEnvironmentsResponse>(req, "DeleteEnvironments");
        }

        /// <summary>
        /// 删除环境
        /// </summary>
        /// <param name="req"><see cref="DeleteEnvironmentsRequest"/></param>
        /// <returns><see cref="DeleteEnvironmentsResponse"/></returns>
        public DeleteEnvironmentsResponse DeleteEnvironmentsSync(DeleteEnvironmentsRequest req)
        {
            return InternalRequestAsync<DeleteEnvironmentsResponse>(req, "DeleteEnvironments")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="req"><see cref="DeleteFilesRequest"/></param>
        /// <returns><see cref="DeleteFilesResponse"/></returns>
        public Task<DeleteFilesResponse> DeleteFiles(DeleteFilesRequest req)
        {
            return InternalRequestAsync<DeleteFilesResponse>(req, "DeleteFiles");
        }

        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="req"><see cref="DeleteFilesRequest"/></param>
        /// <returns><see cref="DeleteFilesResponse"/></returns>
        public DeleteFilesResponse DeleteFilesSync(DeleteFilesRequest req)
        {
            return InternalRequestAsync<DeleteFilesResponse>(req, "DeleteFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除任务
        /// </summary>
        /// <param name="req"><see cref="DeleteJobsRequest"/></param>
        /// <returns><see cref="DeleteJobsResponse"/></returns>
        public Task<DeleteJobsResponse> DeleteJobs(DeleteJobsRequest req)
        {
            return InternalRequestAsync<DeleteJobsResponse>(req, "DeleteJobs");
        }

        /// <summary>
        /// 删除任务
        /// </summary>
        /// <param name="req"><see cref="DeleteJobsRequest"/></param>
        /// <returns><see cref="DeleteJobsResponse"/></returns>
        public DeleteJobsResponse DeleteJobsSync(DeleteJobsRequest req)
        {
            return InternalRequestAsync<DeleteJobsResponse>(req, "DeleteJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除项目
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectsRequest"/></param>
        /// <returns><see cref="DeleteProjectsResponse"/></returns>
        public Task<DeleteProjectsResponse> DeleteProjects(DeleteProjectsRequest req)
        {
            return InternalRequestAsync<DeleteProjectsResponse>(req, "DeleteProjects");
        }

        /// <summary>
        /// 删除项目
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectsRequest"/></param>
        /// <returns><see cref="DeleteProjectsResponse"/></returns>
        public DeleteProjectsResponse DeleteProjectsSync(DeleteProjectsRequest req)
        {
            return InternalRequestAsync<DeleteProjectsResponse>(req, "DeleteProjects")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除场景
        /// </summary>
        /// <param name="req"><see cref="DeleteScenariosRequest"/></param>
        /// <returns><see cref="DeleteScenariosResponse"/></returns>
        public Task<DeleteScenariosResponse> DeleteScenarios(DeleteScenariosRequest req)
        {
            return InternalRequestAsync<DeleteScenariosResponse>(req, "DeleteScenarios");
        }

        /// <summary>
        /// 删除场景
        /// </summary>
        /// <param name="req"><see cref="DeleteScenariosRequest"/></param>
        /// <returns><see cref="DeleteScenariosResponse"/></returns>
        public DeleteScenariosResponse DeleteScenariosSync(DeleteScenariosRequest req)
        {
            return InternalRequestAsync<DeleteScenariosResponse>(req, "DeleteScenarios")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询告警通知接收组
        /// </summary>
        /// <param name="req"><see cref="DescribeAlertChannelsRequest"/></param>
        /// <returns><see cref="DescribeAlertChannelsResponse"/></returns>
        public Task<DescribeAlertChannelsResponse> DescribeAlertChannels(DescribeAlertChannelsRequest req)
        {
            return InternalRequestAsync<DescribeAlertChannelsResponse>(req, "DescribeAlertChannels");
        }

        /// <summary>
        /// 查询告警通知接收组
        /// </summary>
        /// <param name="req"><see cref="DescribeAlertChannelsRequest"/></param>
        /// <returns><see cref="DescribeAlertChannelsResponse"/></returns>
        public DescribeAlertChannelsResponse DescribeAlertChannelsSync(DescribeAlertChannelsRequest req)
        {
            return InternalRequestAsync<DescribeAlertChannelsResponse>(req, "DescribeAlertChannels")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 返回告警历史项的列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAlertRecordsRequest"/></param>
        /// <returns><see cref="DescribeAlertRecordsResponse"/></returns>
        public Task<DescribeAlertRecordsResponse> DescribeAlertRecords(DescribeAlertRecordsRequest req)
        {
            return InternalRequestAsync<DescribeAlertRecordsResponse>(req, "DescribeAlertRecords");
        }

        /// <summary>
        /// 返回告警历史项的列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAlertRecordsRequest"/></param>
        /// <returns><see cref="DescribeAlertRecordsResponse"/></returns>
        public DescribeAlertRecordsResponse DescribeAlertRecordsSync(DescribeAlertRecordsRequest req)
        {
            return InternalRequestAsync<DescribeAlertRecordsResponse>(req, "DescribeAlertRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询系统支持的指标
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableMetricsRequest"/></param>
        /// <returns><see cref="DescribeAvailableMetricsResponse"/></returns>
        public Task<DescribeAvailableMetricsResponse> DescribeAvailableMetrics(DescribeAvailableMetricsRequest req)
        {
            return InternalRequestAsync<DescribeAvailableMetricsResponse>(req, "DescribeAvailableMetrics");
        }

        /// <summary>
        /// 查询系统支持的指标
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableMetricsRequest"/></param>
        /// <returns><see cref="DescribeAvailableMetricsResponse"/></returns>
        public DescribeAvailableMetricsResponse DescribeAvailableMetricsSync(DescribeAvailableMetricsRequest req)
        {
            return InternalRequestAsync<DescribeAvailableMetricsResponse>(req, "DescribeAvailableMetrics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询检查点汇总信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCheckSummaryRequest"/></param>
        /// <returns><see cref="DescribeCheckSummaryResponse"/></returns>
        public Task<DescribeCheckSummaryResponse> DescribeCheckSummary(DescribeCheckSummaryRequest req)
        {
            return InternalRequestAsync<DescribeCheckSummaryResponse>(req, "DescribeCheckSummary");
        }

        /// <summary>
        /// 查询检查点汇总信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCheckSummaryRequest"/></param>
        /// <returns><see cref="DescribeCheckSummaryResponse"/></returns>
        public DescribeCheckSummaryResponse DescribeCheckSummarySync(DescribeCheckSummaryRequest req)
        {
            return InternalRequestAsync<DescribeCheckSummaryResponse>(req, "DescribeCheckSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 列出定时任务，非必填数组为空就默认全选
        /// </summary>
        /// <param name="req"><see cref="DescribeCronJobsRequest"/></param>
        /// <returns><see cref="DescribeCronJobsResponse"/></returns>
        public Task<DescribeCronJobsResponse> DescribeCronJobs(DescribeCronJobsRequest req)
        {
            return InternalRequestAsync<DescribeCronJobsResponse>(req, "DescribeCronJobs");
        }

        /// <summary>
        /// 列出定时任务，非必填数组为空就默认全选
        /// </summary>
        /// <param name="req"><see cref="DescribeCronJobsRequest"/></param>
        /// <returns><see cref="DescribeCronJobsResponse"/></returns>
        public DescribeCronJobsResponse DescribeCronJobsSync(DescribeCronJobsRequest req)
        {
            return InternalRequestAsync<DescribeCronJobsResponse>(req, "DescribeCronJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查看环境列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentsRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentsResponse"/></returns>
        public Task<DescribeEnvironmentsResponse> DescribeEnvironments(DescribeEnvironmentsRequest req)
        {
            return InternalRequestAsync<DescribeEnvironmentsResponse>(req, "DescribeEnvironments");
        }

        /// <summary>
        /// 查看环境列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentsRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentsResponse"/></returns>
        public DescribeEnvironmentsResponse DescribeEnvironmentsSync(DescribeEnvironmentsRequest req)
        {
            return InternalRequestAsync<DescribeEnvironmentsResponse>(req, "DescribeEnvironments")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询错误详情汇总信息
        /// </summary>
        /// <param name="req"><see cref="DescribeErrorSummaryRequest"/></param>
        /// <returns><see cref="DescribeErrorSummaryResponse"/></returns>
        public Task<DescribeErrorSummaryResponse> DescribeErrorSummary(DescribeErrorSummaryRequest req)
        {
            return InternalRequestAsync<DescribeErrorSummaryResponse>(req, "DescribeErrorSummary");
        }

        /// <summary>
        /// 查询错误详情汇总信息
        /// </summary>
        /// <param name="req"><see cref="DescribeErrorSummaryRequest"/></param>
        /// <returns><see cref="DescribeErrorSummaryResponse"/></returns>
        public DescribeErrorSummaryResponse DescribeErrorSummarySync(DescribeErrorSummaryRequest req)
        {
            return InternalRequestAsync<DescribeErrorSummaryResponse>(req, "DescribeErrorSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询文件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFilesRequest"/></param>
        /// <returns><see cref="DescribeFilesResponse"/></returns>
        public Task<DescribeFilesResponse> DescribeFiles(DescribeFilesRequest req)
        {
            return InternalRequestAsync<DescribeFilesResponse>(req, "DescribeFiles");
        }

        /// <summary>
        /// 查询文件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFilesRequest"/></param>
        /// <returns><see cref="DescribeFilesResponse"/></returns>
        public DescribeFilesResponse DescribeFilesSync(DescribeFilesRequest req)
        {
            return InternalRequestAsync<DescribeFilesResponse>(req, "DescribeFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeJobsRequest"/></param>
        /// <returns><see cref="DescribeJobsResponse"/></returns>
        public Task<DescribeJobsResponse> DescribeJobs(DescribeJobsRequest req)
        {
            return InternalRequestAsync<DescribeJobsResponse>(req, "DescribeJobs");
        }

        /// <summary>
        /// 查询任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeJobsRequest"/></param>
        /// <returns><see cref="DescribeJobsResponse"/></returns>
        public DescribeJobsResponse DescribeJobsSync(DescribeJobsRequest req)
        {
            return InternalRequestAsync<DescribeJobsResponse>(req, "DescribeJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询标签内容
        /// </summary>
        /// <param name="req"><see cref="DescribeLabelValuesRequest"/></param>
        /// <returns><see cref="DescribeLabelValuesResponse"/></returns>
        public Task<DescribeLabelValuesResponse> DescribeLabelValues(DescribeLabelValuesRequest req)
        {
            return InternalRequestAsync<DescribeLabelValuesResponse>(req, "DescribeLabelValues");
        }

        /// <summary>
        /// 查询标签内容
        /// </summary>
        /// <param name="req"><see cref="DescribeLabelValuesRequest"/></param>
        /// <returns><see cref="DescribeLabelValuesResponse"/></returns>
        public DescribeLabelValuesResponse DescribeLabelValuesSync(DescribeLabelValuesRequest req)
        {
            return InternalRequestAsync<DescribeLabelValuesResponse>(req, "DescribeLabelValues")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指标所有的label及values值
        /// </summary>
        /// <param name="req"><see cref="DescribeMetricLabelWithValuesRequest"/></param>
        /// <returns><see cref="DescribeMetricLabelWithValuesResponse"/></returns>
        public Task<DescribeMetricLabelWithValuesResponse> DescribeMetricLabelWithValues(DescribeMetricLabelWithValuesRequest req)
        {
            return InternalRequestAsync<DescribeMetricLabelWithValuesResponse>(req, "DescribeMetricLabelWithValues");
        }

        /// <summary>
        /// 查询指标所有的label及values值
        /// </summary>
        /// <param name="req"><see cref="DescribeMetricLabelWithValuesRequest"/></param>
        /// <returns><see cref="DescribeMetricLabelWithValuesResponse"/></returns>
        public DescribeMetricLabelWithValuesResponse DescribeMetricLabelWithValuesSync(DescribeMetricLabelWithValuesRequest req)
        {
            return InternalRequestAsync<DescribeMetricLabelWithValuesResponse>(req, "DescribeMetricLabelWithValues")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 压测过程日志包括引擎输出日志及用户输出日志
        /// </summary>
        /// <param name="req"><see cref="DescribeNormalLogsRequest"/></param>
        /// <returns><see cref="DescribeNormalLogsResponse"/></returns>
        public Task<DescribeNormalLogsResponse> DescribeNormalLogs(DescribeNormalLogsRequest req)
        {
            return InternalRequestAsync<DescribeNormalLogsResponse>(req, "DescribeNormalLogs");
        }

        /// <summary>
        /// 压测过程日志包括引擎输出日志及用户输出日志
        /// </summary>
        /// <param name="req"><see cref="DescribeNormalLogsRequest"/></param>
        /// <returns><see cref="DescribeNormalLogsResponse"/></returns>
        public DescribeNormalLogsResponse DescribeNormalLogsSync(DescribeNormalLogsRequest req)
        {
            return InternalRequestAsync<DescribeNormalLogsResponse>(req, "DescribeNormalLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询项目列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectsRequest"/></param>
        /// <returns><see cref="DescribeProjectsResponse"/></returns>
        public Task<DescribeProjectsResponse> DescribeProjects(DescribeProjectsRequest req)
        {
            return InternalRequestAsync<DescribeProjectsResponse>(req, "DescribeProjects");
        }

        /// <summary>
        /// 查询项目列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectsRequest"/></param>
        /// <returns><see cref="DescribeProjectsResponse"/></returns>
        public DescribeProjectsResponse DescribeProjectsSync(DescribeProjectsRequest req)
        {
            return InternalRequestAsync<DescribeProjectsResponse>(req, "DescribeProjects")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询地域列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public Task<DescribeRegionsResponse> DescribeRegions(DescribeRegionsRequest req)
        {
            return InternalRequestAsync<DescribeRegionsResponse>(req, "DescribeRegions");
        }

        /// <summary>
        /// 查询地域列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public DescribeRegionsResponse DescribeRegionsSync(DescribeRegionsRequest req)
        {
            return InternalRequestAsync<DescribeRegionsResponse>(req, "DescribeRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询请求汇总信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRequestSummaryRequest"/></param>
        /// <returns><see cref="DescribeRequestSummaryResponse"/></returns>
        public Task<DescribeRequestSummaryResponse> DescribeRequestSummary(DescribeRequestSummaryRequest req)
        {
            return InternalRequestAsync<DescribeRequestSummaryResponse>(req, "DescribeRequestSummary");
        }

        /// <summary>
        /// 查询请求汇总信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRequestSummaryRequest"/></param>
        /// <returns><see cref="DescribeRequestSummaryResponse"/></returns>
        public DescribeRequestSummaryResponse DescribeRequestSummarySync(DescribeRequestSummaryRequest req)
        {
            return InternalRequestAsync<DescribeRequestSummaryResponse>(req, "DescribeRequestSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量查询指标，返回固定时间点指标内容
        /// </summary>
        /// <param name="req"><see cref="DescribeSampleBatchQueryRequest"/></param>
        /// <returns><see cref="DescribeSampleBatchQueryResponse"/></returns>
        public Task<DescribeSampleBatchQueryResponse> DescribeSampleBatchQuery(DescribeSampleBatchQueryRequest req)
        {
            return InternalRequestAsync<DescribeSampleBatchQueryResponse>(req, "DescribeSampleBatchQuery");
        }

        /// <summary>
        /// 批量查询指标，返回固定时间点指标内容
        /// </summary>
        /// <param name="req"><see cref="DescribeSampleBatchQueryRequest"/></param>
        /// <returns><see cref="DescribeSampleBatchQueryResponse"/></returns>
        public DescribeSampleBatchQueryResponse DescribeSampleBatchQuerySync(DescribeSampleBatchQueryRequest req)
        {
            return InternalRequestAsync<DescribeSampleBatchQueryResponse>(req, "DescribeSampleBatchQuery")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询采样日志
        /// </summary>
        /// <param name="req"><see cref="DescribeSampleLogsRequest"/></param>
        /// <returns><see cref="DescribeSampleLogsResponse"/></returns>
        public Task<DescribeSampleLogsResponse> DescribeSampleLogs(DescribeSampleLogsRequest req)
        {
            return InternalRequestAsync<DescribeSampleLogsResponse>(req, "DescribeSampleLogs");
        }

        /// <summary>
        /// 查询采样日志
        /// </summary>
        /// <param name="req"><see cref="DescribeSampleLogsRequest"/></param>
        /// <returns><see cref="DescribeSampleLogsResponse"/></returns>
        public DescribeSampleLogsResponse DescribeSampleLogsSync(DescribeSampleLogsRequest req)
        {
            return InternalRequestAsync<DescribeSampleLogsResponse>(req, "DescribeSampleLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量查询指标矩阵
        /// </summary>
        /// <param name="req"><see cref="DescribeSampleMatrixBatchQueryRequest"/></param>
        /// <returns><see cref="DescribeSampleMatrixBatchQueryResponse"/></returns>
        public Task<DescribeSampleMatrixBatchQueryResponse> DescribeSampleMatrixBatchQuery(DescribeSampleMatrixBatchQueryRequest req)
        {
            return InternalRequestAsync<DescribeSampleMatrixBatchQueryResponse>(req, "DescribeSampleMatrixBatchQuery");
        }

        /// <summary>
        /// 批量查询指标矩阵
        /// </summary>
        /// <param name="req"><see cref="DescribeSampleMatrixBatchQueryRequest"/></param>
        /// <returns><see cref="DescribeSampleMatrixBatchQueryResponse"/></returns>
        public DescribeSampleMatrixBatchQueryResponse DescribeSampleMatrixBatchQuerySync(DescribeSampleMatrixBatchQueryRequest req)
        {
            return InternalRequestAsync<DescribeSampleMatrixBatchQueryResponse>(req, "DescribeSampleMatrixBatchQuery")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指标矩阵
        /// </summary>
        /// <param name="req"><see cref="DescribeSampleMatrixQueryRequest"/></param>
        /// <returns><see cref="DescribeSampleMatrixQueryResponse"/></returns>
        public Task<DescribeSampleMatrixQueryResponse> DescribeSampleMatrixQuery(DescribeSampleMatrixQueryRequest req)
        {
            return InternalRequestAsync<DescribeSampleMatrixQueryResponse>(req, "DescribeSampleMatrixQuery");
        }

        /// <summary>
        /// 查询指标矩阵
        /// </summary>
        /// <param name="req"><see cref="DescribeSampleMatrixQueryRequest"/></param>
        /// <returns><see cref="DescribeSampleMatrixQueryResponse"/></returns>
        public DescribeSampleMatrixQueryResponse DescribeSampleMatrixQuerySync(DescribeSampleMatrixQueryRequest req)
        {
            return InternalRequestAsync<DescribeSampleMatrixQueryResponse>(req, "DescribeSampleMatrixQuery")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询指标，返回固定时间点指标内容
        /// </summary>
        /// <param name="req"><see cref="DescribeSampleQueryRequest"/></param>
        /// <returns><see cref="DescribeSampleQueryResponse"/></returns>
        public Task<DescribeSampleQueryResponse> DescribeSampleQuery(DescribeSampleQueryRequest req)
        {
            return InternalRequestAsync<DescribeSampleQueryResponse>(req, "DescribeSampleQuery");
        }

        /// <summary>
        /// 查询指标，返回固定时间点指标内容
        /// </summary>
        /// <param name="req"><see cref="DescribeSampleQueryRequest"/></param>
        /// <returns><see cref="DescribeSampleQueryResponse"/></returns>
        public DescribeSampleQueryResponse DescribeSampleQuerySync(DescribeSampleQueryRequest req)
        {
            return InternalRequestAsync<DescribeSampleQueryResponse>(req, "DescribeSampleQuery")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询场景配置并附带已经执行的任务内容
        /// </summary>
        /// <param name="req"><see cref="DescribeScenarioWithJobsRequest"/></param>
        /// <returns><see cref="DescribeScenarioWithJobsResponse"/></returns>
        public Task<DescribeScenarioWithJobsResponse> DescribeScenarioWithJobs(DescribeScenarioWithJobsRequest req)
        {
            return InternalRequestAsync<DescribeScenarioWithJobsResponse>(req, "DescribeScenarioWithJobs");
        }

        /// <summary>
        /// 查询场景配置并附带已经执行的任务内容
        /// </summary>
        /// <param name="req"><see cref="DescribeScenarioWithJobsRequest"/></param>
        /// <returns><see cref="DescribeScenarioWithJobsResponse"/></returns>
        public DescribeScenarioWithJobsResponse DescribeScenarioWithJobsSync(DescribeScenarioWithJobsRequest req)
        {
            return InternalRequestAsync<DescribeScenarioWithJobsResponse>(req, "DescribeScenarioWithJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询场景列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScenariosRequest"/></param>
        /// <returns><see cref="DescribeScenariosResponse"/></returns>
        public Task<DescribeScenariosResponse> DescribeScenarios(DescribeScenariosRequest req)
        {
            return InternalRequestAsync<DescribeScenariosResponse>(req, "DescribeScenarios");
        }

        /// <summary>
        /// 查询场景列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScenariosRequest"/></param>
        /// <returns><see cref="DescribeScenariosResponse"/></returns>
        public DescribeScenariosResponse DescribeScenariosSync(DescribeScenariosRequest req)
        {
            return InternalRequestAsync<DescribeScenariosResponse>(req, "DescribeScenarios")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 生成临时COS凭证
        /// </summary>
        /// <param name="req"><see cref="GenerateTmpKeyRequest"/></param>
        /// <returns><see cref="GenerateTmpKeyResponse"/></returns>
        public Task<GenerateTmpKeyResponse> GenerateTmpKey(GenerateTmpKeyRequest req)
        {
            return InternalRequestAsync<GenerateTmpKeyResponse>(req, "GenerateTmpKey");
        }

        /// <summary>
        /// 生成临时COS凭证
        /// </summary>
        /// <param name="req"><see cref="GenerateTmpKeyRequest"/></param>
        /// <returns><see cref="GenerateTmpKeyResponse"/></returns>
        public GenerateTmpKeyResponse GenerateTmpKeySync(GenerateTmpKeyRequest req)
        {
            return InternalRequestAsync<GenerateTmpKeyResponse>(req, "GenerateTmpKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 重启状态为已中止的定时任务
        /// </summary>
        /// <param name="req"><see cref="RestartCronJobsRequest"/></param>
        /// <returns><see cref="RestartCronJobsResponse"/></returns>
        public Task<RestartCronJobsResponse> RestartCronJobs(RestartCronJobsRequest req)
        {
            return InternalRequestAsync<RestartCronJobsResponse>(req, "RestartCronJobs");
        }

        /// <summary>
        /// 重启状态为已中止的定时任务
        /// </summary>
        /// <param name="req"><see cref="RestartCronJobsRequest"/></param>
        /// <returns><see cref="RestartCronJobsResponse"/></returns>
        public RestartCronJobsResponse RestartCronJobsSync(RestartCronJobsRequest req)
        {
            return InternalRequestAsync<RestartCronJobsResponse>(req, "RestartCronJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建并启动任务
        /// </summary>
        /// <param name="req"><see cref="StartJobRequest"/></param>
        /// <returns><see cref="StartJobResponse"/></returns>
        public Task<StartJobResponse> StartJob(StartJobRequest req)
        {
            return InternalRequestAsync<StartJobResponse>(req, "StartJob");
        }

        /// <summary>
        /// 创建并启动任务
        /// </summary>
        /// <param name="req"><see cref="StartJobRequest"/></param>
        /// <returns><see cref="StartJobResponse"/></returns>
        public StartJobResponse StartJobSync(StartJobRequest req)
        {
            return InternalRequestAsync<StartJobResponse>(req, "StartJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新定时任务
        /// </summary>
        /// <param name="req"><see cref="UpdateCronJobRequest"/></param>
        /// <returns><see cref="UpdateCronJobResponse"/></returns>
        public Task<UpdateCronJobResponse> UpdateCronJob(UpdateCronJobRequest req)
        {
            return InternalRequestAsync<UpdateCronJobResponse>(req, "UpdateCronJob");
        }

        /// <summary>
        /// 更新定时任务
        /// </summary>
        /// <param name="req"><see cref="UpdateCronJobRequest"/></param>
        /// <returns><see cref="UpdateCronJobResponse"/></returns>
        public UpdateCronJobResponse UpdateCronJobSync(UpdateCronJobRequest req)
        {
            return InternalRequestAsync<UpdateCronJobResponse>(req, "UpdateCronJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新环境
        /// </summary>
        /// <param name="req"><see cref="UpdateEnvironmentRequest"/></param>
        /// <returns><see cref="UpdateEnvironmentResponse"/></returns>
        public Task<UpdateEnvironmentResponse> UpdateEnvironment(UpdateEnvironmentRequest req)
        {
            return InternalRequestAsync<UpdateEnvironmentResponse>(req, "UpdateEnvironment");
        }

        /// <summary>
        /// 更新环境
        /// </summary>
        /// <param name="req"><see cref="UpdateEnvironmentRequest"/></param>
        /// <returns><see cref="UpdateEnvironmentResponse"/></returns>
        public UpdateEnvironmentResponse UpdateEnvironmentSync(UpdateEnvironmentRequest req)
        {
            return InternalRequestAsync<UpdateEnvironmentResponse>(req, "UpdateEnvironment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新关联文件场景
        /// </summary>
        /// <param name="req"><see cref="UpdateFileScenarioRelationRequest"/></param>
        /// <returns><see cref="UpdateFileScenarioRelationResponse"/></returns>
        public Task<UpdateFileScenarioRelationResponse> UpdateFileScenarioRelation(UpdateFileScenarioRelationRequest req)
        {
            return InternalRequestAsync<UpdateFileScenarioRelationResponse>(req, "UpdateFileScenarioRelation");
        }

        /// <summary>
        /// 更新关联文件场景
        /// </summary>
        /// <param name="req"><see cref="UpdateFileScenarioRelationRequest"/></param>
        /// <returns><see cref="UpdateFileScenarioRelationResponse"/></returns>
        public UpdateFileScenarioRelationResponse UpdateFileScenarioRelationSync(UpdateFileScenarioRelationRequest req)
        {
            return InternalRequestAsync<UpdateFileScenarioRelationResponse>(req, "UpdateFileScenarioRelation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新任务
        /// </summary>
        /// <param name="req"><see cref="UpdateJobRequest"/></param>
        /// <returns><see cref="UpdateJobResponse"/></returns>
        public Task<UpdateJobResponse> UpdateJob(UpdateJobRequest req)
        {
            return InternalRequestAsync<UpdateJobResponse>(req, "UpdateJob");
        }

        /// <summary>
        /// 更新任务
        /// </summary>
        /// <param name="req"><see cref="UpdateJobRequest"/></param>
        /// <returns><see cref="UpdateJobResponse"/></returns>
        public UpdateJobResponse UpdateJobSync(UpdateJobRequest req)
        {
            return InternalRequestAsync<UpdateJobResponse>(req, "UpdateJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新项目
        /// </summary>
        /// <param name="req"><see cref="UpdateProjectRequest"/></param>
        /// <returns><see cref="UpdateProjectResponse"/></returns>
        public Task<UpdateProjectResponse> UpdateProject(UpdateProjectRequest req)
        {
            return InternalRequestAsync<UpdateProjectResponse>(req, "UpdateProject");
        }

        /// <summary>
        /// 更新项目
        /// </summary>
        /// <param name="req"><see cref="UpdateProjectRequest"/></param>
        /// <returns><see cref="UpdateProjectResponse"/></returns>
        public UpdateProjectResponse UpdateProjectSync(UpdateProjectRequest req)
        {
            return InternalRequestAsync<UpdateProjectResponse>(req, "UpdateProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新场景
        /// </summary>
        /// <param name="req"><see cref="UpdateScenarioRequest"/></param>
        /// <returns><see cref="UpdateScenarioResponse"/></returns>
        public Task<UpdateScenarioResponse> UpdateScenario(UpdateScenarioRequest req)
        {
            return InternalRequestAsync<UpdateScenarioResponse>(req, "UpdateScenario");
        }

        /// <summary>
        /// 更新场景
        /// </summary>
        /// <param name="req"><see cref="UpdateScenarioRequest"/></param>
        /// <returns><see cref="UpdateScenarioResponse"/></returns>
        public UpdateScenarioResponse UpdateScenarioSync(UpdateScenarioRequest req)
        {
            return InternalRequestAsync<UpdateScenarioResponse>(req, "UpdateScenario")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}

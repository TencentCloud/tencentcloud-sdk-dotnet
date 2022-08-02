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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public PtsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// 停止定时任务
        /// </summary>
        /// <param name="req"><see cref="AbortCronJobsRequest"/></param>
        /// <returns><see cref="AbortCronJobsResponse"/></returns>
        public async Task<AbortCronJobsResponse> AbortCronJobs(AbortCronJobsRequest req)
        {
             JsonResponseModel<AbortCronJobsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AbortCronJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AbortCronJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止定时任务
        /// </summary>
        /// <param name="req"><see cref="AbortCronJobsRequest"/></param>
        /// <returns><see cref="AbortCronJobsResponse"/></returns>
        public AbortCronJobsResponse AbortCronJobsSync(AbortCronJobsRequest req)
        {
             JsonResponseModel<AbortCronJobsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AbortCronJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AbortCronJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止任务
        /// </summary>
        /// <param name="req"><see cref="AbortJobRequest"/></param>
        /// <returns><see cref="AbortJobResponse"/></returns>
        public async Task<AbortJobResponse> AbortJob(AbortJobRequest req)
        {
             JsonResponseModel<AbortJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AbortJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AbortJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 停止任务
        /// </summary>
        /// <param name="req"><see cref="AbortJobRequest"/></param>
        /// <returns><see cref="AbortJobResponse"/></returns>
        public AbortJobResponse AbortJobSync(AbortJobRequest req)
        {
             JsonResponseModel<AbortJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AbortJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AbortJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 调整任务的目标RPS
        /// </summary>
        /// <param name="req"><see cref="AdjustJobSpeedRequest"/></param>
        /// <returns><see cref="AdjustJobSpeedResponse"/></returns>
        public async Task<AdjustJobSpeedResponse> AdjustJobSpeed(AdjustJobSpeedRequest req)
        {
             JsonResponseModel<AdjustJobSpeedResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AdjustJobSpeed");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AdjustJobSpeedResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 调整任务的目标RPS
        /// </summary>
        /// <param name="req"><see cref="AdjustJobSpeedRequest"/></param>
        /// <returns><see cref="AdjustJobSpeedResponse"/></returns>
        public AdjustJobSpeedResponse AdjustJobSpeedSync(AdjustJobSpeedRequest req)
        {
             JsonResponseModel<AdjustJobSpeedResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AdjustJobSpeed");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AdjustJobSpeedResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 复制场景
        /// </summary>
        /// <param name="req"><see cref="CopyScenarioRequest"/></param>
        /// <returns><see cref="CopyScenarioResponse"/></returns>
        public async Task<CopyScenarioResponse> CopyScenario(CopyScenarioRequest req)
        {
             JsonResponseModel<CopyScenarioResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CopyScenario");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CopyScenarioResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 复制场景
        /// </summary>
        /// <param name="req"><see cref="CopyScenarioRequest"/></param>
        /// <returns><see cref="CopyScenarioResponse"/></returns>
        public CopyScenarioResponse CopyScenarioSync(CopyScenarioRequest req)
        {
             JsonResponseModel<CopyScenarioResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CopyScenario");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CopyScenarioResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建告警通知接收组
        /// </summary>
        /// <param name="req"><see cref="CreateAlertChannelRequest"/></param>
        /// <returns><see cref="CreateAlertChannelResponse"/></returns>
        public async Task<CreateAlertChannelResponse> CreateAlertChannel(CreateAlertChannelRequest req)
        {
             JsonResponseModel<CreateAlertChannelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAlertChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAlertChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建告警通知接收组
        /// </summary>
        /// <param name="req"><see cref="CreateAlertChannelRequest"/></param>
        /// <returns><see cref="CreateAlertChannelResponse"/></returns>
        public CreateAlertChannelResponse CreateAlertChannelSync(CreateAlertChannelRequest req)
        {
             JsonResponseModel<CreateAlertChannelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAlertChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAlertChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建定时任务
        /// </summary>
        /// <param name="req"><see cref="CreateCronJobRequest"/></param>
        /// <returns><see cref="CreateCronJobResponse"/></returns>
        public async Task<CreateCronJobResponse> CreateCronJob(CreateCronJobRequest req)
        {
             JsonResponseModel<CreateCronJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCronJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCronJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建定时任务
        /// </summary>
        /// <param name="req"><see cref="CreateCronJobRequest"/></param>
        /// <returns><see cref="CreateCronJobResponse"/></returns>
        public CreateCronJobResponse CreateCronJobSync(CreateCronJobRequest req)
        {
             JsonResponseModel<CreateCronJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCronJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCronJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建文件
        /// </summary>
        /// <param name="req"><see cref="CreateFileRequest"/></param>
        /// <returns><see cref="CreateFileResponse"/></returns>
        public async Task<CreateFileResponse> CreateFile(CreateFileRequest req)
        {
             JsonResponseModel<CreateFileResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateFile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建文件
        /// </summary>
        /// <param name="req"><see cref="CreateFileRequest"/></param>
        /// <returns><see cref="CreateFileResponse"/></returns>
        public CreateFileResponse CreateFileSync(CreateFileRequest req)
        {
             JsonResponseModel<CreateFileResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateFile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建项目
        /// </summary>
        /// <param name="req"><see cref="CreateProjectRequest"/></param>
        /// <returns><see cref="CreateProjectResponse"/></returns>
        public async Task<CreateProjectResponse> CreateProject(CreateProjectRequest req)
        {
             JsonResponseModel<CreateProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建项目
        /// </summary>
        /// <param name="req"><see cref="CreateProjectRequest"/></param>
        /// <returns><see cref="CreateProjectResponse"/></returns>
        public CreateProjectResponse CreateProjectSync(CreateProjectRequest req)
        {
             JsonResponseModel<CreateProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建场景
        /// </summary>
        /// <param name="req"><see cref="CreateScenarioRequest"/></param>
        /// <returns><see cref="CreateScenarioResponse"/></returns>
        public async Task<CreateScenarioResponse> CreateScenario(CreateScenarioRequest req)
        {
             JsonResponseModel<CreateScenarioResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateScenario");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateScenarioResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建场景
        /// </summary>
        /// <param name="req"><see cref="CreateScenarioRequest"/></param>
        /// <returns><see cref="CreateScenarioResponse"/></returns>
        public CreateScenarioResponse CreateScenarioSync(CreateScenarioRequest req)
        {
             JsonResponseModel<CreateScenarioResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateScenario");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateScenarioResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除告警通知接收组
        /// </summary>
        /// <param name="req"><see cref="DeleteAlertChannelRequest"/></param>
        /// <returns><see cref="DeleteAlertChannelResponse"/></returns>
        public async Task<DeleteAlertChannelResponse> DeleteAlertChannel(DeleteAlertChannelRequest req)
        {
             JsonResponseModel<DeleteAlertChannelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAlertChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAlertChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除告警通知接收组
        /// </summary>
        /// <param name="req"><see cref="DeleteAlertChannelRequest"/></param>
        /// <returns><see cref="DeleteAlertChannelResponse"/></returns>
        public DeleteAlertChannelResponse DeleteAlertChannelSync(DeleteAlertChannelRequest req)
        {
             JsonResponseModel<DeleteAlertChannelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAlertChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAlertChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除定时任务
        /// </summary>
        /// <param name="req"><see cref="DeleteCronJobsRequest"/></param>
        /// <returns><see cref="DeleteCronJobsResponse"/></returns>
        public async Task<DeleteCronJobsResponse> DeleteCronJobs(DeleteCronJobsRequest req)
        {
             JsonResponseModel<DeleteCronJobsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteCronJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCronJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除定时任务
        /// </summary>
        /// <param name="req"><see cref="DeleteCronJobsRequest"/></param>
        /// <returns><see cref="DeleteCronJobsResponse"/></returns>
        public DeleteCronJobsResponse DeleteCronJobsSync(DeleteCronJobsRequest req)
        {
             JsonResponseModel<DeleteCronJobsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteCronJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteCronJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="req"><see cref="DeleteFilesRequest"/></param>
        /// <returns><see cref="DeleteFilesResponse"/></returns>
        public async Task<DeleteFilesResponse> DeleteFiles(DeleteFilesRequest req)
        {
             JsonResponseModel<DeleteFilesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="req"><see cref="DeleteFilesRequest"/></param>
        /// <returns><see cref="DeleteFilesResponse"/></returns>
        public DeleteFilesResponse DeleteFilesSync(DeleteFilesRequest req)
        {
             JsonResponseModel<DeleteFilesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除任务
        /// </summary>
        /// <param name="req"><see cref="DeleteJobsRequest"/></param>
        /// <returns><see cref="DeleteJobsResponse"/></returns>
        public async Task<DeleteJobsResponse> DeleteJobs(DeleteJobsRequest req)
        {
             JsonResponseModel<DeleteJobsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除任务
        /// </summary>
        /// <param name="req"><see cref="DeleteJobsRequest"/></param>
        /// <returns><see cref="DeleteJobsResponse"/></returns>
        public DeleteJobsResponse DeleteJobsSync(DeleteJobsRequest req)
        {
             JsonResponseModel<DeleteJobsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除项目
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectsRequest"/></param>
        /// <returns><see cref="DeleteProjectsResponse"/></returns>
        public async Task<DeleteProjectsResponse> DeleteProjects(DeleteProjectsRequest req)
        {
             JsonResponseModel<DeleteProjectsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteProjects");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteProjectsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除项目
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectsRequest"/></param>
        /// <returns><see cref="DeleteProjectsResponse"/></returns>
        public DeleteProjectsResponse DeleteProjectsSync(DeleteProjectsRequest req)
        {
             JsonResponseModel<DeleteProjectsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteProjects");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteProjectsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除场景
        /// </summary>
        /// <param name="req"><see cref="DeleteScenariosRequest"/></param>
        /// <returns><see cref="DeleteScenariosResponse"/></returns>
        public async Task<DeleteScenariosResponse> DeleteScenarios(DeleteScenariosRequest req)
        {
             JsonResponseModel<DeleteScenariosResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteScenarios");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteScenariosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除场景
        /// </summary>
        /// <param name="req"><see cref="DeleteScenariosRequest"/></param>
        /// <returns><see cref="DeleteScenariosResponse"/></returns>
        public DeleteScenariosResponse DeleteScenariosSync(DeleteScenariosRequest req)
        {
             JsonResponseModel<DeleteScenariosResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteScenarios");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteScenariosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询告警通知接收组
        /// </summary>
        /// <param name="req"><see cref="DescribeAlertChannelsRequest"/></param>
        /// <returns><see cref="DescribeAlertChannelsResponse"/></returns>
        public async Task<DescribeAlertChannelsResponse> DescribeAlertChannels(DescribeAlertChannelsRequest req)
        {
             JsonResponseModel<DescribeAlertChannelsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAlertChannels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlertChannelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询告警通知接收组
        /// </summary>
        /// <param name="req"><see cref="DescribeAlertChannelsRequest"/></param>
        /// <returns><see cref="DescribeAlertChannelsResponse"/></returns>
        public DescribeAlertChannelsResponse DescribeAlertChannelsSync(DescribeAlertChannelsRequest req)
        {
             JsonResponseModel<DescribeAlertChannelsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAlertChannels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlertChannelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 返回告警历史项的列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAlertRecordsRequest"/></param>
        /// <returns><see cref="DescribeAlertRecordsResponse"/></returns>
        public async Task<DescribeAlertRecordsResponse> DescribeAlertRecords(DescribeAlertRecordsRequest req)
        {
             JsonResponseModel<DescribeAlertRecordsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAlertRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlertRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 返回告警历史项的列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAlertRecordsRequest"/></param>
        /// <returns><see cref="DescribeAlertRecordsResponse"/></returns>
        public DescribeAlertRecordsResponse DescribeAlertRecordsSync(DescribeAlertRecordsRequest req)
        {
             JsonResponseModel<DescribeAlertRecordsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAlertRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlertRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询系统支持的指标
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableMetricsRequest"/></param>
        /// <returns><see cref="DescribeAvailableMetricsResponse"/></returns>
        public async Task<DescribeAvailableMetricsResponse> DescribeAvailableMetrics(DescribeAvailableMetricsRequest req)
        {
             JsonResponseModel<DescribeAvailableMetricsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAvailableMetrics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAvailableMetricsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询系统支持的指标
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableMetricsRequest"/></param>
        /// <returns><see cref="DescribeAvailableMetricsResponse"/></returns>
        public DescribeAvailableMetricsResponse DescribeAvailableMetricsSync(DescribeAvailableMetricsRequest req)
        {
             JsonResponseModel<DescribeAvailableMetricsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAvailableMetrics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAvailableMetricsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询检查点汇总信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCheckSummaryRequest"/></param>
        /// <returns><see cref="DescribeCheckSummaryResponse"/></returns>
        public async Task<DescribeCheckSummaryResponse> DescribeCheckSummary(DescribeCheckSummaryRequest req)
        {
             JsonResponseModel<DescribeCheckSummaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCheckSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCheckSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询检查点汇总信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCheckSummaryRequest"/></param>
        /// <returns><see cref="DescribeCheckSummaryResponse"/></returns>
        public DescribeCheckSummaryResponse DescribeCheckSummarySync(DescribeCheckSummaryRequest req)
        {
             JsonResponseModel<DescribeCheckSummaryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCheckSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCheckSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 列出定时任务，非必填数组为空就默认全选
        /// </summary>
        /// <param name="req"><see cref="DescribeCronJobsRequest"/></param>
        /// <returns><see cref="DescribeCronJobsResponse"/></returns>
        public async Task<DescribeCronJobsResponse> DescribeCronJobs(DescribeCronJobsRequest req)
        {
             JsonResponseModel<DescribeCronJobsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCronJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCronJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 列出定时任务，非必填数组为空就默认全选
        /// </summary>
        /// <param name="req"><see cref="DescribeCronJobsRequest"/></param>
        /// <returns><see cref="DescribeCronJobsResponse"/></returns>
        public DescribeCronJobsResponse DescribeCronJobsSync(DescribeCronJobsRequest req)
        {
             JsonResponseModel<DescribeCronJobsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCronJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCronJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询文件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFilesRequest"/></param>
        /// <returns><see cref="DescribeFilesResponse"/></returns>
        public async Task<DescribeFilesResponse> DescribeFiles(DescribeFilesRequest req)
        {
             JsonResponseModel<DescribeFilesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询文件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeFilesRequest"/></param>
        /// <returns><see cref="DescribeFilesResponse"/></returns>
        public DescribeFilesResponse DescribeFilesSync(DescribeFilesRequest req)
        {
             JsonResponseModel<DescribeFilesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeJobsRequest"/></param>
        /// <returns><see cref="DescribeJobsResponse"/></returns>
        public async Task<DescribeJobsResponse> DescribeJobs(DescribeJobsRequest req)
        {
             JsonResponseModel<DescribeJobsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询任务列表
        /// </summary>
        /// <param name="req"><see cref="DescribeJobsRequest"/></param>
        /// <returns><see cref="DescribeJobsResponse"/></returns>
        public DescribeJobsResponse DescribeJobsSync(DescribeJobsRequest req)
        {
             JsonResponseModel<DescribeJobsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询标签内容
        /// </summary>
        /// <param name="req"><see cref="DescribeLabelValuesRequest"/></param>
        /// <returns><see cref="DescribeLabelValuesResponse"/></returns>
        public async Task<DescribeLabelValuesResponse> DescribeLabelValues(DescribeLabelValuesRequest req)
        {
             JsonResponseModel<DescribeLabelValuesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLabelValues");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLabelValuesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询标签内容
        /// </summary>
        /// <param name="req"><see cref="DescribeLabelValuesRequest"/></param>
        /// <returns><see cref="DescribeLabelValuesResponse"/></returns>
        public DescribeLabelValuesResponse DescribeLabelValuesSync(DescribeLabelValuesRequest req)
        {
             JsonResponseModel<DescribeLabelValuesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLabelValues");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLabelValuesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指标所有的label及values值
        /// </summary>
        /// <param name="req"><see cref="DescribeMetricLabelWithValuesRequest"/></param>
        /// <returns><see cref="DescribeMetricLabelWithValuesResponse"/></returns>
        public async Task<DescribeMetricLabelWithValuesResponse> DescribeMetricLabelWithValues(DescribeMetricLabelWithValuesRequest req)
        {
             JsonResponseModel<DescribeMetricLabelWithValuesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMetricLabelWithValues");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMetricLabelWithValuesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指标所有的label及values值
        /// </summary>
        /// <param name="req"><see cref="DescribeMetricLabelWithValuesRequest"/></param>
        /// <returns><see cref="DescribeMetricLabelWithValuesResponse"/></returns>
        public DescribeMetricLabelWithValuesResponse DescribeMetricLabelWithValuesSync(DescribeMetricLabelWithValuesRequest req)
        {
             JsonResponseModel<DescribeMetricLabelWithValuesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMetricLabelWithValues");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMetricLabelWithValuesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 压测过程日志日志包括引擎输出日志及用户输出日志
        /// </summary>
        /// <param name="req"><see cref="DescribeNormalLogsRequest"/></param>
        /// <returns><see cref="DescribeNormalLogsResponse"/></returns>
        public async Task<DescribeNormalLogsResponse> DescribeNormalLogs(DescribeNormalLogsRequest req)
        {
             JsonResponseModel<DescribeNormalLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNormalLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNormalLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 压测过程日志日志包括引擎输出日志及用户输出日志
        /// </summary>
        /// <param name="req"><see cref="DescribeNormalLogsRequest"/></param>
        /// <returns><see cref="DescribeNormalLogsResponse"/></returns>
        public DescribeNormalLogsResponse DescribeNormalLogsSync(DescribeNormalLogsRequest req)
        {
             JsonResponseModel<DescribeNormalLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNormalLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNormalLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询项目列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectsRequest"/></param>
        /// <returns><see cref="DescribeProjectsResponse"/></returns>
        public async Task<DescribeProjectsResponse> DescribeProjects(DescribeProjectsRequest req)
        {
             JsonResponseModel<DescribeProjectsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProjects");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询项目列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectsRequest"/></param>
        /// <returns><see cref="DescribeProjectsResponse"/></returns>
        public DescribeProjectsResponse DescribeProjectsSync(DescribeProjectsRequest req)
        {
             JsonResponseModel<DescribeProjectsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProjects");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProjectsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询地域列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public async Task<DescribeRegionsResponse> DescribeRegions(DescribeRegionsRequest req)
        {
             JsonResponseModel<DescribeRegionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询地域列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public DescribeRegionsResponse DescribeRegionsSync(DescribeRegionsRequest req)
        {
             JsonResponseModel<DescribeRegionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询请求汇总信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRequestSummaryRequest"/></param>
        /// <returns><see cref="DescribeRequestSummaryResponse"/></returns>
        public async Task<DescribeRequestSummaryResponse> DescribeRequestSummary(DescribeRequestSummaryRequest req)
        {
             JsonResponseModel<DescribeRequestSummaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRequestSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRequestSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询请求汇总信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRequestSummaryRequest"/></param>
        /// <returns><see cref="DescribeRequestSummaryResponse"/></returns>
        public DescribeRequestSummaryResponse DescribeRequestSummarySync(DescribeRequestSummaryRequest req)
        {
             JsonResponseModel<DescribeRequestSummaryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRequestSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRequestSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量查询指标，返回固定时间点指标内容
        /// </summary>
        /// <param name="req"><see cref="DescribeSampleBatchQueryRequest"/></param>
        /// <returns><see cref="DescribeSampleBatchQueryResponse"/></returns>
        public async Task<DescribeSampleBatchQueryResponse> DescribeSampleBatchQuery(DescribeSampleBatchQueryRequest req)
        {
             JsonResponseModel<DescribeSampleBatchQueryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSampleBatchQuery");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSampleBatchQueryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量查询指标，返回固定时间点指标内容
        /// </summary>
        /// <param name="req"><see cref="DescribeSampleBatchQueryRequest"/></param>
        /// <returns><see cref="DescribeSampleBatchQueryResponse"/></returns>
        public DescribeSampleBatchQueryResponse DescribeSampleBatchQuerySync(DescribeSampleBatchQueryRequest req)
        {
             JsonResponseModel<DescribeSampleBatchQueryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSampleBatchQuery");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSampleBatchQueryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询采样日志
        /// </summary>
        /// <param name="req"><see cref="DescribeSampleLogsRequest"/></param>
        /// <returns><see cref="DescribeSampleLogsResponse"/></returns>
        public async Task<DescribeSampleLogsResponse> DescribeSampleLogs(DescribeSampleLogsRequest req)
        {
             JsonResponseModel<DescribeSampleLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSampleLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSampleLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询采样日志
        /// </summary>
        /// <param name="req"><see cref="DescribeSampleLogsRequest"/></param>
        /// <returns><see cref="DescribeSampleLogsResponse"/></returns>
        public DescribeSampleLogsResponse DescribeSampleLogsSync(DescribeSampleLogsRequest req)
        {
             JsonResponseModel<DescribeSampleLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSampleLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSampleLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量查询指标矩阵
        /// </summary>
        /// <param name="req"><see cref="DescribeSampleMatrixBatchQueryRequest"/></param>
        /// <returns><see cref="DescribeSampleMatrixBatchQueryResponse"/></returns>
        public async Task<DescribeSampleMatrixBatchQueryResponse> DescribeSampleMatrixBatchQuery(DescribeSampleMatrixBatchQueryRequest req)
        {
             JsonResponseModel<DescribeSampleMatrixBatchQueryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSampleMatrixBatchQuery");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSampleMatrixBatchQueryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量查询指标矩阵
        /// </summary>
        /// <param name="req"><see cref="DescribeSampleMatrixBatchQueryRequest"/></param>
        /// <returns><see cref="DescribeSampleMatrixBatchQueryResponse"/></returns>
        public DescribeSampleMatrixBatchQueryResponse DescribeSampleMatrixBatchQuerySync(DescribeSampleMatrixBatchQueryRequest req)
        {
             JsonResponseModel<DescribeSampleMatrixBatchQueryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSampleMatrixBatchQuery");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSampleMatrixBatchQueryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指标矩阵
        /// </summary>
        /// <param name="req"><see cref="DescribeSampleMatrixQueryRequest"/></param>
        /// <returns><see cref="DescribeSampleMatrixQueryResponse"/></returns>
        public async Task<DescribeSampleMatrixQueryResponse> DescribeSampleMatrixQuery(DescribeSampleMatrixQueryRequest req)
        {
             JsonResponseModel<DescribeSampleMatrixQueryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSampleMatrixQuery");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSampleMatrixQueryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指标矩阵
        /// </summary>
        /// <param name="req"><see cref="DescribeSampleMatrixQueryRequest"/></param>
        /// <returns><see cref="DescribeSampleMatrixQueryResponse"/></returns>
        public DescribeSampleMatrixQueryResponse DescribeSampleMatrixQuerySync(DescribeSampleMatrixQueryRequest req)
        {
             JsonResponseModel<DescribeSampleMatrixQueryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSampleMatrixQuery");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSampleMatrixQueryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指标，返回固定时间点指标内容
        /// </summary>
        /// <param name="req"><see cref="DescribeSampleQueryRequest"/></param>
        /// <returns><see cref="DescribeSampleQueryResponse"/></returns>
        public async Task<DescribeSampleQueryResponse> DescribeSampleQuery(DescribeSampleQueryRequest req)
        {
             JsonResponseModel<DescribeSampleQueryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSampleQuery");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSampleQueryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指标，返回固定时间点指标内容
        /// </summary>
        /// <param name="req"><see cref="DescribeSampleQueryRequest"/></param>
        /// <returns><see cref="DescribeSampleQueryResponse"/></returns>
        public DescribeSampleQueryResponse DescribeSampleQuerySync(DescribeSampleQueryRequest req)
        {
             JsonResponseModel<DescribeSampleQueryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSampleQuery");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSampleQueryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询场景配置并附带已经执行的任务内容
        /// </summary>
        /// <param name="req"><see cref="DescribeScenarioWithJobsRequest"/></param>
        /// <returns><see cref="DescribeScenarioWithJobsResponse"/></returns>
        public async Task<DescribeScenarioWithJobsResponse> DescribeScenarioWithJobs(DescribeScenarioWithJobsRequest req)
        {
             JsonResponseModel<DescribeScenarioWithJobsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScenarioWithJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScenarioWithJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询场景配置并附带已经执行的任务内容
        /// </summary>
        /// <param name="req"><see cref="DescribeScenarioWithJobsRequest"/></param>
        /// <returns><see cref="DescribeScenarioWithJobsResponse"/></returns>
        public DescribeScenarioWithJobsResponse DescribeScenarioWithJobsSync(DescribeScenarioWithJobsRequest req)
        {
             JsonResponseModel<DescribeScenarioWithJobsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScenarioWithJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScenarioWithJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询场景列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScenariosRequest"/></param>
        /// <returns><see cref="DescribeScenariosResponse"/></returns>
        public async Task<DescribeScenariosResponse> DescribeScenarios(DescribeScenariosRequest req)
        {
             JsonResponseModel<DescribeScenariosResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScenarios");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScenariosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询场景列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScenariosRequest"/></param>
        /// <returns><see cref="DescribeScenariosResponse"/></returns>
        public DescribeScenariosResponse DescribeScenariosSync(DescribeScenariosRequest req)
        {
             JsonResponseModel<DescribeScenariosResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScenarios");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScenariosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 生成临时COS凭证
        /// </summary>
        /// <param name="req"><see cref="GenerateTmpKeyRequest"/></param>
        /// <returns><see cref="GenerateTmpKeyResponse"/></returns>
        public async Task<GenerateTmpKeyResponse> GenerateTmpKey(GenerateTmpKeyRequest req)
        {
             JsonResponseModel<GenerateTmpKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GenerateTmpKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GenerateTmpKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 生成临时COS凭证
        /// </summary>
        /// <param name="req"><see cref="GenerateTmpKeyRequest"/></param>
        /// <returns><see cref="GenerateTmpKeyResponse"/></returns>
        public GenerateTmpKeyResponse GenerateTmpKeySync(GenerateTmpKeyRequest req)
        {
             JsonResponseModel<GenerateTmpKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GenerateTmpKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GenerateTmpKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重启状态为已中止的定时任务
        /// </summary>
        /// <param name="req"><see cref="RestartCronJobsRequest"/></param>
        /// <returns><see cref="RestartCronJobsResponse"/></returns>
        public async Task<RestartCronJobsResponse> RestartCronJobs(RestartCronJobsRequest req)
        {
             JsonResponseModel<RestartCronJobsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RestartCronJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestartCronJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重启状态为已中止的定时任务
        /// </summary>
        /// <param name="req"><see cref="RestartCronJobsRequest"/></param>
        /// <returns><see cref="RestartCronJobsResponse"/></returns>
        public RestartCronJobsResponse RestartCronJobsSync(RestartCronJobsRequest req)
        {
             JsonResponseModel<RestartCronJobsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RestartCronJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestartCronJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建并启动任务
        /// </summary>
        /// <param name="req"><see cref="StartJobRequest"/></param>
        /// <returns><see cref="StartJobResponse"/></returns>
        public async Task<StartJobResponse> StartJob(StartJobRequest req)
        {
             JsonResponseModel<StartJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建并启动任务
        /// </summary>
        /// <param name="req"><see cref="StartJobRequest"/></param>
        /// <returns><see cref="StartJobResponse"/></returns>
        public StartJobResponse StartJobSync(StartJobRequest req)
        {
             JsonResponseModel<StartJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新定时任务
        /// </summary>
        /// <param name="req"><see cref="UpdateCronJobRequest"/></param>
        /// <returns><see cref="UpdateCronJobResponse"/></returns>
        public async Task<UpdateCronJobResponse> UpdateCronJob(UpdateCronJobRequest req)
        {
             JsonResponseModel<UpdateCronJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateCronJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCronJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新定时任务
        /// </summary>
        /// <param name="req"><see cref="UpdateCronJobRequest"/></param>
        /// <returns><see cref="UpdateCronJobResponse"/></returns>
        public UpdateCronJobResponse UpdateCronJobSync(UpdateCronJobRequest req)
        {
             JsonResponseModel<UpdateCronJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateCronJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateCronJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新关联文件场景
        /// </summary>
        /// <param name="req"><see cref="UpdateFileScenarioRelationRequest"/></param>
        /// <returns><see cref="UpdateFileScenarioRelationResponse"/></returns>
        public async Task<UpdateFileScenarioRelationResponse> UpdateFileScenarioRelation(UpdateFileScenarioRelationRequest req)
        {
             JsonResponseModel<UpdateFileScenarioRelationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateFileScenarioRelation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateFileScenarioRelationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新关联文件场景
        /// </summary>
        /// <param name="req"><see cref="UpdateFileScenarioRelationRequest"/></param>
        /// <returns><see cref="UpdateFileScenarioRelationResponse"/></returns>
        public UpdateFileScenarioRelationResponse UpdateFileScenarioRelationSync(UpdateFileScenarioRelationRequest req)
        {
             JsonResponseModel<UpdateFileScenarioRelationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateFileScenarioRelation");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateFileScenarioRelationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新任务
        /// </summary>
        /// <param name="req"><see cref="UpdateJobRequest"/></param>
        /// <returns><see cref="UpdateJobResponse"/></returns>
        public async Task<UpdateJobResponse> UpdateJob(UpdateJobRequest req)
        {
             JsonResponseModel<UpdateJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新任务
        /// </summary>
        /// <param name="req"><see cref="UpdateJobRequest"/></param>
        /// <returns><see cref="UpdateJobResponse"/></returns>
        public UpdateJobResponse UpdateJobSync(UpdateJobRequest req)
        {
             JsonResponseModel<UpdateJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新项目
        /// </summary>
        /// <param name="req"><see cref="UpdateProjectRequest"/></param>
        /// <returns><see cref="UpdateProjectResponse"/></returns>
        public async Task<UpdateProjectResponse> UpdateProject(UpdateProjectRequest req)
        {
             JsonResponseModel<UpdateProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新项目
        /// </summary>
        /// <param name="req"><see cref="UpdateProjectRequest"/></param>
        /// <returns><see cref="UpdateProjectResponse"/></returns>
        public UpdateProjectResponse UpdateProjectSync(UpdateProjectRequest req)
        {
             JsonResponseModel<UpdateProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新场景
        /// </summary>
        /// <param name="req"><see cref="UpdateScenarioRequest"/></param>
        /// <returns><see cref="UpdateScenarioResponse"/></returns>
        public async Task<UpdateScenarioResponse> UpdateScenario(UpdateScenarioRequest req)
        {
             JsonResponseModel<UpdateScenarioResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateScenario");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateScenarioResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新场景
        /// </summary>
        /// <param name="req"><see cref="UpdateScenarioRequest"/></param>
        /// <returns><see cref="UpdateScenarioResponse"/></returns>
        public UpdateScenarioResponse UpdateScenarioSync(UpdateScenarioRequest req)
        {
             JsonResponseModel<UpdateScenarioResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateScenario");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateScenarioResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}

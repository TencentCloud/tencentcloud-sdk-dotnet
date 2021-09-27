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

namespace TencentCloud.Rum.V20210622
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Rum.V20210622.Models;

   public class RumClient : AbstractClient{

       private const string endpoint = "rum.tencentcloudapi.com";
       private const string version = "2021-06-22";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public RumClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public RumClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 创建项目（归属于某个团队）
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
        /// 创建项目（归属于某个团队）
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
        /// 获取LogUrlStatistics信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataLogUrlStatisticsRequest"/></param>
        /// <returns><see cref="DescribeDataLogUrlStatisticsResponse"/></returns>
        public async Task<DescribeDataLogUrlStatisticsResponse> DescribeDataLogUrlStatistics(DescribeDataLogUrlStatisticsRequest req)
        {
             JsonResponseModel<DescribeDataLogUrlStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDataLogUrlStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataLogUrlStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取LogUrlStatistics信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataLogUrlStatisticsRequest"/></param>
        /// <returns><see cref="DescribeDataLogUrlStatisticsResponse"/></returns>
        public DescribeDataLogUrlStatisticsResponse DescribeDataLogUrlStatisticsSync(DescribeDataLogUrlStatisticsRequest req)
        {
             JsonResponseModel<DescribeDataLogUrlStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDataLogUrlStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataLogUrlStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取PerformancePage信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataPerformancePageRequest"/></param>
        /// <returns><see cref="DescribeDataPerformancePageResponse"/></returns>
        public async Task<DescribeDataPerformancePageResponse> DescribeDataPerformancePage(DescribeDataPerformancePageRequest req)
        {
             JsonResponseModel<DescribeDataPerformancePageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDataPerformancePage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataPerformancePageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取PerformancePage信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataPerformancePageRequest"/></param>
        /// <returns><see cref="DescribeDataPerformancePageResponse"/></returns>
        public DescribeDataPerformancePageResponse DescribeDataPerformancePageSync(DescribeDataPerformancePageRequest req)
        {
             JsonResponseModel<DescribeDataPerformancePageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDataPerformancePage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDataPerformancePageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取首页错误信息
        /// </summary>
        /// <param name="req"><see cref="DescribeErrorRequest"/></param>
        /// <returns><see cref="DescribeErrorResponse"/></returns>
        public async Task<DescribeErrorResponse> DescribeError(DescribeErrorRequest req)
        {
             JsonResponseModel<DescribeErrorResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeError");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeErrorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取首页错误信息
        /// </summary>
        /// <param name="req"><see cref="DescribeErrorRequest"/></param>
        /// <returns><see cref="DescribeErrorResponse"/></returns>
        public DescribeErrorResponse DescribeErrorSync(DescribeErrorRequest req)
        {
             JsonResponseModel<DescribeErrorResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeError");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeErrorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取项目下的日志列表（实例创建的项目下的日志列表）
        /// </summary>
        /// <param name="req"><see cref="DescribeLogListRequest"/></param>
        /// <returns><see cref="DescribeLogListResponse"/></returns>
        public async Task<DescribeLogListResponse> DescribeLogList(DescribeLogListRequest req)
        {
             JsonResponseModel<DescribeLogListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLogList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取项目下的日志列表（实例创建的项目下的日志列表）
        /// </summary>
        /// <param name="req"><see cref="DescribeLogListRequest"/></param>
        /// <returns><see cref="DescribeLogListResponse"/></returns>
        public DescribeLogListResponse DescribeLogListSync(DescribeLogListRequest req)
        {
             JsonResponseModel<DescribeLogListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLogList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取项目列表（实例创建的团队下的项目列表）
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
        /// 获取项目列表（实例创建的团队下的项目列表）
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
        /// 获取首页分数列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScoresRequest"/></param>
        /// <returns><see cref="DescribeScoresResponse"/></returns>
        public async Task<DescribeScoresResponse> DescribeScores(DescribeScoresRequest req)
        {
             JsonResponseModel<DescribeScoresResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScores");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScoresResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取首页分数列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScoresRequest"/></param>
        /// <returns><see cref="DescribeScoresResponse"/></returns>
        public DescribeScoresResponse DescribeScoresSync(DescribeScoresRequest req)
        {
             JsonResponseModel<DescribeScoresResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScores");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScoresResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}

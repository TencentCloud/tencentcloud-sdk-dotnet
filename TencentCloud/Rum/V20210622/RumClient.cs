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
       private const string sdkVersion = "SDK_NET_3.0.1226";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public RumClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 创建 RUM 应用（归属于某个团队）
        /// </summary>
        /// <param name="req"><see cref="CreateProjectRequest"/></param>
        /// <returns><see cref="CreateProjectResponse"/></returns>
        public Task<CreateProjectResponse> CreateProject(CreateProjectRequest req)
        {
            return InternalRequestAsync<CreateProjectResponse>(req, "CreateProject");
        }

        /// <summary>
        /// 创建 RUM 应用（归属于某个团队）
        /// </summary>
        /// <param name="req"><see cref="CreateProjectRequest"/></param>
        /// <returns><see cref="CreateProjectResponse"/></returns>
        public CreateProjectResponse CreateProjectSync(CreateProjectRequest req)
        {
            return InternalRequestAsync<CreateProjectResponse>(req, "CreateProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建对应项目的文件记录
        /// </summary>
        /// <param name="req"><see cref="CreateReleaseFileRequest"/></param>
        /// <returns><see cref="CreateReleaseFileResponse"/></returns>
        public Task<CreateReleaseFileResponse> CreateReleaseFile(CreateReleaseFileRequest req)
        {
            return InternalRequestAsync<CreateReleaseFileResponse>(req, "CreateReleaseFile");
        }

        /// <summary>
        /// 创建对应项目的文件记录
        /// </summary>
        /// <param name="req"><see cref="CreateReleaseFileRequest"/></param>
        /// <returns><see cref="CreateReleaseFileResponse"/></returns>
        public CreateReleaseFileResponse CreateReleaseFileSync(CreateReleaseFileRequest req)
        {
            return InternalRequestAsync<CreateReleaseFileResponse>(req, "CreateReleaseFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 个人用户添加星标项目
        /// </summary>
        /// <param name="req"><see cref="CreateStarProjectRequest"/></param>
        /// <returns><see cref="CreateStarProjectResponse"/></returns>
        public Task<CreateStarProjectResponse> CreateStarProject(CreateStarProjectRequest req)
        {
            return InternalRequestAsync<CreateStarProjectResponse>(req, "CreateStarProject");
        }

        /// <summary>
        /// 个人用户添加星标项目
        /// </summary>
        /// <param name="req"><see cref="CreateStarProjectRequest"/></param>
        /// <returns><see cref="CreateStarProjectResponse"/></returns>
        public CreateStarProjectResponse CreateStarProjectSync(CreateStarProjectRequest req)
        {
            return InternalRequestAsync<CreateStarProjectResponse>(req, "CreateStarProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建 RUM 业务系统
        /// </summary>
        /// <param name="req"><see cref="CreateTawInstanceRequest"/></param>
        /// <returns><see cref="CreateTawInstanceResponse"/></returns>
        public Task<CreateTawInstanceResponse> CreateTawInstance(CreateTawInstanceRequest req)
        {
            return InternalRequestAsync<CreateTawInstanceResponse>(req, "CreateTawInstance");
        }

        /// <summary>
        /// 创建 RUM 业务系统
        /// </summary>
        /// <param name="req"><see cref="CreateTawInstanceRequest"/></param>
        /// <returns><see cref="CreateTawInstanceResponse"/></returns>
        public CreateTawInstanceResponse CreateTawInstanceSync(CreateTawInstanceRequest req)
        {
            return InternalRequestAsync<CreateTawInstanceResponse>(req, "CreateTawInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建白名单
        /// </summary>
        /// <param name="req"><see cref="CreateWhitelistRequest"/></param>
        /// <returns><see cref="CreateWhitelistResponse"/></returns>
        public Task<CreateWhitelistResponse> CreateWhitelist(CreateWhitelistRequest req)
        {
            return InternalRequestAsync<CreateWhitelistResponse>(req, "CreateWhitelist");
        }

        /// <summary>
        /// 创建白名单
        /// </summary>
        /// <param name="req"><see cref="CreateWhitelistRequest"/></param>
        /// <returns><see cref="CreateWhitelistResponse"/></returns>
        public CreateWhitelistResponse CreateWhitelistSync(CreateWhitelistRequest req)
        {
            return InternalRequestAsync<CreateWhitelistResponse>(req, "CreateWhitelist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除实例，谨慎操作，不可恢复
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceRequest"/></param>
        /// <returns><see cref="DeleteInstanceResponse"/></returns>
        public Task<DeleteInstanceResponse> DeleteInstance(DeleteInstanceRequest req)
        {
            return InternalRequestAsync<DeleteInstanceResponse>(req, "DeleteInstance");
        }

        /// <summary>
        /// 删除实例，谨慎操作，不可恢复
        /// </summary>
        /// <param name="req"><see cref="DeleteInstanceRequest"/></param>
        /// <returns><see cref="DeleteInstanceResponse"/></returns>
        public DeleteInstanceResponse DeleteInstanceSync(DeleteInstanceRequest req)
        {
            return InternalRequestAsync<DeleteInstanceResponse>(req, "DeleteInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除给定的 rum 的项目
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectRequest"/></param>
        /// <returns><see cref="DeleteProjectResponse"/></returns>
        public Task<DeleteProjectResponse> DeleteProject(DeleteProjectRequest req)
        {
            return InternalRequestAsync<DeleteProjectResponse>(req, "DeleteProject");
        }

        /// <summary>
        /// 删除给定的 rum 的项目
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectRequest"/></param>
        /// <returns><see cref="DeleteProjectResponse"/></returns>
        public DeleteProjectResponse DeleteProjectSync(DeleteProjectRequest req)
        {
            return InternalRequestAsync<DeleteProjectResponse>(req, "DeleteProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 将对应 sourcemap 文件删除
        /// </summary>
        /// <param name="req"><see cref="DeleteReleaseFileRequest"/></param>
        /// <returns><see cref="DeleteReleaseFileResponse"/></returns>
        public Task<DeleteReleaseFileResponse> DeleteReleaseFile(DeleteReleaseFileRequest req)
        {
            return InternalRequestAsync<DeleteReleaseFileResponse>(req, "DeleteReleaseFile");
        }

        /// <summary>
        /// 将对应 sourcemap 文件删除
        /// </summary>
        /// <param name="req"><see cref="DeleteReleaseFileRequest"/></param>
        /// <returns><see cref="DeleteReleaseFileResponse"/></returns>
        public DeleteReleaseFileResponse DeleteReleaseFileSync(DeleteReleaseFileRequest req)
        {
            return InternalRequestAsync<DeleteReleaseFileResponse>(req, "DeleteReleaseFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除用户名下的星标项目
        /// </summary>
        /// <param name="req"><see cref="DeleteStarProjectRequest"/></param>
        /// <returns><see cref="DeleteStarProjectResponse"/></returns>
        public Task<DeleteStarProjectResponse> DeleteStarProject(DeleteStarProjectRequest req)
        {
            return InternalRequestAsync<DeleteStarProjectResponse>(req, "DeleteStarProject");
        }

        /// <summary>
        /// 删除用户名下的星标项目
        /// </summary>
        /// <param name="req"><see cref="DeleteStarProjectRequest"/></param>
        /// <returns><see cref="DeleteStarProjectResponse"/></returns>
        public DeleteStarProjectResponse DeleteStarProjectSync(DeleteStarProjectRequest req)
        {
            return InternalRequestAsync<DeleteStarProjectResponse>(req, "DeleteStarProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteWhitelistRequest"/></param>
        /// <returns><see cref="DeleteWhitelistResponse"/></returns>
        public Task<DeleteWhitelistResponse> DeleteWhitelist(DeleteWhitelistRequest req)
        {
            return InternalRequestAsync<DeleteWhitelistResponse>(req, "DeleteWhitelist");
        }

        /// <summary>
        /// 删除白名单
        /// </summary>
        /// <param name="req"><see cref="DeleteWhitelistRequest"/></param>
        /// <returns><see cref="DeleteWhitelistResponse"/></returns>
        public DeleteWhitelistResponse DeleteWhitelistSync(DeleteWhitelistRequest req)
        {
            return InternalRequestAsync<DeleteWhitelistResponse>(req, "DeleteWhitelist")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询 app 监控多维分析数据
        /// </summary>
        /// <param name="req"><see cref="DescribeAppDimensionMetricsRequest"/></param>
        /// <returns><see cref="DescribeAppDimensionMetricsResponse"/></returns>
        public Task<DescribeAppDimensionMetricsResponse> DescribeAppDimensionMetrics(DescribeAppDimensionMetricsRequest req)
        {
            return InternalRequestAsync<DescribeAppDimensionMetricsResponse>(req, "DescribeAppDimensionMetrics");
        }

        /// <summary>
        /// 用于查询 app 监控多维分析数据
        /// </summary>
        /// <param name="req"><see cref="DescribeAppDimensionMetricsRequest"/></param>
        /// <returns><see cref="DescribeAppDimensionMetricsResponse"/></returns>
        public DescribeAppDimensionMetricsResponse DescribeAppDimensionMetricsSync(DescribeAppDimensionMetricsRequest req)
        {
            return InternalRequestAsync<DescribeAppDimensionMetricsResponse>(req, "DescribeAppDimensionMetrics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取 app 监控指标数据
        /// </summary>
        /// <param name="req"><see cref="DescribeAppMetricsDataRequest"/></param>
        /// <returns><see cref="DescribeAppMetricsDataResponse"/></returns>
        public Task<DescribeAppMetricsDataResponse> DescribeAppMetricsData(DescribeAppMetricsDataRequest req)
        {
            return InternalRequestAsync<DescribeAppMetricsDataResponse>(req, "DescribeAppMetricsData");
        }

        /// <summary>
        /// 获取 app 监控指标数据
        /// </summary>
        /// <param name="req"><see cref="DescribeAppMetricsDataRequest"/></param>
        /// <returns><see cref="DescribeAppMetricsDataResponse"/></returns>
        public DescribeAppMetricsDataResponse DescribeAppMetricsDataSync(DescribeAppMetricsDataRequest req)
        {
            return InternalRequestAsync<DescribeAppMetricsDataResponse>(req, "DescribeAppMetricsData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 app 监控个例样本详情列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAppSingleCaseDetailListRequest"/></param>
        /// <returns><see cref="DescribeAppSingleCaseDetailListResponse"/></returns>
        public Task<DescribeAppSingleCaseDetailListResponse> DescribeAppSingleCaseDetailList(DescribeAppSingleCaseDetailListRequest req)
        {
            return InternalRequestAsync<DescribeAppSingleCaseDetailListResponse>(req, "DescribeAppSingleCaseDetailList");
        }

        /// <summary>
        /// 查询 app 监控个例样本详情列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAppSingleCaseDetailListRequest"/></param>
        /// <returns><see cref="DescribeAppSingleCaseDetailListResponse"/></returns>
        public DescribeAppSingleCaseDetailListResponse DescribeAppSingleCaseDetailListSync(DescribeAppSingleCaseDetailListRequest req)
        {
            return InternalRequestAsync<DescribeAppSingleCaseDetailListResponse>(req, "DescribeAppSingleCaseDetailList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 app 监控个例聚合列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAppSingleCaseListRequest"/></param>
        /// <returns><see cref="DescribeAppSingleCaseListResponse"/></returns>
        public Task<DescribeAppSingleCaseListResponse> DescribeAppSingleCaseList(DescribeAppSingleCaseListRequest req)
        {
            return InternalRequestAsync<DescribeAppSingleCaseListResponse>(req, "DescribeAppSingleCaseList");
        }

        /// <summary>
        /// 查询 app 监控个例聚合列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAppSingleCaseListRequest"/></param>
        /// <returns><see cref="DescribeAppSingleCaseListResponse"/></returns>
        public DescribeAppSingleCaseListResponse DescribeAppSingleCaseListSync(DescribeAppSingleCaseListRequest req)
        {
            return InternalRequestAsync<DescribeAppSingleCaseListResponse>(req, "DescribeAppSingleCaseList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 转发monitor查询
        /// </summary>
        /// <param name="req"><see cref="DescribeDataRequest"/></param>
        /// <returns><see cref="DescribeDataResponse"/></returns>
        public Task<DescribeDataResponse> DescribeData(DescribeDataRequest req)
        {
            return InternalRequestAsync<DescribeDataResponse>(req, "DescribeData");
        }

        /// <summary>
        /// 转发monitor查询
        /// </summary>
        /// <param name="req"><see cref="DescribeDataRequest"/></param>
        /// <returns><see cref="DescribeDataResponse"/></returns>
        public DescribeDataResponse DescribeDataSync(DescribeDataRequest req)
        {
            return InternalRequestAsync<DescribeDataResponse>(req, "DescribeData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DescribeDataCustomUrl信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataCustomUrlRequest"/></param>
        /// <returns><see cref="DescribeDataCustomUrlResponse"/></returns>
        public Task<DescribeDataCustomUrlResponse> DescribeDataCustomUrl(DescribeDataCustomUrlRequest req)
        {
            return InternalRequestAsync<DescribeDataCustomUrlResponse>(req, "DescribeDataCustomUrl");
        }

        /// <summary>
        /// 获取DescribeDataCustomUrl信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataCustomUrlRequest"/></param>
        /// <returns><see cref="DescribeDataCustomUrlResponse"/></returns>
        public DescribeDataCustomUrlResponse DescribeDataCustomUrlSync(DescribeDataCustomUrlRequest req)
        {
            return InternalRequestAsync<DescribeDataCustomUrlResponse>(req, "DescribeDataCustomUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DescribeDataEventUrl信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataEventUrlRequest"/></param>
        /// <returns><see cref="DescribeDataEventUrlResponse"/></returns>
        public Task<DescribeDataEventUrlResponse> DescribeDataEventUrl(DescribeDataEventUrlRequest req)
        {
            return InternalRequestAsync<DescribeDataEventUrlResponse>(req, "DescribeDataEventUrl");
        }

        /// <summary>
        /// 获取DescribeDataEventUrl信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataEventUrlRequest"/></param>
        /// <returns><see cref="DescribeDataEventUrlResponse"/></returns>
        public DescribeDataEventUrlResponse DescribeDataEventUrlSync(DescribeDataEventUrlRequest req)
        {
            return InternalRequestAsync<DescribeDataEventUrlResponse>(req, "DescribeDataEventUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DescribeDataFetchProject信息。已下线，请使用DescribeDataFetchUrl
        /// </summary>
        /// <param name="req"><see cref="DescribeDataFetchProjectRequest"/></param>
        /// <returns><see cref="DescribeDataFetchProjectResponse"/></returns>
        public Task<DescribeDataFetchProjectResponse> DescribeDataFetchProject(DescribeDataFetchProjectRequest req)
        {
            return InternalRequestAsync<DescribeDataFetchProjectResponse>(req, "DescribeDataFetchProject");
        }

        /// <summary>
        /// 获取DescribeDataFetchProject信息。已下线，请使用DescribeDataFetchUrl
        /// </summary>
        /// <param name="req"><see cref="DescribeDataFetchProjectRequest"/></param>
        /// <returns><see cref="DescribeDataFetchProjectResponse"/></returns>
        public DescribeDataFetchProjectResponse DescribeDataFetchProjectSync(DescribeDataFetchProjectRequest req)
        {
            return InternalRequestAsync<DescribeDataFetchProjectResponse>(req, "DescribeDataFetchProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DescribeDataFetchUrl信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataFetchUrlRequest"/></param>
        /// <returns><see cref="DescribeDataFetchUrlResponse"/></returns>
        public Task<DescribeDataFetchUrlResponse> DescribeDataFetchUrl(DescribeDataFetchUrlRequest req)
        {
            return InternalRequestAsync<DescribeDataFetchUrlResponse>(req, "DescribeDataFetchUrl");
        }

        /// <summary>
        /// 获取DescribeDataFetchUrl信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataFetchUrlRequest"/></param>
        /// <returns><see cref="DescribeDataFetchUrlResponse"/></returns>
        public DescribeDataFetchUrlResponse DescribeDataFetchUrlSync(DescribeDataFetchUrlRequest req)
        {
            return InternalRequestAsync<DescribeDataFetchUrlResponse>(req, "DescribeDataFetchUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DescribeDataFetchUrlInfo信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataFetchUrlInfoRequest"/></param>
        /// <returns><see cref="DescribeDataFetchUrlInfoResponse"/></returns>
        public Task<DescribeDataFetchUrlInfoResponse> DescribeDataFetchUrlInfo(DescribeDataFetchUrlInfoRequest req)
        {
            return InternalRequestAsync<DescribeDataFetchUrlInfoResponse>(req, "DescribeDataFetchUrlInfo");
        }

        /// <summary>
        /// 获取DescribeDataFetchUrlInfo信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataFetchUrlInfoRequest"/></param>
        /// <returns><see cref="DescribeDataFetchUrlInfoResponse"/></returns>
        public DescribeDataFetchUrlInfoResponse DescribeDataFetchUrlInfoSync(DescribeDataFetchUrlInfoRequest req)
        {
            return InternalRequestAsync<DescribeDataFetchUrlInfoResponse>(req, "DescribeDataFetchUrlInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取loginfo信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataLogUrlInfoRequest"/></param>
        /// <returns><see cref="DescribeDataLogUrlInfoResponse"/></returns>
        public Task<DescribeDataLogUrlInfoResponse> DescribeDataLogUrlInfo(DescribeDataLogUrlInfoRequest req)
        {
            return InternalRequestAsync<DescribeDataLogUrlInfoResponse>(req, "DescribeDataLogUrlInfo");
        }

        /// <summary>
        /// 获取loginfo信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataLogUrlInfoRequest"/></param>
        /// <returns><see cref="DescribeDataLogUrlInfoResponse"/></returns>
        public DescribeDataLogUrlInfoResponse DescribeDataLogUrlInfoSync(DescribeDataLogUrlInfoRequest req)
        {
            return InternalRequestAsync<DescribeDataLogUrlInfoResponse>(req, "DescribeDataLogUrlInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取LogUrlStatistics信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataLogUrlStatisticsRequest"/></param>
        /// <returns><see cref="DescribeDataLogUrlStatisticsResponse"/></returns>
        public Task<DescribeDataLogUrlStatisticsResponse> DescribeDataLogUrlStatistics(DescribeDataLogUrlStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeDataLogUrlStatisticsResponse>(req, "DescribeDataLogUrlStatistics");
        }

        /// <summary>
        /// 获取LogUrlStatistics信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataLogUrlStatisticsRequest"/></param>
        /// <returns><see cref="DescribeDataLogUrlStatisticsResponse"/></returns>
        public DescribeDataLogUrlStatisticsResponse DescribeDataLogUrlStatisticsSync(DescribeDataLogUrlStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeDataLogUrlStatisticsResponse>(req, "DescribeDataLogUrlStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取PerformancePage信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataPerformancePageRequest"/></param>
        /// <returns><see cref="DescribeDataPerformancePageResponse"/></returns>
        public Task<DescribeDataPerformancePageResponse> DescribeDataPerformancePage(DescribeDataPerformancePageRequest req)
        {
            return InternalRequestAsync<DescribeDataPerformancePageResponse>(req, "DescribeDataPerformancePage");
        }

        /// <summary>
        /// 获取PerformancePage信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataPerformancePageRequest"/></param>
        /// <returns><see cref="DescribeDataPerformancePageResponse"/></returns>
        public DescribeDataPerformancePageResponse DescribeDataPerformancePageSync(DescribeDataPerformancePageRequest req)
        {
            return InternalRequestAsync<DescribeDataPerformancePageResponse>(req, "DescribeDataPerformancePage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取PvUrlInfo信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataPvUrlInfoRequest"/></param>
        /// <returns><see cref="DescribeDataPvUrlInfoResponse"/></returns>
        public Task<DescribeDataPvUrlInfoResponse> DescribeDataPvUrlInfo(DescribeDataPvUrlInfoRequest req)
        {
            return InternalRequestAsync<DescribeDataPvUrlInfoResponse>(req, "DescribeDataPvUrlInfo");
        }

        /// <summary>
        /// 获取PvUrlInfo信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataPvUrlInfoRequest"/></param>
        /// <returns><see cref="DescribeDataPvUrlInfoResponse"/></returns>
        public DescribeDataPvUrlInfoResponse DescribeDataPvUrlInfoSync(DescribeDataPvUrlInfoRequest req)
        {
            return InternalRequestAsync<DescribeDataPvUrlInfoResponse>(req, "DescribeDataPvUrlInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DescribeDataPvUrlStatistics信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataPvUrlStatisticsRequest"/></param>
        /// <returns><see cref="DescribeDataPvUrlStatisticsResponse"/></returns>
        public Task<DescribeDataPvUrlStatisticsResponse> DescribeDataPvUrlStatistics(DescribeDataPvUrlStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeDataPvUrlStatisticsResponse>(req, "DescribeDataPvUrlStatistics");
        }

        /// <summary>
        /// 获取DescribeDataPvUrlStatistics信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataPvUrlStatisticsRequest"/></param>
        /// <returns><see cref="DescribeDataPvUrlStatisticsResponse"/></returns>
        public DescribeDataPvUrlStatisticsResponse DescribeDataPvUrlStatisticsSync(DescribeDataPvUrlStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeDataPvUrlStatisticsResponse>(req, "DescribeDataPvUrlStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取项目上报量
        /// </summary>
        /// <param name="req"><see cref="DescribeDataReportCountRequest"/></param>
        /// <returns><see cref="DescribeDataReportCountResponse"/></returns>
        public Task<DescribeDataReportCountResponse> DescribeDataReportCount(DescribeDataReportCountRequest req)
        {
            return InternalRequestAsync<DescribeDataReportCountResponse>(req, "DescribeDataReportCount");
        }

        /// <summary>
        /// 获取项目上报量
        /// </summary>
        /// <param name="req"><see cref="DescribeDataReportCountRequest"/></param>
        /// <returns><see cref="DescribeDataReportCountResponse"/></returns>
        public DescribeDataReportCountResponse DescribeDataReportCountSync(DescribeDataReportCountRequest req)
        {
            return InternalRequestAsync<DescribeDataReportCountResponse>(req, "DescribeDataReportCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DescribeDataSetUrlStatistics信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataSetUrlStatisticsRequest"/></param>
        /// <returns><see cref="DescribeDataSetUrlStatisticsResponse"/></returns>
        public Task<DescribeDataSetUrlStatisticsResponse> DescribeDataSetUrlStatistics(DescribeDataSetUrlStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeDataSetUrlStatisticsResponse>(req, "DescribeDataSetUrlStatistics");
        }

        /// <summary>
        /// 获取DescribeDataSetUrlStatistics信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataSetUrlStatisticsRequest"/></param>
        /// <returns><see cref="DescribeDataSetUrlStatisticsResponse"/></returns>
        public DescribeDataSetUrlStatisticsResponse DescribeDataSetUrlStatisticsSync(DescribeDataSetUrlStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeDataSetUrlStatisticsResponse>(req, "DescribeDataSetUrlStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DescribeDataStaticProject信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataStaticProjectRequest"/></param>
        /// <returns><see cref="DescribeDataStaticProjectResponse"/></returns>
        public Task<DescribeDataStaticProjectResponse> DescribeDataStaticProject(DescribeDataStaticProjectRequest req)
        {
            return InternalRequestAsync<DescribeDataStaticProjectResponse>(req, "DescribeDataStaticProject");
        }

        /// <summary>
        /// 获取DescribeDataStaticProject信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataStaticProjectRequest"/></param>
        /// <returns><see cref="DescribeDataStaticProjectResponse"/></returns>
        public DescribeDataStaticProjectResponse DescribeDataStaticProjectSync(DescribeDataStaticProjectRequest req)
        {
            return InternalRequestAsync<DescribeDataStaticProjectResponse>(req, "DescribeDataStaticProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DescribeDataStaticResource信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataStaticResourceRequest"/></param>
        /// <returns><see cref="DescribeDataStaticResourceResponse"/></returns>
        public Task<DescribeDataStaticResourceResponse> DescribeDataStaticResource(DescribeDataStaticResourceRequest req)
        {
            return InternalRequestAsync<DescribeDataStaticResourceResponse>(req, "DescribeDataStaticResource");
        }

        /// <summary>
        /// 获取DescribeDataStaticResource信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataStaticResourceRequest"/></param>
        /// <returns><see cref="DescribeDataStaticResourceResponse"/></returns>
        public DescribeDataStaticResourceResponse DescribeDataStaticResourceSync(DescribeDataStaticResourceRequest req)
        {
            return InternalRequestAsync<DescribeDataStaticResourceResponse>(req, "DescribeDataStaticResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DescribeDataStaticUrl信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataStaticUrlRequest"/></param>
        /// <returns><see cref="DescribeDataStaticUrlResponse"/></returns>
        public Task<DescribeDataStaticUrlResponse> DescribeDataStaticUrl(DescribeDataStaticUrlRequest req)
        {
            return InternalRequestAsync<DescribeDataStaticUrlResponse>(req, "DescribeDataStaticUrl");
        }

        /// <summary>
        /// 获取DescribeDataStaticUrl信息
        /// </summary>
        /// <param name="req"><see cref="DescribeDataStaticUrlRequest"/></param>
        /// <returns><see cref="DescribeDataStaticUrlResponse"/></returns>
        public DescribeDataStaticUrlResponse DescribeDataStaticUrlSync(DescribeDataStaticUrlRequest req)
        {
            return InternalRequestAsync<DescribeDataStaticUrlResponse>(req, "DescribeDataStaticUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取DescribeDataWebVitalsPage信息，用户核心活动信息
        /// 页面加载性能之Web Vitals。性能关键点
        /// </summary>
        /// <param name="req"><see cref="DescribeDataWebVitalsPageRequest"/></param>
        /// <returns><see cref="DescribeDataWebVitalsPageResponse"/></returns>
        public Task<DescribeDataWebVitalsPageResponse> DescribeDataWebVitalsPage(DescribeDataWebVitalsPageRequest req)
        {
            return InternalRequestAsync<DescribeDataWebVitalsPageResponse>(req, "DescribeDataWebVitalsPage");
        }

        /// <summary>
        /// 获取DescribeDataWebVitalsPage信息，用户核心活动信息
        /// 页面加载性能之Web Vitals。性能关键点
        /// </summary>
        /// <param name="req"><see cref="DescribeDataWebVitalsPageRequest"/></param>
        /// <returns><see cref="DescribeDataWebVitalsPageResponse"/></returns>
        public DescribeDataWebVitalsPageResponse DescribeDataWebVitalsPageSync(DescribeDataWebVitalsPageRequest req)
        {
            return InternalRequestAsync<DescribeDataWebVitalsPageResponse>(req, "DescribeDataWebVitalsPage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取首页错误信息
        /// </summary>
        /// <param name="req"><see cref="DescribeErrorRequest"/></param>
        /// <returns><see cref="DescribeErrorResponse"/></returns>
        public Task<DescribeErrorResponse> DescribeError(DescribeErrorRequest req)
        {
            return InternalRequestAsync<DescribeErrorResponse>(req, "DescribeError");
        }

        /// <summary>
        /// 获取首页错误信息
        /// </summary>
        /// <param name="req"><see cref="DescribeErrorRequest"/></param>
        /// <returns><see cref="DescribeErrorResponse"/></returns>
        public DescribeErrorResponse DescribeErrorSync(DescribeErrorRequest req)
        {
            return InternalRequestAsync<DescribeErrorResponse>(req, "DescribeError")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取应用上报抽样信息
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectLimitsRequest"/></param>
        /// <returns><see cref="DescribeProjectLimitsResponse"/></returns>
        public Task<DescribeProjectLimitsResponse> DescribeProjectLimits(DescribeProjectLimitsRequest req)
        {
            return InternalRequestAsync<DescribeProjectLimitsResponse>(req, "DescribeProjectLimits");
        }

        /// <summary>
        /// 获取应用上报抽样信息
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectLimitsRequest"/></param>
        /// <returns><see cref="DescribeProjectLimitsResponse"/></returns>
        public DescribeProjectLimitsResponse DescribeProjectLimitsSync(DescribeProjectLimitsRequest req)
        {
            return InternalRequestAsync<DescribeProjectLimitsResponse>(req, "DescribeProjectLimits")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取项目列表（实例创建的团队下的项目列表）
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectsRequest"/></param>
        /// <returns><see cref="DescribeProjectsResponse"/></returns>
        public Task<DescribeProjectsResponse> DescribeProjects(DescribeProjectsRequest req)
        {
            return InternalRequestAsync<DescribeProjectsResponse>(req, "DescribeProjects");
        }

        /// <summary>
        /// 获取项目列表（实例创建的团队下的项目列表）
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectsRequest"/></param>
        /// <returns><see cref="DescribeProjectsResponse"/></returns>
        public DescribeProjectsResponse DescribeProjectsSync(DescribeProjectsRequest req)
        {
            return InternalRequestAsync<DescribeProjectsResponse>(req, "DescribeProjects")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取项目下的PV列表
        /// </summary>
        /// <param name="req"><see cref="DescribePvListRequest"/></param>
        /// <returns><see cref="DescribePvListResponse"/></returns>
        public Task<DescribePvListResponse> DescribePvList(DescribePvListRequest req)
        {
            return InternalRequestAsync<DescribePvListResponse>(req, "DescribePvList");
        }

        /// <summary>
        /// 获取项目下的PV列表
        /// </summary>
        /// <param name="req"><see cref="DescribePvListRequest"/></param>
        /// <returns><see cref="DescribePvListResponse"/></returns>
        public DescribePvListResponse DescribePvListSync(DescribePvListRequest req)
        {
            return InternalRequestAsync<DescribePvListResponse>(req, "DescribePvList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取上传文件存储的临时密钥
        /// </summary>
        /// <param name="req"><see cref="DescribeReleaseFileSignRequest"/></param>
        /// <returns><see cref="DescribeReleaseFileSignResponse"/></returns>
        public Task<DescribeReleaseFileSignResponse> DescribeReleaseFileSign(DescribeReleaseFileSignRequest req)
        {
            return InternalRequestAsync<DescribeReleaseFileSignResponse>(req, "DescribeReleaseFileSign");
        }

        /// <summary>
        /// 获取上传文件存储的临时密钥
        /// </summary>
        /// <param name="req"><see cref="DescribeReleaseFileSignRequest"/></param>
        /// <returns><see cref="DescribeReleaseFileSignResponse"/></returns>
        public DescribeReleaseFileSignResponse DescribeReleaseFileSignSync(DescribeReleaseFileSignRequest req)
        {
            return InternalRequestAsync<DescribeReleaseFileSignResponse>(req, "DescribeReleaseFileSign")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取应用对应sourcemap文件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeReleaseFilesRequest"/></param>
        /// <returns><see cref="DescribeReleaseFilesResponse"/></returns>
        public Task<DescribeReleaseFilesResponse> DescribeReleaseFiles(DescribeReleaseFilesRequest req)
        {
            return InternalRequestAsync<DescribeReleaseFilesResponse>(req, "DescribeReleaseFiles");
        }

        /// <summary>
        /// 获取应用对应sourcemap文件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeReleaseFilesRequest"/></param>
        /// <returns><see cref="DescribeReleaseFilesResponse"/></returns>
        public DescribeReleaseFilesResponse DescribeReleaseFilesSync(DescribeReleaseFilesRequest req)
        {
            return InternalRequestAsync<DescribeReleaseFilesResponse>(req, "DescribeReleaseFiles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取项目下的日志聚合信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRumGroupLogRequest"/></param>
        /// <returns><see cref="DescribeRumGroupLogResponse"/></returns>
        public Task<DescribeRumGroupLogResponse> DescribeRumGroupLog(DescribeRumGroupLogRequest req)
        {
            return InternalRequestAsync<DescribeRumGroupLogResponse>(req, "DescribeRumGroupLog");
        }

        /// <summary>
        /// 获取项目下的日志聚合信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRumGroupLogRequest"/></param>
        /// <returns><see cref="DescribeRumGroupLogResponse"/></returns>
        public DescribeRumGroupLogResponse DescribeRumGroupLogSync(DescribeRumGroupLogRequest req)
        {
            return InternalRequestAsync<DescribeRumGroupLogResponse>(req, "DescribeRumGroupLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取项目下的日志列表（实例创建的项目下的日志列表）
        /// </summary>
        /// <param name="req"><see cref="DescribeRumLogExportRequest"/></param>
        /// <returns><see cref="DescribeRumLogExportResponse"/></returns>
        public Task<DescribeRumLogExportResponse> DescribeRumLogExport(DescribeRumLogExportRequest req)
        {
            return InternalRequestAsync<DescribeRumLogExportResponse>(req, "DescribeRumLogExport");
        }

        /// <summary>
        /// 获取项目下的日志列表（实例创建的项目下的日志列表）
        /// </summary>
        /// <param name="req"><see cref="DescribeRumLogExportRequest"/></param>
        /// <returns><see cref="DescribeRumLogExportResponse"/></returns>
        public DescribeRumLogExportResponse DescribeRumLogExportSync(DescribeRumLogExportRequest req)
        {
            return InternalRequestAsync<DescribeRumLogExportResponse>(req, "DescribeRumLogExport")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取项目下的日志导出列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRumLogExportsRequest"/></param>
        /// <returns><see cref="DescribeRumLogExportsResponse"/></returns>
        public Task<DescribeRumLogExportsResponse> DescribeRumLogExports(DescribeRumLogExportsRequest req)
        {
            return InternalRequestAsync<DescribeRumLogExportsResponse>(req, "DescribeRumLogExports");
        }

        /// <summary>
        /// 获取项目下的日志导出列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRumLogExportsRequest"/></param>
        /// <returns><see cref="DescribeRumLogExportsResponse"/></returns>
        public DescribeRumLogExportsResponse DescribeRumLogExportsSync(DescribeRumLogExportsRequest req)
        {
            return InternalRequestAsync<DescribeRumLogExportsResponse>(req, "DescribeRumLogExports")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取项目下的日志列表（实例创建的项目下的日志列表）
        /// </summary>
        /// <param name="req"><see cref="DescribeRumLogListRequest"/></param>
        /// <returns><see cref="DescribeRumLogListResponse"/></returns>
        public Task<DescribeRumLogListResponse> DescribeRumLogList(DescribeRumLogListRequest req)
        {
            return InternalRequestAsync<DescribeRumLogListResponse>(req, "DescribeRumLogList");
        }

        /// <summary>
        /// 获取项目下的日志列表（实例创建的项目下的日志列表）
        /// </summary>
        /// <param name="req"><see cref="DescribeRumLogListRequest"/></param>
        /// <returns><see cref="DescribeRumLogListResponse"/></returns>
        public DescribeRumLogListResponse DescribeRumLogListSync(DescribeRumLogListRequest req)
        {
            return InternalRequestAsync<DescribeRumLogListResponse>(req, "DescribeRumLogList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取项目下的日志列表，分钟级
        /// </summary>
        /// <param name="req"><see cref="DescribeRumStatsLogListRequest"/></param>
        /// <returns><see cref="DescribeRumStatsLogListResponse"/></returns>
        public Task<DescribeRumStatsLogListResponse> DescribeRumStatsLogList(DescribeRumStatsLogListRequest req)
        {
            return InternalRequestAsync<DescribeRumStatsLogListResponse>(req, "DescribeRumStatsLogList");
        }

        /// <summary>
        /// 获取项目下的日志列表，分钟级
        /// </summary>
        /// <param name="req"><see cref="DescribeRumStatsLogListRequest"/></param>
        /// <returns><see cref="DescribeRumStatsLogListResponse"/></returns>
        public DescribeRumStatsLogListResponse DescribeRumStatsLogListSync(DescribeRumStatsLogListRequest req)
        {
            return InternalRequestAsync<DescribeRumStatsLogListResponse>(req, "DescribeRumStatsLogList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取首页分数列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScoresRequest"/></param>
        /// <returns><see cref="DescribeScoresResponse"/></returns>
        public Task<DescribeScoresResponse> DescribeScores(DescribeScoresRequest req)
        {
            return InternalRequestAsync<DescribeScoresResponse>(req, "DescribeScores");
        }

        /// <summary>
        /// 获取首页分数列表
        /// </summary>
        /// <param name="req"><see cref="DescribeScoresRequest"/></param>
        /// <returns><see cref="DescribeScoresResponse"/></returns>
        public DescribeScoresResponse DescribeScoresSync(DescribeScoresRequest req)
        {
            return InternalRequestAsync<DescribeScoresResponse>(req, "DescribeScores")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询片区信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTawAreasRequest"/></param>
        /// <returns><see cref="DescribeTawAreasResponse"/></returns>
        public Task<DescribeTawAreasResponse> DescribeTawAreas(DescribeTawAreasRequest req)
        {
            return InternalRequestAsync<DescribeTawAreasResponse>(req, "DescribeTawAreas");
        }

        /// <summary>
        /// 查询片区信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTawAreasRequest"/></param>
        /// <returns><see cref="DescribeTawAreasResponse"/></returns>
        public DescribeTawAreasResponse DescribeTawAreasSync(DescribeTawAreasRequest req)
        {
            return InternalRequestAsync<DescribeTawAreasResponse>(req, "DescribeTawAreas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTawInstancesRequest"/></param>
        /// <returns><see cref="DescribeTawInstancesResponse"/></returns>
        public Task<DescribeTawInstancesResponse> DescribeTawInstances(DescribeTawInstancesRequest req)
        {
            return InternalRequestAsync<DescribeTawInstancesResponse>(req, "DescribeTawInstances");
        }

        /// <summary>
        /// 查询实例信息
        /// </summary>
        /// <param name="req"><see cref="DescribeTawInstancesRequest"/></param>
        /// <returns><see cref="DescribeTawInstancesResponse"/></returns>
        public DescribeTawInstancesResponse DescribeTawInstancesSync(DescribeTawInstancesRequest req)
        {
            return InternalRequestAsync<DescribeTawInstancesResponse>(req, "DescribeTawInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取项目下的UV列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUvListRequest"/></param>
        /// <returns><see cref="DescribeUvListResponse"/></returns>
        public Task<DescribeUvListResponse> DescribeUvList(DescribeUvListRequest req)
        {
            return InternalRequestAsync<DescribeUvListResponse>(req, "DescribeUvList");
        }

        /// <summary>
        /// 获取项目下的UV列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUvListRequest"/></param>
        /// <returns><see cref="DescribeUvListResponse"/></returns>
        public DescribeUvListResponse DescribeUvListSync(DescribeUvListRequest req)
        {
            return InternalRequestAsync<DescribeUvListResponse>(req, "DescribeUvList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取白名单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWhitelistsRequest"/></param>
        /// <returns><see cref="DescribeWhitelistsResponse"/></returns>
        public Task<DescribeWhitelistsResponse> DescribeWhitelists(DescribeWhitelistsRequest req)
        {
            return InternalRequestAsync<DescribeWhitelistsResponse>(req, "DescribeWhitelists");
        }

        /// <summary>
        /// 获取白名单列表
        /// </summary>
        /// <param name="req"><see cref="DescribeWhitelistsRequest"/></param>
        /// <returns><see cref="DescribeWhitelistsResponse"/></returns>
        public DescribeWhitelistsResponse DescribeWhitelistsSync(DescribeWhitelistsRequest req)
        {
            return InternalRequestAsync<DescribeWhitelistsResponse>(req, "DescribeWhitelists")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改 RUM 业务系统
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public Task<ModifyInstanceResponse> ModifyInstance(ModifyInstanceRequest req)
        {
            return InternalRequestAsync<ModifyInstanceResponse>(req, "ModifyInstance");
        }

        /// <summary>
        /// 修改 RUM 业务系统
        /// </summary>
        /// <param name="req"><see cref="ModifyInstanceRequest"/></param>
        /// <returns><see cref="ModifyInstanceResponse"/></returns>
        public ModifyInstanceResponse ModifyInstanceSync(ModifyInstanceRequest req)
        {
            return InternalRequestAsync<ModifyInstanceResponse>(req, "ModifyInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改 RUM 应用信息
        /// </summary>
        /// <param name="req"><see cref="ModifyProjectRequest"/></param>
        /// <returns><see cref="ModifyProjectResponse"/></returns>
        public Task<ModifyProjectResponse> ModifyProject(ModifyProjectRequest req)
        {
            return InternalRequestAsync<ModifyProjectResponse>(req, "ModifyProject");
        }

        /// <summary>
        /// 修改 RUM 应用信息
        /// </summary>
        /// <param name="req"><see cref="ModifyProjectRequest"/></param>
        /// <returns><see cref="ModifyProjectResponse"/></returns>
        public ModifyProjectResponse ModifyProjectSync(ModifyProjectRequest req)
        {
            return InternalRequestAsync<ModifyProjectResponse>(req, "ModifyProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 新增修改限流
        /// </summary>
        /// <param name="req"><see cref="ModifyProjectLimitRequest"/></param>
        /// <returns><see cref="ModifyProjectLimitResponse"/></returns>
        public Task<ModifyProjectLimitResponse> ModifyProjectLimit(ModifyProjectLimitRequest req)
        {
            return InternalRequestAsync<ModifyProjectLimitResponse>(req, "ModifyProjectLimit");
        }

        /// <summary>
        /// 新增修改限流
        /// </summary>
        /// <param name="req"><see cref="ModifyProjectLimitRequest"/></param>
        /// <returns><see cref="ModifyProjectLimitResponse"/></returns>
        public ModifyProjectLimitResponse ModifyProjectLimitSync(ModifyProjectLimitRequest req)
        {
            return InternalRequestAsync<ModifyProjectLimitResponse>(req, "ModifyProjectLimit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 恢复 RUM 业务系统，恢复后，用户可以正常使用和上报数据
        /// </summary>
        /// <param name="req"><see cref="ResumeInstanceRequest"/></param>
        /// <returns><see cref="ResumeInstanceResponse"/></returns>
        public Task<ResumeInstanceResponse> ResumeInstance(ResumeInstanceRequest req)
        {
            return InternalRequestAsync<ResumeInstanceResponse>(req, "ResumeInstance");
        }

        /// <summary>
        /// 恢复 RUM 业务系统，恢复后，用户可以正常使用和上报数据
        /// </summary>
        /// <param name="req"><see cref="ResumeInstanceRequest"/></param>
        /// <returns><see cref="ResumeInstanceResponse"/></returns>
        public ResumeInstanceResponse ResumeInstanceSync(ResumeInstanceRequest req)
        {
            return InternalRequestAsync<ResumeInstanceResponse>(req, "ResumeInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 恢复应用使用与上报数据
        /// </summary>
        /// <param name="req"><see cref="ResumeProjectRequest"/></param>
        /// <returns><see cref="ResumeProjectResponse"/></returns>
        public Task<ResumeProjectResponse> ResumeProject(ResumeProjectRequest req)
        {
            return InternalRequestAsync<ResumeProjectResponse>(req, "ResumeProject");
        }

        /// <summary>
        /// 恢复应用使用与上报数据
        /// </summary>
        /// <param name="req"><see cref="ResumeProjectRequest"/></param>
        /// <returns><see cref="ResumeProjectResponse"/></returns>
        public ResumeProjectResponse ResumeProjectSync(ResumeProjectRequest req)
        {
            return InternalRequestAsync<ResumeProjectResponse>(req, "ResumeProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止实例
        /// </summary>
        /// <param name="req"><see cref="StopInstanceRequest"/></param>
        /// <returns><see cref="StopInstanceResponse"/></returns>
        public Task<StopInstanceResponse> StopInstance(StopInstanceRequest req)
        {
            return InternalRequestAsync<StopInstanceResponse>(req, "StopInstance");
        }

        /// <summary>
        /// 停止实例
        /// </summary>
        /// <param name="req"><see cref="StopInstanceRequest"/></param>
        /// <returns><see cref="StopInstanceResponse"/></returns>
        public StopInstanceResponse StopInstanceSync(StopInstanceRequest req)
        {
            return InternalRequestAsync<StopInstanceResponse>(req, "StopInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 停止项目使用与上报数据
        /// </summary>
        /// <param name="req"><see cref="StopProjectRequest"/></param>
        /// <returns><see cref="StopProjectResponse"/></returns>
        public Task<StopProjectResponse> StopProject(StopProjectRequest req)
        {
            return InternalRequestAsync<StopProjectResponse>(req, "StopProject");
        }

        /// <summary>
        /// 停止项目使用与上报数据
        /// </summary>
        /// <param name="req"><see cref="StopProjectRequest"/></param>
        /// <returns><see cref="StopProjectResponse"/></returns>
        public StopProjectResponse StopProjectSync(StopProjectRequest req)
        {
            return InternalRequestAsync<StopProjectResponse>(req, "StopProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}

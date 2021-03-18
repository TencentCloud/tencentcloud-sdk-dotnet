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

namespace TencentCloud.Ecdn.V20191012
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ecdn.V20191012.Models;

   public class EcdnClient : AbstractClient{

       private const string endpoint = "ecdn.tencentcloudapi.com";
       private const string version = "2019-10-12";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public EcdnClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public EcdnClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 本接口（AddEcdnDomain）用于创建加速域名。
        /// </summary>
        /// <param name="req"><see cref="AddEcdnDomainRequest"/></param>
        /// <returns><see cref="AddEcdnDomainResponse"/></returns>
        public async Task<AddEcdnDomainResponse> AddEcdnDomain(AddEcdnDomainRequest req)
        {
             JsonResponseModel<AddEcdnDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddEcdnDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddEcdnDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（AddEcdnDomain）用于创建加速域名。
        /// </summary>
        /// <param name="req"><see cref="AddEcdnDomainRequest"/></param>
        /// <returns><see cref="AddEcdnDomainResponse"/></returns>
        public AddEcdnDomainResponse AddEcdnDomainSync(AddEcdnDomainRequest req)
        {
             JsonResponseModel<AddEcdnDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddEcdnDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddEcdnDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteEcdnDomain）用于删除指定加速域名。待删除域名必须处于已停用状态。
        /// </summary>
        /// <param name="req"><see cref="DeleteEcdnDomainRequest"/></param>
        /// <returns><see cref="DeleteEcdnDomainResponse"/></returns>
        public async Task<DeleteEcdnDomainResponse> DeleteEcdnDomain(DeleteEcdnDomainRequest req)
        {
             JsonResponseModel<DeleteEcdnDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteEcdnDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEcdnDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteEcdnDomain）用于删除指定加速域名。待删除域名必须处于已停用状态。
        /// </summary>
        /// <param name="req"><see cref="DeleteEcdnDomainRequest"/></param>
        /// <returns><see cref="DeleteEcdnDomainResponse"/></returns>
        public DeleteEcdnDomainResponse DeleteEcdnDomainSync(DeleteEcdnDomainRequest req)
        {
             JsonResponseModel<DeleteEcdnDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteEcdnDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEcdnDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDomains）用于查询CDN域名基本信息，包括项目id，状态，业务类型，创建时间，更新时间等。
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainsRequest"/></param>
        /// <returns><see cref="DescribeDomainsResponse"/></returns>
        public async Task<DescribeDomainsResponse> DescribeDomains(DescribeDomainsRequest req)
        {
             JsonResponseModel<DescribeDomainsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDomains）用于查询CDN域名基本信息，包括项目id，状态，业务类型，创建时间，更新时间等。
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainsRequest"/></param>
        /// <returns><see cref="DescribeDomainsResponse"/></returns>
        public DescribeDomainsResponse DescribeDomainsSync(DescribeDomainsRequest req)
        {
             JsonResponseModel<DescribeDomainsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDomains");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDomainsConfig）用于查询CDN加速域名详细配置信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainsConfigRequest"/></param>
        /// <returns><see cref="DescribeDomainsConfigResponse"/></returns>
        public async Task<DescribeDomainsConfigResponse> DescribeDomainsConfig(DescribeDomainsConfigRequest req)
        {
             JsonResponseModel<DescribeDomainsConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDomainsConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainsConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeDomainsConfig）用于查询CDN加速域名详细配置信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainsConfigRequest"/></param>
        /// <returns><see cref="DescribeDomainsConfigResponse"/></returns>
        public DescribeDomainsConfigResponse DescribeDomainsConfigSync(DescribeDomainsConfigRequest req)
        {
             JsonResponseModel<DescribeDomainsConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDomainsConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainsConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeEcdnDomainLogs）用于查询域名的访问日志下载地址。
        /// </summary>
        /// <param name="req"><see cref="DescribeEcdnDomainLogsRequest"/></param>
        /// <returns><see cref="DescribeEcdnDomainLogsResponse"/></returns>
        public async Task<DescribeEcdnDomainLogsResponse> DescribeEcdnDomainLogs(DescribeEcdnDomainLogsRequest req)
        {
             JsonResponseModel<DescribeEcdnDomainLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEcdnDomainLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEcdnDomainLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeEcdnDomainLogs）用于查询域名的访问日志下载地址。
        /// </summary>
        /// <param name="req"><see cref="DescribeEcdnDomainLogsRequest"/></param>
        /// <returns><see cref="DescribeEcdnDomainLogsResponse"/></returns>
        public DescribeEcdnDomainLogsResponse DescribeEcdnDomainLogsSync(DescribeEcdnDomainLogsRequest req)
        {
             JsonResponseModel<DescribeEcdnDomainLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEcdnDomainLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEcdnDomainLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeEcdnDomainStatistics）用于查询指定时间段内的域名访问统计指标
        /// </summary>
        /// <param name="req"><see cref="DescribeEcdnDomainStatisticsRequest"/></param>
        /// <returns><see cref="DescribeEcdnDomainStatisticsResponse"/></returns>
        public async Task<DescribeEcdnDomainStatisticsResponse> DescribeEcdnDomainStatistics(DescribeEcdnDomainStatisticsRequest req)
        {
             JsonResponseModel<DescribeEcdnDomainStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEcdnDomainStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEcdnDomainStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeEcdnDomainStatistics）用于查询指定时间段内的域名访问统计指标
        /// </summary>
        /// <param name="req"><see cref="DescribeEcdnDomainStatisticsRequest"/></param>
        /// <returns><see cref="DescribeEcdnDomainStatisticsResponse"/></returns>
        public DescribeEcdnDomainStatisticsResponse DescribeEcdnDomainStatisticsSync(DescribeEcdnDomainStatisticsRequest req)
        {
             JsonResponseModel<DescribeEcdnDomainStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEcdnDomainStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEcdnDomainStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeEcdnStatistics用于查询 ECDN 实时访问监控数据，支持以下指标查询：
        /// 
        /// + 流量（单位为 byte）
        /// + 带宽（单位为 bps）
        /// + 请求数（单位为 次）
        /// + 状态码 2xx 汇总及各 2 开头状态码明细（单位为 个）
        /// + 状态码 3xx 汇总及各 3 开头状态码明细（单位为 个）
        /// + 状态码 4xx 汇总及各 4 开头状态码明细（单位为 个）
        /// + 状态码 5xx 汇总及各 5 开头状态码明细（单位为 个）
        /// </summary>
        /// <param name="req"><see cref="DescribeEcdnStatisticsRequest"/></param>
        /// <returns><see cref="DescribeEcdnStatisticsResponse"/></returns>
        public async Task<DescribeEcdnStatisticsResponse> DescribeEcdnStatistics(DescribeEcdnStatisticsRequest req)
        {
             JsonResponseModel<DescribeEcdnStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEcdnStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEcdnStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeEcdnStatistics用于查询 ECDN 实时访问监控数据，支持以下指标查询：
        /// 
        /// + 流量（单位为 byte）
        /// + 带宽（单位为 bps）
        /// + 请求数（单位为 次）
        /// + 状态码 2xx 汇总及各 2 开头状态码明细（单位为 个）
        /// + 状态码 3xx 汇总及各 3 开头状态码明细（单位为 个）
        /// + 状态码 4xx 汇总及各 4 开头状态码明细（单位为 个）
        /// + 状态码 5xx 汇总及各 5 开头状态码明细（单位为 个）
        /// </summary>
        /// <param name="req"><see cref="DescribeEcdnStatisticsRequest"/></param>
        /// <returns><see cref="DescribeEcdnStatisticsResponse"/></returns>
        public DescribeEcdnStatisticsResponse DescribeEcdnStatisticsSync(DescribeEcdnStatisticsRequest req)
        {
             JsonResponseModel<DescribeEcdnStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEcdnStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEcdnStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeIpStatus 用于查询域名所在加速平台的所有节点明细。
        /// </summary>
        /// <param name="req"><see cref="DescribeIpStatusRequest"/></param>
        /// <returns><see cref="DescribeIpStatusResponse"/></returns>
        public async Task<DescribeIpStatusResponse> DescribeIpStatus(DescribeIpStatusRequest req)
        {
             JsonResponseModel<DescribeIpStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIpStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIpStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeIpStatus 用于查询域名所在加速平台的所有节点明细。
        /// </summary>
        /// <param name="req"><see cref="DescribeIpStatusRequest"/></param>
        /// <returns><see cref="DescribeIpStatusResponse"/></returns>
        public DescribeIpStatusResponse DescribeIpStatusSync(DescribeIpStatusRequest req)
        {
             JsonResponseModel<DescribeIpStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIpStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIpStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询刷新接口的用量配额。
        /// </summary>
        /// <param name="req"><see cref="DescribePurgeQuotaRequest"/></param>
        /// <returns><see cref="DescribePurgeQuotaResponse"/></returns>
        public async Task<DescribePurgeQuotaResponse> DescribePurgeQuota(DescribePurgeQuotaRequest req)
        {
             JsonResponseModel<DescribePurgeQuotaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePurgeQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePurgeQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询刷新接口的用量配额。
        /// </summary>
        /// <param name="req"><see cref="DescribePurgeQuotaRequest"/></param>
        /// <returns><see cref="DescribePurgeQuotaResponse"/></returns>
        public DescribePurgeQuotaResponse DescribePurgeQuotaSync(DescribePurgeQuotaRequest req)
        {
             JsonResponseModel<DescribePurgeQuotaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePurgeQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePurgeQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribePurgeTasks 用于查询刷新任务提交历史记录及执行进度。
        /// </summary>
        /// <param name="req"><see cref="DescribePurgeTasksRequest"/></param>
        /// <returns><see cref="DescribePurgeTasksResponse"/></returns>
        public async Task<DescribePurgeTasksResponse> DescribePurgeTasks(DescribePurgeTasksRequest req)
        {
             JsonResponseModel<DescribePurgeTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePurgeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePurgeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribePurgeTasks 用于查询刷新任务提交历史记录及执行进度。
        /// </summary>
        /// <param name="req"><see cref="DescribePurgeTasksRequest"/></param>
        /// <returns><see cref="DescribePurgeTasksResponse"/></returns>
        public DescribePurgeTasksResponse DescribePurgeTasksSync(DescribePurgeTasksRequest req)
        {
             JsonResponseModel<DescribePurgeTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePurgeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePurgeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// PurgePathCache 用于批量刷新目录缓存，一次提交将返回一个刷新任务id。
        /// </summary>
        /// <param name="req"><see cref="PurgePathCacheRequest"/></param>
        /// <returns><see cref="PurgePathCacheResponse"/></returns>
        public async Task<PurgePathCacheResponse> PurgePathCache(PurgePathCacheRequest req)
        {
             JsonResponseModel<PurgePathCacheResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PurgePathCache");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PurgePathCacheResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// PurgePathCache 用于批量刷新目录缓存，一次提交将返回一个刷新任务id。
        /// </summary>
        /// <param name="req"><see cref="PurgePathCacheRequest"/></param>
        /// <returns><see cref="PurgePathCacheResponse"/></returns>
        public PurgePathCacheResponse PurgePathCacheSync(PurgePathCacheRequest req)
        {
             JsonResponseModel<PurgePathCacheResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PurgePathCache");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PurgePathCacheResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// PurgeUrlsCache 用于批量刷新Url，一次提交将返回一个刷新任务id。
        /// </summary>
        /// <param name="req"><see cref="PurgeUrlsCacheRequest"/></param>
        /// <returns><see cref="PurgeUrlsCacheResponse"/></returns>
        public async Task<PurgeUrlsCacheResponse> PurgeUrlsCache(PurgeUrlsCacheRequest req)
        {
             JsonResponseModel<PurgeUrlsCacheResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PurgeUrlsCache");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PurgeUrlsCacheResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// PurgeUrlsCache 用于批量刷新Url，一次提交将返回一个刷新任务id。
        /// </summary>
        /// <param name="req"><see cref="PurgeUrlsCacheRequest"/></param>
        /// <returns><see cref="PurgeUrlsCacheResponse"/></returns>
        public PurgeUrlsCacheResponse PurgeUrlsCacheSync(PurgeUrlsCacheRequest req)
        {
             JsonResponseModel<PurgeUrlsCacheResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PurgeUrlsCache");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PurgeUrlsCacheResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（StartEcdnDomain）用于启用加速域名，待启用域名必须处于已下线状态。
        /// </summary>
        /// <param name="req"><see cref="StartEcdnDomainRequest"/></param>
        /// <returns><see cref="StartEcdnDomainResponse"/></returns>
        public async Task<StartEcdnDomainResponse> StartEcdnDomain(StartEcdnDomainRequest req)
        {
             JsonResponseModel<StartEcdnDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartEcdnDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartEcdnDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（StartEcdnDomain）用于启用加速域名，待启用域名必须处于已下线状态。
        /// </summary>
        /// <param name="req"><see cref="StartEcdnDomainRequest"/></param>
        /// <returns><see cref="StartEcdnDomainResponse"/></returns>
        public StartEcdnDomainResponse StartEcdnDomainSync(StartEcdnDomainRequest req)
        {
             JsonResponseModel<StartEcdnDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartEcdnDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartEcdnDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（StopCdnDomain）用于停止加速域名，待停用加速域名必须处于已上线或部署中状态。
        /// </summary>
        /// <param name="req"><see cref="StopEcdnDomainRequest"/></param>
        /// <returns><see cref="StopEcdnDomainResponse"/></returns>
        public async Task<StopEcdnDomainResponse> StopEcdnDomain(StopEcdnDomainRequest req)
        {
             JsonResponseModel<StopEcdnDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopEcdnDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopEcdnDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（StopCdnDomain）用于停止加速域名，待停用加速域名必须处于已上线或部署中状态。
        /// </summary>
        /// <param name="req"><see cref="StopEcdnDomainRequest"/></param>
        /// <returns><see cref="StopEcdnDomainResponse"/></returns>
        public StopEcdnDomainResponse StopEcdnDomainSync(StopEcdnDomainRequest req)
        {
             JsonResponseModel<StopEcdnDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopEcdnDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopEcdnDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateDomainConfig）用于更新ECDN加速域名配置信息。
        /// 注意：如果需要更新复杂类型的配置项，必须传递整个对象的所有属性，未传递的属性将使用默认值。建议通过查询接口获取配置属性后，直接修改后传递给本接口。Https配置由于证书的特殊性，更新时不用传递证书和密钥字段。
        /// </summary>
        /// <param name="req"><see cref="UpdateDomainConfigRequest"/></param>
        /// <returns><see cref="UpdateDomainConfigResponse"/></returns>
        public async Task<UpdateDomainConfigResponse> UpdateDomainConfig(UpdateDomainConfigRequest req)
        {
             JsonResponseModel<UpdateDomainConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateDomainConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDomainConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateDomainConfig）用于更新ECDN加速域名配置信息。
        /// 注意：如果需要更新复杂类型的配置项，必须传递整个对象的所有属性，未传递的属性将使用默认值。建议通过查询接口获取配置属性后，直接修改后传递给本接口。Https配置由于证书的特殊性，更新时不用传递证书和密钥字段。
        /// </summary>
        /// <param name="req"><see cref="UpdateDomainConfigRequest"/></param>
        /// <returns><see cref="UpdateDomainConfigResponse"/></returns>
        public UpdateDomainConfigResponse UpdateDomainConfigSync(UpdateDomainConfigRequest req)
        {
             JsonResponseModel<UpdateDomainConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateDomainConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateDomainConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}

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

namespace TencentCloud.Cdn.V20180606
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cdn.V20180606.Models;

   public class CdnClient : AbstractClient{

       private const string endpoint = "cdn.tencentcloudapi.com";
       private const string version = "2018-06-06";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CdnClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CdnClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// DescribeCdnData 用于查询 CDN 实时访问监控数据，支持以下指标查询：
        /// 
        /// + 流量（单位为 byte）
        /// + 带宽（单位为 bps）
        /// + 请求数（单位为 次）
        /// + 流量命中率（单位为 %，小数点后保留两位）
        /// + 状态码 2xx 汇总及各 2 开头状态码明细（单位为 个）
        /// + 状态码 3xx 汇总及各 3 开头状态码明细（单位为 个）
        /// + 状态码 4xx 汇总及各 4 开头状态码明细（单位为 个）
        /// + 状态码 5xx 汇总及各 5 开头状态码明细（单位为 个）
        /// </summary>
        /// <param name="req"><see cref="DescribeCdnDataRequest"/></param>
        /// <returns><see cref="DescribeCdnDataResponse"/></returns>
        public async Task<DescribeCdnDataResponse> DescribeCdnData(DescribeCdnDataRequest req)
        {
             JsonResponseModel<DescribeCdnDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCdnData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCdnDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeCdnData接口的同步版本，DescribeCdnData 用于查询 CDN 实时访问监控数据，支持以下指标查询：
        /// 
        /// + 流量（单位为 byte）
        /// + 带宽（单位为 bps）
        /// + 请求数（单位为 次）
        /// + 流量命中率（单位为 %，小数点后保留两位）
        /// + 状态码 2xx 汇总及各 2 开头状态码明细（单位为 个）
        /// + 状态码 3xx 汇总及各 3 开头状态码明细（单位为 个）
        /// + 状态码 4xx 汇总及各 4 开头状态码明细（单位为 个）
        /// + 状态码 5xx 汇总及各 5 开头状态码明细（单位为 个）
        /// </summary>
        /// <param name="req">参考<see cref="DescribeCdnDataRequest"/></param>
        /// <returns>参考<see cref="DescribeCdnDataResponse"/>实例</returns>
        public DescribeCdnDataResponse DescribeCdnDataSync(DescribeCdnDataRequest req)
        {
             JsonResponseModel<DescribeCdnDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCdnData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCdnDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeCdnDomainLogs 用于查询访问日志下载地址，仅支持 30 天以内的境内、境外访问日志下载链接查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeCdnDomainLogsRequest"/></param>
        /// <returns><see cref="DescribeCdnDomainLogsResponse"/></returns>
        public async Task<DescribeCdnDomainLogsResponse> DescribeCdnDomainLogs(DescribeCdnDomainLogsRequest req)
        {
             JsonResponseModel<DescribeCdnDomainLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCdnDomainLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCdnDomainLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeCdnDomainLogs接口的同步版本，DescribeCdnDomainLogs 用于查询访问日志下载地址，仅支持 30 天以内的境内、境外访问日志下载链接查询。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeCdnDomainLogsRequest"/></param>
        /// <returns>参考<see cref="DescribeCdnDomainLogsResponse"/>实例</returns>
        public DescribeCdnDomainLogsResponse DescribeCdnDomainLogsSync(DescribeCdnDomainLogsRequest req)
        {
             JsonResponseModel<DescribeCdnDomainLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCdnDomainLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCdnDomainLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeCdnIp 用于查询 CDN IP 归属。
        /// </summary>
        /// <param name="req"><see cref="DescribeCdnIpRequest"/></param>
        /// <returns><see cref="DescribeCdnIpResponse"/></returns>
        public async Task<DescribeCdnIpResponse> DescribeCdnIp(DescribeCdnIpRequest req)
        {
             JsonResponseModel<DescribeCdnIpResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCdnIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCdnIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeCdnIp接口的同步版本，DescribeCdnIp 用于查询 CDN IP 归属。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeCdnIpRequest"/></param>
        /// <returns>参考<see cref="DescribeCdnIpResponse"/>实例</returns>
        public DescribeCdnIpResponse DescribeCdnIpSync(DescribeCdnIpRequest req)
        {
             JsonResponseModel<DescribeCdnIpResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCdnIp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCdnIpResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeIpVisit 用于查询 5 分钟活跃用户数，及日活跃用户数明细
        /// 
        /// + 5 分钟活跃用户数：根据日志中客户端 IP，5 分钟粒度去重统计
        /// + 日活跃用户数：根据日志中客户端 IP，按天粒度去重统计
        /// </summary>
        /// <param name="req"><see cref="DescribeIpVisitRequest"/></param>
        /// <returns><see cref="DescribeIpVisitResponse"/></returns>
        public async Task<DescribeIpVisitResponse> DescribeIpVisit(DescribeIpVisitRequest req)
        {
             JsonResponseModel<DescribeIpVisitResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeIpVisit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIpVisitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeIpVisit接口的同步版本，DescribeIpVisit 用于查询 5 分钟活跃用户数，及日活跃用户数明细
        /// 
        /// + 5 分钟活跃用户数：根据日志中客户端 IP，5 分钟粒度去重统计
        /// + 日活跃用户数：根据日志中客户端 IP，按天粒度去重统计
        /// </summary>
        /// <param name="req">参考<see cref="DescribeIpVisitRequest"/></param>
        /// <returns>参考<see cref="DescribeIpVisitResponse"/>实例</returns>
        public DescribeIpVisitResponse DescribeIpVisitSync(DescribeIpVisitRequest req)
        {
             JsonResponseModel<DescribeIpVisitResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeIpVisit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeIpVisitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeMapInfo 用于查询省份对应的 ID，运营商对应的 ID 信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeMapInfoRequest"/></param>
        /// <returns><see cref="DescribeMapInfoResponse"/></returns>
        public async Task<DescribeMapInfoResponse> DescribeMapInfo(DescribeMapInfoRequest req)
        {
             JsonResponseModel<DescribeMapInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMapInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMapInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeMapInfo接口的同步版本，DescribeMapInfo 用于查询省份对应的 ID，运营商对应的 ID 信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeMapInfoRequest"/></param>
        /// <returns>参考<see cref="DescribeMapInfoResponse"/>实例</returns>
        public DescribeMapInfoResponse DescribeMapInfoSync(DescribeMapInfoRequest req)
        {
             JsonResponseModel<DescribeMapInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMapInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMapInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeOriginData 用于查询 CDN 实时回源监控数据，支持以下指标查询：
        /// 
        /// + 回源流量（单位为 byte）
        /// + 回源带宽（单位为 bps）
        /// + 回源请求数（单位为 次）
        /// + 回源失败请求数（单位为 次）
        /// + 回源失败率（单位为 %，小数点后保留两位）
        /// + 回源状态码 2xx 汇总及各 2 开头回源状态码明细（单位为 个）
        /// + 回源状态码 3xx 汇总及各 3 开头回源状态码明细（单位为 个）
        /// + 回源状态码 4xx 汇总及各 4 开头回源状态码明细（单位为 个）
        /// + 回源状态码 5xx 汇总及各 5 开头回源状态码明细（单位为 个）
        /// </summary>
        /// <param name="req"><see cref="DescribeOriginDataRequest"/></param>
        /// <returns><see cref="DescribeOriginDataResponse"/></returns>
        public async Task<DescribeOriginDataResponse> DescribeOriginData(DescribeOriginDataRequest req)
        {
             JsonResponseModel<DescribeOriginDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOriginData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOriginDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeOriginData接口的同步版本，DescribeOriginData 用于查询 CDN 实时回源监控数据，支持以下指标查询：
        /// 
        /// + 回源流量（单位为 byte）
        /// + 回源带宽（单位为 bps）
        /// + 回源请求数（单位为 次）
        /// + 回源失败请求数（单位为 次）
        /// + 回源失败率（单位为 %，小数点后保留两位）
        /// + 回源状态码 2xx 汇总及各 2 开头回源状态码明细（单位为 个）
        /// + 回源状态码 3xx 汇总及各 3 开头回源状态码明细（单位为 个）
        /// + 回源状态码 4xx 汇总及各 4 开头回源状态码明细（单位为 个）
        /// + 回源状态码 5xx 汇总及各 5 开头回源状态码明细（单位为 个）
        /// </summary>
        /// <param name="req">参考<see cref="DescribeOriginDataRequest"/></param>
        /// <returns>参考<see cref="DescribeOriginDataResponse"/>实例</returns>
        public DescribeOriginDataResponse DescribeOriginDataSync(DescribeOriginDataRequest req)
        {
             JsonResponseModel<DescribeOriginDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOriginData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOriginDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribePayType 用于查询用户的计费类型，计费周期等信息。
        /// </summary>
        /// <param name="req"><see cref="DescribePayTypeRequest"/></param>
        /// <returns><see cref="DescribePayTypeResponse"/></returns>
        public async Task<DescribePayTypeResponse> DescribePayType(DescribePayTypeRequest req)
        {
             JsonResponseModel<DescribePayTypeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePayType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePayTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribePayType接口的同步版本，DescribePayType 用于查询用户的计费类型，计费周期等信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribePayTypeRequest"/></param>
        /// <returns>参考<see cref="DescribePayTypeResponse"/>实例</returns>
        public DescribePayTypeResponse DescribePayTypeSync(DescribePayTypeRequest req)
        {
             JsonResponseModel<DescribePayTypeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePayType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePayTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribePurgeTasks 用于查询提交的 URL 刷新、目录刷新记录及执行进度，通过 PurgePathCache 与 PurgeUrlsCache 接口提交的任务均可通过此接口进行查询。
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
        /// DescribePurgeTasks接口的同步版本，DescribePurgeTasks 用于查询提交的 URL 刷新、目录刷新记录及执行进度，通过 PurgePathCache 与 PurgeUrlsCache 接口提交的任务均可通过此接口进行查询。
        /// </summary>
        /// <param name="req">参考<see cref="DescribePurgeTasksRequest"/></param>
        /// <returns>参考<see cref="DescribePurgeTasksResponse"/>实例</returns>
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
        /// DescribePushTasks  用于查询预热任务提交历史记录及执行进度。
        /// 接口灰度中，暂未全量开放，敬请期待。
        /// </summary>
        /// <param name="req"><see cref="DescribePushTasksRequest"/></param>
        /// <returns><see cref="DescribePushTasksResponse"/></returns>
        public async Task<DescribePushTasksResponse> DescribePushTasks(DescribePushTasksRequest req)
        {
             JsonResponseModel<DescribePushTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePushTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePushTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribePushTasks接口的同步版本，DescribePushTasks  用于查询预热任务提交历史记录及执行进度。
        /// 接口灰度中，暂未全量开放，敬请期待。
        /// </summary>
        /// <param name="req">参考<see cref="DescribePushTasksRequest"/></param>
        /// <returns>参考<see cref="DescribePushTasksResponse"/>实例</returns>
        public DescribePushTasksResponse DescribePushTasksSync(DescribePushTasksRequest req)
        {
             JsonResponseModel<DescribePushTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePushTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePushTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeTrafficPackages 用于查询境内 CDN 流量包详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeTrafficPackagesRequest"/></param>
        /// <returns><see cref="DescribeTrafficPackagesResponse"/></returns>
        public async Task<DescribeTrafficPackagesResponse> DescribeTrafficPackages(DescribeTrafficPackagesRequest req)
        {
             JsonResponseModel<DescribeTrafficPackagesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTrafficPackages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrafficPackagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DescribeTrafficPackages接口的同步版本，DescribeTrafficPackages 用于查询境内 CDN 流量包详情。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTrafficPackagesRequest"/></param>
        /// <returns>参考<see cref="DescribeTrafficPackagesResponse"/>实例</returns>
        public DescribeTrafficPackagesResponse DescribeTrafficPackagesSync(DescribeTrafficPackagesRequest req)
        {
             JsonResponseModel<DescribeTrafficPackagesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTrafficPackages");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTrafficPackagesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DisableCaches 用于禁用 CDN 上指定 URL 的访问，禁用完成后，全网访问会直接返回 403。（接口尚在内测中，暂未全量开放使用）
        /// </summary>
        /// <param name="req"><see cref="DisableCachesRequest"/></param>
        /// <returns><see cref="DisableCachesResponse"/></returns>
        public async Task<DisableCachesResponse> DisableCaches(DisableCachesRequest req)
        {
             JsonResponseModel<DisableCachesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableCaches");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableCachesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// DisableCaches接口的同步版本，DisableCaches 用于禁用 CDN 上指定 URL 的访问，禁用完成后，全网访问会直接返回 403。（接口尚在内测中，暂未全量开放使用）
        /// </summary>
        /// <param name="req">参考<see cref="DisableCachesRequest"/></param>
        /// <returns>参考<see cref="DisableCachesResponse"/>实例</returns>
        public DisableCachesResponse DisableCachesSync(DisableCachesRequest req)
        {
             JsonResponseModel<DisableCachesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableCaches");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableCachesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// EnableCaches 用于解禁手工封禁的 URL，解禁成功后，全网生效时间约 5~10 分钟。（接口尚在内测中，暂未全量开放使用）
        /// </summary>
        /// <param name="req"><see cref="EnableCachesRequest"/></param>
        /// <returns><see cref="EnableCachesResponse"/></returns>
        public async Task<EnableCachesResponse> EnableCaches(EnableCachesRequest req)
        {
             JsonResponseModel<EnableCachesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableCaches");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableCachesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// EnableCaches接口的同步版本，EnableCaches 用于解禁手工封禁的 URL，解禁成功后，全网生效时间约 5~10 分钟。（接口尚在内测中，暂未全量开放使用）
        /// </summary>
        /// <param name="req">参考<see cref="EnableCachesRequest"/></param>
        /// <returns>参考<see cref="EnableCachesResponse"/>实例</returns>
        public EnableCachesResponse EnableCachesSync(EnableCachesRequest req)
        {
             JsonResponseModel<EnableCachesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableCaches");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableCachesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// GetDisableRecords 用户查询资源禁用历史，及 URL 当前状态。（接口尚在内测中，暂未全量开放使用）
        /// </summary>
        /// <param name="req"><see cref="GetDisableRecordsRequest"/></param>
        /// <returns><see cref="GetDisableRecordsResponse"/></returns>
        public async Task<GetDisableRecordsResponse> GetDisableRecords(GetDisableRecordsRequest req)
        {
             JsonResponseModel<GetDisableRecordsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetDisableRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDisableRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// GetDisableRecords接口的同步版本，GetDisableRecords 用户查询资源禁用历史，及 URL 当前状态。（接口尚在内测中，暂未全量开放使用）
        /// </summary>
        /// <param name="req">参考<see cref="GetDisableRecordsRequest"/></param>
        /// <returns>参考<see cref="GetDisableRecordsResponse"/>实例</returns>
        public GetDisableRecordsResponse GetDisableRecordsSync(GetDisableRecordsRequest req)
        {
             JsonResponseModel<GetDisableRecordsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetDisableRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDisableRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ListTopData 通过入参 Metric 和 Filter 组合不同，可以查询以下排序数据：
        /// 
        /// + 依据总流量、总请求数对访问 URL 排序，从大至小返回 TOP 1000 URL
        /// + 依据总流量、总请求数对客户端省份排序，从大至小返回省份列表
        /// + 依据总流量、总请求数对客户端运营商排序，从大至小返回运营商列表
        /// + 依据总流量、峰值带宽、总请求数、平均命中率、2XX/3XX/4XX/5XX 状态码对域名排序，从大至小返回域名列表
        /// + 依据总回源流量、回源峰值带宽、总回源请求数、平均回源失败率、2XX/3XX/4XX/5XX 回源状态码对域名排序，从大至小返回域名列表
        /// </summary>
        /// <param name="req"><see cref="ListTopDataRequest"/></param>
        /// <returns><see cref="ListTopDataResponse"/></returns>
        public async Task<ListTopDataResponse> ListTopData(ListTopDataRequest req)
        {
             JsonResponseModel<ListTopDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ListTopData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListTopDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// ListTopData接口的同步版本，ListTopData 通过入参 Metric 和 Filter 组合不同，可以查询以下排序数据：
        /// 
        /// + 依据总流量、总请求数对访问 URL 排序，从大至小返回 TOP 1000 URL
        /// + 依据总流量、总请求数对客户端省份排序，从大至小返回省份列表
        /// + 依据总流量、总请求数对客户端运营商排序，从大至小返回运营商列表
        /// + 依据总流量、峰值带宽、总请求数、平均命中率、2XX/3XX/4XX/5XX 状态码对域名排序，从大至小返回域名列表
        /// + 依据总回源流量、回源峰值带宽、总回源请求数、平均回源失败率、2XX/3XX/4XX/5XX 回源状态码对域名排序，从大至小返回域名列表
        /// </summary>
        /// <param name="req">参考<see cref="ListTopDataRequest"/></param>
        /// <returns>参考<see cref="ListTopDataResponse"/>实例</returns>
        public ListTopDataResponse ListTopDataSync(ListTopDataRequest req)
        {
             JsonResponseModel<ListTopDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ListTopData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ListTopDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// PurgePathCache 用于批量提交目录刷新，根据域名的加速区域进行对应区域的刷新。
        /// 默认情况下境内、境外加速区域每日目录刷新额度为各 100 条，每次最多可提交 20 条。
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
        /// PurgePathCache接口的同步版本，PurgePathCache 用于批量提交目录刷新，根据域名的加速区域进行对应区域的刷新。
        /// 默认情况下境内、境外加速区域每日目录刷新额度为各 100 条，每次最多可提交 20 条。
        /// </summary>
        /// <param name="req">参考<see cref="PurgePathCacheRequest"/></param>
        /// <returns>参考<see cref="PurgePathCacheResponse"/>实例</returns>
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
        /// PurgeUrlsCache 用于批量提交 URL 进行刷新，根据 URL 中域名的当前加速区域进行对应区域的刷新。
        /// 默认情况下境内、境外加速区域每日 URL 刷新额度各为 10000 条，每次最多可提交 1000 条。
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
        /// PurgeUrlsCache接口的同步版本，PurgeUrlsCache 用于批量提交 URL 进行刷新，根据 URL 中域名的当前加速区域进行对应区域的刷新。
        /// 默认情况下境内、境外加速区域每日 URL 刷新额度各为 10000 条，每次最多可提交 1000 条。
        /// </summary>
        /// <param name="req">参考<see cref="PurgeUrlsCacheRequest"/></param>
        /// <returns>参考<see cref="PurgeUrlsCacheResponse"/>实例</returns>
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
        /// PushUrlsCache 用于将指定 URL 资源列表加载至 CDN 节点，支持指定加速区域预热。
        /// 默认情况下境内、境外每日预热 URL 限额为各 1000 条，每次最多可提交 20 条。
        /// 接口灰度中，暂未全量开放，敬请期待。
        /// </summary>
        /// <param name="req"><see cref="PushUrlsCacheRequest"/></param>
        /// <returns><see cref="PushUrlsCacheResponse"/></returns>
        public async Task<PushUrlsCacheResponse> PushUrlsCache(PushUrlsCacheRequest req)
        {
             JsonResponseModel<PushUrlsCacheResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PushUrlsCache");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PushUrlsCacheResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// PushUrlsCache接口的同步版本，PushUrlsCache 用于将指定 URL 资源列表加载至 CDN 节点，支持指定加速区域预热。
        /// 默认情况下境内、境外每日预热 URL 限额为各 1000 条，每次最多可提交 20 条。
        /// 接口灰度中，暂未全量开放，敬请期待。
        /// </summary>
        /// <param name="req">参考<see cref="PushUrlsCacheRequest"/></param>
        /// <returns>参考<see cref="PushUrlsCacheResponse"/>实例</returns>
        public PushUrlsCacheResponse PushUrlsCacheSync(PushUrlsCacheRequest req)
        {
             JsonResponseModel<PushUrlsCacheResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PushUrlsCache");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PushUrlsCacheResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}

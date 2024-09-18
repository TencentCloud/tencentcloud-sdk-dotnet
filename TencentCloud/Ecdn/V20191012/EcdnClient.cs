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
       private const string sdkVersion = "SDK_NET_3.0.1090";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public EcdnClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// ECDN融合CDN后，接口都用CDN的，此接口已经废弃
        /// 
        /// 本接口（AddEcdnDomain）用于创建加速域名。
        /// 
        /// >?  若您的业务已迁移至 CDN 控制台，请参考<a href="https://cloud.tencent.com/document/api/228/41123"> CDN 接口文档</a>，使用  CDN 相关API 进行操作。
        /// </summary>
        /// <param name="req"><see cref="AddEcdnDomainRequest"/></param>
        /// <returns><see cref="AddEcdnDomainResponse"/></returns>
        public Task<AddEcdnDomainResponse> AddEcdnDomain(AddEcdnDomainRequest req)
        {
            return InternalRequestAsync<AddEcdnDomainResponse>(req, "AddEcdnDomain");
        }

        /// <summary>
        /// ECDN融合CDN后，接口都用CDN的，此接口已经废弃
        /// 
        /// 本接口（AddEcdnDomain）用于创建加速域名。
        /// 
        /// >?  若您的业务已迁移至 CDN 控制台，请参考<a href="https://cloud.tencent.com/document/api/228/41123"> CDN 接口文档</a>，使用  CDN 相关API 进行操作。
        /// </summary>
        /// <param name="req"><see cref="AddEcdnDomainRequest"/></param>
        /// <returns><see cref="AddEcdnDomainResponse"/></returns>
        public AddEcdnDomainResponse AddEcdnDomainSync(AddEcdnDomainRequest req)
        {
            return InternalRequestAsync<AddEcdnDomainResponse>(req, "AddEcdnDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ECDN融合CDN后，接口都用CDN的，此接口已经废弃
        /// 
        /// 生成一条子域名解析，提示客户添加到域名解析上，用于泛域名及域名取回校验归属权。
        /// 
        /// >?  若您的业务已迁移至 CDN 控制台，请参考<a href="	https://cloud.tencent.com/document/api/228/48118"> CDN 接口文档</a>，使用  CDN 相关API 进行操作。
        /// </summary>
        /// <param name="req"><see cref="CreateVerifyRecordRequest"/></param>
        /// <returns><see cref="CreateVerifyRecordResponse"/></returns>
        public Task<CreateVerifyRecordResponse> CreateVerifyRecord(CreateVerifyRecordRequest req)
        {
            return InternalRequestAsync<CreateVerifyRecordResponse>(req, "CreateVerifyRecord");
        }

        /// <summary>
        /// ECDN融合CDN后，接口都用CDN的，此接口已经废弃
        /// 
        /// 生成一条子域名解析，提示客户添加到域名解析上，用于泛域名及域名取回校验归属权。
        /// 
        /// >?  若您的业务已迁移至 CDN 控制台，请参考<a href="	https://cloud.tencent.com/document/api/228/48118"> CDN 接口文档</a>，使用  CDN 相关API 进行操作。
        /// </summary>
        /// <param name="req"><see cref="CreateVerifyRecordRequest"/></param>
        /// <returns><see cref="CreateVerifyRecordResponse"/></returns>
        public CreateVerifyRecordResponse CreateVerifyRecordSync(CreateVerifyRecordRequest req)
        {
            return InternalRequestAsync<CreateVerifyRecordResponse>(req, "CreateVerifyRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ECDN融合CDN后，接口都用CDN的，此接口已经废弃
        /// 
        /// 本接口（DeleteEcdnDomain）用于删除指定加速域名。待删除域名必须处于已停用状态。
        /// 
        /// >?  若您的业务已迁移至 CDN 控制台，请参考<a href="https://cloud.tencent.com/document/api/228/41122"> CDN 接口文档</a>，使用  CDN 相关API 进行操作。
        /// </summary>
        /// <param name="req"><see cref="DeleteEcdnDomainRequest"/></param>
        /// <returns><see cref="DeleteEcdnDomainResponse"/></returns>
        public Task<DeleteEcdnDomainResponse> DeleteEcdnDomain(DeleteEcdnDomainRequest req)
        {
            return InternalRequestAsync<DeleteEcdnDomainResponse>(req, "DeleteEcdnDomain");
        }

        /// <summary>
        /// ECDN融合CDN后，接口都用CDN的，此接口已经废弃
        /// 
        /// 本接口（DeleteEcdnDomain）用于删除指定加速域名。待删除域名必须处于已停用状态。
        /// 
        /// >?  若您的业务已迁移至 CDN 控制台，请参考<a href="https://cloud.tencent.com/document/api/228/41122"> CDN 接口文档</a>，使用  CDN 相关API 进行操作。
        /// </summary>
        /// <param name="req"><see cref="DeleteEcdnDomainRequest"/></param>
        /// <returns><see cref="DeleteEcdnDomainResponse"/></returns>
        public DeleteEcdnDomainResponse DeleteEcdnDomainSync(DeleteEcdnDomainRequest req)
        {
            return InternalRequestAsync<DeleteEcdnDomainResponse>(req, "DeleteEcdnDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDomains）用于查询CDN域名基本信息，包括项目id，状态，业务类型，创建时间，更新时间等。
        /// 
        /// >?  若您的业务已迁移至 CDN 控制台，请参考<a href="https://cloud.tencent.com/document/api/228/41118"> CDN 接口文档</a>，使用  CDN 相关API 进行操作。
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainsRequest"/></param>
        /// <returns><see cref="DescribeDomainsResponse"/></returns>
        public Task<DescribeDomainsResponse> DescribeDomains(DescribeDomainsRequest req)
        {
            return InternalRequestAsync<DescribeDomainsResponse>(req, "DescribeDomains");
        }

        /// <summary>
        /// 本接口（DescribeDomains）用于查询CDN域名基本信息，包括项目id，状态，业务类型，创建时间，更新时间等。
        /// 
        /// >?  若您的业务已迁移至 CDN 控制台，请参考<a href="https://cloud.tencent.com/document/api/228/41118"> CDN 接口文档</a>，使用  CDN 相关API 进行操作。
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainsRequest"/></param>
        /// <returns><see cref="DescribeDomainsResponse"/></returns>
        public DescribeDomainsResponse DescribeDomainsSync(DescribeDomainsRequest req)
        {
            return InternalRequestAsync<DescribeDomainsResponse>(req, "DescribeDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeDomainsConfig）用于查询CDN加速域名详细配置信息。
        /// 
        /// >?  若您的业务已迁移至 CDN 控制台，请参考<a href="https://cloud.tencent.com/document/api/228/41117"> CDN 接口文档</a>，使用  CDN 相关API 进行操作。
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainsConfigRequest"/></param>
        /// <returns><see cref="DescribeDomainsConfigResponse"/></returns>
        public Task<DescribeDomainsConfigResponse> DescribeDomainsConfig(DescribeDomainsConfigRequest req)
        {
            return InternalRequestAsync<DescribeDomainsConfigResponse>(req, "DescribeDomainsConfig");
        }

        /// <summary>
        /// 本接口（DescribeDomainsConfig）用于查询CDN加速域名详细配置信息。
        /// 
        /// >?  若您的业务已迁移至 CDN 控制台，请参考<a href="https://cloud.tencent.com/document/api/228/41117"> CDN 接口文档</a>，使用  CDN 相关API 进行操作。
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainsConfigRequest"/></param>
        /// <returns><see cref="DescribeDomainsConfigResponse"/></returns>
        public DescribeDomainsConfigResponse DescribeDomainsConfigSync(DescribeDomainsConfigRequest req)
        {
            return InternalRequestAsync<DescribeDomainsConfigResponse>(req, "DescribeDomainsConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeEcdnDomainLogs）用于查询域名的访问日志下载地址。
        /// </summary>
        /// <param name="req"><see cref="DescribeEcdnDomainLogsRequest"/></param>
        /// <returns><see cref="DescribeEcdnDomainLogsResponse"/></returns>
        public Task<DescribeEcdnDomainLogsResponse> DescribeEcdnDomainLogs(DescribeEcdnDomainLogsRequest req)
        {
            return InternalRequestAsync<DescribeEcdnDomainLogsResponse>(req, "DescribeEcdnDomainLogs");
        }

        /// <summary>
        /// 本接口（DescribeEcdnDomainLogs）用于查询域名的访问日志下载地址。
        /// </summary>
        /// <param name="req"><see cref="DescribeEcdnDomainLogsRequest"/></param>
        /// <returns><see cref="DescribeEcdnDomainLogsResponse"/></returns>
        public DescribeEcdnDomainLogsResponse DescribeEcdnDomainLogsSync(DescribeEcdnDomainLogsRequest req)
        {
            return InternalRequestAsync<DescribeEcdnDomainLogsResponse>(req, "DescribeEcdnDomainLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeEcdnDomainStatistics）用于查询指定时间段内的域名访问统计指标。
        /// 
        /// >?  若您的业务已迁移至 CDN 控制台，请参考<a href="https://cloud.tencent.com/document/api/228/30986"> CDN 接口文档</a>，使用  CDN 相关API 进行操作。
        /// </summary>
        /// <param name="req"><see cref="DescribeEcdnDomainStatisticsRequest"/></param>
        /// <returns><see cref="DescribeEcdnDomainStatisticsResponse"/></returns>
        public Task<DescribeEcdnDomainStatisticsResponse> DescribeEcdnDomainStatistics(DescribeEcdnDomainStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeEcdnDomainStatisticsResponse>(req, "DescribeEcdnDomainStatistics");
        }

        /// <summary>
        /// 本接口（DescribeEcdnDomainStatistics）用于查询指定时间段内的域名访问统计指标。
        /// 
        /// >?  若您的业务已迁移至 CDN 控制台，请参考<a href="https://cloud.tencent.com/document/api/228/30986"> CDN 接口文档</a>，使用  CDN 相关API 进行操作。
        /// </summary>
        /// <param name="req"><see cref="DescribeEcdnDomainStatisticsRequest"/></param>
        /// <returns><see cref="DescribeEcdnDomainStatisticsResponse"/></returns>
        public DescribeEcdnDomainStatisticsResponse DescribeEcdnDomainStatisticsSync(DescribeEcdnDomainStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeEcdnDomainStatisticsResponse>(req, "DescribeEcdnDomainStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        public Task<DescribeEcdnStatisticsResponse> DescribeEcdnStatistics(DescribeEcdnStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeEcdnStatisticsResponse>(req, "DescribeEcdnStatistics");
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
            return InternalRequestAsync<DescribeEcdnStatisticsResponse>(req, "DescribeEcdnStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeIpStatus 用于查询域名所在加速平台的所有节点信息, 如果您的源站有白名单设置,可以通过本接口获取ECDN服务的节点IP进行加白, 本接口为内测接口,请联系腾讯云工程师开白。
        /// 
        /// 由于产品服务节点常有更新，对于源站开白的使用场景，请定期调用接口获取最新节点信息，若新增服务节点发布7日后您尚未更新加白导致回源失败等问题，ECDN侧不对此承担责任。
        /// </summary>
        /// <param name="req"><see cref="DescribeIpStatusRequest"/></param>
        /// <returns><see cref="DescribeIpStatusResponse"/></returns>
        public Task<DescribeIpStatusResponse> DescribeIpStatus(DescribeIpStatusRequest req)
        {
            return InternalRequestAsync<DescribeIpStatusResponse>(req, "DescribeIpStatus");
        }

        /// <summary>
        /// DescribeIpStatus 用于查询域名所在加速平台的所有节点信息, 如果您的源站有白名单设置,可以通过本接口获取ECDN服务的节点IP进行加白, 本接口为内测接口,请联系腾讯云工程师开白。
        /// 
        /// 由于产品服务节点常有更新，对于源站开白的使用场景，请定期调用接口获取最新节点信息，若新增服务节点发布7日后您尚未更新加白导致回源失败等问题，ECDN侧不对此承担责任。
        /// </summary>
        /// <param name="req"><see cref="DescribeIpStatusRequest"/></param>
        /// <returns><see cref="DescribeIpStatusResponse"/></returns>
        public DescribeIpStatusResponse DescribeIpStatusSync(DescribeIpStatusRequest req)
        {
            return InternalRequestAsync<DescribeIpStatusResponse>(req, "DescribeIpStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ECDN融合CDN后，接口都用CDN的，此接口已经废弃
        /// 
        /// 查询刷新接口的用量配额。
        /// 
        /// >?  若您的业务已迁移至 CDN 控制台，请参考<a href="https://cloud.tencent.com/document/api/228/41956"> CDN 接口文档</a>，使用  CDN 相关API 进行操作。
        /// </summary>
        /// <param name="req"><see cref="DescribePurgeQuotaRequest"/></param>
        /// <returns><see cref="DescribePurgeQuotaResponse"/></returns>
        public Task<DescribePurgeQuotaResponse> DescribePurgeQuota(DescribePurgeQuotaRequest req)
        {
            return InternalRequestAsync<DescribePurgeQuotaResponse>(req, "DescribePurgeQuota");
        }

        /// <summary>
        /// ECDN融合CDN后，接口都用CDN的，此接口已经废弃
        /// 
        /// 查询刷新接口的用量配额。
        /// 
        /// >?  若您的业务已迁移至 CDN 控制台，请参考<a href="https://cloud.tencent.com/document/api/228/41956"> CDN 接口文档</a>，使用  CDN 相关API 进行操作。
        /// </summary>
        /// <param name="req"><see cref="DescribePurgeQuotaRequest"/></param>
        /// <returns><see cref="DescribePurgeQuotaResponse"/></returns>
        public DescribePurgeQuotaResponse DescribePurgeQuotaSync(DescribePurgeQuotaRequest req)
        {
            return InternalRequestAsync<DescribePurgeQuotaResponse>(req, "DescribePurgeQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribePurgeTasks 用于查询刷新任务提交历史记录及执行进度。
        /// 
        /// >?  若您的业务已迁移至 CDN 控制台，请参考<a href="https://cloud.tencent.com/document/api/228/37873"> CDN 接口文档</a>，使用  CDN 相关API 进行操作。
        /// </summary>
        /// <param name="req"><see cref="DescribePurgeTasksRequest"/></param>
        /// <returns><see cref="DescribePurgeTasksResponse"/></returns>
        public Task<DescribePurgeTasksResponse> DescribePurgeTasks(DescribePurgeTasksRequest req)
        {
            return InternalRequestAsync<DescribePurgeTasksResponse>(req, "DescribePurgeTasks");
        }

        /// <summary>
        /// DescribePurgeTasks 用于查询刷新任务提交历史记录及执行进度。
        /// 
        /// >?  若您的业务已迁移至 CDN 控制台，请参考<a href="https://cloud.tencent.com/document/api/228/37873"> CDN 接口文档</a>，使用  CDN 相关API 进行操作。
        /// </summary>
        /// <param name="req"><see cref="DescribePurgeTasksRequest"/></param>
        /// <returns><see cref="DescribePurgeTasksResponse"/></returns>
        public DescribePurgeTasksResponse DescribePurgeTasksSync(DescribePurgeTasksRequest req)
        {
            return InternalRequestAsync<DescribePurgeTasksResponse>(req, "DescribePurgeTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ECDN融合CDN后，接口都用CDN的，此接口已经废弃
        /// 
        /// PurgePathCache 用于批量刷新目录缓存，一次提交将返回一个刷新任务id。
        /// 
        /// >?  若您的业务已迁移至 CDN 控制台，请参考<a href="	https://cloud.tencent.com/document/api/570/42475"> CDN 接口文档</a>，使用  CDN 相关API 进行操作。
        /// </summary>
        /// <param name="req"><see cref="PurgePathCacheRequest"/></param>
        /// <returns><see cref="PurgePathCacheResponse"/></returns>
        public Task<PurgePathCacheResponse> PurgePathCache(PurgePathCacheRequest req)
        {
            return InternalRequestAsync<PurgePathCacheResponse>(req, "PurgePathCache");
        }

        /// <summary>
        /// ECDN融合CDN后，接口都用CDN的，此接口已经废弃
        /// 
        /// PurgePathCache 用于批量刷新目录缓存，一次提交将返回一个刷新任务id。
        /// 
        /// >?  若您的业务已迁移至 CDN 控制台，请参考<a href="	https://cloud.tencent.com/document/api/570/42475"> CDN 接口文档</a>，使用  CDN 相关API 进行操作。
        /// </summary>
        /// <param name="req"><see cref="PurgePathCacheRequest"/></param>
        /// <returns><see cref="PurgePathCacheResponse"/></returns>
        public PurgePathCacheResponse PurgePathCacheSync(PurgePathCacheRequest req)
        {
            return InternalRequestAsync<PurgePathCacheResponse>(req, "PurgePathCache")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// PurgeUrlsCache 用于批量刷新Url，一次提交将返回一个刷新任务id。
        /// 
        /// >?  若您的业务已迁移至 CDN 控制台，请参考<a href="https://cloud.tencent.com/document/api/228/37870"> CDN 接口文档</a>，使用  CDN 相关API 进行操作。
        /// </summary>
        /// <param name="req"><see cref="PurgeUrlsCacheRequest"/></param>
        /// <returns><see cref="PurgeUrlsCacheResponse"/></returns>
        public Task<PurgeUrlsCacheResponse> PurgeUrlsCache(PurgeUrlsCacheRequest req)
        {
            return InternalRequestAsync<PurgeUrlsCacheResponse>(req, "PurgeUrlsCache");
        }

        /// <summary>
        /// PurgeUrlsCache 用于批量刷新Url，一次提交将返回一个刷新任务id。
        /// 
        /// >?  若您的业务已迁移至 CDN 控制台，请参考<a href="https://cloud.tencent.com/document/api/228/37870"> CDN 接口文档</a>，使用  CDN 相关API 进行操作。
        /// </summary>
        /// <param name="req"><see cref="PurgeUrlsCacheRequest"/></param>
        /// <returns><see cref="PurgeUrlsCacheResponse"/></returns>
        public PurgeUrlsCacheResponse PurgeUrlsCacheSync(PurgeUrlsCacheRequest req)
        {
            return InternalRequestAsync<PurgeUrlsCacheResponse>(req, "PurgeUrlsCache")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ECDN融合CDN后，接口都用CDN的，此接口已经废弃
        /// 
        /// 本接口（StartEcdnDomain）用于启用加速域名，待启用域名必须处于已下线状态。
        /// 
        /// >?  若您的业务已迁移至 CDN 控制台，请参考<a href="https://cloud.tencent.com/document/product/228/41121"> CDN 接口文档</a>，使用  CDN 相关API 进行操作。
        /// </summary>
        /// <param name="req"><see cref="StartEcdnDomainRequest"/></param>
        /// <returns><see cref="StartEcdnDomainResponse"/></returns>
        public Task<StartEcdnDomainResponse> StartEcdnDomain(StartEcdnDomainRequest req)
        {
            return InternalRequestAsync<StartEcdnDomainResponse>(req, "StartEcdnDomain");
        }

        /// <summary>
        /// ECDN融合CDN后，接口都用CDN的，此接口已经废弃
        /// 
        /// 本接口（StartEcdnDomain）用于启用加速域名，待启用域名必须处于已下线状态。
        /// 
        /// >?  若您的业务已迁移至 CDN 控制台，请参考<a href="https://cloud.tencent.com/document/product/228/41121"> CDN 接口文档</a>，使用  CDN 相关API 进行操作。
        /// </summary>
        /// <param name="req"><see cref="StartEcdnDomainRequest"/></param>
        /// <returns><see cref="StartEcdnDomainResponse"/></returns>
        public StartEcdnDomainResponse StartEcdnDomainSync(StartEcdnDomainRequest req)
        {
            return InternalRequestAsync<StartEcdnDomainResponse>(req, "StartEcdnDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ECDN融合CDN后，接口都用CDN的，此接口已经废弃
        /// 
        /// 本接口（StopCdnDomain）用于停止加速域名，待停用加速域名必须处于已上线或部署中状态。
        /// 
        /// >?  若您的业务已迁移至 CDN 控制台，请参考<a href="https://cloud.tencent.com/document/product/228/41120"> CDN 接口文档</a>，使用  CDN 相关API 进行操作。
        /// </summary>
        /// <param name="req"><see cref="StopEcdnDomainRequest"/></param>
        /// <returns><see cref="StopEcdnDomainResponse"/></returns>
        public Task<StopEcdnDomainResponse> StopEcdnDomain(StopEcdnDomainRequest req)
        {
            return InternalRequestAsync<StopEcdnDomainResponse>(req, "StopEcdnDomain");
        }

        /// <summary>
        /// ECDN融合CDN后，接口都用CDN的，此接口已经废弃
        /// 
        /// 本接口（StopCdnDomain）用于停止加速域名，待停用加速域名必须处于已上线或部署中状态。
        /// 
        /// >?  若您的业务已迁移至 CDN 控制台，请参考<a href="https://cloud.tencent.com/document/product/228/41120"> CDN 接口文档</a>，使用  CDN 相关API 进行操作。
        /// </summary>
        /// <param name="req"><see cref="StopEcdnDomainRequest"/></param>
        /// <returns><see cref="StopEcdnDomainResponse"/></returns>
        public StopEcdnDomainResponse StopEcdnDomainSync(StopEcdnDomainRequest req)
        {
            return InternalRequestAsync<StopEcdnDomainResponse>(req, "StopEcdnDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ECDN融合CDN后，接口都用CDN的，此接口已经废弃
        /// 
        /// 本接口（UpdateDomainConfig）用于更新ECDN加速域名配置信息。
        /// 注意：如果需要更新复杂类型的配置项，必须传递整个对象的所有属性，未传递的属性将使用默认值。建议通过查询接口获取配置属性后，直接修改后传递给本接口。Https配置由于证书的特殊性，更新时不用传递证书和密钥字段。
        /// 
        /// >?  若您的业务已迁移至 CDN 控制台，请参考<a href="https://cloud.tencent.com/document/product/228/41116"> CDN 接口文档</a>，使用  CDN 相关API 进行操作。
        /// </summary>
        /// <param name="req"><see cref="UpdateDomainConfigRequest"/></param>
        /// <returns><see cref="UpdateDomainConfigResponse"/></returns>
        public Task<UpdateDomainConfigResponse> UpdateDomainConfig(UpdateDomainConfigRequest req)
        {
            return InternalRequestAsync<UpdateDomainConfigResponse>(req, "UpdateDomainConfig");
        }

        /// <summary>
        /// ECDN融合CDN后，接口都用CDN的，此接口已经废弃
        /// 
        /// 本接口（UpdateDomainConfig）用于更新ECDN加速域名配置信息。
        /// 注意：如果需要更新复杂类型的配置项，必须传递整个对象的所有属性，未传递的属性将使用默认值。建议通过查询接口获取配置属性后，直接修改后传递给本接口。Https配置由于证书的特殊性，更新时不用传递证书和密钥字段。
        /// 
        /// >?  若您的业务已迁移至 CDN 控制台，请参考<a href="https://cloud.tencent.com/document/product/228/41116"> CDN 接口文档</a>，使用  CDN 相关API 进行操作。
        /// </summary>
        /// <param name="req"><see cref="UpdateDomainConfigRequest"/></param>
        /// <returns><see cref="UpdateDomainConfigResponse"/></returns>
        public UpdateDomainConfigResponse UpdateDomainConfigSync(UpdateDomainConfigRequest req)
        {
            return InternalRequestAsync<UpdateDomainConfigResponse>(req, "UpdateDomainConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}

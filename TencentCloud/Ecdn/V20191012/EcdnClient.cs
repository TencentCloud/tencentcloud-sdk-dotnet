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
       private const string sdkVersion = "SDK_NET_3.0.1237";

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
        /// ECDN平台下线，接口开始预下线处理
        /// 
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
        /// ECDN平台下线，接口开始预下线处理
        /// 
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
        /// ECDN平台下线，接口开始预下线处理
        /// 
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
        /// ECDN平台下线，接口开始预下线处理
        /// 
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
        /// ECDN平台下线，接口开始预下线处理
        /// 
        /// 本接口（DescribeEcdnDomainLogs）用于查询域名的访问日志下载地址。
        /// </summary>
        /// <param name="req"><see cref="DescribeEcdnDomainLogsRequest"/></param>
        /// <returns><see cref="DescribeEcdnDomainLogsResponse"/></returns>
        public Task<DescribeEcdnDomainLogsResponse> DescribeEcdnDomainLogs(DescribeEcdnDomainLogsRequest req)
        {
            return InternalRequestAsync<DescribeEcdnDomainLogsResponse>(req, "DescribeEcdnDomainLogs");
        }

        /// <summary>
        /// ECDN平台下线，接口开始预下线处理
        /// 
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
        /// ECDN平台下线，接口开始预下线处理
        /// 
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
        /// ECDN平台下线，接口开始预下线处理
        /// 
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
        /// ECDN平台下线，接口开始预下线处理
        /// 
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
        /// ECDN平台下线，接口开始预下线处理
        /// 
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
        /// ECDN平台下线，接口开始预下线处理
        /// 
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
        /// ECDN平台下线，接口开始预下线处理
        /// 
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
        /// ECDN即将下线，如需要动态加速请使用EdgeOne
        /// 
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
        /// ECDN即将下线，如需要动态加速请使用EdgeOne
        /// 
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
        /// ECDN即将下线，如需要动态加速请使用EdgeOne
        /// 
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
        /// ECDN即将下线，如需要动态加速请使用EdgeOne
        /// 
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

    }
}
